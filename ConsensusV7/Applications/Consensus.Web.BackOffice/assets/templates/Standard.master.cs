using Consensus.UserInterface;
using Consensus.Security;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;

namespace Consensus.Web.BackOffice.assets.templates
{
    public partial class Standard : MasterPage
    {
        #region fields

        /// <summary>
        ///     The collection of items featured in the main menu.
        /// </summary>
        private List<MenuItem> _mainMenu;

        /// <summary>
        ///     The collection of items featured in the side menu.
        /// </summary>
        private List<MenuItem> _sideMenu;

        /// <summary>
        ///     The collection of items featured in the quick link list.
        /// </summary>
        private List<MenuItem> _quickLink;

        /// <summary>
        ///     The collection of items featured in the user history list.
        /// </summary>
        private List<MenuItem> _userHistory;

        /// <summary>
        ///     The collection of items featured in the page menu.
        /// </summary>
        private List<MenuItem> _pageMenu;

        #endregion

        #region properties

        /// <summary>
        ///     CustomiseButton control.
        /// </summary>
        public LinkButton CustomiseButton;

        /// <summary>
        ///    Gets the collection of items featured in the main menu.
        /// </summary>
        public List<MenuItem> MainMenu
        {
            get
            {
                if (_mainMenu == null)
                    _mainMenu = MenuItem.GetSystemMenuItems().Where(menu => menu.Type == MenuItem.Types.MainMenu).ToList();

                return _mainMenu;
            }
        }

        /// <summary>
        ///    Gets the collection of items featured in the side menu.
        /// </summary>
        public List<MenuItem> SideMenu
        {
            get
            {
                if (_sideMenu == null)
                    _sideMenu = MenuItem.GetSystemMenuItems().Where(menu => menu.Type == MenuItem.Types.SideMenu).ToList();

                return _sideMenu;
            }
        }

        /// <summary>
        ///    Gets the collection of items featured in the quicklinks.
        /// </summary>
        public List<MenuItem> QuickLink
        {
            get
            {
                if (_quickLink == null)
                    _quickLink = MenuItem.GetSystemMenuItems().Where(menu => menu.Type == MenuItem.Types.QuickLink).ToList();

                return _quickLink;
            }
        }

        /// <summary>
        ///    Gets the collection of items featured in the userhistory.
        /// </summary>
        public List<MenuItem> UserHistory
        {
            get
            {
                if (_userHistory == null)
                    _userHistory = MenuItem.GetSystemMenuItems().Where(menu => menu.Type == MenuItem.Types.UserHistory).ToList();

                return _userHistory;
            }
        }

        /// <summary>
        ///    Gets the collection of items featured in the page menu.
        /// </summary>
        public List<MenuItem> PageMenu
        {
            get
            {
                if (_pageMenu == null)
                    _pageMenu = MenuItem.GetSystemMenuItems().Where(menu => menu.Type == MenuItem.Types.PageMenu).ToList();

                return _pageMenu;
            }
        }

        #endregion

        #region page cycle

        /// <summary>
        ///     Occurs during the "PreRender" phase of the ASP.NET lifecycle.
        /// </summary>
        protected override void OnPreRender(EventArgs e)
        {
            base.OnPreRender(e);

             
            
            // Set the user dropdown menu
            BasePage basePage = this.Page as BasePage;
            if (basePage != null && basePage.CurrentSession != null && basePage.CurrentSession.User != null && basePage.CurrentSession.User.Person != null)
                //this.UserDropdown.InnerText = basePage.CurrentSession.User.Person.FullName;
            this.UserDropDownLink.Text = string.Concat(basePage.CurrentSession.User.Person.FirstName," ", basePage.CurrentSession.User.Person.Surname);
            this.loggedUser.Value = basePage.CurrentSession.User.Username;
            // Set the page header and icon
            BaseStandardPage standardPage = this.Page as BaseStandardPage;
            if (this.PageHeader.Visible = (standardPage != null && !String.IsNullOrEmpty(standardPage.Title)))
                this.PageHeader.Text = standardPage.Title;
            if (this.PageIcon.Visible = (standardPage != null && !String.IsNullOrEmpty(standardPage.Icon)))
                this.PageIcon.Attributes["class"] += " icons8-" + standardPage.Icon;

            // Populate the menus
            this.MainMenuRepeater.DataSource = this.MainMenu;
            this.MainMenuRepeater.DataBind();
            this.SideMenuRepeater.DataSource = this.SideMenu;
            this.SideMenuRepeater.DataBind();
            this.QuickLinkRepeater.DataSource = this.QuickLink;
            this.QuickLinkRepeater.DataBind();
            this.UserHistoryRepeater.DataSource = this.UserHistory;
            this.UserHistoryRepeater.DataBind();
            this.PageMenuRepeater.DataSource = this.PageMenu;
            this.PageMenuRepeater.DataBind();


            // Toggle the option header visibility
            if (this.SideMenuRepeater.Items.Count == 0)
            {
                this.OptionHeader.Visible = false;             
            }

        }

        #endregion

        #region event handlers

        /// <summary>
        ///     Occurs when the main menu is bound to a data source.
        /// </summary>
        protected void MainMenuRepeater_ItemDataBound(Object sender, RepeaterItemEventArgs e)
        {
            MenuItem menuItem = e.Item.DataItem as MenuItem;
            Repeater repeater = e.Item.FindControl("MainMenuRepeater") as Repeater;
            repeater.DataSource = menuItem.Children;
            repeater.DataBind();
        }

        /// <summary>
        ///     Occurs when the side menu is bound to a data source.
        /// </summary>
        protected void SideMenuRepeater_ItemDataBound(object sender, RepeaterItemEventArgs e)
        {
            MenuItem menuItem = e.Item.DataItem as MenuItem;
            HtmlGenericControl itemIcon = new HtmlGenericControl("span");
            //itemIcon.Attributes["class"] = String.IsNullOrEmpty(menuItem.Icon) ? "" : "icons8-" + menuItem.Icon;

            HtmlGenericControl itemText = new HtmlGenericControl("span");
            itemText.InnerText = menuItem.Text;
            HtmlGenericControl itemLink = new HtmlGenericControl("a");
            itemLink.Attributes.Add("href", menuItem.Link.StartsWith("#") ? "#" : menuItem.Link.StartsWith("~") ? VirtualPathUtility.ToAbsolute(menuItem.Link) : menuItem.Link);
            itemLink.Attributes.Add("data-scroll-to", menuItem.Link.StartsWith("#") ? menuItem.Link : null);
            itemLink.Attributes.Add("title", menuItem.Text);
            itemLink.Controls.Add(itemIcon);
            itemLink.Controls.Add(itemText);
            e.Item.Controls.Add(itemLink);
        }

        /// <summary>
        ///     Occurs when the side menu is bound to a data source.
        /// </summary>
        protected void QuickLinkRepeater_ItemDataBound(object sender, RepeaterItemEventArgs e)
        {
            MenuItem menuItem = e.Item.DataItem as MenuItem;
            HtmlGenericControl itemIcon = new HtmlGenericControl("span");
            itemIcon.Attributes["class"] = String.IsNullOrEmpty(menuItem.Icon) ? "" : "icons8-" + menuItem.Icon;

            HtmlGenericControl dropIcon = new HtmlGenericControl("span");
            //dropIcon.Attributes["class"] = "icons8-delete_sign";
            dropIcon.Attributes["onclick"] = "consensus.web.quickAccessLinks.remove(event,'" + menuItem.Id + "'); return false;";

            HtmlGenericControl svgTag = new HtmlGenericControl("svg");
            svgTag.Attributes["class"] = "icon icon-black";
            HtmlGenericControl useTag = new HtmlGenericControl("use");
            useTag.Attributes.Add("href", "#delete_sign");
            svgTag.Controls.Add(useTag);
            dropIcon.Controls.AddAt(0,svgTag);

            HtmlGenericControl itemText = new HtmlGenericControl("span");
            itemText.InnerText = menuItem.Text;


            
            HtmlGenericControl itemLink = new HtmlGenericControl("a");
            itemLink.Controls.Add(dropIcon);
            itemLink.Attributes.Add("href", menuItem.Link.StartsWith("#") ? "#" : VirtualPathUtility.ToAbsolute("~" + menuItem.Link));
            itemLink.Attributes.Add("data-scroll-to", menuItem.Link.StartsWith("#") ? menuItem.Link : null);
            itemLink.Attributes.Add("title", menuItem.Text);
            //itemLink.Controls.Add(itemIcon);           
            itemLink.Controls.Add(itemText);

            e.Item.Controls.Add(itemLink);
        }

        /// <summary>
        ///     Occurs when the side menu is bound to a data source.
        /// </summary>
        protected void UserHistoryRepeater_ItemDataBound(object sender, RepeaterItemEventArgs e)
        {
            MenuItem menuItem = e.Item.DataItem as MenuItem;
            HtmlGenericControl itemIcon = new HtmlGenericControl("span");
            //itemIcon.Attributes["class"] = String.IsNullOrEmpty(menuItem.Icon) ? "" : "icons8-" + menuItem.Icon;

            HtmlGenericControl itemText = new HtmlGenericControl("span");
            itemText.InnerText = menuItem.Text;

            HtmlGenericControl itemLink = new HtmlGenericControl("a");
            itemLink.Attributes.Add("href", menuItem.Link.StartsWith("#") ? "#" : VirtualPathUtility.ToAbsolute("~" + menuItem.Link));
            itemLink.Attributes.Add("data-scroll-to", menuItem.Link.StartsWith("#") ? menuItem.Link : null);
            itemLink.Attributes.Add("title", menuItem.Text);
            itemLink.Controls.Add(itemIcon);
            itemLink.Controls.Add(itemText);
            e.Item.Controls.Add(itemLink);
        }


        /// <summary>
        ///     Occurs when the page menu is bound to a data source.
        /// </summary>
        protected void PageMenuRepeater_ItemDataBound(object sender, RepeaterItemEventArgs e)
        {
            MenuItem menuItem = e.Item.DataItem as MenuItem;

            HtmlGenericControl itemIcon = new HtmlGenericControl("span");
            itemIcon.Attributes["class"] = String.IsNullOrEmpty(menuItem.Icon) ? "" : "icons8-" + menuItem.Icon;

            HtmlGenericControl itemText = new HtmlGenericControl("span");
            itemText.InnerText = menuItem.Text;

            HtmlGenericControl itemLink = new HtmlGenericControl("a");
            itemLink.Attributes.Add("href", menuItem.Link.StartsWith("#") ? "#" : menuItem.Link.StartsWith("~") ? VirtualPathUtility.ToAbsolute(menuItem.Link) : menuItem.Link);
            itemLink.Attributes.Add("data-scroll-to", menuItem.Link.StartsWith("#") ? menuItem.Link : null);
            itemLink.Controls.Add(itemIcon);
            itemLink.Controls.Add(itemText);
            e.Item.Controls.Add(itemLink);
        }


        #endregion
    }
}