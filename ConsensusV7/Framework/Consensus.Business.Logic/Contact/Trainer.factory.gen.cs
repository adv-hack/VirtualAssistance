using System;
using System.Collections.Generic;
using System.Linq;

namespace Consensus.Contact
{
    /// <summary>
    ///     Supports the instantiation of the <see cref="TrainerModel" /> object.
    /// </summary>
    /// <remarks>
    ///     THIS CODE HAS BEEN AUTOMATICALLY GENERATED USING THE CONSENSUS DEVELOPER TOOLS.
    ///     DO NOT EDIT THIS CODE AS ANY CUSTOM MODIFICATIONS WILL BE LOST UPON REGENERATION.
    /// </remarks>
    public partial class LocalTrainerFactory : LocalFactory<LocalTrainerModel, TrainerRecord, String>, ITrainerFactory
    {
        #region methods

        /// <summary>
        ///     Creates a new <see cref='TrainerModel' /> instance.
        /// </summary>
        /// <returns>
        ///     A newly instantiated <see cref='TrainerModel' /> instance.
        /// </returns>
        public LocalTrainerModel Create()
        {
            return new LocalTrainerModel(this.Provider);
        }

        /// <summary>
        ///     Retrieves all instances of the <see cref='TrainerModel' /> class.
        /// </summary>
        /// <returns>
        ///     An enumerable collection of <see cref='TrainerModel' /> instances.
        /// </returns>
        public IEnumerable<LocalTrainerModel> FetchAll()
        {
            IEnumerable<TrainerRecord> recordCollection = this.Provider.DataProvider.Contact.Trainer.FetchAll();
            foreach (TrainerRecord record in recordCollection)
            {
                if (record != null)
                {
                    yield return new LocalTrainerModel(this.Provider, record);
                }
            }
        }

        /// <summary>
        ///     Retrieves a specific <see cref='TrainerModel' /> instance.
        /// </summary>
        /// <param name="id">
        ///     The unique value which distinctly identifies the <see cref='TrainerModel' /> instance to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref='TrainerModel' /> instance that matches the specified <paramref name='id' />; or null, if no matching instance can be found.
        /// </returns>
        public LocalTrainerModel FetchById(String id)
        {
            TrainerRecord record = this.Provider.DataProvider.Contact.Trainer.FetchById(id);
            if (record == null)
                return null;
            return new LocalTrainerModel(this.Provider, record);
        }

        /// <summary>
        ///     Gets the underlying database table name for <see cref='Trainer/>.
        /// </summary>
        /// <returns>
        ///     The table name.
        /// </returns>
        public String GetTableName()
        {
            return this.Provider.DataProvider.Contact.Trainer.TableName;
        }

        /// <summary>
        ///     Retrieves a collection of <see cref='TrainerModel' /> instances.
        /// </summary>
        /// <param name="roleId">
        ///     The value which identifies the <see cref='TrainerModel' /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref='TrainerModel' /> instances that match the specified <paramref name='roleId' />.
        /// </returns>
        public IEnumerable<LocalTrainerModel> FetchAllByRoleId(String roleId)
        {
            IEnumerable<TrainerRecord> recordCollection = this.Provider.DataProvider.Contact.Trainer.FetchAllByAinProleId(roleId);
            foreach (TrainerRecord record in recordCollection)
            {
                if (record != null)
                {
                    yield return new LocalTrainerModel(this.Provider, record);
                }
            }
        }

        /// <summary>
        ///     Retrieves a collection of <see cref='TrainerModel' /> instances.
        /// </summary>
        /// <param name="sellingCompanyId">
        ///     The value which identifies the <see cref='TrainerModel' /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref='TrainerModel' /> instances that match the specified <paramref name='sellingCompanyId' />.
        /// </returns>
        public IEnumerable<LocalTrainerModel> FetchAllBySellingCompanyId(String sellingCompanyId)
        {
            IEnumerable<TrainerRecord> recordCollection = this.Provider.DataProvider.Contact.Trainer.FetchAllByAinSelcoSpId(sellingCompanyId);
            foreach (TrainerRecord record in recordCollection)
            {
                if (record != null)
                {
                    yield return new LocalTrainerModel(this.Provider, record);
                }
            }
        }

        /// <summary>
        ///     Retrieves a collection of <see cref='TrainerModel' /> instances.
        /// </summary>
        /// <param name="feeNotesTextId">
        ///     The value which identifies the <see cref='TrainerModel' /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref='TrainerModel' /> instances that match the specified <paramref name='feeNotesTextId' />.
        /// </returns>
        public IEnumerable<LocalTrainerModel> FetchAllByFeeNotesTextId(String feeNotesTextId)
        {
            IEnumerable<TrainerRecord> recordCollection = this.Provider.DataProvider.Contact.Trainer.FetchAllByAinFeeNotesTextId(feeNotesTextId);
            foreach (TrainerRecord record in recordCollection)
            {
                if (record != null)
                {
                    yield return new LocalTrainerModel(this.Provider, record);
                }
            }
        }

        /// <summary>
        ///     Retrieves a collection of <see cref='TrainerModel' /> instances.
        /// </summary>
        /// <param name="hotelReqTextId">
        ///     The value which identifies the <see cref='TrainerModel' /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref='TrainerModel' /> instances that match the specified <paramref name='hotelReqTextId' />.
        /// </returns>
        public IEnumerable<LocalTrainerModel> FetchAllByHotelReqTextId(String hotelReqTextId)
        {
            IEnumerable<TrainerRecord> recordCollection = this.Provider.DataProvider.Contact.Trainer.FetchAllByAinHotelReqTextId(hotelReqTextId);
            foreach (TrainerRecord record in recordCollection)
            {
                if (record != null)
                {
                    yield return new LocalTrainerModel(this.Provider, record);
                }
            }
        }

        /// <summary>
        ///     Retrieves a collection of <see cref='TrainerModel' /> instances.
        /// </summary>
        /// <param name="otherInfoTextId">
        ///     The value which identifies the <see cref='TrainerModel' /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref='TrainerModel' /> instances that match the specified <paramref name='otherInfoTextId' />.
        /// </returns>
        public IEnumerable<LocalTrainerModel> FetchAllByOtherInfoTextId(String otherInfoTextId)
        {
            IEnumerable<TrainerRecord> recordCollection = this.Provider.DataProvider.Contact.Trainer.FetchAllByAinOtherInfoTextId(otherInfoTextId);
            foreach (TrainerRecord record in recordCollection)
            {
                if (record != null)
                {
                    yield return new LocalTrainerModel(this.Provider, record);
                }
            }
        }

        #endregion

        #region implementations

        /// <summary>
        ///     Check if Person exist or not.
        /// </summary>
        /// <param name="proleId">
        ///     ProleId of Role.
        /// </param>
        /// <param name="trainerId">
        ///     Id of Trainer.
        /// </param>
        /// <param name="syType">
        ///     Determines whether person is associate or trainer.
        /// </param>
        /// <returns>
        ///     Whether Person exist or not.
        /// </returns>
        System.Boolean ITrainerFactory.CheckIfPersonIsAssociatedWithTrainer(System.String proleId, System.String trainerId, System.String syType)
        {
            return this.CheckIfPersonIsAssociatedWithTrainer(proleId, trainerId, syType);
        }

        /// <summary>
        ///     Creates a new <see cref="!:TrainerModel" /> instance.
        /// </summary>
        /// <returns>
        ///     A newly instantiated <see cref="!:TrainerModel" /> instance.
        /// </returns>
        Consensus.Contact.ITrainerModel ITrainerFactory.Create()
        {
            return this.Create();
        }

        /// <summary>
        ///     Retrieves all instances of the <see cref="!:TrainerModel" /> class.
        /// </summary>
        /// <returns>
        ///     An enumerable collection of <see cref="!:TrainerModel" /> instances.
        /// </returns>
        System.Collections.Generic.IEnumerable<Consensus.Contact.ITrainerModel> ITrainerFactory.FetchAll()
        {
            return this.FetchAll();
        }

        /// <summary>
        ///     Retrieves a specific <see cref="!:TrainerModel" /> instance.
        /// </summary>
        /// <param name="id">
        ///     The unique value which distinctly identifies the <see cref="!:TrainerModel" /> instance to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:TrainerModel" /> instance that matches the specified <paramref name="id" />; or null, if no matching instance can be found.
        /// </returns>
        Consensus.Contact.ITrainerModel ITrainerFactory.FetchById(System.String id)
        {
            return this.FetchById(id);
        }

        System.String ITrainerFactory.GetTableName()
        {
            return this.GetTableName();
        }

        /// <summary>
        ///     Retrieves a collection of <see cref="!:TrainerModel" /> instances.
        /// </summary>
        /// <param name="roleId">
        ///     The value which identifies the <see cref="!:TrainerModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:TrainerModel" /> instances that match the specified <paramref name="roleId" />.
        /// </returns>
        System.Collections.Generic.IEnumerable<Consensus.Contact.ITrainerModel> ITrainerFactory.FetchAllByRoleId(System.String roleId)
        {
            return this.FetchAllByRoleId(roleId);
        }

        /// <summary>
        ///     Retrieves a collection of <see cref="!:TrainerModel" /> instances.
        /// </summary>
        /// <param name="sellingCompanyId">
        ///     The value which identifies the <see cref="!:TrainerModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:TrainerModel" /> instances that match the specified <paramref name="sellingCompanyId" />.
        /// </returns>
        System.Collections.Generic.IEnumerable<Consensus.Contact.ITrainerModel> ITrainerFactory.FetchAllBySellingCompanyId(System.String sellingCompanyId)
        {
            return this.FetchAllBySellingCompanyId(sellingCompanyId);
        }

        /// <summary>
        ///     Retrieves a collection of <see cref="!:TrainerModel" /> instances.
        /// </summary>
        /// <param name="feeNotesTextId">
        ///     The value which identifies the <see cref="!:TrainerModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:TrainerModel" /> instances that match the specified <paramref name="feeNotesTextId" />.
        /// </returns>
        System.Collections.Generic.IEnumerable<Consensus.Contact.ITrainerModel> ITrainerFactory.FetchAllByFeeNotesTextId(System.String feeNotesTextId)
        {
            return this.FetchAllByFeeNotesTextId(feeNotesTextId);
        }

        /// <summary>
        ///     Retrieves a collection of <see cref="!:TrainerModel" /> instances.
        /// </summary>
        /// <param name="hotelReqTextId">
        ///     The value which identifies the <see cref="!:TrainerModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:TrainerModel" /> instances that match the specified <paramref name="hotelReqTextId" />.
        /// </returns>
        System.Collections.Generic.IEnumerable<Consensus.Contact.ITrainerModel> ITrainerFactory.FetchAllByHotelReqTextId(System.String hotelReqTextId)
        {
            return this.FetchAllByHotelReqTextId(hotelReqTextId);
        }

        /// <summary>
        ///     Retrieves a collection of <see cref="!:TrainerModel" /> instances.
        /// </summary>
        /// <param name="otherInfoTextId">
        ///     The value which identifies the <see cref="!:TrainerModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:TrainerModel" /> instances that match the specified <paramref name="otherInfoTextId" />.
        /// </returns>
        System.Collections.Generic.IEnumerable<Consensus.Contact.ITrainerModel> ITrainerFactory.FetchAllByOtherInfoTextId(System.String otherInfoTextId)
        {
            return this.FetchAllByOtherInfoTextId(otherInfoTextId);
        }

        #endregion
    }
}
