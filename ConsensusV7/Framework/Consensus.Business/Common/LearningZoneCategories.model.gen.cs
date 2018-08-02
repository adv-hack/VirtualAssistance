using System;
using System.Collections.Generic;
using System.Linq;

namespace Consensus.Common
{
    /// <summary>
    ///     Encapsulates the <see cref="LearningzonecategoriesRecord" /> data structure.
    /// </summary>
    /// <remarks>
    ///     THIS CODE HAS BEEN AUTOMATICALLY GENERATED USING THE CONSENSUS DEVELOPER TOOLS.
    ///     DO NOT EDIT THIS CODE AS ANY CUSTOM MODIFICATIONS WILL BE LOST UPON REGENERATION.
    /// </remarks>
    public interface ILearningZoneCategoriesModel : IModel<Int32>
    {
        /// <summary>
        ///     Gets or sets the value of the "LZC_CATEGORY_TITLE" field.
        /// </summary>
        System.String CategoryTitle
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets or sets the value of the "LZC_DESCRIPTION" field.
        /// </summary>
        System.String Description
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets or sets the value of the "LZC_DESCRIPTION_HTML" field.
        /// </summary>
        System.String DescriptionHtml
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets the collection of <see cref="!:AttachLearningZoneCategoriesModel" /> instances that reference this <see cref="!:LearningZoneCategoriesModel" />.
        /// </summary>
        Consensus.Collection<Consensus.Common.IAttachLearningZoneCategoriesModel> LearningZoneCategoriesLinkCategories
        {
            get;
        }
    }
}
