<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="PrincipalList.ascx.cs" Inherits="Consensus.Web.BackOffice.security.controls.PrincipalList" %>
<con:DataTable runat="server" ID="SearchResult" CanExport="false" CanPrint="false" CanSearch="false" CanCreate="false" CanModify="false">
  <Columns>
    <con:DataTableTextColumn Title="Name" FieldName="Name" />
  </Columns>
</con:DataTable>