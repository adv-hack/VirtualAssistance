<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="BookingInvoiceDetails.ascx.cs" Inherits="Consensus.Web.BackOffice.learning.controls.BookingInvoiceDetails" %>

<%@ Register TagPrefix="con" TagName="InvoiceDetails" Src="~/learning/controls/InvoiceDetails.ascx" %>

<div class="row">
    <div class="col-md-6">
        <con:GroupBox runat="server" Title="Invoice contact">
            <con:InvoiceDetails runat="server" Id="InvoiceDetails" />        
        </con:GroupBox>
        <con:TextField runat="server" ID="InvExtNotes" DataBoundValue="InvExtNotes.Body" LabelText="Invoice Notes" TextMode="MultiLine" />
    </div>

    <div class="col-md-6">
        <con:GroupBox runat="server" Title="Payment information">
           <div class="row">
            <div class="col-md-6"><con:TextField runat="server" ID="CustOrdNo" DataBoundValue="CustOrdNo" LabelText="Purcase Order Number" /></div>
            <div class="col-md-6"><con:CodeField runat="server" ID="PaymentMethod" DataBoundValue="PaymentMethodCode" LabelText="Payment Method" CodeType="PYPAY" /></div>
           </div>
           
          <div class="row"> 
            <div class="col-md-6"><con:CheckField runat="server" ID="DoNotInvoice" DataBoundValue="DoNotInvoice" LabelText="Manual invoice only" /></div>
          </div>  
        </con:GroupBox>
        <con:GroupBox runat="server" Title="Invoice rule">          

          <div class="row">
            <con:HiddenField runat="server" ID="InvoiceRuleOffset" DataBoundValue="InvoiceRuleOffset" />
            <div class="col-md-2"><con:TextField runat="server" ID="OffsetValue" LabelText="Days" TextMode="Number" ClientOnChange="SetInvoiceRuleOffset();"/></div>
            <div class="col-md-2">
                <con:ListField runat="server" ID="OffsetSign"  LabelText="Before/After" ClientOnChange="SetInvoiceRuleOffset();">
                    <Items>
                        <asp:ListItem Text="days before" Value="-1" />
                        <asp:ListItem Text="days after" Value="1" />
                    </Items>
                </con:ListField>
            </div>
            <div class="col-md-8"><con:ListField runat="server" ID="InvoiceRule" DataBoundValue="InvoiceRule" LabelText="Rule" ValueMember="Value1" DisplayMember="Description" /></div>
          </div>


<%--          <div class="row">
            <div class="col-md-6"><con:CodeField runat="server" ID="InvoiceWhenStatus" DataBoundValue="InvoiceWhenStatusCode" LabelText="Invoice bookings at status" CodeType="SSTAT" /></div>
          </div> 
          <div class="row">
            <div class="col-md-6"><con:CheckField runat="server" ID="InvoiceMustUseRule" DataBoundValue="InvoiceMustUseRule" LabelText="Must Use Invoicing Rules" /></div>
          </div> 
          <div class="row">
            <div class="col-md-6"><con:CheckField runat="server" ID="InvoicePerPerson" DataBoundValue="InvoicePerPerson" LabelText="Invoice per Person" /></div>
          </div> --%>
              
        </con:GroupBox>
    </div>
</div>
<script type="text/javascript">
    function SetInvoiceRuleOffset() {
        var OffsetSign = $('#<%= this.OffsetSign.ClientID %>Field').val();
        var OffsetValue = $('#<%= this.OffsetValue.ClientID %>Field').val();
        var InvoiceRuleOffset = 0;

        InvoiceRuleOffset = OffsetValue * OffsetSign;

        $('#<%= this.InvoiceRuleOffset.ClientID %>Field').val(InvoiceRuleOffset);
    }

</script>