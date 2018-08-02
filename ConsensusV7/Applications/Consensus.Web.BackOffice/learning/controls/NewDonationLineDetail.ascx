<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="NewDonationLineDetail.ascx.cs" Inherits="Consensus.Web.BackOffice.learning.controls.NewDonationLineDetail" %>

<div class="row">
    <con:HiddenField runat="server" ID="DelegateAddress" DataBoundValue="Delegate.DelegateAddressId" />
    <con:HiddenField runat="server" ID="DelegateRole" DataBoundValue="Delegate.DelegateRoleId" />
    <con:HiddenField runat="server" ID="DelegateOrg" DataBoundValue="Delegate.DelegateOrgId" />
    <con:HiddenField runat="server" ID="DelegatePerson" DataBoundValue="Delegate.DelegatePersonId" />
    <con:HiddenField runat="server" ID="SellingCompany" DataBoundValue="SellingCompanyId" />
    <con:HiddenField runat="server" ID="PriceIdId" DataBoundValue="PriceIdId" />
    <con:HiddenField runat="server" ID="MainSession" DataBoundValue="MainSession" />
    <con:HiddenField runat="server" ID="Type" DataBoundValue="Type" />
    <con:HiddenField runat="server" ID="PaymentMethod" DataBoundValue="PaymentMethodCode" />
    <con:HiddenField runat="server" ID="Qty" DataBoundValue="Qty" />
    <con:HiddenField runat="server" ID="Description" DataBoundValue="Description" />
    <con:HiddenField runat="server" ID="VatCode" DataBoundValue="Product.VatCodeCode" />
    <con:HiddenField runat="server" ID="VatCodeValue" DataBoundValue="Product.VatCode.Value3" />
    <div class="col-md-6">
        <div class="row">
            <div class="col-md-12">
                <con:PopupField runat="server" ID="DonationProduct" DataBoundValue="ProductId" DataBoundText="Product.Name" LabelText="Donation" PopupUrl="~/learning/popups/productsearch.aspx?syProduct=29" />
            </div>
        </div>
        <div class="row">
            <div class="col-md-12">
                <con:ListField runat="server" ID="CostCode" DataBoundValue="CostCode" LabelText="Fund" ValueMember="Code" DisplayMember="Desc" IsReadOnly="True" />
            </div>
        </div>
        <div class="row">
            <div class="col-md-6">
                <con:CheckField runat="server" ID="GiftAid" DataBoundValue="GiftAid" LabelText="Gift Aid" IsReadOnly="True" ClientOnChange="SetDeclaration();" />
            </div>
            <con:HiddenField runat="server" ID="ActiveGiftAidId" DataBoundValue="Delegate.Role.Person.ActiveGiftAid.id" />
            <con:HiddenField runat="server" ID="ActiveGiftAidActive" DataBoundValue="Delegate.Role.Person.ActiveGiftAid.Active" />
            <div id="divGADec" class="col-md-6">
                <con:CodeField runat="server" DataBoundValue="Delegate.Role.Person.ActiveGiftAid.TypeCode" ID="Declaration" LabelText="Declaration method" CodeType="DECLA" Requirement="MandatoryEnforced" />
            </div>
        </div>
    </div>
    <div class="col-md-6">
        <div class="row">
            <div class="col-md-12">
                <con:ListField runat="server" ID="PriceList" DataBoundValue="PriceListId" LabelText="Price List" ValueMember="Id" DisplayMember="Name" Requirement="MandatoryEnforced" ClientOnChange="SetPrice('')" />
            </div>
        </div>
        <div class="row">
            <div class="col-md-6">
                <con:TextField runat="server" ID="UintPrice" DataBoundValue="UintPrice" LabelText="Amount" TextMode="Number" />
            </div>
        </div>
        <div class="row">
            <div class="col-xs-12" style="height: 30px;"></div>
            <div class="col-md-3" id="divDonation1">
                <asp:LinkButton runat="server" ID="Donation1" CssClass="btn btn-success" OnClientClick="SetPrice('1');return false;">
            <span aria-hidden="true" class="icons8-money_bag_pound"></span>
            <span ID="SpanDonation1" class="text"></span>
                </asp:LinkButton>
            </div>
            <div class="col-md-3" id="divDonation2">
                <asp:LinkButton runat="server" ID="Donation2" CssClass="btn btn-success" OnClientClick="SetPrice('2');return false;">
            <span aria-hidden="true" class="icons8-money_bag_pound"></span>
            <span ID="SpanDonation2" class="text"></span>
                </asp:LinkButton>
            </div>
            <div class="col-md-3" id="divDonation3">
                <asp:LinkButton runat="server" ID="Donation3" CssClass="btn btn-success" OnClientClick="SetPrice('3');return false;">
            <span aria-hidden="true" class="icons8-money_bag_pound"></span>
            <span  ID="SpanDonation3" class="text"></span>
                </asp:LinkButton>
            </div>
            <div class="col-md-3" id="divDonation4">
                <asp:LinkButton runat="server" ID="Donation4" CssClass="btn btn-success" OnClientClick="SetPrice('4');return false;">
            <span aria-hidden="true" class="icons8-money_bag_pound"></span>
            <span ID="SpanDonation4"class="text"></span>
                </asp:LinkButton>
            </div>
        </div>
    </div>
</div>
<asp:CustomValidator runat="server" ClientValidationFunction="ValidateAmount" Display="None" EnableClientScript="true" ErrorMessage="A donation cannot be a negative amount or zero." />
<script>
    $(document).ready(function () {
        hideDonations();
        SetDeclaration();
        $('#<%= this.CostCode.ClientID %>Field').prepend("<option value='' selected='selected'></option>");
    });
    function callPromise(ProdId, priceList) {
        document.getElementById("Content_PopupFooter_SaveButton").setAttribute("disabled", true);
        if (ProdId) {
            var resp = updatePrices(ProdId, priceList);
        }
    }
    function updatePrices(ProdId, priceList) {
        document.getElementById("Content_PopupFooter_SaveButton").setAttribute("disabled", true);
        var resp = false;
        var priceListField = $('#' + priceList + 'Field');
        //get price lists
        consensus.network.send({
            async: false,
            method: 'post',
            url: 'finance/pricelist/fetchAllByProductId',
            data: {
                productId: ProdId,
                serialization: {
                    Include: {
                        "Finance.PriceList": ["Name"]
                    }
                }
            },
            success: function (result) {

                // Remove the existing options
                priceListField.find('option').remove();

                // Create the new options
                //$('<option />').attr('value', '').text('').appendTo(priceListField);
                for (var i = 0; i < result.length; i++)
                    $('<option />').attr('value', result[i].Id).text(result[i].Name).appendTo(priceListField);
                SetPrice('');
            }
        });
        //get the product related information
        hideDonations();
        consensus.network.send({
            async: false,
            method: 'post',
            url: 'learning/product/fetchById',
            data: { id: ProdId },
            success: function (result) {
                var activeGiftAid = $('#<%= this.ActiveGiftAidId.ClientID %>Field').val();

                if (result.Price > 0) {
                    document.getElementById("SpanDonation1").textContent = result.Price;
                    document.getElementById("divDonation1").hidden = false;
                }
                if (result.BlockPrice > 0) {
                    document.getElementById("SpanDonation2").textContent = result.BlockPrice;
                    document.getElementById("divDonation2").hidden = false;
                }
                if (result.SparePrice > 0) {
                    document.getElementById("SpanDonation3").textContent = result.SparePrice;
                    document.getElementById("divDonation3").hidden = false;
                }
                if (result.CostPrice > 0) {
                    document.getElementById("SpanDonation4").textContent = result.CostPrice;
                    document.getElementById("divDonation4").hidden = false;
                }

                if (result.CostCode != '') {
                    $('#<%= this.CostCode.ClientID %>Field').val(result.CostCode, result.CostCode);
                }

                $('#<%= this.CostCode.ClientID %>Field').attr('readonly', result.CanChangeCostCode ? null : 'readonly').attr('disabled', result.CanChangeCostCode ? null : 'disabled');
                $('#<%= this.GiftAid.ClientID %>Field').bootstrapSwitch("disabled", false).bootstrapSwitch("readonly", false);
                if (activeGiftAid.length > 0 && result.Giftaid == true) {
                    $('#<%= this.GiftAid.ClientID %>Field').bootstrapSwitch("state", true);
                }

                if (result.Giftaid == false) {
                    $('#<%= this.GiftAid.ClientID %>Field').bootstrapSwitch("state", false);
                }

                $('#<%= this.GiftAid.ClientID %>Field').bootstrapSwitch("disabled", result.Giftaid ? false : true).bootstrapSwitch("readonly", result.Giftaid ? false : true);

                SetDeclaration();
                resp = true;
            }
        });
        document.getElementById("Content_PopupFooter_SaveButton").removeAttribute("disabled");
        return resp;
    }
  function hideDonations() {
      document.getElementById("divDonation1").hidden = true;
      document.getElementById("divDonation2").hidden = true;
      document.getElementById("divDonation3").hidden = true;
      document.getElementById("divDonation4").hidden = true;
  }
  function SetPrice(price) {
      var PriceList = $('#<%= this.PriceList.ClientID %>Field').val();
      var ProdId = $('#<%= this.DonationProduct.ClientID %>Value').val();

      if (price == '') {
          consensus.network.send({
              async: false,
              method: 'post',
              url: 'finance/price/fetchAllByProdidPriceListid',
              data: {
                  productId: ProdId,
                  plId: PriceList,
                  serialization: {
                      Include: {
                          "Finance.Price": ["Amount"]
                      }
                  }
              },
              success: function (result) {
                  // Create the new options
                  for (var i = 0; i < result.length; i++) {
                      $('#<%= this.PriceIdId.ClientID %>Field').val(result[i].Id);
                      $('#<%= this.UintPrice.ClientID %>Field').val(result[i].Amount);
                  }
              }
          });
      }
      else {
          $('#<%= this.UintPrice.ClientID %>Field').val(document.getElementById("SpanDonation" + price).textContent);
      }
  }
    function SetDeclaration() {
        var giftAid = $('#<%= this.GiftAid.ClientID %>Field').prop("checked");
        var activeGiftAid = $('#<%= this.ActiveGiftAidId.ClientID %>Field').val();
        if (activeGiftAid.length == 0) {
            if (giftAid) {
                toggleValidation('<%= this.Declaration.ClientID %>', true);
                document.getElementById("divGADec").hidden = false;
            }
            else {
                toggleValidation('<%= this.Declaration.ClientID %>', false);
                document.getElementById("divGADec").hidden = true;
            }
        }
        else if (activeGiftAid.length > 0) {
            <%--if (giftAid) {
                toggleValidation('<%= this.Declaration.ClientID %>', true);
                document.getElementById("divGADec").hidden = false;
            }--%>
            var giftAidActive = $('#<%= this.ActiveGiftAidActive.ClientID %>Field').val();

            toggleValidation('<%= this.Declaration.ClientID %>', false);
            document.getElementById("divGADec").hidden = true;
        }
    }
function toggleValidation(controlId, enabled) {
    if (typeof (window.ValidatorValidate) == 'function' && typeof (window.Page_Validators) != 'undefined') {
        for (var i = 0; i < window.Page_Validators.length; i++) {
            var validator = window.Page_Validators[i];
            if (validator.validationGroup == controlId) {
                validator.enabled = enabled;
                consensus.data.validation.check($('#' + controlId + 'Field'));
            }
        }
    }
}
function ValidateAmount(source, arguments) {
    var amount = $('#<%= this.UintPrice.ClientID %>Field').val();
      if (amount <= 0) {
          arguments.IsValid = false;
      }
      else {
          arguments.IsValid = true;
      }
}

    
</script>
