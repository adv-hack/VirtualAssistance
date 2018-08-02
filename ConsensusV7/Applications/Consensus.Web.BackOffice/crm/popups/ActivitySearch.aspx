<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ActivitySearch.aspx.cs" Inherits="Consensus.Web.BackOffice.learning.popups.ActivitySearch" MasterPageFile="~/assets/templates/PopupSearch.master" Title="Activity Search" %>

<asp:Content ContentPlaceHolderID="SearchFields" runat="server">
    <div class="row">
        <div class="col-sm-3">
            <con:TextField runat="server" ID="SessionName" LabelText="Title" IsEditable="true" />
        </div>
        <div class="col-sm-3">
            <con:CodeField runat="server" ID="ActivityType" LabelText="Activity Type" IsEditable="true" CodeType="ACT" />
        </div>
        <div class="col-sm-3">
            <con:DateField runat="server" ID="StartDate" LabelText="Start Date" IsEditable="true" />
        </div>
        <div class="col-sm-3">
            <con:DateField runat="server" ID="EndDate" LabelText="End Date" IsEditable="true" />
        </div>        
    </div>
    <div class="row">        
        <div class="col-sm-3">
            <con:PopupField runat="server" ID="Person" DataBoundValue="PersonId" DataBoundText="PnName" LabelText="Contact" PopupUrl="~/crm/popups/personsearch.aspx"  IsEditable="True"/>
        </div>
        <div class="col-sm-3">
            <con:ListField runat="server" ID="SellingCompany" LabelText="Selling Company"  DataBoundValue="SellingCompanyId" ValueMember="Id" DisplayMember="Name" IsEditable="true" />
        </div>
        <div class="col-sm-3">
            <asp:Button runat="server" ID="SearchButton" CssClass="btn btn-primary" Text="Search" Style="margin-top: 37px" OnClick="SearchButton_Click" />
        </div>
    </div>
    
    <%if (this.SearchResult.Data == null)
        { %>
    <br />
    <br />
    <br />
    <br />
    <br />

    <%} %>
</asp:Content>
<asp:Content ContentPlaceHolderID="SearchResult" runat="server">
    <con:DataTable runat="server" ID="SearchResult" PageLength="10" CanCreate="false" CanCreateInEditMode="false" CanRemove="false" CanModify="false" >
        <Columns>
            <con:DataTableTextColumn FieldName="ACT_TYPE" Title="Activity Type" />
            <con:DataTableTextColumn FieldName="ACT_SESSION_NAME" Title="Title" />
            <con:DataTableDateColumn FieldName="ACT_ACTION_DATE" Title="Start Date" />
            <con:DataTableTextColumn FieldName="PersonName" Title="Contact" />
            <con:DataTableTextColumn FieldName="Notes" Title="Notes" />
            <con:DataTableLinkColumn LinkHref="javascript: closePopup({ command: 'select', text: '{{ACT_SESSION_NAME}}', value: '{{ACT_ID}}' ,data:{ activityXRefType: '{{ACTXREF_TYPE}}'}});" LinkText="Select" />
        </Columns>
    </con:DataTable>
</asp:Content>