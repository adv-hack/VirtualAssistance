using Consensus.Searches;
using Consensus.Web.BackOffice.assets.templates;
using Consensus.Web.Controls;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.HtmlControls;

namespace Consensus.Web.BackOffice
{
    public abstract class BasePopupSearchPage : BasePopupPage
    {
        #region fields

        /// <summary>
        ///     The buttons that will be included in the footer of the popup.
        /// </summary>
        private PopupButtons? _buttons;
        
        #endregion

        #region properties

        /// <summary>
        ///     Specifies whether a search has been executed and controls whether the results table is displayed.
        /// </summary>
        private Boolean HasSearchRan { get; set; }
        //{ // ViewState is turned off. Would have to save this in a hidden field if we want it preserved on postback (at the moment it's not needed).
        //    get { return this.ViewState["hasSearchRan"].ConvertTo<Boolean>(false); }
        //    set { this.ViewState["hasSearchRan"] = value; }
        //}

        /// <summary>
        ///     The reference to the search results table.
        /// </summary>
        protected abstract DataTable SearchResultTable
        {
            get;
        }

        /// <summary>
        ///     Gets the buttons that will be included in the footer of the popup.
        /// </summary>
        protected virtual PopupButtons Buttons
        {
            get
            {
                if (_buttons == null && !String.IsNullOrEmpty(this.Request.QueryString["search-buttons"]))
                    _buttons = this.Request.QueryString["search-buttons"].ConvertTo<PopupButtons>(PopupButtons.Both);

                return _buttons ?? PopupButtons.Both;
            }
        }
        
        #endregion
        
        #region page cycle

        /// <summary>
        ///     Prepares the page control hierarchy.
        /// </summary>
        protected override void OnInit(EventArgs e)
        {
            base.OnInit(e);

            this.BlockCustomFields = true;

            this.SearchResultTable.CanExport = false;
            this.SearchResultTable.CanPrint = false;
            this.SearchResultTable.CanSearch = false;
            this.SearchResultTable.ClientSideRefresh = UserInterface.ConfigurableBoolean.False;

            PopupSearch master = this.Master as PopupSearch;
            if (master != null)
            {
                if (this.Buttons == PopupButtons.Clear || this.Buttons == PopupButtons.Both)
                {
                    HtmlGenericControl clear = new HtmlGenericControl("button");
                    clear = this.CreateButton("delete", "Clear", "danger", true, "icon-white", "closePopup('clear'); return false;");
                    master.PopupButtons.Controls.Add(clear);
                }
                if (this.Buttons == PopupButtons.Cancel || this.Buttons == PopupButtons.Both)
                {
                    HtmlGenericControl cancel = new HtmlGenericControl("button");

                    cancel = this.CreateButton("delete_sign", "Cancel", "warning", true, "icon-white", "closePopup(); return false;");
                    master.PopupButtons.Controls.Add(cancel);
                }
            }
        }

        /// <summary>
        ///     Prepares the page for loading, after viewstate has been initialised.
        /// </summary>
        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);

            // Perform an automated search where a search parameter is passed.
            if (!this.IsPostBack && this.Request.QueryString.AllKeys.Contains("search"))
            {
                this.SetSearch(this.Request.QueryString["search"]);
                this.SearchResultTable.Data = this.GetSearch();
                this.HasSearchRan = true;            
            }
        }

        /// <summary>
        ///     Prepares the page for rendering.
        /// </summary>
        protected override void OnPreRender(EventArgs e)
        {
            base.OnPreRender(e);
            this.Form.Attributes.Add("data-mode", "edit");
            PopupSearch masterPage = this.Master as PopupSearch;
            if (masterPage != null)
                masterPage.SearchResultPanel.Style[HtmlTextWriterStyle.Display] = this.HasSearchRan ? "block" : "none";
        }

        #endregion

        #region methods
        /// <summary>
        /// Creates buttons
        /// </summary>
        /// <param name="icon">Icon class or svg reference</param>
        /// <param name="text">Button Text</param>
        /// <param name="style">Button style</param>
        /// <param name="useSvg">true or false - use svg for icon</param>
        /// <param name="svgclass">additional classes for svg icon (eg colour change)</param>
        /// <param name="action">onclick text</param>
        /// <returns></returns>
        private HtmlGenericControl CreateButton(String icon, String text, String style, Boolean useSvg, String svgClass, String action)
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
            buttonElement.Attributes["class"] = "btn btn-" + style + " mx-1";
            buttonElement.Attributes["type"] = "button";
            buttonElement.Attributes["onclick"] = action;
            buttonElement.Controls.Add(iconElement);
            buttonElement.Controls.Add(spacer);
            buttonElement.Controls.Add(textElement);

            return buttonElement;
        }
        /// <summary>
        ///     Executes the search when the search button is clicked.
        /// </summary>
        protected void SearchButton_Click(Object sender, EventArgs eventArguments)
        {
            this.SearchResultTable.Data = this.GetSearch();
            this.HasSearchRan = true;            
        }

        /// <summary>
        ///     Pre-populates the search fields.
        /// </summary>
        protected abstract void SetSearch(String value);

        /// <summary>
        ///     Gets the parameterised search procedure.
        /// </summary>
        protected abstract ISearchesRunnable GetSearch();

        #endregion
    }
}