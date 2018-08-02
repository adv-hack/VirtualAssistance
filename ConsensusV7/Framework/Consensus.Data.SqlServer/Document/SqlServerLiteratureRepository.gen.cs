using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Linq;

namespace Consensus.Document
{
    /// <summary>
    ///     Provides the persistence and retrieval of the <see cref="LiteratureRecord" /> instances in a Microsoft SQL Server database.
    /// </summary>
    /// <remarks>
    ///     THIS CODE HAS BEEN AUTOMATICALLY GENERATED USING THE CONSENSUS DEVELOPER TOOLS.
    ///     DO NOT EDIT THIS CODE AS ANY CUSTOM MODIFICATIONS WILL BE LOST UPON REGENERATION.
    /// </remarks>
    public partial class SqlServerLiteratureRepository : SqlServerRepository<LiteratureRecord, String>, ILiteratureRepository
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
            get { return "Literature"; }
        }

        /// <summary>
        ///     Gets the name of the parameter which is used to specify the unique value that identifies each instance of a <see cref="LiteratureRecord" />.
        /// </summary>
        protected override String TypeKeyName
        {
            get { return "@PA_LIT_ID"; }
        }

        /// <summary>
        ///     Gets the underlying table name that this repository sit over.
        /// </summary>
        public override String TableName
        {
            get { return "Literature"; }
        }

        #endregion

        #region methods

        /// <summary>
        ///     Maps an <see cref="IDataRecord" /> to the specified <see cref="LiteratureRecord" />.
        /// </summary>
        /// <param name="dataRecord">
        ///     The <see cref="IDataRecord" /> to be mapped.
        /// </param>
        /// <param name="record">
        ///     The <see cref="LiteratureRecord" /> instance to be mapped to.
        /// </param>
        protected override void MapRecord(IDataRecord dataRecord, LiteratureRecord record)
        {
            record.Id = dataRecord["LIT_ID"].ConvertTo<String>();
            record.Lock = dataRecord["LIT_LOCK"].ConvertTo<String>();
            record.AddDate = dataRecord["LIT_ADD_DATE"].ConvertTo<DateTime?>();
            record.AddBy = dataRecord["LIT_ADD_BY"].ConvertTo<String>();
            record.ModDate = dataRecord["LIT_MOD_DATE"].ConvertTo<DateTime?>();
            record.ModBy = dataRecord["LIT_MOD_BY"].ConvertTo<String>();
            record.RcvDate = dataRecord["LIT_RCV_DATE"].ConvertTo<DateTime?>();
            record.RcvFrom = dataRecord["LIT_RCV_FROM"].ConvertTo<String>();
            record.Name = dataRecord["LIT_NAME"].ConvertTo<String>();
            record.Cost = dataRecord["LIT_COST"].ConvertTo<Double?>();
            record.Template = dataRecord["LIT_TEMPLATE"].ConvertTo<String>();
            record.Exam = dataRecord["LIT_EXAM"].ConvertTo<Byte?>();
            record.Attendance = dataRecord["LIT_ATTENDANCE"].ConvertTo<Byte?>();
            record.Type = dataRecord["LIT_TYPE"].ConvertTo<Byte?>();
            record.Current = dataRecord["LIT_CURRENT"].ConvertTo<Byte?>();
            record.LtId = dataRecord["LIT_LT_ID"].ConvertTo<String>();
            record.SendOverride = dataRecord["LIT_SEND_OVERRIDE"].ConvertTo<Byte?>();
            record.EmailOnly = dataRecord["LIT_EMAIL_ONLY"].ConvertTo<Byte>();
            record.PrintOnly = dataRecord["LIT_PRINT_ONLY"].ConvertTo<Byte>();
            record.FileName = dataRecord["LIT_FILE_NAME"].ConvertTo<String>();
        }

        /// <summary>
        ///     Sets the parameter values for the specified <paramref name="command" /> based on the specified <typeparamref name="TRecord" /> instance.
        /// </summary>
        /// <param name="command">
        ///     The <see cref="IDbCommand" /> containing the parameters to be mapped.
        /// </param>
        /// <param name="record">
        ///     The <see cref="LiteratureRecord" /> instance to be mapped.
        /// </param>
        /// <param name="useV6Logic">
        ///     Is the procedure being run an old version 6.x procedure? (the null value handling logic is different).
        /// </param>
        protected override void MapParametersIn(IDbCommand command, LiteratureRecord record, bool useV6Logic)
        {
            this.MapParameterIn(command, "@PA_LIT_ID", record.Id);
            this.MapParameterIn(command, "@PA_LIT_LOCK", record.Lock);
            this.MapParameterIn(command, "@PA_LIT_NAME", record.Name);
            this.MapParameterIn(command, "@PA_LIT_COST", record.Cost == Double.MinValue ? ( useV6Logic ? new Double?(0) : null ) : record.Cost);
            this.MapParameterIn(command, "@PA_LIT_TEMPLATE", record.Template);
            this.MapParameterIn(command, "@PA_LIT_EXAM", record.Exam);
            this.MapParameterIn(command, "@PA_LIT_ATTENDANCE", record.Attendance);
            this.MapParameterIn(command, "@PA_LIT_TYPE", record.Type);
            this.MapParameterIn(command, "@PA_LIT_CURRENT", record.Current);
            this.MapParameterIn(command, "@PA_LIT_LT_ID", record.LtId);
            this.MapParameterIn(command, "@PA_LIT_SEND_OVERRIDE", record.SendOverride);
            this.MapParameterIn(command, "@PA_LIT_EMAIL_ONLY", record.EmailOnly);
            this.MapParameterIn(command, "@PA_LIT_PRINT_ONLY", record.PrintOnly);
            this.MapParameterIn(command, "@PA_LIT_FILE_NAME", record.FileName);
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
        ///     The <see cref="LiteratureRecord" /> instance to be updated.
        /// </param>
        protected override void MapParametersOut(IDbCommand command, LiteratureRecord record)
        {
            record.Id = this.MapParameterOut(command, "@PA_LIT_ID", record.Id);
            record.Lock = this.MapParameterOut(command, "@PA_LIT_LOCK", record.Lock);
            record.Name = this.MapParameterOut(command, "@PA_LIT_NAME", record.Name);
            record.Cost = this.MapParameterOut(command, "@PA_LIT_COST", record.Cost);
            record.Template = this.MapParameterOut(command, "@PA_LIT_TEMPLATE", record.Template);
            record.Exam = this.MapParameterOut(command, "@PA_LIT_EXAM", record.Exam);
            record.Attendance = this.MapParameterOut(command, "@PA_LIT_ATTENDANCE", record.Attendance);
            record.Type = this.MapParameterOut(command, "@PA_LIT_TYPE", record.Type);
            record.Current = this.MapParameterOut(command, "@PA_LIT_CURRENT", record.Current);
            record.LtId = this.MapParameterOut(command, "@PA_LIT_LT_ID", record.LtId);
            record.SendOverride = this.MapParameterOut(command, "@PA_LIT_SEND_OVERRIDE", record.SendOverride);
            record.EmailOnly = this.MapParameterOut(command, "@PA_LIT_EMAIL_ONLY", record.EmailOnly);
            record.PrintOnly = this.MapParameterOut(command, "@PA_LIT_PRINT_ONLY", record.PrintOnly);
            record.FileName = this.MapParameterOut(command, "@PA_LIT_FILE_NAME", record.FileName);
            record.Id = this.MapParameterOut(command, "@PA_RETURN_ID", record.Id);
        }

        /// <summary>
        ///     Retrieves a collection of <see cref="LiteratureRecord" /> instances from the data store.
        /// </summary>
        /// <param name="ltId">
        ///     The value which identifies the <see cref='LiteratureModel' /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The collection of <see cref="LiteratureRecord" /> instances that match the specified <paramref name='ltId' />.
        /// </returns>
        public IEnumerable<LiteratureRecord> FetchAllByLtId(String ltId)
        {
            DbCommand command = this.GetStoredProcedure(SqlServerOperation.FetchAll, "LtId");
            this.MapParameterIn(command, "@PA_LIT_LT_ID", ltId);
            return this.Execute(command);
        }

        #endregion

        #region implementations

        /// <summary>
        ///     Gets the underlying table name that this repository sit over.
        /// </summary>
        System.String ILiteratureRepository.TableName
        {
            get { return this.TableName; }
        }

        /// <summary>
        ///     Retrieves a collection of <see cref="T:Consensus.Document.LiteratureRecord" /> instances from the data store.
        /// </summary>
        /// <param name="ltId">
        ///     The value which identifies the <see cref="!:LiteratureModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The collection of <see cref="T:Consensus.Document.LiteratureRecord" /> instances that match the specified <paramref name="ltId" />.
        /// </returns>
        System.Collections.Generic.IEnumerable<Consensus.Document.LiteratureRecord> ILiteratureRepository.FetchAllByLtId(System.String ltId)
        {
            return this.FetchAllByLtId(ltId);
        }

        #endregion
    }
}
