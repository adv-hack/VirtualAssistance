using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace Consensus.Security
{
    /// <summary>
    ///     Represents Represents a user identity.
    /// </summary>
    public partial class LocalUserPrincipalModel
    {
        #region fields

        /// <summary>
        ///     The collection of runtime type permissions.
        /// </summary>
        private UserPermissionSet[] _permissionSets;

        #endregion

        #region properties

        /// <summary>
        ///     Gets the display name for the principal.
        /// </summary>
        public String DisplayName
        {
            get
            {
                String displayName = null;
                if (this.PrincipalType == UserPrincipalTypes.User)
                {
                    LocalUserAccountModel account = this.UserAccounts.FirstOrDefault();
                    if (account != null && account.Person != null)
                        displayName = account.Person.FullName.TrimOrNullify();
                }

                return displayName ?? this.Name;
            }
        }

        /// <summary>
        ///     Gets the type of security principal
        /// </summary>
        public UserPrincipalTypes PrincipalType
        {
            get
            {
                if (this.UserAccounts.Count != 0)
                    return UserPrincipalTypes.User;
                if (this.UserGroups.Count != 0)
                    return UserPrincipalTypes.Group;

                return UserPrincipalTypes.Unknown;

            }
        }

        /// <summary>
        ///    Gets the collection of runtime type permissions.
        /// </summary>
        public UserPermissionSet[] PermissionSets
        {
            get
            {
                if (_permissionSets == null)
                    _permissionSets = this.GetPermissions().ToArray();

                return _permissionSets;
            }
        }

        #endregion

        #region methods

        private IEnumerable<UserPermissionSet> GetPermissions()
        {
            // Identify all of the modules that are currently available under the software license.
            LicenseModules[] licensedModules = this.Provider.Security.License.GetCurrent().Modules.Where(mod => mod.Enabled).Select(mod => mod.Module).ToArray();

            // Identify all of the runtime types that are derived from the <see cref="LocalModel" /> type.
            Type[] types = typeof(LocalModel).Assembly.GetTypes().Where(type => !type.IsAbstract && type.IsSubclassOf(typeof(LocalModel))).ToArray();
            foreach (Type type in types)
            {
                // Identify all of the modules that the type is restricted to.
                LicenseModules[] modules = type.GetCustomAttributes(false).OfType<LicenseModuleRestrictionAttribute>().SelectMany(attr => attr.Modules).ToArray();
                modules = (modules.Length == 0) ? new LicenseModules[] { LicenseModules.Core } : modules;

                // Validate that at least one of the modules is enabled under the software license.
                modules = modules.Intersect(licensedModules).ToArray();
                if (modules.Length != 0)
                {
                    UserPermissionSet permissionSet = new UserPermissionSet(modules.First(), type);

                    // Iterate through the permissions that are applicable to the runtime type.
                    UserPermissionAttribute[] attributes = type.GetCustomAttributes(false).OfType<UserPermissionAttribute>().ToArray();
                    Enum[] permissions = attributes.Length == 0 ? Enum.GetValues(typeof(UserPermissionActions)).OfType<Enum>().ToArray() : attributes.SelectMany(attr => attr.Permissions).ToArray();
                    foreach (Enum permission in permissions)
                    {
                        UserPermissionType permissionType = new UserPermissionType();
                        permissionType.Type = permission.GetType().Name;
                        permissionType.Name = permission.ConvertTo<String>();
                        permissionType.Number = permission.ConvertTo<Int32>();

                        // Apply the permissions saved against the current security principal.
                        LocalUserPermissionModel dbPermission = this.Permissions.FirstOrDefault(perm => String.Equals(permissionSet.FullName, perm.DataType, StringComparison.OrdinalIgnoreCase) && Int32.Equals(permissionType.Number, perm.Action));
                        if (dbPermission != null)
                        {
                            permissionType.Id = dbPermission.Id;
                            permissionType.Value = dbPermission.Allow;
                        }
                        permissionSet.Permissions.Add(permissionType);
                    }

                    yield return permissionSet;                    
                }
            }

        }

        public void SetPermissions(ArrayList permissionSets)
        {
            // Update the in-memory collection of permissions
            foreach (Dictionary<String, Object> permissionSet in permissionSets)
            {
                UserPermissionSet principalPermissionSet = this.PermissionSets.FirstOrDefault(ps => ps.FullName == permissionSet["FullName"].ConvertTo<String>());
                if (principalPermissionSet != null)
                {
                    ArrayList permissionTypes = permissionSet["Permissions"] as ArrayList;
                    foreach (Dictionary<String, Object> permissionType in permissionTypes)
                    {
                        UserPermissionType principalPermissionType = principalPermissionSet.Permissions.FirstOrDefault(pt => pt.Number == permissionType["Number"].ConvertTo<Int32>());
                        if (principalPermissionType != null)
                            principalPermissionType.Value = permissionType["Value"].ConvertTo<Boolean?>();
                    }
                }
            }

            // Apply the changes to the underlying database
            foreach (UserPermissionSet principalPermissionSet in this.PermissionSets)
            {
                foreach (UserPermissionType principalPermissionType in principalPermissionSet.Permissions)
                {
                    if (principalPermissionType.Id == 0 && principalPermissionType.Value != null)
                    {
                        LocalUserPermissionModel model = new LocalUserPermissionModel(this.Provider) { PrincipalId = this.Id, DataType = principalPermissionSet.FullName, Action = principalPermissionType.Number, Allow = principalPermissionType.Value.Value };
                        model.Save();
                    } 
                    if (principalPermissionType.Id != 0 && principalPermissionType.Value == null)
                    {
                        LocalUserPermissionModel model = this.Provider.Security.UserPermission.FetchById(principalPermissionType.Id);
                        model.Delete();
                    }
                }
            }

            _permissionSets = null;
        }

        #endregion
    }
}
