using System;
using System.Collections.Generic;
using System.Linq;

namespace Consensus.Learning
{
    /// <remarks>
    ///     THIS CODE HAS BEEN AUTOMATICALLY GENERATED USING THE CONSENSUS DEVELOPER TOOLS.
    ///     DO NOT EDIT THIS CODE AS ANY CUSTOM MODIFICATIONS WILL BE LOST UPON REGENERATION.
    /// </remarks>
    public partial class CourseSelectGroups : Proxy<ICourseSelectGroupsModel, Int32>
    {
        #region fields

        /// <summary>
        ///     The client-consumable proxy instance for the <see cref="ProdSelectionGroup" /> member.
        /// </summary>
        private Consensus.Learning.ProdSelectGroup _prodSelectionGroup;

        /// <summary>
        ///     The client-consumable proxy instance for the <see cref="Event" /> member.
        /// </summary>
        private Consensus.Learning.Event _event;

        #endregion

        #region properties

        /// <summary>
        ///     Gets the The value of the "CSG_PSG_ID" field.
        /// </summary>
        public Consensus.Learning.ProdSelectGroup ProdSelectionGroup
        {
            get
            {
                if (_prodSelectionGroup == null && this.Model.ProdSelectionGroup != null)
                    _prodSelectionGroup = new Consensus.Learning.ProdSelectGroup(this.Model.ProdSelectionGroup);
                if (_prodSelectionGroup == null)
                    _prodSelectionGroup = Consensus.Learning.ProdSelectGroup.Create();
                return _prodSelectionGroup;
            }
        }

        /// <summary>
        ///     Gets or sets the unique code for the value of the "CSG_PSG_ID" field.
        /// </summary>
        public System.Nullable<System.Int32> ProdSelectionGroupId
        {
            get { return this.Model.ProdSelectionGroupId; }
            set { this.Model.ProdSelectionGroupId = value; }
        }

        /// <summary>
        ///     Gets the The value of the "CSG_COURSE_ID" field.
        /// </summary>
        public Consensus.Learning.Event Event
        {
            get
            {
                if (_event == null && this.Model.Event != null)
                    _event = new Consensus.Learning.Event(this.Model.Event);
                if (_event == null)
                    _event = Consensus.Learning.Event.Create();
                return _event;
            }
        }

        /// <summary>
        ///     Gets or sets the unique code for the value of the "CSG_COURSE_ID" field.
        /// </summary>
        public System.String EventId
        {
            get { return this.Model.EventId; }
            set { this.Model.EventId = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "CSG_TYPE" field.
        /// </summary>
        public System.Byte Type
        {
            get { return this.Model.Type; }
            set { this.Model.Type = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "CSG_NAME" field.
        /// </summary>
        public System.String Name
        {
            get { return this.Model.Name; }
            set { this.Model.Name = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "CSG_DESCRIPTION" field.
        /// </summary>
        public System.String Description
        {
            get { return this.Model.Description; }
            set { this.Model.Description = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "CSG_MIN" field.
        /// </summary>
        public System.Byte Min
        {
            get { return this.Model.Min; }
            set { this.Model.Min = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "CSG_MAX" field.
        /// </summary>
        public System.Byte Max
        {
            get { return this.Model.Max; }
            set { this.Model.Max = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "CSG_ORDER" field.
        /// </summary>
        public System.Byte Order
        {
            get { return this.Model.Order; }
            set { this.Model.Order = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "CSG_ERROR_MESSAGE" field.
        /// </summary>
        public System.String ErrorMessage
        {
            get { return this.Model.ErrorMessage; }
            set { this.Model.ErrorMessage = value; }
        }

        #endregion

        #region constructors

        /// <summary>
        ///     Initialises a new instance of the client-consumable class.
        /// </summary>
        internal CourseSelectGroups(ICourseSelectGroupsModel model) : base(model)
        {
        }

        #endregion

        #region methods

        /// <summary>
        ///     Creates a new <see cref="!:CourseSelectGroupsModel" /> instance.
        /// </summary>
        /// <returns>
        ///     A newly instantiated <see cref="!:CourseSelectGroupsModel" /> instance.
        /// </returns>
        public static Consensus.Learning.CourseSelectGroups Create()
        {
            ConsensusSite site = ConsensusDomain.Configuration[ConsensusDomain.Configuration.DefaultSite];
            return CourseSelectGroups.Create(site);
        }

        /// <summary>
        ///     Creates a new <see cref="!:CourseSelectGroupsModel" /> instance.
        /// </summary>
        /// <returns>
        ///     A newly instantiated <see cref="!:CourseSelectGroupsModel" /> instance.
        /// </returns>
        public static Consensus.Learning.CourseSelectGroups Create(ConsensusSite site)
        {
            IBusinessProvider provider = site.GetService<IBusinessProvider>();
            Consensus.Learning.ICourseSelectGroupsModel model = provider.Learning.CourseSelectGroups.Create();
            return model == null ? null : new Consensus.Learning.CourseSelectGroups(model);
        }

        /// <summary>
        ///     Retrieves all instances of the <see cref="!:CourseSelectGroupsModel" /> class.
        /// </summary>
        /// <returns>
        ///     An enumerable collection of <see cref="!:CourseSelectGroupsModel" /> instances.
        /// </returns>
        public static IEnumerable<Consensus.Learning.CourseSelectGroups> FetchAll()
        {
            ConsensusSite site = ConsensusDomain.Configuration[ConsensusDomain.Configuration.DefaultSite];
            return CourseSelectGroups.FetchAll(site);
        }

        /// <summary>
        ///     Retrieves all instances of the <see cref="!:CourseSelectGroupsModel" /> class.
        /// </summary>
        /// <returns>
        ///     An enumerable collection of <see cref="!:CourseSelectGroupsModel" /> instances.
        /// </returns>
        public static IEnumerable<Consensus.Learning.CourseSelectGroups> FetchAll(ConsensusSite site)
        {
            IBusinessProvider provider = site.GetService<IBusinessProvider>();
            IEnumerable<Consensus.Learning.ICourseSelectGroupsModel> collection = provider.Learning.CourseSelectGroups.FetchAll();
            return collection.Select(model => new Consensus.Learning.CourseSelectGroups(model));
        }

        /// <summary>
        ///     Retrieves a specific <see cref="!:CourseSelectGroupsModel" /> instance.
        /// </summary>
        /// <param name="id">
        ///     The unique value which distinctly identifies the <see cref="!:CourseSelectGroupsModel" /> instance to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:CourseSelectGroupsModel" /> instance that matches the specified <paramref name="id" />; or null, if no matching instance can be found.
        /// </returns>
        public static Consensus.Learning.CourseSelectGroups FetchById(System.Int32 id)
        {
            ConsensusSite site = ConsensusDomain.Configuration[ConsensusDomain.Configuration.DefaultSite];
            return CourseSelectGroups.FetchById(site,id);
        }

        /// <summary>
        ///     Retrieves a specific <see cref="!:CourseSelectGroupsModel" /> instance.
        /// </summary>
        /// <param name="id">
        ///     The unique value which distinctly identifies the <see cref="!:CourseSelectGroupsModel" /> instance to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:CourseSelectGroupsModel" /> instance that matches the specified <paramref name="id" />; or null, if no matching instance can be found.
        /// </returns>
        public static Consensus.Learning.CourseSelectGroups FetchById(ConsensusSite site, System.Int32 id)
        {
            IBusinessProvider provider = site.GetService<IBusinessProvider>();
            Consensus.Learning.ICourseSelectGroupsModel model = provider.Learning.CourseSelectGroups.FetchById(id);
            return model == null ? null : new Consensus.Learning.CourseSelectGroups(model);
        }

        public static System.String GetTableName()
        {
            ConsensusSite site = ConsensusDomain.Configuration[ConsensusDomain.Configuration.DefaultSite];
            return CourseSelectGroups.GetTableName(site);
        }

        public static System.String GetTableName(ConsensusSite site)
        {
            IBusinessProvider provider = site.GetService<IBusinessProvider>();
            return provider.Learning.CourseSelectGroups.GetTableName();
        }

        public static IEnumerable<Consensus.Learning.CourseSelectGroups> FetchAllByProdSelectionGroupId(System.Nullable<System.Int32> prodSelectionGroupId)
        {
            ConsensusSite site = ConsensusDomain.Configuration[ConsensusDomain.Configuration.DefaultSite];
            return CourseSelectGroups.FetchAllByProdSelectionGroupId(site,prodSelectionGroupId);
        }

        public static IEnumerable<Consensus.Learning.CourseSelectGroups> FetchAllByProdSelectionGroupId(ConsensusSite site, System.Nullable<System.Int32> prodSelectionGroupId)
        {
            IBusinessProvider provider = site.GetService<IBusinessProvider>();
            IEnumerable<Consensus.Learning.ICourseSelectGroupsModel> collection = provider.Learning.CourseSelectGroups.FetchAllByProdSelectionGroupId(prodSelectionGroupId);
            return collection.Select(model => new Consensus.Learning.CourseSelectGroups(model));
        }

        /// <summary>
        ///     Retrieves a collection of <see cref="!:CourseSelectGroupsModel" /> instances.
        /// </summary>
        /// <param name="eventId">
        ///     The value which identifies the <see cref="!:CourseSelectGroupsModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:CourseSelectGroupsModel" /> instances that match the specified <paramref name="eventId" />.
        /// </returns>
        public static IEnumerable<Consensus.Learning.CourseSelectGroups> FetchAllByEventId(System.String eventId)
        {
            ConsensusSite site = ConsensusDomain.Configuration[ConsensusDomain.Configuration.DefaultSite];
            return CourseSelectGroups.FetchAllByEventId(site,eventId);
        }

        /// <summary>
        ///     Retrieves a collection of <see cref="!:CourseSelectGroupsModel" /> instances.
        /// </summary>
        /// <param name="eventId">
        ///     The value which identifies the <see cref="!:CourseSelectGroupsModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:CourseSelectGroupsModel" /> instances that match the specified <paramref name="eventId" />.
        /// </returns>
        public static IEnumerable<Consensus.Learning.CourseSelectGroups> FetchAllByEventId(ConsensusSite site, System.String eventId)
        {
            IBusinessProvider provider = site.GetService<IBusinessProvider>();
            IEnumerable<Consensus.Learning.ICourseSelectGroupsModel> collection = provider.Learning.CourseSelectGroups.FetchAllByEventId(eventId);
            return collection.Select(model => new Consensus.Learning.CourseSelectGroups(model));
        }

        #endregion
    }
}
