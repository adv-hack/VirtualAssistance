<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="MemberGradeList.ascx.cs" Inherits="Consensus.Web.BackOffice.membership.controls.MemberGradeList" %>
<con:DataTable runat="server" ID="MemberGradeLists" Url="~/GenericPopup.aspx?context=membership&control=membergradedetail&id={{Id}}" CreateUrl="~/GenericPopup.aspx?context=membership&control=memberregradedetail&id={{Id}}">
    <Columns>
        <con:DataTableTextColumn Title="Reference" FieldName="PROD_REF" />
        <con:DataTableTextColumn Title="Name" FieldName="PROD_NAME" />
        <con:DataTableDateColumn Title="Start Date" FieldName="MEL_DATE" />
        <con:DataTableTextColumn Title="Fee" FieldName="MEL_FEE" />
        <con:DataTableTextColumn Title="VAT" FieldName="MEL_VAT_AMT" />
        <con:DataTableTextColumn Title="VAT Code" FieldName="MEL_VATCD" />
        <con:DataTableIconColumn Title="Invoiced" FieldName="MEL_INVOICED" Visible="false"/>
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
