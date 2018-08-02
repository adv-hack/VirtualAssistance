<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="TemplateList.ascx.cs" Inherits="Consensus.Web.BackOffice.learning.TemplateList" %>
<con:DataTable runat="server" ID="TemplateListResults" Url="~/GenericPopup.aspx?context=learning&control=" SerializeListsAtDepth="Root">
  <Columns>
    <con:DataTableTextColumn Title="Activity" FieldName="BOM_ACT_TYPE" Visible ="false" />
    <con:DataTableTextColumn Title="Name" FieldName="BOM_ACT_SESSION_NAME" Visible ="false" />
    <con:DataTableLinkColumn Title="Name" LinkHref="coursepage.aspx?id={{BOM_SYLLABUS_ID}}" LinkText="{{PROD_NAME}}" Visible ="true" />
    <con:DataTableLinkColumn Title="Name" LinkHref="productpage.aspx?id={{BOM_SYLLABUS_ID}}" LinkText="{{PROD_NAME}}" Visible ="false" />
    <con:DataTableTextColumn Title="Reference" FieldName="PROD_REF" Visible ="true"/>
    <con:DataTableTextColumn Title="Type" FieldName="BOM_TYPE_SUB" Visible ="false"/>     
    <con:DataTableTextColumn Title="Mandatory" FieldName="BOM_MANDATORY" Visible ="true"/>
    <con:DataTableIconColumn Title="Chargeable" FieldName="BOM_CHARGEABLE" Visible ="true"/>
    <con:DataTableTextColumn Title="Per Delegate" FieldName="TXREF_DEL_QTY" Visible ="false"/>
    <con:DataTableTextColumn Title="Spare" FieldName="TXREF_QTY" Visible ="false"/>
    <con:DataTableTextColumn Title="Start Day" FieldName="BOM_START_DAY_TEXT" Visible ="true"/>
    <con:DataTableTextColumn Title="Start Time" FieldName="BOM_START_TIME" Visible ="true"/>
    <con:DataTableTextColumn Title="End Day" FieldName="BOM_END_DAY_TEXT" Visible ="true"/>
    <con:DataTableTextColumn Title="End Time" FieldName="BOM_END_TIME" Visible ="true"/>
    <con:DataTableTextColumn Title="Start Date Type" FieldName="PROD_START_DATE_TYPE" Visible ="false"/>
    <con:DataTableTextColumn Title="End Date Type" FieldName="PROD_END_DATE_TYPE" Visible ="false"/>
    <con:DataTableTextColumn Title="Start Date" FieldName="PROD_START_DATE_FIXED" Visible ="false"/>
    <con:DataTableTextColumn Title="End Date" FieldName="PROD_END_DATE_FIXED" Visible ="false"/>
    <con:DataTableTextColumn Title="Main session" FieldName="BOM_MAIN_SESSION" Visible ="false"/>
    <con:DataTableTextColumn Title="Selection Group" FieldName="PSG_NAME" Visible ="true"/>
  </Columns>
</con:DataTable>

