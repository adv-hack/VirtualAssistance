using Consensus.Common;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Linq;

namespace Consensus.Finance
{
    /// <summary>
    ///     Supports the instantiation of the <see cref="DirectDebitModel" /> class.
    /// </summary>
    /// <remarks>
    ///     THIS CODE HAS BEEN AUTOMATICALLY GENERATED USING THE CONSENSUS DEVELOPER TOOLS.
    ///     DO NOT EDIT THIS CODE AS ANY CUSTOM MODIFICATIONS WILL BE LOST UPON REGENERATION.
    /// </remarks>
    public interface IDirectDebitFactory : IFactory<IDirectDebitModel, String>
    {
        /// <summary>
        /// Validates account number and sort code. If valid returns bank details
        /// </summary>
        /// <param name="accountNumber">Account number</param>
        /// <param name="sortCode">Sort code</param>
        /// <returns>Returns bank details if account number and sort code is valid else returns error message</returns>
        AfdResponse AfdBankFinderAccountNumberValidation(System.String accountNumber, System.String sortCode);

        /// <summary>
        ///     Creates a new <see cref="!:DirectDebitModel" /> instance.
        /// </summary>
        /// <returns>
        ///     A newly instantiated <see cref="!:DirectDebitModel" /> instance.
        /// </returns>
        Consensus.Finance.IDirectDebitModel Create();

        /// <summary>
        ///     Retrieves all instances of the <see cref="!:DirectDebitModel" /> class.
        /// </summary>
        /// <returns>
        ///     An enumerable collection of <see cref="!:DirectDebitModel" /> instances.
        /// </returns>
        System.Collections.Generic.IEnumerable<Consensus.Finance.IDirectDebitModel> FetchAll();

        /// <summary>
        ///     Retrieves a specific <see cref="!:DirectDebitModel" /> instance.
        /// </summary>
        /// <param name="id">
        ///     The unique value which distinctly identifies the <see cref="!:DirectDebitModel" /> instance to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:DirectDebitModel" /> instance that matches the specified <paramref name="id" />; or null, if no matching instance can be found.
        /// </returns>
        Consensus.Finance.IDirectDebitModel FetchById(System.String id);

        System.String GetTableName();

        /// <summary>
        ///     Retrieves a collection of <see cref="!:DirectDebitModel" /> instances.
        /// </summary>
        /// <param name="memberPeriodId">
        ///     The value which identifies the <see cref="!:DirectDebitModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:DirectDebitModel" /> instances that match the specified <paramref name="memberPeriodId" />.
        /// </returns>
        System.Collections.Generic.IEnumerable<Consensus.Finance.IDirectDebitModel> FetchAllByMemberPeriodId(System.String memberPeriodId);
    }
}
