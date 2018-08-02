using System;
using System.Collections.Generic;
using System.Linq;
using Consensus.Sales;

namespace Consensus.Learning
{
    /// <summary>
    ///     Encapsulates the <see cref="ProductProdXrefRecord" /> data structure.
    /// </summary>
    /// <remarks>
    ///     THIS CODE HAS BEEN AUTOMATICALLY GENERATED USING THE CONSENSUS DEVELOPER TOOLS.
    ///     DO NOT EDIT THIS CODE AS ANY CUSTOM MODIFICATIONS WILL BE LOST UPON REGENERATION.
    /// </remarks>
    public interface IRelatedProductModel : IModel<Int32>
    {
        /// <summary>
        ///     Gets or sets the value of the "PPX_MAST_PROD_ID" field.
        /// </summary>
        System.String MastProdId
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets the The value of the "PPX_SIM_PROD_ID" field.
        /// </summary>
        Consensus.Learning.IProductModel RelatedProdId
        {
            get;
        }

        /// <summary>
        ///     Gets or sets the unique code for the value of the "PPX_SIM_PROD_ID" field.
        /// </summary>
        System.String RelatedProdIdId
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets or sets the value of the "PPX_NOTES" field.
        /// </summary>
        System.String Notes
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets or sets the value of the "PPX_PREREQ" field.
        /// </summary>
        System.Byte Prereq
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets the The value of the "PPX_SCHN_ID" field.
        /// </summary>
        Consensus.Sales.ISalesChannelModel SalesChannel
        {
            get;
        }

        /// <summary>
        ///     Gets or sets the unique code for the value of the "PPX_SCHN_ID" field.
        /// </summary>
        System.String SalesChannelId
        {
            get;
            set;
        }
    }
}
