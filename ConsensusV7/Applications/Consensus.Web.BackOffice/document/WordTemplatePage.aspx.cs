using Consensus.Document;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Consensus.Web.BackOffice.document
{
    public partial class WordTemplatePage : BaseStandardPage<LetterTemplate, String>
    {
        #region properties

        /// <summary>
        ///     Gets the text displayed within the header of the page.
        /// </summary>
        public override String DefaultTitle
        {
            get { return "Word Template - " + this.Data.Name; }
        }

        /// <summary>
        ///     Gets the icon displayed within the header of the page.
        /// </summary>
        public override String DefaultIcon
        {
            get { return "ms_word"; }
        }

        /// <summary>
        ///     Gets the delegated method for loading the API object that is presented within the page.
        /// </summary>
        public override Func<String, LetterTemplate> DataLoader
        {
            get { return LetterTemplate.FetchById; }
        }

        /// <summary>
        ///     Gets the delegated method for creating the API object that is presented within the page.
        /// </summary>
        public override Func<LetterTemplate> DataCreator
        {
            get { return LetterTemplate.Create; }
        }

        #endregion

        #region methods

        protected override void PopulateControls()
        {
            this.WordTemplateDetails.DataSource = this.Data;
        }

        #endregion
    }
}