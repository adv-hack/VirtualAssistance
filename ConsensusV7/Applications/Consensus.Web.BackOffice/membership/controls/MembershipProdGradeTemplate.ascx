<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="MembershipProdGradeTemplate.ascx.cs" Inherits="Consensus.Web.BackOffice.membership.controls.MembershipProdGradeTemplate" %>
<con:HiddenField runat="server" ID="Id" DataBoundValue="Id" />
<div class="row">
    <div class="col-md-6">
        <con:PopupField runat="server" ID="gradeProduct" DataBoundValue="GradeProdId" DataBoundText="GradeProd.Name" LabelText="Grade" PopupUrl="~/learning/popups/productsearch.aspx?syProduct=17" HyperlinkUrl="~/learning/productpage.aspx?id={id}" Requirement="MandatoryEnforced" />
    </div>
    <div class="col-md-6">
        <con:TextField runat="server" ID="upgradePrice"  LabelText="Upgrade Price" IsReadOnly="True" />
    </div>
    <div class="col-md-6">
        <con:CheckField runat="server" ID="main" DataBoundValue="Main" LabelText="Default" />
    </div>

    <con:HiddenField runat="server" ID="gradeParentId" DataBoundValue="ProdParentIdId" />
    <con:HiddenField runat="server" ID="gradeId" DataBoundValue="GradeProdId" />
   <con:Validator runat="server" ClientValidationFunction="CheckIfGradeExist" ErrorMessage="" />
<script type="text/javascript">
    function CheckIfGradeExist(source, args) {
        consensus.network.send({
            async: false,
            method: 'post',
            url: 'membership/memberbom/CheckIfGradeExist?parentProdId=' + $('#<%= this.gradeParentId.ClientID %>Field').val() + '&gradeId=' + $('#<%= this.gradeId.ClientID %>Field').val() + '&MBomId=' + $('#<%= this.Id.ClientID %>Field').val(),
            success: function (response) {
                if (response) {
                    args.IsValid = !response;

                    source.errormessage = "Grade already exist.";
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

</div>