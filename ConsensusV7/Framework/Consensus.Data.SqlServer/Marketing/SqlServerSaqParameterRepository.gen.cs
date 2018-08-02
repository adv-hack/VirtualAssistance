using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Linq;

namespace Consensus.Marketing
{
    /// <summary>
    ///     Provides the persistence and retrieval of the <see cref="SaqStepParamsRecord" /> instances in a Microsoft SQL Server database.
    /// </summary>
    /// <remarks>
    ///     THIS CODE HAS BEEN AUTOMATICALLY GENERATED USING THE CONSENSUS DEVELOPER TOOLS.
    ///     DO NOT EDIT THIS CODE AS ANY CUSTOM MODIFICATIONS WILL BE LOST UPON REGENERATION.
    /// </remarks>
    public partial class SqlServerSaqParameterRepository : SqlServerRepository<SaqStepParamsRecord, Int64>, ISaqParameterRepository
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
            get { return "SaqStepParams"; }
        }

        /// <summary>
        ///     Gets the name of the parameter which is used to specify the unique value that identifies each instance of a <see cref="SaqStepParamsRecord" />.
        /// </summary>
        protected override String TypeKeyName
        {
            get { return "@PA_STPRM_ID"; }
        }

        /// <summary>
        ///     Gets the underlying table name that this repository sit over.
        /// </summary>
        public override String TableName
        {
            get { return "SAQ_STEP_PARAMS"; }
        }

        #endregion

        #region methods

        /// <summary>
        ///     Maps an <see cref="IDataRecord" /> to the specified <see cref="SaqStepParamsRecord" />.
        /// </summary>
        /// <param name="dataRecord">
        ///     The <see cref="IDataRecord" /> to be mapped.
        /// </param>
        /// <param name="record">
        ///     The <see cref="SaqStepParamsRecord" /> instance to be mapped to.
        /// </param>
        protected override void MapRecord(IDataRecord dataRecord, SaqStepParamsRecord record)
        {
            record.Id = dataRecord["STPRM_ID"].ConvertTo<Int64>();
            record.AddBy = dataRecord["STPRM_ADD_BY"].ConvertTo<String>();
            record.AddDate = dataRecord["STPRM_ADD_DATE"].ConvertTo<DateTime>();
            record.ModBy = dataRecord["STPRM_MOD_BY"].ConvertTo<String>();
            record.ModDate = dataRecord["STPRM_MOD_DATE"].ConvertTo<DateTime>();
            record.StepId = dataRecord["STPRM_STEP_ID"].ConvertTo<Int64>();
            record.FId = dataRecord["STPRM_F_ID"].ConvertTo<Int64>();
            record.Condition = dataRecord["STPRM_CONDITION"].ConvertTo<String>();
            record.Value = dataRecord["STPRM_VALUE"].ConvertTo<String>();
            record.Operand = dataRecord["STPRM_OPERAND"].ConvertTo<String>();
            record.KeepWithPrevious = dataRecord["STPRM_KEEP_WITH_PREVIOUS"].ConvertTo<Byte>();
            record.Order = dataRecord["STPRM_ORDER"].ConvertTo<Int32>();
            record.PreBracket = dataRecord["STPRM_PRE_BRACKET"].ConvertTo<String>();
            record.PostBracket = dataRecord["STPRM_POST_BRACKET"].ConvertTo<String>();
        }

        /// <summary>
        ///     Sets the parameter values for the specified <paramref name="command" /> based on the specified <typeparamref name="TRecord" /> instance.
        /// </summary>
        /// <param name="command">
        ///     The <see cref="IDbCommand" /> containing the parameters to be mapped.
        /// </param>
        /// <param name="record">
        ///     The <see cref="SaqStepParamsRecord" /> instance to be mapped.
        /// </param>
        /// <param name="useV6Logic">
        ///     Is the procedure being run an old version 6.x procedure? (the null value handling logic is different).
        /// </param>
        protected override void MapParametersIn(IDbCommand command, SaqStepParamsRecord record, bool useV6Logic)
        {
            this.MapParameterIn(command, "@PA_STPRM_ID", record.Id == Int64.MinValue ? ( useV6Logic ? new Int64?(0) : null ) : record.Id);
            this.MapParameterIn(command, "@PA_STPRM_STEP_ID", record.StepId == Int64.MinValue ? ( useV6Logic ? new Int64?(0) : null ) : record.StepId);
            this.MapParameterIn(command, "@PA_STPRM_F_ID", record.FId == Int64.MinValue ? ( useV6Logic ? new Int64?(0) : null ) : record.FId);
            this.MapParameterIn(command, "@PA_STPRM_CONDITION", record.Condition);
            this.MapParameterIn(command, "@PA_STPRM_VALUE", record.Value);
            this.MapParameterIn(command, "@PA_STPRM_OPERAND", record.Operand);
            this.MapParameterIn(command, "@PA_STPRM_KEEP_WITH_PREVIOUS", record.KeepWithPrevious);
            this.MapParameterIn(command, "@PA_STPRM_ORDER", record.Order == Int32.MinValue ? 0 : record.Order);
            this.MapParameterIn(command, "@PA_STPRM_PRE_BRACKET", record.PreBracket);
            this.MapParameterIn(command, "@PA_STPRM_POST_BRACKET", record.PostBracket);
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
        ///     The <see cref="SaqStepParamsRecord" /> instance to be updated.
        /// </param>
        protected override void MapParametersOut(IDbCommand command, SaqStepParamsRecord record)
        {
            record.Id = this.MapParameterOut(command, "@PA_STPRM_ID", record.Id);
            record.StepId = this.MapParameterOut(command, "@PA_STPRM_STEP_ID", record.StepId);
            record.FId = this.MapParameterOut(command, "@PA_STPRM_F_ID", record.FId);
            record.Condition = this.MapParameterOut(command, "@PA_STPRM_CONDITION", record.Condition);
            record.Value = this.MapParameterOut(command, "@PA_STPRM_VALUE", record.Value);
            record.Operand = this.MapParameterOut(command, "@PA_STPRM_OPERAND", record.Operand);
            record.KeepWithPrevious = this.MapParameterOut(command, "@PA_STPRM_KEEP_WITH_PREVIOUS", record.KeepWithPrevious);
            record.Order = this.MapParameterOut(command, "@PA_STPRM_ORDER", record.Order);
            record.PreBracket = this.MapParameterOut(command, "@PA_STPRM_PRE_BRACKET", record.PreBracket);
            record.PostBracket = this.MapParameterOut(command, "@PA_STPRM_POST_BRACKET", record.PostBracket);
            record.Id = this.MapParameterOut(command, "@PA_RETURN_ID", record.Id);
        }

        /// <summary>
        ///     Retrieves a collection of <see cref="SaqStepParamsRecord" /> instances from the data store.
        /// </summary>
        /// <param name="stepId">
        ///     The value which identifies the <see cref='SaqParameterModel' /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The collection of <see cref="SaqStepParamsRecord" /> instances that match the specified <paramref name='stepId' />.
        /// </returns>
        public IEnumerable<SaqStepParamsRecord> FetchAllByStepId(Int64 stepId)
        {
            DbCommand command = this.GetStoredProcedure(SqlServerOperation.FetchAll, "StepId");
            this.MapParameterIn(command, "@PA_STPRM_STEP_ID", stepId);
            return this.Execute(command);
        }

        /// <summary>
        ///     Retrieves a collection of <see cref="SaqStepParamsRecord" /> instances from the data store.
        /// </summary>
        /// <param name="fId">
        ///     The value which identifies the <see cref='SaqParameterModel' /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The collection of <see cref="SaqStepParamsRecord" /> instances that match the specified <paramref name='fId' />.
        /// </returns>
        public IEnumerable<SaqStepParamsRecord> FetchAllByFId(Int64 fId)
        {
            DbCommand command = this.GetStoredProcedure(SqlServerOperation.FetchAll, "FId");
            this.MapParameterIn(command, "@PA_STPRM_F_ID", fId);
            return this.Execute(command);
        }

        #endregion

        #region implementations

        /// <summary>
        ///     Gets the underlying table name that this repository sit over.
        /// </summary>
        System.String ISaqParameterRepository.TableName
        {
            get { return this.TableName; }
        }

        /// <summary>
        ///     Retrieves a collection of <see cref="T:Consensus.Marketing.SaqStepParamsRecord" /> instances from the data store.
        /// </summary>
        /// <param name="stepId">
        ///     The value which identifies the <see cref="!:SaqParameterModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The collection of <see cref="T:Consensus.Marketing.SaqStepParamsRecord" /> instances that match the specified <paramref name="stepId" />.
        /// </returns>
        System.Collections.Generic.IEnumerable<Consensus.Marketing.SaqStepParamsRecord> ISaqParameterRepository.FetchAllByStepId(System.Int64 stepId)
        {
            return this.FetchAllByStepId(stepId);
        }

        /// <summary>
        ///     Retrieves a collection of <see cref="T:Consensus.Marketing.SaqStepParamsRecord" /> instances from the data store.
        /// </summary>
        /// <param name="fId">
        ///     The value which identifies the <see cref="!:SaqParameterModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The collection of <see cref="T:Consensus.Marketing.SaqStepParamsRecord" /> instances that match the specified <paramref name="fId" />.
        /// </returns>
        System.Collections.Generic.IEnumerable<Consensus.Marketing.SaqStepParamsRecord> ISaqParameterRepository.FetchAllByFId(System.Int64 fId)
        {
            return this.FetchAllByFId(fId);
        }

        #endregion
    }
}
