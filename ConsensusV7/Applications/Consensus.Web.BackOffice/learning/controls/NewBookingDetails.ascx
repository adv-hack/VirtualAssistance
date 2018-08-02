<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="NewBookingDetails.ascx.cs" Inherits="Consensus.Web.BackOffice.learning.controls.NewBookingDetails" %>
<%@ Register TagPrefix="con" TagName="Payment" Src="~/finance/controls/NewPayment.ascx" %>

<%@ Register TagPrefix="cc1" Namespace="Consensus.Web.Customisation" Assembly="Consensus.Web" %>
<con:Wizard runat="server" ID="Wizard">
  <con:WizardPage runat="server" ID="ContactDetailsPage" Title="Contact">
    <con:HiddenField runat="server" ID="BookerPersonId" DataBoundValue="BookerPersonId" />
    <con:HiddenField runat="server" ID="BookerAddressId" DataBoundValue="BookerAddressId" />
    <con:HiddenField runat="server" ID="InvoiceAddressId" DataBoundValue="InvoiceAddressId" />
    <con:HiddenField runat="server" ID="InvoiceOrgId" DataBoundValue="InvoiceOrgId" />
    <con:HiddenField runat="server" ID="OpportunityId" DataBoundValue="OpportunityId" />
    <con:HiddenField runat="server" ID="AccVatcode" DataBoundValue="Account.VatcdCode" />
    <con:HiddenField runat="server" ID="VATCalculation" />
    <con:HiddenField runat="server" ID="InvoicePersonId" />
    <div class="row">
      <div class="col-6">
        <con:GroupBox runat="server" Title="Booker details">
          <div class="row">
            <div class="col-12"><Con:PopupField runat="server" ID="Contact" DataBoundValue="BookerRoleId" DataBoundText="BookerRole.PersonName" LabelText="Booking contact" PopupUrl="~/crm/popups/personsearch.aspx" HyperlinkUrl="~/crm/personpage.aspx?role={id}" Requirement="MandatoryEnforced">
                <Filters>
                    <con:PopupFieldFilter ParameterName="org" Type="Control" Value="OrgName" />
                </Filters>
            </Con:PopupField>
            </div>
          </div>
          <div class="row">
            <div class="col-12"><Con:PopupField runat="server" ID="OrgName" DataBoundValue="BookerOrgId" DataBoundText="BookerOrg.Name" LabelText="Booking organisation" PopupUrl="~/crm/popups/organisationsearch.aspx" HyperlinkUrl="~/crm/organisationpage.aspx?id={id}" /></div>         
          </div>
          <div class="row">
            <div class="col-12">
                 <con:HiddenField runat="server" ID="AddressId" DataBoundValue="AddressId" />
                <con:TextField  runat="server" ID="BookingAddress" LabelText="Booking address" DataBoundValue="BookerAddress.Address.MailString" IsReadOnly="TrueEnforced" TextMode="MultiLine" CssClass="consensus-input noresize" >
                        <Addons>
                            <con:AddOn Icon="search" ToolTip="Select Alternate Address" CssClass="consensus-edit-visible" ID="AddressSearch" />
                        </Addons>
                </con:TextField>
                </div> 
          </div>
          <Con:PopupField runat="server" ID="SourceCode" DataBoundValue="SourceCodeId" DataBoundText="SourceCode.Name" LabelText="Source code" PopupUrl="~/marketing/popups/promotionsearch.aspx" HyperlinkUrl="~/marketing/sourcepage.aspx?id={id}" />
          <con:ListField runat="server" ID="SellCompName" DataBoundValue="SellingCompanyId" DataBoundText="SellingCompany.Name" LabelText="Selling company" DisplayMember="Name" ValueMember="Id" Requirement="MandatoryEnforced" ClientOnChange="SellingCompanyOnChange();" />

        </con:GroupBox>
      </div>
      <div class="col-6">
         <con:GroupBox runat="server" Title="Billing details">
            <div class="row">
                <div class="col-12">
                   <con:ListField runat="server" ID="Account" DataBoundValue="AccountId" LabelText="AR number" ValueMember="Id" DisplayMember="ARNumber"></con:ListField>
                   <con:ListField runat="server" ID="InvoiceContact" DataBoundValue="InvoiceRoleId" Requirement="MandatoryEnforced" LabelText="Invoice contact" ValueMember="Id" DisplayMember="InvoiceRole.PersonName"></con:ListField>
                   <con:TextField runat="server" ID="InvoiceOrganisation" DataBoundValue="InvoiceOrg.Name" LabelText="Invoice organisation" IsReadOnly="TrueEnforced" />
                </div>
            </div>
          <div class="row">
            <div class="col-12"><con:TextField  runat="server" ID="InvoiceAddress" LabelText="Invoice address" DataBoundValue="InvoiceAddress.Address.MailString" IsReadOnly="TrueEnforced" TextMode="MultiLine" CssClass="consensus-input noresize" /></div> 
          </div>

           <con:TextField runat="server" ID="PONumber" DataBoundValue="CustOrdNo" LabelText="Purchase order number">
               <Validators>
                 <con:Validator runat="server" ClientValidationFunction="CheckPurchaseOrderNumberRequired" Critical="true" ErrorMessage="This is a required field" />
               </Validators>
          </con:TextField>
          <con:HiddenField runat="server" ID="PORequired" />          
          <con:CheckField runat="server" ID="DoNotInvoice" DataBoundValue="DoNotInvoice" LabelText="Manual invoice" />
        </con:GroupBox>        
      </div>
    </div>
  </con:WizardPage>
  <con:WizardPage runat="server" ID="SelectEventPage" Title="Events">
    <div class="row">
      <div class="col-12">
        <con:GroupBox runat="server" Title="Events">
            <con:DataTable runat="server" ID="NewEventList" CanSearch="false" Mode="Stateful" CanModify="false" Url="~/learning/popups/eventsearch.aspx?search-buttons=1">
              <Columns>
                <con:DataTableTextColumn FieldName="data.COURSE_ID" visible ="false"/>
                <con:DataTableTextColumn FieldName="data.COURSE_DEF_ELEM_ST" visible ="false"/>
                <con:DataTableTextColumn FieldName="data.COURSE_OVERBOOK" visible ="false"/>
                <con:DataTableTextColumn Title="Name" FieldName="data.COURSE_NAME" />
                <con:DataTableTextColumn Title="Reference" FieldName="data.COURSE_REF" />
                <con:DataTableDateColumn Title="Start date" FieldName="data.COURSE_START_DATE" />
                <con:DataTableTextColumn Title="Start time" FieldName="data.EVENT_START_TIME" />
                <con:DataTableDateColumn Title="End date" FieldName="data.COURSE_END_DATE" />
                <con:DataTableTextColumn Title="End time" FieldName="data.EVENT_END_TIME" />
                <con:DataTableTextColumn Title="Location" FieldName="data.VENUE" />
                <con:DataTableCustomColumn Title="" Width="60px" CssClass="datatable-buttons consensus-visible-edit">
                      <!-- get the table id - trying to find from the DOM was causing errors, so find the value that's passed into the render function -->  
                      var dataTable = meta.settings.nTable.id;
                      return '<a onclick="' + dataTable + '.removeRow(this);" class="icons8-delete" title="Delete"></a>';
                </con:DataTableCustomColumn>
              </Columns>
            </con:DataTable>
        </con:GroupBox>
      </div>
    </div>
  </con:WizardPage>
  <con:WizardPage runat="server" ID="SelectProductPage" Title="Products">
    <div class="row">
      <div class="col-12">
        <con:GroupBox runat="server" Title="Products">
            <con:Validator runat="server" ClientValidationFunction="ValidateProductList" ErrorMessage="You must provide at least one event or product" />
            <con:DataTable runat="server" ID="NewProductList" CanSearch="false" Mode="Stateful" CanModify="false" Url="~/learning/popups/productsearch.aspx?syProduct=0,3,5,8,11,13,21&search-buttons=1">
              <Columns>
                <con:DataTableTextColumn FieldName="data.prod_id" visible ="false"/>
                <con:DataTableTextColumn FieldName="data.prod_sy_product" visible ="false"/>
                <con:DataTableTextColumn FieldName="data.prod_vat_code" visible ="false"/>
                <con:DataTableTextColumn FieldName="data.prod_def_elem_st" visible ="false"/>
                <con:DataTableTextColumn Title="Name" FieldName="data.prod_name" />
                <con:DataTableTextColumn Title="Reference" FieldName="data.prod_ref" />
                <con:DataTableTextColumn Title="Product type" FieldName="data.prod_sy_product_desc" />
                <con:DataTableTextColumn Title="Type" FieldName="data.prod_type" />
                <con:DataTableTextColumn Title="Category" FieldName="data.prod_category" />
                <con:DataTableTextColumn Title="Group" FieldName="data.prod_group" />
                <con:DataTableCustomColumn Title="" Width="60px" CssClass="datatable-buttons consensus-visible-edit">
                      <!-- get the table id - trying to find from the DOM was causing errors, so find the value that's passed into the render function -->  
                      var dataTable = meta.settings.nTable.id;
                      return '<a onclick="' + dataTable + '.removeRow(this);" class="icons8-delete" title="Delete"></a>';
                </con:DataTableCustomColumn>
              </Columns>
            </con:DataTable>
        </con:GroupBox>
      </div>
    </div>
  </con:WizardPage>
  <con:WizardPage runat="server" ID="SelectPeoplePage" Title="People">
    <div class="row">
      <div class="col-12">
        <con:GroupBox runat="server" Title="People">
            <con:Validator runat="server" ClientValidationFunction="ValidatePeopleList" ErrorMessage="You must provide at least one delegate" />
            <con:DataTable runat="server" ID="NewPeopleList" CanSearch="false" Mode="Stateful" CanModify="false" Url="~/crm/popups/personsearch.aspx?search-buttons=1">
              <Columns>
                <con:DataTableTextColumn FieldName="value" visible ="false"/>
                <con:DataTableTextColumn FieldName="data.pnId" visible ="false"/>
                <con:DataTableTextColumn FieldName="data.organisation.id" visible ="false"/>
                <con:DataTableTextColumn FieldName="data.address.id" visible ="false"/>
                <con:DataTableTextColumn Title="Name" FieldName="text" />
                <con:DataTableTextColumn Title="Email" FieldName="data.email" />
                <con:DataTableTextColumn Title="Organisation" FieldName="data.organisation.name" />
                <con:DataTableCustomColumn Title="" Width="60px" CssClass="datatable-buttons consensus-visible-edit">
                      <!-- get the table id - trying to find from the DOM was causing errors, so find the value that's passed into the render function -->  
                      var dataTable = meta.settings.nTable.id;
                      return '<a onclick="' + dataTable + '.removeRow(this);" class="icons8-delete" title="Delete"></a>';
                </con:DataTableCustomColumn>
              </Columns>
            </con:DataTable>
        </con:GroupBox>
      </div>
    </div>
  </con:WizardPage>
  <con:WizardPage runat="server" ID="SelectOptionsPage" Title="Options">
    <div class="row">
      <div class="col-12">
        <con:GroupBox runat="server" Title="Options">
            <con:Validator runat="server" ClientValidationFunction="ValidateOptionsList" ErrorMessage="You must select at least one item" />
            <con:Validator runat="server" ClientValidationFunction="ValidateDelegate" ErrorMessage="" />
            <con:DataTable runat="server" ID="NewOptionsList" CanSearch="false" Mode="Stateful" CanCreate="false" CanModify="false" Url="">
              <Columns>
                <con:DataTableTextColumn FieldName="proleId" visible ="false"/>
                <con:DataTableTextColumn FieldName="pnId" visible ="false"/>
                <con:DataTableTextColumn FieldName="orgId" visible ="false"/>
                <con:DataTableTextColumn FieldName="addId" visible ="false"/>
                <con:DataTableTextColumn FieldName="prod_sy_product" visible ="false"/>
                <con:DataTableTextColumn FieldName="courseId" visible ="false"/>
                <con:DataTableTextColumn FieldName="prodId" visible ="false"/>
                <con:DataTableTextColumn FieldName="actId" visible ="false"/>
                <con:DataTableTextColumn FieldName="elemmainsession" visible ="false"/>
                <con:DataTableTextColumn FieldName="elemtype" visible ="false"/>
                <con:DataTableTextColumn FieldName="status" visible ="false"/>
                <con:DataTableTextColumn FieldName="elem_st" visible ="false"/>
                <con:DataTableTextColumn FieldName="overbook" visible ="false"/>
                <con:DataTableTextColumn Title="Delegate name" FieldName="name" Orderable ="False"  />
                <con:DataTableTextColumn Title="Type" FieldName="prod_sy_product_desc" Orderable ="False" />
                <con:DataTableTextColumn Title="Item" FieldName="description" Orderable ="False" />
                <con:DataTableTextColumn Title="Status" FieldName="statustext" Orderable ="False" />
                <con:DataTableDateColumn Title="Start date" FieldName="START_DATE" Orderable ="False" />
                <con:DataTableTextColumn Title="Start time" FieldName="START_TIME" Orderable ="False" />
                <con:DataTableDateColumn Title="End date" FieldName="END_DATE" Orderable ="False" />
                <con:DataTableTextColumn Title="End time" FieldName="END_TIME" Orderable ="False" />
                <con:DataTableCheckColumn Title="Select" FieldName="SELECTED" Width="45px" Orderable ="False" />
              </Columns>
            </con:DataTable>
        </con:GroupBox>
      </div>
    </div>
  </con:WizardPage>
  <con:WizardPage runat="server" ID="SelectWarnings" Title="Warnings">
    <div class="row">
      <div class="col-12">
        <con:GroupBox runat="server" Title="Warnings">
            <con:DataTable runat="server" ID="WarningList" CanSearch="false" Mode="Stateful" CanCreate="false" CanModify="false" Url="">
              <Columns>
                <con:DataTableTextColumn FieldName="proleId" visible ="false"/>
                <con:DataTableTextColumn FieldName="courseId" visible ="false"/>
                <con:DataTableTextColumn FieldName="stop" visible ="false"/>
                <con:DataTableTextColumn FieldName="canoverbook" visible ="false"/>
                <con:DataTableTextColumn FieldName="canwait" visible ="false"/>
                <con:DataTableTextColumn Title="Warning" FieldName="warning" Orderable ="False"  />
                <con:DataTableCheckColumn Title="Don't book" FieldName="DONTBOOK" Width="45px" Orderable ="False" />
                <con:DataTableCheckColumn Title="Wait list" FieldName="WAIT" Width="45px" Orderable ="False" />
                <con:DataTableCheckColumn Title="Overbook" FieldName="OVERBOOK" Width="45px" Orderable ="False" />
              </Columns>
            </con:DataTable>
        </con:GroupBox>
      </div>
    </div>
  </con:WizardPage>
  <con:WizardPage runat="server" ID="BookingSummaryPage" Title="Summary">
    <div class="row">
      <div class="col-12">
        <con:GroupBox runat="server" Title="Pricing">
          <div class="col-3">
            <con:ListField runat="server" ID="PaymentMethod" LabelText="Payment Method" Requirement="MandatoryEnforced" ClientOnChange="CheckPayment()">
                <Items>
                    <asp:ListItem Text="Do not take payment" Value="NONE" />
                    <asp:ListItem Text="Take payment now" Value="PAY" />
                </Items>
            </con:ListField>
            </div>
            <con:Validator runat="server" ClientValidationFunction="ValidateNewSummaryList" ErrorMessage="There must be delegates to book to continue" />
            <con:Validator runat="server" ClientValidationFunction="ValidateNewSummaryListPrices" ErrorMessage="You cannot sell an item that has no price list" />
            <con:DataTable runat="server" ID="NewSummaryList" CanSearch="false" Mode="Stateful" CanCreate="false" CanModify="true" Url="~/genericPopup.aspx?context=learning&control=bookinglinedetails&CourseId={{Elements.CourseId}}&ActId={{Elements.ActivityId}}&ProdId={{Elements.ProductId}}&PrsId={{Elements.PriceIdId}}&sxrefId={{Elements.SessionXrefsId}}">
              <Columns>
                <con:DataTableTextColumn FieldName="DelegateAddressId" visible ="false"/>
                <con:DataTableTextColumn FieldName="DelegatePersonId" visible ="false"/>
                <con:DataTableTextColumn FieldName="DelegateRoleId" visible ="false"/>
                <con:DataTableTextColumn FieldName="DelegateOrgId" visible ="false"/>
                <con:DataTableTextColumn FieldName="Elements.SellingCompanyId" visible ="false"/>
                <con:DataTableTextColumn FieldName="Elements.ProductId" visible ="false"/>
                <con:DataTableTextColumn FieldName="Elements.MainSession" visible ="false" />
                <con:DataTableTextColumn FieldName="Elements.Type" visible ="false" />
                <con:DataTableTextColumn FieldName="Elements.PaymentMethodCode" visible ="false" />
                <con:DataTableTextColumn FieldName="Elements.Qty" visible ="false" />
                <con:DataTableTextColumn FieldName="Elements.PriceListId" visible ="false" />
                <con:DataTableTextColumn FieldName="Elements.PriceIdId" visible ="false" />
                <con:DataTableTextColumn FieldName="Elements.SessionXrefsId" visible ="false" />
                <con:DataTableTextColumn FieldName="Elements.CourseId" visible ="false" />
                <con:DataTableTextColumn FieldName="Elements.ActivityId" visible ="false" />
                <con:DataTableTextColumn FieldName="Elements.Status" visible ="false" />
                <con:DataTableTextColumn Title="Delegate" FieldName="BadgeName" Orderable ="False" />
                <con:DataTableTextColumn Title="Description" FieldName="Elements.Description" Orderable ="False" />
                <con:DataTableTextColumn Title="Amount" FieldName="Elements.UintPrice" Orderable ="False" />
                <con:DataTableTextColumn Title="Price list" FieldName="Elements.PriceList.Name" Orderable ="False" />
                <con:DataTableTextColumn Title="VAT code" FieldName="Elements.VatcdCode" Orderable ="False" />
              </Columns>
            </con:DataTable>
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
  <con:WizardPage runat="server" ID="ConfirmPage" Title="Complete">
  </con:WizardPage>
</con:Wizard>
<script>
  var newBookingDetails = {
    client: null,
    loader: 'One moment...',
    allContacts: null,
    controls: {
      booking: {
        sellingCompany: $('#<%= this.SellCompName.ClientID %>Field')
      },
      payment: {
        sellingCompany: $('#<%= this.Payment.SellingCompany.ClientID %>Field'),
        paymentType: $('#<%= this.Payment.PaymentType.ClientID %>Field'),
        currency: $('#<%= this.Payment.Currency.ClientID %>Field')
      }
    },
    functions: {
      togglePages: function () {
        newBookingDetails.pages.terminal.toggleClass('hidden', !payment.functions.useVirtualTerminal());
        newBookingDetails.pages.warnings.toggleClass('hidden', !newBookingDetails.functions.checkWarningsExist());
        newBookingDetails.pages.payment.toggleClass('hidden', !newBookingDetails.functions.checkTakingPayment());
        newBookingDetails.client._init(false);
      },
      getVATCalculation: function () {
        var sellingCompany = newBookingDetails.controls.booking.sellingCompany.val();

        consensus.network.send({
          method: 'post',
          async: false,
          url: 'common/sellingCompanyConfig/fetchAllBySellingCompanyIdKeyName',
          data: { 
              sellingCompanyId: sellingCompany, 
              keyName: "SC_VAT_METHOD",
              serialization: {
                  Include: {
                      "Common.SellingCompanyConfig": ["IntValue"]
                  }
              }
          },
          success: function (result) {
            for (var i = 0; i < result.length; i++)
              $('#<%= this.VATCalculation.ClientID %>Field').val(result[i].IntValue);
          }
        });
      },
      calculateVAT: function (price,rate,method) {
        var vatAmt = 0.0000;
        var tempVatAmt = 0.0000;

        var returnValue = 0.00
        //we only want to deal with +ve rate 
        if (rate > 0.0000) {
          // if the method is not in valid range, return 0.00
          if (method >=0 || method <=2) {
            tempVatAmt = price * rate / 100

            switch (method) {
              case "0": //rounds to nearest 0.1 pence
                vatAmt = newBookingDetails.functions.round(tempVatAmt, 3);
                break;
              case "2": //rounds to nearest 1 pence
                vatAmt = newBookingDetails.functions.round(tempVatAmt, 2);
                break;
              case "1": //rounds to nearest 0.5 pence
                var diff = 0.0000;
                var diffAmt = 0.0000;

                diff = tempVatAmt - (floor(tempVatAmt * 100) / 100);
                if (diff >= 0.0000 && diff < 0.0025) {
                  diffAmt = 0.0000;
                }
                if (diff >= 0.0025 && diff < 0.0075) {
                  diffAmt = 0.0050;
                }
                if (diff >= 0.0075 && diff < 0.0100) {
                  diffAmt = 0.0100;
                }

                vatAmt = (floor(tempVatAmt * 100) / 100) + diffAmt

                if (price > 0.0000 && rate > 0.0000 && vatAmt == 0.0000) {
                  vatAmt = 0.005 // must have a vat amount
                }
                break;
            }
          }
        }
        return vatAmt;
      },
      round: function(value, decimals)  {
        return Number(Math.round(value+'e'+decimals)+'e-'+decimals);
      },
      getARNumbers: function () {
        var accountField = $('#<%= this.Account.ClientID %>Field');
        var roleId = $('#<%= this.Contact.ClientID %>Value').val();
        var orgId = $('#<%= this.OrgName.ClientID %>Value').val();
        var sellingCompany = newBookingDetails.controls.booking.sellingCompany.val();

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
            // Create the new options
            for (var i = 0; i < result.length; i++)
              $('<option />').attr('value', result[i].Id).text(result[i].ARNumber + ' - ' + result[i].Title).appendTo(accountField);
          }
        });

        newBookingDetails.functions.getBillingContacts();
      },
      getBillingContacts: function () {
        var accountField = $('#<%= this.Account.ClientID %>Field');
        var invoiceContactField = $('#<%= this.InvoiceContact.ClientID %>Field');
        var accId = accountField.val();
        var proleId = $('#<%= this.Contact.ClientID %>Value').val();

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

            newBookingDetails.allContacts = result;

            for (var i = 0; i < result.length; i++) {
                if (result[i].Id3 != null) {
                    $('<option />').attr('value', result[i].Id3).text(result[i].Desc2).appendTo(invoiceContactField);
                    $('#<%= this.AccVatcode.ClientID %>Field').val(result[i].Desc4);
                }
            }                       
          }
        });
        newBookingDetails.functions.setInvoiceDetails();
      },
      setInvoiceDetails: function () {
        var invoiceContactField = $('#<%= this.InvoiceContact.ClientID %>Field');
        var contactDetails = [];
        contactDetails = newBookingDetails.allContacts;
        for (var i = 0; i < contactDetails.length; i++) {
          if (contactDetails[i].Id3 == invoiceContactField.val()) {
            $('#<%= this.InvoiceOrganisation.ClientID %>Field').val(contactDetails[i].Desc1);
            $('#<%= this.InvoiceOrgId.ClientID %>Field').val(contactDetails[i].Id2);
            <%=this.Payment.Organisation.ClientID%>.setValue(contactDetails[i].Id2, contactDetails[i].Desc1);
            <%=this.Payment.Person.ClientID%>.setValue(contactDetails[i].Id3, contactDetails[i].Desc2);
            $('#<%= this.InvoiceAddress.ClientID %>Field').val(contactDetails[i].Longdesc);
            $('#<%= this.InvoiceAddressId.ClientID %>Field').val(contactDetails[i].Id4);
            $('#<%= this.Payment.AddressId.ClientID %>Field').val(contactDetails[i].Id4);
            <%=this.Payment.Account.ClientID%>.setValue($('#<%= this.Account.ClientID %>Field').val(), contactDetails[i].Desc3);
            if (contactDetails[i].Int2 == "1") {
              $('#<%= this.PaymentMethod.ClientID %>Field').val("PAY");
              $('#<%= this.PaymentMethod.ClientID %>Field').attr('readonly','readonly').attr('disabled','disabled');
            }
            else {
              $('#<%= this.PaymentMethod.ClientID %>Field').val("NONE");
              $('#<%= this.PaymentMethod.ClientID %>Field').attr('readonly',null).attr('disabled',null);
            }
            $('#<%= this.PORequired.ClientID %>Field').val(contactDetails[i].Desc5);
            newBookingDetails.pages.payment.toggleClass('hidden', !newBookingDetails.functions.checkTakingPayment());
          }
        }
      },
      removeDuplicatePeople: function () {
        var newPeople = window['<%= this.NewPeopleList.ClientID %>'];
        var array = newPeople._getSourceData();
        var newArray = [];
        var counter = 0;

        for (i = 0; i < array.length; i++) {
          if ((jQuery.grep(newArray, function (element) { return element.value == array[i].value; })) == false) {
            newArray[counter] = array[i];
            counter +=1;
          }
        }
        newPeople._setSourceData(newArray);
        newPeople.reload();
      },
      removeDuplicateEvents: function () {
        var newEvents = window['<%= this.NewEventList.ClientID %>'];
        var array = newEvents._getSourceData();
        var newArray = [];
        var counter = 0;

        for (i = 0; i < array.length; i++) {
          if ((jQuery.grep(newArray, function (element) { return element.data.COURSE_ID == array[i].data.COURSE_ID; })) == false) {
            newArray[counter] = array[i];
            counter +=1;
          }
        }
        newEvents._setSourceData(newArray);
        newEvents.reload();
      },
      removeDuplicateProducts: function () {
        var newProducts = window['<%= this.NewProductList.ClientID %>'];
        var array = newProducts._getSourceData();
        var newArray = [];
        var counter = 0;

        for (i = 0; i < array.length; i++) {
          if ((jQuery.grep(newArray, function (element) { return element.data.prod_id == array[i].data.prod_id; })) == false) {
            newArray[counter] = array[i];
            counter +=1;
          }
        }
        newProducts._setSourceData(newArray);
        newProducts.reload();
      },
      getSessionPrices: function (course_id,qty) {
        var sessions = [];
        consensus.network.send({
          method: 'post',
          async: false,
          url: 'common/genericmodel/fetchAllByCourseIdPrices',
          data: { courseid: course_id,delcount: qty },
          success: function (result) {
            sessions = result;
          }
        });
        return sessions;
      },
      getProductPrices: function (prod_id, qty, prod_vat_code) {
        var sessions = [];
        consensus.network.send({
          method: 'post',
          async: false,
          url: 'common/genericmodel/fetchAllByProdIdPrices',
          data: { prodid: prod_id, qty:qty },
          success: function (result) {
            for (i = 0; i < result.length; i++) {
              result[i].Desc1 = prod_vat_code;
            }
            sessions = result;
          }
        });
        return sessions;
      },
      getSessions: function (course_id) {
        var sessions = [];
        consensus.network.send({
          method: 'post',
          async: false,
          url: 'common/genericmodel/fetchAllByCourseIdSessions',
          data: { courseid: course_id },
          success: function (result) {
            sessions = result;
          }
        });
        return sessions;
      },
      toggleWarnings : function (check, field) {
        var warnings = window['<%= this.WarningList.ClientID %>'];
        var array = $('#<%= this.WarningList.ClientID %>').DataTable().rows().data();
        var sourceData = warnings._getSourceData();
        var chk = $(check);
        var row = chk.parents('tr').first();
        var tbl = chk.parents('table').first();
        var obj = tbl.dataTable().api().row(row).data();
        var count = 0;

        for (i = 0; i < array.length; i++) { 
          sourceData[i] = array[i];
          if (obj == array[i]) {
            //always must be do not book, and can't be changed
            if (obj.stop == "1") {
              sourceData[i].DONTBOOK == "1"
              sourceData[i].WAIT == "0"
              sourceData[i].OVERBOOK == "0"
            }
            else  {
              switch (field) {
                case "DONTBOOK":
                  if (sourceData[i].DONTBOOK == "1")  {
                    sourceData[i].DONTBOOK = "0"
                    if (obj.canwait == "1") {
                      sourceData[i].WAIT = "1"
                    }
                  }
                  else {
                    sourceData[i].DONTBOOK = "1"
                    sourceData[i].WAIT = "0"
                  }
                  sourceData[i].OVERBOOK = "0"
                  break
                case "WAIT":
                  if (obj.canwait == "1" && sourceData[i].WAIT == "0") {
                    sourceData[i].DONTBOOK = "0"
                    sourceData[i].WAIT = "1"
                  }
                  else if (obj.canwait == "1" && sourceData[i].WAIT == "1") {
                    sourceData[i].DONTBOOK = "1"
                    sourceData[i].WAIT = "0"
                  }
                  sourceData[i].OVERBOOK = "0"
                  break
                case "OVERBOOK":
                  if (obj.canoverbook == "1" && obj.canwait == "1" && sourceData[i].OVERBOOK == "0") {
                    sourceData[i].DONTBOOK = "0"
                    sourceData[i].OVERBOOK = "1"
                  }
                  else if (obj.canoverbook == "1" && obj.canwait == "1" && sourceData[i].OVERBOOK == "1") {
                    sourceData[i].DONTBOOK = "1"
                    sourceData[i].OVERBOOK = "0"
                  }
                  else {
                    sourceData[i].DONTBOOK = "1"
                  }
                  sourceData[i].WAIT = "0"
                  break
              }
            }
          }
        }
        warnings._setSourceData(sourceData);
        warnings.reload();
      },
      toggleOptions : function (check, field) {
        var newOptions = window['<%= this.NewOptionsList.ClientID %>'];
        var array = $('#<%= this.NewOptionsList.ClientID %>').DataTable().rows().data();
        var sourceData = newOptions._getSourceData();
        var chk = $(check);
        var row = chk.parents('tr').first();
        var tbl = chk.parents('table').first();
        var obj = tbl.dataTable().api().row(row).data();
        var count = 0;
        var page = tbl.dataTable().api().page();
        var table = $('#<%= this.NewOptionsList.ClientID %>').DataTable();
        sourceData.length =  0;

        if (obj.prod_sy_product_desc == "Event") {
          for (i = 0; i < array.length; i++) {   
            //we need to keep track of which tick box we are dealing with, to untick later
            if (obj == array[i]) {
              count = i;
            }
            else {
              // is this one of the sessions for the event 
              if (obj.courseId == array[i].courseId && obj.proleId == array[i].proleId && array[i].prod_sy_product_desc != "Event") {
                //untick it as we are not wanting it now
                if (obj.SELECTED == "1" && array[i].SELECTED == "1") {
                  array[i].SELECTED = "0"
                }
                //if it is not optional, tick it
                if (obj.SELECTED == "0" &&  array[i].SELECTED == "0" &&  array[i].status != 0) {
                  array[i].SELECTED = "1";   
                }
              }
            }
            sourceData[i] = array[i];
          }
        }
        else {
          for (i = 0; i < array.length; i++) { 
            //we need to keep track of which tick box we are dealing with, to untick later
            if (obj == array[i]) {
              count = i;
            }
            else {
              //dealing with events, so need to tidy up
              if (obj.courseId !="") {
                //we are ticking
                if (obj.SELECTED == "0") {
                  if (obj.courseId == array[i].courseId && obj.proleId == array[i].proleId && (array[i].status == 1 || array[i].prod_sy_product_desc == "Event")) {
                    array[i].SELECTED = "1"
                  }
                } //unticking and it is mandatory untick everythinng for that event
                else if (obj.status == 1 && obj.courseId == array[i].courseId && obj.proleId == array[i].proleId) {
                  //untick all for that event
                  array[i].SELECTED = "0"
                }
              }
            }
            sourceData[i] = array[i];
          }
        }

        if (obj.SELECTED == "0") {
          sourceData[count].SELECTED = "1";
        }
        else {
          sourceData[count].SELECTED = "0";
        }

        //consensus.data.setValue(obj, field, chk.is(':checked'));
        newOptions._setSourceData(sourceData);
        newOptions.reload();
        table.page(page).draw(false);
      },
      dataTabletoggle : function (check, field) {
        if (field == "SELECTED") {
          newBookingDetails.functions.toggleOptions(check,field);
        }
        else {
          newBookingDetails.functions.toggleWarnings(check,field);
        }       
      },

      buildOptionsList: function(table,arrPeople,arrEvents,arrSessions,arrProducts) {
        var selected = 0;

        for (i = 0; i < arrPeople.length; i++) {
          for (j = 0; j < arrEvents.length; j++) {
            table.row.add({
              "proleId": arrPeople[i].value,
              "pnId": arrPeople[i].data.pnId,
              "orgId": arrPeople[i].data.organisation.id,
              "addId": arrPeople[i].data.address.id,
              "prod_sy_product": "1",
              "courseId": arrEvents[j].data.COURSE_ID,
              "prodId": "",
              "actId": "",
              "elemmainsession": "0",
              "elemtype": "0",
              "status": "",
              "elem_st": "",
              "overbook": "",
              "name": arrPeople[i].text,
              "prod_sy_product_desc": "Event",
              "description": arrEvents[j].data.COURSE_NAME,
              "statustext": "",
              "START_DATE": arrEvents[j].data.COURSE_START_DATE,
              "START_TIME": arrEvents[j].data.EVENT_START_TIME,
              "END_DATE": arrEvents[j].data.COURSE_END_DATE,
              "END_TIME": arrEvents[j].data.EVENT_END_TIME,
              "SELECTED":1
            }).draw();
            for (k = 0; k < arrSessions.length; k++) {
              if (arrEvents[j].data.COURSE_ID == arrSessions[k].Id2) {
                selected = 1;
                if (arrSessions[k].Int2 == 0) {
                  selected = 0;
                }
                table.row.add({
                  "proleId": arrPeople[i].value,
                  "pnId": arrPeople[i].data.pnId,
                  "orgId": arrPeople[i].data.organisation.id,
                  "addId": arrPeople[i].data.address.id,
                  "prod_sy_product": "1",
                  "courseId": arrEvents[j].data.COURSE_ID,
                  "prodId": arrSessions[k].Id1,
                  "actId": arrSessions[k].Id,
                  "elemmainsession": arrSessions[k].Int1,
                  "elemtype": arrSessions[k].Int3,
                  "status": arrSessions[k].Int2,
                  "elem_st": arrEvents[j].data.COURSE_DEF_ELEM_ST,
                  "overbook": arrEvents[j].data.COURSE_OVERBOOK,
                  "name": "",
                  "prod_sy_product_desc": arrSessions[k].Desc4,
                  "description": arrSessions[k].Desc1,
                  "statustext": arrSessions[k].Desc5,
                  "START_DATE": arrSessions[k].Date1,
                  "START_TIME": arrSessions[k].Desc2,
                  "END_DATE": arrSessions[k].Date2,
                  "END_TIME": arrSessions[k].Desc3,
                  "SELECTED": selected
                }).draw();
              }
            }
          }
          for (j = 0; j < arrProducts.length; j++) {
            table.row.add({
              "proleId": arrPeople[i].value,
              "pnId": arrPeople[i].data.pnId,
              "orgId": arrPeople[i].data.organisation.id,
              "addId": arrPeople[i].data.address.id,
              "prod_sy_product": arrProducts[j].data.prod_sy_product,
              "courseId": "",
              "prodId": arrProducts[j].data.prod_id,
              "actId": "",
              "elemmainsession": "1",
              "elemtype": "",
              "status": "1",
              "elem_st": arrProducts[j].data.prod_def_elem_st,
              "overbook": "",
              "name": arrPeople[i].text,
              "prod_sy_product_desc": arrProducts[j].data.prod_sy_product_desc,
              "description": arrProducts[j].data.prod_name,
              "statustext": "Mandatory",
              "START_DATE": "",
              "START_TIME": "",
              "END_DATE": "",
              "END_TIME": "",
              "SELECTED":1
            }).draw();
          }
        }
      },
      buildPricingList: function(tableSummary,arrOptions,arrProductPrices,arrEventPrices) {
        var prodId = "";
        var price = 0.00;
        var vatCD = "";
        var sxrefId = "";
        var prsId = "";
        var plId = "";
        var priceListName = "";
        var status = "";
        var elemType = 0;
        var warnings = window['<%= this.WarningList.ClientID %>'];
        var arrWarnings = $('#<%= this.WarningList.ClientID %>').DataTable().rows().data();
        var name = "";

        for (i = 0; i < arrOptions.length; i++) {
          prodId = arrOptions[i].prodId
          if (arrOptions[i].prod_sy_product_desc != "Session" && arrOptions[i].elemmainsession == "1") {
            name = arrOptions[i].name;
          }
          else if (arrOptions[i].prod_sy_product_desc == "Event") {
            name = arrOptions[i].name;
          }
          var getprice = 1;
          //we only want to display the selected items that we want to book
          if (arrOptions[i].SELECTED == "1" && arrOptions[i].prod_sy_product_desc != "Event") {
            status = arrOptions[i].elem_st
            if (arrOptions[i].courseId == "") {
              var arrPrice = jQuery.grep(arrProductPrices, function (element) {
                return (element.Id2 == arrOptions[i].prodId);
              });
              var currentPrice = 0.00;
              price = 0.00;
              vatCD = "";
              prsId = "";
              plId = "";
              sxrefId = "";
              priceListName = "";
              
              for (j = 0; j < arrPrice.length; j++) {
                if (j == 0) {
                  price = arrPrice[j].Money1;
                  vatCD = arrPrice[j].Desc1;
                  prsId = arrPrice[j].Id;
                  plId = arrPrice[j].Id1;
                  priceListName = arrPrice[j].Desc2;
                }
                if (arrPrice[j].Money1 < currentPrice) {
                  price = arrPrice[j].Money1;
                  vatCD = arrPrice[j].Desc1;
                  prsId = arrPrice[j].Id;
                  plId = arrPrice[j].Id1;
                  priceListName = arrPrice[j].Desc2;
                }
                currentPrice = arrPrice[j].Money1;
                elemType = arrPrice[j].Int3;
              }
            }
            else {
              var arrDontBook = jQuery.grep(arrWarnings, function (element) {
                return (element.courseId == arrOptions[i].courseId && element.proleId == arrOptions[i].proleId);
              });
              if (arrDontBook.length > 0) {
                if (arrDontBook[0].DONTBOOK == "1") {
                  getprice = 0;
                }
                if (arrDontBook[0].WAIT == "1") {
                  status = "10"
                }
              }
              if (getprice == "1") {
                //we are wanting to find the prices for our session or product
                var arrPrice = jQuery.grep(arrEventPrices, function (element) {
                  if (arrOptions[i].actId == "") {
                    return (element.Id2 == arrOptions[i].prodId && element.Id5 == arrOptions[i].courseId);
                  }
                  else {
                    return (element.Id4 == arrOptions[i].actId);
                  }
                });
                var currentPrice = 0.00;
                price = 0.00;
                vatCD = "";
                prsId = "";
                plId = "";
                sxrefId = "";
                priceListName = "";
                elemType = arrOptions[i].elemtype;
                //get the cheapest price that was returned. This needs to take in to account if they are a member in the future
                for (j = 0; j < arrPrice.length; j++) {
                  if (j == 0) {
                    price = arrPrice[j].Money1;
                    vatCD = arrPrice[j].Desc1;
                    prsId = arrPrice[j].Id;
                    plId = arrPrice[j].Id1;
                    sxrefId = arrPrice[j].Id3;
                    priceListName = arrPrice[j].Desc2;
                  }
                  if (arrPrice[j].Money1 < currentPrice) {
                    price = arrPrice[j].Money1;
                    vatCD = arrPrice[j].Desc1;
                    prsId = arrPrice[j].Id;
                    plId = arrPrice[j].Id1;
                    sxrefId = arrPrice[j].Id3;
                    priceListName = arrPrice[j].Desc2;
                  }
                  currentPrice = arrPrice[j].Money1;
                }
              }
            }
            if (getprice == "1") {
              //use the account override VAT code
              if ($('#<%= this.AccVatcode.ClientID %>Field').val().length > 0) {
                vatCD = $('#<%= this.AccVatcode.ClientID %>Field').val();
              }
              if (status == "") {
                status = "0";
              }
              tableSummary.row.add({
                "_guid": consensus.data.guid(),
                "DelegateAddressId": arrOptions[i].addId,
                "DelegatePersonId": arrOptions[i].pnId,
                "DelegateRoleId": arrOptions[i].proleId,
                "DelegateOrgId": arrOptions[i].orgId,
                "BadgeName": name,
                "Elements": {
                  "SellingCompanyId": $('#<%= this.SellCompName.ClientID %>Field').val(),
                  "ProductId": prodId,
                  "MainSession": arrOptions[i].elemmainsession,
                  "Type": elemType,
                  "PaymentMethodCode": "01-Invoice",
                  "Qty": "1",
                  "PriceListId": plId,
                  "PriceIdId": prsId,
                  "SessionXrefsId": sxrefId,
                  "CourseId": arrOptions[i].courseId,
                  "ActivityId": arrOptions[i].actId,
                  "Status": status,
                  "Description": arrOptions[i].description,
                  "UintPrice": price,
                  "PriceList": { "Name": priceListName },
                  "VatcdCode": vatCD
                }                   
              }).draw();
            }
          }
          if (arrOptions[i].prod_sy_product_desc != "Event") {
            name = "";
          }
        }
        newBookingDetails.functions.setDatasourcePrices();
      },
      setDatasourcePrices: function() {
        var newSummary = window['<%= this.NewSummaryList.ClientID %>'];
        var table = $('#<%= this.NewSummaryList.ClientID %>').DataTable();
        var sourceData = newSummary._getSourceData();
        var array = table.rows().data();

        for (i = 0; i < array.length; i++) {
          sourceData[i] = array[i];
        }
        newSummary._setSourceData(array);
        newSummary.reload();
      },
      getDelegates: function() {
        var table = $('#<%= this.NewSummaryList.ClientID %>').DataTable();
        var arrPricing = table.rows().data();
        var currentProleId = "";
        var arrDelegate = [];
        var arrElements = [];
        var counter = 0;
        var elemCounter = 0;
        //get the delegates and elements in the correct format to insert the data
        for (i = 0; i < arrPricing.length; i++) {
          if (currentProleId != arrPricing[i].DelegateRoleId) {
            arrDelegate[counter] = arrPricing[i]
              
            if (i>0){
              arrDelegate[counter-1].Elements = arrElements;
              arrElements = [];
              elemCounter = 0
            }
            counter+=1;
          }
          arrElements[elemCounter] = arrPricing[i].Elements;
          currentProleId = arrPricing[i].DelegateRoleId
          elemCounter+=1;
        }
        if (arrElements.length > 0) {
          arrDelegate[counter-1].Elements = arrElements;
        }
        return arrDelegate;
      },
      validateDelegates: function() {
        var newOptions = window['<%= this.NewOptionsList.ClientID %>'];
        var array = $('#<%= this.NewOptionsList.ClientID %>').DataTable().rows().data();
        var table = $('#<%= this.WarningList.ClientID %>').DataTable();
        var sourceData = array;
        var quantity = 1;
        var stop = 0;
        var canwait  = 0;
        var dontbook = 0;
        table.clear();

        for (i = 0; i < sourceData.length; i++) {
          //is this an event and the main session (as only need to check for the main session
          if (sourceData[i].courseId.length>0 && sourceData[i].elemmainsession == "1" && sourceData[i].SELECTED == "1") {
            quantity = jQuery.grep(sourceData, function (element) { return (element.courseId == sourceData[i].courseId && element.elemmainsession == "1" && element.SELECTED == "1"); });

            consensus.network.send({
              method: 'post',
              async: false,
              url: 'common/genericmodel/validateDelegate',
              data: { 
                  courseid: sourceData[i].courseId, 
                  proleid: sourceData[i].proleId, 
                  qualid:"",
                  ignorefreeplaces:0, 
                  delquantity: quantity.length, 
                  serialization: {
                      Include: {
                          "Common.GenericModel": ["Int1", "Desc1", "Longdesc"]
                      }
                  }
              },
              success: function (result) {
                if (result[0].Int1 > 0) {
                  switch (result[0].Int1) {
                    case 1: //warning
                      stop =  0;
                      canwait = 0;  
                      dontbook = 0;
                      break
                    case 2: //stop
                      if (result[0].Desc1 == "-1032") {
                        stop = 0;
                        canwait = 1;
                        dontbook = 1;
                      }
                      else {
                        canwait = 0;
                        stop = 1;
                        dontbook = 1;
                      }                     
                      break;
                  }
                  table.row.add({
                    "proleId": sourceData[i].proleId,
                    "courseId": sourceData[i].courseId,
                    "stop":stop,
                    "canoverbook":sourceData[i].overbook,
                    "canwait": canwait,
                    "warning": result[0].Longdesc,
                    "DONTBOOK":dontbook,
                    "WAIT":0,
                    "OVERBOOK":0
                  }).draw();                         
                }
              }
            });
          }
        }
        newBookingDetails.pages.warnings.toggleClass('hidden', !newBookingDetails.functions.checkWarningsExist());
      },
      checkWarningsExist: function () {
        if (window['<%= this.WarningList.ClientID %>'] != null) {
          var array = $('#<%= this.WarningList.ClientID %>').DataTable().rows().data();
          if (array.length > 0) {
            return true;
          }
        }
        return false;
      },
      checkTakingPayment: function () {
        if ($('#<%= this.PaymentMethod.ClientID %>Field').val() == "PAY") {
          var summaryTable = $('#<%= this.NewSummaryList.ClientID %>').DataTable();
          var arrPrices = summaryTable.rows().data();
          var amount = 0.00;
          for (i = 0; i < arrPrices.length; i++) {
            var netamount = Number(arrPrices[i].Elements.UintPrice)
            if (arrPrices[i].Elements.Status != "10") {
              amount += netamount;
            }
          }
          if (amount > 0) {
            return true;
          }
          else {
            return false;
          }
        }
        return false;
      },
      onNext: function (sourcePage, targetPage) {
        switch (targetPage) {
          case 2:
            newBookingDetails.functions.removeDuplicateEvents();
            break;
          case 3: //
            newBookingDetails.functions.removeDuplicateProducts();
            break;
          case 4: //building the options list ready to display
            newBookingDetails.functions.removeDuplicatePeople();
            var arrPeople = window['<%= this.NewPeopleList.ClientID %>']._getSourceData();
            var arrProducts = window['<%= this.NewProductList.ClientID %>']._getSourceData();
            var arrEvents = window['<%= this.NewEventList.ClientID %>']._getSourceData();
            var arrSessions = [];
            var Sessions = [];
            var table = $('#<%= this.NewOptionsList.ClientID %>').DataTable();
            
            for (i = 0; i < arrEvents.length; i++) {
              Sessions = newBookingDetails.functions.getSessions(arrEvents[i].data.COURSE_ID);
              arrSessions = arrSessions.concat(Sessions);
            }



            table.clear();
            newBookingDetails.functions.buildOptionsList(table,arrPeople,arrEvents,arrSessions,arrProducts);

            break;
          case 5: 

            break
          case 6: //building the pricing list ready to display from the selected items             
            var optionTable = $('#<%= this.NewOptionsList.ClientID %>').DataTable();
            var arrOptions = optionTable.rows().data();
            var tableSummary = $('#<%= this.NewSummaryList.ClientID %>').DataTable();
            var arrProducts = window['<%= this.NewProductList.ClientID %>']._getSourceData();
            var arrEvents = window['<%= this.NewEventList.ClientID %>']._getSourceData();
            var arrEventPrices = [];
            var arrProductPrices = [];
            var prices = [];
            var qty = 1;

            for (i = 0; i < arrEvents.length; i++) {
              prices = newBookingDetails.functions.getSessionPrices(arrEvents[i].data.COURSE_ID, qty);
              arrEventPrices = arrEventPrices.concat(prices);
            }
            prices = [];
            for (j = 0; j < arrProducts.length; j++) {
              prices = newBookingDetails.functions.getProductPrices(arrProducts[j].data.prod_id, qty, arrProducts[j].data.prod_vat_code);
              arrProductPrices = arrProductPrices.concat(prices);
            }
            tableSummary.clear();
            newBookingDetails.functions.buildPricingList(tableSummary,arrOptions,arrProductPrices,arrEventPrices);

            break;
          case 7: //calculate price ready to take payment
            var amount = 0.00;
            var summaryTable = $('#<%= this.NewSummaryList.ClientID %>').DataTable();
            var arrPrices = summaryTable.rows().data();
            var arrVatCodes;
            
            consensus.network.send({
              method: 'post',
              async: false,
              url: 'common/code/fetchAllByType',
              data: { codeType: "VATCD" },
              success: function (result) {
                arrVatCodes = result;
              }
            });

            for (i = 0; i < arrPrices.length; i++) {
              var vatrate = jQuery.grep(arrVatCodes, function (code) { return (code.Value1 == arrPrices[i].Elements.VatcdCode); });
              var netamount = Number(arrPrices[i].Elements.UintPrice) * Number(arrPrices[i].Elements.Qty);
              if (vatrate.length > 0) {
                var vatamount = newBookingDetails.functions.calculateVAT(netamount,vatrate[0].Value3,$('#<%= this.VATCalculation.ClientID %>Field').val());
              }
              else {
                var vatamount = newBookingDetails.functions.calculateVAT(netamount,20,$('#<%= this.VATCalculation.ClientID %>Field').val());
              }
              var total = netamount + vatamount;
              if (arrPrices[i].Elements.Status != "10") {
                amount += total;
              }

            }

            $('#<%= this.Payment.PaymentAmount.ClientID %>Field').val(amount.toFixed(2));
            $('#<%= this.Payment.Currency.ClientID %>Field').val('GBP');

            var currency = newBookingDetails.controls.payment.currency.find('option[value="' + newBookingDetails.controls.payment.currency.val() + '"]');
            var conversion = parseFloat(currency.attr('data-conversion'));
            conversion = isNaN(conversion) ? 1 : conversion;
            amount = isNaN(amount) ? 0 : (amount * conversion);
            $('#<%= this.Payment.Conversion.ClientID %>Field').val(conversion.toFixed(2));
            $('#<%= this.Payment.PaymentBC.ClientID %>Field').val(amount.toFixed(2));

            break;
          case 8:
            newBookingDetails.client.showProgress('Connecting to payment gateway', 'info');
            setTimeout(function () {
              newBookingDetails.client.showProgress('Payment gateway not supported', 'error', false);
            }, 1000);

            break;
          case 9:
            newBookingDetails.client.showProgress('Creating booking', 'info');
            var table = $('#<%= this.NewSummaryList.ClientID %>').DataTable();
            var state = new consensus.data.state(null, {}, $('#' + newBookingDetails.pages.booking.attr('data-page')));
            state.updateObject();
            var booking = state.object;
            var updatedBooking = "";
            //gets the delegate and element json so we can create the booking
            booking.Learners = newBookingDetails.functions.getDelegates();
            if ($('#<%= this.PaymentMethod.ClientID %>Field').val() == "PAY" && $('#<%= this.Payment.PaymentBC.ClientID %>Field').val() > 0) {
              var state = new consensus.data.state(null, {}, $('#' + newBookingDetails.pages.payment.attr('data-page')));
              state.updateObject();
              booking.payments = [state.object];
            }
            consensus.network.send({
              method: 'put',
              url: 'learning/booking',
              async: false,
              data: booking,
              success: function (result) {
                newBookingDetails.client.showProgress('Booking created successfully', 'success', true);
                bookId = result.Id;
                //needt to set the grpid now the booking exists
                consensus.network.send({
                  method: 'post',
                  async: false,
                  url: 'learning/booking/BookingGenerateGrpId',
                  data: { bookId: bookId } //,
                  //success: function (result) {
                  //}
                });
              },
              error: function (request) {
                newBookingDetails.client.showProgress('Could not create booking<br/>' + request.statusText, 'error', true);
              }
            })
            //need to add this to clear the summary table as there is an error at the end for no reason what so ever about the description even though we are not doing anything with the table 
            table.clear();
            break;
        }
        return true;
      },
      onFinish: function () {
        if (bookId && bookId.length != 0) {
          window.top.window.location.href = consensus.resolveUrl('~/learning/booking?id=' + bookId);
        }
        return true;
      }
    },
    pages: {
      booking: $('[data-page="<%= this.ContactDetailsPage.ClientID %>"]'),
      events: $('[data-page="<%= this.SelectEventPage.ClientID %>"]'),
      products: $('[data-page="<%= this.SelectProductPage.ClientID %>"]'),
      delegates: $('[data-page="<%= this.SelectPeoplePage.ClientID %>"]'),
      options: $('[data-page="<%= this.SelectOptionsPage.ClientID %>"]'),
      warnings: $('[data-page="<%= this.SelectWarnings.ClientID %>"]'),
      bookinglines: $('[data-page="<%= this.BookingSummaryPage.ClientID %>"]'),
      payment: $('[data-page="<%= this.PaymentPage.ClientID %>"]'),
      terminal: $('[data-page="<%= this.TerminalPage.ClientID %>"]'),
      confirm: $('[data-page="<%= this.ConfirmPage.ClientID %>"]')
    }
  };

  $(document).ready(function () {
    newBookingDetails.client = window['<%= this.Wizard.ClientID %>'];
    newBookingDetails.client.onNext = newBookingDetails.functions.onNext;
    newBookingDetails.client.onFinish = newBookingDetails.functions.onFinish;
    newBookingDetails.functions.togglePages();
    if ($('#<%= this.Contact.ClientID %>Value').val().length > 0) {
      newBookingDetails.functions.getARNumbers();
    }
    
    //newBookingDetails.functions.setInvoiceDetails();
    window.consensus.web.dataTable.toggle  = newBookingDetails.functions.dataTabletoggle;
    //newBookingDetails.functions.setGridUrl();
    payment.functions.onLoadConfiguration = newBookingDetails.functions.togglePages;

    $('[id$=_PopupFooterPanel]').show(); // to show the customise button from the footer that gets hided.
    $('[id$=_PopupFooterPanel]').find('#Content_CustomiseButton').addClass('Content_CustomiseButton')
    $('[id$=_PopupFooterPanel]').find('#Content_PopupFooter_SaveButton').css('display', 'none')
    $('[id$=_PopupFooterPanel]').find('#Content_PopupFooter_UndoButton').css('display', 'none')

  });

    function SellingCompanyOnChange()
    {
        newBookingDetails.functions.getARNumbers();
    }

  function ValidatePeopleList(source, arguments) {
    arguments.IsValid = window['<%= this.NewPeopleList.ClientID %>']._getSourceData().length > 0;
  };

  function ValidateProductList(source, arguments) {
    var listlength = 0;

    listlength = window['<%= this.NewProductList.ClientID %>']._getSourceData().length > 0;
    listlength += window['<%= this.NewEventList.ClientID %>']._getSourceData().length > 0;
    arguments.IsValid = listlength;
  };

  function ValidateOptionsList(source, arguments) {
    
    var optionsTable = $('#<%= this.NewOptionsList.ClientID %>').DataTable();
    var arrOptions = optionsTable.rows().data();
    var selected = 0;
    var counter = 0;
    for (i = 0; i < arrOptions.length; i++) {
      if (arrOptions[i].SELECTED == "1") {
        selected = 1;
        counter = arrOptions.length;
      }
      else {
        counter++;
      }
    }
    arguments.IsValid = selected;
  };

  function ValidateDelegate(source, arguments) {
    newBookingDetails.functions.validateDelegates();
  };

  function ValidateNewSummaryList(source, arguments) {
    var summaryTable = $('#<%= this.NewSummaryList.ClientID %>').DataTable();
    var arrPrices = summaryTable.rows().data();
    CheckPayment();
    arguments.IsValid = arrPrices.length;
  };

  function ValidateNewSummaryListPrices(source, arguments) {
    var summaryTable = $('#<%= this.NewSummaryList.ClientID %>').DataTable();
    var arrPrices = summaryTable.rows().data();
    var counter = 0;
    for (i = 0; i < arrPrices.length; i++) {
      if (arrPrices[i].Elements.PriceListId == "") {
        counter++;
      }
    }
    if (counter > 0) {
      arguments.IsValid = false;
    }
    else {
      arguments.IsValid = true;
    }
    
  };

  function CheckPayment() {
    newBookingDetails.pages.payment.toggleClass('hidden', !newBookingDetails.functions.checkTakingPayment());
  }

  //Checks if Purchase order number is required
  function CheckPurchaseOrderNumberRequired(source, args) {
      args.IsValid = true;
      if ($('#<%= this.PORequired.ClientID %>Field').val()=="1" && !($('#<%= this.PONumber.ClientID %>Field').val())) {            
          args.IsValid = false;            
      }
  }

   addressField = function () {
        var closure = this;
        this.opening = false;
        this._addressId = $('#' + '<%=this.AddressId.ClientID%>' + 'Field');
        this._orgId = $('#' + '<%=this.OrgName.ClientID%>' + 'Value');
        this._addmailstring = $('#' + '<%=this.BookingAddress.ClientID%>' + ' textarea');
        this._updateIcon = function (icon) {
            closure._addmailstring.next('.input-group-addon').find('.glyphicon')
              .removeClass(function (index, className) {
                  return (className.match(/(^|\s)glyphicon-\S+/g) || []).join(' ');
              }).addClass(icon);
        };
        this.setAddress = function (addId, addmailstring) {
            this._addmailstring.val(addmailstring).attr('readonly', 'readonly');
            this._addressId.val(addId);
        };
        this.openPopup = function () {
            if (closure._orgId.val()) {
                closure._opening = true;
                closure._updateIcon('glyphicon-repeat glyphicon-spin');
                consensus.web.popupFrame({
                    url: consensus.resolveUrl('~/genericpopup.aspx?context=crm&control=addresslist&type=altbutton&width=1200&select=1&orgId=' + closure._orgId.val()),
                    open: function () {
                        closure._updateIcon('glyphicon-search');
                        closure._opening = false;
                    },
                    result: function (result) {
                        closure.setAddress(result.data.id, result.data.mailstring);
                    }
                });
            }
            else {                
                window.top.swal.call(window.top,{ title: 'Warning', text: 'You have not selected an organisation.', type: 'warning', showCancelButton: false, confirmButtonText: 'Ok', confirmButtonClass: 'btn btn-danger', buttonsStyling: false }).then(function (success) {
                });
            }
        };
        this._addmailstring.next('.input-group-addon').on('click', function () {
            if (!closure._opening)
                closure.openPopup();
        });
    };

</script>
