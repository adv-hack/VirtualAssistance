<%@ Page Language="C#" MasterPageFile="~/assets/templates/StandardDetail.master" AutoEventWireup="true" CodeBehind="GiftAidClaimPage.aspx.cs" Inherits="Consensus.Web.BackOffice.finance.GiftAidClaimPage" %>

<%@ Register TagPrefix="con" TagName="GiftAidClaimDetails" Src="~/finance/controls/GiftAidClaimDetails.ascx" %>
<%@ Register TagPrefix="con" TagName="GiftAidClaimBatchList" src="~/finance/controls/GiftAidClaimBatchList.ascx" %>
<%@ Register TagPrefix="con" TagName="PageFooter" Src="~/common/controls/PageFooter.ascx" %>

<asp:Content ID="Content3" ContentPlaceHolderID="TopContent" runat="server">
    <con:TabControl runat="server">
        <Pages>
            <con:TabPage runat="server" Title="Overview">
                <con:GiftAidClaimDetails runat="server" ID="GiftAidClaimDetails" />
            </con:TabPage>
        </Pages>
    </con:TabControl>
</asp:Content>

<asp:Content ID="Content4" ContentPlaceHolderID="BottomContent" runat="server">
    <con:TabControl runat="server" Mode="Simple" ID="BottomTabControl">
        <Pages>
            <con:TabList runat="server" Title="Batches" EnableCreation="false">
                <con:GiftAidClaimBatchList runat="server" id="GiftAidClaimBatchList" />
            </con:TabList>
       </Pages>
    </con:TabControl>


</asp:Content>

<asp:Content ContentPlaceHolderID="Footer" runat="server">
    <con:PageFooter runat="server" />
</asp:Content>