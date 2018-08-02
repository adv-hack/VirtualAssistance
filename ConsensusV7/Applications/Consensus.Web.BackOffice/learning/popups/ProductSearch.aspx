<%@ Page AutoEventWireup="true" CodeBehind="ProductSearch.aspx.cs" Inherits="Consensus.Web.BackOffice.learning.popups.ProductSearch" Language="C#" MasterPageFile="~/assets/templates/PopupSearch.master" Title="Product Search" %>
<asp:Content ContentPlaceHolderID="SearchFields" runat="server">
    <div class="row">
        <div class="col-5">
            <con:TextField runat="server" ID="Name" LabelText="Name" IsEditable="true" />
        </div>
        <div class="col-3">
            <con:TextField runat="server" ID="Ref" LabelText="Ref" IsEditable="true" />
        </div>

        <div class="col-4">
            <con:CodeField runat="server" ID="Type" LabelText="Type" CodeType="PRTYP" IsEditable="true" />
        </div>
    

    </div>
    <div class="row">

          <div class="col-4">
            <con:CodeField runat="server" ID="Category" LabelText="Category" CodeType="PRCAT" IsEditable="true" />
        </div>

        <div class="col-3">
            <con:CodeField runat="server" ID="Group" LabelText="Group" CodeType="PRGRP" IsEditable="true" />
        </div>
        
        <div class="col-3">
            <con:ListField Visible="false" runat="server" ID="ProductType" LabelText="Product Type" ValueMember="Value" DisplayMember="Text" IsEditable="true" />
        </div>

        <div class="col-2">
            <asp:Button runat="server" ID="SearchButton" CssClass="btn btn-primary" Text="Search" Style="margin-top: 37px" OnClick="SearchButton_Click" /></div>
    </div>
</asp:Content>
<asp:Content ContentPlaceHolderID="SearchResult" runat="server">
  <con:DataTable runat="server" ID="SearchResult" PageLength="10" CanCreate="false" CanModify="false">
    <Columns>
      <con:DataTableTextColumn FieldName="PROD_NAME" Title="Name" />
      <con:DataTableTextColumn FieldName="PROD_REF" Title="Reference" />
      <con:DataTableTextColumn FieldName="PROD_SY_PRODUCT_DESC" Title="Product Type" />
      <con:DataTableTextColumn FieldName="PROD_TYPE" Title="Type" />
      <con:DataTableTextColumn FieldName="PROD_PRICE" Title="Price" />
      <con:DataTableLinkColumn LinkHref="javascript: closePopup({ command: 'select', text: '{{PROD_NAME}}', value: '{{PROD_ID}}', data: { prod_id: '{{PROD_ID}}' , prod_ref: '{{PROD_REF}}', prod_name: '{{PROD_NAME}}',prod_price: '{{PROD_PRICE}}', prod_vat_code: '{{PROD_VAT_CODE}}', vat_code_value: '{{CODE_VALUE3}}' , prod_type: '{{PROD_TYPE}}', prod_group: '{{PROD_GROUP}}', prod_category: '{{PROD_CATEGORY}}', prod_sy_product: '{{PROD_SY_PRODUCT}}', prod_sy_product_desc: '{{PROD_SY_PRODUCT_DESC}}', prod_def_elem_st:'{{PROD_DEF_ELEM_ST}}'} });" LinkText="Select" />    
    </Columns>
  </con:DataTable>
</asp:Content>
