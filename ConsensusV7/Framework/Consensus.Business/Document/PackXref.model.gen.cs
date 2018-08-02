using System;
using System.Collections.Generic;
using System.Linq;

namespace Consensus.Document
{
    /// <summary>
    ///     Encapsulates the <see cref="PackXrefRecord" /> data structure.
    /// </summary>
    /// <remarks>
    ///     THIS CODE HAS BEEN AUTOMATICALLY GENERATED USING THE CONSENSUS DEVELOPER TOOLS.
    ///     DO NOT EDIT THIS CODE AS ANY CUSTOM MODIFICATIONS WILL BE LOST UPON REGENERATION.
    /// </remarks>
    public interface IPackXrefModel : IModel<String>
    {
        /// <summary>
        ///     Gets the The value of the "PACKXREF_PACK_ID" field.
        /// </summary>
        Consensus.Document.IPackModel PackId
        {
            get;
        }

        /// <summary>
        ///     Gets or sets the unique code for the value of the "PACKXREF_PACK_ID" field.
        /// </summary>
        System.String PackIdId
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets the The value of the "PACKXREF_LIT_ID" field.
        /// </summary>
        Consensus.Document.ILiteratureModel LitId
        {
            get;
        }

        /// <summary>
        ///     Gets or sets the unique code for the value of the "PACKXREF_LIT_ID" field.
        /// </summary>
        System.String LitIdId
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets or sets the value of the "PACKXREF_SEQ" field.
        /// </summary>
        System.Nullable<System.Int32> Seq
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets the The value of the "PACKXREF_SMS_ID" field.
        /// </summary>
        Consensus.Document.ISmsMessageModel SmsId
        {
            get;
        }

        /// <summary>
        ///     Gets or sets the unique code for the value of the "PACKXREF_SMS_ID" field.
        /// </summary>
        System.Nullable<System.Int32> SmsIdId
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets the The value of the "PACKXREF_ICM_ID" field.
        /// </summary>
        Consensus.Document.IICalMessageModel IcmId
        {
            get;
        }

        /// <summary>
        ///     Gets or sets the unique code for the value of the "PACKXREF_ICM_ID" field.
        /// </summary>
        System.Nullable<System.Int32> IcmIdId
        {
            get;
            set;
        }
    }
}
