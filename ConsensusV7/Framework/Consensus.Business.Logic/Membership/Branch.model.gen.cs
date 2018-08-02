using System;
using System.Collections.Generic;
using System.Linq;
using Consensus.Common;

namespace Consensus.Membership
{
    /// <summary>
    ///     Encapsulates the <see cref="BranchRecord" /> with standardised business rules.
    /// </summary>
    /// <remarks>
    ///     THIS CODE HAS BEEN AUTOMATICALLY GENERATED USING THE CONSENSUS DEVELOPER TOOLS.
    ///     DO NOT EDIT THIS CODE AS ANY CUSTOM MODIFICATIONS WILL BE LOST UPON REGENERATION.
    /// </remarks>
    public partial class LocalBranchModel : LocalModel<BranchRecord, String>, IBranchModel
    {
        #region fields

        /// <summary>
        ///     The value of the "BR_STATUS" field.
        /// </summary>
        private LocalCodeModel _status;

        /// <summary>
        ///     The value of the "BR_TYPE" field.
        /// </summary>
        private LocalCodeModel _type;

        /// <summary>
        ///     The value of the "BR_CATEGORY" field.
        /// </summary>
        private LocalCodeModel _category;

        /// <summary>
        ///     The value of the "BR_GROUP" field.
        /// </summary>
        private LocalCodeModel _group;

        /// <summary>
        ///     The value of the "BR_REGION" field.
        /// </summary>
        private LocalCodeModel _region;

        /// <summary>
        ///     The collection of <see cref="BranchXrefModel" /> instances that reference this <see cref="BranchModel" />.
        /// </summary>
        private LocalCollection<LocalBranchXrefModel, IBranchXrefModel> _branchXrefs;

        /// <summary>
        ///     The collection of <see cref="CommitteeModel" /> instances that reference this <see cref="BranchModel" />.
        /// </summary>
        private LocalCollection<LocalCommitteeModel, ICommitteeModel> _commiteeBranch;

        #endregion

        #region properties

        /// <summary>
        ///     Gets the delegated function that is responsible for persisting a new instance of the data structure within the underlying persistence mechanism.
        /// </summary>
        protected override Action<BranchRecord> DataCreator
        {
            get { return this.Provider.DataProvider.Membership.Branch.Create; }
        }

        /// <summary>
        ///     Gets the delegated function that is responsible for persisting an existing instance of the data structure within the underlying persistence mechanism.
        /// </summary>
        protected override Action<BranchRecord> DataModifier
        {
            get { return this.Provider.DataProvider.Membership.Branch.Modify; }
        }

        /// <summary>
        ///     Gets the delegated function that is responsible for removing an existing instance of the data structure from the underlying persistence mechanism.
        /// </summary>
        protected override Action<BranchRecord> DataRemover
        {
            get { return this.Provider.DataProvider.Membership.Branch.RemoveById; }
        }

        /// <summary>
        ///     Gets or sets the value of the "BR_ADD_DATE" field.
        /// </summary>
        public DateTime? AddDate
        {
            get { return this.ModifiedData.AddDate; }
            set { this.ModifiedData.AddDate = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "BR_NAME" field.
        /// </summary>
        public String Name
        {
            get { return this.ModifiedData.Name; }
            set { this.ModifiedData.Name = value; }
        }

        /// <summary>
        ///     Gets the The value of the "BR_STATUS" field.
        /// </summary>
        public LocalCodeModel Status
        {
            get
            {
                if (_status == null && !String.IsNullOrEmpty(this.StatusCode))
                    _status = this.Provider.Common.Code.FetchByTypeAndCode("BRSTA", this.StatusCode);
                if (_status == null)
                    _status = this.Provider.Common.Code.Create("BRSTA");
                return _status;
            }
        }

        /// <summary>
        ///     Gets or sets the unique code for the value of the "BR_STATUS" field.
        /// </summary>
        public String StatusCode
        {
            get { return this.ModifiedData.Status; }
            set
            {
                if (this.ModifiedData.Status != value)
                     _status = null;
                this.ModifiedData.Status = value;
            }
        }

        /// <summary>
        ///     Gets the The value of the "BR_TYPE" field.
        /// </summary>
        public LocalCodeModel Type
        {
            get
            {
                if (_type == null && !String.IsNullOrEmpty(this.TypeCode))
                    _type = this.Provider.Common.Code.FetchByTypeAndCode("BRTYP", this.TypeCode);
                if (_type == null)
                    _type = this.Provider.Common.Code.Create("BRTYP");
                return _type;
            }
        }

        /// <summary>
        ///     Gets or sets the unique code for the value of the "BR_TYPE" field.
        /// </summary>
        public String TypeCode
        {
            get { return this.ModifiedData.Type; }
            set
            {
                if (this.ModifiedData.Type != value)
                     _type = null;
                this.ModifiedData.Type = value;
            }
        }

        /// <summary>
        ///     Gets the The value of the "BR_CATEGORY" field.
        /// </summary>
        public LocalCodeModel Category
        {
            get
            {
                if (_category == null && !String.IsNullOrEmpty(this.CategoryCode))
                    _category = this.Provider.Common.Code.FetchByTypeAndCode("BRCAT", this.CategoryCode);
                if (_category == null)
                    _category = this.Provider.Common.Code.Create("BRCAT");
                return _category;
            }
        }

        /// <summary>
        ///     Gets or sets the unique code for the value of the "BR_CATEGORY" field.
        /// </summary>
        public String CategoryCode
        {
            get { return this.ModifiedData.Category; }
            set
            {
                if (this.ModifiedData.Category != value)
                     _category = null;
                this.ModifiedData.Category = value;
            }
        }

        /// <summary>
        ///     Gets the The value of the "BR_GROUP" field.
        /// </summary>
        public LocalCodeModel Group
        {
            get
            {
                if (_group == null && !String.IsNullOrEmpty(this.GroupCode))
                    _group = this.Provider.Common.Code.FetchByTypeAndCode("BRGRP", this.GroupCode);
                if (_group == null)
                    _group = this.Provider.Common.Code.Create("BRGRP");
                return _group;
            }
        }

        /// <summary>
        ///     Gets or sets the unique code for the value of the "BR_GROUP" field.
        /// </summary>
        public String GroupCode
        {
            get { return this.ModifiedData.Group; }
            set
            {
                if (this.ModifiedData.Group != value)
                     _group = null;
                this.ModifiedData.Group = value;
            }
        }

        /// <summary>
        ///     Gets the The value of the "BR_REGION" field.
        /// </summary>
        public LocalCodeModel Region
        {
            get
            {
                if (_region == null && !String.IsNullOrEmpty(this.RegionCode))
                    _region = this.Provider.Common.Code.FetchByTypeAndCode("REGI", this.RegionCode);
                if (_region == null)
                    _region = this.Provider.Common.Code.Create("REGI");
                return _region;
            }
        }

        /// <summary>
        ///     Gets or sets the unique code for the value of the "BR_REGION" field.
        /// </summary>
        public String RegionCode
        {
            get { return this.ModifiedData.Region; }
            set
            {
                if (this.ModifiedData.Region != value)
                     _region = null;
                this.ModifiedData.Region = value;
            }
        }

        /// <summary>
        ///     Gets or sets the value of the "BR_WEB" field.
        /// </summary>
        public Byte Web
        {
            get { return this.ModifiedData.Web; }
            set { this.ModifiedData.Web = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "BR_EXT_URL" field.
        /// </summary>
        public String ExtUrl
        {
            get { return this.ModifiedData.ExtUrl; }
            set { this.ModifiedData.ExtUrl = value; }
        }

        /// <summary>
        ///     Gets the collection of <see cref="BranchXrefModel" /> instances that reference this <see cref="BranchModel" />.
        /// </summary>
        public LocalCollection<LocalBranchXrefModel, IBranchXrefModel> BranchXrefs
        {
            get
            {
                if (_branchXrefs == null)
                    _branchXrefs = new LocalCollection<LocalBranchXrefModel, IBranchXrefModel>(this.Provider.Membership.BranchXref.FetchAllByBranchId(this.Id));
                
                return _branchXrefs;
            }
        }

        /// <summary>
        ///     Gets the collection of <see cref="CommitteeModel" /> instances that reference this <see cref="BranchModel" />.
        /// </summary>
        public LocalCollection<LocalCommitteeModel, ICommitteeModel> CommiteeBranch
        {
            get
            {
                if (_commiteeBranch == null)
                    _commiteeBranch = new LocalCollection<LocalCommitteeModel, ICommitteeModel>(this.Provider.Membership.Committee.FetchAllByBrIdId(this.Id));
                
                return _commiteeBranch;
            }
        }

        #endregion

        #region constructors

        /// <summary>
        ///     Initialises a new <see cref="LocalBranchModel" /> instance.
        /// </summary>
        /// <param name="provider">
        ///     The business provider to which the business model is bound.
        /// </param>
        internal LocalBranchModel(LocalProvider provider) : base(provider)
        {
        }

        /// <summary>
        ///     Initialises a new <see cref="LocalBranchModel" /> instance.
        /// </summary>
        /// <param name="provider">
        ///     The business provider to which the business model is bound.
        /// </param>
        /// <param name="record">
        ///     The data record which is encapsulated by the business model.
        /// </param>
        internal LocalBranchModel(LocalProvider provider, BranchRecord record) : base(provider, record)
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
            if (_status != null)
            {
                _status.Save();
                this.ModifiedData.Status = _status.Value1;
            }
            if (_type != null)
            {
                _type.Save();
                this.ModifiedData.Type = _type.Value1;
            }
            if (_category != null)
            {
                _category.Save();
                this.ModifiedData.Category = _category.Value1;
            }
            if (_group != null)
            {
                _group.Save();
                this.ModifiedData.Group = _group.Value1;
            }
            if (_region != null)
            {
                _region.Save();
                this.ModifiedData.Region = _region.Value1;
            }
        }

        /// <summary>
        ///     Resolves the dependent models by means of updating all models that reference this model.
        /// </summary>
        protected override void ResolveGeneratedDependent()
        {
            base.ResolveGeneratedDependent();
            if (_branchXrefs != null)
                _branchXrefs.Execute(obj => obj.BranchId = this.Id).Execute(obj => obj.Save());
            if (_commiteeBranch != null)
                _commiteeBranch.Execute(obj => obj.BrIdId = this.Id).Execute(obj => obj.Save());
        }

        #endregion

        #region implementations

        /// <summary>
        ///     Gets or sets the value of the "BR_ADD_DATE" field.
        /// </summary>
        System.Nullable<System.DateTime> IBranchModel.AddDate
        {
            get { return this.AddDate; }
            set { this.AddDate = (System.Nullable<System.DateTime>)value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "BR_NAME" field.
        /// </summary>
        System.String IBranchModel.Name
        {
            get { return this.Name; }
            set { this.Name = (System.String)value; }
        }

        /// <summary>
        ///     Gets the The value of the "BR_STATUS" field.
        /// </summary>
        Consensus.Common.ICodeModel IBranchModel.Status
        {
            get { return this.Status; }
        }

        /// <summary>
        ///     Gets or sets the unique code for the value of the "BR_STATUS" field.
        /// </summary>
        System.String IBranchModel.StatusCode
        {
            get { return this.StatusCode; }
            set { this.StatusCode = (System.String)value; }
        }

        /// <summary>
        ///     Gets the The value of the "BR_TYPE" field.
        /// </summary>
        Consensus.Common.ICodeModel IBranchModel.Type
        {
            get { return this.Type; }
        }

        /// <summary>
        ///     Gets or sets the unique code for the value of the "BR_TYPE" field.
        /// </summary>
        System.String IBranchModel.TypeCode
        {
            get { return this.TypeCode; }
            set { this.TypeCode = (System.String)value; }
        }

        /// <summary>
        ///     Gets the The value of the "BR_CATEGORY" field.
        /// </summary>
        Consensus.Common.ICodeModel IBranchModel.Category
        {
            get { return this.Category; }
        }

        /// <summary>
        ///     Gets or sets the unique code for the value of the "BR_CATEGORY" field.
        /// </summary>
        System.String IBranchModel.CategoryCode
        {
            get { return this.CategoryCode; }
            set { this.CategoryCode = (System.String)value; }
        }

        /// <summary>
        ///     Gets the The value of the "BR_GROUP" field.
        /// </summary>
        Consensus.Common.ICodeModel IBranchModel.Group
        {
            get { return this.Group; }
        }

        /// <summary>
        ///     Gets or sets the unique code for the value of the "BR_GROUP" field.
        /// </summary>
        System.String IBranchModel.GroupCode
        {
            get { return this.GroupCode; }
            set { this.GroupCode = (System.String)value; }
        }

        /// <summary>
        ///     Gets the The value of the "BR_REGION" field.
        /// </summary>
        Consensus.Common.ICodeModel IBranchModel.Region
        {
            get { return this.Region; }
        }

        /// <summary>
        ///     Gets or sets the unique code for the value of the "BR_REGION" field.
        /// </summary>
        System.String IBranchModel.RegionCode
        {
            get { return this.RegionCode; }
            set { this.RegionCode = (System.String)value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "BR_WEB" field.
        /// </summary>
        System.Byte IBranchModel.Web
        {
            get { return this.Web; }
            set { this.Web = (System.Byte)value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "BR_EXT_URL" field.
        /// </summary>
        System.String IBranchModel.ExtUrl
        {
            get { return this.ExtUrl; }
            set { this.ExtUrl = (System.String)value; }
        }

        /// <summary>
        ///     Gets the collection of <see cref="!:BranchXrefModel" /> instances that reference this <see cref="!:BranchModel" />.
        /// </summary>
        Consensus.Collection<Consensus.Membership.IBranchXrefModel> IBranchModel.BranchXrefs
        {
            get { return this.BranchXrefs; }
        }

        /// <summary>
        ///     Gets the collection of <see cref="!:CommitteeModel" /> instances that reference this <see cref="!:BranchModel" />.
        /// </summary>
        Consensus.Collection<Consensus.Membership.ICommitteeModel> IBranchModel.CommiteeBranch
        {
            get { return this.CommiteeBranch; }
        }

        #endregion
    }
}
