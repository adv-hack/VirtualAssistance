using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Linq;

namespace Consensus.Document
{
    /// <summary>
    ///     Provides the persistence and retrieval of the <see cref="LettertmpltRecord" /> instances in a Microsoft SQL Server database.
    /// </summary>
    /// <remarks>
    ///     THIS CODE HAS BEEN AUTOMATICALLY GENERATED USING THE CONSENSUS DEVELOPER TOOLS.
    ///     DO NOT EDIT THIS CODE AS ANY CUSTOM MODIFICATIONS WILL BE LOST UPON REGENERATION.
    /// </remarks>
    public partial class SqlServerLetterTemplateRepository : SqlServerRepository<LettertmpltRecord, String>, ILetterTemplateRepository
    {
        #region properties

        /// <summary>
        ///     Gets the namespace in which the data type is contained.
        /// </summary>
        protected override String TypeNamespace
        {
            get { return "Document"; }
        }

        /// <summary>
        ///     Gets the name of the data type which is persisted by this repository.
        /// </summary>
        protected override String TypeName
        {
            get { return "Lettertmplt"; }
        }

        /// <summary>
        ///     Gets the name of the parameter which is used to specify the unique value that identifies each instance of a <see cref="LettertmpltRecord" />.
        /// </summary>
        protected override String TypeKeyName
        {
            get { return "@PA_LT_ID"; }
        }

        /// <summary>
        ///     Gets the underlying table name that this repository sit over.
        /// </summary>
        public override String TableName
        {
            get { return "LetterTmplt"; }
        }

        #endregion

        #region methods

        /// <summary>
        ///     Maps an <see cref="IDataRecord" /> to the specified <see cref="LettertmpltRecord" />.
        /// </summary>
        /// <param name="dataRecord">
        ///     The <see cref="IDataRecord" /> to be mapped.
        /// </param>
        /// <param name="record">
        ///     The <see cref="LettertmpltRecord" /> instance to be mapped to.
        /// </param>
        protected override void MapRecord(IDataRecord dataRecord, LettertmpltRecord record)
        {
            record.Id = dataRecord["LT_ID"].ConvertTo<String>();
            record.Lock = dataRecord["LT_LOCK"].ConvertTo<String>();
            record.AddDate = dataRecord["LT_ADD_DATE"].ConvertTo<DateTime?>();
            record.AddBy = dataRecord["LT_ADD_BY"].ConvertTo<String>();
            record.ModDate = dataRecord["LT_MOD_DATE"].ConvertTo<DateTime?>();
            record.ModBy = dataRecord["LT_MOD_BY"].ConvertTo<String>();
            record.RcvDate = dataRecord["LT_RCV_DATE"].ConvertTo<DateTime?>();
            record.RcvFrom = dataRecord["LT_RCV_FROM"].ConvertTo<String>();
            record.Name = dataRecord["LT_NAME"].ConvertTo<String>();
            record.Type = dataRecord["LT_TYPE"].ConvertTo<String>();
            record.Private = dataRecord["LT_PRIVATE"].ConvertTo<Byte?>();
            record.Section = dataRecord["LT_SECTION"].ConvertTo<Byte?>();
            record.ProleId = dataRecord["LT_PROLE_ID"].ConvertTo<String>();
            record.Language = dataRecord["LT_LANGUAGE"].ConvertTo<String>();
            record.Desc = dataRecord["LT_DESC"].ConvertTo<String>();
            record.Text = dataRecord["LT_TEXT"].ConvertTo<String>();
            record.Level = dataRecord["LT_LEVEL"].ConvertTo<Int32?>();
            record.Index = dataRecord["LT_INDEX"].ConvertTo<String>();
            record.Page = dataRecord["LT_PAGE"].ConvertTo<String>();
            record.ForUseWith = dataRecord["LT_FOR_USE_WITH"].ConvertTo<Byte?>();
            record.FileName = dataRecord["LT_FILE_NAME"].ConvertTo<String>();
            record.SelcoSpId = dataRecord["LT_SELCO_SP_ID"].ConvertTo<String>();
            record.PrintOnly = dataRecord["LT_PRINT_ONLY"].ConvertTo<Byte?>();
            record.EmailSubject = dataRecord["LT_EMAIL_SUBJECT"].ConvertTo<String>();
            record.LocalprintOnly = dataRecord["LT_LOCALPRINT_ONLY"].ConvertTo<Byte?>();
            record.Pdf = dataRecord["LT_PDF"].ConvertTo<Byte?>();
            record.SendProleId = dataRecord["LT_SEND_PROLE_ID"].ConvertTo<String>();
            record.Current = dataRecord["LT_CURRENT"].ConvertTo<Byte>();
            record.EmailBody = dataRecord["LT_EMAIL_BODY"].ConvertTo<Byte>();
            record.PqId = dataRecord["LT_PQ_ID"].ConvertTo<String>();
            record.AttId = dataRecord["LT_ATT_ID"].ConvertTo<String>();
            record.Label = dataRecord["LT_LABEL"].ConvertTo<Byte?>();
        }

        /// <summary>
        ///     Sets the parameter values for the specified <paramref name="command" /> based on the specified <typeparamref name="TRecord" /> instance.
        /// </summary>
        /// <param name="command">
        ///     The <see cref="IDbCommand" /> containing the parameters to be mapped.
        /// </param>
        /// <param name="record">
        ///     The <see cref="LettertmpltRecord" /> instance to be mapped.
        /// </param>
        /// <param name="useV6Logic">
        ///     Is the procedure being run an old version 6.x procedure? (the null value handling logic is different).
        /// </param>
        protected override void MapParametersIn(IDbCommand command, LettertmpltRecord record, bool useV6Logic)
        {
            this.MapParameterIn(command, "@PA_LT_ID", record.Id);
            this.MapParameterIn(command, "@PA_LT_LOCK", record.Lock);
            this.MapParameterIn(command, "@PA_LT_NAME", record.Name);
            this.MapParameterIn(command, "@PA_LT_TYPE", record.Type);
            this.MapParameterIn(command, "@PA_LT_PRIVATE", record.Private);
            this.MapParameterIn(command, "@PA_LT_SECTION", record.Section);
            this.MapParameterIn(command, "@PA_LT_PROLE_ID", record.ProleId);
            this.MapParameterIn(command, "@PA_LT_LANGUAGE", record.Language);
            this.MapParameterIn(command, "@PA_LT_DESC", record.Desc);
            this.MapParameterIn(command, "@PA_LT_TEXT", record.Text);
            this.MapParameterIn(command, "@PA_LT_LEVEL", record.Level == Int32.MinValue ? ( useV6Logic ? new Int32?(0) : null ) : record.Level);
            this.MapParameterIn(command, "@PA_LT_INDEX", record.Index);
            this.MapParameterIn(command, "@PA_LT_PAGE", record.Page);
            this.MapParameterIn(command, "@PA_LT_FOR_USE_WITH", record.ForUseWith);
            this.MapParameterIn(command, "@PA_LT_FILE_NAME", record.FileName);
            this.MapParameterIn(command, "@PA_LT_SELCO_SP_ID", record.SelcoSpId);
            this.MapParameterIn(command, "@PA_LT_PRINT_ONLY", record.PrintOnly);
            this.MapParameterIn(command, "@PA_LT_EMAIL_SUBJECT", record.EmailSubject);
            this.MapParameterIn(command, "@PA_LT_LOCALPRINT_ONLY", record.LocalprintOnly);
            this.MapParameterIn(command, "@PA_LT_PDF", record.Pdf);
            this.MapParameterIn(command, "@PA_LT_SEND_PROLE_ID", record.SendProleId);
            this.MapParameterIn(command, "@PA_LT_CURRENT", record.Current);
            this.MapParameterIn(command, "@PA_LT_EMAIL_BODY", record.EmailBody);
            this.MapParameterIn(command, "@PA_LT_PQ_ID", record.PqId);
            this.MapParameterIn(command, "@PA_LT_ATT_ID", record.AttId);
            this.MapParameterIn(command, "@PA_LT_LABEL", record.Label);
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
        ///     The <see cref="LettertmpltRecord" /> instance to be updated.
        /// </param>
        protected override void MapParametersOut(IDbCommand command, LettertmpltRecord record)
        {
            record.Id = this.MapParameterOut(command, "@PA_LT_ID", record.Id);
            record.Lock = this.MapParameterOut(command, "@PA_LT_LOCK", record.Lock);
            record.Name = this.MapParameterOut(command, "@PA_LT_NAME", record.Name);
            record.Type = this.MapParameterOut(command, "@PA_LT_TYPE", record.Type);
            record.Private = this.MapParameterOut(command, "@PA_LT_PRIVATE", record.Private);
            record.Section = this.MapParameterOut(command, "@PA_LT_SECTION", record.Section);
            record.ProleId = this.MapParameterOut(command, "@PA_LT_PROLE_ID", record.ProleId);
            record.Language = this.MapParameterOut(command, "@PA_LT_LANGUAGE", record.Language);
            record.Desc = this.MapParameterOut(command, "@PA_LT_DESC", record.Desc);
            record.Text = this.MapParameterOut(command, "@PA_LT_TEXT", record.Text);
            record.Level = this.MapParameterOut(command, "@PA_LT_LEVEL", record.Level);
            record.Index = this.MapParameterOut(command, "@PA_LT_INDEX", record.Index);
            record.Page = this.MapParameterOut(command, "@PA_LT_PAGE", record.Page);
            record.ForUseWith = this.MapParameterOut(command, "@PA_LT_FOR_USE_WITH", record.ForUseWith);
            record.FileName = this.MapParameterOut(command, "@PA_LT_FILE_NAME", record.FileName);
            record.SelcoSpId = this.MapParameterOut(command, "@PA_LT_SELCO_SP_ID", record.SelcoSpId);
            record.PrintOnly = this.MapParameterOut(command, "@PA_LT_PRINT_ONLY", record.PrintOnly);
            record.EmailSubject = this.MapParameterOut(command, "@PA_LT_EMAIL_SUBJECT", record.EmailSubject);
            record.LocalprintOnly = this.MapParameterOut(command, "@PA_LT_LOCALPRINT_ONLY", record.LocalprintOnly);
            record.Pdf = this.MapParameterOut(command, "@PA_LT_PDF", record.Pdf);
            record.SendProleId = this.MapParameterOut(command, "@PA_LT_SEND_PROLE_ID", record.SendProleId);
            record.Current = this.MapParameterOut(command, "@PA_LT_CURRENT", record.Current);
            record.EmailBody = this.MapParameterOut(command, "@PA_LT_EMAIL_BODY", record.EmailBody);
            record.PqId = this.MapParameterOut(command, "@PA_LT_PQ_ID", record.PqId);
            record.AttId = this.MapParameterOut(command, "@PA_LT_ATT_ID", record.AttId);
            record.Label = this.MapParameterOut(command, "@PA_LT_LABEL", record.Label);
            record.Id = this.MapParameterOut(command, "@PA_RETURN_ID", record.Id);
        }

        /// <summary>
        ///     Retrieves a collection of <see cref="LettertmpltRecord" /> instances from the data store.
        /// </summary>
        /// <param name="type">
        ///     The value which identifies the <see cref='LetterTemplateModel' /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The collection of <see cref="LettertmpltRecord" /> instances that match the specified <paramref name='type' />.
        /// </returns>
        public IEnumerable<LettertmpltRecord> FetchAllByType(String type)
        {
            DbCommand command = this.GetStoredProcedure(SqlServerOperation.FetchAll, "Type");
            this.MapParameterIn(command, "@PA_LT_TYPE", type);
            return this.Execute(command);
        }

        /// <summary>
        ///     Retrieves a collection of <see cref="LettertmpltRecord" /> instances from the data store.
        /// </summary>
        /// <param name="selcoSpId">
        ///     The value which identifies the <see cref='LetterTemplateModel' /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The collection of <see cref="LettertmpltRecord" /> instances that match the specified <paramref name='selcoSpId' />.
        /// </returns>
        public IEnumerable<LettertmpltRecord> FetchAllBySelcoSpId(String selcoSpId)
        {
            DbCommand command = this.GetStoredProcedure(SqlServerOperation.FetchAll, "SelcoSpId");
            this.MapParameterIn(command, "@PA_LT_SELCO_SP_ID", selcoSpId);
            return this.Execute(command);
        }

        /// <summary>
        ///     Retrieves a collection of <see cref="LettertmpltRecord" /> instances from the data store.
        /// </summary>
        /// <param name="sendProleId">
        ///     The value which identifies the <see cref='LetterTemplateModel' /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The collection of <see cref="LettertmpltRecord" /> instances that match the specified <paramref name='sendProleId' />.
        /// </returns>
        public IEnumerable<LettertmpltRecord> FetchAllBySendProleId(String sendProleId)
        {
            DbCommand command = this.GetStoredProcedure(SqlServerOperation.FetchAll, "SendProleId");
            this.MapParameterIn(command, "@PA_LT_SEND_PROLE_ID", sendProleId);
            return this.Execute(command);
        }

        #endregion

        #region implementations

        /// <summary>
        ///     Gets the underlying table name that this repository sit over.
        /// </summary>
        System.String ILetterTemplateRepository.TableName
        {
            get { return this.TableName; }
        }

        void ILetterTemplateRepository.Create(Consensus.Document.LettertmpltRecord record)
        {
            this.Create(record);
        }

        void ILetterTemplateRepository.Modify(Consensus.Document.LettertmpltRecord record)
        {
            this.Modify(record);
        }

        /// <summary>
        ///     Retrieves a collection of <see cref="T:Consensus.Document.LettertmpltRecord" /> instances from the data store.
        /// </summary>
        /// <param name="type">
        ///     The value which identifies the <see cref="!:LetterTemplateModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The collection of <see cref="T:Consensus.Document.LettertmpltRecord" /> instances that match the specified <paramref name="type" />.
        /// </returns>
        System.Collections.Generic.IEnumerable<Consensus.Document.LettertmpltRecord> ILetterTemplateRepository.FetchAllByType(System.String type)
        {
            return this.FetchAllByType(type);
        }

        /// <summary>
        ///     Retrieves a collection of <see cref="T:Consensus.Document.LettertmpltRecord" /> instances from the data store.
        /// </summary>
        /// <param name="selcoSpId">
        ///     The value which identifies the <see cref="!:LetterTemplateModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The collection of <see cref="T:Consensus.Document.LettertmpltRecord" /> instances that match the specified <paramref name="selcoSpId" />.
        /// </returns>
        System.Collections.Generic.IEnumerable<Consensus.Document.LettertmpltRecord> ILetterTemplateRepository.FetchAllBySelcoSpId(System.String selcoSpId)
        {
            return this.FetchAllBySelcoSpId(selcoSpId);
        }

        /// <summary>
        ///     Retrieves a collection of <see cref="T:Consensus.Document.LettertmpltRecord" /> instances from the data store.
        /// </summary>
        /// <param name="sendProleId">
        ///     The value which identifies the <see cref="!:LetterTemplateModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The collection of <see cref="T:Consensus.Document.LettertmpltRecord" /> instances that match the specified <paramref name="sendProleId" />.
        /// </returns>
        System.Collections.Generic.IEnumerable<Consensus.Document.LettertmpltRecord> ILetterTemplateRepository.FetchAllBySendProleId(System.String sendProleId)
        {
            return this.FetchAllBySendProleId(sendProleId);
        }

        #endregion
    }
}
