using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Linq;

namespace Consensus.Contact
{
    /// <summary>
    ///     Supports the instantiation of the <see cref="TrainerModel" /> class.
    /// </summary>
    /// <remarks>
    ///     THIS CODE HAS BEEN AUTOMATICALLY GENERATED USING THE CONSENSUS DEVELOPER TOOLS.
    ///     DO NOT EDIT THIS CODE AS ANY CUSTOM MODIFICATIONS WILL BE LOST UPON REGENERATION.
    /// </remarks>
    public interface ITrainerFactory : IFactory<ITrainerModel, String>
    {
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
        System.Boolean CheckIfPersonIsAssociatedWithTrainer(System.String proleId, System.String trainerId, System.String syType);

        /// <summary>
        ///     Creates a new <see cref="!:TrainerModel" /> instance.
        /// </summary>
        /// <returns>
        ///     A newly instantiated <see cref="!:TrainerModel" /> instance.
        /// </returns>
        Consensus.Contact.ITrainerModel Create();

        /// <summary>
        ///     Retrieves all instances of the <see cref="!:TrainerModel" /> class.
        /// </summary>
        /// <returns>
        ///     An enumerable collection of <see cref="!:TrainerModel" /> instances.
        /// </returns>
        System.Collections.Generic.IEnumerable<Consensus.Contact.ITrainerModel> FetchAll();

        /// <summary>
        ///     Retrieves a specific <see cref="!:TrainerModel" /> instance.
        /// </summary>
        /// <param name="id">
        ///     The unique value which distinctly identifies the <see cref="!:TrainerModel" /> instance to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:TrainerModel" /> instance that matches the specified <paramref name="id" />; or null, if no matching instance can be found.
        /// </returns>
        Consensus.Contact.ITrainerModel FetchById(System.String id);

        System.String GetTableName();

        /// <summary>
        ///     Retrieves a collection of <see cref="!:TrainerModel" /> instances.
        /// </summary>
        /// <param name="roleId">
        ///     The value which identifies the <see cref="!:TrainerModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:TrainerModel" /> instances that match the specified <paramref name="roleId" />.
        /// </returns>
        System.Collections.Generic.IEnumerable<Consensus.Contact.ITrainerModel> FetchAllByRoleId(System.String roleId);

        /// <summary>
        ///     Retrieves a collection of <see cref="!:TrainerModel" /> instances.
        /// </summary>
        /// <param name="sellingCompanyId">
        ///     The value which identifies the <see cref="!:TrainerModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:TrainerModel" /> instances that match the specified <paramref name="sellingCompanyId" />.
        /// </returns>
        System.Collections.Generic.IEnumerable<Consensus.Contact.ITrainerModel> FetchAllBySellingCompanyId(System.String sellingCompanyId);

        /// <summary>
        ///     Retrieves a collection of <see cref="!:TrainerModel" /> instances.
        /// </summary>
        /// <param name="feeNotesTextId">
        ///     The value which identifies the <see cref="!:TrainerModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:TrainerModel" /> instances that match the specified <paramref name="feeNotesTextId" />.
        /// </returns>
        System.Collections.Generic.IEnumerable<Consensus.Contact.ITrainerModel> FetchAllByFeeNotesTextId(System.String feeNotesTextId);

        /// <summary>
        ///     Retrieves a collection of <see cref="!:TrainerModel" /> instances.
        /// </summary>
        /// <param name="hotelReqTextId">
        ///     The value which identifies the <see cref="!:TrainerModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:TrainerModel" /> instances that match the specified <paramref name="hotelReqTextId" />.
        /// </returns>
        System.Collections.Generic.IEnumerable<Consensus.Contact.ITrainerModel> FetchAllByHotelReqTextId(System.String hotelReqTextId);

        /// <summary>
        ///     Retrieves a collection of <see cref="!:TrainerModel" /> instances.
        /// </summary>
        /// <param name="otherInfoTextId">
        ///     The value which identifies the <see cref="!:TrainerModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:TrainerModel" /> instances that match the specified <paramref name="otherInfoTextId" />.
        /// </returns>
        System.Collections.Generic.IEnumerable<Consensus.Contact.ITrainerModel> FetchAllByOtherInfoTextId(System.String otherInfoTextId);
    }
}
