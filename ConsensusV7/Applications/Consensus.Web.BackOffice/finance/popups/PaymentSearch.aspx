<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="PaymentSearch.aspx.cs" Inherits="Consensus.Web.BackOffice.finance.popups.PaymentSearch" MasterPageFile="~/assets/templates/PopupSearch.master" Title="Payment search" %>

<asp:Content ContentPlaceHolderID="SearchFields" runat="server">
    <div class="row">
        <div class="col-sm-3">
            <con:HiddenField runat="server" ID="PaymentId" />
            <con:DateField runat="server" ID="PaymentDate" LabelText="Payment date" IsEditable="true" />
        </div>
        <div class="col-sm-3">
            <con:TextField runat="server" ID="ARNumber" LabelText="AR number" IsEditable="false" ValueUrlParameter="ARNumber" ValueUrlIsEnforced="true" />
        </div>
        <div class="col-sm-3">
            <con:TextField runat="server" ID="PaymentReference" LabelText="Payment reference" IsEditable="true" />
        </div>
        <div class="col-sm-3">
            <con:CodeField runat="server" ID="PaymentType" LabelText="Type" CodeType="PYPAY" IsEditable="true" />
        </div>
        <div class="col-sm-3">
            <con:TextField runat="server" ID="Payer" LabelText="Payer" IsEditable="true" />
        </div>
        <div class="col-sm-3">
            <con:TextField runat="server" ID="Organisation" LabelText="Organisation" IsEditable="true" />
        </div>
        <div class="col-sm-3">
            <con:CodeField runat="server" ID="Status" LabelText="Status" CodeType="PAYST" IsEditable="true" />
        </div>
        <div class="col-sm-3">
            <con:TextField runat="server" ID="Currency" LabelText="Currency" IsEditable="false" ValueUrlParameter="Currency" ValueUrlIsEnforced="true" />
        </div>
        <div class="col-sm-3">
            <con:TextField runat="server" ID="UnusedValue" LabelText="Unused value greater than" IsEditable="true" TextMode="Number" />
        </div>
        <div class="col-sm-1">
            <asp:Button runat="server" ID="Search" CssClass="btn btn-primary" Text="Search" Style="margin-top: 37px" OnClick="SearchButton_Click" />
        </div>
    </div>

    <%if (this.SearchResult.Data == null)
        { %>
    <br />
    <br />
    <%} %>
</asp:Content>
<asp:Content ContentPlaceHolderID="SearchResult" runat="server">
    <con:DataTable runat="server" ID="SearchResult" PageLength="10" CanModify="false" CanRemove="false">
        <Columns>
            <con:DataTableDateColumn FieldName="PAY_ID" Title="Date" Visible="false" />
            <con:DataTableDateColumn FieldName="PAY_DATE" Title="Date" />
            <con:DataTableTextColumn FieldName="PAY_REF" Title="Reference" />
            <con:DataTableTextColumn FieldName="PAY_TYPE" Title="Type" />
            <con:DataTableTextColumn FieldName="PAY_CURR_TYPE" Title="Currency" />
            <con:DataTableTextColumn FieldName="PAY_RECVD" Title="Value" />
            <con:DataTableTextColumn FieldName="PAY_UNUSED_VAL" Title="Unused value" />
            <con:DataTableTextColumn FieldName="PROLE_PN_NAME" Title="Payer" />
            <con:DataTableLinkColumn LinkHref="javascript: closePopup({ command: 'select', text: '{{PAY_ID}}', value: '{{PAY_ID}}', data: { PAY_REF: '{{PAY_REF}}', PAY_DATE:'{{PAY_DATE}}', PAY_TYPE:'{{PAY_TYPE}}', PAY_CURR_TYPE: '{{PAY_CURR_TYPE}}', PAY_RECVD: '{{PAY_RECVD}}', PAY_UNUSED_VAL: '{{PAY_UNUSED_VAL}}', PROLE_PN_NAME: '{{PROLE_PN_NAME}}'}});" LinkText="Select" />
        </Columns>
    </con:DataTable>

    <script type="text/javascript">

        $(document).ready(function () {
            $("#<%= this.UnusedValue.ClientID%>Field").attr("step", "any");
        });

    </script>

</asp:Content>
