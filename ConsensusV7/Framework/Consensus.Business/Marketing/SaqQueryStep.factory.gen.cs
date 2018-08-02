using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Linq;

namespace Consensus.Marketing
{
    /// <summary>
    ///     Supports the instantiation of the <see cref="SaqQueryStepModel" /> class.
    /// </summary>
    /// <remarks>
    ///     THIS CODE HAS BEEN AUTOMATICALLY GENERATED USING THE CONSENSUS DEVELOPER TOOLS.
    ///     DO NOT EDIT THIS CODE AS ANY CUSTOM MODIFICATIONS WILL BE LOST UPON REGENERATION.
    /// </remarks>
    public interface ISaqQueryStepFactory : IFactory<ISaqQueryStepModel, Int32>
    {
        /// <summary>
        ///     Creates a new <see cref="!:SaqQueryStepModel" /> instance.
        /// </summary>
        /// <returns>
        ///     A newly instantiated <see cref="!:SaqQueryStepModel" /> instance.
        /// </returns>
        Consensus.Marketing.ISaqQueryStepModel Create();

        /// <summary>
        ///     Retrieves all instances of the <see cref="!:SaqQueryStepModel" /> class.
        /// </summary>
        /// <returns>
        ///     An enumerable collection of <see cref="!:SaqQueryStepModel" /> instances.
        /// </returns>
        System.Collections.Generic.IEnumerable<Consensus.Marketing.ISaqQueryStepModel> FetchAll();

        /// <summary>
        ///     Retrieves a specific <see cref="!:SaqQueryStepModel" /> instance.
        /// </summary>
        /// <param name="id">
        ///     The unique value which distinctly identifies the <see cref="!:SaqQueryStepModel" /> instance to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:SaqQueryStepModel" /> instance that matches the specified <paramref name="id" />; or null, if no matching instance can be found.
        /// </returns>
        Consensus.Marketing.ISaqQueryStepModel FetchById(System.Int32 id);

        System.String GetTableName();

        /// <summary>
        ///     Retrieves a collection of <see cref="!:SaqQueryStepModel" /> instances.
        /// </summary>
        /// <param name="stepQueryId">
        ///     The value which identifies the <see cref="!:SaqQueryStepModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:SaqQueryStepModel" /> instances that match the specified <paramref name="stepQueryId" />.
        /// </returns>
        System.Collections.Generic.IEnumerable<Consensus.Marketing.ISaqQueryStepModel> FetchAllByStepQueryId(System.Int64 stepQueryId);

        /// <summary>
        ///     Retrieves a collection of <see cref="!:SaqQueryStepModel" /> instances.
        /// </summary>
        /// <param name="stepId">
        ///     The value which identifies the <see cref="!:SaqQueryStepModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:SaqQueryStepModel" /> instances that match the specified <paramref name="stepId" />.
        /// </returns>
        System.Collections.Generic.IEnumerable<Consensus.Marketing.ISaqQueryStepModel> FetchAllByStepId(System.Int64 stepId);
    }
}
