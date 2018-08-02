using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Linq;

namespace Consensus.Reporting
{
    /// <summary>
    ///     Supports the instantiation of the <see cref="ReportModel" /> class.
    /// </summary>
    /// <remarks>
    ///     THIS CODE HAS BEEN AUTOMATICALLY GENERATED USING THE CONSENSUS DEVELOPER TOOLS.
    ///     DO NOT EDIT THIS CODE AS ANY CUSTOM MODIFICATIONS WILL BE LOST UPON REGENERATION.
    /// </remarks>
    public interface IReportFactory : IFactory<IReportModel, String>
    {
        /// <summary>
        ///     Creates a new <see cref="!:ReportModel" /> instance.
        /// </summary>
        /// <returns>
        ///     A newly instantiated <see cref="!:ReportModel" /> instance.
        /// </returns>
        Consensus.Reporting.IReportModel Create();

        /// <summary>
        ///     Retrieves all instances of the <see cref="!:ReportModel" /> class.
        /// </summary>
        /// <returns>
        ///     An enumerable collection of <see cref="!:ReportModel" /> instances.
        /// </returns>
        System.Collections.Generic.IEnumerable<Consensus.Reporting.IReportModel> FetchAll();

        /// <summary>
        ///     Retrieves a specific <see cref="!:ReportModel" /> instance.
        /// </summary>
        /// <param name="id">
        ///     The unique value which distinctly identifies the <see cref="!:ReportModel" /> instance to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:ReportModel" /> instance that matches the specified <paramref name="id" />; or null, if no matching instance can be found.
        /// </returns>
        Consensus.Reporting.IReportModel FetchById(System.String id);

        System.String GetTableName();

        System.Collections.Generic.IEnumerable<Consensus.Reporting.IReportModel> FetchAllByReportPageId(System.Nullable<System.Int32> reportPageId);

        System.Collections.Generic.IEnumerable<Consensus.Reporting.IReportModel> FetchAllByReportParamPageId(System.Nullable<System.Int32> reportParamPageId);
    }
}
