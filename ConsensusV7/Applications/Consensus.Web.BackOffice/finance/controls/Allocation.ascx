<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="Allocation.ascx.cs" Inherits="Consensus.Web.BackOffice.finance.controls.Allocation" %>
<div class="row">
    <div class="col-md-6">
        <con:DateField runat="server" ID="Date" DataBoundValue="Date" LabelText="Allocation date" />
    </div>
    <div class="col-md-6">
        <con:TextField runat="server" ID="AllocationID" DataBoundValue="Id" LabelText="Allocation ID" />
    </div>
    <div class="col-md-6">
        <con:TextField runat="server" ID="InvRef" DataBoundValue="InvRef" LabelText="Invoice Ref " />
    </div>
    <div class="col-md-6">
        <con:TextField runat="server" ID="CreditNoteRef" DataBoundValue="CreditRef" LabelText="Credit Note Ref" />
    </div>
    <div class="col-md-6">
        <con:TextField runat="server" ID="PaymentID" DataBoundValue="PayIdId" LabelText="Payment ID" />
    </div>
    <% if (this.AllocationType.Equals("invoice") ||(this.AllocationType.Equals("payment")))
        { %>
    <con:HiddenField runat="server" ID="ReversesPaId" DataBoundValue="ReversesPaId" LabelText="ReversesPaId" />

    <div class="col-md-6">
        <con:TextField runat="server" ID="Type" LabelText=" Payment Type" />
    </div>
    <% }%>
    <div class="col-md-6">
        <con:TextField runat="server" ID="CurrType" DataBoundValue="CurrType" LabelText="Currency" />
    </div>
    <div class="col-md-6">
        <con:TextField runat="server" ID="Value" DataBoundValue="Value" LabelText="Allocation" />
    </div>
   
    <button runat="server" id="Reverse" class="btn btn-danger btnreverse" onclick="reverseallocation(); return false;">
        <span aria-hidden="true" class="icons8-refund_2"></span>
        <span class="text" runat="server" id="ReverseButtonText">Reverse</span>
    </button>
    
</div>

