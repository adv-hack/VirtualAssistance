<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="MailingListList.ascx.cs" Inherits="Consensus.Web.BackOffice.crm.MailingListList" %>
<con:DataTable runat="server" ID="MailingListListResult" Url="~/GenericPopup.aspx?context=marketing&control=membermailinglistdetail&id={{Id}}" >
  <Columns>
    <con:DataTableTextColumn Title="ID" FieldName="ID" />
    <con:DataTableTextColumn Title="List Name" FieldName="Name" />
    <con:DataTableDateColumn Title="Added Date" FieldName="AddDate" />
    <con:DataTableTextColumn Title="List Status" FieldName="Status" />
  </Columns>
</con:DataTable>


