<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="LicenseDetail.ascx.cs" Inherits="Consensus.Web.BackOffice.security.controls.LicenseDetail" %>
<div class="row">
  <div class="col-md-6">
    <con:DateField runat="server" ID="Active" LabelText="Active Date" IsReadOnly="FalseEnforced" Requirement="MandatoryEnforced" DataBoundValue="Active" />
    <con:DateField runat="server" ID="Expiry" LabelText="Expiry Date" IsReadOnly="FalseEnforced" DataBoundValue="Expiry" />
    <con:TextField runat="server" ID="Status" LabelText="Status" IsReadOnly="TrueEnforced" Requirement="MandatoryEnforced" DataBoundValue="StatusText" />
  </div>
  <div class="col-md-6">
    <con:TextField runat="server" ID="Hash" LabelText="License Key" IsReadOnly="TrueEnforced" Requirement="MandatoryEnforced" DataBoundValue="Verification" TextMode="MultiLine" CssClass="consensus-input license-data license-hash" />
    <con:TextField runat="server" ID="Sign" LabelText="License Verifier" IsReadOnly="TrueEnforced" Requirement="MandatoryEnforced" DataBoundValue="Signature" TextMode="MultiLine" CssClass="consensus-input license-data license-sign" />
  </div>
</div>
<style type="text/css">
  .license-data textarea {
    font-family: Consolas;
    padding: 5px 7px !important;
    resize: none;
  }
  .license-data.license-hash textarea {
    height: 46px;
  }
  .license-data.license-sign textarea {
    height: 182px;
  }
  .dataTables_wrapper .btn-group {
    text-align: right;
    margin-bottom: 10px;
  }
</style>