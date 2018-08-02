<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="MemberDetails.ascx.cs" Inherits="Consensus.Web.BackOffice.membership.controls.MemberDetails" %>
    <div class="col-md-6">
            <con:GroupBox runat="server" Title="Member period details">
                <div class="row">
                    <div class="col-md-6">
                        <con:TextField runat="server" ID="MemberNumber" LabelText="Member number" DataBoundValue="MemId.Ref" IsReadonly="True"/>
                    </div>
                    <div class="col-md-6">
                        <con:PopupField runat="server" ID="MembershipProduct" DataBoundValue="ProductId" DataBoundText="Product.Name" LabelText="Membership product" PopupUrl="~/learning/popups/productsearch.aspx?syProduct=10" HyperlinkUrl="~/membership/membershipproductpage.aspx?id={id}" IsReadOnly="True"/>
                    </div>
                </div>
                <div class="row">
                    <div class="col-md-6">
                        <con:CodeField runat="server" ID="Status" LabelText="Status" DataBoundValue="StatusCode" CodeType="MEPST" ClientOnChange="ShowCancellationField();"/>
                    </div>
                    <div class="col-md-6">
                        <con:DateField runat="server" ID="RenewalDate" LabelText="Renewal date" DataBoundValue="RenewalDate"  />      
                    </div>
                </div>
                <div class="row">
                    <div class="col-md-6">

                        <con:DateField runat="server" ID="StartDate" LabelText="Period start date" DataBoundValue="Start" Requirement="MandatoryEnforced" />
                    </div>
                    <div class="col-md-6">
                        <con:DateField runat="server" ID="EndDate" LabelText="Period end Date" DataBoundValue="End" Requirement="MandatoryEnforced" />
                    </div>
                </div>
                <div class="row">
                    <div class="col-md-6">
                        <con:DateField runat="server" ID="IndemInsurDate" LabelText="Insurance expiry date" DataBoundValue="IndemInsurDate" />
                    </div>
                    <div class="col-md-6">
                        <con:DateField runat="server" ID="RollbackDate" LabelText="Renewal rollback date" DataBoundValue="RollbackDate"  IsReadonly="True" />
                    </div>
                </div>

                <div class="row">
                    <div class="col-md-6">
                        <con:DateField runat="server" ID="LapseDate" LabelText="Lapsed / cancelled date" DataBoundValue="LapseDate"  IsReadonly="True" />
                    </div>
                    <div class="col-md-6" id="divCancel">
                        <con:CodeField runat="server" ID="CancelReason" LabelText="Cancellation reason" DataBoundValue="CancelReasonCode" CodeType="MEPCR" />
                    </div>
                </div>            
                 </con:GroupBox>
        
                <con:GroupBox runat="server" Title="Member history">

                <div class="row">
                   <div class="col-md-6">                        
                        <con:DateField runat="server" ID="JoinDate" LabelText="Join date" DataBoundValue="MemId.JoinDate"  IsReadonly="True"/>
                    </div>
                    <div class="col-md-6">
                        <con:DateField runat="server" ID="CurrentDate" LabelText="Membership start date" DataBoundValue="CurrentDate"  IsReadonly="True"/>                                          
                    </div>
                </div>


                <div class="row">
                    <div class="col-md-6">
                        <con:PopupField runat="server" ID="SourceCode" DataBoundValue="SourceCodeId" DataBoundText="SourceCode.Name" LabelText="Source code" PopupUrl="~/marketing/popups/promotionsearch.aspx" HyperlinkUrl="~/marketing/sourcepage.aspx?id={id}" />

                    </div>
                    <div class="col-md-6">
                        <con:CodeField runat="server" ID="AppMethod" LabelText="Application method" DataBoundValue="AppMethodCode" CodeType="MEMAPP" />
                    </div>
                </div>

            </con:GroupBox>
        
            <con:GroupBox runat="server" Title="Locations">
<%--                <div class="row">
                <div class="col-md-6">
                    <con:TextField runat="server" ID="LocationNoUK" DataBoundValue="Qty2" LabelText="UK locations" IsReadOnly="True" TextMode="Number" />
                </div>
                <div class="col-md-6">
                    <con:TextField runat="server" ID="LocationNoInt" DataBoundValue="Qty3" LabelText="Overseas locations" IsReadOnly="True" TextMode="Number" />
                </div> </div>--%>
                <div class="row">
                <div class="col-md-6">
                    <con:TextField runat="server" ID="TotalLoc" LabelText="Total locations" IsReadOnly="True" TextMode="Number"  />
                </div>
                <div class="col-md-6">
                    <con:TextField runat="server" ID="TotalCurLoc" LabelText="Total active locations" IsReadOnly="True" TextMode="Number" />
                </div></div>
            </con:GroupBox>
        </div>

<script>

    $(document).ready(function () {
        //toggle cancellation reason field
        ShowCancellationField();

    });
    function ShowCancellationField() {
        var statusCode = $("#<%= Status.ClientID %>Field").val(),
            $cancelField = $("#divCancel");

            var statusVal = statusCode.substr(0, 2);
            $cancelField.toggle(statusVal >= 90);
    }
</script>