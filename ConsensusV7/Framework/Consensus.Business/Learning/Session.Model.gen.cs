using System;
using System.Collections.Generic;
using System.Linq;
using Consensus.Activities;
using Consensus.Contact;

namespace Consensus.Learning
{
    /// <summary>
    ///     Encapsulates the <see cref="ActivityRecord" /> data structure.
    /// </summary>
    /// <remarks>
    ///     THIS CODE HAS BEEN AUTOMATICALLY GENERATED USING THE CONSENSUS DEVELOPER TOOLS.
    ///     DO NOT EDIT THIS CODE AS ANY CUSTOM MODIFICATIONS WILL BE LOST UPON REGENERATION.
    /// </remarks>
    public interface ISessionModel : IActivityModel
    {
        /// <summary>
        ///     Gets or sets the main session.
        /// </summary>
        Consensus.Learning.ISessionXrefModel SessionXrefMaster
        {
            get;
        }

        System.Boolean IsModified
        {
            get;
        }

        /// <summary>
        ///     Gets or sets the value of the "ACT_DONE_IT" field.
        /// </summary>
        System.Nullable<System.Byte> DoneIt
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets the The value of the "ACT_LOC_ID" field.
        /// </summary>
        Consensus.Contact.ILocationModel Location
        {
            get;
        }

        /// <summary>
        ///     Gets or sets the unique code for the value of the "ACT_LOC_ID" field.
        /// </summary>
        System.String LocationId
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets the The value of the "ACT_SYLLABUS_ID" field.
        /// </summary>
        Consensus.Learning.IProductModel Product
        {
            get;
        }

        /// <summary>
        ///     Gets or sets the unique code for the value of the "ACT_SYLLABUS_ID" field.
        /// </summary>
        System.String ProductId
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets or sets the value of the "ACT_MAX_PLACES" field.
        /// </summary>
        System.Nullable<System.Double> MaxPlaces
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets or sets the value of the "ACT_MIN_PLACES" field.
        /// </summary>
        System.Nullable<System.Double> MinPlaces
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets or sets the value of the "ACT_FREE_PLACES" field.
        /// </summary>
        System.Nullable<System.Double> FreePlaces
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets the The value of the "ACT_ORG_ID" field.
        /// </summary>
        Consensus.Contact.IOrganisationModel Organisation
        {
            get;
        }

        /// <summary>
        ///     Gets or sets the unique code for the value of the "ACT_ORG_ID" field.
        /// </summary>
        System.String OrganisationId
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets or sets the value of the "ACT_ADDRESS" field.
        /// </summary>
        System.String Address
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets or sets the value of the "ACT_PQ_ID" field.
        /// </summary>
        System.String PqId
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets or sets the value of the "ACT_ROOM_LAYOUT" field.
        /// </summary>
        System.Nullable<System.Int32> RoomLayout
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets or sets the value of the "ACT_TEACH_HRS" field.
        /// </summary>
        System.Nullable<System.Decimal> TeachHrs
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets or sets the value of the "ACT_STUD_WKS" field.
        /// </summary>
        System.Nullable<System.Decimal> StudWks
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets the The value of the "ACT_BOM_ID" field.
        /// </summary>
        Consensus.Learning.IBillOfMaterialModel BiillOfMaterial
        {
            get;
        }

        /// <summary>
        ///     Gets or sets the unique code for the value of the "ACT_BOM_ID" field.
        /// </summary>
        System.String BiillOfMaterialId
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets or sets the value of the "ACT_CG_CODE" field.
        /// </summary>
        System.String UnitNumber
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets or sets the value of the "ACT_SHOW_ATT_LOG" field.
        /// </summary>
        System.Nullable<System.Byte> ShowAttLog
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets the collection of <see cref="!:SessionXrefModel" /> instances that reference this <see cref="!:SessionModel" />.
        /// </summary>
        Consensus.Collection<Consensus.Learning.ISessionXrefModel> SessionXrefActivity
        {
            get;
        }
    }
}
