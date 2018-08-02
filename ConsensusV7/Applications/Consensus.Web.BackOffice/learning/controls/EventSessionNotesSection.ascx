<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="EventSessionNotesSection.ascx.cs" Inherits="Consensus.Web.BackOffice.learning.controls.EventSessionNotesSection" %>
<div>
    <div class="row">
        <div class="col-md-12">
            <con:TextField runat="server" ID="SessionNotes" DataBoundValue="NoteHtml" LabelText="Session Notes" TextMode="MultiLine" />
        </div>
    </div>
</div>

