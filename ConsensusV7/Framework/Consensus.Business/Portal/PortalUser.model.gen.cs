using System;
using System.Collections.Generic;
using System.Linq;
using Consensus.Common;
using Consensus.Contact;

namespace Consensus.Portal
{
    /// <summary>
    ///     Encapsulates the <see cref="PortalUserRecord" /> data structure.
    /// </summary>
    /// <remarks>
    ///     THIS CODE HAS BEEN AUTOMATICALLY GENERATED USING THE CONSENSUS DEVELOPER TOOLS.
    ///     DO NOT EDIT THIS CODE AS ANY CUSTOM MODIFICATIONS WILL BE LOST UPON REGENERATION.
    /// </remarks>
    public interface IPortalUserModel : IModel<Int32>
    {
        #region properties

        /// <summary>
        ///     Gets or sets the new password entered from reset password screen.
        /// </summary>
        System.String NewPassword
        {
            get;
            set;
        }

        /// <summary>
        ///     sets the password.
        /// </summary>
        System.String Password
        {
            set;
        }

        System.Boolean IsModified
        {
            get;
        }

        /// <summary>
        ///     Gets the The value of the "PU_PROLE_ID" field.
        /// </summary>
        Consensus.Contact.IRoleModel PersonRole
        {
            get;
        }

        /// <summary>
        ///     Gets or sets the unique code for the value of the "PU_PROLE_ID" field.
        /// </summary>
        System.String PersonRoleId
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets or sets the value of the "PU_LOGIN_ID" field.
        /// </summary>
        System.String LoginId
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets or sets the value of the "PU_BARRED" field.
        /// </summary>
        System.Nullable<System.Byte> Barred
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets or sets the value of the "PU_NTUSERNAME" field.
        /// </summary>
        System.String Ntusername
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets the The value of the "PU_SELCO_SP_ID" field.
        /// </summary>
        Consensus.Common.ISellingCompanyModel SellingCompany
        {
            get;
        }

        /// <summary>
        ///     Gets or sets the unique code for the value of the "PU_SELCO_SP_ID" field.
        /// </summary>
        System.String SellingCompanyId
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets or sets the value of the "PU_FIRST_LOGIN" field.
        /// </summary>
        System.Nullable<System.DateTime> FirstLogin
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets or sets the value of the "PU_LAST_LOGIN" field.
        /// </summary>
        System.Nullable<System.DateTime> LastLogin
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets or sets the value of the "PU_AUTH_PROVIDER" field.
        /// </summary>
        System.String AuthProvider
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets the collection of <see cref="!:PortalUserSiteModel" /> instances that reference this <see cref="!:PortalUserModel" />.
        /// </summary>
        Consensus.Collection<Consensus.Portal.IPortalUserSiteModel> PortalUserSites
        {
            get;
        }

        /// <summary>
        ///     Gets the collection of <see cref="!:PortalUserRoleModel" /> instances that reference this <see cref="!:PortalUserModel" />.
        /// </summary>
        Consensus.Collection<Consensus.Portal.IPortalUserRoleModel> PortalUserRoles
        {
            get;
        }

        #endregion

        #region methods

        void UpdateUserRoles(System.Collections.ArrayList portaluserRoles);

        void UpdateUserPortals(System.Collections.ArrayList portaluserPortals);

        #endregion
    }
}
