using System;
using System.Collections.Generic;
using System.Linq;
using Consensus.Learning;

namespace Consensus.Finance
{
    /// <summary>
    ///     Encapsulates the <see cref="BookingTermsRecord" /> data structure.
    /// </summary>
    /// <remarks>
    ///     THIS CODE HAS BEEN AUTOMATICALLY GENERATED USING THE CONSENSUS DEVELOPER TOOLS.
    ///     DO NOT EDIT THIS CODE AS ANY CUSTOM MODIFICATIONS WILL BE LOST UPON REGENERATION.
    /// </remarks>
    public interface IBookingTermsModel : IModel<String>
    {
        /// <summary>
        ///     Gets or sets the value of the "BKT_DESCRIPTION" field.
        /// </summary>
        System.String Description
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets the collection of <see cref="!:ProductModel" /> instances that reference this <see cref="!:BookingTermsModel" />.
        /// </summary>
        Consensus.Collection<Consensus.Learning.IProductModel> Product
        {
            get;
        }

        /// <summary>
        ///     Gets the collection of <see cref="!:EventModel" /> instances that reference this <see cref="!:BookingTermsModel" />.
        /// </summary>
        [NonSerializedAttribute]
        Consensus.Collection<Consensus.Learning.IEventModel> Events
        {
            get;
        }

        /// <summary>
        ///     Gets the collection of <see cref="!:ElementModel" /> instances that reference this <see cref="!:BookingTermsModel" />.
        /// </summary>
        Consensus.Collection<Consensus.Learning.IElementModel> Elements
        {
            get;
        }
    }
}
