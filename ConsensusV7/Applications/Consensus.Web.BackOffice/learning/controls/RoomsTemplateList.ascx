<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="RoomsTemplateList.ascx.cs" Inherits="Consensus.Web.BackOffice.learning.controls.RoomsTemplateList" %>
<con:DataTable runat="server" ID="RoomsListResult" Mode="Stateful" Url="~/genericPopup.aspx?context=learning&control=roomtemplatedetail">
  <Columns>
    <con:DataTableTextColumn Title="Type" FieldName="RoomTypeCode" />
    <con:DataTableTextColumn Title="Cost" FieldName="Cost" />
    <con:DataTableTextColumn Title="Per" FieldName="UntType" />
  </Columns>
</con:DataTable>
