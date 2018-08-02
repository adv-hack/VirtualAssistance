<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="LicenseLimitDetail.ascx.cs" Inherits="Consensus.Web.BackOffice.security.controls.LicenseLimitDetail" %>
<div class="row">
    <div class="col-md-8">
        <con:EnumField runat="server" ID="Type" LabelText="Type" Requirement="MandatoryEnforced" DataBoundValue="Type" EnumType="LicenseLimitTypes" AddEmptyItem="false" ClientOnChange="setDescription();" />
    </div>
    <div class="col-md-4">
        <con:TextField runat="server" ID="Value" LabelText="Limitation" Requirement="MandatoryEnforced" DataBoundValue="Value" TextMode="Number" ValidatorCritical="true" />
    </div>
    <con:HiddenField runat="server" ID="TypeDescription" DataBoundValue="TypeDescription" />    
    <con:Validator runat="server" ClientValidationFunction="RestrictLicenseType" ErrorMessage="" />
</div>

<script type="text/javascript">
    function setDescription() {
        var selectedValue = $('#<%= this.Type.ClientID %>Field').val();
        var selectedOption = $('#<%= this.Type.ClientID %>Field option[value="' + selectedValue + '"]').text();
        $('#<%= this.TypeDescription.ClientID %>Field').val(selectedOption);
    }

    //Restricts adding of same license type
    function RestrictLicenseType(source, args) {
        var licenseListId = $('[id$=_LicenseLimitSearchResult]', parent.document)[0].id;
        var licenseList = window.parent[licenseListId]._getSourceData();
        args.IsValid = true;
        var selectedLicenseType = $('#<%= this.TypeDescription.ClientID %>Field').val();           

        var params = new URLSearchParams(location.search.slice(1));
        var id = params.get("id");

        for (var i = 0; i < licenseList.length; i++) {
            if (selectedLicenseType == licenseList[i].TypeDescription && licenseList[i].Id != id) {
                args.IsValid = false;
                source.errormessage = "License type already exists.";
                break;
            }
        }
    }

</script>
