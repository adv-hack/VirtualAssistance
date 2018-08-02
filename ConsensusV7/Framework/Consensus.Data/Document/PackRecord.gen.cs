using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Linq;

namespace Consensus.Document
{
    /// <summary>
    ///     Represents the "Pack" data structure.
    /// </summary>
    /// <remarks>
    ///     THIS CODE HAS BEEN AUTOMATICALLY GENERATED USING THE CONSENSUS DEVELOPER TOOLS.
    ///     DO NOT EDIT THIS CODE AS ANY CUSTOM MODIFICATIONS WILL BE LOST UPON REGENERATION.
    /// </remarks>
    public class PackRecord : Record<String>, Cloneable<PackRecord>, IEquatable<PackRecord>
    {
        #region fields

        /// <summary>
        ///     the value of the "PACK_LOCK" field.
        /// </summary>
        private String _lock;

        /// <summary>
        ///     the value of the "PACK_ADD_DATE" field.
        /// </summary>
        private DateTime? _addDate;

        /// <summary>
        ///     the value of the "PACK_ADD_BY" field.
        /// </summary>
        private String _addBy;

        /// <summary>
        ///     the value of the "PACK_MOD_DATE" field.
        /// </summary>
        private DateTime? _modDate;

        /// <summary>
        ///     the value of the "PACK_MOD_BY" field.
        /// </summary>
        private String _modBy;

        /// <summary>
        ///     the value of the "PACK_RCV_DATE" field.
        /// </summary>
        private DateTime? _rcvDate;

        /// <summary>
        ///     the value of the "PACK_RCV_FROM" field.
        /// </summary>
        private String _rcvFrom;

        /// <summary>
        ///     the value of the "PACK_NAME" field.
        /// </summary>
        private String _name;

        /// <summary>
        ///     the value of the "PACK_TYPE" field.
        /// </summary>
        private Byte? _packType;

        /// <summary>
        ///     the value of the "PACK_TO_BOOKER" field.
        /// </summary>
        private Byte? _toBooker;

        /// <summary>
        ///     the value of the "PACK_TO_DEL" field.
        /// </summary>
        private Byte? _toDel;

        /// <summary>
        ///     the value of the "PACK_DOCS_METHOD" field.
        /// </summary>
        private String _docsMethod;

        /// <summary>
        ///     the value of the "PACK_EMAIL_SUBJECT" field.
        /// </summary>
        private String _emailSubject;

        /// <summary>
        ///     the value of the "PACK_INVOICE" field.
        /// </summary>
        private Byte? _invoice;

        /// <summary>
        ///     the value of the "PACK_ACT_PQ_KEEP" field.
        /// </summary>
        private Byte? _actPqKeep;

        /// <summary>
        ///     the value of the "PACK_EMAIL_BODY" field.
        /// </summary>
        private String _emailBody;

        /// <summary>
        ///     the value of the "PACK_EMAIL_ONLY" field.
        /// </summary>
        private Byte _emailOnly;

        /// <summary>
        ///     the value of the "PACK_PRINT_ONLY" field.
        /// </summary>
        private Byte _printOnly;

        /// <summary>
        ///     the value of the "PACK_STATUS" field.
        /// </summary>
        private Byte _status;

        /// <summary>
        ///     the value of the "PACK_SEND_PROLE_ID" field.
        /// </summary>
        private String _sendProleId;

        /// <summary>
        ///     the value of the "PACK_CATEGORY" field.
        /// </summary>
        private String _category;

        /// <summary>
        ///     the value of the "PACK_PQ_ID" field.
        /// </summary>
        private String _pqId;

        /// <summary>
        ///     the value of the "PACK_BCC_EMAIL" field.
        /// </summary>
        private String _bccEmail;

        /// <summary>
        ///     the value of the "PACK_MDN_EMAIL" field.
        /// </summary>
        private String _mdnEmail;

        /// <summary>
        ///     the value of the "PACK_DSN_EMAIL" field.
        /// </summary>
        private String _dsnEmail;

        /// <summary>
        ///     the value of the "PACK_DSN_OPTIONS" field.
        /// </summary>
        private String _dsnOptions;

        /// <summary>
        ///     the value of the "PACK_SELCO_SP_ID" field.
        /// </summary>
        private String _selcoSpId;

        #endregion

        #region properties

        /// <summary>
        ///     the value of the "PACK_LOCK" field.
        /// </summary>
        public String Lock
        {
            get { return _lock; }
            set { _lock = value; }
        }

        /// <summary>
        ///     the value of the "PACK_ADD_DATE" field.
        /// </summary>
        public DateTime? AddDate
        {
            get { return _addDate; }
            set { _addDate = value; }
        }

        /// <summary>
        ///     the value of the "PACK_ADD_BY" field.
        /// </summary>
        public String AddBy
        {
            get { return _addBy; }
            set { _addBy = value; }
        }

        /// <summary>
        ///     the value of the "PACK_MOD_DATE" field.
        /// </summary>
        public DateTime? ModDate
        {
            get { return _modDate; }
            set { _modDate = value; }
        }

        /// <summary>
        ///     the value of the "PACK_MOD_BY" field.
        /// </summary>
        public String ModBy
        {
            get { return _modBy; }
            set { _modBy = value; }
        }

        /// <summary>
        ///     the value of the "PACK_RCV_DATE" field.
        /// </summary>
        public DateTime? RcvDate
        {
            get { return _rcvDate; }
            set { _rcvDate = value; }
        }

        /// <summary>
        ///     the value of the "PACK_RCV_FROM" field.
        /// </summary>
        public String RcvFrom
        {
            get { return _rcvFrom; }
            set { _rcvFrom = value; }
        }

        /// <summary>
        ///     the value of the "PACK_NAME" field.
        /// </summary>
        public String Name
        {
            get { return _name; }
            set { _name = value; }
        }

        /// <summary>
        ///     the value of the "PACK_TYPE" field.
        /// </summary>
        public Byte? PackType
        {
            get { return _packType; }
            set { _packType = value; }
        }

        /// <summary>
        ///     the value of the "PACK_TO_BOOKER" field.
        /// </summary>
        public Byte? ToBooker
        {
            get { return _toBooker; }
            set { _toBooker = value; }
        }

        /// <summary>
        ///     the value of the "PACK_TO_DEL" field.
        /// </summary>
        public Byte? ToDel
        {
            get { return _toDel; }
            set { _toDel = value; }
        }

        /// <summary>
        ///     the value of the "PACK_DOCS_METHOD" field.
        /// </summary>
        public String DocsMethod
        {
            get { return _docsMethod; }
            set { _docsMethod = value; }
        }

        /// <summary>
        ///     the value of the "PACK_EMAIL_SUBJECT" field.
        /// </summary>
        public String EmailSubject
        {
            get { return _emailSubject; }
            set { _emailSubject = value; }
        }

        /// <summary>
        ///     the value of the "PACK_INVOICE" field.
        /// </summary>
        public Byte? Invoice
        {
            get { return _invoice; }
            set { _invoice = value; }
        }

        /// <summary>
        ///     the value of the "PACK_ACT_PQ_KEEP" field.
        /// </summary>
        public Byte? ActPqKeep
        {
            get { return _actPqKeep; }
            set { _actPqKeep = value; }
        }

        /// <summary>
        ///     the value of the "PACK_EMAIL_BODY" field.
        /// </summary>
        public String EmailBody
        {
            get { return _emailBody; }
            set { _emailBody = value; }
        }

        /// <summary>
        ///     the value of the "PACK_EMAIL_ONLY" field.
        /// </summary>
        public Byte EmailOnly
        {
            get { return _emailOnly; }
            set { _emailOnly = value; }
        }

        /// <summary>
        ///     the value of the "PACK_PRINT_ONLY" field.
        /// </summary>
        public Byte PrintOnly
        {
            get { return _printOnly; }
            set { _printOnly = value; }
        }

        /// <summary>
        ///     the value of the "PACK_STATUS" field.
        /// </summary>
        public Byte Status
        {
            get { return _status; }
            set { _status = value; }
        }

        /// <summary>
        ///     the value of the "PACK_SEND_PROLE_ID" field.
        /// </summary>
        public String SendProleId
        {
            get { return _sendProleId; }
            set { _sendProleId = value; }
        }

        /// <summary>
        ///     the value of the "PACK_CATEGORY" field.
        /// </summary>
        public String Category
        {
            get { return _category; }
            set { _category = value; }
        }

        /// <summary>
        ///     the value of the "PACK_PQ_ID" field.
        /// </summary>
        public String PqId
        {
            get { return _pqId; }
            set { _pqId = value; }
        }

        /// <summary>
        ///     the value of the "PACK_BCC_EMAIL" field.
        /// </summary>
        public String BccEmail
        {
            get { return _bccEmail; }
            set { _bccEmail = value; }
        }

        /// <summary>
        ///     the value of the "PACK_MDN_EMAIL" field.
        /// </summary>
        public String MdnEmail
        {
            get { return _mdnEmail; }
            set { _mdnEmail = value; }
        }

        /// <summary>
        ///     the value of the "PACK_DSN_EMAIL" field.
        /// </summary>
        public String DsnEmail
        {
            get { return _dsnEmail; }
            set { _dsnEmail = value; }
        }

        /// <summary>
        ///     the value of the "PACK_DSN_OPTIONS" field.
        /// </summary>
        public String DsnOptions
        {
            get { return _dsnOptions; }
            set { _dsnOptions = value; }
        }

        /// <summary>
        ///     the value of the "PACK_SELCO_SP_ID" field.
        /// </summary>
        public String SelcoSpId
        {
            get { return _selcoSpId; }
            set { _selcoSpId = value; }
        }

        #endregion

        #region methods

        /// <summary>
        ///     Creates a new <see cref="PackRecord" /> object instance that is a shallow-copy of the current object instance.
        /// </summary>
        /// <returns>
        ///     The shallow-copy of the current <see cref="PackRecord" /> object instance.
        /// </returns>
        public PackRecord Clone()
        {
            PackRecord record = new PackRecord();
            record.Id = this.Id;
            record.Lock = this.Lock;
            record.AddDate = this.AddDate;
            record.AddBy = this.AddBy;
            record.ModDate = this.ModDate;
            record.ModBy = this.ModBy;
            record.RcvDate = this.RcvDate;
            record.RcvFrom = this.RcvFrom;
            record.Name = this.Name;
            record.PackType = this.PackType;
            record.ToBooker = this.ToBooker;
            record.ToDel = this.ToDel;
            record.DocsMethod = this.DocsMethod;
            record.EmailSubject = this.EmailSubject;
            record.Invoice = this.Invoice;
            record.ActPqKeep = this.ActPqKeep;
            record.EmailBody = this.EmailBody;
            record.EmailOnly = this.EmailOnly;
            record.PrintOnly = this.PrintOnly;
            record.Status = this.Status;
            record.SendProleId = this.SendProleId;
            record.Category = this.Category;
            record.PqId = this.PqId;
            record.BccEmail = this.BccEmail;
            record.MdnEmail = this.MdnEmail;
            record.DsnEmail = this.DsnEmail;
            record.DsnOptions = this.DsnOptions;
            record.SelcoSpId = this.SelcoSpId;
            return record;
        }

        /// <summary>
        ///     Indicates whether the current <see cref="PackRecord" /> instance is equal to another <see cref="PackRecord" /> instance.
        /// </summary>
        /// <param name="that">
        ///     The <see cref="PackRecord" /> instance to be compared against this instance.
        /// </param>
        /// <returns>
        ///     True if both instances are considered equal; otherwise, false.
        /// </returns>
        public Boolean Equals(PackRecord that)
        {
            Boolean result = true;
            result = result && (this.Id.TrimOrNullify() == that.Id.TrimOrNullify());
            result = result && (this.Lock.TrimOrNullify() == that.Lock.TrimOrNullify());
            result = result && (this.Name.TrimOrNullify() == that.Name.TrimOrNullify());
            result = result && (this.PackType == that.PackType);
            result = result && (this.ToBooker == that.ToBooker);
            result = result && (this.ToDel == that.ToDel);
            result = result && (this.DocsMethod.TrimOrNullify() == that.DocsMethod.TrimOrNullify());
            result = result && (this.EmailSubject.TrimOrNullify() == that.EmailSubject.TrimOrNullify());
            result = result && (this.Invoice == that.Invoice);
            result = result && (this.ActPqKeep == that.ActPqKeep);
            result = result && (this.EmailBody.TrimOrNullify() == that.EmailBody.TrimOrNullify());
            result = result && (this.EmailOnly == that.EmailOnly);
            result = result && (this.PrintOnly == that.PrintOnly);
            result = result && (this.Status == that.Status);
            result = result && (this.SendProleId.TrimOrNullify() == that.SendProleId.TrimOrNullify());
            result = result && (this.Category.TrimOrNullify() == that.Category.TrimOrNullify());
            result = result && (this.PqId.TrimOrNullify() == that.PqId.TrimOrNullify());
            result = result && (this.BccEmail.TrimOrNullify() == that.BccEmail.TrimOrNullify());
            result = result && (this.MdnEmail.TrimOrNullify() == that.MdnEmail.TrimOrNullify());
            result = result && (this.DsnEmail.TrimOrNullify() == that.DsnEmail.TrimOrNullify());
            result = result && (this.DsnOptions.TrimOrNullify() == that.DsnOptions.TrimOrNullify());
            result = result && (this.SelcoSpId.TrimOrNullify() == that.SelcoSpId.TrimOrNullify());
            return result;
        }

        #endregion
    }
}
