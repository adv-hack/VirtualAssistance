<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="StepParameterDetail.ascx.cs" Inherits="Consensus.Web.BackOffice.marketing.controls.StepParameterDetail" %>

<div class="row">
    <div class="col-md-12">
        <con:GroupBox runat="server" Title="Details">
            <div class="row">
                <div class="col-md-2"><con:ListField runat="server" ID="Condition" DataBoundValue="Condition" LabelText="Condition" Requirement="MandatoryEnforced" /></div>
                <div class="col-md-2"><con:ListField runat="server" ID="PreBracket" DataBoundValue="PreBracket" LabelText="((" /></div>
            </div>
            <div class="row">
                <div class="col-md-4 offset-md-1">
                    <con:PopupField runat="server" ID="FilterField" DataBoundValue="FilterFieldId" DataBoundText="FilterField.ColumnDesc" LabelText="Filter Field" PopupUrl="~/marketing/popups/parameterfiltersearch.aspx" HyperlinkUrl="~/marketing/popups/parameterfiltersearch.aspx?id={id}" />
                </div>   
            </div>
            <div class="row">                        
                <div class="col-md-3 offset-md-2"><con:ListField runat="server" ID="Operand" DataBoundValue="Operand" DisplayMember="Desc" ValueMember="Value" LabelText="Comparison" Requirement="MandatoryEnforced" /></div> 
            </div>
            <div class="row">      
                <div class="col-md-7 offset-md-3"><con:TextField runat="server" ID="Value" DataBoundValue="Value" LabelText="Value" /></div>
                <div class="col-md-2"><con:ListField runat="server" ID="PostBracket" DataBoundValue="PostBracket" LabelText="))" /></div>
            </div>
        </con:GroupBox>
    </div>
</div>