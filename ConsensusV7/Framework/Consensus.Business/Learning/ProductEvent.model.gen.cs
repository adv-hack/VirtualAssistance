using System;
using System.Collections.Generic;
using System.Linq;
using Consensus.Common;

namespace Consensus.Learning
{
    /// <summary>
    ///     Encapsulates the <see cref="ProductEventRecord" /> data structure.
    /// </summary>
    /// <remarks>
    ///     THIS CODE HAS BEEN AUTOMATICALLY GENERATED USING THE CONSENSUS DEVELOPER TOOLS.
    ///     DO NOT EDIT THIS CODE AS ANY CUSTOM MODIFICATIONS WILL BE LOST UPON REGENERATION.
    /// </remarks>
    public interface IProductEventModel : IModel<Int32>
    {
        /// <summary>
        ///     Gets the The value of the "PE_PROD_ID" field.
        /// </summary>
        Consensus.Learning.IProductModel Product
        {
            get;
        }

        /// <summary>
        ///     Gets or sets the unique code for the value of the "PE_PROD_ID" field.
        /// </summary>
        System.String ProductId
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets or sets the value of the "PE_INSTANCE" field.
        /// </summary>
        System.Int32 Instance
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets the The value of the "PE_ACADY_CODE" field.
        /// </summary>
        Consensus.Common.ICodeModel AcadyCode
        {
            get;
        }

        /// <summary>
        ///     Gets or sets the unique code for the value of the "PE_ACADY_CODE" field.
        /// </summary>
        System.String AcadyCodeCode
        {
            get;
            set;
        }
    }
}
