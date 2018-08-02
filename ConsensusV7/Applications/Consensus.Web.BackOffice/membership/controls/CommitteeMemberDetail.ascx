<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="CommitteeMemberDetail.ascx.cs" Inherits="Consensus.Web.BackOffice.membership.controls.CommitteeMemberDetail" %>
<div class="row">
    <div class="col-md-6">
        <con:PopupField runat="server" ID="Name" DataBoundValue="RecordId" LabelText="Person" PopupUrl="~/crm/popups/personsearch.aspx" HyperlinkUrl="~/crm/personpage.aspx?id={id}" Requirement="MandatoryEnforced" />
    </div>
    <div class="col-md-6">
        <con:DateField runat="server" ID="AddDate"  DataBoundValue="Date" LabelText="Date added" />
    </div>
    <div class="col-md-6">
        <con:CodeField runat="server" ID="Committeerole" DataBoundValue="Role" LabelText="Committee role" CodeType="COMRL" />
    </div>
    <con:HiddenField runat="server" ID="TableName" DataBoundValue="TableName" />    
    <con:HiddenField runat="server" ID="CommitteeId" DataBoundValue="CommitteeId" />
    <con:HiddenField runat="server" ID="Disabled" DataBoundValue="Disabled" />
    <con:HiddenField runat="server" ID="CommitteXrefid" DataBoundValue="Id" />
</div>
<br />
<br />
<br />
<br />
<br />
<br />

<con:Validator runat="server" ClientValidationFunction="CheckIfPersonExist" ErrorMessage="" />
<script type="text/javascript">
    function CheckIfPersonExist(source, args) {
        consensus.network.send({
            async: false,
            method: 'post',
            url: 'membership/committeexref/CheckIfPersonExist?committeeid=' + $('#<%=this.CommitteeId.ClientID%>Field').val() + '&personid=' + $('#<%=this.Name.ClientID%>Value').val() + '&committeexrefid=' + $('#<%=this.CommitteXrefid.ClientID%>Field').val(),
            success: function (result) {
                if (result) {
                    args.IsValid = !result;
                    source.errormessage = "This person is already present for the committee.";
                }
                else {
                    source.errormessage = "";
                }
            },
            error: function (request) {

            }
        });
    }
</script>


   
   
    