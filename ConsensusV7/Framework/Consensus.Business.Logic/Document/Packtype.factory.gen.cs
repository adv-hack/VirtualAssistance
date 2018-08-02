using System;
using System.Collections.Generic;
using System.Linq;

namespace Consensus.Document
{
    /// <summary>
    ///     Supports the instantiation of the <see cref="PacktypeModel" /> object.
    /// </summary>
    /// <remarks>
    ///     THIS CODE HAS BEEN AUTOMATICALLY GENERATED USING THE CONSENSUS DEVELOPER TOOLS.
    ///     DO NOT EDIT THIS CODE AS ANY CUSTOM MODIFICATIONS WILL BE LOST UPON REGENERATION.
    /// </remarks>
    public partial class LocalPacktypeFactory : LocalFactory<LocalPacktypeModel, PacktypeRecord, Int32>, IPacktypeFactory
    {
        #region methods

        /// <summary>
        ///     Creates a new <see cref='PacktypeModel' /> instance.
        /// </summary>
        /// <returns>
        ///     A newly instantiated <see cref='PacktypeModel' /> instance.
        /// </returns>
        public LocalPacktypeModel Create()
        {
            return new LocalPacktypeModel(this.Provider);
        }

        /// <summary>
        ///     Retrieves all instances of the <see cref='PacktypeModel' /> class.
        /// </summary>
        /// <returns>
        ///     An enumerable collection of <see cref='PacktypeModel' /> instances.
        /// </returns>
        public IEnumerable<LocalPacktypeModel> FetchAll()
        {
            IEnumerable<PacktypeRecord> recordCollection = this.Provider.DataProvider.Document.Packtype.FetchAll();
            foreach (PacktypeRecord record in recordCollection)
            {
                if (record != null)
                {
                    yield return new LocalPacktypeModel(this.Provider, record);
                }
            }
        }

        /// <summary>
        ///     Retrieves a specific <see cref='PacktypeModel' /> instance.
        /// </summary>
        /// <param name="id">
        ///     The unique value which distinctly identifies the <see cref='PacktypeModel' /> instance to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref='PacktypeModel' /> instance that matches the specified <paramref name='id' />; or null, if no matching instance can be found.
        /// </returns>
        public LocalPacktypeModel FetchById(Int32 id)
        {
            PacktypeRecord record = this.Provider.DataProvider.Document.Packtype.FetchById(id);
            if (record == null)
                return null;
            return new LocalPacktypeModel(this.Provider, record);
        }

        /// <summary>
        ///     Gets the underlying database table name for <see cref='Packtype/>.
        /// </summary>
        /// <returns>
        ///     The table name.
        /// </returns>
        public String GetTableName()
        {
            return this.Provider.DataProvider.Document.Packtype.TableName;
        }

        #endregion

        #region implementations

        /// <summary>
        ///     Creates a new <see cref="!:PacktypeModel" /> instance.
        /// </summary>
        /// <returns>
        ///     A newly instantiated <see cref="!:PacktypeModel" /> instance.
        /// </returns>
        Consensus.Document.IPacktypeModel IPacktypeFactory.Create()
        {
            return this.Create();
        }

        /// <summary>
        ///     Retrieves all instances of the <see cref="!:PacktypeModel" /> class.
        /// </summary>
        /// <returns>
        ///     An enumerable collection of <see cref="!:PacktypeModel" /> instances.
        /// </returns>
        System.Collections.Generic.IEnumerable<Consensus.Document.IPacktypeModel> IPacktypeFactory.FetchAll()
        {
            return this.FetchAll();
        }

        /// <summary>
        ///     Retrieves a specific <see cref="!:PacktypeModel" /> instance.
        /// </summary>
        /// <param name="id">
        ///     The unique value which distinctly identifies the <see cref="!:PacktypeModel" /> instance to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:PacktypeModel" /> instance that matches the specified <paramref name="id" />; or null, if no matching instance can be found.
        /// </returns>
        Consensus.Document.IPacktypeModel IPacktypeFactory.FetchById(System.Int32 id)
        {
            return this.FetchById(id);
        }

        System.String IPacktypeFactory.GetTableName()
        {
            return this.GetTableName();
        }

        #endregion
    }
}
