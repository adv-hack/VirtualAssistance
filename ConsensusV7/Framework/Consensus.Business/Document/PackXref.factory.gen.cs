using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Linq;

namespace Consensus.Document
{
    /// <summary>
    ///     Supports the instantiation of the <see cref="PackXrefModel" /> class.
    /// </summary>
    /// <remarks>
    ///     THIS CODE HAS BEEN AUTOMATICALLY GENERATED USING THE CONSENSUS DEVELOPER TOOLS.
    ///     DO NOT EDIT THIS CODE AS ANY CUSTOM MODIFICATIONS WILL BE LOST UPON REGENERATION.
    /// </remarks>
    public interface IPackXrefFactory : IFactory<IPackXrefModel, String>
    {
        /// <summary>
        ///     Creates a new <see cref="!:PackXrefModel" /> instance.
        /// </summary>
        /// <returns>
        ///     A newly instantiated <see cref="!:PackXrefModel" /> instance.
        /// </returns>
        Consensus.Document.IPackXrefModel Create();

        /// <summary>
        ///     Retrieves all instances of the <see cref="!:PackXrefModel" /> class.
        /// </summary>
        /// <returns>
        ///     An enumerable collection of <see cref="!:PackXrefModel" /> instances.
        /// </returns>
        System.Collections.Generic.IEnumerable<Consensus.Document.IPackXrefModel> FetchAll();

        /// <summary>
        ///     Retrieves a specific <see cref="!:PackXrefModel" /> instance.
        /// </summary>
        /// <param name="id">
        ///     The unique value which distinctly identifies the <see cref="!:PackXrefModel" /> instance to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:PackXrefModel" /> instance that matches the specified <paramref name="id" />; or null, if no matching instance can be found.
        /// </returns>
        Consensus.Document.IPackXrefModel FetchById(System.String id);

        System.String GetTableName();

        /// <summary>
        ///     Retrieves a collection of <see cref="!:PackXrefModel" /> instances.
        /// </summary>
        /// <param name="packIdId">
        ///     The value which identifies the <see cref="!:PackXrefModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:PackXrefModel" /> instances that match the specified <paramref name="packIdId" />.
        /// </returns>
        System.Collections.Generic.IEnumerable<Consensus.Document.IPackXrefModel> FetchAllByPackIdId(System.String packIdId);

        /// <summary>
        ///     Retrieves a collection of <see cref="!:PackXrefModel" /> instances.
        /// </summary>
        /// <param name="litIdId">
        ///     The value which identifies the <see cref="!:PackXrefModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:PackXrefModel" /> instances that match the specified <paramref name="litIdId" />.
        /// </returns>
        System.Collections.Generic.IEnumerable<Consensus.Document.IPackXrefModel> FetchAllByLitIdId(System.String litIdId);

        System.Collections.Generic.IEnumerable<Consensus.Document.IPackXrefModel> FetchAllBySmsIdId(System.Nullable<System.Int32> smsIdId);

        System.Collections.Generic.IEnumerable<Consensus.Document.IPackXrefModel> FetchAllByIcmIdId(System.Nullable<System.Int32> icmIdId);
    }
}
