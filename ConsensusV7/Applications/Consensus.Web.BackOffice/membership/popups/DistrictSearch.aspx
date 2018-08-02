<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="DistrictSearch.aspx.cs" Inherits="Consensus.Web.BackOffice.membership.popups.DistrictSearch" MasterPageFile="~/assets/templates/PopupSearch.master" Title="District Search" %>

<asp:content contentplaceholderid="SearchFields" runat="server">
    <div class="row">
        <div class="col-sm-2"><con:TextField runat="server" ID="DistrictId" LabelText="ID" IsEditable="True"/></div>
        <div class="col-sm-3"><con:TextField runat="server" ID="Name" LabelText="Name" IsEditable="True" /></div>
        <div class="col-sm-3"><con:CodeField runat="server" ID="Status" LabelText="Status" CodeType="DISTA" IsEditable="True" /></div>
        <div class="col-sm-3"><con:CodeField runat="server" ID="Region" LabelText="Region" CodeType="REGI" IsEditable="True" /></div>
     </div>
    <div class="row">
        <div class="col-sm-3"><con:CodeField runat="server" ID="Type" LabelText="Type" CodeType="DITYP" IsEditable="True" /></div>
        <div class="col-sm-3"><con:CodeField runat="server" ID="Category" LabelText="Category" CodeType="DICAT" IsEditable="True" /></div>
        <div class="col-sm-3"><con:CodeField runat="server" ID="Group" LabelText="Group" CodeType="DIGRP" IsEditable="True" /></div>
        <div class="col-sm-1"><asp:Button runat="server" ID="SearchButton" CssClass="btn btn-primary" Text="Search" style="margin-top: 37px" OnClick="SearchButton_Click" /></div>
    </div>
</asp:content>
<asp:Content ContentPlaceHolderID="SearchResult" runat="server">
  <con:DataTable runat="server" ID="SearchResult" PageLength="10"  CanCreate="false" CanModify="false">
    <Columns>
      <con:DataTableTextColumn FieldName="DIS_ID" Title="ID" />
      <con:DataTableTextColumn FieldName="DIS_NAME" Title="Name" />
      <con:DataTableTextColumn FieldName="DIS_STATUS" Title="Status" />
      <con:DataTableTextColumn FieldName="DIS_REGION" Title="Region" />
      <con:DataTableTextColumn FieldName="DIS_TYPE" Title="Type" />
      <con:DataTableTextColumn FieldName="DIS_CATEGORY" Title="Category" />
      <con:DataTableTextColumn FieldName="DIS_GROUP" Title="Group" />
      <con:DataTableLinkColumn LinkHref="javascript: closePopup({ command: 'select', text: '{{DIS_NAME}}', value: '{{DIS_ID}}', data: { id:'{{DIS_ID}}',name:'{{DIS_NAME}}', status: '{{DIS_STATUS}}', region: '{{DIS_REGION}}', type: '{{DIS_TYPE}}', category: '{{DIS_CATEGORY}}', group: '{{DIS_GROUP}}' } });" LinkText="Select" />    
    </Columns>
  </con:DataTable>
</asp:Content>

