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
    /// <remarks>
    ///     THIS CODE HAS BEEN AUTOMATICALLY GENERATED USING THE CONSENSUS DEVELOPER TOOLS.
    ///     DO NOT EDIT THIS CODE AS ANY CUSTOM MODIFICATIONS WILL BE LOST UPON REGENERATION.
    /// </remarks>
    public partial class Event : Proxy<IEventModel, String>
    {
        #region fields

        /// <summary>
        ///     The client-consumable proxy instance for the <see cref="MainSession" /> member.
        /// </summary>
        private Consensus.Learning.Session _mainSession;

        /// <summary>
        ///     The client-consumable proxy instance for the <see cref="Manager" /> member.
        /// </summary>
        private Consensus.Contact.Person _manager;

        /// <summary>
        ///     The client-consumable proxy instance for the <see cref="Product" /> member.
        /// </summary>
        private Consensus.Learning.Product _product;

        /// <summary>
        ///     The client-consumable proxy instance for the <see cref="Location" /> member.
        /// </summary>
        private Consensus.Contact.Location _location;

        /// <summary>
        ///     The client-consumable proxy instance for the <see cref="Organisation" /> member.
        /// </summary>
        private Consensus.Contact.Organisation _organisation;

        /// <summary>
        ///     The client-consumable proxy instance for the <see cref="Type" /> member.
        /// </summary>
        private Consensus.Common.Code _type;

        /// <summary>
        ///     The client-consumable proxy instance for the <see cref="Status" /> member.
        /// </summary>
        private Consensus.Common.Code _status;

        /// <summary>
        ///     The client-consumable proxy instance for the <see cref="Rev" /> member.
        /// </summary>
        private Consensus.Common.Code _rev;

        /// <summary>
        ///     The client-consumable proxy instance for the <see cref="Notes" /> member.
        /// </summary>
        private Consensus.Common.Notes _notes;

        /// <summary>
        ///     The client-consumable proxy instance for the <see cref="Commissioned" /> member.
        /// </summary>
        private Consensus.Contact.Organisation _commissioned;

        /// <summary>
        ///     The client-consumable proxy instance for the <see cref="Opportunity" /> member.
        /// </summary>
        private Consensus.Sales.Opportunity _opportunity;

        /// <summary>
        ///     The client-consumable proxy instance for the <see cref="Address" /> member.
        /// </summary>
        private Consensus.Contact.Address _address;

        /// <summary>
        ///     The client-consumable proxy instance for the <see cref="CommissionedRole" /> member.
        /// </summary>
        private Consensus.Contact.Role _commissionedRole;

        /// <summary>
        ///     The client-consumable proxy instance for the <see cref="SellingCompany" /> member.
        /// </summary>
        private Consensus.Common.SellingCompany _sellingCompany;

        /// <summary>
        ///     The client-consumable proxy instance for the <see cref="BookingTerms" /> member.
        /// </summary>
        private Consensus.Finance.BookingTerms _bookingTerms;

        /// <summary>
        ///     The client-consumable proxy instance for the <see cref="Contact" /> member.
        /// </summary>
        private Consensus.Contact.Role _contact;

        /// <summary>
        ///     The client-consumable proxy instance for the <see cref="SupplierStatus" /> member.
        /// </summary>
        private Consensus.Common.Code _supplierStatus;

        /// <summary>
        ///     The client-consumable proxy instance for the <see cref="SupplierOrg" /> member.
        /// </summary>
        private Consensus.Contact.Organisation _supplierOrg;

        /// <summary>
        ///     The client-consumable proxy instance for the <see cref="SupplierRole" /> member.
        /// </summary>
        private Consensus.Contact.Role _supplierRole;

        /// <summary>
        ///     The client-consumable proxy instance for the <see cref="FundingOrganisation" /> member.
        /// </summary>
        private Consensus.Contact.Organisation _fundingOrganisation;

        /// <summary>
        ///     The client-consumable proxy instance for the <see cref="DefaultDelegateStatus" /> member.
        /// </summary>
        private Consensus.Common.Code _defaultDelegateStatus;

        /// <summary>
        ///     The client-consumable proxy instance for the <see cref="IntNotes" /> member.
        /// </summary>
        private Consensus.Common.Notes _intNotes;

        /// <summary>
        ///     The client-consumable proxy instance for the <see cref="CancellationReason" /> member.
        /// </summary>
        private Consensus.Common.Code _cancellationReason;

        /// <summary>
        ///     The client-consumable proxy instance for the <see cref="MainTrainer" /> member.
        /// </summary>
        private Consensus.Contact.Role _mainTrainer;

        /// <summary>
        ///     The client-consumable proxy instance for the <see cref="AcademicYear" /> member.
        /// </summary>
        private Consensus.Common.Code _academicYear;

        /// <summary>
        ///     The client-consumable proxy instance for the <see cref="PayScheduleHeader" /> member.
        /// </summary>
        private Consensus.Finance.Payscheduleheader _payScheduleHeader;

        /// <summary>
        ///     The client-consumable proxy collection for the <see cref="Elements" /> member.
        /// </summary>
        private ProxyCollection<Consensus.Learning.Element, Consensus.Learning.IElementModel> _elements;

        /// <summary>
        ///     The client-consumable proxy collection for the <see cref="SessionXrefEvent" /> member.
        /// </summary>
        private ProxyCollection<Consensus.Learning.SessionXref, Consensus.Learning.ISessionXrefModel> _sessionXrefEvent;

        /// <summary>
        ///     The client-consumable proxy collection for the <see cref="SelectinGroupEvent" /> member.
        /// </summary>
        private ProxyCollection<Consensus.Learning.CourseSelectGroups, Consensus.Learning.ICourseSelectGroupsModel> _selectinGroupEvent;

        /// <summary>
        ///     The client-consumable proxy collection for the <see cref="EventEP" /> member.
        /// </summary>
        private ProxyCollection<Consensus.Learning.EventProduct, Consensus.Learning.IEventProductModel> _eventEP;

        /// <summary>
        ///     The client-consumable proxy collection for the <see cref="OppEventId" /> member.
        /// </summary>
        private ProxyCollection<Consensus.Sales.Opportunity, Consensus.Sales.IOpportunityModel> _oppEventId;

        /// <summary>
        ///     The client-consumable proxy collection for the <see cref="InvoiceLines" /> member.
        /// </summary>
        private ProxyCollection<Consensus.Finance.InvoiceLine, Consensus.Finance.IInvoiceLineModel> _invoiceLines;

        /// <summary>
        ///     The client-consumable proxy collection for the <see cref="PromotionMasterEvent" /> member.
        /// </summary>
        private ProxyCollection<Consensus.Marketing.PromotionMaster, Consensus.Marketing.IPromotionMasterModel> _promotionMasterEvent;

        /// <summary>
        ///     The client-consumable proxy collection for the <see cref="SaqQueryEvent" /> member.
        /// </summary>
        private ProxyCollection<Consensus.Marketing.SaqQuery, Consensus.Marketing.ISaqQueryModel> _saqQueryEvent;

        #endregion

        #region properties

        /// <summary>
        ///     Gets or sets the main session.
        /// </summary>
        public Consensus.Learning.Session MainSession
        {
            get
            {
                if (_mainSession == null && this.Model.MainSession != null)
                    _mainSession = new Consensus.Learning.Session(this.Model.MainSession);
                if (_mainSession == null)
                    _mainSession = Consensus.Learning.Session.Create();
                return _mainSession;
            }
        }

        /// <summary>
        ///     Gets the The value of the "COURSE_PERSON_ID" field.
        /// </summary>
        public Consensus.Contact.Person Manager
        {
            get
            {
                if (_manager == null && this.Model.Manager != null)
                    _manager = new Consensus.Contact.Person(this.Model.Manager);
                if (_manager == null)
                    _manager = Consensus.Contact.Person.Create();
                return _manager;
            }
        }

        /// <summary>
        ///     Gets or sets the unique code for the value of the "COURSE_PERSON_ID" field.
        /// </summary>
        public System.String ManagerId
        {
            get { return this.Model.ManagerId; }
            set { this.Model.ManagerId = value; }
        }

        /// <summary>
        ///     Gets the The value of the "COURSE_PRODUCT_ID" field.
        /// </summary>
        public Consensus.Learning.Product Product
        {
            get
            {
                if (_product == null && this.Model.Product != null)
                    _product = new Consensus.Learning.Product(this.Model.Product);
                if (_product == null)
                    _product = Consensus.Learning.Product.Create();
                return _product;
            }
        }

        /// <summary>
        ///     Gets or sets the unique code for the value of the "COURSE_PRODUCT_ID" field.
        /// </summary>
        public System.String ProductId
        {
            get { return this.Model.ProductId; }
            set { this.Model.ProductId = value; }
        }

        /// <summary>
        ///     Gets the The value of the "COURSE_LOC_ID" field.
        /// </summary>
        public Consensus.Contact.Location Location
        {
            get
            {
                if (_location == null && this.Model.Location != null)
                    _location = new Consensus.Contact.Location(this.Model.Location);
                if (_location == null)
                    _location = Consensus.Contact.Location.Create();
                return _location;
            }
        }

        /// <summary>
        ///     Gets or sets the unique code for the value of the "COURSE_LOC_ID" field.
        /// </summary>
        public System.String LocationId
        {
            get { return this.Model.LocationId; }
            set { this.Model.LocationId = value; }
        }

        /// <summary>
        ///     Gets the The value of the "COURSE_ORG_ID" field.
        /// </summary>
        public Consensus.Contact.Organisation Organisation
        {
            get
            {
                if (_organisation == null && this.Model.Organisation != null)
                    _organisation = new Consensus.Contact.Organisation(this.Model.Organisation);
                if (_organisation == null)
                    _organisation = Consensus.Contact.Organisation.Create();
                return _organisation;
            }
        }

        /// <summary>
        ///     Gets or sets the unique code for the value of the "COURSE_ORG_ID" field.
        /// </summary>
        public System.String OrganisationId
        {
            get { return this.Model.OrganisationId; }
            set { this.Model.OrganisationId = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "COURSE_REF" field.
        /// </summary>
        public System.String Ref
        {
            get { return this.Model.Ref; }
            set { this.Model.Ref = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "COURSE_NAME" field.
        /// </summary>
        public System.String Name
        {
            get { return this.Model.Name; }
            set { this.Model.Name = value; }
        }

        /// <summary>
        ///     Gets the The value of the "COURSE_TYPE" field.
        /// </summary>
        public Consensus.Common.Code Type
        {
            get
            {
                if (_type == null && this.Model.Type != null)
                    _type = new Consensus.Common.Code(this.Model.Type);
                if (_type == null)
                    _type = Consensus.Common.Code.Create();
                return _type;
            }
        }

        /// <summary>
        ///     Gets or sets the unique code for the value of the "COURSE_TYPE" field.
        /// </summary>
        public System.String TypeCode
        {
            get { return this.Model.TypeCode; }
            set { this.Model.TypeCode = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "COURSE_BLOCK_PRICD" field.
        /// </summary>
        public System.Nullable<System.Byte> Pricing
        {
            get { return this.Model.Pricing; }
            set { this.Model.Pricing = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "COURSE_START_DATE" field.
        /// </summary>
        public System.Nullable<System.DateTime> StartDate
        {
            get { return this.Model.StartDate; }
            set { this.Model.StartDate = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "COURSE_END_DATE" field.
        /// </summary>
        public System.Nullable<System.DateTime> EndDate
        {
            get { return this.Model.EndDate; }
            set { this.Model.EndDate = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "COURSE_START_TIME" field.
        /// </summary>
        public System.Nullable<System.DateTime> StartTime
        {
            get { return this.Model.StartTime; }
            set { this.Model.StartTime = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "COURSE_END_TIME" field.
        /// </summary>
        public System.Nullable<System.DateTime> EndTime
        {
            get { return this.Model.EndTime; }
            set { this.Model.EndTime = value; }
        }

        /// <summary>
        ///     Gets the The value of the "COURSE_STATUS" field.
        /// </summary>
        public Consensus.Common.Code Status
        {
            get
            {
                if (_status == null && this.Model.Status != null)
                    _status = new Consensus.Common.Code(this.Model.Status);
                if (_status == null)
                    _status = Consensus.Common.Code.Create();
                return _status;
            }
        }

        /// <summary>
        ///     Gets or sets the unique code for the value of the "COURSE_STATUS" field.
        /// </summary>
        public System.String StatusCode
        {
            get { return this.Model.StatusCode; }
            set { this.Model.StatusCode = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "COURSE_LENGTH" field.
        /// </summary>
        public System.Nullable<System.Double> Length
        {
            get { return this.Model.Length; }
            set { this.Model.Length = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "COURSE_MIN_PLACES" field.
        /// </summary>
        public System.Nullable<System.Double> MinPlaces
        {
            get { return this.Model.MinPlaces; }
            set { this.Model.MinPlaces = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "COURSE_MAX_PLACES" field.
        /// </summary>
        public System.Nullable<System.Double> MaxPlaces
        {
            get { return this.Model.MaxPlaces; }
            set { this.Model.MaxPlaces = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "COURSE_FREE_PLACES" field.
        /// </summary>
        public System.Nullable<System.Double> FreePlaces
        {
            get { return this.Model.FreePlaces; }
            set { this.Model.FreePlaces = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "COURSE_CONF_PLACES" field.
        /// </summary>
        public System.Nullable<System.Double> ConfirmedPlaces
        {
            get { return this.Model.ConfirmedPlaces; }
            set { this.Model.ConfirmedPlaces = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "COURSE_PROVIS_BKGS" field.
        /// </summary>
        public System.Nullable<System.Double> ProvisionalPlaces
        {
            get { return this.Model.ProvisionalPlaces; }
            set { this.Model.ProvisionalPlaces = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "COURSE_RESV_PLACES" field.
        /// </summary>
        public System.Nullable<System.Double> WaitlistPlaces
        {
            get { return this.Model.WaitlistPlaces; }
            set { this.Model.WaitlistPlaces = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "COURSE_CANCELS" field.
        /// </summary>
        public System.Nullable<System.Double> CancelledPlaces
        {
            get { return this.Model.CancelledPlaces; }
            set { this.Model.CancelledPlaces = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "COURSE_BLOCK_PRICE" field.
        /// </summary>
        public System.Nullable<System.Double> BlockPrice
        {
            get { return this.Model.BlockPrice; }
            set { this.Model.BlockPrice = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "COURSE_STUDT_PRICE" field.
        /// </summary>
        public System.Nullable<System.Double> UnitPrice
        {
            get { return this.Model.UnitPrice; }
            set { this.Model.UnitPrice = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "COURSE_COST_CODE" field.
        /// </summary>
        public System.String CostCode
        {
            get { return this.Model.CostCode; }
            set { this.Model.CostCode = value; }
        }

        /// <summary>
        ///     Gets the The value of the "COURSE_REV_CODE" field.
        /// </summary>
        public Consensus.Common.Code Rev
        {
            get
            {
                if (_rev == null && this.Model.Rev != null)
                    _rev = new Consensus.Common.Code(this.Model.Rev);
                if (_rev == null)
                    _rev = Consensus.Common.Code.Create();
                return _rev;
            }
        }

        /// <summary>
        ///     Gets or sets the unique code for the value of the "COURSE_REV_CODE" field.
        /// </summary>
        public System.String RevCode
        {
            get { return this.Model.RevCode; }
            set { this.Model.RevCode = value; }
        }

        /// <summary>
        ///     Gets the The value of the "COURSE_NOTES" field.
        /// </summary>
        public Consensus.Common.Notes Notes
        {
            get
            {
                if (_notes == null && this.Model.Notes != null)
                    _notes = new Consensus.Common.Notes(this.Model.Notes);
                if (_notes == null)
                    _notes = Consensus.Common.Notes.Create();
                return _notes;
            }
        }

        /// <summary>
        ///     Gets or sets the unique code for the value of the "COURSE_NOTES" field.
        /// </summary>
        public System.String NotesId
        {
            get { return this.Model.NotesId; }
            set { this.Model.NotesId = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "COURSE_BOOK_ACTUAL" field.
        /// </summary>
        public System.Nullable<System.Double> BookActual
        {
            get { return this.Model.BookActual; }
            set { this.Model.BookActual = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "COURSE_ACTUAL_TOT" field.
        /// </summary>
        public System.Nullable<System.Double> ActualCost
        {
            get { return this.Model.ActualCost; }
            set { this.Model.ActualCost = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "COURSE_DO_NOT_INVC" field.
        /// </summary>
        public System.Nullable<System.Byte> DoNotInvoice
        {
            get { return this.Model.DoNotInvoice; }
            set { this.Model.DoNotInvoice = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "COURSE_CANCEL_DATE" field.
        /// </summary>
        public System.Nullable<System.DateTime> CancelDate
        {
            get { return this.Model.CancelDate; }
            set { this.Model.CancelDate = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "COURSE_CANCEL_BY" field.
        /// </summary>
        public System.String CancelBy
        {
            get { return this.Model.CancelBy; }
            set { this.Model.CancelBy = value; }
        }

        /// <summary>
        ///     Gets the The value of the "COURSE_SUPPLIER_ID" field.
        /// </summary>
        public Consensus.Contact.Organisation Commissioned
        {
            get
            {
                if (_commissioned == null && this.Model.Commissioned != null)
                    _commissioned = new Consensus.Contact.Organisation(this.Model.Commissioned);
                if (_commissioned == null)
                    _commissioned = Consensus.Contact.Organisation.Create();
                return _commissioned;
            }
        }

        /// <summary>
        ///     Gets or sets the unique code for the value of the "COURSE_SUPPLIER_ID" field.
        /// </summary>
        public System.String CommissionedId
        {
            get { return this.Model.CommissionedId; }
            set { this.Model.CommissionedId = value; }
        }

        /// <summary>
        ///     Gets the The value of the "COURSE_OPP_ID" field.
        /// </summary>
        public Consensus.Sales.Opportunity Opportunity
        {
            get
            {
                if (_opportunity == null && this.Model.Opportunity != null)
                    _opportunity = new Consensus.Sales.Opportunity(this.Model.Opportunity);
                if (_opportunity == null)
                    _opportunity = Consensus.Sales.Opportunity.Create();
                return _opportunity;
            }
        }

        /// <summary>
        ///     Gets or sets the unique code for the value of the "COURSE_OPP_ID" field.
        /// </summary>
        public System.String OpportunityId
        {
            get { return this.Model.OpportunityId; }
            set { this.Model.OpportunityId = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "COURSE_PRIVATE" field.
        /// </summary>
        public System.Nullable<System.Byte> Private
        {
            get { return this.Model.Private; }
            set { this.Model.Private = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "COURSE_WEB" field.
        /// </summary>
        public System.Nullable<System.Byte> Web
        {
            get { return this.Model.Web; }
            set { this.Model.Web = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "COURSE_URL" field.
        /// </summary>
        public System.String Url
        {
            get { return this.Model.Url; }
            set { this.Model.Url = value; }
        }

        /// <summary>
        ///     Gets the The value of the "COURSE_ADD_ID" field.
        /// </summary>
        public Consensus.Contact.Address Address
        {
            get
            {
                if (_address == null && this.Model.Address != null)
                    _address = new Consensus.Contact.Address(this.Model.Address);
                if (_address == null)
                    _address = Consensus.Contact.Address.Create();
                return _address;
            }
        }

        /// <summary>
        ///     Gets or sets the unique code for the value of the "COURSE_ADD_ID" field.
        /// </summary>
        public System.String AddressId
        {
            get { return this.Model.AddressId; }
            set { this.Model.AddressId = value; }
        }

        /// <summary>
        ///     Gets the The value of the "COURSE_SUP_ROLE_ID" field.
        /// </summary>
        public Consensus.Contact.Role CommissionedRole
        {
            get
            {
                if (_commissionedRole == null && this.Model.CommissionedRole != null)
                    _commissionedRole = new Consensus.Contact.Role(this.Model.CommissionedRole);
                if (_commissionedRole == null)
                    _commissionedRole = Consensus.Contact.Role.Create();
                return _commissionedRole;
            }
        }

        /// <summary>
        ///     Gets or sets the unique code for the value of the "COURSE_SUP_ROLE_ID" field.
        /// </summary>
        public System.String CommissionedRoleId
        {
            get { return this.Model.CommissionedRoleId; }
            set { this.Model.CommissionedRoleId = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "COURSE_CURRENCY" field.
        /// </summary>
        public System.String Currency
        {
            get { return this.Model.Currency; }
            set { this.Model.Currency = value; }
        }

        /// <summary>
        ///     Gets the The value of the "COURSE_SELCO_SP_ID" field.
        /// </summary>
        public Consensus.Common.SellingCompany SellingCompany
        {
            get
            {
                if (_sellingCompany == null && this.Model.SellingCompany != null)
                    _sellingCompany = new Consensus.Common.SellingCompany(this.Model.SellingCompany);
                if (_sellingCompany == null)
                    _sellingCompany = Consensus.Common.SellingCompany.Create();
                return _sellingCompany;
            }
        }

        /// <summary>
        ///     Gets or sets the unique code for the value of the "COURSE_SELCO_SP_ID" field.
        /// </summary>
        public System.String SellingCompanyId
        {
            get { return this.Model.SellingCompanyId; }
            set { this.Model.SellingCompanyId = value; }
        }

        /// <summary>
        ///     Gets the The value of the "COURSE_BKT_ID" field.
        /// </summary>
        public Consensus.Finance.BookingTerms BookingTerms
        {
            get
            {
                if (_bookingTerms == null && this.Model.BookingTerms != null)
                    _bookingTerms = new Consensus.Finance.BookingTerms(this.Model.BookingTerms);
                if (_bookingTerms == null)
                    _bookingTerms = Consensus.Finance.BookingTerms.Create();
                return _bookingTerms;
            }
        }

        /// <summary>
        ///     Gets or sets the unique code for the value of the "COURSE_BKT_ID" field.
        /// </summary>
        public System.String BookingTermsId
        {
            get { return this.Model.BookingTermsId; }
            set { this.Model.BookingTermsId = value; }
        }

        /// <summary>
        ///     Gets the The value of the "COURSE_CONTPROL_ID" field.
        /// </summary>
        public Consensus.Contact.Role Contact
        {
            get
            {
                if (_contact == null && this.Model.Contact != null)
                    _contact = new Consensus.Contact.Role(this.Model.Contact);
                if (_contact == null)
                    _contact = Consensus.Contact.Role.Create();
                return _contact;
            }
        }

        /// <summary>
        ///     Gets or sets the unique code for the value of the "COURSE_CONTPROL_ID" field.
        /// </summary>
        public System.String ContactId
        {
            get { return this.Model.ContactId; }
            set { this.Model.ContactId = value; }
        }

        /// <summary>
        ///     Gets the The value of the "COURSE_SUP_STATUS" field.
        /// </summary>
        public Consensus.Common.Code SupplierStatus
        {
            get
            {
                if (_supplierStatus == null && this.Model.SupplierStatus != null)
                    _supplierStatus = new Consensus.Common.Code(this.Model.SupplierStatus);
                if (_supplierStatus == null)
                    _supplierStatus = Consensus.Common.Code.Create();
                return _supplierStatus;
            }
        }

        /// <summary>
        ///     Gets or sets the unique code for the value of the "COURSE_SUP_STATUS" field.
        /// </summary>
        public System.String SupplierStatusCode
        {
            get { return this.Model.SupplierStatusCode; }
            set { this.Model.SupplierStatusCode = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "COURSE_OVERBOOK" field.
        /// </summary>
        public System.Nullable<System.Byte> AllowOverbook
        {
            get { return this.Model.AllowOverbook; }
            set { this.Model.AllowOverbook = value; }
        }

        /// <summary>
        ///     Gets the The value of the "COURSE_PROV_ORG_ID" field.
        /// </summary>
        public Consensus.Contact.Organisation SupplierOrg
        {
            get
            {
                if (_supplierOrg == null && this.Model.SupplierOrg != null)
                    _supplierOrg = new Consensus.Contact.Organisation(this.Model.SupplierOrg);
                if (_supplierOrg == null)
                    _supplierOrg = Consensus.Contact.Organisation.Create();
                return _supplierOrg;
            }
        }

        /// <summary>
        ///     Gets or sets the unique code for the value of the "COURSE_PROV_ORG_ID" field.
        /// </summary>
        public System.String SupplierOrgId
        {
            get { return this.Model.SupplierOrgId; }
            set { this.Model.SupplierOrgId = value; }
        }

        /// <summary>
        ///     Gets the The value of the "COURSE_PROV_PROLE_ID" field.
        /// </summary>
        public Consensus.Contact.Role SupplierRole
        {
            get
            {
                if (_supplierRole == null && this.Model.SupplierRole != null)
                    _supplierRole = new Consensus.Contact.Role(this.Model.SupplierRole);
                if (_supplierRole == null)
                    _supplierRole = Consensus.Contact.Role.Create();
                return _supplierRole;
            }
        }

        /// <summary>
        ///     Gets or sets the unique code for the value of the "COURSE_PROV_PROLE_ID" field.
        /// </summary>
        public System.String SupplierRoleId
        {
            get { return this.Model.SupplierRoleId; }
            set { this.Model.SupplierRoleId = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "COURSE_FUNDED" field.
        /// </summary>
        public System.Nullable<System.Byte> Funded
        {
            get { return this.Model.Funded; }
            set { this.Model.Funded = value; }
        }

        /// <summary>
        ///     Gets the The value of the "COURSE_FUNDED_ORG_ID" field.
        /// </summary>
        public Consensus.Contact.Organisation FundingOrganisation
        {
            get
            {
                if (_fundingOrganisation == null && this.Model.FundingOrganisation != null)
                    _fundingOrganisation = new Consensus.Contact.Organisation(this.Model.FundingOrganisation);
                if (_fundingOrganisation == null)
                    _fundingOrganisation = Consensus.Contact.Organisation.Create();
                return _fundingOrganisation;
            }
        }

        /// <summary>
        ///     Gets or sets the unique code for the value of the "COURSE_FUNDED_ORG_ID" field.
        /// </summary>
        public System.String FundingOrganisationId
        {
            get { return this.Model.FundingOrganisationId; }
            set { this.Model.FundingOrganisationId = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "COURSE_RESERVATIONS" field.
        /// </summary>
        public System.Int32 ReservedPlaces
        {
            get { return this.Model.ReservedPlaces; }
            set { this.Model.ReservedPlaces = value; }
        }

        /// <summary>
        ///     Gets the The value of the "COURSE_DEF_ELEM_ST" field.
        /// </summary>
        public Consensus.Common.Code DefaultDelegateStatus
        {
            get
            {
                if (_defaultDelegateStatus == null && this.Model.DefaultDelegateStatus != null)
                    _defaultDelegateStatus = new Consensus.Common.Code(this.Model.DefaultDelegateStatus);
                if (_defaultDelegateStatus == null)
                    _defaultDelegateStatus = Consensus.Common.Code.Create();
                return _defaultDelegateStatus;
            }
        }

        /// <summary>
        ///     Gets or sets the unique code for the value of the "COURSE_DEF_ELEM_ST" field.
        /// </summary>
        public System.String DefaultDelegateStatusCode
        {
            get { return this.Model.DefaultDelegateStatusCode; }
            set { this.Model.DefaultDelegateStatusCode = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "COURSE_LAPSED" field.
        /// </summary>
        public System.Int32 LapsedPlaces
        {
            get { return this.Model.LapsedPlaces; }
            set { this.Model.LapsedPlaces = value; }
        }

        /// <summary>
        ///     Gets the The value of the "COURSE_INT_NOTES" field.
        /// </summary>
        public Consensus.Common.Notes IntNotes
        {
            get
            {
                if (_intNotes == null && this.Model.IntNotes != null)
                    _intNotes = new Consensus.Common.Notes(this.Model.IntNotes);
                if (_intNotes == null)
                    _intNotes = Consensus.Common.Notes.Create();
                return _intNotes;
            }
        }

        /// <summary>
        ///     Gets or sets the unique code for the value of the "COURSE_INT_NOTES" field.
        /// </summary>
        public System.String IntNotesId
        {
            get { return this.Model.IntNotesId; }
            set { this.Model.IntNotesId = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "COURSE_CANCELLATION_DATE" field.
        /// </summary>
        public System.Nullable<System.DateTime> CancellationDate
        {
            get { return this.Model.CancellationDate; }
            set { this.Model.CancellationDate = value; }
        }

        /// <summary>
        ///     Gets the The value of the "COURSE_REASON" field.
        /// </summary>
        public Consensus.Common.Code CancellationReason
        {
            get
            {
                if (_cancellationReason == null && this.Model.CancellationReason != null)
                    _cancellationReason = new Consensus.Common.Code(this.Model.CancellationReason);
                if (_cancellationReason == null)
                    _cancellationReason = Consensus.Common.Code.Create();
                return _cancellationReason;
            }
        }

        /// <summary>
        ///     Gets or sets the unique code for the value of the "COURSE_REASON" field.
        /// </summary>
        public System.String CancellationReasonCode
        {
            get { return this.Model.CancellationReasonCode; }
            set { this.Model.CancellationReasonCode = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "COURSE_UNRECOVERABLE_CANC_LOSS" field.
        /// </summary>
        public System.Nullable<System.Decimal> UnrecoverableCancelationLoss
        {
            get { return this.Model.UnrecoverableCancelationLoss; }
            set { this.Model.UnrecoverableCancelationLoss = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "COURSE_EXT_COURSEWARE" field.
        /// </summary>
        public System.Nullable<System.Byte> RequiresExternalCourseware
        {
            get { return this.Model.RequiresExternalCourseware; }
            set { this.Model.RequiresExternalCourseware = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "COURSE_CONTINGENCY" field.
        /// </summary>
        public System.Nullable<System.Int32> Contingency
        {
            get { return this.Model.Contingency; }
            set { this.Model.Contingency = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "COURSE_COST" field.
        /// </summary>
        public System.Nullable<System.Decimal> Cost
        {
            get { return this.Model.Cost; }
            set { this.Model.Cost = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "COURSE_DELIVERY_DAYS" field.
        /// </summary>
        public System.Nullable<System.Int32> DeliveryDays
        {
            get { return this.Model.DeliveryDays; }
            set { this.Model.DeliveryDays = value; }
        }

        /// <summary>
        ///     Gets the The value of the "COURSE_MTR_PROLE_ID" field.
        /// </summary>
        public Consensus.Contact.Role MainTrainer
        {
            get
            {
                if (_mainTrainer == null && this.Model.MainTrainer != null)
                    _mainTrainer = new Consensus.Contact.Role(this.Model.MainTrainer);
                if (_mainTrainer == null)
                    _mainTrainer = Consensus.Contact.Role.Create();
                return _mainTrainer;
            }
        }

        /// <summary>
        ///     Gets or sets the unique code for the value of the "COURSE_MTR_PROLE_ID" field.
        /// </summary>
        public System.String MainTrainerId
        {
            get { return this.Model.MainTrainerId; }
            set { this.Model.MainTrainerId = value; }
        }

        /// <summary>
        ///     Gets the The value of the "COURSE_ACADY_CODE" field.
        /// </summary>
        public Consensus.Common.Code AcademicYear
        {
            get
            {
                if (_academicYear == null && this.Model.AcademicYear != null)
                    _academicYear = new Consensus.Common.Code(this.Model.AcademicYear);
                if (_academicYear == null)
                    _academicYear = Consensus.Common.Code.Create();
                return _academicYear;
            }
        }

        /// <summary>
        ///     Gets or sets the unique code for the value of the "COURSE_ACADY_CODE" field.
        /// </summary>
        public System.String AcademicYearCode
        {
            get { return this.Model.AcademicYearCode; }
            set { this.Model.AcademicYearCode = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "COURSE_USERMULTI_1" field.
        /// </summary>
        public System.String Usermulti1
        {
            get { return this.Model.Usermulti1; }
            set { this.Model.Usermulti1 = value; }
        }

        /// <summary>
        ///     Gets the The value of the "COURSE_PSH_ID" field.
        /// </summary>
        public Consensus.Finance.Payscheduleheader PayScheduleHeader
        {
            get
            {
                if (_payScheduleHeader == null && this.Model.PayScheduleHeader != null)
                    _payScheduleHeader = new Consensus.Finance.Payscheduleheader(this.Model.PayScheduleHeader);
                if (_payScheduleHeader == null)
                    _payScheduleHeader = Consensus.Finance.Payscheduleheader.Create();
                return _payScheduleHeader;
            }
        }

        /// <summary>
        ///     Gets or sets the unique code for the value of the "COURSE_PSH_ID" field.
        /// </summary>
        public System.Nullable<System.Int32> PayScheduleHeaderId
        {
            get { return this.Model.PayScheduleHeaderId; }
            set { this.Model.PayScheduleHeaderId = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "COURSE_BLOCK_TYPE" field.
        /// </summary>
        public System.Nullable<System.Byte> BlockType
        {
            get { return this.Model.BlockType; }
            set { this.Model.BlockType = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "COURSE_AVAIL" field.
        /// </summary>
        public System.String Avail
        {
            get { return this.Model.Avail; }
            set { this.Model.Avail = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "COURSE_FIRST_LIC_EVENT" field.
        /// </summary>
        public System.Nullable<System.Byte> FirstLicencedEvent
        {
            get { return this.Model.FirstLicencedEvent; }
            set { this.Model.FirstLicencedEvent = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "COURSE_LICENSED" field.
        /// </summary>
        public System.Byte Licensed
        {
            get { return this.Model.Licensed; }
            set { this.Model.Licensed = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "COURSE_PACK_BCC_EMAIL" field.
        /// </summary>
        public System.String PackBccEmail
        {
            get { return this.Model.PackBccEmail; }
            set { this.Model.PackBccEmail = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "COURSE_PACK_MDN_EMAIL" field.
        /// </summary>
        public System.String PackMdnEmail
        {
            get { return this.Model.PackMdnEmail; }
            set { this.Model.PackMdnEmail = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "COURSE_PACK_DSN_EMAIL" field.
        /// </summary>
        public System.String PackDsnEmail
        {
            get { return this.Model.PackDsnEmail; }
            set { this.Model.PackDsnEmail = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "COURSE_CLIENT_REF" field.
        /// </summary>
        public System.String ClientRef
        {
            get { return this.Model.ClientRef; }
            set { this.Model.ClientRef = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "COURSE_SESSIONS_DESCRIPTION" field.
        /// </summary>
        public System.String SessionsDescription
        {
            get { return this.Model.SessionsDescription; }
            set { this.Model.SessionsDescription = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "COURSE_SESSIONS_HEADER" field.
        /// </summary>
        public System.String SessionsHeader
        {
            get { return this.Model.SessionsHeader; }
            set { this.Model.SessionsHeader = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "COURSE_CUT_PRD_TIME" field.
        /// </summary>
        public System.Nullable<System.Byte> CutPrdTime
        {
            get { return this.Model.CutPrdTime; }
            set { this.Model.CutPrdTime = value; }
        }

        /// <summary>
        ///     Gets the collection of <see cref="!:ElementModel" /> instances that reference this <see cref="!:EventModel" />.
        /// </summary>
        public Collection<Consensus.Learning.Element> Elements
        {
            get
            {
                if (_elements == null)
                    _elements = new ProxyCollection<Consensus.Learning.Element, Consensus.Learning.IElementModel>(this.Model.Elements, model => new Consensus.Learning.Element(model));
                return _elements;
            }
        }

        /// <summary>
        ///     Gets the collection of <see cref="!:SessionXrefModel" /> instances that reference this <see cref="!:EventModel" />.
        /// </summary>
        public Collection<Consensus.Learning.SessionXref> SessionXrefEvent
        {
            get
            {
                if (_sessionXrefEvent == null)
                    _sessionXrefEvent = new ProxyCollection<Consensus.Learning.SessionXref, Consensus.Learning.ISessionXrefModel>(this.Model.SessionXrefEvent, model => new Consensus.Learning.SessionXref(model));
                return _sessionXrefEvent;
            }
        }

        /// <summary>
        ///     Gets the collection of <see cref="!:CourseSelectGroupsModel" /> instances that reference this <see cref="!:EventModel" />.
        /// </summary>
        public Collection<Consensus.Learning.CourseSelectGroups> SelectinGroupEvent
        {
            get
            {
                if (_selectinGroupEvent == null)
                    _selectinGroupEvent = new ProxyCollection<Consensus.Learning.CourseSelectGroups, Consensus.Learning.ICourseSelectGroupsModel>(this.Model.SelectinGroupEvent, model => new Consensus.Learning.CourseSelectGroups(model));
                return _selectinGroupEvent;
            }
        }

        /// <summary>
        ///     Gets the collection of <see cref="!:EventProductModel" /> instances that reference this <see cref="!:EventModel" />.
        /// </summary>
        public Collection<Consensus.Learning.EventProduct> EventEP
        {
            get
            {
                if (_eventEP == null)
                    _eventEP = new ProxyCollection<Consensus.Learning.EventProduct, Consensus.Learning.IEventProductModel>(this.Model.EventEP, model => new Consensus.Learning.EventProduct(model));
                return _eventEP;
            }
        }

        /// <summary>
        ///     Gets the collection of <see cref="!:OpportunityModel" /> instances that reference this <see cref="!:EventModel" />.
        /// </summary>
        public Collection<Consensus.Sales.Opportunity> OppEventId
        {
            get
            {
                if (_oppEventId == null)
                    _oppEventId = new ProxyCollection<Consensus.Sales.Opportunity, Consensus.Sales.IOpportunityModel>(this.Model.OppEventId, model => new Consensus.Sales.Opportunity(model));
                return _oppEventId;
            }
        }

        /// <summary>
        ///     Gets the collection of <see cref="!:InvoiceLineModel" /> instances that reference this <see cref="!:EventModel" />.
        /// </summary>
        public Collection<Consensus.Finance.InvoiceLine> InvoiceLines
        {
            get
            {
                if (_invoiceLines == null)
                    _invoiceLines = new ProxyCollection<Consensus.Finance.InvoiceLine, Consensus.Finance.IInvoiceLineModel>(this.Model.InvoiceLines, model => new Consensus.Finance.InvoiceLine(model));
                return _invoiceLines;
            }
        }

        /// <summary>
        ///     Gets the collection of <see cref="!:PromotionMasterModel" /> instances that reference this <see cref="!:EventModel" />.
        /// </summary>
        public Collection<Consensus.Marketing.PromotionMaster> PromotionMasterEvent
        {
            get
            {
                if (_promotionMasterEvent == null)
                    _promotionMasterEvent = new ProxyCollection<Consensus.Marketing.PromotionMaster, Consensus.Marketing.IPromotionMasterModel>(this.Model.PromotionMasterEvent, model => new Consensus.Marketing.PromotionMaster(model));
                return _promotionMasterEvent;
            }
        }

        /// <summary>
        ///     Gets the collection of <see cref="!:SaqQueryModel" /> instances that reference this <see cref="!:EventModel" />.
        /// </summary>
        public Collection<Consensus.Marketing.SaqQuery> SaqQueryEvent
        {
            get
            {
                if (_saqQueryEvent == null)
                    _saqQueryEvent = new ProxyCollection<Consensus.Marketing.SaqQuery, Consensus.Marketing.ISaqQueryModel>(this.Model.SaqQueryEvent, model => new Consensus.Marketing.SaqQuery(model));
                return _saqQueryEvent;
            }
        }

        #endregion

        #region constructors

        /// <summary>
        ///     Initialises a new instance of the client-consumable class.
        /// </summary>
        internal Event(IEventModel model) : base(model)
        {
        }

        #endregion

        #region methods

        /// <summary>
        ///     Retrieves a single <see cref="!:EventModel" /> instance.
        /// </summary>
        /// <param name="courseParentId">
        ///     The value which identifies the <see cref="!:EventModel" /> instance to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:EventModel" /> instance that match the specified <paramref name="courseParentId" />.
        /// </returns>
        public static Consensus.Learning.Event FetchByCourseParentId(System.String courseParentId)
        {
            ConsensusSite site = ConsensusDomain.Configuration[ConsensusDomain.Configuration.DefaultSite];
            return Event.FetchByCourseParentId(site,courseParentId);
        }

        /// <summary>
        ///     Retrieves a single <see cref="!:EventModel" /> instance.
        /// </summary>
        /// <param name="courseParentId">
        ///     The value which identifies the <see cref="!:EventModel" /> instance to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:EventModel" /> instance that match the specified <paramref name="courseParentId" />.
        /// </returns>
        public static Consensus.Learning.Event FetchByCourseParentId(ConsensusSite site, System.String courseParentId)
        {
            IBusinessProvider provider = site.GetService<IBusinessProvider>();
            Consensus.Learning.IEventModel model = provider.Learning.Event.FetchByCourseParentId(courseParentId);
            return model == null ? null : new Consensus.Learning.Event(model);
        }

        public static void CalculateCourseNumbers(System.String courseId)
        {
            ConsensusSite site = ConsensusDomain.Configuration[ConsensusDomain.Configuration.DefaultSite];
            Event.CalculateCourseNumbers(site,courseId);
        }

        public static void CalculateCourseNumbers(ConsensusSite site, System.String courseId)
        {
            IBusinessProvider provider = site.GetService<IBusinessProvider>();
            provider.Learning.Event.CalculateCourseNumbers(courseId);
        }

        public static void CalculateCourseStartEnd(System.String courseId)
        {
            ConsensusSite site = ConsensusDomain.Configuration[ConsensusDomain.Configuration.DefaultSite];
            Event.CalculateCourseStartEnd(site,courseId);
        }

        public static void CalculateCourseStartEnd(ConsensusSite site, System.String courseId)
        {
            IBusinessProvider provider = site.GetService<IBusinessProvider>();
            provider.Learning.Event.CalculateCourseStartEnd(courseId);
        }

        /// <summary>
        ///     Creates a new <see cref="!:EventModel" /> instance.
        /// </summary>
        /// <returns>
        ///     A newly instantiated <see cref="!:EventModel" /> instance.
        /// </returns>
        public static Consensus.Learning.Event Create()
        {
            ConsensusSite site = ConsensusDomain.Configuration[ConsensusDomain.Configuration.DefaultSite];
            return Event.Create(site);
        }

        /// <summary>
        ///     Creates a new <see cref="!:EventModel" /> instance.
        /// </summary>
        /// <returns>
        ///     A newly instantiated <see cref="!:EventModel" /> instance.
        /// </returns>
        public static Consensus.Learning.Event Create(ConsensusSite site)
        {
            IBusinessProvider provider = site.GetService<IBusinessProvider>();
            Consensus.Learning.IEventModel model = provider.Learning.Event.Create();
            return model == null ? null : new Consensus.Learning.Event(model);
        }

        /// <summary>
        ///     Retrieves all instances of the <see cref="!:EventModel" /> class.
        /// </summary>
        /// <returns>
        ///     An enumerable collection of <see cref="!:EventModel" /> instances.
        /// </returns>
        public static IEnumerable<Consensus.Learning.Event> FetchAll()
        {
            ConsensusSite site = ConsensusDomain.Configuration[ConsensusDomain.Configuration.DefaultSite];
            return Event.FetchAll(site);
        }

        /// <summary>
        ///     Retrieves all instances of the <see cref="!:EventModel" /> class.
        /// </summary>
        /// <returns>
        ///     An enumerable collection of <see cref="!:EventModel" /> instances.
        /// </returns>
        public static IEnumerable<Consensus.Learning.Event> FetchAll(ConsensusSite site)
        {
            IBusinessProvider provider = site.GetService<IBusinessProvider>();
            IEnumerable<Consensus.Learning.IEventModel> collection = provider.Learning.Event.FetchAll();
            return collection.Select(model => new Consensus.Learning.Event(model));
        }

        /// <summary>
        ///     Retrieves a specific <see cref="!:EventModel" /> instance.
        /// </summary>
        /// <param name="id">
        ///     The unique value which distinctly identifies the <see cref="!:EventModel" /> instance to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:EventModel" /> instance that matches the specified <paramref name="id" />; or null, if no matching instance can be found.
        /// </returns>
        public static Consensus.Learning.Event FetchById(System.String id)
        {
            ConsensusSite site = ConsensusDomain.Configuration[ConsensusDomain.Configuration.DefaultSite];
            return Event.FetchById(site,id);
        }

        /// <summary>
        ///     Retrieves a specific <see cref="!:EventModel" /> instance.
        /// </summary>
        /// <param name="id">
        ///     The unique value which distinctly identifies the <see cref="!:EventModel" /> instance to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:EventModel" /> instance that matches the specified <paramref name="id" />; or null, if no matching instance can be found.
        /// </returns>
        public static Consensus.Learning.Event FetchById(ConsensusSite site, System.String id)
        {
            IBusinessProvider provider = site.GetService<IBusinessProvider>();
            Consensus.Learning.IEventModel model = provider.Learning.Event.FetchById(id);
            return model == null ? null : new Consensus.Learning.Event(model);
        }

        public static System.String GetTableName()
        {
            ConsensusSite site = ConsensusDomain.Configuration[ConsensusDomain.Configuration.DefaultSite];
            return Event.GetTableName(site);
        }

        public static System.String GetTableName(ConsensusSite site)
        {
            IBusinessProvider provider = site.GetService<IBusinessProvider>();
            return provider.Learning.Event.GetTableName();
        }

        /// <summary>
        ///     Retrieves a collection of <see cref="!:EventModel" /> instances.
        /// </summary>
        /// <param name="managerId">
        ///     The value which identifies the <see cref="!:EventModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:EventModel" /> instances that match the specified <paramref name="managerId" />.
        /// </returns>
        public static IEnumerable<Consensus.Learning.Event> FetchAllByManagerId(System.String managerId)
        {
            ConsensusSite site = ConsensusDomain.Configuration[ConsensusDomain.Configuration.DefaultSite];
            return Event.FetchAllByManagerId(site,managerId);
        }

        /// <summary>
        ///     Retrieves a collection of <see cref="!:EventModel" /> instances.
        /// </summary>
        /// <param name="managerId">
        ///     The value which identifies the <see cref="!:EventModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:EventModel" /> instances that match the specified <paramref name="managerId" />.
        /// </returns>
        public static IEnumerable<Consensus.Learning.Event> FetchAllByManagerId(ConsensusSite site, System.String managerId)
        {
            IBusinessProvider provider = site.GetService<IBusinessProvider>();
            IEnumerable<Consensus.Learning.IEventModel> collection = provider.Learning.Event.FetchAllByManagerId(managerId);
            return collection.Select(model => new Consensus.Learning.Event(model));
        }

        /// <summary>
        ///     Retrieves a collection of <see cref="!:EventModel" /> instances.
        /// </summary>
        /// <param name="productId">
        ///     The value which identifies the <see cref="!:EventModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:EventModel" /> instances that match the specified <paramref name="productId" />.
        /// </returns>
        public static IEnumerable<Consensus.Learning.Event> FetchAllByProductId(System.String productId)
        {
            ConsensusSite site = ConsensusDomain.Configuration[ConsensusDomain.Configuration.DefaultSite];
            return Event.FetchAllByProductId(site,productId);
        }

        /// <summary>
        ///     Retrieves a collection of <see cref="!:EventModel" /> instances.
        /// </summary>
        /// <param name="productId">
        ///     The value which identifies the <see cref="!:EventModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:EventModel" /> instances that match the specified <paramref name="productId" />.
        /// </returns>
        public static IEnumerable<Consensus.Learning.Event> FetchAllByProductId(ConsensusSite site, System.String productId)
        {
            IBusinessProvider provider = site.GetService<IBusinessProvider>();
            IEnumerable<Consensus.Learning.IEventModel> collection = provider.Learning.Event.FetchAllByProductId(productId);
            return collection.Select(model => new Consensus.Learning.Event(model));
        }

        /// <summary>
        ///     Retrieves a collection of <see cref="!:EventModel" /> instances.
        /// </summary>
        /// <param name="locationId">
        ///     The value which identifies the <see cref="!:EventModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:EventModel" /> instances that match the specified <paramref name="locationId" />.
        /// </returns>
        public static IEnumerable<Consensus.Learning.Event> FetchAllByLocationId(System.String locationId)
        {
            ConsensusSite site = ConsensusDomain.Configuration[ConsensusDomain.Configuration.DefaultSite];
            return Event.FetchAllByLocationId(site,locationId);
        }

        /// <summary>
        ///     Retrieves a collection of <see cref="!:EventModel" /> instances.
        /// </summary>
        /// <param name="locationId">
        ///     The value which identifies the <see cref="!:EventModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:EventModel" /> instances that match the specified <paramref name="locationId" />.
        /// </returns>
        public static IEnumerable<Consensus.Learning.Event> FetchAllByLocationId(ConsensusSite site, System.String locationId)
        {
            IBusinessProvider provider = site.GetService<IBusinessProvider>();
            IEnumerable<Consensus.Learning.IEventModel> collection = provider.Learning.Event.FetchAllByLocationId(locationId);
            return collection.Select(model => new Consensus.Learning.Event(model));
        }

        /// <summary>
        ///     Retrieves a collection of <see cref="!:EventModel" /> instances.
        /// </summary>
        /// <param name="organisationId">
        ///     The value which identifies the <see cref="!:EventModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:EventModel" /> instances that match the specified <paramref name="organisationId" />.
        /// </returns>
        public static IEnumerable<Consensus.Learning.Event> FetchAllByOrganisationId(System.String organisationId)
        {
            ConsensusSite site = ConsensusDomain.Configuration[ConsensusDomain.Configuration.DefaultSite];
            return Event.FetchAllByOrganisationId(site,organisationId);
        }

        /// <summary>
        ///     Retrieves a collection of <see cref="!:EventModel" /> instances.
        /// </summary>
        /// <param name="organisationId">
        ///     The value which identifies the <see cref="!:EventModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:EventModel" /> instances that match the specified <paramref name="organisationId" />.
        /// </returns>
        public static IEnumerable<Consensus.Learning.Event> FetchAllByOrganisationId(ConsensusSite site, System.String organisationId)
        {
            IBusinessProvider provider = site.GetService<IBusinessProvider>();
            IEnumerable<Consensus.Learning.IEventModel> collection = provider.Learning.Event.FetchAllByOrganisationId(organisationId);
            return collection.Select(model => new Consensus.Learning.Event(model));
        }

        /// <summary>
        ///     Retrieves a collection of <see cref="!:EventModel" /> instances.
        /// </summary>
        /// <param name="notesId">
        ///     The value which identifies the <see cref="!:EventModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:EventModel" /> instances that match the specified <paramref name="notesId" />.
        /// </returns>
        public static IEnumerable<Consensus.Learning.Event> FetchAllByNotesId(System.String notesId)
        {
            ConsensusSite site = ConsensusDomain.Configuration[ConsensusDomain.Configuration.DefaultSite];
            return Event.FetchAllByNotesId(site,notesId);
        }

        /// <summary>
        ///     Retrieves a collection of <see cref="!:EventModel" /> instances.
        /// </summary>
        /// <param name="notesId">
        ///     The value which identifies the <see cref="!:EventModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:EventModel" /> instances that match the specified <paramref name="notesId" />.
        /// </returns>
        public static IEnumerable<Consensus.Learning.Event> FetchAllByNotesId(ConsensusSite site, System.String notesId)
        {
            IBusinessProvider provider = site.GetService<IBusinessProvider>();
            IEnumerable<Consensus.Learning.IEventModel> collection = provider.Learning.Event.FetchAllByNotesId(notesId);
            return collection.Select(model => new Consensus.Learning.Event(model));
        }

        /// <summary>
        ///     Retrieves a collection of <see cref="!:EventModel" /> instances.
        /// </summary>
        /// <param name="commissionedId">
        ///     The value which identifies the <see cref="!:EventModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:EventModel" /> instances that match the specified <paramref name="commissionedId" />.
        /// </returns>
        public static IEnumerable<Consensus.Learning.Event> FetchAllByCommissionedId(System.String commissionedId)
        {
            ConsensusSite site = ConsensusDomain.Configuration[ConsensusDomain.Configuration.DefaultSite];
            return Event.FetchAllByCommissionedId(site,commissionedId);
        }

        /// <summary>
        ///     Retrieves a collection of <see cref="!:EventModel" /> instances.
        /// </summary>
        /// <param name="commissionedId">
        ///     The value which identifies the <see cref="!:EventModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:EventModel" /> instances that match the specified <paramref name="commissionedId" />.
        /// </returns>
        public static IEnumerable<Consensus.Learning.Event> FetchAllByCommissionedId(ConsensusSite site, System.String commissionedId)
        {
            IBusinessProvider provider = site.GetService<IBusinessProvider>();
            IEnumerable<Consensus.Learning.IEventModel> collection = provider.Learning.Event.FetchAllByCommissionedId(commissionedId);
            return collection.Select(model => new Consensus.Learning.Event(model));
        }

        /// <summary>
        ///     Retrieves a collection of <see cref="!:EventModel" /> instances.
        /// </summary>
        /// <param name="opportunityId">
        ///     The value which identifies the <see cref="!:EventModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:EventModel" /> instances that match the specified <paramref name="opportunityId" />.
        /// </returns>
        public static IEnumerable<Consensus.Learning.Event> FetchAllByOpportunityId(System.String opportunityId)
        {
            ConsensusSite site = ConsensusDomain.Configuration[ConsensusDomain.Configuration.DefaultSite];
            return Event.FetchAllByOpportunityId(site,opportunityId);
        }

        /// <summary>
        ///     Retrieves a collection of <see cref="!:EventModel" /> instances.
        /// </summary>
        /// <param name="opportunityId">
        ///     The value which identifies the <see cref="!:EventModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:EventModel" /> instances that match the specified <paramref name="opportunityId" />.
        /// </returns>
        public static IEnumerable<Consensus.Learning.Event> FetchAllByOpportunityId(ConsensusSite site, System.String opportunityId)
        {
            IBusinessProvider provider = site.GetService<IBusinessProvider>();
            IEnumerable<Consensus.Learning.IEventModel> collection = provider.Learning.Event.FetchAllByOpportunityId(opportunityId);
            return collection.Select(model => new Consensus.Learning.Event(model));
        }

        /// <summary>
        ///     Retrieves a collection of <see cref="!:EventModel" /> instances.
        /// </summary>
        /// <param name="addressId">
        ///     The value which identifies the <see cref="!:EventModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:EventModel" /> instances that match the specified <paramref name="addressId" />.
        /// </returns>
        public static IEnumerable<Consensus.Learning.Event> FetchAllByAddressId(System.String addressId)
        {
            ConsensusSite site = ConsensusDomain.Configuration[ConsensusDomain.Configuration.DefaultSite];
            return Event.FetchAllByAddressId(site,addressId);
        }

        /// <summary>
        ///     Retrieves a collection of <see cref="!:EventModel" /> instances.
        /// </summary>
        /// <param name="addressId">
        ///     The value which identifies the <see cref="!:EventModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:EventModel" /> instances that match the specified <paramref name="addressId" />.
        /// </returns>
        public static IEnumerable<Consensus.Learning.Event> FetchAllByAddressId(ConsensusSite site, System.String addressId)
        {
            IBusinessProvider provider = site.GetService<IBusinessProvider>();
            IEnumerable<Consensus.Learning.IEventModel> collection = provider.Learning.Event.FetchAllByAddressId(addressId);
            return collection.Select(model => new Consensus.Learning.Event(model));
        }

        /// <summary>
        ///     Retrieves a collection of <see cref="!:EventModel" /> instances.
        /// </summary>
        /// <param name="commissionedRoleId">
        ///     The value which identifies the <see cref="!:EventModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:EventModel" /> instances that match the specified <paramref name="commissionedRoleId" />.
        /// </returns>
        public static IEnumerable<Consensus.Learning.Event> FetchAllByCommissionedRoleId(System.String commissionedRoleId)
        {
            ConsensusSite site = ConsensusDomain.Configuration[ConsensusDomain.Configuration.DefaultSite];
            return Event.FetchAllByCommissionedRoleId(site,commissionedRoleId);
        }

        /// <summary>
        ///     Retrieves a collection of <see cref="!:EventModel" /> instances.
        /// </summary>
        /// <param name="commissionedRoleId">
        ///     The value which identifies the <see cref="!:EventModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:EventModel" /> instances that match the specified <paramref name="commissionedRoleId" />.
        /// </returns>
        public static IEnumerable<Consensus.Learning.Event> FetchAllByCommissionedRoleId(ConsensusSite site, System.String commissionedRoleId)
        {
            IBusinessProvider provider = site.GetService<IBusinessProvider>();
            IEnumerable<Consensus.Learning.IEventModel> collection = provider.Learning.Event.FetchAllByCommissionedRoleId(commissionedRoleId);
            return collection.Select(model => new Consensus.Learning.Event(model));
        }

        /// <summary>
        ///     Retrieves a collection of <see cref="!:EventModel" /> instances.
        /// </summary>
        /// <param name="sellingCompanyId">
        ///     The value which identifies the <see cref="!:EventModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:EventModel" /> instances that match the specified <paramref name="sellingCompanyId" />.
        /// </returns>
        public static IEnumerable<Consensus.Learning.Event> FetchAllBySellingCompanyId(System.String sellingCompanyId)
        {
            ConsensusSite site = ConsensusDomain.Configuration[ConsensusDomain.Configuration.DefaultSite];
            return Event.FetchAllBySellingCompanyId(site,sellingCompanyId);
        }

        /// <summary>
        ///     Retrieves a collection of <see cref="!:EventModel" /> instances.
        /// </summary>
        /// <param name="sellingCompanyId">
        ///     The value which identifies the <see cref="!:EventModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:EventModel" /> instances that match the specified <paramref name="sellingCompanyId" />.
        /// </returns>
        public static IEnumerable<Consensus.Learning.Event> FetchAllBySellingCompanyId(ConsensusSite site, System.String sellingCompanyId)
        {
            IBusinessProvider provider = site.GetService<IBusinessProvider>();
            IEnumerable<Consensus.Learning.IEventModel> collection = provider.Learning.Event.FetchAllBySellingCompanyId(sellingCompanyId);
            return collection.Select(model => new Consensus.Learning.Event(model));
        }

        /// <summary>
        ///     Retrieves a collection of <see cref="!:EventModel" /> instances.
        /// </summary>
        /// <param name="bookingTermsId">
        ///     The value which identifies the <see cref="!:EventModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:EventModel" /> instances that match the specified <paramref name="bookingTermsId" />.
        /// </returns>
        public static IEnumerable<Consensus.Learning.Event> FetchAllByBookingTermsId(System.String bookingTermsId)
        {
            ConsensusSite site = ConsensusDomain.Configuration[ConsensusDomain.Configuration.DefaultSite];
            return Event.FetchAllByBookingTermsId(site,bookingTermsId);
        }

        /// <summary>
        ///     Retrieves a collection of <see cref="!:EventModel" /> instances.
        /// </summary>
        /// <param name="bookingTermsId">
        ///     The value which identifies the <see cref="!:EventModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:EventModel" /> instances that match the specified <paramref name="bookingTermsId" />.
        /// </returns>
        public static IEnumerable<Consensus.Learning.Event> FetchAllByBookingTermsId(ConsensusSite site, System.String bookingTermsId)
        {
            IBusinessProvider provider = site.GetService<IBusinessProvider>();
            IEnumerable<Consensus.Learning.IEventModel> collection = provider.Learning.Event.FetchAllByBookingTermsId(bookingTermsId);
            return collection.Select(model => new Consensus.Learning.Event(model));
        }

        /// <summary>
        ///     Retrieves a collection of <see cref="!:EventModel" /> instances.
        /// </summary>
        /// <param name="contactId">
        ///     The value which identifies the <see cref="!:EventModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:EventModel" /> instances that match the specified <paramref name="contactId" />.
        /// </returns>
        public static IEnumerable<Consensus.Learning.Event> FetchAllByContactId(System.String contactId)
        {
            ConsensusSite site = ConsensusDomain.Configuration[ConsensusDomain.Configuration.DefaultSite];
            return Event.FetchAllByContactId(site,contactId);
        }

        /// <summary>
        ///     Retrieves a collection of <see cref="!:EventModel" /> instances.
        /// </summary>
        /// <param name="contactId">
        ///     The value which identifies the <see cref="!:EventModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:EventModel" /> instances that match the specified <paramref name="contactId" />.
        /// </returns>
        public static IEnumerable<Consensus.Learning.Event> FetchAllByContactId(ConsensusSite site, System.String contactId)
        {
            IBusinessProvider provider = site.GetService<IBusinessProvider>();
            IEnumerable<Consensus.Learning.IEventModel> collection = provider.Learning.Event.FetchAllByContactId(contactId);
            return collection.Select(model => new Consensus.Learning.Event(model));
        }

        /// <summary>
        ///     Retrieves a collection of <see cref="!:EventModel" /> instances.
        /// </summary>
        /// <param name="supplierOrgId">
        ///     The value which identifies the <see cref="!:EventModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:EventModel" /> instances that match the specified <paramref name="supplierOrgId" />.
        /// </returns>
        public static IEnumerable<Consensus.Learning.Event> FetchAllBySupplierOrgId(System.String supplierOrgId)
        {
            ConsensusSite site = ConsensusDomain.Configuration[ConsensusDomain.Configuration.DefaultSite];
            return Event.FetchAllBySupplierOrgId(site,supplierOrgId);
        }

        /// <summary>
        ///     Retrieves a collection of <see cref="!:EventModel" /> instances.
        /// </summary>
        /// <param name="supplierOrgId">
        ///     The value which identifies the <see cref="!:EventModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:EventModel" /> instances that match the specified <paramref name="supplierOrgId" />.
        /// </returns>
        public static IEnumerable<Consensus.Learning.Event> FetchAllBySupplierOrgId(ConsensusSite site, System.String supplierOrgId)
        {
            IBusinessProvider provider = site.GetService<IBusinessProvider>();
            IEnumerable<Consensus.Learning.IEventModel> collection = provider.Learning.Event.FetchAllBySupplierOrgId(supplierOrgId);
            return collection.Select(model => new Consensus.Learning.Event(model));
        }

        /// <summary>
        ///     Retrieves a collection of <see cref="!:EventModel" /> instances.
        /// </summary>
        /// <param name="supplierRoleId">
        ///     The value which identifies the <see cref="!:EventModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:EventModel" /> instances that match the specified <paramref name="supplierRoleId" />.
        /// </returns>
        public static IEnumerable<Consensus.Learning.Event> FetchAllBySupplierRoleId(System.String supplierRoleId)
        {
            ConsensusSite site = ConsensusDomain.Configuration[ConsensusDomain.Configuration.DefaultSite];
            return Event.FetchAllBySupplierRoleId(site,supplierRoleId);
        }

        /// <summary>
        ///     Retrieves a collection of <see cref="!:EventModel" /> instances.
        /// </summary>
        /// <param name="supplierRoleId">
        ///     The value which identifies the <see cref="!:EventModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:EventModel" /> instances that match the specified <paramref name="supplierRoleId" />.
        /// </returns>
        public static IEnumerable<Consensus.Learning.Event> FetchAllBySupplierRoleId(ConsensusSite site, System.String supplierRoleId)
        {
            IBusinessProvider provider = site.GetService<IBusinessProvider>();
            IEnumerable<Consensus.Learning.IEventModel> collection = provider.Learning.Event.FetchAllBySupplierRoleId(supplierRoleId);
            return collection.Select(model => new Consensus.Learning.Event(model));
        }

        /// <summary>
        ///     Retrieves a collection of <see cref="!:EventModel" /> instances.
        /// </summary>
        /// <param name="fundingOrganisationId">
        ///     The value which identifies the <see cref="!:EventModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:EventModel" /> instances that match the specified <paramref name="fundingOrganisationId" />.
        /// </returns>
        public static IEnumerable<Consensus.Learning.Event> FetchAllByFundingOrganisationId(System.String fundingOrganisationId)
        {
            ConsensusSite site = ConsensusDomain.Configuration[ConsensusDomain.Configuration.DefaultSite];
            return Event.FetchAllByFundingOrganisationId(site,fundingOrganisationId);
        }

        /// <summary>
        ///     Retrieves a collection of <see cref="!:EventModel" /> instances.
        /// </summary>
        /// <param name="fundingOrganisationId">
        ///     The value which identifies the <see cref="!:EventModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:EventModel" /> instances that match the specified <paramref name="fundingOrganisationId" />.
        /// </returns>
        public static IEnumerable<Consensus.Learning.Event> FetchAllByFundingOrganisationId(ConsensusSite site, System.String fundingOrganisationId)
        {
            IBusinessProvider provider = site.GetService<IBusinessProvider>();
            IEnumerable<Consensus.Learning.IEventModel> collection = provider.Learning.Event.FetchAllByFundingOrganisationId(fundingOrganisationId);
            return collection.Select(model => new Consensus.Learning.Event(model));
        }

        /// <summary>
        ///     Retrieves a collection of <see cref="!:EventModel" /> instances.
        /// </summary>
        /// <param name="intNotesId">
        ///     The value which identifies the <see cref="!:EventModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:EventModel" /> instances that match the specified <paramref name="intNotesId" />.
        /// </returns>
        public static IEnumerable<Consensus.Learning.Event> FetchAllByIntNotesId(System.String intNotesId)
        {
            ConsensusSite site = ConsensusDomain.Configuration[ConsensusDomain.Configuration.DefaultSite];
            return Event.FetchAllByIntNotesId(site,intNotesId);
        }

        /// <summary>
        ///     Retrieves a collection of <see cref="!:EventModel" /> instances.
        /// </summary>
        /// <param name="intNotesId">
        ///     The value which identifies the <see cref="!:EventModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:EventModel" /> instances that match the specified <paramref name="intNotesId" />.
        /// </returns>
        public static IEnumerable<Consensus.Learning.Event> FetchAllByIntNotesId(ConsensusSite site, System.String intNotesId)
        {
            IBusinessProvider provider = site.GetService<IBusinessProvider>();
            IEnumerable<Consensus.Learning.IEventModel> collection = provider.Learning.Event.FetchAllByIntNotesId(intNotesId);
            return collection.Select(model => new Consensus.Learning.Event(model));
        }

        /// <summary>
        ///     Retrieves a collection of <see cref="!:EventModel" /> instances.
        /// </summary>
        /// <param name="mainTrainerId">
        ///     The value which identifies the <see cref="!:EventModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:EventModel" /> instances that match the specified <paramref name="mainTrainerId" />.
        /// </returns>
        public static IEnumerable<Consensus.Learning.Event> FetchAllByMainTrainerId(System.String mainTrainerId)
        {
            ConsensusSite site = ConsensusDomain.Configuration[ConsensusDomain.Configuration.DefaultSite];
            return Event.FetchAllByMainTrainerId(site,mainTrainerId);
        }

        /// <summary>
        ///     Retrieves a collection of <see cref="!:EventModel" /> instances.
        /// </summary>
        /// <param name="mainTrainerId">
        ///     The value which identifies the <see cref="!:EventModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:EventModel" /> instances that match the specified <paramref name="mainTrainerId" />.
        /// </returns>
        public static IEnumerable<Consensus.Learning.Event> FetchAllByMainTrainerId(ConsensusSite site, System.String mainTrainerId)
        {
            IBusinessProvider provider = site.GetService<IBusinessProvider>();
            IEnumerable<Consensus.Learning.IEventModel> collection = provider.Learning.Event.FetchAllByMainTrainerId(mainTrainerId);
            return collection.Select(model => new Consensus.Learning.Event(model));
        }

        public static IEnumerable<Consensus.Learning.Event> FetchAllByPayScheduleHeaderId(System.Nullable<System.Int32> payScheduleHeaderId)
        {
            ConsensusSite site = ConsensusDomain.Configuration[ConsensusDomain.Configuration.DefaultSite];
            return Event.FetchAllByPayScheduleHeaderId(site,payScheduleHeaderId);
        }

        public static IEnumerable<Consensus.Learning.Event> FetchAllByPayScheduleHeaderId(ConsensusSite site, System.Nullable<System.Int32> payScheduleHeaderId)
        {
            IBusinessProvider provider = site.GetService<IBusinessProvider>();
            IEnumerable<Consensus.Learning.IEventModel> collection = provider.Learning.Event.FetchAllByPayScheduleHeaderId(payScheduleHeaderId);
            return collection.Select(model => new Consensus.Learning.Event(model));
        }

        #endregion
    }
}
