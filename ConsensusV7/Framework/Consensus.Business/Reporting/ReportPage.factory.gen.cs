using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Linq;

namespace Consensus.Reporting
{
    /// <summary>
    ///     Supports the instantiation of the <see cref="ReportPageModel" /> class.
    /// </summary>
    /// <remarks>
    ///     THIS CODE HAS BEEN AUTOMATICALLY GENERATED USING THE CONSENSUS DEVELOPER TOOLS.
    ///     DO NOT EDIT THIS CODE AS ANY CUSTOM MODIFICATIONS WILL BE LOST UPON REGENERATION.
    /// </remarks>
    public interface IReportPageFactory : IFactory<IReportPageModel, Int32>
    {
        /// <summary>
        ///     Creates a new <see cref="!:ReportPageModel" /> instance.
        /// </summary>
        /// <returns>
        ///     A newly instantiated <see cref="!:ReportPageModel" /> instance.
        /// </returns>
        Consensus.Reporting.IReportPageModel Create();

        /// <summary>
        ///     Retrieves all instances of the <see cref="!:ReportPageModel" /> class.
        /// </summary>
        /// <returns>
        ///     An enumerable collection of <see cref="!:ReportPageModel" /> instances.
        /// </returns>
        System.Collections.Generic.IEnumerable<Consensus.Reporting.IReportPageModel> FetchAll();

        /// <summary>
        ///     Retrieves a specific <see cref="!:ReportPageModel" /> instance.
        /// </summary>
        /// <param name="id">
        ///     The unique value which distinctly identifies the <see cref="!:ReportPageModel" /> instance to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:ReportPageModel" /> instance that matches the specified <paramref name="id" />; or null, if no matching instance can be found.
        /// </returns>
        Consensus.Reporting.IReportPageModel FetchById(System.Int32 id);

        System.String GetTableName();
    }
}
