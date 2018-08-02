using System;
using System.Collections.Generic;
using System.Linq;
using Consensus.Learning;

namespace Consensus.Membership
{
    /// <summary>
    ///     Encapsulates the <see cref="MemberBomRecord" /> data structure.
    /// </summary>
    /// <remarks>
    ///     THIS CODE HAS BEEN AUTOMATICALLY GENERATED USING THE CONSENSUS DEVELOPER TOOLS.
    ///     DO NOT EDIT THIS CODE AS ANY CUSTOM MODIFICATIONS WILL BE LOST UPON REGENERATION.
    /// </remarks>
    public interface IMemberBomModel : IModel<String>
    {
        /// <summary>
        ///     Gets the The value of the "MBOM_PARENT_ID" field.
        /// </summary>
        Consensus.Learning.IProductModel ProdParentId
        {
            get;
        }

        /// <summary>
        ///     Gets or sets the unique code for the value of the "MBOM_PARENT_ID" field.
        /// </summary>
        System.String ProdParentIdId
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets or sets the value of the "MBOM_PROD_ID" field.
        /// </summary>
        System.String ProdId
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets the The value of the "MBOM_GRADE_ID" field.
        /// </summary>
        Consensus.Learning.IProductModel GradeProd
        {
            get;
        }

        /// <summary>
        ///     Gets or sets the unique code for the value of the "MBOM_GRADE_ID" field.
        /// </summary>
        System.String GradeProdId
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets or sets the value of the "MBOM_MAIN" field.
        /// </summary>
        System.Nullable<System.Byte> Main
        {
            get;
            set;
        }
    }
}
