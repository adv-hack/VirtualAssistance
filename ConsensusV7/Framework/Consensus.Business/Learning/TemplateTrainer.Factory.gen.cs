using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Linq;

namespace Consensus.Learning
{
    /// <summary>
    ///     Supports the instantiation of the <see cref="TemplateTrainerModel" /> class.
    /// </summary>
    /// <remarks>
    ///     THIS CODE HAS BEEN AUTOMATICALLY GENERATED USING THE CONSENSUS DEVELOPER TOOLS.
    ///     DO NOT EDIT THIS CODE AS ANY CUSTOM MODIFICATIONS WILL BE LOST UPON REGENERATION.
    /// </remarks>
    public interface ITemplateTrainerFactory : IFactory<ITemplateTrainerModel, String>
    {
        /// <summary>
        ///     Creates a new <see cref="!:TemplateTrainerModel" /> instance.
        /// </summary>
        /// <returns>
        ///     A newly instantiated <see cref="!:TemplateTrainerModel" /> instance.
        /// </returns>
        Consensus.Learning.ITemplateTrainerModel Create();

        /// <summary>
        ///     Retrieves all instances of the <see cref="!:TemplateTrainerModel" /> class.
        /// </summary>
        /// <returns>
        ///     An enumerable collection of <see cref="!:TemplateTrainerModel" /> instances.
        /// </returns>
        System.Collections.Generic.IEnumerable<Consensus.Learning.ITemplateTrainerModel> FetchAll();

        /// <summary>
        ///     Retrieves a specific <see cref="!:TemplateTrainerModel" /> instance.
        /// </summary>
        /// <param name="id">
        ///     The unique value which distinctly identifies the <see cref="!:TemplateTrainerModel" /> instance to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:TemplateTrainerModel" /> instance that matches the specified <paramref name="id" />; or null, if no matching instance can be found.
        /// </returns>
        Consensus.Learning.ITemplateTrainerModel FetchById(System.String id);

        System.String GetTableName();

        /// <summary>
        ///     Retrieves a collection of <see cref="!:TemplateTrainerModel" /> instances.
        /// </summary>
        /// <param name="billOfMaterialId">
        ///     The value which identifies the <see cref="!:TemplateTrainerModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:TemplateTrainerModel" /> instances that match the specified <paramref name="billOfMaterialId" />.
        /// </returns>
        System.Collections.Generic.IEnumerable<Consensus.Learning.ITemplateTrainerModel> FetchAllByBillOfMaterialId(System.String billOfMaterialId);

        /// <summary>
        ///     Retrieves a collection of <see cref="!:TemplateTrainerModel" /> instances.
        /// </summary>
        /// <param name="trainerRoleId">
        ///     The value which identifies the <see cref="!:TemplateTrainerModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:TemplateTrainerModel" /> instances that match the specified <paramref name="trainerRoleId" />.
        /// </returns>
        System.Collections.Generic.IEnumerable<Consensus.Learning.ITemplateTrainerModel> FetchAllByTrainerRoleId(System.String trainerRoleId);
    }
}
