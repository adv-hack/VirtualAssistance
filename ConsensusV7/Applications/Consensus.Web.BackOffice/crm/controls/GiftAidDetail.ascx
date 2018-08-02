<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="GiftAidDetail.ascx.cs" Inherits="Consensus.Web.BackOffice.crm.controls.GiftAidDetail" %>



<div class="row">
    <div class="col-md-12">
        <con:DateField runat="server" DataBoundValue="StartDate" ID="StartDate" LabelText="Start Date" Requirement="MandatoryEnforced" />
    </div>
</div>
<div class="row">
    <div class="col-md-12">
        <con:DateField runat="server" DataBoundValue="EndDate" ID="EndDate" LabelText="End Date" />
    </div>

    <div class="col-md-12">
        <con:CodeField runat="server" ID="Type" DataBoundValue="TypeCode" LabelText="Declaration method" CodeType="DECLA" Requirement="MandatoryEnforced" />
    </div>
    <div class="col-md-12">
        <con:CheckField runat="server" DataBoundValue="Communication" ID="Communication" LabelText="Communication Sent" />
    </div>
</div>
<br />
<br />
<br />

<con:Validator runat="server" ClientValidationFunction="CheckIfDatesAreValid" ErrorMessage="" />

<script type="text/javascript">
    function CheckIfDatesAreValid(source, args) {
        args.IsValid = true;
        var startDate = new Date($('#<%= this.StartDate.ClientID %>Field').val());
        startDate.setHours(0, 0, 0, 0);
        var endDate = new Date($('#<%= this.EndDate.ClientID %>Field').val());
        endDate.setHours(0, 0, 0, 0);        
        var currentDate = new Date();
        currentDate.setHours(0, 0, 0, 0);

        if (endDate.getTime() < startDate.getTime()) {
            args.IsValid = false;
            source.errormessage = "End date must be after start date.";
        }
        else {            
            if (endDate.getTime() < currentDate.getTime()) {
                args.IsValid = false;
                source.errormessage = "End date cannot be less than current date.";
            }
        }
    }
</script>
