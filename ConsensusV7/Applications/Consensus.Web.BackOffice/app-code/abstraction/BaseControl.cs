using Consensus.Security;
using Consensus.Web.Controls;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;

namespace Consensus.Web.BackOffice
{
    /// <summary>
    ///     Provides the abstraction for all user controls within the web application.
    /// </summary>
    public abstract class BaseControl : UserControl
    {
        #region fields

        /// <summary>
        ///     The name of the property to which the control is bound.
        /// </summary>
        private String _dataBoundObject;

        /// <summary>
        ///     The name of the property to which the unique identifier is bound to.
        /// </summary>
        private String _dataBoundId;

        /// <summary>
        ///     The hidden field which holds the unique identifier value.
        /// </summary>
        private HiddenField _idField;

        /// <summary>
        ///     The current authentication session.
        /// </summary>
        private UserSession _currentSession;
        
        private Boolean _allowDelete = true;

        #endregion

        #region properties

        public abstract String DataTypeName
        {
            get;
        }


        public virtual Boolean AllowDelete
        {
            get { return _allowDelete; }
            set { _allowDelete = value; }
        }

        public String DeleteMessage { get; set; }

        /// <summary>
        ///     Gets or sets the name of the property to which the control is bound.
        /// </summary>
        public String DataBoundObject
        {
            get { return _dataBoundObject; }
            set { _dataBoundObject = value; }
        }

        /// <summary>
        ///     Gets or sets the name of the property to which the unique identifier is bound to.
        /// </summary>
        public String DataBoundId
        {
            get { return _dataBoundId; }
            set { _dataBoundId = value; }
        }

        /// <summary>
        ///     Gets the hidden field which holds the unique identifier value.
        /// </summary>
        public HiddenField IdField
        {
            get
            {
                if (_idField == null)
                    _idField = new HiddenField();

                return _idField;
            }
        }

        /// <summary>
        ///    Gets the current authentication session.
        /// </summary>
        protected internal UserSession CurrentSession
        {
            get
            {
                if (_currentSession == null && this.Page is BasePage)
                    _currentSession = (this.Page as BasePage).CurrentSession;

                return _currentSession;
            }
        }

        protected override void OnPreRender(EventArgs e)
        {
            base.OnPreRender(e);

            if (AllowDelete && !string.IsNullOrEmpty(DeleteMessage) && !Page.ClientScript.IsStartupScriptRegistered("_deleteMessage")) {
                Page.ClientScript.RegisterStartupScript(Page.GetType(), "_deleteMessage", string.Format(@"
function getDeleteMessage() {{
    return {0};
}}
                ", HttpUtility.JavaScriptStringEncode(DeleteMessage, true)), true);
            }
        }

        #endregion
    }
}