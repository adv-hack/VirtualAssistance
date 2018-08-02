using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Linq;

namespace Consensus.Marketing
{
    /// <summary>
    ///     Microsoft SQL Server repository collection which pertains to the Marketing namespace.
    /// </summary>
    /// <remarks>
    ///     THIS CODE HAS BEEN AUTOMATICALLY GENERATED USING THE CONSENSUS DEVELOPER TOOLS.
    ///     DO NOT EDIT THIS CODE AS ANY CUSTOM MODIFICATIONS WILL BE LOST UPON REGENERATION.
    /// </remarks>
    public partial class SqlServerMarketingRepositoryCollection : SqlServerRepositoryCollection, IMarketingRepositoryCollection
    {
        #region fields

        /// <summary>
        ///     The Microsoft SQL Server repository which persists and retrieves instances of the <see cref="CampaignRecord" /> data structure.
        /// </summary>
        private SqlServerCampaignRepository _campaign;

        /// <summary>
        ///     The Microsoft SQL Server repository which persists and retrieves instances of the <see cref="PromotionRecord" /> data structure.
        /// </summary>
        private SqlServerPromotionRepository _promotion;

        /// <summary>
        ///     The Microsoft SQL Server repository which persists and retrieves instances of the <see cref="PromotionMasterRecord" /> data structure.
        /// </summary>
        private SqlServerPromotionMasterRepository _promotionMaster;

        /// <summary>
        ///     The Microsoft SQL Server repository which persists and retrieves instances of the <see cref="SaqFilterRecord" /> data structure.
        /// </summary>
        private SqlServerSaqFilterFieldRepository _saqFilterField;

        /// <summary>
        ///     The Microsoft SQL Server repository which persists and retrieves instances of the <see cref="SaqStepRecord" /> data structure.
        /// </summary>
        private SqlServerSaqStepRepository _saqStep;

        /// <summary>
        ///     The Microsoft SQL Server repository which persists and retrieves instances of the <see cref="SaqStepParamsRecord" /> data structure.
        /// </summary>
        private SqlServerSaqParameterRepository _saqParameter;

        /// <summary>
        ///     The Microsoft SQL Server repository which persists and retrieves instances of the <see cref="SaqQueryRecord" /> data structure.
        /// </summary>
        private SqlServerSaqQueryRepository _saqQuery;

        /// <summary>
        ///     The Microsoft SQL Server repository which persists and retrieves instances of the <see cref="SaqQueryStepsRecord" /> data structure.
        /// </summary>
        private SqlServerSaqQueryStepRepository _saqQueryStep;

        /// <summary>
        ///     The Microsoft SQL Server repository which persists and retrieves instances of the <see cref="SaqQueryQueueRecord" /> data structure.
        /// </summary>
        private SqlServerSaqQueueRepository _saqQueue;

        /// <summary>
        ///     The Microsoft SQL Server repository which persists and retrieves instances of the <see cref="ListRecord" /> data structure.
        /// </summary>
        private SqlServerMailingListRepository _mailingList;

        /// <summary>
        ///     The Microsoft SQL Server repository which persists and retrieves instances of the <see cref="ListMemberRecord" /> data structure.
        /// </summary>
        private SqlServerMailingListMemberRepository _mailingListMember;

        #endregion

        #region properties

        /// <summary>
        ///     Gets the Microsoft SQL Server repository which persists and retrieves instances of the <see cref="CampaignRecord" /> data structure.
        /// </summary>
        public SqlServerCampaignRepository Campaign
        {
            get
            {
                SqlServerProvider provider = this.Provider;
                OverrideProvider(typeof(SqlServerCampaignRepository), ref provider);
                return SqlServerRepository.Create(provider, ref _campaign);
            }
        }

        /// <summary>
        ///     Gets the Microsoft SQL Server repository which persists and retrieves instances of the <see cref="PromotionRecord" /> data structure.
        /// </summary>
        public SqlServerPromotionRepository Promotion
        {
            get
            {
                SqlServerProvider provider = this.Provider;
                OverrideProvider(typeof(SqlServerPromotionRepository), ref provider);
                return SqlServerRepository.Create(provider, ref _promotion);
            }
        }

        /// <summary>
        ///     Gets the Microsoft SQL Server repository which persists and retrieves instances of the <see cref="PromotionMasterRecord" /> data structure.
        /// </summary>
        public SqlServerPromotionMasterRepository PromotionMaster
        {
            get
            {
                SqlServerProvider provider = this.Provider;
                OverrideProvider(typeof(SqlServerPromotionMasterRepository), ref provider);
                return SqlServerRepository.Create(provider, ref _promotionMaster);
            }
        }

        /// <summary>
        ///     Gets the Microsoft SQL Server repository which persists and retrieves instances of the <see cref="SaqFilterRecord" /> data structure.
        /// </summary>
        public SqlServerSaqFilterFieldRepository SaqFilterField
        {
            get
            {
                SqlServerProvider provider = this.Provider;
                OverrideProvider(typeof(SqlServerSaqFilterFieldRepository), ref provider);
                return SqlServerRepository.Create(provider, ref _saqFilterField);
            }
        }

        /// <summary>
        ///     Gets the Microsoft SQL Server repository which persists and retrieves instances of the <see cref="SaqStepRecord" /> data structure.
        /// </summary>
        public SqlServerSaqStepRepository SaqStep
        {
            get
            {
                SqlServerProvider provider = this.Provider;
                OverrideProvider(typeof(SqlServerSaqStepRepository), ref provider);
                return SqlServerRepository.Create(provider, ref _saqStep);
            }
        }

        /// <summary>
        ///     Gets the Microsoft SQL Server repository which persists and retrieves instances of the <see cref="SaqStepParamsRecord" /> data structure.
        /// </summary>
        public SqlServerSaqParameterRepository SaqParameter
        {
            get
            {
                SqlServerProvider provider = this.Provider;
                OverrideProvider(typeof(SqlServerSaqParameterRepository), ref provider);
                return SqlServerRepository.Create(provider, ref _saqParameter);
            }
        }

        /// <summary>
        ///     Gets the Microsoft SQL Server repository which persists and retrieves instances of the <see cref="SaqQueryRecord" /> data structure.
        /// </summary>
        public SqlServerSaqQueryRepository SaqQuery
        {
            get
            {
                SqlServerProvider provider = this.Provider;
                OverrideProvider(typeof(SqlServerSaqQueryRepository), ref provider);
                return SqlServerRepository.Create(provider, ref _saqQuery);
            }
        }

        /// <summary>
        ///     Gets the Microsoft SQL Server repository which persists and retrieves instances of the <see cref="SaqQueryStepsRecord" /> data structure.
        /// </summary>
        public SqlServerSaqQueryStepRepository SaqQueryStep
        {
            get
            {
                SqlServerProvider provider = this.Provider;
                OverrideProvider(typeof(SqlServerSaqQueryStepRepository), ref provider);
                return SqlServerRepository.Create(provider, ref _saqQueryStep);
            }
        }

        /// <summary>
        ///     Gets the Microsoft SQL Server repository which persists and retrieves instances of the <see cref="SaqQueryQueueRecord" /> data structure.
        /// </summary>
        public SqlServerSaqQueueRepository SaqQueue
        {
            get
            {
                SqlServerProvider provider = this.Provider;
                OverrideProvider(typeof(SqlServerSaqQueueRepository), ref provider);
                return SqlServerRepository.Create(provider, ref _saqQueue);
            }
        }

        /// <summary>
        ///     Gets the Microsoft SQL Server repository which persists and retrieves instances of the <see cref="ListRecord" /> data structure.
        /// </summary>
        public SqlServerMailingListRepository MailingList
        {
            get
            {
                SqlServerProvider provider = this.Provider;
                OverrideProvider(typeof(SqlServerMailingListRepository), ref provider);
                return SqlServerRepository.Create(provider, ref _mailingList);
            }
        }

        /// <summary>
        ///     Gets the Microsoft SQL Server repository which persists and retrieves instances of the <see cref="ListMemberRecord" /> data structure.
        /// </summary>
        public SqlServerMailingListMemberRepository MailingListMember
        {
            get
            {
                SqlServerProvider provider = this.Provider;
                OverrideProvider(typeof(SqlServerMailingListMemberRepository), ref provider);
                return SqlServerRepository.Create(provider, ref _mailingListMember);
            }
        }

        #endregion

        #region methods

        /// <summary>
        ///     Partial method that can be implemented elsewhere in the partial class to allow the provider to be amended for a particular instance.
        /// </summary>
        /// <param name="SqlServerDataRepositoryType">
        ///     The type of the SqlServerDataRepository instance being created.
        /// </param>
        /// <param name="provider">
        ///     The default provider. A new provider may be assigned to this parameter in an implementation, if required.
        /// </param>
        partial void OverrideProvider(Type SqlServerDataRepositoryType, ref SqlServerProvider provider);

        #endregion

        #region implementations

        /// <summary>
        ///     Gets the Microsoft SQL Server repository which persists and retrieves instances of the <see cref="T:Consensus.Marketing.CampaignRecord" /> data structure.
        /// </summary>
        Consensus.Marketing.ICampaignRepository IMarketingRepositoryCollection.Campaign
        {
            get { return this.Campaign; }
        }

        /// <summary>
        ///     Gets the Microsoft SQL Server repository which persists and retrieves instances of the <see cref="T:Consensus.Marketing.PromotionRecord" /> data structure.
        /// </summary>
        Consensus.Marketing.IPromotionRepository IMarketingRepositoryCollection.Promotion
        {
            get { return this.Promotion; }
        }

        /// <summary>
        ///     Gets the Microsoft SQL Server repository which persists and retrieves instances of the <see cref="T:Consensus.Marketing.PromotionMasterRecord" /> data structure.
        /// </summary>
        Consensus.Marketing.IPromotionMasterRepository IMarketingRepositoryCollection.PromotionMaster
        {
            get { return this.PromotionMaster; }
        }

        /// <summary>
        ///     Gets the Microsoft SQL Server repository which persists and retrieves instances of the <see cref="T:Consensus.Marketing.SaqFilterRecord" /> data structure.
        /// </summary>
        Consensus.Marketing.ISaqFilterFieldRepository IMarketingRepositoryCollection.SaqFilterField
        {
            get { return this.SaqFilterField; }
        }

        /// <summary>
        ///     Gets the Microsoft SQL Server repository which persists and retrieves instances of the <see cref="T:Consensus.Marketing.SaqStepRecord" /> data structure.
        /// </summary>
        Consensus.Marketing.ISaqStepRepository IMarketingRepositoryCollection.SaqStep
        {
            get { return this.SaqStep; }
        }

        /// <summary>
        ///     Gets the Microsoft SQL Server repository which persists and retrieves instances of the <see cref="T:Consensus.Marketing.SaqStepParamsRecord" /> data structure.
        /// </summary>
        Consensus.Marketing.ISaqParameterRepository IMarketingRepositoryCollection.SaqParameter
        {
            get { return this.SaqParameter; }
        }

        /// <summary>
        ///     Gets the Microsoft SQL Server repository which persists and retrieves instances of the <see cref="T:Consensus.Marketing.SaqQueryRecord" /> data structure.
        /// </summary>
        Consensus.Marketing.ISaqQueryRepository IMarketingRepositoryCollection.SaqQuery
        {
            get { return this.SaqQuery; }
        }

        /// <summary>
        ///     Gets the Microsoft SQL Server repository which persists and retrieves instances of the <see cref="T:Consensus.Marketing.SaqQueryStepsRecord" /> data structure.
        /// </summary>
        Consensus.Marketing.ISaqQueryStepRepository IMarketingRepositoryCollection.SaqQueryStep
        {
            get { return this.SaqQueryStep; }
        }

        /// <summary>
        ///     Gets the Microsoft SQL Server repository which persists and retrieves instances of the <see cref="T:Consensus.Marketing.SaqQueryQueueRecord" /> data structure.
        /// </summary>
        Consensus.Marketing.ISaqQueueRepository IMarketingRepositoryCollection.SaqQueue
        {
            get { return this.SaqQueue; }
        }

        /// <summary>
        ///     Gets the Microsoft SQL Server repository which persists and retrieves instances of the <see cref="T:Consensus.Marketing.ListRecord" /> data structure.
        /// </summary>
        Consensus.Marketing.IMailingListRepository IMarketingRepositoryCollection.MailingList
        {
            get { return this.MailingList; }
        }

        /// <summary>
        ///     Gets the Microsoft SQL Server repository which persists and retrieves instances of the <see cref="T:Consensus.Marketing.ListMemberRecord" /> data structure.
        /// </summary>
        Consensus.Marketing.IMailingListMemberRepository IMarketingRepositoryCollection.MailingListMember
        {
            get { return this.MailingListMember; }
        }

        #endregion
    }
}
