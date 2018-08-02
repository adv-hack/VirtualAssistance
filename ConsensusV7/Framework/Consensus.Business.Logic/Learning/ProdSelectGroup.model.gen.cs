using System;
using System.Collections.Generic;
using System.Linq;

namespace Consensus.Learning
{
    /// <summary>
    ///     Encapsulates the <see cref="ProdselectgroupsRecord" /> with standardised business rules.
    /// </summary>
    /// <remarks>
    ///     THIS CODE HAS BEEN AUTOMATICALLY GENERATED USING THE CONSENSUS DEVELOPER TOOLS.
    ///     DO NOT EDIT THIS CODE AS ANY CUSTOM MODIFICATIONS WILL BE LOST UPON REGENERATION.
    /// </remarks>
    public partial class LocalProdSelectGroupModel : LocalModel<ProdselectgroupsRecord, Int32>, IProdSelectGroupModel
    {
        #region fields

        /// <summary>
        ///     The value of the "PSG_PROD_ID" field.
        /// </summary>
        private LocalProductModel _prodId;

        /// <summary>
        ///     The collection of <see cref="BillOfMaterialModel" /> instances that reference this <see cref="ProdSelectGroupModel" />.
        /// </summary>
        private LocalCollection<LocalBillOfMaterialModel, IBillOfMaterialModel> _bOMSelectGroup;

        /// <summary>
        ///     The collection of <see cref="CourseSelectGroupsModel" /> instances that reference this <see cref="ProdSelectGroupModel" />.
        /// </summary>
        private LocalCollection<LocalCourseSelectGroupsModel, ICourseSelectGroupsModel> _courseSelectionGroups;

        #endregion

        #region properties

        /// <summary>
        ///     Gets the delegated function that is responsible for persisting a new instance of the data structure within the underlying persistence mechanism.
        /// </summary>
        protected override Action<ProdselectgroupsRecord> DataCreator
        {
            get { return this.Provider.DataProvider.Learning.ProdSelectGroup.Create; }
        }

        /// <summary>
        ///     Gets the delegated function that is responsible for persisting an existing instance of the data structure within the underlying persistence mechanism.
        /// </summary>
        protected override Action<ProdselectgroupsRecord> DataModifier
        {
            get { return this.Provider.DataProvider.Learning.ProdSelectGroup.Modify; }
        }

        /// <summary>
        ///     Gets the delegated function that is responsible for removing an existing instance of the data structure from the underlying persistence mechanism.
        /// </summary>
        protected override Action<ProdselectgroupsRecord> DataRemover
        {
            get { return this.Provider.DataProvider.Learning.ProdSelectGroup.RemoveById; }
        }

        /// <summary>
        ///     Gets the The value of the "PSG_PROD_ID" field.
        /// </summary>
        public LocalProductModel ProdId
        {
            get
            {
                if (_prodId == null)
                    _prodId = this.Provider.Learning.Product.FetchById(this.ProdIdId);
                if (_prodId == null)
                    _prodId = this.Provider.Learning.Product.Create();
                
                return _prodId;
            }
        }

        /// <summary>
        ///     Gets or sets the unique code for the value of the "PSG_PROD_ID" field.
        /// </summary>
        public String ProdIdId
        {
            get { return this.ModifiedData.Product; }
            set
            {
                if (this.ModifiedData.Product != value)
                     _prodId = null;
                this.ModifiedData.Product = value;
            }
        }

        /// <summary>
        ///     Gets or sets the value of the "PSG_TYPE" field.
        /// </summary>
        public Byte Type
        {
            get { return this.ModifiedData.Type; }
            set { this.ModifiedData.Type = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "PSG_NAME" field.
        /// </summary>
        public String Name
        {
            get { return this.ModifiedData.Name; }
            set { this.ModifiedData.Name = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "PSG_DESCRIPTION" field.
        /// </summary>
        public String Description
        {
            get { return this.ModifiedData.Description; }
            set { this.ModifiedData.Description = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "PSG_MIN" field.
        /// </summary>
        public Byte Min
        {
            get { return this.ModifiedData.Min; }
            set { this.ModifiedData.Min = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "PSG_MAX" field.
        /// </summary>
        public Byte Max
        {
            get { return this.ModifiedData.Max; }
            set { this.ModifiedData.Max = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "PSG_ORDER" field.
        /// </summary>
        public Byte Order
        {
            get { return this.ModifiedData.Order; }
            set { this.ModifiedData.Order = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "PSG_ERROR_MESSAGE" field.
        /// </summary>
        public String ErrorMessage
        {
            get { return this.ModifiedData.ErrorMessage; }
            set { this.ModifiedData.ErrorMessage = value; }
        }

        /// <summary>
        ///     Gets the collection of <see cref="BillOfMaterialModel" /> instances that reference this <see cref="ProdSelectGroupModel" />.
        /// </summary>
        public LocalCollection<LocalBillOfMaterialModel, IBillOfMaterialModel> BOMSelectGroup
        {
            get
            {
                if (_bOMSelectGroup == null)
                    _bOMSelectGroup = new LocalCollection<LocalBillOfMaterialModel, IBillOfMaterialModel>(this.Provider.Learning.BillOfMaterial.FetchAllByPsgIdId(this.Id));
                
                return _bOMSelectGroup;
            }
        }

        /// <summary>
        ///     Gets the collection of <see cref="CourseSelectGroupsModel" /> instances that reference this <see cref="ProdSelectGroupModel" />.
        /// </summary>
        public LocalCollection<LocalCourseSelectGroupsModel, ICourseSelectGroupsModel> CourseSelectionGroups
        {
            get
            {
                if (_courseSelectionGroups == null)
                    _courseSelectionGroups = new LocalCollection<LocalCourseSelectGroupsModel, ICourseSelectGroupsModel>(this.Provider.Learning.CourseSelectGroups.FetchAllByProdSelectionGroupId(this.Id));
                
                return _courseSelectionGroups;
            }
        }

        #endregion

        #region constructors

        /// <summary>
        ///     Initialises a new <see cref="LocalProdSelectGroupModel" /> instance.
        /// </summary>
        /// <param name="provider">
        ///     The business provider to which the business model is bound.
        /// </param>
        internal LocalProdSelectGroupModel(LocalProvider provider) : base(provider)
        {
        }

        /// <summary>
        ///     Initialises a new <see cref="LocalProdSelectGroupModel" /> instance.
        /// </summary>
        /// <param name="provider">
        ///     The business provider to which the business model is bound.
        /// </param>
        /// <param name="record">
        ///     The data record which is encapsulated by the business model.
        /// </param>
        internal LocalProdSelectGroupModel(LocalProvider provider, ProdselectgroupsRecord record) : base(provider, record)
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
            if (_prodId != null)
            {
                _prodId.Save();
                this.ModifiedData.Product = _prodId.Id == null && this.ModifiedData.Product != null ? "" : _prodId.Id;
            }
        }

        /// <summary>
        ///     Resolves the dependent models by means of updating all models that reference this model.
        /// </summary>
        protected override void ResolveGeneratedDependent()
        {
            base.ResolveGeneratedDependent();
            if (_bOMSelectGroup != null)
                _bOMSelectGroup.Execute(obj => obj.PsgIdId = this.Id).Execute(obj => obj.Save());
            if (_courseSelectionGroups != null)
                _courseSelectionGroups.Execute(obj => obj.ProdSelectionGroupId = this.Id).Execute(obj => obj.Save());
        }

        #endregion

        #region implementations

        /// <summary>
        ///     Gets the The value of the "PSG_PROD_ID" field.
        /// </summary>
        Consensus.Learning.IProductModel IProdSelectGroupModel.ProdId
        {
            get { return this.ProdId; }
        }

        /// <summary>
        ///     Gets or sets the unique code for the value of the "PSG_PROD_ID" field.
        /// </summary>
        System.String IProdSelectGroupModel.ProdIdId
        {
            get { return this.ProdIdId; }
            set { this.ProdIdId = (System.String)value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "PSG_TYPE" field.
        /// </summary>
        System.Byte IProdSelectGroupModel.Type
        {
            get { return this.Type; }
            set { this.Type = (System.Byte)value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "PSG_NAME" field.
        /// </summary>
        System.String IProdSelectGroupModel.Name
        {
            get { return this.Name; }
            set { this.Name = (System.String)value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "PSG_DESCRIPTION" field.
        /// </summary>
        System.String IProdSelectGroupModel.Description
        {
            get { return this.Description; }
            set { this.Description = (System.String)value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "PSG_MIN" field.
        /// </summary>
        System.Byte IProdSelectGroupModel.Min
        {
            get { return this.Min; }
            set { this.Min = (System.Byte)value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "PSG_MAX" field.
        /// </summary>
        System.Byte IProdSelectGroupModel.Max
        {
            get { return this.Max; }
            set { this.Max = (System.Byte)value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "PSG_ORDER" field.
        /// </summary>
        System.Byte IProdSelectGroupModel.Order
        {
            get { return this.Order; }
            set { this.Order = (System.Byte)value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "PSG_ERROR_MESSAGE" field.
        /// </summary>
        System.String IProdSelectGroupModel.ErrorMessage
        {
            get { return this.ErrorMessage; }
            set { this.ErrorMessage = (System.String)value; }
        }

        /// <summary>
        ///     Gets the collection of <see cref="!:BillOfMaterialModel" /> instances that reference this <see cref="!:ProdSelectGroupModel" />.
        /// </summary>
        Consensus.Collection<Consensus.Learning.IBillOfMaterialModel> IProdSelectGroupModel.BOMSelectGroup
        {
            get { return this.BOMSelectGroup; }
        }

        /// <summary>
        ///     Gets the collection of <see cref="!:CourseSelectGroupsModel" /> instances that reference this <see cref="!:ProdSelectGroupModel" />.
        /// </summary>
        Consensus.Collection<Consensus.Learning.ICourseSelectGroupsModel> IProdSelectGroupModel.CourseSelectionGroups
        {
            get { return this.CourseSelectionGroups; }
        }

        #endregion
    }
}
