<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="QueryDetail.ascx.cs" Inherits="Consensus.Web.BackOffice.marketing.controls.QueryDetail" %>

<con:GroupBox runat="server" Title="Details">
    <div class="row">
        <div class="col-md-6">
            <div class="row">
                <div class="col-md-12">
                    <con:TextField runat="server" ID="Name" DataBoundValue="Name" LabelText="Name" Requirement="MandatoryEnforced">
                        <Validators>
                            <con:Validator runat="server" ClientValidationFunction="checkName" Critical="true" ErrorMessage="This field cannot contain any special characters" />
                        </Validators>
                    </con:TextField>
                </div>
            </div>
            <div class="row">
                <div class="col-md-12">
                    <con:TextField runat="server" TextMode="MultiLine" ID="Desc" DataBoundValue="Desc" LabelText="Description" />
                </div>
            </div>
            <!-- may be relocated - leave here commented out for now
            <div class="row">
                <div class="col-md-6"><con:TextField blablabla="server" ID="TitleSlug" DataBoundValue="TitleSlug" LabelText="Title Slug" /></div>
                <div class="col-md-6"><con:TextField blablabla="server" ID="LastResultFile" DataBoundValue="LastResultFile" LabelText="Last Result File" IsReadonly="True" /></div>
            </div>
            <div class="row">
                <div class="col-md-6"><con:CheckField blablabla="server" ID="OrgOnly" DataBoundValue="OrgOnly" LabelText="Organisation Only" /></div>
                <div class="col-md-6"><con:CheckField blablabla="server" ID="OrgDedupe" DataBoundValue="OrgDedupe" LabelText="De-dupe Organisation" /></div>
            </div>
            <div class="row">
                <div class="col-md-6"><con:CheckField blablabla="server" ID="PnDedupe" DataBoundValue="PnDedupe" LabelText="De-dupe Person" /></div>
                <div class="col-md-6"><con:CheckField blablabla="server" ID="SaveMailSample" DataBoundValue="SaveMailSample" LabelText="Save Mail Sample" /></div>
            </div>
            <div class="row">
                <div class="col-md-6"><con:CheckField blablabla="server" ID="Locked" DataBoundValue="Locked" LabelText="Locked Query" /></div>
                <div class="col-md-6"><con:TextField blablabla="server" TextMode="Number" ID="PeoplePerOrg" DataBoundValue="PeoplePerOrg" LabelText="People Per Org." /></div>
            </div>
                -->
        </div>
        <div class="col-md-6">
            <div class="row">
                <div class="col-md-6"><con:TextField runat="server" ID="Status" DataBoundValue="StatusCode" LabelText="Status" IsReadonly="True" /></div>
                <div class="col-md-6"><con:PopupField runat="server" ID="SourceCode" DataBoundValue="SourceCodeId" DataBoundText="SourceCode.Name" LabelText="Promotion" PopupUrl="~/marketing/popups/promotionsearch.aspx" HyperlinkUrl="~/learning/SourcePage.aspx?id={id}" /></div>
                
            </div>
            <div class="row">
                <div class="col-md-6"><con:PopupField runat="server" ID="Event" DataBoundValue="EventId" DataBoundText="Event.Name" LabelText="Event" PopupUrl="~/learning/popups/EventSearch.aspx" HyperlinkUrl="~/learning/EventPage.aspx?id={id}" /></div>
                <div class="col-md-6"><con:CodeField runat="server" ID="Channel" DataBoundValue="ChannelCode" LabelText="Channel" CodeType="CHAN" /></div>
            </div>
            <div class="row">
                <div class="col-md-6"><con:PopupField runat="server" ID="Owner" DataBoundValue="ManagerId" DataBoundText="Manager.PersonName" LabelText="Owner" PopupUrl="~/crm/popups/PersonSearch.aspx" HyperlinkUrl="~/crm/PersonPage.aspx?role={id}" /></div>
            </div>
        </div>
    </div>
</con:GroupBox>
<script>

    function checkName(source, arguments)
    {
        var myRegxp = /[^\w\ ]/
        var Name = $('#<%= this.Name.ClientID %>Field').val();

        arguments.IsValid = !myRegxp.test(Name);
    }

</script>