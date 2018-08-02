using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Linq;

namespace Consensus.Contact
{
    /// <summary>
    ///     Supports the instantiation of the <see cref="TimeSpentModel" /> class.
    /// </summary>
    /// <remarks>
    ///     THIS CODE HAS BEEN AUTOMATICALLY GENERATED USING THE CONSENSUS DEVELOPER TOOLS.
    ///     DO NOT EDIT THIS CODE AS ANY CUSTOM MODIFICATIONS WILL BE LOST UPON REGENERATION.
    /// </remarks>
    public interface ITimeSpentFactory : IFactory<ITimeSpentModel, String>
    {
        /// <summary>
        ///     Creates a new <see cref="!:TimeSpentModel" /> instance.
        /// </summary>
        /// <returns>
        ///     A newly instantiated <see cref="!:TimeSpentModel" /> instance.
        /// </returns>
        Consensus.Contact.ITimeSpentModel Create();

        /// <summary>
        ///     Retrieves all instances of the <see cref="!:TimeSpentModel" /> class.
        /// </summary>
        /// <returns>
        ///     An enumerable collection of <see cref="!:TimeSpentModel" /> instances.
        /// </returns>
        System.Collections.Generic.IEnumerable<Consensus.Contact.ITimeSpentModel> FetchAll();

        /// <summary>
        ///     Retrieves a specific <see cref="!:TimeSpentModel" /> instance.
        /// </summary>
        /// <param name="id">
        ///     The unique value which distinctly identifies the <see cref="!:TimeSpentModel" /> instance to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:TimeSpentModel" /> instance that matches the specified <paramref name="id" />; or null, if no matching instance can be found.
        /// </returns>
        Consensus.Contact.ITimeSpentModel FetchById(System.String id);

        System.String GetTableName();
    }
}
