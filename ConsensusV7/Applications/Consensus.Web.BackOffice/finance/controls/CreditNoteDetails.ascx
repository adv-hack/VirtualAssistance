<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="CreditNoteDetails.ascx.cs" Inherits="Consensus.Web.BackOffice.finance.controls.CreditNoteDetails" %>

<div class="row">
    <div class="col-md-6">
        <con:GroupBox runat="server" Title="Credit note details">
          <div class="row">
            <div class="col-md-6"><con:TextField runat="server" ID="InvoiceNo" DataBoundValue="Reference" LabelText="Credit note number" IsReadOnly="True" /></div>
            <div class="col-md-6"><con:TextField runat="server" ID="CreditedInvoice" DataBoundValue="CreditNteRef.Reference" LabelText="Credited invoice" IsReadOnly="True" /></div>
          </div>
          <div class="row">
            <div class="col-md-6"><con:DateField runat="server" ID="InvoiceDate" DataBoundValue="Date" IsReadOnly="True" LabelText="Credit date" Requirement="MandatoryEnforced" /></div>
            <div class="col-md-6"><con:TextField runat="server" ID="Curr" DataBoundValue="Currency" LabelText="Currency" IsReadOnly="True" /></div>
          </div>
          <div class="row">
            <div class="col-md-6"><con:TextField runat="server" ID="GrossTotal" DataBoundValue="GrossTotal" LabelText="Gross total" IsReadOnly="True" /></div>
            <div class="col-md-6"><con:TextField runat="server" ID="Unpaid" DataBoundValue="UnpaidValue" LabelText="Unallocated value" IsReadOnly="True" /></div>
          </div>
          <div class="row">
            <div class="col-md-6"><con:TextField runat="server" ID="NetTotal" DataBoundValue="NetTotal" LabelText="Net total" IsReadOnly="True" /></div>
            <div class="col-md-6"><con:TextField runat="server" ID="VatTotal" DataBoundValue="VatTotal" LabelText="VAT total" IsReadOnly="True" /></div>
          </div>
          <div class="row">
            <div class="col-md-6"><con:ListField runat="server" ID="SellingCompanyId" DataBoundValue="SellingCompanyId" DataBoundText="SellingCompany.Name" IsReadOnly="True" LabelText="Selling Company" DisplayMember="Name" ValueMember="Id" Requirement="MandatoryEnforced" /></div>
          </div>
        </con:GroupBox>
    </div>
    <div class="col-md-6">
        <con:GroupBox runat="server" Title="Account information">
          <div class="row">
            <div class="col-md-6"><con:PopupField runat="server" ID="ARNo" DataBoundValue="AccountId" DataBoundText="Account.ARNumber" IsReadOnly="True" LabelText="AR number" PopupUrl="~/finance/popups/accountsearch.aspx" HyperlinkUrl="~/finance/accountpage.aspx?id={id}">
                <Filters>
                    <con:PopupFieldFilter ParameterName="org" Type="Control" Value="OrgName" />
                </Filters>
            </con:PopupField></div>
            <div class="col-md-6"><con:TextField runat="server" ID="AccountName" DataBoundValue="Account.Title" LabelText="Account name" IsReadOnly="True" /></div>
          </div>

          <div class="row">
            <div class="col-md-6"><con:CodeField runat="server" ID="AccountStatus" DataBoundValue="SOPStatus" LabelText="Account status" CodeType="ACCST" IsReadOnly="True" /></div>
            <div class="col-md-6"><con:PopupField runat="server" ID="AccountContact" DataBoundValue="Account.RoleId" DataBoundText="Account.Role.PersonName" LabelText="Account contact" PopupUrl="~/crm/popups/personsearch.aspx" HyperlinkUrl="~/crm/personpage.aspx?role={id}" IsReadOnly="True" /></div>
          </div>
        </con:GroupBox>
 
        <con:GroupBox runat="server" Title="Credit note contact">
          <div class="row">
            <div class="col-md-6"><con:PopupField runat="server" ID="CreditNoteContact" DataBoundValue="ProleIdId" DataBoundText="ProleId.PersonName" LabelText="Contact" PopupUrl="~/crm/popups/personsearch.aspx" HyperlinkUrl="~/crm/personpage.aspx?role={id}">
                <Filters>
                    <con:PopupFieldFilter ParameterName="org" Type="Control" Value="OrgName" />
                </Filters>
            </con:PopupField></div>
            <con:HiddenField runat="server" ID="PersonId" DataBoundValue="PersonId" />
            <div class="col-md-6"><con:PopupField runat="server" ID="OrgName" DataBoundValue="OrganisationId" DataBoundText="Organisation.Name" LabelText="Organisation" PopupUrl="~/crm/popups/organisationsearch.aspx" HyperlinkUrl="~/crm/organisationpage.aspx?id={id}" /></div>
            <con:HiddenField runat="server" ID="OrganisationName" DataBoundValue="OrgName" />
          </div>
          <div class="row">
            <con:HiddenField runat="server" ID="AddressId" DataBoundValue="AddId" />
            <div class="col-md-6"><con:TextField runat="server" ID="AddressMailstring" LabelText="Invoice address" DataBoundValue="AddressMailstring" IsReadOnly="TrueEnforced"  TextMode="MultiLine" CssClass="consensus-input noresize" /></div>
            <div class="col-md-6"><con:PopupField runat="server" ID="PackType" DataBoundValue="PackId" DataBoundText="Pack.Name" LabelText="Pack" PopupUrl="~/document/popups/packsearch.aspx" Requirement="MandatoryEnforced">
                <Filters>
                    <con:PopupFieldFilter ParameterName="PackType" Type="Value" Value="Invoice" />
                </Filters>
            </con:PopupField></div>
          </div>

        </con:GroupBox>
    </div>
</div>
