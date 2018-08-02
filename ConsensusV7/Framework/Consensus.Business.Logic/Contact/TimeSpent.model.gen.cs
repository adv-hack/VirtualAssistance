using System;
using System.Collections.Generic;
using System.Linq;
using Consensus.Common;

namespace Consensus.Contact
{
    /// <summary>
    ///     Encapsulates the <see cref="TimeSpentRecord" /> with standardised business rules.
    /// </summary>
    /// <remarks>
    ///     THIS CODE HAS BEEN AUTOMATICALLY GENERATED USING THE CONSENSUS DEVELOPER TOOLS.
    ///     DO NOT EDIT THIS CODE AS ANY CUSTOM MODIFICATIONS WILL BE LOST UPON REGENERATION.
    /// </remarks>
    public partial class LocalTimeSpentModel : LocalModel<TimeSpentRecord, String>, ITimeSpentModel
    {
        #region fields

        /// <summary>
        ///     The value of the "TIM_DROPDOWN_1" field.
        /// </summary>
        private LocalCodeModel _timTypeDropdown;

        #endregion

        #region properties

        /// <summary>
        ///     Gets the delegated function that is responsible for persisting a new instance of the data structure within the underlying persistence mechanism.
        /// </summary>
        protected override Action<TimeSpentRecord> DataCreator
        {
            get { return this.Provider.DataProvider.Contact.TimeSpent.Create; }
        }

        /// <summary>
        ///     Gets the delegated function that is responsible for persisting an existing instance of the data structure within the underlying persistence mechanism.
        /// </summary>
        protected override Action<TimeSpentRecord> DataModifier
        {
            get { return this.Provider.DataProvider.Contact.TimeSpent.Modify; }
        }

        /// <summary>
        ///     Gets the delegated function that is responsible for removing an existing instance of the data structure from the underlying persistence mechanism.
        /// </summary>
        protected override Action<TimeSpentRecord> DataRemover
        {
            get { return this.Provider.DataProvider.Contact.TimeSpent.RemoveById; }
        }

        /// <summary>
        ///     Gets or sets the value of the "TIM_RCV_DATE" field.
        /// </summary>
        public DateTime? RcvDate
        {
            get { return this.ModifiedData.RcvDate; }
            set { this.ModifiedData.RcvDate = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "TIM_RCV_FROM" field.
        /// </summary>
        public String RcvFrom
        {
            get { return this.ModifiedData.RcvFrom; }
            set { this.ModifiedData.RcvFrom = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "TIM_ACT_ID" field.
        /// </summary>
        public String ActId
        {
            get { return this.ModifiedData.ActId; }
            set { this.ModifiedData.ActId = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "TIM_ROLE_ID" field.
        /// </summary>
        public String RoleId
        {
            get { return this.ModifiedData.RoleId; }
            set { this.ModifiedData.RoleId = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "TIM_HOURS" field.
        /// </summary>
        public Double? Hours
        {
            get { return this.ModifiedData.Hours; }
            set { this.ModifiedData.Hours = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "TIM_DATE" field.
        /// </summary>
        public DateTime? Date
        {
            get { return this.ModifiedData.Date; }
            set { this.ModifiedData.Date = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "TIM_TYPE" field.
        /// </summary>
        public String Type
        {
            get { return this.ModifiedData.Type; }
            set { this.ModifiedData.Type = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "TIM_DESC" field.
        /// </summary>
        public String Desc
        {
            get { return this.ModifiedData.Desc; }
            set { this.ModifiedData.Desc = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "TIM_ORG_ID" field.
        /// </summary>
        public String OrgId
        {
            get { return this.ModifiedData.OrgId; }
            set { this.ModifiedData.OrgId = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "TIM_TRA_HOURS" field.
        /// </summary>
        public Double? TraHours
        {
            get { return this.ModifiedData.TraHours; }
            set { this.ModifiedData.TraHours = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "TIM_HOU_CHARGE" field.
        /// </summary>
        public Double? HouCharge
        {
            get { return this.ModifiedData.HouCharge; }
            set { this.ModifiedData.HouCharge = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "TIM_TRA_CHARGE" field.
        /// </summary>
        public Double? TraCharge
        {
            get { return this.ModifiedData.TraCharge; }
            set { this.ModifiedData.TraCharge = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "TIM_MILEAGE" field.
        /// </summary>
        public Decimal? Mileage
        {
            get { return this.ModifiedData.Mileage; }
            set { this.ModifiedData.Mileage = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "TIM_EXPENSES" field.
        /// </summary>
        public Decimal? Expenses
        {
            get { return this.ModifiedData.Expenses; }
            set { this.ModifiedData.Expenses = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "TIM_CST_AC" field.
        /// </summary>
        public Double? CstAc
        {
            get { return this.ModifiedData.CstAc; }
            set { this.ModifiedData.CstAc = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "TIM_UNT_TYPE" field.
        /// </summary>
        public String UntType
        {
            get { return this.ModifiedData.UntType; }
            set { this.ModifiedData.UntType = value; }
        }

        /// <summary>
        ///     Gets the The value of the "TIM_DROPDOWN_1" field.
        /// </summary>
        public LocalCodeModel TimTypeDropdown
        {
            get
            {
                if (_timTypeDropdown == null && !String.IsNullOrEmpty(this.TimTypeDropdownCode))
                    _timTypeDropdown = this.Provider.Common.Code.FetchByTypeAndCode("", this.TimTypeDropdownCode);
                if (_timTypeDropdown == null)
                    _timTypeDropdown = this.Provider.Common.Code.Create("");
                return _timTypeDropdown;
            }
        }

        /// <summary>
        ///     Gets or sets the unique code for the value of the "TIM_DROPDOWN_1" field.
        /// </summary>
        public String TimTypeDropdownCode
        {
            get { return this.ModifiedData.TimType; }
            set
            {
                if (this.ModifiedData.TimType != value)
                     _timTypeDropdown = null;
                this.ModifiedData.TimType = value;
            }
        }

        /// <summary>
        ///     Gets or sets the value of the "TIM_TRAIN_SY_TYPE" field.
        /// </summary>
        public Int16 TrainSyType
        {
            get { return this.ModifiedData.TrainSyType; }
            set { this.ModifiedData.TrainSyType = value; }
        }

        #endregion

        #region constructors

        /// <summary>
        ///     Initialises a new <see cref="LocalTimeSpentModel" /> instance.
        /// </summary>
        /// <param name="provider">
        ///     The business provider to which the business model is bound.
        /// </param>
        internal LocalTimeSpentModel(LocalProvider provider) : base(provider)
        {
        }

        /// <summary>
        ///     Initialises a new <see cref="LocalTimeSpentModel" /> instance.
        /// </summary>
        /// <param name="provider">
        ///     The business provider to which the business model is bound.
        /// </param>
        /// <param name="record">
        ///     The data record which is encapsulated by the business model.
        /// </param>
        internal LocalTimeSpentModel(LocalProvider provider, TimeSpentRecord record) : base(provider, record)
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
            if (_timTypeDropdown != null)
            {
                _timTypeDropdown.Save();
                this.ModifiedData.TimType = _timTypeDropdown.Value1;
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
        ///     Gets or sets the value of the "TIM_RCV_DATE" field.
        /// </summary>
        System.Nullable<System.DateTime> ITimeSpentModel.RcvDate
        {
            get { return this.RcvDate; }
            set { this.RcvDate = (System.Nullable<System.DateTime>)value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "TIM_RCV_FROM" field.
        /// </summary>
        System.String ITimeSpentModel.RcvFrom
        {
            get { return this.RcvFrom; }
            set { this.RcvFrom = (System.String)value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "TIM_ACT_ID" field.
        /// </summary>
        System.String ITimeSpentModel.ActId
        {
            get { return this.ActId; }
            set { this.ActId = (System.String)value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "TIM_ROLE_ID" field.
        /// </summary>
        System.String ITimeSpentModel.RoleId
        {
            get { return this.RoleId; }
            set { this.RoleId = (System.String)value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "TIM_HOURS" field.
        /// </summary>
        System.Nullable<System.Double> ITimeSpentModel.Hours
        {
            get { return this.Hours; }
            set { this.Hours = (System.Nullable<System.Double>)value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "TIM_DATE" field.
        /// </summary>
        System.Nullable<System.DateTime> ITimeSpentModel.Date
        {
            get { return this.Date; }
            set { this.Date = (System.Nullable<System.DateTime>)value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "TIM_TYPE" field.
        /// </summary>
        System.String ITimeSpentModel.Type
        {
            get { return this.Type; }
            set { this.Type = (System.String)value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "TIM_DESC" field.
        /// </summary>
        System.String ITimeSpentModel.Desc
        {
            get { return this.Desc; }
            set { this.Desc = (System.String)value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "TIM_ORG_ID" field.
        /// </summary>
        System.String ITimeSpentModel.OrgId
        {
            get { return this.OrgId; }
            set { this.OrgId = (System.String)value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "TIM_TRA_HOURS" field.
        /// </summary>
        System.Nullable<System.Double> ITimeSpentModel.TraHours
        {
            get { return this.TraHours; }
            set { this.TraHours = (System.Nullable<System.Double>)value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "TIM_HOU_CHARGE" field.
        /// </summary>
        System.Nullable<System.Double> ITimeSpentModel.HouCharge
        {
            get { return this.HouCharge; }
            set { this.HouCharge = (System.Nullable<System.Double>)value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "TIM_TRA_CHARGE" field.
        /// </summary>
        System.Nullable<System.Double> ITimeSpentModel.TraCharge
        {
            get { return this.TraCharge; }
            set { this.TraCharge = (System.Nullable<System.Double>)value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "TIM_MILEAGE" field.
        /// </summary>
        System.Nullable<System.Decimal> ITimeSpentModel.Mileage
        {
            get { return this.Mileage; }
            set { this.Mileage = (System.Nullable<System.Decimal>)value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "TIM_EXPENSES" field.
        /// </summary>
        System.Nullable<System.Decimal> ITimeSpentModel.Expenses
        {
            get { return this.Expenses; }
            set { this.Expenses = (System.Nullable<System.Decimal>)value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "TIM_CST_AC" field.
        /// </summary>
        System.Nullable<System.Double> ITimeSpentModel.CstAc
        {
            get { return this.CstAc; }
            set { this.CstAc = (System.Nullable<System.Double>)value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "TIM_UNT_TYPE" field.
        /// </summary>
        System.String ITimeSpentModel.UntType
        {
            get { return this.UntType; }
            set { this.UntType = (System.String)value; }
        }

        /// <summary>
        ///     Gets the The value of the "TIM_DROPDOWN_1" field.
        /// </summary>
        Consensus.Common.ICodeModel ITimeSpentModel.TimTypeDropdown
        {
            get { return this.TimTypeDropdown; }
        }

        /// <summary>
        ///     Gets or sets the unique code for the value of the "TIM_DROPDOWN_1" field.
        /// </summary>
        System.String ITimeSpentModel.TimTypeDropdownCode
        {
            get { return this.TimTypeDropdownCode; }
            set { this.TimTypeDropdownCode = (System.String)value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "TIM_TRAIN_SY_TYPE" field.
        /// </summary>
        System.Int16 ITimeSpentModel.TrainSyType
        {
            get { return this.TrainSyType; }
            set { this.TrainSyType = (System.Int16)value; }
        }

        #endregion
    }
}
