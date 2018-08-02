<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="RoleDetail.ascx.cs" Inherits="Consensus.Web.BackOffice.crm.controls.RoleDetail" %>

<div class="row">
    <div class="col-lg-6 consensus-column"> 
        <con:GroupBox runat="server" Title="Job details">
            <div class="row">
                <div class="col-md-6"><con:CodeField runat="server" ID="Type" DataBoundValue="TypeCode" LabelText="Role type" CodeType="ROLE"/></div>
                <div class="col-md-6"><con:CodeField runat="server" ID="JobType" DataBoundValue="JobTypeCode" LabelText="Job type" CodeType="ROLET"/></div>
            </div>

            <div class="row">
                <div class="col-md-6"><con:CodeField runat="server" ID="JobLevel" DataBoundValue="JobLevelCode" LabelText="Job level" CodeType="ATRJL"/></div>
                <div class="col-md-6"><con:CodeField runat="server" ID="CostCode" DataBoundValue="CostCodeCode" LabelText="Cost code" CodeType="COST"/></div>

            </div>
            
            <div class="row">
                <div class="col-md-6"><con:TextField runat="server" ID="Payroll" DataBoundValue="Payroll" LabelText="Payroll number" /></div>
                <div class="col-md-6"><con:TextField runat="server" ID="StaffNo" DataBoundValue="StaffNo" LabelText="Staff number" /></div>                
            </div>
            
            <div class="row">
                <div class="col-md-6"><con:CodeField runat="server" ID="UnionRolNo" DataBoundValue="UnionRolNoCode" LabelText="Expenditure code" CodeType="EXPCD"/></div>
                <div class="col-md-6"><con:TextField runat="server" ID="HourlyRate" DataBoundValue="HourlyRate" LabelText="Hourly rate" /></div>
            </div>
        </con:GroupBox>
    </div>


    <div class="col-lg-6 consensus-column"> 
        <con:GroupBox runat="server" Title="Role information">
            <div class="row">
                <div class="col-md-6"><con:DateField runat="server" DataBoundValue="StartDate" ID="StartDate" LabelText="Start date" /></div>
                <div class="col-md-6"><con:DateField runat="server" DataBoundValue="EndDate" ID="EndDate" LabelText="End date" /></div>
            </div>

            <div class="row">
                <div class="col-md-6"><con:CheckField runat="server" DataBoundValue="IsPrincipal" ID="Principal" LabelText="Main role" /></div>
                <div class="col-md-6"><con:CheckField runat="server" DataBoundValue="KeyContact" ID="KeyContact" LabelText="Key contact" /></div>
            </div>

            <div class="row">
                <div class="col-md-6"><con:CheckField runat="server" DataBoundValue="IsRoleDisabled" ID="Disabled" LabelText="Archived" /></div>
                <div class="col-md-6"><con:ListField runat="server" ID="SellCompName" DataBoundValue="SellingCompanyId" DataBoundText="SellingCompany.Name" LabelText="Selling company" DisplayMember="Name" ValueMember="Id" Requirement="MandatoryEnforced" /></div>
            </div>
        </con:GroupBox>
    </div>
</div>

