<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="CommitteeSearch.aspx.cs" Inherits="Consensus.Web.BackOffice.membership.popups.CommitteeSearch" MasterPageFile="~/assets/templates/PopupSearch.master" Title="Committee Search" %>

<asp:Content ContentPlaceHolderID="SearchFields" runat="server">
    <div class="row">
        <div class="col-sm-2">
            <con:TextField runat="server" ID="ComID" LabelText="ID" IsEditable="True" />
        </div>
        <div class="col-sm-3">
            <con:TextField runat="server" ID="Name" LabelText="Name" IsEditable="True" />
        </div>
        <div class="col-sm-3">
            <con:CodeField runat="server" ID="Status" LabelText="Status" CodeType="CMSTA" IsEditable="True" />
        </div>
        <div class="col-sm-3">
            <con:CodeField runat="server" ID="Type" LabelText="Type" CodeType="CMTYP" IsEditable="True" />
        </div>
        <div class="col-sm-3">
            <con:CodeField runat="server" ID="Category" LabelText="Category" CodeType="CMCAT" IsEditable="True" />
        </div>
        <div class="col-sm-3">
            <con:CodeField runat="server" ID="Group" LabelText="Group" CodeType="CMGRP" IsEditable="True" />
        </div>
        <div class="col-sm-1">
            <asp:Button runat="server" ID="SearchButton" CssClass="btn btn-primary" Text="Search" Style="margin-top: 37px" OnClick="SearchButton_Click" /></div>
    </div>
</asp:Content>
<asp:Content ContentPlaceHolderID="SearchResult" runat="server">
    <con:DataTable runat="server" ID="SearchResult" PageLength="10" CanCreate="false" CanModify="false">
        <Columns>
            <con:DataTableTextColumn FieldName="COM_ID" Title="ID" />
            <con:DataTableTextColumn FieldName="COM_NAME" Title="Name" />
            <con:DataTableTextColumn FieldName="COM_STATUS" Title="Status" />
            <con:DataTableTextColumn FieldName="COM_TYPE" Title="Type" />
            <con:DataTableTextColumn FieldName="COM_CATEGORY" Title="Category" />
            <con:DataTableTextColumn FieldName="COM_GROUP" Title="Group" />
            <con:DataTableLinkColumn LinkHref="javascript: closePopup({ command: 'select', text: '{{COM_NAME}}', value: '{{COM_ID}}', data: { id:'{{COM_ID}}',name:'{{COM_NAME}}', status: '{{COM_STATUS}}', type: '{{COM_TYPE}}', category: '{{COM_CATEGORY}}', group: '{{COM_GROUP}}' } });" LinkText="Select" />
        </Columns>
    </con:DataTable>
</asp:Content>
