using System;
using System.Collections.Generic;
using System.Linq;
using Consensus.Common;

namespace Consensus.Contact
{
    /// <remarks>
    ///     THIS CODE HAS BEEN AUTOMATICALLY GENERATED USING THE CONSENSUS DEVELOPER TOOLS.
    ///     DO NOT EDIT THIS CODE AS ANY CUSTOM MODIFICATIONS WILL BE LOST UPON REGENERATION.
    /// </remarks>
    public partial class Communications : Proxy<ICommunicationsModel, Int64>
    {
        #region fields

        /// <summary>
        ///     The client-consumable proxy instance for the <see cref="DeviceCode" /> member.
        /// </summary>
        private Consensus.Common.Code _deviceCode;

        /// <summary>
        ///     The client-consumable proxy collection for the <see cref="CommId" /> member.
        /// </summary>
        private ProxyCollection<Consensus.Contact.Communications_Xref, Consensus.Contact.ICommunications_XrefModel> _commId;

        #endregion

        #region properties

        /// <summary>
        ///     Gets the recognised type of the device.
        /// </summary>
        public System.String DeviceType
        {
            get { return this.Model.DeviceType; }
        }

        /// <summary>
        ///     Gets or sets the value of the "COMM_ACTIVE" field.
        /// </summary>
        public System.Boolean Active
        {
            get { return this.Model.Active; }
            set { this.Model.Active = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "COMM_DEFAULT" field.
        /// </summary>
        public System.Boolean Default
        {
            get { return this.Model.Default; }
            set { this.Model.Default = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "COMM_PREFERRED" field.
        /// </summary>
        public System.Boolean Preferred
        {
            get { return this.Model.Preferred; }
            set { this.Model.Preferred = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "COMM_EX_DIRECTORY" field.
        /// </summary>
        public System.Boolean ExDirectory
        {
            get { return this.Model.ExDirectory; }
            set { this.Model.ExDirectory = value; }
        }

        /// <summary>
        ///     Gets the The value of the "COMM_DEVICE_CODE" field.
        /// </summary>
        public Consensus.Common.Code DeviceCode
        {
            get
            {
                if (_deviceCode == null && this.Model.DeviceCode != null)
                    _deviceCode = new Consensus.Common.Code(this.Model.DeviceCode);
                if (_deviceCode == null)
                    _deviceCode = Consensus.Common.Code.Create();
                return _deviceCode;
            }
        }

        /// <summary>
        ///     Gets or sets the unique code for the value of the "COMM_DEVICE_CODE" field.
        /// </summary>
        public System.String DeviceCodeCode
        {
            get { return this.Model.DeviceCodeCode; }
            set { this.Model.DeviceCodeCode = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "COMM_DIALLING_CODE" field.
        /// </summary>
        public System.String DiallingCode
        {
            get { return this.Model.DiallingCode; }
            set { this.Model.DiallingCode = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "COMM_STD_CODE" field.
        /// </summary>
        public System.String StdCode
        {
            get { return this.Model.StdCode; }
            set { this.Model.StdCode = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "COMM_EXTENSION" field.
        /// </summary>
        public System.String Extension
        {
            get { return this.Model.Extension; }
            set { this.Model.Extension = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "COMM_NOTES" field.
        /// </summary>
        public System.String Notes
        {
            get { return this.Model.Notes; }
            set { this.Model.Notes = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "COMM_VALID_FROM" field.
        /// </summary>
        public System.Nullable<System.DateTime> ValidFrom
        {
            get { return this.Model.ValidFrom; }
            set { this.Model.ValidFrom = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "COMM_DEVICE_VALUE" field.
        /// </summary>
        public System.String DeviceValue
        {
            get { return this.Model.DeviceValue; }
            set { this.Model.DeviceValue = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "COMM_DEVICE_FULL_VALUE" field.
        /// </summary>
        public System.String DeviceFullValue
        {
            get { return this.Model.DeviceFullValue; }
            set { this.Model.DeviceFullValue = value; }
        }

        /// <summary>
        ///     Gets the collection of <see cref="!:Communications_XrefModel" /> instances that reference this <see cref="!:CommunicationsModel" />.
        /// </summary>
        public Collection<Consensus.Contact.Communications_Xref> CommId
        {
            get
            {
                if (_commId == null)
                    _commId = new ProxyCollection<Consensus.Contact.Communications_Xref, Consensus.Contact.ICommunications_XrefModel>(this.Model.CommId, model => new Consensus.Contact.Communications_Xref(model));
                return _commId;
            }
        }

        #endregion

        #region constructors

        /// <summary>
        ///     Initialises a new instance of the client-consumable class.
        /// </summary>
        internal Communications(ICommunicationsModel model) : base(model)
        {
        }

        #endregion

        #region methods

        /// <summary>
        ///     Creates a new <see cref="!:CommunicationsModel" /> instance.
        /// </summary>
        /// <returns>
        ///     A newly instantiated <see cref="!:CommunicationsModel" /> instance.
        /// </returns>
        public static Consensus.Contact.Communications Create()
        {
            ConsensusSite site = ConsensusDomain.Configuration[ConsensusDomain.Configuration.DefaultSite];
            return Communications.Create(site);
        }

        /// <summary>
        ///     Creates a new <see cref="!:CommunicationsModel" /> instance.
        /// </summary>
        /// <returns>
        ///     A newly instantiated <see cref="!:CommunicationsModel" /> instance.
        /// </returns>
        public static Consensus.Contact.Communications Create(ConsensusSite site)
        {
            IBusinessProvider provider = site.GetService<IBusinessProvider>();
            Consensus.Contact.ICommunicationsModel model = provider.Contact.Communications.Create();
            return model == null ? null : new Consensus.Contact.Communications(model);
        }

        /// <summary>
        ///     Retrieves all instances of the <see cref="!:CommunicationsModel" /> class.
        /// </summary>
        /// <returns>
        ///     An enumerable collection of <see cref="!:CommunicationsModel" /> instances.
        /// </returns>
        public static IEnumerable<Consensus.Contact.Communications> FetchAll()
        {
            ConsensusSite site = ConsensusDomain.Configuration[ConsensusDomain.Configuration.DefaultSite];
            return Communications.FetchAll(site);
        }

        /// <summary>
        ///     Retrieves all instances of the <see cref="!:CommunicationsModel" /> class.
        /// </summary>
        /// <returns>
        ///     An enumerable collection of <see cref="!:CommunicationsModel" /> instances.
        /// </returns>
        public static IEnumerable<Consensus.Contact.Communications> FetchAll(ConsensusSite site)
        {
            IBusinessProvider provider = site.GetService<IBusinessProvider>();
            IEnumerable<Consensus.Contact.ICommunicationsModel> collection = provider.Contact.Communications.FetchAll();
            return collection.Select(model => new Consensus.Contact.Communications(model));
        }

        /// <summary>
        ///     Retrieves a specific <see cref="!:CommunicationsModel" /> instance.
        /// </summary>
        /// <param name="id">
        ///     The unique value which distinctly identifies the <see cref="!:CommunicationsModel" /> instance to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:CommunicationsModel" /> instance that matches the specified <paramref name="id" />; or null, if no matching instance can be found.
        /// </returns>
        public static Consensus.Contact.Communications FetchById(System.Int64 id)
        {
            ConsensusSite site = ConsensusDomain.Configuration[ConsensusDomain.Configuration.DefaultSite];
            return Communications.FetchById(site,id);
        }

        /// <summary>
        ///     Retrieves a specific <see cref="!:CommunicationsModel" /> instance.
        /// </summary>
        /// <param name="id">
        ///     The unique value which distinctly identifies the <see cref="!:CommunicationsModel" /> instance to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:CommunicationsModel" /> instance that matches the specified <paramref name="id" />; or null, if no matching instance can be found.
        /// </returns>
        public static Consensus.Contact.Communications FetchById(ConsensusSite site, System.Int64 id)
        {
            IBusinessProvider provider = site.GetService<IBusinessProvider>();
            Consensus.Contact.ICommunicationsModel model = provider.Contact.Communications.FetchById(id);
            return model == null ? null : new Consensus.Contact.Communications(model);
        }

        public static System.String GetTableName()
        {
            ConsensusSite site = ConsensusDomain.Configuration[ConsensusDomain.Configuration.DefaultSite];
            return Communications.GetTableName(site);
        }

        public static System.String GetTableName(ConsensusSite site)
        {
            IBusinessProvider provider = site.GetService<IBusinessProvider>();
            return provider.Contact.Communications.GetTableName();
        }

        #endregion
    }
}
