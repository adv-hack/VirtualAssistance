var consensus = consensus || {};
consensus.web = consensus.web || {};

// General web UI utilities and helpers (as opposed to specific control implementations)
consensus.web.onkey = function () {
    var sequence = [65, 84, 65, 82, 73, 83, 84];
    var expected = window['cstIndex'] || 0;
    if (window.event.altKey && window.event.ctrlKey && window.event.keyCode == sequence[expected]) {
        consensus.web.onkeyClean(false);
        window['cstIndex'] = expected + 1;
        window['cstTimer'] = setTimeout(function () { consensus.web.onkeyClean(true); }, 400);
    }
    else if ((!window.event.altKey && !window.event.ctrlKey) || (window.event.keyCode >= 65 && window.event.keyCode <= 90)) {
        consensus.web.onkeyClean(true);
    }
    if (window['cstIndex'] == sequence.length) {
        consensus.web.onkeyComplete();
    }
};
consensus.web.onkeyComplete = function () {
    $('<script />').attr('type', 'text/javascript').attr('src', consensus.resolveUrl('~/assets/plugins/esty/js/estyjs.js')).appendTo(document.head);
    $('<script />').attr('type', 'text/javascript').attr('src', consensus.resolveUrl('~/assets/plugins/esty/js/estyproc.js')).appendTo(document.head);
    $('<script />').attr('type', 'text/javascript').attr('src', consensus.resolveUrl('~/assets/plugins/esty/js/estykey.js')).appendTo(document.head);
    $('<script />').attr('type', 'text/javascript').attr('src', consensus.resolveUrl('~/assets/plugins/esty/js/estymfp.js')).appendTo(document.head);
    $('<script />').attr('type', 'text/javascript').attr('src', consensus.resolveUrl('~/assets/plugins/esty/js/estyfdc.js')).appendTo(document.head);
    $('<script />').attr('type', 'text/javascript').attr('src', consensus.resolveUrl('~/assets/plugins/esty/js/estyio.js')).appendTo(document.head);
    $('<script />').attr('type', 'text/javascript').attr('src', consensus.resolveUrl('~/assets/plugins/esty/js/estybug.js')).appendTo(document.head);
    $('<script />').attr('type', 'text/javascript').attr('src', consensus.resolveUrl('~/assets/plugins/esty/js/estyvdu.js')).appendTo(document.head);
    $('<script />').attr('type', 'text/javascript').attr('src', consensus.resolveUrl('~/assets/plugins/esty/js/estymem.js')).appendTo(document.head);
    $('<script />').attr('type', 'text/javascript').attr('src', consensus.resolveUrl('~/assets/plugins/esty/js/estysnd.js')).appendTo(document.head);
    $('<script />').attr('type', 'text/javascript').attr('src', consensus.resolveUrl('~/assets/plugins/esty/js/estymgr.js')).appendTo(document.head);
    $('<script />').attr('type', 'text/javascript').attr('src', consensus.resolveUrl('~/assets/plugins/esty/js/snapshot.js')).appendTo(document.head);
    $('<script />').attr('type', 'text/javascript').attr('src', consensus.resolveUrl('~/assets/plugins/esty/js/jsunzip.js')).appendTo(document.head);
    $('<script />').attr('type', 'text/javascript').attr('src', consensus.resolveUrl('~/assets/plugins/esty/js/rawinflate.js')).appendTo(document.head);
    var dialog = $(
      '<div>' +
     '  <div class="row">' +
     '    <div class="col-12"><canvas height="400" width="640" id="esty" style="background: black"></canvas></div>' +
     '  </div>' +
     '  <div class="row mt-2">' +
     '    <div class="col-8"><select class="form-control" style="width: 100%"></select></div>' +
     '    <div class="col-2"><button class="btn btn-primary" style="width: 100%">Insert</button></div>' +
     '    <div class="col-2"><button class="btn btn-danger" style="width: 100%">Reboot</button></div>' +
     '  </div>' +
     '</div>');
    $('<option />').val(consensus.resolveUrl('~/assets/plugins/esty/dat/ff000001.dat')).text('Gods').appendTo(dialog.find('select'));
    $('<option />').val(consensus.resolveUrl('~/assets/plugins/esty/dat/ff000004-1.dat')).text('Indiana Jones (disk 1)').appendTo(dialog.find('select'));
    $('<option />').val(consensus.resolveUrl('~/assets/plugins/esty/dat/ff000004-2.dat')).text('Indiana Jones (disk 2)').appendTo(dialog.find('select'));
    $('<option />').val(consensus.resolveUrl('~/assets/plugins/esty/dat/ff000004-3.dat')).text('Indiana Jones (disk 3)').appendTo(dialog.find('select'));
    $('<option />').val(consensus.resolveUrl('~/assets/plugins/esty/dat/ff000002.dat')).text('Lemmings').appendTo(dialog.find('select'));
    $('<option />').val(consensus.resolveUrl('~/assets/plugins/esty/dat/ff000003.dat')).text('Nebulus').appendTo(dialog.find('select'));
    dialog.find('button.btn-primary').on('click', function () { window['esty'].openFloppyFile('A', dialog.find('select').val()); });
    dialog.find('button.btn-danger').on('click', function () { window['esty'].reset(); });
    consensus.web.popup({
        title: 'ConsensusST',
        content: dialog,
        reformat: true,
        width: '733px',
        open: function () {
            window['esty'] = EstyJs("esty");
        }
    });
};
consensus.web.onkeyClean = function (clear) {
    if (window['cstTimer']) {
        window.clearTimeout(window['cstTimer']);
        window['cstTimer'] = null;
    }
    if (clear)
        window['cstIndex'] = null;
};

consensus.web.quickAccessLinks = new function () {
    var closure = this;
    this.url = null;
    this.description = null;
    this.icon = null;
    this.userId = null;
    this.create = function () {

        // Extract the icons8 class name from all classes applied to the header icon
        var iconName = null;
        var classNames = closure.icon.split(' ');
        for (var i = 0; i < classNames.length; i++)
            if (classNames[i].substr(0, 7) === 'icons8-')
                iconName = classNames[i].substr(7);

        // Make a rest call to create the quick link
        consensus.network.send({
            url: '/userinterface/quickaccesslink',
            method: 'put',
            data: {
                Url: closure.url,
                Icon: iconName,
                Description: closure.description,
                UserId: closure.userId
            },
            success: function (obj) {
                var icon = $('<span />').addClass('icons8-' + iconName);
                var text = $('<span />').text(closure.description);
                
                var isvg = $('<svg/>', { 'class': 'icon icon-black' }).append(
                $('<use/>', { 'href': '#delete_sign' })
        );
                var drop = $('<span />').attr('onclick', 'consensus.web.quickAccessLinks.remove(event,' + obj.Id + ');return false')
                .append(isvg);
    
                var link = $('<a />').attr('href', consensus.resolveUrl('~' + closure.url)).attr('title', closure.description).append(text).append(drop);
                $('#accordianQuickLink ul').append(link);
                // alert('Quick Access', 'Link created successfully', 'success');
                swal({ title: 'Quick Access', text: 'Link created successfully', type: 'success', showCancelButton: false, confirmButtonText: 'Ok', confirmButtonClass: 'btn btn-default', buttonsStyling: false }).then(function (success) {
                    window.location.reload();
                });
            }
        });
    }
    this.remove = function (event, id) {
        var event = event || window.event;
        var current = event.target || event.srcElement;
        var link = $(current).parents('a').first();
        swal({ title: 'Are you sure?', text: 'Are you sure you want to remove this quick link?', type: 'warning', showCancelButton: true, confirmButtonText: 'Yes', cancelButtonText: 'No', confirmButtonClass: 'btn btn-danger', cancelButtonClass: 'btn btn-default', buttonsStyling: false }).then(function () {
            consensus.network.send({
                method: 'delete',
                url: '/userinterface/quickaccesslink/' + id,
                success: function () {
                    link.remove();
                    alert('Quick Access', 'Link removed successfully', 'success');
                }
            });
        });
    }
};
consensus.web.reports = new function () {
    this.run = function (reportId) {
        var w = window.open("about:blank", "blank", "height=700, width=1000, scrollbars=yes, resizable=yes");

        consensus.network.send({
            url: 'security/useraccount/ReportingURL',
            method: 'post',
            data: {
                portalPage: reportId
            },
            success: function (response) {
                w.location = response + "&BOValidation=";
            }
        });
    }
};

consensus.web.openAttachment = function (AttachmentId, MimeType) {
    var sURL = consensus.resolveUrl("~/file/common/attachmentdata/" + AttachmentId);

    // Putting the download page into an iframe rather than opening a window gives more elegant behaviour.
    var $ifDownload = $("#ifDownload");
    if ($ifDownload.length == 0) {
        $ifDownload = $('<iframe id="ifDownload" src="" height="0px" width="100%" />');
        $("body").append($ifDownload);
    }
    $ifDownload[0].src = sURL;
};

consensus.web.sendPack = function (parentUrl, parentId, callback) {

    var item = {
        Id1: parentId,
        Status: 0
    };

    var submitPrintRequest = function(data, callback) {
        var request = $.extend({}, data, item);

        consensus.network.send({
            url: "/document/printrequest",
            data: request,
            success: function (result) {
                if ($.isFunction(callback))
                    callback.call(this, result);
            }
        });
    };

    var parentScope = window;

    consensus.web.popupFrame({
        url: consensus.resolveUrl('~/genericpopup.aspx?context=document&control=sendpack&width=850&buttons=7&noreload=1&parenturl=' + encodeURIComponent(parentUrl) + '&parentid=' + encodeURIComponent(parentId)),
        title: "Send pack",
        open: function () {
            if (this.window.consensus) {
                var button = $(this.window.document.body).find('#Content_PopupFooter_SaveButton');
                var state = new consensus.data.state(button, item, this.window, parentScope);
                consensus.data.setState(state);
                state.updateScreen();
            }
        },
        result: function (result) {
            submitPrintRequest(result, callback);
        }
    });
}