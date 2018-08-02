using System;
using System.Collections.Generic;
using System.Linq;

namespace Consensus.Logistics
{
    /// <summary>
    ///     Supports the instantiation of the <see cref="ProjectModel" /> object.
    /// </summary>
    /// <remarks>
    ///     THIS CODE HAS BEEN AUTOMATICALLY GENERATED USING THE CONSENSUS DEVELOPER TOOLS.
    ///     DO NOT EDIT THIS CODE AS ANY CUSTOM MODIFICATIONS WILL BE LOST UPON REGENERATION.
    /// </remarks>
    public partial class LocalProjectFactory : LocalFactory<LocalProjectModel, ProjectRecord, String>, IProjectFactory
    {
        #region methods

        /// <summary>
        ///     Creates a new <see cref='ProjectModel' /> instance.
        /// </summary>
        /// <returns>
        ///     A newly instantiated <see cref='ProjectModel' /> instance.
        /// </returns>
        public LocalProjectModel Create()
        {
            return new LocalProjectModel(this.Provider);
        }

        /// <summary>
        ///     Retrieves all instances of the <see cref='ProjectModel' /> class.
        /// </summary>
        /// <returns>
        ///     An enumerable collection of <see cref='ProjectModel' /> instances.
        /// </returns>
        public IEnumerable<LocalProjectModel> FetchAll()
        {
            IEnumerable<ProjectRecord> recordCollection = this.Provider.DataProvider.Logistics.Project.FetchAll();
            foreach (ProjectRecord record in recordCollection)
            {
                if (record != null)
                {
                    yield return new LocalProjectModel(this.Provider, record);
                }
            }
        }

        /// <summary>
        ///     Retrieves a specific <see cref='ProjectModel' /> instance.
        /// </summary>
        /// <param name="id">
        ///     The unique value which distinctly identifies the <see cref='ProjectModel' /> instance to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref='ProjectModel' /> instance that matches the specified <paramref name='id' />; or null, if no matching instance can be found.
        /// </returns>
        public LocalProjectModel FetchById(String id)
        {
            ProjectRecord record = this.Provider.DataProvider.Logistics.Project.FetchById(id);
            if (record == null)
                return null;
            return new LocalProjectModel(this.Provider, record);
        }

        /// <summary>
        ///     Gets the underlying database table name for <see cref='Project/>.
        /// </summary>
        /// <returns>
        ///     The table name.
        /// </returns>
        public String GetTableName()
        {
            return this.Provider.DataProvider.Logistics.Project.TableName;
        }

        #endregion

        #region implementations

        /// <summary>
        ///     Creates a new <see cref="!:ProjectModel" /> instance.
        /// </summary>
        /// <returns>
        ///     A newly instantiated <see cref="!:ProjectModel" /> instance.
        /// </returns>
        Consensus.Logistics.IProjectModel IProjectFactory.Create()
        {
            return this.Create();
        }

        /// <summary>
        ///     Retrieves all instances of the <see cref="!:ProjectModel" /> class.
        /// </summary>
        /// <returns>
        ///     An enumerable collection of <see cref="!:ProjectModel" /> instances.
        /// </returns>
        System.Collections.Generic.IEnumerable<Consensus.Logistics.IProjectModel> IProjectFactory.FetchAll()
        {
            return this.FetchAll();
        }

        /// <summary>
        ///     Retrieves a specific <see cref="!:ProjectModel" /> instance.
        /// </summary>
        /// <param name="id">
        ///     The unique value which distinctly identifies the <see cref="!:ProjectModel" /> instance to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:ProjectModel" /> instance that matches the specified <paramref name="id" />; or null, if no matching instance can be found.
        /// </returns>
        Consensus.Logistics.IProjectModel IProjectFactory.FetchById(System.String id)
        {
            return this.FetchById(id);
        }

        System.String IProjectFactory.GetTableName()
        {
            return this.GetTableName();
        }

        #endregion
    }
}
