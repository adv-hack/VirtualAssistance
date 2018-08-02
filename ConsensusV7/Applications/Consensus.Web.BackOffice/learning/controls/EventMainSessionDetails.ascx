<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="EventMainSessionDetails.ascx.cs" Inherits="Consensus.Web.BackOffice.learning.controls.EventMainSessionDetails" %>
<div>
    <con:GroupBox runat="server" Title="Main Session Details">
        <div class="row">
            <div class="col-md-6">

                <div class="col-md-6">
                    <con:PopupField runat="server" ID="CourseName" DataBoundValue="MainSession.ProductId" DataBoundText="MainSession.Product.Name" LabelText="Session Course Product" IsReadOnly="True" PopupUrl="~/learning/popups/productsearch.aspx?syProduct=1" HyperlinkUrl="~/learning/coursepage.aspx?id={id}" />
                </div>

                <div class="col-md-6">
                    <con:TextField runat="server" ID="Name" DataBoundValue="MainSession.Name" LabelText="Session Title" Requirement="MandatoryEnforced" />
                </div>

                <div class="col-md-6">
                    <con:DateField runat="server" ID="StartDate" DataBoundValue="MainSession.ActionDate" LabelText="Start Date" Requirement="MandatoryEnforced" />
                </div>
                <div class="col-md-6">
                    <con:TimeField runat="server" ID="StartTime" DataBoundValue="MainSession.Time" LabelText="Start Time" />
                </div>

                <div class="col-md-6">
                    <con:DateField runat="server" ID="EndDate" DataBoundValue="MainSession.EndDate" LabelText="End Date" Requirement="MandatoryEnforced">
                        <Validators>
                            <con:Validator runat="server" ClientValidationFunction="validateDates" Critical="true" ErrorMessage="End date must be after the start date" />
                        </Validators>
                    </con:DateField>
                </div>
                <div class="col-md-6">
                    <con:TimeField runat="server" ID="EndTime" DataBoundValue="MainSession.EndTime" LabelText="End Time" />
                </div>

            </div>
            <div class="col-md-6">

                <div class="col-md-4">
                    <con:TextField runat="server" ID="MaxPlaces" DataBoundValue="MainSession.MaxPlaces" LabelText="Maximum Places" TextMode="Number" />
                </div>
                <div class="col-md-4">
                    <con:TextField runat="server" ID="MinPlaces" DataBoundValue="MainSession.MinPlaces" LabelText="Minimum Places" TextMode="Number" >
                    <Validators>
                            <con:Validator runat="server" ClientValidationFunction="validateMaxPlaces" Critical="true" ErrorMessage="Minimum places must be less than the maximum places" />
                        </Validators>
                    </con:TextField>
                </div>
                <div class="col-md-4">
                    <con:TextField runat="server" ID="FreePlaces" DataBoundValue="MainSession.FreePlaces" LabelText="Free Places" TextMode="Number" IsReadOnly="True" />
                </div>
                <div class="col-md-4">
                    <con:CheckField runat="server" ID="SessionComplete" DataBoundValue="MainSession.DoneIt" LabelText="Session Complete" />
                </div>
                <div class="col-md-4">
                    <con:CheckField runat="server" ID="AttendanceLog" DataBoundValue="MainSession.ShowAttLog" LabelText="Show on Attendance Log" />
                </div>
                <div class="col-md-4">
                    <con:CheckField runat="server" ID="Element" DataBoundValue="MainSession.SessionXrefMaster.Element" LabelText="Element" />
                </div>
                <div class="col-md-4">
                    <con:CheckField runat="server" ID="Invoice" DataBoundValue="MainSession.SessionXrefMaster.InvPrint" LabelText="Invoice" />
                </div>
                <div class="col-md-4">
                    <con:CheckField runat="server" ID="ShowOnBooking" DataBoundValue="MainSession.SessionXrefMaster.ShowSales" LabelText="Show on Booking" />
                </div>

            </div>
        </div>

    </con:GroupBox>
</div>











