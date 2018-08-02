using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Linq;

namespace Consensus.Contact
{
    /// <summary>
    ///     Represents the "Address" data structure.
    /// </summary>
    /// <remarks>
    ///     THIS CODE HAS BEEN AUTOMATICALLY GENERATED USING THE CONSENSUS DEVELOPER TOOLS.
    ///     DO NOT EDIT THIS CODE AS ANY CUSTOM MODIFICATIONS WILL BE LOST UPON REGENERATION.
    /// </remarks>
    public class AddressRecord : Record<String>, Cloneable<AddressRecord>, IEquatable<AddressRecord>
    {
        #region fields

        /// <summary>
        ///     the value of the "ADD_LOCK" field.
        /// </summary>
        private String _lock;

        /// <summary>
        ///     the value of the "ADD_ADD_DATE" field.
        /// </summary>
        private DateTime? _addDate;

        /// <summary>
        ///     the value of the "ADD_ADD_BY" field.
        /// </summary>
        private String _addBy;

        /// <summary>
        ///     the value of the "ADD_MOD_DATE" field.
        /// </summary>
        private DateTime? _modDate;

        /// <summary>
        ///     the value of the "ADD_MOD_BY" field.
        /// </summary>
        private String _modBy;

        /// <summary>
        ///     the value of the "ADD_RCV_DATE" field.
        /// </summary>
        private DateTime? _rcvDate;

        /// <summary>
        ///     the value of the "ADD_RCV_FROM" field.
        /// </summary>
        private String _rcvFrom;

        /// <summary>
        ///     the value of the "ADD_BUILDING" field.
        /// </summary>
        private String _building;

        /// <summary>
        ///     the value of the "ADD_STREET" field.
        /// </summary>
        private String _street;

        /// <summary>
        ///     the value of the "ADD_TOWN" field.
        /// </summary>
        private String _town;

        /// <summary>
        ///     the value of the "ADD_AREA" field.
        /// </summary>
        private String _area;

        /// <summary>
        ///     the value of the "ADD_COUNTY" field.
        /// </summary>
        private String _county;

        /// <summary>
        ///     the value of the "ADD_POSTCODE" field.
        /// </summary>
        private String _postcode;

        /// <summary>
        ///     the value of the "ADD_COUNTRY" field.
        /// </summary>
        private String _country;

        /// <summary>
        ///     the value of the "ADD_COUNTRY_STYLE" field.
        /// </summary>
        private String _countryStyle;

        /// <summary>
        ///     the value of the "ADD_MAILSTRING" field.
        /// </summary>
        private String _mailstring;

        /// <summary>
        ///     the value of the "ADD_MAP" field.
        /// </summary>
        private String _map;

        /// <summary>
        ///     the value of the "ADD_JOINING_INSTRC" field.
        /// </summary>
        private String _joiningInstrc;

        /// <summary>
        ///     the value of the "ADD_COUNTRY_VALUE" field.
        /// </summary>
        private Byte? _countryValue;

        /// <summary>
        ///     the value of the "ADD_CO_CODE" field.
        /// </summary>
        private String _coCode;

        /// <summary>
        ///     the value of the "ADD_CO_AREA" field.
        /// </summary>
        private String _coArea;

        /// <summary>
        ///     the value of the "ADD_CO_REGION" field.
        /// </summary>
        private String _coRegion;

        /// <summary>
        ///     the value of the "ADD_USERCHAR_1" field.
        /// </summary>
        private String _userchar1;

        /// <summary>
        ///     the value of the "ADD_USERCHAR_2" field.
        /// </summary>
        private String _userchar2;

        /// <summary>
        ///     the value of the "ADD_USERCHAR_3" field.
        /// </summary>
        private String _userchar3;

        /// <summary>
        ///     the value of the "ADD_DRTION_TEXT" field.
        /// </summary>
        private String _drtionText;

        /// <summary>
        ///     the value of the "ADD_DRTION_HTML" field.
        /// </summary>
        private String _drtionHtml;

        /// <summary>
        ///     the value of the "ADD_LOCATION_URL" field.
        /// </summary>
        private String _locationUrl;

        /// <summary>
        ///     the value of the "ADD_PHONE" field.
        /// </summary>
        private String _phone;

        /// <summary>
        ///     the value of the "ADD_FAX" field.
        /// </summary>
        private String _fax;

        /// <summary>
        ///     the value of the "ADD_EMAIL" field.
        /// </summary>
        private String _email;

        /// <summary>
        ///     the value of the "ADD_CUSTOMER_ACC" field.
        /// </summary>
        private String _customerAcc;

        /// <summary>
        ///     the value of the "ADD_5" field.
        /// </summary>
        private String _line5;

        /// <summary>
        ///     the value of the "ADD_PHONE_STD" field.
        /// </summary>
        private String _phoneStd;

        /// <summary>
        ///     the value of the "ADD_FAX_STD" field.
        /// </summary>
        private String _faxStd;

        /// <summary>
        ///     the value of the "ADD_LAT" field.
        /// </summary>
        private Decimal? _lat;

        /// <summary>
        ///     the value of the "ADD_LONG" field.
        /// </summary>
        private Decimal? _long;

        /// <summary>
        ///     the value of the "ADD_GRID_EAST" field.
        /// </summary>
        private String _gridEast;

        /// <summary>
        ///     the value of the "ADD_GRID_NORTH" field.
        /// </summary>
        private String _gridNorth;

        /// <summary>
        ///     the value of the "ADD_BAT_ID" field.
        /// </summary>
        private String _batId;

        /// <summary>
        ///     the value of the "ADD_DX_CODE" field.
        /// </summary>
        private String _dxCode;

        /// <summary>
        ///     the value of the "ADD_DX_EXCHANGE" field.
        /// </summary>
        private String _dxExchange;

        /// <summary>
        ///     the value of the "ADD_DX_BARCODE" field.
        /// </summary>
        private String _dxBarcode;

        /// <summary>
        ///     the value of the "ADD_MAILSORT_CODE" field.
        /// </summary>
        private String _mailsortCode;

        #endregion

        #region properties

        /// <summary>
        ///     the value of the "ADD_LOCK" field.
        /// </summary>
        public String Lock
        {
            get { return _lock; }
            set { _lock = value; }
        }

        /// <summary>
        ///     the value of the "ADD_ADD_DATE" field.
        /// </summary>
        public DateTime? AddDate
        {
            get { return _addDate; }
            set { _addDate = value; }
        }

        /// <summary>
        ///     the value of the "ADD_ADD_BY" field.
        /// </summary>
        public String AddBy
        {
            get { return _addBy; }
            set { _addBy = value; }
        }

        /// <summary>
        ///     the value of the "ADD_MOD_DATE" field.
        /// </summary>
        public DateTime? ModDate
        {
            get { return _modDate; }
            set { _modDate = value; }
        }

        /// <summary>
        ///     the value of the "ADD_MOD_BY" field.
        /// </summary>
        public String ModBy
        {
            get { return _modBy; }
            set { _modBy = value; }
        }

        /// <summary>
        ///     the value of the "ADD_RCV_DATE" field.
        /// </summary>
        public DateTime? RcvDate
        {
            get { return _rcvDate; }
            set { _rcvDate = value; }
        }

        /// <summary>
        ///     the value of the "ADD_RCV_FROM" field.
        /// </summary>
        public String RcvFrom
        {
            get { return _rcvFrom; }
            set { _rcvFrom = value; }
        }

        /// <summary>
        ///     the value of the "ADD_BUILDING" field.
        /// </summary>
        public String Building
        {
            get { return _building; }
            set { _building = value; }
        }

        /// <summary>
        ///     the value of the "ADD_STREET" field.
        /// </summary>
        public String Street
        {
            get { return _street; }
            set { _street = value; }
        }

        /// <summary>
        ///     the value of the "ADD_TOWN" field.
        /// </summary>
        public String Town
        {
            get { return _town; }
            set { _town = value; }
        }

        /// <summary>
        ///     the value of the "ADD_AREA" field.
        /// </summary>
        public String Area
        {
            get { return _area; }
            set { _area = value; }
        }

        /// <summary>
        ///     the value of the "ADD_COUNTY" field.
        /// </summary>
        public String County
        {
            get { return _county; }
            set { _county = value; }
        }

        /// <summary>
        ///     the value of the "ADD_POSTCODE" field.
        /// </summary>
        public String Postcode
        {
            get { return _postcode; }
            set { _postcode = value; }
        }

        /// <summary>
        ///     the value of the "ADD_COUNTRY" field.
        /// </summary>
        public String Country
        {
            get { return _country; }
            set { _country = value; }
        }

        /// <summary>
        ///     the value of the "ADD_COUNTRY_STYLE" field.
        /// </summary>
        public String CountryStyle
        {
            get { return _countryStyle; }
            set { _countryStyle = value; }
        }

        /// <summary>
        ///     the value of the "ADD_MAILSTRING" field.
        /// </summary>
        public String Mailstring
        {
            get { return _mailstring; }
            set { _mailstring = value; }
        }

        /// <summary>
        ///     the value of the "ADD_MAP" field.
        /// </summary>
        public String Map
        {
            get { return _map; }
            set { _map = value; }
        }

        /// <summary>
        ///     the value of the "ADD_JOINING_INSTRC" field.
        /// </summary>
        public String JoiningInstrc
        {
            get { return _joiningInstrc; }
            set { _joiningInstrc = value; }
        }

        /// <summary>
        ///     the value of the "ADD_COUNTRY_VALUE" field.
        /// </summary>
        public Byte? CountryValue
        {
            get { return _countryValue; }
            set { _countryValue = value; }
        }

        /// <summary>
        ///     the value of the "ADD_CO_CODE" field.
        /// </summary>
        public String CoCode
        {
            get { return _coCode; }
            set { _coCode = value; }
        }

        /// <summary>
        ///     the value of the "ADD_CO_AREA" field.
        /// </summary>
        public String CoArea
        {
            get { return _coArea; }
            set { _coArea = value; }
        }

        /// <summary>
        ///     the value of the "ADD_CO_REGION" field.
        /// </summary>
        public String CoRegion
        {
            get { return _coRegion; }
            set { _coRegion = value; }
        }

        /// <summary>
        ///     the value of the "ADD_USERCHAR_1" field.
        /// </summary>
        public String Userchar1
        {
            get { return _userchar1; }
            set { _userchar1 = value; }
        }

        /// <summary>
        ///     the value of the "ADD_USERCHAR_2" field.
        /// </summary>
        public String Userchar2
        {
            get { return _userchar2; }
            set { _userchar2 = value; }
        }

        /// <summary>
        ///     the value of the "ADD_USERCHAR_3" field.
        /// </summary>
        public String Userchar3
        {
            get { return _userchar3; }
            set { _userchar3 = value; }
        }

        /// <summary>
        ///     the value of the "ADD_DRTION_TEXT" field.
        /// </summary>
        public String DrtionText
        {
            get { return _drtionText; }
            set { _drtionText = value; }
        }

        /// <summary>
        ///     the value of the "ADD_DRTION_HTML" field.
        /// </summary>
        public String DrtionHtml
        {
            get { return _drtionHtml; }
            set { _drtionHtml = value; }
        }

        /// <summary>
        ///     the value of the "ADD_LOCATION_URL" field.
        /// </summary>
        public String LocationUrl
        {
            get { return _locationUrl; }
            set { _locationUrl = value; }
        }

        /// <summary>
        ///     the value of the "ADD_PHONE" field.
        /// </summary>
        public String Phone
        {
            get { return _phone; }
            set { _phone = value; }
        }

        /// <summary>
        ///     the value of the "ADD_FAX" field.
        /// </summary>
        public String Fax
        {
            get { return _fax; }
            set { _fax = value; }
        }

        /// <summary>
        ///     the value of the "ADD_EMAIL" field.
        /// </summary>
        public String Email
        {
            get { return _email; }
            set { _email = value; }
        }

        /// <summary>
        ///     the value of the "ADD_CUSTOMER_ACC" field.
        /// </summary>
        public String CustomerAcc
        {
            get { return _customerAcc; }
            set { _customerAcc = value; }
        }

        /// <summary>
        ///     the value of the "ADD_5" field.
        /// </summary>
        public String Line5
        {
            get { return _line5; }
            set { _line5 = value; }
        }

        /// <summary>
        ///     the value of the "ADD_PHONE_STD" field.
        /// </summary>
        public String PhoneStd
        {
            get { return _phoneStd; }
            set { _phoneStd = value; }
        }

        /// <summary>
        ///     the value of the "ADD_FAX_STD" field.
        /// </summary>
        public String FaxStd
        {
            get { return _faxStd; }
            set { _faxStd = value; }
        }

        /// <summary>
        ///     the value of the "ADD_LAT" field.
        /// </summary>
        public Decimal? Lat
        {
            get { return _lat; }
            set { _lat = value; }
        }

        /// <summary>
        ///     the value of the "ADD_LONG" field.
        /// </summary>
        public Decimal? Long
        {
            get { return _long; }
            set { _long = value; }
        }

        /// <summary>
        ///     the value of the "ADD_GRID_EAST" field.
        /// </summary>
        public String GridEast
        {
            get { return _gridEast; }
            set { _gridEast = value; }
        }

        /// <summary>
        ///     the value of the "ADD_GRID_NORTH" field.
        /// </summary>
        public String GridNorth
        {
            get { return _gridNorth; }
            set { _gridNorth = value; }
        }

        /// <summary>
        ///     the value of the "ADD_BAT_ID" field.
        /// </summary>
        public String BatId
        {
            get { return _batId; }
            set { _batId = value; }
        }

        /// <summary>
        ///     the value of the "ADD_DX_CODE" field.
        /// </summary>
        public String DxCode
        {
            get { return _dxCode; }
            set { _dxCode = value; }
        }

        /// <summary>
        ///     the value of the "ADD_DX_EXCHANGE" field.
        /// </summary>
        public String DxExchange
        {
            get { return _dxExchange; }
            set { _dxExchange = value; }
        }

        /// <summary>
        ///     the value of the "ADD_DX_BARCODE" field.
        /// </summary>
        public String DxBarcode
        {
            get { return _dxBarcode; }
            set { _dxBarcode = value; }
        }

        /// <summary>
        ///     the value of the "ADD_MAILSORT_CODE" field.
        /// </summary>
        public String MailsortCode
        {
            get { return _mailsortCode; }
            set { _mailsortCode = value; }
        }

        #endregion

        #region methods

        /// <summary>
        ///     Creates a new <see cref="AddressRecord" /> object instance that is a shallow-copy of the current object instance.
        /// </summary>
        /// <returns>
        ///     The shallow-copy of the current <see cref="AddressRecord" /> object instance.
        /// </returns>
        public AddressRecord Clone()
        {
            AddressRecord record = new AddressRecord();
            record.Id = this.Id;
            record.Lock = this.Lock;
            record.AddDate = this.AddDate;
            record.AddBy = this.AddBy;
            record.ModDate = this.ModDate;
            record.ModBy = this.ModBy;
            record.RcvDate = this.RcvDate;
            record.RcvFrom = this.RcvFrom;
            record.Building = this.Building;
            record.Street = this.Street;
            record.Town = this.Town;
            record.Area = this.Area;
            record.County = this.County;
            record.Postcode = this.Postcode;
            record.Country = this.Country;
            record.CountryStyle = this.CountryStyle;
            record.Mailstring = this.Mailstring;
            record.Map = this.Map;
            record.JoiningInstrc = this.JoiningInstrc;
            record.CountryValue = this.CountryValue;
            record.CoCode = this.CoCode;
            record.CoArea = this.CoArea;
            record.CoRegion = this.CoRegion;
            record.Userchar1 = this.Userchar1;
            record.Userchar2 = this.Userchar2;
            record.Userchar3 = this.Userchar3;
            record.DrtionText = this.DrtionText;
            record.DrtionHtml = this.DrtionHtml;
            record.LocationUrl = this.LocationUrl;
            record.Phone = this.Phone;
            record.Fax = this.Fax;
            record.Email = this.Email;
            record.CustomerAcc = this.CustomerAcc;
            record.Line5 = this.Line5;
            record.PhoneStd = this.PhoneStd;
            record.FaxStd = this.FaxStd;
            record.Lat = this.Lat;
            record.Long = this.Long;
            record.GridEast = this.GridEast;
            record.GridNorth = this.GridNorth;
            record.BatId = this.BatId;
            record.DxCode = this.DxCode;
            record.DxExchange = this.DxExchange;
            record.DxBarcode = this.DxBarcode;
            record.MailsortCode = this.MailsortCode;
            return record;
        }

        /// <summary>
        ///     Indicates whether the current <see cref="AddressRecord" /> instance is equal to another <see cref="AddressRecord" /> instance.
        /// </summary>
        /// <param name="that">
        ///     The <see cref="AddressRecord" /> instance to be compared against this instance.
        /// </param>
        /// <returns>
        ///     True if both instances are considered equal; otherwise, false.
        /// </returns>
        public Boolean Equals(AddressRecord that)
        {
            Boolean result = true;
            result = result && (this.Id.TrimOrNullify() == that.Id.TrimOrNullify());
            result = result && (this.Lock.TrimOrNullify() == that.Lock.TrimOrNullify());
            result = result && (this.Building.TrimOrNullify() == that.Building.TrimOrNullify());
            result = result && (this.Street.TrimOrNullify() == that.Street.TrimOrNullify());
            result = result && (this.Town.TrimOrNullify() == that.Town.TrimOrNullify());
            result = result && (this.Area.TrimOrNullify() == that.Area.TrimOrNullify());
            result = result && (this.County.TrimOrNullify() == that.County.TrimOrNullify());
            result = result && (this.Postcode.TrimOrNullify() == that.Postcode.TrimOrNullify());
            result = result && (this.Country.TrimOrNullify() == that.Country.TrimOrNullify());
            result = result && (this.CountryStyle.TrimOrNullify() == that.CountryStyle.TrimOrNullify());
            result = result && (this.Mailstring.TrimOrNullify() == that.Mailstring.TrimOrNullify());
            result = result && (this.Map.TrimOrNullify() == that.Map.TrimOrNullify());
            result = result && (this.JoiningInstrc.TrimOrNullify() == that.JoiningInstrc.TrimOrNullify());
            result = result && (this.CountryValue == that.CountryValue);
            result = result && (this.CoCode.TrimOrNullify() == that.CoCode.TrimOrNullify());
            result = result && (this.CoArea.TrimOrNullify() == that.CoArea.TrimOrNullify());
            result = result && (this.CoRegion.TrimOrNullify() == that.CoRegion.TrimOrNullify());
            result = result && (this.Userchar1.TrimOrNullify() == that.Userchar1.TrimOrNullify());
            result = result && (this.Userchar2.TrimOrNullify() == that.Userchar2.TrimOrNullify());
            result = result && (this.Userchar3.TrimOrNullify() == that.Userchar3.TrimOrNullify());
            result = result && (this.DrtionText.TrimOrNullify() == that.DrtionText.TrimOrNullify());
            result = result && (this.DrtionHtml.TrimOrNullify() == that.DrtionHtml.TrimOrNullify());
            result = result && (this.LocationUrl.TrimOrNullify() == that.LocationUrl.TrimOrNullify());
            result = result && (this.Phone.TrimOrNullify() == that.Phone.TrimOrNullify());
            result = result && (this.Fax.TrimOrNullify() == that.Fax.TrimOrNullify());
            result = result && (this.Email.TrimOrNullify() == that.Email.TrimOrNullify());
            result = result && (this.CustomerAcc.TrimOrNullify() == that.CustomerAcc.TrimOrNullify());
            result = result && (this.Line5.TrimOrNullify() == that.Line5.TrimOrNullify());
            result = result && (this.PhoneStd.TrimOrNullify() == that.PhoneStd.TrimOrNullify());
            result = result && (this.FaxStd.TrimOrNullify() == that.FaxStd.TrimOrNullify());
            result = result && (this.Lat == that.Lat);
            result = result && (this.Long == that.Long);
            result = result && (this.GridEast.TrimOrNullify() == that.GridEast.TrimOrNullify());
            result = result && (this.GridNorth.TrimOrNullify() == that.GridNorth.TrimOrNullify());
            result = result && (this.BatId.TrimOrNullify() == that.BatId.TrimOrNullify());
            result = result && (this.DxCode.TrimOrNullify() == that.DxCode.TrimOrNullify());
            result = result && (this.DxExchange.TrimOrNullify() == that.DxExchange.TrimOrNullify());
            result = result && (this.DxBarcode.TrimOrNullify() == that.DxBarcode.TrimOrNullify());
            result = result && (this.MailsortCode.TrimOrNullify() == that.MailsortCode.TrimOrNullify());
            return result;
        }

        #endregion
    }
}
