using System;
using System.Collections.Generic;
using System.Linq;

namespace Consensus.Security
{
    /// <summary>
    ///     Represents Represents a current or historic authentication session.
    /// </summary>
    /// <remarks>
    ///     THIS CODE HAS BEEN AUTOMATICALLY GENERATED USING THE CONSENSUS DEVELOPER TOOLS.
    ///     DO NOT EDIT THIS CODE AS ANY CUSTOM MODIFICATIONS WILL BE LOST UPON REGENERATION.
    /// </remarks>
    public partial class LocalUserSessionModel : LocalModel<UserSessionRecord, Guid>, IUserSessionModel
    {
        #region fields

        /// <summary>
        ///     The user account that has been authenticated.
        /// </summary>
        private LocalUserAccountModel _user;

        #endregion

        #region properties

        /// <summary>
        ///     Gets the delegated function that is responsible for persisting a new instance of the data structure within the underlying persistence mechanism.
        /// </summary>
        protected override Action<UserSessionRecord> DataCreator
        {
            get { return this.Provider.DataProvider.Security.UserSession.Create; }
        }

        /// <summary>
        ///     Gets the delegated function that is responsible for persisting an existing instance of the data structure within the underlying persistence mechanism.
        /// </summary>
        protected override Action<UserSessionRecord> DataModifier
        {
            get { return this.Provider.DataProvider.Security.UserSession.Modify; }
        }

        /// <summary>
        ///     Gets the delegated function that is responsible for removing an existing instance of the data structure from the underlying persistence mechanism.
        /// </summary>
        protected override Action<UserSessionRecord> DataRemover
        {
            get { return this.Provider.DataProvider.Security.UserSession.RemoveById; }
        }

        /// <summary>
        ///     Gets the The user account that has been authenticated.
        /// </summary>
        public LocalUserAccountModel User
        {
            get
            {
                if (_user == null)
                    _user = this.Provider.Security.UserAccount.FetchById(this.UserId);
                if (_user == null)
                    _user = this.Provider.Security.UserAccount.Create();
                
                return _user;
            }
        }

        /// <summary>
        ///     Gets or sets the unique code for The user account that has been authenticated.
        /// </summary>
        public Int32 UserId
        {
            get { return this.ModifiedData.UserId; }
            set
            {
                if (this.ModifiedData.UserId != value)
                     _user = null;
                this.ModifiedData.UserId = value;
            }
        }

        /// <summary>
        ///     Gets or sets The date and time on which the session became active.
        /// </summary>
        public DateTime Active
        {
            get { return this.ModifiedData.Active; }
            set { this.ModifiedData.Active = value; }
        }

        /// <summary>
        ///     Gets or sets The date and time on which the session automatically expires, or was terminated.
        /// </summary>
        public DateTime Expiry
        {
            get { return this.ModifiedData.Expiry; }
            set { this.ModifiedData.Expiry = value; }
        }

        #endregion

        #region constructors

        /// <summary>
        ///     Initialises a new <see cref="LocalUserSessionModel" /> instance.
        /// </summary>
        /// <param name="provider">
        ///     The business provider to which the business model is bound.
        /// </param>
        internal LocalUserSessionModel(LocalProvider provider) : base(provider)
        {
        }

        /// <summary>
        ///     Initialises a new <see cref="LocalUserSessionModel" /> instance.
        /// </summary>
        /// <param name="provider">
        ///     The business provider to which the business model is bound.
        /// </param>
        /// <param name="record">
        ///     The data record which is encapsulated by the business model.
        /// </param>
        internal LocalUserSessionModel(LocalProvider provider, UserSessionRecord record) : base(provider, record)
        {
        }

        #endregion

        #region methods

        /// <summary>
        ///     Resolves the dependencies by means of persisting all models that this model is referencing.
        /// </summary>
        protected override void ResolveGeneratedDependency()
        {
            base.ResolveGeneratedDependency();
            if (_user != null)
            {
                _user.Save();
                this.ModifiedData.UserId = _user.Id;
            }
        }

        /// <summary>
        ///     Resolves the dependent models by means of updating all models that reference this model.
        /// </summary>
        protected override void ResolveGeneratedDependent()
        {
            base.ResolveGeneratedDependent();
        }

        #endregion

        #region implementations

        /// <summary>
        ///     Gets the status of the authentication session.
        /// </summary>
        Consensus.Security.UserSessionStates IUserSessionModel.Status
        {
            get { return this.Status; }
        }

        /// <summary>
        ///     Gets the The user account that has been authenticated.
        /// </summary>
        Consensus.Security.IUserAccountModel IUserSessionModel.User
        {
            get { return this.User; }
        }

        /// <summary>
        ///     Gets or sets the unique code for The user account that has been authenticated.
        /// </summary>
        System.Int32 IUserSessionModel.UserId
        {
            get { return this.UserId; }
            set { this.UserId = (System.Int32)value; }
        }

        /// <summary>
        ///     Gets or sets The date and time on which the session became active.
        /// </summary>
        System.DateTime IUserSessionModel.Active
        {
            get { return this.Active; }
            set { this.Active = (System.DateTime)value; }
        }

        /// <summary>
        ///     Gets or sets The date and time on which the session automatically expires, or was terminated.
        /// </summary>
        System.DateTime IUserSessionModel.Expiry
        {
            get { return this.Expiry; }
            set { this.Expiry = (System.DateTime)value; }
        }

        #endregion
    }
}
