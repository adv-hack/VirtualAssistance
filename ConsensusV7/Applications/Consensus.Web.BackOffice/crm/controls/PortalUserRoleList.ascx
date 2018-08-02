<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="PortalUserRoleList.ascx.cs" Inherits="Consensus.Web.BackOffice.crm.controls.PortalUserRoleList" %>
<con:DataTable runat="server" ID="SearchResult" CanExport="false" CanPrint="false" CanResize="false" CanSearch="false" Mode="Stateful" CanCreate="false" CanModify="false">
    <Columns>
        <con:DataTableTextColumn Title="ID" FieldName="PR_ID" Width="95px" />
        <con:DataTableTextColumn Title="Role Name" FieldName="PR_TITLE" />
        <con:DataTableCheckColumn Title="Access" FieldName="SELECTED" Width="95px" />
        <con:DataTableTextColumn Title="User Role ID" FieldName="PUR_ID" Visible="false" />
    </Columns>
</con:DataTable>
<asp:CustomValidator runat="server" ClientValidationFunction="validateSelectedRoles" Display="None" EnableClientScript="true" ErrorMessage="At least one Role must be selected" />
<script type="text/javascript">
    function savePortalUserRoles(state, result, callback) {

        var dataTable = window['<%= this.SearchResult.ClientID %>'];
            var portalUser = '<%= this.PortalUser %>';

            if (portalUser == 0) {
                portalUser = result.Id;
            }

            consensus.network.send({
                url: 'portal/portalUser/' + portalUser + '/UpdateUserRoles',
                method: 'post',
                async: false,
                data: {
                    portaluserRoles: dataTable._getSourceData(),
                },
                success: function () {
                    var hasId = typeof (state.source.Id) != 'undefined' && state.source.Id != null && state.source.Id.length != 0 && state.source.Id.toString() != '0';
                    state.toggleSave(null);
                    state.object = jQuery.extend(true, {}, result);
                    state.updateScreen();
                    state.toggleScreen(false);
                    if (window.top.consensus == window.consensus && !hasId)
                        window.location = window.location.toString() + (window.location.toString().indexOf('?') == -1 ? '?' : '&') + 'id=' + result.Id;
                    else
                        window.location.reload();
                }
            });
            return true;
        }

        function validateSelectedRoles(source, arguments) {
            var selected = ($('#<%= this.SearchResult.ClientID %>').find('input[type="checkbox"]:checked').length)

        arguments.IsValid = (selected > 0);

    }
</script>
