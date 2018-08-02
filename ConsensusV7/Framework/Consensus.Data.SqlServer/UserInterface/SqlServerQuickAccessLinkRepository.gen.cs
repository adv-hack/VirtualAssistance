using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Linq;

namespace Consensus.UserInterface
{
    /// <summary>
    ///     Provides the persistence and retrieval of the <see cref="QuickaccesslinkRecord" /> instances in a Microsoft SQL Server database.
    /// </summary>
    /// <remarks>
    ///     THIS CODE HAS BEEN AUTOMATICALLY GENERATED USING THE CONSENSUS DEVELOPER TOOLS.
    ///     DO NOT EDIT THIS CODE AS ANY CUSTOM MODIFICATIONS WILL BE LOST UPON REGENERATION.
    /// </remarks>
    public partial class SqlServerQuickAccessLinkRepository : SqlServerRepository<QuickaccesslinkRecord, Int32>, IQuickAccessLinkRepository
    {
        #region properties

        /// <summary>
        ///     Gets the namespace in which the data type is contained.
        /// </summary>
        protected override String TypeNamespace
        {
            get { return "UserInterface"; }
        }

        /// <summary>
        ///     Gets the name of the data type which is persisted by this repository.
        /// </summary>
        protected override String TypeName
        {
            get { return "Quickaccesslink"; }
        }

        /// <summary>
        ///     Gets the name of the parameter which is used to specify the unique value that identifies each instance of a <see cref="QuickaccesslinkRecord" />.
        /// </summary>
        protected override String TypeKeyName
        {
            get { return "@PA_QAL_ID"; }
        }

        /// <summary>
        ///     Gets the underlying table name that this repository sit over.
        /// </summary>
        public override String TableName
        {
            get { return "QuickAccessLink"; }
        }

        #endregion

        #region methods

        /// <summary>
        ///     Maps an <see cref="IDataRecord" /> to the specified <see cref="QuickaccesslinkRecord" />.
        /// </summary>
        /// <param name="dataRecord">
        ///     The <see cref="IDataRecord" /> to be mapped.
        /// </param>
        /// <param name="record">
        ///     The <see cref="QuickaccesslinkRecord" /> instance to be mapped to.
        /// </param>
        protected override void MapRecord(IDataRecord dataRecord, QuickaccesslinkRecord record)
        {
            record.Id = dataRecord["QAL_ID"].ConvertTo<Int32>();
            record.AddDate = dataRecord["QAL_ADD_DATE"].ConvertTo<DateTime>();
            record.AddBy = dataRecord["QAL_ADD_BY"].ConvertTo<String>();
            record.ModDate = dataRecord["QAL_MOD_DATE"].ConvertTo<DateTime>();
            record.ModBy = dataRecord["QAL_MOD_BY"].ConvertTo<String>();
            record.UserId = dataRecord["QAL_USER_ID"].ConvertTo<Int32>();
            record.Description = dataRecord["QAL_DESCRIPTION"].ConvertTo<String>();
            record.Url = dataRecord["QAL_URL"].ConvertTo<String>();
            record.Icon = dataRecord["QAL_ICON"].ConvertTo<String>();
        }

        /// <summary>
        ///     Sets the parameter values for the specified <paramref name="command" /> based on the specified <typeparamref name="TRecord" /> instance.
        /// </summary>
        /// <param name="command">
        ///     The <see cref="IDbCommand" /> containing the parameters to be mapped.
        /// </param>
        /// <param name="record">
        ///     The <see cref="QuickaccesslinkRecord" /> instance to be mapped.
        /// </param>
        /// <param name="useV6Logic">
        ///     Is the procedure being run an old version 6.x procedure? (the null value handling logic is different).
        /// </param>
        protected override void MapParametersIn(IDbCommand command, QuickaccesslinkRecord record, bool useV6Logic)
        {
            this.MapParameterIn(command, "@PA_QAL_ID", record.Id == Int32.MinValue ? ( useV6Logic ? new Int32?(0) : null ) : record.Id);
            this.MapParameterIn(command, "@PA_QAL_USER_ID", record.UserId == Int32.MinValue ? ( useV6Logic ? new Int32?(0) : null ) : record.UserId);
            this.MapParameterIn(command, "@PA_QAL_DESCRIPTION", record.Description);
            this.MapParameterIn(command, "@PA_QAL_URL", record.Url);
            this.MapParameterIn(command, "@PA_QAL_ICON", record.Icon);
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
        ///     The <see cref="QuickaccesslinkRecord" /> instance to be updated.
        /// </param>
        protected override void MapParametersOut(IDbCommand command, QuickaccesslinkRecord record)
        {
            record.Id = this.MapParameterOut(command, "@PA_QAL_ID", record.Id);
            record.UserId = this.MapParameterOut(command, "@PA_QAL_USER_ID", record.UserId);
            record.Description = this.MapParameterOut(command, "@PA_QAL_DESCRIPTION", record.Description);
            record.Url = this.MapParameterOut(command, "@PA_QAL_URL", record.Url);
            record.Icon = this.MapParameterOut(command, "@PA_QAL_ICON", record.Icon);
            record.Id = this.MapParameterOut(command, "@PA_RETURN_ID", record.Id);
        }

        /// <summary>
        ///     Retrieves a collection of <see cref="QuickaccesslinkRecord" /> instances from the data store.
        /// </summary>
        /// <param name="userId">
        ///     The value which identifies the <see cref='QuickAccessLinkModel' /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The collection of <see cref="QuickaccesslinkRecord" /> instances that match the specified <paramref name='userId' />.
        /// </returns>
        public IEnumerable<QuickaccesslinkRecord> FetchAllByUserId(Int32 userId)
        {
            DbCommand command = this.GetStoredProcedure(SqlServerOperation.FetchAll, "UserId");
            this.MapParameterIn(command, "@PA_QAL_USER_ID", userId);
            return this.Execute(command);
        }

        #endregion

        #region implementations

        /// <summary>
        ///     Gets the underlying table name that this repository sit over.
        /// </summary>
        System.String IQuickAccessLinkRepository.TableName
        {
            get { return this.TableName; }
        }

        /// <summary>
        ///     Retrieves a collection of <see cref="T:Consensus.UserInterface.QuickaccesslinkRecord" /> instances from the data store.
        /// </summary>
        /// <param name="userId">
        ///     The value which identifies the <see cref="!:QuickAccessLinkModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The collection of <see cref="T:Consensus.UserInterface.QuickaccesslinkRecord" /> instances that match the specified <paramref name="userId" />.
        /// </returns>
        System.Collections.Generic.IEnumerable<Consensus.UserInterface.QuickaccesslinkRecord> IQuickAccessLinkRepository.FetchAllByUserId(System.Int32 userId)
        {
            return this.FetchAllByUserId(userId);
        }

        #endregion
    }
}
