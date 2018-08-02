<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="RelatedArticleDetail.ascx.cs" Inherits="Consensus.Web.BackOffice.document.controls.RelatedArticleDetail" %>
<div class="row">
    <con:HiddenField ID="ArtiId" runat="server" DataBoundValue="ArtiId"></con:HiddenField>  
    <con:HiddenField ID="RelatedArticleId" runat="server" DataBoundValue="RelArticle.Id"  FieldValue="RelArticle.Id"></con:HiddenField>  
    <con:HiddenField ID="ArticleXrefId" runat="server" DataBoundValue="Id"></con:HiddenField>  
    <div class="col-md-6">
        <con:PopupField runat="server" ID="ArticleName" DataBoundValue="RelArticleId" DataBoundText="RelArticle.Name" LabelText="Name" PopupUrl="~/document/popups/relatedarticlessearch.aspx?" HyperlinkUrl="" Requirement="MandatoryEnforced" />
    </div>   
</div>
<div class="row">
    <div class="col-md-12"><con:TextField runat="server" DataBoundValue="RelArticle.Summary" DataBoundText="RelArticle.Summary" ID="ArticleSummary" LabelText="Summary" TextMode="MultiLine" IsReadOnly="True" /></div>
</div>
<con:Validator runat="server" ClientValidationFunction="CheckIfRelatedArticleExists" ErrorMessage="" />
<script type="text/javascript">
    function CheckIfRelatedArticleExists(source, args) {
        consensus.network.send({
            async: false,
            method: 'post',
            url: 'document/Articlexref/CheckIfRelatedArticleExist?articleId=' + $('#<%=this.ArtiId.ClientID%>Field').val() + '&relatedArticleId=' + $('#<%=this.RelatedArticleId.ClientID%>Field').val() + '&articleXrefId=' + $('#<%=this.ArticleXrefId.ClientID%>Field').val(),
            success: function (response) {
                if (response) {
                    args.IsValid = !response;
                    source.errormessage = "This article is already linked.";
                }
                else {
                    source.errormessage = "";
                }
            },
            error: function (request) {

            }
        });
    }
</script>