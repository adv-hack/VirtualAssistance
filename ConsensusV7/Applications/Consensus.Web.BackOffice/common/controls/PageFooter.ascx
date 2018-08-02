<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="PageFooter.ascx.cs" Inherits="Consensus.Web.BackOffice.common.controls.PageFooter" %>
<%--<%@ Register TagPrefix="con" TagName="PageSummary" Src="~/common/controls/PageSummary.ascx" %>--%>
<%@ Register TagPrefix="con" TagName="AttachmentList" Src="~/common/controls/AttachmentList.ascx" %>
<%@ Register TagPrefix="con" TagName="Comments" Src="~/common/controls/Comments.ascx" %>

<con:TabControlFooter ID="tabControlFooter" runat="server" title="Comments and Attachments">
    <Pages>
        <%-- This works, but isn't what was specified. It will show the last updated user and date for the page, if they exist in the model.
        <con:TabPage ID="tabSummary" runat="server" Title="Summary">
            <con:PageSummary ID="conSummary" runat="server" />
        </con:TabPage>--%>
        <con:TabPage ID="tabAttachments" runat="server" Title="Attachments" BlockCustomFields="true">
            <con:AttachmentList ID="conAttachments" runat="server" />
        </con:TabPage>
        <con:TabPage ID="tabComments" runat="server" Title="Comments" BlockCustomFields="true">
            <con:Comments ID="conComments" runat="server" />
        </con:TabPage>
    </Pages>
</con:TabControlFooter>
<script type="text/javascript">
    $("#<%=tabControlFooter.ClientID%> .nav-tabs").on('shown.bs.tab', function (e) {
        //e.target // newly activated tab
        //e.relatedTarget // previous active tab
        if ($(e.target).attr("href") == "#<%=tabComments.ClientID%>") {
            if (footComments && $.isFunction(footComments.showHideExpand)) {
                footComments.showHideExpand();
            }
        }
    })
</script>