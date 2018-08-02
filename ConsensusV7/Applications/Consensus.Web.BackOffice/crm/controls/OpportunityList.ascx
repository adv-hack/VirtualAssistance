<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="OpportunityList.ascx.cs" Inherits="Consensus.Web.BackOffice.crm.OpportunityList" %>
<con:DataTable runat="server" ID="OppListResult" Mode="Redirect"  CreateUrl="~/sales/opportunitypage.aspx?" Url="~/sales/opportunitypage.aspx?id={{Id}}">
  <Columns>
    <con:DataTableTextColumn Title="Name" FieldName="Name" />
    <con:DataTableLinkColumn Title="Person" LinkHref="personpage.aspx?id={{PN_ID}}&role={{PROLE_ID}}" LinkText="{{Person}}" />
    <con:DataTableLinkColumn Title="Organisation" LinkHref="organisationpage.aspx?id={{ORG_ID}}" LinkText="{{Organisation}}" />
    <con:DataTableTextColumn Title="Status" FieldName="Status" />
    <con:DataTableDateColumn Title="Enquiry date" FieldName="EnqDate" />  
    <con:DataTableDateColumn Title="Decision date" FieldName="OPP_DATE_DEC" />  
    <con:DataTableTextColumn Title="Group" FieldName="ProdInterest" /> 
    <con:DataTableTextColumn Title="Type" FieldName="OPP_SALES_TYPE" /> 
    <con:DataTableTextColumn Title="Potential value" FieldName="PotValue" /> 
  </Columns>
</con:DataTable>