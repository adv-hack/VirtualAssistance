using System;
using System.Collections.Generic;
using System.Linq;

namespace Consensus.Common
{
    /// <remarks>
    ///     THIS CODE HAS BEEN AUTOMATICALLY GENERATED USING THE CONSENSUS DEVELOPER TOOLS.
    ///     DO NOT EDIT THIS CODE AS ANY CUSTOM MODIFICATIONS WILL BE LOST UPON REGENERATION.
    /// </remarks>
    public partial class GenericModel : Proxy<IGenericModelModel, String>
    {
        #region properties

        /// <summary>
        ///     Gets or sets the value of the "GMT_ID1" field.
        /// </summary>
        public System.String Id1
        {
            get { return this.Model.Id1; }
            set { this.Model.Id1 = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "GMT_ID2" field.
        /// </summary>
        public System.String Id2
        {
            get { return this.Model.Id2; }
            set { this.Model.Id2 = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "GMT_ID3" field.
        /// </summary>
        public System.String Id3
        {
            get { return this.Model.Id3; }
            set { this.Model.Id3 = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "GMT_ID4" field.
        /// </summary>
        public System.String Id4
        {
            get { return this.Model.Id4; }
            set { this.Model.Id4 = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "GMT_ID5" field.
        /// </summary>
        public System.String Id5
        {
            get { return this.Model.Id5; }
            set { this.Model.Id5 = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "GMT_DESC1" field.
        /// </summary>
        public System.String Desc1
        {
            get { return this.Model.Desc1; }
            set { this.Model.Desc1 = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "GMT_DESC2" field.
        /// </summary>
        public System.String Desc2
        {
            get { return this.Model.Desc2; }
            set { this.Model.Desc2 = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "GMT_DESC3" field.
        /// </summary>
        public System.String Desc3
        {
            get { return this.Model.Desc3; }
            set { this.Model.Desc3 = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "GMT_DESC4" field.
        /// </summary>
        public System.String Desc4
        {
            get { return this.Model.Desc4; }
            set { this.Model.Desc4 = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "GMT_DESC5" field.
        /// </summary>
        public System.String Desc5
        {
            get { return this.Model.Desc5; }
            set { this.Model.Desc5 = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "GMT_LONGDESC" field.
        /// </summary>
        public System.String Longdesc
        {
            get { return this.Model.Longdesc; }
            set { this.Model.Longdesc = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "GMT_DATE1" field.
        /// </summary>
        public System.Nullable<System.DateTime> Date1
        {
            get { return this.Model.Date1; }
            set { this.Model.Date1 = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "GMT_DATE2" field.
        /// </summary>
        public System.Nullable<System.DateTime> Date2
        {
            get { return this.Model.Date2; }
            set { this.Model.Date2 = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "GMT_DATE3" field.
        /// </summary>
        public System.Nullable<System.DateTime> Date3
        {
            get { return this.Model.Date3; }
            set { this.Model.Date3 = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "GMT_INT1" field.
        /// </summary>
        public System.Nullable<System.Int32> Int1
        {
            get { return this.Model.Int1; }
            set { this.Model.Int1 = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "GMT_INT2" field.
        /// </summary>
        public System.Nullable<System.Int32> Int2
        {
            get { return this.Model.Int2; }
            set { this.Model.Int2 = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "GMT_INT3" field.
        /// </summary>
        public System.Nullable<System.Int32> Int3
        {
            get { return this.Model.Int3; }
            set { this.Model.Int3 = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "GMT_MONEY1" field.
        /// </summary>
        public System.Nullable<System.Decimal> Money1
        {
            get { return this.Model.Money1; }
            set { this.Model.Money1 = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "GMT_MONEY2" field.
        /// </summary>
        public System.Nullable<System.Decimal> Money2
        {
            get { return this.Model.Money2; }
            set { this.Model.Money2 = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "GMT_MONEY3" field.
        /// </summary>
        public System.Nullable<System.Decimal> Money3
        {
            get { return this.Model.Money3; }
            set { this.Model.Money3 = value; }
        }

        #endregion

        #region constructors

        /// <summary>
        ///     Initialises a new instance of the client-consumable class.
        /// </summary>
        internal GenericModel(IGenericModelModel model) : base(model)
        {
        }

        #endregion

        #region methods

        /// <summary>
        ///     Retrieves a specific <see cref="!:GenericModelModel" /> instance.
        /// </summary>
        /// <returns>
        ///     The <see cref="!:GenericModelModel" /> instance that matches the specified <paramref name="accId" />; or null, if no matching instance can be found.
        /// </returns>
        public static IEnumerable<Consensus.Common.GenericModel> FetchAllByAccIdAccountXref(System.String accId, System.String proleId)
        {
            ConsensusSite site = ConsensusDomain.Configuration[ConsensusDomain.Configuration.DefaultSite];
            return GenericModel.FetchAllByAccIdAccountXref(site,accId,proleId);
        }

        /// <summary>
        ///     Retrieves a specific <see cref="!:GenericModelModel" /> instance.
        /// </summary>
        /// <returns>
        ///     The <see cref="!:GenericModelModel" /> instance that matches the specified <paramref name="accId" />; or null, if no matching instance can be found.
        /// </returns>
        public static IEnumerable<Consensus.Common.GenericModel> FetchAllByAccIdAccountXref(ConsensusSite site, System.String accId, System.String proleId)
        {
            IBusinessProvider provider = site.GetService<IBusinessProvider>();
            IEnumerable<Consensus.Common.IGenericModelModel> collection = provider.Common.GenericModel.FetchAllByAccIdAccountXref(accId,proleId);
            return collection.Select(model => new Consensus.Common.GenericModel(model));
        }

        /// <summary>
        ///     Retrieves a specific <see cref="!:GenericModelModel" /> instance.
        /// </summary>
        /// <returns>
        ///     The <see cref="!:GenericModelModel" /> instance that matches the specified <paramref name="courseid" />; or null, if no matching instance can be found.
        /// </returns>
        public static IEnumerable<Consensus.Common.GenericModel> FetchAllByCourseIdSessions(System.String courseid)
        {
            ConsensusSite site = ConsensusDomain.Configuration[ConsensusDomain.Configuration.DefaultSite];
            return GenericModel.FetchAllByCourseIdSessions(site,courseid);
        }

        /// <summary>
        ///     Retrieves a specific <see cref="!:GenericModelModel" /> instance.
        /// </summary>
        /// <returns>
        ///     The <see cref="!:GenericModelModel" /> instance that matches the specified <paramref name="courseid" />; or null, if no matching instance can be found.
        /// </returns>
        public static IEnumerable<Consensus.Common.GenericModel> FetchAllByCourseIdSessions(ConsensusSite site, System.String courseid)
        {
            IBusinessProvider provider = site.GetService<IBusinessProvider>();
            IEnumerable<Consensus.Common.IGenericModelModel> collection = provider.Common.GenericModel.FetchAllByCourseIdSessions(courseid);
            return collection.Select(model => new Consensus.Common.GenericModel(model));
        }

        /// <summary>
        ///     Retrieves a specific <see cref="!:GenericModelModel" /> instance.
        /// </summary>
        /// <returns>
        ///     The <see cref="!:GenericModelModel" /> instance that matches the specified <paramref name="courseid" />; or null, if no matching instance can be found.
        /// </returns>
        public static IEnumerable<Consensus.Common.GenericModel> FetchAllByCourseIdPrices(System.String courseid, System.Int32 delcount)
        {
            ConsensusSite site = ConsensusDomain.Configuration[ConsensusDomain.Configuration.DefaultSite];
            return GenericModel.FetchAllByCourseIdPrices(site,courseid,delcount);
        }

        /// <summary>
        ///     Retrieves a specific <see cref="!:GenericModelModel" /> instance.
        /// </summary>
        /// <returns>
        ///     The <see cref="!:GenericModelModel" /> instance that matches the specified <paramref name="courseid" />; or null, if no matching instance can be found.
        /// </returns>
        public static IEnumerable<Consensus.Common.GenericModel> FetchAllByCourseIdPrices(ConsensusSite site, System.String courseid, System.Int32 delcount)
        {
            IBusinessProvider provider = site.GetService<IBusinessProvider>();
            IEnumerable<Consensus.Common.IGenericModelModel> collection = provider.Common.GenericModel.FetchAllByCourseIdPrices(courseid,delcount);
            return collection.Select(model => new Consensus.Common.GenericModel(model));
        }

        /// <summary>
        ///     Retrieves a specific <see cref="!:GenericModelModel" /> instance.
        /// </summary>
        /// <returns>
        ///     The <see cref="!:GenericModelModel" /> instance that matches the specified <paramref name="courseid" />; or null, if no matching instance can be found.
        /// </returns>
        public static IEnumerable<Consensus.Common.GenericModel> FetchAllByProdIdPrices(System.String prodid, System.Int32 qty)
        {
            ConsensusSite site = ConsensusDomain.Configuration[ConsensusDomain.Configuration.DefaultSite];
            return GenericModel.FetchAllByProdIdPrices(site,prodid,qty);
        }

        /// <summary>
        ///     Retrieves a specific <see cref="!:GenericModelModel" /> instance.
        /// </summary>
        /// <returns>
        ///     The <see cref="!:GenericModelModel" /> instance that matches the specified <paramref name="courseid" />; or null, if no matching instance can be found.
        /// </returns>
        public static IEnumerable<Consensus.Common.GenericModel> FetchAllByProdIdPrices(ConsensusSite site, System.String prodid, System.Int32 qty)
        {
            IBusinessProvider provider = site.GetService<IBusinessProvider>();
            IEnumerable<Consensus.Common.IGenericModelModel> collection = provider.Common.GenericModel.FetchAllByProdIdPrices(prodid,qty);
            return collection.Select(model => new Consensus.Common.GenericModel(model));
        }

        /// <summary>
        ///     Retrieves a specific <see cref="!:GenericModelModel" /> instance.
        /// </summary>
        /// <returns>
        ///     The <see cref="!:GenericModelModel" /> instance that matches the specified <paramref name="courseid" />; or null, if no matching instance can be found.
        /// </returns>
        public static IEnumerable<Consensus.Common.GenericModel> ValidateDelegate(System.String courseid, System.String proleid, System.String qualid, System.Int16 ignorefreeplaces, System.Int16 delquantity)
        {
            ConsensusSite site = ConsensusDomain.Configuration[ConsensusDomain.Configuration.DefaultSite];
            return GenericModel.ValidateDelegate(site,courseid,proleid,qualid,ignorefreeplaces,delquantity);
        }

        /// <summary>
        ///     Retrieves a specific <see cref="!:GenericModelModel" /> instance.
        /// </summary>
        /// <returns>
        ///     The <see cref="!:GenericModelModel" /> instance that matches the specified <paramref name="courseid" />; or null, if no matching instance can be found.
        /// </returns>
        public static IEnumerable<Consensus.Common.GenericModel> ValidateDelegate(ConsensusSite site, System.String courseid, System.String proleid, System.String qualid, System.Int16 ignorefreeplaces, System.Int16 delquantity)
        {
            IBusinessProvider provider = site.GetService<IBusinessProvider>();
            IEnumerable<Consensus.Common.IGenericModelModel> collection = provider.Common.GenericModel.ValidateDelegate(courseid,proleid,qualid,ignorefreeplaces,delquantity);
            return collection.Select(model => new Consensus.Common.GenericModel(model));
        }

        /// <summary>
        ///     Creates a new <see cref="!:GenericModelModel" /> instance.
        /// </summary>
        /// <returns>
        ///     A newly instantiated <see cref="!:GenericModelModel" /> instance.
        /// </returns>
        public static Consensus.Common.GenericModel Create()
        {
            ConsensusSite site = ConsensusDomain.Configuration[ConsensusDomain.Configuration.DefaultSite];
            return GenericModel.Create(site);
        }

        /// <summary>
        ///     Creates a new <see cref="!:GenericModelModel" /> instance.
        /// </summary>
        /// <returns>
        ///     A newly instantiated <see cref="!:GenericModelModel" /> instance.
        /// </returns>
        public static Consensus.Common.GenericModel Create(ConsensusSite site)
        {
            IBusinessProvider provider = site.GetService<IBusinessProvider>();
            Consensus.Common.IGenericModelModel model = provider.Common.GenericModel.Create();
            return model == null ? null : new Consensus.Common.GenericModel(model);
        }

        /// <summary>
        ///     Retrieves all instances of the <see cref="!:GenericModelModel" /> class.
        /// </summary>
        /// <returns>
        ///     An enumerable collection of <see cref="!:GenericModelModel" /> instances.
        /// </returns>
        public static IEnumerable<Consensus.Common.GenericModel> FetchAll()
        {
            ConsensusSite site = ConsensusDomain.Configuration[ConsensusDomain.Configuration.DefaultSite];
            return GenericModel.FetchAll(site);
        }

        /// <summary>
        ///     Retrieves all instances of the <see cref="!:GenericModelModel" /> class.
        /// </summary>
        /// <returns>
        ///     An enumerable collection of <see cref="!:GenericModelModel" /> instances.
        /// </returns>
        public static IEnumerable<Consensus.Common.GenericModel> FetchAll(ConsensusSite site)
        {
            IBusinessProvider provider = site.GetService<IBusinessProvider>();
            IEnumerable<Consensus.Common.IGenericModelModel> collection = provider.Common.GenericModel.FetchAll();
            return collection.Select(model => new Consensus.Common.GenericModel(model));
        }

        /// <summary>
        ///     Retrieves a specific <see cref="!:GenericModelModel" /> instance.
        /// </summary>
        /// <param name="id">
        ///     The unique value which distinctly identifies the <see cref="!:GenericModelModel" /> instance to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:GenericModelModel" /> instance that matches the specified <paramref name="id" />; or null, if no matching instance can be found.
        /// </returns>
        public static Consensus.Common.GenericModel FetchById(System.String id)
        {
            ConsensusSite site = ConsensusDomain.Configuration[ConsensusDomain.Configuration.DefaultSite];
            return GenericModel.FetchById(site,id);
        }

        /// <summary>
        ///     Retrieves a specific <see cref="!:GenericModelModel" /> instance.
        /// </summary>
        /// <param name="id">
        ///     The unique value which distinctly identifies the <see cref="!:GenericModelModel" /> instance to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:GenericModelModel" /> instance that matches the specified <paramref name="id" />; or null, if no matching instance can be found.
        /// </returns>
        public static Consensus.Common.GenericModel FetchById(ConsensusSite site, System.String id)
        {
            IBusinessProvider provider = site.GetService<IBusinessProvider>();
            Consensus.Common.IGenericModelModel model = provider.Common.GenericModel.FetchById(id);
            return model == null ? null : new Consensus.Common.GenericModel(model);
        }

        public static System.String GetTableName()
        {
            ConsensusSite site = ConsensusDomain.Configuration[ConsensusDomain.Configuration.DefaultSite];
            return GenericModel.GetTableName(site);
        }

        public static System.String GetTableName(ConsensusSite site)
        {
            IBusinessProvider provider = site.GetService<IBusinessProvider>();
            return provider.Common.GenericModel.GetTableName();
        }

        #endregion
    }
}
