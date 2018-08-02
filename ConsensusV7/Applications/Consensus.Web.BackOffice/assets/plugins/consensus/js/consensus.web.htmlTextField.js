var consensus = consensus || {};
consensus.web = consensus.web || {};

consensus.web.htmlTextField = function (group, options) {
    var closure = this;
    this._options = options;
    this._groupElement = typeof (group) == 'string' ? $('#' + group) : group;
    this._fieldElement = this._groupElement.find('#' + this._groupElement.attr('id') + 'Field');

    $(document).ready(function () {
        var editorHeight = 250;
        var cssGroupHeight = closure._groupElement[0].style.height;
        if (cssGroupHeight && cssGroupHeight.indexOf("px") > 0) {
            cssGroupHeight = parseInt(cssGroupHeight);
            if (!isNaN(cssGroupHeight)) {
                editorHeight = cssGroupHeight - 90;
            }
        }

        closure._fieldElement.hide();
        closure._fieldElement.summernote({
            height: editorHeight,
            //fontNames: ['Arial', 'Arial Black', 'Comic Sans MS', 'Courier New'],
            //fontNamesIgnoreCheck: ['Arial', 'Arial Black', 'Comic Sans MS', 'Courier New'],
            toolbar: [
                ['edit', ['undo', 'redo']],
                ['font', ['bold', 'underline', 'italic', 'clear', 'fontsize']],
                //['fontname', ['fontname']], // Was giving errors. Now works on main screens, but finds no fonts when in a popup. I give up. The fonts weren't that interesting anyway.
                ['color', ['color']],
                ['para', ['ul', 'ol', 'style', 'paragraph', 'height']],
                ['table', ['table', 'hr']],
                ['insert', ['link', 'picture']],
                ['view', ['fullscreen', 'codeview', 'help']]
            ]
        });

        if (options.disabled) {
            closure._fieldElement.summernote('disable');
        }

        //closure._fieldElement.on('summernote.change', function (we, contents, $editable) {
        //    closure._fieldElement.value = contents;
        //});
    });
};