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
    ///     Supports the programmatic access to the repository collections.
    /// </summary>
    /// <remarks>
    ///     THIS CODE HAS BEEN AUTOMATICALLY GENERATED USING THE CONSENSUS DEVELOPER TOOLS.
    ///     DO NOT EDIT THIS CODE AS ANY CUSTOM MODIFICATIONS WILL BE LOST UPON REGENERATION.
    /// </remarks>
    public partial interface IDataProvider
    {
        #region properties

        /// <summary>
        ///     Gets the Microsoft SQL Server repository collection which pertains to the Contact namespace.
        /// </summary>
        Consensus.Contact.IContactRepositoryCollection Contact
        {
            get;
        }

        /// <summary>
        ///     Gets the Microsoft SQL Server repository collection which pertains to the Learning namespace.
        /// </summary>
        Consensus.Learning.ILearningRepositoryCollection Learning
        {
            get;
        }

        /// <summary>
        ///     Gets the Microsoft SQL Server repository collection which pertains to the Sales namespace.
        /// </summary>
        Consensus.Sales.ISalesRepositoryCollection Sales
        {
            get;
        }

        /// <summary>
        ///     Gets the Microsoft SQL Server repository collection which pertains to the Document namespace.
        /// </summary>
        Consensus.Document.IDocumentRepositoryCollection Document
        {
            get;
        }

        /// <summary>
        ///     Gets the Microsoft SQL Server repository collection which pertains to the Finance namespace.
        /// </summary>
        Consensus.Finance.IFinanceRepositoryCollection Finance
        {
            get;
        }

        /// <summary>
        ///     Gets the Microsoft SQL Server repository collection which pertains to the Common namespace.
        /// </summary>
        Consensus.Common.ICommonRepositoryCollection Common
        {
            get;
        }

        /// <summary>
        ///     Gets the Microsoft SQL Server repository collection which pertains to the Activities namespace.
        /// </summary>
        Consensus.Activities.IActivitiesRepositoryCollection Activities
        {
            get;
        }

        /// <summary>
        ///     Gets the Microsoft SQL Server repository collection which pertains to the UserInterface namespace.
        /// </summary>
        Consensus.UserInterface.IUserInterfaceRepositoryCollection UserInterface
        {
            get;
        }

        /// <summary>
        ///     Gets the Microsoft SQL Server repository collection which pertains to the Security namespace.
        /// </summary>
        Consensus.Security.ISecurityRepositoryCollection Security
        {
            get;
        }

        /// <summary>
        ///     Gets the Microsoft SQL Server repository collection which pertains to the Membership namespace.
        /// </summary>
        Consensus.Membership.IMembershipRepositoryCollection Membership
        {
            get;
        }

        /// <summary>
        ///     Gets the Microsoft SQL Server repository collection which pertains to the Marketing namespace.
        /// </summary>
        Consensus.Marketing.IMarketingRepositoryCollection Marketing
        {
            get;
        }

        /// <summary>
        ///     Gets the Microsoft SQL Server repository collection which pertains to the Logistics namespace.
        /// </summary>
        Consensus.Logistics.ILogisticsRepositoryCollection Logistics
        {
            get;
        }

        /// <summary>
        ///     Gets the Microsoft SQL Server repository collection which pertains to the Search namespace.
        /// </summary>
        Consensus.Search.ISearchRepositoryCollection Search
        {
            get;
        }

        /// <summary>
        ///     Gets the Microsoft SQL Server repository collection which pertains to the Other namespace.
        /// </summary>
        Consensus.Other.IOtherRepositoryCollection Other
        {
            get;
        }

        /// <summary>
        ///     Gets the Microsoft SQL Server repository collection which pertains to the Portal namespace.
        /// </summary>
        Consensus.Portal.IPortalRepositoryCollection Portal
        {
            get;
        }

        /// <summary>
        ///     Gets the Microsoft SQL Server repository collection which pertains to the Reporting namespace.
        /// </summary>
        Consensus.Reporting.IReportingRepositoryCollection Reporting
        {
            get;
        }

        #endregion

        #region methods

        System.Collections.Generic.Dictionary<System.String, System.Object>[] ExecuteQuery(System.String query);

        System.Collections.Generic.Dictionary<System.String, System.Object>[] ExecuteQuery(System.String query, System.Collections.Generic.Dictionary<System.String, System.Object> parameters);

        System.Collections.Generic.Dictionary<System.String, System.Object>[] ExecuteProcedure(System.String procedureName, System.Collections.Generic.Dictionary<System.String, System.Object> parameters);

        #endregion
    }
}
