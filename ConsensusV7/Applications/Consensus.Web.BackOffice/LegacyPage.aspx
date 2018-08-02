<%@ Page Title="" Language="C#" AutoEventWireup="true" CodeBehind="LegacyPage.aspx.cs" Inherits="Consensus.Web.BackOffice.LegacyPage" %>
<!doctype html>
<html lang="en-gb">
  <head runat="server">
    <title></title>
    <meta name="author" content="Advanced Computer Software Group Limited"/>
    <meta name="mobile-web-app-capable" content="yes">
    <meta name="robots" content="noindex, nofollow" />
    <meta name="viewport" content="width=device-width, initial-scale=1.0" />
    <meta name="theme-color" content="#e57200" />
    <meta http-equiv="content-type" content="text/html;charset=utf-8" />
    <meta http-equiv="x-ua-compatible" content="IE=8, chrome=1" runat="server" />
    <link rel="shortcut icon" href="<%= VirtualPathUtility.ToAbsolute("~/assets/icons/advanced-icon.ico") %>" type="image/x-icon" />
    <link rel="stylesheet" href="<%= VirtualPathUtility.ToAbsolute("~/assets/plugins/tether/css/tether.min.css")%>" type="text/css" />
    <link rel="stylesheet" href="<%= VirtualPathUtility.ToAbsolute("~/assets/plugins/bootstrap/css/bootstrap.min.css")%>" type="text/css" />
    <link rel="stylesheet" href="<%= VirtualPathUtility.ToAbsolute("~/assets/plugins/advanced/adv-bootstrap.css")%>" type="text/css" />
    <link rel="stylesheet" href="<%= VirtualPathUtility.ToAbsolute("~/assets/plugins/advanced/adv-login.css")%>" type="text/css" />
    <link rel="stylesheet" href="<%= VirtualPathUtility.ToAbsolute("~/assets/plugins/consensus/css/consensus.css")%>" type="text/css" />
    <link rel="stylesheet" href="<%= VirtualPathUtility.ToAbsolute("~/assets/plugins/yamm/yamm.min.css")%>" type="text/css" />
    <style type="text/css">
        .navbar-inverse .navbar-nav .nav-link { color: #888; }
        .navbar .navbar-nav { margin-top: 3px; }
        .navbar .navbar-nav > li { display: inline-block; }
        .navbar .navbar-nav > li > a { padding: 11.5px 8px; }
        .yamm-content > .row { display: flex; flex-direction: row; }
        .yamm-content > .row > * { flex-grow: 1; flex-shrink: 0; flex-basis: auto; width: unset; max-width: unset; padding: 0 1rem; }
    </style>
    
  </head>
  <body class="standard">
    <div class="navbar navbar-inverse bg-inverse yamm hidden-print navbar-fixed-top" id="headerNav" style="padding: 0 15px">
      <a class="navbar-brand" href="/" style="float: left">
        <img alt="Advanced" class="d-inline-block align-top" src="<%= VirtualPathUtility.ToAbsolute("~/assets/images/advanced-icon.png") %>" />
        <span>Advanced</span>
      </a> 
      <ul class="navbar-nav mr-auto" style="float: left">
        <asp:Repeater runat="server" ID="MenuRepeater">
          <ItemTemplate>
            <li class="dropdown">
              <a class="nav-link dropdown-toggle" href="#" data-toggle="dropdown" aria-haspopup="true" aria-expanded="false"><%# Eval("Name") %></a>
              <ul class="dropdown-menu">
                <li>
                  <div class="yamm-content">
                    <div class="row">
                      <asp:Repeater runat="server" ID="MenuRepeater">
                        <ItemTemplate>
                          <ul class="list-unstyled">
                            <li><p><strong><%# Eval("Name") %></strong></p></li>
                            <asp:Repeater runat="server" ID="MenuRepeater">
                              <ItemTemplate>
                                <li><a href="<%# VirtualPathUtility.ToAbsolute("~/" + Eval("RelativePath") as String) %>"><%# Eval("Name") %></a></li>
                              </ItemTemplate>
                            </asp:Repeater>
                          </ul>
                        </ItemTemplate>
                      </asp:Repeater>
                    </div>
                  </div>
                </li>
              </ul>
            </li>
          </ItemTemplate>
        </asp:Repeater>
      </ul>
    </div>
    <div class="clearfix" style="position: absolute; width: 100%; top: 52px; bottom: 0;">
      <iframe runat="server" id="PageFrame" frameborder="0" style="height: 100%; width: 100%; border: none; overflow: auto; float: left" />
      <script type="text/javascript">
          var iframe = document.getElementById('<%= this.PageFrame.ClientID %>');
          iframe.onload = function () {
              iframe.contentWindow.redirect7 = function (url) { window.top.location = '<%= VirtualPathUtility.ToAbsolute("~") %>' + (url.substr(0, 1) == '/' ? '' : '/') + url; }
          }

          var rootUrl = '<%= VirtualPathUtility.ToAbsolute("~/" + Consensus.ConsensusDomain.Configuration[Consensus.ConsensusDomain.Configuration.DefaultSite].Version6) %>/';
          var fullUrl = rootUrl + window.location.hash.substr(1);
          while (fullUrl.indexOf('//') != -1) { fullUrl = target.replace('//', '/'); }
          fullUrl = fullUrl + (fullUrl.indexOf('?') == -1 ? '?' : '&') + 'embedv6=true';
          iframe.setAttribute('src', fullUrl);
      </script>
    </div>
  </body>
</html>