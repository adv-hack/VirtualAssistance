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
    ///     Represents Represents an individual user.
    /// </summary>
    /// <remarks>
    ///     THIS CODE HAS BEEN AUTOMATICALLY GENERATED USING THE CONSENSUS DEVELOPER TOOLS.
    ///     DO NOT EDIT THIS CODE AS ANY CUSTOM MODIFICATIONS WILL BE LOST UPON REGENERATION.
    /// </remarks>
    public partial class LocalUserAccountModel : LocalModel<UserAccountRecord, Int32>, IUserAccountModel
    {
        #region fields

        /// <summary>
        ///     The security principal referenced by the account.
        /// </summary>
        private LocalUserPrincipalModel _principal;

        /// <summary>
        ///     The value of the "USER_PERSON_ID" field.
        /// </summary>
        private LocalPersonModel _person;

        /// <summary>
        ///     The selling company settings applied to the user.
        /// </summary>
        private LocalSellingCompanyModel _sellingCompany;

        /// <summary>
        ///     It's use for set the Home page dashboard report id.
        /// </summary>
        private LocalReportModel _reportId;

        /// <summary>
        ///     The collection of <see cref="QuickAccessLinkModel" /> instances that reference this <see cref="UserAccountModel" />.
        /// </summary>
        private LocalCollection<LocalQuickAccessLinkModel, IQuickAccessLinkModel> _quickAccessLinks;

        /// <summary>
        ///     The collection of <see cref="HistoryLinkModel" /> instances that reference this <see cref="UserAccountModel" />.
        /// </summary>
        private LocalCollection<LocalHistoryLinkModel, IHistoryLinkModel> _historyLinks;

        /// <summary>
        ///     The collection of <see cref="UserCredentialModel" /> instances that reference this <see cref="UserAccountModel" />.
        /// </summary>
        private LocalCollection<LocalUserCredentialModel, IUserCredentialModel> _credentials;

        /// <summary>
        ///     The collection of <see cref="UserSessionModel" /> instances that reference this <see cref="UserAccountModel" />.
        /// </summary>
        private LocalCollection<LocalUserSessionModel, IUserSessionModel> _userSessions;

        #endregion

        #region properties

        /// <summary>
        ///     Gets the delegated function that is responsible for persisting a new instance of the data structure within the underlying persistence mechanism.
        /// </summary>
        protected override Action<UserAccountRecord> DataCreator
        {
            get { return this.Provider.DataProvider.Security.UserAccount.Create; }
        }

        /// <summary>
        ///     Gets the delegated function that is responsible for persisting an existing instance of the data structure within the underlying persistence mechanism.
        /// </summary>
        protected override Action<UserAccountRecord> DataModifier
        {
            get { return this.Provider.DataProvider.Security.UserAccount.Modify; }
        }

        /// <summary>
        ///     Gets the delegated function that is responsible for removing an existing instance of the data structure from the underlying persistence mechanism.
        /// </summary>
        protected override Action<UserAccountRecord> DataRemover
        {
            get { return this.Provider.DataProvider.Security.UserAccount.RemoveById; }
        }

        /// <summary>
        ///     Gets the The security principal referenced by the account.
        /// </summary>
        public LocalUserPrincipalModel Principal
        {
            get
            {
                if (_principal == null)
                    _principal = this.Provider.Security.UserPrincipal.FetchById(this.PrincipalId);
                if (_principal == null)
                    _principal = this.Provider.Security.UserPrincipal.Create();
                
                return _principal;
            }
        }

        /// <summary>
        ///     Gets or sets the unique code for The security principal referenced by the account.
        /// </summary>
        public Int32 PrincipalId
        {
            get { return this.ModifiedData.PrincipalId; }
            set
            {
                if (this.ModifiedData.PrincipalId != value)
                     _principal = null;
                this.ModifiedData.PrincipalId = value;
            }
        }

        /// <summary>
        ///     Gets the The value of the "USER_PERSON_ID" field.
        /// </summary>
        public LocalPersonModel Person
        {
            get
            {
                if (_person == null)
                    _person = this.Provider.Contact.Person.FetchById(this.PersonId);
                if (_person == null)
                    _person = this.Provider.Contact.Person.Create();
                
                return _person;
            }
        }

        /// <summary>
        ///     Gets or sets the unique code for the value of the "USER_PERSON_ID" field.
        /// </summary>
        public String PersonId
        {
            get { return this.ModifiedData.PersonId; }
            set
            {
                if (this.ModifiedData.PersonId != value)
                     _person = null;
                this.ModifiedData.PersonId = value;
            }
        }

        /// <summary>
        ///     Gets the The selling company settings applied to the user.
        /// </summary>
        public LocalSellingCompanyModel SellingCompany
        {
            get
            {
                if (_sellingCompany == null)
                    _sellingCompany = this.Provider.Common.SellingCompany.FetchById(this.SellingCompanyId);
                if (_sellingCompany == null)
                    _sellingCompany = this.Provider.Common.SellingCompany.Create();
                
                return _sellingCompany;
            }
        }

        /// <summary>
        ///     Gets or sets the unique code for The selling company settings applied to the user.
        /// </summary>
        public String SellingCompanyId
        {
            get { return this.ModifiedData.SelcoId; }
            set
            {
                if (this.ModifiedData.SelcoId != value)
                     _sellingCompany = null;
                this.ModifiedData.SelcoId = value;
            }
        }

        /// <summary>
        ///     Gets or sets The enumerated status of the user account.
        /// </summary>
        public Int32 Status
        {
            get { return this.ModifiedData.Status; }
            set { this.ModifiedData.Status = value; }
        }

        /// <summary>
        ///     Gets or sets The number of login attempts that have failed since the user last logged on successfully.
        /// </summary>
        public Int32 FailCount
        {
            get { return this.ModifiedData.FailCount; }
            set { this.ModifiedData.FailCount = value; }
        }

        /// <summary>
        ///     Gets or sets The date and time of the last successful authentication.
        /// </summary>
        public DateTime? LastLogin
        {
            get { return this.ModifiedData.LastLogin; }
            set { this.ModifiedData.LastLogin = value; }
        }

        /// <summary>
        ///     Gets or sets The name of the authentication provider.
        /// </summary>
        public String AuthenticationProvider
        {
            get { return this.ModifiedData.Provider; }
            set { this.ModifiedData.Provider = value; }
        }

        /// <summary>
        ///     Gets or sets Sys admin flag.
        /// </summary>
        public Byte? SysAdmin
        {
            get { return this.ModifiedData.SysAdmin; }
            set { this.ModifiedData.SysAdmin = value; }
        }

        /// <summary>
        ///     Gets or sets Determines whether user is  in Pool A or Pool B.
        /// </summary>
        public Int32 LicenseType
        {
            get { return this.ModifiedData.LicenseType; }
            set { this.ModifiedData.LicenseType = value; }
        }

        /// <summary>
        ///     Gets the It's use for set the Home page dashboard report id.
        /// </summary>
        public LocalReportModel ReportId
        {
            get
            {
                if (_reportId == null && this.ReportIdId != null)
                    _reportId = this.Provider.Reporting.Report.FetchById(this.ReportIdId);
                if (_reportId == null)
                    _reportId = this.Provider.Reporting.Report.Create();
                
                return _reportId;
            }
        }

        /// <summary>
        ///     Gets or sets the unique code for It's use for set the Home page dashboard report id.
        /// </summary>
        public String ReportIdId
        {
            get { return this.ModifiedData.RepId; }
            set
            {
                if (this.ModifiedData.RepId != value)
                     _reportId = null;
                this.ModifiedData.RepId = value;
            }
        }

        /// <summary>
        ///     Gets the collection of <see cref="QuickAccessLinkModel" /> instances that reference this <see cref="UserAccountModel" />.
        /// </summary>
        public LocalCollection<LocalQuickAccessLinkModel, IQuickAccessLinkModel> QuickAccessLinks
        {
            get
            {
                if (_quickAccessLinks == null)
                    _quickAccessLinks = new LocalCollection<LocalQuickAccessLinkModel, IQuickAccessLinkModel>(this.Provider.UserInterface.QuickAccessLink.FetchAllByUserId(this.Id));
                
                return _quickAccessLinks;
            }
        }

        /// <summary>
        ///     Gets the collection of <see cref="HistoryLinkModel" /> instances that reference this <see cref="UserAccountModel" />.
        /// </summary>
        public LocalCollection<LocalHistoryLinkModel, IHistoryLinkModel> HistoryLinks
        {
            get
            {
                if (_historyLinks == null)
                    _historyLinks = new LocalCollection<LocalHistoryLinkModel, IHistoryLinkModel>(this.Provider.UserInterface.HistoryLink.FetchAllByUserId(this.Id));
                
                return _historyLinks;
            }
        }

        /// <summary>
        ///     Gets the collection of <see cref="UserCredentialModel" /> instances that reference this <see cref="UserAccountModel" />.
        /// </summary>
        public LocalCollection<LocalUserCredentialModel, IUserCredentialModel> Credentials
        {
            get
            {
                if (_credentials == null)
                    _credentials = new LocalCollection<LocalUserCredentialModel, IUserCredentialModel>(this.Provider.Security.UserCredential.FetchAllByUserId(this.Id));
                
                return _credentials;
            }
        }

        /// <summary>
        ///     Gets the collection of <see cref="UserSessionModel" /> instances that reference this <see cref="UserAccountModel" />.
        /// </summary>
        public LocalCollection<LocalUserSessionModel, IUserSessionModel> UserSessions
        {
            get
            {
                if (_userSessions == null)
                    _userSessions = new LocalCollection<LocalUserSessionModel, IUserSessionModel>(this.Provider.Security.UserSession.FetchAllByUserId(this.Id));
                
                return _userSessions;
            }
        }

        #endregion

        #region constructors

        /// <summary>
        ///     Initialises a new <see cref="LocalUserAccountModel" /> instance.
        /// </summary>
        /// <param name="provider">
        ///     The business provider to which the business model is bound.
        /// </param>
        internal LocalUserAccountModel(LocalProvider provider) : base(provider)
        {
        }

        /// <summary>
        ///     Initialises a new <see cref="LocalUserAccountModel" /> instance.
        /// </summary>
        /// <param name="provider">
        ///     The business provider to which the business model is bound.
        /// </param>
        /// <param name="record">
        ///     The data record which is encapsulated by the business model.
        /// </param>
        internal LocalUserAccountModel(LocalProvider provider, UserAccountRecord record) : base(provider, record)
        {
        }

        #endregion

        #region methods

        /// <summary>
        ///     Resolves the dependencies by means of persisting all models that this model is referencing.
        /// </summary>
        protected override void ResolveGeneratedDependency()
        {
            base.ResolveGeneratedDependency();
            if (_principal != null)
            {
                _principal.Save();
                this.ModifiedData.PrincipalId = _principal.Id;
            }
            if (_person != null)
            {
                _person.Save();
                this.ModifiedData.PersonId = _person.Id == null && this.ModifiedData.PersonId != null ? "" : _person.Id;
            }
            if (_sellingCompany != null)
            {
                _sellingCompany.Save();
                this.ModifiedData.SelcoId = _sellingCompany.Id == null && this.ModifiedData.SelcoId != null ? "" : _sellingCompany.Id;
            }
            if (_reportId != null)
            {
                _reportId.Save();
                this.ModifiedData.RepId = _reportId.Id == null && this.ModifiedData.RepId != null ? "" : _reportId.Id;
            }
        }

        /// <summary>
        ///     Resolves the dependent models by means of updating all models that reference this model.
        /// </summary>
        protected override void ResolveGeneratedDependent()
        {
            base.ResolveGeneratedDependent();
            if (_quickAccessLinks != null)
                _quickAccessLinks.Execute(obj => obj.UserId = this.Id).Execute(obj => obj.Save());
            if (_historyLinks != null)
                _historyLinks.Execute(obj => obj.UserId = this.Id).Execute(obj => obj.Save());
            if (_credentials != null)
                _credentials.Execute(obj => obj.UserId = this.Id).Execute(obj => obj.Save());
            if (_userSessions != null)
                _userSessions.Execute(obj => obj.UserId = this.Id).Execute(obj => obj.Save());
        }

        #endregion

        #region implementations

        /// <summary>
        ///     Gets whether the underlying data has been modified since instantiation.
        /// </summary>
        System.Boolean IUserAccountModel.IsModified
        {
            get { return this.IsModified; }
        }

        /// <summary>
        ///     Gets or sets the name of the user.
        /// </summary>
        System.String IUserAccountModel.Username
        {
            get { return this.Username; }
            set { this.Username = (System.String)value; }
        }

        /// <summary>
        ///     Sets the users new password.
        /// </summary>
        System.String IUserAccountModel.Password
        {
            set { this.Password = (System.String)value; }
        }

        /// <summary>
        ///     Gets the The security principal referenced by the account.
        /// </summary>
        Consensus.Security.IUserPrincipalModel IUserAccountModel.Principal
        {
            get { return this.Principal; }
        }

        /// <summary>
        ///     Gets or sets the unique code for The security principal referenced by the account.
        /// </summary>
        System.Int32 IUserAccountModel.PrincipalId
        {
            get { return this.PrincipalId; }
            set { this.PrincipalId = (System.Int32)value; }
        }

        /// <summary>
        ///     Gets the The value of the "USER_PERSON_ID" field.
        /// </summary>
        Consensus.Contact.IPersonModel IUserAccountModel.Person
        {
            get { return this.Person; }
        }

        /// <summary>
        ///     Gets or sets the unique code for the value of the "USER_PERSON_ID" field.
        /// </summary>
        System.String IUserAccountModel.PersonId
        {
            get { return this.PersonId; }
            set { this.PersonId = (System.String)value; }
        }

        /// <summary>
        ///     Gets the The selling company settings applied to the user.
        /// </summary>
        Consensus.Common.ISellingCompanyModel IUserAccountModel.SellingCompany
        {
            get { return this.SellingCompany; }
        }

        /// <summary>
        ///     Gets or sets the unique code for The selling company settings applied to the user.
        /// </summary>
        System.String IUserAccountModel.SellingCompanyId
        {
            get { return this.SellingCompanyId; }
            set { this.SellingCompanyId = (System.String)value; }
        }

        /// <summary>
        ///     Gets or sets The enumerated status of the user account.
        /// </summary>
        System.Int32 IUserAccountModel.Status
        {
            get { return this.Status; }
            set { this.Status = (System.Int32)value; }
        }

        /// <summary>
        ///     Gets or sets The number of login attempts that have failed since the user last logged on successfully.
        /// </summary>
        System.Int32 IUserAccountModel.FailCount
        {
            get { return this.FailCount; }
            set { this.FailCount = (System.Int32)value; }
        }

        /// <summary>
        ///     Gets or sets The date and time of the last successful authentication.
        /// </summary>
        System.Nullable<System.DateTime> IUserAccountModel.LastLogin
        {
            get { return this.LastLogin; }
            set { this.LastLogin = (System.Nullable<System.DateTime>)value; }
        }

        /// <summary>
        ///     Gets or sets The name of the authentication provider.
        /// </summary>
        System.String IUserAccountModel.AuthenticationProvider
        {
            get { return this.AuthenticationProvider; }
            set { this.AuthenticationProvider = (System.String)value; }
        }

        /// <summary>
        ///     Gets or sets Sys admin flag.
        /// </summary>
        System.Nullable<System.Byte> IUserAccountModel.SysAdmin
        {
            get { return this.SysAdmin; }
            set { this.SysAdmin = (System.Nullable<System.Byte>)value; }
        }

        /// <summary>
        ///     Gets or sets Determines whether user is  in Pool A or Pool B.
        /// </summary>
        System.Int32 IUserAccountModel.LicenseType
        {
            get { return this.LicenseType; }
            set { this.LicenseType = (System.Int32)value; }
        }

        /// <summary>
        ///     Gets the It's use for set the Home page dashboard report id.
        /// </summary>
        Consensus.Reporting.IReportModel IUserAccountModel.ReportId
        {
            get { return this.ReportId; }
        }

        /// <summary>
        ///     Gets or sets the unique code for It's use for set the Home page dashboard report id.
        /// </summary>
        System.String IUserAccountModel.ReportIdId
        {
            get { return this.ReportIdId; }
            set { this.ReportIdId = (System.String)value; }
        }

        /// <summary>
        ///     Gets the collection of <see cref="!:QuickAccessLinkModel" /> instances that reference this <see cref="!:UserAccountModel" />.
        /// </summary>
        Consensus.Collection<Consensus.UserInterface.IQuickAccessLinkModel> IUserAccountModel.QuickAccessLinks
        {
            get { return this.QuickAccessLinks; }
        }

        /// <summary>
        ///     Gets the collection of <see cref="!:HistoryLinkModel" /> instances that reference this <see cref="!:UserAccountModel" />.
        /// </summary>
        Consensus.Collection<Consensus.UserInterface.IHistoryLinkModel> IUserAccountModel.HistoryLinks
        {
            get { return this.HistoryLinks; }
        }

        /// <summary>
        ///     Gets the collection of <see cref="!:UserCredentialModel" /> instances that reference this <see cref="!:UserAccountModel" />.
        /// </summary>
        Consensus.Collection<Consensus.Security.IUserCredentialModel> IUserAccountModel.Credentials
        {
            get { return this.Credentials; }
        }

        /// <summary>
        ///     Gets the collection of <see cref="!:UserSessionModel" /> instances that reference this <see cref="!:UserAccountModel" />.
        /// </summary>
        Consensus.Collection<Consensus.Security.IUserSessionModel> IUserAccountModel.UserSessions
        {
            get { return this.UserSessions; }
        }

        System.Boolean IUserAccountModel.HasPermission<Type>(System.Enum permission)
        {
            return this.HasPermission<Type>(permission);
        }

        #endregion
    }
}
