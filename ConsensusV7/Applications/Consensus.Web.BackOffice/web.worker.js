var CACHE_NAME = 'consensus-web-backoffice-v7';

/* On installation, the files required for caching are defined */
this.addEventListener('install', function (event) {
  event.waitUntil(
    caches.open(CACHE_NAME).then(function (cache) {
      return cache.addAll([
        'auth/loginpage.aspx',
        'assets/icons/advanced-icon.ico',
        'assets/icons/advanced-icon.ico',
        'assets/icons/glyphicons.css',
        'assets/plugins/jquery/jquery.min.js',
        'assets/plugins/tether/js/tether.min.js',
        'assets/plugins/bootstrap/js/bootstrap.min.js',
        'assets/plugins/jquery/jquery-ui.min.js',
        'assets/plugins/sweetalert/es6-promise.js',
        'assets/plugins/sweetalert/sweetalert2.min.js',
        'assets/plugins/datepicker/js/bootstrap-datepicker.min.js',
        'assets/plugins/bootstrap-switch/js/bootstrap-switch.min.js',
        'assets/plugins/datatables/datatables.js',
        'assets/plugins/datatables/datatables-1.10.15/js/datatables.bootstrap4.min.js',
        'assets/plugins/datatables/moment/moment.js',
        'assets/plugins/datatables/moment/datetime.js',
        'assets/plugins/tether/css/tether.min.css',
        'assets/plugins/bootstrap/css/bootstrap.min.css',
        'assets/plugins/jquery/jquery-ui.min.css',
        'assets/plugins/yamm/yamm.min.css',
        'assets/plugins/sweetalert/sweetalert2.css',
        'assets/plugins/datepicker/css/bootstrap-datepicker.standalone.min.css',
        'assets/plugins/bootstrap-switch/css/bootstrap-switch.min.css',
        'assets/plugins/datatables/datatables.css',
        'assets/plugins/datatables/datatables-1.10.15/css/datatables.bootstrap4.min.css',
        'assets/plugins/advanced/adv-bootstrap.css',
        'assets/plugins/advanced/adv-login.css',
        'assets/plugins/advanced/advanced-horizontal-cmyk.png',
        'assets/plugins/advanced/bgd.jpg',
        'assets/plugins/advanced/login_icon.png',
        'assets/plugins/consensus/css/consensus.css'
      ]);
    })
  );
});

/* On activation, any previously cached files should be cleared */
this.addEventListener('activate', function (event) {
  event.waitUntil(
    caches.keys().then(function(cacheNames) {
      caches.delete(cacheName);
    })
  );
});

self.addEventListener('fetch', function(event) {
  event.respondWith(
    caches.match(event.request)
      .then(function(response) {
        if (response) {
          return response;
        }
        var request = event.request.clone();
        return fetch(request).then(
          function(response) {
            return response;
          }
        );
      })
    );
});
