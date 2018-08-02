<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="ProfileList.ascx.cs" Inherits="Consensus.Web.BackOffice.crm.ProfileList" %>
<con:DataTable runat="server" ID="ProfileListResult" Url="~/GenericPopup.aspx?context=crm&control=profiledetail&id={{Id}}">
  <Columns>
    <con:DataTableTextColumn Title="Level 1" FieldName="Key" />
    <con:DataTableTextColumn Title="Level 2" FieldName="Value" />
    <con:DataTableTextColumn Title="Level 3" FieldName="Value 2" />
    <con:DataTableTextColumn Title="Status" FieldName="Status" />
    <con:DataTableTextColumn Title="Notes" FieldName="Notes" />
  </Columns>
</con:DataTable>


