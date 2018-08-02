<%@ Page Title="" Language="C#" MasterPageFile="~/assets/templates/StandardDetail.master" AutoEventWireup="true" CodeBehind="QueryPage.aspx.cs" Inherits="Consensus.Web.BackOffice.marketing.QueryPage" %>
<%@ Register TagPrefix="con" TagName="QueryDetail" Src="~/marketing/controls/QueryDetail.ascx" %>
<%@ Register TagPrefix="con" TagName="QueryDataProtection" Src="~/marketing/controls/QueryDataProtection.ascx" %>
<%@ Register TagPrefix="con" TagName="QueryStepList" Src="~/marketing/controls/QueryStepList.ascx" %>
<%@ Register TagPrefix="con" TagName="PageFooter" Src="~/common/controls/PageFooter.ascx" %>


<asp:Content ID="Content1" ContentPlaceHolderID="ReadModeToolbar" runat="server">
  <asp:Button runat="server" ID="OutputAndProcess" CssClass="btn btn-default" Text="Run Query" OnClientClick="addQueuePopup();return false;" />
</asp:Content>

<asp:Content ID="Content3" ContentPlaceHolderID="TopContent" runat="server">
    <con:TabControl runat="server">
        <Pages>
            <con:TabPage runat="server" Title="Overview">
                <con:QueryDetail runat="server" id="QueryDetail" />
            </con:TabPage>
            <con:TabPage runat="server" Title="Data Protection">
                <con:QueryDataProtection runat="server" id="QueryDataProtection" />
            </con:TabPage>
        </Pages>
    </con:TabControl>
    
    <script>
        
        function addQueuePopup() {
            var queryid = <%=Data.Id%>
            consensus.web.popupFrame({
                url: consensus.resolveUrl('~/genericpopup.aspx?context=marketing&control=queryqueue&queryId=<%=Data.Id%>&persistence=stateful'),
                open: function () {
                    if (this.window.consensus) {
                        var button = $(this.window.document.body).find('#Content_PopupFooter_SaveButton');
                        var state = new consensus.data.state(button, {}, this.window);
                        consensus.data.setState(state);
                        state.updateScreen();
                    }
                },
                result: function (data) {
                    // Don't save things that have been hidden in the UI
                    if (data.ProcessOption) {
                        if (data.ProcessOption != 3) { // "Create activity"
                            data.ActTypeCode = "";
                            data.ActDate = null;
                            data.ActNote = "";
                        }
                        if (data.ProcessOption != 4) { // "Add profile to person"
                            data.ProfilePersonId = null;
                        }
                        if (data.ProcessOption != 5) { // "Add profile to organisation"
                            data.ProfileOrgId = null;
                        }
                        if (data.ProcessOption != 6) { // "Add people to mailing list"
                            data.MailingListId = null;
                        }
                    }

                    consensus.network.send({
                        method: 'put',
                        url: "marketing/saqqueue?GoToDepth=None",
                        data: data,
                        success: function (result) {
                            alert("Your request has been added to the queue.");
                        }
                    });

                    consensus.network.send({
                        method: 'put',
                        url: 'marketing/saqquery/' + queryid,
                        data: { statusCode: '1-Awaiting Processing' } //,
                        //success: function (result) {                           
                        //}
                    });
                }
            });
        }
    </script>
</asp:Content>

<asp:Content ContentPlaceHolderID="BottomContent" runat="server">
    <con:TabControl runat="server" Mode="Simple" ID="BottomTabControl">
        <Pages>
            <con:TabList runat="server" Title="Steps"  EnableCreation="true">
                <Content>
                    <con:QueryStepList runat="server" id="QueryStepList" />
                </Content>
            </con:TabList>
        </Pages>
    </con:TabControl>
</asp:Content>

<asp:Content ContentPlaceHolderID="Footer" runat="server">
    <con:PageFooter runat="server" />
</asp:Content>