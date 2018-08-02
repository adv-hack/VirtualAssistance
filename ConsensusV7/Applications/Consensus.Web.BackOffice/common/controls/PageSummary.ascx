<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="PageSummary.ascx.cs" Inherits="Consensus.Web.BackOffice.common.controls.PageSummary" %>
<div class="row" id="rowSummary" runat="server">
  <div class="col-xs-3 inline">
      <label id="lbLastUser" runat="server">Last modifying user:</label>
      <span id="LastUser" runat="server"></span>
  </div>
  <div class="col-xs-3 inline">
      <label id="lbLastDate" runat="server">Date & time:</label>
      <span id="LastDate" runat="server"></span>
  </div>
</div>