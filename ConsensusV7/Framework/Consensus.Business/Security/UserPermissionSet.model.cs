using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Consensus.Security
{
    public class UserPermissionSet 
    {
        #region fields

        /// <summary>
        ///     The runtime type to which the permission applies.
        /// </summary>
        private Type _runtimeType;

        /// <summary>
        ///     The module used to group the permission.
        /// </summary>
        private LicenseModules _module;

        /// <summary>
        ///     The collection of permissions that apply to the security principal.
        /// </summary>
        private List<UserPermissionType> _permissions;

        #endregion

        #region properties

        /// <summary>
        ///     Gets the user friendly name for the runtime type
        /// </summary>
        public String Name
        {
            get
            {
                String name = _runtimeType.GetCustomAttributes(false).OfType<DisplayNameAttribute>().Select(attr => attr.DisplayName).FirstOrDefault();
                if (String.IsNullOrEmpty(name))
                {
                    Type type = _runtimeType.GetInterfaces().Except(_runtimeType.GetInterfaces().SelectMany(iface => iface.GetInterfaces())).FirstOrDefault();
                    name = type.Name.Substring(1, type.Name.Length - 6);
                }
                return name;
            }
        }

        /// <summary>
        ///     Gets the user friendly name for the runtime type
        /// </summary>
        public String FullName
        {
            get
            {
                Type type = _runtimeType.GetInterfaces().Except(_runtimeType.GetInterfaces().SelectMany(iface => iface.GetInterfaces())).FirstOrDefault();
                String fullName = String.Format("{0}.{1}", type.Namespace, type.Name.Substring(1, type.Name.Length - 6));
                return fullName;
            }
        }

        /// <summary>
        ///    Gets the module used to group the permission.
        /// </summary>
        public String Module
        {
            get { return _module.ToString(); }
        }

        /// <summary>
        ///    Gets the collection of permissions that apply to the security principal.
        /// </summary>
        public List<UserPermissionType> Permissions
        {
            get
            {
                if (_permissions == null)
                    _permissions = new List<UserPermissionType>();

                return _permissions;
            }
        }

        #endregion

        #region constructors

        public UserPermissionSet(LicenseModules module, Type runtimeType)
        {
            _module = module;
            _runtimeType = runtimeType;
        }

        #endregion
    }

    public class UserPermissionType
    {
        /// <summary>
        ///     The identifier for the database-persisted setting.
        /// </summary>
        public Int32 Id
        {
            get;
            set;
        }

        /// <summary>
        ///     The name of the enumerator type.
        /// </summary>
        public String Type
        {
            get;
            set;
        }

        /// <summary>
        ///     The name of the enumerator value.
        /// </summary>
        public String Name
        {
            get;
            set;
        }

        /// <summary>
        ///     The numerical equivalent of the enumerator value.
        /// </summary>
        public Int32 Number
        {
            get;
            set;
        }

        /// <summary>
        ///     The permission allow/deny value.
        /// </summary>
        public Boolean? Value
        {
            get;
            set;
        }
    }
}
