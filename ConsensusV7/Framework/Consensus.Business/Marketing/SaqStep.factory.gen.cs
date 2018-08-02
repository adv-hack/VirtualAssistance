using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Linq;

namespace Consensus.Marketing
{
    /// <summary>
    ///     Supports the instantiation of the <see cref="SaqStepModel" /> class.
    /// </summary>
    /// <remarks>
    ///     THIS CODE HAS BEEN AUTOMATICALLY GENERATED USING THE CONSENSUS DEVELOPER TOOLS.
    ///     DO NOT EDIT THIS CODE AS ANY CUSTOM MODIFICATIONS WILL BE LOST UPON REGENERATION.
    /// </remarks>
    public interface ISaqStepFactory : IFactory<ISaqStepModel, Int64>
    {
        /// <summary>
        ///     Creates a new <see cref="!:SaqStepModel" /> instance.
        /// </summary>
        /// <returns>
        ///     A newly instantiated <see cref="!:SaqStepModel" /> instance.
        /// </returns>
        Consensus.Marketing.ISaqStepModel Create();

        /// <summary>
        ///     Retrieves all instances of the <see cref="!:SaqStepModel" /> class.
        /// </summary>
        /// <returns>
        ///     An enumerable collection of <see cref="!:SaqStepModel" /> instances.
        /// </returns>
        System.Collections.Generic.IEnumerable<Consensus.Marketing.ISaqStepModel> FetchAll();

        /// <summary>
        ///     Retrieves a specific <see cref="!:SaqStepModel" /> instance.
        /// </summary>
        /// <param name="id">
        ///     The unique value which distinctly identifies the <see cref="!:SaqStepModel" /> instance to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:SaqStepModel" /> instance that matches the specified <paramref name="id" />; or null, if no matching instance can be found.
        /// </returns>
        Consensus.Marketing.ISaqStepModel FetchById(System.Int64 id);

        System.String GetTableName();

        /// <summary>
        ///     Retrieves a collection of <see cref="!:SaqStepModel" /> instances.
        /// </summary>
        /// <param name="ownerRoleId">
        ///     The value which identifies the <see cref="!:SaqStepModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:SaqStepModel" /> instances that match the specified <paramref name="ownerRoleId" />.
        /// </returns>
        System.Collections.Generic.IEnumerable<Consensus.Marketing.ISaqStepModel> FetchAllByOwnerRoleId(System.String ownerRoleId);
    }
}
