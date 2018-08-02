using System;
using System.Collections.Generic;
using System.Linq;

namespace Consensus.UserInterface
{
    /// <summary>
    ///     Encapsulates the <see cref="ScreenObjectRecord" /> data structure.
    /// </summary>
    /// <remarks>
    ///     THIS CODE HAS BEEN AUTOMATICALLY GENERATED USING THE CONSENSUS DEVELOPER TOOLS.
    ///     DO NOT EDIT THIS CODE AS ANY CUSTOM MODIFICATIONS WILL BE LOST UPON REGENERATION.
    /// </remarks>
    public interface IScreenObjectModel : IModel<Int32>
    {
        /// <summary>
        ///     Gets or sets the visibility mode of the screen object.
        /// </summary>
        Consensus.UserInterface.ScreenObjectVisibility Visibility
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets or sets the visibility mode of the screen object.
        /// </summary>
        Consensus.UserInterface.ScreenObjectRequirement Requirement
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets or sets the value of the "OBJ_URL" field.
        /// </summary>
        System.String Url
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets or sets the value of the "OBJ_CONTROL" field.
        /// </summary>
        System.String Control
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets or sets the value of the "OBJ_TITLE" field.
        /// </summary>
        System.String Title
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets or sets the value of the "OBJ_ICON" field.
        /// </summary>
        System.String Icon
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets or sets the value of the "OBJ_VALIDATOR_EXPRESSION" field.
        /// </summary>
        System.String ValidatorExpression
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets or sets the value of the "OBJ_VALIDATOR_MESSAGE" field.
        /// </summary>
        System.String ValidatorMessage
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets or sets the value of the "OBJ_VALIDATOR_CRITICAL" field.
        /// </summary>
        System.Boolean ValidatorCritical
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets or sets the value of the "OBJ_MAX_LENGTH" field.
        /// </summary>
        System.Int32 MaximumLength
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets or sets the value of the "OBJ_OFF_TEXT" field.
        /// </summary>
        System.String OffText
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets or sets the value of the "OBJ_OFF_COLOUR" field.
        /// </summary>
        System.String OffColour
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets or sets the value of the "OBJ_ON_TEXT" field.
        /// </summary>
        System.String OnText
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets or sets the value of the "OBJ_ON_COLOUR" field.
        /// </summary>
        System.String OnColour
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets or sets the value of the "OBJ_DEFAULT" field.
        /// </summary>
        System.String Default
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets the collection of <see cref="!:ScreenObjectDisplayModel" /> instances that reference this <see cref="!:ScreenObjectModel" />.
        /// </summary>
        Consensus.Collection<Consensus.UserInterface.IScreenObjectDisplayModel> DisplayRules
        {
            get;
        }

        /// <summary>
        ///     Gets the collection of <see cref="!:ScreenObjectEntryModel" /> instances that reference this <see cref="!:ScreenObjectModel" />.
        /// </summary>
        Consensus.Collection<Consensus.UserInterface.IScreenObjectEntryModel> Entries
        {
            get;
        }

        /// <summary>
        ///     Gets the collection of <see cref="!:ScreenObjectColumnModel" /> instances that reference this <see cref="!:ScreenObjectModel" />.
        /// </summary>
        Consensus.Collection<Consensus.UserInterface.IScreenObjectColumnModel> Columns
        {
            get;
        }
    }
}
