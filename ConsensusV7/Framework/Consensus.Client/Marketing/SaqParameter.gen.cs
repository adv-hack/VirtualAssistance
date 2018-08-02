using System;
using System.Collections.Generic;
using System.Linq;

namespace Consensus.Marketing
{
    /// <remarks>
    ///     THIS CODE HAS BEEN AUTOMATICALLY GENERATED USING THE CONSENSUS DEVELOPER TOOLS.
    ///     DO NOT EDIT THIS CODE AS ANY CUSTOM MODIFICATIONS WILL BE LOST UPON REGENERATION.
    /// </remarks>
    public partial class SaqParameter : Proxy<ISaqParameterModel, Int64>
    {
        #region fields

        /// <summary>
        ///     The client-consumable proxy instance for the <see cref="Step" /> member.
        /// </summary>
        private Consensus.Marketing.SaqStep _step;

        /// <summary>
        ///     The client-consumable proxy instance for the <see cref="FilterField" /> member.
        /// </summary>
        private Consensus.Marketing.SaqFilterField _filterField;

        #endregion

        #region properties

        /// <summary>
        ///     Gets the The value of the "STPRM_STEP_ID" field.
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
        ///     Gets or sets the unique code for the value of the "STPRM_STEP_ID" field.
        /// </summary>
        public System.Int64 StepId
        {
            get { return this.Model.StepId; }
            set { this.Model.StepId = value; }
        }

        /// <summary>
        ///     Gets the The value of the "STPRM_F_ID" field.
        /// </summary>
        public Consensus.Marketing.SaqFilterField FilterField
        {
            get
            {
                if (_filterField == null && this.Model.FilterField != null)
                    _filterField = new Consensus.Marketing.SaqFilterField(this.Model.FilterField);
                if (_filterField == null)
                    _filterField = Consensus.Marketing.SaqFilterField.Create();
                return _filterField;
            }
        }

        /// <summary>
        ///     Gets or sets the unique code for the value of the "STPRM_F_ID" field.
        /// </summary>
        public System.Int64 FilterFieldId
        {
            get { return this.Model.FilterFieldId; }
            set { this.Model.FilterFieldId = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "STPRM_CONDITION" field.
        /// </summary>
        public System.String Condition
        {
            get { return this.Model.Condition; }
            set { this.Model.Condition = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "STPRM_VALUE" field.
        /// </summary>
        public System.String Value
        {
            get { return this.Model.Value; }
            set { this.Model.Value = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "STPRM_OPERAND" field.
        /// </summary>
        public System.String Operand
        {
            get { return this.Model.Operand; }
            set { this.Model.Operand = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "STPRM_ORDER" field.
        /// </summary>
        public System.Int32 Order
        {
            get { return this.Model.Order; }
            set { this.Model.Order = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "STPRM_PRE_BRACKET" field.
        /// </summary>
        public System.String PreBracket
        {
            get { return this.Model.PreBracket; }
            set { this.Model.PreBracket = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "STPRM_POST_BRACKET" field.
        /// </summary>
        public System.String PostBracket
        {
            get { return this.Model.PostBracket; }
            set { this.Model.PostBracket = value; }
        }

        #endregion

        #region constructors

        /// <summary>
        ///     Initialises a new instance of the client-consumable class.
        /// </summary>
        internal SaqParameter(ISaqParameterModel model) : base(model)
        {
        }

        #endregion

        #region methods

        /// <summary>
        ///     Creates a new <see cref="!:SaqParameterModel" /> instance.
        /// </summary>
        /// <returns>
        ///     A newly instantiated <see cref="!:SaqParameterModel" /> instance.
        /// </returns>
        public static Consensus.Marketing.SaqParameter Create()
        {
            ConsensusSite site = ConsensusDomain.Configuration[ConsensusDomain.Configuration.DefaultSite];
            return SaqParameter.Create(site);
        }

        /// <summary>
        ///     Creates a new <see cref="!:SaqParameterModel" /> instance.
        /// </summary>
        /// <returns>
        ///     A newly instantiated <see cref="!:SaqParameterModel" /> instance.
        /// </returns>
        public static Consensus.Marketing.SaqParameter Create(ConsensusSite site)
        {
            IBusinessProvider provider = site.GetService<IBusinessProvider>();
            Consensus.Marketing.ISaqParameterModel model = provider.Marketing.SaqParameter.Create();
            return model == null ? null : new Consensus.Marketing.SaqParameter(model);
        }

        /// <summary>
        ///     Retrieves all instances of the <see cref="!:SaqParameterModel" /> class.
        /// </summary>
        /// <returns>
        ///     An enumerable collection of <see cref="!:SaqParameterModel" /> instances.
        /// </returns>
        public static IEnumerable<Consensus.Marketing.SaqParameter> FetchAll()
        {
            ConsensusSite site = ConsensusDomain.Configuration[ConsensusDomain.Configuration.DefaultSite];
            return SaqParameter.FetchAll(site);
        }

        /// <summary>
        ///     Retrieves all instances of the <see cref="!:SaqParameterModel" /> class.
        /// </summary>
        /// <returns>
        ///     An enumerable collection of <see cref="!:SaqParameterModel" /> instances.
        /// </returns>
        public static IEnumerable<Consensus.Marketing.SaqParameter> FetchAll(ConsensusSite site)
        {
            IBusinessProvider provider = site.GetService<IBusinessProvider>();
            IEnumerable<Consensus.Marketing.ISaqParameterModel> collection = provider.Marketing.SaqParameter.FetchAll();
            return collection.Select(model => new Consensus.Marketing.SaqParameter(model));
        }

        /// <summary>
        ///     Retrieves a specific <see cref="!:SaqParameterModel" /> instance.
        /// </summary>
        /// <param name="id">
        ///     The unique value which distinctly identifies the <see cref="!:SaqParameterModel" /> instance to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:SaqParameterModel" /> instance that matches the specified <paramref name="id" />; or null, if no matching instance can be found.
        /// </returns>
        public static Consensus.Marketing.SaqParameter FetchById(System.Int64 id)
        {
            ConsensusSite site = ConsensusDomain.Configuration[ConsensusDomain.Configuration.DefaultSite];
            return SaqParameter.FetchById(site,id);
        }

        /// <summary>
        ///     Retrieves a specific <see cref="!:SaqParameterModel" /> instance.
        /// </summary>
        /// <param name="id">
        ///     The unique value which distinctly identifies the <see cref="!:SaqParameterModel" /> instance to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:SaqParameterModel" /> instance that matches the specified <paramref name="id" />; or null, if no matching instance can be found.
        /// </returns>
        public static Consensus.Marketing.SaqParameter FetchById(ConsensusSite site, System.Int64 id)
        {
            IBusinessProvider provider = site.GetService<IBusinessProvider>();
            Consensus.Marketing.ISaqParameterModel model = provider.Marketing.SaqParameter.FetchById(id);
            return model == null ? null : new Consensus.Marketing.SaqParameter(model);
        }

        public static System.String GetTableName()
        {
            ConsensusSite site = ConsensusDomain.Configuration[ConsensusDomain.Configuration.DefaultSite];
            return SaqParameter.GetTableName(site);
        }

        public static System.String GetTableName(ConsensusSite site)
        {
            IBusinessProvider provider = site.GetService<IBusinessProvider>();
            return provider.Marketing.SaqParameter.GetTableName();
        }

        /// <summary>
        ///     Retrieves a collection of <see cref="!:SaqParameterModel" /> instances.
        /// </summary>
        /// <param name="stepId">
        ///     The value which identifies the <see cref="!:SaqParameterModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:SaqParameterModel" /> instances that match the specified <paramref name="stepId" />.
        /// </returns>
        public static IEnumerable<Consensus.Marketing.SaqParameter> FetchAllByStepId(System.Int64 stepId)
        {
            ConsensusSite site = ConsensusDomain.Configuration[ConsensusDomain.Configuration.DefaultSite];
            return SaqParameter.FetchAllByStepId(site,stepId);
        }

        /// <summary>
        ///     Retrieves a collection of <see cref="!:SaqParameterModel" /> instances.
        /// </summary>
        /// <param name="stepId">
        ///     The value which identifies the <see cref="!:SaqParameterModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:SaqParameterModel" /> instances that match the specified <paramref name="stepId" />.
        /// </returns>
        public static IEnumerable<Consensus.Marketing.SaqParameter> FetchAllByStepId(ConsensusSite site, System.Int64 stepId)
        {
            IBusinessProvider provider = site.GetService<IBusinessProvider>();
            IEnumerable<Consensus.Marketing.ISaqParameterModel> collection = provider.Marketing.SaqParameter.FetchAllByStepId(stepId);
            return collection.Select(model => new Consensus.Marketing.SaqParameter(model));
        }

        /// <summary>
        ///     Retrieves a collection of <see cref="!:SaqParameterModel" /> instances.
        /// </summary>
        /// <param name="filterFieldId">
        ///     The value which identifies the <see cref="!:SaqParameterModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:SaqParameterModel" /> instances that match the specified <paramref name="filterFieldId" />.
        /// </returns>
        public static IEnumerable<Consensus.Marketing.SaqParameter> FetchAllByFilterFieldId(System.Int64 filterFieldId)
        {
            ConsensusSite site = ConsensusDomain.Configuration[ConsensusDomain.Configuration.DefaultSite];
            return SaqParameter.FetchAllByFilterFieldId(site,filterFieldId);
        }

        /// <summary>
        ///     Retrieves a collection of <see cref="!:SaqParameterModel" /> instances.
        /// </summary>
        /// <param name="filterFieldId">
        ///     The value which identifies the <see cref="!:SaqParameterModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:SaqParameterModel" /> instances that match the specified <paramref name="filterFieldId" />.
        /// </returns>
        public static IEnumerable<Consensus.Marketing.SaqParameter> FetchAllByFilterFieldId(ConsensusSite site, System.Int64 filterFieldId)
        {
            IBusinessProvider provider = site.GetService<IBusinessProvider>();
            IEnumerable<Consensus.Marketing.ISaqParameterModel> collection = provider.Marketing.SaqParameter.FetchAllByFilterFieldId(filterFieldId);
            return collection.Select(model => new Consensus.Marketing.SaqParameter(model));
        }

        #endregion
    }
}
