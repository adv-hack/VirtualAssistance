using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Linq;

namespace Consensus.Contact
{
    /// <summary>
    ///     Provides the persistence and retrieval of the <see cref="DepartmentRecord" /> instances in a Microsoft SQL Server database.
    /// </summary>
    /// <remarks>
    ///     THIS CODE HAS BEEN AUTOMATICALLY GENERATED USING THE CONSENSUS DEVELOPER TOOLS.
    ///     DO NOT EDIT THIS CODE AS ANY CUSTOM MODIFICATIONS WILL BE LOST UPON REGENERATION.
    /// </remarks>
    public partial class SqlServerOrganisationDepartmentRepository : SqlServerRepository<DepartmentRecord, String>, IOrganisationDepartmentRepository
    {
        #region properties

        /// <summary>
        ///     Gets the namespace in which the data type is contained.
        /// </summary>
        protected override String TypeNamespace
        {
            get { return "Contact"; }
        }

        /// <summary>
        ///     Gets the name of the data type which is persisted by this repository.
        /// </summary>
        protected override String TypeName
        {
            get { return "Department"; }
        }

        /// <summary>
        ///     Gets the name of the parameter which is used to specify the unique value that identifies each instance of a <see cref="DepartmentRecord" />.
        /// </summary>
        protected override String TypeKeyName
        {
            get { return "@PA_DEPT_ID"; }
        }

        /// <summary>
        ///     Gets the underlying table name that this repository sit over.
        /// </summary>
        public override String TableName
        {
            get { return "DEPARTMENT"; }
        }

        #endregion

        #region methods

        /// <summary>
        ///     Maps an <see cref="IDataRecord" /> to the specified <see cref="DepartmentRecord" />.
        /// </summary>
        /// <param name="dataRecord">
        ///     The <see cref="IDataRecord" /> to be mapped.
        /// </param>
        /// <param name="record">
        ///     The <see cref="DepartmentRecord" /> instance to be mapped to.
        /// </param>
        protected override void MapRecord(IDataRecord dataRecord, DepartmentRecord record)
        {
            record.Id = dataRecord["DEPT_ID"].ConvertTo<String>();
            record.AddDate = dataRecord["DEPT_ADD_DATE"].ConvertTo<DateTime?>();
            record.AddBy = dataRecord["DEPT_ADD_BY"].ConvertTo<String>();
            record.ModDate = dataRecord["DEPT_MOD_DATE"].ConvertTo<DateTime?>();
            record.ModBy = dataRecord["DEPT_MOD_BY"].ConvertTo<String>();
            record.RcvDate = dataRecord["DEPT_RCV_DATE"].ConvertTo<DateTime?>();
            record.RcvFrom = dataRecord["DEPT_RCV_FROM"].ConvertTo<String>();
            record.OrgId = dataRecord["DEPT_ORG_ID"].ConvertTo<String>();
            record.Name = dataRecord["DEPT_NAME"].ConvertTo<String>();
        }

        /// <summary>
        ///     Sets the parameter values for the specified <paramref name="command" /> based on the specified <typeparamref name="TRecord" /> instance.
        /// </summary>
        /// <param name="command">
        ///     The <see cref="IDbCommand" /> containing the parameters to be mapped.
        /// </param>
        /// <param name="record">
        ///     The <see cref="DepartmentRecord" /> instance to be mapped.
        /// </param>
        /// <param name="useV6Logic">
        ///     Is the procedure being run an old version 6.x procedure? (the null value handling logic is different).
        /// </param>
        protected override void MapParametersIn(IDbCommand command, DepartmentRecord record, bool useV6Logic)
        {
            this.MapParameterIn(command, "@PA_DEPT_ID", record.Id);
            this.MapParameterIn(command, "@PA_DEPT_ORG_ID", record.OrgId);
            this.MapParameterIn(command, "@PA_DEPT_NAME", record.Name);
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
        ///     The <see cref="DepartmentRecord" /> instance to be updated.
        /// </param>
        protected override void MapParametersOut(IDbCommand command, DepartmentRecord record)
        {
            record.Id = this.MapParameterOut(command, "@PA_DEPT_ID", record.Id);
            record.OrgId = this.MapParameterOut(command, "@PA_DEPT_ORG_ID", record.OrgId);
            record.Name = this.MapParameterOut(command, "@PA_DEPT_NAME", record.Name);
            record.Id = this.MapParameterOut(command, "@PA_RETURN_ID", record.Id);
        }

        /// <summary>
        ///     Retrieves a collection of <see cref="DepartmentRecord" /> instances from the data store.
        /// </summary>
        /// <param name="orgId">
        ///     The value which identifies the <see cref='OrganisationDepartmentModel' /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The collection of <see cref="DepartmentRecord" /> instances that match the specified <paramref name='orgId' />.
        /// </returns>
        public IEnumerable<DepartmentRecord> FetchAllByOrgId(String orgId)
        {
            DbCommand command = this.GetStoredProcedure(SqlServerOperation.FetchAll, "OrgId");
            this.MapParameterIn(command, "@PA_DEPT_ORG_ID", orgId);
            return this.Execute(command);
        }

        #endregion

        #region implementations

        /// <summary>
        ///     Gets the underlying table name that this repository sit over.
        /// </summary>
        System.String IOrganisationDepartmentRepository.TableName
        {
            get { return this.TableName; }
        }

        /// <summary>
        ///     Retrieves a collection of <see cref="T:Consensus.Contact.DepartmentRecord" /> instances from the data store.
        /// </summary>
        /// <param name="orgId">
        ///     The value which identifies the <see cref="!:OrganisationDepartmentModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The collection of <see cref="T:Consensus.Contact.DepartmentRecord" /> instances that match the specified <paramref name="orgId" />.
        /// </returns>
        System.Collections.Generic.IEnumerable<Consensus.Contact.DepartmentRecord> IOrganisationDepartmentRepository.FetchAllByOrgId(System.String orgId)
        {
            return this.FetchAllByOrgId(orgId);
        }

        #endregion
    }
}
