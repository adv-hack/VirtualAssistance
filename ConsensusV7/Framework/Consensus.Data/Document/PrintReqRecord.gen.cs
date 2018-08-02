using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Linq;

namespace Consensus.Document
{
    /// <summary>
    ///     Represents the "Print_Req" data structure.
    /// </summary>
    /// <remarks>
    ///     THIS CODE HAS BEEN AUTOMATICALLY GENERATED USING THE CONSENSUS DEVELOPER TOOLS.
    ///     DO NOT EDIT THIS CODE AS ANY CUSTOM MODIFICATIONS WILL BE LOST UPON REGENERATION.
    /// </remarks>
    public class PrintReqRecord : Record<String>, Cloneable<PrintReqRecord>, IEquatable<PrintReqRecord>
    {
        #region fields

        /// <summary>
        ///     the value of the "PR_ADD_DATE" field.
        /// </summary>
        private DateTime? _addDate;

        /// <summary>
        ///     the value of the "PR_ADD_BY" field.
        /// </summary>
        private String _addBy;

        /// <summary>
        ///     the value of the "PR_MOD_DATE" field.
        /// </summary>
        private DateTime? _modDate;

        /// <summary>
        ///     the value of the "PR_MOD_BY" field.
        /// </summary>
        private String _modBy;

        /// <summary>
        ///     the value of the "PR_RCV_DATE" field.
        /// </summary>
        private DateTime? _rcvDate;

        /// <summary>
        ///     the value of the "PR_RCV_FROM" field.
        /// </summary>
        private String _rcvFrom;

        /// <summary>
        ///     the value of the "PR_ID_1" field.
        /// </summary>
        private String _id1;

        /// <summary>
        ///     the value of the "PR_ID_2" field.
        /// </summary>
        private String _id2;

        /// <summary>
        ///     the value of the "PR_ID_3" field.
        /// </summary>
        private String _id3;

        /// <summary>
        ///     the value of the "PR_TYPE" field.
        /// </summary>
        private String _type;

        /// <summary>
        ///     the value of the "PR_STATUS" field.
        /// </summary>
        private Int32? _status;

        /// <summary>
        ///     the value of the "PR_REQ_DATE" field.
        /// </summary>
        private DateTime? _reqDate;

        /// <summary>
        ///     the value of the "PR_DONE_DATE" field.
        /// </summary>
        private DateTime? _doneDate;

        /// <summary>
        ///     the value of the "PR_REQ_BY" field.
        /// </summary>
        private String _reqBy;

        /// <summary>
        ///     the value of the "PR_PQ_ID" field.
        /// </summary>
        private String _pqId;

        /// <summary>
        ///     the value of the "PR_ACT_PQ_STATUS" field.
        /// </summary>
        private String _actPqStatus;

        /// <summary>
        ///     the value of the "PR_PQ_SEND_TYPE" field.
        /// </summary>
        private String _pqSendType;

        /// <summary>
        ///     the value of the "PR_PACK_ID" field.
        /// </summary>
        private String _packId;

        /// <summary>
        ///     the value of the "PR_WF_ID" field.
        /// </summary>
        private String _wfId;

        /// <summary>
        ///     the value of the "PR_BAT_ID" field.
        /// </summary>
        private String _batId;

        /// <summary>
        ///     the value of the "PR_LT_ID" field.
        /// </summary>
        private String _ltId;

        /// <summary>
        ///     the value of the "PR_SEND_TO_BOOKER" field.
        /// </summary>
        private Byte? _sendToBooker;

        /// <summary>
        ///     the value of the "PR_SEND_TO_DELEGATE" field.
        /// </summary>
        private Byte? _sendToDelegate;

        /// <summary>
        ///     the value of the "PR_SEND_FROM_PROLE_ID" field.
        /// </summary>
        private String _sendFromProleId;

        /// <summary>
        ///     the value of the "PR_SEND_TO_PROLE_ID" field.
        /// </summary>
        private String _sendToProleId;

        /// <summary>
        ///     the value of the "PR_EMAIL_SUBJECT" field.
        /// </summary>
        private String _emailSubject;

        /// <summary>
        ///     the value of the "PR_EMAIL_CC_ADDRESS" field.
        /// </summary>
        private String _emailCcAddress;

        /// <summary>
        ///     the value of the "PR_REISSUE" field.
        /// </summary>
        private Byte? _reissue;

        /// <summary>
        ///     the value of the "PR_ID_4" field.
        /// </summary>
        private String _id4;

        /// <summary>
        ///     the value of the "PR_WFA_ID" field.
        /// </summary>
        private String _wfaId;

        /// <summary>
        ///     the value of the "PR_USE_HOME_ADDRESS" field.
        /// </summary>
        private Byte? _useHomeAddress;

        /// <summary>
        ///     the value of the "PR_EMAIL_SEND_FROM_PERSON" field.
        /// </summary>
        private Byte? _emailSendFromPerson;

        /// <summary>
        ///     the value of the "PR_SMS_ID" field.
        /// </summary>
        private Int32? _smsId;

        /// <summary>
        ///     the value of the "PR_PR_ID" field.
        /// </summary>
        private String _prId;

        /// <summary>
        ///     the value of the "PR_ID_5" field.
        /// </summary>
        private String _id5;

        /// <summary>
        ///     the value of the "PR_WFXREF_REC_ID" field.
        /// </summary>
        private String _wfxrefRecId;

        /// <summary>
        ///     the value of the "PR_ARG_ID" field.
        /// </summary>
        private String _argId;

        /// <summary>
        ///     the value of the "PR_BCC_EMAIL" field.
        /// </summary>
        private String _bccEmail;

        /// <summary>
        ///     the value of the "PR_MDN_EMAIL" field.
        /// </summary>
        private String _mdnEmail;

        /// <summary>
        ///     the value of the "PR_DSN_EMAIL" field.
        /// </summary>
        private String _dsnEmail;

        /// <summary>
        ///     the value of the "PR_DSN_OPTIONS" field.
        /// </summary>
        private String _dsnOptions;

        /// <summary>
        ///     the value of the "PR_ICM_ID" field.
        /// </summary>
        private Int32? _icmId;

        /// <summary>
        ///     the value of the "PR_NAME" field.
        /// </summary>
        private String _name;

        #endregion

        #region properties

        /// <summary>
        ///     the value of the "PR_ADD_DATE" field.
        /// </summary>
        public DateTime? AddDate
        {
            get { return _addDate; }
            set { _addDate = value; }
        }

        /// <summary>
        ///     the value of the "PR_ADD_BY" field.
        /// </summary>
        public String AddBy
        {
            get { return _addBy; }
            set { _addBy = value; }
        }

        /// <summary>
        ///     the value of the "PR_MOD_DATE" field.
        /// </summary>
        public DateTime? ModDate
        {
            get { return _modDate; }
            set { _modDate = value; }
        }

        /// <summary>
        ///     the value of the "PR_MOD_BY" field.
        /// </summary>
        public String ModBy
        {
            get { return _modBy; }
            set { _modBy = value; }
        }

        /// <summary>
        ///     the value of the "PR_RCV_DATE" field.
        /// </summary>
        public DateTime? RcvDate
        {
            get { return _rcvDate; }
            set { _rcvDate = value; }
        }

        /// <summary>
        ///     the value of the "PR_RCV_FROM" field.
        /// </summary>
        public String RcvFrom
        {
            get { return _rcvFrom; }
            set { _rcvFrom = value; }
        }

        /// <summary>
        ///     the value of the "PR_ID_1" field.
        /// </summary>
        public String Id1
        {
            get { return _id1; }
            set { _id1 = value; }
        }

        /// <summary>
        ///     the value of the "PR_ID_2" field.
        /// </summary>
        public String Id2
        {
            get { return _id2; }
            set { _id2 = value; }
        }

        /// <summary>
        ///     the value of the "PR_ID_3" field.
        /// </summary>
        public String Id3
        {
            get { return _id3; }
            set { _id3 = value; }
        }

        /// <summary>
        ///     the value of the "PR_TYPE" field.
        /// </summary>
        public String Type
        {
            get { return _type; }
            set { _type = value; }
        }

        /// <summary>
        ///     the value of the "PR_STATUS" field.
        /// </summary>
        public Int32? Status
        {
            get { return _status; }
            set { _status = value; }
        }

        /// <summary>
        ///     the value of the "PR_REQ_DATE" field.
        /// </summary>
        public DateTime? ReqDate
        {
            get { return _reqDate; }
            set { _reqDate = value; }
        }

        /// <summary>
        ///     the value of the "PR_DONE_DATE" field.
        /// </summary>
        public DateTime? DoneDate
        {
            get { return _doneDate; }
            set { _doneDate = value; }
        }

        /// <summary>
        ///     the value of the "PR_REQ_BY" field.
        /// </summary>
        public String ReqBy
        {
            get { return _reqBy; }
            set { _reqBy = value; }
        }

        /// <summary>
        ///     the value of the "PR_PQ_ID" field.
        /// </summary>
        public String PqId
        {
            get { return _pqId; }
            set { _pqId = value; }
        }

        /// <summary>
        ///     the value of the "PR_ACT_PQ_STATUS" field.
        /// </summary>
        public String ActPqStatus
        {
            get { return _actPqStatus; }
            set { _actPqStatus = value; }
        }

        /// <summary>
        ///     the value of the "PR_PQ_SEND_TYPE" field.
        /// </summary>
        public String PqSendType
        {
            get { return _pqSendType; }
            set { _pqSendType = value; }
        }

        /// <summary>
        ///     the value of the "PR_PACK_ID" field.
        /// </summary>
        public String PackId
        {
            get { return _packId; }
            set { _packId = value; }
        }

        /// <summary>
        ///     the value of the "PR_WF_ID" field.
        /// </summary>
        public String WfId
        {
            get { return _wfId; }
            set { _wfId = value; }
        }

        /// <summary>
        ///     the value of the "PR_BAT_ID" field.
        /// </summary>
        public String BatId
        {
            get { return _batId; }
            set { _batId = value; }
        }

        /// <summary>
        ///     the value of the "PR_LT_ID" field.
        /// </summary>
        public String LtId
        {
            get { return _ltId; }
            set { _ltId = value; }
        }

        /// <summary>
        ///     the value of the "PR_SEND_TO_BOOKER" field.
        /// </summary>
        public Byte? SendToBooker
        {
            get { return _sendToBooker; }
            set { _sendToBooker = value; }
        }

        /// <summary>
        ///     the value of the "PR_SEND_TO_DELEGATE" field.
        /// </summary>
        public Byte? SendToDelegate
        {
            get { return _sendToDelegate; }
            set { _sendToDelegate = value; }
        }

        /// <summary>
        ///     the value of the "PR_SEND_FROM_PROLE_ID" field.
        /// </summary>
        public String SendFromProleId
        {
            get { return _sendFromProleId; }
            set { _sendFromProleId = value; }
        }

        /// <summary>
        ///     the value of the "PR_SEND_TO_PROLE_ID" field.
        /// </summary>
        public String SendToProleId
        {
            get { return _sendToProleId; }
            set { _sendToProleId = value; }
        }

        /// <summary>
        ///     the value of the "PR_EMAIL_SUBJECT" field.
        /// </summary>
        public String EmailSubject
        {
            get { return _emailSubject; }
            set { _emailSubject = value; }
        }

        /// <summary>
        ///     the value of the "PR_EMAIL_CC_ADDRESS" field.
        /// </summary>
        public String EmailCcAddress
        {
            get { return _emailCcAddress; }
            set { _emailCcAddress = value; }
        }

        /// <summary>
        ///     the value of the "PR_REISSUE" field.
        /// </summary>
        public Byte? Reissue
        {
            get { return _reissue; }
            set { _reissue = value; }
        }

        /// <summary>
        ///     the value of the "PR_ID_4" field.
        /// </summary>
        public String Id4
        {
            get { return _id4; }
            set { _id4 = value; }
        }

        /// <summary>
        ///     the value of the "PR_WFA_ID" field.
        /// </summary>
        public String WfaId
        {
            get { return _wfaId; }
            set { _wfaId = value; }
        }

        /// <summary>
        ///     the value of the "PR_USE_HOME_ADDRESS" field.
        /// </summary>
        public Byte? UseHomeAddress
        {
            get { return _useHomeAddress; }
            set { _useHomeAddress = value; }
        }

        /// <summary>
        ///     the value of the "PR_EMAIL_SEND_FROM_PERSON" field.
        /// </summary>
        public Byte? EmailSendFromPerson
        {
            get { return _emailSendFromPerson; }
            set { _emailSendFromPerson = value; }
        }

        /// <summary>
        ///     the value of the "PR_SMS_ID" field.
        /// </summary>
        public Int32? SmsId
        {
            get { return _smsId; }
            set { _smsId = value; }
        }

        /// <summary>
        ///     the value of the "PR_PR_ID" field.
        /// </summary>
        public String PrId
        {
            get { return _prId; }
            set { _prId = value; }
        }

        /// <summary>
        ///     the value of the "PR_ID_5" field.
        /// </summary>
        public String Id5
        {
            get { return _id5; }
            set { _id5 = value; }
        }

        /// <summary>
        ///     the value of the "PR_WFXREF_REC_ID" field.
        /// </summary>
        public String WfxrefRecId
        {
            get { return _wfxrefRecId; }
            set { _wfxrefRecId = value; }
        }

        /// <summary>
        ///     the value of the "PR_ARG_ID" field.
        /// </summary>
        public String ArgId
        {
            get { return _argId; }
            set { _argId = value; }
        }

        /// <summary>
        ///     the value of the "PR_BCC_EMAIL" field.
        /// </summary>
        public String BccEmail
        {
            get { return _bccEmail; }
            set { _bccEmail = value; }
        }

        /// <summary>
        ///     the value of the "PR_MDN_EMAIL" field.
        /// </summary>
        public String MdnEmail
        {
            get { return _mdnEmail; }
            set { _mdnEmail = value; }
        }

        /// <summary>
        ///     the value of the "PR_DSN_EMAIL" field.
        /// </summary>
        public String DsnEmail
        {
            get { return _dsnEmail; }
            set { _dsnEmail = value; }
        }

        /// <summary>
        ///     the value of the "PR_DSN_OPTIONS" field.
        /// </summary>
        public String DsnOptions
        {
            get { return _dsnOptions; }
            set { _dsnOptions = value; }
        }

        /// <summary>
        ///     the value of the "PR_ICM_ID" field.
        /// </summary>
        public Int32? IcmId
        {
            get { return _icmId; }
            set { _icmId = value; }
        }

        /// <summary>
        ///     the value of the "PR_NAME" field.
        /// </summary>
        public String Name
        {
            get { return _name; }
            set { _name = value; }
        }

        #endregion

        #region methods

        /// <summary>
        ///     Creates a new <see cref="PrintReqRecord" /> object instance that is a shallow-copy of the current object instance.
        /// </summary>
        /// <returns>
        ///     The shallow-copy of the current <see cref="PrintReqRecord" /> object instance.
        /// </returns>
        public PrintReqRecord Clone()
        {
            PrintReqRecord record = new PrintReqRecord();
            record.Id = this.Id;
            record.AddDate = this.AddDate;
            record.AddBy = this.AddBy;
            record.ModDate = this.ModDate;
            record.ModBy = this.ModBy;
            record.RcvDate = this.RcvDate;
            record.RcvFrom = this.RcvFrom;
            record.Id1 = this.Id1;
            record.Id2 = this.Id2;
            record.Id3 = this.Id3;
            record.Type = this.Type;
            record.Status = this.Status;
            record.ReqDate = this.ReqDate;
            record.DoneDate = this.DoneDate;
            record.ReqBy = this.ReqBy;
            record.PqId = this.PqId;
            record.ActPqStatus = this.ActPqStatus;
            record.PqSendType = this.PqSendType;
            record.PackId = this.PackId;
            record.WfId = this.WfId;
            record.BatId = this.BatId;
            record.LtId = this.LtId;
            record.SendToBooker = this.SendToBooker;
            record.SendToDelegate = this.SendToDelegate;
            record.SendFromProleId = this.SendFromProleId;
            record.SendToProleId = this.SendToProleId;
            record.EmailSubject = this.EmailSubject;
            record.EmailCcAddress = this.EmailCcAddress;
            record.Reissue = this.Reissue;
            record.Id4 = this.Id4;
            record.WfaId = this.WfaId;
            record.UseHomeAddress = this.UseHomeAddress;
            record.EmailSendFromPerson = this.EmailSendFromPerson;
            record.SmsId = this.SmsId;
            record.PrId = this.PrId;
            record.Id5 = this.Id5;
            record.WfxrefRecId = this.WfxrefRecId;
            record.ArgId = this.ArgId;
            record.BccEmail = this.BccEmail;
            record.MdnEmail = this.MdnEmail;
            record.DsnEmail = this.DsnEmail;
            record.DsnOptions = this.DsnOptions;
            record.IcmId = this.IcmId;
            record.Name = this.Name;
            return record;
        }

        /// <summary>
        ///     Indicates whether the current <see cref="PrintReqRecord" /> instance is equal to another <see cref="PrintReqRecord" /> instance.
        /// </summary>
        /// <param name="that">
        ///     The <see cref="PrintReqRecord" /> instance to be compared against this instance.
        /// </param>
        /// <returns>
        ///     True if both instances are considered equal; otherwise, false.
        /// </returns>
        public Boolean Equals(PrintReqRecord that)
        {
            Boolean result = true;
            result = result && (this.Id.TrimOrNullify() == that.Id.TrimOrNullify());
            result = result && (this.Id1.TrimOrNullify() == that.Id1.TrimOrNullify());
            result = result && (this.Id2.TrimOrNullify() == that.Id2.TrimOrNullify());
            result = result && (this.Id3.TrimOrNullify() == that.Id3.TrimOrNullify());
            result = result && (this.Type.TrimOrNullify() == that.Type.TrimOrNullify());
            result = result && (this.Status == that.Status);
            result = result && (this.ReqDate == that.ReqDate);
            result = result && (this.DoneDate == that.DoneDate);
            result = result && (this.ReqBy.TrimOrNullify() == that.ReqBy.TrimOrNullify());
            result = result && (this.PqId.TrimOrNullify() == that.PqId.TrimOrNullify());
            result = result && (this.ActPqStatus.TrimOrNullify() == that.ActPqStatus.TrimOrNullify());
            result = result && (this.PqSendType.TrimOrNullify() == that.PqSendType.TrimOrNullify());
            result = result && (this.PackId.TrimOrNullify() == that.PackId.TrimOrNullify());
            result = result && (this.WfId.TrimOrNullify() == that.WfId.TrimOrNullify());
            result = result && (this.BatId.TrimOrNullify() == that.BatId.TrimOrNullify());
            result = result && (this.LtId.TrimOrNullify() == that.LtId.TrimOrNullify());
            result = result && (this.SendToBooker == that.SendToBooker);
            result = result && (this.SendToDelegate == that.SendToDelegate);
            result = result && (this.SendFromProleId.TrimOrNullify() == that.SendFromProleId.TrimOrNullify());
            result = result && (this.SendToProleId.TrimOrNullify() == that.SendToProleId.TrimOrNullify());
            result = result && (this.EmailSubject.TrimOrNullify() == that.EmailSubject.TrimOrNullify());
            result = result && (this.EmailCcAddress.TrimOrNullify() == that.EmailCcAddress.TrimOrNullify());
            result = result && (this.Reissue == that.Reissue);
            result = result && (this.Id4.TrimOrNullify() == that.Id4.TrimOrNullify());
            result = result && (this.WfaId.TrimOrNullify() == that.WfaId.TrimOrNullify());
            result = result && (this.UseHomeAddress == that.UseHomeAddress);
            result = result && (this.EmailSendFromPerson == that.EmailSendFromPerson);
            result = result && (this.SmsId == that.SmsId);
            result = result && (this.PrId.TrimOrNullify() == that.PrId.TrimOrNullify());
            result = result && (this.Id5.TrimOrNullify() == that.Id5.TrimOrNullify());
            result = result && (this.WfxrefRecId.TrimOrNullify() == that.WfxrefRecId.TrimOrNullify());
            result = result && (this.ArgId.TrimOrNullify() == that.ArgId.TrimOrNullify());
            result = result && (this.BccEmail.TrimOrNullify() == that.BccEmail.TrimOrNullify());
            result = result && (this.MdnEmail.TrimOrNullify() == that.MdnEmail.TrimOrNullify());
            result = result && (this.DsnEmail.TrimOrNullify() == that.DsnEmail.TrimOrNullify());
            result = result && (this.DsnOptions.TrimOrNullify() == that.DsnOptions.TrimOrNullify());
            result = result && (this.IcmId == that.IcmId);
            result = result && (this.Name.TrimOrNullify() == that.Name.TrimOrNullify());
            return result;
        }

        #endregion
    }
}
