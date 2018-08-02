using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Linq;

namespace Consensus.Learning
{
    /// <summary>
    ///     Supports the instantiation of the <see cref="BillOfMaterialModel" /> class.
    /// </summary>
    /// <remarks>
    ///     THIS CODE HAS BEEN AUTOMATICALLY GENERATED USING THE CONSENSUS DEVELOPER TOOLS.
    ///     DO NOT EDIT THIS CODE AS ANY CUSTOM MODIFICATIONS WILL BE LOST UPON REGENERATION.
    /// </remarks>
    public interface IBillOfMaterialFactory : IFactory<IBillOfMaterialModel, String>
    {
        /// <summary>
        ///     Creates a new <see cref="!:BillOfMaterialModel" /> instance.
        /// </summary>
        /// <returns>
        ///     A newly instantiated <see cref="!:BillOfMaterialModel" /> instance.
        /// </returns>
        Consensus.Learning.IBillOfMaterialModel Create();

        /// <summary>
        ///     Retrieves all instances of the <see cref="!:BillOfMaterialModel" /> class.
        /// </summary>
        /// <returns>
        ///     An enumerable collection of <see cref="!:BillOfMaterialModel" /> instances.
        /// </returns>
        System.Collections.Generic.IEnumerable<Consensus.Learning.IBillOfMaterialModel> FetchAll();

        /// <summary>
        ///     Retrieves a specific <see cref="!:BillOfMaterialModel" /> instance.
        /// </summary>
        /// <param name="id">
        ///     The unique value which distinctly identifies the <see cref="!:BillOfMaterialModel" /> instance to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:BillOfMaterialModel" /> instance that matches the specified <paramref name="id" />; or null, if no matching instance can be found.
        /// </returns>
        Consensus.Learning.IBillOfMaterialModel FetchById(System.String id);

        System.String GetTableName();

        /// <summary>
        ///     Retrieves a collection of <see cref="!:BillOfMaterialModel" /> instances.
        /// </summary>
        /// <param name="masterProductId">
        ///     The value which identifies the <see cref="!:BillOfMaterialModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:BillOfMaterialModel" /> instances that match the specified <paramref name="masterProductId" />.
        /// </returns>
        System.Collections.Generic.IEnumerable<Consensus.Learning.IBillOfMaterialModel> FetchAllByMasterProductId(System.String masterProductId);

        /// <summary>
        ///     Retrieves a collection of <see cref="!:BillOfMaterialModel" /> instances.
        /// </summary>
        /// <param name="childProductId">
        ///     The value which identifies the <see cref="!:BillOfMaterialModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:BillOfMaterialModel" /> instances that match the specified <paramref name="childProductId" />.
        /// </returns>
        System.Collections.Generic.IEnumerable<Consensus.Learning.IBillOfMaterialModel> FetchAllByChildProductId(System.String childProductId);

        /// <summary>
        ///     Retrieves a collection of <see cref="!:BillOfMaterialModel" /> instances.
        /// </summary>
        /// <param name="accomProductId">
        ///     The value which identifies the <see cref="!:BillOfMaterialModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:BillOfMaterialModel" /> instances that match the specified <paramref name="accomProductId" />.
        /// </returns>
        System.Collections.Generic.IEnumerable<Consensus.Learning.IBillOfMaterialModel> FetchAllByAccomProductId(System.String accomProductId);

        System.Collections.Generic.IEnumerable<Consensus.Learning.IBillOfMaterialModel> FetchAllByPsgIdId(System.Nullable<System.Int32> psgIdId);
    }
}
