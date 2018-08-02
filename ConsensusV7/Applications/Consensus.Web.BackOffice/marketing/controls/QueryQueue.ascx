<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="QueryQueue.ascx.cs" Inherits="Consensus.Web.BackOffice.marketing.controls.QueryQueue" %>


<con:HiddenField runat="server" ID="QueryId" DataBoundValue="QueryId" FieldValue="1" />
<con:HiddenField runat="server" ID="Status" DataBoundValue="Status" FieldValue="1-Awaiting Processing" />
<div class="row">
    <div class="col-md-6">
        <con:GroupBox runat="server" Title="Record Selection">                               
            <div class="row">
                <div class="col-md-6"><con:CheckField runat="server" ID="Dedupe" DataBoundValue="Query.Dedupe" LabelText="Deduplicate Output" /></div>
                <div class="col-md-6"><con:CheckField runat="server" ID="OrgOnly" DataBoundValue="Query.OrgOnly" LabelText="Exclude Person Information" /></div>
            </div>    
            <div class="row">
                <div class="col-md-6"><con:CheckField runat="server" ID="ResultsSizeOpt" DataBoundValue="Query.ResultsSizeOpt" LabelText="Random Sample" ClientOnChange="ResultSizeOptChanged();" /></div>
                <div class="col-md-6"><con:TextField runat="server" TextMode="Number" ID="ResultsSize" DataBoundValue="Query.ResultsSize" LabelText="Sample Size" /></div>
            </div>                                  
            <div class="row">
                <div class="col-md-6"><con:TextField TextMode="Number" runat="server" ID="PeoplePerOrg" DataBoundValue="Query.PeoplePerOrg" LabelText="Maximum people per organisation" /></div>
            </div>                 
        </con:GroupBox>  
        <con:GroupBox runat="server" Title="Output Options">                               
            <div class="row">
                <div class="col-md-6"><con:ListField runat="server" ID="FileType" DataBoundValue="FileType" LabelText="File format" DisplayMember="Name" ValueMember="Id" Requirement="MandatoryEnforced" /></div>
                <div class="col-md-6"><con:ListField runat="server" ID="ResultsType" DataBoundValue="ResultsType" LabelText="Results Type" DisplayMember="Name" ValueMember="Id" Requirement="MandatoryEnforced" /></div>
            </div>
            <div class="row">
                <div class="col-md-6"><con:ListField runat="server" ID="OutputOption" DataBoundValue="OutputOption" LabelText="Run Option" DisplayMember="Name" ValueMember="Id" ClientOnChange="outputOptionChanged();" Requirement="MandatoryEnforced" /></div>
                <div class="col-md-6">
                    <con:PopupField runat="server" ID="Pack" DataBoundValue="PackId" DataBoundText="Pack.Name" LabelText="Pack To Send" PopupUrl="~/document/popups/PackSearch.aspx"/>
                    <asp:CustomValidator runat="server" Display="None" ClientValidationFunction="ValidatePackCode" Critical="true" ErrorMessage="A Pack Name is required" />                        
                </div>
                <con:HiddenField runat="server" ID="RedoResultsIfExist" DataBoundValue="RedoResultsIfExist" FieldValue="1" />
            </div>
        </con:GroupBox>      
        <%-- These will be put back on the QueryDetail control in due course...
        <con:GroupBox runat="server" Title="Output">                               
            <div class="row">
                <div class="col-md-6"><con:TextField TextMode="Number" runat="server" ID="TotalRecords" DataBoundValue="Query.TotalRecords" LabelText="Record Count" IsReadOnly="True" /></div>
                <div class="col-md-6"><con:TextField TextMode="DateTime" runat="server" ID="TextField1" DataBoundValue="Query.CalculatedDate" LabelText="Run Date" IsReadOnly="True" /></div>
                <div class="col-md-6"><con:TextField runat="server" ID="LastResultFile" DataBoundValue="Query.LastResultFile" LabelText="File" IsReadOnly="True" /></div>
            </div>           
        </con:GroupBox>    --%>                        
    </div>          
    <div class="col-md-6">     
        <con:GroupBox runat="server" Title="Actions">  
            <div class="row">
                <div class="col-md-6"><con:ListField runat="server" ID="ProcessOption" DataBoundValue="ProcessOption" LabelText="Process Actions" DisplayMember="Name" ValueMember="Id" ClientOnChange="processOptionChanged();" Requirement="MandatoryEnforced" /></div>
            </div>                                  
            <div class="row" id="process_activity_row_1">
                <div class="col-md-6"><con:CodeField runat="server" ID="ActType" DataBoundValue="ActTypeCode" LabelText="Activity Type" CodeType="ACT" Requirement="MandatoryEnforced" /></div>
                <div class="col-md-6"><con:DateField runat="server" ID="ActDate" DataBoundValue="ActDate" LabelText="Activity Date" Requirement="MandatoryEnforced" /></div>
            </div>
            <div class="row" id="process_activity_row_2">
                <div class="col-md-12">
                    <con:TextField runat="server" TextMode="MultiLine" ID="ActNote" DataBoundValue="ActNote" LabelText="Description" Requirement="MandatoryEnforced" />
                </div>    
            </div>                                    
            <div id="process_person_profile_row">
              <div class="row"><div class="col-md-12"><Con:PopupField runat="server" ID="ProfileKeyPerson" DataBoundValue="ProfileKeyPerson" DataBoundText="ProfileKeyPerson" LabelText="Key" PopupUrl="~/GenericPopup.aspx?context=crm&control=profiletree&persistence=stateful&title=Select Profile&profileType=PRCT" Requirement="MandatoryEnforced" IsReadOnly="false"  /></div></div>  
              <div class="row"><div class="col-md-12"><con:TextField runat="server" ID="ProfValuePerson" DataBoundValue="ProfValuePerson" LabelText="Value" IsReadOnly="True"/></div></div>  
              <div class="row"><div class="col-md-12"><con:TextField runat="server" ID="ProfValue2Person" DataBoundValue="ProfValue2Person" LabelText="Value2" IsReadOnly="True"/></div></div>  
            </div> 
            <div id="process_org_profile_row">
              <div class="row"><div class="col-md-12"><Con:PopupField runat="server" ID="ProfileKeyOrg" DataBoundValue="ProfileKeyOrg" DataBoundText="ProfileKeyOrg" LabelText="Key" PopupUrl="~/GenericPopup.aspx?context=crm&control=profiletree&persistence=stateful&title=Select Profile&profileType=PROF" Requirement="MandatoryEnforced" IsReadOnly="false"  /></div></div>  
              <div class="row"><div class="col-md-12"><con:TextField runat="server" ID="ProfValueOrg" DataBoundValue="ProfValueOrg" LabelText="Value" IsReadOnly="True"/></div></div>  
              <div class="row"><div class="col-md-12"><con:TextField runat="server" ID="ProfValue2Org" DataBoundValue="ProfValue2Org" LabelText="Value2" IsReadOnly="True"/></div></div>  
            </div>                                                          
            <div id="process_mailing_list_row">
                <con:HiddenField runat="server" ID="TableName" DataBoundValue="TableName" />
                <con:ListField runat="server" ID="MailingList" LabelText="Mailing list" DataBoundValue="MailingListId" Width="400PX" DisplayMember="Title" ValueMember="Id" Requirement="MandatoryEnforced" />
            </div>
        </con:GroupBox>        
    </div>

    
</div>
<script>

    $(document).ready(function () {
        ResultSizeOptChanged();
        processOptionChanged();
        outputOptionChanged();

        $("#Content_PopupFooter_SaveButtonText").text("Submit");
    });
    function ResultSizeOptChanged() {
        var $cbResultsSizeOpt = $("#<%= ResultsSizeOpt.ClientID %>Field"),
            $cbResultsSize = $("#<%= ResultsSize.ClientID %>Field");

        $cbResultsSize.prop("disabled", !$cbResultsSizeOpt.prop("checked"));
    }

    function outputOptionChanged() {
        var nOption = parseInt($("#<%=this.OutputOption.ClientID%>Field").val());
        $("#<%=Pack.ClientID%>").toggle(nOption == 5); 
       
      $('#<%= this.ProcessOption.ClientID %>Field').attr('readonly', (nOption > 1) ? null : 'readonly').attr('disabled', (nOption > 1) ? null : 'disabled');  
      if (nOption == 1) {
        $('#<%= this.ProcessOption.ClientID %>Field').val('1');
        processOptionChanged();
      }
    }

    function processOptionChanged() {
        var nOption = parseInt($("#<%=this.ProcessOption.ClientID%>Field").val());

        $("#process_activity_row_1").add("#process_activity_row_2").toggle(nOption == 3);
        toggleValidation('<%= this.ActType.ClientID %>', nOption == 3);
        toggleValidation('<%= this.ActDate.ClientID %>', nOption == 3);
        toggleValidation('<%= this.ActNote.ClientID %>', nOption == 3);

        $("#process_person_profile_row").toggle(nOption == 4);
        toggleValidation('<%= this.ProfileKeyPerson.ClientID %>', nOption == 4);

        $("#process_org_profile_row").toggle(nOption == 5);
        toggleValidation('<%= this.ProfileKeyOrg.ClientID %>', nOption == 5);

        $("#process_mailing_list_row").toggle(nOption == 6);
        toggleValidation('<%= this.MailingList.ClientID %>', nOption == 6);
    }

    function isProcessOption(nTest) {        
        var nOption = parseInt($("#<%=this.ProcessOption.ClientID%>Field").val());
        return (nOption == nTest);
    }
        
    // There is a centralised implementation of this functionality at consensus.data.validation.bind, however I couldn't get that to work.
    function toggleValidation(controlId, enabled) {
        //var controlId = document.getElementById('#' + controlId);
        if (typeof (window.ValidatorValidate) == 'function' && typeof (window.Page_Validators) != 'undefined') {
            for (var i = 0; i < window.Page_Validators.length; i++) {
                var validator = window.Page_Validators[i];
                if (validator.validationGroup == controlId) {
                    validator.enabled = enabled;
                    //consensus.data.validation.check($('#' + controlId + 'Field'));
                }
            }
        }
    }

</script>