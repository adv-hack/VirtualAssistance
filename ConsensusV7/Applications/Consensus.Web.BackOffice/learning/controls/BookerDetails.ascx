<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="BookerDetails.ascx.cs" Inherits="Consensus.Web.BackOffice.learning.controls.BookerDetails" %>


<div class="row">
    <div class="col-md-6">
        <con:PopupField runat="server" ID="Contact" DataBoundValue="BookerRoleId" DataBoundText="BookerRole.PersonName" LabelText="Contact" PopupUrl="~/crm/popups/personsearch.aspx" HyperlinkUrl="~/crm/personpage.aspx?role={id}">
            <Filters>
                <con:PopupFieldFilter ParameterName="org" Type="Control" Value="OrgName" />
            </Filters>
        </con:PopupField>
    </div>
    <div class="col-md-6">
        <con:PopupField runat="server" ID="OrgName" DataBoundValue="BookerOrgId" DataBoundText="BookerOrg.Name" LabelText="Organisation" PopupUrl="~/crm/popups/organisationsearch.aspx" HyperlinkUrl="~/crm/organisationpage.aspx?id={id}" />
    </div>
</div>

<con:HiddenField runat="server" ID="BookerAddressId" DataBoundValue="BookerAddressId" />
<div class="row">

    <div class="col-md-6">
        <con:TextField runat="server" ID="BookerAddress" LabelText="Address" DataBoundValue="BookerAddress.MailString" IsReadOnly="TrueEnforced" Requirement="OptionalEnforced" TextMode="MultiLine" CssClass="consensus-input noresize" />
    </div>
</div>
<script>

//to check whether data is available to populate in fields
var isDataAvailable = false;

</script>

