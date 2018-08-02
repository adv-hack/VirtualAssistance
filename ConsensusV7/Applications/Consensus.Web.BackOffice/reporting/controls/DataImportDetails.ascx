<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="DataImportDetails.ascx.cs" Inherits="Consensus.Web.BackOffice.reporting.controls.DataImportDetails" %>
<div class="row">
    <div class="col-md-6">
        <con:GroupBox runat="server" Title="Import details">           
            <div class="row">
                <div class="col-md-6">
                    <con:TextField runat="server" ID="txtImportId" DataBoundValue="Id" LabelText="Import id" IsReadOnly="TrueEnforced" />
                </div>
                <div class="col-md-6">
                    <con:ListField runat="server" DataBoundValue="BatchDiIdId" DataBoundText="BatchDiId.Title" ID="ImportTypeList" LabelText="Import type" DisplayMember="Title" ValueMember="Id"  Requirement="MandatoryEnforced" />
                </div>
            </div>

            <con:HiddenField runat="server" ID="ImportId" DataBoundValue="Id" />
        </con:GroupBox>
    </div>
    <div class="col-md-6">
        <con:GroupBox runat="server" Title="Process information">
            <div class="row">
                <div class="col-md-6">
                    <con:TextField runat="server" DataBoundValue="Status" LabelText="Status" IsReadOnly="TrueEnforced" />
                </div>
                <div class="col-md-6">
                    <con:TextField runat="server" DataBoundValue="BatchRunBy" LabelText="Run by" IsReadOnly="TrueEnforced" />
                </div>
            </div>
            <div class="row">
                <div class="col-md-6">
                    <con:HiddenField runat="server" ID="hiddenBatStart" DataBoundValue="BatchStartedDate" />
                    <con:TextField runat="server" ID="BatchStart" DataBoundValue="BatchStartedDate" LabelText="Started" IsReadOnly="TrueEnforced" />
                </div>
                <div class="col-md-6">
                    <con:HiddenField runat="server" ID="hiddenBatFinish" DataBoundValue="BatchFinishedDate" />
                    <con:TextField runat="server" ID="BatchFinish" DataBoundValue="BatchFinishedDate" LabelText="Finished" IsReadOnly="TrueEnforced">
                    </con:TextField>
                </div>
            </div>
            <div class="row">
                <div class="col-md-6">
                    <con:TextField runat="server" DataBoundValue="BatchProcessedRecords" LabelText="Records processed" IsReadOnly="TrueEnforced" />
                </div>
            </div>
        </con:GroupBox>
    </div>
    <div class="col-md-12">
        <con:GroupBox runat="server" Title="Notes">
            <div class="row">
                <div class="col-md-12">
                    <con:HtmlTextField runat="server" DataBoundValue="BatchNote" LabelText="Notes" IsReadOnly="TrueEnforced" />
                </div>
            </div>
            <div class="row">
                <div class="col-md-12">
                    <con:HtmlTextField runat="server" DataBoundValue="BatchErrorNote" LabelText="Errors" IsReadOnly="TrueEnforced" />
                </div>
            </div>
        </con:GroupBox>
    </div>

</div>

