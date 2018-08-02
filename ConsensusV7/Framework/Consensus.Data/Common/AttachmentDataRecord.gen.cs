using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Linq;

namespace Consensus.Common
{
    /// <summary>
    ///     Represents the "Attachment_Data" data structure.
    /// </summary>
    /// <remarks>
    ///     THIS CODE HAS BEEN AUTOMATICALLY GENERATED USING THE CONSENSUS DEVELOPER TOOLS.
    ///     DO NOT EDIT THIS CODE AS ANY CUSTOM MODIFICATIONS WILL BE LOST UPON REGENERATION.
    /// </remarks>
    public class AttachmentDataRecord : Record<Int32>, Cloneable<AttachmentDataRecord>, IEquatable<AttachmentDataRecord>
    {
        #region fields

        /// <summary>
        ///     the value of the "ATTD_ATT_ID" field.
        /// </summary>
        private String _attId;

        /// <summary>
        ///     the value of the "ATTD_VERSION_NO" field.
        /// </summary>
        private Double? _versionNo;

        /// <summary>
        ///     the value of the "ATTD_BINARY" field.
        /// </summary>
        private Byte[] _binary;

        /// <summary>
        ///     the value of the "ATTD_TEXT" field.
        /// </summary>
        private String _text;

        #endregion

        #region properties

        /// <summary>
        ///     the value of the "ATTD_ATT_ID" field.
        /// </summary>
        public String AttId
        {
            get { return _attId; }
            set { _attId = value; }
        }

        /// <summary>
        ///     the value of the "ATTD_VERSION_NO" field.
        /// </summary>
        public Double? VersionNo
        {
            get { return _versionNo; }
            set { _versionNo = value; }
        }

        /// <summary>
        ///     the value of the "ATTD_BINARY" field.
        /// </summary>
        public Byte[] Binary
        {
            get { return _binary; }
            set { _binary = value; }
        }

        /// <summary>
        ///     the value of the "ATTD_TEXT" field.
        /// </summary>
        public String Text
        {
            get { return _text; }
            set { _text = value; }
        }

        #endregion

        #region methods

        /// <summary>
        ///     Creates a new <see cref="AttachmentDataRecord" /> object instance that is a shallow-copy of the current object instance.
        /// </summary>
        /// <returns>
        ///     The shallow-copy of the current <see cref="AttachmentDataRecord" /> object instance.
        /// </returns>
        public AttachmentDataRecord Clone()
        {
            AttachmentDataRecord record = new AttachmentDataRecord();
            record.Id = this.Id;
            record.AttId = this.AttId;
            record.VersionNo = this.VersionNo;
            record.Binary = this.Binary;
            record.Text = this.Text;
            return record;
        }

        /// <summary>
        ///     Indicates whether the current <see cref="AttachmentDataRecord" /> instance is equal to another <see cref="AttachmentDataRecord" /> instance.
        /// </summary>
        /// <param name="that">
        ///     The <see cref="AttachmentDataRecord" /> instance to be compared against this instance.
        /// </param>
        /// <returns>
        ///     True if both instances are considered equal; otherwise, false.
        /// </returns>
        public Boolean Equals(AttachmentDataRecord that)
        {
            Boolean result = true;
            result = result && (this.Id == that.Id);
            result = result && (this.AttId.TrimOrNullify() == that.AttId.TrimOrNullify());
            result = result && (this.VersionNo == that.VersionNo);
            result = result && (this.Binary == that.Binary);
            result = result && (this.Text.TrimOrNullify() == that.Text.TrimOrNullify());
            return result;
        }

        #endregion
    }
}
