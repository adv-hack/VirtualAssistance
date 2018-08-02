using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Linq;

namespace Consensus.Security
{
    /// <summary>
    ///     Represents the "User_Principal" data structure.
    /// </summary>
    /// <remarks>
    ///     THIS CODE HAS BEEN AUTOMATICALLY GENERATED USING THE CONSENSUS DEVELOPER TOOLS.
    ///     DO NOT EDIT THIS CODE AS ANY CUSTOM MODIFICATIONS WILL BE LOST UPON REGENERATION.
    /// </remarks>
    public class UserPrincipalRecord : Record<Int32>, Cloneable<UserPrincipalRecord>, IEquatable<UserPrincipalRecord>
    {
        #region fields

        /// <summary>
        ///     the name of the security principal.
        /// </summary>
        private String _name;

        #endregion

        #region properties

        /// <summary>
        ///     the name of the security principal.
        /// </summary>
        public String Name
        {
            get { return _name; }
            set { _name = value; }
        }

        #endregion

        #region methods

        /// <summary>
        ///     Creates a new <see cref="UserPrincipalRecord" /> object instance that is a shallow-copy of the current object instance.
        /// </summary>
        /// <returns>
        ///     The shallow-copy of the current <see cref="UserPrincipalRecord" /> object instance.
        /// </returns>
        public UserPrincipalRecord Clone()
        {
            UserPrincipalRecord record = new UserPrincipalRecord();
            record.Id = this.Id;
            record.Name = this.Name;
            return record;
        }

        /// <summary>
        ///     Indicates whether the current <see cref="UserPrincipalRecord" /> instance is equal to another <see cref="UserPrincipalRecord" /> instance.
        /// </summary>
        /// <param name="that">
        ///     The <see cref="UserPrincipalRecord" /> instance to be compared against this instance.
        /// </param>
        /// <returns>
        ///     True if both instances are considered equal; otherwise, false.
        /// </returns>
        public Boolean Equals(UserPrincipalRecord that)
        {
            Boolean result = true;
            result = result && (this.Id == that.Id);
            result = result && (this.Name.TrimOrNullify() == that.Name.TrimOrNullify());
            return result;
        }

        #endregion
    }
}
