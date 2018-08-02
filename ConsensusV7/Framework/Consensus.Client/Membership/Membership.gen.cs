using System;
using System.Collections.Generic;
using System.Linq;

namespace Consensus.Membership
{
    /// <remarks>
    ///     THIS CODE HAS BEEN AUTOMATICALLY GENERATED USING THE CONSENSUS DEVELOPER TOOLS.
    ///     DO NOT EDIT THIS CODE AS ANY CUSTOM MODIFICATIONS WILL BE LOST UPON REGENERATION.
    /// </remarks>
    public partial class Membership : Proxy<IMembershipModel, String>
    {
        #region fields

        /// <summary>
        ///     The client-consumable proxy instance for the <see cref="CurrentPeriod" /> member.
        /// </summary>
        private Consensus.Membership.MemberPeriod _currentPeriod;

        /// <summary>
        ///     The client-consumable proxy collection for the <see cref="Periods" /> member.
        /// </summary>
        private ProxyCollection<Consensus.Membership.MemberPeriod, Consensus.Membership.IMemberPeriodModel> _periods;

        /// <summary>
        ///     The client-consumable proxy collection for the <see cref="MemberLocations" /> member.
        /// </summary>
        private ProxyCollection<Consensus.Membership.MemberLocation, Consensus.Membership.IMemberLocationModel> _memberLocations;

        #endregion

        #region properties

        /// <summary>
        ///     Gets whether the underlying data has been modified since instantiation.
        /// </summary>
        public System.Boolean IsModified
        {
            get { return this.Model.IsModified; }
        }

        /// <summary>
        ///     Gets the current or latest period for the membership.
        /// </summary>
        public Consensus.Membership.MemberPeriod CurrentPeriod
        {
            get
            {
                if (_currentPeriod == null && this.Model.CurrentPeriod != null)
                    _currentPeriod = new Consensus.Membership.MemberPeriod(this.Model.CurrentPeriod);
                if (_currentPeriod == null)
                    _currentPeriod = Consensus.Membership.MemberPeriod.Create();
                return _currentPeriod;
            }
        }

        /// <summary>
        ///     Gets or sets the value of the "MEM_REF" field.
        /// </summary>
        public System.String Ref
        {
            get { return this.Model.Ref; }
            set { this.Model.Ref = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "MEM_NOTES" field.
        /// </summary>
        public System.String Notes
        {
            get { return this.Model.Notes; }
            set { this.Model.Notes = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "MEM_START" field.
        /// </summary>
        public System.Nullable<System.DateTime> JoinDate
        {
            get { return this.Model.JoinDate; }
            set { this.Model.JoinDate = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "MEM_USERNAME" field.
        /// </summary>
        public System.String Username
        {
            get { return this.Model.Username; }
            set { this.Model.Username = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "MEM_PASSWORD" field.
        /// </summary>
        public System.String Password
        {
            get { return this.Model.Password; }
            set { this.Model.Password = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "MEM_TYPE" field.
        /// </summary>
        public System.String Type
        {
            get { return this.Model.Type; }
            set { this.Model.Type = value; }
        }

        /// <summary>
        ///     Gets the collection of <see cref="!:MemberPeriodModel" /> instances that reference this <see cref="!:MembershipModel" />.
        /// </summary>
        public Collection<Consensus.Membership.MemberPeriod> Periods
        {
            get
            {
                if (_periods == null)
                    _periods = new ProxyCollection<Consensus.Membership.MemberPeriod, Consensus.Membership.IMemberPeriodModel>(this.Model.Periods, model => new Consensus.Membership.MemberPeriod(model));
                return _periods;
            }
        }

        /// <summary>
        ///     Gets the collection of <see cref="!:MemberLocationModel" /> instances that reference this <see cref="!:MembershipModel" />.
        /// </summary>
        public Collection<Consensus.Membership.MemberLocation> MemberLocations
        {
            get
            {
                if (_memberLocations == null)
                    _memberLocations = new ProxyCollection<Consensus.Membership.MemberLocation, Consensus.Membership.IMemberLocationModel>(this.Model.MemberLocations, model => new Consensus.Membership.MemberLocation(model));
                return _memberLocations;
            }
        }

        #endregion

        #region constructors

        /// <summary>
        ///     Initialises a new instance of the client-consumable class.
        /// </summary>
        internal Membership(IMembershipModel model) : base(model)
        {
        }

        #endregion

        #region methods

        /// <summary>
        ///     Creates a new <see cref="!:MembershipModel" /> instance.
        /// </summary>
        /// <returns>
        ///     A newly instantiated <see cref="!:MembershipModel" /> instance.
        /// </returns>
        public static Consensus.Membership.Membership Create()
        {
            ConsensusSite site = ConsensusDomain.Configuration[ConsensusDomain.Configuration.DefaultSite];
            return Membership.Create(site);
        }

        /// <summary>
        ///     Creates a new <see cref="!:MembershipModel" /> instance.
        /// </summary>
        /// <returns>
        ///     A newly instantiated <see cref="!:MembershipModel" /> instance.
        /// </returns>
        public static Consensus.Membership.Membership Create(ConsensusSite site)
        {
            IBusinessProvider provider = site.GetService<IBusinessProvider>();
            Consensus.Membership.IMembershipModel model = provider.Membership.Membership.Create();
            return model == null ? null : new Consensus.Membership.Membership(model);
        }

        /// <summary>
        ///     Retrieves all instances of the <see cref="!:MembershipModel" /> class.
        /// </summary>
        /// <returns>
        ///     An enumerable collection of <see cref="!:MembershipModel" /> instances.
        /// </returns>
        public static IEnumerable<Consensus.Membership.Membership> FetchAll()
        {
            ConsensusSite site = ConsensusDomain.Configuration[ConsensusDomain.Configuration.DefaultSite];
            return Membership.FetchAll(site);
        }

        /// <summary>
        ///     Retrieves all instances of the <see cref="!:MembershipModel" /> class.
        /// </summary>
        /// <returns>
        ///     An enumerable collection of <see cref="!:MembershipModel" /> instances.
        /// </returns>
        public static IEnumerable<Consensus.Membership.Membership> FetchAll(ConsensusSite site)
        {
            IBusinessProvider provider = site.GetService<IBusinessProvider>();
            IEnumerable<Consensus.Membership.IMembershipModel> collection = provider.Membership.Membership.FetchAll();
            return collection.Select(model => new Consensus.Membership.Membership(model));
        }

        /// <summary>
        ///     Retrieves a specific <see cref="!:MembershipModel" /> instance.
        /// </summary>
        /// <param name="id">
        ///     The unique value which distinctly identifies the <see cref="!:MembershipModel" /> instance to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:MembershipModel" /> instance that matches the specified <paramref name="id" />; or null, if no matching instance can be found.
        /// </returns>
        public static Consensus.Membership.Membership FetchById(System.String id)
        {
            ConsensusSite site = ConsensusDomain.Configuration[ConsensusDomain.Configuration.DefaultSite];
            return Membership.FetchById(site,id);
        }

        /// <summary>
        ///     Retrieves a specific <see cref="!:MembershipModel" /> instance.
        /// </summary>
        /// <param name="id">
        ///     The unique value which distinctly identifies the <see cref="!:MembershipModel" /> instance to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:MembershipModel" /> instance that matches the specified <paramref name="id" />; or null, if no matching instance can be found.
        /// </returns>
        public static Consensus.Membership.Membership FetchById(ConsensusSite site, System.String id)
        {
            IBusinessProvider provider = site.GetService<IBusinessProvider>();
            Consensus.Membership.IMembershipModel model = provider.Membership.Membership.FetchById(id);
            return model == null ? null : new Consensus.Membership.Membership(model);
        }

        public static System.String GetTableName()
        {
            ConsensusSite site = ConsensusDomain.Configuration[ConsensusDomain.Configuration.DefaultSite];
            return Membership.GetTableName(site);
        }

        public static System.String GetTableName(ConsensusSite site)
        {
            IBusinessProvider provider = site.GetService<IBusinessProvider>();
            return provider.Membership.Membership.GetTableName();
        }

        #endregion
    }
}
