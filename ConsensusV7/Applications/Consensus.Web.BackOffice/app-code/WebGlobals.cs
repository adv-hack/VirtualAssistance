using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Consensus.Web.BackOffice
{
    /// <summary>
    ///     Provides constants and access to static methods which pertain to the web application.
    /// </summary>
    public static class WebGlobals
    {
        /// <summary>
        ///     The virtual path of the root of the site.
        /// </summary>
        public static readonly String RootUrl = VirtualPathUtility.ToAbsolute("~");

        /// <summary>
        ///     The relative path of the page to redirect newly authenticated users to.
        /// </summary>
        public const String HomeUrl = "~/home";

        /// <summary>
        ///     The relative path of the page to redirect newly authenticated users to.
        /// </summary>
        public const String HomePage = "~/homepage.aspx";

        /// <summary>
        ///     The relative path of the page to redirect failed requests to.
        /// </summary>
        public const String ErrorUrl = "~/error";

        /// <summary>
        ///     The relative path of the page to redirect failed requests to.
        /// </summary>
        public const String ErrorPage = "~/errorpage.aspx";

        /// <summary>
        ///     The relative path of the page to redirect unauthenticated users to.
        /// </summary>
        public const String LoginUrl = "~/auth/login";

        /// <summary>
        ///     The relative path of the page to redirect unauthenticated users to.
        /// </summary>
        public const String LoginPage = "~/auth/loginpage.aspx";

        /// <summary>
        ///     The relative path of the page to redirect to when an invalid license is detected.
        /// </summary>
        public const String LicenseUrl = "~/security/license";

        /// <summary>
        ///     The relative path of the page to redirect to when an invalid license is detected.
        /// </summary>
        public const String LicensePage = "~/security/licensepage.aspx";

    }
}