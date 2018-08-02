
// Core methods and properties in the consensus namespace, plus general $(document).ready handler and other web UI utilities.

var consensus = consensus || {};
consensus.name = 'OpenLMS';
consensus.siteRoot = null;
consensus.showErrors = false;
consensus.resolveUrl = function (url) {
    if (url.substr(0, 1) == '~') {
        url = url.substr(1, url.length - 1);
        if (url.substr(0, 1) == '/' && consensus.siteRoot.substr(consensus.siteRoot.length - 1, 1) == '/')
            url = url.substr(1, url.length - 1);
        url = consensus.siteRoot + url;
    }
    return url;
}


$(document).ready(function () {
    $('[data-provide=bootstrapswitch]').bootstrapSwitch();
    $('[data-provide=datepicker]').on('changeDate', function () {
        $(this).datepicker('hide');
    });
    $('.consensus-input input:not([type=checkbox]), .consensus-input select, .consensus-input textarea').on('blur', function () { consensus.data.validation.check(this); });
    $('.consensus-input input:not([type=checkbox]), .consensus-input select, .consensus-input textarea').on('change', function () { consensus.data.validation.check(this); });
    $('.consensus-input input[type=checkbox]').on('click', function () { consensus.data.validation.check(this); });
    $('.bootstrap-switch').addClass('consensus-bootstrap-switch');
    $('.bootstrap-switch').on('switchChange.bootstrapSwitch', function (event, state) {
        var onchange = $(this).find('input[type=checkbox]').attr('onclick');
        return onchange ? eval(onchange) : true;
    });
    $('a[data-toggle="tab"]').on('shown.bs.tab', function (e) {
        for (var i = 0; i < window.consensus.web.dataTable.all.length; i++)
            if (window.consensus.web.dataTable.all[i]._tableElement.parents($(e.target).attr('href')).length != 0)
                window.consensus.web.dataTable.all[i]._tableElement.dataTable().fnAdjustColumnSizing();
    });

    $('[data-scroll-to]').on('click', function () {
        var target = $(this).attr('data-scroll-to');
        var offset = $(target).offset().top;
        var header = $('main').offset().top;
        var result = offset >= header ? offset - header : 0;
        $('html, body').animate({ scrollTop: result });
    });
    setTimeout(function () {
        if ($(window.document).find('form:not(iframe *)').attr('data-mode') === 'edit')
            $(window.document).find('.bootstrap-switch-container:not(iframe *)').addClass('enable-transition');
    }, 0);
});

window.alert = function (title, text, type, timeout) {
    var options = { confirmButtonText: 'OK', confirmButtonClass: 'btn btn-primary', buttonsStyling: false };
    options.html = (arguments.length == 1) ? title : text;
    options.title = (arguments.length == 1) ? 'Information' : title;
    options.type = type || 'info';
    options.timer = !timeout ? 5000 : timeout > 0 ? timeout : undefined;
    window.top.swal.call(window.top, options);
};