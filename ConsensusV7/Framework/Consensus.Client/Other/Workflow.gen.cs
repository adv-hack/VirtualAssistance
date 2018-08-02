using System;
using System.Collections.Generic;
using System.Linq;

namespace Consensus.Other
{
    /// <remarks>
    ///     THIS CODE HAS BEEN AUTOMATICALLY GENERATED USING THE CONSENSUS DEVELOPER TOOLS.
    ///     DO NOT EDIT THIS CODE AS ANY CUSTOM MODIFICATIONS WILL BE LOST UPON REGENERATION.
    /// </remarks>
    public partial class Workflow : Proxy<IWorkflowModel, String>
    {
        #region properties

        /// <summary>
        ///     Gets or sets the value of the "WF_NAME" field.
        /// </summary>
        public System.String Name
        {
            get { return this.Model.Name; }
            set { this.Model.Name = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "WF_DESC" field.
        /// </summary>
        public System.String Desc
        {
            get { return this.Model.Desc; }
            set { this.Model.Desc = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "WF_REC_TYPE" field.
        /// </summary>
        public System.String RecType
        {
            get { return this.Model.RecType; }
            set { this.Model.RecType = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "WF_AUTO_LINK" field.
        /// </summary>
        public System.Nullable<System.Byte> AutoLink
        {
            get { return this.Model.AutoLink; }
            set { this.Model.AutoLink = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "WF_FIRST_WFR_ID" field.
        /// </summary>
        public System.String FirstWfrId
        {
            get { return this.Model.FirstWfrId; }
            set { this.Model.FirstWfrId = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "WF_DELAY" field.
        /// </summary>
        public System.Nullable<System.Int32> Delay
        {
            get { return this.Model.Delay; }
            set { this.Model.Delay = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "WF_OCCURS" field.
        /// </summary>
        public System.Nullable<System.Byte> Occurs
        {
            get { return this.Model.Occurs; }
            set { this.Model.Occurs = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "WF_DAY_OF_WEEK" field.
        /// </summary>
        public System.Nullable<System.Byte> DayOfWeek
        {
            get { return this.Model.DayOfWeek; }
            set { this.Model.DayOfWeek = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "WF_DAILY_FREQ" field.
        /// </summary>
        public System.Nullable<System.Byte> DailyFreq
        {
            get { return this.Model.DailyFreq; }
            set { this.Model.DailyFreq = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "WF_NORMAL_TIME" field.
        /// </summary>
        public System.Nullable<System.DateTime> NormalTime
        {
            get { return this.Model.NormalTime; }
            set { this.Model.NormalTime = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "WF_FREQUENCY" field.
        /// </summary>
        public System.Nullable<System.Int32> Frequency
        {
            get { return this.Model.Frequency; }
            set { this.Model.Frequency = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "WF_VALID_FROM_DATE" field.
        /// </summary>
        public System.Nullable<System.DateTime> ValidFromDate
        {
            get { return this.Model.ValidFromDate; }
            set { this.Model.ValidFromDate = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "WF_VALID_TO_DATE" field.
        /// </summary>
        public System.Nullable<System.DateTime> ValidToDate
        {
            get { return this.Model.ValidToDate; }
            set { this.Model.ValidToDate = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "WF_DISABLED" field.
        /// </summary>
        public System.Nullable<System.Byte> Disabled
        {
            get { return this.Model.Disabled; }
            set { this.Model.Disabled = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "WF_RUN_DATETIME" field.
        /// </summary>
        public System.Nullable<System.DateTime> RunDatetime
        {
            get { return this.Model.RunDatetime; }
            set { this.Model.RunDatetime = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "WF_LAST_RUN_DTTIME" field.
        /// </summary>
        public System.Nullable<System.DateTime> LastRunDttime
        {
            get { return this.Model.LastRunDttime; }
            set { this.Model.LastRunDttime = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "WF_CREATED_BY_V1" field.
        /// </summary>
        public System.Boolean CreatedByV1
        {
            get { return this.Model.CreatedByV1; }
            set { this.Model.CreatedByV1 = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "WF_GROUP" field.
        /// </summary>
        public System.String Group
        {
            get { return this.Model.Group; }
            set { this.Model.Group = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "WF_UNIQUE_SYS_NAME" field.
        /// </summary>
        public System.String UniqueSysName
        {
            get { return this.Model.UniqueSysName; }
            set { this.Model.UniqueSysName = value; }
        }

        #endregion

        #region constructors

        /// <summary>
        ///     Initialises a new instance of the client-consumable class.
        /// </summary>
        internal Workflow(IWorkflowModel model) : base(model)
        {
        }

        #endregion

        #region methods

        /// <summary>
        ///     Retrieves a specific <see cref="!:WorkflowModel" /> instance.
        /// </summary>
        /// <param name="recType">
        ///     The recType value for the <see cref="!:WorkflowModel" /> instance to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:WorkflowModel" /> instance that matches the specified <paramref name="recType" />; or null, if no matching instance can be found.
        /// </returns>
        public static IEnumerable<Consensus.Other.Workflow> FetchAllByRecType(System.String recType)
        {
            ConsensusSite site = ConsensusDomain.Configuration[ConsensusDomain.Configuration.DefaultSite];
            return Workflow.FetchAllByRecType(site,recType);
        }

        /// <summary>
        ///     Retrieves a specific <see cref="!:WorkflowModel" /> instance.
        /// </summary>
        /// <param name="recType">
        ///     The recType value for the <see cref="!:WorkflowModel" /> instance to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:WorkflowModel" /> instance that matches the specified <paramref name="recType" />; or null, if no matching instance can be found.
        /// </returns>
        public static IEnumerable<Consensus.Other.Workflow> FetchAllByRecType(ConsensusSite site, System.String recType)
        {
            IBusinessProvider provider = site.GetService<IBusinessProvider>();
            IEnumerable<Consensus.Other.IWorkflowModel> collection = provider.Other.Workflow.FetchAllByRecType(recType);
            return collection.Select(model => new Consensus.Other.Workflow(model));
        }

        /// <summary>
        ///     Creates a new <see cref="!:WorkflowModel" /> instance.
        /// </summary>
        /// <returns>
        ///     A newly instantiated <see cref="!:WorkflowModel" /> instance.
        /// </returns>
        public static Consensus.Other.Workflow Create()
        {
            ConsensusSite site = ConsensusDomain.Configuration[ConsensusDomain.Configuration.DefaultSite];
            return Workflow.Create(site);
        }

        /// <summary>
        ///     Creates a new <see cref="!:WorkflowModel" /> instance.
        /// </summary>
        /// <returns>
        ///     A newly instantiated <see cref="!:WorkflowModel" /> instance.
        /// </returns>
        public static Consensus.Other.Workflow Create(ConsensusSite site)
        {
            IBusinessProvider provider = site.GetService<IBusinessProvider>();
            Consensus.Other.IWorkflowModel model = provider.Other.Workflow.Create();
            return model == null ? null : new Consensus.Other.Workflow(model);
        }

        /// <summary>
        ///     Retrieves all instances of the <see cref="!:WorkflowModel" /> class.
        /// </summary>
        /// <returns>
        ///     An enumerable collection of <see cref="!:WorkflowModel" /> instances.
        /// </returns>
        public static IEnumerable<Consensus.Other.Workflow> FetchAll()
        {
            ConsensusSite site = ConsensusDomain.Configuration[ConsensusDomain.Configuration.DefaultSite];
            return Workflow.FetchAll(site);
        }

        /// <summary>
        ///     Retrieves all instances of the <see cref="!:WorkflowModel" /> class.
        /// </summary>
        /// <returns>
        ///     An enumerable collection of <see cref="!:WorkflowModel" /> instances.
        /// </returns>
        public static IEnumerable<Consensus.Other.Workflow> FetchAll(ConsensusSite site)
        {
            IBusinessProvider provider = site.GetService<IBusinessProvider>();
            IEnumerable<Consensus.Other.IWorkflowModel> collection = provider.Other.Workflow.FetchAll();
            return collection.Select(model => new Consensus.Other.Workflow(model));
        }

        /// <summary>
        ///     Retrieves a specific <see cref="!:WorkflowModel" /> instance.
        /// </summary>
        /// <param name="id">
        ///     The unique value which distinctly identifies the <see cref="!:WorkflowModel" /> instance to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:WorkflowModel" /> instance that matches the specified <paramref name="id" />; or null, if no matching instance can be found.
        /// </returns>
        public static Consensus.Other.Workflow FetchById(System.String id)
        {
            ConsensusSite site = ConsensusDomain.Configuration[ConsensusDomain.Configuration.DefaultSite];
            return Workflow.FetchById(site,id);
        }

        /// <summary>
        ///     Retrieves a specific <see cref="!:WorkflowModel" /> instance.
        /// </summary>
        /// <param name="id">
        ///     The unique value which distinctly identifies the <see cref="!:WorkflowModel" /> instance to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:WorkflowModel" /> instance that matches the specified <paramref name="id" />; or null, if no matching instance can be found.
        /// </returns>
        public static Consensus.Other.Workflow FetchById(ConsensusSite site, System.String id)
        {
            IBusinessProvider provider = site.GetService<IBusinessProvider>();
            Consensus.Other.IWorkflowModel model = provider.Other.Workflow.FetchById(id);
            return model == null ? null : new Consensus.Other.Workflow(model);
        }

        public static System.String GetTableName()
        {
            ConsensusSite site = ConsensusDomain.Configuration[ConsensusDomain.Configuration.DefaultSite];
            return Workflow.GetTableName(site);
        }

        public static System.String GetTableName(ConsensusSite site)
        {
            IBusinessProvider provider = site.GetService<IBusinessProvider>();
            return provider.Other.Workflow.GetTableName();
        }

        #endregion
    }
}
