<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="StepDetail.ascx.cs" Inherits="Consensus.Web.BackOffice.marketing.controls.StepDetail" %>

<div class="row">
    <div class="col-md-6">
        <con:GroupBox runat="server" Title="Details">
            <div class="row">
                <div class="col-md-12"><con:TextField runat="server" ID="Name" DataBoundValue="Name" LabelText="Name" Requirement="MandatoryEnforced" /></div>
            </div>
            <div class="row">                
                <div class="col-md-6"><con:ListField runat="server" ID="LinkDefault" DataBoundValue="LinkDefault" LabelText="Default Link" /></div>
                <div class="col-md-6"><con:PopupField runat="server" ID="Owner" DataBoundValue="OwnerRoleId" DataBoundText="OwnerRole.PersonName" LabelText="Owner" PopupUrl="~/crm/popups/PersonSearch.aspx" HyperlinkUrl="~/crm/PersonPage.aspx?role={id}" /></div>
            </div>
            <div class="row">
                <div class="col-md-12">
                    <con:TextField runat="server" TextMode="MultiLine" ID="Desc" DataBoundValue="Desc" LabelText="Description" />
                </div>
            </div>
        </con:GroupBox>
    </div>
    <div class="col-md-6">
        <con:GroupBox runat="server" Title="Output Options"> 
            <div class="row">
                <div class="col-md-6"><con:CheckField runat="server" ID="ResultSizeOpt" DataBoundValue="ResultSizeOpt" LabelText="Random Sample" ClientOnChange="ResultSizeOptChanged();" /></div>
                <div class="col-md-6"><con:TextField runat="server" TextMode="Number" ID="ResultSize" DataBoundValue="ResultSize" LabelText="Sample Size" /></div>
            </div>
        </con:GroupBox>
        <con:GroupBox runat="server" Title="Options"> 
            <div class="row">
                <div class="col-md-6"><con:CheckField runat="server" ID="OrgOnly" DataBoundValue="OrgOnly" LabelText="Organisation Details Only" /></div>
                <div class="col-md-6"><con:CheckField runat="server" ID="BookOnly" DataBoundValue="BookOnly" LabelText="Booking Person Only" /></div>
            </div> 
        </con:GroupBox>
    </div>
</div>
<script>
    function ResultSizeOptChanged() {
        var $cbResultSizeOpt = $("#<%= ResultSizeOpt.ClientID %>Field"),
            $cbResultSize = $("#<%= ResultSize.ClientID %>Field");

        $cbResultSize.prop("disabled", !$cbResultSizeOpt.prop("checked"));
    }

    consensus.data.onedit = function() {
        ResultSizeOptChanged();
    };

    $(document).ready(function () {
        ResultSizeOptChanged();
    });
</script>