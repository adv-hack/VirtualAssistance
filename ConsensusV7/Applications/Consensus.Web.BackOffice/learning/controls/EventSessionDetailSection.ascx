<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="EventSessionDetailSection.ascx.cs" Inherits="Consensus.Web.BackOffice.learning.controls.EventSessionDetailSection" %>
<con:HiddenField runat="server" ID="Id" DataBoundValue="Id" />
<con:HiddenField runat="server" ID="SellingCompany" DataBoundValue="SellingCompanyId" />
<con:HiddenField runat="server" ID="VATCode" DataBoundValue="SessionXrefMaster.VATCodeCode" />
<con:HiddenField runat="server" ID="BookedPlaces" />

<div>
    <div class="row">
        <div class="col-md-6">
            <con:PopupField runat="server" ID="CourseName" DataBoundValue="ProductId" DataBoundText="Product.Name" LabelText="Session Course Product" IsReadOnly="True" PopupUrl="~/learning/popups/productsearch.aspx?syProduct=1" HyperlinkUrl="~/learning/coursepage.aspx?id={id}" />
        </div>
        <div class="col-md-3">
            <con:ListField runat="server" ID="Mandatory" DataBoundValue="SessionXrefMaster.Mandatory" LabelText="Mandatory">
                <Items>
                    <asp:ListItem Text="No" Value="0" />
                    <asp:ListItem Text="Yes" Value="1" />
                    <asp:ListItem Text="Recommended" Value="2" />
                </Items>
            </con:ListField>
        </div>
        <div class="col-md-3">
            <con:CheckField runat="server" ID="MainSession" DataBoundValue="SessionXrefMaster.MainSession" LabelText="Main Session"  ClientOnChange="checkMainSession()"  />
            <con:HiddenField runat="server" ID="Real" DataBoundValue="SessionXrefMaster.Real" />
        </div>

    </div>
    <div class="row">
        <div class="col-md-6">
            <con:TextField runat="server" ID="Name" DataBoundValue="Name" LabelText="Session Title" Requirement="MandatoryEnforced" />
        </div>

        <div class="col-md-3">
            <con:ListField runat="server" ID="SelectionGroup" DataBoundValue="SessionXrefMaster.CsgId" DisplayMember="Name" ValueMember="Id" LabelText="Selection Group" />
        </div>
        <div class="col-md-3">
            <con:CheckField runat="server" ID="Element" DataBoundValue="SessionXrefMaster.Element" LabelText="Element" />
        </div>
    </div>
    <div class="row">
        <div class="col-md-3">
            <con:DateField runat="server" ID="StartDate" DataBoundValue="ActionDate" LabelText="Start Date" Requirement="MandatoryEnforced" />
        </div>
        <div class="col-md-3">
            <con:TimeField runat="server" ID="StartTime" DataBoundValue="Time" LabelText="Start Time" />
        </div>
        <div class="col-md-3">
            <con:TextField runat="server" ID="StudentWeeks" DataBoundValue="StudWks" LabelText="Student Weeks" TextMode="Number" />
        </div>

        <div class="col-md-3">
            <con:CheckField runat="server" ID="ShowOnBooking" DataBoundValue="SessionXrefMaster.ShowSales" LabelText="Show On Booking" />
        </div>

    </div>
    <div class="row">
        <div class="col-md-3">
            <con:DateField runat="server" ID="EndDate" DataBoundValue="EndDate" LabelText="End Date" Requirement="MandatoryEnforced">
                <Validators>
                    <con:Validator runat="server" ClientValidationFunction="validateDates" Critical="true" ErrorMessage="End date must be after the start date" />
                </Validators>
            </con:DateField>
        </div>
        <div class="col-md-3">
            <con:TimeField runat="server" ID="EndTime" DataBoundValue="EndTime" LabelText="End Time"/>
        </div>
        <div class="col-md-3">
            <con:TextField runat="server" ID="TeachHrs" DataBoundValue="TeachHrs" LabelText="Teaching Hours" TextMode="Number" />
        </div>
        <div class="col-md-3">
            <con:CheckField runat="server" ID="PrintInvoice" DataBoundValue="SessionXrefMaster.InvPrint" LabelText="Show On Invoice" />
        </div>

    </div>
    <div class="row">
        <div class="col-md-2">
            <con:TextField runat="server" ID="MaxPlaces" DataBoundValue="MaxPlaces" LabelText="Maximum Places" TextMode="Number"  ClientOnChange="updateFreePlaces();">
               
            </con:TextField>
        </div>
        <div class="col-md-2">
            <con:TextField runat="server" ID="MinPlaces" DataBoundValue="MinPlaces" LabelText="Minimum Places" TextMode="Number" />
        </div>
        <div class="col-md-2">
            <con:TextField runat="server" ID="FreePlaces" DataBoundValue="FreePlaces" LabelText="Free Places" TextMode="Number" IsReadOnly="True" />
        </div>
        <div class="col-md-3">
            <con:CheckField runat="server" ID="ShowAttLog" DataBoundValue="ShowAttLog" LabelText="Show On Attendance Log" />
        </div>
        <div class="col-md-3">
            <con:CheckField runat="server" ID="SessionComplete" DataBoundValue="DoneIt" LabelText="Session Complete" />

        </div>
    </div>
</div>
<con:Validator runat="server" ClientValidationFunction="validateMaxPlaces" Critical="true" ErrorMessage="Minimum places must be less than the maximum places" />
<script>
  $(document).ready(function () {
      checkMainSession();
  });

  function checkMainSession() {
    var mainSession = $('#<%= this.MainSession.ClientID %>Field').prop("checked");

    if (mainSession) {
      $('#<%= this.Mandatory.ClientID %>Field').val('1');
      $('#<%= this.ShowOnBooking.ClientID %>Field').bootstrapSwitch("state", true);
    }
    $('#<%= this.Mandatory.ClientID %>Field').attr('readonly', mainSession ? 'readonly' : null).attr('disabled', mainSession ? 'disabled' : null);
  }

   function updateFreePlaces() {
        var bookedPlaces = parseFloat($('#<%= this.BookedPlaces.ClientID%>Field').val());
        var maxPlaces = parseFloat($('#<%= this.MaxPlaces.ClientID%>Field').val());
        $('#<%= this.FreePlaces.ClientID%>Field').val(maxPlaces - bookedPlaces);
    }
</script>








