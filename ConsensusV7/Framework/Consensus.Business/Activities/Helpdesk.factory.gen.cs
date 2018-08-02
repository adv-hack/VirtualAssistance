using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Linq;

namespace Consensus.Activities
{
    /// <summary>
    ///     Supports the instantiation of the <see cref="HelpdeskModel" /> class.
    /// </summary>
    /// <remarks>
    ///     THIS CODE HAS BEEN AUTOMATICALLY GENERATED USING THE CONSENSUS DEVELOPER TOOLS.
    ///     DO NOT EDIT THIS CODE AS ANY CUSTOM MODIFICATIONS WILL BE LOST UPON REGENERATION.
    /// </remarks>
    public interface IHelpdeskFactory : IFactory<IHelpdeskModel, String>
    {
        /// <summary>
        ///     Creates a new <see cref="!:HelpdeskModel" /> instance.
        /// </summary>
        /// <returns>
        ///     A newly instantiated <see cref="!:HelpdeskModel" /> instance.
        /// </returns>
        Consensus.Activities.IHelpdeskModel Create();

        /// <summary>
        ///     Retrieves all instances of the <see cref="!:HelpdeskModel" /> class.
        /// </summary>
        /// <returns>
        ///     An enumerable collection of <see cref="!:HelpdeskModel" /> instances.
        /// </returns>
        System.Collections.Generic.IEnumerable<Consensus.Activities.IHelpdeskModel> FetchAll();

        /// <summary>
        ///     Retrieves a specific <see cref="!:HelpdeskModel" /> instance.
        /// </summary>
        /// <param name="id">
        ///     The unique value which distinctly identifies the <see cref="!:HelpdeskModel" /> instance to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:HelpdeskModel" /> instance that matches the specified <paramref name="id" />; or null, if no matching instance can be found.
        /// </returns>
        Consensus.Activities.IHelpdeskModel FetchById(System.String id);

        System.String GetTableName();

        /// <summary>
        ///     Retrieves a collection of <see cref="!:HelpdeskModel" /> instances.
        /// </summary>
        /// <param name="orgIdId">
        ///     The value which identifies the <see cref="!:HelpdeskModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:HelpdeskModel" /> instances that match the specified <paramref name="orgIdId" />.
        /// </returns>
        System.Collections.Generic.IEnumerable<Consensus.Activities.IHelpdeskModel> FetchAllByOrgIdId(System.String orgIdId);

        /// <summary>
        ///     Retrieves a collection of <see cref="!:HelpdeskModel" /> instances.
        /// </summary>
        /// <param name="proleIdId">
        ///     The value which identifies the <see cref="!:HelpdeskModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:HelpdeskModel" /> instances that match the specified <paramref name="proleIdId" />.
        /// </returns>
        System.Collections.Generic.IEnumerable<Consensus.Activities.IHelpdeskModel> FetchAllByProleIdId(System.String proleIdId);

        /// <summary>
        ///     Retrieves a collection of <see cref="!:HelpdeskModel" /> instances.
        /// </summary>
        /// <param name="givenToIdId">
        ///     The value which identifies the <see cref="!:HelpdeskModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:HelpdeskModel" /> instances that match the specified <paramref name="givenToIdId" />.
        /// </returns>
        System.Collections.Generic.IEnumerable<Consensus.Activities.IHelpdeskModel> FetchAllByGivenToIdId(System.String givenToIdId);

        /// <summary>
        ///     Retrieves a collection of <see cref="!:HelpdeskModel" /> instances.
        /// </summary>
        /// <param name="detailsIdId">
        ///     The value which identifies the <see cref="!:HelpdeskModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:HelpdeskModel" /> instances that match the specified <paramref name="detailsIdId" />.
        /// </returns>
        System.Collections.Generic.IEnumerable<Consensus.Activities.IHelpdeskModel> FetchAllByDetailsIdId(System.String detailsIdId);

        /// <summary>
        ///     Retrieves a collection of <see cref="!:HelpdeskModel" /> instances.
        /// </summary>
        /// <param name="fixIdId">
        ///     The value which identifies the <see cref="!:HelpdeskModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:HelpdeskModel" /> instances that match the specified <paramref name="fixIdId" />.
        /// </returns>
        System.Collections.Generic.IEnumerable<Consensus.Activities.IHelpdeskModel> FetchAllByFixIdId(System.String fixIdId);

        /// <summary>
        ///     Retrieves a collection of <see cref="!:HelpdeskModel" /> instances.
        /// </summary>
        /// <param name="wipIdId">
        ///     The value which identifies the <see cref="!:HelpdeskModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:HelpdeskModel" /> instances that match the specified <paramref name="wipIdId" />.
        /// </returns>
        System.Collections.Generic.IEnumerable<Consensus.Activities.IHelpdeskModel> FetchAllByWipIdId(System.String wipIdId);

        /// <summary>
        ///     Retrieves a collection of <see cref="!:HelpdeskModel" /> instances.
        /// </summary>
        /// <param name="selcoSpIdId">
        ///     The value which identifies the <see cref="!:HelpdeskModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:HelpdeskModel" /> instances that match the specified <paramref name="selcoSpIdId" />.
        /// </returns>
        System.Collections.Generic.IEnumerable<Consensus.Activities.IHelpdeskModel> FetchAllBySelcoSpIdId(System.String selcoSpIdId);

        /// <summary>
        ///     Retrieves a collection of <see cref="!:HelpdeskModel" /> instances.
        /// </summary>
        /// <param name="pmIdId">
        ///     The value which identifies the <see cref="!:HelpdeskModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:HelpdeskModel" /> instances that match the specified <paramref name="pmIdId" />.
        /// </returns>
        System.Collections.Generic.IEnumerable<Consensus.Activities.IHelpdeskModel> FetchAllByPmIdId(System.String pmIdId);
    }
}
