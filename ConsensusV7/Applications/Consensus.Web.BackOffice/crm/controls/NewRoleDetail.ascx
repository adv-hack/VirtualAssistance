<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="NewRoleDetail.ascx.cs" Inherits="Consensus.Web.BackOffice.crm.controls.NewRoleDetail" %>
<%@ Register TagPrefix="con" TagName="AddressDetail" Src="~/crm/controls/AddressDetail.ascx" %>

<con:HiddenField runat="server" DataBoundValue="PersonId" ID="PersonID" />
<div class="row">
    <div class="col-6"> 
        <con:GroupBox runat="server" Title="Position">
          <con:TextField runat="server" ID="JobTitle" DataBoundValue="JobTitle" LabelText="Job Title" />
          <con:PopupField runat="server" ID="Organisation" DataBoundValue="OrganisationId" DataBoundText="Organisation.Name" LabelText="Organisation" PopupUrl="~/crm/popups/organisationsearch.aspx" HyperlinkUrl="~/crm/organisationpage.aspx?id={id}"  />
        </con:GroupBox>
        <con:GroupBox runat="server" Title="Address">
          <con:AddressDetail runat="server" Id="Address" DataBoundObject="Address" DataBoundId="AddressId" />
        </con:GroupBox>
        
    </div>
    <div class="col-6">
        <con:GroupBox runat="server" Title="Contact Details">
                     
          <div class="row">
            <div class="col-md-6"><con:TextField runat="server" DataBoundValue="Telephone" ID="Telephone" LabelText="Telephone" TextMode="Phone" HyperlinkUrl="tel:{text}"/></div>
            <div class="col-md-6"><con:TextField runat="server" DataBoundValue="Mobile" ID="Mobile" LabelText="Mobile" TextMode="Phone" HyperlinkUrl="tel:{text}" /></div>
          </div>
          <con:TextField runat="server" ID="Email" DataBoundValue="Email" LabelText="Email Address" TextMode="Email" HyperlinkUrl="mailto:{text}" />
                         
        </con:GroupBox>
        <con:GroupBox runat="server" Title="Role Details">
            <div class="row">
                <div class="col-md-4"><con:CheckField runat="server" DataBoundValue="IsPrincipal" ID="Principal" LabelText="Main role" /></div>
                <div class="col-md-4"><con:CheckField runat="server" DataBoundValue="KeyContact" ID="KeyContact" LabelText="Key contact" /></div>
                <div class="col-md-4"><con:CheckField runat="server" DataBoundValue="DisFlag" ID="Disabled" LabelText="Archived" /></div>
            </div>
            <con:ListField runat="server" ID="SellCompName" DataBoundValue="SellingCompanyId" DataBoundText="SellingCompany.Name" LabelText="Selling Company" DisplayMember="Name" ValueMember="Id" Requirement="MandatoryEnforced" />            
        </con:GroupBox>
    </div>
</div>