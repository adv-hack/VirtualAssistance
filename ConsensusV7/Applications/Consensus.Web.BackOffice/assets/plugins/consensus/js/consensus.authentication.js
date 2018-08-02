var consensus = consensus || {};

// Authentication
consensus.authentication = consensus.authentication || {};
consensus.authentication.authUrl = null;
consensus.authentication.login = function (username, password, destination, error) {
    consensus.network.send({
        method: 'post',
        url: 'security/usersession/login',
        data: { username: username, password: password },
        success: function () { window.location.href = consensus.resolveUrl(destination); },
        error: function (request) { error(request); }
    });
}
consensus.authentication.logout = function () {
    consensus.network.send({
        method: 'post',
        success: function () { window.location.href = consensus.resolveUrl(consensus.authentication.authUrl); },
        url: 'security/usersession/logout',
    });
}
