using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Linq;

namespace Consensus.Activities
{
    /// <summary>
    ///     Supports the instantiation of the <see cref="C4textModel" /> class.
    /// </summary>
    /// <remarks>
    ///     THIS CODE HAS BEEN AUTOMATICALLY GENERATED USING THE CONSENSUS DEVELOPER TOOLS.
    ///     DO NOT EDIT THIS CODE AS ANY CUSTOM MODIFICATIONS WILL BE LOST UPON REGENERATION.
    /// </remarks>
    public interface IC4textFactory : IFactory<IC4textModel, String>
    {
        System.Collections.Generic.IEnumerable<Consensus.Activities.IC4textModel> FetchAllByOwnerUrlAndOwnerId(System.String ownerUrl, System.String ownerId);

        /// <summary>
        ///     Creates a new <see cref="!:C4textModel" /> instance.
        /// </summary>
        /// <returns>
        ///     A newly instantiated <see cref="!:C4textModel" /> instance.
        /// </returns>
        Consensus.Activities.IC4textModel Create();

        /// <summary>
        ///     Retrieves all instances of the <see cref="!:C4textModel" /> class.
        /// </summary>
        /// <returns>
        ///     An enumerable collection of <see cref="!:C4textModel" /> instances.
        /// </returns>
        System.Collections.Generic.IEnumerable<Consensus.Activities.IC4textModel> FetchAll();

        /// <summary>
        ///     Retrieves a specific <see cref="!:C4textModel" /> instance.
        /// </summary>
        /// <param name="id">
        ///     The unique value which distinctly identifies the <see cref="!:C4textModel" /> instance to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:C4textModel" /> instance that matches the specified <paramref name="id" />; or null, if no matching instance can be found.
        /// </returns>
        Consensus.Activities.IC4textModel FetchById(System.String id);

        System.String GetTableName();
    }
}
