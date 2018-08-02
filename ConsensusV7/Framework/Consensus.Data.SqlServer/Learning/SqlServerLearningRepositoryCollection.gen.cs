using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Linq;

namespace Consensus.Learning
{
    /// <summary>
    ///     Microsoft SQL Server repository collection which pertains to the Learning namespace.
    /// </summary>
    /// <remarks>
    ///     THIS CODE HAS BEEN AUTOMATICALLY GENERATED USING THE CONSENSUS DEVELOPER TOOLS.
    ///     DO NOT EDIT THIS CODE AS ANY CUSTOM MODIFICATIONS WILL BE LOST UPON REGENERATION.
    /// </remarks>
    public partial class SqlServerLearningRepositoryCollection : SqlServerRepositoryCollection, ILearningRepositoryCollection
    {
        #region fields

        /// <summary>
        ///     The Microsoft SQL Server repository which persists and retrieves instances of the <see cref="ProductRecord" /> data structure.
        /// </summary>
        private SqlServerProductRepository _product;

        /// <summary>
        ///     The Microsoft SQL Server repository which persists and retrieves instances of the <see cref="BillOfMaterialRecord" /> data structure.
        /// </summary>
        private SqlServerBillOfMaterialRepository _billOfMaterial;

        /// <summary>
        ///     The Microsoft SQL Server repository which persists and retrieves instances of the <see cref="TemplateXrefRecord" /> data structure.
        /// </summary>
        private SqlServerTemplateRepository _template;

        /// <summary>
        ///     The Microsoft SQL Server repository which persists and retrieves instances of the <see cref="CourseRecord" /> data structure.
        /// </summary>
        private SqlServerEventRepository _event;

        /// <summary>
        ///     The Microsoft SQL Server repository which persists and retrieves instances of the <see cref="ProductProdXrefRecord" /> data structure.
        /// </summary>
        private SqlServerRelatedProductRepository _relatedProduct;

        /// <summary>
        ///     The Microsoft SQL Server repository which persists and retrieves instances of the <see cref="ProductEventRecord" /> data structure.
        /// </summary>
        private SqlServerProductEventRepository _productEvent;

        /// <summary>
        ///     The Microsoft SQL Server repository which persists and retrieves instances of the <see cref="BookingRecord" /> data structure.
        /// </summary>
        private SqlServerBookingRepository _booking;

        /// <summary>
        ///     The Microsoft SQL Server repository which persists and retrieves instances of the <see cref="DelegateRecord" /> data structure.
        /// </summary>
        private SqlServerLearnerRepository _learner;

        /// <summary>
        ///     The Microsoft SQL Server repository which persists and retrieves instances of the <see cref="ElementRecord" /> data structure.
        /// </summary>
        private SqlServerElementRepository _element;

        /// <summary>
        ///     The Microsoft SQL Server repository which persists and retrieves instances of the <see cref="SessionXrefRecord" /> data structure.
        /// </summary>
        private SqlServerSessionXrefRepository _sessionXref;

        /// <summary>
        ///     The Microsoft SQL Server repository which persists and retrieves instances of the <see cref="CourseselectgroupsRecord" /> data structure.
        /// </summary>
        private SqlServerCourseSelectGroupsRepository _courseSelectGroups;

        /// <summary>
        ///     The Microsoft SQL Server repository which persists and retrieves instances of the <see cref="EventProductRecord" /> data structure.
        /// </summary>
        private SqlServerEventProductRepository _eventProduct;

        /// <summary>
        ///     The Microsoft SQL Server repository which persists and retrieves instances of the <see cref="ProdselectgroupsRecord" /> data structure.
        /// </summary>
        private SqlServerProdSelectGroupRepository _prodSelectGroup;

        #endregion

        #region properties

        /// <summary>
        ///     Gets the Microsoft SQL Server repository which persists and retrieves instances of the <see cref="ProductRecord" /> data structure.
        /// </summary>
        public SqlServerProductRepository Product
        {
            get
            {
                SqlServerProvider provider = this.Provider;
                OverrideProvider(typeof(SqlServerProductRepository), ref provider);
                return SqlServerRepository.Create(provider, ref _product);
            }
        }

        /// <summary>
        ///     Gets the Microsoft SQL Server repository which persists and retrieves instances of the <see cref="BillOfMaterialRecord" /> data structure.
        /// </summary>
        public SqlServerBillOfMaterialRepository BillOfMaterial
        {
            get
            {
                SqlServerProvider provider = this.Provider;
                OverrideProvider(typeof(SqlServerBillOfMaterialRepository), ref provider);
                return SqlServerRepository.Create(provider, ref _billOfMaterial);
            }
        }

        /// <summary>
        ///     Gets the Microsoft SQL Server repository which persists and retrieves instances of the <see cref="TemplateXrefRecord" /> data structure.
        /// </summary>
        public SqlServerTemplateRepository Template
        {
            get
            {
                SqlServerProvider provider = this.Provider;
                OverrideProvider(typeof(SqlServerTemplateRepository), ref provider);
                return SqlServerRepository.Create(provider, ref _template);
            }
        }

        /// <summary>
        ///     Gets the Microsoft SQL Server repository which persists and retrieves instances of the <see cref="CourseRecord" /> data structure.
        /// </summary>
        public SqlServerEventRepository Event
        {
            get
            {
                SqlServerProvider provider = this.Provider;
                OverrideProvider(typeof(SqlServerEventRepository), ref provider);
                return SqlServerRepository.Create(provider, ref _event);
            }
        }

        /// <summary>
        ///     Gets the Microsoft SQL Server repository which persists and retrieves instances of the <see cref="ProductProdXrefRecord" /> data structure.
        /// </summary>
        public SqlServerRelatedProductRepository RelatedProduct
        {
            get
            {
                SqlServerProvider provider = this.Provider;
                OverrideProvider(typeof(SqlServerRelatedProductRepository), ref provider);
                return SqlServerRepository.Create(provider, ref _relatedProduct);
            }
        }

        /// <summary>
        ///     Gets the Microsoft SQL Server repository which persists and retrieves instances of the <see cref="ProductEventRecord" /> data structure.
        /// </summary>
        public SqlServerProductEventRepository ProductEvent
        {
            get
            {
                SqlServerProvider provider = this.Provider;
                OverrideProvider(typeof(SqlServerProductEventRepository), ref provider);
                return SqlServerRepository.Create(provider, ref _productEvent);
            }
        }

        /// <summary>
        ///     Gets the Microsoft SQL Server repository which persists and retrieves instances of the <see cref="BookingRecord" /> data structure.
        /// </summary>
        public SqlServerBookingRepository Booking
        {
            get
            {
                SqlServerProvider provider = this.Provider;
                OverrideProvider(typeof(SqlServerBookingRepository), ref provider);
                return SqlServerRepository.Create(provider, ref _booking);
            }
        }

        /// <summary>
        ///     Gets the Microsoft SQL Server repository which persists and retrieves instances of the <see cref="DelegateRecord" /> data structure.
        /// </summary>
        public SqlServerLearnerRepository Learner
        {
            get
            {
                SqlServerProvider provider = this.Provider;
                OverrideProvider(typeof(SqlServerLearnerRepository), ref provider);
                return SqlServerRepository.Create(provider, ref _learner);
            }
        }

        /// <summary>
        ///     Gets the Microsoft SQL Server repository which persists and retrieves instances of the <see cref="ElementRecord" /> data structure.
        /// </summary>
        public SqlServerElementRepository Element
        {
            get
            {
                SqlServerProvider provider = this.Provider;
                OverrideProvider(typeof(SqlServerElementRepository), ref provider);
                return SqlServerRepository.Create(provider, ref _element);
            }
        }

        /// <summary>
        ///     Gets the Microsoft SQL Server repository which persists and retrieves instances of the <see cref="SessionXrefRecord" /> data structure.
        /// </summary>
        public SqlServerSessionXrefRepository SessionXref
        {
            get
            {
                SqlServerProvider provider = this.Provider;
                OverrideProvider(typeof(SqlServerSessionXrefRepository), ref provider);
                return SqlServerRepository.Create(provider, ref _sessionXref);
            }
        }

        /// <summary>
        ///     Gets the Microsoft SQL Server repository which persists and retrieves instances of the <see cref="CourseselectgroupsRecord" /> data structure.
        /// </summary>
        public SqlServerCourseSelectGroupsRepository CourseSelectGroups
        {
            get
            {
                SqlServerProvider provider = this.Provider;
                OverrideProvider(typeof(SqlServerCourseSelectGroupsRepository), ref provider);
                return SqlServerRepository.Create(provider, ref _courseSelectGroups);
            }
        }

        /// <summary>
        ///     Gets the Microsoft SQL Server repository which persists and retrieves instances of the <see cref="EventProductRecord" /> data structure.
        /// </summary>
        public SqlServerEventProductRepository EventProduct
        {
            get
            {
                SqlServerProvider provider = this.Provider;
                OverrideProvider(typeof(SqlServerEventProductRepository), ref provider);
                return SqlServerRepository.Create(provider, ref _eventProduct);
            }
        }

        /// <summary>
        ///     Gets the Microsoft SQL Server repository which persists and retrieves instances of the <see cref="ProdselectgroupsRecord" /> data structure.
        /// </summary>
        public SqlServerProdSelectGroupRepository ProdSelectGroup
        {
            get
            {
                SqlServerProvider provider = this.Provider;
                OverrideProvider(typeof(SqlServerProdSelectGroupRepository), ref provider);
                return SqlServerRepository.Create(provider, ref _prodSelectGroup);
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
        ///     Gets the Microsoft SQL Server repository which persists and retrieves instances of the <see cref="T:Consensus.Learning.ProductRecord" /> data structure.
        /// </summary>
        Consensus.Learning.IProductRepository ILearningRepositoryCollection.Product
        {
            get { return this.Product; }
        }

        /// <summary>
        ///     Gets the Microsoft SQL Server repository which persists and retrieves instances of the <see cref="T:Consensus.Learning.BillOfMaterialRecord" /> data structure.
        /// </summary>
        Consensus.Learning.IBillOfMaterialRepository ILearningRepositoryCollection.BillOfMaterial
        {
            get { return this.BillOfMaterial; }
        }

        /// <summary>
        ///     Gets the Microsoft SQL Server repository which persists and retrieves instances of the <see cref="T:Consensus.Learning.TemplateXrefRecord" /> data structure.
        /// </summary>
        Consensus.Learning.ITemplateRepository ILearningRepositoryCollection.Template
        {
            get { return this.Template; }
        }

        /// <summary>
        ///     Gets the Microsoft SQL Server repository which persists and retrieves instances of the <see cref="T:Consensus.Learning.CourseRecord" /> data structure.
        /// </summary>
        Consensus.Learning.IEventRepository ILearningRepositoryCollection.Event
        {
            get { return this.Event; }
        }

        /// <summary>
        ///     Gets the Microsoft SQL Server repository which persists and retrieves instances of the <see cref="T:Consensus.Learning.ProductProdXrefRecord" /> data structure.
        /// </summary>
        Consensus.Learning.IRelatedProductRepository ILearningRepositoryCollection.RelatedProduct
        {
            get { return this.RelatedProduct; }
        }

        /// <summary>
        ///     Gets the Microsoft SQL Server repository which persists and retrieves instances of the <see cref="T:Consensus.Learning.ProductEventRecord" /> data structure.
        /// </summary>
        Consensus.Learning.IProductEventRepository ILearningRepositoryCollection.ProductEvent
        {
            get { return this.ProductEvent; }
        }

        /// <summary>
        ///     Gets the Microsoft SQL Server repository which persists and retrieves instances of the <see cref="T:Consensus.Learning.BookingRecord" /> data structure.
        /// </summary>
        Consensus.Learning.IBookingRepository ILearningRepositoryCollection.Booking
        {
            get { return this.Booking; }
        }

        /// <summary>
        ///     Gets the Microsoft SQL Server repository which persists and retrieves instances of the <see cref="T:Consensus.Learning.DelegateRecord" /> data structure.
        /// </summary>
        Consensus.Learning.ILearnerRepository ILearningRepositoryCollection.Learner
        {
            get { return this.Learner; }
        }

        /// <summary>
        ///     Gets the Microsoft SQL Server repository which persists and retrieves instances of the <see cref="T:Consensus.Learning.ElementRecord" /> data structure.
        /// </summary>
        Consensus.Learning.IElementRepository ILearningRepositoryCollection.Element
        {
            get { return this.Element; }
        }

        /// <summary>
        ///     Gets the Microsoft SQL Server repository which persists and retrieves instances of the <see cref="T:Consensus.Learning.SessionXrefRecord" /> data structure.
        /// </summary>
        Consensus.Learning.ISessionXrefRepository ILearningRepositoryCollection.SessionXref
        {
            get { return this.SessionXref; }
        }

        /// <summary>
        ///     Gets the Microsoft SQL Server repository which persists and retrieves instances of the <see cref="T:Consensus.Learning.CourseselectgroupsRecord" /> data structure.
        /// </summary>
        Consensus.Learning.ICourseSelectGroupsRepository ILearningRepositoryCollection.CourseSelectGroups
        {
            get { return this.CourseSelectGroups; }
        }

        /// <summary>
        ///     Gets the Microsoft SQL Server repository which persists and retrieves instances of the <see cref="T:Consensus.Learning.EventProductRecord" /> data structure.
        /// </summary>
        Consensus.Learning.IEventProductRepository ILearningRepositoryCollection.EventProduct
        {
            get { return this.EventProduct; }
        }

        /// <summary>
        ///     Gets the Microsoft SQL Server repository which persists and retrieves instances of the <see cref="T:Consensus.Learning.ProdselectgroupsRecord" /> data structure.
        /// </summary>
        Consensus.Learning.IProdSelectGroupRepository ILearningRepositoryCollection.ProdSelectGroup
        {
            get { return this.ProdSelectGroup; }
        }

        #endregion
    }
}
