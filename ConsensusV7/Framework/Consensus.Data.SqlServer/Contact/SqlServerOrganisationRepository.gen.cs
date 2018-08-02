using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Linq;

namespace Consensus.Contact
{
    /// <summary>
    ///     Provides the persistence and retrieval of the <see cref="OrganisationRecord" /> instances in a Microsoft SQL Server database.
    /// </summary>
    /// <remarks>
    ///     THIS CODE HAS BEEN AUTOMATICALLY GENERATED USING THE CONSENSUS DEVELOPER TOOLS.
    ///     DO NOT EDIT THIS CODE AS ANY CUSTOM MODIFICATIONS WILL BE LOST UPON REGENERATION.
    /// </remarks>
    public partial class SqlServerOrganisationRepository : SqlServerRepository<OrganisationRecord, String>, IOrganisationRepository
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
            get { return "Organisation"; }
        }

        /// <summary>
        ///     Gets the name of the parameter which is used to specify the unique value that identifies each instance of a <see cref="OrganisationRecord" />.
        /// </summary>
        protected override String TypeKeyName
        {
            get { return "@PA_ORG_ID"; }
        }

        /// <summary>
        ///     Gets the underlying table name that this repository sit over.
        /// </summary>
        public override String TableName
        {
            get { return "Organisation"; }
        }

        #endregion

        #region methods

        /// <summary>
        ///     Maps an <see cref="IDataRecord" /> to the specified <see cref="OrganisationRecord" />.
        /// </summary>
        /// <param name="dataRecord">
        ///     The <see cref="IDataRecord" /> to be mapped.
        /// </param>
        /// <param name="record">
        ///     The <see cref="OrganisationRecord" /> instance to be mapped to.
        /// </param>
        protected override void MapRecord(IDataRecord dataRecord, OrganisationRecord record)
        {
            record.Id = dataRecord["ORG_ID"].ConvertTo<String>();
            record.Lock = dataRecord["ORG_LOCK"].ConvertTo<String>();
            record.AddDate = dataRecord["ORG_ADD_DATE"].ConvertTo<DateTime?>();
            record.AddBy = dataRecord["ORG_ADD_BY"].ConvertTo<String>();
            record.ModDate = dataRecord["ORG_MOD_DATE"].ConvertTo<DateTime?>();
            record.ModBy = dataRecord["ORG_MOD_BY"].ConvertTo<String>();
            record.RcvDate = dataRecord["ORG_RCV_DATE"].ConvertTo<DateTime?>();
            record.RcvFrom = dataRecord["ORG_RCV_FROM"].ConvertTo<String>();
            record.Name = dataRecord["ORG_NAME"].ConvertTo<String>();
            record.Shortname = dataRecord["ORG_SHORTNAME"].ConvertTo<String>();
            record.Hierarchy = dataRecord["ORG_HIERARCHY"].ConvertTo<String>();
            record.Phone = dataRecord["ORG_PHONE"].ConvertTo<String>();
            record.Fax = dataRecord["ORG_FAX"].ConvertTo<String>();
            record.Type = dataRecord["ORG_TYPE"].ConvertTo<String>();
            record.HierarchyLevl = dataRecord["ORG_HIERARCHY_LEVL"].ConvertTo<Byte?>();
            record.HierarchyLast = dataRecord["ORG_HIERARCHY_LAST"].ConvertTo<Double?>();
            record.NoEmployee = dataRecord["ORG_NO_EMPLOYEE"].ConvertTo<Double?>();
            record.NoTucmember = dataRecord["ORG_NO_TUCMEMBER"].ConvertTo<Double?>();
            record.TucPercent = dataRecord["ORG_TUC_PERCENT"].ConvertTo<Double?>();
            record.DailyHrs = dataRecord["ORG_DAILY_HRS"].ConvertTo<Double?>();
            record.BlockrateNo = dataRecord["ORG_BLOCKRATE_NO"].ConvertTo<Double?>();
            record.TucRegion = dataRecord["ORG_TUC_REGION"].ConvertTo<String>();
            record.MajorUnion = dataRecord["ORG_MAJOR_UNION"].ConvertTo<Byte?>();
            record.StudentAuth = dataRecord["ORG_STUDENT_AUTH"].ConvertTo<Byte?>();
            record.UnionReport = dataRecord["ORG_UNION_REPORT"].ConvertTo<Byte?>();
            record.BlockrateFlag = dataRecord["ORG_BLOCKRATE_FLAG"].ConvertTo<Byte?>();
            record.Donotmail = dataRecord["ORG_DONOTMAIL"].ConvertTo<Byte?>();
            record.Distributor = dataRecord["ORG_DISTRIBUTOR"].ConvertTo<Byte?>();
            record.Userchar5 = dataRecord["ORG_USERCHAR_5"].ConvertTo<String>();
            record.Industry = dataRecord["ORG_INDUSTRY"].ConvertTo<String>();
            record.Area = dataRecord["ORG_AREA"].ConvertTo<String>();
            record.Notes = dataRecord["ORG_NOTES"].ConvertTo<String>();
            record.SpecialDeal = dataRecord["ORG_SPECIAL_DEAL"].ConvertTo<String>();
            record.Orgchart = dataRecord["ORG_ORGCHART"].ConvertTo<String>();
            record.Source = dataRecord["ORG_SOURCE"].ConvertTo<String>();
            record.VatRef = dataRecord["ORG_VAT_REF"].ConvertTo<String>();
            record.Discount = dataRecord["ORG_DISCOUNT"].ConvertTo<String>();
            record.SoundexKey = dataRecord["ORG_SOUNDEX_KEY"].ConvertTo<String>();
            record.NormStart = dataRecord["ORG_NORM_START"].ConvertTo<DateTime?>();
            record.NormFinish = dataRecord["ORG_NORM_FINISH"].ConvertTo<DateTime?>();
            record.SalesRevenue = dataRecord["ORG_SALES_REVENUE"].ConvertTo<Int32?>();
            record.Turnover = dataRecord["ORG_TURNOVER"].ConvertTo<Decimal?>();
            record.SalesPot = dataRecord["ORG_SALES_POT"].ConvertTo<Int32?>();
            record.Employees = dataRecord["ORG_EMPLOYEES"].ConvertTo<Int32?>();
            record.Attractive = dataRecord["ORG_ATTRACTIVE"].ConvertTo<String>();
            record.Potential = dataRecord["ORG_POTENTIAL"].ConvertTo<String>();
            record.SalesRevBc = dataRecord["ORG_SALES_REV_BC"].ConvertTo<Double?>();
            record.TurnoverBc = dataRecord["ORG_TURNOVER_BC"].ConvertTo<Int32?>();
            record.SalesPotBc = dataRecord["ORG_SALES_POT_BC"].ConvertTo<Int32?>();
            record.CurrencyType = dataRecord["ORG_CURRENCY_TYPE"].ConvertTo<String>();
            record.CustomerAcc = dataRecord["ORG_CUSTOMER_ACC"].ConvertTo<String>();
            record.GroupAcc = dataRecord["ORG_GROUP_ACC"].ConvertTo<String>();
            record.DepositAcc = dataRecord["ORG_DEPOSIT_ACC"].ConvertTo<String>();
            record.ExecCode = dataRecord["ORG_EXEC_CODE"].ConvertTo<String>();
            record.Userchar1 = dataRecord["ORG_USERCHAR_1"].ConvertTo<String>();
            record.Userchar2 = dataRecord["ORG_USERCHAR_2"].ConvertTo<String>();
            record.Userchar3 = dataRecord["ORG_USERCHAR_3"].ConvertTo<String>();
            record.Userchar4 = dataRecord["ORG_USERCHAR_4"].ConvertTo<String>();
            record.Usernum1 = dataRecord["ORG_USERNUM_1"].ConvertTo<Decimal?>();
            record.Usernum2 = dataRecord["ORG_USERNUM_2"].ConvertTo<Decimal?>();
            record.Usernum3 = dataRecord["ORG_USERNUM_3"].ConvertTo<Decimal?>();
            record.Usernum4 = dataRecord["ORG_USERNUM_4"].ConvertTo<Decimal?>();
            record.Accmgr1Id = dataRecord["ORG_ACCMGR1_ID"].ConvertTo<String>();
            record.Accmgr2Id = dataRecord["ORG_ACCMGR2_ID"].ConvertTo<String>();
            record.StrategicAcc = dataRecord["ORG_STRATEGIC_ACC"].ConvertTo<Byte?>();
            record.PicId = dataRecord["ORG_PIC_ID"].ConvertTo<String>();
            record.Parent = dataRecord["ORG_PARENT"].ConvertTo<String>();
            record.ListId = dataRecord["ORG_LIST_ID"].ConvertTo<String>();
            record.SpecialTerms = dataRecord["ORG_SPECIAL_TERMS"].ConvertTo<String>();
            record.Aka = dataRecord["ORG_AKA"].ConvertTo<String>();
            record.Hold1 = dataRecord["ORG_HOLD1"].ConvertTo<Byte?>();
            record.Hold2 = dataRecord["ORG_HOLD2"].ConvertTo<Byte?>();
            record.Url = dataRecord["ORG_URL"].ConvertTo<String>();
            record.Userchar6 = dataRecord["ORG_USERCHAR_6"].ConvertTo<String>();
            record.Userchar7 = dataRecord["ORG_USERCHAR_7"].ConvertTo<String>();
            record.Userchar8 = dataRecord["ORG_USERCHAR_8"].ConvertTo<String>();
            record.Userchar9 = dataRecord["ORG_USERCHAR_9"].ConvertTo<String>();
            record.Userchar10 = dataRecord["ORG_USERCHAR_10"].ConvertTo<String>();
            record.Comments = dataRecord["ORG_COMMENTS"].ConvertTo<String>();
            record.Rank = dataRecord["ORG_RANK"].ConvertTo<String>();
            record.MatchKey = dataRecord["ORG_MATCH_KEY"].ConvertTo<String>();
            record.Terr1Id = dataRecord["ORG_TERR1_ID"].ConvertTo<String>();
            record.Terr2Id = dataRecord["ORG_TERR2_ID"].ConvertTo<String>();
            record.Terr3Id = dataRecord["ORG_TERR3_ID"].ConvertTo<String>();
            record.BatId = dataRecord["ORG_BAT_ID"].ConvertTo<String>();
            record.Userdate1 = dataRecord["ORG_USERDATE_1"].ConvertTo<DateTime?>();
            record.Userdate2 = dataRecord["ORG_USERDATE_2"].ConvertTo<DateTime?>();
            record.Currency = dataRecord["ORG_CURRENCY"].ConvertTo<String>();
            record.PaymentDays = dataRecord["ORG_PAYMENT_DAYS"].ConvertTo<Int32?>();
            record.PaymentType = dataRecord["ORG_PAYMENT_TYPE"].ConvertTo<Byte?>();
            record.PayTerms1 = dataRecord["ORG_PAY_TERMS_1"].ConvertTo<String>();
            record.PayTerms2 = dataRecord["ORG_PAY_TERMS_2"].ConvertTo<String>();
            record.PayTerms3 = dataRecord["ORG_PAY_TERMS_3"].ConvertTo<String>();
            record.PayTerms4 = dataRecord["ORG_PAY_TERMS_4"].ConvertTo<String>();
            record.CreditCurr = dataRecord["ORG_CREDIT_CURR"].ConvertTo<String>();
            record.Credit = dataRecord["ORG_CREDIT"].ConvertTo<Double?>();
            record.CreditBc = dataRecord["ORG_CREDIT_BC"].ConvertTo<Double?>();
            record.CreditBc2 = dataRecord["ORG_CREDIT_BC2"].ConvertTo<Double?>();
            record.ExistClient = dataRecord["ORG_EXIST_CLIENT"].ConvertTo<Byte?>();
            record.Sic1 = dataRecord["ORG_SIC1"].ConvertTo<String>();
            record.Sic2 = dataRecord["ORG_SIC2"].ConvertTo<String>();
            record.Sic3 = dataRecord["ORG_SIC3"].ConvertTo<String>();
            record.Sic4 = dataRecord["ORG_SIC4"].ConvertTo<String>();
            record.Duns = dataRecord["ORG_DUNS"].ConvertTo<String>();
            record.StdCode = dataRecord["ORG_STD_CODE"].ConvertTo<String>();
            record.Security = dataRecord["ORG_SECURITY"].ConvertTo<String>();
            record.Flag1 = dataRecord["ORG_FLAG_1"].ConvertTo<Byte?>();
            record.AccStatus = dataRecord["ORG_ACC_STATUS"].ConvertTo<String>();
            record.AltName1 = dataRecord["ORG_ALT_NAME_1"].ConvertTo<String>();
            record.AltName2 = dataRecord["ORG_ALT_NAME_2"].ConvertTo<String>();
            record.BktId = dataRecord["ORG_BKT_ID"].ConvertTo<String>();
            record.PlId = dataRecord["ORG_PL_ID"].ConvertTo<String>();
            record.VatCode = dataRecord["ORG_VAT_CODE"].ConvertTo<String>();
            record.Userchar11 = dataRecord["ORG_USERCHAR_11"].ConvertTo<String>();
            record.Email = dataRecord["ORG_EMAIL"].ConvertTo<String>();
            record.SourcePmId = dataRecord["ORG_SOURCE_PM_ID"].ConvertTo<String>();
            record.Userchar12 = dataRecord["ORG_USERCHAR_12"].ConvertTo<String>();
            record.Userchar13 = dataRecord["ORG_USERCHAR_13"].ConvertTo<String>();
            record.Userchar14 = dataRecord["ORG_USERCHAR_14"].ConvertTo<String>();
            record.Userchar15 = dataRecord["ORG_USERCHAR_15"].ConvertTo<String>();
            record.Userdate3 = dataRecord["ORG_USERDATE_3"].ConvertTo<DateTime?>();
            record.Userdate4 = dataRecord["ORG_USERDATE_4"].ConvertTo<DateTime?>();
            record.Userdate5 = dataRecord["ORG_USERDATE_5"].ConvertTo<DateTime?>();
            record.Usernum5 = dataRecord["ORG_USERNUM_5"].ConvertTo<Decimal?>();
            record.Usernum6 = dataRecord["ORG_USERNUM_6"].ConvertTo<Decimal?>();
            record.Usernum7 = dataRecord["ORG_USERNUM_7"].ConvertTo<Single?>();
            record.Usernum8 = dataRecord["ORG_USERNUM_8"].ConvertTo<Single?>();
            record.Userint1 = dataRecord["ORG_USERINT_1"].ConvertTo<Int32?>();
            record.Userint2 = dataRecord["ORG_USERINT_2"].ConvertTo<Int32?>();
            record.Userint3 = dataRecord["ORG_USERINT_3"].ConvertTo<Int32?>();
            record.Userint4 = dataRecord["ORG_USERINT_4"].ConvertTo<Int32?>();
            record.Userint5 = dataRecord["ORG_USERINT_5"].ConvertTo<Int32?>();
            record.MemCTot = dataRecord["ORG_MEM_C_TOT"].ConvertTo<Double?>();
            record.MemRTot = dataRecord["ORG_MEM_R_TOT"].ConvertTo<Double?>();
            record.MemLTot = dataRecord["ORG_MEM_L_TOT"].ConvertTo<Double?>();
            record.Donotfax = dataRecord["ORG_DONOTFAX"].ConvertTo<Byte?>();
            record.Vatcd = dataRecord["ORG_VATCD"].ConvertTo<String>();
            record.CustStatus = dataRecord["ORG_CUST_STATUS"].ConvertTo<String>();
            record.Disabled = dataRecord["ORG_DISABLED"].ConvertTo<Byte?>();
            record.Userint6 = dataRecord["ORG_USERINT_6"].ConvertTo<Byte?>();
            record.Userdate6 = dataRecord["ORG_USERDATE_6"].ConvertTo<DateTime?>();
            record.OurOrg = dataRecord["ORG_OUR_ORG"].ConvertTo<Byte?>();
            record.ExtKey = dataRecord["ORG_EXT_KEY"].ConvertTo<String>();
            record.AttribChar01 = dataRecord["ORG_ATTRIB_CHAR_01"].ConvertTo<String>();
            record.AttribChar02 = dataRecord["ORG_ATTRIB_CHAR_02"].ConvertTo<String>();
            record.AttribChar03 = dataRecord["ORG_ATTRIB_CHAR_03"].ConvertTo<String>();
            record.AttribChar04 = dataRecord["ORG_ATTRIB_CHAR_04"].ConvertTo<String>();
            record.AttribChar05 = dataRecord["ORG_ATTRIB_CHAR_05"].ConvertTo<String>();
            record.AttribDate01 = dataRecord["ORG_ATTRIB_DATE_01"].ConvertTo<DateTime?>();
            record.TypeSub = dataRecord["ORG_TYPE_SUB"].ConvertTo<String>();
            record.PhoneStd = dataRecord["ORG_PHONE_STD"].ConvertTo<String>();
            record.FaxStd = dataRecord["ORG_FAX_STD"].ConvertTo<String>();
            record.ImmDuns = dataRecord["ORG_IMM_DUNS"].ConvertTo<String>();
            record.ImmName = dataRecord["ORG_IMM_NAME"].ConvertTo<String>();
            record.HqDuns = dataRecord["ORG_HQ_DUNS"].ConvertTo<String>();
            record.HqName = dataRecord["ORG_HQ_NAME"].ConvertTo<String>();
            record.UltukDuns = dataRecord["ORG_ULTUK_DUNS"].ConvertTo<String>();
            record.UltukName = dataRecord["ORG_ULTUK_NAME"].ConvertTo<String>();
            record.UltDuns = dataRecord["ORG_ULT_DUNS"].ConvertTo<String>();
            record.UltName = dataRecord["ORG_ULT_NAME"].ConvertTo<String>();
            record.MemATot = dataRecord["ORG_MEM_A_TOT"].ConvertTo<Double?>();
            record.SelcoSpId = dataRecord["ORG_SELCO_SP_ID"].ConvertTo<String>();
            record.Area2 = dataRecord["ORG_AREA2"].ConvertTo<String>();
            record.Region2 = dataRecord["ORG_REGION2"].ConvertTo<String>();
            record.SectypeId = dataRecord["ORG_SECTYPE_ID"].ConvertTo<Int32?>();
            record.OrgSubRegion = dataRecord["org_sub_region"].ConvertTo<String>();
            record.Status = dataRecord["ORG_STATUS"].ConvertTo<String>();
            record.OsId = dataRecord["ORG_OS_ID"].ConvertTo<Int32?>();
            record.Confirmation = dataRecord["ORG_CONFIRMATION"].ConvertTo<Byte?>();
            record.Ji = dataRecord["ORG_JI"].ConvertTo<Byte?>();
            record.UniqueRef = dataRecord["ORG_UNIQUE_REF"].ConvertTo<String>();
            record.Ref = dataRecord["ORG_REF"].ConvertTo<String>();
            record.RefPassword = dataRecord["ORG_REF_PASSWORD"].ConvertTo<String>();
            record.ValidDomainSuffix = dataRecord["ORG_VALID_DOMAIN_SUFFIX"].ConvertTo<String>();
            record.SuppBktId = dataRecord["ORG_SUPP_BKT_ID"].ConvertTo<String>();
            record.DoNotSpare1 = dataRecord["ORG_DO_NOT_SPARE1"].ConvertTo<Byte?>();
            record.DoNotSpare2 = dataRecord["ORG_DO_NOT_SPARE2"].ConvertTo<Byte?>();
            record.DoNotSpare3 = dataRecord["ORG_DO_NOT_SPARE3"].ConvertTo<Byte?>();
            record.DoNotSpare4 = dataRecord["ORG_DO_NOT_SPARE4"].ConvertTo<Byte?>();
            record.VatRegNum = dataRecord["ORG_VAT_REG_NUM"].ConvertTo<String>();
            record.ReportPassword = dataRecord["ORG_REPORT_PASSWORD"].ConvertTo<String>();
            record.ReportPath = dataRecord["ORG_REPORT_PATH"].ConvertTo<String>();
            record.ReportUsername = dataRecord["ORG_REPORT_USERNAME"].ConvertTo<String>();
            record.InvAuthPassword = dataRecord["ORG_INV_AUTH_PASSWORD"].ConvertTo<String>();
            record.WebEnabled = dataRecord["ORG_WEB_ENABLED"].ConvertTo<Byte>();
            record.PersonCount = dataRecord["ORG_PERSON_COUNT"].ConvertTo<Int32>();
            record.Spend = dataRecord["ORG_SPEND"].ConvertTo<Decimal?>();
            record.OnHold = dataRecord["ORG_ON_HOLD"].ConvertTo<Byte>();
            record.PshId = dataRecord["ORG_PSH_ID"].ConvertTo<Int32?>();
            record.PortalConfirmation = dataRecord["ORG_PORTAL_CONFIRMATION"].ConvertTo<String>();
        }

        /// <summary>
        ///     Sets the parameter values for the specified <paramref name="command" /> based on the specified <typeparamref name="TRecord" /> instance.
        /// </summary>
        /// <param name="command">
        ///     The <see cref="IDbCommand" /> containing the parameters to be mapped.
        /// </param>
        /// <param name="record">
        ///     The <see cref="OrganisationRecord" /> instance to be mapped.
        /// </param>
        /// <param name="useV6Logic">
        ///     Is the procedure being run an old version 6.x procedure? (the null value handling logic is different).
        /// </param>
        protected override void MapParametersIn(IDbCommand command, OrganisationRecord record, bool useV6Logic)
        {
            this.MapParameterIn(command, "@PA_ORG_ID", record.Id);
            this.MapParameterIn(command, "@PA_ORG_LOCK", record.Lock);
            this.MapParameterIn(command, "@PA_ORG_NAME", record.Name);
            this.MapParameterIn(command, "@PA_ORG_SHORTNAME", record.Shortname);
            this.MapParameterIn(command, "@PA_ORG_HIERARCHY", record.Hierarchy);
            this.MapParameterIn(command, "@PA_ORG_PHONE", record.Phone);
            this.MapParameterIn(command, "@PA_ORG_FAX", record.Fax);
            this.MapParameterIn(command, "@PA_ORG_TYPE", record.Type);
            this.MapParameterIn(command, "@PA_ORG_HIERARCHY_LEVL", record.HierarchyLevl);
            this.MapParameterIn(command, "@PA_ORG_HIERARCHY_LAST", record.HierarchyLast == Double.MinValue ? ( useV6Logic ? new Double?(0) : null ) : record.HierarchyLast);
            this.MapParameterIn(command, "@PA_ORG_NO_EMPLOYEE", record.NoEmployee == Double.MinValue ? ( useV6Logic ? new Double?(0) : null ) : record.NoEmployee);
            this.MapParameterIn(command, "@PA_ORG_NO_TUCMEMBER", record.NoTucmember == Double.MinValue ? ( useV6Logic ? new Double?(0) : null ) : record.NoTucmember);
            this.MapParameterIn(command, "@PA_ORG_TUC_PERCENT", record.TucPercent == Double.MinValue ? ( useV6Logic ? new Double?(0) : null ) : record.TucPercent);
            this.MapParameterIn(command, "@PA_ORG_DAILY_HRS", record.DailyHrs == Double.MinValue ? ( useV6Logic ? new Double?(0) : null ) : record.DailyHrs);
            this.MapParameterIn(command, "@PA_ORG_BLOCKRATE_NO", record.BlockrateNo == Double.MinValue ? ( useV6Logic ? new Double?(0) : null ) : record.BlockrateNo);
            this.MapParameterIn(command, "@PA_ORG_TUC_REGION", record.TucRegion);
            this.MapParameterIn(command, "@PA_ORG_MAJOR_UNION", record.MajorUnion);
            this.MapParameterIn(command, "@PA_ORG_STUDENT_AUTH", record.StudentAuth);
            this.MapParameterIn(command, "@PA_ORG_UNION_REPORT", record.UnionReport);
            this.MapParameterIn(command, "@PA_ORG_BLOCKRATE_FLAG", record.BlockrateFlag);
            this.MapParameterIn(command, "@PA_ORG_DONOTMAIL", record.Donotmail);
            this.MapParameterIn(command, "@PA_ORG_DISTRIBUTOR", record.Distributor);
            this.MapParameterIn(command, "@PA_ORG_USERCHAR_5", record.Userchar5);
            this.MapParameterIn(command, "@PA_ORG_INDUSTRY", record.Industry);
            this.MapParameterIn(command, "@PA_ORG_AREA", record.Area);
            this.MapParameterIn(command, "@PA_ORG_NOTES", record.Notes);
            this.MapParameterIn(command, "@PA_ORG_SPECIAL_DEAL", record.SpecialDeal);
            this.MapParameterIn(command, "@PA_ORG_ORGCHART", record.Orgchart);
            this.MapParameterIn(command, "@PA_ORG_SOURCE", record.Source);
            this.MapParameterIn(command, "@PA_ORG_VAT_REF", record.VatRef);
            this.MapParameterIn(command, "@PA_ORG_DISCOUNT", record.Discount);
            this.MapParameterIn(command, "@PA_ORG_SOUNDEX_KEY", record.SoundexKey);
            this.MapParameterIn(command, "@PA_ORG_NORM_START", record.NormStart == DateTime.MinValue ? ( useV6Logic ? new DateTime?(new DateTime(1900,1,1)) : null ) : record.NormStart);
            this.MapParameterIn(command, "@PA_ORG_NORM_FINISH", record.NormFinish == DateTime.MinValue ? ( useV6Logic ? new DateTime?(new DateTime(1900,1,1)) : null ) : record.NormFinish);
            this.MapParameterIn(command, "@PA_ORG_SALES_REVENUE", record.SalesRevenue == Int32.MinValue ? ( useV6Logic ? new Int32?(0) : null ) : record.SalesRevenue);
            this.MapParameterIn(command, "@PA_ORG_TURNOVER", record.Turnover == Decimal.MinValue ? ( useV6Logic ? new Decimal?(0M) : null ) : record.Turnover);
            this.MapParameterIn(command, "@PA_ORG_SALES_POT", record.SalesPot == Int32.MinValue ? ( useV6Logic ? new Int32?(0) : null ) : record.SalesPot);
            this.MapParameterIn(command, "@PA_ORG_EMPLOYEES", record.Employees == Int32.MinValue ? ( useV6Logic ? new Int32?(0) : null ) : record.Employees);
            this.MapParameterIn(command, "@PA_ORG_ATTRACTIVE", record.Attractive);
            this.MapParameterIn(command, "@PA_ORG_POTENTIAL", record.Potential);
            this.MapParameterIn(command, "@PA_ORG_SALES_REV_BC", record.SalesRevBc == Double.MinValue ? ( useV6Logic ? new Double?(0) : null ) : record.SalesRevBc);
            this.MapParameterIn(command, "@PA_ORG_TURNOVER_BC", record.TurnoverBc == Int32.MinValue ? ( useV6Logic ? new Int32?(0) : null ) : record.TurnoverBc);
            this.MapParameterIn(command, "@PA_ORG_SALES_POT_BC", record.SalesPotBc == Int32.MinValue ? ( useV6Logic ? new Int32?(0) : null ) : record.SalesPotBc);
            this.MapParameterIn(command, "@PA_ORG_CURRENCY_TYPE", record.CurrencyType);
            this.MapParameterIn(command, "@PA_ORG_CUSTOMER_ACC", record.CustomerAcc);
            this.MapParameterIn(command, "@PA_ORG_GROUP_ACC", record.GroupAcc);
            this.MapParameterIn(command, "@PA_ORG_DEPOSIT_ACC", record.DepositAcc);
            this.MapParameterIn(command, "@PA_ORG_EXEC_CODE", record.ExecCode);
            this.MapParameterIn(command, "@PA_ORG_USERCHAR_1", record.Userchar1);
            this.MapParameterIn(command, "@PA_ORG_USERCHAR_2", record.Userchar2);
            this.MapParameterIn(command, "@PA_ORG_USERCHAR_3", record.Userchar3);
            this.MapParameterIn(command, "@PA_ORG_USERCHAR_4", record.Userchar4);
            this.MapParameterIn(command, "@PA_ORG_USERNUM_1", record.Usernum1 == Decimal.MinValue ? ( useV6Logic ? new Decimal?(0M) : null ) : record.Usernum1);
            this.MapParameterIn(command, "@PA_ORG_USERNUM_2", record.Usernum2 == Decimal.MinValue ? ( useV6Logic ? new Decimal?(0M) : null ) : record.Usernum2);
            this.MapParameterIn(command, "@PA_ORG_USERNUM_3", record.Usernum3 == Decimal.MinValue ? ( useV6Logic ? new Decimal?(0M) : null ) : record.Usernum3);
            this.MapParameterIn(command, "@PA_ORG_USERNUM_4", record.Usernum4 == Decimal.MinValue ? ( useV6Logic ? new Decimal?(0M) : null ) : record.Usernum4);
            this.MapParameterIn(command, "@PA_ORG_ACCMGR1_ID", record.Accmgr1Id);
            this.MapParameterIn(command, "@PA_ORG_ACCMGR2_ID", record.Accmgr2Id);
            this.MapParameterIn(command, "@PA_ORG_STRATEGIC_ACC", record.StrategicAcc);
            this.MapParameterIn(command, "@PA_ORG_PIC_ID", record.PicId);
            this.MapParameterIn(command, "@PA_ORG_PARENT", record.Parent);
            this.MapParameterIn(command, "@PA_ORG_LIST_ID", record.ListId);
            this.MapParameterIn(command, "@PA_ORG_SPECIAL_TERMS", record.SpecialTerms);
            this.MapParameterIn(command, "@PA_ORG_AKA", record.Aka);
            this.MapParameterIn(command, "@PA_ORG_HOLD1", record.Hold1);
            this.MapParameterIn(command, "@PA_ORG_HOLD2", record.Hold2);
            this.MapParameterIn(command, "@PA_ORG_URL", record.Url);
            this.MapParameterIn(command, "@PA_ORG_USERCHAR_6", record.Userchar6);
            this.MapParameterIn(command, "@PA_ORG_USERCHAR_7", record.Userchar7);
            this.MapParameterIn(command, "@PA_ORG_USERCHAR_8", record.Userchar8);
            this.MapParameterIn(command, "@PA_ORG_USERCHAR_9", record.Userchar9);
            this.MapParameterIn(command, "@PA_ORG_USERCHAR_10", record.Userchar10);
            this.MapParameterIn(command, "@PA_ORG_COMMENTS", record.Comments);
            this.MapParameterIn(command, "@PA_ORG_RANK", record.Rank);
            this.MapParameterIn(command, "@PA_ORG_MATCH_KEY", record.MatchKey);
            this.MapParameterIn(command, "@PA_ORG_TERR1_ID", record.Terr1Id);
            this.MapParameterIn(command, "@PA_ORG_TERR2_ID", record.Terr2Id);
            this.MapParameterIn(command, "@PA_ORG_TERR3_ID", record.Terr3Id);
            this.MapParameterIn(command, "@PA_ORG_BAT_ID", record.BatId);
            this.MapParameterIn(command, "@PA_ORG_USERDATE_1", record.Userdate1 == DateTime.MinValue ? ( useV6Logic ? new DateTime?(new DateTime(1900,1,1)) : null ) : record.Userdate1);
            this.MapParameterIn(command, "@PA_ORG_USERDATE_2", record.Userdate2 == DateTime.MinValue ? ( useV6Logic ? new DateTime?(new DateTime(1900,1,1)) : null ) : record.Userdate2);
            this.MapParameterIn(command, "@PA_ORG_CURRENCY", record.Currency);
            this.MapParameterIn(command, "@PA_ORG_PAYMENT_DAYS", record.PaymentDays == Int32.MinValue ? ( useV6Logic ? new Int32?(0) : null ) : record.PaymentDays);
            this.MapParameterIn(command, "@PA_ORG_PAYMENT_TYPE", record.PaymentType);
            this.MapParameterIn(command, "@PA_ORG_PAY_TERMS_1", record.PayTerms1);
            this.MapParameterIn(command, "@PA_ORG_PAY_TERMS_2", record.PayTerms2);
            this.MapParameterIn(command, "@PA_ORG_PAY_TERMS_3", record.PayTerms3);
            this.MapParameterIn(command, "@PA_ORG_PAY_TERMS_4", record.PayTerms4);
            this.MapParameterIn(command, "@PA_ORG_CREDIT_CURR", record.CreditCurr);
            this.MapParameterIn(command, "@PA_ORG_CREDIT", record.Credit == Double.MinValue ? ( useV6Logic ? new Double?(0) : null ) : record.Credit);
            this.MapParameterIn(command, "@PA_ORG_CREDIT_BC", record.CreditBc == Double.MinValue ? ( useV6Logic ? new Double?(0) : null ) : record.CreditBc);
            this.MapParameterIn(command, "@PA_ORG_CREDIT_BC2", record.CreditBc2 == Double.MinValue ? ( useV6Logic ? new Double?(0) : null ) : record.CreditBc2);
            this.MapParameterIn(command, "@PA_ORG_EXIST_CLIENT", record.ExistClient);
            this.MapParameterIn(command, "@PA_ORG_SIC1", record.Sic1);
            this.MapParameterIn(command, "@PA_ORG_SIC2", record.Sic2);
            this.MapParameterIn(command, "@PA_ORG_SIC3", record.Sic3);
            this.MapParameterIn(command, "@PA_ORG_SIC4", record.Sic4);
            this.MapParameterIn(command, "@PA_ORG_DUNS", record.Duns);
            this.MapParameterIn(command, "@PA_ORG_STD_CODE", record.StdCode);
            this.MapParameterIn(command, "@PA_ORG_SECURITY", record.Security);
            this.MapParameterIn(command, "@PA_ORG_FLAG_1", record.Flag1);
            this.MapParameterIn(command, "@PA_ORG_ACC_STATUS", record.AccStatus);
            this.MapParameterIn(command, "@PA_ORG_ALT_NAME_1", record.AltName1);
            this.MapParameterIn(command, "@PA_ORG_ALT_NAME_2", record.AltName2);
            this.MapParameterIn(command, "@PA_ORG_BKT_ID", record.BktId);
            this.MapParameterIn(command, "@PA_ORG_PL_ID", record.PlId);
            this.MapParameterIn(command, "@PA_ORG_VAT_CODE", record.VatCode);
            this.MapParameterIn(command, "@PA_ORG_USERCHAR_11", record.Userchar11);
            this.MapParameterIn(command, "@PA_ORG_EMAIL", record.Email);
            this.MapParameterIn(command, "@PA_ORG_SOURCE_PM_ID", record.SourcePmId);
            this.MapParameterIn(command, "@PA_ORG_USERCHAR_12", record.Userchar12);
            this.MapParameterIn(command, "@PA_ORG_USERCHAR_13", record.Userchar13);
            this.MapParameterIn(command, "@PA_ORG_USERCHAR_14", record.Userchar14);
            this.MapParameterIn(command, "@PA_ORG_USERCHAR_15", record.Userchar15);
            this.MapParameterIn(command, "@PA_ORG_USERDATE_3", record.Userdate3 == DateTime.MinValue ? ( useV6Logic ? new DateTime?(new DateTime(1900,1,1)) : null ) : record.Userdate3);
            this.MapParameterIn(command, "@PA_ORG_USERDATE_4", record.Userdate4 == DateTime.MinValue ? ( useV6Logic ? new DateTime?(new DateTime(1900,1,1)) : null ) : record.Userdate4);
            this.MapParameterIn(command, "@PA_ORG_USERDATE_5", record.Userdate5 == DateTime.MinValue ? ( useV6Logic ? new DateTime?(new DateTime(1900,1,1)) : null ) : record.Userdate5);
            this.MapParameterIn(command, "@PA_ORG_USERNUM_5", record.Usernum5 == Decimal.MinValue ? ( useV6Logic ? new Decimal?(0M) : null ) : record.Usernum5);
            this.MapParameterIn(command, "@PA_ORG_USERNUM_6", record.Usernum6 == Decimal.MinValue ? ( useV6Logic ? new Decimal?(0M) : null ) : record.Usernum6);
            this.MapParameterIn(command, "@PA_ORG_USERNUM_7", record.Usernum7 == Single.MinValue ? ( useV6Logic ? new Single?(0) : null ) : record.Usernum7);
            this.MapParameterIn(command, "@PA_ORG_USERNUM_8", record.Usernum8 == Single.MinValue ? ( useV6Logic ? new Single?(0) : null ) : record.Usernum8);
            this.MapParameterIn(command, "@PA_ORG_USERINT_1", record.Userint1 == Int32.MinValue ? ( useV6Logic ? new Int32?(0) : null ) : record.Userint1);
            this.MapParameterIn(command, "@PA_ORG_USERINT_2", record.Userint2 == Int32.MinValue ? ( useV6Logic ? new Int32?(0) : null ) : record.Userint2);
            this.MapParameterIn(command, "@PA_ORG_USERINT_3", record.Userint3 == Int32.MinValue ? ( useV6Logic ? new Int32?(0) : null ) : record.Userint3);
            this.MapParameterIn(command, "@PA_ORG_USERINT_4", record.Userint4 == Int32.MinValue ? ( useV6Logic ? new Int32?(0) : null ) : record.Userint4);
            this.MapParameterIn(command, "@PA_ORG_USERINT_5", record.Userint5 == Int32.MinValue ? ( useV6Logic ? new Int32?(0) : null ) : record.Userint5);
            this.MapParameterIn(command, "@PA_ORG_MEM_C_TOT", record.MemCTot == Double.MinValue ? ( useV6Logic ? new Double?(0) : null ) : record.MemCTot);
            this.MapParameterIn(command, "@PA_ORG_MEM_R_TOT", record.MemRTot == Double.MinValue ? ( useV6Logic ? new Double?(0) : null ) : record.MemRTot);
            this.MapParameterIn(command, "@PA_ORG_MEM_L_TOT", record.MemLTot == Double.MinValue ? ( useV6Logic ? new Double?(0) : null ) : record.MemLTot);
            this.MapParameterIn(command, "@PA_ORG_DONOTFAX", record.Donotfax);
            this.MapParameterIn(command, "@PA_ORG_VATCD", record.Vatcd);
            this.MapParameterIn(command, "@PA_ORG_CUST_STATUS", record.CustStatus);
            this.MapParameterIn(command, "@PA_ORG_DISABLED", record.Disabled);
            this.MapParameterIn(command, "@PA_ORG_USERINT_6", record.Userint6);
            this.MapParameterIn(command, "@PA_ORG_USERDATE_6", record.Userdate6 == DateTime.MinValue ? ( useV6Logic ? new DateTime?(new DateTime(1900,1,1)) : null ) : record.Userdate6);
            this.MapParameterIn(command, "@PA_ORG_OUR_ORG", record.OurOrg);
            this.MapParameterIn(command, "@PA_ORG_EXT_KEY", record.ExtKey);
            this.MapParameterIn(command, "@PA_ORG_ATTRIB_CHAR_01", record.AttribChar01);
            this.MapParameterIn(command, "@PA_ORG_ATTRIB_CHAR_02", record.AttribChar02);
            this.MapParameterIn(command, "@PA_ORG_ATTRIB_CHAR_03", record.AttribChar03);
            this.MapParameterIn(command, "@PA_ORG_ATTRIB_CHAR_04", record.AttribChar04);
            this.MapParameterIn(command, "@PA_ORG_ATTRIB_CHAR_05", record.AttribChar05);
            this.MapParameterIn(command, "@PA_ORG_ATTRIB_DATE_01", record.AttribDate01 == DateTime.MinValue ? ( useV6Logic ? new DateTime?(new DateTime(1900,1,1)) : null ) : record.AttribDate01);
            this.MapParameterIn(command, "@PA_ORG_TYPE_SUB", record.TypeSub);
            this.MapParameterIn(command, "@PA_ORG_PHONE_STD", record.PhoneStd);
            this.MapParameterIn(command, "@PA_ORG_FAX_STD", record.FaxStd);
            this.MapParameterIn(command, "@PA_ORG_IMM_DUNS", record.ImmDuns);
            this.MapParameterIn(command, "@PA_ORG_IMM_NAME", record.ImmName);
            this.MapParameterIn(command, "@PA_ORG_HQ_DUNS", record.HqDuns);
            this.MapParameterIn(command, "@PA_ORG_HQ_NAME", record.HqName);
            this.MapParameterIn(command, "@PA_ORG_ULTUK_DUNS", record.UltukDuns);
            this.MapParameterIn(command, "@PA_ORG_ULTUK_NAME", record.UltukName);
            this.MapParameterIn(command, "@PA_ORG_ULT_DUNS", record.UltDuns);
            this.MapParameterIn(command, "@PA_ORG_ULT_NAME", record.UltName);
            this.MapParameterIn(command, "@PA_ORG_MEM_A_TOT", record.MemATot == Double.MinValue ? ( useV6Logic ? new Double?(0) : null ) : record.MemATot);
            this.MapParameterIn(command, "@PA_ORG_SELCO_SP_ID", record.SelcoSpId);
            this.MapParameterIn(command, "@PA_ORG_AREA2", record.Area2);
            this.MapParameterIn(command, "@PA_ORG_REGION2", record.Region2);
            this.MapParameterIn(command, "@PA_ORG_SECTYPE_ID", record.SectypeId == Int32.MinValue ? ( useV6Logic ? new Int32?(0) : null ) : record.SectypeId);
            this.MapParameterIn(command, "@PA_org_sub_region", record.OrgSubRegion);
            this.MapParameterIn(command, "@PA_ORG_STATUS", record.Status);
            this.MapParameterIn(command, "@PA_ORG_OS_ID", record.OsId == Int32.MinValue ? ( useV6Logic ? new Int32?(0) : null ) : record.OsId);
            this.MapParameterIn(command, "@PA_ORG_CONFIRMATION", record.Confirmation);
            this.MapParameterIn(command, "@PA_ORG_JI", record.Ji);
            this.MapParameterIn(command, "@PA_ORG_UNIQUE_REF", record.UniqueRef);
            this.MapParameterIn(command, "@PA_ORG_REF", record.Ref);
            this.MapParameterIn(command, "@PA_ORG_REF_PASSWORD", record.RefPassword);
            this.MapParameterIn(command, "@PA_ORG_VALID_DOMAIN_SUFFIX", record.ValidDomainSuffix);
            this.MapParameterIn(command, "@PA_ORG_SUPP_BKT_ID", record.SuppBktId);
            this.MapParameterIn(command, "@PA_ORG_DO_NOT_SPARE1", record.DoNotSpare1);
            this.MapParameterIn(command, "@PA_ORG_DO_NOT_SPARE2", record.DoNotSpare2);
            this.MapParameterIn(command, "@PA_ORG_DO_NOT_SPARE3", record.DoNotSpare3);
            this.MapParameterIn(command, "@PA_ORG_DO_NOT_SPARE4", record.DoNotSpare4);
            this.MapParameterIn(command, "@PA_ORG_VAT_REG_NUM", record.VatRegNum);
            this.MapParameterIn(command, "@PA_ORG_REPORT_PASSWORD", record.ReportPassword);
            this.MapParameterIn(command, "@PA_ORG_REPORT_PATH", record.ReportPath);
            this.MapParameterIn(command, "@PA_ORG_REPORT_USERNAME", record.ReportUsername);
            this.MapParameterIn(command, "@PA_ORG_INV_AUTH_PASSWORD", record.InvAuthPassword);
            this.MapParameterIn(command, "@PA_ORG_WEB_ENABLED", record.WebEnabled);
            this.MapParameterIn(command, "@PA_ORG_PERSON_COUNT", record.PersonCount == Int32.MinValue ? 0 : record.PersonCount);
            this.MapParameterIn(command, "@PA_ORG_SPEND", record.Spend == Decimal.MinValue ? ( useV6Logic ? new Decimal?(0M) : null ) : record.Spend);
            this.MapParameterIn(command, "@PA_ORG_ON_HOLD", record.OnHold);
            this.MapParameterIn(command, "@PA_ORG_PSH_ID", record.PshId == Int32.MinValue ? ( useV6Logic ? new Int32?(0) : null ) : record.PshId);
            this.MapParameterIn(command, "@PA_ORG_PORTAL_CONFIRMATION", record.PortalConfirmation);
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
        ///     The <see cref="OrganisationRecord" /> instance to be updated.
        /// </param>
        protected override void MapParametersOut(IDbCommand command, OrganisationRecord record)
        {
            record.Id = this.MapParameterOut(command, "@PA_ORG_ID", record.Id);
            record.Lock = this.MapParameterOut(command, "@PA_ORG_LOCK", record.Lock);
            record.Name = this.MapParameterOut(command, "@PA_ORG_NAME", record.Name);
            record.Shortname = this.MapParameterOut(command, "@PA_ORG_SHORTNAME", record.Shortname);
            record.Hierarchy = this.MapParameterOut(command, "@PA_ORG_HIERARCHY", record.Hierarchy);
            record.Phone = this.MapParameterOut(command, "@PA_ORG_PHONE", record.Phone);
            record.Fax = this.MapParameterOut(command, "@PA_ORG_FAX", record.Fax);
            record.Type = this.MapParameterOut(command, "@PA_ORG_TYPE", record.Type);
            record.HierarchyLevl = this.MapParameterOut(command, "@PA_ORG_HIERARCHY_LEVL", record.HierarchyLevl);
            record.HierarchyLast = this.MapParameterOut(command, "@PA_ORG_HIERARCHY_LAST", record.HierarchyLast);
            record.NoEmployee = this.MapParameterOut(command, "@PA_ORG_NO_EMPLOYEE", record.NoEmployee);
            record.NoTucmember = this.MapParameterOut(command, "@PA_ORG_NO_TUCMEMBER", record.NoTucmember);
            record.TucPercent = this.MapParameterOut(command, "@PA_ORG_TUC_PERCENT", record.TucPercent);
            record.DailyHrs = this.MapParameterOut(command, "@PA_ORG_DAILY_HRS", record.DailyHrs);
            record.BlockrateNo = this.MapParameterOut(command, "@PA_ORG_BLOCKRATE_NO", record.BlockrateNo);
            record.TucRegion = this.MapParameterOut(command, "@PA_ORG_TUC_REGION", record.TucRegion);
            record.MajorUnion = this.MapParameterOut(command, "@PA_ORG_MAJOR_UNION", record.MajorUnion);
            record.StudentAuth = this.MapParameterOut(command, "@PA_ORG_STUDENT_AUTH", record.StudentAuth);
            record.UnionReport = this.MapParameterOut(command, "@PA_ORG_UNION_REPORT", record.UnionReport);
            record.BlockrateFlag = this.MapParameterOut(command, "@PA_ORG_BLOCKRATE_FLAG", record.BlockrateFlag);
            record.Donotmail = this.MapParameterOut(command, "@PA_ORG_DONOTMAIL", record.Donotmail);
            record.Distributor = this.MapParameterOut(command, "@PA_ORG_DISTRIBUTOR", record.Distributor);
            record.Userchar5 = this.MapParameterOut(command, "@PA_ORG_USERCHAR_5", record.Userchar5);
            record.Industry = this.MapParameterOut(command, "@PA_ORG_INDUSTRY", record.Industry);
            record.Area = this.MapParameterOut(command, "@PA_ORG_AREA", record.Area);
            record.Notes = this.MapParameterOut(command, "@PA_ORG_NOTES", record.Notes);
            record.SpecialDeal = this.MapParameterOut(command, "@PA_ORG_SPECIAL_DEAL", record.SpecialDeal);
            record.Orgchart = this.MapParameterOut(command, "@PA_ORG_ORGCHART", record.Orgchart);
            record.Source = this.MapParameterOut(command, "@PA_ORG_SOURCE", record.Source);
            record.VatRef = this.MapParameterOut(command, "@PA_ORG_VAT_REF", record.VatRef);
            record.Discount = this.MapParameterOut(command, "@PA_ORG_DISCOUNT", record.Discount);
            record.SoundexKey = this.MapParameterOut(command, "@PA_ORG_SOUNDEX_KEY", record.SoundexKey);
            record.NormStart = this.MapParameterOut(command, "@PA_ORG_NORM_START", record.NormStart);
            record.NormFinish = this.MapParameterOut(command, "@PA_ORG_NORM_FINISH", record.NormFinish);
            record.SalesRevenue = this.MapParameterOut(command, "@PA_ORG_SALES_REVENUE", record.SalesRevenue);
            record.Turnover = this.MapParameterOut(command, "@PA_ORG_TURNOVER", record.Turnover);
            record.SalesPot = this.MapParameterOut(command, "@PA_ORG_SALES_POT", record.SalesPot);
            record.Employees = this.MapParameterOut(command, "@PA_ORG_EMPLOYEES", record.Employees);
            record.Attractive = this.MapParameterOut(command, "@PA_ORG_ATTRACTIVE", record.Attractive);
            record.Potential = this.MapParameterOut(command, "@PA_ORG_POTENTIAL", record.Potential);
            record.SalesRevBc = this.MapParameterOut(command, "@PA_ORG_SALES_REV_BC", record.SalesRevBc);
            record.TurnoverBc = this.MapParameterOut(command, "@PA_ORG_TURNOVER_BC", record.TurnoverBc);
            record.SalesPotBc = this.MapParameterOut(command, "@PA_ORG_SALES_POT_BC", record.SalesPotBc);
            record.CurrencyType = this.MapParameterOut(command, "@PA_ORG_CURRENCY_TYPE", record.CurrencyType);
            record.CustomerAcc = this.MapParameterOut(command, "@PA_ORG_CUSTOMER_ACC", record.CustomerAcc);
            record.GroupAcc = this.MapParameterOut(command, "@PA_ORG_GROUP_ACC", record.GroupAcc);
            record.DepositAcc = this.MapParameterOut(command, "@PA_ORG_DEPOSIT_ACC", record.DepositAcc);
            record.ExecCode = this.MapParameterOut(command, "@PA_ORG_EXEC_CODE", record.ExecCode);
            record.Userchar1 = this.MapParameterOut(command, "@PA_ORG_USERCHAR_1", record.Userchar1);
            record.Userchar2 = this.MapParameterOut(command, "@PA_ORG_USERCHAR_2", record.Userchar2);
            record.Userchar3 = this.MapParameterOut(command, "@PA_ORG_USERCHAR_3", record.Userchar3);
            record.Userchar4 = this.MapParameterOut(command, "@PA_ORG_USERCHAR_4", record.Userchar4);
            record.Usernum1 = this.MapParameterOut(command, "@PA_ORG_USERNUM_1", record.Usernum1);
            record.Usernum2 = this.MapParameterOut(command, "@PA_ORG_USERNUM_2", record.Usernum2);
            record.Usernum3 = this.MapParameterOut(command, "@PA_ORG_USERNUM_3", record.Usernum3);
            record.Usernum4 = this.MapParameterOut(command, "@PA_ORG_USERNUM_4", record.Usernum4);
            record.Accmgr1Id = this.MapParameterOut(command, "@PA_ORG_ACCMGR1_ID", record.Accmgr1Id);
            record.Accmgr2Id = this.MapParameterOut(command, "@PA_ORG_ACCMGR2_ID", record.Accmgr2Id);
            record.StrategicAcc = this.MapParameterOut(command, "@PA_ORG_STRATEGIC_ACC", record.StrategicAcc);
            record.PicId = this.MapParameterOut(command, "@PA_ORG_PIC_ID", record.PicId);
            record.Parent = this.MapParameterOut(command, "@PA_ORG_PARENT", record.Parent);
            record.ListId = this.MapParameterOut(command, "@PA_ORG_LIST_ID", record.ListId);
            record.SpecialTerms = this.MapParameterOut(command, "@PA_ORG_SPECIAL_TERMS", record.SpecialTerms);
            record.Aka = this.MapParameterOut(command, "@PA_ORG_AKA", record.Aka);
            record.Hold1 = this.MapParameterOut(command, "@PA_ORG_HOLD1", record.Hold1);
            record.Hold2 = this.MapParameterOut(command, "@PA_ORG_HOLD2", record.Hold2);
            record.Url = this.MapParameterOut(command, "@PA_ORG_URL", record.Url);
            record.Userchar6 = this.MapParameterOut(command, "@PA_ORG_USERCHAR_6", record.Userchar6);
            record.Userchar7 = this.MapParameterOut(command, "@PA_ORG_USERCHAR_7", record.Userchar7);
            record.Userchar8 = this.MapParameterOut(command, "@PA_ORG_USERCHAR_8", record.Userchar8);
            record.Userchar9 = this.MapParameterOut(command, "@PA_ORG_USERCHAR_9", record.Userchar9);
            record.Userchar10 = this.MapParameterOut(command, "@PA_ORG_USERCHAR_10", record.Userchar10);
            record.Comments = this.MapParameterOut(command, "@PA_ORG_COMMENTS", record.Comments);
            record.Rank = this.MapParameterOut(command, "@PA_ORG_RANK", record.Rank);
            record.MatchKey = this.MapParameterOut(command, "@PA_ORG_MATCH_KEY", record.MatchKey);
            record.Terr1Id = this.MapParameterOut(command, "@PA_ORG_TERR1_ID", record.Terr1Id);
            record.Terr2Id = this.MapParameterOut(command, "@PA_ORG_TERR2_ID", record.Terr2Id);
            record.Terr3Id = this.MapParameterOut(command, "@PA_ORG_TERR3_ID", record.Terr3Id);
            record.BatId = this.MapParameterOut(command, "@PA_ORG_BAT_ID", record.BatId);
            record.Userdate1 = this.MapParameterOut(command, "@PA_ORG_USERDATE_1", record.Userdate1);
            record.Userdate2 = this.MapParameterOut(command, "@PA_ORG_USERDATE_2", record.Userdate2);
            record.Currency = this.MapParameterOut(command, "@PA_ORG_CURRENCY", record.Currency);
            record.PaymentDays = this.MapParameterOut(command, "@PA_ORG_PAYMENT_DAYS", record.PaymentDays);
            record.PaymentType = this.MapParameterOut(command, "@PA_ORG_PAYMENT_TYPE", record.PaymentType);
            record.PayTerms1 = this.MapParameterOut(command, "@PA_ORG_PAY_TERMS_1", record.PayTerms1);
            record.PayTerms2 = this.MapParameterOut(command, "@PA_ORG_PAY_TERMS_2", record.PayTerms2);
            record.PayTerms3 = this.MapParameterOut(command, "@PA_ORG_PAY_TERMS_3", record.PayTerms3);
            record.PayTerms4 = this.MapParameterOut(command, "@PA_ORG_PAY_TERMS_4", record.PayTerms4);
            record.CreditCurr = this.MapParameterOut(command, "@PA_ORG_CREDIT_CURR", record.CreditCurr);
            record.Credit = this.MapParameterOut(command, "@PA_ORG_CREDIT", record.Credit);
            record.CreditBc = this.MapParameterOut(command, "@PA_ORG_CREDIT_BC", record.CreditBc);
            record.CreditBc2 = this.MapParameterOut(command, "@PA_ORG_CREDIT_BC2", record.CreditBc2);
            record.ExistClient = this.MapParameterOut(command, "@PA_ORG_EXIST_CLIENT", record.ExistClient);
            record.Sic1 = this.MapParameterOut(command, "@PA_ORG_SIC1", record.Sic1);
            record.Sic2 = this.MapParameterOut(command, "@PA_ORG_SIC2", record.Sic2);
            record.Sic3 = this.MapParameterOut(command, "@PA_ORG_SIC3", record.Sic3);
            record.Sic4 = this.MapParameterOut(command, "@PA_ORG_SIC4", record.Sic4);
            record.Duns = this.MapParameterOut(command, "@PA_ORG_DUNS", record.Duns);
            record.StdCode = this.MapParameterOut(command, "@PA_ORG_STD_CODE", record.StdCode);
            record.Security = this.MapParameterOut(command, "@PA_ORG_SECURITY", record.Security);
            record.Flag1 = this.MapParameterOut(command, "@PA_ORG_FLAG_1", record.Flag1);
            record.AccStatus = this.MapParameterOut(command, "@PA_ORG_ACC_STATUS", record.AccStatus);
            record.AltName1 = this.MapParameterOut(command, "@PA_ORG_ALT_NAME_1", record.AltName1);
            record.AltName2 = this.MapParameterOut(command, "@PA_ORG_ALT_NAME_2", record.AltName2);
            record.BktId = this.MapParameterOut(command, "@PA_ORG_BKT_ID", record.BktId);
            record.PlId = this.MapParameterOut(command, "@PA_ORG_PL_ID", record.PlId);
            record.VatCode = this.MapParameterOut(command, "@PA_ORG_VAT_CODE", record.VatCode);
            record.Userchar11 = this.MapParameterOut(command, "@PA_ORG_USERCHAR_11", record.Userchar11);
            record.Email = this.MapParameterOut(command, "@PA_ORG_EMAIL", record.Email);
            record.SourcePmId = this.MapParameterOut(command, "@PA_ORG_SOURCE_PM_ID", record.SourcePmId);
            record.Userchar12 = this.MapParameterOut(command, "@PA_ORG_USERCHAR_12", record.Userchar12);
            record.Userchar13 = this.MapParameterOut(command, "@PA_ORG_USERCHAR_13", record.Userchar13);
            record.Userchar14 = this.MapParameterOut(command, "@PA_ORG_USERCHAR_14", record.Userchar14);
            record.Userchar15 = this.MapParameterOut(command, "@PA_ORG_USERCHAR_15", record.Userchar15);
            record.Userdate3 = this.MapParameterOut(command, "@PA_ORG_USERDATE_3", record.Userdate3);
            record.Userdate4 = this.MapParameterOut(command, "@PA_ORG_USERDATE_4", record.Userdate4);
            record.Userdate5 = this.MapParameterOut(command, "@PA_ORG_USERDATE_5", record.Userdate5);
            record.Usernum5 = this.MapParameterOut(command, "@PA_ORG_USERNUM_5", record.Usernum5);
            record.Usernum6 = this.MapParameterOut(command, "@PA_ORG_USERNUM_6", record.Usernum6);
            record.Usernum7 = this.MapParameterOut(command, "@PA_ORG_USERNUM_7", record.Usernum7);
            record.Usernum8 = this.MapParameterOut(command, "@PA_ORG_USERNUM_8", record.Usernum8);
            record.Userint1 = this.MapParameterOut(command, "@PA_ORG_USERINT_1", record.Userint1);
            record.Userint2 = this.MapParameterOut(command, "@PA_ORG_USERINT_2", record.Userint2);
            record.Userint3 = this.MapParameterOut(command, "@PA_ORG_USERINT_3", record.Userint3);
            record.Userint4 = this.MapParameterOut(command, "@PA_ORG_USERINT_4", record.Userint4);
            record.Userint5 = this.MapParameterOut(command, "@PA_ORG_USERINT_5", record.Userint5);
            record.MemCTot = this.MapParameterOut(command, "@PA_ORG_MEM_C_TOT", record.MemCTot);
            record.MemRTot = this.MapParameterOut(command, "@PA_ORG_MEM_R_TOT", record.MemRTot);
            record.MemLTot = this.MapParameterOut(command, "@PA_ORG_MEM_L_TOT", record.MemLTot);
            record.Donotfax = this.MapParameterOut(command, "@PA_ORG_DONOTFAX", record.Donotfax);
            record.Vatcd = this.MapParameterOut(command, "@PA_ORG_VATCD", record.Vatcd);
            record.CustStatus = this.MapParameterOut(command, "@PA_ORG_CUST_STATUS", record.CustStatus);
            record.Disabled = this.MapParameterOut(command, "@PA_ORG_DISABLED", record.Disabled);
            record.Userint6 = this.MapParameterOut(command, "@PA_ORG_USERINT_6", record.Userint6);
            record.Userdate6 = this.MapParameterOut(command, "@PA_ORG_USERDATE_6", record.Userdate6);
            record.OurOrg = this.MapParameterOut(command, "@PA_ORG_OUR_ORG", record.OurOrg);
            record.ExtKey = this.MapParameterOut(command, "@PA_ORG_EXT_KEY", record.ExtKey);
            record.AttribChar01 = this.MapParameterOut(command, "@PA_ORG_ATTRIB_CHAR_01", record.AttribChar01);
            record.AttribChar02 = this.MapParameterOut(command, "@PA_ORG_ATTRIB_CHAR_02", record.AttribChar02);
            record.AttribChar03 = this.MapParameterOut(command, "@PA_ORG_ATTRIB_CHAR_03", record.AttribChar03);
            record.AttribChar04 = this.MapParameterOut(command, "@PA_ORG_ATTRIB_CHAR_04", record.AttribChar04);
            record.AttribChar05 = this.MapParameterOut(command, "@PA_ORG_ATTRIB_CHAR_05", record.AttribChar05);
            record.AttribDate01 = this.MapParameterOut(command, "@PA_ORG_ATTRIB_DATE_01", record.AttribDate01);
            record.TypeSub = this.MapParameterOut(command, "@PA_ORG_TYPE_SUB", record.TypeSub);
            record.PhoneStd = this.MapParameterOut(command, "@PA_ORG_PHONE_STD", record.PhoneStd);
            record.FaxStd = this.MapParameterOut(command, "@PA_ORG_FAX_STD", record.FaxStd);
            record.ImmDuns = this.MapParameterOut(command, "@PA_ORG_IMM_DUNS", record.ImmDuns);
            record.ImmName = this.MapParameterOut(command, "@PA_ORG_IMM_NAME", record.ImmName);
            record.HqDuns = this.MapParameterOut(command, "@PA_ORG_HQ_DUNS", record.HqDuns);
            record.HqName = this.MapParameterOut(command, "@PA_ORG_HQ_NAME", record.HqName);
            record.UltukDuns = this.MapParameterOut(command, "@PA_ORG_ULTUK_DUNS", record.UltukDuns);
            record.UltukName = this.MapParameterOut(command, "@PA_ORG_ULTUK_NAME", record.UltukName);
            record.UltDuns = this.MapParameterOut(command, "@PA_ORG_ULT_DUNS", record.UltDuns);
            record.UltName = this.MapParameterOut(command, "@PA_ORG_ULT_NAME", record.UltName);
            record.MemATot = this.MapParameterOut(command, "@PA_ORG_MEM_A_TOT", record.MemATot);
            record.SelcoSpId = this.MapParameterOut(command, "@PA_ORG_SELCO_SP_ID", record.SelcoSpId);
            record.Area2 = this.MapParameterOut(command, "@PA_ORG_AREA2", record.Area2);
            record.Region2 = this.MapParameterOut(command, "@PA_ORG_REGION2", record.Region2);
            record.SectypeId = this.MapParameterOut(command, "@PA_ORG_SECTYPE_ID", record.SectypeId);
            record.OrgSubRegion = this.MapParameterOut(command, "@PA_org_sub_region", record.OrgSubRegion);
            record.Status = this.MapParameterOut(command, "@PA_ORG_STATUS", record.Status);
            record.OsId = this.MapParameterOut(command, "@PA_ORG_OS_ID", record.OsId);
            record.Confirmation = this.MapParameterOut(command, "@PA_ORG_CONFIRMATION", record.Confirmation);
            record.Ji = this.MapParameterOut(command, "@PA_ORG_JI", record.Ji);
            record.UniqueRef = this.MapParameterOut(command, "@PA_ORG_UNIQUE_REF", record.UniqueRef);
            record.Ref = this.MapParameterOut(command, "@PA_ORG_REF", record.Ref);
            record.RefPassword = this.MapParameterOut(command, "@PA_ORG_REF_PASSWORD", record.RefPassword);
            record.ValidDomainSuffix = this.MapParameterOut(command, "@PA_ORG_VALID_DOMAIN_SUFFIX", record.ValidDomainSuffix);
            record.SuppBktId = this.MapParameterOut(command, "@PA_ORG_SUPP_BKT_ID", record.SuppBktId);
            record.DoNotSpare1 = this.MapParameterOut(command, "@PA_ORG_DO_NOT_SPARE1", record.DoNotSpare1);
            record.DoNotSpare2 = this.MapParameterOut(command, "@PA_ORG_DO_NOT_SPARE2", record.DoNotSpare2);
            record.DoNotSpare3 = this.MapParameterOut(command, "@PA_ORG_DO_NOT_SPARE3", record.DoNotSpare3);
            record.DoNotSpare4 = this.MapParameterOut(command, "@PA_ORG_DO_NOT_SPARE4", record.DoNotSpare4);
            record.VatRegNum = this.MapParameterOut(command, "@PA_ORG_VAT_REG_NUM", record.VatRegNum);
            record.ReportPassword = this.MapParameterOut(command, "@PA_ORG_REPORT_PASSWORD", record.ReportPassword);
            record.ReportPath = this.MapParameterOut(command, "@PA_ORG_REPORT_PATH", record.ReportPath);
            record.ReportUsername = this.MapParameterOut(command, "@PA_ORG_REPORT_USERNAME", record.ReportUsername);
            record.InvAuthPassword = this.MapParameterOut(command, "@PA_ORG_INV_AUTH_PASSWORD", record.InvAuthPassword);
            record.WebEnabled = this.MapParameterOut(command, "@PA_ORG_WEB_ENABLED", record.WebEnabled);
            record.PersonCount = this.MapParameterOut(command, "@PA_ORG_PERSON_COUNT", record.PersonCount);
            record.Spend = this.MapParameterOut(command, "@PA_ORG_SPEND", record.Spend);
            record.OnHold = this.MapParameterOut(command, "@PA_ORG_ON_HOLD", record.OnHold);
            record.PshId = this.MapParameterOut(command, "@PA_ORG_PSH_ID", record.PshId);
            record.PortalConfirmation = this.MapParameterOut(command, "@PA_ORG_PORTAL_CONFIRMATION", record.PortalConfirmation);
            record.Id = this.MapParameterOut(command, "@PA_RETURN_ID", record.Id);
        }

        /// <summary>
        ///     Retrieves a collection of <see cref="OrganisationRecord" /> instances from the data store.
        /// </summary>
        /// <param name="selcoSpId">
        ///     The value which identifies the <see cref='OrganisationModel' /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The collection of <see cref="OrganisationRecord" /> instances that match the specified <paramref name='selcoSpId' />.
        /// </returns>
        public IEnumerable<OrganisationRecord> FetchAllBySelcoSpId(String selcoSpId)
        {
            DbCommand command = this.GetStoredProcedure(SqlServerOperation.FetchAll, "SelcoSpId");
            this.MapParameterIn(command, "@PA_ORG_SELCO_SP_ID", selcoSpId);
            return this.Execute(command);
        }

        #endregion

        #region implementations

        /// <summary>
        ///     Gets the underlying table name that this repository sit over.
        /// </summary>
        System.String IOrganisationRepository.TableName
        {
            get { return this.TableName; }
        }

        void IOrganisationRepository.Create(Consensus.Contact.OrganisationRecord record)
        {
            this.Create(record);
        }

        void IOrganisationRepository.Modify(Consensus.Contact.OrganisationRecord record)
        {
            this.Modify(record);
        }

        /// <summary>
        ///     Retrieves a collection of <see cref="T:Consensus.Contact.OrganisationRecord" /> instances from the data store.
        /// </summary>
        /// <param name="selcoSpId">
        ///     The value which identifies the <see cref="!:OrganisationModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The collection of <see cref="T:Consensus.Contact.OrganisationRecord" /> instances that match the specified <paramref name="selcoSpId" />.
        /// </returns>
        System.Collections.Generic.IEnumerable<Consensus.Contact.OrganisationRecord> IOrganisationRepository.FetchAllBySelcoSpId(System.String selcoSpId)
        {
            return this.FetchAllBySelcoSpId(selcoSpId);
        }

        #endregion
    }
}
