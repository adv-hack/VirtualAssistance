using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Linq;

namespace Consensus.Activities
{
    /// <summary>
    ///     Provides the persistence and retrieval of the <see cref="ActivityXrefRecord" /> instances in a Microsoft SQL Server database.
    /// </summary>
    /// <remarks>
    ///     THIS CODE HAS BEEN AUTOMATICALLY GENERATED USING THE CONSENSUS DEVELOPER TOOLS.
    ///     DO NOT EDIT THIS CODE AS ANY CUSTOM MODIFICATIONS WILL BE LOST UPON REGENERATION.
    /// </remarks>
    public partial class SqlServerActivityXrefRepository : SqlServerRepository<ActivityXrefRecord, String>, IActivityXrefRepository
    {
        #region properties

        /// <summary>
        ///     Gets the namespace in which the data type is contained.
        /// </summary>
        protected override String TypeNamespace
        {
            get { return "Activities"; }
        }

        /// <summary>
        ///     Gets the name of the data type which is persisted by this repository.
        /// </summary>
        protected override String TypeName
        {
            get { return "ActivityXref"; }
        }

        /// <summary>
        ///     Gets the name of the parameter which is used to specify the unique value that identifies each instance of a <see cref="ActivityXrefRecord" />.
        /// </summary>
        protected override String TypeKeyName
        {
            get { return "@PA_ACTXREF_ID"; }
        }

        /// <summary>
        ///     Gets the underlying table name that this repository sit over.
        /// </summary>
        public override String TableName
        {
            get { return "Activity_Xref"; }
        }

        #endregion

        #region methods

        /// <summary>
        ///     Maps an <see cref="IDataRecord" /> to the specified <see cref="ActivityXrefRecord" />.
        /// </summary>
        /// <param name="dataRecord">
        ///     The <see cref="IDataRecord" /> to be mapped.
        /// </param>
        /// <param name="record">
        ///     The <see cref="ActivityXrefRecord" /> instance to be mapped to.
        /// </param>
        protected override void MapRecord(IDataRecord dataRecord, ActivityXrefRecord record)
        {
            record.Id = dataRecord["ACTXREF_ID"].ConvertTo<String>();
            record.AddDate = dataRecord["ACTXREF_ADD_DATE"].ConvertTo<DateTime?>();
            record.AddBy = dataRecord["ACTXREF_ADD_BY"].ConvertTo<String>();
            record.ModDate = dataRecord["ACTXREF_MOD_DATE"].ConvertTo<DateTime?>();
            record.ModBy = dataRecord["ACTXREF_MOD_BY"].ConvertTo<String>();
            record.RcvDate = dataRecord["ACTXREF_RCV_DATE"].ConvertTo<DateTime?>();
            record.RcvFrom = dataRecord["ACTXREF_RCV_FROM"].ConvertTo<String>();
            record.ActId = dataRecord["ACTXREF_ACT_ID"].ConvertTo<String>();
            record.PersonId = dataRecord["ACTXREF_PERSON_ID"].ConvertTo<String>();
            record.OrgId = dataRecord["ACTXREF_ORG_ID"].ConvertTo<String>();
            record.ProleId = dataRecord["ACTXREF_PROLE_ID"].ConvertTo<String>();
            record.DiaryType = dataRecord["ACTXREF_DIARY_TYPE"].ConvertTo<Byte?>();
            record.Closer = dataRecord["ACTXREF_CLOSER"].ConvertTo<Byte?>();
            record.PassFrom = dataRecord["ACTXREF_PASS_FROM"].ConvertTo<Byte?>();
            record.Originator = dataRecord["ACTXREF_ORIGINATOR"].ConvertTo<Byte?>();
            record.OrgName = dataRecord["ACTXREF_ORG_NAME"].ConvertTo<String>();
            record.PnName = dataRecord["ACTXREF_PN_NAME"].ConvertTo<String>();
            record.OrgPhone = dataRecord["ACTXREF_ORG_PHONE"].ConvertTo<String>();
            record.PnPhone = dataRecord["ACTXREF_PN_PHONE"].ConvertTo<String>();
            record.Type = dataRecord["ACTXREF_TYPE"].ConvertTo<Byte?>();
            record.Read = dataRecord["ACTXREF_READ"].ConvertTo<Byte?>();
            record.Trainer = dataRecord["ACTXREF_TRAINER"].ConvertTo<Byte?>();
            record.Admin = dataRecord["ACTXREF_ADMIN"].ConvertTo<Byte?>();
            record.Session = dataRecord["ACTXREF_SESSION"].ConvertTo<Byte?>();
            record.ProdId = dataRecord["ACTXREF_PROD_ID"].ConvertTo<String>();
            record.TerrId = dataRecord["ACTXREF_TERR_ID"].ConvertTo<String>();
            record.SchedId = dataRecord["ACTXREF_SCHED_ID"].ConvertTo<String>();
            record.SlDtId = dataRecord["ACTXREF_SL_DT_ID"].ConvertTo<String>();
            record.Usage = dataRecord["ACTXREF_USAGE"].ConvertTo<Byte?>();
            record.Qty = dataRecord["ACTXREF_QTY"].ConvertTo<Double?>();
            record.DelQty = dataRecord["ACTXREF_DEL_QTY"].ConvertTo<Double?>();
            record.Usernum1 = dataRecord["ACTXREF_USERNUM_1"].ConvertTo<Double?>();
            record.Userdate1 = dataRecord["ACTXREF_USERDATE_1"].ConvertTo<DateTime?>();
            record.Internal = dataRecord["ACTXREF_INTERNAL"].ConvertTo<Byte?>();
            record.HourRate = dataRecord["ACTXREF_HOUR_RATE"].ConvertTo<Double?>();
            record.DayRate = dataRecord["ACTXREF_DAY_RATE"].ConvertTo<Double?>();
            record.Currency = dataRecord["ACTXREF_CURRENCY"].ConvertTo<String>();
            record.PayMethod = dataRecord["ACTXREF_PAY_METHOD"].ConvertTo<String>();
            record.PoNumber = dataRecord["ACTXREF_PO_NUMBER"].ConvertTo<String>();
            record.TeachHour = dataRecord["ACTXREF_TEACH_HOUR"].ConvertTo<Double?>();
            record.CstAc = dataRecord["ACTXREF_CST_AC"].ConvertTo<Double?>();
            record.CstAcBc = dataRecord["ACTXREF_CST_AC_BC"].ConvertTo<Double?>();
            record.CstAcBc2 = dataRecord["ACTXREF_CST_AC_BC2"].ConvertTo<Double?>();
            record.PerDay = dataRecord["ACTXREF_PER_DAY"].ConvertTo<Byte?>();
            record.BatId = dataRecord["ACTXREF_BAT_ID"].ConvertTo<String>();
            record.Recharge = dataRecord["ACTXREF_RECHARGE"].ConvertTo<Byte?>();
            record.Cancelled = dataRecord["ACTXREF_CANCELLED"].ConvertTo<Byte?>();
            record.TrainerT = dataRecord["ACTXREF_TRAINER_T"].ConvertTo<String>();
            record.AdminT = dataRecord["ACTXREF_ADMIN_T"].ConvertTo<String>();
            record.Guid = dataRecord["ACTXREF_GUID"].ConvertTo<String>();
            record.Notaccepted = dataRecord["ACTXREF_NOTACCEPTED"].ConvertTo<Byte?>();
            record.ExclCertDel = dataRecord["ACTXREF_EXCL_CERT_DEL"].ConvertTo<Byte?>();
            record.RemindDate = dataRecord["ACTXREF_REMIND_DATE"].ConvertTo<DateTime?>();
            record.AllocStatus = dataRecord["ACTXREF_ALLOC_STATUS"].ConvertTo<Byte?>();
            record.ProfKey = dataRecord["ACTXREF_PROF_KEY"].ConvertTo<String>();
            record.ProfValue = dataRecord["ACTXREF_PROF_VALUE"].ConvertTo<String>();
            record.ProfValue2 = dataRecord["ACTXREF_PROF_VALUE2"].ConvertTo<String>();
            record.UntType = dataRecord["ACTXREF_UNT_TYPE"].ConvertTo<String>();
            record.RoomType = dataRecord["ACTXREF_ROOM_TYPE"].ConvertTo<String>();
            record.IncInBudget = dataRecord["ACTXREF_INC_IN_BUDGET"].ConvertTo<Byte>();
            record.ProleEmail = dataRecord["ACTXREF_PROLE_EMAIL"].ConvertTo<String>();
            record.OutlookStatus = dataRecord["ACTXREF_OUTLOOK_STATUS"].ConvertTo<String>();
            record.CemOrganizer = dataRecord["ACTXREF_CEM_ORGANIZER"].ConvertTo<Byte?>();
            record.OutlookId = dataRecord["ACTXREF_OUTLOOK_ID"].ConvertTo<String>();
            record.Delete = dataRecord["ACTXREF_DELETE"].ConvertTo<Byte>();
            record.BomId = dataRecord["ACTXREF_BOM_ID"].ConvertTo<String>();
            record.ProdName = dataRecord["ACTXREF_PROD_NAME"].ConvertTo<String>();
        }

        /// <summary>
        ///     Sets the parameter values for the specified <paramref name="command" /> based on the specified <typeparamref name="TRecord" /> instance.
        /// </summary>
        /// <param name="command">
        ///     The <see cref="IDbCommand" /> containing the parameters to be mapped.
        /// </param>
        /// <param name="record">
        ///     The <see cref="ActivityXrefRecord" /> instance to be mapped.
        /// </param>
        /// <param name="useV6Logic">
        ///     Is the procedure being run an old version 6.x procedure? (the null value handling logic is different).
        /// </param>
        protected override void MapParametersIn(IDbCommand command, ActivityXrefRecord record, bool useV6Logic)
        {
            this.MapParameterIn(command, "@PA_ACTXREF_ID", record.Id);
            this.MapParameterIn(command, "@PA_ACTXREF_ACT_ID", record.ActId);
            this.MapParameterIn(command, "@PA_ACTXREF_PERSON_ID", record.PersonId);
            this.MapParameterIn(command, "@PA_ACTXREF_ORG_ID", record.OrgId);
            this.MapParameterIn(command, "@PA_ACTXREF_PROLE_ID", record.ProleId);
            this.MapParameterIn(command, "@PA_ACTXREF_DIARY_TYPE", record.DiaryType);
            this.MapParameterIn(command, "@PA_ACTXREF_CLOSER", record.Closer);
            this.MapParameterIn(command, "@PA_ACTXREF_PASS_FROM", record.PassFrom);
            this.MapParameterIn(command, "@PA_ACTXREF_ORIGINATOR", record.Originator);
            this.MapParameterIn(command, "@PA_ACTXREF_ORG_NAME", record.OrgName);
            this.MapParameterIn(command, "@PA_ACTXREF_PN_NAME", record.PnName);
            this.MapParameterIn(command, "@PA_ACTXREF_ORG_PHONE", record.OrgPhone);
            this.MapParameterIn(command, "@PA_ACTXREF_PN_PHONE", record.PnPhone);
            this.MapParameterIn(command, "@PA_ACTXREF_TYPE", record.Type);
            this.MapParameterIn(command, "@PA_ACTXREF_READ", record.Read);
            this.MapParameterIn(command, "@PA_ACTXREF_TRAINER", record.Trainer);
            this.MapParameterIn(command, "@PA_ACTXREF_ADMIN", record.Admin);
            this.MapParameterIn(command, "@PA_ACTXREF_SESSION", record.Session);
            this.MapParameterIn(command, "@PA_ACTXREF_PROD_ID", record.ProdId);
            this.MapParameterIn(command, "@PA_ACTXREF_TERR_ID", record.TerrId);
            this.MapParameterIn(command, "@PA_ACTXREF_SCHED_ID", record.SchedId);
            this.MapParameterIn(command, "@PA_ACTXREF_SL_DT_ID", record.SlDtId);
            this.MapParameterIn(command, "@PA_ACTXREF_USAGE", record.Usage);
            this.MapParameterIn(command, "@PA_ACTXREF_QTY", record.Qty == Double.MinValue ? ( useV6Logic ? new Double?(0) : null ) : record.Qty);
            this.MapParameterIn(command, "@PA_ACTXREF_DEL_QTY", record.DelQty == Double.MinValue ? ( useV6Logic ? new Double?(0) : null ) : record.DelQty);
            this.MapParameterIn(command, "@PA_ACTXREF_USERNUM_1", record.Usernum1 == Double.MinValue ? ( useV6Logic ? new Double?(0) : null ) : record.Usernum1);
            this.MapParameterIn(command, "@PA_ACTXREF_USERDATE_1", record.Userdate1 == DateTime.MinValue ? ( useV6Logic ? new DateTime?(new DateTime(1900,1,1)) : null ) : record.Userdate1);
            this.MapParameterIn(command, "@PA_ACTXREF_INTERNAL", record.Internal);
            this.MapParameterIn(command, "@PA_ACTXREF_HOUR_RATE", record.HourRate == Double.MinValue ? ( useV6Logic ? new Double?(0) : null ) : record.HourRate);
            this.MapParameterIn(command, "@PA_ACTXREF_DAY_RATE", record.DayRate == Double.MinValue ? ( useV6Logic ? new Double?(0) : null ) : record.DayRate);
            this.MapParameterIn(command, "@PA_ACTXREF_CURRENCY", record.Currency);
            this.MapParameterIn(command, "@PA_ACTXREF_PAY_METHOD", record.PayMethod);
            this.MapParameterIn(command, "@PA_ACTXREF_PO_NUMBER", record.PoNumber);
            this.MapParameterIn(command, "@PA_ACTXREF_TEACH_HOUR", record.TeachHour == Double.MinValue ? ( useV6Logic ? new Double?(0) : null ) : record.TeachHour);
            this.MapParameterIn(command, "@PA_ACTXREF_CST_AC", record.CstAc == Double.MinValue ? ( useV6Logic ? new Double?(0) : null ) : record.CstAc);
            this.MapParameterIn(command, "@PA_ACTXREF_CST_AC_BC", record.CstAcBc == Double.MinValue ? ( useV6Logic ? new Double?(0) : null ) : record.CstAcBc);
            this.MapParameterIn(command, "@PA_ACTXREF_CST_AC_BC2", record.CstAcBc2 == Double.MinValue ? ( useV6Logic ? new Double?(0) : null ) : record.CstAcBc2);
            this.MapParameterIn(command, "@PA_ACTXREF_PER_DAY", record.PerDay);
            this.MapParameterIn(command, "@PA_ACTXREF_BAT_ID", record.BatId);
            this.MapParameterIn(command, "@PA_ACTXREF_RECHARGE", record.Recharge);
            this.MapParameterIn(command, "@PA_ACTXREF_CANCELLED", record.Cancelled);
            this.MapParameterIn(command, "@PA_ACTXREF_TRAINER_T", record.TrainerT);
            this.MapParameterIn(command, "@PA_ACTXREF_ADMIN_T", record.AdminT);
            this.MapParameterIn(command, "@PA_ACTXREF_GUID", record.Guid);
            this.MapParameterIn(command, "@PA_ACTXREF_NOTACCEPTED", record.Notaccepted);
            this.MapParameterIn(command, "@PA_ACTXREF_EXCL_CERT_DEL", record.ExclCertDel);
            this.MapParameterIn(command, "@PA_ACTXREF_REMIND_DATE", record.RemindDate == DateTime.MinValue ? ( useV6Logic ? new DateTime?(new DateTime(1900,1,1)) : null ) : record.RemindDate);
            this.MapParameterIn(command, "@PA_ACTXREF_ALLOC_STATUS", record.AllocStatus);
            this.MapParameterIn(command, "@PA_ACTXREF_PROF_KEY", record.ProfKey);
            this.MapParameterIn(command, "@PA_ACTXREF_PROF_VALUE", record.ProfValue);
            this.MapParameterIn(command, "@PA_ACTXREF_PROF_VALUE2", record.ProfValue2);
            this.MapParameterIn(command, "@PA_ACTXREF_UNT_TYPE", record.UntType);
            this.MapParameterIn(command, "@PA_ACTXREF_ROOM_TYPE", record.RoomType);
            this.MapParameterIn(command, "@PA_ACTXREF_INC_IN_BUDGET", record.IncInBudget);
            this.MapParameterIn(command, "@PA_ACTXREF_PROLE_EMAIL", record.ProleEmail);
            this.MapParameterIn(command, "@PA_ACTXREF_OUTLOOK_STATUS", record.OutlookStatus);
            this.MapParameterIn(command, "@PA_ACTXREF_CEM_ORGANIZER", record.CemOrganizer);
            this.MapParameterIn(command, "@PA_ACTXREF_OUTLOOK_ID", record.OutlookId);
            this.MapParameterIn(command, "@PA_ACTXREF_DELETE", record.Delete);
            this.MapParameterIn(command, "@PA_ACTXREF_BOM_ID", record.BomId);
            this.MapParameterIn(command, "@PA_ACTXREF_PROD_NAME", record.ProdName);
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
        ///     The <see cref="ActivityXrefRecord" /> instance to be updated.
        /// </param>
        protected override void MapParametersOut(IDbCommand command, ActivityXrefRecord record)
        {
            record.Id = this.MapParameterOut(command, "@PA_ACTXREF_ID", record.Id);
            record.ActId = this.MapParameterOut(command, "@PA_ACTXREF_ACT_ID", record.ActId);
            record.PersonId = this.MapParameterOut(command, "@PA_ACTXREF_PERSON_ID", record.PersonId);
            record.OrgId = this.MapParameterOut(command, "@PA_ACTXREF_ORG_ID", record.OrgId);
            record.ProleId = this.MapParameterOut(command, "@PA_ACTXREF_PROLE_ID", record.ProleId);
            record.DiaryType = this.MapParameterOut(command, "@PA_ACTXREF_DIARY_TYPE", record.DiaryType);
            record.Closer = this.MapParameterOut(command, "@PA_ACTXREF_CLOSER", record.Closer);
            record.PassFrom = this.MapParameterOut(command, "@PA_ACTXREF_PASS_FROM", record.PassFrom);
            record.Originator = this.MapParameterOut(command, "@PA_ACTXREF_ORIGINATOR", record.Originator);
            record.OrgName = this.MapParameterOut(command, "@PA_ACTXREF_ORG_NAME", record.OrgName);
            record.PnName = this.MapParameterOut(command, "@PA_ACTXREF_PN_NAME", record.PnName);
            record.OrgPhone = this.MapParameterOut(command, "@PA_ACTXREF_ORG_PHONE", record.OrgPhone);
            record.PnPhone = this.MapParameterOut(command, "@PA_ACTXREF_PN_PHONE", record.PnPhone);
            record.Type = this.MapParameterOut(command, "@PA_ACTXREF_TYPE", record.Type);
            record.Read = this.MapParameterOut(command, "@PA_ACTXREF_READ", record.Read);
            record.Trainer = this.MapParameterOut(command, "@PA_ACTXREF_TRAINER", record.Trainer);
            record.Admin = this.MapParameterOut(command, "@PA_ACTXREF_ADMIN", record.Admin);
            record.Session = this.MapParameterOut(command, "@PA_ACTXREF_SESSION", record.Session);
            record.ProdId = this.MapParameterOut(command, "@PA_ACTXREF_PROD_ID", record.ProdId);
            record.TerrId = this.MapParameterOut(command, "@PA_ACTXREF_TERR_ID", record.TerrId);
            record.SchedId = this.MapParameterOut(command, "@PA_ACTXREF_SCHED_ID", record.SchedId);
            record.SlDtId = this.MapParameterOut(command, "@PA_ACTXREF_SL_DT_ID", record.SlDtId);
            record.Usage = this.MapParameterOut(command, "@PA_ACTXREF_USAGE", record.Usage);
            record.Qty = this.MapParameterOut(command, "@PA_ACTXREF_QTY", record.Qty);
            record.DelQty = this.MapParameterOut(command, "@PA_ACTXREF_DEL_QTY", record.DelQty);
            record.Usernum1 = this.MapParameterOut(command, "@PA_ACTXREF_USERNUM_1", record.Usernum1);
            record.Userdate1 = this.MapParameterOut(command, "@PA_ACTXREF_USERDATE_1", record.Userdate1);
            record.Internal = this.MapParameterOut(command, "@PA_ACTXREF_INTERNAL", record.Internal);
            record.HourRate = this.MapParameterOut(command, "@PA_ACTXREF_HOUR_RATE", record.HourRate);
            record.DayRate = this.MapParameterOut(command, "@PA_ACTXREF_DAY_RATE", record.DayRate);
            record.Currency = this.MapParameterOut(command, "@PA_ACTXREF_CURRENCY", record.Currency);
            record.PayMethod = this.MapParameterOut(command, "@PA_ACTXREF_PAY_METHOD", record.PayMethod);
            record.PoNumber = this.MapParameterOut(command, "@PA_ACTXREF_PO_NUMBER", record.PoNumber);
            record.TeachHour = this.MapParameterOut(command, "@PA_ACTXREF_TEACH_HOUR", record.TeachHour);
            record.CstAc = this.MapParameterOut(command, "@PA_ACTXREF_CST_AC", record.CstAc);
            record.CstAcBc = this.MapParameterOut(command, "@PA_ACTXREF_CST_AC_BC", record.CstAcBc);
            record.CstAcBc2 = this.MapParameterOut(command, "@PA_ACTXREF_CST_AC_BC2", record.CstAcBc2);
            record.PerDay = this.MapParameterOut(command, "@PA_ACTXREF_PER_DAY", record.PerDay);
            record.BatId = this.MapParameterOut(command, "@PA_ACTXREF_BAT_ID", record.BatId);
            record.Recharge = this.MapParameterOut(command, "@PA_ACTXREF_RECHARGE", record.Recharge);
            record.Cancelled = this.MapParameterOut(command, "@PA_ACTXREF_CANCELLED", record.Cancelled);
            record.TrainerT = this.MapParameterOut(command, "@PA_ACTXREF_TRAINER_T", record.TrainerT);
            record.AdminT = this.MapParameterOut(command, "@PA_ACTXREF_ADMIN_T", record.AdminT);
            record.Guid = this.MapParameterOut(command, "@PA_ACTXREF_GUID", record.Guid);
            record.Notaccepted = this.MapParameterOut(command, "@PA_ACTXREF_NOTACCEPTED", record.Notaccepted);
            record.ExclCertDel = this.MapParameterOut(command, "@PA_ACTXREF_EXCL_CERT_DEL", record.ExclCertDel);
            record.RemindDate = this.MapParameterOut(command, "@PA_ACTXREF_REMIND_DATE", record.RemindDate);
            record.AllocStatus = this.MapParameterOut(command, "@PA_ACTXREF_ALLOC_STATUS", record.AllocStatus);
            record.ProfKey = this.MapParameterOut(command, "@PA_ACTXREF_PROF_KEY", record.ProfKey);
            record.ProfValue = this.MapParameterOut(command, "@PA_ACTXREF_PROF_VALUE", record.ProfValue);
            record.ProfValue2 = this.MapParameterOut(command, "@PA_ACTXREF_PROF_VALUE2", record.ProfValue2);
            record.UntType = this.MapParameterOut(command, "@PA_ACTXREF_UNT_TYPE", record.UntType);
            record.RoomType = this.MapParameterOut(command, "@PA_ACTXREF_ROOM_TYPE", record.RoomType);
            record.IncInBudget = this.MapParameterOut(command, "@PA_ACTXREF_INC_IN_BUDGET", record.IncInBudget);
            record.ProleEmail = this.MapParameterOut(command, "@PA_ACTXREF_PROLE_EMAIL", record.ProleEmail);
            record.OutlookStatus = this.MapParameterOut(command, "@PA_ACTXREF_OUTLOOK_STATUS", record.OutlookStatus);
            record.CemOrganizer = this.MapParameterOut(command, "@PA_ACTXREF_CEM_ORGANIZER", record.CemOrganizer);
            record.OutlookId = this.MapParameterOut(command, "@PA_ACTXREF_OUTLOOK_ID", record.OutlookId);
            record.Delete = this.MapParameterOut(command, "@PA_ACTXREF_DELETE", record.Delete);
            record.BomId = this.MapParameterOut(command, "@PA_ACTXREF_BOM_ID", record.BomId);
            record.ProdName = this.MapParameterOut(command, "@PA_ACTXREF_PROD_NAME", record.ProdName);
            record.Id = this.MapParameterOut(command, "@PA_RETURN_ID", record.Id);
        }

        /// <summary>
        ///     Retrieves a collection of <see cref="ActivityXrefRecord" /> instances from the data store.
        /// </summary>
        /// <param name="actId">
        ///     The value which identifies the <see cref='ActivityXrefModel' /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The collection of <see cref="ActivityXrefRecord" /> instances that match the specified <paramref name='actId' />.
        /// </returns>
        public IEnumerable<ActivityXrefRecord> FetchAllByActId(String actId)
        {
            DbCommand command = this.GetStoredProcedure(SqlServerOperation.FetchAll, "ActId");
            this.MapParameterIn(command, "@PA_ACTXREF_ACT_ID", actId);
            return this.Execute(command);
        }

        /// <summary>
        ///     Retrieves a collection of <see cref="ActivityXrefRecord" /> instances from the data store.
        /// </summary>
        /// <param name="personId">
        ///     The value which identifies the <see cref='ActivityXrefModel' /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The collection of <see cref="ActivityXrefRecord" /> instances that match the specified <paramref name='personId' />.
        /// </returns>
        public IEnumerable<ActivityXrefRecord> FetchAllByPersonId(String personId)
        {
            DbCommand command = this.GetStoredProcedure(SqlServerOperation.FetchAll, "PersonId");
            this.MapParameterIn(command, "@PA_ACTXREF_PERSON_ID", personId);
            return this.Execute(command);
        }

        /// <summary>
        ///     Retrieves a collection of <see cref="ActivityXrefRecord" /> instances from the data store.
        /// </summary>
        /// <param name="orgId">
        ///     The value which identifies the <see cref='ActivityXrefModel' /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The collection of <see cref="ActivityXrefRecord" /> instances that match the specified <paramref name='orgId' />.
        /// </returns>
        public IEnumerable<ActivityXrefRecord> FetchAllByOrgId(String orgId)
        {
            DbCommand command = this.GetStoredProcedure(SqlServerOperation.FetchAll, "OrgId");
            this.MapParameterIn(command, "@PA_ACTXREF_ORG_ID", orgId);
            return this.Execute(command);
        }

        /// <summary>
        ///     Retrieves a collection of <see cref="ActivityXrefRecord" /> instances from the data store.
        /// </summary>
        /// <param name="proleId">
        ///     The value which identifies the <see cref='ActivityXrefModel' /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The collection of <see cref="ActivityXrefRecord" /> instances that match the specified <paramref name='proleId' />.
        /// </returns>
        public IEnumerable<ActivityXrefRecord> FetchAllByProleId(String proleId)
        {
            DbCommand command = this.GetStoredProcedure(SqlServerOperation.FetchAll, "ProleId");
            this.MapParameterIn(command, "@PA_ACTXREF_PROLE_ID", proleId);
            return this.Execute(command);
        }

        /// <summary>
        ///     Retrieves a collection of <see cref="ActivityXrefRecord" /> instances from the data store.
        /// </summary>
        /// <param name="prodId">
        ///     The value which identifies the <see cref='ActivityXrefModel' /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The collection of <see cref="ActivityXrefRecord" /> instances that match the specified <paramref name='prodId' />.
        /// </returns>
        public IEnumerable<ActivityXrefRecord> FetchAllByProdId(String prodId)
        {
            DbCommand command = this.GetStoredProcedure(SqlServerOperation.FetchAll, "ProdId");
            this.MapParameterIn(command, "@PA_ACTXREF_PROD_ID", prodId);
            return this.Execute(command);
        }

        #endregion

        #region implementations

        /// <summary>
        ///     Gets the underlying table name that this repository sit over.
        /// </summary>
        System.String IActivityXrefRepository.TableName
        {
            get { return this.TableName; }
        }

        void IActivityXrefRepository.Create(Consensus.Activities.ActivityXrefRecord record)
        {
            this.Create(record);
        }

        void IActivityXrefRepository.Modify(Consensus.Activities.ActivityXrefRecord record)
        {
            this.Modify(record);
        }

        /// <summary>
        ///     Retrieves a collection of <see cref="T:Consensus.Activities.ActivityXrefRecord" /> instances from the data store.
        /// </summary>
        /// <param name="actId">
        ///     The value which identifies the <see cref="!:ActivityXrefModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The collection of <see cref="T:Consensus.Activities.ActivityXrefRecord" /> instances that match the specified <paramref name="actId" />.
        /// </returns>
        System.Collections.Generic.IEnumerable<Consensus.Activities.ActivityXrefRecord> IActivityXrefRepository.FetchAllByActId(System.String actId)
        {
            return this.FetchAllByActId(actId);
        }

        /// <summary>
        ///     Retrieves a collection of <see cref="T:Consensus.Activities.ActivityXrefRecord" /> instances from the data store.
        /// </summary>
        /// <param name="personId">
        ///     The value which identifies the <see cref="!:ActivityXrefModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The collection of <see cref="T:Consensus.Activities.ActivityXrefRecord" /> instances that match the specified <paramref name="personId" />.
        /// </returns>
        System.Collections.Generic.IEnumerable<Consensus.Activities.ActivityXrefRecord> IActivityXrefRepository.FetchAllByPersonId(System.String personId)
        {
            return this.FetchAllByPersonId(personId);
        }

        /// <summary>
        ///     Retrieves a collection of <see cref="T:Consensus.Activities.ActivityXrefRecord" /> instances from the data store.
        /// </summary>
        /// <param name="orgId">
        ///     The value which identifies the <see cref="!:ActivityXrefModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The collection of <see cref="T:Consensus.Activities.ActivityXrefRecord" /> instances that match the specified <paramref name="orgId" />.
        /// </returns>
        System.Collections.Generic.IEnumerable<Consensus.Activities.ActivityXrefRecord> IActivityXrefRepository.FetchAllByOrgId(System.String orgId)
        {
            return this.FetchAllByOrgId(orgId);
        }

        /// <summary>
        ///     Retrieves a collection of <see cref="T:Consensus.Activities.ActivityXrefRecord" /> instances from the data store.
        /// </summary>
        /// <param name="proleId">
        ///     The value which identifies the <see cref="!:ActivityXrefModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The collection of <see cref="T:Consensus.Activities.ActivityXrefRecord" /> instances that match the specified <paramref name="proleId" />.
        /// </returns>
        System.Collections.Generic.IEnumerable<Consensus.Activities.ActivityXrefRecord> IActivityXrefRepository.FetchAllByProleId(System.String proleId)
        {
            return this.FetchAllByProleId(proleId);
        }

        /// <summary>
        ///     Retrieves a collection of <see cref="T:Consensus.Activities.ActivityXrefRecord" /> instances from the data store.
        /// </summary>
        /// <param name="prodId">
        ///     The value which identifies the <see cref="!:ActivityXrefModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The collection of <see cref="T:Consensus.Activities.ActivityXrefRecord" /> instances that match the specified <paramref name="prodId" />.
        /// </returns>
        System.Collections.Generic.IEnumerable<Consensus.Activities.ActivityXrefRecord> IActivityXrefRepository.FetchAllByProdId(System.String prodId)
        {
            return this.FetchAllByProdId(prodId);
        }

        #endregion
    }
}
