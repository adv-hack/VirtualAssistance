using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Linq;

namespace Consensus.Contact
{
    /// <summary>
    ///     Supports the instantiation of the <see cref="TrainProdXrefModel" /> class.
    /// </summary>
    /// <remarks>
    ///     THIS CODE HAS BEEN AUTOMATICALLY GENERATED USING THE CONSENSUS DEVELOPER TOOLS.
    ///     DO NOT EDIT THIS CODE AS ANY CUSTOM MODIFICATIONS WILL BE LOST UPON REGENERATION.
    /// </remarks>
    public interface ITrainProdXrefFactory : IFactory<ITrainProdXrefModel, String>
    {
        /// <summary>
        ///     Creates a new <see cref="!:TrainProdXrefModel" /> instance.
        /// </summary>
        /// <returns>
        ///     A newly instantiated <see cref="!:TrainProdXrefModel" /> instance.
        /// </returns>
        Consensus.Contact.ITrainProdXrefModel Create();

        /// <summary>
        ///     Retrieves all instances of the <see cref="!:TrainProdXrefModel" /> class.
        /// </summary>
        /// <returns>
        ///     An enumerable collection of <see cref="!:TrainProdXrefModel" /> instances.
        /// </returns>
        System.Collections.Generic.IEnumerable<Consensus.Contact.ITrainProdXrefModel> FetchAll();

        /// <summary>
        ///     Retrieves a specific <see cref="!:TrainProdXrefModel" /> instance.
        /// </summary>
        /// <param name="id">
        ///     The unique value which distinctly identifies the <see cref="!:TrainProdXrefModel" /> instance to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:TrainProdXrefModel" /> instance that matches the specified <paramref name="id" />; or null, if no matching instance can be found.
        /// </returns>
        Consensus.Contact.ITrainProdXrefModel FetchById(System.String id);

        System.String GetTableName();

        /// <summary>
        ///     Retrieves a collection of <see cref="!:TrainProdXrefModel" /> instances.
        /// </summary>
        /// <param name="trainerId">
        ///     The value which identifies the <see cref="!:TrainProdXrefModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:TrainProdXrefModel" /> instances that match the specified <paramref name="trainerId" />.
        /// </returns>
        System.Collections.Generic.IEnumerable<Consensus.Contact.ITrainProdXrefModel> FetchAllByTrainerId(System.String trainerId);

        /// <summary>
        ///     Retrieves a collection of <see cref="!:TrainProdXrefModel" /> instances.
        /// </summary>
        /// <param name="productId">
        ///     The value which identifies the <see cref="!:TrainProdXrefModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:TrainProdXrefModel" /> instances that match the specified <paramref name="productId" />.
        /// </returns>
        System.Collections.Generic.IEnumerable<Consensus.Contact.ITrainProdXrefModel> FetchAllByProductId(System.String productId);
    }
}
