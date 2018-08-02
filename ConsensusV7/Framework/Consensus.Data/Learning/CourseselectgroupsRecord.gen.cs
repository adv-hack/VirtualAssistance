using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Linq;

namespace Consensus.Learning
{
    /// <summary>
    ///     Represents the "CourseSelectGroups" data structure.
    /// </summary>
    /// <remarks>
    ///     THIS CODE HAS BEEN AUTOMATICALLY GENERATED USING THE CONSENSUS DEVELOPER TOOLS.
    ///     DO NOT EDIT THIS CODE AS ANY CUSTOM MODIFICATIONS WILL BE LOST UPON REGENERATION.
    /// </remarks>
    public class CourseselectgroupsRecord : Record<Int32>, Cloneable<CourseselectgroupsRecord>, IEquatable<CourseselectgroupsRecord>
    {
        #region fields

        /// <summary>
        ///     the value of the "CSG_ADD_DATE" field.
        /// </summary>
        private DateTime _addDate;

        /// <summary>
        ///     the value of the "CSG_ADD_BY" field.
        /// </summary>
        private String _addBy;

        /// <summary>
        ///     the value of the "CSG_MOD_DATE" field.
        /// </summary>
        private DateTime _modDate;

        /// <summary>
        ///     the value of the "CSG_MOD_BY" field.
        /// </summary>
        private String _modBy;

        /// <summary>
        ///     the value of the "CSG_PSG_ID" field.
        /// </summary>
        private Int32? _psgId;

        /// <summary>
        ///     the value of the "CSG_COURSE_ID" field.
        /// </summary>
        private String _eventId;

        /// <summary>
        ///     the value of the "CSG_TYPE" field.
        /// </summary>
        private Byte _type;

        /// <summary>
        ///     the value of the "CSG_NAME" field.
        /// </summary>
        private String _name;

        /// <summary>
        ///     the value of the "CSG_DESCRIPTION" field.
        /// </summary>
        private String _description;

        /// <summary>
        ///     the value of the "CSG_MIN" field.
        /// </summary>
        private Byte _min;

        /// <summary>
        ///     the value of the "CSG_MAX" field.
        /// </summary>
        private Byte _max;

        /// <summary>
        ///     the value of the "CSG_ORDER" field.
        /// </summary>
        private Byte _order;

        /// <summary>
        ///     the value of the "CSG_ERROR_MESSAGE" field.
        /// </summary>
        private String _errorMessage;

        #endregion

        #region properties

        /// <summary>
        ///     the value of the "CSG_ADD_DATE" field.
        /// </summary>
        public DateTime AddDate
        {
            get { return _addDate; }
            set { _addDate = value; }
        }

        /// <summary>
        ///     the value of the "CSG_ADD_BY" field.
        /// </summary>
        public String AddBy
        {
            get { return _addBy; }
            set { _addBy = value; }
        }

        /// <summary>
        ///     the value of the "CSG_MOD_DATE" field.
        /// </summary>
        public DateTime ModDate
        {
            get { return _modDate; }
            set { _modDate = value; }
        }

        /// <summary>
        ///     the value of the "CSG_MOD_BY" field.
        /// </summary>
        public String ModBy
        {
            get { return _modBy; }
            set { _modBy = value; }
        }

        /// <summary>
        ///     the value of the "CSG_PSG_ID" field.
        /// </summary>
        public Int32? PsgId
        {
            get { return _psgId; }
            set { _psgId = value; }
        }

        /// <summary>
        ///     the value of the "CSG_COURSE_ID" field.
        /// </summary>
        public String EventId
        {
            get { return _eventId; }
            set { _eventId = value; }
        }

        /// <summary>
        ///     the value of the "CSG_TYPE" field.
        /// </summary>
        public Byte Type
        {
            get { return _type; }
            set { _type = value; }
        }

        /// <summary>
        ///     the value of the "CSG_NAME" field.
        /// </summary>
        public String Name
        {
            get { return _name; }
            set { _name = value; }
        }

        /// <summary>
        ///     the value of the "CSG_DESCRIPTION" field.
        /// </summary>
        public String Description
        {
            get { return _description; }
            set { _description = value; }
        }

        /// <summary>
        ///     the value of the "CSG_MIN" field.
        /// </summary>
        public Byte Min
        {
            get { return _min; }
            set { _min = value; }
        }

        /// <summary>
        ///     the value of the "CSG_MAX" field.
        /// </summary>
        public Byte Max
        {
            get { return _max; }
            set { _max = value; }
        }

        /// <summary>
        ///     the value of the "CSG_ORDER" field.
        /// </summary>
        public Byte Order
        {
            get { return _order; }
            set { _order = value; }
        }

        /// <summary>
        ///     the value of the "CSG_ERROR_MESSAGE" field.
        /// </summary>
        public String ErrorMessage
        {
            get { return _errorMessage; }
            set { _errorMessage = value; }
        }

        #endregion

        #region methods

        /// <summary>
        ///     Creates a new <see cref="CourseselectgroupsRecord" /> object instance that is a shallow-copy of the current object instance.
        /// </summary>
        /// <returns>
        ///     The shallow-copy of the current <see cref="CourseselectgroupsRecord" /> object instance.
        /// </returns>
        public CourseselectgroupsRecord Clone()
        {
            CourseselectgroupsRecord record = new CourseselectgroupsRecord();
            record.Id = this.Id;
            record.AddDate = this.AddDate;
            record.AddBy = this.AddBy;
            record.ModDate = this.ModDate;
            record.ModBy = this.ModBy;
            record.PsgId = this.PsgId;
            record.EventId = this.EventId;
            record.Type = this.Type;
            record.Name = this.Name;
            record.Description = this.Description;
            record.Min = this.Min;
            record.Max = this.Max;
            record.Order = this.Order;
            record.ErrorMessage = this.ErrorMessage;
            return record;
        }

        /// <summary>
        ///     Indicates whether the current <see cref="CourseselectgroupsRecord" /> instance is equal to another <see cref="CourseselectgroupsRecord" /> instance.
        /// </summary>
        /// <param name="that">
        ///     The <see cref="CourseselectgroupsRecord" /> instance to be compared against this instance.
        /// </param>
        /// <returns>
        ///     True if both instances are considered equal; otherwise, false.
        /// </returns>
        public Boolean Equals(CourseselectgroupsRecord that)
        {
            Boolean result = true;
            result = result && (this.Id == that.Id);
            result = result && (this.PsgId == that.PsgId);
            result = result && (this.EventId.TrimOrNullify() == that.EventId.TrimOrNullify());
            result = result && (this.Type == that.Type);
            result = result && (this.Name.TrimOrNullify() == that.Name.TrimOrNullify());
            result = result && (this.Description.TrimOrNullify() == that.Description.TrimOrNullify());
            result = result && (this.Min == that.Min);
            result = result && (this.Max == that.Max);
            result = result && (this.Order == that.Order);
            result = result && (this.ErrorMessage.TrimOrNullify() == that.ErrorMessage.TrimOrNullify());
            return result;
        }

        #endregion
    }
}
