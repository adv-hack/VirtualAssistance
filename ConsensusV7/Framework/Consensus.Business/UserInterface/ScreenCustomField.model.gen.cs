using System;
using System.Collections.Generic;
using System.Linq;

namespace Consensus.UserInterface
{
    /// <summary>
    ///     Encapsulates the <see cref="ScreenCustomFieldRecord" /> data structure.
    /// </summary>
    /// <remarks>
    ///     THIS CODE HAS BEEN AUTOMATICALLY GENERATED USING THE CONSENSUS DEVELOPER TOOLS.
    ///     DO NOT EDIT THIS CODE AS ANY CUSTOM MODIFICATIONS WILL BE LOST UPON REGENERATION.
    /// </remarks>
    public interface IScreenCustomFieldModel : IModel<Int32>
    {
        /// <summary>
        ///     Gets or sets the value of the "CFIELD_URL" field.
        /// </summary>
        System.String Url
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets or sets the value of the "CFIELD_PARENT_CONTROL" field.
        /// </summary>
        System.String ParentControl
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets or sets the value of the "CFIELD_NAME" field.
        /// </summary>
        System.String Name
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets or sets the value of the "CFIELD_LABEL" field.
        /// </summary>
        System.String Label
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets the The value of the "CFIELD_CFTYPE_ID" field.
        /// </summary>
        Consensus.UserInterface.IScreenCustomFieldTypeModel Cftype
        {
            get;
        }

        /// <summary>
        ///     Gets or sets the unique code for the value of the "CFIELD_CFTYPE_ID" field.
        /// </summary>
        System.String CftypeId
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets or sets the value of the "CFIELD_POPUP_URL" field.
        /// </summary>
        System.String PopupUrl
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets or sets the value of the "CFIELD_DECIMALS" field.
        /// </summary>
        System.Nullable<System.Int32> Decimals
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets or sets the value of the "CFIELD_PAGE" field.
        /// </summary>
        System.String Page
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets or sets the value of the "CFIELD_TABLE" field.
        /// </summary>
        System.String Table
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets the collection of <see cref="!:ScreenCustomFieldListitemModel" /> instances that reference this <see cref="!:ScreenCustomFieldModel" />.
        /// </summary>
        Consensus.Collection<Consensus.UserInterface.IScreenCustomFieldListitemModel> CustomFieldListItems
        {
            get;
        }

        /// <summary>
        ///     Gets the collection of <see cref="!:ScreenCustomFieldValueModel" /> instances that reference this <see cref="!:ScreenCustomFieldModel" />.
        /// </summary>
        Consensus.Collection<Consensus.UserInterface.IScreenCustomFieldValueModel> CustomFieldValues
        {
            get;
        }
    }
}
