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
    ///     Renders a tabbable collection of pages.
    /// </summary>
    [ParseChildren(true)]
    public class TabControl : WebControl
    {
        #region fields

        /// <summary>
        ///     The collection of tabbable pages.
        /// </summary>
        private List<TabPage> _pages;

        /// <summary>
        ///     The HTML element used to render the tab control header.
        /// </summary>
        private HtmlGenericControl _header;

        /// <summary>
        ///     The HTML element used to contain the individual tabbable pages.
        /// </summary>
        private HtmlGenericControl _content;

        /// <summary>
        ///     A hidden input to hold the currently selected tab index.
        /// </summary>
        private HtmlInputHidden _selectedTabIndex;

        /// <summary>
        ///     The rendering mode for the tab control.
        /// </summary>
        private TabControlModes _mode;

        /// <summary>
        ///     Sets the minimum height for the tabbed pages.
        /// </summary>
        private Unit _height;

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
        ///    Gets the HTML element used to render the tab control header.
        /// </summary>
        protected HtmlGenericControl Header
        {
            get
            {
                if (_header == null)
                    _header = new HtmlGenericControl("ul");

                return _header;
            }
        }

        /// <summary>
        ///    Gets the HTML element used to contain the individual tabbable pages.
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
        ///    Hidden control holding the currently selected tab index.
        /// </summary>
        protected HtmlInputHidden SelectedTabIndex
        {
            get
            {
                if (_selectedTabIndex == null)
                {
                    _selectedTabIndex = new HtmlInputHidden();
                    _selectedTabIndex.ID = this.ID + "Index";
                }

                return _selectedTabIndex;
            }
        }

        /// <summary>
        ///     Gets or sets the currently selected tab page.
        /// </summary>
        public TabPage SelectedPage
        {
            get
            {
                TabPage selectedTab = this.Pages.FirstOrDefault(tab => tab.Visible);                
                Int32 pageIndex = SelectedTabIndex.Value.ConvertTo<Int32>(0);
                if (pageIndex > 0 && pageIndex < this.Pages.Count && this.Pages.ElementAt(pageIndex).Visible)
                    selectedTab = this.Pages.ElementAt(pageIndex);

                return selectedTab;
            }
            set
            {
                SelectedTabIndex.Value = this.Pages.IndexOf(value).ToString();
            }
        }

        /// <summary>
        ///    Gets the collection of tabbable pages.
        /// </summary>
        [PersistenceMode(PersistenceMode.InnerProperty)]
        public List<TabPage> Pages
        {
            get
            {
                if (_pages == null)
                    _pages = new List<TabPage>();

                return _pages;
            }
        }

        /// <summary>
        ///    Gets or sets the rendering mode for the tab control.
        /// </summary>
        public TabControlModes Mode
        {
            get { return _mode; }
            set { _mode = value; }
        }

        /// <summary>
        ///    Gets or sets the minimum height for the tabbed pages.
        /// </summary>
        public override Unit Height
        {
            get { return _height; }
            set { _height = value; }
        }

        #endregion

        #region page cycle

        protected override void OnInit(EventArgs e)
        {
            base.OnInit(e);

            this.Controls.Add(this.Header);
            foreach (TabPage page in this.Pages)
                if (this.Mode == TabControlModes.Tabbed)
                    this.Header.Controls.Add(page.Heading);
            
            this.Controls.Add(this.Content);
            foreach (TabPage page in this.Pages)
                this.Content.Controls.Add(page);

            this.Controls.Add(this.SelectedTabIndex);
        }

        protected override void OnPreRender(EventArgs e)
        {
            base.OnPreRender(e);
            switch (this.Mode)
            {
                case TabControlModes.Tabbed:
                    this.Header.Attributes.Add("role", "tablist");
                    this.Header.Attributes.Add("class", "nav nav-tabs hidden-print");
                    this.Content.Attributes.Add("class", "tab-content");
                    if (this.Height != 0)
                        this.Content.Attributes.Add("style", "min-height: " + this.Height.ToString());

                    // Make the client keep the SelectedTabIndex hidden field up to date when the user clicks on a tab.
                    string script = string.Format(@"
$(document).ready(function() {{
    $('#{0}').on('shown.bs.tab', function(event) {{
        var tix = 0;
        $('#{0}').each(function(ix, tab) {{
            if ($(tab).hasClass('active')) {{
                tix = ix;
                return false;
            }}
        }});
        $('#{1}').val(tix);    
    }});
}}); ", this.Header.ClientID, this.SelectedTabIndex.ClientID);

                    Page.ClientScript.RegisterStartupScript(Page.GetType(), this.Header.ClientID + "_script", script.ToString(), true);

                    break;
            }
        }

        #endregion
    }
}
