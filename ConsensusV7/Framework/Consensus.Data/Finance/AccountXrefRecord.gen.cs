using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Linq;

namespace Consensus.Finance
{
    /// <summary>
    ///     Represents the "Account_Xref" data structure.
    /// </summary>
    /// <remarks>
    ///     THIS CODE HAS BEEN AUTOMATICALLY GENERATED USING THE CONSENSUS DEVELOPER TOOLS.
    ///     DO NOT EDIT THIS CODE AS ANY CUSTOM MODIFICATIONS WILL BE LOST UPON REGENERATION.
    /// </remarks>
    public class AccountXrefRecord : Record<String>, Cloneable<AccountXrefRecord>, IEquatable<AccountXrefRecord>
    {
        #region fields

        /// <summary>
        ///     the value of the "ACXREF_LOCK" field.
        /// </summary>
        private String _lock;

        /// <summary>
        ///     the value of the "ACXREF_ADD_DATE" field.
        /// </summary>
        private DateTime? _addDate;

        /// <summary>
        ///     the value of the "ACXREF_ADD_BY" field.
        /// </summary>
        private String _addBy;

        /// <summary>
        ///     the value of the "ACXREF_MOD_DATE" field.
        /// </summary>
        private DateTime? _modDate;

        /// <summary>
        ///     the value of the "ACXREF_MOD_BY" field.
        /// </summary>
        private String _modBy;

        /// <summary>
        ///     the value of the "ACXREF_RCV_DATE" field.
        /// </summary>
        private DateTime? _rcvDate;

        /// <summary>
        ///     the value of the "ACXREF_RCV_FROM" field.
        /// </summary>
        private String _rcvFrom;

        /// <summary>
        ///     the value of the "ACXREF_ACC_ID" field.
        /// </summary>
        private String _accId;

        /// <summary>
        ///     the value of the "ACXREF_ORG_ID" field.
        /// </summary>
        private String _orgId;

        /// <summary>
        ///     the value of the "ACXREF_ADD_ID" field.
        /// </summary>
        private String _addId;

        /// <summary>
        ///     the value of the "ACXREF_MAIN" field.
        /// </summary>
        private Byte? _main;

        /// <summary>
        ///     the value of the "ACXREF_INVOICE" field.
        /// </summary>
        private Byte? _invoice;

        /// <summary>
        ///     the value of the "ACXREF_STATEMENT" field.
        /// </summary>
        private Byte? _statement;

        /// <summary>
        ///     the value of the "ACXREF_NO_ADD_CHANGE" field.
        /// </summary>
        private Byte? _noAddChange;

        /// <summary>
        ///     the value of the "ACXREF_PROLE_ID" field.
        /// </summary>
        private String _proleId;

        /// <summary>
        ///     the value of the "ACXREF_FOR_ATTN_OF" field.
        /// </summary>
        private String _forAttnOf;

        /// <summary>
        ///     the value of the "ACXREF_CODE" field.
        /// </summary>
        private String _code;

        /// <summary>
        ///     the value of the "ACXREF_NOMINATED" field.
        /// </summary>
        private Byte? _nominated;

        /// <summary>
        ///     the value of the "ACXREF_INCL_HIERARCHY" field.
        /// </summary>
        private Byte _inclHierarchy;

        /// <summary>
        ///     the value of the "ACXREF_FROM_HIERARCHY" field.
        /// </summary>
        private Byte _fromHierarchy;

        #endregion

        #region properties

        /// <summary>
        ///     the value of the "ACXREF_LOCK" field.
        /// </summary>
        public String Lock
        {
            get { return _lock; }
            set { _lock = value; }
        }

        /// <summary>
        ///     the value of the "ACXREF_ADD_DATE" field.
        /// </summary>
        public DateTime? AddDate
        {
            get { return _addDate; }
            set { _addDate = value; }
        }

        /// <summary>
        ///     the value of the "ACXREF_ADD_BY" field.
        /// </summary>
        public String AddBy
        {
            get { return _addBy; }
            set { _addBy = value; }
        }

        /// <summary>
        ///     the value of the "ACXREF_MOD_DATE" field.
        /// </summary>
        public DateTime? ModDate
        {
            get { return _modDate; }
            set { _modDate = value; }
        }

        /// <summary>
        ///     the value of the "ACXREF_MOD_BY" field.
        /// </summary>
        public String ModBy
        {
            get { return _modBy; }
            set { _modBy = value; }
        }

        /// <summary>
        ///     the value of the "ACXREF_RCV_DATE" field.
        /// </summary>
        public DateTime? RcvDate
        {
            get { return _rcvDate; }
            set { _rcvDate = value; }
        }

        /// <summary>
        ///     the value of the "ACXREF_RCV_FROM" field.
        /// </summary>
        public String RcvFrom
        {
            get { return _rcvFrom; }
            set { _rcvFrom = value; }
        }

        /// <summary>
        ///     the value of the "ACXREF_ACC_ID" field.
        /// </summary>
        public String AccId
        {
            get { return _accId; }
            set { _accId = value; }
        }

        /// <summary>
        ///     the value of the "ACXREF_ORG_ID" field.
        /// </summary>
        public String OrgId
        {
            get { return _orgId; }
            set { _orgId = value; }
        }

        /// <summary>
        ///     the value of the "ACXREF_ADD_ID" field.
        /// </summary>
        public String AddId
        {
            get { return _addId; }
            set { _addId = value; }
        }

        /// <summary>
        ///     the value of the "ACXREF_MAIN" field.
        /// </summary>
        public Byte? Main
        {
            get { return _main; }
            set { _main = value; }
        }

        /// <summary>
        ///     the value of the "ACXREF_INVOICE" field.
        /// </summary>
        public Byte? Invoice
        {
            get { return _invoice; }
            set { _invoice = value; }
        }

        /// <summary>
        ///     the value of the "ACXREF_STATEMENT" field.
        /// </summary>
        public Byte? Statement
        {
            get { return _statement; }
            set { _statement = value; }
        }

        /// <summary>
        ///     the value of the "ACXREF_NO_ADD_CHANGE" field.
        /// </summary>
        public Byte? NoAddChange
        {
            get { return _noAddChange; }
            set { _noAddChange = value; }
        }

        /// <summary>
        ///     the value of the "ACXREF_PROLE_ID" field.
        /// </summary>
        public String ProleId
        {
            get { return _proleId; }
            set { _proleId = value; }
        }

        /// <summary>
        ///     the value of the "ACXREF_FOR_ATTN_OF" field.
        /// </summary>
        public String ForAttnOf
        {
            get { return _forAttnOf; }
            set { _forAttnOf = value; }
        }

        /// <summary>
        ///     the value of the "ACXREF_CODE" field.
        /// </summary>
        public String Code
        {
            get { return _code; }
            set { _code = value; }
        }

        /// <summary>
        ///     the value of the "ACXREF_NOMINATED" field.
        /// </summary>
        public Byte? Nominated
        {
            get { return _nominated; }
            set { _nominated = value; }
        }

        /// <summary>
        ///     the value of the "ACXREF_INCL_HIERARCHY" field.
        /// </summary>
        public Byte InclHierarchy
        {
            get { return _inclHierarchy; }
            set { _inclHierarchy = value; }
        }

        /// <summary>
        ///     the value of the "ACXREF_FROM_HIERARCHY" field.
        /// </summary>
        public Byte FromHierarchy
        {
            get { return _fromHierarchy; }
            set { _fromHierarchy = value; }
        }

        #endregion

        #region methods

        /// <summary>
        ///     Creates a new <see cref="AccountXrefRecord" /> object instance that is a shallow-copy of the current object instance.
        /// </summary>
        /// <returns>
        ///     The shallow-copy of the current <see cref="AccountXrefRecord" /> object instance.
        /// </returns>
        public AccountXrefRecord Clone()
        {
            AccountXrefRecord record = new AccountXrefRecord();
            record.Id = this.Id;
            record.Lock = this.Lock;
            record.AddDate = this.AddDate;
            record.AddBy = this.AddBy;
            record.ModDate = this.ModDate;
            record.ModBy = this.ModBy;
            record.RcvDate = this.RcvDate;
            record.RcvFrom = this.RcvFrom;
            record.AccId = this.AccId;
            record.OrgId = this.OrgId;
            record.AddId = this.AddId;
            record.Main = this.Main;
            record.Invoice = this.Invoice;
            record.Statement = this.Statement;
            record.NoAddChange = this.NoAddChange;
            record.ProleId = this.ProleId;
            record.ForAttnOf = this.ForAttnOf;
            record.Code = this.Code;
            record.Nominated = this.Nominated;
            record.InclHierarchy = this.InclHierarchy;
            record.FromHierarchy = this.FromHierarchy;
            return record;
        }

        /// <summary>
        ///     Indicates whether the current <see cref="AccountXrefRecord" /> instance is equal to another <see cref="AccountXrefRecord" /> instance.
        /// </summary>
        /// <param name="that">
        ///     The <see cref="AccountXrefRecord" /> instance to be compared against this instance.
        /// </param>
        /// <returns>
        ///     True if both instances are considered equal; otherwise, false.
        /// </returns>
        public Boolean Equals(AccountXrefRecord that)
        {
            Boolean result = true;
            result = result && (this.Id.TrimOrNullify() == that.Id.TrimOrNullify());
            result = result && (this.Lock.TrimOrNullify() == that.Lock.TrimOrNullify());
            result = result && (this.AccId.TrimOrNullify() == that.AccId.TrimOrNullify());
            result = result && (this.OrgId.TrimOrNullify() == that.OrgId.TrimOrNullify());
            result = result && (this.AddId.TrimOrNullify() == that.AddId.TrimOrNullify());
            result = result && (this.Main == that.Main);
            result = result && (this.Invoice == that.Invoice);
            result = result && (this.Statement == that.Statement);
            result = result && (this.NoAddChange == that.NoAddChange);
            result = result && (this.ProleId.TrimOrNullify() == that.ProleId.TrimOrNullify());
            result = result && (this.ForAttnOf.TrimOrNullify() == that.ForAttnOf.TrimOrNullify());
            result = result && (this.Code.TrimOrNullify() == that.Code.TrimOrNullify());
            result = result && (this.Nominated == that.Nominated);
            result = result && (this.InclHierarchy == that.InclHierarchy);
            result = result && (this.FromHierarchy == that.FromHierarchy);
            return result;
        }

        #endregion
    }
}
