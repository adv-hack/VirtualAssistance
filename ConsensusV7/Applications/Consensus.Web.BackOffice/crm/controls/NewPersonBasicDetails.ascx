<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="NewPersonBasicDetails.ascx.cs" Inherits="Consensus.Web.BackOffice.crm.controls.NewPersonBasicDetails" %>
<%@ Register TagPrefix="con" TagName="AddressDetail" Src="~/crm/controls/AddressDetail.ascx" %>

<con:HiddenField runat="server" DataBoundValue="IsPrincipal" ID="Principal" />
<div class="row">
    <div class="col-6"> 
        <con:GroupBox runat="server" Title="Personal Details">
          <div class="row">
            <div class="col-md-6"><con:CodeField runat="server" ID="PersonTitle" DataBoundValue="Person.TitleCode" LabelText="Title" CodeType="TITLE" ClientOnChange="UpdateSalutation();" /></div>
            <div class="col-md-6"><con:TextField runat="server" ID="PersonFirstName" DataBoundValue="Person.FirstName" LabelText="First Name" Requirement="MandatoryEnforced" ClientOnChange="UpdateSalutation();" /></div>
            
          </div>
          <div class="row">
              <div class="col-md-6"><con:TextField runat="server" ID="PersonSurname" DataBoundValue="Person.Surname"   LabelText="Surname" Requirement="MandatoryEnforced" ClientOnChange="UpdateSalutation();" /></div>
              <div class="col-md-6"><con:TextField runat="server" ID="PersonSalutation" DataBoundValue="Person.Salutation" LabelText="Salutation" /></div>
          </div>
          <con:TextField runat="server" ID="JobTitle" DataBoundValue="JobTitle" LabelText="Job Title" />
          <con:PopupField runat="server" ID="Organisation" DataBoundValue="OrganisationId" DataBoundText="Organisation.Name" LabelText="Organisation" PopupUrl="~/crm/popups/organisationsearch.aspx" HyperlinkUrl="~/crm/organisationpage.aspx?id={id}"  />
        </con:GroupBox>

        <con:GroupBox runat="server" Title="Additional Details">
          <div class="row">
            <div class="col-md-6"><con:DateField runat="server" DataBoundValue="Person.DateOfBirth" ID="DateOfBirth" LabelText="Date Of Birth"/></div>
            <div class="col-md-2"><con:CodeField runat="server" DataBoundValue="Person.GenderCode" ID="Gender" LabelText="Gender" CodeType="GEND" /></div>
            <div class="col-md-4"><con:TextField runat="server" DataBoundValue="Person.NiNumber" ID="NiNumber" LabelText="NI Number" /></div>
          </div>
          <div class="row">
            <div class="col-md-6"><con:CodeField runat="server" DataBoundValue="Person.EthnicityCode" ID="Ethnicity" LabelText="Ethnicity" CodeType="ETHNI"  /></div>
            <div class="col-md-6"><con:CodeField runat="server" DataBoundValue="Person.NationalityCode" ID="Nationality" LabelText="Nationality" CodeType="NTNLT"  /></div>
          </div>
          <div class="row">
                
            <div class="col-md-4"><con:CheckField runat="server" DataBoundValue="KeyContact" ID="KeyContact" LabelText="KeyContact" /></div>
            <div class="col-md-4"><con:CheckField runat="server" DataBoundValue="Person.OurPerson" ID="OurPerson" LabelText="OurPerson" /></div>
            <div class="col-md-4"><con:CheckField runat="server" DataBoundValue="Person.Diary" ID="Diary" LabelText="Diary" /></div>
          </div>
          <con:ListField runat="server" ID="SellCompName" DataBoundValue="SellingCompanyId" DataBoundText="SellingCompany.Name" LabelText="Selling Company" ValueMember="Id" DisplayMember="Name" Requirement="MandatoryEnforced" />
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
        <con:GroupBox runat="server" Title="Address">
          <con:AddressDetail runat="server" Id="Address" DataBoundObject="Address" DataBoundId="AddressId" />
        </con:GroupBox> 
    </div>

    <script>
        function UpdateSalutation() {
            var salutation = $('#<%= this.PersonSalutation.ClientID %>Field');
            var title = $('#<%= this.PersonTitle.ClientID %>Field').val();
            var fName = $('#<%= this.PersonFirstName.ClientID %>Field').val();
            var lName = $('#<%= this.PersonSurname.ClientID %>Field').val();
            if (title.trim() == '' || title.trim().toLowerCase() == 'other')
                salutation.val((fName + ' ' + lName).trim());
            else
                salutation.val((title + ' ' + lName).trim());
        }
    </script>
</div>