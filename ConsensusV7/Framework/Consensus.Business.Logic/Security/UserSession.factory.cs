using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Web;

namespace Consensus.Security
{
    /// <summary>
    ///     Supports the instantiation of the <see cref="UserSessionModel" /> object.
    /// </summary>
    public partial class LocalUserSessionFactory
    {
        #region fields

        /// <summary>
        ///     The unique key of the HTTP-session persisted authentication object.
        /// </summary>
        internal const String SessionKey = "current_user";

        #endregion

        #region methods

        /// <summary>
        ///     Gets the authentication session for the currently logged on user.
        /// </summary>
        /// <returns>
        ///     The <see cref="IUserSessionModel"/> for the currently authenticated user.
        /// </returns>
        public LocalUserSessionModel FetchCurrent()
        {
            if (HttpContext.Current == null || HttpContext.Current.Session == null)
                return null;
            else
                return HttpContext.Current.Session[LocalUserSessionFactory.SessionKey] as LocalUserSessionModel;
        }

        /// <summary>
        ///     Authenticates a user account using pre-shared credentials.
        /// </summary>
        /// <param name="username">
        ///     The unique name which distinctly identifies the account to be authenticated.
        /// </param>
        /// <param name="password">
        ///     The pre-shared secret which confirms the identity of the authenticating user.
        /// </param>
        /// <returns>
        ///     The <see cref="IUserSessionModel" /> instance for the authenticated user.
        /// </returns>
        public void Login(String username, String password)
        {
            // Validate the credentials
            if (String.IsNullOrEmpty(username))
                throw new ArgumentException("Please specify a username.");
            if (String.IsNullOrEmpty(password))
                throw new ArgumentException("Please specify a password.");

            // Validate the account
            LocalUserAccountModel userAccount = this.Provider.Security.UserAccount.FetchByUsername(username);
            if (userAccount == null)
                throw new ArgumentException("Incorrect username or password.");
            if (userAccount.Credentials.Count == 0)
                throw new ArgumentException("Incorrect username or password.");

            // Validate the password
            LocalUserCredentialModel credential = userAccount.Credentials.OrderBy(cred => cred.Modified).LastOrDefault();
            using (SHA512 hashAlgoritm = SHA512.Create())
            {
                Byte[] passBytes = Encoding.UTF8.GetBytes(password);
                Byte[] fullBytes = credential.Salt.Concat(passBytes).ToArray();
                Byte[] hashBytes = hashAlgoritm.ComputeHash(fullBytes);

                Boolean success = hashBytes.SequenceEqual(credential.Pass);
                userAccount.FailCount = success ? 0 : userAccount.FailCount + 1;
                userAccount.LastLogin = success ? DateTime.Now : userAccount.LastLogin;
                userAccount.Save();
                if (!success)
                    throw new ArgumentException("Incorrect username or password.");
                else
                {
                    if (userAccount.Status == 0)
                        throw new ArgumentException("Your account is inactive.");
                    else
                    {
                        var licenseLimit = this.Provider.Security.LicenseLimit.FetchAll().Where(x => (int)x.Type == userAccount.LicenseType).FirstOrDefault();

                        if (licenseLimit != null)
                        {
                            //Checks total number of Licenses currently in use                                               
                            var totalUserSessions = this.Provider.Security.UserSession.FetchAll().Where(x => x.Status == UserSessionStates.Active && x.User.LicenseType == userAccount.LicenseType).OrderByDescending(x => x.Active).Select(x => x.UserId).Distinct().ToList();

                            //Checks if already logged in user signs in again
                            var isSameUser = totalUserSessions.ToList().Any(x => x == userAccount.Id);
                            if (!isSameUser && totalUserSessions.Count >= licenseLimit.Value)
                            {
                                throw new ArgumentException("All licences are currently in use.");
                            }

                            if (isSameUser && totalUserSessions.Count > licenseLimit.Value)
                            {
                                throw new ArgumentException("All licences are currently in use.");
                            }
                        }

                    }
                }
            }

            // Create the new session
            LocalUserSessionModel session = this.Provider.Security.UserSession.Create();
            session.UserId = userAccount.Id;
            session.Active = DateTime.Now;
            session.Expiry = DateTime.Now.AddMinutes(HttpContext.Current.Session.Timeout);
            session.Save();

            // Persist and return the session
            HttpContext.Current.Session[LocalUserSessionFactory.SessionKey] = session;
        }

        /// <summary>
        ///     Extends the expiry period for the current authentication session.
        /// </summary>
        public void Update()
        {
            LocalUserSessionModel session = this.FetchCurrent();
            if (session != null)
            {
                session.Expiry = DateTime.Now.AddMinutes(HttpContext.Current.Session.Timeout);
                session.Save();
                HttpContext.Current.Session[LocalUserSessionFactory.SessionKey] = session;
            }
        }

        /// <summary>
        ///     Terminates the current authentication session.
        /// </summary>
        public void Logout()
        {
            LocalUserSessionModel session = this.FetchCurrent();
            if (session != null)
                session.Logout();

            HttpContext.Current.Session[LocalUserSessionFactory.SessionKey] = null;
        }

        #endregion
    }
}
