<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="PortalUserDetail.ascx.cs" Inherits="Consensus.Web.BackOffice.crm.controls.PortalUserDetail" %>
<div class="row">
    <div class="col-lg-6 consensus-column">
        <con:GroupBox runat="server" Title="User details">
            <div class="row">
                <div class="col-md-12"><con:TextField runat="server" ID="LoginId" DataBoundValue="LoginId" LabelText="Username" Requirement="MandatoryEnforced"/></div>            
            </div>
            
            <div class="row">    
                <div class="col-md-6"><con:PopupField runat="server" ID="PersonRole" DataBoundValue="PersonRoleId" DataBoundText="PersonRole.PersonName" LabelText="Person" PopupUrl="~/crm/popups/personsearch.aspx" HyperlinkUrl="~/crm/personpage.aspx?role={id}" Requirement="MandatoryEnforced"/></div>
                <div class="col-md-6"><con:PopupField runat="server" ID="Organisation" DataBoundValue="PersonRole.OrganisationId" DataBoundText="PersonRole.Organisation.Name" LabelText="Organisation" PopupUrl="~/crm/popups/organisationsearch.aspx"  HyperlinkUrl="~/crm/organisation?id={id}" IsReadOnly="True"/></div>
            </div>
            
            <div class="row">
                <div class="col-md-6"><con:TextField runat="server" ID="Id" DataBoundValue="Id" LabelText="ID" IsReadOnly="True"/></div>
                <div class="col-md-6"><con:ListField runat="server" ID="SellingCompany" DataBoundValue="SellingCompanyId" DataBoundText="SellingCompany.Name" LabelText="Selling Company" DisplayMember="Name" ValueMember="Id" Requirement="MandatoryEnforced" /></div>
            </div>
        </con:GroupBox>
    </div>

    <div class="col-lg-6 consensus-column"> 
        <con:GroupBox runat="server" Title="Account information">
            <div class="row">
                <div class="col-md-6"><con:ListField runat="server" ID="Status" DataBoundValue="Barred" LabelText="Status" DisplayMember="Text" ValueMember="Id" Requirement="MandatoryEnforced">
                    <Items>
                       <asp:ListItem Text="Active" Value="0" />
                       <asp:ListItem Text="Barred" Value="1" />
                       <asp:ListItem Text="Pending" Value="3" />
                    </Items>
                </con:ListField></div>
                <div class="col-md-6"><con:TextField runat="server" ID="AuthProvider" LabelText="Authentication Method" IsReadOnly="True"/></div>
            </div>
            
            <div class="row">
                <div class="col-md-6"><con:TextField runat="server" ID="FirstLogin" LabelText="First Login" IsReadOnly="True" /></div>
                <div class="col-md-6"><con:TextField runat="server" ID="LastLogin" LabelText="Last Login" IsReadOnly="True" /></div>
            </div>
        </con:GroupBox>
    </div>  
    <con:HiddenField runat="server" DataBoundValue="Id" ID="PortalUserId" />
</div>
<con:Validator runat="server" ClientValidationFunction="CheckIfUsernameExist" ErrorMessage="" />
<script type="text/javascript">
    function CheckIfUsernameExist(source, args) {
        consensus.network.send({
            async: false,
            method: 'post',
            url: 'portal/portaluser/CheckIfUsernameExist?name=' + $('#<%=this.LoginId.ClientID%>Field').val()+ '&userId=' + $('#<%= this.PortalUserId.ClientID %>Field').val(),
            success: function (result) {
                if (result) {
                    args.IsValid = !result;
                    source.errormessage="Username already exists."
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

