<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="UserPermissionList.ascx.cs" Inherits="Consensus.Web.BackOffice.security.controls.UserPermissionList" %>
<con:DataTable runat="server" ID="PermissionList" CanExport="true" CanPrint="true" CanSearch="true" Mode="Stateful" CanCreate="false" CanModify="false" Url="~/GenericPopup.aspx?context=security&control=userpermissiondetail" PageSize="10">
  <Columns>
    <con:DataTableTextColumn Title="Module" FieldName="Module" />
    <con:DataTableTextColumn Title="Type" FieldName="Name" />    
  </Columns>
</con:DataTable>
<script type="text/javascript">
    function createPermissionColumn(row, action) {
        var chkId = 'check_' + consensus.data.guid();
        var value = jQuery.grep(row.Permissions, function (permission) { return permission.Type == 'UserPermissionActions' && permission.Name == action })[0];
        var input = $('<input />').addClass('stylised').attr('type', 'checkbox').attr('checked', value.Value === true ? 'checked' : null).attr('id', chkId).attr('onclick', 'updatePermissionColumn(this);').attr('data-permission-action', action);
        var label = $('<label />').attr('for', chkId);
        return input[0].outerHTML + label[0].outerHTML;
    }
    function updatePermissionColumn(element) {
        var row = $(element).parents('tr').first();
        var tbl = $(element).parents('table').first();
        var obj = tbl.dataTable().api().row(row).data();
        var action = $(element).attr('data-permission-action');
        var value = jQuery.grep(obj.Permissions, function (permission) { return permission.Type == 'UserPermissionActions' && permission.Name == action })[0];
        value.Value = $(element).is(':checked') ? true : null;
    }
    function createPermissionOption(row) {
        var hasCustom = false;
        for (var i = 0; i < row.Permissions.length; i++)
            if (row.Permissions[i].Type != 'UserPermissionActions')
                hasCustom = true;
        return !hasCustom ? '' : $('<a />').addClass('icons8-edit_property').attr('title', 'More Permissions').attr('onclick', 'displayCustomPermissions(this);return false;').css({ cursor: 'pointer', display: 'block', fontSize: '20px', margin: '0 auto' })[0].outerHTML;
    }
    function displayCustomPermissions(element) {
        var row = $(element).parents('tr').first();
        var tbl = $(element).parents('table').first();
        var obj = tbl.dataTable().api().row(row).data();
        consensus.web.popupFrame({
            url: consensus.resolveUrl('~/genericpopup.aspx?context=security&control=userpermissiondetail&buttons=5&width=500'),
            open: function () {
                var closeBtn = $(this.document).find('.btn.btn-primary');
                var stateObj = new consensus.data.state(closeBtn, obj, this);
                this.consensus.data.setState(stateObj);
                this.initialiseDialog(obj);
            },
            title: 'Amend Permissions',
            result: function (data) {
                var pageNumber = $('#<%= this.PermissionList.ClientID %>').dataTable().api().page();
                var dataTable = jQuery.grep(window.consensus.web.dataTable.all, function (dt) { return dt._tableElement.attr('id') == '<%= this.PermissionList.ClientID %>'; })[0];
                dataTable._reload(dataTable._sourceData);
                $('#<%= this.PermissionList.ClientID %>').dataTable().api().page(pageNumber).draw(false);
            }
        });
    }
    function applyPermission(permission) {
        var data = $('#<%= this.PermissionList.ClientID %>').dataTable().api().rows({ filter: 'applied' }).data();
        if (data.length != 0) {
            var toggle = jQuery.grep(data[0].Permissions, function (element) { return element.Name == permission; })[0].Value !== true;
            for (var i = 0; i < data.length; i++)
                jQuery.grep(data[i].Permissions, function (element) { return element.Name == permission; })[0].Value = toggle;
        }
        var pageNumber = $('#<%= this.PermissionList.ClientID %>').dataTable().api().page();
        var dataTable = window['<%= this.PermissionList.ClientID %>'];
        dataTable._reload(dataTable._getSourceData());
        $('#<%= this.PermissionList.ClientID %>').dataTable().api().page(pageNumber).draw(true);
        $('#<%= this.PermissionList.ClientID %>_paginate').css('display', 'block');

    }
    consensus.data.onsave = function (state, result, callback) {
        var dataTable = window['<%= this.PermissionList.ClientID %>'];
        var principal = consensus.data.getState().object.Principal.Id;        
        if (principal == 0 && result.Principal) {
            principal = result.Principal.Id;        
        }

        consensus.network.send({
            url: 'security/userprincipal/' + principal + '/SetPermissions',
            method: 'post',
            data: {
                permissionSets: dataTable._getSourceData(),
            },
            success: function () {
                callback.call(this, state, result);
            }
        });
    }
    
    $(document).ready(function () {
        var headers = $('#<%= this.PermissionList.ClientID %> thead th');
        for (var i = 2; i < headers.length - 1; i++) {
            var link = $('<a />').addClass('consensus-visible-edit').attr('href', '#').attr('onclick', 'applyPermission("' + $(headers[i]).text() + '"); return false').text($(headers[i]).text())
            var span = $('<span />').addClass('consensus-visible-read').text($(headers[i]).text())
            $(headers[i]).text('').append(link).append(span);
        }
    });
</script>
