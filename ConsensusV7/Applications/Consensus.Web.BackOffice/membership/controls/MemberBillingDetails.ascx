<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="MemberBillingDetails.ascx.cs" Inherits="Consensus.Web.BackOffice.membership.controls.MemberBillingDetails" %>
<%@ Register TagPrefix="con" TagName="AddressDetail" Src="~/crm/controls/AddressDetail.ascx" %>
<div class="row">
    <div class="col-md-6">
        <con:GroupBox runat="server" Title="Billing Details">
            <div class="row">
                <div class="col-md-6">
                    <con:PopupField runat="server" ID="ARNum" DataBoundValue="AccountId" DataBoundText="Account.ARNumber" LabelText="AR Number" PopupUrl="~/finance/popups/accountsearch.aspx" HyperlinkUrl="~/finance/accountpage.aspx?id={id}">
                        <Filters>
                            <con:PopupFieldFilter ParameterName="org" Type="Control" Value="InvoiceOrg" />
                        </Filters>
                    </con:PopupField>
                </div>
                
                <div class="col-md-6">
                    <con:TextField runat="server" ID="AccountName" DataBoundValue="Account.Title" LabelText="Account Name" IsReadOnly="True" />
                </div>
            </div>
            <div class="row">
                <div class="col-md-6">
                    <con:CodeField runat="server" ID="AccountStatus" DataBoundValue="Account.StatusCode" LabelText="Account Status" CodeType="ACCST" IsReadOnly="True" />
                </div>
                
                <div class="col-md-6">
                    <con:PopupField runat="server" ID="AccountContact" DataBoundValue="Account.RoleId" DataBoundText="Account.Role.PersonName" LabelText="Account Contact" PopupUrl="~/crm/popups/personsearch.aspx" HyperlinkUrl="~/crm/personpage.aspx?role={id}" IsReadOnly="True"/>
                </div>
            </div>
            <div class="row">
                <div class="col-md-6">
                    <con:PopupField runat="server" ID="InvoiceOrg" DataBoundValue="InvOrganisationId" DataBoundText="InvOrganisation.Name" LabelText="Invoice Organisation" PopupUrl="~/crm/popups/organisationsearch.aspx" HyperlinkUrl="~/crm/organisationpage.aspx?id={id}" />

                </div>
                <div class="col-md-6">
                    <con:PopupField runat="server" ID="InvoiceContact" DataBoundValue="InvoiceRoleId" DataBoundText="InvoiceRole.PersonName" LabelText="Invoice Contact" PopupUrl="~/crm/popups/personsearch.aspx" HyperlinkUrl="~/crm/personpage.aspx?role={id}">
                        <Filters>
                            <con:PopupFieldFilter ParameterName="org" Type="Control" Value="InvoiceOrg" />
                        </Filters>
                    </con:PopupField>
                </div>
           </div>
            <div class="row">
                <div class="col-md-12">
                <con:AddressDetail runat="server" ID="InvAddress" DataBoundObject="InvAddress" DataBoundId="InvAddressId" DisplayAltAddressButton="true" HideAddressContactInfo="true"/>
           </div>
                </div>
        </con:GroupBox>
    </div>
    <div class="col-md-6">
        <con:GroupBox runat="server" Title="Payment Details">
            <div class="row">
                <div class="col-md-6">
                    <con:CodeField runat="server" ID="PaymentMethod" LabelText="Payment method" DataBoundValue="PayMethodCode" CodeType="MPAYM" />
                </div>
                <div class="col-md-6">
                    <con:TextField runat="server" ID="DDStatus" LabelText="Direct debit status" IsReadOnly="True" />
                </div>

            </div>
            <div class="row">
                <div class="col-md-6">
                    <con:TextField runat="server" ID="PONumber" DataBoundValue="CustOrderNo" LabelText="Purchase Order Number" />
                </div>
                <div class="col-md-6">
                    <con:CheckField runat="server" ID="ManualInvoice" LabelText="Manual invoice" DataBoundValue="ManualInvoice" />
                </div>
            </div>
            <div class="row">

                <div class="col-md-6">
                    <con:CheckField runat="server" ID="Invoiced" LabelText="Invoiced" IsReadOnly="True" />
                </div>

            </div>
        </con:GroupBox>
    </div>
</div>
