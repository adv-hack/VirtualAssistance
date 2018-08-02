<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="AccountPersonList.ascx.cs" Inherits="Consensus.Web.BackOffice.finance.controls.AccountPersonList" %>

<con:DataTable runat="server" ID="AccountPersonLists" CanCreate="true" CanModify="true" Url="~/GenericPopup.aspx?context=finance&control=ContactPersonDetail&width=900&id={{Id}}">

    <Columns>
        <con:DataTableTextColumn Title="Contact" FieldName="PROLE_PN_NAME" />
        <con:DataTableTextColumn Title="Organisation" FieldName="ORG_NAME" />
        <con:DataTableTextColumn Title="Address" FieldName="ADD_MAILSTRING" />
        <con:DataTableTextColumn Title="Main" FieldName="ACXREF_MAIN" Visible="false"/>
        <con:DataTableCustomColumn Title="Main">
            var main=consensus.data.getValue(row,"ACXREF_MAIN") || '';
           if(main == 1){
            return '<span class="icons8-checkmark"></span>';
            } 
            else
            return '<span class="icons8-delete_sign"></span>';
        </con:DataTableCustomColumn> 
        <con:DataTableTextColumn Title="Invoice" FieldName="ACXREF_INVOICE" Visible="False" />  
        <con:DataTableCustomColumn Title="Invoice">
            var invoice=consensus.data.getValue(row,"ACXREF_INVOICE") || '';
            if(invoice == 1){
            return '<span class="icons8-checkmark"></span>';
            } 
            else
            return '<span class="icons8-delete_sign"></span>';
        </con:DataTableCustomColumn>     
        <con:DataTableTextColumn Title="Statement" FieldName="ACXREF_STATEMENT" Visible="False" />
        <con:DataTableCustomColumn Title="Statement">
            var statement=consensus.data.getValue(row,"ACXREF_STATEMENT") || '';
            if(statement == 1){
            return '<span class="icons8-checkmark"></span>';
            } 
            else
            return '<span class="icons8-delete_sign"></span>';
        </con:DataTableCustomColumn> 
        <con:DataTableTextColumn Title="Must use" FieldName="ACXREF_NO_ADD_CHANGE" Visible="False" />
        <con:DataTableCustomColumn Title="Must use">
            var must_use=consensus.data.getValue(row,"ACXREF_NO_ADD_CHANGE") || '';
            if(must_use == 1){
            return '<span class="icons8-checkmark"></span>';
            } 
            else
            return '<span class="icons8-delete_sign"></span>';
        </con:DataTableCustomColumn> 
    </Columns>
</con:DataTable>


