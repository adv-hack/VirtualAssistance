using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Linq;

namespace Consensus.Finance
{
    /// <summary>
    ///     Supports the instantiation of the <see cref="CurrencyModel" /> class.
    /// </summary>
    /// <remarks>
    ///     THIS CODE HAS BEEN AUTOMATICALLY GENERATED USING THE CONSENSUS DEVELOPER TOOLS.
    ///     DO NOT EDIT THIS CODE AS ANY CUSTOM MODIFICATIONS WILL BE LOST UPON REGENERATION.
    /// </remarks>
    public interface ICurrencyFactory : IFactory<ICurrencyModel, String>
    {
        /// <summary>
        ///     Retrieves a specific <see cref="!:CodeModel" /> instance.
        /// </summary>
        /// <returns>
        ///     The <see cref="!:CodeModel" /> instance that matches the specified <paramref name="id" />; or null, if no matching instance can be found.
        /// </returns>
        Consensus.Finance.ICurrencyModel FetchByCodeAndSellingCompany(System.String code, System.String sellingCompany);

        /// <summary>
        ///     Creates a new <see cref="!:CurrencyModel" /> instance.
        /// </summary>
        /// <returns>
        ///     A newly instantiated <see cref="!:CurrencyModel" /> instance.
        /// </returns>
        Consensus.Finance.ICurrencyModel Create();

        /// <summary>
        ///     Retrieves all instances of the <see cref="!:CurrencyModel" /> class.
        /// </summary>
        /// <returns>
        ///     An enumerable collection of <see cref="!:CurrencyModel" /> instances.
        /// </returns>
        System.Collections.Generic.IEnumerable<Consensus.Finance.ICurrencyModel> FetchAll();

        /// <summary>
        ///     Retrieves a specific <see cref="!:CurrencyModel" /> instance.
        /// </summary>
        /// <param name="id">
        ///     The unique value which distinctly identifies the <see cref="!:CurrencyModel" /> instance to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:CurrencyModel" /> instance that matches the specified <paramref name="id" />; or null, if no matching instance can be found.
        /// </returns>
        Consensus.Finance.ICurrencyModel FetchById(System.String id);

        System.String GetTableName();

        /// <summary>
        ///     Retrieves a collection of <see cref="!:CurrencyModel" /> instances.
        /// </summary>
        /// <param name="sellingCompanyId">
        ///     The value which identifies the <see cref="!:CurrencyModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:CurrencyModel" /> instances that match the specified <paramref name="sellingCompanyId" />.
        /// </returns>
        System.Collections.Generic.IEnumerable<Consensus.Finance.ICurrencyModel> FetchAllBySellingCompanyId(System.String sellingCompanyId);
    }
}
