using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Linq;

namespace Consensus.Contact
{
    /// <summary>
    ///     Provides the persistence and retrieval of the <see cref="GiftaidRecord" /> instances in a Microsoft SQL Server database.
    /// </summary>
    /// <remarks>
    ///     THIS CODE HAS BEEN AUTOMATICALLY GENERATED USING THE CONSENSUS DEVELOPER TOOLS.
    ///     DO NOT EDIT THIS CODE AS ANY CUSTOM MODIFICATIONS WILL BE LOST UPON REGENERATION.
    /// </remarks>
    public partial class SqlServerGiftaidRepository : SqlServerRepository<GiftaidRecord, Int32>, IGiftaidRepository
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
            get { return "Giftaid"; }
        }

        /// <summary>
        ///     Gets the name of the parameter which is used to specify the unique value that identifies each instance of a <see cref="GiftaidRecord" />.
        /// </summary>
        protected override String TypeKeyName
        {
            get { return "@PA_GIF_ID"; }
        }

        /// <summary>
        ///     Gets the underlying table name that this repository sit over.
        /// </summary>
        public override String TableName
        {
            get { return "GiftAid"; }
        }

        #endregion

        #region methods

        /// <summary>
        ///     Maps an <see cref="IDataRecord" /> to the specified <see cref="GiftaidRecord" />.
        /// </summary>
        /// <param name="dataRecord">
        ///     The <see cref="IDataRecord" /> to be mapped.
        /// </param>
        /// <param name="record">
        ///     The <see cref="GiftaidRecord" /> instance to be mapped to.
        /// </param>
        protected override void MapRecord(IDataRecord dataRecord, GiftaidRecord record)
        {
            record.Id = dataRecord["GIF_ID"].ConvertTo<Int32>();
            record.AddDate = dataRecord["GIF_ADD_DATE"].ConvertTo<DateTime>();
            record.AddBy = dataRecord["GIF_ADD_BY"].ConvertTo<String>();
            record.ModDate = dataRecord["GIF_MOD_DATE"].ConvertTo<DateTime>();
            record.ModBy = dataRecord["GIF_MOD_BY"].ConvertTo<String>();
            record.PnId = dataRecord["GIF_PN_ID"].ConvertTo<String>();
            record.Type = dataRecord["GIF_TYPE"].ConvertTo<String>();
            record.Active = dataRecord["GIF_ACTIVE"].ConvertTo<Byte>();
            record.StartDate = dataRecord["GIF_START_DATE"].ConvertTo<DateTime?>();
            record.EndDate = dataRecord["GIF_END_DATE"].ConvertTo<DateTime?>();
            record.Communication = dataRecord["GIF_COMMUNICATION"].ConvertTo<Byte>();
            record.FirstName = dataRecord["GIF_FIRST_NAME"].ConvertTo<String>();
            record.Surname = dataRecord["GIF_SURNAME"].ConvertTo<String>();
        }

        /// <summary>
        ///     Sets the parameter values for the specified <paramref name="command" /> based on the specified <typeparamref name="TRecord" /> instance.
        /// </summary>
        /// <param name="command">
        ///     The <see cref="IDbCommand" /> containing the parameters to be mapped.
        /// </param>
        /// <param name="record">
        ///     The <see cref="GiftaidRecord" /> instance to be mapped.
        /// </param>
        /// <param name="useV6Logic">
        ///     Is the procedure being run an old version 6.x procedure? (the null value handling logic is different).
        /// </param>
        protected override void MapParametersIn(IDbCommand command, GiftaidRecord record, bool useV6Logic)
        {
            this.MapParameterIn(command, "@PA_GIF_ID", record.Id == Int32.MinValue ? ( useV6Logic ? new Int32?(0) : null ) : record.Id);
            this.MapParameterIn(command, "@PA_GIF_PN_ID", record.PnId);
            this.MapParameterIn(command, "@PA_GIF_TYPE", record.Type);
            this.MapParameterIn(command, "@PA_GIF_ACTIVE", record.Active);
            this.MapParameterIn(command, "@PA_GIF_START_DATE", record.StartDate == DateTime.MinValue ? ( useV6Logic ? new DateTime?(new DateTime(1900,1,1)) : null ) : record.StartDate);
            this.MapParameterIn(command, "@PA_GIF_END_DATE", record.EndDate == DateTime.MinValue ? ( useV6Logic ? new DateTime?(new DateTime(1900,1,1)) : null ) : record.EndDate);
            this.MapParameterIn(command, "@PA_GIF_COMMUNICATION", record.Communication);
            this.MapParameterIn(command, "@PA_GIF_FIRST_NAME", record.FirstName);
            this.MapParameterIn(command, "@PA_GIF_SURNAME", record.Surname);
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
        ///     The <see cref="GiftaidRecord" /> instance to be updated.
        /// </param>
        protected override void MapParametersOut(IDbCommand command, GiftaidRecord record)
        {
            record.Id = this.MapParameterOut(command, "@PA_GIF_ID", record.Id);
            record.PnId = this.MapParameterOut(command, "@PA_GIF_PN_ID", record.PnId);
            record.Type = this.MapParameterOut(command, "@PA_GIF_TYPE", record.Type);
            record.Active = this.MapParameterOut(command, "@PA_GIF_ACTIVE", record.Active);
            record.StartDate = this.MapParameterOut(command, "@PA_GIF_START_DATE", record.StartDate);
            record.EndDate = this.MapParameterOut(command, "@PA_GIF_END_DATE", record.EndDate);
            record.Communication = this.MapParameterOut(command, "@PA_GIF_COMMUNICATION", record.Communication);
            record.FirstName = this.MapParameterOut(command, "@PA_GIF_FIRST_NAME", record.FirstName);
            record.Surname = this.MapParameterOut(command, "@PA_GIF_SURNAME", record.Surname);
            record.Id = this.MapParameterOut(command, "@PA_RETURN_ID", record.Id);
        }

        /// <summary>
        ///     Retrieves a collection of <see cref="GiftaidRecord" /> instances from the data store.
        /// </summary>
        /// <param name="pnId">
        ///     The value which identifies the <see cref='GiftaidModel' /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The collection of <see cref="GiftaidRecord" /> instances that match the specified <paramref name='pnId' />.
        /// </returns>
        public IEnumerable<GiftaidRecord> FetchAllByPnId(String pnId)
        {
            DbCommand command = this.GetStoredProcedure(SqlServerOperation.FetchAll, "PnId");
            this.MapParameterIn(command, "@PA_GIF_PN_ID", pnId);
            return this.Execute(command);
        }

        #endregion

        #region implementations

        /// <summary>
        ///     Gets the underlying table name that this repository sit over.
        /// </summary>
        System.String IGiftaidRepository.TableName
        {
            get { return this.TableName; }
        }

        /// <summary>
        ///     Retrieves a collection of <see cref="T:Consensus.Contact.GiftaidRecord" /> instances from the data store.
        /// </summary>
        /// <param name="pnId">
        ///     The value which identifies the <see cref="!:GiftaidModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The collection of <see cref="T:Consensus.Contact.GiftaidRecord" /> instances that match the specified <paramref name="pnId" />.
        /// </returns>
        System.Collections.Generic.IEnumerable<Consensus.Contact.GiftaidRecord> IGiftaidRepository.FetchAllByPnId(System.String pnId)
        {
            return this.FetchAllByPnId(pnId);
        }

        #endregion
    }
}
