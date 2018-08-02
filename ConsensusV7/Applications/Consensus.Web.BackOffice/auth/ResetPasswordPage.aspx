<%@ Page AutoEventWireup="true" CodeBehind="ResetPasswordPage.aspx.cs" Inherits="Consensus.Web.BackOffice.auth.ResetPasswordPage" Language="C#" MasterPageFile="~/assets/templates/Basic.master" %>
<asp:Content runat="server" ContentPlaceHolderID="Content">
  <div class="productInfo">
    <h1><%= Consensus.ConsensusDomain.Configuration[Consensus.ConsensusDomain.Configuration.DefaultSite].ProductName %></h1>
    <h3><%= Consensus.ConsensusDomain.Configuration[Consensus.ConsensusDomain.Configuration.DefaultSite].ProductStrapline %></h3>
  </div>
  <div class="login-form">
    <div class="login">
      <span>Username</span>
      <input class="field form-control" type="text" />
    </div>
    <div class="login">
      <span>Email Address</span>
      <input class="field form-control" type="text" />
    </div>
    <div class="login">
      <a runat="server" href="~/auth/LoginPage.aspx">
        Back to Login
      </a>
  	<button class="login-btn btn-blue">
        <span class="login-icon"></span>
        <span>Reset</span>
  	</button>
    </div>
  </div>
</asp:Content>