<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="TrainersTemplateList.ascx.cs" Inherits="Consensus.Web.BackOffice.learning.controls.TrainersTemplateList" %>
<con:DataTable runat="server" ID="TrainerListResult" Mode="Stateful" Url="~/genericPopup.aspx?context=learning&control=trainertemplatedetail">
  <Columns>
    <con:DataTableTextColumn Title="Trainer" FieldName="TrainerRole.PersonName" />
    <con:DataTableTextColumn Title="Type" FieldName="TypeModelCode" />
    <con:DataTableTextColumn Title="Cost" FieldName="Cost" />
    <con:DataTableTextColumn Title="Per" FieldName="UntType" />
    <con:DataTableTextColumn Title="Ratio" FieldName="Ratio" />
  </Columns>
</con:DataTable>


