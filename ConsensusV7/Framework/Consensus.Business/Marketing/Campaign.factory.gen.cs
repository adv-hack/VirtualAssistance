using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Linq;

namespace Consensus.Marketing
{
    /// <summary>
    ///     Supports the instantiation of the <see cref="CampaignModel" /> class.
    /// </summary>
    /// <remarks>
    ///     THIS CODE HAS BEEN AUTOMATICALLY GENERATED USING THE CONSENSUS DEVELOPER TOOLS.
    ///     DO NOT EDIT THIS CODE AS ANY CUSTOM MODIFICATIONS WILL BE LOST UPON REGENERATION.
    /// </remarks>
    public interface ICampaignFactory : IFactory<ICampaignModel, String>
    {
        /// <summary>
        ///     Creates a new <see cref="!:CampaignModel" /> instance.
        /// </summary>
        /// <returns>
        ///     A newly instantiated <see cref="!:CampaignModel" /> instance.
        /// </returns>
        Consensus.Marketing.ICampaignModel Create();

        /// <summary>
        ///     Retrieves all instances of the <see cref="!:CampaignModel" /> class.
        /// </summary>
        /// <returns>
        ///     An enumerable collection of <see cref="!:CampaignModel" /> instances.
        /// </returns>
        System.Collections.Generic.IEnumerable<Consensus.Marketing.ICampaignModel> FetchAll();

        /// <summary>
        ///     Retrieves a specific <see cref="!:CampaignModel" /> instance.
        /// </summary>
        /// <param name="id">
        ///     The unique value which distinctly identifies the <see cref="!:CampaignModel" /> instance to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:CampaignModel" /> instance that matches the specified <paramref name="id" />; or null, if no matching instance can be found.
        /// </returns>
        Consensus.Marketing.ICampaignModel FetchById(System.String id);

        System.String GetTableName();

        /// <summary>
        ///     Retrieves a collection of <see cref="!:CampaignModel" /> instances.
        /// </summary>
        /// <param name="projectId">
        ///     The value which identifies the <see cref="!:CampaignModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:CampaignModel" /> instances that match the specified <paramref name="projectId" />.
        /// </returns>
        System.Collections.Generic.IEnumerable<Consensus.Marketing.ICampaignModel> FetchAllByProjectId(System.String projectId);

        /// <summary>
        ///     Retrieves a collection of <see cref="!:CampaignModel" /> instances.
        /// </summary>
        /// <param name="sellingCompanyId">
        ///     The value which identifies the <see cref="!:CampaignModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:CampaignModel" /> instances that match the specified <paramref name="sellingCompanyId" />.
        /// </returns>
        System.Collections.Generic.IEnumerable<Consensus.Marketing.ICampaignModel> FetchAllBySellingCompanyId(System.String sellingCompanyId);

        /// <summary>
        ///     Retrieves a collection of <see cref="!:CampaignModel" /> instances.
        /// </summary>
        /// <param name="managerId">
        ///     The value which identifies the <see cref="!:CampaignModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:CampaignModel" /> instances that match the specified <paramref name="managerId" />.
        /// </returns>
        System.Collections.Generic.IEnumerable<Consensus.Marketing.ICampaignModel> FetchAllByManagerId(System.String managerId);

        /// <summary>
        ///     Retrieves a collection of <see cref="!:CampaignModel" /> instances.
        /// </summary>
        /// <param name="approverId">
        ///     The value which identifies the <see cref="!:CampaignModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:CampaignModel" /> instances that match the specified <paramref name="approverId" />.
        /// </returns>
        System.Collections.Generic.IEnumerable<Consensus.Marketing.ICampaignModel> FetchAllByApproverId(System.String approverId);
    }
}
