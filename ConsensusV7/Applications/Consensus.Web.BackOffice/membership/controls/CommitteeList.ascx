<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="CommitteeList.ascx.cs" Inherits="Consensus.Web.BackOffice.membership.controls.CommitteeList" %>
<con:DataTable runat="server" ID="CommitteesLists" Url="~/GenericPopup.aspx?context=membership&control=BranchCommitteeDetail&id={{Id}}">
    <Columns>
        <con:DataTableTextColumn Title="Name" FieldName="COM_NAME" />
        <con:DataTableTextColumn Title="Status" FieldName="COM_STATUS" />
        <con:DataTableTextColumn Title="Type" FieldName="COM_TYPE" />
        <con:DataTableTextColumn Title="Category" FieldName="COM_CATEGORY" />
        <con:DataTableTextColumn Title="Group" FieldName="COM_GROUP" />
    </Columns>

</con:DataTable>
