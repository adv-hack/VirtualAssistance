using System;
using System.Collections.Generic;
using System.Linq;
using Consensus.Learning;

namespace Consensus.Common
{
    /// <summary>
    ///     Encapsulates the <see cref="ProfileRecord" /> data structure.
    /// </summary>
    /// <remarks>
    ///     THIS CODE HAS BEEN AUTOMATICALLY GENERATED USING THE CONSENSUS DEVELOPER TOOLS.
    ///     DO NOT EDIT THIS CODE AS ANY CUSTOM MODIFICATIONS WILL BE LOST UPON REGENERATION.
    /// </remarks>
    public interface IProfileProductModel : IProfileModel
    {
        /// <summary>
        ///     Gets the The value of the "PROF_PROD_ID" field.
        /// </summary>
        Consensus.Learning.IProductModel Product
        {
            get;
        }

        /// <summary>
        ///     Gets or sets the unique code for the value of the "PROF_PROD_ID" field.
        /// </summary>
        System.String ProductId
        {
            get;
            set;
        }
    }
}
