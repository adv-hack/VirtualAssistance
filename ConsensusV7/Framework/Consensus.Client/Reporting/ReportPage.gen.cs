using System;
using System.Collections.Generic;
using System.Linq;

namespace Consensus.Reporting
{
    /// <remarks>
    ///     THIS CODE HAS BEEN AUTOMATICALLY GENERATED USING THE CONSENSUS DEVELOPER TOOLS.
    ///     DO NOT EDIT THIS CODE AS ANY CUSTOM MODIFICATIONS WILL BE LOST UPON REGENERATION.
    /// </remarks>
    public partial class ReportPage : Proxy<IReportPageModel, Int32>
    {
        #region fields

        /// <summary>
        ///     The client-consumable proxy collection for the <see cref="ReportPages" /> member.
        /// </summary>
        private ProxyCollection<Consensus.Reporting.Report, Consensus.Reporting.IReportModel> _reportPages;

        #endregion

        #region properties

        /// <summary>
        ///     Gets or sets the value of the "RPTP_PAGE_NAME" field.
        /// </summary>
        public System.String PageName
        {
            get { return this.Model.PageName; }
            set { this.Model.PageName = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "RPTP_PAGE_PATH" field.
        /// </summary>
        public System.String PagePath
        {
            get { return this.Model.PagePath; }
            set { this.Model.PagePath = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "RPTP_SECTION" field.
        /// </summary>
        public System.String Section
        {
            get { return this.Model.Section; }
            set { this.Model.Section = value; }
        }

        /// <summary>
        ///     Gets the collection of <see cref="!:ReportModel" /> instances that reference this <see cref="!:ReportPageModel" />.
        /// </summary>
        public Collection<Consensus.Reporting.Report> ReportPages
        {
            get
            {
                if (_reportPages == null)
                    _reportPages = new ProxyCollection<Consensus.Reporting.Report, Consensus.Reporting.IReportModel>(this.Model.ReportPages, model => new Consensus.Reporting.Report(model));
                return _reportPages;
            }
        }

        #endregion

        #region constructors

        /// <summary>
        ///     Initialises a new instance of the client-consumable class.
        /// </summary>
        internal ReportPage(IReportPageModel model) : base(model)
        {
        }

        #endregion

        #region methods

        /// <summary>
        ///     Creates a new <see cref="!:ReportPageModel" /> instance.
        /// </summary>
        /// <returns>
        ///     A newly instantiated <see cref="!:ReportPageModel" /> instance.
        /// </returns>
        public static Consensus.Reporting.ReportPage Create()
        {
            ConsensusSite site = ConsensusDomain.Configuration[ConsensusDomain.Configuration.DefaultSite];
            return ReportPage.Create(site);
        }

        /// <summary>
        ///     Creates a new <see cref="!:ReportPageModel" /> instance.
        /// </summary>
        /// <returns>
        ///     A newly instantiated <see cref="!:ReportPageModel" /> instance.
        /// </returns>
        public static Consensus.Reporting.ReportPage Create(ConsensusSite site)
        {
            IBusinessProvider provider = site.GetService<IBusinessProvider>();
            Consensus.Reporting.IReportPageModel model = provider.Reporting.ReportPage.Create();
            return model == null ? null : new Consensus.Reporting.ReportPage(model);
        }

        /// <summary>
        ///     Retrieves all instances of the <see cref="!:ReportPageModel" /> class.
        /// </summary>
        /// <returns>
        ///     An enumerable collection of <see cref="!:ReportPageModel" /> instances.
        /// </returns>
        public static IEnumerable<Consensus.Reporting.ReportPage> FetchAll()
        {
            ConsensusSite site = ConsensusDomain.Configuration[ConsensusDomain.Configuration.DefaultSite];
            return ReportPage.FetchAll(site);
        }

        /// <summary>
        ///     Retrieves all instances of the <see cref="!:ReportPageModel" /> class.
        /// </summary>
        /// <returns>
        ///     An enumerable collection of <see cref="!:ReportPageModel" /> instances.
        /// </returns>
        public static IEnumerable<Consensus.Reporting.ReportPage> FetchAll(ConsensusSite site)
        {
            IBusinessProvider provider = site.GetService<IBusinessProvider>();
            IEnumerable<Consensus.Reporting.IReportPageModel> collection = provider.Reporting.ReportPage.FetchAll();
            return collection.Select(model => new Consensus.Reporting.ReportPage(model));
        }

        /// <summary>
        ///     Retrieves a specific <see cref="!:ReportPageModel" /> instance.
        /// </summary>
        /// <param name="id">
        ///     The unique value which distinctly identifies the <see cref="!:ReportPageModel" /> instance to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:ReportPageModel" /> instance that matches the specified <paramref name="id" />; or null, if no matching instance can be found.
        /// </returns>
        public static Consensus.Reporting.ReportPage FetchById(System.Int32 id)
        {
            ConsensusSite site = ConsensusDomain.Configuration[ConsensusDomain.Configuration.DefaultSite];
            return ReportPage.FetchById(site,id);
        }

        /// <summary>
        ///     Retrieves a specific <see cref="!:ReportPageModel" /> instance.
        /// </summary>
        /// <param name="id">
        ///     The unique value which distinctly identifies the <see cref="!:ReportPageModel" /> instance to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:ReportPageModel" /> instance that matches the specified <paramref name="id" />; or null, if no matching instance can be found.
        /// </returns>
        public static Consensus.Reporting.ReportPage FetchById(ConsensusSite site, System.Int32 id)
        {
            IBusinessProvider provider = site.GetService<IBusinessProvider>();
            Consensus.Reporting.IReportPageModel model = provider.Reporting.ReportPage.FetchById(id);
            return model == null ? null : new Consensus.Reporting.ReportPage(model);
        }

        public static System.String GetTableName()
        {
            ConsensusSite site = ConsensusDomain.Configuration[ConsensusDomain.Configuration.DefaultSite];
            return ReportPage.GetTableName(site);
        }

        public static System.String GetTableName(ConsensusSite site)
        {
            IBusinessProvider provider = site.GetService<IBusinessProvider>();
            return provider.Reporting.ReportPage.GetTableName();
        }

        #endregion
    }
}
