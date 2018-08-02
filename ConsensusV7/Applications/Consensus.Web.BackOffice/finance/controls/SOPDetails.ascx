<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="SOPDetails.ascx.cs" Inherits="Consensus.Web.BackOffice.finance.controls.SOPDetails" %>
<style>
    textarea{
        height: 99px !important;
    }
</style>
<con:GroupBox runat="server" Title="Sales Order Processing">
    <div class="row">
        <div class="col-md-4"> 
            <con:ListField runat="server" ID="SOPStatus" DataBoundValue="SOPStatus" LabelText="SOP Status" ClientOnChange="calculateSOPDate()" >
               <Items>
                    <asp:ListItem Text="00-Not Processed" Value="00-Not Processed" />
                    <asp:ListItem Text="10-Processed" Value="10-Processed" />
                </Items>
             </con:ListField>
            <con:TextField runat="server" ID="SOPModBy" DataBoundValue="SOPModBy" LabelText="SOP Mod By" IsReadOnly="true" />
            <con:HiddenField runat="server" ID="LoggedOnUser"/>
        </div>
        <div class="col-md-4"> 
            <con:TextField runat="server" ID="SOPRef" DataBoundValue="SOPRef" LabelText="SOP Ref" ClientOnChange="calculateSOPDate()" />
            <con:DateField runat="server" ID="SOPModDate" DataBoundValue="SOPModDate" LabelText="SOP Mod Date" IsReadOnly="true" />
        </div>
        <div class="col-md-4" id="Note"> 
            <con:TextField runat="server" ID="SOPNotes" DataBoundValue="SOPNotes" LabelText="Notes" TextMode="MultiLine" ClientOnChange="calculateSOPDate()" />
        </div>
    </div>
</con:GroupBox>
<script type="text/javascript">

    $(document).ready(function () {
        //disable the calendar on readonly datepickers
        var modDatecontrol = '#' + '<%=this.SOPModDate.ClientID%>' + 'Group';
           $(modDatecontrol).datepicker({ enableOnReadonly: false });
        });
    

    function calculateSOPDate() {   
        var today = new Date();
        $('#<%= this.SOPModDate.ClientID %>Group').datepicker('setDate', new Date());

        $('#<%= this.SOPModBy.ClientID %>Field').val(('<%= this.LoggedOnUser.FieldValue %>'));
    }
</script>