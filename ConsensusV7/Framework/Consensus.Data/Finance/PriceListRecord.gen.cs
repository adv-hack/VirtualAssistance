using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Linq;

namespace Consensus.Finance
{
    /// <summary>
    ///     Represents the "Price_List" data structure.
    /// </summary>
    /// <remarks>
    ///     THIS CODE HAS BEEN AUTOMATICALLY GENERATED USING THE CONSENSUS DEVELOPER TOOLS.
    ///     DO NOT EDIT THIS CODE AS ANY CUSTOM MODIFICATIONS WILL BE LOST UPON REGENERATION.
    /// </remarks>
    public class PriceListRecord : Record<String>, Cloneable<PriceListRecord>, IEquatable<PriceListRecord>
    {
        #region fields

        /// <summary>
        ///     the value of the "PL_LOCK" field.
        /// </summary>
        private String _lock;

        /// <summary>
        ///     the value of the "PL_ADD_DATE" field.
        /// </summary>
        private DateTime? _addDate;

        /// <summary>
        ///     the value of the "PL_ADD_BY" field.
        /// </summary>
        private String _addBy;

        /// <summary>
        ///     the value of the "PL_MOD_DATE" field.
        /// </summary>
        private DateTime? _modDate;

        /// <summary>
        ///     the value of the "PL_MOD_BY" field.
        /// </summary>
        private String _modBy;

        /// <summary>
        ///     the value of the "PL_RCV_DATE" field.
        /// </summary>
        private DateTime? _rcvDate;

        /// <summary>
        ///     the value of the "PL_RCV_FROM" field.
        /// </summary>
        private String _rcvFrom;

        /// <summary>
        ///     the value of the "PL_CURRENCY" field.
        /// </summary>
        private String _currency;

        /// <summary>
        ///     the value of the "PL_NAME" field.
        /// </summary>
        private String _name;

        /// <summary>
        ///     the value of the "PL_VALID_FROM" field.
        /// </summary>
        private DateTime? _validFrom;

        /// <summary>
        ///     the value of the "PL_VALID_UNTIL" field.
        /// </summary>
        private DateTime? _validUntil;

        /// <summary>
        ///     the value of the "PL_BUSINESS_UNIT" field.
        /// </summary>
        private String _businessUnit;

        /// <summary>
        ///     the value of the "PL_TICKET" field.
        /// </summary>
        private Byte? _ticket;

        /// <summary>
        ///     the value of the "PL_PROD_FAMILY" field.
        /// </summary>
        private String _prodFamily;

        /// <summary>
        ///     the value of the "PL_BKT_ID" field.
        /// </summary>
        private String _bktId;

        /// <summary>
        ///     the value of the "PL_ORG_ONLY" field.
        /// </summary>
        private Byte? _orgOnly;

        /// <summary>
        ///     the value of the "PL_STATUS" field.
        /// </summary>
        private Byte? _status;

        /// <summary>
        ///     the value of the "PL_PREPAY_ACCOUNT_ONLY" field.
        /// </summary>
        private Byte? _prepayAccountOnly;

        /// <summary>
        ///     the value of the "PL_PSH_ID" field.
        /// </summary>
        private Int32? _pshId;

        /// <summary>
        ///     the value of the "PL_DEFAULT" field.
        /// </summary>
        private Byte _default;

        /// <summary>
        ///     the value of the "PL_VAT_CODE" field.
        /// </summary>
        private String _vatCode;

        #endregion

        #region properties

        /// <summary>
        ///     the value of the "PL_LOCK" field.
        /// </summary>
        public String Lock
        {
            get { return _lock; }
            set { _lock = value; }
        }

        /// <summary>
        ///     the value of the "PL_ADD_DATE" field.
        /// </summary>
        public DateTime? AddDate
        {
            get { return _addDate; }
            set { _addDate = value; }
        }

        /// <summary>
        ///     the value of the "PL_ADD_BY" field.
        /// </summary>
        public String AddBy
        {
            get { return _addBy; }
            set { _addBy = value; }
        }

        /// <summary>
        ///     the value of the "PL_MOD_DATE" field.
        /// </summary>
        public DateTime? ModDate
        {
            get { return _modDate; }
            set { _modDate = value; }
        }

        /// <summary>
        ///     the value of the "PL_MOD_BY" field.
        /// </summary>
        public String ModBy
        {
            get { return _modBy; }
            set { _modBy = value; }
        }

        /// <summary>
        ///     the value of the "PL_RCV_DATE" field.
        /// </summary>
        public DateTime? RcvDate
        {
            get { return _rcvDate; }
            set { _rcvDate = value; }
        }

        /// <summary>
        ///     the value of the "PL_RCV_FROM" field.
        /// </summary>
        public String RcvFrom
        {
            get { return _rcvFrom; }
            set { _rcvFrom = value; }
        }

        /// <summary>
        ///     the value of the "PL_CURRENCY" field.
        /// </summary>
        public String Currency
        {
            get { return _currency; }
            set { _currency = value; }
        }

        /// <summary>
        ///     the value of the "PL_NAME" field.
        /// </summary>
        public String Name
        {
            get { return _name; }
            set { _name = value; }
        }

        /// <summary>
        ///     the value of the "PL_VALID_FROM" field.
        /// </summary>
        public DateTime? ValidFrom
        {
            get { return _validFrom; }
            set { _validFrom = value; }
        }

        /// <summary>
        ///     the value of the "PL_VALID_UNTIL" field.
        /// </summary>
        public DateTime? ValidUntil
        {
            get { return _validUntil; }
            set { _validUntil = value; }
        }

        /// <summary>
        ///     the value of the "PL_BUSINESS_UNIT" field.
        /// </summary>
        public String BusinessUnit
        {
            get { return _businessUnit; }
            set { _businessUnit = value; }
        }

        /// <summary>
        ///     the value of the "PL_TICKET" field.
        /// </summary>
        public Byte? Ticket
        {
            get { return _ticket; }
            set { _ticket = value; }
        }

        /// <summary>
        ///     the value of the "PL_PROD_FAMILY" field.
        /// </summary>
        public String ProdFamily
        {
            get { return _prodFamily; }
            set { _prodFamily = value; }
        }

        /// <summary>
        ///     the value of the "PL_BKT_ID" field.
        /// </summary>
        public String BktId
        {
            get { return _bktId; }
            set { _bktId = value; }
        }

        /// <summary>
        ///     the value of the "PL_ORG_ONLY" field.
        /// </summary>
        public Byte? OrgOnly
        {
            get { return _orgOnly; }
            set { _orgOnly = value; }
        }

        /// <summary>
        ///     the value of the "PL_STATUS" field.
        /// </summary>
        public Byte? Status
        {
            get { return _status; }
            set { _status = value; }
        }

        /// <summary>
        ///     the value of the "PL_PREPAY_ACCOUNT_ONLY" field.
        /// </summary>
        public Byte? PrepayAccountOnly
        {
            get { return _prepayAccountOnly; }
            set { _prepayAccountOnly = value; }
        }

        /// <summary>
        ///     the value of the "PL_PSH_ID" field.
        /// </summary>
        public Int32? PshId
        {
            get { return _pshId; }
            set { _pshId = value; }
        }

        /// <summary>
        ///     the value of the "PL_DEFAULT" field.
        /// </summary>
        public Byte Default
        {
            get { return _default; }
            set { _default = value; }
        }

        /// <summary>
        ///     the value of the "PL_VAT_CODE" field.
        /// </summary>
        public String VatCode
        {
            get { return _vatCode; }
            set { _vatCode = value; }
        }

        #endregion

        #region methods

        /// <summary>
        ///     Creates a new <see cref="PriceListRecord" /> object instance that is a shallow-copy of the current object instance.
        /// </summary>
        /// <returns>
        ///     The shallow-copy of the current <see cref="PriceListRecord" /> object instance.
        /// </returns>
        public PriceListRecord Clone()
        {
            PriceListRecord record = new PriceListRecord();
            record.Id = this.Id;
            record.Lock = this.Lock;
            record.AddDate = this.AddDate;
            record.AddBy = this.AddBy;
            record.ModDate = this.ModDate;
            record.ModBy = this.ModBy;
            record.RcvDate = this.RcvDate;
            record.RcvFrom = this.RcvFrom;
            record.Currency = this.Currency;
            record.Name = this.Name;
            record.ValidFrom = this.ValidFrom;
            record.ValidUntil = this.ValidUntil;
            record.BusinessUnit = this.BusinessUnit;
            record.Ticket = this.Ticket;
            record.ProdFamily = this.ProdFamily;
            record.BktId = this.BktId;
            record.OrgOnly = this.OrgOnly;
            record.Status = this.Status;
            record.PrepayAccountOnly = this.PrepayAccountOnly;
            record.PshId = this.PshId;
            record.Default = this.Default;
            record.VatCode = this.VatCode;
            return record;
        }

        /// <summary>
        ///     Indicates whether the current <see cref="PriceListRecord" /> instance is equal to another <see cref="PriceListRecord" /> instance.
        /// </summary>
        /// <param name="that">
        ///     The <see cref="PriceListRecord" /> instance to be compared against this instance.
        /// </param>
        /// <returns>
        ///     True if both instances are considered equal; otherwise, false.
        /// </returns>
        public Boolean Equals(PriceListRecord that)
        {
            Boolean result = true;
            result = result && (this.Id.TrimOrNullify() == that.Id.TrimOrNullify());
            result = result && (this.Lock.TrimOrNullify() == that.Lock.TrimOrNullify());
            result = result && (this.Currency.TrimOrNullify() == that.Currency.TrimOrNullify());
            result = result && (this.Name.TrimOrNullify() == that.Name.TrimOrNullify());
            result = result && (this.ValidFrom == that.ValidFrom);
            result = result && (this.ValidUntil == that.ValidUntil);
            result = result && (this.BusinessUnit.TrimOrNullify() == that.BusinessUnit.TrimOrNullify());
            result = result && (this.Ticket == that.Ticket);
            result = result && (this.ProdFamily.TrimOrNullify() == that.ProdFamily.TrimOrNullify());
            result = result && (this.BktId.TrimOrNullify() == that.BktId.TrimOrNullify());
            result = result && (this.OrgOnly == that.OrgOnly);
            result = result && (this.Status == that.Status);
            result = result && (this.PrepayAccountOnly == that.PrepayAccountOnly);
            result = result && (this.PshId == that.PshId);
            result = result && (this.Default == that.Default);
            result = result && (this.VatCode.TrimOrNullify() == that.VatCode.TrimOrNullify());
            return result;
        }

        #endregion
    }
}
