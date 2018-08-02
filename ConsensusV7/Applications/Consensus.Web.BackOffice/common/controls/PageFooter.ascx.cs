using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Consensus.Web.Customisation;

namespace Consensus.Web.BackOffice.common.controls
{
    public partial class PageFooter : System.Web.UI.UserControl, IHaveNoChildren
    {
        /// <summary>
        ///     When set, shows more booking related fields on attachments. These are hidden by default.
        /// </summary>
        public bool ShowAttachmentBookingFields { get; set; }
        //public bool HideSummary { get; set; }
        public bool HideAttachments { get; set; }
        public bool HideComments { get; set; }

       

        protected override void OnPreRender(EventArgs e)
        {
            base.OnPreRender(e);
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);

            //if (this.HideSummary)
            //    this.tabSummary.Visible = false;

            if (this.HideAttachments)
            {
                this.tabAttachments.Visible = false;
            }
            else
            {
                this.conAttachments.ShowBookingRelatedFields = ShowAttachmentBookingFields;
            }

            if (this.HideComments)
                this.tabComments.Visible = false;

            BaseStandardPage basePage = (Page as BaseStandardPage);
            if (basePage != null)
            {
                basePage.PopulateLink(this.tabControlFooter);
            }

        }
    }
}