using Consensus.Security;
using Consensus.Web.BackOffice.assets.templates;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;

namespace Consensus.Web.BackOffice
{
    /// <summary>
    ///     Provides the abstraction for all pages within the web application.
    /// </summary>
    public abstract class BasePage : Page
    {
        #region fields

        /// <summary>
        ///     The current authentication session.
        /// </summary>
        private UserSession _currentSession;

        #endregion

        #region properties

        /// <summary>
        ///    Gets the current authentication session.
        /// </summary>
        public UserSession CurrentSession
        {
            get
            {
                if (_currentSession == null)
                    _currentSession = UserSession.FetchCurrent();
                if (_currentSession != null && _currentSession.Expiry < DateTime.Now)
                    _currentSession = null;

                return _currentSession;
            }
        }

        #endregion
        
        #region page cycle

        protected override void OnPreInit(EventArgs e)
        {
            base.OnPreInit(e);

            if (ConsensusDomain.Configuration[ConsensusDomain.Configuration.DefaultSite].SSLPort != null && String.Equals(this.Request.Url.Scheme, "HTTP", StringComparison.OrdinalIgnoreCase))
            {
                String secureUrl = String.Concat("https://", this.Request.Url.Host, ":", ConsensusDomain.Configuration[ConsensusDomain.Configuration.DefaultSite].SSLPort, this.Request.Url.PathAndQuery);
                this.Response.Clear();
                this.Response.StatusCode = 307;
                this.Response.StatusDescription = "Temporary Redirect";
                this.Response.AddHeader("Location", secureUrl);
                this.Response.Flush();
                this.Response.End();
            }
        }

        protected override void OnPreRender(EventArgs e)
        {
            base.OnPreRender(e);

            // Remove the customisations options
            if (this is IAmNonCustomisable || this.CurrentSession == null || this.CurrentSession.Expiry == DateTime.Now || this.CurrentSession.User == null || this.CurrentSession.User.SysAdmin.ConvertTo<Boolean>() == false)
                if (this.Master is Standard)
                    (this.Master as Standard).CustomiseButton.Visible = false;
                else if (this.Master is StandardDetail)
                    (((this.Master as StandardDetail).Master as Main).Master as Standard).CustomiseButton.Visible = false;
                else if (this.Master is Main)
                    ((this.Master as Main).Master as Standard).CustomiseButton.Visible = false;
                else if (this.Master is Popup)
                    (this.Master as Popup).CustomiseButton.Visible = false;
                else if (this.Master is PopupSearch)
                    ((this.Master as PopupSearch).Master as Popup).CustomiseButton.Visible = false;

            // Set the page title
            if (String.IsNullOrEmpty(this.Title))
                this.Title = ConsensusDomain.Configuration[ConsensusDomain.Configuration.DefaultSite].ProductName;
            else
                this.Title = ConsensusDomain.Configuration[ConsensusDomain.Configuration.DefaultSite].ProductName + " | " + this.Title;
        }

        #endregion

        #region methods

        /// <summary>
        ///     Terminates the current HTTP request.
        /// </summary>
        /// <param name="code">
        ///     The status code to be returned.
        /// </param>
        /// <param name="decription">
        ///     The description to be returned.
        /// </param>
        protected void TerminateRequest(Int32 code, String description)
        {
            this.Response.Clear();
            this.Response.StatusCode = code;
            this.Response.StatusDescription = description;
            this.Response.End();
        }

        #endregion
    }
}