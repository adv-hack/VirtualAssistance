using System;
using System.Collections.Generic;
using System.Linq;

namespace Consensus.Membership
{
    /// <summary>
    ///     Encapsulates the <see cref="MembershipRecord" /> with standardised business rules.
    /// </summary>
    public partial class LocalMembershipModel
    {
        #region fields

        /// <summary>
        ///    The current or latest period for the membership.
        /// </summary>
        private LocalMemberPeriodModel _currentPeriod;

        #endregion

        #region properties

        /// <summary>
        ///     Gets whether the underlying data has been modified since instantiation.
        /// </summary>
        public override Boolean IsModified
        {
            get { return base.IsModified || (_currentPeriod != null && _currentPeriod.IsModified); }
        }

        /// <summary>
        ///    Gets the current or latest period for the membership.
        /// </summary>
        public LocalMemberPeriodModel CurrentPeriod
        {
            get
            {
                if (_currentPeriod == null)
                    _currentPeriod = this.Periods.Where(period => period.StatusNumber >= 20 && period.StatusNumber <= 29).OrderBy(period => period.Start).LastOrDefault();
                if (_currentPeriod == null)
                    _currentPeriod = this.Periods.OrderBy(period => period.Start).LastOrDefault();
                if (_currentPeriod == null)
                    _currentPeriod = new LocalMemberPeriodModel(this.Provider);

                return _currentPeriod;
            }
        }

        #endregion

        #region methods

        /// <summary>
        ///     Resolves the dependent models by means of updating all models that reference this model.
        /// </summary>
        protected override void ResolveDependent()
        {
 	        base.ResolveDependent();
            if (_currentPeriod != null && _currentPeriod.IsModified)
            {
                _currentPeriod.MemIdId = this.Id;
                _currentPeriod.Save();
            }
        }

        #endregion
    }
}
