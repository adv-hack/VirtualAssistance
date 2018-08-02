using System;
using System.Collections.Generic;
using System.Linq;

namespace Consensus.Learning
{
    /// <summary>
    ///     Encapsulates the <see cref="CourseRecord" /> with standardised business rules.
    /// </summary>
    public partial class LocalEventModel
    {
		private LocalSessionModel _mainSession;


        /// <summary>
        ///    Gets or sets the main session
        /// </summary>
        public LocalSessionModel MainSession
        {
            get
            {
                // Get the main session
                if (_mainSession == null && this.SessionXrefEvent.Count > 0)
                    _mainSession = this.SessionXrefEvent.Where(SessionXrefEvent => SessionXrefEvent.MainSession == 1).FirstOrDefault().Session;

                return _mainSession;
            }
        }

        #region methods
        /// <summary>
        ///     Provides denormalisation of the activity data, prior to persistence.
        /// </summary>
        protected internal override void Denormalise()
        {
            base.Denormalise();

            if (_mainSession != null && (_mainSession.IsModified || _mainSession.SessionXrefMaster.IsModified))
            {
                _mainSession.Denormalise();
                _mainSession.Save();
            }

        }
        #endregion

    }
}
