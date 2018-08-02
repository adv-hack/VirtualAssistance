using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Linq;

namespace Consensus.Common
{
    /// <summary>
    ///     Supports the instantiation of the <see cref="ProfileTrainerModel" /> class.
    /// </summary>
    /// <remarks>
    ///     THIS CODE HAS BEEN AUTOMATICALLY GENERATED USING THE CONSENSUS DEVELOPER TOOLS.
    ///     DO NOT EDIT THIS CODE AS ANY CUSTOM MODIFICATIONS WILL BE LOST UPON REGENERATION.
    /// </remarks>
    public interface IProfileTrainerFactory : IFactory<IProfileTrainerModel, String>
    {
        /// <summary>
        ///     Creates a new <see cref="!:ProfileTrainerModel" /> instance.
        /// </summary>
        /// <returns>
        ///     A newly instantiated <see cref="!:ProfileTrainerModel" /> instance.
        /// </returns>
        Consensus.Common.IProfileTrainerModel Create();

        /// <summary>
        ///     Retrieves all instances of the <see cref="!:ProfileTrainerModel" /> class.
        /// </summary>
        /// <returns>
        ///     An enumerable collection of <see cref="!:ProfileTrainerModel" /> instances.
        /// </returns>
        System.Collections.Generic.IEnumerable<Consensus.Common.IProfileTrainerModel> FetchAll();

        /// <summary>
        ///     Retrieves a specific <see cref="!:ProfileTrainerModel" /> instance.
        /// </summary>
        /// <param name="id">
        ///     The unique value which distinctly identifies the <see cref="!:ProfileTrainerModel" /> instance to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:ProfileTrainerModel" /> instance that matches the specified <paramref name="id" />; or null, if no matching instance can be found.
        /// </returns>
        Consensus.Common.IProfileTrainerModel FetchById(System.String id);

        System.String GetTableName();

        /// <summary>
        ///     Retrieves a collection of <see cref="!:ProfileTrainerModel" /> instances.
        /// </summary>
        /// <param name="trainerId">
        ///     The value which identifies the <see cref="!:ProfileTrainerModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:ProfileTrainerModel" /> instances that match the specified <paramref name="trainerId" />.
        /// </returns>
        System.Collections.Generic.IEnumerable<Consensus.Common.IProfileTrainerModel> FetchAllByTrainerId(System.String trainerId);
    }
}
