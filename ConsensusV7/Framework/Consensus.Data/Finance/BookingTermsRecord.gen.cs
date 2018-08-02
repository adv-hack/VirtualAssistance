using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Linq;

namespace Consensus.Finance
{
    /// <summary>
    ///     Represents the "Booking_Terms" data structure.
    /// </summary>
    /// <remarks>
    ///     THIS CODE HAS BEEN AUTOMATICALLY GENERATED USING THE CONSENSUS DEVELOPER TOOLS.
    ///     DO NOT EDIT THIS CODE AS ANY CUSTOM MODIFICATIONS WILL BE LOST UPON REGENERATION.
    /// </remarks>
    public class BookingTermsRecord : Record<String>, Cloneable<BookingTermsRecord>, IEquatable<BookingTermsRecord>
    {
        #region fields

        /// <summary>
        ///     the value of the "BKT_LOCK" field.
        /// </summary>
        private String _lock;

        /// <summary>
        ///     the value of the "BKT_ADD_DATE" field.
        /// </summary>
        private DateTime? _addDate;

        /// <summary>
        ///     the value of the "BKT_ADD_BY" field.
        /// </summary>
        private String _addBy;

        /// <summary>
        ///     the value of the "BKT_MOD_DATE" field.
        /// </summary>
        private DateTime? _modDate;

        /// <summary>
        ///     the value of the "BKT_MOD_BY" field.
        /// </summary>
        private String _modBy;

        /// <summary>
        ///     the value of the "BKT_RCV_DATE" field.
        /// </summary>
        private DateTime? _rcvDate;

        /// <summary>
        ///     the value of the "BKT_RCV_FROM" field.
        /// </summary>
        private String _rcvFrom;

        /// <summary>
        ///     the value of the "BKT_FT_CAN_CH_TH" field.
        /// </summary>
        private Int32? _ftCanChTh;

        /// <summary>
        ///     the value of the "BKT_SD_CAN_CH_TH" field.
        /// </summary>
        private Int32? _sdCanChTh;

        /// <summary>
        ///     the value of the "BKT_CAN_CHG_PRCN" field.
        /// </summary>
        private Double? _canChgPrcn;

        /// <summary>
        ///     the value of the "BKT_FT_TRN_CH_TH" field.
        /// </summary>
        private Int32? _ftTrnChTh;

        /// <summary>
        ///     the value of the "BKT_TRAN_CH_PRCN" field.
        /// </summary>
        private Double? _tranChPrcn;

        /// <summary>
        ///     the value of the "BKT_XT_MV_CH_PRCN" field.
        /// </summary>
        private Double? _xtMvChPrcn;

        /// <summary>
        ///     the value of the "BKT_DESCRIPTION" field.
        /// </summary>
        private String _description;

        /// <summary>
        ///     the value of the "BKT_CAN_CHG_PRCN2" field.
        /// </summary>
        private Double? _canChgPrcn2;

        /// <summary>
        ///     the value of the "BKT_CAN_CHG_PRCN3" field.
        /// </summary>
        private Double? _canChgPrcn3;

        /// <summary>
        ///     the value of the "BKT_3D_CAN_CH_TH" field.
        /// </summary>
        private Int32? _b3dCanChTh;

        /// <summary>
        ///     the value of the "BKT_SD_TRN_CH_TH" field.
        /// </summary>
        private Int32? _sdTrnChTh;

        /// <summary>
        ///     the value of the "BKT_3D_TRN_CH_TH" field.
        /// </summary>
        private Int32? _bdTrnChTh;

        /// <summary>
        ///     the value of the "BKT_TRAN_CH_PRCN2" field.
        /// </summary>
        private Double? _tranChPrcn2;

        /// <summary>
        ///     the value of the "BKT_TRAN_CH_PRCN3" field.
        /// </summary>
        private Double? _tranChPrcn3;

        /// <summary>
        ///     the value of the "BKT_CAN_CHG_FX1" field.
        /// </summary>
        private Double? _canChgFx1;

        /// <summary>
        ///     the value of the "BKT_CAN_CHG_FX2" field.
        /// </summary>
        private Double? _canChgFx2;

        /// <summary>
        ///     the value of the "BKT_CAN_CHG_FX3" field.
        /// </summary>
        private Double? _canChgFx3;

        /// <summary>
        ///     the value of the "BKT_TRAN_CH_FX1" field.
        /// </summary>
        private Double? _tranChFx1;

        /// <summary>
        ///     the value of the "BKT_TRAN_CH_FX2" field.
        /// </summary>
        private Double? _tranChFx2;

        /// <summary>
        ///     the value of the "BKT_TRAN_CH_FX3" field.
        /// </summary>
        private Double? _tranChFx3;

        /// <summary>
        ///     the value of the "BKT_CURRENCY" field.
        /// </summary>
        private String _currency;

        /// <summary>
        ///     the value of the "BKT_NOTE_HTML" field.
        /// </summary>
        private String _noteHtml;

        /// <summary>
        ///     the value of the "BKT_CAN_CHG_BC" field.
        /// </summary>
        private Decimal? _canChgBc;

        /// <summary>
        ///     the value of the "BKT_CAN_CHG_BC2" field.
        /// </summary>
        private Decimal? _canChgBc2;

        /// <summary>
        ///     the value of the "BKT_CAN_CHG_BC3" field.
        /// </summary>
        private Decimal? _canChgBc3;

        /// <summary>
        ///     the value of the "BKT_TRAN_CHG_BC" field.
        /// </summary>
        private Decimal? _tranChgBc;

        /// <summary>
        ///     the value of the "BKT_TRAN_CHG_BC2" field.
        /// </summary>
        private Decimal? _tranChgBc2;

        /// <summary>
        ///     the value of the "BKT_TRAN_CHG_BC3" field.
        /// </summary>
        private Decimal? _tranChgBc3;

        /// <summary>
        ///     the value of the "BKT_SUB_CHG_BC" field.
        /// </summary>
        private Decimal? _subChgBc;

        /// <summary>
        ///     the value of the "BKT_SUB_CHG_BC2" field.
        /// </summary>
        private Decimal? _subChgBc2;

        /// <summary>
        ///     the value of the "BKT_SUB_CHG_BC3" field.
        /// </summary>
        private Decimal? _subChgBc3;

        /// <summary>
        ///     the value of the "BKT_SUB_CH_PRCN" field.
        /// </summary>
        private Decimal? _subChPrcn;

        /// <summary>
        ///     the value of the "BKT_SUB_CH_PRCN2" field.
        /// </summary>
        private Decimal? _subChPrcn2;

        /// <summary>
        ///     the value of the "BKT_SUB_CH_PRCN3" field.
        /// </summary>
        private Decimal? _subChPrcn3;

        /// <summary>
        ///     the value of the "BKT_FT_SUB_CH_TH" field.
        /// </summary>
        private Int32? _ftSubChTh;

        /// <summary>
        ///     the value of the "BKT_SD_SUB_CH_TH" field.
        /// </summary>
        private Int32? _sdSubChTh;

        /// <summary>
        ///     the value of the "BKT_3D_SUB_CH_TH" field.
        /// </summary>
        private Int32? _b3dSubChTh;

        /// <summary>
        ///     the value of the "BKT_TRN_NO_CHG" field.
        /// </summary>
        private Int32? _trnNoChg;

        /// <summary>
        ///     the value of the "BKT_SUB_NO_CHG" field.
        /// </summary>
        private Int32? _subNoChg;

        /// <summary>
        ///     the value of the "BKT_TRN_NO_CHG_PRCN" field.
        /// </summary>
        private Double? _trnNoChgPrcn;

        /// <summary>
        ///     the value of the "BKT_TRN_NO_CHG_BC" field.
        /// </summary>
        private Decimal? _trnNoChgBc;

        /// <summary>
        ///     the value of the "BKT_SUB_NO_CHG_PRCN" field.
        /// </summary>
        private Double? _subNoChgPrcn;

        /// <summary>
        ///     the value of the "BKT_SUB_NO_CHG_BC" field.
        /// </summary>
        private Decimal? _subNoChgBc;

        /// <summary>
        ///     the value of the "BKT_QUAL_CAN_CHG_PRCN" field.
        /// </summary>
        private Double? _qualCanChgPrcn;

        /// <summary>
        ///     the value of the "BKT_TRN_ADMIN_FEE" field.
        /// </summary>
        private Decimal? _trnAdminFee;

        /// <summary>
        ///     the value of the "BKT_SUB_ADMIN_FEE" field.
        /// </summary>
        private Decimal? _subAdminFee;

        /// <summary>
        ///     the value of the "BKT_TRN_ADMIN_TH" field.
        /// </summary>
        private Int32? _trnAdminTh;

        /// <summary>
        ///     the value of the "BKT_SUB_ADMIN_TH" field.
        /// </summary>
        private Int32? _subAdminTh;

        /// <summary>
        ///     the value of the "BKT_PENALTY_CALC" field.
        /// </summary>
        private Byte _penaltyCalc;

        /// <summary>
        ///     the value of the "BKT_04_CAN_CH_TH" field.
        /// </summary>
        private Int32? _b04CanChTh;

        /// <summary>
        ///     the value of the "BKT_05_CAN_CH_TH" field.
        /// </summary>
        private Int32? _b05CanChTh;

        /// <summary>
        ///     the value of the "BKT_CAN_CHG_PRCN4" field.
        /// </summary>
        private Double? _canChgPrcn4;

        /// <summary>
        ///     the value of the "BKT_CAN_CHG_PRCN5" field.
        /// </summary>
        private Double? _canChgPrcn5;

        /// <summary>
        ///     the value of the "BKT_CAN_CHG_BC4" field.
        /// </summary>
        private Decimal? _canChgBc4;

        /// <summary>
        ///     the value of the "BKT_CAN_CHG_BC5" field.
        /// </summary>
        private Decimal? _canChgBc5;

        /// <summary>
        ///     the value of the "BKT_04_TRN_CH_TH" field.
        /// </summary>
        private Int32? _b04TrnChTh;

        /// <summary>
        ///     the value of the "BKT_05_TRN_CH_TH" field.
        /// </summary>
        private Int32? _b05TrnChTh;

        /// <summary>
        ///     the value of the "BKT_TRAN_CH_PRCN4" field.
        /// </summary>
        private Double? _tranChPrcn4;

        /// <summary>
        ///     the value of the "BKT_TRAN_CH_PRCN5" field.
        /// </summary>
        private Double? _tranChPrcn5;

        /// <summary>
        ///     the value of the "BKT_TRAN_CHG_BC4" field.
        /// </summary>
        private Decimal? _tranChgBc4;

        /// <summary>
        ///     the value of the "BKT_TRAN_CHG_BC5" field.
        /// </summary>
        private Decimal? _tranChgBc5;

        /// <summary>
        ///     the value of the "BKT_04_SUB_CH_TH" field.
        /// </summary>
        private Int32? _b04SubChTh;

        /// <summary>
        ///     the value of the "BKT_05_SUB_CH_TH" field.
        /// </summary>
        private Int32? _b05SubChTh;

        /// <summary>
        ///     the value of the "BKT_SUB_CH_PRCN4" field.
        /// </summary>
        private Double? _subChPrcn4;

        /// <summary>
        ///     the value of the "BKT_SUB_CH_PRCN5" field.
        /// </summary>
        private Double? _subChPrcn5;

        /// <summary>
        ///     the value of the "BKT_SUB_CHG_BC4" field.
        /// </summary>
        private Decimal? _subChgBc4;

        /// <summary>
        ///     the value of the "BKT_SUB_CHG_BC5" field.
        /// </summary>
        private Decimal? _subChgBc5;

        /// <summary>
        ///     the value of the "BKT_COST_CODE" field.
        /// </summary>
        private String _costCode;

        /// <summary>
        ///     the value of the "BKT_REV_CODE" field.
        /// </summary>
        private String _revCode;

        #endregion

        #region properties

        /// <summary>
        ///     the value of the "BKT_LOCK" field.
        /// </summary>
        public String Lock
        {
            get { return _lock; }
            set { _lock = value; }
        }

        /// <summary>
        ///     the value of the "BKT_ADD_DATE" field.
        /// </summary>
        public DateTime? AddDate
        {
            get { return _addDate; }
            set { _addDate = value; }
        }

        /// <summary>
        ///     the value of the "BKT_ADD_BY" field.
        /// </summary>
        public String AddBy
        {
            get { return _addBy; }
            set { _addBy = value; }
        }

        /// <summary>
        ///     the value of the "BKT_MOD_DATE" field.
        /// </summary>
        public DateTime? ModDate
        {
            get { return _modDate; }
            set { _modDate = value; }
        }

        /// <summary>
        ///     the value of the "BKT_MOD_BY" field.
        /// </summary>
        public String ModBy
        {
            get { return _modBy; }
            set { _modBy = value; }
        }

        /// <summary>
        ///     the value of the "BKT_RCV_DATE" field.
        /// </summary>
        public DateTime? RcvDate
        {
            get { return _rcvDate; }
            set { _rcvDate = value; }
        }

        /// <summary>
        ///     the value of the "BKT_RCV_FROM" field.
        /// </summary>
        public String RcvFrom
        {
            get { return _rcvFrom; }
            set { _rcvFrom = value; }
        }

        /// <summary>
        ///     the value of the "BKT_FT_CAN_CH_TH" field.
        /// </summary>
        public Int32? FtCanChTh
        {
            get { return _ftCanChTh; }
            set { _ftCanChTh = value; }
        }

        /// <summary>
        ///     the value of the "BKT_SD_CAN_CH_TH" field.
        /// </summary>
        public Int32? SdCanChTh
        {
            get { return _sdCanChTh; }
            set { _sdCanChTh = value; }
        }

        /// <summary>
        ///     the value of the "BKT_CAN_CHG_PRCN" field.
        /// </summary>
        public Double? CanChgPrcn
        {
            get { return _canChgPrcn; }
            set { _canChgPrcn = value; }
        }

        /// <summary>
        ///     the value of the "BKT_FT_TRN_CH_TH" field.
        /// </summary>
        public Int32? FtTrnChTh
        {
            get { return _ftTrnChTh; }
            set { _ftTrnChTh = value; }
        }

        /// <summary>
        ///     the value of the "BKT_TRAN_CH_PRCN" field.
        /// </summary>
        public Double? TranChPrcn
        {
            get { return _tranChPrcn; }
            set { _tranChPrcn = value; }
        }

        /// <summary>
        ///     the value of the "BKT_XT_MV_CH_PRCN" field.
        /// </summary>
        public Double? XtMvChPrcn
        {
            get { return _xtMvChPrcn; }
            set { _xtMvChPrcn = value; }
        }

        /// <summary>
        ///     the value of the "BKT_DESCRIPTION" field.
        /// </summary>
        public String Description
        {
            get { return _description; }
            set { _description = value; }
        }

        /// <summary>
        ///     the value of the "BKT_CAN_CHG_PRCN2" field.
        /// </summary>
        public Double? CanChgPrcn2
        {
            get { return _canChgPrcn2; }
            set { _canChgPrcn2 = value; }
        }

        /// <summary>
        ///     the value of the "BKT_CAN_CHG_PRCN3" field.
        /// </summary>
        public Double? CanChgPrcn3
        {
            get { return _canChgPrcn3; }
            set { _canChgPrcn3 = value; }
        }

        /// <summary>
        ///     the value of the "BKT_3D_CAN_CH_TH" field.
        /// </summary>
        public Int32? B3dCanChTh
        {
            get { return _b3dCanChTh; }
            set { _b3dCanChTh = value; }
        }

        /// <summary>
        ///     the value of the "BKT_SD_TRN_CH_TH" field.
        /// </summary>
        public Int32? SdTrnChTh
        {
            get { return _sdTrnChTh; }
            set { _sdTrnChTh = value; }
        }

        /// <summary>
        ///     the value of the "BKT_3D_TRN_CH_TH" field.
        /// </summary>
        public Int32? BdTrnChTh
        {
            get { return _bdTrnChTh; }
            set { _bdTrnChTh = value; }
        }

        /// <summary>
        ///     the value of the "BKT_TRAN_CH_PRCN2" field.
        /// </summary>
        public Double? TranChPrcn2
        {
            get { return _tranChPrcn2; }
            set { _tranChPrcn2 = value; }
        }

        /// <summary>
        ///     the value of the "BKT_TRAN_CH_PRCN3" field.
        /// </summary>
        public Double? TranChPrcn3
        {
            get { return _tranChPrcn3; }
            set { _tranChPrcn3 = value; }
        }

        /// <summary>
        ///     the value of the "BKT_CAN_CHG_FX1" field.
        /// </summary>
        public Double? CanChgFx1
        {
            get { return _canChgFx1; }
            set { _canChgFx1 = value; }
        }

        /// <summary>
        ///     the value of the "BKT_CAN_CHG_FX2" field.
        /// </summary>
        public Double? CanChgFx2
        {
            get { return _canChgFx2; }
            set { _canChgFx2 = value; }
        }

        /// <summary>
        ///     the value of the "BKT_CAN_CHG_FX3" field.
        /// </summary>
        public Double? CanChgFx3
        {
            get { return _canChgFx3; }
            set { _canChgFx3 = value; }
        }

        /// <summary>
        ///     the value of the "BKT_TRAN_CH_FX1" field.
        /// </summary>
        public Double? TranChFx1
        {
            get { return _tranChFx1; }
            set { _tranChFx1 = value; }
        }

        /// <summary>
        ///     the value of the "BKT_TRAN_CH_FX2" field.
        /// </summary>
        public Double? TranChFx2
        {
            get { return _tranChFx2; }
            set { _tranChFx2 = value; }
        }

        /// <summary>
        ///     the value of the "BKT_TRAN_CH_FX3" field.
        /// </summary>
        public Double? TranChFx3
        {
            get { return _tranChFx3; }
            set { _tranChFx3 = value; }
        }

        /// <summary>
        ///     the value of the "BKT_CURRENCY" field.
        /// </summary>
        public String Currency
        {
            get { return _currency; }
            set { _currency = value; }
        }

        /// <summary>
        ///     the value of the "BKT_NOTE_HTML" field.
        /// </summary>
        public String NoteHtml
        {
            get { return _noteHtml; }
            set { _noteHtml = value; }
        }

        /// <summary>
        ///     the value of the "BKT_CAN_CHG_BC" field.
        /// </summary>
        public Decimal? CanChgBc
        {
            get { return _canChgBc; }
            set { _canChgBc = value; }
        }

        /// <summary>
        ///     the value of the "BKT_CAN_CHG_BC2" field.
        /// </summary>
        public Decimal? CanChgBc2
        {
            get { return _canChgBc2; }
            set { _canChgBc2 = value; }
        }

        /// <summary>
        ///     the value of the "BKT_CAN_CHG_BC3" field.
        /// </summary>
        public Decimal? CanChgBc3
        {
            get { return _canChgBc3; }
            set { _canChgBc3 = value; }
        }

        /// <summary>
        ///     the value of the "BKT_TRAN_CHG_BC" field.
        /// </summary>
        public Decimal? TranChgBc
        {
            get { return _tranChgBc; }
            set { _tranChgBc = value; }
        }

        /// <summary>
        ///     the value of the "BKT_TRAN_CHG_BC2" field.
        /// </summary>
        public Decimal? TranChgBc2
        {
            get { return _tranChgBc2; }
            set { _tranChgBc2 = value; }
        }

        /// <summary>
        ///     the value of the "BKT_TRAN_CHG_BC3" field.
        /// </summary>
        public Decimal? TranChgBc3
        {
            get { return _tranChgBc3; }
            set { _tranChgBc3 = value; }
        }

        /// <summary>
        ///     the value of the "BKT_SUB_CHG_BC" field.
        /// </summary>
        public Decimal? SubChgBc
        {
            get { return _subChgBc; }
            set { _subChgBc = value; }
        }

        /// <summary>
        ///     the value of the "BKT_SUB_CHG_BC2" field.
        /// </summary>
        public Decimal? SubChgBc2
        {
            get { return _subChgBc2; }
            set { _subChgBc2 = value; }
        }

        /// <summary>
        ///     the value of the "BKT_SUB_CHG_BC3" field.
        /// </summary>
        public Decimal? SubChgBc3
        {
            get { return _subChgBc3; }
            set { _subChgBc3 = value; }
        }

        /// <summary>
        ///     the value of the "BKT_SUB_CH_PRCN" field.
        /// </summary>
        public Decimal? SubChPrcn
        {
            get { return _subChPrcn; }
            set { _subChPrcn = value; }
        }

        /// <summary>
        ///     the value of the "BKT_SUB_CH_PRCN2" field.
        /// </summary>
        public Decimal? SubChPrcn2
        {
            get { return _subChPrcn2; }
            set { _subChPrcn2 = value; }
        }

        /// <summary>
        ///     the value of the "BKT_SUB_CH_PRCN3" field.
        /// </summary>
        public Decimal? SubChPrcn3
        {
            get { return _subChPrcn3; }
            set { _subChPrcn3 = value; }
        }

        /// <summary>
        ///     the value of the "BKT_FT_SUB_CH_TH" field.
        /// </summary>
        public Int32? FtSubChTh
        {
            get { return _ftSubChTh; }
            set { _ftSubChTh = value; }
        }

        /// <summary>
        ///     the value of the "BKT_SD_SUB_CH_TH" field.
        /// </summary>
        public Int32? SdSubChTh
        {
            get { return _sdSubChTh; }
            set { _sdSubChTh = value; }
        }

        /// <summary>
        ///     the value of the "BKT_3D_SUB_CH_TH" field.
        /// </summary>
        public Int32? B3dSubChTh
        {
            get { return _b3dSubChTh; }
            set { _b3dSubChTh = value; }
        }

        /// <summary>
        ///     the value of the "BKT_TRN_NO_CHG" field.
        /// </summary>
        public Int32? TrnNoChg
        {
            get { return _trnNoChg; }
            set { _trnNoChg = value; }
        }

        /// <summary>
        ///     the value of the "BKT_SUB_NO_CHG" field.
        /// </summary>
        public Int32? SubNoChg
        {
            get { return _subNoChg; }
            set { _subNoChg = value; }
        }

        /// <summary>
        ///     the value of the "BKT_TRN_NO_CHG_PRCN" field.
        /// </summary>
        public Double? TrnNoChgPrcn
        {
            get { return _trnNoChgPrcn; }
            set { _trnNoChgPrcn = value; }
        }

        /// <summary>
        ///     the value of the "BKT_TRN_NO_CHG_BC" field.
        /// </summary>
        public Decimal? TrnNoChgBc
        {
            get { return _trnNoChgBc; }
            set { _trnNoChgBc = value; }
        }

        /// <summary>
        ///     the value of the "BKT_SUB_NO_CHG_PRCN" field.
        /// </summary>
        public Double? SubNoChgPrcn
        {
            get { return _subNoChgPrcn; }
            set { _subNoChgPrcn = value; }
        }

        /// <summary>
        ///     the value of the "BKT_SUB_NO_CHG_BC" field.
        /// </summary>
        public Decimal? SubNoChgBc
        {
            get { return _subNoChgBc; }
            set { _subNoChgBc = value; }
        }

        /// <summary>
        ///     the value of the "BKT_QUAL_CAN_CHG_PRCN" field.
        /// </summary>
        public Double? QualCanChgPrcn
        {
            get { return _qualCanChgPrcn; }
            set { _qualCanChgPrcn = value; }
        }

        /// <summary>
        ///     the value of the "BKT_TRN_ADMIN_FEE" field.
        /// </summary>
        public Decimal? TrnAdminFee
        {
            get { return _trnAdminFee; }
            set { _trnAdminFee = value; }
        }

        /// <summary>
        ///     the value of the "BKT_SUB_ADMIN_FEE" field.
        /// </summary>
        public Decimal? SubAdminFee
        {
            get { return _subAdminFee; }
            set { _subAdminFee = value; }
        }

        /// <summary>
        ///     the value of the "BKT_TRN_ADMIN_TH" field.
        /// </summary>
        public Int32? TrnAdminTh
        {
            get { return _trnAdminTh; }
            set { _trnAdminTh = value; }
        }

        /// <summary>
        ///     the value of the "BKT_SUB_ADMIN_TH" field.
        /// </summary>
        public Int32? SubAdminTh
        {
            get { return _subAdminTh; }
            set { _subAdminTh = value; }
        }

        /// <summary>
        ///     the value of the "BKT_PENALTY_CALC" field.
        /// </summary>
        public Byte PenaltyCalc
        {
            get { return _penaltyCalc; }
            set { _penaltyCalc = value; }
        }

        /// <summary>
        ///     the value of the "BKT_04_CAN_CH_TH" field.
        /// </summary>
        public Int32? B04CanChTh
        {
            get { return _b04CanChTh; }
            set { _b04CanChTh = value; }
        }

        /// <summary>
        ///     the value of the "BKT_05_CAN_CH_TH" field.
        /// </summary>
        public Int32? B05CanChTh
        {
            get { return _b05CanChTh; }
            set { _b05CanChTh = value; }
        }

        /// <summary>
        ///     the value of the "BKT_CAN_CHG_PRCN4" field.
        /// </summary>
        public Double? CanChgPrcn4
        {
            get { return _canChgPrcn4; }
            set { _canChgPrcn4 = value; }
        }

        /// <summary>
        ///     the value of the "BKT_CAN_CHG_PRCN5" field.
        /// </summary>
        public Double? CanChgPrcn5
        {
            get { return _canChgPrcn5; }
            set { _canChgPrcn5 = value; }
        }

        /// <summary>
        ///     the value of the "BKT_CAN_CHG_BC4" field.
        /// </summary>
        public Decimal? CanChgBc4
        {
            get { return _canChgBc4; }
            set { _canChgBc4 = value; }
        }

        /// <summary>
        ///     the value of the "BKT_CAN_CHG_BC5" field.
        /// </summary>
        public Decimal? CanChgBc5
        {
            get { return _canChgBc5; }
            set { _canChgBc5 = value; }
        }

        /// <summary>
        ///     the value of the "BKT_04_TRN_CH_TH" field.
        /// </summary>
        public Int32? B04TrnChTh
        {
            get { return _b04TrnChTh; }
            set { _b04TrnChTh = value; }
        }

        /// <summary>
        ///     the value of the "BKT_05_TRN_CH_TH" field.
        /// </summary>
        public Int32? B05TrnChTh
        {
            get { return _b05TrnChTh; }
            set { _b05TrnChTh = value; }
        }

        /// <summary>
        ///     the value of the "BKT_TRAN_CH_PRCN4" field.
        /// </summary>
        public Double? TranChPrcn4
        {
            get { return _tranChPrcn4; }
            set { _tranChPrcn4 = value; }
        }

        /// <summary>
        ///     the value of the "BKT_TRAN_CH_PRCN5" field.
        /// </summary>
        public Double? TranChPrcn5
        {
            get { return _tranChPrcn5; }
            set { _tranChPrcn5 = value; }
        }

        /// <summary>
        ///     the value of the "BKT_TRAN_CHG_BC4" field.
        /// </summary>
        public Decimal? TranChgBc4
        {
            get { return _tranChgBc4; }
            set { _tranChgBc4 = value; }
        }

        /// <summary>
        ///     the value of the "BKT_TRAN_CHG_BC5" field.
        /// </summary>
        public Decimal? TranChgBc5
        {
            get { return _tranChgBc5; }
            set { _tranChgBc5 = value; }
        }

        /// <summary>
        ///     the value of the "BKT_04_SUB_CH_TH" field.
        /// </summary>
        public Int32? B04SubChTh
        {
            get { return _b04SubChTh; }
            set { _b04SubChTh = value; }
        }

        /// <summary>
        ///     the value of the "BKT_05_SUB_CH_TH" field.
        /// </summary>
        public Int32? B05SubChTh
        {
            get { return _b05SubChTh; }
            set { _b05SubChTh = value; }
        }

        /// <summary>
        ///     the value of the "BKT_SUB_CH_PRCN4" field.
        /// </summary>
        public Double? SubChPrcn4
        {
            get { return _subChPrcn4; }
            set { _subChPrcn4 = value; }
        }

        /// <summary>
        ///     the value of the "BKT_SUB_CH_PRCN5" field.
        /// </summary>
        public Double? SubChPrcn5
        {
            get { return _subChPrcn5; }
            set { _subChPrcn5 = value; }
        }

        /// <summary>
        ///     the value of the "BKT_SUB_CHG_BC4" field.
        /// </summary>
        public Decimal? SubChgBc4
        {
            get { return _subChgBc4; }
            set { _subChgBc4 = value; }
        }

        /// <summary>
        ///     the value of the "BKT_SUB_CHG_BC5" field.
        /// </summary>
        public Decimal? SubChgBc5
        {
            get { return _subChgBc5; }
            set { _subChgBc5 = value; }
        }

        /// <summary>
        ///     the value of the "BKT_COST_CODE" field.
        /// </summary>
        public String CostCode
        {
            get { return _costCode; }
            set { _costCode = value; }
        }

        /// <summary>
        ///     the value of the "BKT_REV_CODE" field.
        /// </summary>
        public String RevCode
        {
            get { return _revCode; }
            set { _revCode = value; }
        }

        #endregion

        #region methods

        /// <summary>
        ///     Creates a new <see cref="BookingTermsRecord" /> object instance that is a shallow-copy of the current object instance.
        /// </summary>
        /// <returns>
        ///     The shallow-copy of the current <see cref="BookingTermsRecord" /> object instance.
        /// </returns>
        public BookingTermsRecord Clone()
        {
            BookingTermsRecord record = new BookingTermsRecord();
            record.Id = this.Id;
            record.Lock = this.Lock;
            record.AddDate = this.AddDate;
            record.AddBy = this.AddBy;
            record.ModDate = this.ModDate;
            record.ModBy = this.ModBy;
            record.RcvDate = this.RcvDate;
            record.RcvFrom = this.RcvFrom;
            record.FtCanChTh = this.FtCanChTh;
            record.SdCanChTh = this.SdCanChTh;
            record.CanChgPrcn = this.CanChgPrcn;
            record.FtTrnChTh = this.FtTrnChTh;
            record.TranChPrcn = this.TranChPrcn;
            record.XtMvChPrcn = this.XtMvChPrcn;
            record.Description = this.Description;
            record.CanChgPrcn2 = this.CanChgPrcn2;
            record.CanChgPrcn3 = this.CanChgPrcn3;
            record.B3dCanChTh = this.B3dCanChTh;
            record.SdTrnChTh = this.SdTrnChTh;
            record.BdTrnChTh = this.BdTrnChTh;
            record.TranChPrcn2 = this.TranChPrcn2;
            record.TranChPrcn3 = this.TranChPrcn3;
            record.CanChgFx1 = this.CanChgFx1;
            record.CanChgFx2 = this.CanChgFx2;
            record.CanChgFx3 = this.CanChgFx3;
            record.TranChFx1 = this.TranChFx1;
            record.TranChFx2 = this.TranChFx2;
            record.TranChFx3 = this.TranChFx3;
            record.Currency = this.Currency;
            record.NoteHtml = this.NoteHtml;
            record.CanChgBc = this.CanChgBc;
            record.CanChgBc2 = this.CanChgBc2;
            record.CanChgBc3 = this.CanChgBc3;
            record.TranChgBc = this.TranChgBc;
            record.TranChgBc2 = this.TranChgBc2;
            record.TranChgBc3 = this.TranChgBc3;
            record.SubChgBc = this.SubChgBc;
            record.SubChgBc2 = this.SubChgBc2;
            record.SubChgBc3 = this.SubChgBc3;
            record.SubChPrcn = this.SubChPrcn;
            record.SubChPrcn2 = this.SubChPrcn2;
            record.SubChPrcn3 = this.SubChPrcn3;
            record.FtSubChTh = this.FtSubChTh;
            record.SdSubChTh = this.SdSubChTh;
            record.B3dSubChTh = this.B3dSubChTh;
            record.TrnNoChg = this.TrnNoChg;
            record.SubNoChg = this.SubNoChg;
            record.TrnNoChgPrcn = this.TrnNoChgPrcn;
            record.TrnNoChgBc = this.TrnNoChgBc;
            record.SubNoChgPrcn = this.SubNoChgPrcn;
            record.SubNoChgBc = this.SubNoChgBc;
            record.QualCanChgPrcn = this.QualCanChgPrcn;
            record.TrnAdminFee = this.TrnAdminFee;
            record.SubAdminFee = this.SubAdminFee;
            record.TrnAdminTh = this.TrnAdminTh;
            record.SubAdminTh = this.SubAdminTh;
            record.PenaltyCalc = this.PenaltyCalc;
            record.B04CanChTh = this.B04CanChTh;
            record.B05CanChTh = this.B05CanChTh;
            record.CanChgPrcn4 = this.CanChgPrcn4;
            record.CanChgPrcn5 = this.CanChgPrcn5;
            record.CanChgBc4 = this.CanChgBc4;
            record.CanChgBc5 = this.CanChgBc5;
            record.B04TrnChTh = this.B04TrnChTh;
            record.B05TrnChTh = this.B05TrnChTh;
            record.TranChPrcn4 = this.TranChPrcn4;
            record.TranChPrcn5 = this.TranChPrcn5;
            record.TranChgBc4 = this.TranChgBc4;
            record.TranChgBc5 = this.TranChgBc5;
            record.B04SubChTh = this.B04SubChTh;
            record.B05SubChTh = this.B05SubChTh;
            record.SubChPrcn4 = this.SubChPrcn4;
            record.SubChPrcn5 = this.SubChPrcn5;
            record.SubChgBc4 = this.SubChgBc4;
            record.SubChgBc5 = this.SubChgBc5;
            record.CostCode = this.CostCode;
            record.RevCode = this.RevCode;
            return record;
        }

        /// <summary>
        ///     Indicates whether the current <see cref="BookingTermsRecord" /> instance is equal to another <see cref="BookingTermsRecord" /> instance.
        /// </summary>
        /// <param name="that">
        ///     The <see cref="BookingTermsRecord" /> instance to be compared against this instance.
        /// </param>
        /// <returns>
        ///     True if both instances are considered equal; otherwise, false.
        /// </returns>
        public Boolean Equals(BookingTermsRecord that)
        {
            Boolean result = true;
            result = result && (this.Id.TrimOrNullify() == that.Id.TrimOrNullify());
            result = result && (this.Lock.TrimOrNullify() == that.Lock.TrimOrNullify());
            result = result && (this.FtCanChTh == that.FtCanChTh);
            result = result && (this.SdCanChTh == that.SdCanChTh);
            result = result && (this.CanChgPrcn == that.CanChgPrcn);
            result = result && (this.FtTrnChTh == that.FtTrnChTh);
            result = result && (this.TranChPrcn == that.TranChPrcn);
            result = result && (this.XtMvChPrcn == that.XtMvChPrcn);
            result = result && (this.Description.TrimOrNullify() == that.Description.TrimOrNullify());
            result = result && (this.CanChgPrcn2 == that.CanChgPrcn2);
            result = result && (this.CanChgPrcn3 == that.CanChgPrcn3);
            result = result && (this.B3dCanChTh == that.B3dCanChTh);
            result = result && (this.SdTrnChTh == that.SdTrnChTh);
            result = result && (this.BdTrnChTh == that.BdTrnChTh);
            result = result && (this.TranChPrcn2 == that.TranChPrcn2);
            result = result && (this.TranChPrcn3 == that.TranChPrcn3);
            result = result && (this.CanChgFx1 == that.CanChgFx1);
            result = result && (this.CanChgFx2 == that.CanChgFx2);
            result = result && (this.CanChgFx3 == that.CanChgFx3);
            result = result && (this.TranChFx1 == that.TranChFx1);
            result = result && (this.TranChFx2 == that.TranChFx2);
            result = result && (this.TranChFx3 == that.TranChFx3);
            result = result && (this.Currency.TrimOrNullify() == that.Currency.TrimOrNullify());
            result = result && (this.NoteHtml.TrimOrNullify() == that.NoteHtml.TrimOrNullify());
            result = result && (this.CanChgBc == that.CanChgBc);
            result = result && (this.CanChgBc2 == that.CanChgBc2);
            result = result && (this.CanChgBc3 == that.CanChgBc3);
            result = result && (this.TranChgBc == that.TranChgBc);
            result = result && (this.TranChgBc2 == that.TranChgBc2);
            result = result && (this.TranChgBc3 == that.TranChgBc3);
            result = result && (this.SubChgBc == that.SubChgBc);
            result = result && (this.SubChgBc2 == that.SubChgBc2);
            result = result && (this.SubChgBc3 == that.SubChgBc3);
            result = result && (this.SubChPrcn == that.SubChPrcn);
            result = result && (this.SubChPrcn2 == that.SubChPrcn2);
            result = result && (this.SubChPrcn3 == that.SubChPrcn3);
            result = result && (this.FtSubChTh == that.FtSubChTh);
            result = result && (this.SdSubChTh == that.SdSubChTh);
            result = result && (this.B3dSubChTh == that.B3dSubChTh);
            result = result && (this.TrnNoChg == that.TrnNoChg);
            result = result && (this.SubNoChg == that.SubNoChg);
            result = result && (this.TrnNoChgPrcn == that.TrnNoChgPrcn);
            result = result && (this.TrnNoChgBc == that.TrnNoChgBc);
            result = result && (this.SubNoChgPrcn == that.SubNoChgPrcn);
            result = result && (this.SubNoChgBc == that.SubNoChgBc);
            result = result && (this.QualCanChgPrcn == that.QualCanChgPrcn);
            result = result && (this.TrnAdminFee == that.TrnAdminFee);
            result = result && (this.SubAdminFee == that.SubAdminFee);
            result = result && (this.TrnAdminTh == that.TrnAdminTh);
            result = result && (this.SubAdminTh == that.SubAdminTh);
            result = result && (this.PenaltyCalc == that.PenaltyCalc);
            result = result && (this.B04CanChTh == that.B04CanChTh);
            result = result && (this.B05CanChTh == that.B05CanChTh);
            result = result && (this.CanChgPrcn4 == that.CanChgPrcn4);
            result = result && (this.CanChgPrcn5 == that.CanChgPrcn5);
            result = result && (this.CanChgBc4 == that.CanChgBc4);
            result = result && (this.CanChgBc5 == that.CanChgBc5);
            result = result && (this.B04TrnChTh == that.B04TrnChTh);
            result = result && (this.B05TrnChTh == that.B05TrnChTh);
            result = result && (this.TranChPrcn4 == that.TranChPrcn4);
            result = result && (this.TranChPrcn5 == that.TranChPrcn5);
            result = result && (this.TranChgBc4 == that.TranChgBc4);
            result = result && (this.TranChgBc5 == that.TranChgBc5);
            result = result && (this.B04SubChTh == that.B04SubChTh);
            result = result && (this.B05SubChTh == that.B05SubChTh);
            result = result && (this.SubChPrcn4 == that.SubChPrcn4);
            result = result && (this.SubChPrcn5 == that.SubChPrcn5);
            result = result && (this.SubChgBc4 == that.SubChgBc4);
            result = result && (this.SubChgBc5 == that.SubChgBc5);
            result = result && (this.CostCode.TrimOrNullify() == that.CostCode.TrimOrNullify());
            result = result && (this.RevCode.TrimOrNullify() == that.RevCode.TrimOrNullify());
            return result;
        }

        #endregion
    }
}
