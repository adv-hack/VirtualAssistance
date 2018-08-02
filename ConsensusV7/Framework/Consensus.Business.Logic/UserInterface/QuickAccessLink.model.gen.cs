using System;
using System.Collections.Generic;
using System.Linq;
using Consensus.Security;

namespace Consensus.UserInterface
{
    /// <summary>
    ///     Encapsulates the <see cref="QuickaccesslinkRecord" /> with standardised business rules.
    /// </summary>
    /// <remarks>
    ///     THIS CODE HAS BEEN AUTOMATICALLY GENERATED USING THE CONSENSUS DEVELOPER TOOLS.
    ///     DO NOT EDIT THIS CODE AS ANY CUSTOM MODIFICATIONS WILL BE LOST UPON REGENERATION.
    /// </remarks>
    public partial class LocalQuickAccessLinkModel : LocalModel<QuickaccesslinkRecord, Int32>, IQuickAccessLinkModel
    {
        #region fields

        /// <summary>
        ///     The value of the "QAL_USER_ID" field.
        /// </summary>
        private LocalUserAccountModel _user;

        #endregion

        #region properties

        /// <summary>
        ///     Gets the delegated function that is responsible for persisting a new instance of the data structure within the underlying persistence mechanism.
        /// </summary>
        protected override Action<QuickaccesslinkRecord> DataCreator
        {
            get { return this.Provider.DataProvider.UserInterface.QuickAccessLink.Create; }
        }

        /// <summary>
        ///     Gets the delegated function that is responsible for persisting an existing instance of the data structure within the underlying persistence mechanism.
        /// </summary>
        protected override Action<QuickaccesslinkRecord> DataModifier
        {
            get { return this.Provider.DataProvider.UserInterface.QuickAccessLink.Modify; }
        }

        /// <summary>
        ///     Gets the delegated function that is responsible for removing an existing instance of the data structure from the underlying persistence mechanism.
        /// </summary>
        protected override Action<QuickaccesslinkRecord> DataRemover
        {
            get { return this.Provider.DataProvider.UserInterface.QuickAccessLink.RemoveById; }
        }

        /// <summary>
        ///     Gets the The value of the "QAL_USER_ID" field.
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
        ///     Gets or sets the unique code for the value of the "QAL_USER_ID" field.
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
        ///     Gets or sets the value of the "QAL_DESCRIPTION" field.
        /// </summary>
        public String Description
        {
            get { return this.ModifiedData.Description; }
            set { this.ModifiedData.Description = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "QAL_URL" field.
        /// </summary>
        public String Url
        {
            get { return this.ModifiedData.Url; }
            set { this.ModifiedData.Url = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "QAL_ICON" field.
        /// </summary>
        public String Icon
        {
            get { return this.ModifiedData.Icon; }
            set { this.ModifiedData.Icon = value; }
        }

        #endregion

        #region constructors

        /// <summary>
        ///     Initialises a new <see cref="LocalQuickAccessLinkModel" /> instance.
        /// </summary>
        /// <param name="provider">
        ///     The business provider to which the business model is bound.
        /// </param>
        internal LocalQuickAccessLinkModel(LocalProvider provider) : base(provider)
        {
        }

        /// <summary>
        ///     Initialises a new <see cref="LocalQuickAccessLinkModel" /> instance.
        /// </summary>
        /// <param name="provider">
        ///     The business provider to which the business model is bound.
        /// </param>
        /// <param name="record">
        ///     The data record which is encapsulated by the business model.
        /// </param>
        internal LocalQuickAccessLinkModel(LocalProvider provider, QuickaccesslinkRecord record) : base(provider, record)
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
        ///     Gets the The value of the "QAL_USER_ID" field.
        /// </summary>
        Consensus.Security.IUserAccountModel IQuickAccessLinkModel.User
        {
            get { return this.User; }
        }

        /// <summary>
        ///     Gets or sets the unique code for the value of the "QAL_USER_ID" field.
        /// </summary>
        System.Int32 IQuickAccessLinkModel.UserId
        {
            get { return this.UserId; }
            set { this.UserId = (System.Int32)value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "QAL_DESCRIPTION" field.
        /// </summary>
        System.String IQuickAccessLinkModel.Description
        {
            get { return this.Description; }
            set { this.Description = (System.String)value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "QAL_URL" field.
        /// </summary>
        System.String IQuickAccessLinkModel.Url
        {
            get { return this.Url; }
            set { this.Url = (System.String)value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "QAL_ICON" field.
        /// </summary>
        System.String IQuickAccessLinkModel.Icon
        {
            get { return this.Icon; }
            set { this.Icon = (System.String)value; }
        }

        #endregion
    }
}
