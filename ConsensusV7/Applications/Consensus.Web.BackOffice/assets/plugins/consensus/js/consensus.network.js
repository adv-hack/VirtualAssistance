var consensus = consensus || {};

// Network
consensus.network = consensus.network || {};
consensus.network.send = function (options) {
	jQuery.ajax({
		async: options.async !== false,
		converters: {
			"text json": function (data) { return $.parseJSON(data, true); }
		},
		contentType: 'application/json',
		data: options.data ? JSON.stringify(options.data) : null,
		dataType: options.dataType || 'json',
		success: function (result) {
			result = typeof (result) == 'undefined' ? null : result;
			if (options.success)
				options.success(result);
		},
		error: function (request, status, text) {
		    var shown = false;
		    if (options.error) {
		        if (options.error(request) === true)
    		        shown = true;
		    }
		    else if (consensus.showErrors) {
		        var isErrorPage = (request.responseText.toLowerCase().indexOf("<!doctype") >= 0);
		        if (isErrorPage) {
		            var isPopupFormat = (request.responseText.toLowerCase().indexOf("body class=\"consensus-popup") >= 0);
		            if (isPopupFormat) {                        
		                consensus.web.popup({
		                    title: request.statusText,
		                    content: $('<div />').html(request.responseText),
		                    reformat: true
		                });
		                shown = true;
		            }
		        }
		    }
		    if (!shown) {
		        switch (request.status) {
		            case 400: alert('Error', request.statusText, 'info', 4000); break;
		            case 401: alert('Not Authorised', 'The requested page could not be accessed.<br/>Please contact your administrator for support', 'error'); break;
		            case 404: alert('Not Found', 'The requested page could not be found.<br/>Please contact your administrator for support', 'error'); break;
		            case 405: alert('Not Supported', 'The requested action is not supported.<br/>Please contact your administrator for support', 'error'); break;
		            case 500: alert('Server Error', 'An internal server error has occurred.<br/>Please contact your administrator for support', 'error'); break;
		            default: alert('Error', 'An unknown error has occurred.<br/>Please contact your administrator for support', 'error'); break;
		        }
		    }
		},
		method: options.method || 'put',
		url: consensus.resolveUrl('~/rest/' + options.url) + (options.success ? "" : (options.url.indexOf("?") >= 0 ? "&" : "?") + "GoToDepth=None"), // If there's no "success" method, don't bother returning anything.
		xhrFields: { withCredentials: true },
	});
};
consensus.network.appendUrl = function (param, value) {
	var params = window.location.search.split('&');
	var target = window.location.protocol + '//' + window.location.host + window.location.pathname + '?';
	var update = false;
	for (var i = 0; i < params.length; i++) {
		var name = params.split('=')[0];
		var data = params.split('=')[1];
		target += name + '=' + (name == param ? value : data) + (i < params.length - 1 ? '&' : '');
		update = update || name == param;
	}
	window.location = target + (update ? '' : '&' + param + '=' + value);
};