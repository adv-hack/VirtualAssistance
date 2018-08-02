using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Linq;

namespace Consensus.Sales
{
    /// <summary>
    ///     Supports the instantiation of the <see cref="SalesChannelModel" /> class.
    /// </summary>
    /// <remarks>
    ///     THIS CODE HAS BEEN AUTOMATICALLY GENERATED USING THE CONSENSUS DEVELOPER TOOLS.
    ///     DO NOT EDIT THIS CODE AS ANY CUSTOM MODIFICATIONS WILL BE LOST UPON REGENERATION.
    /// </remarks>
    public interface ISalesChannelFactory : IFactory<ISalesChannelModel, String>
    {
        /// <summary>
        ///     Creates a new <see cref="!:SalesChannelModel" /> instance.
        /// </summary>
        /// <returns>
        ///     A newly instantiated <see cref="!:SalesChannelModel" /> instance.
        /// </returns>
        Consensus.Sales.ISalesChannelModel Create();

        /// <summary>
        ///     Retrieves all instances of the <see cref="!:SalesChannelModel" /> class.
        /// </summary>
        /// <returns>
        ///     An enumerable collection of <see cref="!:SalesChannelModel" /> instances.
        /// </returns>
        System.Collections.Generic.IEnumerable<Consensus.Sales.ISalesChannelModel> FetchAll();

        /// <summary>
        ///     Retrieves a specific <see cref="!:SalesChannelModel" /> instance.
        /// </summary>
        /// <param name="id">
        ///     The unique value which distinctly identifies the <see cref="!:SalesChannelModel" /> instance to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:SalesChannelModel" /> instance that matches the specified <paramref name="id" />; or null, if no matching instance can be found.
        /// </returns>
        Consensus.Sales.ISalesChannelModel FetchById(System.String id);

        System.String GetTableName();
    }
}
