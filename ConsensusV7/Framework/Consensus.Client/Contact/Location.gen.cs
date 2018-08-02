using System;
using System.Collections.Generic;
using System.Linq;
using Consensus.Common;
using Consensus.Learning;

namespace Consensus.Contact
{
    /// <remarks>
    ///     THIS CODE HAS BEEN AUTOMATICALLY GENERATED USING THE CONSENSUS DEVELOPER TOOLS.
    ///     DO NOT EDIT THIS CODE AS ANY CUSTOM MODIFICATIONS WILL BE LOST UPON REGENERATION.
    /// </remarks>
    public partial class Location : Proxy<ILocationModel, String>
    {
        #region fields

        /// <summary>
        ///     The client-consumable proxy instance for the <see cref="Organisation" /> member.
        /// </summary>
        private Consensus.Contact.Organisation _organisation;

        /// <summary>
        ///     The client-consumable proxy instance for the <see cref="Address" /> member.
        /// </summary>
        private Consensus.Contact.Address _address;

        /// <summary>
        ///     The client-consumable proxy instance for the <see cref="SellingCompany" /> member.
        /// </summary>
        private Consensus.Common.SellingCompany _sellingCompany;

        /// <summary>
        ///     The client-consumable proxy instance for the <see cref="LocationRole" /> member.
        /// </summary>
        private Consensus.Contact.Role _locationRole;

        /// <summary>
        ///     The client-consumable proxy instance for the <see cref="Region" /> member.
        /// </summary>
        private Consensus.Common.Code _region;

        /// <summary>
        ///     The client-consumable proxy instance for the <see cref="VenueType" /> member.
        /// </summary>
        private Consensus.Common.Code _venueType;

        /// <summary>
        ///     The client-consumable proxy instance for the <see cref="LinkedLocation" /> member.
        /// </summary>
        private Consensus.Contact.Location _linkedLocation;

        /// <summary>
        ///     The client-consumable proxy collection for the <see cref="LinkedLocations" /> member.
        /// </summary>
        private ProxyCollection<Consensus.Contact.Location, Consensus.Contact.ILocationModel> _linkedLocations;

        /// <summary>
        ///     The client-consumable proxy collection for the <see cref="Product" /> member.
        /// </summary>
        private ProxyCollection<Consensus.Learning.Product, Consensus.Learning.IProductModel> _product;

        /// <summary>
        ///     The client-consumable proxy collection for the <see cref="Events" /> member.
        /// </summary>
        private ProxyCollection<Consensus.Learning.Event, Consensus.Learning.IEventModel> _events;

        /// <summary>
        ///     The client-consumable proxy collection for the <see cref="SessionLocation" /> member.
        /// </summary>
        private ProxyCollection<Consensus.Learning.Session, Consensus.Learning.ISessionModel> _sessionLocation;

        #endregion

        #region properties

        /// <summary>
        ///     Gets the The value of the "LOC_ORG_ID" field.
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
        ///     Gets or sets the unique code for the value of the "LOC_ORG_ID" field.
        /// </summary>
        public System.String OrganisationId
        {
            get { return this.Model.OrganisationId; }
            set { this.Model.OrganisationId = value; }
        }

        /// <summary>
        ///     Gets the The value of the "LOC_ADD_ID" field.
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
        ///     Gets or sets the unique code for the value of the "LOC_ADD_ID" field.
        /// </summary>
        public System.String AddressId
        {
            get { return this.Model.AddressId; }
            set { this.Model.AddressId = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "LOC_REF" field.
        /// </summary>
        public System.String Ref
        {
            get { return this.Model.Ref; }
            set { this.Model.Ref = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "LOC_NAME" field.
        /// </summary>
        public System.String Name
        {
            get { return this.Model.Name; }
            set { this.Model.Name = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "LOC_EXTERNAL" field.
        /// </summary>
        public System.Nullable<System.Byte> External
        {
            get { return this.Model.External; }
            set { this.Model.External = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "LOC_CONTACT_NAME" field.
        /// </summary>
        public System.String ContactName
        {
            get { return this.Model.ContactName; }
            set { this.Model.ContactName = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "LOC_COST_PER_DAY" field.
        /// </summary>
        public System.Nullable<System.Double> CostPerDay
        {
            get { return this.Model.CostPerDay; }
            set { this.Model.CostPerDay = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "LOC_MAX_PLACES" field.
        /// </summary>
        public System.Nullable<System.Double> MaxPlaces
        {
            get { return this.Model.MaxPlaces; }
            set { this.Model.MaxPlaces = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "LOC_SIZE" field.
        /// </summary>
        public System.String Size
        {
            get { return this.Model.Size; }
            set { this.Model.Size = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "LOC_BEDROOM" field.
        /// </summary>
        public System.Nullable<System.Byte> Bedroom
        {
            get { return this.Model.Bedroom; }
            set { this.Model.Bedroom = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "LOC_ROOM_TYPE" field.
        /// </summary>
        public System.String RoomType
        {
            get { return this.Model.RoomType; }
            set { this.Model.RoomType = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "LOC_ROOM_GRADE" field.
        /// </summary>
        public System.String RoomGrade
        {
            get { return this.Model.RoomGrade; }
            set { this.Model.RoomGrade = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "LOC_DIRECTION" field.
        /// </summary>
        public System.String Direction
        {
            get { return this.Model.Direction; }
            set { this.Model.Direction = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "LOC_HTML" field.
        /// </summary>
        public System.String Html
        {
            get { return this.Model.Html; }
            set { this.Model.Html = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "LOC_URL" field.
        /// </summary>
        public System.String Url
        {
            get { return this.Model.Url; }
            set { this.Model.Url = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "LOC_MAP_FILE" field.
        /// </summary>
        public System.String MapFile
        {
            get { return this.Model.MapFile; }
            set { this.Model.MapFile = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "LOC_OUR_LOCATION" field.
        /// </summary>
        public System.Nullable<System.Byte> OurLocation
        {
            get { return this.Model.OurLocation; }
            set { this.Model.OurLocation = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "LOC_TRAIN_PROVIDER" field.
        /// </summary>
        public System.Nullable<System.Byte> TrainProvider
        {
            get { return this.Model.TrainProvider; }
            set { this.Model.TrainProvider = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "LOC_TRAIN_LOCATION" field.
        /// </summary>
        public System.Nullable<System.Byte> TrainLocation
        {
            get { return this.Model.TrainLocation; }
            set { this.Model.TrainLocation = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "LOC_HOTEL" field.
        /// </summary>
        public System.Nullable<System.Byte> Hotel
        {
            get { return this.Model.Hotel; }
            set { this.Model.Hotel = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "LOC_DIRECTIONS" field.
        /// </summary>
        public System.String Directions
        {
            get { return this.Model.Directions; }
            set { this.Model.Directions = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "LOC_NOTES" field.
        /// </summary>
        public System.String Notes
        {
            get { return this.Model.Notes; }
            set { this.Model.Notes = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "LOC_MAP_NAME" field.
        /// </summary>
        public System.String MapName
        {
            get { return this.Model.MapName; }
            set { this.Model.MapName = value; }
        }

        /// <summary>
        ///     Gets the The value of the "LOC_SELCO_SP_ID" field.
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
        ///     Gets or sets the unique code for the value of the "LOC_SELCO_SP_ID" field.
        /// </summary>
        public System.String SellingCompanyId
        {
            get { return this.Model.SellingCompanyId; }
            set { this.Model.SellingCompanyId = value; }
        }

        /// <summary>
        ///     Gets the The value of the "loc_prole_id" field.
        /// </summary>
        public Consensus.Contact.Role LocationRole
        {
            get
            {
                if (_locationRole == null && this.Model.LocationRole != null)
                    _locationRole = new Consensus.Contact.Role(this.Model.LocationRole);
                if (_locationRole == null)
                    _locationRole = Consensus.Contact.Role.Create();
                return _locationRole;
            }
        }

        /// <summary>
        ///     Gets or sets the unique code for the value of the "loc_prole_id" field.
        /// </summary>
        public System.String LocationRoleId
        {
            get { return this.Model.LocationRoleId; }
            set { this.Model.LocationRoleId = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "loc_phone" field.
        /// </summary>
        public System.String LocationPhone
        {
            get { return this.Model.LocationPhone; }
            set { this.Model.LocationPhone = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "loc_fax" field.
        /// </summary>
        public System.String LocationFax
        {
            get { return this.Model.LocationFax; }
            set { this.Model.LocationFax = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "loc_phone_std" field.
        /// </summary>
        public System.String LocPhoneStd
        {
            get { return this.Model.LocPhoneStd; }
            set { this.Model.LocPhoneStd = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "loc_fax_std" field.
        /// </summary>
        public System.String LocFaxStd
        {
            get { return this.Model.LocFaxStd; }
            set { this.Model.LocFaxStd = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "loc_email" field.
        /// </summary>
        public System.String LocationEmail
        {
            get { return this.Model.LocationEmail; }
            set { this.Model.LocationEmail = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "LOC_MAP_IMAGE_PATH" field.
        /// </summary>
        public System.String MapImagePath
        {
            get { return this.Model.MapImagePath; }
            set { this.Model.MapImagePath = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "LOC_DETAILS_PATH" field.
        /// </summary>
        public System.String DetailsPath
        {
            get { return this.Model.DetailsPath; }
            set { this.Model.DetailsPath = value; }
        }

        /// <summary>
        ///     Gets the The value of the "LOC_REGION" field.
        /// </summary>
        public Consensus.Common.Code Region
        {
            get
            {
                if (_region == null && this.Model.Region != null)
                    _region = new Consensus.Common.Code(this.Model.Region);
                if (_region == null)
                    _region = Consensus.Common.Code.Create();
                return _region;
            }
        }

        /// <summary>
        ///     Gets or sets the unique code for the value of the "LOC_REGION" field.
        /// </summary>
        public System.String RegionCode
        {
            get { return this.Model.RegionCode; }
            set { this.Model.RegionCode = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "LOC_COST_CODE" field.
        /// </summary>
        public System.String CostCode
        {
            get { return this.Model.CostCode; }
            set { this.Model.CostCode = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "LOC_REV_CODE" field.
        /// </summary>
        public System.String RevCode
        {
            get { return this.Model.RevCode; }
            set { this.Model.RevCode = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "LOC_WEB" field.
        /// </summary>
        public System.Byte WebEnabled
        {
            get { return this.Model.WebEnabled; }
            set { this.Model.WebEnabled = value; }
        }

        /// <summary>
        ///     Gets the The value of the "LOC_VENUE_TYPE" field.
        /// </summary>
        public Consensus.Common.Code VenueType
        {
            get
            {
                if (_venueType == null && this.Model.VenueType != null)
                    _venueType = new Consensus.Common.Code(this.Model.VenueType);
                if (_venueType == null)
                    _venueType = Consensus.Common.Code.Create();
                return _venueType;
            }
        }

        /// <summary>
        ///     Gets or sets the unique code for the value of the "LOC_VENUE_TYPE" field.
        /// </summary>
        public System.String VenueTypeCode
        {
            get { return this.Model.VenueTypeCode; }
            set { this.Model.VenueTypeCode = value; }
        }

        /// <summary>
        ///     Gets the The value of the "LOC_LINKED_LOC_ID" field.
        /// </summary>
        public Consensus.Contact.Location LinkedLocation
        {
            get
            {
                if (_linkedLocation == null && this.Model.LinkedLocation != null)
                    _linkedLocation = new Consensus.Contact.Location(this.Model.LinkedLocation);
                if (_linkedLocation == null)
                    _linkedLocation = Consensus.Contact.Location.Create();
                return _linkedLocation;
            }
        }

        /// <summary>
        ///     Gets or sets the unique code for the value of the "LOC_LINKED_LOC_ID" field.
        /// </summary>
        public System.String LinkedLocationId
        {
            get { return this.Model.LinkedLocationId; }
            set { this.Model.LinkedLocationId = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "LOC_TITLE" field.
        /// </summary>
        public System.String Title
        {
            get { return this.Model.Title; }
            set { this.Model.Title = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "LOC_DESCRIPTION" field.
        /// </summary>
        public System.String Description
        {
            get { return this.Model.Description; }
            set { this.Model.Description = value; }
        }

        /// <summary>
        ///     Gets the collection of <see cref="!:LocationModel" /> instances that reference this <see cref="!:LocationModel" />.
        /// </summary>
        public Collection<Consensus.Contact.Location> LinkedLocations
        {
            get
            {
                if (_linkedLocations == null)
                    _linkedLocations = new ProxyCollection<Consensus.Contact.Location, Consensus.Contact.ILocationModel>(this.Model.LinkedLocations, model => new Consensus.Contact.Location(model));
                return _linkedLocations;
            }
        }

        /// <summary>
        ///     Gets the collection of <see cref="!:ProductModel" /> instances that reference this <see cref="!:LocationModel" />.
        /// </summary>
        public Collection<Consensus.Learning.Product> Product
        {
            get
            {
                if (_product == null)
                    _product = new ProxyCollection<Consensus.Learning.Product, Consensus.Learning.IProductModel>(this.Model.Product, model => new Consensus.Learning.Product(model));
                return _product;
            }
        }

        /// <summary>
        ///     Gets the collection of <see cref="!:EventModel" /> instances that reference this <see cref="!:LocationModel" />.
        /// </summary>
        [NonSerializedAttribute]
        public Collection<Consensus.Learning.Event> Events
        {
            get
            {
                if (_events == null)
                    _events = new ProxyCollection<Consensus.Learning.Event, Consensus.Learning.IEventModel>(this.Model.Events, model => new Consensus.Learning.Event(model));
                return _events;
            }
        }

        /// <summary>
        ///     Gets the collection of <see cref="!:SessionModel" /> instances that reference this <see cref="!:LocationModel" />.
        /// </summary>
        public Collection<Consensus.Learning.Session> SessionLocation
        {
            get
            {
                if (_sessionLocation == null)
                    _sessionLocation = new ProxyCollection<Consensus.Learning.Session, Consensus.Learning.ISessionModel>(this.Model.SessionLocation, model => new Consensus.Learning.Session(model));
                return _sessionLocation;
            }
        }

        #endregion

        #region constructors

        /// <summary>
        ///     Initialises a new instance of the client-consumable class.
        /// </summary>
        internal Location(ILocationModel model) : base(model)
        {
        }

        #endregion

        #region methods

        /// <summary>
        ///     Check if Location Reference exist or not.
        /// </summary>
        /// <param name="reference">
        ///     Location Reference.
        /// </param>
        /// <param name="locationId">
        ///     Id of Location.
        /// </param>
        /// <returns>
        ///     Whether loction exist or not.
        /// </returns>
        public static System.Boolean CheckIfLocationReferenceExist(System.String reference, System.String locationId)
        {
            ConsensusSite site = ConsensusDomain.Configuration[ConsensusDomain.Configuration.DefaultSite];
            return Location.CheckIfLocationReferenceExist(site,reference,locationId);
        }

        /// <summary>
        ///     Check if Location Reference exist or not.
        /// </summary>
        /// <param name="reference">
        ///     Location Reference.
        /// </param>
        /// <param name="locationId">
        ///     Id of Location.
        /// </param>
        /// <returns>
        ///     Whether loction exist or not.
        /// </returns>
        public static System.Boolean CheckIfLocationReferenceExist(ConsensusSite site, System.String reference, System.String locationId)
        {
            IBusinessProvider provider = site.GetService<IBusinessProvider>();
            return provider.Contact.Location.CheckIfLocationReferenceExist(reference,locationId);
        }

        /// <summary>
        ///     Creates a new <see cref="!:LocationModel" /> instance.
        /// </summary>
        /// <returns>
        ///     A newly instantiated <see cref="!:LocationModel" /> instance.
        /// </returns>
        public static Consensus.Contact.Location Create()
        {
            ConsensusSite site = ConsensusDomain.Configuration[ConsensusDomain.Configuration.DefaultSite];
            return Location.Create(site);
        }

        /// <summary>
        ///     Creates a new <see cref="!:LocationModel" /> instance.
        /// </summary>
        /// <returns>
        ///     A newly instantiated <see cref="!:LocationModel" /> instance.
        /// </returns>
        public static Consensus.Contact.Location Create(ConsensusSite site)
        {
            IBusinessProvider provider = site.GetService<IBusinessProvider>();
            Consensus.Contact.ILocationModel model = provider.Contact.Location.Create();
            return model == null ? null : new Consensus.Contact.Location(model);
        }

        /// <summary>
        ///     Retrieves all instances of the <see cref="!:LocationModel" /> class.
        /// </summary>
        /// <returns>
        ///     An enumerable collection of <see cref="!:LocationModel" /> instances.
        /// </returns>
        public static IEnumerable<Consensus.Contact.Location> FetchAll()
        {
            ConsensusSite site = ConsensusDomain.Configuration[ConsensusDomain.Configuration.DefaultSite];
            return Location.FetchAll(site);
        }

        /// <summary>
        ///     Retrieves all instances of the <see cref="!:LocationModel" /> class.
        /// </summary>
        /// <returns>
        ///     An enumerable collection of <see cref="!:LocationModel" /> instances.
        /// </returns>
        public static IEnumerable<Consensus.Contact.Location> FetchAll(ConsensusSite site)
        {
            IBusinessProvider provider = site.GetService<IBusinessProvider>();
            IEnumerable<Consensus.Contact.ILocationModel> collection = provider.Contact.Location.FetchAll();
            return collection.Select(model => new Consensus.Contact.Location(model));
        }

        /// <summary>
        ///     Retrieves a specific <see cref="!:LocationModel" /> instance.
        /// </summary>
        /// <param name="id">
        ///     The unique value which distinctly identifies the <see cref="!:LocationModel" /> instance to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:LocationModel" /> instance that matches the specified <paramref name="id" />; or null, if no matching instance can be found.
        /// </returns>
        public static Consensus.Contact.Location FetchById(System.String id)
        {
            ConsensusSite site = ConsensusDomain.Configuration[ConsensusDomain.Configuration.DefaultSite];
            return Location.FetchById(site,id);
        }

        /// <summary>
        ///     Retrieves a specific <see cref="!:LocationModel" /> instance.
        /// </summary>
        /// <param name="id">
        ///     The unique value which distinctly identifies the <see cref="!:LocationModel" /> instance to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:LocationModel" /> instance that matches the specified <paramref name="id" />; or null, if no matching instance can be found.
        /// </returns>
        public static Consensus.Contact.Location FetchById(ConsensusSite site, System.String id)
        {
            IBusinessProvider provider = site.GetService<IBusinessProvider>();
            Consensus.Contact.ILocationModel model = provider.Contact.Location.FetchById(id);
            return model == null ? null : new Consensus.Contact.Location(model);
        }

        public static System.String GetTableName()
        {
            ConsensusSite site = ConsensusDomain.Configuration[ConsensusDomain.Configuration.DefaultSite];
            return Location.GetTableName(site);
        }

        public static System.String GetTableName(ConsensusSite site)
        {
            IBusinessProvider provider = site.GetService<IBusinessProvider>();
            return provider.Contact.Location.GetTableName();
        }

        /// <summary>
        ///     Retrieves a collection of <see cref="!:LocationModel" /> instances.
        /// </summary>
        /// <param name="organisationId">
        ///     The value which identifies the <see cref="!:LocationModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:LocationModel" /> instances that match the specified <paramref name="organisationId" />.
        /// </returns>
        public static IEnumerable<Consensus.Contact.Location> FetchAllByOrganisationId(System.String organisationId)
        {
            ConsensusSite site = ConsensusDomain.Configuration[ConsensusDomain.Configuration.DefaultSite];
            return Location.FetchAllByOrganisationId(site,organisationId);
        }

        /// <summary>
        ///     Retrieves a collection of <see cref="!:LocationModel" /> instances.
        /// </summary>
        /// <param name="organisationId">
        ///     The value which identifies the <see cref="!:LocationModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:LocationModel" /> instances that match the specified <paramref name="organisationId" />.
        /// </returns>
        public static IEnumerable<Consensus.Contact.Location> FetchAllByOrganisationId(ConsensusSite site, System.String organisationId)
        {
            IBusinessProvider provider = site.GetService<IBusinessProvider>();
            IEnumerable<Consensus.Contact.ILocationModel> collection = provider.Contact.Location.FetchAllByOrganisationId(organisationId);
            return collection.Select(model => new Consensus.Contact.Location(model));
        }

        /// <summary>
        ///     Retrieves a collection of <see cref="!:LocationModel" /> instances.
        /// </summary>
        /// <param name="addressId">
        ///     The value which identifies the <see cref="!:LocationModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:LocationModel" /> instances that match the specified <paramref name="addressId" />.
        /// </returns>
        public static IEnumerable<Consensus.Contact.Location> FetchAllByAddressId(System.String addressId)
        {
            ConsensusSite site = ConsensusDomain.Configuration[ConsensusDomain.Configuration.DefaultSite];
            return Location.FetchAllByAddressId(site,addressId);
        }

        /// <summary>
        ///     Retrieves a collection of <see cref="!:LocationModel" /> instances.
        /// </summary>
        /// <param name="addressId">
        ///     The value which identifies the <see cref="!:LocationModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:LocationModel" /> instances that match the specified <paramref name="addressId" />.
        /// </returns>
        public static IEnumerable<Consensus.Contact.Location> FetchAllByAddressId(ConsensusSite site, System.String addressId)
        {
            IBusinessProvider provider = site.GetService<IBusinessProvider>();
            IEnumerable<Consensus.Contact.ILocationModel> collection = provider.Contact.Location.FetchAllByAddressId(addressId);
            return collection.Select(model => new Consensus.Contact.Location(model));
        }

        /// <summary>
        ///     Retrieves a collection of <see cref="!:LocationModel" /> instances.
        /// </summary>
        /// <param name="sellingCompanyId">
        ///     The value which identifies the <see cref="!:LocationModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:LocationModel" /> instances that match the specified <paramref name="sellingCompanyId" />.
        /// </returns>
        public static IEnumerable<Consensus.Contact.Location> FetchAllBySellingCompanyId(System.String sellingCompanyId)
        {
            ConsensusSite site = ConsensusDomain.Configuration[ConsensusDomain.Configuration.DefaultSite];
            return Location.FetchAllBySellingCompanyId(site,sellingCompanyId);
        }

        /// <summary>
        ///     Retrieves a collection of <see cref="!:LocationModel" /> instances.
        /// </summary>
        /// <param name="sellingCompanyId">
        ///     The value which identifies the <see cref="!:LocationModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:LocationModel" /> instances that match the specified <paramref name="sellingCompanyId" />.
        /// </returns>
        public static IEnumerable<Consensus.Contact.Location> FetchAllBySellingCompanyId(ConsensusSite site, System.String sellingCompanyId)
        {
            IBusinessProvider provider = site.GetService<IBusinessProvider>();
            IEnumerable<Consensus.Contact.ILocationModel> collection = provider.Contact.Location.FetchAllBySellingCompanyId(sellingCompanyId);
            return collection.Select(model => new Consensus.Contact.Location(model));
        }

        /// <summary>
        ///     Retrieves a collection of <see cref="!:LocationModel" /> instances.
        /// </summary>
        /// <param name="locationRoleId">
        ///     The value which identifies the <see cref="!:LocationModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:LocationModel" /> instances that match the specified <paramref name="locationRoleId" />.
        /// </returns>
        public static IEnumerable<Consensus.Contact.Location> FetchAllByLocationRoleId(System.String locationRoleId)
        {
            ConsensusSite site = ConsensusDomain.Configuration[ConsensusDomain.Configuration.DefaultSite];
            return Location.FetchAllByLocationRoleId(site,locationRoleId);
        }

        /// <summary>
        ///     Retrieves a collection of <see cref="!:LocationModel" /> instances.
        /// </summary>
        /// <param name="locationRoleId">
        ///     The value which identifies the <see cref="!:LocationModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:LocationModel" /> instances that match the specified <paramref name="locationRoleId" />.
        /// </returns>
        public static IEnumerable<Consensus.Contact.Location> FetchAllByLocationRoleId(ConsensusSite site, System.String locationRoleId)
        {
            IBusinessProvider provider = site.GetService<IBusinessProvider>();
            IEnumerable<Consensus.Contact.ILocationModel> collection = provider.Contact.Location.FetchAllByLocationRoleId(locationRoleId);
            return collection.Select(model => new Consensus.Contact.Location(model));
        }

        /// <summary>
        ///     Retrieves a collection of <see cref="!:LocationModel" /> instances.
        /// </summary>
        /// <param name="linkedLocationId">
        ///     The value which identifies the <see cref="!:LocationModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:LocationModel" /> instances that match the specified <paramref name="linkedLocationId" />.
        /// </returns>
        public static IEnumerable<Consensus.Contact.Location> FetchAllByLinkedLocationId(System.String linkedLocationId)
        {
            ConsensusSite site = ConsensusDomain.Configuration[ConsensusDomain.Configuration.DefaultSite];
            return Location.FetchAllByLinkedLocationId(site,linkedLocationId);
        }

        /// <summary>
        ///     Retrieves a collection of <see cref="!:LocationModel" /> instances.
        /// </summary>
        /// <param name="linkedLocationId">
        ///     The value which identifies the <see cref="!:LocationModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:LocationModel" /> instances that match the specified <paramref name="linkedLocationId" />.
        /// </returns>
        public static IEnumerable<Consensus.Contact.Location> FetchAllByLinkedLocationId(ConsensusSite site, System.String linkedLocationId)
        {
            IBusinessProvider provider = site.GetService<IBusinessProvider>();
            IEnumerable<Consensus.Contact.ILocationModel> collection = provider.Contact.Location.FetchAllByLinkedLocationId(linkedLocationId);
            return collection.Select(model => new Consensus.Contact.Location(model));
        }

        #endregion
    }
}
