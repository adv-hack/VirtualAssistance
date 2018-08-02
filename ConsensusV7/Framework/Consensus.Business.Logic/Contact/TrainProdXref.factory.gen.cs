using System;
using System.Collections.Generic;
using System.Linq;

namespace Consensus.Contact
{
    /// <summary>
    ///     Supports the instantiation of the <see cref="TrainProdXrefModel" /> object.
    /// </summary>
    /// <remarks>
    ///     THIS CODE HAS BEEN AUTOMATICALLY GENERATED USING THE CONSENSUS DEVELOPER TOOLS.
    ///     DO NOT EDIT THIS CODE AS ANY CUSTOM MODIFICATIONS WILL BE LOST UPON REGENERATION.
    /// </remarks>
    public partial class LocalTrainProdXrefFactory : LocalFactory<LocalTrainProdXrefModel, TrainProdXrefRecord, String>, ITrainProdXrefFactory
    {
        #region methods

        /// <summary>
        ///     Creates a new <see cref='TrainProdXrefModel' /> instance.
        /// </summary>
        /// <returns>
        ///     A newly instantiated <see cref='TrainProdXrefModel' /> instance.
        /// </returns>
        public LocalTrainProdXrefModel Create()
        {
            return new LocalTrainProdXrefModel(this.Provider);
        }

        /// <summary>
        ///     Retrieves all instances of the <see cref='TrainProdXrefModel' /> class.
        /// </summary>
        /// <returns>
        ///     An enumerable collection of <see cref='TrainProdXrefModel' /> instances.
        /// </returns>
        public IEnumerable<LocalTrainProdXrefModel> FetchAll()
        {
            IEnumerable<TrainProdXrefRecord> recordCollection = this.Provider.DataProvider.Contact.TrainProdXref.FetchAll();
            foreach (TrainProdXrefRecord record in recordCollection)
            {
                if (record != null)
                {
                    yield return new LocalTrainProdXrefModel(this.Provider, record);
                }
            }
        }

        /// <summary>
        ///     Retrieves a specific <see cref='TrainProdXrefModel' /> instance.
        /// </summary>
        /// <param name="id">
        ///     The unique value which distinctly identifies the <see cref='TrainProdXrefModel' /> instance to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref='TrainProdXrefModel' /> instance that matches the specified <paramref name='id' />; or null, if no matching instance can be found.
        /// </returns>
        public LocalTrainProdXrefModel FetchById(String id)
        {
            TrainProdXrefRecord record = this.Provider.DataProvider.Contact.TrainProdXref.FetchById(id);
            if (record == null)
                return null;
            return new LocalTrainProdXrefModel(this.Provider, record);
        }

        /// <summary>
        ///     Gets the underlying database table name for <see cref='TrainProdXref/>.
        /// </summary>
        /// <returns>
        ///     The table name.
        /// </returns>
        public String GetTableName()
        {
            return this.Provider.DataProvider.Contact.TrainProdXref.TableName;
        }

        /// <summary>
        ///     Retrieves a collection of <see cref='TrainProdXrefModel' /> instances.
        /// </summary>
        /// <param name="trainerId">
        ///     The value which identifies the <see cref='TrainProdXrefModel' /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref='TrainProdXrefModel' /> instances that match the specified <paramref name='trainerId' />.
        /// </returns>
        public IEnumerable<LocalTrainProdXrefModel> FetchAllByTrainerId(String trainerId)
        {
            IEnumerable<TrainProdXrefRecord> recordCollection = this.Provider.DataProvider.Contact.TrainProdXref.FetchAllByTrainId(trainerId);
            foreach (TrainProdXrefRecord record in recordCollection)
            {
                if (record != null)
                {
                    yield return new LocalTrainProdXrefModel(this.Provider, record);
                }
            }
        }

        /// <summary>
        ///     Retrieves a collection of <see cref='TrainProdXrefModel' /> instances.
        /// </summary>
        /// <param name="productId">
        ///     The value which identifies the <see cref='TrainProdXrefModel' /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref='TrainProdXrefModel' /> instances that match the specified <paramref name='productId' />.
        /// </returns>
        public IEnumerable<LocalTrainProdXrefModel> FetchAllByProductId(String productId)
        {
            IEnumerable<TrainProdXrefRecord> recordCollection = this.Provider.DataProvider.Contact.TrainProdXref.FetchAllByProdId(productId);
            foreach (TrainProdXrefRecord record in recordCollection)
            {
                if (record != null)
                {
                    yield return new LocalTrainProdXrefModel(this.Provider, record);
                }
            }
        }

        #endregion

        #region implementations

        /// <summary>
        ///     Creates a new <see cref="!:TrainProdXrefModel" /> instance.
        /// </summary>
        /// <returns>
        ///     A newly instantiated <see cref="!:TrainProdXrefModel" /> instance.
        /// </returns>
        Consensus.Contact.ITrainProdXrefModel ITrainProdXrefFactory.Create()
        {
            return this.Create();
        }

        /// <summary>
        ///     Retrieves all instances of the <see cref="!:TrainProdXrefModel" /> class.
        /// </summary>
        /// <returns>
        ///     An enumerable collection of <see cref="!:TrainProdXrefModel" /> instances.
        /// </returns>
        System.Collections.Generic.IEnumerable<Consensus.Contact.ITrainProdXrefModel> ITrainProdXrefFactory.FetchAll()
        {
            return this.FetchAll();
        }

        /// <summary>
        ///     Retrieves a specific <see cref="!:TrainProdXrefModel" /> instance.
        /// </summary>
        /// <param name="id">
        ///     The unique value which distinctly identifies the <see cref="!:TrainProdXrefModel" /> instance to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:TrainProdXrefModel" /> instance that matches the specified <paramref name="id" />; or null, if no matching instance can be found.
        /// </returns>
        Consensus.Contact.ITrainProdXrefModel ITrainProdXrefFactory.FetchById(System.String id)
        {
            return this.FetchById(id);
        }

        System.String ITrainProdXrefFactory.GetTableName()
        {
            return this.GetTableName();
        }

        /// <summary>
        ///     Retrieves a collection of <see cref="!:TrainProdXrefModel" /> instances.
        /// </summary>
        /// <param name="trainerId">
        ///     The value which identifies the <see cref="!:TrainProdXrefModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:TrainProdXrefModel" /> instances that match the specified <paramref name="trainerId" />.
        /// </returns>
        System.Collections.Generic.IEnumerable<Consensus.Contact.ITrainProdXrefModel> ITrainProdXrefFactory.FetchAllByTrainerId(System.String trainerId)
        {
            return this.FetchAllByTrainerId(trainerId);
        }

        /// <summary>
        ///     Retrieves a collection of <see cref="!:TrainProdXrefModel" /> instances.
        /// </summary>
        /// <param name="productId">
        ///     The value which identifies the <see cref="!:TrainProdXrefModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:TrainProdXrefModel" /> instances that match the specified <paramref name="productId" />.
        /// </returns>
        System.Collections.Generic.IEnumerable<Consensus.Contact.ITrainProdXrefModel> ITrainProdXrefFactory.FetchAllByProductId(System.String productId)
        {
            return this.FetchAllByProductId(productId);
        }

        #endregion
    }
}
