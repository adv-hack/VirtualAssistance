using System;
using System.Collections.Generic;
using System.Linq;

namespace Consensus.Common
{
    /// <summary>
    ///     Encapsulates the <see cref="ViewLogRecord" /> with standardised business rules.
    /// </summary>
    /// <remarks>
    ///     THIS CODE HAS BEEN AUTOMATICALLY GENERATED USING THE CONSENSUS DEVELOPER TOOLS.
    ///     DO NOT EDIT THIS CODE AS ANY CUSTOM MODIFICATIONS WILL BE LOST UPON REGENERATION.
    /// </remarks>
    public partial class LocalViewLogModel : LocalModel<ViewLogRecord, Int32>, IViewLogModel
    {
        #region properties

        /// <summary>
        ///     Gets the delegated function that is responsible for persisting a new instance of the data structure within the underlying persistence mechanism.
        /// </summary>
        protected override Action<ViewLogRecord> DataCreator
        {
            get { return this.Provider.DataProvider.Common.ViewLog.Create; }
        }

        /// <summary>
        ///     Gets the delegated function that is responsible for persisting an existing instance of the data structure within the underlying persistence mechanism.
        /// </summary>
        protected override Action<ViewLogRecord> DataModifier
        {
            get { return this.Provider.DataProvider.Common.ViewLog.Modify; }
        }

        /// <summary>
        ///     Gets the delegated function that is responsible for removing an existing instance of the data structure from the underlying persistence mechanism.
        /// </summary>
        protected override Action<ViewLogRecord> DataRemover
        {
            get { return this.Provider.DataProvider.Common.ViewLog.RemoveById; }
        }

        /// <summary>
        ///     Gets or sets the value of the "VIEW_TABLE" field.
        /// </summary>
        public String Table
        {
            get { return this.ModifiedData.Table; }
            set { this.ModifiedData.Table = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "VIEW_REC_ID" field.
        /// </summary>
        public String RecId
        {
            get { return this.ModifiedData.RecId; }
            set { this.ModifiedData.RecId = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "VIEW_SOURCE" field.
        /// </summary>
        public Byte Source
        {
            get { return this.ModifiedData.Source; }
            set { this.ModifiedData.Source = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "VIEW_REC_ID2" field.
        /// </summary>
        public String RecId2
        {
            get { return this.ModifiedData.RecId2; }
            set { this.ModifiedData.RecId2 = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "VIEW_TABLE2" field.
        /// </summary>
        public String Table2
        {
            get { return this.ModifiedData.Table2; }
            set { this.ModifiedData.Table2 = value; }
        }

        #endregion

        #region constructors

        /// <summary>
        ///     Initialises a new <see cref="LocalViewLogModel" /> instance.
        /// </summary>
        /// <param name="provider">
        ///     The business provider to which the business model is bound.
        /// </param>
        internal LocalViewLogModel(LocalProvider provider) : base(provider)
        {
        }

        /// <summary>
        ///     Initialises a new <see cref="LocalViewLogModel" /> instance.
        /// </summary>
        /// <param name="provider">
        ///     The business provider to which the business model is bound.
        /// </param>
        /// <param name="record">
        ///     The data record which is encapsulated by the business model.
        /// </param>
        internal LocalViewLogModel(LocalProvider provider, ViewLogRecord record) : base(provider, record)
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
        ///     Gets or sets the value of the "VIEW_TABLE" field.
        /// </summary>
        System.String IViewLogModel.Table
        {
            get { return this.Table; }
            set { this.Table = (System.String)value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "VIEW_REC_ID" field.
        /// </summary>
        System.String IViewLogModel.RecId
        {
            get { return this.RecId; }
            set { this.RecId = (System.String)value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "VIEW_SOURCE" field.
        /// </summary>
        System.Byte IViewLogModel.Source
        {
            get { return this.Source; }
            set { this.Source = (System.Byte)value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "VIEW_REC_ID2" field.
        /// </summary>
        System.String IViewLogModel.RecId2
        {
            get { return this.RecId2; }
            set { this.RecId2 = (System.String)value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "VIEW_TABLE2" field.
        /// </summary>
        System.String IViewLogModel.Table2
        {
            get { return this.Table2; }
            set { this.Table2 = (System.String)value; }
        }

        #endregion
    }
}
