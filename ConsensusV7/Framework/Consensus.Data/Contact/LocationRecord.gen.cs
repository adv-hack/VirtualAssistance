using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Linq;

namespace Consensus.Contact
{
    /// <summary>
    ///     Represents the "Location" data structure.
    /// </summary>
    /// <remarks>
    ///     THIS CODE HAS BEEN AUTOMATICALLY GENERATED USING THE CONSENSUS DEVELOPER TOOLS.
    ///     DO NOT EDIT THIS CODE AS ANY CUSTOM MODIFICATIONS WILL BE LOST UPON REGENERATION.
    /// </remarks>
    public class LocationRecord : Record<String>, Cloneable<LocationRecord>, IEquatable<LocationRecord>
    {
        #region fields

        /// <summary>
        ///     the value of the "LOC_ADD_DATE" field.
        /// </summary>
        private DateTime? _addDate;

        /// <summary>
        ///     the value of the "LOC_ADD_BY" field.
        /// </summary>
        private String _addBy;

        /// <summary>
        ///     the value of the "LOC_MOD_DATE" field.
        /// </summary>
        private DateTime? _modDate;

        /// <summary>
        ///     the value of the "LOC_MOD_BY" field.
        /// </summary>
        private String _modBy;

        /// <summary>
        ///     the value of the "LOC_RCV_DATE" field.
        /// </summary>
        private DateTime? _rcvDate;

        /// <summary>
        ///     the value of the "LOC_RCV_FROM" field.
        /// </summary>
        private String _rcvFrom;

        /// <summary>
        ///     the value of the "LOC_ORG_ID" field.
        /// </summary>
        private String _orgId;

        /// <summary>
        ///     the value of the "LOC_ADD_ID" field.
        /// </summary>
        private String _addId;

        /// <summary>
        ///     the value of the "LOC_JOIN_INSTRUCS" field.
        /// </summary>
        private String _joinInstrucs;

        /// <summary>
        ///     the value of the "LOC_REF" field.
        /// </summary>
        private String _ref;

        /// <summary>
        ///     the value of the "LOC_NAME" field.
        /// </summary>
        private String _name;

        /// <summary>
        ///     the value of the "LOC_CERT_NAME" field.
        /// </summary>
        private String _certName;

        /// <summary>
        ///     the value of the "LOC_EXTERNAL" field.
        /// </summary>
        private Byte? _external;

        /// <summary>
        ///     the value of the "LOC_CONTACT_NAME" field.
        /// </summary>
        private String _contactName;

        /// <summary>
        ///     the value of the "LOC_COST_PER_DAY" field.
        /// </summary>
        private Double? _costPerDay;

        /// <summary>
        ///     the value of the "LOC_DEL_PER_DAY" field.
        /// </summary>
        private Double? _delPerDay;

        /// <summary>
        ///     the value of the "LOC_MAX_PLACES" field.
        /// </summary>
        private Double? _maxPlaces;

        /// <summary>
        ///     the value of the "LOC_SIZE" field.
        /// </summary>
        private String _size;

        /// <summary>
        ///     the value of the "LOC_MAP_ID" field.
        /// </summary>
        private String _mapId;

        /// <summary>
        ///     the value of the "LOC_BEDROOM" field.
        /// </summary>
        private Byte? _bedroom;

        /// <summary>
        ///     the value of the "LOC_ROOM_TYPE" field.
        /// </summary>
        private String _roomType;

        /// <summary>
        ///     the value of the "LOC_ROOM_GRADE" field.
        /// </summary>
        private String _roomGrade;

        /// <summary>
        ///     the value of the "LOC_DIRECTION" field.
        /// </summary>
        private String _direction;

        /// <summary>
        ///     the value of the "LOC_HTML" field.
        /// </summary>
        private String _html;

        /// <summary>
        ///     the value of the "LOC_URL" field.
        /// </summary>
        private String _url;

        /// <summary>
        ///     the value of the "LOC_MAP_FILE" field.
        /// </summary>
        private String _mapFile;

        /// <summary>
        ///     the value of the "LOC_OUR_LOCATION" field.
        /// </summary>
        private Byte? _ourLocation;

        /// <summary>
        ///     the value of the "LOC_TRAIN_PROVIDER" field.
        /// </summary>
        private Byte? _trainProvider;

        /// <summary>
        ///     the value of the "LOC_TRAIN_LOCATION" field.
        /// </summary>
        private Byte? _trainLocation;

        /// <summary>
        ///     the value of the "LOC_HOTEL" field.
        /// </summary>
        private Byte? _hotel;

        /// <summary>
        ///     the value of the "LOC_ANALYSIS_1" field.
        /// </summary>
        private String _analysis1;

        /// <summary>
        ///     the value of the "LOC_ANALYSIS_2" field.
        /// </summary>
        private String _analysis2;

        /// <summary>
        ///     the value of the "LOC_DIRECTIONS" field.
        /// </summary>
        private String _directions;

        /// <summary>
        ///     the value of the "LOC_NOTES" field.
        /// </summary>
        private String _notes;

        /// <summary>
        ///     the value of the "LOC_MAP_NAME" field.
        /// </summary>
        private String _mapName;

        /// <summary>
        ///     the value of the "LOC_SELCO_SP_ID" field.
        /// </summary>
        private String _selcoSpId;

        /// <summary>
        ///     the value of the "loc_prole_id" field.
        /// </summary>
        private String _locProleId;

        /// <summary>
        ///     the value of the "loc_phone" field.
        /// </summary>
        private String _locPhone;

        /// <summary>
        ///     the value of the "loc_fax" field.
        /// </summary>
        private String _locFax;

        /// <summary>
        ///     the value of the "loc_phone_std" field.
        /// </summary>
        private String _locPhoneStd;

        /// <summary>
        ///     the value of the "loc_fax_std" field.
        /// </summary>
        private String _locFaxStd;

        /// <summary>
        ///     the value of the "loc_email" field.
        /// </summary>
        private String _locEmail;

        /// <summary>
        ///     the value of the "loc_nearest_1" field.
        /// </summary>
        private String _locNearest1;

        /// <summary>
        ///     the value of the "loc_nearest_2" field.
        /// </summary>
        private String _locNearest2;

        /// <summary>
        ///     the value of the "loc_nearest_3" field.
        /// </summary>
        private String _locNearest3;

        /// <summary>
        ///     the value of the "loc_nearest_4" field.
        /// </summary>
        private String _locNearest4;

        /// <summary>
        ///     the value of the "loc_nearest_5" field.
        /// </summary>
        private String _locNearest5;

        /// <summary>
        ///     the value of the "loc_nearest_6" field.
        /// </summary>
        private String _locNearest6;

        /// <summary>
        ///     the value of the "LOC_MAP_IMAGE_PATH" field.
        /// </summary>
        private String _mapImagePath;

        /// <summary>
        ///     the value of the "LOC_DETAILS_PATH" field.
        /// </summary>
        private String _detailsPath;

        /// <summary>
        ///     the value of the "LOC_REGION" field.
        /// </summary>
        private String _region;

        /// <summary>
        ///     the value of the "LOC_DEL_DAY_RATE" field.
        /// </summary>
        private Decimal? _delDayRate;

        /// <summary>
        ///     the value of the "LOC_COST_CODE" field.
        /// </summary>
        private String _costCode;

        /// <summary>
        ///     the value of the "LOC_REV_CODE" field.
        /// </summary>
        private String _revCode;

        /// <summary>
        ///     the value of the "LOC_WEB" field.
        /// </summary>
        private Byte _web;

        /// <summary>
        ///     the value of the "LOC_VENUE_TYPE" field.
        /// </summary>
        private String _venueType;

        /// <summary>
        ///     the value of the "LOC_LINKED_LOC_ID" field.
        /// </summary>
        private String _linkedLocId;

        /// <summary>
        ///     the value of the "LOC_TITLE" field.
        /// </summary>
        private String _title;

        /// <summary>
        ///     the value of the "LOC_DESCRIPTION" field.
        /// </summary>
        private String _description;

        #endregion

        #region properties

        /// <summary>
        ///     the value of the "LOC_ADD_DATE" field.
        /// </summary>
        public DateTime? AddDate
        {
            get { return _addDate; }
            set { _addDate = value; }
        }

        /// <summary>
        ///     the value of the "LOC_ADD_BY" field.
        /// </summary>
        public String AddBy
        {
            get { return _addBy; }
            set { _addBy = value; }
        }

        /// <summary>
        ///     the value of the "LOC_MOD_DATE" field.
        /// </summary>
        public DateTime? ModDate
        {
            get { return _modDate; }
            set { _modDate = value; }
        }

        /// <summary>
        ///     the value of the "LOC_MOD_BY" field.
        /// </summary>
        public String ModBy
        {
            get { return _modBy; }
            set { _modBy = value; }
        }

        /// <summary>
        ///     the value of the "LOC_RCV_DATE" field.
        /// </summary>
        public DateTime? RcvDate
        {
            get { return _rcvDate; }
            set { _rcvDate = value; }
        }

        /// <summary>
        ///     the value of the "LOC_RCV_FROM" field.
        /// </summary>
        public String RcvFrom
        {
            get { return _rcvFrom; }
            set { _rcvFrom = value; }
        }

        /// <summary>
        ///     the value of the "LOC_ORG_ID" field.
        /// </summary>
        public String OrgId
        {
            get { return _orgId; }
            set { _orgId = value; }
        }

        /// <summary>
        ///     the value of the "LOC_ADD_ID" field.
        /// </summary>
        public String AddId
        {
            get { return _addId; }
            set { _addId = value; }
        }

        /// <summary>
        ///     the value of the "LOC_JOIN_INSTRUCS" field.
        /// </summary>
        public String JoinInstrucs
        {
            get { return _joinInstrucs; }
            set { _joinInstrucs = value; }
        }

        /// <summary>
        ///     the value of the "LOC_REF" field.
        /// </summary>
        public String Ref
        {
            get { return _ref; }
            set { _ref = value; }
        }

        /// <summary>
        ///     the value of the "LOC_NAME" field.
        /// </summary>
        public String Name
        {
            get { return _name; }
            set { _name = value; }
        }

        /// <summary>
        ///     the value of the "LOC_CERT_NAME" field.
        /// </summary>
        public String CertName
        {
            get { return _certName; }
            set { _certName = value; }
        }

        /// <summary>
        ///     the value of the "LOC_EXTERNAL" field.
        /// </summary>
        public Byte? External
        {
            get { return _external; }
            set { _external = value; }
        }

        /// <summary>
        ///     the value of the "LOC_CONTACT_NAME" field.
        /// </summary>
        public String ContactName
        {
            get { return _contactName; }
            set { _contactName = value; }
        }

        /// <summary>
        ///     the value of the "LOC_COST_PER_DAY" field.
        /// </summary>
        public Double? CostPerDay
        {
            get { return _costPerDay; }
            set { _costPerDay = value; }
        }

        /// <summary>
        ///     the value of the "LOC_DEL_PER_DAY" field.
        /// </summary>
        public Double? DelPerDay
        {
            get { return _delPerDay; }
            set { _delPerDay = value; }
        }

        /// <summary>
        ///     the value of the "LOC_MAX_PLACES" field.
        /// </summary>
        public Double? MaxPlaces
        {
            get { return _maxPlaces; }
            set { _maxPlaces = value; }
        }

        /// <summary>
        ///     the value of the "LOC_SIZE" field.
        /// </summary>
        public String Size
        {
            get { return _size; }
            set { _size = value; }
        }

        /// <summary>
        ///     the value of the "LOC_MAP_ID" field.
        /// </summary>
        public String MapId
        {
            get { return _mapId; }
            set { _mapId = value; }
        }

        /// <summary>
        ///     the value of the "LOC_BEDROOM" field.
        /// </summary>
        public Byte? Bedroom
        {
            get { return _bedroom; }
            set { _bedroom = value; }
        }

        /// <summary>
        ///     the value of the "LOC_ROOM_TYPE" field.
        /// </summary>
        public String RoomType
        {
            get { return _roomType; }
            set { _roomType = value; }
        }

        /// <summary>
        ///     the value of the "LOC_ROOM_GRADE" field.
        /// </summary>
        public String RoomGrade
        {
            get { return _roomGrade; }
            set { _roomGrade = value; }
        }

        /// <summary>
        ///     the value of the "LOC_DIRECTION" field.
        /// </summary>
        public String Direction
        {
            get { return _direction; }
            set { _direction = value; }
        }

        /// <summary>
        ///     the value of the "LOC_HTML" field.
        /// </summary>
        public String Html
        {
            get { return _html; }
            set { _html = value; }
        }

        /// <summary>
        ///     the value of the "LOC_URL" field.
        /// </summary>
        public String Url
        {
            get { return _url; }
            set { _url = value; }
        }

        /// <summary>
        ///     the value of the "LOC_MAP_FILE" field.
        /// </summary>
        public String MapFile
        {
            get { return _mapFile; }
            set { _mapFile = value; }
        }

        /// <summary>
        ///     the value of the "LOC_OUR_LOCATION" field.
        /// </summary>
        public Byte? OurLocation
        {
            get { return _ourLocation; }
            set { _ourLocation = value; }
        }

        /// <summary>
        ///     the value of the "LOC_TRAIN_PROVIDER" field.
        /// </summary>
        public Byte? TrainProvider
        {
            get { return _trainProvider; }
            set { _trainProvider = value; }
        }

        /// <summary>
        ///     the value of the "LOC_TRAIN_LOCATION" field.
        /// </summary>
        public Byte? TrainLocation
        {
            get { return _trainLocation; }
            set { _trainLocation = value; }
        }

        /// <summary>
        ///     the value of the "LOC_HOTEL" field.
        /// </summary>
        public Byte? Hotel
        {
            get { return _hotel; }
            set { _hotel = value; }
        }

        /// <summary>
        ///     the value of the "LOC_ANALYSIS_1" field.
        /// </summary>
        public String Analysis1
        {
            get { return _analysis1; }
            set { _analysis1 = value; }
        }

        /// <summary>
        ///     the value of the "LOC_ANALYSIS_2" field.
        /// </summary>
        public String Analysis2
        {
            get { return _analysis2; }
            set { _analysis2 = value; }
        }

        /// <summary>
        ///     the value of the "LOC_DIRECTIONS" field.
        /// </summary>
        public String Directions
        {
            get { return _directions; }
            set { _directions = value; }
        }

        /// <summary>
        ///     the value of the "LOC_NOTES" field.
        /// </summary>
        public String Notes
        {
            get { return _notes; }
            set { _notes = value; }
        }

        /// <summary>
        ///     the value of the "LOC_MAP_NAME" field.
        /// </summary>
        public String MapName
        {
            get { return _mapName; }
            set { _mapName = value; }
        }

        /// <summary>
        ///     the value of the "LOC_SELCO_SP_ID" field.
        /// </summary>
        public String SelcoSpId
        {
            get { return _selcoSpId; }
            set { _selcoSpId = value; }
        }

        /// <summary>
        ///     the value of the "loc_prole_id" field.
        /// </summary>
        public String LocProleId
        {
            get { return _locProleId; }
            set { _locProleId = value; }
        }

        /// <summary>
        ///     the value of the "loc_phone" field.
        /// </summary>
        public String LocPhone
        {
            get { return _locPhone; }
            set { _locPhone = value; }
        }

        /// <summary>
        ///     the value of the "loc_fax" field.
        /// </summary>
        public String LocFax
        {
            get { return _locFax; }
            set { _locFax = value; }
        }

        /// <summary>
        ///     the value of the "loc_phone_std" field.
        /// </summary>
        public String LocPhoneStd
        {
            get { return _locPhoneStd; }
            set { _locPhoneStd = value; }
        }

        /// <summary>
        ///     the value of the "loc_fax_std" field.
        /// </summary>
        public String LocFaxStd
        {
            get { return _locFaxStd; }
            set { _locFaxStd = value; }
        }

        /// <summary>
        ///     the value of the "loc_email" field.
        /// </summary>
        public String LocEmail
        {
            get { return _locEmail; }
            set { _locEmail = value; }
        }

        /// <summary>
        ///     the value of the "loc_nearest_1" field.
        /// </summary>
        public String LocNearest1
        {
            get { return _locNearest1; }
            set { _locNearest1 = value; }
        }

        /// <summary>
        ///     the value of the "loc_nearest_2" field.
        /// </summary>
        public String LocNearest2
        {
            get { return _locNearest2; }
            set { _locNearest2 = value; }
        }

        /// <summary>
        ///     the value of the "loc_nearest_3" field.
        /// </summary>
        public String LocNearest3
        {
            get { return _locNearest3; }
            set { _locNearest3 = value; }
        }

        /// <summary>
        ///     the value of the "loc_nearest_4" field.
        /// </summary>
        public String LocNearest4
        {
            get { return _locNearest4; }
            set { _locNearest4 = value; }
        }

        /// <summary>
        ///     the value of the "loc_nearest_5" field.
        /// </summary>
        public String LocNearest5
        {
            get { return _locNearest5; }
            set { _locNearest5 = value; }
        }

        /// <summary>
        ///     the value of the "loc_nearest_6" field.
        /// </summary>
        public String LocNearest6
        {
            get { return _locNearest6; }
            set { _locNearest6 = value; }
        }

        /// <summary>
        ///     the value of the "LOC_MAP_IMAGE_PATH" field.
        /// </summary>
        public String MapImagePath
        {
            get { return _mapImagePath; }
            set { _mapImagePath = value; }
        }

        /// <summary>
        ///     the value of the "LOC_DETAILS_PATH" field.
        /// </summary>
        public String DetailsPath
        {
            get { return _detailsPath; }
            set { _detailsPath = value; }
        }

        /// <summary>
        ///     the value of the "LOC_REGION" field.
        /// </summary>
        public String Region
        {
            get { return _region; }
            set { _region = value; }
        }

        /// <summary>
        ///     the value of the "LOC_DEL_DAY_RATE" field.
        /// </summary>
        public Decimal? DelDayRate
        {
            get { return _delDayRate; }
            set { _delDayRate = value; }
        }

        /// <summary>
        ///     the value of the "LOC_COST_CODE" field.
        /// </summary>
        public String CostCode
        {
            get { return _costCode; }
            set { _costCode = value; }
        }

        /// <summary>
        ///     the value of the "LOC_REV_CODE" field.
        /// </summary>
        public String RevCode
        {
            get { return _revCode; }
            set { _revCode = value; }
        }

        /// <summary>
        ///     the value of the "LOC_WEB" field.
        /// </summary>
        public Byte Web
        {
            get { return _web; }
            set { _web = value; }
        }

        /// <summary>
        ///     the value of the "LOC_VENUE_TYPE" field.
        /// </summary>
        public String VenueType
        {
            get { return _venueType; }
            set { _venueType = value; }
        }

        /// <summary>
        ///     the value of the "LOC_LINKED_LOC_ID" field.
        /// </summary>
        public String LinkedLocId
        {
            get { return _linkedLocId; }
            set { _linkedLocId = value; }
        }

        /// <summary>
        ///     the value of the "LOC_TITLE" field.
        /// </summary>
        public String Title
        {
            get { return _title; }
            set { _title = value; }
        }

        /// <summary>
        ///     the value of the "LOC_DESCRIPTION" field.
        /// </summary>
        public String Description
        {
            get { return _description; }
            set { _description = value; }
        }

        #endregion

        #region methods

        /// <summary>
        ///     Creates a new <see cref="LocationRecord" /> object instance that is a shallow-copy of the current object instance.
        /// </summary>
        /// <returns>
        ///     The shallow-copy of the current <see cref="LocationRecord" /> object instance.
        /// </returns>
        public LocationRecord Clone()
        {
            LocationRecord record = new LocationRecord();
            record.Id = this.Id;
            record.AddDate = this.AddDate;
            record.AddBy = this.AddBy;
            record.ModDate = this.ModDate;
            record.ModBy = this.ModBy;
            record.RcvDate = this.RcvDate;
            record.RcvFrom = this.RcvFrom;
            record.OrgId = this.OrgId;
            record.AddId = this.AddId;
            record.JoinInstrucs = this.JoinInstrucs;
            record.Ref = this.Ref;
            record.Name = this.Name;
            record.CertName = this.CertName;
            record.External = this.External;
            record.ContactName = this.ContactName;
            record.CostPerDay = this.CostPerDay;
            record.DelPerDay = this.DelPerDay;
            record.MaxPlaces = this.MaxPlaces;
            record.Size = this.Size;
            record.MapId = this.MapId;
            record.Bedroom = this.Bedroom;
            record.RoomType = this.RoomType;
            record.RoomGrade = this.RoomGrade;
            record.Direction = this.Direction;
            record.Html = this.Html;
            record.Url = this.Url;
            record.MapFile = this.MapFile;
            record.OurLocation = this.OurLocation;
            record.TrainProvider = this.TrainProvider;
            record.TrainLocation = this.TrainLocation;
            record.Hotel = this.Hotel;
            record.Analysis1 = this.Analysis1;
            record.Analysis2 = this.Analysis2;
            record.Directions = this.Directions;
            record.Notes = this.Notes;
            record.MapName = this.MapName;
            record.SelcoSpId = this.SelcoSpId;
            record.LocProleId = this.LocProleId;
            record.LocPhone = this.LocPhone;
            record.LocFax = this.LocFax;
            record.LocPhoneStd = this.LocPhoneStd;
            record.LocFaxStd = this.LocFaxStd;
            record.LocEmail = this.LocEmail;
            record.LocNearest1 = this.LocNearest1;
            record.LocNearest2 = this.LocNearest2;
            record.LocNearest3 = this.LocNearest3;
            record.LocNearest4 = this.LocNearest4;
            record.LocNearest5 = this.LocNearest5;
            record.LocNearest6 = this.LocNearest6;
            record.MapImagePath = this.MapImagePath;
            record.DetailsPath = this.DetailsPath;
            record.Region = this.Region;
            record.DelDayRate = this.DelDayRate;
            record.CostCode = this.CostCode;
            record.RevCode = this.RevCode;
            record.Web = this.Web;
            record.VenueType = this.VenueType;
            record.LinkedLocId = this.LinkedLocId;
            record.Title = this.Title;
            record.Description = this.Description;
            return record;
        }

        /// <summary>
        ///     Indicates whether the current <see cref="LocationRecord" /> instance is equal to another <see cref="LocationRecord" /> instance.
        /// </summary>
        /// <param name="that">
        ///     The <see cref="LocationRecord" /> instance to be compared against this instance.
        /// </param>
        /// <returns>
        ///     True if both instances are considered equal; otherwise, false.
        /// </returns>
        public Boolean Equals(LocationRecord that)
        {
            Boolean result = true;
            result = result && (this.Id.TrimOrNullify() == that.Id.TrimOrNullify());
            result = result && (this.OrgId.TrimOrNullify() == that.OrgId.TrimOrNullify());
            result = result && (this.AddId.TrimOrNullify() == that.AddId.TrimOrNullify());
            result = result && (this.JoinInstrucs.TrimOrNullify() == that.JoinInstrucs.TrimOrNullify());
            result = result && (this.Ref.TrimOrNullify() == that.Ref.TrimOrNullify());
            result = result && (this.Name.TrimOrNullify() == that.Name.TrimOrNullify());
            result = result && (this.CertName.TrimOrNullify() == that.CertName.TrimOrNullify());
            result = result && (this.External == that.External);
            result = result && (this.ContactName.TrimOrNullify() == that.ContactName.TrimOrNullify());
            result = result && (this.CostPerDay == that.CostPerDay);
            result = result && (this.DelPerDay == that.DelPerDay);
            result = result && (this.MaxPlaces == that.MaxPlaces);
            result = result && (this.Size.TrimOrNullify() == that.Size.TrimOrNullify());
            result = result && (this.MapId.TrimOrNullify() == that.MapId.TrimOrNullify());
            result = result && (this.Bedroom == that.Bedroom);
            result = result && (this.RoomType.TrimOrNullify() == that.RoomType.TrimOrNullify());
            result = result && (this.RoomGrade.TrimOrNullify() == that.RoomGrade.TrimOrNullify());
            result = result && (this.Direction.TrimOrNullify() == that.Direction.TrimOrNullify());
            result = result && (this.Html.TrimOrNullify() == that.Html.TrimOrNullify());
            result = result && (this.Url.TrimOrNullify() == that.Url.TrimOrNullify());
            result = result && (this.MapFile.TrimOrNullify() == that.MapFile.TrimOrNullify());
            result = result && (this.OurLocation == that.OurLocation);
            result = result && (this.TrainProvider == that.TrainProvider);
            result = result && (this.TrainLocation == that.TrainLocation);
            result = result && (this.Hotel == that.Hotel);
            result = result && (this.Analysis1.TrimOrNullify() == that.Analysis1.TrimOrNullify());
            result = result && (this.Analysis2.TrimOrNullify() == that.Analysis2.TrimOrNullify());
            result = result && (this.Directions.TrimOrNullify() == that.Directions.TrimOrNullify());
            result = result && (this.Notes.TrimOrNullify() == that.Notes.TrimOrNullify());
            result = result && (this.MapName.TrimOrNullify() == that.MapName.TrimOrNullify());
            result = result && (this.SelcoSpId.TrimOrNullify() == that.SelcoSpId.TrimOrNullify());
            result = result && (this.LocProleId.TrimOrNullify() == that.LocProleId.TrimOrNullify());
            result = result && (this.LocPhone.TrimOrNullify() == that.LocPhone.TrimOrNullify());
            result = result && (this.LocFax.TrimOrNullify() == that.LocFax.TrimOrNullify());
            result = result && (this.LocPhoneStd.TrimOrNullify() == that.LocPhoneStd.TrimOrNullify());
            result = result && (this.LocFaxStd.TrimOrNullify() == that.LocFaxStd.TrimOrNullify());
            result = result && (this.LocEmail.TrimOrNullify() == that.LocEmail.TrimOrNullify());
            result = result && (this.LocNearest1.TrimOrNullify() == that.LocNearest1.TrimOrNullify());
            result = result && (this.LocNearest2.TrimOrNullify() == that.LocNearest2.TrimOrNullify());
            result = result && (this.LocNearest3.TrimOrNullify() == that.LocNearest3.TrimOrNullify());
            result = result && (this.LocNearest4.TrimOrNullify() == that.LocNearest4.TrimOrNullify());
            result = result && (this.LocNearest5.TrimOrNullify() == that.LocNearest5.TrimOrNullify());
            result = result && (this.LocNearest6.TrimOrNullify() == that.LocNearest6.TrimOrNullify());
            result = result && (this.MapImagePath.TrimOrNullify() == that.MapImagePath.TrimOrNullify());
            result = result && (this.DetailsPath.TrimOrNullify() == that.DetailsPath.TrimOrNullify());
            result = result && (this.Region.TrimOrNullify() == that.Region.TrimOrNullify());
            result = result && (this.DelDayRate == that.DelDayRate);
            result = result && (this.CostCode.TrimOrNullify() == that.CostCode.TrimOrNullify());
            result = result && (this.RevCode.TrimOrNullify() == that.RevCode.TrimOrNullify());
            result = result && (this.Web == that.Web);
            result = result && (this.VenueType.TrimOrNullify() == that.VenueType.TrimOrNullify());
            result = result && (this.LinkedLocId.TrimOrNullify() == that.LinkedLocId.TrimOrNullify());
            result = result && (this.Title.TrimOrNullify() == that.Title.TrimOrNullify());
            result = result && (this.Description.TrimOrNullify() == that.Description.TrimOrNullify());
            return result;
        }

        #endregion
    }
}
