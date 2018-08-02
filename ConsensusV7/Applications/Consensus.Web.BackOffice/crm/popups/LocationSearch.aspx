<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="LocationSearch.aspx.cs" Inherits="Consensus.Web.BackOffice.crm.popups.LocationSearch" MasterPageFile="~/assets/templates/PopupSearch.master" Title="Locations Search"%>

<asp:Content ContentPlaceHolderID="SearchFields" runat="server">
  <div class="row">
    <%--<div class="col-sm-2"><con:TextField runat="server" ID="PersonID" LabelText="Person ID" IsEditable="true" ValueUrlParameter="personID" ValueUrlIsEnforced="false" /></div>--%>
    <div class="col-sm-2"><con:TextField runat="server" ID="LocRef" LabelText="Location Reference" IsEditable="true" ValueUrlParameter="LocationReference" ValueUrlIsEnforced="false" /></div>
    <div class="col-sm-3"><con:TextField runat="server" ID="LocName" LabelText="Location Name" IsEditable="true" ValueUrlParameter="personSurname" ValueUrlIsEnforced="false" /></div>
    <div class="col-sm-3"><con:TextField runat="server" ID="Organisation" LabelText="Organisation" IsEditable="true" ValueUrlParameter="orgText" ValueUrlIsEnforced="false" /></div>
    <div class="col-sm-3"><con:TextField runat="server" ID="Town" LabelText="Town" IsEditable="true" ValueUrlParameter="town" ValueUrlIsEnforced="false" /></div>
    <%--<div class="col-sm-3"><con:TextField runat="server" ID="ActiveLocation" LabelText="Active Location" IsEditable="true" ValueUrlParameter="activeLocation" /></div>--%>
       <div class="col-sm-2">
                <con:ListField runat="server" ID="ActiveLocation" LabelText="Active Location" IsEditable="True" ValueUrlParameter="activeLocation">
                    <Items>
                        <asp:ListItem Text="Active" Value="1" />
                        <asp:ListItem Text="All" Value="0" />
                    </Items>
                </con:ListField>
            </div>
    <div class="col-sm-2"><con:CodeField runat="server" ID="LocType" LabelText="Venue Type" CodeType="VNTYP" IsEditable="true"  /></div>
    <div class="col-sm-1"><asp:Button runat="server" ID="Button1" CssClass="btn btn-primary" Text="Search" style="margin-top: 37px" OnClick="SearchButton_Click" /></div>
  </div>
  
</asp:Content>
<asp:Content ContentPlaceHolderID="SearchResult" runat="server">
    <!-- CanCreate="true" CanCreateInEditMode="true" Url="~/GenericPopup.aspx?context=crm&control=newpersondetail" -->
  <con:DataTable runat="server" ID="SearchResult" PageLength="10" CanModify="false" CanRemove="false"> 
    <Columns>
      <con:DataTableTextColumn FieldName="LOC_REF" Title=" Location Ref" /> 
      <con:DataTableTextColumn FieldName="LOC_NAME" Title="Location Name " />
      <con:DataTableTextColumn FieldName="ORG_NAME" Title="Organisation" />
        <con:DataTableTextColumn FieldName="ADD_TOWN" Title="Town" />
        <con:DataTableIconColumn FieldName="LOC_ACTIVE"   Title="Active Location" />
        <con:DataTableTextColumn FieldName="LOC_VENUE_TYPE" Title="Venue Type" />
      <con:DataTableLinkColumn LinkHref="javascript: closePopup({ command: 'select', text: '{{LOC_NAME}}', value: '{{LOC_ID}}', data: { loc_id: '{{LOC_ID}}', contact:{prole_id:'{{LOC_PROLE_ID}}', prole_name:'{{PROLE_PN_NAME}}'}, organisation: { id: '{{LOC_ORG_ID}}', name: '{{ORG_NAME}}'}, address: { add_id: '{{LOC_ADD_ID}}', add_mailstring: '{{ADD_MAILSTRING}}', addressLine1: '{{ADD_BUILDING}}', addressLine2: '{{ADD_STREET}}', addressLine3: '{{ADD_AREA}}', town: '{{ADD_TOWN}}', county: '{{ADD_COUNTY}}', postcode: '{{ADD_POSTCODE}}', country: '{{ADD_COUNTRY}}' }  }});" LinkText="Select" />    </Columns>
  </con:DataTable>
</asp:Content>
