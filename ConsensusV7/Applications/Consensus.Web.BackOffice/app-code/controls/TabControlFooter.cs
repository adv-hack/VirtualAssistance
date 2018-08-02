using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;

namespace Consensus.Web.Controls
{
    /// <summary>
    ///     Renders a footer card with title, containing tabs.
    /// </summary>
    [ParseChildren(true)]
    public class TabControlFooter : TabControl
    {
        #region fields

        /// <summary>
        ///     The printable header for the footer card.
        /// </summary>
        private HtmlGenericControl _printableHead;

        /// <summary>
        ///     The text displayed in the printable header.
        /// </summary>
        private HtmlGenericControl _printableText;

        /// <summary>
        ///     The icon displayed in the printable header.
        /// </summary>
        private HtmlGenericControl _printableIcon;

        #endregion

        #region properties

        /// <summary>
        ///    Gets the printable header for the tab page.
        /// </summary>
        protected HtmlGenericControl PrintableHead
        {
            get
            {
                if (_printableHead == null)
                    _printableHead = new HtmlGenericControl("h4");

                return _printableHead;
            }
        }

        /// <summary>
        ///    Gets the text displayed in the header link.
        /// </summary>
        protected HtmlGenericControl PrintableText
        {
            get
            {
                if (_printableText == null)
                    _printableText = new HtmlGenericControl("span");

                return _printableText;
            }
        }

        /// <summary>
        ///    Gets the icon displayed in the header link.
        /// </summary>
        protected HtmlGenericControl PrintableIcon
        {
            get
            {
                if (_printableIcon == null)
                    _printableIcon = new HtmlGenericControl("i");

                return _printableIcon;
            }
        }

        /// <summary>
        ///    Gets or sets the title of the footer
        /// </summary>
        public String Title
        {
            get
            {
                //return this.HeadingText.InnerText;
                return this.PrintableText.InnerText;
            }
            set
            {
                //this.HeadingText.InnerText = value;
                this.PrintableText.InnerText = value;
            }
        }

        #endregion

        #region page cycle

        protected override void OnInit(EventArgs e)
        {
            // Add the header to the tab page.
            //this.Heading.Controls.Add(this.HeadingLink);
            //this.HeadingLink.Controls.Add(this.HeadingIcon);
            //this.HeadingLink.Controls.Add(this.HeadingText);
            this.Controls.Add(this.PrintableHead);
            this.PrintableHead.Controls.Add(this.PrintableIcon);
            this.PrintableHead.Controls.Add(this.PrintableText);

            base.OnInit(e);
        }

        protected override void OnPreRender(EventArgs e)
        {
            base.OnPreRender(e);

            this.Attributes.Add("class", "con-footer card pb-3");
            this.PrintableHead.Attributes.Add("class", "card-header bg-secondary h4 py-4 mt-0 mb-4");            
        }

        #endregion
    }
}
