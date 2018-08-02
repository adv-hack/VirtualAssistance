using System;
using System.Collections.Generic;
using System.Linq;

namespace Consensus.Common
{
    /// <summary>
    ///     Encapsulates the <see cref="CodeRecord" /> with standardised business rules.
    /// </summary>
    /// <remarks>
    ///     THIS CODE HAS BEEN AUTOMATICALLY GENERATED USING THE CONSENSUS DEVELOPER TOOLS.
    ///     DO NOT EDIT THIS CODE AS ANY CUSTOM MODIFICATIONS WILL BE LOST UPON REGENERATION.
    /// </remarks>
    public partial class LocalCodeModel : LocalModel<CodeRecord, String>, ICodeModel
    {
        #region properties

        /// <summary>
        ///     Gets the delegated function that is responsible for persisting a new instance of the data structure within the underlying persistence mechanism.
        /// </summary>
        protected override Action<CodeRecord> DataCreator
        {
            get { return this.Provider.DataProvider.Common.Code.Create; }
        }

        /// <summary>
        ///     Gets the delegated function that is responsible for persisting an existing instance of the data structure within the underlying persistence mechanism.
        /// </summary>
        protected override Action<CodeRecord> DataModifier
        {
            get { return this.Provider.DataProvider.Common.Code.Modify; }
        }

        /// <summary>
        ///     Gets the delegated function that is responsible for removing an existing instance of the data structure from the underlying persistence mechanism.
        /// </summary>
        protected override Action<CodeRecord> DataRemover
        {
            get { return this.Provider.DataProvider.Common.Code.RemoveById; }
        }

        /// <summary>
        ///     Gets or sets the value of the "CODE_TYPE" field.
        /// </summary>
        public String Type
        {
            get { return this.ModifiedData.Type; }
            set { this.ModifiedData.Type = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "CODE_VALUE1" field.
        /// </summary>
        public String Value1
        {
            get { return this.ModifiedData.Value1; }
            set { this.ModifiedData.Value1 = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "CODE_VALUE2" field.
        /// </summary>
        public String Value2
        {
            get { return this.ModifiedData.Value2; }
            set { this.ModifiedData.Value2 = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "CODE_VALUE3" field.
        /// </summary>
        public String Value3
        {
            get { return this.ModifiedData.Value3; }
            set { this.ModifiedData.Value3 = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "CODE_DESCRIPTION" field.
        /// </summary>
        public String Description
        {
            get { return this.ModifiedData.Description; }
            set { this.ModifiedData.Description = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "CODE_VALUE4" field.
        /// </summary>
        public String Value4
        {
            get { return this.ModifiedData.Value4; }
            set { this.ModifiedData.Value4 = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "CODE_SYSTEM" field.
        /// </summary>
        public Byte? System
        {
            get { return this.ModifiedData.System; }
            set { this.ModifiedData.System = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "CODE_DELETED" field.
        /// </summary>
        public Byte? Deleted
        {
            get { return this.ModifiedData.Deleted; }
            set { this.ModifiedData.Deleted = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "CODE_READ_ONLY" field.
        /// </summary>
        public Byte? ReadOnly
        {
            get { return this.ModifiedData.ReadOnly; }
            set { this.ModifiedData.ReadOnly = value; }
        }

        #endregion

        #region constructors

        /// <summary>
        ///     Initialises a new <see cref="LocalCodeModel" /> instance.
        /// </summary>
        /// <param name="provider">
        ///     The business provider to which the business model is bound.
        /// </param>
        internal LocalCodeModel(LocalProvider provider) : base(provider)
        {
        }

        /// <summary>
        ///     Initialises a new <see cref="LocalCodeModel" /> instance.
        /// </summary>
        /// <param name="provider">
        ///     The business provider to which the business model is bound.
        /// </param>
        /// <param name="record">
        ///     The data record which is encapsulated by the business model.
        /// </param>
        internal LocalCodeModel(LocalProvider provider, CodeRecord record) : base(provider, record)
        {
        }

        #endregion

        #region implementations

        /// <summary>
        ///     Gets or sets the value of the "CODE_TYPE" field.
        /// </summary>
        System.String ICodeModel.Type
        {
            get { return this.Type; }
            set { this.Type = (System.String)value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "CODE_VALUE1" field.
        /// </summary>
        System.String ICodeModel.Value1
        {
            get { return this.Value1; }
            set { this.Value1 = (System.String)value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "CODE_VALUE2" field.
        /// </summary>
        System.String ICodeModel.Value2
        {
            get { return this.Value2; }
            set { this.Value2 = (System.String)value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "CODE_VALUE3" field.
        /// </summary>
        System.String ICodeModel.Value3
        {
            get { return this.Value3; }
            set { this.Value3 = (System.String)value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "CODE_DESCRIPTION" field.
        /// </summary>
        System.String ICodeModel.Description
        {
            get { return this.Description; }
            set { this.Description = (System.String)value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "CODE_VALUE4" field.
        /// </summary>
        System.String ICodeModel.Value4
        {
            get { return this.Value4; }
            set { this.Value4 = (System.String)value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "CODE_SYSTEM" field.
        /// </summary>
        System.Nullable<System.Byte> ICodeModel.System
        {
            get { return this.System; }
            set { this.System = (System.Nullable<System.Byte>)value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "CODE_DELETED" field.
        /// </summary>
        System.Nullable<System.Byte> ICodeModel.Deleted
        {
            get { return this.Deleted; }
            set { this.Deleted = (System.Nullable<System.Byte>)value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "CODE_READ_ONLY" field.
        /// </summary>
        System.Nullable<System.Byte> ICodeModel.ReadOnly
        {
            get { return this.ReadOnly; }
            set { this.ReadOnly = (System.Nullable<System.Byte>)value; }
        }

        #endregion
    }
}
