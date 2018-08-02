using System;
using System.Collections.Generic;
using System.Linq;

namespace Consensus.Other
{
    /// <summary>
    ///     Supports the instantiation of the <see cref="ExportconfigurationsModel" /> object.
    /// </summary>
    /// <remarks>
    ///     THIS CODE HAS BEEN AUTOMATICALLY GENERATED USING THE CONSENSUS DEVELOPER TOOLS.
    ///     DO NOT EDIT THIS CODE AS ANY CUSTOM MODIFICATIONS WILL BE LOST UPON REGENERATION.
    /// </remarks>
    public partial class LocalExportconfigurationsFactory : LocalFactory<LocalExportconfigurationsModel, ExportconfigurationsRecord, Int32>, IExportconfigurationsFactory
    {
        #region methods

        /// <summary>
        ///     Creates a new <see cref='ExportconfigurationsModel' /> instance.
        /// </summary>
        /// <returns>
        ///     A newly instantiated <see cref='ExportconfigurationsModel' /> instance.
        /// </returns>
        public LocalExportconfigurationsModel Create()
        {
            return new LocalExportconfigurationsModel(this.Provider);
        }

        /// <summary>
        ///     Retrieves all instances of the <see cref='ExportconfigurationsModel' /> class.
        /// </summary>
        /// <returns>
        ///     An enumerable collection of <see cref='ExportconfigurationsModel' /> instances.
        /// </returns>
        public IEnumerable<LocalExportconfigurationsModel> FetchAll()
        {
            IEnumerable<ExportconfigurationsRecord> recordCollection = this.Provider.DataProvider.Other.Exportconfigurations.FetchAll();
            foreach (ExportconfigurationsRecord record in recordCollection)
            {
                if (record != null)
                {
                    yield return new LocalExportconfigurationsModel(this.Provider, record);
                }
            }
        }

        /// <summary>
        ///     Retrieves a specific <see cref='ExportconfigurationsModel' /> instance.
        /// </summary>
        /// <param name="id">
        ///     The unique value which distinctly identifies the <see cref='ExportconfigurationsModel' /> instance to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref='ExportconfigurationsModel' /> instance that matches the specified <paramref name='id' />; or null, if no matching instance can be found.
        /// </returns>
        public LocalExportconfigurationsModel FetchById(Int32 id)
        {
            ExportconfigurationsRecord record = this.Provider.DataProvider.Other.Exportconfigurations.FetchById(id);
            if (record == null)
                return null;
            return new LocalExportconfigurationsModel(this.Provider, record);
        }

        /// <summary>
        ///     Gets the underlying database table name for <see cref='Exportconfigurations/>.
        /// </summary>
        /// <returns>
        ///     The table name.
        /// </returns>
        public String GetTableName()
        {
            return this.Provider.DataProvider.Other.Exportconfigurations.TableName;
        }

        #endregion

        #region implementations

        /// <summary>
        ///     Creates a new <see cref="!:ExportconfigurationsModel" /> instance.
        /// </summary>
        /// <returns>
        ///     A newly instantiated <see cref="!:ExportconfigurationsModel" /> instance.
        /// </returns>
        Consensus.Other.IExportconfigurationsModel IExportconfigurationsFactory.Create()
        {
            return this.Create();
        }

        /// <summary>
        ///     Retrieves all instances of the <see cref="!:ExportconfigurationsModel" /> class.
        /// </summary>
        /// <returns>
        ///     An enumerable collection of <see cref="!:ExportconfigurationsModel" /> instances.
        /// </returns>
        System.Collections.Generic.IEnumerable<Consensus.Other.IExportconfigurationsModel> IExportconfigurationsFactory.FetchAll()
        {
            return this.FetchAll();
        }

        /// <summary>
        ///     Retrieves a specific <see cref="!:ExportconfigurationsModel" /> instance.
        /// </summary>
        /// <param name="id">
        ///     The unique value which distinctly identifies the <see cref="!:ExportconfigurationsModel" /> instance to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:ExportconfigurationsModel" /> instance that matches the specified <paramref name="id" />; or null, if no matching instance can be found.
        /// </returns>
        Consensus.Other.IExportconfigurationsModel IExportconfigurationsFactory.FetchById(System.Int32 id)
        {
            return this.FetchById(id);
        }

        System.String IExportconfigurationsFactory.GetTableName()
        {
            return this.GetTableName();
        }

        #endregion
    }
}
