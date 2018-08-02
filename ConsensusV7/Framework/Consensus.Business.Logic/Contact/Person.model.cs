using Consensus.Security;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Consensus.Contact
{
    /// <summary>
    ///     Represents An individual person.
    /// </summary>
    public partial class LocalPersonModel
    {
        #region fields

        /// <summary>
        ///     The principal role for the person.
        /// </summary>
        private LocalRoleModel _principalRole;

        /// <summary>
        ///     The active gift aid declaration for the person
        /// </summary>
        private LocalGiftaidModel _activeGiftAid;

        /// <summary>
        ///     The active user account
        /// </summary>
        private LocalUserAccountModel _activeUserAccount;

        #endregion

        #region properties

        /// <summary>
        ///    Gets or sets the principal role for the person.
        /// </summary>
        public LocalRoleModel PrincipalRole
        {
            get
            {
                if (_principalRole == null)
                    _principalRole = this.Roles.FirstOrDefault(role => role.IsPrincipal == 1);

                return _principalRole;
            }
            set
            {
                this.Roles.Execute(role => role.IsPrincipal = 0);
                value.IsPrincipal = 1;

                _principalRole = value;
            }
        }

        /// <summary>
        ///    Gets or sets the principal role for the person.
        /// </summary>
        public LocalGiftaidModel ActiveGiftAid
        {
            get
            {
                // Get the gift aid which is active
                if (_activeGiftAid == null)
                    _activeGiftAid = this.GiftAid.Where(giftAid => giftAid.Active).LastOrDefault();

                // If a gift aid doesn't exist yet (particularly for new people), create one and add to the list (so it can save when the person is saved).
                if (_activeGiftAid == null)
                    _activeGiftAid = this.Provider.Contact.Giftaid.Create();

                return _activeGiftAid;
            }
        }
        /// <summary>
        ///    Gets UserAccount
        /// </summary>
        public LocalUserAccountModel ActiveUserAccount
        {
            get
            {
                // Get the gift aid which is active
                if (_activeUserAccount == null)
                    _activeUserAccount = this.UserAccounts.FirstOrDefault();

                return _activeUserAccount;
            }
        } 

        /// <summary>
        ///     Gets the persons full name
        /// </summary>
        public String FullName
        {
            get { return String.Format("{0} {1} {2}", this.TitleCode, this.FirstName, this.Surname).TrimOrNullify(); }
        }

        #endregion

        #region methods

        /// <summary>
        ///     Resolves the dependencies by means of persisting all models that this model is referencing.
        /// </summary>
        protected override void ResolveDependency()
        {
            base.ResolveDependency();

            // If we are saving a new person, and the new person has an active gift aid, add this to the list of gift aids for the person so that it will save when the person is saved.
            if (!this.IsPersisted && !this.GiftAid.Contains(this.ActiveGiftAid) && this.ActiveGiftAid.Active.ConvertTo<Boolean>())
                this.GiftAid.Add(this.ActiveGiftAid);


        }

        #endregion
    }
}
