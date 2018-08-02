using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Linq;

namespace Consensus.Activities
{
    /// <summary>
    ///     Provides the persistence and retrieval of the <see cref="HelpdeskRecord" /> instances in a Microsoft SQL Server database.
    /// </summary>
    /// <remarks>
    ///     THIS CODE HAS BEEN AUTOMATICALLY GENERATED USING THE CONSENSUS DEVELOPER TOOLS.
    ///     DO NOT EDIT THIS CODE AS ANY CUSTOM MODIFICATIONS WILL BE LOST UPON REGENERATION.
    /// </remarks>
    public partial class SqlServerHelpdeskRepository : SqlServerRepository<HelpdeskRecord, String>, IHelpdeskRepository
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
            get { return "Helpdesk"; }
        }

        /// <summary>
        ///     Gets the name of the parameter which is used to specify the unique value that identifies each instance of a <see cref="HelpdeskRecord" />.
        /// </summary>
        protected override String TypeKeyName
        {
            get { return "@PA_HD_ID"; }
        }

        /// <summary>
        ///     Gets the underlying table name that this repository sit over.
        /// </summary>
        public override String TableName
        {
            get { return "Helpdesk"; }
        }

        #endregion

        #region methods

        /// <summary>
        ///     Maps an <see cref="IDataRecord" /> to the specified <see cref="HelpdeskRecord" />.
        /// </summary>
        /// <param name="dataRecord">
        ///     The <see cref="IDataRecord" /> to be mapped.
        /// </param>
        /// <param name="record">
        ///     The <see cref="HelpdeskRecord" /> instance to be mapped to.
        /// </param>
        protected override void MapRecord(IDataRecord dataRecord, HelpdeskRecord record)
        {
            record.Id = dataRecord["HD_ID"].ConvertTo<String>();
            record.Lock = dataRecord["HD_LOCK"].ConvertTo<String>();
            record.AddDate = dataRecord["HD_ADD_DATE"].ConvertTo<DateTime?>();
            record.AddBy = dataRecord["HD_ADD_BY"].ConvertTo<String>();
            record.ModDate = dataRecord["HD_MOD_DATE"].ConvertTo<DateTime?>();
            record.ModBy = dataRecord["HD_MOD_BY"].ConvertTo<String>();
            record.RcvDate = dataRecord["HD_RCV_DATE"].ConvertTo<DateTime?>();
            record.RcvFrom = dataRecord["HD_RCV_FROM"].ConvertTo<String>();
            record.OrgId = dataRecord["HD_ORG_ID"].ConvertTo<String>();
            record.OrgName = dataRecord["HD_ORG_NAME"].ConvertTo<String>();
            record.ProleId = dataRecord["HD_PROLE_ID"].ConvertTo<String>();
            record.PnName = dataRecord["HD_PN_NAME"].ConvertTo<String>();
            record.SerialNo = dataRecord["HD_SERIAL_NO"].ConvertTo<String>();
            record.InId = dataRecord["HD_IN_ID"].ConvertTo<String>();
            record.ProdCode = dataRecord["HD_PROD_CODE"].ConvertTo<String>();
            record.ProdId = dataRecord["HD_PROD_ID"].ConvertTo<String>();
            record.WarrDate = dataRecord["HD_WARR_DATE"].ConvertTo<DateTime?>();
            record.ContrRef = dataRecord["HD_CONTR_REF"].ConvertTo<String>();
            record.ContType = dataRecord["HD_CONT_TYPE"].ConvertTo<String>();
            record.ContDate = dataRecord["HD_CONT_DATE"].ConvertTo<DateTime?>();
            record.GivenTo = dataRecord["HD_GIVEN_TO"].ConvertTo<String>();
            record.GivenToId = dataRecord["HD_GIVEN_TO_ID"].ConvertTo<String>();
            record.FixedDate = dataRecord["HD_FIXED_DATE"].ConvertTo<DateTime?>();
            record.FixedTime = dataRecord["HD_FIXED_TIME"].ConvertTo<Double?>();
            record.Status = dataRecord["HD_STATUS"].ConvertTo<String>();
            record.DetailsId = dataRecord["HD_DETAILS_ID"].ConvertTo<String>();
            record.FixId = dataRecord["HD_FIX_ID"].ConvertTo<String>();
            record.Category = dataRecord["HD_CATEGORY"].ConvertTo<String>();
            record.FixCat = dataRecord["HD_FIX_CAT"].ConvertTo<String>();
            record.CallDate = dataRecord["HD_CALL_DATE"].ConvertTo<DateTime?>();
            record.CallTime = dataRecord["HD_CALL_TIME"].ConvertTo<DateTime?>();
            record.CallerPhone = dataRecord["HD_CALLER_PHONE"].ConvertTo<String>();
            record.FaultType = dataRecord["HD_FAULT_TYPE"].ConvertTo<String>();
            record.ProdName = dataRecord["HD_PROD_NAME"].ConvertTo<String>();
            record.Severity = dataRecord["HD_SEVERITY"].ConvertTo<String>();
            record.ProjRef = dataRecord["HD_PROJ_REF"].ConvertTo<String>();
            record.ProjId = dataRecord["HD_PROJ_ID"].ConvertTo<String>();
            record.ActId = dataRecord["HD_ACT_ID"].ConvertTo<String>();
            record.HistoryTxt = dataRecord["HD_HISTORY_TXT"].ConvertTo<String>();
            record.Title = dataRecord["HD_TITLE"].ConvertTo<String>();
            record.CustRef = dataRecord["HD_CUST_REF"].ConvertTo<String>();
            record.CustAcpt = dataRecord["HD_CUST_ACPT"].ConvertTo<String>();
            record.RptDate = dataRecord["HD_RPT_DATE"].ConvertTo<DateTime?>();
            record.TrgRspDate = dataRecord["HD_TRG_RSP_DATE"].ConvertTo<DateTime?>();
            record.ActRspDate = dataRecord["HD_ACT_RSP_DATE"].ConvertTo<DateTime?>();
            record.TrgTpfixD = dataRecord["HD_TRG_TPFIX_D"].ConvertTo<DateTime?>();
            record.ActTpfixD = dataRecord["HD_ACT_TPFIX_D"].ConvertTo<DateTime?>();
            record.TrgActfixD = dataRecord["HD_TRG_ACTFIX_D"].ConvertTo<DateTime?>();
            record.SucId = dataRecord["HD_SUC_ID"].ConvertTo<String>();
            record.AccDate = dataRecord["HD_ACC_DATE"].ConvertTo<DateTime?>();
            record.ResolvedVer = dataRecord["HD_RESOLVED_VER"].ConvertTo<String>();
            record.EstTime = dataRecord["HD_EST_TIME"].ConvertTo<Double?>();
            record.Type = dataRecord["HD_TYPE"].ConvertTo<Byte?>();
            record.WipId = dataRecord["HD_WIP_ID"].ConvertTo<String>();
            record.ResDate = dataRecord["HD_RES_DATE"].ConvertTo<DateTime?>();
            record.SelcoSpId = dataRecord["HD_SELCO_SP_ID"].ConvertTo<String>();
            record.Group = dataRecord["HD_GROUP"].ConvertTo<String>();
            record.Assigned = dataRecord["HD_ASSIGNED"].ConvertTo<Byte?>();
            record.Read = dataRecord["HD_READ"].ConvertTo<Byte?>();
            record.ResolutionId = dataRecord["HD_RESOLUTION_ID"].ConvertTo<String>();
            record.Version = dataRecord["HD_VERSION"].ConvertTo<String>();
            record.PmId = dataRecord["HD_PM_ID"].ConvertTo<String>();
            record.BuildVersion = dataRecord["HD_BUILD_VERSION"].ConvertTo<String>();
        }

        /// <summary>
        ///     Sets the parameter values for the specified <paramref name="command" /> based on the specified <typeparamref name="TRecord" /> instance.
        /// </summary>
        /// <param name="command">
        ///     The <see cref="IDbCommand" /> containing the parameters to be mapped.
        /// </param>
        /// <param name="record">
        ///     The <see cref="HelpdeskRecord" /> instance to be mapped.
        /// </param>
        /// <param name="useV6Logic">
        ///     Is the procedure being run an old version 6.x procedure? (the null value handling logic is different).
        /// </param>
        protected override void MapParametersIn(IDbCommand command, HelpdeskRecord record, bool useV6Logic)
        {
            this.MapParameterIn(command, "@PA_HD_ID", record.Id);
            this.MapParameterIn(command, "@PA_HD_LOCK", record.Lock);
            this.MapParameterIn(command, "@PA_HD_ORG_ID", record.OrgId);
            this.MapParameterIn(command, "@PA_HD_ORG_NAME", record.OrgName);
            this.MapParameterIn(command, "@PA_HD_PROLE_ID", record.ProleId);
            this.MapParameterIn(command, "@PA_HD_PN_NAME", record.PnName);
            this.MapParameterIn(command, "@PA_HD_SERIAL_NO", record.SerialNo);
            this.MapParameterIn(command, "@PA_HD_IN_ID", record.InId);
            this.MapParameterIn(command, "@PA_HD_PROD_CODE", record.ProdCode);
            this.MapParameterIn(command, "@PA_HD_PROD_ID", record.ProdId);
            this.MapParameterIn(command, "@PA_HD_WARR_DATE", record.WarrDate == DateTime.MinValue ? ( useV6Logic ? new DateTime?(new DateTime(1900,1,1)) : null ) : record.WarrDate);
            this.MapParameterIn(command, "@PA_HD_CONTR_REF", record.ContrRef);
            this.MapParameterIn(command, "@PA_HD_CONT_TYPE", record.ContType);
            this.MapParameterIn(command, "@PA_HD_CONT_DATE", record.ContDate == DateTime.MinValue ? ( useV6Logic ? new DateTime?(new DateTime(1900,1,1)) : null ) : record.ContDate);
            this.MapParameterIn(command, "@PA_HD_GIVEN_TO", record.GivenTo);
            this.MapParameterIn(command, "@PA_HD_GIVEN_TO_ID", record.GivenToId);
            this.MapParameterIn(command, "@PA_HD_FIXED_DATE", record.FixedDate == DateTime.MinValue ? ( useV6Logic ? new DateTime?(new DateTime(1900,1,1)) : null ) : record.FixedDate);
            this.MapParameterIn(command, "@PA_HD_FIXED_TIME", record.FixedTime == Double.MinValue ? ( useV6Logic ? new Double?(0) : null ) : record.FixedTime);
            this.MapParameterIn(command, "@PA_HD_STATUS", record.Status);
            this.MapParameterIn(command, "@PA_HD_DETAILS_ID", record.DetailsId);
            this.MapParameterIn(command, "@PA_HD_FIX_ID", record.FixId);
            this.MapParameterIn(command, "@PA_HD_CATEGORY", record.Category);
            this.MapParameterIn(command, "@PA_HD_FIX_CAT", record.FixCat);
            this.MapParameterIn(command, "@PA_HD_CALL_DATE", record.CallDate == DateTime.MinValue ? ( useV6Logic ? new DateTime?(new DateTime(1900,1,1)) : null ) : record.CallDate);
            this.MapParameterIn(command, "@PA_HD_CALL_TIME", record.CallTime == DateTime.MinValue ? ( useV6Logic ? new DateTime?(new DateTime(1900,1,1)) : null ) : record.CallTime);
            this.MapParameterIn(command, "@PA_HD_CALLER_PHONE", record.CallerPhone);
            this.MapParameterIn(command, "@PA_HD_FAULT_TYPE", record.FaultType);
            this.MapParameterIn(command, "@PA_HD_PROD_NAME", record.ProdName);
            this.MapParameterIn(command, "@PA_HD_SEVERITY", record.Severity);
            this.MapParameterIn(command, "@PA_HD_PROJ_REF", record.ProjRef);
            this.MapParameterIn(command, "@PA_HD_PROJ_ID", record.ProjId);
            this.MapParameterIn(command, "@PA_HD_ACT_ID", record.ActId);
            this.MapParameterIn(command, "@PA_HD_HISTORY_TXT", record.HistoryTxt);
            this.MapParameterIn(command, "@PA_HD_TITLE", record.Title);
            this.MapParameterIn(command, "@PA_HD_CUST_REF", record.CustRef);
            this.MapParameterIn(command, "@PA_HD_CUST_ACPT", record.CustAcpt);
            this.MapParameterIn(command, "@PA_HD_RPT_DATE", record.RptDate == DateTime.MinValue ? ( useV6Logic ? new DateTime?(new DateTime(1900,1,1)) : null ) : record.RptDate);
            this.MapParameterIn(command, "@PA_HD_TRG_RSP_DATE", record.TrgRspDate == DateTime.MinValue ? ( useV6Logic ? new DateTime?(new DateTime(1900,1,1)) : null ) : record.TrgRspDate);
            this.MapParameterIn(command, "@PA_HD_ACT_RSP_DATE", record.ActRspDate == DateTime.MinValue ? ( useV6Logic ? new DateTime?(new DateTime(1900,1,1)) : null ) : record.ActRspDate);
            this.MapParameterIn(command, "@PA_HD_TRG_TPFIX_D", record.TrgTpfixD == DateTime.MinValue ? ( useV6Logic ? new DateTime?(new DateTime(1900,1,1)) : null ) : record.TrgTpfixD);
            this.MapParameterIn(command, "@PA_HD_ACT_TPFIX_D", record.ActTpfixD == DateTime.MinValue ? ( useV6Logic ? new DateTime?(new DateTime(1900,1,1)) : null ) : record.ActTpfixD);
            this.MapParameterIn(command, "@PA_HD_TRG_ACTFIX_D", record.TrgActfixD == DateTime.MinValue ? ( useV6Logic ? new DateTime?(new DateTime(1900,1,1)) : null ) : record.TrgActfixD);
            this.MapParameterIn(command, "@PA_HD_SUC_ID", record.SucId);
            this.MapParameterIn(command, "@PA_HD_ACC_DATE", record.AccDate == DateTime.MinValue ? ( useV6Logic ? new DateTime?(new DateTime(1900,1,1)) : null ) : record.AccDate);
            this.MapParameterIn(command, "@PA_HD_RESOLVED_VER", record.ResolvedVer);
            this.MapParameterIn(command, "@PA_HD_EST_TIME", record.EstTime == Double.MinValue ? ( useV6Logic ? new Double?(0) : null ) : record.EstTime);
            this.MapParameterIn(command, "@PA_HD_TYPE", record.Type);
            this.MapParameterIn(command, "@PA_HD_WIP_ID", record.WipId);
            this.MapParameterIn(command, "@PA_HD_RES_DATE", record.ResDate == DateTime.MinValue ? ( useV6Logic ? new DateTime?(new DateTime(1900,1,1)) : null ) : record.ResDate);
            this.MapParameterIn(command, "@PA_HD_SELCO_SP_ID", record.SelcoSpId);
            this.MapParameterIn(command, "@PA_HD_GROUP", record.Group);
            this.MapParameterIn(command, "@PA_HD_ASSIGNED", record.Assigned);
            this.MapParameterIn(command, "@PA_HD_READ", record.Read);
            this.MapParameterIn(command, "@PA_HD_RESOLUTION_ID", record.ResolutionId);
            this.MapParameterIn(command, "@PA_HD_VERSION", record.Version);
            this.MapParameterIn(command, "@PA_HD_PM_ID", record.PmId);
            this.MapParameterIn(command, "@PA_HD_BUILD_VERSION", record.BuildVersion);
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
        ///     The <see cref="HelpdeskRecord" /> instance to be updated.
        /// </param>
        protected override void MapParametersOut(IDbCommand command, HelpdeskRecord record)
        {
            record.Id = this.MapParameterOut(command, "@PA_HD_ID", record.Id);
            record.Lock = this.MapParameterOut(command, "@PA_HD_LOCK", record.Lock);
            record.OrgId = this.MapParameterOut(command, "@PA_HD_ORG_ID", record.OrgId);
            record.OrgName = this.MapParameterOut(command, "@PA_HD_ORG_NAME", record.OrgName);
            record.ProleId = this.MapParameterOut(command, "@PA_HD_PROLE_ID", record.ProleId);
            record.PnName = this.MapParameterOut(command, "@PA_HD_PN_NAME", record.PnName);
            record.SerialNo = this.MapParameterOut(command, "@PA_HD_SERIAL_NO", record.SerialNo);
            record.InId = this.MapParameterOut(command, "@PA_HD_IN_ID", record.InId);
            record.ProdCode = this.MapParameterOut(command, "@PA_HD_PROD_CODE", record.ProdCode);
            record.ProdId = this.MapParameterOut(command, "@PA_HD_PROD_ID", record.ProdId);
            record.WarrDate = this.MapParameterOut(command, "@PA_HD_WARR_DATE", record.WarrDate);
            record.ContrRef = this.MapParameterOut(command, "@PA_HD_CONTR_REF", record.ContrRef);
            record.ContType = this.MapParameterOut(command, "@PA_HD_CONT_TYPE", record.ContType);
            record.ContDate = this.MapParameterOut(command, "@PA_HD_CONT_DATE", record.ContDate);
            record.GivenTo = this.MapParameterOut(command, "@PA_HD_GIVEN_TO", record.GivenTo);
            record.GivenToId = this.MapParameterOut(command, "@PA_HD_GIVEN_TO_ID", record.GivenToId);
            record.FixedDate = this.MapParameterOut(command, "@PA_HD_FIXED_DATE", record.FixedDate);
            record.FixedTime = this.MapParameterOut(command, "@PA_HD_FIXED_TIME", record.FixedTime);
            record.Status = this.MapParameterOut(command, "@PA_HD_STATUS", record.Status);
            record.DetailsId = this.MapParameterOut(command, "@PA_HD_DETAILS_ID", record.DetailsId);
            record.FixId = this.MapParameterOut(command, "@PA_HD_FIX_ID", record.FixId);
            record.Category = this.MapParameterOut(command, "@PA_HD_CATEGORY", record.Category);
            record.FixCat = this.MapParameterOut(command, "@PA_HD_FIX_CAT", record.FixCat);
            record.CallDate = this.MapParameterOut(command, "@PA_HD_CALL_DATE", record.CallDate);
            record.CallTime = this.MapParameterOut(command, "@PA_HD_CALL_TIME", record.CallTime);
            record.CallerPhone = this.MapParameterOut(command, "@PA_HD_CALLER_PHONE", record.CallerPhone);
            record.FaultType = this.MapParameterOut(command, "@PA_HD_FAULT_TYPE", record.FaultType);
            record.ProdName = this.MapParameterOut(command, "@PA_HD_PROD_NAME", record.ProdName);
            record.Severity = this.MapParameterOut(command, "@PA_HD_SEVERITY", record.Severity);
            record.ProjRef = this.MapParameterOut(command, "@PA_HD_PROJ_REF", record.ProjRef);
            record.ProjId = this.MapParameterOut(command, "@PA_HD_PROJ_ID", record.ProjId);
            record.ActId = this.MapParameterOut(command, "@PA_HD_ACT_ID", record.ActId);
            record.HistoryTxt = this.MapParameterOut(command, "@PA_HD_HISTORY_TXT", record.HistoryTxt);
            record.Title = this.MapParameterOut(command, "@PA_HD_TITLE", record.Title);
            record.CustRef = this.MapParameterOut(command, "@PA_HD_CUST_REF", record.CustRef);
            record.CustAcpt = this.MapParameterOut(command, "@PA_HD_CUST_ACPT", record.CustAcpt);
            record.RptDate = this.MapParameterOut(command, "@PA_HD_RPT_DATE", record.RptDate);
            record.TrgRspDate = this.MapParameterOut(command, "@PA_HD_TRG_RSP_DATE", record.TrgRspDate);
            record.ActRspDate = this.MapParameterOut(command, "@PA_HD_ACT_RSP_DATE", record.ActRspDate);
            record.TrgTpfixD = this.MapParameterOut(command, "@PA_HD_TRG_TPFIX_D", record.TrgTpfixD);
            record.ActTpfixD = this.MapParameterOut(command, "@PA_HD_ACT_TPFIX_D", record.ActTpfixD);
            record.TrgActfixD = this.MapParameterOut(command, "@PA_HD_TRG_ACTFIX_D", record.TrgActfixD);
            record.SucId = this.MapParameterOut(command, "@PA_HD_SUC_ID", record.SucId);
            record.AccDate = this.MapParameterOut(command, "@PA_HD_ACC_DATE", record.AccDate);
            record.ResolvedVer = this.MapParameterOut(command, "@PA_HD_RESOLVED_VER", record.ResolvedVer);
            record.EstTime = this.MapParameterOut(command, "@PA_HD_EST_TIME", record.EstTime);
            record.Type = this.MapParameterOut(command, "@PA_HD_TYPE", record.Type);
            record.WipId = this.MapParameterOut(command, "@PA_HD_WIP_ID", record.WipId);
            record.ResDate = this.MapParameterOut(command, "@PA_HD_RES_DATE", record.ResDate);
            record.SelcoSpId = this.MapParameterOut(command, "@PA_HD_SELCO_SP_ID", record.SelcoSpId);
            record.Group = this.MapParameterOut(command, "@PA_HD_GROUP", record.Group);
            record.Assigned = this.MapParameterOut(command, "@PA_HD_ASSIGNED", record.Assigned);
            record.Read = this.MapParameterOut(command, "@PA_HD_READ", record.Read);
            record.ResolutionId = this.MapParameterOut(command, "@PA_HD_RESOLUTION_ID", record.ResolutionId);
            record.Version = this.MapParameterOut(command, "@PA_HD_VERSION", record.Version);
            record.PmId = this.MapParameterOut(command, "@PA_HD_PM_ID", record.PmId);
            record.BuildVersion = this.MapParameterOut(command, "@PA_HD_BUILD_VERSION", record.BuildVersion);
            record.Id = this.MapParameterOut(command, "@PA_RETURN_ID", record.Id);
        }

        /// <summary>
        ///     Retrieves a collection of <see cref="HelpdeskRecord" /> instances from the data store.
        /// </summary>
        /// <param name="orgId">
        ///     The value which identifies the <see cref='HelpdeskModel' /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The collection of <see cref="HelpdeskRecord" /> instances that match the specified <paramref name='orgId' />.
        /// </returns>
        public IEnumerable<HelpdeskRecord> FetchAllByOrgId(String orgId)
        {
            DbCommand command = this.GetStoredProcedure(SqlServerOperation.FetchAll, "OrgId");
            this.MapParameterIn(command, "@PA_HD_ORG_ID", orgId);
            return this.Execute(command);
        }

        /// <summary>
        ///     Retrieves a collection of <see cref="HelpdeskRecord" /> instances from the data store.
        /// </summary>
        /// <param name="proleId">
        ///     The value which identifies the <see cref='HelpdeskModel' /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The collection of <see cref="HelpdeskRecord" /> instances that match the specified <paramref name='proleId' />.
        /// </returns>
        public IEnumerable<HelpdeskRecord> FetchAllByProleId(String proleId)
        {
            DbCommand command = this.GetStoredProcedure(SqlServerOperation.FetchAll, "ProleId");
            this.MapParameterIn(command, "@PA_HD_PROLE_ID", proleId);
            return this.Execute(command);
        }

        /// <summary>
        ///     Retrieves a collection of <see cref="HelpdeskRecord" /> instances from the data store.
        /// </summary>
        /// <param name="givenToId">
        ///     The value which identifies the <see cref='HelpdeskModel' /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The collection of <see cref="HelpdeskRecord" /> instances that match the specified <paramref name='givenToId' />.
        /// </returns>
        public IEnumerable<HelpdeskRecord> FetchAllByGivenToId(String givenToId)
        {
            DbCommand command = this.GetStoredProcedure(SqlServerOperation.FetchAll, "GivenToId");
            this.MapParameterIn(command, "@PA_HD_GIVEN_TO_ID", givenToId);
            return this.Execute(command);
        }

        /// <summary>
        ///     Retrieves a collection of <see cref="HelpdeskRecord" /> instances from the data store.
        /// </summary>
        /// <param name="detailsId">
        ///     The value which identifies the <see cref='HelpdeskModel' /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The collection of <see cref="HelpdeskRecord" /> instances that match the specified <paramref name='detailsId' />.
        /// </returns>
        public IEnumerable<HelpdeskRecord> FetchAllByDetailsId(String detailsId)
        {
            DbCommand command = this.GetStoredProcedure(SqlServerOperation.FetchAll, "DetailsId");
            this.MapParameterIn(command, "@PA_HD_DETAILS_ID", detailsId);
            return this.Execute(command);
        }

        /// <summary>
        ///     Retrieves a collection of <see cref="HelpdeskRecord" /> instances from the data store.
        /// </summary>
        /// <param name="fixId">
        ///     The value which identifies the <see cref='HelpdeskModel' /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The collection of <see cref="HelpdeskRecord" /> instances that match the specified <paramref name='fixId' />.
        /// </returns>
        public IEnumerable<HelpdeskRecord> FetchAllByFixId(String fixId)
        {
            DbCommand command = this.GetStoredProcedure(SqlServerOperation.FetchAll, "FixId");
            this.MapParameterIn(command, "@PA_HD_FIX_ID", fixId);
            return this.Execute(command);
        }

        /// <summary>
        ///     Retrieves a collection of <see cref="HelpdeskRecord" /> instances from the data store.
        /// </summary>
        /// <param name="wipId">
        ///     The value which identifies the <see cref='HelpdeskModel' /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The collection of <see cref="HelpdeskRecord" /> instances that match the specified <paramref name='wipId' />.
        /// </returns>
        public IEnumerable<HelpdeskRecord> FetchAllByWipId(String wipId)
        {
            DbCommand command = this.GetStoredProcedure(SqlServerOperation.FetchAll, "WipId");
            this.MapParameterIn(command, "@PA_HD_WIP_ID", wipId);
            return this.Execute(command);
        }

        /// <summary>
        ///     Retrieves a collection of <see cref="HelpdeskRecord" /> instances from the data store.
        /// </summary>
        /// <param name="selcoSpId">
        ///     The value which identifies the <see cref='HelpdeskModel' /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The collection of <see cref="HelpdeskRecord" /> instances that match the specified <paramref name='selcoSpId' />.
        /// </returns>
        public IEnumerable<HelpdeskRecord> FetchAllBySelcoSpId(String selcoSpId)
        {
            DbCommand command = this.GetStoredProcedure(SqlServerOperation.FetchAll, "SelcoSpId");
            this.MapParameterIn(command, "@PA_HD_SELCO_SP_ID", selcoSpId);
            return this.Execute(command);
        }

        /// <summary>
        ///     Retrieves a collection of <see cref="HelpdeskRecord" /> instances from the data store.
        /// </summary>
        /// <param name="pmId">
        ///     The value which identifies the <see cref='HelpdeskModel' /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The collection of <see cref="HelpdeskRecord" /> instances that match the specified <paramref name='pmId' />.
        /// </returns>
        public IEnumerable<HelpdeskRecord> FetchAllByPmId(String pmId)
        {
            DbCommand command = this.GetStoredProcedure(SqlServerOperation.FetchAll, "PmId");
            this.MapParameterIn(command, "@PA_HD_PM_ID", pmId);
            return this.Execute(command);
        }

        #endregion

        #region implementations

        /// <summary>
        ///     Gets the underlying table name that this repository sit over.
        /// </summary>
        System.String IHelpdeskRepository.TableName
        {
            get { return this.TableName; }
        }

        /// <summary>
        ///     Retrieves a collection of <see cref="T:Consensus.Activities.HelpdeskRecord" /> instances from the data store.
        /// </summary>
        /// <param name="orgId">
        ///     The value which identifies the <see cref="!:HelpdeskModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The collection of <see cref="T:Consensus.Activities.HelpdeskRecord" /> instances that match the specified <paramref name="orgId" />.
        /// </returns>
        System.Collections.Generic.IEnumerable<Consensus.Activities.HelpdeskRecord> IHelpdeskRepository.FetchAllByOrgId(System.String orgId)
        {
            return this.FetchAllByOrgId(orgId);
        }

        /// <summary>
        ///     Retrieves a collection of <see cref="T:Consensus.Activities.HelpdeskRecord" /> instances from the data store.
        /// </summary>
        /// <param name="proleId">
        ///     The value which identifies the <see cref="!:HelpdeskModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The collection of <see cref="T:Consensus.Activities.HelpdeskRecord" /> instances that match the specified <paramref name="proleId" />.
        /// </returns>
        System.Collections.Generic.IEnumerable<Consensus.Activities.HelpdeskRecord> IHelpdeskRepository.FetchAllByProleId(System.String proleId)
        {
            return this.FetchAllByProleId(proleId);
        }

        /// <summary>
        ///     Retrieves a collection of <see cref="T:Consensus.Activities.HelpdeskRecord" /> instances from the data store.
        /// </summary>
        /// <param name="givenToId">
        ///     The value which identifies the <see cref="!:HelpdeskModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The collection of <see cref="T:Consensus.Activities.HelpdeskRecord" /> instances that match the specified <paramref name="givenToId" />.
        /// </returns>
        System.Collections.Generic.IEnumerable<Consensus.Activities.HelpdeskRecord> IHelpdeskRepository.FetchAllByGivenToId(System.String givenToId)
        {
            return this.FetchAllByGivenToId(givenToId);
        }

        /// <summary>
        ///     Retrieves a collection of <see cref="T:Consensus.Activities.HelpdeskRecord" /> instances from the data store.
        /// </summary>
        /// <param name="detailsId">
        ///     The value which identifies the <see cref="!:HelpdeskModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The collection of <see cref="T:Consensus.Activities.HelpdeskRecord" /> instances that match the specified <paramref name="detailsId" />.
        /// </returns>
        System.Collections.Generic.IEnumerable<Consensus.Activities.HelpdeskRecord> IHelpdeskRepository.FetchAllByDetailsId(System.String detailsId)
        {
            return this.FetchAllByDetailsId(detailsId);
        }

        /// <summary>
        ///     Retrieves a collection of <see cref="T:Consensus.Activities.HelpdeskRecord" /> instances from the data store.
        /// </summary>
        /// <param name="fixId">
        ///     The value which identifies the <see cref="!:HelpdeskModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The collection of <see cref="T:Consensus.Activities.HelpdeskRecord" /> instances that match the specified <paramref name="fixId" />.
        /// </returns>
        System.Collections.Generic.IEnumerable<Consensus.Activities.HelpdeskRecord> IHelpdeskRepository.FetchAllByFixId(System.String fixId)
        {
            return this.FetchAllByFixId(fixId);
        }

        /// <summary>
        ///     Retrieves a collection of <see cref="T:Consensus.Activities.HelpdeskRecord" /> instances from the data store.
        /// </summary>
        /// <param name="wipId">
        ///     The value which identifies the <see cref="!:HelpdeskModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The collection of <see cref="T:Consensus.Activities.HelpdeskRecord" /> instances that match the specified <paramref name="wipId" />.
        /// </returns>
        System.Collections.Generic.IEnumerable<Consensus.Activities.HelpdeskRecord> IHelpdeskRepository.FetchAllByWipId(System.String wipId)
        {
            return this.FetchAllByWipId(wipId);
        }

        /// <summary>
        ///     Retrieves a collection of <see cref="T:Consensus.Activities.HelpdeskRecord" /> instances from the data store.
        /// </summary>
        /// <param name="selcoSpId">
        ///     The value which identifies the <see cref="!:HelpdeskModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The collection of <see cref="T:Consensus.Activities.HelpdeskRecord" /> instances that match the specified <paramref name="selcoSpId" />.
        /// </returns>
        System.Collections.Generic.IEnumerable<Consensus.Activities.HelpdeskRecord> IHelpdeskRepository.FetchAllBySelcoSpId(System.String selcoSpId)
        {
            return this.FetchAllBySelcoSpId(selcoSpId);
        }

        /// <summary>
        ///     Retrieves a collection of <see cref="T:Consensus.Activities.HelpdeskRecord" /> instances from the data store.
        /// </summary>
        /// <param name="pmId">
        ///     The value which identifies the <see cref="!:HelpdeskModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The collection of <see cref="T:Consensus.Activities.HelpdeskRecord" /> instances that match the specified <paramref name="pmId" />.
        /// </returns>
        System.Collections.Generic.IEnumerable<Consensus.Activities.HelpdeskRecord> IHelpdeskRepository.FetchAllByPmId(System.String pmId)
        {
            return this.FetchAllByPmId(pmId);
        }

        #endregion
    }
}
