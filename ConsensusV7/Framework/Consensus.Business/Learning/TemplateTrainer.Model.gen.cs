using System;
using System.Collections.Generic;
using System.Linq;
using Consensus.Contact;

namespace Consensus.Learning
{
    /// <summary>
    ///     Encapsulates the <see cref="TemplateXrefRecord" /> data structure.
    /// </summary>
    /// <remarks>
    ///     THIS CODE HAS BEEN AUTOMATICALLY GENERATED USING THE CONSENSUS DEVELOPER TOOLS.
    ///     DO NOT EDIT THIS CODE AS ANY CUSTOM MODIFICATIONS WILL BE LOST UPON REGENERATION.
    /// </remarks>
    public interface ITemplateTrainerModel : ITemplateModel
    {
        /// <summary>
        ///     Gets the The value of the "TXREF_TRAINER" field.
        /// </summary>
        Consensus.Common.ICodeModel TypeModel
        {
            get;
        }

        System.String TypeModelCode
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets or sets the value of the "TXREF_PROF_KEY" field.
        /// </summary>
        System.String ProfKey
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets or sets the value of the "TXREF_PROF_VALUE" field.
        /// </summary>
        System.String ProfValue
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets or sets the value of the "TXREF_PROF_VALUE2" field.
        /// </summary>
        System.String ProfValue2
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets or sets the value of the "TXREF_RATIO" field.
        /// </summary>
        System.Int32 Ratio
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets or sets the value of the "TXREF_TRAINER" field.
        /// </summary>
        System.Nullable<System.Byte> Trainer
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets the The value of the "TXREF_TRAIN_PROLE_ID" field.
        /// </summary>
        Consensus.Contact.IRoleModel TrainerRole
        {
            get;
        }

        /// <summary>
        ///     Gets or sets the unique code for the value of the "TXREF_TRAIN_PROLE_ID" field.
        /// </summary>
        System.String TrainerRoleId
        {
            get;
            set;
        }
    }
}
