using System;
using System.Collections.Generic;
using System.Linq;
using Consensus.Learning;

namespace Consensus.Document
{
    /// <summary>
    ///     Encapsulates the <see cref="ProductPackRecord" /> data structure.
    /// </summary>
    /// <remarks>
    ///     THIS CODE HAS BEEN AUTOMATICALLY GENERATED USING THE CONSENSUS DEVELOPER TOOLS.
    ///     DO NOT EDIT THIS CODE AS ANY CUSTOM MODIFICATIONS WILL BE LOST UPON REGENERATION.
    /// </remarks>
    public interface IPackProductModel : IModel<Int32>
    {
        /// <summary>
        ///     Gets the The value of the "PPA_PROD_ID" field.
        /// </summary>
        Consensus.Learning.IProductModel Product
        {
            get;
        }

        /// <summary>
        ///     Gets or sets the unique code for the value of the "PPA_PROD_ID" field.
        /// </summary>
        System.String ProductId
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets the The value of the "PPA_PACK_ID" field.
        /// </summary>
        Consensus.Document.IPackModel Pack
        {
            get;
        }

        /// <summary>
        ///     Gets or sets the unique code for the value of the "PPA_PACK_ID" field.
        /// </summary>
        System.String PackId
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets or sets the value of the "PPA_TYPE" field.
        /// </summary>
        System.String Type
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets or sets the value of the "PPA_SUPPRESS" field.
        /// </summary>
        System.Byte Suppress
        {
            get;
            set;
        }
    }
}
