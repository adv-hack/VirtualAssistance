using System;
using System.Collections.Generic;
using System.Linq;

namespace Consensus.Other
{
    /// <summary>
    ///     Encapsulates the <see cref="WorkflowRecTypeRecord" /> data structure.
    /// </summary>
    /// <remarks>
    ///     THIS CODE HAS BEEN AUTOMATICALLY GENERATED USING THE CONSENSUS DEVELOPER TOOLS.
    ///     DO NOT EDIT THIS CODE AS ANY CUSTOM MODIFICATIONS WILL BE LOST UPON REGENERATION.
    /// </remarks>
    public interface IWorkflowRecTypeModel : IModel<String>
    {
        /// <summary>
        ///     Gets or sets the value of the "WRT_REC_TYPE" field.
        /// </summary>
        System.String RecType
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets or sets the value of the "WRT_DESC" field.
        /// </summary>
        System.String Desc
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets or sets the value of the "WRT_TABLE" field.
        /// </summary>
        System.String Table
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets or sets the value of the "WRT_TABLE_KEY" field.
        /// </summary>
        System.String TableKey
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets or sets the value of the "WRT_SQL" field.
        /// </summary>
        System.String Sql
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets or sets the value of the "WRT_PR_TYPE" field.
        /// </summary>
        System.String PrType
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets or sets the value of the "WRT_SEARCH_ENTITY" field.
        /// </summary>
        System.String SearchEntity
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets or sets the value of the "WRT_LINK_TO" field.
        /// </summary>
        System.String LinkTo
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets or sets the value of the "WRT_PR_TYPE_TYPE" field.
        /// </summary>
        System.String PrTypeType
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets or sets the value of the "WRT_QUERY" field.
        /// </summary>
        System.Nullable<System.Byte> Query
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets or sets the value of the "WRT_QUERY_SELECT" field.
        /// </summary>
        System.String QuerySelect
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets or sets the value of the "WRT_QUERY_MERGE" field.
        /// </summary>
        System.String QueryMerge
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets or sets the value of the "WRT_ACT_TYPES" field.
        /// </summary>
        System.String ActTypes
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets or sets the value of the "WRT_PR_ARG" field.
        /// </summary>
        System.Byte PrArg
        {
            get;
            set;
        }
    }
}
