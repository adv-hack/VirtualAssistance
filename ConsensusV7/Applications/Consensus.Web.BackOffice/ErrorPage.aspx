<%@ Page AutoEventWireup="true" CodeBehind="ErrorPage.aspx.cs" Inherits="Consensus.Web.BackOffice.ErrorPage" Language="C#" MasterPageFile="~/assets/templates/Standard.master" Title="Error" %>
<asp:Content runat="server" ContentPlaceHolderID="Content">
  <script>$(window.document).on('keydown', consensus.web.onkey);</script>
  <div class="text-center px-4">
    <div class="d-inline-block">
      <span style="font-size: 150px;" runat="server" id="ErrorIcon"></span>
      <h1 runat="server" id="ErrorText" class="mt-0 text-danger" />
      <h3 runat="server" id="ErrorDesc" class="mt-1 text-warning" />
    </div>
    <pre runat="server" id="StackTrace" class="mt-4 text-left"></pre>
  </div>
</asp:Content>
