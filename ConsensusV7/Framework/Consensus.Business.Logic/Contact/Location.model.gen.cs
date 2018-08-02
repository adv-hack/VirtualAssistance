using System;
using System.Collections.Generic;
using System.Linq;
using Consensus.Common;
using Consensus.Learning;

namespace Consensus.Contact
{
    /// <summary>
    ///     Encapsulates the <see cref="LocationRecord" /> with standardised business rules.
    /// </summary>
    /// <remarks>
    ///     THIS CODE HAS BEEN AUTOMATICALLY GENERATED USING THE CONSENSUS DEVELOPER TOOLS.
    ///     DO NOT EDIT THIS CODE AS ANY CUSTOM MODIFICATIONS WILL BE LOST UPON REGENERATION.
    /// </remarks>
    public partial class LocalLocationModel : LocalModel<LocationRecord, String>, ILocationModel
    {
        #region fields

        /// <summary>
        ///     The value of the "LOC_ORG_ID" field.
        /// </summary>
        private LocalOrganisationModel _organisation;

        /// <summary>
        ///     The value of the "LOC_ADD_ID" field.
        /// </summary>
        private LocalAddressModel _address;

        /// <summary>
        ///     The value of the "LOC_SELCO_SP_ID" field.
        /// </summary>
        private LocalSellingCompanyModel _sellingCompany;

        /// <summary>
        ///     The value of the "loc_prole_id" field.
        /// </summary>
        private LocalRoleModel _locationRole;

        /// <summary>
        ///     The value of the "LOC_REGION" field.
        /// </summary>
        private LocalCodeModel _region;

        /// <summary>
        ///     The value of the "LOC_VENUE_TYPE" field.
        /// </summary>
        private LocalCodeModel _venueType;

        /// <summary>
        ///     The value of the "LOC_LINKED_LOC_ID" field.
        /// </summary>
        private LocalLocationModel _linkedLocation;

        /// <summary>
        ///     The collection of <see cref="LocationModel" /> instances that reference this <see cref="LocationModel" />.
        /// </summary>
        private LocalCollection<LocalLocationModel, ILocationModel> _linkedLocations;

        /// <summary>
        ///     The collection of <see cref="ProductModel" /> instances that reference this <see cref="LocationModel" />.
        /// </summary>
        private LocalCollection<LocalProductModel, IProductModel> _product;

        /// <summary>
        ///     The collection of <see cref="EventModel" /> instances that reference this <see cref="LocationModel" />.
        /// </summary>
        private LocalCollection<LocalEventModel, IEventModel> _events;

        /// <summary>
        ///     The collection of <see cref="SessionModel" /> instances that reference this <see cref="LocationModel" />.
        /// </summary>
        private LocalCollection<LocalSessionModel, ISessionModel> _sessionLocation;

        #endregion

        #region properties

        /// <summary>
        ///     Gets the delegated function that is responsible for persisting a new instance of the data structure within the underlying persistence mechanism.
        /// </summary>
        protected override Action<LocationRecord> DataCreator
        {
            get { return this.Provider.DataProvider.Contact.Location.Create; }
        }

        /// <summary>
        ///     Gets the delegated function that is responsible for persisting an existing instance of the data structure within the underlying persistence mechanism.
        /// </summary>
        protected override Action<LocationRecord> DataModifier
        {
            get { return this.Provider.DataProvider.Contact.Location.Modify; }
        }

        /// <summary>
        ///     Gets the delegated function that is responsible for removing an existing instance of the data structure from the underlying persistence mechanism.
        /// </summary>
        protected override Action<LocationRecord> DataRemover
        {
            get { return this.Provider.DataProvider.Contact.Location.RemoveById; }
        }

        /// <summary>
        ///     Gets the The value of the "LOC_ORG_ID" field.
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
        ///     Gets or sets the unique code for the value of the "LOC_ORG_ID" field.
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
        ///     Gets the The value of the "LOC_ADD_ID" field.
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
        ///     Gets or sets the unique code for the value of the "LOC_ADD_ID" field.
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
        ///     Gets or sets the value of the "LOC_REF" field.
        /// </summary>
        public String Ref
        {
            get { return this.ModifiedData.Ref; }
            set { this.ModifiedData.Ref = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "LOC_NAME" field.
        /// </summary>
        public String Name
        {
            get { return this.ModifiedData.Name; }
            set { this.ModifiedData.Name = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "LOC_EXTERNAL" field.
        /// </summary>
        public Byte? External
        {
            get { return this.ModifiedData.External; }
            set { this.ModifiedData.External = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "LOC_CONTACT_NAME" field.
        /// </summary>
        public String ContactName
        {
            get { return this.ModifiedData.ContactName; }
            set { this.ModifiedData.ContactName = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "LOC_COST_PER_DAY" field.
        /// </summary>
        public Double? CostPerDay
        {
            get { return this.ModifiedData.CostPerDay; }
            set { this.ModifiedData.CostPerDay = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "LOC_MAX_PLACES" field.
        /// </summary>
        public Double? MaxPlaces
        {
            get { return this.ModifiedData.MaxPlaces; }
            set { this.ModifiedData.MaxPlaces = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "LOC_SIZE" field.
        /// </summary>
        public String Size
        {
            get { return this.ModifiedData.Size; }
            set { this.ModifiedData.Size = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "LOC_BEDROOM" field.
        /// </summary>
        public Byte? Bedroom
        {
            get { return this.ModifiedData.Bedroom; }
            set { this.ModifiedData.Bedroom = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "LOC_ROOM_TYPE" field.
        /// </summary>
        public String RoomType
        {
            get { return this.ModifiedData.RoomType; }
            set { this.ModifiedData.RoomType = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "LOC_ROOM_GRADE" field.
        /// </summary>
        public String RoomGrade
        {
            get { return this.ModifiedData.RoomGrade; }
            set { this.ModifiedData.RoomGrade = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "LOC_DIRECTION" field.
        /// </summary>
        public String Direction
        {
            get { return this.ModifiedData.Direction; }
            set { this.ModifiedData.Direction = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "LOC_HTML" field.
        /// </summary>
        public String Html
        {
            get { return this.ModifiedData.Html; }
            set { this.ModifiedData.Html = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "LOC_URL" field.
        /// </summary>
        public String Url
        {
            get { return this.ModifiedData.Url; }
            set { this.ModifiedData.Url = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "LOC_MAP_FILE" field.
        /// </summary>
        public String MapFile
        {
            get { return this.ModifiedData.MapFile; }
            set { this.ModifiedData.MapFile = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "LOC_OUR_LOCATION" field.
        /// </summary>
        public Byte? OurLocation
        {
            get { return this.ModifiedData.OurLocation; }
            set { this.ModifiedData.OurLocation = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "LOC_TRAIN_PROVIDER" field.
        /// </summary>
        public Byte? TrainProvider
        {
            get { return this.ModifiedData.TrainProvider; }
            set { this.ModifiedData.TrainProvider = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "LOC_TRAIN_LOCATION" field.
        /// </summary>
        public Byte? TrainLocation
        {
            get { return this.ModifiedData.TrainLocation; }
            set { this.ModifiedData.TrainLocation = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "LOC_HOTEL" field.
        /// </summary>
        public Byte? Hotel
        {
            get { return this.ModifiedData.Hotel; }
            set { this.ModifiedData.Hotel = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "LOC_DIRECTIONS" field.
        /// </summary>
        public String Directions
        {
            get { return this.ModifiedData.Directions; }
            set { this.ModifiedData.Directions = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "LOC_NOTES" field.
        /// </summary>
        public String Notes
        {
            get { return this.ModifiedData.Notes; }
            set { this.ModifiedData.Notes = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "LOC_MAP_NAME" field.
        /// </summary>
        public String MapName
        {
            get { return this.ModifiedData.MapName; }
            set { this.ModifiedData.MapName = value; }
        }

        /// <summary>
        ///     Gets the The value of the "LOC_SELCO_SP_ID" field.
        /// </summary>
        public LocalSellingCompanyModel SellingCompany
        {
            get
            {
                if (_sellingCompany == null)
                    _sellingCompany = this.Provider.Common.SellingCompany.FetchById(this.SellingCompanyId);
                if (_sellingCompany == null)
                    _sellingCompany = this.Provider.Common.SellingCompany.Create();
                
                return _sellingCompany;
            }
        }

        /// <summary>
        ///     Gets or sets the unique code for the value of the "LOC_SELCO_SP_ID" field.
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
        ///     Gets the The value of the "loc_prole_id" field.
        /// </summary>
        public LocalRoleModel LocationRole
        {
            get
            {
                if (_locationRole == null && this.LocationRoleId != null)
                    _locationRole = this.Provider.Contact.Role.FetchById(this.LocationRoleId);
                if (_locationRole == null)
                    _locationRole = this.Provider.Contact.Role.Create();
                
                return _locationRole;
            }
        }

        /// <summary>
        ///     Gets or sets the unique code for the value of the "loc_prole_id" field.
        /// </summary>
        public String LocationRoleId
        {
            get { return this.ModifiedData.LocProleId; }
            set
            {
                if (this.ModifiedData.LocProleId != value)
                     _locationRole = null;
                this.ModifiedData.LocProleId = value;
            }
        }

        /// <summary>
        ///     Gets or sets the value of the "loc_phone" field.
        /// </summary>
        public String LocationPhone
        {
            get { return this.ModifiedData.LocPhone; }
            set { this.ModifiedData.LocPhone = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "loc_fax" field.
        /// </summary>
        public String LocationFax
        {
            get { return this.ModifiedData.LocFax; }
            set { this.ModifiedData.LocFax = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "loc_phone_std" field.
        /// </summary>
        public String LocPhoneStd
        {
            get { return this.ModifiedData.LocPhoneStd; }
            set { this.ModifiedData.LocPhoneStd = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "loc_fax_std" field.
        /// </summary>
        public String LocFaxStd
        {
            get { return this.ModifiedData.LocFaxStd; }
            set { this.ModifiedData.LocFaxStd = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "loc_email" field.
        /// </summary>
        public String LocationEmail
        {
            get { return this.ModifiedData.LocEmail; }
            set { this.ModifiedData.LocEmail = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "LOC_MAP_IMAGE_PATH" field.
        /// </summary>
        public String MapImagePath
        {
            get { return this.ModifiedData.MapImagePath; }
            set { this.ModifiedData.MapImagePath = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "LOC_DETAILS_PATH" field.
        /// </summary>
        public String DetailsPath
        {
            get { return this.ModifiedData.DetailsPath; }
            set { this.ModifiedData.DetailsPath = value; }
        }

        /// <summary>
        ///     Gets the The value of the "LOC_REGION" field.
        /// </summary>
        public LocalCodeModel Region
        {
            get
            {
                if (_region == null && !String.IsNullOrEmpty(this.RegionCode))
                    _region = this.Provider.Common.Code.FetchByTypeAndCode("ROREG", this.RegionCode);
                if (_region == null)
                    _region = this.Provider.Common.Code.Create("ROREG");
                return _region;
            }
        }

        /// <summary>
        ///     Gets or sets the unique code for the value of the "LOC_REGION" field.
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
        ///     Gets or sets the value of the "LOC_COST_CODE" field.
        /// </summary>
        public String CostCode
        {
            get { return this.ModifiedData.CostCode; }
            set { this.ModifiedData.CostCode = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "LOC_REV_CODE" field.
        /// </summary>
        public String RevCode
        {
            get { return this.ModifiedData.RevCode; }
            set { this.ModifiedData.RevCode = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "LOC_WEB" field.
        /// </summary>
        public Byte WebEnabled
        {
            get { return this.ModifiedData.Web; }
            set { this.ModifiedData.Web = value; }
        }

        /// <summary>
        ///     Gets the The value of the "LOC_VENUE_TYPE" field.
        /// </summary>
        public LocalCodeModel VenueType
        {
            get
            {
                if (_venueType == null && !String.IsNullOrEmpty(this.VenueTypeCode))
                    _venueType = this.Provider.Common.Code.FetchByTypeAndCode("VNTYP", this.VenueTypeCode);
                if (_venueType == null)
                    _venueType = this.Provider.Common.Code.Create("VNTYP");
                return _venueType;
            }
        }

        /// <summary>
        ///     Gets or sets the unique code for the value of the "LOC_VENUE_TYPE" field.
        /// </summary>
        public String VenueTypeCode
        {
            get { return this.ModifiedData.VenueType; }
            set
            {
                if (this.ModifiedData.VenueType != value)
                     _venueType = null;
                this.ModifiedData.VenueType = value;
            }
        }

        /// <summary>
        ///     Gets the The value of the "LOC_LINKED_LOC_ID" field.
        /// </summary>
        public LocalLocationModel LinkedLocation
        {
            get
            {
                if (_linkedLocation == null && this.LinkedLocationId != null)
                    _linkedLocation = this.Provider.Contact.Location.FetchById(this.LinkedLocationId);
                if (_linkedLocation == null)
                    _linkedLocation = this.Provider.Contact.Location.Create();
                
                return _linkedLocation;
            }
        }

        /// <summary>
        ///     Gets or sets the unique code for the value of the "LOC_LINKED_LOC_ID" field.
        /// </summary>
        public String LinkedLocationId
        {
            get { return this.ModifiedData.LinkedLocId; }
            set
            {
                if (this.ModifiedData.LinkedLocId != value)
                     _linkedLocation = null;
                this.ModifiedData.LinkedLocId = value;
            }
        }

        /// <summary>
        ///     Gets or sets the value of the "LOC_TITLE" field.
        /// </summary>
        public String Title
        {
            get { return this.ModifiedData.Title; }
            set { this.ModifiedData.Title = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "LOC_DESCRIPTION" field.
        /// </summary>
        public String Description
        {
            get { return this.ModifiedData.Description; }
            set { this.ModifiedData.Description = value; }
        }

        /// <summary>
        ///     Gets the collection of <see cref="LocationModel" /> instances that reference this <see cref="LocationModel" />.
        /// </summary>
        public LocalCollection<LocalLocationModel, ILocationModel> LinkedLocations
        {
            get
            {
                if (_linkedLocations == null)
                    _linkedLocations = new LocalCollection<LocalLocationModel, ILocationModel>(this.Provider.Contact.Location.FetchAllByLinkedLocationId(this.Id));
                
                return _linkedLocations;
            }
        }

        /// <summary>
        ///     Gets the collection of <see cref="ProductModel" /> instances that reference this <see cref="LocationModel" />.
        /// </summary>
        public LocalCollection<LocalProductModel, IProductModel> Product
        {
            get
            {
                if (_product == null)
                    _product = new LocalCollection<LocalProductModel, IProductModel>(this.Provider.Learning.Product.FetchAllByLocationId(this.Id));
                
                return _product;
            }
        }

        /// <summary>
        ///     Gets the collection of <see cref="EventModel" /> instances that reference this <see cref="LocationModel" />.
        /// </summary>
        [NonSerializedAttribute]
        public LocalCollection<LocalEventModel, IEventModel> Events
        {
            get
            {
                if (_events == null)
                    _events = new LocalCollection<LocalEventModel, IEventModel>(this.Provider.Learning.Event.FetchAllByLocationId(this.Id));
                
                return _events;
            }
        }

        /// <summary>
        ///     Gets the collection of <see cref="SessionModel" /> instances that reference this <see cref="LocationModel" />.
        /// </summary>
        public LocalCollection<LocalSessionModel, ISessionModel> SessionLocation
        {
            get
            {
                if (_sessionLocation == null)
                    _sessionLocation = new LocalCollection<LocalSessionModel, ISessionModel>(this.Provider.Learning.Session.FetchAllByLocationId(this.Id));
                
                return _sessionLocation;
            }
        }

        #endregion

        #region constructors

        /// <summary>
        ///     Initialises a new <see cref="LocalLocationModel" /> instance.
        /// </summary>
        /// <param name="provider">
        ///     The business provider to which the business model is bound.
        /// </param>
        internal LocalLocationModel(LocalProvider provider) : base(provider)
        {
        }

        /// <summary>
        ///     Initialises a new <see cref="LocalLocationModel" /> instance.
        /// </summary>
        /// <param name="provider">
        ///     The business provider to which the business model is bound.
        /// </param>
        /// <param name="record">
        ///     The data record which is encapsulated by the business model.
        /// </param>
        internal LocalLocationModel(LocalProvider provider, LocationRecord record) : base(provider, record)
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
            if (_region != null)
            {
                _region.Save();
                this.ModifiedData.Region = _region.Value1;
            }
            if (_venueType != null)
            {
                _venueType.Save();
                this.ModifiedData.VenueType = _venueType.Value1;
            }
            if (_organisation != null)
            {
                _organisation.Save();
                this.ModifiedData.OrgId = _organisation.Id == null && this.ModifiedData.OrgId != null ? "" : _organisation.Id;
            }
            if (_address != null)
            {
                _address.Save();
                this.ModifiedData.AddId = _address.Id == null && this.ModifiedData.AddId != null ? "" : _address.Id;
            }
            if (_sellingCompany != null)
            {
                _sellingCompany.Save();
                this.ModifiedData.SelcoSpId = _sellingCompany.Id == null && this.ModifiedData.SelcoSpId != null ? "" : _sellingCompany.Id;
            }
            if (_locationRole != null)
            {
                _locationRole.Save();
                this.ModifiedData.LocProleId = _locationRole.Id == null && this.ModifiedData.LocProleId != null ? "" : _locationRole.Id;
            }
            if (_linkedLocation != null)
            {
                _linkedLocation.Save();
                this.ModifiedData.LinkedLocId = _linkedLocation.Id == null && this.ModifiedData.LinkedLocId != null ? "" : _linkedLocation.Id;
            }
        }

        /// <summary>
        ///     Resolves the dependent models by means of updating all models that reference this model.
        /// </summary>
        protected override void ResolveGeneratedDependent()
        {
            base.ResolveGeneratedDependent();
            if (_linkedLocations != null)
                _linkedLocations.Execute(obj => obj.LinkedLocationId = this.Id).Execute(obj => obj.Save());
            if (_product != null)
                _product.Execute(obj => obj.LocationId = this.Id).Execute(obj => obj.Save());
            if (_events != null)
                _events.Execute(obj => obj.LocationId = this.Id).Execute(obj => obj.Save());
            if (_sessionLocation != null)
                _sessionLocation.Execute(obj => obj.LocationId = this.Id).Execute(obj => obj.Save());
        }

        #endregion

        #region implementations

        /// <summary>
        ///     Gets the The value of the "LOC_ORG_ID" field.
        /// </summary>
        Consensus.Contact.IOrganisationModel ILocationModel.Organisation
        {
            get { return this.Organisation; }
        }

        /// <summary>
        ///     Gets or sets the unique code for the value of the "LOC_ORG_ID" field.
        /// </summary>
        System.String ILocationModel.OrganisationId
        {
            get { return this.OrganisationId; }
            set { this.OrganisationId = (System.String)value; }
        }

        /// <summary>
        ///     Gets the The value of the "LOC_ADD_ID" field.
        /// </summary>
        Consensus.Contact.IAddressModel ILocationModel.Address
        {
            get { return this.Address; }
        }

        /// <summary>
        ///     Gets or sets the unique code for the value of the "LOC_ADD_ID" field.
        /// </summary>
        System.String ILocationModel.AddressId
        {
            get { return this.AddressId; }
            set { this.AddressId = (System.String)value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "LOC_REF" field.
        /// </summary>
        System.String ILocationModel.Ref
        {
            get { return this.Ref; }
            set { this.Ref = (System.String)value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "LOC_NAME" field.
        /// </summary>
        System.String ILocationModel.Name
        {
            get { return this.Name; }
            set { this.Name = (System.String)value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "LOC_EXTERNAL" field.
        /// </summary>
        System.Nullable<System.Byte> ILocationModel.External
        {
            get { return this.External; }
            set { this.External = (System.Nullable<System.Byte>)value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "LOC_CONTACT_NAME" field.
        /// </summary>
        System.String ILocationModel.ContactName
        {
            get { return this.ContactName; }
            set { this.ContactName = (System.String)value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "LOC_COST_PER_DAY" field.
        /// </summary>
        System.Nullable<System.Double> ILocationModel.CostPerDay
        {
            get { return this.CostPerDay; }
            set { this.CostPerDay = (System.Nullable<System.Double>)value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "LOC_MAX_PLACES" field.
        /// </summary>
        System.Nullable<System.Double> ILocationModel.MaxPlaces
        {
            get { return this.MaxPlaces; }
            set { this.MaxPlaces = (System.Nullable<System.Double>)value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "LOC_SIZE" field.
        /// </summary>
        System.String ILocationModel.Size
        {
            get { return this.Size; }
            set { this.Size = (System.String)value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "LOC_BEDROOM" field.
        /// </summary>
        System.Nullable<System.Byte> ILocationModel.Bedroom
        {
            get { return this.Bedroom; }
            set { this.Bedroom = (System.Nullable<System.Byte>)value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "LOC_ROOM_TYPE" field.
        /// </summary>
        System.String ILocationModel.RoomType
        {
            get { return this.RoomType; }
            set { this.RoomType = (System.String)value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "LOC_ROOM_GRADE" field.
        /// </summary>
        System.String ILocationModel.RoomGrade
        {
            get { return this.RoomGrade; }
            set { this.RoomGrade = (System.String)value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "LOC_DIRECTION" field.
        /// </summary>
        System.String ILocationModel.Direction
        {
            get { return this.Direction; }
            set { this.Direction = (System.String)value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "LOC_HTML" field.
        /// </summary>
        System.String ILocationModel.Html
        {
            get { return this.Html; }
            set { this.Html = (System.String)value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "LOC_URL" field.
        /// </summary>
        System.String ILocationModel.Url
        {
            get { return this.Url; }
            set { this.Url = (System.String)value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "LOC_MAP_FILE" field.
        /// </summary>
        System.String ILocationModel.MapFile
        {
            get { return this.MapFile; }
            set { this.MapFile = (System.String)value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "LOC_OUR_LOCATION" field.
        /// </summary>
        System.Nullable<System.Byte> ILocationModel.OurLocation
        {
            get { return this.OurLocation; }
            set { this.OurLocation = (System.Nullable<System.Byte>)value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "LOC_TRAIN_PROVIDER" field.
        /// </summary>
        System.Nullable<System.Byte> ILocationModel.TrainProvider
        {
            get { return this.TrainProvider; }
            set { this.TrainProvider = (System.Nullable<System.Byte>)value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "LOC_TRAIN_LOCATION" field.
        /// </summary>
        System.Nullable<System.Byte> ILocationModel.TrainLocation
        {
            get { return this.TrainLocation; }
            set { this.TrainLocation = (System.Nullable<System.Byte>)value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "LOC_HOTEL" field.
        /// </summary>
        System.Nullable<System.Byte> ILocationModel.Hotel
        {
            get { return this.Hotel; }
            set { this.Hotel = (System.Nullable<System.Byte>)value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "LOC_DIRECTIONS" field.
        /// </summary>
        System.String ILocationModel.Directions
        {
            get { return this.Directions; }
            set { this.Directions = (System.String)value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "LOC_NOTES" field.
        /// </summary>
        System.String ILocationModel.Notes
        {
            get { return this.Notes; }
            set { this.Notes = (System.String)value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "LOC_MAP_NAME" field.
        /// </summary>
        System.String ILocationModel.MapName
        {
            get { return this.MapName; }
            set { this.MapName = (System.String)value; }
        }

        /// <summary>
        ///     Gets the The value of the "LOC_SELCO_SP_ID" field.
        /// </summary>
        Consensus.Common.ISellingCompanyModel ILocationModel.SellingCompany
        {
            get { return this.SellingCompany; }
        }

        /// <summary>
        ///     Gets or sets the unique code for the value of the "LOC_SELCO_SP_ID" field.
        /// </summary>
        System.String ILocationModel.SellingCompanyId
        {
            get { return this.SellingCompanyId; }
            set { this.SellingCompanyId = (System.String)value; }
        }

        /// <summary>
        ///     Gets the The value of the "loc_prole_id" field.
        /// </summary>
        Consensus.Contact.IRoleModel ILocationModel.LocationRole
        {
            get { return this.LocationRole; }
        }

        /// <summary>
        ///     Gets or sets the unique code for the value of the "loc_prole_id" field.
        /// </summary>
        System.String ILocationModel.LocationRoleId
        {
            get { return this.LocationRoleId; }
            set { this.LocationRoleId = (System.String)value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "loc_phone" field.
        /// </summary>
        System.String ILocationModel.LocationPhone
        {
            get { return this.LocationPhone; }
            set { this.LocationPhone = (System.String)value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "loc_fax" field.
        /// </summary>
        System.String ILocationModel.LocationFax
        {
            get { return this.LocationFax; }
            set { this.LocationFax = (System.String)value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "loc_phone_std" field.
        /// </summary>
        System.String ILocationModel.LocPhoneStd
        {
            get { return this.LocPhoneStd; }
            set { this.LocPhoneStd = (System.String)value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "loc_fax_std" field.
        /// </summary>
        System.String ILocationModel.LocFaxStd
        {
            get { return this.LocFaxStd; }
            set { this.LocFaxStd = (System.String)value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "loc_email" field.
        /// </summary>
        System.String ILocationModel.LocationEmail
        {
            get { return this.LocationEmail; }
            set { this.LocationEmail = (System.String)value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "LOC_MAP_IMAGE_PATH" field.
        /// </summary>
        System.String ILocationModel.MapImagePath
        {
            get { return this.MapImagePath; }
            set { this.MapImagePath = (System.String)value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "LOC_DETAILS_PATH" field.
        /// </summary>
        System.String ILocationModel.DetailsPath
        {
            get { return this.DetailsPath; }
            set { this.DetailsPath = (System.String)value; }
        }

        /// <summary>
        ///     Gets the The value of the "LOC_REGION" field.
        /// </summary>
        Consensus.Common.ICodeModel ILocationModel.Region
        {
            get { return this.Region; }
        }

        /// <summary>
        ///     Gets or sets the unique code for the value of the "LOC_REGION" field.
        /// </summary>
        System.String ILocationModel.RegionCode
        {
            get { return this.RegionCode; }
            set { this.RegionCode = (System.String)value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "LOC_COST_CODE" field.
        /// </summary>
        System.String ILocationModel.CostCode
        {
            get { return this.CostCode; }
            set { this.CostCode = (System.String)value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "LOC_REV_CODE" field.
        /// </summary>
        System.String ILocationModel.RevCode
        {
            get { return this.RevCode; }
            set { this.RevCode = (System.String)value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "LOC_WEB" field.
        /// </summary>
        System.Byte ILocationModel.WebEnabled
        {
            get { return this.WebEnabled; }
            set { this.WebEnabled = (System.Byte)value; }
        }

        /// <summary>
        ///     Gets the The value of the "LOC_VENUE_TYPE" field.
        /// </summary>
        Consensus.Common.ICodeModel ILocationModel.VenueType
        {
            get { return this.VenueType; }
        }

        /// <summary>
        ///     Gets or sets the unique code for the value of the "LOC_VENUE_TYPE" field.
        /// </summary>
        System.String ILocationModel.VenueTypeCode
        {
            get { return this.VenueTypeCode; }
            set { this.VenueTypeCode = (System.String)value; }
        }

        /// <summary>
        ///     Gets the The value of the "LOC_LINKED_LOC_ID" field.
        /// </summary>
        Consensus.Contact.ILocationModel ILocationModel.LinkedLocation
        {
            get { return this.LinkedLocation; }
        }

        /// <summary>
        ///     Gets or sets the unique code for the value of the "LOC_LINKED_LOC_ID" field.
        /// </summary>
        System.String ILocationModel.LinkedLocationId
        {
            get { return this.LinkedLocationId; }
            set { this.LinkedLocationId = (System.String)value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "LOC_TITLE" field.
        /// </summary>
        System.String ILocationModel.Title
        {
            get { return this.Title; }
            set { this.Title = (System.String)value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "LOC_DESCRIPTION" field.
        /// </summary>
        System.String ILocationModel.Description
        {
            get { return this.Description; }
            set { this.Description = (System.String)value; }
        }

        /// <summary>
        ///     Gets the collection of <see cref="!:LocationModel" /> instances that reference this <see cref="!:LocationModel" />.
        /// </summary>
        Consensus.Collection<Consensus.Contact.ILocationModel> ILocationModel.LinkedLocations
        {
            get { return this.LinkedLocations; }
        }

        /// <summary>
        ///     Gets the collection of <see cref="!:ProductModel" /> instances that reference this <see cref="!:LocationModel" />.
        /// </summary>
        Consensus.Collection<Consensus.Learning.IProductModel> ILocationModel.Product
        {
            get { return this.Product; }
        }

        /// <summary>
        ///     Gets the collection of <see cref="!:EventModel" /> instances that reference this <see cref="!:LocationModel" />.
        /// </summary>
        [NonSerializedAttribute]
        Consensus.Collection<Consensus.Learning.IEventModel> ILocationModel.Events
        {
            get { return this.Events; }
        }

        /// <summary>
        ///     Gets the collection of <see cref="!:SessionModel" /> instances that reference this <see cref="!:LocationModel" />.
        /// </summary>
        Consensus.Collection<Consensus.Learning.ISessionModel> ILocationModel.SessionLocation
        {
            get { return this.SessionLocation; }
        }

        #endregion
    }
}
