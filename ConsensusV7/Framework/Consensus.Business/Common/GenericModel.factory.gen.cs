using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Linq;

namespace Consensus.Common
{
    /// <summary>
    ///     Supports the instantiation of the <see cref="GenericModelModel" /> class.
    /// </summary>
    /// <remarks>
    ///     THIS CODE HAS BEEN AUTOMATICALLY GENERATED USING THE CONSENSUS DEVELOPER TOOLS.
    ///     DO NOT EDIT THIS CODE AS ANY CUSTOM MODIFICATIONS WILL BE LOST UPON REGENERATION.
    /// </remarks>
    public interface IGenericModelFactory : IFactory<IGenericModelModel, String>
    {
        /// <summary>
        ///     Retrieves a specific <see cref="!:GenericModelModel" /> instance.
        /// </summary>
        /// <returns>
        ///     The <see cref="!:GenericModelModel" /> instance that matches the specified <paramref name="accId" />; or null, if no matching instance can be found.
        /// </returns>
        System.Collections.Generic.IEnumerable<Consensus.Common.IGenericModelModel> FetchAllByAccIdAccountXref(System.String accId, System.String proleId);

        /// <summary>
        ///     Retrieves a specific <see cref="!:GenericModelModel" /> instance.
        /// </summary>
        /// <returns>
        ///     The <see cref="!:GenericModelModel" /> instance that matches the specified <paramref name="courseid" />; or null, if no matching instance can be found.
        /// </returns>
        System.Collections.Generic.IEnumerable<Consensus.Common.IGenericModelModel> FetchAllByCourseIdSessions(System.String courseid);

        /// <summary>
        ///     Retrieves a specific <see cref="!:GenericModelModel" /> instance.
        /// </summary>
        /// <returns>
        ///     The <see cref="!:GenericModelModel" /> instance that matches the specified <paramref name="courseid" />; or null, if no matching instance can be found.
        /// </returns>
        System.Collections.Generic.IEnumerable<Consensus.Common.IGenericModelModel> FetchAllByCourseIdPrices(System.String courseid, System.Int32 delcount);

        /// <summary>
        ///     Retrieves a specific <see cref="!:GenericModelModel" /> instance.
        /// </summary>
        /// <returns>
        ///     The <see cref="!:GenericModelModel" /> instance that matches the specified <paramref name="courseid" />; or null, if no matching instance can be found.
        /// </returns>
        System.Collections.Generic.IEnumerable<Consensus.Common.IGenericModelModel> FetchAllByProdIdPrices(System.String prodid, System.Int32 qty);

        /// <summary>
        ///     Retrieves a specific <see cref="!:GenericModelModel" /> instance.
        /// </summary>
        /// <returns>
        ///     The <see cref="!:GenericModelModel" /> instance that matches the specified <paramref name="courseid" />; or null, if no matching instance can be found.
        /// </returns>
        System.Collections.Generic.IEnumerable<Consensus.Common.IGenericModelModel> ValidateDelegate(System.String courseid, System.String proleid, System.String qualid, System.Int16 ignorefreeplaces, System.Int16 delquantity);

        /// <summary>
        ///     Creates a new <see cref="!:GenericModelModel" /> instance.
        /// </summary>
        /// <returns>
        ///     A newly instantiated <see cref="!:GenericModelModel" /> instance.
        /// </returns>
        Consensus.Common.IGenericModelModel Create();

        /// <summary>
        ///     Retrieves all instances of the <see cref="!:GenericModelModel" /> class.
        /// </summary>
        /// <returns>
        ///     An enumerable collection of <see cref="!:GenericModelModel" /> instances.
        /// </returns>
        System.Collections.Generic.IEnumerable<Consensus.Common.IGenericModelModel> FetchAll();

        /// <summary>
        ///     Retrieves a specific <see cref="!:GenericModelModel" /> instance.
        /// </summary>
        /// <param name="id">
        ///     The unique value which distinctly identifies the <see cref="!:GenericModelModel" /> instance to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:GenericModelModel" /> instance that matches the specified <paramref name="id" />; or null, if no matching instance can be found.
        /// </returns>
        Consensus.Common.IGenericModelModel FetchById(System.String id);

        System.String GetTableName();
    }
}
