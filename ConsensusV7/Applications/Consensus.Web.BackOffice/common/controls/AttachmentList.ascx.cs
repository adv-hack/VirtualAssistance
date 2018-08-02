using Consensus.Web.BackOffice.assets.templates;
using Consensus.Web.Controls;
using Consensus.Searches;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Reflection;

namespace Consensus.Web.BackOffice.common.controls
{
    public partial class AttachmentList : BaseListControl
    {
        private string _attachmentParentURL = null;
        private string _attachmentParentId = null;

        /// <summary>
        ///     When set, shows the "Pack category", "Resource type" and "Visibility" fields. These are hidden by default.
        /// </summary>
        public bool ShowBookingRelatedFields { get; set; }
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
                        if (controlInfo != null) {
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

        public override object DataSource
        {
            get
            {
                //return Query.Create()
                //    .Select("ATT_ID")
                //    .Select("ATT_MIME")
                //    .Select("ATT_FILE_NAME")
                //    .Select("ATT_ADD_BY")
                //    .Select("ATT_ADD_DATE")
                //    .Select("ATT_CATEGORY")
                //    .Select("LZC_CATEGORY_TITLE")
                //    .Select("ATT_VISIBILITY")
                //    .Select("ATT_WEB")
                //    .Select("ATT_ORDER_NUM")
                //    .Select("uri")
                //    .From(QuerySources.Attachments)
                //    .Where("ATT_TABLE_URL", QueryConditionTypes.Equal, this.AttachmentParentURL)
                //    .And("ATT_RECORD_ID", QueryConditionTypes.Equal, this.AttachmentParentId)
                //    .OrderBy("ATT_ORDER_NUM", true)
                //    .ThenBy("ATT_FILE_NAME", true);
                return Common.Attachment.GetListQuery(this.AttachmentParentURL, this.AttachmentParentId);
            }
        }

        public override DataTable DataTable
        {
            get { return this.AttachmentListResult; }
        }

        public override string DataTypeName
        {
            get { return "Attachment"; }
        }
        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);

            this.DataTable.Json = "{ uri: \"common/attachment\", TableUrl: '" + this.AttachmentParentURL + "', RecordId: \"" + this.AttachmentParentId + "\" }";
            this.DataTable.Url = "~/GenericPopup.aspx?context=common&control=attachmentdetail&id={{Id}}" 
                + "&parenturl=" + HttpUtility.UrlPathEncode(this.AttachmentParentURL) 
                + "&parentid=" + HttpUtility.UrlPathEncode(this.AttachmentParentId)
                + "&bookingfields=" + (ShowBookingRelatedFields ? "1" : "0");

            if (!ShowBookingRelatedFields)
            {
                this.ColCategory.Visible = false;
                this.ColCategory.Exportable = false;
                this.ColResourceType.Visible = false;
                this.ColResourceType.Exportable = false;
                this.ColVisibility.Visible = false;
                this.ColVisibility.Exportable = false;
            }
        }

        
    }
}