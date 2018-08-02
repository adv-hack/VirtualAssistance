<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="EventTeamDetail.ascx.cs" Inherits="Consensus.Web.BackOffice.learning.controls.EventTeamDetail" %>

<%@ Register TagPrefix="con" TagName="EventTeamSessionList" Src="~/learning/controls/EventTeamSessionList.ascx" %>

<con:TabControl runat="server">
    <pages>
        <con:TabPage ID="PersonDetailSection" runat="server" Title="Person">
            <div class="row">
                <div class="col-md-6">
                    <con:PopupField runat="server" ID="Person" DataBoundValue="PersonRole.PersonRoleId" LabelText="Name" PopupUrl="~/crm/popups/personsearch.aspx" HyperlinkUrl="~/crm/personpage.aspx?role={id}" Requirement="MandatoryEnforced">
                        <Filters>
                            <con:PopupFieldFilter ParameterName="org" Type="Control" Value="ClientOrg" />
                        </Filters>
                    </con:PopupField>
                </div>
                <div class="col-md-6">
                    <con:TextField runat="server" ID="JobTitle" DataBoundValue="JobTitle" LabelText="Job Title" />
                </div>
                <div class="col-md-6">
                    <con:PopupField runat="server" ID="ClientOrg" DataBoundValue="Organisation.OrganisationId" LabelText="Organisation" PopupUrl="~/crm/popups/organisationsearch.aspx" HyperlinkUrl="~/crm/organisationpage.aspx?id={id}" IsReadOnly="TrueEnforced" />
                </div>
                 <div class="col-md-6">
                    <con:CodeField runat="server" ID="EventRole" DataBoundValue="Trainer" LabelText="Event Role" CodeType="AREFT" />
                </div>
                <div class="col-md-3">
                    <con:TextField runat="server" ID="Cost" DataBoundValue="CstAc" LabelText="Cost" />
                </div>
                <div class="col-md-3">
                    <con:ListField runat="server" DataBoundValue="UntType" ID="UnitTypeList" LabelText="Per">
                        <Items>
                            <asp:ListItem Text="" Value="" />
                            <asp:ListItem Text="Hour" Value="H" />
                            <asp:ListItem Text="Day" Value="D" />
                        </Items>
                    </con:ListField>
                </div>
               
                <div class="col-md-6">
                    <con:CodeField runat="server" ID="AdminRole" DataBoundValue="Admin" LabelText="Admin Role" CodeType="AREFA" />
                </div>
                <div class="col-md-6">
                    <con:CheckField runat="server" DataBoundValue="Session" ID="Leader" LabelText="Leader" />
                </div>
            </div>
        </con:TabPage>

        <con:TabPage ID="SessionListSection" runat="server" Title="Session">
             <%-- <con:TabList runat="server" Title="Event Team" EnableCreation="false">
                         <con:EventTeamSessionList runat="server" ID="EventTeamSessionList" />
            </con:TabList>--%>
        </con:TabPage>

    </pages>

</con:TabControl>
