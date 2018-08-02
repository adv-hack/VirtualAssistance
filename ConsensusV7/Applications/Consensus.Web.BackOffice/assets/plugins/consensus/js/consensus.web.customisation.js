var consensus = consensus || {};
consensus.web = consensus.web || {};

consensus.web.customisation = new function () {
    var closure = this;
    this.data = [];
    this.url = '';
    this.page = '';
    this.tableName = '';
    this.blockCustomFields = false;
    this._rootScope = window;
    this.popup = function () {

        consensus.web.popupFrame({
            url: consensus.resolveUrl('~/genericpopup.aspx?context=common&control=customisationlist&buttons=5&width=1200&bcf=' + (closure.blockCustomFields ? 1 : 0)),
            open: function () {
                var closeBtn = $(this.document).find('.btn.btn-primary');
                var tableObj = this.window.consensus.web.dataTable.all[0];
                var stateObj = new consensus.data.state(closeBtn, {}, this, closure._rootScope);
                this.consensus.data.setState(stateObj);
                if (!closure.blockCustomFields)
                    consensus.web.customisation.mergeCustomFieldData(consensus.web.customisation.data, consensus.web.customisation.customFields);
                if (tableObj) {
                    tableObj._sourceData = consensus.web.customisation.data;
                    tableObj._sourceType = "object";
                    tableObj._reload(consensus.web.customisation.data);
                }
            },
            title: 'Customise this page',
            result: this.save,
            canDrag: true,
            canMove: true
        });
    };
    this.save = function (data) {

        for (var x = 0; x < consensus.web.customisation.data.length; x++) {
            var customisationRow = consensus.web.customisation.data[x];
            // Remove parental references
            if (customisationRow.Configuration.Security) {
                for (var y = 0; y < customisationRow.Configuration.Security.length; y++) {
                    delete customisationRow.Configuration.Security[y].parent;
                }
            }
            if (!customisationRow.Url) {
                customisationRow.Url = consensus.web.customisation.url;
            }
        }

        var customFields = [];
        if (!closure.blockCustomFields) {
            $.each(consensus.web.customisation.data, function (ix, item) {
                if (item.customField) {
                    item.customField.Page = consensus.web.customisation.page;
                    item.customField.Url = consensus.web.customisation.dataurl;
                    item.customField.Table = consensus.web.customisation.tableName;

                    if (item.DeleteMe == 1)
                        item.customField.DeleteMe = 1;

                    customFields.push(item.customField);
                }
            });
        }
        var fSaveCustomisations = function () {
            // Submit customisations to the server
            consensus.network.send({
                url: 'userinterface/screenobject/update',  // Note: LocalScreenObjectFactory has an Update method that takes a url and an array of customisations.
                method: 'post',
                data: {
                    url: consensus.web.customisation.url,
                    controls: consensus.web.customisation.data
                },
                success: function () {
                    window.location.href = window.location.href;
                }
            });
        };

        if (customFields.length > 0) {
            consensus.network.send({
                url: 'userinterface/screencustomfield/update',
                method: 'post',
                data: {
                    //url: consensus.web.customisation.url,
                    customFields: customFields
                },
                success: function () {
                    fSaveCustomisations();
                }
            });
        }
        else {
            fSaveCustomisations();
        }

        
    };
    this.showDialog = function (source) {
        var row = $(source).parents('tr').first();
        var obj = window.consensus.web.dataTable.all[0]._tableElement.dataTable().api().row(row).data();
        var title = obj.ControlType;
        //var updateObject;
        var buttons = 7;
        var _listScope = window;

        if (this.isCapable(obj, 'IsCustomField')) {
            title = "user defined field";
            buttons += 8; // Include the delete button
        }
        else {
            switch (obj.ControlType) {
                case 'TabPage': title = 'tab'; break;
                case 'TabList': title = 'list'; break;
                case 'GroupBox': title = 'section'; break;
                case 'TextField': title = 'text field'; break;
                case 'ListField': title = 'dropdown'; break;
                case 'CodeField': title = 'dropdown'; break;
                case 'PopupField': title = 'search field'; break;
                case 'DateField': title = 'date field'; break;
                case 'CheckField': title = 'switch'; break;
            }
        }
        consensus.web.popupFrame({
            url: consensus.resolveUrl('~/genericpopup.aspx?context=common&control=customisationdetail&buttons=' + buttons + '&width=900'),
            open: function () {
                var closeBtn = $(this.document).find('.btn.btn-primary');
                var stateObj = new consensus.data.state(closeBtn, obj, this, _listScope);
                this.consensus.data.setState(stateObj);
                if ($.isFunction(this.initialiseDialog))
                    this.initialiseDialog(obj);
                //updateObject = this.updateObject;
            },
            title: 'Customise this ' + title,
            result: function (data) {
                //updateObject(obj);

                var pageNumber = window.consensus.web.dataTable.all[0]._tableElement.dataTable().api().page();
                var customisedData = window.consensus.web.dataTable.all[0]._tableElement.dataTable().DataTable().data();
                window.consensus.web.dataTable.all[0]._reload(customisedData);
                window.consensus.web.dataTable.all[0]._tableElement.dataTable().api().page(pageNumber).draw(false);
            },
            canDrag: true,
            canMove: true
        });
    }
    //this.getCreatedData = function (data) {
    //    updateObject(data);
    //};
    this.isCapable = function (data, capability) {
        return data.Capabilities.indexOf(capability) != -1;
    };
    this.createBasicColumn = function (data, property /* plus a number of capabilities... */) {
        var result = '';
        if (arguments.length > 2) {
            var isCapable = false;
            for (var i = 2; i < arguments.length; i++) {                     
                isCapable = consensus.web.customisation.isCapable(data, arguments[i]);
                if (isCapable)
                    break;
            }
            if (isCapable) {
                var input = $('<span />').text(data.Configuration[property].DefaultValue);
                result = $('<div />').append(input).html();
            }
        } else {
            var input = $('<span />').text(data[property]);
            result = $('<div />').append(input).html();
        }
        return result;
    };
    this.createInputColumn = function (data, property, capability) {
        var result = '';
        if (capability) {
            if (consensus.web.customisation.isCapable(data, capability) && !(capability == 'IHaveCustomTitle' && consensus.web.customisation.isCapable(data, 'IsCustomField'))) {
                var input = $('<input />').addClass('form-control').attr('type', 'text').attr('value', data.Configuration[property].ConfiguredValue).attr('onchange', 'consensus.web.customisation.updateInputColumn(this);').attr('onchange-target', property).attr('onchange-type', 'configuration');
                result = $('<div />').append(input).html();
            }
        } else {
            var input = $('<input />').addClass('form-control').attr('type', 'text').attr('value', data[property]).attr('onchange', 'consensus.web.customisation.updateInputColumn(this);').attr('onchange-target', property).attr('onchange-type', 'property');
            result = $('<div />').append(input).html();
        }
        return result;
    };
//    this.createRequiredInputColumn = function (data, property, capability) {
//        var result = '';
//        /*
//         <span id="n" class="consensus-input">
//            <div id="nGroup" class="input-group">
//                <input name="nnField" id="nField" class="form-control" ...>
//            </div>
//            <small id="nError">
//                <span id="Content_Content_Content_TopContent_PromotionMasterDetail_ctl53" class="consensus-validator text-danger" data-validation-critical="yes" style="display: none;">
//                    This is a required field
//                </span>
//            </small>
//        </span>
        
//var Content_Content_Content_TopContent_PromotionMasterDetail_ctl53 = document.all ? document.all["Content_Content_Content_TopContent_PromotionMasterDetail_ctl53"] : document.getElementById("Content_Content_Content_TopContent_PromotionMasterDetail_ctl53");
//Content_Content_Content_TopContent_PromotionMasterDetail_ctl53.controltovalidate = "Content_Content_Content_TopContent_PromotionMasterDetail_TypeField";
//Content_Content_Content_TopContent_PromotionMasterDetail_ctl53.errormessage = "This is a required field";
//Content_Content_Content_TopContent_PromotionMasterDetail_ctl53.display = "Dynamic";
//Content_Content_Content_TopContent_PromotionMasterDetail_ctl53.validationGroup = "Content_Content_Content_TopContent_PromotionMasterDetail_Type";
//Content_Content_Content_TopContent_PromotionMasterDetail_ctl53.evaluationfunction = "RequiredFieldValidatorEvaluateIsValid";
//Content_Content_Content_TopContent_PromotionMasterDetail_ctl53.initialvalue = "";

//var Page_Validators =  new Array(document.getElementById("Content_Content_Content_TopContent_PromotionMasterDetail_ctl53"), ...);

//can't see this working. Abandoning for now...
//         */
//        if (capability) {
//            if (consensus.web.customisation.isCapable(data, capability) && !(capability == 'IHaveCustomTitle' && consensus.web.customisation.isCapable(data, 'IsCustomField'))) {
//                var input = $('<input />').addClass('form-control').attr('type', 'text').attr('value', data.Configuration[property].ConfiguredValue).attr('onchange', 'consensus.web.customisation.updateInputColumn(this);').attr('onchange-target', property).attr('onchange-type', 'configuration');
//            }
//        } else {
//            var input = $('<input />').addClass('form-control').attr('type', 'text').attr('value', data[property]).attr('onchange', 'consensus.web.customisation.updateInputColumn(this);').attr('onchange-target', property).attr('onchange-type', 'property');
//        }
//        result = $('<span />').addClass("consensus-input");


//            .append(input).html();
//        return result;
//    };
    this.createCheckColumn = function (data, property, capability) {
        var input = null;
        var label = null;
        var result = '';
        var elemId = 'check_' + consensus.data.guid();
        if (typeof (capability) == 'undefined')
            input = $('<input />').attr('checked', data[property] === true ? 'checked' : null).attr('onchange-type', 'property');
        else if (consensus.web.customisation.isCapable(data, capability))
            input = $('<input />').attr('checked', data.Configuration[property].ConfiguredValue === true ? 'checked' : null).attr('onchange-type', 'configuration');
        if (input) {
            input.attr('id', elemId).addClass('stylised').attr('type', 'checkbox').attr('onchange', 'consensus.web.customisation.updateCheckColumn(this);').attr('onchange-target', property);
            label = $('<label />').attr('for', elemId);
            result = $('<div />').append(input).append(label).html();
        }
        return result;
    };
    this.createVisibleColumn = function (data) {
        var result = '';
        if (consensus.web.customisation.isCapable(data, 'ICanBeReadOnly') || consensus.web.customisation.isCapable(data, 'ICanBeHidden')) {
            var input = $('<select />').addClass('form-control').attr('onchange', 'consensus.web.customisation.updateVisibleColumn(this);');
            if (!consensus.web.customisation.isCapable(data, 'ICanBeReadOnly') || data.Configuration.IsReadOnly.DefaultValue == 'false' || data.Configuration.IsReadOnly.DefaultValue == 'falseenforced')
                $('<option />').attr('value', 'visible').text('Visible').appendTo(input);
            if (consensus.web.customisation.isCapable(data, 'ICanBeReadOnly')) {
                $('<option />').attr('value', 'readonly').text('Read Only').attr('selected', (data.Configuration.IsReadOnly.ConfiguredValue || data.Configuration.IsReadOnly.DefaultValue) == 'true' || (data.Configuration.IsReadOnly.ConfiguredValue || data.Configuration.IsReadOnly.DefaultValue) == 'trueenforced' ? 'selected' : null).appendTo(input);
                input.attr('disabled', (data.Configuration.IsReadOnly.ConfiguredValue || data.Configuration.IsReadOnly.DefaultValue) == 'trueenforced' ? 'disabled' : input.attr('disabled'));
            }
            if (consensus.web.customisation.isCapable(data, 'ICanBeHidden')) {
                $('<option />').attr('value', 'hidden').text('Hidden').attr('selected', (data.Configuration.IsHidden.ConfiguredValue || data.Configuration.IsHidden.DefaultValue) == 'true' || (data.Configuration.IsHidden.ConfiguredValue || data.Configuration.IsHidden.DefaultValue) == 'trueenforced' ? 'selected' : null).appendTo(input);
                input.attr('disabled', (data.Configuration.IsHidden.ConfiguredValue || data.Configuration.IsHidden.DefaultValue) == 'trueenforced' ? 'disabled' : input.attr('disabled'));
            }
            result = $('<div />').append(input).html();
        }
        return result;
    };
    this.createMandatoryColumn = function (data) {
        var result = '';
        if (consensus.web.customisation.isCapable(data, 'ICanBeMandatory')) {
            var input = $('<select />').addClass('form-control').attr('onchange', 'consensus.web.customisation.updateMandatoryColumn(this);');
            $('<option />').attr('value', '0').text('Optional').attr('selected', (data.Configuration.Requirement.ConfiguredValue || data.Configuration.Requirement.DefaultValue) == 0 || (data.Configuration.Requirement.ConfiguredValue || data.Configuration.Requirement.DefaultValue) == 1 ? 'selected' : null).appendTo(input);
            $('<option />').attr('value', '2').text('Recommended').attr('selected', (data.Configuration.Requirement.ConfiguredValue || data.Configuration.Requirement.DefaultValue) == 2 || (data.Configuration.Requirement.ConfiguredValue || data.Configuration.Requirement.DefaultValue) == 3 ? 'selected' : null).appendTo(input);
            $('<option />').attr('value', '4').text('Mandatory').attr('selected', (data.Configuration.Requirement.ConfiguredValue || data.Configuration.Requirement.DefaultValue) == 4 || (data.Configuration.Requirement.ConfiguredValue || data.Configuration.Requirement.DefaultValue) == 5 ? 'selected' : null).appendTo(input);
            input.attr('disabled', (data.Configuration.Requirement.ConfiguredValue || data.Configuration.Requirement.DefaultValue) % 2 == 1 ? 'disabled' : null);
            result = $('<div />').append(input).html();
        }
        return result;
    };
    this.createTypeColumn = function (data) {
        switch (data.ControlType) {
            case 'TabPage': return 'Tab';
            case 'TabList': return 'List';
            case 'GroupBox': return 'Section';
            case 'TextField':
                if (data.customField && data.customField.CftypeId == "MultiLine")
                    return "Multi-line text";
                else
                    return 'Text';
            case 'ListField': return 'Dropdown';
            case 'CodeField': return 'Dropdown';
            case 'PopupField': return 'Search';
            case 'DateField': return 'Date';
            case 'CheckField': return 'Switch';
            case 'FilePickerField': return 'File picker';
            case 'CustomFieldContainer': return 'Container';
            default: return data.ControlType;
        }
    };
    this.createSecurityColumn = function (data) {
        var result = '';
        if (consensus.web.customisation.isCapable(data.parent, 'ICanBeReadOnly') || consensus.web.customisation.isCapable(data.parent, 'ICanBeHidden')) {
            var input = $('<select />').addClass('form-control').attr('onchange', 'consensus.web.customisation.updateSecurityColumn(this);');
            $('<option />').attr('value', '').text('(use default setting)').appendTo(input);
            $('<option />').attr('value', '0').text('Visible').attr('selected', data.Visibility != null && data.Visibility.toString() == '0' ? 'selected' : null).appendTo(input);
            if (consensus.web.customisation.isCapable(data.parent, 'ICanBeReadOnly'))
                $('<option />').attr('value', '1').text('Read Only').attr('selected', data.Visibility != null && data.Visibility.toString() == '1' ? 'selected' : null).appendTo(input);
            if (consensus.web.customisation.isCapable(data.parent, 'ICanBeHidden'))
                $('<option />').attr('value', '2').text('Hidden').attr('selected', data.Visibility != null && data.Visibility.toString() == '2' ? 'selected' : null).appendTo(input);
            result = $('<div />').append(input).html();
        }
        return result;
    }
    this.updateInputColumn = function (source) {
        var row = $(source).parents('tr').first();
        var tbl = $(source).parents('table').first();
        var obj = tbl.dataTable().api().row(row).data();
        var prop = $(source).attr('onchange-target');
        var type = $(source).attr('onchange-type');
        if (type == 'configuration')
            obj.Configuration[prop].ConfiguredValue = $(source).val();
        else
            obj[prop] = $(source).val();
    };
    this.updateCheckColumn = function (source) {
        var row = $(source).parents('tr').first();
        var tbl = $(source).parents('table').first();
        var obj = tbl.dataTable().api().row(row).data();
        var prop = $(source).attr('onchange-target');
        var type = $(source).attr('onchange-type');
        if (type == 'configuration')
            obj.Configuration[prop].ConfiguredValue = $(source).is(':checked');
        else
            obj[prop] = $(source).is(':checked');
    };
    this.updateVisibleColumn = function (source) {
        var row = $(source).parents('tr').first();
        var tbl = $(source).parents('table').first();
        var obj = tbl.dataTable().api().row(row).data();
        if (consensus.web.customisation.isCapable(obj, 'ICanBeReadOnly'))
            obj.Configuration.IsReadOnly.ConfiguredValue = ($(source).val() == 'readonly').toString();
        if (consensus.web.customisation.isCapable(obj, 'ICanBeHidden'))
            obj.Configuration.IsHidden.ConfiguredValue = ($(source).val() == 'hidden').toString();
    };
    this.updateMandatoryColumn = function (source) {
        var row = $(source).parents('tr').first();
        var tbl = $(source).parents('table').first();
        var obj = tbl.dataTable().api().row(row).data();
        obj.Configuration.Requirement.ConfiguredValue = parseInt($(source).val());
    };
    this.updateSecurityColumn = function (source) {
        var row = $(source).parents('tr').first();
        var tbl = $(source).parents('table').first();
        var obj = tbl.dataTable().api().row(row).data();
        obj.Visibility = $(source).val() == '' ? null : $(source).val();
    };
    this.mergeCustomFieldData = function (data, customFields) {
        var customData = $.grep(data, function (el, iX) { return el.Configuration.IsCustomField && el.Configuration.IsCustomField.DefaultValue; });
        if (customData && customData.length > 0) {
            $.each(customFields, function (iX, customField) {
                var fieldDatas = $.grep(customData, function (d, dX) { return d.Configuration.CustomFieldId && d.Configuration.CustomFieldId.DefaultValue == customField.Id; });
                if (fieldDatas.length > 0) {
                    fieldDatas[0].customField = customField;
                }
            });

            data.sort(function (a, b) {
                if ((!a.Configuration.IsCustomField && !b.Configuration.IsCustomField)
                    || (a.Configuration.IsCustomField && b.Configuration.IsCustomField && a.Configuration.IsCustomField.DefaultValue == b.Configuration.IsCustomField.DefaultValue)) {
                    return a.Configuration.Ordinal - b.Configuration.Ordinal;
                }
                else if (a.Configuration.IsCustomField && a.Configuration.IsCustomField.DefaultValue)
                    return -1;
                else
                    return 1;
            });
        }
    }
};