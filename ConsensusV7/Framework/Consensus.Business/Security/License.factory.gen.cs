using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Linq;

namespace Consensus.Security
{
    /// <summary>
    ///     Supports the instantiation of the <see cref="LicenseModel" /> class.
    /// </summary>
    /// <remarks>
    ///     THIS CODE HAS BEEN AUTOMATICALLY GENERATED USING THE CONSENSUS DEVELOPER TOOLS.
    ///     DO NOT EDIT THIS CODE AS ANY CUSTOM MODIFICATIONS WILL BE LOST UPON REGENERATION.
    /// </remarks>
    public interface ILicenseFactory : IFactory<ILicenseModel, Guid>
    {
        /// <summary>
        ///     Gets the active software license.
        /// </summary>
        /// <returns>
        ///     The most applicable software license.
        /// </returns>
        Consensus.Security.ILicenseModel GetCurrent();

        /// <summary>
        ///     Generates a signature for the specified license verification code.
        /// </summary>
        System.String Sign(System.String verification);

        /// <summary>
        ///     Creates a new <see cref="!:LicenseModel" /> instance.
        /// </summary>
        /// <returns>
        ///     A newly instantiated <see cref="!:LicenseModel" /> instance.
        /// </returns>
        Consensus.Security.ILicenseModel Create();

        /// <summary>
        ///     Retrieves all instances of the <see cref="!:LicenseModel" /> class.
        /// </summary>
        /// <returns>
        ///     An enumerable collection of <see cref="!:LicenseModel" /> instances.
        /// </returns>
        System.Collections.Generic.IEnumerable<Consensus.Security.ILicenseModel> FetchAll();

        /// <summary>
        ///     Retrieves a specific <see cref="!:LicenseModel" /> instance.
        /// </summary>
        /// <param name="id">
        ///     The unique value which distinctly identifies the <see cref="!:LicenseModel" /> instance to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:LicenseModel" /> instance that matches the specified <paramref name="id" />; or null, if no matching instance can be found.
        /// </returns>
        Consensus.Security.ILicenseModel FetchById(System.Guid id);

        System.String GetTableName();

        /// <summary>
        ///     Retrieves a collection of <see cref="!:LicenseModel" /> instances.
        /// </summary>
        /// <param name="ownerId">
        ///     The value which identifies the <see cref="!:LicenseModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:LicenseModel" /> instances that match the specified <paramref name="ownerId" />.
        /// </returns>
        System.Collections.Generic.IEnumerable<Consensus.Security.ILicenseModel> FetchAllByOwnerId(System.String ownerId);
    }
}
