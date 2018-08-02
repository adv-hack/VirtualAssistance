using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Linq;

namespace Consensus.Learning
{
    /// <summary>
    ///     Provides the persistence and retrieval of the <see cref="ProductRecord" /> instances.
    /// </summary>
    /// <remarks>
    ///     THIS CODE HAS BEEN AUTOMATICALLY GENERATED USING THE CONSENSUS DEVELOPER TOOLS.
    ///     DO NOT EDIT THIS CODE AS ANY CUSTOM MODIFICATIONS WILL BE LOST UPON REGENERATION.
    /// </remarks>
    public interface IProductRepository : IRepository<ProductRecord, String>
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

        void Modify(Consensus.Learning.ProductRecord record);

        void Create(Consensus.Learning.ProductRecord record);

        /// <summary>
        ///     Retrieves a single <see cref="T:Consensus.Learning.ProductRecord" /> instance from the data store.
        /// </summary>
        /// <param name="reference">
        ///     The value which identifies the <see cref="T:Consensus.Learning.ProductRecord" /> instance to be returned.
        /// </param>
        /// <returns>
        ///     The first <see cref="T:Consensus.Learning.ProductRecord" /> instance which matches the specified <paramref name="reference" />.
        /// </returns>
        Consensus.Learning.ProductRecord FetchAllByReference(System.String reference);

        /// <summary>
        ///     Retrieves a collection of <see cref="T:Consensus.Learning.ProductRecord" /> instances from the data store.
        /// </summary>
        /// <param name="descrip">
        ///     The value which identifies the <see cref="!:ProductModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The collection of <see cref="T:Consensus.Learning.ProductRecord" /> instances that match the specified <paramref name="descrip" />.
        /// </returns>
        System.Collections.Generic.IEnumerable<Consensus.Learning.ProductRecord> FetchAllByDescrip(System.String descrip);

        /// <summary>
        ///     Retrieves a collection of <see cref="T:Consensus.Learning.ProductRecord" /> instances from the data store.
        /// </summary>
        /// <param name="text1">
        ///     The value which identifies the <see cref="!:ProductModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The collection of <see cref="T:Consensus.Learning.ProductRecord" /> instances that match the specified <paramref name="text1" />.
        /// </returns>
        System.Collections.Generic.IEnumerable<Consensus.Learning.ProductRecord> FetchAllByText1(System.String text1);

        /// <summary>
        ///     Retrieves a collection of <see cref="T:Consensus.Learning.ProductRecord" /> instances from the data store.
        /// </summary>
        /// <param name="text2">
        ///     The value which identifies the <see cref="!:ProductModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The collection of <see cref="T:Consensus.Learning.ProductRecord" /> instances that match the specified <paramref name="text2" />.
        /// </returns>
        System.Collections.Generic.IEnumerable<Consensus.Learning.ProductRecord> FetchAllByText2(System.String text2);

        /// <summary>
        ///     Retrieves a collection of <see cref="T:Consensus.Learning.ProductRecord" /> instances from the data store.
        /// </summary>
        /// <param name="text3">
        ///     The value which identifies the <see cref="!:ProductModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The collection of <see cref="T:Consensus.Learning.ProductRecord" /> instances that match the specified <paramref name="text3" />.
        /// </returns>
        System.Collections.Generic.IEnumerable<Consensus.Learning.ProductRecord> FetchAllByText3(System.String text3);

        /// <summary>
        ///     Retrieves a collection of <see cref="T:Consensus.Learning.ProductRecord" /> instances from the data store.
        /// </summary>
        /// <param name="proleId">
        ///     The value which identifies the <see cref="!:ProductModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The collection of <see cref="T:Consensus.Learning.ProductRecord" /> instances that match the specified <paramref name="proleId" />.
        /// </returns>
        System.Collections.Generic.IEnumerable<Consensus.Learning.ProductRecord> FetchAllByProleId(System.String proleId);

        /// <summary>
        ///     Retrieves a collection of <see cref="T:Consensus.Learning.ProductRecord" /> instances from the data store.
        /// </summary>
        /// <param name="manProleId">
        ///     The value which identifies the <see cref="!:ProductModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The collection of <see cref="T:Consensus.Learning.ProductRecord" /> instances that match the specified <paramref name="manProleId" />.
        /// </returns>
        System.Collections.Generic.IEnumerable<Consensus.Learning.ProductRecord> FetchAllByManProleId(System.String manProleId);

        /// <summary>
        ///     Retrieves a collection of <see cref="T:Consensus.Learning.ProductRecord" /> instances from the data store.
        /// </summary>
        /// <param name="bktId">
        ///     The value which identifies the <see cref="!:ProductModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The collection of <see cref="T:Consensus.Learning.ProductRecord" /> instances that match the specified <paramref name="bktId" />.
        /// </returns>
        System.Collections.Generic.IEnumerable<Consensus.Learning.ProductRecord> FetchAllByBktId(System.String bktId);

        /// <summary>
        ///     Retrieves a collection of <see cref="T:Consensus.Learning.ProductRecord" /> instances from the data store.
        /// </summary>
        /// <param name="locId">
        ///     The value which identifies the <see cref="!:ProductModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The collection of <see cref="T:Consensus.Learning.ProductRecord" /> instances that match the specified <paramref name="locId" />.
        /// </returns>
        System.Collections.Generic.IEnumerable<Consensus.Learning.ProductRecord> FetchAllByLocId(System.String locId);

        /// <summary>
        ///     Retrieves a collection of <see cref="T:Consensus.Learning.ProductRecord" /> instances from the data store.
        /// </summary>
        /// <param name="selcoSpId">
        ///     The value which identifies the <see cref="!:ProductModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The collection of <see cref="T:Consensus.Learning.ProductRecord" /> instances that match the specified <paramref name="selcoSpId" />.
        /// </returns>
        System.Collections.Generic.IEnumerable<Consensus.Learning.ProductRecord> FetchAllBySelcoSpId(System.String selcoSpId);

        /// <summary>
        ///     Retrieves a collection of <see cref="T:Consensus.Learning.ProductRecord" /> instances from the data store.
        /// </summary>
        /// <param name="authPnId">
        ///     The value which identifies the <see cref="!:ProductModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The collection of <see cref="T:Consensus.Learning.ProductRecord" /> instances that match the specified <paramref name="authPnId" />.
        /// </returns>
        System.Collections.Generic.IEnumerable<Consensus.Learning.ProductRecord> FetchAllByAuthPnId(System.String authPnId);

        /// <summary>
        ///     Retrieves a collection of <see cref="T:Consensus.Learning.ProductRecord" /> instances from the data store.
        /// </summary>
        /// <param name="orgId">
        ///     The value which identifies the <see cref="!:ProductModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The collection of <see cref="T:Consensus.Learning.ProductRecord" /> instances that match the specified <paramref name="orgId" />.
        /// </returns>
        System.Collections.Generic.IEnumerable<Consensus.Learning.ProductRecord> FetchAllByOrgId(System.String orgId);

        System.Collections.Generic.IEnumerable<Consensus.Learning.ProductRecord> FetchAllByPshId(System.Nullable<System.Int32> pshId);

        /// <summary>
        ///     Retrieves a collection of <see cref="T:Consensus.Learning.ProductRecord" /> instances from the data store.
        /// </summary>
        /// <param name="trnRulesTxt">
        ///     The value which identifies the <see cref="!:ProductModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The collection of <see cref="T:Consensus.Learning.ProductRecord" /> instances that match the specified <paramref name="trnRulesTxt" />.
        /// </returns>
        System.Collections.Generic.IEnumerable<Consensus.Learning.ProductRecord> FetchAllByTrnRulesTxt(System.String trnRulesTxt);

        /// <summary>
        ///     Retrieves a collection of <see cref="T:Consensus.Learning.ProductRecord" /> instances from the data store.
        /// </summary>
        /// <param name="msNew">
        ///     The value which identifies the <see cref="!:ProductModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The collection of <see cref="T:Consensus.Learning.ProductRecord" /> instances that match the specified <paramref name="msNew" />.
        /// </returns>
        System.Collections.Generic.IEnumerable<Consensus.Learning.ProductRecord> FetchAllByMsNew(System.String msNew);

        /// <summary>
        ///     Retrieves a collection of <see cref="T:Consensus.Learning.ProductRecord" /> instances from the data store.
        /// </summary>
        /// <param name="msRemind1">
        ///     The value which identifies the <see cref="!:ProductModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The collection of <see cref="T:Consensus.Learning.ProductRecord" /> instances that match the specified <paramref name="msRemind1" />.
        /// </returns>
        System.Collections.Generic.IEnumerable<Consensus.Learning.ProductRecord> FetchAllByMsRemind1(System.String msRemind1);

        /// <summary>
        ///     Retrieves a collection of <see cref="T:Consensus.Learning.ProductRecord" /> instances from the data store.
        /// </summary>
        /// <param name="msRemind2">
        ///     The value which identifies the <see cref="!:ProductModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The collection of <see cref="T:Consensus.Learning.ProductRecord" /> instances that match the specified <paramref name="msRemind2" />.
        /// </returns>
        System.Collections.Generic.IEnumerable<Consensus.Learning.ProductRecord> FetchAllByMsRemind2(System.String msRemind2);

        /// <summary>
        ///     Retrieves a collection of <see cref="T:Consensus.Learning.ProductRecord" /> instances from the data store.
        /// </summary>
        /// <param name="msRenew">
        ///     The value which identifies the <see cref="!:ProductModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The collection of <see cref="T:Consensus.Learning.ProductRecord" /> instances that match the specified <paramref name="msRenew" />.
        /// </returns>
        System.Collections.Generic.IEnumerable<Consensus.Learning.ProductRecord> FetchAllByMsRenew(System.String msRenew);

        /// <summary>
        ///     Retrieves a collection of <see cref="T:Consensus.Learning.ProductRecord" /> instances from the data store.
        /// </summary>
        /// <param name="msLapsed">
        ///     The value which identifies the <see cref="!:ProductModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The collection of <see cref="T:Consensus.Learning.ProductRecord" /> instances that match the specified <paramref name="msLapsed" />.
        /// </returns>
        System.Collections.Generic.IEnumerable<Consensus.Learning.ProductRecord> FetchAllByMsLapsed(System.String msLapsed);

        /// <summary>
        ///     Retrieves a collection of <see cref="T:Consensus.Learning.ProductRecord" /> instances from the data store.
        /// </summary>
        /// <param name="msCancel">
        ///     The value which identifies the <see cref="!:ProductModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The collection of <see cref="T:Consensus.Learning.ProductRecord" /> instances that match the specified <paramref name="msCancel" />.
        /// </returns>
        System.Collections.Generic.IEnumerable<Consensus.Learning.ProductRecord> FetchAllByMsCancel(System.String msCancel);

        /// <summary>
        ///     Retrieves a collection of <see cref="T:Consensus.Learning.ProductRecord" /> instances from the data store.
        /// </summary>
        /// <param name="msRemind3">
        ///     The value which identifies the <see cref="!:ProductModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The collection of <see cref="T:Consensus.Learning.ProductRecord" /> instances that match the specified <paramref name="msRemind3" />.
        /// </returns>
        System.Collections.Generic.IEnumerable<Consensus.Learning.ProductRecord> FetchAllByMsRemind3(System.String msRemind3);

        /// <summary>
        ///     Retrieves a collection of <see cref="T:Consensus.Learning.ProductRecord" /> instances from the data store.
        /// </summary>
        /// <param name="msRenewed">
        ///     The value which identifies the <see cref="!:ProductModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The collection of <see cref="T:Consensus.Learning.ProductRecord" /> instances that match the specified <paramref name="msRenewed" />.
        /// </returns>
        System.Collections.Generic.IEnumerable<Consensus.Learning.ProductRecord> FetchAllByMsRenewed(System.String msRenewed);

        /// <summary>
        ///     Retrieves a collection of <see cref="T:Consensus.Learning.ProductRecord" /> instances from the data store.
        /// </summary>
        /// <param name="msApp">
        ///     The value which identifies the <see cref="!:ProductModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The collection of <see cref="T:Consensus.Learning.ProductRecord" /> instances that match the specified <paramref name="msApp" />.
        /// </returns>
        System.Collections.Generic.IEnumerable<Consensus.Learning.ProductRecord> FetchAllByMsApp(System.String msApp);

        /// <summary>
        ///     Retrieves a collection of <see cref="T:Consensus.Learning.ProductRecord" /> instances from the data store.
        /// </summary>
        /// <param name="msOff">
        ///     The value which identifies the <see cref="!:ProductModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The collection of <see cref="T:Consensus.Learning.ProductRecord" /> instances that match the specified <paramref name="msOff" />.
        /// </returns>
        System.Collections.Generic.IEnumerable<Consensus.Learning.ProductRecord> FetchAllByMsOff(System.String msOff);

        #endregion
    }
}
