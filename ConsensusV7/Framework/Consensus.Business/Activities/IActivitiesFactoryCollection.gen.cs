using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
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
    public interface IActivitiesFactoryCollection : IFactoryCollection
    {
        /// <summary>
        ///     Gets the locally executable factory which is responsible for instantiating <see cref="!:ActivityModel" /> objects.
        /// </summary>
        Consensus.Activities.IActivityFactory Activity
        {
            get;
        }

        /// <summary>
        ///     Gets the locally executable factory which is responsible for instantiating <see cref="!:ActivityXrefModel" /> objects.
        /// </summary>
        Consensus.Activities.IActivityXrefFactory ActivityXref
        {
            get;
        }

        /// <summary>
        ///     Gets the locally executable factory which is responsible for instantiating <see cref="!:ActLinkXrefModel" /> objects.
        /// </summary>
        Consensus.Activities.IActLinkXrefFactory ActLinkXref
        {
            get;
        }

        /// <summary>
        ///     Gets the locally executable factory which is responsible for instantiating <see cref="!:C4textModel" /> objects.
        /// </summary>
        Consensus.Activities.IC4textFactory C4text
        {
            get;
        }

        /// <summary>
        ///     Gets the locally executable factory which is responsible for instantiating <see cref="!:HelpdeskModel" /> objects.
        /// </summary>
        Consensus.Activities.IHelpdeskFactory Helpdesk
        {
            get;
        }

        /// <summary>
        ///     Gets the locally executable factory which is responsible for instantiating <see cref="!:ComplaintModel" /> objects.
        /// </summary>
        Consensus.Activities.IComplaintFactory Complaint
        {
            get;
        }
    }
}
