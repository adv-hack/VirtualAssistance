<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="EventTeamList.ascx.cs" Inherits="Consensus.Web.BackOffice.learning.controls.EventTeamList" %>


<con:DataTable runat="server" ID="EventTeamListResult" Url="~/GenericPopup.aspx?context=learning&control=eventteamdetail&width=1150&id={{Id}}" CanCreate="true">
    <Columns>
        <con:DataTableLinkColumn Title="Person" LinkHref="~/crm/personpage.aspx?id={{ACTXREF_PERSON_ID}}&role={{ACTXREF_PROLE_ID}}" LinkText="{{ACTXREF_PN_NAME}}" />
        <con:DataTableDateColumn Title="Hours" FieldName="TotalHours" />
        <con:DataTableTextColumn Title="Session" FieldName="Total_Session" />
        <con:DataTableDateColumn Title="StartDate" FieldName="ACT_ACTION_DATE" />
        <con:DataTableTextColumn Title="Associate Status" FieldName="Associate_Status" />
        <con:DataTableTextColumn Title="Volunteer Status" FieldName="Volunteer_Status" />
    </Columns>
</con:DataTable>
