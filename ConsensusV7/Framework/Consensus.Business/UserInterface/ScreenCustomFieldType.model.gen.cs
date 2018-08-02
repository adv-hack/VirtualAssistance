using System;
using System.Collections.Generic;
using System.Linq;

namespace Consensus.UserInterface
{
    /// <summary>
    ///     Encapsulates the <see cref="ScreenCustomFieldTypeRecord" /> data structure.
    /// </summary>
    /// <remarks>
    ///     THIS CODE HAS BEEN AUTOMATICALLY GENERATED USING THE CONSENSUS DEVELOPER TOOLS.
    ///     DO NOT EDIT THIS CODE AS ANY CUSTOM MODIFICATIONS WILL BE LOST UPON REGENERATION.
    /// </remarks>
    public interface IScreenCustomFieldTypeModel : IModel<String>
    {
        /// <summary>
        ///     Gets or sets the value of the "CFTYPE_NAME" field.
        /// </summary>
        System.String Name
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets the collection of <see cref="!:ScreenCustomFieldModel" /> instances that reference this <see cref="!:ScreenCustomFieldTypeModel" />.
        /// </summary>
        Consensus.Collection<Consensus.UserInterface.IScreenCustomFieldModel> CustomFieldTypes
        {
            get;
        }
    }
}
