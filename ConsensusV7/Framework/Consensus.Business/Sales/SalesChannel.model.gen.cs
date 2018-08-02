using System;
using System.Collections.Generic;
using System.Linq;
using Consensus.Learning;

namespace Consensus.Sales
{
    /// <summary>
    ///     Encapsulates the <see cref="SalesChannelRecord" /> data structure.
    /// </summary>
    /// <remarks>
    ///     THIS CODE HAS BEEN AUTOMATICALLY GENERATED USING THE CONSENSUS DEVELOPER TOOLS.
    ///     DO NOT EDIT THIS CODE AS ANY CUSTOM MODIFICATIONS WILL BE LOST UPON REGENERATION.
    /// </remarks>
    public interface ISalesChannelModel : IModel<String>
    {
        /// <summary>
        ///     Gets or sets the value of the "SCHN_NAME" field.
        /// </summary>
        System.String Name
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets the collection of <see cref="!:RelatedProductModel" /> instances that reference this <see cref="!:SalesChannelModel" />.
        /// </summary>
        Consensus.Collection<Consensus.Learning.IRelatedProductModel> RelatedProducts
        {
            get;
        }

        /// <summary>
        ///     Gets the collection of <see cref="!:BookingModel" /> instances that reference this <see cref="!:SalesChannelModel" />.
        /// </summary>
        Consensus.Collection<Consensus.Learning.IBookingModel> Bookings
        {
            get;
        }
    }
}
