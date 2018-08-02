<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="ProfileDetail.ascx.cs" Inherits="Consensus.Web.BackOffice.crm.controls.ProfileDetail" %>
<div class="row">
    <div class="col-md-12"> 
        <Con:PopupField runat="server" ID="Key" DataBoundValue="Key" DataBoundText="Key" LabelText="Level 1" PopupUrl="~/GenericPopup.aspx?context=crm&control=profiletree&persistence=stateful&title=Select Profile" Requirement="MandatoryEnforced" IsReadOnly="false"  />
        <con:TextField runat="server" ID="Value" DataBoundValue="Value" LabelText="Level 2" IsReadOnly="True"/>
        <con:TextField runat="server" ID="Value2" DataBoundValue="Value2" LabelText="Level 3" IsReadOnly="True"/>
        <con:CodeField runat="server" ID="Status" DataBoundValue="StatusCode" LabelText="Status" CodeType="PROST" Requirement="MandatoryEnforced" />
        <con:HiddenField runat="server" ID="Organisation"/>
        <con:HiddenField runat="server" ID="Person"/>
        <con:HiddenField runat="server" ID="Course"/>
        <con:HiddenField runat="server" ID="Product"/>
        <con:HiddenField runat="server" ID="Trainer"/>
        <con:HiddenField runat="server" ID="Volunteer"/>
        <con:CodeField runat="server" ID="PersonProfiles" IsHidden="TrueEnforced" IsReadOnly="TrueEnforced"  LabelText="Person profiles" CodeType="PRCT" />
        <con:CodeField runat="server" ID="OrganisationProfiles" IsHidden="TrueEnforced" IsReadOnly="TrueEnforced"  LabelText="Organisation profiles" CodeType="PROF" />
        <con:CodeField runat="server" ID="AssociateProfiles" IsHidden="TrueEnforced" IsReadOnly="TrueEnforced"  LabelText="Associate profiles" CodeType="PRTRN" />
        <con:CodeField runat="server" ID="VolunteerProfiles" IsHidden="TrueEnforced" IsReadOnly="TrueEnforced"  LabelText="Volunteer profiles" CodeType="PRVOL" />
     </div>
</div>
<div class="row">
    <div class="col-md-12">
        <con:TextField runat="server" ID="Notes" DataBoundValue="Notes" LabelText="Notes" TextMode="MultiLine"/>
    </div>
</div>