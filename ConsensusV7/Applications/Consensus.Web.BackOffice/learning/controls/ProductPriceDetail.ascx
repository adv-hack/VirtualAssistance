<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="ProductPriceDetail.ascx.cs" Inherits="Consensus.Web.BackOffice.learning.controls.ProductPriceDetail" %>

<div class="row">
    <div class="col-md-6">
        <con:ListField runat="server" ID="PriceName" DataBoundValue="PriceListId" DataBoundText="PriceList.Name" LabelText="Name" DisplayMember="Name" ValueMember="Id" Requirement="MandatoryEnforced"  />
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
        <con:CodeField runat="server" DataBoundValue="RegionCode" ID="Region" LabelText="Region" CodeType="ROREG" />
    </div>
</div>
<div class="row">
    <div class="col-md-3">
        <con:TextField runat="server" ID="MinQty" DataBoundValue="QtyMin" LabelText="Min Qty" TextMode="Number" />
    </div>
    <div class="col-md-3">
        <con:TextField runat="server" ID="MaxQty" DataBoundValue="QtyMax" LabelText="Max Qty" TextMode="Number" />
    </div>
    <div class="col-md-3">
        <con:TextField runat="server" ID="Start" DataBoundValue="Start" LabelText="Start" TextMode="Number" />
    </div>
    <div class="col-md-3">
        <con:TextField runat="server" ID="End" DataBoundValue="End" LabelText="End" TextMode="Number" />
    </div>

</div>
<div class="row">
    <div class="col-md-3">
        <con:CodeField runat="server" DataBoundValue="TypeModel.Value1" ID="Type" LabelText="Price Type" CodeType="PRSTY" OnLoadDataSource="Type_OnLoadDataSource" />
    </div>
    <div class="col-md-3">
        <con:TextField runat="server" ID="CurrType" DataBoundValue="CurrType" LabelText="Currency" IsReadOnly="True" Requirement="MandatoryEnforced"/>
    </div>
    <div class="col-md-2">
        <con:TextField runat="server" ID="UnitPrice" DataBoundValue="Amount" LabelText="Unit Price" TextMode="Number" />
    </div>
    <div class="col-md-2">
        <con:TextField runat="server" ID="CostPrice" DataBoundValue="CostPrice" LabelText="Cost Price" TextMode="Number" />
    </div>
    <div class="col-md-2">
        <con:TextField runat="server" ID="RetailPrice" DataBoundValue="RetailPrice" LabelText="Retail Price" TextMode="Number" />
    </div>
</div>

<script>
    $(document).ready(function () {
        //disable the calendar on readonly datepickers
        var validFromcontrol = '#' + '<%=this.ValidFrom.ClientID%>' + 'Group';
        var validTocontrol = '#' + '<%=this.ValidUntil.ClientID%>' + 'Group';
        $(validFromcontrol).datepicker({ enableOnReadonly: false });
        $(validTocontrol).datepicker({ enableOnReadonly: false });
    });
    
 
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