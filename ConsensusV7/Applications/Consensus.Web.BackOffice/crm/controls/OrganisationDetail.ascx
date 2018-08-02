<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="OrganisationDetail.ascx.cs" Inherits="Consensus.Web.BackOffice.crm.controls.OrganisationDetail" %>
<%@ Register TagPrefix="con" TagName="AddressDetail" Src="~/crm/controls/OrganisationAddressDetail.ascx" %>

<div class="row">
    <div class="col-md-6">

        <con:GroupBox runat="server" Title="Organisation details">
            <div class="row">
                <div class="col-md-12"><con:TextField runat="server" ID="OrgName" DataBoundValue="Name" LabelText="Name" Requirement="MandatoryEnforced" /></div>
            </div>

            <div class="row">
                <div class="col-md-6"><con:TextField runat="server" ID="Reference" DataBoundValue="Ref" LabelText="Reference" /></div>
                <div class="col-md-6"><con:CodeField runat="server" ID="Type" DataBoundValue="TypeCode" LabelText="Type" CodeType="ORGT" /></div>
            </div>

            <div class="row">
                <div class="col-md-6"><con:CodeField runat="server" ID="Industry" DataBoundValue="IndustryCode" LabelText="Industry code" CodeType="IND" /></div>
                <div class="col-md-6"><con:ListField runat="server" ID="SellCompName" DataBoundValue="SellingCompanyId" DataBoundText="SellingCompany.Name" LabelText="Selling company" DisplayMember="Name" ValueMember="Id" Requirement="MandatoryEnforced" /></div>
             </div>
        </con:GroupBox>



        <%if (this.DataSource.PrincipalAddress.Id != null)
            { %>
        <con:GroupBox runat="server" Title="Address">
            <con:AddressDetail runat="server" Id="AddressDetail" DataBoundObject="PrincipalAddress" DataBoundId="PrincipalAddress.Id"/>
        </con:GroupBox>
        <% }
    else
    { %>
        <con:GroupBox runat="server" Title="Address">
            <div class="row">
                <div class="col-md-12">
                    <con:HiddenField ID="Id" runat="server" DataBoundValue="Id" />
                    <con:TextField runat="server" ID="AddressLine1" DataBoundValue="Userchar1" LabelText="Building" Requirement="MandatoryEnforced">                        
                    </con:TextField>
                </div>
            </div>
            <div class="row">
                <div class="col-md-12">
                    <con:TextField runat="server" ID="AddressLine2" DataBoundValue="Userchar2" LabelText="Street" />
                </div>
            </div>
            <div class="row">
                <div class="col-md-12">
                    <con:TextField runat="server" ID="AddressLine3" DataBoundValue="Userchar3" LabelText="Area" />
                </div>
            </div>
            <div class="row">
                <div class="col-md-12">
                    <con:TextField runat="server" ID="Town" DataBoundValue="Userchar4" LabelText="Town" />
                </div>
            </div>
            <div class="row">
                <div class="col-md-7">
                    <con:TextField runat="server" ID="County" DataBoundValue="Userchar5" LabelText="County" />
                </div>
                <div class="col-md-5">
                    <con:TextField runat="server" ID="Postcode" DataBoundValue="Userchar6" LabelText="Postcode" />
                </div>
            </div>
            <div class="row">
                <div class="col-md-12">
                    <con:ListField runat="server" ID="Countries" DataBoundValue="Userchar7" ValueMember="Name" LabelText="Country" DisplayMember="Name" />
                </div>
            </div>            
        </con:GroupBox>
        <%} %>
    </div>
    <div class="col-md-6">
        <con:GroupBox runat="server" Title="Contact information">
            <div class="row">
                <div class="col-md-6">
                    <con:TextField runat="server" ID="Telephone" DataBoundValue="Phone" LabelText="Phone" TextMode="Phone" HyperlinkUrl="tel:{text}" />
                </div>
                <div class="col-md-6">
                    <con:TextField runat="server" ID="Email" DataBoundValue="Email" LabelText="Email address" TextMode="Email" HyperlinkUrl="mailto:{text}" />
                </div>
            </div>

            <con:TextField runat="server" ID="Webite" DataBoundValue="Website" LabelText="Website" TextMode="Url" HyperlinkUrl="http://{text}" />
        </con:GroupBox>
        <con:GroupBox runat="server" Title="Additional information">
            <div class="row">
                <div class="col-md-6">
                    <con:CheckField runat="server" ID="Archived" DataBoundValue="Disabled" LabelText="Archived" />
                </div>
                <div class="col-md-6">
                    <con:CheckField runat="server" ID="OnHold" DataBoundValue="OnHold" LabelText="On hold" />
                </div>
            </div>
            <div class="row">
                <div class="col-md-6">
                    <con:CheckField runat="server" ID="OurOrg" DataBoundValue="OurOrg" LabelText="Our organisation" />
                </div>
                <div class="col-md-6">
                    <con:CheckField runat="server" ID="WebEnabled" DataBoundValue="WebEnabled" LabelText="Web enabled" />
                </div>
            </div>
        </con:GroupBox>
    </div>
</div>
