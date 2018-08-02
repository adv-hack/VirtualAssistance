<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="CommunicationDetail.ascx.cs" Inherits="Consensus.Web.BackOffice.crm.controls.CommunicationDetail" %>
<con:HiddenField runat="server" DataBoundValue="id" />
<con:HiddenField runat="server" ID="FullValue" DataBoundValue="Communication.DeviceFullValue" />
<div class="row">
  <div class="col-md-8">
    <div class="row">
      <div class="col-md-11">
        <con:CodeField runat="server" ID="CommunicationType" LabelText="Type" CodeType="COMMU" Requirement="MandatoryEnforced" DataBoundValue="Communication.DeviceCodeCode" ClientOnChange="toggleFields();">
          <Attributes>
            <con:ListAttribute Name="DeviceType" Value="Value2" />
            <con:ListAttribute Name="DeviceText" Value="Value3" />
          </Attributes>
        </con:CodeField>
      </div>
    </div>
    <div class="row">
      <div class="col-md-2"><con:TextField runat="server" ID="DiallingCode" DataBoundValue="Communication.DiallingCode" LabelText="Prefix" ClientOnChange="buildFullValue();" /></div>
      <div class="col-md-3"><con:TextField runat="server" ID="StdCode" DataBoundValue="Communication.StdCode" LabelText="Area Code" Requirement="MandatoryEnforced"  ClientOnChange="buildFullValue();" /></div>
      <div class="col-md-4"><con:TextField runat="server" ID="DeviceValue" DataBoundValue="Communication.DeviceValue" Requirement="MandatoryEnforced" MaximumLength="255" ClientOnChange="buildFullValue();" /></div>
      <div class="col-md-2"><con:TextField runat="server" ID="Extension" DataBoundValue="Communication.Extension" LabelText="Ext" /></div>
    </div>
  </div>
  <div class="col-md-4">
    <div class="row">
      <div class="col-6"><con:CheckField runat="server" ID="Active" DataBoundValue="Communication.Active" LabelText="Active" /></div>
      <div class="col-6"><con:CheckField runat="server" ID="Default" DataBoundValue="Communication.Default" LabelText="Default" /></div>
      
    </div>
    <div class="row">
      <div class="col-6"><con:CheckField runat="server" ID="Preferred" DataBoundValue="Communication.Preferred" LabelText="Preferred" /></div>
      <div class="col-6"><con:CheckField runat="server" ID="ExDirectory" DataBoundValue="Communication.ExDirectory" LabelText="Ex Directory" /></div>
    </div>
    <div class="row">
      
      <div class="col-10"><con:DateField runat="server" ID="ValidFrom" DataBoundValue="Communication.ValidFrom" LabelText="Start Date" /></div>
    </div>
  </div>
</div>
<con:TextField runat="server" ID="Notes" DataBoundValue="Communication.Notes" LabelText="Notes" TextMode="MultiLine" />
<script type="text/javascript">

    // Popup initialiser
    function initPopup() {
        toggleFields();
    }

    // Toggles which fields are visible depending on the type of communication
    function toggleFields() {
        var commType = getCommType();
        $('#<%= this.DiallingCode.ClientID %>').parent().toggle(commType.type == 'phone' || commType.type == 'fax' || commType.type == 'mobile');
        $('#<%= this.StdCode.ClientID %>').parent().toggle(commType.type == 'phone' || commType.type == 'fax' || commType.type == 'mobile');
        $('#<%= this.Extension.ClientID %>').parent().toggle(commType.type == 'phone');
        $('#<%= this.DeviceValue.ClientID %>').parent().attr('class', (commType.type == 'phone') ? 'col-md-4' : (commType.type == 'fax' || commType.type == 'mobile') ? 'col-md-6' : 'col-md-11');
        $('#<%= this.DeviceValue.ClientID %>Label').text(commType.text);
    }

    // Updates the hidden field with the concatenated device value
    function buildFullValue() {
        var element1 = $('#<%= this.DiallingCode.ClientID %>Field').val();
        var element2 = $('#<%= this.StdCode.ClientID %>Field').val();
        var element3 = $('#<%= this.DeviceValue.ClientID %>Field').val();
        var element4 = $('#<%= this.FullValue.ClientID %>Field');
        var commType = getCommType();
        switch (commType.type) {
            case 'phone':
            case 'fax':
            case 'mobile':
                element4.val((element1 + ' ' + element2 + ' ' + element3).trim());
                break;
            case 'email':
            case 'web':
                element4.val(element3.trim());
                break;
            default:
                element4.val(element3.trim());
                break;
        }
    }

    // Gets the type of communication, depending on the selected dropdown option
    function getCommType() {
        var dropdown = $('#<%= this.CommunicationType.ClientID %>Field');
        var selected = dropdown.find('option[value="' + dropdown.val() + '"]');
        return { type: (selected.attr('data-devicetype') || '').toLowerCase(), text: selected.attr('data-devicetext') || '' };
    }

    // Ensures the STD code is set as mandatory when defining a phone/fax number.
    consensus.data.validation.bind('<%= this.CommunicationType.ClientID %>', '<%= this.StdCode.ClientID %>', function () { return getCommType() == 'phone' || getCommType() == 'fax'; });
</script>