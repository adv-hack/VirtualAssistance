using System;
using System.Collections.Generic;
using System.Linq;

namespace Consensus.Contact
{
    /// <summary>
    ///     Supports the instantiation of the <see cref="GiftaidModel" /> object.
    /// </summary>
    /// <remarks>
    ///     THIS CODE HAS BEEN AUTOMATICALLY GENERATED USING THE CONSENSUS DEVELOPER TOOLS.
    ///     DO NOT EDIT THIS CODE AS ANY CUSTOM MODIFICATIONS WILL BE LOST UPON REGENERATION.
    /// </remarks>
    public partial class LocalGiftaidFactory : LocalFactory<LocalGiftaidModel, GiftaidRecord, Int32>, IGiftaidFactory
    {
        #region methods

        /// <summary>
        ///     Creates a new <see cref='GiftaidModel' /> instance.
        /// </summary>
        /// <returns>
        ///     A newly instantiated <see cref='GiftaidModel' /> instance.
        /// </returns>
        public LocalGiftaidModel Create()
        {
            return new LocalGiftaidModel(this.Provider);
        }

        /// <summary>
        ///     Retrieves all instances of the <see cref='GiftaidModel' /> class.
        /// </summary>
        /// <returns>
        ///     An enumerable collection of <see cref='GiftaidModel' /> instances.
        /// </returns>
        public IEnumerable<LocalGiftaidModel> FetchAll()
        {
            IEnumerable<GiftaidRecord> recordCollection = this.Provider.DataProvider.Contact.Giftaid.FetchAll();
            foreach (GiftaidRecord record in recordCollection)
            {
                if (record != null)
                {
                    yield return new LocalGiftaidModel(this.Provider, record);
                }
            }
        }

        /// <summary>
        ///     Retrieves a specific <see cref='GiftaidModel' /> instance.
        /// </summary>
        /// <param name="id">
        ///     The unique value which distinctly identifies the <see cref='GiftaidModel' /> instance to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref='GiftaidModel' /> instance that matches the specified <paramref name='id' />; or null, if no matching instance can be found.
        /// </returns>
        public LocalGiftaidModel FetchById(Int32 id)
        {
            GiftaidRecord record = this.Provider.DataProvider.Contact.Giftaid.FetchById(id);
            if (record == null)
                return null;
            return new LocalGiftaidModel(this.Provider, record);
        }

        /// <summary>
        ///     Gets the underlying database table name for <see cref='Giftaid/>.
        /// </summary>
        /// <returns>
        ///     The table name.
        /// </returns>
        public String GetTableName()
        {
            return this.Provider.DataProvider.Contact.Giftaid.TableName;
        }

        /// <summary>
        ///     Retrieves a collection of <see cref='GiftaidModel' /> instances.
        /// </summary>
        /// <param name="pnIdId">
        ///     The value which identifies the <see cref='GiftaidModel' /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref='GiftaidModel' /> instances that match the specified <paramref name='pnIdId' />.
        /// </returns>
        public IEnumerable<LocalGiftaidModel> FetchAllByPnIdId(String pnIdId)
        {
            IEnumerable<GiftaidRecord> recordCollection = this.Provider.DataProvider.Contact.Giftaid.FetchAllByPnId(pnIdId);
            foreach (GiftaidRecord record in recordCollection)
            {
                if (record != null)
                {
                    yield return new LocalGiftaidModel(this.Provider, record);
                }
            }
        }

        #endregion

        #region implementations

        /// <summary>
        ///     Creates a new <see cref="!:GiftaidModel" /> instance.
        /// </summary>
        /// <returns>
        ///     A newly instantiated <see cref="!:GiftaidModel" /> instance.
        /// </returns>
        Consensus.Contact.IGiftaidModel IGiftaidFactory.Create()
        {
            return this.Create();
        }

        /// <summary>
        ///     Retrieves all instances of the <see cref="!:GiftaidModel" /> class.
        /// </summary>
        /// <returns>
        ///     An enumerable collection of <see cref="!:GiftaidModel" /> instances.
        /// </returns>
        System.Collections.Generic.IEnumerable<Consensus.Contact.IGiftaidModel> IGiftaidFactory.FetchAll()
        {
            return this.FetchAll();
        }

        /// <summary>
        ///     Retrieves a specific <see cref="!:GiftaidModel" /> instance.
        /// </summary>
        /// <param name="id">
        ///     The unique value which distinctly identifies the <see cref="!:GiftaidModel" /> instance to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:GiftaidModel" /> instance that matches the specified <paramref name="id" />; or null, if no matching instance can be found.
        /// </returns>
        Consensus.Contact.IGiftaidModel IGiftaidFactory.FetchById(System.Int32 id)
        {
            return this.FetchById(id);
        }

        System.String IGiftaidFactory.GetTableName()
        {
            return this.GetTableName();
        }

        /// <summary>
        ///     Retrieves a collection of <see cref="!:GiftaidModel" /> instances.
        /// </summary>
        /// <param name="pnIdId">
        ///     The value which identifies the <see cref="!:GiftaidModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:GiftaidModel" /> instances that match the specified <paramref name="pnIdId" />.
        /// </returns>
        System.Collections.Generic.IEnumerable<Consensus.Contact.IGiftaidModel> IGiftaidFactory.FetchAllByPnIdId(System.String pnIdId)
        {
            return this.FetchAllByPnIdId(pnIdId);
        }

        #endregion
    }
}
