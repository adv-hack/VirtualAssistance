<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="DepartmentList.ascx.cs" Inherits="Consensus.Web.BackOffice.crm.DepartmentList" %>
<con:DataTable runat="server" ID="DepartmentSearchList" Url="~/GenericPopup.aspx?context=crm&control=departmentdetail&id={{Id}}">
  <Columns>
    <con:DataTableTextColumn Title="Department" FieldName="Department" />
  </Columns>
</con:DataTable>