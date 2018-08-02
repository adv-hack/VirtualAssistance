<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="QueryDataProtection.ascx.cs" Inherits="Consensus.Web.BackOffice.marketing.controls.QueryDataProtection" %>


<div class="row">
    <div class="col-md-6">
        <con:GroupBox runat="server" Title="Marketing permissions">  
            <con:CheckField runat="server" ID="PnDoNotEmail" DataBoundValue="PnDoNotEmailBool" LabelText="Obey email setting" />
            <con:CheckField runat="server" ID="PnDoNotMail" DataBoundValue="PnDoNotMailBool" LabelText="Obey mail setting" />
            <con:CheckField runat="server" ID="PnDoNotFax" DataBoundValue="PnDoNotFaxBool" LabelText="Obey fax setting" />
            <con:CheckField runat="server" ID="PnDoNotSwap" DataBoundValue="PnDoNotSwapBool" LabelText="Obey 3rd party setting" />
            <con:CheckField runat="server" ID="PnExcludeArchived" DataBoundValue="PnExcludeArchivedBool" LabelText="Exclude archived people" />
        </con:GroupBox>
    </div>         
    <div class="col-md-6">
        <con:GroupBox runat="server" Title="Role specific marketing permissions"> 
            <con:CheckField runat="server" ID="ProleDoNotEmail" DataBoundValue="ProleDoNotEmailBool" LabelText="Obey email setting" />
            <con:CheckField runat="server" ID="ProleDoNotMail" DataBoundValue="ProleDoNotMailBool" LabelText="Obey mail setting" />
            <con:CheckField runat="server" ID="ProleDoNotFax" DataBoundValue="ProleDoNotFaxBool" LabelText="Obey fax setting" />
            <con:CheckField runat="server" ID="ProleDoNotSwap" DataBoundValue="ProleDoNotSwapBool" LabelText="Obey 3rd party setting" />
            <con:CheckField runat="server" ID="ProleDoNotCall" DataBoundValue="ProleDoNotCallBool" LabelText="Obey phone setting" />
            <con:CheckField runat="server" ID="ProleExcludeDisabled" DataBoundValue="ProleExcludeDisabledBool" LabelText="Exclude disabled roles" />
        </con:GroupBox>
    </div>
<%--   MKD: I've commented this out until we have done the data protection flags against the organisation
    <div class="col-md-4">
        <con:GroupBox runat="server" Title="Organisation Preferences">  
            <con:CheckField runat="server" ID="OrgDoNotEmail" DataBoundValue="OrgDoNotEmailBool" LabelText="Exclude when Do Not Email is yes" />
            <con:CheckField runat="server" ID="OrgDoNotMail" DataBoundValue="OrgDoNotMailBool" LabelText="Exclude when Do Not Mail is yes" />
            <con:CheckField runat="server" ID="OrgDoNotFax" DataBoundValue="OrgDoNotFaxBool" LabelText="Exclude when Do Not Fax is yes" />
            <con:CheckField runat="server" ID="OrgDoNotRent" DataBoundValue="OrgDoNotRentBool" LabelText="Exclude when Do Not Rent is yes" />
        </con:GroupBox>
    </div>
 --%> 
</div>
<script>
    // Ugly workaround for a UI problem with the sizing of the checkbox/bootstrapSwitch elements.
    // Without this they are not sized correctly in this context.
    // This appears to be down to a combination of the number of CheckFields on this screen and the fact that it is
    // in a tab which is not visible on page initialisation.
    // Resetting the size when this tab is displayed and we go into edit mode, or the tab is opened and 
    // we are already in edit mode.
    var bResized = false;
    $(document).ready(function () {
        $('.nav-tabs a').on('shown.bs.tab', function (event) {
            if (!bResized && $(event.target).text() == "Data Protection" && $("#Content_PageButtons_SaveButton").is(":visible")) {
                // reset the size.
                $(".bootstrap-switch-container input[type='checkbox']").bootstrapSwitch({ size: null });
                bResized = true;
            }
        });
        $("#Content_PageButtons_EditButton").on('click', function (e) {
            if (!bResized && $(".nav-tabs .nav-link.active").text() == "Data Protection") {
                // reset the size. Sadly just setting size: null has no effect in this context (even when delayed)
                // destroying and recreating the bootstrapSwitch plugin, which involves duplicating some code in consensus.js $(document).ready()
                $(".bootstrap-switch-container input[type='checkbox']").bootstrapSwitch('destroy');
                $('[data-provide=bootstrapswitch]').bootstrapSwitch();
                $('.bootstrap-switch').addClass('consensus-bootstrap-switch');
                $('.bootstrap-switch').on('switchChange.bootstrapSwitch', function (event, state) {
                    var onchange = $(this).find('input[type=checkbox]').attr('onclick');
                    return onchange ? eval(onchange) : true;
                });
                bResized = true;
            }
        });
    });
</script>