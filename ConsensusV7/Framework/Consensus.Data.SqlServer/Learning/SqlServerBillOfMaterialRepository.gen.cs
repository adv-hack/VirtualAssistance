using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Linq;

namespace Consensus.Learning
{
    /// <summary>
    ///     Provides the persistence and retrieval of the <see cref="BillOfMaterialRecord" /> instances in a Microsoft SQL Server database.
    /// </summary>
    /// <remarks>
    ///     THIS CODE HAS BEEN AUTOMATICALLY GENERATED USING THE CONSENSUS DEVELOPER TOOLS.
    ///     DO NOT EDIT THIS CODE AS ANY CUSTOM MODIFICATIONS WILL BE LOST UPON REGENERATION.
    /// </remarks>
    public partial class SqlServerBillOfMaterialRepository : SqlServerRepository<BillOfMaterialRecord, String>, IBillOfMaterialRepository
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
            get { return "BillOfMaterial"; }
        }

        /// <summary>
        ///     Gets the name of the parameter which is used to specify the unique value that identifies each instance of a <see cref="BillOfMaterialRecord" />.
        /// </summary>
        protected override String TypeKeyName
        {
            get { return "@PA_BOM_ID"; }
        }

        /// <summary>
        ///     Gets the underlying table name that this repository sit over.
        /// </summary>
        public override String TableName
        {
            get { return "Bill_Of_Material"; }
        }

        #endregion

        #region methods

        /// <summary>
        ///     Maps an <see cref="IDataRecord" /> to the specified <see cref="BillOfMaterialRecord" />.
        /// </summary>
        /// <param name="dataRecord">
        ///     The <see cref="IDataRecord" /> to be mapped.
        /// </param>
        /// <param name="record">
        ///     The <see cref="BillOfMaterialRecord" /> instance to be mapped to.
        /// </param>
        protected override void MapRecord(IDataRecord dataRecord, BillOfMaterialRecord record)
        {
            record.Id = dataRecord["BOM_ID"].ConvertTo<String>();
            record.Lock = dataRecord["BOM_LOCK"].ConvertTo<String>();
            record.AddDate = dataRecord["BOM_ADD_DATE"].ConvertTo<DateTime?>();
            record.AddBy = dataRecord["BOM_ADD_BY"].ConvertTo<String>();
            record.ModDate = dataRecord["BOM_MOD_DATE"].ConvertTo<DateTime?>();
            record.ModBy = dataRecord["BOM_MOD_BY"].ConvertTo<String>();
            record.RcvDate = dataRecord["BOM_RCV_DATE"].ConvertTo<DateTime?>();
            record.RcvFrom = dataRecord["BOM_RCV_FROM"].ConvertTo<String>();
            record.ParentId = dataRecord["BOM_PARENT_ID"].ConvertTo<String>();
            record.SyllabusId = dataRecord["BOM_SYLLABUS_ID"].ConvertTo<String>();
            record.LocationId = dataRecord["BOM_LOCATION_ID"].ConvertTo<String>();
            record.ResourceId = dataRecord["BOM_RESOURCE_ID"].ConvertTo<String>();
            record.Type = dataRecord["BOM_TYPE"].ConvertTo<String>();
            record.Real = dataRecord["BOM_REAL"].ConvertTo<Byte?>();
            record.Session = dataRecord["BOM_SESSION"].ConvertTo<Byte?>();
            record.Element = dataRecord["BOM_ELEMENT"].ConvertTo<Byte?>();
            record.StartDay = dataRecord["BOM_START_DAY"].ConvertTo<Double?>();
            record.EndDay = dataRecord["BOM_END_DAY"].ConvertTo<Double?>();
            record.StartTime = dataRecord["BOM_START_TIME"].ConvertTo<DateTime?>();
            record.EndTime = dataRecord["BOM_END_TIME"].ConvertTo<DateTime?>();
            record.Quantity = dataRecord["BOM_QUANTITY"].ConvertTo<Double?>();
            record.Mandatory = dataRecord["BOM_MANDATORY"].ConvertTo<Byte?>();
            record.Stream = dataRecord["BOM_STREAM"].ConvertTo<String>();
            record.Chargeable = dataRecord["BOM_CHARGEABLE"].ConvertTo<Byte?>();
            record.InvoicePrint = dataRecord["BOM_INVOICE_PRINT"].ConvertTo<Byte?>();
            record.ActType = dataRecord["BOM_ACT_TYPE"].ConvertTo<String>();
            record.ShowSales = dataRecord["BOM_SHOW_SALES"].ConvertTo<Byte?>();
            record.ActNote = dataRecord["BOM_ACT_NOTE"].ConvertTo<String>();
            record.Subject = dataRecord["BOM_SUBJECT"].ConvertTo<String>();
            record.ValToRev = dataRecord["BOM_VAL_TO_REV"].ConvertTo<Double?>();
            record.MainSession = dataRecord["BOM_MAIN_SESSION"].ConvertTo<Byte?>();
            record.TypeSub = dataRecord["BOM_TYPE_SUB"].ConvertTo<String>();
            record.RoomLayout = dataRecord["BOM_ROOM_LAYOUT"].ConvertTo<Int32?>();
            record.IncInBudget = dataRecord["BOM_INC_IN_BUDGET"].ConvertTo<Byte>();
            record.TeachHrs = dataRecord["BOM_TEACH_HRS"].ConvertTo<Decimal?>();
            record.StudWks = dataRecord["BOM_STUD_WKS"].ConvertTo<Decimal?>();
            record.NotinuseStart = dataRecord["BOM_NOTINUSE_START"].ConvertTo<Int32?>();
            record.NotinuseEnd = dataRecord["BOM_NOTINUSE_END"].ConvertTo<Int32?>();
            record.ActSessionName = dataRecord["BOM_ACT_SESSION_NAME"].ConvertTo<String>();
            record.NoSlots = dataRecord["BOM_NO_SLOTS"].ConvertTo<Int32?>();
            record.StartSlot = dataRecord["BOM_START_SLOT"].ConvertTo<Int32?>();
            record.Predeliv = dataRecord["BOM_PREDELIV"].ConvertTo<Byte>();
            record.Code = dataRecord["BOM_CODE"].ConvertTo<String>();
            record.ProvPack = dataRecord["BOM_PROV_PACK"].ConvertTo<String>();
            record.ConfPack = dataRecord["BOM_CONF_PACK"].ConvertTo<String>();
            record.JoiningPack = dataRecord["BOM_JOINING_PACK"].ConvertTo<String>();
            record.PostPack = dataRecord["BOM_POST_PACK"].ConvertTo<String>();
            record.ProvSendToBook = dataRecord["BOM_PROV_SEND_TO_BOOK"].ConvertTo<Byte>();
            record.ProvSendToDel = dataRecord["BOM_PROV_SEND_TO_DEL"].ConvertTo<Byte>();
            record.ConfSendToBook = dataRecord["BOM_CONF_SEND_TO_BOOK"].ConvertTo<Byte>();
            record.ConfSendToDel = dataRecord["BOM_CONF_SEND_TO_DEL"].ConvertTo<Byte>();
            record.JoiningSendToBook = dataRecord["BOM_JOINING_SEND_TO_BOOK"].ConvertTo<Byte>();
            record.JoiningSendToDel = dataRecord["BOM_JOINING_SEND_TO_DEL"].ConvertTo<Byte>();
            record.PostSendToBook = dataRecord["BOM_POST_SEND_TO_BOOK"].ConvertTo<Byte>();
            record.PostSendToDel = dataRecord["BOM_POST_SEND_TO_DEL"].ConvertTo<Byte>();
            record.ProductSelectGroup = dataRecord["BOM_PSG_ID"].ConvertTo<Int32?>();
            record.ActRevenueSplit = dataRecord["BOM_ACT_REVENUE_SPLIT"].ConvertTo<Double>();
            record.ActHoursSplit = dataRecord["BOM_ACT_HOURS_SPLIT"].ConvertTo<Double>();
            record.ExpOccupancy = dataRecord["BOM_EXP_OCCUPANCY"].ConvertTo<Int32?>();
            record.ShowAttLog = dataRecord["BOM_SHOW_ATT_LOG"].ConvertTo<Byte?>();
        }

        /// <summary>
        ///     Sets the parameter values for the specified <paramref name="command" /> based on the specified <typeparamref name="TRecord" /> instance.
        /// </summary>
        /// <param name="command">
        ///     The <see cref="IDbCommand" /> containing the parameters to be mapped.
        /// </param>
        /// <param name="record">
        ///     The <see cref="BillOfMaterialRecord" /> instance to be mapped.
        /// </param>
        /// <param name="useV6Logic">
        ///     Is the procedure being run an old version 6.x procedure? (the null value handling logic is different).
        /// </param>
        protected override void MapParametersIn(IDbCommand command, BillOfMaterialRecord record, bool useV6Logic)
        {
            this.MapParameterIn(command, "@PA_BOM_ID", record.Id);
            this.MapParameterIn(command, "@PA_BOM_LOCK", record.Lock);
            this.MapParameterIn(command, "@PA_BOM_PARENT_ID", record.ParentId);
            this.MapParameterIn(command, "@PA_BOM_SYLLABUS_ID", record.SyllabusId);
            this.MapParameterIn(command, "@PA_BOM_LOCATION_ID", record.LocationId);
            this.MapParameterIn(command, "@PA_BOM_RESOURCE_ID", record.ResourceId);
            this.MapParameterIn(command, "@PA_BOM_TYPE", record.Type);
            this.MapParameterIn(command, "@PA_BOM_REAL", record.Real);
            this.MapParameterIn(command, "@PA_BOM_SESSION", record.Session);
            this.MapParameterIn(command, "@PA_BOM_ELEMENT", record.Element);
            this.MapParameterIn(command, "@PA_BOM_START_DAY", record.StartDay == Double.MinValue ? ( useV6Logic ? new Double?(0) : null ) : record.StartDay);
            this.MapParameterIn(command, "@PA_BOM_END_DAY", record.EndDay == Double.MinValue ? ( useV6Logic ? new Double?(0) : null ) : record.EndDay);
            this.MapParameterIn(command, "@PA_BOM_START_TIME", record.StartTime == DateTime.MinValue ? ( useV6Logic ? new DateTime?(new DateTime(1900,1,1)) : null ) : record.StartTime);
            this.MapParameterIn(command, "@PA_BOM_END_TIME", record.EndTime == DateTime.MinValue ? ( useV6Logic ? new DateTime?(new DateTime(1900,1,1)) : null ) : record.EndTime);
            this.MapParameterIn(command, "@PA_BOM_QUANTITY", record.Quantity == Double.MinValue ? ( useV6Logic ? new Double?(0) : null ) : record.Quantity);
            this.MapParameterIn(command, "@PA_BOM_MANDATORY", record.Mandatory);
            this.MapParameterIn(command, "@PA_BOM_STREAM", record.Stream);
            this.MapParameterIn(command, "@PA_BOM_CHARGEABLE", record.Chargeable);
            this.MapParameterIn(command, "@PA_BOM_INVOICE_PRINT", record.InvoicePrint);
            this.MapParameterIn(command, "@PA_BOM_ACT_TYPE", record.ActType);
            this.MapParameterIn(command, "@PA_BOM_SHOW_SALES", record.ShowSales);
            this.MapParameterIn(command, "@PA_BOM_ACT_NOTE", record.ActNote);
            this.MapParameterIn(command, "@PA_BOM_SUBJECT", record.Subject);
            this.MapParameterIn(command, "@PA_BOM_VAL_TO_REV", record.ValToRev == Double.MinValue ? ( useV6Logic ? new Double?(0) : null ) : record.ValToRev);
            this.MapParameterIn(command, "@PA_BOM_MAIN_SESSION", record.MainSession);
            this.MapParameterIn(command, "@PA_BOM_TYPE_SUB", record.TypeSub);
            this.MapParameterIn(command, "@PA_BOM_ROOM_LAYOUT", record.RoomLayout == Int32.MinValue ? ( useV6Logic ? new Int32?(0) : null ) : record.RoomLayout);
            this.MapParameterIn(command, "@PA_BOM_INC_IN_BUDGET", record.IncInBudget);
            this.MapParameterIn(command, "@PA_BOM_TEACH_HRS", record.TeachHrs == Decimal.MinValue ? ( useV6Logic ? new Decimal?(0M) : null ) : record.TeachHrs);
            this.MapParameterIn(command, "@PA_BOM_STUD_WKS", record.StudWks == Decimal.MinValue ? ( useV6Logic ? new Decimal?(0M) : null ) : record.StudWks);
            this.MapParameterIn(command, "@PA_BOM_NOTINUSE_START", record.NotinuseStart == Int32.MinValue ? ( useV6Logic ? new Int32?(0) : null ) : record.NotinuseStart);
            this.MapParameterIn(command, "@PA_BOM_NOTINUSE_END", record.NotinuseEnd == Int32.MinValue ? ( useV6Logic ? new Int32?(0) : null ) : record.NotinuseEnd);
            this.MapParameterIn(command, "@PA_BOM_ACT_SESSION_NAME", record.ActSessionName);
            this.MapParameterIn(command, "@PA_BOM_NO_SLOTS", record.NoSlots == Int32.MinValue ? ( useV6Logic ? new Int32?(0) : null ) : record.NoSlots);
            this.MapParameterIn(command, "@PA_BOM_START_SLOT", record.StartSlot == Int32.MinValue ? ( useV6Logic ? new Int32?(0) : null ) : record.StartSlot);
            this.MapParameterIn(command, "@PA_BOM_PREDELIV", record.Predeliv);
            this.MapParameterIn(command, "@PA_BOM_CODE", record.Code);
            this.MapParameterIn(command, "@PA_BOM_PROV_PACK", record.ProvPack);
            this.MapParameterIn(command, "@PA_BOM_CONF_PACK", record.ConfPack);
            this.MapParameterIn(command, "@PA_BOM_JOINING_PACK", record.JoiningPack);
            this.MapParameterIn(command, "@PA_BOM_POST_PACK", record.PostPack);
            this.MapParameterIn(command, "@PA_BOM_PROV_SEND_TO_BOOK", record.ProvSendToBook);
            this.MapParameterIn(command, "@PA_BOM_PROV_SEND_TO_DEL", record.ProvSendToDel);
            this.MapParameterIn(command, "@PA_BOM_CONF_SEND_TO_BOOK", record.ConfSendToBook);
            this.MapParameterIn(command, "@PA_BOM_CONF_SEND_TO_DEL", record.ConfSendToDel);
            this.MapParameterIn(command, "@PA_BOM_JOINING_SEND_TO_BOOK", record.JoiningSendToBook);
            this.MapParameterIn(command, "@PA_BOM_JOINING_SEND_TO_DEL", record.JoiningSendToDel);
            this.MapParameterIn(command, "@PA_BOM_POST_SEND_TO_BOOK", record.PostSendToBook);
            this.MapParameterIn(command, "@PA_BOM_POST_SEND_TO_DEL", record.PostSendToDel);
            this.MapParameterIn(command, "@PA_BOM_PSG_ID", record.ProductSelectGroup == Int32.MinValue ? ( useV6Logic ? new Int32?(0) : null ) : record.ProductSelectGroup);
            this.MapParameterIn(command, "@PA_BOM_ACT_REVENUE_SPLIT", record.ActRevenueSplit == Double.MinValue ? 0 : record.ActRevenueSplit);
            this.MapParameterIn(command, "@PA_BOM_ACT_HOURS_SPLIT", record.ActHoursSplit == Double.MinValue ? 0 : record.ActHoursSplit);
            this.MapParameterIn(command, "@PA_BOM_EXP_OCCUPANCY", record.ExpOccupancy == Int32.MinValue ? ( useV6Logic ? new Int32?(0) : null ) : record.ExpOccupancy);
            this.MapParameterIn(command, "@PA_BOM_SHOW_ATT_LOG", record.ShowAttLog);
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
        ///     The <see cref="BillOfMaterialRecord" /> instance to be updated.
        /// </param>
        protected override void MapParametersOut(IDbCommand command, BillOfMaterialRecord record)
        {
            record.Id = this.MapParameterOut(command, "@PA_BOM_ID", record.Id);
            record.Lock = this.MapParameterOut(command, "@PA_BOM_LOCK", record.Lock);
            record.ParentId = this.MapParameterOut(command, "@PA_BOM_PARENT_ID", record.ParentId);
            record.SyllabusId = this.MapParameterOut(command, "@PA_BOM_SYLLABUS_ID", record.SyllabusId);
            record.LocationId = this.MapParameterOut(command, "@PA_BOM_LOCATION_ID", record.LocationId);
            record.ResourceId = this.MapParameterOut(command, "@PA_BOM_RESOURCE_ID", record.ResourceId);
            record.Type = this.MapParameterOut(command, "@PA_BOM_TYPE", record.Type);
            record.Real = this.MapParameterOut(command, "@PA_BOM_REAL", record.Real);
            record.Session = this.MapParameterOut(command, "@PA_BOM_SESSION", record.Session);
            record.Element = this.MapParameterOut(command, "@PA_BOM_ELEMENT", record.Element);
            record.StartDay = this.MapParameterOut(command, "@PA_BOM_START_DAY", record.StartDay);
            record.EndDay = this.MapParameterOut(command, "@PA_BOM_END_DAY", record.EndDay);
            record.StartTime = this.MapParameterOut(command, "@PA_BOM_START_TIME", record.StartTime);
            record.EndTime = this.MapParameterOut(command, "@PA_BOM_END_TIME", record.EndTime);
            record.Quantity = this.MapParameterOut(command, "@PA_BOM_QUANTITY", record.Quantity);
            record.Mandatory = this.MapParameterOut(command, "@PA_BOM_MANDATORY", record.Mandatory);
            record.Stream = this.MapParameterOut(command, "@PA_BOM_STREAM", record.Stream);
            record.Chargeable = this.MapParameterOut(command, "@PA_BOM_CHARGEABLE", record.Chargeable);
            record.InvoicePrint = this.MapParameterOut(command, "@PA_BOM_INVOICE_PRINT", record.InvoicePrint);
            record.ActType = this.MapParameterOut(command, "@PA_BOM_ACT_TYPE", record.ActType);
            record.ShowSales = this.MapParameterOut(command, "@PA_BOM_SHOW_SALES", record.ShowSales);
            record.ActNote = this.MapParameterOut(command, "@PA_BOM_ACT_NOTE", record.ActNote);
            record.Subject = this.MapParameterOut(command, "@PA_BOM_SUBJECT", record.Subject);
            record.ValToRev = this.MapParameterOut(command, "@PA_BOM_VAL_TO_REV", record.ValToRev);
            record.MainSession = this.MapParameterOut(command, "@PA_BOM_MAIN_SESSION", record.MainSession);
            record.TypeSub = this.MapParameterOut(command, "@PA_BOM_TYPE_SUB", record.TypeSub);
            record.RoomLayout = this.MapParameterOut(command, "@PA_BOM_ROOM_LAYOUT", record.RoomLayout);
            record.IncInBudget = this.MapParameterOut(command, "@PA_BOM_INC_IN_BUDGET", record.IncInBudget);
            record.TeachHrs = this.MapParameterOut(command, "@PA_BOM_TEACH_HRS", record.TeachHrs);
            record.StudWks = this.MapParameterOut(command, "@PA_BOM_STUD_WKS", record.StudWks);
            record.NotinuseStart = this.MapParameterOut(command, "@PA_BOM_NOTINUSE_START", record.NotinuseStart);
            record.NotinuseEnd = this.MapParameterOut(command, "@PA_BOM_NOTINUSE_END", record.NotinuseEnd);
            record.ActSessionName = this.MapParameterOut(command, "@PA_BOM_ACT_SESSION_NAME", record.ActSessionName);
            record.NoSlots = this.MapParameterOut(command, "@PA_BOM_NO_SLOTS", record.NoSlots);
            record.StartSlot = this.MapParameterOut(command, "@PA_BOM_START_SLOT", record.StartSlot);
            record.Predeliv = this.MapParameterOut(command, "@PA_BOM_PREDELIV", record.Predeliv);
            record.Code = this.MapParameterOut(command, "@PA_BOM_CODE", record.Code);
            record.ProvPack = this.MapParameterOut(command, "@PA_BOM_PROV_PACK", record.ProvPack);
            record.ConfPack = this.MapParameterOut(command, "@PA_BOM_CONF_PACK", record.ConfPack);
            record.JoiningPack = this.MapParameterOut(command, "@PA_BOM_JOINING_PACK", record.JoiningPack);
            record.PostPack = this.MapParameterOut(command, "@PA_BOM_POST_PACK", record.PostPack);
            record.ProvSendToBook = this.MapParameterOut(command, "@PA_BOM_PROV_SEND_TO_BOOK", record.ProvSendToBook);
            record.ProvSendToDel = this.MapParameterOut(command, "@PA_BOM_PROV_SEND_TO_DEL", record.ProvSendToDel);
            record.ConfSendToBook = this.MapParameterOut(command, "@PA_BOM_CONF_SEND_TO_BOOK", record.ConfSendToBook);
            record.ConfSendToDel = this.MapParameterOut(command, "@PA_BOM_CONF_SEND_TO_DEL", record.ConfSendToDel);
            record.JoiningSendToBook = this.MapParameterOut(command, "@PA_BOM_JOINING_SEND_TO_BOOK", record.JoiningSendToBook);
            record.JoiningSendToDel = this.MapParameterOut(command, "@PA_BOM_JOINING_SEND_TO_DEL", record.JoiningSendToDel);
            record.PostSendToBook = this.MapParameterOut(command, "@PA_BOM_POST_SEND_TO_BOOK", record.PostSendToBook);
            record.PostSendToDel = this.MapParameterOut(command, "@PA_BOM_POST_SEND_TO_DEL", record.PostSendToDel);
            record.ProductSelectGroup = this.MapParameterOut(command, "@PA_BOM_PSG_ID", record.ProductSelectGroup);
            record.ActRevenueSplit = this.MapParameterOut(command, "@PA_BOM_ACT_REVENUE_SPLIT", record.ActRevenueSplit);
            record.ActHoursSplit = this.MapParameterOut(command, "@PA_BOM_ACT_HOURS_SPLIT", record.ActHoursSplit);
            record.ExpOccupancy = this.MapParameterOut(command, "@PA_BOM_EXP_OCCUPANCY", record.ExpOccupancy);
            record.ShowAttLog = this.MapParameterOut(command, "@PA_BOM_SHOW_ATT_LOG", record.ShowAttLog);
            record.Id = this.MapParameterOut(command, "@PA_RETURN_ID", record.Id);
        }

        /// <summary>
        ///     Retrieves a collection of <see cref="BillOfMaterialRecord" /> instances from the data store.
        /// </summary>
        /// <param name="parentId">
        ///     The value which identifies the <see cref='BillOfMaterialModel' /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The collection of <see cref="BillOfMaterialRecord" /> instances that match the specified <paramref name='parentId' />.
        /// </returns>
        public IEnumerable<BillOfMaterialRecord> FetchAllByParentId(String parentId)
        {
            DbCommand command = this.GetStoredProcedure(SqlServerOperation.FetchAll, "ParentId");
            this.MapParameterIn(command, "@PA_BOM_PARENT_ID", parentId);
            return this.Execute(command);
        }

        /// <summary>
        ///     Retrieves a collection of <see cref="BillOfMaterialRecord" /> instances from the data store.
        /// </summary>
        /// <param name="syllabusId">
        ///     The value which identifies the <see cref='BillOfMaterialModel' /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The collection of <see cref="BillOfMaterialRecord" /> instances that match the specified <paramref name='syllabusId' />.
        /// </returns>
        public IEnumerable<BillOfMaterialRecord> FetchAllBySyllabusId(String syllabusId)
        {
            DbCommand command = this.GetStoredProcedure(SqlServerOperation.FetchAll, "SyllabusId");
            this.MapParameterIn(command, "@PA_BOM_SYLLABUS_ID", syllabusId);
            return this.Execute(command);
        }

        /// <summary>
        ///     Retrieves a collection of <see cref="BillOfMaterialRecord" /> instances from the data store.
        /// </summary>
        /// <param name="resourceId">
        ///     The value which identifies the <see cref='BillOfMaterialModel' /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The collection of <see cref="BillOfMaterialRecord" /> instances that match the specified <paramref name='resourceId' />.
        /// </returns>
        public IEnumerable<BillOfMaterialRecord> FetchAllByResourceId(String resourceId)
        {
            DbCommand command = this.GetStoredProcedure(SqlServerOperation.FetchAll, "ResourceId");
            this.MapParameterIn(command, "@PA_BOM_RESOURCE_ID", resourceId);
            return this.Execute(command);
        }

        /// <summary>
        ///     Retrieves a collection of <see cref="BillOfMaterialRecord" /> instances from the data store.
        /// </summary>
        /// <param name="productSelectGroup">
        ///     The value which identifies the <see cref='BillOfMaterialModel' /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The collection of <see cref="BillOfMaterialRecord" /> instances that match the specified <paramref name='productSelectGroup' />.
        /// </returns>
        public IEnumerable<BillOfMaterialRecord> FetchAllByProductSelectGroup(Int32? productSelectGroup)
        {
            DbCommand command = this.GetStoredProcedure(SqlServerOperation.FetchAll, "ProductSelectGroup");
            this.MapParameterIn(command, "@PA_BOM_PSG_ID", productSelectGroup);
            return this.Execute(command);
        }

        #endregion

        #region implementations

        /// <summary>
        ///     Gets the underlying table name that this repository sit over.
        /// </summary>
        System.String IBillOfMaterialRepository.TableName
        {
            get { return this.TableName; }
        }

        void IBillOfMaterialRepository.Modify(Consensus.Learning.BillOfMaterialRecord record)
        {
            this.Modify(record);
        }

        void IBillOfMaterialRepository.Create(Consensus.Learning.BillOfMaterialRecord record)
        {
            this.Create(record);
        }

        /// <summary>
        ///     Retrieves a collection of <see cref="T:Consensus.Learning.BillOfMaterialRecord" /> instances from the data store.
        /// </summary>
        /// <param name="parentId">
        ///     The value which identifies the <see cref="!:BillOfMaterialModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The collection of <see cref="T:Consensus.Learning.BillOfMaterialRecord" /> instances that match the specified <paramref name="parentId" />.
        /// </returns>
        System.Collections.Generic.IEnumerable<Consensus.Learning.BillOfMaterialRecord> IBillOfMaterialRepository.FetchAllByParentId(System.String parentId)
        {
            return this.FetchAllByParentId(parentId);
        }

        /// <summary>
        ///     Retrieves a collection of <see cref="T:Consensus.Learning.BillOfMaterialRecord" /> instances from the data store.
        /// </summary>
        /// <param name="syllabusId">
        ///     The value which identifies the <see cref="!:BillOfMaterialModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The collection of <see cref="T:Consensus.Learning.BillOfMaterialRecord" /> instances that match the specified <paramref name="syllabusId" />.
        /// </returns>
        System.Collections.Generic.IEnumerable<Consensus.Learning.BillOfMaterialRecord> IBillOfMaterialRepository.FetchAllBySyllabusId(System.String syllabusId)
        {
            return this.FetchAllBySyllabusId(syllabusId);
        }

        /// <summary>
        ///     Retrieves a collection of <see cref="T:Consensus.Learning.BillOfMaterialRecord" /> instances from the data store.
        /// </summary>
        /// <param name="resourceId">
        ///     The value which identifies the <see cref="!:BillOfMaterialModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The collection of <see cref="T:Consensus.Learning.BillOfMaterialRecord" /> instances that match the specified <paramref name="resourceId" />.
        /// </returns>
        System.Collections.Generic.IEnumerable<Consensus.Learning.BillOfMaterialRecord> IBillOfMaterialRepository.FetchAllByResourceId(System.String resourceId)
        {
            return this.FetchAllByResourceId(resourceId);
        }

        System.Collections.Generic.IEnumerable<Consensus.Learning.BillOfMaterialRecord> IBillOfMaterialRepository.FetchAllByProductSelectGroup(System.Nullable<System.Int32> productSelectGroup)
        {
            return this.FetchAllByProductSelectGroup(productSelectGroup);
        }

        #endregion
    }
}
