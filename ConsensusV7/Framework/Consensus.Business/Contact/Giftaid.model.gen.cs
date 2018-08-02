using System;
using System.Collections.Generic;
using System.Linq;
using Consensus.Common;

namespace Consensus.Contact
{
    /// <summary>
    ///     Encapsulates the <see cref="GiftaidRecord" /> data structure.
    /// </summary>
    /// <remarks>
    ///     THIS CODE HAS BEEN AUTOMATICALLY GENERATED USING THE CONSENSUS DEVELOPER TOOLS.
    ///     DO NOT EDIT THIS CODE AS ANY CUSTOM MODIFICATIONS WILL BE LOST UPON REGENERATION.
    /// </remarks>
    public interface IGiftaidModel : IModel<Int32>
    {
        /// <summary>
        ///     Gets or sets the value of the "GIF_ACTIVE" field.
        /// </summary>
        System.Boolean Active
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets the The value of the "GIF_PN_ID" field.
        /// </summary>
        Consensus.Contact.IPersonModel PnId
        {
            get;
        }

        /// <summary>
        ///     Gets or sets the unique code for the value of the "GIF_PN_ID" field.
        /// </summary>
        System.String PnIdId
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets the The value of the "GIF_TYPE" field.
        /// </summary>
        Consensus.Common.ICodeModel Type
        {
            get;
        }

        /// <summary>
        ///     Gets or sets the unique code for the value of the "GIF_TYPE" field.
        /// </summary>
        System.String TypeCode
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets or sets the value of the "GIF_START_DATE" field.
        /// </summary>
        System.Nullable<System.DateTime> StartDate
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets or sets the value of the "GIF_END_DATE" field.
        /// </summary>
        System.Nullable<System.DateTime> EndDate
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets or sets the value of the "GIF_COMMUNICATION" field.
        /// </summary>
        System.Byte Communication
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets or sets the value of the "GIF_FIRST_NAME" field.
        /// </summary>
        System.String FirstName
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets or sets the value of the "GIF_SURNAME" field.
        /// </summary>
        System.String Surname
        {
            get;
            set;
        }
    }
}
