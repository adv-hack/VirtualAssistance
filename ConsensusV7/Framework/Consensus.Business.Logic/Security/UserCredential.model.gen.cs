using System;
using System.Collections.Generic;
using System.Linq;

namespace Consensus.Security
{
    /// <summary>
    ///     Represents Represents a current or historic credential used to authenticate a user.
    /// </summary>
    /// <remarks>
    ///     THIS CODE HAS BEEN AUTOMATICALLY GENERATED USING THE CONSENSUS DEVELOPER TOOLS.
    ///     DO NOT EDIT THIS CODE AS ANY CUSTOM MODIFICATIONS WILL BE LOST UPON REGENERATION.
    /// </remarks>
    public partial class LocalUserCredentialModel : LocalModel<UserCredentialRecord, Int32>, IUserCredentialModel
    {
        #region fields

        /// <summary>
        ///     The user account to whom the password belongs.
        /// </summary>
        private LocalUserAccountModel _user;

        #endregion

        #region properties

        /// <summary>
        ///     Gets the delegated function that is responsible for persisting a new instance of the data structure within the underlying persistence mechanism.
        /// </summary>
        protected override Action<UserCredentialRecord> DataCreator
        {
            get { return this.Provider.DataProvider.Security.UserCredential.Create; }
        }

        /// <summary>
        ///     Gets the delegated function that is responsible for persisting an existing instance of the data structure within the underlying persistence mechanism.
        /// </summary>
        protected override Action<UserCredentialRecord> DataModifier
        {
            get { return this.Provider.DataProvider.Security.UserCredential.Modify; }
        }

        /// <summary>
        ///     Gets the delegated function that is responsible for removing an existing instance of the data structure from the underlying persistence mechanism.
        /// </summary>
        protected override Action<UserCredentialRecord> DataRemover
        {
            get { return this.Provider.DataProvider.Security.UserCredential.RemoveById; }
        }

        /// <summary>
        ///     Gets the The user account to whom the password belongs.
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
        ///     Gets or sets the unique code for The user account to whom the password belongs.
        /// </summary>
        public Int32 UserId
        {
            get { return this.ModifiedData.User; }
            set
            {
                if (this.ModifiedData.User != value)
                     _user = null;
                this.ModifiedData.User = value;
            }
        }

        /// <summary>
        ///     Gets or sets The salting value for the password,.
        /// </summary>
        public Byte[] Salt
        {
            get { return this.ModifiedData.Salt; }
            set { this.ModifiedData.Salt = value; }
        }

        /// <summary>
        ///     Gets or sets The verifier for the password.
        /// </summary>
        public Byte[] Pass
        {
            get { return this.ModifiedData.Pass; }
            set { this.ModifiedData.Pass = value; }
        }

        /// <summary>
        ///     Gets or sets The date and time on which the password was set.
        /// </summary>
        public DateTime Modified
        {
            get { return this.ModifiedData.Modified; }
            set { this.ModifiedData.Modified = value; }
        }

        #endregion

        #region constructors

        /// <summary>
        ///     Initialises a new <see cref="LocalUserCredentialModel" /> instance.
        /// </summary>
        /// <param name="provider">
        ///     The business provider to which the business model is bound.
        /// </param>
        internal LocalUserCredentialModel(LocalProvider provider) : base(provider)
        {
        }

        /// <summary>
        ///     Initialises a new <see cref="LocalUserCredentialModel" /> instance.
        /// </summary>
        /// <param name="provider">
        ///     The business provider to which the business model is bound.
        /// </param>
        /// <param name="record">
        ///     The data record which is encapsulated by the business model.
        /// </param>
        internal LocalUserCredentialModel(LocalProvider provider, UserCredentialRecord record) : base(provider, record)
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
                this.ModifiedData.User = _user.Id;
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
        ///     Gets the The user account to whom the password belongs.
        /// </summary>
        Consensus.Security.IUserAccountModel IUserCredentialModel.User
        {
            get { return this.User; }
        }

        /// <summary>
        ///     Gets or sets the unique code for The user account to whom the password belongs.
        /// </summary>
        System.Int32 IUserCredentialModel.UserId
        {
            get { return this.UserId; }
            set { this.UserId = (System.Int32)value; }
        }

        /// <summary>
        ///     Gets or sets The salting value for the password,.
        /// </summary>
        System.Byte[] IUserCredentialModel.Salt
        {
            get { return this.Salt; }
            set { this.Salt = (System.Byte[])value; }
        }

        /// <summary>
        ///     Gets or sets The verifier for the password.
        /// </summary>
        System.Byte[] IUserCredentialModel.Pass
        {
            get { return this.Pass; }
            set { this.Pass = (System.Byte[])value; }
        }

        /// <summary>
        ///     Gets or sets The date and time on which the password was set.
        /// </summary>
        System.DateTime IUserCredentialModel.Modified
        {
            get { return this.Modified; }
            set { this.Modified = (System.DateTime)value; }
        }

        #endregion
    }
}
