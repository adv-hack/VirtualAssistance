using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Linq;

namespace Consensus.Document
{
    /// <summary>
    ///     Represents the "Article" data structure.
    /// </summary>
    /// <remarks>
    ///     THIS CODE HAS BEEN AUTOMATICALLY GENERATED USING THE CONSENSUS DEVELOPER TOOLS.
    ///     DO NOT EDIT THIS CODE AS ANY CUSTOM MODIFICATIONS WILL BE LOST UPON REGENERATION.
    /// </remarks>
    public class ArticleRecord : Record<Int32>, Cloneable<ArticleRecord>, IEquatable<ArticleRecord>
    {
        #region fields

        /// <summary>
        ///     the value of the "ARTI_TYPE" field.
        /// </summary>
        private Byte _type;

        /// <summary>
        ///     the value of the "ARTI_STATE" field.
        /// </summary>
        private Byte _state;

        /// <summary>
        ///     the value of the "ARTI_ADD_DATE" field.
        /// </summary>
        private DateTime? _addDate;

        /// <summary>
        ///     the value of the "ARTI_MOD_DATE" field.
        /// </summary>
        private DateTime? _modDate;

        /// <summary>
        ///     the value of the "ARTI_RCV_DATE" field.
        /// </summary>
        private DateTime? _rcvDate;

        /// <summary>
        ///     the value of the "ARTI_ADD_BY" field.
        /// </summary>
        private String _addBy;

        /// <summary>
        ///     the value of the "ARTI_MOD_BY" field.
        /// </summary>
        private String _modBy;

        /// <summary>
        ///     the value of the "ARTI_RCV_FROM" field.
        /// </summary>
        private String _rcvFrom;

        /// <summary>
        ///     the value of the "ARTI_NAME" field.
        /// </summary>
        private String _name;

        /// <summary>
        ///     the value of the "ARTI_NOTES" field.
        /// </summary>
        private String _notes;

        /// <summary>
        ///     the value of the "ARTI_NOTES_HTML" field.
        /// </summary>
        private String _notesHtml;

        /// <summary>
        ///     the value of the "ARTI_GROUP" field.
        /// </summary>
        private String _group;

        /// <summary>
        ///     the value of the "ARTI_KEYWORDS" field.
        /// </summary>
        private String _keywords;

        /// <summary>
        ///     the value of the "ARTI_CATEGORY" field.
        /// </summary>
        private String _category;

        /// <summary>
        ///     the value of the "ARTI_SUMMARY" field.
        /// </summary>
        private String _summary;

        /// <summary>
        ///     the value of the "ARTI_SUMMARY_HTML" field.
        /// </summary>
        private String _summaryHtml;

        /// <summary>
        ///     the value of the "ARTI_WEB" field.
        /// </summary>
        private Byte _web;

        /// <summary>
        ///     the value of the "ARTI_IMAGE" field.
        /// </summary>
        private String _image;

        /// <summary>
        ///     the value of the "ARTI_FEATURED" field.
        /// </summary>
        private Byte _featured;

        /// <summary>
        ///     the value of the "ARTI_PUBLISH_DATE" field.
        /// </summary>
        private DateTime? _publishDate;

        /// <summary>
        ///     the value of the "ARTI_PUBLISH_PROLE_ID" field.
        /// </summary>
        private String _publishProleId;

        /// <summary>
        ///     the value of the "ARTI_PS_ID" field.
        /// </summary>
        private Int32? _psId;

        /// <summary>
        ///     the value of the "ARTI_AREA" field.
        /// </summary>
        private String _area;

        #endregion

        #region properties

        /// <summary>
        ///     the value of the "ARTI_TYPE" field.
        /// </summary>
        public Byte Type
        {
            get { return _type; }
            set { _type = value; }
        }

        /// <summary>
        ///     the value of the "ARTI_STATE" field.
        /// </summary>
        public Byte State
        {
            get { return _state; }
            set { _state = value; }
        }

        /// <summary>
        ///     the value of the "ARTI_ADD_DATE" field.
        /// </summary>
        public DateTime? AddDate
        {
            get { return _addDate; }
            set { _addDate = value; }
        }

        /// <summary>
        ///     the value of the "ARTI_MOD_DATE" field.
        /// </summary>
        public DateTime? ModDate
        {
            get { return _modDate; }
            set { _modDate = value; }
        }

        /// <summary>
        ///     the value of the "ARTI_RCV_DATE" field.
        /// </summary>
        public DateTime? RcvDate
        {
            get { return _rcvDate; }
            set { _rcvDate = value; }
        }

        /// <summary>
        ///     the value of the "ARTI_ADD_BY" field.
        /// </summary>
        public String AddBy
        {
            get { return _addBy; }
            set { _addBy = value; }
        }

        /// <summary>
        ///     the value of the "ARTI_MOD_BY" field.
        /// </summary>
        public String ModBy
        {
            get { return _modBy; }
            set { _modBy = value; }
        }

        /// <summary>
        ///     the value of the "ARTI_RCV_FROM" field.
        /// </summary>
        public String RcvFrom
        {
            get { return _rcvFrom; }
            set { _rcvFrom = value; }
        }

        /// <summary>
        ///     the value of the "ARTI_NAME" field.
        /// </summary>
        public String Name
        {
            get { return _name; }
            set { _name = value; }
        }

        /// <summary>
        ///     the value of the "ARTI_NOTES" field.
        /// </summary>
        public String Notes
        {
            get { return _notes; }
            set { _notes = value; }
        }

        /// <summary>
        ///     the value of the "ARTI_NOTES_HTML" field.
        /// </summary>
        public String NotesHtml
        {
            get { return _notesHtml; }
            set { _notesHtml = value; }
        }

        /// <summary>
        ///     the value of the "ARTI_GROUP" field.
        /// </summary>
        public String Group
        {
            get { return _group; }
            set { _group = value; }
        }

        /// <summary>
        ///     the value of the "ARTI_KEYWORDS" field.
        /// </summary>
        public String Keywords
        {
            get { return _keywords; }
            set { _keywords = value; }
        }

        /// <summary>
        ///     the value of the "ARTI_CATEGORY" field.
        /// </summary>
        public String Category
        {
            get { return _category; }
            set { _category = value; }
        }

        /// <summary>
        ///     the value of the "ARTI_SUMMARY" field.
        /// </summary>
        public String Summary
        {
            get { return _summary; }
            set { _summary = value; }
        }

        /// <summary>
        ///     the value of the "ARTI_SUMMARY_HTML" field.
        /// </summary>
        public String SummaryHtml
        {
            get { return _summaryHtml; }
            set { _summaryHtml = value; }
        }

        /// <summary>
        ///     the value of the "ARTI_WEB" field.
        /// </summary>
        public Byte Web
        {
            get { return _web; }
            set { _web = value; }
        }

        /// <summary>
        ///     the value of the "ARTI_IMAGE" field.
        /// </summary>
        public String Image
        {
            get { return _image; }
            set { _image = value; }
        }

        /// <summary>
        ///     the value of the "ARTI_FEATURED" field.
        /// </summary>
        public Byte Featured
        {
            get { return _featured; }
            set { _featured = value; }
        }

        /// <summary>
        ///     the value of the "ARTI_PUBLISH_DATE" field.
        /// </summary>
        public DateTime? PublishDate
        {
            get { return _publishDate; }
            set { _publishDate = value; }
        }

        /// <summary>
        ///     the value of the "ARTI_PUBLISH_PROLE_ID" field.
        /// </summary>
        public String PublishProleId
        {
            get { return _publishProleId; }
            set { _publishProleId = value; }
        }

        /// <summary>
        ///     the value of the "ARTI_PS_ID" field.
        /// </summary>
        public Int32? PsId
        {
            get { return _psId; }
            set { _psId = value; }
        }

        /// <summary>
        ///     the value of the "ARTI_AREA" field.
        /// </summary>
        public String Area
        {
            get { return _area; }
            set { _area = value; }
        }

        #endregion

        #region methods

        /// <summary>
        ///     Creates a new <see cref="ArticleRecord" /> object instance that is a shallow-copy of the current object instance.
        /// </summary>
        /// <returns>
        ///     The shallow-copy of the current <see cref="ArticleRecord" /> object instance.
        /// </returns>
        public ArticleRecord Clone()
        {
            ArticleRecord record = new ArticleRecord();
            record.Id = this.Id;
            record.Type = this.Type;
            record.State = this.State;
            record.AddDate = this.AddDate;
            record.ModDate = this.ModDate;
            record.RcvDate = this.RcvDate;
            record.AddBy = this.AddBy;
            record.ModBy = this.ModBy;
            record.RcvFrom = this.RcvFrom;
            record.Name = this.Name;
            record.Notes = this.Notes;
            record.NotesHtml = this.NotesHtml;
            record.Group = this.Group;
            record.Keywords = this.Keywords;
            record.Category = this.Category;
            record.Summary = this.Summary;
            record.SummaryHtml = this.SummaryHtml;
            record.Web = this.Web;
            record.Image = this.Image;
            record.Featured = this.Featured;
            record.PublishDate = this.PublishDate;
            record.PublishProleId = this.PublishProleId;
            record.PsId = this.PsId;
            record.Area = this.Area;
            return record;
        }

        /// <summary>
        ///     Indicates whether the current <see cref="ArticleRecord" /> instance is equal to another <see cref="ArticleRecord" /> instance.
        /// </summary>
        /// <param name="that">
        ///     The <see cref="ArticleRecord" /> instance to be compared against this instance.
        /// </param>
        /// <returns>
        ///     True if both instances are considered equal; otherwise, false.
        /// </returns>
        public Boolean Equals(ArticleRecord that)
        {
            Boolean result = true;
            result = result && (this.Id == that.Id);
            result = result && (this.Type == that.Type);
            result = result && (this.State == that.State);
            result = result && (this.Name.TrimOrNullify() == that.Name.TrimOrNullify());
            result = result && (this.Notes.TrimOrNullify() == that.Notes.TrimOrNullify());
            result = result && (this.NotesHtml.TrimOrNullify() == that.NotesHtml.TrimOrNullify());
            result = result && (this.Group.TrimOrNullify() == that.Group.TrimOrNullify());
            result = result && (this.Keywords.TrimOrNullify() == that.Keywords.TrimOrNullify());
            result = result && (this.Category.TrimOrNullify() == that.Category.TrimOrNullify());
            result = result && (this.Summary.TrimOrNullify() == that.Summary.TrimOrNullify());
            result = result && (this.SummaryHtml.TrimOrNullify() == that.SummaryHtml.TrimOrNullify());
            result = result && (this.Web == that.Web);
            result = result && (this.Image.TrimOrNullify() == that.Image.TrimOrNullify());
            result = result && (this.Featured == that.Featured);
            result = result && (this.PublishDate == that.PublishDate);
            result = result && (this.PublishProleId.TrimOrNullify() == that.PublishProleId.TrimOrNullify());
            result = result && (this.PsId == that.PsId);
            result = result && (this.Area.TrimOrNullify() == that.Area.TrimOrNullify());
            return result;
        }

        #endregion
    }
}
