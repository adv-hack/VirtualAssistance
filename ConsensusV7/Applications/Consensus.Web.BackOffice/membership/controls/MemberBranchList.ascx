<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="MemberBranchList.ascx.cs" Inherits="Consensus.Web.BackOffice.membership.controls.MemberBranchList" %>
<con:DataTable runat="server" ID="MemberBranchLists" Url="~/GenericPopup.aspx?context=membership&control=memberbranchdetail&id={{Id}}">
    <Columns>
        <con:DataTableTextColumn Title="ID" FieldName="BR_ID" Visible="false" />
        <con:DataTableTextColumn Title="Branch name" FieldName="BR_NAME" />
        <con:DataTableTextColumn Title="Status" FieldName="BRXREF_STATUS" />
        <con:DataTableDateColumn Title="Start date" FieldName="BRXREF_START_DATE" />
        <con:DataTableDateColumn Title="End date" FieldName="BRXREF_END_DATE" />
        <con:DataTableTextColumn Title="Region" FieldName="BR_REGION" />
        <con:DataTableTextColumn Title="Type" FieldName="BR_TYPE" />
        <con:DataTableTextColumn Title="Category" FieldName="BR_Category" />
        <con:DataTableTextColumn Title="Group" FieldName="BR_Group" />
        <con:DataTableTextColumn Title="Branch status" FieldName="BR_STATUS" />
    </Columns>
</con:DataTable>