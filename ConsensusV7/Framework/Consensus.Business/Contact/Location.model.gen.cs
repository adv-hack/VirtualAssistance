using System;
using System.Collections.Generic;
using System.Linq;
using Consensus.Common;
using Consensus.Learning;

namespace Consensus.Contact
{
    /// <summary>
    ///     Encapsulates the <see cref="LocationRecord" /> data structure.
    /// </summary>
    /// <remarks>
    ///     THIS CODE HAS BEEN AUTOMATICALLY GENERATED USING THE CONSENSUS DEVELOPER TOOLS.
    ///     DO NOT EDIT THIS CODE AS ANY CUSTOM MODIFICATIONS WILL BE LOST UPON REGENERATION.
    /// </remarks>
    public interface ILocationModel : IModel<String>
    {
        /// <summary>
        ///     Gets the The value of the "LOC_ORG_ID" field.
        /// </summary>
        Consensus.Contact.IOrganisationModel Organisation
        {
            get;
        }

        /// <summary>
        ///     Gets or sets the unique code for the value of the "LOC_ORG_ID" field.
        /// </summary>
        System.String OrganisationId
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets the The value of the "LOC_ADD_ID" field.
        /// </summary>
        Consensus.Contact.IAddressModel Address
        {
            get;
        }

        /// <summary>
        ///     Gets or sets the unique code for the value of the "LOC_ADD_ID" field.
        /// </summary>
        System.String AddressId
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets or sets the value of the "LOC_REF" field.
        /// </summary>
        System.String Ref
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets or sets the value of the "LOC_NAME" field.
        /// </summary>
        System.String Name
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets or sets the value of the "LOC_EXTERNAL" field.
        /// </summary>
        System.Nullable<System.Byte> External
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets or sets the value of the "LOC_CONTACT_NAME" field.
        /// </summary>
        System.String ContactName
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets or sets the value of the "LOC_COST_PER_DAY" field.
        /// </summary>
        System.Nullable<System.Double> CostPerDay
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets or sets the value of the "LOC_MAX_PLACES" field.
        /// </summary>
        System.Nullable<System.Double> MaxPlaces
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets or sets the value of the "LOC_SIZE" field.
        /// </summary>
        System.String Size
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets or sets the value of the "LOC_BEDROOM" field.
        /// </summary>
        System.Nullable<System.Byte> Bedroom
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets or sets the value of the "LOC_ROOM_TYPE" field.
        /// </summary>
        System.String RoomType
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets or sets the value of the "LOC_ROOM_GRADE" field.
        /// </summary>
        System.String RoomGrade
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets or sets the value of the "LOC_DIRECTION" field.
        /// </summary>
        System.String Direction
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets or sets the value of the "LOC_HTML" field.
        /// </summary>
        System.String Html
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets or sets the value of the "LOC_URL" field.
        /// </summary>
        System.String Url
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets or sets the value of the "LOC_MAP_FILE" field.
        /// </summary>
        System.String MapFile
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets or sets the value of the "LOC_OUR_LOCATION" field.
        /// </summary>
        System.Nullable<System.Byte> OurLocation
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets or sets the value of the "LOC_TRAIN_PROVIDER" field.
        /// </summary>
        System.Nullable<System.Byte> TrainProvider
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets or sets the value of the "LOC_TRAIN_LOCATION" field.
        /// </summary>
        System.Nullable<System.Byte> TrainLocation
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets or sets the value of the "LOC_HOTEL" field.
        /// </summary>
        System.Nullable<System.Byte> Hotel
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets or sets the value of the "LOC_DIRECTIONS" field.
        /// </summary>
        System.String Directions
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets or sets the value of the "LOC_NOTES" field.
        /// </summary>
        System.String Notes
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets or sets the value of the "LOC_MAP_NAME" field.
        /// </summary>
        System.String MapName
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets the The value of the "LOC_SELCO_SP_ID" field.
        /// </summary>
        Consensus.Common.ISellingCompanyModel SellingCompany
        {
            get;
        }

        /// <summary>
        ///     Gets or sets the unique code for the value of the "LOC_SELCO_SP_ID" field.
        /// </summary>
        System.String SellingCompanyId
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets the The value of the "loc_prole_id" field.
        /// </summary>
        Consensus.Contact.IRoleModel LocationRole
        {
            get;
        }

        /// <summary>
        ///     Gets or sets the unique code for the value of the "loc_prole_id" field.
        /// </summary>
        System.String LocationRoleId
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets or sets the value of the "loc_phone" field.
        /// </summary>
        System.String LocationPhone
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets or sets the value of the "loc_fax" field.
        /// </summary>
        System.String LocationFax
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets or sets the value of the "loc_phone_std" field.
        /// </summary>
        System.String LocPhoneStd
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets or sets the value of the "loc_fax_std" field.
        /// </summary>
        System.String LocFaxStd
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets or sets the value of the "loc_email" field.
        /// </summary>
        System.String LocationEmail
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets or sets the value of the "LOC_MAP_IMAGE_PATH" field.
        /// </summary>
        System.String MapImagePath
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets or sets the value of the "LOC_DETAILS_PATH" field.
        /// </summary>
        System.String DetailsPath
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets the The value of the "LOC_REGION" field.
        /// </summary>
        Consensus.Common.ICodeModel Region
        {
            get;
        }

        /// <summary>
        ///     Gets or sets the unique code for the value of the "LOC_REGION" field.
        /// </summary>
        System.String RegionCode
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets or sets the value of the "LOC_COST_CODE" field.
        /// </summary>
        System.String CostCode
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets or sets the value of the "LOC_REV_CODE" field.
        /// </summary>
        System.String RevCode
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets or sets the value of the "LOC_WEB" field.
        /// </summary>
        System.Byte WebEnabled
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets the The value of the "LOC_VENUE_TYPE" field.
        /// </summary>
        Consensus.Common.ICodeModel VenueType
        {
            get;
        }

        /// <summary>
        ///     Gets or sets the unique code for the value of the "LOC_VENUE_TYPE" field.
        /// </summary>
        System.String VenueTypeCode
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets the The value of the "LOC_LINKED_LOC_ID" field.
        /// </summary>
        Consensus.Contact.ILocationModel LinkedLocation
        {
            get;
        }

        /// <summary>
        ///     Gets or sets the unique code for the value of the "LOC_LINKED_LOC_ID" field.
        /// </summary>
        System.String LinkedLocationId
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets or sets the value of the "LOC_TITLE" field.
        /// </summary>
        System.String Title
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets or sets the value of the "LOC_DESCRIPTION" field.
        /// </summary>
        System.String Description
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets the collection of <see cref="!:LocationModel" /> instances that reference this <see cref="!:LocationModel" />.
        /// </summary>
        Consensus.Collection<Consensus.Contact.ILocationModel> LinkedLocations
        {
            get;
        }

        /// <summary>
        ///     Gets the collection of <see cref="!:ProductModel" /> instances that reference this <see cref="!:LocationModel" />.
        /// </summary>
        Consensus.Collection<Consensus.Learning.IProductModel> Product
        {
            get;
        }

        /// <summary>
        ///     Gets the collection of <see cref="!:EventModel" /> instances that reference this <see cref="!:LocationModel" />.
        /// </summary>
        [NonSerializedAttribute]
        Consensus.Collection<Consensus.Learning.IEventModel> Events
        {
            get;
        }

        /// <summary>
        ///     Gets the collection of <see cref="!:SessionModel" /> instances that reference this <see cref="!:LocationModel" />.
        /// </summary>
        Consensus.Collection<Consensus.Learning.ISessionModel> SessionLocation
        {
            get;
        }
    }
}
