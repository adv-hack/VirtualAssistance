<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="CustomisationDetail.ascx.cs" Inherits="Consensus.Web.BackOffice.common.controls.CustomisationDetail" %>
<con:TabControl runat="server" id="TabControl">
  <Pages>
      
    <%-- General Options --%>

    <con:TabPage runat="server" Title="User Fields" ID="TabUserFields">
      <div class="row">
        <div class="col-6"><con:TextField runat="server" ID="CustomFieldName" LabelText="User field name" ValidatorCritical="true" ValidatorExpression="[a-zA-Z_][a-zA-Z0-9_]*" ValidatorMessage="The name can only include letters, numbers and underscores (not spaces), and must start with a letter or underscore." /></div>
        <div class="col-6"><con:TextField runat="server" ID="CustomFieldLabel" LabelText="Text" /></div>
        <div class="col-6"><con:ListField runat="server" ID="CustomFieldType" LabelText="Field type" DisplayMember="Name" ValueMember="Id"/></div>
        <div class="col-6"><con:ListField runat="server" ID="CustomFieldParentControl" LabelText="Section of the screen"/></div>
        <div class="col-6"><con:ListField runat="server" ID="CustomPopupUrl" LabelText="Element to select" IsHidden="True" DisplayMember="Text" ValueMember="Value" /></div>
        <div class="col-6"><con:TextField runat="server" ID="CustomNumberOfDecs" TextMode="Number" IsHidden="True" LabelText="Number of decimals" /></div>
        <div class="col-6"><con:TextField runat="server" ID="CustomCodeType" MaximumLength="5" LabelText="List code" IsHidden="True" /></div>
      </div>
    </con:TabPage>
      
    <con:TabPage runat="server" Title="List Selection" ID="TabUserFieldList">
        <con:DataTable runat="server" ID="TabUserFieldListTable" CanModify="false" CanResize="false" PageSize="10" CanSearch="false" 
                CanCreate="true" CanCreateInEditMode="true" CreateMode="Stateful">
            <Columns> 
                <con:DataTableCustomColumn Title="Code" Width="300px">return consensus.web.customisation.createInputColumn(row, 'IdValue');</con:DataTableCustomColumn>
                <con:DataTableCustomColumn Title="Display text" Width="360px">return consensus.web.customisation.createInputColumn(row, 'Text');</con:DataTableCustomColumn> 
                <con:DataTableButtonColumn runat="server" ID="TabUserFieldListTableButtons" Width="30px"></con:DataTableButtonColumn>
            </Columns>
        </con:DataTable>
    </con:TabPage>

    <%-- General Options --%>

    <con:TabPage runat="server" Title="Options" ID="TabOptions">
      <div class="row">
        <div class="col-6"><con:TextField runat="server" ID="DefaultText" LabelText="Default Text" IsReadOnly="TrueEnforced" /></div>
        <div class="col-6"><con:TextField runat="server" ID="CustomText" LabelText="Custom Text" /></div>
        <div class="col-6"><con:ListField runat="server" ID="Icon" LabelText="Icon"/></div>
        <div class="col-6">
          <con:ListField runat="server" ID="Visibility" LabelText="Display">
            <Items>
              <asp:ListItem Text="Visible" Value="visible" />
              <asp:ListItem Text="Read Only" Value="readonly" />
              <asp:ListItem Text="Hidden" Value="hidden" />
            </Items>
          </con:ListField>
        </div>
        <div class="col-6">
          <con:ListField runat="server" ID="Requirement" LabelText="Required">
            <Items>
              <asp:ListItem Text="Optional" Value="0" />
              <asp:ListItem Text="Recommended" Value="2" />
              <asp:ListItem Text="Mandatory" Value="4" />
            </Items>
          </con:ListField>
        </div>
          <div class="col-6">
              <con:TextField runat="server" ID="MaximumLength" LabelText="Max Length" TextMode="Number">
                  <Validators>
                      <con:Validator runat="server" ClientValidationFunction="validateMaximumLength" Critical="true" ErrorMessage="Please enter a valid number" />
                  </Validators>
              </con:TextField>
          </div>
        <div class="col-3"><con:TextField runat="server" ID="OnText" LabelText="On Text" /></div>
        <div class="col-3">
          <con:ListField runat="server" ID="OnColour" LabelText="On Colour">
            <Items>
              <asp:ListItem Value="default" Text="Grey" />
              <asp:ListItem Value="primary" Text="Blue" />
              <asp:ListItem Value="success" Text="Green" />
              <asp:ListItem Value="warning" Text="Yellow" />
              <asp:ListItem Value="danger" Text="Red" />
            </Items>
          </con:ListField>
        </div>
        <div class="col-3"><con:TextField runat="server" ID="OffText" LabelText="Off Text" /></div>
        <div class="col-3">
          <con:ListField runat="server" ID="OffColour" LabelText="Off Colour">
            <Items>
              <asp:ListItem Value="default" Text="Grey" />
              <asp:ListItem Value="primary" Text="Blue" />
              <asp:ListItem Value="success" Text="Green" />
              <asp:ListItem Value="warning" Text="Yellow" />
              <asp:ListItem Value="danger" Text="Red" />
            </Items>
          </con:ListField>
        </div>
      </div>
    </con:TabPage>
    
    <%-- Validation --%>
    
    <con:TabPage runat="server" Title="Validation" ID="TabValidation">
      <div class="row">
        <div class="col-12">
          <con:ListField runat="server" ID="ExpressionType" LabelText="Type" ClientOnChange="updateValidator();">
            <Items>
              <asp:ListItem Text="(none)"         Value="" />
              <asp:ListItem Text="Date"           Value="^\d{2}\s.*\s\d{4}\s\d{2}:\d{2}:\d{2}$" />
              <asp:ListItem Text="Date and Time"  Value="^\d{2}\s.*\s\d{4}\s\d{2}:\d{2}:\d{2} (?:0?[0-9]|1[0-9]|2[0-3]):[0-5][0-9]$" />
              <asp:ListItem Text="Decimal Number" Value="^-?[0-9]+([.,][0-9]{1,3})?$" />
              <asp:ListItem Text="Email Address"  Value="^(?:[a-zA-Z0-9!#$%&'*+/=?^_`{|}~-]+(?:\.[a-zA-Z0-9!#$%&'*+/=?^_`{|}~-]+)*|&quot;(?:[\x01-\x08\x0b\x0c\x0e-\x1f\x21\x23-\x5b\x5d-\x7f]|\\[\x01-\x09\x0b\x0c\x0e-\x7f])*&quot;)@(?:(?:[a-zA-Z0-9](?:[a-zA-Z0-9-]*[a-zA-Z0-9])?\.)+[a-zA-Z0-9](?:[a-zA-Z0-9-]*[a-zA-Z0-9])?|\[(?:(?:(2(5[0-5]|[0-4][0-9])|1[0-9][0-9]|[1-9]?[0-9]))\.){3}(?:(2(5[0-5]|[0-4][0-9])|1[0-9][0-9]|[1-9]?[0-9])|[a-zA-Z0-9-]*[a-zA-Z0-9]:(?:[\x01-\x08\x0b\x0c\x0e-\x1f\x21-\x5a\x53-\x7f]|\\[\x01-\x09\x0b\x0c\x0e-\x7f])+)\])$" />
              <asp:ListItem Text="NI Number"      Value="^[a-zA-Z]{2}\s*\d{4}\s*\d{2}\s*[a-zA-Z]?$" />
              <asp:ListItem Text="Phone Number"   Value="^(?:(?:\(?(?:00|\+)([1-4]\d\d|[1-9]\d?)\)?)?[\-\.\ \\\/]?)?((?:\(?\d{1,}\)?[\-\.\ \\\/]?){0,})(?:[\-\.\ \\\/]?(?:#|ext\.?|extension|x)[\-\.\ \\\/]?(\d+))?$" />
              <asp:ListItem Text="Time"           Value="^(?:0?[0-9]|1[0-9]|2[0-3]):[0-5][0-9]$" />
              <asp:ListItem Text="Web Address"    Value="^((http|ftp|https|www)://)?([\w+?\.\w+])+([a-zA-Z0-9\~\!\@\#\$\%\^\&\*\(\)_\-\=\+\\\/\?\.\:\;\'\,]*)?$" />
              <asp:ListItem Text="Whole Number"   Value="^-?[0-9]+(,[0-9]{1,3})?$" />
              <asp:ListItem Text="(custom)"       Value="custom" />              
            </Items>
          </con:ListField>
        </div>
      </div>
      <div class="row">
        <div class="col-12"><con:TextField runat="server" ID="ExpressionPattern" LabelText="Pattern" /></div>
      </div>
      <div class="row">
        <div class="col-12">
          <con:ListField runat="server" ID="ExpressionSeverity" LabelText="Severity">
            <Items>
              <asp:ListItem Value="true" Text="Critical" />
              <asp:ListItem Value="false" Text="Warning" />
            </Items>
          </con:ListField>
        </div>
      </div>
      <div class="row">
        <div class="col-12"><con:TextField runat="server" ID="ExpressionMessage" LabelText="Message" /></div>
      </div>
    </con:TabPage>
    
    <%-- Security --%>
    
    <con:TabPage runat="server" Title="Security" ID="TabSecurity">
      <con:DataTable runat="server" ID="SecurityTable" CanCreate="false" CanModify="false" CanExport="false" CanPrint="false" CanResize="false" CanSearch="false" PageSize="10" Mode="Stateful">
        <Columns>
          <con:DataTableTextColumn Title="User Group" FieldName="PrincipalName" />
          <con:DataTableCustomColumn Title="Display" Width="160px">return consensus.web.customisation.createSecurityColumn(row);</con:DataTableCustomColumn>
        </Columns>
      </con:DataTable>
    </con:TabPage>
    
    <%-- Dropdown List --%>
    
    <con:TabPage runat="server" Title="Dropdown" ID="TabDropdown">
      <con:DataTable runat="server" ID="DropdownTable" CanCreate="false" CanModify="false" CanExport="false" CanPrint="false" CanResize="false" CanSearch="false" PageSize="10" Mode="Stateful">
        <Columns>
          <con:DataTableCustomColumn Title="Show" Width="40px">return consensus.web.customisation.createCheckColumn(row, 'Displayed');</con:DataTableCustomColumn>
          <con:DataTableTextColumn Title="Default Text" FieldName="DefaultText"  />
          <con:DataTableCustomColumn Title="Custom Text">return consensus.web.customisation.createInputColumn(row, 'CustomText');</con:DataTableCustomColumn>
        </Columns>
      </con:DataTable>
    </con:TabPage>
    
    <%-- Code List --%>
    
    <con:TabPage runat="server" Title="Codes" ID="TabCodes">
      <con:DataTable runat="server" ID="CodeTable" Url="~/GenericPopup.aspx?width=500&context=common&control=codedetail&id={{Id}}" Mode="RealTime" CanSearch="false" PageSize="10" >
        <Columns>
          <con:DataTableTextColumn Title="Level 1" FieldName="Value1" />
          <con:DataTableTextColumn Title="Level 2" FieldName="Value2" />
          <con:DataTableTextColumn Title="Level 3" FieldName="Value4" />
        </Columns>
      </con:DataTable>
    </con:TabPage>
    
    <%-- Table Columns --%>
    
    <con:TabPage runat="server" Title="Columns" ID="TabColumns">
      <con:DataTable runat="server" ID="ColumnTable" CanCreate="false" CanModify="false" CanExport="false" CanPrint="false" CanResize="false" CanSearch="false" PageSize="10" Mode="Stateful">
        <Columns>
          <con:DataTableTextColumn Title="Default Text" FieldName="DefaultTitle" />
          <con:DataTableCustomColumn Title="Custom Text">return consensus.web.customisation.createInputColumn(row, 'CustomTitle');</con:DataTableCustomColumn>
          <con:DataTableCustomColumn Title="Exportable">return consensus.web.customisation.createCheckColumn(row, 'Exportable');</con:DataTableCustomColumn>
          <con:DataTableCustomColumn Title="Visible">return consensus.web.customisation.createCheckColumn(row, 'Visible');</con:DataTableCustomColumn>
        </Columns>
      </con:DataTable>
    </con:TabPage>
  </Pages>
</con:TabControl>

<script>

    var tabControl = $('#<%= this.TabControl.ClientID %>');
    var _data = null;

    // Hides or shows a field based upon the capabilities of the control
    function toggleField(data, field) {
        var isCapable = false;
        for (var i = 2; i < arguments.length; i++)
            if (consensus.web.customisation.isCapable(data, arguments[i]) && !(arguments[i] == 'IHaveCustomTitle' && consensus.web.customisation.isCapable(data, "IsCustomField")))
                isCapable = true;
        $('#' + field).parent().toggle(isCapable);
    }

    // Hides or shows a tab based upon the capabilities of the control
    function toggleTab(data, page) {
        var isCapable = false;
        for (var i = 2; i < arguments.length; i++)
            if (consensus.web.customisation.isCapable(data, arguments[i]))
                isCapable = true;
        tabControl.find('ul.nav-tabs li.nav-item a[href="#' + page + '"]').parents('li').toggle(isCapable);
        // If we are hiding the user fields tab, then "click" on the options tab (we've hidden the default tab).
        if (!isCapable && page == "<%=TabUserFields.ClientID%>") {
            $('#<%=TabControl.ClientID%> a[href="#<%=TabOptions.ClientID%>"]').tab('show');
        }
    }

    // Disables a dropdown based on enforced values
    function toggleSelect(data, select, capability, configuration) {
        if (consensus.web.customisation.isCapable(data, capability)) {
            var match = false;
            var field = $('#' + select + 'Field')
            for (var i = 4; i < arguments.length; i++)
                if ((data.Configuration[configuration].ConfiguredValue || data.Configuration[configuration].DefaultValue) == arguments[i])
                    match = true;
            if (!field.is(':disabled') && match)
                field.attr('readonly', 'readonly').attr('disabled', 'disabled');
        }
    }

    // Removes an option from a dropdown based upon the capabilities of the control
    function toggleOption(data, select, option, capability) {
        if (!consensus.web.customisation.isCapable(data, capability))
            $('#' + select + 'Field').find('option[value="' + option + '"]').remove();
    }

    // Updates the field to the currently configured value
    function applyValue(data, field, capability, configuration, property) {
        if (consensus.web.customisation.isCapable(data, capability)) {
            var value = property ? data.Configuration[configuration][property] : data.Configuration[configuration].ConfiguredValue || data.Configuration[configuration].DefaultValue;
            $('#' + field + 'Field').val(typeof (value) == 'undefined' || value == null ? '' : value.toString());
        }
    }

    // Updates the dropdown to the currently configured value
    function applyDropdown(data, field, capability, configuration, value) {
        if (consensus.web.customisation.isCapable(data, capability)) {
            var match = false;
            for (var i = 5; i < arguments.length; i++)
                if ((data.Configuration[configuration].ConfiguredValue || data.Configuration[configuration].DefaultValue) == arguments[i])
                    match = true;
            if (match)
                $('#' + field + 'Field').val(value);
        }
    }

    var beforeSave = function (state, callback) {
        state.data = _data;
        state.updateObject = function () { updateObject(state.data); };
        state.createObject = function () { return state.data; };
        callback();
    }

    // Updates the objects with the values from the dialog
    function updateObject(object, updateWhenDisabled, capability, configuration, field) {
        if (arguments.length == 1) {
            updateObject(object, false, 'ICanBeHidden', 'IsHidden', '<%= this.Visibility.ClientID %>', 'hidden');
            updateObject(object, false, 'ICanBeReadOnly', 'IsReadOnly', '<%= this.Visibility.ClientID %>', 'readonly');
            updateObject(object, false, 'ICanBeMandatory', 'Requirement', '<%= this.Requirement.ClientID %>');
            updateObject(object, false, 'IHaveCustomTitle', 'Title', '<%= this.CustomText.ClientID %>');
            updateObject(object, false, 'IHaveCustomIcon', 'Icon', '<%= this.Icon.ClientID %>');
            updateObject(object, false, 'IHaveMaxLength', 'MaximumLength', '<%= this.MaximumLength.ClientID %>');
            updateObject(object, false, 'ICanBeSwitched', 'OnText', '<%= this.OnText.ClientID %>');
            updateObject(object, false, 'ICanBeSwitched', 'OnColour', '<%= this.OnColour.ClientID %>');
            updateObject(object, false, 'ICanBeSwitched', 'OffText', '<%= this.OffText.ClientID %>');
            updateObject(object, false, 'ICanBeSwitched', 'OffColour', '<%= this.OffColour.ClientID %>');
            updateObject(object, true, 'ICanBeValidated', 'ValidatorExpression', '<%= this.ExpressionPattern.ClientID %>');
            updateObject(object, true, 'ICanBeValidated', 'ValidatorCritical', '<%= this.ExpressionSeverity.ClientID %>');
            updateObject(object, true, 'ICanBeValidated', 'ValidatorMessage', '<%= this.ExpressionMessage.ClientID %>');
            // Save custom field settings, if required.
            if (consensus.web.customisation.isCapable(object, "IsCustomField")) {
                object.customField = object.customField || {};
                object.customField.Name = $('#<%= this.CustomFieldName.ClientID %>Field').val();
                object.customField.Label = $('#<%= this.CustomFieldLabel.ClientID %>Field').val();
                var $CustomFieldType = $('#<%= this.CustomFieldType.ClientID %>Field');
                object.customField.CftypeId = $CustomFieldType.val();
                object.customField.ParentControl = $('#<%= this.CustomFieldParentControl.ClientID %>Field').val();
                object.customField.PopupUrl = $('#<%= this.CustomPopupUrl.ClientID %>Field').val();
                object.customField.Decimals = $('#<%= this.CustomNumberOfDecs.ClientID %>Field').val();

                object.Configuration['Title'].DefaultValue = object.customField.Label;
                object.ControlText = object.customField.Label;
                var iTypeIx = $CustomFieldType.prop("selectedIndex");
                if (iTypeIx >= 0) {
                    object.ControlType = $CustomFieldType.children().eq(iTypeIx).text();
                }
                // TODO: CustomCodeType
            }
        } else if (arguments.length == 5) {
            if (consensus.web.customisation.isCapable(object, capability)) {
                var fieldParent = $('#' + field).parent();
                var fieldObject = $('#' + field + 'Field');
                if (fieldParent.css('display') != 'none' && (!fieldObject.is(':disabled') || updateWhenDisabled))
                    object.Configuration[configuration].ConfiguredValue = fieldObject.val();
            }
        }
        else {
            if (consensus.web.customisation.isCapable(object, capability)) {
                var fieldParent = $('#' + field).parent();
                var fieldObject = $('#' + field + 'Field');
                if (fieldParent.css('display') != 'none' && (!fieldObject.is(':disabled') || updateWhenDisabled))
                    for (var i = 5; i < arguments.length; i++)
                        if (fieldObject.val() == arguments[i])
                            object.Configuration[configuration].ConfiguredValue = 'true';
            }
        }
    }

    // Prepopulates the code list with entries from the code table
    function initialiseCodeList(codeType) {
        var table = window['<%= this.CodeTable.ClientID %>'];
        table._createJson = { uri: 'common/code', Type: codeType };
        table.reload = function () {
            consensus.network.send({
                url: 'common/code/fetchAllByType',
                method: 'post',
                data: { codeType: codeType },
                success: function (result) {
                    table._setSourceData(result);
                    table._reload(result);
                    var wrapper = $('#' + table._tableElement.attr('id') + '_wrapper');
                    wrapper.find('.consensus-visible-read').removeClass('consensus-visible-read');
                }
            });
        }
        table.remove = function (row) {
            //swal({ title: 'Are you sure?', text: 'Are you sure you want to delete this record?', type: 'warning', showCancelButton: true, confirmButtonText: 'Yes', cancelButtonText: 'No', confirmButtonClass: 'btn btn-danger', cancelButtonClass: 'btn btn-default', buttonsStyling: false }).then(function () {
                consensus.network.send({
                    method: 'delete',
                    //url: table._tableElement.dataTable().api().row($(row).parents('tr').first()).data().uri,
                    url: row.uri,
                    success: function (result) {
                        table.reload();
                    },
                    error: function(response)
                    { console.log(response);}
                });
            //});
        }
        table.reload();
    }

    // Updates the validation readonly state and pattern when the validation type dropdown is changed.
    function updateValidator() {
        if ($('#<%= this.ExpressionType.ClientID %>Field').val() == null)
            $('#<%= this.ExpressionType.ClientID %>Field').val('custom');
        $('#<%= this.ExpressionPattern.ClientID %>Field').attr('disabled', $('#<%= this.ExpressionType.ClientID %>Field').val() == 'custom' ? null : 'disabled');
        $('#<%= this.ExpressionSeverity.ClientID %>Field').attr('disabled', $('#<%= this.ExpressionType.ClientID %>Field').val() != '' ? null : 'disabled');
        $('#<%= this.ExpressionMessage.ClientID %>Field').attr('disabled', $('#<%= this.ExpressionType.ClientID %>Field').val() != '' ? null : 'disabled');
        if ($('#<%= this.ExpressionType.ClientID %>Field').val() != 'custom')
            $('#<%= this.ExpressionPattern.ClientID %>Field').val($('#<%= this.ExpressionType.ClientID %>Field').val());
        if ($('#<%= this.ExpressionType.ClientID %>Field').val() == '') {
            $('#<%= this.ExpressionPattern.ClientID %>Field').val('');
            $('#<%= this.ExpressionMessage.ClientID %>Field').val('');
        }
    }

    var initialised = false;

    function initPopup() {
        // If InitialiseDialog has not been called then assume we are inserting a new custom field. Create a framework data object and initialise.
        if (!initialised) {
            var newObj = {
                Capabilities: ["ICanBeMandatory", "ICanBeHidden", "ICanBeReadOnly", "IHaveMaxLength", "ICanBeValidated", "IsCustomField", "IHaveCustomTitle"],
                ClientId: "",
                Configuration: {
                    CustomFieldId: { ConfiguredValue: null, DefaultValue: 1},
                    IsCustomField: {DefaultValue: true, ConfiguredValue: null},
                    IsHidden: {DefaultValue: "false", ConfiguredValue: "false"},
                    IsReadOnly: {DefaultValue: "false", ConfiguredValue: "false"},
                    MaximumLength: {DefaultValue: 0, ConfiguredValue: 0},
                    Requirement: {DefaultValue: "0", ConfiguredValue: "0"},
                    Security: <%= getSecurityJSON() %>,
                    Title: {DefaultValue: "", ConfiguredValue: null},
                    ValidatorCritical: {DefaultValue: "false", ConfiguredValue: "false"},
                    ValidatorExpression: {DefaultValue: "", ConfiguredValue: null},
                    ValidatorMessage: {DefaultValue: "", ConfiguredValue: null}
                },
                ControlId: "",
                ControlName: "",
                ControlText: "",
                ControlType: "",
                ScreenObject: {
                    uri:"UserInterface/ScreenObject",
                },
                customField: {
                    uri: "UserInterface/ScreenCustomField",
                    CustomFieldListItems: []
                }
            };

            var state = consensus.data.getState();
            state.object = newObj;

            initialiseDialog(newObj);
        }
    }

    // Initialises the dialog with the data provided
    function initialiseDialog(data) {
        try
        {
            initialised = true;
            _data = data;

            // Hide or show the customisation options, depending upon the capabilities of the control
            toggleField(data, '<%= this.DefaultText.ClientID %>', 'IHaveCustomTitle');
            toggleField(data, '<%= this.CustomText.ClientID %>', 'IHaveCustomTitle');
            toggleField(data, '<%= this.Icon.ClientID %>', 'IHaveCustomIcon');
            toggleField(data, '<%= this.Visibility.ClientID %>', 'ICanBeReadOnly', 'ICanBeHidden');
            toggleField(data, '<%= this.Requirement.ClientID %>', 'ICanBeMandatory');
            toggleField(data, '<%= this.MaximumLength.ClientID %>', 'IHaveMaxLength');
            toggleField(data, '<%= this.OnText.ClientID %>', 'ICanBeSwitched');
            toggleField(data, '<%= this.OnColour.ClientID %>', 'ICanBeSwitched');
            toggleField(data, '<%= this.OffText.ClientID %>', 'ICanBeSwitched');
            toggleField(data, '<%= this.OffColour.ClientID %>', 'ICanBeSwitched');

            // Hide or show tabs, depending upon the capabilities of the control
            if (data.customField) {
                data.Capabilities.push("IsCustomField");
            }
            toggleTab(data, '<%= this.TabUserFields.ClientID %>', 'IsCustomField');
            toggleTab(data, '<%= this.TabValidation.ClientID %>', 'ICanBeValidated');
            toggleTab(data, '<%= this.TabSecurity.ClientID %>', 'ICanBeReadOnly', 'ICanBeHidden');
            toggleTab(data, '<%= this.TabDropdown.ClientID %>', 'IHaveListItems');
            toggleTab(data, '<%= this.TabCodes.ClientID %>', 'IHaveCodeItems');
            toggleTab(data, '<%= this.TabColumns.ClientID %>', 'IHaveColumns');
            toggleTab(data, '<%= this.TabUserFieldList.ClientID %>', 'IsCustomField');

            // Remove options that cannot be chosen
            toggleOption(data, '<%= this.Visibility.ClientID %>', 'hidden', 'ICanBeHidden');
            toggleOption(data, '<%= this.Visibility.ClientID %>', 'readonly', 'ICanBeReadOnly');
            toggleSelect(data, '<%= this.Visibility.ClientID %>', 'ICanBeReadOnly', 'IsReadOnly', 'trueenforced', 'falseenforced');
            toggleSelect(data, '<%= this.Visibility.ClientID %>', 'ICanBeHidden', 'IsHidden', 'trueenforced', 'falseenforced');
            toggleSelect(data, '<%= this.Requirement.ClientID %>', 'ICanBeMandatory', 'Requirement', 1, 3, 5);

            // Update the customisation options with the currently selected values
            applyDropdown(data, '<%= this.Visibility.ClientID %>', 'ICanBeHidden', 'IsHidden', 'hidden', 'true', 'trueenforced');
            applyDropdown(data, '<%= this.Visibility.ClientID %>', 'ICanBeReadOnly', 'IsReadOnly', 'readonly', 'true', 'trueenforced');
            applyDropdown(data, '<%= this.Requirement.ClientID %>', 'ICanBeMandatory', 'Requirement', '0', 0, 1);
            applyDropdown(data, '<%= this.Requirement.ClientID %>', 'ICanBeMandatory', 'Requirement', '2', 2, 3);
            applyDropdown(data, '<%= this.Requirement.ClientID %>', 'ICanBeMandatory', 'Requirement', '4', 4, 5);
            applyValue(data, '<%= this.DefaultText.ClientID %>', 'IHaveCustomTitle', 'Title', 'DefaultValue');
            applyValue(data, '<%= this.CustomText.ClientID %>', 'IHaveCustomTitle', 'Title', 'ConfiguredValue');
            applyValue(data, '<%= this.Icon.ClientID %>', 'IHaveCustomIcon', 'Icon');
            applyValue(data, '<%= this.MaximumLength.ClientID %>', 'IHaveMaxLength', 'MaximumLength');
            applyValue(data, '<%= this.OnText.ClientID %>', 'ICanBeSwitched', 'OnText');
            applyValue(data, '<%= this.OnColour.ClientID %>', 'ICanBeSwitched', 'OnColour');
            applyValue(data, '<%= this.OffText.ClientID %>', 'ICanBeSwitched', 'OffText');
            applyValue(data, '<%= this.OffColour.ClientID %>', 'ICanBeSwitched', 'OffColour');
            applyValue(data, '<%= this.ExpressionType.ClientID %>', 'ICanBeValidated', 'ValidatorExpression');
            applyValue(data, '<%= this.ExpressionPattern.ClientID %>', 'ICanBeValidated', 'ValidatorExpression');
            applyValue(data, '<%= this.ExpressionSeverity.ClientID %>', 'ICanBeValidated', 'ValidatorCritical');
            applyValue(data, '<%= this.ExpressionMessage.ClientID %>', 'ICanBeValidated', 'ValidatorMessage');

            if (consensus.web.customisation.isCapable(data, 'IsCustomField')) {
                initialiseCustomField(data);
            }

            if (consensus.web.customisation.isCapable(data, 'ICanBeValidated'))
                if ((data.Configuration.ValidatorExpression.ConfiguredValue || data.Configuration.ValidatorExpression.DefaultValue) && (data.Configuration.ValidatorExpression.ConfiguredValue || data.Configuration.ValidatorExpression.DefaultValue).length != 0)
                    if ($('#<%= this.ExpressionType.ClientID %>Field').val() == '')
                        $('#<%= this.ExpressionType.ClientID %>Field').val('custom');

            // Ensure that the code list table is updated using the Code.FetchAllByType RESTful method
            if (consensus.web.customisation.isCapable(data, 'IHaveCodeItems'))
                initialiseCodeList(data.Configuration.CodeType);
            if (consensus.web.customisation.isCapable(data, 'IHaveListItems'))
                window['<%= this.DropdownTable.ClientID %>']._reload(data.Configuration.Items);
            if (consensus.web.customisation.isCapable(data, 'IHaveColumns'))
                window['<%= this.ColumnTable.ClientID %>']._reload(data.Configuration.Columns);
            if ((consensus.web.customisation.isCapable(data, 'ICanBeReadOnly') && (data.Configuration.IsReadOnly.ConfiguredValue || data.Configuration.IsReadOnly.DefaultValue) != 'trueenforced' && (data.Configuration.IsReadOnly.ConfiguredValue || data.Configuration.IsReadOnly.DefaultValue) != 'falseenforced') || (consensus.web.customisation.isCapable(data, 'ICanBeHidden') && (data.Configuration.IsHidden.ConfiguredValue || data.Configuration.IsHidden.DefaultValue) != 'trueenforced' && (data.Configuration.IsHidden.ConfiguredValue || data.Configuration.IsHidden.DefaultValue) != 'falseenforced')) {
                for (var i = 0 ; i < data.Configuration.Security.length; i++)
                    data.Configuration.Security[i].parent = data;
                window['<%= this.SecurityTable.ClientID %>']._reload(data.Configuration.Security);
            }

            // Toggle the validation fields
            updateValidator();
        }
        catch (e) {
            alert("Initialisation error: " + e.message);
        }
    }

    function initialiseCustomField(data) {
        $('#<%= this.CustomFieldName.ClientID %>Field').val(data.customField.Name);
        $('#<%= this.CustomFieldLabel.ClientID %>Field').val(data.customField.Label);
        $('#<%= this.CustomFieldType.ClientID %>Field')
            .val(data.customField.CftypeId)
            .on("change", function (e) {
                showHideCustomFields();
            });

        var state = consensus.data.getState();
        var parentList = state.parentScope.consensus.web.dataTable.all[0];
        var listData = parentList._tableElement.dataTable().DataTable().data();

        var containers = $.grep(listData, function (item, iX) {
            return ($.inArray("ICustomFieldContainer", item.Capabilities) >= 0);
        });
        var containerList = $('#<%= this.CustomFieldParentControl.ClientID %>Field');
        $.each(containers, function (iX, container) {
            var title = container.Configuration.Title ? (container.Configuration.Title.ConfiguredValue || container.Configuration.Title.DefaultValue) : "";
            var typeDesc = consensus.web.customisation.createTypeColumn(container); // Resolves container.ControlType to a user freindly description.
            var option = $("<option>")
                .attr("value", container.ClientId)
                .text((typeDesc ? typeDesc + ": " : "") + (title || container.ControlText));
            if (container.ClientId == data.customField.ParentControl)
                option.attr("selected", "selected");
            containerList.append(option);
        });

        $('#<%= this.CustomNumberOfDecs.ClientID %>Field').val(data.customField.Decimals);
        $('#<%= this.CustomPopupUrl.ClientID %>Field').val(data.customField.PopupUrl);

        var fieldListTable = window['<%= this.TabUserFieldListTable.ClientID %>'];
        fieldListTable._reload(data.customField.CustomFieldListItems); 
        // Set it up to create a new row when you tab off the last field on the last row. 
        // Don't know what is setting tabindex=0 on the first cell of each row? It's not useful here, but
        // can't seem to turn it off. I think it's being set later...
        //fieldListTable._tableElement.find("td[tabIndex]").removeAttr("tabindex"); //.prop("tabIndex", -1); 
        fieldListTable._tableElement.on("keydown", function(event) {
            if (event.which == 9 && !event.shiftKey) { // tab key
                var $lastInput = fieldListTable._tableElement
                    .children("tbody")
                    .children("tr")
                    .last()
                    .children("td:has(input:enabled):visible")
                    .last()
                    .find("input:enabled");

                if ($lastInput.length > 0 && $lastInput[0] == event.target)
                {
                    fieldListTable.create();
                    event.stopImmediatePropagation();
                    event.preventDefault();
                }
            }
        });

        showHideCustomFields();
    }

    function showHideCustomFields()
    {
        var $typeField = $('#<%= this.CustomFieldType.ClientID %>Field');
        var selectedIx = $typeField.prop("selectedIndex");
        var selectedType = (selectedIx >= 0) ? $typeField.prop("options")[selectedIx].value : "";
        showHideField($('#<%= this.CustomNumberOfDecs.ClientID %>'), selectedType == "Number");
        showHideField($('#<%= this.CustomPopupUrl.ClientID %>'), selectedType == "PopupSearch");
        showHideTab('<%= this.TabUserFieldList.ClientID %>', selectedType == "List");
        //$('#<%= this.CustomCodeType.ClientID %>').toggle(selectedType == "Code"); //TODO...
        
    }

    function deleteRow(row) {
        window['<%= this.TabUserFieldListTable.ClientID %>'].markToDelete(row);
    }

    function showHideField($field, show) {        
        if (show) {
            $field.removeAttr("hidden").css("display", "");
        }
        else {
            $field.attr("hidden", "hidden").css("display", "inline");
        }
    }
    
    function showHideTab(tab, show) {        
        var $tabLi = tabControl.find('ul.nav-tabs li.nav-item a[href="#' + tab + '"]').parents('li');
        $tabLi.toggle(show);
    }

    function validateMaximumLength(source, arguments) {
        var maxLength = arguments.Value;
        arguments.IsValid = (maxLength == '' || (!isNaN(maxLength) && maxLength >= 0));
    }

    $(function () {
        $('[id$=_CodeTable]').on('draw.dt', function () {
            var table = window['<%= this.CodeTable.ClientID %>'];
            var wrapper = $('#' + table._tableElement.attr('id') + '_wrapper');
            wrapper.find('.consensus-visible-read').removeClass('consensus-visible-read');
        }).dataTable();
    });

</script>