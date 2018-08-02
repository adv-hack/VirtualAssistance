using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Linq;

namespace Consensus.Contact
{
    /// <summary>
    ///     Represents the "Trainer" data structure.
    /// </summary>
    /// <remarks>
    ///     THIS CODE HAS BEEN AUTOMATICALLY GENERATED USING THE CONSENSUS DEVELOPER TOOLS.
    ///     DO NOT EDIT THIS CODE AS ANY CUSTOM MODIFICATIONS WILL BE LOST UPON REGENERATION.
    /// </remarks>
    public class TrainerRecord : Record<String>, Cloneable<TrainerRecord>, IEquatable<TrainerRecord>
    {
        #region fields

        /// <summary>
        ///     the value of the "TRAIN_LOCK" field.
        /// </summary>
        private String _ainLock;

        /// <summary>
        ///     the value of the "TRAIN_ADD_DATE" field.
        /// </summary>
        private DateTime? _ainAddDate;

        /// <summary>
        ///     the value of the "TRAIN_ADD_BY" field.
        /// </summary>
        private String _ainAddBy;

        /// <summary>
        ///     the value of the "TRAIN_MOD_DATE" field.
        /// </summary>
        private DateTime? _ainModDate;

        /// <summary>
        ///     the value of the "TRAIN_MOD_BY" field.
        /// </summary>
        private String _ainModBy;

        /// <summary>
        ///     the value of the "TRAIN_RCV_DATE" field.
        /// </summary>
        private DateTime? _ainRcvDate;

        /// <summary>
        ///     the value of the "TRAIN_RCV_FROM" field.
        /// </summary>
        private String _ainRcvFrom;

        /// <summary>
        ///     the value of the "TRAIN_PROLE_ID" field.
        /// </summary>
        private String _ainProleId;

        /// <summary>
        ///     the value of the "TRAIN_APP_ID" field.
        /// </summary>
        private String _ainAppId;

        /// <summary>
        ///     the value of the "TRAIN_START_DATE" field.
        /// </summary>
        private DateTime? _ainStartDate;

        /// <summary>
        ///     the value of the "TRAIN_STATUS" field.
        /// </summary>
        private String _ainStatus;

        /// <summary>
        ///     the value of the "TRAIN_REVIEW_DATE" field.
        /// </summary>
        private DateTime? _ainReviewDate;

        /// <summary>
        ///     the value of the "TRAIN_REF" field.
        /// </summary>
        private String _ainRef;

        /// <summary>
        ///     the value of the "TRAIN_COST" field.
        /// </summary>
        private Decimal? _ainCost;

        /// <summary>
        ///     the value of the "TRAIN_USERCHAR_1" field.
        /// </summary>
        private String _ainUserchar1;

        /// <summary>
        ///     the value of the "TRAIN_USERCHAR_2" field.
        /// </summary>
        private String _ainUserchar2;

        /// <summary>
        ///     the value of the "TRAIN_USERCHAR_3" field.
        /// </summary>
        private String _ainUserchar3;

        /// <summary>
        ///     the value of the "TRAIN_USERCHAR_4" field.
        /// </summary>
        private String _ainUserchar4;

        /// <summary>
        ///     the value of the "TRAIN_USERCHAR_5" field.
        /// </summary>
        private String _ainUserchar5;

        /// <summary>
        ///     the value of the "TRAIN_USERCHAR_6" field.
        /// </summary>
        private String _ainUserchar6;

        /// <summary>
        ///     the value of the "TRAIN_USERINT_1" field.
        /// </summary>
        private Byte? _ainUserint1;

        /// <summary>
        ///     the value of the "TRAIN_USERINT_2" field.
        /// </summary>
        private Byte? _ainUserint2;

        /// <summary>
        ///     the value of the "TRAIN_USERINT_3" field.
        /// </summary>
        private Byte? _ainUserint3;

        /// <summary>
        ///     the value of the "TRAIN_USERINT_4" field.
        /// </summary>
        private Byte? _ainUserint4;

        /// <summary>
        ///     the value of the "TRAIN_USERINT_5" field.
        /// </summary>
        private Byte? _ainUserint5;

        /// <summary>
        ///     the value of the "TRAIN_USERINT_6" field.
        /// </summary>
        private Byte? _ainUserint6;

        /// <summary>
        ///     the value of the "TRAIN_USERNUM_1" field.
        /// </summary>
        private Decimal? _ainUsernum1;

        /// <summary>
        ///     the value of the "TRAIN_USERNUM_2" field.
        /// </summary>
        private Decimal? _ainUsernum2;

        /// <summary>
        ///     the value of the "TRAIN_USERNUM_3" field.
        /// </summary>
        private Decimal? _ainUsernum3;

        /// <summary>
        ///     the value of the "TRAIN_USERNUM_4" field.
        /// </summary>
        private Decimal? _ainUsernum4;

        /// <summary>
        ///     the value of the "TRAIN_USERNUM_5" field.
        /// </summary>
        private Decimal? _ainUsernum5;

        /// <summary>
        ///     the value of the "TRAIN_USERNUM_6" field.
        /// </summary>
        private Decimal? _ainUsernum6;

        /// <summary>
        ///     the value of the "TRAIN_USERDATE_1" field.
        /// </summary>
        private DateTime? _ainUserdate1;

        /// <summary>
        ///     the value of the "TRAIN_USERDATE_2" field.
        /// </summary>
        private DateTime? _ainUserdate2;

        /// <summary>
        ///     the value of the "TRAIN_USERDATE_3" field.
        /// </summary>
        private DateTime? _ainUserdate3;

        /// <summary>
        ///     the value of the "TRAIN_USERDATE_4" field.
        /// </summary>
        private DateTime? _ainUserdate4;

        /// <summary>
        ///     the value of the "TRAIN_USERDATE_5" field.
        /// </summary>
        private DateTime? _ainUserdate5;

        /// <summary>
        ///     the value of the "TRAIN_USERDATE_6" field.
        /// </summary>
        private DateTime? _ainUserdate6;

        /// <summary>
        ///     the value of the "TRAIN_BIOG" field.
        /// </summary>
        private String _ainBiog;

        /// <summary>
        ///     the value of the "TRAIN_ATTRIB01" field.
        /// </summary>
        private String _ainAttrib01;

        /// <summary>
        ///     the value of the "TRAIN_DAY_COST" field.
        /// </summary>
        private Decimal _ainDayCost;

        /// <summary>
        ///     the value of the "TRAIN_HOUR_COST" field.
        /// </summary>
        private Decimal _ainHourCost;

        /// <summary>
        ///     the value of the "TRAIN_BASE_POSTCODE" field.
        /// </summary>
        private String _ainBasePostcode;

        /// <summary>
        ///     the value of the "TRAIN_BASE_LAT" field.
        /// </summary>
        private Decimal? _ainBaseLat;

        /// <summary>
        ///     the value of the "TRAIN_BASE_LONG" field.
        /// </summary>
        private Decimal? _ainBaseLong;

        /// <summary>
        ///     the value of the "TRAIN_SELCO_SP_ID" field.
        /// </summary>
        private String _ainSelcoSpId;

        /// <summary>
        ///     the value of the "TRAIN_INS_EXPIRY" field.
        /// </summary>
        private DateTime? _ainInsExpiry;

        /// <summary>
        ///     the value of the "TRN_UNIQUE_REF" field.
        /// </summary>
        private String _nUniqueRef;

        /// <summary>
        ///     the value of the "TRAIN_FEE_NOTES_TEXT_ID" field.
        /// </summary>
        private String _ainFeeNotesTextId;

        /// <summary>
        ///     the value of the "TRAIN_HOTEL_REQ_TEXT_ID" field.
        /// </summary>
        private String _ainHotelReqTextId;

        /// <summary>
        ///     the value of the "TRAIN_OTHER_INFO_TEXT_ID" field.
        /// </summary>
        private String _ainOtherInfoTextId;

        /// <summary>
        ///     the value of the "TRAIN_PASSWORD" field.
        /// </summary>
        private String _ainPassword;

        /// <summary>
        ///     the value of the "TRAIN_WEB" field.
        /// </summary>
        private Byte _ainWeb;

        /// <summary>
        ///     the value of the "TRAIN_BIOG_PIC_URL" field.
        /// </summary>
        private String _ainBiogPicUrl;

        /// <summary>
        ///     the value of the "TRAIN_SY_TYPE" field.
        /// </summary>
        private Int32 _ainSyType;

        #endregion

        #region properties

        /// <summary>
        ///     the value of the "TRAIN_LOCK" field.
        /// </summary>
        public String AinLock
        {
            get { return _ainLock; }
            set { _ainLock = value; }
        }

        /// <summary>
        ///     the value of the "TRAIN_ADD_DATE" field.
        /// </summary>
        public DateTime? AinAddDate
        {
            get { return _ainAddDate; }
            set { _ainAddDate = value; }
        }

        /// <summary>
        ///     the value of the "TRAIN_ADD_BY" field.
        /// </summary>
        public String AinAddBy
        {
            get { return _ainAddBy; }
            set { _ainAddBy = value; }
        }

        /// <summary>
        ///     the value of the "TRAIN_MOD_DATE" field.
        /// </summary>
        public DateTime? AinModDate
        {
            get { return _ainModDate; }
            set { _ainModDate = value; }
        }

        /// <summary>
        ///     the value of the "TRAIN_MOD_BY" field.
        /// </summary>
        public String AinModBy
        {
            get { return _ainModBy; }
            set { _ainModBy = value; }
        }

        /// <summary>
        ///     the value of the "TRAIN_RCV_DATE" field.
        /// </summary>
        public DateTime? AinRcvDate
        {
            get { return _ainRcvDate; }
            set { _ainRcvDate = value; }
        }

        /// <summary>
        ///     the value of the "TRAIN_RCV_FROM" field.
        /// </summary>
        public String AinRcvFrom
        {
            get { return _ainRcvFrom; }
            set { _ainRcvFrom = value; }
        }

        /// <summary>
        ///     the value of the "TRAIN_PROLE_ID" field.
        /// </summary>
        public String AinProleId
        {
            get { return _ainProleId; }
            set { _ainProleId = value; }
        }

        /// <summary>
        ///     the value of the "TRAIN_APP_ID" field.
        /// </summary>
        public String AinAppId
        {
            get { return _ainAppId; }
            set { _ainAppId = value; }
        }

        /// <summary>
        ///     the value of the "TRAIN_START_DATE" field.
        /// </summary>
        public DateTime? AinStartDate
        {
            get { return _ainStartDate; }
            set { _ainStartDate = value; }
        }

        /// <summary>
        ///     the value of the "TRAIN_STATUS" field.
        /// </summary>
        public String AinStatus
        {
            get { return _ainStatus; }
            set { _ainStatus = value; }
        }

        /// <summary>
        ///     the value of the "TRAIN_REVIEW_DATE" field.
        /// </summary>
        public DateTime? AinReviewDate
        {
            get { return _ainReviewDate; }
            set { _ainReviewDate = value; }
        }

        /// <summary>
        ///     the value of the "TRAIN_REF" field.
        /// </summary>
        public String AinRef
        {
            get { return _ainRef; }
            set { _ainRef = value; }
        }

        /// <summary>
        ///     the value of the "TRAIN_COST" field.
        /// </summary>
        public Decimal? AinCost
        {
            get { return _ainCost; }
            set { _ainCost = value; }
        }

        /// <summary>
        ///     the value of the "TRAIN_USERCHAR_1" field.
        /// </summary>
        public String AinUserchar1
        {
            get { return _ainUserchar1; }
            set { _ainUserchar1 = value; }
        }

        /// <summary>
        ///     the value of the "TRAIN_USERCHAR_2" field.
        /// </summary>
        public String AinUserchar2
        {
            get { return _ainUserchar2; }
            set { _ainUserchar2 = value; }
        }

        /// <summary>
        ///     the value of the "TRAIN_USERCHAR_3" field.
        /// </summary>
        public String AinUserchar3
        {
            get { return _ainUserchar3; }
            set { _ainUserchar3 = value; }
        }

        /// <summary>
        ///     the value of the "TRAIN_USERCHAR_4" field.
        /// </summary>
        public String AinUserchar4
        {
            get { return _ainUserchar4; }
            set { _ainUserchar4 = value; }
        }

        /// <summary>
        ///     the value of the "TRAIN_USERCHAR_5" field.
        /// </summary>
        public String AinUserchar5
        {
            get { return _ainUserchar5; }
            set { _ainUserchar5 = value; }
        }

        /// <summary>
        ///     the value of the "TRAIN_USERCHAR_6" field.
        /// </summary>
        public String AinUserchar6
        {
            get { return _ainUserchar6; }
            set { _ainUserchar6 = value; }
        }

        /// <summary>
        ///     the value of the "TRAIN_USERINT_1" field.
        /// </summary>
        public Byte? AinUserint1
        {
            get { return _ainUserint1; }
            set { _ainUserint1 = value; }
        }

        /// <summary>
        ///     the value of the "TRAIN_USERINT_2" field.
        /// </summary>
        public Byte? AinUserint2
        {
            get { return _ainUserint2; }
            set { _ainUserint2 = value; }
        }

        /// <summary>
        ///     the value of the "TRAIN_USERINT_3" field.
        /// </summary>
        public Byte? AinUserint3
        {
            get { return _ainUserint3; }
            set { _ainUserint3 = value; }
        }

        /// <summary>
        ///     the value of the "TRAIN_USERINT_4" field.
        /// </summary>
        public Byte? AinUserint4
        {
            get { return _ainUserint4; }
            set { _ainUserint4 = value; }
        }

        /// <summary>
        ///     the value of the "TRAIN_USERINT_5" field.
        /// </summary>
        public Byte? AinUserint5
        {
            get { return _ainUserint5; }
            set { _ainUserint5 = value; }
        }

        /// <summary>
        ///     the value of the "TRAIN_USERINT_6" field.
        /// </summary>
        public Byte? AinUserint6
        {
            get { return _ainUserint6; }
            set { _ainUserint6 = value; }
        }

        /// <summary>
        ///     the value of the "TRAIN_USERNUM_1" field.
        /// </summary>
        public Decimal? AinUsernum1
        {
            get { return _ainUsernum1; }
            set { _ainUsernum1 = value; }
        }

        /// <summary>
        ///     the value of the "TRAIN_USERNUM_2" field.
        /// </summary>
        public Decimal? AinUsernum2
        {
            get { return _ainUsernum2; }
            set { _ainUsernum2 = value; }
        }

        /// <summary>
        ///     the value of the "TRAIN_USERNUM_3" field.
        /// </summary>
        public Decimal? AinUsernum3
        {
            get { return _ainUsernum3; }
            set { _ainUsernum3 = value; }
        }

        /// <summary>
        ///     the value of the "TRAIN_USERNUM_4" field.
        /// </summary>
        public Decimal? AinUsernum4
        {
            get { return _ainUsernum4; }
            set { _ainUsernum4 = value; }
        }

        /// <summary>
        ///     the value of the "TRAIN_USERNUM_5" field.
        /// </summary>
        public Decimal? AinUsernum5
        {
            get { return _ainUsernum5; }
            set { _ainUsernum5 = value; }
        }

        /// <summary>
        ///     the value of the "TRAIN_USERNUM_6" field.
        /// </summary>
        public Decimal? AinUsernum6
        {
            get { return _ainUsernum6; }
            set { _ainUsernum6 = value; }
        }

        /// <summary>
        ///     the value of the "TRAIN_USERDATE_1" field.
        /// </summary>
        public DateTime? AinUserdate1
        {
            get { return _ainUserdate1; }
            set { _ainUserdate1 = value; }
        }

        /// <summary>
        ///     the value of the "TRAIN_USERDATE_2" field.
        /// </summary>
        public DateTime? AinUserdate2
        {
            get { return _ainUserdate2; }
            set { _ainUserdate2 = value; }
        }

        /// <summary>
        ///     the value of the "TRAIN_USERDATE_3" field.
        /// </summary>
        public DateTime? AinUserdate3
        {
            get { return _ainUserdate3; }
            set { _ainUserdate3 = value; }
        }

        /// <summary>
        ///     the value of the "TRAIN_USERDATE_4" field.
        /// </summary>
        public DateTime? AinUserdate4
        {
            get { return _ainUserdate4; }
            set { _ainUserdate4 = value; }
        }

        /// <summary>
        ///     the value of the "TRAIN_USERDATE_5" field.
        /// </summary>
        public DateTime? AinUserdate5
        {
            get { return _ainUserdate5; }
            set { _ainUserdate5 = value; }
        }

        /// <summary>
        ///     the value of the "TRAIN_USERDATE_6" field.
        /// </summary>
        public DateTime? AinUserdate6
        {
            get { return _ainUserdate6; }
            set { _ainUserdate6 = value; }
        }

        /// <summary>
        ///     the value of the "TRAIN_BIOG" field.
        /// </summary>
        public String AinBiog
        {
            get { return _ainBiog; }
            set { _ainBiog = value; }
        }

        /// <summary>
        ///     the value of the "TRAIN_ATTRIB01" field.
        /// </summary>
        public String AinAttrib01
        {
            get { return _ainAttrib01; }
            set { _ainAttrib01 = value; }
        }

        /// <summary>
        ///     the value of the "TRAIN_DAY_COST" field.
        /// </summary>
        public Decimal AinDayCost
        {
            get { return _ainDayCost; }
            set { _ainDayCost = value; }
        }

        /// <summary>
        ///     the value of the "TRAIN_HOUR_COST" field.
        /// </summary>
        public Decimal AinHourCost
        {
            get { return _ainHourCost; }
            set { _ainHourCost = value; }
        }

        /// <summary>
        ///     the value of the "TRAIN_BASE_POSTCODE" field.
        /// </summary>
        public String AinBasePostcode
        {
            get { return _ainBasePostcode; }
            set { _ainBasePostcode = value; }
        }

        /// <summary>
        ///     the value of the "TRAIN_BASE_LAT" field.
        /// </summary>
        public Decimal? AinBaseLat
        {
            get { return _ainBaseLat; }
            set { _ainBaseLat = value; }
        }

        /// <summary>
        ///     the value of the "TRAIN_BASE_LONG" field.
        /// </summary>
        public Decimal? AinBaseLong
        {
            get { return _ainBaseLong; }
            set { _ainBaseLong = value; }
        }

        /// <summary>
        ///     the value of the "TRAIN_SELCO_SP_ID" field.
        /// </summary>
        public String AinSelcoSpId
        {
            get { return _ainSelcoSpId; }
            set { _ainSelcoSpId = value; }
        }

        /// <summary>
        ///     the value of the "TRAIN_INS_EXPIRY" field.
        /// </summary>
        public DateTime? AinInsExpiry
        {
            get { return _ainInsExpiry; }
            set { _ainInsExpiry = value; }
        }

        /// <summary>
        ///     the value of the "TRN_UNIQUE_REF" field.
        /// </summary>
        public String NUniqueRef
        {
            get { return _nUniqueRef; }
            set { _nUniqueRef = value; }
        }

        /// <summary>
        ///     the value of the "TRAIN_FEE_NOTES_TEXT_ID" field.
        /// </summary>
        public String AinFeeNotesTextId
        {
            get { return _ainFeeNotesTextId; }
            set { _ainFeeNotesTextId = value; }
        }

        /// <summary>
        ///     the value of the "TRAIN_HOTEL_REQ_TEXT_ID" field.
        /// </summary>
        public String AinHotelReqTextId
        {
            get { return _ainHotelReqTextId; }
            set { _ainHotelReqTextId = value; }
        }

        /// <summary>
        ///     the value of the "TRAIN_OTHER_INFO_TEXT_ID" field.
        /// </summary>
        public String AinOtherInfoTextId
        {
            get { return _ainOtherInfoTextId; }
            set { _ainOtherInfoTextId = value; }
        }

        /// <summary>
        ///     the value of the "TRAIN_PASSWORD" field.
        /// </summary>
        public String AinPassword
        {
            get { return _ainPassword; }
            set { _ainPassword = value; }
        }

        /// <summary>
        ///     the value of the "TRAIN_WEB" field.
        /// </summary>
        public Byte AinWeb
        {
            get { return _ainWeb; }
            set { _ainWeb = value; }
        }

        /// <summary>
        ///     the value of the "TRAIN_BIOG_PIC_URL" field.
        /// </summary>
        public String AinBiogPicUrl
        {
            get { return _ainBiogPicUrl; }
            set { _ainBiogPicUrl = value; }
        }

        /// <summary>
        ///     the value of the "TRAIN_SY_TYPE" field.
        /// </summary>
        public Int32 AinSyType
        {
            get { return _ainSyType; }
            set { _ainSyType = value; }
        }

        #endregion

        #region methods

        /// <summary>
        ///     Creates a new <see cref="TrainerRecord" /> object instance that is a shallow-copy of the current object instance.
        /// </summary>
        /// <returns>
        ///     The shallow-copy of the current <see cref="TrainerRecord" /> object instance.
        /// </returns>
        public TrainerRecord Clone()
        {
            TrainerRecord record = new TrainerRecord();
            record.Id = this.Id;
            record.AinLock = this.AinLock;
            record.AinAddDate = this.AinAddDate;
            record.AinAddBy = this.AinAddBy;
            record.AinModDate = this.AinModDate;
            record.AinModBy = this.AinModBy;
            record.AinRcvDate = this.AinRcvDate;
            record.AinRcvFrom = this.AinRcvFrom;
            record.AinProleId = this.AinProleId;
            record.AinAppId = this.AinAppId;
            record.AinStartDate = this.AinStartDate;
            record.AinStatus = this.AinStatus;
            record.AinReviewDate = this.AinReviewDate;
            record.AinRef = this.AinRef;
            record.AinCost = this.AinCost;
            record.AinUserchar1 = this.AinUserchar1;
            record.AinUserchar2 = this.AinUserchar2;
            record.AinUserchar3 = this.AinUserchar3;
            record.AinUserchar4 = this.AinUserchar4;
            record.AinUserchar5 = this.AinUserchar5;
            record.AinUserchar6 = this.AinUserchar6;
            record.AinUserint1 = this.AinUserint1;
            record.AinUserint2 = this.AinUserint2;
            record.AinUserint3 = this.AinUserint3;
            record.AinUserint4 = this.AinUserint4;
            record.AinUserint5 = this.AinUserint5;
            record.AinUserint6 = this.AinUserint6;
            record.AinUsernum1 = this.AinUsernum1;
            record.AinUsernum2 = this.AinUsernum2;
            record.AinUsernum3 = this.AinUsernum3;
            record.AinUsernum4 = this.AinUsernum4;
            record.AinUsernum5 = this.AinUsernum5;
            record.AinUsernum6 = this.AinUsernum6;
            record.AinUserdate1 = this.AinUserdate1;
            record.AinUserdate2 = this.AinUserdate2;
            record.AinUserdate3 = this.AinUserdate3;
            record.AinUserdate4 = this.AinUserdate4;
            record.AinUserdate5 = this.AinUserdate5;
            record.AinUserdate6 = this.AinUserdate6;
            record.AinBiog = this.AinBiog;
            record.AinAttrib01 = this.AinAttrib01;
            record.AinDayCost = this.AinDayCost;
            record.AinHourCost = this.AinHourCost;
            record.AinBasePostcode = this.AinBasePostcode;
            record.AinBaseLat = this.AinBaseLat;
            record.AinBaseLong = this.AinBaseLong;
            record.AinSelcoSpId = this.AinSelcoSpId;
            record.AinInsExpiry = this.AinInsExpiry;
            record.NUniqueRef = this.NUniqueRef;
            record.AinFeeNotesTextId = this.AinFeeNotesTextId;
            record.AinHotelReqTextId = this.AinHotelReqTextId;
            record.AinOtherInfoTextId = this.AinOtherInfoTextId;
            record.AinPassword = this.AinPassword;
            record.AinWeb = this.AinWeb;
            record.AinBiogPicUrl = this.AinBiogPicUrl;
            record.AinSyType = this.AinSyType;
            return record;
        }

        /// <summary>
        ///     Indicates whether the current <see cref="TrainerRecord" /> instance is equal to another <see cref="TrainerRecord" /> instance.
        /// </summary>
        /// <param name="that">
        ///     The <see cref="TrainerRecord" /> instance to be compared against this instance.
        /// </param>
        /// <returns>
        ///     True if both instances are considered equal; otherwise, false.
        /// </returns>
        public Boolean Equals(TrainerRecord that)
        {
            Boolean result = true;
            result = result && (this.Id.TrimOrNullify() == that.Id.TrimOrNullify());
            result = result && (this.AinLock.TrimOrNullify() == that.AinLock.TrimOrNullify());
            result = result && (this.AinAddDate == that.AinAddDate);
            result = result && (this.AinAddBy.TrimOrNullify() == that.AinAddBy.TrimOrNullify());
            result = result && (this.AinModDate == that.AinModDate);
            result = result && (this.AinModBy.TrimOrNullify() == that.AinModBy.TrimOrNullify());
            result = result && (this.AinRcvDate == that.AinRcvDate);
            result = result && (this.AinRcvFrom.TrimOrNullify() == that.AinRcvFrom.TrimOrNullify());
            result = result && (this.AinProleId.TrimOrNullify() == that.AinProleId.TrimOrNullify());
            result = result && (this.AinAppId.TrimOrNullify() == that.AinAppId.TrimOrNullify());
            result = result && (this.AinStartDate == that.AinStartDate);
            result = result && (this.AinStatus.TrimOrNullify() == that.AinStatus.TrimOrNullify());
            result = result && (this.AinReviewDate == that.AinReviewDate);
            result = result && (this.AinRef.TrimOrNullify() == that.AinRef.TrimOrNullify());
            result = result && (this.AinCost == that.AinCost);
            result = result && (this.AinUserchar1.TrimOrNullify() == that.AinUserchar1.TrimOrNullify());
            result = result && (this.AinUserchar2.TrimOrNullify() == that.AinUserchar2.TrimOrNullify());
            result = result && (this.AinUserchar3.TrimOrNullify() == that.AinUserchar3.TrimOrNullify());
            result = result && (this.AinUserchar4.TrimOrNullify() == that.AinUserchar4.TrimOrNullify());
            result = result && (this.AinUserchar5.TrimOrNullify() == that.AinUserchar5.TrimOrNullify());
            result = result && (this.AinUserchar6.TrimOrNullify() == that.AinUserchar6.TrimOrNullify());
            result = result && (this.AinUserint1 == that.AinUserint1);
            result = result && (this.AinUserint2 == that.AinUserint2);
            result = result && (this.AinUserint3 == that.AinUserint3);
            result = result && (this.AinUserint4 == that.AinUserint4);
            result = result && (this.AinUserint5 == that.AinUserint5);
            result = result && (this.AinUserint6 == that.AinUserint6);
            result = result && (this.AinUsernum1 == that.AinUsernum1);
            result = result && (this.AinUsernum2 == that.AinUsernum2);
            result = result && (this.AinUsernum3 == that.AinUsernum3);
            result = result && (this.AinUsernum4 == that.AinUsernum4);
            result = result && (this.AinUsernum5 == that.AinUsernum5);
            result = result && (this.AinUsernum6 == that.AinUsernum6);
            result = result && (this.AinUserdate1 == that.AinUserdate1);
            result = result && (this.AinUserdate2 == that.AinUserdate2);
            result = result && (this.AinUserdate3 == that.AinUserdate3);
            result = result && (this.AinUserdate4 == that.AinUserdate4);
            result = result && (this.AinUserdate5 == that.AinUserdate5);
            result = result && (this.AinUserdate6 == that.AinUserdate6);
            result = result && (this.AinBiog.TrimOrNullify() == that.AinBiog.TrimOrNullify());
            result = result && (this.AinAttrib01.TrimOrNullify() == that.AinAttrib01.TrimOrNullify());
            result = result && (this.AinDayCost == that.AinDayCost);
            result = result && (this.AinHourCost == that.AinHourCost);
            result = result && (this.AinBasePostcode.TrimOrNullify() == that.AinBasePostcode.TrimOrNullify());
            result = result && (this.AinBaseLat == that.AinBaseLat);
            result = result && (this.AinBaseLong == that.AinBaseLong);
            result = result && (this.AinSelcoSpId.TrimOrNullify() == that.AinSelcoSpId.TrimOrNullify());
            result = result && (this.AinInsExpiry == that.AinInsExpiry);
            result = result && (this.NUniqueRef.TrimOrNullify() == that.NUniqueRef.TrimOrNullify());
            result = result && (this.AinFeeNotesTextId.TrimOrNullify() == that.AinFeeNotesTextId.TrimOrNullify());
            result = result && (this.AinHotelReqTextId.TrimOrNullify() == that.AinHotelReqTextId.TrimOrNullify());
            result = result && (this.AinOtherInfoTextId.TrimOrNullify() == that.AinOtherInfoTextId.TrimOrNullify());
            result = result && (this.AinPassword.TrimOrNullify() == that.AinPassword.TrimOrNullify());
            result = result && (this.AinWeb == that.AinWeb);
            result = result && (this.AinBiogPicUrl.TrimOrNullify() == that.AinBiogPicUrl.TrimOrNullify());
            result = result && (this.AinSyType == that.AinSyType);
            return result;
        }

        #endregion
    }
}
