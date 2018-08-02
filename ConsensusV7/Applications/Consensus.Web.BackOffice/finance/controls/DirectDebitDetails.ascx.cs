using Consensus.Finance;
using Consensus.Contact;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Consensus.Membership;

namespace Consensus.Web.BackOffice.finance.controls
{
    public partial class DirectDebitDetails : BaseControl<DirectDebit, String>
    {
        #region properties

        public override string DataTypeName
        {
            get { return "Direct Debit"; }
        }

        #endregion

        #region methods
        protected override void OnInit(EventArgs e)
        {
            base.OnInit(e);

            this.DayOfMonth.DataSource = PopulateDayList();
            this.Status.DataSource = PopulateStatusList(true);

            //set defaults
            this.RecDate.FieldValue = DateTime.Now;
            this.EffectiveDate.FieldValue = DateTime.Now.AddDays(14);
            this.Type.FieldValue = "0";
            this.DayOfMonth.FieldValue = "1";
            this.CollectionType.FieldValue = "1";
            this.Status.FieldValue = "0";
            this.TableNum.FieldValue = "271";
        }
        protected override void PopulateControl()
        {
            base.PopulateControl();

            decimal balOutstanding = (this.DataSource.Id != null && this.DataSource.Total.HasValue) ? this.DataSource.Total.Value : 0;
            int numInstallments = (this.DataSource.Id != null && this.DataSource.NoOfInstallments.HasValue) ? this.DataSource.NoOfInstallments.Value : 1;

            if (this.DataSource.Id == null)
            {
                if (!string.IsNullOrEmpty(this.Request.QueryString["memberPeriodId"]))
                //new direct debit created from member page
                //relate to the member period id and the memberperiod table (271)
                //and set defaults from the member period
                {
                    //set defaults
                    this.RecDate.FieldValue = DateTime.Now;
                    this.EffectiveDate.FieldValue = DateTime.Now.AddDays(14);
                    this.Type.FieldValue = "0";
                    this.DayOfMonth.FieldValue = "1";
                    this.CollectionType.FieldValue = "1";
                    this.Status.FieldValue = "0";
                    this.TableNum.FieldValue = "271";

                    MemberPeriod membership = MemberPeriod.FetchById(this.Request.QueryString["memberPeriodId"]);
                    balOutstanding = membership.Fee;

                    if (membership != null)
                    {
                        var unpaidInvoiceValue = CalculateOutstandingBalance(membership);
                        if (unpaidInvoiceValue.HasValue)
                        {
                            balOutstanding = unpaidInvoiceValue.Value;
                        }
                    }

                    if (membership.Product.DdNoOfInstallments.HasValue)
                        numInstallments = membership.Product.DdNoOfInstallments.Value;
                    this.MepStartDate.FieldValue = membership.Start.Value.ToString("dd MMM yyyy");
                    this.MepEndDate.FieldValue = this.EndDate.FieldValue = membership.End.Value.ToString("dd MMM yyyy");
                    this.DueDate.FieldValue = CalculateFirstDueDate(DateTime.Now, membership.Start, 1).ToString("dd MMM yyyy");
                    this.MemberPeriodId.FieldValue = (this.Request.QueryString["memberPeriodId"]);
                    this.AccountName.FieldValue = membership.InvoiceRole.PersonName;
                    this.Frequency.FieldValue = membership.Product.DdFrequency.HasValue ? membership.Product.DdFrequency.Value.ToString() : "0";
                    this.Installments.FieldValue = numInstallments.ToString();                    
                    this.DDExist.FieldValue = DirectDebit.FetchAllByMemberPeriodId(membership.Id).Where(dd => dd.Status < 7).Count().ToString();
                   
                }
                //initialise max value
                this.MaximumValue.FieldValue = (balOutstanding / numInstallments).ConvertTo<String>();
                this.TotalVal.FieldValue = balOutstanding.ConvertTo<String>();
            }
            else
            {
                this.Status.DataSource = PopulateStatusList(false);
                this.Status.FieldValue = this.DataSource.Status.ToString();
                //can't update status or rec date in edit mode
                this.Status.IsReadOnly = UserInterface.ConfigurableBoolean.True;
                this.RecDate.IsReadOnly = UserInterface.ConfigurableBoolean.True;

                if (this.DataSource.MemberPeriod != null)
                {
                    var unpaidInvoiceValue = CalculateOutstandingBalance(this.DataSource.MemberPeriod);
                    if (this.DataSource.MemberPeriodId != null && this.DataSource.TableNum == 271 && unpaidInvoiceValue.HasValue)
                    {
                        balOutstanding = unpaidInvoiceValue.Value;
                    }
                }
            }

            this.BalanceOutstanding.FieldValue = balOutstanding.ConvertTo<String>();
            
        }

        private object PopulateDayList()
        {
            List<KeyValuePair<String, String>> days = new List<KeyValuePair<String, String>>();
            for (int i = 1; i <= 28; i++)
            {
                string day = i.ToString();
                days.Add(new KeyValuePair<string, string>(day, day));
            }
            return days;
        }

        private object PopulateStatusList(bool init)
        {
            List<KeyValuePair<String, String>> statusCodes = new List<KeyValuePair<String, String>>();
            if (init)
            {
                statusCodes.Add(new KeyValuePair<string, string>("New Instruction", "0"));
                statusCodes.Add(new KeyValuePair<string, string>("First Collection", "3"));
            }
            else
            {
                statusCodes.Add(new KeyValuePair<string, string>("New Instruction", "0"));
                statusCodes.Add(new KeyValuePair<string, string>("Authorisation Sent to Bank", "1"));
                statusCodes.Add(new KeyValuePair<string, string>("Rejected by Bank", "2"));
                statusCodes.Add(new KeyValuePair<string, string>("First Collection", "3"));
                statusCodes.Add(new KeyValuePair<string, string>("Standard Collection", "4"));
                statusCodes.Add(new KeyValuePair<string, string>("Payment sent to Bank", "5"));
                statusCodes.Add(new KeyValuePair<string, string>("Payment Rejected", "6"));
                statusCodes.Add(new KeyValuePair<string, string>("Cancelled by Member", "7"));
                statusCodes.Add(new KeyValuePair<string, string>("Cancellation sent to Bank", "8"));
                statusCodes.Add(new KeyValuePair<string, string>("Cancellation accepted by Bank", "9"));
                statusCodes.Add(new KeyValuePair<string, string>("Membership Cancelled", "10"));
            }


            return statusCodes;
        }

        private decimal? CalculateOutstandingBalance(MemberPeriod membership)
        { //calculate Outstanding balance

            decimal? invUnpaidVal = null;
            if (membership.InvHeader.Count > 0)
            {
                decimal totalUnpaidValue = 0;
                foreach (Invoice i in membership.InvHeader)
                {
                    totalUnpaidValue += i.UnpaidValue;
                }
                return totalUnpaidValue;
            }
            return invUnpaidVal;
        }

        private DateTime CalculateFirstDueDate(DateTime receivedDate, DateTime? membershipStartDate, int dayOfMonth)
        { //For new payments determine first day can collect based on day of month and days have to wait.
          // Copied from v6.5

            DateTime actualStartDate = new DateTime();
            int addMonth = 0, effectdays = 14;

            if (!membershipStartDate.HasValue)
                membershipStartDate = DateTime.Now.AddDays(effectdays);

            if (dayOfMonth == 0)
                dayOfMonth = 1;

            if (membershipStartDate.Value.Day > dayOfMonth)
                addMonth = 1;

            actualStartDate = new DateTime(membershipStartDate.Value.Year, membershipStartDate.Value.AddMonths(addMonth).Month, dayOfMonth);

            if (receivedDate.AddDays(effectdays) <= actualStartDate)
                return actualStartDate;
            else
            //Keep adding months until after received date i.e. in the future
            {
                while (actualStartDate < receivedDate.AddDays(effectdays))
                {
                    actualStartDate = actualStartDate.AddMonths(1);
                }

            }
            return actualStartDate;
        }
        #endregion


    }
}