using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Linq;

namespace Consensus.Document
{
    /// <summary>
    ///     Represents the "ArticleXref" data structure.
    /// </summary>
    /// <remarks>
    ///     THIS CODE HAS BEEN AUTOMATICALLY GENERATED USING THE CONSENSUS DEVELOPER TOOLS.
    ///     DO NOT EDIT THIS CODE AS ANY CUSTOM MODIFICATIONS WILL BE LOST UPON REGENERATION.
    /// </remarks>
    public class ArticlexrefRecord : Record<Int32>, Cloneable<ArticlexrefRecord>, IEquatable<ArticlexrefRecord>
    {
        #region fields

        /// <summary>
        ///     the value of the "ARTIXREF_ADD_DATE" field.
        /// </summary>
        private DateTime _addDate;

        /// <summary>
        ///     the value of the "ARTIXREF_ADD_BY" field.
        /// </summary>
        private String _addBy;

        /// <summary>
        ///     the value of the "ARTIXREF_MOD_DATE" field.
        /// </summary>
        private DateTime _modDate;

        /// <summary>
        ///     the value of the "ARTIXREF_MOD_BY" field.
        /// </summary>
        private String _modBy;

        /// <summary>
        ///     the value of the "ARTIXREF_ARTI_ID" field.
        /// </summary>
        private String _artiId;

        /// <summary>
        ///     the value of the "ARTIXREF_REL_ARTI_ID" field.
        /// </summary>
        private Int32 _relArtiId;

        #endregion

        #region properties

        /// <summary>
        ///     the value of the "ARTIXREF_ADD_DATE" field.
        /// </summary>
        public DateTime AddDate
        {
            get { return _addDate; }
            set { _addDate = value; }
        }

        /// <summary>
        ///     the value of the "ARTIXREF_ADD_BY" field.
        /// </summary>
        public String AddBy
        {
            get { return _addBy; }
            set { _addBy = value; }
        }

        /// <summary>
        ///     the value of the "ARTIXREF_MOD_DATE" field.
        /// </summary>
        public DateTime ModDate
        {
            get { return _modDate; }
            set { _modDate = value; }
        }

        /// <summary>
        ///     the value of the "ARTIXREF_MOD_BY" field.
        /// </summary>
        public String ModBy
        {
            get { return _modBy; }
            set { _modBy = value; }
        }

        /// <summary>
        ///     the value of the "ARTIXREF_ARTI_ID" field.
        /// </summary>
        public String ArtiId
        {
            get { return _artiId; }
            set { _artiId = value; }
        }

        /// <summary>
        ///     the value of the "ARTIXREF_REL_ARTI_ID" field.
        /// </summary>
        public Int32 RelArtiId
        {
            get { return _relArtiId; }
            set { _relArtiId = value; }
        }

        #endregion

        #region methods

        /// <summary>
        ///     Creates a new <see cref="ArticlexrefRecord" /> object instance that is a shallow-copy of the current object instance.
        /// </summary>
        /// <returns>
        ///     The shallow-copy of the current <see cref="ArticlexrefRecord" /> object instance.
        /// </returns>
        public ArticlexrefRecord Clone()
        {
            ArticlexrefRecord record = new ArticlexrefRecord();
            record.Id = this.Id;
            record.AddDate = this.AddDate;
            record.AddBy = this.AddBy;
            record.ModDate = this.ModDate;
            record.ModBy = this.ModBy;
            record.ArtiId = this.ArtiId;
            record.RelArtiId = this.RelArtiId;
            return record;
        }

        /// <summary>
        ///     Indicates whether the current <see cref="ArticlexrefRecord" /> instance is equal to another <see cref="ArticlexrefRecord" /> instance.
        /// </summary>
        /// <param name="that">
        ///     The <see cref="ArticlexrefRecord" /> instance to be compared against this instance.
        /// </param>
        /// <returns>
        ///     True if both instances are considered equal; otherwise, false.
        /// </returns>
        public Boolean Equals(ArticlexrefRecord that)
        {
            Boolean result = true;
            result = result && (this.Id == that.Id);
            result = result && (this.ArtiId.TrimOrNullify() == that.ArtiId.TrimOrNullify());
            result = result && (this.RelArtiId == that.RelArtiId);
            return result;
        }

        #endregion
    }
}
