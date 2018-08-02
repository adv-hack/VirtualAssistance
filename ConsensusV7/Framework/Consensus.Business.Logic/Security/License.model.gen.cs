using System;
using System.Collections.Generic;
using System.Linq;
using Consensus.Contact;

namespace Consensus.Security
{
    /// <summary>
    ///     Represents Represents a software license.
    /// </summary>
    /// <remarks>
    ///     THIS CODE HAS BEEN AUTOMATICALLY GENERATED USING THE CONSENSUS DEVELOPER TOOLS.
    ///     DO NOT EDIT THIS CODE AS ANY CUSTOM MODIFICATIONS WILL BE LOST UPON REGENERATION.
    /// </remarks>
    public partial class LocalLicenseModel : LocalModel<LicenseRecord, Guid>, ILicenseModel
    {
        #region fields

        /// <summary>
        ///     The value of the "LIC_OWNER" field.
        /// </summary>
        private LocalRoleModel _owner;

        /// <summary>
        ///     The collection of <see cref="LicenseLimitModel" /> instances that reference this <see cref="LicenseModel" />.
        /// </summary>
        private LocalCollection<LocalLicenseLimitModel, ILicenseLimitModel> _limits;

        #endregion

        #region properties

        /// <summary>
        ///     Gets the delegated function that is responsible for persisting a new instance of the data structure within the underlying persistence mechanism.
        /// </summary>
        protected override Action<LicenseRecord> DataCreator
        {
            get { return this.Provider.DataProvider.Security.License.Create; }
        }

        /// <summary>
        ///     Gets the delegated function that is responsible for persisting an existing instance of the data structure within the underlying persistence mechanism.
        /// </summary>
        protected override Action<LicenseRecord> DataModifier
        {
            get { return this.Provider.DataProvider.Security.License.Modify; }
        }

        /// <summary>
        ///     Gets the delegated function that is responsible for removing an existing instance of the data structure from the underlying persistence mechanism.
        /// </summary>
        protected override Action<LicenseRecord> DataRemover
        {
            get { return this.Provider.DataProvider.Security.License.RemoveById; }
        }

        /// <summary>
        ///     Gets or sets the value of the "LIC_ACTIVE" field.
        /// </summary>
        public DateTime Active
        {
            get { return this.ModifiedData.Active; }
            set { this.ModifiedData.Active = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "LIC_EXPIRY" field.
        /// </summary>
        public DateTime? Expiry
        {
            get { return this.ModifiedData.Expiry; }
            set { this.ModifiedData.Expiry = value; }
        }

        /// <summary>
        ///     Gets the The value of the "LIC_OWNER" field.
        /// </summary>
        public LocalRoleModel Owner
        {
            get
            {
                if (_owner == null)
                    _owner = this.Provider.Contact.Role.FetchById(this.OwnerId);
                if (_owner == null)
                    _owner = this.Provider.Contact.Role.Create();
                
                return _owner;
            }
        }

        /// <summary>
        ///     Gets or sets the unique code for the value of the "LIC_OWNER" field.
        /// </summary>
        public String OwnerId
        {
            get { return this.ModifiedData.Owner; }
            set
            {
                if (this.ModifiedData.Owner != value)
                     _owner = null;
                this.ModifiedData.Owner = value;
            }
        }

        /// <summary>
        ///     Gets the collection of <see cref="LicenseLimitModel" /> instances that reference this <see cref="LicenseModel" />.
        /// </summary>
        public LocalCollection<LocalLicenseLimitModel, ILicenseLimitModel> Limits
        {
            get
            {
                if (_limits == null)
                    _limits = new LocalCollection<LocalLicenseLimitModel, ILicenseLimitModel>(this.Provider.Security.LicenseLimit.FetchAllByLicenseId(this.Id));
                
                return _limits;
            }
        }

        #endregion

        #region constructors

        /// <summary>
        ///     Initialises a new <see cref="LocalLicenseModel" /> instance.
        /// </summary>
        /// <param name="provider">
        ///     The business provider to which the business model is bound.
        /// </param>
        internal LocalLicenseModel(LocalProvider provider) : base(provider)
        {
        }

        /// <summary>
        ///     Initialises a new <see cref="LocalLicenseModel" /> instance.
        /// </summary>
        /// <param name="provider">
        ///     The business provider to which the business model is bound.
        /// </param>
        /// <param name="record">
        ///     The data record which is encapsulated by the business model.
        /// </param>
        internal LocalLicenseModel(LocalProvider provider, LicenseRecord record) : base(provider, record)
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
            if (_owner != null)
            {
                _owner.Save();
                this.ModifiedData.Owner = _owner.Id == null && this.ModifiedData.Owner != null ? "" : _owner.Id;
            }
        }

        /// <summary>
        ///     Resolves the dependent models by means of updating all models that reference this model.
        /// </summary>
        protected override void ResolveGeneratedDependent()
        {
            base.ResolveGeneratedDependent();
            if (_limits != null)
                _limits.Execute(obj => obj.LicenseId = this.Id).Execute(obj => obj.Save());
        }

        #endregion

        #region implementations

        /// <summary>
        ///     Gets the collection of enabled modules;.
        /// </summary>
        Consensus.Security.LicenseModuleState[] ILicenseModel.Modules
        {
            get { return this.Modules; }
            set { this.Modules = (Consensus.Security.LicenseModuleState[])value; }
        }

        /// <summary>
        ///     Gets the computed status of the license.
        /// </summary>
        System.String ILicenseModel.StatusText
        {
            get { return this.StatusText; }
        }

        /// <summary>
        ///     Gets the computed status of the license.
        /// </summary>
        Consensus.Security.LicenseStatus ILicenseModel.Status
        {
            get { return this.Status; }
        }

        /// <summary>
        ///     Gets the hexadecimal encoded hash of the license-protected data which is signed to verify the license.
        /// </summary>
        System.String ILicenseModel.Verification
        {
            get { return this.Verification; }
        }

        /// <summary>
        ///     Gets the digital signature for the license.
        /// </summary>
        System.String ILicenseModel.Signature
        {
            get { return this.Signature; }
            set { this.Signature = (System.String)value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "LIC_ACTIVE" field.
        /// </summary>
        System.DateTime ILicenseModel.Active
        {
            get { return this.Active; }
            set { this.Active = (System.DateTime)value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "LIC_EXPIRY" field.
        /// </summary>
        System.Nullable<System.DateTime> ILicenseModel.Expiry
        {
            get { return this.Expiry; }
            set { this.Expiry = (System.Nullable<System.DateTime>)value; }
        }

        /// <summary>
        ///     Gets the The value of the "LIC_OWNER" field.
        /// </summary>
        Consensus.Contact.IRoleModel ILicenseModel.Owner
        {
            get { return this.Owner; }
        }

        /// <summary>
        ///     Gets or sets the unique code for the value of the "LIC_OWNER" field.
        /// </summary>
        System.String ILicenseModel.OwnerId
        {
            get { return this.OwnerId; }
            set { this.OwnerId = (System.String)value; }
        }

        /// <summary>
        ///     Gets the collection of <see cref="!:LicenseLimitModel" /> instances that reference this <see cref="!:LicenseModel" />.
        /// </summary>
        Consensus.Collection<Consensus.Security.ILicenseLimitModel> ILicenseModel.Limits
        {
            get { return this.Limits; }
        }

        /// <summary>
        ///     Saves the license key.
        /// </summary>
        void ILicenseModel.Save()
        {
            this.Save();
        }

        #endregion
    }
}
