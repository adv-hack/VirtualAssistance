using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Linq;

namespace Consensus.Common
{
    /// <summary>
    ///     Provides the persistence and retrieval of the <see cref="CodeRecord" /> instances in a Microsoft SQL Server database.
    /// </summary>
    /// <remarks>
    ///     THIS CODE HAS BEEN AUTOMATICALLY GENERATED USING THE CONSENSUS DEVELOPER TOOLS.
    ///     DO NOT EDIT THIS CODE AS ANY CUSTOM MODIFICATIONS WILL BE LOST UPON REGENERATION.
    /// </remarks>
    public partial class SqlServerCodeRepository : SqlServerRepository<CodeRecord, String>, ICodeRepository
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
            get { return "Code"; }
        }

        /// <summary>
        ///     Gets the name of the parameter which is used to specify the unique value that identifies each instance of a <see cref="CodeRecord" />.
        /// </summary>
        protected override String TypeKeyName
        {
            get { return "@PA_CODE_ID"; }
        }

        /// <summary>
        ///     Gets the underlying table name that this repository sit over.
        /// </summary>
        public override String TableName
        {
            get { return "Code"; }
        }

        #endregion

        #region methods

        /// <summary>
        ///     Maps an <see cref="IDataRecord" /> to the specified <see cref="CodeRecord" />.
        /// </summary>
        /// <param name="dataRecord">
        ///     The <see cref="IDataRecord" /> to be mapped.
        /// </param>
        /// <param name="record">
        ///     The <see cref="CodeRecord" /> instance to be mapped to.
        /// </param>
        protected override void MapRecord(IDataRecord dataRecord, CodeRecord record)
        {
            record.Id = dataRecord["CODE_ID"].ConvertTo<String>();
            record.Lock = dataRecord["CODE_LOCK"].ConvertTo<String>();
            record.AddDate = dataRecord["CODE_ADD_DATE"].ConvertTo<DateTime?>();
            record.AddBy = dataRecord["CODE_ADD_BY"].ConvertTo<String>();
            record.ModDate = dataRecord["CODE_MOD_DATE"].ConvertTo<DateTime?>();
            record.ModBy = dataRecord["CODE_MOD_BY"].ConvertTo<String>();
            record.RcvDate = dataRecord["CODE_RCV_DATE"].ConvertTo<DateTime?>();
            record.RcvFrom = dataRecord["CODE_RCV_FROM"].ConvertTo<String>();
            record.Type = dataRecord["CODE_TYPE"].ConvertTo<String>();
            record.Value1 = dataRecord["CODE_VALUE1"].ConvertTo<String>();
            record.Value2 = dataRecord["CODE_VALUE2"].ConvertTo<String>();
            record.Value3 = dataRecord["CODE_VALUE3"].ConvertTo<String>();
            record.Description = dataRecord["CODE_DESCRIPTION"].ConvertTo<String>();
            record.Notes = dataRecord["CODE_NOTES"].ConvertTo<String>();
            record.Value4 = dataRecord["CODE_VALUE4"].ConvertTo<String>();
            record.System = dataRecord["CODE_SYSTEM"].ConvertTo<Byte?>();
            record.Deleted = dataRecord["CODE_DELETED"].ConvertTo<Byte?>();
            record.Instruct = dataRecord["CODE_INSTRUCT"].ConvertTo<String>();
            record.ReadOnly = dataRecord["CODE_READ_ONLY"].ConvertTo<Byte?>();
            record.OrigValue = dataRecord["CODE_ORIG_VALUE"].ConvertTo<String>();
            record.Value5 = dataRecord["CODE_VALUE5"].ConvertTo<String>();
            record.Order = dataRecord["CODE_ORDER"].ConvertTo<Int32>();
        }

        /// <summary>
        ///     Sets the parameter values for the specified <paramref name="command" /> based on the specified <typeparamref name="TRecord" /> instance.
        /// </summary>
        /// <param name="command">
        ///     The <see cref="IDbCommand" /> containing the parameters to be mapped.
        /// </param>
        /// <param name="record">
        ///     The <see cref="CodeRecord" /> instance to be mapped.
        /// </param>
        /// <param name="useV6Logic">
        ///     Is the procedure being run an old version 6.x procedure? (the null value handling logic is different).
        /// </param>
        protected override void MapParametersIn(IDbCommand command, CodeRecord record, bool useV6Logic)
        {
            this.MapParameterIn(command, "@PA_CODE_ID", record.Id);
            this.MapParameterIn(command, "@PA_CODE_LOCK", record.Lock);
            this.MapParameterIn(command, "@PA_CODE_TYPE", record.Type);
            this.MapParameterIn(command, "@PA_CODE_VALUE1", record.Value1);
            this.MapParameterIn(command, "@PA_CODE_VALUE2", record.Value2);
            this.MapParameterIn(command, "@PA_CODE_VALUE3", record.Value3);
            this.MapParameterIn(command, "@PA_CODE_DESCRIPTION", record.Description);
            this.MapParameterIn(command, "@PA_CODE_NOTES", record.Notes);
            this.MapParameterIn(command, "@PA_CODE_VALUE4", record.Value4);
            this.MapParameterIn(command, "@PA_CODE_SYSTEM", record.System);
            this.MapParameterIn(command, "@PA_CODE_DELETED", record.Deleted);
            this.MapParameterIn(command, "@PA_CODE_INSTRUCT", record.Instruct);
            this.MapParameterIn(command, "@PA_CODE_READ_ONLY", record.ReadOnly);
            this.MapParameterIn(command, "@PA_CODE_ORIG_VALUE", record.OrigValue);
            this.MapParameterIn(command, "@PA_CODE_VALUE5", record.Value5);
            this.MapParameterIn(command, "@PA_CODE_ORDER", record.Order == Int32.MinValue ? 0 : record.Order);
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
        ///     The <see cref="CodeRecord" /> instance to be updated.
        /// </param>
        protected override void MapParametersOut(IDbCommand command, CodeRecord record)
        {
            record.Id = this.MapParameterOut(command, "@PA_CODE_ID", record.Id);
            record.Lock = this.MapParameterOut(command, "@PA_CODE_LOCK", record.Lock);
            record.Type = this.MapParameterOut(command, "@PA_CODE_TYPE", record.Type);
            record.Value1 = this.MapParameterOut(command, "@PA_CODE_VALUE1", record.Value1);
            record.Value2 = this.MapParameterOut(command, "@PA_CODE_VALUE2", record.Value2);
            record.Value3 = this.MapParameterOut(command, "@PA_CODE_VALUE3", record.Value3);
            record.Description = this.MapParameterOut(command, "@PA_CODE_DESCRIPTION", record.Description);
            record.Notes = this.MapParameterOut(command, "@PA_CODE_NOTES", record.Notes);
            record.Value4 = this.MapParameterOut(command, "@PA_CODE_VALUE4", record.Value4);
            record.System = this.MapParameterOut(command, "@PA_CODE_SYSTEM", record.System);
            record.Deleted = this.MapParameterOut(command, "@PA_CODE_DELETED", record.Deleted);
            record.Instruct = this.MapParameterOut(command, "@PA_CODE_INSTRUCT", record.Instruct);
            record.ReadOnly = this.MapParameterOut(command, "@PA_CODE_READ_ONLY", record.ReadOnly);
            record.OrigValue = this.MapParameterOut(command, "@PA_CODE_ORIG_VALUE", record.OrigValue);
            record.Value5 = this.MapParameterOut(command, "@PA_CODE_VALUE5", record.Value5);
            record.Order = this.MapParameterOut(command, "@PA_CODE_ORDER", record.Order);
            record.Id = this.MapParameterOut(command, "@PA_RETURN_ID", record.Id);
        }

        #endregion

        #region implementations

        /// <summary>
        ///     Gets the underlying table name that this repository sit over.
        /// </summary>
        System.String ICodeRepository.TableName
        {
            get { return this.TableName; }
        }

        /// <summary>
        ///     Retrieves a single <typeparamref name="TRecord" /> instance from the data store.
        /// </summary>
        /// <returns>
        ///     The <typeparamref name="TRecord" /> instance that matches the specified <paramref name="id" />; or null, if no matching instance can be found.
        /// </returns>
        Consensus.Common.CodeRecord ICodeRepository.FetchByTypeAndCode(System.String type, System.String code)
        {
            return this.FetchByTypeAndCode(type, code);
        }

        /// <summary>
        ///     Retrieves a single <see cref="T:Consensus.Common.CodeRecord" /> instance from the data store.
        /// </summary>
        /// <param name="type">
        ///     The type code which distinctly identifies the type of <see cref="T:Consensus.Common.CodeRecord" /> instance to be returned.
        /// </param>
        /// <param name="codeValue3">
        ///     The unique value which distinctly identifies the <see cref="T:Consensus.Common.CodeRecord" /> instance to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="T:Consensus.Common.CodeRecord" /> instance that matches the specified <paramref name="codeValue3" />; or null, if no matching instance can be found.
        /// </returns>
        Consensus.Common.CodeRecord ICodeRepository.FetchByTypeAndCodeValue3(System.String type, System.String codeValue3)
        {
            return this.FetchByTypeAndCodeValue3(type, codeValue3);
        }

        /// <summary>
        ///     Retrieves a single <typeparamref name="TRecord" /> instance from the data store.
        /// </summary>
        /// <returns>
        ///     The <typeparamref name="TRecord" /> instance that matches the specified <paramref name="id" />; or null, if no matching instance can be found.
        /// </returns>
        System.Collections.Generic.IEnumerable<Consensus.Common.CodeRecord> ICodeRepository.FetchAllByType(System.String type)
        {
            return this.FetchAllByType(type);
        }

        void ICodeRepository.RemoveById(Consensus.Common.CodeRecord record)
        {
            this.RemoveById(record);
        }

        #endregion
    }
}
