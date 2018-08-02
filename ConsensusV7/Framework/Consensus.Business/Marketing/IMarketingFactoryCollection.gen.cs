using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Linq;

namespace Consensus.Marketing
{
    /// <summary>
    ///     Represents a collection of factory instances which are responsible for the instantiation of the business models in the Marketing namespace.
    /// </summary>
    /// <remarks>
    ///     THIS CODE HAS BEEN AUTOMATICALLY GENERATED USING THE CONSENSUS DEVELOPER TOOLS.
    ///     DO NOT EDIT THIS CODE AS ANY CUSTOM MODIFICATIONS WILL BE LOST UPON REGENERATION.
    /// </remarks>
    public interface IMarketingFactoryCollection : IFactoryCollection
    {
        /// <summary>
        ///     Gets the locally executable factory which is responsible for instantiating <see cref="!:CampaignModel" /> objects.
        /// </summary>
        Consensus.Marketing.ICampaignFactory Campaign
        {
            get;
        }

        /// <summary>
        ///     Gets the locally executable factory which is responsible for instantiating <see cref="!:PromotionModel" /> objects.
        /// </summary>
        Consensus.Marketing.IPromotionFactory Promotion
        {
            get;
        }

        /// <summary>
        ///     Gets the locally executable factory which is responsible for instantiating <see cref="!:PromotionMasterModel" /> objects.
        /// </summary>
        Consensus.Marketing.IPromotionMasterFactory PromotionMaster
        {
            get;
        }

        /// <summary>
        ///     Gets the locally executable factory which is responsible for instantiating <see cref="!:SaqFilterFieldModel" /> objects.
        /// </summary>
        Consensus.Marketing.ISaqFilterFieldFactory SaqFilterField
        {
            get;
        }

        /// <summary>
        ///     Gets the locally executable factory which is responsible for instantiating <see cref="!:SaqStepModel" /> objects.
        /// </summary>
        Consensus.Marketing.ISaqStepFactory SaqStep
        {
            get;
        }

        /// <summary>
        ///     Gets the locally executable factory which is responsible for instantiating <see cref="!:SaqParameterModel" /> objects.
        /// </summary>
        Consensus.Marketing.ISaqParameterFactory SaqParameter
        {
            get;
        }

        /// <summary>
        ///     Gets the locally executable factory which is responsible for instantiating <see cref="!:SaqQueryModel" /> objects.
        /// </summary>
        Consensus.Marketing.ISaqQueryFactory SaqQuery
        {
            get;
        }

        /// <summary>
        ///     Gets the locally executable factory which is responsible for instantiating <see cref="!:SaqQueryStepModel" /> objects.
        /// </summary>
        Consensus.Marketing.ISaqQueryStepFactory SaqQueryStep
        {
            get;
        }

        /// <summary>
        ///     Gets the locally executable factory which is responsible for instantiating <see cref="!:SaqQueueModel" /> objects.
        /// </summary>
        Consensus.Marketing.ISaqQueueFactory SaqQueue
        {
            get;
        }

        /// <summary>
        ///     Gets the locally executable factory which is responsible for instantiating <see cref="!:MailingListModel" /> objects.
        /// </summary>
        Consensus.Marketing.IMailingListFactory MailingList
        {
            get;
        }

        /// <summary>
        ///     Gets the locally executable factory which is responsible for instantiating <see cref="!:MailingListMemberModel" /> objects.
        /// </summary>
        Consensus.Marketing.IMailingListMemberFactory MailingListMember
        {
            get;
        }
    }
}
