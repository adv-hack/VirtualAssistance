using System;
using System.Collections.Generic;
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
    public partial class LocalMarketingFactoryCollection : LocalFactoryCollection, IMarketingFactoryCollection
    {
        #region fields

        /// <summary>
        ///     The locally executable factory which is responsible for instantiating <see cref="CampaignModel" /> objects.
        /// </summary>
        private LocalCampaignFactory _campaign;

        /// <summary>
        ///     The locally executable factory which is responsible for instantiating <see cref="PromotionModel" /> objects.
        /// </summary>
        private LocalPromotionFactory _promotion;

        /// <summary>
        ///     The locally executable factory which is responsible for instantiating <see cref="PromotionMasterModel" /> objects.
        /// </summary>
        private LocalPromotionMasterFactory _promotionMaster;

        /// <summary>
        ///     The locally executable factory which is responsible for instantiating <see cref="SaqFilterFieldModel" /> objects.
        /// </summary>
        private LocalSaqFilterFieldFactory _saqFilterField;

        /// <summary>
        ///     The locally executable factory which is responsible for instantiating <see cref="SaqStepModel" /> objects.
        /// </summary>
        private LocalSaqStepFactory _saqStep;

        /// <summary>
        ///     The locally executable factory which is responsible for instantiating <see cref="SaqParameterModel" /> objects.
        /// </summary>
        private LocalSaqParameterFactory _saqParameter;

        /// <summary>
        ///     The locally executable factory which is responsible for instantiating <see cref="SaqQueryModel" /> objects.
        /// </summary>
        private LocalSaqQueryFactory _saqQuery;

        /// <summary>
        ///     The locally executable factory which is responsible for instantiating <see cref="SaqQueryStepModel" /> objects.
        /// </summary>
        private LocalSaqQueryStepFactory _saqQueryStep;

        /// <summary>
        ///     The locally executable factory which is responsible for instantiating <see cref="SaqQueueModel" /> objects.
        /// </summary>
        private LocalSaqQueueFactory _saqQueue;

        /// <summary>
        ///     The locally executable factory which is responsible for instantiating <see cref="MailingListModel" /> objects.
        /// </summary>
        private LocalMailingListFactory _mailingList;

        /// <summary>
        ///     The locally executable factory which is responsible for instantiating <see cref="MailingListMemberModel" /> objects.
        /// </summary>
        private LocalMailingListMemberFactory _mailingListMember;

        #endregion

        #region properties

        /// <summary>
        ///     Gets the locally executable factory which is responsible for instantiating <see cref="CampaignModel" /> objects.
        /// </summary>
        public LocalCampaignFactory Campaign
        {
            get { return LocalFactory.Create(this.Provider, ref _campaign); }
        }

        /// <summary>
        ///     Gets the locally executable factory which is responsible for instantiating <see cref="PromotionModel" /> objects.
        /// </summary>
        public LocalPromotionFactory Promotion
        {
            get { return LocalFactory.Create(this.Provider, ref _promotion); }
        }

        /// <summary>
        ///     Gets the locally executable factory which is responsible for instantiating <see cref="PromotionMasterModel" /> objects.
        /// </summary>
        public LocalPromotionMasterFactory PromotionMaster
        {
            get { return LocalFactory.Create(this.Provider, ref _promotionMaster); }
        }

        /// <summary>
        ///     Gets the locally executable factory which is responsible for instantiating <see cref="SaqFilterFieldModel" /> objects.
        /// </summary>
        public LocalSaqFilterFieldFactory SaqFilterField
        {
            get { return LocalFactory.Create(this.Provider, ref _saqFilterField); }
        }

        /// <summary>
        ///     Gets the locally executable factory which is responsible for instantiating <see cref="SaqStepModel" /> objects.
        /// </summary>
        public LocalSaqStepFactory SaqStep
        {
            get { return LocalFactory.Create(this.Provider, ref _saqStep); }
        }

        /// <summary>
        ///     Gets the locally executable factory which is responsible for instantiating <see cref="SaqParameterModel" /> objects.
        /// </summary>
        public LocalSaqParameterFactory SaqParameter
        {
            get { return LocalFactory.Create(this.Provider, ref _saqParameter); }
        }

        /// <summary>
        ///     Gets the locally executable factory which is responsible for instantiating <see cref="SaqQueryModel" /> objects.
        /// </summary>
        public LocalSaqQueryFactory SaqQuery
        {
            get { return LocalFactory.Create(this.Provider, ref _saqQuery); }
        }

        /// <summary>
        ///     Gets the locally executable factory which is responsible for instantiating <see cref="SaqQueryStepModel" /> objects.
        /// </summary>
        public LocalSaqQueryStepFactory SaqQueryStep
        {
            get { return LocalFactory.Create(this.Provider, ref _saqQueryStep); }
        }

        /// <summary>
        ///     Gets the locally executable factory which is responsible for instantiating <see cref="SaqQueueModel" /> objects.
        /// </summary>
        public LocalSaqQueueFactory SaqQueue
        {
            get { return LocalFactory.Create(this.Provider, ref _saqQueue); }
        }

        /// <summary>
        ///     Gets the locally executable factory which is responsible for instantiating <see cref="MailingListModel" /> objects.
        /// </summary>
        public LocalMailingListFactory MailingList
        {
            get { return LocalFactory.Create(this.Provider, ref _mailingList); }
        }

        /// <summary>
        ///     Gets the locally executable factory which is responsible for instantiating <see cref="MailingListMemberModel" /> objects.
        /// </summary>
        public LocalMailingListMemberFactory MailingListMember
        {
            get { return LocalFactory.Create(this.Provider, ref _mailingListMember); }
        }

        #endregion

        #region implementations

        /// <summary>
        ///     Gets the locally executable factory which is responsible for instantiating <see cref="!:CampaignModel" /> objects.
        /// </summary>
        Consensus.Marketing.ICampaignFactory IMarketingFactoryCollection.Campaign
        {
            get { return this.Campaign; }
        }

        /// <summary>
        ///     Gets the locally executable factory which is responsible for instantiating <see cref="!:PromotionModel" /> objects.
        /// </summary>
        Consensus.Marketing.IPromotionFactory IMarketingFactoryCollection.Promotion
        {
            get { return this.Promotion; }
        }

        /// <summary>
        ///     Gets the locally executable factory which is responsible for instantiating <see cref="!:PromotionMasterModel" /> objects.
        /// </summary>
        Consensus.Marketing.IPromotionMasterFactory IMarketingFactoryCollection.PromotionMaster
        {
            get { return this.PromotionMaster; }
        }

        /// <summary>
        ///     Gets the locally executable factory which is responsible for instantiating <see cref="!:SaqFilterFieldModel" /> objects.
        /// </summary>
        Consensus.Marketing.ISaqFilterFieldFactory IMarketingFactoryCollection.SaqFilterField
        {
            get { return this.SaqFilterField; }
        }

        /// <summary>
        ///     Gets the locally executable factory which is responsible for instantiating <see cref="!:SaqStepModel" /> objects.
        /// </summary>
        Consensus.Marketing.ISaqStepFactory IMarketingFactoryCollection.SaqStep
        {
            get { return this.SaqStep; }
        }

        /// <summary>
        ///     Gets the locally executable factory which is responsible for instantiating <see cref="!:SaqParameterModel" /> objects.
        /// </summary>
        Consensus.Marketing.ISaqParameterFactory IMarketingFactoryCollection.SaqParameter
        {
            get { return this.SaqParameter; }
        }

        /// <summary>
        ///     Gets the locally executable factory which is responsible for instantiating <see cref="!:SaqQueryModel" /> objects.
        /// </summary>
        Consensus.Marketing.ISaqQueryFactory IMarketingFactoryCollection.SaqQuery
        {
            get { return this.SaqQuery; }
        }

        /// <summary>
        ///     Gets the locally executable factory which is responsible for instantiating <see cref="!:SaqQueryStepModel" /> objects.
        /// </summary>
        Consensus.Marketing.ISaqQueryStepFactory IMarketingFactoryCollection.SaqQueryStep
        {
            get { return this.SaqQueryStep; }
        }

        /// <summary>
        ///     Gets the locally executable factory which is responsible for instantiating <see cref="!:SaqQueueModel" /> objects.
        /// </summary>
        Consensus.Marketing.ISaqQueueFactory IMarketingFactoryCollection.SaqQueue
        {
            get { return this.SaqQueue; }
        }

        /// <summary>
        ///     Gets the locally executable factory which is responsible for instantiating <see cref="!:MailingListModel" /> objects.
        /// </summary>
        Consensus.Marketing.IMailingListFactory IMarketingFactoryCollection.MailingList
        {
            get { return this.MailingList; }
        }

        /// <summary>
        ///     Gets the locally executable factory which is responsible for instantiating <see cref="!:MailingListMemberModel" /> objects.
        /// </summary>
        Consensus.Marketing.IMailingListMemberFactory IMarketingFactoryCollection.MailingListMember
        {
            get { return this.MailingListMember; }
        }

        #endregion
    }
}
