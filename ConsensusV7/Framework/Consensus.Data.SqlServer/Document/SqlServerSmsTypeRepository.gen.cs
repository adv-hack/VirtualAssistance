using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Linq;

namespace Consensus.Document
{
    /// <summary>
    ///     Provides the persistence and retrieval of the <see cref="SmsTypeRecord" /> instances in a Microsoft SQL Server database.
    /// </summary>
    /// <remarks>
    ///     THIS CODE HAS BEEN AUTOMATICALLY GENERATED USING THE CONSENSUS DEVELOPER TOOLS.
    ///     DO NOT EDIT THIS CODE AS ANY CUSTOM MODIFICATIONS WILL BE LOST UPON REGENERATION.
    /// </remarks>
    public partial class SqlServerSmsTypeRepository : SqlServerRepository<SmsTypeRecord, Int32>, ISmsTypeRepository
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
            get { return "SmsType"; }
        }

        /// <summary>
        ///     Gets the name of the parameter which is used to specify the unique value that identifies each instance of a <see cref="SmsTypeRecord" />.
        /// </summary>
        protected override String TypeKeyName
        {
            get { return "@PA_SMT_ID"; }
        }

        /// <summary>
        ///     Gets the underlying table name that this repository sit over.
        /// </summary>
        public override String TableName
        {
            get { return "SMS_Type"; }
        }

        #endregion

        #region methods

        /// <summary>
        ///     Maps an <see cref="IDataRecord" /> to the specified <see cref="SmsTypeRecord" />.
        /// </summary>
        /// <param name="dataRecord">
        ///     The <see cref="IDataRecord" /> to be mapped.
        /// </param>
        /// <param name="record">
        ///     The <see cref="SmsTypeRecord" /> instance to be mapped to.
        /// </param>
        protected override void MapRecord(IDataRecord dataRecord, SmsTypeRecord record)
        {
            record.Id = dataRecord["SMT_ID"].ConvertTo<Int32>();
            record.AddDate = dataRecord["SMT_ADD_DATE"].ConvertTo<DateTime>();
            record.AddBy = dataRecord["SMT_ADD_BY"].ConvertTo<String>();
            record.ModDate = dataRecord["SMT_MOD_DATE"].ConvertTo<DateTime>();
            record.ModBy = dataRecord["SMT_MOD_BY"].ConvertTo<String>();
            record.Name = dataRecord["SMT_NAME"].ConvertTo<String>();
            record.View = dataRecord["SMT_VIEW"].ConvertTo<String>();
            record.StoredProc = dataRecord["SMT_STORED_PROC"].ConvertTo<String>();
        }

        /// <summary>
        ///     Sets the parameter values for the specified <paramref name="command" /> based on the specified <typeparamref name="TRecord" /> instance.
        /// </summary>
        /// <param name="command">
        ///     The <see cref="IDbCommand" /> containing the parameters to be mapped.
        /// </param>
        /// <param name="record">
        ///     The <see cref="SmsTypeRecord" /> instance to be mapped.
        /// </param>
        /// <param name="useV6Logic">
        ///     Is the procedure being run an old version 6.x procedure? (the null value handling logic is different).
        /// </param>
        protected override void MapParametersIn(IDbCommand command, SmsTypeRecord record, bool useV6Logic)
        {
            this.MapParameterIn(command, "@PA_SMT_ID", record.Id == Int32.MinValue ? ( useV6Logic ? new Int32?(0) : null ) : record.Id);
            this.MapParameterIn(command, "@PA_SMT_NAME", record.Name);
            this.MapParameterIn(command, "@PA_SMT_VIEW", record.View);
            this.MapParameterIn(command, "@PA_SMT_STORED_PROC", record.StoredProc);
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
        ///     The <see cref="SmsTypeRecord" /> instance to be updated.
        /// </param>
        protected override void MapParametersOut(IDbCommand command, SmsTypeRecord record)
        {
            record.Id = this.MapParameterOut(command, "@PA_SMT_ID", record.Id);
            record.Name = this.MapParameterOut(command, "@PA_SMT_NAME", record.Name);
            record.View = this.MapParameterOut(command, "@PA_SMT_VIEW", record.View);
            record.StoredProc = this.MapParameterOut(command, "@PA_SMT_STORED_PROC", record.StoredProc);
            record.Id = this.MapParameterOut(command, "@PA_RETURN_ID", record.Id);
        }

        #endregion

        #region implementations

        /// <summary>
        ///     Gets the underlying table name that this repository sit over.
        /// </summary>
        System.String ISmsTypeRepository.TableName
        {
            get { return this.TableName; }
        }

        #endregion
    }
}
