using System;
using System.Collections.Generic;
using System.Linq;

namespace Consensus.Other
{
    /// <summary>
    ///     Encapsulates the <see cref="WorkflowRecord" /> with standardised business rules.
    /// </summary>
    /// <remarks>
    ///     THIS CODE HAS BEEN AUTOMATICALLY GENERATED USING THE CONSENSUS DEVELOPER TOOLS.
    ///     DO NOT EDIT THIS CODE AS ANY CUSTOM MODIFICATIONS WILL BE LOST UPON REGENERATION.
    /// </remarks>
    public partial class LocalWorkflowModel : LocalModel<WorkflowRecord, String>, IWorkflowModel
    {
        #region properties

        /// <summary>
        ///     Gets the delegated function that is responsible for persisting a new instance of the data structure within the underlying persistence mechanism.
        /// </summary>
        protected override Action<WorkflowRecord> DataCreator
        {
            get { return this.Provider.DataProvider.Other.Workflow.Create; }
        }

        /// <summary>
        ///     Gets the delegated function that is responsible for persisting an existing instance of the data structure within the underlying persistence mechanism.
        /// </summary>
        protected override Action<WorkflowRecord> DataModifier
        {
            get { return this.Provider.DataProvider.Other.Workflow.Modify; }
        }

        /// <summary>
        ///     Gets the delegated function that is responsible for removing an existing instance of the data structure from the underlying persistence mechanism.
        /// </summary>
        protected override Action<WorkflowRecord> DataRemover
        {
            get { return this.Provider.DataProvider.Other.Workflow.RemoveById; }
        }

        /// <summary>
        ///     Gets or sets the value of the "WF_NAME" field.
        /// </summary>
        public String Name
        {
            get { return this.ModifiedData.Name; }
            set { this.ModifiedData.Name = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "WF_DESC" field.
        /// </summary>
        public String Desc
        {
            get { return this.ModifiedData.Desc; }
            set { this.ModifiedData.Desc = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "WF_REC_TYPE" field.
        /// </summary>
        public String RecType
        {
            get { return this.ModifiedData.RecType; }
            set { this.ModifiedData.RecType = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "WF_AUTO_LINK" field.
        /// </summary>
        public Byte? AutoLink
        {
            get { return this.ModifiedData.AutoLink; }
            set { this.ModifiedData.AutoLink = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "WF_FIRST_WFR_ID" field.
        /// </summary>
        public String FirstWfrId
        {
            get { return this.ModifiedData.FirstWfrId; }
            set { this.ModifiedData.FirstWfrId = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "WF_DELAY" field.
        /// </summary>
        public Int32? Delay
        {
            get { return this.ModifiedData.Delay; }
            set { this.ModifiedData.Delay = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "WF_OCCURS" field.
        /// </summary>
        public Byte? Occurs
        {
            get { return this.ModifiedData.Occurs; }
            set { this.ModifiedData.Occurs = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "WF_DAY_OF_WEEK" field.
        /// </summary>
        public Byte? DayOfWeek
        {
            get { return this.ModifiedData.DayOfWeek; }
            set { this.ModifiedData.DayOfWeek = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "WF_DAILY_FREQ" field.
        /// </summary>
        public Byte? DailyFreq
        {
            get { return this.ModifiedData.DailyFreq; }
            set { this.ModifiedData.DailyFreq = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "WF_NORMAL_TIME" field.
        /// </summary>
        public DateTime? NormalTime
        {
            get { return this.ModifiedData.NormalTime; }
            set { this.ModifiedData.NormalTime = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "WF_FREQUENCY" field.
        /// </summary>
        public Int32? Frequency
        {
            get { return this.ModifiedData.Frequency; }
            set { this.ModifiedData.Frequency = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "WF_VALID_FROM_DATE" field.
        /// </summary>
        public DateTime? ValidFromDate
        {
            get { return this.ModifiedData.ValidFromDate; }
            set { this.ModifiedData.ValidFromDate = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "WF_VALID_TO_DATE" field.
        /// </summary>
        public DateTime? ValidToDate
        {
            get { return this.ModifiedData.ValidToDate; }
            set { this.ModifiedData.ValidToDate = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "WF_DISABLED" field.
        /// </summary>
        public Byte? Disabled
        {
            get { return this.ModifiedData.Disabled; }
            set { this.ModifiedData.Disabled = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "WF_RUN_DATETIME" field.
        /// </summary>
        public DateTime? RunDatetime
        {
            get { return this.ModifiedData.RunDatetime; }
            set { this.ModifiedData.RunDatetime = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "WF_LAST_RUN_DTTIME" field.
        /// </summary>
        public DateTime? LastRunDttime
        {
            get { return this.ModifiedData.LastRunDttime; }
            set { this.ModifiedData.LastRunDttime = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "WF_CREATED_BY_V1" field.
        /// </summary>
        public Boolean CreatedByV1
        {
            get { return this.ModifiedData.CreatedByV1; }
            set { this.ModifiedData.CreatedByV1 = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "WF_GROUP" field.
        /// </summary>
        public String Group
        {
            get { return this.ModifiedData.Group; }
            set { this.ModifiedData.Group = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "WF_UNIQUE_SYS_NAME" field.
        /// </summary>
        public String UniqueSysName
        {
            get { return this.ModifiedData.UniqueSysName; }
            set { this.ModifiedData.UniqueSysName = value; }
        }

        #endregion

        #region constructors

        /// <summary>
        ///     Initialises a new <see cref="LocalWorkflowModel" /> instance.
        /// </summary>
        /// <param name="provider">
        ///     The business provider to which the business model is bound.
        /// </param>
        internal LocalWorkflowModel(LocalProvider provider) : base(provider)
        {
        }

        /// <summary>
        ///     Initialises a new <see cref="LocalWorkflowModel" /> instance.
        /// </summary>
        /// <param name="provider">
        ///     The business provider to which the business model is bound.
        /// </param>
        /// <param name="record">
        ///     The data record which is encapsulated by the business model.
        /// </param>
        internal LocalWorkflowModel(LocalProvider provider, WorkflowRecord record) : base(provider, record)
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
        ///     Gets or sets the value of the "WF_NAME" field.
        /// </summary>
        System.String IWorkflowModel.Name
        {
            get { return this.Name; }
            set { this.Name = (System.String)value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "WF_DESC" field.
        /// </summary>
        System.String IWorkflowModel.Desc
        {
            get { return this.Desc; }
            set { this.Desc = (System.String)value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "WF_REC_TYPE" field.
        /// </summary>
        System.String IWorkflowModel.RecType
        {
            get { return this.RecType; }
            set { this.RecType = (System.String)value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "WF_AUTO_LINK" field.
        /// </summary>
        System.Nullable<System.Byte> IWorkflowModel.AutoLink
        {
            get { return this.AutoLink; }
            set { this.AutoLink = (System.Nullable<System.Byte>)value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "WF_FIRST_WFR_ID" field.
        /// </summary>
        System.String IWorkflowModel.FirstWfrId
        {
            get { return this.FirstWfrId; }
            set { this.FirstWfrId = (System.String)value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "WF_DELAY" field.
        /// </summary>
        System.Nullable<System.Int32> IWorkflowModel.Delay
        {
            get { return this.Delay; }
            set { this.Delay = (System.Nullable<System.Int32>)value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "WF_OCCURS" field.
        /// </summary>
        System.Nullable<System.Byte> IWorkflowModel.Occurs
        {
            get { return this.Occurs; }
            set { this.Occurs = (System.Nullable<System.Byte>)value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "WF_DAY_OF_WEEK" field.
        /// </summary>
        System.Nullable<System.Byte> IWorkflowModel.DayOfWeek
        {
            get { return this.DayOfWeek; }
            set { this.DayOfWeek = (System.Nullable<System.Byte>)value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "WF_DAILY_FREQ" field.
        /// </summary>
        System.Nullable<System.Byte> IWorkflowModel.DailyFreq
        {
            get { return this.DailyFreq; }
            set { this.DailyFreq = (System.Nullable<System.Byte>)value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "WF_NORMAL_TIME" field.
        /// </summary>
        System.Nullable<System.DateTime> IWorkflowModel.NormalTime
        {
            get { return this.NormalTime; }
            set { this.NormalTime = (System.Nullable<System.DateTime>)value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "WF_FREQUENCY" field.
        /// </summary>
        System.Nullable<System.Int32> IWorkflowModel.Frequency
        {
            get { return this.Frequency; }
            set { this.Frequency = (System.Nullable<System.Int32>)value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "WF_VALID_FROM_DATE" field.
        /// </summary>
        System.Nullable<System.DateTime> IWorkflowModel.ValidFromDate
        {
            get { return this.ValidFromDate; }
            set { this.ValidFromDate = (System.Nullable<System.DateTime>)value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "WF_VALID_TO_DATE" field.
        /// </summary>
        System.Nullable<System.DateTime> IWorkflowModel.ValidToDate
        {
            get { return this.ValidToDate; }
            set { this.ValidToDate = (System.Nullable<System.DateTime>)value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "WF_DISABLED" field.
        /// </summary>
        System.Nullable<System.Byte> IWorkflowModel.Disabled
        {
            get { return this.Disabled; }
            set { this.Disabled = (System.Nullable<System.Byte>)value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "WF_RUN_DATETIME" field.
        /// </summary>
        System.Nullable<System.DateTime> IWorkflowModel.RunDatetime
        {
            get { return this.RunDatetime; }
            set { this.RunDatetime = (System.Nullable<System.DateTime>)value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "WF_LAST_RUN_DTTIME" field.
        /// </summary>
        System.Nullable<System.DateTime> IWorkflowModel.LastRunDttime
        {
            get { return this.LastRunDttime; }
            set { this.LastRunDttime = (System.Nullable<System.DateTime>)value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "WF_CREATED_BY_V1" field.
        /// </summary>
        System.Boolean IWorkflowModel.CreatedByV1
        {
            get { return this.CreatedByV1; }
            set { this.CreatedByV1 = (System.Boolean)value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "WF_GROUP" field.
        /// </summary>
        System.String IWorkflowModel.Group
        {
            get { return this.Group; }
            set { this.Group = (System.String)value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "WF_UNIQUE_SYS_NAME" field.
        /// </summary>
        System.String IWorkflowModel.UniqueSysName
        {
            get { return this.UniqueSysName; }
            set { this.UniqueSysName = (System.String)value; }
        }

        #endregion
    }
}
