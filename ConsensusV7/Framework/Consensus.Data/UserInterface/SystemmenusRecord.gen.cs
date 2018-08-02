using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Linq;

namespace Consensus.UserInterface
{
    /// <summary>
    ///     Represents the "SystemMenus" data structure.
    /// </summary>
    /// <remarks>
    ///     THIS CODE HAS BEEN AUTOMATICALLY GENERATED USING THE CONSENSUS DEVELOPER TOOLS.
    ///     DO NOT EDIT THIS CODE AS ANY CUSTOM MODIFICATIONS WILL BE LOST UPON REGENERATION.
    /// </remarks>
    public class SystemmenusRecord : Record<Int32>, Cloneable<SystemmenusRecord>, IEquatable<SystemmenusRecord>
    {
        #region fields

        /// <summary>
        ///     the value of the "SMENU_NAME" field.
        /// </summary>
        private String _name;

        /// <summary>
        ///     the value of the "SMENU_URL" field.
        /// </summary>
        private String _url;

        /// <summary>
        ///     the value of the "SMENU_GROUP" field.
        /// </summary>
        private String _group;

        /// <summary>
        ///     the value of the "SMENU_USER_ID" field.
        /// </summary>
        private String _userId;

        /// <summary>
        ///     the value of the "SMENU_TYPE" field.
        /// </summary>
        private String _type;

        /// <summary>
        ///     the value of the "SMENU_SYSTEM" field.
        /// </summary>
        private Byte _system;

        /// <summary>
        ///     the value of the "SMENU_ICON" field.
        /// </summary>
        private String _icon;

        /// <summary>
        ///     the value of the "SMENU_RELATIVE_PATH" field.
        /// </summary>
        private String _relativePath;

        /// <summary>
        ///     the value of the "SMENU_SMENU_ID" field.
        /// </summary>
        private Int32? _smenuId;

        /// <summary>
        ///     the value of the "SMENU_NAME_ID" field.
        /// </summary>
        private String _nameId;

        /// <summary>
        ///     the value of the "SMENU_NAME_REF" field.
        /// </summary>
        private String _nameRef;

        #endregion

        #region properties

        /// <summary>
        ///     the value of the "SMENU_NAME" field.
        /// </summary>
        public String Name
        {
            get { return _name; }
            set { _name = value; }
        }

        /// <summary>
        ///     the value of the "SMENU_URL" field.
        /// </summary>
        public String Url
        {
            get { return _url; }
            set { _url = value; }
        }

        /// <summary>
        ///     the value of the "SMENU_GROUP" field.
        /// </summary>
        public String Group
        {
            get { return _group; }
            set { _group = value; }
        }

        /// <summary>
        ///     the value of the "SMENU_USER_ID" field.
        /// </summary>
        public String UserId
        {
            get { return _userId; }
            set { _userId = value; }
        }

        /// <summary>
        ///     the value of the "SMENU_TYPE" field.
        /// </summary>
        public String Type
        {
            get { return _type; }
            set { _type = value; }
        }

        /// <summary>
        ///     the value of the "SMENU_SYSTEM" field.
        /// </summary>
        public Byte System
        {
            get { return _system; }
            set { _system = value; }
        }

        /// <summary>
        ///     the value of the "SMENU_ICON" field.
        /// </summary>
        public String Icon
        {
            get { return _icon; }
            set { _icon = value; }
        }

        /// <summary>
        ///     the value of the "SMENU_RELATIVE_PATH" field.
        /// </summary>
        public String RelativePath
        {
            get { return _relativePath; }
            set { _relativePath = value; }
        }

        /// <summary>
        ///     the value of the "SMENU_SMENU_ID" field.
        /// </summary>
        public Int32? SmenuId
        {
            get { return _smenuId; }
            set { _smenuId = value; }
        }

        /// <summary>
        ///     the value of the "SMENU_NAME_ID" field.
        /// </summary>
        public String NameId
        {
            get { return _nameId; }
            set { _nameId = value; }
        }

        /// <summary>
        ///     the value of the "SMENU_NAME_REF" field.
        /// </summary>
        public String NameRef
        {
            get { return _nameRef; }
            set { _nameRef = value; }
        }

        #endregion

        #region methods

        /// <summary>
        ///     Creates a new <see cref="SystemmenusRecord" /> object instance that is a shallow-copy of the current object instance.
        /// </summary>
        /// <returns>
        ///     The shallow-copy of the current <see cref="SystemmenusRecord" /> object instance.
        /// </returns>
        public SystemmenusRecord Clone()
        {
            SystemmenusRecord record = new SystemmenusRecord();
            record.Id = this.Id;
            record.Name = this.Name;
            record.Url = this.Url;
            record.Group = this.Group;
            record.UserId = this.UserId;
            record.Type = this.Type;
            record.System = this.System;
            record.Icon = this.Icon;
            record.RelativePath = this.RelativePath;
            record.SmenuId = this.SmenuId;
            record.NameId = this.NameId;
            record.NameRef = this.NameRef;
            return record;
        }

        /// <summary>
        ///     Indicates whether the current <see cref="SystemmenusRecord" /> instance is equal to another <see cref="SystemmenusRecord" /> instance.
        /// </summary>
        /// <param name="that">
        ///     The <see cref="SystemmenusRecord" /> instance to be compared against this instance.
        /// </param>
        /// <returns>
        ///     True if both instances are considered equal; otherwise, false.
        /// </returns>
        public Boolean Equals(SystemmenusRecord that)
        {
            Boolean result = true;
            result = result && (this.Id == that.Id);
            result = result && (this.Name.TrimOrNullify() == that.Name.TrimOrNullify());
            result = result && (this.Url.TrimOrNullify() == that.Url.TrimOrNullify());
            result = result && (this.Group.TrimOrNullify() == that.Group.TrimOrNullify());
            result = result && (this.UserId.TrimOrNullify() == that.UserId.TrimOrNullify());
            result = result && (this.Type.TrimOrNullify() == that.Type.TrimOrNullify());
            result = result && (this.System == that.System);
            result = result && (this.Icon.TrimOrNullify() == that.Icon.TrimOrNullify());
            result = result && (this.RelativePath.TrimOrNullify() == that.RelativePath.TrimOrNullify());
            result = result && (this.SmenuId == that.SmenuId);
            result = result && (this.NameId.TrimOrNullify() == that.NameId.TrimOrNullify());
            result = result && (this.NameRef.TrimOrNullify() == that.NameRef.TrimOrNullify());
            return result;
        }

        #endregion
    }
}
