<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="AttachmentDetail.ascx.cs" Inherits="Consensus.Web.BackOffice.common.controls.AttachmentDetail" %>
<div class="row" runat="server" id="newFile">
  <div class="col-xs-12"><con:FilePickerField runat="server" Id="FilePicker" LabelText="Select a file.." AutoUpload="False" SingleFile="True" Requirement="Mandatory" URL="common/attachmentdata" /></div>
</div>
<div class="row" runat="server" id="editFile">
  <div class="col-xs-12"><con:TextField runat="server" Id="FileName" LabelText="File name" IsEditable="False" Enabled="false" /></div>
</div>
<div class="row">
  <div class="col-xs-6"><con:CodeField runat="server" Id="Category" LabelText="Pack category" DataBoundValue="CategoryCode" CodeType="ATCAT" /></div>
  <div class="col-xs-6"><con:ListField runat="server" ID="ResourceType" DataBoundValue="LearningZoneCategoryId" DataBoundText="LearningZoneCategory.CategoryTitle" LabelText="Resource type" DisplayMember="CategoryTitle" ValueMember="Id" />
</div>
</div>
<div class="row">
  <div class="col-xs-6"><con:CheckField runat="server" Id="WebEnabled" LabelText="Web enabled" DataBoundValue="Web" /></div>
  <div class="col-xs-6">
      <con:ListField runat="server" Id="Visibility" LabelText="Visibility" DataBoundValue="Visibility">
            <Items>
                <asp:ListItem Text="Booked On" Value="0" />
                <asp:ListItem Text="Training On" Value="1" />
                <asp:ListItem Text="Always" Value="2" />
            </Items>
        </con:ListField>
  </div>
</div>

<% if (string.IsNullOrEmpty(this.DataId)) { %>
<script type="text/javascript">
    var beforeSave = function (state, callback) {
        <% = FilePicker.ClientID %>.SaveFiles(function (createdIDs) {
            state.object.uri = "common/attachment/" + createdIDs[0]; 
            state.object.FileName = <% = FilePicker.ClientID %>._group.fineUploader("getName", 0)
            if (!state.object.FileName)
                state.object.FileName = null;

            callback();
        });
    }
</script>
<% } %>