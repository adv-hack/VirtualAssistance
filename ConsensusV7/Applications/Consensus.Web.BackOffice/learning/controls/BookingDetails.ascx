<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="BookingDetails.ascx.cs" Inherits="Consensus.Web.BackOffice.learning.controls.BookingDetails" %>
<%@ Register TagPrefix="con" TagName="BookerDetails" Src="~/learning/controls/BookerDetails.ascx" %>

<div class="row">
     <div class="col-md-6">
        <con:GroupBox runat="server" Title="Booking details">
          <div class="row" id="BookingRef">
            <div class="col-md-6"><con:TextField runat="server" ID="Ref" DataBoundValue="Id" LabelText="Reference" IsReadOnly="True"/></div>
            <div class="col-md-6"><con:TextField runat="server" ID="Status" DataBoundValue="Status" LabelText="Status" IsReadOnly="True"/></div>
          </div>
          
          <div class="row">
            <div class="col-md-6"><con:ListField runat="server" ID="CurrencyType" DataBoundValue="CurrencyType" LabelText="Currency" ValueMember="Code" DisplayMember="Code" IsReadOnly="True"/></div>
            <div class="col-md-6"><con:TextField runat="server" ID="NetTotal" LabelText="Net total" TextMode="Number" IsReadOnly="True" /></div>
          </div>
          
          <div class="row">
            <div class="col-md-6"><con:TextField runat="server" ID="GrossTotal" LabelText="Gross total" TextMode="Number" IsReadOnly="True" /></div>
            <div class="col-md-6"><con:TextField runat="server" ID="VATTotal" LabelText="VAT" TextMode="Number" IsReadOnly="True" /></div>
          </div>

          <div class="row">
            <div class="col-md-6"><con:CodeField runat="server" ID="BookingMethod" DataBoundValue="BookingMethodCode" LabelText="Booking method" CodeType="BOOKM" /></div>
            <div class="col-md-6"><Con:PopupField runat="server" ID="SourceCode" DataBoundValue="SourceCodeId" DataBoundText="SourceCode.Name" LabelText="Source code" PopupUrl="~/marketing/popups/promotionsearch.aspx" HyperlinkUrl="~/marketing/sourcepage.aspx?id={id}" /></div>  
          </div>

          <div class="row">
            <div class="col-md-6"><con:CheckField runat="server" ID="Invoiced" DataBoundValue="Invoiced" LabelText="Invoiced" IsReadOnly="True"/></div>
            <div class="col-md-6"><con:DateField runat="server" ID="Confirmed" DataBoundValue="Confirmed" LabelText="Confirmation date" IsReadOnly="True"/></div>

          </div>
          <div class="row" id="divCancel">
            <div class="col-md-6"><con:DateField runat="server" ID="CancelDate" DataBoundValue="CancelDate" LabelText="Cancellation date" IsReadOnly="True"/></div>
            <div class="col-md-6"><con:TextField runat="server" ID="CancelRef" DataBoundValue="CancelRef" LabelText="Cancellation reference" IsReadOnly="True"/></div>
          </div>         
          <div class="row"  >
             <div class="col-md-6"><con:ListField runat="server" ID="SellCompName" DataBoundValue="SellingCompanyId" DataBoundText="SellingCompany.Name" LabelText="Selling company" DisplayMember="Name" ValueMember="Id" Requirement="MandatoryEnforced" /></div>           
         </div>


        </con:GroupBox>
    </div>
    
   
    <div class="col-md-6"> 
        <con:GroupBox runat="server" Title="Booker information">
            <con:BookerDetails runat="server" Id="BookerDetails"  />
        </con:GroupBox>
    </div>
    <div class="col-md-12">
        <div class="row">
            <div class="col-md-12"><con:TextField runat="server" ID="Notes" DataBoundValue="Notes.Body" LabelText="Notes" TextMode="MultiLine" /></div>
        </div>
        <div class="row" id="divPersonTerms">
            <div class="col-md-12"><con:TextField runat="server" ID="PersonSpecialTerms" DataBoundValue="BookerRole.Person.SpecialTerms" LabelText="Person Special Terms"  IsReadOnly="True"/></div>
        </div>
        <div class="row" id="divOrgTerms">
            <div class="col-md-12"><con:TextField runat="server" ID="OrgSpecialTerms" DataBoundValue="BookerOrg.SpecialTerms" LabelText="Organisation Special Terms" IsReadOnly="True"/></div>
        </div>
        <div class="row" id="divAccountTerms">
            <div class="col-md-12"><con:TextField runat="server" ID="AccSpecialTerms" DataBoundValue="Account.SpecialTerms" LabelText="Person Special Terms"  IsReadOnly="True"/></div>
        </div>
    </div>
</div>
<script>
    $(document).ready(function () {
        AmendFields();
 
    });
    function AmendFields() {
        var RefValue = $('#<%= this.Ref.ClientID %>Field').val();
        var Status = $('#<%= this.Status.ClientID %>Field').val();
        var PersonSpecialTerms = $('#<%= this.PersonSpecialTerms.ClientID %>Field').val();
        var OrgSpecialTerms = $('#<%= this.OrgSpecialTerms.ClientID %>Field').val();
        var AccSpecialTerms = $('#<%= this.AccSpecialTerms.ClientID %>Field').val();
        var CurrencyTypecontrol = '#' + '<%=this.CurrencyType.ClientID%>' + 'Group';
        if (RefValue == "") {
            document.getElementById("BookingRef").hidden = true;
           
            $(CurrencyTypecontrol).listfield({ enableOnReadonly: true });

        }
        if (Status != "99-cancelled")
        {
            document.getElementById("divCancel").hidden = true;
        }
        if (PersonSpecialTerms == "")
        {
            document.getElementById("divPersonTerms").hidden = true;
        }
        if (OrgSpecialTerms == "") {
            document.getElementById("divOrgTerms").hidden = true;
        }
        if (AccSpecialTerms == "") {
            document.getElementById("divAccountTerms").hidden = true;
        }
    };
</script>