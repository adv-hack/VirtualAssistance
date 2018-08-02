<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="SessionPriceDetail.ascx.cs" Inherits="Consensus.Web.BackOffice.learning.controls.SessionPriceDetail" %>
<con:HiddenField runat="server" ID="Id" DataBoundValue="Id"/>
<con:HiddenField runat="server" ID="PlName" DataBoundValue="PlName" />
<div class="row">
    <div class="col-md-6">
        <con:ListField runat="server" ID="PriceName" DataBoundValue="PlId" LabelText="Name" DisplayMember="Name" ValueMember="Id" Requirement="MandatoryEnforced"  />
    </div>
    <div class="col-md-3">
        <con:DateField runat="server" ID="ValidFrom" DataBoundValue="ValidFrom" LabelText="Valid From" IsReadOnly="True" />
    </div>
    <div class="col-md-3">
        <con:DateField runat="server" ID="ValidUntil" DataBoundValue="ValidUntil" LabelText="Valid Until" IsReadOnly="True" />
    </div>

</div>
<div class="row">
    <div class="col-md-6">
        <con:ListField runat="server" ID="ValidDate" DataBoundValue="ValidDate" LabelText="Valid Date">
            <Items>
                <asp:ListItem Text="Booking" Value="0" />
                <asp:ListItem Text="Event" Value="1" />
            </Items>
        </con:ListField>
    </div>
    <div class="col-md-6">
        <con:CodeField runat="server" DataBoundValue="RegionCodeCode" ID="Region" LabelText="Region" CodeType="ROREG" />
    </div>
</div>
<div class="row">
    <div class="col-md-3">
        <con:TextField runat="server" ID="MinQty" DataBoundValue="QtyMin" LabelText="Minimum quantity" TextMode="Number" />
    </div>
    <div class="col-md-3">
        <con:TextField runat="server" ID="MaxQty" DataBoundValue="QtyMax" LabelText="Maximum quantity" TextMode="Number" />
    </div>
    <div class="col-md-3">
        <con:TextField runat="server" ID="Start" DataBoundValue="StartDay" LabelText="Start" TextMode="Number" />
    </div>
    <div class="col-md-3">
        <con:TextField runat="server" ID="End" DataBoundValue="EndDay" LabelText="End" TextMode="Number" />
    </div>

</div> 
<div class="row">
    <div class="col-md-3">
        <con:ListField runat="server" ID="PriceType" DataBoundValue="Member" LabelText="Price Type">
            <Items>
                <asp:ListItem Text="Standard" Value="0" />
                <asp:ListItem Text="Block" Value="1" />
                <asp:ListItem Text="Member" Value="2" />
            </Items>
        </con:ListField> 
    </div>
    <div class="col-md-3">
        <con:TextField runat="server" ID="CurrType" DataBoundValue="Currency" LabelText="Currency" IsReadOnly="True" Requirement="MandatoryEnforced"/>
    </div>
    <div class="col-md-2">
        <con:TextField runat="server" ID="UnitPrice" DataBoundValue="Price" LabelText="Unit Price" TextMode="Number" />
    </div>
    <div class="col-md-2">
        <con:TextField runat="server" ID="CostPrice" DataBoundValue="CostPrice" LabelText="Cost Price" TextMode="Number" />
    </div>
    <div class="col-md-2">
        <con:TextField runat="server" ID="RetailPrice" DataBoundValue="RetailPrice" LabelText="Retail Price" TextMode="Number" />
    </div>
</div>
<asp:CustomValidator runat="server" ClientValidationFunction="validateMinMaxValues" Display="None" EnableClientScript="true" ErrorMessage="The maximum quantity cannot be less than minimum quantity" />
<asp:CustomValidator runat="server" ClientValidationFunction="validatePrices" Display="None" EnableClientScript="true" ErrorMessage="Prices must be 0 or greater" />
<script>
    $(document).ready(function () {
        var plControl = '#' + '<%=this.PriceName.ClientID%>' + 'Field';
        if ($(plControl).val() != "")
            $(plControl).trigger('change');
        else {
            setTimeout(function () {
                if ($(plControl).val() != "")
                    $(plControl).trigger('change');
            }, 100);
        }
    });
    

    function validateMinMaxValues(source, arguments) {
        var min = $('#<%= this.MinQty.ClientID %>Field').val();
        var max = $('#<%= this.MaxQty.ClientID %>Field').val();
        arguments.IsValid = ((min.length == 0 && max.length == 0) || (min.length > 0 && parseInt(max) >= parseInt(min)));
  }

    function validatePrices(source, arguments) {
        var unit = parseInt($('#<%= this.UnitPrice.ClientID %>Field').val());
        var cost = parseInt($('#<%= this.CostPrice.ClientID %>Field').val());
        var retail = parseInt($('#<%= this.RetailPrice.ClientID %>Field').val());
        var valid = true;
        if ((unit.length > 0 && isNaN(unit)) || unit < 0)
            valid = false;
        else if ((cost.length > 0 && isNaN(cost)) || cost < 0)
            valid = false;
        else if ((retail.length > 0 && isNaN(retail)) || unit < 0)
            valid = false;
        arguments.IsValid =valid;
  }
 
    var PopulatePriceListDetails = function (validFromField, validToField, currField, priceListField, restUrl) {
        this.ValidFromField = validFromField;
        this.ValidToField = validToField;
        this.CurrField = currField;
        this.PriceListField = priceListField;
        this.RestUrl = restUrl;
        this.Update = function () {
            var thisInstance = this;
            var priceList = $('#' + thisInstance.PriceListField).val();

            if (priceList && priceList.length != 0) {
                jQuery.ajax({
                    type: 'GET',
                    dataType: 'json',
                    contentType: 'application/json',
                    url: thisInstance.RestUrl + '/finance/pricelist/' + priceList,
                    error: function (request) {
                        consensus.utilities.displayError(request);
                    },
                    success: function (data, status, request) {
                        $('#' + thisInstance.ValidFromField).datepicker('setDate', new Date(data.ValidFrom));
                        $('#' + thisInstance.ValidToField).datepicker('setDate', new Date(data.ValidUntil));
                        $('#' + thisInstance.CurrField).val(data.Currency);
                    }
                });
            } else {
                $('#' + thisInstance.ValidFromField).val('');
                $('#' + thisInstance.ValidToField).val('');
                $('#' + thisInstance.CurrField).val('');
            }
        }
    }
</script>