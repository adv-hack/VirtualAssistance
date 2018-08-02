using System;
using System.Collections.Generic;
using System.Linq;
using Consensus.Common;

namespace Consensus.Finance
{
    /// <summary>
    ///     Encapsulates the <see cref="CostCodeRecord" /> data structure.
    /// </summary>
    /// <remarks>
    ///     THIS CODE HAS BEEN AUTOMATICALLY GENERATED USING THE CONSENSUS DEVELOPER TOOLS.
    ///     DO NOT EDIT THIS CODE AS ANY CUSTOM MODIFICATIONS WILL BE LOST UPON REGENERATION.
    /// </remarks>
    public interface ICostCodeModel : IModel<String>
    {
        /// <summary>
        ///     Gets or sets the value of the "COST_CODE" field.
        /// </summary>
        System.String Code
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets or sets the value of the "COST_DESC" field.
        /// </summary>
        System.String Desc
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets the The value of the "COST_SELCO_SP_ID" field.
        /// </summary>
        Consensus.Common.ISellingCompanyModel SelcoSpId
        {
            get;
        }

        /// <summary>
        ///     Gets or sets the unique code for the value of the "COST_SELCO_SP_ID" field.
        /// </summary>
        System.String SelcoSpIdId
        {
            get;
            set;
        }
    }
}
