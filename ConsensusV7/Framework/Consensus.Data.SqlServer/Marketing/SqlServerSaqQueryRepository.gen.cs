using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Linq;

namespace Consensus.Marketing
{
    /// <summary>
    ///     Provides the persistence and retrieval of the <see cref="SaqQueryRecord" /> instances in a Microsoft SQL Server database.
    /// </summary>
    /// <remarks>
    ///     THIS CODE HAS BEEN AUTOMATICALLY GENERATED USING THE CONSENSUS DEVELOPER TOOLS.
    ///     DO NOT EDIT THIS CODE AS ANY CUSTOM MODIFICATIONS WILL BE LOST UPON REGENERATION.
    /// </remarks>
    public partial class SqlServerSaqQueryRepository : SqlServerRepository<SaqQueryRecord, Int64>, ISaqQueryRepository
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
            get { return "SaqQuery"; }
        }

        /// <summary>
        ///     Gets the name of the parameter which is used to specify the unique value that identifies each instance of a <see cref="SaqQueryRecord" />.
        /// </summary>
        protected override String TypeKeyName
        {
            get { return "@PA_QRY_ID"; }
        }

        /// <summary>
        ///     Gets the underlying table name that this repository sit over.
        /// </summary>
        public override String TableName
        {
            get { return "SAQ_QUERY"; }
        }

        #endregion

        #region methods

        /// <summary>
        ///     Maps an <see cref="IDataRecord" /> to the specified <see cref="SaqQueryRecord" />.
        /// </summary>
        /// <param name="dataRecord">
        ///     The <see cref="IDataRecord" /> to be mapped.
        /// </param>
        /// <param name="record">
        ///     The <see cref="SaqQueryRecord" /> instance to be mapped to.
        /// </param>
        protected override void MapRecord(IDataRecord dataRecord, SaqQueryRecord record)
        {
            record.Id = dataRecord["QRY_ID"].ConvertTo<Int64>();
            record.AddBy = dataRecord["QRY_ADD_BY"].ConvertTo<String>();
            record.AddDate = dataRecord["QRY_ADD_DATE"].ConvertTo<DateTime>();
            record.ModBy = dataRecord["QRY_MOD_BY"].ConvertTo<String>();
            record.ModDate = dataRecord["QRY_MOD_DATE"].ConvertTo<DateTime>();
            record.QgId = dataRecord["QRY_QG_ID"].ConvertTo<Int32?>();
            record.QoffId = dataRecord["QRY_QOFF_ID"].ConvertTo<Int32?>();
            record.Name = dataRecord["QRY_NAME"].ConvertTo<String>();
            record.Desc = dataRecord["QRY_DESC"].ConvertTo<String>();
            record.Status = dataRecord["QRY_STATUS"].ConvertTo<String>();
            record.PmId = dataRecord["QRY_PM_ID"].ConvertTo<String>();
            record.CourseId = dataRecord["QRY_COURSE_ID"].ConvertTo<String>();
            record.Channel = dataRecord["QRY_CHANNEL"].ConvertTo<String>();
            record.MgrProleId = dataRecord["QRY_MGR_PROLE_ID"].ConvertTo<String>();
            record.AppByProleId = dataRecord["QRY_APP_BY_PROLE_ID"].ConvertTo<String>();
            record.TitleSlug = dataRecord["QRY_TITLE_SLUG"].ConvertTo<String>();
            record.OrgOnly = dataRecord["QRY_ORG_ONLY"].ConvertTo<Byte>();
            record.OrgDedupe = dataRecord["QRY_ORG_DEDUPE"].ConvertTo<Byte>();
            record.PnDedupe = dataRecord["QRY_PN_DEDUPE"].ConvertTo<Byte>();
            record.SaveMailSample = dataRecord["QRY_SAVE_MAIL_SAMPLE"].ConvertTo<Byte>();
            record.Locked = dataRecord["QRY_LOCKED"].ConvertTo<Byte>();
            record.PeoplePerOrg = dataRecord["QRY_PEOPLE_PER_ORG"].ConvertTo<Int32>();
            record.PnDonotmail = dataRecord["QRY_PN_DONOTMAIL"].ConvertTo<Byte>();
            record.PnDonotmail2 = dataRecord["QRY_PN_DONOTMAIL2"].ConvertTo<Byte>();
            record.PnDonotmail3 = dataRecord["QRY_PN_DONOTMAIL3"].ConvertTo<Byte>();
            record.ProleDoNotFax = dataRecord["QRY_PROLE_DO_NOT_FAX"].ConvertTo<Byte>();
            record.ProleDoNotMail = dataRecord["QRY_PROLE_DO_NOT_MAIL"].ConvertTo<Byte>();
            record.PnFlag3 = dataRecord["QRY_PN_FLAG_3"].ConvertTo<Byte>();
            record.ProleDisFlag = dataRecord["QRY_PROLE_DIS_FLAG"].ConvertTo<Byte>();
            record.ProleUsernum1 = dataRecord["QRY_PROLE_USERNUM_1"].ConvertTo<Byte>();
            record.PnFlag2 = dataRecord["QRY_PN_FLAG_2"].ConvertTo<Byte>();
            record.ResultsSizeOpt = dataRecord["QRY_RESULTS_SIZE_OPT"].ConvertTo<Byte>();
            record.ResultsSize = dataRecord["QRY_RESULTS_SIZE"].ConvertTo<Int64>();
            record.SchedRunDate = dataRecord["QRY_SCHED_RUN_DATE"].ConvertTo<DateTime?>();
            record.SchedRunTime = dataRecord["QRY_SCHED_RUN_TIME"].ConvertTo<DateTime?>();
            record.CalculatedDate = dataRecord["QRY_CALCULATED_DATE"].ConvertTo<DateTime?>();
            record.OutputDate = dataRecord["QRY_OUTPUT_DATE"].ConvertTo<DateTime?>();
            record.TotalRecords = dataRecord["QRY_TOTAL_RECORDS"].ConvertTo<Int64>();
            record.Sample = dataRecord["QRY_SAMPLE"].ConvertTo<Int64>();
            record.Seeds = dataRecord["QRY_SEEDS"].ConvertTo<Int64>();
            record.InUse = dataRecord["QRY_IN_USE"].ConvertTo<Byte>();
            record.LastResultFile = dataRecord["QRY_LAST_RESULT_FILE"].ConvertTo<String>();
            record.AppStatus = dataRecord["QRY_APP_STATUS"].ConvertTo<Byte>();
            record.ProleDoNotSwap = dataRecord["QRY_PROLE_DO_NOT_SWAP"].ConvertTo<Byte>();
            record.PnFlag1 = dataRecord["QRY_PN_FLAG_1"].ConvertTo<Byte>();
            record.ProleDoNotEmail = dataRecord["QRY_PROLE_DO_NOT_EMAIL"].ConvertTo<Byte>();
            record.ProleDoNotSpare = dataRecord["QRY_PROLE_DO_NOT_SPARE"].ConvertTo<Byte>();
            record.OrgDonotmail = dataRecord["QRY_ORG_DONOTMAIL"].ConvertTo<Byte>();
            record.OrgUsernum1 = dataRecord["QRY_ORG_USERNUM_1"].ConvertTo<Byte>();
            record.OrgFlag1 = dataRecord["QRY_ORG_FLAG_1"].ConvertTo<Byte>();
            record.OrgDonotfax = dataRecord["QRY_ORG_DONOTFAX"].ConvertTo<Byte>();
            record.DpSetting = dataRecord["QRY_DP_SETTING"].ConvertTo<Byte>();
            record.ProleDoNotSpare1 = dataRecord["QRY_PROLE_DO_NOT_SPARE1"].ConvertTo<Byte?>();
            record.ProleDoNotSpare2 = dataRecord["QRY_PROLE_DO_NOT_SPARE2"].ConvertTo<Byte?>();
            record.ProleDoNotSpare3 = dataRecord["QRY_PROLE_DO_NOT_SPARE3"].ConvertTo<Byte?>();
            record.ProleDoNotSpare4 = dataRecord["QRY_PROLE_DO_NOT_SPARE4"].ConvertTo<Byte?>();
            record.PnDoNotSpare1 = dataRecord["QRY_PN_DO_NOT_SPARE1"].ConvertTo<Byte?>();
            record.PnDoNotSpare2 = dataRecord["QRY_PN_DO_NOT_SPARE2"].ConvertTo<Byte?>();
            record.PnDoNotSpare3 = dataRecord["QRY_PN_DO_NOT_SPARE3"].ConvertTo<Byte?>();
            record.PnDoNotSpare4 = dataRecord["QRY_PN_DO_NOT_SPARE4"].ConvertTo<Byte?>();
            record.OrgDoNotSpare1 = dataRecord["QRY_ORG_DO_NOT_SPARE1"].ConvertTo<Byte?>();
            record.OrgDoNotSpare2 = dataRecord["QRY_ORG_DO_NOT_SPARE2"].ConvertTo<Byte?>();
            record.OrgDoNotSpare3 = dataRecord["QRY_ORG_DO_NOT_SPARE3"].ConvertTo<Byte?>();
            record.OrgDoNotSpare4 = dataRecord["QRY_ORG_DO_NOT_SPARE4"].ConvertTo<Byte?>();
        }

        /// <summary>
        ///     Sets the parameter values for the specified <paramref name="command" /> based on the specified <typeparamref name="TRecord" /> instance.
        /// </summary>
        /// <param name="command">
        ///     The <see cref="IDbCommand" /> containing the parameters to be mapped.
        /// </param>
        /// <param name="record">
        ///     The <see cref="SaqQueryRecord" /> instance to be mapped.
        /// </param>
        /// <param name="useV6Logic">
        ///     Is the procedure being run an old version 6.x procedure? (the null value handling logic is different).
        /// </param>
        protected override void MapParametersIn(IDbCommand command, SaqQueryRecord record, bool useV6Logic)
        {
            this.MapParameterIn(command, "@PA_QRY_ID", record.Id == Int64.MinValue ? ( useV6Logic ? new Int64?(0) : null ) : record.Id);
            this.MapParameterIn(command, "@PA_QRY_QG_ID", record.QgId == Int32.MinValue ? ( useV6Logic ? new Int32?(0) : null ) : record.QgId);
            this.MapParameterIn(command, "@PA_QRY_QOFF_ID", record.QoffId == Int32.MinValue ? ( useV6Logic ? new Int32?(0) : null ) : record.QoffId);
            this.MapParameterIn(command, "@PA_QRY_NAME", record.Name);
            this.MapParameterIn(command, "@PA_QRY_DESC", record.Desc);
            this.MapParameterIn(command, "@PA_QRY_STATUS", record.Status);
            this.MapParameterIn(command, "@PA_QRY_PM_ID", record.PmId);
            this.MapParameterIn(command, "@PA_QRY_COURSE_ID", record.CourseId);
            this.MapParameterIn(command, "@PA_QRY_CHANNEL", record.Channel);
            this.MapParameterIn(command, "@PA_QRY_MGR_PROLE_ID", record.MgrProleId);
            this.MapParameterIn(command, "@PA_QRY_APP_BY_PROLE_ID", record.AppByProleId);
            this.MapParameterIn(command, "@PA_QRY_TITLE_SLUG", record.TitleSlug);
            this.MapParameterIn(command, "@PA_QRY_ORG_ONLY", record.OrgOnly);
            this.MapParameterIn(command, "@PA_QRY_ORG_DEDUPE", record.OrgDedupe);
            this.MapParameterIn(command, "@PA_QRY_PN_DEDUPE", record.PnDedupe);
            this.MapParameterIn(command, "@PA_QRY_SAVE_MAIL_SAMPLE", record.SaveMailSample);
            this.MapParameterIn(command, "@PA_QRY_LOCKED", record.Locked);
            this.MapParameterIn(command, "@PA_QRY_PEOPLE_PER_ORG", record.PeoplePerOrg == Int32.MinValue ? 0 : record.PeoplePerOrg);
            this.MapParameterIn(command, "@PA_QRY_PN_DONOTMAIL", record.PnDonotmail);
            this.MapParameterIn(command, "@PA_QRY_PN_DONOTMAIL2", record.PnDonotmail2);
            this.MapParameterIn(command, "@PA_QRY_PN_DONOTMAIL3", record.PnDonotmail3);
            this.MapParameterIn(command, "@PA_QRY_PROLE_DO_NOT_FAX", record.ProleDoNotFax);
            this.MapParameterIn(command, "@PA_QRY_PROLE_DO_NOT_MAIL", record.ProleDoNotMail);
            this.MapParameterIn(command, "@PA_QRY_PN_FLAG_3", record.PnFlag3);
            this.MapParameterIn(command, "@PA_QRY_PROLE_DIS_FLAG", record.ProleDisFlag);
            this.MapParameterIn(command, "@PA_QRY_PROLE_USERNUM_1", record.ProleUsernum1);
            this.MapParameterIn(command, "@PA_QRY_PN_FLAG_2", record.PnFlag2);
            this.MapParameterIn(command, "@PA_QRY_RESULTS_SIZE_OPT", record.ResultsSizeOpt);
            this.MapParameterIn(command, "@PA_QRY_RESULTS_SIZE", record.ResultsSize == Int64.MinValue ? 0 : record.ResultsSize);
            this.MapParameterIn(command, "@PA_QRY_SCHED_RUN_DATE", record.SchedRunDate == DateTime.MinValue ? ( useV6Logic ? new DateTime?(new DateTime(1900,1,1)) : null ) : record.SchedRunDate);
            this.MapParameterIn(command, "@PA_QRY_SCHED_RUN_TIME", record.SchedRunTime == DateTime.MinValue ? ( useV6Logic ? new DateTime?(new DateTime(1900,1,1)) : null ) : record.SchedRunTime);
            this.MapParameterIn(command, "@PA_QRY_CALCULATED_DATE", record.CalculatedDate == DateTime.MinValue ? ( useV6Logic ? new DateTime?(new DateTime(1900,1,1)) : null ) : record.CalculatedDate);
            this.MapParameterIn(command, "@PA_QRY_OUTPUT_DATE", record.OutputDate == DateTime.MinValue ? ( useV6Logic ? new DateTime?(new DateTime(1900,1,1)) : null ) : record.OutputDate);
            this.MapParameterIn(command, "@PA_QRY_TOTAL_RECORDS", record.TotalRecords == Int64.MinValue ? 0 : record.TotalRecords);
            this.MapParameterIn(command, "@PA_QRY_SAMPLE", record.Sample == Int64.MinValue ? 0 : record.Sample);
            this.MapParameterIn(command, "@PA_QRY_SEEDS", record.Seeds == Int64.MinValue ? 0 : record.Seeds);
            this.MapParameterIn(command, "@PA_QRY_IN_USE", record.InUse);
            this.MapParameterIn(command, "@PA_QRY_LAST_RESULT_FILE", record.LastResultFile);
            this.MapParameterIn(command, "@PA_QRY_APP_STATUS", record.AppStatus);
            this.MapParameterIn(command, "@PA_QRY_PROLE_DO_NOT_SWAP", record.ProleDoNotSwap);
            this.MapParameterIn(command, "@PA_QRY_PN_FLAG_1", record.PnFlag1);
            this.MapParameterIn(command, "@PA_QRY_PROLE_DO_NOT_EMAIL", record.ProleDoNotEmail);
            this.MapParameterIn(command, "@PA_QRY_PROLE_DO_NOT_SPARE", record.ProleDoNotSpare);
            this.MapParameterIn(command, "@PA_QRY_ORG_DONOTMAIL", record.OrgDonotmail);
            this.MapParameterIn(command, "@PA_QRY_ORG_USERNUM_1", record.OrgUsernum1);
            this.MapParameterIn(command, "@PA_QRY_ORG_FLAG_1", record.OrgFlag1);
            this.MapParameterIn(command, "@PA_QRY_ORG_DONOTFAX", record.OrgDonotfax);
            this.MapParameterIn(command, "@PA_QRY_DP_SETTING", record.DpSetting);
            this.MapParameterIn(command, "@PA_QRY_PROLE_DO_NOT_SPARE1", record.ProleDoNotSpare1);
            this.MapParameterIn(command, "@PA_QRY_PROLE_DO_NOT_SPARE2", record.ProleDoNotSpare2);
            this.MapParameterIn(command, "@PA_QRY_PROLE_DO_NOT_SPARE3", record.ProleDoNotSpare3);
            this.MapParameterIn(command, "@PA_QRY_PROLE_DO_NOT_SPARE4", record.ProleDoNotSpare4);
            this.MapParameterIn(command, "@PA_QRY_PN_DO_NOT_SPARE1", record.PnDoNotSpare1);
            this.MapParameterIn(command, "@PA_QRY_PN_DO_NOT_SPARE2", record.PnDoNotSpare2);
            this.MapParameterIn(command, "@PA_QRY_PN_DO_NOT_SPARE3", record.PnDoNotSpare3);
            this.MapParameterIn(command, "@PA_QRY_PN_DO_NOT_SPARE4", record.PnDoNotSpare4);
            this.MapParameterIn(command, "@PA_QRY_ORG_DO_NOT_SPARE1", record.OrgDoNotSpare1);
            this.MapParameterIn(command, "@PA_QRY_ORG_DO_NOT_SPARE2", record.OrgDoNotSpare2);
            this.MapParameterIn(command, "@PA_QRY_ORG_DO_NOT_SPARE3", record.OrgDoNotSpare3);
            this.MapParameterIn(command, "@PA_QRY_ORG_DO_NOT_SPARE4", record.OrgDoNotSpare4);
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
        ///     The <see cref="SaqQueryRecord" /> instance to be updated.
        /// </param>
        protected override void MapParametersOut(IDbCommand command, SaqQueryRecord record)
        {
            record.Id = this.MapParameterOut(command, "@PA_QRY_ID", record.Id);
            record.QgId = this.MapParameterOut(command, "@PA_QRY_QG_ID", record.QgId);
            record.QoffId = this.MapParameterOut(command, "@PA_QRY_QOFF_ID", record.QoffId);
            record.Name = this.MapParameterOut(command, "@PA_QRY_NAME", record.Name);
            record.Desc = this.MapParameterOut(command, "@PA_QRY_DESC", record.Desc);
            record.Status = this.MapParameterOut(command, "@PA_QRY_STATUS", record.Status);
            record.PmId = this.MapParameterOut(command, "@PA_QRY_PM_ID", record.PmId);
            record.CourseId = this.MapParameterOut(command, "@PA_QRY_COURSE_ID", record.CourseId);
            record.Channel = this.MapParameterOut(command, "@PA_QRY_CHANNEL", record.Channel);
            record.MgrProleId = this.MapParameterOut(command, "@PA_QRY_MGR_PROLE_ID", record.MgrProleId);
            record.AppByProleId = this.MapParameterOut(command, "@PA_QRY_APP_BY_PROLE_ID", record.AppByProleId);
            record.TitleSlug = this.MapParameterOut(command, "@PA_QRY_TITLE_SLUG", record.TitleSlug);
            record.OrgOnly = this.MapParameterOut(command, "@PA_QRY_ORG_ONLY", record.OrgOnly);
            record.OrgDedupe = this.MapParameterOut(command, "@PA_QRY_ORG_DEDUPE", record.OrgDedupe);
            record.PnDedupe = this.MapParameterOut(command, "@PA_QRY_PN_DEDUPE", record.PnDedupe);
            record.SaveMailSample = this.MapParameterOut(command, "@PA_QRY_SAVE_MAIL_SAMPLE", record.SaveMailSample);
            record.Locked = this.MapParameterOut(command, "@PA_QRY_LOCKED", record.Locked);
            record.PeoplePerOrg = this.MapParameterOut(command, "@PA_QRY_PEOPLE_PER_ORG", record.PeoplePerOrg);
            record.PnDonotmail = this.MapParameterOut(command, "@PA_QRY_PN_DONOTMAIL", record.PnDonotmail);
            record.PnDonotmail2 = this.MapParameterOut(command, "@PA_QRY_PN_DONOTMAIL2", record.PnDonotmail2);
            record.PnDonotmail3 = this.MapParameterOut(command, "@PA_QRY_PN_DONOTMAIL3", record.PnDonotmail3);
            record.ProleDoNotFax = this.MapParameterOut(command, "@PA_QRY_PROLE_DO_NOT_FAX", record.ProleDoNotFax);
            record.ProleDoNotMail = this.MapParameterOut(command, "@PA_QRY_PROLE_DO_NOT_MAIL", record.ProleDoNotMail);
            record.PnFlag3 = this.MapParameterOut(command, "@PA_QRY_PN_FLAG_3", record.PnFlag3);
            record.ProleDisFlag = this.MapParameterOut(command, "@PA_QRY_PROLE_DIS_FLAG", record.ProleDisFlag);
            record.ProleUsernum1 = this.MapParameterOut(command, "@PA_QRY_PROLE_USERNUM_1", record.ProleUsernum1);
            record.PnFlag2 = this.MapParameterOut(command, "@PA_QRY_PN_FLAG_2", record.PnFlag2);
            record.ResultsSizeOpt = this.MapParameterOut(command, "@PA_QRY_RESULTS_SIZE_OPT", record.ResultsSizeOpt);
            record.ResultsSize = this.MapParameterOut(command, "@PA_QRY_RESULTS_SIZE", record.ResultsSize);
            record.SchedRunDate = this.MapParameterOut(command, "@PA_QRY_SCHED_RUN_DATE", record.SchedRunDate);
            record.SchedRunTime = this.MapParameterOut(command, "@PA_QRY_SCHED_RUN_TIME", record.SchedRunTime);
            record.CalculatedDate = this.MapParameterOut(command, "@PA_QRY_CALCULATED_DATE", record.CalculatedDate);
            record.OutputDate = this.MapParameterOut(command, "@PA_QRY_OUTPUT_DATE", record.OutputDate);
            record.TotalRecords = this.MapParameterOut(command, "@PA_QRY_TOTAL_RECORDS", record.TotalRecords);
            record.Sample = this.MapParameterOut(command, "@PA_QRY_SAMPLE", record.Sample);
            record.Seeds = this.MapParameterOut(command, "@PA_QRY_SEEDS", record.Seeds);
            record.InUse = this.MapParameterOut(command, "@PA_QRY_IN_USE", record.InUse);
            record.LastResultFile = this.MapParameterOut(command, "@PA_QRY_LAST_RESULT_FILE", record.LastResultFile);
            record.AppStatus = this.MapParameterOut(command, "@PA_QRY_APP_STATUS", record.AppStatus);
            record.ProleDoNotSwap = this.MapParameterOut(command, "@PA_QRY_PROLE_DO_NOT_SWAP", record.ProleDoNotSwap);
            record.PnFlag1 = this.MapParameterOut(command, "@PA_QRY_PN_FLAG_1", record.PnFlag1);
            record.ProleDoNotEmail = this.MapParameterOut(command, "@PA_QRY_PROLE_DO_NOT_EMAIL", record.ProleDoNotEmail);
            record.ProleDoNotSpare = this.MapParameterOut(command, "@PA_QRY_PROLE_DO_NOT_SPARE", record.ProleDoNotSpare);
            record.OrgDonotmail = this.MapParameterOut(command, "@PA_QRY_ORG_DONOTMAIL", record.OrgDonotmail);
            record.OrgUsernum1 = this.MapParameterOut(command, "@PA_QRY_ORG_USERNUM_1", record.OrgUsernum1);
            record.OrgFlag1 = this.MapParameterOut(command, "@PA_QRY_ORG_FLAG_1", record.OrgFlag1);
            record.OrgDonotfax = this.MapParameterOut(command, "@PA_QRY_ORG_DONOTFAX", record.OrgDonotfax);
            record.DpSetting = this.MapParameterOut(command, "@PA_QRY_DP_SETTING", record.DpSetting);
            record.ProleDoNotSpare1 = this.MapParameterOut(command, "@PA_QRY_PROLE_DO_NOT_SPARE1", record.ProleDoNotSpare1);
            record.ProleDoNotSpare2 = this.MapParameterOut(command, "@PA_QRY_PROLE_DO_NOT_SPARE2", record.ProleDoNotSpare2);
            record.ProleDoNotSpare3 = this.MapParameterOut(command, "@PA_QRY_PROLE_DO_NOT_SPARE3", record.ProleDoNotSpare3);
            record.ProleDoNotSpare4 = this.MapParameterOut(command, "@PA_QRY_PROLE_DO_NOT_SPARE4", record.ProleDoNotSpare4);
            record.PnDoNotSpare1 = this.MapParameterOut(command, "@PA_QRY_PN_DO_NOT_SPARE1", record.PnDoNotSpare1);
            record.PnDoNotSpare2 = this.MapParameterOut(command, "@PA_QRY_PN_DO_NOT_SPARE2", record.PnDoNotSpare2);
            record.PnDoNotSpare3 = this.MapParameterOut(command, "@PA_QRY_PN_DO_NOT_SPARE3", record.PnDoNotSpare3);
            record.PnDoNotSpare4 = this.MapParameterOut(command, "@PA_QRY_PN_DO_NOT_SPARE4", record.PnDoNotSpare4);
            record.OrgDoNotSpare1 = this.MapParameterOut(command, "@PA_QRY_ORG_DO_NOT_SPARE1", record.OrgDoNotSpare1);
            record.OrgDoNotSpare2 = this.MapParameterOut(command, "@PA_QRY_ORG_DO_NOT_SPARE2", record.OrgDoNotSpare2);
            record.OrgDoNotSpare3 = this.MapParameterOut(command, "@PA_QRY_ORG_DO_NOT_SPARE3", record.OrgDoNotSpare3);
            record.OrgDoNotSpare4 = this.MapParameterOut(command, "@PA_QRY_ORG_DO_NOT_SPARE4", record.OrgDoNotSpare4);
            record.Id = this.MapParameterOut(command, "@PA_RETURN_ID", record.Id);
        }

        /// <summary>
        ///     Retrieves a collection of <see cref="SaqQueryRecord" /> instances from the data store.
        /// </summary>
        /// <param name="pmId">
        ///     The value which identifies the <see cref='SaqQueryModel' /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The collection of <see cref="SaqQueryRecord" /> instances that match the specified <paramref name='pmId' />.
        /// </returns>
        public IEnumerable<SaqQueryRecord> FetchAllByPmId(String pmId)
        {
            DbCommand command = this.GetStoredProcedure(SqlServerOperation.FetchAll, "PmId");
            this.MapParameterIn(command, "@PA_QRY_PM_ID", pmId);
            return this.Execute(command);
        }

        /// <summary>
        ///     Retrieves a collection of <see cref="SaqQueryRecord" /> instances from the data store.
        /// </summary>
        /// <param name="courseId">
        ///     The value which identifies the <see cref='SaqQueryModel' /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The collection of <see cref="SaqQueryRecord" /> instances that match the specified <paramref name='courseId' />.
        /// </returns>
        public IEnumerable<SaqQueryRecord> FetchAllByCourseId(String courseId)
        {
            DbCommand command = this.GetStoredProcedure(SqlServerOperation.FetchAll, "CourseId");
            this.MapParameterIn(command, "@PA_QRY_COURSE_ID", courseId);
            return this.Execute(command);
        }

        /// <summary>
        ///     Retrieves a collection of <see cref="SaqQueryRecord" /> instances from the data store.
        /// </summary>
        /// <param name="mgrProleId">
        ///     The value which identifies the <see cref='SaqQueryModel' /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The collection of <see cref="SaqQueryRecord" /> instances that match the specified <paramref name='mgrProleId' />.
        /// </returns>
        public IEnumerable<SaqQueryRecord> FetchAllByMgrProleId(String mgrProleId)
        {
            DbCommand command = this.GetStoredProcedure(SqlServerOperation.FetchAll, "MgrProleId");
            this.MapParameterIn(command, "@PA_QRY_MGR_PROLE_ID", mgrProleId);
            return this.Execute(command);
        }

        /// <summary>
        ///     Retrieves a collection of <see cref="SaqQueryRecord" /> instances from the data store.
        /// </summary>
        /// <param name="appByProleId">
        ///     The value which identifies the <see cref='SaqQueryModel' /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The collection of <see cref="SaqQueryRecord" /> instances that match the specified <paramref name='appByProleId' />.
        /// </returns>
        public IEnumerable<SaqQueryRecord> FetchAllByAppByProleId(String appByProleId)
        {
            DbCommand command = this.GetStoredProcedure(SqlServerOperation.FetchAll, "AppByProleId");
            this.MapParameterIn(command, "@PA_QRY_APP_BY_PROLE_ID", appByProleId);
            return this.Execute(command);
        }

        #endregion

        #region implementations

        /// <summary>
        ///     Gets the underlying table name that this repository sit over.
        /// </summary>
        System.String ISaqQueryRepository.TableName
        {
            get { return this.TableName; }
        }

        /// <summary>
        ///     Retrieves a collection of <see cref="T:Consensus.Marketing.SaqQueryRecord" /> instances from the data store.
        /// </summary>
        /// <param name="pmId">
        ///     The value which identifies the <see cref="!:SaqQueryModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The collection of <see cref="T:Consensus.Marketing.SaqQueryRecord" /> instances that match the specified <paramref name="pmId" />.
        /// </returns>
        System.Collections.Generic.IEnumerable<Consensus.Marketing.SaqQueryRecord> ISaqQueryRepository.FetchAllByPmId(System.String pmId)
        {
            return this.FetchAllByPmId(pmId);
        }

        /// <summary>
        ///     Retrieves a collection of <see cref="T:Consensus.Marketing.SaqQueryRecord" /> instances from the data store.
        /// </summary>
        /// <param name="courseId">
        ///     The value which identifies the <see cref="!:SaqQueryModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The collection of <see cref="T:Consensus.Marketing.SaqQueryRecord" /> instances that match the specified <paramref name="courseId" />.
        /// </returns>
        System.Collections.Generic.IEnumerable<Consensus.Marketing.SaqQueryRecord> ISaqQueryRepository.FetchAllByCourseId(System.String courseId)
        {
            return this.FetchAllByCourseId(courseId);
        }

        /// <summary>
        ///     Retrieves a collection of <see cref="T:Consensus.Marketing.SaqQueryRecord" /> instances from the data store.
        /// </summary>
        /// <param name="mgrProleId">
        ///     The value which identifies the <see cref="!:SaqQueryModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The collection of <see cref="T:Consensus.Marketing.SaqQueryRecord" /> instances that match the specified <paramref name="mgrProleId" />.
        /// </returns>
        System.Collections.Generic.IEnumerable<Consensus.Marketing.SaqQueryRecord> ISaqQueryRepository.FetchAllByMgrProleId(System.String mgrProleId)
        {
            return this.FetchAllByMgrProleId(mgrProleId);
        }

        /// <summary>
        ///     Retrieves a collection of <see cref="T:Consensus.Marketing.SaqQueryRecord" /> instances from the data store.
        /// </summary>
        /// <param name="appByProleId">
        ///     The value which identifies the <see cref="!:SaqQueryModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The collection of <see cref="T:Consensus.Marketing.SaqQueryRecord" /> instances that match the specified <paramref name="appByProleId" />.
        /// </returns>
        System.Collections.Generic.IEnumerable<Consensus.Marketing.SaqQueryRecord> ISaqQueryRepository.FetchAllByAppByProleId(System.String appByProleId)
        {
            return this.FetchAllByAppByProleId(appByProleId);
        }

        #endregion
    }
}
