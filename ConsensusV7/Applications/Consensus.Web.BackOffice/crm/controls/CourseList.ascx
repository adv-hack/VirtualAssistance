<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="CourseList.ascx.cs" Inherits="Consensus.Web.BackOffice.crm.controls.CourseList" %>
<con:DataTable runat="server" ID="CourseListResult" Url="~/GenericPopup.aspx?context=crm&control=coursedetail&id={{Id}}">
  <Columns>    
    <con:DataTableLinkColumn Title="Course" LinkHref="~/learning/course?id={{PROD_ID}}" LinkText="{{PROD_NAME}}" />
    <con:DataTableTextColumn Title="Cost" FieldName="TPXREF_COST" />
    <con:DataTableDateColumn Title="Start Date" FieldName="TPXREF_START_DATE" />  
    <con:DataTableDateColumn Title="End Date" FieldName="TPXREF_END_DATE" />
    <con:DataTableTextColumn Title="Status" FieldName="TPXREF_STATUS" />    
    <con:DataTableTextColumn Title="Grade" FieldName="TPXREF_GRADE" />
  </Columns>
</con:DataTable>