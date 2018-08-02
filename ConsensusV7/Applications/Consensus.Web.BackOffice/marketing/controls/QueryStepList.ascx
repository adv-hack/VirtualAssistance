<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="QueryStepList.ascx.cs" Inherits="Consensus.Web.BackOffice.marketing.QueryStepList" %>
<con:DataTable runat="server" ID="StepResult" Mode="RealTime" CanDelete="true" Url="~/GenericPopup.aspx?context=marketing&width=600&control=stepquerydetail&id={{Id}}" >
  <Columns>
    <con:DataTableTextColumn Title="Step ID" FieldName="STEP_ID" />
    <%--<con:DataTableTextColumn Title="Name" FieldName="STEP_NAME" />--%>
    <con:DataTableLinkColumn Title="Name" LinkHref="~/marketing/steppage.aspx?id={{STEP_ID}}" LinkText="{{STEP_NAME}}" />
    <con:DataTableTextColumn Title="Description" FieldName="STEP_DESC" />
    <con:DataTableTextColumn Title="Link Type" FieldName="QSTEP_LINK" />
    <con:DataTableTextColumn Title="Roles" FieldName="QSTEP_ROLE_TOTAL" />
    <con:DataTableTextColumn Title="People" FieldName="QSTEP_PERSON_TOTAL" />
    <con:DataTableTextColumn Title="Organisations" FieldName="QSTEP_ORG_TOTAL" />  
    <con:DataTableTextColumn Title="Total records" FieldName="QSTEP_RESULT_COUNT" /> 
    <con:DataTableReorderColumn Title="Order" FieldName="QSTEP_ORDER"  ModelFieldName="Order" Visible="false" />
  </Columns>
</con:DataTable>