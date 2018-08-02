<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="RelatedProductDetail.ascx.cs" Inherits="Consensus.Web.BackOffice.learning.controls.RelatedProductDetail" %>

<div class="row">

    <div class="col-md-6">
        <con:ListField runat="server" ID="Prereq" DataBoundValue="Prereq" LabelText="Relationship" Requirement="MandatoryEnforced">
            <Items>
                <asp:ListItem Text="" Value="" />
                <asp:ListItem Text="Similar To" Value="0" />
                <asp:ListItem Text="Pre-Requisite" Value="1" />
                <asp:ListItem Text="Recommended" Value="2" />
            </Items>
        </con:ListField>
        <con:TextField runat="server" ID="Notes" DataBoundValue="Notes" LabelText="Notes" TextMode="MultiLine" />
    </div>
    <div class="col-md-6">
        <con:PopupField runat="server" ID="ProductName" DataBoundValue="RelatedProdIdId"  DataBoundText="RelatedProdId.Name" LabelText="Name" PopupUrl="~/learning/popups/productsearch.aspx?syProduct=0,1,3,8,11,21,25" HyperlinkUrl="~/learning/productpage.aspx?id={id}" Requirement="MandatoryEnforced"/>
        <con:TextField runat="server" ID="ProductRef" DataBoundValue="RelatedProdId.Ref"  LabelText="Reference" IsReadOnly="True"/>
        
    </div>
</div>

<script>
   
 
    var RefreshProductReference = function (restUrl) {

        this.RestUrl = restUrl;
        this.Update = function () {
            var thisInstance = this;
            var productId = $('#' + '<%=this.ProductName.ClientID%>' + 'Value').val();
            if (productId && productId.length != 0) {
                jQuery.ajax({
                    type: 'GET',
                    dataType: 'json',
                    contentType: 'application/json',
                    url: thisInstance.RestUrl + '/learning/product/' + productId,
                    error: function (request) {
                        consensus.utilities.displayError(request);
                    },
                    success: function (data, status, request) {
                        $('#' + '<%=this.ProductRef.ClientID%>' + 'Field').val(data.Ref);
                    }
                });
            } else {
                $('#' + '<%=this.ProductRef.ClientID%>' + 'Field').val('');
            }
        }
    }
</script>