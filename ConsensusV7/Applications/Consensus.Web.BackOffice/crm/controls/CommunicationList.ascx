<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="CommunicationList.ascx.cs" Inherits="Consensus.Web.BackOffice.crm.CommunicationList" %>
<con:DataTable runat="server" ID="CommunicationListResult" Mode="Stateful" Url="~/genericPopup.aspx?context=crm&control=communicationdetail&id={{Id}}" >
  <Columns>
    <con:DataTableTextColumn Title="Type" FieldName="Communication.DeviceCodeCode" />
    <con:DataTableCustomColumn Title="Communication">
      var deviceType = consensus.data.getValue(row, "Communication.DeviceType") || '';
      var deviceComm = consensus.data.getValue(row, "Communication.DeviceFullValue");
      if (deviceComm && deviceComm.length != 0) {
        switch (deviceType.toLowerCase()) {
          case "phone":   return '<a href="tel:' + deviceComm + '">' + deviceComm + '</a>';
          case "fax":     return '<a href="fax:' + deviceComm + '">' + deviceComm + '</a>';
          case "mobile":  return '<a href="tel:' + deviceComm + '">' + deviceComm + '</a>';
          case "email":   return '<a href="mailto:' + deviceComm + '">' + deviceComm + '</a>';
          case "web": 
            var regExp= /(http(s?))\:\/\//gi;
            if(regExp.test(deviceComm))
                return '<a href="' + deviceComm + '">' + deviceComm + '</a>';
            else
                return '<a href="http://' + deviceComm + '">' + deviceComm + '</a>';
          default:        return deviceComm;
        }
      }
      return deviceComm;
    </con:DataTableCustomColumn>
    <con:DataTableTextColumn Title="Extention" FieldName="Communication.Extension" />
    <con:DataTableIconColumn Title="Active" FieldName="Communication.Active" />
    <con:DataTableIconColumn Title="Default" FieldName="Communication.Default" />
    <con:DataTableIconColumn Title="Preferred" FieldName="Communication.Preferred" />
    <con:DataTableIconColumn Title="Ex Directory" FieldName="Communication.ExDirectory" />
    <con:DataTableDateColumn Title="Start Date" FieldName="Communication.ValidFrom" />  
  </Columns>
</con:DataTable>
