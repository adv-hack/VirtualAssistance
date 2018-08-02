using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Linq;

namespace Consensus.Logistics
{
    /// <summary>
    ///     Provides the persistence and retrieval of the <see cref="ProjectRecord" /> instances in a Microsoft SQL Server database.
    /// </summary>
    /// <remarks>
    ///     THIS CODE HAS BEEN AUTOMATICALLY GENERATED USING THE CONSENSUS DEVELOPER TOOLS.
    ///     DO NOT EDIT THIS CODE AS ANY CUSTOM MODIFICATIONS WILL BE LOST UPON REGENERATION.
    /// </remarks>
    public partial class SqlServerProjectRepository : SqlServerRepository<ProjectRecord, String>, IProjectRepository
    {
        #region properties

        /// <summary>
        ///     Gets the namespace in which the data type is contained.
        /// </summary>
        protected override String TypeNamespace
        {
            get { return "Logistics"; }
        }

        /// <summary>
        ///     Gets the name of the data type which is persisted by this repository.
        /// </summary>
        protected override String TypeName
        {
            get { return "Project"; }
        }

        /// <summary>
        ///     Gets the name of the parameter which is used to specify the unique value that identifies each instance of a <see cref="ProjectRecord" />.
        /// </summary>
        protected override String TypeKeyName
        {
            get { return "@PA_PROJ_ID"; }
        }

        /// <summary>
        ///     Gets the underlying table name that this repository sit over.
        /// </summary>
        public override String TableName
        {
            get { return "Project"; }
        }

        #endregion

        #region methods

        /// <summary>
        ///     Maps an <see cref="IDataRecord" /> to the specified <see cref="ProjectRecord" />.
        /// </summary>
        /// <param name="dataRecord">
        ///     The <see cref="IDataRecord" /> to be mapped.
        /// </param>
        /// <param name="record">
        ///     The <see cref="ProjectRecord" /> instance to be mapped to.
        /// </param>
        protected override void MapRecord(IDataRecord dataRecord, ProjectRecord record)
        {
            record.Id = dataRecord["PROJ_ID"].ConvertTo<String>();
            record.AddDate = dataRecord["PROJ_ADD_DATE"].ConvertTo<DateTime?>();
            record.AddBy = dataRecord["PROJ_ADD_BY"].ConvertTo<String>();
            record.ModDate = dataRecord["PROJ_MOD_DATE"].ConvertTo<DateTime?>();
            record.ModBy = dataRecord["PROJ_MOD_BY"].ConvertTo<String>();
            record.RcvDate = dataRecord["PROJ_RCV_DATE"].ConvertTo<DateTime?>();
            record.RcvFrom = dataRecord["PROJ_RCV_FROM"].ConvertTo<String>();
            record.Status = dataRecord["PROJ_STATUS"].ConvertTo<String>();
            record.MgrRoleId = dataRecord["PROJ_MGR_ROLE_ID"].ConvertTo<String>();
            record.PayTerms = dataRecord["PROJ_PAY_TERMS"].ConvertTo<String>();
            record.CurrSitu = dataRecord["PROJ_CURR_SITU"].ConvertTo<String>();
            record.Notes = dataRecord["PROJ_NOTES"].ConvertTo<String>();
            record.Value = dataRecord["PROJ_VALUE"].ConvertTo<Double?>();
            record.ValToDate = dataRecord["PROJ_VAL_TO_DATE"].ConvertTo<Double?>();
            record.Userval1 = dataRecord["PROJ_USERVAL_1"].ConvertTo<Double?>();
            record.Userval2 = dataRecord["PROJ_USERVAL_2"].ConvertTo<Double?>();
            record.Userval3 = dataRecord["PROJ_USERVAL_3"].ConvertTo<Double?>();
            record.Userval4 = dataRecord["PROJ_USERVAL_4"].ConvertTo<Double?>();
            record.Userval5 = dataRecord["PROJ_USERVAL_5"].ConvertTo<Double?>();
            record.Userval6 = dataRecord["PROJ_USERVAL_6"].ConvertTo<Double?>();
            record.Userval7 = dataRecord["PROJ_USERVAL_7"].ConvertTo<Double?>();
            record.Userval8 = dataRecord["PROJ_USERVAL_8"].ConvertTo<Double?>();
            record.TimeEst = dataRecord["PROJ_TIME_EST"].ConvertTo<Double?>();
            record.TimeAct = dataRecord["PROJ_TIME_ACT"].ConvertTo<Double?>();
            record.Usertime1 = dataRecord["PROJ_USERTIME_1"].ConvertTo<Double?>();
            record.Usertime2 = dataRecord["PROJ_USERTIME_2"].ConvertTo<Double?>();
            record.Usertime3 = dataRecord["PROJ_USERTIME_3"].ConvertTo<Double?>();
            record.Usertime4 = dataRecord["PROJ_USERTIME_4"].ConvertTo<Double?>();
            record.Usertime5 = dataRecord["PROJ_USERTIME_5"].ConvertTo<Double?>();
            record.Usertime6 = dataRecord["PROJ_USERTIME_6"].ConvertTo<Double?>();
            record.Usertime7 = dataRecord["PROJ_USERTIME_7"].ConvertTo<Double?>();
            record.Usertime8 = dataRecord["PROJ_USERTIME_8"].ConvertTo<Double?>();
            record.Cat = dataRecord["PROJ_CAT"].ConvertTo<String>();
            record.OrgId = dataRecord["PROJ_ORG_ID"].ConvertTo<String>();
            record.QuoteId = dataRecord["PROJ_QUOTE_ID"].ConvertTo<String>();
            record.Name = dataRecord["PROJ_NAME"].ConvertTo<String>();
            record.Lock = dataRecord["PROJ_LOCK"].ConvertTo<String>();
            record.StartDate = dataRecord["PROJ_START_DATE"].ConvertTo<DateTime?>();
            record.EndDate = dataRecord["PROJ_END_DATE"].ConvertTo<DateTime?>();
            record.TraHours = dataRecord["PROJ_TRA_HOURS"].ConvertTo<Double?>();
            record.HouCharge = dataRecord["PROJ_HOU_CHARGE"].ConvertTo<Double?>();
            record.TraCharge = dataRecord["PROJ_TRA_CHARGE"].ConvertTo<Double?>();
            record.Template = dataRecord["PROJ_TEMPLATE"].ConvertTo<Byte?>();
            record.SelcoSpId = dataRecord["PROJ_SELCO_SP_ID"].ConvertTo<String>();
            record.Invoiced = dataRecord["PROJ_INVOICED"].ConvertTo<Byte?>();
            record.CostCode = dataRecord["PROJ_COST_CODE"].ConvertTo<String>();
            record.RevCode = dataRecord["PROJ_REV_CODE"].ConvertTo<String>();
            record.OppId = dataRecord["PROJ_OPP_ID"].ConvertTo<String>();
            record.Userchar1 = dataRecord["PROJ_USERCHAR_1"].ConvertTo<String>();
            record.Chargable = dataRecord["PROJ_CHARGABLE"].ConvertTo<Byte?>();
            record.ForAttnOf = dataRecord["PROJ_FOR_ATTN_OF"].ConvertTo<String>();
            record.ProjectDir = dataRecord["PROJ_PROJECT_DIR"].ConvertTo<String>();
            record.PromId = dataRecord["PROJ_PROM_ID"].ConvertTo<String>();
            record.FeeYear = dataRecord["PROJ_FEE_YEAR"].ConvertTo<String>();
            record.Priority = dataRecord["PROJ_PRIORITY"].ConvertTo<String>();
            record.WorkOrder = dataRecord["PROJ_WORK_ORDER"].ConvertTo<String>();
            record.AttribChar01 = dataRecord["PROJ_ATTRIB_CHAR_01"].ConvertTo<String>();
            record.AttribChar02 = dataRecord["PROJ_ATTRIB_CHAR_02"].ConvertTo<String>();
            record.AttribChar03 = dataRecord["PROJ_ATTRIB_CHAR_03"].ConvertTo<String>();
            record.AttribChar04 = dataRecord["PROJ_ATTRIB_CHAR_04"].ConvertTo<String>();
            record.AttribChar05 = dataRecord["PROJ_ATTRIB_CHAR_05"].ConvertTo<String>();
            record.AttribChar06 = dataRecord["PROJ_ATTRIB_CHAR_06"].ConvertTo<String>();
            record.AttribTint01 = dataRecord["PROJ_ATTRIB_TINT_01"].ConvertTo<Byte?>();
            record.Ref = dataRecord["PROJ_REF"].ConvertTo<String>();
            record.AttribChar07 = dataRecord["PROJ_ATTRIB_CHAR_07"].ConvertTo<String>();
            record.AttribDate01 = dataRecord["PROJ_ATTRIB_DATE_01"].ConvertTo<DateTime?>();
            record.AttribDate02 = dataRecord["PROJ_ATTRIB_DATE_02"].ConvertTo<DateTime?>();
            record.AttribChar08 = dataRecord["PROJ_ATTRIB_CHAR_08"].ConvertTo<String>();
            record.AttribChar09 = dataRecord["PROJ_ATTRIB_CHAR_09"].ConvertTo<String>();
            record.AttribChar10 = dataRecord["PROJ_ATTRIB_CHAR_10"].ConvertTo<String>();
            record.BdCompBy = dataRecord["PROJ_BD_COMP_BY"].ConvertTo<String>();
            record.BdCompDate = dataRecord["PROJ_BD_COMP_DATE"].ConvertTo<DateTime?>();
            record.BdTotActCost = dataRecord["PROJ_BD_TOT_ACT_COST"].ConvertTo<Decimal?>();
            record.BdStatus = dataRecord["PROJ_BD_STATUS"].ConvertTo<String>();
            record.BdPrepBy = dataRecord["PROJ_BD_PREP_BY"].ConvertTo<String>();
            record.BdPrepDate = dataRecord["PROJ_BD_PREP_DATE"].ConvertTo<DateTime?>();
            record.BdAppBy = dataRecord["PROJ_BD_APP_BY"].ConvertTo<String>();
            record.BdAppDate = dataRecord["PROJ_BD_APP_DATE"].ConvertTo<DateTime?>();
            record.BdTotEstCost = dataRecord["PROJ_BD_TOT_EST_COST"].ConvertTo<Decimal?>();
            record.BdPoId = dataRecord["PROJ_BD_PO_ID"].ConvertTo<String>();
            record.MsprojId = dataRecord["PROJ_MSPROJ_ID"].ConvertTo<String>();
            record.Dropdown1 = dataRecord["PROJ_DROPDOWN_1"].ConvertTo<String>();
            record.Usernum1 = dataRecord["PROJ_USERNUM_1"].ConvertTo<Decimal?>();
            record.Usernum2 = dataRecord["PROJ_USERNUM_2"].ConvertTo<Decimal?>();
            record.Usernum3 = dataRecord["PROJ_USERNUM_3"].ConvertTo<Decimal?>();
            record.Usernum4 = dataRecord["PROJ_USERNUM_4"].ConvertTo<Decimal?>();
            record.Usernum5 = dataRecord["PROJ_USERNUM_5"].ConvertTo<Decimal?>();
            record.Usernum6 = dataRecord["PROJ_USERNUM_6"].ConvertTo<Decimal?>();
            record.Userint1 = dataRecord["PROJ_USERINT_1"].ConvertTo<Byte?>();
            record.Userint2 = dataRecord["PROJ_USERINT_2"].ConvertTo<Byte?>();
            record.Userint3 = dataRecord["PROJ_USERINT_3"].ConvertTo<Byte?>();
            record.Userint4 = dataRecord["PROJ_USERINT_4"].ConvertTo<Byte?>();
            record.Userint5 = dataRecord["PROJ_USERINT_5"].ConvertTo<Byte?>();
            record.Userint6 = dataRecord["PROJ_USERINT_6"].ConvertTo<Byte?>();
            record.Userchar2 = dataRecord["PROJ_USERCHAR_2"].ConvertTo<String>();
            record.Userchar3 = dataRecord["PROJ_USERCHAR_3"].ConvertTo<String>();
            record.Userchar4 = dataRecord["PROJ_USERCHAR_4"].ConvertTo<String>();
            record.Userchar5 = dataRecord["PROJ_USERCHAR_5"].ConvertTo<String>();
            record.Userchar6 = dataRecord["PROJ_USERCHAR_6"].ConvertTo<String>();
            record.Userdate1 = dataRecord["PROJ_USERDATE_1"].ConvertTo<DateTime?>();
            record.Userdate2 = dataRecord["PROJ_USERDATE_2"].ConvertTo<DateTime?>();
            record.Userdate3 = dataRecord["PROJ_USERDATE_3"].ConvertTo<DateTime?>();
            record.Userdate4 = dataRecord["PROJ_USERDATE_4"].ConvertTo<DateTime?>();
            record.Userdate5 = dataRecord["PROJ_USERDATE_5"].ConvertTo<DateTime?>();
            record.Userdate6 = dataRecord["PROJ_USERDATE_6"].ConvertTo<DateTime?>();
            record.Rands = dataRecord["PROJ_RANDS"].ConvertTo<Byte>();
            record.BookId = dataRecord["PROJ_BOOK_ID"].ConvertTo<String>();
            record.QuoId = dataRecord["PROJ_QUO_ID"].ConvertTo<String>();
            record.Web = dataRecord["PROJ_WEB"].ConvertTo<Byte>();
        }

        /// <summary>
        ///     Sets the parameter values for the specified <paramref name="command" /> based on the specified <typeparamref name="TRecord" /> instance.
        /// </summary>
        /// <param name="command">
        ///     The <see cref="IDbCommand" /> containing the parameters to be mapped.
        /// </param>
        /// <param name="record">
        ///     The <see cref="ProjectRecord" /> instance to be mapped.
        /// </param>
        /// <param name="useV6Logic">
        ///     Is the procedure being run an old version 6.x procedure? (the null value handling logic is different).
        /// </param>
        protected override void MapParametersIn(IDbCommand command, ProjectRecord record, bool useV6Logic)
        {
            this.MapParameterIn(command, "@PA_PROJ_ID", record.Id);
            this.MapParameterIn(command, "@PA_PROJ_STATUS", record.Status);
            this.MapParameterIn(command, "@PA_PROJ_MGR_ROLE_ID", record.MgrRoleId);
            this.MapParameterIn(command, "@PA_PROJ_PAY_TERMS", record.PayTerms);
            this.MapParameterIn(command, "@PA_PROJ_CURR_SITU", record.CurrSitu);
            this.MapParameterIn(command, "@PA_PROJ_NOTES", record.Notes);
            this.MapParameterIn(command, "@PA_PROJ_VALUE", record.Value == Double.MinValue ? ( useV6Logic ? new Double?(0) : null ) : record.Value);
            this.MapParameterIn(command, "@PA_PROJ_VAL_TO_DATE", record.ValToDate == Double.MinValue ? ( useV6Logic ? new Double?(0) : null ) : record.ValToDate);
            this.MapParameterIn(command, "@PA_PROJ_USERVAL_1", record.Userval1 == Double.MinValue ? ( useV6Logic ? new Double?(0) : null ) : record.Userval1);
            this.MapParameterIn(command, "@PA_PROJ_USERVAL_2", record.Userval2 == Double.MinValue ? ( useV6Logic ? new Double?(0) : null ) : record.Userval2);
            this.MapParameterIn(command, "@PA_PROJ_USERVAL_3", record.Userval3 == Double.MinValue ? ( useV6Logic ? new Double?(0) : null ) : record.Userval3);
            this.MapParameterIn(command, "@PA_PROJ_USERVAL_4", record.Userval4 == Double.MinValue ? ( useV6Logic ? new Double?(0) : null ) : record.Userval4);
            this.MapParameterIn(command, "@PA_PROJ_USERVAL_5", record.Userval5 == Double.MinValue ? ( useV6Logic ? new Double?(0) : null ) : record.Userval5);
            this.MapParameterIn(command, "@PA_PROJ_USERVAL_6", record.Userval6 == Double.MinValue ? ( useV6Logic ? new Double?(0) : null ) : record.Userval6);
            this.MapParameterIn(command, "@PA_PROJ_USERVAL_7", record.Userval7 == Double.MinValue ? ( useV6Logic ? new Double?(0) : null ) : record.Userval7);
            this.MapParameterIn(command, "@PA_PROJ_USERVAL_8", record.Userval8 == Double.MinValue ? ( useV6Logic ? new Double?(0) : null ) : record.Userval8);
            this.MapParameterIn(command, "@PA_PROJ_TIME_EST", record.TimeEst == Double.MinValue ? ( useV6Logic ? new Double?(0) : null ) : record.TimeEst);
            this.MapParameterIn(command, "@PA_PROJ_TIME_ACT", record.TimeAct == Double.MinValue ? ( useV6Logic ? new Double?(0) : null ) : record.TimeAct);
            this.MapParameterIn(command, "@PA_PROJ_USERTIME_1", record.Usertime1 == Double.MinValue ? ( useV6Logic ? new Double?(0) : null ) : record.Usertime1);
            this.MapParameterIn(command, "@PA_PROJ_USERTIME_2", record.Usertime2 == Double.MinValue ? ( useV6Logic ? new Double?(0) : null ) : record.Usertime2);
            this.MapParameterIn(command, "@PA_PROJ_USERTIME_3", record.Usertime3 == Double.MinValue ? ( useV6Logic ? new Double?(0) : null ) : record.Usertime3);
            this.MapParameterIn(command, "@PA_PROJ_USERTIME_4", record.Usertime4 == Double.MinValue ? ( useV6Logic ? new Double?(0) : null ) : record.Usertime4);
            this.MapParameterIn(command, "@PA_PROJ_USERTIME_5", record.Usertime5 == Double.MinValue ? ( useV6Logic ? new Double?(0) : null ) : record.Usertime5);
            this.MapParameterIn(command, "@PA_PROJ_USERTIME_6", record.Usertime6 == Double.MinValue ? ( useV6Logic ? new Double?(0) : null ) : record.Usertime6);
            this.MapParameterIn(command, "@PA_PROJ_USERTIME_7", record.Usertime7 == Double.MinValue ? ( useV6Logic ? new Double?(0) : null ) : record.Usertime7);
            this.MapParameterIn(command, "@PA_PROJ_USERTIME_8", record.Usertime8 == Double.MinValue ? ( useV6Logic ? new Double?(0) : null ) : record.Usertime8);
            this.MapParameterIn(command, "@PA_PROJ_CAT", record.Cat);
            this.MapParameterIn(command, "@PA_PROJ_ORG_ID", record.OrgId);
            this.MapParameterIn(command, "@PA_PROJ_QUOTE_ID", record.QuoteId);
            this.MapParameterIn(command, "@PA_PROJ_NAME", record.Name);
            this.MapParameterIn(command, "@PA_PROJ_LOCK", record.Lock);
            this.MapParameterIn(command, "@PA_PROJ_START_DATE", record.StartDate == DateTime.MinValue ? ( useV6Logic ? new DateTime?(new DateTime(1900,1,1)) : null ) : record.StartDate);
            this.MapParameterIn(command, "@PA_PROJ_END_DATE", record.EndDate == DateTime.MinValue ? ( useV6Logic ? new DateTime?(new DateTime(1900,1,1)) : null ) : record.EndDate);
            this.MapParameterIn(command, "@PA_PROJ_TRA_HOURS", record.TraHours == Double.MinValue ? ( useV6Logic ? new Double?(0) : null ) : record.TraHours);
            this.MapParameterIn(command, "@PA_PROJ_HOU_CHARGE", record.HouCharge == Double.MinValue ? ( useV6Logic ? new Double?(0) : null ) : record.HouCharge);
            this.MapParameterIn(command, "@PA_PROJ_TRA_CHARGE", record.TraCharge == Double.MinValue ? ( useV6Logic ? new Double?(0) : null ) : record.TraCharge);
            this.MapParameterIn(command, "@PA_PROJ_TEMPLATE", record.Template);
            this.MapParameterIn(command, "@PA_PROJ_SELCO_SP_ID", record.SelcoSpId);
            this.MapParameterIn(command, "@PA_PROJ_INVOICED", record.Invoiced);
            this.MapParameterIn(command, "@PA_PROJ_COST_CODE", record.CostCode);
            this.MapParameterIn(command, "@PA_PROJ_REV_CODE", record.RevCode);
            this.MapParameterIn(command, "@PA_PROJ_OPP_ID", record.OppId);
            this.MapParameterIn(command, "@PA_PROJ_USERCHAR_1", record.Userchar1);
            this.MapParameterIn(command, "@PA_PROJ_CHARGABLE", record.Chargable);
            this.MapParameterIn(command, "@PA_PROJ_FOR_ATTN_OF", record.ForAttnOf);
            this.MapParameterIn(command, "@PA_PROJ_PROJECT_DIR", record.ProjectDir);
            this.MapParameterIn(command, "@PA_PROJ_PROM_ID", record.PromId);
            this.MapParameterIn(command, "@PA_PROJ_FEE_YEAR", record.FeeYear);
            this.MapParameterIn(command, "@PA_PROJ_PRIORITY", record.Priority);
            this.MapParameterIn(command, "@PA_PROJ_WORK_ORDER", record.WorkOrder);
            this.MapParameterIn(command, "@PA_PROJ_ATTRIB_CHAR_01", record.AttribChar01);
            this.MapParameterIn(command, "@PA_PROJ_ATTRIB_CHAR_02", record.AttribChar02);
            this.MapParameterIn(command, "@PA_PROJ_ATTRIB_CHAR_03", record.AttribChar03);
            this.MapParameterIn(command, "@PA_PROJ_ATTRIB_CHAR_04", record.AttribChar04);
            this.MapParameterIn(command, "@PA_PROJ_ATTRIB_CHAR_05", record.AttribChar05);
            this.MapParameterIn(command, "@PA_PROJ_ATTRIB_CHAR_06", record.AttribChar06);
            this.MapParameterIn(command, "@PA_PROJ_ATTRIB_TINT_01", record.AttribTint01);
            this.MapParameterIn(command, "@PA_PROJ_REF", record.Ref);
            this.MapParameterIn(command, "@PA_PROJ_ATTRIB_CHAR_07", record.AttribChar07);
            this.MapParameterIn(command, "@PA_PROJ_ATTRIB_DATE_01", record.AttribDate01 == DateTime.MinValue ? ( useV6Logic ? new DateTime?(new DateTime(1900,1,1)) : null ) : record.AttribDate01);
            this.MapParameterIn(command, "@PA_PROJ_ATTRIB_DATE_02", record.AttribDate02 == DateTime.MinValue ? ( useV6Logic ? new DateTime?(new DateTime(1900,1,1)) : null ) : record.AttribDate02);
            this.MapParameterIn(command, "@PA_PROJ_ATTRIB_CHAR_08", record.AttribChar08);
            this.MapParameterIn(command, "@PA_PROJ_ATTRIB_CHAR_09", record.AttribChar09);
            this.MapParameterIn(command, "@PA_PROJ_ATTRIB_CHAR_10", record.AttribChar10);
            this.MapParameterIn(command, "@PA_PROJ_BD_COMP_BY", record.BdCompBy);
            this.MapParameterIn(command, "@PA_PROJ_BD_COMP_DATE", record.BdCompDate == DateTime.MinValue ? ( useV6Logic ? new DateTime?(new DateTime(1900,1,1)) : null ) : record.BdCompDate);
            this.MapParameterIn(command, "@PA_PROJ_BD_TOT_ACT_COST", record.BdTotActCost == Decimal.MinValue ? ( useV6Logic ? new Decimal?(0M) : null ) : record.BdTotActCost);
            this.MapParameterIn(command, "@PA_PROJ_BD_STATUS", record.BdStatus);
            this.MapParameterIn(command, "@PA_PROJ_BD_PREP_BY", record.BdPrepBy);
            this.MapParameterIn(command, "@PA_PROJ_BD_PREP_DATE", record.BdPrepDate == DateTime.MinValue ? ( useV6Logic ? new DateTime?(new DateTime(1900,1,1)) : null ) : record.BdPrepDate);
            this.MapParameterIn(command, "@PA_PROJ_BD_APP_BY", record.BdAppBy);
            this.MapParameterIn(command, "@PA_PROJ_BD_APP_DATE", record.BdAppDate == DateTime.MinValue ? ( useV6Logic ? new DateTime?(new DateTime(1900,1,1)) : null ) : record.BdAppDate);
            this.MapParameterIn(command, "@PA_PROJ_BD_TOT_EST_COST", record.BdTotEstCost == Decimal.MinValue ? ( useV6Logic ? new Decimal?(0M) : null ) : record.BdTotEstCost);
            this.MapParameterIn(command, "@PA_PROJ_BD_PO_ID", record.BdPoId);
            this.MapParameterIn(command, "@PA_PROJ_MSPROJ_ID", record.MsprojId);
            this.MapParameterIn(command, "@PA_PROJ_DROPDOWN_1", record.Dropdown1);
            this.MapParameterIn(command, "@PA_PROJ_USERNUM_1", record.Usernum1 == Decimal.MinValue ? ( useV6Logic ? new Decimal?(0M) : null ) : record.Usernum1);
            this.MapParameterIn(command, "@PA_PROJ_USERNUM_2", record.Usernum2 == Decimal.MinValue ? ( useV6Logic ? new Decimal?(0M) : null ) : record.Usernum2);
            this.MapParameterIn(command, "@PA_PROJ_USERNUM_3", record.Usernum3 == Decimal.MinValue ? ( useV6Logic ? new Decimal?(0M) : null ) : record.Usernum3);
            this.MapParameterIn(command, "@PA_PROJ_USERNUM_4", record.Usernum4 == Decimal.MinValue ? ( useV6Logic ? new Decimal?(0M) : null ) : record.Usernum4);
            this.MapParameterIn(command, "@PA_PROJ_USERNUM_5", record.Usernum5 == Decimal.MinValue ? ( useV6Logic ? new Decimal?(0M) : null ) : record.Usernum5);
            this.MapParameterIn(command, "@PA_PROJ_USERNUM_6", record.Usernum6 == Decimal.MinValue ? ( useV6Logic ? new Decimal?(0M) : null ) : record.Usernum6);
            this.MapParameterIn(command, "@PA_PROJ_USERINT_1", record.Userint1);
            this.MapParameterIn(command, "@PA_PROJ_USERINT_2", record.Userint2);
            this.MapParameterIn(command, "@PA_PROJ_USERINT_3", record.Userint3);
            this.MapParameterIn(command, "@PA_PROJ_USERINT_4", record.Userint4);
            this.MapParameterIn(command, "@PA_PROJ_USERINT_5", record.Userint5);
            this.MapParameterIn(command, "@PA_PROJ_USERINT_6", record.Userint6);
            this.MapParameterIn(command, "@PA_PROJ_USERCHAR_2", record.Userchar2);
            this.MapParameterIn(command, "@PA_PROJ_USERCHAR_3", record.Userchar3);
            this.MapParameterIn(command, "@PA_PROJ_USERCHAR_4", record.Userchar4);
            this.MapParameterIn(command, "@PA_PROJ_USERCHAR_5", record.Userchar5);
            this.MapParameterIn(command, "@PA_PROJ_USERCHAR_6", record.Userchar6);
            this.MapParameterIn(command, "@PA_PROJ_USERDATE_1", record.Userdate1 == DateTime.MinValue ? ( useV6Logic ? new DateTime?(new DateTime(1900,1,1)) : null ) : record.Userdate1);
            this.MapParameterIn(command, "@PA_PROJ_USERDATE_2", record.Userdate2 == DateTime.MinValue ? ( useV6Logic ? new DateTime?(new DateTime(1900,1,1)) : null ) : record.Userdate2);
            this.MapParameterIn(command, "@PA_PROJ_USERDATE_3", record.Userdate3 == DateTime.MinValue ? ( useV6Logic ? new DateTime?(new DateTime(1900,1,1)) : null ) : record.Userdate3);
            this.MapParameterIn(command, "@PA_PROJ_USERDATE_4", record.Userdate4 == DateTime.MinValue ? ( useV6Logic ? new DateTime?(new DateTime(1900,1,1)) : null ) : record.Userdate4);
            this.MapParameterIn(command, "@PA_PROJ_USERDATE_5", record.Userdate5 == DateTime.MinValue ? ( useV6Logic ? new DateTime?(new DateTime(1900,1,1)) : null ) : record.Userdate5);
            this.MapParameterIn(command, "@PA_PROJ_USERDATE_6", record.Userdate6 == DateTime.MinValue ? ( useV6Logic ? new DateTime?(new DateTime(1900,1,1)) : null ) : record.Userdate6);
            this.MapParameterIn(command, "@PA_PROJ_RANDS", record.Rands);
            this.MapParameterIn(command, "@PA_PROJ_BOOK_ID", record.BookId);
            this.MapParameterIn(command, "@PA_PROJ_QUO_ID", record.QuoId);
            this.MapParameterIn(command, "@PA_PROJ_WEB", record.Web);
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
        ///     The <see cref="ProjectRecord" /> instance to be updated.
        /// </param>
        protected override void MapParametersOut(IDbCommand command, ProjectRecord record)
        {
            record.Id = this.MapParameterOut(command, "@PA_PROJ_ID", record.Id);
            record.Status = this.MapParameterOut(command, "@PA_PROJ_STATUS", record.Status);
            record.MgrRoleId = this.MapParameterOut(command, "@PA_PROJ_MGR_ROLE_ID", record.MgrRoleId);
            record.PayTerms = this.MapParameterOut(command, "@PA_PROJ_PAY_TERMS", record.PayTerms);
            record.CurrSitu = this.MapParameterOut(command, "@PA_PROJ_CURR_SITU", record.CurrSitu);
            record.Notes = this.MapParameterOut(command, "@PA_PROJ_NOTES", record.Notes);
            record.Value = this.MapParameterOut(command, "@PA_PROJ_VALUE", record.Value);
            record.ValToDate = this.MapParameterOut(command, "@PA_PROJ_VAL_TO_DATE", record.ValToDate);
            record.Userval1 = this.MapParameterOut(command, "@PA_PROJ_USERVAL_1", record.Userval1);
            record.Userval2 = this.MapParameterOut(command, "@PA_PROJ_USERVAL_2", record.Userval2);
            record.Userval3 = this.MapParameterOut(command, "@PA_PROJ_USERVAL_3", record.Userval3);
            record.Userval4 = this.MapParameterOut(command, "@PA_PROJ_USERVAL_4", record.Userval4);
            record.Userval5 = this.MapParameterOut(command, "@PA_PROJ_USERVAL_5", record.Userval5);
            record.Userval6 = this.MapParameterOut(command, "@PA_PROJ_USERVAL_6", record.Userval6);
            record.Userval7 = this.MapParameterOut(command, "@PA_PROJ_USERVAL_7", record.Userval7);
            record.Userval8 = this.MapParameterOut(command, "@PA_PROJ_USERVAL_8", record.Userval8);
            record.TimeEst = this.MapParameterOut(command, "@PA_PROJ_TIME_EST", record.TimeEst);
            record.TimeAct = this.MapParameterOut(command, "@PA_PROJ_TIME_ACT", record.TimeAct);
            record.Usertime1 = this.MapParameterOut(command, "@PA_PROJ_USERTIME_1", record.Usertime1);
            record.Usertime2 = this.MapParameterOut(command, "@PA_PROJ_USERTIME_2", record.Usertime2);
            record.Usertime3 = this.MapParameterOut(command, "@PA_PROJ_USERTIME_3", record.Usertime3);
            record.Usertime4 = this.MapParameterOut(command, "@PA_PROJ_USERTIME_4", record.Usertime4);
            record.Usertime5 = this.MapParameterOut(command, "@PA_PROJ_USERTIME_5", record.Usertime5);
            record.Usertime6 = this.MapParameterOut(command, "@PA_PROJ_USERTIME_6", record.Usertime6);
            record.Usertime7 = this.MapParameterOut(command, "@PA_PROJ_USERTIME_7", record.Usertime7);
            record.Usertime8 = this.MapParameterOut(command, "@PA_PROJ_USERTIME_8", record.Usertime8);
            record.Cat = this.MapParameterOut(command, "@PA_PROJ_CAT", record.Cat);
            record.OrgId = this.MapParameterOut(command, "@PA_PROJ_ORG_ID", record.OrgId);
            record.QuoteId = this.MapParameterOut(command, "@PA_PROJ_QUOTE_ID", record.QuoteId);
            record.Name = this.MapParameterOut(command, "@PA_PROJ_NAME", record.Name);
            record.Lock = this.MapParameterOut(command, "@PA_PROJ_LOCK", record.Lock);
            record.StartDate = this.MapParameterOut(command, "@PA_PROJ_START_DATE", record.StartDate);
            record.EndDate = this.MapParameterOut(command, "@PA_PROJ_END_DATE", record.EndDate);
            record.TraHours = this.MapParameterOut(command, "@PA_PROJ_TRA_HOURS", record.TraHours);
            record.HouCharge = this.MapParameterOut(command, "@PA_PROJ_HOU_CHARGE", record.HouCharge);
            record.TraCharge = this.MapParameterOut(command, "@PA_PROJ_TRA_CHARGE", record.TraCharge);
            record.Template = this.MapParameterOut(command, "@PA_PROJ_TEMPLATE", record.Template);
            record.SelcoSpId = this.MapParameterOut(command, "@PA_PROJ_SELCO_SP_ID", record.SelcoSpId);
            record.Invoiced = this.MapParameterOut(command, "@PA_PROJ_INVOICED", record.Invoiced);
            record.CostCode = this.MapParameterOut(command, "@PA_PROJ_COST_CODE", record.CostCode);
            record.RevCode = this.MapParameterOut(command, "@PA_PROJ_REV_CODE", record.RevCode);
            record.OppId = this.MapParameterOut(command, "@PA_PROJ_OPP_ID", record.OppId);
            record.Userchar1 = this.MapParameterOut(command, "@PA_PROJ_USERCHAR_1", record.Userchar1);
            record.Chargable = this.MapParameterOut(command, "@PA_PROJ_CHARGABLE", record.Chargable);
            record.ForAttnOf = this.MapParameterOut(command, "@PA_PROJ_FOR_ATTN_OF", record.ForAttnOf);
            record.ProjectDir = this.MapParameterOut(command, "@PA_PROJ_PROJECT_DIR", record.ProjectDir);
            record.PromId = this.MapParameterOut(command, "@PA_PROJ_PROM_ID", record.PromId);
            record.FeeYear = this.MapParameterOut(command, "@PA_PROJ_FEE_YEAR", record.FeeYear);
            record.Priority = this.MapParameterOut(command, "@PA_PROJ_PRIORITY", record.Priority);
            record.WorkOrder = this.MapParameterOut(command, "@PA_PROJ_WORK_ORDER", record.WorkOrder);
            record.AttribChar01 = this.MapParameterOut(command, "@PA_PROJ_ATTRIB_CHAR_01", record.AttribChar01);
            record.AttribChar02 = this.MapParameterOut(command, "@PA_PROJ_ATTRIB_CHAR_02", record.AttribChar02);
            record.AttribChar03 = this.MapParameterOut(command, "@PA_PROJ_ATTRIB_CHAR_03", record.AttribChar03);
            record.AttribChar04 = this.MapParameterOut(command, "@PA_PROJ_ATTRIB_CHAR_04", record.AttribChar04);
            record.AttribChar05 = this.MapParameterOut(command, "@PA_PROJ_ATTRIB_CHAR_05", record.AttribChar05);
            record.AttribChar06 = this.MapParameterOut(command, "@PA_PROJ_ATTRIB_CHAR_06", record.AttribChar06);
            record.AttribTint01 = this.MapParameterOut(command, "@PA_PROJ_ATTRIB_TINT_01", record.AttribTint01);
            record.Ref = this.MapParameterOut(command, "@PA_PROJ_REF", record.Ref);
            record.AttribChar07 = this.MapParameterOut(command, "@PA_PROJ_ATTRIB_CHAR_07", record.AttribChar07);
            record.AttribDate01 = this.MapParameterOut(command, "@PA_PROJ_ATTRIB_DATE_01", record.AttribDate01);
            record.AttribDate02 = this.MapParameterOut(command, "@PA_PROJ_ATTRIB_DATE_02", record.AttribDate02);
            record.AttribChar08 = this.MapParameterOut(command, "@PA_PROJ_ATTRIB_CHAR_08", record.AttribChar08);
            record.AttribChar09 = this.MapParameterOut(command, "@PA_PROJ_ATTRIB_CHAR_09", record.AttribChar09);
            record.AttribChar10 = this.MapParameterOut(command, "@PA_PROJ_ATTRIB_CHAR_10", record.AttribChar10);
            record.BdCompBy = this.MapParameterOut(command, "@PA_PROJ_BD_COMP_BY", record.BdCompBy);
            record.BdCompDate = this.MapParameterOut(command, "@PA_PROJ_BD_COMP_DATE", record.BdCompDate);
            record.BdTotActCost = this.MapParameterOut(command, "@PA_PROJ_BD_TOT_ACT_COST", record.BdTotActCost);
            record.BdStatus = this.MapParameterOut(command, "@PA_PROJ_BD_STATUS", record.BdStatus);
            record.BdPrepBy = this.MapParameterOut(command, "@PA_PROJ_BD_PREP_BY", record.BdPrepBy);
            record.BdPrepDate = this.MapParameterOut(command, "@PA_PROJ_BD_PREP_DATE", record.BdPrepDate);
            record.BdAppBy = this.MapParameterOut(command, "@PA_PROJ_BD_APP_BY", record.BdAppBy);
            record.BdAppDate = this.MapParameterOut(command, "@PA_PROJ_BD_APP_DATE", record.BdAppDate);
            record.BdTotEstCost = this.MapParameterOut(command, "@PA_PROJ_BD_TOT_EST_COST", record.BdTotEstCost);
            record.BdPoId = this.MapParameterOut(command, "@PA_PROJ_BD_PO_ID", record.BdPoId);
            record.MsprojId = this.MapParameterOut(command, "@PA_PROJ_MSPROJ_ID", record.MsprojId);
            record.Dropdown1 = this.MapParameterOut(command, "@PA_PROJ_DROPDOWN_1", record.Dropdown1);
            record.Usernum1 = this.MapParameterOut(command, "@PA_PROJ_USERNUM_1", record.Usernum1);
            record.Usernum2 = this.MapParameterOut(command, "@PA_PROJ_USERNUM_2", record.Usernum2);
            record.Usernum3 = this.MapParameterOut(command, "@PA_PROJ_USERNUM_3", record.Usernum3);
            record.Usernum4 = this.MapParameterOut(command, "@PA_PROJ_USERNUM_4", record.Usernum4);
            record.Usernum5 = this.MapParameterOut(command, "@PA_PROJ_USERNUM_5", record.Usernum5);
            record.Usernum6 = this.MapParameterOut(command, "@PA_PROJ_USERNUM_6", record.Usernum6);
            record.Userint1 = this.MapParameterOut(command, "@PA_PROJ_USERINT_1", record.Userint1);
            record.Userint2 = this.MapParameterOut(command, "@PA_PROJ_USERINT_2", record.Userint2);
            record.Userint3 = this.MapParameterOut(command, "@PA_PROJ_USERINT_3", record.Userint3);
            record.Userint4 = this.MapParameterOut(command, "@PA_PROJ_USERINT_4", record.Userint4);
            record.Userint5 = this.MapParameterOut(command, "@PA_PROJ_USERINT_5", record.Userint5);
            record.Userint6 = this.MapParameterOut(command, "@PA_PROJ_USERINT_6", record.Userint6);
            record.Userchar2 = this.MapParameterOut(command, "@PA_PROJ_USERCHAR_2", record.Userchar2);
            record.Userchar3 = this.MapParameterOut(command, "@PA_PROJ_USERCHAR_3", record.Userchar3);
            record.Userchar4 = this.MapParameterOut(command, "@PA_PROJ_USERCHAR_4", record.Userchar4);
            record.Userchar5 = this.MapParameterOut(command, "@PA_PROJ_USERCHAR_5", record.Userchar5);
            record.Userchar6 = this.MapParameterOut(command, "@PA_PROJ_USERCHAR_6", record.Userchar6);
            record.Userdate1 = this.MapParameterOut(command, "@PA_PROJ_USERDATE_1", record.Userdate1);
            record.Userdate2 = this.MapParameterOut(command, "@PA_PROJ_USERDATE_2", record.Userdate2);
            record.Userdate3 = this.MapParameterOut(command, "@PA_PROJ_USERDATE_3", record.Userdate3);
            record.Userdate4 = this.MapParameterOut(command, "@PA_PROJ_USERDATE_4", record.Userdate4);
            record.Userdate5 = this.MapParameterOut(command, "@PA_PROJ_USERDATE_5", record.Userdate5);
            record.Userdate6 = this.MapParameterOut(command, "@PA_PROJ_USERDATE_6", record.Userdate6);
            record.Rands = this.MapParameterOut(command, "@PA_PROJ_RANDS", record.Rands);
            record.BookId = this.MapParameterOut(command, "@PA_PROJ_BOOK_ID", record.BookId);
            record.QuoId = this.MapParameterOut(command, "@PA_PROJ_QUO_ID", record.QuoId);
            record.Web = this.MapParameterOut(command, "@PA_PROJ_WEB", record.Web);
            record.Id = this.MapParameterOut(command, "@PA_RETURN_ID", record.Id);
        }

        #endregion

        #region implementations

        /// <summary>
        ///     Gets the underlying table name that this repository sit over.
        /// </summary>
        System.String IProjectRepository.TableName
        {
            get { return this.TableName; }
        }

        #endregion
    }
}
