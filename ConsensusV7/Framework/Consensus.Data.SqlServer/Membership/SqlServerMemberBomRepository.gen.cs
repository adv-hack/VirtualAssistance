using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Linq;

namespace Consensus.Membership
{
    /// <summary>
    ///     Provides the persistence and retrieval of the <see cref="MemberBomRecord" /> instances in a Microsoft SQL Server database.
    /// </summary>
    /// <remarks>
    ///     THIS CODE HAS BEEN AUTOMATICALLY GENERATED USING THE CONSENSUS DEVELOPER TOOLS.
    ///     DO NOT EDIT THIS CODE AS ANY CUSTOM MODIFICATIONS WILL BE LOST UPON REGENERATION.
    /// </remarks>
    public partial class SqlServerMemberBomRepository : SqlServerRepository<MemberBomRecord, String>, IMemberBomRepository
    {
        #region properties

        /// <summary>
        ///     Gets the namespace in which the data type is contained.
        /// </summary>
        protected override String TypeNamespace
        {
            get { return "Membership"; }
        }

        /// <summary>
        ///     Gets the name of the data type which is persisted by this repository.
        /// </summary>
        protected override String TypeName
        {
            get { return "MemberBom"; }
        }

        /// <summary>
        ///     Gets the name of the parameter which is used to specify the unique value that identifies each instance of a <see cref="MemberBomRecord" />.
        /// </summary>
        protected override String TypeKeyName
        {
            get { return "@PA_MBOM_ID"; }
        }

        /// <summary>
        ///     Gets the underlying table name that this repository sit over.
        /// </summary>
        public override String TableName
        {
            get { return "MEMBER_BOM"; }
        }

        #endregion

        #region methods

        /// <summary>
        ///     Maps an <see cref="IDataRecord" /> to the specified <see cref="MemberBomRecord" />.
        /// </summary>
        /// <param name="dataRecord">
        ///     The <see cref="IDataRecord" /> to be mapped.
        /// </param>
        /// <param name="record">
        ///     The <see cref="MemberBomRecord" /> instance to be mapped to.
        /// </param>
        protected override void MapRecord(IDataRecord dataRecord, MemberBomRecord record)
        {
            record.Id = dataRecord["MBOM_ID"].ConvertTo<String>();
            record.Lock = dataRecord["MBOM_LOCK"].ConvertTo<String>();
            record.AddBy = dataRecord["MBOM_ADD_BY"].ConvertTo<String>();
            record.AddDate = dataRecord["MBOM_ADD_DATE"].ConvertTo<DateTime?>();
            record.ModBy = dataRecord["MBOM_MOD_BY"].ConvertTo<String>();
            record.ModDate = dataRecord["MBOM_MOD_DATE"].ConvertTo<DateTime?>();
            record.RcvFrom = dataRecord["MBOM_RCV_FROM"].ConvertTo<String>();
            record.RcvDate = dataRecord["MBOM_RCV_DATE"].ConvertTo<DateTime?>();
            record.ParentId = dataRecord["MBOM_PARENT_ID"].ConvertTo<String>();
            record.ProdId = dataRecord["MBOM_PROD_ID"].ConvertTo<String>();
            record.GradeId = dataRecord["MBOM_GRADE_ID"].ConvertTo<String>();
            record.Main = dataRecord["MBOM_MAIN"].ConvertTo<Byte?>();
        }

        /// <summary>
        ///     Sets the parameter values for the specified <paramref name="command" /> based on the specified <typeparamref name="TRecord" /> instance.
        /// </summary>
        /// <param name="command">
        ///     The <see cref="IDbCommand" /> containing the parameters to be mapped.
        /// </param>
        /// <param name="record">
        ///     The <see cref="MemberBomRecord" /> instance to be mapped.
        /// </param>
        /// <param name="useV6Logic">
        ///     Is the procedure being run an old version 6.x procedure? (the null value handling logic is different).
        /// </param>
        protected override void MapParametersIn(IDbCommand command, MemberBomRecord record, bool useV6Logic)
        {
            this.MapParameterIn(command, "@PA_MBOM_ID", record.Id);
            this.MapParameterIn(command, "@PA_MBOM_LOCK", record.Lock);
            this.MapParameterIn(command, "@PA_MBOM_PARENT_ID", record.ParentId);
            this.MapParameterIn(command, "@PA_MBOM_PROD_ID", record.ProdId);
            this.MapParameterIn(command, "@PA_MBOM_GRADE_ID", record.GradeId);
            this.MapParameterIn(command, "@PA_MBOM_MAIN", record.Main);
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
        ///     The <see cref="MemberBomRecord" /> instance to be updated.
        /// </param>
        protected override void MapParametersOut(IDbCommand command, MemberBomRecord record)
        {
            record.Id = this.MapParameterOut(command, "@PA_MBOM_ID", record.Id);
            record.Lock = this.MapParameterOut(command, "@PA_MBOM_LOCK", record.Lock);
            record.ParentId = this.MapParameterOut(command, "@PA_MBOM_PARENT_ID", record.ParentId);
            record.ProdId = this.MapParameterOut(command, "@PA_MBOM_PROD_ID", record.ProdId);
            record.GradeId = this.MapParameterOut(command, "@PA_MBOM_GRADE_ID", record.GradeId);
            record.Main = this.MapParameterOut(command, "@PA_MBOM_MAIN", record.Main);
            record.Id = this.MapParameterOut(command, "@PA_RETURN_ID", record.Id);
        }

        /// <summary>
        ///     Retrieves a collection of <see cref="MemberBomRecord" /> instances from the data store.
        /// </summary>
        /// <param name="parentId">
        ///     The value which identifies the <see cref='MemberBomModel' /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The collection of <see cref="MemberBomRecord" /> instances that match the specified <paramref name='parentId' />.
        /// </returns>
        public IEnumerable<MemberBomRecord> FetchAllByParentId(String parentId)
        {
            DbCommand command = this.GetStoredProcedure(SqlServerOperation.FetchAll, "ParentId");
            this.MapParameterIn(command, "@PA_MBOM_PARENT_ID", parentId);
            return this.Execute(command);
        }

        /// <summary>
        ///     Retrieves a collection of <see cref="MemberBomRecord" /> instances from the data store.
        /// </summary>
        /// <param name="gradeId">
        ///     The value which identifies the <see cref='MemberBomModel' /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The collection of <see cref="MemberBomRecord" /> instances that match the specified <paramref name='gradeId' />.
        /// </returns>
        public IEnumerable<MemberBomRecord> FetchAllByGradeId(String gradeId)
        {
            DbCommand command = this.GetStoredProcedure(SqlServerOperation.FetchAll, "GradeId");
            this.MapParameterIn(command, "@PA_MBOM_GRADE_ID", gradeId);
            return this.Execute(command);
        }

        #endregion

        #region implementations

        /// <summary>
        ///     Gets the underlying table name that this repository sit over.
        /// </summary>
        System.String IMemberBomRepository.TableName
        {
            get { return this.TableName; }
        }

        /// <summary>
        ///     Retrieves a collection of <see cref="T:Consensus.Membership.MemberBomRecord" /> instances from the data store.
        /// </summary>
        /// <param name="parentId">
        ///     The value which identifies the <see cref="!:MemberBomModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The collection of <see cref="T:Consensus.Membership.MemberBomRecord" /> instances that match the specified <paramref name="parentId" />.
        /// </returns>
        System.Collections.Generic.IEnumerable<Consensus.Membership.MemberBomRecord> IMemberBomRepository.FetchAllByParentId(System.String parentId)
        {
            return this.FetchAllByParentId(parentId);
        }

        /// <summary>
        ///     Retrieves a collection of <see cref="T:Consensus.Membership.MemberBomRecord" /> instances from the data store.
        /// </summary>
        /// <param name="gradeId">
        ///     The value which identifies the <see cref="!:MemberBomModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The collection of <see cref="T:Consensus.Membership.MemberBomRecord" /> instances that match the specified <paramref name="gradeId" />.
        /// </returns>
        System.Collections.Generic.IEnumerable<Consensus.Membership.MemberBomRecord> IMemberBomRepository.FetchAllByGradeId(System.String gradeId)
        {
            return this.FetchAllByGradeId(gradeId);
        }

        #endregion
    }
}
