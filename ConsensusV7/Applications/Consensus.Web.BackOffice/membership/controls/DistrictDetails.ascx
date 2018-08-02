<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="DistrictDetails.ascx.cs" Inherits="Consensus.Web.BackOffice.membership.controls.DistrictDetails" %>

<div class="row">
    <div class="col-md-6">
        <con:GroupBox runat="server" Title="District Details">   

            <div class="row">         
                <div class="col-md-12"><con:TextField runat="server" ID="Name" DataBoundValue="Name" LabelText="Name"  Requirement="MandatoryEnforced"/></div>
            </div>
            <div class="row">
                <div class="col-md-6"><con:CodeField runat="server" ID="Status" DataBoundValue="StatusCode" LabelText="Status" CodeType="DISTA" Requirement="MandatoryEnforced" /></div>
                <div class="col-md-6"><con:CodeField runat="server" ID="Region" DataBoundValue="RegionCode" LabelText="Region" CodeType="REGI" /></div>
            </div>
            <div class="row">
                <div class="col-md-6"><con:CodeField runat="server" ID="Type" DataBoundValue="TypeCode" LabelText="Type" CodeType="DITYP" /></div>
                <div class="col-md-6"><con:CodeField runat="server" ID="Category" DataBoundValue="CategoryCode" LabelText="Category" CodeType="DICAT" /></div>
            </div>
            <div class="row">
                <div class="col-md-6"><con:CodeField runat="server" ID="Group" DataBoundValue="GroupCode" LabelText="Group" CodeType="DIGRP" /></div>
                <div class="col-md-6"><con:CheckField runat="server" ID="WebEnabled" LabelText="Web enabled" DataBoundValue="Web" /></div>
            </div>
        </con:GroupBox>
    </div>
</div>
