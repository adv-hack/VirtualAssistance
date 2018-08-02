using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Linq;

namespace Consensus.Activities
{
    /// <summary>
    ///     Provides the persistence and retrieval of the <see cref="ComplaintRecord" /> instances in a Microsoft SQL Server database.
    /// </summary>
    /// <remarks>
    ///     THIS CODE HAS BEEN AUTOMATICALLY GENERATED USING THE CONSENSUS DEVELOPER TOOLS.
    ///     DO NOT EDIT THIS CODE AS ANY CUSTOM MODIFICATIONS WILL BE LOST UPON REGENERATION.
    /// </remarks>
    public partial class SqlServerComplaintRepository : SqlServerRepository<ComplaintRecord, String>, IComplaintRepository
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
            get { return "Complaint"; }
        }

        /// <summary>
        ///     Gets the name of the parameter which is used to specify the unique value that identifies each instance of a <see cref="ComplaintRecord" />.
        /// </summary>
        protected override String TypeKeyName
        {
            get { return "@PA_CMPL_ID"; }
        }

        /// <summary>
        ///     Gets the underlying table name that this repository sit over.
        /// </summary>
        public override String TableName
        {
            get { return "Complaint"; }
        }

        #endregion

        #region methods

        /// <summary>
        ///     Maps an <see cref="IDataRecord" /> to the specified <see cref="ComplaintRecord" />.
        /// </summary>
        /// <param name="dataRecord">
        ///     The <see cref="IDataRecord" /> to be mapped.
        /// </param>
        /// <param name="record">
        ///     The <see cref="ComplaintRecord" /> instance to be mapped to.
        /// </param>
        protected override void MapRecord(IDataRecord dataRecord, ComplaintRecord record)
        {
            record.Id = dataRecord["CMPL_ID"].ConvertTo<String>();
            record.AddBy = dataRecord["CMPL_ADD_BY"].ConvertTo<String>();
            record.AddDate = dataRecord["CMPL_ADD_DATE"].ConvertTo<DateTime?>();
            record.ModBy = dataRecord["CMPL_MOD_BY"].ConvertTo<String>();
            record.ModDate = dataRecord["CMPL_MOD_DATE"].ConvertTo<DateTime?>();
            record.RcvFrom = dataRecord["CMPL_RCV_FROM"].ConvertTo<String>();
            record.RcvDate = dataRecord["CMPL_RCV_DATE"].ConvertTo<DateTime?>();
            record.Title = dataRecord["CMPL_TITLE"].ConvertTo<String>();
            record.FromProleId = dataRecord["CMPL_FROM_PROLE_ID"].ConvertTo<String>();
            record.ReProleId = dataRecord["CMPL_RE_PROLE_ID"].ConvertTo<String>();
            record.MgrProleId = dataRecord["CMPL_MGR_PROLE_ID"].ConvertTo<String>();
            record.MedtrProleId = dataRecord["CMPL_MEDTR_PROLE_ID"].ConvertTo<String>();
            record.Status1 = dataRecord["CMPL_STATUS_1"].ConvertTo<String>();
            record.Status2 = dataRecord["CMPL_STATUS_2"].ConvertTo<String>();
            record.Status3 = dataRecord["CMPL_STATUS_3"].ConvertTo<String>();
            record.Type1 = dataRecord["CMPL_TYPE_1"].ConvertTo<String>();
            record.Type2 = dataRecord["CMPL_TYPE_2"].ConvertTo<String>();
            record.Type3 = dataRecord["CMPL_TYPE_3"].ConvertTo<String>();
            record.Scheme = dataRecord["CMPL_SCHEME"].ConvertTo<String>();
            record.DateOfCompl = dataRecord["CMPL_DATE_OF_COMPL"].ConvertTo<DateTime?>();
            record.DateRcvd = dataRecord["CMPL_DATE_RCVD"].ConvertTo<DateTime?>();
            record.DateEnd = dataRecord["CMPL_DATE_END"].ConvertTo<DateTime?>();
            record.DateNextAct = dataRecord["CMPL_DATE_NEXT_ACT"].ConvertTo<DateTime?>();
            record.Notes = dataRecord["CMPL_NOTES"].ConvertTo<String>();
            record.Value01 = dataRecord["CMPL_01_VALUE"].ConvertTo<String>();
            record.Value02 = dataRecord["CMPL_02_VALUE"].ConvertTo<String>();
            record.Value03 = dataRecord["CMPL_03_VALUE"].ConvertTo<String>();
            record.Value04 = dataRecord["CMPL_04_VALUE"].ConvertTo<String>();
            record.Value05 = dataRecord["CMPL_05_VALUE"].ConvertTo<String>();
            record.Value06 = dataRecord["CMPL_06_VALUE"].ConvertTo<String>();
            record.Value07 = dataRecord["CMPL_07_VALUE"].ConvertTo<String>();
            record.Value08 = dataRecord["CMPL_08_VALUE"].ConvertTo<String>();
            record.Value09 = dataRecord["CMPL_09_VALUE"].ConvertTo<String>();
            record.Value10 = dataRecord["CMPL_10_VALUE"].ConvertTo<String>();
            record.PmId = dataRecord["CMPL_PM_ID"].ConvertTo<String>();
            record.OurPerson = dataRecord["CMPL_OUR_PERSON"].ConvertTo<Byte?>();
            record.DetailsId = dataRecord["CMPL_DETAILS_ID"].ConvertTo<String>();
            record.ResolId = dataRecord["CMPL_RESOL_ID"].ConvertTo<String>();
        }

        /// <summary>
        ///     Sets the parameter values for the specified <paramref name="command" /> based on the specified <typeparamref name="TRecord" /> instance.
        /// </summary>
        /// <param name="command">
        ///     The <see cref="IDbCommand" /> containing the parameters to be mapped.
        /// </param>
        /// <param name="record">
        ///     The <see cref="ComplaintRecord" /> instance to be mapped.
        /// </param>
        /// <param name="useV6Logic">
        ///     Is the procedure being run an old version 6.x procedure? (the null value handling logic is different).
        /// </param>
        protected override void MapParametersIn(IDbCommand command, ComplaintRecord record, bool useV6Logic)
        {
            this.MapParameterIn(command, "@PA_CMPL_ID", record.Id);
            this.MapParameterIn(command, "@PA_CMPL_TITLE", record.Title);
            this.MapParameterIn(command, "@PA_CMPL_FROM_PROLE_ID", record.FromProleId);
            this.MapParameterIn(command, "@PA_CMPL_RE_PROLE_ID", record.ReProleId);
            this.MapParameterIn(command, "@PA_CMPL_MGR_PROLE_ID", record.MgrProleId);
            this.MapParameterIn(command, "@PA_CMPL_MEDTR_PROLE_ID", record.MedtrProleId);
            this.MapParameterIn(command, "@PA_CMPL_STATUS_1", record.Status1);
            this.MapParameterIn(command, "@PA_CMPL_STATUS_2", record.Status2);
            this.MapParameterIn(command, "@PA_CMPL_STATUS_3", record.Status3);
            this.MapParameterIn(command, "@PA_CMPL_TYPE_1", record.Type1);
            this.MapParameterIn(command, "@PA_CMPL_TYPE_2", record.Type2);
            this.MapParameterIn(command, "@PA_CMPL_TYPE_3", record.Type3);
            this.MapParameterIn(command, "@PA_CMPL_SCHEME", record.Scheme);
            this.MapParameterIn(command, "@PA_CMPL_DATE_OF_COMPL", record.DateOfCompl == DateTime.MinValue ? ( useV6Logic ? new DateTime?(new DateTime(1900,1,1)) : null ) : record.DateOfCompl);
            this.MapParameterIn(command, "@PA_CMPL_DATE_RCVD", record.DateRcvd == DateTime.MinValue ? ( useV6Logic ? new DateTime?(new DateTime(1900,1,1)) : null ) : record.DateRcvd);
            this.MapParameterIn(command, "@PA_CMPL_DATE_END", record.DateEnd == DateTime.MinValue ? ( useV6Logic ? new DateTime?(new DateTime(1900,1,1)) : null ) : record.DateEnd);
            this.MapParameterIn(command, "@PA_CMPL_DATE_NEXT_ACT", record.DateNextAct == DateTime.MinValue ? ( useV6Logic ? new DateTime?(new DateTime(1900,1,1)) : null ) : record.DateNextAct);
            this.MapParameterIn(command, "@PA_CMPL_NOTES", record.Notes);
            this.MapParameterIn(command, "@PA_CMPL_01_VALUE", record.Value01);
            this.MapParameterIn(command, "@PA_CMPL_02_VALUE", record.Value02);
            this.MapParameterIn(command, "@PA_CMPL_03_VALUE", record.Value03);
            this.MapParameterIn(command, "@PA_CMPL_04_VALUE", record.Value04);
            this.MapParameterIn(command, "@PA_CMPL_05_VALUE", record.Value05);
            this.MapParameterIn(command, "@PA_CMPL_06_VALUE", record.Value06);
            this.MapParameterIn(command, "@PA_CMPL_07_VALUE", record.Value07);
            this.MapParameterIn(command, "@PA_CMPL_08_VALUE", record.Value08);
            this.MapParameterIn(command, "@PA_CMPL_09_VALUE", record.Value09);
            this.MapParameterIn(command, "@PA_CMPL_10_VALUE", record.Value10);
            this.MapParameterIn(command, "@PA_CMPL_PM_ID", record.PmId);
            this.MapParameterIn(command, "@PA_CMPL_OUR_PERSON", record.OurPerson);
            this.MapParameterIn(command, "@PA_CMPL_DETAILS_ID", record.DetailsId);
            this.MapParameterIn(command, "@PA_CMPL_RESOL_ID", record.ResolId);
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
        ///     The <see cref="ComplaintRecord" /> instance to be updated.
        /// </param>
        protected override void MapParametersOut(IDbCommand command, ComplaintRecord record)
        {
            record.Id = this.MapParameterOut(command, "@PA_CMPL_ID", record.Id);
            record.Title = this.MapParameterOut(command, "@PA_CMPL_TITLE", record.Title);
            record.FromProleId = this.MapParameterOut(command, "@PA_CMPL_FROM_PROLE_ID", record.FromProleId);
            record.ReProleId = this.MapParameterOut(command, "@PA_CMPL_RE_PROLE_ID", record.ReProleId);
            record.MgrProleId = this.MapParameterOut(command, "@PA_CMPL_MGR_PROLE_ID", record.MgrProleId);
            record.MedtrProleId = this.MapParameterOut(command, "@PA_CMPL_MEDTR_PROLE_ID", record.MedtrProleId);
            record.Status1 = this.MapParameterOut(command, "@PA_CMPL_STATUS_1", record.Status1);
            record.Status2 = this.MapParameterOut(command, "@PA_CMPL_STATUS_2", record.Status2);
            record.Status3 = this.MapParameterOut(command, "@PA_CMPL_STATUS_3", record.Status3);
            record.Type1 = this.MapParameterOut(command, "@PA_CMPL_TYPE_1", record.Type1);
            record.Type2 = this.MapParameterOut(command, "@PA_CMPL_TYPE_2", record.Type2);
            record.Type3 = this.MapParameterOut(command, "@PA_CMPL_TYPE_3", record.Type3);
            record.Scheme = this.MapParameterOut(command, "@PA_CMPL_SCHEME", record.Scheme);
            record.DateOfCompl = this.MapParameterOut(command, "@PA_CMPL_DATE_OF_COMPL", record.DateOfCompl);
            record.DateRcvd = this.MapParameterOut(command, "@PA_CMPL_DATE_RCVD", record.DateRcvd);
            record.DateEnd = this.MapParameterOut(command, "@PA_CMPL_DATE_END", record.DateEnd);
            record.DateNextAct = this.MapParameterOut(command, "@PA_CMPL_DATE_NEXT_ACT", record.DateNextAct);
            record.Notes = this.MapParameterOut(command, "@PA_CMPL_NOTES", record.Notes);
            record.Value01 = this.MapParameterOut(command, "@PA_CMPL_01_VALUE", record.Value01);
            record.Value02 = this.MapParameterOut(command, "@PA_CMPL_02_VALUE", record.Value02);
            record.Value03 = this.MapParameterOut(command, "@PA_CMPL_03_VALUE", record.Value03);
            record.Value04 = this.MapParameterOut(command, "@PA_CMPL_04_VALUE", record.Value04);
            record.Value05 = this.MapParameterOut(command, "@PA_CMPL_05_VALUE", record.Value05);
            record.Value06 = this.MapParameterOut(command, "@PA_CMPL_06_VALUE", record.Value06);
            record.Value07 = this.MapParameterOut(command, "@PA_CMPL_07_VALUE", record.Value07);
            record.Value08 = this.MapParameterOut(command, "@PA_CMPL_08_VALUE", record.Value08);
            record.Value09 = this.MapParameterOut(command, "@PA_CMPL_09_VALUE", record.Value09);
            record.Value10 = this.MapParameterOut(command, "@PA_CMPL_10_VALUE", record.Value10);
            record.PmId = this.MapParameterOut(command, "@PA_CMPL_PM_ID", record.PmId);
            record.OurPerson = this.MapParameterOut(command, "@PA_CMPL_OUR_PERSON", record.OurPerson);
            record.DetailsId = this.MapParameterOut(command, "@PA_CMPL_DETAILS_ID", record.DetailsId);
            record.ResolId = this.MapParameterOut(command, "@PA_CMPL_RESOL_ID", record.ResolId);
            record.Id = this.MapParameterOut(command, "@PA_RETURN_ID", record.Id);
        }

        /// <summary>
        ///     Retrieves a collection of <see cref="ComplaintRecord" /> instances from the data store.
        /// </summary>
        /// <param name="fromProleId">
        ///     The value which identifies the <see cref='ComplaintModel' /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The collection of <see cref="ComplaintRecord" /> instances that match the specified <paramref name='fromProleId' />.
        /// </returns>
        public IEnumerable<ComplaintRecord> FetchAllByFromProleId(String fromProleId)
        {
            DbCommand command = this.GetStoredProcedure(SqlServerOperation.FetchAll, "FromProleId");
            this.MapParameterIn(command, "@PA_CMPL_FROM_PROLE_ID", fromProleId);
            return this.Execute(command);
        }

        /// <summary>
        ///     Retrieves a collection of <see cref="ComplaintRecord" /> instances from the data store.
        /// </summary>
        /// <param name="reProleId">
        ///     The value which identifies the <see cref='ComplaintModel' /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The collection of <see cref="ComplaintRecord" /> instances that match the specified <paramref name='reProleId' />.
        /// </returns>
        public IEnumerable<ComplaintRecord> FetchAllByReProleId(String reProleId)
        {
            DbCommand command = this.GetStoredProcedure(SqlServerOperation.FetchAll, "ReProleId");
            this.MapParameterIn(command, "@PA_CMPL_RE_PROLE_ID", reProleId);
            return this.Execute(command);
        }

        /// <summary>
        ///     Retrieves a collection of <see cref="ComplaintRecord" /> instances from the data store.
        /// </summary>
        /// <param name="mgrProleId">
        ///     The value which identifies the <see cref='ComplaintModel' /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The collection of <see cref="ComplaintRecord" /> instances that match the specified <paramref name='mgrProleId' />.
        /// </returns>
        public IEnumerable<ComplaintRecord> FetchAllByMgrProleId(String mgrProleId)
        {
            DbCommand command = this.GetStoredProcedure(SqlServerOperation.FetchAll, "MgrProleId");
            this.MapParameterIn(command, "@PA_CMPL_MGR_PROLE_ID", mgrProleId);
            return this.Execute(command);
        }

        /// <summary>
        ///     Retrieves a collection of <see cref="ComplaintRecord" /> instances from the data store.
        /// </summary>
        /// <param name="medtrProleId">
        ///     The value which identifies the <see cref='ComplaintModel' /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The collection of <see cref="ComplaintRecord" /> instances that match the specified <paramref name='medtrProleId' />.
        /// </returns>
        public IEnumerable<ComplaintRecord> FetchAllByMedtrProleId(String medtrProleId)
        {
            DbCommand command = this.GetStoredProcedure(SqlServerOperation.FetchAll, "MedtrProleId");
            this.MapParameterIn(command, "@PA_CMPL_MEDTR_PROLE_ID", medtrProleId);
            return this.Execute(command);
        }

        /// <summary>
        ///     Retrieves a collection of <see cref="ComplaintRecord" /> instances from the data store.
        /// </summary>
        /// <param name="pmId">
        ///     The value which identifies the <see cref='ComplaintModel' /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The collection of <see cref="ComplaintRecord" /> instances that match the specified <paramref name='pmId' />.
        /// </returns>
        public IEnumerable<ComplaintRecord> FetchAllByPmId(String pmId)
        {
            DbCommand command = this.GetStoredProcedure(SqlServerOperation.FetchAll, "PmId");
            this.MapParameterIn(command, "@PA_CMPL_PM_ID", pmId);
            return this.Execute(command);
        }

        /// <summary>
        ///     Retrieves a collection of <see cref="ComplaintRecord" /> instances from the data store.
        /// </summary>
        /// <param name="detailsId">
        ///     The value which identifies the <see cref='ComplaintModel' /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The collection of <see cref="ComplaintRecord" /> instances that match the specified <paramref name='detailsId' />.
        /// </returns>
        public IEnumerable<ComplaintRecord> FetchAllByDetailsId(String detailsId)
        {
            DbCommand command = this.GetStoredProcedure(SqlServerOperation.FetchAll, "DetailsId");
            this.MapParameterIn(command, "@PA_CMPL_DETAILS_ID", detailsId);
            return this.Execute(command);
        }

        #endregion

        #region implementations

        /// <summary>
        ///     Gets the underlying table name that this repository sit over.
        /// </summary>
        System.String IComplaintRepository.TableName
        {
            get { return this.TableName; }
        }

        /// <summary>
        ///     Retrieves a collection of <see cref="T:Consensus.Activities.ComplaintRecord" /> instances from the data store.
        /// </summary>
        /// <param name="fromProleId">
        ///     The value which identifies the <see cref="!:ComplaintModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The collection of <see cref="T:Consensus.Activities.ComplaintRecord" /> instances that match the specified <paramref name="fromProleId" />.
        /// </returns>
        System.Collections.Generic.IEnumerable<Consensus.Activities.ComplaintRecord> IComplaintRepository.FetchAllByFromProleId(System.String fromProleId)
        {
            return this.FetchAllByFromProleId(fromProleId);
        }

        /// <summary>
        ///     Retrieves a collection of <see cref="T:Consensus.Activities.ComplaintRecord" /> instances from the data store.
        /// </summary>
        /// <param name="reProleId">
        ///     The value which identifies the <see cref="!:ComplaintModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The collection of <see cref="T:Consensus.Activities.ComplaintRecord" /> instances that match the specified <paramref name="reProleId" />.
        /// </returns>
        System.Collections.Generic.IEnumerable<Consensus.Activities.ComplaintRecord> IComplaintRepository.FetchAllByReProleId(System.String reProleId)
        {
            return this.FetchAllByReProleId(reProleId);
        }

        /// <summary>
        ///     Retrieves a collection of <see cref="T:Consensus.Activities.ComplaintRecord" /> instances from the data store.
        /// </summary>
        /// <param name="mgrProleId">
        ///     The value which identifies the <see cref="!:ComplaintModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The collection of <see cref="T:Consensus.Activities.ComplaintRecord" /> instances that match the specified <paramref name="mgrProleId" />.
        /// </returns>
        System.Collections.Generic.IEnumerable<Consensus.Activities.ComplaintRecord> IComplaintRepository.FetchAllByMgrProleId(System.String mgrProleId)
        {
            return this.FetchAllByMgrProleId(mgrProleId);
        }

        /// <summary>
        ///     Retrieves a collection of <see cref="T:Consensus.Activities.ComplaintRecord" /> instances from the data store.
        /// </summary>
        /// <param name="medtrProleId">
        ///     The value which identifies the <see cref="!:ComplaintModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The collection of <see cref="T:Consensus.Activities.ComplaintRecord" /> instances that match the specified <paramref name="medtrProleId" />.
        /// </returns>
        System.Collections.Generic.IEnumerable<Consensus.Activities.ComplaintRecord> IComplaintRepository.FetchAllByMedtrProleId(System.String medtrProleId)
        {
            return this.FetchAllByMedtrProleId(medtrProleId);
        }

        /// <summary>
        ///     Retrieves a collection of <see cref="T:Consensus.Activities.ComplaintRecord" /> instances from the data store.
        /// </summary>
        /// <param name="pmId">
        ///     The value which identifies the <see cref="!:ComplaintModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The collection of <see cref="T:Consensus.Activities.ComplaintRecord" /> instances that match the specified <paramref name="pmId" />.
        /// </returns>
        System.Collections.Generic.IEnumerable<Consensus.Activities.ComplaintRecord> IComplaintRepository.FetchAllByPmId(System.String pmId)
        {
            return this.FetchAllByPmId(pmId);
        }

        /// <summary>
        ///     Retrieves a collection of <see cref="T:Consensus.Activities.ComplaintRecord" /> instances from the data store.
        /// </summary>
        /// <param name="detailsId">
        ///     The value which identifies the <see cref="!:ComplaintModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The collection of <see cref="T:Consensus.Activities.ComplaintRecord" /> instances that match the specified <paramref name="detailsId" />.
        /// </returns>
        System.Collections.Generic.IEnumerable<Consensus.Activities.ComplaintRecord> IComplaintRepository.FetchAllByDetailsId(System.String detailsId)
        {
            return this.FetchAllByDetailsId(detailsId);
        }

        #endregion
    }
}
