using System;
using System.Collections.Generic;
using System.Linq;

namespace Consensus.Activities
{
    /// <summary>
    ///     Represents a collection of factory instances which are responsible for the instantiation of the business models in the Activities namespace.
    /// </summary>
    /// <remarks>
    ///     THIS CODE HAS BEEN AUTOMATICALLY GENERATED USING THE CONSENSUS DEVELOPER TOOLS.
    ///     DO NOT EDIT THIS CODE AS ANY CUSTOM MODIFICATIONS WILL BE LOST UPON REGENERATION.
    /// </remarks>
    public partial class LocalActivitiesFactoryCollection : LocalFactoryCollection, IActivitiesFactoryCollection
    {
        #region fields

        /// <summary>
        ///     The locally executable factory which is responsible for instantiating <see cref="ActivityModel" /> objects.
        /// </summary>
        private LocalActivityFactory _activity;

        /// <summary>
        ///     The locally executable factory which is responsible for instantiating <see cref="ActivityXrefModel" /> objects.
        /// </summary>
        private LocalActivityXrefFactory _activityXref;

        /// <summary>
        ///     The locally executable factory which is responsible for instantiating <see cref="ActLinkXrefModel" /> objects.
        /// </summary>
        private LocalActLinkXrefFactory _actLinkXref;

        /// <summary>
        ///     The locally executable factory which is responsible for instantiating <see cref="C4textModel" /> objects.
        /// </summary>
        private LocalC4textFactory _c4text;

        /// <summary>
        ///     The locally executable factory which is responsible for instantiating <see cref="HelpdeskModel" /> objects.
        /// </summary>
        private LocalHelpdeskFactory _helpdesk;

        /// <summary>
        ///     The locally executable factory which is responsible for instantiating <see cref="ComplaintModel" /> objects.
        /// </summary>
        private LocalComplaintFactory _complaint;

        #endregion

        #region properties

        /// <summary>
        ///     Gets the locally executable factory which is responsible for instantiating <see cref="ActivityModel" /> objects.
        /// </summary>
        public LocalActivityFactory Activity
        {
            get { return LocalFactory.Create(this.Provider, ref _activity); }
        }

        /// <summary>
        ///     Gets the locally executable factory which is responsible for instantiating <see cref="ActivityXrefModel" /> objects.
        /// </summary>
        public LocalActivityXrefFactory ActivityXref
        {
            get { return LocalFactory.Create(this.Provider, ref _activityXref); }
        }

        /// <summary>
        ///     Gets the locally executable factory which is responsible for instantiating <see cref="ActLinkXrefModel" /> objects.
        /// </summary>
        public LocalActLinkXrefFactory ActLinkXref
        {
            get { return LocalFactory.Create(this.Provider, ref _actLinkXref); }
        }

        /// <summary>
        ///     Gets the locally executable factory which is responsible for instantiating <see cref="C4textModel" /> objects.
        /// </summary>
        public LocalC4textFactory C4text
        {
            get { return LocalFactory.Create(this.Provider, ref _c4text); }
        }

        /// <summary>
        ///     Gets the locally executable factory which is responsible for instantiating <see cref="HelpdeskModel" /> objects.
        /// </summary>
        public LocalHelpdeskFactory Helpdesk
        {
            get { return LocalFactory.Create(this.Provider, ref _helpdesk); }
        }

        /// <summary>
        ///     Gets the locally executable factory which is responsible for instantiating <see cref="ComplaintModel" /> objects.
        /// </summary>
        public LocalComplaintFactory Complaint
        {
            get { return LocalFactory.Create(this.Provider, ref _complaint); }
        }

        #endregion

        #region implementations

        /// <summary>
        ///     Gets the locally executable factory which is responsible for instantiating <see cref="!:ActivityModel" /> objects.
        /// </summary>
        Consensus.Activities.IActivityFactory IActivitiesFactoryCollection.Activity
        {
            get { return this.Activity; }
        }

        /// <summary>
        ///     Gets the locally executable factory which is responsible for instantiating <see cref="!:ActivityXrefModel" /> objects.
        /// </summary>
        Consensus.Activities.IActivityXrefFactory IActivitiesFactoryCollection.ActivityXref
        {
            get { return this.ActivityXref; }
        }

        /// <summary>
        ///     Gets the locally executable factory which is responsible for instantiating <see cref="!:ActLinkXrefModel" /> objects.
        /// </summary>
        Consensus.Activities.IActLinkXrefFactory IActivitiesFactoryCollection.ActLinkXref
        {
            get { return this.ActLinkXref; }
        }

        /// <summary>
        ///     Gets the locally executable factory which is responsible for instantiating <see cref="!:C4textModel" /> objects.
        /// </summary>
        Consensus.Activities.IC4textFactory IActivitiesFactoryCollection.C4text
        {
            get { return this.C4text; }
        }

        /// <summary>
        ///     Gets the locally executable factory which is responsible for instantiating <see cref="!:HelpdeskModel" /> objects.
        /// </summary>
        Consensus.Activities.IHelpdeskFactory IActivitiesFactoryCollection.Helpdesk
        {
            get { return this.Helpdesk; }
        }

        /// <summary>
        ///     Gets the locally executable factory which is responsible for instantiating <see cref="!:ComplaintModel" /> objects.
        /// </summary>
        Consensus.Activities.IComplaintFactory IActivitiesFactoryCollection.Complaint
        {
            get { return this.Complaint; }
        }

        #endregion
    }
}
