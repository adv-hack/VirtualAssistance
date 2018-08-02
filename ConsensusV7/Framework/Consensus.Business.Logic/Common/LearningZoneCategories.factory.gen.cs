using System;
using System.Collections.Generic;
using System.Linq;

namespace Consensus.Common
{
    /// <summary>
    ///     Supports the instantiation of the <see cref="LearningZoneCategoriesModel" /> object.
    /// </summary>
    /// <remarks>
    ///     THIS CODE HAS BEEN AUTOMATICALLY GENERATED USING THE CONSENSUS DEVELOPER TOOLS.
    ///     DO NOT EDIT THIS CODE AS ANY CUSTOM MODIFICATIONS WILL BE LOST UPON REGENERATION.
    /// </remarks>
    public partial class LocalLearningZoneCategoriesFactory : LocalFactory<LocalLearningZoneCategoriesModel, LearningzonecategoriesRecord, Int32>, ILearningZoneCategoriesFactory
    {
        #region methods

        /// <summary>
        ///     Creates a new <see cref='LearningZoneCategoriesModel' /> instance.
        /// </summary>
        /// <returns>
        ///     A newly instantiated <see cref='LearningZoneCategoriesModel' /> instance.
        /// </returns>
        public LocalLearningZoneCategoriesModel Create()
        {
            return new LocalLearningZoneCategoriesModel(this.Provider);
        }

        /// <summary>
        ///     Retrieves all instances of the <see cref='LearningZoneCategoriesModel' /> class.
        /// </summary>
        /// <returns>
        ///     An enumerable collection of <see cref='LearningZoneCategoriesModel' /> instances.
        /// </returns>
        public IEnumerable<LocalLearningZoneCategoriesModel> FetchAll()
        {
            IEnumerable<LearningzonecategoriesRecord> recordCollection = this.Provider.DataProvider.Common.LearningZoneCategories.FetchAll();
            foreach (LearningzonecategoriesRecord record in recordCollection)
            {
                if (record != null)
                {
                    yield return new LocalLearningZoneCategoriesModel(this.Provider, record);
                }
            }
        }

        /// <summary>
        ///     Retrieves a specific <see cref='LearningZoneCategoriesModel' /> instance.
        /// </summary>
        /// <param name="id">
        ///     The unique value which distinctly identifies the <see cref='LearningZoneCategoriesModel' /> instance to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref='LearningZoneCategoriesModel' /> instance that matches the specified <paramref name='id' />; or null, if no matching instance can be found.
        /// </returns>
        public LocalLearningZoneCategoriesModel FetchById(Int32 id)
        {
            LearningzonecategoriesRecord record = this.Provider.DataProvider.Common.LearningZoneCategories.FetchById(id);
            if (record == null)
                return null;
            return new LocalLearningZoneCategoriesModel(this.Provider, record);
        }

        /// <summary>
        ///     Gets the underlying database table name for <see cref='LearningZoneCategories/>.
        /// </summary>
        /// <returns>
        ///     The table name.
        /// </returns>
        public String GetTableName()
        {
            return this.Provider.DataProvider.Common.LearningZoneCategories.TableName;
        }

        #endregion

        #region implementations

        /// <summary>
        ///     Creates a new <see cref="!:LearningZoneCategoriesModel" /> instance.
        /// </summary>
        /// <returns>
        ///     A newly instantiated <see cref="!:LearningZoneCategoriesModel" /> instance.
        /// </returns>
        Consensus.Common.ILearningZoneCategoriesModel ILearningZoneCategoriesFactory.Create()
        {
            return this.Create();
        }

        /// <summary>
        ///     Retrieves all instances of the <see cref="!:LearningZoneCategoriesModel" /> class.
        /// </summary>
        /// <returns>
        ///     An enumerable collection of <see cref="!:LearningZoneCategoriesModel" /> instances.
        /// </returns>
        System.Collections.Generic.IEnumerable<Consensus.Common.ILearningZoneCategoriesModel> ILearningZoneCategoriesFactory.FetchAll()
        {
            return this.FetchAll();
        }

        /// <summary>
        ///     Retrieves a specific <see cref="!:LearningZoneCategoriesModel" /> instance.
        /// </summary>
        /// <param name="id">
        ///     The unique value which distinctly identifies the <see cref="!:LearningZoneCategoriesModel" /> instance to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:LearningZoneCategoriesModel" /> instance that matches the specified <paramref name="id" />; or null, if no matching instance can be found.
        /// </returns>
        Consensus.Common.ILearningZoneCategoriesModel ILearningZoneCategoriesFactory.FetchById(System.Int32 id)
        {
            return this.FetchById(id);
        }

        System.String ILearningZoneCategoriesFactory.GetTableName()
        {
            return this.GetTableName();
        }

        #endregion
    }
}
