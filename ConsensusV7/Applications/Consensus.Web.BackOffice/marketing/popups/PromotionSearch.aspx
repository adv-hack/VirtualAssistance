<%@ Page AutoEventWireup="true" CodeBehind="PromotionSearch.aspx.cs" Inherits="Consensus.Web.BackOffice.marketing.popups.PromotionSearch" Language="C#" MasterPageFile="~/assets/templates/PopupSearch.master" Title="Promotion Search" %>
<asp:Content ContentPlaceHolderID="SearchFields" runat="server">
    <div class="row">
        <div class="col-sm-3"><con:TextField runat="server" ID="Campaign" LabelText="Campaign" IsEditable="true" /></div>
        <div class="col-sm-3"><con:TextField runat="server" ID="PromotionMaster" LabelText="Promotion Master" IsEditable="true" /></div>
        <div class="col-sm-3"><con:DateField runat="server" ID="EndDate" LabelText="End Date" IsEditable="true" /></div>
        <div class="col-sm-3"><con:DateField runat="server" ID="StartDate" LabelText="Start Date"  IsEditable="true" /></div>
    </div>
    <div class="row">
        <div class="col-sm-2"><con:CodeField runat="server" ID="Channel" LabelText="Channel" CodeType="CHAN" IsEditable="true" /></div>
        <div class="col-sm-2"><con:CodeField runat="server" ID="Type" LabelText="Type" CodeType="PMTY" IsEditable="true" /></div>
        <div class="col-sm-2"><con:CodeField runat="server" ID="MediaName" LabelText="Media Name" CodeType="MDANM" IsEditable="true" /></div>
        <div class="col-sm-2"><con:TextField runat="server" ID="SourceCode" LabelText="Source Code" IsEditable="true" /></div>
        
        <div class="col-sm-2"><con:TextField runat="server" ID="QuickCode" LabelText="Quick Code" IsEditable="true" /></div>
        <div class="col-sm-1"><asp:Button runat="server" ID="SearchButton" CssClass="btn btn-primary" Text="Search" Style="margin-top: 37px" OnClick="SearchButton_Click" /></div>

    </div>
    
</asp:Content>
<asp:Content ContentPlaceHolderID="SearchResult" runat="server">
  <con:DataTable runat="server" ID="SearchResult" PageLength="10"  CanCreate="false" CanModify="false">
    <Columns>
        <con:DataTableTextColumn FieldName="PM_NAME" Title="Source Code" />
        <con:DataTableTextColumn FieldName="PM_MST_NAME" Title="Promotion Master" />
        <con:DataTableTextColumn FieldName="CMP_NAME" Title="Campaign" />
        <con:DataTableTextColumn FieldName="PM_CHANNEL" Title="Channel" />
        <con:DataTableTextColumn FieldName="PM_MEDIA_NAME" Title="Media Name" />
        <con:DataTableTextColumn FieldName="TEXT_BODY" Title="Description" />
      <con:DataTableLinkColumn LinkHref="javascript: closePopup({ command: 'select', text: '{{PM_NAME}}', value: '{{PM_ID}}', data: { org_id: '{{PM_ID}}' } });" LinkText="Select" />    

    </Columns>
  </con:DataTable>
</asp:Content>
