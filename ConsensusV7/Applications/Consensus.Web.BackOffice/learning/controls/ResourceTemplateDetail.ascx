<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="ResourceTemplateDetail.ascx.cs" Inherits="Consensus.Web.BackOffice.learning.controls.ResourceTemplateDetail" %>
<con:HiddenField runat="server" DataBoundValue="id" />
<con:HiddenField runat="server" id="ProductRef" DataBoundValue="Resource.Ref" />
<div class="row">
  <div class="col-md-9">
    <div class="row">
        <div class="col-12">
            <con:PopupField runat="server" ID="Product" DataBoundValue="ResourceId" DataBoundText="Resource.Name" LabelText="Product" PopupUrl="~/learning/popups/productsearch.aspx?syProduct=0,4" HyperlinkUrl="~/learning/coursepage.aspx?id={Resource.id}"  Requirement="MandatoryEnforced" IsReadOnly="False"/>
        </div>
    </div>   
  </div>
  <div class="col-md-3">
    <div class="row">
      <div class="col-6"><con:TextField runat="server" ID="Qty" DataBoundValue="Qty" LabelText="Per Session" TextMode="Number"/></div>
      <div class="col-6"><con:TextField runat="server" ID="DelQty" DataBoundValue="DelQty" LabelText="Per Delegate" TextMode="Number"/></div>
      <div class="col-6"><con:CheckField runat="server" DataBoundValue="PerDay" ID="PerDay" LabelText="Per Day" /></div>
    </div>
  </div>
</div>
<script type="text/javascript">

</script>
