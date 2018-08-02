<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="SessionTemplateDetails.ascx.cs" Inherits="Consensus.Web.BackOffice.learning.controls.SessionDetails" %>
<con:HiddenField runat="server" ID="Id" DataBoundValue="Id" />
<div class="row">
    <div class="col-6"> 
        <con:GroupBox runat="server" Title="Basic Details">
          <div class="row">
            <div class="col-md-12">
              <con:PopupField runat="server" ID="Product" DataBoundValue="childProductId" DataBoundText="ChildProduct.Name" LabelText="Session" PopupUrl="~/learning/popups/productsearch.aspx?syProduct=1" HyperlinkUrl="~/learning/coursepage.aspx?id={ChildProduct.id}"  Requirement="MandatoryEnforced" IsReadOnly="False"/>
            </div>
          </div>
          <div class="row">
            <div class="col-md-6"><con:TextField runat="server" ID="StartDay" DataBoundValue="StartDay"  Requirement="MandatoryEnforced" LabelText="Start Day" TextMode="Number"/></div>
            <div class="col-md-6"><con:TimeField runat="server" ID="StartTime" DataBoundValue="StartTime" LabelText="Start Time" /></div>
          </div>
          <div class="row">
            <div class="col-md-6"><con:TextField runat="server" ID="EndDay" DataBoundValue="EndDay" Requirement="MandatoryEnforced" LabelText="End Day" TextMode="Number"/></div>
            <div class="col-md-6"><con:TimeField runat="server" ID="EndTime" DataBoundValue="EndTime" LabelText="End Time"/></div>
          </div>
          <div class="row">
            <div class="col-md-12">
                <con:ListField runat="server" ID="RoomLayout" DataBoundValue="RoomLayout" LabelText="Room Layout" >
                    <Items>
                        <asp:ListItem Text="Standard Style" Value="0" />
                        <asp:ListItem Text="Theatre" Value="1" />
                        <asp:ListItem Text="Informal" Value="2" />
                        <asp:ListItem Text="Classroom" Value="3" />
                        <asp:ListItem Text="Other" Value="4" />
                    </Items>
                 </con:ListField>
              </div>
            </div>
        </con:GroupBox>
    </div>

    <div class="col-6">
        <con:GroupBox runat="server" Title="Session Configuration">
          <div class="row">
            <div class="col-md-6"><con:CheckField runat="server" DataBoundValue="MainSession" ID="MainSession" LabelText="Main Session" ClientOnChange="checkMainSession()" IsReadOnly="false" /></div>
            <div class="col-md-6">
            <con:ListField runat="server" ID="Mandatory" DataBoundValue="Mandatory" Requirement="MandatoryEnforced" LabelText="Mandatory" ClientOnChange="checkMainSession()" IsReadOnly="false" >
                <Items>
                    <asp:ListItem Text="No" Value="0" />
                    <asp:ListItem Text="Yes" Value="1" />
                    <asp:ListItem Text="Recommended" Value="2" />
                </Items>
             </con:ListField>
                <con:HiddenField runat="server" ID="Real" DataBoundValue="Real" />
                <con:HiddenField runat="server" ID="Session" DataBoundValue="Session" />
                <con:HiddenField runat="server" ID="Element" DataBoundValue="Element" />
            </div>
        </div>
          <div class="row">
            <div class="col-md-6"><con:CheckField runat="server" DataBoundValue="Chargeable" ID="Chargeable" LabelText="Chargeable" /></div>
            <div class="col-md-6"><con:ListField runat="server" DataBoundValue="PsgIdId" ID="SelectGroup" LabelText="Selection group" ValueMember="Id" DisplayMember="Name" /></div>
          </div>
           <div class="row">
            <div class="col-md-6"><con:CheckField runat="server" DataBoundValue="ShowSales" ID="ShowSales" LabelText="Show on Booking" ClientOnChange="checkMainSession()" IsReadOnly="false"/></div>
            <div class="col-md-6"><con:CheckField runat="server" DataBoundValue="ShowAttLog" ID="ShowAttLog" LabelText="Show on Attendance Log" /></div>
          </div>           

        </con:GroupBox>
    </div>
</div>
<div class="row">
  <div class="col-md-12">
    <con:TextField runat="server" ID="Notes" DataBoundValue="ActNote" LabelText="Notes" TextMode="MultiLine" />
  </div>
</div>
<script>
  $(document).ready(function () {
    SetReadOnly();
  });
  function SetReadOnly() {
    var mainSession = $('#<%= this.MainSession.ClientID %>Field').prop("checked");

    $('#<%= this.Mandatory.ClientID %>Field').attr('readonly', mainSession ? 'readonly' : null).attr('disabled', mainSession ? 'disabled' : null);
    $('#<%= this.ShowSales.ClientID %>Field').bootstrapSwitch("disabled", mainSession ? true : false).bootstrapSwitch("readonly", mainSession ? true : false);
    $('#<%= this.MainSession.ClientID %>Field').bootstrapSwitch("disabled", mainSession ? true : false).bootstrapSwitch("readonly", mainSession ? true : false);

    checkMainSession()
  }

  function checkMainSession() {
    var mainSession = $('#<%= this.MainSession.ClientID %>Field').prop("checked");

    if (mainSession) {
      $('#<%= this.Mandatory.ClientID %>Field').val('1');
      $('#<%= this.ShowSales.ClientID %>Field').bootstrapSwitch("state", true);

    }

  }
</script>