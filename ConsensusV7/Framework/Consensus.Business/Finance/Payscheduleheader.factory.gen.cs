using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Linq;

namespace Consensus.Finance
{
    /// <summary>
    ///     Supports the instantiation of the <see cref="PayscheduleheaderModel" /> class.
    /// </summary>
    /// <remarks>
    ///     THIS CODE HAS BEEN AUTOMATICALLY GENERATED USING THE CONSENSUS DEVELOPER TOOLS.
    ///     DO NOT EDIT THIS CODE AS ANY CUSTOM MODIFICATIONS WILL BE LOST UPON REGENERATION.
    /// </remarks>
    public interface IPayscheduleheaderFactory : IFactory<IPayscheduleheaderModel, Int32>
    {
        /// <summary>
        ///     Creates a new <see cref="!:PayscheduleheaderModel" /> instance.
        /// </summary>
        /// <returns>
        ///     A newly instantiated <see cref="!:PayscheduleheaderModel" /> instance.
        /// </returns>
        Consensus.Finance.IPayscheduleheaderModel Create();

        /// <summary>
        ///     Retrieves all instances of the <see cref="!:PayscheduleheaderModel" /> class.
        /// </summary>
        /// <returns>
        ///     An enumerable collection of <see cref="!:PayscheduleheaderModel" /> instances.
        /// </returns>
        System.Collections.Generic.IEnumerable<Consensus.Finance.IPayscheduleheaderModel> FetchAll();

        /// <summary>
        ///     Retrieves a specific <see cref="!:PayscheduleheaderModel" /> instance.
        /// </summary>
        /// <param name="id">
        ///     The unique value which distinctly identifies the <see cref="!:PayscheduleheaderModel" /> instance to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:PayscheduleheaderModel" /> instance that matches the specified <paramref name="id" />; or null, if no matching instance can be found.
        /// </returns>
        Consensus.Finance.IPayscheduleheaderModel FetchById(System.Int32 id);

        System.String GetTableName();
    }
}
