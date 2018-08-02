<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="PackEmailDetail.ascx.cs" Inherits="Consensus.Web.BackOffice.document.controls.PackEmailDetail" %>

<div class="row">
    <div class="col-md-12">
        <con:GroupBox runat="server" Title="Email message">
            <con:HiddenField runat="server" ID="PackId" DataBoundValue="Id" />
            <con:ListField runat="server" ID="SubjectMerge" LabelText="Subject merge fields" ClientOnChange="SubjectMergeFieldChanged()" />
            <con:TextField runat="server" ID="SubjectField" DataBoundValue="EmailSubject" LabelText="Subject" />
            <con:ListField runat="server" ID="BodyMerge" LabelText="Body merge fields" ClientOnChange="BodyMergeFieldChanged()" />            
            <con:HtmlTextField runat="server" DataBoundValue="PackEmailBody.Html" ID="Body" LabelText="Body" Height="220px" />    
        </con:GroupBox>
    </div>
</div>

<script type="text/javascript">    

    function InsertText(originalField, mergedField) {
        var value = originalField.val();
        originalField.val(value + " " + "[[" + mergedField.val() + "]]");        
    }

    function SubjectMergeFieldChanged() {
        InsertText($('#<%= this.SubjectField.ClientID %>Field'), $('#<%= this.SubjectMerge.ClientID %>Field'));
    }

    function BodyMergeFieldChanged() {               
        var originalField = $('#<%= this.Body.ClientID %>Field');
        var value = originalField.val();
        var mergedField = $('#<%= this.BodyMerge.ClientID %>Field');
        originalField.summernote("code", value + " " + "[[" + mergedField.val() + "]]");        
    }
    
</script>
