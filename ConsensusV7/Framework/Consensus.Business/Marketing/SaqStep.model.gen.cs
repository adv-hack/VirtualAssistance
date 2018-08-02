using System;
using System.Collections.Generic;
using System.Linq;
using Consensus.Contact;

namespace Consensus.Marketing
{
    /// <summary>
    ///     Encapsulates the <see cref="SaqStepRecord" /> data structure.
    /// </summary>
    /// <remarks>
    ///     THIS CODE HAS BEEN AUTOMATICALLY GENERATED USING THE CONSENSUS DEVELOPER TOOLS.
    ///     DO NOT EDIT THIS CODE AS ANY CUSTOM MODIFICATIONS WILL BE LOST UPON REGENERATION.
    /// </remarks>
    public interface ISaqStepModel : IModel<Int64>
    {
        /// <summary>
        ///     Gets the The value of the "STEP_PROLE_ID" field.
        /// </summary>
        Consensus.Contact.IRoleModel OwnerRole
        {
            get;
        }

        /// <summary>
        ///     Gets or sets the unique code for the value of the "STEP_PROLE_ID" field.
        /// </summary>
        System.String OwnerRoleId
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets or sets the value of the "STEP_NAME" field.
        /// </summary>
        System.String Name
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets or sets the value of the "STEP_DESC" field.
        /// </summary>
        System.String Desc
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets or sets the value of the "STEP_RESULT_SIZE_OPT" field.
        /// </summary>
        System.Byte ResultSizeOpt
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets or sets the value of the "STEP_RESULT_SIZE" field.
        /// </summary>
        System.Int64 ResultSize
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets or sets the value of the "STEP_IN_USE" field.
        /// </summary>
        System.Byte InUse
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets or sets the value of the "STEP_ORG_ONLY" field.
        /// </summary>
        System.Byte OrgOnly
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets or sets the value of the "STEP_LOCKED" field.
        /// </summary>
        System.Byte Locked
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets or sets the value of the "STEP_BOOK_ONLY" field.
        /// </summary>
        System.Byte BookOnly
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets or sets the value of the "STEP_LINK_DEFAULT" field.
        /// </summary>
        System.String LinkDefault
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets the collection of <see cref="!:SaqParameterModel" /> instances that reference this <see cref="!:SaqStepModel" />.
        /// </summary>
        Consensus.Collection<Consensus.Marketing.ISaqParameterModel> SaqParameterStep
        {
            get;
        }

        /// <summary>
        ///     Gets the collection of <see cref="!:SaqQueryStepModel" /> instances that reference this <see cref="!:SaqStepModel" />.
        /// </summary>
        Consensus.Collection<Consensus.Marketing.ISaqQueryStepModel> SaqQueryStepStep
        {
            get;
        }
    }
}
