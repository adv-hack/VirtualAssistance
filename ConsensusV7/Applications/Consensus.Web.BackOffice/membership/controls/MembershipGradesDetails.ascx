<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="MembershipGradesDetails.ascx.cs" Inherits="Consensus.Web.BackOffice.membership.controls.MembershipGradesDetails" %>
<%@ Register TagPrefix="con" TagName="GenericProductDetails" Src="~/learning/controls/GenericProductDetails.ascx" %>

<div class="row">
    <div class="col-lg-6 consensus-column"> 
        <con:HiddenField runat="server" ID="SyProduct" DataBoundValue="SyProduct" />
        <con:GroupBox runat="server" Title="Grade details">
          <con:GenericProductDetails runat="server" Id="GenericProduct" DataBoundId="Id" />
        </con:GroupBox>
    </div>

    <div class="col-lg-6 consensus-column">
            <con:GroupBox runat="server" Title="Grade Information">
                <div class="row">
                <div class="col-md-6"><con:TextField runat="server" ID="DesigLetters" DataBoundValue="DesigLetters" LabelText="Designatory Letters"/></div>
              </div>
                
            </con:GroupBox>
    </div>
</div>