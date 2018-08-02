<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="ProductPackDetail.ascx.cs" Inherits="Consensus.Web.BackOffice.document.controls.ProductPackDetail" %>
<div class="row">
    <div class="col-md-6">
        <con:CodeField runat="server" DataBoundValue="Type" ID="Type" LabelText="Type" CodeType="PACKT" Requirement="MandatoryEnforced"/>
        <con:PopupField runat="server" ID="Pack" DataBoundValue="PackId" DataBoundText="Pack.Name" LabelText="Pack" PopupUrl="~/document/popups/packsearch.aspx" Requirement="MandatoryEnforced">  
            <Filters>
                    <con:PopupFieldFilter ParameterName="PackType" Type="Value" Value="Booking" />
            </Filters>
         </Con:PopupField>     
        <con:CheckField runat="server" ID="Suppress" DataBoundValue="Suppress" LabelText="Suppress" />
    </div>
</div>