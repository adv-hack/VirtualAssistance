<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="LocationDetail.ascx.cs" Inherits="Consensus.Web.BackOffice.learning.controls.LocationDetail" %>
<%@ Register TagPrefix="con" Src="~/crm/controls/AddressDetail.ascx" TagName="AddressDetail" %>

<div class="row">
    <div class="col-lg-6 consensus-column">
        <con:GroupBox runat="server" Title="Location details">
            <div class="row">
                <div class="col-md-12"><con:TextField runat="server" ID="Name" DataBoundValue="Name" LabelText="Name" Requirement="MandatoryEnforced" /></div>
            </div>
            <div class="row">
                <div class="col-md-6"><con:TextField runat="server" ID="Ref" DataBoundValue="Ref" LabelText="Reference" Requirement="MandatoryEnforced" /></div>
                <div class="col-md-6"><con:PopupField runat="server" ID="Organisation" DataBoundValue="OrganisationId" DataBoundText="Organisation.Name" LabelText="Organisation" PopupUrl="~/crm/popups/organisationsearch.aspx" HyperlinkUrl="~/crm/organisationpage.aspx?id={id}" Requirement="MandatoryEnforced" /></div>
            </div>
            <div class="row">
                <div class="col-md-6"><con:CodeField runat="server" ID="VenueType" DataBoundValue="VenueTypeCode" LabelText="Type" CodeType="VNTYP" /></div>
                <div class="col-md-6"><con:CodeField runat="server" ID="RegionCode" DataBoundValue="RegionCode" LabelText="Region" CodeType="ROREG" /></div>
            </div>
            <div class="row">           
                <div class="col-md-6"><con:CheckField runat="server" ID="TrainLocation" DataBoundValue="TrainLocation" LabelText="Active Location" /></div>
                <div class="col-md-6"><con:CheckField runat="server" ID="WebEnabled" DataBoundValue="WebEnabled" LabelText="Web Enabled" /></div>
            </div>


            <div class="row"> 
                <div class="col-md-6"><con:CheckField runat="server" ID="OurLocation" DataBoundValue="OurLocation" LabelText="Our Location" /></div>
                <div class="col-md-6"><con:ListField runat="server" ID="SellingCompany" DataBoundValue="SellingCompanyId" DataBoundText="SellingCompany.Name" LabelText="Selling Company" DisplayMember="Name" ValueMember="Id" Requirement="MandatoryEnforced" /></div>
            </div>

            <div class="row">
                <div class="col-md-6"><con:HiddenField runat="server" ID="LocationId" DataBoundValue="Id" /></div>
            </div>
        </con:GroupBox>
    </div>
    <div class="col-lg-6 consensus-column">
        <con:GroupBox runat="server" Title="Venue information">
             <div class="row">
                <div class="col-md-6"><con:PopupField runat="server" ID="PersonRole" DataBoundValue="LocationRoleId" DataBoundText="LocationRole.PersonName" LabelText="Contact" PopupUrl="~/crm/popups/personsearch.aspx" HyperlinkUrl="~/crm/personpage.aspx?role={id}" /></div>
                <div class="col-md-6"><con:TextField runat="server" ID="LocationPhone" DataBoundValue="LocationPhone" LabelText="Phone" /></div>
            </div>
            <div class="row">
                <div class="col-md-6"><con:TextField runat="server" ID="LocationEmail" DataBoundValue="LocationEmail" LabelText="Email" /></div>
                <div class="col-md-6"><con:TextField runat="server" ID="URL" DataBoundValue="Url" LabelText="URL" /></div>
            </div>
            <div class="row">
                <div class="col-md-6">
                    <con:HiddenField runat="server" ID="AddressId" DataBoundValue="AddressId" />
                    <con:TextField runat="server" ID="Address" DataBoundValue="Address.MailString" LabelText="Address" TextMode="MultiLine" IsReadOnly="True">
                        <Addons>
                            <con:AddOn Icon="search" ToolTip="Select Alternate Address" CssClass="consensus-edit-visible" ID="AddressSearch" />
                        </Addons>
                    </con:TextField>
                </div>
            </div>
            <div class="row">
                
            </div>
            <div class="row">

            </div>
        </con:GroupBox>
    </div>
</div>
<div class="row">
    <div class="col-md-12">
            <con:TextField runat="server" ID="Description" TextMode="MultiLine" DataBoundValue="Description" LabelText="Notes" />
    </div>
</div>

<con:Validator runat="server" ClientValidationFunction="CheckIfLocationReferenceExist" ErrorMessage="" />

<script type="text/javascript">

    function CheckIfLocationReferenceExist(source, args) {
        consensus.network.send({
            async: false,
            method: 'post',
            url: 'contact/location/CheckIfLocationReferenceExist?reference=' + $('#<%= this.Ref.ClientID %>Field').val() + '&locationId=' + $('#<%= this.LocationId.ClientID %>Field').val(),
            success: function (response) {
                if (response) {
                    args.IsValid = !response;
                    if (response) {
                        source.errormessage = "Location Reference already exists.";
                    }                                        
                }
            },
            error: function (request) {
            }
        });
    }


    addressField = function () {
        var closure = this;
        this.opening = false;
        this._addressId = $('#' + '<%=this.AddressId.ClientID%>' + 'Field');
        this._orgId = $('#' + '<%=this.Organisation.ClientID%>' + 'Value');
        this._addmailstring = $('#' + '<%=this.Address.ClientID%>' + ' textarea');
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
