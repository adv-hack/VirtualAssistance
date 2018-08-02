using System;
using System.Collections.Generic;
using System.Linq;
using Consensus.Contact;
using Consensus.Learning;

namespace Consensus.Activities
{
    /// <summary>
    ///     Encapsulates the <see cref="ActivityXrefRecord" /> data structure.
    /// </summary>
    /// <remarks>
    ///     THIS CODE HAS BEEN AUTOMATICALLY GENERATED USING THE CONSENSUS DEVELOPER TOOLS.
    ///     DO NOT EDIT THIS CODE AS ANY CUSTOM MODIFICATIONS WILL BE LOST UPON REGENERATION.
    /// </remarks>
    public interface IActivityXrefModel : IModel<String>
    {
        Consensus.Activities.ActivityReferenceTypes ActivityReferenceType
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets the The value of the "ACTXREF_ACT_ID" field.
        /// </summary>
        Consensus.Activities.IActivityModel Activity
        {
            get;
        }

        /// <summary>
        ///     Gets or sets the unique code for the value of the "ACTXREF_ACT_ID" field.
        /// </summary>
        System.String ActivityId
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets the The value of the "ACTXREF_PERSON_ID" field.
        /// </summary>
        Consensus.Contact.IPersonModel Person
        {
            get;
        }

        /// <summary>
        ///     Gets or sets the unique code for the value of the "ACTXREF_PERSON_ID" field.
        /// </summary>
        System.String PersonId
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets the The value of the "ACTXREF_ORG_ID" field.
        /// </summary>
        Consensus.Contact.IOrganisationModel Organisation
        {
            get;
        }

        /// <summary>
        ///     Gets or sets the unique code for the value of the "ACTXREF_ORG_ID" field.
        /// </summary>
        System.String OrganisationId
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets the The value of the "ACTXREF_PROLE_ID" field.
        /// </summary>
        Consensus.Contact.IRoleModel PersonRole
        {
            get;
        }

        /// <summary>
        ///     Gets or sets the unique code for the value of the "ACTXREF_PROLE_ID" field.
        /// </summary>
        System.String PersonRoleId
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets or sets the value of the "ACTXREF_ORG_NAME" field.
        /// </summary>
        System.String OrgName
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets or sets the value of the "ACTXREF_PN_NAME" field.
        /// </summary>
        System.String PnName
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets or sets the value of the "ACTXREF_TYPE" field.
        /// </summary>
        System.Nullable<System.Byte> Type
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets or sets the value of the "ACTXREF_TRAINER" field.
        /// </summary>
        System.Nullable<System.Byte> Trainer
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets or sets the value of the "ACTXREF_ADMIN" field.
        /// </summary>
        System.Nullable<System.Byte> Admin
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets or sets the value of the "ACTXREF_SESSION" field.
        /// </summary>
        System.Nullable<System.Byte> Session
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets the The value of the "ACTXREF_PROD_ID" field.
        /// </summary>
        Consensus.Learning.IProductModel Product
        {
            get;
        }

        /// <summary>
        ///     Gets or sets the unique code for the value of the "ACTXREF_PROD_ID" field.
        /// </summary>
        System.String ProductId
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets or sets the value of the "ACTXREF_HOUR_RATE" field.
        /// </summary>
        System.Nullable<System.Double> HourRate
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets or sets the value of the "ACTXREF_DAY_RATE" field.
        /// </summary>
        System.Nullable<System.Double> DayRate
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets or sets the value of the "ACTXREF_CST_AC" field.
        /// </summary>
        System.Nullable<System.Double> CstAc
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets or sets the value of the "ACTXREF_TRAINER_T" field.
        /// </summary>
        System.String TrainerT
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets or sets the value of the "ACTXREF_ADMIN_T" field.
        /// </summary>
        System.String AdminT
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets or sets the value of the "ACTXREF_PROF_KEY" field.
        /// </summary>
        System.String ProfKey
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets or sets the value of the "ACTXREF_UNT_TYPE" field.
        /// </summary>
        System.String UntType
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets or sets the value of the "ACTXREF_INC_IN_BUDGET" field.
        /// </summary>
        System.Byte IncInBudget
        {
            get;
            set;
        }
    }
}
