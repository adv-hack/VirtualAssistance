using System;
using System.Collections.Generic;
using System.Linq;

namespace Consensus.Learning
{
    /// <summary>
    ///     Encapsulates the <see cref="CourseselectgroupsRecord" /> with standardised business rules.
    /// </summary>
    /// <remarks>
    ///     THIS CODE HAS BEEN AUTOMATICALLY GENERATED USING THE CONSENSUS DEVELOPER TOOLS.
    ///     DO NOT EDIT THIS CODE AS ANY CUSTOM MODIFICATIONS WILL BE LOST UPON REGENERATION.
    /// </remarks>
    public partial class LocalCourseSelectGroupsModel : LocalModel<CourseselectgroupsRecord, Int32>, ICourseSelectGroupsModel
    {
        #region fields

        /// <summary>
        ///     The value of the "CSG_PSG_ID" field.
        /// </summary>
        private LocalProdSelectGroupModel _prodSelectionGroup;

        /// <summary>
        ///     The value of the "CSG_COURSE_ID" field.
        /// </summary>
        private LocalEventModel _event;

        #endregion

        #region properties

        /// <summary>
        ///     Gets the delegated function that is responsible for persisting a new instance of the data structure within the underlying persistence mechanism.
        /// </summary>
        protected override Action<CourseselectgroupsRecord> DataCreator
        {
            get { return this.Provider.DataProvider.Learning.CourseSelectGroups.Create; }
        }

        /// <summary>
        ///     Gets the delegated function that is responsible for persisting an existing instance of the data structure within the underlying persistence mechanism.
        /// </summary>
        protected override Action<CourseselectgroupsRecord> DataModifier
        {
            get { return this.Provider.DataProvider.Learning.CourseSelectGroups.Modify; }
        }

        /// <summary>
        ///     Gets the delegated function that is responsible for removing an existing instance of the data structure from the underlying persistence mechanism.
        /// </summary>
        protected override Action<CourseselectgroupsRecord> DataRemover
        {
            get { return this.Provider.DataProvider.Learning.CourseSelectGroups.RemoveById; }
        }

        /// <summary>
        ///     Gets the The value of the "CSG_PSG_ID" field.
        /// </summary>
        public LocalProdSelectGroupModel ProdSelectionGroup
        {
            get
            {
                if (_prodSelectionGroup == null && this.ProdSelectionGroupId != null)
                    _prodSelectionGroup = this.Provider.Learning.ProdSelectGroup.FetchById(this.ProdSelectionGroupId.Value);
                if (_prodSelectionGroup == null)
                    _prodSelectionGroup = this.Provider.Learning.ProdSelectGroup.Create();
                
                return _prodSelectionGroup;
            }
        }

        /// <summary>
        ///     Gets or sets the unique code for the value of the "CSG_PSG_ID" field.
        /// </summary>
        public Int32? ProdSelectionGroupId
        {
            get { return this.ModifiedData.PsgId; }
            set
            {
                if (this.ModifiedData.PsgId != value)
                     _prodSelectionGroup = null;
                this.ModifiedData.PsgId = value;
            }
        }

        /// <summary>
        ///     Gets the The value of the "CSG_COURSE_ID" field.
        /// </summary>
        public LocalEventModel Event
        {
            get
            {
                if (_event == null)
                    _event = this.Provider.Learning.Event.FetchById(this.EventId);
                if (_event == null)
                    _event = this.Provider.Learning.Event.Create();
                
                return _event;
            }
        }

        /// <summary>
        ///     Gets or sets the unique code for the value of the "CSG_COURSE_ID" field.
        /// </summary>
        public String EventId
        {
            get { return this.ModifiedData.EventId; }
            set
            {
                if (this.ModifiedData.EventId != value)
                     _event = null;
                this.ModifiedData.EventId = value;
            }
        }

        /// <summary>
        ///     Gets or sets the value of the "CSG_TYPE" field.
        /// </summary>
        public Byte Type
        {
            get { return this.ModifiedData.Type; }
            set { this.ModifiedData.Type = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "CSG_NAME" field.
        /// </summary>
        public String Name
        {
            get { return this.ModifiedData.Name; }
            set { this.ModifiedData.Name = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "CSG_DESCRIPTION" field.
        /// </summary>
        public String Description
        {
            get { return this.ModifiedData.Description; }
            set { this.ModifiedData.Description = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "CSG_MIN" field.
        /// </summary>
        public Byte Min
        {
            get { return this.ModifiedData.Min; }
            set { this.ModifiedData.Min = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "CSG_MAX" field.
        /// </summary>
        public Byte Max
        {
            get { return this.ModifiedData.Max; }
            set { this.ModifiedData.Max = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "CSG_ORDER" field.
        /// </summary>
        public Byte Order
        {
            get { return this.ModifiedData.Order; }
            set { this.ModifiedData.Order = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "CSG_ERROR_MESSAGE" field.
        /// </summary>
        public String ErrorMessage
        {
            get { return this.ModifiedData.ErrorMessage; }
            set { this.ModifiedData.ErrorMessage = value; }
        }

        #endregion

        #region constructors

        /// <summary>
        ///     Initialises a new <see cref="LocalCourseSelectGroupsModel" /> instance.
        /// </summary>
        /// <param name="provider">
        ///     The business provider to which the business model is bound.
        /// </param>
        internal LocalCourseSelectGroupsModel(LocalProvider provider) : base(provider)
        {
        }

        /// <summary>
        ///     Initialises a new <see cref="LocalCourseSelectGroupsModel" /> instance.
        /// </summary>
        /// <param name="provider">
        ///     The business provider to which the business model is bound.
        /// </param>
        /// <param name="record">
        ///     The data record which is encapsulated by the business model.
        /// </param>
        internal LocalCourseSelectGroupsModel(LocalProvider provider, CourseselectgroupsRecord record) : base(provider, record)
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
            if (_prodSelectionGroup != null)
            {
                _prodSelectionGroup.Save();
                this.ModifiedData.PsgId = _prodSelectionGroup.Id;
            }
            if (_event != null)
            {
                _event.Save();
                this.ModifiedData.EventId = _event.Id == null && this.ModifiedData.EventId != null ? "" : _event.Id;
            }
        }

        /// <summary>
        ///     Resolves the dependent models by means of updating all models that reference this model.
        /// </summary>
        protected override void ResolveGeneratedDependent()
        {
            base.ResolveGeneratedDependent();
        }

        #endregion

        #region implementations

        /// <summary>
        ///     Gets the The value of the "CSG_PSG_ID" field.
        /// </summary>
        Consensus.Learning.IProdSelectGroupModel ICourseSelectGroupsModel.ProdSelectionGroup
        {
            get { return this.ProdSelectionGroup; }
        }

        /// <summary>
        ///     Gets or sets the unique code for the value of the "CSG_PSG_ID" field.
        /// </summary>
        System.Nullable<System.Int32> ICourseSelectGroupsModel.ProdSelectionGroupId
        {
            get { return this.ProdSelectionGroupId; }
            set { this.ProdSelectionGroupId = (System.Nullable<System.Int32>)value; }
        }

        /// <summary>
        ///     Gets the The value of the "CSG_COURSE_ID" field.
        /// </summary>
        Consensus.Learning.IEventModel ICourseSelectGroupsModel.Event
        {
            get { return this.Event; }
        }

        /// <summary>
        ///     Gets or sets the unique code for the value of the "CSG_COURSE_ID" field.
        /// </summary>
        System.String ICourseSelectGroupsModel.EventId
        {
            get { return this.EventId; }
            set { this.EventId = (System.String)value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "CSG_TYPE" field.
        /// </summary>
        System.Byte ICourseSelectGroupsModel.Type
        {
            get { return this.Type; }
            set { this.Type = (System.Byte)value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "CSG_NAME" field.
        /// </summary>
        System.String ICourseSelectGroupsModel.Name
        {
            get { return this.Name; }
            set { this.Name = (System.String)value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "CSG_DESCRIPTION" field.
        /// </summary>
        System.String ICourseSelectGroupsModel.Description
        {
            get { return this.Description; }
            set { this.Description = (System.String)value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "CSG_MIN" field.
        /// </summary>
        System.Byte ICourseSelectGroupsModel.Min
        {
            get { return this.Min; }
            set { this.Min = (System.Byte)value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "CSG_MAX" field.
        /// </summary>
        System.Byte ICourseSelectGroupsModel.Max
        {
            get { return this.Max; }
            set { this.Max = (System.Byte)value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "CSG_ORDER" field.
        /// </summary>
        System.Byte ICourseSelectGroupsModel.Order
        {
            get { return this.Order; }
            set { this.Order = (System.Byte)value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "CSG_ERROR_MESSAGE" field.
        /// </summary>
        System.String ICourseSelectGroupsModel.ErrorMessage
        {
            get { return this.ErrorMessage; }
            set { this.ErrorMessage = (System.String)value; }
        }

        #endregion
    }
}
