<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="ProductFinanceDetails.ascx.cs" Inherits="Consensus.Web.BackOffice.learning.controls.ProductFinanceDetails" %>
    

<div class="row">
    <div class="col-lg-6 consensus-column"> 
        <con:GroupBox runat="server" Title="Invoicing Details">           
            <con:CheckField runat="server" ID="InvZeroVal" LabelText="Invoice Zero Value" />
            <con:HiddenField runat="server" ID="InvoiceZeroVal" DataBoundValue="InvZeroVal" />
        </con:GroupBox>
    </div>
    <div class="col-lg-6 consensus-column">
        <con:GroupBox runat="server" Title="Analysis codes">
            <con:TextField runat="server" ID="Department"  DataBoundValue="Dept" LabelText="Analysis 1" />
            <con:TextField runat="server" ID="SKU" DataBoundValue="Sku" LabelText="Analysis 2" />
            <con:TextField runat="server" ID="JobCode" DataBoundValue="JobCode" LabelText="Analysis 3" />
            <con:TextField runat="server" ID="AnalysisCode" DataBoundValue="JobAnalyCode" LabelText="Analysis 4" />
            <con:TextField runat="server" ID="JobType" DataBoundValue="JobType" LabelText="Analysis 5" />
            <con:TextField runat="server" ID="JobParent" DataBoundValue="JobParent" LabelText="Analysis 6" />
        </con:GroupBox>
    </div>
</div>

<con:Validator runat="server" ClientValidationFunction="UpdateInvoiceZeroValue" ErrorMessage="" />

<script type="text/javascript">

    function UpdateInvoiceZeroValue() {        
        var invZeroVal = 0;
        if ($('#<%= this.InvZeroVal.ClientID %>Field').prop("checked")) {
            invZeroVal = 1;
        }
        $('#<%= this.InvoiceZeroVal.ClientID %>Field').val(invZeroVal);
    }

</script>


    
    
    
    
    
    

    
