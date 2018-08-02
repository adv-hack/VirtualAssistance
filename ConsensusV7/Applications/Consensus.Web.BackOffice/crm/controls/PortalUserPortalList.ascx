<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="PortalUserPortalList.ascx.cs" Inherits="Consensus.Web.BackOffice.crm.controls.PortalUserPortalList" %>
<con:DataTable runat="server" ID="SearchResult" CanExport="false" CanPrint="false" CanResize="false" CanSearch="false" Mode="Stateful" CanCreate="false" CanModify="false">
  <Columns>
    <con:DataTableTextColumn Title="ID" FieldName="PS_ID" Width="95px" />
    <con:DataTableTextColumn Title="Portal" FieldName="PS_PORTAL_TITLE" />
    <con:DataTableCheckColumn Title="Access" FieldName="SELECTED" Width="95px" />
    <con:DataTableTextColumn Title="User Site ID" FieldName="PUSTE_ID" Visible="false"/>
  </Columns>
</con:DataTable>
<asp:CustomValidator runat="server" ClientValidationFunction="validateSelectedPortals" Display="None" EnableClientScript="true" ErrorMessage="At least one Portal must be selected" />
<script type="text/javascript">
    function savePortalUserPortals(state, result, callback) {
        var dataTable = window['<%= this.SearchResult.ClientID %>'];
        var portalUser = '<%= this.PortalUser %>';

        if (portalUser == 0) {
            portalUser = result.Id;
        }    

            consensus.network.send({
                url: 'portal/portalUser/' + portalUser + '/UpdateUserPortals',
                method: 'post',
                async: false,
                data: {
                    portaluserPortals: dataTable._getSourceData(),
                },
                success: function () {                    
                    savePortalUserRoles(state, result, callback);
                }
            });
            return true;

    }

    function validateSelectedPortals(source, arguments) {
        var selected = ($('#<%= this.SearchResult.ClientID %>').find('input[type="checkbox"]:checked').length)

            arguments.IsValid = (selected > 0);

        }
</script>