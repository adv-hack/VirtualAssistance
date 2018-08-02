<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="EventTeamSessionList.ascx.cs" Inherits="Consensus.Web.BackOffice.learning.controls.EventTeamSessionList" %>

<con:DataTable runat="server" ID="SearchResult" CanExport="false" CanPrint="false" CanResize="false" CanSearch="false" Mode="Stateful" CanCreate="false" CanModify="false">
    <Columns>
        <con:DataTableTextColumn Title="SessionName" FieldName="Session" />
        <con:DataTableDateColumn Title="Start date" FieldName="StartDate" />
        <con:DataTableTextColumn Title="Start Time" FieldName="StartTime" />
        <con:DataTableTextColumn Title="End Date" FieldName="End Time" />
        <con:DataTableDateColumn />
        <con:DataTableCustomColumn Title="Enabled" Width="95px">
            var checkGuid = 'check_' + consensus.data.guid();
            var inputValue = consensus.data.getValue(row, "Enabled");
            var parseValue = (typeof(inputValue) != 'undefined' && inputValue != null && inputValue != 0 && inputValue != '0' && inputValue.toString().toLowerCase() != 'no' && inputValue.toString().toLowerCase() != 'false');
            var checkField = $('<input />').addClass('stylised licenseCheckEnabled').attr('checked', parseValue ? 'checked' : null).attr('id', checkGuid).attr('onclick', 'window.consensus.web.dataTable.toggle(this, "Enabled");').attr('type', 'checkbox').css('display','none');
            var labelField = $('<label />').attr('for', checkGuid).css('display','none').addClass('licenseLabelEnabled');
            var element=$('<div />
            ').append(checkField).append(labelField);   
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
