<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="CommitteeDetail.ascx.cs" Inherits="Consensus.Web.BackOffice.membership.controls.CommitteeDetail" %>

<div class="row">
    <div class="col-md-6">
        <con:GroupBox runat="server" Title="Committee details"> 
            <div class="row">
                <div class="col-md-12"><con:TextField runat="server" ID="Name" DataBoundValue="Name" LabelText="Name" Requirement="MandatoryEnforced" /></div>
            </div>
            <div class="row">
                <div class="col-md-6"><con:CodeField runat="server" ID="Status" DataBoundValue="StatusCode" LabelText="Status" CodeType="CMSTA" Requirement="MandatoryEnforced" /></div>
                <div class="col-md-6"><con:DateField runat="server" ID="StartDate" DataBoundValue="StartDate" LabelText="Start date" Requirement="MandatoryEnforced" /></div>
            </div>
            <div class="row">
                <div class="col-md-6"><con:CodeField runat="server" ID="Type" DataBoundValue="TypeCode" LabelText="Type" CodeType="CMTYP" /></div>
                <div class="col-md-6"><con:CodeField runat="server" ID="Category" DataBoundValue="CategoryCode" LabelText="Category" CodeType="CMCAT" /></div>
            </div>
            <div class="row">
                <div class="col-md-6"><con:CodeField runat="server" ID="Group" DataBoundValue="GroupCode" LabelText="Group" CodeType="CMGRP" /></div>
                <div class="col-md-6"><con:TextField runat="server" ID="Members" DataBoundValue="NoPeople" LabelText="Members" IsReadOnly="TrueEnforced" /></div> 
            </div>
        </con:GroupBox>
    </div>
</div>