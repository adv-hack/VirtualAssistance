using System;
using System.Collections.Generic;
using System.Linq;

namespace Consensus.Common
{
    /// <summary>
    ///     Encapsulates the <see cref="CodeRecord" /> data structure.
    /// </summary>
    /// <remarks>
    ///     THIS CODE HAS BEEN AUTOMATICALLY GENERATED USING THE CONSENSUS DEVELOPER TOOLS.
    ///     DO NOT EDIT THIS CODE AS ANY CUSTOM MODIFICATIONS WILL BE LOST UPON REGENERATION.
    /// </remarks>
    public interface ICodeModel : IModel<String>
    {
        /// <summary>
        ///     Gets or sets the value of the "CODE_TYPE" field.
        /// </summary>
        System.String Type
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets or sets the value of the "CODE_VALUE1" field.
        /// </summary>
        System.String Value1
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets or sets the value of the "CODE_VALUE2" field.
        /// </summary>
        System.String Value2
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets or sets the value of the "CODE_VALUE3" field.
        /// </summary>
        System.String Value3
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets or sets the value of the "CODE_DESCRIPTION" field.
        /// </summary>
        System.String Description
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets or sets the value of the "CODE_VALUE4" field.
        /// </summary>
        System.String Value4
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets or sets the value of the "CODE_SYSTEM" field.
        /// </summary>
        System.Nullable<System.Byte> System
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets or sets the value of the "CODE_DELETED" field.
        /// </summary>
        System.Nullable<System.Byte> Deleted
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets or sets the value of the "CODE_READ_ONLY" field.
        /// </summary>
        System.Nullable<System.Byte> ReadOnly
        {
            get;
            set;
        }
    }
}
