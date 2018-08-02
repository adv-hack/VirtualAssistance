using System;
using System.Collections.Generic;
using System.Linq;
using Consensus.Membership;

namespace Consensus.Finance
{
    /// <summary>
    ///     Encapsulates the <see cref="DirectdebitRecord" /> with standardised business rules.
    /// </summary>
    /// <remarks>
    ///     THIS CODE HAS BEEN AUTOMATICALLY GENERATED USING THE CONSENSUS DEVELOPER TOOLS.
    ///     DO NOT EDIT THIS CODE AS ANY CUSTOM MODIFICATIONS WILL BE LOST UPON REGENERATION.
    /// </remarks>
    public partial class LocalDirectDebitModel : LocalModel<DirectdebitRecord, String>, IDirectDebitModel
    {
        #region fields

        /// <summary>
        ///     The value of the "DD_REC_ID" field.
        /// </summary>
        private LocalMemberPeriodModel _memberPeriod;

        #endregion

        #region properties

        /// <summary>
        ///     Gets the delegated function that is responsible for persisting a new instance of the data structure within the underlying persistence mechanism.
        /// </summary>
        protected override Action<DirectdebitRecord> DataCreator
        {
            get { return this.Provider.DataProvider.Finance.DirectDebit.Create; }
        }

        /// <summary>
        ///     Gets the delegated function that is responsible for persisting an existing instance of the data structure within the underlying persistence mechanism.
        /// </summary>
        protected override Action<DirectdebitRecord> DataModifier
        {
            get { return this.Provider.DataProvider.Finance.DirectDebit.Modify; }
        }

        /// <summary>
        ///     Gets the delegated function that is responsible for removing an existing instance of the data structure from the underlying persistence mechanism.
        /// </summary>
        protected override Action<DirectdebitRecord> DataRemover
        {
            get { return this.Provider.DataProvider.Finance.DirectDebit.RemoveById; }
        }

        /// <summary>
        ///     Gets or sets the value of the "DD_TABLE_NUM" field.
        /// </summary>
        public Double? TableNum
        {
            get { return this.ModifiedData.TableNum; }
            set { this.ModifiedData.TableNum = value; }
        }

        /// <summary>
        ///     Gets the The value of the "DD_REC_ID" field.
        /// </summary>
        public LocalMemberPeriodModel MemberPeriod
        {
            get
            {
                if (_memberPeriod == null && this.MemberPeriodId != null)
                    _memberPeriod = this.Provider.Membership.MemberPeriod.FetchById(this.MemberPeriodId);
                if (_memberPeriod == null)
                    _memberPeriod = this.Provider.Membership.MemberPeriod.Create();
                
                return _memberPeriod;
            }
        }

        /// <summary>
        ///     Gets or sets the unique code for the value of the "DD_REC_ID" field.
        /// </summary>
        public String MemberPeriodId
        {
            get { return this.ModifiedData.RecId; }
            set
            {
                if (this.ModifiedData.RecId != value)
                     _memberPeriod = null;
                this.ModifiedData.RecId = value;
            }
        }

        /// <summary>
        ///     Gets or sets the value of the "DD_TYPE" field.
        /// </summary>
        public Int32? Type
        {
            get { return this.ModifiedData.Type; }
            set { this.ModifiedData.Type = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "DD_OIN" field.
        /// </summary>
        public String ServiceUserNumber
        {
            get { return this.ModifiedData.Oin; }
            set { this.ModifiedData.Oin = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "DD_REC_DATE" field.
        /// </summary>
        public DateTime? RecDate
        {
            get { return this.ModifiedData.RecDate; }
            set { this.ModifiedData.RecDate = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "DD_REC_METHOD" field.
        /// </summary>
        public Int32? RecMethod
        {
            get { return this.ModifiedData.RecMethod; }
            set { this.ModifiedData.RecMethod = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "DD_EFFECTIVE_DATE" field.
        /// </summary>
        public DateTime? EffectiveDate
        {
            get { return this.ModifiedData.EffectiveDate; }
            set { this.ModifiedData.EffectiveDate = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "DD_END_DATE" field.
        /// </summary>
        public DateTime? EndDate
        {
            get { return this.ModifiedData.EndDate; }
            set { this.ModifiedData.EndDate = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "DD_STATUS" field.
        /// </summary>
        public Int32? Status
        {
            get { return this.ModifiedData.Status; }
            set { this.ModifiedData.Status = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "DD_FREQUENCY" field.
        /// </summary>
        public Int32? Frequency
        {
            get { return this.ModifiedData.Frequency; }
            set { this.ModifiedData.Frequency = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "DD_DAY_OF_MONTH" field.
        /// </summary>
        public Int32? DayOfMonth
        {
            get { return this.ModifiedData.DayOfMonth; }
            set { this.ModifiedData.DayOfMonth = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "DD_VARIABLE" field.
        /// </summary>
        public Int32? Variable
        {
            get { return this.ModifiedData.Variable; }
            set { this.ModifiedData.Variable = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "DD_MAX_VALUE" field.
        /// </summary>
        public Decimal? MaxValue
        {
            get { return this.ModifiedData.MaxValue; }
            set { this.ModifiedData.MaxValue = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "DD_BANK_NAME" field.
        /// </summary>
        public String BankName
        {
            get { return this.ModifiedData.BankName; }
            set { this.ModifiedData.BankName = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "DD_BANK_ADD_1" field.
        /// </summary>
        public String BankAdd1
        {
            get { return this.ModifiedData.BankAdd1; }
            set { this.ModifiedData.BankAdd1 = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "DD_BANK_ADD_2" field.
        /// </summary>
        public String BankAdd2
        {
            get { return this.ModifiedData.BankAdd2; }
            set { this.ModifiedData.BankAdd2 = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "DD_BANK_ADD_3" field.
        /// </summary>
        public String BankAdd3
        {
            get { return this.ModifiedData.BankAdd3; }
            set { this.ModifiedData.BankAdd3 = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "DD_BANK_ADD_4" field.
        /// </summary>
        public String BankAdd4
        {
            get { return this.ModifiedData.BankAdd4; }
            set { this.ModifiedData.BankAdd4 = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "DD_BANK_POSTCODE" field.
        /// </summary>
        public String BankPostcode
        {
            get { return this.ModifiedData.BankPostcode; }
            set { this.ModifiedData.BankPostcode = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "DD_BANK_ACC_NAME" field.
        /// </summary>
        public String BankAccName
        {
            get { return this.ModifiedData.BankAccName; }
            set { this.ModifiedData.BankAccName = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "DD_BANK_ACC_CODE" field.
        /// </summary>
        public String BankAccCode
        {
            get { return this.ModifiedData.BankAccCode; }
            set { this.ModifiedData.BankAccCode = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "DD_SORT_CODE" field.
        /// </summary>
        public String SortCode
        {
            get { return this.ModifiedData.SortCode; }
            set { this.ModifiedData.SortCode = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "DD_TOTAL" field.
        /// </summary>
        public Decimal? Total
        {
            get { return this.ModifiedData.Total; }
            set { this.ModifiedData.Total = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "DD_NO_OF_INSTALLMENTS" field.
        /// </summary>
        public Int32? NoOfInstallments
        {
            get { return this.ModifiedData.NoOfInstallments; }
            set { this.ModifiedData.NoOfInstallments = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "DD_DUE_DATE" field.
        /// </summary>
        public DateTime? DueDate
        {
            get { return this.ModifiedData.DueDate; }
            set { this.ModifiedData.DueDate = value; }
        }

        #endregion

        #region constructors

        /// <summary>
        ///     Initialises a new <see cref="LocalDirectDebitModel" /> instance.
        /// </summary>
        /// <param name="provider">
        ///     The business provider to which the business model is bound.
        /// </param>
        internal LocalDirectDebitModel(LocalProvider provider) : base(provider)
        {
        }

        /// <summary>
        ///     Initialises a new <see cref="LocalDirectDebitModel" /> instance.
        /// </summary>
        /// <param name="provider">
        ///     The business provider to which the business model is bound.
        /// </param>
        /// <param name="record">
        ///     The data record which is encapsulated by the business model.
        /// </param>
        internal LocalDirectDebitModel(LocalProvider provider, DirectdebitRecord record) : base(provider, record)
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
            if (_memberPeriod != null)
            {
                _memberPeriod.Save();
                this.ModifiedData.RecId = _memberPeriod.Id == null && this.ModifiedData.RecId != null ? "" : _memberPeriod.Id;
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
        ///     Gets or sets the value of the "DD_TABLE_NUM" field.
        /// </summary>
        System.Nullable<System.Double> IDirectDebitModel.TableNum
        {
            get { return this.TableNum; }
            set { this.TableNum = (System.Nullable<System.Double>)value; }
        }

        /// <summary>
        ///     Gets the The value of the "DD_REC_ID" field.
        /// </summary>
        Consensus.Membership.IMemberPeriodModel IDirectDebitModel.MemberPeriod
        {
            get { return this.MemberPeriod; }
        }

        /// <summary>
        ///     Gets or sets the unique code for the value of the "DD_REC_ID" field.
        /// </summary>
        System.String IDirectDebitModel.MemberPeriodId
        {
            get { return this.MemberPeriodId; }
            set { this.MemberPeriodId = (System.String)value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "DD_TYPE" field.
        /// </summary>
        System.Nullable<System.Int32> IDirectDebitModel.Type
        {
            get { return this.Type; }
            set { this.Type = (System.Nullable<System.Int32>)value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "DD_OIN" field.
        /// </summary>
        System.String IDirectDebitModel.ServiceUserNumber
        {
            get { return this.ServiceUserNumber; }
            set { this.ServiceUserNumber = (System.String)value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "DD_REC_DATE" field.
        /// </summary>
        System.Nullable<System.DateTime> IDirectDebitModel.RecDate
        {
            get { return this.RecDate; }
            set { this.RecDate = (System.Nullable<System.DateTime>)value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "DD_REC_METHOD" field.
        /// </summary>
        System.Nullable<System.Int32> IDirectDebitModel.RecMethod
        {
            get { return this.RecMethod; }
            set { this.RecMethod = (System.Nullable<System.Int32>)value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "DD_EFFECTIVE_DATE" field.
        /// </summary>
        System.Nullable<System.DateTime> IDirectDebitModel.EffectiveDate
        {
            get { return this.EffectiveDate; }
            set { this.EffectiveDate = (System.Nullable<System.DateTime>)value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "DD_END_DATE" field.
        /// </summary>
        System.Nullable<System.DateTime> IDirectDebitModel.EndDate
        {
            get { return this.EndDate; }
            set { this.EndDate = (System.Nullable<System.DateTime>)value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "DD_STATUS" field.
        /// </summary>
        System.Nullable<System.Int32> IDirectDebitModel.Status
        {
            get { return this.Status; }
            set { this.Status = (System.Nullable<System.Int32>)value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "DD_FREQUENCY" field.
        /// </summary>
        System.Nullable<System.Int32> IDirectDebitModel.Frequency
        {
            get { return this.Frequency; }
            set { this.Frequency = (System.Nullable<System.Int32>)value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "DD_DAY_OF_MONTH" field.
        /// </summary>
        System.Nullable<System.Int32> IDirectDebitModel.DayOfMonth
        {
            get { return this.DayOfMonth; }
            set { this.DayOfMonth = (System.Nullable<System.Int32>)value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "DD_VARIABLE" field.
        /// </summary>
        System.Nullable<System.Int32> IDirectDebitModel.Variable
        {
            get { return this.Variable; }
            set { this.Variable = (System.Nullable<System.Int32>)value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "DD_MAX_VALUE" field.
        /// </summary>
        System.Nullable<System.Decimal> IDirectDebitModel.MaxValue
        {
            get { return this.MaxValue; }
            set { this.MaxValue = (System.Nullable<System.Decimal>)value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "DD_BANK_NAME" field.
        /// </summary>
        System.String IDirectDebitModel.BankName
        {
            get { return this.BankName; }
            set { this.BankName = (System.String)value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "DD_BANK_ADD_1" field.
        /// </summary>
        System.String IDirectDebitModel.BankAdd1
        {
            get { return this.BankAdd1; }
            set { this.BankAdd1 = (System.String)value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "DD_BANK_ADD_2" field.
        /// </summary>
        System.String IDirectDebitModel.BankAdd2
        {
            get { return this.BankAdd2; }
            set { this.BankAdd2 = (System.String)value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "DD_BANK_ADD_3" field.
        /// </summary>
        System.String IDirectDebitModel.BankAdd3
        {
            get { return this.BankAdd3; }
            set { this.BankAdd3 = (System.String)value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "DD_BANK_ADD_4" field.
        /// </summary>
        System.String IDirectDebitModel.BankAdd4
        {
            get { return this.BankAdd4; }
            set { this.BankAdd4 = (System.String)value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "DD_BANK_POSTCODE" field.
        /// </summary>
        System.String IDirectDebitModel.BankPostcode
        {
            get { return this.BankPostcode; }
            set { this.BankPostcode = (System.String)value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "DD_BANK_ACC_NAME" field.
        /// </summary>
        System.String IDirectDebitModel.BankAccName
        {
            get { return this.BankAccName; }
            set { this.BankAccName = (System.String)value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "DD_BANK_ACC_CODE" field.
        /// </summary>
        System.String IDirectDebitModel.BankAccCode
        {
            get { return this.BankAccCode; }
            set { this.BankAccCode = (System.String)value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "DD_SORT_CODE" field.
        /// </summary>
        System.String IDirectDebitModel.SortCode
        {
            get { return this.SortCode; }
            set { this.SortCode = (System.String)value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "DD_TOTAL" field.
        /// </summary>
        System.Nullable<System.Decimal> IDirectDebitModel.Total
        {
            get { return this.Total; }
            set { this.Total = (System.Nullable<System.Decimal>)value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "DD_NO_OF_INSTALLMENTS" field.
        /// </summary>
        System.Nullable<System.Int32> IDirectDebitModel.NoOfInstallments
        {
            get { return this.NoOfInstallments; }
            set { this.NoOfInstallments = (System.Nullable<System.Int32>)value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "DD_DUE_DATE" field.
        /// </summary>
        System.Nullable<System.DateTime> IDirectDebitModel.DueDate
        {
            get { return this.DueDate; }
            set { this.DueDate = (System.Nullable<System.DateTime>)value; }
        }

        #endregion
    }
}
