using System;
using System.Collections.Generic;
using System.Linq;

namespace Consensus.Document
{
    /// <summary>
    ///     Encapsulates the <see cref="PacktypeRecord" /> with standardised business rules.
    /// </summary>
    /// <remarks>
    ///     THIS CODE HAS BEEN AUTOMATICALLY GENERATED USING THE CONSENSUS DEVELOPER TOOLS.
    ///     DO NOT EDIT THIS CODE AS ANY CUSTOM MODIFICATIONS WILL BE LOST UPON REGENERATION.
    /// </remarks>
    public partial class LocalPacktypeModel : LocalModel<PacktypeRecord, Int32>, IPacktypeModel
    {
        #region properties

        /// <summary>
        ///     Gets the delegated function that is responsible for persisting a new instance of the data structure within the underlying persistence mechanism.
        /// </summary>
        protected override Action<PacktypeRecord> DataCreator
        {
            get { return this.Provider.DataProvider.Document.Packtype.Create; }
        }

        /// <summary>
        ///     Gets the delegated function that is responsible for persisting an existing instance of the data structure within the underlying persistence mechanism.
        /// </summary>
        protected override Action<PacktypeRecord> DataModifier
        {
            get { return this.Provider.DataProvider.Document.Packtype.Modify; }
        }

        /// <summary>
        ///     Gets the delegated function that is responsible for removing an existing instance of the data structure from the underlying persistence mechanism.
        /// </summary>
        protected override Action<PacktypeRecord> DataRemover
        {
            get { return this.Provider.DataProvider.Document.Packtype.RemoveById; }
        }

        /// <summary>
        ///     Gets or sets the value of the "PACKTYP_TYPE" field.
        /// </summary>
        public Byte Type
        {
            get { return this.ModifiedData.Type; }
            set { this.ModifiedData.Type = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "PACKTYP_DESC" field.
        /// </summary>
        public String Desc
        {
            get { return this.ModifiedData.Desc; }
            set { this.ModifiedData.Desc = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "PACKTYP_STORED_PROC" field.
        /// </summary>
        public String StoredProc
        {
            get { return this.ModifiedData.StoredProc; }
            set { this.ModifiedData.StoredProc = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "PACKTYP_URL" field.
        /// </summary>
        public String Url
        {
            get { return this.ModifiedData.Url; }
            set { this.ModifiedData.Url = value; }
        }

        #endregion

        #region constructors

        /// <summary>
        ///     Initialises a new <see cref="LocalPacktypeModel" /> instance.
        /// </summary>
        /// <param name="provider">
        ///     The business provider to which the business model is bound.
        /// </param>
        internal LocalPacktypeModel(LocalProvider provider) : base(provider)
        {
        }

        /// <summary>
        ///     Initialises a new <see cref="LocalPacktypeModel" /> instance.
        /// </summary>
        /// <param name="provider">
        ///     The business provider to which the business model is bound.
        /// </param>
        /// <param name="record">
        ///     The data record which is encapsulated by the business model.
        /// </param>
        internal LocalPacktypeModel(LocalProvider provider, PacktypeRecord record) : base(provider, record)
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
        ///     Gets or sets the value of the "PACKTYP_TYPE" field.
        /// </summary>
        System.Byte IPacktypeModel.Type
        {
            get { return this.Type; }
            set { this.Type = (System.Byte)value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "PACKTYP_DESC" field.
        /// </summary>
        System.String IPacktypeModel.Desc
        {
            get { return this.Desc; }
            set { this.Desc = (System.String)value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "PACKTYP_STORED_PROC" field.
        /// </summary>
        System.String IPacktypeModel.StoredProc
        {
            get { return this.StoredProc; }
            set { this.StoredProc = (System.String)value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "PACKTYP_URL" field.
        /// </summary>
        System.String IPacktypeModel.Url
        {
            get { return this.Url; }
            set { this.Url = (System.String)value; }
        }

        #endregion
    }
}
