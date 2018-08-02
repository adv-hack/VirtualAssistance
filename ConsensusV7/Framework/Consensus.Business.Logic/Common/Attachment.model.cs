using System;
using System.Collections.Generic;
using System.Linq;
using System.Transactions;

namespace Consensus.Common
{
    /// <summary>
    ///     Encapsulates the <see cref="AttachmentRecord" /> with standardised business rules.
    /// </summary>
    public partial class LocalAttachmentModel
    {
        #region fields

        LocalLearningZoneCategoriesModel _learningZoneCategory;

        LocalAttachLearningZoneCategoriesModel _learningZoneCategoryLink;

        #endregion

        #region properties

        /// <summary>
        ///     Flatten out the many-to-many linked LearningZoneCategories into a one-to-many link
        /// </summary>
        public LocalAttachLearningZoneCategoriesModel LearningZoneCategoryLink
        {
            get
            {
                if (_learningZoneCategoryLink == null)
                {
                    _learningZoneCategoryLink = this.LearningZoneCategoriesLinkAttachments.FirstOrDefault();
                    if (_learningZoneCategoryLink == null)
                    {
                        _learningZoneCategoryLink = new LocalAttachLearningZoneCategoriesModel(this.Provider);
                        this.LearningZoneCategoriesLinkAttachments.Add(_learningZoneCategoryLink);
                    }
                }

                return _learningZoneCategoryLink;
            }
        }

        /// <summary>
        ///     The Flattened out linked LearningZoneCategory
        /// </summary>
        public LocalLearningZoneCategoriesModel LearningZoneCategory
        {
            get
            {
                return LearningZoneCategoryLink.LzcId;
            }
        }

        /// <summary>
        ///     The Id of the Flattened out linked LearningZoneCategory
        /// </summary>
        public int LearningZoneCategoryId
        {
            get
            {
                return this.LearningZoneCategoryLink.LzcIdId;
            }
            set
            {
                this.LearningZoneCategoryLink.LzcIdId = value;
            }
        }

        /// <summary>
        ///     Resolves the description of the Visibility option (hard coded). Set has no effect.
        /// </summary>
        public string VisibilityDesc
        {
            get
            {
                string desc = "?";
                switch(Visibility)
                {
                    case 0: desc = "Booked On"; break;
                    case 1: desc = "Training On"; break;
                    case 2: desc = "Always"; break;
                }
                return desc;
            }
            set { }
        }

        #endregion

        #region methods

        /// <summary>
        ///     Always delete the Attachments_Data entry (there should be only one) when we delete an attachment. 
        /// </summary>
        protected override void ResolveDeleteDependent()
        {
            // 
            // Need to put this in an isolated transaction if the Attachments_Data table is in a 
            // different database to prevent it locking up.
            using (TransactionScope transaction = new TransactionScope(TransactionScopeOption.Suppress))
            {
                LocalAttachmentDataModel[] dataEntries = this.DataAttachments.ToArray();

                for (int i = dataEntries.Length - 1; i >= 0; i--)
                {
                    dataEntries[i].Delete();
                }
            }
        }

        #endregion
    }
}
