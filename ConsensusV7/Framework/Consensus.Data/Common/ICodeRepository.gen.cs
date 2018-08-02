using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Linq;

namespace Consensus.Common
{
    /// <summary>
    ///     Provides the persistence and retrieval of the <see cref="CodeRecord" /> instances.
    /// </summary>
    /// <remarks>
    ///     THIS CODE HAS BEEN AUTOMATICALLY GENERATED USING THE CONSENSUS DEVELOPER TOOLS.
    ///     DO NOT EDIT THIS CODE AS ANY CUSTOM MODIFICATIONS WILL BE LOST UPON REGENERATION.
    /// </remarks>
    public interface ICodeRepository : IRepository<CodeRecord, String>
    {
        #region properties

        /// <summary>
        ///     Gets the underlying table name that this repository sit over.
        /// </summary>
        System.String TableName
        {
            get;
        }

        #endregion

        #region methods

        /// <summary>
        ///     Retrieves a single <typeparamref name="TRecord" /> instance from the data store.
        /// </summary>
        /// <returns>
        ///     The <typeparamref name="TRecord" /> instance that matches the specified <paramref name="id" />; or null, if no matching instance can be found.
        /// </returns>
        Consensus.Common.CodeRecord FetchByTypeAndCode(System.String type, System.String code);

        /// <summary>
        ///     Retrieves a single <see cref="T:Consensus.Common.CodeRecord" /> instance from the data store.
        /// </summary>
        /// <param name="type">
        ///     The type code which distinctly identifies the type of <see cref="T:Consensus.Common.CodeRecord" /> instance to be returned.
        /// </param>
        /// <param name="codeValue3">
        ///     The unique value which distinctly identifies the <see cref="T:Consensus.Common.CodeRecord" /> instance to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="T:Consensus.Common.CodeRecord" /> instance that matches the specified <paramref name="codeValue3" />; or null, if no matching instance can be found.
        /// </returns>
        Consensus.Common.CodeRecord FetchByTypeAndCodeValue3(System.String type, System.String codeValue3);

        /// <summary>
        ///     Retrieves a single <typeparamref name="TRecord" /> instance from the data store.
        /// </summary>
        /// <returns>
        ///     The <typeparamref name="TRecord" /> instance that matches the specified <paramref name="id" />; or null, if no matching instance can be found.
        /// </returns>
        System.Collections.Generic.IEnumerable<Consensus.Common.CodeRecord> FetchAllByType(System.String type);

        void RemoveById(Consensus.Common.CodeRecord record);

        #endregion
    }
}
