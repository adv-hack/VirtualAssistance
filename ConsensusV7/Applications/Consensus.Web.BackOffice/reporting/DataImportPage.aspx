<%@ Page Language="C#" MasterPageFile="~/assets/templates/StandardDetail.master" AutoEventWireup="true" CodeBehind="DataImportPage.aspx.cs" Inherits="Consensus.Web.BackOffice.reporting.DataImportPage" %>

<%@ Register TagPrefix="con" TagName="DataImportDetails" Src="~/reporting/controls/DataImportDetails.ascx" %>
<%@ Register TagPrefix="con" TagName="RecordList" Src="~/finance/controls/BatchRecordList.ascx" %>
<%@ Register TagPrefix="con" TagName="PageFooter" Src="~/common/controls/PageFooter.ascx" %>

<asp:Content ContentPlaceHolderID="TopContent" runat="server">
    <con:TabControl runat="server" id="TopTabControl">
        <pages>
            <con:TabPage runat="server" Title="Overview">       
                <con:DataImportDetails ID="DataImportDetail" runat="server" />           
            </con:TabPage>
            
        </pages>
    </con:TabControl>
</asp:Content>

<asp:Content ContentPlaceHolderID="BottomContent" runat="server">
    <con:TabControl runat="server" Mode="Simple" id="BottomTabControl">
        <pages>      
            <con:TabList runat="server" Title="Records" >
                <con:RecordList runat="server" id="ImportDataRecordList" />
            </con:TabList>
        </pages>
    </con:TabControl>


<script type="text/javascript">
   
</script>
    </asp:Content>

<asp:Content ContentPlaceHolderID="Footer" runat="server">
    <con:PageFooter runat="server" />
</asp:Content>