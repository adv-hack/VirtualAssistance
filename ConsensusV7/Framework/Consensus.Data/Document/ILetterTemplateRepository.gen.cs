using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Linq;

namespace Consensus.Document
{
    /// <summary>
    ///     Provides the persistence and retrieval of the <see cref="LettertmpltRecord" /> instances.
    /// </summary>
    /// <remarks>
    ///     THIS CODE HAS BEEN AUTOMATICALLY GENERATED USING THE CONSENSUS DEVELOPER TOOLS.
    ///     DO NOT EDIT THIS CODE AS ANY CUSTOM MODIFICATIONS WILL BE LOST UPON REGENERATION.
    /// </remarks>
    public interface ILetterTemplateRepository : IRepository<LettertmpltRecord, String>
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

        void Create(Consensus.Document.LettertmpltRecord record);

        void Modify(Consensus.Document.LettertmpltRecord record);

        /// <summary>
        ///     Retrieves a collection of <see cref="T:Consensus.Document.LettertmpltRecord" /> instances from the data store.
        /// </summary>
        /// <param name="type">
        ///     The value which identifies the <see cref="!:LetterTemplateModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The collection of <see cref="T:Consensus.Document.LettertmpltRecord" /> instances that match the specified <paramref name="type" />.
        /// </returns>
        System.Collections.Generic.IEnumerable<Consensus.Document.LettertmpltRecord> FetchAllByType(System.String type);

        /// <summary>
        ///     Retrieves a collection of <see cref="T:Consensus.Document.LettertmpltRecord" /> instances from the data store.
        /// </summary>
        /// <param name="selcoSpId">
        ///     The value which identifies the <see cref="!:LetterTemplateModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The collection of <see cref="T:Consensus.Document.LettertmpltRecord" /> instances that match the specified <paramref name="selcoSpId" />.
        /// </returns>
        System.Collections.Generic.IEnumerable<Consensus.Document.LettertmpltRecord> FetchAllBySelcoSpId(System.String selcoSpId);

        /// <summary>
        ///     Retrieves a collection of <see cref="T:Consensus.Document.LettertmpltRecord" /> instances from the data store.
        /// </summary>
        /// <param name="sendProleId">
        ///     The value which identifies the <see cref="!:LetterTemplateModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The collection of <see cref="T:Consensus.Document.LettertmpltRecord" /> instances that match the specified <paramref name="sendProleId" />.
        /// </returns>
        System.Collections.Generic.IEnumerable<Consensus.Document.LettertmpltRecord> FetchAllBySendProleId(System.String sendProleId);

        #endregion
    }
}
