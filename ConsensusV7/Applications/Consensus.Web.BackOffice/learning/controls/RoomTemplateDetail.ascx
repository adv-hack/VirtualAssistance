<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="RoomTemplateDetail.ascx.cs" Inherits="Consensus.Web.BackOffice.learning.controls.RoomTemplateDetail" %>
<con:HiddenField runat="server" DataBoundValue="id" />
<div class="row">
  <div class="col-md-9">
    <div class="row">
        <div class="col-12"><con:CodeField runat="server" ID="RoomType" DataBoundValue="RoomTypeCode" LabelText="Room Type" CodeType="ROOMT" /></div>
    </div>
  </div>
  <div class="col-md-3">
    <div class="row">
      <div class="col-6"><con:TextField runat="server" ID="Cost" DataBoundValue="Cost" LabelText="Cost" TextMode="Number"/></div>
      <div class="col-6">
            <con:ListField runat="server" ID="Per" DataBoundValue="UntType" LabelText="Per" >
                <Items>
                    <asp:ListItem Text="H" Value="H" />
                    <asp:ListItem Text="D" Value="D" />
                </Items>
            </con:ListField>
        </div>
    </div>
  </div>
</div>
<script type="text/javascript">
</script>
