<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="InvoiceDetails.ascx.cs" Inherits="Consensus.Web.BackOffice.learning.controls.InvoiceDetails" %>

    <div class="row">
        <div class="col-md-6"><Con:PopupField runat="server" ID="ARNo" DataBoundValue="AccountId" DataBoundText="Account.ARNumber" LabelText="AR Number" PopupUrl="~/finance/popups/accountsearch.aspx" HyperlinkUrl="~/finance/accountpage.aspx?id={id}">
                                <Filters>
                                    <con:PopupFieldFilter ParameterName="org" Type="Control" Value="InvOrgName" />
                                </Filters>
        </Con:PopupField></div>
    </div>
    
    <div class="row">
        <div class="col-md-6"><Con:PopupField runat="server" ID="InvoiceContact" DataBoundValue="InvoiceRoleId" Requirement="MandatoryEnforced" DataBoundText="InvoiceRole.PersonName" LabelText="Name" PopupUrl="~/crm/popups/personsearch.aspx" HyperlinkUrl="~/crm/personpage.aspx?role={id}">
                                <Filters>
                                    <con:PopupFieldFilter ParameterName="org" Type="Control" Value="InvOrgName" />
                                </Filters>
                              </Con:PopupField>
        </div>
        <div class="col-md-6"><Con:PopupField runat="server" ID="InvOrgName" DataBoundValue="InvoiceOrgId" DataBoundText="InvoiceOrg.Name" LabelText="Organisation" PopupUrl="~/crm/popups/organisationsearch.aspx" HyperlinkUrl="~/crm/organisationpage.aspx?id={id}" /></div>
    </div>

    <con:HiddenField runat="server" ID="InvoiceAddressId" DataBoundValue="InvoiceAddressId" />
    <div class="row">
        <div class="col-md-6"><con:TextField  runat="server" ID="InvoiceAddress" LabelText="Address" DataBoundValue="InvoiceRole.Address.MailString" IsReadOnly="TrueEnforced"  Requirement="OptionalEnforced" TextMode="MultiLine" CssClass="consensus-input noresize" /></div>
    </div>
