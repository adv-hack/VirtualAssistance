<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="SourceStatisticsDetail.ascx.cs" Inherits="Consensus.Web.BackOffice.marketing.controls.SourceStatisticsDetail" %>
<div class="row">
    <div class="col-md-6">
        <div class="row">
            <div class="col-md-4">
                <con:GroupBox runat="server" Title="Description">                                                                          
                        <div class="col-md-12">
                            <span class="consensus-input" >
                                <label></label>
                                <div class="input-group" disabled="disabled"><label class="form-control">Fixed Cost</label></div>
                            </span>
                        </div>
                        <div class="col-md-12">
                            <span class="consensus-input" >
                                <label></label>
                                <div class="input-group" disabled="disabled"><label class="form-control">Variable Cost</label></div>
                            </span>
                        </div>
                         <div class="col-md-12">
                            <span class="consensus-input" >
                                <label></label>
                                <div class="input-group" disabled="disabled"><label class="form-control">Calculated Cost</label></div>
                            </span>
                        </div>
                        <div class="col-md-12">
                            <span class="consensus-input" >
                                <label></label>
                                <div class="input-group" disabled="disabled"><label class="form-control">Calculated</label></div>
                            </span>
                        </div>
                        <div class="col-md-12">
                            <span class="consensus-input" >
                                <label></label>
                                <div class="input-group" disabled="disabled"><label class="form-control">Responses</label></div>
                            </span>
                        </div>
                        <div class="col-md-12">
                            <span class="consensus-input" >
                                <label></label>
                                <div class="input-group" disabled="disabled"><label class="form-control">Opportunities</label></div>
                            </span>
                        </div>
                        <div class="col-md-12">
                            <span class="consensus-input" >
                                <label></label>
                                <div class="input-group" disabled="disabled"><label class="form-control">Sold Opportunities</label></div>
                            </span>
                        </div>
                        <div class="col-md-12">
                            <span class="consensus-input" >
                                <label></label>
                                <div class="input-group" disabled="disabled"><label class="form-control">Sold Opportunities Value</label></div>
                            </span>
                        </div>
                         <div class="col-md-12">
                            <span class="consensus-input" >
                                <label></label>
                                <div class="input-group" disabled="disabled"><label class="form-control">Complaints Logged</label></div>
                            </span>
                        </div>
                        <div class="col-md-12">
                            <span class="consensus-input" >
                                <label></label>
                                <div class="input-group" disabled="disabled"><label class="form-control">Information Requests Logged</label></div>
                            </span>
                        </div>
                </con:GroupBox>
            </div>
            <div class="col-md-4">
                <con:GroupBox runat="server" Title="Target">                                                                         
                        <div class="col-md-12">
                            <con:TextField runat="server" ID="BudgetFixCost" DataBoundValue="BudgetFixCost" TextMode="Number" ClientOnChange="changedBudgetCost();" />
                        </div>
                        <div class="col-md-12">
                            <con:TextField runat="server" ID="BudgetVarCost" DataBoundValue="BudgetVarCost" TextMode="Number" ClientOnChange="changedBudgetCost();" />
                        </div>                        
                         <div class="col-md-12">
                            <con:TextField runat="server" ID="CalculatedBudgetCost" DataBoundValue="CalculatedBudgetCost"  TextMode="Number" IsReadonly="True"/>
                        </div> 
                        <div class="col-md-12">
                            <con:TextField runat="server" ID="BudgetCalculatedLabel" IsReadonly="True" />        
                        </div>                                                 
                        <div class="col-md-12">
                            <con:TextField runat="server" ID="TargetResponses" DataBoundValue="TargetResponses"  TextMode="Number" />
                        </div>                                 
                        <div class="col-md-12">
                            <con:TextField runat="server" ID="TargetOpportunities" DataBoundValue="TargetOpportunities" TextMode="Number" />
                        </div>
                        <div class="col-md-12">
                            <con:TextField runat="server" ID="TargetSoldOpportunities" FieldValue="N/A" IsReadOnly="True"/>
                        </div>
                        <div class="col-md-12">
                            <con:TextField runat="server" ID="TargetOpportunitiesValue" DataBoundValue="TargetOpportunitiesValue" TextMode="Number" />
                        </div>   
                        <div class="col-md-12">
                            <con:TextField runat="server" ID="TargetComplaints" DataBoundValue="TargetComplaints" TextMode="Number" />
                        </div>
                        <div class="col-md-12">
                            <con:TextField runat="server" ID="TargetInfoReq" DataBoundValue="TargetInfoReq" TextMode="Number" />
                        </div> 
                </con:GroupBox>
            </div>
            <div class="col-md-4">
                <con:GroupBox runat="server" Title="Actual">                                                                        
                        <div class="col-md-12">
                            <con:TextField runat="server" ID="ActualFixCost" DataBoundValue="ActualFixCost" TextMode="Number" ClientOnChange="changedActualCost();" />
                        </div>
                        <div class="col-md-12">
                            <con:TextField runat="server" ID="ActualVarCost" DataBoundValue="ActualVarCost"  TextMode="Number" ClientOnChange="changedActualCost();" />
                        </div>                       
                        <div class="col-md-12">
                            <con:TextField runat="server" ID="CalculatedeActualCost" DataBoundValue="CalculatedeActualCost"  TextMode="Number" IsReadonly="True"/>
                        </div>
                        <div class="col-md-12">
                            <con:TextField runat="server" ID="ActualCalculatedLabel" IsReadonly="True" />        
                        </div>                                               
                        <div class="col-md-12">
                            <con:TextField runat="server" ID="Responses" DataBoundValue="Responses"  TextMode="Number" IsReadonly="True" />
                        </div>
                        <div class="col-md-12">
                            <con:TextField runat="server" ID="Opportunities" DataBoundValue="Opportunities"  TextMode="Number"  IsReadonly="True"/>
                        </div>                                             
                        <div class="col-md-12">
                            <con:TextField runat="server" ID="SoldOpportunities" DataBoundValue="SoldOpportunities" TextMode="Number" IsReadonly="True" />
                        </div>
                        <div class="col-md-12">
                            <con:TextField runat="server" ID="SoldOpportunitiesValue" DataBoundValue="SoldOpportunitiesValue"  TextMode="Number" IsReadonly="True" />
                        </div>
                        <div class="col-md-12">
                            <con:TextField runat="server" ID="ActualComplaints" DataBoundValue="ActualComplaints" TextMode="Number" IsReadonly="True" />
                        </div>
                        <div class="col-md-12">
                            <con:TextField runat="server" ID="ActualInfoReq" DataBoundValue="ActualInfoReq" TextMode="Number" IsReadonly="True" />
                        </div>                                              
                </con:GroupBox>
            </div>
        </div>
    </div>
    <div class="col-md-6">
        <div class="row">
            <div class="col-md-4">
                <con:GroupBox runat="server" Title="Description"> 
                        <div class="col-md-12">
                            <span class="consensus-input" >
                                <label></label>
                                <div class="input-group" disabled="disabled"><label class="form-control">Helpcalls Logged</label></div>
                            </span>
                        </div>
                        <div class="col-md-12">
                            <span class="consensus-input" >
                                <label></label>
                                <div class="input-group" disabled="disabled"><label class="form-control">Bookings</label></div>
                            </span>
                        </div>
                        <div class="col-md-12">
                            <span class="consensus-input" >
                                <label></label>
                                <div class="input-group" disabled="disabled"><label class="form-control">Bookings Value</label></div>
                            </span>
                        </div>
                        <div class="col-md-12">
                            <span class="consensus-input" >
                                <label></label>
                                <div class="input-group" disabled="disabled"><label class="form-control">Quotes</label></div>
                            </span>
                        </div>
                        <div class="col-md-12">
                            <span class="consensus-input" >
                                <label></label>
                                <div class="input-group" disabled="disabled"><label class="form-control">Quotes Value</label></div>
                            </span>
                        </div>
                        <div class="col-md-12">
                            <span class="consensus-input" >
                                <label></label>
                                <div class="input-group" disabled="disabled"><label class="form-control">Mailing Activities</label></div>
                            </span>
                        </div>
                        <div class="col-md-12">
                            <span class="consensus-input" >
                                <label></label>
                                <div class="input-group" disabled="disabled"><label class="form-control">Memberships Sold</label></div>
                            </span>
                        </div>
                        <div class="col-md-12">
                            <span class="consensus-input" >
                                <label></label>
                                <div class="input-group" disabled="disabled"><label class="form-control">Value of Memberships Sold</label></div>
                            </span>
                        </div>
                        <div class="col-md-12">
                            <span class="consensus-input" >
                                <label></label>
                                <div class="input-group" disabled="disabled"><label class="form-control">Subscriptions Sold</label></div>
                            </span>
                        </div>
                        <div class="col-md-12">
                            <span class="consensus-input" >
                                <label></label>
                                <div class="input-group" disabled="disabled"><label class="form-control">Value of Subscriptions Sold</label></div>
                            </span>
                        </div>
                </con:GroupBox>
            </div>
            <div class="col-md-4">
                <con:GroupBox runat="server" Title="Target">
                        <div class="col-md-12">
                            <con:TextField runat="server" ID="TargetHelpcalls" DataBoundValue="TargetHelpcalls" TextMode="Number" />
                        </div>                                                                        
                        <div class="col-md-12">
                            <con:TextField runat="server" ID="TargetBookings" FieldValue="N/A" IsReadOnly="True"/>
                        </div>                                            
                        <div class="col-md-12">
                            <con:TextField runat="server" ID="TargetBookingsValue" DataBoundValue="TargetBookingsValue" TextMode="Number" />
                        </div> 
                        <div class="col-md-12">
                            <con:TextField runat="server" ID="TargetQuote" FieldValue="N/A" IsReadOnly="True"/>
                        </div>
                        <div class="col-md-12">
                            <con:TextField runat="server" ID="TargetQuoteValue" FieldValue="N/A" IsReadOnly="True"/>
                        </div>                                             
                        <div class="col-md-12">
                            <con:TextField runat="server" ID="TargetMailing" FieldValue="N/A" IsReadOnly="True"/>
                        </div> 
                        <div class="col-md-12">
                            <con:TextField runat="server" ID="TargetMemberships" DataBoundValue="TargetMemberships" TextMode="Number" />
                        </div> 
                        <div class="col-md-12">
                            <con:TextField runat="server" ID="TargetMembershipsVal" DataBoundValue="TargetMembershipsVal" TextMode="Number" />
                        </div>
                        <div class="col-md-12">
                            <con:TextField runat="server" ID="TargetSubscriptions" DataBoundValue="TargetSubscriptions" TextMode="Number" />
                        </div>                                             
                        <div class="col-md-12">
                            <con:TextField runat="server" ID="TargetSubscriptionsVal" DataBoundValue="TargetSubscriptionsVal" TextMode="Number" />
                        </div> 
                </con:GroupBox>
            </div>
            <div class="col-md-4">
                <con:GroupBox runat="server" Title="Actual"> 
                        <div class="col-md-12">
                            <con:TextField runat="server" ID="ActualHelpcalls" DataBoundValue="ActualHelpcalls" TextMode="Number" IsReadonly="True"/>
                        </div>                                                                        
                        <div class="col-md-12">
                            <con:TextField runat="server" ID="Bookings" DataBoundValue="BookingCount" TextMode="Number" IsReadonly="True"/>
                        </div>
                        <div class="col-md-12">
                            <con:TextField runat="server" ID="BookingsValue" DataBoundValue="BookingsValue" TextMode="Number" IsReadonly="True"/>
                        </div>                                            
                        <div class="col-md-12">
                            <con:TextField runat="server" ID="Quotes" DataBoundValue="QuoteCount" TextMode="Number" IsReadonly="True"/>
                        </div>
                        <div class="col-md-12">
                            <con:TextField runat="server" ID="QuotesValue" DataBoundValue="QuotesValue" TextMode="Number" IsReadonly="True"/>
                        </div>                                             
                        <div class="col-md-12">
                            <con:TextField runat="server" ID="MailingActivities" DataBoundValue="MailingActivities"  TextMode="Number" IsReadonly="True"/>
                        </div>
                        <div class="col-md-12">
                            <con:TextField runat="server" ID="ActualMemberships" DataBoundValue="ActualMemberships" TextMode="Number" IsReadonly="True"/>
                        </div> 
                        <div class="col-md-12">
                            <con:TextField runat="server" ID="ActualMembershipsVal" DataBoundValue="TargetMembershipsVal" TextMode="Number" IsReadonly="True"/>
                        </div>
                        <div class="col-md-12">
                            <con:TextField runat="server" ID="ActualSubscriptions" DataBoundValue="ActualSubscriptions" TextMode="Number" IsReadonly="True"/>
                        </div>                                             
                        <div class="col-md-12">
                            <con:TextField runat="server" ID="ActualSubscriptionsVal" DataBoundValue="ActualSubscriptionsVal" TextMode="Number" IsReadonly="True"/>
                        </div>      
                </con:GroupBox>
            </div>
    </div>
</div>
<script type="text/javascript">
    
    function changedBudgetCost() {
        var enteredFixed = $('#<%= this.BudgetFixCost.ClientID %>Field').val();
        var enteredVariable = $('#<%= this.BudgetVarCost.ClientID %>Field').val();
        $('#<%= this.CalculatedBudgetCost.ClientID %>Field').val((!!enteredFixed ? parseFloat(enteredFixed) : 0) + (!!enteredVariable ? parseFloat(enteredVariable) : 0));
    }

    function changedActualCost() {
        var enteredFixed = $('#<%= this.ActualFixCost.ClientID %>Field').val();
        var enteredVariable = $('#<%= this.ActualVarCost.ClientID %>Field').val();
        $('#<%= this.CalculatedeActualCost.ClientID %>Field').val((!!enteredFixed ? parseFloat(enteredFixed) : 0) + (!!enteredVariable ? parseFloat(enteredVariable) : 0));
    }
</script>