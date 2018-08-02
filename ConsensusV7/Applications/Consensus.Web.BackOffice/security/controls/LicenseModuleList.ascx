<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="LicenseModuleList.ascx.cs" Inherits="Consensus.Web.BackOffice.security.controls.LicenseModuleList" %>
<con:DataTable runat="server" ID="SearchResult" CanExport="false" CanPrint="false" CanResize="false" CanSearch="false" Mode="Stateful" CanCreate="false" CanModify="false">
    <Columns>
        <con:DataTableTextColumn Title="Module" FieldName="ModuleDescription" />        
        <con:DataTableCustomColumn Title="Enabled" Width="95px">
            var checkGuid = 'check_' + consensus.data.guid();
            var inputValue = consensus.data.getValue(row, "Enabled");
            var parseValue = (typeof(inputValue) != 'undefined' && inputValue != null && inputValue != 0 && inputValue != '0' && inputValue.toString().toLowerCase() != 'no' && inputValue.toString().toLowerCase() != 'false');
            var checkField = $('<input />').addClass('stylised licenseCheckEnabled').attr('checked', parseValue ? 'checked' : null).attr('id', checkGuid).attr('onclick', 'window.consensus.web.dataTable.toggle(this, "Enabled");').attr('type', 'checkbox').css('display','none');
            var labelField = $('<label />').attr('for', checkGuid).css('display','none').addClass('licenseLabelEnabled');
            var element=$('<div />').append(checkField).append(labelField);   
            var iconField= $('<i />');            
            if(parseValue)
            {
                iconField.addClass('icons8-checkmark').attr('id', 'licenseCheckMark');
                element.append(iconField);                
            }
            else
            {                
                iconField.addClass('icons8-delete_sign').attr('id', 'licenseDeleteMark');
                element.append(iconField);                
            }                                               
            
            return element.html();     
            
        </con:DataTableCustomColumn>
    </Columns>
</con:DataTable>

<script type="text/javascript">
    $(function () {

        //Changes Icon field to Checkbox on change of data-mode
        $(document).on('data-mode', function () {
            var data = $("#DetailPageContent").attr("data-mode");
            if (data == 'edit') {
                $('i#licenseCheckMark').css('display', 'none');
                $('i#licenseDeleteMark').css('display', 'none');
                $('label.licenseLabelEnabled').css('display', 'block');
                $('input.licenseCheckEnabled').click(function () {
                    window.consensus.web.dataTable.toggle(this, 'Enabled');
                });
            }
            else {
                $('i#licenseCheckMark').css('display', '');
                $('i#licenseDeleteMark').css('display', '');
                $('label.licenseLabelEnabled').css('display', 'none');
            }
        });


        $('[id$=_SaveButton]').click(function () {
            $(document).trigger('data-mode');
        });

        $('[id$=_UndoButton]').click(function () {
            $(document).trigger('data-mode');
        });

        $('[id$=_ModulesTab] [id$=_SearchResult]').on('draw.dt', function () {
            $(document).trigger('data-mode');
        }).dataTable();
        

    });

</script>
