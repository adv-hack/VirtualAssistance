using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Linq;

namespace Consensus.UserInterface
{
    /// <summary>
    ///     Provides the persistence and retrieval of the <see cref="ScreenCustomFieldRecord" /> instances in a Microsoft SQL Server database.
    /// </summary>
    /// <remarks>
    ///     THIS CODE HAS BEEN AUTOMATICALLY GENERATED USING THE CONSENSUS DEVELOPER TOOLS.
    ///     DO NOT EDIT THIS CODE AS ANY CUSTOM MODIFICATIONS WILL BE LOST UPON REGENERATION.
    /// </remarks>
    public partial class SqlServerScreenCustomFieldRepository : SqlServerRepository<ScreenCustomFieldRecord, Int32>, IScreenCustomFieldRepository
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
            get { return "ScreenCustomField"; }
        }

        /// <summary>
        ///     Gets the name of the parameter which is used to specify the unique value that identifies each instance of a <see cref="ScreenCustomFieldRecord" />.
        /// </summary>
        protected override String TypeKeyName
        {
            get { return "@PA_CFIELD_ID"; }
        }

        /// <summary>
        ///     Gets the underlying table name that this repository sit over.
        /// </summary>
        public override String TableName
        {
            get { return "Screen_Custom_Field"; }
        }

        #endregion

        #region methods

        /// <summary>
        ///     Maps an <see cref="IDataRecord" /> to the specified <see cref="ScreenCustomFieldRecord" />.
        /// </summary>
        /// <param name="dataRecord">
        ///     The <see cref="IDataRecord" /> to be mapped.
        /// </param>
        /// <param name="record">
        ///     The <see cref="ScreenCustomFieldRecord" /> instance to be mapped to.
        /// </param>
        protected override void MapRecord(IDataRecord dataRecord, ScreenCustomFieldRecord record)
        {
            record.Id = dataRecord["CFIELD_ID"].ConvertTo<Int32>();
            record.AddDate = dataRecord["CFIELD_ADD_DATE"].ConvertTo<DateTime>();
            record.AddBy = dataRecord["CFIELD_ADD_BY"].ConvertTo<String>();
            record.ModDate = dataRecord["CFIELD_MOD_DATE"].ConvertTo<DateTime>();
            record.ModBy = dataRecord["CFIELD_MOD_BY"].ConvertTo<String>();
            record.Url = dataRecord["CFIELD_URL"].ConvertTo<String>();
            record.ParentControl = dataRecord["CFIELD_PARENT_CONTROL"].ConvertTo<String>();
            record.Name = dataRecord["CFIELD_NAME"].ConvertTo<String>();
            record.Label = dataRecord["CFIELD_LABEL"].ConvertTo<String>();
            record.CftypeId = dataRecord["CFIELD_CFTYPE_ID"].ConvertTo<String>();
            record.PopupUrl = dataRecord["CFIELD_POPUP_URL"].ConvertTo<String>();
            record.Decimals = dataRecord["CFIELD_DECIMALS"].ConvertTo<Int32?>();
            record.Page = dataRecord["CFIELD_PAGE"].ConvertTo<String>();
            record.Table = dataRecord["CFIELD_TABLE"].ConvertTo<String>();
        }

        /// <summary>
        ///     Sets the parameter values for the specified <paramref name="command" /> based on the specified <typeparamref name="TRecord" /> instance.
        /// </summary>
        /// <param name="command">
        ///     The <see cref="IDbCommand" /> containing the parameters to be mapped.
        /// </param>
        /// <param name="record">
        ///     The <see cref="ScreenCustomFieldRecord" /> instance to be mapped.
        /// </param>
        /// <param name="useV6Logic">
        ///     Is the procedure being run an old version 6.x procedure? (the null value handling logic is different).
        /// </param>
        protected override void MapParametersIn(IDbCommand command, ScreenCustomFieldRecord record, bool useV6Logic)
        {
            this.MapParameterIn(command, "@PA_CFIELD_ID", record.Id == Int32.MinValue ? ( useV6Logic ? new Int32?(0) : null ) : record.Id);
            this.MapParameterIn(command, "@PA_CFIELD_URL", record.Url);
            this.MapParameterIn(command, "@PA_CFIELD_PARENT_CONTROL", record.ParentControl);
            this.MapParameterIn(command, "@PA_CFIELD_NAME", record.Name);
            this.MapParameterIn(command, "@PA_CFIELD_LABEL", record.Label);
            this.MapParameterIn(command, "@PA_CFIELD_CFTYPE_ID", record.CftypeId);
            this.MapParameterIn(command, "@PA_CFIELD_POPUP_URL", record.PopupUrl);
            this.MapParameterIn(command, "@PA_CFIELD_DECIMALS", record.Decimals == Int32.MinValue ? ( useV6Logic ? new Int32?(0) : null ) : record.Decimals);
            this.MapParameterIn(command, "@PA_CFIELD_PAGE", record.Page);
            this.MapParameterIn(command, "@PA_CFIELD_TABLE", record.Table);
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
        ///     The <see cref="ScreenCustomFieldRecord" /> instance to be updated.
        /// </param>
        protected override void MapParametersOut(IDbCommand command, ScreenCustomFieldRecord record)
        {
            record.Id = this.MapParameterOut(command, "@PA_CFIELD_ID", record.Id);
            record.Url = this.MapParameterOut(command, "@PA_CFIELD_URL", record.Url);
            record.ParentControl = this.MapParameterOut(command, "@PA_CFIELD_PARENT_CONTROL", record.ParentControl);
            record.Name = this.MapParameterOut(command, "@PA_CFIELD_NAME", record.Name);
            record.Label = this.MapParameterOut(command, "@PA_CFIELD_LABEL", record.Label);
            record.CftypeId = this.MapParameterOut(command, "@PA_CFIELD_CFTYPE_ID", record.CftypeId);
            record.PopupUrl = this.MapParameterOut(command, "@PA_CFIELD_POPUP_URL", record.PopupUrl);
            record.Decimals = this.MapParameterOut(command, "@PA_CFIELD_DECIMALS", record.Decimals);
            record.Page = this.MapParameterOut(command, "@PA_CFIELD_PAGE", record.Page);
            record.Table = this.MapParameterOut(command, "@PA_CFIELD_TABLE", record.Table);
            record.Id = this.MapParameterOut(command, "@PA_RETURN_ID", record.Id);
        }

        /// <summary>
        ///     Retrieves a collection of <see cref="ScreenCustomFieldRecord" /> instances from the data store.
        /// </summary>
        /// <param name="cftypeId">
        ///     The value which identifies the <see cref='ScreenCustomFieldModel' /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The collection of <see cref="ScreenCustomFieldRecord" /> instances that match the specified <paramref name='cftypeId' />.
        /// </returns>
        public IEnumerable<ScreenCustomFieldRecord> FetchAllByCftypeId(String cftypeId)
        {
            DbCommand command = this.GetStoredProcedure(SqlServerOperation.FetchAll, "CftypeId");
            this.MapParameterIn(command, "@PA_CFIELD_CFTYPE_ID", cftypeId);
            return this.Execute(command);
        }

        #endregion

        #region implementations

        /// <summary>
        ///     Gets the underlying table name that this repository sit over.
        /// </summary>
        System.String IScreenCustomFieldRepository.TableName
        {
            get { return this.TableName; }
        }

        /// <summary>
        ///     Fetch the custom fields for a page.
        /// </summary>
        System.Collections.Generic.IEnumerable<Consensus.UserInterface.ScreenCustomFieldRecord> IScreenCustomFieldRepository.FetchAllByPage(System.String page)
        {
            return this.FetchAllByPage(page);
        }

        /// <summary>
        ///     Retrieves a collection of <see cref="T:Consensus.UserInterface.ScreenCustomFieldRecord" /> instances from the data store.
        /// </summary>
        /// <param name="cftypeId">
        ///     The value which identifies the <see cref="!:ScreenCustomFieldModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The collection of <see cref="T:Consensus.UserInterface.ScreenCustomFieldRecord" /> instances that match the specified <paramref name="cftypeId" />.
        /// </returns>
        System.Collections.Generic.IEnumerable<Consensus.UserInterface.ScreenCustomFieldRecord> IScreenCustomFieldRepository.FetchAllByCftypeId(System.String cftypeId)
        {
            return this.FetchAllByCftypeId(cftypeId);
        }

        #endregion
    }
}
