using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Linq;

namespace Consensus.Document
{
    /// <summary>
    ///     Supports the instantiation of the <see cref="SmsTypeModel" /> class.
    /// </summary>
    /// <remarks>
    ///     THIS CODE HAS BEEN AUTOMATICALLY GENERATED USING THE CONSENSUS DEVELOPER TOOLS.
    ///     DO NOT EDIT THIS CODE AS ANY CUSTOM MODIFICATIONS WILL BE LOST UPON REGENERATION.
    /// </remarks>
    public interface ISmsTypeFactory : IFactory<ISmsTypeModel, Int32>
    {
        /// <summary>
        ///     Creates a new <see cref="!:SmsTypeModel" /> instance.
        /// </summary>
        /// <returns>
        ///     A newly instantiated <see cref="!:SmsTypeModel" /> instance.
        /// </returns>
        Consensus.Document.ISmsTypeModel Create();

        /// <summary>
        ///     Retrieves all instances of the <see cref="!:SmsTypeModel" /> class.
        /// </summary>
        /// <returns>
        ///     An enumerable collection of <see cref="!:SmsTypeModel" /> instances.
        /// </returns>
        System.Collections.Generic.IEnumerable<Consensus.Document.ISmsTypeModel> FetchAll();

        /// <summary>
        ///     Retrieves a specific <see cref="!:SmsTypeModel" /> instance.
        /// </summary>
        /// <param name="id">
        ///     The unique value which distinctly identifies the <see cref="!:SmsTypeModel" /> instance to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:SmsTypeModel" /> instance that matches the specified <paramref name="id" />; or null, if no matching instance can be found.
        /// </returns>
        Consensus.Document.ISmsTypeModel FetchById(System.Int32 id);

        System.String GetTableName();
    }
}
