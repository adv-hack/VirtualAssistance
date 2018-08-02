using System;
using System.Collections.Generic;
using System.Linq;

namespace Consensus.UserInterface
{
    /// <summary>
    ///     Supports the instantiation of the <see cref="ScreenObjectModel" /> object.
    /// </summary>
    /// <remarks>
    ///     THIS CODE HAS BEEN AUTOMATICALLY GENERATED USING THE CONSENSUS DEVELOPER TOOLS.
    ///     DO NOT EDIT THIS CODE AS ANY CUSTOM MODIFICATIONS WILL BE LOST UPON REGENERATION.
    /// </remarks>
    public partial class LocalScreenObjectFactory : LocalFactory<LocalScreenObjectModel, ScreenObjectRecord, Int32>, IScreenObjectFactory
    {
        #region methods

        /// <summary>
        ///     Creates a new <see cref='ScreenObjectModel' /> instance.
        /// </summary>
        /// <returns>
        ///     A newly instantiated <see cref='ScreenObjectModel' /> instance.
        /// </returns>
        public LocalScreenObjectModel Create()
        {
            return new LocalScreenObjectModel(this.Provider);
        }

        /// <summary>
        ///     Retrieves all instances of the <see cref='ScreenObjectModel' /> class.
        /// </summary>
        /// <returns>
        ///     An enumerable collection of <see cref='ScreenObjectModel' /> instances.
        /// </returns>
        public IEnumerable<LocalScreenObjectModel> FetchAll()
        {
            IEnumerable<ScreenObjectRecord> recordCollection = this.Provider.DataProvider.UserInterface.ScreenObject.FetchAll();
            foreach (ScreenObjectRecord record in recordCollection)
            {
                if (record != null)
                {
                    yield return new LocalScreenObjectModel(this.Provider, record);
                }
            }
        }

        /// <summary>
        ///     Retrieves a specific <see cref='ScreenObjectModel' /> instance.
        /// </summary>
        /// <param name="id">
        ///     The unique value which distinctly identifies the <see cref='ScreenObjectModel' /> instance to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref='ScreenObjectModel' /> instance that matches the specified <paramref name='id' />; or null, if no matching instance can be found.
        /// </returns>
        public LocalScreenObjectModel FetchById(Int32 id)
        {
            ScreenObjectRecord record = this.Provider.DataProvider.UserInterface.ScreenObject.FetchById(id);
            if (record == null)
                return null;
            return new LocalScreenObjectModel(this.Provider, record);
        }

        /// <summary>
        ///     Gets the underlying database table name for <see cref='ScreenObject/>.
        /// </summary>
        /// <returns>
        ///     The table name.
        /// </returns>
        public String GetTableName()
        {
            return this.Provider.DataProvider.UserInterface.ScreenObject.TableName;
        }

        #endregion

        #region implementations

        /// <summary>
        ///     Updates the page configuration.
        /// </summary>
        void IScreenObjectFactory.Update(System.String url, System.Collections.ArrayList controls)
        {
            this.Update(url, controls);
        }

        /// <summary>
        ///     Creates a new <see cref="!:ScreenObjectModel" /> instance.
        /// </summary>
        /// <returns>
        ///     A newly instantiated <see cref="!:ScreenObjectModel" /> instance.
        /// </returns>
        Consensus.UserInterface.IScreenObjectModel IScreenObjectFactory.Create()
        {
            return this.Create();
        }

        /// <summary>
        ///     Retrieves all instances of the <see cref="!:ScreenObjectModel" /> class.
        /// </summary>
        /// <returns>
        ///     An enumerable collection of <see cref="!:ScreenObjectModel" /> instances.
        /// </returns>
        System.Collections.Generic.IEnumerable<Consensus.UserInterface.IScreenObjectModel> IScreenObjectFactory.FetchAll()
        {
            return this.FetchAll();
        }

        /// <summary>
        ///     Retrieves a specific <see cref="!:ScreenObjectModel" /> instance.
        /// </summary>
        /// <param name="id">
        ///     The unique value which distinctly identifies the <see cref="!:ScreenObjectModel" /> instance to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:ScreenObjectModel" /> instance that matches the specified <paramref name="id" />; or null, if no matching instance can be found.
        /// </returns>
        Consensus.UserInterface.IScreenObjectModel IScreenObjectFactory.FetchById(System.Int32 id)
        {
            return this.FetchById(id);
        }

        System.String IScreenObjectFactory.GetTableName()
        {
            return this.GetTableName();
        }

        #endregion
    }
}
