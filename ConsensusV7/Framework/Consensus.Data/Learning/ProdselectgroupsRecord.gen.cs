using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Linq;

namespace Consensus.Learning
{
    /// <summary>
    ///     Represents the "ProdSelectGroups" data structure.
    /// </summary>
    /// <remarks>
    ///     THIS CODE HAS BEEN AUTOMATICALLY GENERATED USING THE CONSENSUS DEVELOPER TOOLS.
    ///     DO NOT EDIT THIS CODE AS ANY CUSTOM MODIFICATIONS WILL BE LOST UPON REGENERATION.
    /// </remarks>
    public class ProdselectgroupsRecord : Record<Int32>, Cloneable<ProdselectgroupsRecord>, IEquatable<ProdselectgroupsRecord>
    {
        #region fields

        /// <summary>
        ///     the value of the "PSG_ADD_DATE" field.
        /// </summary>
        private DateTime _addDate;

        /// <summary>
        ///     the value of the "PSG_ADD_BY" field.
        /// </summary>
        private String _addBy;

        /// <summary>
        ///     the value of the "PSG_MOD_DATE" field.
        /// </summary>
        private DateTime _modDate;

        /// <summary>
        ///     the value of the "PSG_MOD_BY" field.
        /// </summary>
        private String _modBy;

        /// <summary>
        ///     the value of the "PSG_PROD_ID" field.
        /// </summary>
        private String _product;

        /// <summary>
        ///     the value of the "PSG_TYPE" field.
        /// </summary>
        private Byte _type;

        /// <summary>
        ///     the value of the "PSG_NAME" field.
        /// </summary>
        private String _name;

        /// <summary>
        ///     the value of the "PSG_DESCRIPTION" field.
        /// </summary>
        private String _description;

        /// <summary>
        ///     the value of the "PSG_MIN" field.
        /// </summary>
        private Byte _min;

        /// <summary>
        ///     the value of the "PSG_MAX" field.
        /// </summary>
        private Byte _max;

        /// <summary>
        ///     the value of the "PSG_ORDER" field.
        /// </summary>
        private Byte _order;

        /// <summary>
        ///     the value of the "PSG_ERROR_MESSAGE" field.
        /// </summary>
        private String _errorMessage;

        #endregion

        #region properties

        /// <summary>
        ///     the value of the "PSG_ADD_DATE" field.
        /// </summary>
        public DateTime AddDate
        {
            get { return _addDate; }
            set { _addDate = value; }
        }

        /// <summary>
        ///     the value of the "PSG_ADD_BY" field.
        /// </summary>
        public String AddBy
        {
            get { return _addBy; }
            set { _addBy = value; }
        }

        /// <summary>
        ///     the value of the "PSG_MOD_DATE" field.
        /// </summary>
        public DateTime ModDate
        {
            get { return _modDate; }
            set { _modDate = value; }
        }

        /// <summary>
        ///     the value of the "PSG_MOD_BY" field.
        /// </summary>
        public String ModBy
        {
            get { return _modBy; }
            set { _modBy = value; }
        }

        /// <summary>
        ///     the value of the "PSG_PROD_ID" field.
        /// </summary>
        public String Product
        {
            get { return _product; }
            set { _product = value; }
        }

        /// <summary>
        ///     the value of the "PSG_TYPE" field.
        /// </summary>
        public Byte Type
        {
            get { return _type; }
            set { _type = value; }
        }

        /// <summary>
        ///     the value of the "PSG_NAME" field.
        /// </summary>
        public String Name
        {
            get { return _name; }
            set { _name = value; }
        }

        /// <summary>
        ///     the value of the "PSG_DESCRIPTION" field.
        /// </summary>
        public String Description
        {
            get { return _description; }
            set { _description = value; }
        }

        /// <summary>
        ///     the value of the "PSG_MIN" field.
        /// </summary>
        public Byte Min
        {
            get { return _min; }
            set { _min = value; }
        }

        /// <summary>
        ///     the value of the "PSG_MAX" field.
        /// </summary>
        public Byte Max
        {
            get { return _max; }
            set { _max = value; }
        }

        /// <summary>
        ///     the value of the "PSG_ORDER" field.
        /// </summary>
        public Byte Order
        {
            get { return _order; }
            set { _order = value; }
        }

        /// <summary>
        ///     the value of the "PSG_ERROR_MESSAGE" field.
        /// </summary>
        public String ErrorMessage
        {
            get { return _errorMessage; }
            set { _errorMessage = value; }
        }

        #endregion

        #region methods

        /// <summary>
        ///     Creates a new <see cref="ProdselectgroupsRecord" /> object instance that is a shallow-copy of the current object instance.
        /// </summary>
        /// <returns>
        ///     The shallow-copy of the current <see cref="ProdselectgroupsRecord" /> object instance.
        /// </returns>
        public ProdselectgroupsRecord Clone()
        {
            ProdselectgroupsRecord record = new ProdselectgroupsRecord();
            record.Id = this.Id;
            record.AddDate = this.AddDate;
            record.AddBy = this.AddBy;
            record.ModDate = this.ModDate;
            record.ModBy = this.ModBy;
            record.Product = this.Product;
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
        ///     Indicates whether the current <see cref="ProdselectgroupsRecord" /> instance is equal to another <see cref="ProdselectgroupsRecord" /> instance.
        /// </summary>
        /// <param name="that">
        ///     The <see cref="ProdselectgroupsRecord" /> instance to be compared against this instance.
        /// </param>
        /// <returns>
        ///     True if both instances are considered equal; otherwise, false.
        /// </returns>
        public Boolean Equals(ProdselectgroupsRecord that)
        {
            Boolean result = true;
            result = result && (this.Id == that.Id);
            result = result && (this.Product.TrimOrNullify() == that.Product.TrimOrNullify());
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
