using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Linq;

namespace Consensus.Learning
{
    /// <summary>
    ///     Represents the "Product_Event" data structure.
    /// </summary>
    /// <remarks>
    ///     THIS CODE HAS BEEN AUTOMATICALLY GENERATED USING THE CONSENSUS DEVELOPER TOOLS.
    ///     DO NOT EDIT THIS CODE AS ANY CUSTOM MODIFICATIONS WILL BE LOST UPON REGENERATION.
    /// </remarks>
    public class ProductEventRecord : Record<Int32>, Cloneable<ProductEventRecord>, IEquatable<ProductEventRecord>
    {
        #region fields

        /// <summary>
        ///     the value of the "PE_ADD_BY" field.
        /// </summary>
        private String _addBy;

        /// <summary>
        ///     the value of the "PE_ADD_DATE" field.
        /// </summary>
        private DateTime? _addDate;

        /// <summary>
        ///     the value of the "PE_MOD_BY" field.
        /// </summary>
        private String _modBy;

        /// <summary>
        ///     the value of the "PE_MOD_DATE" field.
        /// </summary>
        private DateTime? _modDate;

        /// <summary>
        ///     the value of the "PE_RCV_FROM" field.
        /// </summary>
        private String _rcvFrom;

        /// <summary>
        ///     the value of the "PE_RCV_DATE" field.
        /// </summary>
        private DateTime? _rcvDate;

        /// <summary>
        ///     the value of the "PE_PROD_ID" field.
        /// </summary>
        private String _prodId;

        /// <summary>
        ///     the value of the "PE_INSTANCE" field.
        /// </summary>
        private Int32 _instance;

        /// <summary>
        ///     the value of the "PE_ACADY_CODE" field.
        /// </summary>
        private String _acadyCode;

        #endregion

        #region properties

        /// <summary>
        ///     the value of the "PE_ADD_BY" field.
        /// </summary>
        public String AddBy
        {
            get { return _addBy; }
            set { _addBy = value; }
        }

        /// <summary>
        ///     the value of the "PE_ADD_DATE" field.
        /// </summary>
        public DateTime? AddDate
        {
            get { return _addDate; }
            set { _addDate = value; }
        }

        /// <summary>
        ///     the value of the "PE_MOD_BY" field.
        /// </summary>
        public String ModBy
        {
            get { return _modBy; }
            set { _modBy = value; }
        }

        /// <summary>
        ///     the value of the "PE_MOD_DATE" field.
        /// </summary>
        public DateTime? ModDate
        {
            get { return _modDate; }
            set { _modDate = value; }
        }

        /// <summary>
        ///     the value of the "PE_RCV_FROM" field.
        /// </summary>
        public String RcvFrom
        {
            get { return _rcvFrom; }
            set { _rcvFrom = value; }
        }

        /// <summary>
        ///     the value of the "PE_RCV_DATE" field.
        /// </summary>
        public DateTime? RcvDate
        {
            get { return _rcvDate; }
            set { _rcvDate = value; }
        }

        /// <summary>
        ///     the value of the "PE_PROD_ID" field.
        /// </summary>
        public String ProdId
        {
            get { return _prodId; }
            set { _prodId = value; }
        }

        /// <summary>
        ///     the value of the "PE_INSTANCE" field.
        /// </summary>
        public Int32 Instance
        {
            get { return _instance; }
            set { _instance = value; }
        }

        /// <summary>
        ///     the value of the "PE_ACADY_CODE" field.
        /// </summary>
        public String AcadyCode
        {
            get { return _acadyCode; }
            set { _acadyCode = value; }
        }

        #endregion

        #region methods

        /// <summary>
        ///     Creates a new <see cref="ProductEventRecord" /> object instance that is a shallow-copy of the current object instance.
        /// </summary>
        /// <returns>
        ///     The shallow-copy of the current <see cref="ProductEventRecord" /> object instance.
        /// </returns>
        public ProductEventRecord Clone()
        {
            ProductEventRecord record = new ProductEventRecord();
            record.Id = this.Id;
            record.AddBy = this.AddBy;
            record.AddDate = this.AddDate;
            record.ModBy = this.ModBy;
            record.ModDate = this.ModDate;
            record.RcvFrom = this.RcvFrom;
            record.RcvDate = this.RcvDate;
            record.ProdId = this.ProdId;
            record.Instance = this.Instance;
            record.AcadyCode = this.AcadyCode;
            return record;
        }

        /// <summary>
        ///     Indicates whether the current <see cref="ProductEventRecord" /> instance is equal to another <see cref="ProductEventRecord" /> instance.
        /// </summary>
        /// <param name="that">
        ///     The <see cref="ProductEventRecord" /> instance to be compared against this instance.
        /// </param>
        /// <returns>
        ///     True if both instances are considered equal; otherwise, false.
        /// </returns>
        public Boolean Equals(ProductEventRecord that)
        {
            Boolean result = true;
            result = result && (this.Id == that.Id);
            result = result && (this.ProdId.TrimOrNullify() == that.ProdId.TrimOrNullify());
            result = result && (this.Instance == that.Instance);
            result = result && (this.AcadyCode.TrimOrNullify() == that.AcadyCode.TrimOrNullify());
            return result;
        }

        #endregion
    }
}
