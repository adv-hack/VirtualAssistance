using System;
using System.Collections.Generic;
using System.Linq;
using Consensus.Security;

namespace Consensus.UserInterface
{
    /// <remarks>
    ///     THIS CODE HAS BEEN AUTOMATICALLY GENERATED USING THE CONSENSUS DEVELOPER TOOLS.
    ///     DO NOT EDIT THIS CODE AS ANY CUSTOM MODIFICATIONS WILL BE LOST UPON REGENERATION.
    /// </remarks>
    public partial class ScreenObjectDisplay : Proxy<IScreenObjectDisplayModel, Int32>
    {
        #region fields

        /// <summary>
        ///     The client-consumable proxy instance for the <see cref="ScreenObject" /> member.
        /// </summary>
        private Consensus.UserInterface.ScreenObject _screenObject;

        /// <summary>
        ///     The client-consumable proxy instance for the <see cref="Principal" /> member.
        /// </summary>
        private Consensus.Security.UserPrincipal _principal;

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
        ///     Gets the The value of the "OBJDIS_OBJ_ID" field.
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
        ///     Gets or sets the unique code for the value of the "OBJDIS_OBJ_ID" field.
        /// </summary>
        public System.Int32 ScreenObjectId
        {
            get { return this.Model.ScreenObjectId; }
            set { this.Model.ScreenObjectId = value; }
        }

        /// <summary>
        ///     Gets the The value of the "OBJDIS_PRINCIPAL_ID" field.
        /// </summary>
        public Consensus.Security.UserPrincipal Principal
        {
            get
            {
                if (_principal == null && this.Model.Principal != null)
                    _principal = new Consensus.Security.UserPrincipal(this.Model.Principal);
                if (_principal == null)
                    _principal = Consensus.Security.UserPrincipal.Create();
                return _principal;
            }
        }

        /// <summary>
        ///     Gets or sets the unique code for the value of the "OBJDIS_PRINCIPAL_ID" field.
        /// </summary>
        public System.Int32 PrincipalId
        {
            get { return this.Model.PrincipalId; }
            set { this.Model.PrincipalId = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "OBJDIS_DISPLAY" field.
        /// </summary>
        public System.Byte Display
        {
            get { return this.Model.Display; }
            set { this.Model.Display = value; }
        }

        #endregion

        #region constructors

        /// <summary>
        ///     Initialises a new instance of the client-consumable class.
        /// </summary>
        internal ScreenObjectDisplay(IScreenObjectDisplayModel model) : base(model)
        {
        }

        #endregion

        #region methods

        /// <summary>
        ///     Creates a new <see cref="!:ScreenObjectDisplayModel" /> instance.
        /// </summary>
        /// <returns>
        ///     A newly instantiated <see cref="!:ScreenObjectDisplayModel" /> instance.
        /// </returns>
        public static Consensus.UserInterface.ScreenObjectDisplay Create()
        {
            ConsensusSite site = ConsensusDomain.Configuration[ConsensusDomain.Configuration.DefaultSite];
            return ScreenObjectDisplay.Create(site);
        }

        /// <summary>
        ///     Creates a new <see cref="!:ScreenObjectDisplayModel" /> instance.
        /// </summary>
        /// <returns>
        ///     A newly instantiated <see cref="!:ScreenObjectDisplayModel" /> instance.
        /// </returns>
        public static Consensus.UserInterface.ScreenObjectDisplay Create(ConsensusSite site)
        {
            IBusinessProvider provider = site.GetService<IBusinessProvider>();
            Consensus.UserInterface.IScreenObjectDisplayModel model = provider.UserInterface.ScreenObjectDisplay.Create();
            return model == null ? null : new Consensus.UserInterface.ScreenObjectDisplay(model);
        }

        /// <summary>
        ///     Retrieves all instances of the <see cref="!:ScreenObjectDisplayModel" /> class.
        /// </summary>
        /// <returns>
        ///     An enumerable collection of <see cref="!:ScreenObjectDisplayModel" /> instances.
        /// </returns>
        public static IEnumerable<Consensus.UserInterface.ScreenObjectDisplay> FetchAll()
        {
            ConsensusSite site = ConsensusDomain.Configuration[ConsensusDomain.Configuration.DefaultSite];
            return ScreenObjectDisplay.FetchAll(site);
        }

        /// <summary>
        ///     Retrieves all instances of the <see cref="!:ScreenObjectDisplayModel" /> class.
        /// </summary>
        /// <returns>
        ///     An enumerable collection of <see cref="!:ScreenObjectDisplayModel" /> instances.
        /// </returns>
        public static IEnumerable<Consensus.UserInterface.ScreenObjectDisplay> FetchAll(ConsensusSite site)
        {
            IBusinessProvider provider = site.GetService<IBusinessProvider>();
            IEnumerable<Consensus.UserInterface.IScreenObjectDisplayModel> collection = provider.UserInterface.ScreenObjectDisplay.FetchAll();
            return collection.Select(model => new Consensus.UserInterface.ScreenObjectDisplay(model));
        }

        /// <summary>
        ///     Retrieves a specific <see cref="!:ScreenObjectDisplayModel" /> instance.
        /// </summary>
        /// <param name="id">
        ///     The unique value which distinctly identifies the <see cref="!:ScreenObjectDisplayModel" /> instance to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:ScreenObjectDisplayModel" /> instance that matches the specified <paramref name="id" />; or null, if no matching instance can be found.
        /// </returns>
        public static Consensus.UserInterface.ScreenObjectDisplay FetchById(System.Int32 id)
        {
            ConsensusSite site = ConsensusDomain.Configuration[ConsensusDomain.Configuration.DefaultSite];
            return ScreenObjectDisplay.FetchById(site,id);
        }

        /// <summary>
        ///     Retrieves a specific <see cref="!:ScreenObjectDisplayModel" /> instance.
        /// </summary>
        /// <param name="id">
        ///     The unique value which distinctly identifies the <see cref="!:ScreenObjectDisplayModel" /> instance to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:ScreenObjectDisplayModel" /> instance that matches the specified <paramref name="id" />; or null, if no matching instance can be found.
        /// </returns>
        public static Consensus.UserInterface.ScreenObjectDisplay FetchById(ConsensusSite site, System.Int32 id)
        {
            IBusinessProvider provider = site.GetService<IBusinessProvider>();
            Consensus.UserInterface.IScreenObjectDisplayModel model = provider.UserInterface.ScreenObjectDisplay.FetchById(id);
            return model == null ? null : new Consensus.UserInterface.ScreenObjectDisplay(model);
        }

        public static System.String GetTableName()
        {
            ConsensusSite site = ConsensusDomain.Configuration[ConsensusDomain.Configuration.DefaultSite];
            return ScreenObjectDisplay.GetTableName(site);
        }

        public static System.String GetTableName(ConsensusSite site)
        {
            IBusinessProvider provider = site.GetService<IBusinessProvider>();
            return provider.UserInterface.ScreenObjectDisplay.GetTableName();
        }

        /// <summary>
        ///     Retrieves a collection of <see cref="!:ScreenObjectDisplayModel" /> instances.
        /// </summary>
        /// <param name="screenObjectId">
        ///     The value which identifies the <see cref="!:ScreenObjectDisplayModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:ScreenObjectDisplayModel" /> instances that match the specified <paramref name="screenObjectId" />.
        /// </returns>
        public static IEnumerable<Consensus.UserInterface.ScreenObjectDisplay> FetchAllByScreenObjectId(System.Int32 screenObjectId)
        {
            ConsensusSite site = ConsensusDomain.Configuration[ConsensusDomain.Configuration.DefaultSite];
            return ScreenObjectDisplay.FetchAllByScreenObjectId(site,screenObjectId);
        }

        /// <summary>
        ///     Retrieves a collection of <see cref="!:ScreenObjectDisplayModel" /> instances.
        /// </summary>
        /// <param name="screenObjectId">
        ///     The value which identifies the <see cref="!:ScreenObjectDisplayModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:ScreenObjectDisplayModel" /> instances that match the specified <paramref name="screenObjectId" />.
        /// </returns>
        public static IEnumerable<Consensus.UserInterface.ScreenObjectDisplay> FetchAllByScreenObjectId(ConsensusSite site, System.Int32 screenObjectId)
        {
            IBusinessProvider provider = site.GetService<IBusinessProvider>();
            IEnumerable<Consensus.UserInterface.IScreenObjectDisplayModel> collection = provider.UserInterface.ScreenObjectDisplay.FetchAllByScreenObjectId(screenObjectId);
            return collection.Select(model => new Consensus.UserInterface.ScreenObjectDisplay(model));
        }

        /// <summary>
        ///     Retrieves a collection of <see cref="!:ScreenObjectDisplayModel" /> instances.
        /// </summary>
        /// <param name="principalId">
        ///     The value which identifies the <see cref="!:ScreenObjectDisplayModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:ScreenObjectDisplayModel" /> instances that match the specified <paramref name="principalId" />.
        /// </returns>
        public static IEnumerable<Consensus.UserInterface.ScreenObjectDisplay> FetchAllByPrincipalId(System.Int32 principalId)
        {
            ConsensusSite site = ConsensusDomain.Configuration[ConsensusDomain.Configuration.DefaultSite];
            return ScreenObjectDisplay.FetchAllByPrincipalId(site,principalId);
        }

        /// <summary>
        ///     Retrieves a collection of <see cref="!:ScreenObjectDisplayModel" /> instances.
        /// </summary>
        /// <param name="principalId">
        ///     The value which identifies the <see cref="!:ScreenObjectDisplayModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:ScreenObjectDisplayModel" /> instances that match the specified <paramref name="principalId" />.
        /// </returns>
        public static IEnumerable<Consensus.UserInterface.ScreenObjectDisplay> FetchAllByPrincipalId(ConsensusSite site, System.Int32 principalId)
        {
            IBusinessProvider provider = site.GetService<IBusinessProvider>();
            IEnumerable<Consensus.UserInterface.IScreenObjectDisplayModel> collection = provider.UserInterface.ScreenObjectDisplay.FetchAllByPrincipalId(principalId);
            return collection.Select(model => new Consensus.UserInterface.ScreenObjectDisplay(model));
        }

        #endregion
    }
}
