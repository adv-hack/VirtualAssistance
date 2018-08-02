<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="TrainerTemplateDetail.ascx.cs" Inherits="Consensus.Web.BackOffice.learning.controls.TrainerTemplateDetail" %>
<con:HiddenField runat="server" DataBoundValue="id" />
<div class="row">
  <div class="col-md-9">
    <div class="row">
        <div class="col-md-12"><con:PopupField runat="server" ID="Trainer" DataBoundValue="TrainerRoleId" DataBoundText="TrainerRole.PersonName" LabelText="Trainer" PopupUrl="~/crm/popups/personsearch.aspx" HyperlinkUrl="~/crm/personpage.aspx?role={id}"  /></div>
    </div>
    <div class="row">
        <div class="col-6"><con:CodeField runat="server" DataBoundValue="TypeModelCode" ID="CodeField1" LabelText="Type" CodeType="AREFT" /></div>
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
    <div class="row">
      <div class="col-6"><con:TextField runat="server" ID="Ratio" DataBoundValue="Ratio" LabelText="Ratio" TextMode="Number"/></div>
    </div>
  </div>
</div>
<script type="text/javascript">
</script>