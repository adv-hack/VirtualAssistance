using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Linq;

namespace Consensus.Finance
{
    /// <summary>
    ///     Provides the persistence and retrieval of the <see cref="BookingTermsRecord" /> instances in a Microsoft SQL Server database.
    /// </summary>
    /// <remarks>
    ///     THIS CODE HAS BEEN AUTOMATICALLY GENERATED USING THE CONSENSUS DEVELOPER TOOLS.
    ///     DO NOT EDIT THIS CODE AS ANY CUSTOM MODIFICATIONS WILL BE LOST UPON REGENERATION.
    /// </remarks>
    public partial class SqlServerBookingTermsRepository : SqlServerRepository<BookingTermsRecord, String>, IBookingTermsRepository
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
            get { return "BookingTerms"; }
        }

        /// <summary>
        ///     Gets the name of the parameter which is used to specify the unique value that identifies each instance of a <see cref="BookingTermsRecord" />.
        /// </summary>
        protected override String TypeKeyName
        {
            get { return "@PA_BKT_ID"; }
        }

        /// <summary>
        ///     Gets the underlying table name that this repository sit over.
        /// </summary>
        public override String TableName
        {
            get { return "Booking_Terms"; }
        }

        #endregion

        #region methods

        /// <summary>
        ///     Maps an <see cref="IDataRecord" /> to the specified <see cref="BookingTermsRecord" />.
        /// </summary>
        /// <param name="dataRecord">
        ///     The <see cref="IDataRecord" /> to be mapped.
        /// </param>
        /// <param name="record">
        ///     The <see cref="BookingTermsRecord" /> instance to be mapped to.
        /// </param>
        protected override void MapRecord(IDataRecord dataRecord, BookingTermsRecord record)
        {
            record.Id = dataRecord["BKT_ID"].ConvertTo<String>();
            record.Lock = dataRecord["BKT_LOCK"].ConvertTo<String>();
            record.AddDate = dataRecord["BKT_ADD_DATE"].ConvertTo<DateTime?>();
            record.AddBy = dataRecord["BKT_ADD_BY"].ConvertTo<String>();
            record.ModDate = dataRecord["BKT_MOD_DATE"].ConvertTo<DateTime?>();
            record.ModBy = dataRecord["BKT_MOD_BY"].ConvertTo<String>();
            record.RcvDate = dataRecord["BKT_RCV_DATE"].ConvertTo<DateTime?>();
            record.RcvFrom = dataRecord["BKT_RCV_FROM"].ConvertTo<String>();
            record.FtCanChTh = dataRecord["BKT_FT_CAN_CH_TH"].ConvertTo<Int32?>();
            record.SdCanChTh = dataRecord["BKT_SD_CAN_CH_TH"].ConvertTo<Int32?>();
            record.CanChgPrcn = dataRecord["BKT_CAN_CHG_PRCN"].ConvertTo<Double?>();
            record.FtTrnChTh = dataRecord["BKT_FT_TRN_CH_TH"].ConvertTo<Int32?>();
            record.TranChPrcn = dataRecord["BKT_TRAN_CH_PRCN"].ConvertTo<Double?>();
            record.XtMvChPrcn = dataRecord["BKT_XT_MV_CH_PRCN"].ConvertTo<Double?>();
            record.Description = dataRecord["BKT_DESCRIPTION"].ConvertTo<String>();
            record.CanChgPrcn2 = dataRecord["BKT_CAN_CHG_PRCN2"].ConvertTo<Double?>();
            record.CanChgPrcn3 = dataRecord["BKT_CAN_CHG_PRCN3"].ConvertTo<Double?>();
            record.B3dCanChTh = dataRecord["BKT_3D_CAN_CH_TH"].ConvertTo<Int32?>();
            record.SdTrnChTh = dataRecord["BKT_SD_TRN_CH_TH"].ConvertTo<Int32?>();
            record.BdTrnChTh = dataRecord["BKT_3D_TRN_CH_TH"].ConvertTo<Int32?>();
            record.TranChPrcn2 = dataRecord["BKT_TRAN_CH_PRCN2"].ConvertTo<Double?>();
            record.TranChPrcn3 = dataRecord["BKT_TRAN_CH_PRCN3"].ConvertTo<Double?>();
            record.CanChgFx1 = dataRecord["BKT_CAN_CHG_FX1"].ConvertTo<Double?>();
            record.CanChgFx2 = dataRecord["BKT_CAN_CHG_FX2"].ConvertTo<Double?>();
            record.CanChgFx3 = dataRecord["BKT_CAN_CHG_FX3"].ConvertTo<Double?>();
            record.TranChFx1 = dataRecord["BKT_TRAN_CH_FX1"].ConvertTo<Double?>();
            record.TranChFx2 = dataRecord["BKT_TRAN_CH_FX2"].ConvertTo<Double?>();
            record.TranChFx3 = dataRecord["BKT_TRAN_CH_FX3"].ConvertTo<Double?>();
            record.Currency = dataRecord["BKT_CURRENCY"].ConvertTo<String>();
            record.NoteHtml = dataRecord["BKT_NOTE_HTML"].ConvertTo<String>();
            record.CanChgBc = dataRecord["BKT_CAN_CHG_BC"].ConvertTo<Decimal?>();
            record.CanChgBc2 = dataRecord["BKT_CAN_CHG_BC2"].ConvertTo<Decimal?>();
            record.CanChgBc3 = dataRecord["BKT_CAN_CHG_BC3"].ConvertTo<Decimal?>();
            record.TranChgBc = dataRecord["BKT_TRAN_CHG_BC"].ConvertTo<Decimal?>();
            record.TranChgBc2 = dataRecord["BKT_TRAN_CHG_BC2"].ConvertTo<Decimal?>();
            record.TranChgBc3 = dataRecord["BKT_TRAN_CHG_BC3"].ConvertTo<Decimal?>();
            record.SubChgBc = dataRecord["BKT_SUB_CHG_BC"].ConvertTo<Decimal?>();
            record.SubChgBc2 = dataRecord["BKT_SUB_CHG_BC2"].ConvertTo<Decimal?>();
            record.SubChgBc3 = dataRecord["BKT_SUB_CHG_BC3"].ConvertTo<Decimal?>();
            record.SubChPrcn = dataRecord["BKT_SUB_CH_PRCN"].ConvertTo<Decimal?>();
            record.SubChPrcn2 = dataRecord["BKT_SUB_CH_PRCN2"].ConvertTo<Decimal?>();
            record.SubChPrcn3 = dataRecord["BKT_SUB_CH_PRCN3"].ConvertTo<Decimal?>();
            record.FtSubChTh = dataRecord["BKT_FT_SUB_CH_TH"].ConvertTo<Int32?>();
            record.SdSubChTh = dataRecord["BKT_SD_SUB_CH_TH"].ConvertTo<Int32?>();
            record.B3dSubChTh = dataRecord["BKT_3D_SUB_CH_TH"].ConvertTo<Int32?>();
            record.TrnNoChg = dataRecord["BKT_TRN_NO_CHG"].ConvertTo<Int32?>();
            record.SubNoChg = dataRecord["BKT_SUB_NO_CHG"].ConvertTo<Int32?>();
            record.TrnNoChgPrcn = dataRecord["BKT_TRN_NO_CHG_PRCN"].ConvertTo<Double?>();
            record.TrnNoChgBc = dataRecord["BKT_TRN_NO_CHG_BC"].ConvertTo<Decimal?>();
            record.SubNoChgPrcn = dataRecord["BKT_SUB_NO_CHG_PRCN"].ConvertTo<Double?>();
            record.SubNoChgBc = dataRecord["BKT_SUB_NO_CHG_BC"].ConvertTo<Decimal?>();
            record.QualCanChgPrcn = dataRecord["BKT_QUAL_CAN_CHG_PRCN"].ConvertTo<Double?>();
            record.TrnAdminFee = dataRecord["BKT_TRN_ADMIN_FEE"].ConvertTo<Decimal?>();
            record.SubAdminFee = dataRecord["BKT_SUB_ADMIN_FEE"].ConvertTo<Decimal?>();
            record.TrnAdminTh = dataRecord["BKT_TRN_ADMIN_TH"].ConvertTo<Int32?>();
            record.SubAdminTh = dataRecord["BKT_SUB_ADMIN_TH"].ConvertTo<Int32?>();
            record.PenaltyCalc = dataRecord["BKT_PENALTY_CALC"].ConvertTo<Byte>();
            record.B04CanChTh = dataRecord["BKT_04_CAN_CH_TH"].ConvertTo<Int32?>();
            record.B05CanChTh = dataRecord["BKT_05_CAN_CH_TH"].ConvertTo<Int32?>();
            record.CanChgPrcn4 = dataRecord["BKT_CAN_CHG_PRCN4"].ConvertTo<Double?>();
            record.CanChgPrcn5 = dataRecord["BKT_CAN_CHG_PRCN5"].ConvertTo<Double?>();
            record.CanChgBc4 = dataRecord["BKT_CAN_CHG_BC4"].ConvertTo<Decimal?>();
            record.CanChgBc5 = dataRecord["BKT_CAN_CHG_BC5"].ConvertTo<Decimal?>();
            record.B04TrnChTh = dataRecord["BKT_04_TRN_CH_TH"].ConvertTo<Int32?>();
            record.B05TrnChTh = dataRecord["BKT_05_TRN_CH_TH"].ConvertTo<Int32?>();
            record.TranChPrcn4 = dataRecord["BKT_TRAN_CH_PRCN4"].ConvertTo<Double?>();
            record.TranChPrcn5 = dataRecord["BKT_TRAN_CH_PRCN5"].ConvertTo<Double?>();
            record.TranChgBc4 = dataRecord["BKT_TRAN_CHG_BC4"].ConvertTo<Decimal?>();
            record.TranChgBc5 = dataRecord["BKT_TRAN_CHG_BC5"].ConvertTo<Decimal?>();
            record.B04SubChTh = dataRecord["BKT_04_SUB_CH_TH"].ConvertTo<Int32?>();
            record.B05SubChTh = dataRecord["BKT_05_SUB_CH_TH"].ConvertTo<Int32?>();
            record.SubChPrcn4 = dataRecord["BKT_SUB_CH_PRCN4"].ConvertTo<Double?>();
            record.SubChPrcn5 = dataRecord["BKT_SUB_CH_PRCN5"].ConvertTo<Double?>();
            record.SubChgBc4 = dataRecord["BKT_SUB_CHG_BC4"].ConvertTo<Decimal?>();
            record.SubChgBc5 = dataRecord["BKT_SUB_CHG_BC5"].ConvertTo<Decimal?>();
            record.CostCode = dataRecord["BKT_COST_CODE"].ConvertTo<String>();
            record.RevCode = dataRecord["BKT_REV_CODE"].ConvertTo<String>();
        }

        /// <summary>
        ///     Sets the parameter values for the specified <paramref name="command" /> based on the specified <typeparamref name="TRecord" /> instance.
        /// </summary>
        /// <param name="command">
        ///     The <see cref="IDbCommand" /> containing the parameters to be mapped.
        /// </param>
        /// <param name="record">
        ///     The <see cref="BookingTermsRecord" /> instance to be mapped.
        /// </param>
        /// <param name="useV6Logic">
        ///     Is the procedure being run an old version 6.x procedure? (the null value handling logic is different).
        /// </param>
        protected override void MapParametersIn(IDbCommand command, BookingTermsRecord record, bool useV6Logic)
        {
            this.MapParameterIn(command, "@PA_BKT_ID", record.Id);
            this.MapParameterIn(command, "@PA_BKT_LOCK", record.Lock);
            this.MapParameterIn(command, "@PA_BKT_FT_CAN_CH_TH", record.FtCanChTh == Int32.MinValue ? ( useV6Logic ? new Int32?(0) : null ) : record.FtCanChTh);
            this.MapParameterIn(command, "@PA_BKT_SD_CAN_CH_TH", record.SdCanChTh == Int32.MinValue ? ( useV6Logic ? new Int32?(0) : null ) : record.SdCanChTh);
            this.MapParameterIn(command, "@PA_BKT_CAN_CHG_PRCN", record.CanChgPrcn == Double.MinValue ? ( useV6Logic ? new Double?(0) : null ) : record.CanChgPrcn);
            this.MapParameterIn(command, "@PA_BKT_FT_TRN_CH_TH", record.FtTrnChTh == Int32.MinValue ? ( useV6Logic ? new Int32?(0) : null ) : record.FtTrnChTh);
            this.MapParameterIn(command, "@PA_BKT_TRAN_CH_PRCN", record.TranChPrcn == Double.MinValue ? ( useV6Logic ? new Double?(0) : null ) : record.TranChPrcn);
            this.MapParameterIn(command, "@PA_BKT_XT_MV_CH_PRCN", record.XtMvChPrcn == Double.MinValue ? ( useV6Logic ? new Double?(0) : null ) : record.XtMvChPrcn);
            this.MapParameterIn(command, "@PA_BKT_DESCRIPTION", record.Description);
            this.MapParameterIn(command, "@PA_BKT_CAN_CHG_PRCN2", record.CanChgPrcn2 == Double.MinValue ? ( useV6Logic ? new Double?(0) : null ) : record.CanChgPrcn2);
            this.MapParameterIn(command, "@PA_BKT_CAN_CHG_PRCN3", record.CanChgPrcn3 == Double.MinValue ? ( useV6Logic ? new Double?(0) : null ) : record.CanChgPrcn3);
            this.MapParameterIn(command, "@PA_BKT_3D_CAN_CH_TH", record.B3dCanChTh == Int32.MinValue ? ( useV6Logic ? new Int32?(0) : null ) : record.B3dCanChTh);
            this.MapParameterIn(command, "@PA_BKT_SD_TRN_CH_TH", record.SdTrnChTh == Int32.MinValue ? ( useV6Logic ? new Int32?(0) : null ) : record.SdTrnChTh);
            this.MapParameterIn(command, "@PA_BKT_3D_TRN_CH_TH", record.BdTrnChTh == Int32.MinValue ? ( useV6Logic ? new Int32?(0) : null ) : record.BdTrnChTh);
            this.MapParameterIn(command, "@PA_BKT_TRAN_CH_PRCN2", record.TranChPrcn2 == Double.MinValue ? ( useV6Logic ? new Double?(0) : null ) : record.TranChPrcn2);
            this.MapParameterIn(command, "@PA_BKT_TRAN_CH_PRCN3", record.TranChPrcn3 == Double.MinValue ? ( useV6Logic ? new Double?(0) : null ) : record.TranChPrcn3);
            this.MapParameterIn(command, "@PA_BKT_CAN_CHG_FX1", record.CanChgFx1 == Double.MinValue ? ( useV6Logic ? new Double?(0) : null ) : record.CanChgFx1);
            this.MapParameterIn(command, "@PA_BKT_CAN_CHG_FX2", record.CanChgFx2 == Double.MinValue ? ( useV6Logic ? new Double?(0) : null ) : record.CanChgFx2);
            this.MapParameterIn(command, "@PA_BKT_CAN_CHG_FX3", record.CanChgFx3 == Double.MinValue ? ( useV6Logic ? new Double?(0) : null ) : record.CanChgFx3);
            this.MapParameterIn(command, "@PA_BKT_TRAN_CH_FX1", record.TranChFx1 == Double.MinValue ? ( useV6Logic ? new Double?(0) : null ) : record.TranChFx1);
            this.MapParameterIn(command, "@PA_BKT_TRAN_CH_FX2", record.TranChFx2 == Double.MinValue ? ( useV6Logic ? new Double?(0) : null ) : record.TranChFx2);
            this.MapParameterIn(command, "@PA_BKT_TRAN_CH_FX3", record.TranChFx3 == Double.MinValue ? ( useV6Logic ? new Double?(0) : null ) : record.TranChFx3);
            this.MapParameterIn(command, "@PA_BKT_CURRENCY", record.Currency);
            this.MapParameterIn(command, "@PA_BKT_NOTE_HTML", record.NoteHtml);
            this.MapParameterIn(command, "@PA_BKT_CAN_CHG_BC", record.CanChgBc == Decimal.MinValue ? ( useV6Logic ? new Decimal?(0M) : null ) : record.CanChgBc);
            this.MapParameterIn(command, "@PA_BKT_CAN_CHG_BC2", record.CanChgBc2 == Decimal.MinValue ? ( useV6Logic ? new Decimal?(0M) : null ) : record.CanChgBc2);
            this.MapParameterIn(command, "@PA_BKT_CAN_CHG_BC3", record.CanChgBc3 == Decimal.MinValue ? ( useV6Logic ? new Decimal?(0M) : null ) : record.CanChgBc3);
            this.MapParameterIn(command, "@PA_BKT_TRAN_CHG_BC", record.TranChgBc == Decimal.MinValue ? ( useV6Logic ? new Decimal?(0M) : null ) : record.TranChgBc);
            this.MapParameterIn(command, "@PA_BKT_TRAN_CHG_BC2", record.TranChgBc2 == Decimal.MinValue ? ( useV6Logic ? new Decimal?(0M) : null ) : record.TranChgBc2);
            this.MapParameterIn(command, "@PA_BKT_TRAN_CHG_BC3", record.TranChgBc3 == Decimal.MinValue ? ( useV6Logic ? new Decimal?(0M) : null ) : record.TranChgBc3);
            this.MapParameterIn(command, "@PA_BKT_SUB_CHG_BC", record.SubChgBc == Decimal.MinValue ? ( useV6Logic ? new Decimal?(0M) : null ) : record.SubChgBc);
            this.MapParameterIn(command, "@PA_BKT_SUB_CHG_BC2", record.SubChgBc2 == Decimal.MinValue ? ( useV6Logic ? new Decimal?(0M) : null ) : record.SubChgBc2);
            this.MapParameterIn(command, "@PA_BKT_SUB_CHG_BC3", record.SubChgBc3 == Decimal.MinValue ? ( useV6Logic ? new Decimal?(0M) : null ) : record.SubChgBc3);
            this.MapParameterIn(command, "@PA_BKT_SUB_CH_PRCN", record.SubChPrcn == Decimal.MinValue ? ( useV6Logic ? new Decimal?(0M) : null ) : record.SubChPrcn);
            this.MapParameterIn(command, "@PA_BKT_SUB_CH_PRCN2", record.SubChPrcn2 == Decimal.MinValue ? ( useV6Logic ? new Decimal?(0M) : null ) : record.SubChPrcn2);
            this.MapParameterIn(command, "@PA_BKT_SUB_CH_PRCN3", record.SubChPrcn3 == Decimal.MinValue ? ( useV6Logic ? new Decimal?(0M) : null ) : record.SubChPrcn3);
            this.MapParameterIn(command, "@PA_BKT_FT_SUB_CH_TH", record.FtSubChTh == Int32.MinValue ? ( useV6Logic ? new Int32?(0) : null ) : record.FtSubChTh);
            this.MapParameterIn(command, "@PA_BKT_SD_SUB_CH_TH", record.SdSubChTh == Int32.MinValue ? ( useV6Logic ? new Int32?(0) : null ) : record.SdSubChTh);
            this.MapParameterIn(command, "@PA_BKT_3D_SUB_CH_TH", record.B3dSubChTh == Int32.MinValue ? ( useV6Logic ? new Int32?(0) : null ) : record.B3dSubChTh);
            this.MapParameterIn(command, "@PA_BKT_TRN_NO_CHG", record.TrnNoChg == Int32.MinValue ? ( useV6Logic ? new Int32?(0) : null ) : record.TrnNoChg);
            this.MapParameterIn(command, "@PA_BKT_SUB_NO_CHG", record.SubNoChg == Int32.MinValue ? ( useV6Logic ? new Int32?(0) : null ) : record.SubNoChg);
            this.MapParameterIn(command, "@PA_BKT_TRN_NO_CHG_PRCN", record.TrnNoChgPrcn == Double.MinValue ? ( useV6Logic ? new Double?(0) : null ) : record.TrnNoChgPrcn);
            this.MapParameterIn(command, "@PA_BKT_TRN_NO_CHG_BC", record.TrnNoChgBc == Decimal.MinValue ? ( useV6Logic ? new Decimal?(0M) : null ) : record.TrnNoChgBc);
            this.MapParameterIn(command, "@PA_BKT_SUB_NO_CHG_PRCN", record.SubNoChgPrcn == Double.MinValue ? ( useV6Logic ? new Double?(0) : null ) : record.SubNoChgPrcn);
            this.MapParameterIn(command, "@PA_BKT_SUB_NO_CHG_BC", record.SubNoChgBc == Decimal.MinValue ? ( useV6Logic ? new Decimal?(0M) : null ) : record.SubNoChgBc);
            this.MapParameterIn(command, "@PA_BKT_QUAL_CAN_CHG_PRCN", record.QualCanChgPrcn == Double.MinValue ? ( useV6Logic ? new Double?(0) : null ) : record.QualCanChgPrcn);
            this.MapParameterIn(command, "@PA_BKT_TRN_ADMIN_FEE", record.TrnAdminFee == Decimal.MinValue ? ( useV6Logic ? new Decimal?(0M) : null ) : record.TrnAdminFee);
            this.MapParameterIn(command, "@PA_BKT_SUB_ADMIN_FEE", record.SubAdminFee == Decimal.MinValue ? ( useV6Logic ? new Decimal?(0M) : null ) : record.SubAdminFee);
            this.MapParameterIn(command, "@PA_BKT_TRN_ADMIN_TH", record.TrnAdminTh == Int32.MinValue ? ( useV6Logic ? new Int32?(0) : null ) : record.TrnAdminTh);
            this.MapParameterIn(command, "@PA_BKT_SUB_ADMIN_TH", record.SubAdminTh == Int32.MinValue ? ( useV6Logic ? new Int32?(0) : null ) : record.SubAdminTh);
            this.MapParameterIn(command, "@PA_BKT_PENALTY_CALC", record.PenaltyCalc);
            this.MapParameterIn(command, "@PA_BKT_04_CAN_CH_TH", record.B04CanChTh == Int32.MinValue ? ( useV6Logic ? new Int32?(0) : null ) : record.B04CanChTh);
            this.MapParameterIn(command, "@PA_BKT_05_CAN_CH_TH", record.B05CanChTh == Int32.MinValue ? ( useV6Logic ? new Int32?(0) : null ) : record.B05CanChTh);
            this.MapParameterIn(command, "@PA_BKT_CAN_CHG_PRCN4", record.CanChgPrcn4 == Double.MinValue ? ( useV6Logic ? new Double?(0) : null ) : record.CanChgPrcn4);
            this.MapParameterIn(command, "@PA_BKT_CAN_CHG_PRCN5", record.CanChgPrcn5 == Double.MinValue ? ( useV6Logic ? new Double?(0) : null ) : record.CanChgPrcn5);
            this.MapParameterIn(command, "@PA_BKT_CAN_CHG_BC4", record.CanChgBc4 == Decimal.MinValue ? ( useV6Logic ? new Decimal?(0M) : null ) : record.CanChgBc4);
            this.MapParameterIn(command, "@PA_BKT_CAN_CHG_BC5", record.CanChgBc5 == Decimal.MinValue ? ( useV6Logic ? new Decimal?(0M) : null ) : record.CanChgBc5);
            this.MapParameterIn(command, "@PA_BKT_04_TRN_CH_TH", record.B04TrnChTh == Int32.MinValue ? ( useV6Logic ? new Int32?(0) : null ) : record.B04TrnChTh);
            this.MapParameterIn(command, "@PA_BKT_05_TRN_CH_TH", record.B05TrnChTh == Int32.MinValue ? ( useV6Logic ? new Int32?(0) : null ) : record.B05TrnChTh);
            this.MapParameterIn(command, "@PA_BKT_TRAN_CH_PRCN4", record.TranChPrcn4 == Double.MinValue ? ( useV6Logic ? new Double?(0) : null ) : record.TranChPrcn4);
            this.MapParameterIn(command, "@PA_BKT_TRAN_CH_PRCN5", record.TranChPrcn5 == Double.MinValue ? ( useV6Logic ? new Double?(0) : null ) : record.TranChPrcn5);
            this.MapParameterIn(command, "@PA_BKT_TRAN_CHG_BC4", record.TranChgBc4 == Decimal.MinValue ? ( useV6Logic ? new Decimal?(0M) : null ) : record.TranChgBc4);
            this.MapParameterIn(command, "@PA_BKT_TRAN_CHG_BC5", record.TranChgBc5 == Decimal.MinValue ? ( useV6Logic ? new Decimal?(0M) : null ) : record.TranChgBc5);
            this.MapParameterIn(command, "@PA_BKT_04_SUB_CH_TH", record.B04SubChTh == Int32.MinValue ? ( useV6Logic ? new Int32?(0) : null ) : record.B04SubChTh);
            this.MapParameterIn(command, "@PA_BKT_05_SUB_CH_TH", record.B05SubChTh == Int32.MinValue ? ( useV6Logic ? new Int32?(0) : null ) : record.B05SubChTh);
            this.MapParameterIn(command, "@PA_BKT_SUB_CH_PRCN4", record.SubChPrcn4 == Double.MinValue ? ( useV6Logic ? new Double?(0) : null ) : record.SubChPrcn4);
            this.MapParameterIn(command, "@PA_BKT_SUB_CH_PRCN5", record.SubChPrcn5 == Double.MinValue ? ( useV6Logic ? new Double?(0) : null ) : record.SubChPrcn5);
            this.MapParameterIn(command, "@PA_BKT_SUB_CHG_BC4", record.SubChgBc4 == Decimal.MinValue ? ( useV6Logic ? new Decimal?(0M) : null ) : record.SubChgBc4);
            this.MapParameterIn(command, "@PA_BKT_SUB_CHG_BC5", record.SubChgBc5 == Decimal.MinValue ? ( useV6Logic ? new Decimal?(0M) : null ) : record.SubChgBc5);
            this.MapParameterIn(command, "@PA_BKT_COST_CODE", record.CostCode);
            this.MapParameterIn(command, "@PA_BKT_REV_CODE", record.RevCode);
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
        ///     The <see cref="BookingTermsRecord" /> instance to be updated.
        /// </param>
        protected override void MapParametersOut(IDbCommand command, BookingTermsRecord record)
        {
            record.Id = this.MapParameterOut(command, "@PA_BKT_ID", record.Id);
            record.Lock = this.MapParameterOut(command, "@PA_BKT_LOCK", record.Lock);
            record.FtCanChTh = this.MapParameterOut(command, "@PA_BKT_FT_CAN_CH_TH", record.FtCanChTh);
            record.SdCanChTh = this.MapParameterOut(command, "@PA_BKT_SD_CAN_CH_TH", record.SdCanChTh);
            record.CanChgPrcn = this.MapParameterOut(command, "@PA_BKT_CAN_CHG_PRCN", record.CanChgPrcn);
            record.FtTrnChTh = this.MapParameterOut(command, "@PA_BKT_FT_TRN_CH_TH", record.FtTrnChTh);
            record.TranChPrcn = this.MapParameterOut(command, "@PA_BKT_TRAN_CH_PRCN", record.TranChPrcn);
            record.XtMvChPrcn = this.MapParameterOut(command, "@PA_BKT_XT_MV_CH_PRCN", record.XtMvChPrcn);
            record.Description = this.MapParameterOut(command, "@PA_BKT_DESCRIPTION", record.Description);
            record.CanChgPrcn2 = this.MapParameterOut(command, "@PA_BKT_CAN_CHG_PRCN2", record.CanChgPrcn2);
            record.CanChgPrcn3 = this.MapParameterOut(command, "@PA_BKT_CAN_CHG_PRCN3", record.CanChgPrcn3);
            record.B3dCanChTh = this.MapParameterOut(command, "@PA_BKT_3D_CAN_CH_TH", record.B3dCanChTh);
            record.SdTrnChTh = this.MapParameterOut(command, "@PA_BKT_SD_TRN_CH_TH", record.SdTrnChTh);
            record.BdTrnChTh = this.MapParameterOut(command, "@PA_BKT_3D_TRN_CH_TH", record.BdTrnChTh);
            record.TranChPrcn2 = this.MapParameterOut(command, "@PA_BKT_TRAN_CH_PRCN2", record.TranChPrcn2);
            record.TranChPrcn3 = this.MapParameterOut(command, "@PA_BKT_TRAN_CH_PRCN3", record.TranChPrcn3);
            record.CanChgFx1 = this.MapParameterOut(command, "@PA_BKT_CAN_CHG_FX1", record.CanChgFx1);
            record.CanChgFx2 = this.MapParameterOut(command, "@PA_BKT_CAN_CHG_FX2", record.CanChgFx2);
            record.CanChgFx3 = this.MapParameterOut(command, "@PA_BKT_CAN_CHG_FX3", record.CanChgFx3);
            record.TranChFx1 = this.MapParameterOut(command, "@PA_BKT_TRAN_CH_FX1", record.TranChFx1);
            record.TranChFx2 = this.MapParameterOut(command, "@PA_BKT_TRAN_CH_FX2", record.TranChFx2);
            record.TranChFx3 = this.MapParameterOut(command, "@PA_BKT_TRAN_CH_FX3", record.TranChFx3);
            record.Currency = this.MapParameterOut(command, "@PA_BKT_CURRENCY", record.Currency);
            record.NoteHtml = this.MapParameterOut(command, "@PA_BKT_NOTE_HTML", record.NoteHtml);
            record.CanChgBc = this.MapParameterOut(command, "@PA_BKT_CAN_CHG_BC", record.CanChgBc);
            record.CanChgBc2 = this.MapParameterOut(command, "@PA_BKT_CAN_CHG_BC2", record.CanChgBc2);
            record.CanChgBc3 = this.MapParameterOut(command, "@PA_BKT_CAN_CHG_BC3", record.CanChgBc3);
            record.TranChgBc = this.MapParameterOut(command, "@PA_BKT_TRAN_CHG_BC", record.TranChgBc);
            record.TranChgBc2 = this.MapParameterOut(command, "@PA_BKT_TRAN_CHG_BC2", record.TranChgBc2);
            record.TranChgBc3 = this.MapParameterOut(command, "@PA_BKT_TRAN_CHG_BC3", record.TranChgBc3);
            record.SubChgBc = this.MapParameterOut(command, "@PA_BKT_SUB_CHG_BC", record.SubChgBc);
            record.SubChgBc2 = this.MapParameterOut(command, "@PA_BKT_SUB_CHG_BC2", record.SubChgBc2);
            record.SubChgBc3 = this.MapParameterOut(command, "@PA_BKT_SUB_CHG_BC3", record.SubChgBc3);
            record.SubChPrcn = this.MapParameterOut(command, "@PA_BKT_SUB_CH_PRCN", record.SubChPrcn);
            record.SubChPrcn2 = this.MapParameterOut(command, "@PA_BKT_SUB_CH_PRCN2", record.SubChPrcn2);
            record.SubChPrcn3 = this.MapParameterOut(command, "@PA_BKT_SUB_CH_PRCN3", record.SubChPrcn3);
            record.FtSubChTh = this.MapParameterOut(command, "@PA_BKT_FT_SUB_CH_TH", record.FtSubChTh);
            record.SdSubChTh = this.MapParameterOut(command, "@PA_BKT_SD_SUB_CH_TH", record.SdSubChTh);
            record.B3dSubChTh = this.MapParameterOut(command, "@PA_BKT_3D_SUB_CH_TH", record.B3dSubChTh);
            record.TrnNoChg = this.MapParameterOut(command, "@PA_BKT_TRN_NO_CHG", record.TrnNoChg);
            record.SubNoChg = this.MapParameterOut(command, "@PA_BKT_SUB_NO_CHG", record.SubNoChg);
            record.TrnNoChgPrcn = this.MapParameterOut(command, "@PA_BKT_TRN_NO_CHG_PRCN", record.TrnNoChgPrcn);
            record.TrnNoChgBc = this.MapParameterOut(command, "@PA_BKT_TRN_NO_CHG_BC", record.TrnNoChgBc);
            record.SubNoChgPrcn = this.MapParameterOut(command, "@PA_BKT_SUB_NO_CHG_PRCN", record.SubNoChgPrcn);
            record.SubNoChgBc = this.MapParameterOut(command, "@PA_BKT_SUB_NO_CHG_BC", record.SubNoChgBc);
            record.QualCanChgPrcn = this.MapParameterOut(command, "@PA_BKT_QUAL_CAN_CHG_PRCN", record.QualCanChgPrcn);
            record.TrnAdminFee = this.MapParameterOut(command, "@PA_BKT_TRN_ADMIN_FEE", record.TrnAdminFee);
            record.SubAdminFee = this.MapParameterOut(command, "@PA_BKT_SUB_ADMIN_FEE", record.SubAdminFee);
            record.TrnAdminTh = this.MapParameterOut(command, "@PA_BKT_TRN_ADMIN_TH", record.TrnAdminTh);
            record.SubAdminTh = this.MapParameterOut(command, "@PA_BKT_SUB_ADMIN_TH", record.SubAdminTh);
            record.PenaltyCalc = this.MapParameterOut(command, "@PA_BKT_PENALTY_CALC", record.PenaltyCalc);
            record.B04CanChTh = this.MapParameterOut(command, "@PA_BKT_04_CAN_CH_TH", record.B04CanChTh);
            record.B05CanChTh = this.MapParameterOut(command, "@PA_BKT_05_CAN_CH_TH", record.B05CanChTh);
            record.CanChgPrcn4 = this.MapParameterOut(command, "@PA_BKT_CAN_CHG_PRCN4", record.CanChgPrcn4);
            record.CanChgPrcn5 = this.MapParameterOut(command, "@PA_BKT_CAN_CHG_PRCN5", record.CanChgPrcn5);
            record.CanChgBc4 = this.MapParameterOut(command, "@PA_BKT_CAN_CHG_BC4", record.CanChgBc4);
            record.CanChgBc5 = this.MapParameterOut(command, "@PA_BKT_CAN_CHG_BC5", record.CanChgBc5);
            record.B04TrnChTh = this.MapParameterOut(command, "@PA_BKT_04_TRN_CH_TH", record.B04TrnChTh);
            record.B05TrnChTh = this.MapParameterOut(command, "@PA_BKT_05_TRN_CH_TH", record.B05TrnChTh);
            record.TranChPrcn4 = this.MapParameterOut(command, "@PA_BKT_TRAN_CH_PRCN4", record.TranChPrcn4);
            record.TranChPrcn5 = this.MapParameterOut(command, "@PA_BKT_TRAN_CH_PRCN5", record.TranChPrcn5);
            record.TranChgBc4 = this.MapParameterOut(command, "@PA_BKT_TRAN_CHG_BC4", record.TranChgBc4);
            record.TranChgBc5 = this.MapParameterOut(command, "@PA_BKT_TRAN_CHG_BC5", record.TranChgBc5);
            record.B04SubChTh = this.MapParameterOut(command, "@PA_BKT_04_SUB_CH_TH", record.B04SubChTh);
            record.B05SubChTh = this.MapParameterOut(command, "@PA_BKT_05_SUB_CH_TH", record.B05SubChTh);
            record.SubChPrcn4 = this.MapParameterOut(command, "@PA_BKT_SUB_CH_PRCN4", record.SubChPrcn4);
            record.SubChPrcn5 = this.MapParameterOut(command, "@PA_BKT_SUB_CH_PRCN5", record.SubChPrcn5);
            record.SubChgBc4 = this.MapParameterOut(command, "@PA_BKT_SUB_CHG_BC4", record.SubChgBc4);
            record.SubChgBc5 = this.MapParameterOut(command, "@PA_BKT_SUB_CHG_BC5", record.SubChgBc5);
            record.CostCode = this.MapParameterOut(command, "@PA_BKT_COST_CODE", record.CostCode);
            record.RevCode = this.MapParameterOut(command, "@PA_BKT_REV_CODE", record.RevCode);
            record.Id = this.MapParameterOut(command, "@PA_RETURN_ID", record.Id);
        }

        #endregion

        #region implementations

        /// <summary>
        ///     Gets the underlying table name that this repository sit over.
        /// </summary>
        System.String IBookingTermsRepository.TableName
        {
            get { return this.TableName; }
        }

        #endregion
    }
}
