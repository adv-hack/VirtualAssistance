using System;
using System.Collections.Generic;
using System.Linq;

namespace Consensus.Reporting
{
    /// <summary>
    ///     Supports the instantiation of the <see cref="ReportPageModel" /> object.
    /// </summary>
    /// <remarks>
    ///     THIS CODE HAS BEEN AUTOMATICALLY GENERATED USING THE CONSENSUS DEVELOPER TOOLS.
    ///     DO NOT EDIT THIS CODE AS ANY CUSTOM MODIFICATIONS WILL BE LOST UPON REGENERATION.
    /// </remarks>
    public partial class LocalReportPageFactory : LocalFactory<LocalReportPageModel, ReportPageRecord, Int32>, IReportPageFactory
    {
        #region methods

        /// <summary>
        ///     Creates a new <see cref='ReportPageModel' /> instance.
        /// </summary>
        /// <returns>
        ///     A newly instantiated <see cref='ReportPageModel' /> instance.
        /// </returns>
        public LocalReportPageModel Create()
        {
            return new LocalReportPageModel(this.Provider);
        }

        /// <summary>
        ///     Retrieves all instances of the <see cref='ReportPageModel' /> class.
        /// </summary>
        /// <returns>
        ///     An enumerable collection of <see cref='ReportPageModel' /> instances.
        /// </returns>
        public IEnumerable<LocalReportPageModel> FetchAll()
        {
            IEnumerable<ReportPageRecord> recordCollection = this.Provider.DataProvider.Reporting.ReportPage.FetchAll();
            foreach (ReportPageRecord record in recordCollection)
            {
                if (record != null)
                {
                    yield return new LocalReportPageModel(this.Provider, record);
                }
            }
        }

        /// <summary>
        ///     Retrieves a specific <see cref='ReportPageModel' /> instance.
        /// </summary>
        /// <param name="id">
        ///     The unique value which distinctly identifies the <see cref='ReportPageModel' /> instance to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref='ReportPageModel' /> instance that matches the specified <paramref name='id' />; or null, if no matching instance can be found.
        /// </returns>
        public LocalReportPageModel FetchById(Int32 id)
        {
            ReportPageRecord record = this.Provider.DataProvider.Reporting.ReportPage.FetchById(id);
            if (record == null)
                return null;
            return new LocalReportPageModel(this.Provider, record);
        }

        /// <summary>
        ///     Gets the underlying database table name for <see cref='ReportPage/>.
        /// </summary>
        /// <returns>
        ///     The table name.
        /// </returns>
        public String GetTableName()
        {
            return this.Provider.DataProvider.Reporting.ReportPage.TableName;
        }

        #endregion

        #region implementations

        /// <summary>
        ///     Creates a new <see cref="!:ReportPageModel" /> instance.
        /// </summary>
        /// <returns>
        ///     A newly instantiated <see cref="!:ReportPageModel" /> instance.
        /// </returns>
        Consensus.Reporting.IReportPageModel IReportPageFactory.Create()
        {
            return this.Create();
        }

        /// <summary>
        ///     Retrieves all instances of the <see cref="!:ReportPageModel" /> class.
        /// </summary>
        /// <returns>
        ///     An enumerable collection of <see cref="!:ReportPageModel" /> instances.
        /// </returns>
        System.Collections.Generic.IEnumerable<Consensus.Reporting.IReportPageModel> IReportPageFactory.FetchAll()
        {
            return this.FetchAll();
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
        Consensus.Reporting.IReportPageModel IReportPageFactory.FetchById(System.Int32 id)
        {
            return this.FetchById(id);
        }

        System.String IReportPageFactory.GetTableName()
        {
            return this.GetTableName();
        }

        #endregion
    }
}
