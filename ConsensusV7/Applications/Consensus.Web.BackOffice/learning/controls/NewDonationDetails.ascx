<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="NewDonationDetails.ascx.cs" Inherits="Consensus.Web.BackOffice.learning.controls.NewDonationDetails" %>
<%@ Register TagPrefix="con" TagName="Payment" Src="~/finance/controls/NewPayment.ascx" %>

<con:Wizard runat="server" ID="Wizard">
  <con:WizardPage runat="server" ID="DonationPage" Title="Contact Details">
        <con:HiddenField runat="server" ID="BookerAddressId" DataBoundValue="BookerAddressId" />
        <con:HiddenField runat="server" ID="InvoiceAddressId" DataBoundValue="InvoiceAddressId" />
        <con:HiddenField runat="server" ID="OpportunityId" DataBoundValue="OpportunityId" />
        <con:HiddenField runat="server" ID="InvoicePersonId" />
    <div class="row">
      <div class="col-6">
        <con:GroupBox runat="server" Title="Contact Details">
          <div class="row">
            <div class="col-12"><Con:PopupField runat="server" ID="Contact" DataBoundValue="BookerRoleId" DataBoundText="BookerRole.PersonName" LabelText="Contact" PopupUrl="~/crm/popups/personsearch.aspx" HyperlinkUrl="~/crm/personpage.aspx?role={id}" Requirement="MandatoryEnforced">
                <Filters>
                    <con:PopupFieldFilter ParameterName="org" Type="Control" Value="OrgName" />
                </Filters>
            </Con:PopupField>
            </div>
          </div>
          <div class="row">
            <div class="col-12"><Con:PopupField runat="server" ID="OrgName" DataBoundValue="BookerOrgId" DataBoundText="BookerOrg.Name" LabelText="Organisation" PopupUrl="~/crm/popups/organisationsearch.aspx" HyperlinkUrl="~/crm/organisationpage.aspx?id={id}" /></div>         
          </div>
        </con:GroupBox>
        <con:GroupBox runat="server" Title="Donor Details">
          <div class="row">
            <div class="col-12"><Con:PopupField runat="server" ID="InvoiceContact" DataBoundValue="InvoiceRoleId" DataBoundText="InvoiceRoleId.PersonName" LabelText="Name" PopupUrl="~/crm/popups/personsearch.aspx" HyperlinkUrl="~/crm/personpage.aspx?role={id}" Requirement="MandatoryEnforced">
                <Filters>
                    <con:PopupFieldFilter ParameterName="org" Type="Control" Value="InvOrgName" />
                </Filters>
            </Con:PopupField>
            </div>
          </div>
          <div class="row">
            <div class="col-12"><Con:PopupField runat="server" ID="InvOrgName" DataBoundValue="InvoiceOrgId" DataBoundText="InvoiceOrg.Name" LabelText="Organisation" PopupUrl="~/crm/popups/organisationsearch.aspx" HyperlinkUrl="~/crm/organisationpage.aspx?id={id}" /></div>
          </div>
        </con:GroupBox>
      </div>
      <div class="col-6">
         <con:GroupBox runat="server" Title="Donation Details">
          <div class="row">
            <div class="col-12"><con:TextField runat="server" ID="ForAttentionOf" DataBoundValue="ForAttentionOf" LabelText="On behalf of"/></div>
          </div>
          <div class="row">
            <div class="col-md-6"><con:CodeField runat="server" ID="BookingMethod" DataBoundValue="BookingMethodCode" LabelText="Donation Method" CodeType="BOOKM" /></div>
          </div>
          <Con:PopupField runat="server" ID="SourceCode" DataBoundValue="SourceCodeId" DataBoundText="SourceCode.Name" LabelText="Promotion" PopupUrl="~/marketing/popups/promotionsearch.aspx" HyperlinkUrl="~/marketing/sourcepage.aspx?id={id}" />
          <con:ListField runat="server" ID="SellCompName" DataBoundValue="SellingCompanyId" DataBoundText="SellingCompany.Name" LabelText="Selling Company" DisplayMember="Name" ValueMember="Id" Requirement="MandatoryEnforced" />
        </con:GroupBox>        
      </div>
    </div>
  </con:WizardPage>
  <con:WizardPage runat="server" ID="DonationAmountPage" Title="Donation Amount">
    <div class="row">
      <div class="col-12">
        <con:GroupBox runat="server" Title="Donations">
            <con:Validator runat="server" ClientValidationFunction="ValidateDonationList" ErrorMessage="You must provide at least one donation" />
            <con:DataTable runat="server" ID="NewDonationLineList" Mode="Stateful" CanModify="false" Url="~/genericPopup.aspx?context=learning&control=newdonationlinedetail">
              <Columns>
                <con:DataTableTextColumn FieldName="Delegate.DelegateAddressId" visible ="false"/>
                <con:DataTableTextColumn FieldName="Delegate.DelegateRoleId" visible ="false"/>
                <con:DataTableTextColumn FieldName="Delegate.DelegateOrgId" visible ="false"/>
                <con:DataTableTextColumn FieldName="SellingCompanyId" visible ="false"/>
                <con:DataTableTextColumn FieldName="ProductId" visible ="false"/>
                <con:DataTableTextColumn FieldName="MainSession" visible ="false" />
                <con:DataTableTextColumn FieldName="Type" visible ="false" />
                <con:DataTableTextColumn FieldName="PaymentMethodCode" visible ="false" />
                <con:DataTableTextColumn FieldName="Qty" visible ="false" />
                <con:DataTableTextColumn FieldName="PriceListId" visible ="false" />
                <con:DataTableTextColumn FieldName="PriceIdId" visible ="false" />
                <con:DataTableTextColumn FieldName="Delegate.Role.Person.ActiveGiftAid.id" visible ="false" />
                <con:DataTableTextColumn FieldName="Delegate.Role.Person.ActiveGiftAid.TypeCode" visible ="false" />
                <con:DataTableTextColumn Title="Description" FieldName="Description" />
                <con:DataTableTextColumn Title="Fund" FieldName="CostCode" />
                <con:DataTableTextColumn Title="Amount" FieldName="UintPrice" />
                <con:DataTableIconColumn Title="Gift Aid" FieldName="GiftAid" />
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
  <con:WizardPage runat="server" ID="PaymentPage" Title="Payment" Visible="true">
    <con:Payment runat="server" ID="Payment" />
  </con:WizardPage>
  <con:WizardPage runat="server" ID="TerminalPage" Title="Payment gateway" Visible="false">
    <h3 class="text-danger">Payment to be completed via DataCash</h3>
  </con:WizardPage>
  <con:WizardPage runat="server" ID="ConfirmPage" Title="Complete">
    
  </con:WizardPage>
</con:Wizard>
<script>
  var newDonationDetails = {
    client: null,
    loader: 'One moment...',
    controls: {
      booking: {
        sellingCompany: $('#<%= this.SellCompName.ClientID %>Field'),
        person: $('#<%= this.InvoiceContact.ClientID %>Value'),
        personid: $('#<%= this.InvoicePersonId.ClientID %>Field'),
        organisation: $('#<%= this.InvOrgName.ClientID %>Value'),
        address: $('#<%= this.InvoiceAddressId.ClientID %>Field'),
      },
      payment: {
        paymentType: $('#<%= this.Payment.PaymentType.ClientID %>Field'),
        sellingCompany: $('#<%= this.Payment.SellingCompany.ClientID %>Field'),
        currency: $('#<%= this.Payment.Currency.ClientID %>Field')
      }
    },
    functions: {
      togglePages: function () {
        //newDonationDetails.pages.payment.toggleClass('hidden', newDonationDetails.controls.booking.paymentMethod.val() > '06');
        newDonationDetails.pages.terminal.toggleClass('hidden', !payment.functions.useVirtualTerminal());
        newDonationDetails.client._init(false);
      },
      setGridUrl: function () {
        var sellingCompany = newDonationDetails.controls.booking.sellingCompany.val();
        var person = newDonationDetails.controls.booking.person.val();
        var organisation = newDonationDetails.controls.booking.organisation.val();
        var address = newDonationDetails.controls.booking.address.val();
        var personid = newDonationDetails.controls.booking.personid.val();
        var popupUrl = '<%= this.NewDonationLineList.Url %>&sellingCompany=' + sellingCompany + '&roleId=' + person + '&organisationId=' + organisation + '&addressId=' + address + '&personid=' + personid;
        window['<%= this.NewDonationLineList.ClientID %>']._createHref = popupUrl;
      },
      onNext: function (sourcePage, targetPage) {          
        switch (targetPage) {
          case 2:
            var amount = 0.00;
            var arrDonations = window['<%= this.NewDonationLineList.ClientID %>']._getSourceData();
              for (i = 0; i < arrDonations.length; i++) {
                    var vatrate = Number(arrDonations[i].Product.VatCode.Value3);
                    var netamount = Number(arrDonations[i].UintPrice) * Number(arrDonations[i].Qty);
                    var vatamount = netamount * (vatrate / 100);
                    var total = netamount + vatamount;
                    amount += total;
                }
 
            $('#<%= this.Payment.PaymentAmount.ClientID %>Field').val(amount.toFixed(2));
            $('#<%= this.Payment.Currency.ClientID %>Field').val('GBP');

            
            var currency = newDonationDetails.controls.payment.currency.find('option[value="' + newDonationDetails.controls.payment.currency.val() + '"]');
            var conversion = parseFloat(currency.attr('data-conversion'));
            conversion = isNaN(conversion) ? 1 : conversion;
            amount = isNaN(amount) ? 0 : (amount * conversion);

            $('#<%= this.Payment.Conversion.ClientID %>Field').val(conversion.toFixed(2));
            $('#<%= this.Payment.PaymentBC.ClientID %>Field').val(amount.toFixed(2));
            break;
          case 3:
            newDonationDetails.client.showProgress('Connecting to payment gateway', 'info');
            setTimeout(function () {
              newDonationDetails.client.showProgress('Payment gateway not supported', 'error', false);
            }, 1000);
            break;
          case 4:
            newDonationDetails.client.showProgress('Creating donation', 'info');
            var state = new consensus.data.state(null, {}, $('#' + newDonationDetails.pages.booking.attr('data-page')));              
            state.updateObject();
            var booking = state.object;
            booking.Elements = window['<%= this.NewDonationLineList.ClientID %>']._getSourceData();
            //if (newDonationDetails.controls.booking.paymentMethod.val() < "07") {
                var state = new consensus.data.state(null, {}, $('#' + newDonationDetails.pages.payment.attr('data-page')));
                state.updateObject();
                booking.payments = [state.object];
                booking.AccountId = state.object.AccountId;              
              
              //}
                if (!booking.Elements["0"].Delegate.Role.Person.ActiveGiftAid.id && booking.Elements["0"].GiftAid) {

                    //consensus.network.send({
                    //    method: 'post',
                    //    url: 'contact/person/FetchById?id=' + booking.Elements[0].Delegate.DelegatePersonId,
                    //    success: function (result) {
                            var newGiftAidDeclaration = {
                                TypeCode: booking.Elements[0].Delegate.Role.Person.ActiveGiftAid.TypeCode,
                                PnIdId: booking.Elements[0].Delegate.DelegatePersonId,
                                Active: booking.Elements[0].GiftAid,
                                //FirstName: result.FirstName,
                                //Surname: result.Surname,
                                //Address: result.PrincipalRole.Address.MailString
                            }
                            consensus.network.send({
                                method: 'put',
                                url: 'contact/Giftaid',
                                data: newGiftAidDeclaration,
                                success: function (result) {
                                    var resp = result;
                                }
                            });
                    //    }
                    //});

                }
                
            consensus.network.send({
              method: 'put',
              url: 'learning/booking',
              data: booking,
              success: function (result) {
                newDonationDetails.client.showProgress('Donation created successfully', 'success', true);
                bookId = result.Id;
              },
              error: function (request) {
                newDonationDetails.client.showProgress('Could not create donation<br/>' + request.statusText, 'error', true);
              }
            })

              
            break;
        }
        return true;
      },
      onFinish: function () {
        if (bookId && bookId.length != 0) {
          window.top.window.location.href = consensus.resolveUrl('~/learning/donationbooking?id=' + bookId);
        }
        return true;
      }
    },
    pages: {
      booking: $('[data-page="<%= this.DonationPage.ClientID %>"]'),
      bookinglines: $('[data-page="<%= this.DonationAmountPage.ClientID %>"]'),
      payment: $('[data-page="<%= this.PaymentPage.ClientID %>"]'),
      terminal: $('[data-page="<%= this.TerminalPage.ClientID %>"]'),
      confirm: $('[data-page="<%= this.ConfirmPage.ClientID %>"]')
    }
  };

  function ValidateDonationList(source, arguments) {
      arguments.IsValid = window['<%= this.NewDonationLineList.ClientID %>']._getSourceData().length > 0;
  }

  $(document).ready(function () {
    newDonationDetails.client = window['<%= this.Wizard.ClientID %>'];
    newDonationDetails.client.onNext = newDonationDetails.functions.onNext;
    newDonationDetails.client.onFinish = newDonationDetails.functions.onFinish;
    newDonationDetails.functions.togglePages();
    newDonationDetails.functions.setGridUrl();
    payment.functions.onLoadConfiguration = newDonationDetails.functions.togglePages;

    $('[id$=_PopupFooterPanel]').show(); // to show the customise button from the footer that gets hided.
    $('[id$=_PopupFooterPanel]').find('#Content_CustomiseButton').addClass('Content_CustomiseButton')
      $('[id$=_PopupFooterPanel]').find('#Content_PopupFooter_SaveButton').css('display', 'none')
      $('[id$=_PopupFooterPanel]').find('#Content_PopupFooter_UndoButton').css('display', 'none')

  });
</script>


