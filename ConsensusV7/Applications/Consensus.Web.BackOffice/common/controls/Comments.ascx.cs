using Consensus.Web.BackOffice.assets.templates;
using Consensus.Web.Controls;
using Consensus.Searches;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Consensus.Activities;
using System.Reflection;

namespace Consensus.Web.BackOffice.common.controls
{
    public partial class Comments : BaseControl<C4text>
    {
        #region fields

        private string _attachmentParentURL = null;
        private string _attachmentParentId = null;

        #endregion

        #region properties

        public override string DataTypeName
        {
            get
            {
                return "C4text";
            }
        }

        /// <summary>
        ///     The "URL" (in the form container/entity) of the entity to which the attachment is linked.
        /// </summary>
        public string AttachmentParentURL
        {
            get
            {
                if (_attachmentParentURL == null)
                {
                    PropertyInfo dataInfo = this.Page.GetType().GetProperty("Data");
                    if (dataInfo == null)
                    {
                        PropertyInfo controlInfo = this.Page.GetType().GetProperty("Control");
                        if (controlInfo != null)
                        {
                            Control popupControl = controlInfo.GetValue(this.Page) as Control;
                            if (popupControl != null)
                            {
                                dataInfo = popupControl.GetType().GetProperty("DataSource");
                            }
                        }
                    }
                    if (dataInfo != null)
                        _attachmentParentURL = dataInfo.PropertyType.FullName.Replace("Consensus.", "").Replace(".", "/");
                }
                return _attachmentParentURL;

            }
            set
            {
                _attachmentParentURL = value;
            }
        }

        /// <summary>
        ///     the ID of the entity to which the attachment is linked.
        /// </summary>
        public string AttachmentParentId
        {
            get
            {
                if (_attachmentParentId == null)
                {
                    PropertyInfo dataInfo = this.Page.GetType().GetProperty("Data");
                    Control dataHolder = this.Page;
                    if (dataInfo == null)
                    {
                        PropertyInfo controlInfo = this.Page.GetType().GetProperty("Control");
                        if (controlInfo != null)
                        {
                            Control popupControl = controlInfo.GetValue(this.Page) as Control;
                            if (popupControl != null)
                            {
                                dataInfo = popupControl.GetType().GetProperty("DataSource");
                                dataHolder = popupControl;
                            }
                        }
                    }
                    if (dataInfo != null)
                    {
                        Proxy pageData = (Proxy)dataInfo.GetValue(dataHolder);
                        if (pageData != null)
                        {
                            Type pageDataType = pageData.GetType();
                            _attachmentParentId = Convert.ToString(pageDataType.GetProperty("Id").GetValue(pageData));
                        }
                    }
                }
                return _attachmentParentId;


            }
            set
            {
                _attachmentParentId = value;
            }
        }

        public int CanEdit
        {
            get
            {
                int canEdit = -1; // Never
                if (this.CurrentSession != null)
                {
                    if (this.CurrentSession.User.SysAdmin.ConvertTo<Boolean>())
                    {
                        canEdit = 0; // Always (I'm a system admin)
                    }
                    else
                    {
                        canEdit = 1; // Ordinary user (need to check modified date/time)
                    }
                }
                return canEdit;
            }
        }

        public int UserId
        {
            get
            {
                return (this.CurrentSession != null) ? this.CurrentSession.User.Id : 0;
            }
        }

        #endregion
    }
}