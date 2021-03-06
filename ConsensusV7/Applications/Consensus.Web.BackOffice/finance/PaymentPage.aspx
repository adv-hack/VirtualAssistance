﻿<%@ Page Title="" Language="C#" MasterPageFile="~/assets/templates/StandardDetail.master" AutoEventWireup="true" CodeBehind="PaymentPage.aspx.cs" Inherits="Consensus.Web.BackOffice.finance.PaymentPage" %>
<%@ Register TagPrefix="con" TagName="PaymentDetails" Src="~/finance/controls/paymentdetails.ascx" %>
<%@ Register TagPrefix="con" TagName="PaymentAllocation" Src="~/finance/controls/PaymentAllocationList.ascx" %>
<%@ Register TagPrefix="con" TagName="PageFooter" Src="~/common/controls/PageFooter.ascx" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ReadModeToolbar" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="EditModeToolbar" runat="server">
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="TopContent" runat="server">
     <con:TabControl runat="server">
        <Pages>
            <con:TabPage runat="server" Title="Overview">
                <con:PaymentDetails runat="server" id="PaymentDetails" />
            </con:TabPage>
        </Pages>
    </con:TabControl>
</asp:Content>
<asp:Content ID="Content4" ContentPlaceHolderID="BottomContent" runat="server">
    <con:TabControl runat="server" Mode="Simple" id="BottomTabControl">
        <Pages>
             <con:TabList runat="server" EnableCreation="true" Title="Allocations" >
                <con:PaymentAllocation runat="server" id="PaymentAllocation"/>
            </con:TabList>
        </Pages>
    </con:TabControl>

</asp:Content>

<asp:Content ContentPlaceHolderID="Footer" runat="server">
    <con:PageFooter runat="server" />
</asp:Content>