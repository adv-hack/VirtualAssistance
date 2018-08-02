var consensus = consensus || {};
consensus.web = consensus.web || {};

consensus.web.dataTable = function (options) {
    var closure = this;
    this._tableElement = typeof (options.tableElement) == 'string' ? $('#' + options.tableElement) : options.tableElement;
    this._tableOptions = options.tableOptions;
    this._tableOptions.dom = this._tableOptions.dom || 'Bfrtip';
    this._createJson = options.createJson;
    this._createMode = options.createMode;
    this._createHref = options.createHref;
    this._modifyMode = options.modifyMode;
    this._modifyHref = options.modifyHref;
    this._sourceData = options.sourceData;
    this._sourceType = options.sourceType;
    this._populator = null;
    this._clientSideInit = options.clientSideInit;
    this._dataBoundValue = options.dataBoundValue;
    this._listsAtDepth = options.listsAtDepth;
    this._goToDepth = options.goToDepth;
    this._listsToDepth = options.listsToDepth;
    this._reorderable = options.reorderable;
    this._orderField = options.orderField;
    this._orderColumnIx = options.orderColumnIx;
    this._scope = window;
    this._compareRow = function (element, rowData) {
        if (rowData._guid)
            return (element._guid == rowData._guid)
        else if (rowData.id && rowData.id.length != 0 && rowData.id.toString() != '0')
            return (element.id == rowData.id);
        else if (rowData.Id && rowData.Id.length != 0 && rowData.Id.toString() != '0')
            return (element.Id == rowData.Id);
        else
            return false;
    };
    this._getSourceData = function () {
        var array;
        if (this._sourceType == 'binding') {
            var state = consensus.data.getState();
            //array = state && state.object && state.object[closure._sourceData] ? state.object[closure._sourceData] : [];
            array = [];
            if (state && state.object) {
                array = consensus.data.getValue(state.object, closure._sourceData);
                if (array === null)
                    array = [];
            }
        }
        else {
            if (!this._sourceData)
                this._sourceData = [];

            array = this._sourceData;
        }
        return array;
    };
    this._setSourceData = function (value) {
        if (this._sourceType == 'binding') {
            var state = consensus.data.getState();
            //state.object[closure._sourceData] = value;
            consensus.data.setValue(state.object, closure._sourceData, value);
        }
        else {
            this._sourceData = value;
        }
    };
    this._matchRow = function (row) {
        var array = this._getSourceData();
        var rowData = closure._tableElement.dataTable().api().row($(row).parents('tr').first()).data();
        var match = jQuery.map(array, function (element, index) {
            if (closure._compareRow(element, rowData))
                return { source: array, index: index, result: jQuery.extend(true, {}, element) };
        });
        return match.length == 0 ? null : match[0];
    };
    this._reload = function (data) {
        var api = closure._tableElement.dataTable().api();
        api.clear();
        if (data) {
            api.rows.add(data);
            api.rows().every( function ( rowIdx, tableLoop, rowLoop ) {
                var data = this.data();
                if (data.DeleteMe && data.DeleteMe.toString() === "1") {
                    $.each(this.nodes(), function (iX, node) { $(node).hide(); });
                }
            } );
        }
        api.draw();
        closure._tableElement.closest('.dataTables_wrapper').find('.dataTables_paginate').toggle(api.page.info().pages > 1);
        closure._tableElement.closest('.dataTables_wrapper').attr('hidden', closure._tableElement.is('[hidden="hidden"]') ? 'hidden' : null);

        //Updates for Member wizard
        if (location.href.toLocaleLowerCase().indexOf('newmemberwizard') > -1 && closure._tableElement[0].id.indexOf("NewSummaryList") > -1) {
            newMemberWizard.functions.updateSummaryDetails();
        }
    };
    this._load = function () {
        var options = jQuery.extend(true, {}, closure._tableOptions);
        options.initComplete = function (settings, json) {
            for (var i = 0; i < settings.aoColumns.length; i++)
                if (settings.aoColumns[i].tooltip && settings.aoColumns[i].tooltip.length != 0)
                    $(settings.aoColumns[i].nTh).attr('data-toggle', 'tooltip').attr('title', settings.aoColumns[i].tooltip).tooltip();
        };
        if (closure._reorderable) {
            $.each(options.columns, function (ix, col) {
                if (col.data != options.rowReorder.dataSrc) {
                    col.orderable = false;
                }
            });
        }
        var thisTable = closure._tableElement.dataTable(options);
        if (closure._reorderable) {
            thisTable.on('row-reorder.dt', closure.reorder);
        }
        window.consensus.web.dataTable.all.push(closure);
        closure.reload();
    };
    this.reorder = function (e, diff, edit) {
        if (diff && diff.length) {
            $.each(diff, function (ix, item) {
                var data = {};
                data[closure._orderField] = item.newPosition;
                consensus.network.send({
                    method: 'put',
                    url: consensus.resolveUrl(closure._tableElement.dataTable().api().row($(item.node)).data().uri),
                    data: data
                });

            });
            closure.reload();
        }
    };
    this.reload = function () {
        var data = closure._getSourceData();
        closure._reload(data);
    };
    this.create = function () {
        if (closure._reorderable) {
            // Need to set the order number of the new row in the json data
            var orderNos = closure._tableElement.dataTable().api().column(closure._orderColumnIx).data();
            var nextOrderNo = (orderNos && orderNos.length) ? orderNos.sort(function (a, b) { return a - b; }).reverse()[0] + 1 : 1;
            closure._createJson[closure._orderField] = nextOrderNo;
        }
        switch (closure._createMode.toUpperCase()) {
            case 'STATEFUL':
                var array = this._getSourceData();
                var item = jQuery.extend(true, {}, closure._createJson);
                item._guid = consensus.data.guid();
                if (closure._createHref) {
                    consensus.web.popupFrame({
                        url: consensus.resolveUrl(consensus.data.substitute(item, closure._createHref + (closure._createHref.indexOf('?') == -1 ? '?' : '&') + 'persistence=stateful')),
                        open: function () {
                            if (this.window.consensus) {
                                var button = $(this.window.document.body).find('#SiteContent_PopupFooter_SaveButton');
                                var state = new consensus.data.state(button, item, this.window, closure._scope);
                                consensus.data.setState(state);
                                state.updateScreen();
                            }
                        },
                        result: function (data) {
                            for (var entry in item)
                                if (typeof (data[entry]) == 'undefined')
                                    data[entry] = item[entry];
                        if (closure.onCreate && typeof (closure.onCreate) == 'function')
                            if (closure.onCreate(data) === false)
                                return false;
                            array.push(data);
                            closure.reload();
                        }
                    });
                }
                else {
                    // If we can create, but no URL was defined but then insert a blank row, running the OnCreate function, if defined.
                    // This is useful for "edit in place" style tables.
                    var tableData = closure._tableElement.dataTable().DataTable().data();
                    var rowData = { };

                    // the OnCreate method is passed the whole data array, including our new row.
                    tableData.push(rowData);
                    if (closure.onCreate && typeof (closure.onCreate) == 'function') {
                        if (closure.onCreate(tableData) === false)
                            return false;
                    }
                    tableData.pop();
                    
                    if (closure._createMode.toUpperCase() == 'STATEFUL') {
                        if (this._sourceType == 'binding') {
                            var state = consensus.data.getState();
                            var sourceData = consensus.data.getValue(state.object, closure._sourceData);
                            if (sourceData && sourceData.push)
                                sourceData.push(rowData);
                        }
                        else {
                            closure._sourceData.push(rowData);
                        }
                    }

                    var api = closure._tableElement.dataTable().api();
                    api.row.add(rowData).draw();
                    if (api.page.info().pages > 1) {
                        closure._tableElement.closest('.dataTables_wrapper').find('.dataTables_paginate').toggle(true);
                        api.page("last").draw('page');
                    }
                    // Focus on the first enabled input element in the new row, if any.
                    var $firstInput = closure._tableElement
                        .children("tbody")
                        .children("tr")
                        .last()
                        .children("td:has(input:enabled):visible")
                        .first()
                        .find("input:enabled");
                    if ($firstInput.length > 0)
                        $firstInput.focus();
                }
                break;
            case 'REALTIME':
                var item = jQuery.extend(true, {}, closure._createJson);
                consensus.web.popupFrame({
                    url: consensus.resolveUrl(consensus.data.substitute(item, closure._createHref)) + (closure._populator ? (closure._createHref.indexOf('?') == -1 ? '?' : '&') + 'noreload=1' : ''),
                    open: function () {
                        if (this.window.consensus) {
                            var button = $(this.window.document.body).find('#SiteContent_PopupFooter_SaveButton');
                            var state = new consensus.data.state(button, item, this.window, closure._scope);
                            consensus.data.setState(state);
                            state.updateScreen();
                        }
                    },
                    result: function (data) {

                        for (var entry in item)
                            if (typeof (data[entry]) == 'undefined')
                                data[entry] = item[entry];
                        consensus.network.send({
                            method: 'put',
                            url: data.uri,
                            data: data,
                            success: function (result) {
                                //Checks if Person search popup is opened and new person is created.
                                if (result && location.href.toLocaleLowerCase().indexOf('personsearch') > -1) {
                                    var personObject = {
                                        command: 'select',
                                        text: result.PersonName,
                                        value: result.Id,
                                        data: {
                                            organisation: {
                                                id: result.OrganisationId,
                                                name: result.Organisation.Name
                                            },
                                            address: {
                                                id: result.Address.Id,
                                                mailstring: result.Address.MailString,
                                                Line1: result.Address.Building,
                                                Line2: result.Address.Street,
                                                Line3: result.Address.Area,
                                                town: result.Address.Town,
                                                county: result.Address.County,
                                                postcode: result.Address.Postcode,
                                                country: result.Address.Country
                                            },
                                            telephone: result.Telephone,
                                            fax: result.Fax,
                                            email: result.Email,
                                            pnId: result.PersonId
                                        }
                                    }
                                    closePopup(personObject);
                                }
                                else {
                                    if (closure.onCreate && typeof (closure.onCreate) == 'function')
                                        if (closure.onCreate(result) === false)
                                            return false;
                                    if (closure._populator)
                                        closure._populator.refresh();
                                    else
                                        closure.reload();
                                }
                            }
                        });
                    }
                });
                break;
            case 'REDIRECT':
                var item = jQuery.extend(true, {}, closure._createJson);
                window.location.href = consensus.resolveUrl(consensus.data.substitute(item, closure._createHref));
                break;
        }
    };
    this.modify = function (row) {
        switch (closure._modifyMode.toUpperCase()) {
            case 'STATEFUL':
                var match = closure._matchRow(row);
                if (match) {
                    consensus.web.popupFrame({
                        url: consensus.resolveUrl(consensus.data.substitute(match.result, closure._modifyHref + (closure._modifyHref.indexOf('?') == -1 ? '?' : '&') + 'persistence=stateful')),
                        open: function () {
                            if (this.window.consensus) {
                                var button = $(this.window.document.body).find('#SiteContent_PopupFooter_SaveButton');
                                var state = new consensus.data.state(button, match.result, this.window, closure._scope);
                                consensus.data.setState(state);
                                state.updateScreen();
                            }
                        },
                        result: function (data) {
                            if (data.DeleteMe) {
                                closure.remove(data);
                            }
                            else {
                                if (closure.onModify && typeof (closure.onModify) == 'function')
                                    if (closure.onModify(data) === false)
                                        return false;
                                match.source[match.index] = data;
                                if (closure.onModify && typeof (closure.onModify) == 'function')
                                    if (closure.onModify(data) === false)
                                        return false;
                                closure.reload();
                            }
                        }
                    });
                }
                break;
            case 'REALTIME':
                var url = consensus.resolveUrl(closure._tableElement.dataTable().api().row($(row).parents('tr').first()).data().uri);
                url += (url.indexOf("?") > 0 ? "&" : "?") + "GoToDepth=" + closure._goToDepth + "&ListsAtDepth=" + closure._listsAtDepth + "&ListsToDepth=" + closure._listsToDepth;
                consensus.network.send({
                    method: 'get',
                    url: url,
                    success: function (result) {
                        consensus.web.popupFrame({
                            url: consensus.resolveUrl(consensus.data.substitute(result, closure._modifyHref)) + (closure._populator ? (closure._modifyHref.indexOf('?') == -1 ? '?' : '&') + 'noreload=1' : ''),
                            open: function () {
                                if (this.window.consensus) {
                                    var button = $(this.window.document.body).find('#SiteContent_PopupFooter_SaveButton');
                                    var state = new consensus.data.state(button, result, this.window, closure._scope);
                                    consensus.data.setState(state);
                                    state.updateScreen();
                                }
                            },
                            result: function (data) {
                                if (data.DeleteMe) {
                                    closure.remove(data);
                                }
                                else {
                                    var hSaving = closure.showRowSaving(row, "Saving");
                                    consensus.network.send({
                                        method: 'put',
                                        url: closure._tableElement.dataTable().api().row($(row).parents('tr').first()).data().uri,
                                        data: data,
                                        success: function (result) {
                                            if (closure.onModify && typeof (closure.onModify) == 'function')
                                                if (closure.onModify(result) === false)
                                                    return false;
                                            if (closure._populator)
                                                closure._populator.refresh();
                                            else
                                                closure.reload();

                                            closure.hideRowSaving(hSaving);
                                        },
                                        error: function (err) {
                                            closure.hideRowSaving(hSaving);
                                        }
                                    });
                                }

                            }
                        });
                    }
                });
                break;
            case 'REDIRECT':
                consensus.network.send({
                    method: 'get',
                    url: consensus.resolveUrl(closure._tableElement.dataTable().api().row($(row).parents('tr').first()).data().uri),
                    success: function (result) {
                        window.location.href = consensus.resolveUrl(consensus.data.substitute(result, closure._modifyHref));
                    }
                });
        }
    };
    this.remove = function (data) {
        switch (closure._modifyMode.toUpperCase()) {
            case 'STATEFUL':
                var array = closure._getSourceData();
                var rowData = null;
                for (var i = 0; i < closure._tableElement.dataTable().api().rows().count() ; i++) {
                    if (closure._tableElement.dataTable().api().row(i).data().Id == data.Id) {
                        rowData = closure._tableElement.dataTable().api().row(i).data();
                    }
                }
                var match = jQuery.grep(array, function (obj) { return !closure._compareRow(obj, rowData); });
                closure._setSourceData(match);
                if (closure.onDelete && typeof (closure.onDelete) == 'function')
                    if (closure.onDelete(data) === false)
                        return false;
                closure.reload();
                break;
            case 'REALTIME':
                consensus.network.send({
                    method: 'delete',
                    url: data.uri,
                    success: function (result) {
                        if (closure.onDelete && typeof (closure.onDelete) == 'function')
                            if (closure.onDelete(data) === false)
                                return false;
                        if (closure._populator)
                            closure._populator.refresh();
                        else
                            closure.reload();
                    }
                });
                break;
        }
    };
    this.removeRow = function (row) {
        window.top.swal.call(window.top, { title: 'Are you sure?', text: 'Are you sure you want to delete this record?', type: 'warning', showCancelButton: true, confirmButtonText: 'Yes', cancelButtonText: 'No', confirmButtonClass: 'btn btn-danger', cancelButtonClass: 'btn btn-default', buttonsStyling: false }).then(function () {
            switch (closure._modifyMode.toUpperCase()) {
                case 'STATEFUL':
                    var array = closure._getSourceData();
                    var rowData = closure._tableElement.dataTable().api().row($(row).parents('tr').first()).data();
                    var match = jQuery.grep(array, function (obj) { return !closure._compareRow(obj, rowData); });
                    closure._setSourceData(match);
                    if (closure.onDelete && typeof (closure.onDelete) == 'function')
                        if (closure.onDelete(data) === false)
                            return false;
                    closure.reload();
                    break;
                case 'REALTIME':
                    consensus.network.send({
                        method: 'delete',
                        url: closure._tableElement.dataTable().api().row($(row).parents('tr').first()).data().uri,
                        success: function (result) {
                            if (closure.onDelete && typeof (closure.onDelete) == 'function')
                                if (closure.onDelete(data) === false)
                                    return false;
                            if (location.href.toLocaleLowerCase().indexOf('batch') > -1)
                            {
                                window.location.reload();
                            }
                            if (closure._populator)
                                closure._populator.refresh();
                            else
                                closure.reload();

                        }
                    });
                    break;
                case 'REDIRECT':
                    consensus.network.send({
                        method: 'delete',
                        url: closure._tableElement.dataTable().api().row($(row).parents('tr').first()).data().uri,
                        success: function (result) {
                            if (closure.onDelete && typeof (closure.onDelete) == 'function')
                                if (closure.onDelete(data) === false)
                                    return false;
                            closure.reload();
                        }
                    });
                    break;
            }
        });
    };
    this.markToDelete = function (target) {
        switch (closure._createMode.toUpperCase()) {
            case 'STATEFUL':
                var $domRow = $(target).parents('tr').first();
                var dtRow = closure._tableElement.dataTable().api().row($domRow);
                var rowData = dtRow.data();
                rowData.DeleteMe = 1;
                $domRow.hide();
                break;
        }
    };
    this.showRowSaving = function (row, message) {
        var tr = $(row).parents('tr').first();
        var tab = tr.parents('table').first();
        var banner = $("<div/>")
            .addClass("con-grid-row-saving")
            .height(tr.find("td").height())            
            .css("position", "absolute")
            //.css("background-color", tr.find("td").css("background-color"))
            .insertAfter(tab)
            .offset(tr.offset())
            .text(message + "...");
        tr.css("visibility", "hidden");
        // Hiding the row (or cells in a row) loses the top border.
        // Frig this by setting a bottom border on the previous row's cells
        // and removing it on this rows cells (so that the apparant row height
        // is stable).
        var prevTr = tr.prev();
        if (prevTr.length > 0) {
            prevTr.find("td").css("border-bottom-width", "1px");
            tr.find("td").css("border-top-width", "0px");
        }
        return {
            banner: banner,
            row: tr,
            prevRow: prevTr.length > 0 ? prevTr : null
        };
    };
    this.hideRowSaving = function (hSaving) {
        if (hSaving) {
            if (hSaving.banner && hSaving.banner.remove)
                hSaving.banner.remove();
            if (hSaving.row && hSaving.row.css)
                hSaving.row.css("visibility", "");
            if (hSaving.prevRow && hSaving.prevRow.css) {
                hSaving.prevRow.find("td").css("border-bottom-width", "");
                hSaving.row.find("td").css("border-top-width", "");
            }
        }
    };

    this.onCreate = null;
    this.onModify = null;
    this.onDelete = null;
    closure._load();

    this.setPopulator = function (populator) {

        populator._callback = function (data) { closure._setSourceData(data); closure._reload(data); };
        //populator._error = function (err) { closure.clearSpinner(); };
        //populator._beforeRefresh = function (data) { closure.setSpinner(); };

        closure._populator = populator;

        if (closure._clientSideInit) {
            $(document).ready(function () {
                if (!populator._populated) {
                    closure._populator.refresh();
                }
            });
        }
    };
};

window.consensus.web.dataTable.formatExport = function (data, col, row) {
    if (data && $.isFunction(data.search) && data.search(/^\s*</i) >= 0) { // If it's a string that starts with < then assume it's html
        var getElText = function ($el) {
            var retStr = "";
            if ($el.is('i')) { // is it an "i" element? - assume this is an icon
                retStr = $el.attr('title');
                if (!retStr) {
                    var cls = $el.attr('class').split(" "); // if we don't have a title look at the classes
                    $.each(cls, function (ix, cl) {
                        switch (cl) {
                            case 'icons8-checkmark':
                                retStr = "Yes";
                                break;
                            case 'icons8-delete_sign':
                                retStr = "No";
                                break;
                            case 'hidden':
                                retStr = "";
                                return false; // If it has the hidden class return an empty string.
                            default:
                                // Fallback if we have no title and its not an icon with a recognised meaning - the icon name without the icons8 prefix.
                                retStr = cl.replace(/^(icons8\-)/ig, "");
                                break;
                        }
                    });
                }
            }
            else {
                // We know it's HTML. Get its inner text, if any, otherwise if it has a title use that.
                retStr = $el.text();
                if (!retStr && $el.attr('title'))
                    retStr = $el.attr('title');
            }
            return retStr;
        }
        var $els = $(data),
            aRet = [];
        $els.each(function (ix, el) {
            var sElText = getElText($(el));
            if (sElText)
                aRet.push(sElText);
        })
        return aRet.join(" ");
    }
    else {
        return data;
    }
};
window.consensus.web.dataTable.toggle = function (check, field) {
    var chk = $(check);
    var row = chk.parents('tr').first();
    var tbl = chk.parents('table').first();
    var obj = tbl.dataTable().api().row(row).data();
    consensus.data.setValue(obj, field, chk.is(':checked'));
}
window.consensus.web.dataTable.all = [];
