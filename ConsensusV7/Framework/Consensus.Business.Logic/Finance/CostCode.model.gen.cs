using System;
using System.Collections.Generic;
using System.Linq;
using Consensus.Common;

namespace Consensus.Finance
{
    /// <summary>
    ///     Encapsulates the <see cref="CostCodeRecord" /> with standardised business rules.
    /// </summary>
    /// <remarks>
    ///     THIS CODE HAS BEEN AUTOMATICALLY GENERATED USING THE CONSENSUS DEVELOPER TOOLS.
    ///     DO NOT EDIT THIS CODE AS ANY CUSTOM MODIFICATIONS WILL BE LOST UPON REGENERATION.
    /// </remarks>
    public partial class LocalCostCodeModel : LocalModel<CostCodeRecord, String>, ICostCodeModel
    {
        #region fields

        /// <summary>
        ///     The value of the "COST_SELCO_SP_ID" field.
        /// </summary>
        private LocalSellingCompanyModel _selcoSpId;

        #endregion

        #region properties

        /// <summary>
        ///     Gets the delegated function that is responsible for persisting a new instance of the data structure within the underlying persistence mechanism.
        /// </summary>
        protected override Action<CostCodeRecord> DataCreator
        {
            get { return this.Provider.DataProvider.Finance.CostCode.Create; }
        }

        /// <summary>
        ///     Gets the delegated function that is responsible for persisting an existing instance of the data structure within the underlying persistence mechanism.
        /// </summary>
        protected override Action<CostCodeRecord> DataModifier
        {
            get { return this.Provider.DataProvider.Finance.CostCode.Modify; }
        }

        /// <summary>
        ///     Gets the delegated function that is responsible for removing an existing instance of the data structure from the underlying persistence mechanism.
        /// </summary>
        protected override Action<CostCodeRecord> DataRemover
        {
            get { return this.Provider.DataProvider.Finance.CostCode.RemoveById; }
        }

        /// <summary>
        ///     Gets or sets the value of the "COST_CODE" field.
        /// </summary>
        public String Code
        {
            get { return this.ModifiedData.Code; }
            set { this.ModifiedData.Code = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "COST_DESC" field.
        /// </summary>
        public String Desc
        {
            get { return this.ModifiedData.Desc; }
            set { this.ModifiedData.Desc = value; }
        }

        /// <summary>
        ///     Gets the The value of the "COST_SELCO_SP_ID" field.
        /// </summary>
        public LocalSellingCompanyModel SelcoSpId
        {
            get
            {
                if (_selcoSpId == null && this.SelcoSpIdId != null)
                    _selcoSpId = this.Provider.Common.SellingCompany.FetchById(this.SelcoSpIdId);
                if (_selcoSpId == null)
                    _selcoSpId = this.Provider.Common.SellingCompany.Create();
                
                return _selcoSpId;
            }
        }

        /// <summary>
        ///     Gets or sets the unique code for the value of the "COST_SELCO_SP_ID" field.
        /// </summary>
        public String SelcoSpIdId
        {
            get { return this.ModifiedData.SelcoSpId; }
            set
            {
                if (this.ModifiedData.SelcoSpId != value)
                     _selcoSpId = null;
                this.ModifiedData.SelcoSpId = value;
            }
        }

        #endregion

        #region constructors

        /// <summary>
        ///     Initialises a new <see cref="LocalCostCodeModel" /> instance.
        /// </summary>
        /// <param name="provider">
        ///     The business provider to which the business model is bound.
        /// </param>
        internal LocalCostCodeModel(LocalProvider provider) : base(provider)
        {
        }

        /// <summary>
        ///     Initialises a new <see cref="LocalCostCodeModel" /> instance.
        /// </summary>
        /// <param name="provider">
        ///     The business provider to which the business model is bound.
        /// </param>
        /// <param name="record">
        ///     The data record which is encapsulated by the business model.
        /// </param>
        internal LocalCostCodeModel(LocalProvider provider, CostCodeRecord record) : base(provider, record)
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
            if (_selcoSpId != null)
            {
                _selcoSpId.Save();
                this.ModifiedData.SelcoSpId = _selcoSpId.Id == null && this.ModifiedData.SelcoSpId != null ? "" : _selcoSpId.Id;
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
        ///     Gets or sets the value of the "COST_CODE" field.
        /// </summary>
        System.String ICostCodeModel.Code
        {
            get { return this.Code; }
            set { this.Code = (System.String)value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "COST_DESC" field.
        /// </summary>
        System.String ICostCodeModel.Desc
        {
            get { return this.Desc; }
            set { this.Desc = (System.String)value; }
        }

        /// <summary>
        ///     Gets the The value of the "COST_SELCO_SP_ID" field.
        /// </summary>
        Consensus.Common.ISellingCompanyModel ICostCodeModel.SelcoSpId
        {
            get { return this.SelcoSpId; }
        }

        /// <summary>
        ///     Gets or sets the unique code for the value of the "COST_SELCO_SP_ID" field.
        /// </summary>
        System.String ICostCodeModel.SelcoSpIdId
        {
            get { return this.SelcoSpIdId; }
            set { this.SelcoSpIdId = (System.String)value; }
        }

        #endregion
    }
}
