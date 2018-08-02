<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="TimeLogDetail.ascx.cs" Inherits="Consensus.Web.BackOffice.crm.controls.TimeLogDetail" %>

<div class="row">
    <div class="col-md-6">
        <con:GroupBox runat="server" Title="Time Log">
            <div class="row">
                <div class="col-md-6">
                    <con:PopupField runat="server" ID="Person" DataBoundValue="RoleId" LabelText="Person" PopupUrl="~/crm/popups/personsearch.aspx" HyperlinkUrl="~/crm/popups/personsearch.aspx?role={id}" Requirement="MandatoryEnforced"></con:PopupField>
                </div>
                <div class="col-md-6">
                    <con:DateField runat="server" ID="Date" DataBoundValue="Date" LabelText="Date" Requirement="MandatoryEnforced" />
                </div>
            </div>
            <div class="row">
                <div class="col-md-6">
                    <con:ListField runat="server" DataBoundValue="Type" ID="TimeAgainst" LabelText="Logged Against" Requirement="MandatoryEnforced" ClientOnChange="EnableDisableControls()">
                        <Items>
                            <asp:ListItem Text="" Value="" />
                            <asp:ListItem Text="Activity" Value="Activity" />
                            <asp:ListItem Text="Event" Value="Session" />
                        </Items>
                    </con:ListField>
                </div>
                <div class="col-md-6">
                    <con:CodeField runat="server" ID="Type" DataBoundValue="TimTypeDropdownCode" LabelText="Type" CodeType="TMDD1" />
                </div>
            </div>
            <div class="row">
                <div class="col-md-6">
                    <con:PopupField runat="server" ID="Activity" LabelText="Activity" PopupUrl="~/crm/popups/ActivitySearch.aspx" HyperlinkUrl="~/learning/ActivityDetailBasic.aspx?id={id}" IsReadOnly="True" ClientOnChange="GetActvityId()">
                        <Validators>
                            <con:Validator runat="server" ClientValidationFunction="CheckIfValidActivity" Critical="true" ErrorMessage="Please select an activity." />
                        </Validators>
                    </con:PopupField>
                </div>
                <div class="col-md-6">
                    <con:PopupField runat="server" ID="Event" LabelText="Event" PopupUrl="~/learning/popups/EventSearch.aspx" HyperlinkUrl="~/learning/EventPage.aspx?id={id}" IsReadOnly="True" ClientOnChange="GetSessions()">
                        <Validators>
                            <con:Validator runat="server" ClientValidationFunction="CheckIfValidEvent" Critical="true" ErrorMessage="Please select an event." />
                        </Validators>
                    </con:PopupField>
                </div>
            </div>
            <div class="row">
                <div class="col-md-12">
                    <con:ListField runat="server" ID="EventSessionList" LabelText="Session" IsReadOnly="True" ClientOnChange="BindSessionValue()">
                        <Validators>
                            <con:Validator runat="server" ClientValidationFunction="CheckIfValidSession" Critical="true" ErrorMessage="Please select a session." />
                        </Validators>
                    </con:ListField>
                    <con:ListField runat="server" ID="ServerSessionList" IsHidden="TrueEnforced" />
                </div>
            </div>
            <con:HiddenField runat="server" ID="EventId" DataBoundValue="ActId"></con:HiddenField>
            <con:HiddenField runat="server" ID="TIM_TRAIN_SY_TYPE" DataBoundValue="TrainSyType"></con:HiddenField>
        </con:GroupBox>
    </div>
    <div class="col-md-6">
        <con:GroupBox runat="server" Title="Time and Expense Recording">
            <div class="row">
                <div class="col-md-6">
                    <con:TextField runat="server" ID="ActualHrs" DataBoundValue="Hours" LabelText="Actual Hours" TextMode="Number" Requirement="MandatoryEnforced" />
                </div>
                <div class="col-md-6">
                    <con:TextField runat="server" ID="ChargeableHrs" DataBoundValue="HouCharge" LabelText="Chargeable Hours" TextMode="Number" />
                </div>
            </div>
            <div class="row">
                <div class="col-md-6">
                    <con:TextField runat="server" ID="TravelHrs" DataBoundValue="TraHours" LabelText="Travel Hours" TextMode="Number" />
                </div>
                <div class="col-md-6">
                    <con:TextField runat="server" ID="ChargeableTravelHrs" DataBoundValue="TraCharge" LabelText="Chargeable Travel Hours" TextMode="Number" />
                </div>
            </div>
            <div class="row">
                <div class="col-md-6">
                    <con:TextField runat="server" ID="Mileage" DataBoundValue="Mileage" LabelText="Mileage" />
                </div>
                <div class="col-md-6">
                    <con:TextField runat="server" ID="Expenses" DataBoundValue="Expenses" LabelText="Expenses" />
                </div>
            </div>
            <div class="row">
                <div class="col-md-6">
                    <con:TextField runat="server" ID="Cost" DataBoundValue="CstAc" LabelText="Cost" />
                </div>
                <div class="col-md-6">
                    <con:ListField runat="server" DataBoundValue="UntType" ID="UnitTypeList" LabelText="Per">
                        <Items>
                            <asp:ListItem Text="" Value="" />
                            <asp:ListItem Text="Hour" Value="H" />
                            <asp:ListItem Text="Day" Value="D" />
                        </Items>
                    </con:ListField>
                </div>
            </div>
        </con:GroupBox>
    </div>
</div>
<div class="row">
    <div class="col-md-12">
        <con:TextField runat="server" ID="Description" DataBoundValue="Desc" LabelText="Description" TextMode="MultiLine" Requirement="MandatoryEnforced" />
    </div>
</div>

<script type="text/javascript">

    $(document).ready(function () {
        EnableDisableControls();
        var dataMode = $('#DetailPageContent', parent.document).attr('data-mode');
        if (dataMode && dataMode == 'read') {
            GetSessions();
        }
    });

    function EnableDisableControls() {
        var timeAgainstValue = $('#<%= this.TimeAgainst.ClientID %>Field');
        var $activity = $('#<%= this.Activity.ClientID %>Field');
        if (timeAgainstValue.val() == "Activity") {
            $('#<%= this.Activity.ClientID %>Field').removeAttr("disabled");
                $('#<%= this.Activity.ClientID %>Group').find("span").removeAttr("disabled");
                $('#<%= this.Activity.ClientID %>Field').removeAttr("readonly");
                $('#<%= this.Activity.ClientID %>Group').find("span").removeAttr("readonly");
                $('#<%= this.Event.ClientID %>Field').attr("disabled", "disabled");
                $('#<%= this.Event.ClientID %>Group').find("span").attr("disabled", "disabled");
                $('#<%= this.Event.ClientID %>Field').attr("readonly", "readonly");
                $('#<%= this.Event.ClientID %>Group').find("span").attr("readonly", "readonly");
                $('#<%= this.EventSessionList.ClientID %>Field').attr("disabled", "disabled"); 
                $('#<%= this.EventSessionList.ClientID %>Field').attr("readonly", "readonly");
                if ($('#<%= this.Event.ClientID %>').find(".consensus-validator")) {
                    $('#<%= this.Event.ClientID %>').find(".consensus-validator").css({ "display": "none" });
                //$('#<%= this.Event.ClientID %>').find(".consensus-validator").remove();
                $('#<%= this.Event.ClientID %>').removeClass("has-error")
            }
            $('#<%= this.Event.ClientID %>Field').val('');
            $('#<%= this.EventSessionList.ClientID %>Field').empty();
            }
            else if (timeAgainstValue.val() == "Session") {
                $('#<%= this.Event.ClientID %>Field').removeAttr("disabled");
            $('#<%= this.Event.ClientID %>Group').find("span").removeAttr("disabled");
            $('#<%= this.Event.ClientID %>Field').removeAttr("readonly");
            $('#<%= this.Event.ClientID %>Group').find("span").removeAttr("readonly");
            $('#<%= this.EventSessionList.ClientID %>Field').removeAttr("disabled");
            $('#<%= this.EventSessionList.ClientID %>Field').removeAttr("readonly");
            $('#<%= this.Activity.ClientID %>Field').attr("disabled", "disabled");
            $('#<%= this.Activity.ClientID %>Group').find("span").attr("disabled", "disabled");
            $('#<%= this.Activity.ClientID %>Field').attr("readonly", "readonly");
            $('#<%= this.Activity.ClientID %>Group').find("span").attr("readonly", "readonly");
            if ($('#<%= this.Activity.ClientID %>').find(".consensus-validator")) {
                $('#<%= this.Activity.ClientID %>').find(".consensus-validator").css({ "display": "none" });
                $('#<%= this.Activity.ClientID %>').removeClass("has-error")
            }
            $('#<%= this.Activity.ClientID %>Field').val('');
        }
        else {

            $('#<%= this.Event.ClientID %>Field').attr("disabled", "disabled");
            $('#<%= this.EventSessionList.ClientID %>Field').attr("disabled", "disabled");
            $('#<%= this.Event.ClientID %>Field').attr("readonly", "readonly");
            $('#<%= this.EventSessionList.ClientID %>Field').attr("readonly", "readonly");
            $('#<%= this.Activity.ClientID %>Field').attr("disabled", "disabled");
            $('#<%= this.Activity.ClientID %>Field').attr("readonly", "readonly");
            $('#<%= this.Activity.ClientID %>Group').find("span").attr("disabled", "disabled");
            $('#<%= this.Activity.ClientID %>Group').find("span").attr("readonly", "readonly");
            $('#<%= this.Event.ClientID %>Group').find("span").attr("disabled", "disabled");
            $('#<%= this.Event.ClientID %>Group').find("span").attr("readonly", "readonly");
        }
}

function GetSessions() {
    $('#<%= this.EventSessionList.ClientID %>Field').empty();

    var selectedEvent = window['<%= this.Event.ClientID %>'].getValue();
    var serverSessionList = document.getElementById("<%= this.ServerSessionList.ClientID %>Field").options;
    var addBlankEntry = true;

    for (var i = 0; i < serverSessionList.length; i++) {
        if (serverSessionList[i].text) {
            var value = serverSessionList[i].text.split("[")[1].split(",");
            var typeValue = value[1].split("]")[0].trim();
            var displayValue = typeValue;
            var course_Id = '0';
            if (typeValue.indexOf('=') != -1) {
                displayValue = typeValue.substr(0, typeValue.indexOf('='));
                course_Id = typeValue.substr(typeValue.indexOf('=') + 1, typeValue.length);
            }
            if (course_Id == selectedEvent) {
                //Inserts empty value for first time                    
                if (addBlankEntry) {
                    $('#<%= this.EventSessionList.ClientID %>Field').append('<option value="' + '' + '">' + '' + '</option>');
                }
                addBlankEntry = false;
                $('#<%= this.EventSessionList.ClientID %>Field').append('<option value="' + value[0] + '">' + displayValue + '</option>');
            }
        }
    }
    var selected_Session = $('#<%= this.EventId.ClientID %>Field').val();
    $('#<%= this.EventSessionList.ClientID %>Field').val(selected_Session);

}


function CheckIfValidActivity(source, args) {

    var timeAgainstValue = $('#<%= this.TimeAgainst.ClientID %>Field').val();
    if (timeAgainstValue == "Activity") {

        var Activity = $('#<%= this.Activity.ClientID %>Field').val();
        if (!Activity) {
            args.IsValid = false;
            source.errormessage = "Please select an activity.";
            source.textContent = "Please select an activity.";
        }
    }

    return args.IsValid;
}

function CheckIfValidEvent(source, args) {

    var timeAgainstValue = $('#<%= this.TimeAgainst.ClientID %>Field').val();
    if (timeAgainstValue == "Session") {

        var event = $('#<%= this.Event.ClientID %>Field').val();
        if (!event) {
            args.IsValid = false;
            source.errormessage = "Please select an event.";
            source.textContent = "Please select an event.";
        }
    }

    return args.IsValid;
}

function CheckIfValidSession(source, args) {
    args.IsValid = true;
    var timeAgainstValue = $('#<%= this.TimeAgainst.ClientID %>Field').val();
    if (timeAgainstValue == "Session") {

        var event = $('#<%= this.Event.ClientID %>Field').val();
        if (event) {
            var session = $('#<%= this.EventSessionList.ClientID %>Field').val();
            if (!session) {
                args.IsValid = false;
                source.errormessage = "Please select a session.";
                source.textContent = "Please select a session.";
            }
        }
    }

    return args.IsValid;
}

function BindSessionValue() {
    var selected_Session = $('#<%= this.EventSessionList.ClientID %>Field').val();
    $('#<%= this.EventId.ClientID %>Field').val(selected_Session);
}

function GetActvityId() {
    var selectedActivity = window['<%= this.Activity.ClientID %>'].getValue();
        $('#<%= this.EventId.ClientID %>Field').val(selectedActivity);
    }

</script>
