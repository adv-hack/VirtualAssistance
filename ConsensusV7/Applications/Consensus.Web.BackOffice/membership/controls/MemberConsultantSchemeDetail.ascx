<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="MemberConsultantSchemeDetail.ascx.cs" Inherits="Consensus.Web.BackOffice.membership.controls.MemberConsultantSchemeDetail" %>

<div class="row">
    <div class="col-md-6">
        <con:PopupField runat="server" ID="Product" DataBoundValue="ProductId" DataBoundText="Product.Name" LabelText="Name" PopupUrl="~/learning/popups/productsearch.aspx?syProduct=19" HyperlinkUrl="~/membership/membershipproductpage.aspx?id={id}" Requirement="MandatoryEnforced" />        
    </div>
    <div class="col-md-6">
        <con:DateField runat="server" ID="StartDate" LabelText="Start date" DataBoundValue="Start" Requirement="MandatoryEnforced" />
    </div>
    <div class="col-md-6">
        <con:DateField runat="server" ID="EndDate" LabelText="End date" DataBoundValue="End" Requirement="MandatoryEnforced" />
    </div>
    <div class="col-md-6">
        <con:ListField runat="server" ID="Status" DataBoundValue="Status" LabelText="Status" ValueMember="Key" DisplayMember="Value" Requirement="MandatoryEnforced" />
    </div>
    <div class="col-md-6">
        <con:TextField runat="server" ID="Fee" DataBoundValue="Fee" LabelText="Fee" Requirement="MandatoryEnforced" />
    </div>
    <div class="col-md-6">
        <con:CodeField runat="server" ID="Vatcode" DataBoundValue="Vatcd" LabelText="VAT Code" CodeType="VATCD" Requirement="MandatoryEnforced" />        
    </div>
    <con:HiddenField runat="server" DataBoundValue="SyType" ID="SyType" />
    <con:HiddenField runat="server" DataBoundValue="Id" ID="MemberLocationId" />    
    <con:HiddenField runat="server" DataBoundValue="MemberPeriodId" ID="MemberPeriodId" />    
</div>
<br />
<br />
<br />
<br />
<br />
<br />

<con:Validator runat="server" ClientValidationFunction="CheckIfProductExist" ErrorMessage="" />
<script type="text/javascript">
    function CheckIfProductExist(source, args) {
        consensus.network.send({
            async: false,
            method: 'post',
            url: 'Membership/MemberLocation/CheckIfProductExist?productId=' + $('#<%= this.Product.ClientID %>Value').val() + '&memberLocationId=' + $('#<%= this.MemberLocationId.ClientID %>Field').val() + '&memberPeriodId=' + $('#<%= this.MemberPeriodId.ClientID %>Field').val(),
            success: function (response) {
                if (response) {
                    args.IsValid = !response;
                    source.errormessage = "This scheme already exists on this membership.";
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


