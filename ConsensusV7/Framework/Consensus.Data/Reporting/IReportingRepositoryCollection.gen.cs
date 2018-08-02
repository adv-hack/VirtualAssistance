using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Linq;

namespace Consensus.Reporting
{
    /// <summary>
    ///     The repository collection which pertains to the Reporting namespace.
    /// </summary>
    /// <remarks>
    ///     THIS CODE HAS BEEN AUTOMATICALLY GENERATED USING THE CONSENSUS DEVELOPER TOOLS.
    ///     DO NOT EDIT THIS CODE AS ANY CUSTOM MODIFICATIONS WILL BE LOST UPON REGENERATION.
    /// </remarks>
    public interface IReportingRepositoryCollection : IRepositoryCollection
    {
        /// <summary>
        ///     Gets the Microsoft SQL Server repository which persists and retrieves instances of the <see cref="T:Consensus.Reporting.ReportRecord" /> data structure.
        /// </summary>
        Consensus.Reporting.IReportRepository Report
        {
            get;
        }

        /// <summary>
        ///     Gets the Microsoft SQL Server repository which persists and retrieves instances of the <see cref="T:Consensus.Reporting.ReportPageRecord" /> data structure.
        /// </summary>
        Consensus.Reporting.IReportPageRepository ReportPage
        {
            get;
        }

        /// <summary>
        ///     Gets the Microsoft SQL Server repository which persists and retrieves instances of the <see cref="T:Consensus.Reporting.ReportParampageRecord" /> data structure.
        /// </summary>
        Consensus.Reporting.IReportParamPageRepository ReportParamPage
        {
            get;
        }
    }
}
