<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="MemberPersonDetail.ascx.cs" Inherits="Consensus.Web.BackOffice.membership.controls.MemberPersonDetail" %>
    <div class="col-md-6">
        <con:GroupBox runat="server" Title="Contact information">
            <div class="row">
                <div class="col-md-12"><con:TextField runat="server" ID="MembershipName" DataBoundValue="MemberPeriod.MembershipName" LabelText="Membership name"  /></div>
            </div>
          
            <div class="row">
                <div class="col-md-6"><con:PopupField runat="server" ID="Name" DataBoundValue="RoleId" DataBoundText="Role.PersonName" LabelText="Name" PopupUrl="~/crm/popups/PersonSearch.aspx" HyperlinkUrl="~/crm/PersonPage.aspx?role={id}" IsReadOnly="True" /></div>
                <div class="col-md-6"><con:PopupField runat="server" ID="Organisation" DataBoundValue="OrgIdId" DataBoundText="OrgId.Name" IsReadOnly="True" LabelText="Organisation" PopupUrl="~/crm/popups/organisationsearch.aspx" HyperlinkUrl="~/crm/organisationpage.aspx?id={id}" /></div>
            </div>
            <div class="row">
                <div class="col-md-6"><con:TextField runat="server" ID="JobTitle" DataBoundValue="Role.JobTitle" LabelText="Job title" IsReadOnly="True" /></div>
                <div class="col-md-6"><con:TextField runat="server" ID="Email" DataBoundValue="Role.Email" LabelText="Email address" TextMode="Email" HyperlinkUrl="mailto:{text}" IsReadOnly="True" /></div>
            </div>
                
            <div class="row">
                <div class="col-md-6"><con:TextField runat="server" DataBoundValue="Role.Telephone" ID="Telephone" LabelText="Phone" TextMode="Phone" HyperlinkUrl="tel:{text}" IsReadOnly="True" /></div>
                <div class="col-md-6"><con:TextField runat="server" DataBoundValue="Role.Mobile" ID="Mobile" LabelText="Mobile" TextMode="Phone" HyperlinkUrl="tel:{text}" IsReadOnly="True" /></div>
            </div>

            <div class="row">
                <div class="col-md-6"><con:TextField runat="server" ID="Address" DataBoundValue="MailAddId.MailString" LabelText="Address" IsReadOnly="True" TextMode="MultiLine" /></div>
            </div>
        </con:GroupBox>
     <con:HiddenField runat="server" ID="MepName" DataBoundValue="MembershipName"></con:HiddenField>
    </div>

<con:Validator runat="server" ClientValidationFunction="updateMembershipName" ErrorMessage="" />
<script type="text/javascript">
    function updateMembershipName(source, arguments)
    {
        var Mepdata = consensus.data.getState().object;
        Mepdata.MembershipName = $('#<%= this.MembershipName.ClientID %>Field').val();

        $('#<%= this.MepName.ClientID %>Field').val(Mepdata.MembershipName);
    }



</script>
