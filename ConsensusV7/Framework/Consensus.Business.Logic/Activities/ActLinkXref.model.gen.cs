using System;
using System.Collections.Generic;
using System.Linq;

namespace Consensus.Activities
{
    /// <summary>
    ///     Encapsulates the <see cref="ActLinkXrefRecord" /> with standardised business rules.
    /// </summary>
    /// <remarks>
    ///     THIS CODE HAS BEEN AUTOMATICALLY GENERATED USING THE CONSENSUS DEVELOPER TOOLS.
    ///     DO NOT EDIT THIS CODE AS ANY CUSTOM MODIFICATIONS WILL BE LOST UPON REGENERATION.
    /// </remarks>
    public partial class LocalActLinkXrefModel : LocalModel<ActLinkXrefRecord, String>, IActLinkXrefModel
    {
        #region fields

        /// <summary>
        ///     The value of the "ACTLINK_ACT_ID" field.
        /// </summary>
        private LocalActivityModel _activity;

        #endregion

        #region properties

        /// <summary>
        ///     Gets the delegated function that is responsible for persisting a new instance of the data structure within the underlying persistence mechanism.
        /// </summary>
        protected override Action<ActLinkXrefRecord> DataCreator
        {
            get { return this.Provider.DataProvider.Activities.ActLinkXref.Create; }
        }

        /// <summary>
        ///     Gets the delegated function that is responsible for persisting an existing instance of the data structure within the underlying persistence mechanism.
        /// </summary>
        protected override Action<ActLinkXrefRecord> DataModifier
        {
            get { return this.Provider.DataProvider.Activities.ActLinkXref.Modify; }
        }

        /// <summary>
        ///     Gets the delegated function that is responsible for removing an existing instance of the data structure from the underlying persistence mechanism.
        /// </summary>
        protected override Action<ActLinkXrefRecord> DataRemover
        {
            get { return this.Provider.DataProvider.Activities.ActLinkXref.RemoveById; }
        }

        /// <summary>
        ///     Gets the The value of the "ACTLINK_ACT_ID" field.
        /// </summary>
        public LocalActivityModel Activity
        {
            get
            {
                if (_activity == null && this.ActivityId != null)
                    _activity = this.Provider.Activities.Activity.FetchById(this.ActivityId);
                if (_activity == null)
                    _activity = this.Provider.Activities.Activity.Create();
                
                return _activity;
            }
        }

        /// <summary>
        ///     Gets or sets the unique code for the value of the "ACTLINK_ACT_ID" field.
        /// </summary>
        public String ActivityId
        {
            get { return this.ModifiedData.ActId; }
            set
            {
                if (this.ModifiedData.ActId != value)
                     _activity = null;
                this.ModifiedData.ActId = value;
            }
        }

        /// <summary>
        ///     Gets or sets the value of the "ACTLINK_TABLE_NUM" field.
        /// </summary>
        public Double? TableNum
        {
            get { return this.ModifiedData.TableNum; }
            set { this.ModifiedData.TableNum = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "ACTLINK_REC_ID" field.
        /// </summary>
        public String RecordId
        {
            get { return this.ModifiedData.RecId; }
            set { this.ModifiedData.RecId = value; }
        }

        #endregion

        #region constructors

        /// <summary>
        ///     Initialises a new <see cref="LocalActLinkXrefModel" /> instance.
        /// </summary>
        /// <param name="provider">
        ///     The business provider to which the business model is bound.
        /// </param>
        internal LocalActLinkXrefModel(LocalProvider provider) : base(provider)
        {
        }

        /// <summary>
        ///     Initialises a new <see cref="LocalActLinkXrefModel" /> instance.
        /// </summary>
        /// <param name="provider">
        ///     The business provider to which the business model is bound.
        /// </param>
        /// <param name="record">
        ///     The data record which is encapsulated by the business model.
        /// </param>
        internal LocalActLinkXrefModel(LocalProvider provider, ActLinkXrefRecord record) : base(provider, record)
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
            if (_activity != null)
            {
                _activity.Save();
                this.ModifiedData.ActId = _activity.Id == null && this.ModifiedData.ActId != null ? "" : _activity.Id;
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
        ///     Gets the The value of the "ACTLINK_ACT_ID" field.
        /// </summary>
        Consensus.Activities.IActivityModel IActLinkXrefModel.Activity
        {
            get { return this.Activity; }
        }

        /// <summary>
        ///     Gets or sets the unique code for the value of the "ACTLINK_ACT_ID" field.
        /// </summary>
        System.String IActLinkXrefModel.ActivityId
        {
            get { return this.ActivityId; }
            set { this.ActivityId = (System.String)value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "ACTLINK_TABLE_NUM" field.
        /// </summary>
        System.Nullable<System.Double> IActLinkXrefModel.TableNum
        {
            get { return this.TableNum; }
            set { this.TableNum = (System.Nullable<System.Double>)value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "ACTLINK_REC_ID" field.
        /// </summary>
        System.String IActLinkXrefModel.RecordId
        {
            get { return this.RecordId; }
            set { this.RecordId = (System.String)value; }
        }

        #endregion
    }
}
