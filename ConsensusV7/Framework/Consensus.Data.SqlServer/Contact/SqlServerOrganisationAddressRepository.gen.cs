using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Linq;

namespace Consensus.Contact
{
    /// <summary>
    ///     Provides the persistence and retrieval of the <see cref="AddressXrefRecord" /> instances in a Microsoft SQL Server database.
    /// </summary>
    /// <remarks>
    ///     THIS CODE HAS BEEN AUTOMATICALLY GENERATED USING THE CONSENSUS DEVELOPER TOOLS.
    ///     DO NOT EDIT THIS CODE AS ANY CUSTOM MODIFICATIONS WILL BE LOST UPON REGENERATION.
    /// </remarks>
    public partial class SqlServerOrganisationAddressRepository : SqlServerRepository<AddressXrefRecord, String>, IOrganisationAddressRepository
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
            get { return "AddressXref"; }
        }

        /// <summary>
        ///     Gets the name of the parameter which is used to specify the unique value that identifies each instance of a <see cref="AddressXrefRecord" />.
        /// </summary>
        protected override String TypeKeyName
        {
            get { return "@PA_ADDXREF_ID"; }
        }

        /// <summary>
        ///     Gets the underlying table name that this repository sit over.
        /// </summary>
        public override String TableName
        {
            get { return "Address_Xref"; }
        }

        #endregion

        #region methods

        /// <summary>
        ///     Maps an <see cref="IDataRecord" /> to the specified <see cref="AddressXrefRecord" />.
        /// </summary>
        /// <param name="dataRecord">
        ///     The <see cref="IDataRecord" /> to be mapped.
        /// </param>
        /// <param name="record">
        ///     The <see cref="AddressXrefRecord" /> instance to be mapped to.
        /// </param>
        protected override void MapRecord(IDataRecord dataRecord, AddressXrefRecord record)
        {
            record.Id = dataRecord["ADDXREF_ID"].ConvertTo<String>();
            record.AddDate = dataRecord["ADDXREF_ADD_DATE"].ConvertTo<DateTime?>();
            record.AddBy = dataRecord["ADDXREF_ADD_BY"].ConvertTo<String>();
            record.ModDate = dataRecord["ADDXREF_MOD_DATE"].ConvertTo<DateTime?>();
            record.ModBy = dataRecord["ADDXREF_MOD_BY"].ConvertTo<String>();
            record.RcvDate = dataRecord["ADDXREF_RCV_DATE"].ConvertTo<DateTime?>();
            record.RcvFrom = dataRecord["ADDXREF_RCV_FROM"].ConvertTo<String>();
            record.AddId = dataRecord["ADDXREF_ADD_ID"].ConvertTo<String>();
            record.Start = dataRecord["ADDXREF_START"].ConvertTo<DateTime?>();
            record.End = dataRecord["ADDXREF_END"].ConvertTo<DateTime?>();
            record.Type = dataRecord["ADDXREF_TYPE"].ConvertTo<String>();
            record.OrgId = dataRecord["ADDXREF_ORG_ID"].ConvertTo<String>();
            record.Principal = dataRecord["ADDXREF_PRINCIPAL"].ConvertTo<Byte?>();
            record.SalesRep = dataRecord["ADDXREF_SALES_REP"].ConvertTo<String>();
            record.AddPostcode = dataRecord["ADDXREF_ADD_POSTCODE"].ConvertTo<String>();
            record.OrgName = dataRecord["ADDXREF_ORG_NAME"].ConvertTo<String>();
            record.OrgDuns = dataRecord["ADDXREF_ORG_DUNS"].ConvertTo<String>();
            record.ProleId = dataRecord["ADDXREF_PROLE_ID"].ConvertTo<String>();
        }

        /// <summary>
        ///     Sets the parameter values for the specified <paramref name="command" /> based on the specified <typeparamref name="TRecord" /> instance.
        /// </summary>
        /// <param name="command">
        ///     The <see cref="IDbCommand" /> containing the parameters to be mapped.
        /// </param>
        /// <param name="record">
        ///     The <see cref="AddressXrefRecord" /> instance to be mapped.
        /// </param>
        /// <param name="useV6Logic">
        ///     Is the procedure being run an old version 6.x procedure? (the null value handling logic is different).
        /// </param>
        protected override void MapParametersIn(IDbCommand command, AddressXrefRecord record, bool useV6Logic)
        {
            this.MapParameterIn(command, "@PA_ADDXREF_ID", record.Id);
            this.MapParameterIn(command, "@PA_ADDXREF_ADD_ID", record.AddId);
            this.MapParameterIn(command, "@PA_ADDXREF_START", record.Start == DateTime.MinValue ? ( useV6Logic ? new DateTime?(new DateTime(1900,1,1)) : null ) : record.Start);
            this.MapParameterIn(command, "@PA_ADDXREF_END", record.End == DateTime.MinValue ? ( useV6Logic ? new DateTime?(new DateTime(1900,1,1)) : null ) : record.End);
            this.MapParameterIn(command, "@PA_ADDXREF_TYPE", record.Type);
            this.MapParameterIn(command, "@PA_ADDXREF_ORG_ID", record.OrgId);
            this.MapParameterIn(command, "@PA_ADDXREF_PRINCIPAL", record.Principal);
            this.MapParameterIn(command, "@PA_ADDXREF_SALES_REP", record.SalesRep);
            this.MapParameterIn(command, "@PA_ADDXREF_ADD_POSTCODE", record.AddPostcode);
            this.MapParameterIn(command, "@PA_ADDXREF_ORG_NAME", record.OrgName);
            this.MapParameterIn(command, "@PA_ADDXREF_ORG_DUNS", record.OrgDuns);
            this.MapParameterIn(command, "@PA_ADDXREF_PROLE_ID", record.ProleId);
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
        ///     The <see cref="AddressXrefRecord" /> instance to be updated.
        /// </param>
        protected override void MapParametersOut(IDbCommand command, AddressXrefRecord record)
        {
            record.Id = this.MapParameterOut(command, "@PA_ADDXREF_ID", record.Id);
            record.AddId = this.MapParameterOut(command, "@PA_ADDXREF_ADD_ID", record.AddId);
            record.Start = this.MapParameterOut(command, "@PA_ADDXREF_START", record.Start);
            record.End = this.MapParameterOut(command, "@PA_ADDXREF_END", record.End);
            record.Type = this.MapParameterOut(command, "@PA_ADDXREF_TYPE", record.Type);
            record.OrgId = this.MapParameterOut(command, "@PA_ADDXREF_ORG_ID", record.OrgId);
            record.Principal = this.MapParameterOut(command, "@PA_ADDXREF_PRINCIPAL", record.Principal);
            record.SalesRep = this.MapParameterOut(command, "@PA_ADDXREF_SALES_REP", record.SalesRep);
            record.AddPostcode = this.MapParameterOut(command, "@PA_ADDXREF_ADD_POSTCODE", record.AddPostcode);
            record.OrgName = this.MapParameterOut(command, "@PA_ADDXREF_ORG_NAME", record.OrgName);
            record.OrgDuns = this.MapParameterOut(command, "@PA_ADDXREF_ORG_DUNS", record.OrgDuns);
            record.ProleId = this.MapParameterOut(command, "@PA_ADDXREF_PROLE_ID", record.ProleId);
            record.Id = this.MapParameterOut(command, "@PA_RETURN_ID", record.Id);
        }

        /// <summary>
        ///     Retrieves a collection of <see cref="AddressXrefRecord" /> instances from the data store.
        /// </summary>
        /// <param name="addId">
        ///     The value which identifies the <see cref='OrganisationAddressModel' /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The collection of <see cref="AddressXrefRecord" /> instances that match the specified <paramref name='addId' />.
        /// </returns>
        public IEnumerable<AddressXrefRecord> FetchAllByAddId(String addId)
        {
            DbCommand command = this.GetStoredProcedure(SqlServerOperation.FetchAll, "AddId");
            this.MapParameterIn(command, "@PA_ADDXREF_ADD_ID", addId);
            return this.Execute(command);
        }

        /// <summary>
        ///     Retrieves a collection of <see cref="AddressXrefRecord" /> instances from the data store.
        /// </summary>
        /// <param name="orgId">
        ///     The value which identifies the <see cref='OrganisationAddressModel' /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The collection of <see cref="AddressXrefRecord" /> instances that match the specified <paramref name='orgId' />.
        /// </returns>
        public IEnumerable<AddressXrefRecord> FetchAllByOrgId(String orgId)
        {
            DbCommand command = this.GetStoredProcedure(SqlServerOperation.FetchAll, "OrgId");
            this.MapParameterIn(command, "@PA_ADDXREF_ORG_ID", orgId);
            return this.Execute(command);
        }

        #endregion

        #region implementations

        /// <summary>
        ///     Gets the underlying table name that this repository sit over.
        /// </summary>
        System.String IOrganisationAddressRepository.TableName
        {
            get { return this.TableName; }
        }

        /// <summary>
        ///     Retrieves a collection of <see cref="T:Consensus.Contact.AddressXrefRecord" /> instances from the data store.
        /// </summary>
        /// <param name="addId">
        ///     The value which identifies the <see cref="!:OrganisationAddressModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The collection of <see cref="T:Consensus.Contact.AddressXrefRecord" /> instances that match the specified <paramref name="addId" />.
        /// </returns>
        System.Collections.Generic.IEnumerable<Consensus.Contact.AddressXrefRecord> IOrganisationAddressRepository.FetchAllByAddId(System.String addId)
        {
            return this.FetchAllByAddId(addId);
        }

        /// <summary>
        ///     Retrieves a collection of <see cref="T:Consensus.Contact.AddressXrefRecord" /> instances from the data store.
        /// </summary>
        /// <param name="orgId">
        ///     The value which identifies the <see cref="!:OrganisationAddressModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The collection of <see cref="T:Consensus.Contact.AddressXrefRecord" /> instances that match the specified <paramref name="orgId" />.
        /// </returns>
        System.Collections.Generic.IEnumerable<Consensus.Contact.AddressXrefRecord> IOrganisationAddressRepository.FetchAllByOrgId(System.String orgId)
        {
            return this.FetchAllByOrgId(orgId);
        }

        #endregion
    }
}
