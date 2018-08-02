<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="BatchDetails.ascx.cs" Inherits="Consensus.Web.BackOffice.finance.controls.BatchDetails" %>

<div class="row">
    <div class="col-md-6">
        <con:GroupBox runat="server" Title="Batch details">
            <con:HiddenField runat="server" ID="BatId" DataBoundValue="Id" />
            <div class="row">
              <div class="col-md-12"><con:TextField runat="server" ID="Description" LabelText="Description" IsReadOnly="TrueEnforced"/></div>
            </div>
            <div class="row">
              <div class="col-md-6"><con:TextField runat="server" ID="BatchId" DataBoundValue="Id" LabelText="Batch Id " IsReadOnly="TrueEnforced" /></div>
            </div>
            <div class="row">
              <div class="col-md-6"><con:TextField runat="server" ID="BatchType" DataBoundValue="Type" LabelText="Batch type" IsReadOnly="TrueEnforced"/></div>
            </div>
            <div class="row">
            <div class="col-md-6"><con:ListField runat="server" ID="SellingCompany" DataBoundValue="SellingCompanyId" DataBoundText="SellingCompany.Name" LabelText="Selling company" DisplayMember="Name" ValueMember="Id" IsReadOnly="TrueEnforced" /></div>
        </div>
        </con:GroupBox>
    </div>
    <div class="col-md-6">
        <con:GroupBox runat="server" Title="Process information">
            <div class="row">
              <div class="col-md-12"><con:TextField runat="server" ID="BatchStatus" DataBoundValue="Status" LabelText="Status " IsReadOnly="TrueEnforced" /></div>
            </div>
            <div class="row">
              <div class="col-md-6">
                  <con:HiddenField runat="server" ID="hiddenBatStart" DataBoundValue="BatchStartedDate" />
                  <con:TextField runat="server" ID="BatchStart"  LabelText="Started" IsReadOnly="TrueEnforced" /></div>
            </div>
            <div class="row">
              <div class="col-md-6">
                   <con:HiddenField runat="server" ID="hiddenBatFinish" DataBoundValue="BatchFinishedDate" />
                  <con:TextField runat="server" ID="BatchFinish"  LabelText="Finished" IsReadOnly="TrueEnforced" /></div>
            </div>
            <div class="row">
              <div class="col-md-6"><con:TextField runat="server" ID="BatchRecProcessed" DataBoundValue="BatchProcessedRecords" LabelText="Records processed" IsReadOnly="TrueEnforced" /></div>
            </div>
            <div class="row">
              <div class="col-md-6"><con:TextField runat="server" ID="BatchRunBy" DataBoundValue="BatchRunBy" LabelText="Run by" IsReadOnly="TrueEnforced" /></div>
            </div>
        </con:GroupBox>
    </div>
    <div class="col-md-12">
        <div class="row">
            <div class="col-md-12"><con:TextField runat="server" ID="BatchNotes" DataBoundValue="BatchNote" LabelText="Notes" TextMode="MultiLine" IsReadOnly="TrueEnforced" /></div>
        </div>
        <div class="row">
            <div class="col-md-12"><con:TextField runat="server" ID="BatchErrNotes" DataBoundValue="BatchErrorNote" LabelText="Errors" TextMode="MultiLine" IsReadOnly="TrueEnforced" /></div>
        </div>
    </div>
</div>
