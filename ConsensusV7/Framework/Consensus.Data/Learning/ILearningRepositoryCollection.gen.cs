using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Linq;

namespace Consensus.Learning
{
    /// <summary>
    ///     The repository collection which pertains to the Learning namespace.
    /// </summary>
    /// <remarks>
    ///     THIS CODE HAS BEEN AUTOMATICALLY GENERATED USING THE CONSENSUS DEVELOPER TOOLS.
    ///     DO NOT EDIT THIS CODE AS ANY CUSTOM MODIFICATIONS WILL BE LOST UPON REGENERATION.
    /// </remarks>
    public interface ILearningRepositoryCollection : IRepositoryCollection
    {
        /// <summary>
        ///     Gets the Microsoft SQL Server repository which persists and retrieves instances of the <see cref="T:Consensus.Learning.ProductRecord" /> data structure.
        /// </summary>
        Consensus.Learning.IProductRepository Product
        {
            get;
        }

        /// <summary>
        ///     Gets the Microsoft SQL Server repository which persists and retrieves instances of the <see cref="T:Consensus.Learning.BillOfMaterialRecord" /> data structure.
        /// </summary>
        Consensus.Learning.IBillOfMaterialRepository BillOfMaterial
        {
            get;
        }

        /// <summary>
        ///     Gets the Microsoft SQL Server repository which persists and retrieves instances of the <see cref="T:Consensus.Learning.TemplateXrefRecord" /> data structure.
        /// </summary>
        Consensus.Learning.ITemplateRepository Template
        {
            get;
        }

        /// <summary>
        ///     Gets the Microsoft SQL Server repository which persists and retrieves instances of the <see cref="T:Consensus.Learning.CourseRecord" /> data structure.
        /// </summary>
        Consensus.Learning.IEventRepository Event
        {
            get;
        }

        /// <summary>
        ///     Gets the Microsoft SQL Server repository which persists and retrieves instances of the <see cref="T:Consensus.Learning.ProductProdXrefRecord" /> data structure.
        /// </summary>
        Consensus.Learning.IRelatedProductRepository RelatedProduct
        {
            get;
        }

        /// <summary>
        ///     Gets the Microsoft SQL Server repository which persists and retrieves instances of the <see cref="T:Consensus.Learning.ProductEventRecord" /> data structure.
        /// </summary>
        Consensus.Learning.IProductEventRepository ProductEvent
        {
            get;
        }

        /// <summary>
        ///     Gets the Microsoft SQL Server repository which persists and retrieves instances of the <see cref="T:Consensus.Learning.BookingRecord" /> data structure.
        /// </summary>
        Consensus.Learning.IBookingRepository Booking
        {
            get;
        }

        /// <summary>
        ///     Gets the Microsoft SQL Server repository which persists and retrieves instances of the <see cref="T:Consensus.Learning.DelegateRecord" /> data structure.
        /// </summary>
        Consensus.Learning.ILearnerRepository Learner
        {
            get;
        }

        /// <summary>
        ///     Gets the Microsoft SQL Server repository which persists and retrieves instances of the <see cref="T:Consensus.Learning.ElementRecord" /> data structure.
        /// </summary>
        Consensus.Learning.IElementRepository Element
        {
            get;
        }

        /// <summary>
        ///     Gets the Microsoft SQL Server repository which persists and retrieves instances of the <see cref="T:Consensus.Learning.SessionXrefRecord" /> data structure.
        /// </summary>
        Consensus.Learning.ISessionXrefRepository SessionXref
        {
            get;
        }

        /// <summary>
        ///     Gets the Microsoft SQL Server repository which persists and retrieves instances of the <see cref="T:Consensus.Learning.CourseselectgroupsRecord" /> data structure.
        /// </summary>
        Consensus.Learning.ICourseSelectGroupsRepository CourseSelectGroups
        {
            get;
        }

        /// <summary>
        ///     Gets the Microsoft SQL Server repository which persists and retrieves instances of the <see cref="T:Consensus.Learning.EventProductRecord" /> data structure.
        /// </summary>
        Consensus.Learning.IEventProductRepository EventProduct
        {
            get;
        }

        /// <summary>
        ///     Gets the Microsoft SQL Server repository which persists and retrieves instances of the <see cref="T:Consensus.Learning.ProdselectgroupsRecord" /> data structure.
        /// </summary>
        Consensus.Learning.IProdSelectGroupRepository ProdSelectGroup
        {
            get;
        }
    }
}
