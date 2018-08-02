using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Linq;

namespace Consensus.Marketing
{
    /// <summary>
    ///     Represents the "SAQ_QUERY_QUEUE" data structure.
    /// </summary>
    /// <remarks>
    ///     THIS CODE HAS BEEN AUTOMATICALLY GENERATED USING THE CONSENSUS DEVELOPER TOOLS.
    ///     DO NOT EDIT THIS CODE AS ANY CUSTOM MODIFICATIONS WILL BE LOST UPON REGENERATION.
    /// </remarks>
    public class SaqQueryQueueRecord : Record<Int64>, Cloneable<SaqQueryQueueRecord>, IEquatable<SaqQueryQueueRecord>
    {
        #region fields

        /// <summary>
        ///     the value of the "QQ_ADD_BY" field.
        /// </summary>
        private String _addBy;

        /// <summary>
        ///     the value of the "QQ_ADD_DATE" field.
        /// </summary>
        private DateTime _addDate;

        /// <summary>
        ///     the value of the "QQ_MOD_BY" field.
        /// </summary>
        private String _modBy;

        /// <summary>
        ///     the value of the "QQ_MOD_DATE" field.
        /// </summary>
        private DateTime _modDate;

        /// <summary>
        ///     the value of the "QQ_PROLE_ID" field.
        /// </summary>
        private String _proleId;

        /// <summary>
        ///     the value of the "QQ_PRIORITY" field.
        /// </summary>
        private Byte _priority;

        /// <summary>
        ///     the value of the "QQ_PROCESSED" field.
        /// </summary>
        private Byte _processed;

        /// <summary>
        ///     the value of the "QQ_QRY_ID" field.
        /// </summary>
        private Int64 _qryId;

        /// <summary>
        ///     the value of the "QQ_OUTPUT_OPTION" field.
        /// </summary>
        private Byte? _outputOption;

        /// <summary>
        ///     the value of the "QQ_PROCESS_OPTION" field.
        /// </summary>
        private Byte? _processOption;

        /// <summary>
        ///     the value of the "QQ_EMAIL_WHEN_DONE" field.
        /// </summary>
        private Byte _emailWhenDone;

        /// <summary>
        ///     the value of the "QQ_REDO_RESULTS_IF_EXIST" field.
        /// </summary>
        private Byte _redoResultsIfExist;

        /// <summary>
        ///     the value of the "QQ_EMAIL_ADDRESS" field.
        /// </summary>
        private String _emailAddress;

        /// <summary>
        ///     the value of the "QQ_ACT_TYPE" field.
        /// </summary>
        private String _actType;

        /// <summary>
        ///     the value of the "QQ_ACT_DATE" field.
        /// </summary>
        private DateTime? _actDate;

        /// <summary>
        ///     the value of the "QQ_ACT_PROLE_ID" field.
        /// </summary>
        private String _actProleId;

        /// <summary>
        ///     the value of the "QQ_ACT_NOTE" field.
        /// </summary>
        private String _actNote;

        /// <summary>
        ///     the value of the "QQ_LIST_ID" field.
        /// </summary>
        private String _listId;

        /// <summary>
        ///     the value of the "QQ_PROF_KEY" field.
        /// </summary>
        private String _profKey;

        /// <summary>
        ///     the value of the "QQ_PROF_VALUE" field.
        /// </summary>
        private String _profValue;

        /// <summary>
        ///     the value of the "QQ_PROF_VALUE2" field.
        /// </summary>
        private String _profValue2;

        /// <summary>
        ///     the value of the "QQ_PROF_VALUE3" field.
        /// </summary>
        private String _profValue3;

        /// <summary>
        ///     the value of the "QQ_FILE_TYPE" field.
        /// </summary>
        private String _fileType;

        /// <summary>
        ///     the value of the "QQ_PM_ID" field.
        /// </summary>
        private String _pmId;

        /// <summary>
        ///     the value of the "QQ_DATE_SELECTED" field.
        /// </summary>
        private DateTime? _dateSelected;

        /// <summary>
        ///     the value of the "QQ_STATUS" field.
        /// </summary>
        private String _status;

        /// <summary>
        ///     the value of the "QQ_ERROR" field.
        /// </summary>
        private String _error;

        /// <summary>
        ///     the value of the "QQ_PROF_KEY_ORG" field.
        /// </summary>
        private String _profKeyOrg;

        /// <summary>
        ///     the value of the "QQ_PROF_VALUE_ORG" field.
        /// </summary>
        private String _profValueOrg;

        /// <summary>
        ///     the value of the "QQ_PROF_VALUE2_ORG" field.
        /// </summary>
        private String _profValue2Org;

        /// <summary>
        ///     the value of the "QQ_RESULTS_TYPE" field.
        /// </summary>
        private String _resultsType;

        /// <summary>
        ///     the value of the "QQ_ACT_ARG_ID" field.
        /// </summary>
        private String _actArgId;

        /// <summary>
        ///     the value of the "QQ_ACT_QUEST_ID" field.
        /// </summary>
        private String _actQuestId;

        /// <summary>
        ///     the value of the "QQ_ACT_PROMOTION_ID" field.
        /// </summary>
        private String _actPromotionId;

        /// <summary>
        ///     the value of the "QQ_BPP_LIT_ID" field.
        /// </summary>
        private String _bppLitId;

        /// <summary>
        ///     the value of the "QQ_PACK_ID" field.
        /// </summary>
        private String _packId;

        #endregion

        #region properties

        /// <summary>
        ///     the value of the "QQ_ADD_BY" field.
        /// </summary>
        public String AddBy
        {
            get { return _addBy; }
            set { _addBy = value; }
        }

        /// <summary>
        ///     the value of the "QQ_ADD_DATE" field.
        /// </summary>
        public DateTime AddDate
        {
            get { return _addDate; }
            set { _addDate = value; }
        }

        /// <summary>
        ///     the value of the "QQ_MOD_BY" field.
        /// </summary>
        public String ModBy
        {
            get { return _modBy; }
            set { _modBy = value; }
        }

        /// <summary>
        ///     the value of the "QQ_MOD_DATE" field.
        /// </summary>
        public DateTime ModDate
        {
            get { return _modDate; }
            set { _modDate = value; }
        }

        /// <summary>
        ///     the value of the "QQ_PROLE_ID" field.
        /// </summary>
        public String ProleId
        {
            get { return _proleId; }
            set { _proleId = value; }
        }

        /// <summary>
        ///     the value of the "QQ_PRIORITY" field.
        /// </summary>
        public Byte Priority
        {
            get { return _priority; }
            set { _priority = value; }
        }

        /// <summary>
        ///     the value of the "QQ_PROCESSED" field.
        /// </summary>
        public Byte Processed
        {
            get { return _processed; }
            set { _processed = value; }
        }

        /// <summary>
        ///     the value of the "QQ_QRY_ID" field.
        /// </summary>
        public Int64 QryId
        {
            get { return _qryId; }
            set { _qryId = value; }
        }

        /// <summary>
        ///     the value of the "QQ_OUTPUT_OPTION" field.
        /// </summary>
        public Byte? OutputOption
        {
            get { return _outputOption; }
            set { _outputOption = value; }
        }

        /// <summary>
        ///     the value of the "QQ_PROCESS_OPTION" field.
        /// </summary>
        public Byte? ProcessOption
        {
            get { return _processOption; }
            set { _processOption = value; }
        }

        /// <summary>
        ///     the value of the "QQ_EMAIL_WHEN_DONE" field.
        /// </summary>
        public Byte EmailWhenDone
        {
            get { return _emailWhenDone; }
            set { _emailWhenDone = value; }
        }

        /// <summary>
        ///     the value of the "QQ_REDO_RESULTS_IF_EXIST" field.
        /// </summary>
        public Byte RedoResultsIfExist
        {
            get { return _redoResultsIfExist; }
            set { _redoResultsIfExist = value; }
        }

        /// <summary>
        ///     the value of the "QQ_EMAIL_ADDRESS" field.
        /// </summary>
        public String EmailAddress
        {
            get { return _emailAddress; }
            set { _emailAddress = value; }
        }

        /// <summary>
        ///     the value of the "QQ_ACT_TYPE" field.
        /// </summary>
        public String ActType
        {
            get { return _actType; }
            set { _actType = value; }
        }

        /// <summary>
        ///     the value of the "QQ_ACT_DATE" field.
        /// </summary>
        public DateTime? ActDate
        {
            get { return _actDate; }
            set { _actDate = value; }
        }

        /// <summary>
        ///     the value of the "QQ_ACT_PROLE_ID" field.
        /// </summary>
        public String ActProleId
        {
            get { return _actProleId; }
            set { _actProleId = value; }
        }

        /// <summary>
        ///     the value of the "QQ_ACT_NOTE" field.
        /// </summary>
        public String ActNote
        {
            get { return _actNote; }
            set { _actNote = value; }
        }

        /// <summary>
        ///     the value of the "QQ_LIST_ID" field.
        /// </summary>
        public String ListId
        {
            get { return _listId; }
            set { _listId = value; }
        }

        /// <summary>
        ///     the value of the "QQ_PROF_KEY" field.
        /// </summary>
        public String ProfKey
        {
            get { return _profKey; }
            set { _profKey = value; }
        }

        /// <summary>
        ///     the value of the "QQ_PROF_VALUE" field.
        /// </summary>
        public String ProfValue
        {
            get { return _profValue; }
            set { _profValue = value; }
        }

        /// <summary>
        ///     the value of the "QQ_PROF_VALUE2" field.
        /// </summary>
        public String ProfValue2
        {
            get { return _profValue2; }
            set { _profValue2 = value; }
        }

        /// <summary>
        ///     the value of the "QQ_PROF_VALUE3" field.
        /// </summary>
        public String ProfValue3
        {
            get { return _profValue3; }
            set { _profValue3 = value; }
        }

        /// <summary>
        ///     the value of the "QQ_FILE_TYPE" field.
        /// </summary>
        public String FileType
        {
            get { return _fileType; }
            set { _fileType = value; }
        }

        /// <summary>
        ///     the value of the "QQ_PM_ID" field.
        /// </summary>
        public String PmId
        {
            get { return _pmId; }
            set { _pmId = value; }
        }

        /// <summary>
        ///     the value of the "QQ_DATE_SELECTED" field.
        /// </summary>
        public DateTime? DateSelected
        {
            get { return _dateSelected; }
            set { _dateSelected = value; }
        }

        /// <summary>
        ///     the value of the "QQ_STATUS" field.
        /// </summary>
        public String Status
        {
            get { return _status; }
            set { _status = value; }
        }

        /// <summary>
        ///     the value of the "QQ_ERROR" field.
        /// </summary>
        public String Error
        {
            get { return _error; }
            set { _error = value; }
        }

        /// <summary>
        ///     the value of the "QQ_PROF_KEY_ORG" field.
        /// </summary>
        public String ProfKeyOrg
        {
            get { return _profKeyOrg; }
            set { _profKeyOrg = value; }
        }

        /// <summary>
        ///     the value of the "QQ_PROF_VALUE_ORG" field.
        /// </summary>
        public String ProfValueOrg
        {
            get { return _profValueOrg; }
            set { _profValueOrg = value; }
        }

        /// <summary>
        ///     the value of the "QQ_PROF_VALUE2_ORG" field.
        /// </summary>
        public String ProfValue2Org
        {
            get { return _profValue2Org; }
            set { _profValue2Org = value; }
        }

        /// <summary>
        ///     the value of the "QQ_RESULTS_TYPE" field.
        /// </summary>
        public String ResultsType
        {
            get { return _resultsType; }
            set { _resultsType = value; }
        }

        /// <summary>
        ///     the value of the "QQ_ACT_ARG_ID" field.
        /// </summary>
        public String ActArgId
        {
            get { return _actArgId; }
            set { _actArgId = value; }
        }

        /// <summary>
        ///     the value of the "QQ_ACT_QUEST_ID" field.
        /// </summary>
        public String ActQuestId
        {
            get { return _actQuestId; }
            set { _actQuestId = value; }
        }

        /// <summary>
        ///     the value of the "QQ_ACT_PROMOTION_ID" field.
        /// </summary>
        public String ActPromotionId
        {
            get { return _actPromotionId; }
            set { _actPromotionId = value; }
        }

        /// <summary>
        ///     the value of the "QQ_BPP_LIT_ID" field.
        /// </summary>
        public String BppLitId
        {
            get { return _bppLitId; }
            set { _bppLitId = value; }
        }

        /// <summary>
        ///     the value of the "QQ_PACK_ID" field.
        /// </summary>
        public String PackId
        {
            get { return _packId; }
            set { _packId = value; }
        }

        #endregion

        #region methods

        /// <summary>
        ///     Creates a new <see cref="SaqQueryQueueRecord" /> object instance that is a shallow-copy of the current object instance.
        /// </summary>
        /// <returns>
        ///     The shallow-copy of the current <see cref="SaqQueryQueueRecord" /> object instance.
        /// </returns>
        public SaqQueryQueueRecord Clone()
        {
            SaqQueryQueueRecord record = new SaqQueryQueueRecord();
            record.Id = this.Id;
            record.AddBy = this.AddBy;
            record.AddDate = this.AddDate;
            record.ModBy = this.ModBy;
            record.ModDate = this.ModDate;
            record.ProleId = this.ProleId;
            record.Priority = this.Priority;
            record.Processed = this.Processed;
            record.QryId = this.QryId;
            record.OutputOption = this.OutputOption;
            record.ProcessOption = this.ProcessOption;
            record.EmailWhenDone = this.EmailWhenDone;
            record.RedoResultsIfExist = this.RedoResultsIfExist;
            record.EmailAddress = this.EmailAddress;
            record.ActType = this.ActType;
            record.ActDate = this.ActDate;
            record.ActProleId = this.ActProleId;
            record.ActNote = this.ActNote;
            record.ListId = this.ListId;
            record.ProfKey = this.ProfKey;
            record.ProfValue = this.ProfValue;
            record.ProfValue2 = this.ProfValue2;
            record.ProfValue3 = this.ProfValue3;
            record.FileType = this.FileType;
            record.PmId = this.PmId;
            record.DateSelected = this.DateSelected;
            record.Status = this.Status;
            record.Error = this.Error;
            record.ProfKeyOrg = this.ProfKeyOrg;
            record.ProfValueOrg = this.ProfValueOrg;
            record.ProfValue2Org = this.ProfValue2Org;
            record.ResultsType = this.ResultsType;
            record.ActArgId = this.ActArgId;
            record.ActQuestId = this.ActQuestId;
            record.ActPromotionId = this.ActPromotionId;
            record.BppLitId = this.BppLitId;
            record.PackId = this.PackId;
            return record;
        }

        /// <summary>
        ///     Indicates whether the current <see cref="SaqQueryQueueRecord" /> instance is equal to another <see cref="SaqQueryQueueRecord" /> instance.
        /// </summary>
        /// <param name="that">
        ///     The <see cref="SaqQueryQueueRecord" /> instance to be compared against this instance.
        /// </param>
        /// <returns>
        ///     True if both instances are considered equal; otherwise, false.
        /// </returns>
        public Boolean Equals(SaqQueryQueueRecord that)
        {
            Boolean result = true;
            result = result && (this.Id == that.Id);
            result = result && (this.ProleId.TrimOrNullify() == that.ProleId.TrimOrNullify());
            result = result && (this.Priority == that.Priority);
            result = result && (this.Processed == that.Processed);
            result = result && (this.QryId == that.QryId);
            result = result && (this.OutputOption == that.OutputOption);
            result = result && (this.ProcessOption == that.ProcessOption);
            result = result && (this.EmailWhenDone == that.EmailWhenDone);
            result = result && (this.RedoResultsIfExist == that.RedoResultsIfExist);
            result = result && (this.EmailAddress.TrimOrNullify() == that.EmailAddress.TrimOrNullify());
            result = result && (this.ActType.TrimOrNullify() == that.ActType.TrimOrNullify());
            result = result && (this.ActDate == that.ActDate);
            result = result && (this.ActProleId.TrimOrNullify() == that.ActProleId.TrimOrNullify());
            result = result && (this.ActNote.TrimOrNullify() == that.ActNote.TrimOrNullify());
            result = result && (this.ListId.TrimOrNullify() == that.ListId.TrimOrNullify());
            result = result && (this.ProfKey.TrimOrNullify() == that.ProfKey.TrimOrNullify());
            result = result && (this.ProfValue.TrimOrNullify() == that.ProfValue.TrimOrNullify());
            result = result && (this.ProfValue2.TrimOrNullify() == that.ProfValue2.TrimOrNullify());
            result = result && (this.ProfValue3.TrimOrNullify() == that.ProfValue3.TrimOrNullify());
            result = result && (this.FileType.TrimOrNullify() == that.FileType.TrimOrNullify());
            result = result && (this.PmId.TrimOrNullify() == that.PmId.TrimOrNullify());
            result = result && (this.DateSelected == that.DateSelected);
            result = result && (this.Status.TrimOrNullify() == that.Status.TrimOrNullify());
            result = result && (this.Error.TrimOrNullify() == that.Error.TrimOrNullify());
            result = result && (this.ProfKeyOrg.TrimOrNullify() == that.ProfKeyOrg.TrimOrNullify());
            result = result && (this.ProfValueOrg.TrimOrNullify() == that.ProfValueOrg.TrimOrNullify());
            result = result && (this.ProfValue2Org.TrimOrNullify() == that.ProfValue2Org.TrimOrNullify());
            result = result && (this.ResultsType.TrimOrNullify() == that.ResultsType.TrimOrNullify());
            result = result && (this.ActArgId.TrimOrNullify() == that.ActArgId.TrimOrNullify());
            result = result && (this.ActQuestId.TrimOrNullify() == that.ActQuestId.TrimOrNullify());
            result = result && (this.ActPromotionId.TrimOrNullify() == that.ActPromotionId.TrimOrNullify());
            result = result && (this.BppLitId.TrimOrNullify() == that.BppLitId.TrimOrNullify());
            result = result && (this.PackId.TrimOrNullify() == that.PackId.TrimOrNullify());
            return result;
        }

        #endregion
    }
}
