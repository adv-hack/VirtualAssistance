using System;
using System.Collections.Generic;
using System.Linq;

namespace Consensus.Common
{
    /// <summary>
    ///     Encapsulates the <see cref="ProfileRecord" /> data structure.
    /// </summary>
    /// <remarks>
    ///     THIS CODE HAS BEEN AUTOMATICALLY GENERATED USING THE CONSENSUS DEVELOPER TOOLS.
    ///     DO NOT EDIT THIS CODE AS ANY CUSTOM MODIFICATIONS WILL BE LOST UPON REGENERATION.
    /// </remarks>
    public interface IProfileModel : IModel<String>
    {
        /// <summary>
        ///     Gets or sets the value of the "PROF_KEY" field.
        /// </summary>
        System.String Key
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets or sets the value of the "PROF_VALUE" field.
        /// </summary>
        System.String Value
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets or sets the value of the "PROF_NOTES" field.
        /// </summary>
        System.String Notes
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets or sets the value of the "PROF_DATE" field.
        /// </summary>
        System.Nullable<System.DateTime> Date
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets or sets the value of the "PROF_VALUE3" field.
        /// </summary>
        System.String Value3
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets the The value of the "PROF_STATUS" field.
        /// </summary>
        Consensus.Common.ICodeModel Status
        {
            get;
        }

        /// <summary>
        ///     Gets or sets the unique code for the value of the "PROF_STATUS" field.
        /// </summary>
        System.String StatusCode
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets or sets the value of the "PROF_VALUE2" field.
        /// </summary>
        System.String Value2
        {
            get;
            set;
        }
    }
}
