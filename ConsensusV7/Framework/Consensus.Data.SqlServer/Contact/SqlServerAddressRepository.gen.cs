using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Linq;

namespace Consensus.Contact
{
    /// <summary>
    ///     Provides the persistence and retrieval of the <see cref="AddressRecord" /> instances in a Microsoft SQL Server database.
    /// </summary>
    /// <remarks>
    ///     THIS CODE HAS BEEN AUTOMATICALLY GENERATED USING THE CONSENSUS DEVELOPER TOOLS.
    ///     DO NOT EDIT THIS CODE AS ANY CUSTOM MODIFICATIONS WILL BE LOST UPON REGENERATION.
    /// </remarks>
    public partial class SqlServerAddressRepository : SqlServerRepository<AddressRecord, String>, IAddressRepository
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
            get { return "Address"; }
        }

        /// <summary>
        ///     Gets the name of the parameter which is used to specify the unique value that identifies each instance of a <see cref="AddressRecord" />.
        /// </summary>
        protected override String TypeKeyName
        {
            get { return "@PA_ADD_ID"; }
        }

        /// <summary>
        ///     Gets the underlying table name that this repository sit over.
        /// </summary>
        public override String TableName
        {
            get { return "Address"; }
        }

        #endregion

        #region methods

        /// <summary>
        ///     Maps an <see cref="IDataRecord" /> to the specified <see cref="AddressRecord" />.
        /// </summary>
        /// <param name="dataRecord">
        ///     The <see cref="IDataRecord" /> to be mapped.
        /// </param>
        /// <param name="record">
        ///     The <see cref="AddressRecord" /> instance to be mapped to.
        /// </param>
        protected override void MapRecord(IDataRecord dataRecord, AddressRecord record)
        {
            record.Id = dataRecord["ADD_ID"].ConvertTo<String>();
            record.Lock = dataRecord["ADD_LOCK"].ConvertTo<String>();
            record.AddDate = dataRecord["ADD_ADD_DATE"].ConvertTo<DateTime?>();
            record.AddBy = dataRecord["ADD_ADD_BY"].ConvertTo<String>();
            record.ModDate = dataRecord["ADD_MOD_DATE"].ConvertTo<DateTime?>();
            record.ModBy = dataRecord["ADD_MOD_BY"].ConvertTo<String>();
            record.RcvDate = dataRecord["ADD_RCV_DATE"].ConvertTo<DateTime?>();
            record.RcvFrom = dataRecord["ADD_RCV_FROM"].ConvertTo<String>();
            record.Building = dataRecord["ADD_BUILDING"].ConvertTo<String>();
            record.Street = dataRecord["ADD_STREET"].ConvertTo<String>();
            record.Town = dataRecord["ADD_TOWN"].ConvertTo<String>();
            record.Area = dataRecord["ADD_AREA"].ConvertTo<String>();
            record.County = dataRecord["ADD_COUNTY"].ConvertTo<String>();
            record.Postcode = dataRecord["ADD_POSTCODE"].ConvertTo<String>();
            record.Country = dataRecord["ADD_COUNTRY"].ConvertTo<String>();
            record.CountryStyle = dataRecord["ADD_COUNTRY_STYLE"].ConvertTo<String>();
            record.Mailstring = dataRecord["ADD_MAILSTRING"].ConvertTo<String>();
            record.Map = dataRecord["ADD_MAP"].ConvertTo<String>();
            record.JoiningInstrc = dataRecord["ADD_JOINING_INSTRC"].ConvertTo<String>();
            record.CountryValue = dataRecord["ADD_COUNTRY_VALUE"].ConvertTo<Byte?>();
            record.CoCode = dataRecord["ADD_CO_CODE"].ConvertTo<String>();
            record.CoArea = dataRecord["ADD_CO_AREA"].ConvertTo<String>();
            record.CoRegion = dataRecord["ADD_CO_REGION"].ConvertTo<String>();
            record.Userchar1 = dataRecord["ADD_USERCHAR_1"].ConvertTo<String>();
            record.Userchar2 = dataRecord["ADD_USERCHAR_2"].ConvertTo<String>();
            record.Userchar3 = dataRecord["ADD_USERCHAR_3"].ConvertTo<String>();
            record.DrtionText = dataRecord["ADD_DRTION_TEXT"].ConvertTo<String>();
            record.DrtionHtml = dataRecord["ADD_DRTION_HTML"].ConvertTo<String>();
            record.LocationUrl = dataRecord["ADD_LOCATION_URL"].ConvertTo<String>();
            record.Phone = dataRecord["ADD_PHONE"].ConvertTo<String>();
            record.Fax = dataRecord["ADD_FAX"].ConvertTo<String>();
            record.Email = dataRecord["ADD_EMAIL"].ConvertTo<String>();
            record.CustomerAcc = dataRecord["ADD_CUSTOMER_ACC"].ConvertTo<String>();
            record.Line5 = dataRecord["ADD_5"].ConvertTo<String>();
            record.PhoneStd = dataRecord["ADD_PHONE_STD"].ConvertTo<String>();
            record.FaxStd = dataRecord["ADD_FAX_STD"].ConvertTo<String>();
            record.Lat = dataRecord["ADD_LAT"].ConvertTo<Decimal?>();
            record.Long = dataRecord["ADD_LONG"].ConvertTo<Decimal?>();
            record.GridEast = dataRecord["ADD_GRID_EAST"].ConvertTo<String>();
            record.GridNorth = dataRecord["ADD_GRID_NORTH"].ConvertTo<String>();
            record.BatId = dataRecord["ADD_BAT_ID"].ConvertTo<String>();
            record.DxCode = dataRecord["ADD_DX_CODE"].ConvertTo<String>();
            record.DxExchange = dataRecord["ADD_DX_EXCHANGE"].ConvertTo<String>();
            record.DxBarcode = dataRecord["ADD_DX_BARCODE"].ConvertTo<String>();
            record.MailsortCode = dataRecord["ADD_MAILSORT_CODE"].ConvertTo<String>();
        }

        /// <summary>
        ///     Sets the parameter values for the specified <paramref name="command" /> based on the specified <typeparamref name="TRecord" /> instance.
        /// </summary>
        /// <param name="command">
        ///     The <see cref="IDbCommand" /> containing the parameters to be mapped.
        /// </param>
        /// <param name="record">
        ///     The <see cref="AddressRecord" /> instance to be mapped.
        /// </param>
        /// <param name="useV6Logic">
        ///     Is the procedure being run an old version 6.x procedure? (the null value handling logic is different).
        /// </param>
        protected override void MapParametersIn(IDbCommand command, AddressRecord record, bool useV6Logic)
        {
            this.MapParameterIn(command, "@PA_ADD_ID", record.Id);
            this.MapParameterIn(command, "@PA_ADD_LOCK", record.Lock);
            this.MapParameterIn(command, "@PA_ADD_BUILDING", record.Building);
            this.MapParameterIn(command, "@PA_ADD_STREET", record.Street);
            this.MapParameterIn(command, "@PA_ADD_TOWN", record.Town);
            this.MapParameterIn(command, "@PA_ADD_AREA", record.Area);
            this.MapParameterIn(command, "@PA_ADD_COUNTY", record.County);
            this.MapParameterIn(command, "@PA_ADD_POSTCODE", record.Postcode);
            this.MapParameterIn(command, "@PA_ADD_COUNTRY", record.Country);
            this.MapParameterIn(command, "@PA_ADD_COUNTRY_STYLE", record.CountryStyle);
            this.MapParameterIn(command, "@PA_ADD_MAILSTRING", record.Mailstring);
            this.MapParameterIn(command, "@PA_ADD_MAP", record.Map);
            this.MapParameterIn(command, "@PA_ADD_JOINING_INSTRC", record.JoiningInstrc);
            this.MapParameterIn(command, "@PA_ADD_COUNTRY_VALUE", record.CountryValue);
            this.MapParameterIn(command, "@PA_ADD_CO_CODE", record.CoCode);
            this.MapParameterIn(command, "@PA_ADD_CO_AREA", record.CoArea);
            this.MapParameterIn(command, "@PA_ADD_CO_REGION", record.CoRegion);
            this.MapParameterIn(command, "@PA_ADD_USERCHAR_1", record.Userchar1);
            this.MapParameterIn(command, "@PA_ADD_USERCHAR_2", record.Userchar2);
            this.MapParameterIn(command, "@PA_ADD_USERCHAR_3", record.Userchar3);
            this.MapParameterIn(command, "@PA_ADD_DRTION_TEXT", record.DrtionText);
            this.MapParameterIn(command, "@PA_ADD_DRTION_HTML", record.DrtionHtml);
            this.MapParameterIn(command, "@PA_ADD_LOCATION_URL", record.LocationUrl);
            this.MapParameterIn(command, "@PA_ADD_PHONE", record.Phone);
            this.MapParameterIn(command, "@PA_ADD_FAX", record.Fax);
            this.MapParameterIn(command, "@PA_ADD_EMAIL", record.Email);
            this.MapParameterIn(command, "@PA_ADD_CUSTOMER_ACC", record.CustomerAcc);
            this.MapParameterIn(command, "@PA_ADD_5", record.Line5);
            this.MapParameterIn(command, "@PA_ADD_PHONE_STD", record.PhoneStd);
            this.MapParameterIn(command, "@PA_ADD_FAX_STD", record.FaxStd);
            this.MapParameterIn(command, "@PA_ADD_LAT", record.Lat == Decimal.MinValue ? ( useV6Logic ? new Decimal?(0M) : null ) : record.Lat);
            this.MapParameterIn(command, "@PA_ADD_LONG", record.Long == Decimal.MinValue ? ( useV6Logic ? new Decimal?(0M) : null ) : record.Long);
            this.MapParameterIn(command, "@PA_ADD_GRID_EAST", record.GridEast);
            this.MapParameterIn(command, "@PA_ADD_GRID_NORTH", record.GridNorth);
            this.MapParameterIn(command, "@PA_ADD_BAT_ID", record.BatId);
            this.MapParameterIn(command, "@PA_ADD_DX_CODE", record.DxCode);
            this.MapParameterIn(command, "@PA_ADD_DX_EXCHANGE", record.DxExchange);
            this.MapParameterIn(command, "@PA_ADD_DX_BARCODE", record.DxBarcode);
            this.MapParameterIn(command, "@PA_ADD_MAILSORT_CODE", record.MailsortCode);
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
        ///     The <see cref="AddressRecord" /> instance to be updated.
        /// </param>
        protected override void MapParametersOut(IDbCommand command, AddressRecord record)
        {
            record.Id = this.MapParameterOut(command, "@PA_ADD_ID", record.Id);
            record.Lock = this.MapParameterOut(command, "@PA_ADD_LOCK", record.Lock);
            record.Building = this.MapParameterOut(command, "@PA_ADD_BUILDING", record.Building);
            record.Street = this.MapParameterOut(command, "@PA_ADD_STREET", record.Street);
            record.Town = this.MapParameterOut(command, "@PA_ADD_TOWN", record.Town);
            record.Area = this.MapParameterOut(command, "@PA_ADD_AREA", record.Area);
            record.County = this.MapParameterOut(command, "@PA_ADD_COUNTY", record.County);
            record.Postcode = this.MapParameterOut(command, "@PA_ADD_POSTCODE", record.Postcode);
            record.Country = this.MapParameterOut(command, "@PA_ADD_COUNTRY", record.Country);
            record.CountryStyle = this.MapParameterOut(command, "@PA_ADD_COUNTRY_STYLE", record.CountryStyle);
            record.Mailstring = this.MapParameterOut(command, "@PA_ADD_MAILSTRING", record.Mailstring);
            record.Map = this.MapParameterOut(command, "@PA_ADD_MAP", record.Map);
            record.JoiningInstrc = this.MapParameterOut(command, "@PA_ADD_JOINING_INSTRC", record.JoiningInstrc);
            record.CountryValue = this.MapParameterOut(command, "@PA_ADD_COUNTRY_VALUE", record.CountryValue);
            record.CoCode = this.MapParameterOut(command, "@PA_ADD_CO_CODE", record.CoCode);
            record.CoArea = this.MapParameterOut(command, "@PA_ADD_CO_AREA", record.CoArea);
            record.CoRegion = this.MapParameterOut(command, "@PA_ADD_CO_REGION", record.CoRegion);
            record.Userchar1 = this.MapParameterOut(command, "@PA_ADD_USERCHAR_1", record.Userchar1);
            record.Userchar2 = this.MapParameterOut(command, "@PA_ADD_USERCHAR_2", record.Userchar2);
            record.Userchar3 = this.MapParameterOut(command, "@PA_ADD_USERCHAR_3", record.Userchar3);
            record.DrtionText = this.MapParameterOut(command, "@PA_ADD_DRTION_TEXT", record.DrtionText);
            record.DrtionHtml = this.MapParameterOut(command, "@PA_ADD_DRTION_HTML", record.DrtionHtml);
            record.LocationUrl = this.MapParameterOut(command, "@PA_ADD_LOCATION_URL", record.LocationUrl);
            record.Phone = this.MapParameterOut(command, "@PA_ADD_PHONE", record.Phone);
            record.Fax = this.MapParameterOut(command, "@PA_ADD_FAX", record.Fax);
            record.Email = this.MapParameterOut(command, "@PA_ADD_EMAIL", record.Email);
            record.CustomerAcc = this.MapParameterOut(command, "@PA_ADD_CUSTOMER_ACC", record.CustomerAcc);
            record.Line5 = this.MapParameterOut(command, "@PA_ADD_5", record.Line5);
            record.PhoneStd = this.MapParameterOut(command, "@PA_ADD_PHONE_STD", record.PhoneStd);
            record.FaxStd = this.MapParameterOut(command, "@PA_ADD_FAX_STD", record.FaxStd);
            record.Lat = this.MapParameterOut(command, "@PA_ADD_LAT", record.Lat);
            record.Long = this.MapParameterOut(command, "@PA_ADD_LONG", record.Long);
            record.GridEast = this.MapParameterOut(command, "@PA_ADD_GRID_EAST", record.GridEast);
            record.GridNorth = this.MapParameterOut(command, "@PA_ADD_GRID_NORTH", record.GridNorth);
            record.BatId = this.MapParameterOut(command, "@PA_ADD_BAT_ID", record.BatId);
            record.DxCode = this.MapParameterOut(command, "@PA_ADD_DX_CODE", record.DxCode);
            record.DxExchange = this.MapParameterOut(command, "@PA_ADD_DX_EXCHANGE", record.DxExchange);
            record.DxBarcode = this.MapParameterOut(command, "@PA_ADD_DX_BARCODE", record.DxBarcode);
            record.MailsortCode = this.MapParameterOut(command, "@PA_ADD_MAILSORT_CODE", record.MailsortCode);
            record.Id = this.MapParameterOut(command, "@PA_RETURN_ID", record.Id);
        }

        #endregion

        #region implementations

        /// <summary>
        ///     Gets the underlying table name that this repository sit over.
        /// </summary>
        System.String IAddressRepository.TableName
        {
            get { return this.TableName; }
        }

        void IAddressRepository.Create(Consensus.Contact.AddressRecord record)
        {
            this.Create(record);
        }

        void IAddressRepository.Modify(Consensus.Contact.AddressRecord record)
        {
            this.Modify(record);
        }

        #endregion
    }
}
