using System;
using System.Collections.Generic;
using System.Linq;
using Consensus.Common;
using Consensus.Security;

namespace Consensus.Reporting
{
    /// <summary>
    ///     Encapsulates the <see cref="ReportRecord" /> with standardised business rules.
    /// </summary>
    /// <remarks>
    ///     THIS CODE HAS BEEN AUTOMATICALLY GENERATED USING THE CONSENSUS DEVELOPER TOOLS.
    ///     DO NOT EDIT THIS CODE AS ANY CUSTOM MODIFICATIONS WILL BE LOST UPON REGENERATION.
    /// </remarks>
    public partial class LocalReportModel : LocalModel<ReportRecord, String>, IReportModel
    {
        #region fields

        /// <summary>
        ///     The value of the "REP_TYPE" field.
        /// </summary>
        private LocalCodeModel _type;

        /// <summary>
        ///     The value of the "REP_RPTP_ID" field.
        /// </summary>
        private LocalReportPageModel _reportPage;

        /// <summary>
        ///     The value of the "REP_RPP_ID" field.
        /// </summary>
        private LocalReportParamPageModel _reportParamPage;

        /// <summary>
        ///     The collection of <see cref="UserAccountModel" /> instances that reference this <see cref="ReportModel" />.
        /// </summary>
        private LocalCollection<LocalUserAccountModel, IUserAccountModel> _userAccountsReport;

        #endregion

        #region properties

        /// <summary>
        ///     Gets the delegated function that is responsible for persisting a new instance of the data structure within the underlying persistence mechanism.
        /// </summary>
        protected override Action<ReportRecord> DataCreator
        {
            get { return this.Provider.DataProvider.Reporting.Report.Create; }
        }

        /// <summary>
        ///     Gets the delegated function that is responsible for persisting an existing instance of the data structure within the underlying persistence mechanism.
        /// </summary>
        protected override Action<ReportRecord> DataModifier
        {
            get { return this.Provider.DataProvider.Reporting.Report.Modify; }
        }

        /// <summary>
        ///     Gets the delegated function that is responsible for removing an existing instance of the data structure from the underlying persistence mechanism.
        /// </summary>
        protected override Action<ReportRecord> DataRemover
        {
            get { return this.Provider.DataProvider.Reporting.Report.RemoveById; }
        }

        /// <summary>
        ///     Gets or sets the value of the "REP_DESCRIPTION" field.
        /// </summary>
        public String Description
        {
            get { return this.ModifiedData.Description; }
            set { this.ModifiedData.Description = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "REP_NAME" field.
        /// </summary>
        public String Name
        {
            get { return this.ModifiedData.Name; }
            set { this.ModifiedData.Name = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "REP_CAT" field.
        /// </summary>
        public String Cat
        {
            get { return this.ModifiedData.Cat; }
            set { this.ModifiedData.Cat = value; }
        }

        /// <summary>
        ///     Gets the The value of the "REP_TYPE" field.
        /// </summary>
        public LocalCodeModel Type
        {
            get
            {
                if (_type == null && !String.IsNullOrEmpty(this.TypeCode))
                    _type = this.Provider.Common.Code.FetchByTypeAndCode("REPT", this.TypeCode);
                if (_type == null)
                    _type = this.Provider.Common.Code.Create("REPT");
                return _type;
            }
        }

        /// <summary>
        ///     Gets or sets the unique code for the value of the "REP_TYPE" field.
        /// </summary>
        public String TypeCode
        {
            get { return this.ModifiedData.Type; }
            set
            {
                if (this.ModifiedData.Type != value)
                     _type = null;
                this.ModifiedData.Type = value;
            }
        }

        /// <summary>
        ///     Gets or sets the value of the "REP_LEVEL" field.
        /// </summary>
        public Byte? Level
        {
            get { return this.ModifiedData.Level; }
            set { this.ModifiedData.Level = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "REP_CONNECTION" field.
        /// </summary>
        public Byte? Connection
        {
            get { return this.ModifiedData.Connection; }
            set { this.ModifiedData.Connection = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "REP_CURRENT" field.
        /// </summary>
        public Byte Current
        {
            get { return this.ModifiedData.Current; }
            set { this.ModifiedData.Current = value; }
        }

        /// <summary>
        ///     Gets the The value of the "REP_RPTP_ID" field.
        /// </summary>
        public LocalReportPageModel ReportPage
        {
            get
            {
                if (_reportPage == null && this.ReportPageId != null)
                    _reportPage = this.Provider.Reporting.ReportPage.FetchById(this.ReportPageId.Value);
                if (_reportPage == null)
                    _reportPage = this.Provider.Reporting.ReportPage.Create();
                
                return _reportPage;
            }
        }

        /// <summary>
        ///     Gets or sets the unique code for the value of the "REP_RPTP_ID" field.
        /// </summary>
        public Int32? ReportPageId
        {
            get { return this.ModifiedData.RptpId; }
            set
            {
                if (this.ModifiedData.RptpId != value)
                     _reportPage = null;
                this.ModifiedData.RptpId = value;
            }
        }

        /// <summary>
        ///     Gets the The value of the "REP_RPP_ID" field.
        /// </summary>
        public LocalReportParamPageModel ReportParamPage
        {
            get
            {
                if (_reportParamPage == null && this.ReportParamPageId != null)
                    _reportParamPage = this.Provider.Reporting.ReportParamPage.FetchById(this.ReportParamPageId.Value);
                if (_reportParamPage == null)
                    _reportParamPage = this.Provider.Reporting.ReportParamPage.Create();
                
                return _reportParamPage;
            }
        }

        /// <summary>
        ///     Gets or sets the unique code for the value of the "REP_RPP_ID" field.
        /// </summary>
        public Int32? ReportParamPageId
        {
            get { return this.ModifiedData.RppId; }
            set
            {
                if (this.ModifiedData.RppId != value)
                     _reportParamPage = null;
                this.ModifiedData.RppId = value;
            }
        }

        /// <summary>
        ///     Gets or sets the value of the "REP_SYSTEM" field.
        /// </summary>
        public Byte System
        {
            get { return this.ModifiedData.System; }
            set { this.ModifiedData.System = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "REP_STANDARD" field.
        /// </summary>
        public Byte Standard
        {
            get { return this.ModifiedData.Standard; }
            set { this.ModifiedData.Standard = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "REP_SSRS_PARAMETERS" field.
        /// </summary>
        public Byte SSRSParameters
        {
            get { return this.ModifiedData.SsrsParameters; }
            set { this.ModifiedData.SsrsParameters = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "REP_PMENU_ID" field.
        /// </summary>
        public Int32? PortalMenuId
        {
            get { return this.ModifiedData.PmenuId; }
            set { this.ModifiedData.PmenuId = value; }
        }

        /// <summary>
        ///     Gets the collection of <see cref="UserAccountModel" /> instances that reference this <see cref="ReportModel" />.
        /// </summary>
        public LocalCollection<LocalUserAccountModel, IUserAccountModel> UserAccountsReport
        {
            get
            {
                if (_userAccountsReport == null)
                    _userAccountsReport = new LocalCollection<LocalUserAccountModel, IUserAccountModel>(this.Provider.Security.UserAccount.FetchAllByReportIdId(this.Id));
                
                return _userAccountsReport;
            }
        }

        #endregion

        #region constructors

        /// <summary>
        ///     Initialises a new <see cref="LocalReportModel" /> instance.
        /// </summary>
        /// <param name="provider">
        ///     The business provider to which the business model is bound.
        /// </param>
        internal LocalReportModel(LocalProvider provider) : base(provider)
        {
        }

        /// <summary>
        ///     Initialises a new <see cref="LocalReportModel" /> instance.
        /// </summary>
        /// <param name="provider">
        ///     The business provider to which the business model is bound.
        /// </param>
        /// <param name="record">
        ///     The data record which is encapsulated by the business model.
        /// </param>
        internal LocalReportModel(LocalProvider provider, ReportRecord record) : base(provider, record)
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
            if (_type != null)
            {
                _type.Save();
                this.ModifiedData.Type = _type.Value1;
            }
            if (_reportPage != null)
            {
                _reportPage.Save();
                this.ModifiedData.RptpId = _reportPage.Id;
            }
            if (_reportParamPage != null)
            {
                _reportParamPage.Save();
                this.ModifiedData.RppId = _reportParamPage.Id;
            }
        }

        /// <summary>
        ///     Resolves the dependent models by means of updating all models that reference this model.
        /// </summary>
        protected override void ResolveGeneratedDependent()
        {
            base.ResolveGeneratedDependent();
            if (_userAccountsReport != null)
                _userAccountsReport.Execute(obj => obj.ReportIdId = this.Id).Execute(obj => obj.Save());
        }

        #endregion

        #region implementations

        /// <summary>
        ///     Gets or sets the value of the "REP_DESCRIPTION" field.
        /// </summary>
        System.String IReportModel.Description
        {
            get { return this.Description; }
            set { this.Description = (System.String)value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "REP_NAME" field.
        /// </summary>
        System.String IReportModel.Name
        {
            get { return this.Name; }
            set { this.Name = (System.String)value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "REP_CAT" field.
        /// </summary>
        System.String IReportModel.Cat
        {
            get { return this.Cat; }
            set { this.Cat = (System.String)value; }
        }

        /// <summary>
        ///     Gets the The value of the "REP_TYPE" field.
        /// </summary>
        Consensus.Common.ICodeModel IReportModel.Type
        {
            get { return this.Type; }
        }

        /// <summary>
        ///     Gets or sets the unique code for the value of the "REP_TYPE" field.
        /// </summary>
        System.String IReportModel.TypeCode
        {
            get { return this.TypeCode; }
            set { this.TypeCode = (System.String)value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "REP_LEVEL" field.
        /// </summary>
        System.Nullable<System.Byte> IReportModel.Level
        {
            get { return this.Level; }
            set { this.Level = (System.Nullable<System.Byte>)value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "REP_CONNECTION" field.
        /// </summary>
        System.Nullable<System.Byte> IReportModel.Connection
        {
            get { return this.Connection; }
            set { this.Connection = (System.Nullable<System.Byte>)value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "REP_CURRENT" field.
        /// </summary>
        System.Byte IReportModel.Current
        {
            get { return this.Current; }
            set { this.Current = (System.Byte)value; }
        }

        /// <summary>
        ///     Gets the The value of the "REP_RPTP_ID" field.
        /// </summary>
        Consensus.Reporting.IReportPageModel IReportModel.ReportPage
        {
            get { return this.ReportPage; }
        }

        /// <summary>
        ///     Gets or sets the unique code for the value of the "REP_RPTP_ID" field.
        /// </summary>
        System.Nullable<System.Int32> IReportModel.ReportPageId
        {
            get { return this.ReportPageId; }
            set { this.ReportPageId = (System.Nullable<System.Int32>)value; }
        }

        /// <summary>
        ///     Gets the The value of the "REP_RPP_ID" field.
        /// </summary>
        Consensus.Reporting.IReportParamPageModel IReportModel.ReportParamPage
        {
            get { return this.ReportParamPage; }
        }

        /// <summary>
        ///     Gets or sets the unique code for the value of the "REP_RPP_ID" field.
        /// </summary>
        System.Nullable<System.Int32> IReportModel.ReportParamPageId
        {
            get { return this.ReportParamPageId; }
            set { this.ReportParamPageId = (System.Nullable<System.Int32>)value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "REP_SYSTEM" field.
        /// </summary>
        System.Byte IReportModel.System
        {
            get { return this.System; }
            set { this.System = (System.Byte)value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "REP_STANDARD" field.
        /// </summary>
        System.Byte IReportModel.Standard
        {
            get { return this.Standard; }
            set { this.Standard = (System.Byte)value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "REP_SSRS_PARAMETERS" field.
        /// </summary>
        System.Byte IReportModel.SSRSParameters
        {
            get { return this.SSRSParameters; }
            set { this.SSRSParameters = (System.Byte)value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "REP_PMENU_ID" field.
        /// </summary>
        System.Nullable<System.Int32> IReportModel.PortalMenuId
        {
            get { return this.PortalMenuId; }
            set { this.PortalMenuId = (System.Nullable<System.Int32>)value; }
        }

        /// <summary>
        ///     Gets the collection of <see cref="!:UserAccountModel" /> instances that reference this <see cref="!:ReportModel" />.
        /// </summary>
        Consensus.Collection<Consensus.Security.IUserAccountModel> IReportModel.UserAccountsReport
        {
            get { return this.UserAccountsReport; }
        }

        #endregion
    }
}
