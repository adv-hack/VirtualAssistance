using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Linq;

namespace Consensus.UserInterface
{
    /// <summary>
    ///     Provides the persistence and retrieval of the <see cref="SystemmenusRecord" /> instances in a Microsoft SQL Server database.
    /// </summary>
    /// <remarks>
    ///     THIS CODE HAS BEEN AUTOMATICALLY GENERATED USING THE CONSENSUS DEVELOPER TOOLS.
    ///     DO NOT EDIT THIS CODE AS ANY CUSTOM MODIFICATIONS WILL BE LOST UPON REGENERATION.
    /// </remarks>
    public partial class SqlServerSystemMenuRepository : SqlServerRepository<SystemmenusRecord, Int32>, ISystemMenuRepository
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
            get { return "Systemmenus"; }
        }

        /// <summary>
        ///     Gets the name of the parameter which is used to specify the unique value that identifies each instance of a <see cref="SystemmenusRecord" />.
        /// </summary>
        protected override String TypeKeyName
        {
            get { return "@PA_SMENU_ID"; }
        }

        /// <summary>
        ///     Gets the underlying table name that this repository sit over.
        /// </summary>
        public override String TableName
        {
            get { return "SystemMenus"; }
        }

        #endregion

        #region methods

        /// <summary>
        ///     Maps an <see cref="IDataRecord" /> to the specified <see cref="SystemmenusRecord" />.
        /// </summary>
        /// <param name="dataRecord">
        ///     The <see cref="IDataRecord" /> to be mapped.
        /// </param>
        /// <param name="record">
        ///     The <see cref="SystemmenusRecord" /> instance to be mapped to.
        /// </param>
        protected override void MapRecord(IDataRecord dataRecord, SystemmenusRecord record)
        {
            record.Id = dataRecord["SMENU_ID"].ConvertTo<Int32>();
            record.Name = dataRecord["SMENU_NAME"].ConvertTo<String>();
            record.Url = dataRecord["SMENU_URL"].ConvertTo<String>();
            record.Group = dataRecord["SMENU_GROUP"].ConvertTo<String>();
            record.UserId = dataRecord["SMENU_USER_ID"].ConvertTo<String>();
            record.Type = dataRecord["SMENU_TYPE"].ConvertTo<String>();
            record.System = dataRecord["SMENU_SYSTEM"].ConvertTo<Byte>();
            record.Icon = dataRecord["SMENU_ICON"].ConvertTo<String>();
            record.RelativePath = dataRecord["SMENU_RELATIVE_PATH"].ConvertTo<String>();
            record.SmenuId = dataRecord["SMENU_SMENU_ID"].ConvertTo<Int32?>();
            record.NameId = dataRecord["SMENU_NAME_ID"].ConvertTo<String>();
            record.NameRef = dataRecord["SMENU_NAME_REF"].ConvertTo<String>();
        }

        /// <summary>
        ///     Sets the parameter values for the specified <paramref name="command" /> based on the specified <typeparamref name="TRecord" /> instance.
        /// </summary>
        /// <param name="command">
        ///     The <see cref="IDbCommand" /> containing the parameters to be mapped.
        /// </param>
        /// <param name="record">
        ///     The <see cref="SystemmenusRecord" /> instance to be mapped.
        /// </param>
        /// <param name="useV6Logic">
        ///     Is the procedure being run an old version 6.x procedure? (the null value handling logic is different).
        /// </param>
        protected override void MapParametersIn(IDbCommand command, SystemmenusRecord record, bool useV6Logic)
        {
            this.MapParameterIn(command, "@PA_SMENU_ID", record.Id == Int32.MinValue ? ( useV6Logic ? new Int32?(0) : null ) : record.Id);
            this.MapParameterIn(command, "@PA_SMENU_NAME", record.Name);
            this.MapParameterIn(command, "@PA_SMENU_URL", record.Url);
            this.MapParameterIn(command, "@PA_SMENU_GROUP", record.Group);
            this.MapParameterIn(command, "@PA_SMENU_USER_ID", record.UserId);
            this.MapParameterIn(command, "@PA_SMENU_TYPE", record.Type);
            this.MapParameterIn(command, "@PA_SMENU_SYSTEM", record.System);
            this.MapParameterIn(command, "@PA_SMENU_ICON", record.Icon);
            this.MapParameterIn(command, "@PA_SMENU_RELATIVE_PATH", record.RelativePath);
            this.MapParameterIn(command, "@PA_SMENU_SMENU_ID", record.SmenuId == Int32.MinValue ? ( useV6Logic ? new Int32?(0) : null ) : record.SmenuId);
            this.MapParameterIn(command, "@PA_SMENU_NAME_ID", record.NameId);
            this.MapParameterIn(command, "@PA_SMENU_NAME_REF", record.NameRef);
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
        ///     The <see cref="SystemmenusRecord" /> instance to be updated.
        /// </param>
        protected override void MapParametersOut(IDbCommand command, SystemmenusRecord record)
        {
            record.Id = this.MapParameterOut(command, "@PA_SMENU_ID", record.Id);
            record.Name = this.MapParameterOut(command, "@PA_SMENU_NAME", record.Name);
            record.Url = this.MapParameterOut(command, "@PA_SMENU_URL", record.Url);
            record.Group = this.MapParameterOut(command, "@PA_SMENU_GROUP", record.Group);
            record.UserId = this.MapParameterOut(command, "@PA_SMENU_USER_ID", record.UserId);
            record.Type = this.MapParameterOut(command, "@PA_SMENU_TYPE", record.Type);
            record.System = this.MapParameterOut(command, "@PA_SMENU_SYSTEM", record.System);
            record.Icon = this.MapParameterOut(command, "@PA_SMENU_ICON", record.Icon);
            record.RelativePath = this.MapParameterOut(command, "@PA_SMENU_RELATIVE_PATH", record.RelativePath);
            record.SmenuId = this.MapParameterOut(command, "@PA_SMENU_SMENU_ID", record.SmenuId);
            record.NameId = this.MapParameterOut(command, "@PA_SMENU_NAME_ID", record.NameId);
            record.NameRef = this.MapParameterOut(command, "@PA_SMENU_NAME_REF", record.NameRef);
            record.Id = this.MapParameterOut(command, "@PA_RETURN_ID", record.Id);
        }

        /// <summary>
        ///     Retrieves a collection of <see cref="SystemmenusRecord" /> instances from the data store.
        /// </summary>
        /// <param name="smenuId">
        ///     The value which identifies the <see cref='SystemMenuModel' /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The collection of <see cref="SystemmenusRecord" /> instances that match the specified <paramref name='smenuId' />.
        /// </returns>
        public IEnumerable<SystemmenusRecord> FetchAllBySmenuId(Int32? smenuId)
        {
            DbCommand command = this.GetStoredProcedure(SqlServerOperation.FetchAll, "SmenuId");
            this.MapParameterIn(command, "@PA_SMENU_SMENU_ID", smenuId);
            return this.Execute(command);
        }

        #endregion

        #region implementations

        /// <summary>
        ///     Gets the underlying table name that this repository sit over.
        /// </summary>
        System.String ISystemMenuRepository.TableName
        {
            get { return this.TableName; }
        }

        System.Collections.Generic.IEnumerable<Consensus.UserInterface.SystemmenusRecord> ISystemMenuRepository.FetchAllBySmenuId(System.Nullable<System.Int32> smenuId)
        {
            return this.FetchAllBySmenuId(smenuId);
        }

        #endregion
    }
}
