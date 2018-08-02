using System;
using System.Collections.Generic;
using System.Linq;

namespace Consensus.Common
{
    /// <summary>
    ///     Encapsulates the <see cref="ViewLogRecord" /> data structure.
    /// </summary>
    /// <remarks>
    ///     THIS CODE HAS BEEN AUTOMATICALLY GENERATED USING THE CONSENSUS DEVELOPER TOOLS.
    ///     DO NOT EDIT THIS CODE AS ANY CUSTOM MODIFICATIONS WILL BE LOST UPON REGENERATION.
    /// </remarks>
    public interface IViewLogModel : IModel<Int32>
    {
        /// <summary>
        ///     Gets or sets the value of the "VIEW_TABLE" field.
        /// </summary>
        System.String Table
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets or sets the value of the "VIEW_REC_ID" field.
        /// </summary>
        System.String RecId
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets or sets the value of the "VIEW_SOURCE" field.
        /// </summary>
        System.Byte Source
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets or sets the value of the "VIEW_REC_ID2" field.
        /// </summary>
        System.String RecId2
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets or sets the value of the "VIEW_TABLE2" field.
        /// </summary>
        System.String Table2
        {
            get;
            set;
        }
    }
}
