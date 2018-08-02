<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="MembershipProductGradesList.ascx.cs" Inherits="Consensus.Web.BackOffice.membership.controls.MembershipProductGradesList" %>
<con:DataTable runat="server" ID="MembershipProdGradeLists" Url="~/GenericPopup.aspx?context=membership&control=membershipprodgradetemplate&id={{Id}}">
    <Columns>
        
        <con:DataTableTextColumn Title="Grade Name" FieldName="PROD_NAME" />
        <con:DataTableTextColumn Title="Reference" FieldName="PROD_REF" />
        <con:DataTableTextColumn Title="Upgrade Price" FieldName="PRS_PRICE" />
        <con:DataTableIconColumn Title="Default" FieldName="MBOM_MAIN" />
    </Columns>

</con:DataTable>