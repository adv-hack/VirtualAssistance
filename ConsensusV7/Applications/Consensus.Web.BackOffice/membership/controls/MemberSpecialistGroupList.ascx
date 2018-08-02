<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="MemberSpecialistGroupList.ascx.cs" Inherits="Consensus.Web.BackOffice.membership.controls.MemberSpecialistGroupList" %>
<con:DataTable runat="server" ID="MemberSpecialistGroupLists" Url="~/GenericPopup.aspx?context=membership&control=memberspecialistgroupdetail&id={{Id}}">
    <Columns>
        <con:DataTableTextColumn Title="Name" FieldName="PROD_NAME" />
        <con:DataTableTextColumn Title="Reference" FieldName="PROD_REF" />
        <con:DataTableDateColumn Title="Start Date" FieldName="MEL_START" />
        <con:DataTableDateColumn Title="End Date" FieldName="MEL_END" />
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