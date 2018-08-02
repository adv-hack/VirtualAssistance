using System;
using System.Collections.Generic;
using System.Linq;

namespace Consensus.Reporting
{
    /// <summary>
    ///     Supports the instantiation of the <see cref="ReportModel" /> object.
    /// </summary>
    /// <remarks>
    ///     THIS CODE HAS BEEN AUTOMATICALLY GENERATED USING THE CONSENSUS DEVELOPER TOOLS.
    ///     DO NOT EDIT THIS CODE AS ANY CUSTOM MODIFICATIONS WILL BE LOST UPON REGENERATION.
    /// </remarks>
    public partial class LocalReportFactory : LocalFactory<LocalReportModel, ReportRecord, String>, IReportFactory
    {
        #region methods

        /// <summary>
        ///     Creates a new <see cref='ReportModel' /> instance.
        /// </summary>
        /// <returns>
        ///     A newly instantiated <see cref='ReportModel' /> instance.
        /// </returns>
        public LocalReportModel Create()
        {
            return new LocalReportModel(this.Provider);
        }

        /// <summary>
        ///     Retrieves all instances of the <see cref='ReportModel' /> class.
        /// </summary>
        /// <returns>
        ///     An enumerable collection of <see cref='ReportModel' /> instances.
        /// </returns>
        public IEnumerable<LocalReportModel> FetchAll()
        {
            IEnumerable<ReportRecord> recordCollection = this.Provider.DataProvider.Reporting.Report.FetchAll();
            foreach (ReportRecord record in recordCollection)
            {
                if (record != null)
                {
                    yield return new LocalReportModel(this.Provider, record);
                }
            }
        }

        /// <summary>
        ///     Retrieves a specific <see cref='ReportModel' /> instance.
        /// </summary>
        /// <param name="id">
        ///     The unique value which distinctly identifies the <see cref='ReportModel' /> instance to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref='ReportModel' /> instance that matches the specified <paramref name='id' />; or null, if no matching instance can be found.
        /// </returns>
        public LocalReportModel FetchById(String id)
        {
            ReportRecord record = this.Provider.DataProvider.Reporting.Report.FetchById(id);
            if (record == null)
                return null;
            return new LocalReportModel(this.Provider, record);
        }

        /// <summary>
        ///     Gets the underlying database table name for <see cref='Report/>.
        /// </summary>
        /// <returns>
        ///     The table name.
        /// </returns>
        public String GetTableName()
        {
            return this.Provider.DataProvider.Reporting.Report.TableName;
        }

        /// <summary>
        ///     Retrieves a collection of <see cref='ReportModel' /> instances.
        /// </summary>
        /// <param name="reportPageId">
        ///     The value which identifies the <see cref='ReportModel' /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref='ReportModel' /> instances that match the specified <paramref name='reportPageId' />.
        /// </returns>
        public IEnumerable<LocalReportModel> FetchAllByReportPageId(Int32? reportPageId)
        {
            IEnumerable<ReportRecord> recordCollection = this.Provider.DataProvider.Reporting.Report.FetchAllByRptpId(reportPageId);
            foreach (ReportRecord record in recordCollection)
            {
                if (record != null)
                {
                    yield return new LocalReportModel(this.Provider, record);
                }
            }
        }

        /// <summary>
        ///     Retrieves a collection of <see cref='ReportModel' /> instances.
        /// </summary>
        /// <param name="reportParamPageId">
        ///     The value which identifies the <see cref='ReportModel' /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref='ReportModel' /> instances that match the specified <paramref name='reportParamPageId' />.
        /// </returns>
        public IEnumerable<LocalReportModel> FetchAllByReportParamPageId(Int32? reportParamPageId)
        {
            IEnumerable<ReportRecord> recordCollection = this.Provider.DataProvider.Reporting.Report.FetchAllByRppId(reportParamPageId);
            foreach (ReportRecord record in recordCollection)
            {
                if (record != null)
                {
                    yield return new LocalReportModel(this.Provider, record);
                }
            }
        }

        #endregion

        #region implementations

        /// <summary>
        ///     Creates a new <see cref="!:ReportModel" /> instance.
        /// </summary>
        /// <returns>
        ///     A newly instantiated <see cref="!:ReportModel" /> instance.
        /// </returns>
        Consensus.Reporting.IReportModel IReportFactory.Create()
        {
            return this.Create();
        }

        /// <summary>
        ///     Retrieves all instances of the <see cref="!:ReportModel" /> class.
        /// </summary>
        /// <returns>
        ///     An enumerable collection of <see cref="!:ReportModel" /> instances.
        /// </returns>
        System.Collections.Generic.IEnumerable<Consensus.Reporting.IReportModel> IReportFactory.FetchAll()
        {
            return this.FetchAll();
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
        Consensus.Reporting.IReportModel IReportFactory.FetchById(System.String id)
        {
            return this.FetchById(id);
        }

        System.String IReportFactory.GetTableName()
        {
            return this.GetTableName();
        }

        System.Collections.Generic.IEnumerable<Consensus.Reporting.IReportModel> IReportFactory.FetchAllByReportPageId(System.Nullable<System.Int32> reportPageId)
        {
            return this.FetchAllByReportPageId(reportPageId);
        }

        System.Collections.Generic.IEnumerable<Consensus.Reporting.IReportModel> IReportFactory.FetchAllByReportParamPageId(System.Nullable<System.Int32> reportParamPageId)
        {
            return this.FetchAllByReportParamPageId(reportParamPageId);
        }

        #endregion
    }
}
