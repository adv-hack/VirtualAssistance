<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="TimeLogList.ascx.cs" Inherits="Consensus.Web.BackOffice.crm.controls.TimeLogList" %>

<con:DataTable runat="server" ID="TimeLogListResult" Url="~/GenericPopup.aspx?context=crm&control=TimeLogDetail&width=1150&id={{Id}}" CanCreate="true">
    <Columns>
        <con:DataTableTextColumn FieldName="TIM_ID" Visible="false" />
        <con:DataTableTextColumn Title="Actual Hours" FieldName="TIM_HOURS" Width="10%" />
        <con:DataTableTextColumn Title="Chargeable Hours" FieldName="TIM_HOU_CHARGE" Width="10%" />
        <con:DataTableTextColumn Title="Travel Hours" FieldName="TIM_TRA_HOURS" Width="10%" />
        <con:DataTableTextColumn Title="Chargeable Travel Hours" FieldName="TIM_TRA_CHARGE" Width="10%" />
        <con:DataTableTextColumn Title="Type" FieldName="TIM_TYPE" Width="10%" />
        <con:DataTableTextColumn Title="Logged Against" FieldName="LoggedAgainst" Visible="false" />
        <con:DataTableCustomColumn runat="server" Title="Logged Against" Width="30%">
            var timType = consensus.data.getValue(row, "TIM_TYPE") || '';            
            var actId = consensus.data.getValue(row, "TIM_ACT_ID") || '';   
            var sessionName = consensus.data.getValue(row, "LoggedAgainst") || '';  
            var page;
            if(timType=="Session")
            {
                 page = "getPopupUrlforSession("+actId+")";
            }
            else
            {
                page = "getPopupUrlforActivity("+actId+")";
            }
                    var link = $('<a />').attr('onclick', page).attr('href',"#").text(sessionName);
                    return link[0].outerHTML;            
        </con:DataTableCustomColumn>
        <con:DataTableTextColumn runat="server" Title="Description" FieldName="Tim_Desc" Width="50%" />
    </Columns>
</con:DataTable>
<con:HiddenField runat="server" ID="AssociateId" />
<script type="text/javascript">
    function getPopupUrlforActivity(actId) {
        return consensus.web.popupFrame({
            url: consensus.resolveUrl('~/GenericPopup.aspx?context=crm&control=activitydetailbasic&width=1150&id=' + actId),
            open: function () {
                var button = $(this.window.document.body).find('#Content_PopupFooter_SaveButton');
                var state = new consensus.data.state(button, { uri: 'activities/activity/' + actId }, this.window);
                consensus.data.setState(state);
            },
            result: function (data) {
                consensus.network.send(
                    {
                        method: 'put',
                        url: data.uri,
                        data: data,
                        success: function (result) {
                            window.location.href = consensus.resolveUrl('~/crm/TimeLogDetail?id=' + Id);
                        }
                    });
            }
        });
    }

    function getPopupUrlforSession(actId) {
        return consensus.web.popupFrame({
            url: consensus.resolveUrl('~/GenericPopup.aspx?context=learning&control=eventsessiondetail&width=1150&id=' + actId),
            open: function () {
                var button = $(this.window.document.body).find('#Content_PopupFooter_SaveButton');
                var state = new consensus.data.state(button, { uri: 'learning/session/' + actId }, this.window);
                consensus.data.setState(state);
            },
            result: function (data) {
                consensus.network.send(
                    {
                        method: 'put',
                        url: data.uri,
                        data: data,
                        success: function (result) {
                            window.location.href = consensus.resolveUrl('~/crm/TimeLogDetail?id=' + Id);
                        }
                    });
            }
        });
    }
</script>
