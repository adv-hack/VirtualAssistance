using System;
using System.Collections.Generic;
using System.Linq;
using Consensus.Common;

namespace Consensus.Finance
{
    /// <remarks>
    ///     THIS CODE HAS BEEN AUTOMATICALLY GENERATED USING THE CONSENSUS DEVELOPER TOOLS.
    ///     DO NOT EDIT THIS CODE AS ANY CUSTOM MODIFICATIONS WILL BE LOST UPON REGENERATION.
    /// </remarks>
    public partial class CostCode : Proxy<ICostCodeModel, String>
    {
        #region fields

        /// <summary>
        ///     The client-consumable proxy instance for the <see cref="SelcoSpId" /> member.
        /// </summary>
        private Consensus.Common.SellingCompany _selcoSpId;

        #endregion

        #region properties

        /// <summary>
        ///     Gets or sets the value of the "COST_CODE" field.
        /// </summary>
        public System.String Code
        {
            get { return this.Model.Code; }
            set { this.Model.Code = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "COST_DESC" field.
        /// </summary>
        public System.String Desc
        {
            get { return this.Model.Desc; }
            set { this.Model.Desc = value; }
        }

        /// <summary>
        ///     Gets the The value of the "COST_SELCO_SP_ID" field.
        /// </summary>
        public Consensus.Common.SellingCompany SelcoSpId
        {
            get
            {
                if (_selcoSpId == null && this.Model.SelcoSpId != null)
                    _selcoSpId = new Consensus.Common.SellingCompany(this.Model.SelcoSpId);
                if (_selcoSpId == null)
                    _selcoSpId = Consensus.Common.SellingCompany.Create();
                return _selcoSpId;
            }
        }

        /// <summary>
        ///     Gets or sets the unique code for the value of the "COST_SELCO_SP_ID" field.
        /// </summary>
        public System.String SelcoSpIdId
        {
            get { return this.Model.SelcoSpIdId; }
            set { this.Model.SelcoSpIdId = value; }
        }

        #endregion

        #region constructors

        /// <summary>
        ///     Initialises a new instance of the client-consumable class.
        /// </summary>
        internal CostCode(ICostCodeModel model) : base(model)
        {
        }

        #endregion

        #region methods

        /// <summary>
        ///     Checks if Country's name or code exist.
        /// </summary>
        /// <param name="code">
        ///     Name of the country.
        /// </param>
        /// <param name="sellingCompId">
        ///     Code of the country.
        /// </param>
        /// <param name="costCodeId">
        ///     Id of the country.
        /// </param>
        /// <returns>
        ///     Whether country's name or code exist in database.
        /// </returns>
        public static System.Boolean CheckIfCodeExist(System.String code, System.String sellingCompId, System.String costCodeId)
        {
            ConsensusSite site = ConsensusDomain.Configuration[ConsensusDomain.Configuration.DefaultSite];
            return CostCode.CheckIfCodeExist(site,code,sellingCompId,costCodeId);
        }

        /// <summary>
        ///     Checks if Country's name or code exist.
        /// </summary>
        /// <param name="code">
        ///     Name of the country.
        /// </param>
        /// <param name="sellingCompId">
        ///     Code of the country.
        /// </param>
        /// <param name="costCodeId">
        ///     Id of the country.
        /// </param>
        /// <returns>
        ///     Whether country's name or code exist in database.
        /// </returns>
        public static System.Boolean CheckIfCodeExist(ConsensusSite site, System.String code, System.String sellingCompId, System.String costCodeId)
        {
            IBusinessProvider provider = site.GetService<IBusinessProvider>();
            return provider.Finance.CostCode.CheckIfCodeExist(code,sellingCompId,costCodeId);
        }

        /// <summary>
        ///     Creates a new <see cref="!:CostCodeModel" /> instance.
        /// </summary>
        /// <returns>
        ///     A newly instantiated <see cref="!:CostCodeModel" /> instance.
        /// </returns>
        public static Consensus.Finance.CostCode Create()
        {
            ConsensusSite site = ConsensusDomain.Configuration[ConsensusDomain.Configuration.DefaultSite];
            return CostCode.Create(site);
        }

        /// <summary>
        ///     Creates a new <see cref="!:CostCodeModel" /> instance.
        /// </summary>
        /// <returns>
        ///     A newly instantiated <see cref="!:CostCodeModel" /> instance.
        /// </returns>
        public static Consensus.Finance.CostCode Create(ConsensusSite site)
        {
            IBusinessProvider provider = site.GetService<IBusinessProvider>();
            Consensus.Finance.ICostCodeModel model = provider.Finance.CostCode.Create();
            return model == null ? null : new Consensus.Finance.CostCode(model);
        }

        /// <summary>
        ///     Retrieves all instances of the <see cref="!:CostCodeModel" /> class.
        /// </summary>
        /// <returns>
        ///     An enumerable collection of <see cref="!:CostCodeModel" /> instances.
        /// </returns>
        public static IEnumerable<Consensus.Finance.CostCode> FetchAll()
        {
            ConsensusSite site = ConsensusDomain.Configuration[ConsensusDomain.Configuration.DefaultSite];
            return CostCode.FetchAll(site);
        }

        /// <summary>
        ///     Retrieves all instances of the <see cref="!:CostCodeModel" /> class.
        /// </summary>
        /// <returns>
        ///     An enumerable collection of <see cref="!:CostCodeModel" /> instances.
        /// </returns>
        public static IEnumerable<Consensus.Finance.CostCode> FetchAll(ConsensusSite site)
        {
            IBusinessProvider provider = site.GetService<IBusinessProvider>();
            IEnumerable<Consensus.Finance.ICostCodeModel> collection = provider.Finance.CostCode.FetchAll();
            return collection.Select(model => new Consensus.Finance.CostCode(model));
        }

        /// <summary>
        ///     Retrieves a specific <see cref="!:CostCodeModel" /> instance.
        /// </summary>
        /// <param name="id">
        ///     The unique value which distinctly identifies the <see cref="!:CostCodeModel" /> instance to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:CostCodeModel" /> instance that matches the specified <paramref name="id" />; or null, if no matching instance can be found.
        /// </returns>
        public static Consensus.Finance.CostCode FetchById(System.String id)
        {
            ConsensusSite site = ConsensusDomain.Configuration[ConsensusDomain.Configuration.DefaultSite];
            return CostCode.FetchById(site,id);
        }

        /// <summary>
        ///     Retrieves a specific <see cref="!:CostCodeModel" /> instance.
        /// </summary>
        /// <param name="id">
        ///     The unique value which distinctly identifies the <see cref="!:CostCodeModel" /> instance to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:CostCodeModel" /> instance that matches the specified <paramref name="id" />; or null, if no matching instance can be found.
        /// </returns>
        public static Consensus.Finance.CostCode FetchById(ConsensusSite site, System.String id)
        {
            IBusinessProvider provider = site.GetService<IBusinessProvider>();
            Consensus.Finance.ICostCodeModel model = provider.Finance.CostCode.FetchById(id);
            return model == null ? null : new Consensus.Finance.CostCode(model);
        }

        public static System.String GetTableName()
        {
            ConsensusSite site = ConsensusDomain.Configuration[ConsensusDomain.Configuration.DefaultSite];
            return CostCode.GetTableName(site);
        }

        public static System.String GetTableName(ConsensusSite site)
        {
            IBusinessProvider provider = site.GetService<IBusinessProvider>();
            return provider.Finance.CostCode.GetTableName();
        }

        /// <summary>
        ///     Retrieves a collection of <see cref="!:CostCodeModel" /> instances.
        /// </summary>
        /// <param name="selcoSpIdId">
        ///     The value which identifies the <see cref="!:CostCodeModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:CostCodeModel" /> instances that match the specified <paramref name="selcoSpIdId" />.
        /// </returns>
        public static IEnumerable<Consensus.Finance.CostCode> FetchAllBySelcoSpIdId(System.String selcoSpIdId)
        {
            ConsensusSite site = ConsensusDomain.Configuration[ConsensusDomain.Configuration.DefaultSite];
            return CostCode.FetchAllBySelcoSpIdId(site,selcoSpIdId);
        }

        /// <summary>
        ///     Retrieves a collection of <see cref="!:CostCodeModel" /> instances.
        /// </summary>
        /// <param name="selcoSpIdId">
        ///     The value which identifies the <see cref="!:CostCodeModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:CostCodeModel" /> instances that match the specified <paramref name="selcoSpIdId" />.
        /// </returns>
        public static IEnumerable<Consensus.Finance.CostCode> FetchAllBySelcoSpIdId(ConsensusSite site, System.String selcoSpIdId)
        {
            IBusinessProvider provider = site.GetService<IBusinessProvider>();
            IEnumerable<Consensus.Finance.ICostCodeModel> collection = provider.Finance.CostCode.FetchAllBySelcoSpIdId(selcoSpIdId);
            return collection.Select(model => new Consensus.Finance.CostCode(model));
        }

        #endregion
    }
}
