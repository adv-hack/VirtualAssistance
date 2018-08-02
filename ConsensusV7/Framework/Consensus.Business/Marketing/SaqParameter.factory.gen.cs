using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Linq;

namespace Consensus.Marketing
{
    /// <summary>
    ///     Supports the instantiation of the <see cref="SaqParameterModel" /> class.
    /// </summary>
    /// <remarks>
    ///     THIS CODE HAS BEEN AUTOMATICALLY GENERATED USING THE CONSENSUS DEVELOPER TOOLS.
    ///     DO NOT EDIT THIS CODE AS ANY CUSTOM MODIFICATIONS WILL BE LOST UPON REGENERATION.
    /// </remarks>
    public interface ISaqParameterFactory : IFactory<ISaqParameterModel, Int64>
    {
        /// <summary>
        ///     Creates a new <see cref="!:SaqParameterModel" /> instance.
        /// </summary>
        /// <returns>
        ///     A newly instantiated <see cref="!:SaqParameterModel" /> instance.
        /// </returns>
        Consensus.Marketing.ISaqParameterModel Create();

        /// <summary>
        ///     Retrieves all instances of the <see cref="!:SaqParameterModel" /> class.
        /// </summary>
        /// <returns>
        ///     An enumerable collection of <see cref="!:SaqParameterModel" /> instances.
        /// </returns>
        System.Collections.Generic.IEnumerable<Consensus.Marketing.ISaqParameterModel> FetchAll();

        /// <summary>
        ///     Retrieves a specific <see cref="!:SaqParameterModel" /> instance.
        /// </summary>
        /// <param name="id">
        ///     The unique value which distinctly identifies the <see cref="!:SaqParameterModel" /> instance to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:SaqParameterModel" /> instance that matches the specified <paramref name="id" />; or null, if no matching instance can be found.
        /// </returns>
        Consensus.Marketing.ISaqParameterModel FetchById(System.Int64 id);

        System.String GetTableName();

        /// <summary>
        ///     Retrieves a collection of <see cref="!:SaqParameterModel" /> instances.
        /// </summary>
        /// <param name="stepId">
        ///     The value which identifies the <see cref="!:SaqParameterModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:SaqParameterModel" /> instances that match the specified <paramref name="stepId" />.
        /// </returns>
        System.Collections.Generic.IEnumerable<Consensus.Marketing.ISaqParameterModel> FetchAllByStepId(System.Int64 stepId);

        /// <summary>
        ///     Retrieves a collection of <see cref="!:SaqParameterModel" /> instances.
        /// </summary>
        /// <param name="filterFieldId">
        ///     The value which identifies the <see cref="!:SaqParameterModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:SaqParameterModel" /> instances that match the specified <paramref name="filterFieldId" />.
        /// </returns>
        System.Collections.Generic.IEnumerable<Consensus.Marketing.ISaqParameterModel> FetchAllByFilterFieldId(System.Int64 filterFieldId);
    }
}
