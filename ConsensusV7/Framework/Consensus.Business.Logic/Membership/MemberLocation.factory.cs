using System;
using System.Collections.Generic;
using System.Linq;

namespace Consensus.Membership
{
    /// <summary>
    ///     Supports the instantiation of the <see cref="MemberLocationModel" /> object.
    /// </summary>
    public partial class LocalMemberLocationFactory
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="memberPeriodId"></param>
        /// <returns></returns>
        public IEnumerable<LocalMemberLocationModel> CheckMemLocLinesToInvoice(string memberPeriodId, string userLoginId)
        {
            //bool createInvoice = false;

            IEnumerable<LocalMemberLocationModel> memberLocations = this.Provider.Membership.MemberLocation.FetchAllByMemberPeriodId(memberPeriodId).Where(mel => (mel.Invoiced == null || mel.Invoiced == (byte)0) && mel.Type == 0).ToList();

            if (memberLocations.Count() > 0)
            {// to be invoiced if locations > 0
             //foreach (LocalMemberLocationModel memberLocation in memberLocations)
                this.Provider.DataProvider.Finance.Invoice.CreateInvoice(memberPeriodId, userLoginId, null, 0);

                IEnumerable<LocalMemberLocationModel> invoicedMember = this.Provider.Membership.MemberLocation.FetchAllByMemberPeriodId(memberPeriodId).Where(loc => loc.Invoiced == 1).OrderByDescending(loc=>loc.InvlnIdId).ToList();
                // get invoiced record from InvHeader.
                //IEnumerable<LocalInvoiceModel> resp = this.Provider.Finance.Invoice.FetchAllByMemberPeriodId(memberPeriodId);

                //if (resp.Count() > 0) // Invoice created against membership
                //{
                //foreach (LocalInvoiceModel invoice in resp)
                //{
                //    if (invoice.Status == 8)
                //        return invoice.Id;
                //}
                return invoicedMember;
            }
            else
                return memberLocations;
        }

        /// <summary>
        /// Checks if Consultant scheme product already exist in database
        /// </summary>
        /// <param name="productId">Id of the Product</param>        
        /// <param name="memberLocationId">Id of the Member Location</param>
        /// <param name="memberPeriodId">Id of the Member Period</param>
        /// <returns>Whether Consultant scheme product already exist in database</returns>
        public bool CheckIfProductExist(string productId, string memberLocationId, string memberPeriodId)
        {
            var memberLocationList = this.FetchAll().ToList();
            var consultantSchemeProductList = memberLocationList.Where(x => x.ProductId == productId && x.MemberPeriodId == memberPeriodId).ToList();

            bool result = false;

            if (consultantSchemeProductList.Count > 0)
            {
                if (string.IsNullOrEmpty(memberLocationId))
                {
                    result = true;
                }
                else
                {
                    if (!consultantSchemeProductList.Any(x => x.Id == memberLocationId))
                    {
                        result = true;
                    }
                }
            }
            return result;

        }
    }
}
