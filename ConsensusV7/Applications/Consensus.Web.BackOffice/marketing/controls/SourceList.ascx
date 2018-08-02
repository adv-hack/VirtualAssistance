<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="SourceList.ascx.cs" Inherits="Consensus.Web.BackOffice.marketing.SourceList" %>
<con:DataTable runat="server" ID="SourceResult" Url="~/marketing/sourcepage.aspx?id={{Id}}" Mode="Redirect" CreateUrl="~/marketing/sourcepage.aspx?mstid={{PromotionMasterId}}" >
  <Columns>
    <con:DataTableTextColumn Title="Source Code" FieldName="PM_NAME" runat="server" />
    <con:DataTableDateColumn Title="Start Date" FieldName="PM_START_DATE" runat="server" />
    <con:DataTableTextColumn Title="Channel" FieldName="PM_CHANNEL" runat="server" /> 
    <con:DataTableTextColumn Title="Media" FieldName="PM_MEDIA_NAME" runat="server" /> 
    <con:DataTableIconColumn Title="Current"  FieldName="PM_CURRENT" runat="server" /> 
  </Columns>
</con:DataTable>