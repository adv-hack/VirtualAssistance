using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Linq;

namespace Consensus.Activities
{
    /// <summary>
    ///     The repository collection which pertains to the Activities namespace.
    /// </summary>
    /// <remarks>
    ///     THIS CODE HAS BEEN AUTOMATICALLY GENERATED USING THE CONSENSUS DEVELOPER TOOLS.
    ///     DO NOT EDIT THIS CODE AS ANY CUSTOM MODIFICATIONS WILL BE LOST UPON REGENERATION.
    /// </remarks>
    public interface IActivitiesRepositoryCollection : IRepositoryCollection
    {
        /// <summary>
        ///     Gets the Microsoft SQL Server repository which persists and retrieves instances of the <see cref="T:Consensus.Activities.ActivityRecord" /> data structure.
        /// </summary>
        Consensus.Activities.IActivityRepository Activity
        {
            get;
        }

        /// <summary>
        ///     Gets the Microsoft SQL Server repository which persists and retrieves instances of the <see cref="T:Consensus.Activities.ActivityXrefRecord" /> data structure.
        /// </summary>
        Consensus.Activities.IActivityXrefRepository ActivityXref
        {
            get;
        }

        /// <summary>
        ///     Gets the Microsoft SQL Server repository which persists and retrieves instances of the <see cref="T:Consensus.Activities.ActLinkXrefRecord" /> data structure.
        /// </summary>
        Consensus.Activities.IActLinkXrefRepository ActLinkXref
        {
            get;
        }

        /// <summary>
        ///     Gets the Microsoft SQL Server repository which persists and retrieves instances of the <see cref="T:Consensus.Activities.C4textRecord" /> data structure.
        /// </summary>
        Consensus.Activities.IC4textRepository C4text
        {
            get;
        }

        /// <summary>
        ///     Gets the Microsoft SQL Server repository which persists and retrieves instances of the <see cref="T:Consensus.Activities.HelpdeskRecord" /> data structure.
        /// </summary>
        Consensus.Activities.IHelpdeskRepository Helpdesk
        {
            get;
        }

        /// <summary>
        ///     Gets the Microsoft SQL Server repository which persists and retrieves instances of the <see cref="T:Consensus.Activities.ComplaintRecord" /> data structure.
        /// </summary>
        Consensus.Activities.IComplaintRepository Complaint
        {
            get;
        }
    }
}
