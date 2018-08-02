using System;
using System.Collections.Generic;
using System.Data;
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
    ///     Provides the programmatic access to the locally-executable factory collections.
    /// </summary>
    /// <remarks>
    ///     THIS CODE HAS BEEN AUTOMATICALLY GENERATED USING THE CONSENSUS DEVELOPER TOOLS.
    ///     DO NOT EDIT THIS CODE AS ANY CUSTOM MODIFICATIONS WILL BE LOST UPON REGENERATION.
    /// </remarks>
    public partial class LocalProvider : ConsensusProvider, IBusinessProvider
    {
        #region fields

        /// <summary>
        ///     The data provider which exposes programmatic access to the repositories within the persistence mechanism.
        /// </summary>
        private IDataProvider _dataProvider;

        /// <summary>
        ///     The collection of locally-executable factories which pertain to the Contact namespace.
        /// </summary>
        private LocalContactFactoryCollection _contact;

        /// <summary>
        ///     The collection of locally-executable factories which pertain to the Learning namespace.
        /// </summary>
        private LocalLearningFactoryCollection _learning;

        /// <summary>
        ///     The collection of locally-executable factories which pertain to the Sales namespace.
        /// </summary>
        private LocalSalesFactoryCollection _sales;

        /// <summary>
        ///     The collection of locally-executable factories which pertain to the Document namespace.
        /// </summary>
        private LocalDocumentFactoryCollection _document;

        /// <summary>
        ///     The collection of locally-executable factories which pertain to the Finance namespace.
        /// </summary>
        private LocalFinanceFactoryCollection _finance;

        /// <summary>
        ///     The collection of locally-executable factories which pertain to the Common namespace.
        /// </summary>
        private LocalCommonFactoryCollection _common;

        /// <summary>
        ///     The collection of locally-executable factories which pertain to the Activities namespace.
        /// </summary>
        private LocalActivitiesFactoryCollection _activities;

        /// <summary>
        ///     The collection of locally-executable factories which pertain to the UserInterface namespace.
        /// </summary>
        private LocalUserInterfaceFactoryCollection _userInterface;

        /// <summary>
        ///     The collection of locally-executable factories which pertain to the Security namespace.
        /// </summary>
        private LocalSecurityFactoryCollection _security;

        /// <summary>
        ///     The collection of locally-executable factories which pertain to the Membership namespace.
        /// </summary>
        private LocalMembershipFactoryCollection _membership;

        /// <summary>
        ///     The collection of locally-executable factories which pertain to the Marketing namespace.
        /// </summary>
        private LocalMarketingFactoryCollection _marketing;

        /// <summary>
        ///     The collection of locally-executable factories which pertain to the Logistics namespace.
        /// </summary>
        private LocalLogisticsFactoryCollection _logistics;

        /// <summary>
        ///     The collection of locally-executable factories which pertain to the Search namespace.
        /// </summary>
        private LocalSearchFactoryCollection _search;

        /// <summary>
        ///     The collection of locally-executable factories which pertain to the Other namespace.
        /// </summary>
        private LocalOtherFactoryCollection _other;

        /// <summary>
        ///     The collection of locally-executable factories which pertain to the Portal namespace.
        /// </summary>
        private LocalPortalFactoryCollection _portal;

        /// <summary>
        ///     The collection of locally-executable factories which pertain to the Reporting namespace.
        /// </summary>
        private LocalReportingFactoryCollection _reporting;

        #endregion

        #region properties

        /// <summary>
        ///     Gets the data provider which exposes programmatic access to the repositories within the persistence mechanism.
        /// </summary>
        internal IDataProvider DataProvider
        {
            get
            {
                if (_dataProvider == null)
                    _dataProvider = this.Site.GetService<IDataProvider>();
                
                return _dataProvider;
            }
        }

        /// <summary>
        ///     Gets the collection of locally-executable factories which pertain to the Contact namespace.
        /// </summary>
        public LocalContactFactoryCollection Contact
        {
            get { return LocalFactoryCollection.Create(this, ref _contact); }
        }

        /// <summary>
        ///     Gets the collection of locally-executable factories which pertain to the Learning namespace.
        /// </summary>
        public LocalLearningFactoryCollection Learning
        {
            get { return LocalFactoryCollection.Create(this, ref _learning); }
        }

        /// <summary>
        ///     Gets the collection of locally-executable factories which pertain to the Sales namespace.
        /// </summary>
        public LocalSalesFactoryCollection Sales
        {
            get { return LocalFactoryCollection.Create(this, ref _sales); }
        }

        /// <summary>
        ///     Gets the collection of locally-executable factories which pertain to the Document namespace.
        /// </summary>
        public LocalDocumentFactoryCollection Document
        {
            get { return LocalFactoryCollection.Create(this, ref _document); }
        }

        /// <summary>
        ///     Gets the collection of locally-executable factories which pertain to the Finance namespace.
        /// </summary>
        public LocalFinanceFactoryCollection Finance
        {
            get { return LocalFactoryCollection.Create(this, ref _finance); }
        }

        /// <summary>
        ///     Gets the collection of locally-executable factories which pertain to the Common namespace.
        /// </summary>
        public LocalCommonFactoryCollection Common
        {
            get { return LocalFactoryCollection.Create(this, ref _common); }
        }

        /// <summary>
        ///     Gets the collection of locally-executable factories which pertain to the Activities namespace.
        /// </summary>
        public LocalActivitiesFactoryCollection Activities
        {
            get { return LocalFactoryCollection.Create(this, ref _activities); }
        }

        /// <summary>
        ///     Gets the collection of locally-executable factories which pertain to the UserInterface namespace.
        /// </summary>
        public LocalUserInterfaceFactoryCollection UserInterface
        {
            get { return LocalFactoryCollection.Create(this, ref _userInterface); }
        }

        /// <summary>
        ///     Gets the collection of locally-executable factories which pertain to the Security namespace.
        /// </summary>
        public LocalSecurityFactoryCollection Security
        {
            get { return LocalFactoryCollection.Create(this, ref _security); }
        }

        /// <summary>
        ///     Gets the collection of locally-executable factories which pertain to the Membership namespace.
        /// </summary>
        public LocalMembershipFactoryCollection Membership
        {
            get { return LocalFactoryCollection.Create(this, ref _membership); }
        }

        /// <summary>
        ///     Gets the collection of locally-executable factories which pertain to the Marketing namespace.
        /// </summary>
        public LocalMarketingFactoryCollection Marketing
        {
            get { return LocalFactoryCollection.Create(this, ref _marketing); }
        }

        /// <summary>
        ///     Gets the collection of locally-executable factories which pertain to the Logistics namespace.
        /// </summary>
        public LocalLogisticsFactoryCollection Logistics
        {
            get { return LocalFactoryCollection.Create(this, ref _logistics); }
        }

        /// <summary>
        ///     Gets the collection of locally-executable factories which pertain to the Search namespace.
        /// </summary>
        public LocalSearchFactoryCollection Search
        {
            get { return LocalFactoryCollection.Create(this, ref _search); }
        }

        /// <summary>
        ///     Gets the collection of locally-executable factories which pertain to the Other namespace.
        /// </summary>
        public LocalOtherFactoryCollection Other
        {
            get { return LocalFactoryCollection.Create(this, ref _other); }
        }

        /// <summary>
        ///     Gets the collection of locally-executable factories which pertain to the Portal namespace.
        /// </summary>
        public LocalPortalFactoryCollection Portal
        {
            get { return LocalFactoryCollection.Create(this, ref _portal); }
        }

        /// <summary>
        ///     Gets the collection of locally-executable factories which pertain to the Reporting namespace.
        /// </summary>
        public LocalReportingFactoryCollection Reporting
        {
            get { return LocalFactoryCollection.Create(this, ref _reporting); }
        }

        #endregion

        #region implementations

        /// <summary>
        ///     Gets the collection of locally-executable factories which pertain to the Searches namespace.
        /// </summary>
        Consensus.Searches.SearchesFactoryCollection IBusinessProvider.Searches
        {
            get { return this.Searches; }
        }

        /// <summary>
        ///     Gets the collection of locally-executable factories which pertain to the Contact namespace.
        /// </summary>
        Consensus.Contact.IContactFactoryCollection IBusinessProvider.Contact
        {
            get { return this.Contact; }
        }

        /// <summary>
        ///     Gets the collection of locally-executable factories which pertain to the Learning namespace.
        /// </summary>
        Consensus.Learning.ILearningFactoryCollection IBusinessProvider.Learning
        {
            get { return this.Learning; }
        }

        /// <summary>
        ///     Gets the collection of locally-executable factories which pertain to the Sales namespace.
        /// </summary>
        Consensus.Sales.ISalesFactoryCollection IBusinessProvider.Sales
        {
            get { return this.Sales; }
        }

        /// <summary>
        ///     Gets the collection of locally-executable factories which pertain to the Document namespace.
        /// </summary>
        Consensus.Document.IDocumentFactoryCollection IBusinessProvider.Document
        {
            get { return this.Document; }
        }

        /// <summary>
        ///     Gets the collection of locally-executable factories which pertain to the Finance namespace.
        /// </summary>
        Consensus.Finance.IFinanceFactoryCollection IBusinessProvider.Finance
        {
            get { return this.Finance; }
        }

        /// <summary>
        ///     Gets the collection of locally-executable factories which pertain to the Common namespace.
        /// </summary>
        Consensus.Common.ICommonFactoryCollection IBusinessProvider.Common
        {
            get { return this.Common; }
        }

        /// <summary>
        ///     Gets the collection of locally-executable factories which pertain to the Activities namespace.
        /// </summary>
        Consensus.Activities.IActivitiesFactoryCollection IBusinessProvider.Activities
        {
            get { return this.Activities; }
        }

        /// <summary>
        ///     Gets the collection of locally-executable factories which pertain to the UserInterface namespace.
        /// </summary>
        Consensus.UserInterface.IUserInterfaceFactoryCollection IBusinessProvider.UserInterface
        {
            get { return this.UserInterface; }
        }

        /// <summary>
        ///     Gets the collection of locally-executable factories which pertain to the Security namespace.
        /// </summary>
        Consensus.Security.ISecurityFactoryCollection IBusinessProvider.Security
        {
            get { return this.Security; }
        }

        /// <summary>
        ///     Gets the collection of locally-executable factories which pertain to the Membership namespace.
        /// </summary>
        Consensus.Membership.IMembershipFactoryCollection IBusinessProvider.Membership
        {
            get { return this.Membership; }
        }

        /// <summary>
        ///     Gets the collection of locally-executable factories which pertain to the Marketing namespace.
        /// </summary>
        Consensus.Marketing.IMarketingFactoryCollection IBusinessProvider.Marketing
        {
            get { return this.Marketing; }
        }

        /// <summary>
        ///     Gets the collection of locally-executable factories which pertain to the Logistics namespace.
        /// </summary>
        Consensus.Logistics.ILogisticsFactoryCollection IBusinessProvider.Logistics
        {
            get { return this.Logistics; }
        }

        /// <summary>
        ///     Gets the collection of locally-executable factories which pertain to the Search namespace.
        /// </summary>
        Consensus.Search.ISearchFactoryCollection IBusinessProvider.Search
        {
            get { return this.Search; }
        }

        /// <summary>
        ///     Gets the collection of locally-executable factories which pertain to the Other namespace.
        /// </summary>
        Consensus.Other.IOtherFactoryCollection IBusinessProvider.Other
        {
            get { return this.Other; }
        }

        /// <summary>
        ///     Gets the collection of locally-executable factories which pertain to the Portal namespace.
        /// </summary>
        Consensus.Portal.IPortalFactoryCollection IBusinessProvider.Portal
        {
            get { return this.Portal; }
        }

        /// <summary>
        ///     Gets the collection of locally-executable factories which pertain to the Reporting namespace.
        /// </summary>
        Consensus.Reporting.IReportingFactoryCollection IBusinessProvider.Reporting
        {
            get { return this.Reporting; }
        }

        #endregion
    }
}
