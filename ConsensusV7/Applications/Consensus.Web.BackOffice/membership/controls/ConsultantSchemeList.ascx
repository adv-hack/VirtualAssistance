<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="ConsultantSchemeList.ascx.cs" Inherits="Consensus.Web.BackOffice.membership.controls.ConsultantSchemeList" %>
<con:DataTable runat="server" ID="ConsultantSchemeLists" Url="~/GenericPopup.aspx?context=membership&control=MemberConsultantSchemeDetail&id={{Id}}" CreateUrl="~/GenericPopup.aspx?context=membership&control=MemberConsultantSchemeDetail&id={{Id}}">
    <Columns>        
        <con:DataTableTextColumn Title="Name" FieldName="PROD_NAME" />
        <con:DataTableTextColumn Title="Reference" FieldName="PROD_REF" />        
        <con:DataTableDateColumn Title="Start date" FieldName="MEL_DATE" />
        <con:DataTableDateColumn Title="End date" FieldName="MEL_END" />
        <con:DataTableTextColumn Title="Status" FieldName="Status" />
        <con:DataTableTextColumn Title="Fee" FieldName="MEL_FEE" />
        <con:DataTableTextColumn Title="VAT" FieldName="MEL_VAT_AMT" />
        <con:DataTableTextColumn Title="VAT Code" FieldName="MEL_VATCD" />
        <con:DataTableIconColumn Title="Invoiced" FieldName="MEL_INVOICED" Visible="false" />
        <con:DataTableCustomColumn Title="Invoiced">
            var invoiced=consensus.data.getValue(row,"MEL_INVOICED") || '';
            if(invoiced == 2)
                return '';
            else if(invoiced == 1){
                return '<span class="icons8-checkmark"></span>';
            } 
            else
                return '<span class="icons8-delete_sign"></span>';
        </con:DataTableCustomColumn>
        <con:DataTableIconColumn Title="Modified" FieldName="MEL_PRICE_MODIFIED" /> 
    </Columns>
</con:DataTable>