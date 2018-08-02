using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Linq;

namespace Consensus.Learning
{
    /// <summary>
    ///     Represents the "Product_Prod_Xref" data structure.
    /// </summary>
    /// <remarks>
    ///     THIS CODE HAS BEEN AUTOMATICALLY GENERATED USING THE CONSENSUS DEVELOPER TOOLS.
    ///     DO NOT EDIT THIS CODE AS ANY CUSTOM MODIFICATIONS WILL BE LOST UPON REGENERATION.
    /// </remarks>
    public class ProductProdXrefRecord : Record<Int32>, Cloneable<ProductProdXrefRecord>, IEquatable<ProductProdXrefRecord>
    {
        #region fields

        /// <summary>
        ///     the value of the "PPX_ADD_BY" field.
        /// </summary>
        private String _addBy;

        /// <summary>
        ///     the value of the "PPX_ADD_DATE" field.
        /// </summary>
        private DateTime? _addDate;

        /// <summary>
        ///     the value of the "PPX_MOD_BY" field.
        /// </summary>
        private String _modBy;

        /// <summary>
        ///     the value of the "PPX_MOD_DATE" field.
        /// </summary>
        private DateTime? _modDate;

        /// <summary>
        ///     the value of the "PPX_RCV_FROM" field.
        /// </summary>
        private String _rcvFrom;

        /// <summary>
        ///     the value of the "PPX_RCV_DATE" field.
        /// </summary>
        private DateTime? _rcvDate;

        /// <summary>
        ///     the value of the "PPX_MAST_PROD_ID" field.
        /// </summary>
        private String _mastProdId;

        /// <summary>
        ///     the value of the "PPX_SIM_PROD_ID" field.
        /// </summary>
        private String _relatedProdId;

        /// <summary>
        ///     the value of the "PPX_NOTES" field.
        /// </summary>
        private String _notes;

        /// <summary>
        ///     the value of the "PPX_PREREQ" field.
        /// </summary>
        private Byte _prereq;

        /// <summary>
        ///     the value of the "PPX_SCHN_ID" field.
        /// </summary>
        private String _schnId;

        #endregion

        #region properties

        /// <summary>
        ///     the value of the "PPX_ADD_BY" field.
        /// </summary>
        public String AddBy
        {
            get { return _addBy; }
            set { _addBy = value; }
        }

        /// <summary>
        ///     the value of the "PPX_ADD_DATE" field.
        /// </summary>
        public DateTime? AddDate
        {
            get { return _addDate; }
            set { _addDate = value; }
        }

        /// <summary>
        ///     the value of the "PPX_MOD_BY" field.
        /// </summary>
        public String ModBy
        {
            get { return _modBy; }
            set { _modBy = value; }
        }

        /// <summary>
        ///     the value of the "PPX_MOD_DATE" field.
        /// </summary>
        public DateTime? ModDate
        {
            get { return _modDate; }
            set { _modDate = value; }
        }

        /// <summary>
        ///     the value of the "PPX_RCV_FROM" field.
        /// </summary>
        public String RcvFrom
        {
            get { return _rcvFrom; }
            set { _rcvFrom = value; }
        }

        /// <summary>
        ///     the value of the "PPX_RCV_DATE" field.
        /// </summary>
        public DateTime? RcvDate
        {
            get { return _rcvDate; }
            set { _rcvDate = value; }
        }

        /// <summary>
        ///     the value of the "PPX_MAST_PROD_ID" field.
        /// </summary>
        public String MastProdId
        {
            get { return _mastProdId; }
            set { _mastProdId = value; }
        }

        /// <summary>
        ///     the value of the "PPX_SIM_PROD_ID" field.
        /// </summary>
        public String RelatedProdId
        {
            get { return _relatedProdId; }
            set { _relatedProdId = value; }
        }

        /// <summary>
        ///     the value of the "PPX_NOTES" field.
        /// </summary>
        public String Notes
        {
            get { return _notes; }
            set { _notes = value; }
        }

        /// <summary>
        ///     the value of the "PPX_PREREQ" field.
        /// </summary>
        public Byte Prereq
        {
            get { return _prereq; }
            set { _prereq = value; }
        }

        /// <summary>
        ///     the value of the "PPX_SCHN_ID" field.
        /// </summary>
        public String SchnId
        {
            get { return _schnId; }
            set { _schnId = value; }
        }

        #endregion

        #region methods

        /// <summary>
        ///     Creates a new <see cref="ProductProdXrefRecord" /> object instance that is a shallow-copy of the current object instance.
        /// </summary>
        /// <returns>
        ///     The shallow-copy of the current <see cref="ProductProdXrefRecord" /> object instance.
        /// </returns>
        public ProductProdXrefRecord Clone()
        {
            ProductProdXrefRecord record = new ProductProdXrefRecord();
            record.Id = this.Id;
            record.AddBy = this.AddBy;
            record.AddDate = this.AddDate;
            record.ModBy = this.ModBy;
            record.ModDate = this.ModDate;
            record.RcvFrom = this.RcvFrom;
            record.RcvDate = this.RcvDate;
            record.MastProdId = this.MastProdId;
            record.RelatedProdId = this.RelatedProdId;
            record.Notes = this.Notes;
            record.Prereq = this.Prereq;
            record.SchnId = this.SchnId;
            return record;
        }

        /// <summary>
        ///     Indicates whether the current <see cref="ProductProdXrefRecord" /> instance is equal to another <see cref="ProductProdXrefRecord" /> instance.
        /// </summary>
        /// <param name="that">
        ///     The <see cref="ProductProdXrefRecord" /> instance to be compared against this instance.
        /// </param>
        /// <returns>
        ///     True if both instances are considered equal; otherwise, false.
        /// </returns>
        public Boolean Equals(ProductProdXrefRecord that)
        {
            Boolean result = true;
            result = result && (this.Id == that.Id);
            result = result && (this.MastProdId.TrimOrNullify() == that.MastProdId.TrimOrNullify());
            result = result && (this.RelatedProdId.TrimOrNullify() == that.RelatedProdId.TrimOrNullify());
            result = result && (this.Notes.TrimOrNullify() == that.Notes.TrimOrNullify());
            result = result && (this.Prereq == that.Prereq);
            result = result && (this.SchnId.TrimOrNullify() == that.SchnId.TrimOrNullify());
            return result;
        }

        #endregion
    }
}
