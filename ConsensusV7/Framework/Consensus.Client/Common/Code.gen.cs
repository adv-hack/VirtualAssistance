using System;
using System.Collections.Generic;
using System.Linq;
using Consensus.Activities;
using Consensus.Contact;
using Consensus.Document;
using Consensus.Finance;
using Consensus.Learning;
using Consensus.Marketing;
using Consensus.Membership;
using Consensus.Reporting;
using Consensus.Sales;

namespace Consensus.Common
{
    /// <remarks>
    ///     THIS CODE HAS BEEN AUTOMATICALLY GENERATED USING THE CONSENSUS DEVELOPER TOOLS.
    ///     DO NOT EDIT THIS CODE AS ANY CUSTOM MODIFICATIONS WILL BE LOST UPON REGENERATION.
    /// </remarks>
    public partial class Code : Proxy<ICodeModel, String>
    {
        #region properties

        /// <summary>
        ///     Gets or sets the value of the "CODE_TYPE" field.
        /// </summary>
        public System.String Type
        {
            get { return this.Model.Type; }
            set { this.Model.Type = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "CODE_VALUE1" field.
        /// </summary>
        public System.String Value1
        {
            get { return this.Model.Value1; }
            set { this.Model.Value1 = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "CODE_VALUE2" field.
        /// </summary>
        public System.String Value2
        {
            get { return this.Model.Value2; }
            set { this.Model.Value2 = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "CODE_VALUE3" field.
        /// </summary>
        public System.String Value3
        {
            get { return this.Model.Value3; }
            set { this.Model.Value3 = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "CODE_DESCRIPTION" field.
        /// </summary>
        public System.String Description
        {
            get { return this.Model.Description; }
            set { this.Model.Description = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "CODE_VALUE4" field.
        /// </summary>
        public System.String Value4
        {
            get { return this.Model.Value4; }
            set { this.Model.Value4 = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "CODE_SYSTEM" field.
        /// </summary>
        public System.Nullable<System.Byte> System
        {
            get { return this.Model.System; }
            set { this.Model.System = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "CODE_DELETED" field.
        /// </summary>
        public System.Nullable<System.Byte> Deleted
        {
            get { return this.Model.Deleted; }
            set { this.Model.Deleted = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "CODE_READ_ONLY" field.
        /// </summary>
        public System.Nullable<System.Byte> ReadOnly
        {
            get { return this.Model.ReadOnly; }
            set { this.Model.ReadOnly = value; }
        }

        #endregion

        #region constructors

        /// <summary>
        ///     Initialises a new instance of the client-consumable class.
        /// </summary>
        internal Code(ICodeModel model) : base(model)
        {
        }

        #endregion

        #region methods

        /// <summary>
        ///     Creates a new <see cref="!:CodeModel" /> instance.
        /// </summary>
        /// <param name="codeType">
        ///     The type of the code.
        /// </param>
        /// <returns>
        ///     A newly instantiated <see cref="!:CodeModel" /> instance.
        /// </returns>
        public static Consensus.Common.Code Create(System.String codeType)
        {
            ConsensusSite site = ConsensusDomain.Configuration[ConsensusDomain.Configuration.DefaultSite];
            return Code.Create(site,codeType);
        }

        /// <summary>
        ///     Creates a new <see cref="!:CodeModel" /> instance.
        /// </summary>
        /// <param name="codeType">
        ///     The type of the code.
        /// </param>
        /// <returns>
        ///     A newly instantiated <see cref="!:CodeModel" /> instance.
        /// </returns>
        public static Consensus.Common.Code Create(ConsensusSite site, System.String codeType)
        {
            IBusinessProvider provider = site.GetService<IBusinessProvider>();
            Consensus.Common.ICodeModel model = provider.Common.Code.Create(codeType);
            return model == null ? null : new Consensus.Common.Code(model);
        }

        /// <summary>
        ///     Retrieves a specific <see cref="!:CodeModel" /> instance.
        /// </summary>
        /// <returns>
        ///     The <see cref="!:CodeModel" /> instance that matches the specified <paramref name="id" />; or null, if no matching instance can be found.
        /// </returns>
        public static Consensus.Common.Code FetchByTypeAndCode(System.String codeType, System.String codeValue)
        {
            ConsensusSite site = ConsensusDomain.Configuration[ConsensusDomain.Configuration.DefaultSite];
            return Code.FetchByTypeAndCode(site,codeType,codeValue);
        }

        /// <summary>
        ///     Retrieves a specific <see cref="!:CodeModel" /> instance.
        /// </summary>
        /// <returns>
        ///     The <see cref="!:CodeModel" /> instance that matches the specified <paramref name="id" />; or null, if no matching instance can be found.
        /// </returns>
        public static Consensus.Common.Code FetchByTypeAndCode(ConsensusSite site, System.String codeType, System.String codeValue)
        {
            IBusinessProvider provider = site.GetService<IBusinessProvider>();
            Consensus.Common.ICodeModel model = provider.Common.Code.FetchByTypeAndCode(codeType,codeValue);
            return model == null ? null : new Consensus.Common.Code(model);
        }

        /// <summary>
        ///     Retrieves a single <see cref="!:CodeModel" /> instance from the data store.
        /// </summary>
        /// <param name="codeValue3">
        ///     The unique value which distinctly identifies the <see cref="!:CodeModel" /> instance to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:CodeModel" /> instance that matches the specified <paramref name="codeValue3" />; or null, if no matching instance can be found.
        /// </returns>
        public static Consensus.Common.Code FetchByTypeAndCodeValue3(System.String codeType, System.String codeValue3)
        {
            ConsensusSite site = ConsensusDomain.Configuration[ConsensusDomain.Configuration.DefaultSite];
            return Code.FetchByTypeAndCodeValue3(site,codeType,codeValue3);
        }

        /// <summary>
        ///     Retrieves a single <see cref="!:CodeModel" /> instance from the data store.
        /// </summary>
        /// <param name="codeValue3">
        ///     The unique value which distinctly identifies the <see cref="!:CodeModel" /> instance to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:CodeModel" /> instance that matches the specified <paramref name="codeValue3" />; or null, if no matching instance can be found.
        /// </returns>
        public static Consensus.Common.Code FetchByTypeAndCodeValue3(ConsensusSite site, System.String codeType, System.String codeValue3)
        {
            IBusinessProvider provider = site.GetService<IBusinessProvider>();
            Consensus.Common.ICodeModel model = provider.Common.Code.FetchByTypeAndCodeValue3(codeType,codeValue3);
            return model == null ? null : new Consensus.Common.Code(model);
        }

        /// <summary>
        ///     Retrieves a specific <see cref="!:CodeModel" /> instance.
        /// </summary>
        /// <returns>
        ///     The <see cref="!:CodeModel" /> instance that matches the specified <paramref name="id" />; or null, if no matching instance can be found.
        /// </returns>
        public static IEnumerable<Consensus.Common.Code> FetchAllByType(System.String codeType)
        {
            ConsensusSite site = ConsensusDomain.Configuration[ConsensusDomain.Configuration.DefaultSite];
            return Code.FetchAllByType(site,codeType);
        }

        /// <summary>
        ///     Retrieves a specific <see cref="!:CodeModel" /> instance.
        /// </summary>
        /// <returns>
        ///     The <see cref="!:CodeModel" /> instance that matches the specified <paramref name="id" />; or null, if no matching instance can be found.
        /// </returns>
        public static IEnumerable<Consensus.Common.Code> FetchAllByType(ConsensusSite site, System.String codeType)
        {
            IBusinessProvider provider = site.GetService<IBusinessProvider>();
            IEnumerable<Consensus.Common.ICodeModel> collection = provider.Common.Code.FetchAllByType(codeType);
            return collection.Select(model => new Consensus.Common.Code(model));
        }

        public static System.Collections.Generic.IEnumerable<System.Object> FetchAllInTree(System.String codeType)
        {
            ConsensusSite site = ConsensusDomain.Configuration[ConsensusDomain.Configuration.DefaultSite];
            return Code.FetchAllInTree(site,codeType);
        }

        public static System.Collections.Generic.IEnumerable<System.Object> FetchAllInTree(ConsensusSite site, System.String codeType)
        {
            IBusinessProvider provider = site.GetService<IBusinessProvider>();
            return provider.Common.Code.FetchAllInTree(codeType);
        }

        /// <summary>
        ///     Creates a new <see cref="!:CodeModel" /> instance.
        /// </summary>
        /// <returns>
        ///     A newly instantiated <see cref="!:CodeModel" /> instance.
        /// </returns>
        public static Consensus.Common.Code Create()
        {
            ConsensusSite site = ConsensusDomain.Configuration[ConsensusDomain.Configuration.DefaultSite];
            return Code.Create(site);
        }

        /// <summary>
        ///     Creates a new <see cref="!:CodeModel" /> instance.
        /// </summary>
        /// <returns>
        ///     A newly instantiated <see cref="!:CodeModel" /> instance.
        /// </returns>
        public static Consensus.Common.Code Create(ConsensusSite site)
        {
            IBusinessProvider provider = site.GetService<IBusinessProvider>();
            Consensus.Common.ICodeModel model = provider.Common.Code.Create();
            return model == null ? null : new Consensus.Common.Code(model);
        }

        /// <summary>
        ///     Retrieves all instances of the <see cref="!:CodeModel" /> class.
        /// </summary>
        /// <returns>
        ///     An enumerable collection of <see cref="!:CodeModel" /> instances.
        /// </returns>
        public static IEnumerable<Consensus.Common.Code> FetchAll()
        {
            ConsensusSite site = ConsensusDomain.Configuration[ConsensusDomain.Configuration.DefaultSite];
            return Code.FetchAll(site);
        }

        /// <summary>
        ///     Retrieves all instances of the <see cref="!:CodeModel" /> class.
        /// </summary>
        /// <returns>
        ///     An enumerable collection of <see cref="!:CodeModel" /> instances.
        /// </returns>
        public static IEnumerable<Consensus.Common.Code> FetchAll(ConsensusSite site)
        {
            IBusinessProvider provider = site.GetService<IBusinessProvider>();
            IEnumerable<Consensus.Common.ICodeModel> collection = provider.Common.Code.FetchAll();
            return collection.Select(model => new Consensus.Common.Code(model));
        }

        /// <summary>
        ///     Retrieves a specific <see cref="!:CodeModel" /> instance.
        /// </summary>
        /// <param name="id">
        ///     The unique value which distinctly identifies the <see cref="!:CodeModel" /> instance to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:CodeModel" /> instance that matches the specified <paramref name="id" />; or null, if no matching instance can be found.
        /// </returns>
        public static Consensus.Common.Code FetchById(System.String id)
        {
            ConsensusSite site = ConsensusDomain.Configuration[ConsensusDomain.Configuration.DefaultSite];
            return Code.FetchById(site,id);
        }

        /// <summary>
        ///     Retrieves a specific <see cref="!:CodeModel" /> instance.
        /// </summary>
        /// <param name="id">
        ///     The unique value which distinctly identifies the <see cref="!:CodeModel" /> instance to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:CodeModel" /> instance that matches the specified <paramref name="id" />; or null, if no matching instance can be found.
        /// </returns>
        public static Consensus.Common.Code FetchById(ConsensusSite site, System.String id)
        {
            IBusinessProvider provider = site.GetService<IBusinessProvider>();
            Consensus.Common.ICodeModel model = provider.Common.Code.FetchById(id);
            return model == null ? null : new Consensus.Common.Code(model);
        }

        public static System.String GetTableName()
        {
            ConsensusSite site = ConsensusDomain.Configuration[ConsensusDomain.Configuration.DefaultSite];
            return Code.GetTableName(site);
        }

        public static System.String GetTableName(ConsensusSite site)
        {
            IBusinessProvider provider = site.GetService<IBusinessProvider>();
            return provider.Common.Code.GetTableName();
        }

        #endregion
    }
}
