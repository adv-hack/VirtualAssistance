<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="NewPersonDetail.ascx.cs" Inherits="Consensus.Web.BackOffice.crm.controls.NewPersonDetail" %>
<%@ Register TagPrefix="con" TagName="PersonDetails" Src="~/crm/controls/NewPersonBasicDetails.ascx" %>
<%@ Register TagPrefix="con" TagName="DataProtection" Src="~/crm/controls/DataProtection.ascx" %>
<con:TabControl runat="server">
    <Pages>
        <con:TabPage id="PersonDetailsSection" runat="server" Title="New Person">
            <con:PersonDetails runat="server" id="PersonDetails" />                  
        </con:TabPage>
        <con:TabPage id="DataProtectionSection" runat="server" Title="Data Protection">
            <con:DataProtection runat="server" id="DataProtection" />            
        </con:TabPage>            
    </Pages>
</con:TabControl>