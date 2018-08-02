using System;
using System.Collections.Generic;
using System.Linq;
using Consensus.Common;
using Consensus.Security;

namespace Consensus.Reporting
{
    /// <remarks>
    ///     THIS CODE HAS BEEN AUTOMATICALLY GENERATED USING THE CONSENSUS DEVELOPER TOOLS.
    ///     DO NOT EDIT THIS CODE AS ANY CUSTOM MODIFICATIONS WILL BE LOST UPON REGENERATION.
    /// </remarks>
    public partial class Report : Proxy<IReportModel, String>
    {
        #region fields

        /// <summary>
        ///     The client-consumable proxy instance for the <see cref="Type" /> member.
        /// </summary>
        private Consensus.Common.Code _type;

        /// <summary>
        ///     The client-consumable proxy instance for the <see cref="ReportPage" /> member.
        /// </summary>
        private Consensus.Reporting.ReportPage _reportPage;

        /// <summary>
        ///     The client-consumable proxy instance for the <see cref="ReportParamPage" /> member.
        /// </summary>
        private Consensus.Reporting.ReportParamPage _reportParamPage;

        /// <summary>
        ///     The client-consumable proxy collection for the <see cref="UserAccountsReport" /> member.
        /// </summary>
        private ProxyCollection<Consensus.Security.UserAccount, Consensus.Security.IUserAccountModel> _userAccountsReport;

        #endregion

        #region properties

        /// <summary>
        ///     Gets or sets the value of the "REP_DESCRIPTION" field.
        /// </summary>
        public System.String Description
        {
            get { return this.Model.Description; }
            set { this.Model.Description = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "REP_NAME" field.
        /// </summary>
        public System.String Name
        {
            get { return this.Model.Name; }
            set { this.Model.Name = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "REP_CAT" field.
        /// </summary>
        public System.String Cat
        {
            get { return this.Model.Cat; }
            set { this.Model.Cat = value; }
        }

        /// <summary>
        ///     Gets the The value of the "REP_TYPE" field.
        /// </summary>
        public Consensus.Common.Code Type
        {
            get
            {
                if (_type == null && this.Model.Type != null)
                    _type = new Consensus.Common.Code(this.Model.Type);
                if (_type == null)
                    _type = Consensus.Common.Code.Create();
                return _type;
            }
        }

        /// <summary>
        ///     Gets or sets the unique code for the value of the "REP_TYPE" field.
        /// </summary>
        public System.String TypeCode
        {
            get { return this.Model.TypeCode; }
            set { this.Model.TypeCode = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "REP_LEVEL" field.
        /// </summary>
        public System.Nullable<System.Byte> Level
        {
            get { return this.Model.Level; }
            set { this.Model.Level = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "REP_CONNECTION" field.
        /// </summary>
        public System.Nullable<System.Byte> Connection
        {
            get { return this.Model.Connection; }
            set { this.Model.Connection = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "REP_CURRENT" field.
        /// </summary>
        public System.Byte Current
        {
            get { return this.Model.Current; }
            set { this.Model.Current = value; }
        }

        /// <summary>
        ///     Gets the The value of the "REP_RPTP_ID" field.
        /// </summary>
        public Consensus.Reporting.ReportPage ReportPage
        {
            get
            {
                if (_reportPage == null && this.Model.ReportPage != null)
                    _reportPage = new Consensus.Reporting.ReportPage(this.Model.ReportPage);
                if (_reportPage == null)
                    _reportPage = Consensus.Reporting.ReportPage.Create();
                return _reportPage;
            }
        }

        /// <summary>
        ///     Gets or sets the unique code for the value of the "REP_RPTP_ID" field.
        /// </summary>
        public System.Nullable<System.Int32> ReportPageId
        {
            get { return this.Model.ReportPageId; }
            set { this.Model.ReportPageId = value; }
        }

        /// <summary>
        ///     Gets the The value of the "REP_RPP_ID" field.
        /// </summary>
        public Consensus.Reporting.ReportParamPage ReportParamPage
        {
            get
            {
                if (_reportParamPage == null && this.Model.ReportParamPage != null)
                    _reportParamPage = new Consensus.Reporting.ReportParamPage(this.Model.ReportParamPage);
                if (_reportParamPage == null)
                    _reportParamPage = Consensus.Reporting.ReportParamPage.Create();
                return _reportParamPage;
            }
        }

        /// <summary>
        ///     Gets or sets the unique code for the value of the "REP_RPP_ID" field.
        /// </summary>
        public System.Nullable<System.Int32> ReportParamPageId
        {
            get { return this.Model.ReportParamPageId; }
            set { this.Model.ReportParamPageId = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "REP_SYSTEM" field.
        /// </summary>
        public System.Byte System
        {
            get { return this.Model.System; }
            set { this.Model.System = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "REP_STANDARD" field.
        /// </summary>
        public System.Byte Standard
        {
            get { return this.Model.Standard; }
            set { this.Model.Standard = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "REP_SSRS_PARAMETERS" field.
        /// </summary>
        public System.Byte SSRSParameters
        {
            get { return this.Model.SSRSParameters; }
            set { this.Model.SSRSParameters = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "REP_PMENU_ID" field.
        /// </summary>
        public System.Nullable<System.Int32> PortalMenuId
        {
            get { return this.Model.PortalMenuId; }
            set { this.Model.PortalMenuId = value; }
        }

        /// <summary>
        ///     Gets the collection of <see cref="!:UserAccountModel" /> instances that reference this <see cref="!:ReportModel" />.
        /// </summary>
        public Collection<Consensus.Security.UserAccount> UserAccountsReport
        {
            get
            {
                if (_userAccountsReport == null)
                    _userAccountsReport = new ProxyCollection<Consensus.Security.UserAccount, Consensus.Security.IUserAccountModel>(this.Model.UserAccountsReport, model => new Consensus.Security.UserAccount(model));
                return _userAccountsReport;
            }
        }

        #endregion

        #region constructors

        /// <summary>
        ///     Initialises a new instance of the client-consumable class.
        /// </summary>
        internal Report(IReportModel model) : base(model)
        {
        }

        #endregion

        #region methods

        /// <summary>
        ///     Creates a new <see cref="!:ReportModel" /> instance.
        /// </summary>
        /// <returns>
        ///     A newly instantiated <see cref="!:ReportModel" /> instance.
        /// </returns>
        public static Consensus.Reporting.Report Create()
        {
            ConsensusSite site = ConsensusDomain.Configuration[ConsensusDomain.Configuration.DefaultSite];
            return Report.Create(site);
        }

        /// <summary>
        ///     Creates a new <see cref="!:ReportModel" /> instance.
        /// </summary>
        /// <returns>
        ///     A newly instantiated <see cref="!:ReportModel" /> instance.
        /// </returns>
        public static Consensus.Reporting.Report Create(ConsensusSite site)
        {
            IBusinessProvider provider = site.GetService<IBusinessProvider>();
            Consensus.Reporting.IReportModel model = provider.Reporting.Report.Create();
            return model == null ? null : new Consensus.Reporting.Report(model);
        }

        /// <summary>
        ///     Retrieves all instances of the <see cref="!:ReportModel" /> class.
        /// </summary>
        /// <returns>
        ///     An enumerable collection of <see cref="!:ReportModel" /> instances.
        /// </returns>
        public static IEnumerable<Consensus.Reporting.Report> FetchAll()
        {
            ConsensusSite site = ConsensusDomain.Configuration[ConsensusDomain.Configuration.DefaultSite];
            return Report.FetchAll(site);
        }

        /// <summary>
        ///     Retrieves all instances of the <see cref="!:ReportModel" /> class.
        /// </summary>
        /// <returns>
        ///     An enumerable collection of <see cref="!:ReportModel" /> instances.
        /// </returns>
        public static IEnumerable<Consensus.Reporting.Report> FetchAll(ConsensusSite site)
        {
            IBusinessProvider provider = site.GetService<IBusinessProvider>();
            IEnumerable<Consensus.Reporting.IReportModel> collection = provider.Reporting.Report.FetchAll();
            return collection.Select(model => new Consensus.Reporting.Report(model));
        }

        /// <summary>
        ///     Retrieves a specific <see cref="!:ReportModel" /> instance.
        /// </summary>
        /// <param name="id">
        ///     The unique value which distinctly identifies the <see cref="!:ReportModel" /> instance to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:ReportModel" /> instance that matches the specified <paramref name="id" />; or null, if no matching instance can be found.
        /// </returns>
        public static Consensus.Reporting.Report FetchById(System.String id)
        {
            ConsensusSite site = ConsensusDomain.Configuration[ConsensusDomain.Configuration.DefaultSite];
            return Report.FetchById(site,id);
        }

        /// <summary>
        ///     Retrieves a specific <see cref="!:ReportModel" /> instance.
        /// </summary>
        /// <param name="id">
        ///     The unique value which distinctly identifies the <see cref="!:ReportModel" /> instance to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:ReportModel" /> instance that matches the specified <paramref name="id" />; or null, if no matching instance can be found.
        /// </returns>
        public static Consensus.Reporting.Report FetchById(ConsensusSite site, System.String id)
        {
            IBusinessProvider provider = site.GetService<IBusinessProvider>();
            Consensus.Reporting.IReportModel model = provider.Reporting.Report.FetchById(id);
            return model == null ? null : new Consensus.Reporting.Report(model);
        }

        public static System.String GetTableName()
        {
            ConsensusSite site = ConsensusDomain.Configuration[ConsensusDomain.Configuration.DefaultSite];
            return Report.GetTableName(site);
        }

        public static System.String GetTableName(ConsensusSite site)
        {
            IBusinessProvider provider = site.GetService<IBusinessProvider>();
            return provider.Reporting.Report.GetTableName();
        }

        public static IEnumerable<Consensus.Reporting.Report> FetchAllByReportPageId(System.Nullable<System.Int32> reportPageId)
        {
            ConsensusSite site = ConsensusDomain.Configuration[ConsensusDomain.Configuration.DefaultSite];
            return Report.FetchAllByReportPageId(site,reportPageId);
        }

        public static IEnumerable<Consensus.Reporting.Report> FetchAllByReportPageId(ConsensusSite site, System.Nullable<System.Int32> reportPageId)
        {
            IBusinessProvider provider = site.GetService<IBusinessProvider>();
            IEnumerable<Consensus.Reporting.IReportModel> collection = provider.Reporting.Report.FetchAllByReportPageId(reportPageId);
            return collection.Select(model => new Consensus.Reporting.Report(model));
        }

        public static IEnumerable<Consensus.Reporting.Report> FetchAllByReportParamPageId(System.Nullable<System.Int32> reportParamPageId)
        {
            ConsensusSite site = ConsensusDomain.Configuration[ConsensusDomain.Configuration.DefaultSite];
            return Report.FetchAllByReportParamPageId(site,reportParamPageId);
        }

        public static IEnumerable<Consensus.Reporting.Report> FetchAllByReportParamPageId(ConsensusSite site, System.Nullable<System.Int32> reportParamPageId)
        {
            IBusinessProvider provider = site.GetService<IBusinessProvider>();
            IEnumerable<Consensus.Reporting.IReportModel> collection = provider.Reporting.Report.FetchAllByReportParamPageId(reportParamPageId);
            return collection.Select(model => new Consensus.Reporting.Report(model));
        }

        #endregion
    }
}
