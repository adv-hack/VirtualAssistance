using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Linq;

namespace Consensus.Common
{
    /// <summary>
    ///     Provides the persistence and retrieval of the <see cref="AttachlearningzonecategoriesRecord" /> instances in a Microsoft SQL Server database.
    /// </summary>
    /// <remarks>
    ///     THIS CODE HAS BEEN AUTOMATICALLY GENERATED USING THE CONSENSUS DEVELOPER TOOLS.
    ///     DO NOT EDIT THIS CODE AS ANY CUSTOM MODIFICATIONS WILL BE LOST UPON REGENERATION.
    /// </remarks>
    public partial class SqlServerAttachLearningZoneCategoriesRepository : SqlServerRepository<AttachlearningzonecategoriesRecord, Int32>, IAttachLearningZoneCategoriesRepository
    {
        #region properties

        /// <summary>
        ///     Gets the namespace in which the data type is contained.
        /// </summary>
        protected override String TypeNamespace
        {
            get { return "Common"; }
        }

        /// <summary>
        ///     Gets the name of the data type which is persisted by this repository.
        /// </summary>
        protected override String TypeName
        {
            get { return "Attachlearningzonecategories"; }
        }

        /// <summary>
        ///     Gets the name of the parameter which is used to specify the unique value that identifies each instance of a <see cref="AttachlearningzonecategoriesRecord" />.
        /// </summary>
        protected override String TypeKeyName
        {
            get { return "@PA_ATTLZC_ID"; }
        }

        /// <summary>
        ///     Gets the underlying table name that this repository sit over.
        /// </summary>
        public override String TableName
        {
            get { return "AttachLearningZoneCategories"; }
        }

        #endregion

        #region methods

        /// <summary>
        ///     Maps an <see cref="IDataRecord" /> to the specified <see cref="AttachlearningzonecategoriesRecord" />.
        /// </summary>
        /// <param name="dataRecord">
        ///     The <see cref="IDataRecord" /> to be mapped.
        /// </param>
        /// <param name="record">
        ///     The <see cref="AttachlearningzonecategoriesRecord" /> instance to be mapped to.
        /// </param>
        protected override void MapRecord(IDataRecord dataRecord, AttachlearningzonecategoriesRecord record)
        {
            record.Id = dataRecord["ATTLZC_ID"].ConvertTo<Int32>();
            record.AddDate = dataRecord["ATTLZC_ADD_DATE"].ConvertTo<DateTime>();
            record.AddBy = dataRecord["ATTLZC_ADD_BY"].ConvertTo<String>();
            record.ModDate = dataRecord["ATTLZC_MOD_DATE"].ConvertTo<DateTime>();
            record.ModBy = dataRecord["ATTLZC_MOD_BY"].ConvertTo<String>();
            record.AttId = dataRecord["ATTLZC_ATT_ID"].ConvertTo<String>();
            record.LzcId = dataRecord["ATTLZC_LZC_ID"].ConvertTo<Int32>();
        }

        /// <summary>
        ///     Sets the parameter values for the specified <paramref name="command" /> based on the specified <typeparamref name="TRecord" /> instance.
        /// </summary>
        /// <param name="command">
        ///     The <see cref="IDbCommand" /> containing the parameters to be mapped.
        /// </param>
        /// <param name="record">
        ///     The <see cref="AttachlearningzonecategoriesRecord" /> instance to be mapped.
        /// </param>
        /// <param name="useV6Logic">
        ///     Is the procedure being run an old version 6.x procedure? (the null value handling logic is different).
        /// </param>
        protected override void MapParametersIn(IDbCommand command, AttachlearningzonecategoriesRecord record, bool useV6Logic)
        {
            this.MapParameterIn(command, "@PA_ATTLZC_ID", record.Id == Int32.MinValue ? ( useV6Logic ? new Int32?(0) : null ) : record.Id);
            this.MapParameterIn(command, "@PA_ATTLZC_ATT_ID", record.AttId);
            this.MapParameterIn(command, "@PA_ATTLZC_LZC_ID", record.LzcId == Int32.MinValue ? ( useV6Logic ? new Int32?(0) : null ) : record.LzcId);
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
        ///     The <see cref="AttachlearningzonecategoriesRecord" /> instance to be updated.
        /// </param>
        protected override void MapParametersOut(IDbCommand command, AttachlearningzonecategoriesRecord record)
        {
            record.Id = this.MapParameterOut(command, "@PA_ATTLZC_ID", record.Id);
            record.AttId = this.MapParameterOut(command, "@PA_ATTLZC_ATT_ID", record.AttId);
            record.LzcId = this.MapParameterOut(command, "@PA_ATTLZC_LZC_ID", record.LzcId);
            record.Id = this.MapParameterOut(command, "@PA_RETURN_ID", record.Id);
        }

        /// <summary>
        ///     Retrieves a collection of <see cref="AttachlearningzonecategoriesRecord" /> instances from the data store.
        /// </summary>
        /// <param name="attId">
        ///     The value which identifies the <see cref='AttachLearningZoneCategoriesModel' /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The collection of <see cref="AttachlearningzonecategoriesRecord" /> instances that match the specified <paramref name='attId' />.
        /// </returns>
        public IEnumerable<AttachlearningzonecategoriesRecord> FetchAllByAttId(String attId)
        {
            DbCommand command = this.GetStoredProcedure(SqlServerOperation.FetchAll, "AttId");
            this.MapParameterIn(command, "@PA_ATTLZC_ATT_ID", attId);
            return this.Execute(command);
        }

        /// <summary>
        ///     Retrieves a collection of <see cref="AttachlearningzonecategoriesRecord" /> instances from the data store.
        /// </summary>
        /// <param name="lzcId">
        ///     The value which identifies the <see cref='AttachLearningZoneCategoriesModel' /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The collection of <see cref="AttachlearningzonecategoriesRecord" /> instances that match the specified <paramref name='lzcId' />.
        /// </returns>
        public IEnumerable<AttachlearningzonecategoriesRecord> FetchAllByLzcId(Int32 lzcId)
        {
            DbCommand command = this.GetStoredProcedure(SqlServerOperation.FetchAll, "LzcId");
            this.MapParameterIn(command, "@PA_ATTLZC_LZC_ID", lzcId);
            return this.Execute(command);
        }

        #endregion

        #region implementations

        /// <summary>
        ///     Gets the underlying table name that this repository sit over.
        /// </summary>
        System.String IAttachLearningZoneCategoriesRepository.TableName
        {
            get { return this.TableName; }
        }

        /// <summary>
        ///     Retrieves a collection of <see cref="T:Consensus.Common.AttachlearningzonecategoriesRecord" /> instances from the data store.
        /// </summary>
        /// <param name="attId">
        ///     The value which identifies the <see cref="!:AttachLearningZoneCategoriesModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The collection of <see cref="T:Consensus.Common.AttachlearningzonecategoriesRecord" /> instances that match the specified <paramref name="attId" />.
        /// </returns>
        System.Collections.Generic.IEnumerable<Consensus.Common.AttachlearningzonecategoriesRecord> IAttachLearningZoneCategoriesRepository.FetchAllByAttId(System.String attId)
        {
            return this.FetchAllByAttId(attId);
        }

        /// <summary>
        ///     Retrieves a collection of <see cref="T:Consensus.Common.AttachlearningzonecategoriesRecord" /> instances from the data store.
        /// </summary>
        /// <param name="lzcId">
        ///     The value which identifies the <see cref="!:AttachLearningZoneCategoriesModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The collection of <see cref="T:Consensus.Common.AttachlearningzonecategoriesRecord" /> instances that match the specified <paramref name="lzcId" />.
        /// </returns>
        System.Collections.Generic.IEnumerable<Consensus.Common.AttachlearningzonecategoriesRecord> IAttachLearningZoneCategoriesRepository.FetchAllByLzcId(System.Int32 lzcId)
        {
            return this.FetchAllByLzcId(lzcId);
        }

        #endregion
    }
}
