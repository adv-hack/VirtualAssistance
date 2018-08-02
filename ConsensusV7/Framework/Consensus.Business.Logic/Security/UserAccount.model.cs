using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;

namespace Consensus.Security
{
    /// <summary>
    ///     Represents Represents an individual user.
    /// </summary>
    public partial class LocalUserAccountModel
    {
        #region fields

        /// <summary>
        ///     The new password that will be assigned to the user.
        /// </summary>
        private String _newPassword;

        #endregion

        #region properties

        /// <summary>
        ///     Gets whether the underlying data has been modified since instantiation.
        /// </summary>
        public override Boolean IsModified
        {
            get
            {
                return base.IsModified || !String.IsNullOrEmpty(_newPassword);
            }
        }

        /// <summary>
        ///     Gets or sets the name of the user.
        /// </summary>
        public String Username
        {
            get { return this.Principal.Name; }
            set { this.Principal.Name = value; }
        }

        /// <summary>
        ///     Sets the users new password.
        /// </summary>
        public String Password
        {
            set
            {
                if (!String.IsNullOrEmpty(value) && !value.All(chr => chr == '*'))
                {
                    Byte[] hash;
                    
                    // Compute a hash of the current salt and the new password
                    LocalUserCredentialModel credential = this.Credentials.OrderBy(cred => cred.Modified).LastOrDefault();

                    if (credential != null)
                    {
                        Byte[] pass = Encoding.UTF8.GetBytes(value);
                        Byte[] data = credential.Salt.Concat(pass).ToArray();
                        using (SHA512CryptoServiceProvider provider = new SHA512CryptoServiceProvider())
                            hash = provider.ComputeHash(data);

                        // If the hash does not match the existing hash, a new password is being set
                        if (!credential.Pass.SequenceEqual(hash))
                            _newPassword = value;
                    }
                    else
                    {
                        _newPassword = value;
                    }
                }
            }
        }

        #endregion

        #region methods

        private IEnumerable<LocalUserPrincipalModel> GetPrincipalHierarchy(LocalUserPrincipalModel principal)
        {
            IEnumerable<LocalUserPrincipalModel> result = new LocalUserPrincipalModel[] { principal };
            foreach (LocalUserGroupMemberModel member in principal.UserGroupMemberships)
                result = result.Concat(GetPrincipalHierarchy(member.Group.Principal));

            return result;
        }

        public Boolean HasPermission<Type>(Enum permission)
        {
            // Get the permission applicable to this principal and, recursively, the groups that this account is a member of.
            Boolean?[] permissions = this.GetPrincipalHierarchy(this.Principal).Select(principal => this.HasPermission<Type>(principal, permission)).ToArray();

            // If any of the permissions are set to false (deny), return false.
            if (permissions.Contains(false))
                return false;

            // If not, and any of the permissions are set to true (allow), return true.
            if (permissions.Contains(true))
                return true;

            // No permissions have been provided for this type/action - assume false.
            return false;
        }

        private Boolean? HasPermission<T>(LocalUserPrincipalModel principal, Enum permission)
        {
            // Get the interface to which permissions are applied
            Type runtimeType = typeof(T).IsInterface ? typeof(T) : typeof(T).GetInterfaces().Except(typeof(T).GetInterfaces().SelectMany(iface => iface.GetInterfaces())).FirstOrDefault();
            if (runtimeType == null && typeof(T).BaseType.GetGenericArguments().Length != 0 && typeof(T).BaseType.GetGenericArguments()[0].GetInterfaces().Any(iface => iface == typeof(IModel)))
                runtimeType = typeof(T).BaseType.GetGenericArguments()[0].IsInterface ? typeof(T).BaseType.GetGenericArguments()[0] : typeof(T).BaseType.GetGenericArguments()[0].GetInterfaces().Except(typeof(T).BaseType.GetGenericArguments()[0].GetInterfaces().SelectMany(iface => iface.GetInterfaces())).FirstOrDefault();

            // Get the permission set for the specified type (this will be null for types linked to an unlicensed module)
            String typeName = String.Format("{0}.{1}", runtimeType.Namespace, runtimeType.Name.Substring(1, runtimeType.Name.Length - 6));
            UserPermissionSet permissionSet = principal.PermissionSets.FirstOrDefault(ps => String.Equals(ps.FullName, typeName, StringComparison.OrdinalIgnoreCase));
            if (permissionSet == null)
                return false;

            // Get the permission information that matches the specified permission (this will be null for types that do not support the specified permission)
            UserPermissionType permissionType = permissionSet.Permissions.FirstOrDefault(pt => String.Equals(pt.Type, permission.GetType().Name, StringComparison.OrdinalIgnoreCase) && pt.Number == permission.ConvertTo<Int32>());
            if (permissionType == null)
                return false;

            // Return the permission setting
            return permissionType.Value;
        }

        protected override void ResolveDependent()
        {
            if (!String.IsNullOrEmpty(_newPassword))
            {
                Byte[] hash;
                Byte[] salt = new Byte[64];
                Byte[] pass = Encoding.UTF8.GetBytes(_newPassword);

                // Generate a cryptographically-secure random salting value.
                using (RNGCryptoServiceProvider provider = new RNGCryptoServiceProvider())
                    provider.GetBytes(salt);

                // Generate a one-way digest from the salt and password
                Byte[] data = salt.Concat(pass).ToArray();
                using (SHA512CryptoServiceProvider provider = new SHA512CryptoServiceProvider())
                    hash = provider.ComputeHash(data);

                // Create a new credential and add to the collection
                LocalUserCredentialModel credential = this.Provider.Security.UserCredential.Create();
                credential.Modified = DateTime.Now;
                credential.Pass = hash;
                credential.Salt = salt;
                this.Credentials.Add(credential);
            }

            base.ResolveDependent();
        }

        #endregion
    }
}
