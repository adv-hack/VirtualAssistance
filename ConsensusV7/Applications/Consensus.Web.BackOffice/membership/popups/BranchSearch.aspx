<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="BranchSearch.aspx.cs" Inherits="Consensus.Web.BackOffice.membership.popups.BranchSearch" MasterPageFile="~/assets/templates/PopupSearch.master" Title="Branch Search" %>
<asp:Content ContentPlaceHolderID="SearchFields" runat="server">
  <div class="row">
    <div class="col-sm-2"><con:TextField runat="server" TextMode="Number" ID="BranchId" LabelText="ID" IsEditable="true" /></div>
    <div class="col-sm-3"><con:TextField runat="server" ID="BranchName" LabelText="Name" IsEditable="true" /></div>
    <div class="col-sm-3"><con:CodeField runat="server" ID="Status" LabelText="Status" CodeType="BRSTA" IsEditable="true" /></div>
    <div class="col-sm-3"><con:CodeField runat="server" ID="Region" LabelText="Region" CodeType="REGI" IsEditable="true" /></div>
  </div>
  <div class="row">
    <div class="col-sm-3"><con:CodeField runat="server" ID="Type" LabelText="Type" CodeType="BRTYP" IsEditable="true" /></div>
    <div class="col-sm-3"><con:CodeField runat="server" ID="Category" LabelText="Category" CodeType="BRCAT" IsEditable="true" /></div>
    <div class="col-sm-3"><con:CodeField runat="server" ID="Group" LabelText="Group" CodeType="BRGRP" IsEditable="true" /></div>
    <div class="col-sm-1"><asp:Button runat="server" ID="SearchButton" CssClass="btn btn-primary" Text="Search" style="margin-top: 37px" OnClick="SearchButton_Click" /></div>
  </div>
</asp:Content>
<asp:Content ContentPlaceHolderID="SearchResult" runat="server">
  <con:DataTable runat="server" ID="SearchResult" PageLength="10"  CanCreate="false" CanModify="false">
    <Columns>
      <con:DataTableTextColumn FieldName="BR_ID" Title="ID" />
      <con:DataTableTextColumn FieldName="BR_NAME" Title="Name" />
      <con:DataTableTextColumn FieldName="BR_STATUS" Title="Status" />
      <con:DataTableTextColumn FieldName="BR_REGION" Title="Region" />
      <con:DataTableTextColumn FieldName="BR_TYPE" Title="Type" />
      <con:DataTableTextColumn FieldName="BR_CATEGORY" Title="Category" />
      <con:DataTableTextColumn FieldName="BR_GROUP" Title="Group" />
      <con:DataTableLinkColumn LinkHref="javascript: closePopup({ command: 'select', text: '{{BR_NAME}}', value: '{{BR_ID}}', data: { status: '{{BR_STATUS}}', region: '{{BR_REGION}}', type: '{{BR_TYPE}}', category: '{{BR_CATEGORY}}', group: '{{BR_GROUP}}' } });" LinkText="Select" />    
    </Columns>
  </con:DataTable>
</asp:Content>
