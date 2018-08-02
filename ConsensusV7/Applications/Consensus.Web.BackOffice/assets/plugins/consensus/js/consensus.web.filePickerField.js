var consensus = consensus || {};
consensus.web = consensus.web || {};

consensus.web.filePickerField = function (group, options) {
    var closure = this;
    this._options = options;
    this._hidValue = $("#" + group + "Field");
    this._group = $("#" + group);
    this._group.removeClass("hidden"); // TODO - prevent the server from setting this...
    this._callback = $.noop;
    this._createdIds = [];

    // From the fine-uploader docs:
    // The path to these placeholder images must be specified in the set of options you pass Fine Uploader. These are only needed if you make use of the thumbnail preview feature:
    // fine-uploader/placeholders/not_available-generic.png
    // fine-uploader/placeholders/waiting-generic.png
    // We are not currently using them...
    
    this._group.fineUploader({
        debug: true,
        multiple: false,
        autoUpload: false,
        request: {
            endpoint: 'file/' + options.url,
            params: options.params
        },
        //deleteFile: {
        //    enabled: true,
        //    endpoint: 'file/' + options.url
        //},
        retry: {
            enableAuto: true
        },
        //form: {
        //    element: $(document.forms[0]),
        //    autoUpload: false
        //},
        dragAndDrop: {
            extraDropzones: [ $(document.body) ]
        },
        callbacks: {
            onSubmit: function (id, name) {
                // Called when the item has been selected and is a candidate for uploading.
                closure._hidValue.val(name);
            },
            onUpload: function (data, buttonContainer) {
                // Called just before an item begins uploading to the server
                // Reset the name, in case it has been edited (there is no afterEdit event)
                closure._hidValue.val(data.name);
                anyErrors = false;
            },
            onCancel: function (id, name) {
                // Called when the item has been cancelled
                closure._hidValue.val("");
            },
            onComplete: function (id, name, responseJSON, xhr) {
                if (responseJSON.success) {
                    closure._createdIds.push(responseJSON.DataId);
                }
            },
            onAllComplete: function (succeeded, failed) {
                if (!failed || !failed.length) {
                    if ($.isFunction(closure._callback))
                        closure._callback(closure._createdIds);
                    this._callback = $.noop;
                }
            },
            onError: function (id, name, errorReason, xhr) {
                setImmediate(function () {
                    $(".qq-file-id-" + id + " .qq-upload-status-text-selector").text(errorReason);
                });
            }
            //onComplete: function (id, name, responseJSON, xhr) {
            //    $.each(responseJSON.files, function (ix, file) {
            //        if (file.error) {
            //            anyErrors = true;
            //            alert(file.error);

            //            var uploads = closure._group.fineUploader("getUploads");
            //            $each(uploads, function (iX, upload) {
            //                if (upload.name == file.name) {
            //                    file.fineId = upload.id;
            //                    return false;
            //                }
            //            })
            //            if (file.fineId)
            //                closure._group.fineUploader("setStatus", file.fineId, qq.status.FAILED);
            //        }
            //    });
            //}
        }
    });

    this.SaveFiles = function (callback) {
        closure._callback = callback;
        closure._group.fineUploader("uploadStoredFiles");
    }
       

};