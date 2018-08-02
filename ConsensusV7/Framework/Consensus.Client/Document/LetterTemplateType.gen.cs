using System;
using System.Collections.Generic;
using System.Linq;

namespace Consensus.Document
{
    /// <remarks>
    ///     THIS CODE HAS BEEN AUTOMATICALLY GENERATED USING THE CONSENSUS DEVELOPER TOOLS.
    ///     DO NOT EDIT THIS CODE AS ANY CUSTOM MODIFICATIONS WILL BE LOST UPON REGENERATION.
    /// </remarks>
    public partial class LetterTemplateType : Proxy<ILetterTemplateTypeModel, String>
    {
        #region fields

        /// <summary>
        ///     The client-consumable proxy collection for the <see cref="LetterTemplates" /> member.
        /// </summary>
        private ProxyCollection<Consensus.Document.LetterTemplate, Consensus.Document.ILetterTemplateModel> _letterTemplates;

        #endregion

        #region properties

        /// <summary>
        ///     Gets or sets the value of the "LTT_NAME" field.
        /// </summary>
        public System.String Name
        {
            get { return this.Model.Name; }
            set { this.Model.Name = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "LTT_DESC" field.
        /// </summary>
        public System.String Desc
        {
            get { return this.Model.Desc; }
            set { this.Model.Desc = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "LTT_TYPE" field.
        /// </summary>
        public System.Nullable<System.Byte> Type
        {
            get { return this.Model.Type; }
            set { this.Model.Type = value; }
        }

        /// <summary>
        ///     Gets the collection of <see cref="!:LetterTemplateModel" /> instances that reference this <see cref="!:LetterTemplateTypeModel" />.
        /// </summary>
        public Collection<Consensus.Document.LetterTemplate> LetterTemplates
        {
            get
            {
                if (_letterTemplates == null)
                    _letterTemplates = new ProxyCollection<Consensus.Document.LetterTemplate, Consensus.Document.ILetterTemplateModel>(this.Model.LetterTemplates, model => new Consensus.Document.LetterTemplate(model));
                return _letterTemplates;
            }
        }

        #endregion

        #region constructors

        /// <summary>
        ///     Initialises a new instance of the client-consumable class.
        /// </summary>
        internal LetterTemplateType(ILetterTemplateTypeModel model) : base(model)
        {
        }

        #endregion

        #region methods

        /// <summary>
        ///     Creates a new <see cref="!:LetterTemplateTypeModel" /> instance.
        /// </summary>
        /// <returns>
        ///     A newly instantiated <see cref="!:LetterTemplateTypeModel" /> instance.
        /// </returns>
        public static Consensus.Document.LetterTemplateType Create()
        {
            ConsensusSite site = ConsensusDomain.Configuration[ConsensusDomain.Configuration.DefaultSite];
            return LetterTemplateType.Create(site);
        }

        /// <summary>
        ///     Creates a new <see cref="!:LetterTemplateTypeModel" /> instance.
        /// </summary>
        /// <returns>
        ///     A newly instantiated <see cref="!:LetterTemplateTypeModel" /> instance.
        /// </returns>
        public static Consensus.Document.LetterTemplateType Create(ConsensusSite site)
        {
            IBusinessProvider provider = site.GetService<IBusinessProvider>();
            Consensus.Document.ILetterTemplateTypeModel model = provider.Document.LetterTemplateType.Create();
            return model == null ? null : new Consensus.Document.LetterTemplateType(model);
        }

        /// <summary>
        ///     Retrieves all instances of the <see cref="!:LetterTemplateTypeModel" /> class.
        /// </summary>
        /// <returns>
        ///     An enumerable collection of <see cref="!:LetterTemplateTypeModel" /> instances.
        /// </returns>
        public static IEnumerable<Consensus.Document.LetterTemplateType> FetchAll()
        {
            ConsensusSite site = ConsensusDomain.Configuration[ConsensusDomain.Configuration.DefaultSite];
            return LetterTemplateType.FetchAll(site);
        }

        /// <summary>
        ///     Retrieves all instances of the <see cref="!:LetterTemplateTypeModel" /> class.
        /// </summary>
        /// <returns>
        ///     An enumerable collection of <see cref="!:LetterTemplateTypeModel" /> instances.
        /// </returns>
        public static IEnumerable<Consensus.Document.LetterTemplateType> FetchAll(ConsensusSite site)
        {
            IBusinessProvider provider = site.GetService<IBusinessProvider>();
            IEnumerable<Consensus.Document.ILetterTemplateTypeModel> collection = provider.Document.LetterTemplateType.FetchAll();
            return collection.Select(model => new Consensus.Document.LetterTemplateType(model));
        }

        /// <summary>
        ///     Retrieves a specific <see cref="!:LetterTemplateTypeModel" /> instance.
        /// </summary>
        /// <param name="id">
        ///     The unique value which distinctly identifies the <see cref="!:LetterTemplateTypeModel" /> instance to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:LetterTemplateTypeModel" /> instance that matches the specified <paramref name="id" />; or null, if no matching instance can be found.
        /// </returns>
        public static Consensus.Document.LetterTemplateType FetchById(System.String id)
        {
            ConsensusSite site = ConsensusDomain.Configuration[ConsensusDomain.Configuration.DefaultSite];
            return LetterTemplateType.FetchById(site,id);
        }

        /// <summary>
        ///     Retrieves a specific <see cref="!:LetterTemplateTypeModel" /> instance.
        /// </summary>
        /// <param name="id">
        ///     The unique value which distinctly identifies the <see cref="!:LetterTemplateTypeModel" /> instance to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:LetterTemplateTypeModel" /> instance that matches the specified <paramref name="id" />; or null, if no matching instance can be found.
        /// </returns>
        public static Consensus.Document.LetterTemplateType FetchById(ConsensusSite site, System.String id)
        {
            IBusinessProvider provider = site.GetService<IBusinessProvider>();
            Consensus.Document.ILetterTemplateTypeModel model = provider.Document.LetterTemplateType.FetchById(id);
            return model == null ? null : new Consensus.Document.LetterTemplateType(model);
        }

        public static System.String GetTableName()
        {
            ConsensusSite site = ConsensusDomain.Configuration[ConsensusDomain.Configuration.DefaultSite];
            return LetterTemplateType.GetTableName(site);
        }

        public static System.String GetTableName(ConsensusSite site)
        {
            IBusinessProvider provider = site.GetService<IBusinessProvider>();
            return provider.Document.LetterTemplateType.GetTableName();
        }

        #endregion
    }
}
