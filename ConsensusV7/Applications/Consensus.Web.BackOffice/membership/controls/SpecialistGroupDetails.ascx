<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="SpecialistGroupDetails.ascx.cs" Inherits="Consensus.Web.BackOffice.membership.controls.SpecialistGroupDetails" %>
<%@ Register TagPrefix="con" TagName="GenericProductDetails" Src="~/learning/controls/GenericProductDetails.ascx" %>

<div class="row">
    <div class="col-lg-6 consensus-column"> 
        <con:HiddenField runat="server" ID="SyProduct" DataBoundValue="SyProduct" />
        <con:GroupBox runat="server" Title="Specialist group details">
          <con:GenericProductDetails runat="server" Id="GenericProduct" DataBoundId="Id" />
        </con:GroupBox>
    </div>
</div>
