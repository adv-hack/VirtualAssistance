<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="PromotionMasterList.ascx.cs" Inherits="Consensus.Web.BackOffice.marketing.PromotionMasterList" %>
<con:DataTable runat="server" ID="PromotionMasterResult" Mode="Redirect" CanDelete="false" Url="~/marketing/promotionmasterpage.aspx?id={{Id}}"  CreateUrl="~/marketing/promotionmasterpage.aspx?cmpid={{CmpIdId}}" >
  <Columns>
    <con:DataTableTextColumn Title="Promotion Master" FieldName="PM_MST_NAME" />
    <con:DataTableTextColumn Title="Region" FieldName="PM_MST_REGION" />
    <con:DataTableLinkColumn Title="Event" LinkHref="~/learning/eventpage.aspx?id={{PM_MST_COURSE_ID}}" LinkText="{{Event}}" />
    <con:DataTableDateColumn Title="Start Date" FieldName="PM_MST_START_DATE" />
    <con:DataTableDateColumn Title="End Date" FieldName="PM_MST_END_DATE" />  
    <con:DataTableTextColumn Title="Type" FieldName="PM_MST_TYPE_DESC" /> 
  </Columns>
</con:DataTable>