<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="TrainerDetail.ascx.cs" Inherits="Consensus.Web.BackOffice.crm.controls.TrainerDetail" %>

<div class="row">
    <div class="col-md-6">
        <con:GroupBox runat="server" Title="Associate details">
            <div class="row">
                <div class="col-md-12">
                    <con:PopupField runat="server" ID="Name" DataBoundValue="RoleId" DataBoundText="Role.PersonName" LabelText="Name" PopupUrl="~/crm/popups/PersonSearch.aspx" HyperlinkUrl="~/crm/PersonPage.aspx?role={id}" Requirement="MandatoryEnforced" ClientOnChange="CheckIfPersonIsAssociatedWithTrainer()" />
                </div>
            </div>
            <div class="row">
                <div class="col-md-6">
                    <con:CodeField runat="server" ID="Status" DataBoundValue="StatusCode" LabelText="Status" CodeType="TRSTA" Requirement="MandatoryEnforced" />
                </div>
                <div class="col-md-6">
                    <con:DateField runat="server" DataBoundValue="AinStartDate" ID="StartDate" LabelText="Start date" />
                </div>
            </div>
            <div class="row">
                <div class="col-md-6">
                    <con:DateField runat="server" DataBoundValue="AinReviewDate" ID="ReviewDate" LabelText="Review date" />
                </div>
                <div class="col-md-6">
                    <con:DateField runat="server" DataBoundValue="AinInsExpiry" ID="Insurance" LabelText="Indemnity insurance expiry" />
                </div>
            </div>
            <div class="row">
                <div class="col-md-6">
                    <con:CheckField runat="server" ID="WebEnabled" LabelText="Web enabled" />
                </div>
                <div class="col-md-6">
                    <con:ListField runat="server" ID="SellingCompany" DataBoundValue="SellingCompanyId" DataBoundText="SellingCompany.Name" LabelText="Selling company" DisplayMember="Name" ValueMember="Id" Requirement="MandatoryEnforced" />
                </div>
            </div>
            <con:HiddenField runat="server" ID="Web" DataBoundValue="AinWeb" />
            <con:HiddenField runat="server" ID="SyType" DataBoundValue="AinSyType" />
            <con:HiddenField runat="server" ID="TrainerId" DataBoundValue="Id" />
            <con:HiddenField runat="server" ID="AinAddBy" DataBoundValue="AinAddBy" />
            <con:HiddenField runat="server" ID="AinModBy" DataBoundValue="AinModBy" />
            <con:HiddenField runat="server" ID="AinBasePostcode" DataBoundValue="AinBasePostcode" />
        </con:GroupBox>
    </div>
    <div class="col-md-6">
        <con:GroupBox runat="server" Title="Associate information">
            <div class="row">
                <div class="col-md-6">
                    <con:TextField runat="server" ID="Reference" DataBoundValue="AinRef" LabelText="Reference" />
                </div>
                <div class="col-md-6">
                    <con:CodeField runat="server" ID="Type" DataBoundValue="Attribute01Code" LabelText="Type" CodeType="TRAn1" />
                </div>
            </div>
            <div class="row">
                <div class="col-md-6">
                    <con:TextField runat="server" TextMode="Number" ID="DayCost" DataBoundValue="AinDayCost" LabelText="Daily cost">                        
                    </con:TextField>
                </div>
                <div class="col-md-6">
                    <con:TextField runat="server" TextMode="Number" ID="HourCost" DataBoundValue="AinHourCost" LabelText="Hourly cost">                        
                    </con:TextField>
                </div>
            </div>
        </con:GroupBox>
    </div>
</div>
<div class="row">
    <div class="col-md-12">
        <con:GroupBox runat="server" Title="Biography">
            <con:HtmlTextField runat="server" DataBoundValue="AinBiog" ID="Biography" LabelText="Biography" Height="220px" />
        </con:GroupBox>
    </div>
</div>


<con:Validator runat="server" ClientValidationFunction="UpdateWebEnabled" ErrorMessage="" />

<script type="text/javascript">

    function UpdateWebEnabled(source, args) {
        if ($('#<%= this.WebEnabled.ClientID %>Field').is(':checked')) {
            $('#<%= this.Web.ClientID %>Field').val(1);
        }
        else {
            $('#<%= this.Web.ClientID %>Field').val(0);
        }
    }

    function CheckIfPersonIsAssociatedWithTrainer() {
        if( $('#<%= this.Name.ClientID %>Value').val()){
            consensus.network.send({
                async: false,
                method: 'post',
                url: 'contact/trainer/CheckIfPersonIsAssociatedWithTrainer?proleId=' + $('#<%= this.Name.ClientID %>Value').val() + '&trainerId=' + $('#<%= this.TrainerId.ClientID %>Field').val() +'&syType='+ $('#<%= this.SyType.ClientID %>Field').val(),
                success: function (response) {
                    if (response) {
                        swal({ title: 'Error', text: 'This person is already an associate.', type: 'error', showCancelButton: false, confirmButtonText: 'Ok', confirmButtonClass: 'btn btn-danger', buttonsStyling: false }).then(function (success) {
                            <%= this.Name.ClientID %>.setValue(null, null);                        
                        });                    
                    }
                    else {      
                        var data= window['<%= this.Name.ClientID %>'].getData();
                        if(data && data.address && data.address.postcode){
                            $('#<%= this.AinBasePostcode.ClientID %>Field').val(data.address.postcode);
                        }
                    }
                },
                error: function (request) {
                }
            });
        }
    }

</script>


