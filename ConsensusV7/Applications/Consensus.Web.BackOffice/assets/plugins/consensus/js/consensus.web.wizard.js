var consensus = consensus || {};
consensus.web = consensus.web || {};

consensus.web.wizard = function (options) {
    var closure = this;
    this._element = $('#' + options.element);
    this._header = this._element.find('header > *');
    this._nextButton = this._element.find('footer .btn-primary');
    this._backButton = this._element.find('footer .btn-default');
    this._undoButton = this._element.find('footer .btn-warning');
    this._pages = this._element.find('main > div');
    this._element.parents('body.consensus-popup').find('.popup-footer').hide();
    this._backButton.on('click', function () { closure.back(); return false; });
    this._nextButton.on('click', function () { closure.next(); return false; });
    this._undoButton.on('click', function () { window.closePopup(null); return false; });
    this._page = 0;
    this._init = function (preventTransition) {

        // Determine the first and last pages that are visible.
        var minPage = 0;
        var maxPage = closure._pages.length - 1;
        while (minPage < closure._pages.length && $(closure._header[minPage]).hasClass('hidden'))
            minPage += 1;
        while (maxPage >= 0 && $(closure._header[maxPage]).hasClass('hidden'))
            maxPage -= 1;

        // Set the disabled state for the next and back buttons.
        this._backButton.attr('disabled', closure._page > minPage ? null : 'disabled');
        this._nextButton.find('.text').text(closure._page < maxPage ? 'Next' : 'Finish');
        this._nextButton.find('*[class^=icons8]').attr('class', closure._page < maxPage ? 'icons8-arrows_long_right' : 'icons8-checkmark');

        // Hide all pages, except the current page.
        closure._pages.addClass('hidden');
        $(closure._pages[closure._page]).removeClass('hidden');

        // Stylise the header to show current progress.
        for (var i = 0; i < closure._header.length; i++) {
            $(closure._header[i]).toggleClass('no-transition', preventTransition);
            $(closure._header[i]).toggleClass('current', i == closure._page);
            $(closure._header[i]).toggleClass('complete', i < closure._page);
            setTimeout(function () { $(closure._header[i]).toggleClass('no-transition', !preventTransition) }, 0);
        }
    }
    this._getNextPage = function () {
        var nextPage = closure._page + 1;
        while (nextPage < closure._pages.length && $(closure._header[nextPage]).hasClass('hidden'))
            nextPage += 1;
        if (nextPage >= closure._pages.length)
            nextPage = closure._page;
        return nextPage;
    };
    this._getBackPage = function () {
        var backPage = closure._page - 1;
        while (backPage > 0 && $(closure._header[backPage]).hasClass('hidden'))
            backPage -= 1;
        if (backPage < 0)
            backPage = closure._page;
        return backPage;
    };
    this.hideProgress = function (showFooter) {
        this._element.find('main').show();
        this._element.find('footer').toggle(showFooter);
        this._element.find('.wizard-indicator').remove();
    };
    this.showProgress = function (message, type, complete) {
        this._element.find('main').hide();
        this._element.find('footer').toggle(type != 'info');
        this._element.find('footer .btn-warning').toggle(!complete);
        this._element.find('footer .btn-default').toggle(!complete);
        this._element.find('footer .btn-primary').toggle(type == 'success');
        this._element.find('.wizard-indicator').remove();

        var indicator = $('<div />').addClass('wizard-indicator').addClass('text-center').insertAfter(this._element.find('header'));
        switch (type) {
            case 'info':
                var spinner = $('<div />').addClass('wizard-indicator-spinner').appendTo(indicator);
                $('<div />').appendTo(spinner);
                $('<label />').text(message).appendTo(spinner);
                break;
            case 'success':
                var icon = $('<div />').addClass('swal2-icon swal2-success swal2-animate-success-icon').appendTo(indicator);
                $('<div />').addClass('swal2-success-circular-line-left').appendTo(icon);
                $('<div />').addClass('swal2-success-line-tip swal2-animate-success-line-tip').appendTo(icon);
                $('<div />').addClass('swal2-success-line-long swal2-animate-success-line-long').appendTo(icon);
                $('<div />').addClass('swal2-success-ring').appendTo(icon);
                $('<div />').addClass('swal2-success-fix').appendTo(icon);
                $('<div />').addClass('swal2-success-circular-line-right').appendTo(icon);
                $('<label />').text(message).appendTo(indicator);
                break;
            case 'error':
                var iconOuter = $('<div />').addClass('swal2-icon swal2-error swal2-animate-error-icon').appendTo(indicator);
                var iconInner = $('<div />').addClass('swal2-x-mark swal2-animate-x-mark').appendTo(iconOuter);
                $('<div />').addClass('swal2-x-mark-line-left').appendTo(iconInner);
                $('<div />').addClass('swal2-x-mark-line-right').appendTo(iconInner);
                $('<label />').text(message).appendTo(indicator);
        }
    };
    this.dropProgress = function (progress) {
        if (progress.remove().length == 1 && this._element.find('.wizard-indicator').length == 0) {
            this._element.find('main').show();
            this._element.find('footer .btn-primary').show();
        }
    }
    this.back = function () {
        var state = consensus.data.getState();
        if (state && state._getWindow() && state._getWindow().Page_Validators) {
            jQuery.each(state._getWindow().Page_Validators, function (index, element) {
                if (jQuery.contains(closure._pages[closure._page], element)) {
                    $('#' + element.controltovalidate).parents('.consensus-input').removeClass('has-error').removeClass('has-warning');
                    element.isready = false;
                    element.isvalid = true;
                    window.ValidatorUpdateDisplay(element);
                }
                if (state._getWindow().Page_ValidationSummaries.length != 0) {
                    $(state._getWindow().Page_ValidationSummaries[0]).slideUp(500, function () {
                        state._getWindow().Page_ValidationSummaries[0].innerHTML = '';
                    });
                }
            });
            state.toggleSave(null);
        }
        var page = closure._getBackPage();
        if (page != closure._page) {
            var progress = this._element.find('.wizard-indicator');
            if (!closure.onBack || typeof (closure.onBack) !== 'function' || closure.onBack.call(closure, closure._page, page) === true) {
                closure.dropProgress(progress);
                closure._page = page;
                closure._init(false);
            }
        }
    };
    this.next = function () {
        var validation = consensus.data.validation.check(null, closure._pages[closure._page]);
        if (validation.formErrors == 0 && validation.pageErrors == 0) {
            var page = closure._getNextPage();
            if (page != closure._page) {
                var progress = this._element.find('.wizard-indicator');
                if (!closure.onNext || typeof (closure.onNext) !== 'function' || closure.onNext.call(closure, closure._page, page) === true) {
                    closure.dropProgress(progress);
                    closure._page = page;
                    closure._init(false);
                }
            } else {
                if (!closure.onFinish || typeof (closure.onFinish) !== 'function' || closure.onFinish.call(closure) === true)
                    window.closePopup(null);
            }
        }
    };
    this.onNext = null;
    this.onBack = null;

    consensus.data.setState(new consensus.data.state(this._nextButton, {}, window));
    this._init(true);
};