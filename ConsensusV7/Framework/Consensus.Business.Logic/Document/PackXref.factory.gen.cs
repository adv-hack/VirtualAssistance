using System;
using System.Collections.Generic;
using System.Linq;

namespace Consensus.Document
{
    /// <summary>
    ///     Supports the instantiation of the <see cref="PackXrefModel" /> object.
    /// </summary>
    /// <remarks>
    ///     THIS CODE HAS BEEN AUTOMATICALLY GENERATED USING THE CONSENSUS DEVELOPER TOOLS.
    ///     DO NOT EDIT THIS CODE AS ANY CUSTOM MODIFICATIONS WILL BE LOST UPON REGENERATION.
    /// </remarks>
    public partial class LocalPackXrefFactory : LocalFactory<LocalPackXrefModel, PackXrefRecord, String>, IPackXrefFactory
    {
        #region methods

        /// <summary>
        ///     Creates a new <see cref='PackXrefModel' /> instance.
        /// </summary>
        /// <returns>
        ///     A newly instantiated <see cref='PackXrefModel' /> instance.
        /// </returns>
        public LocalPackXrefModel Create()
        {
            return new LocalPackXrefModel(this.Provider);
        }

        /// <summary>
        ///     Retrieves all instances of the <see cref='PackXrefModel' /> class.
        /// </summary>
        /// <returns>
        ///     An enumerable collection of <see cref='PackXrefModel' /> instances.
        /// </returns>
        public IEnumerable<LocalPackXrefModel> FetchAll()
        {
            IEnumerable<PackXrefRecord> recordCollection = this.Provider.DataProvider.Document.PackXref.FetchAll();
            foreach (PackXrefRecord record in recordCollection)
            {
                if (record != null)
                {
                    yield return new LocalPackXrefModel(this.Provider, record);
                }
            }
        }

        /// <summary>
        ///     Retrieves a specific <see cref='PackXrefModel' /> instance.
        /// </summary>
        /// <param name="id">
        ///     The unique value which distinctly identifies the <see cref='PackXrefModel' /> instance to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref='PackXrefModel' /> instance that matches the specified <paramref name='id' />; or null, if no matching instance can be found.
        /// </returns>
        public LocalPackXrefModel FetchById(String id)
        {
            PackXrefRecord record = this.Provider.DataProvider.Document.PackXref.FetchById(id);
            if (record == null)
                return null;
            return new LocalPackXrefModel(this.Provider, record);
        }

        /// <summary>
        ///     Gets the underlying database table name for <see cref='PackXref/>.
        /// </summary>
        /// <returns>
        ///     The table name.
        /// </returns>
        public String GetTableName()
        {
            return this.Provider.DataProvider.Document.PackXref.TableName;
        }

        /// <summary>
        ///     Retrieves a collection of <see cref='PackXrefModel' /> instances.
        /// </summary>
        /// <param name="packIdId">
        ///     The value which identifies the <see cref='PackXrefModel' /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref='PackXrefModel' /> instances that match the specified <paramref name='packIdId' />.
        /// </returns>
        public IEnumerable<LocalPackXrefModel> FetchAllByPackIdId(String packIdId)
        {
            IEnumerable<PackXrefRecord> recordCollection = this.Provider.DataProvider.Document.PackXref.FetchAllByPackId(packIdId);
            foreach (PackXrefRecord record in recordCollection)
            {
                if (record != null)
                {
                    yield return new LocalPackXrefModel(this.Provider, record);
                }
            }
        }

        /// <summary>
        ///     Retrieves a collection of <see cref='PackXrefModel' /> instances.
        /// </summary>
        /// <param name="litIdId">
        ///     The value which identifies the <see cref='PackXrefModel' /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref='PackXrefModel' /> instances that match the specified <paramref name='litIdId' />.
        /// </returns>
        public IEnumerable<LocalPackXrefModel> FetchAllByLitIdId(String litIdId)
        {
            IEnumerable<PackXrefRecord> recordCollection = this.Provider.DataProvider.Document.PackXref.FetchAllByLitId(litIdId);
            foreach (PackXrefRecord record in recordCollection)
            {
                if (record != null)
                {
                    yield return new LocalPackXrefModel(this.Provider, record);
                }
            }
        }

        /// <summary>
        ///     Retrieves a collection of <see cref='PackXrefModel' /> instances.
        /// </summary>
        /// <param name="smsIdId">
        ///     The value which identifies the <see cref='PackXrefModel' /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref='PackXrefModel' /> instances that match the specified <paramref name='smsIdId' />.
        /// </returns>
        public IEnumerable<LocalPackXrefModel> FetchAllBySmsIdId(Int32? smsIdId)
        {
            IEnumerable<PackXrefRecord> recordCollection = this.Provider.DataProvider.Document.PackXref.FetchAllBySmsId(smsIdId);
            foreach (PackXrefRecord record in recordCollection)
            {
                if (record != null)
                {
                    yield return new LocalPackXrefModel(this.Provider, record);
                }
            }
        }

        /// <summary>
        ///     Retrieves a collection of <see cref='PackXrefModel' /> instances.
        /// </summary>
        /// <param name="icmIdId">
        ///     The value which identifies the <see cref='PackXrefModel' /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref='PackXrefModel' /> instances that match the specified <paramref name='icmIdId' />.
        /// </returns>
        public IEnumerable<LocalPackXrefModel> FetchAllByIcmIdId(Int32? icmIdId)
        {
            IEnumerable<PackXrefRecord> recordCollection = this.Provider.DataProvider.Document.PackXref.FetchAllByIcmId(icmIdId);
            foreach (PackXrefRecord record in recordCollection)
            {
                if (record != null)
                {
                    yield return new LocalPackXrefModel(this.Provider, record);
                }
            }
        }

        #endregion

        #region implementations

        /// <summary>
        ///     Creates a new <see cref="!:PackXrefModel" /> instance.
        /// </summary>
        /// <returns>
        ///     A newly instantiated <see cref="!:PackXrefModel" /> instance.
        /// </returns>
        Consensus.Document.IPackXrefModel IPackXrefFactory.Create()
        {
            return this.Create();
        }

        /// <summary>
        ///     Retrieves all instances of the <see cref="!:PackXrefModel" /> class.
        /// </summary>
        /// <returns>
        ///     An enumerable collection of <see cref="!:PackXrefModel" /> instances.
        /// </returns>
        System.Collections.Generic.IEnumerable<Consensus.Document.IPackXrefModel> IPackXrefFactory.FetchAll()
        {
            return this.FetchAll();
        }

        /// <summary>
        ///     Retrieves a specific <see cref="!:PackXrefModel" /> instance.
        /// </summary>
        /// <param name="id">
        ///     The unique value which distinctly identifies the <see cref="!:PackXrefModel" /> instance to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:PackXrefModel" /> instance that matches the specified <paramref name="id" />; or null, if no matching instance can be found.
        /// </returns>
        Consensus.Document.IPackXrefModel IPackXrefFactory.FetchById(System.String id)
        {
            return this.FetchById(id);
        }

        System.String IPackXrefFactory.GetTableName()
        {
            return this.GetTableName();
        }

        /// <summary>
        ///     Retrieves a collection of <see cref="!:PackXrefModel" /> instances.
        /// </summary>
        /// <param name="packIdId">
        ///     The value which identifies the <see cref="!:PackXrefModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:PackXrefModel" /> instances that match the specified <paramref name="packIdId" />.
        /// </returns>
        System.Collections.Generic.IEnumerable<Consensus.Document.IPackXrefModel> IPackXrefFactory.FetchAllByPackIdId(System.String packIdId)
        {
            return this.FetchAllByPackIdId(packIdId);
        }

        /// <summary>
        ///     Retrieves a collection of <see cref="!:PackXrefModel" /> instances.
        /// </summary>
        /// <param name="litIdId">
        ///     The value which identifies the <see cref="!:PackXrefModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:PackXrefModel" /> instances that match the specified <paramref name="litIdId" />.
        /// </returns>
        System.Collections.Generic.IEnumerable<Consensus.Document.IPackXrefModel> IPackXrefFactory.FetchAllByLitIdId(System.String litIdId)
        {
            return this.FetchAllByLitIdId(litIdId);
        }

        System.Collections.Generic.IEnumerable<Consensus.Document.IPackXrefModel> IPackXrefFactory.FetchAllBySmsIdId(System.Nullable<System.Int32> smsIdId)
        {
            return this.FetchAllBySmsIdId(smsIdId);
        }

        System.Collections.Generic.IEnumerable<Consensus.Document.IPackXrefModel> IPackXrefFactory.FetchAllByIcmIdId(System.Nullable<System.Int32> icmIdId)
        {
            return this.FetchAllByIcmIdId(icmIdId);
        }

        #endregion
    }
}
