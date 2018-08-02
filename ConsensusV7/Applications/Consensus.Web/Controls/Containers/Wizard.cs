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
    ///     Represents a wizard
    /// </summary>
    [ParseChildren(false)]
    public class Wizard : WebControl
    {
        #region fields

        /// <summary>
        ///     The collection of pages displayed in the wizard.
        /// </summary>
        private WizardPage[] _pages;

        /// <summary>
        ///     The header section for the wizard.
        /// </summary>
        private HtmlGenericControl _header;

        /// <summary>
        ///     The detail section for the wizard.
        /// </summary>
        private HtmlGenericControl _detail;

        /// <summary>
        ///     The footer section for the wizard.
        /// </summary>
        private HtmlGenericControl _footer;

        #endregion

        #region properties

        /// <summary>
        ///    Gets the collection of pages displayed in the wizard.
        /// </summary>
        protected WizardPage[] Pages
        {
            get
            {
                if (_pages == null)
                    _pages = this.Controls.OfType<WizardPage>().ToArray();

                return _pages;
            }
        }

        /// <summary>
        ///    Gets the header section for the wizard;
        /// </summary>
        protected HtmlGenericControl Header
        {
            get
            {
                if (_header == null)
                    _header = new HtmlGenericControl("header");

                return _header;
            }
        }

        /// <summary>
        ///    Gets the detail section for the wizard;
        /// </summary>
        protected HtmlGenericControl Detail
        {
            get
            {
                if (_detail == null)
                    _detail = new HtmlGenericControl("main");

                return _detail;
            }
        }

        /// <summary>
        ///    Gets the footer section for the wizard;
        /// </summary>
        protected HtmlGenericControl Footer
        {
            get
            {
                if (_footer == null)
                    _footer = new HtmlGenericControl("footer");

                return _footer;
            }
        }

        #endregion

        #region life cycle

        protected override void OnInit(EventArgs e)
        {
            base.OnInit(e);
            this.CssClass += "wizard";

            // Move all wizard pages to the detail section
            foreach (WizardPage page in this.Pages)
                this.Detail.Controls.Add(page);

            // Apply the wizard control hierarchy.
            this.Controls.Clear();
            this.Controls.Add(this.Header);
            this.Controls.Add(this.Detail);
            this.Controls.Add(this.Footer);

            // Create the wizard footer
            this.Footer.Controls.Add(this.CreateButton("delete_sign", "Cancel", "warning", "button",true, "icon-white"));
            this.Footer.Controls.Add(this.CreateButton("arrows_long_left", "Back", "default", "button",true, "icon-black"));
            this.Footer.Controls.Add(this.CreateButton("arrows_long_right", "Next", "primary", "", true, "icon-white"));
        }

        protected override void OnLoad(EventArgs e)
        {
            // Create the wizard header (this occurs during on-load to ensure client identifiers have been calculated)
            base.OnLoad(e);
            foreach (WizardPage page in this.Pages)
                this.CreateHeader(page);
        }

        protected override void OnPreRender(EventArgs e)
        {
            base.OnPreRender(e);

            // Register the javascript client instance.
            String javascript = String.Format("var {0} = new consensus.web.wizard({{ element: '{0}' }});", this.ClientID); 
            this.Page.ClientScript.RegisterStartupScript(this.GetType(), this.UniqueID, javascript, true);

            // Ensure all pages (except the first) are hidden.
            this.Pages.Skip(1).Execute(page => page.Attributes["class"] += "hidden");
        }

        #endregion

        #region methods

        private HtmlGenericControl CreateHeader(WizardPage page)
        {
            // Ensure that the page has a unique identifier.
            if (String.IsNullOrEmpty(page.ID))
                page.ID = "page_" + Guid.NewGuid().ToString();

            // Create a wrapping element to show the page in the header
            HtmlGenericControl wrapper = new HtmlGenericControl("div");
            wrapper.Attributes["class"] = page.Visible ? "" : "hidden";
            wrapper.Attributes["data-page"] = page.ClientID;
            this.Header.Controls.Add(wrapper);

            // Create the text element to show the title of the page
            HtmlGenericControl label = new HtmlGenericControl("span");
            label.InnerText = page.Title;
            wrapper.Controls.Add(label);

            return wrapper;
        }

        private HtmlGenericControl CreateButton(String icon, String text, String style, String type, Boolean useSvg, String svgClass)
        {
            HtmlGenericControl iconElement = new HtmlGenericControl("span");
            if (useSvg)
            {
                HtmlGenericControl svgElement = new HtmlGenericControl("svg");
                svgElement.Attributes["class"] = "icon " + svgClass;
                HtmlGenericControl useElement = new HtmlGenericControl("use");
                useElement.Attributes["href"] = "#" + icon;
                svgElement.Controls.Add(useElement);

                iconElement.Attributes["aria-hidden"] = "true";
                iconElement.Controls.Add(svgElement);
            }
            else
            {
                iconElement.Attributes["class"] = "icons8-" + icon;
                iconElement.Attributes["aria-hidden"] = "true";
            }

            HtmlGenericControl textElement = new HtmlGenericControl("span");
            textElement.Attributes["class"] = "text";
            textElement.InnerText = text;

            LiteralControl spacer = new LiteralControl();
            spacer.Text = Environment.NewLine;

            HtmlGenericControl buttonElement = new HtmlGenericControl("button");
            buttonElement.Attributes["class"] = "btn btn-" + style;
            buttonElement.Attributes["type"] = type;
            if (text.Equals("Next"))
            {
                buttonElement.Controls.Add(textElement);
                buttonElement.Controls.Add(spacer);
                buttonElement.Controls.Add(iconElement);
            }
            else
            {
                buttonElement.Controls.Add(iconElement);
                buttonElement.Controls.Add(spacer);
                buttonElement.Controls.Add(textElement);
            }
            
            
            
            return buttonElement;
        }

        #endregion
    }
}
