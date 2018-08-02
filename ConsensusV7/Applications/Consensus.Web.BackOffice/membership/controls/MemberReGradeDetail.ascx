<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="MemberReGradeDetail.ascx.cs" Inherits="Consensus.Web.BackOffice.membership.controls.MemberReGradeDetail" %>
             
            <div class="row">
                <div class="col-md-8">
                    <con:TextField runat="server" ID="ExistingGrade" LabelText="Existing Grade" IsReadOnly="True" />
                    <con:TextField runat="server" ID="Systype" DataBoundValue="SyType" DataBoundText="SyType" IsHidden="TrueEnforced" IsReadOnly="True" />
                    <con:TextField runat="server" ID="Current" DataBoundValue="Current" DataBoundText="Current" IsHidden="TrueEnforced" IsReadOnly="True" />
                </div>                
            </div>
             <div class="row">
                <div class="col-md-8">
                    <con:ListField runat="server" ID="NewGrade" DataBoundValue="ProductId" DataBoundText="GradeProd.Name" LabelText="New Grade" DisplayMember="Name" ValueMember="Id" Requirement="MandatoryEnforced" ClientOnChange="SetPriceField()" />
                    <con:ListField runat="server" ID="AllGradePrice" DisplayMember="Price" ValueMember="Id"  IsHidden="TrueEnforced" />
                    <con:ListField runat="server" ID="AllVatCode" DataBoundValue="Vatcd" DisplayMember="Id" ValueMember="VatCodeCode" IsHidden="TrueEnforced"  />
                </div>                
            </div>
            <div class="row">
                <div class="col-md-8">
                    <con:TextField runat="server" DataBoundValue="Fee"  ID="Price" LabelText="Price" TextMode="Number"  />
                </div>                
            </div>
       
<script type="text/javascript">
    function SetPriceField() {

        var selectedGrade = $('#<%= this.NewGrade.ClientID %>Field').val();

        var allGradePrices = document.getElementById("<%= this.AllGradePrice.ClientID %>Field").options;
        var allVatCodes = document.getElementById("<%= this.AllVatCode.ClientID %>Field").options;
        var addBlankEntry = true;
        for (var i = 0; i < allGradePrices.length; i++) {
            if (allGradePrices[i].text) {
                var typeValue = allGradePrices[i].value;
                $('#<%= this.Price.ClientID %>Field').val("0");
                if (typeValue == selectedGrade) {
                    $('#<%= this.Price.ClientID %>Field').val(allGradePrices[i].text);
                    break;
                }
            }
        }
        for (var i = 0; i < allVatCodes.length; i++) {
            if (allVatCodes[i].text) {
                var typeValue = allVatCodes[i].text;
                if (typeValue == selectedGrade) {                   
                    $('#<%= this.AllVatCode.ClientID %>Field option[value="' + allVatCodes[i].value + '"]').attr("selected", "selected");
                    break;
                }
            }
        }
    }
</script>
   