using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Consensus.Security
{
    /// <summary>
    ///     Represents Represents a current or historic authentication session.
    /// </summary>
    public partial class LocalUserSessionModel
    {
        #region properties

        /// <summary>
        ///     Gets the status of the authentication session.
        /// </summary>
        public UserSessionStates Status
        {
            get
            {
                UserSessionStates state = this.ModifiedData.Status.ConvertTo<UserSessionStates>();
                if (state == UserSessionStates.LoggedOff)
                    return state;
                if (state == UserSessionStates.Terminated)
                    return state;
                if (this.Expiry <= DateTime.Now)
                    return UserSessionStates.Expired;

                return UserSessionStates.Active;
            }
        }

        #endregion

        #region methods

        /// <summary>
        ///     Terminates the current authentication session.
        /// </summary>
        internal void Logout()
        {
            this.ModifiedData.Status = (Int32)UserSessionStates.LoggedOff;
            this.ModifiedData.Expiry = DateTime.Now;
            this.Save();
        }

        #endregion
    }
}
