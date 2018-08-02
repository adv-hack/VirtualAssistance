<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="BookingLineDetails.ascx.cs" Inherits="Consensus.Web.BackOffice.learning.controls.BookingLineDetails" %>

<div class="row">
  <con:HiddenField runat="server" ID="GUID" DataBoundValue="_guid" />
  <con:HiddenField runat="server" ID="DelegateAddressId" DataBoundValue="DelegateAddressId" />
  <con:HiddenField runat="server" ID="DelegatePersonId" DataBoundValue="DelegatePersonId" />
  <con:HiddenField runat="server" ID="DelegateRoleId" DataBoundValue="DelegateRoleId" />
  <con:HiddenField runat="server" ID="DelegateOrgId" DataBoundValue="DelegateOrgId" />
  <con:HiddenField runat="server" ID="SellingCompanyId" DataBoundValue="Elements.SellingCompanyId" />
  <con:HiddenField runat="server" ID="ProductId" DataBoundValue="Elements.ProductId" />
  <con:HiddenField runat="server" ID="MainSession" DataBoundValue="Elements.MainSession" />
  <con:HiddenField runat="server" ID="Type" DataBoundValue="Elements.Type" />
  <con:HiddenField runat="server" ID="PaymentMethodCode" DataBoundValue="Elements.PaymentMethodCode" />
  <con:HiddenField runat="server" ID="Qty" DataBoundValue="Elements.Qty" />
  <con:HiddenField runat="server" ID="PriceListId" DataBoundValue="Elements.PriceListId" />
  <con:HiddenField runat="server" ID="PriceIdId" DataBoundValue="Elements.PriceIdId" />
  <con:HiddenField runat="server" ID="SessionXrefsId" DataBoundValue="Elements.SessionXrefsId" />
  <con:HiddenField runat="server" ID="CourseId" DataBoundValue="Elements.CourseId" />
  <con:HiddenField runat="server" ID="ActId" DataBoundValue="Elements.ActivityId" />
  <con:HiddenField runat="server" ID="Status" DataBoundValue="Elements.Status" />
  <con:HiddenField runat="server" ID="PriceList" DataBoundValue="Elements.PriceList.Name" />
  
  <div class="col-md-12">
      <div class="row">
          <div class="col-md-12">
              <con:TextField runat="server" ID="BadgeName" DataBoundValue="BadgeName" LabelText="Badge name"/>
          </div>
          <div class="col-md-12">
              <con:TextField runat="server" ID="Description" DataBoundValue="Elements.Description" LabelText="Description"/>
          </div>
      </div>
  </div>
  <div class="col-md-12">
        <div class="row">
            <div class="col-md-6">
                <con:ListField runat="server" ID="Price" LabelText="Price list" DisplayMember="Desc2" ValueMember="Id" ClientOnChange="SetIds()" />
            </div>
            <div class="col-md-6">
                <con:TextField runat="server" ID="UintPrice" DataBoundValue="Elements.UintPrice" LabelText="Amount" TextMode="Number" Requirement="MandatoryEnforced"/>
            </div>
            <div class="col-md-6">

                <con:CodeField runat="server" ID="VatcdCode" DataBoundValue="Elements.VatcdCode" LabelText="VAT code" CodeType="VATCD" Requirement="MandatoryEnforced" />
            </div>
        </div>
   </div>
</div>
<asp:CustomValidator runat="server" ClientValidationFunction="ValidateAmount" Display="None" EnableClientScript="true" ErrorMessage="Negative amounts are not allowed." />
<script>
  var priceLists = [];
  $(document).ready(function () {
    getPriceLists();
  });
  function SetIds() {
    var priceField = $('#<%= this.Price.ClientID %>Field');
    var priceListField = $('#<%= this.PriceList.ClientID %>Field');
    var sxrefIdField = $('#<%= this.SessionXrefsId.ClientID %>Field');
    var prsIdField = $('#<%= this.PriceIdId.ClientID %>Field');
    var priceListIdField = $('#<%= this.PriceListId.ClientID %>Field');
    var courseId = "<%=this.Request.QueryString["CourseId"]%>";
    var price = $('#<%= this.UintPrice.ClientID %>Field');

    for (var i = 0; i < priceLists.length; i++) {
      if (courseId.length > 0) {
        if (priceLists[i].Id3 == priceField.val()) {
          sxrefIdField.val(priceLists[i].Id3);
          prsIdField.val(priceLists[i].Id);
          priceListIdField.val(priceLists[i].Id1);
          priceListField.val(priceLists[i].Desc2);
          price.val(priceLists[i].Money1);
        }
      }
      else {
        if (priceLists[i].Id == priceField.val()) {
          prsIdField.val(priceLists[i].Id);
          priceListIdField.val(priceLists[i].Id1);
          priceListField.val(priceLists[i].Desc2);
          price.val(priceLists[i].Money1);
        }
      }
    }
  }
  function getPriceLists() {
    var sessions = [];
    var priceField = $('#<%= this.Price.ClientID %>Field');
    var courseId = "<%=this.Request.QueryString["CourseId"]%>";
    var actId = "<%=this.Request.QueryString["ActId"]%>";
    var productId = "<%=this.Request.QueryString["ProdId"]%>";
    var prsId = "<%=this.Request.QueryString["PrsId"]%>";
    var sxrefId = "<%=this.Request.QueryString["sxrefId"]%>";
    var qty = 1;
    //var priceLists = [];

    if (courseId.length > 0) {
      consensus.network.send({
        method: 'post',
        async: false,
        url: 'common/genericmodel/fetchAllByCourseIdPrices',
        data: {
            courseid: courseId,
            delcount: qty,
            serialization: {
                ListsAtDepth: "None",
                GoToDepth: "Root"
            }
        },
        success: function (result) {
          sessions = result;
        }
      });

      priceLists = jQuery.grep(sessions, function (element) {
        if (actId != "") {
          return (element.Id4 == actId);
        }
      });

      for (var i = 0; i < priceLists.length; i++)
        $('<option />').attr('value', priceLists[i].Id3).text(priceLists[i].Desc2).appendTo(priceField);
      $('#<%= this.Price.ClientID %>Field').val(sxrefId);
    }
    else {
      consensus.network.send({
        method: 'post',
        async: false,
        url: 'common/genericmodel/fetchAllByProdIdPrices',
        data: {
            prodid: productId,
            qty: qty,
            serialization: {
                ListsAtDepth: "None",
                GoToDepth: "Root"
            }
        },
        success: function (result) {
          priceLists = result;
        }
      });
      for (var i = 0; i < priceLists.length; i++)
        $('<option />').attr('value', priceLists[i].Id).text(priceLists[i].Desc2).appendTo(priceField);
      $('#<%= this.Price.ClientID %>Field').val(prsId);
    }
   
  };
  function ValidateAmount(source, arguments) {
    var amount = $('#<%= this.UintPrice.ClientID %>Field').val();
    if (amount < 0) {
      arguments.IsValid = false;
    }
    else {
      arguments.IsValid = true;
    }
  }

</script>

