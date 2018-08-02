using System;
using System.Collections.Generic;
using System.Linq;

namespace Consensus.Document
{
    /// <summary>
    ///     Encapsulates the <see cref="LettmplttypeRecord" /> data structure.
    /// </summary>
    /// <remarks>
    ///     THIS CODE HAS BEEN AUTOMATICALLY GENERATED USING THE CONSENSUS DEVELOPER TOOLS.
    ///     DO NOT EDIT THIS CODE AS ANY CUSTOM MODIFICATIONS WILL BE LOST UPON REGENERATION.
    /// </remarks>
    public interface ILetterTemplateTypeModel : IModel<String>
    {
        /// <summary>
        ///     Gets or sets the value of the "LTT_NAME" field.
        /// </summary>
        System.String Name
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets or sets the value of the "LTT_DESC" field.
        /// </summary>
        System.String Desc
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets or sets the value of the "LTT_TYPE" field.
        /// </summary>
        System.Nullable<System.Byte> Type
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets the collection of <see cref="!:LetterTemplateModel" /> instances that reference this <see cref="!:LetterTemplateTypeModel" />.
        /// </summary>
        Consensus.Collection<Consensus.Document.ILetterTemplateModel> LetterTemplates
        {
            get;
        }
    }
}
