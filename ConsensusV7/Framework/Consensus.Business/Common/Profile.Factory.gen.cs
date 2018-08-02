using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Linq;

namespace Consensus.Common
{
    /// <summary>
    ///     Supports the instantiation of the <see cref="ProfileModel" /> class.
    /// </summary>
    /// <remarks>
    ///     THIS CODE HAS BEEN AUTOMATICALLY GENERATED USING THE CONSENSUS DEVELOPER TOOLS.
    ///     DO NOT EDIT THIS CODE AS ANY CUSTOM MODIFICATIONS WILL BE LOST UPON REGENERATION.
    /// </remarks>
    public interface IProfileFactory : IFactory<IProfileModel, String>
    {
        /// <summary>
        ///     Creates a new <see cref="!:ProfileModel" /> instance.
        /// </summary>
        /// <returns>
        ///     A newly instantiated <see cref="!:ProfileModel" /> instance.
        /// </returns>
        Consensus.Common.IProfileModel Create();

        /// <summary>
        ///     Retrieves all instances of the <see cref="!:ProfileModel" /> class.
        /// </summary>
        /// <returns>
        ///     An enumerable collection of <see cref="!:ProfileModel" /> instances.
        /// </returns>
        System.Collections.Generic.IEnumerable<Consensus.Common.IProfileModel> FetchAll();

        /// <summary>
        ///     Retrieves a specific <see cref="!:ProfileModel" /> instance.
        /// </summary>
        /// <param name="id">
        ///     The unique value which distinctly identifies the <see cref="!:ProfileModel" /> instance to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:ProfileModel" /> instance that matches the specified <paramref name="id" />; or null, if no matching instance can be found.
        /// </returns>
        Consensus.Common.IProfileModel FetchById(System.String id);

        System.String GetTableName();
    }
}
