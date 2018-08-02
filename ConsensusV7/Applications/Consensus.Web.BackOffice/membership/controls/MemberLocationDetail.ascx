<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="MemberLocationDetail.ascx.cs" Inherits="Consensus.Web.BackOffice.membership.controls.MemberLocationDetail" %>
<%@ Register TagPrefix="con" TagName="AddressDetail" Src="~/crm/controls/AddressDetail.ascx" %>
<div class="row">
    <con:HiddenField runat="server" ID="ProductId" DataBoundValue="ProductId" />
    <con:HiddenField runat="server" ID="PriceListId" DataBoundValue="MemberPeriod.PriceListId" />
    <con:HiddenField runat="server" ID="TotalQty" />
    <div class="col-md-6">
        <div class="row">
            <div class="col-md-12">
                <con:PopupField runat="server" ID="Contact" DataBoundValue="RoleId" DataBoundText="Role.PersonName" LabelText="Contact" PopupUrl="~/crm/popups/PersonSearch.aspx" HyperlinkUrl="~/crm/PersonPage.aspx?role={id}" Requirement="MandatoryEnforced">
                    <Filters>
                        <con:PopupFieldFilter ParameterName="org" Type="Control" Value="Organisation" />
                    </Filters>
                </con:PopupField>
            </div>
            <div class="col-md-12">
                <con:PopupField runat="server" ID="Organisation" DataBoundValue="OrgIdId" DataBoundText="OrgId.Name" LabelText="Organisation" PopupUrl="~/crm/popups/organisationsearch.aspx" HyperlinkUrl="~/crm/organisationpage.aspx?id={id}" />
            </div>
        </div>
        <div class="row">
            <div class="col-md-12">
                <con:AddressDetail runat="server" ID="Address" DataBoundObject="MailAddId" DataBoundId="MailAddIdId" />
            </div>
        </div>
    </div>
    <div class="col-md-6">
        <div class="row">
            <div class="col-md-12">
                <con:HiddenField runat="server" ID="origStartDate" />
                <con:DateField runat="server" ID="StartDate" DataBoundValue="Start" LabelText="Start Date" Requirement="MandatoryEnforced" ClientOnChange="changeDate();" />
            </div>
        </div>
        <div class="row">
            <div class="col-md-12">
                <con:HiddenField runat="server" ID="origEndDate" />
                <con:DateField runat="server" ID="EndDate" DataBoundValue="End" LabelText="End Date" Requirement="MandatoryEnforced" ClientOnChange="changeDate();" />
            </div>

        </div>
        <div class="row">
            <div class="col-md-12">
                <con:DateField runat="server" ID="CurrentDate" DataBoundValue="CurrentDate" LabelText="Current Date" IsReadOnly="True" />
            </div>
        </div>
        <div class="row">
            <div class="col-md-12">
                <con:DateField runat="server" ID="LapseDate" DataBoundValue="CancelDate" LabelText="Lapsed / Cancelled date" IsReadOnly="True" />
            </div>
        </div>
        <div class="row">
            <div class="col-md-12">
                <con:ListField runat="server" ID="Status" DataBoundValue="Status" LabelText="Status" Requirement="MandatoryEnforced">
                    <Items>
                        <asp:ListItem Text="Current and active" Value="0" />
                        <asp:ListItem Text="Cancelled and credited" Value="1" />
                        <asp:ListItem Text="Changed and inactive" Value="2" />
                    </Items>
                </con:ListField>
            </div>
        </div>
        <div class="row">
            <div class="col-md-12">
                <con:ListField runat="server" ID="Type" DataBoundValue="Type" LabelText="Type" Requirement="MandatoryEnforced" ClientOnChange="recalculateFee();">
                    <Items>
                        <asp:ListItem Text="" Value="" />
                        <asp:ListItem Text="Member" Value="0" />
                        <asp:ListItem Text="Publication only" Value="5" />
                        <asp:ListItem Text="Inactive" Value="9" />
                    </Items>
                </con:ListField>
            </div>
        </div>
        <div class="row">
            <div class="col-md-6">
                <con:CodeField runat="server" ID="VatCode" DataBoundValue="Vatcd" LabelText="VAT Code" CodeType="VATCD" Requirement="MandatoryEnforced" />
            </div>
            <div class="col-md-6">
                <con:TextField runat="server" ID="Fee" DataBoundValue="Fee" LabelText="Fee" />
            </div>
        </div>
        <div class="row">
            <div class="col-md-6">
                <con:CheckField runat="server" DataBoundValue="RenewLoc" ID="RenewLoc" LabelText="Main Location" />
            </div>
            <div class="col-md-6">
                <con:CheckField runat="server" DataBoundValue="Invoiced" ID="Invoiced" LabelText="Invoiced" IsReadOnly="True" />
            </div>
        </div>
    </div>
</div>
<script>

    $(document).ready(function () {
        var $ctlOrigStartDate = $('#' + '<%=this.origStartDate.ClientID%>' + 'Field');
        var $ctlOrigEndDate = $('#' + '<%=this.origEndDate.ClientID%>' + 'Field');
        var startDate = $('#' + '<%=this.StartDate.ClientID%>' + 'Field').val();
        var endDate = $('#' + '<%=this.EndDate.ClientID%>' + 'Field').val();

        $ctlOrigStartDate.val(startDate);
        $ctlOrigEndDate.val(endDate);

    });

    var options = {
        title: 'Are you sure?',
        text: 'Prices will be recalculated, do you wish to continue?',
        type: 'warning',
        showCancelButton: true,
        confirmButtonText: 'Yes',
        cancelButtonText: 'No',
        confirmButtonClass: 'btn btn-danger',
        cancelButtonClass: 'btn btn-default',
        buttonsStyling: false
    }

    function changeDate() {
        var $ctlOrigStartDate = $('#' + '<%=this.origStartDate.ClientID%>' + 'Field');
        var $ctlOrigEndDate = $('#' + '<%=this.origEndDate.ClientID%>' + 'Field');
        var $ctlStartDate = $('#' + '<%=this.StartDate.ClientID%>' + 'Group');
        var $ctlEndDate = $('#' + '<%=this.EndDate.ClientID%>' + 'Group');
        var startDate = $('#' + '<%=this.StartDate.ClientID%>' + 'Field').val();
        var endDate = $('#' + '<%=this.EndDate.ClientID%>' + 'Field').val();

        swal(options).then(function (result) {
            if (result) {
                //save new date values
                $ctlOrigStartDate.val(startDate);
                $ctlOrigEndDate.val(endDate);
                recalculateFee();
            }
        }, function (dismiss) {
            //reset the date fields
            $ctlStartDate.datepicker("update", $ctlOrigStartDate.val());
            $ctlEndDate.datepicker("update", $ctlOrigEndDate.val());
        });
    }

    function recalculateFee() {
        var productId = $('#' + '<%=this.ProductId.ClientID%>' + 'Field').val();
        var priceListId = $('#' + '<%=this.PriceListId.ClientID%>' + 'Field').val();
        var startDate = $('#' + '<%=this.StartDate.ClientID%>' + 'Field').val();
        var endDate = $('#' + '<%=this.EndDate.ClientID%>' + 'Field').val();
        var totalQty = $('#' + '<%=this.TotalQty.ClientID%>' + 'Field').val();
        if (!startDate)
            startDate = null;
        if (!endDate)
            endDate = null;

        consensus.network.send({
            method: 'post',
            url: 'finance/price/recalculateMemberFee?productId=' + productId + '&plId=' + priceListId + '&startDate=' + startDate + '&endDate=' + endDate + '&qtyTotal=' + totalQty,
            success: function (result) {
                updateFields(result);
            }
        });
    }

    function updateFields(result) {
        var $fee = $('#' + '<%=this.Fee.ClientID%>' + 'Field');
        var $vatCode = $('#' + '<%=this.VatCode.ClientID%>' + 'Field');

        var isMember = $('#' + '<%=this.Type.ClientID%>' + 'Field').val() == 0;

        if (isMember) {
            $fee.val(result.Amount);
            $vatCode.val(result.VatCodeCode);

        }
        else {
            $fee.val(0);
            $vatCode.val(result.VatCodeCode);
        }
    }
</script>

