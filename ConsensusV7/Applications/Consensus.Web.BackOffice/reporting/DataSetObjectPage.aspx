<%@ Page Title="" Language="C#" MasterPageFile="~/assets/templates/Standard.master" AutoEventWireup="true" CodeBehind="DataSetObjectPage.aspx.cs" Inherits="Consensus.Web.BackOffice.Reporting.DataSetObjectPage" %>
<asp:Content ContentPlaceHolderID="Content" runat="server">
    <iframe runat="server" id="ReportIframe" scrolling="no" frameborder="0" style="width:100%;"></iframe>

    <script>
        $(document).ready(function () {
            var iFrameID = document.getElementById('<%=ReportIframe.ClientID%>');
            if (iFrameID) {
                iFrameID.height = "";
                iFrameID.height = "600px";
            }
        });
    </script>
</asp:Content>
