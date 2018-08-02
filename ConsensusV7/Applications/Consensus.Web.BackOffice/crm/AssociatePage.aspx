<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="AssociatePage.aspx.cs" Inherits="Consensus.Web.BackOffice.crm.AssociatePage" MasterPageFile="~/assets/templates/StandardDetail.master" %>

<%@ Register TagPrefix="con" TagName="TrainerDetail" Src="~/crm/controls/TrainerDetail.ascx" %>
<%@ Register TagPrefix="con" TagName="TimeLogList" Src="~/crm/controls/TimeLogList.ascx" %>
<%@ Register TagPrefix="con" TagName="AssociateCourseList" Src="~/crm/controls/CourseList.ascx" %>
<%@ Register TagPrefix="con" TagName="TrainerNotesDetail" Src="~/crm/controls/TrainerNotesDetail.ascx" %>
<%@ Register TagPrefix="con" TagName="ProfileList" Src="~/crm/controls/ProfileList.ascx" %>

<asp:Content ContentPlaceHolderID="TopContent" runat="server">
    <con:TabControl runat="server" ID="TopTabControl">
        <pages>
            <con:TabPage runat="server" Title="Overview">      
                <con:TrainerDetail runat="server" ID="TrainerDetail" />         
            </con:TabPage>
            <con:TabPage runat="server" Title="Notes">      
                <con:TrainerNotesDetail runat="server" ID="TrainerNotesDetail" />         
            </con:TabPage>
        </pages>
    </con:TabControl>
</asp:Content>

<asp:Content ContentPlaceHolderID="BottomContent" runat="server">
    <con:TabControl runat="server" Mode="Simple" ID="BottomTabControl">
        <pages>
            <con:TabList runat="server" EnableCreation="true" Title="Time logs" >
                <con:TimeLogList runat="server" id="TimeLogList"/>
            </con:TabList>
              <con:TabList runat="server" EnableCreation="true" Title="Courses" >
                <con:AssociateCourseList runat="server" id="AssociateCourseList"/>
            </con:TabList>
            <con:TabList runat="server" Title="Profiles">
                <con:ProfileList runat="server" id="ProfileList" />
            </con:TabList>
        </pages>
    </con:TabControl>
</asp:Content>
