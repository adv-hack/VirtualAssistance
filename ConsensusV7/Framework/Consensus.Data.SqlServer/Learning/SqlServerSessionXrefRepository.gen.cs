using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Linq;

namespace Consensus.Learning
{
    /// <summary>
    ///     Provides the persistence and retrieval of the <see cref="SessionXrefRecord" /> instances in a Microsoft SQL Server database.
    /// </summary>
    /// <remarks>
    ///     THIS CODE HAS BEEN AUTOMATICALLY GENERATED USING THE CONSENSUS DEVELOPER TOOLS.
    ///     DO NOT EDIT THIS CODE AS ANY CUSTOM MODIFICATIONS WILL BE LOST UPON REGENERATION.
    /// </remarks>
    public partial class SqlServerSessionXrefRepository : SqlServerRepository<SessionXrefRecord, String>, ISessionXrefRepository
    {
        #region properties

        /// <summary>
        ///     Gets the namespace in which the data type is contained.
        /// </summary>
        protected override String TypeNamespace
        {
            get { return "Learning"; }
        }

        /// <summary>
        ///     Gets the name of the data type which is persisted by this repository.
        /// </summary>
        protected override String TypeName
        {
            get { return "SessionXref"; }
        }

        /// <summary>
        ///     Gets the name of the parameter which is used to specify the unique value that identifies each instance of a <see cref="SessionXrefRecord" />.
        /// </summary>
        protected override String TypeKeyName
        {
            get { return "@PA_SXREF_ID"; }
        }

        /// <summary>
        ///     Gets the underlying table name that this repository sit over.
        /// </summary>
        public override String TableName
        {
            get { return "Session_Xref"; }
        }

        #endregion

        #region methods

        /// <summary>
        ///     Maps an <see cref="IDataRecord" /> to the specified <see cref="SessionXrefRecord" />.
        /// </summary>
        /// <param name="dataRecord">
        ///     The <see cref="IDataRecord" /> to be mapped.
        /// </param>
        /// <param name="record">
        ///     The <see cref="SessionXrefRecord" /> instance to be mapped to.
        /// </param>
        protected override void MapRecord(IDataRecord dataRecord, SessionXrefRecord record)
        {
            record.Id = dataRecord["SXREF_ID"].ConvertTo<String>();
            record.Lock = dataRecord["SXREF_LOCK"].ConvertTo<String>();
            record.AddDate = dataRecord["SXREF_ADD_DATE"].ConvertTo<DateTime?>();
            record.AddBy = dataRecord["SXREF_ADD_BY"].ConvertTo<String>();
            record.ModDate = dataRecord["SXREF_MOD_DATE"].ConvertTo<DateTime?>();
            record.ModBy = dataRecord["SXREF_MOD_BY"].ConvertTo<String>();
            record.RcvDate = dataRecord["SXREF_RCV_DATE"].ConvertTo<DateTime?>();
            record.RcvFrom = dataRecord["SXREF_RCV_FROM"].ConvertTo<String>();
            record.CourseId = dataRecord["SXREF_COURSE_ID"].ConvertTo<String>();
            record.ActId = dataRecord["SXREF_ACT_ID"].ConvertTo<String>();
            record.Real = dataRecord["SXREF_REAL"].ConvertTo<Byte?>();
            record.Element = dataRecord["SXREF_ELEMENT"].ConvertTo<Byte?>();
            record.Mandatory = dataRecord["SXREF_MANDATORY"].ConvertTo<Byte?>();
            record.InvPrint = dataRecord["SXREF_INV_PRINT"].ConvertTo<Byte?>();
            record.Currency = dataRecord["SXREF_CURRENCY"].ConvertTo<String>();
            record.Price = dataRecord["SXREF_PRICE"].ConvertTo<Decimal>();
            record.BlockPrice = dataRecord["SXREF_BLOCK_PRICE"].ConvertTo<Decimal>();
            record.PriceBc = dataRecord["SXREF_PRICE_BC"].ConvertTo<Decimal>();
            record.BlkPriceBc = dataRecord["SXREF_BLK_PRICE_BC"].ConvertTo<Decimal>();
            record.Vatcd = dataRecord["SXREF_VATCD"].ConvertTo<String>();
            record.RevCode = dataRecord["SXREF_REV_CODE"].ConvertTo<String>();
            record.CostCode = dataRecord["SXREF_COST_CODE"].ConvertTo<String>();
            record.DoNotInv = dataRecord["SXREF_DO_NOT_INV"].ConvertTo<Byte?>();
            record.ShowSales = dataRecord["SXREF_SHOW_SALES"].ConvertTo<Byte?>();
            record.NoInSet = dataRecord["SXREF_NO_IN_SET"].ConvertTo<Int32?>();
            record.RetailPrice = dataRecord["SXREF_RETAIL_PRICE"].ConvertTo<Decimal>();
            record.CostPrice = dataRecord["SXREF_COST_PRICE"].ConvertTo<Decimal>();
            record.RetPriceBc = dataRecord["SXREF_RET_PRICE_BC"].ConvertTo<Decimal>();
            record.CstPriceBc = dataRecord["SXREF_CST_PRICE_BC"].ConvertTo<Decimal>();
            record.RetPricBc2 = dataRecord["SXREF_RET_PRIC_BC2"].ConvertTo<Decimal>();
            record.CstPricBc2 = dataRecord["SXREF_CST_PRIC_BC2"].ConvertTo<Decimal>();
            record.PriceA = dataRecord["SXREF_PRICE_A"].ConvertTo<Decimal>();
            record.PriceB = dataRecord["SXREF_PRICE_B"].ConvertTo<Decimal>();
            record.PriceC = dataRecord["SXREF_PRICE_C"].ConvertTo<Decimal>();
            record.PriceD = dataRecord["SXREF_PRICE_D"].ConvertTo<Decimal>();
            record.PriceE = dataRecord["SXREF_PRICE_E"].ConvertTo<Decimal>();
            record.Default = dataRecord["SXREF_DEFAULT"].ConvertTo<Byte?>();
            record.PlId = dataRecord["SXREF_PL_ID"].ConvertTo<String>();
            record.Ticket = dataRecord["SXREF_TICKET"].ConvertTo<Byte?>();
            record.GroupQty = dataRecord["SXREF_GROUP_QTY"].ConvertTo<Byte?>();
            record.GroupDte = dataRecord["SXREF_GROUP_DTE"].ConvertTo<Byte?>();
            record.GroupQtyId = dataRecord["SXREF_GROUP_QTY_ID"].ConvertTo<String>();
            record.GroupDteId = dataRecord["SXREF_GROUP_DTE_ID"].ConvertTo<String>();
            record.QtyMin = dataRecord["SXREF_QTY_MIN"].ConvertTo<Int32?>();
            record.QtyMax = dataRecord["SXREF_QTY_MAX"].ConvertTo<Int32?>();
            record.ValidFrom = dataRecord["SXREF_VALID_FROM"].ConvertTo<DateTime?>();
            record.ValidUntil = dataRecord["SXREF_VALID_UNTIL"].ConvertTo<DateTime?>();
            record.BeforeDays = dataRecord["SXREF_BEFORE_DAYS"].ConvertTo<Int32?>();
            record.Chargeable = dataRecord["SXREF_CHARGEABLE"].ConvertTo<Int32?>();
            record.MainSession = dataRecord["SXREF_MAIN_SESSION"].ConvertTo<Byte?>();
            record.EttId = dataRecord["SXREF_ETT_ID"].ConvertTo<String>();
            record.GrpSgId = dataRecord["SXREF_GRP_SG_ID"].ConvertTo<String>();
            record.StrmSgId = dataRecord["SXREF_STRM_SG_ID"].ConvertTo<String>();
            record.GridStart = dataRecord["SXREF_GRID_START"].ConvertTo<String>();
            record.GridEnd = dataRecord["SXREF_GRID_END"].ConvertTo<String>();
            record.SessPnts = dataRecord["SXREF_SESS_PNTS"].ConvertTo<Int32?>();
            record.MastSess = dataRecord["SXREF_MAST_SESS"].ConvertTo<Int32?>();
            record.Selected = dataRecord["SXREF_SELECTED"].ConvertTo<Byte?>();
            record.CountDel = dataRecord["SXREF_COUNT_DEL"].ConvertTo<Byte?>();
            record.PayPnts = dataRecord["SXREF_PAY_PNTS"].ConvertTo<Byte?>();
            record.Code = dataRecord["SXREF_CODE"].ConvertTo<String>();
            record.ActxrefId = dataRecord["SXREF_ACTXREF_ID"].ConvertTo<String>();
            record.ProdId = dataRecord["SXREF_PROD_ID"].ConvertTo<String>();
            record.PlName = dataRecord["SXREF_PL_NAME"].ConvertTo<String>();
            record.PrsId = dataRecord["SXREF_PRS_ID"].ConvertTo<String>();
            record.Member = dataRecord["SXREF_MEMBER"].ConvertTo<Byte?>();
            record.StartDay = dataRecord["SXREF_START_DAY"].ConvertTo<Int32?>();
            record.EndDay = dataRecord["SXREF_END_DAY"].ConvertTo<Int32?>();
            record.LstPrice = dataRecord["SXREF_LST_PRICE"].ConvertTo<Decimal>();
            record.Student = dataRecord["SXREF_STUDENT"].ConvertTo<Byte?>();
            record.BomId = dataRecord["SXREF_BOM_ID"].ConvertTo<String>();
            record.EpId = dataRecord["SXREF_EP_ID"].ConvertTo<Int32?>();
            record.ValidDate = dataRecord["SXREF_VALID_DATE"].ConvertTo<Byte>();
            record.Region = dataRecord["SXREF_REGION"].ConvertTo<String>();
            record.CsgId = dataRecord["SXREF_CSG_ID"].ConvertTo<Int32?>();
        }

        /// <summary>
        ///     Sets the parameter values for the specified <paramref name="command" /> based on the specified <typeparamref name="TRecord" /> instance.
        /// </summary>
        /// <param name="command">
        ///     The <see cref="IDbCommand" /> containing the parameters to be mapped.
        /// </param>
        /// <param name="record">
        ///     The <see cref="SessionXrefRecord" /> instance to be mapped.
        /// </param>
        /// <param name="useV6Logic">
        ///     Is the procedure being run an old version 6.x procedure? (the null value handling logic is different).
        /// </param>
        protected override void MapParametersIn(IDbCommand command, SessionXrefRecord record, bool useV6Logic)
        {
            this.MapParameterIn(command, "@PA_SXREF_ID", record.Id);
            this.MapParameterIn(command, "@PA_SXREF_LOCK", record.Lock);
            this.MapParameterIn(command, "@PA_SXREF_COURSE_ID", record.CourseId);
            this.MapParameterIn(command, "@PA_SXREF_ACT_ID", record.ActId);
            this.MapParameterIn(command, "@PA_SXREF_REAL", record.Real);
            this.MapParameterIn(command, "@PA_SXREF_ELEMENT", record.Element);
            this.MapParameterIn(command, "@PA_SXREF_MANDATORY", record.Mandatory);
            this.MapParameterIn(command, "@PA_SXREF_INV_PRINT", record.InvPrint);
            this.MapParameterIn(command, "@PA_SXREF_CURRENCY", record.Currency);
            this.MapParameterIn(command, "@PA_SXREF_PRICE", record.Price == Decimal.MinValue ? 0M : record.Price);
            this.MapParameterIn(command, "@PA_SXREF_BLOCK_PRICE", record.BlockPrice == Decimal.MinValue ? 0M : record.BlockPrice);
            this.MapParameterIn(command, "@PA_SXREF_PRICE_BC", record.PriceBc == Decimal.MinValue ? 0M : record.PriceBc);
            this.MapParameterIn(command, "@PA_SXREF_BLK_PRICE_BC", record.BlkPriceBc == Decimal.MinValue ? 0M : record.BlkPriceBc);
            this.MapParameterIn(command, "@PA_SXREF_VATCD", record.Vatcd);
            this.MapParameterIn(command, "@PA_SXREF_REV_CODE", record.RevCode);
            this.MapParameterIn(command, "@PA_SXREF_COST_CODE", record.CostCode);
            this.MapParameterIn(command, "@PA_SXREF_DO_NOT_INV", record.DoNotInv);
            this.MapParameterIn(command, "@PA_SXREF_SHOW_SALES", record.ShowSales);
            this.MapParameterIn(command, "@PA_SXREF_NO_IN_SET", record.NoInSet == Int32.MinValue ? ( useV6Logic ? new Int32?(0) : null ) : record.NoInSet);
            this.MapParameterIn(command, "@PA_SXREF_RETAIL_PRICE", record.RetailPrice == Decimal.MinValue ? 0M : record.RetailPrice);
            this.MapParameterIn(command, "@PA_SXREF_COST_PRICE", record.CostPrice == Decimal.MinValue ? 0M : record.CostPrice);
            this.MapParameterIn(command, "@PA_SXREF_RET_PRICE_BC", record.RetPriceBc == Decimal.MinValue ? 0M : record.RetPriceBc);
            this.MapParameterIn(command, "@PA_SXREF_CST_PRICE_BC", record.CstPriceBc == Decimal.MinValue ? 0M : record.CstPriceBc);
            this.MapParameterIn(command, "@PA_SXREF_RET_PRIC_BC2", record.RetPricBc2 == Decimal.MinValue ? 0M : record.RetPricBc2);
            this.MapParameterIn(command, "@PA_SXREF_CST_PRIC_BC2", record.CstPricBc2 == Decimal.MinValue ? 0M : record.CstPricBc2);
            this.MapParameterIn(command, "@PA_SXREF_PRICE_A", record.PriceA == Decimal.MinValue ? 0M : record.PriceA);
            this.MapParameterIn(command, "@PA_SXREF_PRICE_B", record.PriceB == Decimal.MinValue ? 0M : record.PriceB);
            this.MapParameterIn(command, "@PA_SXREF_PRICE_C", record.PriceC == Decimal.MinValue ? 0M : record.PriceC);
            this.MapParameterIn(command, "@PA_SXREF_PRICE_D", record.PriceD == Decimal.MinValue ? 0M : record.PriceD);
            this.MapParameterIn(command, "@PA_SXREF_PRICE_E", record.PriceE == Decimal.MinValue ? 0M : record.PriceE);
            this.MapParameterIn(command, "@PA_SXREF_DEFAULT", record.Default);
            this.MapParameterIn(command, "@PA_SXREF_PL_ID", record.PlId);
            this.MapParameterIn(command, "@PA_SXREF_TICKET", record.Ticket);
            this.MapParameterIn(command, "@PA_SXREF_GROUP_QTY", record.GroupQty);
            this.MapParameterIn(command, "@PA_SXREF_GROUP_DTE", record.GroupDte);
            this.MapParameterIn(command, "@PA_SXREF_GROUP_QTY_ID", record.GroupQtyId);
            this.MapParameterIn(command, "@PA_SXREF_GROUP_DTE_ID", record.GroupDteId);
            this.MapParameterIn(command, "@PA_SXREF_QTY_MIN", record.QtyMin == Int32.MinValue ? ( useV6Logic ? new Int32?(0) : null ) : record.QtyMin);
            this.MapParameterIn(command, "@PA_SXREF_QTY_MAX", record.QtyMax == Int32.MinValue ? ( useV6Logic ? new Int32?(0) : null ) : record.QtyMax);
            this.MapParameterIn(command, "@PA_SXREF_VALID_FROM", record.ValidFrom == DateTime.MinValue ? ( useV6Logic ? new DateTime?(new DateTime(1900,1,1)) : null ) : record.ValidFrom);
            this.MapParameterIn(command, "@PA_SXREF_VALID_UNTIL", record.ValidUntil == DateTime.MinValue ? ( useV6Logic ? new DateTime?(new DateTime(1900,1,1)) : null ) : record.ValidUntil);
            this.MapParameterIn(command, "@PA_SXREF_BEFORE_DAYS", record.BeforeDays == Int32.MinValue ? ( useV6Logic ? new Int32?(0) : null ) : record.BeforeDays);
            this.MapParameterIn(command, "@PA_SXREF_CHARGEABLE", record.Chargeable == Int32.MinValue ? ( useV6Logic ? new Int32?(0) : null ) : record.Chargeable);
            this.MapParameterIn(command, "@PA_SXREF_MAIN_SESSION", record.MainSession);
            this.MapParameterIn(command, "@PA_SXREF_ETT_ID", record.EttId);
            this.MapParameterIn(command, "@PA_SXREF_GRP_SG_ID", record.GrpSgId);
            this.MapParameterIn(command, "@PA_SXREF_STRM_SG_ID", record.StrmSgId);
            this.MapParameterIn(command, "@PA_SXREF_GRID_START", record.GridStart);
            this.MapParameterIn(command, "@PA_SXREF_GRID_END", record.GridEnd);
            this.MapParameterIn(command, "@PA_SXREF_SESS_PNTS", record.SessPnts == Int32.MinValue ? ( useV6Logic ? new Int32?(0) : null ) : record.SessPnts);
            this.MapParameterIn(command, "@PA_SXREF_MAST_SESS", record.MastSess == Int32.MinValue ? ( useV6Logic ? new Int32?(0) : null ) : record.MastSess);
            this.MapParameterIn(command, "@PA_SXREF_SELECTED", record.Selected);
            this.MapParameterIn(command, "@PA_SXREF_COUNT_DEL", record.CountDel);
            this.MapParameterIn(command, "@PA_SXREF_PAY_PNTS", record.PayPnts);
            this.MapParameterIn(command, "@PA_SXREF_CODE", record.Code);
            this.MapParameterIn(command, "@PA_SXREF_ACTXREF_ID", record.ActxrefId);
            this.MapParameterIn(command, "@PA_SXREF_PROD_ID", record.ProdId);
            this.MapParameterIn(command, "@PA_SXREF_PL_NAME", record.PlName);
            this.MapParameterIn(command, "@PA_SXREF_PRS_ID", record.PrsId);
            this.MapParameterIn(command, "@PA_SXREF_MEMBER", record.Member);
            this.MapParameterIn(command, "@PA_SXREF_START_DAY", record.StartDay == Int32.MinValue ? ( useV6Logic ? new Int32?(0) : null ) : record.StartDay);
            this.MapParameterIn(command, "@PA_SXREF_END_DAY", record.EndDay == Int32.MinValue ? ( useV6Logic ? new Int32?(0) : null ) : record.EndDay);
            this.MapParameterIn(command, "@PA_SXREF_LST_PRICE", record.LstPrice == Decimal.MinValue ? 0M : record.LstPrice);
            this.MapParameterIn(command, "@PA_SXREF_STUDENT", record.Student);
            this.MapParameterIn(command, "@PA_SXREF_BOM_ID", record.BomId);
            this.MapParameterIn(command, "@PA_SXREF_EP_ID", record.EpId == Int32.MinValue ? ( useV6Logic ? new Int32?(0) : null ) : record.EpId);
            this.MapParameterIn(command, "@PA_SXREF_VALID_DATE", record.ValidDate);
            this.MapParameterIn(command, "@PA_SXREF_REGION", record.Region);
            this.MapParameterIn(command, "@PA_SXREF_CSG_ID", record.CsgId == Int32.MinValue ? ( useV6Logic ? new Int32?(0) : null ) : record.CsgId);
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
        ///     The <see cref="SessionXrefRecord" /> instance to be updated.
        /// </param>
        protected override void MapParametersOut(IDbCommand command, SessionXrefRecord record)
        {
            record.Id = this.MapParameterOut(command, "@PA_SXREF_ID", record.Id);
            record.Lock = this.MapParameterOut(command, "@PA_SXREF_LOCK", record.Lock);
            record.CourseId = this.MapParameterOut(command, "@PA_SXREF_COURSE_ID", record.CourseId);
            record.ActId = this.MapParameterOut(command, "@PA_SXREF_ACT_ID", record.ActId);
            record.Real = this.MapParameterOut(command, "@PA_SXREF_REAL", record.Real);
            record.Element = this.MapParameterOut(command, "@PA_SXREF_ELEMENT", record.Element);
            record.Mandatory = this.MapParameterOut(command, "@PA_SXREF_MANDATORY", record.Mandatory);
            record.InvPrint = this.MapParameterOut(command, "@PA_SXREF_INV_PRINT", record.InvPrint);
            record.Currency = this.MapParameterOut(command, "@PA_SXREF_CURRENCY", record.Currency);
            record.Price = this.MapParameterOut(command, "@PA_SXREF_PRICE", record.Price);
            record.BlockPrice = this.MapParameterOut(command, "@PA_SXREF_BLOCK_PRICE", record.BlockPrice);
            record.PriceBc = this.MapParameterOut(command, "@PA_SXREF_PRICE_BC", record.PriceBc);
            record.BlkPriceBc = this.MapParameterOut(command, "@PA_SXREF_BLK_PRICE_BC", record.BlkPriceBc);
            record.Vatcd = this.MapParameterOut(command, "@PA_SXREF_VATCD", record.Vatcd);
            record.RevCode = this.MapParameterOut(command, "@PA_SXREF_REV_CODE", record.RevCode);
            record.CostCode = this.MapParameterOut(command, "@PA_SXREF_COST_CODE", record.CostCode);
            record.DoNotInv = this.MapParameterOut(command, "@PA_SXREF_DO_NOT_INV", record.DoNotInv);
            record.ShowSales = this.MapParameterOut(command, "@PA_SXREF_SHOW_SALES", record.ShowSales);
            record.NoInSet = this.MapParameterOut(command, "@PA_SXREF_NO_IN_SET", record.NoInSet);
            record.RetailPrice = this.MapParameterOut(command, "@PA_SXREF_RETAIL_PRICE", record.RetailPrice);
            record.CostPrice = this.MapParameterOut(command, "@PA_SXREF_COST_PRICE", record.CostPrice);
            record.RetPriceBc = this.MapParameterOut(command, "@PA_SXREF_RET_PRICE_BC", record.RetPriceBc);
            record.CstPriceBc = this.MapParameterOut(command, "@PA_SXREF_CST_PRICE_BC", record.CstPriceBc);
            record.RetPricBc2 = this.MapParameterOut(command, "@PA_SXREF_RET_PRIC_BC2", record.RetPricBc2);
            record.CstPricBc2 = this.MapParameterOut(command, "@PA_SXREF_CST_PRIC_BC2", record.CstPricBc2);
            record.PriceA = this.MapParameterOut(command, "@PA_SXREF_PRICE_A", record.PriceA);
            record.PriceB = this.MapParameterOut(command, "@PA_SXREF_PRICE_B", record.PriceB);
            record.PriceC = this.MapParameterOut(command, "@PA_SXREF_PRICE_C", record.PriceC);
            record.PriceD = this.MapParameterOut(command, "@PA_SXREF_PRICE_D", record.PriceD);
            record.PriceE = this.MapParameterOut(command, "@PA_SXREF_PRICE_E", record.PriceE);
            record.Default = this.MapParameterOut(command, "@PA_SXREF_DEFAULT", record.Default);
            record.PlId = this.MapParameterOut(command, "@PA_SXREF_PL_ID", record.PlId);
            record.Ticket = this.MapParameterOut(command, "@PA_SXREF_TICKET", record.Ticket);
            record.GroupQty = this.MapParameterOut(command, "@PA_SXREF_GROUP_QTY", record.GroupQty);
            record.GroupDte = this.MapParameterOut(command, "@PA_SXREF_GROUP_DTE", record.GroupDte);
            record.GroupQtyId = this.MapParameterOut(command, "@PA_SXREF_GROUP_QTY_ID", record.GroupQtyId);
            record.GroupDteId = this.MapParameterOut(command, "@PA_SXREF_GROUP_DTE_ID", record.GroupDteId);
            record.QtyMin = this.MapParameterOut(command, "@PA_SXREF_QTY_MIN", record.QtyMin);
            record.QtyMax = this.MapParameterOut(command, "@PA_SXREF_QTY_MAX", record.QtyMax);
            record.ValidFrom = this.MapParameterOut(command, "@PA_SXREF_VALID_FROM", record.ValidFrom);
            record.ValidUntil = this.MapParameterOut(command, "@PA_SXREF_VALID_UNTIL", record.ValidUntil);
            record.BeforeDays = this.MapParameterOut(command, "@PA_SXREF_BEFORE_DAYS", record.BeforeDays);
            record.Chargeable = this.MapParameterOut(command, "@PA_SXREF_CHARGEABLE", record.Chargeable);
            record.MainSession = this.MapParameterOut(command, "@PA_SXREF_MAIN_SESSION", record.MainSession);
            record.EttId = this.MapParameterOut(command, "@PA_SXREF_ETT_ID", record.EttId);
            record.GrpSgId = this.MapParameterOut(command, "@PA_SXREF_GRP_SG_ID", record.GrpSgId);
            record.StrmSgId = this.MapParameterOut(command, "@PA_SXREF_STRM_SG_ID", record.StrmSgId);
            record.GridStart = this.MapParameterOut(command, "@PA_SXREF_GRID_START", record.GridStart);
            record.GridEnd = this.MapParameterOut(command, "@PA_SXREF_GRID_END", record.GridEnd);
            record.SessPnts = this.MapParameterOut(command, "@PA_SXREF_SESS_PNTS", record.SessPnts);
            record.MastSess = this.MapParameterOut(command, "@PA_SXREF_MAST_SESS", record.MastSess);
            record.Selected = this.MapParameterOut(command, "@PA_SXREF_SELECTED", record.Selected);
            record.CountDel = this.MapParameterOut(command, "@PA_SXREF_COUNT_DEL", record.CountDel);
            record.PayPnts = this.MapParameterOut(command, "@PA_SXREF_PAY_PNTS", record.PayPnts);
            record.Code = this.MapParameterOut(command, "@PA_SXREF_CODE", record.Code);
            record.ActxrefId = this.MapParameterOut(command, "@PA_SXREF_ACTXREF_ID", record.ActxrefId);
            record.ProdId = this.MapParameterOut(command, "@PA_SXREF_PROD_ID", record.ProdId);
            record.PlName = this.MapParameterOut(command, "@PA_SXREF_PL_NAME", record.PlName);
            record.PrsId = this.MapParameterOut(command, "@PA_SXREF_PRS_ID", record.PrsId);
            record.Member = this.MapParameterOut(command, "@PA_SXREF_MEMBER", record.Member);
            record.StartDay = this.MapParameterOut(command, "@PA_SXREF_START_DAY", record.StartDay);
            record.EndDay = this.MapParameterOut(command, "@PA_SXREF_END_DAY", record.EndDay);
            record.LstPrice = this.MapParameterOut(command, "@PA_SXREF_LST_PRICE", record.LstPrice);
            record.Student = this.MapParameterOut(command, "@PA_SXREF_STUDENT", record.Student);
            record.BomId = this.MapParameterOut(command, "@PA_SXREF_BOM_ID", record.BomId);
            record.EpId = this.MapParameterOut(command, "@PA_SXREF_EP_ID", record.EpId);
            record.ValidDate = this.MapParameterOut(command, "@PA_SXREF_VALID_DATE", record.ValidDate);
            record.Region = this.MapParameterOut(command, "@PA_SXREF_REGION", record.Region);
            record.CsgId = this.MapParameterOut(command, "@PA_SXREF_CSG_ID", record.CsgId);
            record.Id = this.MapParameterOut(command, "@PA_RETURN_ID", record.Id);
        }

        /// <summary>
        ///     Retrieves a collection of <see cref="SessionXrefRecord" /> instances from the data store.
        /// </summary>
        /// <param name="courseId">
        ///     The value which identifies the <see cref='SessionXrefModel' /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The collection of <see cref="SessionXrefRecord" /> instances that match the specified <paramref name='courseId' />.
        /// </returns>
        public IEnumerable<SessionXrefRecord> FetchAllByCourseId(String courseId)
        {
            DbCommand command = this.GetStoredProcedure(SqlServerOperation.FetchAll, "CourseId");
            this.MapParameterIn(command, "@PA_SXREF_COURSE_ID", courseId);
            return this.Execute(command);
        }

        /// <summary>
        ///     Retrieves a collection of <see cref="SessionXrefRecord" /> instances from the data store.
        /// </summary>
        /// <param name="actId">
        ///     The value which identifies the <see cref='SessionXrefModel' /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The collection of <see cref="SessionXrefRecord" /> instances that match the specified <paramref name='actId' />.
        /// </returns>
        public IEnumerable<SessionXrefRecord> FetchAllByActId(String actId)
        {
            DbCommand command = this.GetStoredProcedure(SqlServerOperation.FetchAll, "ActId");
            this.MapParameterIn(command, "@PA_SXREF_ACT_ID", actId);
            return this.Execute(command);
        }

        /// <summary>
        ///     Retrieves a collection of <see cref="SessionXrefRecord" /> instances from the data store.
        /// </summary>
        /// <param name="epId">
        ///     The value which identifies the <see cref='SessionXrefModel' /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The collection of <see cref="SessionXrefRecord" /> instances that match the specified <paramref name='epId' />.
        /// </returns>
        public IEnumerable<SessionXrefRecord> FetchAllByEpId(Int32? epId)
        {
            DbCommand command = this.GetStoredProcedure(SqlServerOperation.FetchAll, "EpId");
            this.MapParameterIn(command, "@PA_SXREF_EP_ID", epId);
            return this.Execute(command);
        }

        #endregion

        #region implementations

        /// <summary>
        ///     Gets the underlying table name that this repository sit over.
        /// </summary>
        System.String ISessionXrefRepository.TableName
        {
            get { return this.TableName; }
        }

        /// <summary>
        ///     Retrieves a collection of <see cref="T:Consensus.Learning.SessionXrefRecord" /> instances from the data store.
        /// </summary>
        /// <param name="courseId">
        ///     The value which identifies the <see cref="!:SessionXrefModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The collection of <see cref="T:Consensus.Learning.SessionXrefRecord" /> instances that match the specified <paramref name="courseId" />.
        /// </returns>
        System.Collections.Generic.IEnumerable<Consensus.Learning.SessionXrefRecord> ISessionXrefRepository.FetchAllByCourseId(System.String courseId)
        {
            return this.FetchAllByCourseId(courseId);
        }

        /// <summary>
        ///     Retrieves a collection of <see cref="T:Consensus.Learning.SessionXrefRecord" /> instances from the data store.
        /// </summary>
        /// <param name="actId">
        ///     The value which identifies the <see cref="!:SessionXrefModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The collection of <see cref="T:Consensus.Learning.SessionXrefRecord" /> instances that match the specified <paramref name="actId" />.
        /// </returns>
        System.Collections.Generic.IEnumerable<Consensus.Learning.SessionXrefRecord> ISessionXrefRepository.FetchAllByActId(System.String actId)
        {
            return this.FetchAllByActId(actId);
        }

        System.Collections.Generic.IEnumerable<Consensus.Learning.SessionXrefRecord> ISessionXrefRepository.FetchAllByEpId(System.Nullable<System.Int32> epId)
        {
            return this.FetchAllByEpId(epId);
        }

        #endregion
    }
}
