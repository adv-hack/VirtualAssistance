using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Linq;

namespace Consensus.Marketing
{
    /// <summary>
    ///     Provides the persistence and retrieval of the <see cref="SaqFilterRecord" /> instances in a Microsoft SQL Server database.
    /// </summary>
    /// <remarks>
    ///     THIS CODE HAS BEEN AUTOMATICALLY GENERATED USING THE CONSENSUS DEVELOPER TOOLS.
    ///     DO NOT EDIT THIS CODE AS ANY CUSTOM MODIFICATIONS WILL BE LOST UPON REGENERATION.
    /// </remarks>
    public partial class SqlServerSaqFilterFieldRepository : SqlServerRepository<SaqFilterRecord, Int64>, ISaqFilterFieldRepository
    {
        #region properties

        /// <summary>
        ///     Gets the namespace in which the data type is contained.
        /// </summary>
        protected override String TypeNamespace
        {
            get { return "Marketing"; }
        }

        /// <summary>
        ///     Gets the name of the data type which is persisted by this repository.
        /// </summary>
        protected override String TypeName
        {
            get { return "SaqFilter"; }
        }

        /// <summary>
        ///     Gets the name of the parameter which is used to specify the unique value that identifies each instance of a <see cref="SaqFilterRecord" />.
        /// </summary>
        protected override String TypeKeyName
        {
            get { return "@PA_F_ID"; }
        }

        /// <summary>
        ///     Gets the underlying table name that this repository sit over.
        /// </summary>
        public override String TableName
        {
            get { return "SAQ_FILTER"; }
        }

        #endregion

        #region methods

        /// <summary>
        ///     Maps an <see cref="IDataRecord" /> to the specified <see cref="SaqFilterRecord" />.
        /// </summary>
        /// <param name="dataRecord">
        ///     The <see cref="IDataRecord" /> to be mapped.
        /// </param>
        /// <param name="record">
        ///     The <see cref="SaqFilterRecord" /> instance to be mapped to.
        /// </param>
        protected override void MapRecord(IDataRecord dataRecord, SaqFilterRecord record)
        {
            record.Id = dataRecord["F_ID"].ConvertTo<Int64>();
            record.AddBy = dataRecord["F_ADD_BY"].ConvertTo<String>();
            record.AddDate = dataRecord["F_ADD_DATE"].ConvertTo<DateTime>();
            record.ModBy = dataRecord["F_MOD_BY"].ConvertTo<String>();
            record.ModDate = dataRecord["F_MOD_DATE"].ConvertTo<DateTime>();
            record.DisplayOrder = dataRecord["F_DISPLAY_ORDER"].ConvertTo<Int16>();
            record.Display = dataRecord["F_DISPLAY"].ConvertTo<Byte>();
            record.TablePrefix = dataRecord["F_TABLE_PREFIX"].ConvertTo<String>();
            record.TableDesc = dataRecord["F_TABLE_DESC"].ConvertTo<String>();
            record.ColumnName = dataRecord["F_COLUMN_NAME"].ConvertTo<String>();
            record.ColumnType = dataRecord["F_COLUMN_TYPE"].ConvertTo<String>();
            record.ColumnLength = dataRecord["F_COLUMN_LENGTH"].ConvertTo<Int32?>();
            record.ColumnDesc = dataRecord["F_COLUMN_DESC"].ConvertTo<String>();
            record.CodeLookup = dataRecord["F_CODE_LOOKUP"].ConvertTo<Byte>();
            record.CodeHeader = dataRecord["F_CODE_HEADER"].ConvertTo<String>();
            record.CodeVal = dataRecord["F_CODE_VAL"].ConvertTo<Byte?>();
            record.IdInLookup = dataRecord["F_ID_IN_LOOKUP"].ConvertTo<Byte>();
            record.DefaultOperand = dataRecord["F_DEFAULT_OPERAND"].ConvertTo<String>();
        }

        /// <summary>
        ///     Sets the parameter values for the specified <paramref name="command" /> based on the specified <typeparamref name="TRecord" /> instance.
        /// </summary>
        /// <param name="command">
        ///     The <see cref="IDbCommand" /> containing the parameters to be mapped.
        /// </param>
        /// <param name="record">
        ///     The <see cref="SaqFilterRecord" /> instance to be mapped.
        /// </param>
        /// <param name="useV6Logic">
        ///     Is the procedure being run an old version 6.x procedure? (the null value handling logic is different).
        /// </param>
        protected override void MapParametersIn(IDbCommand command, SaqFilterRecord record, bool useV6Logic)
        {
            this.MapParameterIn(command, "@PA_F_ID", record.Id == Int64.MinValue ? ( useV6Logic ? new Int64?(0) : null ) : record.Id);
            this.MapParameterIn(command, "@PA_F_DISPLAY_ORDER", record.DisplayOrder == Int16.MinValue ? 0 : record.DisplayOrder);
            this.MapParameterIn(command, "@PA_F_DISPLAY", record.Display);
            this.MapParameterIn(command, "@PA_F_TABLE_PREFIX", record.TablePrefix);
            this.MapParameterIn(command, "@PA_F_TABLE_DESC", record.TableDesc);
            this.MapParameterIn(command, "@PA_F_COLUMN_NAME", record.ColumnName);
            this.MapParameterIn(command, "@PA_F_COLUMN_TYPE", record.ColumnType);
            this.MapParameterIn(command, "@PA_F_COLUMN_LENGTH", record.ColumnLength == Int32.MinValue ? ( useV6Logic ? new Int32?(0) : null ) : record.ColumnLength);
            this.MapParameterIn(command, "@PA_F_COLUMN_DESC", record.ColumnDesc);
            this.MapParameterIn(command, "@PA_F_CODE_LOOKUP", record.CodeLookup);
            this.MapParameterIn(command, "@PA_F_CODE_HEADER", record.CodeHeader);
            this.MapParameterIn(command, "@PA_F_CODE_VAL", record.CodeVal);
            this.MapParameterIn(command, "@PA_F_ID_IN_LOOKUP", record.IdInLookup);
            this.MapParameterIn(command, "@PA_F_DEFAULT_OPERAND", record.DefaultOperand);
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
        ///     The <see cref="SaqFilterRecord" /> instance to be updated.
        /// </param>
        protected override void MapParametersOut(IDbCommand command, SaqFilterRecord record)
        {
            record.Id = this.MapParameterOut(command, "@PA_F_ID", record.Id);
            record.DisplayOrder = this.MapParameterOut(command, "@PA_F_DISPLAY_ORDER", record.DisplayOrder);
            record.Display = this.MapParameterOut(command, "@PA_F_DISPLAY", record.Display);
            record.TablePrefix = this.MapParameterOut(command, "@PA_F_TABLE_PREFIX", record.TablePrefix);
            record.TableDesc = this.MapParameterOut(command, "@PA_F_TABLE_DESC", record.TableDesc);
            record.ColumnName = this.MapParameterOut(command, "@PA_F_COLUMN_NAME", record.ColumnName);
            record.ColumnType = this.MapParameterOut(command, "@PA_F_COLUMN_TYPE", record.ColumnType);
            record.ColumnLength = this.MapParameterOut(command, "@PA_F_COLUMN_LENGTH", record.ColumnLength);
            record.ColumnDesc = this.MapParameterOut(command, "@PA_F_COLUMN_DESC", record.ColumnDesc);
            record.CodeLookup = this.MapParameterOut(command, "@PA_F_CODE_LOOKUP", record.CodeLookup);
            record.CodeHeader = this.MapParameterOut(command, "@PA_F_CODE_HEADER", record.CodeHeader);
            record.CodeVal = this.MapParameterOut(command, "@PA_F_CODE_VAL", record.CodeVal);
            record.IdInLookup = this.MapParameterOut(command, "@PA_F_ID_IN_LOOKUP", record.IdInLookup);
            record.DefaultOperand = this.MapParameterOut(command, "@PA_F_DEFAULT_OPERAND", record.DefaultOperand);
            record.Id = this.MapParameterOut(command, "@PA_RETURN_ID", record.Id);
        }

        #endregion

        #region implementations

        /// <summary>
        ///     Gets the underlying table name that this repository sit over.
        /// </summary>
        System.String ISaqFilterFieldRepository.TableName
        {
            get { return this.TableName; }
        }

        #endregion
    }
}
