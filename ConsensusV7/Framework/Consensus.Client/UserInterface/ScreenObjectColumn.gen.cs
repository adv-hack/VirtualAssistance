using System;
using System.Collections.Generic;
using System.Linq;

namespace Consensus.UserInterface
{
    /// <remarks>
    ///     THIS CODE HAS BEEN AUTOMATICALLY GENERATED USING THE CONSENSUS DEVELOPER TOOLS.
    ///     DO NOT EDIT THIS CODE AS ANY CUSTOM MODIFICATIONS WILL BE LOST UPON REGENERATION.
    /// </remarks>
    public partial class ScreenObjectColumn : Proxy<IScreenObjectColumnModel, Int32>
    {
        #region fields

        /// <summary>
        ///     The client-consumable proxy instance for the <see cref="ScreenObject" /> member.
        /// </summary>
        private Consensus.UserInterface.ScreenObject _screenObject;

        #endregion

        #region properties

        /// <summary>
        ///     Gets the The value of the "OBJCOL_OBJ_ID" field.
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
        ///     Gets or sets the unique code for the value of the "OBJCOL_OBJ_ID" field.
        /// </summary>
        public System.Int32 ScreenObjectId
        {
            get { return this.Model.ScreenObjectId; }
            set { this.Model.ScreenObjectId = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "OBJCOL_ORDINAL" field.
        /// </summary>
        public System.Int32 Ordinal
        {
            get { return this.Model.Ordinal; }
            set { this.Model.Ordinal = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "OBJCOL_CUSTOM" field.
        /// </summary>
        public System.String CustomTitle
        {
            get { return this.Model.CustomTitle; }
            set { this.Model.CustomTitle = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "OBJCOL_EXPORTABLE" field.
        /// </summary>
        public System.Boolean Exportable
        {
            get { return this.Model.Exportable; }
            set { this.Model.Exportable = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "OBJCOL_VISIBLE" field.
        /// </summary>
        public System.Boolean Visible
        {
            get { return this.Model.Visible; }
            set { this.Model.Visible = value; }
        }

        #endregion

        #region constructors

        /// <summary>
        ///     Initialises a new instance of the client-consumable class.
        /// </summary>
        internal ScreenObjectColumn(IScreenObjectColumnModel model) : base(model)
        {
        }

        #endregion

        #region methods

        /// <summary>
        ///     Creates a new <see cref="!:ScreenObjectColumnModel" /> instance.
        /// </summary>
        /// <returns>
        ///     A newly instantiated <see cref="!:ScreenObjectColumnModel" /> instance.
        /// </returns>
        public static Consensus.UserInterface.ScreenObjectColumn Create()
        {
            ConsensusSite site = ConsensusDomain.Configuration[ConsensusDomain.Configuration.DefaultSite];
            return ScreenObjectColumn.Create(site);
        }

        /// <summary>
        ///     Creates a new <see cref="!:ScreenObjectColumnModel" /> instance.
        /// </summary>
        /// <returns>
        ///     A newly instantiated <see cref="!:ScreenObjectColumnModel" /> instance.
        /// </returns>
        public static Consensus.UserInterface.ScreenObjectColumn Create(ConsensusSite site)
        {
            IBusinessProvider provider = site.GetService<IBusinessProvider>();
            Consensus.UserInterface.IScreenObjectColumnModel model = provider.UserInterface.ScreenObjectColumn.Create();
            return model == null ? null : new Consensus.UserInterface.ScreenObjectColumn(model);
        }

        /// <summary>
        ///     Retrieves all instances of the <see cref="!:ScreenObjectColumnModel" /> class.
        /// </summary>
        /// <returns>
        ///     An enumerable collection of <see cref="!:ScreenObjectColumnModel" /> instances.
        /// </returns>
        public static IEnumerable<Consensus.UserInterface.ScreenObjectColumn> FetchAll()
        {
            ConsensusSite site = ConsensusDomain.Configuration[ConsensusDomain.Configuration.DefaultSite];
            return ScreenObjectColumn.FetchAll(site);
        }

        /// <summary>
        ///     Retrieves all instances of the <see cref="!:ScreenObjectColumnModel" /> class.
        /// </summary>
        /// <returns>
        ///     An enumerable collection of <see cref="!:ScreenObjectColumnModel" /> instances.
        /// </returns>
        public static IEnumerable<Consensus.UserInterface.ScreenObjectColumn> FetchAll(ConsensusSite site)
        {
            IBusinessProvider provider = site.GetService<IBusinessProvider>();
            IEnumerable<Consensus.UserInterface.IScreenObjectColumnModel> collection = provider.UserInterface.ScreenObjectColumn.FetchAll();
            return collection.Select(model => new Consensus.UserInterface.ScreenObjectColumn(model));
        }

        /// <summary>
        ///     Retrieves a specific <see cref="!:ScreenObjectColumnModel" /> instance.
        /// </summary>
        /// <param name="id">
        ///     The unique value which distinctly identifies the <see cref="!:ScreenObjectColumnModel" /> instance to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:ScreenObjectColumnModel" /> instance that matches the specified <paramref name="id" />; or null, if no matching instance can be found.
        /// </returns>
        public static Consensus.UserInterface.ScreenObjectColumn FetchById(System.Int32 id)
        {
            ConsensusSite site = ConsensusDomain.Configuration[ConsensusDomain.Configuration.DefaultSite];
            return ScreenObjectColumn.FetchById(site,id);
        }

        /// <summary>
        ///     Retrieves a specific <see cref="!:ScreenObjectColumnModel" /> instance.
        /// </summary>
        /// <param name="id">
        ///     The unique value which distinctly identifies the <see cref="!:ScreenObjectColumnModel" /> instance to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:ScreenObjectColumnModel" /> instance that matches the specified <paramref name="id" />; or null, if no matching instance can be found.
        /// </returns>
        public static Consensus.UserInterface.ScreenObjectColumn FetchById(ConsensusSite site, System.Int32 id)
        {
            IBusinessProvider provider = site.GetService<IBusinessProvider>();
            Consensus.UserInterface.IScreenObjectColumnModel model = provider.UserInterface.ScreenObjectColumn.FetchById(id);
            return model == null ? null : new Consensus.UserInterface.ScreenObjectColumn(model);
        }

        public static System.String GetTableName()
        {
            ConsensusSite site = ConsensusDomain.Configuration[ConsensusDomain.Configuration.DefaultSite];
            return ScreenObjectColumn.GetTableName(site);
        }

        public static System.String GetTableName(ConsensusSite site)
        {
            IBusinessProvider provider = site.GetService<IBusinessProvider>();
            return provider.UserInterface.ScreenObjectColumn.GetTableName();
        }

        /// <summary>
        ///     Retrieves a collection of <see cref="!:ScreenObjectColumnModel" /> instances.
        /// </summary>
        /// <param name="screenObjectId">
        ///     The value which identifies the <see cref="!:ScreenObjectColumnModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:ScreenObjectColumnModel" /> instances that match the specified <paramref name="screenObjectId" />.
        /// </returns>
        public static IEnumerable<Consensus.UserInterface.ScreenObjectColumn> FetchAllByScreenObjectId(System.Int32 screenObjectId)
        {
            ConsensusSite site = ConsensusDomain.Configuration[ConsensusDomain.Configuration.DefaultSite];
            return ScreenObjectColumn.FetchAllByScreenObjectId(site,screenObjectId);
        }

        /// <summary>
        ///     Retrieves a collection of <see cref="!:ScreenObjectColumnModel" /> instances.
        /// </summary>
        /// <param name="screenObjectId">
        ///     The value which identifies the <see cref="!:ScreenObjectColumnModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:ScreenObjectColumnModel" /> instances that match the specified <paramref name="screenObjectId" />.
        /// </returns>
        public static IEnumerable<Consensus.UserInterface.ScreenObjectColumn> FetchAllByScreenObjectId(ConsensusSite site, System.Int32 screenObjectId)
        {
            IBusinessProvider provider = site.GetService<IBusinessProvider>();
            IEnumerable<Consensus.UserInterface.IScreenObjectColumnModel> collection = provider.UserInterface.ScreenObjectColumn.FetchAllByScreenObjectId(screenObjectId);
            return collection.Select(model => new Consensus.UserInterface.ScreenObjectColumn(model));
        }

        #endregion
    }
}
