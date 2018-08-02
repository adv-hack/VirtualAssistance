using System;
using System.Collections.Generic;
using System.Linq;

namespace Consensus.Learning
{
    /// <summary>
    ///     Encapsulates the <see cref="TemplateXrefRecord" /> data structure.
    /// </summary>
    /// <remarks>
    ///     THIS CODE HAS BEEN AUTOMATICALLY GENERATED USING THE CONSENSUS DEVELOPER TOOLS.
    ///     DO NOT EDIT THIS CODE AS ANY CUSTOM MODIFICATIONS WILL BE LOST UPON REGENERATION.
    /// </remarks>
    public interface ITemplateResourceModel : ITemplateModel
    {
        /// <summary>
        ///     Gets the The value of the "TXREF_PROD_ID" field.
        /// </summary>
        Consensus.Learning.IProductModel Resource
        {
            get;
        }

        /// <summary>
        ///     Gets or sets the unique code for the value of the "TXREF_PROD_ID" field.
        /// </summary>
        System.String ResourceId
        {
            get;
            set;
        }
    }
}
