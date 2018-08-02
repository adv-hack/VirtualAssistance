<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="InfoRequestDetail.ascx.cs" Inherits="Consensus.Web.BackOffice.activities.controls.InfoRequestDetail" %>
<div class="row">
    <div class="col-md-6">
        <con:GroupBox runat="server" Title="Request details">

        <div class="row">
            <con:HiddenField runat="server" ID="Type" DataBoundValue="Type" />
            <div class="col-md-12"><con:TextField runat="server" ID="Summary" DataBoundValue="Title" LabelText="Summary" Requirement="MandatoryEnforced" /></div>
        </div>
        
        <div class="row">
           <div class="col-md-6"><con:PopupField runat="server" ID="PersonRole" DataBoundValue="ProleIdId" DataBoundText="PnName" LabelText="Requested by" PopupUrl="~/crm/popups/personsearch.aspx" HyperlinkUrl="~/crm/personpage.aspx?role={id}" >
                <Filters>
                    <con:PopupFieldFilter ParameterName="org" Type="Control" Value="Organisation" />
                </Filters>
            </con:PopupField></div>
            <div class="col-md-6"><con:PopupField runat="server" ID="Organisation" DataBoundValue="OrgIdId" DataBoundText="OrgId.Name" LabelText="Organisation" PopupUrl="~/crm/popups/organisationsearch.aspx" HyperlinkUrl="~/crm/organisation?id={id}" /></div>
        </div>
       
        <div class="row">        
            <div class="col-md-6"><con:ListField runat="server" ID="Priority" DataBoundValue="Severity" LabelText="Priority" ValueMember="Value" DisplayMember="Key" /></div>
            <div class="col-md-6"><con:PopupField runat="server" ID="SourceCode" DataBoundValue="PmIdId" DataBoundText="PmId.Name" LabelText="Source code" PopupUrl="~/marketing/popups/promotionsearch.aspx" HyperlinkUrl="~/marketing/sourcepage.aspx?id={id}" /></div>
        </div>

        <div class="row">
            <div class="col-md-6"><con:ListField runat="server" ID="SellingCompany" DataBoundValue="SelcoSpIdId" DataBoundText="SellingCompany.Name" LabelText="Selling Company" DisplayMember="Name" ValueMember="Id" Requirement="MandatoryEnforced" /></div>
        </div>
        </con:GroupBox>
    </div>
    <div class="col-md-6">
        <con:GroupBox runat="server" Title="Request management">
        <div class="row">
            <div class="col-md-6"><con:DateField runat="server" ID="CallDate" DataBoundValue="CallDate" LabelText="Next action date" /></div>
            <div class="col-md-6"><con:PopupField runat="server" ID="AssignedToId" DataBoundValue="GivenToIdId" DataBoundText="GivenTo" LabelText="Assigned to" PopupUrl="~/crm/popups/personsearch.aspx" HyperlinkUrl="~/crm/personpage.aspx?role={id}" Requirement="MandatoryEnforced" /></div>                           
        </div>

        <div class="row">
            <div class="col-md-6"><con:CodeField runat="server" ID="Category" DataBoundValue="Category" LabelText="Category" CodeType="INFCA" /></div>
            <div class="col-md-6"><con:CodeField runat="server" ID="Status" DataBoundValue="Status" LabelText="Status" CodeType="INFST" /></div>
        </div>

        <div class="row">
            <div class="col-md-6"><con:CodeField runat="server" ID="Resolution" DataBoundValue="FixCat" LabelText="Resolution" CodeType="INFFI" /></div>
            <div class="col-md-6"><con:DateField runat="server" ID="ResDate" DataBoundValue="ResDate" LabelText="Resolution date" /></div>
        </div>

        </con:GroupBox>
    </div>
</div>

<div class="row">
    <div class="col-md-12">
        <con:TextField runat="server" ID="Details" TextMode="MultiLine" DataBoundText="DetailsId.Body" DataBoundValue="DetailsId.Body" LabelText="Request text" />
    </div>
</div>
