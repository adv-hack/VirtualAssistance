using System;
using System.Collections.Generic;
using System.Linq;

namespace Consensus.Reporting
{
    /// <summary>
    ///     Supports the instantiation of the <see cref="ReportParamPageModel" /> object.
    /// </summary>
    /// <remarks>
    ///     THIS CODE HAS BEEN AUTOMATICALLY GENERATED USING THE CONSENSUS DEVELOPER TOOLS.
    ///     DO NOT EDIT THIS CODE AS ANY CUSTOM MODIFICATIONS WILL BE LOST UPON REGENERATION.
    /// </remarks>
    public partial class LocalReportParamPageFactory : LocalFactory<LocalReportParamPageModel, ReportParampageRecord, Int32>, IReportParamPageFactory
    {
        #region methods

        /// <summary>
        ///     Creates a new <see cref='ReportParamPageModel' /> instance.
        /// </summary>
        /// <returns>
        ///     A newly instantiated <see cref='ReportParamPageModel' /> instance.
        /// </returns>
        public LocalReportParamPageModel Create()
        {
            return new LocalReportParamPageModel(this.Provider);
        }

        /// <summary>
        ///     Retrieves all instances of the <see cref='ReportParamPageModel' /> class.
        /// </summary>
        /// <returns>
        ///     An enumerable collection of <see cref='ReportParamPageModel' /> instances.
        /// </returns>
        public IEnumerable<LocalReportParamPageModel> FetchAll()
        {
            IEnumerable<ReportParampageRecord> recordCollection = this.Provider.DataProvider.Reporting.ReportParamPage.FetchAll();
            foreach (ReportParampageRecord record in recordCollection)
            {
                if (record != null)
                {
                    yield return new LocalReportParamPageModel(this.Provider, record);
                }
            }
        }

        /// <summary>
        ///     Retrieves a specific <see cref='ReportParamPageModel' /> instance.
        /// </summary>
        /// <param name="id">
        ///     The unique value which distinctly identifies the <see cref='ReportParamPageModel' /> instance to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref='ReportParamPageModel' /> instance that matches the specified <paramref name='id' />; or null, if no matching instance can be found.
        /// </returns>
        public LocalReportParamPageModel FetchById(Int32 id)
        {
            ReportParampageRecord record = this.Provider.DataProvider.Reporting.ReportParamPage.FetchById(id);
            if (record == null)
                return null;
            return new LocalReportParamPageModel(this.Provider, record);
        }

        /// <summary>
        ///     Gets the underlying database table name for <see cref='ReportParamPage/>.
        /// </summary>
        /// <returns>
        ///     The table name.
        /// </returns>
        public String GetTableName()
        {
            return this.Provider.DataProvider.Reporting.ReportParamPage.TableName;
        }

        #endregion

        #region implementations

        /// <summary>
        ///     Creates a new <see cref="!:ReportParamPageModel" /> instance.
        /// </summary>
        /// <returns>
        ///     A newly instantiated <see cref="!:ReportParamPageModel" /> instance.
        /// </returns>
        Consensus.Reporting.IReportParamPageModel IReportParamPageFactory.Create()
        {
            return this.Create();
        }

        /// <summary>
        ///     Retrieves all instances of the <see cref="!:ReportParamPageModel" /> class.
        /// </summary>
        /// <returns>
        ///     An enumerable collection of <see cref="!:ReportParamPageModel" /> instances.
        /// </returns>
        System.Collections.Generic.IEnumerable<Consensus.Reporting.IReportParamPageModel> IReportParamPageFactory.FetchAll()
        {
            return this.FetchAll();
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
        Consensus.Reporting.IReportParamPageModel IReportParamPageFactory.FetchById(System.Int32 id)
        {
            return this.FetchById(id);
        }

        System.String IReportParamPageFactory.GetTableName()
        {
            return this.GetTableName();
        }

        #endregion
    }
}
