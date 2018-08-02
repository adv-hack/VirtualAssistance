using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Linq;

namespace Consensus.Contact
{
    /// <summary>
    ///     Provides the persistence and retrieval of the <see cref="LocationRecord" /> instances in a Microsoft SQL Server database.
    /// </summary>
    /// <remarks>
    ///     THIS CODE HAS BEEN AUTOMATICALLY GENERATED USING THE CONSENSUS DEVELOPER TOOLS.
    ///     DO NOT EDIT THIS CODE AS ANY CUSTOM MODIFICATIONS WILL BE LOST UPON REGENERATION.
    /// </remarks>
    public partial class SqlServerLocationRepository : SqlServerRepository<LocationRecord, String>, ILocationRepository
    {
        #region properties

        /// <summary>
        ///     Gets the namespace in which the data type is contained.
        /// </summary>
        protected override String TypeNamespace
        {
            get { return "Contact"; }
        }

        /// <summary>
        ///     Gets the name of the data type which is persisted by this repository.
        /// </summary>
        protected override String TypeName
        {
            get { return "Location"; }
        }

        /// <summary>
        ///     Gets the name of the parameter which is used to specify the unique value that identifies each instance of a <see cref="LocationRecord" />.
        /// </summary>
        protected override String TypeKeyName
        {
            get { return "@PA_LOC_ID"; }
        }

        /// <summary>
        ///     Gets the underlying table name that this repository sit over.
        /// </summary>
        public override String TableName
        {
            get { return "Location"; }
        }

        #endregion

        #region methods

        /// <summary>
        ///     Maps an <see cref="IDataRecord" /> to the specified <see cref="LocationRecord" />.
        /// </summary>
        /// <param name="dataRecord">
        ///     The <see cref="IDataRecord" /> to be mapped.
        /// </param>
        /// <param name="record">
        ///     The <see cref="LocationRecord" /> instance to be mapped to.
        /// </param>
        protected override void MapRecord(IDataRecord dataRecord, LocationRecord record)
        {
            record.Id = dataRecord["LOC_ID"].ConvertTo<String>();
            record.AddDate = dataRecord["LOC_ADD_DATE"].ConvertTo<DateTime?>();
            record.AddBy = dataRecord["LOC_ADD_BY"].ConvertTo<String>();
            record.ModDate = dataRecord["LOC_MOD_DATE"].ConvertTo<DateTime?>();
            record.ModBy = dataRecord["LOC_MOD_BY"].ConvertTo<String>();
            record.RcvDate = dataRecord["LOC_RCV_DATE"].ConvertTo<DateTime?>();
            record.RcvFrom = dataRecord["LOC_RCV_FROM"].ConvertTo<String>();
            record.OrgId = dataRecord["LOC_ORG_ID"].ConvertTo<String>();
            record.AddId = dataRecord["LOC_ADD_ID"].ConvertTo<String>();
            record.JoinInstrucs = dataRecord["LOC_JOIN_INSTRUCS"].ConvertTo<String>();
            record.Ref = dataRecord["LOC_REF"].ConvertTo<String>();
            record.Name = dataRecord["LOC_NAME"].ConvertTo<String>();
            record.CertName = dataRecord["LOC_CERT_NAME"].ConvertTo<String>();
            record.External = dataRecord["LOC_EXTERNAL"].ConvertTo<Byte?>();
            record.ContactName = dataRecord["LOC_CONTACT_NAME"].ConvertTo<String>();
            record.CostPerDay = dataRecord["LOC_COST_PER_DAY"].ConvertTo<Double?>();
            record.DelPerDay = dataRecord["LOC_DEL_PER_DAY"].ConvertTo<Double?>();
            record.MaxPlaces = dataRecord["LOC_MAX_PLACES"].ConvertTo<Double?>();
            record.Size = dataRecord["LOC_SIZE"].ConvertTo<String>();
            record.MapId = dataRecord["LOC_MAP_ID"].ConvertTo<String>();
            record.Bedroom = dataRecord["LOC_BEDROOM"].ConvertTo<Byte?>();
            record.RoomType = dataRecord["LOC_ROOM_TYPE"].ConvertTo<String>();
            record.RoomGrade = dataRecord["LOC_ROOM_GRADE"].ConvertTo<String>();
            record.Direction = dataRecord["LOC_DIRECTION"].ConvertTo<String>();
            record.Html = dataRecord["LOC_HTML"].ConvertTo<String>();
            record.Url = dataRecord["LOC_URL"].ConvertTo<String>();
            record.MapFile = dataRecord["LOC_MAP_FILE"].ConvertTo<String>();
            record.OurLocation = dataRecord["LOC_OUR_LOCATION"].ConvertTo<Byte?>();
            record.TrainProvider = dataRecord["LOC_TRAIN_PROVIDER"].ConvertTo<Byte?>();
            record.TrainLocation = dataRecord["LOC_TRAIN_LOCATION"].ConvertTo<Byte?>();
            record.Hotel = dataRecord["LOC_HOTEL"].ConvertTo<Byte?>();
            record.Analysis1 = dataRecord["LOC_ANALYSIS_1"].ConvertTo<String>();
            record.Analysis2 = dataRecord["LOC_ANALYSIS_2"].ConvertTo<String>();
            record.Directions = dataRecord["LOC_DIRECTIONS"].ConvertTo<String>();
            record.Notes = dataRecord["LOC_NOTES"].ConvertTo<String>();
            record.MapName = dataRecord["LOC_MAP_NAME"].ConvertTo<String>();
            record.SelcoSpId = dataRecord["LOC_SELCO_SP_ID"].ConvertTo<String>();
            record.LocProleId = dataRecord["loc_prole_id"].ConvertTo<String>();
            record.LocPhone = dataRecord["loc_phone"].ConvertTo<String>();
            record.LocFax = dataRecord["loc_fax"].ConvertTo<String>();
            record.LocPhoneStd = dataRecord["loc_phone_std"].ConvertTo<String>();
            record.LocFaxStd = dataRecord["loc_fax_std"].ConvertTo<String>();
            record.LocEmail = dataRecord["loc_email"].ConvertTo<String>();
            record.LocNearest1 = dataRecord["loc_nearest_1"].ConvertTo<String>();
            record.LocNearest2 = dataRecord["loc_nearest_2"].ConvertTo<String>();
            record.LocNearest3 = dataRecord["loc_nearest_3"].ConvertTo<String>();
            record.LocNearest4 = dataRecord["loc_nearest_4"].ConvertTo<String>();
            record.LocNearest5 = dataRecord["loc_nearest_5"].ConvertTo<String>();
            record.LocNearest6 = dataRecord["loc_nearest_6"].ConvertTo<String>();
            record.MapImagePath = dataRecord["LOC_MAP_IMAGE_PATH"].ConvertTo<String>();
            record.DetailsPath = dataRecord["LOC_DETAILS_PATH"].ConvertTo<String>();
            record.Region = dataRecord["LOC_REGION"].ConvertTo<String>();
            record.DelDayRate = dataRecord["LOC_DEL_DAY_RATE"].ConvertTo<Decimal?>();
            record.CostCode = dataRecord["LOC_COST_CODE"].ConvertTo<String>();
            record.RevCode = dataRecord["LOC_REV_CODE"].ConvertTo<String>();
            record.Web = dataRecord["LOC_WEB"].ConvertTo<Byte>();
            record.VenueType = dataRecord["LOC_VENUE_TYPE"].ConvertTo<String>();
            record.LinkedLocId = dataRecord["LOC_LINKED_LOC_ID"].ConvertTo<String>();
            record.Title = dataRecord["LOC_TITLE"].ConvertTo<String>();
            record.Description = dataRecord["LOC_DESCRIPTION"].ConvertTo<String>();
        }

        /// <summary>
        ///     Sets the parameter values for the specified <paramref name="command" /> based on the specified <typeparamref name="TRecord" /> instance.
        /// </summary>
        /// <param name="command">
        ///     The <see cref="IDbCommand" /> containing the parameters to be mapped.
        /// </param>
        /// <param name="record">
        ///     The <see cref="LocationRecord" /> instance to be mapped.
        /// </param>
        /// <param name="useV6Logic">
        ///     Is the procedure being run an old version 6.x procedure? (the null value handling logic is different).
        /// </param>
        protected override void MapParametersIn(IDbCommand command, LocationRecord record, bool useV6Logic)
        {
            this.MapParameterIn(command, "@PA_LOC_ID", record.Id);
            this.MapParameterIn(command, "@PA_LOC_ORG_ID", record.OrgId);
            this.MapParameterIn(command, "@PA_LOC_ADD_ID", record.AddId);
            this.MapParameterIn(command, "@PA_LOC_JOIN_INSTRUCS", record.JoinInstrucs);
            this.MapParameterIn(command, "@PA_LOC_REF", record.Ref);
            this.MapParameterIn(command, "@PA_LOC_NAME", record.Name);
            this.MapParameterIn(command, "@PA_LOC_CERT_NAME", record.CertName);
            this.MapParameterIn(command, "@PA_LOC_EXTERNAL", record.External);
            this.MapParameterIn(command, "@PA_LOC_CONTACT_NAME", record.ContactName);
            this.MapParameterIn(command, "@PA_LOC_COST_PER_DAY", record.CostPerDay == Double.MinValue ? ( useV6Logic ? new Double?(0) : null ) : record.CostPerDay);
            this.MapParameterIn(command, "@PA_LOC_DEL_PER_DAY", record.DelPerDay == Double.MinValue ? ( useV6Logic ? new Double?(0) : null ) : record.DelPerDay);
            this.MapParameterIn(command, "@PA_LOC_MAX_PLACES", record.MaxPlaces == Double.MinValue ? ( useV6Logic ? new Double?(0) : null ) : record.MaxPlaces);
            this.MapParameterIn(command, "@PA_LOC_SIZE", record.Size);
            this.MapParameterIn(command, "@PA_LOC_MAP_ID", record.MapId);
            this.MapParameterIn(command, "@PA_LOC_BEDROOM", record.Bedroom);
            this.MapParameterIn(command, "@PA_LOC_ROOM_TYPE", record.RoomType);
            this.MapParameterIn(command, "@PA_LOC_ROOM_GRADE", record.RoomGrade);
            this.MapParameterIn(command, "@PA_LOC_DIRECTION", record.Direction);
            this.MapParameterIn(command, "@PA_LOC_HTML", record.Html);
            this.MapParameterIn(command, "@PA_LOC_URL", record.Url);
            this.MapParameterIn(command, "@PA_LOC_MAP_FILE", record.MapFile);
            this.MapParameterIn(command, "@PA_LOC_OUR_LOCATION", record.OurLocation);
            this.MapParameterIn(command, "@PA_LOC_TRAIN_PROVIDER", record.TrainProvider);
            this.MapParameterIn(command, "@PA_LOC_TRAIN_LOCATION", record.TrainLocation);
            this.MapParameterIn(command, "@PA_LOC_HOTEL", record.Hotel);
            this.MapParameterIn(command, "@PA_LOC_ANALYSIS_1", record.Analysis1);
            this.MapParameterIn(command, "@PA_LOC_ANALYSIS_2", record.Analysis2);
            this.MapParameterIn(command, "@PA_LOC_DIRECTIONS", record.Directions);
            this.MapParameterIn(command, "@PA_LOC_NOTES", record.Notes);
            this.MapParameterIn(command, "@PA_LOC_MAP_NAME", record.MapName);
            this.MapParameterIn(command, "@PA_LOC_SELCO_SP_ID", record.SelcoSpId);
            this.MapParameterIn(command, "@PA_loc_prole_id", record.LocProleId);
            this.MapParameterIn(command, "@PA_loc_phone", record.LocPhone);
            this.MapParameterIn(command, "@PA_loc_fax", record.LocFax);
            this.MapParameterIn(command, "@PA_loc_phone_std", record.LocPhoneStd);
            this.MapParameterIn(command, "@PA_loc_fax_std", record.LocFaxStd);
            this.MapParameterIn(command, "@PA_loc_email", record.LocEmail);
            this.MapParameterIn(command, "@PA_loc_nearest_1", record.LocNearest1);
            this.MapParameterIn(command, "@PA_loc_nearest_2", record.LocNearest2);
            this.MapParameterIn(command, "@PA_loc_nearest_3", record.LocNearest3);
            this.MapParameterIn(command, "@PA_loc_nearest_4", record.LocNearest4);
            this.MapParameterIn(command, "@PA_loc_nearest_5", record.LocNearest5);
            this.MapParameterIn(command, "@PA_loc_nearest_6", record.LocNearest6);
            this.MapParameterIn(command, "@PA_LOC_MAP_IMAGE_PATH", record.MapImagePath);
            this.MapParameterIn(command, "@PA_LOC_DETAILS_PATH", record.DetailsPath);
            this.MapParameterIn(command, "@PA_LOC_REGION", record.Region);
            this.MapParameterIn(command, "@PA_LOC_DEL_DAY_RATE", record.DelDayRate == Decimal.MinValue ? ( useV6Logic ? new Decimal?(0M) : null ) : record.DelDayRate);
            this.MapParameterIn(command, "@PA_LOC_COST_CODE", record.CostCode);
            this.MapParameterIn(command, "@PA_LOC_REV_CODE", record.RevCode);
            this.MapParameterIn(command, "@PA_LOC_WEB", record.Web);
            this.MapParameterIn(command, "@PA_LOC_VENUE_TYPE", record.VenueType);
            this.MapParameterIn(command, "@PA_LOC_LINKED_LOC_ID", record.LinkedLocId);
            this.MapParameterIn(command, "@PA_LOC_TITLE", record.Title);
            this.MapParameterIn(command, "@PA_LOC_DESCRIPTION", record.Description);
            this.MapParameterIn(command, "@_AUDIT_USER_ID", UserId);
            this.MapParameterIn(command, "@PA_RETURN_ID", record.Id);
        }

        /// <summary>
        ///     Extracts the parameter values for the specified <paramref name="command" /> and applies the values to the specified <typeparamref name="TRecord" /> instance.
        /// </summary>
        /// <param name="command">
        ///     The <see cref="IDbCommand" /> containing the parameters to be mapped.
        /// </param>
        /// <param name="record">
        ///     The <see cref="LocationRecord" /> instance to be updated.
        /// </param>
        protected override void MapParametersOut(IDbCommand command, LocationRecord record)
        {
            record.Id = this.MapParameterOut(command, "@PA_LOC_ID", record.Id);
            record.OrgId = this.MapParameterOut(command, "@PA_LOC_ORG_ID", record.OrgId);
            record.AddId = this.MapParameterOut(command, "@PA_LOC_ADD_ID", record.AddId);
            record.JoinInstrucs = this.MapParameterOut(command, "@PA_LOC_JOIN_INSTRUCS", record.JoinInstrucs);
            record.Ref = this.MapParameterOut(command, "@PA_LOC_REF", record.Ref);
            record.Name = this.MapParameterOut(command, "@PA_LOC_NAME", record.Name);
            record.CertName = this.MapParameterOut(command, "@PA_LOC_CERT_NAME", record.CertName);
            record.External = this.MapParameterOut(command, "@PA_LOC_EXTERNAL", record.External);
            record.ContactName = this.MapParameterOut(command, "@PA_LOC_CONTACT_NAME", record.ContactName);
            record.CostPerDay = this.MapParameterOut(command, "@PA_LOC_COST_PER_DAY", record.CostPerDay);
            record.DelPerDay = this.MapParameterOut(command, "@PA_LOC_DEL_PER_DAY", record.DelPerDay);
            record.MaxPlaces = this.MapParameterOut(command, "@PA_LOC_MAX_PLACES", record.MaxPlaces);
            record.Size = this.MapParameterOut(command, "@PA_LOC_SIZE", record.Size);
            record.MapId = this.MapParameterOut(command, "@PA_LOC_MAP_ID", record.MapId);
            record.Bedroom = this.MapParameterOut(command, "@PA_LOC_BEDROOM", record.Bedroom);
            record.RoomType = this.MapParameterOut(command, "@PA_LOC_ROOM_TYPE", record.RoomType);
            record.RoomGrade = this.MapParameterOut(command, "@PA_LOC_ROOM_GRADE", record.RoomGrade);
            record.Direction = this.MapParameterOut(command, "@PA_LOC_DIRECTION", record.Direction);
            record.Html = this.MapParameterOut(command, "@PA_LOC_HTML", record.Html);
            record.Url = this.MapParameterOut(command, "@PA_LOC_URL", record.Url);
            record.MapFile = this.MapParameterOut(command, "@PA_LOC_MAP_FILE", record.MapFile);
            record.OurLocation = this.MapParameterOut(command, "@PA_LOC_OUR_LOCATION", record.OurLocation);
            record.TrainProvider = this.MapParameterOut(command, "@PA_LOC_TRAIN_PROVIDER", record.TrainProvider);
            record.TrainLocation = this.MapParameterOut(command, "@PA_LOC_TRAIN_LOCATION", record.TrainLocation);
            record.Hotel = this.MapParameterOut(command, "@PA_LOC_HOTEL", record.Hotel);
            record.Analysis1 = this.MapParameterOut(command, "@PA_LOC_ANALYSIS_1", record.Analysis1);
            record.Analysis2 = this.MapParameterOut(command, "@PA_LOC_ANALYSIS_2", record.Analysis2);
            record.Directions = this.MapParameterOut(command, "@PA_LOC_DIRECTIONS", record.Directions);
            record.Notes = this.MapParameterOut(command, "@PA_LOC_NOTES", record.Notes);
            record.MapName = this.MapParameterOut(command, "@PA_LOC_MAP_NAME", record.MapName);
            record.SelcoSpId = this.MapParameterOut(command, "@PA_LOC_SELCO_SP_ID", record.SelcoSpId);
            record.LocProleId = this.MapParameterOut(command, "@PA_loc_prole_id", record.LocProleId);
            record.LocPhone = this.MapParameterOut(command, "@PA_loc_phone", record.LocPhone);
            record.LocFax = this.MapParameterOut(command, "@PA_loc_fax", record.LocFax);
            record.LocPhoneStd = this.MapParameterOut(command, "@PA_loc_phone_std", record.LocPhoneStd);
            record.LocFaxStd = this.MapParameterOut(command, "@PA_loc_fax_std", record.LocFaxStd);
            record.LocEmail = this.MapParameterOut(command, "@PA_loc_email", record.LocEmail);
            record.LocNearest1 = this.MapParameterOut(command, "@PA_loc_nearest_1", record.LocNearest1);
            record.LocNearest2 = this.MapParameterOut(command, "@PA_loc_nearest_2", record.LocNearest2);
            record.LocNearest3 = this.MapParameterOut(command, "@PA_loc_nearest_3", record.LocNearest3);
            record.LocNearest4 = this.MapParameterOut(command, "@PA_loc_nearest_4", record.LocNearest4);
            record.LocNearest5 = this.MapParameterOut(command, "@PA_loc_nearest_5", record.LocNearest5);
            record.LocNearest6 = this.MapParameterOut(command, "@PA_loc_nearest_6", record.LocNearest6);
            record.MapImagePath = this.MapParameterOut(command, "@PA_LOC_MAP_IMAGE_PATH", record.MapImagePath);
            record.DetailsPath = this.MapParameterOut(command, "@PA_LOC_DETAILS_PATH", record.DetailsPath);
            record.Region = this.MapParameterOut(command, "@PA_LOC_REGION", record.Region);
            record.DelDayRate = this.MapParameterOut(command, "@PA_LOC_DEL_DAY_RATE", record.DelDayRate);
            record.CostCode = this.MapParameterOut(command, "@PA_LOC_COST_CODE", record.CostCode);
            record.RevCode = this.MapParameterOut(command, "@PA_LOC_REV_CODE", record.RevCode);
            record.Web = this.MapParameterOut(command, "@PA_LOC_WEB", record.Web);
            record.VenueType = this.MapParameterOut(command, "@PA_LOC_VENUE_TYPE", record.VenueType);
            record.LinkedLocId = this.MapParameterOut(command, "@PA_LOC_LINKED_LOC_ID", record.LinkedLocId);
            record.Title = this.MapParameterOut(command, "@PA_LOC_TITLE", record.Title);
            record.Description = this.MapParameterOut(command, "@PA_LOC_DESCRIPTION", record.Description);
            record.Id = this.MapParameterOut(command, "@PA_RETURN_ID", record.Id);
        }

        /// <summary>
        ///     Retrieves a collection of <see cref="LocationRecord" /> instances from the data store.
        /// </summary>
        /// <param name="orgId">
        ///     The value which identifies the <see cref='LocationModel' /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The collection of <see cref="LocationRecord" /> instances that match the specified <paramref name='orgId' />.
        /// </returns>
        public IEnumerable<LocationRecord> FetchAllByOrgId(String orgId)
        {
            DbCommand command = this.GetStoredProcedure(SqlServerOperation.FetchAll, "OrgId");
            this.MapParameterIn(command, "@PA_LOC_ORG_ID", orgId);
            return this.Execute(command);
        }

        /// <summary>
        ///     Retrieves a collection of <see cref="LocationRecord" /> instances from the data store.
        /// </summary>
        /// <param name="addId">
        ///     The value which identifies the <see cref='LocationModel' /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The collection of <see cref="LocationRecord" /> instances that match the specified <paramref name='addId' />.
        /// </returns>
        public IEnumerable<LocationRecord> FetchAllByAddId(String addId)
        {
            DbCommand command = this.GetStoredProcedure(SqlServerOperation.FetchAll, "AddId");
            this.MapParameterIn(command, "@PA_LOC_ADD_ID", addId);
            return this.Execute(command);
        }

        /// <summary>
        ///     Retrieves a collection of <see cref="LocationRecord" /> instances from the data store.
        /// </summary>
        /// <param name="selcoSpId">
        ///     The value which identifies the <see cref='LocationModel' /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The collection of <see cref="LocationRecord" /> instances that match the specified <paramref name='selcoSpId' />.
        /// </returns>
        public IEnumerable<LocationRecord> FetchAllBySelcoSpId(String selcoSpId)
        {
            DbCommand command = this.GetStoredProcedure(SqlServerOperation.FetchAll, "SelcoSpId");
            this.MapParameterIn(command, "@PA_LOC_SELCO_SP_ID", selcoSpId);
            return this.Execute(command);
        }

        /// <summary>
        ///     Retrieves a collection of <see cref="LocationRecord" /> instances from the data store.
        /// </summary>
        /// <param name="locProleId">
        ///     The value which identifies the <see cref='LocationModel' /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The collection of <see cref="LocationRecord" /> instances that match the specified <paramref name='locProleId' />.
        /// </returns>
        public IEnumerable<LocationRecord> FetchAllByLocProleId(String locProleId)
        {
            DbCommand command = this.GetStoredProcedure(SqlServerOperation.FetchAll, "LocProleId");
            this.MapParameterIn(command, "@PA_loc_prole_id", locProleId);
            return this.Execute(command);
        }

        /// <summary>
        ///     Retrieves a collection of <see cref="LocationRecord" /> instances from the data store.
        /// </summary>
        /// <param name="linkedLocId">
        ///     The value which identifies the <see cref='LocationModel' /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The collection of <see cref="LocationRecord" /> instances that match the specified <paramref name='linkedLocId' />.
        /// </returns>
        public IEnumerable<LocationRecord> FetchAllByLinkedLocId(String linkedLocId)
        {
            DbCommand command = this.GetStoredProcedure(SqlServerOperation.FetchAll, "LinkedLocId");
            this.MapParameterIn(command, "@PA_LOC_LINKED_LOC_ID", linkedLocId);
            return this.Execute(command);
        }

        #endregion

        #region implementations

        /// <summary>
        ///     Gets the underlying table name that this repository sit over.
        /// </summary>
        System.String ILocationRepository.TableName
        {
            get { return this.TableName; }
        }

        /// <summary>
        ///     Retrieves a collection of <see cref="T:Consensus.Contact.LocationRecord" /> instances from the data store.
        /// </summary>
        /// <param name="orgId">
        ///     The value which identifies the <see cref="!:LocationModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The collection of <see cref="T:Consensus.Contact.LocationRecord" /> instances that match the specified <paramref name="orgId" />.
        /// </returns>
        System.Collections.Generic.IEnumerable<Consensus.Contact.LocationRecord> ILocationRepository.FetchAllByOrgId(System.String orgId)
        {
            return this.FetchAllByOrgId(orgId);
        }

        /// <summary>
        ///     Retrieves a collection of <see cref="T:Consensus.Contact.LocationRecord" /> instances from the data store.
        /// </summary>
        /// <param name="addId">
        ///     The value which identifies the <see cref="!:LocationModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The collection of <see cref="T:Consensus.Contact.LocationRecord" /> instances that match the specified <paramref name="addId" />.
        /// </returns>
        System.Collections.Generic.IEnumerable<Consensus.Contact.LocationRecord> ILocationRepository.FetchAllByAddId(System.String addId)
        {
            return this.FetchAllByAddId(addId);
        }

        /// <summary>
        ///     Retrieves a collection of <see cref="T:Consensus.Contact.LocationRecord" /> instances from the data store.
        /// </summary>
        /// <param name="selcoSpId">
        ///     The value which identifies the <see cref="!:LocationModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The collection of <see cref="T:Consensus.Contact.LocationRecord" /> instances that match the specified <paramref name="selcoSpId" />.
        /// </returns>
        System.Collections.Generic.IEnumerable<Consensus.Contact.LocationRecord> ILocationRepository.FetchAllBySelcoSpId(System.String selcoSpId)
        {
            return this.FetchAllBySelcoSpId(selcoSpId);
        }

        /// <summary>
        ///     Retrieves a collection of <see cref="T:Consensus.Contact.LocationRecord" /> instances from the data store.
        /// </summary>
        /// <param name="locProleId">
        ///     The value which identifies the <see cref="!:LocationModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The collection of <see cref="T:Consensus.Contact.LocationRecord" /> instances that match the specified <paramref name="locProleId" />.
        /// </returns>
        System.Collections.Generic.IEnumerable<Consensus.Contact.LocationRecord> ILocationRepository.FetchAllByLocProleId(System.String locProleId)
        {
            return this.FetchAllByLocProleId(locProleId);
        }

        /// <summary>
        ///     Retrieves a collection of <see cref="T:Consensus.Contact.LocationRecord" /> instances from the data store.
        /// </summary>
        /// <param name="linkedLocId">
        ///     The value which identifies the <see cref="!:LocationModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The collection of <see cref="T:Consensus.Contact.LocationRecord" /> instances that match the specified <paramref name="linkedLocId" />.
        /// </returns>
        System.Collections.Generic.IEnumerable<Consensus.Contact.LocationRecord> ILocationRepository.FetchAllByLinkedLocId(System.String linkedLocId)
        {
            return this.FetchAllByLinkedLocId(linkedLocId);
        }

        #endregion
    }
}
