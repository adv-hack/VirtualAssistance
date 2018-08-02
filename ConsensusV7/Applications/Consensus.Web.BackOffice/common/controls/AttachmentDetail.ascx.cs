using Consensus.Common;
using Consensus.Web.BackOffice.assets.templates;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Consensus.Web.BackOffice.common.controls
{
    public partial class AttachmentDetail : BaseControl<Attachment, string>
    {
        public bool ShowBookingRelatedFields
        {
            get
            {
                return (Page.Request.QueryString["bookingfields"] == "1");
            }
        }
        public string AttachmentParentURL
        {
            get
            {
                return Page.Request.QueryString["parenturl"];
            }
        }

        public string AttachmentParentId
        {
            get
            {
                return Page.Request.QueryString["parentid"];
            }
        }
        public override String DataTypeName
        {
            get { return "Attachment"; }
        }

        /// <summary>
        ///     Gets the delegated method for loading the API object that is presented within the page.
        /// </summary>
        public override Func<string, Attachment> DataLoader
        {
            get { return Attachment.FetchById; }
        }

        protected override void OnInit(EventArgs e)
        {
            base.OnInit(e);
            if (ShowBookingRelatedFields)
            {
                this.ResourceType.DataSource = Common.LearningZoneCategories.FetchAll();
            }
            else
            {
                this.ResourceType.Visible = false;
                this.Visibility.Visible = false;
                this.Category.Visible = false;
            }
        }

        protected override void OnPreRender(EventArgs e)
        {
            base.OnPreRender(e);

            if (string.IsNullOrEmpty(this.DataId))
            {
                // Hide the (non editable) file name
                this.editFile.Visible = false;
                this.FilePicker.Parameters.Add("tableURL", AttachmentParentURL);
                this.FilePicker.Parameters.Add("recordId", AttachmentParentId);
                this.WebEnabled.FieldValue = true;
            }
            else
            {
                // Hide the file picker/drop area
                this.newFile.Visible = false;
                this.FileName.FieldValue = this.DataSource.FileName;
            }
        }
    }
}