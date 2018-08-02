using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Linq;

namespace Consensus.Membership
{
    /// <summary>
    ///     Provides the persistence and retrieval of the <see cref="CommitteeRecord" /> instances in a Microsoft SQL Server database.
    /// </summary>
    /// <remarks>
    ///     THIS CODE HAS BEEN AUTOMATICALLY GENERATED USING THE CONSENSUS DEVELOPER TOOLS.
    ///     DO NOT EDIT THIS CODE AS ANY CUSTOM MODIFICATIONS WILL BE LOST UPON REGENERATION.
    /// </remarks>
    public partial class SqlServerCommitteeRepository : SqlServerRepository<CommitteeRecord, String>, ICommitteeRepository
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
            get { return "Committee"; }
        }

        /// <summary>
        ///     Gets the name of the parameter which is used to specify the unique value that identifies each instance of a <see cref="CommitteeRecord" />.
        /// </summary>
        protected override String TypeKeyName
        {
            get { return "@PA_COM_ID"; }
        }

        /// <summary>
        ///     Gets the underlying table name that this repository sit over.
        /// </summary>
        public override String TableName
        {
            get { return "Committee"; }
        }

        #endregion

        #region methods

        /// <summary>
        ///     Maps an <see cref="IDataRecord" /> to the specified <see cref="CommitteeRecord" />.
        /// </summary>
        /// <param name="dataRecord">
        ///     The <see cref="IDataRecord" /> to be mapped.
        /// </param>
        /// <param name="record">
        ///     The <see cref="CommitteeRecord" /> instance to be mapped to.
        /// </param>
        protected override void MapRecord(IDataRecord dataRecord, CommitteeRecord record)
        {
            record.Id = dataRecord["COM_ID"].ConvertTo<String>();
            record.AddBy = dataRecord["COM_ADD_BY"].ConvertTo<String>();
            record.AddDate = dataRecord["COM_ADD_DATE"].ConvertTo<DateTime?>();
            record.ModBy = dataRecord["COM_MOD_BY"].ConvertTo<String>();
            record.ModDate = dataRecord["COM_MOD_DATE"].ConvertTo<DateTime?>();
            record.RcvFrom = dataRecord["COM_RCV_FROM"].ConvertTo<String>();
            record.RcvDate = dataRecord["COM_RCV_DATE"].ConvertTo<DateTime?>();
            record.Name = dataRecord["COM_NAME"].ConvertTo<String>();
            record.Status = dataRecord["COM_STATUS"].ConvertTo<String>();
            record.Type = dataRecord["COM_TYPE"].ConvertTo<String>();
            record.StartDate = dataRecord["COM_START_DATE"].ConvertTo<DateTime?>();
            record.Category = dataRecord["COM_CATEGORY"].ConvertTo<String>();
            record.Group = dataRecord["COM_GROUP"].ConvertTo<String>();
            record.DisId = dataRecord["COM_DIS_ID"].ConvertTo<String>();
            record.ProdId = dataRecord["COM_PROD_ID"].ConvertTo<String>();
            record.BrId = dataRecord["COM_BR_ID"].ConvertTo<String>();
            record.ExtUrl = dataRecord["COM_EXT_URL"].ConvertTo<String>();
            record.ShowOnOrg = dataRecord["COM_SHOW_ON_ORG"].ConvertTo<Byte?>();
            record.NoPeople = dataRecord["COM_NO_PEOPLE"].ConvertTo<Int32?>();
        }

        /// <summary>
        ///     Sets the parameter values for the specified <paramref name="command" /> based on the specified <typeparamref name="TRecord" /> instance.
        /// </summary>
        /// <param name="command">
        ///     The <see cref="IDbCommand" /> containing the parameters to be mapped.
        /// </param>
        /// <param name="record">
        ///     The <see cref="CommitteeRecord" /> instance to be mapped.
        /// </param>
        /// <param name="useV6Logic">
        ///     Is the procedure being run an old version 6.x procedure? (the null value handling logic is different).
        /// </param>
        protected override void MapParametersIn(IDbCommand command, CommitteeRecord record, bool useV6Logic)
        {
            this.MapParameterIn(command, "@PA_COM_ID", record.Id);
            this.MapParameterIn(command, "@PA_COM_NAME", record.Name);
            this.MapParameterIn(command, "@PA_COM_STATUS", record.Status);
            this.MapParameterIn(command, "@PA_COM_TYPE", record.Type);
            this.MapParameterIn(command, "@PA_COM_START_DATE", record.StartDate == DateTime.MinValue ? ( useV6Logic ? new DateTime?(new DateTime(1900,1,1)) : null ) : record.StartDate);
            this.MapParameterIn(command, "@PA_COM_CATEGORY", record.Category);
            this.MapParameterIn(command, "@PA_COM_GROUP", record.Group);
            this.MapParameterIn(command, "@PA_COM_DIS_ID", record.DisId);
            this.MapParameterIn(command, "@PA_COM_PROD_ID", record.ProdId);
            this.MapParameterIn(command, "@PA_COM_BR_ID", record.BrId);
            this.MapParameterIn(command, "@PA_COM_EXT_URL", record.ExtUrl);
            this.MapParameterIn(command, "@PA_COM_SHOW_ON_ORG", record.ShowOnOrg);
            this.MapParameterIn(command, "@PA_COM_NO_PEOPLE", record.NoPeople == Int32.MinValue ? ( useV6Logic ? new Int32?(0) : null ) : record.NoPeople);
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
        ///     The <see cref="CommitteeRecord" /> instance to be updated.
        /// </param>
        protected override void MapParametersOut(IDbCommand command, CommitteeRecord record)
        {
            record.Id = this.MapParameterOut(command, "@PA_COM_ID", record.Id);
            record.Name = this.MapParameterOut(command, "@PA_COM_NAME", record.Name);
            record.Status = this.MapParameterOut(command, "@PA_COM_STATUS", record.Status);
            record.Type = this.MapParameterOut(command, "@PA_COM_TYPE", record.Type);
            record.StartDate = this.MapParameterOut(command, "@PA_COM_START_DATE", record.StartDate);
            record.Category = this.MapParameterOut(command, "@PA_COM_CATEGORY", record.Category);
            record.Group = this.MapParameterOut(command, "@PA_COM_GROUP", record.Group);
            record.DisId = this.MapParameterOut(command, "@PA_COM_DIS_ID", record.DisId);
            record.ProdId = this.MapParameterOut(command, "@PA_COM_PROD_ID", record.ProdId);
            record.BrId = this.MapParameterOut(command, "@PA_COM_BR_ID", record.BrId);
            record.ExtUrl = this.MapParameterOut(command, "@PA_COM_EXT_URL", record.ExtUrl);
            record.ShowOnOrg = this.MapParameterOut(command, "@PA_COM_SHOW_ON_ORG", record.ShowOnOrg);
            record.NoPeople = this.MapParameterOut(command, "@PA_COM_NO_PEOPLE", record.NoPeople);
            record.Id = this.MapParameterOut(command, "@PA_RETURN_ID", record.Id);
        }

        /// <summary>
        ///     Retrieves a collection of <see cref="CommitteeRecord" /> instances from the data store.
        /// </summary>
        /// <param name="disId">
        ///     The value which identifies the <see cref='CommitteeModel' /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The collection of <see cref="CommitteeRecord" /> instances that match the specified <paramref name='disId' />.
        /// </returns>
        public IEnumerable<CommitteeRecord> FetchAllByDisId(String disId)
        {
            DbCommand command = this.GetStoredProcedure(SqlServerOperation.FetchAll, "DisId");
            this.MapParameterIn(command, "@PA_COM_DIS_ID", disId);
            return this.Execute(command);
        }

        /// <summary>
        ///     Retrieves a collection of <see cref="CommitteeRecord" /> instances from the data store.
        /// </summary>
        /// <param name="prodId">
        ///     The value which identifies the <see cref='CommitteeModel' /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The collection of <see cref="CommitteeRecord" /> instances that match the specified <paramref name='prodId' />.
        /// </returns>
        public IEnumerable<CommitteeRecord> FetchAllByProdId(String prodId)
        {
            DbCommand command = this.GetStoredProcedure(SqlServerOperation.FetchAll, "ProdId");
            this.MapParameterIn(command, "@PA_COM_PROD_ID", prodId);
            return this.Execute(command);
        }

        /// <summary>
        ///     Retrieves a collection of <see cref="CommitteeRecord" /> instances from the data store.
        /// </summary>
        /// <param name="brId">
        ///     The value which identifies the <see cref='CommitteeModel' /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The collection of <see cref="CommitteeRecord" /> instances that match the specified <paramref name='brId' />.
        /// </returns>
        public IEnumerable<CommitteeRecord> FetchAllByBrId(String brId)
        {
            DbCommand command = this.GetStoredProcedure(SqlServerOperation.FetchAll, "BrId");
            this.MapParameterIn(command, "@PA_COM_BR_ID", brId);
            return this.Execute(command);
        }

        #endregion

        #region implementations

        /// <summary>
        ///     Gets the underlying table name that this repository sit over.
        /// </summary>
        System.String ICommitteeRepository.TableName
        {
            get { return this.TableName; }
        }

        /// <summary>
        ///     Retrieves a collection of <see cref="T:Consensus.Membership.CommitteeRecord" /> instances from the data store.
        /// </summary>
        /// <param name="disId">
        ///     The value which identifies the <see cref="!:CommitteeModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The collection of <see cref="T:Consensus.Membership.CommitteeRecord" /> instances that match the specified <paramref name="disId" />.
        /// </returns>
        System.Collections.Generic.IEnumerable<Consensus.Membership.CommitteeRecord> ICommitteeRepository.FetchAllByDisId(System.String disId)
        {
            return this.FetchAllByDisId(disId);
        }

        /// <summary>
        ///     Retrieves a collection of <see cref="T:Consensus.Membership.CommitteeRecord" /> instances from the data store.
        /// </summary>
        /// <param name="prodId">
        ///     The value which identifies the <see cref="!:CommitteeModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The collection of <see cref="T:Consensus.Membership.CommitteeRecord" /> instances that match the specified <paramref name="prodId" />.
        /// </returns>
        System.Collections.Generic.IEnumerable<Consensus.Membership.CommitteeRecord> ICommitteeRepository.FetchAllByProdId(System.String prodId)
        {
            return this.FetchAllByProdId(prodId);
        }

        /// <summary>
        ///     Retrieves a collection of <see cref="T:Consensus.Membership.CommitteeRecord" /> instances from the data store.
        /// </summary>
        /// <param name="brId">
        ///     The value which identifies the <see cref="!:CommitteeModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The collection of <see cref="T:Consensus.Membership.CommitteeRecord" /> instances that match the specified <paramref name="brId" />.
        /// </returns>
        System.Collections.Generic.IEnumerable<Consensus.Membership.CommitteeRecord> ICommitteeRepository.FetchAllByBrId(System.String brId)
        {
            return this.FetchAllByBrId(brId);
        }

        #endregion
    }
}
