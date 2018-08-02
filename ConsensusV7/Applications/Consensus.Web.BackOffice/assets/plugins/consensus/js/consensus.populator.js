var consensus = consensus || {};

consensus.populator = function (options) {
    var closure = this;
    this._dataSource = options.dataSource;
    this._sourceType = options.sourceType;
    this._callback = $.isFunction(options.callback) ? options.callback : $.noop;
    this._error = $.isFunction(options.error) ? options.error : $.noop;
    this._beforeRefresh = $.isFunction(options.beforeRefresh) ? options.beforeRefresh : $.noop;
    this._populated = !!options.populated;

    this.refresh = function () {

        if (closure._beforeRefresh() === false)
            return;

        closure._populated = false;

        var body = {
            dataSource: closure._dataSource
        }

        if (closure._dataSource.Serialization) {
            body.serialization = closure._dataSource.Serialization;
            closure._dataSource.Serialization = null;
        }

        consensus.network.send({
            method: 'post',
            async: true,
            url: closure._sourceType + '/RunDataSource',
            data: body,
            success: function (result) {
                if (closure._callback(result) !== false)
                    closure._populated = true;
            },
            error: function (err) {
                return closure._error(err);
            }
        });

    }

    this.setParameters = function (parameters) {
        if (parameters && parameters.length > 0) {
            switch (closure._sourceType.toLowerCase()) {
                case "searches/query":
                    $.each(closure._dataSource.Wheres, function (iW, where) {
                        $.each(parameters, function (iP, param) {
                            if (param.name == where.Correlation && !where.MatchCorrelation) {
                                where.Value = param.value;
                                return false;
                            }
                        });
                    });
                    $.each(closure._dataSource.Joins, function (iJ, join) {
                        $.each(join.Conditions, function (iW, condition) {
                            $.each(parameters, function (iP, param) {
                                if (param.name == condition.Correlation && !condition.MatchCorrelation) {
                                    condition.Value = param.value;
                                    return false;
                                }
                            });
                        });
                    });
                    break;
                case "searches/search":
                case "searches/restcall":
                    $.each(closure._dataSource.Parameters, function (iW, srcParam) {
                        $.each(parameters, function (iP, param) {
                            if (param.name == srcParam.Parameter) {
                                srcParam.Value = param.value;
                                return false;
                            }
                        });
                    });
                    break;
            }
            closure.refresh();
        }
    }

};