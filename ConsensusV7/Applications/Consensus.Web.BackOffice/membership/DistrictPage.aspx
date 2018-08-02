<%@ Page Language="C#" AutoEventWireup="true" MasterPageFile="~/assets/templates/StandardDetail.master" CodeBehind="DistrictPage.aspx.cs" Inherits="Consensus.Web.BackOffice.membership.DistrictPage" %>
<%@ Register TagPrefix="con" TagName="DistrictDetails" Src="~/membership/controls/DistrictDetails.ascx" %>
<%@ Register TagPrefix="con" TagName="PageFooter" Src="~/common/controls/PageFooter.ascx" %>

<asp:Content ContentPlaceHolderID="TopContent" runat="server">
    <con:TabControl runat="server" id="TopTabControl">
        <Pages>
            <con:TabPage runat="server" Title="Overview">      
                <con:DistrictDetails runat="server" ID="DistrictDetails" />         
            </con:TabPage>
        </Pages>
    </con:TabControl>
</asp:Content>
<asp:Content ContentPlaceHolderID="Footer" runat="server">
    <con:PageFooter runat="server" />
</asp:Content>