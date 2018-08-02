using System;
using System.Collections.Generic;
using System.Linq;

namespace Consensus.Reporting
{
    /// <summary>
    ///     Encapsulates the <see cref="ReportPageRecord" /> data structure.
    /// </summary>
    /// <remarks>
    ///     THIS CODE HAS BEEN AUTOMATICALLY GENERATED USING THE CONSENSUS DEVELOPER TOOLS.
    ///     DO NOT EDIT THIS CODE AS ANY CUSTOM MODIFICATIONS WILL BE LOST UPON REGENERATION.
    /// </remarks>
    public interface IReportPageModel : IModel<Int32>
    {
        /// <summary>
        ///     Gets or sets the value of the "RPTP_PAGE_NAME" field.
        /// </summary>
        System.String PageName
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets or sets the value of the "RPTP_PAGE_PATH" field.
        /// </summary>
        System.String PagePath
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets or sets the value of the "RPTP_SECTION" field.
        /// </summary>
        System.String Section
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets the collection of <see cref="!:ReportModel" /> instances that reference this <see cref="!:ReportPageModel" />.
        /// </summary>
        Consensus.Collection<Consensus.Reporting.IReportModel> ReportPages
        {
            get;
        }
    }
}
