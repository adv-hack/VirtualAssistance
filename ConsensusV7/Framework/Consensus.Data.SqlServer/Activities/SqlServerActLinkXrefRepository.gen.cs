using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Linq;

namespace Consensus.Activities
{
    /// <summary>
    ///     Provides the persistence and retrieval of the <see cref="ActLinkXrefRecord" /> instances in a Microsoft SQL Server database.
    /// </summary>
    /// <remarks>
    ///     THIS CODE HAS BEEN AUTOMATICALLY GENERATED USING THE CONSENSUS DEVELOPER TOOLS.
    ///     DO NOT EDIT THIS CODE AS ANY CUSTOM MODIFICATIONS WILL BE LOST UPON REGENERATION.
    /// </remarks>
    public partial class SqlServerActLinkXrefRepository : SqlServerRepository<ActLinkXrefRecord, String>, IActLinkXrefRepository
    {
        #region properties

        /// <summary>
        ///     Gets the namespace in which the data type is contained.
        /// </summary>
        protected override String TypeNamespace
        {
            get { return "Activities"; }
        }

        /// <summary>
        ///     Gets the name of the data type which is persisted by this repository.
        /// </summary>
        protected override String TypeName
        {
            get { return "ActLinkXref"; }
        }

        /// <summary>
        ///     Gets the name of the parameter which is used to specify the unique value that identifies each instance of a <see cref="ActLinkXrefRecord" />.
        /// </summary>
        protected override String TypeKeyName
        {
            get { return "@PA_ACTLINK_ID"; }
        }

        /// <summary>
        ///     Gets the underlying table name that this repository sit over.
        /// </summary>
        public override String TableName
        {
            get { return "ACT_LINK_XREF"; }
        }

        #endregion

        #region methods

        /// <summary>
        ///     Maps an <see cref="IDataRecord" /> to the specified <see cref="ActLinkXrefRecord" />.
        /// </summary>
        /// <param name="dataRecord">
        ///     The <see cref="IDataRecord" /> to be mapped.
        /// </param>
        /// <param name="record">
        ///     The <see cref="ActLinkXrefRecord" /> instance to be mapped to.
        /// </param>
        protected override void MapRecord(IDataRecord dataRecord, ActLinkXrefRecord record)
        {
            record.Id = dataRecord["ACTLINK_ID"].ConvertTo<String>();
            record.AddDate = dataRecord["ACTLINK_ADD_DATE"].ConvertTo<DateTime?>();
            record.AddBy = dataRecord["ACTLINK_ADD_BY"].ConvertTo<String>();
            record.ModDate = dataRecord["ACTLINK_MOD_DATE"].ConvertTo<DateTime?>();
            record.ModBy = dataRecord["ACTLINK_MOD_BY"].ConvertTo<String>();
            record.RcvDate = dataRecord["ACTLINK_RCV_DATE"].ConvertTo<DateTime?>();
            record.RcvFrom = dataRecord["ACTLINK_RCV_FROM"].ConvertTo<String>();
            record.ActId = dataRecord["ACTLINK_ACT_ID"].ConvertTo<String>();
            record.TableNum = dataRecord["ACTLINK_TABLE_NUM"].ConvertTo<Double?>();
            record.RecId = dataRecord["ACTLINK_REC_ID"].ConvertTo<String>();
            record.BomId = dataRecord["ACTLINK_BOM_ID"].ConvertTo<String>();
            record.Text = dataRecord["ACTLINK_TEXT"].ConvertTo<String>();
        }

        /// <summary>
        ///     Sets the parameter values for the specified <paramref name="command" /> based on the specified <typeparamref name="TRecord" /> instance.
        /// </summary>
        /// <param name="command">
        ///     The <see cref="IDbCommand" /> containing the parameters to be mapped.
        /// </param>
        /// <param name="record">
        ///     The <see cref="ActLinkXrefRecord" /> instance to be mapped.
        /// </param>
        /// <param name="useV6Logic">
        ///     Is the procedure being run an old version 6.x procedure? (the null value handling logic is different).
        /// </param>
        protected override void MapParametersIn(IDbCommand command, ActLinkXrefRecord record, bool useV6Logic)
        {
            this.MapParameterIn(command, "@PA_ACTLINK_ID", record.Id);
            this.MapParameterIn(command, "@PA_ACTLINK_ACT_ID", record.ActId);
            this.MapParameterIn(command, "@PA_ACTLINK_TABLE_NUM", record.TableNum == Double.MinValue ? ( useV6Logic ? new Double?(0) : null ) : record.TableNum);
            this.MapParameterIn(command, "@PA_ACTLINK_REC_ID", record.RecId);
            this.MapParameterIn(command, "@PA_ACTLINK_BOM_ID", record.BomId);
            this.MapParameterIn(command, "@PA_ACTLINK_TEXT", record.Text);
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
        ///     The <see cref="ActLinkXrefRecord" /> instance to be updated.
        /// </param>
        protected override void MapParametersOut(IDbCommand command, ActLinkXrefRecord record)
        {
            record.Id = this.MapParameterOut(command, "@PA_ACTLINK_ID", record.Id);
            record.ActId = this.MapParameterOut(command, "@PA_ACTLINK_ACT_ID", record.ActId);
            record.TableNum = this.MapParameterOut(command, "@PA_ACTLINK_TABLE_NUM", record.TableNum);
            record.RecId = this.MapParameterOut(command, "@PA_ACTLINK_REC_ID", record.RecId);
            record.BomId = this.MapParameterOut(command, "@PA_ACTLINK_BOM_ID", record.BomId);
            record.Text = this.MapParameterOut(command, "@PA_ACTLINK_TEXT", record.Text);
            record.Id = this.MapParameterOut(command, "@PA_RETURN_ID", record.Id);
        }

        /// <summary>
        ///     Retrieves a collection of <see cref="ActLinkXrefRecord" /> instances from the data store.
        /// </summary>
        /// <param name="actId">
        ///     The value which identifies the <see cref='ActLinkXrefModel' /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The collection of <see cref="ActLinkXrefRecord" /> instances that match the specified <paramref name='actId' />.
        /// </returns>
        public IEnumerable<ActLinkXrefRecord> FetchAllByActId(String actId)
        {
            DbCommand command = this.GetStoredProcedure(SqlServerOperation.FetchAll, "ActId");
            this.MapParameterIn(command, "@PA_ACTLINK_ACT_ID", actId);
            return this.Execute(command);
        }

        #endregion

        #region implementations

        /// <summary>
        ///     Gets the underlying table name that this repository sit over.
        /// </summary>
        System.String IActLinkXrefRepository.TableName
        {
            get { return this.TableName; }
        }

        /// <summary>
        ///     Retrieves a collection of <see cref="T:Consensus.Activities.ActLinkXrefRecord" /> instances from the data store.
        /// </summary>
        /// <param name="actId">
        ///     The value which identifies the <see cref="!:ActLinkXrefModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The collection of <see cref="T:Consensus.Activities.ActLinkXrefRecord" /> instances that match the specified <paramref name="actId" />.
        /// </returns>
        System.Collections.Generic.IEnumerable<Consensus.Activities.ActLinkXrefRecord> IActLinkXrefRepository.FetchAllByActId(System.String actId)
        {
            return this.FetchAllByActId(actId);
        }

        #endregion
    }
}
