<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="WorkflowDetails.ascx.cs" Inherits="Consensus.Web.BackOffice.Other.controls.WorkflowDetails" %>

<div class="row">
    <div class="col-md-6"> 
        <con:GroupBox runat="server" Title="Workflow Details">
            <con:TextField runat="server" ID="Name" DataBoundValue="Name" LabelText="Name" Requirement="MandatoryEnforced" />

            <con:ListField runat="server" ID="RecType" DataBoundValue="RecType" LabelText="Type" ValueMember="RecType" DisplayMember="RecType" Requirement="MandatoryEnforced"/>

            <con:ListField runat="server" ID="Group" DataBoundValue="Group" LabelText="Group" />

            <con:CheckField runat="server" DataBoundValue="Disabled" ID="Disabled" LabelText="Disabled" />

            <con:TextField runat="server" ID="Desc" DataBoundValue="Desc" LabelText="Description" TextMode="MultiLine" />
        </con:GroupBox>
    </div>

    <div class="col-md-6"> 
        <con:GroupBox runat="server" Title="Configuration">

            <div class="row">
                <div class="col-md-6"><con:TextField runat="server"  ID="LastRunDttime" LabelText="Last Run Date" IsReadOnly="TrueEnforced" TextMode="DateTime" /></div>
                <div class="col-md-6"><con:TextField runat="server"  ID="RunDatetime" LabelText="Next Run Date" IsReadOnly="TrueEnforced" TextMode="DateTime" /></div>
            </div>
            <div class="row">
                <div class="col-md-6"><con:DateField runat="server" DataBoundValue="ValidFromDate" ID="ValidFromDate" LabelText="Valid From Date" /></div>
                <div class="col-md-6"><con:DateField runat="server" DataBoundValue="ValidToDate" ID="ValidToDate" LabelText="Valid To Date" /></div>
            </div>
            <con:ListField runat="server" ID="Occurs" DataBoundValue="Occurs" Requirement="MandatoryEnforced" LabelText="Occurs" >
                <Items>
                    <asp:ListItem Text="Daily" Value="0" />
                    <asp:ListItem Text="Weekly" Value="1" />
                    <asp:ListItem Text="Recurring" Value="2" />
                </Items>
             </con:ListField>
            <div class="row" id="divTime">
                <div class="col-md-6"><con:TimeField runat="server" ID="NormalTime" DataBoundValue="NormalTime" LabelText="Time"/></div>
                <div class="col-md-6" id="divDayOfWeek">
                     <con:ListField runat="server" ID="DayOfWeek" DataBoundValue="DayOfWeek" Requirement="MandatoryEnforced" LabelText="Day" >
                        <Items>
                            <asp:ListItem Text="Monday" Value="0" />
                            <asp:ListItem Text="Tuesday" Value="1" />
                            <asp:ListItem Text="Wednesday" Value="2" />
                            <asp:ListItem Text="Thursday" Value="3" />
                            <asp:ListItem Text="Friday" Value="4" />
                            <asp:ListItem Text="Saturday" Value="5" />
                            <asp:ListItem Text="Sunday" Value="6" />
                        </Items>
                     </con:ListField>
                </div>
            </div>
            <div class="row" id="divFrequency">
                <div class="col-md-6"><con:TextField runat="server" ID="Frequency" DataBoundValue="Frequency" LabelText="Time Gap" TextMode="Number"/></div>
                <div class="col-md-6">
                     <con:ListField runat="server" ID="DailyFreq" DataBoundValue="DailyFreq" Requirement="MandatoryEnforced" LabelText="Time unit" >
                        <Items>
                            <asp:ListItem Text="Minutes" Value="0" />
                            <asp:ListItem Text="Hours" Value="1" />
                            <asp:ListItem Text="Days" Value="2" />
                            <asp:ListItem Text="Weeks" Value="3" />
                            <asp:ListItem Text="Months" Value="4" />
                        </Items>
                     </con:ListField>
                </div>
            </div>
        </con:GroupBox>
    </div>
</div>

<script>
    $(document).ready(function () {
        //hide fields
        HideFrequencyFields();
 
    });
    function HideFrequencyFields() {
        var OccursValue = $('#<%= this.Occurs.ClientID %>Field').val();
        if (OccursValue < 2) {
            document.getElementById("divFrequency").hidden = true;
            document.getElementById("divTime").hidden = false;
            if (OccursValue == 0) {
                document.getElementById("divDayOfWeek").hidden = true;
            }
            else {
                document.getElementById("divDayOfWeek").hidden = false;
            }
        }
        else {
            document.getElementById("divFrequency").hidden = false;
            document.getElementById("divTime").hidden = true;
            document.getElementById("divDayOfWeek").hidden = false;
        }

    };

    function updateGroup(recType, group) {
        var recTypeField = $('#' + recType + 'Field');
        var groupField = $('#' + group + 'Field');
        var groupValue = groupField.val();
        consensus.network.send({
            method: 'post',
            data: {
                recType: recTypeField.val(),
                serialization: {
                    Include: {
                        "Other.Workflow": ["Group"]
                    }
                }
            },
            url: 'other/workflow/fetchallbyrectype',
            success: function (result) {

                // Remove the existing options
                groupField.find('option').remove();

                // Create the new options
                $('<option />').attr('value', '').text('').appendTo(groupField);
                var duplicate = [];
                for (var i = 0; i < result.length; i++)
                {
                    if (duplicate.indexOf(result[i].Group) == -1) {
                        $('<option />').attr('value', result[i].Group).text(result[i].Group).appendTo(groupField);
                        duplicate.push(result[i].Group);
                    }
                }                    
            }
        });
    }
</script>