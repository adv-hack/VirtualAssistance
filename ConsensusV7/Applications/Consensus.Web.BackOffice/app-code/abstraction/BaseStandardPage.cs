using Consensus.Security;
using Consensus.UserInterface;
using Consensus.Web.BackOffice.assets.templates;
using Consensus.Web.Controls;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;

namespace Consensus.Web.BackOffice
{
    /// <summary>
    ///     Provides the abstraction for the pages that are accessible to authenticated users only.
    /// </summary>
    public abstract class BaseStandardPage : BaseSecurePage, IIsEditable, IHaveCustomTitle, IHaveCustomIcon
    {
        #region fields

        /// <summary>
        ///     The icon displayed within the header of the page.
        /// </summary>
        private String _icon;

        /// <summary>
        ///     The text displayed within the header of the page. 
        /// </summary>
        private String _title;

        #endregion

        #region properties

        /// <summary>
        ///     Gets whether the page is initially rendered in editing mode.
        /// </summary>
        public virtual Boolean IsEditable
        {
            get { return this.Request.QueryString.AllKeys.Contains("edit"); }
        }

        /// <summary>
        ///     Gets the icon displayed within the header of the page.
        /// </summary>
        public virtual String DefaultIcon
        {
            get { return null; }
        }

        /// <summary>
        ///     Gets the text displayed within the header of the page.
        /// </summary>
        public abstract String DefaultTitle
        {
            get;
        }
        
        /// <summary>
        ///     Gets or sets the icon displayed within the header of the page.
        /// </summary>
        public String Icon
        {
            get { return String.IsNullOrEmpty(_icon) ? this.DefaultIcon : _icon; }
            set { _icon = value; }
        }

        /// <summary>
        ///     Gets or sets the text displayed within the header of the page.
        /// </summary>
        public String Title
        {
            get { return String.IsNullOrEmpty(_title) ? this.DefaultTitle : _title; }
            set { _title = value; }
        }

        #endregion

        #region page cycle

        protected override void OnInit(EventArgs e)
        {
            this.PopulateLinks();
            base.OnInit(e);
        }

        protected override void OnLoadComplete(EventArgs e)
        {
            base.OnLoadComplete(e);
            this.Form.Attributes["data-mode"] += (this.IsEditable ? "edit" : "read");
        }

        protected override void OnPreRender(EventArgs e)
        {
            base.OnPreRender(e);
            
            String pageURL = this.Request.Url.PathAndQuery.Substring(VirtualPathUtility.ToAbsolute("~").Length).StartsWith("/") ? this.Request.Url.PathAndQuery.Substring(VirtualPathUtility.ToAbsolute("~").Length) : "/" + this.Request.Url.PathAndQuery.Substring(VirtualPathUtility.ToAbsolute("~").Length);

            if (!HistoryLink.FetchAllByUserId(this.CurrentSession.UserId).OfType<HistoryLink>().Any(Link => Link.Url == pageURL))
                this.CreateHistoryLink(pageURL);
            else
                this.UpdateHistoryLink(this.CurrentSession.UserId, pageURL);

            foreach (QuickAccessLink QuickLink in QuickAccessLink.FetchAllByUserId(this.CurrentSession.UserId).OrderBy(Link => Link.Description))
                this.PopulateQuickLink(QuickLink.Url, QuickLink.Description, QuickLink.Icon, QuickLink.Id);
            foreach (HistoryLink UserHistoryLink in HistoryLink.FetchAllByUserId(this.CurrentSession.UserId).OrderByDescending(Link => Link.ModDate))
                this.PopulateHistoryLink(UserHistoryLink.Url, UserHistoryLink.Description, UserHistoryLink.Icon, UserHistoryLink.Id);
        }

        #endregion

        #region methods

        protected virtual void CreateHistoryLink(String URL)
        {
           
                HistoryLink link = HistoryLink.Create();
                if (this.Request.Url.ToString().Contains("id") || this.Request.Url.ToString().Contains("search")) {
                    link.Url = URL;
                    link.Description = this.DefaultTitle;
                    link.Icon = this.DefaultIcon;
                    link.UserId = CurrentSession.UserId;
                    link.SaveAndCleanUp();
                }

        }

        protected virtual void UpdateHistoryLink(Int32 userId, String URL)
        {
            HistoryLink link = HistoryLink.FetchByUserIDAndURL(userId, URL);
            if (link != null) { 
            link.ModDate = DateTime.Now;
            link.Description = this.DefaultTitle;
            link.Icon = this.DefaultIcon;
            link.SaveAndCleanUp();
            }
        }


        /// <summary>
        ///     Adds a link to the sidebar menu
        /// </summary>
        protected virtual void PopulateSideBar(String href, String text)
        {
            // Find the standard master page
            MasterPage masterPage = this.Master;
            while (masterPage != null && masterPage is Standard == false)
                masterPage = masterPage.Master;

            // Add the menu item to the list
            MenuItem menuItem = new MenuItem(href, text);
            if (masterPage != null)
                (masterPage as Standard).SideMenu.Add(menuItem);
        }

        /// <summary>
        ///     Adds a link to the quick links list
        /// </summary>
        protected virtual void PopulateQuickLink(String href, String text, String icon, Int32 id)
        {
            // Find the standard master page
            MasterPage masterPage = this.Master;
            while (masterPage != null && masterPage is Standard == false)
                masterPage = masterPage.Master;

            // Add the menu item to the list
            MenuItem menuItem = new MenuItem(href, text, icon, id);
            if (masterPage != null)
                (masterPage as Standard).QuickLink.Add(menuItem);
        }

        /// <summary>
        ///     Adds a link to the history link menu
        /// </summary>
        protected virtual void PopulateHistoryLink(String href, String text, String icon, Int32 id)
        {
            // Find the standard master page
            MasterPage masterPage = this.Master;
            while (masterPage != null && masterPage is Standard == false)
                masterPage = masterPage.Master;

            // Add the menu item to the list
            MenuItem menuItem = new MenuItem(href, text, icon, id);
            if (masterPage != null)
                (masterPage as Standard).UserHistory.Add(menuItem);
        }

        /// <summary>
        ///     Adds the links to the page header
        /// </summary>
        protected virtual void PopulateLinks()
        {
        }

        /// <summary>
        ///     Adds a link to the page header
        /// </summary>
        private void PopulateLink(String href, String text, MasterPage masterPage)
        {
            // Add the menu item to the list
            MenuItem menuItem = new MenuItem(href, text);
            if (masterPage != null)
                (masterPage as Standard).PageMenu.Add(menuItem);
        }

        /// <summary>
        ///     Adds a link to the page header to each page within the specified tab control
        /// </summary>
        internal void PopulateLink(TabControl tabControl)
        {
            // Find the standard master page
            MasterPage masterPage = this.Master;
            while (masterPage != null && masterPage is Standard == false)
                masterPage = masterPage.Master;

            if (tabControl != null && tabControl.Pages != null && !(tabControl is TabControlFooter))
            {
                TabPage[] pages = tabControl.Pages.Where(page => page.IsHidden == ConfigurableBoolean.False || page.IsHidden == ConfigurableBoolean.FalseEnforced).ToArray();
                if (pages.Length != 0)
                {
                    if ((masterPage as Standard).PageMenu.Count == 0)
                    {
                        this.PopulateLink("#body", "Details", masterPage);
                    }
                    foreach (TabPage page in pages)
                        if (!String.IsNullOrEmpty(page.ClientID) && page.Visible)
                            this.PopulateLink("#" + page.ClientID, page.Title, masterPage);
                }
            }
            else if (tabControl is TabControlFooter)
            {
                if ((masterPage as Standard).PageMenu.Count == 0)
                {
                    this.PopulateLink("#body", "Details", masterPage);
                }
                this.PopulateLink("#" + tabControl.ClientID, (tabControl as TabControlFooter).Title, masterPage);
            }
        }
        
        #endregion
    }
}