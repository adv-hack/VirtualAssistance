<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="BranchCommitteeDetail.ascx.cs" Inherits="Consensus.Web.BackOffice.membership.controls.BranchCommitteeDetail" %>
<div class="row">
    <div class="col-md-6">
        <con:PopupField runat="server" ID="Comm" DataBoundValue="id" DataBoundText="Name" LabelText="Committee" PopupUrl="~/membership/popups/CommitteeSearch.aspx" HyperlinkUrl="~/membership/CommitteePage.aspx?id={id}" Requirement="MandatoryEnforced">
        </con:PopupField>
    </div>


    <%-- <con:HiddenField runat="server" ID="BrxrefId" DataBoundValue="Id" />--%>
</div>
<%--<con:Validator runat="server" ClientValidationFunction="CheckIfCommitteeExist" ErrorMessage="" />--%>
<%--<script type="text/javascript">
    function CheckIfCommitteeExist(source, args) {
        consensus.network.send({
            async: false,
            method: 'post',
            url: 'membership/branchxref/CheckIfCommitteeExist?branchid=' + $('#<%=this.Brid.ClientID%>Field').val() + '&districtid=' + $('#<%=this.DisId.ClientID%>Field').val() + '&branchxrefid=' + $('#<%=this.BrxrefId.ClientID%>Field').val(),
            success: function (result) {
                if (result) {
                    args.IsValid = !result;
                    source.errormessage = "This committee is already present for the branch.";
                }
                else {
                    source.errormessage = "";
                }
            },
            error: function (request) {

            }
        });
    }
</script>--%>