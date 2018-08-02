using System;
using System.Collections.Generic;
using System.Linq;

namespace Consensus.Membership
{
    /// <summary>
    ///     Encapsulates the <see cref="MembershipRecord" /> with standardised business rules.
    /// </summary>
    /// <remarks>
    ///     THIS CODE HAS BEEN AUTOMATICALLY GENERATED USING THE CONSENSUS DEVELOPER TOOLS.
    ///     DO NOT EDIT THIS CODE AS ANY CUSTOM MODIFICATIONS WILL BE LOST UPON REGENERATION.
    /// </remarks>
    public partial class LocalMembershipModel : LocalModel<MembershipRecord, String>, IMembershipModel
    {
        #region fields

        /// <summary>
        ///     The collection of <see cref="MemberPeriodModel" /> instances that reference this <see cref="MembershipModel" />.
        /// </summary>
        private LocalCollection<LocalMemberPeriodModel, IMemberPeriodModel> _periods;

        /// <summary>
        ///     The collection of <see cref="MemberLocationModel" /> instances that reference this <see cref="MembershipModel" />.
        /// </summary>
        private LocalCollection<LocalMemberLocationModel, IMemberLocationModel> _memberLocations;

        #endregion

        #region properties

        /// <summary>
        ///     Gets the delegated function that is responsible for persisting a new instance of the data structure within the underlying persistence mechanism.
        /// </summary>
        protected override Action<MembershipRecord> DataCreator
        {
            get { return this.Provider.DataProvider.Membership.Membership.Create; }
        }

        /// <summary>
        ///     Gets the delegated function that is responsible for persisting an existing instance of the data structure within the underlying persistence mechanism.
        /// </summary>
        protected override Action<MembershipRecord> DataModifier
        {
            get { return this.Provider.DataProvider.Membership.Membership.Modify; }
        }

        /// <summary>
        ///     Gets the delegated function that is responsible for removing an existing instance of the data structure from the underlying persistence mechanism.
        /// </summary>
        protected override Action<MembershipRecord> DataRemover
        {
            get { return this.Provider.DataProvider.Membership.Membership.RemoveById; }
        }

        /// <summary>
        ///     Gets or sets the value of the "MEM_REF" field.
        /// </summary>
        public String Ref
        {
            get { return this.ModifiedData.Ref; }
            set { this.ModifiedData.Ref = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "MEM_NOTES" field.
        /// </summary>
        public String Notes
        {
            get { return this.ModifiedData.Notes; }
            set { this.ModifiedData.Notes = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "MEM_START" field.
        /// </summary>
        public DateTime? JoinDate
        {
            get { return this.ModifiedData.Start; }
            set { this.ModifiedData.Start = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "MEM_USERNAME" field.
        /// </summary>
        public String Username
        {
            get { return this.ModifiedData.Username; }
            set { this.ModifiedData.Username = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "MEM_PASSWORD" field.
        /// </summary>
        public String Password
        {
            get { return this.ModifiedData.Password; }
            set { this.ModifiedData.Password = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "MEM_TYPE" field.
        /// </summary>
        public String Type
        {
            get { return this.ModifiedData.Type; }
            set { this.ModifiedData.Type = value; }
        }

        /// <summary>
        ///     Gets the collection of <see cref="MemberPeriodModel" /> instances that reference this <see cref="MembershipModel" />.
        /// </summary>
        public LocalCollection<LocalMemberPeriodModel, IMemberPeriodModel> Periods
        {
            get
            {
                if (_periods == null)
                    _periods = new LocalCollection<LocalMemberPeriodModel, IMemberPeriodModel>(this.Provider.Membership.MemberPeriod.FetchAllByMemIdId(this.Id));
                
                return _periods;
            }
        }

        /// <summary>
        ///     Gets the collection of <see cref="MemberLocationModel" /> instances that reference this <see cref="MembershipModel" />.
        /// </summary>
        public LocalCollection<LocalMemberLocationModel, IMemberLocationModel> MemberLocations
        {
            get
            {
                if (_memberLocations == null)
                    _memberLocations = new LocalCollection<LocalMemberLocationModel, IMemberLocationModel>(this.Provider.Membership.MemberLocation.FetchAllByMembershipId(this.Id));
                
                return _memberLocations;
            }
        }

        #endregion

        #region constructors

        /// <summary>
        ///     Initialises a new <see cref="LocalMembershipModel" /> instance.
        /// </summary>
        /// <param name="provider">
        ///     The business provider to which the business model is bound.
        /// </param>
        internal LocalMembershipModel(LocalProvider provider) : base(provider)
        {
        }

        /// <summary>
        ///     Initialises a new <see cref="LocalMembershipModel" /> instance.
        /// </summary>
        /// <param name="provider">
        ///     The business provider to which the business model is bound.
        /// </param>
        /// <param name="record">
        ///     The data record which is encapsulated by the business model.
        /// </param>
        internal LocalMembershipModel(LocalProvider provider, MembershipRecord record) : base(provider, record)
        {
        }

        #endregion

        #region methods

        /// <summary>
        ///     Resolves the dependencies by means of persisting all models that this model is referencing.
        /// </summary>
        protected override void ResolveGeneratedDependency()
        {
            base.ResolveGeneratedDependency();
        }

        /// <summary>
        ///     Resolves the dependent models by means of updating all models that reference this model.
        /// </summary>
        protected override void ResolveGeneratedDependent()
        {
            base.ResolveGeneratedDependent();
            if (_periods != null)
                _periods.Execute(obj => obj.MemIdId = this.Id).Execute(obj => obj.Save());
            if (_memberLocations != null)
                _memberLocations.Execute(obj => obj.MembershipId = this.Id).Execute(obj => obj.Save());
        }

        #endregion

        #region implementations

        /// <summary>
        ///     Gets whether the underlying data has been modified since instantiation.
        /// </summary>
        System.Boolean IMembershipModel.IsModified
        {
            get { return this.IsModified; }
        }

        /// <summary>
        ///     Gets the current or latest period for the membership.
        /// </summary>
        Consensus.Membership.IMemberPeriodModel IMembershipModel.CurrentPeriod
        {
            get { return this.CurrentPeriod; }
        }

        /// <summary>
        ///     Gets or sets the value of the "MEM_REF" field.
        /// </summary>
        System.String IMembershipModel.Ref
        {
            get { return this.Ref; }
            set { this.Ref = (System.String)value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "MEM_NOTES" field.
        /// </summary>
        System.String IMembershipModel.Notes
        {
            get { return this.Notes; }
            set { this.Notes = (System.String)value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "MEM_START" field.
        /// </summary>
        System.Nullable<System.DateTime> IMembershipModel.JoinDate
        {
            get { return this.JoinDate; }
            set { this.JoinDate = (System.Nullable<System.DateTime>)value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "MEM_USERNAME" field.
        /// </summary>
        System.String IMembershipModel.Username
        {
            get { return this.Username; }
            set { this.Username = (System.String)value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "MEM_PASSWORD" field.
        /// </summary>
        System.String IMembershipModel.Password
        {
            get { return this.Password; }
            set { this.Password = (System.String)value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "MEM_TYPE" field.
        /// </summary>
        System.String IMembershipModel.Type
        {
            get { return this.Type; }
            set { this.Type = (System.String)value; }
        }

        /// <summary>
        ///     Gets the collection of <see cref="!:MemberPeriodModel" /> instances that reference this <see cref="!:MembershipModel" />.
        /// </summary>
        Consensus.Collection<Consensus.Membership.IMemberPeriodModel> IMembershipModel.Periods
        {
            get { return this.Periods; }
        }

        /// <summary>
        ///     Gets the collection of <see cref="!:MemberLocationModel" /> instances that reference this <see cref="!:MembershipModel" />.
        /// </summary>
        Consensus.Collection<Consensus.Membership.IMemberLocationModel> IMembershipModel.MemberLocations
        {
            get { return this.MemberLocations; }
        }

        #endregion
    }
}
