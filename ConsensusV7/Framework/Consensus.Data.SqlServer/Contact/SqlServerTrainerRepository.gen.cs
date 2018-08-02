using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Linq;

namespace Consensus.Contact
{
    /// <summary>
    ///     Provides the persistence and retrieval of the <see cref="TrainerRecord" /> instances in a Microsoft SQL Server database.
    /// </summary>
    /// <remarks>
    ///     THIS CODE HAS BEEN AUTOMATICALLY GENERATED USING THE CONSENSUS DEVELOPER TOOLS.
    ///     DO NOT EDIT THIS CODE AS ANY CUSTOM MODIFICATIONS WILL BE LOST UPON REGENERATION.
    /// </remarks>
    public partial class SqlServerTrainerRepository : SqlServerRepository<TrainerRecord, String>, ITrainerRepository
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
            get { return "Trainer"; }
        }

        /// <summary>
        ///     Gets the name of the parameter which is used to specify the unique value that identifies each instance of a <see cref="TrainerRecord" />.
        /// </summary>
        protected override String TypeKeyName
        {
            get { return "@PA_TRAIN_ID"; }
        }

        /// <summary>
        ///     Gets the underlying table name that this repository sit over.
        /// </summary>
        public override String TableName
        {
            get { return "Trainer"; }
        }

        #endregion

        #region methods

        /// <summary>
        ///     Maps an <see cref="IDataRecord" /> to the specified <see cref="TrainerRecord" />.
        /// </summary>
        /// <param name="dataRecord">
        ///     The <see cref="IDataRecord" /> to be mapped.
        /// </param>
        /// <param name="record">
        ///     The <see cref="TrainerRecord" /> instance to be mapped to.
        /// </param>
        protected override void MapRecord(IDataRecord dataRecord, TrainerRecord record)
        {
            record.Id = dataRecord["TRAIN_ID"].ConvertTo<String>();
            record.AinLock = dataRecord["TRAIN_LOCK"].ConvertTo<String>();
            record.AinAddDate = dataRecord["TRAIN_ADD_DATE"].ConvertTo<DateTime?>();
            record.AinAddBy = dataRecord["TRAIN_ADD_BY"].ConvertTo<String>();
            record.AinModDate = dataRecord["TRAIN_MOD_DATE"].ConvertTo<DateTime?>();
            record.AinModBy = dataRecord["TRAIN_MOD_BY"].ConvertTo<String>();
            record.AinRcvDate = dataRecord["TRAIN_RCV_DATE"].ConvertTo<DateTime?>();
            record.AinRcvFrom = dataRecord["TRAIN_RCV_FROM"].ConvertTo<String>();
            record.AinProleId = dataRecord["TRAIN_PROLE_ID"].ConvertTo<String>();
            record.AinAppId = dataRecord["TRAIN_APP_ID"].ConvertTo<String>();
            record.AinStartDate = dataRecord["TRAIN_START_DATE"].ConvertTo<DateTime?>();
            record.AinStatus = dataRecord["TRAIN_STATUS"].ConvertTo<String>();
            record.AinReviewDate = dataRecord["TRAIN_REVIEW_DATE"].ConvertTo<DateTime?>();
            record.AinRef = dataRecord["TRAIN_REF"].ConvertTo<String>();
            record.AinCost = dataRecord["TRAIN_COST"].ConvertTo<Decimal?>();
            record.AinUserchar1 = dataRecord["TRAIN_USERCHAR_1"].ConvertTo<String>();
            record.AinUserchar2 = dataRecord["TRAIN_USERCHAR_2"].ConvertTo<String>();
            record.AinUserchar3 = dataRecord["TRAIN_USERCHAR_3"].ConvertTo<String>();
            record.AinUserchar4 = dataRecord["TRAIN_USERCHAR_4"].ConvertTo<String>();
            record.AinUserchar5 = dataRecord["TRAIN_USERCHAR_5"].ConvertTo<String>();
            record.AinUserchar6 = dataRecord["TRAIN_USERCHAR_6"].ConvertTo<String>();
            record.AinUserint1 = dataRecord["TRAIN_USERINT_1"].ConvertTo<Byte?>();
            record.AinUserint2 = dataRecord["TRAIN_USERINT_2"].ConvertTo<Byte?>();
            record.AinUserint3 = dataRecord["TRAIN_USERINT_3"].ConvertTo<Byte?>();
            record.AinUserint4 = dataRecord["TRAIN_USERINT_4"].ConvertTo<Byte?>();
            record.AinUserint5 = dataRecord["TRAIN_USERINT_5"].ConvertTo<Byte?>();
            record.AinUserint6 = dataRecord["TRAIN_USERINT_6"].ConvertTo<Byte?>();
            record.AinUsernum1 = dataRecord["TRAIN_USERNUM_1"].ConvertTo<Decimal?>();
            record.AinUsernum2 = dataRecord["TRAIN_USERNUM_2"].ConvertTo<Decimal?>();
            record.AinUsernum3 = dataRecord["TRAIN_USERNUM_3"].ConvertTo<Decimal?>();
            record.AinUsernum4 = dataRecord["TRAIN_USERNUM_4"].ConvertTo<Decimal?>();
            record.AinUsernum5 = dataRecord["TRAIN_USERNUM_5"].ConvertTo<Decimal?>();
            record.AinUsernum6 = dataRecord["TRAIN_USERNUM_6"].ConvertTo<Decimal?>();
            record.AinUserdate1 = dataRecord["TRAIN_USERDATE_1"].ConvertTo<DateTime?>();
            record.AinUserdate2 = dataRecord["TRAIN_USERDATE_2"].ConvertTo<DateTime?>();
            record.AinUserdate3 = dataRecord["TRAIN_USERDATE_3"].ConvertTo<DateTime?>();
            record.AinUserdate4 = dataRecord["TRAIN_USERDATE_4"].ConvertTo<DateTime?>();
            record.AinUserdate5 = dataRecord["TRAIN_USERDATE_5"].ConvertTo<DateTime?>();
            record.AinUserdate6 = dataRecord["TRAIN_USERDATE_6"].ConvertTo<DateTime?>();
            record.AinBiog = dataRecord["TRAIN_BIOG"].ConvertTo<String>();
            record.AinAttrib01 = dataRecord["TRAIN_ATTRIB01"].ConvertTo<String>();
            record.AinDayCost = dataRecord["TRAIN_DAY_COST"].ConvertTo<Decimal>();
            record.AinHourCost = dataRecord["TRAIN_HOUR_COST"].ConvertTo<Decimal>();
            record.AinBasePostcode = dataRecord["TRAIN_BASE_POSTCODE"].ConvertTo<String>();
            record.AinBaseLat = dataRecord["TRAIN_BASE_LAT"].ConvertTo<Decimal?>();
            record.AinBaseLong = dataRecord["TRAIN_BASE_LONG"].ConvertTo<Decimal?>();
            record.AinSelcoSpId = dataRecord["TRAIN_SELCO_SP_ID"].ConvertTo<String>();
            record.AinInsExpiry = dataRecord["TRAIN_INS_EXPIRY"].ConvertTo<DateTime?>();
            record.NUniqueRef = dataRecord["TRN_UNIQUE_REF"].ConvertTo<String>();
            record.AinFeeNotesTextId = dataRecord["TRAIN_FEE_NOTES_TEXT_ID"].ConvertTo<String>();
            record.AinHotelReqTextId = dataRecord["TRAIN_HOTEL_REQ_TEXT_ID"].ConvertTo<String>();
            record.AinOtherInfoTextId = dataRecord["TRAIN_OTHER_INFO_TEXT_ID"].ConvertTo<String>();
            record.AinPassword = dataRecord["TRAIN_PASSWORD"].ConvertTo<String>();
            record.AinWeb = dataRecord["TRAIN_WEB"].ConvertTo<Byte>();
            record.AinBiogPicUrl = dataRecord["TRAIN_BIOG_PIC_URL"].ConvertTo<String>();
            record.AinSyType = dataRecord["TRAIN_SY_TYPE"].ConvertTo<Int32>();
        }

        /// <summary>
        ///     Sets the parameter values for the specified <paramref name="command" /> based on the specified <typeparamref name="TRecord" /> instance.
        /// </summary>
        /// <param name="command">
        ///     The <see cref="IDbCommand" /> containing the parameters to be mapped.
        /// </param>
        /// <param name="record">
        ///     The <see cref="TrainerRecord" /> instance to be mapped.
        /// </param>
        /// <param name="useV6Logic">
        ///     Is the procedure being run an old version 6.x procedure? (the null value handling logic is different).
        /// </param>
        protected override void MapParametersIn(IDbCommand command, TrainerRecord record, bool useV6Logic)
        {
            this.MapParameterIn(command, "@PA_TRAIN_ID", record.Id);
            this.MapParameterIn(command, "@PA_TRAIN_LOCK", record.AinLock);
            this.MapParameterIn(command, "@PA_TRAIN_ADD_DATE", record.AinAddDate == DateTime.MinValue ? ( useV6Logic ? new DateTime?(DateTime.Now) : null ) : record.AinAddDate);
            this.MapParameterIn(command, "@PA_TRAIN_ADD_BY", record.AinAddBy);
            this.MapParameterIn(command, "@PA_TRAIN_MOD_DATE", record.AinModDate == DateTime.MinValue ? ( useV6Logic ? new DateTime?(DateTime.Now) : null ) : record.AinModDate);
            this.MapParameterIn(command, "@PA_TRAIN_MOD_BY", record.AinModBy);
            this.MapParameterIn(command, "@PA_TRAIN_RCV_DATE", record.AinRcvDate == DateTime.MinValue ? ( useV6Logic ? new DateTime?(DateTime.Now) : null ) : record.AinRcvDate);
            this.MapParameterIn(command, "@PA_TRAIN_RCV_FROM", record.AinRcvFrom);
            this.MapParameterIn(command, "@PA_TRAIN_PROLE_ID", record.AinProleId);
            this.MapParameterIn(command, "@PA_TRAIN_APP_ID", record.AinAppId);
            this.MapParameterIn(command, "@PA_TRAIN_START_DATE", record.AinStartDate == DateTime.MinValue ? ( useV6Logic ? new DateTime?(new DateTime(1900,1,1)) : null ) : record.AinStartDate);
            this.MapParameterIn(command, "@PA_TRAIN_STATUS", record.AinStatus);
            this.MapParameterIn(command, "@PA_TRAIN_REVIEW_DATE", record.AinReviewDate == DateTime.MinValue ? ( useV6Logic ? new DateTime?(new DateTime(1900,1,1)) : null ) : record.AinReviewDate);
            this.MapParameterIn(command, "@PA_TRAIN_REF", record.AinRef);
            this.MapParameterIn(command, "@PA_TRAIN_COST", record.AinCost == Decimal.MinValue ? ( useV6Logic ? new Decimal?(0M) : null ) : record.AinCost);
            this.MapParameterIn(command, "@PA_TRAIN_USERCHAR_1", record.AinUserchar1);
            this.MapParameterIn(command, "@PA_TRAIN_USERCHAR_2", record.AinUserchar2);
            this.MapParameterIn(command, "@PA_TRAIN_USERCHAR_3", record.AinUserchar3);
            this.MapParameterIn(command, "@PA_TRAIN_USERCHAR_4", record.AinUserchar4);
            this.MapParameterIn(command, "@PA_TRAIN_USERCHAR_5", record.AinUserchar5);
            this.MapParameterIn(command, "@PA_TRAIN_USERCHAR_6", record.AinUserchar6);
            this.MapParameterIn(command, "@PA_TRAIN_USERINT_1", record.AinUserint1);
            this.MapParameterIn(command, "@PA_TRAIN_USERINT_2", record.AinUserint2);
            this.MapParameterIn(command, "@PA_TRAIN_USERINT_3", record.AinUserint3);
            this.MapParameterIn(command, "@PA_TRAIN_USERINT_4", record.AinUserint4);
            this.MapParameterIn(command, "@PA_TRAIN_USERINT_5", record.AinUserint5);
            this.MapParameterIn(command, "@PA_TRAIN_USERINT_6", record.AinUserint6);
            this.MapParameterIn(command, "@PA_TRAIN_USERNUM_1", record.AinUsernum1 == Decimal.MinValue ? ( useV6Logic ? new Decimal?(0M) : null ) : record.AinUsernum1);
            this.MapParameterIn(command, "@PA_TRAIN_USERNUM_2", record.AinUsernum2 == Decimal.MinValue ? ( useV6Logic ? new Decimal?(0M) : null ) : record.AinUsernum2);
            this.MapParameterIn(command, "@PA_TRAIN_USERNUM_3", record.AinUsernum3 == Decimal.MinValue ? ( useV6Logic ? new Decimal?(0M) : null ) : record.AinUsernum3);
            this.MapParameterIn(command, "@PA_TRAIN_USERNUM_4", record.AinUsernum4 == Decimal.MinValue ? ( useV6Logic ? new Decimal?(0M) : null ) : record.AinUsernum4);
            this.MapParameterIn(command, "@PA_TRAIN_USERNUM_5", record.AinUsernum5 == Decimal.MinValue ? ( useV6Logic ? new Decimal?(0M) : null ) : record.AinUsernum5);
            this.MapParameterIn(command, "@PA_TRAIN_USERNUM_6", record.AinUsernum6 == Decimal.MinValue ? ( useV6Logic ? new Decimal?(0M) : null ) : record.AinUsernum6);
            this.MapParameterIn(command, "@PA_TRAIN_USERDATE_1", record.AinUserdate1 == DateTime.MinValue ? ( useV6Logic ? new DateTime?(new DateTime(1900,1,1)) : null ) : record.AinUserdate1);
            this.MapParameterIn(command, "@PA_TRAIN_USERDATE_2", record.AinUserdate2 == DateTime.MinValue ? ( useV6Logic ? new DateTime?(new DateTime(1900,1,1)) : null ) : record.AinUserdate2);
            this.MapParameterIn(command, "@PA_TRAIN_USERDATE_3", record.AinUserdate3 == DateTime.MinValue ? ( useV6Logic ? new DateTime?(new DateTime(1900,1,1)) : null ) : record.AinUserdate3);
            this.MapParameterIn(command, "@PA_TRAIN_USERDATE_4", record.AinUserdate4 == DateTime.MinValue ? ( useV6Logic ? new DateTime?(new DateTime(1900,1,1)) : null ) : record.AinUserdate4);
            this.MapParameterIn(command, "@PA_TRAIN_USERDATE_5", record.AinUserdate5 == DateTime.MinValue ? ( useV6Logic ? new DateTime?(new DateTime(1900,1,1)) : null ) : record.AinUserdate5);
            this.MapParameterIn(command, "@PA_TRAIN_USERDATE_6", record.AinUserdate6 == DateTime.MinValue ? ( useV6Logic ? new DateTime?(new DateTime(1900,1,1)) : null ) : record.AinUserdate6);
            this.MapParameterIn(command, "@PA_TRAIN_BIOG", record.AinBiog);
            this.MapParameterIn(command, "@PA_TRAIN_ATTRIB01", record.AinAttrib01);
            this.MapParameterIn(command, "@PA_TRAIN_DAY_COST", record.AinDayCost == Decimal.MinValue ? 0M : record.AinDayCost);
            this.MapParameterIn(command, "@PA_TRAIN_HOUR_COST", record.AinHourCost == Decimal.MinValue ? 0M : record.AinHourCost);
            this.MapParameterIn(command, "@PA_TRAIN_BASE_POSTCODE", record.AinBasePostcode);
            this.MapParameterIn(command, "@PA_TRAIN_BASE_LAT", record.AinBaseLat == Decimal.MinValue ? ( useV6Logic ? new Decimal?(0M) : null ) : record.AinBaseLat);
            this.MapParameterIn(command, "@PA_TRAIN_BASE_LONG", record.AinBaseLong == Decimal.MinValue ? ( useV6Logic ? new Decimal?(0M) : null ) : record.AinBaseLong);
            this.MapParameterIn(command, "@PA_TRAIN_SELCO_SP_ID", record.AinSelcoSpId);
            this.MapParameterIn(command, "@PA_TRAIN_INS_EXPIRY", record.AinInsExpiry == DateTime.MinValue ? ( useV6Logic ? new DateTime?(new DateTime(1900,1,1)) : null ) : record.AinInsExpiry);
            this.MapParameterIn(command, "@PA_TRN_UNIQUE_REF", record.NUniqueRef);
            this.MapParameterIn(command, "@PA_TRAIN_FEE_NOTES_TEXT_ID", record.AinFeeNotesTextId);
            this.MapParameterIn(command, "@PA_TRAIN_HOTEL_REQ_TEXT_ID", record.AinHotelReqTextId);
            this.MapParameterIn(command, "@PA_TRAIN_OTHER_INFO_TEXT_ID", record.AinOtherInfoTextId);
            this.MapParameterIn(command, "@PA_TRAIN_PASSWORD", record.AinPassword);
            this.MapParameterIn(command, "@PA_TRAIN_WEB", record.AinWeb);
            this.MapParameterIn(command, "@PA_TRAIN_BIOG_PIC_URL", record.AinBiogPicUrl);
            this.MapParameterIn(command, "@PA_TRAIN_SY_TYPE", record.AinSyType == Int32.MinValue ? 0 : record.AinSyType);
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
        ///     The <see cref="TrainerRecord" /> instance to be updated.
        /// </param>
        protected override void MapParametersOut(IDbCommand command, TrainerRecord record)
        {
            record.Id = this.MapParameterOut(command, "@PA_TRAIN_ID", record.Id);
            record.AinLock = this.MapParameterOut(command, "@PA_TRAIN_LOCK", record.AinLock);
            record.AinAddDate = this.MapParameterOut(command, "@PA_TRAIN_ADD_DATE", record.AinAddDate);
            record.AinAddBy = this.MapParameterOut(command, "@PA_TRAIN_ADD_BY", record.AinAddBy);
            record.AinModDate = this.MapParameterOut(command, "@PA_TRAIN_MOD_DATE", record.AinModDate);
            record.AinModBy = this.MapParameterOut(command, "@PA_TRAIN_MOD_BY", record.AinModBy);
            record.AinRcvDate = this.MapParameterOut(command, "@PA_TRAIN_RCV_DATE", record.AinRcvDate);
            record.AinRcvFrom = this.MapParameterOut(command, "@PA_TRAIN_RCV_FROM", record.AinRcvFrom);
            record.AinProleId = this.MapParameterOut(command, "@PA_TRAIN_PROLE_ID", record.AinProleId);
            record.AinAppId = this.MapParameterOut(command, "@PA_TRAIN_APP_ID", record.AinAppId);
            record.AinStartDate = this.MapParameterOut(command, "@PA_TRAIN_START_DATE", record.AinStartDate);
            record.AinStatus = this.MapParameterOut(command, "@PA_TRAIN_STATUS", record.AinStatus);
            record.AinReviewDate = this.MapParameterOut(command, "@PA_TRAIN_REVIEW_DATE", record.AinReviewDate);
            record.AinRef = this.MapParameterOut(command, "@PA_TRAIN_REF", record.AinRef);
            record.AinCost = this.MapParameterOut(command, "@PA_TRAIN_COST", record.AinCost);
            record.AinUserchar1 = this.MapParameterOut(command, "@PA_TRAIN_USERCHAR_1", record.AinUserchar1);
            record.AinUserchar2 = this.MapParameterOut(command, "@PA_TRAIN_USERCHAR_2", record.AinUserchar2);
            record.AinUserchar3 = this.MapParameterOut(command, "@PA_TRAIN_USERCHAR_3", record.AinUserchar3);
            record.AinUserchar4 = this.MapParameterOut(command, "@PA_TRAIN_USERCHAR_4", record.AinUserchar4);
            record.AinUserchar5 = this.MapParameterOut(command, "@PA_TRAIN_USERCHAR_5", record.AinUserchar5);
            record.AinUserchar6 = this.MapParameterOut(command, "@PA_TRAIN_USERCHAR_6", record.AinUserchar6);
            record.AinUserint1 = this.MapParameterOut(command, "@PA_TRAIN_USERINT_1", record.AinUserint1);
            record.AinUserint2 = this.MapParameterOut(command, "@PA_TRAIN_USERINT_2", record.AinUserint2);
            record.AinUserint3 = this.MapParameterOut(command, "@PA_TRAIN_USERINT_3", record.AinUserint3);
            record.AinUserint4 = this.MapParameterOut(command, "@PA_TRAIN_USERINT_4", record.AinUserint4);
            record.AinUserint5 = this.MapParameterOut(command, "@PA_TRAIN_USERINT_5", record.AinUserint5);
            record.AinUserint6 = this.MapParameterOut(command, "@PA_TRAIN_USERINT_6", record.AinUserint6);
            record.AinUsernum1 = this.MapParameterOut(command, "@PA_TRAIN_USERNUM_1", record.AinUsernum1);
            record.AinUsernum2 = this.MapParameterOut(command, "@PA_TRAIN_USERNUM_2", record.AinUsernum2);
            record.AinUsernum3 = this.MapParameterOut(command, "@PA_TRAIN_USERNUM_3", record.AinUsernum3);
            record.AinUsernum4 = this.MapParameterOut(command, "@PA_TRAIN_USERNUM_4", record.AinUsernum4);
            record.AinUsernum5 = this.MapParameterOut(command, "@PA_TRAIN_USERNUM_5", record.AinUsernum5);
            record.AinUsernum6 = this.MapParameterOut(command, "@PA_TRAIN_USERNUM_6", record.AinUsernum6);
            record.AinUserdate1 = this.MapParameterOut(command, "@PA_TRAIN_USERDATE_1", record.AinUserdate1);
            record.AinUserdate2 = this.MapParameterOut(command, "@PA_TRAIN_USERDATE_2", record.AinUserdate2);
            record.AinUserdate3 = this.MapParameterOut(command, "@PA_TRAIN_USERDATE_3", record.AinUserdate3);
            record.AinUserdate4 = this.MapParameterOut(command, "@PA_TRAIN_USERDATE_4", record.AinUserdate4);
            record.AinUserdate5 = this.MapParameterOut(command, "@PA_TRAIN_USERDATE_5", record.AinUserdate5);
            record.AinUserdate6 = this.MapParameterOut(command, "@PA_TRAIN_USERDATE_6", record.AinUserdate6);
            record.AinBiog = this.MapParameterOut(command, "@PA_TRAIN_BIOG", record.AinBiog);
            record.AinAttrib01 = this.MapParameterOut(command, "@PA_TRAIN_ATTRIB01", record.AinAttrib01);
            record.AinDayCost = this.MapParameterOut(command, "@PA_TRAIN_DAY_COST", record.AinDayCost);
            record.AinHourCost = this.MapParameterOut(command, "@PA_TRAIN_HOUR_COST", record.AinHourCost);
            record.AinBasePostcode = this.MapParameterOut(command, "@PA_TRAIN_BASE_POSTCODE", record.AinBasePostcode);
            record.AinBaseLat = this.MapParameterOut(command, "@PA_TRAIN_BASE_LAT", record.AinBaseLat);
            record.AinBaseLong = this.MapParameterOut(command, "@PA_TRAIN_BASE_LONG", record.AinBaseLong);
            record.AinSelcoSpId = this.MapParameterOut(command, "@PA_TRAIN_SELCO_SP_ID", record.AinSelcoSpId);
            record.AinInsExpiry = this.MapParameterOut(command, "@PA_TRAIN_INS_EXPIRY", record.AinInsExpiry);
            record.NUniqueRef = this.MapParameterOut(command, "@PA_TRN_UNIQUE_REF", record.NUniqueRef);
            record.AinFeeNotesTextId = this.MapParameterOut(command, "@PA_TRAIN_FEE_NOTES_TEXT_ID", record.AinFeeNotesTextId);
            record.AinHotelReqTextId = this.MapParameterOut(command, "@PA_TRAIN_HOTEL_REQ_TEXT_ID", record.AinHotelReqTextId);
            record.AinOtherInfoTextId = this.MapParameterOut(command, "@PA_TRAIN_OTHER_INFO_TEXT_ID", record.AinOtherInfoTextId);
            record.AinPassword = this.MapParameterOut(command, "@PA_TRAIN_PASSWORD", record.AinPassword);
            record.AinWeb = this.MapParameterOut(command, "@PA_TRAIN_WEB", record.AinWeb);
            record.AinBiogPicUrl = this.MapParameterOut(command, "@PA_TRAIN_BIOG_PIC_URL", record.AinBiogPicUrl);
            record.AinSyType = this.MapParameterOut(command, "@PA_TRAIN_SY_TYPE", record.AinSyType);
            record.Id = this.MapParameterOut(command, "@PA_RETURN_ID", record.Id);
        }

        /// <summary>
        ///     Retrieves a collection of <see cref="TrainerRecord" /> instances from the data store.
        /// </summary>
        /// <param name="ainProleId">
        ///     The value which identifies the <see cref='TrainerModel' /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The collection of <see cref="TrainerRecord" /> instances that match the specified <paramref name='ainProleId' />.
        /// </returns>
        public IEnumerable<TrainerRecord> FetchAllByAinProleId(String ainProleId)
        {
            DbCommand command = this.GetStoredProcedure(SqlServerOperation.FetchAll, "AinProleId");
            this.MapParameterIn(command, "@PA_TRAIN_PROLE_ID", ainProleId);
            return this.Execute(command);
        }

        /// <summary>
        ///     Retrieves a collection of <see cref="TrainerRecord" /> instances from the data store.
        /// </summary>
        /// <param name="ainSelcoSpId">
        ///     The value which identifies the <see cref='TrainerModel' /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The collection of <see cref="TrainerRecord" /> instances that match the specified <paramref name='ainSelcoSpId' />.
        /// </returns>
        public IEnumerable<TrainerRecord> FetchAllByAinSelcoSpId(String ainSelcoSpId)
        {
            DbCommand command = this.GetStoredProcedure(SqlServerOperation.FetchAll, "AinSelcoSpId");
            this.MapParameterIn(command, "@PA_TRAIN_SELCO_SP_ID", ainSelcoSpId);
            return this.Execute(command);
        }

        /// <summary>
        ///     Retrieves a collection of <see cref="TrainerRecord" /> instances from the data store.
        /// </summary>
        /// <param name="ainFeeNotesTextId">
        ///     The value which identifies the <see cref='TrainerModel' /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The collection of <see cref="TrainerRecord" /> instances that match the specified <paramref name='ainFeeNotesTextId' />.
        /// </returns>
        public IEnumerable<TrainerRecord> FetchAllByAinFeeNotesTextId(String ainFeeNotesTextId)
        {
            DbCommand command = this.GetStoredProcedure(SqlServerOperation.FetchAll, "AinFeeNotesTextId");
            this.MapParameterIn(command, "@PA_TRAIN_FEE_NOTES_TEXT_ID", ainFeeNotesTextId);
            return this.Execute(command);
        }

        /// <summary>
        ///     Retrieves a collection of <see cref="TrainerRecord" /> instances from the data store.
        /// </summary>
        /// <param name="ainHotelReqTextId">
        ///     The value which identifies the <see cref='TrainerModel' /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The collection of <see cref="TrainerRecord" /> instances that match the specified <paramref name='ainHotelReqTextId' />.
        /// </returns>
        public IEnumerable<TrainerRecord> FetchAllByAinHotelReqTextId(String ainHotelReqTextId)
        {
            DbCommand command = this.GetStoredProcedure(SqlServerOperation.FetchAll, "AinHotelReqTextId");
            this.MapParameterIn(command, "@PA_TRAIN_HOTEL_REQ_TEXT_ID", ainHotelReqTextId);
            return this.Execute(command);
        }

        /// <summary>
        ///     Retrieves a collection of <see cref="TrainerRecord" /> instances from the data store.
        /// </summary>
        /// <param name="ainOtherInfoTextId">
        ///     The value which identifies the <see cref='TrainerModel' /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The collection of <see cref="TrainerRecord" /> instances that match the specified <paramref name='ainOtherInfoTextId' />.
        /// </returns>
        public IEnumerable<TrainerRecord> FetchAllByAinOtherInfoTextId(String ainOtherInfoTextId)
        {
            DbCommand command = this.GetStoredProcedure(SqlServerOperation.FetchAll, "AinOtherInfoTextId");
            this.MapParameterIn(command, "@PA_TRAIN_OTHER_INFO_TEXT_ID", ainOtherInfoTextId);
            return this.Execute(command);
        }

        #endregion

        #region implementations

        /// <summary>
        ///     Gets the underlying table name that this repository sit over.
        /// </summary>
        System.String ITrainerRepository.TableName
        {
            get { return this.TableName; }
        }

        /// <summary>
        ///     Retrieves a collection of <see cref="T:Consensus.Contact.TrainerRecord" /> instances from the data store.
        /// </summary>
        /// <param name="ainProleId">
        ///     The value which identifies the <see cref="!:TrainerModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The collection of <see cref="T:Consensus.Contact.TrainerRecord" /> instances that match the specified <paramref name="ainProleId" />.
        /// </returns>
        System.Collections.Generic.IEnumerable<Consensus.Contact.TrainerRecord> ITrainerRepository.FetchAllByAinProleId(System.String ainProleId)
        {
            return this.FetchAllByAinProleId(ainProleId);
        }

        /// <summary>
        ///     Retrieves a collection of <see cref="T:Consensus.Contact.TrainerRecord" /> instances from the data store.
        /// </summary>
        /// <param name="ainSelcoSpId">
        ///     The value which identifies the <see cref="!:TrainerModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The collection of <see cref="T:Consensus.Contact.TrainerRecord" /> instances that match the specified <paramref name="ainSelcoSpId" />.
        /// </returns>
        System.Collections.Generic.IEnumerable<Consensus.Contact.TrainerRecord> ITrainerRepository.FetchAllByAinSelcoSpId(System.String ainSelcoSpId)
        {
            return this.FetchAllByAinSelcoSpId(ainSelcoSpId);
        }

        /// <summary>
        ///     Retrieves a collection of <see cref="T:Consensus.Contact.TrainerRecord" /> instances from the data store.
        /// </summary>
        /// <param name="ainFeeNotesTextId">
        ///     The value which identifies the <see cref="!:TrainerModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The collection of <see cref="T:Consensus.Contact.TrainerRecord" /> instances that match the specified <paramref name="ainFeeNotesTextId" />.
        /// </returns>
        System.Collections.Generic.IEnumerable<Consensus.Contact.TrainerRecord> ITrainerRepository.FetchAllByAinFeeNotesTextId(System.String ainFeeNotesTextId)
        {
            return this.FetchAllByAinFeeNotesTextId(ainFeeNotesTextId);
        }

        /// <summary>
        ///     Retrieves a collection of <see cref="T:Consensus.Contact.TrainerRecord" /> instances from the data store.
        /// </summary>
        /// <param name="ainHotelReqTextId">
        ///     The value which identifies the <see cref="!:TrainerModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The collection of <see cref="T:Consensus.Contact.TrainerRecord" /> instances that match the specified <paramref name="ainHotelReqTextId" />.
        /// </returns>
        System.Collections.Generic.IEnumerable<Consensus.Contact.TrainerRecord> ITrainerRepository.FetchAllByAinHotelReqTextId(System.String ainHotelReqTextId)
        {
            return this.FetchAllByAinHotelReqTextId(ainHotelReqTextId);
        }

        /// <summary>
        ///     Retrieves a collection of <see cref="T:Consensus.Contact.TrainerRecord" /> instances from the data store.
        /// </summary>
        /// <param name="ainOtherInfoTextId">
        ///     The value which identifies the <see cref="!:TrainerModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The collection of <see cref="T:Consensus.Contact.TrainerRecord" /> instances that match the specified <paramref name="ainOtherInfoTextId" />.
        /// </returns>
        System.Collections.Generic.IEnumerable<Consensus.Contact.TrainerRecord> ITrainerRepository.FetchAllByAinOtherInfoTextId(System.String ainOtherInfoTextId)
        {
            return this.FetchAllByAinOtherInfoTextId(ainOtherInfoTextId);
        }

        #endregion
    }
}
