using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Linq;

namespace Consensus.UserInterface
{
    /// <summary>
    ///     Represents the "Screen_Object" data structure.
    /// </summary>
    /// <remarks>
    ///     THIS CODE HAS BEEN AUTOMATICALLY GENERATED USING THE CONSENSUS DEVELOPER TOOLS.
    ///     DO NOT EDIT THIS CODE AS ANY CUSTOM MODIFICATIONS WILL BE LOST UPON REGENERATION.
    /// </remarks>
    public class ScreenObjectRecord : Record<Int32>, Cloneable<ScreenObjectRecord>, IEquatable<ScreenObjectRecord>
    {
        #region fields

        /// <summary>
        ///     the value of the "OBJ_ADD_DATE" field.
        /// </summary>
        private DateTime _addDate;

        /// <summary>
        ///     the value of the "OBJ_ADD_BY" field.
        /// </summary>
        private String _addBy;

        /// <summary>
        ///     the value of the "OBJ_MOD_DATE" field.
        /// </summary>
        private DateTime _modDate;

        /// <summary>
        ///     the value of the "OBJ_MOD_BY" field.
        /// </summary>
        private String _modBy;

        /// <summary>
        ///     the value of the "OBJ_URL" field.
        /// </summary>
        private String _url;

        /// <summary>
        ///     the value of the "OBJ_CONTROL" field.
        /// </summary>
        private String _control;

        /// <summary>
        ///     the value of the "OBJ_TITLE" field.
        /// </summary>
        private String _title;

        /// <summary>
        ///     the value of the "OBJ_ICON" field.
        /// </summary>
        private String _icon;

        /// <summary>
        ///     the value of the "OBJ_DISPLAY" field.
        /// </summary>
        private Byte _display;

        /// <summary>
        ///     the value of the "OBJ_VALIDATOR_EXPRESSION" field.
        /// </summary>
        private String _validatorExpression;

        /// <summary>
        ///     the value of the "OBJ_VALIDATOR_MESSAGE" field.
        /// </summary>
        private String _validatorMessage;

        /// <summary>
        ///     the value of the "OBJ_VALIDATOR_CRITICAL" field.
        /// </summary>
        private Boolean _validatorCritical;

        /// <summary>
        ///     the value of the "OBJ_MAX_LENGTH" field.
        /// </summary>
        private Int32 _maxLength;

        /// <summary>
        ///     the value of the "OBJ_OFF_TEXT" field.
        /// </summary>
        private String _offText;

        /// <summary>
        ///     the value of the "OBJ_OFF_COLOUR" field.
        /// </summary>
        private String _offColour;

        /// <summary>
        ///     the value of the "OBJ_ON_TEXT" field.
        /// </summary>
        private String _onText;

        /// <summary>
        ///     the value of the "OBJ_ON_COLOUR" field.
        /// </summary>
        private String _onColour;

        /// <summary>
        ///     the value of the "OBJ_REQUIREMENT" field.
        /// </summary>
        private Byte _requirement;

        /// <summary>
        ///     the value of the "OBJ_DEFAULT" field.
        /// </summary>
        private String _default;

        #endregion

        #region properties

        /// <summary>
        ///     the value of the "OBJ_ADD_DATE" field.
        /// </summary>
        public DateTime AddDate
        {
            get { return _addDate; }
            set { _addDate = value; }
        }

        /// <summary>
        ///     the value of the "OBJ_ADD_BY" field.
        /// </summary>
        public String AddBy
        {
            get { return _addBy; }
            set { _addBy = value; }
        }

        /// <summary>
        ///     the value of the "OBJ_MOD_DATE" field.
        /// </summary>
        public DateTime ModDate
        {
            get { return _modDate; }
            set { _modDate = value; }
        }

        /// <summary>
        ///     the value of the "OBJ_MOD_BY" field.
        /// </summary>
        public String ModBy
        {
            get { return _modBy; }
            set { _modBy = value; }
        }

        /// <summary>
        ///     the value of the "OBJ_URL" field.
        /// </summary>
        public String Url
        {
            get { return _url; }
            set { _url = value; }
        }

        /// <summary>
        ///     the value of the "OBJ_CONTROL" field.
        /// </summary>
        public String Control
        {
            get { return _control; }
            set { _control = value; }
        }

        /// <summary>
        ///     the value of the "OBJ_TITLE" field.
        /// </summary>
        public String Title
        {
            get { return _title; }
            set { _title = value; }
        }

        /// <summary>
        ///     the value of the "OBJ_ICON" field.
        /// </summary>
        public String Icon
        {
            get { return _icon; }
            set { _icon = value; }
        }

        /// <summary>
        ///     the value of the "OBJ_DISPLAY" field.
        /// </summary>
        public Byte Display
        {
            get { return _display; }
            set { _display = value; }
        }

        /// <summary>
        ///     the value of the "OBJ_VALIDATOR_EXPRESSION" field.
        /// </summary>
        public String ValidatorExpression
        {
            get { return _validatorExpression; }
            set { _validatorExpression = value; }
        }

        /// <summary>
        ///     the value of the "OBJ_VALIDATOR_MESSAGE" field.
        /// </summary>
        public String ValidatorMessage
        {
            get { return _validatorMessage; }
            set { _validatorMessage = value; }
        }

        /// <summary>
        ///     the value of the "OBJ_VALIDATOR_CRITICAL" field.
        /// </summary>
        public Boolean ValidatorCritical
        {
            get { return _validatorCritical; }
            set { _validatorCritical = value; }
        }

        /// <summary>
        ///     the value of the "OBJ_MAX_LENGTH" field.
        /// </summary>
        public Int32 MaxLength
        {
            get { return _maxLength; }
            set { _maxLength = value; }
        }

        /// <summary>
        ///     the value of the "OBJ_OFF_TEXT" field.
        /// </summary>
        public String OffText
        {
            get { return _offText; }
            set { _offText = value; }
        }

        /// <summary>
        ///     the value of the "OBJ_OFF_COLOUR" field.
        /// </summary>
        public String OffColour
        {
            get { return _offColour; }
            set { _offColour = value; }
        }

        /// <summary>
        ///     the value of the "OBJ_ON_TEXT" field.
        /// </summary>
        public String OnText
        {
            get { return _onText; }
            set { _onText = value; }
        }

        /// <summary>
        ///     the value of the "OBJ_ON_COLOUR" field.
        /// </summary>
        public String OnColour
        {
            get { return _onColour; }
            set { _onColour = value; }
        }

        /// <summary>
        ///     the value of the "OBJ_REQUIREMENT" field.
        /// </summary>
        public Byte Requirement
        {
            get { return _requirement; }
            set { _requirement = value; }
        }

        /// <summary>
        ///     the value of the "OBJ_DEFAULT" field.
        /// </summary>
        public String Default
        {
            get { return _default; }
            set { _default = value; }
        }

        #endregion

        #region methods

        /// <summary>
        ///     Creates a new <see cref="ScreenObjectRecord" /> object instance that is a shallow-copy of the current object instance.
        /// </summary>
        /// <returns>
        ///     The shallow-copy of the current <see cref="ScreenObjectRecord" /> object instance.
        /// </returns>
        public ScreenObjectRecord Clone()
        {
            ScreenObjectRecord record = new ScreenObjectRecord();
            record.Id = this.Id;
            record.AddDate = this.AddDate;
            record.AddBy = this.AddBy;
            record.ModDate = this.ModDate;
            record.ModBy = this.ModBy;
            record.Url = this.Url;
            record.Control = this.Control;
            record.Title = this.Title;
            record.Icon = this.Icon;
            record.Display = this.Display;
            record.ValidatorExpression = this.ValidatorExpression;
            record.ValidatorMessage = this.ValidatorMessage;
            record.ValidatorCritical = this.ValidatorCritical;
            record.MaxLength = this.MaxLength;
            record.OffText = this.OffText;
            record.OffColour = this.OffColour;
            record.OnText = this.OnText;
            record.OnColour = this.OnColour;
            record.Requirement = this.Requirement;
            record.Default = this.Default;
            return record;
        }

        /// <summary>
        ///     Indicates whether the current <see cref="ScreenObjectRecord" /> instance is equal to another <see cref="ScreenObjectRecord" /> instance.
        /// </summary>
        /// <param name="that">
        ///     The <see cref="ScreenObjectRecord" /> instance to be compared against this instance.
        /// </param>
        /// <returns>
        ///     True if both instances are considered equal; otherwise, false.
        /// </returns>
        public Boolean Equals(ScreenObjectRecord that)
        {
            Boolean result = true;
            result = result && (this.Id == that.Id);
            result = result && (this.Url.TrimOrNullify() == that.Url.TrimOrNullify());
            result = result && (this.Control.TrimOrNullify() == that.Control.TrimOrNullify());
            result = result && (this.Title.TrimOrNullify() == that.Title.TrimOrNullify());
            result = result && (this.Icon.TrimOrNullify() == that.Icon.TrimOrNullify());
            result = result && (this.Display == that.Display);
            result = result && (this.ValidatorExpression.TrimOrNullify() == that.ValidatorExpression.TrimOrNullify());
            result = result && (this.ValidatorMessage.TrimOrNullify() == that.ValidatorMessage.TrimOrNullify());
            result = result && (this.ValidatorCritical == that.ValidatorCritical);
            result = result && (this.MaxLength == that.MaxLength);
            result = result && (this.OffText.TrimOrNullify() == that.OffText.TrimOrNullify());
            result = result && (this.OffColour.TrimOrNullify() == that.OffColour.TrimOrNullify());
            result = result && (this.OnText.TrimOrNullify() == that.OnText.TrimOrNullify());
            result = result && (this.OnColour.TrimOrNullify() == that.OnColour.TrimOrNullify());
            result = result && (this.Requirement == that.Requirement);
            result = result && (this.Default.TrimOrNullify() == that.Default.TrimOrNullify());
            return result;
        }

        #endregion
    }
}
