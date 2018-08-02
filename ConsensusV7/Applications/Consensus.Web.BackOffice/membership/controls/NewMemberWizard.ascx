<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="NewMemberWizard.ascx.cs" Inherits="Consensus.Web.BackOffice.membership.controls.NewMemberWizard" %>
<%@ Register TagPrefix="con" TagName="Payment" Src="~/finance/controls/NewPayment.ascx" %>
<%@ Register TagPrefix="con" TagName="DirectDebit" Src="~/finance/controls/DirectDebitDetails.ascx" %>

<con:Wizard runat="server" ID="Wizard">
    <con:WizardPage runat="server" ID="MemberPage" Title="Member Details">
        <con:HiddenField runat="server" ID="AddressId" />
        <con:HiddenField runat="server" ID="InvoiceAddressId" />
        <con:HiddenField runat="server" ID="InvoiceOrgId" />
        <con:HiddenField runat="server" ID="OpportunityId" />
        <con:HiddenField runat="server" ID="AccVatcode" />
        <con:HiddenField runat="server" ID="VATCalculation" />
        <con:HiddenField runat="server" ID="InvoicePersonId" />
        <div class="row">
            <div class="col-6">
                <con:GroupBox runat="server" Title="Member details">
                    <div class="row">
                        <div class="col-12">
                            <con:PopupField runat="server" ID="Person" LabelText="Contact" PopupUrl="~/crm/popups/personsearch.aspx" HyperlinkUrl="~/crm/personpage.aspx?role={id}" Requirement="MandatoryEnforced">
                                <Filters>
                                    <con:PopupFieldFilter ParameterName="org" Type="Control" Value="OrgName" />
                                </Filters>
                            </con:PopupField>
                        </div>
                    </div>
                    <div class="row">
                        <div class="col-12">
                            <con:TextField runat="server" ID="MembershipName" LabelText="Membership name" />
                        </div>
                    </div>
                    <div class="row">
                        <div class="col-12">
                            <con:PopupField runat="server" ID="OrgName" LabelText="Organisation" PopupUrl="~/crm/popups/organisationsearch.aspx" HyperlinkUrl="~/crm/organisationpage.aspx?id={id}" />
                        </div>
                    </div>
                    <div class="row">
                        <div class="col-12">
                            <con:TextField runat="server" ID="Address" LabelText="Address" IsReadOnly="TrueEnforced" TextMode="MultiLine" CssClass="consensus-input noresize" />
                        </div>
                    </div>
                    <con:PopupField runat="server" ID="SourceCode" LabelText="Source code" PopupUrl="~/marketing/popups/promotionsearch.aspx" HyperlinkUrl="~/marketing/sourcepage.aspx?id={id}" />
                    <con:ListField runat="server" ID="SellCompName" LabelText="Selling company" DisplayMember="Name" ValueMember="Id" Requirement="MandatoryEnforced" />
                </con:GroupBox>
            </div>
            <div class="col-6">
                <con:GroupBox runat="server" Title="Billing details">
                    <div class="row">
                        <div class="col-12">
                            <con:ListField runat="server" ID="AccountId" LabelText="AR number"></con:ListField>
                            <con:ListField runat="server" ID="ARNumber" IsHidden="TrueEnforced"></con:ListField>
                            <con:ListField runat="server" ID="InvoiceContact" Requirement="MandatoryEnforced" LabelText="Invoice contact"></con:ListField>
                            <con:TextField runat="server" ID="InvoiceOrganisation" LabelText="Invoice organisation" IsReadOnly="TrueEnforced" />
                        </div>
                    </div>
                    <div class="row">
                        <div class="col-12">
                            <con:TextField runat="server" ID="InvoiceAddress" LabelText="Invoice address" IsReadOnly="TrueEnforced" TextMode="MultiLine" CssClass="consensus-input noresize" />
                        </div>
                    </div>
                    <con:TextField runat="server" ID="PONumber" LabelText="Purchase order number">
                        <Validators>
                            <con:Validator runat="server" ClientValidationFunction="CheckPurchaseOrderNumberRequired" Critical="true" ErrorMessage="This is a required field" />
                        </Validators>
                    </con:TextField>
                    <con:HiddenField runat="server" ID="PORequired" />
                    <con:CheckField runat="server" ID="DoNotInvoice" LabelText="Manual invoice" />
                </con:GroupBox>
            </div>
        </div>
    </con:WizardPage>
    <con:WizardPage runat="server" ID="MembershipPage" Title="Membership">
        <div class="row">
            <div class="col-12">
                <con:GroupBox runat="server" Title="Membership">
                    <div class="row">
                        <div class="col-12">
                            <con:PopupField runat="server" ID="MembershipProduct" LabelText="Membership" PopupUrl="~/learning/popups/productsearch.aspx?syProduct=10" Requirement="MandatoryEnforced" />
                        </div>
                    </div>
                    <div class="row">
                        <div class="col-6">
                            <con:DateField runat="server" ID="StartDate" LabelText="Start" Requirement="MandatoryEnforced" />
                        </div>
                        <div class="col-6">
                            <con:DateField runat="server" ID="EndDate" LabelText="End" Requirement="MandatoryEnforced" />
                        </div>
                    </div>
                    <div class="row">
                        <div class="col-5">
                            <con:CodeField runat="server" ID="ApplicationMethod" LabelText="Application Method" CodeType="MEMAP" />
                        </div>
                        <div class="col-5">
                            <con:TextField runat="server" ID="Quantity" LabelText="No of employees" TextMode="Number" />
                        </div>
                        <div class="col-2">
                            <con:CheckField runat="server" ID="Overseas" LabelText="Is Overseas" />
                        </div>
                    </div>
                    <div class="row">
                        <div class="col-5">
                            <con:ListField runat="server" ID="PriceList" LabelText="Price List" Requirement="MandatoryEnforced">
                            </con:ListField>
                        </div>
                    </div>
                    <div class="row">
                        <div class="col-6">
                        </div>
                        <div class="col-2">
                            <con:TextField runat="server" ID="NetTotal" LabelText="Net Total" IsReadOnly="TrueEnforced" />
                        </div>
                        <div class="col-2">
                            <con:TextField runat="server" ID="VAT" LabelText="VAT" IsReadOnly="TrueEnforced" />
                            <con:HiddenField runat="server" ID="VatCode" />
                        </div>
                        <div class="col-2">
                            <con:TextField runat="server" ID="Total" LabelText="Total" IsReadOnly="TrueEnforced" />
                        </div>
                    </div>
                </con:GroupBox>
            </div>
        </div>
    </con:WizardPage>
    <con:WizardPage runat="server" ID="MembershipProductGradePage" Title="Grade" Visible="false">
        <div class="row">
            <div class="col-12">
                <con:ListField runat="server" ID="productPrices" IsHidden="TrueEnforced" DisplayMember="Amount" ValueMember="ProdPrice" />
                <con:ListField runat="server" ID="PriceListForSummary" IsHidden="TrueEnforced" DisplayMember="Name" ValueMember="Id" />
                <con:ListField runat="server" ID="prodVATvalues" IsHidden="TrueEnforced" DisplayMember="Value3" ValueMember="Value1" />
                <con:GroupBox runat="server" Title="Grade">
                    <con:Validator runat="server" ClientValidationFunction="ValidateGradesList" ErrorMessage="You must select at least one grade" />
                    <con:DataTable runat="server" ID="MembershipProductGradesList" CanSearch="false" Mode="Stateful" CanCreate="false" CanModify="false" Url="">
                        <Columns>
                            <con:DataTableTextColumn Title="Grade ID" FieldName="PROD_ID" Visible="false" />
                            <con:DataTableTextColumn Title="Grade Name" FieldName="PROD_NAME" />
                            <con:DataTableTextColumn Title="Reference" FieldName="PROD_REF" />
                            <con:DataTableTextColumn Title="Upgrade Price" FieldName="PRS_PRICE" />
                            <con:DataTableTextColumn Title="Price" FieldName="VATCode" Visible="false" />
                            <con:DataTableCheckColumn Title="Select" FieldName="SELECTED" Width="45px" Orderable="False" />
                        </Columns>
                    </con:DataTable>
                    <div class="row">
                        <div class="col-6">
                        </div>
                        <div class="col-2">
                            <con:TextField runat="server" ID="GradeNetTotal" LabelText="Net Total" IsReadOnly="TrueEnforced" />
                        </div>
                        <div class="col-2">
                            <con:TextField runat="server" ID="GradeVat" LabelText="VAT" IsReadOnly="TrueEnforced" />
                        </div>
                        <div class="col-2">
                            <con:TextField runat="server" ID="GradeTotal" LabelText="Total" IsReadOnly="TrueEnforced" />
                        </div>
                    </div>
                </con:GroupBox>
            </div>
        </div>
    </con:WizardPage>
    <con:WizardPage runat="server" ID="SpecialistGroupPage" Title="Specialist groups">
        <div class="row">
            <div class="col-12">
                <con:GroupBox runat="server" Title="Specialist groups">
                    <con:DataTable runat="server" ID="SpecialistGroupList" CanExport="false" CanPrint="false" CanResize="false" CanSearch="false" Mode="Stateful" CanCreate="false" CanModify="false">
                        <Columns>
                            <con:DataTableTextColumn Title="Group name" FieldName="PROD_NAME" />
                            <con:DataTableTextColumn Title="Reference" FieldName="PROD_REF" />
                            <con:DataTableTextColumn Title="Price" FieldName="PROD_PRICE" />
                            <con:DataTableCheckColumn Title="Select" FieldName="SELECTED" Width="45px" Orderable="False" />
                        </Columns>
                    </con:DataTable>
                    <div class="row">
                        <div class="col-6">
                        </div>
                        <div class="col-2">
                            <con:TextField runat="server" ID="SpecialistGroupNetTotal" LabelText="Net Total" IsReadOnly="TrueEnforced" />
                        </div>
                        <div class="col-2">
                            <con:TextField runat="server" ID="SpecialistGroupVat" LabelText="VAT" IsReadOnly="TrueEnforced" />
                        </div>
                        <div class="col-2">
                            <con:TextField runat="server" ID="SpecialistGroupTotal" LabelText="Total" IsReadOnly="TrueEnforced" />
                        </div>
                    </div>
                </con:GroupBox>
            </div>
        </div>
    </con:WizardPage>
    <con:WizardPage runat="server" ID="MemberSummaryPage" Title="Summary">
        <div class="row">
            <div class="col-12">
                <con:GroupBox runat="server" Title="Pricing">
                    <div class="col-3">
                        <con:ListField runat="server" ID="PaymentMethod" LabelText="Payment Method" Requirement="MandatoryEnforced" ClientOnChange="CheckPayment()">
                            <Items>
                                <asp:ListItem Text="Do not take payment" Value="NONE" />
                                <asp:ListItem Text="Take payment now" Value="PAY" />
                                <asp:ListItem Text="Direct debit" Value="DD" />
                            </Items>
                        </con:ListField>
                    </div>
                    <con:DataTable runat="server" ID="NewSummaryList" CanSearch="false" Mode="Stateful" CanCreate="false" CanModify="true" Url="~/genericPopup.aspx?context=membership&control=MembershipProductSummary&guid={{_guid}}&productName={{Name}}&amount={{Amount}}&priceList={{PriceListId}}&vatCode={{VatCode}}&productId={{ProductId}}&priceListName={{PriceListName}}">
                        <Columns>
                            <con:DataTableTextColumn Title="Guid" FieldName="_guid" Orderable="False" Visible="false" />
                            <con:DataTableTextColumn Title="Product name" FieldName="Name" Orderable="False" />
                            <con:DataTableTextColumn Title="Amount" FieldName="Amount" Orderable="False" />
                            <con:DataTableTextColumn Title="Price list" FieldName="PriceListName" Orderable="False" />
                            <con:DataTableTextColumn Title="VAT code" FieldName="VatCode" Orderable="False" />
                        </Columns>
                    </con:DataTable>
                    <div class="row">
                        <div class="col-6">
                        </div>
                        <div class="col-2">
                            <con:TextField runat="server" ID="SummaryNetTotal" LabelText="Net Total" IsReadOnly="TrueEnforced" />
                        </div>
                        <div class="col-2">
                            <con:TextField runat="server" ID="SummaryVat" LabelText="VAT" IsReadOnly="TrueEnforced" />
                        </div>
                        <div class="col-2">
                            <con:TextField runat="server" ID="SummaryTotal" LabelText="Total" IsReadOnly="TrueEnforced" />
                        </div>
                    </div>
                </con:GroupBox>
            </div>
        </div>
    </con:WizardPage>
    <con:WizardPage runat="server" ID="PaymentPage" Title="Payment" Visible="false">
        <con:Payment runat="server" ID="Payment" />
    </con:WizardPage>
    <con:WizardPage runat="server" ID="TerminalPage" Title="Payment gateway" Visible="false">
        <h3 class="text-danger">Payment to be completed via DataCash</h3>
    </con:WizardPage>
    <con:WizardPage runat="server" ID="DirectDebitPage" Title="Direct Debit" Visible="false">
        <con:DirectDebit runat="server" ID="DirectDebit" />
    </con:WizardPage>
    <con:WizardPage runat="server" ID="ConfirmPage" Title="Complete">
    </con:WizardPage>
</con:Wizard>
<script>

    var specialistGroupListForMemberLocation = [];
    var GradesForMemberLocation = {};
    var membershipProductForMemberLocation = {};
    var memberPeriodId = null;
    var isGradePricePopulated = false;
    var newMemberWizard = {
        client: null,
        loader: 'One moment...',
        allContacts: null,
        controls: {
            member: {
                person: $('#<%= this.Person.ClientID %>Value'),
                personName: $('#<%= this.Person.ClientID %>Field'),
                membershipName: $('#<%= this.MembershipName.ClientID %>Field'),
                organisation: $('#<%= this.OrgName.ClientID %>Value'),
                arNumber: $('#<%= this.ARNumber.ClientID %>Field'),
                accountId: $('#<%= this.AccountId.ClientID %>Field'),
                sourceCode: $('#<%= this.SourceCode.ClientID %>Value'),
                sellingCompany: $('#<%= this.SellCompName.ClientID %>Field'),
                promotion: $('#<%= this.SourceCode.ClientID %>Value'),
                poNumber: $('#<%= this.PONumber.ClientID %>Field'),
                poRequired: $('#<%= this.PORequired.ClientID %>Field'),
                doNotInvoice: $('#<%= this.DoNotInvoice.ClientID %>Field'),
                addressId: $('#<%= this.AddressId.ClientID %>Field'),
                invoiceContact: $('#<%= this.InvoiceContact.ClientID %>Field'),
                invoiceAddressId: $('#<%= this.InvoiceAddressId.ClientID %>Field'),
                invOrganisationId:  $('#<%= this.InvoiceOrgId.ClientID %>Field')
            },
            membership: {
                product: $('#<%= this.MembershipProduct.ClientID %>Value'),
                startDate: $('#<%= this.StartDate.ClientID %>Field'),
                endDate: $('#<%= this.EndDate.ClientID %>Field'),
                quantity: $('#<%= this.Quantity.ClientID %>Field'),
                priceList: $('#<%= this.PriceList.ClientID %>Field'),                
                overseas: $('#<%= this.Overseas.ClientID %>Field'),
                applicationMethod: $('#<%= this.ApplicationMethod.ClientID %>Field'),
                netTotal: $('#<%= this.NetTotal.ClientID %>Field'),
                vat: $('#<%= this.VAT.ClientID %>Field'),
                total: $('#<%= this.Total.ClientID %>Field'),
                vatCode: $('#<%= this.VatCode.ClientID %>Field')
            },
            grade: {               
                gradeList: $('#<%= this.MembershipProductGradesList.ClientID %>Field'),
                netTotal: $('#<%= this.GradeNetTotal.ClientID %>Field'),
                vat: $('#<%= this.GradeVat.ClientID %>Field'),
                total: $('#<%= this.GradeTotal.ClientID %>Field'),
            },
            specialistGroup: {                   
                netTotal: $('#<%= this.SpecialistGroupNetTotal.ClientID %>Field'),
                vat: $('#<%= this.SpecialistGroupVat.ClientID %>Field'),
                total: $('#<%= this.SpecialistGroupTotal.ClientID %>Field'),
            },
            summary:{
                paymentMethod: $('#<%= this.PaymentMethod.ClientID %>Field'),
                netTotal: $('#<%= this.SummaryNetTotal.ClientID %>Field'),
                vat: $('#<%= this.SummaryVat.ClientID %>Field'),
                total: $('#<%= this.SummaryTotal.ClientID %>Field'),
            },
            payment: {
                paymentType: $('#<%= this.Payment.PaymentType.ClientID %>Field'),
                sellingCompany: $('#<%= this.Payment.SellingCompany.ClientID %>Field'),
            }
        },
        functions: {
            togglePages: function () {
                CheckPayment();
                newMemberWizard.pages.terminal.toggleClass('hidden', !payment.functions.useVirtualTerminal());
                newMemberWizard.pages.membershipProdGrades.toggleClass('hidden', !newMemberWizard.functions.showGradesList());
                newMemberWizard.pages.specialistGroup.toggleClass('hidden', !newMemberWizard.functions.checkSpecialistGroupExist());
                newMemberWizard.client._init(false);
            },
            togglePaymentPages: function(){
                CheckPayment();
                newMemberWizard.pages.terminal.toggleClass('hidden', !payment.functions.useVirtualTerminal());
            },
            populatePriceList: function () {

                // Validate that the required controls have a value
                newMemberWizard.controls.membership.priceList.find('option').remove();
                if (newMemberWizard.controls.membership.product.val().length == 0)
                    return;

                // Provide a loading indicator and then request the data from the RESTful API
                $('<option />').attr('selected', 'selected').text(newMemberWizard.loader).appendTo(newMemberWizard.controls.membership.priceList.attr('disabled', 'disabled'));
                consensus.network.send({
                    method: 'post',
                    url: 'finance/pricelist/fetchAllByProductId',
                    data: { 
                        productId: newMemberWizard.controls.membership.product.val(),
                        serialization: {
                            Include: {
                                "Finance.PriceList": ["Name"]
                            }
                        }
                    },
                    success: function (result) {
                        newMemberWizard.controls.membership.priceList.attr('disabled', null).find('option').remove();
                        for (var i = 0; i < result.length; i++)
                            $('<option />').attr('value', result[i].Id).text(result[i].Name).appendTo(newMemberWizard.controls.membership.priceList);
                        newMemberWizard.functions.populatePrice();
                    }
                });
            },

            populateGradeList: function () {
                var hidden = true;
                var prodParentId = newMemberWizard.controls.membership.product.val();
                var allProdPriceList = document.getElementById("<%= this.productPrices.ClientID %>Field").options;
                GradesForMemberLocation = {};
                consensus.network.send({
                    method: 'post',
                    url: 'membership/memberbom/FetchAllByProdParentIdId?prodParentIdId=' + prodParentId,
                    success: function (result) {                        
                        if (result.length && result.length > 0) {
                            hidden = false;
                            var memProdGrades = window['<%= this.MembershipProductGradesList.ClientID %>'];
                            var newArray = [];
                            var modified_arr = [];
                            var totFeeAmt = 0;
                            loop1:
                            for (var i = 0; i < result.length; i++) {
                                //iterate through Prices for all products
                                loop2:
                                    for (var j = 0; j < allProdPriceList.length; j++) {
                                        //Binded product price object in list field. 
                                        if(allProdPriceList[j].value){
                                            var productId= allProdPriceList[j].value.split("ProductId = ")[1].split(",")[0];
                                            var priceListId = allProdPriceList[j].value.split("PriceListId = ")[1].split(",")[0].split("}")[0];
                                            if (result[i].GradeProdId == productId) {
                                                newArray[i] = result[i];
                                                if (result[i].Main == "1") {

                                                    //Checks if Account Vat code is there
                                                    var accountVatCode = $('#<%= this.AccVatcode.ClientID %>Field').val(); 
                                                    var vatCode=accountVatCode;
                                                    if(!accountVatCode){
                                                        vatCode=result[i].GradeProd.VatCodeCode;
                                                    }

                                                    GradesForMemberLocation = {
                                                        ProductId: result[i].GradeProd.Id,
                                                        SyType: 2,
                                                        Status: 0,
                                                        Current: 1,
                                                        Fee: parseFloat(parseFloat(allProdPriceList[j].text).toFixed(2)),
                                                        Vatcd: vatCode,
                                                        ProductName: result[i].GradeProd.Name,
                                                        PlIdId: priceListId,
                                                        ProductVatCode: result[i].GradeProd.VatCodeCode
                                                    };

                                                    ProductChanged();
                                                    CheckPayment();
                                                    isGradePricePopulated=true;
                                                                                                   
                                                }
                                                modified_arr.push({
                                                    "PROD_ID": result[i].GradeProd.Id,
                                                    "PROD_NAME": result[i].GradeProd.Name,
                                                    "PROD_REF": result[i].GradeProd.Ref,
                                                    "PRS_PRICE": parseFloat(parseFloat(allProdPriceList[j].text).toFixed(2)),
                                                    "VATCode": result[i].GradeProd.VatCodeCode,
                                                    "SELECTED": result[i].Main,
                                                    "PRS_PL_ID": priceListId
                                                });

                                                continue loop1;
                                            }
                                        }
                                    }
                                //break;
                                    if (result[i].Main == "1") {
                                        
                                        //Checks if Account Vat code is there
                                        var accountVatCode = $('#<%= this.AccVatcode.ClientID %>Field').val(); 
                                        var vatCode=accountVatCode;
                                        if(!accountVatCode){
                                            vatCode=result[i].GradeProd.VatCodeCode;
                                        }

                                        GradesForMemberLocation = {
                                            ProductId: result[i].GradeProd.Id,
                                            SyType: 2,
                                            Status: 0,
                                            Current: 1,
                                            Fee: 0,
                                            Vatcd: vatCode,
                                            ProductName: result[i].GradeProd.Name,
                                            PlIdId: "",
                                            ProductVatCode: result[i].GradeProd.VatCodeCode
                                        };

                                        ProductChanged();
                                        CheckPayment();
                                        isGradePricePopulated=true;                                        

                                    }
                                    modified_arr.push({
                                        "PROD_ID": result[i].GradeProd.Id,
                                        "PROD_NAME": result[i].GradeProd.Name,
                                        "PROD_REF": result[i].GradeProd.Ref,
                                        "PRS_PRICE": "0",
                                        "VATCode": result[i].GradeProd.VatCodeCode,
                                        "SELECTED": result[i].Main,
                                        "PRS_PL_ID": ""
                                    });
                                }

                                memProdGrades._setSourceData(modified_arr);
                                memProdGrades.reload();
                                hidden = false;
                                newMemberWizard.functions.showHideGradeList(false);
                            }
                            else { hidden = true; newMemberWizard.functions.showHideGradeList(true); }
                    }
                });
                return hidden;
                //}

            },
            showHideGradeList: function (value) {
                if (value)
                    newMemberWizard.pages.membershipProdGrades.toggleClass('hidden', true);
                else
                    newMemberWizard.pages.membershipProdGrades.toggleClass('hidden', false);
            },
            showGradesList: function () {
                if (newMemberWizard.controls.membership.product.val().length == 0)
                    return;
                else
                    var response = newMemberWizard.functions.populateGradeList();
            },
            populateEndDate: function () {

                // Validate that the required controls have a value
                newMemberWizard.controls.membership.endDate.val('');
                if (newMemberWizard.controls.membership.product.val().length == 0)
                    return;
                if (newMemberWizard.controls.membership.startDate.val().length == 0)
                    return;

                // Provide a loading indicator and then request the data from the RESTful API
                newMemberWizard.controls.membership.endDate.attr('disabled', 'disabled').val(newMemberWizard.loader);
                consensus.network.send({
                    method: 'post',
                    url: 'learning/productmembership/' + newMemberWizard.controls.membership.product.val() + '/CalculateMembershipEndDate',
                    data: { startDate: newMemberWizard.controls.membership.startDate.val() },
                    success: function (result) {
                        newMemberWizard.controls.membership.endDate.parents('[data-provide=datepicker]').first().datepicker("update", result);
                        newMemberWizard.controls.membership.endDate.attr('disabled', null);
                        directdebit.controls.dateEnd.val(result.toDateString());
                        directdebit.controls.dateDue.val(directdebit.functions.calculateDueDate(newMemberWizard.controls.membership.startDate.val()));
                        newMemberWizard.functions.populatePrice();
                    }
                });
            },
            populatePrice: function () {

                // Validate that the required controls have a value                
                if (newMemberWizard.controls.membership.product.val().length == 0)
                    return;
                if (newMemberWizard.controls.membership.startDate.val().length == 0)
                    return;
                if (newMemberWizard.controls.membership.endDate.val().length == 0 || newMemberWizard.controls.membership.endDate.val() == newMemberWizard.loader)
                    return;
                if (newMemberWizard.controls.membership.priceList.val().length == 0 || newMemberWizard.controls.membership.priceList.val() == newMemberWizard.loader)
                    return;
                if (newMemberWizard.controls.member.person.val().length == 0)
                    return;

                // Provide a loading indicator and then request the data from the RESTful API
                
                consensus.network.send({
                    method: 'post',
                    url: 'learning/productmembership/' + newMemberWizard.controls.membership.product.val() + '/CalculateMembershipPrice',
                    data: {
                        personId: newMemberWizard.controls.member.person.val(),
                        startDate: newMemberWizard.controls.membership.startDate.val(),
                        endDate: newMemberWizard.controls.membership.endDate.val(),
                        priceList: newMemberWizard.controls.membership.priceList.val(),
                        quantity: parseInt(newMemberWizard.controls.membership.quantity.val())
                    },
                    success: function (result) {
                        var price = parseFloat(result.Total);
                        var fee = parseFloat(result.Amount);
                        var accountVatCode = $('#<%= this.AccVatcode.ClientID %>Field').val();
                        var vatRate = result.VatRate;
                        var vatAmount = result.VatAmount;
                        if(accountVatCode) {
                            vatRate = newMemberWizard.functions.getVatRate(accountVatCode);
                            vatAmount = fee * parseFloat(vatRate)/100;
                            price = fee + vatAmount;
                        }          
                        else{
                            accountVatCode=result.VatCode;
                        }
                        
                        newMemberWizard.controls.membership.vatCode.val(accountVatCode);

                        var netTotal = parseFloat(!isNaN(fee) && fee >= 0 ? fee.toFixed(2) : '0');
                        var vatAmount = parseFloat(vatAmount.toFixed(2));
                        var total = parseFloat(!isNaN(price) && price >= 0 ? price.toFixed(2) : '0');
                        
                        membershipProductForMemberLocation={
                            RoleId: newMemberWizard.controls.member.person.val(),
                            OrgIdId: newMemberWizard.controls.member.organisation.val(),
                            Overseas: newMemberWizard.controls.membership.overseas.is(':checked'),
                            PlIdId: newMemberWizard.controls.membership.priceList.val(),
                            RenewLoc: 1,
                            Fee: netTotal,
                            Vatcd: newMemberWizard.controls.membership.vatCode.val(),
                            ProductId: newMemberWizard.controls.membership.product.val(),
                            ProductName: $('#<%= this.MembershipProduct.ClientID %>Field').val(),
                            ProductVatCode: result.VatCode
                        };

                        ProductChanged();    
                        CheckPayment();
                                               
                    }
                });

            },
            calculateFeeIncVAT: function (Amount, VATCode) {
                Amount = parseFloat(Amount);
                var vatAmount = 0; var totFeeAmt = 0;
                var allVATValues = document.getElementById("<%= this.prodVATvalues.ClientID %>Field").options;

                for (var i = 0; i < allVATValues.length; i++) {
                    if (allVATValues[i].value == VATCode) {
                        var VATRate = parseFloat(allVATValues[i].text);
                        vatAmount = parseFloat(Amount * VATRate / 100);
                        totFeeAmt = parseFloat(Amount + vatAmount);

                        break;
                    }
                }

                return totFeeAmt;
            },
            getVatRate: function (vatCode) {                           
                var allVATValues = document.getElementById("<%= this.prodVATvalues.ClientID %>Field").options;
                var VATRate = 0;
                for (var i = 0; i < allVATValues.length; i++) {
                    if (allVATValues[i].value == vatCode) {
                        var VATRate = parseFloat(allVATValues[i].text);                                       
                        break;
                    }
                }
                return VATRate;
            },
            updateSummaryDetails:function(){
                var summaryTable = $('#<%= this.NewSummaryList.ClientID %>').DataTable();
                var arrPrices = summaryTable.rows().data();
                var netTotal = 0, vatTotal = 0, total = 0;
                
                for (i = 0; i < arrPrices.length; i++) {
                    var vatRate = 0;
                    if(arrPrices[i].VatCode){
                        vatRate = newMemberWizard.functions.getVatRate(arrPrices[i].VatCode);
                    }        
                    vatTotal = vatTotal + (parseFloat(arrPrices[i].Amount) * parseFloat(vatRate)/100);                                        
                    netTotal=netTotal+parseFloat(arrPrices[i].Amount);
                    total= netTotal + vatTotal;   
                }
                UpdateSummaryPageTotal(netTotal.toFixed(2),vatTotal.toFixed(2),total.toFixed(2));
                UpdatePaymentDirectDebitTotal(total.toFixed(2));
                CheckPayment();
            },
            onBack: function(sourcePage, targetPage){
                var paymentCase = 6, directDebitCase = 7, newMemberWizardPage = 8, summaryCase = 4, gradeCase=2, specialistGroupCase=3, membershipCase=1;

                switch (targetPage) {
                    case membershipCase:
                        ProductChanged('membership');
                        break;

                    case gradeCase:
                        ProductChanged('grade');
                        break;

                    case specialistGroupCase:
                        ProductChanged('specialistgroup');
                        break;
                }
                return true;
            },
            onNext: function (sourcePage, targetPage) {

                var paymentCase = 6, directDebitCase = 7, newMemberWizardPage = 8, summaryCase = 4, gradeCase=2, specialistGroupCase=3, membershipCase=1;

                switch (targetPage) {
                    case membershipCase:
                        ProductChanged('membership');
                        break;

                    case gradeCase:
                        ProductChanged('grade');
                        break;

                    case specialistGroupCase:
                        ProductChanged('specialistgroup');
                        break;

                    case summaryCase:
                        var membership=CreateMembershipObject();
                        PopulateSummary(membership);
                        break;

                    case paymentCase:
                        newMemberWizard.client.showProgress('Connecting to payment gateway', 'info');
                        setTimeout(function () {
                            newMemberWizard.client.showProgress('Payment gateway not supported', 'error', false);
                        }, 1000);
                        break;
                    case directDebitCase:
                        directdebit.controls.accountName.val(newMemberWizard.controls.member.personName.val());
                        directdebit.functions.recalculateRepayments();
                        break;
                    case newMemberWizardPage:
                        newMemberWizard.client.showProgress('Creating membership', 'info');
                        var pMethod = '', pStatus = '';
                        switch (newMemberWizard.controls.summary.paymentMethod.val()) {
                            case 'PAY':
                                pMethod = '01-Invoice';
                                pStatus = payment.controls.paymentStatus.children('option').filter(':selected').text();
                                break;
                            case 'DD':
                                pMethod = '03-Direct Debit';
                                pStatus = '00-Processed';
                                break;
                        }

                        var membership=CreateMembershipObject();
                        membership= UpdateMemberLocations(membership);
                        membership.PayMethodCode=pMethod;
                        membership.PayStatusCode=pStatus;

                        switch (newMemberWizard.controls.summary.paymentMethod.val()) {
                            case 'PAY':
                                var state = new consensus.data.state(null, {}, $('#' + newMemberWizard.pages.payment.attr('data-page')));
                                state.updateObject();
                                membership.currentPeriod.payments = [state.object];
                                break;
                            case 'DD':
                                var state = new consensus.data.state(null, {}, $('#' + newMemberWizard.pages.directDebit.attr('data-page')));
                                state.updateObject();
                                membership.currentPeriod.directDebits = [state.object];
                                break;
                        }

                        consensus.network.send({
                            method: 'put',
                            url: 'membership/membership',
                            data: membership,
                            success: function (result) {
                                newMemberWizard.client.showProgress('Membership created successfully', 'success', true);
                                memberPeriodId = result.CurrentPeriod.Id;
                            },
                            error: function (request) {
                                newMemberWizard.client.showProgress('Could not create membership<br/>' + request.statusText, 'error', true);
                            }
                        })
                        break;
                }
                return true;
            },
            onFinish: function () {
                if (memberPeriodId && memberPeriodId.length != 0) {
                    window.top.window.location.href = consensus.resolveUrl('~/membership/member?id=' + memberPeriodId);
                }
                return true;
            },
            checkSpecialistGroupExist: function () {
                if (window['<%= this.SpecialistGroupList.ClientID %>'] != null) {
                    var specialistGroupList = window['<%= this.SpecialistGroupList.ClientID %>']._getSourceData();
                    if (specialistGroupList.length > 0) {
                        return true;
                    }
                }
                return false;
            },
            dataTabletoggle: function (check, field) {
                var totFeeAmt = 0;
                var chk = $(check);
                var row = chk.parents('tr').first();
                var tbl = chk.parents('table').first();
                var obj = tbl.dataTable().api().row(row).data();
                if (tbl[0].id.indexOf("SpecialistGroupList") > -1) {

                    //Checks if Account Vat code is there
                    var accountVatCode = $('#<%= this.AccVatcode.ClientID %>Field').val(); 

                    if (check.checked) {

                        //If account vat code is there then that is used for product
                        var vatCode=accountVatCode;
                        if(!accountVatCode){
                            vatCode = obj.PROD_VAT_CODE;
                        }
                        specialistGroupListForMemberLocation.push({
                            ProductId: obj.PROD_ID,
                            SyType: 1,
                            Status: 0,
                            Fee: obj.PROD_PRICE,
                            Vatcd: vatCode,
                            ProductName: obj.PROD_NAME,
                            PlIdId: obj.PRS_PL_ID,
                            ProductVatCode: obj.PROD_VAT_CODE
                        });
                    }
                    else {
                        var index = specialistGroupListForMemberLocation.findIndex(x=>x.ProductId == obj.PROD_ID);
                        if (index > -1) {
                            specialistGroupListForMemberLocation.splice(index, 1);
                        }
                    }

                    ProductChanged();       
                    CheckPayment();
                    
                }
                // when Grades will be selected / de-selected
                if (tbl[0].id.indexOf("MembershipProductGradesList") > -1) {
                    if (!check.checked) { check.checked = true; }
                    if (check.checked) {
                        //newMemberWizard.controls.grade.gradeFee.val(!isNaN(totFeeAmt) && totFeeAmt >= 0 ? totFeeAmt.toFixed(2) : '');

                        var newGrades = window['<%= this.MembershipProductGradesList.ClientID %>'];
                        var array = $('#<%= this.MembershipProductGradesList.ClientID %>').DataTable().rows().data();
                        var sourceData = newGrades._getSourceData();
                        var count = 0;

                        for (var i = 0; i < array.length; i++) {
                            //we need to keep track of which tick box we are dealing with, to untick later
                            if (obj == array[i]) {
                                count = i;
                            }
                            else {
                                //untick it as we are not wanting it now
                                if (obj.SELECTED == "0" && array[i].SELECTED == "1") {
                                    array[i].SELECTED = 0
                                }

                            }
                            sourceData[i] = array[i];
                        }
                        if (obj.SELECTED == "0") {
                            sourceData[count].SELECTED = 1;
                        }
                        //else {
                        //    sourceData[count].SELECTED = 0;
                        //}

                        newGrades._setSourceData(sourceData);
                        newGrades.reload();
                                                                  
                        //Checks if Account Vat code is there
                        var accountVatCode = $('#<%= this.AccVatcode.ClientID %>Field').val(); 
                        //If account vat code is there then that is used for product
                        var vatCode=accountVatCode;
                        if(!accountVatCode){
                            vatCode = obj.VATCode;
                        }

                        GradesForMemberLocation = {
                            ProductId: obj.PROD_ID,
                            SyType: 2,
                            Status: 0,
                            Current: 1,
                            Fee: obj.PRS_PRICE,
                            Vatcd: vatCode,
                            ProductName: obj.PROD_NAME,
                            ProductVatCode: obj.VATCode,
                            PlIdId: obj.PRS_PL_ID.trim(),
                        };

                        ProductChanged();
                        CheckPayment();
                    }
                    else {                       
                    }
                }
            },
            getARNumbers: function () {
                var arNumberField = $('#<%= this.ARNumber.ClientID %>Field');
                var accountField = $('#<%= this.AccountId.ClientID %>Field');
                var roleId = $('#<%= this.Person.ClientID %>Value').val();
                var orgId = $('#<%= this.OrgName.ClientID %>Value').val();
                var sellingCompany = newMemberWizard.controls.member.sellingCompany.val();

                consensus.network.send({
                    method: 'post',
                    async: false,
                    url: 'finance/account/fetchByXrefRoleIdandOrgId',
                    data: { 
                        roleId: roleId, 
                        orgId: orgId, 
                        spId: sellingCompany,
                        serialization: {
                            Include: {
                                "Finance.Account": ["ARNumber", "Title"]
                            }
                        }
                    },
                    success: function (result) {
                        // Remove the existing options
                        accountField.find('option').remove();
                        arNumberField.find('option').remove();

                        // Create the new options
                        for (var i = 0; i < result.length; i++){
                            $('<option />').attr('value', result[i].Id).text(result[i].ARNumber + ' - ' + result[i].Title).appendTo(accountField);
                            $('<option />').attr('value', result[i].Id).text(result[i].ARNumber).appendTo(arNumberField);
                        }
                    }
                });
                newMemberWizard.functions.getBillingContacts();
            },
            getBillingContacts: function () {
                var accountField = $('#<%= this.AccountId.ClientID %>Field');
                var invoiceContactField = $('#<%= this.InvoiceContact.ClientID %>Field');
                var accId = accountField.val();
                var proleId = $('#<%= this.Person.ClientID %>Value').val();

                consensus.network.send({
                    method: 'post',
                    async: false,
                    url: 'common/genericmodel/fetchAllByAccIdAccountXref',
                    data: { 
                        accId: accId, 
                        proleId: proleId,
                        serialization: {
                            Include: {
                                "Common.GenericModel": ["Id3", "Desc2", "Desc4"]
                            }
                        }
                    },
                    success: function (result) {
                        // Remove the existing options
                        invoiceContactField.find('option').remove();

                        newMemberWizard.allContacts = result;

                        for (var i = 0; i < result.length; i++) {
                            $('<option />').attr('value', result[i].Id3).text(result[i].Desc2).appendTo(invoiceContactField);
                            $('#<%= this.AccVatcode.ClientID %>Field').val(result[i].Desc4);
                        }                       
                        AccountChanged();
                    }
                });
                newMemberWizard.functions.setInvoiceDetails();
            },
            setInvoiceDetails: function () {
                var invoiceContactField = $('#<%= this.InvoiceContact.ClientID %>Field');
                var contactDetails = [];
                contactDetails = newMemberWizard.allContacts;
                for (var i = 0; i < contactDetails.length; i++) {
                    if (contactDetails[i].Id3 == invoiceContactField.val()) {
                        $('#<%= this.InvoiceOrganisation.ClientID %>Field').val(contactDetails[i].Desc1);
                        $('#<%= this.InvoiceOrgId.ClientID %>Field').val(contactDetails[i].Id2);
                        <%=this.Payment.Organisation.ClientID%>.setValue(contactDetails[i].Id2, contactDetails[i].Desc1);
                        <%=this.Payment.Person.ClientID%>.setValue(contactDetails[i].Id3, contactDetails[i].Desc2);
                        $('#<%= this.InvoiceAddress.ClientID %>Field').val(contactDetails[i].Longdesc);
                        $('#<%= this.InvoiceAddressId.ClientID %>Field').val(contactDetails[i].Id4);
                        $('#<%= this.Payment.AddressId.ClientID %>Field').val(contactDetails[i].Id4);
                        <%=this.Payment.Account.ClientID%>.setValue($('#<%= this.ARNumber.ClientID %>Field').val(), contactDetails[i].Desc3);
                        if (contactDetails[i].Int2 == "1") {
                            $("#<%= this.PaymentMethod.ClientID %>Field option[value='NONE']").attr("hidden",true);
                            $('#<%= this.PaymentMethod.ClientID %>Field').val("PAY");                            
                        }
                        else {
                            $("#<%= this.PaymentMethod.ClientID %>Field option[value='NONE']").attr("hidden",false);
                            $('#<%= this.PaymentMethod.ClientID %>Field').val("NONE");                               
                        }
                        newMemberWizard.controls.member.poRequired.val(contactDetails[i].Desc5);
                        CheckPayment();
                    }
                }
            },            
            checkTakingPayment: function () {
                if ($('#<%= this.PaymentMethod.ClientID %>Field').val() == "PAY" || $('#<%= this.PaymentMethod.ClientID %>Field').val() == "DD") {                  
                    var amount= parseFloat(newMemberWizard.controls.summary.total.val());
                    if (amount > 0) {
                        return true;
                    }
                    else {
                        return false;
                    }
                }
                return false;
            }
        },        
        pages: {
            member: $('[data-page="<%= this.MemberPage.ClientID %>"]'),
            membership: $('[data-page="<%= this.MembershipPage.ClientID %>"]'),
            payment: $('[data-page="<%= this.PaymentPage.ClientID %>"]'),
            terminal: $('[data-page="<%= this.TerminalPage.ClientID %>"]'),
            directDebit: $('[data-page="<%= this.DirectDebitPage.ClientID %>"]'),
            confirm: $('[data-page="<%= this.ConfirmPage.ClientID %>"]'),
            membershipProdGrades: $('[data-page="<%= this.MembershipProductGradePage.ClientID %>"]'),
            specialistGroup: $('[data-page="<%= this.SpecialistGroupPage.ClientID %>"]')
        }        
    };

    $(document).ready(function () {
        newMemberWizard.client = window['<%= this.Wizard.ClientID %>'];
        newMemberWizard.client.onNext = newMemberWizard.functions.onNext;
        newMemberWizard.client.onBack = newMemberWizard.functions.onBack;
        newMemberWizard.client.onFinish = newMemberWizard.functions.onFinish;
        newMemberWizard.functions.togglePages();
        payment.functions.onLoadConfiguration = newMemberWizard.functions.togglePaymentPages;
        window.consensus.web.dataTable.toggle = newMemberWizard.functions.dataTabletoggle;        

        $('[id$=_PopupFooterPanel]').show(); // to show the customise button from the footer that gets hided.
        $('[id$=_PopupFooterPanel]').find('#Content_CustomiseButton').addClass('Content_CustomiseButton')
        $('[id$=_PopupFooterPanel]').find('#Content_PopupFooter_SaveButton').css('display', 'none');
        $('[id$=_PopupFooterPanel]').find('#Content_PopupFooter_UndoButton').css('display', 'none');

        CheckIfCalledFromPersonPage();
    });

    function ValidateGradesList(source, arguments) {
        arguments.IsValid = ($('#<%= this.MembershipProductGradesList.ClientID %>').find('input[type="checkbox"]:checked').length)
    };

    //Selects ARNumber as per account
    function SelectArNumber(){
        var accountId= $('#<%= this.AccountId.ClientID %>Field').val();
        var allArNumbers = document.getElementById("<%= this.ARNumber.ClientID %>Field").options;
        for(var i=0; i< allArNumbers.length; i++){
            if(allArNumbers[i].value==accountId) {
                $('#<%= this.ARNumber.ClientID %>Field').val(allArNumbers[i].text);
                break;
            }
        }
    }

    //Gets object for total amount
    function GetObjectForTotalAmount(vatCode, price, netTotal, vatAmount){ 
        var vatRate = 0;
        if(vatCode){
            vatRate = newMemberWizard.functions.getVatRate(vatCode);
        }
        else{
            vatRate = 0;
        }        
        var vatAmount = vatAmount + (parseFloat(price) * parseFloat(vatRate)/100);
        var netTotal = netTotal + parseFloat(price);
        var total= netTotal + vatAmount;   
        return {netTotal: netTotal, vatAmount:vatAmount, total:total, vatCode: vatCode};
    }   

    function CheckPayment() {
        
        var isPayment= newMemberWizard.controls.summary.paymentMethod.val() != 'PAY';  
        var checkAmount= !isPayment;
        if(!isPayment){
            checkAmount= newMemberWizard.functions.checkTakingPayment();
        }
        newMemberWizard.pages.payment.toggleClass('hidden', !checkAmount);

        var isDirectDebit= newMemberWizard.controls.summary.paymentMethod.val() != 'DD';    
        checkAmount=!isDirectDebit;
        if(!isDirectDebit){
            checkAmount=newMemberWizard.functions.checkTakingPayment();
        }
        newMemberWizard.pages.directDebit.toggleClass('hidden', !checkAmount);
           
    }

    //Populates Summary Datatable
    function PopulateSummary(membership){        
        var priceListSummary = document.getElementById('<%= this.PriceListForSummary.ClientID%>Field').options;
        var sourceData=[];
        for(var i=0;i<membership.currentPeriod.MemberLocations.length;i++){
            var memberLocation=membership.currentPeriod.MemberLocations[i];

            var priceListName="";
            if(memberLocation.PlIdId){
                for (var j = 0; j < priceListSummary.length; j++) {
                    if(priceListSummary[j].value.trim()==memberLocation.PlIdId.trim()){
                        priceListName=priceListSummary[j].text;
                        break;
                    }
                }
            }
            var object={
                "_guid": consensus.data.guid(),                
                "Name": memberLocation.ProductName,
                "Amount": memberLocation.Fee,                
                "VatCode": memberLocation.Vatcd,                
                "ProductId": memberLocation.ProductId,                
                "PriceListId": memberLocation.PlIdId,
                "PriceListName": priceListName
            };            
            sourceData.push(object);
        }
        window['<%= this.NewSummaryList.ClientID %>']._setSourceData(sourceData);
        window['<%= this.NewSummaryList.ClientID %>'].reload();
    }

    //Creates object for creating Membership
    function CreateMembershipObject(){

        //Checks if ManualInvoice is toggled on
        var manualInvoice=0;
        if(newMemberWizard.controls.member.doNotInvoice.prop("checked")){
            manualInvoice=1;
        }

        var membership = {
            currentPeriod: {
                MemberLocations: [membershipProductForMemberLocation],
                AccountId: newMemberWizard.controls.member.accountId.val(),
                AccountRef: newMemberWizard.controls.member.arNumber.text().trim(),
                SourceCodeId: newMemberWizard.controls.member.promotion.val(),
                ProductId: newMemberWizard.controls.membership.product.val(),
                Start: newMemberWizard.controls.membership.startDate.val(),
                End: newMemberWizard.controls.membership.endDate.val(),
                AppMethodCode: newMemberWizard.controls.membership.applicationMethod.val(),
                Qty1: newMemberWizard.controls.membership.quantity.val(),
                PriceListId: newMemberWizard.controls.membership.priceList.val(),
                StatusCode: '00-Application',
                InvoiceRoleId: newMemberWizard.controls.member.invoiceContact.val(),                
                MembershipName: newMemberWizard.controls.member.membershipName.val(),
                CustOrderNo: newMemberWizard.controls.member.poNumber.val(),
                ManualInvoice: manualInvoice,
                MailAddIdId: newMemberWizard.controls.member.addressId.val(),
                SellingCompanyId: newMemberWizard.controls.member.sellingCompany.val(),
                InvAddressId: newMemberWizard.controls.member.invoiceAddressId.val(),
                InvOrganisationId: newMemberWizard.controls.member.invOrganisationId.val()
            }
        };

        //Adds Specialist group product
        if (specialistGroupListForMemberLocation.length > 0) {
            membership.currentPeriod.MemberLocations.push.apply(membership.currentPeriod.MemberLocations, specialistGroupListForMemberLocation);
        }

        //Adds Membership grade product
        if (GradesForMemberLocation.ProductId) {
            membership.currentPeriod.MemberLocations.push(GradesForMemberLocation);
        }    
        return membership;
    }

    //Updates Member location for each Product 
    function UpdateMemberLocations(membership){
        var updateData= window['<%= this.NewSummaryList.ClientID %>']._getSourceData();
        var memberLocations= membership.currentPeriod.MemberLocations;
        memberLocations.forEach(function(x){
            updateData.forEach(function(data){
                if(data.ProductId == x.ProductId){
                    x.PlIdId=data.PriceListId;
                    x.Fee = data.Amount;
                    x.Vatcd = data.VatCode;
                }
            });
        });
        membership.currentPeriod.MemberLocations=memberLocations;
        return membership;
    }

    //Updates Membership Page values
    function UpdateMembershipProductTotal(netTotal, vatAmount, total){
        newMemberWizard.controls.membership.netTotal.val(netTotal);
        newMemberWizard.controls.membership.total.val(total);
        newMemberWizard.controls.membership.vat.val(vatAmount);        
    }

    //Updates Grade page values
    function UpdateGradeTotal(netTotal, vatTotal, total){
        newMemberWizard.controls.grade.netTotal.val(netTotal);
        newMemberWizard.controls.grade.vat.val(vatTotal);
        newMemberWizard.controls.grade.total.val(total);
    }

    //Updates Specialist Group page values
    function UpdateSpecialistGroupTotal(netTotal, vatTotal, total){
        newMemberWizard.controls.specialistGroup.netTotal.val(netTotal);
        newMemberWizard.controls.specialistGroup.vat.val(vatTotal);
        newMemberWizard.controls.specialistGroup.total.val(total);
    }

    //Updates Summary page values
    function UpdateSummaryPageTotal(netTotal, vatTotal, total){
        newMemberWizard.controls.summary.netTotal.val(netTotal);
        newMemberWizard.controls.summary.vat.val(vatTotal);
        newMemberWizard.controls.summary.total.val(total);
    }

    //Updates Payment and Direct debit total
    function UpdatePaymentDirectDebitTotal(total){
        payment.controls.amount.val(total);
        directdebit.controls.amount.val(total);
        directdebit.controls.balance.val(total);
    }    
   
    //Updates total depending on step
    function ProductChanged(step){

        if(!step)
            step=$("#<%= this.Wizard.ClientID %> .current").text().toLowerCase();
        
        //Checks if Account Vat code is there
        var accountVatCode = $('#<%= this.AccVatcode.ClientID %>Field').val();       

        var totalAmountObject = {netTotal: 0, vatAmount:0, total:0, vatCode: accountVatCode};

        if(membershipProductForMemberLocation.ProductId){
            totalAmountObject = GetObjectForTotalAmount(membershipProductForMemberLocation.Vatcd, membershipProductForMemberLocation.Fee, totalAmountObject.netTotal, totalAmountObject.vatAmount);                          
        }

        if(step!= 'membership'){
            if(GradesForMemberLocation.ProductId){
                totalAmountObject = GetObjectForTotalAmount(GradesForMemberLocation.Vatcd, GradesForMemberLocation.Fee, totalAmountObject.netTotal, totalAmountObject.vatAmount);                          
            }

            if(step!='grade'){
                if(specialistGroupListForMemberLocation.length>0){
                    for(var i=0; i< specialistGroupListForMemberLocation.length; i++){
                        totalAmountObject = GetObjectForTotalAmount(specialistGroupListForMemberLocation[i].Vatcd, specialistGroupListForMemberLocation[i].Fee, totalAmountObject.netTotal, totalAmountObject.vatAmount);                          
                    }
                }          
            }
        }      

        var totalOfAllProducts = parseFloat(totalAmountObject.total.toFixed(2));
        var vatTotalOfAllProducts = parseFloat(totalAmountObject.vatAmount.toFixed(2));
        var netTotalOfAllProducts = parseFloat(totalAmountObject.netTotal.toFixed(2));

        //Updates Net total, Vat and Total of Membership product
        UpdateMembershipProductTotal(netTotalOfAllProducts,vatTotalOfAllProducts,totalOfAllProducts);        

        //Updates Net total, Vat and Total of Grades page
        UpdateGradeTotal(netTotalOfAllProducts,vatTotalOfAllProducts,totalOfAllProducts);

        //Updates Net total, Vat and Total of Specialist group page
        UpdateSpecialistGroupTotal(netTotalOfAllProducts,vatTotalOfAllProducts,totalOfAllProducts);

        //Updates Net total, Vat and Total of Summary page
        UpdateSummaryPageTotal(netTotalOfAllProducts,vatTotalOfAllProducts,totalOfAllProducts);

        //Updates Payment and Direct debit total values                       
        UpdatePaymentDirectDebitTotal(totalOfAllProducts);

    }

    //Vat code is updated when Account is changed for all steps
    function AccountChanged(){
        var accountVatCode = $('#<%= this.AccVatcode.ClientID %>Field').val();         

        if(membershipProductForMemberLocation.ProductId){
            if(accountVatCode)
                membershipProductForMemberLocation.Vatcd = accountVatCode;
            else
                membershipProductForMemberLocation.Vatcd = membershipProductForMemberLocation.ProductVatCode;
        }

        if(GradesForMemberLocation.ProductId){
            if(accountVatCode)
                GradesForMemberLocation.Vatcd = accountVatCode;
            else
                GradesForMemberLocation.Vatcd = GradesForMemberLocation.ProductVatCode;
        }

        if(specialistGroupListForMemberLocation.length>0){
            for(var i=0; i< specialistGroupListForMemberLocation.length; i++){
                if(accountVatCode)
                    specialistGroupListForMemberLocation[i].Vatcd=accountVatCode;
                else
                    specialistGroupListForMemberLocation[i].Vatcd=specialistGroupListForMemberLocation[i].ProductVatCode;                
            }
        }
    }

    //Populated billing information if called from person page
    function CheckIfCalledFromPersonPage(){
        if(window.parent.location.href.toLocaleLowerCase().indexOf("person")>-1){
            newMemberWizard.functions.getARNumbers();
        }
    }

    //Checks if Purchase order number is required
    function CheckPurchaseOrderNumberRequired(source, args) {
        args.IsValid = true;        
        if (newMemberWizard.controls.member.poRequired.val()=="1" && !(newMemberWizard.controls.member.poNumber.val())) {            
            args.IsValid = false;            
        }        
    }


</script>

<!-- 

    1. Create Membership with direct debit or with payment
    2. Go to:
       a. DataCash
       b. WorldPay
    
-->
