using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Linq;

namespace Consensus.Contact
{
    /// <summary>
    ///     Provides the persistence and retrieval of the <see cref="PersonRoleRecord" /> instances in a Microsoft SQL Server database.
    /// </summary>
    /// <remarks>
    ///     THIS CODE HAS BEEN AUTOMATICALLY GENERATED USING THE CONSENSUS DEVELOPER TOOLS.
    ///     DO NOT EDIT THIS CODE AS ANY CUSTOM MODIFICATIONS WILL BE LOST UPON REGENERATION.
    /// </remarks>
    public partial class SqlServerRoleRepository : SqlServerRepository<PersonRoleRecord, String>, IRoleRepository
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
            get { return "PersonRole"; }
        }

        /// <summary>
        ///     Gets the name of the parameter which is used to specify the unique value that identifies each instance of a <see cref="PersonRoleRecord" />.
        /// </summary>
        protected override String TypeKeyName
        {
            get { return "@PA_PROLE_ID"; }
        }

        /// <summary>
        ///     Gets the underlying table name that this repository sit over.
        /// </summary>
        public override String TableName
        {
            get { return "Person_Role"; }
        }

        #endregion

        #region methods

        /// <summary>
        ///     Maps an <see cref="IDataRecord" /> to the specified <see cref="PersonRoleRecord" />.
        /// </summary>
        /// <param name="dataRecord">
        ///     The <see cref="IDataRecord" /> to be mapped.
        /// </param>
        /// <param name="record">
        ///     The <see cref="PersonRoleRecord" /> instance to be mapped to.
        /// </param>
        protected override void MapRecord(IDataRecord dataRecord, PersonRoleRecord record)
        {
            record.Id = dataRecord["PROLE_ID"].ConvertTo<String>();
            record.Lock = dataRecord["PROLE_LOCK"].ConvertTo<String>();
            record.AddDate = dataRecord["PROLE_ADD_DATE"].ConvertTo<DateTime?>();
            record.AddBy = dataRecord["PROLE_ADD_BY"].ConvertTo<String>();
            record.ModDate = dataRecord["PROLE_MOD_DATE"].ConvertTo<DateTime?>();
            record.ModBy = dataRecord["PROLE_MOD_BY"].ConvertTo<String>();
            record.RcvDate = dataRecord["PROLE_RCV_DATE"].ConvertTo<DateTime?>();
            record.RcvFrom = dataRecord["PROLE_RCV_FROM"].ConvertTo<String>();
            record.PersonId = dataRecord["PROLE_PERSON_ID"].ConvertTo<String>();
            record.OrgId = dataRecord["PROLE_ORG_ID"].ConvertTo<String>();
            record.PosTitle = dataRecord["PROLE_POS_TITLE"].ConvertTo<String>();
            record.Dept = dataRecord["PROLE_DEPT"].ConvertTo<String>();
            record.PosType = dataRecord["PROLE_POS_TYPE"].ConvertTo<String>();
            record.PosLevel = dataRecord["PROLE_POS_LEVEL"].ConvertTo<String>();
            record.Phone = dataRecord["PROLE_PHONE"].ConvertTo<String>();
            record.Fax = dataRecord["PROLE_FAX"].ConvertTo<String>();
            record.Mobile = dataRecord["PROLE_MOBILE"].ConvertTo<String>();
            record.Email1 = dataRecord["PROLE_EMAIL1"].ConvertTo<String>();
            record.ReportsTo = dataRecord["PROLE_REPORTS_TO"].ConvertTo<String>();
            record.Secretary = dataRecord["PROLE_SECRETARY"].ConvertTo<String>();
            record.PrincipRole = dataRecord["PROLE_PRINCIP_ROLE"].ConvertTo<Byte?>();
            record.DoNotMail = dataRecord["PROLE_DO_NOT_MAIL"].ConvertTo<Byte?>();
            record.AddId = dataRecord["PROLE_ADD_ID"].ConvertTo<String>();
            record.StartDate = dataRecord["PROLE_START_DATE"].ConvertTo<DateTime?>();
            record.EndDate = dataRecord["PROLE_END_DATE"].ConvertTo<DateTime?>();
            record.UnionRolNo = dataRecord["PROLE_UNION_ROL_NO"].ConvertTo<String>();
            record.BranchName = dataRecord["PROLE_BRANCH_NAME"].ConvertTo<String>();
            record.FirstCourse = dataRecord["PROLE_FIRST_COURSE"].ConvertTo<DateTime?>();
            record.Type = dataRecord["PROLE_TYPE"].ConvertTo<String>();
            record.AltPhone = dataRecord["PROLE_ALT_PHONE"].ConvertTo<String>();
            record.AltFax = dataRecord["PROLE_ALT_FAX"].ConvertTo<String>();
            record.Budget = dataRecord["PROLE_BUDGET"].ConvertTo<Double?>();
            record.NlCopies = dataRecord["PROLE_NL_COPIES"].ConvertTo<Double?>();
            record.UserType = dataRecord["PROLE_USER_TYPE"].ConvertTo<String>();
            record.UserType1 = dataRecord["PROLE_USER_TYPE_1"].ConvertTo<String>();
            record.UserType2 = dataRecord["PROLE_USER_TYPE_2"].ConvertTo<String>();
            record.UserType3 = dataRecord["PROLE_USER_TYPE_3"].ConvertTo<String>();
            record.ExecCode = dataRecord["PROLE_EXEC_CODE"].ConvertTo<String>();
            record.Userchar1 = dataRecord["PROLE_USERCHAR_1"].ConvertTo<String>();
            record.Userchar2 = dataRecord["PROLE_USERCHAR_2"].ConvertTo<String>();
            record.Userchar3 = dataRecord["PROLE_USERCHAR_3"].ConvertTo<String>();
            record.Userchar4 = dataRecord["PROLE_USERCHAR_4"].ConvertTo<String>();
            record.Usernum1 = dataRecord["PROLE_USERNUM_1"].ConvertTo<Decimal?>();
            record.Usernum2 = dataRecord["PROLE_USERNUM_2"].ConvertTo<Decimal?>();
            record.Email = dataRecord["PROLE_EMAIL"].ConvertTo<String>();
            record.OrgName = dataRecord["PROLE_ORG_NAME"].ConvertTo<String>();
            record.PnName = dataRecord["PROLE_PN_NAME"].ConvertTo<String>();
            record.ContactMgr = dataRecord["PROLE_CONTACT_MGR"].ConvertTo<String>();
            record.Source = dataRecord["PROLE_SOURCE"].ConvertTo<String>();
            record.MailLimit = dataRecord["PROLE_MAIL_LIMIT"].ConvertTo<Byte?>();
            record.Until = dataRecord["PROLE_UNTIL"].ConvertTo<DateTime?>();
            record.MailNolimit = dataRecord["PROLE_MAIL_NOLIMIT"].ConvertTo<Byte?>();
            record.ExtId1 = dataRecord["PROLE_EXT_ID_1"].ConvertTo<String>();
            record.ExtId2 = dataRecord["PROLE_EXT_ID_2"].ConvertTo<String>();
            record.ExtId3 = dataRecord["PROLE_EXT_ID_3"].ConvertTo<String>();
            record.SecretPhone = dataRecord["PROLE_SECRET_PHONE"].ConvertTo<String>();
            record.Notes = dataRecord["PROLE_NOTES"].ConvertTo<String>();
            record.LbstDate = dataRecord["PROLE_LBST_DATE"].ConvertTo<DateTime?>();
            record.PostSpec = dataRecord["PROLE_POST_SPEC"].ConvertTo<String>();
            record.ScalePoint = dataRecord["PROLE_SCALE_POINT"].ConvertTo<Int32?>();
            record.GradeBand = dataRecord["PROLE_GRADE_BAND"].ConvertTo<String>();
            record.DisFlag = dataRecord["PROLE_DIS_FLAG"].ConvertTo<Byte?>();
            record.WebProf = dataRecord["PROLE_WEB_PROF"].ConvertTo<String>();
            record.WebPass = dataRecord["PROLE_WEB_PASS"].ConvertTo<String>();
            record.CustomerAcc = dataRecord["PROLE_CUSTOMER_ACC"].ConvertTo<String>();
            record.CjtId = dataRecord["PROLE_CJT_ID"].ConvertTo<String>();
            record.Payroll = dataRecord["PROLE_PAYROLL"].ConvertTo<String>();
            record.StaffNo = dataRecord["PROLE_STAFF_NO"].ConvertTo<String>();
            record.CostCentre = dataRecord["PROLE_COST_CENTRE"].ConvertTo<String>();
            record.KeyContact = dataRecord["PROLE_KEY_CONTACT"].ConvertTo<Byte?>();
            record.MemCTot = dataRecord["PROLE_MEM_C_TOT"].ConvertTo<Double?>();
            record.MemRTot = dataRecord["PROLE_MEM_R_TOT"].ConvertTo<Double?>();
            record.MemLTot = dataRecord["PROLE_MEM_L_TOT"].ConvertTo<Double?>();
            record.ContactMgr2 = dataRecord["PROLE_CONTACT_MGR2"].ConvertTo<String>();
            record.Userchar5 = dataRecord["PROLE_USERCHAR_5"].ConvertTo<String>();
            record.Userchar6 = dataRecord["PROLE_USERCHAR_6"].ConvertTo<String>();
            record.Userint1 = dataRecord["PROLE_USERINT_1"].ConvertTo<Byte?>();
            record.Userint2 = dataRecord["PROLE_USERINT_2"].ConvertTo<Byte?>();
            record.Userint3 = dataRecord["PROLE_USERINT_3"].ConvertTo<Byte?>();
            record.Userint4 = dataRecord["PROLE_USERINT_4"].ConvertTo<Byte?>();
            record.Userint5 = dataRecord["PROLE_USERINT_5"].ConvertTo<Byte?>();
            record.Userint6 = dataRecord["PROLE_USERINT_6"].ConvertTo<Byte?>();
            record.Usernum3 = dataRecord["PROLE_USERNUM_3"].ConvertTo<Decimal?>();
            record.Usernum4 = dataRecord["PROLE_USERNUM_4"].ConvertTo<Decimal?>();
            record.Usernum5 = dataRecord["PROLE_USERNUM_5"].ConvertTo<Decimal?>();
            record.Usernum6 = dataRecord["PROLE_USERNUM_6"].ConvertTo<Decimal?>();
            record.Userdate1 = dataRecord["PROLE_USERDATE_1"].ConvertTo<DateTime?>();
            record.Userdate2 = dataRecord["PROLE_USERDATE_2"].ConvertTo<DateTime?>();
            record.Userdate3 = dataRecord["PROLE_USERDATE_3"].ConvertTo<DateTime?>();
            record.Userdate4 = dataRecord["PROLE_USERDATE_4"].ConvertTo<DateTime?>();
            record.Userdate5 = dataRecord["PROLE_USERDATE_5"].ConvertTo<DateTime?>();
            record.Userdate6 = dataRecord["PROLE_USERDATE_6"].ConvertTo<DateTime?>();
            record.DoNotFax = dataRecord["PROLE_DO_NOT_FAX"].ConvertTo<Byte?>();
            record.DoNotEmail = dataRecord["PROLE_DO_NOT_EMAIL"].ConvertTo<Byte?>();
            record.DoNotSwap = dataRecord["PROLE_DO_NOT_SWAP"].ConvertTo<Byte?>();
            record.DoNotSpare = dataRecord["PROLE_DO_NOT_SPARE"].ConvertTo<Byte?>();
            record.PrivateAdd = dataRecord["PROLE_PRIVATE_ADD"].ConvertTo<Byte?>();
            record.CostCode = dataRecord["PROLE_COST_CODE"].ConvertTo<String>();
            record.MainWorkadd = dataRecord["PROLE_MAIN_WORKADD"].ConvertTo<Byte?>();
            record.MainPrivadd = dataRecord["PROLE_MAIN_PRIVADD"].ConvertTo<Byte?>();
            record.WorkAdd = dataRecord["PROLE_WORK_ADD"].ConvertTo<Byte?>();
            record.LmPhone = dataRecord["PROLE_LM_PHONE"].ConvertTo<String>();
            record.LmEmail = dataRecord["PROLE_LM_EMAIL"].ConvertTo<String>();
            record.Service = dataRecord["PROLE_SERVICE"].ConvertTo<String>();
            record.PayLocation = dataRecord["PROLE_PAY_LOCATION"].ConvertTo<String>();
            record.Ba = dataRecord["PROLE_BA"].ConvertTo<String>();
            record.Ba1 = dataRecord["PROLE_BA1"].ConvertTo<String>();
            record.TrnAdmin = dataRecord["PROLE_TRN_ADMIN"].ConvertTo<Byte?>();
            record.AttribNum01 = dataRecord["PROLE_ATTRIB_NUM_01"].ConvertTo<Int32?>();
            record.AttribChar01 = dataRecord["PROLE_ATTRIB_CHAR_01"].ConvertTo<String>();
            record.AttribTint01 = dataRecord["PROLE_ATTRIB_TINT_01"].ConvertTo<Byte?>();
            record.Wte = dataRecord["PROLE_WTE"].ConvertTo<Decimal?>();
            record.PhoneStd = dataRecord["PROLE_PHONE_STD"].ConvertTo<String>();
            record.FaxStd = dataRecord["PROLE_FAX_STD"].ConvertTo<String>();
            record.AltPhoneStd = dataRecord["PROLE_ALT_PHONE_STD"].ConvertTo<String>();
            record.AltFaxStd = dataRecord["PROLE_ALT_FAX_STD"].ConvertTo<String>();
            record.SecretPhoneStd = dataRecord["PROLE_SECRET_PHONE_STD"].ConvertTo<String>();
            record.LmPhoneStd = dataRecord["PROLE_LM_PHONE_STD"].ConvertTo<String>();
            record.DelivPoint1 = dataRecord["PROLE_DELIV_POINT1"].ConvertTo<String>();
            record.DelivPoint2 = dataRecord["PROLE_DELIV_POINT2"].ConvertTo<String>();
            record.ShowAddress = dataRecord["PROLE_SHOW_ADDRESS"].ConvertTo<Byte>();
            record.ShowPhone = dataRecord["PROLE_SHOW_PHONE"].ConvertTo<Byte>();
            record.ShowEmail = dataRecord["PROLE_SHOW_EMAIL"].ConvertTo<Byte>();
            record.MemATot = dataRecord["PROLE_MEM_A_TOT"].ConvertTo<Double?>();
            record.SelcoSpId = dataRecord["PROLE_SELCO_SP_ID"].ConvertTo<String>();
            record.CjtAchieved = dataRecord["PROLE_CJT_ACHIEVED"].ConvertTo<Byte?>();
            record.MemRef = dataRecord["PROLE_MEM_REF"].ConvertTo<String>();
            record.HourRte = dataRecord["PROLE_HOUR_RTE"].ConvertTo<Decimal>();
            record.BudhId = dataRecord["PROLE_BUDH_ID"].ConvertTo<String>();
            record.OsId = dataRecord["PROLE_OS_ID"].ConvertTo<Int32?>();
            record.JobLvl = dataRecord["PROLE_JOB_LVL"].ConvertTo<String>();
            record.ReportsTo1 = dataRecord["PROLE_REPORTS_TO_1"].ConvertTo<String>();
            record.OsuId = dataRecord["PROLE_OSU_ID"].ConvertTo<Int32?>();
            record.AjtId = dataRecord["PROLE_AJT_ID"].ConvertTo<Int32?>();
            record.UniqueRef = dataRecord["PROLE_UNIQUE_REF"].ConvertTo<String>();
            record.SendToWhichEmail = dataRecord["PROLE_SEND_TO_WHICH_EMAIL"].ConvertTo<Byte>();
            record.ReptoLineage = dataRecord["PROLE_REPTO_LINEAGE"].ConvertTo<String>();
            record.ReptoDepth = dataRecord["PROLE_REPTO_DEPTH"].ConvertTo<Int32?>();
            record.MembCheck1 = dataRecord["PROLE_MEMB_CHECK_1"].ConvertTo<Byte>();
            record.MembCheck2 = dataRecord["PROLE_MEMB_CHECK_2"].ConvertTo<Byte>();
            record.MembCheck3 = dataRecord["PROLE_MEMB_CHECK_3"].ConvertTo<Byte>();
            record.MembCheck4 = dataRecord["PROLE_MEMB_CHECK_4"].ConvertTo<Byte>();
            record.MembCheck5 = dataRecord["PROLE_MEMB_CHECK_5"].ConvertTo<Byte>();
            record.MembCheck6 = dataRecord["PROLE_MEMB_CHECK_6"].ConvertTo<Byte>();
            record.MembCheck7 = dataRecord["PROLE_MEMB_CHECK_7"].ConvertTo<Byte>();
            record.Userint7 = dataRecord["PROLE_USERINT_7"].ConvertTo<Byte?>();
            record.Userint8 = dataRecord["PROLE_USERINT_8"].ConvertTo<Byte?>();
            record.Userint9 = dataRecord["PROLE_USERINT_9"].ConvertTo<Byte?>();
            record.Userint10 = dataRecord["PROLE_USERINT_10"].ConvertTo<Byte?>();
            record.Userint11 = dataRecord["PROLE_USERINT_11"].ConvertTo<Byte?>();
            record.Overseas = dataRecord["PROLE_OVERSEAS"].ConvertTo<Byte?>();
            record.SendToWhichMobile = dataRecord["PROLE_SEND_TO_WHICH_MOBILE"].ConvertTo<Byte>();
            record.DoNotSpare1 = dataRecord["PROLE_DO_NOT_SPARE1"].ConvertTo<Byte?>();
            record.DoNotSpare2 = dataRecord["PROLE_DO_NOT_SPARE2"].ConvertTo<Byte?>();
            record.DoNotSpare3 = dataRecord["PROLE_DO_NOT_SPARE3"].ConvertTo<Byte?>();
            record.DoNotSpare4 = dataRecord["PROLE_DO_NOT_SPARE4"].ConvertTo<Byte?>();
            record.Area = dataRecord["PROLE_AREA"].ConvertTo<String>();
            record.Region = dataRecord["PROLE_REGION"].ConvertTo<String>();
            record.ProfileDescription = dataRecord["PROLE_PROFILE_DESCRIPTION"].ConvertTo<String>();
            record.DefaultPrId = dataRecord["PROLE_DEFAULT_PR_ID"].ConvertTo<Int32?>();
        }

        /// <summary>
        ///     Sets the parameter values for the specified <paramref name="command" /> based on the specified <typeparamref name="TRecord" /> instance.
        /// </summary>
        /// <param name="command">
        ///     The <see cref="IDbCommand" /> containing the parameters to be mapped.
        /// </param>
        /// <param name="record">
        ///     The <see cref="PersonRoleRecord" /> instance to be mapped.
        /// </param>
        /// <param name="useV6Logic">
        ///     Is the procedure being run an old version 6.x procedure? (the null value handling logic is different).
        /// </param>
        protected override void MapParametersIn(IDbCommand command, PersonRoleRecord record, bool useV6Logic)
        {
            this.MapParameterIn(command, "@PA_PROLE_ID", record.Id);
            this.MapParameterIn(command, "@PA_PROLE_LOCK", record.Lock);
            this.MapParameterIn(command, "@PA_PROLE_PERSON_ID", record.PersonId);
            this.MapParameterIn(command, "@PA_PROLE_ORG_ID", record.OrgId);
            this.MapParameterIn(command, "@PA_PROLE_POS_TITLE", record.PosTitle);
            this.MapParameterIn(command, "@PA_PROLE_DEPT", record.Dept);
            this.MapParameterIn(command, "@PA_PROLE_POS_TYPE", record.PosType);
            this.MapParameterIn(command, "@PA_PROLE_POS_LEVEL", record.PosLevel);
            this.MapParameterIn(command, "@PA_PROLE_PHONE", record.Phone);
            this.MapParameterIn(command, "@PA_PROLE_FAX", record.Fax);
            this.MapParameterIn(command, "@PA_PROLE_MOBILE", record.Mobile);
            this.MapParameterIn(command, "@PA_PROLE_EMAIL1", record.Email1);
            this.MapParameterIn(command, "@PA_PROLE_REPORTS_TO", record.ReportsTo);
            this.MapParameterIn(command, "@PA_PROLE_SECRETARY", record.Secretary);
            this.MapParameterIn(command, "@PA_PROLE_PRINCIP_ROLE", record.PrincipRole);
            this.MapParameterIn(command, "@PA_PROLE_DO_NOT_MAIL", record.DoNotMail);
            this.MapParameterIn(command, "@PA_PROLE_ADD_ID", record.AddId);
            this.MapParameterIn(command, "@PA_PROLE_START_DATE", record.StartDate == DateTime.MinValue ? ( useV6Logic ? new DateTime?(new DateTime(1900,1,1)) : null ) : record.StartDate);
            this.MapParameterIn(command, "@PA_PROLE_END_DATE", record.EndDate == DateTime.MinValue ? ( useV6Logic ? new DateTime?(new DateTime(1900,1,1)) : null ) : record.EndDate);
            this.MapParameterIn(command, "@PA_PROLE_UNION_ROL_NO", record.UnionRolNo);
            this.MapParameterIn(command, "@PA_PROLE_BRANCH_NAME", record.BranchName);
            this.MapParameterIn(command, "@PA_PROLE_FIRST_COURSE", record.FirstCourse == DateTime.MinValue ? ( useV6Logic ? new DateTime?(new DateTime(1900,1,1)) : null ) : record.FirstCourse);
            this.MapParameterIn(command, "@PA_PROLE_TYPE", record.Type);
            this.MapParameterIn(command, "@PA_PROLE_ALT_PHONE", record.AltPhone);
            this.MapParameterIn(command, "@PA_PROLE_ALT_FAX", record.AltFax);
            this.MapParameterIn(command, "@PA_PROLE_BUDGET", record.Budget == Double.MinValue ? ( useV6Logic ? new Double?(0) : null ) : record.Budget);
            this.MapParameterIn(command, "@PA_PROLE_NL_COPIES", record.NlCopies == Double.MinValue ? ( useV6Logic ? new Double?(0) : null ) : record.NlCopies);
            this.MapParameterIn(command, "@PA_PROLE_USER_TYPE", record.UserType);
            this.MapParameterIn(command, "@PA_PROLE_USER_TYPE_1", record.UserType1);
            this.MapParameterIn(command, "@PA_PROLE_USER_TYPE_2", record.UserType2);
            this.MapParameterIn(command, "@PA_PROLE_USER_TYPE_3", record.UserType3);
            this.MapParameterIn(command, "@PA_PROLE_EXEC_CODE", record.ExecCode);
            this.MapParameterIn(command, "@PA_PROLE_USERCHAR_1", record.Userchar1);
            this.MapParameterIn(command, "@PA_PROLE_USERCHAR_2", record.Userchar2);
            this.MapParameterIn(command, "@PA_PROLE_USERCHAR_3", record.Userchar3);
            this.MapParameterIn(command, "@PA_PROLE_USERCHAR_4", record.Userchar4);
            this.MapParameterIn(command, "@PA_PROLE_USERNUM_1", record.Usernum1 == Decimal.MinValue ? ( useV6Logic ? new Decimal?(0M) : null ) : record.Usernum1);
            this.MapParameterIn(command, "@PA_PROLE_USERNUM_2", record.Usernum2 == Decimal.MinValue ? ( useV6Logic ? new Decimal?(0M) : null ) : record.Usernum2);
            this.MapParameterIn(command, "@PA_PROLE_EMAIL", record.Email);
            this.MapParameterIn(command, "@PA_PROLE_ORG_NAME", record.OrgName);
            this.MapParameterIn(command, "@PA_PROLE_PN_NAME", record.PnName);
            this.MapParameterIn(command, "@PA_PROLE_CONTACT_MGR", record.ContactMgr);
            this.MapParameterIn(command, "@PA_PROLE_SOURCE", record.Source);
            this.MapParameterIn(command, "@PA_PROLE_MAIL_LIMIT", record.MailLimit);
            this.MapParameterIn(command, "@PA_PROLE_UNTIL", record.Until == DateTime.MinValue ? ( useV6Logic ? new DateTime?(new DateTime(1900,1,1)) : null ) : record.Until);
            this.MapParameterIn(command, "@PA_PROLE_MAIL_NOLIMIT", record.MailNolimit);
            this.MapParameterIn(command, "@PA_PROLE_EXT_ID_1", record.ExtId1);
            this.MapParameterIn(command, "@PA_PROLE_EXT_ID_2", record.ExtId2);
            this.MapParameterIn(command, "@PA_PROLE_EXT_ID_3", record.ExtId3);
            this.MapParameterIn(command, "@PA_PROLE_SECRET_PHONE", record.SecretPhone);
            this.MapParameterIn(command, "@PA_PROLE_NOTES", record.Notes);
            this.MapParameterIn(command, "@PA_PROLE_LBST_DATE", record.LbstDate == DateTime.MinValue ? ( useV6Logic ? new DateTime?(new DateTime(1900,1,1)) : null ) : record.LbstDate);
            this.MapParameterIn(command, "@PA_PROLE_POST_SPEC", record.PostSpec);
            this.MapParameterIn(command, "@PA_PROLE_SCALE_POINT", record.ScalePoint == Int32.MinValue ? ( useV6Logic ? new Int32?(0) : null ) : record.ScalePoint);
            this.MapParameterIn(command, "@PA_PROLE_GRADE_BAND", record.GradeBand);
            this.MapParameterIn(command, "@PA_PROLE_DIS_FLAG", record.DisFlag);
            this.MapParameterIn(command, "@PA_PROLE_WEB_PROF", record.WebProf);
            this.MapParameterIn(command, "@PA_PROLE_WEB_PASS", record.WebPass);
            this.MapParameterIn(command, "@PA_PROLE_CUSTOMER_ACC", record.CustomerAcc);
            this.MapParameterIn(command, "@PA_PROLE_CJT_ID", record.CjtId);
            this.MapParameterIn(command, "@PA_PROLE_PAYROLL", record.Payroll);
            this.MapParameterIn(command, "@PA_PROLE_STAFF_NO", record.StaffNo);
            this.MapParameterIn(command, "@PA_PROLE_COST_CENTRE", record.CostCentre);
            this.MapParameterIn(command, "@PA_PROLE_KEY_CONTACT", record.KeyContact);
            this.MapParameterIn(command, "@PA_PROLE_MEM_C_TOT", record.MemCTot == Double.MinValue ? ( useV6Logic ? new Double?(0) : null ) : record.MemCTot);
            this.MapParameterIn(command, "@PA_PROLE_MEM_R_TOT", record.MemRTot == Double.MinValue ? ( useV6Logic ? new Double?(0) : null ) : record.MemRTot);
            this.MapParameterIn(command, "@PA_PROLE_MEM_L_TOT", record.MemLTot == Double.MinValue ? ( useV6Logic ? new Double?(0) : null ) : record.MemLTot);
            this.MapParameterIn(command, "@PA_PROLE_CONTACT_MGR2", record.ContactMgr2);
            this.MapParameterIn(command, "@PA_PROLE_USERCHAR_5", record.Userchar5);
            this.MapParameterIn(command, "@PA_PROLE_USERCHAR_6", record.Userchar6);
            this.MapParameterIn(command, "@PA_PROLE_USERINT_1", record.Userint1);
            this.MapParameterIn(command, "@PA_PROLE_USERINT_2", record.Userint2);
            this.MapParameterIn(command, "@PA_PROLE_USERINT_3", record.Userint3);
            this.MapParameterIn(command, "@PA_PROLE_USERINT_4", record.Userint4);
            this.MapParameterIn(command, "@PA_PROLE_USERINT_5", record.Userint5);
            this.MapParameterIn(command, "@PA_PROLE_USERINT_6", record.Userint6);
            this.MapParameterIn(command, "@PA_PROLE_USERNUM_3", record.Usernum3 == Decimal.MinValue ? ( useV6Logic ? new Decimal?(0M) : null ) : record.Usernum3);
            this.MapParameterIn(command, "@PA_PROLE_USERNUM_4", record.Usernum4 == Decimal.MinValue ? ( useV6Logic ? new Decimal?(0M) : null ) : record.Usernum4);
            this.MapParameterIn(command, "@PA_PROLE_USERNUM_5", record.Usernum5 == Decimal.MinValue ? ( useV6Logic ? new Decimal?(0M) : null ) : record.Usernum5);
            this.MapParameterIn(command, "@PA_PROLE_USERNUM_6", record.Usernum6 == Decimal.MinValue ? ( useV6Logic ? new Decimal?(0M) : null ) : record.Usernum6);
            this.MapParameterIn(command, "@PA_PROLE_USERDATE_1", record.Userdate1 == DateTime.MinValue ? ( useV6Logic ? new DateTime?(new DateTime(1900,1,1)) : null ) : record.Userdate1);
            this.MapParameterIn(command, "@PA_PROLE_USERDATE_2", record.Userdate2 == DateTime.MinValue ? ( useV6Logic ? new DateTime?(new DateTime(1900,1,1)) : null ) : record.Userdate2);
            this.MapParameterIn(command, "@PA_PROLE_USERDATE_3", record.Userdate3 == DateTime.MinValue ? ( useV6Logic ? new DateTime?(new DateTime(1900,1,1)) : null ) : record.Userdate3);
            this.MapParameterIn(command, "@PA_PROLE_USERDATE_4", record.Userdate4 == DateTime.MinValue ? ( useV6Logic ? new DateTime?(new DateTime(1900,1,1)) : null ) : record.Userdate4);
            this.MapParameterIn(command, "@PA_PROLE_USERDATE_5", record.Userdate5 == DateTime.MinValue ? ( useV6Logic ? new DateTime?(new DateTime(1900,1,1)) : null ) : record.Userdate5);
            this.MapParameterIn(command, "@PA_PROLE_USERDATE_6", record.Userdate6 == DateTime.MinValue ? ( useV6Logic ? new DateTime?(new DateTime(1900,1,1)) : null ) : record.Userdate6);
            this.MapParameterIn(command, "@PA_PROLE_DO_NOT_FAX", record.DoNotFax);
            this.MapParameterIn(command, "@PA_PROLE_DO_NOT_EMAIL", record.DoNotEmail);
            this.MapParameterIn(command, "@PA_PROLE_DO_NOT_SWAP", record.DoNotSwap);
            this.MapParameterIn(command, "@PA_PROLE_DO_NOT_SPARE", record.DoNotSpare);
            this.MapParameterIn(command, "@PA_PROLE_PRIVATE_ADD", record.PrivateAdd);
            this.MapParameterIn(command, "@PA_PROLE_COST_CODE", record.CostCode);
            this.MapParameterIn(command, "@PA_PROLE_MAIN_WORKADD", record.MainWorkadd);
            this.MapParameterIn(command, "@PA_PROLE_MAIN_PRIVADD", record.MainPrivadd);
            this.MapParameterIn(command, "@PA_PROLE_WORK_ADD", record.WorkAdd);
            this.MapParameterIn(command, "@PA_PROLE_LM_PHONE", record.LmPhone);
            this.MapParameterIn(command, "@PA_PROLE_LM_EMAIL", record.LmEmail);
            this.MapParameterIn(command, "@PA_PROLE_SERVICE", record.Service);
            this.MapParameterIn(command, "@PA_PROLE_PAY_LOCATION", record.PayLocation);
            this.MapParameterIn(command, "@PA_PROLE_BA", record.Ba);
            this.MapParameterIn(command, "@PA_PROLE_BA1", record.Ba1);
            this.MapParameterIn(command, "@PA_PROLE_TRN_ADMIN", record.TrnAdmin);
            this.MapParameterIn(command, "@PA_PROLE_ATTRIB_NUM_01", record.AttribNum01 == Int32.MinValue ? ( useV6Logic ? new Int32?(0) : null ) : record.AttribNum01);
            this.MapParameterIn(command, "@PA_PROLE_ATTRIB_CHAR_01", record.AttribChar01);
            this.MapParameterIn(command, "@PA_PROLE_ATTRIB_TINT_01", record.AttribTint01);
            this.MapParameterIn(command, "@PA_PROLE_WTE", record.Wte == Decimal.MinValue ? ( useV6Logic ? new Decimal?(0M) : null ) : record.Wte);
            this.MapParameterIn(command, "@PA_PROLE_PHONE_STD", record.PhoneStd);
            this.MapParameterIn(command, "@PA_PROLE_FAX_STD", record.FaxStd);
            this.MapParameterIn(command, "@PA_PROLE_ALT_PHONE_STD", record.AltPhoneStd);
            this.MapParameterIn(command, "@PA_PROLE_ALT_FAX_STD", record.AltFaxStd);
            this.MapParameterIn(command, "@PA_PROLE_SECRET_PHONE_STD", record.SecretPhoneStd);
            this.MapParameterIn(command, "@PA_PROLE_LM_PHONE_STD", record.LmPhoneStd);
            this.MapParameterIn(command, "@PA_PROLE_DELIV_POINT1", record.DelivPoint1);
            this.MapParameterIn(command, "@PA_PROLE_DELIV_POINT2", record.DelivPoint2);
            this.MapParameterIn(command, "@PA_PROLE_SHOW_ADDRESS", record.ShowAddress);
            this.MapParameterIn(command, "@PA_PROLE_SHOW_PHONE", record.ShowPhone);
            this.MapParameterIn(command, "@PA_PROLE_SHOW_EMAIL", record.ShowEmail);
            this.MapParameterIn(command, "@PA_PROLE_MEM_A_TOT", record.MemATot == Double.MinValue ? ( useV6Logic ? new Double?(0) : null ) : record.MemATot);
            this.MapParameterIn(command, "@PA_PROLE_SELCO_SP_ID", record.SelcoSpId);
            this.MapParameterIn(command, "@PA_PROLE_CJT_ACHIEVED", record.CjtAchieved);
            this.MapParameterIn(command, "@PA_PROLE_MEM_REF", record.MemRef);
            this.MapParameterIn(command, "@PA_PROLE_HOUR_RTE", record.HourRte == Decimal.MinValue ? 0M : record.HourRte);
            this.MapParameterIn(command, "@PA_PROLE_BUDH_ID", record.BudhId);
            this.MapParameterIn(command, "@PA_PROLE_OS_ID", record.OsId == Int32.MinValue ? ( useV6Logic ? new Int32?(0) : null ) : record.OsId);
            this.MapParameterIn(command, "@PA_PROLE_JOB_LVL", record.JobLvl);
            this.MapParameterIn(command, "@PA_PROLE_REPORTS_TO_1", record.ReportsTo1);
            this.MapParameterIn(command, "@PA_PROLE_OSU_ID", record.OsuId == Int32.MinValue ? ( useV6Logic ? new Int32?(0) : null ) : record.OsuId);
            this.MapParameterIn(command, "@PA_PROLE_AJT_ID", record.AjtId == Int32.MinValue ? ( useV6Logic ? new Int32?(0) : null ) : record.AjtId);
            this.MapParameterIn(command, "@PA_PROLE_UNIQUE_REF", record.UniqueRef);
            this.MapParameterIn(command, "@PA_PROLE_SEND_TO_WHICH_EMAIL", record.SendToWhichEmail);
            this.MapParameterIn(command, "@PA_PROLE_REPTO_LINEAGE", record.ReptoLineage);
            this.MapParameterIn(command, "@PA_PROLE_REPTO_DEPTH", record.ReptoDepth == Int32.MinValue ? ( useV6Logic ? new Int32?(0) : null ) : record.ReptoDepth);
            this.MapParameterIn(command, "@PA_PROLE_MEMB_CHECK_1", record.MembCheck1);
            this.MapParameterIn(command, "@PA_PROLE_MEMB_CHECK_2", record.MembCheck2);
            this.MapParameterIn(command, "@PA_PROLE_MEMB_CHECK_3", record.MembCheck3);
            this.MapParameterIn(command, "@PA_PROLE_MEMB_CHECK_4", record.MembCheck4);
            this.MapParameterIn(command, "@PA_PROLE_MEMB_CHECK_5", record.MembCheck5);
            this.MapParameterIn(command, "@PA_PROLE_MEMB_CHECK_6", record.MembCheck6);
            this.MapParameterIn(command, "@PA_PROLE_MEMB_CHECK_7", record.MembCheck7);
            this.MapParameterIn(command, "@PA_PROLE_USERINT_7", record.Userint7);
            this.MapParameterIn(command, "@PA_PROLE_USERINT_8", record.Userint8);
            this.MapParameterIn(command, "@PA_PROLE_USERINT_9", record.Userint9);
            this.MapParameterIn(command, "@PA_PROLE_USERINT_10", record.Userint10);
            this.MapParameterIn(command, "@PA_PROLE_USERINT_11", record.Userint11);
            this.MapParameterIn(command, "@PA_PROLE_OVERSEAS", record.Overseas);
            this.MapParameterIn(command, "@PA_PROLE_SEND_TO_WHICH_MOBILE", record.SendToWhichMobile);
            this.MapParameterIn(command, "@PA_PROLE_DO_NOT_SPARE1", record.DoNotSpare1);
            this.MapParameterIn(command, "@PA_PROLE_DO_NOT_SPARE2", record.DoNotSpare2);
            this.MapParameterIn(command, "@PA_PROLE_DO_NOT_SPARE3", record.DoNotSpare3);
            this.MapParameterIn(command, "@PA_PROLE_DO_NOT_SPARE4", record.DoNotSpare4);
            this.MapParameterIn(command, "@PA_PROLE_AREA", record.Area);
            this.MapParameterIn(command, "@PA_PROLE_REGION", record.Region);
            this.MapParameterIn(command, "@PA_PROLE_PROFILE_DESCRIPTION", record.ProfileDescription);
            this.MapParameterIn(command, "@PA_PROLE_DEFAULT_PR_ID", record.DefaultPrId == Int32.MinValue ? ( useV6Logic ? new Int32?(0) : null ) : record.DefaultPrId);
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
        ///     The <see cref="PersonRoleRecord" /> instance to be updated.
        /// </param>
        protected override void MapParametersOut(IDbCommand command, PersonRoleRecord record)
        {
            record.Id = this.MapParameterOut(command, "@PA_PROLE_ID", record.Id);
            record.Lock = this.MapParameterOut(command, "@PA_PROLE_LOCK", record.Lock);
            record.PersonId = this.MapParameterOut(command, "@PA_PROLE_PERSON_ID", record.PersonId);
            record.OrgId = this.MapParameterOut(command, "@PA_PROLE_ORG_ID", record.OrgId);
            record.PosTitle = this.MapParameterOut(command, "@PA_PROLE_POS_TITLE", record.PosTitle);
            record.Dept = this.MapParameterOut(command, "@PA_PROLE_DEPT", record.Dept);
            record.PosType = this.MapParameterOut(command, "@PA_PROLE_POS_TYPE", record.PosType);
            record.PosLevel = this.MapParameterOut(command, "@PA_PROLE_POS_LEVEL", record.PosLevel);
            record.Phone = this.MapParameterOut(command, "@PA_PROLE_PHONE", record.Phone);
            record.Fax = this.MapParameterOut(command, "@PA_PROLE_FAX", record.Fax);
            record.Mobile = this.MapParameterOut(command, "@PA_PROLE_MOBILE", record.Mobile);
            record.Email1 = this.MapParameterOut(command, "@PA_PROLE_EMAIL1", record.Email1);
            record.ReportsTo = this.MapParameterOut(command, "@PA_PROLE_REPORTS_TO", record.ReportsTo);
            record.Secretary = this.MapParameterOut(command, "@PA_PROLE_SECRETARY", record.Secretary);
            record.PrincipRole = this.MapParameterOut(command, "@PA_PROLE_PRINCIP_ROLE", record.PrincipRole);
            record.DoNotMail = this.MapParameterOut(command, "@PA_PROLE_DO_NOT_MAIL", record.DoNotMail);
            record.AddId = this.MapParameterOut(command, "@PA_PROLE_ADD_ID", record.AddId);
            record.StartDate = this.MapParameterOut(command, "@PA_PROLE_START_DATE", record.StartDate);
            record.EndDate = this.MapParameterOut(command, "@PA_PROLE_END_DATE", record.EndDate);
            record.UnionRolNo = this.MapParameterOut(command, "@PA_PROLE_UNION_ROL_NO", record.UnionRolNo);
            record.BranchName = this.MapParameterOut(command, "@PA_PROLE_BRANCH_NAME", record.BranchName);
            record.FirstCourse = this.MapParameterOut(command, "@PA_PROLE_FIRST_COURSE", record.FirstCourse);
            record.Type = this.MapParameterOut(command, "@PA_PROLE_TYPE", record.Type);
            record.AltPhone = this.MapParameterOut(command, "@PA_PROLE_ALT_PHONE", record.AltPhone);
            record.AltFax = this.MapParameterOut(command, "@PA_PROLE_ALT_FAX", record.AltFax);
            record.Budget = this.MapParameterOut(command, "@PA_PROLE_BUDGET", record.Budget);
            record.NlCopies = this.MapParameterOut(command, "@PA_PROLE_NL_COPIES", record.NlCopies);
            record.UserType = this.MapParameterOut(command, "@PA_PROLE_USER_TYPE", record.UserType);
            record.UserType1 = this.MapParameterOut(command, "@PA_PROLE_USER_TYPE_1", record.UserType1);
            record.UserType2 = this.MapParameterOut(command, "@PA_PROLE_USER_TYPE_2", record.UserType2);
            record.UserType3 = this.MapParameterOut(command, "@PA_PROLE_USER_TYPE_3", record.UserType3);
            record.ExecCode = this.MapParameterOut(command, "@PA_PROLE_EXEC_CODE", record.ExecCode);
            record.Userchar1 = this.MapParameterOut(command, "@PA_PROLE_USERCHAR_1", record.Userchar1);
            record.Userchar2 = this.MapParameterOut(command, "@PA_PROLE_USERCHAR_2", record.Userchar2);
            record.Userchar3 = this.MapParameterOut(command, "@PA_PROLE_USERCHAR_3", record.Userchar3);
            record.Userchar4 = this.MapParameterOut(command, "@PA_PROLE_USERCHAR_4", record.Userchar4);
            record.Usernum1 = this.MapParameterOut(command, "@PA_PROLE_USERNUM_1", record.Usernum1);
            record.Usernum2 = this.MapParameterOut(command, "@PA_PROLE_USERNUM_2", record.Usernum2);
            record.Email = this.MapParameterOut(command, "@PA_PROLE_EMAIL", record.Email);
            record.OrgName = this.MapParameterOut(command, "@PA_PROLE_ORG_NAME", record.OrgName);
            record.PnName = this.MapParameterOut(command, "@PA_PROLE_PN_NAME", record.PnName);
            record.ContactMgr = this.MapParameterOut(command, "@PA_PROLE_CONTACT_MGR", record.ContactMgr);
            record.Source = this.MapParameterOut(command, "@PA_PROLE_SOURCE", record.Source);
            record.MailLimit = this.MapParameterOut(command, "@PA_PROLE_MAIL_LIMIT", record.MailLimit);
            record.Until = this.MapParameterOut(command, "@PA_PROLE_UNTIL", record.Until);
            record.MailNolimit = this.MapParameterOut(command, "@PA_PROLE_MAIL_NOLIMIT", record.MailNolimit);
            record.ExtId1 = this.MapParameterOut(command, "@PA_PROLE_EXT_ID_1", record.ExtId1);
            record.ExtId2 = this.MapParameterOut(command, "@PA_PROLE_EXT_ID_2", record.ExtId2);
            record.ExtId3 = this.MapParameterOut(command, "@PA_PROLE_EXT_ID_3", record.ExtId3);
            record.SecretPhone = this.MapParameterOut(command, "@PA_PROLE_SECRET_PHONE", record.SecretPhone);
            record.Notes = this.MapParameterOut(command, "@PA_PROLE_NOTES", record.Notes);
            record.LbstDate = this.MapParameterOut(command, "@PA_PROLE_LBST_DATE", record.LbstDate);
            record.PostSpec = this.MapParameterOut(command, "@PA_PROLE_POST_SPEC", record.PostSpec);
            record.ScalePoint = this.MapParameterOut(command, "@PA_PROLE_SCALE_POINT", record.ScalePoint);
            record.GradeBand = this.MapParameterOut(command, "@PA_PROLE_GRADE_BAND", record.GradeBand);
            record.DisFlag = this.MapParameterOut(command, "@PA_PROLE_DIS_FLAG", record.DisFlag);
            record.WebProf = this.MapParameterOut(command, "@PA_PROLE_WEB_PROF", record.WebProf);
            record.WebPass = this.MapParameterOut(command, "@PA_PROLE_WEB_PASS", record.WebPass);
            record.CustomerAcc = this.MapParameterOut(command, "@PA_PROLE_CUSTOMER_ACC", record.CustomerAcc);
            record.CjtId = this.MapParameterOut(command, "@PA_PROLE_CJT_ID", record.CjtId);
            record.Payroll = this.MapParameterOut(command, "@PA_PROLE_PAYROLL", record.Payroll);
            record.StaffNo = this.MapParameterOut(command, "@PA_PROLE_STAFF_NO", record.StaffNo);
            record.CostCentre = this.MapParameterOut(command, "@PA_PROLE_COST_CENTRE", record.CostCentre);
            record.KeyContact = this.MapParameterOut(command, "@PA_PROLE_KEY_CONTACT", record.KeyContact);
            record.MemCTot = this.MapParameterOut(command, "@PA_PROLE_MEM_C_TOT", record.MemCTot);
            record.MemRTot = this.MapParameterOut(command, "@PA_PROLE_MEM_R_TOT", record.MemRTot);
            record.MemLTot = this.MapParameterOut(command, "@PA_PROLE_MEM_L_TOT", record.MemLTot);
            record.ContactMgr2 = this.MapParameterOut(command, "@PA_PROLE_CONTACT_MGR2", record.ContactMgr2);
            record.Userchar5 = this.MapParameterOut(command, "@PA_PROLE_USERCHAR_5", record.Userchar5);
            record.Userchar6 = this.MapParameterOut(command, "@PA_PROLE_USERCHAR_6", record.Userchar6);
            record.Userint1 = this.MapParameterOut(command, "@PA_PROLE_USERINT_1", record.Userint1);
            record.Userint2 = this.MapParameterOut(command, "@PA_PROLE_USERINT_2", record.Userint2);
            record.Userint3 = this.MapParameterOut(command, "@PA_PROLE_USERINT_3", record.Userint3);
            record.Userint4 = this.MapParameterOut(command, "@PA_PROLE_USERINT_4", record.Userint4);
            record.Userint5 = this.MapParameterOut(command, "@PA_PROLE_USERINT_5", record.Userint5);
            record.Userint6 = this.MapParameterOut(command, "@PA_PROLE_USERINT_6", record.Userint6);
            record.Usernum3 = this.MapParameterOut(command, "@PA_PROLE_USERNUM_3", record.Usernum3);
            record.Usernum4 = this.MapParameterOut(command, "@PA_PROLE_USERNUM_4", record.Usernum4);
            record.Usernum5 = this.MapParameterOut(command, "@PA_PROLE_USERNUM_5", record.Usernum5);
            record.Usernum6 = this.MapParameterOut(command, "@PA_PROLE_USERNUM_6", record.Usernum6);
            record.Userdate1 = this.MapParameterOut(command, "@PA_PROLE_USERDATE_1", record.Userdate1);
            record.Userdate2 = this.MapParameterOut(command, "@PA_PROLE_USERDATE_2", record.Userdate2);
            record.Userdate3 = this.MapParameterOut(command, "@PA_PROLE_USERDATE_3", record.Userdate3);
            record.Userdate4 = this.MapParameterOut(command, "@PA_PROLE_USERDATE_4", record.Userdate4);
            record.Userdate5 = this.MapParameterOut(command, "@PA_PROLE_USERDATE_5", record.Userdate5);
            record.Userdate6 = this.MapParameterOut(command, "@PA_PROLE_USERDATE_6", record.Userdate6);
            record.DoNotFax = this.MapParameterOut(command, "@PA_PROLE_DO_NOT_FAX", record.DoNotFax);
            record.DoNotEmail = this.MapParameterOut(command, "@PA_PROLE_DO_NOT_EMAIL", record.DoNotEmail);
            record.DoNotSwap = this.MapParameterOut(command, "@PA_PROLE_DO_NOT_SWAP", record.DoNotSwap);
            record.DoNotSpare = this.MapParameterOut(command, "@PA_PROLE_DO_NOT_SPARE", record.DoNotSpare);
            record.PrivateAdd = this.MapParameterOut(command, "@PA_PROLE_PRIVATE_ADD", record.PrivateAdd);
            record.CostCode = this.MapParameterOut(command, "@PA_PROLE_COST_CODE", record.CostCode);
            record.MainWorkadd = this.MapParameterOut(command, "@PA_PROLE_MAIN_WORKADD", record.MainWorkadd);
            record.MainPrivadd = this.MapParameterOut(command, "@PA_PROLE_MAIN_PRIVADD", record.MainPrivadd);
            record.WorkAdd = this.MapParameterOut(command, "@PA_PROLE_WORK_ADD", record.WorkAdd);
            record.LmPhone = this.MapParameterOut(command, "@PA_PROLE_LM_PHONE", record.LmPhone);
            record.LmEmail = this.MapParameterOut(command, "@PA_PROLE_LM_EMAIL", record.LmEmail);
            record.Service = this.MapParameterOut(command, "@PA_PROLE_SERVICE", record.Service);
            record.PayLocation = this.MapParameterOut(command, "@PA_PROLE_PAY_LOCATION", record.PayLocation);
            record.Ba = this.MapParameterOut(command, "@PA_PROLE_BA", record.Ba);
            record.Ba1 = this.MapParameterOut(command, "@PA_PROLE_BA1", record.Ba1);
            record.TrnAdmin = this.MapParameterOut(command, "@PA_PROLE_TRN_ADMIN", record.TrnAdmin);
            record.AttribNum01 = this.MapParameterOut(command, "@PA_PROLE_ATTRIB_NUM_01", record.AttribNum01);
            record.AttribChar01 = this.MapParameterOut(command, "@PA_PROLE_ATTRIB_CHAR_01", record.AttribChar01);
            record.AttribTint01 = this.MapParameterOut(command, "@PA_PROLE_ATTRIB_TINT_01", record.AttribTint01);
            record.Wte = this.MapParameterOut(command, "@PA_PROLE_WTE", record.Wte);
            record.PhoneStd = this.MapParameterOut(command, "@PA_PROLE_PHONE_STD", record.PhoneStd);
            record.FaxStd = this.MapParameterOut(command, "@PA_PROLE_FAX_STD", record.FaxStd);
            record.AltPhoneStd = this.MapParameterOut(command, "@PA_PROLE_ALT_PHONE_STD", record.AltPhoneStd);
            record.AltFaxStd = this.MapParameterOut(command, "@PA_PROLE_ALT_FAX_STD", record.AltFaxStd);
            record.SecretPhoneStd = this.MapParameterOut(command, "@PA_PROLE_SECRET_PHONE_STD", record.SecretPhoneStd);
            record.LmPhoneStd = this.MapParameterOut(command, "@PA_PROLE_LM_PHONE_STD", record.LmPhoneStd);
            record.DelivPoint1 = this.MapParameterOut(command, "@PA_PROLE_DELIV_POINT1", record.DelivPoint1);
            record.DelivPoint2 = this.MapParameterOut(command, "@PA_PROLE_DELIV_POINT2", record.DelivPoint2);
            record.ShowAddress = this.MapParameterOut(command, "@PA_PROLE_SHOW_ADDRESS", record.ShowAddress);
            record.ShowPhone = this.MapParameterOut(command, "@PA_PROLE_SHOW_PHONE", record.ShowPhone);
            record.ShowEmail = this.MapParameterOut(command, "@PA_PROLE_SHOW_EMAIL", record.ShowEmail);
            record.MemATot = this.MapParameterOut(command, "@PA_PROLE_MEM_A_TOT", record.MemATot);
            record.SelcoSpId = this.MapParameterOut(command, "@PA_PROLE_SELCO_SP_ID", record.SelcoSpId);
            record.CjtAchieved = this.MapParameterOut(command, "@PA_PROLE_CJT_ACHIEVED", record.CjtAchieved);
            record.MemRef = this.MapParameterOut(command, "@PA_PROLE_MEM_REF", record.MemRef);
            record.HourRte = this.MapParameterOut(command, "@PA_PROLE_HOUR_RTE", record.HourRte);
            record.BudhId = this.MapParameterOut(command, "@PA_PROLE_BUDH_ID", record.BudhId);
            record.OsId = this.MapParameterOut(command, "@PA_PROLE_OS_ID", record.OsId);
            record.JobLvl = this.MapParameterOut(command, "@PA_PROLE_JOB_LVL", record.JobLvl);
            record.ReportsTo1 = this.MapParameterOut(command, "@PA_PROLE_REPORTS_TO_1", record.ReportsTo1);
            record.OsuId = this.MapParameterOut(command, "@PA_PROLE_OSU_ID", record.OsuId);
            record.AjtId = this.MapParameterOut(command, "@PA_PROLE_AJT_ID", record.AjtId);
            record.UniqueRef = this.MapParameterOut(command, "@PA_PROLE_UNIQUE_REF", record.UniqueRef);
            record.SendToWhichEmail = this.MapParameterOut(command, "@PA_PROLE_SEND_TO_WHICH_EMAIL", record.SendToWhichEmail);
            record.ReptoLineage = this.MapParameterOut(command, "@PA_PROLE_REPTO_LINEAGE", record.ReptoLineage);
            record.ReptoDepth = this.MapParameterOut(command, "@PA_PROLE_REPTO_DEPTH", record.ReptoDepth);
            record.MembCheck1 = this.MapParameterOut(command, "@PA_PROLE_MEMB_CHECK_1", record.MembCheck1);
            record.MembCheck2 = this.MapParameterOut(command, "@PA_PROLE_MEMB_CHECK_2", record.MembCheck2);
            record.MembCheck3 = this.MapParameterOut(command, "@PA_PROLE_MEMB_CHECK_3", record.MembCheck3);
            record.MembCheck4 = this.MapParameterOut(command, "@PA_PROLE_MEMB_CHECK_4", record.MembCheck4);
            record.MembCheck5 = this.MapParameterOut(command, "@PA_PROLE_MEMB_CHECK_5", record.MembCheck5);
            record.MembCheck6 = this.MapParameterOut(command, "@PA_PROLE_MEMB_CHECK_6", record.MembCheck6);
            record.MembCheck7 = this.MapParameterOut(command, "@PA_PROLE_MEMB_CHECK_7", record.MembCheck7);
            record.Userint7 = this.MapParameterOut(command, "@PA_PROLE_USERINT_7", record.Userint7);
            record.Userint8 = this.MapParameterOut(command, "@PA_PROLE_USERINT_8", record.Userint8);
            record.Userint9 = this.MapParameterOut(command, "@PA_PROLE_USERINT_9", record.Userint9);
            record.Userint10 = this.MapParameterOut(command, "@PA_PROLE_USERINT_10", record.Userint10);
            record.Userint11 = this.MapParameterOut(command, "@PA_PROLE_USERINT_11", record.Userint11);
            record.Overseas = this.MapParameterOut(command, "@PA_PROLE_OVERSEAS", record.Overseas);
            record.SendToWhichMobile = this.MapParameterOut(command, "@PA_PROLE_SEND_TO_WHICH_MOBILE", record.SendToWhichMobile);
            record.DoNotSpare1 = this.MapParameterOut(command, "@PA_PROLE_DO_NOT_SPARE1", record.DoNotSpare1);
            record.DoNotSpare2 = this.MapParameterOut(command, "@PA_PROLE_DO_NOT_SPARE2", record.DoNotSpare2);
            record.DoNotSpare3 = this.MapParameterOut(command, "@PA_PROLE_DO_NOT_SPARE3", record.DoNotSpare3);
            record.DoNotSpare4 = this.MapParameterOut(command, "@PA_PROLE_DO_NOT_SPARE4", record.DoNotSpare4);
            record.Area = this.MapParameterOut(command, "@PA_PROLE_AREA", record.Area);
            record.Region = this.MapParameterOut(command, "@PA_PROLE_REGION", record.Region);
            record.ProfileDescription = this.MapParameterOut(command, "@PA_PROLE_PROFILE_DESCRIPTION", record.ProfileDescription);
            record.DefaultPrId = this.MapParameterOut(command, "@PA_PROLE_DEFAULT_PR_ID", record.DefaultPrId);
            record.Id = this.MapParameterOut(command, "@PA_RETURN_ID", record.Id);
        }

        /// <summary>
        ///     Retrieves a collection of <see cref="PersonRoleRecord" /> instances from the data store.
        /// </summary>
        /// <param name="personId">
        ///     The value which identifies the <see cref='RoleModel' /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The collection of <see cref="PersonRoleRecord" /> instances that match the specified <paramref name='personId' />.
        /// </returns>
        public IEnumerable<PersonRoleRecord> FetchAllByPersonId(String personId)
        {
            DbCommand command = this.GetStoredProcedure(SqlServerOperation.FetchAll, "PersonId");
            this.MapParameterIn(command, "@PA_PROLE_PERSON_ID", personId);
            return this.Execute(command);
        }

        /// <summary>
        ///     Retrieves a collection of <see cref="PersonRoleRecord" /> instances from the data store.
        /// </summary>
        /// <param name="orgId">
        ///     The value which identifies the <see cref='RoleModel' /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The collection of <see cref="PersonRoleRecord" /> instances that match the specified <paramref name='orgId' />.
        /// </returns>
        public IEnumerable<PersonRoleRecord> FetchAllByOrgId(String orgId)
        {
            DbCommand command = this.GetStoredProcedure(SqlServerOperation.FetchAll, "OrgId");
            this.MapParameterIn(command, "@PA_PROLE_ORG_ID", orgId);
            return this.Execute(command);
        }

        /// <summary>
        ///     Retrieves a collection of <see cref="PersonRoleRecord" /> instances from the data store.
        /// </summary>
        /// <param name="addId">
        ///     The value which identifies the <see cref='RoleModel' /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The collection of <see cref="PersonRoleRecord" /> instances that match the specified <paramref name='addId' />.
        /// </returns>
        public IEnumerable<PersonRoleRecord> FetchAllByAddId(String addId)
        {
            DbCommand command = this.GetStoredProcedure(SqlServerOperation.FetchAll, "AddId");
            this.MapParameterIn(command, "@PA_PROLE_ADD_ID", addId);
            return this.Execute(command);
        }

        /// <summary>
        ///     Retrieves a collection of <see cref="PersonRoleRecord" /> instances from the data store.
        /// </summary>
        /// <param name="selcoSpId">
        ///     The value which identifies the <see cref='RoleModel' /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The collection of <see cref="PersonRoleRecord" /> instances that match the specified <paramref name='selcoSpId' />.
        /// </returns>
        public IEnumerable<PersonRoleRecord> FetchAllBySelcoSpId(String selcoSpId)
        {
            DbCommand command = this.GetStoredProcedure(SqlServerOperation.FetchAll, "SelcoSpId");
            this.MapParameterIn(command, "@PA_PROLE_SELCO_SP_ID", selcoSpId);
            return this.Execute(command);
        }

        #endregion

        #region implementations

        /// <summary>
        ///     Gets the underlying table name that this repository sit over.
        /// </summary>
        System.String IRoleRepository.TableName
        {
            get { return this.TableName; }
        }

        void IRoleRepository.Create(Consensus.Contact.PersonRoleRecord record)
        {
            this.Create(record);
        }

        void IRoleRepository.Modify(Consensus.Contact.PersonRoleRecord record)
        {
            this.Modify(record);
        }

        /// <summary>
        ///     Retrieves a collection of <see cref="T:Consensus.Contact.PersonRoleRecord" /> instances from the data store.
        /// </summary>
        /// <param name="personId">
        ///     The value which identifies the <see cref="!:RoleModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The collection of <see cref="T:Consensus.Contact.PersonRoleRecord" /> instances that match the specified <paramref name="personId" />.
        /// </returns>
        System.Collections.Generic.IEnumerable<Consensus.Contact.PersonRoleRecord> IRoleRepository.FetchAllByPersonId(System.String personId)
        {
            return this.FetchAllByPersonId(personId);
        }

        /// <summary>
        ///     Retrieves a collection of <see cref="T:Consensus.Contact.PersonRoleRecord" /> instances from the data store.
        /// </summary>
        /// <param name="orgId">
        ///     The value which identifies the <see cref="!:RoleModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The collection of <see cref="T:Consensus.Contact.PersonRoleRecord" /> instances that match the specified <paramref name="orgId" />.
        /// </returns>
        System.Collections.Generic.IEnumerable<Consensus.Contact.PersonRoleRecord> IRoleRepository.FetchAllByOrgId(System.String orgId)
        {
            return this.FetchAllByOrgId(orgId);
        }

        /// <summary>
        ///     Retrieves a collection of <see cref="T:Consensus.Contact.PersonRoleRecord" /> instances from the data store.
        /// </summary>
        /// <param name="addId">
        ///     The value which identifies the <see cref="!:RoleModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The collection of <see cref="T:Consensus.Contact.PersonRoleRecord" /> instances that match the specified <paramref name="addId" />.
        /// </returns>
        System.Collections.Generic.IEnumerable<Consensus.Contact.PersonRoleRecord> IRoleRepository.FetchAllByAddId(System.String addId)
        {
            return this.FetchAllByAddId(addId);
        }

        /// <summary>
        ///     Retrieves a collection of <see cref="T:Consensus.Contact.PersonRoleRecord" /> instances from the data store.
        /// </summary>
        /// <param name="selcoSpId">
        ///     The value which identifies the <see cref="!:RoleModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The collection of <see cref="T:Consensus.Contact.PersonRoleRecord" /> instances that match the specified <paramref name="selcoSpId" />.
        /// </returns>
        System.Collections.Generic.IEnumerable<Consensus.Contact.PersonRoleRecord> IRoleRepository.FetchAllBySelcoSpId(System.String selcoSpId)
        {
            return this.FetchAllBySelcoSpId(selcoSpId);
        }

        #endregion
    }
}
