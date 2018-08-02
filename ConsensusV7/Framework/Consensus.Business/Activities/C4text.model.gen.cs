using System;
using System.Collections.Generic;
using System.Linq;
using Consensus.Contact;
using Consensus.Document;
using Consensus.Learning;

namespace Consensus.Activities
{
    /// <summary>
    ///     Encapsulates the <see cref="C4textRecord" /> data structure.
    /// </summary>
    /// <remarks>
    ///     THIS CODE HAS BEEN AUTOMATICALLY GENERATED USING THE CONSENSUS DEVELOPER TOOLS.
    ///     DO NOT EDIT THIS CODE AS ANY CUSTOM MODIFICATIONS WILL BE LOST UPON REGENERATION.
    /// </remarks>
    public interface IC4textModel : IModel<String>
    {
        /// <summary>
        ///     The resolved name of the user that created the record.
        /// </summary>
        System.String AddByName
        {
            get;
        }

        /// <summary>
        ///     The resolved name of the user that last updated the record.
        /// </summary>
        System.String ModByName
        {
            get;
        }

        /// <summary>
        ///     Gets or sets the value of the "TEXT_ADD_DATE" field.
        /// </summary>
        System.Nullable<System.DateTime> AddDate
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets or sets the value of the "TEXT_ADD_BY" field.
        /// </summary>
        System.String AddBy
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets or sets the value of the "TEXT_MOD_DATE" field.
        /// </summary>
        System.Nullable<System.DateTime> ModDate
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets or sets the value of the "TEXT_MOD_BY" field.
        /// </summary>
        System.String ModBy
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets or sets the value of the "TEXT_TYPE" field.
        /// </summary>
        System.String Type
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets or sets the value of the "TEXT_OWNER_ID" field.
        /// </summary>
        System.String OwnerId
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets or sets the value of the "TEXT_BODY" field.
        /// </summary>
        System.String Body
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets or sets the value of the "TEXT_HTML" field.
        /// </summary>
        System.String Html
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets or sets the value of the "TEXT_OWNER_URL" field.
        /// </summary>
        System.String OwnerUrl
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets the collection of <see cref="!:TrainerModel" /> instances that reference this <see cref="!:C4textModel" />.
        /// </summary>
        Consensus.Collection<Consensus.Contact.ITrainerModel> TrainersFeeNoteText
        {
            get;
        }

        /// <summary>
        ///     Gets the collection of <see cref="!:TrainerModel" /> instances that reference this <see cref="!:C4textModel" />.
        /// </summary>
        Consensus.Collection<Consensus.Contact.ITrainerModel> TrainersHotelReqText
        {
            get;
        }

        /// <summary>
        ///     Gets the collection of <see cref="!:TrainerModel" /> instances that reference this <see cref="!:C4textModel" />.
        /// </summary>
        Consensus.Collection<Consensus.Contact.ITrainerModel> TrainersOtherInfoText
        {
            get;
        }

        /// <summary>
        ///     Gets the collection of <see cref="!:ProductModel" /> instances that reference this <see cref="!:C4textModel" />.
        /// </summary>
        Consensus.Collection<Consensus.Learning.IProductModel> ProductsDescrip
        {
            get;
        }

        /// <summary>
        ///     Gets the collection of <see cref="!:ProductModel" /> instances that reference this <see cref="!:C4textModel" />.
        /// </summary>
        Consensus.Collection<Consensus.Learning.IProductModel> ProductsText1
        {
            get;
        }

        /// <summary>
        ///     Gets the collection of <see cref="!:ProductModel" /> instances that reference this <see cref="!:C4textModel" />.
        /// </summary>
        Consensus.Collection<Consensus.Learning.IProductModel> ProductsText2
        {
            get;
        }

        /// <summary>
        ///     Gets the collection of <see cref="!:ProductModel" /> instances that reference this <see cref="!:C4textModel" />.
        /// </summary>
        Consensus.Collection<Consensus.Learning.IProductModel> ProductsText3
        {
            get;
        }

        /// <summary>
        ///     Gets the collection of <see cref="!:ProductModel" /> instances that reference this <see cref="!:C4textModel" />.
        /// </summary>
        Consensus.Collection<Consensus.Learning.IProductModel> ProductsTrnRulesTxt
        {
            get;
        }

        /// <summary>
        ///     Gets the collection of <see cref="!:PackModel" /> instances that reference this <see cref="!:C4textModel" />.
        /// </summary>
        Consensus.Collection<Consensus.Document.IPackModel> PackEmailBody
        {
            get;
        }

        /// <summary>
        ///     Gets the collection of <see cref="!:HelpdeskModel" /> instances that reference this <see cref="!:C4textModel" />.
        /// </summary>
        Consensus.Collection<Consensus.Activities.IHelpdeskModel> HelpdeskDetails
        {
            get;
        }

        /// <summary>
        ///     Gets the collection of <see cref="!:HelpdeskModel" /> instances that reference this <see cref="!:C4textModel" />.
        /// </summary>
        Consensus.Collection<Consensus.Activities.IHelpdeskModel> HelpdeskFixes
        {
            get;
        }

        /// <summary>
        ///     Gets the collection of <see cref="!:HelpdeskModel" /> instances that reference this <see cref="!:C4textModel" />.
        /// </summary>
        Consensus.Collection<Consensus.Activities.IHelpdeskModel> HelpdeskWIPs
        {
            get;
        }

        /// <summary>
        ///     Gets the collection of <see cref="!:ComplaintModel" /> instances that reference this <see cref="!:C4textModel" />.
        /// </summary>
        Consensus.Collection<Consensus.Activities.IComplaintModel> ComplaintDetails
        {
            get;
        }
    }
}
