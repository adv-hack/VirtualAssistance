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
    public interface ITemplateModel : IModel<String>
    {
        /// <summary>
        ///     Gets the The value of the "TXREF_BOM_ID" field.
        /// </summary>
        Consensus.Learning.IBillOfMaterialModel BillOfMaterial
        {
            get;
        }

        /// <summary>
        ///     Gets or sets the unique code for the value of the "TXREF_BOM_ID" field.
        /// </summary>
        System.String BillOfMaterialId
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets or sets the value of the "TXREF_QTY" field.
        /// </summary>
        System.Nullable<System.Double> Qty
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets or sets the value of the "TXREF_DEL_QTY" field.
        /// </summary>
        System.Nullable<System.Double> DelQty
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets or sets the value of the "TXREF_PER_DAY" field.
        /// </summary>
        System.Nullable<System.Byte> PerDay
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets or sets the value of the "TXREF_UNT_TYPE" field.
        /// </summary>
        System.String UntType
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets or sets the value of the "TXREF_COST" field.
        /// </summary>
        System.Decimal Cost
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets or sets the value of the "TXREF_INC_IN_BUDGET" field.
        /// </summary>
        System.Byte IncInBudget
        {
            get;
            set;
        }
    }
}
