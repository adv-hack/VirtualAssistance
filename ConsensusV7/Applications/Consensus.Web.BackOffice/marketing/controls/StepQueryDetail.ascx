<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="StepQueryDetail.ascx.cs" Inherits="Consensus.Web.BackOffice.marketing.controls.StepQueryDetail" %>

<div class="row">                
    <div class="col-md-12">
        <con:GroupBox runat="server" Title="Link Step to Query">
            <div class="row">                
                <div class="col-md-12"><con:PopupField runat="server" ID="Step" DataBoundValue="StepId" DataBoundText="Step.Name" LabelText="Step" PopupUrl="~/marketing/popups/StepSearch.aspx" HyperlinkUrl="~/marketing/StepPage.aspx?id={id}" Requirement="MandatoryEnforced" ClientOnChange="changedStep();" /></div>
            </div>
            <div class="row">
                <div class="col-md-12"><con:ListField runat="server" ID="Link" DataBoundValue="Link" LabelText="Link" Requirement="MandatoryEnforced" /></div>
            </div>
        </con:GroupBox>
    </div>
</div>
