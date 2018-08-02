using Consensus.Web.Controls;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Consensus.Web.BackOffice
{
    public abstract class BaseControl<TProxy, TKey> : BaseControl<TProxy>
    {
        #region properties

        /// <summary>
        ///     Gets the delegated method for loading the API object that is presented within the page.
        /// </summary>
        public virtual Func<TKey, TProxy> DataLoader
        {
            get { return null; }
        }

        /// <summary>
        ///     Gets the unique identifier for the API object that is presented within the page.
        /// </summary>
        public virtual TKey DataId
        {
            get { return this.Request.QueryString["id"].ConvertTo<TKey>(); }
        }

        #endregion

        #region page cycle

        protected override void OnInit(EventArgs e)
        {
            base.OnInit(e);
            if (this.DataLoader != null && !Object.Equals(this.DataId, default(TKey)))
            {
                this.DataSource = this.DataLoader.Invoke(this.DataId);                
            }
        }

        protected override void OnPreRender(EventArgs e)
        {
            base.OnPreRender(e);
            if (!String.IsNullOrEmpty(this.DataBoundObject))
            {
                BaseInputControl[] inputControls = this.GetControlTree(this).OfType<BaseInputControl>().Where(ctrl => !String.IsNullOrEmpty(ctrl.DataBoundValue)).ToArray();
                PopupField[] popupControls = this.GetControlTree(this).OfType<PopupField>().Where(ctrl => !String.IsNullOrEmpty(ctrl.DataBoundText)).ToArray();
                BaseControl[] userControls = this.GetControlTree(this).OfType<BaseControl>().Where(ctrl => !String.IsNullOrEmpty(ctrl.DataBoundObject)).ToArray();
                inputControls.Execute(ctrl => ctrl.DataBoundValue = this.DataBoundObject + "." + ctrl.DataBoundValue);
                popupControls.Execute(ctrl => ctrl.DataBoundText = this.DataBoundObject + "." + ctrl.DataBoundText);
                userControls.Execute(ctrl => ctrl.DataBoundObject = this.DataBoundObject + "." + ctrl.DataBoundObject);
            }
            if (!String.IsNullOrEmpty(this.DataBoundId))
            {
                this.IdField.DataBoundValue = this.DataBoundId;
                this.Controls.AddAt(0, this.IdField);
            }

            if (Page is GenericPopup)
            {
                GenericPopup popup = Page as GenericPopup;
                if (DataSource == null || Object.Equals(this.DataId, default(TKey)))
                {
                    popup.SetInsertMode();
                }
                else
                {
                    if (popup.Buttons.HasFlag(GenericPopup.ButtonStyle.SendPack))
                    {
                        string parentUrl = DataSource.GetType().FullName.Substring(10).Replace(".", "/");

                        if (!Page.ClientScript.IsStartupScriptRegistered("_sendpack"))
                        {
                            // Matt wanted to see the "Send Pack" option, even if there were no packs available to be sent for the type.
                            //IQueryRunnable packQuery = Query.Create()
                            //    .Select("PACK_TYPE")
                            //    .From(QuerySources.Packs)
                            //    .Where("PARENT_URL", QueryConditionTypes.Equal, parentUrl);

                            //IList<Dictionary<string, object>> results = packQuery.Run();

                            //if (results.Count > 0)
                            //{
                            string sJs = "function sendPack() { consensus.web.sendPack('" + parentUrl + "', " + System.Web.HttpUtility.JavaScriptStringEncode(DataId.ToString(), true) +
                                ", function(){ alert('Pack queued for sending successfully'); }); }";
                            Page.ClientScript.RegisterStartupScript(Page.GetType(), "_sendpack", sJs, true);
                            //}
                        }
                    }
                }
            }
        }

        #endregion

        #region methods

        private IEnumerable<Control> GetControlTree(Control parent)
        {
            List<Control> controls = new List<Control>();
            foreach (Control child in parent.Controls)
            {
                controls.Add(child);
                if (child is UserControl == false)
                    controls.AddRange(this.GetControlTree(child));
            }
            return controls;
        }

        #endregion
    }
}