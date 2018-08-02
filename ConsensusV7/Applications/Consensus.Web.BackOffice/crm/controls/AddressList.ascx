<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="AddressList.ascx.cs" Inherits="Consensus.Web.BackOffice.crm.controls.AddressList" %>
<con:DataTable runat="server" ID="AddressSearchList" CanCreate="true" Url="~/GenericPopup.aspx?context=crm&control=OrganisationAddressDetail&width=900&id={{Id}}&orgId={{OrganisationId}}">
    <Columns>
        <con:DataTableTextColumn Title="Type" FieldName="Type" />
        <con:DataTableTextColumn Title="Address" FieldName="AltAddress" />
        <con:DataTableLinkColumn runat="server" LinkHref="javascript: closePopup({ command: 'select', text: '{{Address}}', value: '{{ADD_ID}}', data: { id: '{{ADD_ID}}',Building: '{{ADD_BUILDING}}',Street: '{{ADD_STREET}}',Area: '{{ADD_AREA}}',Town: '{{ADD_TOWN}}',County: '{{ADD_COUNTY}}',Postcode: '{{ADD_POSTCODE}}',Country: '{{ADD_COUNTRY}}', mailstring: '{{Address}}' } });" LinkText="Select" ID="Select" />
    </Columns>
</con:DataTable>

<script type="text/javascript">

    $(document).ready(function () {
        if (location.href.indexOf("crm/organisation")==-1 && $('[id$=_AddressSearchList_wrapper] a.btn-success.consensus-visible-read').hasClass('consensus-visible-read')) {
            $('[id$=_AddressSearchList_wrapper] a.btn-success.consensus-visible-read').removeClass('consensus-visible-read');
        }

        //Updated Create method for Address popup
        window.consensus.web.dataTable.all[0].create = function () {
            var closure = window.consensus.web.dataTable.all[0];
            if (closure._reorderable) {
                // Need to set the order number of the new row in the json data
                var orderNos = closure._tableElement.dataTable().api().column(closure._orderColumnIx).data();
                var nextOrderNo = (orderNos && orderNos.length) ? orderNos.sort(function (a, b) { return a - b; }).reverse()[0] + 1 : 1;
                closure._createJson[closure._orderField] = nextOrderNo;
            }
            switch (closure._createMode.toUpperCase()) {                
                case 'REALTIME':
                    var array = this._getSourceData();
                    var item = jQuery.extend(true, {}, closure._createJson);
                    consensus.web.popupFrame({
                        url: consensus.resolveUrl(consensus.data.substitute(item, closure._createHref)),
                        open: function () {
                            if (this.window.consensus) {
                                var button = $(this.window.document.body).find('#SiteContent_PopupFooter_SaveButton');
                                var state = new consensus.data.state(button, item, this.window);
                                consensus.data.setState(state);
                                state.updateScreen();
                            }
                        },
                        result: function (data) {
                            for (var entry in item)
                                if (typeof (data[entry]) == 'undefined')
                                    data[entry] = item[entry];                            
                            consensus.network.send({
                                method: 'put',
                                url: data.uri,
                                data: data,
                                success: function (result) {
                                    var addressObject = {
                                        ADD_ID: result.Address.Id,
                                        ADD_AREA: result.Address.Area,
                                        ADD_BUILDING: result.Address.Building,
                                        ADD_COUNTRY: result.Address.Country,
                                        ADD_COUNTY: result.Address.County,
                                        ADD_POSTCODE:result.Address.Postcode,
                                        ADD_STREET: result.Address.Street,
                                        ADD_TOWN: result.Address.Town,
                                        Address: result.Address.MailString,
                                        AltAddress: result.Address.MailString,
                                        Type: result.TypeCode,
                                        uri: result.uri
                                    };

                                    array.push(addressObject);
                                    closure.reload();
                                    if (closure.onCreate && typeof (closure.onCreate) == 'function')
                                        closure.onCreate(result);
                                }
                            });
                        }
                    });
                    break;               
            }
        }        

    });    

</script>
