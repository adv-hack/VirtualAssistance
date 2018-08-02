<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="LicenseLimitList.ascx.cs" Inherits="Consensus.Web.BackOffice.security.controls.LicenseLimitList" %>
<con:DataTable runat="server" ID="LicenseLimitSearchResult" CanExport="false" CanPrint="false" CanResize="false" CanSearch="false" Mode="Stateful" Url="~/GenericPopup.aspx?context=security&control=licenselimitdetail&id={{Id}}">
  <Columns>
    <con:DataTableTextColumn Title="Type" FieldName="TypeDescription" />
    <con:DataTableTextColumn Title="Limitation" FieldName="Value" />
  </Columns>
</con:DataTable>