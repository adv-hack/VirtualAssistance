var consensus = consensus || {};

// Data Management
consensus.data = consensus.data || {};
consensus.data.guid = function () {
    return 'xxxxxxxx-xxxx-4xxx-yxxx-xxxxxxxxxxxx'.replace(/[xy]/g, function (c) {
        var r = Math.random() * 16 | 0, v = c == 'x' ? r : (r & 0x3 | 0x8);
        return v.toString(16);
    });
};
consensus.data.init = function (editButton, saveButton, url, formData, id, success) {
    editButton.attr('disabled', 'disabled');

    var fInitData = function (data) {
        var state = new consensus.data.state(saveButton, data);
        state.updateObject();
        consensus.data.setState(state);
        setImmediate(function () {
            for (var i = 0; i < window.consensus.web.dataTable.all.length; i++) {
                window.consensus.web.dataTable.all[i].reload();
                var table = window.consensus.web.dataTable.all[i];
                if (table._reorderable) {
                    table._tableElement.dataTable().api().rowReorder.enable(false);
                }
            }
        });

        if (!id) {
            state.updateObject(null, true);
            state.edit();
        }
        if (success && typeof (success) == 'function')
            success.call();
        editButton.attr('disabled', null);
    }

    if (url && !formData)
    {
        consensus.network.send({
            method: id ? 'get' : 'post',
            url: url + '/' + (id && id.length != 0 ? id : 'create'),
            success: function (restData) {
                fInitData(restData);
            }
        });
    }
    else {
        fInitData(formData);
    }
}
consensus.data.state = function (button, object, scope, parentScope) {
    this.source = null;
    this.object = object;
    this.button = button;
    this.scope = typeof (scope) == 'undefined' ? window.document.body : ($.isWindow(scope) ? scope.document.body : scope);
    this.parentScope = typeof (parentScope) == 'undefined' ? window.parent.document.body : parentScope;
    var closure = this;
    this._getWindow = function () {
        if (this.scope instanceof window.constructor || this.scope.constructor.name === 'Window')
            return this.scope;
        else if (this.scope instanceof document.constructor || this.scope.constructor.name === 'document')
            return this.scope.defaultView;
        else if (this.scope.ownerDocument)
            return this.scope.ownerDocument.defaultView;
        else
            return this.scope;
    };
    this._find = function (selector) {
        var scope = closure.scope;
        if (scope instanceof window.constructor || scope.constructor.name === 'Window')
            scope = scope.document.body;
        return $(scope).find(selector);
    };
    this.toggleSave = function (text) {
        closure.button.attr('disabled', text ? 'disabled' : null);
        closure.button.css('cursor', text ? 'default' : '');
        var label = closure.button.find('.text');
        label.attr('data-text', label.attr('data-text') || label.text());
        label.text(text ? text : label.attr('data-text'));
    };
    this.toggleScreen = function (enable) {
        closure._find('form:not(iframe *)').attr('data-mode', enable ? 'edit' : 'read');
        closure._find('.input-group:not(iframe *)').attr('disabled', enable ? null : 'disabled')
        closure._find('.input-group:not(iframe *):not([readonly])').find('input, select, textarea, .input-group-addon').attr('disabled', enable ? null : 'disabled');
        closure._find('.input-group:not(iframe *):not([readonly])').find('.bootstrap-switch input[type=checkbox]').bootstrapSwitch('disabled', !enable);
        closure._find('.input-group:not(iframe *):not([readonly])').has('.note-editor').find('textarea.form-control').each(function (iX, editor) {
            $(editor).summernote(enable ? 'enable' : 'disable');
        });
        for (var i = 0; i < closure._getWindow().consensus.web.dataTable.all.length; i++) {
            var table = closure._getWindow().consensus.web.dataTable.all[i];
            if (table._tableElement.parents('.tab-pane.active').length != 0) {
                table._tableElement.dataTable().fnAdjustColumnSizing();
            }
            if (table._reorderable) {
                table._tableElement.dataTable().api().rowReorder.enable(enable);
            }
        }
        setTimeout(function () {
            closure._find('.bootstrap-switch-container:not(iframe *)').toggleClass('enable-transition', enable);
        }, 0);
        if (enable)
            $('[data-provide=bootstrapswitch]').bootstrapSwitch('_init');
    };
    this.updateScreen = function () {
        this._updateScreen('select', 'data-bound-value', function (value) { $(this).val(value); });
        this._updateScreen('input[type=checkbox]', 'data-bound-value', function (value) { this.checked = value; if ($(this).data('bootstrapSwitch')) { $(this).bootstrapSwitch('state', value); } });
        this._updateScreen('input:not([type=checkbox])', 'data-bound-value', function (value) { $(this).val(value); });
        this._updateScreen('input:not([type=checkbox])', 'data-bound-text', function (value) { $(this).val(value); });
        this._updateScreen('textarea', 'data-bound-value', function (value) {
            var $this = $(this);
            $this.val(value);
            var $editor = $this.siblings(".note-editor").find(".note-editable");
            if ($editor.length > 0) {
                //if ($this.summernote('code') != value) {
                //    $this.summernote('code', value);                
                //    //$this.summernote('reset');
                //    //$this.summernote('pasteHTML', value);
                //}
                $editor.html(value);
            }
        });
        this._find('[consensus-input-link]').each(function () {
            var href = $(this).attr('consensus-input-link');
            var link = $(this).find('a.consensus-input-link');
            var control = $(this).find('.form-control');
            if (control.is('select')) {
                var option = control.find('option[value="' + control.val() + '"]');
                link.attr('href', href.replace(/\{text\}/g, option.text()).replace(/\{id\}/g, option.val())).text(control.val());
            } else {
                var hidden = $(this).find('> input[type=hidden]');
                link.attr('href', href.replace(/\{text\}/g, control.val()).replace(/\{id\}/g, hidden.val())).text(control.val());
            }
        });
        for (var i = 0; i < this._getWindow().consensus.web.dataTable.all.length; i++)
            this._getWindow().consensus.web.dataTable.all[i].reload();
    };
    this.updateObject = function (target, init) {
        target = target || closure.object;
        this._updateObject(target, init === true, 'select', 'data-bound-value', function (obj) { return $(this).val(); });
        this._updateObject(target, init === true, 'input[type=checkbox]', 'data-bound-value', function () { return this.checked; });
        this._updateObject(target, init === true, 'input:not([type=checkbox])', 'data-bound-value', function () { return $(this).val(); });
        this._updateObject(target, init === true, 'input:not([type=checkbox])', 'data-bound-text', function () { return $(this).val(); });
        this._updateObject(target, init === true, 'textarea', 'data-bound-value', function () { return $(this).val(); });
    };
    this.createObject = function () {
        var result = {};
        closure.updateObject(result);
        for (var i = 0; i < closure._getWindow().consensus.web.dataTable.all.length; i++) {
            var grid = closure._getWindow().consensus.web.dataTable.all[i];
            var mode = (result.Id && result.Id.length != 0 && result.Id.toString() != '0' ? grid._modifyMode : grid._createMode).toUpperCase();
            if (mode == 'STATEFUL') {
                if (grid._dataBoundValue) {
                    consensus.data.setValue(result, grid._dataBoundValue, grid._sourceData);
                }
                else {
                    result[grid._sourceData] = closure.object[grid._sourceData];
                }
            }
        }
        if (closure.object.Id && closure.object.Id.length != 0 && closure.object.Id.toString() != '0')
            result.Id = closure.object.Id;
        if (closure.object.Uri && closure.object.Uri.length != 0)
            result.Uri = closure.object.Uri;
        if (closure.object.uri && closure.object.uri.length != 0)
            result.uri = closure.object.uri;

        return result;
    };
    this.changed = function () {
        var result = false;
        closure._find('input[data-bound-value][type=checkbox]:not(iframe *)').each(function () {
            result = result || this.checked != consensus.data.getValue(closure.object, $(this).attr('data-bound-value'));
        });
        closure._find('input[data-bound-value]:not([type=checkbox]):not(iframe *)').each(function () {
            result = result || $(this).val() != consensus.data.getValue(closure.object, $(this).attr('data-bound-value'));
        });
        return result;
    };
    this.edit = function () {
        consensus.data.edit(closure);
        if (consensus.data.onedit && typeof (consensus.data.onedit) == 'function')
            consensus.data.onedit.call();
    };
    this.undo = function () {
        consensus.data.undo(closure);
    };
    this.save = function () {
        consensus.data.save(closure);
    };
    this._updateScreen = function (selector, attribute, callback) {
        var elements = closure._find(selector + '[' + attribute + ']:not(iframe *)');
        elements.each(function () {
            var field = $(this).attr(attribute);
            var dType = $(this).attr('data-type');
            if (consensus.data.hasValue(closure.object, field)) {
                var value = consensus.data.getValue(closure.object, field);
                if (dType == 'date' && value instanceof Date)
                    value = value.toLocaleString('en-GB', { day: "2-digit", month: "long", year: "numeric" });
                else if (dType == 'time' && value instanceof Date)
                    value = (value.getHours() / 100).toFixed(2).substr(2) + ':' + (value.getMinutes() / 100).toFixed(2).substr(2);
                callback.call(this, value);
            }
        });
    };
    this._updateObject = function (target, init, selector, attribute, callback) {
        var elements = closure._find(selector + '[' + attribute + ']:not(iframe *)');
        elements.each(function () {
            var field = $(this).attr(attribute);
            var value = callback.call(this);
            if ((value != null && value.length != 0) || !init) {
                var customFieldAttr = $(this).attr("custom-field-id");
                //if (!customFieldAttr) {
                //    customFieldAttr = $(this).parents(".consensus-input").find("[custom-field-id]").attr("custom-field-id");
                //}
                var customFieldId = parseInt(customFieldAttr);
                if (customFieldId) {
                    consensus.data.setValue(target, field, {
                        FieldId: customFieldId,
                        Value: value
                    });
                }
                else {
                    consensus.data.setValue(target, field, value);                
                }
            }
        });
    };
}
consensus.data.getState = function () {
    return window['consensus_data_state'];
};

consensus.data.getValue = function (object, property) {
    var result;
    if (object == null) {
        result = null;
    } else if (property.indexOf('.') == -1) {
        result = null;
        for (var x in object)
            if (x.toLowerCase() == property.toLowerCase()) {
                result = object[x];
                break;
            }
    } else {
        var parent = property.substr(0, property.indexOf('.'));
        var child = property.substr(property.indexOf('.') + 1);
        if (parent == "_customFields" && child && object[parent]) {
            result = consensus.data.getValue(object[parent][child], "Value");
        }
        else {
            result = consensus.data.getValue(object[parent], child);
        }
    }
    return result;
};
consensus.data.hasValue = function (object, property) {
    var result;
    if (object == null) {
        result = false;
    } else if (property.indexOf('.') == -1) {
        result = false;
        for (var x in object)
            if (x.toLowerCase() == property.toLowerCase())
                result = true;
    } else {
        var parent = property.substr(0, property.indexOf('.'));
        var child = property.substr(property.indexOf('.') + 1);
        if (parent == "_customFields" && child && object[parent]) {
            result = consensus.data.hasValue(object[parent][child], "Value");
        }
        else {
            result = consensus.data.hasValue(object[parent], child);
        }
    }
    return result;
};
consensus.data.setState = function (value) {
    value._getWindow()['consensus_data_state'] = value;
};
consensus.data.setValue = function (object, property, value) {
    var result;
    if (property.indexOf('.') != -1) {
        var parent = property.substr(0, property.indexOf('.'));
        var child = property.substr(property.indexOf('.') + 1);
        object[parent] = object[parent] || {};
        consensus.data.setValue(object[parent], child, value);
    }
    else {
        object[property] = value;
    }
};
consensus.data.substitute = function (object, value) {
    var match = new RegExp('\\{\\{([^\\}\\}]+)\\}\\}', 'g').exec(value);
    while (match) {
        // Escape both single and double quotes in the data, noting that 
        // we are assuming that the "template" (value) has string values enclosed 
        // in single quotes (despite this being non-standard json) as they
        // are set up in an ASP.NET control property. 
        var sVal = consensus.data.getValue(object, match[1]);
        if (sVal && sVal.replace) {
            if (sVal.indexOf('$&') >= 0) {
                sVal = sVal.split('$').join('$$');
            }
            sVal = sVal.replace(/\'/g, "\\'").replace(/\"/g, "&quot;");
        }
        value = value.replace(match[0], (sVal || ''));
        match = new RegExp('\\{\\{([^\\}\\}]+)\\}\\}', 'g').exec(value);
    }
    value = value.replace(/\r/g, '\\r').replace(/\n/g, '\\n');
    return value;
};
consensus.data.validation = {};
consensus.data.validation.reset = function () {
    var state = consensus.data.getState();
    if (state._getWindow().Page_Validators) {
        jQuery.each(state._getWindow().Page_Validators, function (index, element) {
            element.isvalid = true
            state._getWindow().ValidatorUpdateDisplay(element);
            $(this.scope).find('#' + element.controltovalidate).windows('.consensus-input').removeClass('has-warning').removeClass('has-error');
        });
    }
};
consensus.data.validation.check = function (control, scope) {

    var result = {
        validators: [],
        formErrors: 0,
        pageErrors: 0,
    };

    // Get the validators for the window  
    var state = consensus.data.getState();
    var hWndw = (state && state._getWindow() ? state._getWindow() : window);
    if (hWndw.Page_Validators) {

        // Identify the validators that need to be evaluated
        for (var i = 0; i < hWndw.Page_Validators.length; i++) {
            if (!control || control == document.getElementById(hWndw.Page_Validators[i].controltovalidate))
                if (!scope || jQuery.contains($(scope)[0], hWndw.Page_Validators[i]))
                    result.validators.push(hWndw.Page_Validators[i]);
        }

        // Loop through each of the validators that need to be executed
        for (var i = 0; i < result.validators.length; i++) {

            // Reset the state of the input control
            var wrapper = $('#' + result.validators[i].controltovalidate).parents('.consensus-input');
            wrapper.removeClass('has-warning').removeClass('has-error');

            // Reset the state of the validator
            result.validators[i].iserror = $(result.validators[i]).attr('data-validation-critical') != 'no';
            result.validators[i].isvalid = true;

            // Re-evaluate the validator
            if (result.validators[i].enabled != false) {
                hWndw.ValidatorValidate(result.validators[i], result.validators[i].validationGroup);
                if (wrapper && wrapper.length != 0) {
                    if (result.validators[i].iserror && !result.validators[i].isvalid)
                        wrapper.addClass('has-error');
                    if (wrapper && !wrapper.hasClass('.has-error') && !result.validators[i].iserror && !result.validators[i].isvalid)
                        wrapper.addClass('has-warning');
                }
            }

            // Update the display to show the result of the validation
            hWndw.ValidatorUpdateDisplay(result.validators[i]);
        }

        // Loop through all validators and identify the number of errors
        for (var i = 0; i < hWndw.Page_Validators.length; i++)
            if (hWndw.Page_Validators[i].enabled != false)
                if (hWndw.Page_Validators[i].controltovalidate && hWndw.Page_Validators[i].controltovalidate.length != 0)
                    result.formErrors += (!hWndw.Page_Validators[i].isvalid && hWndw.Page_Validators[i].iserror) ? 1 : 0;
                else
                    result.pageErrors += (!hWndw.Page_Validators[i].isvalid && hWndw.Page_Validators[i].iserror) ? 1 : 0;

        // If object state exists, enable or disable the save button based on the number of form validation errors
        if (state)
            state.toggleSave(result.formErrors == 0 ? null : result.formErrors.toString() + ' error' + (result.formErrors > 1 ? 's' : ''));

        // Hide or show page-level validation errors
        if (hWndw.Page_ValidationSummaries.length != 0) {
            if (result.pageErrors == 0) {
                $(hWndw.Page_ValidationSummaries[0]).slideUp(500, function () {
                    hWndw.Page_ValidationSummaries[0].innerHTML = '';
                });
            } else {
                hWndw.Page_ValidationSummaries[0].innerHTML = '';
                for (var x = 0; x < hWndw.Page_Validators.length; x++)
                    if (hWndw.Page_Validators[x].enabled != false && hWndw.Page_Validators[x].isvalid == false && (!hWndw.Page_Validators[x].controltovalidate || hWndw.Page_Validators[x].controltovalidate.length == 0))
                        hWndw.Page_ValidationSummaries[0].innerHTML += (hWndw.Page_ValidationSummaries[0].innerHTML.length == 0 ? '' : '<br/>') + hWndw.Page_Validators[x].errormessage;
                $(hWndw.Page_ValidationSummaries[0]).slideDown(500);
            }
        }
    }
    return result;
};
consensus.data.validation.bind = function (conditionalElement, validatedElement, condition) {

    conditionalElement = typeof (conditionalElement) == 'string' ? $('#' + conditionalElement) : conditionalElement;
    validatedElement = typeof (validatedElement) == 'string' ? $('#' + validatedElement) : validatedElement;

    var evaluate = function () {
        var enableValidator = condition.call(conditionalElement);
        if (typeof (window.ValidatorValidate) == 'function' && typeof (window.Page_Validators) != 'undefined') {
            var validator = jQuery.grep(window.Page_Validators, function (obj) { return obj.validationGroup == validatedElement.attr('id'); });
            if (validator.length != 0) {
                validator[0].enabled = enableValidator;
                consensus.data.validation.check($('#' + validatedElement.attr('id') + 'Field'));
            }
        }
    }
    $(document).ready(function () { evaluate(); });
    $(conditionalElement).on('change', function () { evaluate(); });
    $(conditionalElement).on('switchChange.bootstrapSwitch', function () { evaluate(); });
};
consensus.data.onsave = null;
consensus.data.onedit = null;
consensus.data.onundo = null;
consensus.data.edit = function (state) {
    state.source = jQuery.extend(true, {}, state.object);
    state.updateScreen();
    state.toggleScreen(true);
}
consensus.data.undo = function (state) {
    if ((state.source || state.object).IsPersisted) {
        state.object = state.source ? jQuery.extend(true, {}, state.source) : state.object;
        state.updateScreen();
        state.toggleScreen(false);
        if (consensus.data.onundo && typeof (consensus.data.onundo) == 'function') {
            consensus.data.onundo.call();
        }
    }
    else {
        window.history.back(1);
    }
}
consensus.data.save = function (state) {
    var validation = consensus.data.validation.check();
    if (validation.formErrors == 0 && validation.pageErrors == 0) {
        state.updateObject();
        state.toggleSave('Saving...');
        consensus.network.send({
            url: state.object.uri,
            data: state.createObject(),
            success: function (result) {
                var callback = function (state, result) {
                    var hasId = typeof (state.source.Id) != 'undefined' && state.source.Id != null && state.source.Id.length != 0 && state.source.Id.toString() != '0';
                    state.toggleSave(null);
                    state.object = jQuery.extend(true, {}, result);
                    state.updateScreen();
                    state.toggleScreen(false);
                    if (window.top.consensus == window.consensus && !hasId)
                        window.location = window.location.toString() + (window.location.toString().indexOf('?') == -1 ? '?' : '&') + 'id=' + result.Id;
                }
                if (consensus.data.onsave && typeof (consensus.data.onsave) == 'function')
                    consensus.data.onsave.call(this, state, result, callback);
                else
                    callback.call(this, state, result);
            },
            error: function (request) {
                state.toggleSave(null);

                switch (request.status) {
                    case 400: alert('Failed to save', request.statusText, 'info', 4000); break;
                    case 401: alert('Not Authorised', 'The requested page could not be accessed.<br/>Please contact your administrator for support', 'error'); break;
                    case 404: alert('Not Found', 'The requested page could not be found.<br/>Please contact your administrator for support', 'error'); break;
                    case 405: alert('Not Supported', 'The requested action is not supported.<br/>Please contact your administrator for support', 'error'); break;
                    case 500: alert('Server Error', 'An internal server error has occurred.<br/>Please contact your administrator for support', 'error'); break;
                    default: alert('Error', 'An unknown error has occurred.<br/>Please contact your administrator for support', 'error'); break;
                }
            }
        });
    }
}
