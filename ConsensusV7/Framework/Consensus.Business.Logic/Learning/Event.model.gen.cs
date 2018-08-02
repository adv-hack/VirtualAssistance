using System;
using System.Collections.Generic;
using System.Linq;
using Consensus.Common;
using Consensus.Contact;
using Consensus.Finance;
using Consensus.Marketing;
using Consensus.Sales;

namespace Consensus.Learning
{
    /// <summary>
    ///     Encapsulates the <see cref="CourseRecord" /> with standardised business rules.
    /// </summary>
    /// <remarks>
    ///     THIS CODE HAS BEEN AUTOMATICALLY GENERATED USING THE CONSENSUS DEVELOPER TOOLS.
    ///     DO NOT EDIT THIS CODE AS ANY CUSTOM MODIFICATIONS WILL BE LOST UPON REGENERATION.
    /// </remarks>
    public partial class LocalEventModel : LocalModel<CourseRecord, String>, IEventModel
    {
        #region fields

        /// <summary>
        ///     The value of the "COURSE_PERSON_ID" field.
        /// </summary>
        private LocalPersonModel _manager;

        /// <summary>
        ///     The value of the "COURSE_PRODUCT_ID" field.
        /// </summary>
        private LocalProductModel _product;

        /// <summary>
        ///     The value of the "COURSE_LOC_ID" field.
        /// </summary>
        private LocalLocationModel _location;

        /// <summary>
        ///     The value of the "COURSE_ORG_ID" field.
        /// </summary>
        private LocalOrganisationModel _organisation;

        /// <summary>
        ///     The value of the "COURSE_TYPE" field.
        /// </summary>
        private LocalCodeModel _type;

        /// <summary>
        ///     The value of the "COURSE_STATUS" field.
        /// </summary>
        private LocalCodeModel _status;

        /// <summary>
        ///     The value of the "COURSE_REV_CODE" field.
        /// </summary>
        private LocalCodeModel _rev;

        /// <summary>
        ///     The value of the "COURSE_NOTES" field.
        /// </summary>
        private LocalNotesModel _notes;

        /// <summary>
        ///     The value of the "COURSE_SUPPLIER_ID" field.
        /// </summary>
        private LocalOrganisationModel _commissioned;

        /// <summary>
        ///     The value of the "COURSE_OPP_ID" field.
        /// </summary>
        private LocalOpportunityModel _opportunity;

        /// <summary>
        ///     The value of the "COURSE_ADD_ID" field.
        /// </summary>
        private LocalAddressModel _address;

        /// <summary>
        ///     The value of the "COURSE_SUP_ROLE_ID" field.
        /// </summary>
        private LocalRoleModel _commissionedRole;

        /// <summary>
        ///     The value of the "COURSE_SELCO_SP_ID" field.
        /// </summary>
        private LocalSellingCompanyModel _sellingCompany;

        /// <summary>
        ///     The value of the "COURSE_BKT_ID" field.
        /// </summary>
        private LocalBookingTermsModel _bookingTerms;

        /// <summary>
        ///     The value of the "COURSE_CONTPROL_ID" field.
        /// </summary>
        private LocalRoleModel _contact;

        /// <summary>
        ///     The value of the "COURSE_SUP_STATUS" field.
        /// </summary>
        private LocalCodeModel _supplierStatus;

        /// <summary>
        ///     The value of the "COURSE_PROV_ORG_ID" field.
        /// </summary>
        private LocalOrganisationModel _supplierOrg;

        /// <summary>
        ///     The value of the "COURSE_PROV_PROLE_ID" field.
        /// </summary>
        private LocalRoleModel _supplierRole;

        /// <summary>
        ///     The value of the "COURSE_FUNDED_ORG_ID" field.
        /// </summary>
        private LocalOrganisationModel _fundingOrganisation;

        /// <summary>
        ///     The value of the "COURSE_DEF_ELEM_ST" field.
        /// </summary>
        private LocalCodeModel _defaultDelegateStatus;

        /// <summary>
        ///     The value of the "COURSE_INT_NOTES" field.
        /// </summary>
        private LocalNotesModel _intNotes;

        /// <summary>
        ///     The value of the "COURSE_REASON" field.
        /// </summary>
        private LocalCodeModel _cancellationReason;

        /// <summary>
        ///     The value of the "COURSE_MTR_PROLE_ID" field.
        /// </summary>
        private LocalRoleModel _mainTrainer;

        /// <summary>
        ///     The value of the "COURSE_ACADY_CODE" field.
        /// </summary>
        private LocalCodeModel _academicYear;

        /// <summary>
        ///     The value of the "COURSE_PSH_ID" field.
        /// </summary>
        private LocalPayscheduleheaderModel _payScheduleHeader;

        /// <summary>
        ///     The collection of <see cref="ElementModel" /> instances that reference this <see cref="EventModel" />.
        /// </summary>
        private LocalCollection<LocalElementModel, IElementModel> _elements;

        /// <summary>
        ///     The collection of <see cref="SessionXrefModel" /> instances that reference this <see cref="EventModel" />.
        /// </summary>
        private LocalCollection<LocalSessionXrefModel, ISessionXrefModel> _sessionXrefEvent;

        /// <summary>
        ///     The collection of <see cref="CourseSelectGroupsModel" /> instances that reference this <see cref="EventModel" />.
        /// </summary>
        private LocalCollection<LocalCourseSelectGroupsModel, ICourseSelectGroupsModel> _selectinGroupEvent;

        /// <summary>
        ///     The collection of <see cref="EventProductModel" /> instances that reference this <see cref="EventModel" />.
        /// </summary>
        private LocalCollection<LocalEventProductModel, IEventProductModel> _eventEP;

        /// <summary>
        ///     The collection of <see cref="OpportunityModel" /> instances that reference this <see cref="EventModel" />.
        /// </summary>
        private LocalCollection<LocalOpportunityModel, IOpportunityModel> _oppEventId;

        /// <summary>
        ///     The collection of <see cref="InvoiceLineModel" /> instances that reference this <see cref="EventModel" />.
        /// </summary>
        private LocalCollection<LocalInvoiceLineModel, IInvoiceLineModel> _invoiceLines;

        /// <summary>
        ///     The collection of <see cref="PromotionMasterModel" /> instances that reference this <see cref="EventModel" />.
        /// </summary>
        private LocalCollection<LocalPromotionMasterModel, IPromotionMasterModel> _promotionMasterEvent;

        /// <summary>
        ///     The collection of <see cref="SaqQueryModel" /> instances that reference this <see cref="EventModel" />.
        /// </summary>
        private LocalCollection<LocalSaqQueryModel, ISaqQueryModel> _saqQueryEvent;

        #endregion

        #region properties

        /// <summary>
        ///     Gets the delegated function that is responsible for persisting a new instance of the data structure within the underlying persistence mechanism.
        /// </summary>
        protected override Action<CourseRecord> DataCreator
        {
            get { return this.Provider.DataProvider.Learning.Event.Create; }
        }

        /// <summary>
        ///     Gets the delegated function that is responsible for persisting an existing instance of the data structure within the underlying persistence mechanism.
        /// </summary>
        protected override Action<CourseRecord> DataModifier
        {
            get { return this.Provider.DataProvider.Learning.Event.Modify; }
        }

        /// <summary>
        ///     Gets the delegated function that is responsible for removing an existing instance of the data structure from the underlying persistence mechanism.
        /// </summary>
        protected override Action<CourseRecord> DataRemover
        {
            get { return this.Provider.DataProvider.Learning.Event.RemoveById; }
        }

        /// <summary>
        ///     Gets the The value of the "COURSE_PERSON_ID" field.
        /// </summary>
        public LocalPersonModel Manager
        {
            get
            {
                if (_manager == null && this.ManagerId != null)
                    _manager = this.Provider.Contact.Person.FetchById(this.ManagerId);
                if (_manager == null)
                    _manager = this.Provider.Contact.Person.Create();
                
                return _manager;
            }
        }

        /// <summary>
        ///     Gets or sets the unique code for the value of the "COURSE_PERSON_ID" field.
        /// </summary>
        public String ManagerId
        {
            get { return this.ModifiedData.PersonId; }
            set
            {
                if (this.ModifiedData.PersonId != value)
                     _manager = null;
                this.ModifiedData.PersonId = value;
            }
        }

        /// <summary>
        ///     Gets the The value of the "COURSE_PRODUCT_ID" field.
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
        ///     Gets or sets the unique code for the value of the "COURSE_PRODUCT_ID" field.
        /// </summary>
        public String ProductId
        {
            get { return this.ModifiedData.ProductId; }
            set
            {
                if (this.ModifiedData.ProductId != value)
                     _product = null;
                this.ModifiedData.ProductId = value;
            }
        }

        /// <summary>
        ///     Gets the The value of the "COURSE_LOC_ID" field.
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
        ///     Gets or sets the unique code for the value of the "COURSE_LOC_ID" field.
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
        ///     Gets the The value of the "COURSE_ORG_ID" field.
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
        ///     Gets or sets the unique code for the value of the "COURSE_ORG_ID" field.
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
        ///     Gets or sets the value of the "COURSE_REF" field.
        /// </summary>
        public String Ref
        {
            get { return this.ModifiedData.Ref; }
            set { this.ModifiedData.Ref = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "COURSE_NAME" field.
        /// </summary>
        public String Name
        {
            get { return this.ModifiedData.Name; }
            set { this.ModifiedData.Name = value; }
        }

        /// <summary>
        ///     Gets the The value of the "COURSE_TYPE" field.
        /// </summary>
        public LocalCodeModel Type
        {
            get
            {
                if (_type == null && !String.IsNullOrEmpty(this.TypeCode))
                    _type = this.Provider.Common.Code.FetchByTypeAndCode("COURT", this.TypeCode);
                if (_type == null)
                    _type = this.Provider.Common.Code.Create("COURT");
                return _type;
            }
        }

        /// <summary>
        ///     Gets or sets the unique code for the value of the "COURSE_TYPE" field.
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
        ///     Gets or sets the value of the "COURSE_BLOCK_PRICD" field.
        /// </summary>
        public Byte? Pricing
        {
            get { return this.ModifiedData.BlockPricd; }
            set { this.ModifiedData.BlockPricd = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "COURSE_START_DATE" field.
        /// </summary>
        public DateTime? StartDate
        {
            get { return this.ModifiedData.StartDate; }
            set { this.ModifiedData.StartDate = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "COURSE_END_DATE" field.
        /// </summary>
        public DateTime? EndDate
        {
            get { return this.ModifiedData.EndDate; }
            set { this.ModifiedData.EndDate = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "COURSE_START_TIME" field.
        /// </summary>
        public DateTime? StartTime
        {
            get { return this.ModifiedData.StartTime; }
            set { this.ModifiedData.StartTime = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "COURSE_END_TIME" field.
        /// </summary>
        public DateTime? EndTime
        {
            get { return this.ModifiedData.EndTime; }
            set { this.ModifiedData.EndTime = value; }
        }

        /// <summary>
        ///     Gets the The value of the "COURSE_STATUS" field.
        /// </summary>
        public LocalCodeModel Status
        {
            get
            {
                if (_status == null && !String.IsNullOrEmpty(this.StatusCode))
                    _status = this.Provider.Common.Code.FetchByTypeAndCode("COUST", this.StatusCode);
                if (_status == null)
                    _status = this.Provider.Common.Code.Create("COUST");
                return _status;
            }
        }

        /// <summary>
        ///     Gets or sets the unique code for the value of the "COURSE_STATUS" field.
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
        ///     Gets or sets the value of the "COURSE_LENGTH" field.
        /// </summary>
        public Double? Length
        {
            get { return this.ModifiedData.Length; }
            set { this.ModifiedData.Length = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "COURSE_MIN_PLACES" field.
        /// </summary>
        public Double? MinPlaces
        {
            get { return this.ModifiedData.MinPlaces; }
            set { this.ModifiedData.MinPlaces = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "COURSE_MAX_PLACES" field.
        /// </summary>
        public Double? MaxPlaces
        {
            get { return this.ModifiedData.MaxPlaces; }
            set { this.ModifiedData.MaxPlaces = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "COURSE_FREE_PLACES" field.
        /// </summary>
        public Double? FreePlaces
        {
            get { return this.ModifiedData.FreePlaces; }
            set { this.ModifiedData.FreePlaces = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "COURSE_CONF_PLACES" field.
        /// </summary>
        public Double? ConfirmedPlaces
        {
            get { return this.ModifiedData.ConfPlaces; }
            set { this.ModifiedData.ConfPlaces = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "COURSE_PROVIS_BKGS" field.
        /// </summary>
        public Double? ProvisionalPlaces
        {
            get { return this.ModifiedData.ProvisBkgs; }
            set { this.ModifiedData.ProvisBkgs = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "COURSE_RESV_PLACES" field.
        /// </summary>
        public Double? WaitlistPlaces
        {
            get { return this.ModifiedData.ResvPlaces; }
            set { this.ModifiedData.ResvPlaces = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "COURSE_CANCELS" field.
        /// </summary>
        public Double? CancelledPlaces
        {
            get { return this.ModifiedData.Cancels; }
            set { this.ModifiedData.Cancels = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "COURSE_BLOCK_PRICE" field.
        /// </summary>
        public Double? BlockPrice
        {
            get { return this.ModifiedData.BlockPrice; }
            set { this.ModifiedData.BlockPrice = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "COURSE_STUDT_PRICE" field.
        /// </summary>
        public Double? UnitPrice
        {
            get { return this.ModifiedData.StudtPrice; }
            set { this.ModifiedData.StudtPrice = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "COURSE_COST_CODE" field.
        /// </summary>
        public String CostCode
        {
            get { return this.ModifiedData.CostCode; }
            set { this.ModifiedData.CostCode = value; }
        }

        /// <summary>
        ///     Gets the The value of the "COURSE_REV_CODE" field.
        /// </summary>
        public LocalCodeModel Rev
        {
            get
            {
                if (_rev == null && !String.IsNullOrEmpty(this.RevCode))
                    _rev = this.Provider.Common.Code.FetchByTypeAndCode("REVE", this.RevCode);
                if (_rev == null)
                    _rev = this.Provider.Common.Code.Create("REVE");
                return _rev;
            }
        }

        /// <summary>
        ///     Gets or sets the unique code for the value of the "COURSE_REV_CODE" field.
        /// </summary>
        public String RevCode
        {
            get { return this.ModifiedData.RevCode; }
            set
            {
                if (this.ModifiedData.RevCode != value)
                     _rev = null;
                this.ModifiedData.RevCode = value;
            }
        }

        /// <summary>
        ///     Gets the The value of the "COURSE_NOTES" field.
        /// </summary>
        public LocalNotesModel Notes
        {
            get
            {
                if (_notes == null && this.NotesId != null)
                    _notes = this.Provider.Common.Notes.FetchById(this.NotesId);
                if (_notes == null)
                    _notes = this.Provider.Common.Notes.Create();
                
                return _notes;
            }
        }

        /// <summary>
        ///     Gets or sets the unique code for the value of the "COURSE_NOTES" field.
        /// </summary>
        public String NotesId
        {
            get { return this.ModifiedData.Notes; }
            set
            {
                if (this.ModifiedData.Notes != value)
                     _notes = null;
                this.ModifiedData.Notes = value;
            }
        }

        /// <summary>
        ///     Gets or sets the value of the "COURSE_BOOK_ACTUAL" field.
        /// </summary>
        public Double? BookActual
        {
            get { return this.ModifiedData.BookActual; }
            set { this.ModifiedData.BookActual = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "COURSE_ACTUAL_TOT" field.
        /// </summary>
        public Double? ActualCost
        {
            get { return this.ModifiedData.ActualTot; }
            set { this.ModifiedData.ActualTot = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "COURSE_DO_NOT_INVC" field.
        /// </summary>
        public Byte? DoNotInvoice
        {
            get { return this.ModifiedData.DoNotInvc; }
            set { this.ModifiedData.DoNotInvc = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "COURSE_CANCEL_DATE" field.
        /// </summary>
        public DateTime? CancelDate
        {
            get { return this.ModifiedData.CancelDate; }
            set { this.ModifiedData.CancelDate = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "COURSE_CANCEL_BY" field.
        /// </summary>
        public String CancelBy
        {
            get { return this.ModifiedData.CancelBy; }
            set { this.ModifiedData.CancelBy = value; }
        }

        /// <summary>
        ///     Gets the The value of the "COURSE_SUPPLIER_ID" field.
        /// </summary>
        public LocalOrganisationModel Commissioned
        {
            get
            {
                if (_commissioned == null && this.CommissionedId != null)
                    _commissioned = this.Provider.Contact.Organisation.FetchById(this.CommissionedId);
                if (_commissioned == null)
                    _commissioned = this.Provider.Contact.Organisation.Create();
                
                return _commissioned;
            }
        }

        /// <summary>
        ///     Gets or sets the unique code for the value of the "COURSE_SUPPLIER_ID" field.
        /// </summary>
        public String CommissionedId
        {
            get { return this.ModifiedData.SupplierId; }
            set
            {
                if (this.ModifiedData.SupplierId != value)
                     _commissioned = null;
                this.ModifiedData.SupplierId = value;
            }
        }

        /// <summary>
        ///     Gets the The value of the "COURSE_OPP_ID" field.
        /// </summary>
        public LocalOpportunityModel Opportunity
        {
            get
            {
                if (_opportunity == null && this.OpportunityId != null)
                    _opportunity = this.Provider.Sales.Opportunity.FetchById(this.OpportunityId);
                if (_opportunity == null)
                    _opportunity = this.Provider.Sales.Opportunity.Create();
                
                return _opportunity;
            }
        }

        /// <summary>
        ///     Gets or sets the unique code for the value of the "COURSE_OPP_ID" field.
        /// </summary>
        public String OpportunityId
        {
            get { return this.ModifiedData.OppId; }
            set
            {
                if (this.ModifiedData.OppId != value)
                     _opportunity = null;
                this.ModifiedData.OppId = value;
            }
        }

        /// <summary>
        ///     Gets or sets the value of the "COURSE_PRIVATE" field.
        /// </summary>
        public Byte? Private
        {
            get { return this.ModifiedData.Private; }
            set { this.ModifiedData.Private = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "COURSE_WEB" field.
        /// </summary>
        public Byte? Web
        {
            get { return this.ModifiedData.Web; }
            set { this.ModifiedData.Web = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "COURSE_URL" field.
        /// </summary>
        public String Url
        {
            get { return this.ModifiedData.Url; }
            set { this.ModifiedData.Url = value; }
        }

        /// <summary>
        ///     Gets the The value of the "COURSE_ADD_ID" field.
        /// </summary>
        public LocalAddressModel Address
        {
            get
            {
                if (_address == null && this.AddressId != null)
                    _address = this.Provider.Contact.Address.FetchById(this.AddressId);
                if (_address == null)
                    _address = this.Provider.Contact.Address.Create();
                
                return _address;
            }
        }

        /// <summary>
        ///     Gets or sets the unique code for the value of the "COURSE_ADD_ID" field.
        /// </summary>
        public String AddressId
        {
            get { return this.ModifiedData.AddId; }
            set
            {
                if (this.ModifiedData.AddId != value)
                     _address = null;
                this.ModifiedData.AddId = value;
            }
        }

        /// <summary>
        ///     Gets the The value of the "COURSE_SUP_ROLE_ID" field.
        /// </summary>
        public LocalRoleModel CommissionedRole
        {
            get
            {
                if (_commissionedRole == null && this.CommissionedRoleId != null)
                    _commissionedRole = this.Provider.Contact.Role.FetchById(this.CommissionedRoleId);
                if (_commissionedRole == null)
                    _commissionedRole = this.Provider.Contact.Role.Create();
                
                return _commissionedRole;
            }
        }

        /// <summary>
        ///     Gets or sets the unique code for the value of the "COURSE_SUP_ROLE_ID" field.
        /// </summary>
        public String CommissionedRoleId
        {
            get { return this.ModifiedData.SupRoleId; }
            set
            {
                if (this.ModifiedData.SupRoleId != value)
                     _commissionedRole = null;
                this.ModifiedData.SupRoleId = value;
            }
        }

        /// <summary>
        ///     Gets or sets the value of the "COURSE_CURRENCY" field.
        /// </summary>
        public String Currency
        {
            get { return this.ModifiedData.Currency; }
            set { this.ModifiedData.Currency = value; }
        }

        /// <summary>
        ///     Gets the The value of the "COURSE_SELCO_SP_ID" field.
        /// </summary>
        public LocalSellingCompanyModel SellingCompany
        {
            get
            {
                if (_sellingCompany == null && this.SellingCompanyId != null)
                    _sellingCompany = this.Provider.Common.SellingCompany.FetchById(this.SellingCompanyId);
                if (_sellingCompany == null)
                    _sellingCompany = this.Provider.Common.SellingCompany.Create();
                
                return _sellingCompany;
            }
        }

        /// <summary>
        ///     Gets or sets the unique code for the value of the "COURSE_SELCO_SP_ID" field.
        /// </summary>
        public String SellingCompanyId
        {
            get { return this.ModifiedData.SelcoSpId; }
            set
            {
                if (this.ModifiedData.SelcoSpId != value)
                     _sellingCompany = null;
                this.ModifiedData.SelcoSpId = value;
            }
        }

        /// <summary>
        ///     Gets the The value of the "COURSE_BKT_ID" field.
        /// </summary>
        public LocalBookingTermsModel BookingTerms
        {
            get
            {
                if (_bookingTerms == null && this.BookingTermsId != null)
                    _bookingTerms = this.Provider.Finance.BookingTerms.FetchById(this.BookingTermsId);
                if (_bookingTerms == null)
                    _bookingTerms = this.Provider.Finance.BookingTerms.Create();
                
                return _bookingTerms;
            }
        }

        /// <summary>
        ///     Gets or sets the unique code for the value of the "COURSE_BKT_ID" field.
        /// </summary>
        public String BookingTermsId
        {
            get { return this.ModifiedData.BktId; }
            set
            {
                if (this.ModifiedData.BktId != value)
                     _bookingTerms = null;
                this.ModifiedData.BktId = value;
            }
        }

        /// <summary>
        ///     Gets the The value of the "COURSE_CONTPROL_ID" field.
        /// </summary>
        public LocalRoleModel Contact
        {
            get
            {
                if (_contact == null && this.ContactId != null)
                    _contact = this.Provider.Contact.Role.FetchById(this.ContactId);
                if (_contact == null)
                    _contact = this.Provider.Contact.Role.Create();
                
                return _contact;
            }
        }

        /// <summary>
        ///     Gets or sets the unique code for the value of the "COURSE_CONTPROL_ID" field.
        /// </summary>
        public String ContactId
        {
            get { return this.ModifiedData.ContprolId; }
            set
            {
                if (this.ModifiedData.ContprolId != value)
                     _contact = null;
                this.ModifiedData.ContprolId = value;
            }
        }

        /// <summary>
        ///     Gets the The value of the "COURSE_SUP_STATUS" field.
        /// </summary>
        public LocalCodeModel SupplierStatus
        {
            get
            {
                if (_supplierStatus == null && !String.IsNullOrEmpty(this.SupplierStatusCode))
                    _supplierStatus = this.Provider.Common.Code.FetchByTypeAndCode("SPST", this.SupplierStatusCode);
                if (_supplierStatus == null)
                    _supplierStatus = this.Provider.Common.Code.Create("SPST");
                return _supplierStatus;
            }
        }

        /// <summary>
        ///     Gets or sets the unique code for the value of the "COURSE_SUP_STATUS" field.
        /// </summary>
        public String SupplierStatusCode
        {
            get { return this.ModifiedData.SupStatus; }
            set
            {
                if (this.ModifiedData.SupStatus != value)
                     _supplierStatus = null;
                this.ModifiedData.SupStatus = value;
            }
        }

        /// <summary>
        ///     Gets or sets the value of the "COURSE_OVERBOOK" field.
        /// </summary>
        public Byte? AllowOverbook
        {
            get { return this.ModifiedData.Overbook; }
            set { this.ModifiedData.Overbook = value; }
        }

        /// <summary>
        ///     Gets the The value of the "COURSE_PROV_ORG_ID" field.
        /// </summary>
        public LocalOrganisationModel SupplierOrg
        {
            get
            {
                if (_supplierOrg == null && this.SupplierOrgId != null)
                    _supplierOrg = this.Provider.Contact.Organisation.FetchById(this.SupplierOrgId);
                if (_supplierOrg == null)
                    _supplierOrg = this.Provider.Contact.Organisation.Create();
                
                return _supplierOrg;
            }
        }

        /// <summary>
        ///     Gets or sets the unique code for the value of the "COURSE_PROV_ORG_ID" field.
        /// </summary>
        public String SupplierOrgId
        {
            get { return this.ModifiedData.ProvOrgId; }
            set
            {
                if (this.ModifiedData.ProvOrgId != value)
                     _supplierOrg = null;
                this.ModifiedData.ProvOrgId = value;
            }
        }

        /// <summary>
        ///     Gets the The value of the "COURSE_PROV_PROLE_ID" field.
        /// </summary>
        public LocalRoleModel SupplierRole
        {
            get
            {
                if (_supplierRole == null && this.SupplierRoleId != null)
                    _supplierRole = this.Provider.Contact.Role.FetchById(this.SupplierRoleId);
                if (_supplierRole == null)
                    _supplierRole = this.Provider.Contact.Role.Create();
                
                return _supplierRole;
            }
        }

        /// <summary>
        ///     Gets or sets the unique code for the value of the "COURSE_PROV_PROLE_ID" field.
        /// </summary>
        public String SupplierRoleId
        {
            get { return this.ModifiedData.ProvProleId; }
            set
            {
                if (this.ModifiedData.ProvProleId != value)
                     _supplierRole = null;
                this.ModifiedData.ProvProleId = value;
            }
        }

        /// <summary>
        ///     Gets or sets the value of the "COURSE_FUNDED" field.
        /// </summary>
        public Byte? Funded
        {
            get { return this.ModifiedData.Funded; }
            set { this.ModifiedData.Funded = value; }
        }

        /// <summary>
        ///     Gets the The value of the "COURSE_FUNDED_ORG_ID" field.
        /// </summary>
        public LocalOrganisationModel FundingOrganisation
        {
            get
            {
                if (_fundingOrganisation == null && this.FundingOrganisationId != null)
                    _fundingOrganisation = this.Provider.Contact.Organisation.FetchById(this.FundingOrganisationId);
                if (_fundingOrganisation == null)
                    _fundingOrganisation = this.Provider.Contact.Organisation.Create();
                
                return _fundingOrganisation;
            }
        }

        /// <summary>
        ///     Gets or sets the unique code for the value of the "COURSE_FUNDED_ORG_ID" field.
        /// </summary>
        public String FundingOrganisationId
        {
            get { return this.ModifiedData.FundedOrgId; }
            set
            {
                if (this.ModifiedData.FundedOrgId != value)
                     _fundingOrganisation = null;
                this.ModifiedData.FundedOrgId = value;
            }
        }

        /// <summary>
        ///     Gets or sets the value of the "COURSE_RESERVATIONS" field.
        /// </summary>
        public Int32 ReservedPlaces
        {
            get { return this.ModifiedData.Reservations; }
            set { this.ModifiedData.Reservations = value; }
        }

        /// <summary>
        ///     Gets the The value of the "COURSE_DEF_ELEM_ST" field.
        /// </summary>
        public LocalCodeModel DefaultDelegateStatus
        {
            get
            {
                if (_defaultDelegateStatus == null && !String.IsNullOrEmpty(this.DefaultDelegateStatusCode))
                    _defaultDelegateStatus = this.Provider.Common.Code.FetchByTypeAndCode("CDES", this.DefaultDelegateStatusCode);
                if (_defaultDelegateStatus == null)
                    _defaultDelegateStatus = this.Provider.Common.Code.Create("CDES");
                return _defaultDelegateStatus;
            }
        }

        /// <summary>
        ///     Gets or sets the unique code for the value of the "COURSE_DEF_ELEM_ST" field.
        /// </summary>
        public String DefaultDelegateStatusCode
        {
            get { return this.ModifiedData.DefElemSt; }
            set
            {
                if (this.ModifiedData.DefElemSt != value)
                     _defaultDelegateStatus = null;
                this.ModifiedData.DefElemSt = value;
            }
        }

        /// <summary>
        ///     Gets or sets the value of the "COURSE_LAPSED" field.
        /// </summary>
        public Int32 LapsedPlaces
        {
            get { return this.ModifiedData.Lapsed; }
            set { this.ModifiedData.Lapsed = value; }
        }

        /// <summary>
        ///     Gets the The value of the "COURSE_INT_NOTES" field.
        /// </summary>
        public LocalNotesModel IntNotes
        {
            get
            {
                if (_intNotes == null && this.IntNotesId != null)
                    _intNotes = this.Provider.Common.Notes.FetchById(this.IntNotesId);
                if (_intNotes == null)
                    _intNotes = this.Provider.Common.Notes.Create();
                
                return _intNotes;
            }
        }

        /// <summary>
        ///     Gets or sets the unique code for the value of the "COURSE_INT_NOTES" field.
        /// </summary>
        public String IntNotesId
        {
            get { return this.ModifiedData.IntNotes; }
            set
            {
                if (this.ModifiedData.IntNotes != value)
                     _intNotes = null;
                this.ModifiedData.IntNotes = value;
            }
        }

        /// <summary>
        ///     Gets or sets the value of the "COURSE_CANCELLATION_DATE" field.
        /// </summary>
        public DateTime? CancellationDate
        {
            get { return this.ModifiedData.CancellationDate; }
            set { this.ModifiedData.CancellationDate = value; }
        }

        /// <summary>
        ///     Gets the The value of the "COURSE_REASON" field.
        /// </summary>
        public LocalCodeModel CancellationReason
        {
            get
            {
                if (_cancellationReason == null && !String.IsNullOrEmpty(this.CancellationReasonCode))
                    _cancellationReason = this.Provider.Common.Code.FetchByTypeAndCode("CNCRS", this.CancellationReasonCode);
                if (_cancellationReason == null)
                    _cancellationReason = this.Provider.Common.Code.Create("CNCRS");
                return _cancellationReason;
            }
        }

        /// <summary>
        ///     Gets or sets the unique code for the value of the "COURSE_REASON" field.
        /// </summary>
        public String CancellationReasonCode
        {
            get { return this.ModifiedData.Reason; }
            set
            {
                if (this.ModifiedData.Reason != value)
                     _cancellationReason = null;
                this.ModifiedData.Reason = value;
            }
        }

        /// <summary>
        ///     Gets or sets the value of the "COURSE_UNRECOVERABLE_CANC_LOSS" field.
        /// </summary>
        public Decimal? UnrecoverableCancelationLoss
        {
            get { return this.ModifiedData.UnrecoverableCancLoss; }
            set { this.ModifiedData.UnrecoverableCancLoss = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "COURSE_EXT_COURSEWARE" field.
        /// </summary>
        public Byte? RequiresExternalCourseware
        {
            get { return this.ModifiedData.ExtCourseware; }
            set { this.ModifiedData.ExtCourseware = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "COURSE_CONTINGENCY" field.
        /// </summary>
        public Int32? Contingency
        {
            get { return this.ModifiedData.Contingency; }
            set { this.ModifiedData.Contingency = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "COURSE_COST" field.
        /// </summary>
        public Decimal? Cost
        {
            get { return this.ModifiedData.Cost; }
            set { this.ModifiedData.Cost = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "COURSE_DELIVERY_DAYS" field.
        /// </summary>
        public Int32? DeliveryDays
        {
            get { return this.ModifiedData.DeliveryDays; }
            set { this.ModifiedData.DeliveryDays = value; }
        }

        /// <summary>
        ///     Gets the The value of the "COURSE_MTR_PROLE_ID" field.
        /// </summary>
        public LocalRoleModel MainTrainer
        {
            get
            {
                if (_mainTrainer == null && this.MainTrainerId != null)
                    _mainTrainer = this.Provider.Contact.Role.FetchById(this.MainTrainerId);
                if (_mainTrainer == null)
                    _mainTrainer = this.Provider.Contact.Role.Create();
                
                return _mainTrainer;
            }
        }

        /// <summary>
        ///     Gets or sets the unique code for the value of the "COURSE_MTR_PROLE_ID" field.
        /// </summary>
        public String MainTrainerId
        {
            get { return this.ModifiedData.MtrProleId; }
            set
            {
                if (this.ModifiedData.MtrProleId != value)
                     _mainTrainer = null;
                this.ModifiedData.MtrProleId = value;
            }
        }

        /// <summary>
        ///     Gets the The value of the "COURSE_ACADY_CODE" field.
        /// </summary>
        public LocalCodeModel AcademicYear
        {
            get
            {
                if (_academicYear == null && !String.IsNullOrEmpty(this.AcademicYearCode))
                    _academicYear = this.Provider.Common.Code.FetchByTypeAndCode("ACADY", this.AcademicYearCode);
                if (_academicYear == null)
                    _academicYear = this.Provider.Common.Code.Create("ACADY");
                return _academicYear;
            }
        }

        /// <summary>
        ///     Gets or sets the unique code for the value of the "COURSE_ACADY_CODE" field.
        /// </summary>
        public String AcademicYearCode
        {
            get { return this.ModifiedData.AcadyCode; }
            set
            {
                if (this.ModifiedData.AcadyCode != value)
                     _academicYear = null;
                this.ModifiedData.AcadyCode = value;
            }
        }

        /// <summary>
        ///     Gets or sets the value of the "COURSE_USERMULTI_1" field.
        /// </summary>
        public String Usermulti1
        {
            get { return this.ModifiedData.Usermulti1; }
            set { this.ModifiedData.Usermulti1 = value; }
        }

        /// <summary>
        ///     Gets the The value of the "COURSE_PSH_ID" field.
        /// </summary>
        public LocalPayscheduleheaderModel PayScheduleHeader
        {
            get
            {
                if (_payScheduleHeader == null && this.PayScheduleHeaderId != null)
                    _payScheduleHeader = this.Provider.Finance.Payscheduleheader.FetchById(this.PayScheduleHeaderId.Value);
                if (_payScheduleHeader == null)
                    _payScheduleHeader = this.Provider.Finance.Payscheduleheader.Create();
                
                return _payScheduleHeader;
            }
        }

        /// <summary>
        ///     Gets or sets the unique code for the value of the "COURSE_PSH_ID" field.
        /// </summary>
        public Int32? PayScheduleHeaderId
        {
            get { return this.ModifiedData.PshId; }
            set
            {
                if (this.ModifiedData.PshId != value)
                     _payScheduleHeader = null;
                this.ModifiedData.PshId = value;
            }
        }

        /// <summary>
        ///     Gets or sets the value of the "COURSE_BLOCK_TYPE" field.
        /// </summary>
        public Byte? BlockType
        {
            get { return this.ModifiedData.BlockType; }
            set { this.ModifiedData.BlockType = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "COURSE_AVAIL" field.
        /// </summary>
        public String Avail
        {
            get { return this.ModifiedData.Avail; }
            set { this.ModifiedData.Avail = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "COURSE_FIRST_LIC_EVENT" field.
        /// </summary>
        public Byte? FirstLicencedEvent
        {
            get { return this.ModifiedData.FirstLicEvent; }
            set { this.ModifiedData.FirstLicEvent = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "COURSE_LICENSED" field.
        /// </summary>
        public Byte Licensed
        {
            get { return this.ModifiedData.Licensed; }
            set { this.ModifiedData.Licensed = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "COURSE_PACK_BCC_EMAIL" field.
        /// </summary>
        public String PackBccEmail
        {
            get { return this.ModifiedData.PackBccEmail; }
            set { this.ModifiedData.PackBccEmail = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "COURSE_PACK_MDN_EMAIL" field.
        /// </summary>
        public String PackMdnEmail
        {
            get { return this.ModifiedData.PackMdnEmail; }
            set { this.ModifiedData.PackMdnEmail = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "COURSE_PACK_DSN_EMAIL" field.
        /// </summary>
        public String PackDsnEmail
        {
            get { return this.ModifiedData.PackDsnEmail; }
            set { this.ModifiedData.PackDsnEmail = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "COURSE_CLIENT_REF" field.
        /// </summary>
        public String ClientRef
        {
            get { return this.ModifiedData.ClientRef; }
            set { this.ModifiedData.ClientRef = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "COURSE_SESSIONS_DESCRIPTION" field.
        /// </summary>
        public String SessionsDescription
        {
            get { return this.ModifiedData.SessionsDescription; }
            set { this.ModifiedData.SessionsDescription = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "COURSE_SESSIONS_HEADER" field.
        /// </summary>
        public String SessionsHeader
        {
            get { return this.ModifiedData.SessionsHeader; }
            set { this.ModifiedData.SessionsHeader = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "COURSE_CUT_PRD_TIME" field.
        /// </summary>
        public Byte? CutPrdTime
        {
            get { return this.ModifiedData.CutPrdTime; }
            set { this.ModifiedData.CutPrdTime = value; }
        }

        /// <summary>
        ///     Gets the collection of <see cref="ElementModel" /> instances that reference this <see cref="EventModel" />.
        /// </summary>
        public LocalCollection<LocalElementModel, IElementModel> Elements
        {
            get
            {
                if (_elements == null)
                    _elements = new LocalCollection<LocalElementModel, IElementModel>(this.Provider.Learning.Element.FetchAllByCourseId(this.Id));
                
                return _elements;
            }
        }

        /// <summary>
        ///     Gets the collection of <see cref="SessionXrefModel" /> instances that reference this <see cref="EventModel" />.
        /// </summary>
        public LocalCollection<LocalSessionXrefModel, ISessionXrefModel> SessionXrefEvent
        {
            get
            {
                if (_sessionXrefEvent == null)
                    _sessionXrefEvent = new LocalCollection<LocalSessionXrefModel, ISessionXrefModel>(this.Provider.Learning.SessionXref.FetchAllByEventId(this.Id));
                
                return _sessionXrefEvent;
            }
        }

        /// <summary>
        ///     Gets the collection of <see cref="CourseSelectGroupsModel" /> instances that reference this <see cref="EventModel" />.
        /// </summary>
        public LocalCollection<LocalCourseSelectGroupsModel, ICourseSelectGroupsModel> SelectinGroupEvent
        {
            get
            {
                if (_selectinGroupEvent == null)
                    _selectinGroupEvent = new LocalCollection<LocalCourseSelectGroupsModel, ICourseSelectGroupsModel>(this.Provider.Learning.CourseSelectGroups.FetchAllByEventId(this.Id));
                
                return _selectinGroupEvent;
            }
        }

        /// <summary>
        ///     Gets the collection of <see cref="EventProductModel" /> instances that reference this <see cref="EventModel" />.
        /// </summary>
        public LocalCollection<LocalEventProductModel, IEventProductModel> EventEP
        {
            get
            {
                if (_eventEP == null)
                    _eventEP = new LocalCollection<LocalEventProductModel, IEventProductModel>(this.Provider.Learning.EventProduct.FetchAllByEventId(this.Id));
                
                return _eventEP;
            }
        }

        /// <summary>
        ///     Gets the collection of <see cref="OpportunityModel" /> instances that reference this <see cref="EventModel" />.
        /// </summary>
        public LocalCollection<LocalOpportunityModel, IOpportunityModel> OppEventId
        {
            get
            {
                if (_oppEventId == null)
                    _oppEventId = new LocalCollection<LocalOpportunityModel, IOpportunityModel>(this.Provider.Sales.Opportunity.FetchAllByCourseIdId(this.Id));
                
                return _oppEventId;
            }
        }

        /// <summary>
        ///     Gets the collection of <see cref="InvoiceLineModel" /> instances that reference this <see cref="EventModel" />.
        /// </summary>
        public LocalCollection<LocalInvoiceLineModel, IInvoiceLineModel> InvoiceLines
        {
            get
            {
                if (_invoiceLines == null)
                    _invoiceLines = new LocalCollection<LocalInvoiceLineModel, IInvoiceLineModel>(this.Provider.Finance.InvoiceLine.FetchAllByCourseIdId(this.Id));
                
                return _invoiceLines;
            }
        }

        /// <summary>
        ///     Gets the collection of <see cref="PromotionMasterModel" /> instances that reference this <see cref="EventModel" />.
        /// </summary>
        public LocalCollection<LocalPromotionMasterModel, IPromotionMasterModel> PromotionMasterEvent
        {
            get
            {
                if (_promotionMasterEvent == null)
                    _promotionMasterEvent = new LocalCollection<LocalPromotionMasterModel, IPromotionMasterModel>(this.Provider.Marketing.PromotionMaster.FetchAllByCourseIdId(this.Id));
                
                return _promotionMasterEvent;
            }
        }

        /// <summary>
        ///     Gets the collection of <see cref="SaqQueryModel" /> instances that reference this <see cref="EventModel" />.
        /// </summary>
        public LocalCollection<LocalSaqQueryModel, ISaqQueryModel> SaqQueryEvent
        {
            get
            {
                if (_saqQueryEvent == null)
                    _saqQueryEvent = new LocalCollection<LocalSaqQueryModel, ISaqQueryModel>(this.Provider.Marketing.SaqQuery.FetchAllByEventId(this.Id));
                
                return _saqQueryEvent;
            }
        }

        #endregion

        #region constructors

        /// <summary>
        ///     Initialises a new <see cref="LocalEventModel" /> instance.
        /// </summary>
        /// <param name="provider">
        ///     The business provider to which the business model is bound.
        /// </param>
        internal LocalEventModel(LocalProvider provider) : base(provider)
        {
        }

        /// <summary>
        ///     Initialises a new <see cref="LocalEventModel" /> instance.
        /// </summary>
        /// <param name="provider">
        ///     The business provider to which the business model is bound.
        /// </param>
        /// <param name="record">
        ///     The data record which is encapsulated by the business model.
        /// </param>
        internal LocalEventModel(LocalProvider provider, CourseRecord record) : base(provider, record)
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
            if (_type != null)
            {
                _type.Save();
                this.ModifiedData.Type = _type.Value1;
            }
            if (_status != null)
            {
                _status.Save();
                this.ModifiedData.Status = _status.Value1;
            }
            if (_rev != null)
            {
                _rev.Save();
                this.ModifiedData.RevCode = _rev.Value1;
            }
            if (_supplierStatus != null)
            {
                _supplierStatus.Save();
                this.ModifiedData.SupStatus = _supplierStatus.Value1;
            }
            if (_defaultDelegateStatus != null)
            {
                _defaultDelegateStatus.Save();
                this.ModifiedData.DefElemSt = _defaultDelegateStatus.Value1;
            }
            if (_cancellationReason != null)
            {
                _cancellationReason.Save();
                this.ModifiedData.Reason = _cancellationReason.Value1;
            }
            if (_academicYear != null)
            {
                _academicYear.Save();
                this.ModifiedData.AcadyCode = _academicYear.Value1;
            }
            if (_manager != null)
            {
                _manager.Save();
                this.ModifiedData.PersonId = _manager.Id == null && this.ModifiedData.PersonId != null ? "" : _manager.Id;
            }
            if (_product != null)
            {
                _product.Save();
                this.ModifiedData.ProductId = _product.Id == null && this.ModifiedData.ProductId != null ? "" : _product.Id;
            }
            if (_location != null)
            {
                _location.Save();
                this.ModifiedData.LocId = _location.Id == null && this.ModifiedData.LocId != null ? "" : _location.Id;
            }
            if (_organisation != null)
            {
                _organisation.Save();
                this.ModifiedData.OrgId = _organisation.Id == null && this.ModifiedData.OrgId != null ? "" : _organisation.Id;
            }
            if (_notes != null)
            {
                _notes.Save();
                this.ModifiedData.Notes = _notes.Id == null && this.ModifiedData.Notes != null ? "" : _notes.Id;
            }
            if (_commissioned != null)
            {
                _commissioned.Save();
                this.ModifiedData.SupplierId = _commissioned.Id == null && this.ModifiedData.SupplierId != null ? "" : _commissioned.Id;
            }
            if (_opportunity != null)
            {
                _opportunity.Save();
                this.ModifiedData.OppId = _opportunity.Id == null && this.ModifiedData.OppId != null ? "" : _opportunity.Id;
            }
            if (_address != null)
            {
                _address.Save();
                this.ModifiedData.AddId = _address.Id == null && this.ModifiedData.AddId != null ? "" : _address.Id;
            }
            if (_commissionedRole != null)
            {
                _commissionedRole.Save();
                this.ModifiedData.SupRoleId = _commissionedRole.Id == null && this.ModifiedData.SupRoleId != null ? "" : _commissionedRole.Id;
            }
            if (_sellingCompany != null)
            {
                _sellingCompany.Save();
                this.ModifiedData.SelcoSpId = _sellingCompany.Id == null && this.ModifiedData.SelcoSpId != null ? "" : _sellingCompany.Id;
            }
            if (_bookingTerms != null)
            {
                _bookingTerms.Save();
                this.ModifiedData.BktId = _bookingTerms.Id == null && this.ModifiedData.BktId != null ? "" : _bookingTerms.Id;
            }
            if (_contact != null)
            {
                _contact.Save();
                this.ModifiedData.ContprolId = _contact.Id == null && this.ModifiedData.ContprolId != null ? "" : _contact.Id;
            }
            if (_supplierOrg != null)
            {
                _supplierOrg.Save();
                this.ModifiedData.ProvOrgId = _supplierOrg.Id == null && this.ModifiedData.ProvOrgId != null ? "" : _supplierOrg.Id;
            }
            if (_supplierRole != null)
            {
                _supplierRole.Save();
                this.ModifiedData.ProvProleId = _supplierRole.Id == null && this.ModifiedData.ProvProleId != null ? "" : _supplierRole.Id;
            }
            if (_fundingOrganisation != null)
            {
                _fundingOrganisation.Save();
                this.ModifiedData.FundedOrgId = _fundingOrganisation.Id == null && this.ModifiedData.FundedOrgId != null ? "" : _fundingOrganisation.Id;
            }
            if (_intNotes != null)
            {
                _intNotes.Save();
                this.ModifiedData.IntNotes = _intNotes.Id == null && this.ModifiedData.IntNotes != null ? "" : _intNotes.Id;
            }
            if (_mainTrainer != null)
            {
                _mainTrainer.Save();
                this.ModifiedData.MtrProleId = _mainTrainer.Id == null && this.ModifiedData.MtrProleId != null ? "" : _mainTrainer.Id;
            }
            if (_payScheduleHeader != null)
            {
                _payScheduleHeader.Save();
                this.ModifiedData.PshId = _payScheduleHeader.Id;
            }
        }

        /// <summary>
        ///     Resolves the dependent models by means of updating all models that reference this model.
        /// </summary>
        protected override void ResolveGeneratedDependent()
        {
            base.ResolveGeneratedDependent();
            if (_elements != null)
                _elements.Execute(obj => obj.CourseId = this.Id).Execute(obj => obj.Save());
            if (_sessionXrefEvent != null)
                _sessionXrefEvent.Execute(obj => obj.EventId = this.Id).Execute(obj => obj.Save());
            if (_selectinGroupEvent != null)
                _selectinGroupEvent.Execute(obj => obj.EventId = this.Id).Execute(obj => obj.Save());
            if (_eventEP != null)
                _eventEP.Execute(obj => obj.EventId = this.Id).Execute(obj => obj.Save());
            if (_oppEventId != null)
                _oppEventId.Execute(obj => obj.CourseIdId = this.Id).Execute(obj => obj.Save());
            if (_invoiceLines != null)
                _invoiceLines.Execute(obj => obj.CourseIdId = this.Id).Execute(obj => obj.Save());
            if (_promotionMasterEvent != null)
                _promotionMasterEvent.Execute(obj => obj.CourseIdId = this.Id).Execute(obj => obj.Save());
            if (_saqQueryEvent != null)
                _saqQueryEvent.Execute(obj => obj.EventId = this.Id).Execute(obj => obj.Save());
        }

        #endregion

        #region implementations

        /// <summary>
        ///     Gets or sets the main session.
        /// </summary>
        Consensus.Learning.ISessionModel IEventModel.MainSession
        {
            get { return this.MainSession; }
        }

        /// <summary>
        ///     Gets the The value of the "COURSE_PERSON_ID" field.
        /// </summary>
        Consensus.Contact.IPersonModel IEventModel.Manager
        {
            get { return this.Manager; }
        }

        /// <summary>
        ///     Gets or sets the unique code for the value of the "COURSE_PERSON_ID" field.
        /// </summary>
        System.String IEventModel.ManagerId
        {
            get { return this.ManagerId; }
            set { this.ManagerId = (System.String)value; }
        }

        /// <summary>
        ///     Gets the The value of the "COURSE_PRODUCT_ID" field.
        /// </summary>
        Consensus.Learning.IProductModel IEventModel.Product
        {
            get { return this.Product; }
        }

        /// <summary>
        ///     Gets or sets the unique code for the value of the "COURSE_PRODUCT_ID" field.
        /// </summary>
        System.String IEventModel.ProductId
        {
            get { return this.ProductId; }
            set { this.ProductId = (System.String)value; }
        }

        /// <summary>
        ///     Gets the The value of the "COURSE_LOC_ID" field.
        /// </summary>
        Consensus.Contact.ILocationModel IEventModel.Location
        {
            get { return this.Location; }
        }

        /// <summary>
        ///     Gets or sets the unique code for the value of the "COURSE_LOC_ID" field.
        /// </summary>
        System.String IEventModel.LocationId
        {
            get { return this.LocationId; }
            set { this.LocationId = (System.String)value; }
        }

        /// <summary>
        ///     Gets the The value of the "COURSE_ORG_ID" field.
        /// </summary>
        Consensus.Contact.IOrganisationModel IEventModel.Organisation
        {
            get { return this.Organisation; }
        }

        /// <summary>
        ///     Gets or sets the unique code for the value of the "COURSE_ORG_ID" field.
        /// </summary>
        System.String IEventModel.OrganisationId
        {
            get { return this.OrganisationId; }
            set { this.OrganisationId = (System.String)value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "COURSE_REF" field.
        /// </summary>
        System.String IEventModel.Ref
        {
            get { return this.Ref; }
            set { this.Ref = (System.String)value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "COURSE_NAME" field.
        /// </summary>
        System.String IEventModel.Name
        {
            get { return this.Name; }
            set { this.Name = (System.String)value; }
        }

        /// <summary>
        ///     Gets the The value of the "COURSE_TYPE" field.
        /// </summary>
        Consensus.Common.ICodeModel IEventModel.Type
        {
            get { return this.Type; }
        }

        /// <summary>
        ///     Gets or sets the unique code for the value of the "COURSE_TYPE" field.
        /// </summary>
        System.String IEventModel.TypeCode
        {
            get { return this.TypeCode; }
            set { this.TypeCode = (System.String)value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "COURSE_BLOCK_PRICD" field.
        /// </summary>
        System.Nullable<System.Byte> IEventModel.Pricing
        {
            get { return this.Pricing; }
            set { this.Pricing = (System.Nullable<System.Byte>)value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "COURSE_START_DATE" field.
        /// </summary>
        System.Nullable<System.DateTime> IEventModel.StartDate
        {
            get { return this.StartDate; }
            set { this.StartDate = (System.Nullable<System.DateTime>)value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "COURSE_END_DATE" field.
        /// </summary>
        System.Nullable<System.DateTime> IEventModel.EndDate
        {
            get { return this.EndDate; }
            set { this.EndDate = (System.Nullable<System.DateTime>)value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "COURSE_START_TIME" field.
        /// </summary>
        System.Nullable<System.DateTime> IEventModel.StartTime
        {
            get { return this.StartTime; }
            set { this.StartTime = (System.Nullable<System.DateTime>)value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "COURSE_END_TIME" field.
        /// </summary>
        System.Nullable<System.DateTime> IEventModel.EndTime
        {
            get { return this.EndTime; }
            set { this.EndTime = (System.Nullable<System.DateTime>)value; }
        }

        /// <summary>
        ///     Gets the The value of the "COURSE_STATUS" field.
        /// </summary>
        Consensus.Common.ICodeModel IEventModel.Status
        {
            get { return this.Status; }
        }

        /// <summary>
        ///     Gets or sets the unique code for the value of the "COURSE_STATUS" field.
        /// </summary>
        System.String IEventModel.StatusCode
        {
            get { return this.StatusCode; }
            set { this.StatusCode = (System.String)value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "COURSE_LENGTH" field.
        /// </summary>
        System.Nullable<System.Double> IEventModel.Length
        {
            get { return this.Length; }
            set { this.Length = (System.Nullable<System.Double>)value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "COURSE_MIN_PLACES" field.
        /// </summary>
        System.Nullable<System.Double> IEventModel.MinPlaces
        {
            get { return this.MinPlaces; }
            set { this.MinPlaces = (System.Nullable<System.Double>)value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "COURSE_MAX_PLACES" field.
        /// </summary>
        System.Nullable<System.Double> IEventModel.MaxPlaces
        {
            get { return this.MaxPlaces; }
            set { this.MaxPlaces = (System.Nullable<System.Double>)value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "COURSE_FREE_PLACES" field.
        /// </summary>
        System.Nullable<System.Double> IEventModel.FreePlaces
        {
            get { return this.FreePlaces; }
            set { this.FreePlaces = (System.Nullable<System.Double>)value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "COURSE_CONF_PLACES" field.
        /// </summary>
        System.Nullable<System.Double> IEventModel.ConfirmedPlaces
        {
            get { return this.ConfirmedPlaces; }
            set { this.ConfirmedPlaces = (System.Nullable<System.Double>)value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "COURSE_PROVIS_BKGS" field.
        /// </summary>
        System.Nullable<System.Double> IEventModel.ProvisionalPlaces
        {
            get { return this.ProvisionalPlaces; }
            set { this.ProvisionalPlaces = (System.Nullable<System.Double>)value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "COURSE_RESV_PLACES" field.
        /// </summary>
        System.Nullable<System.Double> IEventModel.WaitlistPlaces
        {
            get { return this.WaitlistPlaces; }
            set { this.WaitlistPlaces = (System.Nullable<System.Double>)value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "COURSE_CANCELS" field.
        /// </summary>
        System.Nullable<System.Double> IEventModel.CancelledPlaces
        {
            get { return this.CancelledPlaces; }
            set { this.CancelledPlaces = (System.Nullable<System.Double>)value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "COURSE_BLOCK_PRICE" field.
        /// </summary>
        System.Nullable<System.Double> IEventModel.BlockPrice
        {
            get { return this.BlockPrice; }
            set { this.BlockPrice = (System.Nullable<System.Double>)value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "COURSE_STUDT_PRICE" field.
        /// </summary>
        System.Nullable<System.Double> IEventModel.UnitPrice
        {
            get { return this.UnitPrice; }
            set { this.UnitPrice = (System.Nullable<System.Double>)value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "COURSE_COST_CODE" field.
        /// </summary>
        System.String IEventModel.CostCode
        {
            get { return this.CostCode; }
            set { this.CostCode = (System.String)value; }
        }

        /// <summary>
        ///     Gets the The value of the "COURSE_REV_CODE" field.
        /// </summary>
        Consensus.Common.ICodeModel IEventModel.Rev
        {
            get { return this.Rev; }
        }

        /// <summary>
        ///     Gets or sets the unique code for the value of the "COURSE_REV_CODE" field.
        /// </summary>
        System.String IEventModel.RevCode
        {
            get { return this.RevCode; }
            set { this.RevCode = (System.String)value; }
        }

        /// <summary>
        ///     Gets the The value of the "COURSE_NOTES" field.
        /// </summary>
        Consensus.Common.INotesModel IEventModel.Notes
        {
            get { return this.Notes; }
        }

        /// <summary>
        ///     Gets or sets the unique code for the value of the "COURSE_NOTES" field.
        /// </summary>
        System.String IEventModel.NotesId
        {
            get { return this.NotesId; }
            set { this.NotesId = (System.String)value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "COURSE_BOOK_ACTUAL" field.
        /// </summary>
        System.Nullable<System.Double> IEventModel.BookActual
        {
            get { return this.BookActual; }
            set { this.BookActual = (System.Nullable<System.Double>)value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "COURSE_ACTUAL_TOT" field.
        /// </summary>
        System.Nullable<System.Double> IEventModel.ActualCost
        {
            get { return this.ActualCost; }
            set { this.ActualCost = (System.Nullable<System.Double>)value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "COURSE_DO_NOT_INVC" field.
        /// </summary>
        System.Nullable<System.Byte> IEventModel.DoNotInvoice
        {
            get { return this.DoNotInvoice; }
            set { this.DoNotInvoice = (System.Nullable<System.Byte>)value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "COURSE_CANCEL_DATE" field.
        /// </summary>
        System.Nullable<System.DateTime> IEventModel.CancelDate
        {
            get { return this.CancelDate; }
            set { this.CancelDate = (System.Nullable<System.DateTime>)value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "COURSE_CANCEL_BY" field.
        /// </summary>
        System.String IEventModel.CancelBy
        {
            get { return this.CancelBy; }
            set { this.CancelBy = (System.String)value; }
        }

        /// <summary>
        ///     Gets the The value of the "COURSE_SUPPLIER_ID" field.
        /// </summary>
        Consensus.Contact.IOrganisationModel IEventModel.Commissioned
        {
            get { return this.Commissioned; }
        }

        /// <summary>
        ///     Gets or sets the unique code for the value of the "COURSE_SUPPLIER_ID" field.
        /// </summary>
        System.String IEventModel.CommissionedId
        {
            get { return this.CommissionedId; }
            set { this.CommissionedId = (System.String)value; }
        }

        /// <summary>
        ///     Gets the The value of the "COURSE_OPP_ID" field.
        /// </summary>
        Consensus.Sales.IOpportunityModel IEventModel.Opportunity
        {
            get { return this.Opportunity; }
        }

        /// <summary>
        ///     Gets or sets the unique code for the value of the "COURSE_OPP_ID" field.
        /// </summary>
        System.String IEventModel.OpportunityId
        {
            get { return this.OpportunityId; }
            set { this.OpportunityId = (System.String)value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "COURSE_PRIVATE" field.
        /// </summary>
        System.Nullable<System.Byte> IEventModel.Private
        {
            get { return this.Private; }
            set { this.Private = (System.Nullable<System.Byte>)value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "COURSE_WEB" field.
        /// </summary>
        System.Nullable<System.Byte> IEventModel.Web
        {
            get { return this.Web; }
            set { this.Web = (System.Nullable<System.Byte>)value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "COURSE_URL" field.
        /// </summary>
        System.String IEventModel.Url
        {
            get { return this.Url; }
            set { this.Url = (System.String)value; }
        }

        /// <summary>
        ///     Gets the The value of the "COURSE_ADD_ID" field.
        /// </summary>
        Consensus.Contact.IAddressModel IEventModel.Address
        {
            get { return this.Address; }
        }

        /// <summary>
        ///     Gets or sets the unique code for the value of the "COURSE_ADD_ID" field.
        /// </summary>
        System.String IEventModel.AddressId
        {
            get { return this.AddressId; }
            set { this.AddressId = (System.String)value; }
        }

        /// <summary>
        ///     Gets the The value of the "COURSE_SUP_ROLE_ID" field.
        /// </summary>
        Consensus.Contact.IRoleModel IEventModel.CommissionedRole
        {
            get { return this.CommissionedRole; }
        }

        /// <summary>
        ///     Gets or sets the unique code for the value of the "COURSE_SUP_ROLE_ID" field.
        /// </summary>
        System.String IEventModel.CommissionedRoleId
        {
            get { return this.CommissionedRoleId; }
            set { this.CommissionedRoleId = (System.String)value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "COURSE_CURRENCY" field.
        /// </summary>
        System.String IEventModel.Currency
        {
            get { return this.Currency; }
            set { this.Currency = (System.String)value; }
        }

        /// <summary>
        ///     Gets the The value of the "COURSE_SELCO_SP_ID" field.
        /// </summary>
        Consensus.Common.ISellingCompanyModel IEventModel.SellingCompany
        {
            get { return this.SellingCompany; }
        }

        /// <summary>
        ///     Gets or sets the unique code for the value of the "COURSE_SELCO_SP_ID" field.
        /// </summary>
        System.String IEventModel.SellingCompanyId
        {
            get { return this.SellingCompanyId; }
            set { this.SellingCompanyId = (System.String)value; }
        }

        /// <summary>
        ///     Gets the The value of the "COURSE_BKT_ID" field.
        /// </summary>
        Consensus.Finance.IBookingTermsModel IEventModel.BookingTerms
        {
            get { return this.BookingTerms; }
        }

        /// <summary>
        ///     Gets or sets the unique code for the value of the "COURSE_BKT_ID" field.
        /// </summary>
        System.String IEventModel.BookingTermsId
        {
            get { return this.BookingTermsId; }
            set { this.BookingTermsId = (System.String)value; }
        }

        /// <summary>
        ///     Gets the The value of the "COURSE_CONTPROL_ID" field.
        /// </summary>
        Consensus.Contact.IRoleModel IEventModel.Contact
        {
            get { return this.Contact; }
        }

        /// <summary>
        ///     Gets or sets the unique code for the value of the "COURSE_CONTPROL_ID" field.
        /// </summary>
        System.String IEventModel.ContactId
        {
            get { return this.ContactId; }
            set { this.ContactId = (System.String)value; }
        }

        /// <summary>
        ///     Gets the The value of the "COURSE_SUP_STATUS" field.
        /// </summary>
        Consensus.Common.ICodeModel IEventModel.SupplierStatus
        {
            get { return this.SupplierStatus; }
        }

        /// <summary>
        ///     Gets or sets the unique code for the value of the "COURSE_SUP_STATUS" field.
        /// </summary>
        System.String IEventModel.SupplierStatusCode
        {
            get { return this.SupplierStatusCode; }
            set { this.SupplierStatusCode = (System.String)value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "COURSE_OVERBOOK" field.
        /// </summary>
        System.Nullable<System.Byte> IEventModel.AllowOverbook
        {
            get { return this.AllowOverbook; }
            set { this.AllowOverbook = (System.Nullable<System.Byte>)value; }
        }

        /// <summary>
        ///     Gets the The value of the "COURSE_PROV_ORG_ID" field.
        /// </summary>
        Consensus.Contact.IOrganisationModel IEventModel.SupplierOrg
        {
            get { return this.SupplierOrg; }
        }

        /// <summary>
        ///     Gets or sets the unique code for the value of the "COURSE_PROV_ORG_ID" field.
        /// </summary>
        System.String IEventModel.SupplierOrgId
        {
            get { return this.SupplierOrgId; }
            set { this.SupplierOrgId = (System.String)value; }
        }

        /// <summary>
        ///     Gets the The value of the "COURSE_PROV_PROLE_ID" field.
        /// </summary>
        Consensus.Contact.IRoleModel IEventModel.SupplierRole
        {
            get { return this.SupplierRole; }
        }

        /// <summary>
        ///     Gets or sets the unique code for the value of the "COURSE_PROV_PROLE_ID" field.
        /// </summary>
        System.String IEventModel.SupplierRoleId
        {
            get { return this.SupplierRoleId; }
            set { this.SupplierRoleId = (System.String)value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "COURSE_FUNDED" field.
        /// </summary>
        System.Nullable<System.Byte> IEventModel.Funded
        {
            get { return this.Funded; }
            set { this.Funded = (System.Nullable<System.Byte>)value; }
        }

        /// <summary>
        ///     Gets the The value of the "COURSE_FUNDED_ORG_ID" field.
        /// </summary>
        Consensus.Contact.IOrganisationModel IEventModel.FundingOrganisation
        {
            get { return this.FundingOrganisation; }
        }

        /// <summary>
        ///     Gets or sets the unique code for the value of the "COURSE_FUNDED_ORG_ID" field.
        /// </summary>
        System.String IEventModel.FundingOrganisationId
        {
            get { return this.FundingOrganisationId; }
            set { this.FundingOrganisationId = (System.String)value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "COURSE_RESERVATIONS" field.
        /// </summary>
        System.Int32 IEventModel.ReservedPlaces
        {
            get { return this.ReservedPlaces; }
            set { this.ReservedPlaces = (System.Int32)value; }
        }

        /// <summary>
        ///     Gets the The value of the "COURSE_DEF_ELEM_ST" field.
        /// </summary>
        Consensus.Common.ICodeModel IEventModel.DefaultDelegateStatus
        {
            get { return this.DefaultDelegateStatus; }
        }

        /// <summary>
        ///     Gets or sets the unique code for the value of the "COURSE_DEF_ELEM_ST" field.
        /// </summary>
        System.String IEventModel.DefaultDelegateStatusCode
        {
            get { return this.DefaultDelegateStatusCode; }
            set { this.DefaultDelegateStatusCode = (System.String)value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "COURSE_LAPSED" field.
        /// </summary>
        System.Int32 IEventModel.LapsedPlaces
        {
            get { return this.LapsedPlaces; }
            set { this.LapsedPlaces = (System.Int32)value; }
        }

        /// <summary>
        ///     Gets the The value of the "COURSE_INT_NOTES" field.
        /// </summary>
        Consensus.Common.INotesModel IEventModel.IntNotes
        {
            get { return this.IntNotes; }
        }

        /// <summary>
        ///     Gets or sets the unique code for the value of the "COURSE_INT_NOTES" field.
        /// </summary>
        System.String IEventModel.IntNotesId
        {
            get { return this.IntNotesId; }
            set { this.IntNotesId = (System.String)value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "COURSE_CANCELLATION_DATE" field.
        /// </summary>
        System.Nullable<System.DateTime> IEventModel.CancellationDate
        {
            get { return this.CancellationDate; }
            set { this.CancellationDate = (System.Nullable<System.DateTime>)value; }
        }

        /// <summary>
        ///     Gets the The value of the "COURSE_REASON" field.
        /// </summary>
        Consensus.Common.ICodeModel IEventModel.CancellationReason
        {
            get { return this.CancellationReason; }
        }

        /// <summary>
        ///     Gets or sets the unique code for the value of the "COURSE_REASON" field.
        /// </summary>
        System.String IEventModel.CancellationReasonCode
        {
            get { return this.CancellationReasonCode; }
            set { this.CancellationReasonCode = (System.String)value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "COURSE_UNRECOVERABLE_CANC_LOSS" field.
        /// </summary>
        System.Nullable<System.Decimal> IEventModel.UnrecoverableCancelationLoss
        {
            get { return this.UnrecoverableCancelationLoss; }
            set { this.UnrecoverableCancelationLoss = (System.Nullable<System.Decimal>)value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "COURSE_EXT_COURSEWARE" field.
        /// </summary>
        System.Nullable<System.Byte> IEventModel.RequiresExternalCourseware
        {
            get { return this.RequiresExternalCourseware; }
            set { this.RequiresExternalCourseware = (System.Nullable<System.Byte>)value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "COURSE_CONTINGENCY" field.
        /// </summary>
        System.Nullable<System.Int32> IEventModel.Contingency
        {
            get { return this.Contingency; }
            set { this.Contingency = (System.Nullable<System.Int32>)value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "COURSE_COST" field.
        /// </summary>
        System.Nullable<System.Decimal> IEventModel.Cost
        {
            get { return this.Cost; }
            set { this.Cost = (System.Nullable<System.Decimal>)value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "COURSE_DELIVERY_DAYS" field.
        /// </summary>
        System.Nullable<System.Int32> IEventModel.DeliveryDays
        {
            get { return this.DeliveryDays; }
            set { this.DeliveryDays = (System.Nullable<System.Int32>)value; }
        }

        /// <summary>
        ///     Gets the The value of the "COURSE_MTR_PROLE_ID" field.
        /// </summary>
        Consensus.Contact.IRoleModel IEventModel.MainTrainer
        {
            get { return this.MainTrainer; }
        }

        /// <summary>
        ///     Gets or sets the unique code for the value of the "COURSE_MTR_PROLE_ID" field.
        /// </summary>
        System.String IEventModel.MainTrainerId
        {
            get { return this.MainTrainerId; }
            set { this.MainTrainerId = (System.String)value; }
        }

        /// <summary>
        ///     Gets the The value of the "COURSE_ACADY_CODE" field.
        /// </summary>
        Consensus.Common.ICodeModel IEventModel.AcademicYear
        {
            get { return this.AcademicYear; }
        }

        /// <summary>
        ///     Gets or sets the unique code for the value of the "COURSE_ACADY_CODE" field.
        /// </summary>
        System.String IEventModel.AcademicYearCode
        {
            get { return this.AcademicYearCode; }
            set { this.AcademicYearCode = (System.String)value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "COURSE_USERMULTI_1" field.
        /// </summary>
        System.String IEventModel.Usermulti1
        {
            get { return this.Usermulti1; }
            set { this.Usermulti1 = (System.String)value; }
        }

        /// <summary>
        ///     Gets the The value of the "COURSE_PSH_ID" field.
        /// </summary>
        Consensus.Finance.IPayscheduleheaderModel IEventModel.PayScheduleHeader
        {
            get { return this.PayScheduleHeader; }
        }

        /// <summary>
        ///     Gets or sets the unique code for the value of the "COURSE_PSH_ID" field.
        /// </summary>
        System.Nullable<System.Int32> IEventModel.PayScheduleHeaderId
        {
            get { return this.PayScheduleHeaderId; }
            set { this.PayScheduleHeaderId = (System.Nullable<System.Int32>)value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "COURSE_BLOCK_TYPE" field.
        /// </summary>
        System.Nullable<System.Byte> IEventModel.BlockType
        {
            get { return this.BlockType; }
            set { this.BlockType = (System.Nullable<System.Byte>)value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "COURSE_AVAIL" field.
        /// </summary>
        System.String IEventModel.Avail
        {
            get { return this.Avail; }
            set { this.Avail = (System.String)value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "COURSE_FIRST_LIC_EVENT" field.
        /// </summary>
        System.Nullable<System.Byte> IEventModel.FirstLicencedEvent
        {
            get { return this.FirstLicencedEvent; }
            set { this.FirstLicencedEvent = (System.Nullable<System.Byte>)value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "COURSE_LICENSED" field.
        /// </summary>
        System.Byte IEventModel.Licensed
        {
            get { return this.Licensed; }
            set { this.Licensed = (System.Byte)value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "COURSE_PACK_BCC_EMAIL" field.
        /// </summary>
        System.String IEventModel.PackBccEmail
        {
            get { return this.PackBccEmail; }
            set { this.PackBccEmail = (System.String)value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "COURSE_PACK_MDN_EMAIL" field.
        /// </summary>
        System.String IEventModel.PackMdnEmail
        {
            get { return this.PackMdnEmail; }
            set { this.PackMdnEmail = (System.String)value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "COURSE_PACK_DSN_EMAIL" field.
        /// </summary>
        System.String IEventModel.PackDsnEmail
        {
            get { return this.PackDsnEmail; }
            set { this.PackDsnEmail = (System.String)value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "COURSE_CLIENT_REF" field.
        /// </summary>
        System.String IEventModel.ClientRef
        {
            get { return this.ClientRef; }
            set { this.ClientRef = (System.String)value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "COURSE_SESSIONS_DESCRIPTION" field.
        /// </summary>
        System.String IEventModel.SessionsDescription
        {
            get { return this.SessionsDescription; }
            set { this.SessionsDescription = (System.String)value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "COURSE_SESSIONS_HEADER" field.
        /// </summary>
        System.String IEventModel.SessionsHeader
        {
            get { return this.SessionsHeader; }
            set { this.SessionsHeader = (System.String)value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "COURSE_CUT_PRD_TIME" field.
        /// </summary>
        System.Nullable<System.Byte> IEventModel.CutPrdTime
        {
            get { return this.CutPrdTime; }
            set { this.CutPrdTime = (System.Nullable<System.Byte>)value; }
        }

        /// <summary>
        ///     Gets the collection of <see cref="!:ElementModel" /> instances that reference this <see cref="!:EventModel" />.
        /// </summary>
        Consensus.Collection<Consensus.Learning.IElementModel> IEventModel.Elements
        {
            get { return this.Elements; }
        }

        /// <summary>
        ///     Gets the collection of <see cref="!:SessionXrefModel" /> instances that reference this <see cref="!:EventModel" />.
        /// </summary>
        Consensus.Collection<Consensus.Learning.ISessionXrefModel> IEventModel.SessionXrefEvent
        {
            get { return this.SessionXrefEvent; }
        }

        /// <summary>
        ///     Gets the collection of <see cref="!:CourseSelectGroupsModel" /> instances that reference this <see cref="!:EventModel" />.
        /// </summary>
        Consensus.Collection<Consensus.Learning.ICourseSelectGroupsModel> IEventModel.SelectinGroupEvent
        {
            get { return this.SelectinGroupEvent; }
        }

        /// <summary>
        ///     Gets the collection of <see cref="!:EventProductModel" /> instances that reference this <see cref="!:EventModel" />.
        /// </summary>
        Consensus.Collection<Consensus.Learning.IEventProductModel> IEventModel.EventEP
        {
            get { return this.EventEP; }
        }

        /// <summary>
        ///     Gets the collection of <see cref="!:OpportunityModel" /> instances that reference this <see cref="!:EventModel" />.
        /// </summary>
        Consensus.Collection<Consensus.Sales.IOpportunityModel> IEventModel.OppEventId
        {
            get { return this.OppEventId; }
        }

        /// <summary>
        ///     Gets the collection of <see cref="!:InvoiceLineModel" /> instances that reference this <see cref="!:EventModel" />.
        /// </summary>
        Consensus.Collection<Consensus.Finance.IInvoiceLineModel> IEventModel.InvoiceLines
        {
            get { return this.InvoiceLines; }
        }

        /// <summary>
        ///     Gets the collection of <see cref="!:PromotionMasterModel" /> instances that reference this <see cref="!:EventModel" />.
        /// </summary>
        Consensus.Collection<Consensus.Marketing.IPromotionMasterModel> IEventModel.PromotionMasterEvent
        {
            get { return this.PromotionMasterEvent; }
        }

        /// <summary>
        ///     Gets the collection of <see cref="!:SaqQueryModel" /> instances that reference this <see cref="!:EventModel" />.
        /// </summary>
        Consensus.Collection<Consensus.Marketing.ISaqQueryModel> IEventModel.SaqQueryEvent
        {
            get { return this.SaqQueryEvent; }
        }

        #endregion
    }
}
