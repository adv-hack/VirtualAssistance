<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="EventSelectionGroupDetail.ascx.cs" Inherits="Consensus.Web.BackOffice.learning.controls.EventSelectionGroupDetail" %>

<div class="row">
    <div class="col-md-12">
        <con:TextField runat="server" ID="Name" DataBoundValue="Name" LabelText="Name" Requirement="MandatoryEnforced" />
    </div>
</div>
<div class="row">
    <div class="col-md-12">
        <con:TextField runat="server" ID="Description" DataBoundValue="Description" LabelText="Description" />
    </div>
</div>
<div class="row">
    <div class="col-md-6">
        <con:TextField runat="server" ID="Minimum" DataBoundValue="Min" LabelText="Minimum" Requirement="MandatoryEnforced" TextMode="Number" />
    </div>
    <div class="col-md-6">
        <con:TextField runat="server" ID="Maximum" DataBoundValue="Max"  LabelText="Maximum" Requirement="MandatoryEnforced" TextMode="Number"/>
    </div>
</div>
<div class="row">
    <div class="col-md-12">
        <con:TextField runat="server" ID="ErrorMessage" DataBoundValue="ErrorMessage" LabelText="Warning message" TextMode="MultiLine" />
    </div>
</div>
<asp:CustomValidator runat="server" ClientValidationFunction="validateMinMaxValues" Display="None" EnableClientScript="true" ErrorMessage="The maximum number cannot be less than minimum number" />
<script type="text/javascript">
    function validateMinMaxValues(source, arguments) {
        var min = parseInt($('#<%= this.Minimum.ClientID %>Field').val());
        var max = parseInt($('#<%= this.Maximum.ClientID %>Field').val());
        arguments.IsValid = (isNaN(min) || isNaN(max) || min <= max);
        if (arguments.IsValid && max > 99)
            $('#<%= this.Maximum.ClientID %>Field').val(99);
        if (arguments.IsValid && min > 99)
            $('#<%= this.Minimum.ClientID %>Field').val(99);
  }
</script>

