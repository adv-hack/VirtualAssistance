using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Linq;

namespace Consensus.Activities
{
    /// <summary>
    ///     Provides the persistence and retrieval of the <see cref="C4textRecord" /> instances in a Microsoft SQL Server database.
    /// </summary>
    /// <remarks>
    ///     THIS CODE HAS BEEN AUTOMATICALLY GENERATED USING THE CONSENSUS DEVELOPER TOOLS.
    ///     DO NOT EDIT THIS CODE AS ANY CUSTOM MODIFICATIONS WILL BE LOST UPON REGENERATION.
    /// </remarks>
    public partial class SqlServerC4textRepository : SqlServerRepository<C4textRecord, String>, IC4textRepository
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
            get { return "C4text"; }
        }

        /// <summary>
        ///     Gets the name of the parameter which is used to specify the unique value that identifies each instance of a <see cref="C4textRecord" />.
        /// </summary>
        protected override String TypeKeyName
        {
            get { return "@PA_TEXT_ID"; }
        }

        /// <summary>
        ///     Gets the underlying table name that this repository sit over.
        /// </summary>
        public override String TableName
        {
            get { return "C4Text"; }
        }

        #endregion

        #region methods

        /// <summary>
        ///     Maps an <see cref="IDataRecord" /> to the specified <see cref="C4textRecord" />.
        /// </summary>
        /// <param name="dataRecord">
        ///     The <see cref="IDataRecord" /> to be mapped.
        /// </param>
        /// <param name="record">
        ///     The <see cref="C4textRecord" /> instance to be mapped to.
        /// </param>
        protected override void MapRecord(IDataRecord dataRecord, C4textRecord record)
        {
            record.Id = dataRecord["TEXT_ID"].ConvertTo<String>();
            record.AddDate = dataRecord["TEXT_ADD_DATE"].ConvertTo<DateTime?>();
            record.AddBy = dataRecord["TEXT_ADD_BY"].ConvertTo<String>();
            record.ModDate = dataRecord["TEXT_MOD_DATE"].ConvertTo<DateTime?>();
            record.ModBy = dataRecord["TEXT_MOD_BY"].ConvertTo<String>();
            record.RcvDate = dataRecord["TEXT_RCV_DATE"].ConvertTo<DateTime?>();
            record.RcvFrom = dataRecord["TEXT_RCV_FROM"].ConvertTo<String>();
            record.Type = dataRecord["TEXT_TYPE"].ConvertTo<String>();
            record.OwnerId = dataRecord["TEXT_OWNER_ID"].ConvertTo<String>();
            record.Body = dataRecord["TEXT_BODY"].ConvertTo<String>();
            record.Rtf = dataRecord["TEXT_RTF"].ConvertTo<String>();
            record.Html = dataRecord["TEXT_HTML"].ConvertTo<String>();
            record.OwnerUrl = dataRecord["TEXT_OWNER_URL"].ConvertTo<String>();
        }

        /// <summary>
        ///     Sets the parameter values for the specified <paramref name="command" /> based on the specified <typeparamref name="TRecord" /> instance.
        /// </summary>
        /// <param name="command">
        ///     The <see cref="IDbCommand" /> containing the parameters to be mapped.
        /// </param>
        /// <param name="record">
        ///     The <see cref="C4textRecord" /> instance to be mapped.
        /// </param>
        /// <param name="useV6Logic">
        ///     Is the procedure being run an old version 6.x procedure? (the null value handling logic is different).
        /// </param>
        protected override void MapParametersIn(IDbCommand command, C4textRecord record, bool useV6Logic)
        {
            this.MapParameterIn(command, "@PA_TEXT_ID", record.Id);
            this.MapParameterIn(command, "@PA_TEXT_TYPE", record.Type);
            this.MapParameterIn(command, "@PA_TEXT_OWNER_ID", record.OwnerId);
            this.MapParameterIn(command, "@PA_TEXT_BODY", record.Body);
            this.MapParameterIn(command, "@PA_TEXT_RTF", record.Rtf);
            this.MapParameterIn(command, "@PA_TEXT_HTML", record.Html);
            this.MapParameterIn(command, "@PA_TEXT_OWNER_URL", record.OwnerUrl);
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
        ///     The <see cref="C4textRecord" /> instance to be updated.
        /// </param>
        protected override void MapParametersOut(IDbCommand command, C4textRecord record)
        {
            record.Id = this.MapParameterOut(command, "@PA_TEXT_ID", record.Id);
            record.Type = this.MapParameterOut(command, "@PA_TEXT_TYPE", record.Type);
            record.OwnerId = this.MapParameterOut(command, "@PA_TEXT_OWNER_ID", record.OwnerId);
            record.Body = this.MapParameterOut(command, "@PA_TEXT_BODY", record.Body);
            record.Rtf = this.MapParameterOut(command, "@PA_TEXT_RTF", record.Rtf);
            record.Html = this.MapParameterOut(command, "@PA_TEXT_HTML", record.Html);
            record.OwnerUrl = this.MapParameterOut(command, "@PA_TEXT_OWNER_URL", record.OwnerUrl);
            record.Id = this.MapParameterOut(command, "@PA_RETURN_ID", record.Id);
        }

        #endregion

        #region implementations

        /// <summary>
        ///     Gets the underlying table name that this repository sit over.
        /// </summary>
        System.String IC4textRepository.TableName
        {
            get { return this.TableName; }
        }

        System.Collections.Generic.IEnumerable<Consensus.Activities.C4textRecord> IC4textRepository.FetchAllByOwnerUrlAndOwnerId(System.String ownerUrl, System.String ownerId)
        {
            return this.FetchAllByOwnerUrlAndOwnerId(ownerUrl, ownerId);
        }

        #endregion
    }
}
