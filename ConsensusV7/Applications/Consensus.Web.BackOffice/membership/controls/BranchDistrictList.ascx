<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="BranchDistrictList.ascx.cs" Inherits="Consensus.Web.BackOffice.membership.controls.BranchDistrictList" %>
<con:DataTable runat="server" ID="BranchDistrictLists" Url="~/GenericPopup.aspx?context=membership&control=branchdistrictdetail&id={{Id}}">
    <Columns>
        <con:DataTableTextColumn Title="District name" FieldName="DIS_NAME" />
        <con:DataTableTextColumn Title="Region" FieldName="DIS_REGION" />
        <con:DataTableTextColumn Title="Status" FieldName="DIS_STATUS" />
        <con:DataTableTextColumn Title="Type" FieldName="DIS_TYPE" />
        <con:DataTableTextColumn Title="Category" FieldName="DIS_CATEGORY" />
        <con:DataTableTextColumn Title="Group" FieldName="DIS_GROUP" />
    </Columns>

</con:DataTable>
