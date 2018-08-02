<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="UserPermissionDetail.ascx.cs" Inherits="Consensus.Web.BackOffice.security.controls.UserPermissionDetail" %>
<con:DataTable runat="server" ID="PermissionList" CanExport="false" CanPrint="false" CanSearch="false" Mode="Stateful" CanCreate="false" CanModify="false" PageSize="10">
  <Columns>
    <con:DataTableTextColumn Title="Type" FieldName="Name" />    
    <con:DataTableCustomColumn Title="Permission" Width="95px">return createPermissionColumn(row);</con:DataTableCustomColumn>
  </Columns>
</con:DataTable>
<script type="text/javascript">

    function initialiseDialog(obj) {
        var table = window.consensus.web.dataTable.all[0]._reload(obj.Permissions);
    }
    function createPermissionColumn(value) {
        var chkId = 'check_' + consensus.data.guid();
        var input = $('<input />').addClass('stylised').attr('type', 'checkbox').attr('checked', value.Value === true ? 'checked' : null).attr('id', chkId).attr('onclick', 'updatePermissionColumn(this);');
        var label = $('<label />').attr('for', chkId);
        return input[0].outerHTML + label[0].outerHTML;
    }
    function updatePermissionColumn(element) {
        var row = $(element).parents('tr').first();
        var tbl = $(element).parents('table').first();
        var obj = tbl.dataTable().api().row(row).data();
        obj.Value = $(element).is(':checked') ? true : null;
    }
</script>