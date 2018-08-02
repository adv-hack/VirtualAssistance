using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Linq;

namespace Consensus.Sales
{
    /// <summary>
    ///     Provides the persistence and retrieval of the <see cref="SalesChannelRecord" /> instances in a Microsoft SQL Server database.
    /// </summary>
    /// <remarks>
    ///     THIS CODE HAS BEEN AUTOMATICALLY GENERATED USING THE CONSENSUS DEVELOPER TOOLS.
    ///     DO NOT EDIT THIS CODE AS ANY CUSTOM MODIFICATIONS WILL BE LOST UPON REGENERATION.
    /// </remarks>
    public partial class SqlServerSalesChannelRepository : SqlServerRepository<SalesChannelRecord, String>, ISalesChannelRepository
    {
        #region properties

        /// <summary>
        ///     Gets the namespace in which the data type is contained.
        /// </summary>
        protected override String TypeNamespace
        {
            get { return "Sales"; }
        }

        /// <summary>
        ///     Gets the name of the data type which is persisted by this repository.
        /// </summary>
        protected override String TypeName
        {
            get { return "SalesChannel"; }
        }

        /// <summary>
        ///     Gets the name of the parameter which is used to specify the unique value that identifies each instance of a <see cref="SalesChannelRecord" />.
        /// </summary>
        protected override String TypeKeyName
        {
            get { return "@PA_SCHN_ID"; }
        }

        /// <summary>
        ///     Gets the underlying table name that this repository sit over.
        /// </summary>
        public override String TableName
        {
            get { return "Sales_Channel"; }
        }

        #endregion

        #region methods

        /// <summary>
        ///     Maps an <see cref="IDataRecord" /> to the specified <see cref="SalesChannelRecord" />.
        /// </summary>
        /// <param name="dataRecord">
        ///     The <see cref="IDataRecord" /> to be mapped.
        /// </param>
        /// <param name="record">
        ///     The <see cref="SalesChannelRecord" /> instance to be mapped to.
        /// </param>
        protected override void MapRecord(IDataRecord dataRecord, SalesChannelRecord record)
        {
            record.Id = dataRecord["SCHN_ID"].ConvertTo<String>();
            record.Lock = dataRecord["SCHN_LOCK"].ConvertTo<String>();
            record.AddDate = dataRecord["SCHN_ADD_DATE"].ConvertTo<DateTime?>();
            record.AddBy = dataRecord["SCHN_ADD_BY"].ConvertTo<String>();
            record.ModDate = dataRecord["SCHN_MOD_DATE"].ConvertTo<DateTime?>();
            record.ModBy = dataRecord["SCHN_MOD_BY"].ConvertTo<String>();
            record.RcvDate = dataRecord["SCHN_RCV_DATE"].ConvertTo<DateTime?>();
            record.RcvFrom = dataRecord["SCHN_RCV_FROM"].ConvertTo<String>();
            record.Number = dataRecord["SCHN_NUMBER"].ConvertTo<Byte?>();
            record.Name = dataRecord["SCHN_NAME"].ConvertTo<String>();
            record.Ref = dataRecord["SCHN_REF"].ConvertTo<String>();
            record.PlId = dataRecord["SCHN_PL_ID"].ConvertTo<String>();
            record.State = dataRecord["SCHN_STATE"].ConvertTo<Byte?>();
            record.CutoffTime = dataRecord["SCHN_CUTOFF_TIME"].ConvertTo<DateTime?>();
            record.Timeout = dataRecord["SCHN_TIMEOUT"].ConvertTo<Int32?>();
            record.NoBook = dataRecord["SCHN_NO_BOOK"].ConvertTo<Byte?>();
        }

        /// <summary>
        ///     Sets the parameter values for the specified <paramref name="command" /> based on the specified <typeparamref name="TRecord" /> instance.
        /// </summary>
        /// <param name="command">
        ///     The <see cref="IDbCommand" /> containing the parameters to be mapped.
        /// </param>
        /// <param name="record">
        ///     The <see cref="SalesChannelRecord" /> instance to be mapped.
        /// </param>
        /// <param name="useV6Logic">
        ///     Is the procedure being run an old version 6.x procedure? (the null value handling logic is different).
        /// </param>
        protected override void MapParametersIn(IDbCommand command, SalesChannelRecord record, bool useV6Logic)
        {
            this.MapParameterIn(command, "@PA_SCHN_ID", record.Id);
            this.MapParameterIn(command, "@PA_SCHN_LOCK", record.Lock);
            this.MapParameterIn(command, "@PA_SCHN_NUMBER", record.Number);
            this.MapParameterIn(command, "@PA_SCHN_NAME", record.Name);
            this.MapParameterIn(command, "@PA_SCHN_REF", record.Ref);
            this.MapParameterIn(command, "@PA_SCHN_PL_ID", record.PlId);
            this.MapParameterIn(command, "@PA_SCHN_STATE", record.State);
            this.MapParameterIn(command, "@PA_SCHN_CUTOFF_TIME", record.CutoffTime == DateTime.MinValue ? ( useV6Logic ? new DateTime?(new DateTime(1900,1,1)) : null ) : record.CutoffTime);
            this.MapParameterIn(command, "@PA_SCHN_TIMEOUT", record.Timeout == Int32.MinValue ? ( useV6Logic ? new Int32?(0) : null ) : record.Timeout);
            this.MapParameterIn(command, "@PA_SCHN_NO_BOOK", record.NoBook);
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
        ///     The <see cref="SalesChannelRecord" /> instance to be updated.
        /// </param>
        protected override void MapParametersOut(IDbCommand command, SalesChannelRecord record)
        {
            record.Id = this.MapParameterOut(command, "@PA_SCHN_ID", record.Id);
            record.Lock = this.MapParameterOut(command, "@PA_SCHN_LOCK", record.Lock);
            record.Number = this.MapParameterOut(command, "@PA_SCHN_NUMBER", record.Number);
            record.Name = this.MapParameterOut(command, "@PA_SCHN_NAME", record.Name);
            record.Ref = this.MapParameterOut(command, "@PA_SCHN_REF", record.Ref);
            record.PlId = this.MapParameterOut(command, "@PA_SCHN_PL_ID", record.PlId);
            record.State = this.MapParameterOut(command, "@PA_SCHN_STATE", record.State);
            record.CutoffTime = this.MapParameterOut(command, "@PA_SCHN_CUTOFF_TIME", record.CutoffTime);
            record.Timeout = this.MapParameterOut(command, "@PA_SCHN_TIMEOUT", record.Timeout);
            record.NoBook = this.MapParameterOut(command, "@PA_SCHN_NO_BOOK", record.NoBook);
            record.Id = this.MapParameterOut(command, "@PA_RETURN_ID", record.Id);
        }

        #endregion

        #region implementations

        /// <summary>
        ///     Gets the underlying table name that this repository sit over.
        /// </summary>
        System.String ISalesChannelRepository.TableName
        {
            get { return this.TableName; }
        }

        #endregion
    }
}
