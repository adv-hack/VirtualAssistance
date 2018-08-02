<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="TemplateDetails.ascx.cs" Inherits="Consensus.Web.BackOffice.learning.controls.TemplateDetails" %>
<%@ Register TagPrefix="con" TagName="SessionDetails" Src="~/learning/controls/SessionTemplateDetails.ascx" %>
<%@ Register TagPrefix="con" TagName="TrainersList" Src="~/learning/controls/TrainersTemplateList.ascx" %>
<%@ Register TagPrefix="con" TagName="RoomsList" Src="~/learning/controls/RoomsTemplateList.ascx" %>
<%@ Register TagPrefix="con" TagName="ResourcesList" Src="~/learning/controls/ResourcesTemplateList.ascx" %>

<con:TabControl runat="server">
    <Pages>
        <con:TabPage id="SessionDetailSection" runat="server" Title="Session">
            <con:SessionDetails runat="server" id="SessionDetails" />                  
        </con:TabPage>
        <con:TabPage id="TrainersListSection" runat="server" Title="Trainers">
            <con:TrainersList runat="server" id="TrainersList" DataBoundValue="Trainers"/>               
        </con:TabPage>
        <con:TabPage id="RoomsListSection" runat="server" Title="Rooms">
             <con:RoomsList runat="server" id="RoomsList" DataBoundValue="Rooms"/>               
        </con:TabPage>
        <con:TabPage id="ResourcesListSection" runat="server" Title="Resources">
            <con:ResourcesList runat="server" id="ResourcesList" DataBoundValue="Resources"/>               
        </con:TabPage>            
    </Pages>
</con:TabControl>

