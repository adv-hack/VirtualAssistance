<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="BranchDistrictDetail.ascx.cs" Inherits="Consensus.Web.BackOffice.membership.controls.BranchDistrictDetail" %>
<div class="row">
    <div class="col-md-6">
        <con:PopupField runat="server" ID="Dis" LabelText="District" PopupUrl="~/membership/popups/districtsearch.aspx?" HyperlinkUrl="~/membership/districtpage.aspx?id={id}" Requirement="MandatoryEnforced" />
    </div>
    <con:HiddenField runat="server" ID="TableName" DataBoundValue="TableName" />
    <con:HiddenField runat="server" ID="Brid" DataBoundValue="BranchId" />
    <con:HiddenField runat="server" ID="DisId" DataBoundValue="RecordId" />
    <con:HiddenField runat="server" ID="BrxrefId" DataBoundValue="Id" />
</div>
<con:Validator runat="server" ClientValidationFunction="CheckIfDistrictExist" ErrorMessage="" />
<script type="text/javascript">
    function CheckIfDistrictExist(source, args) {
        consensus.network.send({
            async: false,
            method: 'post',
            url: 'membership/branchxref/CheckIfDistrictExist?branchid=' + $('#<%=this.Brid.ClientID%>Field').val() + '&districtid=' + $('#<%=this.DisId.ClientID%>Field').val() + '&branchxrefid=' + $('#<%=this.BrxrefId.ClientID%>Field').val(),
            success: function (result) {
                if (result) {
                    args.IsValid = !result;
                    source.errormessage = "This district is already present for the branch.";
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

