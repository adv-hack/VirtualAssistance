using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Linq;

namespace Consensus.Reporting
{
    /// <summary>
    ///     Provides the persistence and retrieval of the <see cref="ReportRecord" /> instances.
    /// </summary>
    /// <remarks>
    ///     THIS CODE HAS BEEN AUTOMATICALLY GENERATED USING THE CONSENSUS DEVELOPER TOOLS.
    ///     DO NOT EDIT THIS CODE AS ANY CUSTOM MODIFICATIONS WILL BE LOST UPON REGENERATION.
    /// </remarks>
    public interface IReportRepository : IRepository<ReportRecord, String>
    {
        #region properties

        /// <summary>
        ///     Gets the underlying table name that this repository sit over.
        /// </summary>
        System.String TableName
        {
            get;
        }

        #endregion

        #region methods

        System.Collections.Generic.IEnumerable<Consensus.Reporting.ReportRecord> FetchAllByRptpId(System.Nullable<System.Int32> rptpId);

        System.Collections.Generic.IEnumerable<Consensus.Reporting.ReportRecord> FetchAllByRppId(System.Nullable<System.Int32> rppId);

        #endregion
    }
}
