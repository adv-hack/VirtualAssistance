using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Linq;

namespace Consensus.Contact
{
    /// <summary>
    ///     Provides the persistence and retrieval of the <see cref="TrainerRecord" /> instances.
    /// </summary>
    /// <remarks>
    ///     THIS CODE HAS BEEN AUTOMATICALLY GENERATED USING THE CONSENSUS DEVELOPER TOOLS.
    ///     DO NOT EDIT THIS CODE AS ANY CUSTOM MODIFICATIONS WILL BE LOST UPON REGENERATION.
    /// </remarks>
    public interface ITrainerRepository : IRepository<TrainerRecord, String>
    {
        #region properties

        /// <summary>
        ///     Gets the underlying table name that this repository sit over.
        /// </summary>
        System.String TableName
        {
            get;
        }

        #endregion

        #region methods

        /// <summary>
        ///     Retrieves a collection of <see cref="T:Consensus.Contact.TrainerRecord" /> instances from the data store.
        /// </summary>
        /// <param name="ainProleId">
        ///     The value which identifies the <see cref="!:TrainerModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The collection of <see cref="T:Consensus.Contact.TrainerRecord" /> instances that match the specified <paramref name="ainProleId" />.
        /// </returns>
        System.Collections.Generic.IEnumerable<Consensus.Contact.TrainerRecord> FetchAllByAinProleId(System.String ainProleId);

        /// <summary>
        ///     Retrieves a collection of <see cref="T:Consensus.Contact.TrainerRecord" /> instances from the data store.
        /// </summary>
        /// <param name="ainSelcoSpId">
        ///     The value which identifies the <see cref="!:TrainerModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The collection of <see cref="T:Consensus.Contact.TrainerRecord" /> instances that match the specified <paramref name="ainSelcoSpId" />.
        /// </returns>
        System.Collections.Generic.IEnumerable<Consensus.Contact.TrainerRecord> FetchAllByAinSelcoSpId(System.String ainSelcoSpId);

        /// <summary>
        ///     Retrieves a collection of <see cref="T:Consensus.Contact.TrainerRecord" /> instances from the data store.
        /// </summary>
        /// <param name="ainFeeNotesTextId">
        ///     The value which identifies the <see cref="!:TrainerModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The collection of <see cref="T:Consensus.Contact.TrainerRecord" /> instances that match the specified <paramref name="ainFeeNotesTextId" />.
        /// </returns>
        System.Collections.Generic.IEnumerable<Consensus.Contact.TrainerRecord> FetchAllByAinFeeNotesTextId(System.String ainFeeNotesTextId);

        /// <summary>
        ///     Retrieves a collection of <see cref="T:Consensus.Contact.TrainerRecord" /> instances from the data store.
        /// </summary>
        /// <param name="ainHotelReqTextId">
        ///     The value which identifies the <see cref="!:TrainerModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The collection of <see cref="T:Consensus.Contact.TrainerRecord" /> instances that match the specified <paramref name="ainHotelReqTextId" />.
        /// </returns>
        System.Collections.Generic.IEnumerable<Consensus.Contact.TrainerRecord> FetchAllByAinHotelReqTextId(System.String ainHotelReqTextId);

        /// <summary>
        ///     Retrieves a collection of <see cref="T:Consensus.Contact.TrainerRecord" /> instances from the data store.
        /// </summary>
        /// <param name="ainOtherInfoTextId">
        ///     The value which identifies the <see cref="!:TrainerModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The collection of <see cref="T:Consensus.Contact.TrainerRecord" /> instances that match the specified <paramref name="ainOtherInfoTextId" />.
        /// </returns>
        System.Collections.Generic.IEnumerable<Consensus.Contact.TrainerRecord> FetchAllByAinOtherInfoTextId(System.String ainOtherInfoTextId);

        #endregion
    }
}
