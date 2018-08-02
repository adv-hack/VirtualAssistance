<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="MembershipPackDetails.ascx.cs" Inherits="Consensus.Web.BackOffice.membership.controls.MembershipPackDetails" %>
<div class="row">
    <div class="col-md-12">

        <con:GroupBox runat="server" Title="Packs">
            <div class="row">
                <div class="col-md-6">
                    <con:PopupField runat="server" ID="AppPack" DataBoundValue="AppPackId" DataBoundText="AppPack.Name" LabelText="Application pack" PopupUrl="~/document/popups/packsearch.aspx">
                        <Filters>
                            <con:PopupFieldFilter ParameterName="PackType" Type="Value" Value="Membership" />
                        </Filters>
                    </con:PopupField>
                </div>
                <div class="col-md-6">
                    <con:PopupField runat="server" ID="OfferPack" DataBoundValue="OfferPackId" DataBoundText="OfferPack.Name" LabelText="Offer pack" PopupUrl="~/document/popups/packsearch.aspx">
                        <Filters>
                            <con:PopupFieldFilter ParameterName="PackType" Type="Value" Value="Membership" />
                        </Filters>
                    </con:PopupField>
                </div>
            </div>
            <div class="row">
                <div class="col-md-6">
                    <con:PopupField runat="server" ID="JoiningPack" DataBoundValue="JoiningPackId" DataBoundText="JoiningPack.Name" LabelText="Joining pack" PopupUrl="~/document/popups/packsearch.aspx">
                        <Filters>
                            <con:PopupFieldFilter ParameterName="PackType" Type="Value" Value="Membership" />
                        </Filters>
                    </con:PopupField>
                </div>
                <div class="col-md-6">
                    <con:PopupField runat="server" ID="RenewalPack" DataBoundValue="RenewalPackId" DataBoundText="RenewalPack.Name" LabelText="Renewal pack" PopupUrl="~/document/popups/packsearch.aspx">
                        <Filters>
                            <con:PopupFieldFilter ParameterName="PackType" Type="Value" Value="Membership" />
                        </Filters>
                    </con:PopupField>

                </div>
            </div>
            <div class="row">
                <div class="col-md-6">
                    <con:PopupField runat="server" ID="Remind1Pack" DataBoundValue="Remind1PackId" DataBoundText="Remind1Pack.Name" LabelText="First reminder pack" PopupUrl="~/document/popups/packsearch.aspx">
                        <Filters>
                            <con:PopupFieldFilter ParameterName="PackType" Type="Value" Value="Membership" />
                        </Filters>
                    </con:PopupField>
                </div>
                <div class="col-md-6">
                    <con:PopupField runat="server" ID="Remind2Pack" DataBoundValue="Remind2PackId" DataBoundText="Remind2Pack.Name" LabelText="Second reminder pack" PopupUrl="~/document/popups/packsearch.aspx">
                        <Filters>
                            <con:PopupFieldFilter ParameterName="PackType" Type="Value" Value="Membership" />
                        </Filters>
                    </con:PopupField>
                </div>
            </div>

            <div class="row">
                <div class="col-md-6">
                    <con:PopupField runat="server" ID="Remind3Pack" DataBoundValue="Remind3PackId" DataBoundText="Remind3Pack.Name" LabelText="Third reminder pack" PopupUrl="~/document/popups/packsearch.aspx">
                        <Filters>
                            <con:PopupFieldFilter ParameterName="PackType" Type="Value" Value="Membership" />
                        </Filters>
                    </con:PopupField>
                </div>
                <div class="col-md-6">
                    <con:PopupField runat="server" ID="RenewedPack" DataBoundValue="RenewedPackId" DataBoundText="RenewedPack.Name" LabelText="Renewed pack" PopupUrl="~/document/popups/packsearch.aspx">
                        <Filters>
                            <con:PopupFieldFilter ParameterName="PackType" Type="Value" Value="Membership" />
                        </Filters>
                    </con:PopupField>
                </div>
            </div>
            <div class="row">
                <div class="col-md-6">
                    <con:PopupField runat="server" ID="LapsedPack" DataBoundValue="LapsedPackId" DataBoundText="LapsedPack.Name" LabelText="Lapsed pack" PopupUrl="~/document/popups/packsearch.aspx">
                        <Filters>
                            <con:PopupFieldFilter ParameterName="PackType" Type="Value" Value="Membership" />
                        </Filters>
                    </con:PopupField>
                </div>
                <div class="col-md-6">
                    <con:PopupField runat="server" ID="CancelPack" DataBoundValue="CancelPackId" DataBoundText="CancelPack.Name" LabelText="Cancellation pack" PopupUrl="~/document/popups/packsearch.aspx">
                        <Filters>
                            <con:PopupFieldFilter ParameterName="PackType" Type="Value" Value="Membership" />
                        </Filters>
                    </con:PopupField>
                </div>
            </div>
        </con:GroupBox>
    </div>

    <div class="col-md-12">
        <con:GroupBox runat="server" Title="Renewal tasks">
            <div class="row">
                <div class="col-md-6">
                    <con:TextField runat="server" ID="Reminder1Days" LabelText="Send first reminder (days after renewal) " DataBoundValue="Reminder1Days" TextMode="Number" />
                </div>
                <div class="col-md-6">
                    <con:TextField runat="server" ID="Reminder2Days" LabelText="Send second reminder (days after renewal) " DataBoundValue="Reminder2Days" TextMode="Number" />
                </div>
                <div class="col-md-6">
                    <con:TextField runat="server" ID="Reminder3Days" LabelText="Send third reminder (days after renewal) " DataBoundValue="Reminder3Days" TextMode="Number" />
                </div>
                <div class="col-md-6">
                    <con:TextField runat="server" ID="LapsedDays" LabelText="Lapse membership (days after end date) " DataBoundValue="LapsedDays" TextMode="Number" />
                </div>
            </div>
        </con:GroupBox>
    </div>
</div>
