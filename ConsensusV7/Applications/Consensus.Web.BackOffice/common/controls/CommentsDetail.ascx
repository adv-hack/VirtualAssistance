<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="CommentsDetail.ascx.cs" Inherits="Consensus.Web.BackOffice.common.controls.CommentsDetail" %>

<div class="row">
    <div class="col-md-12">
        <con:HtmlTextField runat="server" DataBoundValue="Html" ID="Comment" LabelText="Comment" Requirement="MandatoryEnforced" Height="300px" />
    </div>
</div>
 