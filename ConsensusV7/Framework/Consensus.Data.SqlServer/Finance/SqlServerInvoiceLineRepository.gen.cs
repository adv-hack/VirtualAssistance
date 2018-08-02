using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Linq;

namespace Consensus.Finance
{
    /// <summary>
    ///     Provides the persistence and retrieval of the <see cref="InvlineRecord" /> instances in a Microsoft SQL Server database.
    /// </summary>
    /// <remarks>
    ///     THIS CODE HAS BEEN AUTOMATICALLY GENERATED USING THE CONSENSUS DEVELOPER TOOLS.
    ///     DO NOT EDIT THIS CODE AS ANY CUSTOM MODIFICATIONS WILL BE LOST UPON REGENERATION.
    /// </remarks>
    public partial class SqlServerInvoiceLineRepository : SqlServerRepository<InvlineRecord, String>, IInvoiceLineRepository
    {
        #region properties

        /// <summary>
        ///     Gets the namespace in which the data type is contained.
        /// </summary>
        protected override String TypeNamespace
        {
            get { return "Finance"; }
        }

        /// <summary>
        ///     Gets the name of the data type which is persisted by this repository.
        /// </summary>
        protected override String TypeName
        {
            get { return "Invline"; }
        }

        /// <summary>
        ///     Gets the name of the parameter which is used to specify the unique value that identifies each instance of a <see cref="InvlineRecord" />.
        /// </summary>
        protected override String TypeKeyName
        {
            get { return "@PA_INVLN_ID"; }
        }

        /// <summary>
        ///     Gets the underlying table name that this repository sit over.
        /// </summary>
        public override String TableName
        {
            get { return "InvLine"; }
        }

        #endregion

        #region methods

        /// <summary>
        ///     Maps an <see cref="IDataRecord" /> to the specified <see cref="InvlineRecord" />.
        /// </summary>
        /// <param name="dataRecord">
        ///     The <see cref="IDataRecord" /> to be mapped.
        /// </param>
        /// <param name="record">
        ///     The <see cref="InvlineRecord" /> instance to be mapped to.
        /// </param>
        protected override void MapRecord(IDataRecord dataRecord, InvlineRecord record)
        {
            record.Id = dataRecord["INVLN_ID"].ConvertTo<String>();
            record.AddDate = dataRecord["INVLN_ADD_DATE"].ConvertTo<DateTime?>();
            record.AddBy = dataRecord["INVLN_ADD_BY"].ConvertTo<String>();
            record.ModDate = dataRecord["INVLN_MOD_DATE"].ConvertTo<DateTime?>();
            record.ModBy = dataRecord["INVLN_MOD_BY"].ConvertTo<String>();
            record.RcvDate = dataRecord["INVLN_RCV_DATE"].ConvertTo<DateTime?>();
            record.RcvFrom = dataRecord["INVLN_RCV_FROM"].ConvertTo<String>();
            record.InvId = dataRecord["INVLN_INV_ID"].ConvertTo<String>();
            record.ProductId = dataRecord["INVLN_PRODUCT_ID"].ConvertTo<String>();
            record.OrderLnId = dataRecord["INVLN_ORDER_LN_ID"].ConvertTo<String>();
            record.LineNo = dataRecord["INVLN_LINE_NO"].ConvertTo<Double?>();
            record.Qty = dataRecord["INVLN_QTY"].ConvertTo<Double?>();
            record.UnitPrice = dataRecord["INVLN_UNIT_PRICE"].ConvertTo<Decimal>();
            record.Discount = dataRecord["INVLN_DISCOUNT"].ConvertTo<Decimal>();
            record.DisctPrice = dataRecord["INVLN_DISCT_PRICE"].ConvertTo<Decimal>();
            record.Net = dataRecord["INVLN_NET"].ConvertTo<Decimal>();
            record.VatCode = dataRecord["INVLN_VAT_CODE"].ConvertTo<String>();
            record.VatRate = dataRecord["INVLN_VAT_RATE"].ConvertTo<Decimal>();
            record.VatAmt = dataRecord["INVLN_VAT_AMT"].ConvertTo<Decimal>();
            record.TotalPrice = dataRecord["INVLN_TOTAL_PRICE"].ConvertTo<Decimal>();
            record.CreditDesc = dataRecord["INVLN_CREDIT_DESC"].ConvertTo<String>();
            record.UnitPrceBc = dataRecord["INVLN_UNIT_PRCE_BC"].ConvertTo<Decimal>();
            record.DiscountBc = dataRecord["INVLN_DISCOUNT_BC"].ConvertTo<Decimal>();
            record.DiscPrceBc = dataRecord["INVLN_DISC_PRCE_BC"].ConvertTo<Decimal>();
            record.NetBc = dataRecord["INVLN_NET_BC"].ConvertTo<Decimal>();
            record.TotPriceBc = dataRecord["INVLN_TOT_PRICE_BC"].ConvertTo<Decimal>();
            record.CurrType = dataRecord["INVLN_CURR_TYPE"].ConvertTo<String>();
            record.Description = dataRecord["INVLN_DESCRIPTION"].ConvertTo<String>();
            record.SalesId = dataRecord["INVLN_SALES_ID"].ConvertTo<String>();
            record.SalesDetId = dataRecord["INVLN_SALES_DET_ID"].ConvertTo<String>();
            record.BookId = dataRecord["INVLN_BOOK_ID"].ConvertTo<String>();
            record.ElemId = dataRecord["INVLN_ELEM_ID"].ConvertTo<String>();
            record.CourseId = dataRecord["INVLN_COURSE_ID"].ConvertTo<String>();
            record.Type = dataRecord["INVLN_TYPE"].ConvertTo<Byte?>();
            record.ProdName = dataRecord["INVLN_PROD_NAME"].ConvertTo<String>();
            record.PrdRevCode = dataRecord["INVLN_PRD_REV_CODE"].ConvertTo<String>();
            record.ProjId = dataRecord["INVLN_PROJ_ID"].ConvertTo<String>();
            record.MelId = dataRecord["INVLN_MEL_ID"].ConvertTo<String>();
            record.UntPrceBc2 = dataRecord["INVLN_UNT_PRCE_BC2"].ConvertTo<Decimal>();
            record.NetBc2 = dataRecord["INVLN_NET_BC2"].ConvertTo<Decimal>();
            record.TotPrceBc2 = dataRecord["INVLN_TOT_PRCE_BC2"].ConvertTo<Decimal>();
            record.VatAmtBc = dataRecord["INVLN_VAT_AMT_BC"].ConvertTo<Decimal>();
            record.VatAmtBc2 = dataRecord["INVLN_VAT_AMT_BC2"].ConvertTo<Decimal>();
            record.CostCode = dataRecord["INVLN_COST_CODE"].ConvertTo<String>();
            record.Credited = dataRecord["INVLN_CREDITED"].ConvertTo<Byte?>();
            record.Userchar1 = dataRecord["INVLN_USERCHAR_1"].ConvertTo<String>();
            record.Anl1 = dataRecord["INVLN_ANL1"].ConvertTo<String>();
            record.Anl2 = dataRecord["INVLN_ANL2"].ConvertTo<String>();
            record.Anl3 = dataRecord["INVLN_ANL3"].ConvertTo<String>();
            record.DiscountBc2 = dataRecord["INVLN_DISCOUNT_BC2"].ConvertTo<Decimal>();
            record.DiscPriceBc2 = dataRecord["INVLN_DISC_PRICE_BC2"].ConvertTo<Decimal>();
            record.CreditForInvlnId = dataRecord["INVLN_CREDIT_FOR_INVLN_ID"].ConvertTo<String>();
            record.DoNotPrint = dataRecord["INVLN_DO_NOT_PRINT"].ConvertTo<Byte>();
            record.DelCostCode = dataRecord["INVLN_DEL_COST_CODE"].ConvertTo<String>();
            record.SelcoSpId = dataRecord["INVLN_SELCO_SP_ID"].ConvertTo<String>();
            record.CurrencyType = dataRecord["INVLN_CURRENCY_TYPE"].ConvertTo<String>();
            record.CurrRateBc = dataRecord["INVLN_CURR_RATE_BC"].ConvertTo<Decimal?>();
            record.CurrRateBc2 = dataRecord["INVLN_CURR_RATE_BC2"].ConvertTo<Decimal?>();
            record.UnitPriceDisc = dataRecord["INVLN_UNIT_PRICE_DISC"].ConvertTo<Decimal?>();
            record.UnitPriceDiscBc = dataRecord["INVLN_UNIT_PRICE_DISC_BC"].ConvertTo<Decimal?>();
            record.UnitPriceDiscBc2 = dataRecord["INVLN_UNIT_PRICE_DISC_BC2"].ConvertTo<Decimal?>();
            record.Dept = dataRecord["INVLN_DEPT"].ConvertTo<String>();
            record.Sku = dataRecord["INVLN_SKU"].ConvertTo<String>();
            record.JobCode = dataRecord["INVLN_JOB_CODE"].ConvertTo<String>();
            record.JobAnalCode = dataRecord["INVLN_JOB_ANAL_CODE"].ConvertTo<String>();
            record.JobType = dataRecord["INVLN_JOB_TYPE"].ConvertTo<String>();
            record.JobParent = dataRecord["INVLN_JOB_PARENT"].ConvertTo<String>();
            record.PrsType = dataRecord["INVLN_PRS_TYPE"].ConvertTo<Byte>();
        }

        /// <summary>
        ///     Sets the parameter values for the specified <paramref name="command" /> based on the specified <typeparamref name="TRecord" /> instance.
        /// </summary>
        /// <param name="command">
        ///     The <see cref="IDbCommand" /> containing the parameters to be mapped.
        /// </param>
        /// <param name="record">
        ///     The <see cref="InvlineRecord" /> instance to be mapped.
        /// </param>
        /// <param name="useV6Logic">
        ///     Is the procedure being run an old version 6.x procedure? (the null value handling logic is different).
        /// </param>
        protected override void MapParametersIn(IDbCommand command, InvlineRecord record, bool useV6Logic)
        {
            this.MapParameterIn(command, "@PA_INVLN_ID", record.Id);
            this.MapParameterIn(command, "@PA_INVLN_INV_ID", record.InvId);
            this.MapParameterIn(command, "@PA_INVLN_PRODUCT_ID", record.ProductId);
            this.MapParameterIn(command, "@PA_INVLN_ORDER_LN_ID", record.OrderLnId);
            this.MapParameterIn(command, "@PA_INVLN_LINE_NO", record.LineNo == Double.MinValue ? ( useV6Logic ? new Double?(0) : null ) : record.LineNo);
            this.MapParameterIn(command, "@PA_INVLN_QTY", record.Qty == Double.MinValue ? ( useV6Logic ? new Double?(0) : null ) : record.Qty);
            this.MapParameterIn(command, "@PA_INVLN_UNIT_PRICE", record.UnitPrice == Decimal.MinValue ? 0M : record.UnitPrice);
            this.MapParameterIn(command, "@PA_INVLN_DISCOUNT", record.Discount == Decimal.MinValue ? 0M : record.Discount);
            this.MapParameterIn(command, "@PA_INVLN_DISCT_PRICE", record.DisctPrice == Decimal.MinValue ? 0M : record.DisctPrice);
            this.MapParameterIn(command, "@PA_INVLN_NET", record.Net == Decimal.MinValue ? 0M : record.Net);
            this.MapParameterIn(command, "@PA_INVLN_VAT_CODE", record.VatCode);
            this.MapParameterIn(command, "@PA_INVLN_VAT_RATE", record.VatRate == Decimal.MinValue ? 0M : record.VatRate);
            this.MapParameterIn(command, "@PA_INVLN_VAT_AMT", record.VatAmt == Decimal.MinValue ? 0M : record.VatAmt);
            this.MapParameterIn(command, "@PA_INVLN_TOTAL_PRICE", record.TotalPrice == Decimal.MinValue ? 0M : record.TotalPrice);
            this.MapParameterIn(command, "@PA_INVLN_CREDIT_DESC", record.CreditDesc);
            this.MapParameterIn(command, "@PA_INVLN_UNIT_PRCE_BC", record.UnitPrceBc == Decimal.MinValue ? 0M : record.UnitPrceBc);
            this.MapParameterIn(command, "@PA_INVLN_DISCOUNT_BC", record.DiscountBc == Decimal.MinValue ? 0M : record.DiscountBc);
            this.MapParameterIn(command, "@PA_INVLN_DISC_PRCE_BC", record.DiscPrceBc == Decimal.MinValue ? 0M : record.DiscPrceBc);
            this.MapParameterIn(command, "@PA_INVLN_NET_BC", record.NetBc == Decimal.MinValue ? 0M : record.NetBc);
            this.MapParameterIn(command, "@PA_INVLN_TOT_PRICE_BC", record.TotPriceBc == Decimal.MinValue ? 0M : record.TotPriceBc);
            this.MapParameterIn(command, "@PA_INVLN_CURR_TYPE", record.CurrType);
            this.MapParameterIn(command, "@PA_INVLN_DESCRIPTION", record.Description);
            this.MapParameterIn(command, "@PA_INVLN_SALES_ID", record.SalesId);
            this.MapParameterIn(command, "@PA_INVLN_SALES_DET_ID", record.SalesDetId);
            this.MapParameterIn(command, "@PA_INVLN_BOOK_ID", record.BookId);
            this.MapParameterIn(command, "@PA_INVLN_ELEM_ID", record.ElemId);
            this.MapParameterIn(command, "@PA_INVLN_COURSE_ID", record.CourseId);
            this.MapParameterIn(command, "@PA_INVLN_TYPE", record.Type);
            this.MapParameterIn(command, "@PA_INVLN_PROD_NAME", record.ProdName);
            this.MapParameterIn(command, "@PA_INVLN_PRD_REV_CODE", record.PrdRevCode);
            this.MapParameterIn(command, "@PA_INVLN_PROJ_ID", record.ProjId);
            this.MapParameterIn(command, "@PA_INVLN_MEL_ID", record.MelId);
            this.MapParameterIn(command, "@PA_INVLN_UNT_PRCE_BC2", record.UntPrceBc2 == Decimal.MinValue ? 0M : record.UntPrceBc2);
            this.MapParameterIn(command, "@PA_INVLN_NET_BC2", record.NetBc2 == Decimal.MinValue ? 0M : record.NetBc2);
            this.MapParameterIn(command, "@PA_INVLN_TOT_PRCE_BC2", record.TotPrceBc2 == Decimal.MinValue ? 0M : record.TotPrceBc2);
            this.MapParameterIn(command, "@PA_INVLN_VAT_AMT_BC", record.VatAmtBc == Decimal.MinValue ? 0M : record.VatAmtBc);
            this.MapParameterIn(command, "@PA_INVLN_VAT_AMT_BC2", record.VatAmtBc2 == Decimal.MinValue ? 0M : record.VatAmtBc2);
            this.MapParameterIn(command, "@PA_INVLN_COST_CODE", record.CostCode);
            this.MapParameterIn(command, "@PA_INVLN_CREDITED", record.Credited);
            this.MapParameterIn(command, "@PA_INVLN_USERCHAR_1", record.Userchar1);
            this.MapParameterIn(command, "@PA_INVLN_ANL1", record.Anl1);
            this.MapParameterIn(command, "@PA_INVLN_ANL2", record.Anl2);
            this.MapParameterIn(command, "@PA_INVLN_ANL3", record.Anl3);
            this.MapParameterIn(command, "@PA_INVLN_DISCOUNT_BC2", record.DiscountBc2 == Decimal.MinValue ? 0M : record.DiscountBc2);
            this.MapParameterIn(command, "@PA_INVLN_DISC_PRICE_BC2", record.DiscPriceBc2 == Decimal.MinValue ? 0M : record.DiscPriceBc2);
            this.MapParameterIn(command, "@PA_INVLN_CREDIT_FOR_INVLN_ID", record.CreditForInvlnId);
            this.MapParameterIn(command, "@PA_INVLN_DO_NOT_PRINT", record.DoNotPrint);
            this.MapParameterIn(command, "@PA_INVLN_DEL_COST_CODE", record.DelCostCode);
            this.MapParameterIn(command, "@PA_INVLN_SELCO_SP_ID", record.SelcoSpId);
            this.MapParameterIn(command, "@PA_INVLN_CURRENCY_TYPE", record.CurrencyType);
            this.MapParameterIn(command, "@PA_INVLN_CURR_RATE_BC", record.CurrRateBc == Decimal.MinValue ? ( useV6Logic ? new Decimal?(0M) : null ) : record.CurrRateBc);
            this.MapParameterIn(command, "@PA_INVLN_CURR_RATE_BC2", record.CurrRateBc2 == Decimal.MinValue ? ( useV6Logic ? new Decimal?(0M) : null ) : record.CurrRateBc2);
            this.MapParameterIn(command, "@PA_INVLN_UNIT_PRICE_DISC", record.UnitPriceDisc == Decimal.MinValue ? ( useV6Logic ? new Decimal?(0M) : null ) : record.UnitPriceDisc);
            this.MapParameterIn(command, "@PA_INVLN_UNIT_PRICE_DISC_BC", record.UnitPriceDiscBc == Decimal.MinValue ? ( useV6Logic ? new Decimal?(0M) : null ) : record.UnitPriceDiscBc);
            this.MapParameterIn(command, "@PA_INVLN_UNIT_PRICE_DISC_BC2", record.UnitPriceDiscBc2 == Decimal.MinValue ? ( useV6Logic ? new Decimal?(0M) : null ) : record.UnitPriceDiscBc2);
            this.MapParameterIn(command, "@PA_INVLN_DEPT", record.Dept);
            this.MapParameterIn(command, "@PA_INVLN_SKU", record.Sku);
            this.MapParameterIn(command, "@PA_INVLN_JOB_CODE", record.JobCode);
            this.MapParameterIn(command, "@PA_INVLN_JOB_ANAL_CODE", record.JobAnalCode);
            this.MapParameterIn(command, "@PA_INVLN_JOB_TYPE", record.JobType);
            this.MapParameterIn(command, "@PA_INVLN_JOB_PARENT", record.JobParent);
            this.MapParameterIn(command, "@PA_INVLN_PRS_TYPE", record.PrsType);
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
        ///     The <see cref="InvlineRecord" /> instance to be updated.
        /// </param>
        protected override void MapParametersOut(IDbCommand command, InvlineRecord record)
        {
            record.Id = this.MapParameterOut(command, "@PA_INVLN_ID", record.Id);
            record.InvId = this.MapParameterOut(command, "@PA_INVLN_INV_ID", record.InvId);
            record.ProductId = this.MapParameterOut(command, "@PA_INVLN_PRODUCT_ID", record.ProductId);
            record.OrderLnId = this.MapParameterOut(command, "@PA_INVLN_ORDER_LN_ID", record.OrderLnId);
            record.LineNo = this.MapParameterOut(command, "@PA_INVLN_LINE_NO", record.LineNo);
            record.Qty = this.MapParameterOut(command, "@PA_INVLN_QTY", record.Qty);
            record.UnitPrice = this.MapParameterOut(command, "@PA_INVLN_UNIT_PRICE", record.UnitPrice);
            record.Discount = this.MapParameterOut(command, "@PA_INVLN_DISCOUNT", record.Discount);
            record.DisctPrice = this.MapParameterOut(command, "@PA_INVLN_DISCT_PRICE", record.DisctPrice);
            record.Net = this.MapParameterOut(command, "@PA_INVLN_NET", record.Net);
            record.VatCode = this.MapParameterOut(command, "@PA_INVLN_VAT_CODE", record.VatCode);
            record.VatRate = this.MapParameterOut(command, "@PA_INVLN_VAT_RATE", record.VatRate);
            record.VatAmt = this.MapParameterOut(command, "@PA_INVLN_VAT_AMT", record.VatAmt);
            record.TotalPrice = this.MapParameterOut(command, "@PA_INVLN_TOTAL_PRICE", record.TotalPrice);
            record.CreditDesc = this.MapParameterOut(command, "@PA_INVLN_CREDIT_DESC", record.CreditDesc);
            record.UnitPrceBc = this.MapParameterOut(command, "@PA_INVLN_UNIT_PRCE_BC", record.UnitPrceBc);
            record.DiscountBc = this.MapParameterOut(command, "@PA_INVLN_DISCOUNT_BC", record.DiscountBc);
            record.DiscPrceBc = this.MapParameterOut(command, "@PA_INVLN_DISC_PRCE_BC", record.DiscPrceBc);
            record.NetBc = this.MapParameterOut(command, "@PA_INVLN_NET_BC", record.NetBc);
            record.TotPriceBc = this.MapParameterOut(command, "@PA_INVLN_TOT_PRICE_BC", record.TotPriceBc);
            record.CurrType = this.MapParameterOut(command, "@PA_INVLN_CURR_TYPE", record.CurrType);
            record.Description = this.MapParameterOut(command, "@PA_INVLN_DESCRIPTION", record.Description);
            record.SalesId = this.MapParameterOut(command, "@PA_INVLN_SALES_ID", record.SalesId);
            record.SalesDetId = this.MapParameterOut(command, "@PA_INVLN_SALES_DET_ID", record.SalesDetId);
            record.BookId = this.MapParameterOut(command, "@PA_INVLN_BOOK_ID", record.BookId);
            record.ElemId = this.MapParameterOut(command, "@PA_INVLN_ELEM_ID", record.ElemId);
            record.CourseId = this.MapParameterOut(command, "@PA_INVLN_COURSE_ID", record.CourseId);
            record.Type = this.MapParameterOut(command, "@PA_INVLN_TYPE", record.Type);
            record.ProdName = this.MapParameterOut(command, "@PA_INVLN_PROD_NAME", record.ProdName);
            record.PrdRevCode = this.MapParameterOut(command, "@PA_INVLN_PRD_REV_CODE", record.PrdRevCode);
            record.ProjId = this.MapParameterOut(command, "@PA_INVLN_PROJ_ID", record.ProjId);
            record.MelId = this.MapParameterOut(command, "@PA_INVLN_MEL_ID", record.MelId);
            record.UntPrceBc2 = this.MapParameterOut(command, "@PA_INVLN_UNT_PRCE_BC2", record.UntPrceBc2);
            record.NetBc2 = this.MapParameterOut(command, "@PA_INVLN_NET_BC2", record.NetBc2);
            record.TotPrceBc2 = this.MapParameterOut(command, "@PA_INVLN_TOT_PRCE_BC2", record.TotPrceBc2);
            record.VatAmtBc = this.MapParameterOut(command, "@PA_INVLN_VAT_AMT_BC", record.VatAmtBc);
            record.VatAmtBc2 = this.MapParameterOut(command, "@PA_INVLN_VAT_AMT_BC2", record.VatAmtBc2);
            record.CostCode = this.MapParameterOut(command, "@PA_INVLN_COST_CODE", record.CostCode);
            record.Credited = this.MapParameterOut(command, "@PA_INVLN_CREDITED", record.Credited);
            record.Userchar1 = this.MapParameterOut(command, "@PA_INVLN_USERCHAR_1", record.Userchar1);
            record.Anl1 = this.MapParameterOut(command, "@PA_INVLN_ANL1", record.Anl1);
            record.Anl2 = this.MapParameterOut(command, "@PA_INVLN_ANL2", record.Anl2);
            record.Anl3 = this.MapParameterOut(command, "@PA_INVLN_ANL3", record.Anl3);
            record.DiscountBc2 = this.MapParameterOut(command, "@PA_INVLN_DISCOUNT_BC2", record.DiscountBc2);
            record.DiscPriceBc2 = this.MapParameterOut(command, "@PA_INVLN_DISC_PRICE_BC2", record.DiscPriceBc2);
            record.CreditForInvlnId = this.MapParameterOut(command, "@PA_INVLN_CREDIT_FOR_INVLN_ID", record.CreditForInvlnId);
            record.DoNotPrint = this.MapParameterOut(command, "@PA_INVLN_DO_NOT_PRINT", record.DoNotPrint);
            record.DelCostCode = this.MapParameterOut(command, "@PA_INVLN_DEL_COST_CODE", record.DelCostCode);
            record.SelcoSpId = this.MapParameterOut(command, "@PA_INVLN_SELCO_SP_ID", record.SelcoSpId);
            record.CurrencyType = this.MapParameterOut(command, "@PA_INVLN_CURRENCY_TYPE", record.CurrencyType);
            record.CurrRateBc = this.MapParameterOut(command, "@PA_INVLN_CURR_RATE_BC", record.CurrRateBc);
            record.CurrRateBc2 = this.MapParameterOut(command, "@PA_INVLN_CURR_RATE_BC2", record.CurrRateBc2);
            record.UnitPriceDisc = this.MapParameterOut(command, "@PA_INVLN_UNIT_PRICE_DISC", record.UnitPriceDisc);
            record.UnitPriceDiscBc = this.MapParameterOut(command, "@PA_INVLN_UNIT_PRICE_DISC_BC", record.UnitPriceDiscBc);
            record.UnitPriceDiscBc2 = this.MapParameterOut(command, "@PA_INVLN_UNIT_PRICE_DISC_BC2", record.UnitPriceDiscBc2);
            record.Dept = this.MapParameterOut(command, "@PA_INVLN_DEPT", record.Dept);
            record.Sku = this.MapParameterOut(command, "@PA_INVLN_SKU", record.Sku);
            record.JobCode = this.MapParameterOut(command, "@PA_INVLN_JOB_CODE", record.JobCode);
            record.JobAnalCode = this.MapParameterOut(command, "@PA_INVLN_JOB_ANAL_CODE", record.JobAnalCode);
            record.JobType = this.MapParameterOut(command, "@PA_INVLN_JOB_TYPE", record.JobType);
            record.JobParent = this.MapParameterOut(command, "@PA_INVLN_JOB_PARENT", record.JobParent);
            record.PrsType = this.MapParameterOut(command, "@PA_INVLN_PRS_TYPE", record.PrsType);
            record.Id = this.MapParameterOut(command, "@PA_RETURN_ID", record.Id);
        }

        /// <summary>
        ///     Retrieves a collection of <see cref="InvlineRecord" /> instances from the data store.
        /// </summary>
        /// <param name="invId">
        ///     The value which identifies the <see cref='InvoiceLineModel' /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The collection of <see cref="InvlineRecord" /> instances that match the specified <paramref name='invId' />.
        /// </returns>
        public IEnumerable<InvlineRecord> FetchAllByInvId(String invId)
        {
            DbCommand command = this.GetStoredProcedure(SqlServerOperation.FetchAll, "InvId");
            this.MapParameterIn(command, "@PA_INVLN_INV_ID", invId);
            return this.Execute(command);
        }

        /// <summary>
        ///     Retrieves a collection of <see cref="InvlineRecord" /> instances from the data store.
        /// </summary>
        /// <param name="productId">
        ///     The value which identifies the <see cref='InvoiceLineModel' /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The collection of <see cref="InvlineRecord" /> instances that match the specified <paramref name='productId' />.
        /// </returns>
        public IEnumerable<InvlineRecord> FetchAllByProductId(String productId)
        {
            DbCommand command = this.GetStoredProcedure(SqlServerOperation.FetchAll, "ProductId");
            this.MapParameterIn(command, "@PA_INVLN_PRODUCT_ID", productId);
            return this.Execute(command);
        }

        /// <summary>
        ///     Retrieves a collection of <see cref="InvlineRecord" /> instances from the data store.
        /// </summary>
        /// <param name="bookId">
        ///     The value which identifies the <see cref='InvoiceLineModel' /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The collection of <see cref="InvlineRecord" /> instances that match the specified <paramref name='bookId' />.
        /// </returns>
        public IEnumerable<InvlineRecord> FetchAllByBookId(String bookId)
        {
            DbCommand command = this.GetStoredProcedure(SqlServerOperation.FetchAll, "BookId");
            this.MapParameterIn(command, "@PA_INVLN_BOOK_ID", bookId);
            return this.Execute(command);
        }

        /// <summary>
        ///     Retrieves a collection of <see cref="InvlineRecord" /> instances from the data store.
        /// </summary>
        /// <param name="elemId">
        ///     The value which identifies the <see cref='InvoiceLineModel' /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The collection of <see cref="InvlineRecord" /> instances that match the specified <paramref name='elemId' />.
        /// </returns>
        public IEnumerable<InvlineRecord> FetchAllByElemId(String elemId)
        {
            DbCommand command = this.GetStoredProcedure(SqlServerOperation.FetchAll, "ElemId");
            this.MapParameterIn(command, "@PA_INVLN_ELEM_ID", elemId);
            return this.Execute(command);
        }

        /// <summary>
        ///     Retrieves a collection of <see cref="InvlineRecord" /> instances from the data store.
        /// </summary>
        /// <param name="courseId">
        ///     The value which identifies the <see cref='InvoiceLineModel' /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The collection of <see cref="InvlineRecord" /> instances that match the specified <paramref name='courseId' />.
        /// </returns>
        public IEnumerable<InvlineRecord> FetchAllByCourseId(String courseId)
        {
            DbCommand command = this.GetStoredProcedure(SqlServerOperation.FetchAll, "CourseId");
            this.MapParameterIn(command, "@PA_INVLN_COURSE_ID", courseId);
            return this.Execute(command);
        }

        /// <summary>
        ///     Retrieves a collection of <see cref="InvlineRecord" /> instances from the data store.
        /// </summary>
        /// <param name="melId">
        ///     The value which identifies the <see cref='InvoiceLineModel' /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The collection of <see cref="InvlineRecord" /> instances that match the specified <paramref name='melId' />.
        /// </returns>
        public IEnumerable<InvlineRecord> FetchAllByMelId(String melId)
        {
            DbCommand command = this.GetStoredProcedure(SqlServerOperation.FetchAll, "MelId");
            this.MapParameterIn(command, "@PA_INVLN_MEL_ID", melId);
            return this.Execute(command);
        }

        /// <summary>
        ///     Retrieves a collection of <see cref="InvlineRecord" /> instances from the data store.
        /// </summary>
        /// <param name="selcoSpId">
        ///     The value which identifies the <see cref='InvoiceLineModel' /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The collection of <see cref="InvlineRecord" /> instances that match the specified <paramref name='selcoSpId' />.
        /// </returns>
        public IEnumerable<InvlineRecord> FetchAllBySelcoSpId(String selcoSpId)
        {
            DbCommand command = this.GetStoredProcedure(SqlServerOperation.FetchAll, "SelcoSpId");
            this.MapParameterIn(command, "@PA_INVLN_SELCO_SP_ID", selcoSpId);
            return this.Execute(command);
        }

        #endregion

        #region implementations

        /// <summary>
        ///     Gets the underlying table name that this repository sit over.
        /// </summary>
        System.String IInvoiceLineRepository.TableName
        {
            get { return this.TableName; }
        }

        void IInvoiceLineRepository.Create(Consensus.Finance.InvlineRecord record)
        {
            this.Create(record);
        }

        void IInvoiceLineRepository.Modify(Consensus.Finance.InvlineRecord record)
        {
            this.Modify(record);
        }

        void IInvoiceLineRepository.RemoveById(Consensus.Finance.InvlineRecord record)
        {
            this.RemoveById(record);
        }

        /// <summary>
        ///     Retrieves a collection of <see cref="T:Consensus.Finance.InvlineRecord" /> instances from the data store.
        /// </summary>
        /// <param name="invId">
        ///     The value which identifies the <see cref="!:InvoiceLineModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The collection of <see cref="T:Consensus.Finance.InvlineRecord" /> instances that match the specified <paramref name="invId" />.
        /// </returns>
        System.Collections.Generic.IEnumerable<Consensus.Finance.InvlineRecord> IInvoiceLineRepository.FetchAllByInvId(System.String invId)
        {
            return this.FetchAllByInvId(invId);
        }

        /// <summary>
        ///     Retrieves a collection of <see cref="T:Consensus.Finance.InvlineRecord" /> instances from the data store.
        /// </summary>
        /// <param name="productId">
        ///     The value which identifies the <see cref="!:InvoiceLineModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The collection of <see cref="T:Consensus.Finance.InvlineRecord" /> instances that match the specified <paramref name="productId" />.
        /// </returns>
        System.Collections.Generic.IEnumerable<Consensus.Finance.InvlineRecord> IInvoiceLineRepository.FetchAllByProductId(System.String productId)
        {
            return this.FetchAllByProductId(productId);
        }

        /// <summary>
        ///     Retrieves a collection of <see cref="T:Consensus.Finance.InvlineRecord" /> instances from the data store.
        /// </summary>
        /// <param name="bookId">
        ///     The value which identifies the <see cref="!:InvoiceLineModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The collection of <see cref="T:Consensus.Finance.InvlineRecord" /> instances that match the specified <paramref name="bookId" />.
        /// </returns>
        System.Collections.Generic.IEnumerable<Consensus.Finance.InvlineRecord> IInvoiceLineRepository.FetchAllByBookId(System.String bookId)
        {
            return this.FetchAllByBookId(bookId);
        }

        /// <summary>
        ///     Retrieves a collection of <see cref="T:Consensus.Finance.InvlineRecord" /> instances from the data store.
        /// </summary>
        /// <param name="elemId">
        ///     The value which identifies the <see cref="!:InvoiceLineModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The collection of <see cref="T:Consensus.Finance.InvlineRecord" /> instances that match the specified <paramref name="elemId" />.
        /// </returns>
        System.Collections.Generic.IEnumerable<Consensus.Finance.InvlineRecord> IInvoiceLineRepository.FetchAllByElemId(System.String elemId)
        {
            return this.FetchAllByElemId(elemId);
        }

        /// <summary>
        ///     Retrieves a collection of <see cref="T:Consensus.Finance.InvlineRecord" /> instances from the data store.
        /// </summary>
        /// <param name="courseId">
        ///     The value which identifies the <see cref="!:InvoiceLineModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The collection of <see cref="T:Consensus.Finance.InvlineRecord" /> instances that match the specified <paramref name="courseId" />.
        /// </returns>
        System.Collections.Generic.IEnumerable<Consensus.Finance.InvlineRecord> IInvoiceLineRepository.FetchAllByCourseId(System.String courseId)
        {
            return this.FetchAllByCourseId(courseId);
        }

        /// <summary>
        ///     Retrieves a collection of <see cref="T:Consensus.Finance.InvlineRecord" /> instances from the data store.
        /// </summary>
        /// <param name="melId">
        ///     The value which identifies the <see cref="!:InvoiceLineModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The collection of <see cref="T:Consensus.Finance.InvlineRecord" /> instances that match the specified <paramref name="melId" />.
        /// </returns>
        System.Collections.Generic.IEnumerable<Consensus.Finance.InvlineRecord> IInvoiceLineRepository.FetchAllByMelId(System.String melId)
        {
            return this.FetchAllByMelId(melId);
        }

        /// <summary>
        ///     Retrieves a collection of <see cref="T:Consensus.Finance.InvlineRecord" /> instances from the data store.
        /// </summary>
        /// <param name="selcoSpId">
        ///     The value which identifies the <see cref="!:InvoiceLineModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The collection of <see cref="T:Consensus.Finance.InvlineRecord" /> instances that match the specified <paramref name="selcoSpId" />.
        /// </returns>
        System.Collections.Generic.IEnumerable<Consensus.Finance.InvlineRecord> IInvoiceLineRepository.FetchAllBySelcoSpId(System.String selcoSpId)
        {
            return this.FetchAllBySelcoSpId(selcoSpId);
        }

        #endregion
    }
}
