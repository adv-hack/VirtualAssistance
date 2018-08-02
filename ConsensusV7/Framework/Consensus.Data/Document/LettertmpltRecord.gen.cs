using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Linq;

namespace Consensus.Document
{
    /// <summary>
    ///     Represents the "LetterTmplt" data structure.
    /// </summary>
    /// <remarks>
    ///     THIS CODE HAS BEEN AUTOMATICALLY GENERATED USING THE CONSENSUS DEVELOPER TOOLS.
    ///     DO NOT EDIT THIS CODE AS ANY CUSTOM MODIFICATIONS WILL BE LOST UPON REGENERATION.
    /// </remarks>
    public class LettertmpltRecord : Record<String>, Cloneable<LettertmpltRecord>, IEquatable<LettertmpltRecord>
    {
        #region fields

        /// <summary>
        ///     the value of the "LT_LOCK" field.
        /// </summary>
        private String _lock;

        /// <summary>
        ///     the value of the "LT_ADD_DATE" field.
        /// </summary>
        private DateTime? _addDate;

        /// <summary>
        ///     the value of the "LT_ADD_BY" field.
        /// </summary>
        private String _addBy;

        /// <summary>
        ///     the value of the "LT_MOD_DATE" field.
        /// </summary>
        private DateTime? _modDate;

        /// <summary>
        ///     the value of the "LT_MOD_BY" field.
        /// </summary>
        private String _modBy;

        /// <summary>
        ///     the value of the "LT_RCV_DATE" field.
        /// </summary>
        private DateTime? _rcvDate;

        /// <summary>
        ///     the value of the "LT_RCV_FROM" field.
        /// </summary>
        private String _rcvFrom;

        /// <summary>
        ///     the value of the "LT_NAME" field.
        /// </summary>
        private String _name;

        /// <summary>
        ///     the value of the "LT_TYPE" field.
        /// </summary>
        private String _type;

        /// <summary>
        ///     the value of the "LT_PRIVATE" field.
        /// </summary>
        private Byte? _private;

        /// <summary>
        ///     the value of the "LT_SECTION" field.
        /// </summary>
        private Byte? _section;

        /// <summary>
        ///     the value of the "LT_PROLE_ID" field.
        /// </summary>
        private String _proleId;

        /// <summary>
        ///     the value of the "LT_LANGUAGE" field.
        /// </summary>
        private String _language;

        /// <summary>
        ///     the value of the "LT_DESC" field.
        /// </summary>
        private String _desc;

        /// <summary>
        ///     the value of the "LT_TEXT" field.
        /// </summary>
        private String _text;

        /// <summary>
        ///     the value of the "LT_LEVEL" field.
        /// </summary>
        private Int32? _level;

        /// <summary>
        ///     the value of the "LT_INDEX" field.
        /// </summary>
        private String _index;

        /// <summary>
        ///     the value of the "LT_PAGE" field.
        /// </summary>
        private String _page;

        /// <summary>
        ///     the value of the "LT_FOR_USE_WITH" field.
        /// </summary>
        private Byte? _forUseWith;

        /// <summary>
        ///     the value of the "LT_FILE_NAME" field.
        /// </summary>
        private String _fileName;

        /// <summary>
        ///     the value of the "LT_SELCO_SP_ID" field.
        /// </summary>
        private String _selcoSpId;

        /// <summary>
        ///     the value of the "LT_PRINT_ONLY" field.
        /// </summary>
        private Byte? _printOnly;

        /// <summary>
        ///     the value of the "LT_EMAIL_SUBJECT" field.
        /// </summary>
        private String _emailSubject;

        /// <summary>
        ///     the value of the "LT_LOCALPRINT_ONLY" field.
        /// </summary>
        private Byte? _localprintOnly;

        /// <summary>
        ///     the value of the "LT_PDF" field.
        /// </summary>
        private Byte? _pdf;

        /// <summary>
        ///     the value of the "LT_SEND_PROLE_ID" field.
        /// </summary>
        private String _sendProleId;

        /// <summary>
        ///     the value of the "LT_CURRENT" field.
        /// </summary>
        private Byte _current;

        /// <summary>
        ///     the value of the "LT_EMAIL_BODY" field.
        /// </summary>
        private Byte _emailBody;

        /// <summary>
        ///     the value of the "LT_PQ_ID" field.
        /// </summary>
        private String _pqId;

        /// <summary>
        ///     the value of the "LT_ATT_ID" field.
        /// </summary>
        private String _attId;

        /// <summary>
        ///     the value of the "LT_LABEL" field.
        /// </summary>
        private Byte? _label;

        #endregion

        #region properties

        /// <summary>
        ///     the value of the "LT_LOCK" field.
        /// </summary>
        public String Lock
        {
            get { return _lock; }
            set { _lock = value; }
        }

        /// <summary>
        ///     the value of the "LT_ADD_DATE" field.
        /// </summary>
        public DateTime? AddDate
        {
            get { return _addDate; }
            set { _addDate = value; }
        }

        /// <summary>
        ///     the value of the "LT_ADD_BY" field.
        /// </summary>
        public String AddBy
        {
            get { return _addBy; }
            set { _addBy = value; }
        }

        /// <summary>
        ///     the value of the "LT_MOD_DATE" field.
        /// </summary>
        public DateTime? ModDate
        {
            get { return _modDate; }
            set { _modDate = value; }
        }

        /// <summary>
        ///     the value of the "LT_MOD_BY" field.
        /// </summary>
        public String ModBy
        {
            get { return _modBy; }
            set { _modBy = value; }
        }

        /// <summary>
        ///     the value of the "LT_RCV_DATE" field.
        /// </summary>
        public DateTime? RcvDate
        {
            get { return _rcvDate; }
            set { _rcvDate = value; }
        }

        /// <summary>
        ///     the value of the "LT_RCV_FROM" field.
        /// </summary>
        public String RcvFrom
        {
            get { return _rcvFrom; }
            set { _rcvFrom = value; }
        }

        /// <summary>
        ///     the value of the "LT_NAME" field.
        /// </summary>
        public String Name
        {
            get { return _name; }
            set { _name = value; }
        }

        /// <summary>
        ///     the value of the "LT_TYPE" field.
        /// </summary>
        public String Type
        {
            get { return _type; }
            set { _type = value; }
        }

        /// <summary>
        ///     the value of the "LT_PRIVATE" field.
        /// </summary>
        public Byte? Private
        {
            get { return _private; }
            set { _private = value; }
        }

        /// <summary>
        ///     the value of the "LT_SECTION" field.
        /// </summary>
        public Byte? Section
        {
            get { return _section; }
            set { _section = value; }
        }

        /// <summary>
        ///     the value of the "LT_PROLE_ID" field.
        /// </summary>
        public String ProleId
        {
            get { return _proleId; }
            set { _proleId = value; }
        }

        /// <summary>
        ///     the value of the "LT_LANGUAGE" field.
        /// </summary>
        public String Language
        {
            get { return _language; }
            set { _language = value; }
        }

        /// <summary>
        ///     the value of the "LT_DESC" field.
        /// </summary>
        public String Desc
        {
            get { return _desc; }
            set { _desc = value; }
        }

        /// <summary>
        ///     the value of the "LT_TEXT" field.
        /// </summary>
        public String Text
        {
            get { return _text; }
            set { _text = value; }
        }

        /// <summary>
        ///     the value of the "LT_LEVEL" field.
        /// </summary>
        public Int32? Level
        {
            get { return _level; }
            set { _level = value; }
        }

        /// <summary>
        ///     the value of the "LT_INDEX" field.
        /// </summary>
        public String Index
        {
            get { return _index; }
            set { _index = value; }
        }

        /// <summary>
        ///     the value of the "LT_PAGE" field.
        /// </summary>
        public String Page
        {
            get { return _page; }
            set { _page = value; }
        }

        /// <summary>
        ///     the value of the "LT_FOR_USE_WITH" field.
        /// </summary>
        public Byte? ForUseWith
        {
            get { return _forUseWith; }
            set { _forUseWith = value; }
        }

        /// <summary>
        ///     the value of the "LT_FILE_NAME" field.
        /// </summary>
        public String FileName
        {
            get { return _fileName; }
            set { _fileName = value; }
        }

        /// <summary>
        ///     the value of the "LT_SELCO_SP_ID" field.
        /// </summary>
        public String SelcoSpId
        {
            get { return _selcoSpId; }
            set { _selcoSpId = value; }
        }

        /// <summary>
        ///     the value of the "LT_PRINT_ONLY" field.
        /// </summary>
        public Byte? PrintOnly
        {
            get { return _printOnly; }
            set { _printOnly = value; }
        }

        /// <summary>
        ///     the value of the "LT_EMAIL_SUBJECT" field.
        /// </summary>
        public String EmailSubject
        {
            get { return _emailSubject; }
            set { _emailSubject = value; }
        }

        /// <summary>
        ///     the value of the "LT_LOCALPRINT_ONLY" field.
        /// </summary>
        public Byte? LocalprintOnly
        {
            get { return _localprintOnly; }
            set { _localprintOnly = value; }
        }

        /// <summary>
        ///     the value of the "LT_PDF" field.
        /// </summary>
        public Byte? Pdf
        {
            get { return _pdf; }
            set { _pdf = value; }
        }

        /// <summary>
        ///     the value of the "LT_SEND_PROLE_ID" field.
        /// </summary>
        public String SendProleId
        {
            get { return _sendProleId; }
            set { _sendProleId = value; }
        }

        /// <summary>
        ///     the value of the "LT_CURRENT" field.
        /// </summary>
        public Byte Current
        {
            get { return _current; }
            set { _current = value; }
        }

        /// <summary>
        ///     the value of the "LT_EMAIL_BODY" field.
        /// </summary>
        public Byte EmailBody
        {
            get { return _emailBody; }
            set { _emailBody = value; }
        }

        /// <summary>
        ///     the value of the "LT_PQ_ID" field.
        /// </summary>
        public String PqId
        {
            get { return _pqId; }
            set { _pqId = value; }
        }

        /// <summary>
        ///     the value of the "LT_ATT_ID" field.
        /// </summary>
        public String AttId
        {
            get { return _attId; }
            set { _attId = value; }
        }

        /// <summary>
        ///     the value of the "LT_LABEL" field.
        /// </summary>
        public Byte? Label
        {
            get { return _label; }
            set { _label = value; }
        }

        #endregion

        #region methods

        /// <summary>
        ///     Creates a new <see cref="LettertmpltRecord" /> object instance that is a shallow-copy of the current object instance.
        /// </summary>
        /// <returns>
        ///     The shallow-copy of the current <see cref="LettertmpltRecord" /> object instance.
        /// </returns>
        public LettertmpltRecord Clone()
        {
            LettertmpltRecord record = new LettertmpltRecord();
            record.Id = this.Id;
            record.Lock = this.Lock;
            record.AddDate = this.AddDate;
            record.AddBy = this.AddBy;
            record.ModDate = this.ModDate;
            record.ModBy = this.ModBy;
            record.RcvDate = this.RcvDate;
            record.RcvFrom = this.RcvFrom;
            record.Name = this.Name;
            record.Type = this.Type;
            record.Private = this.Private;
            record.Section = this.Section;
            record.ProleId = this.ProleId;
            record.Language = this.Language;
            record.Desc = this.Desc;
            record.Text = this.Text;
            record.Level = this.Level;
            record.Index = this.Index;
            record.Page = this.Page;
            record.ForUseWith = this.ForUseWith;
            record.FileName = this.FileName;
            record.SelcoSpId = this.SelcoSpId;
            record.PrintOnly = this.PrintOnly;
            record.EmailSubject = this.EmailSubject;
            record.LocalprintOnly = this.LocalprintOnly;
            record.Pdf = this.Pdf;
            record.SendProleId = this.SendProleId;
            record.Current = this.Current;
            record.EmailBody = this.EmailBody;
            record.PqId = this.PqId;
            record.AttId = this.AttId;
            record.Label = this.Label;
            return record;
        }

        /// <summary>
        ///     Indicates whether the current <see cref="LettertmpltRecord" /> instance is equal to another <see cref="LettertmpltRecord" /> instance.
        /// </summary>
        /// <param name="that">
        ///     The <see cref="LettertmpltRecord" /> instance to be compared against this instance.
        /// </param>
        /// <returns>
        ///     True if both instances are considered equal; otherwise, false.
        /// </returns>
        public Boolean Equals(LettertmpltRecord that)
        {
            Boolean result = true;
            result = result && (this.Id.TrimOrNullify() == that.Id.TrimOrNullify());
            result = result && (this.Lock.TrimOrNullify() == that.Lock.TrimOrNullify());
            result = result && (this.Name.TrimOrNullify() == that.Name.TrimOrNullify());
            result = result && (this.Type.TrimOrNullify() == that.Type.TrimOrNullify());
            result = result && (this.Private == that.Private);
            result = result && (this.Section == that.Section);
            result = result && (this.ProleId.TrimOrNullify() == that.ProleId.TrimOrNullify());
            result = result && (this.Language.TrimOrNullify() == that.Language.TrimOrNullify());
            result = result && (this.Desc.TrimOrNullify() == that.Desc.TrimOrNullify());
            result = result && (this.Text.TrimOrNullify() == that.Text.TrimOrNullify());
            result = result && (this.Level == that.Level);
            result = result && (this.Index.TrimOrNullify() == that.Index.TrimOrNullify());
            result = result && (this.Page.TrimOrNullify() == that.Page.TrimOrNullify());
            result = result && (this.ForUseWith == that.ForUseWith);
            result = result && (this.FileName.TrimOrNullify() == that.FileName.TrimOrNullify());
            result = result && (this.SelcoSpId.TrimOrNullify() == that.SelcoSpId.TrimOrNullify());
            result = result && (this.PrintOnly == that.PrintOnly);
            result = result && (this.EmailSubject.TrimOrNullify() == that.EmailSubject.TrimOrNullify());
            result = result && (this.LocalprintOnly == that.LocalprintOnly);
            result = result && (this.Pdf == that.Pdf);
            result = result && (this.SendProleId.TrimOrNullify() == that.SendProleId.TrimOrNullify());
            result = result && (this.Current == that.Current);
            result = result && (this.EmailBody == that.EmailBody);
            result = result && (this.PqId.TrimOrNullify() == that.PqId.TrimOrNullify());
            result = result && (this.AttId.TrimOrNullify() == that.AttId.TrimOrNullify());
            result = result && (this.Label == that.Label);
            return result;
        }

        #endregion
    }
}
