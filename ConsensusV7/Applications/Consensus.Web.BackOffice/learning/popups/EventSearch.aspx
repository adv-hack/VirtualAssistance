<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="EventSearch.aspx.cs" Inherits="Consensus.Web.BackOffice.learning.popups.EventSearch" MasterPageFile="~/assets/templates/PopupSearch.master" %>

<asp:Content ContentPlaceHolderID="SearchFields" runat="server">
    <div class="row">

        <div class="col-sm-3">
            <con:TextField runat="server" ID="EventName" LabelText="Event Name" IsEditable="true"  />
        </div>
        <div class="col-sm-3">
            <con:TextField runat="server" ID="EventReference" LabelText="Event Reference" IsEditable="true" />
        </div>
        <div class="col-sm-3">
            <con:TextField runat="server" ID="EventID" LabelText="Event ID" IsEditable="true" />
        </div>
        <div class="col-sm-3">
            <con:DateField runat="server" ID="StartingAfter" LabelText="Starting after" IsEditable="true" />
        </div>
        <div class="col-sm-3">
            <con:DateField runat="server" ID="StartingBefore" LabelText="Starting before" IsEditable="true" />
        </div>
        <div class="col-sm-3">
            <con:TextField runat="server" ID="VenueTown" LabelText="Venue town" IsEditable="true" />
        </div>
        <div class="col-sm-3">
            <con:CodeField runat="server" ID="Group" LabelText="Group" CodeType="PRGRP" IsEditable="true" />
        </div>
        <div class="col-sm-3">
            <con:CodeField runat="server" ID="Category" LabelText="Category" CodeType="PRCAT" IsEditable="true" />
        </div>
        <div class="col-sm-3">
            <con:CodeField runat="server" ID="EventType" LabelText="Event type" CodeType="COURT" IsEditable="true" />
        </div>
        <div class="col-sm-3">
            <con:CodeField runat="server" ID="EventStatus" LabelText="Event status" CodeType="COUST" IsEditable="true" />
        </div>
        <div class="col-sm-3">
            <con:TextField runat="server" ID="Location" LabelText="Location" IsEditable="true" />
        </div>
        <div class="col-sm-1">
            <asp:Button runat="server" ID="Button1" CssClass="btn btn-primary" Text="Search" Style="margin-top: 37px" OnClick="SearchButton_Click" />
        </div>
    </div>  
    <%if (this.SearchResult.Data==null) { %>
    <br />
    <br />
    <br />
    <br />
    <br />
    <%} %>  
</asp:Content>
<asp:Content ContentPlaceHolderID="SearchResult" runat="server">
    <con:DataTable runat="server" ID="SearchResult" PageLength="10" CanModify="false" CanRemove="false" Url="~/GenericPopup.aspx?context=crm&control=newpersondetail">
        <Columns>
            <con:DataTableTextColumn FieldName="COURSE_NAME" Title="Name" />
            <con:DataTableTextColumn FieldName="COURSE_REF" Title="Reference" />
            <con:DataTableTextColumn FieldName="COURSE_STATUS" Title="Status" />
            <con:DataTableDateColumn FieldName="COURSE_START_DATE" Title="Start date" />
            <con:DataTableTextColumn FieldName="EVENT_START_TIME" Title="Start time" />
            <con:DataTableDateColumn FieldName="COURSE_END_DATE" Title="End date" />
            <con:DataTableTextColumn FieldName="EVENT_END_TIME" Title="End time" />
            <con:DataTableTextColumn FieldName="ADD_TOWN" Title="Town" />
            <con:DataTableTextColumn FieldName="ACT_FREE_PLACES" Title="Free places" />
            <con:DataTableLinkColumn LinkHref="javascript: closePopup({ command: 'select', text: '{{COURSE_NAME}}', value: '{{COURSE_ID}}', data: { COURSE_ID: '{{COURSE_ID}}', COURSE_STATUS:'{{COURSE_STATUS}}', ADD_TOWN:'{{ADD_TOWN}}', ACT_FREE_PLACES: '{{ACT_FREE_PLACES}}', PROD_CATEGORY: '{{PROD_CATEGORY}}', COURSE_TYPE: '{{COURSE_TYPE}}', COURSE_NAME: '{{COURSE_NAME}}', COURSE_REF: '{{COURSE_REF}}', VENUE: '{{VENUE}}', COURSE_START_DATE: '{{COURSE_START_DATE}}', COURSE_END_DATE: '{{COURSE_END_DATE}}', EVENT_START_TIME: '{{EVENT_START_TIME}}', EVENT_END_TIME: '{{EVENT_END_TIME}}',COURSE_OVERBOOK:'{{COURSE_OVERBOOK}}', COURSE_DEF_ELEM_ST: '{{COURSE_DEF_ELEM_ST}}'}});" LinkText="Select" />
        </Columns>
    </con:DataTable>    
</asp:Content>
