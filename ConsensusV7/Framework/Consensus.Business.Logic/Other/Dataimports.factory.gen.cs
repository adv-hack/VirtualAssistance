using System;
using System.Collections.Generic;
using System.Linq;

namespace Consensus.Other
{
    /// <summary>
    ///     Supports the instantiation of the <see cref="DataimportsModel" /> object.
    /// </summary>
    /// <remarks>
    ///     THIS CODE HAS BEEN AUTOMATICALLY GENERATED USING THE CONSENSUS DEVELOPER TOOLS.
    ///     DO NOT EDIT THIS CODE AS ANY CUSTOM MODIFICATIONS WILL BE LOST UPON REGENERATION.
    /// </remarks>
    public partial class LocalDataimportsFactory : LocalFactory<LocalDataimportsModel, DataimportsRecord, Int32>, IDataimportsFactory
    {
        #region methods

        /// <summary>
        ///     Creates a new <see cref='DataimportsModel' /> instance.
        /// </summary>
        /// <returns>
        ///     A newly instantiated <see cref='DataimportsModel' /> instance.
        /// </returns>
        public LocalDataimportsModel Create()
        {
            return new LocalDataimportsModel(this.Provider);
        }

        /// <summary>
        ///     Retrieves all instances of the <see cref='DataimportsModel' /> class.
        /// </summary>
        /// <returns>
        ///     An enumerable collection of <see cref='DataimportsModel' /> instances.
        /// </returns>
        public IEnumerable<LocalDataimportsModel> FetchAll()
        {
            IEnumerable<DataimportsRecord> recordCollection = this.Provider.DataProvider.Other.Dataimports.FetchAll();
            foreach (DataimportsRecord record in recordCollection)
            {
                if (record != null)
                {
                    yield return new LocalDataimportsModel(this.Provider, record);
                }
            }
        }

        /// <summary>
        ///     Retrieves a specific <see cref='DataimportsModel' /> instance.
        /// </summary>
        /// <param name="id">
        ///     The unique value which distinctly identifies the <see cref='DataimportsModel' /> instance to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref='DataimportsModel' /> instance that matches the specified <paramref name='id' />; or null, if no matching instance can be found.
        /// </returns>
        public LocalDataimportsModel FetchById(Int32 id)
        {
            DataimportsRecord record = this.Provider.DataProvider.Other.Dataimports.FetchById(id);
            if (record == null)
                return null;
            return new LocalDataimportsModel(this.Provider, record);
        }

        /// <summary>
        ///     Gets the underlying database table name for <see cref='Dataimports/>.
        /// </summary>
        /// <returns>
        ///     The table name.
        /// </returns>
        public String GetTableName()
        {
            return this.Provider.DataProvider.Other.Dataimports.TableName;
        }

        #endregion

        #region implementations

        /// <summary>
        ///     Creates a new <see cref="!:DataimportsModel" /> instance.
        /// </summary>
        /// <returns>
        ///     A newly instantiated <see cref="!:DataimportsModel" /> instance.
        /// </returns>
        Consensus.Other.IDataimportsModel IDataimportsFactory.Create()
        {
            return this.Create();
        }

        /// <summary>
        ///     Retrieves all instances of the <see cref="!:DataimportsModel" /> class.
        /// </summary>
        /// <returns>
        ///     An enumerable collection of <see cref="!:DataimportsModel" /> instances.
        /// </returns>
        System.Collections.Generic.IEnumerable<Consensus.Other.IDataimportsModel> IDataimportsFactory.FetchAll()
        {
            return this.FetchAll();
        }

        /// <summary>
        ///     Retrieves a specific <see cref="!:DataimportsModel" /> instance.
        /// </summary>
        /// <param name="id">
        ///     The unique value which distinctly identifies the <see cref="!:DataimportsModel" /> instance to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:DataimportsModel" /> instance that matches the specified <paramref name="id" />; or null, if no matching instance can be found.
        /// </returns>
        Consensus.Other.IDataimportsModel IDataimportsFactory.FetchById(System.Int32 id)
        {
            return this.FetchById(id);
        }

        System.String IDataimportsFactory.GetTableName()
        {
            return this.GetTableName();
        }

        #endregion
    }
}
