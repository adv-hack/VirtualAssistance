using Consensus.Security;
using Consensus.Web.BackOffice.assets.templates;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Consensus.Web.BackOffice
{
    public abstract class BaseStandardPage<TProxy> : BaseStandardPage where TProxy : Proxy
    {
        #region properties

        /// <summary>
        ///     Gets the instance of the API object that is presented within the page.
        /// </summary>
        public abstract TProxy Data
        {
            get;
        }

        /// <summary>
        ///     Gets whether the page is initially rendered in editing mode.
        /// </summary>
        public override Boolean IsEditable
        {
            get { return base.IsEditable || !this.Data.IsPersisted; }
        }

        /// <summary>
        ///     Gets the REST api used for saving the object.
        /// </summary>
        public virtual String SaveUri
        {
            get
            {
                String typeContext = String.Join(".", typeof(TProxy).Namespace.Split('.').Skip(1));
                String relativeUri = String.Format("{0}/{1}", typeContext, typeof(TProxy).Name);
                return relativeUri;
            }
        }

        /// <summary>
        ///     Gets the ID of the object being saved via the REST api
        /// </summary>
        public abstract String SaveId
        {
            get;
        }

        #endregion

        #region page cycle

        protected override void OnPreInit(EventArgs e)
        {
            base.OnPreInit(e);
            //if (!this.CurrentSession.User.HasPermission<TProxy>(UserPermissionActions.Read))
            //    this.TerminateRequest(403, "You do not have permission to access this page.");
            if (this.Data == null)
                this.TerminateRequest(410, "Not Found.");
        }

        protected override void OnInit(EventArgs eventArguments)
        {
            base.OnInit(eventArguments);
            this.PopulateControls();
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);

            Object value;

            if (!BlockCustomFields)
            {
                if (this.GetControlValue(this.Data, "Id", out value) && value != null)
                    PopulateCustomFields(value.ToString());
            }
        }

        protected override void OnPreRender(EventArgs eventArguments)
        {
            // Register the javascript
            base.OnPreRender(eventArguments);

            StandardDetail masterPage = this.Master as StandardDetail;
            if (masterPage != null)
            {
                string dataURI = Data.GetType().FullName.Replace("Consensus.", "").Replace(".", "/");
                if (!dataURI.Equals(this.SaveUri, StringComparison.InvariantCultureIgnoreCase))
                    this.ClientScript.RegisterStartupScript(this.GetType(), "initjs", String.Format("consensus.data.init($('#{0}'), $('#{1}'), '{2}', null, '{3}');", masterPage.EditButton.ClientID, masterPage.SaveButton.ClientID, HttpUtility.JavaScriptStringEncode(this.SaveUri), HttpUtility.JavaScriptStringEncode(this.SaveId)), true);
                else
                    this.ClientScript.RegisterStartupScript(this.GetType(), "initjs", String.Format("consensus.data.init($('#{0}'), $('#{1}'), null, {2}, '{3}');", masterPage.EditButton.ClientID, masterPage.SaveButton.ClientID, RestHandler.Serializer.Serialize(Data), HttpUtility.JavaScriptStringEncode(this.SaveId)), true);
            }
        }

        #endregion

        #region methods

        /// <summary>
        ///     Populates the controls on the screen.
        /// </summary>
        protected virtual void PopulateControls()
        {
        }

        #endregion
    }
}