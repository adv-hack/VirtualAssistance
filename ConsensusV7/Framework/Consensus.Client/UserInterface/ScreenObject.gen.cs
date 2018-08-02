using System;
using System.Collections.Generic;
using System.Linq;

namespace Consensus.UserInterface
{
    /// <remarks>
    ///     THIS CODE HAS BEEN AUTOMATICALLY GENERATED USING THE CONSENSUS DEVELOPER TOOLS.
    ///     DO NOT EDIT THIS CODE AS ANY CUSTOM MODIFICATIONS WILL BE LOST UPON REGENERATION.
    /// </remarks>
    public partial class ScreenObject : Proxy<IScreenObjectModel, Int32>
    {
        #region fields

        /// <summary>
        ///     The client-consumable proxy collection for the <see cref="DisplayRules" /> member.
        /// </summary>
        private ProxyCollection<Consensus.UserInterface.ScreenObjectDisplay, Consensus.UserInterface.IScreenObjectDisplayModel> _displayRules;

        /// <summary>
        ///     The client-consumable proxy collection for the <see cref="Entries" /> member.
        /// </summary>
        private ProxyCollection<Consensus.UserInterface.ScreenObjectEntry, Consensus.UserInterface.IScreenObjectEntryModel> _entries;

        /// <summary>
        ///     The client-consumable proxy collection for the <see cref="Columns" /> member.
        /// </summary>
        private ProxyCollection<Consensus.UserInterface.ScreenObjectColumn, Consensus.UserInterface.IScreenObjectColumnModel> _columns;

        #endregion

        #region properties

        /// <summary>
        ///     Gets or sets the visibility mode of the screen object.
        /// </summary>
        public Consensus.UserInterface.ScreenObjectVisibility Visibility
        {
            get { return this.Model.Visibility; }
            set { this.Model.Visibility = value; }
        }

        /// <summary>
        ///     Gets or sets the visibility mode of the screen object.
        /// </summary>
        public Consensus.UserInterface.ScreenObjectRequirement Requirement
        {
            get { return this.Model.Requirement; }
            set { this.Model.Requirement = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "OBJ_URL" field.
        /// </summary>
        public System.String Url
        {
            get { return this.Model.Url; }
            set { this.Model.Url = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "OBJ_CONTROL" field.
        /// </summary>
        public System.String Control
        {
            get { return this.Model.Control; }
            set { this.Model.Control = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "OBJ_TITLE" field.
        /// </summary>
        public System.String Title
        {
            get { return this.Model.Title; }
            set { this.Model.Title = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "OBJ_ICON" field.
        /// </summary>
        public System.String Icon
        {
            get { return this.Model.Icon; }
            set { this.Model.Icon = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "OBJ_VALIDATOR_EXPRESSION" field.
        /// </summary>
        public System.String ValidatorExpression
        {
            get { return this.Model.ValidatorExpression; }
            set { this.Model.ValidatorExpression = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "OBJ_VALIDATOR_MESSAGE" field.
        /// </summary>
        public System.String ValidatorMessage
        {
            get { return this.Model.ValidatorMessage; }
            set { this.Model.ValidatorMessage = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "OBJ_VALIDATOR_CRITICAL" field.
        /// </summary>
        public System.Boolean ValidatorCritical
        {
            get { return this.Model.ValidatorCritical; }
            set { this.Model.ValidatorCritical = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "OBJ_MAX_LENGTH" field.
        /// </summary>
        public System.Int32 MaximumLength
        {
            get { return this.Model.MaximumLength; }
            set { this.Model.MaximumLength = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "OBJ_OFF_TEXT" field.
        /// </summary>
        public System.String OffText
        {
            get { return this.Model.OffText; }
            set { this.Model.OffText = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "OBJ_OFF_COLOUR" field.
        /// </summary>
        public System.String OffColour
        {
            get { return this.Model.OffColour; }
            set { this.Model.OffColour = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "OBJ_ON_TEXT" field.
        /// </summary>
        public System.String OnText
        {
            get { return this.Model.OnText; }
            set { this.Model.OnText = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "OBJ_ON_COLOUR" field.
        /// </summary>
        public System.String OnColour
        {
            get { return this.Model.OnColour; }
            set { this.Model.OnColour = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "OBJ_DEFAULT" field.
        /// </summary>
        public System.String Default
        {
            get { return this.Model.Default; }
            set { this.Model.Default = value; }
        }

        /// <summary>
        ///     Gets the collection of <see cref="!:ScreenObjectDisplayModel" /> instances that reference this <see cref="!:ScreenObjectModel" />.
        /// </summary>
        public Collection<Consensus.UserInterface.ScreenObjectDisplay> DisplayRules
        {
            get
            {
                if (_displayRules == null)
                    _displayRules = new ProxyCollection<Consensus.UserInterface.ScreenObjectDisplay, Consensus.UserInterface.IScreenObjectDisplayModel>(this.Model.DisplayRules, model => new Consensus.UserInterface.ScreenObjectDisplay(model));
                return _displayRules;
            }
        }

        /// <summary>
        ///     Gets the collection of <see cref="!:ScreenObjectEntryModel" /> instances that reference this <see cref="!:ScreenObjectModel" />.
        /// </summary>
        public Collection<Consensus.UserInterface.ScreenObjectEntry> Entries
        {
            get
            {
                if (_entries == null)
                    _entries = new ProxyCollection<Consensus.UserInterface.ScreenObjectEntry, Consensus.UserInterface.IScreenObjectEntryModel>(this.Model.Entries, model => new Consensus.UserInterface.ScreenObjectEntry(model));
                return _entries;
            }
        }

        /// <summary>
        ///     Gets the collection of <see cref="!:ScreenObjectColumnModel" /> instances that reference this <see cref="!:ScreenObjectModel" />.
        /// </summary>
        public Collection<Consensus.UserInterface.ScreenObjectColumn> Columns
        {
            get
            {
                if (_columns == null)
                    _columns = new ProxyCollection<Consensus.UserInterface.ScreenObjectColumn, Consensus.UserInterface.IScreenObjectColumnModel>(this.Model.Columns, model => new Consensus.UserInterface.ScreenObjectColumn(model));
                return _columns;
            }
        }

        #endregion

        #region constructors

        /// <summary>
        ///     Initialises a new instance of the client-consumable class.
        /// </summary>
        internal ScreenObject(IScreenObjectModel model) : base(model)
        {
        }

        #endregion

        #region methods

        /// <summary>
        ///     Updates the page configuration.
        /// </summary>
        public static void Update(System.String url, System.Collections.ArrayList controls)
        {
            ConsensusSite site = ConsensusDomain.Configuration[ConsensusDomain.Configuration.DefaultSite];
            ScreenObject.Update(site,url,controls);
        }

        /// <summary>
        ///     Updates the page configuration.
        /// </summary>
        public static void Update(ConsensusSite site, System.String url, System.Collections.ArrayList controls)
        {
            IBusinessProvider provider = site.GetService<IBusinessProvider>();
            provider.UserInterface.ScreenObject.Update(url,controls);
        }

        /// <summary>
        ///     Creates a new <see cref="!:ScreenObjectModel" /> instance.
        /// </summary>
        /// <returns>
        ///     A newly instantiated <see cref="!:ScreenObjectModel" /> instance.
        /// </returns>
        public static Consensus.UserInterface.ScreenObject Create()
        {
            ConsensusSite site = ConsensusDomain.Configuration[ConsensusDomain.Configuration.DefaultSite];
            return ScreenObject.Create(site);
        }

        /// <summary>
        ///     Creates a new <see cref="!:ScreenObjectModel" /> instance.
        /// </summary>
        /// <returns>
        ///     A newly instantiated <see cref="!:ScreenObjectModel" /> instance.
        /// </returns>
        public static Consensus.UserInterface.ScreenObject Create(ConsensusSite site)
        {
            IBusinessProvider provider = site.GetService<IBusinessProvider>();
            Consensus.UserInterface.IScreenObjectModel model = provider.UserInterface.ScreenObject.Create();
            return model == null ? null : new Consensus.UserInterface.ScreenObject(model);
        }

        /// <summary>
        ///     Retrieves all instances of the <see cref="!:ScreenObjectModel" /> class.
        /// </summary>
        /// <returns>
        ///     An enumerable collection of <see cref="!:ScreenObjectModel" /> instances.
        /// </returns>
        public static IEnumerable<Consensus.UserInterface.ScreenObject> FetchAll()
        {
            ConsensusSite site = ConsensusDomain.Configuration[ConsensusDomain.Configuration.DefaultSite];
            return ScreenObject.FetchAll(site);
        }

        /// <summary>
        ///     Retrieves all instances of the <see cref="!:ScreenObjectModel" /> class.
        /// </summary>
        /// <returns>
        ///     An enumerable collection of <see cref="!:ScreenObjectModel" /> instances.
        /// </returns>
        public static IEnumerable<Consensus.UserInterface.ScreenObject> FetchAll(ConsensusSite site)
        {
            IBusinessProvider provider = site.GetService<IBusinessProvider>();
            IEnumerable<Consensus.UserInterface.IScreenObjectModel> collection = provider.UserInterface.ScreenObject.FetchAll();
            return collection.Select(model => new Consensus.UserInterface.ScreenObject(model));
        }

        /// <summary>
        ///     Retrieves a specific <see cref="!:ScreenObjectModel" /> instance.
        /// </summary>
        /// <param name="id">
        ///     The unique value which distinctly identifies the <see cref="!:ScreenObjectModel" /> instance to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:ScreenObjectModel" /> instance that matches the specified <paramref name="id" />; or null, if no matching instance can be found.
        /// </returns>
        public static Consensus.UserInterface.ScreenObject FetchById(System.Int32 id)
        {
            ConsensusSite site = ConsensusDomain.Configuration[ConsensusDomain.Configuration.DefaultSite];
            return ScreenObject.FetchById(site,id);
        }

        /// <summary>
        ///     Retrieves a specific <see cref="!:ScreenObjectModel" /> instance.
        /// </summary>
        /// <param name="id">
        ///     The unique value which distinctly identifies the <see cref="!:ScreenObjectModel" /> instance to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:ScreenObjectModel" /> instance that matches the specified <paramref name="id" />; or null, if no matching instance can be found.
        /// </returns>
        public static Consensus.UserInterface.ScreenObject FetchById(ConsensusSite site, System.Int32 id)
        {
            IBusinessProvider provider = site.GetService<IBusinessProvider>();
            Consensus.UserInterface.IScreenObjectModel model = provider.UserInterface.ScreenObject.FetchById(id);
            return model == null ? null : new Consensus.UserInterface.ScreenObject(model);
        }

        public static System.String GetTableName()
        {
            ConsensusSite site = ConsensusDomain.Configuration[ConsensusDomain.Configuration.DefaultSite];
            return ScreenObject.GetTableName(site);
        }

        public static System.String GetTableName(ConsensusSite site)
        {
            IBusinessProvider provider = site.GetService<IBusinessProvider>();
            return provider.UserInterface.ScreenObject.GetTableName();
        }

        #endregion
    }
}
