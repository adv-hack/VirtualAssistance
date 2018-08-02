<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="ProductOnlineDetails.ascx.cs" Inherits="Consensus.Web.BackOffice.learning.controls.ProductOnlineDetails" %>


<div class="row">
    <div class="col-lg-12 consensus-column">
        <con:GroupBox runat="server" Title="Online Details">
            <div class="row">
                <div class="col-md-6">
                    <con:TextField runat="server" ID="Image" DataBoundValue="Image" LabelText="Image Link" />
                </div>
                <div class="col-md-6">
                    <con:CodeField runat="server" ID="GatewayAccId" DataBoundValue="GatewayAccIdCode" LabelText="Gateway Account ID" CodeType="GATAC" />
                </div>
            </div>
            <div class="row">
                <div class="col-md-6">
                    <con:TextField runat="server" ID="UrlName" DataBoundValue="UrlName" LabelText="URL Name" IsReadOnly="True" />
                </div>
                <div class="col-md-6">
                    <con:TextField runat="server" ID="Keywords" DataBoundValue="Keywords" LabelText="Keywords" />
                </div>
            </div>
            <div class="row">
            <div class="col-md-2">
                <con:CheckField runat="server" ID="Web" DataBoundValue="Web" LabelText="Web Enabled" />
            </div>
            <div class="col-md-2">
                <con:CheckField runat="server" ID="OneclickCheckout" DataBoundValue="OneclickCheckout" LabelText="One Click Checkout" />
            </div>
            <div class="col-md-2">
                <con:CheckField runat="server" ID="BookerOnly" DataBoundValue="BookerOnly" LabelText="Booker Only" />
            </div>
            </div>
        </con:GroupBox>
    </div>
</div>
<div class="row">
    <div class="col-md-12">
        <con:TextField runat="server" TextMode="MultiLine" DataBoundValue="ProductSummary" ID="Summary" LabelText="Summary" Height="220px" MaximumLength="1000" />
    </div>
    <div class="col-md-12">
        <con:HtmlTextField runat="server" DataBoundValue="ProdDescrip.Html" ID="Description" LabelText="Description" Height="220px" />
    </div>
    <div class="col-md-12">
        <con:HtmlTextField runat="server" DataBoundValue="ProdContent.Html" ID="Content" LabelText="Content" Height="220px" />
    </div>
    <div class="col-md-12">
        <con:HtmlTextField runat="server" DataBoundValue="ProdPrereq.Html" ID="PreRequisites" LabelText="Pre-requisites" Height="220px" />
    </div>
    <div class="col-md-12">
        <con:HtmlTextField runat="server" DataBoundValue="ProdObjective.Html" ID="Objectives" LabelText="Objectives" Height="220px" />
    </div>
    <div class="col-md-12">
        <con:TextField runat="server" TextMode="MultiLine" DataBoundValue="ProdSellHint" ID="Sellinghints" LabelText="Selling hints" Height="220px" />
    </div>
    <div class="col-md-12">
        <con:HtmlTextField runat="server" DataBoundValue="ProductTrainingRules.Html" ID="Rules" LabelText="Rules" Height="220px" />
    </div>
</div>












