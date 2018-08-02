<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="MemberDiscountList.ascx.cs" Inherits="Consensus.Web.BackOffice.membership.controls.MemberDiscountList" %>
<con:DataTable runat="server" ID="MemberDiscountLists" Url="~/GenericPopup.aspx?context=membership&control=memberdiscountdetail&id={{Id}}">
    <Columns>
        <con:DataTableTextColumn Title="Discount reason" FieldName="MEL_DISC_REASON" />
        <con:DataTableDateColumn Title="Applies until" FieldName="MEL_DISC_RENEWAL" />
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
    </Columns>

</con:DataTable>
