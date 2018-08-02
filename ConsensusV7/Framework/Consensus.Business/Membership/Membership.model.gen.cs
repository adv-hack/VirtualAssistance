using System;
using System.Collections.Generic;
using System.Linq;

namespace Consensus.Membership
{
    /// <summary>
    ///     Encapsulates the <see cref="MembershipRecord" /> data structure.
    /// </summary>
    /// <remarks>
    ///     THIS CODE HAS BEEN AUTOMATICALLY GENERATED USING THE CONSENSUS DEVELOPER TOOLS.
    ///     DO NOT EDIT THIS CODE AS ANY CUSTOM MODIFICATIONS WILL BE LOST UPON REGENERATION.
    /// </remarks>
    public interface IMembershipModel : IModel<String>
    {
        /// <summary>
        ///     Gets whether the underlying data has been modified since instantiation.
        /// </summary>
        System.Boolean IsModified
        {
            get;
        }

        /// <summary>
        ///     Gets the current or latest period for the membership.
        /// </summary>
        Consensus.Membership.IMemberPeriodModel CurrentPeriod
        {
            get;
        }

        /// <summary>
        ///     Gets or sets the value of the "MEM_REF" field.
        /// </summary>
        System.String Ref
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets or sets the value of the "MEM_NOTES" field.
        /// </summary>
        System.String Notes
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets or sets the value of the "MEM_START" field.
        /// </summary>
        System.Nullable<System.DateTime> JoinDate
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets or sets the value of the "MEM_USERNAME" field.
        /// </summary>
        System.String Username
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets or sets the value of the "MEM_PASSWORD" field.
        /// </summary>
        System.String Password
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets or sets the value of the "MEM_TYPE" field.
        /// </summary>
        System.String Type
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets the collection of <see cref="!:MemberPeriodModel" /> instances that reference this <see cref="!:MembershipModel" />.
        /// </summary>
        Consensus.Collection<Consensus.Membership.IMemberPeriodModel> Periods
        {
            get;
        }

        /// <summary>
        ///     Gets the collection of <see cref="!:MemberLocationModel" /> instances that reference this <see cref="!:MembershipModel" />.
        /// </summary>
        Consensus.Collection<Consensus.Membership.IMemberLocationModel> MemberLocations
        {
            get;
        }
    }
}
