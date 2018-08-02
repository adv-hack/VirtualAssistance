using System;
using System.Collections.Generic;
using System.Linq;
using Consensus.Contact;

namespace Consensus.Marketing
{
    /// <remarks>
    ///     THIS CODE HAS BEEN AUTOMATICALLY GENERATED USING THE CONSENSUS DEVELOPER TOOLS.
    ///     DO NOT EDIT THIS CODE AS ANY CUSTOM MODIFICATIONS WILL BE LOST UPON REGENERATION.
    /// </remarks>
    public partial class SaqStep : Proxy<ISaqStepModel, Int64>
    {
        #region fields

        /// <summary>
        ///     The client-consumable proxy instance for the <see cref="OwnerRole" /> member.
        /// </summary>
        private Consensus.Contact.Role _ownerRole;

        /// <summary>
        ///     The client-consumable proxy collection for the <see cref="SaqParameterStep" /> member.
        /// </summary>
        private ProxyCollection<Consensus.Marketing.SaqParameter, Consensus.Marketing.ISaqParameterModel> _saqParameterStep;

        /// <summary>
        ///     The client-consumable proxy collection for the <see cref="SaqQueryStepStep" /> member.
        /// </summary>
        private ProxyCollection<Consensus.Marketing.SaqQueryStep, Consensus.Marketing.ISaqQueryStepModel> _saqQueryStepStep;

        #endregion

        #region properties

        /// <summary>
        ///     Gets the The value of the "STEP_PROLE_ID" field.
        /// </summary>
        public Consensus.Contact.Role OwnerRole
        {
            get
            {
                if (_ownerRole == null && this.Model.OwnerRole != null)
                    _ownerRole = new Consensus.Contact.Role(this.Model.OwnerRole);
                if (_ownerRole == null)
                    _ownerRole = Consensus.Contact.Role.Create();
                return _ownerRole;
            }
        }

        /// <summary>
        ///     Gets or sets the unique code for the value of the "STEP_PROLE_ID" field.
        /// </summary>
        public System.String OwnerRoleId
        {
            get { return this.Model.OwnerRoleId; }
            set { this.Model.OwnerRoleId = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "STEP_NAME" field.
        /// </summary>
        public System.String Name
        {
            get { return this.Model.Name; }
            set { this.Model.Name = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "STEP_DESC" field.
        /// </summary>
        public System.String Desc
        {
            get { return this.Model.Desc; }
            set { this.Model.Desc = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "STEP_RESULT_SIZE_OPT" field.
        /// </summary>
        public System.Byte ResultSizeOpt
        {
            get { return this.Model.ResultSizeOpt; }
            set { this.Model.ResultSizeOpt = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "STEP_RESULT_SIZE" field.
        /// </summary>
        public System.Int64 ResultSize
        {
            get { return this.Model.ResultSize; }
            set { this.Model.ResultSize = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "STEP_IN_USE" field.
        /// </summary>
        public System.Byte InUse
        {
            get { return this.Model.InUse; }
            set { this.Model.InUse = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "STEP_ORG_ONLY" field.
        /// </summary>
        public System.Byte OrgOnly
        {
            get { return this.Model.OrgOnly; }
            set { this.Model.OrgOnly = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "STEP_LOCKED" field.
        /// </summary>
        public System.Byte Locked
        {
            get { return this.Model.Locked; }
            set { this.Model.Locked = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "STEP_BOOK_ONLY" field.
        /// </summary>
        public System.Byte BookOnly
        {
            get { return this.Model.BookOnly; }
            set { this.Model.BookOnly = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "STEP_LINK_DEFAULT" field.
        /// </summary>
        public System.String LinkDefault
        {
            get { return this.Model.LinkDefault; }
            set { this.Model.LinkDefault = value; }
        }

        /// <summary>
        ///     Gets the collection of <see cref="!:SaqParameterModel" /> instances that reference this <see cref="!:SaqStepModel" />.
        /// </summary>
        public Collection<Consensus.Marketing.SaqParameter> SaqParameterStep
        {
            get
            {
                if (_saqParameterStep == null)
                    _saqParameterStep = new ProxyCollection<Consensus.Marketing.SaqParameter, Consensus.Marketing.ISaqParameterModel>(this.Model.SaqParameterStep, model => new Consensus.Marketing.SaqParameter(model));
                return _saqParameterStep;
            }
        }

        /// <summary>
        ///     Gets the collection of <see cref="!:SaqQueryStepModel" /> instances that reference this <see cref="!:SaqStepModel" />.
        /// </summary>
        public Collection<Consensus.Marketing.SaqQueryStep> SaqQueryStepStep
        {
            get
            {
                if (_saqQueryStepStep == null)
                    _saqQueryStepStep = new ProxyCollection<Consensus.Marketing.SaqQueryStep, Consensus.Marketing.ISaqQueryStepModel>(this.Model.SaqQueryStepStep, model => new Consensus.Marketing.SaqQueryStep(model));
                return _saqQueryStepStep;
            }
        }

        #endregion

        #region constructors

        /// <summary>
        ///     Initialises a new instance of the client-consumable class.
        /// </summary>
        internal SaqStep(ISaqStepModel model) : base(model)
        {
        }

        #endregion

        #region methods

        /// <summary>
        ///     Creates a new <see cref="!:SaqStepModel" /> instance.
        /// </summary>
        /// <returns>
        ///     A newly instantiated <see cref="!:SaqStepModel" /> instance.
        /// </returns>
        public static Consensus.Marketing.SaqStep Create()
        {
            ConsensusSite site = ConsensusDomain.Configuration[ConsensusDomain.Configuration.DefaultSite];
            return SaqStep.Create(site);
        }

        /// <summary>
        ///     Creates a new <see cref="!:SaqStepModel" /> instance.
        /// </summary>
        /// <returns>
        ///     A newly instantiated <see cref="!:SaqStepModel" /> instance.
        /// </returns>
        public static Consensus.Marketing.SaqStep Create(ConsensusSite site)
        {
            IBusinessProvider provider = site.GetService<IBusinessProvider>();
            Consensus.Marketing.ISaqStepModel model = provider.Marketing.SaqStep.Create();
            return model == null ? null : new Consensus.Marketing.SaqStep(model);
        }

        /// <summary>
        ///     Retrieves all instances of the <see cref="!:SaqStepModel" /> class.
        /// </summary>
        /// <returns>
        ///     An enumerable collection of <see cref="!:SaqStepModel" /> instances.
        /// </returns>
        public static IEnumerable<Consensus.Marketing.SaqStep> FetchAll()
        {
            ConsensusSite site = ConsensusDomain.Configuration[ConsensusDomain.Configuration.DefaultSite];
            return SaqStep.FetchAll(site);
        }

        /// <summary>
        ///     Retrieves all instances of the <see cref="!:SaqStepModel" /> class.
        /// </summary>
        /// <returns>
        ///     An enumerable collection of <see cref="!:SaqStepModel" /> instances.
        /// </returns>
        public static IEnumerable<Consensus.Marketing.SaqStep> FetchAll(ConsensusSite site)
        {
            IBusinessProvider provider = site.GetService<IBusinessProvider>();
            IEnumerable<Consensus.Marketing.ISaqStepModel> collection = provider.Marketing.SaqStep.FetchAll();
            return collection.Select(model => new Consensus.Marketing.SaqStep(model));
        }

        /// <summary>
        ///     Retrieves a specific <see cref="!:SaqStepModel" /> instance.
        /// </summary>
        /// <param name="id">
        ///     The unique value which distinctly identifies the <see cref="!:SaqStepModel" /> instance to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:SaqStepModel" /> instance that matches the specified <paramref name="id" />; or null, if no matching instance can be found.
        /// </returns>
        public static Consensus.Marketing.SaqStep FetchById(System.Int64 id)
        {
            ConsensusSite site = ConsensusDomain.Configuration[ConsensusDomain.Configuration.DefaultSite];
            return SaqStep.FetchById(site,id);
        }

        /// <summary>
        ///     Retrieves a specific <see cref="!:SaqStepModel" /> instance.
        /// </summary>
        /// <param name="id">
        ///     The unique value which distinctly identifies the <see cref="!:SaqStepModel" /> instance to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:SaqStepModel" /> instance that matches the specified <paramref name="id" />; or null, if no matching instance can be found.
        /// </returns>
        public static Consensus.Marketing.SaqStep FetchById(ConsensusSite site, System.Int64 id)
        {
            IBusinessProvider provider = site.GetService<IBusinessProvider>();
            Consensus.Marketing.ISaqStepModel model = provider.Marketing.SaqStep.FetchById(id);
            return model == null ? null : new Consensus.Marketing.SaqStep(model);
        }

        public static System.String GetTableName()
        {
            ConsensusSite site = ConsensusDomain.Configuration[ConsensusDomain.Configuration.DefaultSite];
            return SaqStep.GetTableName(site);
        }

        public static System.String GetTableName(ConsensusSite site)
        {
            IBusinessProvider provider = site.GetService<IBusinessProvider>();
            return provider.Marketing.SaqStep.GetTableName();
        }

        /// <summary>
        ///     Retrieves a collection of <see cref="!:SaqStepModel" /> instances.
        /// </summary>
        /// <param name="ownerRoleId">
        ///     The value which identifies the <see cref="!:SaqStepModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:SaqStepModel" /> instances that match the specified <paramref name="ownerRoleId" />.
        /// </returns>
        public static IEnumerable<Consensus.Marketing.SaqStep> FetchAllByOwnerRoleId(System.String ownerRoleId)
        {
            ConsensusSite site = ConsensusDomain.Configuration[ConsensusDomain.Configuration.DefaultSite];
            return SaqStep.FetchAllByOwnerRoleId(site,ownerRoleId);
        }

        /// <summary>
        ///     Retrieves a collection of <see cref="!:SaqStepModel" /> instances.
        /// </summary>
        /// <param name="ownerRoleId">
        ///     The value which identifies the <see cref="!:SaqStepModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:SaqStepModel" /> instances that match the specified <paramref name="ownerRoleId" />.
        /// </returns>
        public static IEnumerable<Consensus.Marketing.SaqStep> FetchAllByOwnerRoleId(ConsensusSite site, System.String ownerRoleId)
        {
            IBusinessProvider provider = site.GetService<IBusinessProvider>();
            IEnumerable<Consensus.Marketing.ISaqStepModel> collection = provider.Marketing.SaqStep.FetchAllByOwnerRoleId(ownerRoleId);
            return collection.Select(model => new Consensus.Marketing.SaqStep(model));
        }

        #endregion
    }
}
