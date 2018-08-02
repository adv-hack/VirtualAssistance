<%@ Page Language="C#" MasterPageFile="~/assets/templates/StandardDetail.master" AutoEventWireup="true" CodeBehind="CoursePage.aspx.cs" Inherits="Consensus.Web.BackOffice.learning.CoursePage" %>

<%@ Register TagPrefix="con" TagName="CourseDetails" Src="~/learning/controls/coursedetails.ascx" %>
<%@ Register TagPrefix="con" TagName="MainSessionDetails" Src="~/learning/controls/mainsessiondetails.ascx" %>
<%@ Register TagPrefix="con" TagName="FinanceDetails" Src="~/learning/controls/productfinancedetails.ascx" %>
<%@ Register TagPrefix="con" TagName="OnlineDetails" Src="~/learning/controls/productonlinedetails.ascx" %>
<%@ Register TagPrefix="con" TagName="RelationshipsList" Src="~/learning/controls/relatedproductlist.ascx" %>
<%@ Register TagPrefix="con" TagName="PricesList" Src="~/learning/controls/ProductPriceList.ascx" %>
<%@ Register TagPrefix="con" TagName="CourseTemplateList" Src="~/learning/controls/TemplateList.ascx" %>
<%@ Register TagPrefix="con" TagName="ProductTemplateList" Src="~/learning/controls/TemplateList.ascx" %>
<%@ Register TagPrefix="con" TagName="PacksList" Src="~/document/controls/ProductPackList.ascx" %>
<%@ Register TagPrefix="con" TagName="ProfileList" Src="~/crm/controls/ProfileList.ascx" %>
<%@ Register TagPrefix="con" TagName="SelectionGroupList" Src="~/learning/controls/SelectionGroupList.ascx" %>
<%@ Register TagPrefix="con" TagName="PageFooter" Src="~/common/controls/PageFooter.ascx" %>

<asp:Content ContentPlaceHolderID="TopContent" runat="server">
    <con:TabControl runat="server">
        <Pages>
            <con:TabPage runat="server" Title="Overview">
                <con:CourseDetails runat="server" id="CourseDetails" />
            </con:TabPage>
            <con:TabPage runat="server" Title="Main Session">
                <con:MainSessionDetails runat="server" id="MainSessionDetails" />
            </con:TabPage>
            <con:TabPage runat="server" Title="Finance">
                <con:FinanceDetails runat="server" id="FinanceDetails" />
            </con:TabPage>
            <con:TabPage runat="server" Title="Online">
                <con:OnlineDetails runat="server" id="OnlineDetails" />
            </con:TabPage>
        </Pages>
    </con:TabControl>
</asp:Content>

<asp:Content ContentPlaceHolderID="BottomContent" runat="server">
    <con:TabControl runat="server" Mode="Simple" id="BottomTabControl">
        <Pages>
            <con:TabList runat="server" Title="Prices" EnableCreation="true">
                <con:PricesList runat="server" id="PricesList" />
            </con:TabList>
            <con:TabList runat="server" Title="Sessions" EnableCreation="true">
                <con:CourseTemplateList runat="server" id="CourseTemplateList" />
            </con:TabList>
            <con:TabList runat="server" Title="Products" EnableCreation="true">
                <con:ProductTemplateList runat="server" id="ProductTemplateList" />
            </con:TabList>
            <con:TabList runat="server" Title="Related Products" EnableCreation="true">
                <con:RelationshipsList runat="server" id="RelationshipsList" />
            </con:TabList>
            <con:TabList runat="server" Title="Packs" EnableCreation="true">
                <con:PacksList runat="server" id="PacksList" />
            </con:TabList>            
            <con:TabList runat="server" Title="Selection Groups" EnableCreation="true">
                <con:SelectionGroupList runat="server" id="SelectionGroupList" />
            </con:TabList>
            <con:TabList runat="server" Title="Profiles">
                <con:ProfileList runat="server" id="ProfileList" />
            </con:TabList>
        </Pages>
    </con:TabControl>
</asp:Content>
<asp:Content ContentPlaceHolderID="Footer" runat="server">
    <con:PageFooter runat="server" ShowAttachmentBookingFields="true" />
</asp:Content>