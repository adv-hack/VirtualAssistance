using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Linq;

namespace Consensus.Finance
{
    /// <summary>
    ///     Supports the instantiation of the <see cref="BookingTermsModel" /> class.
    /// </summary>
    /// <remarks>
    ///     THIS CODE HAS BEEN AUTOMATICALLY GENERATED USING THE CONSENSUS DEVELOPER TOOLS.
    ///     DO NOT EDIT THIS CODE AS ANY CUSTOM MODIFICATIONS WILL BE LOST UPON REGENERATION.
    /// </remarks>
    public interface IBookingTermsFactory : IFactory<IBookingTermsModel, String>
    {
        /// <summary>
        ///     Creates a new <see cref="!:BookingTermsModel" /> instance.
        /// </summary>
        /// <returns>
        ///     A newly instantiated <see cref="!:BookingTermsModel" /> instance.
        /// </returns>
        Consensus.Finance.IBookingTermsModel Create();

        /// <summary>
        ///     Retrieves all instances of the <see cref="!:BookingTermsModel" /> class.
        /// </summary>
        /// <returns>
        ///     An enumerable collection of <see cref="!:BookingTermsModel" /> instances.
        /// </returns>
        System.Collections.Generic.IEnumerable<Consensus.Finance.IBookingTermsModel> FetchAll();

        /// <summary>
        ///     Retrieves a specific <see cref="!:BookingTermsModel" /> instance.
        /// </summary>
        /// <param name="id">
        ///     The unique value which distinctly identifies the <see cref="!:BookingTermsModel" /> instance to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:BookingTermsModel" /> instance that matches the specified <paramref name="id" />; or null, if no matching instance can be found.
        /// </returns>
        Consensus.Finance.IBookingTermsModel FetchById(System.String id);

        System.String GetTableName();
    }
}
