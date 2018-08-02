using System;
using System.Collections.Generic;
using System.Linq;

namespace Consensus.Search
{
    /// <summary>
    ///     Represents defines the parameters that are displayed and used to perform a search within the application.
    /// </summary>
    /// <remarks>
    ///     THIS CODE HAS BEEN AUTOMATICALLY GENERATED USING THE CONSENSUS DEVELOPER TOOLS.
    ///     DO NOT EDIT THIS CODE AS ANY CUSTOM MODIFICATIONS WILL BE LOST UPON REGENERATION.
    /// </remarks>
    public interface ISearchParameterModel : IModel<Int32>
    {
        /// <summary>
        ///     Gets the type of search parameter.
        /// </summary>
        Consensus.Search.SearchParameterTypes Type
        {
            get;
        }

        /// <summary>
        ///     Gets or sets the value of the "SYSSP_VISIBLE" field.
        /// </summary>
        System.Boolean Visible
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets the The value of the "SYSSP_SYSS_ID" field.
        /// </summary>
        Consensus.Search.ISearchTypeModel SearchType
        {
            get;
        }

        /// <summary>
        ///     Gets or sets the unique code for the value of the "SYSSP_SYSS_ID" field.
        /// </summary>
        System.Int32 SearchTypeId
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets or sets the value of the "SYSSP_DISPLAY_ORDER" field.
        /// </summary>
        System.Int32 Order
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets or sets the value of the "SYSSP_FIELD_NAME" field.
        /// </summary>
        System.String FieldName
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets or sets the value of the "SYSSP_DEFAULT_LABEL" field.
        /// </summary>
        System.String DefaultLabel
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets or sets the value of the "SYSSP_LABEL" field.
        /// </summary>
        System.String CustomLabel
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets or sets the value of the "SYSSP_FIELD_TYPE" field.
        /// </summary>
        System.String FieldType
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets or sets the value of the "SYSSP_WHERE_CLAUSE_OPERATOR" field.
        /// </summary>
        System.String Condition
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets or sets the value of the "SYSSP_DEFAULT_VALUE" field.
        /// </summary>
        System.String DefaultValue
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets or sets the value of the "SYSSP_CODE_LIST" field.
        /// </summary>
        System.String CodeType
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets or sets the value of the "SYSSP_DATA" field.
        /// </summary>
        System.String ListData
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets or sets the value of the "SYSSP_WHERE_CLAUSE_OVERRIDE" field.
        /// </summary>
        System.String ConditionSql
        {
            get;
            set;
        }
    }
}
