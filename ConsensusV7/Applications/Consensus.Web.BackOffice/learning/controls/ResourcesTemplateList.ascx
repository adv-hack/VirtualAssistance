<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="ResourcesTemplateList.ascx.cs" Inherits="Consensus.Web.BackOffice.learning.controls.ResourcesTemplateList" %>
<con:DataTable runat="server" ID="ResourcesListResult" Mode="Stateful" Url="~/genericPopup.aspx?context=learning&control=resourcetemplatedetail">
  <Columns>
    <con:DataTableTextColumn Title="Ref" FieldName="Resource.Ref" />
    <con:DataTableTextColumn Title="Name" FieldName="Resource.Name" />
    <con:DataTableTextColumn Title="Per Session" FieldName="Qty" />
    <con:DataTableTextColumn Title="Per Delegate" FieldName="DelQty" />
    <con:DataTableIconColumn Title="Per Day" FieldName="PerDay" />
  </Columns>
</con:DataTable>


