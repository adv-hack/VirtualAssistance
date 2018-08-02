using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.UI.HtmlControls;
using Consensus.Common;

namespace Consensus.Document
{
    /// <summary>
    ///     Encapsulates the <see cref="ArticleRecord" /> with standardised business rules.
    /// </summary>
    public partial class LocalArticleModel
    {
        /// <summary>
        ///     Provides denormalisation of the activity data, prior to persistence.
        /// </summary>
        protected internal override void Denormalise()
        {
            base.Denormalise();
            if (this.NotesHtml != null)
                this.Notes = this.NotesHtml.HtmlToText();
            if (this.SummaryHtml != null)
                this.Summary = this.SummaryHtml.HtmlToText();
        }
    }
}
