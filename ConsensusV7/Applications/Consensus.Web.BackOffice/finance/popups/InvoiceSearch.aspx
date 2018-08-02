<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="InvoiceSearch.aspx.cs" Inherits="Consensus.Web.BackOffice.finance.popups.InvoiceSearch" MasterPageFile="~/assets/templates/PopupSearch.master" Title="Invoice search" %>

<asp:Content ContentPlaceHolderID="SearchFields" runat="server">
    <div class="row">
        <con:HiddenField runat="server" ID="InvId" />
        <div class="col-sm-3">
            <con:TextField runat="server" ID="InvoiceNumber" LabelText="Invoice number" IsEditable="true" />
        </div>
        <div class="col-sm-3">
            <con:TextField runat="server" ID="ARNumber" LabelText="AR number" IsEditable="false" ValueUrlParameter="ARNumber" ValueUrlIsEnforced="true" />
        </div>
        <div class="col-sm-3">
            <con:TextField runat="server" ID="Contact" LabelText="Contact" IsEditable="true" />
        </div>
        <div class="col-sm-3">
            <con:TextField runat="server" ID="Organisation" LabelText="Organisation" IsEditable="true" />
        </div>
        <div class="col-sm-3">
            <con:DateField runat="server" ID="InvoiceDateAfter" LabelText="Invoice date after" IsEditable="true" />
        </div>
        <div class="col-sm-3">
            <con:DateField runat="server" ID="InvoiceDateBefore" LabelText="Invoice date before" IsEditable="true" />
        </div>
        <div class="col-sm-3">
            <con:DateField runat="server" ID="InvoiceDueDateAfter" LabelText="Invoice due after" IsEditable="true" />
        </div>
        <div class="col-sm-3">
            <con:DateField runat="server" ID="InvoiceDueDateBefore" LabelText="Invoice due before" IsEditable="true" />
        </div>
        <div class="col-sm-3">
            <con:TextField runat="server" ID="UnpaidValue" LabelText="Unpaid value greater than" IsEditable="true" TextMode="Number" />
        </div>
        <con:HiddenField runat="server" ID="Currency" LabelText="Currency" IsEditable="false" ValueUrlParameter="Currency" ValueUrlIsEnforced="true" />
        <div class="col-sm-1">
            <asp:Button runat="server" ID="Search" CssClass="btn btn-primary" Text="Search" Style="margin-top: 37px" OnClick="SearchButton_Click" />
        </div>
    </div>

    <%if (this.SearchResult.Data == null)
        { %>
    <br />
    <br />
    <br />
    <br />
    <br />
    <br />
    <%} %>
</asp:Content>
<asp:Content ContentPlaceHolderID="SearchResult" runat="server">
    <con:DataTable runat="server" ID="SearchResult" PageLength="10" CanModify="false" CanRemove="false">
        <Columns>
            <con:DataTableTextColumn FieldName="INV_ID" Title="Invoice Id" Visible="false" />
            <con:DataTableTextColumn FieldName="INV_REF" Title="Invoice number" />
            <con:DataTableDateColumn FieldName="INV_DATE" Title="Invoice date" />
            <con:DataTableTextColumn FieldName="INV_BK_ORG_CUST_AC" Title="AR Number" />
            <con:DataTableTextColumn FieldName="PROLE_PN_NAME" Title="Contact" />
            <con:DataTableTextColumn FieldName="ORG_NAME" Title="Organisation" />
            <con:DataTableTextColumn FieldName="INV_CURRENCY_TYPE" Title="Currency" />
            <con:DataTableTextColumn FieldName="INV_GROSS_TOTAL" Title="Gross value" />
            <con:DataTableDateColumn FieldName="INV_DUE_DATE" Title="Due date" />
            <con:DataTableTextColumn FieldName="INV_UNPAID_VAL" Title="Unpaid value" />
            <con:DataTableLinkColumn LinkHref="javascript: closePopup({ command: 'select', text: '{{INV_REF}}', value: '{{INV_ID}}', data: { INV_DATE: '{{INV_DATE}}', INV_BK_ORG_CUST_AC:'{{INV_BK_ORG_CUST_AC}}', PROLE_PN_NAME:'{{PROLE_PN_NAME}}', ORG_NAME: '{{ORG_NAME}}', INV_CURRENCY_TYPE: '{{INV_CURRENCY_TYPE}}', INV_GROSS_TOTAL: '{{INV_GROSS_TOTAL}}', INV_DUE_DATE: '{{INV_DUE_DATE}}', INV_UNPAID_VAL: '{{INV_UNPAID_VAL}}'}});" LinkText="Select" />
        </Columns>
    </con:DataTable>

    <script type="text/javascript">

        $(document).ready(function () {
            $("#<%= this.UnpaidValue.ClientID%>Field").attr("step", "any");
        });

    </script>

</asp:Content>

