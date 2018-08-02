<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="InvoiceLinesDetails.ascx.cs" Inherits="Consensus.Web.BackOffice.finance.controls.InvoiceLinesDetails" %>

<con:TabControl runat="server">
    <Pages>
        <con:TabPage ID="OverviewTab" runat="server" Title="Overview">
            <div class="row">
                <div class="col-md-6">
                    <con:GroupBox runat="server" Title="Details">
                        <div class="row">
                            <div class="col-md-12">
                                <con:TextField runat="server" ID="ProdName" DataBoundValue="ProdName" LabelText="Product" Requirement="MandatoryEnforced" IsReadOnly="TrueEnforced" />
                            </div>
                        </div>
                        <div class="row">
                            <div class="col-md-12">
                                <con:TextField runat="server" ID="CourseRef" DataBoundValue="Event.Ref" LabelText="Event" IsReadOnly="TrueEnforced" />
                            </div>
                        </div>
                        <div class="row">
                            <div class="col-md-12">
                                <con:PopupField runat="server" ID="Contact" DataBoundValue="Invoice.ProleIdId" DataBoundText="Invoice.ProleId.PersonName" LabelText="Person" IsReadOnly="TrueEnforced" PopupUrl="~/crm/popups/personsearch.aspx" HyperlinkUrl="~/crm/personpage.aspx?role={id}" />
                            </div>
                        </div>

                        <div class="row">
                            <div class="col-md-6">
                                <con:PopupField runat="server" ID="BookingId" DataBoundValue="BookingId" DataBoundText="BookingId" LabelText="Booking ID" PopupUrl="~/learning/popups/elementsearch.aspx?" HyperlinkUrl="~/learning/bookingpage.aspx?id={id}" IsReadOnly="TrueEnforced" />
                            </div>
                            <div class="col-md-6">
                                <con:PopupField runat="server" ID="MemberRef" DataBoundValue="MemeberLocationId" DataBoundText="MelId.Membership.Ref" LabelText="Member number" PopupUrl="~/membership/popups/memberlocationsearch.aspx?" HyperlinkUrl="~/learning/membershippage.aspx?id={id}" IsReadOnly="TrueEnforced" />
                            </div>
                        </div>
                    </con:GroupBox>
                </div>
 
                <div class="col-md-6">
                    <con:GroupBox runat="server" Title="Value">
                        <div class="row">
                            <div class="col-md-6"><con:TextField runat="server" ID="Qty" DataBoundValue="Qty" LabelText="Qty" TextMode="Number" ClientOnChange="calculatePrice()" Requirement="MandatoryEnforced" IsReadOnly="TrueEnforced" /></div>
                            <div class="col-md-6"><con:TextField runat="server" ID="UnitPrice" DataBoundValue="UnitPrice" LabelText="Unit price" TextMode="Number" IsReadOnly="TrueEnforced" ClientOnChange="calculatePrice()" Requirement="MandatoryEnforced" /></div>
                        </div>

                        <div class="row">
                            <div class="col-md-6"><con:TextField runat="server" ID="Net" DataBoundValue="Net" LabelText="Net price" TextMode="Number" IsReadOnly="TrueEnforced" /></div>                          
                            <div class="col-md-6"><con:TextField runat="server" ID="TotalPrice" DataBoundValue="TotalPrice" LabelText="Gross price" TextMode="Number" IsReadOnly="TrueEnforced" /></div>
                        </div>
 
                       <div class="row">
                            <div class="col-md-6">
                                <con:CodeField runat="server" ID="VatCode" DataBoundValue="VatCodeCode" LabelText="VAT" CodeType="VATCD" IsReadOnly="TrueEnforced" ClientOnChange="calculateVAT()" Requirement="MandatoryEnforced">
                                    <Attributes>
                                        <con:ListAttribute runat="server" Name="value3" Value="Value3" />
                                    </Attributes>
                                </con:CodeField>
                            </div>
                            <div class="col-md-6"><con:TextField runat="server" ID="VatRate" DataBoundValue="VatRate" LabelText="VAT rate" TextMode="Number" IsReadOnly="True" /></div>
                                <con:HiddenField runat="server" ID="VatAmount" DataBoundValue="VatAmount" />
                        </div>
                    </con:GroupBox>

                </div>
            </div>

            <div class="row">
                <div class="col-md-12">
                    <con:TextField runat="server" ID="Description" DataBoundValue="Description" LabelText="Description" TextMode="MultiLine" />
                </div>
            </div>
        </con:TabPage>
 
        
        <con:TabPage ID="AnalysisTab" runat="server" Title="Analysis">
            <div class="row">
                <div class="col-md-6"><con:ListField runat="server" ID="CostCode" DataBoundValue="CostCode" LabelText="Cost code" ValueMember="Code" DisplayMember="Desc" /></div>
                <div class="col-md-6"><con:CodeField runat="server" ID="RevCode" DataBoundValue="RevCodeCode" LabelText="Revenue code" CodeType="REVE" /></div>
            </div>
            <div class="row">
                <div class="col-md-6"><con:TextField runat="server" ID="Department" DataBoundValue="Dept" LabelText="Analysis 1" /></div>
                <div class="col-md-6"><con:TextField runat="server" ID="Sku" DataBoundValue="Sku" LabelText="Analysis 2" /></div>
            </div>
            <div class="row">
                <div class="col-md-6"><con:TextField runat="server" ID="JobCode" DataBoundValue="JobCode" LabelText="Analysis 3" /></div>
                <div class="col-md-6"><con:TextField runat="server" ID="JobAnalCode" DataBoundValue="JobAnalCode" LabelText="Analysis 4" /></div>
            </div>
            <div class="row">
                <div class="col-md-6"><con:TextField runat="server" ID="JobType" DataBoundValue="JobType" LabelText="Analysis 5" /></div>
                <div class="col-md-6"><con:TextField runat="server" ID="JobParent" DataBoundValue="JobParent" LabelText="Analysis 6" /></div>
            </div>
        </con:TabPage>
    </Pages>
</con:TabControl>

<script type="text/javascript">

    // calculates the invoice line price totals when quantity or price is changed
    function calculatePrice() {
        var unitprice = parseFloat($('#<%= this.UnitPrice.ClientID %>Field').val());
        var quantity = parseFloat($('#<%= this.Qty.ClientID %>Field').val());
        var vatrate = parseFloat($('#<%= this.VatRate.ClientID %>Field').val());
        var netamount = unitprice * quantity;
        var vatamount = netamount * (vatrate / 100);
        var total = netamount + vatamount;
        $('#<%= this.Net.ClientID %>Field').val(netamount.toFixed(2));
        $('#<%= this.VatAmount.ClientID %>Field').val(vatamount.toFixed(2));
        $('#<%= this.TotalPrice.ClientID %>Field').val(total.toFixed(2));
    }

    // calculates the invoice line VAT amount when the VAT code is changed
    function calculateVAT() {
        var vatCode = $('#<%= this.VatCode.ClientID %>Field').val();
        var vatrate = jQuery.grep($('#<%= this.VatCode.ClientID %>Field option'), function (obj) { return $(obj).val() == vatCode });
        var vatattr = vatrate.length == 0 ? '0' : $(vatrate[0]).attr('data-value3');
        var vatNumb = parseFloat(vatattr);
        $('#<%= this.VatRate.ClientID %>Field').val((isNaN(vatNumb) ? 0 : vatNumb).toFixed(2));
        calculatePrice();
    }

</script>
