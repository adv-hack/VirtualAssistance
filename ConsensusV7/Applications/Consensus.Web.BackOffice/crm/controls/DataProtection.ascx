<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="DataProtection.ascx.cs" Inherits="Consensus.Web.BackOffice.crm.controls.DataProtection" %>
<div class="row">
    <div class="col-lg-6 consensus-column"> 
        <con:GroupBox runat="server" Title="Marketing permissions">
            <div class="row">
                <div class="col-md-6"><con:CheckField runat="server" DataBoundValue="Person.DoNotSpare4" ID="DoNotSpare4" LabelText="Contact by phone" OffColour="success" OffText="Yes" OnColour="danger" OnText="No"/></div>
                <div class="col-md-6"><con:CheckField runat="server" DataBoundValue="Person.DoNotEmail" ID="DoNotEmail" LabelText="Contact by email" OffColour="success" OffText="Yes" OnColour="danger" OnText="No" /></div>
            </div>

            <div class="row">

                <div class="col-md-6"><con:CheckField runat="server" DataBoundValue="Person.DoNotMail" ID="DoNotMail" LabelText="Contact by mail" OffColour="success" OffText="Yes" OnColour="danger" OnText="No" /></div>
                <div class="col-md-6"><con:CheckField runat="server" DataBoundValue="Person.DoNotFax" ID="DoNotFax" LabelText="Contact by SMS" OffColour="success" OffText="Yes" OnColour="danger" OnText="No" /></div>

            </div>
                
            <div class="row">            
                <div class="col-md-6"><con:CheckField runat="server" DataBoundValue="Person.DoNotSwap" ID="DoNotSwap" LabelText="Share with 3rd parties" OffColour="success" OffText="Yes" OnColour="danger" OnText="No" /></div>
                <div class="col-md-6"><con:CheckField runat="server" DataBoundValue="Person.DoNotSpare1" ID="DoNotSpare1" LabelText="Spare contact method 1" OffColour="success" OffText="Yes" OnColour="danger" OnText="No" /></div>
            </div>

            <div class="row">            
                <div class="col-md-6"><con:CheckField runat="server" DataBoundValue="Person.DoNotSpare2" ID="DoNotSpare2" LabelText="Spare contact method 2" OffColour="success" OffText="Yes" OnColour="danger" OnText="No" /></div>
                <div class="col-md-6"><con:CheckField runat="server" DataBoundValue="Person.DoNotSpare3" ID="DoNotSpare3" LabelText="Spare contact method 3" OffColour="success" OffText="Yes" OnColour="danger" OnText="No" /></div>
            </div>

            <div class="row">     
                <div class="col-md-6"><con:DateField class="col-md-6" runat="server" DataBoundValue="Person.GdprConsentDate" ID="GdprConsentDate" LabelText="Consent last obtained" /></div>
                <div class="col-md-6"><con:DateField runat="server" DataBoundValue="Person.RetainUntilDate" ID="RetainUntilDate" LabelText="Retain data until" /></div>
            </div>
        </con:GroupBox>
    </div>
    <div class="col-lg-6 consensus-column"> 
        <con:GroupBox runat="server" Title="Role specific marketing permissions">
            <div class="row"> 
                <div class="col-md-6"><con:CheckField runat="server" DataBoundValue="DoNotTelesale" ID="RoleDoNotTelesale"  LabelText="Contact by phone" OffColour="success" OffText="Yes" OnColour="danger" OnText="No" /></div>
            </div>

            <div class="row"> 
                <div class="col-md-6"><con:CheckField runat="server" DataBoundValue="DoNotEmail" ID="RoleDoNotEmail" LabelText="Contact by email" OffColour="success" OffText="Yes" OnColour="danger" OnText="No" /></div>
            </div>

            <div class="row">
                <div class="col-md-6"><con:CheckField runat="server" DataBoundValue="DoNotMail" ID="RoleDoNotMail" LabelText="Contact by mail" OffColour="success" OffText="Yes" OnColour="danger" OnText="No" /></div>
            </div>

            <div class="row"> 
                <div class="col-md-6"><con:CheckField runat="server" DataBoundValue="DoNotFax" ID="RoleDoNotFax" LabelText="Contact by SMS" OffColour="success" OffText="Yes" OnColour="danger" OnText="No" /></div>
            </div>

            <div class="row"> 
                <div class="col-md-6"><con:CheckField runat="server" DataBoundValue="DoNotSwap" ID="RoleDoNotSwap" LabelText="Share with 3rd parties" OffColour="success" OffText="Yes" OnColour="danger" OnText="No" /></div>
            </div>
 
        </con:GroupBox>
    </div>
</div>