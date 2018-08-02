using System;
using System.Collections.Generic;
using System.Linq;

namespace Consensus.Marketing
{
    /// <remarks>
    ///     THIS CODE HAS BEEN AUTOMATICALLY GENERATED USING THE CONSENSUS DEVELOPER TOOLS.
    ///     DO NOT EDIT THIS CODE AS ANY CUSTOM MODIFICATIONS WILL BE LOST UPON REGENERATION.
    /// </remarks>
    public partial class SaqQueryStep : Proxy<ISaqQueryStepModel, Int32>
    {
        #region fields

        /// <summary>
        ///     The client-consumable proxy instance for the <see cref="StepQuery" /> member.
        /// </summary>
        private Consensus.Marketing.SaqQuery _stepQuery;

        /// <summary>
        ///     The client-consumable proxy instance for the <see cref="Step" /> member.
        /// </summary>
        private Consensus.Marketing.SaqStep _step;

        #endregion

        #region properties

        /// <summary>
        ///     Gets the The value of the "QSTEP_QRY_ID" field.
        /// </summary>
        public Consensus.Marketing.SaqQuery StepQuery
        {
            get
            {
                if (_stepQuery == null && this.Model.StepQuery != null)
                    _stepQuery = new Consensus.Marketing.SaqQuery(this.Model.StepQuery);
                if (_stepQuery == null)
                    _stepQuery = Consensus.Marketing.SaqQuery.Create();
                return _stepQuery;
            }
        }

        /// <summary>
        ///     Gets or sets the unique code for the value of the "QSTEP_QRY_ID" field.
        /// </summary>
        public System.Int64 StepQueryId
        {
            get { return this.Model.StepQueryId; }
            set { this.Model.StepQueryId = value; }
        }

        /// <summary>
        ///     Gets the The value of the "QSTEP_STEP_ID" field.
        /// </summary>
        public Consensus.Marketing.SaqStep Step
        {
            get
            {
                if (_step == null && this.Model.Step != null)
                    _step = new Consensus.Marketing.SaqStep(this.Model.Step);
                if (_step == null)
                    _step = Consensus.Marketing.SaqStep.Create();
                return _step;
            }
        }

        /// <summary>
        ///     Gets or sets the unique code for the value of the "QSTEP_STEP_ID" field.
        /// </summary>
        public System.Int64 StepId
        {
            get { return this.Model.StepId; }
            set { this.Model.StepId = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "QSTEP_LINK" field.
        /// </summary>
        public System.String Link
        {
            get { return this.Model.Link; }
            set { this.Model.Link = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "QSTEP_ORDER" field.
        /// </summary>
        public System.Int16 Order
        {
            get { return this.Model.Order; }
            set { this.Model.Order = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "QSTEP_RESULT_COUNT" field.
        /// </summary>
        public System.Int64 ResultCount
        {
            get { return this.Model.ResultCount; }
            set { this.Model.ResultCount = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "QSTEP_ORG_TOTAL" field.
        /// </summary>
        public System.Int64 OrgTotal
        {
            get { return this.Model.OrgTotal; }
            set { this.Model.OrgTotal = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "QSTEP_ROLE_TOTAL" field.
        /// </summary>
        public System.Int64 RoleTotal
        {
            get { return this.Model.RoleTotal; }
            set { this.Model.RoleTotal = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "QSTEP_PERSON_TOTAL" field.
        /// </summary>
        public System.Int64 PersonTotal
        {
            get { return this.Model.PersonTotal; }
            set { this.Model.PersonTotal = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "QSTEP_LOCKED" field.
        /// </summary>
        public System.Byte Locked
        {
            get { return this.Model.Locked; }
            set { this.Model.Locked = value; }
        }

        #endregion

        #region constructors

        /// <summary>
        ///     Initialises a new instance of the client-consumable class.
        /// </summary>
        internal SaqQueryStep(ISaqQueryStepModel model) : base(model)
        {
        }

        #endregion

        #region methods

        /// <summary>
        ///     Creates a new <see cref="!:SaqQueryStepModel" /> instance.
        /// </summary>
        /// <returns>
        ///     A newly instantiated <see cref="!:SaqQueryStepModel" /> instance.
        /// </returns>
        public static Consensus.Marketing.SaqQueryStep Create()
        {
            ConsensusSite site = ConsensusDomain.Configuration[ConsensusDomain.Configuration.DefaultSite];
            return SaqQueryStep.Create(site);
        }

        /// <summary>
        ///     Creates a new <see cref="!:SaqQueryStepModel" /> instance.
        /// </summary>
        /// <returns>
        ///     A newly instantiated <see cref="!:SaqQueryStepModel" /> instance.
        /// </returns>
        public static Consensus.Marketing.SaqQueryStep Create(ConsensusSite site)
        {
            IBusinessProvider provider = site.GetService<IBusinessProvider>();
            Consensus.Marketing.ISaqQueryStepModel model = provider.Marketing.SaqQueryStep.Create();
            return model == null ? null : new Consensus.Marketing.SaqQueryStep(model);
        }

        /// <summary>
        ///     Retrieves all instances of the <see cref="!:SaqQueryStepModel" /> class.
        /// </summary>
        /// <returns>
        ///     An enumerable collection of <see cref="!:SaqQueryStepModel" /> instances.
        /// </returns>
        public static IEnumerable<Consensus.Marketing.SaqQueryStep> FetchAll()
        {
            ConsensusSite site = ConsensusDomain.Configuration[ConsensusDomain.Configuration.DefaultSite];
            return SaqQueryStep.FetchAll(site);
        }

        /// <summary>
        ///     Retrieves all instances of the <see cref="!:SaqQueryStepModel" /> class.
        /// </summary>
        /// <returns>
        ///     An enumerable collection of <see cref="!:SaqQueryStepModel" /> instances.
        /// </returns>
        public static IEnumerable<Consensus.Marketing.SaqQueryStep> FetchAll(ConsensusSite site)
        {
            IBusinessProvider provider = site.GetService<IBusinessProvider>();
            IEnumerable<Consensus.Marketing.ISaqQueryStepModel> collection = provider.Marketing.SaqQueryStep.FetchAll();
            return collection.Select(model => new Consensus.Marketing.SaqQueryStep(model));
        }

        /// <summary>
        ///     Retrieves a specific <see cref="!:SaqQueryStepModel" /> instance.
        /// </summary>
        /// <param name="id">
        ///     The unique value which distinctly identifies the <see cref="!:SaqQueryStepModel" /> instance to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:SaqQueryStepModel" /> instance that matches the specified <paramref name="id" />; or null, if no matching instance can be found.
        /// </returns>
        public static Consensus.Marketing.SaqQueryStep FetchById(System.Int32 id)
        {
            ConsensusSite site = ConsensusDomain.Configuration[ConsensusDomain.Configuration.DefaultSite];
            return SaqQueryStep.FetchById(site,id);
        }

        /// <summary>
        ///     Retrieves a specific <see cref="!:SaqQueryStepModel" /> instance.
        /// </summary>
        /// <param name="id">
        ///     The unique value which distinctly identifies the <see cref="!:SaqQueryStepModel" /> instance to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:SaqQueryStepModel" /> instance that matches the specified <paramref name="id" />; or null, if no matching instance can be found.
        /// </returns>
        public static Consensus.Marketing.SaqQueryStep FetchById(ConsensusSite site, System.Int32 id)
        {
            IBusinessProvider provider = site.GetService<IBusinessProvider>();
            Consensus.Marketing.ISaqQueryStepModel model = provider.Marketing.SaqQueryStep.FetchById(id);
            return model == null ? null : new Consensus.Marketing.SaqQueryStep(model);
        }

        public static System.String GetTableName()
        {
            ConsensusSite site = ConsensusDomain.Configuration[ConsensusDomain.Configuration.DefaultSite];
            return SaqQueryStep.GetTableName(site);
        }

        public static System.String GetTableName(ConsensusSite site)
        {
            IBusinessProvider provider = site.GetService<IBusinessProvider>();
            return provider.Marketing.SaqQueryStep.GetTableName();
        }

        /// <summary>
        ///     Retrieves a collection of <see cref="!:SaqQueryStepModel" /> instances.
        /// </summary>
        /// <param name="stepQueryId">
        ///     The value which identifies the <see cref="!:SaqQueryStepModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:SaqQueryStepModel" /> instances that match the specified <paramref name="stepQueryId" />.
        /// </returns>
        public static IEnumerable<Consensus.Marketing.SaqQueryStep> FetchAllByStepQueryId(System.Int64 stepQueryId)
        {
            ConsensusSite site = ConsensusDomain.Configuration[ConsensusDomain.Configuration.DefaultSite];
            return SaqQueryStep.FetchAllByStepQueryId(site,stepQueryId);
        }

        /// <summary>
        ///     Retrieves a collection of <see cref="!:SaqQueryStepModel" /> instances.
        /// </summary>
        /// <param name="stepQueryId">
        ///     The value which identifies the <see cref="!:SaqQueryStepModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:SaqQueryStepModel" /> instances that match the specified <paramref name="stepQueryId" />.
        /// </returns>
        public static IEnumerable<Consensus.Marketing.SaqQueryStep> FetchAllByStepQueryId(ConsensusSite site, System.Int64 stepQueryId)
        {
            IBusinessProvider provider = site.GetService<IBusinessProvider>();
            IEnumerable<Consensus.Marketing.ISaqQueryStepModel> collection = provider.Marketing.SaqQueryStep.FetchAllByStepQueryId(stepQueryId);
            return collection.Select(model => new Consensus.Marketing.SaqQueryStep(model));
        }

        /// <summary>
        ///     Retrieves a collection of <see cref="!:SaqQueryStepModel" /> instances.
        /// </summary>
        /// <param name="stepId">
        ///     The value which identifies the <see cref="!:SaqQueryStepModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:SaqQueryStepModel" /> instances that match the specified <paramref name="stepId" />.
        /// </returns>
        public static IEnumerable<Consensus.Marketing.SaqQueryStep> FetchAllByStepId(System.Int64 stepId)
        {
            ConsensusSite site = ConsensusDomain.Configuration[ConsensusDomain.Configuration.DefaultSite];
            return SaqQueryStep.FetchAllByStepId(site,stepId);
        }

        /// <summary>
        ///     Retrieves a collection of <see cref="!:SaqQueryStepModel" /> instances.
        /// </summary>
        /// <param name="stepId">
        ///     The value which identifies the <see cref="!:SaqQueryStepModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:SaqQueryStepModel" /> instances that match the specified <paramref name="stepId" />.
        /// </returns>
        public static IEnumerable<Consensus.Marketing.SaqQueryStep> FetchAllByStepId(ConsensusSite site, System.Int64 stepId)
        {
            IBusinessProvider provider = site.GetService<IBusinessProvider>();
            IEnumerable<Consensus.Marketing.ISaqQueryStepModel> collection = provider.Marketing.SaqQueryStep.FetchAllByStepId(stepId);
            return collection.Select(model => new Consensus.Marketing.SaqQueryStep(model));
        }

        #endregion
    }
}
