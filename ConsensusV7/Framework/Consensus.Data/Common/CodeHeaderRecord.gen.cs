using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Linq;

namespace Consensus.Common
{
    /// <summary>
    ///     Represents the "Code_Header" data structure.
    /// </summary>
    /// <remarks>
    ///     THIS CODE HAS BEEN AUTOMATICALLY GENERATED USING THE CONSENSUS DEVELOPER TOOLS.
    ///     DO NOT EDIT THIS CODE AS ANY CUSTOM MODIFICATIONS WILL BE LOST UPON REGENERATION.
    /// </remarks>
    public class CodeHeaderRecord : Record<String>, Cloneable<CodeHeaderRecord>, IEquatable<CodeHeaderRecord>
    {
        #region fields

        /// <summary>
        ///     the value of the "CDHDR_NAME" field.
        /// </summary>
        private String _name;

        /// <summary>
        ///     the value of the "CDHDR_LENGTH" field.
        /// </summary>
        private Byte? _length;

        /// <summary>
        ///     the value of the "CDHDR_TYPE" field.
        /// </summary>
        private Byte? _type;

        /// <summary>
        ///     the value of the "CDHDR_TV1" field.
        /// </summary>
        private Byte? _tv1;

        /// <summary>
        ///     the value of the "CDHDR_TV2" field.
        /// </summary>
        private Byte? _tv2;

        /// <summary>
        ///     the value of the "CDHDR_TV3" field.
        /// </summary>
        private Byte? _tv3;

        /// <summary>
        ///     the value of the "CDHDR_TV4" field.
        /// </summary>
        private Byte? _tv4;

        /// <summary>
        ///     the value of the "CDHDR_TV1_LEN" field.
        /// </summary>
        private Byte? _tv1Len;

        /// <summary>
        ///     the value of the "CDHDR_COL_NAME" field.
        /// </summary>
        private String _colName;

        /// <summary>
        ///     the value of the "CDHDR_TAB_NAME" field.
        /// </summary>
        private String _tabName;

        /// <summary>
        ///     the value of the "CDHDR_READ_ONLY" field.
        /// </summary>
        private Byte? _readOnly;

        /// <summary>
        ///     the value of the "CDHDR_CODE_VALUE3_LIST" field.
        /// </summary>
        private String _codeValue3List;

        /// <summary>
        ///     the value of the "CDHDR_IMMUTABLE" field.
        /// </summary>
        private Byte? _immutable;

        #endregion

        #region properties

        /// <summary>
        ///     the value of the "CDHDR_NAME" field.
        /// </summary>
        public String Name
        {
            get { return _name; }
            set { _name = value; }
        }

        /// <summary>
        ///     the value of the "CDHDR_LENGTH" field.
        /// </summary>
        public Byte? Length
        {
            get { return _length; }
            set { _length = value; }
        }

        /// <summary>
        ///     the value of the "CDHDR_TYPE" field.
        /// </summary>
        public Byte? Type
        {
            get { return _type; }
            set { _type = value; }
        }

        /// <summary>
        ///     the value of the "CDHDR_TV1" field.
        /// </summary>
        public Byte? Tv1
        {
            get { return _tv1; }
            set { _tv1 = value; }
        }

        /// <summary>
        ///     the value of the "CDHDR_TV2" field.
        /// </summary>
        public Byte? Tv2
        {
            get { return _tv2; }
            set { _tv2 = value; }
        }

        /// <summary>
        ///     the value of the "CDHDR_TV3" field.
        /// </summary>
        public Byte? Tv3
        {
            get { return _tv3; }
            set { _tv3 = value; }
        }

        /// <summary>
        ///     the value of the "CDHDR_TV4" field.
        /// </summary>
        public Byte? Tv4
        {
            get { return _tv4; }
            set { _tv4 = value; }
        }

        /// <summary>
        ///     the value of the "CDHDR_TV1_LEN" field.
        /// </summary>
        public Byte? Tv1Len
        {
            get { return _tv1Len; }
            set { _tv1Len = value; }
        }

        /// <summary>
        ///     the value of the "CDHDR_COL_NAME" field.
        /// </summary>
        public String ColName
        {
            get { return _colName; }
            set { _colName = value; }
        }

        /// <summary>
        ///     the value of the "CDHDR_TAB_NAME" field.
        /// </summary>
        public String TabName
        {
            get { return _tabName; }
            set { _tabName = value; }
        }

        /// <summary>
        ///     the value of the "CDHDR_READ_ONLY" field.
        /// </summary>
        public Byte? ReadOnly
        {
            get { return _readOnly; }
            set { _readOnly = value; }
        }

        /// <summary>
        ///     the value of the "CDHDR_CODE_VALUE3_LIST" field.
        /// </summary>
        public String CodeValue3List
        {
            get { return _codeValue3List; }
            set { _codeValue3List = value; }
        }

        /// <summary>
        ///     the value of the "CDHDR_IMMUTABLE" field.
        /// </summary>
        public Byte? Immutable
        {
            get { return _immutable; }
            set { _immutable = value; }
        }

        #endregion

        #region methods

        /// <summary>
        ///     Creates a new <see cref="CodeHeaderRecord" /> object instance that is a shallow-copy of the current object instance.
        /// </summary>
        /// <returns>
        ///     The shallow-copy of the current <see cref="CodeHeaderRecord" /> object instance.
        /// </returns>
        public CodeHeaderRecord Clone()
        {
            CodeHeaderRecord record = new CodeHeaderRecord();
            record.Id = this.Id;
            record.Name = this.Name;
            record.Length = this.Length;
            record.Type = this.Type;
            record.Tv1 = this.Tv1;
            record.Tv2 = this.Tv2;
            record.Tv3 = this.Tv3;
            record.Tv4 = this.Tv4;
            record.Tv1Len = this.Tv1Len;
            record.ColName = this.ColName;
            record.TabName = this.TabName;
            record.ReadOnly = this.ReadOnly;
            record.CodeValue3List = this.CodeValue3List;
            record.Immutable = this.Immutable;
            return record;
        }

        /// <summary>
        ///     Indicates whether the current <see cref="CodeHeaderRecord" /> instance is equal to another <see cref="CodeHeaderRecord" /> instance.
        /// </summary>
        /// <param name="that">
        ///     The <see cref="CodeHeaderRecord" /> instance to be compared against this instance.
        /// </param>
        /// <returns>
        ///     True if both instances are considered equal; otherwise, false.
        /// </returns>
        public Boolean Equals(CodeHeaderRecord that)
        {
            Boolean result = true;
            result = result && (this.Id.TrimOrNullify() == that.Id.TrimOrNullify());
            result = result && (this.Name.TrimOrNullify() == that.Name.TrimOrNullify());
            result = result && (this.Length == that.Length);
            result = result && (this.Type == that.Type);
            result = result && (this.Tv1 == that.Tv1);
            result = result && (this.Tv2 == that.Tv2);
            result = result && (this.Tv3 == that.Tv3);
            result = result && (this.Tv4 == that.Tv4);
            result = result && (this.Tv1Len == that.Tv1Len);
            result = result && (this.ColName.TrimOrNullify() == that.ColName.TrimOrNullify());
            result = result && (this.TabName.TrimOrNullify() == that.TabName.TrimOrNullify());
            result = result && (this.ReadOnly == that.ReadOnly);
            result = result && (this.CodeValue3List.TrimOrNullify() == that.CodeValue3List.TrimOrNullify());
            result = result && (this.Immutable == that.Immutable);
            return result;
        }

        #endregion
    }
}
