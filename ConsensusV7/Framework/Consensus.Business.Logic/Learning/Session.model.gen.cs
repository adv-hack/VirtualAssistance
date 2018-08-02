using System;
using System.Collections.Generic;
using System.Linq;
using Consensus.Activities;
using Consensus.Contact;

namespace Consensus.Learning
{
    /// <summary>
    ///     Encapsulates the <see cref="ActivityRecord" /> with standardised business rules.
    /// </summary>
    /// <remarks>
    ///     THIS CODE HAS BEEN AUTOMATICALLY GENERATED USING THE CONSENSUS DEVELOPER TOOLS.
    ///     DO NOT EDIT THIS CODE AS ANY CUSTOM MODIFICATIONS WILL BE LOST UPON REGENERATION.
    /// </remarks>
    public partial class LocalSessionModel : LocalActivityModel, ISessionModel
    {
        #region fields

        /// <summary>
        ///     The value of the "ACT_LOC_ID" field.
        /// </summary>
        private LocalLocationModel _location;

        /// <summary>
        ///     The value of the "ACT_SYLLABUS_ID" field.
        /// </summary>
        private LocalProductModel _product;

        /// <summary>
        ///     The value of the "ACT_ORG_ID" field.
        /// </summary>
        private LocalOrganisationModel _organisation;

        /// <summary>
        ///     The value of the "ACT_BOM_ID" field.
        /// </summary>
        private LocalBillOfMaterialModel _biillOfMaterial;

        /// <summary>
        ///     The collection of <see cref="SessionXrefModel" /> instances that reference this <see cref="SessionModel" />.
        /// </summary>
        private LocalCollection<LocalSessionXrefModel, ISessionXrefModel> _sessionXrefActivity;

        #endregion

        #region properties

        /// <summary>
        ///     Gets the delegated function that is responsible for persisting a new instance of the data structure within the underlying persistence mechanism.
        /// </summary>
        protected override Action<ActivityRecord> DataCreator
        {
            get { return this.Provider.DataProvider.Activities.Activity.Create; }
        }

        /// <summary>
        ///     Gets the delegated function that is responsible for persisting an existing instance of the data structure within the underlying persistence mechanism.
        /// </summary>
        protected override Action<ActivityRecord> DataModifier
        {
            get { return this.Provider.DataProvider.Activities.Activity.Modify; }
        }

        /// <summary>
        ///     Gets the delegated function that is responsible for removing an existing instance of the data structure from the underlying persistence mechanism.
        /// </summary>
        protected override Action<ActivityRecord> DataRemover
        {
            get { return this.Provider.DataProvider.Activities.Activity.RemoveById; }
        }

        /// <summary>
        ///     Gets or sets the value of the "ACT_DONE_IT" field.
        /// </summary>
        public Byte? DoneIt
        {
            get { return this.ModifiedData.DoneIt; }
            set { this.ModifiedData.DoneIt = value; }
        }

        /// <summary>
        ///     Gets the The value of the "ACT_LOC_ID" field.
        /// </summary>
        public LocalLocationModel Location
        {
            get
            {
                if (_location == null && this.LocationId != null)
                    _location = this.Provider.Contact.Location.FetchById(this.LocationId);
                if (_location == null)
                    _location = this.Provider.Contact.Location.Create();
                
                return _location;
            }
        }

        /// <summary>
        ///     Gets or sets the unique code for the value of the "ACT_LOC_ID" field.
        /// </summary>
        public String LocationId
        {
            get { return this.ModifiedData.LocId; }
            set
            {
                if (this.ModifiedData.LocId != value)
                     _location = null;
                this.ModifiedData.LocId = value;
            }
        }

        /// <summary>
        ///     Gets the The value of the "ACT_SYLLABUS_ID" field.
        /// </summary>
        public LocalProductModel Product
        {
            get
            {
                if (_product == null && this.ProductId != null)
                    _product = this.Provider.Learning.Product.FetchById(this.ProductId);
                if (_product == null)
                    _product = this.Provider.Learning.Product.Create();
                
                return _product;
            }
        }

        /// <summary>
        ///     Gets or sets the unique code for the value of the "ACT_SYLLABUS_ID" field.
        /// </summary>
        public String ProductId
        {
            get { return this.ModifiedData.SyllabusId; }
            set
            {
                if (this.ModifiedData.SyllabusId != value)
                     _product = null;
                this.ModifiedData.SyllabusId = value;
            }
        }

        /// <summary>
        ///     Gets or sets the value of the "ACT_MAX_PLACES" field.
        /// </summary>
        public Double? MaxPlaces
        {
            get { return this.ModifiedData.MaxPlaces; }
            set { this.ModifiedData.MaxPlaces = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "ACT_MIN_PLACES" field.
        /// </summary>
        public Double? MinPlaces
        {
            get { return this.ModifiedData.MinPlaces; }
            set { this.ModifiedData.MinPlaces = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "ACT_FREE_PLACES" field.
        /// </summary>
        public Double? FreePlaces
        {
            get { return this.ModifiedData.FreePlaces; }
            set { this.ModifiedData.FreePlaces = value; }
        }

        /// <summary>
        ///     Gets the The value of the "ACT_ORG_ID" field.
        /// </summary>
        public LocalOrganisationModel Organisation
        {
            get
            {
                if (_organisation == null && this.OrganisationId != null)
                    _organisation = this.Provider.Contact.Organisation.FetchById(this.OrganisationId);
                if (_organisation == null)
                    _organisation = this.Provider.Contact.Organisation.Create();
                
                return _organisation;
            }
        }

        /// <summary>
        ///     Gets or sets the unique code for the value of the "ACT_ORG_ID" field.
        /// </summary>
        public String OrganisationId
        {
            get { return this.ModifiedData.OrgId; }
            set
            {
                if (this.ModifiedData.OrgId != value)
                     _organisation = null;
                this.ModifiedData.OrgId = value;
            }
        }

        /// <summary>
        ///     Gets or sets the value of the "ACT_ADDRESS" field.
        /// </summary>
        public String Address
        {
            get { return this.ModifiedData.Address; }
            set { this.ModifiedData.Address = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "ACT_PQ_ID" field.
        /// </summary>
        public String PqId
        {
            get { return this.ModifiedData.PqId; }
            set { this.ModifiedData.PqId = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "ACT_ROOM_LAYOUT" field.
        /// </summary>
        public Int32? RoomLayout
        {
            get { return this.ModifiedData.RoomLayout; }
            set { this.ModifiedData.RoomLayout = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "ACT_TEACH_HRS" field.
        /// </summary>
        public Decimal? TeachHrs
        {
            get { return this.ModifiedData.TeachHrs; }
            set { this.ModifiedData.TeachHrs = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "ACT_STUD_WKS" field.
        /// </summary>
        public Decimal? StudWks
        {
            get { return this.ModifiedData.StudWks; }
            set { this.ModifiedData.StudWks = value; }
        }

        /// <summary>
        ///     Gets the The value of the "ACT_BOM_ID" field.
        /// </summary>
        public LocalBillOfMaterialModel BiillOfMaterial
        {
            get
            {
                if (_biillOfMaterial == null && this.BiillOfMaterialId != null)
                    _biillOfMaterial = this.Provider.Learning.BillOfMaterial.FetchById(this.BiillOfMaterialId);
                if (_biillOfMaterial == null)
                    _biillOfMaterial = this.Provider.Learning.BillOfMaterial.Create();
                
                return _biillOfMaterial;
            }
        }

        /// <summary>
        ///     Gets or sets the unique code for the value of the "ACT_BOM_ID" field.
        /// </summary>
        public String BiillOfMaterialId
        {
            get { return this.ModifiedData.BomId; }
            set
            {
                if (this.ModifiedData.BomId != value)
                     _biillOfMaterial = null;
                this.ModifiedData.BomId = value;
            }
        }

        /// <summary>
        ///     Gets or sets the value of the "ACT_CG_CODE" field.
        /// </summary>
        public String UnitNumber
        {
            get { return this.ModifiedData.CgCode; }
            set { this.ModifiedData.CgCode = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "ACT_SHOW_ATT_LOG" field.
        /// </summary>
        public Byte? ShowAttLog
        {
            get { return this.ModifiedData.ShowAttLog; }
            set { this.ModifiedData.ShowAttLog = value; }
        }

        /// <summary>
        ///     Gets the collection of <see cref="SessionXrefModel" /> instances that reference this <see cref="SessionModel" />.
        /// </summary>
        public LocalCollection<LocalSessionXrefModel, ISessionXrefModel> SessionXrefActivity
        {
            get
            {
                if (_sessionXrefActivity == null)
                    _sessionXrefActivity = new LocalCollection<LocalSessionXrefModel, ISessionXrefModel>(this.Provider.Learning.SessionXref.FetchAllBySessionId(this.Id));
                
                return _sessionXrefActivity;
            }
        }

        #endregion

        #region constructors

        /// <summary>
        ///     Initialises a new <see cref="LocalSessionModel" /> instance.
        /// </summary>
        /// <param name="provider">
        ///     The business provider to which the business model is bound.
        /// </param>
        internal LocalSessionModel(LocalProvider provider) : base(provider)
        {
        }

        /// <summary>
        ///     Initialises a new <see cref="LocalSessionModel" /> instance.
        /// </summary>
        /// <param name="provider">
        ///     The business provider to which the business model is bound.
        /// </param>
        /// <param name="record">
        ///     The data record which is encapsulated by the business model.
        /// </param>
        internal LocalSessionModel(LocalProvider provider, ActivityRecord record) : base(provider, record)
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
            if (_location != null)
            {
                _location.Save();
                this.ModifiedData.LocId = _location.Id == null && this.ModifiedData.LocId != null ? "" : _location.Id;
            }
            if (_product != null)
            {
                _product.Save();
                this.ModifiedData.SyllabusId = _product.Id == null && this.ModifiedData.SyllabusId != null ? "" : _product.Id;
            }
            if (_organisation != null)
            {
                _organisation.Save();
                this.ModifiedData.OrgId = _organisation.Id == null && this.ModifiedData.OrgId != null ? "" : _organisation.Id;
            }
            if (_biillOfMaterial != null)
            {
                _biillOfMaterial.Save();
                this.ModifiedData.BomId = _biillOfMaterial.Id == null && this.ModifiedData.BomId != null ? "" : _biillOfMaterial.Id;
            }
        }

        /// <summary>
        ///     Resolves the dependent models by means of updating all models that reference this model.
        /// </summary>
        protected override void ResolveGeneratedDependent()
        {
            base.ResolveGeneratedDependent();
            if (_sessionXrefActivity != null)
                _sessionXrefActivity.Execute(obj => obj.SessionId = this.Id).Execute(obj => obj.Save());
        }

        #endregion

        #region implementations

        /// <summary>
        ///     Gets or sets the main session.
        /// </summary>
        Consensus.Learning.ISessionXrefModel ISessionModel.SessionXrefMaster
        {
            get { return this.SessionXrefMaster; }
        }

        System.Boolean ISessionModel.IsModified
        {
            get { return this.IsModified; }
        }

        /// <summary>
        ///     Gets or sets the value of the "ACT_DONE_IT" field.
        /// </summary>
        System.Nullable<System.Byte> ISessionModel.DoneIt
        {
            get { return this.DoneIt; }
            set { this.DoneIt = (System.Nullable<System.Byte>)value; }
        }

        /// <summary>
        ///     Gets the The value of the "ACT_LOC_ID" field.
        /// </summary>
        Consensus.Contact.ILocationModel ISessionModel.Location
        {
            get { return this.Location; }
        }

        /// <summary>
        ///     Gets or sets the unique code for the value of the "ACT_LOC_ID" field.
        /// </summary>
        System.String ISessionModel.LocationId
        {
            get { return this.LocationId; }
            set { this.LocationId = (System.String)value; }
        }

        /// <summary>
        ///     Gets the The value of the "ACT_SYLLABUS_ID" field.
        /// </summary>
        Consensus.Learning.IProductModel ISessionModel.Product
        {
            get { return this.Product; }
        }

        /// <summary>
        ///     Gets or sets the unique code for the value of the "ACT_SYLLABUS_ID" field.
        /// </summary>
        System.String ISessionModel.ProductId
        {
            get { return this.ProductId; }
            set { this.ProductId = (System.String)value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "ACT_MAX_PLACES" field.
        /// </summary>
        System.Nullable<System.Double> ISessionModel.MaxPlaces
        {
            get { return this.MaxPlaces; }
            set { this.MaxPlaces = (System.Nullable<System.Double>)value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "ACT_MIN_PLACES" field.
        /// </summary>
        System.Nullable<System.Double> ISessionModel.MinPlaces
        {
            get { return this.MinPlaces; }
            set { this.MinPlaces = (System.Nullable<System.Double>)value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "ACT_FREE_PLACES" field.
        /// </summary>
        System.Nullable<System.Double> ISessionModel.FreePlaces
        {
            get { return this.FreePlaces; }
            set { this.FreePlaces = (System.Nullable<System.Double>)value; }
        }

        /// <summary>
        ///     Gets the The value of the "ACT_ORG_ID" field.
        /// </summary>
        Consensus.Contact.IOrganisationModel ISessionModel.Organisation
        {
            get { return this.Organisation; }
        }

        /// <summary>
        ///     Gets or sets the unique code for the value of the "ACT_ORG_ID" field.
        /// </summary>
        System.String ISessionModel.OrganisationId
        {
            get { return this.OrganisationId; }
            set { this.OrganisationId = (System.String)value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "ACT_ADDRESS" field.
        /// </summary>
        System.String ISessionModel.Address
        {
            get { return this.Address; }
            set { this.Address = (System.String)value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "ACT_PQ_ID" field.
        /// </summary>
        System.String ISessionModel.PqId
        {
            get { return this.PqId; }
            set { this.PqId = (System.String)value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "ACT_ROOM_LAYOUT" field.
        /// </summary>
        System.Nullable<System.Int32> ISessionModel.RoomLayout
        {
            get { return this.RoomLayout; }
            set { this.RoomLayout = (System.Nullable<System.Int32>)value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "ACT_TEACH_HRS" field.
        /// </summary>
        System.Nullable<System.Decimal> ISessionModel.TeachHrs
        {
            get { return this.TeachHrs; }
            set { this.TeachHrs = (System.Nullable<System.Decimal>)value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "ACT_STUD_WKS" field.
        /// </summary>
        System.Nullable<System.Decimal> ISessionModel.StudWks
        {
            get { return this.StudWks; }
            set { this.StudWks = (System.Nullable<System.Decimal>)value; }
        }

        /// <summary>
        ///     Gets the The value of the "ACT_BOM_ID" field.
        /// </summary>
        Consensus.Learning.IBillOfMaterialModel ISessionModel.BiillOfMaterial
        {
            get { return this.BiillOfMaterial; }
        }

        /// <summary>
        ///     Gets or sets the unique code for the value of the "ACT_BOM_ID" field.
        /// </summary>
        System.String ISessionModel.BiillOfMaterialId
        {
            get { return this.BiillOfMaterialId; }
            set { this.BiillOfMaterialId = (System.String)value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "ACT_CG_CODE" field.
        /// </summary>
        System.String ISessionModel.UnitNumber
        {
            get { return this.UnitNumber; }
            set { this.UnitNumber = (System.String)value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "ACT_SHOW_ATT_LOG" field.
        /// </summary>
        System.Nullable<System.Byte> ISessionModel.ShowAttLog
        {
            get { return this.ShowAttLog; }
            set { this.ShowAttLog = (System.Nullable<System.Byte>)value; }
        }

        /// <summary>
        ///     Gets the collection of <see cref="!:SessionXrefModel" /> instances that reference this <see cref="!:SessionModel" />.
        /// </summary>
        Consensus.Collection<Consensus.Learning.ISessionXrefModel> ISessionModel.SessionXrefActivity
        {
            get { return this.SessionXrefActivity; }
        }

        #endregion
    }
}
