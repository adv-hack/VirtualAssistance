using System;
using System.Collections.Generic;
using System.Linq;

namespace Consensus.Common
{
    /// <summary>
    ///     Represents A configuration value that applies to a selling company.
    /// </summary>
    /// <remarks>
    ///     THIS CODE HAS BEEN AUTOMATICALLY GENERATED USING THE CONSENSUS DEVELOPER TOOLS.
    ///     DO NOT EDIT THIS CODE AS ANY CUSTOM MODIFICATIONS WILL BE LOST UPON REGENERATION.
    /// </remarks>
    public partial class SellingCompanyConfig : Proxy<ISellingCompanyConfigModel, Int32>
    {
        #region properties

        /// <summary>
        ///     Gets or sets the configuration value.
        /// </summary>
        public System.Object Value
        {
            get { return this.Model.Value; }
            set { this.Model.Value = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "SC_SP_ID" field.
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

        /// <summary>
        ///     Gets or sets the value of the "SC_RECORD_ID" field.
        /// </summary>
        public System.String RecordId
        {
            get { return this.Model.RecordId; }
            set { this.Model.RecordId = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "SC_INT_VALUE" field.
        /// </summary>
        public System.Nullable<System.Int32> IntValue
        {
            get { return this.Model.IntValue; }
            set { this.Model.IntValue = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "SC_DATETIME_VALUE" field.
        /// </summary>
        public System.Nullable<System.DateTime> DatetimeValue
        {
            get { return this.Model.DatetimeValue; }
            set { this.Model.DatetimeValue = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "SC_DECIMAL_VALUE" field.
        /// </summary>
        public System.Nullable<System.Decimal> DecimalValue
        {
            get { return this.Model.DecimalValue; }
            set { this.Model.DecimalValue = value; }
        }

        #endregion

        #region constructors

        /// <summary>
        ///     Initialises a new instance of the client-consumable class.
        /// </summary>
        internal SellingCompanyConfig(ISellingCompanyConfigModel model) : base(model)
        {
        }

        #endregion

        #region methods

        /// <summary>
        ///     Retrieves a specific <see cref="!:SellingCompanyConfigModel" /> instance.
        /// </summary>
        /// <returns>
        ///     The <see cref="!:SellingCompanyConfigModel" /> instance that matches the specified <paramref name="sellingCompanyId" />; or null, if no matching instance can be found.
        /// </returns>
        public static IEnumerable<Consensus.Common.SellingCompanyConfig> FetchAllBySellingCompanyIdKeyName(System.String sellingCompanyId, System.String keyName)
        {
            ConsensusSite site = ConsensusDomain.Configuration[ConsensusDomain.Configuration.DefaultSite];
            return SellingCompanyConfig.FetchAllBySellingCompanyIdKeyName(site,sellingCompanyId,keyName);
        }

        /// <summary>
        ///     Retrieves a specific <see cref="!:SellingCompanyConfigModel" /> instance.
        /// </summary>
        /// <returns>
        ///     The <see cref="!:SellingCompanyConfigModel" /> instance that matches the specified <paramref name="sellingCompanyId" />; or null, if no matching instance can be found.
        /// </returns>
        public static IEnumerable<Consensus.Common.SellingCompanyConfig> FetchAllBySellingCompanyIdKeyName(ConsensusSite site, System.String sellingCompanyId, System.String keyName)
        {
            IBusinessProvider provider = site.GetService<IBusinessProvider>();
            IEnumerable<Consensus.Common.ISellingCompanyConfigModel> collection = provider.Common.SellingCompanyConfig.FetchAllBySellingCompanyIdKeyName(sellingCompanyId,keyName);
            return collection.Select(model => new Consensus.Common.SellingCompanyConfig(model));
        }

        /// <summary>
        ///     Creates a new <see cref="!:SellingCompanyConfigModel" /> instance.
        /// </summary>
        /// <returns>
        ///     A newly instantiated <see cref="!:SellingCompanyConfigModel" /> instance.
        /// </returns>
        public static Consensus.Common.SellingCompanyConfig Create()
        {
            ConsensusSite site = ConsensusDomain.Configuration[ConsensusDomain.Configuration.DefaultSite];
            return SellingCompanyConfig.Create(site);
        }

        /// <summary>
        ///     Creates a new <see cref="!:SellingCompanyConfigModel" /> instance.
        /// </summary>
        /// <returns>
        ///     A newly instantiated <see cref="!:SellingCompanyConfigModel" /> instance.
        /// </returns>
        public static Consensus.Common.SellingCompanyConfig Create(ConsensusSite site)
        {
            IBusinessProvider provider = site.GetService<IBusinessProvider>();
            Consensus.Common.ISellingCompanyConfigModel model = provider.Common.SellingCompanyConfig.Create();
            return model == null ? null : new Consensus.Common.SellingCompanyConfig(model);
        }

        /// <summary>
        ///     Retrieves all instances of the <see cref="!:SellingCompanyConfigModel" /> class.
        /// </summary>
        /// <returns>
        ///     An enumerable collection of <see cref="!:SellingCompanyConfigModel" /> instances.
        /// </returns>
        public static IEnumerable<Consensus.Common.SellingCompanyConfig> FetchAll()
        {
            ConsensusSite site = ConsensusDomain.Configuration[ConsensusDomain.Configuration.DefaultSite];
            return SellingCompanyConfig.FetchAll(site);
        }

        /// <summary>
        ///     Retrieves all instances of the <see cref="!:SellingCompanyConfigModel" /> class.
        /// </summary>
        /// <returns>
        ///     An enumerable collection of <see cref="!:SellingCompanyConfigModel" /> instances.
        /// </returns>
        public static IEnumerable<Consensus.Common.SellingCompanyConfig> FetchAll(ConsensusSite site)
        {
            IBusinessProvider provider = site.GetService<IBusinessProvider>();
            IEnumerable<Consensus.Common.ISellingCompanyConfigModel> collection = provider.Common.SellingCompanyConfig.FetchAll();
            return collection.Select(model => new Consensus.Common.SellingCompanyConfig(model));
        }

        /// <summary>
        ///     Retrieves a specific <see cref="!:SellingCompanyConfigModel" /> instance.
        /// </summary>
        /// <param name="id">
        ///     The unique value which distinctly identifies the <see cref="!:SellingCompanyConfigModel" /> instance to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:SellingCompanyConfigModel" /> instance that matches the specified <paramref name="id" />; or null, if no matching instance can be found.
        /// </returns>
        public static Consensus.Common.SellingCompanyConfig FetchById(System.Int32 id)
        {
            ConsensusSite site = ConsensusDomain.Configuration[ConsensusDomain.Configuration.DefaultSite];
            return SellingCompanyConfig.FetchById(site,id);
        }

        /// <summary>
        ///     Retrieves a specific <see cref="!:SellingCompanyConfigModel" /> instance.
        /// </summary>
        /// <param name="id">
        ///     The unique value which distinctly identifies the <see cref="!:SellingCompanyConfigModel" /> instance to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:SellingCompanyConfigModel" /> instance that matches the specified <paramref name="id" />; or null, if no matching instance can be found.
        /// </returns>
        public static Consensus.Common.SellingCompanyConfig FetchById(ConsensusSite site, System.Int32 id)
        {
            IBusinessProvider provider = site.GetService<IBusinessProvider>();
            Consensus.Common.ISellingCompanyConfigModel model = provider.Common.SellingCompanyConfig.FetchById(id);
            return model == null ? null : new Consensus.Common.SellingCompanyConfig(model);
        }

        public static System.String GetTableName()
        {
            ConsensusSite site = ConsensusDomain.Configuration[ConsensusDomain.Configuration.DefaultSite];
            return SellingCompanyConfig.GetTableName(site);
        }

        public static System.String GetTableName(ConsensusSite site)
        {
            IBusinessProvider provider = site.GetService<IBusinessProvider>();
            return provider.Common.SellingCompanyConfig.GetTableName();
        }

        #endregion
    }
}
