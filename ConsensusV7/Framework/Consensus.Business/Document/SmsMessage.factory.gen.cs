using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Linq;

namespace Consensus.Document
{
    /// <summary>
    ///     Supports the instantiation of the <see cref="SmsMessageModel" /> class.
    /// </summary>
    /// <remarks>
    ///     THIS CODE HAS BEEN AUTOMATICALLY GENERATED USING THE CONSENSUS DEVELOPER TOOLS.
    ///     DO NOT EDIT THIS CODE AS ANY CUSTOM MODIFICATIONS WILL BE LOST UPON REGENERATION.
    /// </remarks>
    public interface ISmsMessageFactory : IFactory<ISmsMessageModel, Int32>
    {
        /// <summary>
        ///     Checks if smsmessage name exist.
        /// </summary>
        /// <param name="name">
        ///     Name of the smsmessage.
        /// </param>
        /// <param name="smsmessageId">
        ///     Id of the smsmessage.
        /// </param>
        /// <returns>
        ///     Whether smsmessage's name exist in database.
        /// </returns>
        System.Boolean CheckIfNameExist(System.String name, System.String smsmessageId);

        /// <summary>
        ///     Creates a new <see cref="!:SmsMessageModel" /> instance.
        /// </summary>
        /// <returns>
        ///     A newly instantiated <see cref="!:SmsMessageModel" /> instance.
        /// </returns>
        Consensus.Document.ISmsMessageModel Create();

        /// <summary>
        ///     Retrieves all instances of the <see cref="!:SmsMessageModel" /> class.
        /// </summary>
        /// <returns>
        ///     An enumerable collection of <see cref="!:SmsMessageModel" /> instances.
        /// </returns>
        System.Collections.Generic.IEnumerable<Consensus.Document.ISmsMessageModel> FetchAll();

        /// <summary>
        ///     Retrieves a specific <see cref="!:SmsMessageModel" /> instance.
        /// </summary>
        /// <param name="id">
        ///     The unique value which distinctly identifies the <see cref="!:SmsMessageModel" /> instance to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:SmsMessageModel" /> instance that matches the specified <paramref name="id" />; or null, if no matching instance can be found.
        /// </returns>
        Consensus.Document.ISmsMessageModel FetchById(System.Int32 id);

        System.String GetTableName();

        System.Collections.Generic.IEnumerable<Consensus.Document.ISmsMessageModel> FetchAllBySmsMessageTypeId(System.Nullable<System.Int32> smsMessageTypeId);

        /// <summary>
        ///     Retrieves a collection of <see cref="!:SmsMessageModel" /> instances.
        /// </summary>
        /// <param name="sellingCompanyId">
        ///     The value which identifies the <see cref="!:SmsMessageModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:SmsMessageModel" /> instances that match the specified <paramref name="sellingCompanyId" />.
        /// </returns>
        System.Collections.Generic.IEnumerable<Consensus.Document.ISmsMessageModel> FetchAllBySellingCompanyId(System.String sellingCompanyId);
    }
}
