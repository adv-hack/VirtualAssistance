using System;
using System.Collections.Generic;
using System.Linq;
using Consensus.Common;
using Consensus.Security;

namespace Consensus.Reporting
{
    /// <summary>
    ///     Encapsulates the <see cref="ReportRecord" /> data structure.
    /// </summary>
    /// <remarks>
    ///     THIS CODE HAS BEEN AUTOMATICALLY GENERATED USING THE CONSENSUS DEVELOPER TOOLS.
    ///     DO NOT EDIT THIS CODE AS ANY CUSTOM MODIFICATIONS WILL BE LOST UPON REGENERATION.
    /// </remarks>
    public interface IReportModel : IModel<String>
    {
        /// <summary>
        ///     Gets or sets the value of the "REP_DESCRIPTION" field.
        /// </summary>
        System.String Description
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets or sets the value of the "REP_NAME" field.
        /// </summary>
        System.String Name
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets or sets the value of the "REP_CAT" field.
        /// </summary>
        System.String Cat
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets the The value of the "REP_TYPE" field.
        /// </summary>
        Consensus.Common.ICodeModel Type
        {
            get;
        }

        /// <summary>
        ///     Gets or sets the unique code for the value of the "REP_TYPE" field.
        /// </summary>
        System.String TypeCode
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets or sets the value of the "REP_LEVEL" field.
        /// </summary>
        System.Nullable<System.Byte> Level
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets or sets the value of the "REP_CONNECTION" field.
        /// </summary>
        System.Nullable<System.Byte> Connection
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets or sets the value of the "REP_CURRENT" field.
        /// </summary>
        System.Byte Current
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets the The value of the "REP_RPTP_ID" field.
        /// </summary>
        Consensus.Reporting.IReportPageModel ReportPage
        {
            get;
        }

        /// <summary>
        ///     Gets or sets the unique code for the value of the "REP_RPTP_ID" field.
        /// </summary>
        System.Nullable<System.Int32> ReportPageId
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets the The value of the "REP_RPP_ID" field.
        /// </summary>
        Consensus.Reporting.IReportParamPageModel ReportParamPage
        {
            get;
        }

        /// <summary>
        ///     Gets or sets the unique code for the value of the "REP_RPP_ID" field.
        /// </summary>
        System.Nullable<System.Int32> ReportParamPageId
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets or sets the value of the "REP_SYSTEM" field.
        /// </summary>
        System.Byte System
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets or sets the value of the "REP_STANDARD" field.
        /// </summary>
        System.Byte Standard
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets or sets the value of the "REP_SSRS_PARAMETERS" field.
        /// </summary>
        System.Byte SSRSParameters
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets or sets the value of the "REP_PMENU_ID" field.
        /// </summary>
        System.Nullable<System.Int32> PortalMenuId
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets the collection of <see cref="!:UserAccountModel" /> instances that reference this <see cref="!:ReportModel" />.
        /// </summary>
        Consensus.Collection<Consensus.Security.IUserAccountModel> UserAccountsReport
        {
            get;
        }
    }
}
