using System;
using System.Collections.Generic;
using System.Linq;

namespace Consensus.Learning
{
    /// <summary>
    ///     Encapsulates the <see cref="TemplateXrefRecord" /> with standardised business rules.
    /// </summary>
    /// <remarks>
    ///     THIS CODE HAS BEEN AUTOMATICALLY GENERATED USING THE CONSENSUS DEVELOPER TOOLS.
    ///     DO NOT EDIT THIS CODE AS ANY CUSTOM MODIFICATIONS WILL BE LOST UPON REGENERATION.
    /// </remarks>
    public partial class LocalTemplateModel : LocalModel<TemplateXrefRecord, String>, ITemplateModel
    {
        #region fields

        /// <summary>
        ///     The value of the "TXREF_BOM_ID" field.
        /// </summary>
        private LocalBillOfMaterialModel _billOfMaterial;

        #endregion

        #region properties

        /// <summary>
        ///     Gets the delegated function that is responsible for persisting a new instance of the data structure within the underlying persistence mechanism.
        /// </summary>
        protected override Action<TemplateXrefRecord> DataCreator
        {
            get { return this.Provider.DataProvider.Learning.Template.Create; }
        }

        /// <summary>
        ///     Gets the delegated function that is responsible for persisting an existing instance of the data structure within the underlying persistence mechanism.
        /// </summary>
        protected override Action<TemplateXrefRecord> DataModifier
        {
            get { return this.Provider.DataProvider.Learning.Template.Modify; }
        }

        /// <summary>
        ///     Gets the delegated function that is responsible for removing an existing instance of the data structure from the underlying persistence mechanism.
        /// </summary>
        protected override Action<TemplateXrefRecord> DataRemover
        {
            get { return this.Provider.DataProvider.Learning.Template.RemoveById; }
        }

        /// <summary>
        ///     Gets the The value of the "TXREF_BOM_ID" field.
        /// </summary>
        public LocalBillOfMaterialModel BillOfMaterial
        {
            get
            {
                if (_billOfMaterial == null && this.BillOfMaterialId != null)
                    _billOfMaterial = this.Provider.Learning.BillOfMaterial.FetchById(this.BillOfMaterialId);
                if (_billOfMaterial == null)
                    _billOfMaterial = this.Provider.Learning.BillOfMaterial.Create();
                
                return _billOfMaterial;
            }
        }

        /// <summary>
        ///     Gets or sets the unique code for the value of the "TXREF_BOM_ID" field.
        /// </summary>
        public String BillOfMaterialId
        {
            get { return this.ModifiedData.BomId; }
            set
            {
                if (this.ModifiedData.BomId != value)
                     _billOfMaterial = null;
                this.ModifiedData.BomId = value;
            }
        }

        /// <summary>
        ///     Gets or sets the value of the "TXREF_QTY" field.
        /// </summary>
        public Double? Qty
        {
            get { return this.ModifiedData.Qty; }
            set { this.ModifiedData.Qty = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "TXREF_DEL_QTY" field.
        /// </summary>
        public Double? DelQty
        {
            get { return this.ModifiedData.DelQty; }
            set { this.ModifiedData.DelQty = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "TXREF_PER_DAY" field.
        /// </summary>
        public Byte? PerDay
        {
            get { return this.ModifiedData.PerDay; }
            set { this.ModifiedData.PerDay = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "TXREF_UNT_TYPE" field.
        /// </summary>
        public String UntType
        {
            get { return this.ModifiedData.UntType; }
            set { this.ModifiedData.UntType = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "TXREF_COST" field.
        /// </summary>
        public Decimal Cost
        {
            get { return this.ModifiedData.Cost; }
            set { this.ModifiedData.Cost = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "TXREF_INC_IN_BUDGET" field.
        /// </summary>
        public Byte IncInBudget
        {
            get { return this.ModifiedData.IncInBudget; }
            set { this.ModifiedData.IncInBudget = value; }
        }

        #endregion

        #region constructors

        /// <summary>
        ///     Initialises a new <see cref="LocalTemplateModel" /> instance.
        /// </summary>
        /// <param name="provider">
        ///     The business provider to which the business model is bound.
        /// </param>
        internal LocalTemplateModel(LocalProvider provider) : base(provider)
        {
        }

        /// <summary>
        ///     Initialises a new <see cref="LocalTemplateModel" /> instance.
        /// </summary>
        /// <param name="provider">
        ///     The business provider to which the business model is bound.
        /// </param>
        /// <param name="record">
        ///     The data record which is encapsulated by the business model.
        /// </param>
        internal LocalTemplateModel(LocalProvider provider, TemplateXrefRecord record) : base(provider, record)
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
            if (_billOfMaterial != null)
            {
                _billOfMaterial.Save();
                this.ModifiedData.BomId = _billOfMaterial.Id == null && this.ModifiedData.BomId != null ? "" : _billOfMaterial.Id;
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
        ///     Gets the The value of the "TXREF_BOM_ID" field.
        /// </summary>
        Consensus.Learning.IBillOfMaterialModel ITemplateModel.BillOfMaterial
        {
            get { return this.BillOfMaterial; }
        }

        /// <summary>
        ///     Gets or sets the unique code for the value of the "TXREF_BOM_ID" field.
        /// </summary>
        System.String ITemplateModel.BillOfMaterialId
        {
            get { return this.BillOfMaterialId; }
            set { this.BillOfMaterialId = (System.String)value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "TXREF_QTY" field.
        /// </summary>
        System.Nullable<System.Double> ITemplateModel.Qty
        {
            get { return this.Qty; }
            set { this.Qty = (System.Nullable<System.Double>)value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "TXREF_DEL_QTY" field.
        /// </summary>
        System.Nullable<System.Double> ITemplateModel.DelQty
        {
            get { return this.DelQty; }
            set { this.DelQty = (System.Nullable<System.Double>)value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "TXREF_PER_DAY" field.
        /// </summary>
        System.Nullable<System.Byte> ITemplateModel.PerDay
        {
            get { return this.PerDay; }
            set { this.PerDay = (System.Nullable<System.Byte>)value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "TXREF_UNT_TYPE" field.
        /// </summary>
        System.String ITemplateModel.UntType
        {
            get { return this.UntType; }
            set { this.UntType = (System.String)value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "TXREF_COST" field.
        /// </summary>
        System.Decimal ITemplateModel.Cost
        {
            get { return this.Cost; }
            set { this.Cost = (System.Decimal)value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "TXREF_INC_IN_BUDGET" field.
        /// </summary>
        System.Byte ITemplateModel.IncInBudget
        {
            get { return this.IncInBudget; }
            set { this.IncInBudget = (System.Byte)value; }
        }

        #endregion
    }
}
