using System;
using System.Collections.Generic;
using System.Linq;

namespace Consensus.Learning
{
    /// <summary>
    ///     Encapsulates the <see cref="ProdselectgroupsRecord" /> data structure.
    /// </summary>
    /// <remarks>
    ///     THIS CODE HAS BEEN AUTOMATICALLY GENERATED USING THE CONSENSUS DEVELOPER TOOLS.
    ///     DO NOT EDIT THIS CODE AS ANY CUSTOM MODIFICATIONS WILL BE LOST UPON REGENERATION.
    /// </remarks>
    public interface IProdSelectGroupModel : IModel<Int32>
    {
        /// <summary>
        ///     Gets the The value of the "PSG_PROD_ID" field.
        /// </summary>
        Consensus.Learning.IProductModel ProdId
        {
            get;
        }

        /// <summary>
        ///     Gets or sets the unique code for the value of the "PSG_PROD_ID" field.
        /// </summary>
        System.String ProdIdId
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets or sets the value of the "PSG_TYPE" field.
        /// </summary>
        System.Byte Type
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets or sets the value of the "PSG_NAME" field.
        /// </summary>
        System.String Name
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets or sets the value of the "PSG_DESCRIPTION" field.
        /// </summary>
        System.String Description
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets or sets the value of the "PSG_MIN" field.
        /// </summary>
        System.Byte Min
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets or sets the value of the "PSG_MAX" field.
        /// </summary>
        System.Byte Max
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets or sets the value of the "PSG_ORDER" field.
        /// </summary>
        System.Byte Order
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets or sets the value of the "PSG_ERROR_MESSAGE" field.
        /// </summary>
        System.String ErrorMessage
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets the collection of <see cref="!:BillOfMaterialModel" /> instances that reference this <see cref="!:ProdSelectGroupModel" />.
        /// </summary>
        Consensus.Collection<Consensus.Learning.IBillOfMaterialModel> BOMSelectGroup
        {
            get;
        }

        /// <summary>
        ///     Gets the collection of <see cref="!:CourseSelectGroupsModel" /> instances that reference this <see cref="!:ProdSelectGroupModel" />.
        /// </summary>
        Consensus.Collection<Consensus.Learning.ICourseSelectGroupsModel> CourseSelectionGroups
        {
            get;
        }
    }
}
