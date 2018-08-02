using System;
using System.Collections.Generic;
using System.Linq;

namespace Consensus.Reporting
{
    /// <remarks>
    ///     THIS CODE HAS BEEN AUTOMATICALLY GENERATED USING THE CONSENSUS DEVELOPER TOOLS.
    ///     DO NOT EDIT THIS CODE AS ANY CUSTOM MODIFICATIONS WILL BE LOST UPON REGENERATION.
    /// </remarks>
    public partial class ReportParamPage : Proxy<IReportParamPageModel, Int32>
    {
        #region fields

        /// <summary>
        ///     The client-consumable proxy collection for the <see cref="ReportParamPages" /> member.
        /// </summary>
        private ProxyCollection<Consensus.Reporting.Report, Consensus.Reporting.IReportModel> _reportParamPages;

        #endregion

        #region properties

        /// <summary>
        ///     Gets or sets the value of the "RPP_PAGE_NAME" field.
        /// </summary>
        public System.String PageName
        {
            get { return this.Model.PageName; }
            set { this.Model.PageName = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "RPP_PAGE_PATH" field.
        /// </summary>
        public System.String PagePath
        {
            get { return this.Model.PagePath; }
            set { this.Model.PagePath = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "RPP_PARAM_DESC" field.
        /// </summary>
        public System.String ParamDesc
        {
            get { return this.Model.ParamDesc; }
            set { this.Model.ParamDesc = value; }
        }

        /// <summary>
        ///     Gets the collection of <see cref="!:ReportModel" /> instances that reference this <see cref="!:ReportParamPageModel" />.
        /// </summary>
        public Collection<Consensus.Reporting.Report> ReportParamPages
        {
            get
            {
                if (_reportParamPages == null)
                    _reportParamPages = new ProxyCollection<Consensus.Reporting.Report, Consensus.Reporting.IReportModel>(this.Model.ReportParamPages, model => new Consensus.Reporting.Report(model));
                return _reportParamPages;
            }
        }

        #endregion

        #region constructors

        /// <summary>
        ///     Initialises a new instance of the client-consumable class.
        /// </summary>
        internal ReportParamPage(IReportParamPageModel model) : base(model)
        {
        }

        #endregion

        #region methods

        /// <summary>
        ///     Creates a new <see cref="!:ReportParamPageModel" /> instance.
        /// </summary>
        /// <returns>
        ///     A newly instantiated <see cref="!:ReportParamPageModel" /> instance.
        /// </returns>
        public static Consensus.Reporting.ReportParamPage Create()
        {
            ConsensusSite site = ConsensusDomain.Configuration[ConsensusDomain.Configuration.DefaultSite];
            return ReportParamPage.Create(site);
        }

        /// <summary>
        ///     Creates a new <see cref="!:ReportParamPageModel" /> instance.
        /// </summary>
        /// <returns>
        ///     A newly instantiated <see cref="!:ReportParamPageModel" /> instance.
        /// </returns>
        public static Consensus.Reporting.ReportParamPage Create(ConsensusSite site)
        {
            IBusinessProvider provider = site.GetService<IBusinessProvider>();
            Consensus.Reporting.IReportParamPageModel model = provider.Reporting.ReportParamPage.Create();
            return model == null ? null : new Consensus.Reporting.ReportParamPage(model);
        }

        /// <summary>
        ///     Retrieves all instances of the <see cref="!:ReportParamPageModel" /> class.
        /// </summary>
        /// <returns>
        ///     An enumerable collection of <see cref="!:ReportParamPageModel" /> instances.
        /// </returns>
        public static IEnumerable<Consensus.Reporting.ReportParamPage> FetchAll()
        {
            ConsensusSite site = ConsensusDomain.Configuration[ConsensusDomain.Configuration.DefaultSite];
            return ReportParamPage.FetchAll(site);
        }

        /// <summary>
        ///     Retrieves all instances of the <see cref="!:ReportParamPageModel" /> class.
        /// </summary>
        /// <returns>
        ///     An enumerable collection of <see cref="!:ReportParamPageModel" /> instances.
        /// </returns>
        public static IEnumerable<Consensus.Reporting.ReportParamPage> FetchAll(ConsensusSite site)
        {
            IBusinessProvider provider = site.GetService<IBusinessProvider>();
            IEnumerable<Consensus.Reporting.IReportParamPageModel> collection = provider.Reporting.ReportParamPage.FetchAll();
            return collection.Select(model => new Consensus.Reporting.ReportParamPage(model));
        }

        /// <summary>
        ///     Retrieves a specific <see cref="!:ReportParamPageModel" /> instance.
        /// </summary>
        /// <param name="id">
        ///     The unique value which distinctly identifies the <see cref="!:ReportParamPageModel" /> instance to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:ReportParamPageModel" /> instance that matches the specified <paramref name="id" />; or null, if no matching instance can be found.
        /// </returns>
        public static Consensus.Reporting.ReportParamPage FetchById(System.Int32 id)
        {
            ConsensusSite site = ConsensusDomain.Configuration[ConsensusDomain.Configuration.DefaultSite];
            return ReportParamPage.FetchById(site,id);
        }

        /// <summary>
        ///     Retrieves a specific <see cref="!:ReportParamPageModel" /> instance.
        /// </summary>
        /// <param name="id">
        ///     The unique value which distinctly identifies the <see cref="!:ReportParamPageModel" /> instance to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:ReportParamPageModel" /> instance that matches the specified <paramref name="id" />; or null, if no matching instance can be found.
        /// </returns>
        public static Consensus.Reporting.ReportParamPage FetchById(ConsensusSite site, System.Int32 id)
        {
            IBusinessProvider provider = site.GetService<IBusinessProvider>();
            Consensus.Reporting.IReportParamPageModel model = provider.Reporting.ReportParamPage.FetchById(id);
            return model == null ? null : new Consensus.Reporting.ReportParamPage(model);
        }

        public static System.String GetTableName()
        {
            ConsensusSite site = ConsensusDomain.Configuration[ConsensusDomain.Configuration.DefaultSite];
            return ReportParamPage.GetTableName(site);
        }

        public static System.String GetTableName(ConsensusSite site)
        {
            IBusinessProvider provider = site.GetService<IBusinessProvider>();
            return provider.Reporting.ReportParamPage.GetTableName();
        }

        #endregion
    }
}
