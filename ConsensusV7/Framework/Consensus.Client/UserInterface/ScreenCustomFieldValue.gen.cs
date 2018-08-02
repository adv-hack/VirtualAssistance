using System;
using System.Collections.Generic;
using System.Linq;

namespace Consensus.UserInterface
{
    /// <remarks>
    ///     THIS CODE HAS BEEN AUTOMATICALLY GENERATED USING THE CONSENSUS DEVELOPER TOOLS.
    ///     DO NOT EDIT THIS CODE AS ANY CUSTOM MODIFICATIONS WILL BE LOST UPON REGENERATION.
    /// </remarks>
    public partial class ScreenCustomFieldValue : Proxy<IScreenCustomFieldValueModel, Int32>
    {
        #region fields

        /// <summary>
        ///     The client-consumable proxy instance for the <see cref="Cfield" /> member.
        /// </summary>
        private Consensus.UserInterface.ScreenCustomField _cfield;

        #endregion

        #region properties

        /// <summary>
        ///     Gets the The value of the "CFVALUE_CFIELD_ID" field.
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
        ///     Gets or sets the unique code for the value of the "CFVALUE_CFIELD_ID" field.
        /// </summary>
        public System.Int32 CfieldId
        {
            get { return this.Model.CfieldId; }
            set { this.Model.CfieldId = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "CFVALUE_RECORD_ID" field.
        /// </summary>
        public System.String RecordId
        {
            get { return this.Model.RecordId; }
            set { this.Model.RecordId = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "CFVALUE_TEXT" field.
        /// </summary>
        public System.String Text
        {
            get { return this.Model.Text; }
            set { this.Model.Text = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "CFVALUE_NUMBER" field.
        /// </summary>
        public System.Nullable<System.Decimal> Number
        {
            get { return this.Model.Number; }
            set { this.Model.Number = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "CFVALUE_ID_VALUE" field.
        /// </summary>
        public System.String IdValue
        {
            get { return this.Model.IdValue; }
            set { this.Model.IdValue = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "CFVALUE_DATE" field.
        /// </summary>
        public System.Nullable<System.DateTime> Date
        {
            get { return this.Model.Date; }
            set { this.Model.Date = value; }
        }

        #endregion

        #region constructors

        /// <summary>
        ///     Initialises a new instance of the client-consumable class.
        /// </summary>
        internal ScreenCustomFieldValue(IScreenCustomFieldValueModel model) : base(model)
        {
        }

        #endregion

        #region methods

        public static Consensus.UserInterface.ScreenCustomFieldValue FetchByFieldIdAndRecordId(System.Int32 fieldId, System.String recordId)
        {
            ConsensusSite site = ConsensusDomain.Configuration[ConsensusDomain.Configuration.DefaultSite];
            return ScreenCustomFieldValue.FetchByFieldIdAndRecordId(site,fieldId,recordId);
        }

        public static Consensus.UserInterface.ScreenCustomFieldValue FetchByFieldIdAndRecordId(ConsensusSite site, System.Int32 fieldId, System.String recordId)
        {
            IBusinessProvider provider = site.GetService<IBusinessProvider>();
            Consensus.UserInterface.IScreenCustomFieldValueModel model = provider.UserInterface.ScreenCustomFieldValue.FetchByFieldIdAndRecordId(fieldId,recordId);
            return model == null ? null : new Consensus.UserInterface.ScreenCustomFieldValue(model);
        }

        /// <summary>
        ///     Creates a new <see cref="!:ScreenCustomFieldValueModel" /> instance.
        /// </summary>
        /// <returns>
        ///     A newly instantiated <see cref="!:ScreenCustomFieldValueModel" /> instance.
        /// </returns>
        public static Consensus.UserInterface.ScreenCustomFieldValue Create()
        {
            ConsensusSite site = ConsensusDomain.Configuration[ConsensusDomain.Configuration.DefaultSite];
            return ScreenCustomFieldValue.Create(site);
        }

        /// <summary>
        ///     Creates a new <see cref="!:ScreenCustomFieldValueModel" /> instance.
        /// </summary>
        /// <returns>
        ///     A newly instantiated <see cref="!:ScreenCustomFieldValueModel" /> instance.
        /// </returns>
        public static Consensus.UserInterface.ScreenCustomFieldValue Create(ConsensusSite site)
        {
            IBusinessProvider provider = site.GetService<IBusinessProvider>();
            Consensus.UserInterface.IScreenCustomFieldValueModel model = provider.UserInterface.ScreenCustomFieldValue.Create();
            return model == null ? null : new Consensus.UserInterface.ScreenCustomFieldValue(model);
        }

        /// <summary>
        ///     Retrieves all instances of the <see cref="!:ScreenCustomFieldValueModel" /> class.
        /// </summary>
        /// <returns>
        ///     An enumerable collection of <see cref="!:ScreenCustomFieldValueModel" /> instances.
        /// </returns>
        public static IEnumerable<Consensus.UserInterface.ScreenCustomFieldValue> FetchAll()
        {
            ConsensusSite site = ConsensusDomain.Configuration[ConsensusDomain.Configuration.DefaultSite];
            return ScreenCustomFieldValue.FetchAll(site);
        }

        /// <summary>
        ///     Retrieves all instances of the <see cref="!:ScreenCustomFieldValueModel" /> class.
        /// </summary>
        /// <returns>
        ///     An enumerable collection of <see cref="!:ScreenCustomFieldValueModel" /> instances.
        /// </returns>
        public static IEnumerable<Consensus.UserInterface.ScreenCustomFieldValue> FetchAll(ConsensusSite site)
        {
            IBusinessProvider provider = site.GetService<IBusinessProvider>();
            IEnumerable<Consensus.UserInterface.IScreenCustomFieldValueModel> collection = provider.UserInterface.ScreenCustomFieldValue.FetchAll();
            return collection.Select(model => new Consensus.UserInterface.ScreenCustomFieldValue(model));
        }

        /// <summary>
        ///     Retrieves a specific <see cref="!:ScreenCustomFieldValueModel" /> instance.
        /// </summary>
        /// <param name="id">
        ///     The unique value which distinctly identifies the <see cref="!:ScreenCustomFieldValueModel" /> instance to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:ScreenCustomFieldValueModel" /> instance that matches the specified <paramref name="id" />; or null, if no matching instance can be found.
        /// </returns>
        public static Consensus.UserInterface.ScreenCustomFieldValue FetchById(System.Int32 id)
        {
            ConsensusSite site = ConsensusDomain.Configuration[ConsensusDomain.Configuration.DefaultSite];
            return ScreenCustomFieldValue.FetchById(site,id);
        }

        /// <summary>
        ///     Retrieves a specific <see cref="!:ScreenCustomFieldValueModel" /> instance.
        /// </summary>
        /// <param name="id">
        ///     The unique value which distinctly identifies the <see cref="!:ScreenCustomFieldValueModel" /> instance to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:ScreenCustomFieldValueModel" /> instance that matches the specified <paramref name="id" />; or null, if no matching instance can be found.
        /// </returns>
        public static Consensus.UserInterface.ScreenCustomFieldValue FetchById(ConsensusSite site, System.Int32 id)
        {
            IBusinessProvider provider = site.GetService<IBusinessProvider>();
            Consensus.UserInterface.IScreenCustomFieldValueModel model = provider.UserInterface.ScreenCustomFieldValue.FetchById(id);
            return model == null ? null : new Consensus.UserInterface.ScreenCustomFieldValue(model);
        }

        public static System.String GetTableName()
        {
            ConsensusSite site = ConsensusDomain.Configuration[ConsensusDomain.Configuration.DefaultSite];
            return ScreenCustomFieldValue.GetTableName(site);
        }

        public static System.String GetTableName(ConsensusSite site)
        {
            IBusinessProvider provider = site.GetService<IBusinessProvider>();
            return provider.UserInterface.ScreenCustomFieldValue.GetTableName();
        }

        /// <summary>
        ///     Retrieves a collection of <see cref="!:ScreenCustomFieldValueModel" /> instances.
        /// </summary>
        /// <param name="cfieldId">
        ///     The value which identifies the <see cref="!:ScreenCustomFieldValueModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:ScreenCustomFieldValueModel" /> instances that match the specified <paramref name="cfieldId" />.
        /// </returns>
        public static IEnumerable<Consensus.UserInterface.ScreenCustomFieldValue> FetchAllByCfieldId(System.Int32 cfieldId)
        {
            ConsensusSite site = ConsensusDomain.Configuration[ConsensusDomain.Configuration.DefaultSite];
            return ScreenCustomFieldValue.FetchAllByCfieldId(site,cfieldId);
        }

        /// <summary>
        ///     Retrieves a collection of <see cref="!:ScreenCustomFieldValueModel" /> instances.
        /// </summary>
        /// <param name="cfieldId">
        ///     The value which identifies the <see cref="!:ScreenCustomFieldValueModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:ScreenCustomFieldValueModel" /> instances that match the specified <paramref name="cfieldId" />.
        /// </returns>
        public static IEnumerable<Consensus.UserInterface.ScreenCustomFieldValue> FetchAllByCfieldId(ConsensusSite site, System.Int32 cfieldId)
        {
            IBusinessProvider provider = site.GetService<IBusinessProvider>();
            IEnumerable<Consensus.UserInterface.IScreenCustomFieldValueModel> collection = provider.UserInterface.ScreenCustomFieldValue.FetchAllByCfieldId(cfieldId);
            return collection.Select(model => new Consensus.UserInterface.ScreenCustomFieldValue(model));
        }

        #endregion
    }
}
