using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Linq;

namespace Consensus.Activities
{
    /// <summary>
    ///     Microsoft SQL Server repository collection which pertains to the Activities namespace.
    /// </summary>
    /// <remarks>
    ///     THIS CODE HAS BEEN AUTOMATICALLY GENERATED USING THE CONSENSUS DEVELOPER TOOLS.
    ///     DO NOT EDIT THIS CODE AS ANY CUSTOM MODIFICATIONS WILL BE LOST UPON REGENERATION.
    /// </remarks>
    public partial class SqlServerActivitiesRepositoryCollection : SqlServerRepositoryCollection, IActivitiesRepositoryCollection
    {
        #region fields

        /// <summary>
        ///     The Microsoft SQL Server repository which persists and retrieves instances of the <see cref="ActivityRecord" /> data structure.
        /// </summary>
        private SqlServerActivityRepository _activity;

        /// <summary>
        ///     The Microsoft SQL Server repository which persists and retrieves instances of the <see cref="ActivityXrefRecord" /> data structure.
        /// </summary>
        private SqlServerActivityXrefRepository _activityXref;

        /// <summary>
        ///     The Microsoft SQL Server repository which persists and retrieves instances of the <see cref="ActLinkXrefRecord" /> data structure.
        /// </summary>
        private SqlServerActLinkXrefRepository _actLinkXref;

        /// <summary>
        ///     The Microsoft SQL Server repository which persists and retrieves instances of the <see cref="C4textRecord" /> data structure.
        /// </summary>
        private SqlServerC4textRepository _c4text;

        /// <summary>
        ///     The Microsoft SQL Server repository which persists and retrieves instances of the <see cref="HelpdeskRecord" /> data structure.
        /// </summary>
        private SqlServerHelpdeskRepository _helpdesk;

        /// <summary>
        ///     The Microsoft SQL Server repository which persists and retrieves instances of the <see cref="ComplaintRecord" /> data structure.
        /// </summary>
        private SqlServerComplaintRepository _complaint;

        #endregion

        #region properties

        /// <summary>
        ///     Gets the Microsoft SQL Server repository which persists and retrieves instances of the <see cref="ActivityRecord" /> data structure.
        /// </summary>
        public SqlServerActivityRepository Activity
        {
            get
            {
                SqlServerProvider provider = this.Provider;
                OverrideProvider(typeof(SqlServerActivityRepository), ref provider);
                return SqlServerRepository.Create(provider, ref _activity);
            }
        }

        /// <summary>
        ///     Gets the Microsoft SQL Server repository which persists and retrieves instances of the <see cref="ActivityXrefRecord" /> data structure.
        /// </summary>
        public SqlServerActivityXrefRepository ActivityXref
        {
            get
            {
                SqlServerProvider provider = this.Provider;
                OverrideProvider(typeof(SqlServerActivityXrefRepository), ref provider);
                return SqlServerRepository.Create(provider, ref _activityXref);
            }
        }

        /// <summary>
        ///     Gets the Microsoft SQL Server repository which persists and retrieves instances of the <see cref="ActLinkXrefRecord" /> data structure.
        /// </summary>
        public SqlServerActLinkXrefRepository ActLinkXref
        {
            get
            {
                SqlServerProvider provider = this.Provider;
                OverrideProvider(typeof(SqlServerActLinkXrefRepository), ref provider);
                return SqlServerRepository.Create(provider, ref _actLinkXref);
            }
        }

        /// <summary>
        ///     Gets the Microsoft SQL Server repository which persists and retrieves instances of the <see cref="C4textRecord" /> data structure.
        /// </summary>
        public SqlServerC4textRepository C4text
        {
            get
            {
                SqlServerProvider provider = this.Provider;
                OverrideProvider(typeof(SqlServerC4textRepository), ref provider);
                return SqlServerRepository.Create(provider, ref _c4text);
            }
        }

        /// <summary>
        ///     Gets the Microsoft SQL Server repository which persists and retrieves instances of the <see cref="HelpdeskRecord" /> data structure.
        /// </summary>
        public SqlServerHelpdeskRepository Helpdesk
        {
            get
            {
                SqlServerProvider provider = this.Provider;
                OverrideProvider(typeof(SqlServerHelpdeskRepository), ref provider);
                return SqlServerRepository.Create(provider, ref _helpdesk);
            }
        }

        /// <summary>
        ///     Gets the Microsoft SQL Server repository which persists and retrieves instances of the <see cref="ComplaintRecord" /> data structure.
        /// </summary>
        public SqlServerComplaintRepository Complaint
        {
            get
            {
                SqlServerProvider provider = this.Provider;
                OverrideProvider(typeof(SqlServerComplaintRepository), ref provider);
                return SqlServerRepository.Create(provider, ref _complaint);
            }
        }

        #endregion

        #region methods

        /// <summary>
        ///     Partial method that can be implemented elsewhere in the partial class to allow the provider to be amended for a particular instance.
        /// </summary>
        /// <param name="SqlServerDataRepositoryType">
        ///     The type of the SqlServerDataRepository instance being created.
        /// </param>
        /// <param name="provider">
        ///     The default provider. A new provider may be assigned to this parameter in an implementation, if required.
        /// </param>
        partial void OverrideProvider(Type SqlServerDataRepositoryType, ref SqlServerProvider provider);

        #endregion

        #region implementations

        /// <summary>
        ///     Gets the Microsoft SQL Server repository which persists and retrieves instances of the <see cref="T:Consensus.Activities.ActivityRecord" /> data structure.
        /// </summary>
        Consensus.Activities.IActivityRepository IActivitiesRepositoryCollection.Activity
        {
            get { return this.Activity; }
        }

        /// <summary>
        ///     Gets the Microsoft SQL Server repository which persists and retrieves instances of the <see cref="T:Consensus.Activities.ActivityXrefRecord" /> data structure.
        /// </summary>
        Consensus.Activities.IActivityXrefRepository IActivitiesRepositoryCollection.ActivityXref
        {
            get { return this.ActivityXref; }
        }

        /// <summary>
        ///     Gets the Microsoft SQL Server repository which persists and retrieves instances of the <see cref="T:Consensus.Activities.ActLinkXrefRecord" /> data structure.
        /// </summary>
        Consensus.Activities.IActLinkXrefRepository IActivitiesRepositoryCollection.ActLinkXref
        {
            get { return this.ActLinkXref; }
        }

        /// <summary>
        ///     Gets the Microsoft SQL Server repository which persists and retrieves instances of the <see cref="T:Consensus.Activities.C4textRecord" /> data structure.
        /// </summary>
        Consensus.Activities.IC4textRepository IActivitiesRepositoryCollection.C4text
        {
            get { return this.C4text; }
        }

        /// <summary>
        ///     Gets the Microsoft SQL Server repository which persists and retrieves instances of the <see cref="T:Consensus.Activities.HelpdeskRecord" /> data structure.
        /// </summary>
        Consensus.Activities.IHelpdeskRepository IActivitiesRepositoryCollection.Helpdesk
        {
            get { return this.Helpdesk; }
        }

        /// <summary>
        ///     Gets the Microsoft SQL Server repository which persists and retrieves instances of the <see cref="T:Consensus.Activities.ComplaintRecord" /> data structure.
        /// </summary>
        Consensus.Activities.IComplaintRepository IActivitiesRepositoryCollection.Complaint
        {
            get { return this.Complaint; }
        }

        #endregion
    }
}
