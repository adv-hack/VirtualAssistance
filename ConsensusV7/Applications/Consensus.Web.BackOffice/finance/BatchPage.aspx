<%@ Page Language="C#" MasterPageFile="~/assets/templates/StandardDetail.master" AutoEventWireup="true" CodeBehind="BatchPage.aspx.cs" Inherits="Consensus.Web.BackOffice.finance.BatchPage" %>

<%@ Register TagPrefix="con" TagName="BatchDetails" Src="~/finance/controls/BatchDetails.ascx" %>
<%@ Register TagPrefix="con" TagName="RecordList" Src="~/finance/controls/BatchRecordList.ascx" %>
<%@ Register TagPrefix="con" TagName="PageFooter" Src="~/common/controls/PageFooter.ascx" %>

<asp:Content ContentPlaceHolderID="TopContent" runat="server">
    <con:TabControl runat="server" id="TopTabControl">
        <pages>
            <con:TabPage runat="server" Title="Overview">       
                <con:BatchDetails runat="server" ID="BatchDetail" />                   
            </con:TabPage>
            
        </pages>
    </con:TabControl>
</asp:Content>

<asp:Content ContentPlaceHolderID="BottomContent" runat="server">
    <con:TabControl runat="server" Mode="Simple" id="BottomTabControl">
        <pages>      
            <con:TabList runat="server" Title="Records" >
                <con:RecordList runat="server" id="BatchRecordList" />
            </con:TabList>
        </pages>
    </con:TabControl>


<script type="text/javascript">
    function ReRunBatch(BatchId) {

        consensus.network.send({
            method: 'put',
            data: { Rerun: 1 },
            url: 'Other/Batch/' + BatchId + "?GoToDepth=None",
            success: function (result) {
                console.log("Batch run successfully")
            }
        });
    }
</script>
    </asp:Content>

<asp:Content ContentPlaceHolderID="Footer" runat="server">
    <con:PageFooter runat="server" />
</asp:Content>