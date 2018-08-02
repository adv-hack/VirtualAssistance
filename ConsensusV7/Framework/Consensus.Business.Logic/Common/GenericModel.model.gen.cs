using System;
using System.Collections.Generic;
using System.Linq;

namespace Consensus.Common
{
    /// <summary>
    ///     Encapsulates the <see cref="GenericmodeltableRecord" /> with standardised business rules.
    /// </summary>
    /// <remarks>
    ///     THIS CODE HAS BEEN AUTOMATICALLY GENERATED USING THE CONSENSUS DEVELOPER TOOLS.
    ///     DO NOT EDIT THIS CODE AS ANY CUSTOM MODIFICATIONS WILL BE LOST UPON REGENERATION.
    /// </remarks>
    public partial class LocalGenericModelModel : LocalModel<GenericmodeltableRecord, String>, IGenericModelModel
    {
        #region properties

        /// <summary>
        ///     Gets the delegated function that is responsible for persisting a new instance of the data structure within the underlying persistence mechanism.
        /// </summary>
        protected override Action<GenericmodeltableRecord> DataCreator
        {
            get { return this.Provider.DataProvider.Common.GenericModel.Create; }
        }

        /// <summary>
        ///     Gets the delegated function that is responsible for persisting an existing instance of the data structure within the underlying persistence mechanism.
        /// </summary>
        protected override Action<GenericmodeltableRecord> DataModifier
        {
            get { return this.Provider.DataProvider.Common.GenericModel.Modify; }
        }

        /// <summary>
        ///     Gets the delegated function that is responsible for removing an existing instance of the data structure from the underlying persistence mechanism.
        /// </summary>
        protected override Action<GenericmodeltableRecord> DataRemover
        {
            get { return this.Provider.DataProvider.Common.GenericModel.RemoveById; }
        }

        /// <summary>
        ///     Gets or sets the value of the "GMT_ID1" field.
        /// </summary>
        public String Id1
        {
            get { return this.ModifiedData.Id1; }
            set { this.ModifiedData.Id1 = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "GMT_ID2" field.
        /// </summary>
        public String Id2
        {
            get { return this.ModifiedData.Id2; }
            set { this.ModifiedData.Id2 = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "GMT_ID3" field.
        /// </summary>
        public String Id3
        {
            get { return this.ModifiedData.Id3; }
            set { this.ModifiedData.Id3 = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "GMT_ID4" field.
        /// </summary>
        public String Id4
        {
            get { return this.ModifiedData.Id4; }
            set { this.ModifiedData.Id4 = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "GMT_ID5" field.
        /// </summary>
        public String Id5
        {
            get { return this.ModifiedData.Id5; }
            set { this.ModifiedData.Id5 = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "GMT_DESC1" field.
        /// </summary>
        public String Desc1
        {
            get { return this.ModifiedData.Desc1; }
            set { this.ModifiedData.Desc1 = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "GMT_DESC2" field.
        /// </summary>
        public String Desc2
        {
            get { return this.ModifiedData.Desc2; }
            set { this.ModifiedData.Desc2 = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "GMT_DESC3" field.
        /// </summary>
        public String Desc3
        {
            get { return this.ModifiedData.Desc3; }
            set { this.ModifiedData.Desc3 = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "GMT_DESC4" field.
        /// </summary>
        public String Desc4
        {
            get { return this.ModifiedData.Desc4; }
            set { this.ModifiedData.Desc4 = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "GMT_DESC5" field.
        /// </summary>
        public String Desc5
        {
            get { return this.ModifiedData.Desc5; }
            set { this.ModifiedData.Desc5 = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "GMT_LONGDESC" field.
        /// </summary>
        public String Longdesc
        {
            get { return this.ModifiedData.Longdesc; }
            set { this.ModifiedData.Longdesc = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "GMT_DATE1" field.
        /// </summary>
        public DateTime? Date1
        {
            get { return this.ModifiedData.Date1; }
            set { this.ModifiedData.Date1 = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "GMT_DATE2" field.
        /// </summary>
        public DateTime? Date2
        {
            get { return this.ModifiedData.Date2; }
            set { this.ModifiedData.Date2 = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "GMT_DATE3" field.
        /// </summary>
        public DateTime? Date3
        {
            get { return this.ModifiedData.Date3; }
            set { this.ModifiedData.Date3 = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "GMT_INT1" field.
        /// </summary>
        public Int32? Int1
        {
            get { return this.ModifiedData.Int1; }
            set { this.ModifiedData.Int1 = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "GMT_INT2" field.
        /// </summary>
        public Int32? Int2
        {
            get { return this.ModifiedData.Int2; }
            set { this.ModifiedData.Int2 = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "GMT_INT3" field.
        /// </summary>
        public Int32? Int3
        {
            get { return this.ModifiedData.Int3; }
            set { this.ModifiedData.Int3 = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "GMT_MONEY1" field.
        /// </summary>
        public Decimal? Money1
        {
            get { return this.ModifiedData.Money1; }
            set { this.ModifiedData.Money1 = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "GMT_MONEY2" field.
        /// </summary>
        public Decimal? Money2
        {
            get { return this.ModifiedData.Money2; }
            set { this.ModifiedData.Money2 = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "GMT_MONEY3" field.
        /// </summary>
        public Decimal? Money3
        {
            get { return this.ModifiedData.Money3; }
            set { this.ModifiedData.Money3 = value; }
        }

        #endregion

        #region constructors

        /// <summary>
        ///     Initialises a new <see cref="LocalGenericModelModel" /> instance.
        /// </summary>
        /// <param name="provider">
        ///     The business provider to which the business model is bound.
        /// </param>
        internal LocalGenericModelModel(LocalProvider provider) : base(provider)
        {
        }

        /// <summary>
        ///     Initialises a new <see cref="LocalGenericModelModel" /> instance.
        /// </summary>
        /// <param name="provider">
        ///     The business provider to which the business model is bound.
        /// </param>
        /// <param name="record">
        ///     The data record which is encapsulated by the business model.
        /// </param>
        internal LocalGenericModelModel(LocalProvider provider, GenericmodeltableRecord record) : base(provider, record)
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
        ///     Gets or sets the value of the "GMT_ID1" field.
        /// </summary>
        System.String IGenericModelModel.Id1
        {
            get { return this.Id1; }
            set { this.Id1 = (System.String)value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "GMT_ID2" field.
        /// </summary>
        System.String IGenericModelModel.Id2
        {
            get { return this.Id2; }
            set { this.Id2 = (System.String)value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "GMT_ID3" field.
        /// </summary>
        System.String IGenericModelModel.Id3
        {
            get { return this.Id3; }
            set { this.Id3 = (System.String)value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "GMT_ID4" field.
        /// </summary>
        System.String IGenericModelModel.Id4
        {
            get { return this.Id4; }
            set { this.Id4 = (System.String)value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "GMT_ID5" field.
        /// </summary>
        System.String IGenericModelModel.Id5
        {
            get { return this.Id5; }
            set { this.Id5 = (System.String)value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "GMT_DESC1" field.
        /// </summary>
        System.String IGenericModelModel.Desc1
        {
            get { return this.Desc1; }
            set { this.Desc1 = (System.String)value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "GMT_DESC2" field.
        /// </summary>
        System.String IGenericModelModel.Desc2
        {
            get { return this.Desc2; }
            set { this.Desc2 = (System.String)value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "GMT_DESC3" field.
        /// </summary>
        System.String IGenericModelModel.Desc3
        {
            get { return this.Desc3; }
            set { this.Desc3 = (System.String)value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "GMT_DESC4" field.
        /// </summary>
        System.String IGenericModelModel.Desc4
        {
            get { return this.Desc4; }
            set { this.Desc4 = (System.String)value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "GMT_DESC5" field.
        /// </summary>
        System.String IGenericModelModel.Desc5
        {
            get { return this.Desc5; }
            set { this.Desc5 = (System.String)value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "GMT_LONGDESC" field.
        /// </summary>
        System.String IGenericModelModel.Longdesc
        {
            get { return this.Longdesc; }
            set { this.Longdesc = (System.String)value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "GMT_DATE1" field.
        /// </summary>
        System.Nullable<System.DateTime> IGenericModelModel.Date1
        {
            get { return this.Date1; }
            set { this.Date1 = (System.Nullable<System.DateTime>)value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "GMT_DATE2" field.
        /// </summary>
        System.Nullable<System.DateTime> IGenericModelModel.Date2
        {
            get { return this.Date2; }
            set { this.Date2 = (System.Nullable<System.DateTime>)value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "GMT_DATE3" field.
        /// </summary>
        System.Nullable<System.DateTime> IGenericModelModel.Date3
        {
            get { return this.Date3; }
            set { this.Date3 = (System.Nullable<System.DateTime>)value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "GMT_INT1" field.
        /// </summary>
        System.Nullable<System.Int32> IGenericModelModel.Int1
        {
            get { return this.Int1; }
            set { this.Int1 = (System.Nullable<System.Int32>)value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "GMT_INT2" field.
        /// </summary>
        System.Nullable<System.Int32> IGenericModelModel.Int2
        {
            get { return this.Int2; }
            set { this.Int2 = (System.Nullable<System.Int32>)value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "GMT_INT3" field.
        /// </summary>
        System.Nullable<System.Int32> IGenericModelModel.Int3
        {
            get { return this.Int3; }
            set { this.Int3 = (System.Nullable<System.Int32>)value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "GMT_MONEY1" field.
        /// </summary>
        System.Nullable<System.Decimal> IGenericModelModel.Money1
        {
            get { return this.Money1; }
            set { this.Money1 = (System.Nullable<System.Decimal>)value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "GMT_MONEY2" field.
        /// </summary>
        System.Nullable<System.Decimal> IGenericModelModel.Money2
        {
            get { return this.Money2; }
            set { this.Money2 = (System.Nullable<System.Decimal>)value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "GMT_MONEY3" field.
        /// </summary>
        System.Nullable<System.Decimal> IGenericModelModel.Money3
        {
            get { return this.Money3; }
            set { this.Money3 = (System.Nullable<System.Decimal>)value; }
        }

        #endregion
    }
}
