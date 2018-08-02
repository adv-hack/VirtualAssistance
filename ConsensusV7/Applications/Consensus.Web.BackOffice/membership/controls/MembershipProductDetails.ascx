<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="MembershipProductDetails.ascx.cs" Inherits="Consensus.Web.BackOffice.membership.controls.MembershipProductDetails" %>
<%@ Register TagPrefix="con" TagName="GenericProductDetails" Src="~/learning/controls/GenericProductDetails.ascx" %>

<div class="row">
    <div class="col-md-6">
        <div class="col-md-12">
            <con:HiddenField runat="server" ID="SyProduct" DataBoundValue="SyProduct" />
            <con:GroupBox runat="server" Title="Basic Details">
                <con:GenericProductDetails runat="server" ID="GenericProduct" DataBoundId="Id" />
            </con:GroupBox>
        </div>
    </div>

    <div class="col-md-6">
        <div class="col-md-12">
            <con:GroupBox runat="server" Title="Membership Details">
                <div class="row">
                    <div class="col-md-6">
                        <con:TextField runat="server" ID="Prefix" LabelText="Prefix" DataBoundValue="Prefix" />
                    </div>
                    <div class="col-md-6">
                        <con:TextField runat="server" ID="MembershipDuration" LabelText="Membership Duration (months)" DataBoundValue="CourseLen">
                            <Validators>
                                <con:Validator runat="server" ClientValidationFunction="CheckMembershipDuration" Critical="true" ErrorMessage="Membership duration cannot be 0." />
                            </Validators>
                        </con:TextField>
                    </div>
                </div>
                <div class="row">
                    <div class="col-md-6">
                        <con:TextField runat="server" ID="SpecialistGroups" LabelText="Number of Specialist Groups" DataBoundValue="NumberOfSpecialistGroups" />
                    </div>
                    <div class="col-md-6">
                        <con:ListField runat="server" ID="FeeCalculation" LabelText="Fee Calculation" DataBoundValue="MsGroup">
                            <Items>
                                <asp:ListItem Text="Individual" Value="10" />
                                <asp:ListItem Text="Group" Value="30" />
                            </Items>
                        </con:ListField>
                    </div>
                </div>
               
                <div class="row">
                    <div class="col-md-4">
                        <con:TextField runat="server" ID="ExclusionDays" LabelText="Exclusion Days" TextMode="Number" DataBoundValue="RenewalExclusion" />
                    </div>
                    <div class="col-md-4">
                        <con:ListField runat="server" ID="ExclusionCalculation" LabelText="Exclusion Calculation" DataBoundValue="ExclCalc">
                            <Items>
                                <asp:ListItem Text="None" Value="0" />
                                <asp:ListItem Text="Months" Value="1" />
                                <asp:ListItem Text="Fixed" Value="2" />
                            </Items>
                        </con:ListField>
                    </div>
                    <div class="col-md-4">
                        <con:ListField runat="server" ID="InvoiceType" LabelText="Invoice Type" DataBoundValue="MemInvType">
                            <Items>
                                <asp:ListItem Text="Invoice" Value="0" />
                                <asp:ListItem Text="Pro forma" Value="1" />
                            </Items>
                        </con:ListField>
                    </div>       
                </div>
                 <div class="row">
                    <div class="col-md-12">
                        <con:CheckField runat="server" ID="StartMembership" LabelText="Start Membership on First Booking / Donation" DataBoundValue="MemFirstBook" />
                    </div>
                                 
                </div>
            </con:GroupBox>

            <con:GroupBox runat="server" Title="Renewals">
                <div class="row">
                    <div class="col-md-4">
                        <con:CheckField runat="server" ID="NoneRenewable" LabelText="None Renewable" DataBoundValue="NonRenewMemb" ClientOnChange="toggleNoneRenewable();"/>
                    </div>
                    <div class="col-md-5">
                        <con:CheckField runat="server" ID="NoInvoice" LabelText="No Invoice on Renewal" DataBoundValue="NoInvRenew" />
                    </div>
                    <div class="col-md-3">
                        <con:TextField runat="server" ID="RenewDays" LabelText="Renewal days" TextMode="Number" DataBoundValue="RenewDays" />
                    </div>

                    <div class="col-md-4">
                        <con:CheckField runat="server" ID="FixedPoint" LabelText="Fixed Point Renewal" DataBoundValue="IsRenewalFixed" ClientOnChange="toggleFixedRenewal(false);"/>
                    </div>
                    <div class="col-md-3">
                        <con:ListField runat="server" ID="RenewalMonth" LabelText="Renewal Month" DataBoundValue="RenewalMonth" ClientOnChange="toggleRenewalDay();">
                            <Items>
                                <asp:ListItem Text="" Value="" /> <asp:ListItem Text="January" Value="1" /><asp:ListItem Text="February" Value="2" />
                                <asp:ListItem Text="March" Value="3" /> <asp:ListItem Text="April" Value="4" /><asp:ListItem Text="May" Value="5" />
                                <asp:ListItem Text="June" Value="6" /> <asp:ListItem Text="July" Value="7" /><asp:ListItem Text="August" Value="8" />
                                <asp:ListItem Text="September" Value="9" /> <asp:ListItem Text="October" Value="10" /><asp:ListItem Text="November" Value="11" />
                                <asp:ListItem Text="December" Value="12" />
                            </Items>
                        </con:ListField>
                    </div>
                    <div class ="col-md-2"></div>
                    <div class="col-md-3">
                        <con:ListField runat="server" ID="RenewalDay" LabelText="Renewal Day" DataBoundValue="RenewalDay" ValueMember="Value" DisplayMember="Key"/>
                    </div>

                </div>
            </con:GroupBox>
            
            <con:GroupBox runat="server" Title="Direct Debit">
                <div class="row">
                    <div class="col-md-6">
                        <con:ListField runat="server" ID="CollectionFrequency" LabelText="Collection Frequency" DataBoundValue="DdFrequency">
                            <Items>
                                <asp:ListItem Text="" Value="" />
                                <asp:ListItem Text="Variable" Value="0" />
                                <asp:ListItem Text="Weekly" Value="1" />
                                <asp:ListItem Text="Monthly" Value="2" />
                                <asp:ListItem Text="Quarterly" Value="3" />
                                <asp:ListItem Text="Annually" Value="4" />
                            </Items>
                        </con:ListField>
                    </div>
                    <div class="col-md-6">
                        <con:TextField runat="server" ID="Installments" LabelText="Number of Installments" DataBoundValue="DdNoOfInstallments" TextMode="Number" />
                    </div>
                </div>
            </con:GroupBox>
        </div>
    </div>
</div>

    <script>
            
        consensus.data.onedit = function () {
            toggleNoneRenewable();
        };

        function toggleNoneRenewable() {
        var $cbNoneRenewable = $("#<%= NoneRenewable.ClientID %>Field"),
            $cbNoInvoice = $("#<%= NoInvoice.ClientID %>Field"),
            $cbFixedPoint = $("#<%= FixedPoint.ClientID %>Field"),
            $cbRenewalMonth = $("#<%= RenewalMonth.ClientID %>Field"),
            $cbRenewalDay = $("#<%= RenewalDay.ClientID %>Field");

            if($cbNoneRenewable.prop("checked")) {
                $cbNoInvoice.bootstrapSwitch("state", false).bootstrapSwitch("disabled",true );
                $cbFixedPoint.bootstrapSwitch("state", false).bootstrapSwitch("disabled", true);
            }
            else {
                $cbNoInvoice.bootstrapSwitch("disabled", false);
                $cbFixedPoint.bootstrapSwitch("disabled", false);
            }
            
            toggleFixedRenewal($cbNoneRenewable.prop("checked"));
        }

        function toggleFixedRenewal(noneRenewable) {
            var $cbFixedPoint = $("#<%= FixedPoint.ClientID %>Field"),
            $cbRenewalMonth = $("#<%= RenewalMonth.ClientID %>Field");

            $cbRenewalMonth.prop("disabled", (!$cbFixedPoint.prop("checked") || noneRenewable));

            toggleRenewalDay();
           
        }

        function toggleRenewalDay() {
        var $cbRenewalMonth = $("#<%= RenewalMonth.ClientID %>Field"),
            $cbRenewalDay = $("#<%= RenewalDay.ClientID %>Field");
            
            if (!$cbRenewalMonth.prop("disabled") && $cbRenewalMonth.val() > 0)
                $cbRenewalDay.prop("disabled", false);
            else
                $cbRenewalDay.prop("disabled", true);
           
        }

        function CheckMembershipDuration(source,arguments) {
        var duration = $("#<%=MembershipDuration.ClientID%>Field").val();
        arguments.IsValid = (duration != 0);
        }


    </script>