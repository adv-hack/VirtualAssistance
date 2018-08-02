<%@ Page Title="" Language="C#" MasterPageFile="~/assets/templates/StandardDetail.master" AutoEventWireup="true" CodeBehind="MemberPage.aspx.cs" Inherits="Consensus.Web.BackOffice.membership.MemberPage" %>
<%@ Register TagPrefix="con" TagName="MemberDetails" Src="~/membership/controls/memberdetails.ascx" %>
<%@ Register TagPrefix="con" TagName="BillingDetails" Src="~/membership/controls/memberbillingdetails.ascx" %>
<%@ Register TagPrefix="con" TagName="PersonDetails" Src="~/membership/controls/memberpersondetail.ascx" %>
<%@ Register TagPrefix="con" TagName="MemberLocationsList" Src="~/membership/controls/memberlocationslist.ascx" %>
<%@ Register TagPrefix="con" TagName="MemberPeriodsList" Src="~/membership/controls/memberperiodslist.ascx" %>
<%@ Register TagPrefix="con" TagName="MemberInvoiceList" Src="~/membership/controls/MembershipInvoiceList.ascx" %>
<%@ Register TagPrefix="con" TagName="MembershipCreditNoteList" Src="~/membership/controls/MembershipCreditNoteList.ascx" %>
<%@ Register TagPrefix="con" TagName="MembershipDirectDebitList" Src="~/membership/controls/MembershipDirectDebitList.ascx" %>
<%@ Register TagPrefix="con" TagName="MemberGradeList" Src="~/membership/controls/MemberGradeList.ascx" %>
<%@ Register TagPrefix="con" TagName="MemberDiscountList" Src="~/membership/controls/MemberDiscountList.ascx" %>
<%@ Register TagPrefix="con" TagName="MemberSpecialistGroupList" Src="~/membership/controls/MemberSpecialistGroupList.ascx" %>
<%@ Register TagPrefix="con" TagName="MemberBranchList" Src="~/membership/controls/MemberBranchList.ascx" %>
<%@ Register TagPrefix="con" TagName="ConsultantSchemeList" Src="~/membership/controls/ConsultantSchemeList.ascx" %>
<%@ Register TagPrefix="con" TagName="PageFooter" Src="~/common/controls/PageFooter.ascx" %>

<asp:Content ID="Content1" ContentPlaceHolderID="TopContent" runat="server">
     <con:TabControl runat="server">
        <Pages>
            <con:TabPage runat="server" Title="Overview">
                <div class="row">
                    <con:PersonDetails runat="server" ID="PersonDetail" />
                    <con:MemberDetails runat="server" ID="MemberDetails" />
                </div>
            </con:TabPage>
            <con:TabPage runat="server" Title="Billing Details">
                <con:BillingDetails runat="server" ID="BillingDetails" />
            </con:TabPage>
        </Pages>
    </con:TabControl>
    
</asp:Content>
<asp:Content ContentPlaceHolderID="BottomContent" runat="server">
    <con:TabControl runat="server" Mode="Simple" id="BottomTabControl">
        <Pages>
            <con:TabList runat="server" Title="Locations" >
                <con:MemberLocationsList runat="server" id="MemberLocationsList" />
            </con:TabList>            

            <con:TabList runat="server" Title="Discounts">
                <con:MemberDiscountList runat="server" id="MemberDiscountList" />
            </con:TabList>
            <con:TabList runat="server" Title="Grades">
                <con:MemberGradeList runat="server" id="MemberGradeList" />
            </con:TabList>
            <con:TabList runat="server" Title="Specialist Groups">
                <con:MemberSpecialistGroupList runat="server" id="MemberSpecialistGroupList" />
            </con:TabList>
            <con:TabList runat="server" Title="Consultant schemes">
                <con:ConsultantSchemeList runat="server" id="ConsultantSchemeList" />
            </con:TabList>
            <con:TabList runat="server" Title="Branches">
                <con:MemberBranchList runat="server" id="MemberBranchList" />
            </con:TabList>
             <con:TabList runat="server" Title="Direct Debits" >
                <con:MembershipDirectDebitList runat="server" id="MembershipDirectDebitList" />
            </con:TabList>

            <con:TabList runat="server" Title="Invoices" >
                <con:MemberInvoiceList runat="server" id="MemberInvoiceList" />
            </con:TabList>

            <con:TabList runat="server" Title="Credit Notes" >
                <con:MembershipCreditNoteList runat="server" id="MembershipCreditNoteList" />
            </con:TabList>
            <con:TabList runat="server" Title="Periods" >
                <con:MemberPeriodsList runat="server" id="MemberPeriodsList" />
            </con:TabList>





        </Pages>
    </con:TabControl>

    <script type="text/javascript">

        function createInvoice(memberPeriodId) {
            var userLoginId = $('#Content_loggedUser').val();
            consensus.network.send({
                method: 'post',
                data: {
                    memberPeriodId: memberPeriodId,
                    userLoginId: userLoginId,
                    serialization: {
                        Include: {
                            "Membership.MemberLocation": ["InvlnIdId"]
                        }
                    }
                },
                url: 'Membership/MemberLocation/CheckMemLocLinesToInvoice',
                success: function (result) {
                    if (result && result.length > 0) //if count > 0 - Invoice is created against the same MemberPeriod
                    {
                        window.location.href = consensus.resolveUrl('~/finance/invoice?id=' + result["0"].InvlnIdId);
                        //consensus.network.send({
                        //    method: 'post',
                        //    url: 'Finance/Invoice/FetchAllByMepId?MepId=' + memberPeriodId,
                        //    success: function (result) {
                        //        console.log(result);

                        //    }
                        //});
                        
                    }
                        else { 
                        // If LOC_Count = 0 then no invoice is to be created.

                        swal({ title: 'Message', text: 'The Membership is already fully invoiced.', type: 'info', showCancelButton: false, confirmButtonText: 'Ok', confirmButtonClass: 'btn btn-default', buttonsStyling: false }).then(function (success) {
                            //    //window.location.href = consensus.resolveUrl('~/crm/person?id=' + result.Id);
                        });
                    }
                }
            });
        }
    </script>

</asp:Content>

<asp:Content ContentPlaceHolderID="Footer" runat="server">
    <con:PageFooter runat="server" />
</asp:Content>