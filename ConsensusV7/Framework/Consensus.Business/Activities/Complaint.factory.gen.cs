using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Linq;

namespace Consensus.Activities
{
    /// <summary>
    ///     Supports the instantiation of the <see cref="ComplaintModel" /> class.
    /// </summary>
    /// <remarks>
    ///     THIS CODE HAS BEEN AUTOMATICALLY GENERATED USING THE CONSENSUS DEVELOPER TOOLS.
    ///     DO NOT EDIT THIS CODE AS ANY CUSTOM MODIFICATIONS WILL BE LOST UPON REGENERATION.
    /// </remarks>
    public interface IComplaintFactory : IFactory<IComplaintModel, String>
    {
        /// <summary>
        ///     Creates a new <see cref="!:ComplaintModel" /> instance.
        /// </summary>
        /// <returns>
        ///     A newly instantiated <see cref="!:ComplaintModel" /> instance.
        /// </returns>
        Consensus.Activities.IComplaintModel Create();

        /// <summary>
        ///     Retrieves all instances of the <see cref="!:ComplaintModel" /> class.
        /// </summary>
        /// <returns>
        ///     An enumerable collection of <see cref="!:ComplaintModel" /> instances.
        /// </returns>
        System.Collections.Generic.IEnumerable<Consensus.Activities.IComplaintModel> FetchAll();

        /// <summary>
        ///     Retrieves a specific <see cref="!:ComplaintModel" /> instance.
        /// </summary>
        /// <param name="id">
        ///     The unique value which distinctly identifies the <see cref="!:ComplaintModel" /> instance to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:ComplaintModel" /> instance that matches the specified <paramref name="id" />; or null, if no matching instance can be found.
        /// </returns>
        Consensus.Activities.IComplaintModel FetchById(System.String id);

        System.String GetTableName();

        /// <summary>
        ///     Retrieves a collection of <see cref="!:ComplaintModel" /> instances.
        /// </summary>
        /// <param name="fromProleIdId">
        ///     The value which identifies the <see cref="!:ComplaintModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:ComplaintModel" /> instances that match the specified <paramref name="fromProleIdId" />.
        /// </returns>
        System.Collections.Generic.IEnumerable<Consensus.Activities.IComplaintModel> FetchAllByFromProleIdId(System.String fromProleIdId);

        /// <summary>
        ///     Retrieves a collection of <see cref="!:ComplaintModel" /> instances.
        /// </summary>
        /// <param name="reProleIdId">
        ///     The value which identifies the <see cref="!:ComplaintModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:ComplaintModel" /> instances that match the specified <paramref name="reProleIdId" />.
        /// </returns>
        System.Collections.Generic.IEnumerable<Consensus.Activities.IComplaintModel> FetchAllByReProleIdId(System.String reProleIdId);

        /// <summary>
        ///     Retrieves a collection of <see cref="!:ComplaintModel" /> instances.
        /// </summary>
        /// <param name="mgrProleIdId">
        ///     The value which identifies the <see cref="!:ComplaintModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:ComplaintModel" /> instances that match the specified <paramref name="mgrProleIdId" />.
        /// </returns>
        System.Collections.Generic.IEnumerable<Consensus.Activities.IComplaintModel> FetchAllByMgrProleIdId(System.String mgrProleIdId);

        /// <summary>
        ///     Retrieves a collection of <see cref="!:ComplaintModel" /> instances.
        /// </summary>
        /// <param name="medtrProleIdId">
        ///     The value which identifies the <see cref="!:ComplaintModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:ComplaintModel" /> instances that match the specified <paramref name="medtrProleIdId" />.
        /// </returns>
        System.Collections.Generic.IEnumerable<Consensus.Activities.IComplaintModel> FetchAllByMedtrProleIdId(System.String medtrProleIdId);

        /// <summary>
        ///     Retrieves a collection of <see cref="!:ComplaintModel" /> instances.
        /// </summary>
        /// <param name="promotionIDId">
        ///     The value which identifies the <see cref="!:ComplaintModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:ComplaintModel" /> instances that match the specified <paramref name="promotionIDId" />.
        /// </returns>
        System.Collections.Generic.IEnumerable<Consensus.Activities.IComplaintModel> FetchAllByPromotionIDId(System.String promotionIDId);

        /// <summary>
        ///     Retrieves a collection of <see cref="!:ComplaintModel" /> instances.
        /// </summary>
        /// <param name="detailsIdId">
        ///     The value which identifies the <see cref="!:ComplaintModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:ComplaintModel" /> instances that match the specified <paramref name="detailsIdId" />.
        /// </returns>
        System.Collections.Generic.IEnumerable<Consensus.Activities.IComplaintModel> FetchAllByDetailsIdId(System.String detailsIdId);
    }
}
