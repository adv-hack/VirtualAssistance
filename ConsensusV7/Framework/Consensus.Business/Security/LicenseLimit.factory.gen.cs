using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Linq;

namespace Consensus.Security
{
    /// <summary>
    ///     Supports the instantiation of the <see cref="LicenseLimitModel" /> class.
    /// </summary>
    /// <remarks>
    ///     THIS CODE HAS BEEN AUTOMATICALLY GENERATED USING THE CONSENSUS DEVELOPER TOOLS.
    ///     DO NOT EDIT THIS CODE AS ANY CUSTOM MODIFICATIONS WILL BE LOST UPON REGENERATION.
    /// </remarks>
    public interface ILicenseLimitFactory : IFactory<ILicenseLimitModel, Int32>
    {
        /// <summary>
        ///     Creates a new <see cref="!:LicenseLimitModel" /> instance.
        /// </summary>
        /// <returns>
        ///     A newly instantiated <see cref="!:LicenseLimitModel" /> instance.
        /// </returns>
        Consensus.Security.ILicenseLimitModel Create();

        /// <summary>
        ///     Retrieves all instances of the <see cref="!:LicenseLimitModel" /> class.
        /// </summary>
        /// <returns>
        ///     An enumerable collection of <see cref="!:LicenseLimitModel" /> instances.
        /// </returns>
        System.Collections.Generic.IEnumerable<Consensus.Security.ILicenseLimitModel> FetchAll();

        /// <summary>
        ///     Retrieves a specific <see cref="!:LicenseLimitModel" /> instance.
        /// </summary>
        /// <param name="id">
        ///     The unique value which distinctly identifies the <see cref="!:LicenseLimitModel" /> instance to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:LicenseLimitModel" /> instance that matches the specified <paramref name="id" />; or null, if no matching instance can be found.
        /// </returns>
        Consensus.Security.ILicenseLimitModel FetchById(System.Int32 id);

        System.String GetTableName();

        /// <summary>
        ///     Retrieves a collection of <see cref="!:LicenseLimitModel" /> instances.
        /// </summary>
        /// <param name="licenseId">
        ///     The value which identifies the <see cref="!:LicenseLimitModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:LicenseLimitModel" /> instances that match the specified <paramref name="licenseId" />.
        /// </returns>
        System.Collections.Generic.IEnumerable<Consensus.Security.ILicenseLimitModel> FetchAllByLicenseId(System.Guid licenseId);
    }
}
