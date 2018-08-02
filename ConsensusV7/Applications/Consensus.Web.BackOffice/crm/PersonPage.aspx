<%@ Page Title="" Language="C#" MasterPageFile="~/assets/templates/StandardDetail.master" AutoEventWireup="true" CodeBehind="PersonPage.aspx.cs" Inherits="Consensus.Web.BackOffice.crm.PersonPage" %>
<%@ Register TagPrefix="con" TagName="PersonDetail" Src="~/crm/controls/PersonDetail.ascx" %>
<%@ Register TagPrefix="con" TagName="DataProtection" Src="~/crm/controls/DataProtection.ascx" %>
<%@ Register TagPrefix="con" TagName="RoleList" Src="~/crm/controls/RoleList.ascx" %>
<%@ Register TagPrefix="con" TagName="RoleDetail" Src="~/crm/controls/RoleDetail.ascx" %>
<%@ Register TagPrefix="con" TagName="AssociateList" Src="~/crm/controls/AssociateList.ascx" %>
<%@ Register TagPrefix="con" TagName="AddressDetail" Src="~/crm/controls/AddressDetail.ascx" %>
<%@ Register TagPrefix="con" TagName="ProfileList" Src="~/crm/controls/ProfileList.ascx" %>
<%@ Register TagPrefix="con" TagName="OppList" Src="~/crm/controls/OpportunityList.ascx" %>
<%@ Register TagPrefix="con" TagName="GrantApplicationList" Src="~/crm/controls/OpportunityList.ascx" %>
<%@ Register TagPrefix="con" TagName="LegacyList" Src="~/crm/controls/OpportunityList.ascx" %>
<%@ Register TagPrefix="con" TagName="MajorDonorList" Src="~/crm/controls/OpportunityList.ascx" %>
<%@ Register TagPrefix="con" TagName="PledgeList" Src="~/crm/controls/OpportunityList.ascx" %>
<%@ Register TagPrefix="con" TagName="MembershipList" Src="~/crm/controls/MembershipList.ascx" %>
<%@ Register TagPrefix="con" TagName="DiaryList" Src="~/crm/controls/ActivityList.ascx" %>
<%@ Register TagPrefix="con" TagName="EmailList" Src="~/crm/controls/ActivityList.ascx" %>
<%@ Register TagPrefix="con" TagName="CommunicationList" Src="~/crm/controls/CommunicationList.ascx" %>
<%@ Register TagPrefix="con" TagName="GiftAidList" Src="~/crm/controls/GiftAidList.ascx" %>
<%@ Register TagPrefix="con" TagName="DonationList" Src="~/learning/controls/DonationList.ascx" %>
<%@ Register TagPrefix="con" TagName="MailingListList" Src="~/crm/controls/MailingListList.ascx" %>
<%@ Register TagPrefix="con" TagName="ComplaintList" Src="~/activities/controls/ComplaintList.ascx" %>
<%@ Register TagPrefix="con" TagName="InfoRequestList" Src="~/activities/controls/InfoRequestList.ascx" %>
<%@ Register TagPrefix="con" TagName="PageFooter" Src="~/common/controls/PageFooter.ascx" %>

<asp:Content ContentPlaceHolderID="TopContent" runat="server">
    <con:TabControl runat="server" ID="TopTabControl">
        <Pages>
            <con:TabPage runat="server" Title="Overview">
                <con:PersonDetail runat="server" ID="PersonDetail" />
            </con:TabPage>
            <con:TabPage runat="server" Title="Role information">
                <con:RoleDetail runat="server" ID="RoleDetail" />
            </con:TabPage>
            <con:TabPage runat="server" Title="Home address">
                <con:AddressDetail runat="server" ID="HomeAddress" DataBoundObject="HomeRole.Address" DataBoundId="HomeRole.AddressId" />
            </con:TabPage>
            <con:TabPage runat="server" Title="Data protection">
                <con:DataProtection runat="server" ID="DataProtection" />
            </con:TabPage>
            <con:TabPage runat="server" Title="Contact details">
                <div class="row">
                    <div class="col-md-12">
                        <con:GroupBox runat="server" Title="Contact details">
                            <con:CommunicationList runat="server" ID="CommunicationList" DataBoundValue="RoleCommunication" />
                        </con:GroupBox>
                    </div>
                </div>
            </con:TabPage>
        </Pages>
    </con:TabControl>
</asp:Content>

<asp:Content ContentPlaceHolderID="BottomContent" runat="server">
    <con:TabControl runat="server" Mode="Simple" ID="BottomTabControl">
        <Pages>
            <con:TabList runat="server" Title="Other roles" EnableCreation="true">
                <con:RoleList runat="server" ID="RoleList" />
            </con:TabList>
            <con:TabList runat="server" Title="Relationships" EnableCreation="true">
                <con:AssociateList runat="server" ID="AssociatesList" />
            </con:TabList>
            <con:TabList runat="server" Title="Related to" EnableCreation="true">
                <con:AssociateList runat="server" ID="AssociatesWith" />
            </con:TabList>
            <con:TabList runat="server" Title="Gift Aid declarations" EnableCreation="true">
                <con:GiftAidList runat="server" ID="GiftAidList" />
            </con:TabList>
            <con:TabList runat="server" Title="Donations" EnableCreation="true">
                <con:DonationList runat="server" ID="DonationList" />
            </con:TabList>
            <con:TabList runat="server" Title="Opportunities" EnableCreation="true">
                <con:OppList runat="server" ID="OppList" />
            </con:TabList>
            <con:TabList runat="server" Title="Grant applications" EnableCreation="true">
                <con:GrantApplicationList runat="server" ID="GrantApplicationList" />
            </con:TabList>
            <con:TabList runat="server" Title="Legacies" EnableCreation="true">
                <con:LegacyList runat="server" ID="LegacyList" />
            </con:TabList>
            <con:TabList runat="server" Title="Major Donors" EnableCreation="true">
                <con:MajorDonorList runat="server" ID="MajorDonorList" />
            </con:TabList>
            <con:TabList runat="server" Title="Pledges" EnableCreation="true">
                <con:PledgeList runat="server" ID="PledgeList" />
            </con:TabList>
            <con:TabList runat="server" Title="Diary activities" EnableCreation="true" EnableDeletion="false">
                <con:DiaryList runat="server" id="DiaryList" />
            </con:TabList>
            <con:TabList runat="server" Title="Communications" EnableCreation="true">
                <con:EmailList runat="server" ID="EmailList" />
            </con:TabList>
            <con:TabList runat="server" Title="Profiles">
                <con:ProfileList runat="server" ID="ProfileList" />
            </con:TabList>
            <con:TabList runat="server" Title="Memberships">
                <con:MembershipList runat="server" ID="MembershipList" />
            </con:TabList>
            <con:TabList runat="server" Title="Mailing lists">
                <con:MailingListList runat="server" ID="MailingListList" />
            </con:TabList>
            <con:TabList runat="server" Title="Complaints">
                <con:ComplaintList runat="server" ID="ComplaintList" />
            </con:TabList>
            <con:TabList runat="server" Title="Information requests">
                <con:InfoRequestList runat="server" ID="InfoRequestList" />
            </con:TabList>
        </Pages>
    </con:TabControl>
    <script type="text/javascript">

        // When the role is saved, we need to redirect back to this page but using the person ID rather than the role ID.
        function OnSave(state, result, callback) {
            var hasId = typeof (state.source.Id) != 'undefined' && state.source.Id != null && state.source.Id.length != 0 && state.source.Id.toString() != '0';
            state.toggleSave(null);
            state.object = jQuery.extend(true, {}, result);
            state.updateScreen();
            state.toggleScreen(false);
            if (window.top.consensus == window.consensus && !hasId)
                window.location = window.location.toString() + (window.location.toString().indexOf('?') == -1 ? '?' : '&') + 'id=' + result.PersonId;
            else
                window.location.reload();
        }

        consensus.data.onsave = OnSave;

    </script>
</asp:Content>

<asp:Content ContentPlaceHolderID="Footer" runat="server">
    <con:PageFooter runat="server" ShowAttachmentBookingFields="true" />
</asp:Content>