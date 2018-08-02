<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="GenericProductDetails.ascx.cs" Inherits="Consensus.Web.BackOffice.learning.controls.GenericProductDetails" %>
    <con:TextField runat="server" ID="Name" DataBoundValue="Name" LabelText="Name" Requirement="MandatoryEnforced" />
    
    <div class="row">
        <div class="col-md-6">
            <con:TextField runat="server" ID="Ref" DataBoundValue="Ref" LabelText="Reference" Requirement="MandatoryEnforced" >
                <Validators>
                    <con:Validator runat="server" ClientValidationFunction="validateUniqueReference" Display="None" EnableClientScript="true" ErrorMessage="Reference must be unique" />
                </Validators>
            </con:TextField>
        </div>
        <div class="col-md-6">
            <con:ListField runat="server" ID="Status" DataBoundValue="State" LabelText="Status" Requirement="MandatoryEnforced">
               <Items>
                    <asp:ListItem Text="Planning" Value="0" />
                    <asp:ListItem Text="Current" Value="1" />
                   <asp:ListItem Text="Cancelled" Value="2" />
                   <asp:ListItem Text="Expired" Value="3" />
                </Items>
            <Validators>
                <con:Validator runat="server" ClientValidationFunction="CheckForPrice" Display="None" EnableClientScript="true" ErrorMessage="There must be a price to set the status to current" />
            </Validators>
             </con:ListField>
        </div>
    </div>


        <div class="row">
            <div class="col-md-6">
                <con:ListField runat="server" ID="CostCode" DataBoundValue="CostCode" LabelText="Cost code" ValueMember="Code" DisplayMember="Desc">
                    <Validators>
                        <con:Validator runat="server" ClientValidationFunction="validateCostCode" Critical="false" ErrorMessage="A cost code is recommended" />
                    </Validators>
                </con:ListField>
            </div>
            <div class="col-md-6">
                <con:CodeField runat="server" ID="RevCode" DataBoundValue="RevCodeCode" LabelText="Revenue code" CodeType="REVE">
                    <Validators>
                        <con:Validator runat="server" ClientValidationFunction="validateRevCode" Critical="false" ErrorMessage="A revenue code is recommended" />
                    </Validators>
                </con:CodeField>
            </div>
        </div>
        <div class="row">
            <div class="col-md-6"><con:CodeField runat="server" ID="VatCode" DataBoundValue="VatCodeCode" LabelText="VAT code" CodeType="VATCD" Requirement="MandatoryEnforced" OnLoadDataSource="ZeroVAT_OnLoadDataSource" /></div>
            <div class="col-md-6"><con:ListField runat="server" ID="SellCompName" DataBoundValue="SellingCompanyId" DataBoundText="SellingCompany.Name" LabelText="Selling company" DisplayMember="Name" ValueMember="Id" Requirement="MandatoryEnforced" /></div>
        </div> 
        <div class="row">
            <div class="col-md-6"><con:CodeField runat="server" ID="DefDelStat" DataBoundValue="DefDelStatCode" CodeType="CDES" LabelText="Default status"  /></div>
            <div class="col-md-6"><con:CheckField  runat="server" ID="TopLevel" DataBoundValue="TopLevel" LabelText="Stand alone" /></div>
         </div>


    <con:GroupBox runat="server" Title="Categorisation">
        <div class="row">
            <div class="col-md-6"><con:CodeField runat="server" ID="Type" DataBoundValue="TypeCode" LabelText="Type" CodeType="PRTYP" /></div>
            <div class="col-md-6"><con:CodeField runat="server" ID="Group" DataBoundValue="GroupCode" LabelText="Group" CodeType="PRGRP" /></div>
        </div>
        <div class="row">
            <div class="col-md-6"><con:CodeField runat="server" ID="Category" DataBoundValue="CategoryCode" LabelText="Category" CodeType="PRCAT" /></div>
            <div class="col-md-6"><con:CodeField runat="server" ID="SearchGroup" DataBoundValue="SearchGroupCode" LabelText="Search group" CodeType="PSGRP" /></div>
        </div>


        <div class="row">
            <div class="col-md-6"><con:PopupField runat="server" ID="ProdMan" DataBoundValue="productManagerId" LabelText="Product manager" PopupUrl="~/crm/popups/personsearch.aspx" HyperlinkUrl="~/crm/personpage.aspx?role={id}"/></div>
        </div>
    </con:GroupBox>



    
<con:HiddenField ID="ProductId" runat="server" DataBoundValue="Id" />

<script>
  function GetPrices(prodid) {
    var prices = [];
      consensus.network.send({
        async: false,
        method: 'post',
        url: 'finance/pricelist/fetchAllByProductId',
        data: {
            productId: prodid,
            serialization: {
                Include: {
                    "Finance.PriceList": ["Name"] // The only place that currently calls this function just looks to see if any rows were returned
                }
            }
        },
        success: function (response) {
          prices = response;
        },
        error: function (request) {
        }
      });
      return prices;
    }
    function updateCostCode(sellingCompany, costCode) {
        var sellCompField = $('#' + sellingCompany + 'Field');
        var costCodeField = $('#' + costCode + 'Field');
        var costCodeValue = costCodeField.val();
        consensus.network.send({
            method: 'post',
            data: {
                selcoSpIdId: sellCompField.val(),
                serialization: {
                    Include: {
                        "Finance.CostCode": ["Code", "Desc"]
                    }
                }
            },
            url: 'finance/costcode/fetchAllBySelcoSpIdId',
            success: function (result) {

                // Remove the existing options
                costCodeField.find('option').remove();

                // Create the new options
                $('<option />').attr('value', '').text('').appendTo(costCodeField);
                for (var i = 0; i < result.length; i++)
                    $('<option />').attr('value', result[i].Code).text(result[i].Desc).appendTo(costCodeField);
            }
        });
    }


</script>