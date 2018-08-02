using System;
using System.Collections.Generic;
using System.Linq;

namespace Consensus.Security
{
    /// <summary>
    ///     Represents Represents a limitation applied to a software license.
    /// </summary>
    /// <remarks>
    ///     THIS CODE HAS BEEN AUTOMATICALLY GENERATED USING THE CONSENSUS DEVELOPER TOOLS.
    ///     DO NOT EDIT THIS CODE AS ANY CUSTOM MODIFICATIONS WILL BE LOST UPON REGENERATION.
    /// </remarks>
    public partial class LocalLicenseLimitModel : LocalModel<LicenseLimitRecord, Int32>, ILicenseLimitModel
    {
        #region fields

        /// <summary>
        ///     The value of the "LL_LIC_ID" field.
        /// </summary>
        private LocalLicenseModel _license;

        #endregion

        #region properties

        /// <summary>
        ///     Gets the delegated function that is responsible for persisting a new instance of the data structure within the underlying persistence mechanism.
        /// </summary>
        protected override Action<LicenseLimitRecord> DataCreator
        {
            get { return this.Provider.DataProvider.Security.LicenseLimit.Create; }
        }

        /// <summary>
        ///     Gets the delegated function that is responsible for persisting an existing instance of the data structure within the underlying persistence mechanism.
        /// </summary>
        protected override Action<LicenseLimitRecord> DataModifier
        {
            get { return this.Provider.DataProvider.Security.LicenseLimit.Modify; }
        }

        /// <summary>
        ///     Gets the delegated function that is responsible for removing an existing instance of the data structure from the underlying persistence mechanism.
        /// </summary>
        protected override Action<LicenseLimitRecord> DataRemover
        {
            get { return this.Provider.DataProvider.Security.LicenseLimit.RemoveById; }
        }

        /// <summary>
        ///     Gets the The value of the "LL_LIC_ID" field.
        /// </summary>
        public LocalLicenseModel License
        {
            get
            {
                if (_license == null)
                    _license = this.Provider.Security.License.FetchById(this.LicenseId);
                if (_license == null)
                    _license = this.Provider.Security.License.Create();
                
                return _license;
            }
        }

        /// <summary>
        ///     Gets or sets the unique code for the value of the "LL_LIC_ID" field.
        /// </summary>
        public Guid LicenseId
        {
            get { return this.ModifiedData.LicId; }
            set
            {
                if (this.ModifiedData.LicId != value)
                     _license = null;
                this.ModifiedData.LicId = value;
            }
        }

        /// <summary>
        ///     Gets or sets the value of the "LL_VALUE" field.
        /// </summary>
        public Int32 Value
        {
            get { return this.ModifiedData.Value; }
            set { this.ModifiedData.Value = value; }
        }

        #endregion

        #region constructors

        /// <summary>
        ///     Initialises a new <see cref="LocalLicenseLimitModel" /> instance.
        /// </summary>
        /// <param name="provider">
        ///     The business provider to which the business model is bound.
        /// </param>
        internal LocalLicenseLimitModel(LocalProvider provider) : base(provider)
        {
        }

        /// <summary>
        ///     Initialises a new <see cref="LocalLicenseLimitModel" /> instance.
        /// </summary>
        /// <param name="provider">
        ///     The business provider to which the business model is bound.
        /// </param>
        /// <param name="record">
        ///     The data record which is encapsulated by the business model.
        /// </param>
        internal LocalLicenseLimitModel(LocalProvider provider, LicenseLimitRecord record) : base(provider, record)
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
            if (_license != null)
            {
                _license.Save();
                this.ModifiedData.LicId = _license.Id;
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
        ///     Gets or sets the type of limitation applied to the license.
        /// </summary>
        Consensus.Security.LicenseLimitTypes ILicenseLimitModel.Type
        {
            get { return this.Type; }
            set { this.Type = (Consensus.Security.LicenseLimitTypes)value; }
        }

        /// <summary>
        ///     Gets or sets the description of the limitation applied to the license.
        /// </summary>
        System.String ILicenseLimitModel.TypeDescription
        {
            get { return this.TypeDescription; }
        }

        /// <summary>
        ///     Gets the The value of the "LL_LIC_ID" field.
        /// </summary>
        Consensus.Security.ILicenseModel ILicenseLimitModel.License
        {
            get { return this.License; }
        }

        /// <summary>
        ///     Gets or sets the unique code for the value of the "LL_LIC_ID" field.
        /// </summary>
        System.Guid ILicenseLimitModel.LicenseId
        {
            get { return this.LicenseId; }
            set { this.LicenseId = (System.Guid)value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "LL_VALUE" field.
        /// </summary>
        System.Int32 ILicenseLimitModel.Value
        {
            get { return this.Value; }
            set { this.Value = (System.Int32)value; }
        }

        #endregion
    }
}
