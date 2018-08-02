using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Linq;

namespace Consensus.Marketing
{
    /// <summary>
    ///     The repository collection which pertains to the Marketing namespace.
    /// </summary>
    /// <remarks>
    ///     THIS CODE HAS BEEN AUTOMATICALLY GENERATED USING THE CONSENSUS DEVELOPER TOOLS.
    ///     DO NOT EDIT THIS CODE AS ANY CUSTOM MODIFICATIONS WILL BE LOST UPON REGENERATION.
    /// </remarks>
    public interface IMarketingRepositoryCollection : IRepositoryCollection
    {
        /// <summary>
        ///     Gets the Microsoft SQL Server repository which persists and retrieves instances of the <see cref="T:Consensus.Marketing.CampaignRecord" /> data structure.
        /// </summary>
        Consensus.Marketing.ICampaignRepository Campaign
        {
            get;
        }

        /// <summary>
        ///     Gets the Microsoft SQL Server repository which persists and retrieves instances of the <see cref="T:Consensus.Marketing.PromotionRecord" /> data structure.
        /// </summary>
        Consensus.Marketing.IPromotionRepository Promotion
        {
            get;
        }

        /// <summary>
        ///     Gets the Microsoft SQL Server repository which persists and retrieves instances of the <see cref="T:Consensus.Marketing.PromotionMasterRecord" /> data structure.
        /// </summary>
        Consensus.Marketing.IPromotionMasterRepository PromotionMaster
        {
            get;
        }

        /// <summary>
        ///     Gets the Microsoft SQL Server repository which persists and retrieves instances of the <see cref="T:Consensus.Marketing.SaqFilterRecord" /> data structure.
        /// </summary>
        Consensus.Marketing.ISaqFilterFieldRepository SaqFilterField
        {
            get;
        }

        /// <summary>
        ///     Gets the Microsoft SQL Server repository which persists and retrieves instances of the <see cref="T:Consensus.Marketing.SaqStepRecord" /> data structure.
        /// </summary>
        Consensus.Marketing.ISaqStepRepository SaqStep
        {
            get;
        }

        /// <summary>
        ///     Gets the Microsoft SQL Server repository which persists and retrieves instances of the <see cref="T:Consensus.Marketing.SaqStepParamsRecord" /> data structure.
        /// </summary>
        Consensus.Marketing.ISaqParameterRepository SaqParameter
        {
            get;
        }

        /// <summary>
        ///     Gets the Microsoft SQL Server repository which persists and retrieves instances of the <see cref="T:Consensus.Marketing.SaqQueryRecord" /> data structure.
        /// </summary>
        Consensus.Marketing.ISaqQueryRepository SaqQuery
        {
            get;
        }

        /// <summary>
        ///     Gets the Microsoft SQL Server repository which persists and retrieves instances of the <see cref="T:Consensus.Marketing.SaqQueryStepsRecord" /> data structure.
        /// </summary>
        Consensus.Marketing.ISaqQueryStepRepository SaqQueryStep
        {
            get;
        }

        /// <summary>
        ///     Gets the Microsoft SQL Server repository which persists and retrieves instances of the <see cref="T:Consensus.Marketing.SaqQueryQueueRecord" /> data structure.
        /// </summary>
        Consensus.Marketing.ISaqQueueRepository SaqQueue
        {
            get;
        }

        /// <summary>
        ///     Gets the Microsoft SQL Server repository which persists and retrieves instances of the <see cref="T:Consensus.Marketing.ListRecord" /> data structure.
        /// </summary>
        Consensus.Marketing.IMailingListRepository MailingList
        {
            get;
        }

        /// <summary>
        ///     Gets the Microsoft SQL Server repository which persists and retrieves instances of the <see cref="T:Consensus.Marketing.ListMemberRecord" /> data structure.
        /// </summary>
        Consensus.Marketing.IMailingListMemberRepository MailingListMember
        {
            get;
        }
    }
}
