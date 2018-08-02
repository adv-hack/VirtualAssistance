<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="VolunteerPage.aspx.cs" Inherits="Consensus.Web.BackOffice.crm.VolunteerPage" MasterPageFile="~/assets/templates/StandardDetail.master" %>
<%@ Register TagPrefix="con" TagName="VolunteerDetail" Src="~/crm/controls/VolunteerDetail.ascx" %>
<%@ Register TagPrefix="con" TagName="TimeLogList" Src="~/crm/controls/TimeLogList.ascx" %>
<%@ Register TagPrefix="con" TagName="ProfileList" Src="~/crm/controls/ProfileList.ascx" %>
<%@ Register TagPrefix="con" TagName="TrainerNotesDetail" Src="~/crm/controls/TrainerNotesDetail.ascx" %>

<asp:Content ContentPlaceHolderID="TopContent" runat="server">
    <con:TabControl runat="server" id="TopTabControl">
        <pages>
            <con:TabPage runat="server" Title="Overview">      
                <con:VolunteerDetail runat="server" ID="VolunteerDetail" />         
            </con:TabPage>
            <con:TabPage runat="server" Title="Notes">      
                <con:TrainerNotesDetail runat="server" ID="TrainerNotesDetail" />         
            </con:TabPage>
        </pages>
    </con:TabControl>
</asp:Content>

<asp:Content ContentPlaceHolderID="BottomContent" runat="server">
    <con:TabControl runat="server" Mode="Simple" id="BottomTabControl">
        <pages>
            <con:TabList runat="server" EnableCreation="true" Title="Time logs" >
                <con:TimeLogList runat="server" id="TimeLogList"/>
            </con:TabList>
            <con:TabList runat="server" Title="Profiles">
                <con:ProfileList runat="server" id="ProfileList" />
            </con:TabList>
        </pages>
    </con:TabControl>
</asp:Content>
