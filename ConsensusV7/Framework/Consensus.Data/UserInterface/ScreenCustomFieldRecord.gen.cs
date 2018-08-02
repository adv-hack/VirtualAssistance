using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Linq;

namespace Consensus.UserInterface
{
    /// <summary>
    ///     Represents the "Screen_Custom_Field" data structure.
    /// </summary>
    /// <remarks>
    ///     THIS CODE HAS BEEN AUTOMATICALLY GENERATED USING THE CONSENSUS DEVELOPER TOOLS.
    ///     DO NOT EDIT THIS CODE AS ANY CUSTOM MODIFICATIONS WILL BE LOST UPON REGENERATION.
    /// </remarks>
    public class ScreenCustomFieldRecord : Record<Int32>, Cloneable<ScreenCustomFieldRecord>, IEquatable<ScreenCustomFieldRecord>
    {
        #region fields

        /// <summary>
        ///     the value of the "CFIELD_ADD_DATE" field.
        /// </summary>
        private DateTime _addDate;

        /// <summary>
        ///     the value of the "CFIELD_ADD_BY" field.
        /// </summary>
        private String _addBy;

        /// <summary>
        ///     the value of the "CFIELD_MOD_DATE" field.
        /// </summary>
        private DateTime _modDate;

        /// <summary>
        ///     the value of the "CFIELD_MOD_BY" field.
        /// </summary>
        private String _modBy;

        /// <summary>
        ///     the value of the "CFIELD_URL" field.
        /// </summary>
        private String _url;

        /// <summary>
        ///     the value of the "CFIELD_PARENT_CONTROL" field.
        /// </summary>
        private String _parentControl;

        /// <summary>
        ///     the value of the "CFIELD_NAME" field.
        /// </summary>
        private String _name;

        /// <summary>
        ///     the value of the "CFIELD_LABEL" field.
        /// </summary>
        private String _label;

        /// <summary>
        ///     the value of the "CFIELD_CFTYPE_ID" field.
        /// </summary>
        private String _cftypeId;

        /// <summary>
        ///     the value of the "CFIELD_POPUP_URL" field.
        /// </summary>
        private String _popupUrl;

        /// <summary>
        ///     the value of the "CFIELD_DECIMALS" field.
        /// </summary>
        private Int32? _decimals;

        /// <summary>
        ///     the value of the "CFIELD_PAGE" field.
        /// </summary>
        private String _page;

        /// <summary>
        ///     the value of the "CFIELD_TABLE" field.
        /// </summary>
        private String _table;

        #endregion

        #region properties

        /// <summary>
        ///     the value of the "CFIELD_ADD_DATE" field.
        /// </summary>
        public DateTime AddDate
        {
            get { return _addDate; }
            set { _addDate = value; }
        }

        /// <summary>
        ///     the value of the "CFIELD_ADD_BY" field.
        /// </summary>
        public String AddBy
        {
            get { return _addBy; }
            set { _addBy = value; }
        }

        /// <summary>
        ///     the value of the "CFIELD_MOD_DATE" field.
        /// </summary>
        public DateTime ModDate
        {
            get { return _modDate; }
            set { _modDate = value; }
        }

        /// <summary>
        ///     the value of the "CFIELD_MOD_BY" field.
        /// </summary>
        public String ModBy
        {
            get { return _modBy; }
            set { _modBy = value; }
        }

        /// <summary>
        ///     the value of the "CFIELD_URL" field.
        /// </summary>
        public String Url
        {
            get { return _url; }
            set { _url = value; }
        }

        /// <summary>
        ///     the value of the "CFIELD_PARENT_CONTROL" field.
        /// </summary>
        public String ParentControl
        {
            get { return _parentControl; }
            set { _parentControl = value; }
        }

        /// <summary>
        ///     the value of the "CFIELD_NAME" field.
        /// </summary>
        public String Name
        {
            get { return _name; }
            set { _name = value; }
        }

        /// <summary>
        ///     the value of the "CFIELD_LABEL" field.
        /// </summary>
        public String Label
        {
            get { return _label; }
            set { _label = value; }
        }

        /// <summary>
        ///     the value of the "CFIELD_CFTYPE_ID" field.
        /// </summary>
        public String CftypeId
        {
            get { return _cftypeId; }
            set { _cftypeId = value; }
        }

        /// <summary>
        ///     the value of the "CFIELD_POPUP_URL" field.
        /// </summary>
        public String PopupUrl
        {
            get { return _popupUrl; }
            set { _popupUrl = value; }
        }

        /// <summary>
        ///     the value of the "CFIELD_DECIMALS" field.
        /// </summary>
        public Int32? Decimals
        {
            get { return _decimals; }
            set { _decimals = value; }
        }

        /// <summary>
        ///     the value of the "CFIELD_PAGE" field.
        /// </summary>
        public String Page
        {
            get { return _page; }
            set { _page = value; }
        }

        /// <summary>
        ///     the value of the "CFIELD_TABLE" field.
        /// </summary>
        public String Table
        {
            get { return _table; }
            set { _table = value; }
        }

        #endregion

        #region methods

        /// <summary>
        ///     Creates a new <see cref="ScreenCustomFieldRecord" /> object instance that is a shallow-copy of the current object instance.
        /// </summary>
        /// <returns>
        ///     The shallow-copy of the current <see cref="ScreenCustomFieldRecord" /> object instance.
        /// </returns>
        public ScreenCustomFieldRecord Clone()
        {
            ScreenCustomFieldRecord record = new ScreenCustomFieldRecord();
            record.Id = this.Id;
            record.AddDate = this.AddDate;
            record.AddBy = this.AddBy;
            record.ModDate = this.ModDate;
            record.ModBy = this.ModBy;
            record.Url = this.Url;
            record.ParentControl = this.ParentControl;
            record.Name = this.Name;
            record.Label = this.Label;
            record.CftypeId = this.CftypeId;
            record.PopupUrl = this.PopupUrl;
            record.Decimals = this.Decimals;
            record.Page = this.Page;
            record.Table = this.Table;
            return record;
        }

        /// <summary>
        ///     Indicates whether the current <see cref="ScreenCustomFieldRecord" /> instance is equal to another <see cref="ScreenCustomFieldRecord" /> instance.
        /// </summary>
        /// <param name="that">
        ///     The <see cref="ScreenCustomFieldRecord" /> instance to be compared against this instance.
        /// </param>
        /// <returns>
        ///     True if both instances are considered equal; otherwise, false.
        /// </returns>
        public Boolean Equals(ScreenCustomFieldRecord that)
        {
            Boolean result = true;
            result = result && (this.Id == that.Id);
            result = result && (this.Url.TrimOrNullify() == that.Url.TrimOrNullify());
            result = result && (this.ParentControl.TrimOrNullify() == that.ParentControl.TrimOrNullify());
            result = result && (this.Name.TrimOrNullify() == that.Name.TrimOrNullify());
            result = result && (this.Label.TrimOrNullify() == that.Label.TrimOrNullify());
            result = result && (this.CftypeId.TrimOrNullify() == that.CftypeId.TrimOrNullify());
            result = result && (this.PopupUrl.TrimOrNullify() == that.PopupUrl.TrimOrNullify());
            result = result && (this.Decimals == that.Decimals);
            result = result && (this.Page.TrimOrNullify() == that.Page.TrimOrNullify());
            result = result && (this.Table.TrimOrNullify() == that.Table.TrimOrNullify());
            return result;
        }

        #endregion
    }
}
