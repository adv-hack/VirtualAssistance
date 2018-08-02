<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="PaymentDetails.ascx.cs" Inherits="Consensus.Web.BackOffice.finance.controls.PaymentDetails" %>
<div class="row">
    <div class="col-md-6">
        <con:GroupBox runat="server" Title="Payment details">
            <div class="row">
                <div class="col-md-6"><con:TextField runat="server" ID="PayRecID" DataBoundValue="Id" LabelText="Payment ID" IsReadOnly="True" /></div>
                <div class="col-md-6"><con:CodeField runat="server" ID="Status" DataBoundValue="StatusCode" LabelText="Status" CodeType="PAYST" /></div>
                
            </div>

            <div class="row">
                <div class="col-md-6"><con:CodeField runat="server" ID="PayType" DataBoundValue="TypeCode" LabelText="Payment Type" CodeType="PYPAY" IsReadOnly="True" /></div>
                <div class="col-md-6"><con:DateField runat="server" ID="Date" DataBoundValue="Date" LabelText="Date" /></div>
            </div>

            <div class="row">
                <div class="col-md-6"><con:TextField runat="server" ID="Currency" DataBoundValue="Currency" LabelText="Currency" Requirement="MandatoryEnforced" IsReadOnly="True" /></div>
                <div class="col-md-6"><con:TextField runat="server" ID="PaymentAmount" DataBoundValue="Amount" LabelText="Payment" IsReadOnly="True"/></div>
            </div>

            <div class="row">
                <div class="col-md-6"><con:TextField runat="server" ID="BankCharge" DataBoundValue="BankCharges" LabelText="Bank Charges" IsReadOnly="True"/></div>
                <div class="col-md-6"><con:TextField runat="server" ID="UnusedVal" DataBoundValue="UnusedVal" LabelText="Unused Value" IsReadOnly="True" /></div>
            </div>

            <div class="row">
                <div class="col-md-6"><con:ListField runat="server" ID="SellingCompany" DataBoundValue="SellingCompanyId" DataBoundText="SellingCompany.Name" LabelText="Selling Company" DisplayMember="Name" ValueMember="Id" Requirement="MandatoryEnforced" /></div>
            </div>        
            
        </con:GroupBox>
    </div>
    
    
    <div class="col-md-6">
        <con:GroupBox runat="server" Title="Payer information">
            <div class="row">
                <div class="col-md-6">
                    <Con:PopupField runat="server" ID="ARNum" DataBoundValue="AccountId" DataBoundText="Account.ARNumber" LabelText="AR Number" PopupUrl="~/finance/popups/accountsearch.aspx" HyperlinkUrl="~/finance/accountpage.aspx?id={id}">
                        <Filters>
                            <con:PopupFieldFilter ParameterName="org" Type="Control" Value="AROrg" />
                        </Filters>
                    </Con:PopupField>
                </div>

            </div>
            <div class="row">
                <div class="col-md-6">
                    <Con:PopupField runat="server" ID="PersonName" DataBoundValue="CardholderRoleId" DataBoundText="CardholderRole.PersonName" LabelText="Payer" PopupUrl="~/crm/popups/personsearch.aspx" HyperlinkUrl="~/crm/personpage.aspx?role={id}">
                         <Filters>
                            <con:PopupFieldFilter ParameterName="org" Type="Control" Value="AROrg" />
                          </Filters>
                    </Con:PopupField>
                </div>
                <div class="col-md-6"><Con:PopupField runat="server" ID="AROrg" DataBoundValue="OrganisationId" DataBoundText="Organisation.Name" LabelText="Organisation" PopupUrl="~/crm/popups/organisationsearch.aspx" HyperlinkUrl="~/crm/organisationpage.aspx?id={id}" /></div>
            </div>



        </con:GroupBox>

        <con:GroupBox runat="server" Title="Payment information">

            <div class="row">
                <div class="col-md-6"><con:TextField runat="server" ID="PayRef" DataBoundValue="Reference" LabelText="Payment reference" /></div>
                <div class="col-md-6"><con:TextField runat="server" ID="BankingRef" DataBoundValue="BankingReference" LabelText="Banking Reference" /></div>
            </div>
            
            <div class="row">
                <div class="col-md-6"><con:TextField runat="server" ID="ApprovalRef" DataBoundValue="ApprovalReference" LabelText="Approval Reference" /></div>
            </div>

        </con:GroupBox>
    </div>
</div>
<con:TextField runat="server" ID="Notes" DataBoundValue="Notes" LabelText="Notes" TextMode="MultiLine" />
<br />
