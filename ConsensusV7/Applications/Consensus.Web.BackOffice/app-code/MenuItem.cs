using Consensus.UserInterface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Consensus.Web.BackOffice
{
    /// <summary>
    ///     Represents a menu item.
    /// </summary>
    public class MenuItem
    {
        #region enums

        public enum Types
        {
            /// <summary>
            ///     The menu item is rendered in the main menu situated at the top of the site.
            /// </summary>
            MainMenu,

            /// <summary>
            ///     The menu item is rendered in the side menu situated at the left-hand side of the site. 
            /// </summary>
            SideMenu,

            /// <summary>
            ///     The menu item is rendered in the quick link list situated at the left-hand side of the site. 
            /// </summary>
            QuickLink,

            /// <summary>
            ///     The menu item is rendered in the history link list situated at the left-hand side of the site. 
            /// </summary>
            UserHistory,

            /// <summary>
            ///     The menu item is rendered in the page menu situated directly beneath the page header.
            /// </summary>
            PageMenu,

            /// <summary>
            ///     The menu item is rendered outside of the normal menus.
            /// </summary>
            Other
        }
        
        #endregion

        #region fields

        /// <summary>
        ///     The singleton collection of system menus.
        /// </summary>
        private static SystemMenu[] _systemMenus;

        /// <summary>
        ///     The type of menu item.
        /// </summary>
        private Types _type;

        /// <summary>
        ///     The link for the menu item.
        /// </summary>
        private String _link;

        /// <summary>
        ///     The screenObjectDisplay icon for the menu item.
        /// </summary>
        private String _icon;

        /// <summary>
        ///     The screenObjectDisplay text for the menu item.
        /// </summary>
        private String _text;

        /// <summary>
        ///     The id for the menu item.
        /// </summary>
        private Int32 _id;

        /// <summary>
        ///     The child nodes that appear under this node.
        /// </summary>
        private MenuItem[] _children;

        #endregion

        #region properties

        /// <summary>
        ///    Gets or sets the 
        /// </summary>
        private static SystemMenu[] SystemMenus
        {
            get
            {
                if (_systemMenus == null)
                    _systemMenus = SystemMenu.FetchAll().ToArray();

                return _systemMenus;
            }
        }

        /// <summary>
        ///     Gets the type of menu item.
        /// </summary>
        public Types Type
        {
            get { return _type; }
        }

        /// <summary>
        ///     Gets the link for the menu item.
        /// </summary>
        public String Link
        {
            get { return _link; }
        }

        /// <summary>
        ///     Gets the screenObjectDisplay icon for the menu item.
        /// </summary>
        public String Icon
        {
            get { return _icon; }
        }

        /// <summary>
        ///     Gets the screenObjectDisplay text for the menu item.
        /// </summary>
        public String Text
        {
            get { return _text; }
        }

        /// <summary>
        ///     Gets the id for the menu item.
        /// </summary>
        public Int32 Id
        {
            get { return _id; }
        }

        /// <summary>
        ///    Gets the child items that exist under this menu item.
        /// </summary>
        public MenuItem[] Children
        {
            get { return _children; }
        }

        #endregion

        #region constructors

        public MenuItem(String link, String text, String icon, Int32 id) : this(Types.Other, link, text, icon, null, id)
        {
        }

        public MenuItem(String link, String text) : this(Types.Other, link, text, null, null, 0)
        {
        }

        private MenuItem(Types type, String link, String text, String icon, MenuItem[] children, Int32 id)
        {
            _type = type;
            _link = link;
            _text = text;
            _icon = icon;
            _id = id;
            _children = children;
        }

        #endregion

        #region methods

        public static IEnumerable<MenuItem> GetSystemMenuItems()
        {
            return MenuItem.GetSystemMenuItems(MenuItem.SystemMenus.Where(sysmen => sysmen.ParentId == null));
        }

        private static IEnumerable<MenuItem> GetSystemMenuItems(IEnumerable<SystemMenu> systemMenus)
        {
            foreach (SystemMenu systemMenu in systemMenus)
                if (String.IsNullOrEmpty(systemMenu.Page) || String.Equals(HttpContext.Current.Request.Url.AbsolutePath, VirtualPathUtility.ToAbsolute(systemMenu.Page), StringComparison.OrdinalIgnoreCase))
                    if (systemMenu.Group.ConvertTo<Types>(Types.Other) != Types.Other)
                        yield return MenuItem.GetSystemMenuItem(systemMenu);
        }

        private static MenuItem GetSystemMenuItem(SystemMenu systemMenu)
        {
            return new MenuItem(
                type: systemMenu.Group.ConvertTo<Types>(), 
                link: systemMenu.RelativePath, 
                text: systemMenu.Name, 
                icon: systemMenu.Icon, 
                id: systemMenu.Id,
                children: MenuItem.GetSystemMenuItems(systemMenu.SystemMenus.OfType<SystemMenu>()).ToArray()
            );
        }

        #endregion
    }
}