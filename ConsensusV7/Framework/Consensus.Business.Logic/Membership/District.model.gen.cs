using System;
using System.Collections.Generic;
using System.Linq;
using Consensus.Common;

namespace Consensus.Membership
{
    /// <summary>
    ///     Encapsulates the <see cref="DistrictRecord" /> with standardised business rules.
    /// </summary>
    /// <remarks>
    ///     THIS CODE HAS BEEN AUTOMATICALLY GENERATED USING THE CONSENSUS DEVELOPER TOOLS.
    ///     DO NOT EDIT THIS CODE AS ANY CUSTOM MODIFICATIONS WILL BE LOST UPON REGENERATION.
    /// </remarks>
    public partial class LocalDistrictModel : LocalModel<DistrictRecord, String>, IDistrictModel
    {
        #region fields

        /// <summary>
        ///     The value of the "DIS_STATUS" field.
        /// </summary>
        private LocalCodeModel _status;

        /// <summary>
        ///     The value of the "DIS_TYPE" field.
        /// </summary>
        private LocalCodeModel _type;

        /// <summary>
        ///     The value of the "DIS_CATEGORY" field.
        /// </summary>
        private LocalCodeModel _category;

        /// <summary>
        ///     The value of the "DIS_GROUP" field.
        /// </summary>
        private LocalCodeModel _group;

        /// <summary>
        ///     The value of the "DIS_REGION" field.
        /// </summary>
        private LocalCodeModel _region;

        /// <summary>
        ///     The collection of <see cref="CommitteeModel" /> instances that reference this <see cref="DistrictModel" />.
        /// </summary>
        private LocalCollection<LocalCommitteeModel, ICommitteeModel> _commiteeDistrict;

        #endregion

        #region properties

        /// <summary>
        ///     Gets the delegated function that is responsible for persisting a new instance of the data structure within the underlying persistence mechanism.
        /// </summary>
        protected override Action<DistrictRecord> DataCreator
        {
            get { return this.Provider.DataProvider.Membership.District.Create; }
        }

        /// <summary>
        ///     Gets the delegated function that is responsible for persisting an existing instance of the data structure within the underlying persistence mechanism.
        /// </summary>
        protected override Action<DistrictRecord> DataModifier
        {
            get { return this.Provider.DataProvider.Membership.District.Modify; }
        }

        /// <summary>
        ///     Gets the delegated function that is responsible for removing an existing instance of the data structure from the underlying persistence mechanism.
        /// </summary>
        protected override Action<DistrictRecord> DataRemover
        {
            get { return this.Provider.DataProvider.Membership.District.RemoveById; }
        }

        /// <summary>
        ///     Gets or sets the value of the "DIS_NAME" field.
        /// </summary>
        public String Name
        {
            get { return this.ModifiedData.Name; }
            set { this.ModifiedData.Name = value; }
        }

        /// <summary>
        ///     Gets the The value of the "DIS_STATUS" field.
        /// </summary>
        public LocalCodeModel Status
        {
            get
            {
                if (_status == null && !String.IsNullOrEmpty(this.StatusCode))
                    _status = this.Provider.Common.Code.FetchByTypeAndCode("DISTA", this.StatusCode);
                if (_status == null)
                    _status = this.Provider.Common.Code.Create("DISTA");
                return _status;
            }
        }

        /// <summary>
        ///     Gets or sets the unique code for the value of the "DIS_STATUS" field.
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
        ///     Gets the The value of the "DIS_TYPE" field.
        /// </summary>
        public LocalCodeModel Type
        {
            get
            {
                if (_type == null && !String.IsNullOrEmpty(this.TypeCode))
                    _type = this.Provider.Common.Code.FetchByTypeAndCode("DITYP", this.TypeCode);
                if (_type == null)
                    _type = this.Provider.Common.Code.Create("DITYP");
                return _type;
            }
        }

        /// <summary>
        ///     Gets or sets the unique code for the value of the "DIS_TYPE" field.
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
        ///     Gets the The value of the "DIS_CATEGORY" field.
        /// </summary>
        public LocalCodeModel Category
        {
            get
            {
                if (_category == null && !String.IsNullOrEmpty(this.CategoryCode))
                    _category = this.Provider.Common.Code.FetchByTypeAndCode("DICAT", this.CategoryCode);
                if (_category == null)
                    _category = this.Provider.Common.Code.Create("DICAT");
                return _category;
            }
        }

        /// <summary>
        ///     Gets or sets the unique code for the value of the "DIS_CATEGORY" field.
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
        ///     Gets the The value of the "DIS_GROUP" field.
        /// </summary>
        public LocalCodeModel Group
        {
            get
            {
                if (_group == null && !String.IsNullOrEmpty(this.GroupCode))
                    _group = this.Provider.Common.Code.FetchByTypeAndCode("DIGRP", this.GroupCode);
                if (_group == null)
                    _group = this.Provider.Common.Code.Create("DIGRP");
                return _group;
            }
        }

        /// <summary>
        ///     Gets or sets the unique code for the value of the "DIS_GROUP" field.
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
        ///     Gets the The value of the "DIS_REGION" field.
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
        ///     Gets or sets the unique code for the value of the "DIS_REGION" field.
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
        ///     Gets or sets the value of the "DIS_WEB" field.
        /// </summary>
        public Byte Web
        {
            get { return this.ModifiedData.Web; }
            set { this.ModifiedData.Web = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "DIS_EXT_URL" field.
        /// </summary>
        public String ExtUrl
        {
            get { return this.ModifiedData.ExtUrl; }
            set { this.ModifiedData.ExtUrl = value; }
        }

        /// <summary>
        ///     Gets the collection of <see cref="CommitteeModel" /> instances that reference this <see cref="DistrictModel" />.
        /// </summary>
        public LocalCollection<LocalCommitteeModel, ICommitteeModel> CommiteeDistrict
        {
            get
            {
                if (_commiteeDistrict == null)
                    _commiteeDistrict = new LocalCollection<LocalCommitteeModel, ICommitteeModel>(this.Provider.Membership.Committee.FetchAllByDisIdId(this.Id));
                
                return _commiteeDistrict;
            }
        }

        #endregion

        #region constructors

        /// <summary>
        ///     Initialises a new <see cref="LocalDistrictModel" /> instance.
        /// </summary>
        /// <param name="provider">
        ///     The business provider to which the business model is bound.
        /// </param>
        internal LocalDistrictModel(LocalProvider provider) : base(provider)
        {
        }

        /// <summary>
        ///     Initialises a new <see cref="LocalDistrictModel" /> instance.
        /// </summary>
        /// <param name="provider">
        ///     The business provider to which the business model is bound.
        /// </param>
        /// <param name="record">
        ///     The data record which is encapsulated by the business model.
        /// </param>
        internal LocalDistrictModel(LocalProvider provider, DistrictRecord record) : base(provider, record)
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
            if (_commiteeDistrict != null)
                _commiteeDistrict.Execute(obj => obj.DisIdId = this.Id).Execute(obj => obj.Save());
        }

        #endregion

        #region implementations

        /// <summary>
        ///     Gets or sets the value of the "DIS_NAME" field.
        /// </summary>
        System.String IDistrictModel.Name
        {
            get { return this.Name; }
            set { this.Name = (System.String)value; }
        }

        /// <summary>
        ///     Gets the The value of the "DIS_STATUS" field.
        /// </summary>
        Consensus.Common.ICodeModel IDistrictModel.Status
        {
            get { return this.Status; }
        }

        /// <summary>
        ///     Gets or sets the unique code for the value of the "DIS_STATUS" field.
        /// </summary>
        System.String IDistrictModel.StatusCode
        {
            get { return this.StatusCode; }
            set { this.StatusCode = (System.String)value; }
        }

        /// <summary>
        ///     Gets the The value of the "DIS_TYPE" field.
        /// </summary>
        Consensus.Common.ICodeModel IDistrictModel.Type
        {
            get { return this.Type; }
        }

        /// <summary>
        ///     Gets or sets the unique code for the value of the "DIS_TYPE" field.
        /// </summary>
        System.String IDistrictModel.TypeCode
        {
            get { return this.TypeCode; }
            set { this.TypeCode = (System.String)value; }
        }

        /// <summary>
        ///     Gets the The value of the "DIS_CATEGORY" field.
        /// </summary>
        Consensus.Common.ICodeModel IDistrictModel.Category
        {
            get { return this.Category; }
        }

        /// <summary>
        ///     Gets or sets the unique code for the value of the "DIS_CATEGORY" field.
        /// </summary>
        System.String IDistrictModel.CategoryCode
        {
            get { return this.CategoryCode; }
            set { this.CategoryCode = (System.String)value; }
        }

        /// <summary>
        ///     Gets the The value of the "DIS_GROUP" field.
        /// </summary>
        Consensus.Common.ICodeModel IDistrictModel.Group
        {
            get { return this.Group; }
        }

        /// <summary>
        ///     Gets or sets the unique code for the value of the "DIS_GROUP" field.
        /// </summary>
        System.String IDistrictModel.GroupCode
        {
            get { return this.GroupCode; }
            set { this.GroupCode = (System.String)value; }
        }

        /// <summary>
        ///     Gets the The value of the "DIS_REGION" field.
        /// </summary>
        Consensus.Common.ICodeModel IDistrictModel.Region
        {
            get { return this.Region; }
        }

        /// <summary>
        ///     Gets or sets the unique code for the value of the "DIS_REGION" field.
        /// </summary>
        System.String IDistrictModel.RegionCode
        {
            get { return this.RegionCode; }
            set { this.RegionCode = (System.String)value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "DIS_WEB" field.
        /// </summary>
        System.Byte IDistrictModel.Web
        {
            get { return this.Web; }
            set { this.Web = (System.Byte)value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "DIS_EXT_URL" field.
        /// </summary>
        System.String IDistrictModel.ExtUrl
        {
            get { return this.ExtUrl; }
            set { this.ExtUrl = (System.String)value; }
        }

        /// <summary>
        ///     Gets the collection of <see cref="!:CommitteeModel" /> instances that reference this <see cref="!:DistrictModel" />.
        /// </summary>
        Consensus.Collection<Consensus.Membership.ICommitteeModel> IDistrictModel.CommiteeDistrict
        {
            get { return this.CommiteeDistrict; }
        }

        #endregion
    }
}
