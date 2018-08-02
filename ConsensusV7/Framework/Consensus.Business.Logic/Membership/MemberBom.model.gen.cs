using System;
using System.Collections.Generic;
using System.Linq;
using Consensus.Learning;

namespace Consensus.Membership
{
    /// <summary>
    ///     Encapsulates the <see cref="MemberBomRecord" /> with standardised business rules.
    /// </summary>
    /// <remarks>
    ///     THIS CODE HAS BEEN AUTOMATICALLY GENERATED USING THE CONSENSUS DEVELOPER TOOLS.
    ///     DO NOT EDIT THIS CODE AS ANY CUSTOM MODIFICATIONS WILL BE LOST UPON REGENERATION.
    /// </remarks>
    public partial class LocalMemberBomModel : LocalModel<MemberBomRecord, String>, IMemberBomModel
    {
        #region fields

        /// <summary>
        ///     The value of the "MBOM_PARENT_ID" field.
        /// </summary>
        private LocalProductModel _prodParentId;

        /// <summary>
        ///     The value of the "MBOM_GRADE_ID" field.
        /// </summary>
        private LocalProductModel _gradeProd;

        #endregion

        #region properties

        /// <summary>
        ///     Gets the delegated function that is responsible for persisting a new instance of the data structure within the underlying persistence mechanism.
        /// </summary>
        protected override Action<MemberBomRecord> DataCreator
        {
            get { return this.Provider.DataProvider.Membership.MemberBom.Create; }
        }

        /// <summary>
        ///     Gets the delegated function that is responsible for persisting an existing instance of the data structure within the underlying persistence mechanism.
        /// </summary>
        protected override Action<MemberBomRecord> DataModifier
        {
            get { return this.Provider.DataProvider.Membership.MemberBom.Modify; }
        }

        /// <summary>
        ///     Gets the delegated function that is responsible for removing an existing instance of the data structure from the underlying persistence mechanism.
        /// </summary>
        protected override Action<MemberBomRecord> DataRemover
        {
            get { return this.Provider.DataProvider.Membership.MemberBom.RemoveById; }
        }

        /// <summary>
        ///     Gets the The value of the "MBOM_PARENT_ID" field.
        /// </summary>
        public LocalProductModel ProdParentId
        {
            get
            {
                if (_prodParentId == null && this.ProdParentIdId != null)
                    _prodParentId = this.Provider.Learning.Product.FetchById(this.ProdParentIdId);
                if (_prodParentId == null)
                    _prodParentId = this.Provider.Learning.Product.Create();
                
                return _prodParentId;
            }
        }

        /// <summary>
        ///     Gets or sets the unique code for the value of the "MBOM_PARENT_ID" field.
        /// </summary>
        public String ProdParentIdId
        {
            get { return this.ModifiedData.ParentId; }
            set
            {
                if (this.ModifiedData.ParentId != value)
                     _prodParentId = null;
                this.ModifiedData.ParentId = value;
            }
        }

        /// <summary>
        ///     Gets or sets the value of the "MBOM_PROD_ID" field.
        /// </summary>
        public String ProdId
        {
            get { return this.ModifiedData.ProdId; }
            set { this.ModifiedData.ProdId = value; }
        }

        /// <summary>
        ///     Gets the The value of the "MBOM_GRADE_ID" field.
        /// </summary>
        public LocalProductModel GradeProd
        {
            get
            {
                if (_gradeProd == null && this.GradeProdId != null)
                    _gradeProd = this.Provider.Learning.Product.FetchById(this.GradeProdId);
                if (_gradeProd == null)
                    _gradeProd = this.Provider.Learning.Product.Create();
                
                return _gradeProd;
            }
        }

        /// <summary>
        ///     Gets or sets the unique code for the value of the "MBOM_GRADE_ID" field.
        /// </summary>
        public String GradeProdId
        {
            get { return this.ModifiedData.GradeId; }
            set
            {
                if (this.ModifiedData.GradeId != value)
                     _gradeProd = null;
                this.ModifiedData.GradeId = value;
            }
        }

        /// <summary>
        ///     Gets or sets the value of the "MBOM_MAIN" field.
        /// </summary>
        public Byte? Main
        {
            get { return this.ModifiedData.Main; }
            set { this.ModifiedData.Main = value; }
        }

        #endregion

        #region constructors

        /// <summary>
        ///     Initialises a new <see cref="LocalMemberBomModel" /> instance.
        /// </summary>
        /// <param name="provider">
        ///     The business provider to which the business model is bound.
        /// </param>
        internal LocalMemberBomModel(LocalProvider provider) : base(provider)
        {
        }

        /// <summary>
        ///     Initialises a new <see cref="LocalMemberBomModel" /> instance.
        /// </summary>
        /// <param name="provider">
        ///     The business provider to which the business model is bound.
        /// </param>
        /// <param name="record">
        ///     The data record which is encapsulated by the business model.
        /// </param>
        internal LocalMemberBomModel(LocalProvider provider, MemberBomRecord record) : base(provider, record)
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
            if (_prodParentId != null)
            {
                _prodParentId.Save();
                this.ModifiedData.ParentId = _prodParentId.Id == null && this.ModifiedData.ParentId != null ? "" : _prodParentId.Id;
            }
            if (_gradeProd != null)
            {
                _gradeProd.Save();
                this.ModifiedData.GradeId = _gradeProd.Id == null && this.ModifiedData.GradeId != null ? "" : _gradeProd.Id;
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
        ///     Gets the The value of the "MBOM_PARENT_ID" field.
        /// </summary>
        Consensus.Learning.IProductModel IMemberBomModel.ProdParentId
        {
            get { return this.ProdParentId; }
        }

        /// <summary>
        ///     Gets or sets the unique code for the value of the "MBOM_PARENT_ID" field.
        /// </summary>
        System.String IMemberBomModel.ProdParentIdId
        {
            get { return this.ProdParentIdId; }
            set { this.ProdParentIdId = (System.String)value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "MBOM_PROD_ID" field.
        /// </summary>
        System.String IMemberBomModel.ProdId
        {
            get { return this.ProdId; }
            set { this.ProdId = (System.String)value; }
        }

        /// <summary>
        ///     Gets the The value of the "MBOM_GRADE_ID" field.
        /// </summary>
        Consensus.Learning.IProductModel IMemberBomModel.GradeProd
        {
            get { return this.GradeProd; }
        }

        /// <summary>
        ///     Gets or sets the unique code for the value of the "MBOM_GRADE_ID" field.
        /// </summary>
        System.String IMemberBomModel.GradeProdId
        {
            get { return this.GradeProdId; }
            set { this.GradeProdId = (System.String)value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "MBOM_MAIN" field.
        /// </summary>
        System.Nullable<System.Byte> IMemberBomModel.Main
        {
            get { return this.Main; }
            set { this.Main = (System.Nullable<System.Byte>)value; }
        }

        #endregion
    }
}
