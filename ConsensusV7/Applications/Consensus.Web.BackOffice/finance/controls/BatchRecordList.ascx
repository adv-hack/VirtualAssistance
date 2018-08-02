<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="BatchRecordList.ascx.cs" Inherits="Consensus.Web.BackOffice.finance.controls.BatchRecordList" %>

<con:DataTable runat="server" Mode="RealTime" ID="RecordList" CanCreate="false" CanModify="false">
    <Columns>
        <con:DataTableLinkColumn Title="View" LinkHref="{{BATXR_LINK_URL}}" LinkText="View" Visible="false" />
        <con:DataTableCustomColumn Title="View" CssClass="ViewLinkRecord">
            var LinkURL = consensus.data.getValue(row, "BATXR_LINK_URL") || '';
            var LinkID = consensus.data.getValue(row, "BATXR_LINK_ID") || '';            
                if (LinkURL == '')
                    return 'Not Available';
                else 
                {
                    var page = consensus.resolveUrl("~/"+LinkURL);
                    var link = $('<a />').attr('href', page).attr('class','icons8-view_file');
                    return link[0].outerHTML;
                }
        </con:DataTableCustomColumn>
        <con:DataTableTextColumn Title="Linked Item" FieldName="BATXR_TABLE_NAME" />
        <con:DataTableTextColumn Title="Record Id" FieldName="BATXR_RECORD_ID" />
        <con:DataTableTextColumn Title="Status" FieldName="BATXR_STATUS" />
        <con:DataTableLinkColumn Title="Delete" LinkHref="BATXR_ID" LinkText="Delete" Visible="false" />
        <con:DataTableCustomColumn Title="Delete" CssClass="datatable-buttons DeleteLinkRecord">
                          
               var dataTable = meta.settings.nTable.id;
            
          return '<a onclick="' + dataTable + '.removeRow(this);" class="icons8-delete" title="Delete"></a>';
        </con:DataTableCustomColumn>


    </Columns>
</con:DataTable>

<script type="text/javascript">

    $(function () {

        $('[id$=_SaveButton]').click(function () {
            AddLinks();
        });

        $('[id$=_UndoButton]').click(function () {
            AddLinks();
        });

        $('[id$=_EditButton]').click(function () {
            RemoveLinks();
        });

    });

    //Removes hidden attribute
    function AddLinks() {
        $("th.ViewLinkRecord").removeAttr("hidden");
        $("td.ViewLinkRecord").removeAttr("hidden");
        $("th.DeleteLinkRecord").removeAttr("hidden");
        $("td.DeleteLinkRecord").removeAttr("hidden");
    }

    //Adds hidden attribute
    function RemoveLinks() {
        $("th.ViewLinkRecord").attr("hidden", "true");
        $("td.ViewLinkRecord").attr("hidden", "true");
        $("th.DeleteLinkRecord").attr("hidden", "true");
        $("td.DeleteLinkRecord").attr("hidden", "true");
    }

</script>

