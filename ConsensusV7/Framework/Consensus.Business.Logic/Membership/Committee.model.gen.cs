using System;
using System.Collections.Generic;
using System.Linq;
using Consensus.Common;
using Consensus.Learning;

namespace Consensus.Membership
{
    /// <summary>
    ///     Encapsulates the <see cref="CommitteeRecord" /> with standardised business rules.
    /// </summary>
    /// <remarks>
    ///     THIS CODE HAS BEEN AUTOMATICALLY GENERATED USING THE CONSENSUS DEVELOPER TOOLS.
    ///     DO NOT EDIT THIS CODE AS ANY CUSTOM MODIFICATIONS WILL BE LOST UPON REGENERATION.
    /// </remarks>
    public partial class LocalCommitteeModel : LocalModel<CommitteeRecord, String>, ICommitteeModel
    {
        #region fields

        /// <summary>
        ///     The value of the "COM_STATUS" field.
        /// </summary>
        private LocalCodeModel _status;

        /// <summary>
        ///     The value of the "COM_TYPE" field.
        /// </summary>
        private LocalCodeModel _type;

        /// <summary>
        ///     The value of the "COM_CATEGORY" field.
        /// </summary>
        private LocalCodeModel _category;

        /// <summary>
        ///     The value of the "COM_GROUP" field.
        /// </summary>
        private LocalCodeModel _group;

        /// <summary>
        ///     The value of the "COM_DIS_ID" field.
        /// </summary>
        private LocalDistrictModel _disId;

        /// <summary>
        ///     The value of the "COM_PROD_ID" field.
        /// </summary>
        private LocalProductModel _prodId;

        /// <summary>
        ///     The value of the "COM_BR_ID" field.
        /// </summary>
        private LocalBranchModel _brId;

        /// <summary>
        ///     The collection of <see cref="CommitteeXrefModel" /> instances that reference this <see cref="CommitteeModel" />.
        /// </summary>
        private LocalCollection<LocalCommitteeXrefModel, ICommitteeXrefModel> _committeeXrefCommitteeId;

        #endregion

        #region properties

        /// <summary>
        ///     Gets the delegated function that is responsible for persisting a new instance of the data structure within the underlying persistence mechanism.
        /// </summary>
        protected override Action<CommitteeRecord> DataCreator
        {
            get { return this.Provider.DataProvider.Membership.Committee.Create; }
        }

        /// <summary>
        ///     Gets the delegated function that is responsible for persisting an existing instance of the data structure within the underlying persistence mechanism.
        /// </summary>
        protected override Action<CommitteeRecord> DataModifier
        {
            get { return this.Provider.DataProvider.Membership.Committee.Modify; }
        }

        /// <summary>
        ///     Gets the delegated function that is responsible for removing an existing instance of the data structure from the underlying persistence mechanism.
        /// </summary>
        protected override Action<CommitteeRecord> DataRemover
        {
            get { return this.Provider.DataProvider.Membership.Committee.RemoveById; }
        }

        /// <summary>
        ///     Gets or sets the value of the "COM_ADD_DATE" field.
        /// </summary>
        public DateTime? AddDate
        {
            get { return this.ModifiedData.AddDate; }
            set { this.ModifiedData.AddDate = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "COM_NAME" field.
        /// </summary>
        public String Name
        {
            get { return this.ModifiedData.Name; }
            set { this.ModifiedData.Name = value; }
        }

        /// <summary>
        ///     Gets the The value of the "COM_STATUS" field.
        /// </summary>
        public LocalCodeModel Status
        {
            get
            {
                if (_status == null && !String.IsNullOrEmpty(this.StatusCode))
                    _status = this.Provider.Common.Code.FetchByTypeAndCode("CMSTA", this.StatusCode);
                if (_status == null)
                    _status = this.Provider.Common.Code.Create("CMSTA");
                return _status;
            }
        }

        /// <summary>
        ///     Gets or sets the unique code for the value of the "COM_STATUS" field.
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
        ///     Gets the The value of the "COM_TYPE" field.
        /// </summary>
        public LocalCodeModel Type
        {
            get
            {
                if (_type == null && !String.IsNullOrEmpty(this.TypeCode))
                    _type = this.Provider.Common.Code.FetchByTypeAndCode("CMTYP", this.TypeCode);
                if (_type == null)
                    _type = this.Provider.Common.Code.Create("CMTYP");
                return _type;
            }
        }

        /// <summary>
        ///     Gets or sets the unique code for the value of the "COM_TYPE" field.
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
        ///     Gets or sets the value of the "COM_START_DATE" field.
        /// </summary>
        public DateTime? StartDate
        {
            get { return this.ModifiedData.StartDate; }
            set { this.ModifiedData.StartDate = value; }
        }

        /// <summary>
        ///     Gets the The value of the "COM_CATEGORY" field.
        /// </summary>
        public LocalCodeModel Category
        {
            get
            {
                if (_category == null && !String.IsNullOrEmpty(this.CategoryCode))
                    _category = this.Provider.Common.Code.FetchByTypeAndCode("CMCAT", this.CategoryCode);
                if (_category == null)
                    _category = this.Provider.Common.Code.Create("CMCAT");
                return _category;
            }
        }

        /// <summary>
        ///     Gets or sets the unique code for the value of the "COM_CATEGORY" field.
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
        ///     Gets the The value of the "COM_GROUP" field.
        /// </summary>
        public LocalCodeModel Group
        {
            get
            {
                if (_group == null && !String.IsNullOrEmpty(this.GroupCode))
                    _group = this.Provider.Common.Code.FetchByTypeAndCode("CMGRP", this.GroupCode);
                if (_group == null)
                    _group = this.Provider.Common.Code.Create("CMGRP");
                return _group;
            }
        }

        /// <summary>
        ///     Gets or sets the unique code for the value of the "COM_GROUP" field.
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
        ///     Gets the The value of the "COM_DIS_ID" field.
        /// </summary>
        public LocalDistrictModel DisId
        {
            get
            {
                if (_disId == null && this.DisIdId != null)
                    _disId = this.Provider.Membership.District.FetchById(this.DisIdId);
                if (_disId == null)
                    _disId = this.Provider.Membership.District.Create();
                
                return _disId;
            }
        }

        /// <summary>
        ///     Gets or sets the unique code for the value of the "COM_DIS_ID" field.
        /// </summary>
        public String DisIdId
        {
            get { return this.ModifiedData.DisId; }
            set
            {
                if (this.ModifiedData.DisId != value)
                     _disId = null;
                this.ModifiedData.DisId = value;
            }
        }

        /// <summary>
        ///     Gets the The value of the "COM_PROD_ID" field.
        /// </summary>
        public LocalProductModel ProdId
        {
            get
            {
                if (_prodId == null && this.ProdIdId != null)
                    _prodId = this.Provider.Learning.Product.FetchById(this.ProdIdId);
                if (_prodId == null)
                    _prodId = this.Provider.Learning.Product.Create();
                
                return _prodId;
            }
        }

        /// <summary>
        ///     Gets or sets the unique code for the value of the "COM_PROD_ID" field.
        /// </summary>
        public String ProdIdId
        {
            get { return this.ModifiedData.ProdId; }
            set
            {
                if (this.ModifiedData.ProdId != value)
                     _prodId = null;
                this.ModifiedData.ProdId = value;
            }
        }

        /// <summary>
        ///     Gets the The value of the "COM_BR_ID" field.
        /// </summary>
        public LocalBranchModel BrId
        {
            get
            {
                if (_brId == null && this.BrIdId != null)
                    _brId = this.Provider.Membership.Branch.FetchById(this.BrIdId);
                if (_brId == null)
                    _brId = this.Provider.Membership.Branch.Create();
                
                return _brId;
            }
        }

        /// <summary>
        ///     Gets or sets the unique code for the value of the "COM_BR_ID" field.
        /// </summary>
        public String BrIdId
        {
            get { return this.ModifiedData.BrId; }
            set
            {
                if (this.ModifiedData.BrId != value)
                     _brId = null;
                this.ModifiedData.BrId = value;
            }
        }

        /// <summary>
        ///     Gets or sets the value of the "COM_EXT_URL" field.
        /// </summary>
        public String ExtUrl
        {
            get { return this.ModifiedData.ExtUrl; }
            set { this.ModifiedData.ExtUrl = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "COM_SHOW_ON_ORG" field.
        /// </summary>
        public Byte? ShowOnOrg
        {
            get { return this.ModifiedData.ShowOnOrg; }
            set { this.ModifiedData.ShowOnOrg = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "COM_NO_PEOPLE" field.
        /// </summary>
        public Int32? NoPeople
        {
            get { return this.ModifiedData.NoPeople; }
            set { this.ModifiedData.NoPeople = value; }
        }

        /// <summary>
        ///     Gets the collection of <see cref="CommitteeXrefModel" /> instances that reference this <see cref="CommitteeModel" />.
        /// </summary>
        public LocalCollection<LocalCommitteeXrefModel, ICommitteeXrefModel> CommitteeXrefCommitteeId
        {
            get
            {
                if (_committeeXrefCommitteeId == null)
                    _committeeXrefCommitteeId = new LocalCollection<LocalCommitteeXrefModel, ICommitteeXrefModel>(this.Provider.Membership.CommitteeXref.FetchAllByCommitteeId(this.Id));
                
                return _committeeXrefCommitteeId;
            }
        }

        #endregion

        #region constructors

        /// <summary>
        ///     Initialises a new <see cref="LocalCommitteeModel" /> instance.
        /// </summary>
        /// <param name="provider">
        ///     The business provider to which the business model is bound.
        /// </param>
        internal LocalCommitteeModel(LocalProvider provider) : base(provider)
        {
        }

        /// <summary>
        ///     Initialises a new <see cref="LocalCommitteeModel" /> instance.
        /// </summary>
        /// <param name="provider">
        ///     The business provider to which the business model is bound.
        /// </param>
        /// <param name="record">
        ///     The data record which is encapsulated by the business model.
        /// </param>
        internal LocalCommitteeModel(LocalProvider provider, CommitteeRecord record) : base(provider, record)
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
            if (_disId != null)
            {
                _disId.Save();
                this.ModifiedData.DisId = _disId.Id == null && this.ModifiedData.DisId != null ? "" : _disId.Id;
            }
            if (_prodId != null)
            {
                _prodId.Save();
                this.ModifiedData.ProdId = _prodId.Id == null && this.ModifiedData.ProdId != null ? "" : _prodId.Id;
            }
            if (_brId != null)
            {
                _brId.Save();
                this.ModifiedData.BrId = _brId.Id == null && this.ModifiedData.BrId != null ? "" : _brId.Id;
            }
        }

        /// <summary>
        ///     Resolves the dependent models by means of updating all models that reference this model.
        /// </summary>
        protected override void ResolveGeneratedDependent()
        {
            base.ResolveGeneratedDependent();
            if (_committeeXrefCommitteeId != null)
                _committeeXrefCommitteeId.Execute(obj => obj.CommitteeId = this.Id).Execute(obj => obj.Save());
        }

        #endregion

        #region implementations

        /// <summary>
        ///     Gets or sets the value of the "COM_ADD_DATE" field.
        /// </summary>
        System.Nullable<System.DateTime> ICommitteeModel.AddDate
        {
            get { return this.AddDate; }
            set { this.AddDate = (System.Nullable<System.DateTime>)value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "COM_NAME" field.
        /// </summary>
        System.String ICommitteeModel.Name
        {
            get { return this.Name; }
            set { this.Name = (System.String)value; }
        }

        /// <summary>
        ///     Gets the The value of the "COM_STATUS" field.
        /// </summary>
        Consensus.Common.ICodeModel ICommitteeModel.Status
        {
            get { return this.Status; }
        }

        /// <summary>
        ///     Gets or sets the unique code for the value of the "COM_STATUS" field.
        /// </summary>
        System.String ICommitteeModel.StatusCode
        {
            get { return this.StatusCode; }
            set { this.StatusCode = (System.String)value; }
        }

        /// <summary>
        ///     Gets the The value of the "COM_TYPE" field.
        /// </summary>
        Consensus.Common.ICodeModel ICommitteeModel.Type
        {
            get { return this.Type; }
        }

        /// <summary>
        ///     Gets or sets the unique code for the value of the "COM_TYPE" field.
        /// </summary>
        System.String ICommitteeModel.TypeCode
        {
            get { return this.TypeCode; }
            set { this.TypeCode = (System.String)value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "COM_START_DATE" field.
        /// </summary>
        System.Nullable<System.DateTime> ICommitteeModel.StartDate
        {
            get { return this.StartDate; }
            set { this.StartDate = (System.Nullable<System.DateTime>)value; }
        }

        /// <summary>
        ///     Gets the The value of the "COM_CATEGORY" field.
        /// </summary>
        Consensus.Common.ICodeModel ICommitteeModel.Category
        {
            get { return this.Category; }
        }

        /// <summary>
        ///     Gets or sets the unique code for the value of the "COM_CATEGORY" field.
        /// </summary>
        System.String ICommitteeModel.CategoryCode
        {
            get { return this.CategoryCode; }
            set { this.CategoryCode = (System.String)value; }
        }

        /// <summary>
        ///     Gets the The value of the "COM_GROUP" field.
        /// </summary>
        Consensus.Common.ICodeModel ICommitteeModel.Group
        {
            get { return this.Group; }
        }

        /// <summary>
        ///     Gets or sets the unique code for the value of the "COM_GROUP" field.
        /// </summary>
        System.String ICommitteeModel.GroupCode
        {
            get { return this.GroupCode; }
            set { this.GroupCode = (System.String)value; }
        }

        /// <summary>
        ///     Gets the The value of the "COM_DIS_ID" field.
        /// </summary>
        Consensus.Membership.IDistrictModel ICommitteeModel.DisId
        {
            get { return this.DisId; }
        }

        /// <summary>
        ///     Gets or sets the unique code for the value of the "COM_DIS_ID" field.
        /// </summary>
        System.String ICommitteeModel.DisIdId
        {
            get { return this.DisIdId; }
            set { this.DisIdId = (System.String)value; }
        }

        /// <summary>
        ///     Gets the The value of the "COM_PROD_ID" field.
        /// </summary>
        Consensus.Learning.IProductModel ICommitteeModel.ProdId
        {
            get { return this.ProdId; }
        }

        /// <summary>
        ///     Gets or sets the unique code for the value of the "COM_PROD_ID" field.
        /// </summary>
        System.String ICommitteeModel.ProdIdId
        {
            get { return this.ProdIdId; }
            set { this.ProdIdId = (System.String)value; }
        }

        /// <summary>
        ///     Gets the The value of the "COM_BR_ID" field.
        /// </summary>
        Consensus.Membership.IBranchModel ICommitteeModel.BrId
        {
            get { return this.BrId; }
        }

        /// <summary>
        ///     Gets or sets the unique code for the value of the "COM_BR_ID" field.
        /// </summary>
        System.String ICommitteeModel.BrIdId
        {
            get { return this.BrIdId; }
            set { this.BrIdId = (System.String)value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "COM_EXT_URL" field.
        /// </summary>
        System.String ICommitteeModel.ExtUrl
        {
            get { return this.ExtUrl; }
            set { this.ExtUrl = (System.String)value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "COM_SHOW_ON_ORG" field.
        /// </summary>
        System.Nullable<System.Byte> ICommitteeModel.ShowOnOrg
        {
            get { return this.ShowOnOrg; }
            set { this.ShowOnOrg = (System.Nullable<System.Byte>)value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "COM_NO_PEOPLE" field.
        /// </summary>
        System.Nullable<System.Int32> ICommitteeModel.NoPeople
        {
            get { return this.NoPeople; }
            set { this.NoPeople = (System.Nullable<System.Int32>)value; }
        }

        /// <summary>
        ///     Gets the collection of <see cref="!:CommitteeXrefModel" /> instances that reference this <see cref="!:CommitteeModel" />.
        /// </summary>
        Consensus.Collection<Consensus.Membership.ICommitteeXrefModel> ICommitteeModel.CommitteeXrefCommitteeId
        {
            get { return this.CommitteeXrefCommitteeId; }
        }

        #endregion
    }
}
