<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="CommitteeMemberList.ascx.cs" Inherits="Consensus.Web.BackOffice.membership.controls.CommitteeMemberList" %>
<con:DataTable runat="server" ID="CommitteeMemberLists" Url="~/GenericPopup.aspx?context=membership&control=committeememberdetail&id={{Id}}">
    <Columns>
        <con:DataTableLinkColumn Title="Name" LinkHref="~/crm/person?id={{PROLE_PERSON_ID}}" LinkText="{{PROLE_PN_NAME}}" />
        <con:DataTableTextColumn Title="Committee role" FieldName="COMXREF_ROLE" />
        <con:DataTableLinkColumn Title="Phone" LinkHref="tel:{{PROLE_PHONE}}" LinkText="{{PROLE_PHONE}}" />
        <con:DataTableLinkColumn Title="Email " LinkHref="mailto:{{PROLE_EMAIL}}" LinkText="{{PROLE_EMAIL}}" />
        <con:DataTableLinkColumn Title="Organisation" LinkHref="~/crm/organisation?id={{PROLE_ORG_ID}}" LinkText="{{PROLE_ORG_NAME}}" />
        <con:DataTableDateColumn Title="Date added" FieldName="COMXREF_DATE" />
    </Columns>
</con:DataTable>
