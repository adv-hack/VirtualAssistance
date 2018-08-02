<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="DocumentTemplateList.ascx.cs" Inherits="Consensus.Web.BackOffice.document.controls.DocumentTemplateList" %>
<con:DataTable runat="server" ID="DocumentTemplateListTable" Url="~/GenericPopup.aspx?context=document&control=DocumentTemplateDetail&id={{Id}}">
      
    <Columns>
        <con:DataTableTextColumn Title="Format" FieldName="Type" />  
        <con:DataTableTextColumn Title="Name " FieldName="LIT_NAME" />
        <con:DataTableTextColumn Title="Type" FieldName="LTT_NAME" />
        <con:DataTableIconColumn Title="Email Body" FieldName="IS_COVER_PAGE"  /> 
        
    </Columns>
</con:DataTable>
