<%@ Page Language="C#" MasterPageFile="~/assets/templates/StandardDetail.master" AutoEventWireup="true" CodeBehind="DonorPage.aspx.cs" Inherits="Consensus.Web.BackOffice.Sales.DonorPage" %>
<%@ Register TagPrefix="con" TagName="OpportunityDonorDetail" Src="~/sales/controls/OpportunityDonorDetail.ascx" %>
<%@ Register TagPrefix="con" TagName="OppPeopleList" Src="~/sales/controls/OpportunityPeopleList.ascx" %>
<%@ Register TagPrefix="con" TagName="OppSalesManList" Src="~/sales/controls/OpportunityPeopleList.ascx" %>
<%@ Register TagPrefix="con" TagName="PageFooter" Src="~/common/controls/PageFooter.ascx" %>
<%@ Register TagPrefix="con" TagName="DiaryList" Src="~/crm/controls/ActivityList.ascx" %>
<%@ Register TagPrefix="con" TagName="EmailList" Src="~/crm/controls/ActivityList.ascx" %>
<%@ Register TagPrefix="con" TagName="DonationList" Src="~/learning/controls/DonationList.ascx" %>

<asp:Content ContentPlaceHolderID="TopContent" runat="server">
    <con:TabControl runat="server">
        <Pages>
            <con:TabPage runat="server" Title="Overview">
                 <con:OpportunityDonorDetail runat="server" ID="OpportunityDonorDetail" />
            </con:TabPage>
        </Pages>
    </con:TabControl>
</asp:Content>

<asp:Content ContentPlaceHolderID="BottomContent" runat="server">
     <con:TabControl runat="server" Mode="Simple" id="BottomTabControl">
       <Pages>
            <con:TabList runat="server" Title="Other Contacts" EnableCreation="true">
                <con:OppPeopleList runat="server" id="OppPeopleList" />
            </con:TabList>        
            <con:TabList runat="server" Title="Bid Team" EnableCreation="true">
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