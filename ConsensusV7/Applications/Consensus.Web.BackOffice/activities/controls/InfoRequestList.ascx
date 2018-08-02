<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="InfoRequestList.ascx.cs" Inherits="Consensus.Web.BackOffice.activities.controls.InfoRequestList" %>
<%--<con:DataTable runat="server" ID="InfoRequestLists" Url="~/GenericPopup.aspx?context=activities&control=inforequestdetail&id={{Id}}">--%>
<con:DataTable runat="server" ID="InfoRequestLists" Mode="Redirect"  CreateUrl="~/activities/InfoRequest?" Url="~/activities/InfoRequest?id={{Id}}">
    <Columns>
        <con:DataTableTextColumn Title="ID" FieldName="HD_ID" />
        <con:DataTableTextColumn Title="Summary" FieldName="HD_TITLE" />
        <con:DataTableTextColumn Title="Category" FieldName="HD_CATEGORY" />
        <con:DataTableLinkColumn Title="Requested by" LinkHref="personpage.aspx?id={{PERSON_ID_REQUESTED_BY}}&role={{HD_PROLE_ID}}" LinkText="{{HD_PROLE_PN_NAME}}" />
        <con:DataTableLinkColumn Title="Assigned to" LinkHref="personpage.aspx?id={{PERSON_ID_GIVEN_TO}}&role={{HD_GIVEN_TO_ID}}" LinkText="{{HD_GIVEN_TO_PN_NAME}}" />
        <con:DataTableTextColumn Title="Status" FieldName="HD_STATUS" />
        <con:DataTableDateColumn Title="Created date" FieldName="HD_ADD_DATE" />
        <con:DataTableDateColumn Title="Resolution date" FieldName="HD_RES_DATE" />
    </Columns>
</con:DataTable>
