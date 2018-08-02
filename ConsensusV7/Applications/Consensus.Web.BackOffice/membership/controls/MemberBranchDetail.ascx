<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="MemberBranchDetail.ascx.cs" Inherits="Consensus.Web.BackOffice.membership.controls.MemberBranchDetail" %>
<div class="row">
    <div class="col-md-6">
        <con:PopupField runat="server" ID="Branch" LabelText="Branch" DataBoundValue="BranchId" DataBoundText="Branch.Name" PopupUrl="~/membership/popups/branchsearch.aspx" Requirement="MandatoryEnforced" />
    </div>
    <div class="col-md-6">
        <con:CodeField runat="server" ID="Status" DataBoundValue="StatusCode" CodeType="MBSTA" LabelText="Status" Requirement="MandatoryEnforced"  />
    </div>
    <div class="col-md-6">
        <con:DateField runat="server" ID="StartDate" DataBoundValue="StartDate" LabelText="Start Date" Requirement="MandatoryEnforced" />
    </div>
    
    <div class="col-md-6">
        <con:DateField runat="server" ID="EndDate" DataBoundValue="EndDate" LabelText="End Date"  />
    </div>
    <con:HiddenField runat="server" ID="TableName" DataBoundValue="TableName" />

    <con:HiddenField runat="server" ID="Mepid" DataBoundValue="RecordId" />
</div>
<br />
<br />
<br />
<br />
<br />
<br />
<br />
<br />
<br />