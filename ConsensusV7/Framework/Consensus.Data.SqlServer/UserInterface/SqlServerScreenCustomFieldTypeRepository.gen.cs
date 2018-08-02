using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Linq;

namespace Consensus.UserInterface
{
    /// <summary>
    ///     Provides the persistence and retrieval of the <see cref="ScreenCustomFieldTypeRecord" /> instances in a Microsoft SQL Server database.
    /// </summary>
    /// <remarks>
    ///     THIS CODE HAS BEEN AUTOMATICALLY GENERATED USING THE CONSENSUS DEVELOPER TOOLS.
    ///     DO NOT EDIT THIS CODE AS ANY CUSTOM MODIFICATIONS WILL BE LOST UPON REGENERATION.
    /// </remarks>
    public partial class SqlServerScreenCustomFieldTypeRepository : SqlServerRepository<ScreenCustomFieldTypeRecord, String>, IScreenCustomFieldTypeRepository
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
            get { return "ScreenCustomFieldType"; }
        }

        /// <summary>
        ///     Gets the name of the parameter which is used to specify the unique value that identifies each instance of a <see cref="ScreenCustomFieldTypeRecord" />.
        /// </summary>
        protected override String TypeKeyName
        {
            get { return "@PA_CFTYPE_ID"; }
        }

        /// <summary>
        ///     Gets the underlying table name that this repository sit over.
        /// </summary>
        public override String TableName
        {
            get { return "Screen_Custom_Field_Type"; }
        }

        #endregion

        #region methods

        /// <summary>
        ///     Maps an <see cref="IDataRecord" /> to the specified <see cref="ScreenCustomFieldTypeRecord" />.
        /// </summary>
        /// <param name="dataRecord">
        ///     The <see cref="IDataRecord" /> to be mapped.
        /// </param>
        /// <param name="record">
        ///     The <see cref="ScreenCustomFieldTypeRecord" /> instance to be mapped to.
        /// </param>
        protected override void MapRecord(IDataRecord dataRecord, ScreenCustomFieldTypeRecord record)
        {
            record.Id = dataRecord["CFTYPE_ID"].ConvertTo<String>();
            record.AddDate = dataRecord["CFTYPE_ADD_DATE"].ConvertTo<DateTime>();
            record.AddBy = dataRecord["CFTYPE_ADD_BY"].ConvertTo<String>();
            record.ModDate = dataRecord["CFTYPE_MOD_DATE"].ConvertTo<DateTime>();
            record.ModBy = dataRecord["CFTYPE_MOD_BY"].ConvertTo<String>();
            record.Name = dataRecord["CFTYPE_NAME"].ConvertTo<String>();
        }

        /// <summary>
        ///     Sets the parameter values for the specified <paramref name="command" /> based on the specified <typeparamref name="TRecord" /> instance.
        /// </summary>
        /// <param name="command">
        ///     The <see cref="IDbCommand" /> containing the parameters to be mapped.
        /// </param>
        /// <param name="record">
        ///     The <see cref="ScreenCustomFieldTypeRecord" /> instance to be mapped.
        /// </param>
        /// <param name="useV6Logic">
        ///     Is the procedure being run an old version 6.x procedure? (the null value handling logic is different).
        /// </param>
        protected override void MapParametersIn(IDbCommand command, ScreenCustomFieldTypeRecord record, bool useV6Logic)
        {
            this.MapParameterIn(command, "@PA_CFTYPE_ID", record.Id);
            this.MapParameterIn(command, "@PA_CFTYPE_NAME", record.Name);
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
        ///     The <see cref="ScreenCustomFieldTypeRecord" /> instance to be updated.
        /// </param>
        protected override void MapParametersOut(IDbCommand command, ScreenCustomFieldTypeRecord record)
        {
            record.Id = this.MapParameterOut(command, "@PA_CFTYPE_ID", record.Id);
            record.Name = this.MapParameterOut(command, "@PA_CFTYPE_NAME", record.Name);
            record.Id = this.MapParameterOut(command, "@PA_RETURN_ID", record.Id);
        }

        #endregion

        #region implementations

        /// <summary>
        ///     Gets the underlying table name that this repository sit over.
        /// </summary>
        System.String IScreenCustomFieldTypeRepository.TableName
        {
            get { return this.TableName; }
        }

        #endregion
    }
}
