using System;
using System.Collections.Generic;
using System.Linq;
using Consensus.Common;

namespace Consensus.Contact
{
    /// <remarks>
    ///     THIS CODE HAS BEEN AUTOMATICALLY GENERATED USING THE CONSENSUS DEVELOPER TOOLS.
    ///     DO NOT EDIT THIS CODE AS ANY CUSTOM MODIFICATIONS WILL BE LOST UPON REGENERATION.
    /// </remarks>
    public partial class TimeSpent : Proxy<ITimeSpentModel, String>
    {
        #region fields

        /// <summary>
        ///     The client-consumable proxy instance for the <see cref="TimTypeDropdown" /> member.
        /// </summary>
        private Consensus.Common.Code _timTypeDropdown;

        #endregion

        #region properties

        /// <summary>
        ///     Gets or sets the value of the "TIM_RCV_DATE" field.
        /// </summary>
        public System.Nullable<System.DateTime> RcvDate
        {
            get { return this.Model.RcvDate; }
            set { this.Model.RcvDate = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "TIM_RCV_FROM" field.
        /// </summary>
        public System.String RcvFrom
        {
            get { return this.Model.RcvFrom; }
            set { this.Model.RcvFrom = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "TIM_ACT_ID" field.
        /// </summary>
        public System.String ActId
        {
            get { return this.Model.ActId; }
            set { this.Model.ActId = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "TIM_ROLE_ID" field.
        /// </summary>
        public System.String RoleId
        {
            get { return this.Model.RoleId; }
            set { this.Model.RoleId = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "TIM_HOURS" field.
        /// </summary>
        public System.Nullable<System.Double> Hours
        {
            get { return this.Model.Hours; }
            set { this.Model.Hours = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "TIM_DATE" field.
        /// </summary>
        public System.Nullable<System.DateTime> Date
        {
            get { return this.Model.Date; }
            set { this.Model.Date = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "TIM_TYPE" field.
        /// </summary>
        public System.String Type
        {
            get { return this.Model.Type; }
            set { this.Model.Type = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "TIM_DESC" field.
        /// </summary>
        public System.String Desc
        {
            get { return this.Model.Desc; }
            set { this.Model.Desc = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "TIM_ORG_ID" field.
        /// </summary>
        public System.String OrgId
        {
            get { return this.Model.OrgId; }
            set { this.Model.OrgId = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "TIM_TRA_HOURS" field.
        /// </summary>
        public System.Nullable<System.Double> TraHours
        {
            get { return this.Model.TraHours; }
            set { this.Model.TraHours = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "TIM_HOU_CHARGE" field.
        /// </summary>
        public System.Nullable<System.Double> HouCharge
        {
            get { return this.Model.HouCharge; }
            set { this.Model.HouCharge = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "TIM_TRA_CHARGE" field.
        /// </summary>
        public System.Nullable<System.Double> TraCharge
        {
            get { return this.Model.TraCharge; }
            set { this.Model.TraCharge = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "TIM_MILEAGE" field.
        /// </summary>
        public System.Nullable<System.Decimal> Mileage
        {
            get { return this.Model.Mileage; }
            set { this.Model.Mileage = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "TIM_EXPENSES" field.
        /// </summary>
        public System.Nullable<System.Decimal> Expenses
        {
            get { return this.Model.Expenses; }
            set { this.Model.Expenses = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "TIM_CST_AC" field.
        /// </summary>
        public System.Nullable<System.Double> CstAc
        {
            get { return this.Model.CstAc; }
            set { this.Model.CstAc = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "TIM_UNT_TYPE" field.
        /// </summary>
        public System.String UntType
        {
            get { return this.Model.UntType; }
            set { this.Model.UntType = value; }
        }

        /// <summary>
        ///     Gets the The value of the "TIM_DROPDOWN_1" field.
        /// </summary>
        public Consensus.Common.Code TimTypeDropdown
        {
            get
            {
                if (_timTypeDropdown == null && this.Model.TimTypeDropdown != null)
                    _timTypeDropdown = new Consensus.Common.Code(this.Model.TimTypeDropdown);
                if (_timTypeDropdown == null)
                    _timTypeDropdown = Consensus.Common.Code.Create();
                return _timTypeDropdown;
            }
        }

        /// <summary>
        ///     Gets or sets the unique code for the value of the "TIM_DROPDOWN_1" field.
        /// </summary>
        public System.String TimTypeDropdownCode
        {
            get { return this.Model.TimTypeDropdownCode; }
            set { this.Model.TimTypeDropdownCode = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "TIM_TRAIN_SY_TYPE" field.
        /// </summary>
        public System.Int16 TrainSyType
        {
            get { return this.Model.TrainSyType; }
            set { this.Model.TrainSyType = value; }
        }

        #endregion

        #region constructors

        /// <summary>
        ///     Initialises a new instance of the client-consumable class.
        /// </summary>
        internal TimeSpent(ITimeSpentModel model) : base(model)
        {
        }

        #endregion

        #region methods

        /// <summary>
        ///     Creates a new <see cref="!:TimeSpentModel" /> instance.
        /// </summary>
        /// <returns>
        ///     A newly instantiated <see cref="!:TimeSpentModel" /> instance.
        /// </returns>
        public static Consensus.Contact.TimeSpent Create()
        {
            ConsensusSite site = ConsensusDomain.Configuration[ConsensusDomain.Configuration.DefaultSite];
            return TimeSpent.Create(site);
        }

        /// <summary>
        ///     Creates a new <see cref="!:TimeSpentModel" /> instance.
        /// </summary>
        /// <returns>
        ///     A newly instantiated <see cref="!:TimeSpentModel" /> instance.
        /// </returns>
        public static Consensus.Contact.TimeSpent Create(ConsensusSite site)
        {
            IBusinessProvider provider = site.GetService<IBusinessProvider>();
            Consensus.Contact.ITimeSpentModel model = provider.Contact.TimeSpent.Create();
            return model == null ? null : new Consensus.Contact.TimeSpent(model);
        }

        /// <summary>
        ///     Retrieves all instances of the <see cref="!:TimeSpentModel" /> class.
        /// </summary>
        /// <returns>
        ///     An enumerable collection of <see cref="!:TimeSpentModel" /> instances.
        /// </returns>
        public static IEnumerable<Consensus.Contact.TimeSpent> FetchAll()
        {
            ConsensusSite site = ConsensusDomain.Configuration[ConsensusDomain.Configuration.DefaultSite];
            return TimeSpent.FetchAll(site);
        }

        /// <summary>
        ///     Retrieves all instances of the <see cref="!:TimeSpentModel" /> class.
        /// </summary>
        /// <returns>
        ///     An enumerable collection of <see cref="!:TimeSpentModel" /> instances.
        /// </returns>
        public static IEnumerable<Consensus.Contact.TimeSpent> FetchAll(ConsensusSite site)
        {
            IBusinessProvider provider = site.GetService<IBusinessProvider>();
            IEnumerable<Consensus.Contact.ITimeSpentModel> collection = provider.Contact.TimeSpent.FetchAll();
            return collection.Select(model => new Consensus.Contact.TimeSpent(model));
        }

        /// <summary>
        ///     Retrieves a specific <see cref="!:TimeSpentModel" /> instance.
        /// </summary>
        /// <param name="id">
        ///     The unique value which distinctly identifies the <see cref="!:TimeSpentModel" /> instance to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:TimeSpentModel" /> instance that matches the specified <paramref name="id" />; or null, if no matching instance can be found.
        /// </returns>
        public static Consensus.Contact.TimeSpent FetchById(System.String id)
        {
            ConsensusSite site = ConsensusDomain.Configuration[ConsensusDomain.Configuration.DefaultSite];
            return TimeSpent.FetchById(site,id);
        }

        /// <summary>
        ///     Retrieves a specific <see cref="!:TimeSpentModel" /> instance.
        /// </summary>
        /// <param name="id">
        ///     The unique value which distinctly identifies the <see cref="!:TimeSpentModel" /> instance to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:TimeSpentModel" /> instance that matches the specified <paramref name="id" />; or null, if no matching instance can be found.
        /// </returns>
        public static Consensus.Contact.TimeSpent FetchById(ConsensusSite site, System.String id)
        {
            IBusinessProvider provider = site.GetService<IBusinessProvider>();
            Consensus.Contact.ITimeSpentModel model = provider.Contact.TimeSpent.FetchById(id);
            return model == null ? null : new Consensus.Contact.TimeSpent(model);
        }

        public static System.String GetTableName()
        {
            ConsensusSite site = ConsensusDomain.Configuration[ConsensusDomain.Configuration.DefaultSite];
            return TimeSpent.GetTableName(site);
        }

        public static System.String GetTableName(ConsensusSite site)
        {
            IBusinessProvider provider = site.GetService<IBusinessProvider>();
            return provider.Contact.TimeSpent.GetTableName();
        }

        #endregion
    }
}
