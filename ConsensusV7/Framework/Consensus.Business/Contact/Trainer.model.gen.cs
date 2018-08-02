using System;
using System.Collections.Generic;
using System.Linq;
using Consensus.Activities;
using Consensus.Common;

namespace Consensus.Contact
{
    /// <summary>
    ///     Encapsulates the <see cref="TrainerRecord" /> data structure.
    /// </summary>
    /// <remarks>
    ///     THIS CODE HAS BEEN AUTOMATICALLY GENERATED USING THE CONSENSUS DEVELOPER TOOLS.
    ///     DO NOT EDIT THIS CODE AS ANY CUSTOM MODIFICATIONS WILL BE LOST UPON REGENERATION.
    /// </remarks>
    public interface ITrainerModel : IModel<String>
    {
        /// <summary>
        ///     Gets or sets the value of the "TRAIN_ADD_BY" field.
        /// </summary>
        System.String AinAddBy
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets or sets the value of the "TRAIN_MOD_BY" field.
        /// </summary>
        System.String AinModBy
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets the The value of the "TRAIN_PROLE_ID" field.
        /// </summary>
        Consensus.Contact.IRoleModel Role
        {
            get;
        }

        /// <summary>
        ///     Gets or sets the unique code for the value of the "TRAIN_PROLE_ID" field.
        /// </summary>
        System.String RoleId
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets or sets the value of the "TRAIN_START_DATE" field.
        /// </summary>
        System.Nullable<System.DateTime> AinStartDate
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets the The value of the "TRAIN_STATUS" field.
        /// </summary>
        Consensus.Common.ICodeModel Status
        {
            get;
        }

        /// <summary>
        ///     Gets or sets the unique code for the value of the "TRAIN_STATUS" field.
        /// </summary>
        System.String StatusCode
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets or sets the value of the "TRAIN_REVIEW_DATE" field.
        /// </summary>
        System.Nullable<System.DateTime> AinReviewDate
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets or sets the value of the "TRAIN_REF" field.
        /// </summary>
        System.String AinRef
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets or sets the value of the "TRAIN_COST" field.
        /// </summary>
        System.Nullable<System.Decimal> AinCost
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets or sets the value of the "TRAIN_BIOG" field.
        /// </summary>
        System.String AinBiog
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets the The value of the "TRAIN_ATTRIB01" field.
        /// </summary>
        Consensus.Common.ICodeModel Attribute01
        {
            get;
        }

        /// <summary>
        ///     Gets or sets the unique code for the value of the "TRAIN_ATTRIB01" field.
        /// </summary>
        System.String Attribute01Code
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets or sets the value of the "TRAIN_DAY_COST" field.
        /// </summary>
        System.Decimal AinDayCost
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets or sets the value of the "TRAIN_HOUR_COST" field.
        /// </summary>
        System.Decimal AinHourCost
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets or sets the value of the "TRAIN_BASE_POSTCODE" field.
        /// </summary>
        System.String AinBasePostcode
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets the The value of the "TRAIN_SELCO_SP_ID" field.
        /// </summary>
        Consensus.Common.ISellingCompanyModel SellingCompany
        {
            get;
        }

        /// <summary>
        ///     Gets or sets the unique code for the value of the "TRAIN_SELCO_SP_ID" field.
        /// </summary>
        System.String SellingCompanyId
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets or sets the value of the "TRAIN_INS_EXPIRY" field.
        /// </summary>
        System.Nullable<System.DateTime> AinInsExpiry
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets or sets the value of the "TRN_UNIQUE_REF" field.
        /// </summary>
        System.String NUniqueRef
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets the The value of the "TRAIN_FEE_NOTES_TEXT_ID" field.
        /// </summary>
        Consensus.Activities.IC4textModel FeeNotesText
        {
            get;
        }

        /// <summary>
        ///     Gets or sets the unique code for the value of the "TRAIN_FEE_NOTES_TEXT_ID" field.
        /// </summary>
        System.String FeeNotesTextId
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets the The value of the "TRAIN_HOTEL_REQ_TEXT_ID" field.
        /// </summary>
        Consensus.Activities.IC4textModel HotelReqText
        {
            get;
        }

        /// <summary>
        ///     Gets or sets the unique code for the value of the "TRAIN_HOTEL_REQ_TEXT_ID" field.
        /// </summary>
        System.String HotelReqTextId
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets the The value of the "TRAIN_OTHER_INFO_TEXT_ID" field.
        /// </summary>
        Consensus.Activities.IC4textModel OtherInfoText
        {
            get;
        }

        /// <summary>
        ///     Gets or sets the unique code for the value of the "TRAIN_OTHER_INFO_TEXT_ID" field.
        /// </summary>
        System.String OtherInfoTextId
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets or sets the value of the "TRAIN_PASSWORD" field.
        /// </summary>
        System.String AinPassword
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets or sets the value of the "TRAIN_WEB" field.
        /// </summary>
        System.Byte AinWeb
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets or sets the value of the "TRAIN_SY_TYPE" field.
        /// </summary>
        System.Int32 AinSyType
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets the collection of <see cref="!:TrainProdXrefModel" /> instances that reference this <see cref="!:TrainerModel" />.
        /// </summary>
        Consensus.Collection<Consensus.Contact.ITrainProdXrefModel> TrainProductXrefTrainer
        {
            get;
        }

        /// <summary>
        ///     Gets the collection of <see cref="!:ProfileTrainerModel" /> instances that reference this <see cref="!:TrainerModel" />.
        /// </summary>
        Consensus.Collection<Consensus.Common.IProfileTrainerModel> Trainers
        {
            get;
        }

        /// <summary>
        ///     Gets the collection of <see cref="!:ProfileVolunteerModel" /> instances that reference this <see cref="!:TrainerModel" />.
        /// </summary>
        Consensus.Collection<Consensus.Common.IProfileVolunteerModel> ProfileVolunteers
        {
            get;
        }
    }
}
