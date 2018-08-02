using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Linq;

namespace Consensus.Finance
{
    /// <summary>
    ///     Provides the persistence and retrieval of the <see cref="PricesRecord" /> instances in a Microsoft SQL Server database.
    /// </summary>
    /// <remarks>
    ///     THIS CODE HAS BEEN AUTOMATICALLY GENERATED USING THE CONSENSUS DEVELOPER TOOLS.
    ///     DO NOT EDIT THIS CODE AS ANY CUSTOM MODIFICATIONS WILL BE LOST UPON REGENERATION.
    /// </remarks>
    public partial class SqlServerPriceRepository : SqlServerRepository<PricesRecord, String>, IPriceRepository
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
            get { return "Prices"; }
        }

        /// <summary>
        ///     Gets the name of the parameter which is used to specify the unique value that identifies each instance of a <see cref="PricesRecord" />.
        /// </summary>
        protected override String TypeKeyName
        {
            get { return "@PA_PRS_ID"; }
        }

        /// <summary>
        ///     Gets the underlying table name that this repository sit over.
        /// </summary>
        public override String TableName
        {
            get { return "Prices"; }
        }

        #endregion

        #region methods

        /// <summary>
        ///     Maps an <see cref="IDataRecord" /> to the specified <see cref="PricesRecord" />.
        /// </summary>
        /// <param name="dataRecord">
        ///     The <see cref="IDataRecord" /> to be mapped.
        /// </param>
        /// <param name="record">
        ///     The <see cref="PricesRecord" /> instance to be mapped to.
        /// </param>
        protected override void MapRecord(IDataRecord dataRecord, PricesRecord record)
        {
            record.Id = dataRecord["PRS_ID"].ConvertTo<String>();
            record.Lock = dataRecord["PRS_LOCK"].ConvertTo<String>();
            record.AddDate = dataRecord["PRS_ADD_DATE"].ConvertTo<DateTime?>();
            record.AddBy = dataRecord["PRS_ADD_BY"].ConvertTo<String>();
            record.ModDate = dataRecord["PRS_MOD_DATE"].ConvertTo<DateTime?>();
            record.ModBy = dataRecord["PRS_MOD_BY"].ConvertTo<String>();
            record.RcvDate = dataRecord["PRS_RCV_DATE"].ConvertTo<DateTime?>();
            record.RcvFrom = dataRecord["PRS_RCV_FROM"].ConvertTo<String>();
            record.PlId = dataRecord["PRS_PL_ID"].ConvertTo<String>();
            record.ProdId = dataRecord["PRS_PROD_ID"].ConvertTo<String>();
            record.Price = dataRecord["PRS_PRICE"].ConvertTo<Decimal>();
            record.BlockPrice = dataRecord["PRS_BLOCK_PRICE"].ConvertTo<Decimal>();
            record.SparePrice = dataRecord["PRS_SPARE_PRICE"].ConvertTo<Decimal>();
            record.CostPrice = dataRecord["PRS_COST_PRICE"].ConvertTo<Decimal>();
            record.CostCode = dataRecord["PRS_COST_CODE"].ConvertTo<String>();
            record.RevCode = dataRecord["PRS_REV_CODE"].ConvertTo<String>();
            record.DiscSched = dataRecord["PRS_DISC_SCHED"].ConvertTo<String>();
            record.VatCode = dataRecord["PRS_VAT_CODE"].ConvertTo<String>();
            record.RetailPrice = dataRecord["PRS_RETAIL_PRICE"].ConvertTo<Decimal>();
            record.NoCostNoSel = dataRecord["PRS_NO_COST_NO_SEL"].ConvertTo<Byte?>();
            record.Default = dataRecord["PRS_DEFAULT"].ConvertTo<Byte?>();
            record.GlCode1 = dataRecord["PRS_GL_CODE1"].ConvertTo<String>();
            record.GlCode2 = dataRecord["PRS_GL_CODE2"].ConvertTo<String>();
            record.ProdCategory = dataRecord["PRS_PROD_CATEGORY"].ConvertTo<String>();
            record.DiscPercent = dataRecord["PRS_DISC_PERCENT"].ConvertTo<Decimal>();
            record.PriceA = dataRecord["PRS_PRICE_A"].ConvertTo<Decimal>();
            record.PriceB = dataRecord["PRS_PRICE_B"].ConvertTo<Decimal>();
            record.PriceC = dataRecord["PRS_PRICE_C"].ConvertTo<Decimal>();
            record.PriceD = dataRecord["PRS_PRICE_D"].ConvertTo<Decimal>();
            record.PriceE = dataRecord["PRS_PRICE_E"].ConvertTo<Decimal>();
            record.GroupQty = dataRecord["PRS_GROUP_QTY"].ConvertTo<Int32?>();
            record.GroupDte = dataRecord["PRS_GROUP_DTE"].ConvertTo<Int32?>();
            record.GroupQtyId = dataRecord["PRS_GROUP_QTY_ID"].ConvertTo<String>();
            record.GroupDteId = dataRecord["PRS_GROUP_DTE_ID"].ConvertTo<String>();
            record.QtyMin = dataRecord["PRS_QTY_MIN"].ConvertTo<Int32?>();
            record.QtyMax = dataRecord["PRS_QTY_MAX"].ConvertTo<Int32?>();
            record.ValidFrom = dataRecord["PRS_VALID_FROM"].ConvertTo<DateTime?>();
            record.ValidUntil = dataRecord["PRS_VALID_UNTIL"].ConvertTo<DateTime?>();
            record.BeforeDays = dataRecord["PRS_BEFORE_DAYS"].ConvertTo<Int32?>();
            record.VatCode2 = dataRecord["PRS_VAT_CODE2"].ConvertTo<String>();
            record.StartDate = dataRecord["PRS_START_DATE"].ConvertTo<DateTime?>();
            record.EndDate = dataRecord["PRS_END_DATE"].ConvertTo<DateTime?>();
            record.QualId = dataRecord["PRS_QUAL_ID"].ConvertTo<String>();
            record.PrepayProdId = dataRecord["PRS_PREPAY_PROD_ID"].ConvertTo<String>();
            record.LineId = dataRecord["PRS_LINE_ID"].ConvertTo<String>();
            record.SeasId = dataRecord["PRS_SEAS_ID"].ConvertTo<String>();
            record.IncPlaces = dataRecord["PRS_INC_PLACES"].ConvertTo<Byte?>();
            record.SubPrice1 = dataRecord["PRS_SUB_PRICE_1"].ConvertTo<Decimal?>();
            record.SubPrice2 = dataRecord["PRS_SUB_PRICE_2"].ConvertTo<Decimal?>();
            record.SubPrice3 = dataRecord["PRS_SUB_PRICE_3"].ConvertTo<Decimal?>();
            record.SubPrice4 = dataRecord["PRS_SUB_PRICE_4"].ConvertTo<Decimal?>();
            record.SubPrice5 = dataRecord["PRS_SUB_PRICE_5"].ConvertTo<Decimal?>();
            record.SubPrice6 = dataRecord["PRS_SUB_PRICE_6"].ConvertTo<Decimal?>();
            record.SubPrice7 = dataRecord["PRS_SUB_PRICE_7"].ConvertTo<Decimal?>();
            record.SubPrice8 = dataRecord["PRS_SUB_PRICE_8"].ConvertTo<Decimal?>();
            record.SubPrice9 = dataRecord["PRS_SUB_PRICE_9"].ConvertTo<Decimal?>();
            record.CurrType = dataRecord["PRS_CURR_TYPE"].ConvertTo<String>();
            record.DoNotRecalc = dataRecord["PRS_DO_NOT_RECALC"].ConvertTo<Byte?>();
            record.SchnNumber = dataRecord["PRS_SCHN_NUMBER"].ConvertTo<Byte?>();
            record.MembPrice = dataRecord["PRS_MEMB_PRICE"].ConvertTo<Byte?>();
            record.Start = dataRecord["PRS_START"].ConvertTo<Int32?>();
            record.End = dataRecord["PRS_END"].ConvertTo<Int32?>();
            record.Desc = dataRecord["PRS_DESC"].ConvertTo<String>();
            record.PrsId = dataRecord["PRS_PRS_ID"].ConvertTo<String>();
            record.Web = dataRecord["PRS_WEB"].ConvertTo<Byte>();
            record.ValidDate = dataRecord["PRS_VALID_DATE"].ConvertTo<Byte>();
            record.Region = dataRecord["PRS_REGION"].ConvertTo<String>();
            record.Type = dataRecord["PRS_TYPE"].ConvertTo<Byte?>();
            record.SeaId = dataRecord["PRS_SEA_ID"].ConvertTo<Int32?>();
        }

        /// <summary>
        ///     Sets the parameter values for the specified <paramref name="command" /> based on the specified <typeparamref name="TRecord" /> instance.
        /// </summary>
        /// <param name="command">
        ///     The <see cref="IDbCommand" /> containing the parameters to be mapped.
        /// </param>
        /// <param name="record">
        ///     The <see cref="PricesRecord" /> instance to be mapped.
        /// </param>
        /// <param name="useV6Logic">
        ///     Is the procedure being run an old version 6.x procedure? (the null value handling logic is different).
        /// </param>
        protected override void MapParametersIn(IDbCommand command, PricesRecord record, bool useV6Logic)
        {
            this.MapParameterIn(command, "@PA_PRS_ID", record.Id);
            this.MapParameterIn(command, "@PA_PRS_LOCK", record.Lock);
            this.MapParameterIn(command, "@PA_PRS_PL_ID", record.PlId);
            this.MapParameterIn(command, "@PA_PRS_PROD_ID", record.ProdId);
            this.MapParameterIn(command, "@PA_PRS_PRICE", record.Price == Decimal.MinValue ? 0M : record.Price);
            this.MapParameterIn(command, "@PA_PRS_BLOCK_PRICE", record.BlockPrice == Decimal.MinValue ? 0M : record.BlockPrice);
            this.MapParameterIn(command, "@PA_PRS_SPARE_PRICE", record.SparePrice == Decimal.MinValue ? 0M : record.SparePrice);
            this.MapParameterIn(command, "@PA_PRS_COST_PRICE", record.CostPrice == Decimal.MinValue ? 0M : record.CostPrice);
            this.MapParameterIn(command, "@PA_PRS_COST_CODE", record.CostCode);
            this.MapParameterIn(command, "@PA_PRS_REV_CODE", record.RevCode);
            this.MapParameterIn(command, "@PA_PRS_DISC_SCHED", record.DiscSched);
            this.MapParameterIn(command, "@PA_PRS_VAT_CODE", record.VatCode);
            this.MapParameterIn(command, "@PA_PRS_RETAIL_PRICE", record.RetailPrice == Decimal.MinValue ? 0M : record.RetailPrice);
            this.MapParameterIn(command, "@PA_PRS_NO_COST_NO_SEL", record.NoCostNoSel);
            this.MapParameterIn(command, "@PA_PRS_DEFAULT", record.Default);
            this.MapParameterIn(command, "@PA_PRS_GL_CODE1", record.GlCode1);
            this.MapParameterIn(command, "@PA_PRS_GL_CODE2", record.GlCode2);
            this.MapParameterIn(command, "@PA_PRS_PROD_CATEGORY", record.ProdCategory);
            this.MapParameterIn(command, "@PA_PRS_DISC_PERCENT", record.DiscPercent == Decimal.MinValue ? 0M : record.DiscPercent);
            this.MapParameterIn(command, "@PA_PRS_PRICE_A", record.PriceA == Decimal.MinValue ? 0M : record.PriceA);
            this.MapParameterIn(command, "@PA_PRS_PRICE_B", record.PriceB == Decimal.MinValue ? 0M : record.PriceB);
            this.MapParameterIn(command, "@PA_PRS_PRICE_C", record.PriceC == Decimal.MinValue ? 0M : record.PriceC);
            this.MapParameterIn(command, "@PA_PRS_PRICE_D", record.PriceD == Decimal.MinValue ? 0M : record.PriceD);
            this.MapParameterIn(command, "@PA_PRS_PRICE_E", record.PriceE == Decimal.MinValue ? 0M : record.PriceE);
            this.MapParameterIn(command, "@PA_PRS_GROUP_QTY", record.GroupQty == Int32.MinValue ? ( useV6Logic ? new Int32?(0) : null ) : record.GroupQty);
            this.MapParameterIn(command, "@PA_PRS_GROUP_DTE", record.GroupDte == Int32.MinValue ? ( useV6Logic ? new Int32?(0) : null ) : record.GroupDte);
            this.MapParameterIn(command, "@PA_PRS_GROUP_QTY_ID", record.GroupQtyId);
            this.MapParameterIn(command, "@PA_PRS_GROUP_DTE_ID", record.GroupDteId);
            this.MapParameterIn(command, "@PA_PRS_QTY_MIN", record.QtyMin == Int32.MinValue ? ( useV6Logic ? new Int32?(0) : null ) : record.QtyMin);
            this.MapParameterIn(command, "@PA_PRS_QTY_MAX", record.QtyMax == Int32.MinValue ? ( useV6Logic ? new Int32?(0) : null ) : record.QtyMax);
            this.MapParameterIn(command, "@PA_PRS_VALID_FROM", record.ValidFrom == DateTime.MinValue ? ( useV6Logic ? new DateTime?(new DateTime(1900,1,1)) : null ) : record.ValidFrom);
            this.MapParameterIn(command, "@PA_PRS_VALID_UNTIL", record.ValidUntil == DateTime.MinValue ? ( useV6Logic ? new DateTime?(new DateTime(1900,1,1)) : null ) : record.ValidUntil);
            this.MapParameterIn(command, "@PA_PRS_BEFORE_DAYS", record.BeforeDays == Int32.MinValue ? ( useV6Logic ? new Int32?(0) : null ) : record.BeforeDays);
            this.MapParameterIn(command, "@PA_PRS_VAT_CODE2", record.VatCode2);
            this.MapParameterIn(command, "@PA_PRS_START_DATE", record.StartDate == DateTime.MinValue ? ( useV6Logic ? new DateTime?(new DateTime(1900,1,1)) : null ) : record.StartDate);
            this.MapParameterIn(command, "@PA_PRS_END_DATE", record.EndDate == DateTime.MinValue ? ( useV6Logic ? new DateTime?(new DateTime(1900,1,1)) : null ) : record.EndDate);
            this.MapParameterIn(command, "@PA_PRS_QUAL_ID", record.QualId);
            this.MapParameterIn(command, "@PA_PRS_PREPAY_PROD_ID", record.PrepayProdId);
            this.MapParameterIn(command, "@PA_PRS_LINE_ID", record.LineId);
            this.MapParameterIn(command, "@PA_PRS_SEAS_ID", record.SeasId);
            this.MapParameterIn(command, "@PA_PRS_INC_PLACES", record.IncPlaces);
            this.MapParameterIn(command, "@PA_PRS_SUB_PRICE_1", record.SubPrice1 == Decimal.MinValue ? ( useV6Logic ? new Decimal?(0M) : null ) : record.SubPrice1);
            this.MapParameterIn(command, "@PA_PRS_SUB_PRICE_2", record.SubPrice2 == Decimal.MinValue ? ( useV6Logic ? new Decimal?(0M) : null ) : record.SubPrice2);
            this.MapParameterIn(command, "@PA_PRS_SUB_PRICE_3", record.SubPrice3 == Decimal.MinValue ? ( useV6Logic ? new Decimal?(0M) : null ) : record.SubPrice3);
            this.MapParameterIn(command, "@PA_PRS_SUB_PRICE_4", record.SubPrice4 == Decimal.MinValue ? ( useV6Logic ? new Decimal?(0M) : null ) : record.SubPrice4);
            this.MapParameterIn(command, "@PA_PRS_SUB_PRICE_5", record.SubPrice5 == Decimal.MinValue ? ( useV6Logic ? new Decimal?(0M) : null ) : record.SubPrice5);
            this.MapParameterIn(command, "@PA_PRS_SUB_PRICE_6", record.SubPrice6 == Decimal.MinValue ? ( useV6Logic ? new Decimal?(0M) : null ) : record.SubPrice6);
            this.MapParameterIn(command, "@PA_PRS_SUB_PRICE_7", record.SubPrice7 == Decimal.MinValue ? ( useV6Logic ? new Decimal?(0M) : null ) : record.SubPrice7);
            this.MapParameterIn(command, "@PA_PRS_SUB_PRICE_8", record.SubPrice8 == Decimal.MinValue ? ( useV6Logic ? new Decimal?(0M) : null ) : record.SubPrice8);
            this.MapParameterIn(command, "@PA_PRS_SUB_PRICE_9", record.SubPrice9 == Decimal.MinValue ? ( useV6Logic ? new Decimal?(0M) : null ) : record.SubPrice9);
            this.MapParameterIn(command, "@PA_PRS_CURR_TYPE", record.CurrType);
            this.MapParameterIn(command, "@PA_PRS_DO_NOT_RECALC", record.DoNotRecalc);
            this.MapParameterIn(command, "@PA_PRS_SCHN_NUMBER", record.SchnNumber);
            this.MapParameterIn(command, "@PA_PRS_MEMB_PRICE", record.MembPrice);
            this.MapParameterIn(command, "@PA_PRS_START", record.Start == Int32.MinValue ? ( useV6Logic ? new Int32?(0) : null ) : record.Start);
            this.MapParameterIn(command, "@PA_PRS_END", record.End == Int32.MinValue ? ( useV6Logic ? new Int32?(0) : null ) : record.End);
            this.MapParameterIn(command, "@PA_PRS_DESC", record.Desc);
            this.MapParameterIn(command, "@PA_PRS_PRS_ID", record.PrsId);
            this.MapParameterIn(command, "@PA_PRS_WEB", record.Web);
            this.MapParameterIn(command, "@PA_PRS_VALID_DATE", record.ValidDate);
            this.MapParameterIn(command, "@PA_PRS_REGION", record.Region);
            this.MapParameterIn(command, "@PA_PRS_TYPE", record.Type);
            this.MapParameterIn(command, "@PA_PRS_SEA_ID", record.SeaId == Int32.MinValue ? ( useV6Logic ? new Int32?(0) : null ) : record.SeaId);
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
        ///     The <see cref="PricesRecord" /> instance to be updated.
        /// </param>
        protected override void MapParametersOut(IDbCommand command, PricesRecord record)
        {
            record.Id = this.MapParameterOut(command, "@PA_PRS_ID", record.Id);
            record.Lock = this.MapParameterOut(command, "@PA_PRS_LOCK", record.Lock);
            record.PlId = this.MapParameterOut(command, "@PA_PRS_PL_ID", record.PlId);
            record.ProdId = this.MapParameterOut(command, "@PA_PRS_PROD_ID", record.ProdId);
            record.Price = this.MapParameterOut(command, "@PA_PRS_PRICE", record.Price);
            record.BlockPrice = this.MapParameterOut(command, "@PA_PRS_BLOCK_PRICE", record.BlockPrice);
            record.SparePrice = this.MapParameterOut(command, "@PA_PRS_SPARE_PRICE", record.SparePrice);
            record.CostPrice = this.MapParameterOut(command, "@PA_PRS_COST_PRICE", record.CostPrice);
            record.CostCode = this.MapParameterOut(command, "@PA_PRS_COST_CODE", record.CostCode);
            record.RevCode = this.MapParameterOut(command, "@PA_PRS_REV_CODE", record.RevCode);
            record.DiscSched = this.MapParameterOut(command, "@PA_PRS_DISC_SCHED", record.DiscSched);
            record.VatCode = this.MapParameterOut(command, "@PA_PRS_VAT_CODE", record.VatCode);
            record.RetailPrice = this.MapParameterOut(command, "@PA_PRS_RETAIL_PRICE", record.RetailPrice);
            record.NoCostNoSel = this.MapParameterOut(command, "@PA_PRS_NO_COST_NO_SEL", record.NoCostNoSel);
            record.Default = this.MapParameterOut(command, "@PA_PRS_DEFAULT", record.Default);
            record.GlCode1 = this.MapParameterOut(command, "@PA_PRS_GL_CODE1", record.GlCode1);
            record.GlCode2 = this.MapParameterOut(command, "@PA_PRS_GL_CODE2", record.GlCode2);
            record.ProdCategory = this.MapParameterOut(command, "@PA_PRS_PROD_CATEGORY", record.ProdCategory);
            record.DiscPercent = this.MapParameterOut(command, "@PA_PRS_DISC_PERCENT", record.DiscPercent);
            record.PriceA = this.MapParameterOut(command, "@PA_PRS_PRICE_A", record.PriceA);
            record.PriceB = this.MapParameterOut(command, "@PA_PRS_PRICE_B", record.PriceB);
            record.PriceC = this.MapParameterOut(command, "@PA_PRS_PRICE_C", record.PriceC);
            record.PriceD = this.MapParameterOut(command, "@PA_PRS_PRICE_D", record.PriceD);
            record.PriceE = this.MapParameterOut(command, "@PA_PRS_PRICE_E", record.PriceE);
            record.GroupQty = this.MapParameterOut(command, "@PA_PRS_GROUP_QTY", record.GroupQty);
            record.GroupDte = this.MapParameterOut(command, "@PA_PRS_GROUP_DTE", record.GroupDte);
            record.GroupQtyId = this.MapParameterOut(command, "@PA_PRS_GROUP_QTY_ID", record.GroupQtyId);
            record.GroupDteId = this.MapParameterOut(command, "@PA_PRS_GROUP_DTE_ID", record.GroupDteId);
            record.QtyMin = this.MapParameterOut(command, "@PA_PRS_QTY_MIN", record.QtyMin);
            record.QtyMax = this.MapParameterOut(command, "@PA_PRS_QTY_MAX", record.QtyMax);
            record.ValidFrom = this.MapParameterOut(command, "@PA_PRS_VALID_FROM", record.ValidFrom);
            record.ValidUntil = this.MapParameterOut(command, "@PA_PRS_VALID_UNTIL", record.ValidUntil);
            record.BeforeDays = this.MapParameterOut(command, "@PA_PRS_BEFORE_DAYS", record.BeforeDays);
            record.VatCode2 = this.MapParameterOut(command, "@PA_PRS_VAT_CODE2", record.VatCode2);
            record.StartDate = this.MapParameterOut(command, "@PA_PRS_START_DATE", record.StartDate);
            record.EndDate = this.MapParameterOut(command, "@PA_PRS_END_DATE", record.EndDate);
            record.QualId = this.MapParameterOut(command, "@PA_PRS_QUAL_ID", record.QualId);
            record.PrepayProdId = this.MapParameterOut(command, "@PA_PRS_PREPAY_PROD_ID", record.PrepayProdId);
            record.LineId = this.MapParameterOut(command, "@PA_PRS_LINE_ID", record.LineId);
            record.SeasId = this.MapParameterOut(command, "@PA_PRS_SEAS_ID", record.SeasId);
            record.IncPlaces = this.MapParameterOut(command, "@PA_PRS_INC_PLACES", record.IncPlaces);
            record.SubPrice1 = this.MapParameterOut(command, "@PA_PRS_SUB_PRICE_1", record.SubPrice1);
            record.SubPrice2 = this.MapParameterOut(command, "@PA_PRS_SUB_PRICE_2", record.SubPrice2);
            record.SubPrice3 = this.MapParameterOut(command, "@PA_PRS_SUB_PRICE_3", record.SubPrice3);
            record.SubPrice4 = this.MapParameterOut(command, "@PA_PRS_SUB_PRICE_4", record.SubPrice4);
            record.SubPrice5 = this.MapParameterOut(command, "@PA_PRS_SUB_PRICE_5", record.SubPrice5);
            record.SubPrice6 = this.MapParameterOut(command, "@PA_PRS_SUB_PRICE_6", record.SubPrice6);
            record.SubPrice7 = this.MapParameterOut(command, "@PA_PRS_SUB_PRICE_7", record.SubPrice7);
            record.SubPrice8 = this.MapParameterOut(command, "@PA_PRS_SUB_PRICE_8", record.SubPrice8);
            record.SubPrice9 = this.MapParameterOut(command, "@PA_PRS_SUB_PRICE_9", record.SubPrice9);
            record.CurrType = this.MapParameterOut(command, "@PA_PRS_CURR_TYPE", record.CurrType);
            record.DoNotRecalc = this.MapParameterOut(command, "@PA_PRS_DO_NOT_RECALC", record.DoNotRecalc);
            record.SchnNumber = this.MapParameterOut(command, "@PA_PRS_SCHN_NUMBER", record.SchnNumber);
            record.MembPrice = this.MapParameterOut(command, "@PA_PRS_MEMB_PRICE", record.MembPrice);
            record.Start = this.MapParameterOut(command, "@PA_PRS_START", record.Start);
            record.End = this.MapParameterOut(command, "@PA_PRS_END", record.End);
            record.Desc = this.MapParameterOut(command, "@PA_PRS_DESC", record.Desc);
            record.PrsId = this.MapParameterOut(command, "@PA_PRS_PRS_ID", record.PrsId);
            record.Web = this.MapParameterOut(command, "@PA_PRS_WEB", record.Web);
            record.ValidDate = this.MapParameterOut(command, "@PA_PRS_VALID_DATE", record.ValidDate);
            record.Region = this.MapParameterOut(command, "@PA_PRS_REGION", record.Region);
            record.Type = this.MapParameterOut(command, "@PA_PRS_TYPE", record.Type);
            record.SeaId = this.MapParameterOut(command, "@PA_PRS_SEA_ID", record.SeaId);
            record.Id = this.MapParameterOut(command, "@PA_RETURN_ID", record.Id);
        }

        /// <summary>
        ///     Retrieves a collection of <see cref="PricesRecord" /> instances from the data store.
        /// </summary>
        /// <param name="plId">
        ///     The value which identifies the <see cref='PriceModel' /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The collection of <see cref="PricesRecord" /> instances that match the specified <paramref name='plId' />.
        /// </returns>
        public IEnumerable<PricesRecord> FetchAllByPlId(String plId)
        {
            DbCommand command = this.GetStoredProcedure(SqlServerOperation.FetchAll, "PlId");
            this.MapParameterIn(command, "@PA_PRS_PL_ID", plId);
            return this.Execute(command);
        }

        /// <summary>
        ///     Retrieves a collection of <see cref="PricesRecord" /> instances from the data store.
        /// </summary>
        /// <param name="prodId">
        ///     The value which identifies the <see cref='PriceModel' /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The collection of <see cref="PricesRecord" /> instances that match the specified <paramref name='prodId' />.
        /// </returns>
        public IEnumerable<PricesRecord> FetchAllByProdId(String prodId)
        {
            DbCommand command = this.GetStoredProcedure(SqlServerOperation.FetchAll, "ProdId");
            this.MapParameterIn(command, "@PA_PRS_PROD_ID", prodId);
            return this.Execute(command);
        }

        #endregion

        #region implementations

        /// <summary>
        ///     Gets the underlying table name that this repository sit over.
        /// </summary>
        System.String IPriceRepository.TableName
        {
            get { return this.TableName; }
        }

        void IPriceRepository.Modify(Consensus.Finance.PricesRecord record)
        {
            this.Modify(record);
        }

        void IPriceRepository.Create(Consensus.Finance.PricesRecord record)
        {
            this.Create(record);
        }

        Consensus.Finance.PricesRecord IPriceRepository.RecalculateMemberFee(System.String productId, System.String plId, System.Nullable<System.DateTime> startDate, System.Nullable<System.DateTime> endDate, System.Int32 qtyTotal)
        {
            return this.RecalculateMemberFee(productId, plId, startDate, endDate, qtyTotal);
        }

        /// <summary>
        ///     Retrieves a single <typeparamref name="TRecord" /> instance from the data store.
        /// </summary>
        /// <returns>
        ///     The <typeparamref name="TRecord" /> instance that matches the specified <paramref name="id" />; or null, if no matching instance can be found.
        /// </returns>
        System.Collections.Generic.IEnumerable<Consensus.Finance.PricesRecord> IPriceRepository.FetchAllByProdidPriceListid(System.String productId, System.String plId)
        {
            return this.FetchAllByProdidPriceListid(productId, plId);
        }

        /// <summary>
        ///     Retrieves a collection of <see cref="T:Consensus.Finance.PricesRecord" /> instances from the data store.
        /// </summary>
        /// <param name="plId">
        ///     The value which identifies the <see cref="!:PriceModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The collection of <see cref="T:Consensus.Finance.PricesRecord" /> instances that match the specified <paramref name="plId" />.
        /// </returns>
        System.Collections.Generic.IEnumerable<Consensus.Finance.PricesRecord> IPriceRepository.FetchAllByPlId(System.String plId)
        {
            return this.FetchAllByPlId(plId);
        }

        /// <summary>
        ///     Retrieves a collection of <see cref="T:Consensus.Finance.PricesRecord" /> instances from the data store.
        /// </summary>
        /// <param name="prodId">
        ///     The value which identifies the <see cref="!:PriceModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The collection of <see cref="T:Consensus.Finance.PricesRecord" /> instances that match the specified <paramref name="prodId" />.
        /// </returns>
        System.Collections.Generic.IEnumerable<Consensus.Finance.PricesRecord> IPriceRepository.FetchAllByProdId(System.String prodId)
        {
            return this.FetchAllByProdId(prodId);
        }

        #endregion
    }
}
