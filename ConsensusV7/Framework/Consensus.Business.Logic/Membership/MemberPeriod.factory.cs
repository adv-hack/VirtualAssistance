using System;
using System.Collections.Generic;
using System.Linq;
using Consensus.Finance;

namespace Consensus.Membership
{
    /// <summary>
    ///     Supports the instantiation of the <see cref="MemberPeriodModel" /> object.
    /// </summary>
    public partial class LocalMemberPeriodFactory
    {
        /// <summary>
        ///     Performs rollback membership on a single <see cref='MemberPeriodModel' /> instance.
        ///     Functionality replicated from the SQL performed in V6.5
        /// </summary>
        /// <param name="memberPeriodId">
        ///     The value which identifies the <see cref='MemberPeriodModel' /> instance to be modified.
        /// </param>
        /// <param name="status">
        ///     The status value which should be set.
        /// </param>
        /// <returns>
        ///     The <see cref='MemberPeriodModel' /> instance that match the specified <paramref name='memberPeriodId' />.
        /// </returns>
        public LocalMemberPeriodModel RollbackMembership(String memberPeriodId, String status)
        {

            //Create credit notes for any associated invoices
            foreach (InvheaderRecord invoice in (this.Provider.DataProvider.Finance.Invoice.FetchAllByMepId(memberPeriodId).Where(i => i.Type != "Credit" && i.NetTotal>0 )))
            {
                if(this.Provider.DataProvider.Finance.InvoiceLine.FetchAllByInvId(invoice.Id).Where(line => line.Credited ==1).Count() == 0)
                {
                    this.Provider.DataProvider.Finance.Invoice.RollbackInvoice(invoice);
                }
            }

            //Update Rollback Date and status for memberperiod record
            LocalMemberPeriodModel memberPeriod = this.Provider.Membership.MemberPeriod.FetchById(memberPeriodId);
            memberPeriod.RollbackDate = DateTime.UtcNow;
            memberPeriod.StatusCode = status;
            memberPeriod.Save();

            //Reset status on old member period record if required
            LocalMemberPeriodModel oldMemberPeriod = this.Provider.Membership.MemberPeriod.FetchById(memberPeriod.OldMepId);
            if (oldMemberPeriod != null && oldMemberPeriod.StatusCode !=null)
            {
                string oldStatus = oldMemberPeriod.StatusCode;
                if (oldStatus.Substring(0, 2) == "90" && (status.Substring(0, 2) == "13" || status.Substring(0, 2) == "14" || status.Substring(0, 2) == "15" || status.Substring(0, 2) == "16"))
                {
                    oldMemberPeriod.StatusCode = "25-Current Renewing";
                    oldMemberPeriod.Save();
                }
            }

            //Reset invoiced status on member location records
            LocalMemberLocationModel[] memberLocations = memberPeriod.MemberLocations.Where(loc => loc.Invoiced == 1).ToArray();
            if (memberLocations.Count() > 0)
                memberLocations.Execute(loc => loc.Invoiced = 0).Execute(loc => loc.Save());

            return memberPeriod;
        }

        /// <summary>
        ///     Cancels existing DDs on <see cref='MemberPeriodModel' /> instance.
        /// </summary>
        /// <param name="memberPeriodId">
        ///     The value which identifies the <see cref='MemberPeriodModel' /> instance to be modified.
        /// </param>        /// 
        /// <param name="directDebitId">
        ///     The new Direct Debit Id which identifies the instance which should not be modified.
        /// </param>
        /// <returns>
        ///     The <see cref='MemberPeriodModel' /> instance that match the specified <paramref name='memberPeriodId' />.
        /// </returns>
        public LocalMemberPeriodModel CancelExistingDirectDebits(String memberPeriodId, String directDebitId)
        {
            //Set DD status to cancelled on existing records
            LocalMemberPeriodModel memberPeriod = this.Provider.Membership.MemberPeriod.FetchById(memberPeriodId);
            LocalDirectDebitModel[] directDebits = memberPeriod.DirectDebits.Where(dd => dd.Status < 8 && dd.Id != directDebitId).ToArray();
            if (directDebits.Count() > 0)
                directDebits.Execute(dd => dd.Status = 7).Execute(loc => loc.Save());

            return memberPeriod;
        }

        
    }
}
