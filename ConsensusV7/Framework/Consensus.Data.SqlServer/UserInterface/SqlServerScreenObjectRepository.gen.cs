using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Linq;

namespace Consensus.UserInterface
{
    /// <summary>
    ///     Provides the persistence and retrieval of the <see cref="ScreenObjectRecord" /> instances in a Microsoft SQL Server database.
    /// </summary>
    /// <remarks>
    ///     THIS CODE HAS BEEN AUTOMATICALLY GENERATED USING THE CONSENSUS DEVELOPER TOOLS.
    ///     DO NOT EDIT THIS CODE AS ANY CUSTOM MODIFICATIONS WILL BE LOST UPON REGENERATION.
    /// </remarks>
    public partial class SqlServerScreenObjectRepository : SqlServerRepository<ScreenObjectRecord, Int32>, IScreenObjectRepository
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
            get { return "ScreenObject"; }
        }

        /// <summary>
        ///     Gets the name of the parameter which is used to specify the unique value that identifies each instance of a <see cref="ScreenObjectRecord" />.
        /// </summary>
        protected override String TypeKeyName
        {
            get { return "@PA_OBJ_ID"; }
        }

        /// <summary>
        ///     Gets the underlying table name that this repository sit over.
        /// </summary>
        public override String TableName
        {
            get { return "Screen_Object"; }
        }

        #endregion

        #region methods

        /// <summary>
        ///     Maps an <see cref="IDataRecord" /> to the specified <see cref="ScreenObjectRecord" />.
        /// </summary>
        /// <param name="dataRecord">
        ///     The <see cref="IDataRecord" /> to be mapped.
        /// </param>
        /// <param name="record">
        ///     The <see cref="ScreenObjectRecord" /> instance to be mapped to.
        /// </param>
        protected override void MapRecord(IDataRecord dataRecord, ScreenObjectRecord record)
        {
            record.Id = dataRecord["OBJ_ID"].ConvertTo<Int32>();
            record.AddDate = dataRecord["OBJ_ADD_DATE"].ConvertTo<DateTime>();
            record.AddBy = dataRecord["OBJ_ADD_BY"].ConvertTo<String>();
            record.ModDate = dataRecord["OBJ_MOD_DATE"].ConvertTo<DateTime>();
            record.ModBy = dataRecord["OBJ_MOD_BY"].ConvertTo<String>();
            record.Url = dataRecord["OBJ_URL"].ConvertTo<String>();
            record.Control = dataRecord["OBJ_CONTROL"].ConvertTo<String>();
            record.Title = dataRecord["OBJ_TITLE"].ConvertTo<String>();
            record.Icon = dataRecord["OBJ_ICON"].ConvertTo<String>();
            record.Display = dataRecord["OBJ_DISPLAY"].ConvertTo<Byte>();
            record.ValidatorExpression = dataRecord["OBJ_VALIDATOR_EXPRESSION"].ConvertTo<String>();
            record.ValidatorMessage = dataRecord["OBJ_VALIDATOR_MESSAGE"].ConvertTo<String>();
            record.ValidatorCritical = dataRecord["OBJ_VALIDATOR_CRITICAL"].ConvertTo<Boolean>();
            record.MaxLength = dataRecord["OBJ_MAX_LENGTH"].ConvertTo<Int32>();
            record.OffText = dataRecord["OBJ_OFF_TEXT"].ConvertTo<String>();
            record.OffColour = dataRecord["OBJ_OFF_COLOUR"].ConvertTo<String>();
            record.OnText = dataRecord["OBJ_ON_TEXT"].ConvertTo<String>();
            record.OnColour = dataRecord["OBJ_ON_COLOUR"].ConvertTo<String>();
            record.Requirement = dataRecord["OBJ_REQUIREMENT"].ConvertTo<Byte>();
            record.Default = dataRecord["OBJ_DEFAULT"].ConvertTo<String>();
        }

        /// <summary>
        ///     Sets the parameter values for the specified <paramref name="command" /> based on the specified <typeparamref name="TRecord" /> instance.
        /// </summary>
        /// <param name="command">
        ///     The <see cref="IDbCommand" /> containing the parameters to be mapped.
        /// </param>
        /// <param name="record">
        ///     The <see cref="ScreenObjectRecord" /> instance to be mapped.
        /// </param>
        /// <param name="useV6Logic">
        ///     Is the procedure being run an old version 6.x procedure? (the null value handling logic is different).
        /// </param>
        protected override void MapParametersIn(IDbCommand command, ScreenObjectRecord record, bool useV6Logic)
        {
            this.MapParameterIn(command, "@PA_OBJ_ID", record.Id == Int32.MinValue ? ( useV6Logic ? new Int32?(0) : null ) : record.Id);
            this.MapParameterIn(command, "@PA_OBJ_URL", record.Url);
            this.MapParameterIn(command, "@PA_OBJ_CONTROL", record.Control);
            this.MapParameterIn(command, "@PA_OBJ_TITLE", record.Title);
            this.MapParameterIn(command, "@PA_OBJ_ICON", record.Icon);
            this.MapParameterIn(command, "@PA_OBJ_DISPLAY", record.Display);
            this.MapParameterIn(command, "@PA_OBJ_VALIDATOR_EXPRESSION", record.ValidatorExpression);
            this.MapParameterIn(command, "@PA_OBJ_VALIDATOR_MESSAGE", record.ValidatorMessage);
            this.MapParameterIn(command, "@PA_OBJ_VALIDATOR_CRITICAL", record.ValidatorCritical);
            this.MapParameterIn(command, "@PA_OBJ_MAX_LENGTH", record.MaxLength == Int32.MinValue ? ( useV6Logic ? new Int32?(0) : null ) : record.MaxLength);
            this.MapParameterIn(command, "@PA_OBJ_OFF_TEXT", record.OffText);
            this.MapParameterIn(command, "@PA_OBJ_OFF_COLOUR", record.OffColour);
            this.MapParameterIn(command, "@PA_OBJ_ON_TEXT", record.OnText);
            this.MapParameterIn(command, "@PA_OBJ_ON_COLOUR", record.OnColour);
            this.MapParameterIn(command, "@PA_OBJ_REQUIREMENT", record.Requirement);
            this.MapParameterIn(command, "@PA_OBJ_DEFAULT", record.Default);
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
        ///     The <see cref="ScreenObjectRecord" /> instance to be updated.
        /// </param>
        protected override void MapParametersOut(IDbCommand command, ScreenObjectRecord record)
        {
            record.Id = this.MapParameterOut(command, "@PA_OBJ_ID", record.Id);
            record.Url = this.MapParameterOut(command, "@PA_OBJ_URL", record.Url);
            record.Control = this.MapParameterOut(command, "@PA_OBJ_CONTROL", record.Control);
            record.Title = this.MapParameterOut(command, "@PA_OBJ_TITLE", record.Title);
            record.Icon = this.MapParameterOut(command, "@PA_OBJ_ICON", record.Icon);
            record.Display = this.MapParameterOut(command, "@PA_OBJ_DISPLAY", record.Display);
            record.ValidatorExpression = this.MapParameterOut(command, "@PA_OBJ_VALIDATOR_EXPRESSION", record.ValidatorExpression);
            record.ValidatorMessage = this.MapParameterOut(command, "@PA_OBJ_VALIDATOR_MESSAGE", record.ValidatorMessage);
            record.ValidatorCritical = this.MapParameterOut(command, "@PA_OBJ_VALIDATOR_CRITICAL", record.ValidatorCritical);
            record.MaxLength = this.MapParameterOut(command, "@PA_OBJ_MAX_LENGTH", record.MaxLength);
            record.OffText = this.MapParameterOut(command, "@PA_OBJ_OFF_TEXT", record.OffText);
            record.OffColour = this.MapParameterOut(command, "@PA_OBJ_OFF_COLOUR", record.OffColour);
            record.OnText = this.MapParameterOut(command, "@PA_OBJ_ON_TEXT", record.OnText);
            record.OnColour = this.MapParameterOut(command, "@PA_OBJ_ON_COLOUR", record.OnColour);
            record.Requirement = this.MapParameterOut(command, "@PA_OBJ_REQUIREMENT", record.Requirement);
            record.Default = this.MapParameterOut(command, "@PA_OBJ_DEFAULT", record.Default);
            record.Id = this.MapParameterOut(command, "@PA_RETURN_ID", record.Id);
        }

        #endregion

        #region implementations

        /// <summary>
        ///     Gets the underlying table name that this repository sit over.
        /// </summary>
        System.String IScreenObjectRepository.TableName
        {
            get { return this.TableName; }
        }

        #endregion
    }
}
