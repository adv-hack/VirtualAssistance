<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="MemberMailingListDetail.ascx.cs" Inherits="Consensus.Web.BackOffice.marketing.controls.MemberMailingListDetail" %>
<div class="row">
    <div class="col-md-6">
        <con:HiddenField runat="server" ID="TableName" DataBoundValue="TableName" />
        <con:ListField runat="server" ID="MailingList" LabelText="Mailing list" DataBoundValue="MailingListId" DisplayMember="Title" ValueMember="Id" Requirement="MandatoryEnforced" />
    </div>
</div>
