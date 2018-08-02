using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Linq;

namespace Consensus.Marketing
{
    /// <summary>
    ///     Provides the persistence and retrieval of the <see cref="ListRecord" /> instances in a Microsoft SQL Server database.
    /// </summary>
    /// <remarks>
    ///     THIS CODE HAS BEEN AUTOMATICALLY GENERATED USING THE CONSENSUS DEVELOPER TOOLS.
    ///     DO NOT EDIT THIS CODE AS ANY CUSTOM MODIFICATIONS WILL BE LOST UPON REGENERATION.
    /// </remarks>
    public partial class SqlServerMailingListRepository : SqlServerRepository<ListRecord, String>, IMailingListRepository
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
            get { return "List"; }
        }

        /// <summary>
        ///     Gets the name of the parameter which is used to specify the unique value that identifies each instance of a <see cref="ListRecord" />.
        /// </summary>
        protected override String TypeKeyName
        {
            get { return "@PA_LIST_ID"; }
        }

        /// <summary>
        ///     Gets the underlying table name that this repository sit over.
        /// </summary>
        public override String TableName
        {
            get { return "List"; }
        }

        #endregion

        #region methods

        /// <summary>
        ///     Maps an <see cref="IDataRecord" /> to the specified <see cref="ListRecord" />.
        /// </summary>
        /// <param name="dataRecord">
        ///     The <see cref="IDataRecord" /> to be mapped.
        /// </param>
        /// <param name="record">
        ///     The <see cref="ListRecord" /> instance to be mapped to.
        /// </param>
        protected override void MapRecord(IDataRecord dataRecord, ListRecord record)
        {
            record.Id = dataRecord["LIST_ID"].ConvertTo<String>();
            record.Lock = dataRecord["LIST_LOCK"].ConvertTo<String>();
            record.AddDate = dataRecord["LIST_ADD_DATE"].ConvertTo<DateTime?>();
            record.AddBy = dataRecord["LIST_ADD_BY"].ConvertTo<String>();
            record.ModDate = dataRecord["LIST_MOD_DATE"].ConvertTo<DateTime?>();
            record.ModBy = dataRecord["LIST_MOD_BY"].ConvertTo<String>();
            record.RcvDate = dataRecord["LIST_RCV_DATE"].ConvertTo<DateTime?>();
            record.RcvFrom = dataRecord["LIST_RCV_FROM"].ConvertTo<String>();
            record.Title = dataRecord["LIST_TITLE"].ConvertTo<String>();
            record.SupplierId = dataRecord["LIST_SUPPLIER_ID"].ConvertTo<String>();
            record.ProleId = dataRecord["LIST_PROLE_ID"].ConvertTo<String>();
            record.Date = dataRecord["LIST_DATE"].ConvertTo<DateTime?>();
            record.UserId = dataRecord["LIST_USER_ID"].ConvertTo<String>();
            record.Entries = dataRecord["LIST_ENTRIES"].ConvertTo<Double?>();
            record.Duplicates = dataRecord["LIST_DUPLICATES"].ConvertTo<Double?>();
            record.NewOrg = dataRecord["LIST_NEW_ORG"].ConvertTo<Double?>();
            record.NewPerson = dataRecord["LIST_NEW_PERSON"].ConvertTo<Double?>();
            record.Price = dataRecord["LIST_PRICE"].ConvertTo<Double?>();
            record.Status = dataRecord["LIST_STATUS"].ConvertTo<String>();
            record.Notes = dataRecord["LIST_NOTES"].ConvertTo<String>();
            record.NewAddresses = dataRecord["LIST_NEW_ADDRESSES"].ConvertTo<Double?>();
            record.Limit = dataRecord["LIST_LIMIT"].ConvertTo<Double?>();
            record.Until = dataRecord["LIST_UNTIL"].ConvertTo<DateTime?>();
            record.Userchar1 = dataRecord["LIST_USERCHAR_1"].ConvertTo<String>();
            record.Userchar2 = dataRecord["LIST_USERCHAR_2"].ConvertTo<String>();
            record.Userchar3 = dataRecord["LIST_USERCHAR_3"].ConvertTo<String>();
            record.Userchar4 = dataRecord["LIST_USERCHAR_4"].ConvertTo<String>();
            record.Userchar5 = dataRecord["LIST_USERCHAR_5"].ConvertTo<String>();
            record.Userchar6 = dataRecord["LIST_USERCHAR_6"].ConvertTo<String>();
            record.CourseId = dataRecord["LIST_COURSE_ID"].ConvertTo<String>();
            record.Process = dataRecord["LIST_PROCESS"].ConvertTo<String>();
            record.Country = dataRecord["LIST_COUNTRY"].ConvertTo<String>();
            record.ImpStatus = dataRecord["LIST_IMP_STATUS"].ConvertTo<Byte?>();
            record.JobLu = dataRecord["LIST_JOB_LU"].ConvertTo<Byte?>();
            record.Lines = dataRecord["LIST_LINES"].ConvertTo<Int32?>();
            record.CountryLu = dataRecord["LIST_COUNTRY_LU"].ConvertTo<Byte?>();
            record.Incomplete = dataRecord["LIST_INCOMPLETE"].ConvertTo<Int32?>();
            record.InvalidInd = dataRecord["LIST_INVALID_IND"].ConvertTo<Int32?>();
            record.InvalidCo = dataRecord["LIST_INVALID_CO"].ConvertTo<Int32?>();
            record.Delimit = dataRecord["LIST_DELIMIT"].ConvertTo<Byte?>();
            record.Header = dataRecord["LIST_HEADER"].ConvertTo<Byte?>();
            record.EttId = dataRecord["LIST_ETT_ID"].ConvertTo<String>();
            record.WebEnabled = dataRecord["LIST_WEB_ENABLED"].ConvertTo<Byte>();
            record.NotesHtml = dataRecord["LIST_NOTES_HTML"].ConvertTo<String>();
            record.IsDynamic = dataRecord["LIST_IS_DYNAMIC"].ConvertTo<Boolean>();
        }

        /// <summary>
        ///     Sets the parameter values for the specified <paramref name="command" /> based on the specified <typeparamref name="TRecord" /> instance.
        /// </summary>
        /// <param name="command">
        ///     The <see cref="IDbCommand" /> containing the parameters to be mapped.
        /// </param>
        /// <param name="record">
        ///     The <see cref="ListRecord" /> instance to be mapped.
        /// </param>
        /// <param name="useV6Logic">
        ///     Is the procedure being run an old version 6.x procedure? (the null value handling logic is different).
        /// </param>
        protected override void MapParametersIn(IDbCommand command, ListRecord record, bool useV6Logic)
        {
            this.MapParameterIn(command, "@PA_LIST_ID", record.Id);
            this.MapParameterIn(command, "@PA_LIST_LOCK", record.Lock);
            this.MapParameterIn(command, "@PA_LIST_TITLE", record.Title);
            this.MapParameterIn(command, "@PA_LIST_SUPPLIER_ID", record.SupplierId);
            this.MapParameterIn(command, "@PA_LIST_PROLE_ID", record.ProleId);
            this.MapParameterIn(command, "@PA_LIST_DATE", record.Date == DateTime.MinValue ? ( useV6Logic ? new DateTime?(new DateTime(1900,1,1)) : null ) : record.Date);
            this.MapParameterIn(command, "@PA_LIST_USER_ID", record.UserId);
            this.MapParameterIn(command, "@PA_LIST_ENTRIES", record.Entries == Double.MinValue ? ( useV6Logic ? new Double?(0) : null ) : record.Entries);
            this.MapParameterIn(command, "@PA_LIST_DUPLICATES", record.Duplicates == Double.MinValue ? ( useV6Logic ? new Double?(0) : null ) : record.Duplicates);
            this.MapParameterIn(command, "@PA_LIST_NEW_ORG", record.NewOrg == Double.MinValue ? ( useV6Logic ? new Double?(0) : null ) : record.NewOrg);
            this.MapParameterIn(command, "@PA_LIST_NEW_PERSON", record.NewPerson == Double.MinValue ? ( useV6Logic ? new Double?(0) : null ) : record.NewPerson);
            this.MapParameterIn(command, "@PA_LIST_PRICE", record.Price == Double.MinValue ? ( useV6Logic ? new Double?(0) : null ) : record.Price);
            this.MapParameterIn(command, "@PA_LIST_STATUS", record.Status);
            this.MapParameterIn(command, "@PA_LIST_NOTES", record.Notes);
            this.MapParameterIn(command, "@PA_LIST_NEW_ADDRESSES", record.NewAddresses == Double.MinValue ? ( useV6Logic ? new Double?(0) : null ) : record.NewAddresses);
            this.MapParameterIn(command, "@PA_LIST_LIMIT", record.Limit == Double.MinValue ? ( useV6Logic ? new Double?(0) : null ) : record.Limit);
            this.MapParameterIn(command, "@PA_LIST_UNTIL", record.Until == DateTime.MinValue ? ( useV6Logic ? new DateTime?(new DateTime(1900,1,1)) : null ) : record.Until);
            this.MapParameterIn(command, "@PA_LIST_USERCHAR_1", record.Userchar1);
            this.MapParameterIn(command, "@PA_LIST_USERCHAR_2", record.Userchar2);
            this.MapParameterIn(command, "@PA_LIST_USERCHAR_3", record.Userchar3);
            this.MapParameterIn(command, "@PA_LIST_USERCHAR_4", record.Userchar4);
            this.MapParameterIn(command, "@PA_LIST_USERCHAR_5", record.Userchar5);
            this.MapParameterIn(command, "@PA_LIST_USERCHAR_6", record.Userchar6);
            this.MapParameterIn(command, "@PA_LIST_COURSE_ID", record.CourseId);
            this.MapParameterIn(command, "@PA_LIST_PROCESS", record.Process);
            this.MapParameterIn(command, "@PA_LIST_COUNTRY", record.Country);
            this.MapParameterIn(command, "@PA_LIST_IMP_STATUS", record.ImpStatus);
            this.MapParameterIn(command, "@PA_LIST_JOB_LU", record.JobLu);
            this.MapParameterIn(command, "@PA_LIST_LINES", record.Lines == Int32.MinValue ? ( useV6Logic ? new Int32?(0) : null ) : record.Lines);
            this.MapParameterIn(command, "@PA_LIST_COUNTRY_LU", record.CountryLu);
            this.MapParameterIn(command, "@PA_LIST_INCOMPLETE", record.Incomplete == Int32.MinValue ? ( useV6Logic ? new Int32?(0) : null ) : record.Incomplete);
            this.MapParameterIn(command, "@PA_LIST_INVALID_IND", record.InvalidInd == Int32.MinValue ? ( useV6Logic ? new Int32?(0) : null ) : record.InvalidInd);
            this.MapParameterIn(command, "@PA_LIST_INVALID_CO", record.InvalidCo == Int32.MinValue ? ( useV6Logic ? new Int32?(0) : null ) : record.InvalidCo);
            this.MapParameterIn(command, "@PA_LIST_DELIMIT", record.Delimit);
            this.MapParameterIn(command, "@PA_LIST_HEADER", record.Header);
            this.MapParameterIn(command, "@PA_LIST_ETT_ID", record.EttId);
            this.MapParameterIn(command, "@PA_LIST_WEB_ENABLED", record.WebEnabled);
            this.MapParameterIn(command, "@PA_LIST_NOTES_HTML", record.NotesHtml);
            this.MapParameterIn(command, "@PA_LIST_IS_DYNAMIC", record.IsDynamic);
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
        ///     The <see cref="ListRecord" /> instance to be updated.
        /// </param>
        protected override void MapParametersOut(IDbCommand command, ListRecord record)
        {
            record.Id = this.MapParameterOut(command, "@PA_LIST_ID", record.Id);
            record.Lock = this.MapParameterOut(command, "@PA_LIST_LOCK", record.Lock);
            record.Title = this.MapParameterOut(command, "@PA_LIST_TITLE", record.Title);
            record.SupplierId = this.MapParameterOut(command, "@PA_LIST_SUPPLIER_ID", record.SupplierId);
            record.ProleId = this.MapParameterOut(command, "@PA_LIST_PROLE_ID", record.ProleId);
            record.Date = this.MapParameterOut(command, "@PA_LIST_DATE", record.Date);
            record.UserId = this.MapParameterOut(command, "@PA_LIST_USER_ID", record.UserId);
            record.Entries = this.MapParameterOut(command, "@PA_LIST_ENTRIES", record.Entries);
            record.Duplicates = this.MapParameterOut(command, "@PA_LIST_DUPLICATES", record.Duplicates);
            record.NewOrg = this.MapParameterOut(command, "@PA_LIST_NEW_ORG", record.NewOrg);
            record.NewPerson = this.MapParameterOut(command, "@PA_LIST_NEW_PERSON", record.NewPerson);
            record.Price = this.MapParameterOut(command, "@PA_LIST_PRICE", record.Price);
            record.Status = this.MapParameterOut(command, "@PA_LIST_STATUS", record.Status);
            record.Notes = this.MapParameterOut(command, "@PA_LIST_NOTES", record.Notes);
            record.NewAddresses = this.MapParameterOut(command, "@PA_LIST_NEW_ADDRESSES", record.NewAddresses);
            record.Limit = this.MapParameterOut(command, "@PA_LIST_LIMIT", record.Limit);
            record.Until = this.MapParameterOut(command, "@PA_LIST_UNTIL", record.Until);
            record.Userchar1 = this.MapParameterOut(command, "@PA_LIST_USERCHAR_1", record.Userchar1);
            record.Userchar2 = this.MapParameterOut(command, "@PA_LIST_USERCHAR_2", record.Userchar2);
            record.Userchar3 = this.MapParameterOut(command, "@PA_LIST_USERCHAR_3", record.Userchar3);
            record.Userchar4 = this.MapParameterOut(command, "@PA_LIST_USERCHAR_4", record.Userchar4);
            record.Userchar5 = this.MapParameterOut(command, "@PA_LIST_USERCHAR_5", record.Userchar5);
            record.Userchar6 = this.MapParameterOut(command, "@PA_LIST_USERCHAR_6", record.Userchar6);
            record.CourseId = this.MapParameterOut(command, "@PA_LIST_COURSE_ID", record.CourseId);
            record.Process = this.MapParameterOut(command, "@PA_LIST_PROCESS", record.Process);
            record.Country = this.MapParameterOut(command, "@PA_LIST_COUNTRY", record.Country);
            record.ImpStatus = this.MapParameterOut(command, "@PA_LIST_IMP_STATUS", record.ImpStatus);
            record.JobLu = this.MapParameterOut(command, "@PA_LIST_JOB_LU", record.JobLu);
            record.Lines = this.MapParameterOut(command, "@PA_LIST_LINES", record.Lines);
            record.CountryLu = this.MapParameterOut(command, "@PA_LIST_COUNTRY_LU", record.CountryLu);
            record.Incomplete = this.MapParameterOut(command, "@PA_LIST_INCOMPLETE", record.Incomplete);
            record.InvalidInd = this.MapParameterOut(command, "@PA_LIST_INVALID_IND", record.InvalidInd);
            record.InvalidCo = this.MapParameterOut(command, "@PA_LIST_INVALID_CO", record.InvalidCo);
            record.Delimit = this.MapParameterOut(command, "@PA_LIST_DELIMIT", record.Delimit);
            record.Header = this.MapParameterOut(command, "@PA_LIST_HEADER", record.Header);
            record.EttId = this.MapParameterOut(command, "@PA_LIST_ETT_ID", record.EttId);
            record.WebEnabled = this.MapParameterOut(command, "@PA_LIST_WEB_ENABLED", record.WebEnabled);
            record.NotesHtml = this.MapParameterOut(command, "@PA_LIST_NOTES_HTML", record.NotesHtml);
            record.IsDynamic = this.MapParameterOut(command, "@PA_LIST_IS_DYNAMIC", record.IsDynamic);
            record.Id = this.MapParameterOut(command, "@PA_RETURN_ID", record.Id);
        }

        /// <summary>
        ///     Retrieves a collection of <see cref="ListRecord" /> instances from the data store.
        /// </summary>
        /// <param name="userId">
        ///     The value which identifies the <see cref='MailingListModel' /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The collection of <see cref="ListRecord" /> instances that match the specified <paramref name='userId' />.
        /// </returns>
        public IEnumerable<ListRecord> FetchAllByUserId(String userId)
        {
            DbCommand command = this.GetStoredProcedure(SqlServerOperation.FetchAll, "UserId");
            this.MapParameterIn(command, "@PA_LIST_USER_ID", userId);
            return this.Execute(command);
        }

        /// <summary>
        ///     Retrieves a collection of <see cref="ListRecord" /> instances from the data store.
        /// </summary>
        /// <param name="notesHtml">
        ///     The value which identifies the <see cref='MailingListModel' /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The collection of <see cref="ListRecord" /> instances that match the specified <paramref name='notesHtml' />.
        /// </returns>
        public IEnumerable<ListRecord> FetchAllByNotesHtml(String notesHtml)
        {
            DbCommand command = this.GetStoredProcedure(SqlServerOperation.FetchAll, "NotesHtml");
            this.MapParameterIn(command, "@PA_LIST_NOTES_HTML", notesHtml);
            return this.Execute(command);
        }

        #endregion

        #region implementations

        /// <summary>
        ///     Gets the underlying table name that this repository sit over.
        /// </summary>
        System.String IMailingListRepository.TableName
        {
            get { return this.TableName; }
        }

        void IMailingListRepository.Create(Consensus.Marketing.ListRecord record)
        {
            this.Create(record);
        }

        void IMailingListRepository.Modify(Consensus.Marketing.ListRecord record)
        {
            this.Modify(record);
        }

        /// <summary>
        ///     Retrieves a collection of <see cref="T:Consensus.Marketing.ListRecord" /> instances from the data store.
        /// </summary>
        /// <param name="userId">
        ///     The value which identifies the <see cref="!:MailingListModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The collection of <see cref="T:Consensus.Marketing.ListRecord" /> instances that match the specified <paramref name="userId" />.
        /// </returns>
        System.Collections.Generic.IEnumerable<Consensus.Marketing.ListRecord> IMailingListRepository.FetchAllByUserId(System.String userId)
        {
            return this.FetchAllByUserId(userId);
        }

        /// <summary>
        ///     Retrieves a collection of <see cref="T:Consensus.Marketing.ListRecord" /> instances from the data store.
        /// </summary>
        /// <param name="notesHtml">
        ///     The value which identifies the <see cref="!:MailingListModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The collection of <see cref="T:Consensus.Marketing.ListRecord" /> instances that match the specified <paramref name="notesHtml" />.
        /// </returns>
        System.Collections.Generic.IEnumerable<Consensus.Marketing.ListRecord> IMailingListRepository.FetchAllByNotesHtml(System.String notesHtml)
        {
            return this.FetchAllByNotesHtml(notesHtml);
        }

        #endregion
    }
}
