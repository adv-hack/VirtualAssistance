<%@ Page Title="" Language="C#" MasterPageFile="~/assets/templates/StandardDetail.master" AutoEventWireup="true" CodeBehind="OrganisationPage.aspx.cs" Inherits="Consensus.Web.BackOffice.crm.OrganisationPage" %>
<%@ Register TagPrefix="con" TagName="OrganisationDetail" Src="~/crm/controls/OrganisationDetail.ascx" %>
<%@ Register TagPrefix="con" TagName="ProfileList" Src="~/crm/controls/ProfileList.ascx" %>
<%@ Register TagPrefix="con" TagName="AssociateList" Src="~/crm/controls/AssociateList.ascx" %>
<%@ Register TagPrefix="con" TagName="PeopleList" Src="~/crm/controls/PersonList.ascx" %>
<%@ Register TagPrefix="con" TagName="AddressList" Src="~/crm/controls/AddressList.ascx" %>
<%--<%@ Register TagPrefix="con" TagName="DeptList" Src="~/crm/controls/DepartmentList.ascx" %>--%>
<%@ Register TagPrefix="con" TagName="MembershipList" Src="~/crm/controls/MembershipList.ascx" %>
<%@ Register TagPrefix="con" TagName="DiaryList" Src="~/crm/controls/ActivityList.ascx" %>
<%@ Register TagPrefix="con" TagName="EmailList" Src="~/crm/controls/ActivityList.ascx" %>
<%@ Register TagPrefix="con" TagName="OpportunityList" Src="~/crm/controls/OrganisationOpportunityList.ascx" %>
<%@ Register TagPrefix="con" TagName="GrantApplicationList" Src="~/crm/controls/OrganisationOpportunityList.ascx" %>
<%@ Register TagPrefix="con" TagName="LegacyList" Src="~/crm/controls/OrganisationOpportunityList.ascx" %>
<%@ Register TagPrefix="con" TagName="MajorDonorList" Src="~/crm/controls/OrganisationOpportunityList.ascx" %>
<%@ Register TagPrefix="con" TagName="PledgeList" Src="~/crm/controls/OrganisationOpportunityList.ascx" %>
<%@ Register TagPrefix="con" TagName="PageFooter" Src="~/common/controls/PageFooter.ascx" %>

<asp:Content ContentPlaceHolderID="TopContent" runat="server">
    <con:TabControl runat="server">
        <Pages>
            <con:TabPage runat="server" Title="Overview">
                <con:OrganisationDetail runat="server" id="OrganisationDetail" />
            </con:TabPage>
        </Pages>
    </con:TabControl>
</asp:Content>

<asp:Content ContentPlaceHolderID="BottomContent" runat="server">
    <con:TabControl runat="server" Mode="Simple" Id="BottomTabControl">
        <Pages>
            <con:TabList runat="server" EnableCreation="true" Title="Other Addresses" >
                <con:AddressList runat="server" id="AddressList" OrgID="Id"/>
            </con:TabList>
            <con:TabPage runat="server" Title="People">
                <con:PeopleList runat="server" id="PeopleList" />
            </con:TabPage>
            <con:TabList runat="server" EnableCreation="true" Title="Relationships">
                <con:AssociateList runat="server" id="AssociateList" AssociateType="OrganisationAssociates" />
            </con:TabList>
            <con:TabList runat="server" Title="Diary Activities">
                <con:DiaryList runat="server" id="DiaryList" />
            </con:TabList>
            <con:TabList runat="server" Title="Communications">
                <con:EmailList runat="server" id="EmailList" />
            </con:TabList>
<%--            <con:TabList runat="server" EnableCreation="true"  Title="Departments">
                <con:DeptList runat="server" id="DeptList" />
            </con:TabList>--%>
            <con:TabList runat="server" Title="Profiles">
                <con:ProfileList runat="server" id="ProfileList" />
            </con:TabList>
            <con:TabList runat="server" Title="Memberships">
                <con:MembershipList runat="server" id="MembershipList" />
            </con:TabList>
            <con:TabList runat="server" Title="Opportunities">
                <con:OpportunityList runat="server" ID="OpportunityList" />
            </con:TabList>
            <con:TabList runat="server" Title="Grant applications">
                <con:GrantApplicationList runat="server" ID="GrantApplicationList" />
            </con:TabList>
            <con:TabList runat="server" Title="Legacies">
                <con:LegacyList runat="server" ID="LegacyList" />
            </con:TabList>
            <con:TabList runat="server" Title="Major Donors">
                <con:MajorDonorList runat="server" ID="MajorDonorList" />
            </con:TabList>
            <con:TabList runat="server" Title="Pledges">
                <con:PledgeList runat="server" ID="PledgeList" />
            </con:TabList>
        </Pages>
    </con:TabControl>
</asp:Content>

<asp:Content ContentPlaceHolderID="Footer" runat="server">
    <con:PageFooter runat="server" />
</asp:Content>
