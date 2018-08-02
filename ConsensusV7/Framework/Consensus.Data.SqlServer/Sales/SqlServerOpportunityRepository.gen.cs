using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Linq;

namespace Consensus.Sales
{
    /// <summary>
    ///     Provides the persistence and retrieval of the <see cref="OpportunityRecord" /> instances in a Microsoft SQL Server database.
    /// </summary>
    /// <remarks>
    ///     THIS CODE HAS BEEN AUTOMATICALLY GENERATED USING THE CONSENSUS DEVELOPER TOOLS.
    ///     DO NOT EDIT THIS CODE AS ANY CUSTOM MODIFICATIONS WILL BE LOST UPON REGENERATION.
    /// </remarks>
    public partial class SqlServerOpportunityRepository : SqlServerRepository<OpportunityRecord, String>, IOpportunityRepository
    {
        #region properties

        /// <summary>
        ///     Gets the namespace in which the data type is contained.
        /// </summary>
        protected override String TypeNamespace
        {
            get { return "Sales"; }
        }

        /// <summary>
        ///     Gets the name of the data type which is persisted by this repository.
        /// </summary>
        protected override String TypeName
        {
            get { return "Opportunity"; }
        }

        /// <summary>
        ///     Gets the name of the parameter which is used to specify the unique value that identifies each instance of a <see cref="OpportunityRecord" />.
        /// </summary>
        protected override String TypeKeyName
        {
            get { return "@PA_OPP_ID"; }
        }

        /// <summary>
        ///     Gets the underlying table name that this repository sit over.
        /// </summary>
        public override String TableName
        {
            get { return "Opportunity"; }
        }

        #endregion

        #region methods

        /// <summary>
        ///     Maps an <see cref="IDataRecord" /> to the specified <see cref="OpportunityRecord" />.
        /// </summary>
        /// <param name="dataRecord">
        ///     The <see cref="IDataRecord" /> to be mapped.
        /// </param>
        /// <param name="record">
        ///     The <see cref="OpportunityRecord" /> instance to be mapped to.
        /// </param>
        protected override void MapRecord(IDataRecord dataRecord, OpportunityRecord record)
        {
            record.Id = dataRecord["OPP_ID"].ConvertTo<String>();
            record.Lock = dataRecord["OPP_LOCK"].ConvertTo<String>();
            record.AddDate = dataRecord["OPP_ADD_DATE"].ConvertTo<DateTime?>();
            record.AddBy = dataRecord["OPP_ADD_BY"].ConvertTo<String>();
            record.ModDate = dataRecord["OPP_MOD_DATE"].ConvertTo<DateTime?>();
            record.ModBy = dataRecord["OPP_MOD_BY"].ConvertTo<String>();
            record.RcvDate = dataRecord["OPP_RCV_DATE"].ConvertTo<DateTime?>();
            record.RcvFrom = dataRecord["OPP_RCV_FROM"].ConvertTo<String>();
            record.QuoId = dataRecord["OPP_QUO_ID"].ConvertTo<String>();
            record.PromId = dataRecord["OPP_PROM_ID"].ConvertTo<String>();
            record.ProleIdSales = dataRecord["OPP_PROLE_ID_SALES"].ConvertTo<String>();
            record.ProleIdTaken = dataRecord["OPP_PROLE_ID_TAKEN"].ConvertTo<String>();
            record.SchId = dataRecord["OPP_SCH_ID"].ConvertTo<String>();
            record.TextId = dataRecord["OPP_TEXT_ID"].ConvertTo<String>();
            record.TextIdHis = dataRecord["OPP_TEXT_ID_HIS"].ConvertTo<String>();
            record.Status = dataRecord["OPP_STATUS"].ConvertTo<String>();
            record.StatusMkt = dataRecord["OPP_STATUS_MKT"].ConvertTo<String>();
            record.Period = dataRecord["OPP_PERIOD"].ConvertTo<String>();
            record.DateEnq = dataRecord["OPP_DATE_ENQ"].ConvertTo<DateTime?>();
            record.DateDec = dataRecord["OPP_DATE_DEC"].ConvertTo<DateTime?>();
            record.ValPot = dataRecord["OPP_VAL_POT"].ConvertTo<Double?>();
            record.ValSold = dataRecord["OPP_VAL_SOLD"].ConvertTo<Double?>();
            record.LostTo = dataRecord["OPP_LOST_TO"].ConvertTo<String>();
            record.LostRea = dataRecord["OPP_LOST_REA"].ConvertTo<String>();
            record.DateNext = dataRecord["OPP_DATE_NEXT"].ConvertTo<DateTime?>();
            record.QuoRef = dataRecord["OPP_QUO_REF"].ConvertTo<String>();
            record.QuoDate = dataRecord["OPP_QUO_DATE"].ConvertTo<DateTime?>();
            record.QuoVal = dataRecord["OPP_QUO_VAL"].ConvertTo<Double?>();
            record.Name = dataRecord["OPP_NAME"].ConvertTo<String>();
            record.Notes = dataRecord["OPP_NOTES"].ConvertTo<String>();
            record.ProbPurch = dataRecord["OPP_PROB_PURCH"].ConvertTo<Byte?>();
            record.ProbWin = dataRecord["OPP_PROB_WIN"].ConvertTo<Byte?>();
            record.DateRolStart = dataRecord["OPP_DATE_ROL_START"].ConvertTo<DateTime?>();
            record.PerdRoll = dataRecord["OPP_PERD_ROLL"].ConvertTo<String>();
            record.IncRoll = dataRecord["OPP_INC_ROLL"].ConvertTo<Byte?>();
            record.IncStart = dataRecord["OPP_INC_START"].ConvertTo<DateTime?>();
            record.IncEnd = dataRecord["OPP_INC_END"].ConvertTo<DateTime?>();
            record.DateRollEnd = dataRecord["OPP_DATE_ROLL_END"].ConvertTo<DateTime?>();
            record.NoteRoll = dataRecord["OPP_NOTE_ROLL"].ConvertTo<String>();
            record.RollQty = dataRecord["OPP_ROLL_QTY"].ConvertTo<Double?>();
            record.RollCost = dataRecord["OPP_ROLL_COST"].ConvertTo<Double?>();
            record.RollRet = dataRecord["OPP_ROLL_RET"].ConvertTo<Double?>();
            record.ValPotBc = dataRecord["OPP_VAL_POT_BC"].ConvertTo<Double?>();
            record.ValSoldBc = dataRecord["OPP_VAL_SOLD_BC"].ConvertTo<Double?>();
            record.QuoValBc = dataRecord["OPP_QUO_VAL_BC"].ConvertTo<Double?>();
            record.ProdInterest = dataRecord["OPP_PROD_INTEREST"].ConvertTo<String>();
            record.SmForcstDate = dataRecord["OPP_SM_FORCST_DATE"].ConvertTo<DateTime?>();
            record.SmValue = dataRecord["OPP_SM_VALUE"].ConvertTo<Double?>();
            record.SmValueBc = dataRecord["OPP_SM_VALUE_BC"].ConvertTo<Double?>();
            record.ProbWinSm = dataRecord["OPP_PROB_WIN_SM"].ConvertTo<Byte?>();
            record.CurrencyType = dataRecord["OPP_CURRENCY_TYPE"].ConvertTo<String>();
            record.ExecCode = dataRecord["OPP_EXEC_CODE"].ConvertTo<String>();
            record.TypeChanDate = dataRecord["OPP_TYPE_CHAN_DATE"].ConvertTo<DateTime?>();
            record.PurchOrdNo = dataRecord["OPP_PURCH_ORD_NO"].ConvertTo<String>();
            record.SubspPerFrom = dataRecord["OPP_SUBSP_PER_FROM"].ConvertTo<DateTime?>();
            record.SubsripPerTo = dataRecord["OPP_SUBSRIP_PER_TO"].ConvertTo<DateTime?>();
            record.BasicActVal = dataRecord["OPP_BASIC_ACT_VAL"].ConvertTo<Double?>();
            record.MatActVal = dataRecord["OPP_MAT_ACT_VAL"].ConvertTo<Double?>();
            record.TotActVal = dataRecord["OPP_TOT_ACT_VAL"].ConvertTo<Double?>();
            record.BasicDiscVal = dataRecord["OPP_BASIC_DISC_VAL"].ConvertTo<Double?>();
            record.MatDiscVal = dataRecord["OPP_MAT_DISC_VAL"].ConvertTo<Double?>();
            record.TotDiscVal = dataRecord["OPP_TOT_DISC_VAL"].ConvertTo<Double?>();
            record.BsActInvVal = dataRecord["OPP_BS_ACT_INV_VAL"].ConvertTo<Double?>();
            record.MtActInvVal = dataRecord["OPP_MT_ACT_INV_VAL"].ConvertTo<Double?>();
            record.TotAtInvVal = dataRecord["OPP_TOT_AT_INV_VAL"].ConvertTo<Double?>();
            record.BasicAnnVal = dataRecord["OPP_BASIC_ANN_VAL"].ConvertTo<Double?>();
            record.MatAnnualVal = dataRecord["OPP_MAT_ANNUAL_VAL"].ConvertTo<Double?>();
            record.TotAnnualVal = dataRecord["OPP_TOT_ANNUAL_VAL"].ConvertTo<Double?>();
            record.BscActValBc = dataRecord["OPP_BSC_ACT_VAL_BC"].ConvertTo<Double?>();
            record.MatActValBc = dataRecord["OPP_MAT_ACT_VAL_BC"].ConvertTo<Double?>();
            record.TotActValBc = dataRecord["OPP_TOT_ACT_VAL_BC"].ConvertTo<Double?>();
            record.BscDscValBc = dataRecord["OPP_BSC_DSC_VAL_BC"].ConvertTo<Double?>();
            record.MatDscValBc = dataRecord["OPP_MAT_DSC_VAL_BC"].ConvertTo<Double?>();
            record.TotDscValBc = dataRecord["OPP_TOT_DSC_VAL_BC"].ConvertTo<Double?>();
            record.BcAtInVlBc = dataRecord["OPP_BC_AT_IN_VL_BC"].ConvertTo<Double?>();
            record.MtAtInVlBc = dataRecord["OPP_MT_AT_IN_VL_BC"].ConvertTo<Double?>();
            record.TtAtInVlBc = dataRecord["OPP_TT_AT_IN_VL_BC"].ConvertTo<Double?>();
            record.BscAnnValBc = dataRecord["OPP_BSC_ANN_VAL_BC"].ConvertTo<Double?>();
            record.MatAnnValBc = dataRecord["OPP_MAT_ANN_VAL_BC"].ConvertTo<Double?>();
            record.TotAnnValBc = dataRecord["OPP_TOT_ANN_VAL_BC"].ConvertTo<Double?>();
            record.Medium = dataRecord["OPP_MEDIUM"].ConvertTo<String>();
            record.Frequency = dataRecord["OPP_FREQUENCY"].ConvertTo<String>();
            record.TailorMadeNo = dataRecord["OPP_TAILOR_MADE_NO"].ConvertTo<String>();
            record.DispatchDate = dataRecord["OPP_DISPATCH_DATE"].ConvertTo<DateTime?>();
            record.DisptchMethod = dataRecord["OPP_DISPTCH_METHOD"].ConvertTo<String>();
            record.ServprodText = dataRecord["OPP_SERVPROD_TEXT"].ConvertTo<String>();
            record.DateOnPrint = dataRecord["OPP_DATE_ON_PRINT"].ConvertTo<DateTime?>();
            record.PicId = dataRecord["OPP_PIC_ID"].ConvertTo<String>();
            record.OrgIdUser = dataRecord["OPP_ORG_ID_USER"].ConvertTo<String>();
            record.ActId = dataRecord["OPP_ACT_ID"].ConvertTo<String>();
            record.Usernum1 = dataRecord["OPP_USERNUM_1"].ConvertTo<Decimal?>();
            record.Userchar1 = dataRecord["OPP_USERCHAR_1"].ConvertTo<String>();
            record.Userchar2 = dataRecord["OPP_USERCHAR_2"].ConvertTo<String>();
            record.Userchar3 = dataRecord["OPP_USERCHAR_3"].ConvertTo<String>();
            record.Userchar4 = dataRecord["OPP_USERCHAR_4"].ConvertTo<String>();
            record.Competitor = dataRecord["OPP_COMPETITOR"].ConvertTo<String>();
            record.UseRollOut = dataRecord["OPP_USE_ROLL_OUT"].ConvertTo<Byte?>();
            record.Userchar5 = dataRecord["OPP_USERCHAR_5"].ConvertTo<String>();
            record.NxStage = dataRecord["OPP_NX_STAGE"].ConvertTo<String>();
            record.StageDt = dataRecord["OPP_STAGE_DT"].ConvertTo<DateTime?>();
            record.CameFromId = dataRecord["OPP_CAME_FROM_ID"].ConvertTo<String>();
            record.ProjId = dataRecord["OPP_PROJ_ID"].ConvertTo<String>();
            record.OppId = dataRecord["OPP_OPP_ID"].ConvertTo<String>();
            record.CameFrom = dataRecord["OPP_CAME_FROM"].ConvertTo<String>();
            record.OptimLock = dataRecord["OPP_OPTIM_LOCK"].ConvertTo<String>();
            record.AddPeriod = dataRecord["OPP_ADD_PERIOD"].ConvertTo<String>();
            record.TerrId = dataRecord["OPP_TERR_ID"].ConvertTo<String>();
            record.Desc = dataRecord["OPP_DESC"].ConvertTo<String>();
            record.Type = dataRecord["OPP_TYPE"].ConvertTo<Byte?>();
            record.Commit = dataRecord["OPP_COMMIT"].ConvertTo<Byte?>();
            record.ContType = dataRecord["OPP_CONT_TYPE"].ConvertTo<String>();
            record.OrigForcstDt = dataRecord["OPP_ORIG_FORCST_DT"].ConvertTo<DateTime?>();
            record.LostExp = dataRecord["OPP_LOST_EXP"].ConvertTo<String>();
            record.SelcoSpId = dataRecord["OPP_SELCO_SP_ID"].ConvertTo<String>();
            record.SalesType = dataRecord["OPP_SALES_TYPE"].ConvertTo<String>();
            record.Userchar6 = dataRecord["OPP_USERCHAR_6"].ConvertTo<String>();
            record.Userint1 = dataRecord["OPP_USERINT_1"].ConvertTo<Byte?>();
            record.Userint2 = dataRecord["OPP_USERINT_2"].ConvertTo<Byte?>();
            record.Userint3 = dataRecord["OPP_USERINT_3"].ConvertTo<Byte?>();
            record.Userint4 = dataRecord["OPP_USERINT_4"].ConvertTo<Byte?>();
            record.Userint5 = dataRecord["OPP_USERINT_5"].ConvertTo<Byte?>();
            record.Userint6 = dataRecord["OPP_USERINT_6"].ConvertTo<Byte?>();
            record.Usernum2 = dataRecord["OPP_USERNUM_2"].ConvertTo<Decimal?>();
            record.Usernum3 = dataRecord["OPP_USERNUM_3"].ConvertTo<Decimal?>();
            record.Usernum4 = dataRecord["OPP_USERNUM_4"].ConvertTo<Decimal?>();
            record.Usernum5 = dataRecord["OPP_USERNUM_5"].ConvertTo<Decimal?>();
            record.Usernum6 = dataRecord["OPP_USERNUM_6"].ConvertTo<Decimal?>();
            record.Userdate1 = dataRecord["OPP_USERDATE_1"].ConvertTo<DateTime?>();
            record.Userdate2 = dataRecord["OPP_USERDATE_2"].ConvertTo<DateTime?>();
            record.Userdate3 = dataRecord["OPP_USERDATE_3"].ConvertTo<DateTime?>();
            record.Userdate4 = dataRecord["OPP_USERDATE_4"].ConvertTo<DateTime?>();
            record.Userdate5 = dataRecord["OPP_USERDATE_5"].ConvertTo<DateTime?>();
            record.Userdate6 = dataRecord["OPP_USERDATE_6"].ConvertTo<DateTime?>();
            record.ExtProjId = dataRecord["OPP_EXT_PROJ_ID"].ConvertTo<String>();
            record.CourseId = dataRecord["OPP_COURSE_ID"].ConvertTo<String>();
            record.ProdId = dataRecord["OPP_PROD_ID"].ConvertTo<String>();
            record.MemId = dataRecord["OPP_MEM_ID"].ConvertTo<String>();
            record.CostCode = dataRecord["OPP_COST_CODE"].ConvertTo<String>();
            record.Service = dataRecord["OPP_SERVICE"].ConvertTo<String>();
            record.Dropdown1 = dataRecord["OPP_DROPDOWN_1"].ConvertTo<String>();
            record.Dropdown2 = dataRecord["OPP_DROPDOWN_2"].ConvertTo<String>();
            record.Dropdown3 = dataRecord["OPP_DROPDOWN_3"].ConvertTo<String>();
            record.Dropdown4 = dataRecord["OPP_DROPDOWN_4"].ConvertTo<String>();
            record.Userdate7 = dataRecord["OPP_USERDATE_7"].ConvertTo<DateTime?>();
            record.Userdate8 = dataRecord["OPP_USERDATE_8"].ConvertTo<DateTime?>();
            record.SchnId = dataRecord["OPP_SCHN_ID"].ConvertTo<String>();
            record.ReasDelay = dataRecord["OPP_REAS_DELAY"].ConvertTo<String>();
            record.Rationale = dataRecord["OPP_RATIONALE"].ConvertTo<String>();
            record.OrigEnquiryType = dataRecord["OPP_ORIG_ENQUIRY_TYPE"].ConvertTo<String>();
            record.SearchGroup = dataRecord["OPP_SEARCH_GROUP"].ConvertTo<String>();
            record.SyType = dataRecord["OPP_SY_TYPE"].ConvertTo<Int32>();
        }

        /// <summary>
        ///     Sets the parameter values for the specified <paramref name="command" /> based on the specified <typeparamref name="TRecord" /> instance.
        /// </summary>
        /// <param name="command">
        ///     The <see cref="IDbCommand" /> containing the parameters to be mapped.
        /// </param>
        /// <param name="record">
        ///     The <see cref="OpportunityRecord" /> instance to be mapped.
        /// </param>
        /// <param name="useV6Logic">
        ///     Is the procedure being run an old version 6.x procedure? (the null value handling logic is different).
        /// </param>
        protected override void MapParametersIn(IDbCommand command, OpportunityRecord record, bool useV6Logic)
        {
            this.MapParameterIn(command, "@PA_OPP_ID", record.Id);
            this.MapParameterIn(command, "@PA_OPP_LOCK", record.Lock);
            this.MapParameterIn(command, "@PA_OPP_QUO_ID", record.QuoId);
            this.MapParameterIn(command, "@PA_OPP_PROM_ID", record.PromId);
            this.MapParameterIn(command, "@PA_OPP_PROLE_ID_SALES", record.ProleIdSales);
            this.MapParameterIn(command, "@PA_OPP_PROLE_ID_TAKEN", record.ProleIdTaken);
            this.MapParameterIn(command, "@PA_OPP_SCH_ID", record.SchId);
            this.MapParameterIn(command, "@PA_OPP_TEXT_ID", record.TextId);
            this.MapParameterIn(command, "@PA_OPP_TEXT_ID_HIS", record.TextIdHis);
            this.MapParameterIn(command, "@PA_OPP_STATUS", record.Status);
            this.MapParameterIn(command, "@PA_OPP_STATUS_MKT", record.StatusMkt);
            this.MapParameterIn(command, "@PA_OPP_PERIOD", record.Period);
            this.MapParameterIn(command, "@PA_OPP_DATE_ENQ", record.DateEnq == DateTime.MinValue ? ( useV6Logic ? new DateTime?(new DateTime(1900,1,1)) : null ) : record.DateEnq);
            this.MapParameterIn(command, "@PA_OPP_DATE_DEC", record.DateDec == DateTime.MinValue ? ( useV6Logic ? new DateTime?(new DateTime(1900,1,1)) : null ) : record.DateDec);
            this.MapParameterIn(command, "@PA_OPP_VAL_POT", record.ValPot == Double.MinValue ? ( useV6Logic ? new Double?(0) : null ) : record.ValPot);
            this.MapParameterIn(command, "@PA_OPP_VAL_SOLD", record.ValSold == Double.MinValue ? ( useV6Logic ? new Double?(0) : null ) : record.ValSold);
            this.MapParameterIn(command, "@PA_OPP_LOST_TO", record.LostTo);
            this.MapParameterIn(command, "@PA_OPP_LOST_REA", record.LostRea);
            this.MapParameterIn(command, "@PA_OPP_DATE_NEXT", record.DateNext == DateTime.MinValue ? ( useV6Logic ? new DateTime?(new DateTime(1900,1,1)) : null ) : record.DateNext);
            this.MapParameterIn(command, "@PA_OPP_QUO_REF", record.QuoRef);
            this.MapParameterIn(command, "@PA_OPP_QUO_DATE", record.QuoDate == DateTime.MinValue ? ( useV6Logic ? new DateTime?(new DateTime(1900,1,1)) : null ) : record.QuoDate);
            this.MapParameterIn(command, "@PA_OPP_QUO_VAL", record.QuoVal == Double.MinValue ? ( useV6Logic ? new Double?(0) : null ) : record.QuoVal);
            this.MapParameterIn(command, "@PA_OPP_NAME", record.Name);
            this.MapParameterIn(command, "@PA_OPP_NOTES", record.Notes);
            this.MapParameterIn(command, "@PA_OPP_PROB_PURCH", record.ProbPurch);
            this.MapParameterIn(command, "@PA_OPP_PROB_WIN", record.ProbWin);
            this.MapParameterIn(command, "@PA_OPP_DATE_ROL_START", record.DateRolStart == DateTime.MinValue ? ( useV6Logic ? new DateTime?(new DateTime(1900,1,1)) : null ) : record.DateRolStart);
            this.MapParameterIn(command, "@PA_OPP_PERD_ROLL", record.PerdRoll);
            this.MapParameterIn(command, "@PA_OPP_INC_ROLL", record.IncRoll);
            this.MapParameterIn(command, "@PA_OPP_INC_START", record.IncStart == DateTime.MinValue ? ( useV6Logic ? new DateTime?(new DateTime(1900,1,1)) : null ) : record.IncStart);
            this.MapParameterIn(command, "@PA_OPP_INC_END", record.IncEnd == DateTime.MinValue ? ( useV6Logic ? new DateTime?(new DateTime(1900,1,1)) : null ) : record.IncEnd);
            this.MapParameterIn(command, "@PA_OPP_DATE_ROLL_END", record.DateRollEnd == DateTime.MinValue ? ( useV6Logic ? new DateTime?(new DateTime(1900,1,1)) : null ) : record.DateRollEnd);
            this.MapParameterIn(command, "@PA_OPP_NOTE_ROLL", record.NoteRoll);
            this.MapParameterIn(command, "@PA_OPP_ROLL_QTY", record.RollQty == Double.MinValue ? ( useV6Logic ? new Double?(0) : null ) : record.RollQty);
            this.MapParameterIn(command, "@PA_OPP_ROLL_COST", record.RollCost == Double.MinValue ? ( useV6Logic ? new Double?(0) : null ) : record.RollCost);
            this.MapParameterIn(command, "@PA_OPP_ROLL_RET", record.RollRet == Double.MinValue ? ( useV6Logic ? new Double?(0) : null ) : record.RollRet);
            this.MapParameterIn(command, "@PA_OPP_VAL_POT_BC", record.ValPotBc == Double.MinValue ? ( useV6Logic ? new Double?(0) : null ) : record.ValPotBc);
            this.MapParameterIn(command, "@PA_OPP_VAL_SOLD_BC", record.ValSoldBc == Double.MinValue ? ( useV6Logic ? new Double?(0) : null ) : record.ValSoldBc);
            this.MapParameterIn(command, "@PA_OPP_QUO_VAL_BC", record.QuoValBc == Double.MinValue ? ( useV6Logic ? new Double?(0) : null ) : record.QuoValBc);
            this.MapParameterIn(command, "@PA_OPP_PROD_INTEREST", record.ProdInterest);
            this.MapParameterIn(command, "@PA_OPP_SM_FORCST_DATE", record.SmForcstDate == DateTime.MinValue ? ( useV6Logic ? new DateTime?(new DateTime(1900,1,1)) : null ) : record.SmForcstDate);
            this.MapParameterIn(command, "@PA_OPP_SM_VALUE", record.SmValue == Double.MinValue ? ( useV6Logic ? new Double?(0) : null ) : record.SmValue);
            this.MapParameterIn(command, "@PA_OPP_SM_VALUE_BC", record.SmValueBc == Double.MinValue ? ( useV6Logic ? new Double?(0) : null ) : record.SmValueBc);
            this.MapParameterIn(command, "@PA_OPP_PROB_WIN_SM", record.ProbWinSm);
            this.MapParameterIn(command, "@PA_OPP_CURRENCY_TYPE", record.CurrencyType);
            this.MapParameterIn(command, "@PA_OPP_EXEC_CODE", record.ExecCode);
            this.MapParameterIn(command, "@PA_OPP_TYPE_CHAN_DATE", record.TypeChanDate == DateTime.MinValue ? ( useV6Logic ? new DateTime?(new DateTime(1900,1,1)) : null ) : record.TypeChanDate);
            this.MapParameterIn(command, "@PA_OPP_PURCH_ORD_NO", record.PurchOrdNo);
            this.MapParameterIn(command, "@PA_OPP_SUBSP_PER_FROM", record.SubspPerFrom == DateTime.MinValue ? ( useV6Logic ? new DateTime?(new DateTime(1900,1,1)) : null ) : record.SubspPerFrom);
            this.MapParameterIn(command, "@PA_OPP_SUBSRIP_PER_TO", record.SubsripPerTo == DateTime.MinValue ? ( useV6Logic ? new DateTime?(new DateTime(1900,1,1)) : null ) : record.SubsripPerTo);
            this.MapParameterIn(command, "@PA_OPP_BASIC_ACT_VAL", record.BasicActVal == Double.MinValue ? ( useV6Logic ? new Double?(0) : null ) : record.BasicActVal);
            this.MapParameterIn(command, "@PA_OPP_MAT_ACT_VAL", record.MatActVal == Double.MinValue ? ( useV6Logic ? new Double?(0) : null ) : record.MatActVal);
            this.MapParameterIn(command, "@PA_OPP_TOT_ACT_VAL", record.TotActVal == Double.MinValue ? ( useV6Logic ? new Double?(0) : null ) : record.TotActVal);
            this.MapParameterIn(command, "@PA_OPP_BASIC_DISC_VAL", record.BasicDiscVal == Double.MinValue ? ( useV6Logic ? new Double?(0) : null ) : record.BasicDiscVal);
            this.MapParameterIn(command, "@PA_OPP_MAT_DISC_VAL", record.MatDiscVal == Double.MinValue ? ( useV6Logic ? new Double?(0) : null ) : record.MatDiscVal);
            this.MapParameterIn(command, "@PA_OPP_TOT_DISC_VAL", record.TotDiscVal == Double.MinValue ? ( useV6Logic ? new Double?(0) : null ) : record.TotDiscVal);
            this.MapParameterIn(command, "@PA_OPP_BS_ACT_INV_VAL", record.BsActInvVal == Double.MinValue ? ( useV6Logic ? new Double?(0) : null ) : record.BsActInvVal);
            this.MapParameterIn(command, "@PA_OPP_MT_ACT_INV_VAL", record.MtActInvVal == Double.MinValue ? ( useV6Logic ? new Double?(0) : null ) : record.MtActInvVal);
            this.MapParameterIn(command, "@PA_OPP_TOT_AT_INV_VAL", record.TotAtInvVal == Double.MinValue ? ( useV6Logic ? new Double?(0) : null ) : record.TotAtInvVal);
            this.MapParameterIn(command, "@PA_OPP_BASIC_ANN_VAL", record.BasicAnnVal == Double.MinValue ? ( useV6Logic ? new Double?(0) : null ) : record.BasicAnnVal);
            this.MapParameterIn(command, "@PA_OPP_MAT_ANNUAL_VAL", record.MatAnnualVal == Double.MinValue ? ( useV6Logic ? new Double?(0) : null ) : record.MatAnnualVal);
            this.MapParameterIn(command, "@PA_OPP_TOT_ANNUAL_VAL", record.TotAnnualVal == Double.MinValue ? ( useV6Logic ? new Double?(0) : null ) : record.TotAnnualVal);
            this.MapParameterIn(command, "@PA_OPP_BSC_ACT_VAL_BC", record.BscActValBc == Double.MinValue ? ( useV6Logic ? new Double?(0) : null ) : record.BscActValBc);
            this.MapParameterIn(command, "@PA_OPP_MAT_ACT_VAL_BC", record.MatActValBc == Double.MinValue ? ( useV6Logic ? new Double?(0) : null ) : record.MatActValBc);
            this.MapParameterIn(command, "@PA_OPP_TOT_ACT_VAL_BC", record.TotActValBc == Double.MinValue ? ( useV6Logic ? new Double?(0) : null ) : record.TotActValBc);
            this.MapParameterIn(command, "@PA_OPP_BSC_DSC_VAL_BC", record.BscDscValBc == Double.MinValue ? ( useV6Logic ? new Double?(0) : null ) : record.BscDscValBc);
            this.MapParameterIn(command, "@PA_OPP_MAT_DSC_VAL_BC", record.MatDscValBc == Double.MinValue ? ( useV6Logic ? new Double?(0) : null ) : record.MatDscValBc);
            this.MapParameterIn(command, "@PA_OPP_TOT_DSC_VAL_BC", record.TotDscValBc == Double.MinValue ? ( useV6Logic ? new Double?(0) : null ) : record.TotDscValBc);
            this.MapParameterIn(command, "@PA_OPP_BC_AT_IN_VL_BC", record.BcAtInVlBc == Double.MinValue ? ( useV6Logic ? new Double?(0) : null ) : record.BcAtInVlBc);
            this.MapParameterIn(command, "@PA_OPP_MT_AT_IN_VL_BC", record.MtAtInVlBc == Double.MinValue ? ( useV6Logic ? new Double?(0) : null ) : record.MtAtInVlBc);
            this.MapParameterIn(command, "@PA_OPP_TT_AT_IN_VL_BC", record.TtAtInVlBc == Double.MinValue ? ( useV6Logic ? new Double?(0) : null ) : record.TtAtInVlBc);
            this.MapParameterIn(command, "@PA_OPP_BSC_ANN_VAL_BC", record.BscAnnValBc == Double.MinValue ? ( useV6Logic ? new Double?(0) : null ) : record.BscAnnValBc);
            this.MapParameterIn(command, "@PA_OPP_MAT_ANN_VAL_BC", record.MatAnnValBc == Double.MinValue ? ( useV6Logic ? new Double?(0) : null ) : record.MatAnnValBc);
            this.MapParameterIn(command, "@PA_OPP_TOT_ANN_VAL_BC", record.TotAnnValBc == Double.MinValue ? ( useV6Logic ? new Double?(0) : null ) : record.TotAnnValBc);
            this.MapParameterIn(command, "@PA_OPP_MEDIUM", record.Medium);
            this.MapParameterIn(command, "@PA_OPP_FREQUENCY", record.Frequency);
            this.MapParameterIn(command, "@PA_OPP_TAILOR_MADE_NO", record.TailorMadeNo);
            this.MapParameterIn(command, "@PA_OPP_DISPATCH_DATE", record.DispatchDate == DateTime.MinValue ? ( useV6Logic ? new DateTime?(new DateTime(1900,1,1)) : null ) : record.DispatchDate);
            this.MapParameterIn(command, "@PA_OPP_DISPTCH_METHOD", record.DisptchMethod);
            this.MapParameterIn(command, "@PA_OPP_SERVPROD_TEXT", record.ServprodText);
            this.MapParameterIn(command, "@PA_OPP_DATE_ON_PRINT", record.DateOnPrint == DateTime.MinValue ? ( useV6Logic ? new DateTime?(new DateTime(1900,1,1)) : null ) : record.DateOnPrint);
            this.MapParameterIn(command, "@PA_OPP_PIC_ID", record.PicId);
            this.MapParameterIn(command, "@PA_OPP_ORG_ID_USER", record.OrgIdUser);
            this.MapParameterIn(command, "@PA_OPP_ACT_ID", record.ActId);
            this.MapParameterIn(command, "@PA_OPP_USERNUM_1", record.Usernum1 == Decimal.MinValue ? ( useV6Logic ? new Decimal?(0M) : null ) : record.Usernum1);
            this.MapParameterIn(command, "@PA_OPP_USERCHAR_1", record.Userchar1);
            this.MapParameterIn(command, "@PA_OPP_USERCHAR_2", record.Userchar2);
            this.MapParameterIn(command, "@PA_OPP_USERCHAR_3", record.Userchar3);
            this.MapParameterIn(command, "@PA_OPP_USERCHAR_4", record.Userchar4);
            this.MapParameterIn(command, "@PA_OPP_COMPETITOR", record.Competitor);
            this.MapParameterIn(command, "@PA_OPP_USE_ROLL_OUT", record.UseRollOut);
            this.MapParameterIn(command, "@PA_OPP_USERCHAR_5", record.Userchar5);
            this.MapParameterIn(command, "@PA_OPP_NX_STAGE", record.NxStage);
            this.MapParameterIn(command, "@PA_OPP_STAGE_DT", record.StageDt == DateTime.MinValue ? ( useV6Logic ? new DateTime?(new DateTime(1900,1,1)) : null ) : record.StageDt);
            this.MapParameterIn(command, "@PA_OPP_CAME_FROM_ID", record.CameFromId);
            this.MapParameterIn(command, "@PA_OPP_PROJ_ID", record.ProjId);
            this.MapParameterIn(command, "@PA_OPP_OPP_ID", record.OppId);
            this.MapParameterIn(command, "@PA_OPP_CAME_FROM", record.CameFrom);
            this.MapParameterIn(command, "@PA_OPP_OPTIM_LOCK", record.OptimLock);
            this.MapParameterIn(command, "@PA_OPP_ADD_PERIOD", record.AddPeriod);
            this.MapParameterIn(command, "@PA_OPP_TERR_ID", record.TerrId);
            this.MapParameterIn(command, "@PA_OPP_DESC", record.Desc);
            this.MapParameterIn(command, "@PA_OPP_TYPE", record.Type);
            this.MapParameterIn(command, "@PA_OPP_COMMIT", record.Commit);
            this.MapParameterIn(command, "@PA_OPP_CONT_TYPE", record.ContType);
            this.MapParameterIn(command, "@PA_OPP_ORIG_FORCST_DT", record.OrigForcstDt == DateTime.MinValue ? ( useV6Logic ? new DateTime?(new DateTime(1900,1,1)) : null ) : record.OrigForcstDt);
            this.MapParameterIn(command, "@PA_OPP_LOST_EXP", record.LostExp);
            this.MapParameterIn(command, "@PA_OPP_SELCO_SP_ID", record.SelcoSpId);
            this.MapParameterIn(command, "@PA_OPP_SALES_TYPE", record.SalesType);
            this.MapParameterIn(command, "@PA_OPP_USERCHAR_6", record.Userchar6);
            this.MapParameterIn(command, "@PA_OPP_USERINT_1", record.Userint1);
            this.MapParameterIn(command, "@PA_OPP_USERINT_2", record.Userint2);
            this.MapParameterIn(command, "@PA_OPP_USERINT_3", record.Userint3);
            this.MapParameterIn(command, "@PA_OPP_USERINT_4", record.Userint4);
            this.MapParameterIn(command, "@PA_OPP_USERINT_5", record.Userint5);
            this.MapParameterIn(command, "@PA_OPP_USERINT_6", record.Userint6);
            this.MapParameterIn(command, "@PA_OPP_USERNUM_2", record.Usernum2 == Decimal.MinValue ? ( useV6Logic ? new Decimal?(0M) : null ) : record.Usernum2);
            this.MapParameterIn(command, "@PA_OPP_USERNUM_3", record.Usernum3 == Decimal.MinValue ? ( useV6Logic ? new Decimal?(0M) : null ) : record.Usernum3);
            this.MapParameterIn(command, "@PA_OPP_USERNUM_4", record.Usernum4 == Decimal.MinValue ? ( useV6Logic ? new Decimal?(0M) : null ) : record.Usernum4);
            this.MapParameterIn(command, "@PA_OPP_USERNUM_5", record.Usernum5 == Decimal.MinValue ? ( useV6Logic ? new Decimal?(0M) : null ) : record.Usernum5);
            this.MapParameterIn(command, "@PA_OPP_USERNUM_6", record.Usernum6 == Decimal.MinValue ? ( useV6Logic ? new Decimal?(0M) : null ) : record.Usernum6);
            this.MapParameterIn(command, "@PA_OPP_USERDATE_1", record.Userdate1 == DateTime.MinValue ? ( useV6Logic ? new DateTime?(new DateTime(1900,1,1)) : null ) : record.Userdate1);
            this.MapParameterIn(command, "@PA_OPP_USERDATE_2", record.Userdate2 == DateTime.MinValue ? ( useV6Logic ? new DateTime?(new DateTime(1900,1,1)) : null ) : record.Userdate2);
            this.MapParameterIn(command, "@PA_OPP_USERDATE_3", record.Userdate3 == DateTime.MinValue ? ( useV6Logic ? new DateTime?(new DateTime(1900,1,1)) : null ) : record.Userdate3);
            this.MapParameterIn(command, "@PA_OPP_USERDATE_4", record.Userdate4 == DateTime.MinValue ? ( useV6Logic ? new DateTime?(new DateTime(1900,1,1)) : null ) : record.Userdate4);
            this.MapParameterIn(command, "@PA_OPP_USERDATE_5", record.Userdate5 == DateTime.MinValue ? ( useV6Logic ? new DateTime?(new DateTime(1900,1,1)) : null ) : record.Userdate5);
            this.MapParameterIn(command, "@PA_OPP_USERDATE_6", record.Userdate6 == DateTime.MinValue ? ( useV6Logic ? new DateTime?(new DateTime(1900,1,1)) : null ) : record.Userdate6);
            this.MapParameterIn(command, "@PA_OPP_EXT_PROJ_ID", record.ExtProjId);
            this.MapParameterIn(command, "@PA_OPP_COURSE_ID", record.CourseId);
            this.MapParameterIn(command, "@PA_OPP_PROD_ID", record.ProdId);
            this.MapParameterIn(command, "@PA_OPP_MEM_ID", record.MemId);
            this.MapParameterIn(command, "@PA_OPP_COST_CODE", record.CostCode);
            this.MapParameterIn(command, "@PA_OPP_SERVICE", record.Service);
            this.MapParameterIn(command, "@PA_OPP_DROPDOWN_1", record.Dropdown1);
            this.MapParameterIn(command, "@PA_OPP_DROPDOWN_2", record.Dropdown2);
            this.MapParameterIn(command, "@PA_OPP_DROPDOWN_3", record.Dropdown3);
            this.MapParameterIn(command, "@PA_OPP_DROPDOWN_4", record.Dropdown4);
            this.MapParameterIn(command, "@PA_OPP_USERDATE_7", record.Userdate7 == DateTime.MinValue ? ( useV6Logic ? new DateTime?(new DateTime(1900,1,1)) : null ) : record.Userdate7);
            this.MapParameterIn(command, "@PA_OPP_USERDATE_8", record.Userdate8 == DateTime.MinValue ? ( useV6Logic ? new DateTime?(new DateTime(1900,1,1)) : null ) : record.Userdate8);
            this.MapParameterIn(command, "@PA_OPP_SCHN_ID", record.SchnId);
            this.MapParameterIn(command, "@PA_OPP_REAS_DELAY", record.ReasDelay);
            this.MapParameterIn(command, "@PA_OPP_RATIONALE", record.Rationale);
            this.MapParameterIn(command, "@PA_OPP_ORIG_ENQUIRY_TYPE", record.OrigEnquiryType);
            this.MapParameterIn(command, "@PA_OPP_SEARCH_GROUP", record.SearchGroup);
            this.MapParameterIn(command, "@PA_OPP_SY_TYPE", record.SyType == Int32.MinValue ? 0 : record.SyType);
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
        ///     The <see cref="OpportunityRecord" /> instance to be updated.
        /// </param>
        protected override void MapParametersOut(IDbCommand command, OpportunityRecord record)
        {
            record.Id = this.MapParameterOut(command, "@PA_OPP_ID", record.Id);
            record.Lock = this.MapParameterOut(command, "@PA_OPP_LOCK", record.Lock);
            record.QuoId = this.MapParameterOut(command, "@PA_OPP_QUO_ID", record.QuoId);
            record.PromId = this.MapParameterOut(command, "@PA_OPP_PROM_ID", record.PromId);
            record.ProleIdSales = this.MapParameterOut(command, "@PA_OPP_PROLE_ID_SALES", record.ProleIdSales);
            record.ProleIdTaken = this.MapParameterOut(command, "@PA_OPP_PROLE_ID_TAKEN", record.ProleIdTaken);
            record.SchId = this.MapParameterOut(command, "@PA_OPP_SCH_ID", record.SchId);
            record.TextId = this.MapParameterOut(command, "@PA_OPP_TEXT_ID", record.TextId);
            record.TextIdHis = this.MapParameterOut(command, "@PA_OPP_TEXT_ID_HIS", record.TextIdHis);
            record.Status = this.MapParameterOut(command, "@PA_OPP_STATUS", record.Status);
            record.StatusMkt = this.MapParameterOut(command, "@PA_OPP_STATUS_MKT", record.StatusMkt);
            record.Period = this.MapParameterOut(command, "@PA_OPP_PERIOD", record.Period);
            record.DateEnq = this.MapParameterOut(command, "@PA_OPP_DATE_ENQ", record.DateEnq);
            record.DateDec = this.MapParameterOut(command, "@PA_OPP_DATE_DEC", record.DateDec);
            record.ValPot = this.MapParameterOut(command, "@PA_OPP_VAL_POT", record.ValPot);
            record.ValSold = this.MapParameterOut(command, "@PA_OPP_VAL_SOLD", record.ValSold);
            record.LostTo = this.MapParameterOut(command, "@PA_OPP_LOST_TO", record.LostTo);
            record.LostRea = this.MapParameterOut(command, "@PA_OPP_LOST_REA", record.LostRea);
            record.DateNext = this.MapParameterOut(command, "@PA_OPP_DATE_NEXT", record.DateNext);
            record.QuoRef = this.MapParameterOut(command, "@PA_OPP_QUO_REF", record.QuoRef);
            record.QuoDate = this.MapParameterOut(command, "@PA_OPP_QUO_DATE", record.QuoDate);
            record.QuoVal = this.MapParameterOut(command, "@PA_OPP_QUO_VAL", record.QuoVal);
            record.Name = this.MapParameterOut(command, "@PA_OPP_NAME", record.Name);
            record.Notes = this.MapParameterOut(command, "@PA_OPP_NOTES", record.Notes);
            record.ProbPurch = this.MapParameterOut(command, "@PA_OPP_PROB_PURCH", record.ProbPurch);
            record.ProbWin = this.MapParameterOut(command, "@PA_OPP_PROB_WIN", record.ProbWin);
            record.DateRolStart = this.MapParameterOut(command, "@PA_OPP_DATE_ROL_START", record.DateRolStart);
            record.PerdRoll = this.MapParameterOut(command, "@PA_OPP_PERD_ROLL", record.PerdRoll);
            record.IncRoll = this.MapParameterOut(command, "@PA_OPP_INC_ROLL", record.IncRoll);
            record.IncStart = this.MapParameterOut(command, "@PA_OPP_INC_START", record.IncStart);
            record.IncEnd = this.MapParameterOut(command, "@PA_OPP_INC_END", record.IncEnd);
            record.DateRollEnd = this.MapParameterOut(command, "@PA_OPP_DATE_ROLL_END", record.DateRollEnd);
            record.NoteRoll = this.MapParameterOut(command, "@PA_OPP_NOTE_ROLL", record.NoteRoll);
            record.RollQty = this.MapParameterOut(command, "@PA_OPP_ROLL_QTY", record.RollQty);
            record.RollCost = this.MapParameterOut(command, "@PA_OPP_ROLL_COST", record.RollCost);
            record.RollRet = this.MapParameterOut(command, "@PA_OPP_ROLL_RET", record.RollRet);
            record.ValPotBc = this.MapParameterOut(command, "@PA_OPP_VAL_POT_BC", record.ValPotBc);
            record.ValSoldBc = this.MapParameterOut(command, "@PA_OPP_VAL_SOLD_BC", record.ValSoldBc);
            record.QuoValBc = this.MapParameterOut(command, "@PA_OPP_QUO_VAL_BC", record.QuoValBc);
            record.ProdInterest = this.MapParameterOut(command, "@PA_OPP_PROD_INTEREST", record.ProdInterest);
            record.SmForcstDate = this.MapParameterOut(command, "@PA_OPP_SM_FORCST_DATE", record.SmForcstDate);
            record.SmValue = this.MapParameterOut(command, "@PA_OPP_SM_VALUE", record.SmValue);
            record.SmValueBc = this.MapParameterOut(command, "@PA_OPP_SM_VALUE_BC", record.SmValueBc);
            record.ProbWinSm = this.MapParameterOut(command, "@PA_OPP_PROB_WIN_SM", record.ProbWinSm);
            record.CurrencyType = this.MapParameterOut(command, "@PA_OPP_CURRENCY_TYPE", record.CurrencyType);
            record.ExecCode = this.MapParameterOut(command, "@PA_OPP_EXEC_CODE", record.ExecCode);
            record.TypeChanDate = this.MapParameterOut(command, "@PA_OPP_TYPE_CHAN_DATE", record.TypeChanDate);
            record.PurchOrdNo = this.MapParameterOut(command, "@PA_OPP_PURCH_ORD_NO", record.PurchOrdNo);
            record.SubspPerFrom = this.MapParameterOut(command, "@PA_OPP_SUBSP_PER_FROM", record.SubspPerFrom);
            record.SubsripPerTo = this.MapParameterOut(command, "@PA_OPP_SUBSRIP_PER_TO", record.SubsripPerTo);
            record.BasicActVal = this.MapParameterOut(command, "@PA_OPP_BASIC_ACT_VAL", record.BasicActVal);
            record.MatActVal = this.MapParameterOut(command, "@PA_OPP_MAT_ACT_VAL", record.MatActVal);
            record.TotActVal = this.MapParameterOut(command, "@PA_OPP_TOT_ACT_VAL", record.TotActVal);
            record.BasicDiscVal = this.MapParameterOut(command, "@PA_OPP_BASIC_DISC_VAL", record.BasicDiscVal);
            record.MatDiscVal = this.MapParameterOut(command, "@PA_OPP_MAT_DISC_VAL", record.MatDiscVal);
            record.TotDiscVal = this.MapParameterOut(command, "@PA_OPP_TOT_DISC_VAL", record.TotDiscVal);
            record.BsActInvVal = this.MapParameterOut(command, "@PA_OPP_BS_ACT_INV_VAL", record.BsActInvVal);
            record.MtActInvVal = this.MapParameterOut(command, "@PA_OPP_MT_ACT_INV_VAL", record.MtActInvVal);
            record.TotAtInvVal = this.MapParameterOut(command, "@PA_OPP_TOT_AT_INV_VAL", record.TotAtInvVal);
            record.BasicAnnVal = this.MapParameterOut(command, "@PA_OPP_BASIC_ANN_VAL", record.BasicAnnVal);
            record.MatAnnualVal = this.MapParameterOut(command, "@PA_OPP_MAT_ANNUAL_VAL", record.MatAnnualVal);
            record.TotAnnualVal = this.MapParameterOut(command, "@PA_OPP_TOT_ANNUAL_VAL", record.TotAnnualVal);
            record.BscActValBc = this.MapParameterOut(command, "@PA_OPP_BSC_ACT_VAL_BC", record.BscActValBc);
            record.MatActValBc = this.MapParameterOut(command, "@PA_OPP_MAT_ACT_VAL_BC", record.MatActValBc);
            record.TotActValBc = this.MapParameterOut(command, "@PA_OPP_TOT_ACT_VAL_BC", record.TotActValBc);
            record.BscDscValBc = this.MapParameterOut(command, "@PA_OPP_BSC_DSC_VAL_BC", record.BscDscValBc);
            record.MatDscValBc = this.MapParameterOut(command, "@PA_OPP_MAT_DSC_VAL_BC", record.MatDscValBc);
            record.TotDscValBc = this.MapParameterOut(command, "@PA_OPP_TOT_DSC_VAL_BC", record.TotDscValBc);
            record.BcAtInVlBc = this.MapParameterOut(command, "@PA_OPP_BC_AT_IN_VL_BC", record.BcAtInVlBc);
            record.MtAtInVlBc = this.MapParameterOut(command, "@PA_OPP_MT_AT_IN_VL_BC", record.MtAtInVlBc);
            record.TtAtInVlBc = this.MapParameterOut(command, "@PA_OPP_TT_AT_IN_VL_BC", record.TtAtInVlBc);
            record.BscAnnValBc = this.MapParameterOut(command, "@PA_OPP_BSC_ANN_VAL_BC", record.BscAnnValBc);
            record.MatAnnValBc = this.MapParameterOut(command, "@PA_OPP_MAT_ANN_VAL_BC", record.MatAnnValBc);
            record.TotAnnValBc = this.MapParameterOut(command, "@PA_OPP_TOT_ANN_VAL_BC", record.TotAnnValBc);
            record.Medium = this.MapParameterOut(command, "@PA_OPP_MEDIUM", record.Medium);
            record.Frequency = this.MapParameterOut(command, "@PA_OPP_FREQUENCY", record.Frequency);
            record.TailorMadeNo = this.MapParameterOut(command, "@PA_OPP_TAILOR_MADE_NO", record.TailorMadeNo);
            record.DispatchDate = this.MapParameterOut(command, "@PA_OPP_DISPATCH_DATE", record.DispatchDate);
            record.DisptchMethod = this.MapParameterOut(command, "@PA_OPP_DISPTCH_METHOD", record.DisptchMethod);
            record.ServprodText = this.MapParameterOut(command, "@PA_OPP_SERVPROD_TEXT", record.ServprodText);
            record.DateOnPrint = this.MapParameterOut(command, "@PA_OPP_DATE_ON_PRINT", record.DateOnPrint);
            record.PicId = this.MapParameterOut(command, "@PA_OPP_PIC_ID", record.PicId);
            record.OrgIdUser = this.MapParameterOut(command, "@PA_OPP_ORG_ID_USER", record.OrgIdUser);
            record.ActId = this.MapParameterOut(command, "@PA_OPP_ACT_ID", record.ActId);
            record.Usernum1 = this.MapParameterOut(command, "@PA_OPP_USERNUM_1", record.Usernum1);
            record.Userchar1 = this.MapParameterOut(command, "@PA_OPP_USERCHAR_1", record.Userchar1);
            record.Userchar2 = this.MapParameterOut(command, "@PA_OPP_USERCHAR_2", record.Userchar2);
            record.Userchar3 = this.MapParameterOut(command, "@PA_OPP_USERCHAR_3", record.Userchar3);
            record.Userchar4 = this.MapParameterOut(command, "@PA_OPP_USERCHAR_4", record.Userchar4);
            record.Competitor = this.MapParameterOut(command, "@PA_OPP_COMPETITOR", record.Competitor);
            record.UseRollOut = this.MapParameterOut(command, "@PA_OPP_USE_ROLL_OUT", record.UseRollOut);
            record.Userchar5 = this.MapParameterOut(command, "@PA_OPP_USERCHAR_5", record.Userchar5);
            record.NxStage = this.MapParameterOut(command, "@PA_OPP_NX_STAGE", record.NxStage);
            record.StageDt = this.MapParameterOut(command, "@PA_OPP_STAGE_DT", record.StageDt);
            record.CameFromId = this.MapParameterOut(command, "@PA_OPP_CAME_FROM_ID", record.CameFromId);
            record.ProjId = this.MapParameterOut(command, "@PA_OPP_PROJ_ID", record.ProjId);
            record.OppId = this.MapParameterOut(command, "@PA_OPP_OPP_ID", record.OppId);
            record.CameFrom = this.MapParameterOut(command, "@PA_OPP_CAME_FROM", record.CameFrom);
            record.OptimLock = this.MapParameterOut(command, "@PA_OPP_OPTIM_LOCK", record.OptimLock);
            record.AddPeriod = this.MapParameterOut(command, "@PA_OPP_ADD_PERIOD", record.AddPeriod);
            record.TerrId = this.MapParameterOut(command, "@PA_OPP_TERR_ID", record.TerrId);
            record.Desc = this.MapParameterOut(command, "@PA_OPP_DESC", record.Desc);
            record.Type = this.MapParameterOut(command, "@PA_OPP_TYPE", record.Type);
            record.Commit = this.MapParameterOut(command, "@PA_OPP_COMMIT", record.Commit);
            record.ContType = this.MapParameterOut(command, "@PA_OPP_CONT_TYPE", record.ContType);
            record.OrigForcstDt = this.MapParameterOut(command, "@PA_OPP_ORIG_FORCST_DT", record.OrigForcstDt);
            record.LostExp = this.MapParameterOut(command, "@PA_OPP_LOST_EXP", record.LostExp);
            record.SelcoSpId = this.MapParameterOut(command, "@PA_OPP_SELCO_SP_ID", record.SelcoSpId);
            record.SalesType = this.MapParameterOut(command, "@PA_OPP_SALES_TYPE", record.SalesType);
            record.Userchar6 = this.MapParameterOut(command, "@PA_OPP_USERCHAR_6", record.Userchar6);
            record.Userint1 = this.MapParameterOut(command, "@PA_OPP_USERINT_1", record.Userint1);
            record.Userint2 = this.MapParameterOut(command, "@PA_OPP_USERINT_2", record.Userint2);
            record.Userint3 = this.MapParameterOut(command, "@PA_OPP_USERINT_3", record.Userint3);
            record.Userint4 = this.MapParameterOut(command, "@PA_OPP_USERINT_4", record.Userint4);
            record.Userint5 = this.MapParameterOut(command, "@PA_OPP_USERINT_5", record.Userint5);
            record.Userint6 = this.MapParameterOut(command, "@PA_OPP_USERINT_6", record.Userint6);
            record.Usernum2 = this.MapParameterOut(command, "@PA_OPP_USERNUM_2", record.Usernum2);
            record.Usernum3 = this.MapParameterOut(command, "@PA_OPP_USERNUM_3", record.Usernum3);
            record.Usernum4 = this.MapParameterOut(command, "@PA_OPP_USERNUM_4", record.Usernum4);
            record.Usernum5 = this.MapParameterOut(command, "@PA_OPP_USERNUM_5", record.Usernum5);
            record.Usernum6 = this.MapParameterOut(command, "@PA_OPP_USERNUM_6", record.Usernum6);
            record.Userdate1 = this.MapParameterOut(command, "@PA_OPP_USERDATE_1", record.Userdate1);
            record.Userdate2 = this.MapParameterOut(command, "@PA_OPP_USERDATE_2", record.Userdate2);
            record.Userdate3 = this.MapParameterOut(command, "@PA_OPP_USERDATE_3", record.Userdate3);
            record.Userdate4 = this.MapParameterOut(command, "@PA_OPP_USERDATE_4", record.Userdate4);
            record.Userdate5 = this.MapParameterOut(command, "@PA_OPP_USERDATE_5", record.Userdate5);
            record.Userdate6 = this.MapParameterOut(command, "@PA_OPP_USERDATE_6", record.Userdate6);
            record.ExtProjId = this.MapParameterOut(command, "@PA_OPP_EXT_PROJ_ID", record.ExtProjId);
            record.CourseId = this.MapParameterOut(command, "@PA_OPP_COURSE_ID", record.CourseId);
            record.ProdId = this.MapParameterOut(command, "@PA_OPP_PROD_ID", record.ProdId);
            record.MemId = this.MapParameterOut(command, "@PA_OPP_MEM_ID", record.MemId);
            record.CostCode = this.MapParameterOut(command, "@PA_OPP_COST_CODE", record.CostCode);
            record.Service = this.MapParameterOut(command, "@PA_OPP_SERVICE", record.Service);
            record.Dropdown1 = this.MapParameterOut(command, "@PA_OPP_DROPDOWN_1", record.Dropdown1);
            record.Dropdown2 = this.MapParameterOut(command, "@PA_OPP_DROPDOWN_2", record.Dropdown2);
            record.Dropdown3 = this.MapParameterOut(command, "@PA_OPP_DROPDOWN_3", record.Dropdown3);
            record.Dropdown4 = this.MapParameterOut(command, "@PA_OPP_DROPDOWN_4", record.Dropdown4);
            record.Userdate7 = this.MapParameterOut(command, "@PA_OPP_USERDATE_7", record.Userdate7);
            record.Userdate8 = this.MapParameterOut(command, "@PA_OPP_USERDATE_8", record.Userdate8);
            record.SchnId = this.MapParameterOut(command, "@PA_OPP_SCHN_ID", record.SchnId);
            record.ReasDelay = this.MapParameterOut(command, "@PA_OPP_REAS_DELAY", record.ReasDelay);
            record.Rationale = this.MapParameterOut(command, "@PA_OPP_RATIONALE", record.Rationale);
            record.OrigEnquiryType = this.MapParameterOut(command, "@PA_OPP_ORIG_ENQUIRY_TYPE", record.OrigEnquiryType);
            record.SearchGroup = this.MapParameterOut(command, "@PA_OPP_SEARCH_GROUP", record.SearchGroup);
            record.SyType = this.MapParameterOut(command, "@PA_OPP_SY_TYPE", record.SyType);
            record.Id = this.MapParameterOut(command, "@PA_RETURN_ID", record.Id);
        }

        /// <summary>
        ///     Retrieves a collection of <see cref="OpportunityRecord" /> instances from the data store.
        /// </summary>
        /// <param name="promId">
        ///     The value which identifies the <see cref='OpportunityModel' /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The collection of <see cref="OpportunityRecord" /> instances that match the specified <paramref name='promId' />.
        /// </returns>
        public IEnumerable<OpportunityRecord> FetchAllByPromId(String promId)
        {
            DbCommand command = this.GetStoredProcedure(SqlServerOperation.FetchAll, "PromId");
            this.MapParameterIn(command, "@PA_OPP_PROM_ID", promId);
            return this.Execute(command);
        }

        /// <summary>
        ///     Retrieves a collection of <see cref="OpportunityRecord" /> instances from the data store.
        /// </summary>
        /// <param name="actId">
        ///     The value which identifies the <see cref='OpportunityModel' /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The collection of <see cref="OpportunityRecord" /> instances that match the specified <paramref name='actId' />.
        /// </returns>
        public IEnumerable<OpportunityRecord> FetchAllByActId(String actId)
        {
            DbCommand command = this.GetStoredProcedure(SqlServerOperation.FetchAll, "ActId");
            this.MapParameterIn(command, "@PA_OPP_ACT_ID", actId);
            return this.Execute(command);
        }

        /// <summary>
        ///     Retrieves a collection of <see cref="OpportunityRecord" /> instances from the data store.
        /// </summary>
        /// <param name="selcoSpId">
        ///     The value which identifies the <see cref='OpportunityModel' /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The collection of <see cref="OpportunityRecord" /> instances that match the specified <paramref name='selcoSpId' />.
        /// </returns>
        public IEnumerable<OpportunityRecord> FetchAllBySelcoSpId(String selcoSpId)
        {
            DbCommand command = this.GetStoredProcedure(SqlServerOperation.FetchAll, "SelcoSpId");
            this.MapParameterIn(command, "@PA_OPP_SELCO_SP_ID", selcoSpId);
            return this.Execute(command);
        }

        /// <summary>
        ///     Retrieves a collection of <see cref="OpportunityRecord" /> instances from the data store.
        /// </summary>
        /// <param name="courseId">
        ///     The value which identifies the <see cref='OpportunityModel' /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The collection of <see cref="OpportunityRecord" /> instances that match the specified <paramref name='courseId' />.
        /// </returns>
        public IEnumerable<OpportunityRecord> FetchAllByCourseId(String courseId)
        {
            DbCommand command = this.GetStoredProcedure(SqlServerOperation.FetchAll, "CourseId");
            this.MapParameterIn(command, "@PA_OPP_COURSE_ID", courseId);
            return this.Execute(command);
        }

        /// <summary>
        ///     Retrieves a collection of <see cref="OpportunityRecord" /> instances from the data store.
        /// </summary>
        /// <param name="prodId">
        ///     The value which identifies the <see cref='OpportunityModel' /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The collection of <see cref="OpportunityRecord" /> instances that match the specified <paramref name='prodId' />.
        /// </returns>
        public IEnumerable<OpportunityRecord> FetchAllByProdId(String prodId)
        {
            DbCommand command = this.GetStoredProcedure(SqlServerOperation.FetchAll, "ProdId");
            this.MapParameterIn(command, "@PA_OPP_PROD_ID", prodId);
            return this.Execute(command);
        }

        #endregion

        #region implementations

        /// <summary>
        ///     Gets the underlying table name that this repository sit over.
        /// </summary>
        System.String IOpportunityRepository.TableName
        {
            get { return this.TableName; }
        }

        void IOpportunityRepository.Create(Consensus.Sales.OpportunityRecord record)
        {
            this.Create(record);
        }

        void IOpportunityRepository.Modify(Consensus.Sales.OpportunityRecord record)
        {
            this.Modify(record);
        }

        /// <summary>
        ///     Retrieves a collection of <see cref="T:Consensus.Sales.OpportunityRecord" /> instances from the data store.
        /// </summary>
        /// <param name="promId">
        ///     The value which identifies the <see cref="!:OpportunityModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The collection of <see cref="T:Consensus.Sales.OpportunityRecord" /> instances that match the specified <paramref name="promId" />.
        /// </returns>
        System.Collections.Generic.IEnumerable<Consensus.Sales.OpportunityRecord> IOpportunityRepository.FetchAllByPromId(System.String promId)
        {
            return this.FetchAllByPromId(promId);
        }

        /// <summary>
        ///     Retrieves a collection of <see cref="T:Consensus.Sales.OpportunityRecord" /> instances from the data store.
        /// </summary>
        /// <param name="actId">
        ///     The value which identifies the <see cref="!:OpportunityModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The collection of <see cref="T:Consensus.Sales.OpportunityRecord" /> instances that match the specified <paramref name="actId" />.
        /// </returns>
        System.Collections.Generic.IEnumerable<Consensus.Sales.OpportunityRecord> IOpportunityRepository.FetchAllByActId(System.String actId)
        {
            return this.FetchAllByActId(actId);
        }

        /// <summary>
        ///     Retrieves a collection of <see cref="T:Consensus.Sales.OpportunityRecord" /> instances from the data store.
        /// </summary>
        /// <param name="selcoSpId">
        ///     The value which identifies the <see cref="!:OpportunityModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The collection of <see cref="T:Consensus.Sales.OpportunityRecord" /> instances that match the specified <paramref name="selcoSpId" />.
        /// </returns>
        System.Collections.Generic.IEnumerable<Consensus.Sales.OpportunityRecord> IOpportunityRepository.FetchAllBySelcoSpId(System.String selcoSpId)
        {
            return this.FetchAllBySelcoSpId(selcoSpId);
        }

        /// <summary>
        ///     Retrieves a collection of <see cref="T:Consensus.Sales.OpportunityRecord" /> instances from the data store.
        /// </summary>
        /// <param name="courseId">
        ///     The value which identifies the <see cref="!:OpportunityModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The collection of <see cref="T:Consensus.Sales.OpportunityRecord" /> instances that match the specified <paramref name="courseId" />.
        /// </returns>
        System.Collections.Generic.IEnumerable<Consensus.Sales.OpportunityRecord> IOpportunityRepository.FetchAllByCourseId(System.String courseId)
        {
            return this.FetchAllByCourseId(courseId);
        }

        /// <summary>
        ///     Retrieves a collection of <see cref="T:Consensus.Sales.OpportunityRecord" /> instances from the data store.
        /// </summary>
        /// <param name="prodId">
        ///     The value which identifies the <see cref="!:OpportunityModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The collection of <see cref="T:Consensus.Sales.OpportunityRecord" /> instances that match the specified <paramref name="prodId" />.
        /// </returns>
        System.Collections.Generic.IEnumerable<Consensus.Sales.OpportunityRecord> IOpportunityRepository.FetchAllByProdId(System.String prodId)
        {
            return this.FetchAllByProdId(prodId);
        }

        #endregion
    }
}
