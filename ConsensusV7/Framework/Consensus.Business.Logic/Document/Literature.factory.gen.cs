using System;
using System.Collections.Generic;
using System.Linq;

namespace Consensus.Document
{
    /// <summary>
    ///     Supports the instantiation of the <see cref="LiteratureModel" /> object.
    /// </summary>
    /// <remarks>
    ///     THIS CODE HAS BEEN AUTOMATICALLY GENERATED USING THE CONSENSUS DEVELOPER TOOLS.
    ///     DO NOT EDIT THIS CODE AS ANY CUSTOM MODIFICATIONS WILL BE LOST UPON REGENERATION.
    /// </remarks>
    public partial class LocalLiteratureFactory : LocalFactory<LocalLiteratureModel, LiteratureRecord, String>, ILiteratureFactory
    {
        #region methods

        /// <summary>
        ///     Creates a new <see cref='LiteratureModel' /> instance.
        /// </summary>
        /// <returns>
        ///     A newly instantiated <see cref='LiteratureModel' /> instance.
        /// </returns>
        public LocalLiteratureModel Create()
        {
            return new LocalLiteratureModel(this.Provider);
        }

        /// <summary>
        ///     Retrieves all instances of the <see cref='LiteratureModel' /> class.
        /// </summary>
        /// <returns>
        ///     An enumerable collection of <see cref='LiteratureModel' /> instances.
        /// </returns>
        public IEnumerable<LocalLiteratureModel> FetchAll()
        {
            IEnumerable<LiteratureRecord> recordCollection = this.Provider.DataProvider.Document.Literature.FetchAll();
            foreach (LiteratureRecord record in recordCollection)
            {
                if (record != null)
                {
                    yield return new LocalLiteratureModel(this.Provider, record);
                }
            }
        }

        /// <summary>
        ///     Retrieves a specific <see cref='LiteratureModel' /> instance.
        /// </summary>
        /// <param name="id">
        ///     The unique value which distinctly identifies the <see cref='LiteratureModel' /> instance to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref='LiteratureModel' /> instance that matches the specified <paramref name='id' />; or null, if no matching instance can be found.
        /// </returns>
        public LocalLiteratureModel FetchById(String id)
        {
            LiteratureRecord record = this.Provider.DataProvider.Document.Literature.FetchById(id);
            if (record == null)
                return null;
            return new LocalLiteratureModel(this.Provider, record);
        }

        /// <summary>
        ///     Gets the underlying database table name for <see cref='Literature/>.
        /// </summary>
        /// <returns>
        ///     The table name.
        /// </returns>
        public String GetTableName()
        {
            return this.Provider.DataProvider.Document.Literature.TableName;
        }

        /// <summary>
        ///     Retrieves a collection of <see cref='LiteratureModel' /> instances.
        /// </summary>
        /// <param name="ltIdId">
        ///     The value which identifies the <see cref='LiteratureModel' /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref='LiteratureModel' /> instances that match the specified <paramref name='ltIdId' />.
        /// </returns>
        public IEnumerable<LocalLiteratureModel> FetchAllByLtIdId(String ltIdId)
        {
            IEnumerable<LiteratureRecord> recordCollection = this.Provider.DataProvider.Document.Literature.FetchAllByLtId(ltIdId);
            foreach (LiteratureRecord record in recordCollection)
            {
                if (record != null)
                {
                    yield return new LocalLiteratureModel(this.Provider, record);
                }
            }
        }

        #endregion

        #region implementations

        /// <summary>
        ///     Creates a new <see cref="!:LiteratureModel" /> instance.
        /// </summary>
        /// <returns>
        ///     A newly instantiated <see cref="!:LiteratureModel" /> instance.
        /// </returns>
        Consensus.Document.ILiteratureModel ILiteratureFactory.Create()
        {
            return this.Create();
        }

        /// <summary>
        ///     Retrieves all instances of the <see cref="!:LiteratureModel" /> class.
        /// </summary>
        /// <returns>
        ///     An enumerable collection of <see cref="!:LiteratureModel" /> instances.
        /// </returns>
        System.Collections.Generic.IEnumerable<Consensus.Document.ILiteratureModel> ILiteratureFactory.FetchAll()
        {
            return this.FetchAll();
        }

        /// <summary>
        ///     Retrieves a specific <see cref="!:LiteratureModel" /> instance.
        /// </summary>
        /// <param name="id">
        ///     The unique value which distinctly identifies the <see cref="!:LiteratureModel" /> instance to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:LiteratureModel" /> instance that matches the specified <paramref name="id" />; or null, if no matching instance can be found.
        /// </returns>
        Consensus.Document.ILiteratureModel ILiteratureFactory.FetchById(System.String id)
        {
            return this.FetchById(id);
        }

        System.String ILiteratureFactory.GetTableName()
        {
            return this.GetTableName();
        }

        /// <summary>
        ///     Retrieves a collection of <see cref="!:LiteratureModel" /> instances.
        /// </summary>
        /// <param name="ltIdId">
        ///     The value which identifies the <see cref="!:LiteratureModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:LiteratureModel" /> instances that match the specified <paramref name="ltIdId" />.
        /// </returns>
        System.Collections.Generic.IEnumerable<Consensus.Document.ILiteratureModel> ILiteratureFactory.FetchAllByLtIdId(System.String ltIdId)
        {
            return this.FetchAllByLtIdId(ltIdId);
        }

        #endregion
    }
}
