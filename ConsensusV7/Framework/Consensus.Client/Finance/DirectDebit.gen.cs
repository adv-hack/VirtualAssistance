using System;
using System.Collections.Generic;
using System.Linq;
using Consensus.Membership;
using Consensus.Common;

namespace Consensus.Finance
{
    /// <remarks>
    ///     THIS CODE HAS BEEN AUTOMATICALLY GENERATED USING THE CONSENSUS DEVELOPER TOOLS.
    ///     DO NOT EDIT THIS CODE AS ANY CUSTOM MODIFICATIONS WILL BE LOST UPON REGENERATION.
    /// </remarks>
    public partial class DirectDebit : Proxy<IDirectDebitModel, String>
    {
        #region fields

        /// <summary>
        ///     The client-consumable proxy instance for the <see cref="MemberPeriod" /> member.
        /// </summary>
        private Consensus.Membership.MemberPeriod _memberPeriod;

        #endregion

        #region properties

        /// <summary>
        ///     Gets or sets the value of the "DD_TABLE_NUM" field.
        /// </summary>
        public System.Nullable<System.Double> TableNum
        {
            get { return this.Model.TableNum; }
            set { this.Model.TableNum = value; }
        }

        /// <summary>
        ///     Gets the The value of the "DD_REC_ID" field.
        /// </summary>
        public Consensus.Membership.MemberPeriod MemberPeriod
        {
            get
            {
                if (_memberPeriod == null && this.Model.MemberPeriod != null)
                    _memberPeriod = new Consensus.Membership.MemberPeriod(this.Model.MemberPeriod);
                if (_memberPeriod == null)
                    _memberPeriod = Consensus.Membership.MemberPeriod.Create();
                return _memberPeriod;
            }
        }

        /// <summary>
        ///     Gets or sets the unique code for the value of the "DD_REC_ID" field.
        /// </summary>
        public System.String MemberPeriodId
        {
            get { return this.Model.MemberPeriodId; }
            set { this.Model.MemberPeriodId = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "DD_TYPE" field.
        /// </summary>
        public System.Nullable<System.Int32> Type
        {
            get { return this.Model.Type; }
            set { this.Model.Type = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "DD_OIN" field.
        /// </summary>
        public System.String ServiceUserNumber
        {
            get { return this.Model.ServiceUserNumber; }
            set { this.Model.ServiceUserNumber = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "DD_REC_DATE" field.
        /// </summary>
        public System.Nullable<System.DateTime> RecDate
        {
            get { return this.Model.RecDate; }
            set { this.Model.RecDate = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "DD_REC_METHOD" field.
        /// </summary>
        public System.Nullable<System.Int32> RecMethod
        {
            get { return this.Model.RecMethod; }
            set { this.Model.RecMethod = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "DD_EFFECTIVE_DATE" field.
        /// </summary>
        public System.Nullable<System.DateTime> EffectiveDate
        {
            get { return this.Model.EffectiveDate; }
            set { this.Model.EffectiveDate = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "DD_END_DATE" field.
        /// </summary>
        public System.Nullable<System.DateTime> EndDate
        {
            get { return this.Model.EndDate; }
            set { this.Model.EndDate = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "DD_STATUS" field.
        /// </summary>
        public System.Nullable<System.Int32> Status
        {
            get { return this.Model.Status; }
            set { this.Model.Status = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "DD_FREQUENCY" field.
        /// </summary>
        public System.Nullable<System.Int32> Frequency
        {
            get { return this.Model.Frequency; }
            set { this.Model.Frequency = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "DD_DAY_OF_MONTH" field.
        /// </summary>
        public System.Nullable<System.Int32> DayOfMonth
        {
            get { return this.Model.DayOfMonth; }
            set { this.Model.DayOfMonth = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "DD_VARIABLE" field.
        /// </summary>
        public System.Nullable<System.Int32> Variable
        {
            get { return this.Model.Variable; }
            set { this.Model.Variable = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "DD_MAX_VALUE" field.
        /// </summary>
        public System.Nullable<System.Decimal> MaxValue
        {
            get { return this.Model.MaxValue; }
            set { this.Model.MaxValue = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "DD_BANK_NAME" field.
        /// </summary>
        public System.String BankName
        {
            get { return this.Model.BankName; }
            set { this.Model.BankName = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "DD_BANK_ADD_1" field.
        /// </summary>
        public System.String BankAdd1
        {
            get { return this.Model.BankAdd1; }
            set { this.Model.BankAdd1 = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "DD_BANK_ADD_2" field.
        /// </summary>
        public System.String BankAdd2
        {
            get { return this.Model.BankAdd2; }
            set { this.Model.BankAdd2 = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "DD_BANK_ADD_3" field.
        /// </summary>
        public System.String BankAdd3
        {
            get { return this.Model.BankAdd3; }
            set { this.Model.BankAdd3 = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "DD_BANK_ADD_4" field.
        /// </summary>
        public System.String BankAdd4
        {
            get { return this.Model.BankAdd4; }
            set { this.Model.BankAdd4 = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "DD_BANK_POSTCODE" field.
        /// </summary>
        public System.String BankPostcode
        {
            get { return this.Model.BankPostcode; }
            set { this.Model.BankPostcode = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "DD_BANK_ACC_NAME" field.
        /// </summary>
        public System.String BankAccName
        {
            get { return this.Model.BankAccName; }
            set { this.Model.BankAccName = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "DD_BANK_ACC_CODE" field.
        /// </summary>
        public System.String BankAccCode
        {
            get { return this.Model.BankAccCode; }
            set { this.Model.BankAccCode = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "DD_SORT_CODE" field.
        /// </summary>
        public System.String SortCode
        {
            get { return this.Model.SortCode; }
            set { this.Model.SortCode = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "DD_TOTAL" field.
        /// </summary>
        public System.Nullable<System.Decimal> Total
        {
            get { return this.Model.Total; }
            set { this.Model.Total = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "DD_NO_OF_INSTALLMENTS" field.
        /// </summary>
        public System.Nullable<System.Int32> NoOfInstallments
        {
            get { return this.Model.NoOfInstallments; }
            set { this.Model.NoOfInstallments = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "DD_DUE_DATE" field.
        /// </summary>
        public System.Nullable<System.DateTime> DueDate
        {
            get { return this.Model.DueDate; }
            set { this.Model.DueDate = value; }
        }

        #endregion

        #region constructors

        /// <summary>
        ///     Initialises a new instance of the client-consumable class.
        /// </summary>
        internal DirectDebit(IDirectDebitModel model) : base(model)
        {
        }

        #endregion

        #region methods

        /// <summary>
        /// Validates account number and sort code. If valid returns bank details
        /// </summary>
        /// <param name="accountNumber">Account number</param>
        /// <param name="sortCode">Sort code</param>
        /// <returns>Returns bank details if account number and sort code is valid else returns error message</returns>
        public static AfdResponse AfdBankFinderAccountNumberValidation(System.String accountNumber, System.String sortCode)
        {
            ConsensusSite site = ConsensusDomain.Configuration[ConsensusDomain.Configuration.DefaultSite];
            return DirectDebit.AfdBankFinderAccountNumberValidation(site,accountNumber,sortCode);
        }

        /// <summary>
        /// Validates account number and sort code. If valid returns bank details
        /// </summary>
        /// <param name="accountNumber">Account number</param>
        /// <param name="sortCode">Sort code</param>
        /// <returns>Returns bank details if account number and sort code is valid else returns error message</returns>
        public static AfdResponse AfdBankFinderAccountNumberValidation(ConsensusSite site, System.String accountNumber, System.String sortCode)
        {
            IBusinessProvider provider = site.GetService<IBusinessProvider>();
            return provider.Finance.DirectDebit.AfdBankFinderAccountNumberValidation(accountNumber,sortCode);
        }

        /// <summary>
        ///     Creates a new <see cref="!:DirectDebitModel" /> instance.
        /// </summary>
        /// <returns>
        ///     A newly instantiated <see cref="!:DirectDebitModel" /> instance.
        /// </returns>
        public static Consensus.Finance.DirectDebit Create()
        {
            ConsensusSite site = ConsensusDomain.Configuration[ConsensusDomain.Configuration.DefaultSite];
            return DirectDebit.Create(site);
        }

        /// <summary>
        ///     Creates a new <see cref="!:DirectDebitModel" /> instance.
        /// </summary>
        /// <returns>
        ///     A newly instantiated <see cref="!:DirectDebitModel" /> instance.
        /// </returns>
        public static Consensus.Finance.DirectDebit Create(ConsensusSite site)
        {
            IBusinessProvider provider = site.GetService<IBusinessProvider>();
            Consensus.Finance.IDirectDebitModel model = provider.Finance.DirectDebit.Create();
            return model == null ? null : new Consensus.Finance.DirectDebit(model);
        }

        /// <summary>
        ///     Retrieves all instances of the <see cref="!:DirectDebitModel" /> class.
        /// </summary>
        /// <returns>
        ///     An enumerable collection of <see cref="!:DirectDebitModel" /> instances.
        /// </returns>
        public static IEnumerable<Consensus.Finance.DirectDebit> FetchAll()
        {
            ConsensusSite site = ConsensusDomain.Configuration[ConsensusDomain.Configuration.DefaultSite];
            return DirectDebit.FetchAll(site);
        }

        /// <summary>
        ///     Retrieves all instances of the <see cref="!:DirectDebitModel" /> class.
        /// </summary>
        /// <returns>
        ///     An enumerable collection of <see cref="!:DirectDebitModel" /> instances.
        /// </returns>
        public static IEnumerable<Consensus.Finance.DirectDebit> FetchAll(ConsensusSite site)
        {
            IBusinessProvider provider = site.GetService<IBusinessProvider>();
            IEnumerable<Consensus.Finance.IDirectDebitModel> collection = provider.Finance.DirectDebit.FetchAll();
            return collection.Select(model => new Consensus.Finance.DirectDebit(model));
        }

        /// <summary>
        ///     Retrieves a specific <see cref="!:DirectDebitModel" /> instance.
        /// </summary>
        /// <param name="id">
        ///     The unique value which distinctly identifies the <see cref="!:DirectDebitModel" /> instance to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:DirectDebitModel" /> instance that matches the specified <paramref name="id" />; or null, if no matching instance can be found.
        /// </returns>
        public static Consensus.Finance.DirectDebit FetchById(System.String id)
        {
            ConsensusSite site = ConsensusDomain.Configuration[ConsensusDomain.Configuration.DefaultSite];
            return DirectDebit.FetchById(site,id);
        }

        /// <summary>
        ///     Retrieves a specific <see cref="!:DirectDebitModel" /> instance.
        /// </summary>
        /// <param name="id">
        ///     The unique value which distinctly identifies the <see cref="!:DirectDebitModel" /> instance to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:DirectDebitModel" /> instance that matches the specified <paramref name="id" />; or null, if no matching instance can be found.
        /// </returns>
        public static Consensus.Finance.DirectDebit FetchById(ConsensusSite site, System.String id)
        {
            IBusinessProvider provider = site.GetService<IBusinessProvider>();
            Consensus.Finance.IDirectDebitModel model = provider.Finance.DirectDebit.FetchById(id);
            return model == null ? null : new Consensus.Finance.DirectDebit(model);
        }

        public static System.String GetTableName()
        {
            ConsensusSite site = ConsensusDomain.Configuration[ConsensusDomain.Configuration.DefaultSite];
            return DirectDebit.GetTableName(site);
        }

        public static System.String GetTableName(ConsensusSite site)
        {
            IBusinessProvider provider = site.GetService<IBusinessProvider>();
            return provider.Finance.DirectDebit.GetTableName();
        }

        /// <summary>
        ///     Retrieves a collection of <see cref="!:DirectDebitModel" /> instances.
        /// </summary>
        /// <param name="memberPeriodId">
        ///     The value which identifies the <see cref="!:DirectDebitModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:DirectDebitModel" /> instances that match the specified <paramref name="memberPeriodId" />.
        /// </returns>
        public static IEnumerable<Consensus.Finance.DirectDebit> FetchAllByMemberPeriodId(System.String memberPeriodId)
        {
            ConsensusSite site = ConsensusDomain.Configuration[ConsensusDomain.Configuration.DefaultSite];
            return DirectDebit.FetchAllByMemberPeriodId(site,memberPeriodId);
        }

        /// <summary>
        ///     Retrieves a collection of <see cref="!:DirectDebitModel" /> instances.
        /// </summary>
        /// <param name="memberPeriodId">
        ///     The value which identifies the <see cref="!:DirectDebitModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:DirectDebitModel" /> instances that match the specified <paramref name="memberPeriodId" />.
        /// </returns>
        public static IEnumerable<Consensus.Finance.DirectDebit> FetchAllByMemberPeriodId(ConsensusSite site, System.String memberPeriodId)
        {
            IBusinessProvider provider = site.GetService<IBusinessProvider>();
            IEnumerable<Consensus.Finance.IDirectDebitModel> collection = provider.Finance.DirectDebit.FetchAllByMemberPeriodId(memberPeriodId);
            return collection.Select(model => new Consensus.Finance.DirectDebit(model));
        }

        #endregion
    }
}
