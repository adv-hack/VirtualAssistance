using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Linq;

namespace Consensus.Common
{
    /// <summary>
    ///     The repository collection which pertains to the Common namespace.
    /// </summary>
    /// <remarks>
    ///     THIS CODE HAS BEEN AUTOMATICALLY GENERATED USING THE CONSENSUS DEVELOPER TOOLS.
    ///     DO NOT EDIT THIS CODE AS ANY CUSTOM MODIFICATIONS WILL BE LOST UPON REGENERATION.
    /// </remarks>
    public interface ICommonRepositoryCollection : IRepositoryCollection
    {
        /// <summary>
        ///     Gets the Microsoft SQL Server repository which persists and retrieves instances of the <see cref="T:Consensus.Common.CodeRecord" /> data structure.
        /// </summary>
        Consensus.Common.ICodeRepository Code
        {
            get;
        }

        /// <summary>
        ///     Gets the Microsoft SQL Server repository which persists and retrieves instances of the <see cref="T:Consensus.Common.CodeHeaderRecord" /> data structure.
        /// </summary>
        Consensus.Common.ICodeHeaderRepository CodeHeader
        {
            get;
        }

        /// <summary>
        ///     Gets the Microsoft SQL Server repository which persists and retrieves instances of the <see cref="T:Consensus.Common.ProfileRecord" /> data structure.
        /// </summary>
        Consensus.Common.IProfileRepository Profile
        {
            get;
        }

        /// <summary>
        ///     Gets the Microsoft SQL Server repository which persists and retrieves instances of the <see cref="T:Consensus.Common.SysParamsRecord" /> data structure.
        /// </summary>
        Consensus.Common.ISellingCompanyRepository SellingCompany
        {
            get;
        }

        /// <summary>
        ///     Gets the Microsoft SQL Server repository which persists and retrieves instances of the <see cref="T:Consensus.Common.C4textRecord" /> data structure.
        /// </summary>
        Consensus.Common.INotesRepository Notes
        {
            get;
        }

        /// <summary>
        ///     Gets the Microsoft SQL Server repository which persists and retrieves instances of the <see cref="T:Consensus.Common.SysConfigRecord" /> data structure.
        /// </summary>
        Consensus.Common.ISellingCompanyConfigRepository SellingCompanyConfig
        {
            get;
        }

        /// <summary>
        ///     Gets the Microsoft SQL Server repository which persists and retrieves instances of the <see cref="T:Consensus.Common.GenericmodeltableRecord" /> data structure.
        /// </summary>
        Consensus.Common.IGenericModelRepository GenericModel
        {
            get;
        }

        /// <summary>
        ///     Gets the Microsoft SQL Server repository which persists and retrieves instances of the <see cref="T:Consensus.Common.AttachmentRecord" /> data structure.
        /// </summary>
        Consensus.Common.IAttachmentRepository Attachment
        {
            get;
        }

        /// <summary>
        ///     Gets the Microsoft SQL Server repository which persists and retrieves instances of the <see cref="T:Consensus.Common.AttachmentDataRecord" /> data structure.
        /// </summary>
        Consensus.Common.IAttachmentDataRepository AttachmentData
        {
            get;
        }

        /// <summary>
        ///     Gets the Microsoft SQL Server repository which persists and retrieves instances of the <see cref="T:Consensus.Common.LearningzonecategoriesRecord" /> data structure.
        /// </summary>
        Consensus.Common.ILearningZoneCategoriesRepository LearningZoneCategories
        {
            get;
        }

        /// <summary>
        ///     Gets the Microsoft SQL Server repository which persists and retrieves instances of the <see cref="T:Consensus.Common.AttachlearningzonecategoriesRecord" /> data structure.
        /// </summary>
        Consensus.Common.IAttachLearningZoneCategoriesRepository AttachLearningZoneCategories
        {
            get;
        }

        /// <summary>
        ///     Gets the Microsoft SQL Server repository which persists and retrieves instances of the <see cref="T:Consensus.Common.ViewLogRecord" /> data structure.
        /// </summary>
        Consensus.Common.IViewLogRepository ViewLog
        {
            get;
        }

        /// <summary>
        ///     Gets the Microsoft SQL Server repository which persists and retrieves instances of the <see cref="T:Consensus.Common.ProfileRecord" /> data structure.
        /// </summary>
        Consensus.Common.IProfileTrainerRepository ProfileTrainer
        {
            get;
        }

        /// <summary>
        ///     Gets the Microsoft SQL Server repository which persists and retrieves instances of the <see cref="T:Consensus.Common.ProfileRecord" /> data structure.
        /// </summary>
        Consensus.Common.IProfileVolunteerRepository ProfileVolunteer
        {
            get;
        }

        /// <summary>
        ///     Gets the Microsoft SQL Server repository which persists and retrieves instances of the <see cref="T:Consensus.Common.SysConfigRecord" /> data structure.
        /// </summary>
        Consensus.Common.ISysConfigRepository SysConfig
        {
            get;
        }
    }
}
