<%@ Page AutoEventWireup="true" CodeBehind="LoginPage.aspx.cs" Inherits="Consensus.Web.BackOffice.auth.LoginPage" Language="C#" MasterPageFile="~/assets/templates/Basic.master" %>
<asp:Content runat="server" ContentPlaceHolderID="Content">
    <div class="productInfo">
        <h1><%= Consensus.ConsensusDomain.Configuration[Consensus.ConsensusDomain.Configuration.DefaultSite].ProductName %></h1>
        <h3><%= Consensus.ConsensusDomain.Configuration[Consensus.ConsensusDomain.Configuration.DefaultSite].ProductStrapline %></h3>
    </div>
    <div class="login-form">
        <div class="login">
            <span>Username</span>
            <input class="field form-control" type="text" id="username" value="" />
        </div>
        <div class="login">
            <span>Password</span>
            <input class="field form-control" type="password" id="password" value="" />
        </div>
        <div class="alert alert-danger hidden" id="message">
            Login Failed
        </div>
        <div class="login">
      <a runat="server" href="~/auth/ResetPasswordPage.aspx">
        Forgotten Password?
            </a>
            <button class="login-btn btn-blue" onclick="authenticate(); return false;">
                <span class="login-icon"></span>
                <span>Login</span>
            </button>
        </div>
    </div>
    <script>
        function authenticate() {
            var username = $('#username').val();
            var password = $('#password').val();
            $('#message').addClass('hidden');

            $('.login-btn').attr('disabled', 'disabled');
            consensus.authentication.login(username, password, '<%= this.Destination %>', function (request) {

              var responseHeader = request.getAllResponseHeaders().split('\r\n');
              var mimeTypeHeader = jQuery.grep(responseHeader, function (element) { return element.split(': ')[0].toLocaleLowerCase() == 'content-type'; });
              var contentType = mimeTypeHeader[0].split(': ')[1].split(';')[0];
              var exception = contentType == 'text/html' && request.statusText && request.statusText.length != 0 ? request.statusText : null;
              $('#message').removeClass('hidden').text(exception ? exception : request.statusText);
              $('.login-btn').attr('disabled', null);
          });
      }
    </script>
</asp:Content>