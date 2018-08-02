<%@ Page Language="C#" MasterPageFile="~/assets/templates/StandardDetail.master" AutoEventWireup="true" CodeBehind="LegacyPage.aspx.cs" Inherits="Consensus.Web.BackOffice.Sales.LegacyPage" %>
<%@ Register TagPrefix="con" TagName="OpportunityLegacyDetail" Src="~/sales/controls/OpportunityLegacyDetail.ascx" %>
<%@ Register TagPrefix="con" TagName="OppPeopleList" Src="~/sales/controls/OpportunityPeopleList.ascx" %>
<%@ Register TagPrefix="con" TagName="OppSalesManList" Src="~/sales/controls/OpportunityPeopleList.ascx" %>
<%@ Register TagPrefix="con" TagName="EmailList" Src="~/crm/controls/ActivityList.ascx" %>
<%@ Register TagPrefix="con" TagName="PageFooter" Src="~/common/controls/PageFooter.ascx" %>
<%@ Register TagPrefix="con" TagName="DiaryList" Src="~/crm/controls/ActivityList.ascx" %>
<%@ Register TagPrefix="con" TagName="DonationList" Src="~/learning/controls/DonationList.ascx" %>

<asp:Content ContentPlaceHolderID="TopContent" runat="server">
    <con:TabControl runat="server">
        <Pages>
            <con:TabPage runat="server" Title="Overview">
                <con:OpportunityLegacyDetail runat="server" ID="OpportunityLegacyDetail" />
            </con:TabPage>
        </Pages>
    </con:TabControl>
</asp:Content>

<asp:Content ContentPlaceHolderID="BottomContent" runat="server">
    <con:TabControl runat="server" Mode="Simple" ID="BottomTabControl">
        <Pages>
             <con:TabList runat="server" Title="Executors" EnableCreation="true">
                <con:OppPeopleList runat="server" id="OppPeopleList" />
            </con:TabList>
            <con:TabList runat="server" Title="Legacy Management Team" EnableCreation="true">
                <con:OppSalesManList runat="server" id="OppSalesManList" />
            </con:TabList>
              <con:TabList runat="server" Title="Donations" EnableCreation="true">
                <con:DonationList runat="server" id="DonationList"/>
            </con:TabList>
            <con:TabList runat="server" Title="Diary Activities">
                <con:DiaryList runat="server" id="DiaryList" />
            </con:TabList>
            <con:TabList runat="server" Title="Communications">
                <con:EmailList runat="server" id="EmailList" />
            </con:TabList>           
        </Pages>
      </con:TabControl>
</asp:Content>
<asp:Content ContentPlaceHolderID="Footer" runat="server">
    <con:PageFooter runat="server" />
</asp:Content>
