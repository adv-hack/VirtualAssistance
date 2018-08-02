<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="AssociateList.ascx.cs" Inherits="Consensus.Web.BackOffice.crm.AssociateList" %>
<con:DataTable runat="server" ID="AssociateListResult" Url="~/GenericPopup.aspx?context=crm&control=associatedetail&id={{Id}}">
  <Columns>
    <con:DataTableTextColumn Title="Type" FieldName="ASSO_TYPE_NAME" />
    <con:DataTableLinkColumn Title="Person" LinkHref="personpage.aspx?id={{ASSO_PERSON_ID}}" LinkText="{{ASSO_PERSON_NAME}}" />
    <con:DataTableLinkColumn Title="Organisation" LinkHref="organisationpage.aspx?id={{ASSO_ORG_ID}}" LinkText="{{ASSO_ORG_NAME}}"  />
    <con:DataTableDateColumn Title="Start Date" FieldName="ASSO_START_DATE" />
    <con:DataTableDateColumn Title="End Date" FieldName="ASSO_END_DATE" />  
  </Columns>
</con:DataTable>



