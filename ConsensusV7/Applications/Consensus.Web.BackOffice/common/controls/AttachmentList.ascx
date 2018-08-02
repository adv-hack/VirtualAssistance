<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="AttachmentList.ascx.cs" Inherits="Consensus.Web.BackOffice.common.controls.AttachmentList" %>
<con:DataTable runat="server" ID="AttachmentListResult" Mode="RealTime" Url="~/GenericPopup.aspx?context=common&control=attachmentdetail&id={{Id}}+modified server side" SerializeListsAtDepth="None">
  <Columns>
    <con:DataTableLinkColumn runat="server" Title="File name" LinkOnClick="consensus.web.openAttachment('{{ATT_ID}}', '{{ATT_MIME}}');" LinkText="{{ATT_FILE_NAME}}" />
    <con:DataTableTextColumn runat="server" Title="Uploaded by" FieldName="ATT_ADD_BY" />
    <con:DataTableDateColumn runat="server" Title="Uploaded on" FieldName="ATT_ADD_DATE" /> 
    <con:DataTableTextColumn runat="server" ID="ColCategory" Title="Pack category" FieldName="ATT_CATEGORY" />
    <con:DataTableTextColumn runat="server" ID="ColResourceType" Title="Resource type" FieldName="LZC_CATEGORY_TITLE" />
    <con:DataTableTextColumn runat="server" ID="ColVisibility" Title="Visibility" FieldName="ATT_VISIBILITY" /> 
    <con:DataTableIconColumn runat="server" Title="Web enabled" FieldName="ATT_WEB" />  
    <con:DataTableReorderColumn runat="server" Title="Order number" FieldName="ATT_ORDER_NUM" ModelFieldName="OrderNum" />
  </Columns>
</con:DataTable>
<script>
    function refreshAttachmentsGrid(editedRow)
    {
        var attachmentParentUrl = '<%= this.AttachmentParentURL %>';
        var attachmentParentId = '<%= this.AttachmentParentId %>';

        consensus.network.send({
            method: 'post',
            url: 'common/attachment/GetListQueryResults',
            data: { Url: attachmentParentUrl, RecordId: attachmentParentId },
            success: function (result) {
                var tableObj = window['<%= this.AttachmentListResult.ClientID %>'];
                tableObj._sourceData = result;
                tableObj.reload();
            }
        });
        // We will reload once the rest call returns - return false so that the framework does not reload
        return false;
    }
</script>
