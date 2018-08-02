<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="RollbackMembership.ascx.cs" Inherits="Consensus.Web.BackOffice.membership.controls.RollbackMembership" %>
<div class="row">
    <div class="col-md-12">
        <h4>This process will credit all invoices and reset the status. Please select the new status below</h4>
    </div>
    <div class="col-md-6">
        <con:HiddenField runat="server" ID="Id" DataBoundValue="Id" />
        <con:CodeField runat="server" ID="Status" LabelText="New Status" DataBoundValue="StatusCode" CodeType="MEPST" />
    </div>
</div>
