using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
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
    public interface ILearningFactoryCollection : IFactoryCollection
    {
        /// <summary>
        ///     Gets the locally executable factory which is responsible for instantiating <see cref="!:ProductModel" /> objects.
        /// </summary>
        Consensus.Learning.IProductFactory Product
        {
            get;
        }

        /// <summary>
        ///     Gets the locally executable factory which is responsible for instantiating <see cref="!:BillOfMaterialModel" /> objects.
        /// </summary>
        Consensus.Learning.IBillOfMaterialFactory BillOfMaterial
        {
            get;
        }

        /// <summary>
        ///     Gets the locally executable factory which is responsible for instantiating <see cref="!:TemplateModel" /> objects.
        /// </summary>
        Consensus.Learning.ITemplateFactory Template
        {
            get;
        }

        /// <summary>
        ///     Gets the locally executable factory which is responsible for instantiating <see cref="!:EventModel" /> objects.
        /// </summary>
        Consensus.Learning.IEventFactory Event
        {
            get;
        }

        /// <summary>
        ///     Gets the locally executable factory which is responsible for instantiating <see cref="!:RelatedProductModel" /> objects.
        /// </summary>
        Consensus.Learning.IRelatedProductFactory RelatedProduct
        {
            get;
        }

        /// <summary>
        ///     Gets the locally executable factory which is responsible for instantiating <see cref="!:ProductEventModel" /> objects.
        /// </summary>
        Consensus.Learning.IProductEventFactory ProductEvent
        {
            get;
        }

        /// <summary>
        ///     Gets the locally executable factory which is responsible for instantiating <see cref="!:BookingModel" /> objects.
        /// </summary>
        Consensus.Learning.IBookingFactory Booking
        {
            get;
        }

        /// <summary>
        ///     Gets the locally executable factory which is responsible for instantiating <see cref="!:LearnerModel" /> objects.
        /// </summary>
        Consensus.Learning.ILearnerFactory Learner
        {
            get;
        }

        /// <summary>
        ///     Gets the locally executable factory which is responsible for instantiating <see cref="!:ElementModel" /> objects.
        /// </summary>
        Consensus.Learning.IElementFactory Element
        {
            get;
        }

        /// <summary>
        ///     Gets the locally executable factory which is responsible for instantiating <see cref="!:SessionXrefModel" /> objects.
        /// </summary>
        Consensus.Learning.ISessionXrefFactory SessionXref
        {
            get;
        }

        /// <summary>
        ///     Gets the locally executable factory which is responsible for instantiating <see cref="!:CourseSelectGroupsModel" /> objects.
        /// </summary>
        Consensus.Learning.ICourseSelectGroupsFactory CourseSelectGroups
        {
            get;
        }

        /// <summary>
        ///     Gets the locally executable factory which is responsible for instantiating <see cref="!:EventProductModel" /> objects.
        /// </summary>
        Consensus.Learning.IEventProductFactory EventProduct
        {
            get;
        }

        /// <summary>
        ///     Gets the locally executable factory which is responsible for instantiating <see cref="!:ProdSelectGroupModel" /> objects.
        /// </summary>
        Consensus.Learning.IProdSelectGroupFactory ProdSelectGroup
        {
            get;
        }

        /// <summary>
        ///     Gets the locally executable factory which is responsible for instantiating <see cref="!:ProductCourseModel" /> objects.
        /// </summary>
        Consensus.Learning.IProductCourseFactory ProductCourse
        {
            get;
        }

        /// <summary>
        ///     Gets the locally executable factory which is responsible for instantiating <see cref="!:ProductMerchandiseModel" /> objects.
        /// </summary>
        Consensus.Learning.IProductMerchandiseFactory ProductMerchandise
        {
            get;
        }

        /// <summary>
        ///     Gets the locally executable factory which is responsible for instantiating <see cref="!:TemplateResourceModel" /> objects.
        /// </summary>
        Consensus.Learning.ITemplateResourceFactory TemplateResource
        {
            get;
        }

        /// <summary>
        ///     Gets the locally executable factory which is responsible for instantiating <see cref="!:TemplateRoomModel" /> objects.
        /// </summary>
        Consensus.Learning.ITemplateRoomFactory TemplateRoom
        {
            get;
        }

        /// <summary>
        ///     Gets the locally executable factory which is responsible for instantiating <see cref="!:TemplateTrainerModel" /> objects.
        /// </summary>
        Consensus.Learning.ITemplateTrainerFactory TemplateTrainer
        {
            get;
        }

        /// <summary>
        ///     Gets the locally executable factory which is responsible for instantiating <see cref="!:SessionModel" /> objects.
        /// </summary>
        Consensus.Learning.ISessionFactory Session
        {
            get;
        }

        /// <summary>
        ///     Gets the locally executable factory which is responsible for instantiating <see cref="!:ProductMembershipModel" /> objects.
        /// </summary>
        Consensus.Learning.IProductMembershipFactory ProductMembership
        {
            get;
        }
    }
}
