<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="InvoiceLinesList.ascx.cs" Inherits="Consensus.Web.BackOffice.finance.controls.InvoiceLinesList" %>
<con:DataTable runat="server" ID="ResultsTable" Url="~/GenericPopup.aspx?context=finance&control=InvoiceLinesDetails&width=900&id={{Id}}&InvId={{InvoiceId}}" CanCreate="false">
    <Columns>
        <con:DataTableLinkColumn Title="Product" LinkHref="PROD_URL" LinkText="INVLN_PROD_NAME" Visible="false" />
        <con:DataTableCustomColumn Title="Product">
            var productUrl = consensus.data.getValue(row, "PROD_URL") || '';
            var product = consensus.data.getValue(row, "INVLN_PROD_NAME") || '';            
                if (productUrl == '')
                    return product;
                else 
                {
                    var page = consensus.resolveUrl("~/"+productUrl);  
                    var link = $('<a />').attr('href', page).text(product);
                    return link[0].outerHTML;
                }
        </con:DataTableCustomColumn>        
        <con:DataTableTextColumn Title="Description" FieldName="INVLN_DESCRIPTION" />
        <con:DataTableLinkColumn Title="Booking ID" LinkHref="book_URL" LinkText="{{INVLN_BOOK_ID}}" Visible="false" />      
        <con:DataTableCustomColumn Title="Booking ID">
            var bookurl = consensus.data.getValue(row, "book_URL") || '';
            var bookid = consensus.data.getValue(row, "INVLN_BOOK_ID") || '';            
                if (bookurl == '')
                    return bookid;
                else 
                {
                    var page = consensus.resolveUrl("~/"+bookurl);  
                    var link = $('<a />').attr('href', page).text(bookid);
                    return link[0].outerHTML;
                }
        </con:DataTableCustomColumn>   
        <con:DataTableLinkColumn Title="Member number" LinkHref="~/membership/memberpage.aspx?id={{MEL_MEP_ID}}" LinkText="{{MEM_REF}}" />
        <con:DataTableTextColumn Title="Qty" FieldName="INVLN_QTY" />
        <con:DataTableTextColumn Title="Unit Price" FieldName="INVLN_UNIT_PRICE" />
        <con:DataTableTextColumn Title="Net Price" FieldName="INVLN_NET" />
        <con:DataTableTextColumn Title="VAT" FieldName="INVLN_VAT_CODE" />
        <con:DataTableTextColumn Title="Gross Price" FieldName="INVLN_TOTAL_PRICE" />
    </Columns>
</con:DataTable>
<script type="text/javascript">
</script>
