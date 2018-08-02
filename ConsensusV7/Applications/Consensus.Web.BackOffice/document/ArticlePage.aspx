<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ArticlePage.aspx.cs" Inherits="Consensus.Web.BackOffice.document.ArticlePage" MasterPageFile="~/assets/templates/StandardDetail.master"  %>
<%@ Register TagPrefix="con" TagName="ArticleDetails" Src="~/document/controls/ArticleDetail.ascx" %>
<%@ Register TagPrefix="con" TagName="RelatedArticlesList" Src="~/document/controls/RelatedArticlesList.ascx" %>

<asp:Content ContentPlaceHolderID="TopContent" runat="server">
    <con:TabControl runat="server" id="TopTabControl">
        <Pages>
            <con:TabPage runat="server" Title="Overview">
                <con:ArticleDetails runat="server" ID="ArticleDetails" />
            </con:TabPage>
            
        </Pages>
    </con:TabControl>
</asp:Content>
<asp:Content ContentPlaceHolderID="BottomContent" runat="server">
     <con:TabControl runat="server" Mode="Simple" id="BottomTabControl">
        <Pages>       
             <con:TabList runat="server" Title="Related Articles" EnableCreation="true">
                <con:RelatedArticlesList runat="server" ID="RelatedArticlesList" />
            </con:TabList>     
        </Pages>
    </con:TabControl>
</asp:Content>
