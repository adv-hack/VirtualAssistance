<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="GiftAidList.ascx.cs" Inherits="Consensus.Web.BackOffice.crm.GiftAidList" %>
<con:DataTable runat="server" ID="GiftAidListResults" Url="~/GenericPopup.aspx?context=crm&control=giftaiddetail&id={{Id}}&buttons=30">
  <Columns>
    <con:DataTableTextColumn Title="Declaration method" FieldName="GIF_TYPE" />
    <con:DataTableIconColumn Title="Communication Sent" FieldName="GIF_COMMUNICATION" />
    <con:DataTableDateColumn Title="Start Date" FieldName="GIF_START_DATE" />
    <con:DataTableDateColumn Title="End Date" FieldName="GIF_END_DATE" />
    <con:DataTableIconColumn Title="Active" FieldName="GIF_ACTIVE" />
  </Columns>
</con:DataTable>
