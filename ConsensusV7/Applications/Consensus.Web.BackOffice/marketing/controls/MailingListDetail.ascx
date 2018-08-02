<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="MailingListDetail.ascx.cs" Inherits="Consensus.Web.BackOffice.marketing.controls.MailingListDetail" %>


    <div class="row">
        <div class="col-md-6">
            <con:GroupBox runat="server" Title="Mailing list details">
                <div class="row">
                 <div class="col-md-12"><con:TextField runat="server" ID="Name" DataBoundValue="Title" LabelText="Name" Requirement="MandatoryEnforced" /></div>
                </div>

                <div class="row">
                    <div class="col-md-6"><con:CodeField runat="server" ID="Status" DataBoundValue="StatusCode" LabelText="Status" CodeType="LU1" /></div>
                    <div class="col-md-6"><con:CheckField runat="server" ID="WebEnabled" DataBoundValue="WebEnabled" LabelText="Web Enabled" /></div>
                </div>
 
                <div class="row">
                    <div class="col-md-12">
                        <con:TextField runat="server" TextMode="MultiLine" ID="Notes" DataBoundValue="NotesHtml.Body" LabelText="Description" />
                    </div>
                </div>
            </con:GroupBox>
        </div>

        <div class="col-md-6">
            <con:GroupBox runat="server" Title="List information">
                <div class="row">
                    <div class="col-md-6"><con:DateField runat="server" ID="Date" DataBoundValue="Date" LabelText="Creation Date" /></div>
                    <div class="col-md-6"><con:PopupField runat="server" ID="Owner" DataBoundValue="OwnerId" DataBoundText="Owner.PersonName" LabelText="Owner" PopupUrl="~/crm/popups/PersonSearch.aspx" HyperlinkUrl="~/crm/PersonPage.aspx?role={id}" /></div>
                </div>
                <div class="row">
                    <div class="col-md-6"><con:TextField runat="server" TextMode="Number" ID="Limit" DataBoundValue="Limit" LabelText="Maximum number of list members" /></div>
                    <div class="col-md-6"><con:TextField runat="server" TextMode="Number" ID="TotalPersonCount" DataBoundValue="TotalPersonCount" LabelText="Current list members" IsReadOnly="True" /></div>
                </div>
            </con:GroupBox>
        </div>
    </div>
