<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="OpportunityPeopleList.ascx.cs" Inherits="Consensus.Web.BackOffice.Sales.controls.OpportunityPeopleList" %>
<con:DataTable runat="server" ID="OppPeopleListResult" EditMode="RealTime" Url="~/GenericPopup.aspx?context=sales&control=OpportunityPersonDetail&id={{Id}}">
  <Columns>
    <con:DataTableTextColumn Title="Type" FieldName="Type" />
    <con:DataTableLinkColumn Title="Person" LinkHref="~/crm/personpage.aspx?id={{OPPXREF_PN_ID}}&role={{OPPXREF_PROLE_ID}}" LinkText="{{Person}}" />
    <con:DataTableLinkColumn Title="Organisation" LinkHref="~/crm/organisationPage.aspx?id={{OPPXREF_ORG_ID}}" LinkText="{{Organisation}}" />
    <con:DataTableLinkColumn Title="Telephone" LinkHref="tel:{{Telephone}}" LinkText="{{Telephone}}" />
    <con:DataTableLinkColumn Title="Mobile" LinkHref="tel:{{Mobile}}" LinkText="{{Mobile}}" />
    <con:DataTableLinkColumn Title="Email address" LinkHref="mailto:{{Email}}" LinkText="{{Email}}"  />  
    <con:DataTableTextColumn Title="Value" FieldName="Value" ID="ValueColumn" runat="server" />  
    <con:DataTableIconColumn Title="Opportunity owner" FieldName="MainSalesPerson" ID="MainSalesPersonColumn" runat="server" />
  </Columns>
</con:DataTable>
