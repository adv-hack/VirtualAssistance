using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Linq;

namespace Consensus.Other
{
    /// <summary>
    ///     Provides the persistence and retrieval of the <see cref="WorkflowRecTypeRecord" /> instances in a Microsoft SQL Server database.
    /// </summary>
    /// <remarks>
    ///     THIS CODE HAS BEEN AUTOMATICALLY GENERATED USING THE CONSENSUS DEVELOPER TOOLS.
    ///     DO NOT EDIT THIS CODE AS ANY CUSTOM MODIFICATIONS WILL BE LOST UPON REGENERATION.
    /// </remarks>
    public partial class SqlServerWorkflowRecTypeRepository : SqlServerRepository<WorkflowRecTypeRecord, String>, IWorkflowRecTypeRepository
    {
        #region properties

        /// <summary>
        ///     Gets the namespace in which the data type is contained.
        /// </summary>
        protected override String TypeNamespace
        {
            get { return "Other"; }
        }

        /// <summary>
        ///     Gets the name of the data type which is persisted by this repository.
        /// </summary>
        protected override String TypeName
        {
            get { return "WorkflowRecType"; }
        }

        /// <summary>
        ///     Gets the name of the parameter which is used to specify the unique value that identifies each instance of a <see cref="WorkflowRecTypeRecord" />.
        /// </summary>
        protected override String TypeKeyName
        {
            get { return "@PA_WRT_ID"; }
        }

        /// <summary>
        ///     Gets the underlying table name that this repository sit over.
        /// </summary>
        public override String TableName
        {
            get { return "Workflow_Rec_Type"; }
        }

        #endregion

        #region methods

        /// <summary>
        ///     Maps an <see cref="IDataRecord" /> to the specified <see cref="WorkflowRecTypeRecord" />.
        /// </summary>
        /// <param name="dataRecord">
        ///     The <see cref="IDataRecord" /> to be mapped.
        /// </param>
        /// <param name="record">
        ///     The <see cref="WorkflowRecTypeRecord" /> instance to be mapped to.
        /// </param>
        protected override void MapRecord(IDataRecord dataRecord, WorkflowRecTypeRecord record)
        {
            record.Id = dataRecord["WRT_ID"].ConvertTo<String>();
            record.Lock = dataRecord["WRT_LOCK"].ConvertTo<String>();
            record.AddDate = dataRecord["WRT_ADD_DATE"].ConvertTo<DateTime?>();
            record.AddBy = dataRecord["WRT_ADD_BY"].ConvertTo<String>();
            record.ModDate = dataRecord["WRT_MOD_DATE"].ConvertTo<DateTime?>();
            record.ModBy = dataRecord["WRT_MOD_BY"].ConvertTo<String>();
            record.RcvDate = dataRecord["WRT_RCV_DATE"].ConvertTo<DateTime?>();
            record.RcvFrom = dataRecord["WRT_RCV_FROM"].ConvertTo<String>();
            record.RecType = dataRecord["WRT_REC_TYPE"].ConvertTo<String>();
            record.Desc = dataRecord["WRT_DESC"].ConvertTo<String>();
            record.Table = dataRecord["WRT_TABLE"].ConvertTo<String>();
            record.TableKey = dataRecord["WRT_TABLE_KEY"].ConvertTo<String>();
            record.Sql = dataRecord["WRT_SQL"].ConvertTo<String>();
            record.PrType = dataRecord["WRT_PR_TYPE"].ConvertTo<String>();
            record.SearchEntity = dataRecord["WRT_SEARCH_ENTITY"].ConvertTo<String>();
            record.LinkTo = dataRecord["WRT_LINK_TO"].ConvertTo<String>();
            record.PrTypeType = dataRecord["WRT_PR_TYPE_TYPE"].ConvertTo<String>();
            record.Query = dataRecord["WRT_QUERY"].ConvertTo<Byte?>();
            record.QuerySelect = dataRecord["WRT_QUERY_SELECT"].ConvertTo<String>();
            record.QueryMerge = dataRecord["WRT_QUERY_MERGE"].ConvertTo<String>();
            record.ActTypes = dataRecord["WRT_ACT_TYPES"].ConvertTo<String>();
            record.PrArg = dataRecord["WRT_PR_ARG"].ConvertTo<Byte>();
        }

        /// <summary>
        ///     Sets the parameter values for the specified <paramref name="command" /> based on the specified <typeparamref name="TRecord" /> instance.
        /// </summary>
        /// <param name="command">
        ///     The <see cref="IDbCommand" /> containing the parameters to be mapped.
        /// </param>
        /// <param name="record">
        ///     The <see cref="WorkflowRecTypeRecord" /> instance to be mapped.
        /// </param>
        /// <param name="useV6Logic">
        ///     Is the procedure being run an old version 6.x procedure? (the null value handling logic is different).
        /// </param>
        protected override void MapParametersIn(IDbCommand command, WorkflowRecTypeRecord record, bool useV6Logic)
        {
            this.MapParameterIn(command, "@PA_WRT_ID", record.Id);
            this.MapParameterIn(command, "@PA_WRT_LOCK", record.Lock);
            this.MapParameterIn(command, "@PA_WRT_REC_TYPE", record.RecType);
            this.MapParameterIn(command, "@PA_WRT_DESC", record.Desc);
            this.MapParameterIn(command, "@PA_WRT_TABLE", record.Table);
            this.MapParameterIn(command, "@PA_WRT_TABLE_KEY", record.TableKey);
            this.MapParameterIn(command, "@PA_WRT_SQL", record.Sql);
            this.MapParameterIn(command, "@PA_WRT_PR_TYPE", record.PrType);
            this.MapParameterIn(command, "@PA_WRT_SEARCH_ENTITY", record.SearchEntity);
            this.MapParameterIn(command, "@PA_WRT_LINK_TO", record.LinkTo);
            this.MapParameterIn(command, "@PA_WRT_PR_TYPE_TYPE", record.PrTypeType);
            this.MapParameterIn(command, "@PA_WRT_QUERY", record.Query);
            this.MapParameterIn(command, "@PA_WRT_QUERY_SELECT", record.QuerySelect);
            this.MapParameterIn(command, "@PA_WRT_QUERY_MERGE", record.QueryMerge);
            this.MapParameterIn(command, "@PA_WRT_ACT_TYPES", record.ActTypes);
            this.MapParameterIn(command, "@PA_WRT_PR_ARG", record.PrArg);
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
        ///     The <see cref="WorkflowRecTypeRecord" /> instance to be updated.
        /// </param>
        protected override void MapParametersOut(IDbCommand command, WorkflowRecTypeRecord record)
        {
            record.Id = this.MapParameterOut(command, "@PA_WRT_ID", record.Id);
            record.Lock = this.MapParameterOut(command, "@PA_WRT_LOCK", record.Lock);
            record.RecType = this.MapParameterOut(command, "@PA_WRT_REC_TYPE", record.RecType);
            record.Desc = this.MapParameterOut(command, "@PA_WRT_DESC", record.Desc);
            record.Table = this.MapParameterOut(command, "@PA_WRT_TABLE", record.Table);
            record.TableKey = this.MapParameterOut(command, "@PA_WRT_TABLE_KEY", record.TableKey);
            record.Sql = this.MapParameterOut(command, "@PA_WRT_SQL", record.Sql);
            record.PrType = this.MapParameterOut(command, "@PA_WRT_PR_TYPE", record.PrType);
            record.SearchEntity = this.MapParameterOut(command, "@PA_WRT_SEARCH_ENTITY", record.SearchEntity);
            record.LinkTo = this.MapParameterOut(command, "@PA_WRT_LINK_TO", record.LinkTo);
            record.PrTypeType = this.MapParameterOut(command, "@PA_WRT_PR_TYPE_TYPE", record.PrTypeType);
            record.Query = this.MapParameterOut(command, "@PA_WRT_QUERY", record.Query);
            record.QuerySelect = this.MapParameterOut(command, "@PA_WRT_QUERY_SELECT", record.QuerySelect);
            record.QueryMerge = this.MapParameterOut(command, "@PA_WRT_QUERY_MERGE", record.QueryMerge);
            record.ActTypes = this.MapParameterOut(command, "@PA_WRT_ACT_TYPES", record.ActTypes);
            record.PrArg = this.MapParameterOut(command, "@PA_WRT_PR_ARG", record.PrArg);
            record.Id = this.MapParameterOut(command, "@PA_RETURN_ID", record.Id);
        }

        #endregion

        #region implementations

        /// <summary>
        ///     Gets the underlying table name that this repository sit over.
        /// </summary>
        System.String IWorkflowRecTypeRepository.TableName
        {
            get { return this.TableName; }
        }

        #endregion
    }
}
