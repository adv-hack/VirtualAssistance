<%@ Page AutoEventWireup="true" CodeBehind="GenericPopup.aspx.cs" Inherits="Consensus.Web.BackOffice.GenericPopup" Language="C#" MasterPageFile="~/assets/templates/Popup.master" %>
<asp:Content runat="server" ContentPlaceHolderID="Content">
    <div class="consensus-popup-body">
        <asp:Panel runat="server" ID="ControlContainer" />
        <con:CustomFieldContainer runat="server" ID="CustomFieldContainer" Title="(Popup body)" />
    </div>
</asp:Content>
<asp:Content runat="server" ContentPlaceHolderID="PopupFooter">
  <div style="text-align: right">
    <button runat="server" ID="SendPackButton" class="btn btn-default" type="button" onclick="sendPack(); return false;">
      <span aria-hidden="true" class="icons8-telegram_app"></span>
      <span class="text" runat="server">Send Pack</span>
    </button>
    <button runat="server" ID="Reverse" class="btn btn-danger" onclick="reverseallocation(); return false;">
        <span aria-hidden="true" class="icons8-refund_2"></span>
        <span class="text" runat="server" ID="ReverseButtonText">Reverse</span>
    </button>
    <button runat="server" ID="DeleteButton" class="btn btn-danger" type="button" onclick="deleteme() ; return false;">
      <span aria-hidden="true" ><svg class="icon icon-white"><use href="#delete"></use></svg></span>
      <span class="text" runat="server">Delete</span>
    </button>
    <%--<button runat="server" ID="UndoButton" class="btn btn-default" type="button" onclick="window.closePopup(); return false;">
      <span aria-hidden="true" class="icons8-delete_sign"></span>
      <span class="text" runat="server" ID="UndoButtonText">Cancel</span>
    </button>--%>
      <button runat="server" ID="UndoButton" class="btn btn-warning" onclick="window.closePopup(); return false;">
      <span aria-hidden="true" ><svg class="icon icon-white"><use href="#delete_sign"></use></svg></span>
      <span class="text">Cancel</span>
    </button>
    <button runat="server" ID="SaveButton" class="btn" onclick="save() ; return false;">
      <span aria-hidden="true" ><svg class="icon icon-white"><use href="#checkmark"></use></svg></span>
      <span class="text" runat="server" ID="SaveButtonText"></span>
    </button>
  </div>

    <script type="text/javascript">
        $(document).ready(function () {
            if ($('[id$=_ReverseButtonField]').val() == 1) {
                $('#<%= this.Reverse.ClientID %>').prop("hidden", false);
            }
            else {
                $('#<%= this.Reverse.ClientID %>').prop("hidden", true);
            }
            });
    </script>

</asp:Content>
