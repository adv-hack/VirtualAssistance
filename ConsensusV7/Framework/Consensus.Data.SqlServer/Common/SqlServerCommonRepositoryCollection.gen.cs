using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Linq;

namespace Consensus.Common
{
    /// <summary>
    ///     Microsoft SQL Server repository collection which pertains to the Common namespace.
    /// </summary>
    /// <remarks>
    ///     THIS CODE HAS BEEN AUTOMATICALLY GENERATED USING THE CONSENSUS DEVELOPER TOOLS.
    ///     DO NOT EDIT THIS CODE AS ANY CUSTOM MODIFICATIONS WILL BE LOST UPON REGENERATION.
    /// </remarks>
    public partial class SqlServerCommonRepositoryCollection : SqlServerRepositoryCollection, ICommonRepositoryCollection
    {
        #region fields

        /// <summary>
        ///     The Microsoft SQL Server repository which persists and retrieves instances of the <see cref="CodeRecord" /> data structure.
        /// </summary>
        private SqlServerCodeRepository _code;

        /// <summary>
        ///     The Microsoft SQL Server repository which persists and retrieves instances of the <see cref="CodeHeaderRecord" /> data structure.
        /// </summary>
        private SqlServerCodeHeaderRepository _codeHeader;

        /// <summary>
        ///     The Microsoft SQL Server repository which persists and retrieves instances of the <see cref="ProfileRecord" /> data structure.
        /// </summary>
        private SqlServerProfileRepository _profile;

        /// <summary>
        ///     The Microsoft SQL Server repository which persists and retrieves instances of the <see cref="SysParamsRecord" /> data structure.
        /// </summary>
        private SqlServerSellingCompanyRepository _sellingCompany;

        /// <summary>
        ///     The Microsoft SQL Server repository which persists and retrieves instances of the <see cref="C4textRecord" /> data structure.
        /// </summary>
        private SqlServerNotesRepository _notes;

        /// <summary>
        ///     The Microsoft SQL Server repository which persists and retrieves instances of the <see cref="SysConfigRecord" /> data structure.
        /// </summary>
        private SqlServerSellingCompanyConfigRepository _sellingCompanyConfig;

        /// <summary>
        ///     The Microsoft SQL Server repository which persists and retrieves instances of the <see cref="GenericmodeltableRecord" /> data structure.
        /// </summary>
        private SqlServerGenericModelRepository _genericModel;

        /// <summary>
        ///     The Microsoft SQL Server repository which persists and retrieves instances of the <see cref="AttachmentRecord" /> data structure.
        /// </summary>
        private SqlServerAttachmentRepository _attachment;

        /// <summary>
        ///     The Microsoft SQL Server repository which persists and retrieves instances of the <see cref="AttachmentDataRecord" /> data structure.
        /// </summary>
        private SqlServerAttachmentDataRepository _attachmentData;

        /// <summary>
        ///     The Microsoft SQL Server repository which persists and retrieves instances of the <see cref="LearningzonecategoriesRecord" /> data structure.
        /// </summary>
        private SqlServerLearningZoneCategoriesRepository _learningZoneCategories;

        /// <summary>
        ///     The Microsoft SQL Server repository which persists and retrieves instances of the <see cref="AttachlearningzonecategoriesRecord" /> data structure.
        /// </summary>
        private SqlServerAttachLearningZoneCategoriesRepository _attachLearningZoneCategories;

        /// <summary>
        ///     The Microsoft SQL Server repository which persists and retrieves instances of the <see cref="ViewLogRecord" /> data structure.
        /// </summary>
        private SqlServerViewLogRepository _viewLog;

        /// <summary>
        ///     The Microsoft SQL Server repository which persists and retrieves instances of the <see cref="ProfileRecord" /> data structure.
        /// </summary>
        private SqlServerProfileTrainerRepository _profileTrainer;

        /// <summary>
        ///     The Microsoft SQL Server repository which persists and retrieves instances of the <see cref="ProfileRecord" /> data structure.
        /// </summary>
        private SqlServerProfileVolunteerRepository _profileVolunteer;

        /// <summary>
        ///     The Microsoft SQL Server repository which persists and retrieves instances of the <see cref="SysConfigRecord" /> data structure.
        /// </summary>
        private SqlServerSysConfigRepository _sysConfig;

        #endregion

        #region properties

        /// <summary>
        ///     Gets the Microsoft SQL Server repository which persists and retrieves instances of the <see cref="CodeRecord" /> data structure.
        /// </summary>
        public SqlServerCodeRepository Code
        {
            get
            {
                SqlServerProvider provider = this.Provider;
                OverrideProvider(typeof(SqlServerCodeRepository), ref provider);
                return SqlServerRepository.Create(provider, ref _code);
            }
        }

        /// <summary>
        ///     Gets the Microsoft SQL Server repository which persists and retrieves instances of the <see cref="CodeHeaderRecord" /> data structure.
        /// </summary>
        public SqlServerCodeHeaderRepository CodeHeader
        {
            get
            {
                SqlServerProvider provider = this.Provider;
                OverrideProvider(typeof(SqlServerCodeHeaderRepository), ref provider);
                return SqlServerRepository.Create(provider, ref _codeHeader);
            }
        }

        /// <summary>
        ///     Gets the Microsoft SQL Server repository which persists and retrieves instances of the <see cref="ProfileRecord" /> data structure.
        /// </summary>
        public SqlServerProfileRepository Profile
        {
            get
            {
                SqlServerProvider provider = this.Provider;
                OverrideProvider(typeof(SqlServerProfileRepository), ref provider);
                return SqlServerRepository.Create(provider, ref _profile);
            }
        }

        /// <summary>
        ///     Gets the Microsoft SQL Server repository which persists and retrieves instances of the <see cref="SysParamsRecord" /> data structure.
        /// </summary>
        public SqlServerSellingCompanyRepository SellingCompany
        {
            get
            {
                SqlServerProvider provider = this.Provider;
                OverrideProvider(typeof(SqlServerSellingCompanyRepository), ref provider);
                return SqlServerRepository.Create(provider, ref _sellingCompany);
            }
        }

        /// <summary>
        ///     Gets the Microsoft SQL Server repository which persists and retrieves instances of the <see cref="C4textRecord" /> data structure.
        /// </summary>
        public SqlServerNotesRepository Notes
        {
            get
            {
                SqlServerProvider provider = this.Provider;
                OverrideProvider(typeof(SqlServerNotesRepository), ref provider);
                return SqlServerRepository.Create(provider, ref _notes);
            }
        }

        /// <summary>
        ///     Gets the Microsoft SQL Server repository which persists and retrieves instances of the <see cref="SysConfigRecord" /> data structure.
        /// </summary>
        public SqlServerSellingCompanyConfigRepository SellingCompanyConfig
        {
            get
            {
                SqlServerProvider provider = this.Provider;
                OverrideProvider(typeof(SqlServerSellingCompanyConfigRepository), ref provider);
                return SqlServerRepository.Create(provider, ref _sellingCompanyConfig);
            }
        }

        /// <summary>
        ///     Gets the Microsoft SQL Server repository which persists and retrieves instances of the <see cref="GenericmodeltableRecord" /> data structure.
        /// </summary>
        public SqlServerGenericModelRepository GenericModel
        {
            get
            {
                SqlServerProvider provider = this.Provider;
                OverrideProvider(typeof(SqlServerGenericModelRepository), ref provider);
                return SqlServerRepository.Create(provider, ref _genericModel);
            }
        }

        /// <summary>
        ///     Gets the Microsoft SQL Server repository which persists and retrieves instances of the <see cref="AttachmentRecord" /> data structure.
        /// </summary>
        public SqlServerAttachmentRepository Attachment
        {
            get
            {
                SqlServerProvider provider = this.Provider;
                OverrideProvider(typeof(SqlServerAttachmentRepository), ref provider);
                return SqlServerRepository.Create(provider, ref _attachment);
            }
        }

        /// <summary>
        ///     Gets the Microsoft SQL Server repository which persists and retrieves instances of the <see cref="AttachmentDataRecord" /> data structure.
        /// </summary>
        public SqlServerAttachmentDataRepository AttachmentData
        {
            get
            {
                SqlServerProvider provider = this.Provider;
                OverrideProvider(typeof(SqlServerAttachmentDataRepository), ref provider);
                return SqlServerRepository.Create(provider, ref _attachmentData);
            }
        }

        /// <summary>
        ///     Gets the Microsoft SQL Server repository which persists and retrieves instances of the <see cref="LearningzonecategoriesRecord" /> data structure.
        /// </summary>
        public SqlServerLearningZoneCategoriesRepository LearningZoneCategories
        {
            get
            {
                SqlServerProvider provider = this.Provider;
                OverrideProvider(typeof(SqlServerLearningZoneCategoriesRepository), ref provider);
                return SqlServerRepository.Create(provider, ref _learningZoneCategories);
            }
        }

        /// <summary>
        ///     Gets the Microsoft SQL Server repository which persists and retrieves instances of the <see cref="AttachlearningzonecategoriesRecord" /> data structure.
        /// </summary>
        public SqlServerAttachLearningZoneCategoriesRepository AttachLearningZoneCategories
        {
            get
            {
                SqlServerProvider provider = this.Provider;
                OverrideProvider(typeof(SqlServerAttachLearningZoneCategoriesRepository), ref provider);
                return SqlServerRepository.Create(provider, ref _attachLearningZoneCategories);
            }
        }

        /// <summary>
        ///     Gets the Microsoft SQL Server repository which persists and retrieves instances of the <see cref="ViewLogRecord" /> data structure.
        /// </summary>
        public SqlServerViewLogRepository ViewLog
        {
            get
            {
                SqlServerProvider provider = this.Provider;
                OverrideProvider(typeof(SqlServerViewLogRepository), ref provider);
                return SqlServerRepository.Create(provider, ref _viewLog);
            }
        }

        /// <summary>
        ///     Gets the Microsoft SQL Server repository which persists and retrieves instances of the <see cref="ProfileRecord" /> data structure.
        /// </summary>
        public SqlServerProfileTrainerRepository ProfileTrainer
        {
            get
            {
                SqlServerProvider provider = this.Provider;
                OverrideProvider(typeof(SqlServerProfileTrainerRepository), ref provider);
                return SqlServerRepository.Create(provider, ref _profileTrainer);
            }
        }

        /// <summary>
        ///     Gets the Microsoft SQL Server repository which persists and retrieves instances of the <see cref="ProfileRecord" /> data structure.
        /// </summary>
        public SqlServerProfileVolunteerRepository ProfileVolunteer
        {
            get
            {
                SqlServerProvider provider = this.Provider;
                OverrideProvider(typeof(SqlServerProfileVolunteerRepository), ref provider);
                return SqlServerRepository.Create(provider, ref _profileVolunteer);
            }
        }

        /// <summary>
        ///     Gets the Microsoft SQL Server repository which persists and retrieves instances of the <see cref="SysConfigRecord" /> data structure.
        /// </summary>
        public SqlServerSysConfigRepository SysConfig
        {
            get
            {
                SqlServerProvider provider = this.Provider;
                OverrideProvider(typeof(SqlServerSysConfigRepository), ref provider);
                return SqlServerRepository.Create(provider, ref _sysConfig);
            }
        }

        #endregion

        #region methods

        /// <summary>
        ///     Partial method that can be implemented elsewhere in the partial class to allow the provider to be amended for a particular instance.
        /// </summary>
        /// <param name="SqlServerDataRepositoryType">
        ///     The type of the SqlServerDataRepository instance being created.
        /// </param>
        /// <param name="provider">
        ///     The default provider. A new provider may be assigned to this parameter in an implementation, if required.
        /// </param>
        partial void OverrideProvider(Type SqlServerDataRepositoryType, ref SqlServerProvider provider);

        #endregion

        #region implementations

        /// <summary>
        ///     Gets the Microsoft SQL Server repository which persists and retrieves instances of the <see cref="T:Consensus.Common.CodeRecord" /> data structure.
        /// </summary>
        Consensus.Common.ICodeRepository ICommonRepositoryCollection.Code
        {
            get { return this.Code; }
        }

        /// <summary>
        ///     Gets the Microsoft SQL Server repository which persists and retrieves instances of the <see cref="T:Consensus.Common.CodeHeaderRecord" /> data structure.
        /// </summary>
        Consensus.Common.ICodeHeaderRepository ICommonRepositoryCollection.CodeHeader
        {
            get { return this.CodeHeader; }
        }

        /// <summary>
        ///     Gets the Microsoft SQL Server repository which persists and retrieves instances of the <see cref="T:Consensus.Common.ProfileRecord" /> data structure.
        /// </summary>
        Consensus.Common.IProfileRepository ICommonRepositoryCollection.Profile
        {
            get { return this.Profile; }
        }

        /// <summary>
        ///     Gets the Microsoft SQL Server repository which persists and retrieves instances of the <see cref="T:Consensus.Common.SysParamsRecord" /> data structure.
        /// </summary>
        Consensus.Common.ISellingCompanyRepository ICommonRepositoryCollection.SellingCompany
        {
            get { return this.SellingCompany; }
        }

        /// <summary>
        ///     Gets the Microsoft SQL Server repository which persists and retrieves instances of the <see cref="T:Consensus.Common.C4textRecord" /> data structure.
        /// </summary>
        Consensus.Common.INotesRepository ICommonRepositoryCollection.Notes
        {
            get { return this.Notes; }
        }

        /// <summary>
        ///     Gets the Microsoft SQL Server repository which persists and retrieves instances of the <see cref="T:Consensus.Common.SysConfigRecord" /> data structure.
        /// </summary>
        Consensus.Common.ISellingCompanyConfigRepository ICommonRepositoryCollection.SellingCompanyConfig
        {
            get { return this.SellingCompanyConfig; }
        }

        /// <summary>
        ///     Gets the Microsoft SQL Server repository which persists and retrieves instances of the <see cref="T:Consensus.Common.GenericmodeltableRecord" /> data structure.
        /// </summary>
        Consensus.Common.IGenericModelRepository ICommonRepositoryCollection.GenericModel
        {
            get { return this.GenericModel; }
        }

        /// <summary>
        ///     Gets the Microsoft SQL Server repository which persists and retrieves instances of the <see cref="T:Consensus.Common.AttachmentRecord" /> data structure.
        /// </summary>
        Consensus.Common.IAttachmentRepository ICommonRepositoryCollection.Attachment
        {
            get { return this.Attachment; }
        }

        /// <summary>
        ///     Gets the Microsoft SQL Server repository which persists and retrieves instances of the <see cref="T:Consensus.Common.AttachmentDataRecord" /> data structure.
        /// </summary>
        Consensus.Common.IAttachmentDataRepository ICommonRepositoryCollection.AttachmentData
        {
            get { return this.AttachmentData; }
        }

        /// <summary>
        ///     Gets the Microsoft SQL Server repository which persists and retrieves instances of the <see cref="T:Consensus.Common.LearningzonecategoriesRecord" /> data structure.
        /// </summary>
        Consensus.Common.ILearningZoneCategoriesRepository ICommonRepositoryCollection.LearningZoneCategories
        {
            get { return this.LearningZoneCategories; }
        }

        /// <summary>
        ///     Gets the Microsoft SQL Server repository which persists and retrieves instances of the <see cref="T:Consensus.Common.AttachlearningzonecategoriesRecord" /> data structure.
        /// </summary>
        Consensus.Common.IAttachLearningZoneCategoriesRepository ICommonRepositoryCollection.AttachLearningZoneCategories
        {
            get { return this.AttachLearningZoneCategories; }
        }

        /// <summary>
        ///     Gets the Microsoft SQL Server repository which persists and retrieves instances of the <see cref="T:Consensus.Common.ViewLogRecord" /> data structure.
        /// </summary>
        Consensus.Common.IViewLogRepository ICommonRepositoryCollection.ViewLog
        {
            get { return this.ViewLog; }
        }

        /// <summary>
        ///     Gets the Microsoft SQL Server repository which persists and retrieves instances of the <see cref="T:Consensus.Common.ProfileRecord" /> data structure.
        /// </summary>
        Consensus.Common.IProfileTrainerRepository ICommonRepositoryCollection.ProfileTrainer
        {
            get { return this.ProfileTrainer; }
        }

        /// <summary>
        ///     Gets the Microsoft SQL Server repository which persists and retrieves instances of the <see cref="T:Consensus.Common.ProfileRecord" /> data structure.
        /// </summary>
        Consensus.Common.IProfileVolunteerRepository ICommonRepositoryCollection.ProfileVolunteer
        {
            get { return this.ProfileVolunteer; }
        }

        /// <summary>
        ///     Gets the Microsoft SQL Server repository which persists and retrieves instances of the <see cref="T:Consensus.Common.SysConfigRecord" /> data structure.
        /// </summary>
        Consensus.Common.ISysConfigRepository ICommonRepositoryCollection.SysConfig
        {
            get { return this.SysConfig; }
        }

        #endregion
    }
}
