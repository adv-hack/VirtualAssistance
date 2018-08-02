using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Linq;

namespace Consensus.Portal
{
    /// <summary>
    ///     Provides the persistence and retrieval of the <see cref="PortaluserroleRecord" /> instances in a Microsoft SQL Server database.
    /// </summary>
    /// <remarks>
    ///     THIS CODE HAS BEEN AUTOMATICALLY GENERATED USING THE CONSENSUS DEVELOPER TOOLS.
    ///     DO NOT EDIT THIS CODE AS ANY CUSTOM MODIFICATIONS WILL BE LOST UPON REGENERATION.
    /// </remarks>
    public partial class SqlServerPortalUserRoleRepository : SqlServerRepository<PortaluserroleRecord, Int32>, IPortalUserRoleRepository
    {
        #region properties

        /// <summary>
        ///     Gets the namespace in which the data type is contained.
        /// </summary>
        protected override String TypeNamespace
        {
            get { return "Portal"; }
        }

        /// <summary>
        ///     Gets the name of the data type which is persisted by this repository.
        /// </summary>
        protected override String TypeName
        {
            get { return "Portaluserrole"; }
        }

        /// <summary>
        ///     Gets the name of the parameter which is used to specify the unique value that identifies each instance of a <see cref="PortaluserroleRecord" />.
        /// </summary>
        protected override String TypeKeyName
        {
            get { return "@PA_PUR_ID"; }
        }

        /// <summary>
        ///     Gets the underlying table name that this repository sit over.
        /// </summary>
        public override String TableName
        {
            get { return "PortalUserRole"; }
        }

        #endregion

        #region methods

        /// <summary>
        ///     Maps an <see cref="IDataRecord" /> to the specified <see cref="PortaluserroleRecord" />.
        /// </summary>
        /// <param name="dataRecord">
        ///     The <see cref="IDataRecord" /> to be mapped.
        /// </param>
        /// <param name="record">
        ///     The <see cref="PortaluserroleRecord" /> instance to be mapped to.
        /// </param>
        protected override void MapRecord(IDataRecord dataRecord, PortaluserroleRecord record)
        {
            record.Id = dataRecord["PUR_ID"].ConvertTo<Int32>();
            record.AddDate = dataRecord["PUR_ADD_DATE"].ConvertTo<DateTime>();
            record.AddBy = dataRecord["PUR_ADD_BY"].ConvertTo<String>();
            record.ModDate = dataRecord["PUR_MOD_DATE"].ConvertTo<DateTime>();
            record.ModBy = dataRecord["PUR_MOD_BY"].ConvertTo<String>();
            record.PuId = dataRecord["PUR_PU_ID"].ConvertTo<Int32>();
            record.PrId = dataRecord["PUR_PR_ID"].ConvertTo<Int32>();
        }

        /// <summary>
        ///     Sets the parameter values for the specified <paramref name="command" /> based on the specified <typeparamref name="TRecord" /> instance.
        /// </summary>
        /// <param name="command">
        ///     The <see cref="IDbCommand" /> containing the parameters to be mapped.
        /// </param>
        /// <param name="record">
        ///     The <see cref="PortaluserroleRecord" /> instance to be mapped.
        /// </param>
        /// <param name="useV6Logic">
        ///     Is the procedure being run an old version 6.x procedure? (the null value handling logic is different).
        /// </param>
        protected override void MapParametersIn(IDbCommand command, PortaluserroleRecord record, bool useV6Logic)
        {
            this.MapParameterIn(command, "@PA_PUR_ID", record.Id == Int32.MinValue ? ( useV6Logic ? new Int32?(0) : null ) : record.Id);
            this.MapParameterIn(command, "@PA_PUR_PU_ID", record.PuId == Int32.MinValue ? ( useV6Logic ? new Int32?(0) : null ) : record.PuId);
            this.MapParameterIn(command, "@PA_PUR_PR_ID", record.PrId == Int32.MinValue ? ( useV6Logic ? new Int32?(0) : null ) : record.PrId);
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
        ///     The <see cref="PortaluserroleRecord" /> instance to be updated.
        /// </param>
        protected override void MapParametersOut(IDbCommand command, PortaluserroleRecord record)
        {
            record.Id = this.MapParameterOut(command, "@PA_PUR_ID", record.Id);
            record.PuId = this.MapParameterOut(command, "@PA_PUR_PU_ID", record.PuId);
            record.PrId = this.MapParameterOut(command, "@PA_PUR_PR_ID", record.PrId);
            record.Id = this.MapParameterOut(command, "@PA_RETURN_ID", record.Id);
        }

        /// <summary>
        ///     Retrieves a collection of <see cref="PortaluserroleRecord" /> instances from the data store.
        /// </summary>
        /// <param name="puId">
        ///     The value which identifies the <see cref='PortalUserRoleModel' /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The collection of <see cref="PortaluserroleRecord" /> instances that match the specified <paramref name='puId' />.
        /// </returns>
        public IEnumerable<PortaluserroleRecord> FetchAllByPuId(Int32 puId)
        {
            DbCommand command = this.GetStoredProcedure(SqlServerOperation.FetchAll, "PuId");
            this.MapParameterIn(command, "@PA_PUR_PU_ID", puId);
            return this.Execute(command);
        }

        /// <summary>
        ///     Retrieves a collection of <see cref="PortaluserroleRecord" /> instances from the data store.
        /// </summary>
        /// <param name="prId">
        ///     The value which identifies the <see cref='PortalUserRoleModel' /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The collection of <see cref="PortaluserroleRecord" /> instances that match the specified <paramref name='prId' />.
        /// </returns>
        public IEnumerable<PortaluserroleRecord> FetchAllByPrId(Int32 prId)
        {
            DbCommand command = this.GetStoredProcedure(SqlServerOperation.FetchAll, "PrId");
            this.MapParameterIn(command, "@PA_PUR_PR_ID", prId);
            return this.Execute(command);
        }

        #endregion

        #region implementations

        /// <summary>
        ///     Gets the underlying table name that this repository sit over.
        /// </summary>
        System.String IPortalUserRoleRepository.TableName
        {
            get { return this.TableName; }
        }

        /// <summary>
        ///     Retrieves a collection of <see cref="T:Consensus.Portal.PortaluserroleRecord" /> instances from the data store.
        /// </summary>
        /// <param name="puId">
        ///     The value which identifies the <see cref="!:PortalUserRoleModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The collection of <see cref="T:Consensus.Portal.PortaluserroleRecord" /> instances that match the specified <paramref name="puId" />.
        /// </returns>
        System.Collections.Generic.IEnumerable<Consensus.Portal.PortaluserroleRecord> IPortalUserRoleRepository.FetchAllByPuId(System.Int32 puId)
        {
            return this.FetchAllByPuId(puId);
        }

        /// <summary>
        ///     Retrieves a collection of <see cref="T:Consensus.Portal.PortaluserroleRecord" /> instances from the data store.
        /// </summary>
        /// <param name="prId">
        ///     The value which identifies the <see cref="!:PortalUserRoleModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The collection of <see cref="T:Consensus.Portal.PortaluserroleRecord" /> instances that match the specified <paramref name="prId" />.
        /// </returns>
        System.Collections.Generic.IEnumerable<Consensus.Portal.PortaluserroleRecord> IPortalUserRoleRepository.FetchAllByPrId(System.Int32 prId)
        {
            return this.FetchAllByPrId(prId);
        }

        #endregion
    }
}
