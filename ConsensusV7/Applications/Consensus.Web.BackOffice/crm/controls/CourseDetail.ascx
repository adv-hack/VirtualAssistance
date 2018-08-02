<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="CourseDetail.ascx.cs" Inherits="Consensus.Web.BackOffice.crm.controls.CourseDetail" %>
<div class="row">
    <div class="col-md-6">
        <con:HiddenField runat="server" ID="CourseId" DataBoundValue="Id" />
        <con:PopupField runat="server" ID="CourseName" DataBoundValue="ProductId" DataBoundText="Product.Name" LabelText="Course" Requirement="MandatoryEnforced" PopupUrl="~/learning/popups/productsearch.aspx?syProduct=1" HyperlinkUrl="~/learning/coursepage.aspx?id={id}" />
        <con:HiddenField runat="server" ID="TrainerId" DataBoundValue="TrainerId" />
    </div>
    <div class="col-md-6">
        <con:CodeField runat="server" ID="Status" DataBoundValue="Status" LabelText="Status" CodeType="TPXST" />
    </div>

    <div class="col-md-6">
        <con:DateField runat="server" ID="StartDate" DataBoundValue="StartDate" ValueMember="StartDate" LabelText="Start Date" />
    </div>
    <div class="col-md-6">
        <con:DateField runat="server" ID="EndDate" DataBoundValue="EndDate" ValueMember="EndDate" LabelText="End Date">
            <Validators>
                <con:Validator runat="server" ClientValidationFunction="validateDates" Critical="true" ErrorMessage="End date should not be earlier than the start date" />
            </Validators>
        </con:DateField>
    </div>
    <div class="col-md-6">
        <con:TextField runat="server" DataBoundValue="Cost" ID="Cost" TextMode="Number" LabelText="Cost" >            
         </con:TextField>
    </div>
    <div class="col-md-6">
        <con:CodeField runat="server" ID="Grade" DataBoundValue="Grade" LabelText="Grade" CodeType="TPXGR" />
    </div>
</div>

