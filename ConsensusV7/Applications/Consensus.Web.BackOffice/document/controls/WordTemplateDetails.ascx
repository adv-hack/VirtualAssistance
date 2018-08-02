<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="WordTemplateDetails.ascx.cs" Inherits="Consensus.Web.BackOffice.document.controls.WordTemplateDetails" %>

<div class="row">
    <div class="col-md-6">
        <con:GroupBox runat="server" Title="Template details">
            <div class="row">
                <div class="col-md-12"><con:TextField runat="server" ID="Name" DataBoundValue="Name" LabelText="Name" Requirement="MandatoryEnforced" /></div>
            </div>
            <div class="row">
                <div class="col-md-6"><con:ListField runat="server" ID="Type" DataBoundValue="TypeId" DisplayMember="Name" ValueMember="Id" LabelText="Type" Requirement="MandatoryEnforced" /></div>
                <div class="col-md-6"><con:CheckField runat="server" ID="Current" DataBoundValue="Current" LabelText="Current" /></div>
            
            </div>
            <div class="row">
                <div class="col-md-6"><con:ListField runat="server" ID="SellingCompany" DataBoundValue="SellingCompanyId" DisplayMember="Name" ValueMember="Id" LabelText="Selling company" Requirement="MandatoryEnforced" /></div>
            </div>
        </con:GroupBox>
    </div>
    <div class="col-md-6">
        <con:GroupBox runat="server" Title="File information">

            <div class="row">
                <div class="col-md-12"><con:TextField runat="server" ID="FileName" DataBoundValue="FileName" DataBoundText="FileName" IsReadOnly="True" LabelText="File name" /></div>

            </div>
            <div class="row">
<%--                <div class="col-md-6">
                    <con:PopupField runat="server" ID="SendFrom" DataBoundValue="SendFromId" DataBoundText="SendFrom.PersonName" LabelText="Send from" PopupUrl="~/crm/popups/personsearch.aspx" HyperlinkUrl="~/crm/popups/personsearch.aspx?role={id}" />
                </div>--%>
                <div class="col-md-6"><con:CheckField runat="server" ID="PrintOnly" DataBoundValue="PrintOnly" LabelText="Physical print only" /></div>
                <div class="col-md-6"><con:CheckField runat="server" ID="SaveAsPdf" DataBoundValue="Pdf" LabelText="Send as PDF" /></div>
            </div>
<%--            <div class="row">
                <div class="col-md-6">
                    <con:ListField runat="server" ID="PrintQueue" DataBoundValue="PqId" LabelText="Print queue" DisplayMember="Description" ValueMember="Id"/>
                </div>
                <div class="col-md-6">
                    <con:CheckField runat="server" ID="EmailBody" DataBoundValue="EmailBody" LabelText="Send in email body" />
                </div>
            </div>--%>
<%--            <div class="row">
                <div class="col-md-6">
                    <con:ListField runat="server" ID="FileType" DataBoundValue="FileType" LabelText="File type" Requirement="MandatoryEnforced">
                        <Items>
                            <asp:ListItem Text="" Value="" />
                            <asp:ListItem Text="File" Value="FILE" />
                            <asp:ListItem Text="Attachment" Value="DB" />
                        </Items>
                    </con:ListField>
                </div>
                <div class="col-md-6"><con:CheckField runat="server" ID="Label" DataBoundValue="Label" LabelText="Mailing label" /></div>
            </div>--%>
        </con:GroupBox>
    </div>

</div>
