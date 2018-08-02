using System;
using System.Collections.Generic;
using System.Linq;

namespace Consensus.UserInterface
{
    /// <remarks>
    ///     THIS CODE HAS BEEN AUTOMATICALLY GENERATED USING THE CONSENSUS DEVELOPER TOOLS.
    ///     DO NOT EDIT THIS CODE AS ANY CUSTOM MODIFICATIONS WILL BE LOST UPON REGENERATION.
    /// </remarks>
    public partial class ScreenObjectEntry : Proxy<IScreenObjectEntryModel, Int32>
    {
        #region fields

        /// <summary>
        ///     The client-consumable proxy instance for the <see cref="ScreenObject" /> member.
        /// </summary>
        private Consensus.UserInterface.ScreenObject _screenObject;

        #endregion

        #region properties

        /// <summary>
        ///     Gets the The value of the "OBJENT_OBJ_ID" field.
        /// </summary>
        public Consensus.UserInterface.ScreenObject ScreenObject
        {
            get
            {
                if (_screenObject == null && this.Model.ScreenObject != null)
                    _screenObject = new Consensus.UserInterface.ScreenObject(this.Model.ScreenObject);
                if (_screenObject == null)
                    _screenObject = Consensus.UserInterface.ScreenObject.Create();
                return _screenObject;
            }
        }

        /// <summary>
        ///     Gets or sets the unique code for the value of the "OBJENT_OBJ_ID" field.
        /// </summary>
        public System.Int32 ScreenObjectId
        {
            get { return this.Model.ScreenObjectId; }
            set { this.Model.ScreenObjectId = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "OBJENT_ITEM_NORMAL" field.
        /// </summary>
        public System.String Normal
        {
            get { return this.Model.Normal; }
            set { this.Model.Normal = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "OBJENT_ITEM_CUSTOM" field.
        /// </summary>
        public System.String Custom
        {
            get { return this.Model.Custom; }
            set { this.Model.Custom = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "OBJENT_ITEM_HIDE" field.
        /// </summary>
        public System.Boolean Hide
        {
            get { return this.Model.Hide; }
            set { this.Model.Hide = value; }
        }

        #endregion

        #region constructors

        /// <summary>
        ///     Initialises a new instance of the client-consumable class.
        /// </summary>
        internal ScreenObjectEntry(IScreenObjectEntryModel model) : base(model)
        {
        }

        #endregion

        #region methods

        /// <summary>
        ///     Creates a new <see cref="!:ScreenObjectEntryModel" /> instance.
        /// </summary>
        /// <returns>
        ///     A newly instantiated <see cref="!:ScreenObjectEntryModel" /> instance.
        /// </returns>
        public static Consensus.UserInterface.ScreenObjectEntry Create()
        {
            ConsensusSite site = ConsensusDomain.Configuration[ConsensusDomain.Configuration.DefaultSite];
            return ScreenObjectEntry.Create(site);
        }

        /// <summary>
        ///     Creates a new <see cref="!:ScreenObjectEntryModel" /> instance.
        /// </summary>
        /// <returns>
        ///     A newly instantiated <see cref="!:ScreenObjectEntryModel" /> instance.
        /// </returns>
        public static Consensus.UserInterface.ScreenObjectEntry Create(ConsensusSite site)
        {
            IBusinessProvider provider = site.GetService<IBusinessProvider>();
            Consensus.UserInterface.IScreenObjectEntryModel model = provider.UserInterface.ScreenObjectEntry.Create();
            return model == null ? null : new Consensus.UserInterface.ScreenObjectEntry(model);
        }

        /// <summary>
        ///     Retrieves all instances of the <see cref="!:ScreenObjectEntryModel" /> class.
        /// </summary>
        /// <returns>
        ///     An enumerable collection of <see cref="!:ScreenObjectEntryModel" /> instances.
        /// </returns>
        public static IEnumerable<Consensus.UserInterface.ScreenObjectEntry> FetchAll()
        {
            ConsensusSite site = ConsensusDomain.Configuration[ConsensusDomain.Configuration.DefaultSite];
            return ScreenObjectEntry.FetchAll(site);
        }

        /// <summary>
        ///     Retrieves all instances of the <see cref="!:ScreenObjectEntryModel" /> class.
        /// </summary>
        /// <returns>
        ///     An enumerable collection of <see cref="!:ScreenObjectEntryModel" /> instances.
        /// </returns>
        public static IEnumerable<Consensus.UserInterface.ScreenObjectEntry> FetchAll(ConsensusSite site)
        {
            IBusinessProvider provider = site.GetService<IBusinessProvider>();
            IEnumerable<Consensus.UserInterface.IScreenObjectEntryModel> collection = provider.UserInterface.ScreenObjectEntry.FetchAll();
            return collection.Select(model => new Consensus.UserInterface.ScreenObjectEntry(model));
        }

        /// <summary>
        ///     Retrieves a specific <see cref="!:ScreenObjectEntryModel" /> instance.
        /// </summary>
        /// <param name="id">
        ///     The unique value which distinctly identifies the <see cref="!:ScreenObjectEntryModel" /> instance to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:ScreenObjectEntryModel" /> instance that matches the specified <paramref name="id" />; or null, if no matching instance can be found.
        /// </returns>
        public static Consensus.UserInterface.ScreenObjectEntry FetchById(System.Int32 id)
        {
            ConsensusSite site = ConsensusDomain.Configuration[ConsensusDomain.Configuration.DefaultSite];
            return ScreenObjectEntry.FetchById(site,id);
        }

        /// <summary>
        ///     Retrieves a specific <see cref="!:ScreenObjectEntryModel" /> instance.
        /// </summary>
        /// <param name="id">
        ///     The unique value which distinctly identifies the <see cref="!:ScreenObjectEntryModel" /> instance to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:ScreenObjectEntryModel" /> instance that matches the specified <paramref name="id" />; or null, if no matching instance can be found.
        /// </returns>
        public static Consensus.UserInterface.ScreenObjectEntry FetchById(ConsensusSite site, System.Int32 id)
        {
            IBusinessProvider provider = site.GetService<IBusinessProvider>();
            Consensus.UserInterface.IScreenObjectEntryModel model = provider.UserInterface.ScreenObjectEntry.FetchById(id);
            return model == null ? null : new Consensus.UserInterface.ScreenObjectEntry(model);
        }

        public static System.String GetTableName()
        {
            ConsensusSite site = ConsensusDomain.Configuration[ConsensusDomain.Configuration.DefaultSite];
            return ScreenObjectEntry.GetTableName(site);
        }

        public static System.String GetTableName(ConsensusSite site)
        {
            IBusinessProvider provider = site.GetService<IBusinessProvider>();
            return provider.UserInterface.ScreenObjectEntry.GetTableName();
        }

        /// <summary>
        ///     Retrieves a collection of <see cref="!:ScreenObjectEntryModel" /> instances.
        /// </summary>
        /// <param name="screenObjectId">
        ///     The value which identifies the <see cref="!:ScreenObjectEntryModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:ScreenObjectEntryModel" /> instances that match the specified <paramref name="screenObjectId" />.
        /// </returns>
        public static IEnumerable<Consensus.UserInterface.ScreenObjectEntry> FetchAllByScreenObjectId(System.Int32 screenObjectId)
        {
            ConsensusSite site = ConsensusDomain.Configuration[ConsensusDomain.Configuration.DefaultSite];
            return ScreenObjectEntry.FetchAllByScreenObjectId(site,screenObjectId);
        }

        /// <summary>
        ///     Retrieves a collection of <see cref="!:ScreenObjectEntryModel" /> instances.
        /// </summary>
        /// <param name="screenObjectId">
        ///     The value which identifies the <see cref="!:ScreenObjectEntryModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:ScreenObjectEntryModel" /> instances that match the specified <paramref name="screenObjectId" />.
        /// </returns>
        public static IEnumerable<Consensus.UserInterface.ScreenObjectEntry> FetchAllByScreenObjectId(ConsensusSite site, System.Int32 screenObjectId)
        {
            IBusinessProvider provider = site.GetService<IBusinessProvider>();
            IEnumerable<Consensus.UserInterface.IScreenObjectEntryModel> collection = provider.UserInterface.ScreenObjectEntry.FetchAllByScreenObjectId(screenObjectId);
            return collection.Select(model => new Consensus.UserInterface.ScreenObjectEntry(model));
        }

        #endregion
    }
}
