using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Linq;

namespace Consensus.Portal
{
    /// <summary>
    ///     Provides the persistence and retrieval of the <see cref="PortalRoleRecord" /> instances in a Microsoft SQL Server database.
    /// </summary>
    /// <remarks>
    ///     THIS CODE HAS BEEN AUTOMATICALLY GENERATED USING THE CONSENSUS DEVELOPER TOOLS.
    ///     DO NOT EDIT THIS CODE AS ANY CUSTOM MODIFICATIONS WILL BE LOST UPON REGENERATION.
    /// </remarks>
    public partial class SqlServerPortalRoleRepository : SqlServerRepository<PortalRoleRecord, Int32>, IPortalRoleRepository
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
            get { return "PortalRole"; }
        }

        /// <summary>
        ///     Gets the name of the parameter which is used to specify the unique value that identifies each instance of a <see cref="PortalRoleRecord" />.
        /// </summary>
        protected override String TypeKeyName
        {
            get { return "@PA_PR_ID"; }
        }

        /// <summary>
        ///     Gets the underlying table name that this repository sit over.
        /// </summary>
        public override String TableName
        {
            get { return "PORTAL_ROLE"; }
        }

        #endregion

        #region methods

        /// <summary>
        ///     Maps an <see cref="IDataRecord" /> to the specified <see cref="PortalRoleRecord" />.
        /// </summary>
        /// <param name="dataRecord">
        ///     The <see cref="IDataRecord" /> to be mapped.
        /// </param>
        /// <param name="record">
        ///     The <see cref="PortalRoleRecord" /> instance to be mapped to.
        /// </param>
        protected override void MapRecord(IDataRecord dataRecord, PortalRoleRecord record)
        {
            record.Id = dataRecord["PR_ID"].ConvertTo<Int32>();
            record.AddDate = dataRecord["PR_ADD_DATE"].ConvertTo<DateTime?>();
            record.AddBy = dataRecord["PR_ADD_BY"].ConvertTo<String>();
            record.ModDate = dataRecord["PR_MOD_DATE"].ConvertTo<DateTime?>();
            record.ModBy = dataRecord["PR_MOD_BY"].ConvertTo<String>();
            record.RcvDate = dataRecord["PR_RCV_DATE"].ConvertTo<DateTime?>();
            record.RcvFrom = dataRecord["PR_RCV_FROM"].ConvertTo<String>();
            record.Title = dataRecord["PR_TITLE"].ConvertTo<String>();
            record.Create = dataRecord["PR_CREATE"].ConvertTo<String>();
            record.Read = dataRecord["PR_READ"].ConvertTo<String>();
            record.Update = dataRecord["PR_UPDATE"].ConvertTo<String>();
            record.Delete = dataRecord["PR_DELETE"].ConvertTo<String>();
            record.ImpPrId = dataRecord["PR_IMP_PR_ID"].ConvertTo<Int32?>();
        }

        /// <summary>
        ///     Sets the parameter values for the specified <paramref name="command" /> based on the specified <typeparamref name="TRecord" /> instance.
        /// </summary>
        /// <param name="command">
        ///     The <see cref="IDbCommand" /> containing the parameters to be mapped.
        /// </param>
        /// <param name="record">
        ///     The <see cref="PortalRoleRecord" /> instance to be mapped.
        /// </param>
        /// <param name="useV6Logic">
        ///     Is the procedure being run an old version 6.x procedure? (the null value handling logic is different).
        /// </param>
        protected override void MapParametersIn(IDbCommand command, PortalRoleRecord record, bool useV6Logic)
        {
            this.MapParameterIn(command, "@PA_PR_ID", record.Id == Int32.MinValue ? ( useV6Logic ? new Int32?(0) : null ) : record.Id);
            this.MapParameterIn(command, "@PA_PR_TITLE", record.Title);
            this.MapParameterIn(command, "@PA_PR_CREATE", record.Create);
            this.MapParameterIn(command, "@PA_PR_READ", record.Read);
            this.MapParameterIn(command, "@PA_PR_UPDATE", record.Update);
            this.MapParameterIn(command, "@PA_PR_DELETE", record.Delete);
            this.MapParameterIn(command, "@PA_PR_IMP_PR_ID", record.ImpPrId == Int32.MinValue ? ( useV6Logic ? new Int32?(0) : null ) : record.ImpPrId);
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
        ///     The <see cref="PortalRoleRecord" /> instance to be updated.
        /// </param>
        protected override void MapParametersOut(IDbCommand command, PortalRoleRecord record)
        {
            record.Id = this.MapParameterOut(command, "@PA_PR_ID", record.Id);
            record.Title = this.MapParameterOut(command, "@PA_PR_TITLE", record.Title);
            record.Create = this.MapParameterOut(command, "@PA_PR_CREATE", record.Create);
            record.Read = this.MapParameterOut(command, "@PA_PR_READ", record.Read);
            record.Update = this.MapParameterOut(command, "@PA_PR_UPDATE", record.Update);
            record.Delete = this.MapParameterOut(command, "@PA_PR_DELETE", record.Delete);
            record.ImpPrId = this.MapParameterOut(command, "@PA_PR_IMP_PR_ID", record.ImpPrId);
            record.Id = this.MapParameterOut(command, "@PA_RETURN_ID", record.Id);
        }

        #endregion

        #region implementations

        /// <summary>
        ///     Gets the underlying table name that this repository sit over.
        /// </summary>
        System.String IPortalRoleRepository.TableName
        {
            get { return this.TableName; }
        }

        #endregion
    }
}
