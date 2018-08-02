using Consensus.Finance;
using Consensus.Learning;
using System;
using System.Linq;
using Consensus.Web.Controls;
using Consensus.UserInterface;

namespace Consensus.Web.BackOffice.finance.controls
{
    public partial class NewPayment : BaseControl<Payment, String>
    {
        #region controls

        /// <summary>
        ///     Person control.
        /// </summary>
        /// <remarks>
        ///     The auto-generated field has been moved from designer file to code-behind file to allow this member to be exposed publicly.
        /// </remarks>
        public PopupField Person;

        /// <summary>
        ///     Account control.
        /// </summary>
        /// <remarks>
        ///     The auto-generated field has been moved from designer file to code-behind file to allow this member to be exposed publicly.
        /// </remarks>
        public PopupField Account;

        /// <summary>
        ///     Organisation control.
        /// </summary>
        /// <remarks>
        ///     The auto-generated field has been moved from designer file to code-behind file to allow this member to be exposed publicly.
        /// </remarks>
        public PopupField Organisation;

        /// <summary>
        ///     PaymentType control.
        /// </summary>
        /// <remarks>
        ///     The auto-generated field has been moved from designer file to code-behind file to allow this member to be exposed publicly.
        /// </remarks>
        public CodeField PaymentType;

        /// <summary>
        ///     SellingCompany control.
        /// </summary>
        /// <remarks>
        ///     The auto-generated field has been moved from designer file to code-behind file to allow this member to be exposed publicly.
        /// </remarks>
        public ListField SellingCompany;

        /// <summary>
        /// AddressId control.
        /// </summary>
        /// <remarks>
        ///  The auto-generated field has been moved from designer file to code-behind file to allow this member to be exposed publicly.
        /// </remarks>
        public Consensus.Web.Controls.HiddenField AddressId;

        /// <summary>
        /// PaymentAmount control.
        /// </summary>
        /// <remarks>
        /// The auto-generated field has been moved from designer file to code-behind file to allow this member to be exposed publicly.
        /// </remarks>
        public Consensus.Web.Controls.TextField PaymentAmount;

        /// <summary>
        /// Currency control.
        /// </summary>
        /// <remarks>
        /// The auto-generated field has been moved from designer file to code-behind file to allow this member to be exposed publicly.
        /// </remarks>
        public Consensus.Web.Controls.ListField Currency;

        /// <summary>
        /// Conversion control.
        /// </summary>
        /// <remarks>
        /// The auto-generated field has been moved from designer file to code-behind file to allow this member to be exposed publicly.
        /// </remarks>
        public Consensus.Web.Controls.TextField Conversion;

        /// <summary>
        /// PaymentBC control.
        /// </summary>
        /// <remarks>
        /// The auto-generated field has been moved from designer file to code-behind file to allow this member to be exposed publicly.
        /// </remarks>
        public Consensus.Web.Controls.TextField PaymentBC;

        #endregion

        #region properties

        public override String DataTypeName
        {
            get
            {
                if (this.Request.QueryString["parent"] == "payment")
                {
                    return "Refund";
                }
                else
                {
                    return "Payment";
                }
            }
        }

        #endregion

        #region methods

        protected override void OnInit(EventArgs e)
        {
            base.OnInit(e);
            this.SellingCompany.DataSource = Common.SellingCompany.FetchAll();
            // this.Currency.DataSource = 
            this.Date.FieldValue = DateTime.Today;
            this.SellingCompany.FieldValue = this.CurrentSession.User.SellingCompanyId;
            this.Currency.FieldValue = "GBP";
            this.Conversion.FieldValue = Finance.Currency.FetchByCodeAndSellingCompany(this.Currency.FieldValue, this.SellingCompany.FieldValue).ConversionFactor.ConvertTo<String>();

            switch (this.Request.QueryString["parent"])
            {
                case "invoice":
                    Invoice invoice = Invoice.FetchById(this.Request.QueryString["invid"]);
                    if (invoice != null)
                    {
                        this.PaymentAmount.FieldValue = invoice.UnpaidValue.ConvertTo<String>();
                        this.Person.FieldValue = invoice.ProleIdId;
                        this.Person.FieldText = invoice.Person.FullName;
                        this.Name.FieldValue = invoice.Person.FullName;
                        this.Account.FieldValue = invoice.AccountId;
                        this.Account.FieldText = invoice.Account.ARNumber;
                        this.Organisation.FieldValue = invoice.OrganisationId;
                        this.Organisation.FieldText = invoice.OrganisationName;
                        this.SellingCompany.FieldValue = invoice.SellingCompanyId;
                        this.Currency.FieldValue = invoice.Currency;
                        this.Conversion.FieldValue = Finance.Currency.FetchByCodeAndSellingCompany(invoice.Currency, invoice.SellingCompanyId).ConversionFactor.ConvertTo<String>();
                        this.PaymentBC.FieldValue = (Decimal.Parse(this.PaymentAmount.FieldValue) / Decimal.Parse(this.Conversion.FieldValue)).ConvertTo<String>();
                        this.InvoiceId.FieldValue = invoice.Id;
                        this.AddressId.FieldValue = invoice.AddId;
                        this.BookingId.FieldValue = invoice.Booking;
                        this.MemberPeriodId.FieldValue = invoice.MemberPeriodId;
                    }

                    break;
                case "booking":
                    Booking booking = Booking.FetchById(this.Request.QueryString["bookingId"]);
                    if (booking != null)
                    {
                        this.PaymentAmount.FieldValue = String.Format("{0:.00}", booking.NetTotal + booking.VatTotal);
                        this.Person.FieldValue = booking.InvoiceRoleId;
                        this.Person.FieldText = booking.InvoiceRole.PersonName;
                        this.Name.FieldValue = booking.InvoiceRole.PersonName;
                        this.Account.FieldValue = booking.AccountId;
                        this.Account.FieldText = booking.Account.ARNumber;
                        this.Organisation.FieldValue = booking.InvoiceOrgId;
                        this.Organisation.FieldText = booking.InvoiceOrg.Name;
                        this.SellingCompany.FieldValue = booking.SellingCompanyId;
                        this.Currency.FieldValue = booking.CurrencyType;
                        this.Conversion.FieldValue = Finance.Currency.FetchByCodeAndSellingCompany(booking.CurrencyType, booking.SellingCompanyId).ConversionFactor.ConvertTo<String>();
                        this.PaymentBC.FieldValue = (Decimal.Parse(this.PaymentAmount.FieldValue) / Decimal.Parse(this.Conversion.FieldValue)).ConvertTo<String>();
                        this.AddressId.FieldValue = booking.InvoiceAddressId;
                        this.BookingId.FieldValue = booking.Id;
                    }
                    break;
                case "account":
                    Account account = Finance.Account.FetchById(this.Request.QueryString["accid"]);
                    if (account != null)
                    {
                        this.Account.FieldValue = account.Id;
                        this.Account.FieldText = account.ARNumber;
                        this.Organisation.FieldValue = account.OrganisationId;
                        this.Organisation.FieldText = account.Organisation.Name;
                        this.SellingCompany.FieldValue = account.SellingComanpyId;
                    }
                    break;
                case "payment":
                    var payment = Payment.FetchById(Request.QueryString["payId"]);
                    this.PaymentAmount.LabelText = "Refund Amount";
                    this.MaxRefundAmt.IsHidden = ConfigurableBoolean.False;
                    this.Conversion.IsReadOnly = ConfigurableBoolean.True;
                    this.Currency.IsReadOnly = ConfigurableBoolean.True;

                    if (payment != null)
                    {
                        this.MaxRefundAmt.FieldValue = payment.UnusedVal.ConvertTo<String>();
                        this.DataSource = payment;
                        this.PaymentAmount.FieldValue = payment.UnusedVal.ConvertTo<String>();
                        this.PaymentBC.FieldValue = (Decimal.Parse(this.PaymentAmount.FieldValue) / Decimal.Parse(this.Conversion.FieldValue)).ConvertTo<String>();
                    }
                    break;

            }

            this.Currency.DataSource = Finance.Currency.FetchAllBySellingCompanyId(this.SellingCompany.FieldValue).Where(curr => (!curr.StartDate.HasValue || curr.StartDate.Value <= DateTime.Today) && (!curr.EndDate.HasValue || curr.EndDate.Value >= DateTime.Today)).ToArray();

        }

        protected override void PopulateControl()
        {
            base.PopulateControl();
        }

        protected override void RegisterJavascript()
        {

            this.PaymentType.ClientOnChange += "payment.functions.toggleFields();";
            this.SellingCompany.ClientOnChange += "payment.functions.clearConfiguration(); payment.functions.toggleFields(); payment.functions.populateCurrency();";
            this.Currency.ClientOnChange += "payment.functions.populateConversion()";
            this.Conversion.ClientOnChange += "payment.functions.updateConversion()";
            this.PaymentAmount.ClientOnChange += "payment.functions.populateConversion()";
            this.Account.ClientOnChange += @"
                if (this.getData() && (this.getValue() || '') != '') {
                    if (this.getData().org_id && this.getData().org_id.length != 0) {
                        " + this.Organisation.ClientID + @".setValue(this.getData().org_id, this.getData().org_name);
                    } else {
                        " + this.Organisation.ClientID + @".setValue(null);
                    }
                    if (this.getData().person_id && this.getData().person_id.length != 0) {
                        " + this.Person.ClientID + @".setValue(this.getData().prole_id, this.getData().person_name); 
                    } else {
                        " + this.Person.ClientID + @".setValue(null); 
                    }
                }
            ";
            this.Organisation.ClientOnChange += @"
                if (!" + this.Account.ClientID + ".getData() || !" + this.Account.ClientID + ".getData().org_id || " + this.Account.ClientID + @".getData().org_id.length == 0 || " + this.Account.ClientID + @".getData().org_id != this.getValue()) {
                    " + this.Account.ClientID + @".setValue(null);
                }
            ";
            this.Person.ClientOnChange += @"
               if (this.getData() && (this.getValue() || '') != '') {
                    $('#" + this.Name.ClientID + @"Field').val(this.getText());
                }
            ";
        }

        #endregion
    }
}