using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Linq;

namespace Consensus.Learning
{
    /// <summary>
    ///     Supports the instantiation of the <see cref="TemplateResourceModel" /> class.
    /// </summary>
    /// <remarks>
    ///     THIS CODE HAS BEEN AUTOMATICALLY GENERATED USING THE CONSENSUS DEVELOPER TOOLS.
    ///     DO NOT EDIT THIS CODE AS ANY CUSTOM MODIFICATIONS WILL BE LOST UPON REGENERATION.
    /// </remarks>
    public interface ITemplateResourceFactory : IFactory<ITemplateResourceModel, String>
    {
        /// <summary>
        ///     Creates a new <see cref="!:TemplateResourceModel" /> instance.
        /// </summary>
        /// <returns>
        ///     A newly instantiated <see cref="!:TemplateResourceModel" /> instance.
        /// </returns>
        Consensus.Learning.ITemplateResourceModel Create();

        /// <summary>
        ///     Retrieves all instances of the <see cref="!:TemplateResourceModel" /> class.
        /// </summary>
        /// <returns>
        ///     An enumerable collection of <see cref="!:TemplateResourceModel" /> instances.
        /// </returns>
        System.Collections.Generic.IEnumerable<Consensus.Learning.ITemplateResourceModel> FetchAll();

        /// <summary>
        ///     Retrieves a specific <see cref="!:TemplateResourceModel" /> instance.
        /// </summary>
        /// <param name="id">
        ///     The unique value which distinctly identifies the <see cref="!:TemplateResourceModel" /> instance to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:TemplateResourceModel" /> instance that matches the specified <paramref name="id" />; or null, if no matching instance can be found.
        /// </returns>
        Consensus.Learning.ITemplateResourceModel FetchById(System.String id);

        System.String GetTableName();

        /// <summary>
        ///     Retrieves a collection of <see cref="!:TemplateResourceModel" /> instances.
        /// </summary>
        /// <param name="billOfMaterialId">
        ///     The value which identifies the <see cref="!:TemplateResourceModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:TemplateResourceModel" /> instances that match the specified <paramref name="billOfMaterialId" />.
        /// </returns>
        System.Collections.Generic.IEnumerable<Consensus.Learning.ITemplateResourceModel> FetchAllByBillOfMaterialId(System.String billOfMaterialId);

        /// <summary>
        ///     Retrieves a collection of <see cref="!:TemplateResourceModel" /> instances.
        /// </summary>
        /// <param name="resourceId">
        ///     The value which identifies the <see cref="!:TemplateResourceModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:TemplateResourceModel" /> instances that match the specified <paramref name="resourceId" />.
        /// </returns>
        System.Collections.Generic.IEnumerable<Consensus.Learning.ITemplateResourceModel> FetchAllByResourceId(System.String resourceId);
    }
}
