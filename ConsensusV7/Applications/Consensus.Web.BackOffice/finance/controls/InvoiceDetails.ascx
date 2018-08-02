<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="InvoiceDetails.ascx.cs" Inherits="Consensus.Web.BackOffice.finance.controls.InvoiceDetails" %>
<%@ Register TagPrefix="con" TagName="AddressDetail" Src="~/crm/controls/AddressDetail.ascx" %>

<div class="row">
  <div class="col-md-6">
    <con:GroupBox runat="server" Title="Invoice details">
      <con:HiddenField runat="server" ID="Type" DataBoundValue="TypeCode" />
      <con:HiddenField runat="server" ID="Status" DataBoundValue="Status" />

      <div class="row">
        <div class="col-md-6"><con:TextField runat="server" ID="InvoiceNo" DataBoundValue="Reference" LabelText="Invoice number" /></div>
        <div class="col-md-6"><con:DateField runat="server" ID="InvoiceDate" DataBoundValue="Date" LabelText="Invoice date" /></div>
      </div>

      <div class="row">
        <div class="col-md-6"><con:TextField runat="server" ID="PurchOrder" DataBoundValue="PurchaseOrderNumber" LabelText="Purchase order number" /></div>
        <div class="col-md-6"><con:DateField runat="server" ID="DueDate" DataBoundValue="DueDate" LabelText="Due date" /></div>
      </div>

      <div class="row">
        <div class="col-md-6"><con:TextField runat="server" ID="Curr" DataBoundValue="Currency" LabelText="Currency" IsReadOnly="True" /></div>  
        <div class="col-md-6"><con:TextField runat="server" ID="Unpaid" DataBoundValue="UnpaidValue" LabelText="Unpaid value" IsReadOnly="True" TextMode="Number"/></div>
      </div>

      <div class="row">
        <div class="col-md-6"><con:TextField runat="server" ID="GrossTotal" DataBoundValue="GrossTotal" LabelText="Gross total" IsReadOnly="True" TextMode="Number"/></div>
        <div class="col-md-6"><con:TextField runat="server" ID="NetTotal" DataBoundValue="NetTotal" LabelText="Net Total" IsReadOnly="True" TextMode="Number" /></div>
      </div>

      <div class="row">        
        <div class="col-md-6"><con:TextField runat="server" ID="VatTotal" DataBoundValue="VatTotal" LabelText="VAT Total" IsReadOnly="True" TextMode="Number" /></div>
        <div class="col-md-6"><con:ListField runat="server" ID="SelCo" DataBoundValue="SellingCompanyId" DataBoundText="SellingCompany.Name" LabelText="Selling Company" DisplayMember="Name" ValueMember="Id" IsReadOnly="True" Requirement="MandatoryEnforced" /></div>
      </div>
    
     </con:GroupBox>   
  </div>
   <div class="col-md-6">
       <con:GroupBox runat="server" Title="Account information">
          <div class="row">
            <div class="col-md-6">
              <Con:PopupField runat="server" ID="ARNo" DataBoundValue="AccountId" IsReadOnly="True" DataBoundText="Account.ARNumber" LabelText="AR Number" PopupUrl="~/finance/popups/accountsearch.aspx" HyperlinkUrl="~/finance/accountpage.aspx?id={id}">
                <Filters>
                    <con:PopupFieldFilter ParameterName="org" Type="Control" Value="OrgName" />
                </Filters>
              </Con:PopupField>
            </div>
            <div class="col-md-6"><con:TextField runat="server" ID="AccountName" DataBoundValue="Account.Title" LabelText="Account name" IsReadOnly="True" /></div>
          </div>
          <div class="row">
              <div class="col-md-6">
                  <con:CodeField runat="server" ID="AccountStatus" DataBoundValue="Account.StatusCode" LabelText="Account status" CodeType="ACCST" IsReadOnly="True" />
              </div>
                
              <div class="col-md-6">
                  <con:PopupField runat="server" ID="AccountContact" DataBoundValue="Account.RoleId" DataBoundText="Account.Role.PersonName" LabelText="Account contact" PopupUrl="~/crm/popups/personsearch.aspx" HyperlinkUrl="~/crm/personpage.aspx?role={id}" IsReadOnly="True"/>
              </div>
          </div>
        </con:GroupBox> 
        <con:GroupBox runat="server" Title="Invoice contact">
          <div class="row">
              <div class="col-md-6">
                <Con:PopupField runat="server" ID="Contact" DataBoundValue="ProleIdId" DataBoundText="ProleId.PersonName" LabelText="Contact" PopupUrl="~/crm/popups/personsearch.aspx" HyperlinkUrl="~/crm/personpage.aspx?role={id}">
                  <Filters>
                      <con:PopupFieldFilter ParameterName="org" Type="Control" Value="OrgName" />
                  </Filters>
                </Con:PopupField>
              </div>
              <div class="col-md-6"><Con:PopupField runat="server" ID="OrgName" DataBoundValue="OrganisationId" DataBoundText="Organisation.Name" LabelText="Organisation" PopupUrl="~/crm/popups/organisationsearch.aspx" HyperlinkUrl="~/crm/organisationpage.aspx?id={id}" /></div>
          </div>
 
          <div class="row">
            <con:HiddenField runat="server" ID="AddressId" DataBoundValue="AddId" />
            <div class="col-md-6"><con:TextField  runat="server" ID="AddressMailstring" LabelText="Address" DataBoundValue="AddressMailstring" IsReadOnly="TrueEnforced"  Requirement="OptionalEnforced" TextMode="MultiLine" CssClass="consensus-input noresize" /></div>
            <div class="col-md-6"><con:PopupField runat="server" ID="Pack" DataBoundValue="PackId" DataBoundText="Pack.Name" LabelText="Pack" PopupUrl="~/document/popups/packsearch.aspx">
                    <Filters>
                      <con:PopupFieldFilter ParameterName="PackType" Type="Value" Value="Invoice" />
                    </Filters>
                </Con:PopupField></div>
          </div>

     </con:GroupBox>   
  </div>
</div>