using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Linq;

namespace Consensus.Reporting
{
    /// <summary>
    ///     Microsoft SQL Server repository collection which pertains to the Reporting namespace.
    /// </summary>
    /// <remarks>
    ///     THIS CODE HAS BEEN AUTOMATICALLY GENERATED USING THE CONSENSUS DEVELOPER TOOLS.
    ///     DO NOT EDIT THIS CODE AS ANY CUSTOM MODIFICATIONS WILL BE LOST UPON REGENERATION.
    /// </remarks>
    public partial class SqlServerReportingRepositoryCollection : SqlServerRepositoryCollection, IReportingRepositoryCollection
    {
        #region fields

        /// <summary>
        ///     The Microsoft SQL Server repository which persists and retrieves instances of the <see cref="ReportRecord" /> data structure.
        /// </summary>
        private SqlServerReportRepository _report;

        /// <summary>
        ///     The Microsoft SQL Server repository which persists and retrieves instances of the <see cref="ReportPageRecord" /> data structure.
        /// </summary>
        private SqlServerReportPageRepository _reportPage;

        /// <summary>
        ///     The Microsoft SQL Server repository which persists and retrieves instances of the <see cref="ReportParampageRecord" /> data structure.
        /// </summary>
        private SqlServerReportParamPageRepository _reportParamPage;

        #endregion

        #region properties

        /// <summary>
        ///     Gets the Microsoft SQL Server repository which persists and retrieves instances of the <see cref="ReportRecord" /> data structure.
        /// </summary>
        public SqlServerReportRepository Report
        {
            get
            {
                SqlServerProvider provider = this.Provider;
                OverrideProvider(typeof(SqlServerReportRepository), ref provider);
                return SqlServerRepository.Create(provider, ref _report);
            }
        }

        /// <summary>
        ///     Gets the Microsoft SQL Server repository which persists and retrieves instances of the <see cref="ReportPageRecord" /> data structure.
        /// </summary>
        public SqlServerReportPageRepository ReportPage
        {
            get
            {
                SqlServerProvider provider = this.Provider;
                OverrideProvider(typeof(SqlServerReportPageRepository), ref provider);
                return SqlServerRepository.Create(provider, ref _reportPage);
            }
        }

        /// <summary>
        ///     Gets the Microsoft SQL Server repository which persists and retrieves instances of the <see cref="ReportParampageRecord" /> data structure.
        /// </summary>
        public SqlServerReportParamPageRepository ReportParamPage
        {
            get
            {
                SqlServerProvider provider = this.Provider;
                OverrideProvider(typeof(SqlServerReportParamPageRepository), ref provider);
                return SqlServerRepository.Create(provider, ref _reportParamPage);
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
        ///     Gets the Microsoft SQL Server repository which persists and retrieves instances of the <see cref="T:Consensus.Reporting.ReportRecord" /> data structure.
        /// </summary>
        Consensus.Reporting.IReportRepository IReportingRepositoryCollection.Report
        {
            get { return this.Report; }
        }

        /// <summary>
        ///     Gets the Microsoft SQL Server repository which persists and retrieves instances of the <see cref="T:Consensus.Reporting.ReportPageRecord" /> data structure.
        /// </summary>
        Consensus.Reporting.IReportPageRepository IReportingRepositoryCollection.ReportPage
        {
            get { return this.ReportPage; }
        }

        /// <summary>
        ///     Gets the Microsoft SQL Server repository which persists and retrieves instances of the <see cref="T:Consensus.Reporting.ReportParampageRecord" /> data structure.
        /// </summary>
        Consensus.Reporting.IReportParamPageRepository IReportingRepositoryCollection.ReportParamPage
        {
            get { return this.ReportParamPage; }
        }

        #endregion
    }
}
