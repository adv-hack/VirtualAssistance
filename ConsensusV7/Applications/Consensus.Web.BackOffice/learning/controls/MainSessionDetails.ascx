<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="MainSessionDetails.ascx.cs" Inherits="Consensus.Web.BackOffice.learning.controls.MainSessionDetails" %>

<div class="row">
    <div class="col-lg-6 consensus-column"> 
        <con:GroupBox runat="server" Title="Basic Details">
          <con:PopupField runat="server" ID="SessionProduct" DataBoundValue="MainSession.childProductId" DataBoundText="MainSession.ChildProduct.Name" LabelText="Session" PopupUrl="~/learning/popups/productsearch.aspx?syProduct=1" HyperlinkUrl="~/learning/coursepage.aspx?id={MainSession.ChildProduct.id}"  Requirement="MandatoryEnforced" IsReadOnly="False"/>
               
          <div class="row">
            <div class="col-md-6"><con:TextField runat="server" ID="StartDay" DataBoundValue="MainSession.StartDay" LabelText="Start Day" TextMode="Number"/></div>
            <div class="col-md-6"><con:TimeField runat="server" ID="StartTime" DataBoundValue="MainSession.StartTime" LabelText="Start Time"/></div>
          </div>
          <div class="row">
            <div class="col-md-6"><con:TextField runat="server" ID="EndDay" DataBoundValue="MainSession.EndDay" LabelText="End Day" TextMode="Number"/></div>
            <div class="col-md-6"><con:TimeField runat="server" ID="EndTime" DataBoundValue="MainSession.EndTime" LabelText="End Time"/></div>
          </div>

        <con:ListField runat="server" ID="RoomLayout" DataBoundValue="MainSession.RoomLayout" LabelText="Room Layout" >
            <Items>
                <asp:ListItem Text="Standard Style" Value="0" />
                <asp:ListItem Text="Theatre" Value="1" />
                <asp:ListItem Text="Informal" Value="2" />
                <asp:ListItem Text="Classroom" Value="3" />
                <asp:ListItem Text="Other" Value="4" />
            </Items>
         </con:ListField>
        <con:TextField runat="server" ID="Notes" DataBoundValue="MainSession.ActNote" LabelText="Notes" TextMode="MultiLine" />
        </con:GroupBox>
    </div>
    <div class="col-lg-6 consensus-column">
        <con:GroupBox runat="server" Title="Session Configuration">
        <div class="row"><div class="col-md-6">
        <con:ListField runat="server" ID="Mandatory" DataBoundValue="MainSession.Mandatory" LabelText="Mandatory" IsReadOnly="true">
            <Items>
                <asp:ListItem Text="No" Value="0" />
                <asp:ListItem Text="Yes" Value="1" />
                <asp:ListItem Text="Recommended" Value="2" />
            </Items>
         </con:ListField>
        </div>
            <div class="col-md-6"><con:CheckField runat="server" DataBoundValue="MainSession.Chargeable" ID="Chargeable" LabelText="Chargeable" /></div>
          </div>

           <div class="row">
            <div class="col-md-6"><con:CheckField runat="server" DataBoundValue="MainSession.ShowSales" ID="ShowSales" LabelText="Show on Booking" IsReadOnly="true"/></div>
            <div class="col-md-6"><con:CheckField runat="server" DataBoundValue="MainSession.ShowAttLog" ID="ShowAttLog" LabelText="Show on Attendance Log" /></div>
          </div>           

        </con:GroupBox>
    </div>
</div>

