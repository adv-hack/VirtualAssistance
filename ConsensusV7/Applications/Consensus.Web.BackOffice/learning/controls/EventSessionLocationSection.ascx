<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="EventSessionLocationSection.ascx.cs" Inherits="Consensus.Web.BackOffice.learning.controls.EventSessionLocationSection" %>
<div>
    <div class="row">
        <div class="col-md-6">
            <con:PopupField runat="server" ID="SessionOrganisation" DataBoundValue="OrganisationId" DataBoundText="Organisation.Name" LabelText="Organisation" PopupUrl="~/crm/popups/organisationsearch.aspx" HyperlinkUrl="~/crm/organisationpage.aspx?id={id}" />
        </div>

        <div class="col-md-6">
            <con:PopupField runat="server" ID="SessionLocation" DataBoundValue="LocationId" DataBoundText="Location.Name" LabelText="Location" PopupUrl="~/crm/popups/locationsearch.aspx" HyperlinkUrl="~/learning/locationpage.aspx?id={id}" />
        </div>
    </div>
    <div class="row">

        <div class="col-md-6">
            <con:HiddenField runat="server" ID="SessionAddressId" DataBoundValue="AddressId" />
            <con:TextField runat="server" ID="SessionAddress" DataBoundValue="Address" LabelText="Address" TextMode="MultiLine" IsReadOnly="True">
                <Addons>
                    <con:AddOn Icon="search" ToolTip="Select Alternate Address" CssClass="consensus-edit-visible" />
                </Addons>
            </con:TextField>
        </div>
    </div>
</div>

<script>
    addressField = function () {
        var closure = this;
        this.opening = false;
        this._orgId = $('#' + '<%=this.SessionOrganisation.ClientID%>' + 'Value');
        this._addmailstring = $('#' + '<%=this.SessionAddress.ClientID%>' + ' textarea');
        this._updateIcon = function (icon) {
            closure._addmailstring.next('.input-group-addon').find('.glyphicon')
              .removeClass(function (index, className) {
                  return (className.match(/(^|\s)glyphicon-\S+/g) || []).join(' ');
              }).addClass(icon);
        };
        this.setAddress = function (addmailstring) {
            this._addmailstring.val(addmailstring).attr('readonly', 'readonly');
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
                        closure.setAddress(result.data.mailstring);
                    }
                });
            }
            else {
                window.top.swal.call(window.top, { title: 'Warning', text: 'You have not selected an organisation.', type: 'warning', showCancelButton: false, confirmButtonText: 'Ok', confirmButtonClass: 'btn btn-danger', buttonsStyling: false }).then(function (success) {
                });
            }
        };
        this._addmailstring.next('.input-group-addon').on('click', function () {
            if (!closure._opening)
                closure.openPopup();
        });
    };
</script>
