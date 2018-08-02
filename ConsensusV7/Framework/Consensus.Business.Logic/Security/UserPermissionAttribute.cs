using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Consensus.Security
{
    [AttributeUsage(AttributeTargets.Class)]
    public class UserPermissionAttribute : Attribute
    {
        #region fields

        /// <summary>
        ///     The standardised permissions that are available for this data type.
        /// </summary>
        private UserPermissionActions[] _permissions;

        /// <summary>
        ///     The type of enumeration which defines custom permissions.
        /// </summary>
        private Type _enumeration;

        #endregion

        #region properties

        /// <summary>
        ///    Gets the standardised permissions that are available for this data type.
        /// </summary>
        public Enum[] Permissions
        {
            get
            {
                IEnumerable<Enum> permissions = _permissions.OfType<Enum>();
                if (_enumeration != null)
                    permissions = permissions.Concat(Enum.GetValues(_enumeration).OfType<Enum>());

                return permissions.ToArray();
            }
        }

        #endregion

        #region constructor

        /// <summary>
        ///     Specifies standard permissions that are available for this data type.
        /// </summary>
        /// <param name="permissions">
        ///     Sets the standardised permissions that are available for this data type.
        /// </param>
        public UserPermissionAttribute(params UserPermissionActions[] permissions) : this(null, permissions)
        {
        }

        /// <summary>
        ///     Specifies custom permissions that are available for this data type.
        /// </summary>
        /// <param name="enumeration">
        ///     Sets the type of enumeration which defines custom permissions.
        /// </param>
        public UserPermissionAttribute(Type enumeration) : this(enumeration, UserPermissionActions.Read, UserPermissionActions.Create, UserPermissionActions.Modify, UserPermissionActions.Remove)
        {
        }

        /// <summary>
        ///     Specifies a mix of standard and custom permissions that are available for this data type.
        /// </summary>
        /// <param name="enumeration">
        ///     Sets the type of enumeration which defines custom permissions.
        /// </param>
        /// <param name="permissions">
        ///     Sets the standardised permissions that are available for this data type.
        /// </param>
        public UserPermissionAttribute(Type enumeration, params UserPermissionActions[] permissions)
        {
            _enumeration = enumeration;
            _permissions = permissions;
        }

        #endregion
    }
}
