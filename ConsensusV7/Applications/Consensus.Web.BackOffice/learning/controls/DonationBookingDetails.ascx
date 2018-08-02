<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="DonationBookingDetails.ascx.cs" Inherits="Consensus.Web.BackOffice.learning.controls.DonationBookingDetails" %>
<%@ Register TagPrefix="con" TagName="BookerDetails" Src="~/learning/controls/BookerDetails.ascx" %>

<div class="row">
    <div class="col-md-6">
        <con:GroupBox runat="server" Title="Donation details">
          <div class="row" id="BookingRef">
            <div class="col-md-6"><con:TextField runat="server" ID="Ref" DataBoundValue="Id" LabelText="Donation reference" IsReadOnly="True"/></div>              
            <div class="col-md-6"><con:TextField runat="server" ID="Status" DataBoundValue="Status" LabelText="Status" IsReadOnly="True"/></div>
          </div>

          
          <div class="row">
            <div class="col-md-6"><con:ListField runat="server" ID="CurrencyType" DataBoundValue="CurrencyType" IsReadOnly="True" LabelText="Currency" ValueMember="Code" DisplayMember="Code" /></div>
            <div class="col-md-6"><con:TextField runat="server" ID="NetTotal" LabelText="Donation value" TextMode="Number" IsReadOnly="True" /></div>
          </div> 
          
          <div class="row">
            <div class="col-md-6"><con:TextField runat="server" ID="GiftAid" LabelText="Gift Aid value" TextMode="Number" IsReadOnly="True" /></div>
            <div class="col-md-6"><con:TextField runat="server" ID="GrossTotal" LabelText="Total value" TextMode="Number" IsReadOnly="True" /></div>
          </div>  

          <div class="row">
            <div class="col-md-12"><con:TextField runat="server" ID="ForAttentionOf" DataBoundValue="ForAttentionOf" LabelText="On behalf of"/></div>
          </div>

          <div class="row">
            <div class="col-md-6"><con:CodeField runat="server" ID="BookingMethod" DataBoundValue="BookingMethodCode" LabelText="Donation method" CodeType="BOOKM" /></div>
            <div class="col-md-6"><Con:PopupField runat="server" ID="SourceCode" DataBoundValue="SourceCodeId" DataBoundText="SourceCode.Name" LabelText="Source code" PopupUrl="~/marketing/popups/promotionsearch.aspx" HyperlinkUrl="~/marketing/sourcepage.aspx?id={id}" /></div>             
          </div>            
            <con:ListField runat="server" ID="SellCompName" DataBoundValue="SellingCompanyId" IsReadOnly="True" DataBoundText="SellingCompany.Name" LabelText="Selling Company" DisplayMember="Name" ValueMember="Id" Requirement="MandatoryEnforced" />
        </con:GroupBox>
        </div>
          <div class="col-md-6"> 
        <con:GroupBox runat="server" Title="Contact information">
            <con:BookerDetails runat="server" Id="BookerDetails" />
        </con:GroupBox>
    </div>
</div>
<script>
    $(document).ready(function () {
        AmendFields();
 
    });
    function AmendFields() {
        var RefValue = $('#<%= this.Ref.ClientID %>Field').val();
        var CurrencyTypecontrol = '#' + '<%=this.CurrencyType.ClientID%>' + 'Group';
        if (RefValue == "") {
            document.getElementById("BookingRef").hidden = true;
           
            $(CurrencyTypecontrol).listfield({ enableOnReadonly: false });

        }


    };
</script>