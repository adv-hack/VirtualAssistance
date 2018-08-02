using Microsoft.Practices.EnterpriseLibrary.Data.Sql;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
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
    ///     Provides the programmatic access to the repository collections for Microsoft SQL Server data access.
    /// </summary>
    /// <remarks>
    ///     THIS CODE HAS BEEN AUTOMATICALLY GENERATED USING THE CONSENSUS DEVELOPER TOOLS.
    ///     DO NOT EDIT THIS CODE AS ANY CUSTOM MODIFICATIONS WILL BE LOST UPON REGENERATION.
    /// </remarks>
    public partial class SqlServerProvider : ConsensusProvider, IDataProvider
    {
        #region fields

        /// <summary>
        ///     The connection to the Microsoft SQL Server database.
        /// </summary>
        private SqlDatabase _database;

        /// <summary>
        ///     The cached collection of stored procedure parameters.
        /// </summary>
        private Dictionary<String, IDataParameter[]> _cache;

        /// <summary>
        ///     The connection string builder which constructs the connection parameters for the Microsoft SQL Server database.
        /// </summary>
        private SqlConnectionStringBuilder _connectionBuilder;

        /// <summary>
        ///     The name of the connection string field in the service definition in web.config.
        /// </summary>
        private string _connectionStringField = "connection";

        /// <summary>
        ///     The Microsoft SQL Server repository collection which pertains to the Contact namespace.
        /// </summary>
        private SqlServerContactRepositoryCollection _contact;

        /// <summary>
        ///     The Microsoft SQL Server repository collection which pertains to the Learning namespace.
        /// </summary>
        private SqlServerLearningRepositoryCollection _learning;

        /// <summary>
        ///     The Microsoft SQL Server repository collection which pertains to the Sales namespace.
        /// </summary>
        private SqlServerSalesRepositoryCollection _sales;

        /// <summary>
        ///     The Microsoft SQL Server repository collection which pertains to the Document namespace.
        /// </summary>
        private SqlServerDocumentRepositoryCollection _document;

        /// <summary>
        ///     The Microsoft SQL Server repository collection which pertains to the Finance namespace.
        /// </summary>
        private SqlServerFinanceRepositoryCollection _finance;

        /// <summary>
        ///     The Microsoft SQL Server repository collection which pertains to the Common namespace.
        /// </summary>
        private SqlServerCommonRepositoryCollection _common;

        /// <summary>
        ///     The Microsoft SQL Server repository collection which pertains to the Activities namespace.
        /// </summary>
        private SqlServerActivitiesRepositoryCollection _activities;

        /// <summary>
        ///     The Microsoft SQL Server repository collection which pertains to the UserInterface namespace.
        /// </summary>
        private SqlServerUserInterfaceRepositoryCollection _userInterface;

        /// <summary>
        ///     The Microsoft SQL Server repository collection which pertains to the Security namespace.
        /// </summary>
        private SqlServerSecurityRepositoryCollection _security;

        /// <summary>
        ///     The Microsoft SQL Server repository collection which pertains to the Membership namespace.
        /// </summary>
        private SqlServerMembershipRepositoryCollection _membership;

        /// <summary>
        ///     The Microsoft SQL Server repository collection which pertains to the Marketing namespace.
        /// </summary>
        private SqlServerMarketingRepositoryCollection _marketing;

        /// <summary>
        ///     The Microsoft SQL Server repository collection which pertains to the Logistics namespace.
        /// </summary>
        private SqlServerLogisticsRepositoryCollection _logistics;

        /// <summary>
        ///     The Microsoft SQL Server repository collection which pertains to the Search namespace.
        /// </summary>
        private SqlServerSearchRepositoryCollection _search;

        /// <summary>
        ///     The Microsoft SQL Server repository collection which pertains to the Other namespace.
        /// </summary>
        private SqlServerOtherRepositoryCollection _other;

        /// <summary>
        ///     The Microsoft SQL Server repository collection which pertains to the Portal namespace.
        /// </summary>
        private SqlServerPortalRepositoryCollection _portal;

        /// <summary>
        ///     The Microsoft SQL Server repository collection which pertains to the Reporting namespace.
        /// </summary>
        private SqlServerReportingRepositoryCollection _reporting;

        #endregion

        #region properties

        /// <summary>
        ///     Gets the connection to the Microsoft SQL Server database.
        /// </summary>
        internal SqlDatabase Database
        {
            get
            {
                if (_database == null)
                    _database = new SqlDatabase(this.ConnectionString);
                return _database;
            }
        }

        /// <summary>
        ///     Gets the cached collection of stored procedure parameters.
        /// </summary>
        internal Dictionary<String, IDataParameter[]> Cache
        {
            get
            {
                if (_cache == null)
                    _cache = new Dictionary<String, IDataParameter[]>();
                return _cache;
            }
        }

        /// <summary>
        ///     Gets the connection string which defines the connection parameters for the Microsoft SQL Server database.
        /// </summary>
        internal String ConnectionString
        {
            get
            {
                if (_connectionBuilder == null)
                    _connectionBuilder = new SqlConnectionStringBuilder(base[_connectionStringField]);
                return _connectionBuilder.ConnectionString;
            }
        }

        /// <summary>
        ///     The name of the connection string field in the service definition in web.config.
        /// </summary>
        internal String ConnectionStringField
        {
            get { return _connectionStringField; }
            set { _connectionStringField = value; }
        }

        /// <summary>
        ///     Gets the Microsoft SQL Server repository collection which pertains to the Contact namespace.
        /// </summary>
        public SqlServerContactRepositoryCollection Contact
        {
            get { return SqlServerRepositoryCollection.Create(this, ref _contact); }
        }

        /// <summary>
        ///     Gets the Microsoft SQL Server repository collection which pertains to the Learning namespace.
        /// </summary>
        public SqlServerLearningRepositoryCollection Learning
        {
            get { return SqlServerRepositoryCollection.Create(this, ref _learning); }
        }

        /// <summary>
        ///     Gets the Microsoft SQL Server repository collection which pertains to the Sales namespace.
        /// </summary>
        public SqlServerSalesRepositoryCollection Sales
        {
            get { return SqlServerRepositoryCollection.Create(this, ref _sales); }
        }

        /// <summary>
        ///     Gets the Microsoft SQL Server repository collection which pertains to the Document namespace.
        /// </summary>
        public SqlServerDocumentRepositoryCollection Document
        {
            get { return SqlServerRepositoryCollection.Create(this, ref _document); }
        }

        /// <summary>
        ///     Gets the Microsoft SQL Server repository collection which pertains to the Finance namespace.
        /// </summary>
        public SqlServerFinanceRepositoryCollection Finance
        {
            get { return SqlServerRepositoryCollection.Create(this, ref _finance); }
        }

        /// <summary>
        ///     Gets the Microsoft SQL Server repository collection which pertains to the Common namespace.
        /// </summary>
        public SqlServerCommonRepositoryCollection Common
        {
            get { return SqlServerRepositoryCollection.Create(this, ref _common); }
        }

        /// <summary>
        ///     Gets the Microsoft SQL Server repository collection which pertains to the Activities namespace.
        /// </summary>
        public SqlServerActivitiesRepositoryCollection Activities
        {
            get { return SqlServerRepositoryCollection.Create(this, ref _activities); }
        }

        /// <summary>
        ///     Gets the Microsoft SQL Server repository collection which pertains to the UserInterface namespace.
        /// </summary>
        public SqlServerUserInterfaceRepositoryCollection UserInterface
        {
            get { return SqlServerRepositoryCollection.Create(this, ref _userInterface); }
        }

        /// <summary>
        ///     Gets the Microsoft SQL Server repository collection which pertains to the Security namespace.
        /// </summary>
        public SqlServerSecurityRepositoryCollection Security
        {
            get { return SqlServerRepositoryCollection.Create(this, ref _security); }
        }

        /// <summary>
        ///     Gets the Microsoft SQL Server repository collection which pertains to the Membership namespace.
        /// </summary>
        public SqlServerMembershipRepositoryCollection Membership
        {
            get { return SqlServerRepositoryCollection.Create(this, ref _membership); }
        }

        /// <summary>
        ///     Gets the Microsoft SQL Server repository collection which pertains to the Marketing namespace.
        /// </summary>
        public SqlServerMarketingRepositoryCollection Marketing
        {
            get { return SqlServerRepositoryCollection.Create(this, ref _marketing); }
        }

        /// <summary>
        ///     Gets the Microsoft SQL Server repository collection which pertains to the Logistics namespace.
        /// </summary>
        public SqlServerLogisticsRepositoryCollection Logistics
        {
            get { return SqlServerRepositoryCollection.Create(this, ref _logistics); }
        }

        /// <summary>
        ///     Gets the Microsoft SQL Server repository collection which pertains to the Search namespace.
        /// </summary>
        public SqlServerSearchRepositoryCollection Search
        {
            get { return SqlServerRepositoryCollection.Create(this, ref _search); }
        }

        /// <summary>
        ///     Gets the Microsoft SQL Server repository collection which pertains to the Other namespace.
        /// </summary>
        public SqlServerOtherRepositoryCollection Other
        {
            get { return SqlServerRepositoryCollection.Create(this, ref _other); }
        }

        /// <summary>
        ///     Gets the Microsoft SQL Server repository collection which pertains to the Portal namespace.
        /// </summary>
        public SqlServerPortalRepositoryCollection Portal
        {
            get { return SqlServerRepositoryCollection.Create(this, ref _portal); }
        }

        /// <summary>
        ///     Gets the Microsoft SQL Server repository collection which pertains to the Reporting namespace.
        /// </summary>
        public SqlServerReportingRepositoryCollection Reporting
        {
            get { return SqlServerRepositoryCollection.Create(this, ref _reporting); }
        }

        #endregion

        #region methods

        /// <summary>
        ///     Gets a <see cref="DbCommand" /> instance for executing a stored procedure.
        /// </summary>
        /// <param name="procedure">
        ///     The name of the stored procedure to be executed by the <see cref="DbCommand" />.
        /// </param>
        /// <returns>
        ///     A new <see cref="DbCommand" /> instance, pre-initialised for executing the specified <paramref name="procedure" />.
        /// </returns>
        internal DbCommand GetStoredProcedure(String procedure)
        {
            // Create the command, connected to the database
            DbCommand command = this.Database.GetStoredProcCommand(procedure);
            command.Connection = this.Database.CreateConnection();
            if (!this.Cache.ContainsKey(procedure))
            {
                // Select the collection of parameters from the database and add to the cache.
                this.Database.DiscoverParameters(command);
                this.Cache.Add(procedure, command.Parameters.OfType<DbParameter>().Select(param => (param as ICloneable).Clone() as DbParameter).ToArray());
            }
            else
            {
                // Construct a collection of cloned parameters from the cache and add to the command.
                foreach (IDataParameter parameter in this.Cache[procedure])
                    command.Parameters.Add((parameter as ICloneable).Clone());
            }
            return command;
        }

        #endregion

        #region implementations

        /// <summary>
        ///     Gets the Microsoft SQL Server repository collection which pertains to the Contact namespace.
        /// </summary>
        Consensus.Contact.IContactRepositoryCollection IDataProvider.Contact
        {
            get { return this.Contact; }
        }

        /// <summary>
        ///     Gets the Microsoft SQL Server repository collection which pertains to the Learning namespace.
        /// </summary>
        Consensus.Learning.ILearningRepositoryCollection IDataProvider.Learning
        {
            get { return this.Learning; }
        }

        /// <summary>
        ///     Gets the Microsoft SQL Server repository collection which pertains to the Sales namespace.
        /// </summary>
        Consensus.Sales.ISalesRepositoryCollection IDataProvider.Sales
        {
            get { return this.Sales; }
        }

        /// <summary>
        ///     Gets the Microsoft SQL Server repository collection which pertains to the Document namespace.
        /// </summary>
        Consensus.Document.IDocumentRepositoryCollection IDataProvider.Document
        {
            get { return this.Document; }
        }

        /// <summary>
        ///     Gets the Microsoft SQL Server repository collection which pertains to the Finance namespace.
        /// </summary>
        Consensus.Finance.IFinanceRepositoryCollection IDataProvider.Finance
        {
            get { return this.Finance; }
        }

        /// <summary>
        ///     Gets the Microsoft SQL Server repository collection which pertains to the Common namespace.
        /// </summary>
        Consensus.Common.ICommonRepositoryCollection IDataProvider.Common
        {
            get { return this.Common; }
        }

        /// <summary>
        ///     Gets the Microsoft SQL Server repository collection which pertains to the Activities namespace.
        /// </summary>
        Consensus.Activities.IActivitiesRepositoryCollection IDataProvider.Activities
        {
            get { return this.Activities; }
        }

        /// <summary>
        ///     Gets the Microsoft SQL Server repository collection which pertains to the UserInterface namespace.
        /// </summary>
        Consensus.UserInterface.IUserInterfaceRepositoryCollection IDataProvider.UserInterface
        {
            get { return this.UserInterface; }
        }

        /// <summary>
        ///     Gets the Microsoft SQL Server repository collection which pertains to the Security namespace.
        /// </summary>
        Consensus.Security.ISecurityRepositoryCollection IDataProvider.Security
        {
            get { return this.Security; }
        }

        /// <summary>
        ///     Gets the Microsoft SQL Server repository collection which pertains to the Membership namespace.
        /// </summary>
        Consensus.Membership.IMembershipRepositoryCollection IDataProvider.Membership
        {
            get { return this.Membership; }
        }

        /// <summary>
        ///     Gets the Microsoft SQL Server repository collection which pertains to the Marketing namespace.
        /// </summary>
        Consensus.Marketing.IMarketingRepositoryCollection IDataProvider.Marketing
        {
            get { return this.Marketing; }
        }

        /// <summary>
        ///     Gets the Microsoft SQL Server repository collection which pertains to the Logistics namespace.
        /// </summary>
        Consensus.Logistics.ILogisticsRepositoryCollection IDataProvider.Logistics
        {
            get { return this.Logistics; }
        }

        /// <summary>
        ///     Gets the Microsoft SQL Server repository collection which pertains to the Search namespace.
        /// </summary>
        Consensus.Search.ISearchRepositoryCollection IDataProvider.Search
        {
            get { return this.Search; }
        }

        /// <summary>
        ///     Gets the Microsoft SQL Server repository collection which pertains to the Other namespace.
        /// </summary>
        Consensus.Other.IOtherRepositoryCollection IDataProvider.Other
        {
            get { return this.Other; }
        }

        /// <summary>
        ///     Gets the Microsoft SQL Server repository collection which pertains to the Portal namespace.
        /// </summary>
        Consensus.Portal.IPortalRepositoryCollection IDataProvider.Portal
        {
            get { return this.Portal; }
        }

        /// <summary>
        ///     Gets the Microsoft SQL Server repository collection which pertains to the Reporting namespace.
        /// </summary>
        Consensus.Reporting.IReportingRepositoryCollection IDataProvider.Reporting
        {
            get { return this.Reporting; }
        }

        System.Collections.Generic.Dictionary<System.String, System.Object>[] IDataProvider.ExecuteQuery(System.String query)
        {
            return this.ExecuteQuery(query);
        }

        System.Collections.Generic.Dictionary<System.String, System.Object>[] IDataProvider.ExecuteQuery(System.String query, System.Collections.Generic.Dictionary<System.String, System.Object> parameters)
        {
            return this.ExecuteQuery(query, parameters);
        }

        System.Collections.Generic.Dictionary<System.String, System.Object>[] IDataProvider.ExecuteProcedure(System.String procedureName, System.Collections.Generic.Dictionary<System.String, System.Object> parameters)
        {
            return this.ExecuteProcedure(procedureName, parameters);
        }

        #endregion
    }
}
