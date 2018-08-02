using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Linq;

namespace Consensus.Common
{
    /// <summary>
    ///     Provides the persistence and retrieval of the <see cref="AttachmentDataRecord" /> instances in a Microsoft SQL Server database.
    /// </summary>
    /// <remarks>
    ///     THIS CODE HAS BEEN AUTOMATICALLY GENERATED USING THE CONSENSUS DEVELOPER TOOLS.
    ///     DO NOT EDIT THIS CODE AS ANY CUSTOM MODIFICATIONS WILL BE LOST UPON REGENERATION.
    /// </remarks>
    public partial class SqlServerAttachmentDataRepository : SqlServerRepository<AttachmentDataRecord, Int32>, IAttachmentDataRepository
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
            get { return "AttachmentData"; }
        }

        /// <summary>
        ///     Gets the name of the parameter which is used to specify the unique value that identifies each instance of a <see cref="AttachmentDataRecord" />.
        /// </summary>
        protected override String TypeKeyName
        {
            get { return "@PA_ATTD_ID"; }
        }

        /// <summary>
        ///     Gets the underlying table name that this repository sit over.
        /// </summary>
        public override String TableName
        {
            get { return "Attachment_Data"; }
        }

        #endregion

        #region methods

        /// <summary>
        ///     Maps an <see cref="IDataRecord" /> to the specified <see cref="AttachmentDataRecord" />.
        /// </summary>
        /// <param name="dataRecord">
        ///     The <see cref="IDataRecord" /> to be mapped.
        /// </param>
        /// <param name="record">
        ///     The <see cref="AttachmentDataRecord" /> instance to be mapped to.
        /// </param>
        protected override void MapRecord(IDataRecord dataRecord, AttachmentDataRecord record)
        {
            record.Id = dataRecord["ATTD_ID"].ConvertTo<Int32>();
            record.AttId = dataRecord["ATTD_ATT_ID"].ConvertTo<String>();
            record.VersionNo = dataRecord["ATTD_VERSION_NO"].ConvertTo<Double?>();
            record.Binary = dataRecord["ATTD_BINARY"].ConvertTo<Byte[]>();
            record.Text = dataRecord["ATTD_TEXT"].ConvertTo<String>();
        }

        /// <summary>
        ///     Sets the parameter values for the specified <paramref name="command" /> based on the specified <typeparamref name="TRecord" /> instance.
        /// </summary>
        /// <param name="command">
        ///     The <see cref="IDbCommand" /> containing the parameters to be mapped.
        /// </param>
        /// <param name="record">
        ///     The <see cref="AttachmentDataRecord" /> instance to be mapped.
        /// </param>
        /// <param name="useV6Logic">
        ///     Is the procedure being run an old version 6.x procedure? (the null value handling logic is different).
        /// </param>
        protected override void MapParametersIn(IDbCommand command, AttachmentDataRecord record, bool useV6Logic)
        {
            this.MapParameterIn(command, "@PA_ATTD_ID", record.Id == Int32.MinValue ? ( useV6Logic ? new Int32?(0) : null ) : record.Id);
            this.MapParameterIn(command, "@PA_ATTD_ATT_ID", record.AttId);
            this.MapParameterIn(command, "@PA_ATTD_VERSION_NO", record.VersionNo == Double.MinValue ? ( useV6Logic ? new Double?(0) : null ) : record.VersionNo);
            this.MapParameterIn(command, "@PA_ATTD_BINARY", record.Binary);
            this.MapParameterIn(command, "@PA_ATTD_TEXT", record.Text);
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
        ///     The <see cref="AttachmentDataRecord" /> instance to be updated.
        /// </param>
        protected override void MapParametersOut(IDbCommand command, AttachmentDataRecord record)
        {
            record.Id = this.MapParameterOut(command, "@PA_ATTD_ID", record.Id);
            record.AttId = this.MapParameterOut(command, "@PA_ATTD_ATT_ID", record.AttId);
            record.VersionNo = this.MapParameterOut(command, "@PA_ATTD_VERSION_NO", record.VersionNo);
            record.Binary = this.MapParameterOut(command, "@PA_ATTD_BINARY", record.Binary);
            record.Text = this.MapParameterOut(command, "@PA_ATTD_TEXT", record.Text);
            record.Id = this.MapParameterOut(command, "@PA_RETURN_ID", record.Id);
        }

        /// <summary>
        ///     Retrieves a collection of <see cref="AttachmentDataRecord" /> instances from the data store.
        /// </summary>
        /// <param name="attId">
        ///     The value which identifies the <see cref='AttachmentDataModel' /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The collection of <see cref="AttachmentDataRecord" /> instances that match the specified <paramref name='attId' />.
        /// </returns>
        public IEnumerable<AttachmentDataRecord> FetchAllByAttId(String attId)
        {
            DbCommand command = this.GetStoredProcedure(SqlServerOperation.FetchAll, "AttId");
            this.MapParameterIn(command, "@PA_ATTD_ATT_ID", attId);
            return this.Execute(command);
        }

        #endregion

        #region implementations

        /// <summary>
        ///     Gets the underlying table name that this repository sit over.
        /// </summary>
        System.String IAttachmentDataRepository.TableName
        {
            get { return this.TableName; }
        }

        /// <summary>
        ///     Retrieves a collection of <see cref="T:Consensus.Common.AttachmentDataRecord" /> instances from the data store.
        /// </summary>
        /// <param name="attId">
        ///     The value which identifies the <see cref="!:AttachmentDataModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The collection of <see cref="T:Consensus.Common.AttachmentDataRecord" /> instances that match the specified <paramref name="attId" />.
        /// </returns>
        System.Collections.Generic.IEnumerable<Consensus.Common.AttachmentDataRecord> IAttachmentDataRepository.FetchAllByAttId(System.String attId)
        {
            return this.FetchAllByAttId(attId);
        }

        #endregion
    }
}
