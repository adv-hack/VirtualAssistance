using System;
using System.Collections.Generic;
using System.Linq;

namespace Consensus.Reporting
{
    /// <summary>
    ///     Encapsulates the <see cref="ReportParampageRecord" /> data structure.
    /// </summary>
    /// <remarks>
    ///     THIS CODE HAS BEEN AUTOMATICALLY GENERATED USING THE CONSENSUS DEVELOPER TOOLS.
    ///     DO NOT EDIT THIS CODE AS ANY CUSTOM MODIFICATIONS WILL BE LOST UPON REGENERATION.
    /// </remarks>
    public interface IReportParamPageModel : IModel<Int32>
    {
        /// <summary>
        ///     Gets or sets the value of the "RPP_PAGE_NAME" field.
        /// </summary>
        System.String PageName
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets or sets the value of the "RPP_PAGE_PATH" field.
        /// </summary>
        System.String PagePath
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets or sets the value of the "RPP_PARAM_DESC" field.
        /// </summary>
        System.String ParamDesc
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets the collection of <see cref="!:ReportModel" /> instances that reference this <see cref="!:ReportParamPageModel" />.
        /// </summary>
        Consensus.Collection<Consensus.Reporting.IReportModel> ReportParamPages
        {
            get;
        }
    }
}
