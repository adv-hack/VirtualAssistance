<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="TrainerNotesDetail.ascx.cs" Inherits="Consensus.Web.BackOffice.crm.controls.TrainerNotesDetail" %>

<div class="row">
    <div class="col-md-12">
        <con:GroupBox runat="server" Title="Notes">
            <con:TextField runat="server" ID="FeeNotesText" TextMode="MultiLine" DataBoundText="FeeNotesText.Body" DataBoundValue="FeeNotesText.Body" LabelText="Fee notes" />
            <con:TextField runat="server" ID="HotelReqText" TextMode="MultiLine" DataBoundText="HotelReqText.Body" DataBoundValue="HotelReqText.Body" LabelText="Hotel requirements" />
            <con:TextField runat="server" ID="OtherInfoText" TextMode="MultiLine" DataBoundText="OtherInfoText.Body" DataBoundValue="OtherInfoText.Body" LabelText="Other information" />                        
        </con:GroupBox>
    </div>
</div>