<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="EventProductDetailSection.ascx.cs" Inherits="Consensus.Web.BackOffice.learning.controls.EventProductDetailSection" %>
<con:HiddenField runat="server" ID="Id" DataBoundValue="Id" />
<con:HiddenField runat="server" ID="VATCode" DataBoundValue="SessionXrefMaster.VATCodeCode" />
<div class="row">
    <div class="col-4">
        <div class="row">
            <div class="col-md-12">
                <con:PopupField runat="server" ID="ProductEvent" DataBoundValue="ProductId" DataBoundText="Product.Name" LabelText="Product" PopupUrl="~/learning/popups/productsearch.aspx?syProduct=0,8,11" HyperlinkUrl="~/learning/productpage.aspx?id={ChildProduct.id}" Requirement="MandatoryEnforced" IsReadOnly="False" />
            </div>

        </div>
        <div class="row">
            <div class="col-md-12">
                <con:ListField runat="server" ID="SelectionGroup" DataBoundValue="SessionXrefMaster.CsgId" DisplayMember="Name" ValueMember="Id" LabelText="Selection Group" />
            </div>
        </div>
    </div>

    <div class="col-8">
        <div class="row">
            <div class="col-md-6">
                <con:CheckField runat="server" DataBoundValue="SessionXrefMaster.Element" ID="Element" LabelText="Element" />
            </div>

            <div class="col-md-6">
                <con:ListField runat="server" ID="Mandatory" DataBoundValue="SessionXrefMaster.Mandatory" Requirement="MandatoryEnforced" LabelText="Mandatory">
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
                <con:CheckField runat="server" DataBoundValue="SessionXrefMaster.ShowSales" ID="ShowSales" LabelText="Show on Booking" />
            </div>
            <div class="col-md-6">
                <con:CheckField runat="server" DataBoundValue="SessionXrefMaster.InvPrint" ID="InvoicePrint" LabelText="Print on Invoice" />
            </div>
        </div>
        <div class="row">
        </div>
    </div>
</div>
<div class="row">
    <div class="col-md-12">
        <con:TextField runat="server" ID="Notes" DataBoundValue="Notes.Html" LabelText="Notes" TextMode="MultiLine" />
    </div>
</div>
