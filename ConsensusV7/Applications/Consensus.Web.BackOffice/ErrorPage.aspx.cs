using Consensus.Security;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Reflection;
using System.Web;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;

namespace Consensus.Web.BackOffice
{
    public partial class ErrorPage : BasePage, IAmNonCustomisable
    {
        #region enum

        /// <summary>
        ///     Enumerates the different rendering modes for the error page.
        /// </summary>
        [Flags]
        private enum ErrorPageModes
        {
            /// <summary>
            ///     An error has been raised for an unauthenticated user.
            /// </summary>
            Anonymous = 0,

            /// <summary>
            ///     An error has been raised for an authenticated user.
            /// </summary>
            Authenticated = 1,

            /// <summary>
            ///     An error has been raised within a popup window.
            /// </summary>
            Popup = 2,

            /// <summary>
            ///     An error has been raised in response to a RESTful API service call.
            /// </summary>
            RESTful = 4
        }

        #endregion

        #region fields

        /// <summary>
        ///     The exception that caused the user to reach the error page.
        /// </summary>
        private Exception _exception;

        /// <summary>
        ///     The status code that this returned to the user-agent.
        /// </summary>
        private Int32? _httpStatusCode;

        /// <summary>
        ///     The status description that is returned to the user-agent.
        /// </summary>
        private String _httpStatusDescription;

        /// <summary>
        ///     The status message that is displayed on the page.
        /// </summary>
        private String _httpStatusMessage;

        /// <summary>
        ///     The rendering mode for the error page. 
        /// </summary>
        private ErrorPageModes? _pageMode;

        #endregion

        #region properties

        /// <summary>
        ///    Gets the exception that caused the user to reach the error page.
        /// </summary>
        public Exception Exception
        {
            get
            {
                if (_exception == null)
                    _exception = HttpContext.Current.Error;
                if (_exception is HttpUnhandledException)
                    _exception = _exception.InnerException;
                if (_exception is TargetInvocationException)
                    _exception = _exception.InnerException;

                return _exception;
            }
        }

        /// <summary>
        ///     Gets the status code that this returned to the user-agent.
        /// </summary>
        public Int32 HttpStatusCode
        {
            get
            {
                if (_httpStatusCode == null && this.Exception is HttpException)
                    _httpStatusCode = (this.Exception as HttpException).GetHttpCode();

                if (_httpStatusCode == null)
                    _httpStatusCode = this.Request.QueryString["err"].ConvertTo<Int32>(500);

                return _httpStatusCode.Value;
            }
        }

        /// <summary>
        ///     Gets the status description that is returned to the user-agent.
        /// </summary>
        public String HttpStatusDescription
        {
            get
            {
                if (_httpStatusDescription == null)
                {
                    switch (this.HttpStatusCode)
                    {
                        case 401: _httpStatusDescription = "You do not have permission to access this page."; break;
                        case 403: _httpStatusDescription = "You do not have permission to access this page."; break;
                        case 404: _httpStatusDescription = "The requested page could not be found."; break;
                        case 410: _httpStatusDescription = "The requested record could not be found, it may have been deleted."; break;
                        case 428: _httpStatusDescription = "You do not have a valid license, please contact support for assistance."; break;
                        default: _httpStatusDescription = "An unexpected error has occurred, please contact support for assistance."; break;
                    }
                }

                return _httpStatusDescription;
            }
        }

        /// <summary>
        ///    Gets the status message that is displayed on the page.
        /// </summary>
        public String HttpStatusMessage
        {
            get
            {
                if (_httpStatusMessage == null)
                {
                    switch (this.HttpStatusCode)
                    {
                        case 401: _httpStatusMessage = "Not Authorised"; break;
                        case 403: _httpStatusMessage = "Not Authorised"; break;
                        case 404: _httpStatusMessage = "Page Not Found"; break;
                        case 410: _httpStatusMessage = "Record Not Found"; break;
                        case 428: _httpStatusMessage = "License Error"; break;
                        default: _httpStatusMessage = "Server Error"; break;
                    }
                }
                return _httpStatusMessage;
            }
        }

        /// <summary>
        ///    Gets the rendering mode for the error page. 
        /// </summary>
        private ErrorPageModes PageMode
        {
            get
            {
                if (_pageMode == null)
                {
                    _pageMode = ErrorPageModes.Anonymous;
                    if (this.CurrentSession != null && this.CurrentSession.Expiry >= DateTime.Now)
                        _pageMode |= ErrorPageModes.Authenticated;
                    if (String.Equals(HttpContext.Current.Request.ContentType, "application/json", StringComparison.OrdinalIgnoreCase))
                        _pageMode |= ErrorPageModes.RESTful;
                    if (HttpContext.Current.PreviousHandler is BasePopupPage || HttpContext.Current.Request.RawUrl.Contains("consensusframe=1"))
                        _pageMode |= ErrorPageModes.Popup;
                }

                return _pageMode.Value;
            }
        }

        #endregion

        #region page cycle

        protected void Page_PreInit(Object sender, EventArgs e)
        {
            // Ensure that the correct status code is returned to the user agent.
            this.Response.StatusCode = this.HttpStatusCode;
            this.Response.StatusDescription = this.HttpStatusDescription;

            // Set the master page required to render the error page.
            if (this.PageMode.HasFlag(ErrorPageModes.Popup))
                this.MasterPageFile = "~/assets/templates/popup.master";
            else if (this.PageMode.HasFlag(ErrorPageModes.Authenticated))
                this.MasterPageFile = "~/assets/templates/standard.master";
            else
                this.MasterPageFile = "~/assets/templates/basic.master";

            // Send a basic response for a RESTful API call.
            if (this.PageMode.HasFlag(ErrorPageModes.RESTful) && this.Exception != null)
            {
                // Construct the error information to be returned.
                Dictionary<String, String> errorDetail = new Dictionary<String, String>();
                errorDetail.Add("message", this.Exception.Message);
                errorDetail.Add("source", this.Exception.Source);
                errorDetail.Add("target", this.Exception.TargetSite == null ? null : String.Concat(this.Exception.TargetSite.DeclaringType.FullName, ".", this.Exception.TargetSite.Name));
                errorDetail.Add("stack ", this.Exception.StackTrace);

                // Return the details of the error.
                HttpContext.Current.Response.Clear();
                HttpContext.Current.Response.ContentType = "application/json";
                HttpContext.Current.Response.Write(RestHandler.Serializer.Serialize(errorDetail));
                HttpContext.Current.Response.End();
            }
            else if (!this.PageMode.HasFlag(ErrorPageModes.Popup))
            {
                // Redirect unauthenticated and unlicensed users to the relevant pages to authenticate/relicense.
                if (this.HttpStatusCode == 401)
                    HttpContext.Current.Server.Transfer(WebGlobals.LoginPage, false);
                else if (this.HttpStatusCode == 428)
                    HttpContext.Current.Server.Transfer(WebGlobals.LicensePage, false);
            }
        }

        protected void Page_PreRender(Object sender, EventArgs e)
        {
            // Initialise the error icon
            String errorMessage = ConfigurationManager.AppSettings["error_message"] ?? String.Empty;
            if (errorMessage == "")
                this.ErrorIcon.Attributes["class"] = "icons8-sad";
            else if (!errorMessage.Contains(":"))
                this.ErrorIcon.Attributes["class"] = "icons8-shit_hits_fan";
            else
                this.ErrorIcon.Attributes["class"] = "icons8-" + errorMessage.Substring(0, errorMessage.IndexOf(":"));

            // Initialise the error message
            this.ErrorText.InnerText = this.HttpStatusMessage;
            if (errorMessage == "")
                this.ErrorDesc.InnerText = this.HttpStatusDescription;
            else if (!errorMessage.Contains(":"))
                this.ErrorDesc.InnerText = errorMessage;
            else
                this.ErrorDesc.InnerText = errorMessage.Substring(errorMessage.IndexOf(":") + 1);

            // Initialise the error detail
            if (this.StackTrace.Visible = (this.HttpStatusCode == 500 && ConsensusDomain.Configuration[ConsensusDomain.Configuration.DefaultSite].ShowErrors && this.Exception != null))
            {
                this.StackTrace.InnerText = "Error: " + this.Exception.Message + Environment.NewLine;
                this.StackTrace.InnerText += "Source: " + this.Exception.Source + Environment.NewLine;
                this.StackTrace.InnerText += "Target: " + (this.Exception.TargetSite == null ? Environment.NewLine : this.Exception.TargetSite.DeclaringType.FullName + "." + this.Exception.TargetSite.Name + Environment.NewLine);
                this.StackTrace.InnerText += "Stack: " + this.Exception.StackTrace;
            }
        }

        #endregion
    }
}