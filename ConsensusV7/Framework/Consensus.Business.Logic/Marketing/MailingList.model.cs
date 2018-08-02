using System;
using System.Collections.Generic;
using System.Linq;

namespace Consensus.Marketing
{
    /// <summary>
    ///     Encapsulates the <see cref="ListRecord" /> with standardised business rules.
    /// </summary>
    public partial class LocalMailingListModel
    {
        /// <summary>
        /// Count of members that are people.
        /// </summary>
        public int TotalPersonCount
        {
            get
            {
                return MailingListMemberList.Count(m => m.Person != null);
            }
        }

        /// <summary>
        ///     Provides denormalisation of the activity data, prior to persistence.
        /// </summary>
        protected internal override void Denormalise()
        {
            base.Denormalise();
            this.Notes = this.NotesHtml.Body.HtmlToText();
        }
    }
}
