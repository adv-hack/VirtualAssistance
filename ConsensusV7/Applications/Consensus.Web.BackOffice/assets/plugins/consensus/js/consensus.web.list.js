var consensus = consensus || {};
consensus.web = consensus.web || {};

consensus.web.list = function (group, options) {
    var closure = this;
    this._options = options;
    this._groupElement = typeof (group) == 'string' ? $('#' + group) : group;
    this._fieldElement = this._groupElement.find('#' + this._groupElement.attr('id') + 'Field');
    this._spinner = null,
    this._displayMember = options.displayMember;
    this._valueMember = options.valueMember;
    this._rowAttributes = options.rowAttributes;
    this._clientSideInit = options.clientSideInit;

    this.setPopulator = function (populator) {

        populator._callback = function (data) { closure.populate(data); closure.clearSpinner(); };
        populator._error = function (err) { closure.clearSpinner(); };
        populator._beforeRefresh = function (data) { closure.setSpinner(); };

        closure._populator = populator;

        if (closure._clientSideInit) {
            $(document).ready(function () {
                if (!populator._populated) {
                    closure._populator.refresh();
                }
            });
        }
    };
    
    this.populate = function (data) {
        // Hang on to the currently selected value;
        var currentValue = closure._fieldElement.val();

        // Remove the existing options
        closure._fieldElement.find('option').remove();
        // Always create an empty element at the top
        $('<option />').text("").attr('value', "").appendTo(closure._fieldElement);

        // Create the new options
        for (var i = 0; i < data.length; i++) {
            var option = $('<option />').text(data[i][closure._displayMember])
                .attr('value', closure._valueMember ? data[i][closure._valueMember] : data[i][closure._displayMember]);
            if (closure._rowAttributes) {
                $.each(closure._rowAttributes, function (iX, attribute) {
                    option.attr("data-" + attribute.Name, data[i][attribute.Value]);
                });
            }
            option.appendTo(closure._fieldElement);
        }

        // Reselect the current value, if it is still in the list.
        if (currentValue) {
            closure._fieldElement.find('option').each(function (ix, option) {
                if ($(option).attr("value") == currentValue) {
                    $(option).attr("selected", true);
                    return false;
                }
            });
        }

        closure._populator._populated = true;
    };

    this.clearSpinner = function () {
        closure._spinner.hide();
    };

    this.setSpinner = function () {
        if (!closure._spinner) {
            closure._spinner = $("<div />")
                .addClass("con-list-refreshing")
                .height(this._fieldElement.outerHeight())
                .width(this._fieldElement.outerWidth())
                .css("position", "absolute")
                //.css("background-color", tr.find("td").css("background-color"))
                .insertAfter(this._fieldElement)
                .offset(this._fieldElement.offset());
            
            $("<div />").addClass("icons8-refresh")
                .appendTo(closure._spinner);
        }
        else {
            closure._spinner.show();
        }
    };

};