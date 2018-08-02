<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="ArticleDetail.ascx.cs" Inherits="Consensus.Web.BackOffice.document.controls.ArticleDetail" %>
<div class="row">
    <div class="col-md-6">
         <con:GroupBox runat="server" Title="Article details">  
                 
            <div class="row">
              <div class="col-md-12"><con:TextField runat="server" ID="Name" DataBoundValue="Name" LabelText="Name" Requirement="MandatoryEnforced" /></div>
          </div>
            <div class="row">
                <div class="col-md-12"><con:TextField runat="server" ID="Keywords" DataBoundValue="Keywords" LabelText="Keywords" Requirement="MandatoryEnforced" /></div>
            </div>
            <div class="row">
                <div class="col-md-12"><con:TextField runat="server" ID="Image" DataBoundValue="Image" LabelText="Image" Requirement="MandatoryEnforced" /></div>
            </div>
            <div class="row">
                <div class="col-md-6">
                    <con:ListField runat="server" ID="Status" DataBoundValue="State" LabelText="Status">
                        <Items>
                            <%--<asp:ListItem Text="Select" Value="" />--%>
                            <asp:ListItem Text="Planning" Value="0" />
                            <asp:ListItem Text="Current" Value="1" />
                            <asp:ListItem Text="Cancelled" Value="2" />
                        </Items>
                    </con:ListField>
                </div>

                <div class="col-md-6">
                    <con:ListField runat="server" ID="artiType" DataBoundValue="Type" LabelText=" Article type">
                        <Items>
                            <%--<asp:ListItem Text="Select" Value="" />--%>
                            <asp:ListItem Text="Standard Article" Value="0" />
                            <asp:ListItem Text="News Article" Value="1" />
                        </Items>
                    </con:ListField>
                </div>
            </div>
            <div class="row">
              <div class="col-md-6">
                    <con:ListField runat="server" ID="webEnabled" DataBoundValue="Web" LabelText="Web enabled">
                        <Items>
                            <%--<asp:ListItem Text="Select" Value="" />--%>
                            <asp:ListItem Text="Not Enabled" Value="0" />
                            <asp:ListItem Text="Web Enabled" Value="1" />
                            <asp:ListItem Text="Published" Value="2" />
                        </Items>
                    </con:ListField>
                </div>
             <div class="col-md-6"><con:CheckField  runat="server" ID="Featured" DataBoundValue="Featured" LabelText="Featured" /></div>
             
          </div>  
            <div class="row">
                 <div class="col-md-6"><con:TextField runat="server" ID="viewCount" DataBoundValue="" IsReadOnly="TrueEnforced" LabelText="Portal viewed"/></div>
             </div>        
           
        </con:GroupBox>
    </div>

     <div class="col-md-6">
        <con:GroupBox runat="server" Title="Article configuration">
            <div class="row">
                <div class="col-md-6"><con:DateField runat="server" ID="createdDate" DataBoundValue="AddDate" IsReadOnly="TrueEnforced" LabelText="Created date" /></div>
                <div class="col-md-6"><con:CodeField runat="server" ID="area" DataBoundValue="ArtAreaCode" LabelText="Area" CodeType="ARTAR" /></div>
            </div>
            <div class="row">
                <div class="col-md-6"><con:CodeField runat="server" ID="group" DataBoundValue="ArtGroupCode" LabelText="Group" CodeType="ARTGR" /></div>
                <div class="col-md-6"><con:CodeField runat="server" ID="category" DataBoundValue="ArtCategoryCode" LabelText="Category" CodeType="ATRCA" /></div>
            </div>
        </con:GroupBox>
    </div>
</div>


    <div class="row">
    <div class="col-md-12">
        <con:GroupBox runat="server" Title="Article summary">
            <con:HtmlTextField runat="server" DataBoundValue="SummaryHtml" ID="HtmlTextField1" LabelText="" Height="220px" />
        </con:GroupBox>
    </div>
</div>

    <div class="row">
    <div class="col-md-12">
        <con:GroupBox runat="server" Title="Article description">
            <con:HtmlTextField runat="server" DataBoundValue="NotesHtml" ID="HtmlTextField2" LabelText="" Height="220px" />
        </con:GroupBox>
    </div>
</div>
<con:HiddenField runat="server" ID="ArticleId" DataBoundValue="Id" />

<script type="text/javascript">
    $(document).ready(function () {
        
        var loggedUser = $('#Content_loggedUser').val()
        var viewLogObj = {
            Table: 'ARTICLE',
            RecId: $('#<%= this.ArticleId.ClientID %>Field').val(),
            Source: "0"
        };
        consensus.network.send({
           
            method: 'post',
            data: viewLogObj,
            url: 'common/viewlog',
            success: function (response) {
                
            }
        });
    });
</script>