using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Linq;

namespace Consensus.Common
{
    /// <summary>
    ///     Represents the "LearningZoneCategories" data structure.
    /// </summary>
    /// <remarks>
    ///     THIS CODE HAS BEEN AUTOMATICALLY GENERATED USING THE CONSENSUS DEVELOPER TOOLS.
    ///     DO NOT EDIT THIS CODE AS ANY CUSTOM MODIFICATIONS WILL BE LOST UPON REGENERATION.
    /// </remarks>
    public class LearningzonecategoriesRecord : Record<Int32>, Cloneable<LearningzonecategoriesRecord>, IEquatable<LearningzonecategoriesRecord>
    {
        #region fields

        /// <summary>
        ///     the value of the "LZC_ADD_DATE" field.
        /// </summary>
        private DateTime _addDate;

        /// <summary>
        ///     the value of the "LZC_ADD_BY" field.
        /// </summary>
        private String _addBy;

        /// <summary>
        ///     the value of the "LZC_MOD_DATE" field.
        /// </summary>
        private DateTime _modDate;

        /// <summary>
        ///     the value of the "LZC_MOD_BY" field.
        /// </summary>
        private String _modBy;

        /// <summary>
        ///     the value of the "LZC_CATEGORY_TITLE" field.
        /// </summary>
        private String _categoryTitle;

        /// <summary>
        ///     the value of the "LZC_DESCRIPTION" field.
        /// </summary>
        private String _description;

        /// <summary>
        ///     the value of the "LZC_DESCRIPTION_HTML" field.
        /// </summary>
        private String _descriptionHtml;

        #endregion

        #region properties

        /// <summary>
        ///     the value of the "LZC_ADD_DATE" field.
        /// </summary>
        public DateTime AddDate
        {
            get { return _addDate; }
            set { _addDate = value; }
        }

        /// <summary>
        ///     the value of the "LZC_ADD_BY" field.
        /// </summary>
        public String AddBy
        {
            get { return _addBy; }
            set { _addBy = value; }
        }

        /// <summary>
        ///     the value of the "LZC_MOD_DATE" field.
        /// </summary>
        public DateTime ModDate
        {
            get { return _modDate; }
            set { _modDate = value; }
        }

        /// <summary>
        ///     the value of the "LZC_MOD_BY" field.
        /// </summary>
        public String ModBy
        {
            get { return _modBy; }
            set { _modBy = value; }
        }

        /// <summary>
        ///     the value of the "LZC_CATEGORY_TITLE" field.
        /// </summary>
        public String CategoryTitle
        {
            get { return _categoryTitle; }
            set { _categoryTitle = value; }
        }

        /// <summary>
        ///     the value of the "LZC_DESCRIPTION" field.
        /// </summary>
        public String Description
        {
            get { return _description; }
            set { _description = value; }
        }

        /// <summary>
        ///     the value of the "LZC_DESCRIPTION_HTML" field.
        /// </summary>
        public String DescriptionHtml
        {
            get { return _descriptionHtml; }
            set { _descriptionHtml = value; }
        }

        #endregion

        #region methods

        /// <summary>
        ///     Creates a new <see cref="LearningzonecategoriesRecord" /> object instance that is a shallow-copy of the current object instance.
        /// </summary>
        /// <returns>
        ///     The shallow-copy of the current <see cref="LearningzonecategoriesRecord" /> object instance.
        /// </returns>
        public LearningzonecategoriesRecord Clone()
        {
            LearningzonecategoriesRecord record = new LearningzonecategoriesRecord();
            record.Id = this.Id;
            record.AddDate = this.AddDate;
            record.AddBy = this.AddBy;
            record.ModDate = this.ModDate;
            record.ModBy = this.ModBy;
            record.CategoryTitle = this.CategoryTitle;
            record.Description = this.Description;
            record.DescriptionHtml = this.DescriptionHtml;
            return record;
        }

        /// <summary>
        ///     Indicates whether the current <see cref="LearningzonecategoriesRecord" /> instance is equal to another <see cref="LearningzonecategoriesRecord" /> instance.
        /// </summary>
        /// <param name="that">
        ///     The <see cref="LearningzonecategoriesRecord" /> instance to be compared against this instance.
        /// </param>
        /// <returns>
        ///     True if both instances are considered equal; otherwise, false.
        /// </returns>
        public Boolean Equals(LearningzonecategoriesRecord that)
        {
            Boolean result = true;
            result = result && (this.Id == that.Id);
            result = result && (this.CategoryTitle.TrimOrNullify() == that.CategoryTitle.TrimOrNullify());
            result = result && (this.Description.TrimOrNullify() == that.Description.TrimOrNullify());
            result = result && (this.DescriptionHtml.TrimOrNullify() == that.DescriptionHtml.TrimOrNullify());
            return result;
        }

        #endregion
    }
}
