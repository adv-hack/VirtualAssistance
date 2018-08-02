using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Linq;

namespace Consensus.Contact
{
    /// <summary>
    ///     Represents the "Country" data structure.
    /// </summary>
    /// <remarks>
    ///     THIS CODE HAS BEEN AUTOMATICALLY GENERATED USING THE CONSENSUS DEVELOPER TOOLS.
    ///     DO NOT EDIT THIS CODE AS ANY CUSTOM MODIFICATIONS WILL BE LOST UPON REGENERATION.
    /// </remarks>
    public class CountryRecord : Record<String>, Cloneable<CountryRecord>, IEquatable<CountryRecord>
    {
        #region fields

        /// <summary>
        ///     the value of the "CO_ADD_BY" field.
        /// </summary>
        private String _addBy;

        /// <summary>
        ///     the value of the "CO_ADD_DATE" field.
        /// </summary>
        private DateTime? _addDate;

        /// <summary>
        ///     the value of the "CO_MOD_BY" field.
        /// </summary>
        private String _modBy;

        /// <summary>
        ///     the value of the "CO_MOD_DATE" field.
        /// </summary>
        private DateTime? _modDate;

        /// <summary>
        ///     the value of the "CO_RCV_FROM" field.
        /// </summary>
        private String _rcvFrom;

        /// <summary>
        ///     the value of the "CO_RCV_DATE" field.
        /// </summary>
        private DateTime? _rcvDate;

        /// <summary>
        ///     the value of the "CO_NAME" field.
        /// </summary>
        private String _name;

        /// <summary>
        ///     the value of the "CO_FORMAT" field.
        /// </summary>
        private String _format;

        /// <summary>
        ///     the value of the "CO_REP" field.
        /// </summary>
        private String _rep;

        /// <summary>
        ///     the value of the "CO_AREA" field.
        /// </summary>
        private String _area;

        /// <summary>
        ///     the value of the "CO_REP_ID" field.
        /// </summary>
        private String _repId;

        /// <summary>
        ///     the value of the "CO_REP1_ID" field.
        /// </summary>
        private String _rep1Id;

        /// <summary>
        ///     the value of the "CO_REP2_ID" field.
        /// </summary>
        private String _rep2Id;

        /// <summary>
        ///     the value of the "CO_POSTCODE_FLAG" field.
        /// </summary>
        private String _postcodeFlag;

        /// <summary>
        ///     the value of the "CO_ORG_TYPE" field.
        /// </summary>
        private String _orgType;

        /// <summary>
        ///     the value of the "CO_PRODUCT_GROUP" field.
        /// </summary>
        private String _productGroup;

        /// <summary>
        ///     the value of the "CO_POSTCODE" field.
        /// </summary>
        private String _postcode;

        /// <summary>
        ///     the value of the "CO_INDUSTRY" field.
        /// </summary>
        private String _industry;

        /// <summary>
        ///     the value of the "CO_TERR_ID" field.
        /// </summary>
        private String _terrId;

        /// <summary>
        ///     the value of the "CO_LOCK" field.
        /// </summary>
        private String _lock;

        /// <summary>
        ///     the value of the "CO_COUNTY" field.
        /// </summary>
        private String _county;

        /// <summary>
        ///     the value of the "CO_VAT_TYPE" field.
        /// </summary>
        private Byte? _vatType;

        /// <summary>
        ///     the value of the "CO_LANGUAGE" field.
        /// </summary>
        private String _language;

        /// <summary>
        ///     the value of the "CO_CURRENCY" field.
        /// </summary>
        private String _currency;

        /// <summary>
        ///     the value of the "CO_USERCHAR_1" field.
        /// </summary>
        private String _userchar1;

        /// <summary>
        ///     the value of the "CO_USERCHAR_2" field.
        /// </summary>
        private String _userchar2;

        /// <summary>
        ///     the value of the "CO_USERNUM_1" field.
        /// </summary>
        private Double? _usernum1;

        /// <summary>
        ///     the value of the "CO_USERNUM_2" field.
        /// </summary>
        private Double? _usernum2;

        /// <summary>
        ///     the value of the "CO_NOTES" field.
        /// </summary>
        private String _notes;

        /// <summary>
        ///     the value of the "CO_EURO" field.
        /// </summary>
        private Byte? _euro;

        /// <summary>
        ///     the value of the "CO_COUNTRY_CODE" field.
        /// </summary>
        private String _countryCode;

        /// <summary>
        ///     the value of the "CO_TOWN" field.
        /// </summary>
        private String _town;

        /// <summary>
        ///     the value of the "CO_PCODE_LU" field.
        /// </summary>
        private Byte? _pcodeLu;

        /// <summary>
        ///     the value of the "CO_LINE_POS" field.
        /// </summary>
        private String _linePos;

        /// <summary>
        ///     the value of the "CO_VAT_CODE" field.
        /// </summary>
        private String _vatCode;

        /// <summary>
        ///     the value of the "CO_VAT_COUNTRY_CODE" field.
        /// </summary>
        private String _vatCountryCode;

        /// <summary>
        ///     the value of the "CO_MAILSTRING_ORDER" field.
        /// </summary>
        private String _mailstringOrder;

        /// <summary>
        ///     the value of the "CO_MAILSTRING_DISPLAY" field.
        /// </summary>
        private String _mailstringDisplay;

        /// <summary>
        ///     the value of the "CO_MAILSTRING_NEWLINE" field.
        /// </summary>
        private String _mailstringNewline;

        /// <summary>
        ///     the value of the "CO_COUNTRY_CODE_2" field.
        /// </summary>
        private String _countryCode2;

        #endregion

        #region properties

        /// <summary>
        ///     the value of the "CO_ADD_BY" field.
        /// </summary>
        public String AddBy
        {
            get { return _addBy; }
            set { _addBy = value; }
        }

        /// <summary>
        ///     the value of the "CO_ADD_DATE" field.
        /// </summary>
        public DateTime? AddDate
        {
            get { return _addDate; }
            set { _addDate = value; }
        }

        /// <summary>
        ///     the value of the "CO_MOD_BY" field.
        /// </summary>
        public String ModBy
        {
            get { return _modBy; }
            set { _modBy = value; }
        }

        /// <summary>
        ///     the value of the "CO_MOD_DATE" field.
        /// </summary>
        public DateTime? ModDate
        {
            get { return _modDate; }
            set { _modDate = value; }
        }

        /// <summary>
        ///     the value of the "CO_RCV_FROM" field.
        /// </summary>
        public String RcvFrom
        {
            get { return _rcvFrom; }
            set { _rcvFrom = value; }
        }

        /// <summary>
        ///     the value of the "CO_RCV_DATE" field.
        /// </summary>
        public DateTime? RcvDate
        {
            get { return _rcvDate; }
            set { _rcvDate = value; }
        }

        /// <summary>
        ///     the value of the "CO_NAME" field.
        /// </summary>
        public String Name
        {
            get { return _name; }
            set { _name = value; }
        }

        /// <summary>
        ///     the value of the "CO_FORMAT" field.
        /// </summary>
        public String Format
        {
            get { return _format; }
            set { _format = value; }
        }

        /// <summary>
        ///     the value of the "CO_REP" field.
        /// </summary>
        public String Rep
        {
            get { return _rep; }
            set { _rep = value; }
        }

        /// <summary>
        ///     the value of the "CO_AREA" field.
        /// </summary>
        public String Area
        {
            get { return _area; }
            set { _area = value; }
        }

        /// <summary>
        ///     the value of the "CO_REP_ID" field.
        /// </summary>
        public String RepId
        {
            get { return _repId; }
            set { _repId = value; }
        }

        /// <summary>
        ///     the value of the "CO_REP1_ID" field.
        /// </summary>
        public String Rep1Id
        {
            get { return _rep1Id; }
            set { _rep1Id = value; }
        }

        /// <summary>
        ///     the value of the "CO_REP2_ID" field.
        /// </summary>
        public String Rep2Id
        {
            get { return _rep2Id; }
            set { _rep2Id = value; }
        }

        /// <summary>
        ///     the value of the "CO_POSTCODE_FLAG" field.
        /// </summary>
        public String PostcodeFlag
        {
            get { return _postcodeFlag; }
            set { _postcodeFlag = value; }
        }

        /// <summary>
        ///     the value of the "CO_ORG_TYPE" field.
        /// </summary>
        public String OrgType
        {
            get { return _orgType; }
            set { _orgType = value; }
        }

        /// <summary>
        ///     the value of the "CO_PRODUCT_GROUP" field.
        /// </summary>
        public String ProductGroup
        {
            get { return _productGroup; }
            set { _productGroup = value; }
        }

        /// <summary>
        ///     the value of the "CO_POSTCODE" field.
        /// </summary>
        public String Postcode
        {
            get { return _postcode; }
            set { _postcode = value; }
        }

        /// <summary>
        ///     the value of the "CO_INDUSTRY" field.
        /// </summary>
        public String Industry
        {
            get { return _industry; }
            set { _industry = value; }
        }

        /// <summary>
        ///     the value of the "CO_TERR_ID" field.
        /// </summary>
        public String TerrId
        {
            get { return _terrId; }
            set { _terrId = value; }
        }

        /// <summary>
        ///     the value of the "CO_LOCK" field.
        /// </summary>
        public String Lock
        {
            get { return _lock; }
            set { _lock = value; }
        }

        /// <summary>
        ///     the value of the "CO_COUNTY" field.
        /// </summary>
        public String County
        {
            get { return _county; }
            set { _county = value; }
        }

        /// <summary>
        ///     the value of the "CO_VAT_TYPE" field.
        /// </summary>
        public Byte? VatType
        {
            get { return _vatType; }
            set { _vatType = value; }
        }

        /// <summary>
        ///     the value of the "CO_LANGUAGE" field.
        /// </summary>
        public String Language
        {
            get { return _language; }
            set { _language = value; }
        }

        /// <summary>
        ///     the value of the "CO_CURRENCY" field.
        /// </summary>
        public String Currency
        {
            get { return _currency; }
            set { _currency = value; }
        }

        /// <summary>
        ///     the value of the "CO_USERCHAR_1" field.
        /// </summary>
        public String Userchar1
        {
            get { return _userchar1; }
            set { _userchar1 = value; }
        }

        /// <summary>
        ///     the value of the "CO_USERCHAR_2" field.
        /// </summary>
        public String Userchar2
        {
            get { return _userchar2; }
            set { _userchar2 = value; }
        }

        /// <summary>
        ///     the value of the "CO_USERNUM_1" field.
        /// </summary>
        public Double? Usernum1
        {
            get { return _usernum1; }
            set { _usernum1 = value; }
        }

        /// <summary>
        ///     the value of the "CO_USERNUM_2" field.
        /// </summary>
        public Double? Usernum2
        {
            get { return _usernum2; }
            set { _usernum2 = value; }
        }

        /// <summary>
        ///     the value of the "CO_NOTES" field.
        /// </summary>
        public String Notes
        {
            get { return _notes; }
            set { _notes = value; }
        }

        /// <summary>
        ///     the value of the "CO_EURO" field.
        /// </summary>
        public Byte? Euro
        {
            get { return _euro; }
            set { _euro = value; }
        }

        /// <summary>
        ///     the value of the "CO_COUNTRY_CODE" field.
        /// </summary>
        public String CountryCode
        {
            get { return _countryCode; }
            set { _countryCode = value; }
        }

        /// <summary>
        ///     the value of the "CO_TOWN" field.
        /// </summary>
        public String Town
        {
            get { return _town; }
            set { _town = value; }
        }

        /// <summary>
        ///     the value of the "CO_PCODE_LU" field.
        /// </summary>
        public Byte? PcodeLu
        {
            get { return _pcodeLu; }
            set { _pcodeLu = value; }
        }

        /// <summary>
        ///     the value of the "CO_LINE_POS" field.
        /// </summary>
        public String LinePos
        {
            get { return _linePos; }
            set { _linePos = value; }
        }

        /// <summary>
        ///     the value of the "CO_VAT_CODE" field.
        /// </summary>
        public String VatCode
        {
            get { return _vatCode; }
            set { _vatCode = value; }
        }

        /// <summary>
        ///     the value of the "CO_VAT_COUNTRY_CODE" field.
        /// </summary>
        public String VatCountryCode
        {
            get { return _vatCountryCode; }
            set { _vatCountryCode = value; }
        }

        /// <summary>
        ///     the value of the "CO_MAILSTRING_ORDER" field.
        /// </summary>
        public String MailstringOrder
        {
            get { return _mailstringOrder; }
            set { _mailstringOrder = value; }
        }

        /// <summary>
        ///     the value of the "CO_MAILSTRING_DISPLAY" field.
        /// </summary>
        public String MailstringDisplay
        {
            get { return _mailstringDisplay; }
            set { _mailstringDisplay = value; }
        }

        /// <summary>
        ///     the value of the "CO_MAILSTRING_NEWLINE" field.
        /// </summary>
        public String MailstringNewline
        {
            get { return _mailstringNewline; }
            set { _mailstringNewline = value; }
        }

        /// <summary>
        ///     the value of the "CO_COUNTRY_CODE_2" field.
        /// </summary>
        public String CountryCode2
        {
            get { return _countryCode2; }
            set { _countryCode2 = value; }
        }

        #endregion

        #region methods

        /// <summary>
        ///     Creates a new <see cref="CountryRecord" /> object instance that is a shallow-copy of the current object instance.
        /// </summary>
        /// <returns>
        ///     The shallow-copy of the current <see cref="CountryRecord" /> object instance.
        /// </returns>
        public CountryRecord Clone()
        {
            CountryRecord record = new CountryRecord();
            record.Id = this.Id;
            record.AddBy = this.AddBy;
            record.AddDate = this.AddDate;
            record.ModBy = this.ModBy;
            record.ModDate = this.ModDate;
            record.RcvFrom = this.RcvFrom;
            record.RcvDate = this.RcvDate;
            record.Name = this.Name;
            record.Format = this.Format;
            record.Rep = this.Rep;
            record.Area = this.Area;
            record.RepId = this.RepId;
            record.Rep1Id = this.Rep1Id;
            record.Rep2Id = this.Rep2Id;
            record.PostcodeFlag = this.PostcodeFlag;
            record.OrgType = this.OrgType;
            record.ProductGroup = this.ProductGroup;
            record.Postcode = this.Postcode;
            record.Industry = this.Industry;
            record.TerrId = this.TerrId;
            record.Lock = this.Lock;
            record.County = this.County;
            record.VatType = this.VatType;
            record.Language = this.Language;
            record.Currency = this.Currency;
            record.Userchar1 = this.Userchar1;
            record.Userchar2 = this.Userchar2;
            record.Usernum1 = this.Usernum1;
            record.Usernum2 = this.Usernum2;
            record.Notes = this.Notes;
            record.Euro = this.Euro;
            record.CountryCode = this.CountryCode;
            record.Town = this.Town;
            record.PcodeLu = this.PcodeLu;
            record.LinePos = this.LinePos;
            record.VatCode = this.VatCode;
            record.VatCountryCode = this.VatCountryCode;
            record.MailstringOrder = this.MailstringOrder;
            record.MailstringDisplay = this.MailstringDisplay;
            record.MailstringNewline = this.MailstringNewline;
            record.CountryCode2 = this.CountryCode2;
            return record;
        }

        /// <summary>
        ///     Indicates whether the current <see cref="CountryRecord" /> instance is equal to another <see cref="CountryRecord" /> instance.
        /// </summary>
        /// <param name="that">
        ///     The <see cref="CountryRecord" /> instance to be compared against this instance.
        /// </param>
        /// <returns>
        ///     True if both instances are considered equal; otherwise, false.
        /// </returns>
        public Boolean Equals(CountryRecord that)
        {
            Boolean result = true;
            result = result && (this.Id.TrimOrNullify() == that.Id.TrimOrNullify());
            result = result && (this.Name.TrimOrNullify() == that.Name.TrimOrNullify());
            result = result && (this.Format.TrimOrNullify() == that.Format.TrimOrNullify());
            result = result && (this.Rep.TrimOrNullify() == that.Rep.TrimOrNullify());
            result = result && (this.Area.TrimOrNullify() == that.Area.TrimOrNullify());
            result = result && (this.RepId.TrimOrNullify() == that.RepId.TrimOrNullify());
            result = result && (this.Rep1Id.TrimOrNullify() == that.Rep1Id.TrimOrNullify());
            result = result && (this.Rep2Id.TrimOrNullify() == that.Rep2Id.TrimOrNullify());
            result = result && (this.PostcodeFlag.TrimOrNullify() == that.PostcodeFlag.TrimOrNullify());
            result = result && (this.OrgType.TrimOrNullify() == that.OrgType.TrimOrNullify());
            result = result && (this.ProductGroup.TrimOrNullify() == that.ProductGroup.TrimOrNullify());
            result = result && (this.Postcode.TrimOrNullify() == that.Postcode.TrimOrNullify());
            result = result && (this.Industry.TrimOrNullify() == that.Industry.TrimOrNullify());
            result = result && (this.TerrId.TrimOrNullify() == that.TerrId.TrimOrNullify());
            result = result && (this.Lock.TrimOrNullify() == that.Lock.TrimOrNullify());
            result = result && (this.County.TrimOrNullify() == that.County.TrimOrNullify());
            result = result && (this.VatType == that.VatType);
            result = result && (this.Language.TrimOrNullify() == that.Language.TrimOrNullify());
            result = result && (this.Currency.TrimOrNullify() == that.Currency.TrimOrNullify());
            result = result && (this.Userchar1.TrimOrNullify() == that.Userchar1.TrimOrNullify());
            result = result && (this.Userchar2.TrimOrNullify() == that.Userchar2.TrimOrNullify());
            result = result && (this.Usernum1 == that.Usernum1);
            result = result && (this.Usernum2 == that.Usernum2);
            result = result && (this.Notes.TrimOrNullify() == that.Notes.TrimOrNullify());
            result = result && (this.Euro == that.Euro);
            result = result && (this.CountryCode.TrimOrNullify() == that.CountryCode.TrimOrNullify());
            result = result && (this.Town.TrimOrNullify() == that.Town.TrimOrNullify());
            result = result && (this.PcodeLu == that.PcodeLu);
            result = result && (this.LinePos.TrimOrNullify() == that.LinePos.TrimOrNullify());
            result = result && (this.VatCode.TrimOrNullify() == that.VatCode.TrimOrNullify());
            result = result && (this.VatCountryCode.TrimOrNullify() == that.VatCountryCode.TrimOrNullify());
            result = result && (this.MailstringOrder.TrimOrNullify() == that.MailstringOrder.TrimOrNullify());
            result = result && (this.MailstringDisplay.TrimOrNullify() == that.MailstringDisplay.TrimOrNullify());
            result = result && (this.MailstringNewline.TrimOrNullify() == that.MailstringNewline.TrimOrNullify());
            result = result && (this.CountryCode2.TrimOrNullify() == that.CountryCode2.TrimOrNullify());
            return result;
        }

        #endregion
    }
}
