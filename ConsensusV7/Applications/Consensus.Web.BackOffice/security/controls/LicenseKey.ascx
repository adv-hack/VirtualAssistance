<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="LicenseKey.ascx.cs" Inherits="Consensus.Web.BackOffice.security.controls.LicenseKey" %>
<div class="row">
  <div class="col-md-12">
    <con:TextField runat="server" ID="Hash" LabelText="License Key" Requirement="MandatoryEnforced" DataBoundValue="Verification" TextMode="MultiLine" CssClass="consensus-input license-data license-hash" />
  </div>
</div>
<div class="row">
  <div class="col-md-12">
    <con:TextField runat="server" ID="Sign" LabelText="License Verifier" Requirement="MandatoryEnforced" DataBoundValue="Signature" TextMode="MultiLine" CssClass="consensus-input license-data license-sign" />
  </div>
</div>
<style type="text/css">
  .license-data textarea { font-family: Consolas; padding: 5px 7px !important; resize: none; }
  .license-data.license-hash textarea { height: 29px; }
  .license-data.license-sign textarea { height: 148px; }
</style>
<script type="text/javascript">
    function generateVerifier() {
      var hash = $('#<%= this.Hash.ClientID %>Field');
      var sign = $('#<%= this.Sign.ClientID %>Field');
      if (hash.val().trim() == '') {
        sign.val('');
      } else {
        sign.val('Generating ...');
        consensus.network.send({
            method: 'post',
            url: 'security/license/sign',
            data: { verification: hash.val() },
            success: function (result) { sign.val(result); },
            error: function (request) { sign.val(request.statusText); }
        });
      }
    }
</script>