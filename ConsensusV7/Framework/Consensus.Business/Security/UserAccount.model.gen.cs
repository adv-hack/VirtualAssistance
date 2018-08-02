using System;
using System.Collections.Generic;
using System.Linq;
using Consensus.Common;
using Consensus.Contact;
using Consensus.Reporting;
using Consensus.UserInterface;

namespace Consensus.Security
{
    /// <summary>
    ///     Represents represents an individual user.
    /// </summary>
    /// <remarks>
    ///     THIS CODE HAS BEEN AUTOMATICALLY GENERATED USING THE CONSENSUS DEVELOPER TOOLS.
    ///     DO NOT EDIT THIS CODE AS ANY CUSTOM MODIFICATIONS WILL BE LOST UPON REGENERATION.
    /// </remarks>
    public interface IUserAccountModel : IModel<Int32>
    {
        #region properties

        /// <summary>
        ///     Gets whether the underlying data has been modified since instantiation.
        /// </summary>
        System.Boolean IsModified
        {
            get;
        }

        /// <summary>
        ///     Gets or sets the name of the user.
        /// </summary>
        System.String Username
        {
            get;
            set;
        }

        /// <summary>
        ///     Sets the users new password.
        /// </summary>
        System.String Password
        {
            set;
        }

        /// <summary>
        ///     Gets the The security principal referenced by the account.
        /// </summary>
        Consensus.Security.IUserPrincipalModel Principal
        {
            get;
        }

        /// <summary>
        ///     Gets or sets the unique code for The security principal referenced by the account.
        /// </summary>
        System.Int32 PrincipalId
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets the The value of the "USER_PERSON_ID" field.
        /// </summary>
        Consensus.Contact.IPersonModel Person
        {
            get;
        }

        /// <summary>
        ///     Gets or sets the unique code for the value of the "USER_PERSON_ID" field.
        /// </summary>
        System.String PersonId
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets the The selling company settings applied to the user.
        /// </summary>
        Consensus.Common.ISellingCompanyModel SellingCompany
        {
            get;
        }

        /// <summary>
        ///     Gets or sets the unique code for The selling company settings applied to the user.
        /// </summary>
        System.String SellingCompanyId
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets or sets The enumerated status of the user account.
        /// </summary>
        System.Int32 Status
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets or sets The number of login attempts that have failed since the user last logged on successfully.
        /// </summary>
        System.Int32 FailCount
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets or sets The date and time of the last successful authentication.
        /// </summary>
        System.Nullable<System.DateTime> LastLogin
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets or sets The name of the authentication provider.
        /// </summary>
        System.String AuthenticationProvider
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets or sets Sys admin flag.
        /// </summary>
        System.Nullable<System.Byte> SysAdmin
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets or sets Determines whether user is  in Pool A or Pool B.
        /// </summary>
        System.Int32 LicenseType
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets the It's use for set the Home page dashboard report id.
        /// </summary>
        Consensus.Reporting.IReportModel ReportId
        {
            get;
        }

        /// <summary>
        ///     Gets or sets the unique code for It's use for set the Home page dashboard report id.
        /// </summary>
        System.String ReportIdId
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets the collection of <see cref="!:QuickAccessLinkModel" /> instances that reference this <see cref="!:UserAccountModel" />.
        /// </summary>
        Consensus.Collection<Consensus.UserInterface.IQuickAccessLinkModel> QuickAccessLinks
        {
            get;
        }

        /// <summary>
        ///     Gets the collection of <see cref="!:HistoryLinkModel" /> instances that reference this <see cref="!:UserAccountModel" />.
        /// </summary>
        Consensus.Collection<Consensus.UserInterface.IHistoryLinkModel> HistoryLinks
        {
            get;
        }

        /// <summary>
        ///     Gets the collection of <see cref="!:UserCredentialModel" /> instances that reference this <see cref="!:UserAccountModel" />.
        /// </summary>
        Consensus.Collection<Consensus.Security.IUserCredentialModel> Credentials
        {
            get;
        }

        /// <summary>
        ///     Gets the collection of <see cref="!:UserSessionModel" /> instances that reference this <see cref="!:UserAccountModel" />.
        /// </summary>
        Consensus.Collection<Consensus.Security.IUserSessionModel> UserSessions
        {
            get;
        }

        #endregion

        #region methods

        System.Boolean HasPermission<Type>(System.Enum permission);

        #endregion
    }
}
