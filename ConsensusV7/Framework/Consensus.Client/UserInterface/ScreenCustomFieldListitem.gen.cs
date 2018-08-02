using System;
using System.Collections.Generic;
using System.Linq;

namespace Consensus.UserInterface
{
    /// <remarks>
    ///     THIS CODE HAS BEEN AUTOMATICALLY GENERATED USING THE CONSENSUS DEVELOPER TOOLS.
    ///     DO NOT EDIT THIS CODE AS ANY CUSTOM MODIFICATIONS WILL BE LOST UPON REGENERATION.
    /// </remarks>
    public partial class ScreenCustomFieldListitem : Proxy<IScreenCustomFieldListitemModel, Int32>
    {
        #region fields

        /// <summary>
        ///     The client-consumable proxy instance for the <see cref="Cfield" /> member.
        /// </summary>
        private Consensus.UserInterface.ScreenCustomField _cfield;

        #endregion

        #region properties

        /// <summary>
        ///     Gets the The value of the "CFLITEM_CFIELD_ID" field.
        /// </summary>
        public Consensus.UserInterface.ScreenCustomField Cfield
        {
            get
            {
                if (_cfield == null && this.Model.Cfield != null)
                    _cfield = new Consensus.UserInterface.ScreenCustomField(this.Model.Cfield);
                if (_cfield == null)
                    _cfield = Consensus.UserInterface.ScreenCustomField.Create();
                return _cfield;
            }
        }

        /// <summary>
        ///     Gets or sets the unique code for the value of the "CFLITEM_CFIELD_ID" field.
        /// </summary>
        public System.Int32 CfieldId
        {
            get { return this.Model.CfieldId; }
            set { this.Model.CfieldId = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "CFLITEM_ID_VALUE" field.
        /// </summary>
        public System.String IdValue
        {
            get { return this.Model.IdValue; }
            set { this.Model.IdValue = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "CFLITEM_TEXT" field.
        /// </summary>
        public System.String Text
        {
            get { return this.Model.Text; }
            set { this.Model.Text = value; }
        }

        #endregion

        #region constructors

        /// <summary>
        ///     Initialises a new instance of the client-consumable class.
        /// </summary>
        internal ScreenCustomFieldListitem(IScreenCustomFieldListitemModel model) : base(model)
        {
        }

        #endregion

        #region methods

        /// <summary>
        ///     Creates a new <see cref="!:ScreenCustomFieldListitemModel" /> instance.
        /// </summary>
        /// <returns>
        ///     A newly instantiated <see cref="!:ScreenCustomFieldListitemModel" /> instance.
        /// </returns>
        public static Consensus.UserInterface.ScreenCustomFieldListitem Create()
        {
            ConsensusSite site = ConsensusDomain.Configuration[ConsensusDomain.Configuration.DefaultSite];
            return ScreenCustomFieldListitem.Create(site);
        }

        /// <summary>
        ///     Creates a new <see cref="!:ScreenCustomFieldListitemModel" /> instance.
        /// </summary>
        /// <returns>
        ///     A newly instantiated <see cref="!:ScreenCustomFieldListitemModel" /> instance.
        /// </returns>
        public static Consensus.UserInterface.ScreenCustomFieldListitem Create(ConsensusSite site)
        {
            IBusinessProvider provider = site.GetService<IBusinessProvider>();
            Consensus.UserInterface.IScreenCustomFieldListitemModel model = provider.UserInterface.ScreenCustomFieldListitem.Create();
            return model == null ? null : new Consensus.UserInterface.ScreenCustomFieldListitem(model);
        }

        /// <summary>
        ///     Retrieves all instances of the <see cref="!:ScreenCustomFieldListitemModel" /> class.
        /// </summary>
        /// <returns>
        ///     An enumerable collection of <see cref="!:ScreenCustomFieldListitemModel" /> instances.
        /// </returns>
        public static IEnumerable<Consensus.UserInterface.ScreenCustomFieldListitem> FetchAll()
        {
            ConsensusSite site = ConsensusDomain.Configuration[ConsensusDomain.Configuration.DefaultSite];
            return ScreenCustomFieldListitem.FetchAll(site);
        }

        /// <summary>
        ///     Retrieves all instances of the <see cref="!:ScreenCustomFieldListitemModel" /> class.
        /// </summary>
        /// <returns>
        ///     An enumerable collection of <see cref="!:ScreenCustomFieldListitemModel" /> instances.
        /// </returns>
        public static IEnumerable<Consensus.UserInterface.ScreenCustomFieldListitem> FetchAll(ConsensusSite site)
        {
            IBusinessProvider provider = site.GetService<IBusinessProvider>();
            IEnumerable<Consensus.UserInterface.IScreenCustomFieldListitemModel> collection = provider.UserInterface.ScreenCustomFieldListitem.FetchAll();
            return collection.Select(model => new Consensus.UserInterface.ScreenCustomFieldListitem(model));
        }

        /// <summary>
        ///     Retrieves a specific <see cref="!:ScreenCustomFieldListitemModel" /> instance.
        /// </summary>
        /// <param name="id">
        ///     The unique value which distinctly identifies the <see cref="!:ScreenCustomFieldListitemModel" /> instance to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:ScreenCustomFieldListitemModel" /> instance that matches the specified <paramref name="id" />; or null, if no matching instance can be found.
        /// </returns>
        public static Consensus.UserInterface.ScreenCustomFieldListitem FetchById(System.Int32 id)
        {
            ConsensusSite site = ConsensusDomain.Configuration[ConsensusDomain.Configuration.DefaultSite];
            return ScreenCustomFieldListitem.FetchById(site,id);
        }

        /// <summary>
        ///     Retrieves a specific <see cref="!:ScreenCustomFieldListitemModel" /> instance.
        /// </summary>
        /// <param name="id">
        ///     The unique value which distinctly identifies the <see cref="!:ScreenCustomFieldListitemModel" /> instance to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:ScreenCustomFieldListitemModel" /> instance that matches the specified <paramref name="id" />; or null, if no matching instance can be found.
        /// </returns>
        public static Consensus.UserInterface.ScreenCustomFieldListitem FetchById(ConsensusSite site, System.Int32 id)
        {
            IBusinessProvider provider = site.GetService<IBusinessProvider>();
            Consensus.UserInterface.IScreenCustomFieldListitemModel model = provider.UserInterface.ScreenCustomFieldListitem.FetchById(id);
            return model == null ? null : new Consensus.UserInterface.ScreenCustomFieldListitem(model);
        }

        public static System.String GetTableName()
        {
            ConsensusSite site = ConsensusDomain.Configuration[ConsensusDomain.Configuration.DefaultSite];
            return ScreenCustomFieldListitem.GetTableName(site);
        }

        public static System.String GetTableName(ConsensusSite site)
        {
            IBusinessProvider provider = site.GetService<IBusinessProvider>();
            return provider.UserInterface.ScreenCustomFieldListitem.GetTableName();
        }

        /// <summary>
        ///     Retrieves a collection of <see cref="!:ScreenCustomFieldListitemModel" /> instances.
        /// </summary>
        /// <param name="cfieldId">
        ///     The value which identifies the <see cref="!:ScreenCustomFieldListitemModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:ScreenCustomFieldListitemModel" /> instances that match the specified <paramref name="cfieldId" />.
        /// </returns>
        public static IEnumerable<Consensus.UserInterface.ScreenCustomFieldListitem> FetchAllByCfieldId(System.Int32 cfieldId)
        {
            ConsensusSite site = ConsensusDomain.Configuration[ConsensusDomain.Configuration.DefaultSite];
            return ScreenCustomFieldListitem.FetchAllByCfieldId(site,cfieldId);
        }

        /// <summary>
        ///     Retrieves a collection of <see cref="!:ScreenCustomFieldListitemModel" /> instances.
        /// </summary>
        /// <param name="cfieldId">
        ///     The value which identifies the <see cref="!:ScreenCustomFieldListitemModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:ScreenCustomFieldListitemModel" /> instances that match the specified <paramref name="cfieldId" />.
        /// </returns>
        public static IEnumerable<Consensus.UserInterface.ScreenCustomFieldListitem> FetchAllByCfieldId(ConsensusSite site, System.Int32 cfieldId)
        {
            IBusinessProvider provider = site.GetService<IBusinessProvider>();
            IEnumerable<Consensus.UserInterface.IScreenCustomFieldListitemModel> collection = provider.UserInterface.ScreenCustomFieldListitem.FetchAllByCfieldId(cfieldId);
            return collection.Select(model => new Consensus.UserInterface.ScreenCustomFieldListitem(model));
        }

        #endregion
    }
}
