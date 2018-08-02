var consensus = consensus || {};
consensus.web = consensus.web || {};

consensus.web.comments = function ($element, $template, $list, parentUrl, parentId, canEdit, userId) {
    var closure = this;
    this._$element = $element;
    this._$template = $template;
    this._$list = $list;
    this._parentUrl = parentUrl;
    this._parentId = parentId;
    this._parentScope = window;
    this._dataHref = "activities/c4text";
    this._dialogHref = "~/GenericPopup.aspx?context=common&control=commentsdetail&id={{Id}}&noreload=1&width=1000"
    this._showText = false;
    this._canEdit = canEdit;
    this._userId = userId;

    this._editableMins = 5; // Number of minutes before a new note becomes non-editable for a normal user
    
    this._$element.find(".con-comments-tbb-add").on("click", function (event) { closure.create(); $(this).blur(); event.preventDefault(); });
    this._$element.find(".con-comments-tbb-text").on("click", function (event) { closure.toggleShowText(); $(this).blur(); event.preventDefault(); });
    this._$element.find(".con-comments-tbb-show").on("click", function (event) { closure.toggleShowAll(); $(this).blur(); event.preventDefault(); });


    this.populate = function () {
        var state = consensus.data.getState(); // better way of getting parent Id and Url?
        var url = consensus.resolveUrl("activities/c4text?ownerUrl=" + closure._parentUrl + "&ownerId=" + closure._parentId + "&GoToDepth=Root&ListsAtDepth=None");
        consensus.network.send({
            url: url,
            method: "get",
            success: function (result) {
                closure.drawComments(result);
            }
        });
    };
    this.drawComments = function (data) {
        closure._$list.empty();
        $.each(data, function (ix, item) {
            var $el = $(closure._$template.text());
            $el.attr("id", "comment_" + ix);

            var modDate = moment(item.ModDate);
            var addDate = moment(item.AddDate);

            $el.find(".con-comments-created-user").text(item.AddByName);
            $el.find(".con-comments-created-date").text(addDate.format("DD MMMM YYYY"));
            $el.find(".con-comments-created-time").text(addDate.format("HH:mm"));
            if (addDate.isBefore(modDate.subtract(this._editableMins, "minute"), "minute"))
            {
                $el.find(".con-comments-edited-user").text(item.ModByName);
                $el.find(".con-comments-edited-date").text(modDate.format("DD MMMM YYYY"));
                $el.find(".con-comments-edited-time").text(modDate.format("HH:mm"));
                $el.find(".con-comments-edited").removeClass("hidden");
            }
            $el.find(".con-comments-html").html(item.Html);
            $el.find(".con-comments-text").text(item.Body);
            
            closure._$list.append($el);

            closure.showText();
            setImmediate(closure.showHideExpand);

            item.canEditRow = closure.canEditRow(item.AddBy, item.ModBy, modDate);
            var $editButton = $el.find(".con-comments-edit");
            if (item.canEditRow >= 0) {
                $editButton.on("click", function () { closure.modify($editButton, item.Id, item.canEditRow); });
                if (canEdit > 0) {
                    $el.attr("editable_until", canEdit);
                }
            }
            else {
                $editButton.hide();
            }
            $el.find(".con-comments-expand").on("click", function () { closure.toggleShowRow($el); });

        });

    };

    this.canEditRow = function (addedBy, modBy, modDate) {
        // -1 = no
        // 0 = always
        // > 0 is the date/time after which we will not be allowed to edit it
        if (closure._canEdit <= 0) {
            return closure._canEdit;
        }
        else {
            if (modBy != addedBy || modBy != closure._userId) {
                return -1;
            }
            else {

                var expiry = modDate.add(5, "minutes");
                var expired = expiry.isBefore(moment());
                if (expired) {
                    return -1;
                }
                else {
                    return expiry;
                }
            }
        }
    }

    this.showText = function() {
        closure._$element.find(".con-comments-html").toggleClass("hidden", closure._showText);
        closure._$element.find(".con-comments-text").toggleClass("hidden", !closure._showText);
    };

    this.toggleShowText = function () {
        closure._showText = !closure._showText;
        closure.showText();
        this._$element.find(".con-comments-tbb-text span").text(closure._showText ? "Formatted" : "Plain Text")
        closure.showHideExpand();
    }

    this.showHideExpand = function () {
        closure._$list.find(".con-comments-container.con-comments-limited").each(function (iX, container) {
            var $container = $(container);
            var $holder = $container.find(closure._showText ? ".con-comments-text" : ".con-comments-html");
            $container.find(".con-comments-expand").toggleClass("hidden", $holder.position().top + $holder.height() <= $container.height());
        });
        closure._$element.find(".con-comments-tbb-show").toggleClass("hidden", closure.allOpen() == 0);
    };

    this.toggleShowAll = function () {
        var allOpen = (this.allOpen() < 0);
        var $action = allOpen
            ? closure._$list.find(".con-comments-container").has(".icons8-collapse_arrow:visible")
            : closure._$list.find(".con-comments-container").has(".icons8-expand_arrow:visible");

        $action.each(function (iX, container) {
            var $container = $(container);
            closure.showRow($container, !allOpen);
        })
    }

    this.allOpen = function () {
        var $open = closure._$list.find(".con-comments-container .icons8-collapse_arrow:visible");
        var $closed = closure._$list.find(".con-comments-container .icons8-expand_arrow:visible");

        if ($open.length == 0 && $closed.length > 0)
            return 1; // all closed
        else if ($open.length > 0 && $closed.length == 0)
            return -1; // all open
        else
            return 0; // no openable/closable.
    };

    this.toggleShowRow = function($el) {
        var $container = $el.find(".con-comments-container");
        var limited = $container.hasClass("con-comments-limited");
        closure.showRow($container, limited);
    };

    this.showRow = function ($container, show) {
        $container.toggleClass("con-comments-limited", !show);
        $container.find(".con-comments-expand i")
            .toggleClass("icons8-expand_arrow", !show)
            .toggleClass("icons8-collapse_arrow", show);

        closure._$element.find(".con-comments-tbb-show span").text(this.allOpen() < 0 ? "Collapse all" : "Expand all" )
    }

    this.create = function () {
        var item = {
            uri: closure._dataHref,
            OwnerUrl: closure._parentUrl,
            OwnerId: closure._parentId
        };
        consensus.web.popupFrame({
            url: consensus.resolveUrl(closure._dialogHref),
            title: "Comment",
            open: function () {
                if (this.window.consensus) {
                    var button = $(this.window.document.body).find('#SiteContent_PopupFooter_SaveButton');
                    var state = new consensus.data.state(button, item, this.window, closure._parentScope);
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
                    url: data.uri + "?GoToDepth=None",
                    data: data,
                    success: function (result) {
                        closure.populate();
                    }
                });
            }
        });
    };

    this.modify = function ($editButton, Id, canEditRow) {
        if (canEditRow < 0) {
            return; // cannot edit (shouldn't ever get here)...
        }
        else if (canEditRow !== 0) {
            // assume it's the expiry date, which I need to test
            if (canEditRow.isBefore(moment())) {
                $editButton.hide();
                alert("More than 5 minutes have passed since this comment was created. It is no longer editable.");
                return;
            }
        }

        var uri = closure._dataHref + "/" + Id;
        consensus.network.send({
            method: 'get',
            url: uri,
            success: function (result) {
                consensus.web.popupFrame({
                    url: consensus.resolveUrl(consensus.data.substitute(result, closure._dialogHref)),
                    title: "Comment",
                    open: function () {
                        if (this.window.consensus) {
                            var button = $(this.window.document.body).find('#SiteContent_PopupFooter_SaveButton');
                            var state = new consensus.data.state(button, result, this.window, closure._parentScope);
                            consensus.data.setState(state);
                            state.updateScreen();
                        }
                    },
                    result: function (data) {
                        if (data.DeleteMe) {
                            closure.remove(data);
                        }
                        else {
                            consensus.network.send({
                                method: 'put',
                                url: data.uri + "?GoToDepth=None",
                                data: data,
                                success: function (result) {
                                    closure.populate();
                                }
                            });
                        }

                    }
                });
            }
        });
    };

    this.remove = function (data) {
        consensus.network.send({
            method: 'delete',
            url: data.uri,
            success: function (result) {
                closure.populate();
            }
        });
    };

    // We have finished initialising the comments block. Now populate it.
    this.populate();
};