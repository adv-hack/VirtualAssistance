using System;
using System.Collections.Generic;
using System.Linq;

namespace Consensus.Common
{
    /// <summary>
    ///     Supports the instantiation of the <see cref="AttachLearningZoneCategoriesModel" /> object.
    /// </summary>
    /// <remarks>
    ///     THIS CODE HAS BEEN AUTOMATICALLY GENERATED USING THE CONSENSUS DEVELOPER TOOLS.
    ///     DO NOT EDIT THIS CODE AS ANY CUSTOM MODIFICATIONS WILL BE LOST UPON REGENERATION.
    /// </remarks>
    public partial class LocalAttachLearningZoneCategoriesFactory : LocalFactory<LocalAttachLearningZoneCategoriesModel, AttachlearningzonecategoriesRecord, Int32>, IAttachLearningZoneCategoriesFactory
    {
        #region methods

        /// <summary>
        ///     Creates a new <see cref='AttachLearningZoneCategoriesModel' /> instance.
        /// </summary>
        /// <returns>
        ///     A newly instantiated <see cref='AttachLearningZoneCategoriesModel' /> instance.
        /// </returns>
        public LocalAttachLearningZoneCategoriesModel Create()
        {
            return new LocalAttachLearningZoneCategoriesModel(this.Provider);
        }

        /// <summary>
        ///     Retrieves all instances of the <see cref='AttachLearningZoneCategoriesModel' /> class.
        /// </summary>
        /// <returns>
        ///     An enumerable collection of <see cref='AttachLearningZoneCategoriesModel' /> instances.
        /// </returns>
        public IEnumerable<LocalAttachLearningZoneCategoriesModel> FetchAll()
        {
            IEnumerable<AttachlearningzonecategoriesRecord> recordCollection = this.Provider.DataProvider.Common.AttachLearningZoneCategories.FetchAll();
            foreach (AttachlearningzonecategoriesRecord record in recordCollection)
            {
                if (record != null)
                {
                    yield return new LocalAttachLearningZoneCategoriesModel(this.Provider, record);
                }
            }
        }

        /// <summary>
        ///     Retrieves a specific <see cref='AttachLearningZoneCategoriesModel' /> instance.
        /// </summary>
        /// <param name="id">
        ///     The unique value which distinctly identifies the <see cref='AttachLearningZoneCategoriesModel' /> instance to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref='AttachLearningZoneCategoriesModel' /> instance that matches the specified <paramref name='id' />; or null, if no matching instance can be found.
        /// </returns>
        public LocalAttachLearningZoneCategoriesModel FetchById(Int32 id)
        {
            AttachlearningzonecategoriesRecord record = this.Provider.DataProvider.Common.AttachLearningZoneCategories.FetchById(id);
            if (record == null)
                return null;
            return new LocalAttachLearningZoneCategoriesModel(this.Provider, record);
        }

        /// <summary>
        ///     Gets the underlying database table name for <see cref='AttachLearningZoneCategories/>.
        /// </summary>
        /// <returns>
        ///     The table name.
        /// </returns>
        public String GetTableName()
        {
            return this.Provider.DataProvider.Common.AttachLearningZoneCategories.TableName;
        }

        /// <summary>
        ///     Retrieves a collection of <see cref='AttachLearningZoneCategoriesModel' /> instances.
        /// </summary>
        /// <param name="attIdId">
        ///     The value which identifies the <see cref='AttachLearningZoneCategoriesModel' /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref='AttachLearningZoneCategoriesModel' /> instances that match the specified <paramref name='attIdId' />.
        /// </returns>
        public IEnumerable<LocalAttachLearningZoneCategoriesModel> FetchAllByAttIdId(String attIdId)
        {
            IEnumerable<AttachlearningzonecategoriesRecord> recordCollection = this.Provider.DataProvider.Common.AttachLearningZoneCategories.FetchAllByAttId(attIdId);
            foreach (AttachlearningzonecategoriesRecord record in recordCollection)
            {
                if (record != null)
                {
                    yield return new LocalAttachLearningZoneCategoriesModel(this.Provider, record);
                }
            }
        }

        /// <summary>
        ///     Retrieves a collection of <see cref='AttachLearningZoneCategoriesModel' /> instances.
        /// </summary>
        /// <param name="lzcIdId">
        ///     The value which identifies the <see cref='AttachLearningZoneCategoriesModel' /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref='AttachLearningZoneCategoriesModel' /> instances that match the specified <paramref name='lzcIdId' />.
        /// </returns>
        public IEnumerable<LocalAttachLearningZoneCategoriesModel> FetchAllByLzcIdId(Int32 lzcIdId)
        {
            IEnumerable<AttachlearningzonecategoriesRecord> recordCollection = this.Provider.DataProvider.Common.AttachLearningZoneCategories.FetchAllByLzcId(lzcIdId);
            foreach (AttachlearningzonecategoriesRecord record in recordCollection)
            {
                if (record != null)
                {
                    yield return new LocalAttachLearningZoneCategoriesModel(this.Provider, record);
                }
            }
        }

        #endregion

        #region implementations

        /// <summary>
        ///     Creates a new <see cref="!:AttachLearningZoneCategoriesModel" /> instance.
        /// </summary>
        /// <returns>
        ///     A newly instantiated <see cref="!:AttachLearningZoneCategoriesModel" /> instance.
        /// </returns>
        Consensus.Common.IAttachLearningZoneCategoriesModel IAttachLearningZoneCategoriesFactory.Create()
        {
            return this.Create();
        }

        /// <summary>
        ///     Retrieves all instances of the <see cref="!:AttachLearningZoneCategoriesModel" /> class.
        /// </summary>
        /// <returns>
        ///     An enumerable collection of <see cref="!:AttachLearningZoneCategoriesModel" /> instances.
        /// </returns>
        System.Collections.Generic.IEnumerable<Consensus.Common.IAttachLearningZoneCategoriesModel> IAttachLearningZoneCategoriesFactory.FetchAll()
        {
            return this.FetchAll();
        }

        /// <summary>
        ///     Retrieves a specific <see cref="!:AttachLearningZoneCategoriesModel" /> instance.
        /// </summary>
        /// <param name="id">
        ///     The unique value which distinctly identifies the <see cref="!:AttachLearningZoneCategoriesModel" /> instance to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:AttachLearningZoneCategoriesModel" /> instance that matches the specified <paramref name="id" />; or null, if no matching instance can be found.
        /// </returns>
        Consensus.Common.IAttachLearningZoneCategoriesModel IAttachLearningZoneCategoriesFactory.FetchById(System.Int32 id)
        {
            return this.FetchById(id);
        }

        System.String IAttachLearningZoneCategoriesFactory.GetTableName()
        {
            return this.GetTableName();
        }

        /// <summary>
        ///     Retrieves a collection of <see cref="!:AttachLearningZoneCategoriesModel" /> instances.
        /// </summary>
        /// <param name="attIdId">
        ///     The value which identifies the <see cref="!:AttachLearningZoneCategoriesModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:AttachLearningZoneCategoriesModel" /> instances that match the specified <paramref name="attIdId" />.
        /// </returns>
        System.Collections.Generic.IEnumerable<Consensus.Common.IAttachLearningZoneCategoriesModel> IAttachLearningZoneCategoriesFactory.FetchAllByAttIdId(System.String attIdId)
        {
            return this.FetchAllByAttIdId(attIdId);
        }

        /// <summary>
        ///     Retrieves a collection of <see cref="!:AttachLearningZoneCategoriesModel" /> instances.
        /// </summary>
        /// <param name="lzcIdId">
        ///     The value which identifies the <see cref="!:AttachLearningZoneCategoriesModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:AttachLearningZoneCategoriesModel" /> instances that match the specified <paramref name="lzcIdId" />.
        /// </returns>
        System.Collections.Generic.IEnumerable<Consensus.Common.IAttachLearningZoneCategoriesModel> IAttachLearningZoneCategoriesFactory.FetchAllByLzcIdId(System.Int32 lzcIdId)
        {
            return this.FetchAllByLzcIdId(lzcIdId);
        }

        #endregion
    }
}
