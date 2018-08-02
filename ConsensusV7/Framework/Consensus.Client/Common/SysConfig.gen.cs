using System;
using System.Collections.Generic;
using System.Linq;

namespace Consensus.Common
{
    /// <remarks>
    ///     THIS CODE HAS BEEN AUTOMATICALLY GENERATED USING THE CONSENSUS DEVELOPER TOOLS.
    ///     DO NOT EDIT THIS CODE AS ANY CUSTOM MODIFICATIONS WILL BE LOST UPON REGENERATION.
    /// </remarks>
    public partial class SysConfig : Proxy<ISysConfigModel, Int32>
    {
        #region fields

        /// <summary>
        ///     The client-consumable proxy instance for the <see cref="SellingCompany" /> member.
        /// </summary>
        private Consensus.Common.SellingCompany _sellingCompany;

        #endregion

        #region properties

        /// <summary>
        ///     Gets or sets the value of the "SC_ADD_DATE" field.
        /// </summary>
        public System.Nullable<System.DateTime> AddDate
        {
            get { return this.Model.AddDate; }
            set { this.Model.AddDate = value; }
        }

        /// <summary>
        ///     Gets the The value of the "SC_SP_ID" field.
        /// </summary>
        public Consensus.Common.SellingCompany SellingCompany
        {
            get
            {
                if (_sellingCompany == null && this.Model.SellingCompany != null)
                    _sellingCompany = new Consensus.Common.SellingCompany(this.Model.SellingCompany);
                if (_sellingCompany == null)
                    _sellingCompany = Consensus.Common.SellingCompany.Create();
                return _sellingCompany;
            }
        }

        /// <summary>
        ///     Gets or sets the unique code for the value of the "SC_SP_ID" field.
        /// </summary>
        public System.String SellingCompanyId
        {
            get { return this.Model.SellingCompanyId; }
            set { this.Model.SellingCompanyId = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "SC_KEY_NAME" field.
        /// </summary>
        public System.String KeyName
        {
            get { return this.Model.KeyName; }
            set { this.Model.KeyName = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "SC_VALUE_TO_USE" field.
        /// </summary>
        public System.Nullable<System.Byte> ValueToUse
        {
            get { return this.Model.ValueToUse; }
            set { this.Model.ValueToUse = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "SC_LABEL_NAME" field.
        /// </summary>
        public System.String LabelName
        {
            get { return this.Model.LabelName; }
            set { this.Model.LabelName = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "SC_CHAR_VALUE" field.
        /// </summary>
        public System.String CharValue
        {
            get { return this.Model.CharValue; }
            set { this.Model.CharValue = value; }
        }

        #endregion

        #region constructors

        /// <summary>
        ///     Initialises a new instance of the client-consumable class.
        /// </summary>
        internal SysConfig(ISysConfigModel model) : base(model)
        {
        }

        #endregion

        #region methods

        /// <summary>
        ///     Creates a new <see cref="!:SysConfigModel" /> instance.
        /// </summary>
        /// <returns>
        ///     A newly instantiated <see cref="!:SysConfigModel" /> instance.
        /// </returns>
        public static Consensus.Common.SysConfig Create()
        {
            ConsensusSite site = ConsensusDomain.Configuration[ConsensusDomain.Configuration.DefaultSite];
            return SysConfig.Create(site);
        }

        /// <summary>
        ///     Creates a new <see cref="!:SysConfigModel" /> instance.
        /// </summary>
        /// <returns>
        ///     A newly instantiated <see cref="!:SysConfigModel" /> instance.
        /// </returns>
        public static Consensus.Common.SysConfig Create(ConsensusSite site)
        {
            IBusinessProvider provider = site.GetService<IBusinessProvider>();
            Consensus.Common.ISysConfigModel model = provider.Common.SysConfig.Create();
            return model == null ? null : new Consensus.Common.SysConfig(model);
        }

        /// <summary>
        ///     Retrieves all instances of the <see cref="!:SysConfigModel" /> class.
        /// </summary>
        /// <returns>
        ///     An enumerable collection of <see cref="!:SysConfigModel" /> instances.
        /// </returns>
        public static IEnumerable<Consensus.Common.SysConfig> FetchAll()
        {
            ConsensusSite site = ConsensusDomain.Configuration[ConsensusDomain.Configuration.DefaultSite];
            return SysConfig.FetchAll(site);
        }

        /// <summary>
        ///     Retrieves all instances of the <see cref="!:SysConfigModel" /> class.
        /// </summary>
        /// <returns>
        ///     An enumerable collection of <see cref="!:SysConfigModel" /> instances.
        /// </returns>
        public static IEnumerable<Consensus.Common.SysConfig> FetchAll(ConsensusSite site)
        {
            IBusinessProvider provider = site.GetService<IBusinessProvider>();
            IEnumerable<Consensus.Common.ISysConfigModel> collection = provider.Common.SysConfig.FetchAll();
            return collection.Select(model => new Consensus.Common.SysConfig(model));
        }

        /// <summary>
        ///     Retrieves a specific <see cref="!:SysConfigModel" /> instance.
        /// </summary>
        /// <param name="id">
        ///     The unique value which distinctly identifies the <see cref="!:SysConfigModel" /> instance to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:SysConfigModel" /> instance that matches the specified <paramref name="id" />; or null, if no matching instance can be found.
        /// </returns>
        public static Consensus.Common.SysConfig FetchById(System.Int32 id)
        {
            ConsensusSite site = ConsensusDomain.Configuration[ConsensusDomain.Configuration.DefaultSite];
            return SysConfig.FetchById(site,id);
        }

        /// <summary>
        ///     Retrieves a specific <see cref="!:SysConfigModel" /> instance.
        /// </summary>
        /// <param name="id">
        ///     The unique value which distinctly identifies the <see cref="!:SysConfigModel" /> instance to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:SysConfigModel" /> instance that matches the specified <paramref name="id" />; or null, if no matching instance can be found.
        /// </returns>
        public static Consensus.Common.SysConfig FetchById(ConsensusSite site, System.Int32 id)
        {
            IBusinessProvider provider = site.GetService<IBusinessProvider>();
            Consensus.Common.ISysConfigModel model = provider.Common.SysConfig.FetchById(id);
            return model == null ? null : new Consensus.Common.SysConfig(model);
        }

        public static System.String GetTableName()
        {
            ConsensusSite site = ConsensusDomain.Configuration[ConsensusDomain.Configuration.DefaultSite];
            return SysConfig.GetTableName(site);
        }

        public static System.String GetTableName(ConsensusSite site)
        {
            IBusinessProvider provider = site.GetService<IBusinessProvider>();
            return provider.Common.SysConfig.GetTableName();
        }

        /// <summary>
        ///     Retrieves a collection of <see cref="!:SysConfigModel" /> instances.
        /// </summary>
        /// <param name="sellingCompanyId">
        ///     The value which identifies the <see cref="!:SysConfigModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:SysConfigModel" /> instances that match the specified <paramref name="sellingCompanyId" />.
        /// </returns>
        public static IEnumerable<Consensus.Common.SysConfig> FetchAllBySellingCompanyId(System.String sellingCompanyId)
        {
            ConsensusSite site = ConsensusDomain.Configuration[ConsensusDomain.Configuration.DefaultSite];
            return SysConfig.FetchAllBySellingCompanyId(site,sellingCompanyId);
        }

        /// <summary>
        ///     Retrieves a collection of <see cref="!:SysConfigModel" /> instances.
        /// </summary>
        /// <param name="sellingCompanyId">
        ///     The value which identifies the <see cref="!:SysConfigModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:SysConfigModel" /> instances that match the specified <paramref name="sellingCompanyId" />.
        /// </returns>
        public static IEnumerable<Consensus.Common.SysConfig> FetchAllBySellingCompanyId(ConsensusSite site, System.String sellingCompanyId)
        {
            IBusinessProvider provider = site.GetService<IBusinessProvider>();
            IEnumerable<Consensus.Common.ISysConfigModel> collection = provider.Common.SysConfig.FetchAllBySellingCompanyId(sellingCompanyId);
            return collection.Select(model => new Consensus.Common.SysConfig(model));
        }

        #endregion
    }
}
