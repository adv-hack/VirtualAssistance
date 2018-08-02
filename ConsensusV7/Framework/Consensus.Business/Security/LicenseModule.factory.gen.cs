using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Linq;

namespace Consensus.Security
{
    /// <summary>
    ///     Supports the instantiation of the <see cref="LicenseModuleModel" /> class.
    /// </summary>
    /// <remarks>
    ///     THIS CODE HAS BEEN AUTOMATICALLY GENERATED USING THE CONSENSUS DEVELOPER TOOLS.
    ///     DO NOT EDIT THIS CODE AS ANY CUSTOM MODIFICATIONS WILL BE LOST UPON REGENERATION.
    /// </remarks>
    public interface ILicenseModuleFactory : IFactory<ILicenseModuleModel, Int32>
    {
        /// <summary>
        ///     Retrieves a collection of <see cref="!:LicenseModuleModel" /> instances.
        /// </summary>
        /// <param name="licenseId">
        ///     The value which identifies the <see cref="!:LicenseModuleModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:LicenseModuleModel" /> instances that match the specified <paramref name="licenseId" />.
        /// </returns>
        System.Collections.Generic.IEnumerable<Consensus.Security.ILicenseModuleModel> FetchAllByLicenseId(System.Guid licenseId);

        /// <summary>
        ///     Creates a new <see cref="!:LicenseModuleModel" /> instance.
        /// </summary>
        /// <returns>
        ///     A newly instantiated <see cref="!:LicenseModuleModel" /> instance.
        /// </returns>
        Consensus.Security.ILicenseModuleModel Create();

        /// <summary>
        ///     Retrieves all instances of the <see cref="!:LicenseModuleModel" /> class.
        /// </summary>
        /// <returns>
        ///     An enumerable collection of <see cref="!:LicenseModuleModel" /> instances.
        /// </returns>
        System.Collections.Generic.IEnumerable<Consensus.Security.ILicenseModuleModel> FetchAll();

        /// <summary>
        ///     Retrieves a specific <see cref="!:LicenseModuleModel" /> instance.
        /// </summary>
        /// <param name="id">
        ///     The unique value which distinctly identifies the <see cref="!:LicenseModuleModel" /> instance to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:LicenseModuleModel" /> instance that matches the specified <paramref name="id" />; or null, if no matching instance can be found.
        /// </returns>
        Consensus.Security.ILicenseModuleModel FetchById(System.Int32 id);

        System.String GetTableName();
    }
}
