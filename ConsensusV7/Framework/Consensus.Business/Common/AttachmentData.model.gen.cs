using System;
using System.Collections.Generic;
using System.Linq;

namespace Consensus.Common
{
    /// <summary>
    ///     Encapsulates the <see cref="AttachmentDataRecord" /> data structure.
    /// </summary>
    /// <remarks>
    ///     THIS CODE HAS BEEN AUTOMATICALLY GENERATED USING THE CONSENSUS DEVELOPER TOOLS.
    ///     DO NOT EDIT THIS CODE AS ANY CUSTOM MODIFICATIONS WILL BE LOST UPON REGENERATION.
    /// </remarks>
    public interface IAttachmentDataModel : IModel<Int32>
    {
        #region properties

        /// <summary>
        ///     Gets the The value of the "ATTD_ATT_ID" field.
        /// </summary>
        Consensus.Common.IAttachmentModel AttId
        {
            get;
        }

        /// <summary>
        ///     Gets or sets the unique code for the value of the "ATTD_ATT_ID" field.
        /// </summary>
        System.String AttIdId
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets or sets the value of the "ATTD_VERSION_NO" field.
        /// </summary>
        System.Nullable<System.Double> VersionNo
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets or sets the value of the "ATTD_BINARY" field.
        /// </summary>
        System.Byte[] Binary
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets or sets the value of the "ATTD_TEXT" field.
        /// </summary>
        System.String Text
        {
            get;
            set;
        }

        #endregion

        #region methods

        void Save();

        void Delete();

        #endregion
    }
}
