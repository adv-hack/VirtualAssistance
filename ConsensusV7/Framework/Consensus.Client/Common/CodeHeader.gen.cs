using System;
using System.Collections.Generic;
using System.Linq;

namespace Consensus.Common
{
    /// <remarks>
    ///     THIS CODE HAS BEEN AUTOMATICALLY GENERATED USING THE CONSENSUS DEVELOPER TOOLS.
    ///     DO NOT EDIT THIS CODE AS ANY CUSTOM MODIFICATIONS WILL BE LOST UPON REGENERATION.
    /// </remarks>
    public partial class CodeHeader : Proxy<ICodeHeaderModel, String>
    {
        #region properties

        /// <summary>
        ///     Gets or sets the value of the "CDHDR_NAME" field.
        /// </summary>
        public System.String Name
        {
            get { return this.Model.Name; }
            set { this.Model.Name = value; }
        }

        #endregion

        #region constructors

        /// <summary>
        ///     Initialises a new instance of the client-consumable class.
        /// </summary>
        internal CodeHeader(ICodeHeaderModel model) : base(model)
        {
        }

        #endregion

        #region methods

        /// <summary>
        ///     Creates a new <see cref="!:CodeHeaderModel" /> instance.
        /// </summary>
        /// <returns>
        ///     A newly instantiated <see cref="!:CodeHeaderModel" /> instance.
        /// </returns>
        public static Consensus.Common.CodeHeader Create()
        {
            ConsensusSite site = ConsensusDomain.Configuration[ConsensusDomain.Configuration.DefaultSite];
            return CodeHeader.Create(site);
        }

        /// <summary>
        ///     Creates a new <see cref="!:CodeHeaderModel" /> instance.
        /// </summary>
        /// <returns>
        ///     A newly instantiated <see cref="!:CodeHeaderModel" /> instance.
        /// </returns>
        public static Consensus.Common.CodeHeader Create(ConsensusSite site)
        {
            IBusinessProvider provider = site.GetService<IBusinessProvider>();
            Consensus.Common.ICodeHeaderModel model = provider.Common.CodeHeader.Create();
            return model == null ? null : new Consensus.Common.CodeHeader(model);
        }

        /// <summary>
        ///     Retrieves all instances of the <see cref="!:CodeHeaderModel" /> class.
        /// </summary>
        /// <returns>
        ///     An enumerable collection of <see cref="!:CodeHeaderModel" /> instances.
        /// </returns>
        public static IEnumerable<Consensus.Common.CodeHeader> FetchAll()
        {
            ConsensusSite site = ConsensusDomain.Configuration[ConsensusDomain.Configuration.DefaultSite];
            return CodeHeader.FetchAll(site);
        }

        /// <summary>
        ///     Retrieves all instances of the <see cref="!:CodeHeaderModel" /> class.
        /// </summary>
        /// <returns>
        ///     An enumerable collection of <see cref="!:CodeHeaderModel" /> instances.
        /// </returns>
        public static IEnumerable<Consensus.Common.CodeHeader> FetchAll(ConsensusSite site)
        {
            IBusinessProvider provider = site.GetService<IBusinessProvider>();
            IEnumerable<Consensus.Common.ICodeHeaderModel> collection = provider.Common.CodeHeader.FetchAll();
            return collection.Select(model => new Consensus.Common.CodeHeader(model));
        }

        /// <summary>
        ///     Retrieves a specific <see cref="!:CodeHeaderModel" /> instance.
        /// </summary>
        /// <param name="id">
        ///     The unique value which distinctly identifies the <see cref="!:CodeHeaderModel" /> instance to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:CodeHeaderModel" /> instance that matches the specified <paramref name="id" />; or null, if no matching instance can be found.
        /// </returns>
        public static Consensus.Common.CodeHeader FetchById(System.String id)
        {
            ConsensusSite site = ConsensusDomain.Configuration[ConsensusDomain.Configuration.DefaultSite];
            return CodeHeader.FetchById(site,id);
        }

        /// <summary>
        ///     Retrieves a specific <see cref="!:CodeHeaderModel" /> instance.
        /// </summary>
        /// <param name="id">
        ///     The unique value which distinctly identifies the <see cref="!:CodeHeaderModel" /> instance to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:CodeHeaderModel" /> instance that matches the specified <paramref name="id" />; or null, if no matching instance can be found.
        /// </returns>
        public static Consensus.Common.CodeHeader FetchById(ConsensusSite site, System.String id)
        {
            IBusinessProvider provider = site.GetService<IBusinessProvider>();
            Consensus.Common.ICodeHeaderModel model = provider.Common.CodeHeader.FetchById(id);
            return model == null ? null : new Consensus.Common.CodeHeader(model);
        }

        public static System.String GetTableName()
        {
            ConsensusSite site = ConsensusDomain.Configuration[ConsensusDomain.Configuration.DefaultSite];
            return CodeHeader.GetTableName(site);
        }

        public static System.String GetTableName(ConsensusSite site)
        {
            IBusinessProvider provider = site.GetService<IBusinessProvider>();
            return provider.Common.CodeHeader.GetTableName();
        }

        #endregion
    }
}
