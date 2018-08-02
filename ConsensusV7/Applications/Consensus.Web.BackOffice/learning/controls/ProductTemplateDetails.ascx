<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="ProductTemplateDetails.ascx.cs" Inherits="Consensus.Web.BackOffice.learning.controls.ProductTemplateDetails" %>
<con:HiddenField runat="server" ID="Id" DataBoundValue="Id" />
<div class="row">
    <div class="col-6">
        <con:GroupBox runat="server" Title="Basic Details">
            <div class="row">
                <div class="col-md-12">
                    <con:PopupField runat="server" ID="Product" DataBoundValue="childProductId" DataBoundText="ChildProduct.Name" LabelText="Product" PopupUrl="~/learning/popups/productsearch.aspx?syProduct=0" HyperlinkUrl="~/learning/productpage.aspx?id={ChildProduct.id}" Requirement="MandatoryEnforced" IsReadOnly="False" />
                </div>
            </div>
            <div class="row">
                <div class="col-md-12">
                </div>
            </div>
        </con:GroupBox>
    </div>

    <div class="col-6">
        <con:GroupBox runat="server" Title="Product Configuration">
            <div class="row">
                <div class="col-md-6">
                    <con:CheckField runat="server" DataBoundValue="Chargeable" ID="Chargeable" LabelText="Chargeable" />
                </div>
                <div class="col-md-6">
                    <con:ListField runat="server" ID="Mandatory" DataBoundValue="Mandatory" Requirement="MandatoryEnforced" LabelText="Mandatory">
                        <Items>
                            <asp:ListItem Text="No" Value="0" />
                            <asp:ListItem Text="Yes" Value="1" />
                            <asp:ListItem Text="Recommended" Value="2" />
                        </Items>
                    </con:ListField>
                </div>
            </div>
            <div class="row">
                <div class="col-md-6">
                    <con:CheckField runat="server" DataBoundValue="ShowSales" ID="ShowSales" LabelText="Show on Booking" />
                </div>
                <div class="col-md-6">
                    <con:ListField runat="server" ID="SelectGroup" DataBoundValue="PsgIdId" LabelText="Selection group" ValueMember="Id" DisplayMember="Name" />
                </div>
            </div>
        </con:GroupBox>
    </div>
</div>
<div class="row">
    <div class="col-md-12">
        <con:TextField runat="server" ID="Notes" DataBoundValue="ActNote" LabelText="Notes" TextMode="MultiLine" />
    </div>
</div>
<script>
    //function to save data into BillOfMaterial And TemplateXref table
    function saveProduct() {

        var result = consensus.data.getState().object;
        var method = "post";
        if (result.Id) {
            method = "put";
            result.ChildProduct = null;
            result.MasterProduct = null;
        }
        consensus.network.send({
            method: method,
            url: result.uri,
            data: result,
            async: false,
            success: function (response) {
                
                if (!result.Id) {

                    response.BillOfMaterialId = response.Id;
                    response.Templates = { uri: "learning/template/", BillOfMaterialId: response.BillOfMaterialId };

                    consensus.network.send({
                        method: 'post',
                        url: response.Templates.uri,
                        data: response.Templates,
                        async:false,
                        success: function (result) {
                            window.closePopup();
                            parent.location.reload();
                        }
                    });
                } else {
                    window.closePopup();
                    parent.location.reload();
                }
            }
        });
    }

    function deleteProduct() {
        var result = consensus.data.getState().object;
        consensus.network.send({
            method: 'delete',
            url: result.uri,
            data: result.Id,
            async: false,
            success: function (response) {

                consensus.network.send({
                    method: 'delete',
                    url: result.Templates[0].uri,
                    data: result.Templates[0].Id,
                    async: false,
                    success: function (response) {
                        window.closePopup();
                        parent.location.reload();
                    }
                });               
            }
        });
    }

</script>
