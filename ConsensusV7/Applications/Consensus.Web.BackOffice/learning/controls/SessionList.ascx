<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="SessionList.ascx.cs" Inherits="Consensus.Web.BackOffice.learning.SessionList" %>
<con:DataTable runat="server" ID="SessionListResult" Url="~/GenericPopup.aspx?context=learning&control=eventsessiondetail&width=1150&id={{Id}}" SerializeListsAtDepth="Root">
  <Columns>
    <con:DataTableTextColumn Title="Name" FieldName="ACT_SESSION_NAME" />
    <con:DataTableTextColumn Title="Group" FieldName="CSG_NAME" />
    <con:DataTableDateColumn Title="Start Date" FieldName="ACT_ACTION_DATE" />  
    <con:DataTableTextColumn Title="Start Time" FieldName="ACT_START_TIME" />
    <con:DataTableDateColumn Title="End Date" FieldName="ACT_END_DATE" />  
    <con:DataTableTextColumn Title="End Time" FieldName="ACT_END_TIME" />
    <con:DataTableTextColumn Title="Location" FieldName="LOC_NAME" />
    <con:DataTableTextColumn Title="Mandatory" FieldName="MANDATORY" />
    <con:DataTableTextColumn Title="Max" FieldName="ACT_MAX_PLACES" />
    <con:DataTableTextColumn Title="Free" FieldName="ACT_FREE_PLACES" />
    <con:DataTableIconColumn Title="Shared" FieldName="SHARED" />
  </Columns>
</con:DataTable>
