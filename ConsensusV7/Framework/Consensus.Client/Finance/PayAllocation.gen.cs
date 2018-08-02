using System;
using System.Collections.Generic;
using System.Linq;

namespace Consensus.Finance
{
    /// <remarks>
    ///     THIS CODE HAS BEEN AUTOMATICALLY GENERATED USING THE CONSENSUS DEVELOPER TOOLS.
    ///     DO NOT EDIT THIS CODE AS ANY CUSTOM MODIFICATIONS WILL BE LOST UPON REGENERATION.
    /// </remarks>
    public partial class PayAllocation : Proxy<IPayAllocationModel, String>
    {
        #region fields

        /// <summary>
        ///     The client-consumable proxy instance for the <see cref="InvId" /> member.
        /// </summary>
        private Consensus.Finance.Invoice _invId;

        /// <summary>
        ///     The client-consumable proxy instance for the <see cref="PayId" /> member.
        /// </summary>
        private Consensus.Finance.Payment _payId;

        /// <summary>
        ///     The client-consumable proxy instance for the <see cref="CreditId" /> member.
        /// </summary>
        private Consensus.Finance.Invoice _creditId;

        #endregion

        #region properties

        public System.String Paid
        {
            set { this.Model.Paid = value; }
        }

        public System.Boolean Reverse
        {
            set { this.Model.Reverse = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "PA_DATE" field.
        /// </summary>
        public System.Nullable<System.DateTime> Date
        {
            get { return this.Model.Date; }
            set { this.Model.Date = value; }
        }

        /// <summary>
        ///     Gets the The value of the "PA_INV_ID" field.
        /// </summary>
        public Consensus.Finance.Invoice InvId
        {
            get
            {
                if (_invId == null && this.Model.InvId != null)
                    _invId = new Consensus.Finance.Invoice(this.Model.InvId);
                if (_invId == null)
                    _invId = Consensus.Finance.Invoice.Create();
                return _invId;
            }
        }

        /// <summary>
        ///     Gets or sets the unique code for the value of the "PA_INV_ID" field.
        /// </summary>
        public System.String InvIdId
        {
            get { return this.Model.InvIdId; }
            set { this.Model.InvIdId = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "PA_INV_REF" field.
        /// </summary>
        public System.String InvRef
        {
            get { return this.Model.InvRef; }
            set { this.Model.InvRef = value; }
        }

        /// <summary>
        ///     Gets the The value of the "PA_PAY_ID" field.
        /// </summary>
        public Consensus.Finance.Payment PayId
        {
            get
            {
                if (_payId == null && this.Model.PayId != null)
                    _payId = new Consensus.Finance.Payment(this.Model.PayId);
                if (_payId == null)
                    _payId = Consensus.Finance.Payment.Create();
                return _payId;
            }
        }

        /// <summary>
        ///     Gets or sets the unique code for the value of the "PA_PAY_ID" field.
        /// </summary>
        public System.String PayIdId
        {
            get { return this.Model.PayIdId; }
            set { this.Model.PayIdId = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "PA_HIDDEN" field.
        /// </summary>
        public System.Nullable<System.Byte> Hidden
        {
            get { return this.Model.Hidden; }
            set { this.Model.Hidden = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "PA_CURR_TYPE" field.
        /// </summary>
        public System.String CurrType
        {
            get { return this.Model.CurrType; }
            set { this.Model.CurrType = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "PA_VALUE" field.
        /// </summary>
        public System.Decimal Value
        {
            get { return this.Model.Value; }
            set { this.Model.Value = value; }
        }

        /// <summary>
        ///     Gets the The value of the "PA_CREDIT_ID" field.
        /// </summary>
        public Consensus.Finance.Invoice CreditId
        {
            get
            {
                if (_creditId == null && this.Model.CreditId != null)
                    _creditId = new Consensus.Finance.Invoice(this.Model.CreditId);
                if (_creditId == null)
                    _creditId = Consensus.Finance.Invoice.Create();
                return _creditId;
            }
        }

        /// <summary>
        ///     Gets or sets the unique code for the value of the "PA_CREDIT_ID" field.
        /// </summary>
        public System.String CreditIdId
        {
            get { return this.Model.CreditIdId; }
            set { this.Model.CreditIdId = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "PA_CREDIT_REF" field.
        /// </summary>
        public System.String CreditRef
        {
            get { return this.Model.CreditRef; }
            set { this.Model.CreditRef = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "PA_BOOK_ID" field.
        /// </summary>
        public System.String BookId
        {
            get { return this.Model.BookId; }
            set { this.Model.BookId = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "PA_MEP_ID" field.
        /// </summary>
        public System.String MepId
        {
            get { return this.Model.MepId; }
            set { this.Model.MepId = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "PA_BAT_ID" field.
        /// </summary>
        public System.String BatId
        {
            get { return this.Model.BatId; }
            set { this.Model.BatId = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "PA_DEL_ID" field.
        /// </summary>
        public System.String DelId
        {
            get { return this.Model.DelId; }
            set { this.Model.DelId = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "PA_REFUND_ID" field.
        /// </summary>
        public System.String RefundId
        {
            get { return this.Model.RefundId; }
            set { this.Model.RefundId = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "PA_DEALLOCATION" field.
        /// </summary>
        public System.Nullable<System.Byte> Deallocation
        {
            get { return this.Model.Deallocation; }
            set { this.Model.Deallocation = value; }
        }

        /// <summary>
        ///     Gets or sets the value of the "PA_REVERSES_PA_ID" field.
        /// </summary>
        public System.String ReversesPaId
        {
            get { return this.Model.ReversesPaId; }
            set { this.Model.ReversesPaId = value; }
        }

        #endregion

        #region constructors

        /// <summary>
        ///     Initialises a new instance of the client-consumable class.
        /// </summary>
        internal PayAllocation(IPayAllocationModel model) : base(model)
        {
        }

        #endregion

        #region methods

        public void Save()
        {
            this.Model.Save();
        }

        /// <summary>
        ///     Creates a new <see cref="!:PayAllocationModel" /> instance.
        /// </summary>
        /// <returns>
        ///     A newly instantiated <see cref="!:PayAllocationModel" /> instance.
        /// </returns>
        public static Consensus.Finance.PayAllocation Create()
        {
            ConsensusSite site = ConsensusDomain.Configuration[ConsensusDomain.Configuration.DefaultSite];
            return PayAllocation.Create(site);
        }

        /// <summary>
        ///     Creates a new <see cref="!:PayAllocationModel" /> instance.
        /// </summary>
        /// <returns>
        ///     A newly instantiated <see cref="!:PayAllocationModel" /> instance.
        /// </returns>
        public static Consensus.Finance.PayAllocation Create(ConsensusSite site)
        {
            IBusinessProvider provider = site.GetService<IBusinessProvider>();
            Consensus.Finance.IPayAllocationModel model = provider.Finance.PayAllocation.Create();
            return model == null ? null : new Consensus.Finance.PayAllocation(model);
        }

        /// <summary>
        ///     Retrieves all instances of the <see cref="!:PayAllocationModel" /> class.
        /// </summary>
        /// <returns>
        ///     An enumerable collection of <see cref="!:PayAllocationModel" /> instances.
        /// </returns>
        public static IEnumerable<Consensus.Finance.PayAllocation> FetchAll()
        {
            ConsensusSite site = ConsensusDomain.Configuration[ConsensusDomain.Configuration.DefaultSite];
            return PayAllocation.FetchAll(site);
        }

        /// <summary>
        ///     Retrieves all instances of the <see cref="!:PayAllocationModel" /> class.
        /// </summary>
        /// <returns>
        ///     An enumerable collection of <see cref="!:PayAllocationModel" /> instances.
        /// </returns>
        public static IEnumerable<Consensus.Finance.PayAllocation> FetchAll(ConsensusSite site)
        {
            IBusinessProvider provider = site.GetService<IBusinessProvider>();
            IEnumerable<Consensus.Finance.IPayAllocationModel> collection = provider.Finance.PayAllocation.FetchAll();
            return collection.Select(model => new Consensus.Finance.PayAllocation(model));
        }

        /// <summary>
        ///     Retrieves a specific <see cref="!:PayAllocationModel" /> instance.
        /// </summary>
        /// <param name="id">
        ///     The unique value which distinctly identifies the <see cref="!:PayAllocationModel" /> instance to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:PayAllocationModel" /> instance that matches the specified <paramref name="id" />; or null, if no matching instance can be found.
        /// </returns>
        public static Consensus.Finance.PayAllocation FetchById(System.String id)
        {
            ConsensusSite site = ConsensusDomain.Configuration[ConsensusDomain.Configuration.DefaultSite];
            return PayAllocation.FetchById(site,id);
        }

        /// <summary>
        ///     Retrieves a specific <see cref="!:PayAllocationModel" /> instance.
        /// </summary>
        /// <param name="id">
        ///     The unique value which distinctly identifies the <see cref="!:PayAllocationModel" /> instance to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:PayAllocationModel" /> instance that matches the specified <paramref name="id" />; or null, if no matching instance can be found.
        /// </returns>
        public static Consensus.Finance.PayAllocation FetchById(ConsensusSite site, System.String id)
        {
            IBusinessProvider provider = site.GetService<IBusinessProvider>();
            Consensus.Finance.IPayAllocationModel model = provider.Finance.PayAllocation.FetchById(id);
            return model == null ? null : new Consensus.Finance.PayAllocation(model);
        }

        public static System.String GetTableName()
        {
            ConsensusSite site = ConsensusDomain.Configuration[ConsensusDomain.Configuration.DefaultSite];
            return PayAllocation.GetTableName(site);
        }

        public static System.String GetTableName(ConsensusSite site)
        {
            IBusinessProvider provider = site.GetService<IBusinessProvider>();
            return provider.Finance.PayAllocation.GetTableName();
        }

        /// <summary>
        ///     Retrieves a collection of <see cref="!:PayAllocationModel" /> instances.
        /// </summary>
        /// <param name="invIdId">
        ///     The value which identifies the <see cref="!:PayAllocationModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:PayAllocationModel" /> instances that match the specified <paramref name="invIdId" />.
        /// </returns>
        public static IEnumerable<Consensus.Finance.PayAllocation> FetchAllByInvIdId(System.String invIdId)
        {
            ConsensusSite site = ConsensusDomain.Configuration[ConsensusDomain.Configuration.DefaultSite];
            return PayAllocation.FetchAllByInvIdId(site,invIdId);
        }

        /// <summary>
        ///     Retrieves a collection of <see cref="!:PayAllocationModel" /> instances.
        /// </summary>
        /// <param name="invIdId">
        ///     The value which identifies the <see cref="!:PayAllocationModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:PayAllocationModel" /> instances that match the specified <paramref name="invIdId" />.
        /// </returns>
        public static IEnumerable<Consensus.Finance.PayAllocation> FetchAllByInvIdId(ConsensusSite site, System.String invIdId)
        {
            IBusinessProvider provider = site.GetService<IBusinessProvider>();
            IEnumerable<Consensus.Finance.IPayAllocationModel> collection = provider.Finance.PayAllocation.FetchAllByInvIdId(invIdId);
            return collection.Select(model => new Consensus.Finance.PayAllocation(model));
        }

        /// <summary>
        ///     Retrieves a collection of <see cref="!:PayAllocationModel" /> instances.
        /// </summary>
        /// <param name="payIdId">
        ///     The value which identifies the <see cref="!:PayAllocationModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:PayAllocationModel" /> instances that match the specified <paramref name="payIdId" />.
        /// </returns>
        public static IEnumerable<Consensus.Finance.PayAllocation> FetchAllByPayIdId(System.String payIdId)
        {
            ConsensusSite site = ConsensusDomain.Configuration[ConsensusDomain.Configuration.DefaultSite];
            return PayAllocation.FetchAllByPayIdId(site,payIdId);
        }

        /// <summary>
        ///     Retrieves a collection of <see cref="!:PayAllocationModel" /> instances.
        /// </summary>
        /// <param name="payIdId">
        ///     The value which identifies the <see cref="!:PayAllocationModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:PayAllocationModel" /> instances that match the specified <paramref name="payIdId" />.
        /// </returns>
        public static IEnumerable<Consensus.Finance.PayAllocation> FetchAllByPayIdId(ConsensusSite site, System.String payIdId)
        {
            IBusinessProvider provider = site.GetService<IBusinessProvider>();
            IEnumerable<Consensus.Finance.IPayAllocationModel> collection = provider.Finance.PayAllocation.FetchAllByPayIdId(payIdId);
            return collection.Select(model => new Consensus.Finance.PayAllocation(model));
        }

        /// <summary>
        ///     Retrieves a collection of <see cref="!:PayAllocationModel" /> instances.
        /// </summary>
        /// <param name="creditIdId">
        ///     The value which identifies the <see cref="!:PayAllocationModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:PayAllocationModel" /> instances that match the specified <paramref name="creditIdId" />.
        /// </returns>
        public static IEnumerable<Consensus.Finance.PayAllocation> FetchAllByCreditIdId(System.String creditIdId)
        {
            ConsensusSite site = ConsensusDomain.Configuration[ConsensusDomain.Configuration.DefaultSite];
            return PayAllocation.FetchAllByCreditIdId(site,creditIdId);
        }

        /// <summary>
        ///     Retrieves a collection of <see cref="!:PayAllocationModel" /> instances.
        /// </summary>
        /// <param name="creditIdId">
        ///     The value which identifies the <see cref="!:PayAllocationModel" /> instances to be returned.
        /// </param>
        /// <returns>
        ///     The <see cref="!:PayAllocationModel" /> instances that match the specified <paramref name="creditIdId" />.
        /// </returns>
        public static IEnumerable<Consensus.Finance.PayAllocation> FetchAllByCreditIdId(ConsensusSite site, System.String creditIdId)
        {
            IBusinessProvider provider = site.GetService<IBusinessProvider>();
            IEnumerable<Consensus.Finance.IPayAllocationModel> collection = provider.Finance.PayAllocation.FetchAllByCreditIdId(creditIdId);
            return collection.Select(model => new Consensus.Finance.PayAllocation(model));
        }

        #endregion
    }
}
