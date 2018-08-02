using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Linq;

namespace Consensus.Contact
{
    /// <summary>
    ///     Provides the persistence and retrieval of the <see cref="AssociatesRecord" /> instances in a Microsoft SQL Server database.
    /// </summary>
    /// <remarks>
    ///     THIS CODE HAS BEEN AUTOMATICALLY GENERATED USING THE CONSENSUS DEVELOPER TOOLS.
    ///     DO NOT EDIT THIS CODE AS ANY CUSTOM MODIFICATIONS WILL BE LOST UPON REGENERATION.
    /// </remarks>
    public partial class SqlServerAssociateRepository : SqlServerRepository<AssociatesRecord, Int32>, IAssociateRepository
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
            get { return "Associates"; }
        }

        /// <summary>
        ///     Gets the name of the parameter which is used to specify the unique value that identifies each instance of a <see cref="AssociatesRecord" />.
        /// </summary>
        protected override String TypeKeyName
        {
            get { return "@PA_ASSO_ID"; }
        }

        /// <summary>
        ///     Gets the underlying table name that this repository sit over.
        /// </summary>
        public override String TableName
        {
            get { return "Associates"; }
        }

        #endregion

        #region methods

        /// <summary>
        ///     Maps an <see cref="IDataRecord" /> to the specified <see cref="AssociatesRecord" />.
        /// </summary>
        /// <param name="dataRecord">
        ///     The <see cref="IDataRecord" /> to be mapped.
        /// </param>
        /// <param name="record">
        ///     The <see cref="AssociatesRecord" /> instance to be mapped to.
        /// </param>
        protected override void MapRecord(IDataRecord dataRecord, AssociatesRecord record)
        {
            record.Id = dataRecord["ASSO_ID"].ConvertTo<Int32>();
            record.AddDate = dataRecord["ASSO_ADD_DATE"].ConvertTo<DateTime>();
            record.AddBy = dataRecord["ASSO_ADD_BY"].ConvertTo<String>();
            record.ModDate = dataRecord["ASSO_MOD_DATE"].ConvertTo<DateTime>();
            record.ModBy = dataRecord["ASSO_MOD_BY"].ConvertTo<String>();
            record.RcvDate = dataRecord["ASSO_RCV_DATE"].ConvertTo<DateTime>();
            record.RcvFrom = dataRecord["ASSO_RCV_FROM"].ConvertTo<String>();
            record.AssociateId = dataRecord["ASSO_ASSOCIATE_ID"].ConvertTo<String>();
            record.ProleId = dataRecord["ASSO_PROLE_ID"].ConvertTo<String>();
            record.OrgId = dataRecord["ASSO_ORG_ID"].ConvertTo<String>();
            record.Type = dataRecord["ASSO_TYPE"].ConvertTo<Byte>();
            record.TypeName = dataRecord["ASSO_TYPE_NAME"].ConvertTo<String>();
            record.TypeCode = dataRecord["ASSO_TYPE_CODE"].ConvertTo<String>();
            record.StartDate = dataRecord["ASSO_START_DATE"].ConvertTo<DateTime?>();
            record.EndDate = dataRecord["ASSO_END_DATE"].ConvertTo<DateTime?>();
        }

        /// <summary>
        ///     Sets the parameter values for the specified <paramref name="command" /> based on the specified <typeparamref name="TRecord" /> instance.
        /// </summary>
        /// <param name="command">
        ///     The <see cref="IDbCommand" /> containing the parameters to be mapped.
        /// </param>
        /// <param name="record">
        ///     The <see cref="AssociatesRecord" /> instance to be mapped.
        /// </param>
        /// <param name="useV6Logic">
        ///     Is the procedure being run an old version 6.x procedure? (the null value handling logic is different).
        /// </param>
        protected override void MapParametersIn(IDbCommand command, AssociatesRecord record, bool useV6Logic)
        {
            this.MapParameterIn(command, "@PA_ASSO_ID", record.Id == Int32.MinValue ? ( useV6Logic ? new Int32?(0) : null ) : record.Id);
            this.MapParameterIn(command, "@PA_ASSO_ASSOCIATE_ID", record.AssociateId);
            this.MapParameterIn(command, "@PA_ASSO_PROLE_ID", record.ProleId);
            this.MapParameterIn(command, "@PA_ASSO_ORG_ID", record.OrgId);
            this.MapParameterIn(command, "@PA_ASSO_TYPE", record.Type);
            this.MapParameterIn(command, "@PA_ASSO_TYPE_NAME", record.TypeName);
            this.MapParameterIn(command, "@PA_ASSO_TYPE_CODE", record.TypeCode);
            this.MapParameterIn(command, "@PA_ASSO_START_DATE", record.StartDate == DateTime.MinValue ? ( useV6Logic ? new DateTime?(new DateTime(1900,1,1)) : null ) : record.StartDate);
            this.MapParameterIn(command, "@PA_ASSO_END_DATE", record.EndDate == DateTime.MinValue ? ( useV6Logic ? new DateTime?(new DateTime(1900,1,1)) : null ) : record.EndDate);
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
        ///     The <see cref="AssociatesRecord" /> instance to be updated.
        /// </param>
        protected override void MapParametersOut(IDbCommand command, AssociatesRecord record)
        {
            record.Id = this.MapParameterOut(command, "@PA_ASSO_ID", record.Id);
            record.AssociateId = this.MapParameterOut(command, "@PA_ASSO_ASSOCIATE_ID", record.AssociateId);
            record.ProleId = this.MapParameterOut(command, "@PA_ASSO_PROLE_ID", record.ProleId);
            record.OrgId = this.MapParameterOut(command, "@PA_ASSO_ORG_ID", record.OrgId);
            record.Type = this.MapParameterOut(command, "@PA_ASSO_TYPE", record.Type);
            record.TypeName = this.MapParameterOut(command, "@PA_ASSO_TYPE_NAME", record.TypeName);
            record.TypeCode = this.MapParameterOut(command, "@PA_ASSO_TYPE_CODE", record.TypeCode);
            record.StartDate = this.MapParameterOut(command, "@PA_ASSO_START_DATE", record.StartDate);
            record.EndDate = this.MapParameterOut(command, "@PA_ASSO_END_DATE", record.EndDate);
            record.Id = this.MapParameterOut(command, "@PA_RETURN_ID", record.Id);
        }

        /// <summary>
        ///     Retrieves a collection of <see cref="AssociatesRecord" /> instances from the data store.
        /// </summary>
        /// <param name="associateId">
        ///     The value which identifies the <see cref='AssociateModel' /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The collection of <see cref="AssociatesRecord" /> instances that match the specified <paramref name='associateId' />.
        /// </returns>
        public IEnumerable<AssociatesRecord> FetchAllByAssociateId(String associateId)
        {
            DbCommand command = this.GetStoredProcedure(SqlServerOperation.FetchAll, "AssociateId");
            this.MapParameterIn(command, "@PA_ASSO_ASSOCIATE_ID", associateId);
            return this.Execute(command);
        }

        /// <summary>
        ///     Retrieves a collection of <see cref="AssociatesRecord" /> instances from the data store.
        /// </summary>
        /// <param name="proleId">
        ///     The value which identifies the <see cref='AssociateModel' /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The collection of <see cref="AssociatesRecord" /> instances that match the specified <paramref name='proleId' />.
        /// </returns>
        public IEnumerable<AssociatesRecord> FetchAllByProleId(String proleId)
        {
            DbCommand command = this.GetStoredProcedure(SqlServerOperation.FetchAll, "ProleId");
            this.MapParameterIn(command, "@PA_ASSO_PROLE_ID", proleId);
            return this.Execute(command);
        }

        /// <summary>
        ///     Retrieves a collection of <see cref="AssociatesRecord" /> instances from the data store.
        /// </summary>
        /// <param name="orgId">
        ///     The value which identifies the <see cref='AssociateModel' /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The collection of <see cref="AssociatesRecord" /> instances that match the specified <paramref name='orgId' />.
        /// </returns>
        public IEnumerable<AssociatesRecord> FetchAllByOrgId(String orgId)
        {
            DbCommand command = this.GetStoredProcedure(SqlServerOperation.FetchAll, "OrgId");
            this.MapParameterIn(command, "@PA_ASSO_ORG_ID", orgId);
            return this.Execute(command);
        }

        #endregion

        #region implementations

        /// <summary>
        ///     Gets the underlying table name that this repository sit over.
        /// </summary>
        System.String IAssociateRepository.TableName
        {
            get { return this.TableName; }
        }

        /// <summary>
        ///     Retrieves a collection of <see cref="T:Consensus.Contact.AssociatesRecord" /> instances from the data store.
        /// </summary>
        /// <param name="associateId">
        ///     The value which identifies the <see cref="!:AssociateModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The collection of <see cref="T:Consensus.Contact.AssociatesRecord" /> instances that match the specified <paramref name="associateId" />.
        /// </returns>
        System.Collections.Generic.IEnumerable<Consensus.Contact.AssociatesRecord> IAssociateRepository.FetchAllByAssociateId(System.String associateId)
        {
            return this.FetchAllByAssociateId(associateId);
        }

        /// <summary>
        ///     Retrieves a collection of <see cref="T:Consensus.Contact.AssociatesRecord" /> instances from the data store.
        /// </summary>
        /// <param name="proleId">
        ///     The value which identifies the <see cref="!:AssociateModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The collection of <see cref="T:Consensus.Contact.AssociatesRecord" /> instances that match the specified <paramref name="proleId" />.
        /// </returns>
        System.Collections.Generic.IEnumerable<Consensus.Contact.AssociatesRecord> IAssociateRepository.FetchAllByProleId(System.String proleId)
        {
            return this.FetchAllByProleId(proleId);
        }

        /// <summary>
        ///     Retrieves a collection of <see cref="T:Consensus.Contact.AssociatesRecord" /> instances from the data store.
        /// </summary>
        /// <param name="orgId">
        ///     The value which identifies the <see cref="!:AssociateModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The collection of <see cref="T:Consensus.Contact.AssociatesRecord" /> instances that match the specified <paramref name="orgId" />.
        /// </returns>
        System.Collections.Generic.IEnumerable<Consensus.Contact.AssociatesRecord> IAssociateRepository.FetchAllByOrgId(System.String orgId)
        {
            return this.FetchAllByOrgId(orgId);
        }

        #endregion
    }
}
