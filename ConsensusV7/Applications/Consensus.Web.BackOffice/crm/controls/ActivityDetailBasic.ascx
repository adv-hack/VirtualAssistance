<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="ActivityDetailBasic.ascx.cs" Inherits="Consensus.Web.BackOffice.crm.controls.ActivityDetailBasic" %>
<%@ Register TagPrefix="con" TagName="AttachmentList" Src="~/common/controls/AttachmentList.ascx" %>
<%@ Register TagPrefix="con" TagName="Comments" Src="~/common/controls/Comments.ascx" %>

<con:TabControlFooter ID="tabControl" runat="server">
    <Pages>
        <con:TabPage ID="tabActivity" runat="server" Title="Activity">
            <div class="row">
                <div class="col-md-6"><con:TextField runat="server" ID="Name" DataBoundValue="Name" LabelText="Summary" Requirement="MandatoryEnforced" /></div>
                <div class="col-md-6"><con:CodeField runat="server" ID="Type" DataBoundValue="TypeCode" LabelText="Type" Requirement="MandatoryEnforced" CodeType="ACT" /></div>
            </div>
            <div class="row">
                <div class="col-md-4"><con:DateField runat="server" DataBoundValue="ActionDate" ID="StartDate" LabelText="Start date" Requirement="MandatoryEnforced"/></div>
                <div class="col-md-2"><con:TimeField runat="server" DataBoundValue="Time" ID="StartTime" LabelText="Start time" /></div>
                <div class="col-md-4"><con:DateField runat="server" DataBoundValue="EndDate" ID="EndDate" LabelText="End date" /></div>
                <div class="col-md-2"><con:TimeField runat="server" DataBoundValue="EndTime" ID="EndTime" LabelText="End time" /></div>
            </div>
            <div class="row">
                <div class="col-md-6"><con:PopupField runat="server" ID="EndUser" DataBoundValue="EndUserId" DataBoundText="EndUser.PersonRole.PersonName" LabelText="Contact" PopupUrl="~/crm/popups/personsearch.aspx" HyperlinkUrl="~/crm/popups/personsearch.aspx?id={id}" Requirement="MandatoryEnforced"/></div>
                <con:HiddenField runat="server" ID="EndUser_PersonID" DataBoundValue="EndUser.PersonId" />
                <con:HiddenField runat="server" ID="EndUser_PnName" DataBoundValue="EndUser.PnName" />
                <div class="col-md-6"><con:CodeField runat="server" ID="Result" DataBoundValue="ResultCode" LabelText="Status" CodeType="TKST" /></div>

            </div>
            <div class="row">
                <div class="col-md-6"><con:PopupField runat="server" ID="SalesPerson" DataBoundValue="SalesPersonId" DataBoundText="SalesPerson.PersonRole.PersonName" LabelText="Owner" PopupUrl="~/crm/popups/personsearch.aspx" HyperlinkUrl="~/crm/popups/personsearch.aspx?id={id}" /></div>   
                <div class="col-md-6"><con:ListField runat="server" ID="SellingCompanyName" DataBoundValue="SellingCompanyId" LabelText="Selling company" DisplayMember="Name" ValueMember="Id" Requirement="MandatoryEnforced" /></div>     
            </div>
            <div class="row">
                <div class="col-md-12">
                    <con:HtmlTextField runat="server" DataBoundValue="NoteHtml" ID="Notes" LabelText="Notes" Requirement="MandatoryEnforced" Height="220px" />
                </div>
            </div>
        </con:TabPage>
 
        <con:TabPage ID="tabAttachments" runat="server" Title="Attachments">
            <con:AttachmentList ID="conAttachments" runat="server" />
        </con:TabPage>
        <%--<con:TabPage ID="tabComments" runat="server" Title="Comments">
            <con:Comments ID="conComments" runat="server" />
        </con:TabPage>--%>
    </Pages>
</con:TabControlFooter>
