<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="PersonDetail.ascx.cs" Inherits="Consensus.Web.BackOffice.crm.controls.PersonDetail" %>
<%@ Register TagPrefix="con" TagName="AddressDetail" Src="~/crm/controls/AddressDetail.ascx" %>

<div class="row">
    <div class="col-lg-6 consensus-column"> 
        <con:GroupBox runat="server" Title="Basic details">

          <div class="row">
            <div class="col-md-6"><con:TextField runat="server" ID="PersonFirstName" DataBoundValue="Person.FirstName" LabelText="First name" Requirement="MandatoryEnforced" ClientOnChange="UpdateSalutation();" /></div>
            <div class="col-md-6"><con:TextField runat="server" ID="PersonSurname" DataBoundValue="Person.Surname"   LabelText="Surname" Requirement="MandatoryEnforced" ClientOnChange="UpdateSalutation();" /></div>
          </div>

          <div class="row">
            <div class="col-md-6"><con:CodeField runat="server" ID="PersonTitle" DataBoundValue="Person.TitleCode" LabelText="Title" CodeType="TITLE" ClientOnChange="UpdateSalutation();" /></div>
            <div class="col-md-6"><con:TextField runat="server" ID="PersonSalutation" DataBoundValue="Person.Salutation" LabelText="Salutation" /></div>
            
          </div>

          <div class="row">
            <div class="col-md-6"><con:TextField runat="server" ID="PersonPreferredName" DataBoundValue="Person.Aka" LabelText="Preferred name" /></div>
            <div class="col-md-6"><con:PopupField runat="server" ID="SourceCode" DataBoundValue="Person.PersonPromoIdId" DataBoundText="Person.PersonPromoId.Name" LabelText="Source code" PopupUrl="~/marketing/popups/promotionsearch.aspx" HyperlinkUrl="~/marketing/sourcepage.aspx?id={id}" /></div>
          </div>

          <div class="row">
            <div class="col-md-6"><con:TextField runat="server" ID="JobTitle" DataBoundValue="JobTitle" LabelText="Job title" /></div>
            <div class="col-md-6"><con:PopupField runat="server" ID="Organisation" DataBoundValue="OrganisationId" DataBoundText="Organisation.Name" LabelText="Organisation" PopupUrl="~/crm/popups/organisationsearch.aspx" HyperlinkUrl="~/crm/organisationpage.aspx?id={id}"  /></div>
          </div>

        </con:GroupBox>
        
        <con:GroupBox runat="server" Title="Address">
          <con:AddressDetail runat="server" Id="Address" DataBoundObject="Address" DataBoundId="AddressId" HideAddressContactInfo="true" />
        </con:GroupBox>
        
    </div>


    <div class="col-lg-6 consensus-column">
        <con:GroupBox runat="server" Title="Contact information">
          <div class="row">
            <div class="col-md-6"><con:TextField runat="server" DataBoundValue="Telephone" ID="Telephone" LabelText="Phone" TextMode="Phone" HyperlinkUrl="tel:{text}" /></div>
            <div class="col-md-6"><con:TextField runat="server" DataBoundValue="Mobile" ID="Mobile" LabelText="Mobile" TextMode="Phone" HyperlinkUrl="tel:{text}" /></div>
          </div>

          <div class="row">         
            <div class="col-md-6"> <con:TextField runat="server" ID="Email" DataBoundValue="Email" LabelText="Email address" TextMode="Email" HyperlinkUrl="mailto:{text}" /></div>
          </div>
        </con:GroupBox>
        
        
        <con:GroupBox runat="server" Title="Additional information">

          <div class="row">
            <div class="col-md-6"><con:DateField runat="server" DataBoundValue="Person.DateOfBirth" ID="DateOfBirth" LabelText="Date of birth"/></div>
            <div class="col-md-6"><con:CodeField runat="server" DataBoundValue="Person.DietryRequirementCode" ID="DietReq" LabelText="Dietary requirements" CodeType="PNDT"  /></div>
          </div>

          <div class="row">
            <div class="col-md-6"><con:CodeField runat="server" DataBoundValue="Person.GenderCode" ID="Gender" LabelText="Gender" CodeType="GEND" /></div>
			<div class="col-md-6"><con:TextField runat="server" DataBoundValue="Person.NiNumber" ID="NiNumber" LabelText="NI number" /></div>
		  </div>

		  <div class="row">
            <div class="col-md-6"><con:CodeField runat="server" DataBoundValue="Person.EthnicityCode" ID="Ethnicity" LabelText="Ethnicity" CodeType="ETHNI"  /></div>
            <div class="col-md-6"><con:CodeField runat="server" DataBoundValue="Person.NationalityCode" ID="Nationality" LabelText="Nationality" CodeType="NTNLT"  /></div>
          </div>

          <div class="row">
            <div class="col-md-6"><con:CheckField runat="server" DataBoundValue="Person.Disability" ID="Disabled" LabelText="Wheelchair access required" /></div>
          </div>

          <div class="row">
            <div class="col-md-6"><con:CheckField runat="server" DataBoundValue="Person.OurPerson" ID="OurPerson" LabelText="System user" /></div>
            <div class="col-md-6"><con:CheckField runat="server" DataBoundValue="Person.Diary" ID="Diary" LabelText="System calendar" /></div>
          </div>
        </con:GroupBox>

<%--       <%if (this.DataSource.PersonId == null) {%>
        <con:GroupBox runat="server" Title="Gift Aid declaration">
          <div class="row">
            <div class="col-md-6"><con:CheckField runat="server" DataBoundValue="Person.ActiveGiftAid.Active" ID="GiftAid" LabelText="Gift Aid" ClientOnChange="SetDeclaration();"/></div>
            <div class="col-md-6"><con:CodeField runat="server" DataBoundValue="Person.ActiveGiftAid.TypeCode" ID="Declaration" LabelText="Declaration method" CodeType="DECLA" Requirement="MandatoryEnforced"/></div>
          </div>
        </con:GroupBox>
        <%} %>--%>
    </div>
    <script>
<%--        $(document).ready(function () {
            //disable the mandatory flag on declaration
            toggleValidation('<%= this.Declaration.ClientID %>', false);
        });--%>
        function UpdateSalutation() {
            <%-- if (param)
            {
                var Fname=$('#<%= this.PersonFirstName.ClientID %>Field').val();
            }--%>
            var salutation = $('#<%= this.PersonSalutation.ClientID %>Field');
            var title = $('#<%= this.PersonTitle.ClientID %>Field').val();
            var fName = $('#<%= this.PersonFirstName.ClientID %>Field').val();
            var lName = $('#<%= this.PersonSurname.ClientID %>Field').val();
            if (title.trim() == '' || title.trim().toLowerCase() == 'other')
                salutation.val((fName + ' ' + lName).trim());
            else
                salutation.val((title + ' ' + lName).trim());

            if (fName != '')
                $('#<%= this.PersonPreferredName.ClientID %>Field').val(fName.trim())
        }
<%--        function SetDeclaration() {
  
            var giftAid = $('#<%= this.GiftAid.ClientID %>Field').prop("checked");
            if (giftAid)
                toggleValidation('<%= this.Declaration.ClientID %>', true);
            else
                toggleValidation('<%= this.Declaration.ClientID %>', false);
        }--%>
        function toggleValidation(controlId, enabled) {
            //var controlId = document.getElementById('#' + controlId);
            if (typeof (window.ValidatorValidate) == 'function' && typeof (window.Page_Validators) != 'undefined') {
                for (var i = 0; i < window.Page_Validators.length; i++) {
                    var validator = window.Page_Validators[i];
                    if (validator.validationGroup == controlId) {
                        validator.enabled = enabled;
                        consensus.data.validation.check($('#' + controlId + 'Field'));
                    }
                }
            }
        }
    </script>
</div>