<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="UserGroupDetails.ascx.cs" Inherits="Consensus.Web.BackOffice.security.controls.UserGroupDetails" %>
<con:GroupBox runat="server" Title="Group Details">
    <div class="row">
        <div class="col-md-6">
            <con:TextField runat="server" ID="Name" DataBoundValue="Principal.Name" LabelText="Name" Requirement="MandatoryEnforced" />
        </div>
    </div>
</con:GroupBox>