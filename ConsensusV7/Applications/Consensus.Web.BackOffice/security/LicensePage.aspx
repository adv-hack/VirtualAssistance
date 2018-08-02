<%@ Page Title="" Language="C#" MasterPageFile="~/assets/templates/StandardDetail.master" AutoEventWireup="true" CodeBehind="LicensePage.aspx.cs" Inherits="Consensus.Web.BackOffice.security.LicensePage" %>
<%@ Register TagPrefix="con" TagName="LicenseOwner" Src="~/security/controls/licenseowner.ascx" %>
<%@ Register TagPrefix="con" TagName="LicenseDetail" Src="~/security/controls/licensedetail.ascx" %>
<%@ Register TagPrefix="con" TagName="LicenseLimits" Src="~/security/controls/licenselimitlist.ascx" %>
<%@ Register TagPrefix="con" TagName="LicenseModules" Src="~/security/controls/licensemodulelist.ascx" %>
<%@ Register TagPrefix="con" TagName="LicenseKey" Src="~/security/controls/licensekey.ascx" %>

<asp:Content runat="server" ContentPlaceHolderID="ReadModeToolbar">
  <asp:Button runat="server" ID="VerifyLicenseButton" CssClass="btn btn-default" Text="Generate Verifier" OnClientClick="generateLicenseVerifier();return false;" />
</asp:Content>
<asp:Content runat="server" ContentPlaceHolderID="TopContent">
  <con:TabControl runat="server" ID="TabControl">
    <Pages>
      <con:TabPage runat="server" Title="Contact" ID="ContactTab">
        <con:LicenseOwner runat="server" ID="LicenseOwner" />
      </con:TabPage>
      <con:TabPage runat="server" Title="License" ID="LicenseTab">
        <con:LicenseDetail runat="server" ID="LicenseDetail" />
      </con:TabPage>
      <con:TabList runat="server" Title="Limits" ID="LimitsTab" EnableCreation="true">
        <con:LicenseLimits runat="server" ID="LicenseLimits" DataBoundValue="Limits" />
      </con:TabList>
      <con:TabList runat="server" Title="Modules" ID="ModulesTab">
        <con:LicenseModules runat="server" ID="LicenseModules" DataBoundValue="Modules" />
      </con:TabList>
    </Pages>
  </con:TabControl>
  <asp:Panel runat="server" CssClass="alert alert-danger mb-0 mt-4" ID="WarningPanel">
    <span class="icons8-warning_shield mr-3"></span>
    <strong>There is a problem with your current software license, please contact support for assistance.</strong>
  </asp:Panel>
  <script type="text/javascript">

    function generateLicenseVerifier() {
      consensus.web.popupFrame({ url: consensus.resolveUrl('~/genericpopup.aspx?context=security&control=licensekey&width=893&mode=generate') });
    }

    function validateLicenseVerifier(state, result, callback) {
      if (result.Status != 'Invalid') {
        callback(state, result);
      } else { 
        consensus.web.popupFrame({
          url: consensus.resolveUrl('~/genericpopup.aspx?context=security&control=licensekey&width=893'),
          open: function() {
            if (this.window.consensus) {
              var button = $(this.window.document.body).find('#Content_PopupFooter_SaveButton');
              var state = new consensus.data.state(button, result, this.window);
              consensus.data.setState(state);
              state.updateScreen();
            }
          },
          cancel: function () {
            state.toggleSave(null);
            state.undo();
          },
          result: function (result) {
              submitLicenseVerifier(state, result, callback);
          }
        });
      }
    }

    function submitLicenseVerifier(state, data, callback) {
      var request = state.createObject();
      request.Signature = data.Signature;
      consensus.network.send({
        url: state.object.uri,
        data: request,
        success: function (result) {
          if (consensus.data.onsave && typeof (consensus.data.onsave) == 'function')
            consensus.data.onsave.call(this, state, result, callback);
          else
            callback.call(this, state, result);
        },
        error: function (request) {
          state.toggleSave(null);
        }
      });
    };

    consensus.data.onsave = validateLicenseVerifier;
    
  </script>
</asp:Content>
