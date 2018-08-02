using System;
using System.Collections.Generic;
using System.Linq;

namespace Consensus.Common
{
    /// <summary>
    ///     Encapsulates the <see cref="AttachlearningzonecategoriesRecord" /> data structure.
    /// </summary>
    /// <remarks>
    ///     THIS CODE HAS BEEN AUTOMATICALLY GENERATED USING THE CONSENSUS DEVELOPER TOOLS.
    ///     DO NOT EDIT THIS CODE AS ANY CUSTOM MODIFICATIONS WILL BE LOST UPON REGENERATION.
    /// </remarks>
    public interface IAttachLearningZoneCategoriesModel : IModel<Int32>
    {
        /// <summary>
        ///     Gets the The value of the "ATTLZC_ATT_ID" field.
        /// </summary>
        Consensus.Common.IAttachmentModel AttId
        {
            get;
        }

        /// <summary>
        ///     Gets or sets the unique code for the value of the "ATTLZC_ATT_ID" field.
        /// </summary>
        System.String AttIdId
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets the The value of the "ATTLZC_LZC_ID" field.
        /// </summary>
        Consensus.Common.ILearningZoneCategoriesModel LzcId
        {
            get;
        }

        /// <summary>
        ///     Gets or sets the unique code for the value of the "ATTLZC_LZC_ID" field.
        /// </summary>
        System.Int32 LzcIdId
        {
            get;
            set;
        }
    }
}
