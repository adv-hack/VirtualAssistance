using System;
using System.Collections.Generic;
using System.Linq;

namespace Consensus.Security
{
    /// <summary>
    ///     Represents Represents a module that is included within a license.
    /// </summary>
    /// <remarks>
    ///     THIS CODE HAS BEEN AUTOMATICALLY GENERATED USING THE CONSENSUS DEVELOPER TOOLS.
    ///     DO NOT EDIT THIS CODE AS ANY CUSTOM MODIFICATIONS WILL BE LOST UPON REGENERATION.
    /// </remarks>
    public partial class LocalLicenseModuleModel : LocalModel<LicenseModuleRecord, Int32>, ILicenseModuleModel
    {
        #region properties

        /// <summary>
        ///     Gets the delegated function that is responsible for persisting a new instance of the data structure within the underlying persistence mechanism.
        /// </summary>
        protected override Action<LicenseModuleRecord> DataCreator
        {
            get { return this.Provider.DataProvider.Security.LicenseModule.Create; }
        }

        /// <summary>
        ///     Gets the delegated function that is responsible for persisting an existing instance of the data structure within the underlying persistence mechanism.
        /// </summary>
        protected override Action<LicenseModuleRecord> DataModifier
        {
            get { return this.Provider.DataProvider.Security.LicenseModule.Modify; }
        }

        /// <summary>
        ///     Gets the delegated function that is responsible for removing an existing instance of the data structure from the underlying persistence mechanism.
        /// </summary>
        protected override Action<LicenseModuleRecord> DataRemover
        {
            get { return this.Provider.DataProvider.Security.LicenseModule.RemoveById; }
        }

        /// <summary>
        ///     Gets or sets the value of the "LM_LIC_ID" field.
        /// </summary>
        public Guid License
        {
            get { return this.ModifiedData.LicId; }
            set { this.ModifiedData.LicId = value; }
        }

        #endregion

        #region constructors

        /// <summary>
        ///     Initialises a new <see cref="LocalLicenseModuleModel" /> instance.
        /// </summary>
        /// <param name="provider">
        ///     The business provider to which the business model is bound.
        /// </param>
        internal LocalLicenseModuleModel(LocalProvider provider) : base(provider)
        {
        }

        /// <summary>
        ///     Initialises a new <see cref="LocalLicenseModuleModel" /> instance.
        /// </summary>
        /// <param name="provider">
        ///     The business provider to which the business model is bound.
        /// </param>
        /// <param name="record">
        ///     The data record which is encapsulated by the business model.
        /// </param>
        internal LocalLicenseModuleModel(LocalProvider provider, LicenseModuleRecord record) : base(provider, record)
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
        ///     Gets or sets the module that is included within the license.
        /// </summary>
        Consensus.Security.LicenseModules ILicenseModuleModel.Module
        {
            get { return this.Module; }
            set { this.Module = (Consensus.Security.LicenseModules)value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "LM_LIC_ID" field.
        /// </summary>
        System.Guid ILicenseModuleModel.License
        {
            get { return this.License; }
            set { this.License = (System.Guid)value; }
        }

        #endregion
    }
}
