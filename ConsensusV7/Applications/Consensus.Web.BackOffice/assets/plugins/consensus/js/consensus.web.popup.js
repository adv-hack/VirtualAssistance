var consensus = consensus || {};
consensus.web = consensus.web || {};

consensus.web.popup = function (options) {

    // Create the modal popup DOM elements
    var modal = $('<div />').addClass('modal fade').attr('role', 'dialog').appendTo(window.top.document.body);
    var popup = $('<div />').addClass('modal-dialog').css('width', options.width || 'auto').css('margin', options.width ? '' : '0 50px').appendTo(modal);
    var inner = $('<div />').addClass('modal-content').css('font-size', '12px').css('width', '100%').appendTo(popup);

    // Render the header, body and footer within the modal popup
    var headerFrame = $('<div />').addClass('modal-header').appendTo(inner);
    var headerTitle = $('<h5 />').addClass('modal-title').text(options.title || consensus.name).appendTo(headerFrame);
    var headerClose = $('<button />').addClass('close').attr('type', 'button').attr('data-dismiss', 'modal').html('&times;').appendTo(headerFrame);
    var bodyFrame = $('<div />').addClass('modal-body').append(options.content).appendTo(inner);
    if (options.reformat) {
        bodyFrame.find('code').css('display', 'block').css('background', 'none');
        bodyFrame.find('pre').css('font-size', 'unset').css('line-height', 'unset');
    }

    // Ensure modal dialogs are layered correctly
    modal.on('show.bs.modal', function () {
        if (options.open)
            options.open();
    });
    modal.on('hide.bs.modal', function () {
        if (!modal.closing && options.cancel)
            options.cancel();
    });
    modal.on('hidden.bs.modal', function () {
        modal.remove();
    });

    // Display the popup
    modal.modal({
        //draggable: (typeof (options.canDrag) !== 'undefined') ? options.canDrag == true : false,
        //resizable: (typeof (options.canMove) !== 'undefined') ? options.canMove == true : false,
        modal: (typeof (options.isModal) !== 'undefined') ? options.isModal == true : true,
        keyboard: false,
        backdrop: 'static'
    });

    // Default to draggable - this causes no particular problems
    if (typeof (options.canDrag) === 'undefined' || options.canDrag) {
        inner.draggable({
            handle: ".modal-header",
            containment: "document"
        })
    }
    // OJH 17/05/18 This has some side effects, so leaving it out for now. More work needed...
    //if (options.canMove) {
    //    inner.resizable({
    //        handles: "e, w, s, se, sw" //,
    //        //start: function (e) { options.content[0].isResizing = true; },
    //        //stop: function (e) { options.content[0].isResizing = false; }
    //    });
    //}

    // Ensure modal backdrops render to the main window.
    var count = $(window.top.document.body).find('.modal.show').length;
    var index = 2000 + (10 * count);
    modal.css('z-index', index);
    $('.modal-backdrop').appendTo(window.top.document.body).not('.modal-stack').css('z-index', index - 1).addClass('modal-stack');

    return popup;
};
consensus.web.popupFrame = function (options) {

    var open = options.open;
    var modal;
    options.open = null;
    options.defer = true;
    options.content = $('<iframe />').attr('scrolling', 'no').css({ border: 0, boxSizing: 'border-box', padding: 0, height: 0, width: '100%' });
    options.width = options.width || 'auto';
    options.content[0].onload = function () {
        if (typeof (options.content.attr('src')) != 'undefined') {

            // Initialise the popup
            var document = options.content[0].contentWindow.document;
            var metaWidth = $(document.head).find('meta[name="consensus-popup-width"]').attr('content');
            var metaTitle = $(document.head).find('meta[name="consensus-popup-title"]').attr('content');

            // Ensure popup height is modified when content changes
            var watch = new MutationObserver(function (mutations, observer) {
                if (!options.content[0].isResizing) {
                    options.content[0].isResizing = true;
                    setTimeout(function () {
                        var modal = options.content.parents('.modal');
                        // OJH 03-10-17 Reapply change to limit dialog hight - it can't be bigger than the root window.
                        /* Taking this out for now - there is something preventing it scrolling smoothly, particularly when clicking the scroll bar rather than using the mouse wheel.
                        var $popupContent = options.content[0].contentWindow.$(".consensus-popup-body")
                        if ($popupContent.hasClass("consensus-popup-body-scroll")) {
                            $popupContent.removeClass("consensus-popup-body-scroll").css("height", "");
                        }
                        var height = document.body.scrollHeight;
                        if ($popupContent.length > 0) {
                            var maxHeight = $(window.parent.parent.parent).innerHeight() - 200; // assuming a limited degree of nesting - window.parent.parent.parent will generally be the root window
                            if (height > maxHeight) {
                                height = maxHeight;
                                $popupContent.css({ height: height - 50 }).addClass("consensus-popup-body-scroll");
                            }
                        }
                        options.content.animate({ height: height }, 100);
                        */
                        options.content.animate({ height: document.body.scrollHeight }, 100);
                        options.content[0].isResizing = false;
                        modal.data('bs.modal')["_isTransitioning"] = false;
                    }, 100);
                }
            });
            options.content[0].contentWindow.onbeforeunload = function () {
                watch.disconnect();
            }
            watch.observe(options.content[0].contentWindow.document, {
                childList: true, subtree: true, attributes: true
            });

            // Initialise the popup content
            if (open != null)
                open.call(options.content[0].contentWindow);
            if (typeof (options.content[0].contentWindow.initPopup) == 'function')
                options.content[0].contentWindow.initPopup();

            // Define the function for handling a result fromt the popup window
            options.content[0].contentWindow.closePopup = function (result) {
                var modal = options.content.parents('.modal');
                modal.data('bs.modal')["_isTransitioning"] = false;
                modal.closing = (typeof (result) != 'undefined');
                modal.modal('hide');
                if (modal.closing && options.result)
                    options.result(result);
            };

            // Display the popup
            modal.css('width', metaWidth || options.width || 'auto');
            modal.css('margin', metaWidth ? '' : '0 50px');
            modal.find('.modal-title').text(options.title || metaTitle || consensus.name);
            modal.show();
            setTimeout(function () {
                options.content.animate({ height: document.body.scrollHeight }, 100);
            }, 50);
        }
    };
    modal = consensus.web.popup(options).hide();
    options.content.attr('src', options.url + (options.url.indexOf('?') == -1 ? '?' : '&') + 'consensusframe=1');
};
consensus.web.popupField = function (group, options) {
    var closure = this;
    this._opening = false;
    this._options = options;
    this._groupElement = typeof (group) == 'string' ? $('#' + group) : group;
    this._fieldElement = this._groupElement.find('#' + this._groupElement.attr('id') + 'Field');
    this._valueElement = this._groupElement.find('#' + this._groupElement.attr('id') + 'Value');
    this._hLinkElement = this._groupElement.find('a.consensus-input-link');
    this._popupElement = this._groupElement.find('span.input-group-addon .icons8-search').parent();
    this._fieldElement.on('change', function () {
        if (closure._fieldElement.val() == '')
            closure.setValue(null);
        else if (!closure._opening)
            closure.openPopup(closure._fieldElement.val());
    });
    this._fieldElement.on('keydown', function (e) {
        if (e.which == 13 && !closure._opening) {
            e.preventDefault();
            e.stopPropagation();
            closure._opening = true;
            $(e.target).blur();
            closure.openPopup(closure._fieldElement.val());
        }
    });
    this._popupElement.on('click', function () {
        if (!closure._opening && !closure._popupElement.is('[disabled=disabled]'))
            closure.openPopup();
    });
    this._updateIcon = function (icon) {
        closure._popupElement.find('[class^="icons8-"], [class*=" icons8-"]')
          .removeClass(function (index, className) {
              return (className.match(/(^|\s)icons8-\S+/g) || []).join(' ');
          }).removeClass('icon-spin').addClass(icon);
    };
    this._current = {
        value: this._valueElement.val(),
        text: this._fieldElement.val(),
        data: null
    };
    this.getData = function () {
        return closure._current.data;
    };
    this.getText = function () {
        return closure._current.text;
    };
    this.getValue = function () {
        return closure._current.value;
    };
    this.setValue = function (value, text, data, fireOnChange) {
        var isChanging = (value || '') != (this.getValue() || '');
        closure._current.value = typeof (value) == 'undefined' ? '' : value;
        closure._current.text = typeof (text) == 'undefined' ? null : text;
        closure._current.data = typeof (data) == 'undefined' ? null : data;
        closure._fieldElement.val(closure._current.text);
        closure._valueElement.val(closure._current.value);
        if (closure._hLinkElement.length != 0) {
            this._hLinkElement.attr('href', consensus.data.substitute(closure._current, closure._groupElement.attr('consensus-input-link'))).text(text);
        }
        if ((isChanging || fireOnChange) && closure._options.onChange)
            closure._options.onChange.call(closure);
    };
    this.openPopup = function (searchText) {
        closure._opening = true;
        closure._updateIcon('icons8-refresh icon-spin');
        var current = jQuery.extend(true, {}, closure._current);
        var url = closure._options.url;
        if (typeof (searchText) != 'undefined' && searchText != null && searchText != '')
            url += (url.indexOf('?') == -1 ? '?' : '&') + 'search=' + searchText;
        for (var i = 0; i < closure._options.filters.length; i++) {
            var filter = closure._options.filters[i];
            if (filter.control && filter.control.length != 0)
                if (window[filter.control] instanceof consensus.web.popupField)
                    url += (url.indexOf('?') == -1 ? '?' : '&') + filter.parameter + 'Id=' + window[filter.control].getValue() + '&' + filter.parameter + 'Text=' + window[filter.control].getText();
                else
                    url += (url.indexOf('?') == -1 ? '?' : '&') + filter.parameter + '=' + $(window[filter.control]).val();
            else if (filter.value && filter.value != 0)
                url += (url.indexOf('?') == -1 ? '?' : '&') + filter.parameter + '=' + filter.value;
        }
        url += (url.indexOf('?') == -1 ? '?' : '&') + 'search-buttons=' + (closure.getValue() && closure.getValue().length != 0 ? 3 : 1).toString();
        consensus.web.popupFrame({
            url: url,
            open: function () {
                closure._updateIcon('icons8-search');
                closure._opening = false;
            },
            cancel: function () {
                closure.setValue(current.value, current.text, current.data);
            },
            result: function (result) {
                result = (typeof (result) == 'string') ? { command: result } : result;
                switch (result.command) {
                    case 'clear': closure.setValue(null); break;
                    case 'select': closure.setValue(result.value, result.text, result.data, result.fireOnChange); break;
                }
            }
        });
    };
};