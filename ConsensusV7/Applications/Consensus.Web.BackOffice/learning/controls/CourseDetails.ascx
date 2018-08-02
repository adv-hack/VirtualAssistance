<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="CourseDetails.ascx.cs" Inherits="Consensus.Web.BackOffice.learning.controls.CourseDetails" %>
<%@ Register TagPrefix="con" TagName="GenericProductDetails" Src="~/learning/controls/GenericProductDetails.ascx" %>

<div class="row">
    <div class="col-lg-6 consensus-column">
        <con:HiddenField runat="server" ID="SyProduct" DataBoundValue="SyProduct" />
        <con:GroupBox runat="server" Title="Basic Details">
            <con:GenericProductDetails runat="server" ID="GenericProduct" DataBoundId="Id" />
        </con:GroupBox>
    </div>
    <div class="col-lg-6 consensus-column">
        <con:GroupBox runat="server" Title="Course details">
            <div class="row">
                <div class="col-md-6">
                    <con:TextField runat="server" ID="MaxAttend" DataBoundValue="MaxAttend" LabelText="Max Places" >
                        <Validators>
                            <con:Validator runat="server" ClientValidationFunction="CheckIfIntegerForMaxPlace" Critical="true" ErrorMessage="This number must be a positive integer." />
                        </Validators>
                    </con:TextField>
                </div>
                <div class="col-md-6">
                    <con:TextField runat="server" ID="MinAttend" DataBoundValue="MinAttend" LabelText="Min Places">
                        <Validators>
                            <con:Validator runat="server" ClientValidationFunction="CheckIfIntegerForMinPlace" Critical="true" ErrorMessage="This number must be a positive integer." />
                            <con:Validator runat="server" ClientValidationFunction="validateMinMaxPlaces" Critical="true" ErrorMessage="The maximum number of places cannot be less than minimum number of places." />
                        </Validators>
                    </con:TextField>
                </div>
            </div>


            <div class="row">
                <div class="col-md-6">
                    <con:CodeField runat="server" ID="RegBody" DataBoundValue="RegBodyCode" LabelText="Regulatory Body" CodeType="REGBO" />
                </div>
                <div class="col-md-6">
                    <con:TextField runat="server" ID="RegBodyRef" DataBoundValue="RegBodyRef" LabelText="Reference Number" />
                </div>
            </div>

            <div class="row">
                <div class="col-md-6">
                    <con:CodeField runat="server" ID="Acady" DataBoundValue="ActiveProductEvent.AcadyCodeCode" LabelText="Academic year" CodeType="ACADY" />
                </div>
                <div class="col-md-6">
                    <con:TextField runat="server" DataBoundValue="CourseLen" ID="Courselength" LabelText="Course length" Requirement="MandatoryEnforced" TextMode="Number" />
                </div>
            </div>

            <div class="row">
                <div class="col-md-6">
                    <con:ListField runat="server" ID="CutOffTime" DataBoundValue="CutOffTime" LabelText="Cut off Time">
                        <Items>
                            <asp:ListItem Text="Midnight" Value="0" />
                            <asp:ListItem Text="Event Start Time" Value="1" />
                        </Items>
                    </con:ListField>
                </div>
                <div class="col-md-6">
                    <con:TextField runat="server" ID="CutOffPeriod" DataBoundValue="CutOffPeriod" LabelText="Cut off Period" TextMode="Number" />
                </div>

            </div>
            <div class="row">
                <div class="col-md-6">
                    <con:DateField runat="server" DataBoundValue="EntryDate" ID="EntryDate" LabelText="Entry Date" />
                </div>
            </div>
        </con:GroupBox>

        <con:GroupBox runat="server" Title="Venue details">
            <con:PopupField runat="server" ID="Organisation" DataBoundValue="VenueId" DataBoundText="Venue.Name" LabelText="Venue" PopupUrl="~/crm/popups/organisationsearch.aspx" HyperlinkUrl="~/crm/organisationpage.aspx?id={id}" />
            <con:PopupField runat="server" ID="Location" DataBoundValue="LocationId" DataBoundText="Location.Name" LabelText="Location" PopupUrl="~/crm/popups/locationsearch.aspx" HyperlinkUrl="~/learning/locationpage.aspx?id={id}" />
            <con:PopupField runat="server" ID="Man" DataBoundValue="ProleIdId" DataBoundText="ProleId.PersonName" LabelText="Manager" PopupUrl="~/crm/popups/personsearch.aspx" HyperlinkUrl="~/crm/personpage.aspx?role={id}" />
        </con:GroupBox>

    </div>
</div>

<%--<asp:CustomValidator runat="server" ClientValidationFunction="validateMinMaxPlaces" Display="None" EnableClientScript="true" ErrorMessage="The maximum number of places cannot be less than minimum number of places" />--%>
<script type="text/javascript">
    function validateMinMaxPlaces(source, arguments) {
        var min = parseInt($('#<%= this.MinAttend.ClientID %>Field').val());
        var max = parseInt($('#<%= this.MaxAttend.ClientID %>Field').val());
        arguments.IsValid = (isNaN(min) || isNaN(max) || min <= max);
    }

    function CheckIfIntegerForMinPlace(source, args) {
        var regExp = /^[\d]*$/;
        var minimumPlaces = $('#<%= this.MinAttend.ClientID %>Field').val();
        var isValid = regExp.test(minimumPlaces);
        args.IsValid = isValid;
    }

    function CheckIfIntegerForMaxPlace(source, args) {
        var regExp = /^[\d]*$/;
        var maximumPlaces = $('#<%= this.MaxAttend.ClientID %>Field').val();
        if (maximumPlaces) {
            var isValid = regExp.test(maximumPlaces);
            args.IsValid = isValid;
            source.errormessage = "This number must be a positive integer.";
            source.textContent = "This number must be a positive integer.";
        }
        else {
            args.IsValid = false;
            source.errormessage = "This is a required field";
            source.textContent = "This is a required field";
        }
    }

</script>
