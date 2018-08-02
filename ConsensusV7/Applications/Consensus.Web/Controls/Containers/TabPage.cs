using Consensus.UserInterface;
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
    ///     Represents an individual page within a tab control.
    /// </summary>
    [ParseChildren(false)]
    public class TabPage : WebControl, IHaveCustomTitle, ICanBeHidden, IHaveCustomIcon, ICustomFieldContainer
    {
        #region fields

        /// <summary>
        ///     The tab control in which the page is displayed.
        /// </summary>
        private TabControl _tabControl;

        /// <summary>
        ///     The on-screen header for the tab page.
        /// </summary>
        private HtmlGenericControl _heading;

        /// <summary>
        ///     The on-screen header link for the tab page.
        /// </summary>
        private HtmlGenericControl _headingLink;

        /// <summary>
        ///     The text displayed in the header link.
        /// </summary>
        private HtmlGenericControl _headingText;

        /// <summary>
        ///     The icon displayed in the header link.
        /// </summary>
        private HtmlGenericControl _headingIcon;

        /// <summary>
        ///     The printable header for the tab page.
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

        /// <summary>
        ///     The content wrapper for the tab page.
        /// </summary>
        private HtmlGenericControl _content;

        /// <summary>
        ///     Specifies whether the field is hidden.
        /// </summary>
        private ConfigurableBoolean _isHidden = ConfigurableBoolean.False;

        /// <summary>
        ///     Identifies where custom fields will be inserted in the panel
        /// </summary>
        private Panel _customFieldInsertPoint;

        #endregion

        #region properties

        /// <summary>
        ///     Gets the HTML element that is rendered for this control.
        /// </summary>
        protected override HtmlTextWriterTag TagKey
        {
            get { return HtmlTextWriterTag.Div; }
        }
        
        /// <summary>
        ///    Gets the tab control in which the page is displayed.
        /// </summary>
        public TabControl TabControl
        {
            get
            {
                if (_tabControl == null)
                {
                    Control parent = this;
                    while (parent != null && !(parent is TabControl))
                        parent = parent.Parent;

                    _tabControl = parent as TabControl;
                }
                return _tabControl;
            }
        }

        /// <summary>
        ///    Gets the on-screen header for the tab page.
        /// </summary>
        internal HtmlGenericControl Heading
        {
            get
            {
                if (_heading == null)
                    _heading = new HtmlGenericControl("li");

                return _heading;
            }
        }

        /// <summary>
        ///    Gets the on-screen header link for the tab page.
        /// </summary>
        protected HtmlGenericControl HeadingLink
        {
            get
            {
                if (_headingLink == null)
                    _headingLink = new HtmlGenericControl("a");

                return _headingLink;
            }
        }

        /// <summary>
        ///    Gets the text displayed in the header link.
        /// </summary>
        protected HtmlGenericControl HeadingText
        {
            get
            {
                if (_headingText == null)
                    _headingText = new HtmlGenericControl("span");

                return _headingText;
            }
        }

        /// <summary>
        ///    Gets the icon displayed in the header link.
        /// </summary>
        protected HtmlGenericControl HeadingIcon
        {
            get
            {
                if (_headingIcon == null)
                    _headingIcon = new HtmlGenericControl("i");

                return _headingIcon;
            }
        }

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
        ///     Gets the content wrapper for the tab page.
        /// </summary>
        protected HtmlGenericControl Content
        {
            get
            {
                if (_content == null)
                    _content = new HtmlGenericControl("div");

                return _content;
            }
        }

        /// <summary>
        ///    Gets or sets the icon of the tab page.
        /// </summary>
        public String Icon
        {
            get
            {
                return this.HeadingIcon.Attributes["class"] == null ? null : this.HeadingIcon.Attributes["class"].Substring(7);
            }
            set
            {
                this.HeadingIcon.Attributes["class"] = value.TrimOrNullify() == null ? null : "icons8-" + value;
                this.PrintableIcon.Attributes["class"] = value.TrimOrNullify() == null ? null : "icons8-" + value;
            }
        }

        /// <summary>
        ///    Gets or sets the title of the tab page.
        /// </summary>
        public String Title
        {
            get
            {
                return this.HeadingText.InnerText;
            }
            set
            {
                this.HeadingText.InnerText = value;
                this.PrintableText.InnerText = value;
            }
        }

        /// <summary>
        ///     Gets the ordinal position of the page, within the tab control.
        /// </summary>
        public Int32 PageIndex
        {
            get { return this.TabControl == null ? -1 : this.TabControl.Pages.IndexOf(this); }
        }

        /// <summary>
        ///     Gets or sets a value that indicates whether the control is rendered.
        /// </summary>
        public override Boolean Visible
        {
            get { return base.Visible && this.Heading.Visible; }
            set { base.Visible = value; this.Heading.Visible = value; }
        }

        /// <summary>
        ///     Gets or sets whether the page is hidden.
        /// </summary>
        public ConfigurableBoolean IsHidden
        {
            get { return _isHidden; }
            set { _isHidden = value; }
        }

        /// <summary>
        ///     Identifies where custom fields will be inserted in the panel
        /// </summary>
        public Panel CustomFieldInsertPoint
        {
            get
            {
                if (_customFieldInsertPoint == null)
                {
                    _customFieldInsertPoint = new Customisation.CustomFieldInsertPointDiv();
                }
                return _customFieldInsertPoint;
            }
        }

        /// <summary>
        ///     Can be set to true to prevent custom fields being added to an individual container.
        /// </summary>
        public bool BlockCustomFields { get; set; }

        #endregion

        #region page cycle

        protected override void OnInit(EventArgs e)
        {
            base.OnInit(e);

            // Move all child controls into the content wrapper.
            Control[] controls = this.Controls.OfType<Control>().ToArray();
            controls.Execute(this.Content.Controls.Add);

            // Add the header to the tab page.
            this.Heading.Controls.Add(this.HeadingLink);
            this.HeadingLink.Controls.Add(this.HeadingIcon);
            this.HeadingLink.Controls.Add(this.HeadingText);
            this.Controls.Add(this.PrintableHead);
            this.PrintableHead.Controls.Add(this.PrintableIcon);
            this.PrintableHead.Controls.Add(this.PrintableText);
            this.Controls.Add(this.Content);
            this.Controls.Add(CustomFieldInsertPoint);
        }

        protected override void OnPreRender(EventArgs e)
        {
            base.OnPreRender(e);
            if (this.TabControl != null)
            {
                switch (this.TabControl.Mode)
                {
                    case TabControlModes.Tabbed:
                        this.Heading.Attributes.Add("data-tooltip", this.ToolTip);
                        this.Heading.Attributes.Add("class", "nav-item");
                        this.HeadingLink.Attributes.Add("aria-controls", this.ClientID);
                        this.HeadingLink.Attributes.Add("class", "nav-link " + (this == this.TabControl.SelectedPage ? "active" : ""));
                        this.HeadingLink.Attributes.Add("data-toggle", "tab");
                        this.HeadingLink.Attributes.Add("href", "#" + this.ClientID);
                        this.HeadingLink.Attributes.Add("role", "tab");
                        this.PrintableHead.Attributes.Add("class", "consensus-tab-heading visible-print-block");
                        this.Attributes.Add("class", "tab-pane fade " + (this == this.TabControl.SelectedPage ? " show active" : ""));
                        this.Attributes.Add("role", "tabpanel");
                        break;
                    case TabControlModes.Simple:
                        this.Attributes.Add("class", "card pb-3");
                        this.PrintableHead.Attributes.Add("class", "card-header bg-secondary h4 py-4 mt-0 mb-4");
                        break;
                }
            }

            if (this.IsHidden == ConfigurableBoolean.True || this.IsHidden == ConfigurableBoolean.TrueEnforced)
            {
                this.Heading.Attributes.Add("hidden", "hidden");
                this.Attributes.Add("hidden", "hidden");
            }
            else
            {
                this.Heading.Attributes.Remove("hidden");
                this.Attributes.Remove("hidden");
            }
        }

        #endregion
    }
}
