<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="ProductDetails.ascx.cs" Inherits="Consensus.Web.BackOffice.learning.controls.ProductDetails" %>
<%@ Register TagPrefix="con" TagName="GenericProductDetails" Src="~/learning/controls/GenericProductDetails.ascx" %>

<div class="row">
    <div class="col-md-6">
            <con:GroupBox runat="server" Title="Basic Details">
              <con:GenericProductDetails runat="server" Id="GenericProduct" DataBoundId="Id" />
            </con:GroupBox>
     </div>


    <div class="col-md-6">
            <con:GroupBox runat="server" Title="Product information">
                <div class="row">
                    <div class="col-md-6"><con:TextField runat="server" ID="Isbn" DataBoundValue="Isbn" LabelText="ISBN" /></div>
                    <div class="col-md-6"><con:PopupField runat="server" ID="Author" DataBoundValue="AuthorPersonId" DataBoundText="AuthorPerson.PrincipalRole.PersonName" LabelText="Author" PopupUrl="~/crm/popups/personsearch.aspx" HyperlinkUrl="~/crm/popups/personpage.aspx?id={id}" /></div>
                </div>
<%--                <con:TextField runat="server" ID="PageCount" DataBoundValue="PageCount" LabelText="No. of Pages" />--%>
<%--                <con:TextField runat="server" ID="AuthorName" DataBoundValue="AuthorName" LabelText="Author Name" />--%>
<%--                <div class="col-md-6"><con:CodeField runat="server" ID="RoyaltyModel" DataBoundValue="RoyaltyModelCode" LabelText="Royalty Model" CodeType="ROYMO" /></div>--%>
                
<%--                <con:CheckField runat="server" ID="Stocked" DataBoundValue="Stocked" LabelText="Stock Tracked" />
                    <con:TextField runat="server" ID="ProdQuantity" DataBoundValue="ProdQuantity" LabelText="Quantity" />
                    <con:TextField runat="server" ID="QtyAc" DataBoundValue="QtyAc" LabelText="Allocated Qty" />
                    <con:TextField runat="server" ID="QtyAv" DataBoundValue="QtyAv" LabelText="Free Qty" />--%>


            </con:GroupBox>
        </div>

</div>