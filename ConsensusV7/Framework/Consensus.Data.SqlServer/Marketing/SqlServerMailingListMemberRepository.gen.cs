using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Linq;

namespace Consensus.Marketing
{
    /// <summary>
    ///     Provides the persistence and retrieval of the <see cref="ListMemberRecord" /> instances in a Microsoft SQL Server database.
    /// </summary>
    /// <remarks>
    ///     THIS CODE HAS BEEN AUTOMATICALLY GENERATED USING THE CONSENSUS DEVELOPER TOOLS.
    ///     DO NOT EDIT THIS CODE AS ANY CUSTOM MODIFICATIONS WILL BE LOST UPON REGENERATION.
    /// </remarks>
    public partial class SqlServerMailingListMemberRepository : SqlServerRepository<ListMemberRecord, String>, IMailingListMemberRepository
    {
        #region properties

        /// <summary>
        ///     Gets the namespace in which the data type is contained.
        /// </summary>
        protected override String TypeNamespace
        {
            get { return "Marketing"; }
        }

        /// <summary>
        ///     Gets the name of the data type which is persisted by this repository.
        /// </summary>
        protected override String TypeName
        {
            get { return "ListMember"; }
        }

        /// <summary>
        ///     Gets the name of the parameter which is used to specify the unique value that identifies each instance of a <see cref="ListMemberRecord" />.
        /// </summary>
        protected override String TypeKeyName
        {
            get { return "@PA_LM_ID"; }
        }

        /// <summary>
        ///     Gets the underlying table name that this repository sit over.
        /// </summary>
        public override String TableName
        {
            get { return "List_Member"; }
        }

        #endregion

        #region methods

        /// <summary>
        ///     Maps an <see cref="IDataRecord" /> to the specified <see cref="ListMemberRecord" />.
        /// </summary>
        /// <param name="dataRecord">
        ///     The <see cref="IDataRecord" /> to be mapped.
        /// </param>
        /// <param name="record">
        ///     The <see cref="ListMemberRecord" /> instance to be mapped to.
        /// </param>
        protected override void MapRecord(IDataRecord dataRecord, ListMemberRecord record)
        {
            record.Id = dataRecord["LM_ID"].ConvertTo<String>();
            record.Lock = dataRecord["LM_LOCK"].ConvertTo<String>();
            record.AddBy = dataRecord["LM_ADD_BY"].ConvertTo<String>();
            record.AddDate = dataRecord["LM_ADD_DATE"].ConvertTo<DateTime?>();
            record.ModBy = dataRecord["LM_MOD_BY"].ConvertTo<String>();
            record.ModDate = dataRecord["LM_MOD_DATE"].ConvertTo<DateTime?>();
            record.RcvDate = dataRecord["LM_RCV_DATE"].ConvertTo<DateTime?>();
            record.RcvFrom = dataRecord["LM_RCV_FROM"].ConvertTo<String>();
            record.ListId = dataRecord["LM_LIST_ID"].ConvertTo<String>();
            record.PnId = dataRecord["LM_PN_ID"].ConvertTo<String>();
            record.Title = dataRecord["LM_TITLE"].ConvertTo<String>();
            record.Userchar1 = dataRecord["LM_USERCHAR_1"].ConvertTo<String>();
            record.Userchar2 = dataRecord["LM_USERCHAR_2"].ConvertTo<String>();
            record.Userchar3 = dataRecord["LM_USERCHAR_3"].ConvertTo<String>();
            record.Userchar4 = dataRecord["LM_USERCHAR_4"].ConvertTo<String>();
            record.TermsRead = dataRecord["LM_TERMS_READ"].ConvertTo<Byte>();
            record.TableName = dataRecord["LM_TABLE_NAME"].ConvertTo<String>();
            record.RecordId = dataRecord["LM_RECORD_ID"].ConvertTo<String>();
            record.Disable = dataRecord["LM_DISABLE"].ConvertTo<Byte>();
        }

        /// <summary>
        ///     Sets the parameter values for the specified <paramref name="command" /> based on the specified <typeparamref name="TRecord" /> instance.
        /// </summary>
        /// <param name="command">
        ///     The <see cref="IDbCommand" /> containing the parameters to be mapped.
        /// </param>
        /// <param name="record">
        ///     The <see cref="ListMemberRecord" /> instance to be mapped.
        /// </param>
        /// <param name="useV6Logic">
        ///     Is the procedure being run an old version 6.x procedure? (the null value handling logic is different).
        /// </param>
        protected override void MapParametersIn(IDbCommand command, ListMemberRecord record, bool useV6Logic)
        {
            this.MapParameterIn(command, "@PA_LM_ID", record.Id);
            this.MapParameterIn(command, "@PA_LM_LOCK", record.Lock);
            this.MapParameterIn(command, "@PA_LM_LIST_ID", record.ListId);
            this.MapParameterIn(command, "@PA_LM_PN_ID", record.PnId);
            this.MapParameterIn(command, "@PA_LM_TITLE", record.Title);
            this.MapParameterIn(command, "@PA_LM_USERCHAR_1", record.Userchar1);
            this.MapParameterIn(command, "@PA_LM_USERCHAR_2", record.Userchar2);
            this.MapParameterIn(command, "@PA_LM_USERCHAR_3", record.Userchar3);
            this.MapParameterIn(command, "@PA_LM_USERCHAR_4", record.Userchar4);
            this.MapParameterIn(command, "@PA_LM_TERMS_READ", record.TermsRead);
            this.MapParameterIn(command, "@PA_LM_TABLE_NAME", record.TableName);
            this.MapParameterIn(command, "@PA_LM_RECORD_ID", record.RecordId);
            this.MapParameterIn(command, "@PA_LM_DISABLE", record.Disable);
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
        ///     The <see cref="ListMemberRecord" /> instance to be updated.
        /// </param>
        protected override void MapParametersOut(IDbCommand command, ListMemberRecord record)
        {
            record.Id = this.MapParameterOut(command, "@PA_LM_ID", record.Id);
            record.Lock = this.MapParameterOut(command, "@PA_LM_LOCK", record.Lock);
            record.ListId = this.MapParameterOut(command, "@PA_LM_LIST_ID", record.ListId);
            record.PnId = this.MapParameterOut(command, "@PA_LM_PN_ID", record.PnId);
            record.Title = this.MapParameterOut(command, "@PA_LM_TITLE", record.Title);
            record.Userchar1 = this.MapParameterOut(command, "@PA_LM_USERCHAR_1", record.Userchar1);
            record.Userchar2 = this.MapParameterOut(command, "@PA_LM_USERCHAR_2", record.Userchar2);
            record.Userchar3 = this.MapParameterOut(command, "@PA_LM_USERCHAR_3", record.Userchar3);
            record.Userchar4 = this.MapParameterOut(command, "@PA_LM_USERCHAR_4", record.Userchar4);
            record.TermsRead = this.MapParameterOut(command, "@PA_LM_TERMS_READ", record.TermsRead);
            record.TableName = this.MapParameterOut(command, "@PA_LM_TABLE_NAME", record.TableName);
            record.RecordId = this.MapParameterOut(command, "@PA_LM_RECORD_ID", record.RecordId);
            record.Disable = this.MapParameterOut(command, "@PA_LM_DISABLE", record.Disable);
            record.Id = this.MapParameterOut(command, "@PA_RETURN_ID", record.Id);
        }

        /// <summary>
        ///     Retrieves a collection of <see cref="ListMemberRecord" /> instances from the data store.
        /// </summary>
        /// <param name="listId">
        ///     The value which identifies the <see cref='MailingListMemberModel' /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The collection of <see cref="ListMemberRecord" /> instances that match the specified <paramref name='listId' />.
        /// </returns>
        public IEnumerable<ListMemberRecord> FetchAllByListId(String listId)
        {
            DbCommand command = this.GetStoredProcedure(SqlServerOperation.FetchAll, "ListId");
            this.MapParameterIn(command, "@PA_LM_LIST_ID", listId);
            return this.Execute(command);
        }

        /// <summary>
        ///     Retrieves a collection of <see cref="ListMemberRecord" /> instances from the data store.
        /// </summary>
        /// <param name="pnId">
        ///     The value which identifies the <see cref='MailingListMemberModel' /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The collection of <see cref="ListMemberRecord" /> instances that match the specified <paramref name='pnId' />.
        /// </returns>
        public IEnumerable<ListMemberRecord> FetchAllByPnId(String pnId)
        {
            DbCommand command = this.GetStoredProcedure(SqlServerOperation.FetchAll, "PnId");
            this.MapParameterIn(command, "@PA_LM_PN_ID", pnId);
            return this.Execute(command);
        }

        #endregion

        #region implementations

        /// <summary>
        ///     Gets the underlying table name that this repository sit over.
        /// </summary>
        System.String IMailingListMemberRepository.TableName
        {
            get { return this.TableName; }
        }

        void IMailingListMemberRepository.Create(Consensus.Marketing.ListMemberRecord record)
        {
            this.Create(record);
        }

        void IMailingListMemberRepository.Modify(Consensus.Marketing.ListMemberRecord record)
        {
            this.Modify(record);
        }

        /// <summary>
        ///     Retrieves a collection of <see cref="T:Consensus.Marketing.ListMemberRecord" /> instances from the data store.
        /// </summary>
        /// <param name="listId">
        ///     The value which identifies the <see cref="!:MailingListMemberModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The collection of <see cref="T:Consensus.Marketing.ListMemberRecord" /> instances that match the specified <paramref name="listId" />.
        /// </returns>
        System.Collections.Generic.IEnumerable<Consensus.Marketing.ListMemberRecord> IMailingListMemberRepository.FetchAllByListId(System.String listId)
        {
            return this.FetchAllByListId(listId);
        }

        /// <summary>
        ///     Retrieves a collection of <see cref="T:Consensus.Marketing.ListMemberRecord" /> instances from the data store.
        /// </summary>
        /// <param name="pnId">
        ///     The value which identifies the <see cref="!:MailingListMemberModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The collection of <see cref="T:Consensus.Marketing.ListMemberRecord" /> instances that match the specified <paramref name="pnId" />.
        /// </returns>
        System.Collections.Generic.IEnumerable<Consensus.Marketing.ListMemberRecord> IMailingListMemberRepository.FetchAllByPnId(System.String pnId)
        {
            return this.FetchAllByPnId(pnId);
        }

        #endregion
    }
}
