using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Linq;

namespace Consensus.Common
{
    /// <summary>
    ///     Represents the "GenericModelTable" data structure.
    /// </summary>
    /// <remarks>
    ///     THIS CODE HAS BEEN AUTOMATICALLY GENERATED USING THE CONSENSUS DEVELOPER TOOLS.
    ///     DO NOT EDIT THIS CODE AS ANY CUSTOM MODIFICATIONS WILL BE LOST UPON REGENERATION.
    /// </remarks>
    public class GenericmodeltableRecord : Record<String>, Cloneable<GenericmodeltableRecord>, IEquatable<GenericmodeltableRecord>
    {
        #region fields

        /// <summary>
        ///     the value of the "GMT_ID1" field.
        /// </summary>
        private String _id1;

        /// <summary>
        ///     the value of the "GMT_ID2" field.
        /// </summary>
        private String _id2;

        /// <summary>
        ///     the value of the "GMT_ID3" field.
        /// </summary>
        private String _id3;

        /// <summary>
        ///     the value of the "GMT_ID4" field.
        /// </summary>
        private String _id4;

        /// <summary>
        ///     the value of the "GMT_ID5" field.
        /// </summary>
        private String _id5;

        /// <summary>
        ///     the value of the "GMT_DESC1" field.
        /// </summary>
        private String _desc1;

        /// <summary>
        ///     the value of the "GMT_DESC2" field.
        /// </summary>
        private String _desc2;

        /// <summary>
        ///     the value of the "GMT_DESC3" field.
        /// </summary>
        private String _desc3;

        /// <summary>
        ///     the value of the "GMT_DESC4" field.
        /// </summary>
        private String _desc4;

        /// <summary>
        ///     the value of the "GMT_DESC5" field.
        /// </summary>
        private String _desc5;

        /// <summary>
        ///     the value of the "GMT_LONGDESC" field.
        /// </summary>
        private String _longdesc;

        /// <summary>
        ///     the value of the "GMT_DATE1" field.
        /// </summary>
        private DateTime? _date1;

        /// <summary>
        ///     the value of the "GMT_DATE2" field.
        /// </summary>
        private DateTime? _date2;

        /// <summary>
        ///     the value of the "GMT_DATE3" field.
        /// </summary>
        private DateTime? _date3;

        /// <summary>
        ///     the value of the "GMT_INT1" field.
        /// </summary>
        private Int32? _int1;

        /// <summary>
        ///     the value of the "GMT_INT2" field.
        /// </summary>
        private Int32? _int2;

        /// <summary>
        ///     the value of the "GMT_INT3" field.
        /// </summary>
        private Int32? _int3;

        /// <summary>
        ///     the value of the "GMT_MONEY1" field.
        /// </summary>
        private Decimal? _money1;

        /// <summary>
        ///     the value of the "GMT_MONEY2" field.
        /// </summary>
        private Decimal? _money2;

        /// <summary>
        ///     the value of the "GMT_MONEY3" field.
        /// </summary>
        private Decimal? _money3;

        #endregion

        #region properties

        /// <summary>
        ///     the value of the "GMT_ID1" field.
        /// </summary>
        public String Id1
        {
            get { return _id1; }
            set { _id1 = value; }
        }

        /// <summary>
        ///     the value of the "GMT_ID2" field.
        /// </summary>
        public String Id2
        {
            get { return _id2; }
            set { _id2 = value; }
        }

        /// <summary>
        ///     the value of the "GMT_ID3" field.
        /// </summary>
        public String Id3
        {
            get { return _id3; }
            set { _id3 = value; }
        }

        /// <summary>
        ///     the value of the "GMT_ID4" field.
        /// </summary>
        public String Id4
        {
            get { return _id4; }
            set { _id4 = value; }
        }

        /// <summary>
        ///     the value of the "GMT_ID5" field.
        /// </summary>
        public String Id5
        {
            get { return _id5; }
            set { _id5 = value; }
        }

        /// <summary>
        ///     the value of the "GMT_DESC1" field.
        /// </summary>
        public String Desc1
        {
            get { return _desc1; }
            set { _desc1 = value; }
        }

        /// <summary>
        ///     the value of the "GMT_DESC2" field.
        /// </summary>
        public String Desc2
        {
            get { return _desc2; }
            set { _desc2 = value; }
        }

        /// <summary>
        ///     the value of the "GMT_DESC3" field.
        /// </summary>
        public String Desc3
        {
            get { return _desc3; }
            set { _desc3 = value; }
        }

        /// <summary>
        ///     the value of the "GMT_DESC4" field.
        /// </summary>
        public String Desc4
        {
            get { return _desc4; }
            set { _desc4 = value; }
        }

        /// <summary>
        ///     the value of the "GMT_DESC5" field.
        /// </summary>
        public String Desc5
        {
            get { return _desc5; }
            set { _desc5 = value; }
        }

        /// <summary>
        ///     the value of the "GMT_LONGDESC" field.
        /// </summary>
        public String Longdesc
        {
            get { return _longdesc; }
            set { _longdesc = value; }
        }

        /// <summary>
        ///     the value of the "GMT_DATE1" field.
        /// </summary>
        public DateTime? Date1
        {
            get { return _date1; }
            set { _date1 = value; }
        }

        /// <summary>
        ///     the value of the "GMT_DATE2" field.
        /// </summary>
        public DateTime? Date2
        {
            get { return _date2; }
            set { _date2 = value; }
        }

        /// <summary>
        ///     the value of the "GMT_DATE3" field.
        /// </summary>
        public DateTime? Date3
        {
            get { return _date3; }
            set { _date3 = value; }
        }

        /// <summary>
        ///     the value of the "GMT_INT1" field.
        /// </summary>
        public Int32? Int1
        {
            get { return _int1; }
            set { _int1 = value; }
        }

        /// <summary>
        ///     the value of the "GMT_INT2" field.
        /// </summary>
        public Int32? Int2
        {
            get { return _int2; }
            set { _int2 = value; }
        }

        /// <summary>
        ///     the value of the "GMT_INT3" field.
        /// </summary>
        public Int32? Int3
        {
            get { return _int3; }
            set { _int3 = value; }
        }

        /// <summary>
        ///     the value of the "GMT_MONEY1" field.
        /// </summary>
        public Decimal? Money1
        {
            get { return _money1; }
            set { _money1 = value; }
        }

        /// <summary>
        ///     the value of the "GMT_MONEY2" field.
        /// </summary>
        public Decimal? Money2
        {
            get { return _money2; }
            set { _money2 = value; }
        }

        /// <summary>
        ///     the value of the "GMT_MONEY3" field.
        /// </summary>
        public Decimal? Money3
        {
            get { return _money3; }
            set { _money3 = value; }
        }

        #endregion

        #region methods

        /// <summary>
        ///     Creates a new <see cref="GenericmodeltableRecord" /> object instance that is a shallow-copy of the current object instance.
        /// </summary>
        /// <returns>
        ///     The shallow-copy of the current <see cref="GenericmodeltableRecord" /> object instance.
        /// </returns>
        public GenericmodeltableRecord Clone()
        {
            GenericmodeltableRecord record = new GenericmodeltableRecord();
            record.Id = this.Id;
            record.Id1 = this.Id1;
            record.Id2 = this.Id2;
            record.Id3 = this.Id3;
            record.Id4 = this.Id4;
            record.Id5 = this.Id5;
            record.Desc1 = this.Desc1;
            record.Desc2 = this.Desc2;
            record.Desc3 = this.Desc3;
            record.Desc4 = this.Desc4;
            record.Desc5 = this.Desc5;
            record.Longdesc = this.Longdesc;
            record.Date1 = this.Date1;
            record.Date2 = this.Date2;
            record.Date3 = this.Date3;
            record.Int1 = this.Int1;
            record.Int2 = this.Int2;
            record.Int3 = this.Int3;
            record.Money1 = this.Money1;
            record.Money2 = this.Money2;
            record.Money3 = this.Money3;
            return record;
        }

        /// <summary>
        ///     Indicates whether the current <see cref="GenericmodeltableRecord" /> instance is equal to another <see cref="GenericmodeltableRecord" /> instance.
        /// </summary>
        /// <param name="that">
        ///     The <see cref="GenericmodeltableRecord" /> instance to be compared against this instance.
        /// </param>
        /// <returns>
        ///     True if both instances are considered equal; otherwise, false.
        /// </returns>
        public Boolean Equals(GenericmodeltableRecord that)
        {
            Boolean result = true;
            result = result && (this.Id.TrimOrNullify() == that.Id.TrimOrNullify());
            result = result && (this.Id1.TrimOrNullify() == that.Id1.TrimOrNullify());
            result = result && (this.Id2.TrimOrNullify() == that.Id2.TrimOrNullify());
            result = result && (this.Id3.TrimOrNullify() == that.Id3.TrimOrNullify());
            result = result && (this.Id4.TrimOrNullify() == that.Id4.TrimOrNullify());
            result = result && (this.Id5.TrimOrNullify() == that.Id5.TrimOrNullify());
            result = result && (this.Desc1.TrimOrNullify() == that.Desc1.TrimOrNullify());
            result = result && (this.Desc2.TrimOrNullify() == that.Desc2.TrimOrNullify());
            result = result && (this.Desc3.TrimOrNullify() == that.Desc3.TrimOrNullify());
            result = result && (this.Desc4.TrimOrNullify() == that.Desc4.TrimOrNullify());
            result = result && (this.Desc5.TrimOrNullify() == that.Desc5.TrimOrNullify());
            result = result && (this.Longdesc.TrimOrNullify() == that.Longdesc.TrimOrNullify());
            result = result && (this.Date1 == that.Date1);
            result = result && (this.Date2 == that.Date2);
            result = result && (this.Date3 == that.Date3);
            result = result && (this.Int1 == that.Int1);
            result = result && (this.Int2 == that.Int2);
            result = result && (this.Int3 == that.Int3);
            result = result && (this.Money1 == that.Money1);
            result = result && (this.Money2 == that.Money2);
            result = result && (this.Money3 == that.Money3);
            return result;
        }

        #endregion
    }
}
