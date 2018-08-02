<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="CustomisationList.ascx.cs" Inherits="Consensus.Web.BackOffice.CustomisationList" %>
<!--  OnCreate="consensus.web.customisation.getCreatedData(data)" -->
<con:DataTable runat="server" ID="CustomisationDataTable" CanModify="false" CanResize="false" PageSize="10" 
    CreateUrl="~/GenericPopup.aspx?context=common&control=customisationdetail&buttons=5&width=900" CanCreate="true" CanCreateInEditMode="true" CreateMode="Stateful"
    OnCreate="return insertNewRowAtTop(data)">
  <Columns>
      <con:DataTableIconColumn runat="server" ID="ColIsCustomField" Title="Custom?" FieldName="Configuration.IsCustomField.DefaultValue" Width="15px"></con:DataTableIconColumn>
    <con:DataTableCustomColumn Title="Type" Width="70px">return consensus.web.customisation.createTypeColumn(row);</con:DataTableCustomColumn>    
    <con:DataTableCustomColumn Title="Default Text">return consensus.web.customisation.createBasicColumn(row, 'Title', 'IHaveCustomTitle', 'ICustomFieldContainer');</con:DataTableCustomColumn>    
    <con:DataTableCustomColumn Title="Custom Text" Width="175px">return consensus.web.customisation.createInputColumn(row, 'Title', 'IHaveCustomTitle');</con:DataTableCustomColumn>
    <con:DataTableCustomColumn Title="Default Value" Width="100px">return consensus.web.customisation.createInputColumn(row, 'DefaultValue', 'IHaveDefaultValue');</con:DataTableCustomColumn>
    <con:DataTableCustomColumn Title="Display" Width="90px">return consensus.web.customisation.createVisibleColumn(row);</con:DataTableCustomColumn>
    <con:DataTableCustomColumn Title="Required" Width="100px">return consensus.web.customisation.createMandatoryColumn(row);</con:DataTableCustomColumn>
    <con:DataTableCustomColumn Title=" " Width="0px">
      var button = $('<a />').addClass('icons8-edit_property').attr('title', 'More options').attr('onclick', 'consensus.web.customisation.showDialog(this); return false;').css({ cursor: 'pointer', display: 'block', fontSize: '20px', margin: '0 auto'});
      return $('<div />').append(button).html();
    </con:DataTableCustomColumn>
  </Columns>
</con:DataTable>

<script>
    $(document).ready(function () {
        $('[id$=_CustomisationDataTable_filter').keyup(function () {
            var filterVal = $('[id$=_CustomisationDataTable_filter').find('input').val();
            if ($.trim(filterVal) === '' && filterVal.length == 0)
            {
                if ($('[id$=_CustomisationDataTable_paginate').is(':hidden'))
                    $('[id$=_CustomisationDataTable_paginate').show();
            }
        });
    });

    function insertNewRowAtTop(data) {
        var table = window.consensus.web.dataTable.all[0];
        var array = table._getSourceData();
        array.splice(0, 0, data); // The standard code doew a push here, but this inserts to row 0.
        table.reload();

        return false; // We have completed the functionality required on return from dialog. - return false to prevent more processing. 
    }
</script>