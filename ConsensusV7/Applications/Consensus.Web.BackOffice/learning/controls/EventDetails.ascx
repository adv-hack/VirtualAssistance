<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="EventDetails.ascx.cs" Inherits="Consensus.Web.BackOffice.learning.controls.EventDetails" %>

<div class="row">
    <div class="col-lg-6 consensus-column">
        <con:GroupBox runat="server" Title="Details">
            <div class="row">
                <div class="col-md-6">
                    <con:PopupField runat="server" ID="CourseName" DataBoundValue="ProductId" DataBoundText="Product.Name" LabelText="Course Name" Requirement="MandatoryEnforced" PopupUrl="~/learning/popups/productsearch.aspx?syProduct=1" HyperlinkUrl="~/learning/coursepage.aspx?id={id}" />
                </div>
                <div class="col-md-6">
                    <con:TextField runat="server" ID="CourseRef" DataBoundValue="Product.Ref" LabelText="Course Ref" IsReadOnly="True" />
                </div>
            </div>
            <div class="row">
                <div class="col-md-6">
                    <con:TextField runat="server" ID="Name" DataBoundValue="Name" LabelText="Event Name" Requirement="MandatoryEnforced" />
                </div>
                <div class="col-md-6">
                    <con:TextField runat="server" ID="Ref" DataBoundValue="Ref" LabelText="Event Ref" IsReadOnly="True" />
                </div>
            </div>
            <div class="row">
                <div class="col-md-6">
                    <con:CodeField runat="server" ID="EventType" DataBoundValue="TypeCode" LabelText="Event Type" CodeType="COURT" />
                </div>

                <div class="col-md-6">
                    <con:ListField runat="server" ID="EventStatus" DataBoundValue="StatusCode" LabelText="Event Status" ValueMember="Value1" Requirement="MandatoryEnforced" />
                </div>
            </div>
            <div class="row">
                <div class="col-md-6">
                    <con:TextField runat="server" ID="Length" DataBoundValue="Length" LabelText="Length" Requirement="MandatoryEnforced" />
                </div>
                <div class="col-md-6">
                    <con:PopupField runat="server" ID="Manager" DataBoundValue="ManagerId" DataBoundText="Manager.PrincipalRole.PersonName" LabelText="Manager" PopupUrl="~/crm/popups/personsearch.aspx" HyperlinkUrl="~/crm/personpage.aspx?id={id}" />
                </div>
            </div>
            <div class="row" id="CancellationFields">
                <div class="col-md-4">
                    <con:CodeField runat="server" ID="CancellationReason" DataBoundValue="CancellationReasonCode" LabelText="Cancellation Reason" CodeType="CNCRS" />
                </div>
                <div class="col-md-4">
                    <con:DateField runat="server" ID="CancellationDate" DataBoundValue="CancellationDate" LabelText="Cancellation Date" />
                </div>
                <div class="col-md-4">
                    <con:TextField runat="server" ID="UnrecoverableCancelationLoss" DataBoundValue="UnrecoverableCancelationLoss" LabelText="Unrecoverable Cancellation Loss" TextMode="Number" />
                </div>
            </div>
            <div class="row">
                <div class="col-md-6">
                    <con:DateField runat="server" ID="StartDate" DataBoundValue="StartDate" LabelText="Start Date" Requirement="MandatoryEnforced" ClientOnChange="setEndDate();" />
                </div>
                <div class="col-md-6">
                    <con:TimeField runat="server" ID="StartTime" DataBoundValue="StartTime" LabelText="Start Time" />
                </div>
            </div>
            <div class="row">
                <div class="col-md-6">
                    <con:DateField runat="server" ID="EndDate" DataBoundValue="EndDate" LabelText="End Date" Requirement="MandatoryEnforced" />
                </div>
                <div class="col-md-6">
                    <con:TimeField runat="server" ID="EndTime" DataBoundValue="EndTime" LabelText="End Time" />
                </div>
            </div>
            <div class="row">
                <div class="col-md-6">
                    <con:ListField runat="server" ID="WebSchedule" DataBoundValue="Web" LabelText="Web Schedule">
                        <Items>
                            <asp:ListItem Text="Not Web Enabled" Value="0" />
                            <asp:ListItem Text="Web Enabled" Value="1" />
                        </Items>
                    </con:ListField>
                </div>
                <div class="col-md-6">
                    <con:ListField runat="server" ID="CutPrdTime" DataBoundValue="CutPrdTime" LabelText="Remove from sale">
                        <Items>
                            <asp:ListItem Text="Midnight" Value="0" />
                            <asp:ListItem Text="Event Start Time" Value="1" />
                        </Items>
                    </con:ListField>
                </div>
            </div>
        </con:GroupBox>
        <con:GroupBox runat="server" Title="Pricing Method">
            <con:ListField runat="server" ID="SellingCompanyName" DataBoundValue="SellingCompanyId" LabelText="Selling Company" DisplayMember="Name" ValueMember="Id" Requirement="MandatoryEnforced" />
            <%--<div class="row">
                <div class="col-md-6">
                    <con:PopupField runat="server" ID="BookingTerms" DataBoundValue="BookingTermsId" LabelText="Booking Terms" PopupUrl="~/#" HyperlinkUrl="~/#" />
                </div>
                <div class="col-md-6">
                    <con:PopupField runat="server" ID="PaymentSchedule" DataBoundValue="PayScheduleHeaderId" LabelText="Payment Schedule" PopupUrl="~/#" HyperlinkUrl="~/#" />
                </div>
            </div>--%>
            <div class="row">
                <div class="col-md-6">
                    <con:CodeField runat="server" ID="DefDelStatus" DataBoundValue="DefaultDelegateStatusCode" LabelText="Default Delegate Status" CodeType="CDES" />
                </div>
                <div class="col-md-6">
                    <con:CheckField runat="server" ID="DoNotInvoice" DataBoundValue="DoNotInvoice" LabelText="Manual Invoice" />
                </div>
            </div>
            <div class="row">
                <div class="col-md-6">
                    <con:ListField runat="server" ID="Pricing" DataBoundValue="Pricing" LabelText="Pricing" ClientOnChange="toggleBlockDropdown();">
                        <Items>
                            <asp:ListItem Text="Public (Per Delegate)" Value="0" />
                            <asp:ListItem Text="Block charge" Value="1" />
                            <asp:ListItem Text="Combination" Value="2" />
                            <asp:ListItem Text="Per Delegate Per Week" Value="3" />
                        </Items>
                    </con:ListField>
                </div>
                <div class="col-md-6">
                    <con:ListField runat="server" ID="BlockType" DataBoundValue="BlockType" LabelText="Block Charging">
                        <Items>
                            <asp:ListItem Text="Block charge per Booking" Value="0" />
                            <asp:ListItem Text="Block charge per Event" Value="1" />
                            <asp:ListItem Text="Registration Fee" Value="2" />
                        </Items>
                    </con:ListField>
                </div>
            </div>
        </con:GroupBox>
        <con:GroupBox runat="server" Title="Customer Details">
            <div class="row">
                <div class="col-md-6">
                    <con:PopupField runat="server" ID="Commissioned" DataBoundValue="CommissionedId" DataBoundText="Commissioned.Name" LabelText="Commissioning Organisation" PopupUrl="~/crm/popups/organisationsearch.aspx" HyperlinkUrl="~/crm/organisationpage.aspx?id={id}" />
                </div>
                <div class="col-md-6">
                    <con:PopupField runat="server" ID="CommissionedRole" DataBoundValue="CommissionedRoleId" DataBoundText="CommissionedRole.PersonName" LabelText="Commissioned by" PopupUrl="~/crm/popups/personsearch.aspx" HyperlinkUrl="~/crm/personpage.aspx?role={id}">
                        <Filters>
                            <con:PopupFieldFilter ParameterName="org" Type="Control" Value="Commissioned" />
                        </Filters>
                    </con:PopupField>
                </div>
            </div>
            <div class="row">
                <div class="col-md-6">
                    <con:TextField runat="server" ID="Opportunity" DataBoundValue="Opportunity.Name" LabelText="Opportunity" IsReadOnly="True" />
                </div>
                <div class="col-md-6">
                    <con:TextField runat="server" ID="ClientRef" DataBoundValue="ClientRef" LabelText="Client Ref" />
                </div>
            </div>
            <div class="row">
                <div class="col-md-6">
                    <con:CheckField runat="server" ID="Private" DataBoundValue="Private" LabelText="Private" />
                </div>
            </div>
        </con:GroupBox>

    </div>
    <div class="col-lg-6 consensus-column">
        <con:GroupBox runat="server" Title="Venue">
            <div class="row">
                <div class="col-md-6">
                    <con:PopupField runat="server" ID="Organisation" DataBoundValue="OrganisationId" DataBoundText="Organisation.Name" LabelText="Organisation" PopupUrl="~/crm/popups/organisationsearch.aspx" HyperlinkUrl="~/crm/organisationpage.aspx?id={id}" Requirement="MandatoryEnforced" />
                </div>
                <div class="col-md-6">
                    <con:PopupField runat="server" ID="Contact" DataBoundValue="ContactId" LabelText="Contact" DataBoundText="Contact.PersonName" PopupUrl="~/crm/popups/personsearch.aspx" HyperlinkUrl="~/crm/personpage.aspx?role={id}" />
                </div>
            </div>
            <div class="row">
                <div class="col-md-6">
                    <con:PopupField runat="server" ID="Location" DataBoundValue="LocationId" DataBoundText="Location.Name" LabelText="Location" PopupUrl="~/crm/popups/locationsearch.aspx" HyperlinkUrl="~/learning/locationpage.aspx?id={id}" />
                </div>
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
                <div class="col-md-6">
                    <con:TextField runat="server" ID="MainTrainer" LabelText="Main Trainer" DataBoundValue="MainTrainer.PersonName" IsReadOnly="True" />
                </div>
                <div class="col-md-6">
                    <con:TextField runat="server" ID="Url" DataBoundValue="Url" LabelText="Course URL" />
                </div>
            </div>
        </con:GroupBox>
        <con:GroupBox runat="server" Title="Event Numbers">
            <div class="row">
                <div class="col-md-6">
                    <con:CheckField runat="server" ID="AllowOverbook" DataBoundValue="AllowOverbook" LabelText="Allow Overbook" />
                </div>
            </div>
            <div class="row">
                <div class="col-md-6">
                    <con:TextField runat="server" ID="MaxPlaces" DataBoundValue="MaxPlaces" LabelText="Maximum places" IsReadOnly="True" />
                </div>
                <div class="col-md-6">
                    <con:TextField runat="server" ID="MinPlaces" DataBoundValue="MinPlaces" LabelText="Minimum places" IsReadOnly="True" />
                </div>
            </div>
            <div class="row">
                <div class="col-md-6">
                    <con:TextField runat="server" ID="FreePlaces" DataBoundValue="FreePlaces" LabelText="Free places" IsReadOnly="True" />
                </div>
                <div class="col-md-6">
                    <con:TextField runat="server" ID="Availability" LabelText="Availability" IsReadOnly="True" />
                </div>
            </div>
            <div class="row">
                <div class="col-md-6">
                    <con:TextField runat="server" ID="ConfirmedPlaces" DataBoundValue="ConfirmedPlaces" LabelText="Confirmed places" IsReadOnly="True" />
                </div>
                <div class="col-md-6">
                    <con:TextField runat="server" ID="ProvisionalPlaces" DataBoundValue="ProvisionalPlaces" LabelText="Provisional places" IsReadOnly="True" />
                </div>
            </div>
            <div class="row">
                <div class="col-md-6">
                    <con:TextField runat="server" ID="ReservedPlaces" DataBoundValue="ReservedPlaces" LabelText="Reserved places" TextMode="Number" IsReadOnly="True" />
                </div>
                <div class="col-md-6">
                    <con:TextField runat="server" ID="LapsedPlaces" DataBoundValue="LapsedPlaces" LabelText="Lapsed places" TextMode="Number" IsReadOnly="True" />
                </div>
            </div>
            <div class="row">
                <div class="col-md-6">
                    <con:TextField runat="server" ID="WaitlistPlaces" DataBoundValue="WaitlistPlaces" LabelText="Wait list" IsReadOnly="True" />
                </div>
                <div class="col-md-6">
                    <con:TextField runat="server" ID="CancelledPlaces" DataBoundValue="CancelledPlaces" LabelText="Cancellations" IsReadOnly="True" />
                </div>
            </div>
        </con:GroupBox>
        <con:GroupBox runat="server" Title="Event Revenue and Cost">
            <div class="row">
                <div class="col-md-6">
                    <con:TextField runat="server" ID="Currency" DataBoundValue="Currency" LabelText="Currency" IsReadOnly="True" />
                </div>
            </div>
            <div class="row">
                <div class="col-md-6">
                    <con:TextField runat="server" ID="UnitPrice" DataBoundValue="UnitPrice" LabelText="Unit Price" TextMode="Number" IsReadOnly="True" />
                </div>
                <div class="col-md-6">
                    <con:TextField runat="server" ID="BlockPrice" DataBoundValue="BlockPrice" LabelText="Block Price" TextMode="Number" IsReadOnly="True" />
                </div>
            </div>
            <div class="row">
                <div class="col-md-6">
                    <con:TextField runat="server" ID="BookActual" DataBoundValue="BookActual" LabelText="Booking Value" TextMode="Number" IsReadOnly="True" />
                </div>
                <div class="col-md-6">
                    <con:TextField runat="server" ID="ActualCost" DataBoundValue="ActualCost" LabelText="Actual Cost" TextMode="Number" IsReadOnly="True" />
                </div>
            </div>
            <div class="row">
                <div class="col-md-6">
                    <con:ListField runat="server" ID="CostCode" DataBoundValue="CostCode" LabelText="Cost Code" ValueMember="Code" DisplayMember="Desc" />
                </div>
                <div class="col-md-6">
                    <con:CodeField runat="server" ID="RevCode" DataBoundValue="RevCode" LabelText="Rev Code" CodeType="REVE" />
                </div>
            </div>
        </con:GroupBox>
    </div>
</div>
<div>
    <con:GroupBox runat="server" Title="Course Notes">
        <div class="row">
            <div class="col-md-6">
                <con:TextField runat="server" ID="SessionsHeader" DataBoundValue="SessionsHeader" LabelText="Sessions Header" />
            </div>
        </div>
        <div class="row">
            <div class="col-md-12">
                <con:TextField runat="server" ID="SessionsDescription" DataBoundValue="SessionsDescription" LabelText="Sessions Description" TextMode="MultiLine" />
            </div>
        </div>
        <div class="row">
            <div class="col-md-12">
                <con:TextField runat="server" ID="CourseNotes" DataBoundValue="Notes.Body" LabelText="Course Notes" TextMode="MultiLine" />
            </div>
        </div>
    </con:GroupBox>
    <con:GroupBox runat="server" Title="Internal Notes">
        <div class="row">
            <div class="col-md-12">
                <con:TextField runat="server" ID="IntNotes" DataBoundValue="IntNotes.Body" LabelText="Internal Notes" TextMode="MultiLine" />
            </div>
        </div>
    </con:GroupBox>
</div>

<script>
    
    $(document).ready(function () {
        if( $('#<%= this.Pricing.ClientID %>Field').val() != 1)
            $('#' + '<%=this.BlockType.ClientID%>').hide();
    });

    consensus.data.onedit = function () {
        if( $('#<%= this.Location.ClientID %>Field').val().length > 0)
            $('#<%= this.AddressSearch.ClientID %>').hide();
        else
            $('#<%= this.AddressSearch.ClientID %>').show();
    };

    var RefreshProductDetails = function (restUrl) {

        this.RestUrl = restUrl;
        this.Update = function () {
            var thisInstance = this;
            var productId = $('#' + '<%=this.CourseName.ClientID%>' + 'Value').val();
            if (productId && productId.length != 0) {
                consensus.network.send({
                    async: false,
                    method: 'get',
                    url: 'learning/product?id='+ productId,
                    success: function (data, status, request) {
                        PopulateProductFields(data);
                    }
                });
            } else {
                ClearProductFields();
            }
        }
    }

    function PopulateProductFields(data) {
        $('#' + '<%=this.CourseRef.ClientID%>' + 'Field').val(data.Ref);
        $('#' + '<%=this.Name.ClientID%>' + 'Field').val(data.Name);
        $('#' + '<%=this.MaxPlaces.ClientID%>' + 'Field').val(data.MaxAttend);
        $('#' + '<%=this.MinPlaces.ClientID%>' + 'Field').val(data.MinAttend);
        $('#' + '<%=this.Length.ClientID%>' + 'Field').val(data.CourseLen);
        $('#' + '<%=this.WebSchedule.ClientID%>' + 'Field').val(data.Web);
        $('#' + '<%=this.CostCode.ClientID%>' + 'Field').val(data.CostCode);
        $('#' + '<%=this.RevCode.ClientID%>' + 'Field').val(data.RevCode);
        $('#' + '<%=this.SellingCompanyName.ClientID%>' + 'Field').val(data.SellingCompanyId);

        if(data.MainSession.StartTime){
            var startTime = new Date(data.MainSession.StartTime).toLocaleTimeString('en-US', { hour: 'numeric', minute: 'numeric', hour12: false });
            $('#' + '<%=this.StartTime.ClientID%>' + 'Field').val(startTime);
        }

        if(data.MainSession.EndTime){
            var endTime= new Date(data.MainSession.EndTime).toLocaleTimeString('en-US', { hour: 'numeric', minute: 'numeric', hour12: false });
            $('#' + '<%=this.EndTime.ClientID%>' + 'Field').val(endTime);
        }

        $('#' + '<%=this.CutPrdTime.ClientID%>' + 'Field').val(data.CutOffPeriod);

        var isLocationSet=false;
        if(data.Venue && data.VenueId)
        {
            <%=this.Organisation.ClientID%>.setValue(data.VenueId, data.Venue.Name); 
            if(!data.Location.Id && data.Venue.PrincipalAddress && data.Venue.PrincipalAddress.Id){
                consensus.network.send({
                    async: false,
                    method: 'get',
                    url: data.Venue.PrincipalAddress.uri,
                    success: function (response, status, request) {
                        isLocationSet=true;
                        $('#' + '<%=this.Address.ClientID%>' + 'Field').val(response.Address.MailString);
                        $('#' + '<%=this.AddressId.ClientID%>' + 'Field').val(response.Address.Id);        
                    }
                });
            }
        }
        else{
            <%=this.Organisation.ClientID%>.setValue(null);           
        }

        if(data.Location && data.Location.Id)
        {
            if(!data.Venue && data.Location.Organisation){
                  <%=this.Organisation.ClientID%>.setValue(data.Location.Organisation.Id, data.Location.Organisation.Name); 
            }

            <%=this.Location.ClientID%>.setValue(data.Location.Id, data.Location.Name);
            $('#' + '<%=this.Address.ClientID%>' + 'Field').val(data.Location.Address.MailString);
            $('#' + '<%=this.AddressId.ClientID%>' + 'Field').val(data.Location.Address.Id);     
            
            if(data.Location.LocationRole && data.Location.LocationRoleId){
                <%=this.Contact.ClientID%>.setValue(data.Location.LocationRoleId, data.Location.LocationRole.PersonName);
            }

        }
        else{
            <%=this.Location.ClientID%>.setValue(null);
            <%=this.Contact.ClientID%>.setValue(null);
            if(!isLocationSet){
                $('#' + '<%=this.Address.ClientID%>' + 'Field').val(null);
                $('#' + '<%=this.AddressId.ClientID%>' + 'Field').val(null);
            }
        }        
       
        if(data.ProleId && data.ProleIdId)
        {
            <%=this.Manager.ClientID%>.setValue(data.ProleId.PersonId, data.ProleId.PersonName);
        }
        else{
            <%=this.Manager.ClientID%>.setValue(null);
        }
    }

    function ClearProductFields() {
        $('#' + '<%=this.CourseRef.ClientID%>' + 'Field').val('');
        $('#' + '<%=this.Name.ClientID%>' + 'Field').val('');
        $('#' + '<%=this.MaxPlaces.ClientID%>' + 'Field').val('');
        $('#' + '<%=this.MinPlaces.ClientID%>' + 'Field').val('');
        $('#' + '<%=this.Length.ClientID%>' + 'Field').val('');
        $('#' + '<%=this.WebSchedule.ClientID%>' + 'Field').val('');
        $('#' + '<%=this.CostCode.ClientID%>' + 'Field').val('');
        $('#' + '<%=this.RevCode.ClientID%>' + 'Field').val('');
        $('#' + '<%=this.SellingCompanyName.ClientID%>' + 'Field').val('');
        <%=this.Location.ClientID%>.setValue(null);
        <%=this.Organisation.ClientID%>.setValue(null);
        $('#' + '<%=this.Address.ClientID%>' + 'Field').val(null);
        $('#' + '<%=this.AddressId.ClientID%>' + 'Field').val(null);
        $('#' + '<%=this.StartTime.ClientID%>' + 'Field').val('');
        $('#' + '<%=this.EndTime.ClientID%>' + 'Field').val('');
        <%=this.Manager.ClientID%>.setValue(null);
        <%=this.Contact.ClientID%>.setValue(null);
    }

    function setEndDate() {
        var length = $('#' + '<%=this.Length.ClientID%>' + 'Field').val();
        if(length > 0)
        {
            length--;
            var sDate = new Date($('#' + '<%=this.StartDate.ClientID%>' + 'Field').val());
            var eDate = new Date();
            eDate.setTime(sDate.getTime() + length * 86400000 );
            $('#' + '<%=this.EndDate.ClientID%>' + 'Group').datepicker('setDate', new Date(eDate));
        }
    }

    function updateCostCode(sellingCompany, costCode) {
        var sellCompField = $('#' + sellingCompany + 'Field');
        var costCodeField = $('#' + costCode + 'Field');
        var costCodeValue = costCodeField.val();
        consensus.network.send({
            method: 'post',
            url: 'finance/costcode/fetchAllBySelcoSpIdId?selcoSpIdId=' + sellCompField.val(),
            success: function(result) {

                // Remove the existing options
                costCodeField.find('option').remove();

                // Create the new options
                $('<option />').attr('value', '').text('').appendTo(costCodeField);
                for (var i = 0; i < result.length; i++)
                    $('<option />').attr('value', result[i].Code).text(result[i].Desc).appendTo(costCodeField);
            }
        });
    }
    
    function toggleBlockDropdown() {
        var selectedValue = $('#<%= this.Pricing.ClientID %>Field').val();
        if(selectedValue == "1")
        {
            $('#' + '<%=this.BlockType.ClientID%>Field').val('1');
            $('#' + '<%=this.BlockType.ClientID%>').show();
        }
        else
        {
            $('#' + '<%=this.BlockType.ClientID%>Field').val('0');
            $('#' + '<%=this.BlockType.ClientID%>').hide();
        }
    }


    addressField = function () {
        var closure = this;
        this.opening = false;
        this._addressId = $('#' + '<%=this.AddressId.ClientID%>' + 'Field');
        this._orgId =  $('#' + '<%=this.Organisation.ClientID%>' + 'Value');
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
            if(closure._orgId.val()){
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
            else{
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
