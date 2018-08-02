using System;
using System.Collections.Generic;
using System.Linq;

namespace Consensus.UserInterface
{
    /// <remarks>
    ///     THIS CODE HAS BEEN AUTOMATICALLY GENERATED USING THE CONSENSUS DEVELOPER TOOLS.
    ///     DO NOT EDIT THIS CODE AS ANY CUSTOM MODIFICATIONS WILL BE LOST UPON REGENERATION.
    /// </remarks>
    public partial class ScreenCustomFieldType : Proxy<IScreenCustomFieldTypeModel, String>
    {
        #region fields

        /// <summary>
        ///     The client-consumable proxy collection for the <see cref="CustomFieldTypes" /> member.
        /// </summary>
        private ProxyCollection<Consensus.UserInterface.ScreenCustomField, Consensus.UserInterface.IScreenCustomFieldModel> _customFieldTypes;

        #endregion

        #region properties

        /// <summary>
        ///     Gets or sets the value of the "CFTYPE_NAME" field.
        /// </summary>
        public System.String Name
        {
            get { return this.Model.Name; }
            set { this.Model.Name = value; }
        }

        /// <summary>
        ///     Gets the collection of <see cref="!:ScreenCustomFieldModel" /> instances that reference this <see cref="!:ScreenCustomFieldTypeModel" />.
        /// </summary>
        public Collection<Consensus.UserInterface.ScreenCustomField> CustomFieldTypes
        {
            get
            {
                if (_customFieldTypes == null)
                    _customFieldTypes = new ProxyCollection<Consensus.UserInterface.ScreenCustomField, Consensus.UserInterface.IScreenCustomFieldModel>(this.Model.CustomFieldTypes, model => new Consensus.UserInterface.ScreenCustomField(model));
                return _customFieldTypes;
            }
        }

        #endregion

        #region constructors

        /// <summary>
        ///     Initialises a new instance of the client-consumable class.
        /// </summary>
        internal ScreenCustomFieldType(IScreenCustomFieldTypeModel model) : base(model)
        {
        }

        #endregion

        #region methods

        /// <summary>
        ///     Creates a new <see cref="!:ScreenCustomFieldTypeModel" /> instance.
        /// </summary>
        /// <returns>
        ///     A newly instantiated <see cref="!:ScreenCustomFieldTypeModel" /> instance.
        /// </returns>
        public static Consensus.UserInterface.ScreenCustomFieldType Create()
        {
            ConsensusSite site = ConsensusDomain.Configuration[ConsensusDomain.Configuration.DefaultSite];
            return ScreenCustomFieldType.Create(site);
        }

        /// <summary>
        ///     Creates a new <see cref="!:ScreenCustomFieldTypeModel" /> instance.
        /// </summary>
        /// <returns>
        ///     A newly instantiated <see cref="!:ScreenCustomFieldTypeModel" /> instance.
        /// </returns>
        public static Consensus.UserInterface.ScreenCustomFieldType Create(ConsensusSite site)
        {
            IBusinessProvider provider = site.GetService<IBusinessProvider>();
            Consensus.UserInterface.IScreenCustomFieldTypeModel model = provider.UserInterface.ScreenCustomFieldType.Create();
            return model == null ? null : new Consensus.UserInterface.ScreenCustomFieldType(model);
        }

        /// <summary>
        ///     Retrieves all instances of the <see cref="!:ScreenCustomFieldTypeModel" /> class.
        /// </summary>
        /// <returns>
        ///     An enumerable collection of <see cref="!:ScreenCustomFieldTypeModel" /> instances.
        /// </returns>
        public static IEnumerable<Consensus.UserInterface.ScreenCustomFieldType> FetchAll()
        {
            ConsensusSite site = ConsensusDomain.Configuration[ConsensusDomain.Configuration.DefaultSite];
            return ScreenCustomFieldType.FetchAll(site);
        }

        /// <summary>
        ///     Retrieves all instances of the <see cref="!:ScreenCustomFieldTypeModel" /> class.
        /// </summary>
        /// <returns>
        ///     An enumerable collection of <see cref="!:ScreenCustomFieldTypeModel" /> instances.
        /// </returns>
        public static IEnumerable<Consensus.UserInterface.ScreenCustomFieldType> FetchAll(ConsensusSite site)
        {
            IBusinessProvider provider = site.GetService<IBusinessProvider>();
            IEnumerable<Consensus.UserInterface.IScreenCustomFieldTypeModel> collection = provider.UserInterface.ScreenCustomFieldType.FetchAll();
            return collection.Select(model => new Consensus.UserInterface.ScreenCustomFieldType(model));
        }

        /// <summary>
        ///     Retrieves a specific <see cref="!:ScreenCustomFieldTypeModel" /> instance.
        /// </summary>
        /// <param name="id">
        ///     The unique value which distinctly identifies the <see cref="!:ScreenCustomFieldTypeModel" /> instance to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:ScreenCustomFieldTypeModel" /> instance that matches the specified <paramref name="id" />; or null, if no matching instance can be found.
        /// </returns>
        public static Consensus.UserInterface.ScreenCustomFieldType FetchById(System.String id)
        {
            ConsensusSite site = ConsensusDomain.Configuration[ConsensusDomain.Configuration.DefaultSite];
            return ScreenCustomFieldType.FetchById(site,id);
        }

        /// <summary>
        ///     Retrieves a specific <see cref="!:ScreenCustomFieldTypeModel" /> instance.
        /// </summary>
        /// <param name="id">
        ///     The unique value which distinctly identifies the <see cref="!:ScreenCustomFieldTypeModel" /> instance to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:ScreenCustomFieldTypeModel" /> instance that matches the specified <paramref name="id" />; or null, if no matching instance can be found.
        /// </returns>
        public static Consensus.UserInterface.ScreenCustomFieldType FetchById(ConsensusSite site, System.String id)
        {
            IBusinessProvider provider = site.GetService<IBusinessProvider>();
            Consensus.UserInterface.IScreenCustomFieldTypeModel model = provider.UserInterface.ScreenCustomFieldType.FetchById(id);
            return model == null ? null : new Consensus.UserInterface.ScreenCustomFieldType(model);
        }

        public static System.String GetTableName()
        {
            ConsensusSite site = ConsensusDomain.Configuration[ConsensusDomain.Configuration.DefaultSite];
            return ScreenCustomFieldType.GetTableName(site);
        }

        public static System.String GetTableName(ConsensusSite site)
        {
            IBusinessProvider provider = site.GetService<IBusinessProvider>();
            return provider.UserInterface.ScreenCustomFieldType.GetTableName();
        }

        #endregion
    }
}
