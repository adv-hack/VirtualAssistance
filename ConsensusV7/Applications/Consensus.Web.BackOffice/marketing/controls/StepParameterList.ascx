<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="StepParameterList.ascx.cs" Inherits="Consensus.Web.BackOffice.marketing.StepParameterList" %>
<con:DataTable runat="server" ID="StepParameterResult" Mode="RealTime" Url="~/GenericPopup.aspx?context=marketing&control=stepparameterdetail&id={{Id}}"  >

  <Columns>      
    <con:DataTableTextColumn Title="Condition" FieldName="STPRM_CONDITION" />
    <con:DataTableTextColumn Title="((" FieldName="STPRM_PRE_BRACKET" />
    <con:DataTableTextColumn Title="Filter Field" FieldName="F_COLUMN_DESC" />
    <con:DataTableTextColumn Title="Comparison" FieldName="OPERAND_DESC" />
    <con:DataTableTextColumn Title="Value" FieldName="STPRM_VALUE" />
    <con:DataTableTextColumn Title="))" FieldName="STPRM_POST_BRACKET" />
    <con:DataTableReorderColumn Title="Order" FieldName="STPRM_ORDER" ModelFieldName="Order" Visible="false"/>
  </Columns>
</con:DataTable>
<script>

    function hide1stRowCondition() {
        var table = $("#<%=StepParameterResult.ClientID%>");
        var api = table.dataTable().api();
        api.rows({ order: 'current' }).every(function (rowIdx, tableLoop, rowLoop) {
            $(api.cell(rowIdx, 1).node()).text(rowLoop == 0 ? "" : api.cell(rowIdx, 1).data());
        });
    }

    $(document).ready(function () {
        hide1stRowCondition(); // In theory we don't need this, however on initialisation the draw.dt event is slow to fire.
        var table = $("#<%=StepParameterResult.ClientID%>");
        table.dataTable().on("draw.dt", function () {
            hide1stRowCondition();
        });

    });

</script>