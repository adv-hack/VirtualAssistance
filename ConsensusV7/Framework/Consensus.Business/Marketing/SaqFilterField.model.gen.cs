using System;
using System.Collections.Generic;
using System.Linq;

namespace Consensus.Marketing
{
    /// <summary>
    ///     Encapsulates the <see cref="SaqFilterRecord" /> data structure.
    /// </summary>
    /// <remarks>
    ///     THIS CODE HAS BEEN AUTOMATICALLY GENERATED USING THE CONSENSUS DEVELOPER TOOLS.
    ///     DO NOT EDIT THIS CODE AS ANY CUSTOM MODIFICATIONS WILL BE LOST UPON REGENERATION.
    /// </remarks>
    public interface ISaqFilterFieldModel : IModel<Int64>
    {
        /// <summary>
        ///     Gets or sets the value of the "F_DISPLAY_ORDER" field.
        /// </summary>
        System.Int16 DisplayOrder
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets or sets the value of the "F_DISPLAY" field.
        /// </summary>
        System.Byte Display
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets or sets the value of the "F_TABLE_PREFIX" field.
        /// </summary>
        System.String TablePrefix
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets or sets the value of the "F_TABLE_DESC" field.
        /// </summary>
        System.String TableDesc
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets or sets the value of the "F_COLUMN_NAME" field.
        /// </summary>
        System.String ColumnName
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets or sets the value of the "F_COLUMN_TYPE" field.
        /// </summary>
        System.String ColumnType
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets or sets the value of the "F_COLUMN_LENGTH" field.
        /// </summary>
        System.Nullable<System.Int32> ColumnLength
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets or sets the value of the "F_COLUMN_DESC" field.
        /// </summary>
        System.String ColumnDesc
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets or sets the value of the "F_CODE_LOOKUP" field.
        /// </summary>
        System.Byte CodeLookup
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets or sets the value of the "F_CODE_HEADER" field.
        /// </summary>
        System.String CodeHeader
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets or sets the value of the "F_CODE_VAL" field.
        /// </summary>
        System.Nullable<System.Byte> CodeVal
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets or sets the value of the "F_ID_IN_LOOKUP" field.
        /// </summary>
        System.Byte IdInLookup
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets or sets the value of the "F_DEFAULT_OPERAND" field.
        /// </summary>
        System.String DefaultOperand
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets the collection of <see cref="!:SaqParameterModel" /> instances that reference this <see cref="!:SaqFilterFieldModel" />.
        /// </summary>
        Consensus.Collection<Consensus.Marketing.ISaqParameterModel> SaqParameterFilterField
        {
            get;
        }
    }
}
