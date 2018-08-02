using System;
using System.Collections.Generic;
using System.Linq;

namespace Consensus.UserInterface
{
    /// <remarks>
    ///     THIS CODE HAS BEEN AUTOMATICALLY GENERATED USING THE CONSENSUS DEVELOPER TOOLS.
    ///     DO NOT EDIT THIS CODE AS ANY CUSTOM MODIFICATIONS WILL BE LOST UPON REGENERATION.
    /// </remarks>
    public partial class ScreenCustomField : Proxy<IScreenCustomFieldModel, Int32>
    {
        #region fields

        /// <summary>
        ///     The client-consumable proxy instance for the <see cref="Cftype" /> member.
        /// </summary>
        private Consensus.UserInterface.ScreenCustomFieldType _cftype;

        /// <summary>
        ///     The client-consumable proxy collection for the <see cref="CustomFieldListItems" /> member.
        /// </summary>
        private ProxyCollection<Consensus.UserInterface.ScreenCustomFieldListitem, Consensus.UserInterface.IScreenCustomFieldListitemModel> _customFieldListItems;

        /// <summary>
        ///     The client-consumable proxy collection for the <see cref="CustomFieldValues" /> member.
        /// </summary>
        private ProxyCollection<Consensus.UserInterface.ScreenCustomFieldValue, Consensus.UserInterface.IScreenCustomFieldValueModel> _customFieldValues;

        #endregion

        #region properties

        /// <summary>
        ///     Gets or sets the value of the "CFIELD_URL" field.
        /// </summary>
        public System.String Url
        {
            get { return this.Model.Url; }
            set { this.Model.Url = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "CFIELD_PARENT_CONTROL" field.
        /// </summary>
        public System.String ParentControl
        {
            get { return this.Model.ParentControl; }
            set { this.Model.ParentControl = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "CFIELD_NAME" field.
        /// </summary>
        public System.String Name
        {
            get { return this.Model.Name; }
            set { this.Model.Name = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "CFIELD_LABEL" field.
        /// </summary>
        public System.String Label
        {
            get { return this.Model.Label; }
            set { this.Model.Label = value; }
        }

        /// <summary>
        ///     Gets the The value of the "CFIELD_CFTYPE_ID" field.
        /// </summary>
        public Consensus.UserInterface.ScreenCustomFieldType Cftype
        {
            get
            {
                if (_cftype == null && this.Model.Cftype != null)
                    _cftype = new Consensus.UserInterface.ScreenCustomFieldType(this.Model.Cftype);
                if (_cftype == null)
                    _cftype = Consensus.UserInterface.ScreenCustomFieldType.Create();
                return _cftype;
            }
        }

        /// <summary>
        ///     Gets or sets the unique code for the value of the "CFIELD_CFTYPE_ID" field.
        /// </summary>
        public System.String CftypeId
        {
            get { return this.Model.CftypeId; }
            set { this.Model.CftypeId = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "CFIELD_POPUP_URL" field.
        /// </summary>
        public System.String PopupUrl
        {
            get { return this.Model.PopupUrl; }
            set { this.Model.PopupUrl = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "CFIELD_DECIMALS" field.
        /// </summary>
        public System.Nullable<System.Int32> Decimals
        {
            get { return this.Model.Decimals; }
            set { this.Model.Decimals = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "CFIELD_PAGE" field.
        /// </summary>
        public System.String Page
        {
            get { return this.Model.Page; }
            set { this.Model.Page = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "CFIELD_TABLE" field.
        /// </summary>
        public System.String Table
        {
            get { return this.Model.Table; }
            set { this.Model.Table = value; }
        }

        /// <summary>
        ///     Gets the collection of <see cref="!:ScreenCustomFieldListitemModel" /> instances that reference this <see cref="!:ScreenCustomFieldModel" />.
        /// </summary>
        public Collection<Consensus.UserInterface.ScreenCustomFieldListitem> CustomFieldListItems
        {
            get
            {
                if (_customFieldListItems == null)
                    _customFieldListItems = new ProxyCollection<Consensus.UserInterface.ScreenCustomFieldListitem, Consensus.UserInterface.IScreenCustomFieldListitemModel>(this.Model.CustomFieldListItems, model => new Consensus.UserInterface.ScreenCustomFieldListitem(model));
                return _customFieldListItems;
            }
        }

        /// <summary>
        ///     Gets the collection of <see cref="!:ScreenCustomFieldValueModel" /> instances that reference this <see cref="!:ScreenCustomFieldModel" />.
        /// </summary>
        public Collection<Consensus.UserInterface.ScreenCustomFieldValue> CustomFieldValues
        {
            get
            {
                if (_customFieldValues == null)
                    _customFieldValues = new ProxyCollection<Consensus.UserInterface.ScreenCustomFieldValue, Consensus.UserInterface.IScreenCustomFieldValueModel>(this.Model.CustomFieldValues, model => new Consensus.UserInterface.ScreenCustomFieldValue(model));
                return _customFieldValues;
            }
        }

        #endregion

        #region constructors

        /// <summary>
        ///     Initialises a new instance of the client-consumable class.
        /// </summary>
        internal ScreenCustomField(IScreenCustomFieldModel model) : base(model)
        {
        }

        #endregion

        #region methods

        /// <summary>
        ///     Fetch the custom fields for a page.
        /// </summary>
        public static IEnumerable<Consensus.UserInterface.ScreenCustomField> FetchAllByPage(System.String page)
        {
            ConsensusSite site = ConsensusDomain.Configuration[ConsensusDomain.Configuration.DefaultSite];
            return ScreenCustomField.FetchAllByPage(site,page);
        }

        /// <summary>
        ///     Fetch the custom fields for a page.
        /// </summary>
        public static IEnumerable<Consensus.UserInterface.ScreenCustomField> FetchAllByPage(ConsensusSite site, System.String page)
        {
            IBusinessProvider provider = site.GetService<IBusinessProvider>();
            IEnumerable<Consensus.UserInterface.IScreenCustomFieldModel> collection = provider.UserInterface.ScreenCustomField.FetchAllByPage(page);
            return collection.Select(model => new Consensus.UserInterface.ScreenCustomField(model));
        }

        /// <summary>
        ///     Updates the page configuration.
        /// </summary>
        public static void Update(System.Collections.ArrayList customFields)
        {
            ConsensusSite site = ConsensusDomain.Configuration[ConsensusDomain.Configuration.DefaultSite];
            ScreenCustomField.Update(site,customFields);
        }

        /// <summary>
        ///     Updates the page configuration.
        /// </summary>
        public static void Update(ConsensusSite site, System.Collections.ArrayList customFields)
        {
            IBusinessProvider provider = site.GetService<IBusinessProvider>();
            provider.UserInterface.ScreenCustomField.Update(customFields);
        }

        /// <summary>
        ///     Creates a new <see cref="!:ScreenCustomFieldModel" /> instance.
        /// </summary>
        /// <returns>
        ///     A newly instantiated <see cref="!:ScreenCustomFieldModel" /> instance.
        /// </returns>
        public static Consensus.UserInterface.ScreenCustomField Create()
        {
            ConsensusSite site = ConsensusDomain.Configuration[ConsensusDomain.Configuration.DefaultSite];
            return ScreenCustomField.Create(site);
        }

        /// <summary>
        ///     Creates a new <see cref="!:ScreenCustomFieldModel" /> instance.
        /// </summary>
        /// <returns>
        ///     A newly instantiated <see cref="!:ScreenCustomFieldModel" /> instance.
        /// </returns>
        public static Consensus.UserInterface.ScreenCustomField Create(ConsensusSite site)
        {
            IBusinessProvider provider = site.GetService<IBusinessProvider>();
            Consensus.UserInterface.IScreenCustomFieldModel model = provider.UserInterface.ScreenCustomField.Create();
            return model == null ? null : new Consensus.UserInterface.ScreenCustomField(model);
        }

        /// <summary>
        ///     Retrieves all instances of the <see cref="!:ScreenCustomFieldModel" /> class.
        /// </summary>
        /// <returns>
        ///     An enumerable collection of <see cref="!:ScreenCustomFieldModel" /> instances.
        /// </returns>
        public static IEnumerable<Consensus.UserInterface.ScreenCustomField> FetchAll()
        {
            ConsensusSite site = ConsensusDomain.Configuration[ConsensusDomain.Configuration.DefaultSite];
            return ScreenCustomField.FetchAll(site);
        }

        /// <summary>
        ///     Retrieves all instances of the <see cref="!:ScreenCustomFieldModel" /> class.
        /// </summary>
        /// <returns>
        ///     An enumerable collection of <see cref="!:ScreenCustomFieldModel" /> instances.
        /// </returns>
        public static IEnumerable<Consensus.UserInterface.ScreenCustomField> FetchAll(ConsensusSite site)
        {
            IBusinessProvider provider = site.GetService<IBusinessProvider>();
            IEnumerable<Consensus.UserInterface.IScreenCustomFieldModel> collection = provider.UserInterface.ScreenCustomField.FetchAll();
            return collection.Select(model => new Consensus.UserInterface.ScreenCustomField(model));
        }

        /// <summary>
        ///     Retrieves a specific <see cref="!:ScreenCustomFieldModel" /> instance.
        /// </summary>
        /// <param name="id">
        ///     The unique value which distinctly identifies the <see cref="!:ScreenCustomFieldModel" /> instance to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:ScreenCustomFieldModel" /> instance that matches the specified <paramref name="id" />; or null, if no matching instance can be found.
        /// </returns>
        public static Consensus.UserInterface.ScreenCustomField FetchById(System.Int32 id)
        {
            ConsensusSite site = ConsensusDomain.Configuration[ConsensusDomain.Configuration.DefaultSite];
            return ScreenCustomField.FetchById(site,id);
        }

        /// <summary>
        ///     Retrieves a specific <see cref="!:ScreenCustomFieldModel" /> instance.
        /// </summary>
        /// <param name="id">
        ///     The unique value which distinctly identifies the <see cref="!:ScreenCustomFieldModel" /> instance to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:ScreenCustomFieldModel" /> instance that matches the specified <paramref name="id" />; or null, if no matching instance can be found.
        /// </returns>
        public static Consensus.UserInterface.ScreenCustomField FetchById(ConsensusSite site, System.Int32 id)
        {
            IBusinessProvider provider = site.GetService<IBusinessProvider>();
            Consensus.UserInterface.IScreenCustomFieldModel model = provider.UserInterface.ScreenCustomField.FetchById(id);
            return model == null ? null : new Consensus.UserInterface.ScreenCustomField(model);
        }

        public static System.String GetTableName()
        {
            ConsensusSite site = ConsensusDomain.Configuration[ConsensusDomain.Configuration.DefaultSite];
            return ScreenCustomField.GetTableName(site);
        }

        public static System.String GetTableName(ConsensusSite site)
        {
            IBusinessProvider provider = site.GetService<IBusinessProvider>();
            return provider.UserInterface.ScreenCustomField.GetTableName();
        }

        /// <summary>
        ///     Retrieves a collection of <see cref="!:ScreenCustomFieldModel" /> instances.
        /// </summary>
        /// <param name="cftypeId">
        ///     The value which identifies the <see cref="!:ScreenCustomFieldModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:ScreenCustomFieldModel" /> instances that match the specified <paramref name="cftypeId" />.
        /// </returns>
        public static IEnumerable<Consensus.UserInterface.ScreenCustomField> FetchAllByCftypeId(System.String cftypeId)
        {
            ConsensusSite site = ConsensusDomain.Configuration[ConsensusDomain.Configuration.DefaultSite];
            return ScreenCustomField.FetchAllByCftypeId(site,cftypeId);
        }

        /// <summary>
        ///     Retrieves a collection of <see cref="!:ScreenCustomFieldModel" /> instances.
        /// </summary>
        /// <param name="cftypeId">
        ///     The value which identifies the <see cref="!:ScreenCustomFieldModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:ScreenCustomFieldModel" /> instances that match the specified <paramref name="cftypeId" />.
        /// </returns>
        public static IEnumerable<Consensus.UserInterface.ScreenCustomField> FetchAllByCftypeId(ConsensusSite site, System.String cftypeId)
        {
            IBusinessProvider provider = site.GetService<IBusinessProvider>();
            IEnumerable<Consensus.UserInterface.IScreenCustomFieldModel> collection = provider.UserInterface.ScreenCustomField.FetchAllByCftypeId(cftypeId);
            return collection.Select(model => new Consensus.UserInterface.ScreenCustomField(model));
        }

        #endregion
    }
}
