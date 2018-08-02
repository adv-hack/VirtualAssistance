<%@ Page Title="" Language="C#" MasterPageFile="~/assets/templates/Main.Master" AutoEventWireup="true" CodeBehind="HomePage.aspx.cs" Inherits="Consensus.Web.BackOffice.HomePage" %>
<asp:Content ContentPlaceHolderID="Content" runat="server">
  <iframe runat="server" id="ReportIframe" scrolling="yes" frameborder="0" style="width:100%;"></iframe>

    <script>
        $(document).ready(function () {
            var iFrameID = document.getElementById('<%=ReportIframe.ClientID%>');
            if (iFrameID) {
                iFrameID.height = "";
                iFrameID.height = "800PX";
            }
        });
    </script>
</asp:Content>