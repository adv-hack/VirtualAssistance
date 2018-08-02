using System;
using System.Collections.Generic;
using System.Linq;
using Consensus.Common;

namespace Consensus.Document
{
    /// <summary>
    ///     Encapsulates the <see cref="IcalmessageRecord" /> data structure.
    /// </summary>
    /// <remarks>
    ///     THIS CODE HAS BEEN AUTOMATICALLY GENERATED USING THE CONSENSUS DEVELOPER TOOLS.
    ///     DO NOT EDIT THIS CODE AS ANY CUSTOM MODIFICATIONS WILL BE LOST UPON REGENERATION.
    /// </remarks>
    public interface IICalMessageModel : IModel<Int32>
    {
        /// <summary>
        ///     Gets the The value of the "ICM_ICMT_ID" field.
        /// </summary>
        Consensus.Document.IICalMessageTypeModel ICalMessageType
        {
            get;
        }

        /// <summary>
        ///     Gets or sets the unique code for the value of the "ICM_ICMT_ID" field.
        /// </summary>
        System.Nullable<System.Int32> ICalMessageTypeId
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets or sets the value of the "ICM_CURRENT" field.
        /// </summary>
        System.Nullable<System.Byte> Current
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets or sets the value of the "ICM_METHOD" field.
        /// </summary>
        System.Nullable<System.Byte> Method
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets or sets the value of the "ICM_NAME" field.
        /// </summary>
        System.String Name
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets or sets the value of the "ICM_DESCRIPTION" field.
        /// </summary>
        System.String Description
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets or sets the value of the "ICM_SUBJECT" field.
        /// </summary>
        System.String Subject
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets or sets the value of the "ICM_LOCATION" field.
        /// </summary>
        System.String Location
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets or sets the value of the "ICM_TEXT" field.
        /// </summary>
        System.String Text
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets the The value of the "ICM_SELCO_SP_ID" field.
        /// </summary>
        Consensus.Common.ISellingCompanyModel SellingCompany
        {
            get;
        }

        /// <summary>
        ///     Gets or sets the unique code for the value of the "ICM_SELCO_SP_ID" field.
        /// </summary>
        System.String SellingCompanyId
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets the collection of <see cref="!:PackXrefModel" /> instances that reference this <see cref="!:ICalMessageModel" />.
        /// </summary>
        Consensus.Collection<Consensus.Document.IPackXrefModel> ICalMessageId
        {
            get;
        }
    }
}
