<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="MemberLocationsList.ascx.cs" Inherits="Consensus.Web.BackOffice.membership.MemberLocationsList" %>
<con:DataTable runat="server" ID="LocationListResult" Url="~/GenericPopup.aspx?context=membership&control=memberlocationdetail&id={{Id}}">
  <Columns>
    <con:DataTableTextColumn Title="Id" FieldName="MEL_ID" />
    <con:DataTableLinkColumn Title="Contact" LinkHref="~/crm/personpage.aspx?id={{PN_ID}}&role={{MEL_PROLE_ID}}" LinkText="{{PROLE_PN_NAME}}" />
    <con:DataTableLinkColumn Title="Organisation" LinkHref="~/crm/organisationpage.aspx?id={{MEL_ORG_ID}}" LinkText="{{ORG_NAME}}" />
    <con:DataTableTextColumn Title="Status" FieldName="Status" />
    <con:DataTableTextColumn Title="Fee" FieldName="MEL_FEE" />  
    <con:DataTableTextColumn Title="VAT" FieldName="MEL_VAT_AMT" /> 
    <con:DataTableTextColumn Title="VAT Code" FieldName="MEL_VATCD" /> 
    <con:DataTableIconColumn Title="Invoiced" FieldName="MEL_INVOICED" />
    <con:DataTableIconColumn Title="Modified" FieldName="MEL_PRICE_MODIFIED" />     
    <con:DataTableTextColumn Title="MainLocation" FieldName="MEL_RENEW_LOC" Visible="false"/>
  </Columns>
</con:DataTable>
