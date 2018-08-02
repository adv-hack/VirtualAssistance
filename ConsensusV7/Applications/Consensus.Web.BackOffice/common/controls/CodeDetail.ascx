<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="CodeDetail.ascx.cs" Inherits="Consensus.Web.BackOffice.common.controls.CodeDetail" %>
<div class="row">
  <div class="col-12"><con:TextField runat="server" Id="CodeType" LabelText="Code Type" DataBoundValue="Type" IsReadOnly="TrueEnforced" /></div>
  <div class="col-12"><con:TextField runat="server" Id="Value1" LabelText="Value 1" DataBoundValue="Value1" /></div>
  <div class="col-12"><con:TextField runat="server" Id="Value2" LabelText="Value 2" DataBoundValue="Value2" /></div>
  <div class="col-12"><con:TextField runat="server" Id="Value4" LabelText="Value 3" DataBoundValue="Value4" /></div>
  <div class="col-12"><con:TextField runat="server" Id="Value3" LabelText="System value" DataBoundValue="Value3" /></div>
   <con:HiddenField runat="server" ID="ID" DataBoundValue="Id" />
  <con:HiddenField runat="server" ID="SystemValue" DataBoundValue="System" />
  <con:HiddenField runat="server" ID="DeletedValue" DataBoundValue="Deleted" />
</div>