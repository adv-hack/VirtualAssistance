using System;
using System.Collections.Generic;
using System.Linq;

namespace Consensus.Learning
{
    /// <summary>
    ///     Represents a collection of factory instances which are responsible for the instantiation of the business models in the Learning namespace.
    /// </summary>
    /// <remarks>
    ///     THIS CODE HAS BEEN AUTOMATICALLY GENERATED USING THE CONSENSUS DEVELOPER TOOLS.
    ///     DO NOT EDIT THIS CODE AS ANY CUSTOM MODIFICATIONS WILL BE LOST UPON REGENERATION.
    /// </remarks>
    public partial class LocalLearningFactoryCollection : LocalFactoryCollection, ILearningFactoryCollection
    {
        #region fields

        /// <summary>
        ///     The locally executable factory which is responsible for instantiating <see cref="ProductModel" /> objects.
        /// </summary>
        private LocalProductFactory _product;

        /// <summary>
        ///     The locally executable factory which is responsible for instantiating <see cref="BillOfMaterialModel" /> objects.
        /// </summary>
        private LocalBillOfMaterialFactory _billOfMaterial;

        /// <summary>
        ///     The locally executable factory which is responsible for instantiating <see cref="TemplateModel" /> objects.
        /// </summary>
        private LocalTemplateFactory _template;

        /// <summary>
        ///     The locally executable factory which is responsible for instantiating <see cref="EventModel" /> objects.
        /// </summary>
        private LocalEventFactory _event;

        /// <summary>
        ///     The locally executable factory which is responsible for instantiating <see cref="RelatedProductModel" /> objects.
        /// </summary>
        private LocalRelatedProductFactory _relatedProduct;

        /// <summary>
        ///     The locally executable factory which is responsible for instantiating <see cref="ProductEventModel" /> objects.
        /// </summary>
        private LocalProductEventFactory _productEvent;

        /// <summary>
        ///     The locally executable factory which is responsible for instantiating <see cref="BookingModel" /> objects.
        /// </summary>
        private LocalBookingFactory _booking;

        /// <summary>
        ///     The locally executable factory which is responsible for instantiating <see cref="LearnerModel" /> objects.
        /// </summary>
        private LocalLearnerFactory _learner;

        /// <summary>
        ///     The locally executable factory which is responsible for instantiating <see cref="ElementModel" /> objects.
        /// </summary>
        private LocalElementFactory _element;

        /// <summary>
        ///     The locally executable factory which is responsible for instantiating <see cref="SessionXrefModel" /> objects.
        /// </summary>
        private LocalSessionXrefFactory _sessionXref;

        /// <summary>
        ///     The locally executable factory which is responsible for instantiating <see cref="CourseSelectGroupsModel" /> objects.
        /// </summary>
        private LocalCourseSelectGroupsFactory _courseSelectGroups;

        /// <summary>
        ///     The locally executable factory which is responsible for instantiating <see cref="EventProductModel" /> objects.
        /// </summary>
        private LocalEventProductFactory _eventProduct;

        /// <summary>
        ///     The locally executable factory which is responsible for instantiating <see cref="ProdSelectGroupModel" /> objects.
        /// </summary>
        private LocalProdSelectGroupFactory _prodSelectGroup;

        /// <summary>
        ///     The locally executable factory which is responsible for instantiating <see cref="ProductCourseModel" /> objects.
        /// </summary>
        private LocalProductCourseFactory _productCourse;

        /// <summary>
        ///     The locally executable factory which is responsible for instantiating <see cref="ProductMerchandiseModel" /> objects.
        /// </summary>
        private LocalProductMerchandiseFactory _productMerchandise;

        /// <summary>
        ///     The locally executable factory which is responsible for instantiating <see cref="TemplateResourceModel" /> objects.
        /// </summary>
        private LocalTemplateResourceFactory _templateResource;

        /// <summary>
        ///     The locally executable factory which is responsible for instantiating <see cref="TemplateRoomModel" /> objects.
        /// </summary>
        private LocalTemplateRoomFactory _templateRoom;

        /// <summary>
        ///     The locally executable factory which is responsible for instantiating <see cref="TemplateTrainerModel" /> objects.
        /// </summary>
        private LocalTemplateTrainerFactory _templateTrainer;

        /// <summary>
        ///     The locally executable factory which is responsible for instantiating <see cref="SessionModel" /> objects.
        /// </summary>
        private LocalSessionFactory _session;

        /// <summary>
        ///     The locally executable factory which is responsible for instantiating <see cref="ProductMembershipModel" /> objects.
        /// </summary>
        private LocalProductMembershipFactory _productMembership;

        #endregion

        #region properties

        /// <summary>
        ///     Gets the locally executable factory which is responsible for instantiating <see cref="ProductModel" /> objects.
        /// </summary>
        public LocalProductFactory Product
        {
            get { return LocalFactory.Create(this.Provider, ref _product); }
        }

        /// <summary>
        ///     Gets the locally executable factory which is responsible for instantiating <see cref="BillOfMaterialModel" /> objects.
        /// </summary>
        public LocalBillOfMaterialFactory BillOfMaterial
        {
            get { return LocalFactory.Create(this.Provider, ref _billOfMaterial); }
        }

        /// <summary>
        ///     Gets the locally executable factory which is responsible for instantiating <see cref="TemplateModel" /> objects.
        /// </summary>
        public LocalTemplateFactory Template
        {
            get { return LocalFactory.Create(this.Provider, ref _template); }
        }

        /// <summary>
        ///     Gets the locally executable factory which is responsible for instantiating <see cref="EventModel" /> objects.
        /// </summary>
        public LocalEventFactory Event
        {
            get { return LocalFactory.Create(this.Provider, ref _event); }
        }

        /// <summary>
        ///     Gets the locally executable factory which is responsible for instantiating <see cref="RelatedProductModel" /> objects.
        /// </summary>
        public LocalRelatedProductFactory RelatedProduct
        {
            get { return LocalFactory.Create(this.Provider, ref _relatedProduct); }
        }

        /// <summary>
        ///     Gets the locally executable factory which is responsible for instantiating <see cref="ProductEventModel" /> objects.
        /// </summary>
        public LocalProductEventFactory ProductEvent
        {
            get { return LocalFactory.Create(this.Provider, ref _productEvent); }
        }

        /// <summary>
        ///     Gets the locally executable factory which is responsible for instantiating <see cref="BookingModel" /> objects.
        /// </summary>
        public LocalBookingFactory Booking
        {
            get { return LocalFactory.Create(this.Provider, ref _booking); }
        }

        /// <summary>
        ///     Gets the locally executable factory which is responsible for instantiating <see cref="LearnerModel" /> objects.
        /// </summary>
        public LocalLearnerFactory Learner
        {
            get { return LocalFactory.Create(this.Provider, ref _learner); }
        }

        /// <summary>
        ///     Gets the locally executable factory which is responsible for instantiating <see cref="ElementModel" /> objects.
        /// </summary>
        public LocalElementFactory Element
        {
            get { return LocalFactory.Create(this.Provider, ref _element); }
        }

        /// <summary>
        ///     Gets the locally executable factory which is responsible for instantiating <see cref="SessionXrefModel" /> objects.
        /// </summary>
        public LocalSessionXrefFactory SessionXref
        {
            get { return LocalFactory.Create(this.Provider, ref _sessionXref); }
        }

        /// <summary>
        ///     Gets the locally executable factory which is responsible for instantiating <see cref="CourseSelectGroupsModel" /> objects.
        /// </summary>
        public LocalCourseSelectGroupsFactory CourseSelectGroups
        {
            get { return LocalFactory.Create(this.Provider, ref _courseSelectGroups); }
        }

        /// <summary>
        ///     Gets the locally executable factory which is responsible for instantiating <see cref="EventProductModel" /> objects.
        /// </summary>
        public LocalEventProductFactory EventProduct
        {
            get { return LocalFactory.Create(this.Provider, ref _eventProduct); }
        }

        /// <summary>
        ///     Gets the locally executable factory which is responsible for instantiating <see cref="ProdSelectGroupModel" /> objects.
        /// </summary>
        public LocalProdSelectGroupFactory ProdSelectGroup
        {
            get { return LocalFactory.Create(this.Provider, ref _prodSelectGroup); }
        }

        /// <summary>
        ///     Gets the locally executable factory which is responsible for instantiating <see cref="ProductCourseModel" /> objects.
        /// </summary>
        public LocalProductCourseFactory ProductCourse
        {
            get { return LocalFactory.Create(this.Provider, ref _productCourse); }
        }

        /// <summary>
        ///     Gets the locally executable factory which is responsible for instantiating <see cref="ProductMerchandiseModel" /> objects.
        /// </summary>
        public LocalProductMerchandiseFactory ProductMerchandise
        {
            get { return LocalFactory.Create(this.Provider, ref _productMerchandise); }
        }

        /// <summary>
        ///     Gets the locally executable factory which is responsible for instantiating <see cref="TemplateResourceModel" /> objects.
        /// </summary>
        public LocalTemplateResourceFactory TemplateResource
        {
            get { return LocalFactory.Create(this.Provider, ref _templateResource); }
        }

        /// <summary>
        ///     Gets the locally executable factory which is responsible for instantiating <see cref="TemplateRoomModel" /> objects.
        /// </summary>
        public LocalTemplateRoomFactory TemplateRoom
        {
            get { return LocalFactory.Create(this.Provider, ref _templateRoom); }
        }

        /// <summary>
        ///     Gets the locally executable factory which is responsible for instantiating <see cref="TemplateTrainerModel" /> objects.
        /// </summary>
        public LocalTemplateTrainerFactory TemplateTrainer
        {
            get { return LocalFactory.Create(this.Provider, ref _templateTrainer); }
        }

        /// <summary>
        ///     Gets the locally executable factory which is responsible for instantiating <see cref="SessionModel" /> objects.
        /// </summary>
        public LocalSessionFactory Session
        {
            get { return LocalFactory.Create(this.Provider, ref _session); }
        }

        /// <summary>
        ///     Gets the locally executable factory which is responsible for instantiating <see cref="ProductMembershipModel" /> objects.
        /// </summary>
        public LocalProductMembershipFactory ProductMembership
        {
            get { return LocalFactory.Create(this.Provider, ref _productMembership); }
        }

        #endregion

        #region implementations

        /// <summary>
        ///     Gets the locally executable factory which is responsible for instantiating <see cref="!:ProductModel" /> objects.
        /// </summary>
        Consensus.Learning.IProductFactory ILearningFactoryCollection.Product
        {
            get { return this.Product; }
        }

        /// <summary>
        ///     Gets the locally executable factory which is responsible for instantiating <see cref="!:BillOfMaterialModel" /> objects.
        /// </summary>
        Consensus.Learning.IBillOfMaterialFactory ILearningFactoryCollection.BillOfMaterial
        {
            get { return this.BillOfMaterial; }
        }

        /// <summary>
        ///     Gets the locally executable factory which is responsible for instantiating <see cref="!:TemplateModel" /> objects.
        /// </summary>
        Consensus.Learning.ITemplateFactory ILearningFactoryCollection.Template
        {
            get { return this.Template; }
        }

        /// <summary>
        ///     Gets the locally executable factory which is responsible for instantiating <see cref="!:EventModel" /> objects.
        /// </summary>
        Consensus.Learning.IEventFactory ILearningFactoryCollection.Event
        {
            get { return this.Event; }
        }

        /// <summary>
        ///     Gets the locally executable factory which is responsible for instantiating <see cref="!:RelatedProductModel" /> objects.
        /// </summary>
        Consensus.Learning.IRelatedProductFactory ILearningFactoryCollection.RelatedProduct
        {
            get { return this.RelatedProduct; }
        }

        /// <summary>
        ///     Gets the locally executable factory which is responsible for instantiating <see cref="!:ProductEventModel" /> objects.
        /// </summary>
        Consensus.Learning.IProductEventFactory ILearningFactoryCollection.ProductEvent
        {
            get { return this.ProductEvent; }
        }

        /// <summary>
        ///     Gets the locally executable factory which is responsible for instantiating <see cref="!:BookingModel" /> objects.
        /// </summary>
        Consensus.Learning.IBookingFactory ILearningFactoryCollection.Booking
        {
            get { return this.Booking; }
        }

        /// <summary>
        ///     Gets the locally executable factory which is responsible for instantiating <see cref="!:LearnerModel" /> objects.
        /// </summary>
        Consensus.Learning.ILearnerFactory ILearningFactoryCollection.Learner
        {
            get { return this.Learner; }
        }

        /// <summary>
        ///     Gets the locally executable factory which is responsible for instantiating <see cref="!:ElementModel" /> objects.
        /// </summary>
        Consensus.Learning.IElementFactory ILearningFactoryCollection.Element
        {
            get { return this.Element; }
        }

        /// <summary>
        ///     Gets the locally executable factory which is responsible for instantiating <see cref="!:SessionXrefModel" /> objects.
        /// </summary>
        Consensus.Learning.ISessionXrefFactory ILearningFactoryCollection.SessionXref
        {
            get { return this.SessionXref; }
        }

        /// <summary>
        ///     Gets the locally executable factory which is responsible for instantiating <see cref="!:CourseSelectGroupsModel" /> objects.
        /// </summary>
        Consensus.Learning.ICourseSelectGroupsFactory ILearningFactoryCollection.CourseSelectGroups
        {
            get { return this.CourseSelectGroups; }
        }

        /// <summary>
        ///     Gets the locally executable factory which is responsible for instantiating <see cref="!:EventProductModel" /> objects.
        /// </summary>
        Consensus.Learning.IEventProductFactory ILearningFactoryCollection.EventProduct
        {
            get { return this.EventProduct; }
        }

        /// <summary>
        ///     Gets the locally executable factory which is responsible for instantiating <see cref="!:ProdSelectGroupModel" /> objects.
        /// </summary>
        Consensus.Learning.IProdSelectGroupFactory ILearningFactoryCollection.ProdSelectGroup
        {
            get { return this.ProdSelectGroup; }
        }

        /// <summary>
        ///     Gets the locally executable factory which is responsible for instantiating <see cref="!:ProductCourseModel" /> objects.
        /// </summary>
        Consensus.Learning.IProductCourseFactory ILearningFactoryCollection.ProductCourse
        {
            get { return this.ProductCourse; }
        }

        /// <summary>
        ///     Gets the locally executable factory which is responsible for instantiating <see cref="!:ProductMerchandiseModel" /> objects.
        /// </summary>
        Consensus.Learning.IProductMerchandiseFactory ILearningFactoryCollection.ProductMerchandise
        {
            get { return this.ProductMerchandise; }
        }

        /// <summary>
        ///     Gets the locally executable factory which is responsible for instantiating <see cref="!:TemplateResourceModel" /> objects.
        /// </summary>
        Consensus.Learning.ITemplateResourceFactory ILearningFactoryCollection.TemplateResource
        {
            get { return this.TemplateResource; }
        }

        /// <summary>
        ///     Gets the locally executable factory which is responsible for instantiating <see cref="!:TemplateRoomModel" /> objects.
        /// </summary>
        Consensus.Learning.ITemplateRoomFactory ILearningFactoryCollection.TemplateRoom
        {
            get { return this.TemplateRoom; }
        }

        /// <summary>
        ///     Gets the locally executable factory which is responsible for instantiating <see cref="!:TemplateTrainerModel" /> objects.
        /// </summary>
        Consensus.Learning.ITemplateTrainerFactory ILearningFactoryCollection.TemplateTrainer
        {
            get { return this.TemplateTrainer; }
        }

        /// <summary>
        ///     Gets the locally executable factory which is responsible for instantiating <see cref="!:SessionModel" /> objects.
        /// </summary>
        Consensus.Learning.ISessionFactory ILearningFactoryCollection.Session
        {
            get { return this.Session; }
        }

        /// <summary>
        ///     Gets the locally executable factory which is responsible for instantiating <see cref="!:ProductMembershipModel" /> objects.
        /// </summary>
        Consensus.Learning.IProductMembershipFactory ILearningFactoryCollection.ProductMembership
        {
            get { return this.ProductMembership; }
        }

        #endregion
    }
}
