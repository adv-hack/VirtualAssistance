using System;
using System.Collections.Generic;
using System.Linq;
using Consensus.Common;

namespace Consensus.Learning
{
    /// <summary>
    ///     Encapsulates the <see cref="TemplateXrefRecord" /> data structure.
    /// </summary>
    /// <remarks>
    ///     THIS CODE HAS BEEN AUTOMATICALLY GENERATED USING THE CONSENSUS DEVELOPER TOOLS.
    ///     DO NOT EDIT THIS CODE AS ANY CUSTOM MODIFICATIONS WILL BE LOST UPON REGENERATION.
    /// </remarks>
    public interface ITemplateRoomModel : ITemplateModel
    {
        /// <summary>
        ///     Gets the The value of the "TXREF_ROOM_TYPE" field.
        /// </summary>
        Consensus.Common.ICodeModel RoomType
        {
            get;
        }

        /// <summary>
        ///     Gets or sets the unique code for the value of the "TXREF_ROOM_TYPE" field.
        /// </summary>
        System.String RoomTypeCode
        {
            get;
            set;
        }
    }
}
