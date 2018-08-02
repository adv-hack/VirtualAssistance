using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Linq;

namespace Consensus.Reporting
{
    /// <summary>
    ///     Represents a collection of factory instances which are responsible for the instantiation of the business models in the Reporting namespace.
    /// </summary>
    /// <remarks>
    ///     THIS CODE HAS BEEN AUTOMATICALLY GENERATED USING THE CONSENSUS DEVELOPER TOOLS.
    ///     DO NOT EDIT THIS CODE AS ANY CUSTOM MODIFICATIONS WILL BE LOST UPON REGENERATION.
    /// </remarks>
    public interface IReportingFactoryCollection : IFactoryCollection
    {
        /// <summary>
        ///     Gets the locally executable factory which is responsible for instantiating <see cref="!:ReportModel" /> objects.
        /// </summary>
        Consensus.Reporting.IReportFactory Report
        {
            get;
        }

        /// <summary>
        ///     Gets the locally executable factory which is responsible for instantiating <see cref="!:ReportPageModel" /> objects.
        /// </summary>
        Consensus.Reporting.IReportPageFactory ReportPage
        {
            get;
        }

        /// <summary>
        ///     Gets the locally executable factory which is responsible for instantiating <see cref="!:ReportParamPageModel" /> objects.
        /// </summary>
        Consensus.Reporting.IReportParamPageFactory ReportParamPage
        {
            get;
        }
    }
}
