<%@ Page Language="C#" AutoEventWireup="true" MasterPageFile="~/assets/templates/StandardDetail.master" CodeBehind="ICalendarTemplatePage.aspx.cs" Inherits="Consensus.Web.BackOffice.document.ICalendarTemplatePage" %>
<%@ Register TagPrefix="con" Src="~/document/controls/ICalendarTemplateDetail.ascx" TagName="ICalendarTemplateDetail" %>

<asp:Content ContentPlaceHolderID="TopContent" runat="server">
    <con:TabControl runat="server" id="TopTabControl">
        <Pages>
            <con:TabPage runat="server" Title="Overview">
                <con:ICalendarTemplateDetail runat="server" id="ICalendarTemplateDetail" />
            </con:TabPage>
        </Pages>
    </con:TabControl>
</asp:Content>
<asp:Content ContentPlaceHolderID="BottomContent" runat="server">
     <con:TabControl runat="server" Mode="Simple" id="BottomTabControl">
        <Pages>            
        </Pages>
    </con:TabControl>
</asp:Content>
