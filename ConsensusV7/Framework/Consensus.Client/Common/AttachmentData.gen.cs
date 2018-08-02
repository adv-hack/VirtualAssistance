using System;
using System.Collections.Generic;
using System.Linq;

namespace Consensus.Common
{
    /// <remarks>
    ///     THIS CODE HAS BEEN AUTOMATICALLY GENERATED USING THE CONSENSUS DEVELOPER TOOLS.
    ///     DO NOT EDIT THIS CODE AS ANY CUSTOM MODIFICATIONS WILL BE LOST UPON REGENERATION.
    /// </remarks>
    public partial class AttachmentData : Proxy<IAttachmentDataModel, Int32>
    {
        #region fields

        /// <summary>
        ///     The client-consumable proxy instance for the <see cref="AttId" /> member.
        /// </summary>
        private Consensus.Common.Attachment _attId;

        #endregion

        #region properties

        /// <summary>
        ///     Gets the The value of the "ATTD_ATT_ID" field.
        /// </summary>
        public Consensus.Common.Attachment AttId
        {
            get
            {
                if (_attId == null && this.Model.AttId != null)
                    _attId = new Consensus.Common.Attachment(this.Model.AttId);
                if (_attId == null)
                    _attId = Consensus.Common.Attachment.Create();
                return _attId;
            }
        }

        /// <summary>
        ///     Gets or sets the unique code for the value of the "ATTD_ATT_ID" field.
        /// </summary>
        public System.String AttIdId
        {
            get { return this.Model.AttIdId; }
            set { this.Model.AttIdId = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "ATTD_VERSION_NO" field.
        /// </summary>
        public System.Nullable<System.Double> VersionNo
        {
            get { return this.Model.VersionNo; }
            set { this.Model.VersionNo = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "ATTD_BINARY" field.
        /// </summary>
        public System.Byte[] Binary
        {
            get { return this.Model.Binary; }
            set { this.Model.Binary = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "ATTD_TEXT" field.
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
        internal AttachmentData(IAttachmentDataModel model) : base(model)
        {
        }

        #endregion

        #region methods

        public void Save()
        {
            this.Model.Save();
        }

        public void Delete()
        {
            this.Model.Delete();
        }

        /// <summary>
        ///     Creates a new <see cref="!:AttachmentDataModel" /> instance.
        /// </summary>
        /// <returns>
        ///     A newly instantiated <see cref="!:AttachmentDataModel" /> instance.
        /// </returns>
        public static Consensus.Common.AttachmentData Create()
        {
            ConsensusSite site = ConsensusDomain.Configuration[ConsensusDomain.Configuration.DefaultSite];
            return AttachmentData.Create(site);
        }

        /// <summary>
        ///     Creates a new <see cref="!:AttachmentDataModel" /> instance.
        /// </summary>
        /// <returns>
        ///     A newly instantiated <see cref="!:AttachmentDataModel" /> instance.
        /// </returns>
        public static Consensus.Common.AttachmentData Create(ConsensusSite site)
        {
            IBusinessProvider provider = site.GetService<IBusinessProvider>();
            Consensus.Common.IAttachmentDataModel model = provider.Common.AttachmentData.Create();
            return model == null ? null : new Consensus.Common.AttachmentData(model);
        }

        /// <summary>
        ///     Retrieves all instances of the <see cref="!:AttachmentDataModel" /> class.
        /// </summary>
        /// <returns>
        ///     An enumerable collection of <see cref="!:AttachmentDataModel" /> instances.
        /// </returns>
        public static IEnumerable<Consensus.Common.AttachmentData> FetchAll()
        {
            ConsensusSite site = ConsensusDomain.Configuration[ConsensusDomain.Configuration.DefaultSite];
            return AttachmentData.FetchAll(site);
        }

        /// <summary>
        ///     Retrieves all instances of the <see cref="!:AttachmentDataModel" /> class.
        /// </summary>
        /// <returns>
        ///     An enumerable collection of <see cref="!:AttachmentDataModel" /> instances.
        /// </returns>
        public static IEnumerable<Consensus.Common.AttachmentData> FetchAll(ConsensusSite site)
        {
            IBusinessProvider provider = site.GetService<IBusinessProvider>();
            IEnumerable<Consensus.Common.IAttachmentDataModel> collection = provider.Common.AttachmentData.FetchAll();
            return collection.Select(model => new Consensus.Common.AttachmentData(model));
        }

        /// <summary>
        ///     Retrieves a specific <see cref="!:AttachmentDataModel" /> instance.
        /// </summary>
        /// <param name="id">
        ///     The unique value which distinctly identifies the <see cref="!:AttachmentDataModel" /> instance to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:AttachmentDataModel" /> instance that matches the specified <paramref name="id" />; or null, if no matching instance can be found.
        /// </returns>
        public static Consensus.Common.AttachmentData FetchById(System.Int32 id)
        {
            ConsensusSite site = ConsensusDomain.Configuration[ConsensusDomain.Configuration.DefaultSite];
            return AttachmentData.FetchById(site,id);
        }

        /// <summary>
        ///     Retrieves a specific <see cref="!:AttachmentDataModel" /> instance.
        /// </summary>
        /// <param name="id">
        ///     The unique value which distinctly identifies the <see cref="!:AttachmentDataModel" /> instance to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:AttachmentDataModel" /> instance that matches the specified <paramref name="id" />; or null, if no matching instance can be found.
        /// </returns>
        public static Consensus.Common.AttachmentData FetchById(ConsensusSite site, System.Int32 id)
        {
            IBusinessProvider provider = site.GetService<IBusinessProvider>();
            Consensus.Common.IAttachmentDataModel model = provider.Common.AttachmentData.FetchById(id);
            return model == null ? null : new Consensus.Common.AttachmentData(model);
        }

        public static System.String GetTableName()
        {
            ConsensusSite site = ConsensusDomain.Configuration[ConsensusDomain.Configuration.DefaultSite];
            return AttachmentData.GetTableName(site);
        }

        public static System.String GetTableName(ConsensusSite site)
        {
            IBusinessProvider provider = site.GetService<IBusinessProvider>();
            return provider.Common.AttachmentData.GetTableName();
        }

        /// <summary>
        ///     Retrieves a collection of <see cref="!:AttachmentDataModel" /> instances.
        /// </summary>
        /// <param name="attIdId">
        ///     The value which identifies the <see cref="!:AttachmentDataModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:AttachmentDataModel" /> instances that match the specified <paramref name="attIdId" />.
        /// </returns>
        public static IEnumerable<Consensus.Common.AttachmentData> FetchAllByAttIdId(System.String attIdId)
        {
            ConsensusSite site = ConsensusDomain.Configuration[ConsensusDomain.Configuration.DefaultSite];
            return AttachmentData.FetchAllByAttIdId(site,attIdId);
        }

        /// <summary>
        ///     Retrieves a collection of <see cref="!:AttachmentDataModel" /> instances.
        /// </summary>
        /// <param name="attIdId">
        ///     The value which identifies the <see cref="!:AttachmentDataModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:AttachmentDataModel" /> instances that match the specified <paramref name="attIdId" />.
        /// </returns>
        public static IEnumerable<Consensus.Common.AttachmentData> FetchAllByAttIdId(ConsensusSite site, System.String attIdId)
        {
            IBusinessProvider provider = site.GetService<IBusinessProvider>();
            IEnumerable<Consensus.Common.IAttachmentDataModel> collection = provider.Common.AttachmentData.FetchAllByAttIdId(attIdId);
            return collection.Select(model => new Consensus.Common.AttachmentData(model));
        }

        #endregion
    }
}
