using Consensus.Document;
using Consensus.Searches;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Text;

namespace Consensus.Web.BackOffice.document.controls
{
    public partial class SendPack : BaseControl<PrintRequest, string>
    {
        #region fields
        private PackType? _type;
        #endregion

        #region enumerations
        public enum PackType
        {
            Booking,
            Membership,
            Event,
            Invoice,
            Batch,
            InformationRequest,
            Complaint,
            Person,
            Activity,
            GiftAidDeclaration,
            //CreditNote,
            //Donation
        }

        #endregion

        #region properties

        public override string DataTypeName
        {
            get
            {
                return "PrintRequest";
            }
        }
        public string PackParentURL
        {
            get
            {
                string parentUrl = Page.Request.QueryString["parenturl"];
                return string.IsNullOrEmpty(parentUrl) ? "" : parentUrl.ToLower();
            }
        }
        public string PackParentId
        {
            get
            {
                return Page.Request.QueryString["parentid"];
            }
        }
        //public string PackParentSubType
        //{
        //    get
        //    {
        //        string parentType = Page.Request.QueryString["parenttype"];
        //        return string.IsNullOrEmpty(parentType) ? "" : parentType.ToLower();
        //    }
        //}
        public PackType Type
        {
            get
            {
                if (!_type.HasValue)
                    _type = GetPackType();
                return _type.Value;
            }
        }

        public override Func<string, PrintRequest> DataLoader
        {
            get { return PrintRequest.FetchById; }
        }
        #endregion

        #region methods

        private PackType GetPackType()
        {
            PackType retType;

            switch (PackParentURL)
            {
                case "activities/activity":
                    retType = PackType.Activity;
                    break;
                case "other/batch":
                    retType = PackType.Batch;
                    break;
                case "learning/booking":
                    retType = PackType.Booking;
                    // retType = PackType.Donation; ...don't think we need to distinguish donations from bookings..
                    break;
                case "activities/complaint":
                    retType = PackType.Complaint;
                    break;
                case "learning/event":
                    retType = PackType.Event;
                    break;
                case "contact/giftaid":
                    retType = PackType.GiftAidDeclaration;
                    break;
                case "activities/helpdesk":
                    retType = PackType.InformationRequest;
                    break;
                case "finance/invoice":
                    retType = PackType.Invoice;
                    //retType = PackType.CreditNote; ...don't think we need to distinguish invoices from credits..
                    break;
                case "membership/memberperiod":
                    retType = PackType.Membership;
                    break;
                case "contact/person":
                    retType = PackType.Person;
                    break;
                default:
                    throw new ApplicationException("Object '" + PackParentURL + "' does not currently support the sending of packs");
            }

            return retType;
        }

        public string sendToJSON(bool toMe)
        {
            Contact.Role roleTo = null;
            if (toMe)
            {
                roleTo = this.CurrentSession.User.Person.PrincipalRole;
            }
            else
            {
                switch (Type)
                {
                    case PackType.Activity:
                        Activities.Activity activity = Activities.Activity.FetchById(PackParentId);
                        if (activity != null && activity.EndUser != null)
                            roleTo = activity.EndUser.PersonRole;
                        break;
                    //case PackType.Batch:
                    //    Consensus.Other.Batch batch = Consensus.Other.Batch.FetchById(PackParentId);
                    //    roleTo = batch.?? // there isn't a role associated with a batch..
                    //    break;
                    case PackType.Booking:
                        Learning.Booking booking = Learning.Booking.FetchById(PackParentId);
                        if (booking != null)
                            roleTo = booking.BookerRole;
                        break;
                    case PackType.Complaint:
                        Activities.Complaint complaint = Activities.Complaint.FetchById(PackParentId);
                        if (complaint != null)
                            roleTo = complaint.FromProleId;
                        break;
                    case PackType.Event:
                        Learning.Event evnt = Learning.Event.FetchById(PackParentId);
                        if (evnt != null)
                            roleTo = evnt.CommissionedRole;
                        break;
                    case PackType.GiftAidDeclaration:
                        Contact.Giftaid giftaid = Contact.Giftaid.FetchById(PackParentId.ConvertTo<int>());
                        if (giftaid != null)
                            roleTo = giftaid.PnId.PrincipalRole;
                        break;
                    case PackType.InformationRequest:
                        Activities.Helpdesk helpdesc = Activities.Helpdesk.FetchById(PackParentId);
                        if (helpdesc != null)
                            roleTo = helpdesc.ProleId;
                        break;
                    case PackType.Invoice:
                        Finance.Invoice invoice = Finance.Invoice.FetchById(PackParentId);
                        if (invoice != null)
                            roleTo = invoice.ProleId;
                        break;
                    case PackType.Membership:
                        Membership.Membership membership = Membership.Membership.FetchById(PackParentId);
                        if (membership != null)
                        {
                            for (int i = 0; i < membership.MemberLocations.Count; i++)
                            {
                                if (membership.MemberLocations[i].RenewLoc == 1)
                                {
                                    roleTo = membership.MemberLocations[i].Role;
                                    break;
                                }
                            }
                        }
                        break;
                    case PackType.Person:
                        Contact.Person person = Contact.Person.FetchById(PackParentId);
                        if (person != null)
                            roleTo = person.PrincipalRole;
                        break;
                }
            }

            if (roleTo == null)
            {
                return "null";
            }
            else
            {
                return string.Format(@"
{{
    id: {0},
    name: {1}
}}", 
                HttpUtility.JavaScriptStringEncode(roleTo.Id, true),
                HttpUtility.JavaScriptStringEncode(roleTo.PersonName, true));
            }
        }

        private void setPrintReqType()
        {
            int prType = 99;

            switch (Type)
            {
                case PackType.Invoice: prType = 20; break;
                case PackType.Event: prType = 40; break;
                case PackType.Person: prType = 29; break;
                case PackType.InformationRequest: prType = 55; break;
                case PackType.Activity: prType = 56; break;
            }
            this.PrintRequestType.FieldValue = prType.ToString();

            /* From 6.5 code...
            select case ucase(request.QueryString("SCP_RECORD_ID"))
              case "INV_ID" : getPrintReqType = 20
              case "COURSE_ID": getPrintReqType = 40
              case "PN_ID": getPrintReqType = 29
              case "ARTI_ID": getPrintReqType = 28    
              case "HD_ID": getPrintReqType = 55
              case "ACT_ID": getPrintReqType = 56
              case "ISCERTXREF_ID": getPrintReqType = 27
              case "PROLEATT_ID": getPrintReqType = 58
              case "ATTLVLXREF_ID": getPrintReqType = 59
              case "SH_ID": getPrintReqType = 62
              case else: getPrintReqType = 99
            end select
             */
        }

        #endregion


        #region Page Lifecycle

        protected override void OnInit(EventArgs e)
        {
            base.OnInit(e);

            ISearchesRunnable packQuery = Query.Create()
                .Select("PACK_ID")
                .Select("PACK_NAME")
                .Select("PACK_PQ_ID")
                .From(QuerySources.Packs)
                .Where("PARENT_URL", QueryConditionTypes.Equal, PackParentURL)
                .OrderBy("PACK_NAME");

            List<ListItem> items = new List<ListItem>();
            IList<Dictionary<string, object>> results = packQuery.Run();

            foreach (Dictionary<string, object> item in results)
            {
                ListItem entry = new ListItem(item["PACK_NAME"].ToString(), item["PACK_ID"].ToString());
                items.Add(entry);
            }

            this.PackName.DataSource = items;

            foreach (ListItem item in this.PackName.Items)
            {
                Dictionary<string, object> qitem = results.FirstOrDefault(p => p["PACK_ID"].ToString() == item.Value);
                if (qitem != null)
                {
                    if (qitem["PACK_PQ_ID"] != null && qitem["PACK_PQ_ID"].ToString() != "")
                    {
                        item.Attributes.Add("queueid", qitem["PACK_PQ_ID"].ToString());
                    }
                }
            }

            SentFrom.FieldValue = this.CurrentSession.User.Person.PrincipalRole.Id;
            setPrintReqType();

            List<Document.OutputQueue> queues = Consensus.Document.OutputQueue.FetchAll().ToList();
            this.OutputQueue.DataSource = queues;

            foreach(ListItem item in this.OutputQueue.Items)
            {
                Document.OutputQueue qitem = queues.FirstOrDefault(q => q.Id == item.Value);
                if (qitem != null)
                {
                    if (qitem.SendType.HasValue)
                        item.Attributes.Add("sendtype", qitem.SendType.ToString());

                    if (qitem.SystemDefault.HasValue && qitem.SystemDefault.Value == 1)
                        item.Attributes.Add("defaultfortype", "1");
                }
            }

            //Consensus.Common.Code.FetchAllByType("DPMS").ToList(); // no longer using this - the types are hard coded...
            // Value is the same as Text because this is what we are saving to the Print_Req table.
            List<ListItem> allQueueTypes = new List<ListItem>()
            {
                new ListItem() { Text = "16-Email", Value = "16-Email" },
                new ListItem() { Text = "01-Post", Value = "01-Post" },
                new ListItem() { Text = "30-SMS", Value = "30-SMS" }
            };

            List<ListItem> showQueueTypes = new List<ListItem>();
            foreach (ListItem queueType in allQueueTypes)
            {
                int queueSendType;
                if (int.TryParse(queueType.Text.Substring(0, 2), out queueSendType))
                {
                    if (queues.Exists(q => q.SendType == queueSendType))
                    {
                        showQueueTypes.Add(queueType);
                    }
                }
            }
            this.SendMethod.DataSource = showQueueTypes;            
        }
        

        #endregion
    }
}