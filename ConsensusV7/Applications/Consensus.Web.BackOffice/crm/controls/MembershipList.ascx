<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="MembershipList.ascx.cs" Inherits="Consensus.Web.BackOffice.crm.controls.MembershipList" %>
<con:DataTable runat="server" ID="MembershipListResult" Mode="Redirect" CreateMode="RealTime" CreateUrl="~/GenericPopup.aspx?context=membership&control=newmemberwizard" Url="~/membership/memberpage.aspx?id={{Id}}">
  <Columns>
    <con:DataTableTextColumn Title="Member number" FieldName="Ref" />
    <con:DataTableTextColumn Title="Membership name" FieldName="MembershipName" />
    <con:DataTableTextColumn Title="Name" FieldName="Name" />
    <con:DataTableDateColumn Title="Start Date" FieldName="StartDate" /> 
    <con:DataTableDateColumn Title="End Date" FieldName="EndDate" /> 
    <con:DataTableDateColumn Title="Renewal Date" FieldName="RenewDate" />  
    <con:DataTableTextColumn Title="Status" FieldName="Status" /> 
  </Columns>
</con:DataTable>
