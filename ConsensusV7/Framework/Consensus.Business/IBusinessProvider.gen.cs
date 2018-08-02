using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Linq;
using Consensus.Activities;
using Consensus.Common;
using Consensus.Contact;
using Consensus.Document;
using Consensus.Finance;
using Consensus.Learning;
using Consensus.Logistics;
using Consensus.Marketing;
using Consensus.Membership;
using Consensus.Other;
using Consensus.Portal;
using Consensus.Reporting;
using Consensus.Sales;
using Consensus.Search;
using Consensus.Security;
using Consensus.UserInterface;

namespace Consensus
{
    /// <summary>
    ///     Supports the programmatic access to the factory collections.
    /// </summary>
    /// <remarks>
    ///     THIS CODE HAS BEEN AUTOMATICALLY GENERATED USING THE CONSENSUS DEVELOPER TOOLS.
    ///     DO NOT EDIT THIS CODE AS ANY CUSTOM MODIFICATIONS WILL BE LOST UPON REGENERATION.
    /// </remarks>
    public partial interface IBusinessProvider
    {
        /// <summary>
        ///     Gets the collection of locally-executable factories which pertain to the Searches namespace.
        /// </summary>
        Consensus.Searches.SearchesFactoryCollection Searches
        {
            get;
        }

        /// <summary>
        ///     Gets the collection of locally-executable factories which pertain to the Contact namespace.
        /// </summary>
        Consensus.Contact.IContactFactoryCollection Contact
        {
            get;
        }

        /// <summary>
        ///     Gets the collection of locally-executable factories which pertain to the Learning namespace.
        /// </summary>
        Consensus.Learning.ILearningFactoryCollection Learning
        {
            get;
        }

        /// <summary>
        ///     Gets the collection of locally-executable factories which pertain to the Sales namespace.
        /// </summary>
        Consensus.Sales.ISalesFactoryCollection Sales
        {
            get;
        }

        /// <summary>
        ///     Gets the collection of locally-executable factories which pertain to the Document namespace.
        /// </summary>
        Consensus.Document.IDocumentFactoryCollection Document
        {
            get;
        }

        /// <summary>
        ///     Gets the collection of locally-executable factories which pertain to the Finance namespace.
        /// </summary>
        Consensus.Finance.IFinanceFactoryCollection Finance
        {
            get;
        }

        /// <summary>
        ///     Gets the collection of locally-executable factories which pertain to the Common namespace.
        /// </summary>
        Consensus.Common.ICommonFactoryCollection Common
        {
            get;
        }

        /// <summary>
        ///     Gets the collection of locally-executable factories which pertain to the Activities namespace.
        /// </summary>
        Consensus.Activities.IActivitiesFactoryCollection Activities
        {
            get;
        }

        /// <summary>
        ///     Gets the collection of locally-executable factories which pertain to the UserInterface namespace.
        /// </summary>
        Consensus.UserInterface.IUserInterfaceFactoryCollection UserInterface
        {
            get;
        }

        /// <summary>
        ///     Gets the collection of locally-executable factories which pertain to the Security namespace.
        /// </summary>
        Consensus.Security.ISecurityFactoryCollection Security
        {
            get;
        }

        /// <summary>
        ///     Gets the collection of locally-executable factories which pertain to the Membership namespace.
        /// </summary>
        Consensus.Membership.IMembershipFactoryCollection Membership
        {
            get;
        }

        /// <summary>
        ///     Gets the collection of locally-executable factories which pertain to the Marketing namespace.
        /// </summary>
        Consensus.Marketing.IMarketingFactoryCollection Marketing
        {
            get;
        }

        /// <summary>
        ///     Gets the collection of locally-executable factories which pertain to the Logistics namespace.
        /// </summary>
        Consensus.Logistics.ILogisticsFactoryCollection Logistics
        {
            get;
        }

        /// <summary>
        ///     Gets the collection of locally-executable factories which pertain to the Search namespace.
        /// </summary>
        Consensus.Search.ISearchFactoryCollection Search
        {
            get;
        }

        /// <summary>
        ///     Gets the collection of locally-executable factories which pertain to the Other namespace.
        /// </summary>
        Consensus.Other.IOtherFactoryCollection Other
        {
            get;
        }

        /// <summary>
        ///     Gets the collection of locally-executable factories which pertain to the Portal namespace.
        /// </summary>
        Consensus.Portal.IPortalFactoryCollection Portal
        {
            get;
        }

        /// <summary>
        ///     Gets the collection of locally-executable factories which pertain to the Reporting namespace.
        /// </summary>
        Consensus.Reporting.IReportingFactoryCollection Reporting
        {
            get;
        }
    }
}
