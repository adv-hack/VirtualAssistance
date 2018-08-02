using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Linq;

namespace Consensus.Learning
{
    /// <summary>
    ///     Supports the instantiation of the <see cref="TemplateRoomModel" /> class.
    /// </summary>
    /// <remarks>
    ///     THIS CODE HAS BEEN AUTOMATICALLY GENERATED USING THE CONSENSUS DEVELOPER TOOLS.
    ///     DO NOT EDIT THIS CODE AS ANY CUSTOM MODIFICATIONS WILL BE LOST UPON REGENERATION.
    /// </remarks>
    public interface ITemplateRoomFactory : IFactory<ITemplateRoomModel, String>
    {
        /// <summary>
        ///     Creates a new <see cref="!:TemplateRoomModel" /> instance.
        /// </summary>
        /// <returns>
        ///     A newly instantiated <see cref="!:TemplateRoomModel" /> instance.
        /// </returns>
        Consensus.Learning.ITemplateRoomModel Create();

        /// <summary>
        ///     Retrieves all instances of the <see cref="!:TemplateRoomModel" /> class.
        /// </summary>
        /// <returns>
        ///     An enumerable collection of <see cref="!:TemplateRoomModel" /> instances.
        /// </returns>
        System.Collections.Generic.IEnumerable<Consensus.Learning.ITemplateRoomModel> FetchAll();

        /// <summary>
        ///     Retrieves a specific <see cref="!:TemplateRoomModel" /> instance.
        /// </summary>
        /// <param name="id">
        ///     The unique value which distinctly identifies the <see cref="!:TemplateRoomModel" /> instance to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:TemplateRoomModel" /> instance that matches the specified <paramref name="id" />; or null, if no matching instance can be found.
        /// </returns>
        Consensus.Learning.ITemplateRoomModel FetchById(System.String id);

        System.String GetTableName();

        /// <summary>
        ///     Retrieves a collection of <see cref="!:TemplateRoomModel" /> instances.
        /// </summary>
        /// <param name="billOfMaterialId">
        ///     The value which identifies the <see cref="!:TemplateRoomModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:TemplateRoomModel" /> instances that match the specified <paramref name="billOfMaterialId" />.
        /// </returns>
        System.Collections.Generic.IEnumerable<Consensus.Learning.ITemplateRoomModel> FetchAllByBillOfMaterialId(System.String billOfMaterialId);
    }
}
