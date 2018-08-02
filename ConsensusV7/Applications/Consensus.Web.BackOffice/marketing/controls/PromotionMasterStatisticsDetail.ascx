<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="PromotionMasterStatisticsDetail.ascx.cs" Inherits="Consensus.Web.BackOffice.marketing.controls.PromotionMasterStatisticsDetail" %>
<div class="row">
    <div class="col-md-6">
        <div class="row">
            <div class="col-md-4">
                <con:GroupBox runat="server" Title="Description">                                                                          
                        <div class="col-md-12">
                            <span class="consensus-input" >
                                <label></label>
                                <div class="input-group" disabled="disabled"><label class="form-control">Cost</label></div>
                            </span>
                        </div>
                         <div class="col-md-12">
                            <span class="consensus-input" >
                                <label></label>
                                <div class="input-group" disabled="disabled"><label class="form-control">Total Cost</label></div>
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
                </con:GroupBox>
            </div>
            <div class="col-md-4">
                <con:GroupBox runat="server" Title="Target">                                                                         
                        <div class="col-md-12">
                            <con:TextField runat="server" ID="BudgetCosts" DataBoundValue="BudgetCost" TextMode="Number" ClientOnChange="changedBudgetCost();" />
                        </div>
                        <div class="col-md-12">
                            <con:TextField runat="server" ID="TotalBudgetCosts" TextMode="Number" IsReadonly="True" />
                        </div>                        
                         <div class="col-md-12">
                            <con:TextField runat="server" ID="CalculatedBudgetCosts" DataBoundValue="CalculatedBudgetCost" TextMode="Number" IsReadonly="True"/>
                        </div> 
                        <div class="col-md-12">
                            <con:TextField runat="server" ID="BudgetCalculatedLabel" IsReadonly="True" />        
                        </div>                                                 
                        <div class="col-md-12">
                            <con:TextField runat="server" ID="TargetResponses" DataBoundValue="TargetReplies"  TextMode="Number" />
                        </div>                                 
                        <div class="col-md-12">
                            <con:TextField runat="server" ID="TargetOpportunities" DataBoundValue="TargetOpp" TextMode="Number" />
                        </div>
                        <div class="col-md-12">
                            <con:TextField runat="server" ID="TargetSoldOpportunities" FieldValue="N/A" IsReadOnly="True"/>
                        </div>
                        <div class="col-md-12">
                            <con:TextField runat="server" ID="TargetOpportunitiesValue" DataBoundValue="TargetOppVal" TextMode="Number" />
                        </div>   
                        <div class="col-md-12">
                            <con:TextField runat="server" ID="TargetBookings" FieldValue="N/A" IsReadOnly="True" />
                        </div>
                        <div class="col-md-12">
                            <con:TextField runat="server" ID="TargetBookingsValue" DataBoundValue="TargetBookVal" TextMode="Number" />
                        </div> 
                        <div class="col-md-12">
                            <con:TextField runat="server" ID="TargetQuote" FieldValue="N/A" IsReadOnly="True"/>
                        </div>
                        <div class="col-md-12">
                            <con:TextField runat="server" ID="TargetQuoteValue" FieldValue="N/A" IsReadOnly="True"/>
                        </div> 
                </con:GroupBox>
            </div>
            <div class="col-md-4">
                <con:GroupBox runat="server" Title="Actual">                                                                        
                        <div class="col-md-12">
                            <con:TextField runat="server" ID="ActualCosts" DataBoundValue="ActualCost" TextMode="Number" ClientOnChange="changedActualCost();" />
                        </div>
                        <div class="col-md-12">
                            <con:TextField runat="server" ID="TotalActualCosts" TextMode="Number" IsReadonly="True"/>
                        </div>                       
                        <div class="col-md-12">
                            <con:TextField runat="server" ID="CalculatedActualCosts"  DataBoundValue="CalculatedActualCost" TextMode="Number" IsReadonly="True"/>
                        </div>
                        <div class="col-md-12">
                            <con:TextField runat="server" ID="ActualCalculatedLabel" IsReadonly="True" />        
                        </div>                                               
                        <div class="col-md-12">
                            <con:TextField runat="server" ID="ActualResponses" DataBoundValue="ActualReplies"  TextMode="Number" IsReadonly="True" />
                        </div>
                        <div class="col-md-12">
                            <con:TextField runat="server" ID="ActualOpportunities" DataBoundValue="ActualOpp"  TextMode="Number"  IsReadonly="True"/>
                        </div>                                             
                        <div class="col-md-12">
                            <con:TextField runat="server" ID="SoldOpportunities" DataBoundValue="SoldOpp" TextMode="Number" IsReadonly="True" />
                        </div>
                        <div class="col-md-12">
                            <con:TextField runat="server" ID="SoldOpportunitiesValue" DataBoundValue="OppVal"  TextMode="Number" IsReadonly="True" />
                        </div>
                        <div class="col-md-12">
                            <con:TextField runat="server" ID="ActualBookings" DataBoundValue="ActualBook" TextMode="Number" IsReadonly="True" />
                        </div>
                        <div class="col-md-12">
                            <con:TextField runat="server" ID="ActualBookingsValue" DataBoundValue="ActualBookVal" TextMode="Number" IsReadonly="True" />
                        </div>  
                        <div class="col-md-12">
                            <con:TextField runat="server" ID="ActualQuote" DataBoundValue="ActualQuotes" TextMode="Number" IsReadonly="True"/>
                        </div>
                        <div class="col-md-12">
                            <con:TextField runat="server" ID="ActualQuoteValue" DataBoundValue="ActualQuotesVal" TextMode="Number" IsReadonly="True"/>
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
                                <div class="input-group" disabled="disabled"><label class="form-control">Mailing Activities</label></div>
                            </span>
                        </div>
                        <div class="col-md-12">
                            <span class="consensus-input" >
                                <label></label>
                                <div class="input-group" disabled="disabled"><label class="form-control">Emails Sent</label></div>
                            </span>
                        </div>
                        <div class="col-md-12">
                            <span class="consensus-input" >
                                <label></label>
                                <div class="input-group" disabled="disabled"><label class="form-control">Emails Opened</label></div>
                            </span>
                        </div>
                        <div class="col-md-12">
                            <span class="consensus-input" >
                                <label></label>
                                <div class="input-group" disabled="disabled"><label class="form-control">Links Clicked</label></div>
                            </span>
                        </div>
                        <div class="col-md-12">
                            <span class="consensus-input" >
                                <label></label>
                                <div class="input-group" disabled="disabled"><label class="form-control">Landing Zone Clicked</label></div>
                            </span>
                        </div>
                        <div class="col-md-12">
                            <span class="consensus-input" >
                                <label></label>
                                <div class="input-group" disabled="disabled"><label class="form-control">Surveys Completed</label></div>
                            </span>
                        </div>
                        <div class="col-md-12">
                            <span class="consensus-input" >
                                <label></label>
                                <div class="input-group" disabled="disabled"><label class="form-control">Global Unsubscribes</label></div>
                            </span>
                        </div>
                        <div class="col-md-12">
                            <span class="consensus-input" >
                                <label></label>
                                <div class="input-group" disabled="disabled"><label class="form-control">List Unsubscribes</label></div>
                            </span>
                        </div>
                        <div class="col-md-12">
                            <span class="consensus-input" >
                                <label></label>
                                <div class="input-group" disabled="disabled"><label class="form-control">Document Downloads</label></div>
                            </span>
                        </div>
                        <div class="col-md-12">
                            <span class="consensus-input" >
                                <label></label>
                                <div class="input-group" disabled="disabled"><label class="form-control">Bounce Backs</label></div>
                            </span>
                        </div>
                </con:GroupBox>
            </div>
            <div class="col-md-4">
                <con:GroupBox runat="server" Title="Target">
                        <div class="col-md-12">
                            <con:TextField runat="server" ID="TargetMailingActivities" FieldValue="N/A" IsReadOnly="True" />
                        </div>                                                                        
                        <div class="col-md-12">
                            <con:TextField runat="server" ID="TargetEmailsSent" DataBoundValue="EmailsSentTarget" TextMode="Number"/>
                        </div>                                            
                        <div class="col-md-12">
                            <con:TextField runat="server" ID="TargetEmailsOpened" DataBoundValue="EmailsOpenedTarget" TextMode="Number" />
                        </div>                                             
                        <div class="col-md-12">
                            <con:TextField runat="server" ID="TargetLinksClicked"  DataBoundValue="LinksClickedTarget" TextMode="Number" />
                        </div> 
                        <div class="col-md-12">
                            <con:TextField runat="server" ID="TargetLandingZonesClicked" DataBoundValue="LzClickedTarget" TextMode="Number" />
                        </div> 
                        <div class="col-md-12">
                            <con:TextField runat="server" ID="TargetSurveysCompleted" DataBoundValue="SurveysCompletedTarget" TextMode="Number" />
                        </div>
                        <div class="col-md-12">
                            <con:TextField runat="server" ID="TargetGlobalUnsubscribes" DataBoundValue="GlobalUnsubscribesTarget" TextMode="Number" />
                        </div>                                             
                        <div class="col-md-12">
                            <con:TextField runat="server" ID="TargetListUnsubscribes" DataBoundValue="ListUnsubscribesTarget" TextMode="Number" />
                        </div> 
                        <div class="col-md-12">
                            <con:TextField runat="server" ID="TargetBounceBacks" DataBoundValue="BounceBacksTarget" TextMode="Number" />
                        </div> 
                        <div class="col-md-12">
                            <con:TextField runat="server" ID="TargetDocumentDownloads" DataBoundValue="DocsDownloadsTarget" TextMode="Number" />
                        </div> 
                </con:GroupBox>
            </div>
            <div class="col-md-4">
                <con:GroupBox runat="server" Title="Actual">                        
                        <div class="col-md-12">
                            <con:TextField runat="server" ID="ActualMailingActivities" DataBoundValue="Mailings" TextMode="Number" IsReadonly="True"/>
                        </div>                                                                        
                        <div class="col-md-12">
                            <con:TextField runat="server" ID="ActualEmailsSent" DataBoundValue="EmailsSentActual" TextMode="Number" IsReadonly="True"/>
                        </div>                                            
                        <div class="col-md-12">
                            <con:TextField runat="server" ID="ActualEmailsOpened" DataBoundValue="EmailsOpenedActual" TextMode="Number" IsReadonly="True"/>
                        </div>                                             
                        <div class="col-md-12">
                            <con:TextField runat="server" ID="ActualLinksClicked"  DataBoundValue="LinksClickedActual" TextMode="Number" IsReadonly="True"/>
                        </div> 
                        <div class="col-md-12">
                            <con:TextField runat="server" ID="ActualLandingZonesClicked" DataBoundValue="LzClickedActual" TextMode="Number" IsReadonly="True"/>
                        </div> 
                        <div class="col-md-12">
                            <con:TextField runat="server" ID="ActualSurveysCompleted" DataBoundValue="SurveysCompletedActual" TextMode="Number" IsReadonly="True"/>
                        </div>
                        <div class="col-md-12">
                            <con:TextField runat="server" ID="ActualGlobalUnsubscribes" DataBoundValue="GlobalUnsubscribesActual" TextMode="Number" IsReadonly="True"/>
                        </div>                                             
                        <div class="col-md-12">
                            <con:TextField runat="server" ID="ActualListUnsubscribes" DataBoundValue="ListUnsubscribesActual" TextMode="Number" IsReadonly="True"/>
                        </div> 
                        <div class="col-md-12">
                            <con:TextField runat="server" ID="ActualBounceBacks" DataBoundValue="BounceBacksActual" TextMode="Number" IsReadonly="True"/>
                        </div> 
                        <div class="col-md-12">
                            <con:TextField runat="server" ID="ActualDocumentDownloads" DataBoundValue="DocsDownloadsActual" TextMode="Number" IsReadonly="True"/>
                        </div>       
                </con:GroupBox>
            </div>
    </div>
</div>
<script type="text/javascript">
    
    function changedBudgetCost() {
        var entered = $('#<%= this.BudgetCosts.ClientID %>Field').val();
        var calculated = $('#<%= this.CalculatedBudgetCosts.ClientID %>Field').val();
        $('#<%= this.TotalBudgetCosts.ClientID %>Field').val(parseFloat(entered) + parseFloat(calculated));
    }

    function changedActualCost() {
        var entered = $('#<%= this.ActualCosts.ClientID %>Field').val();
        var calculated = $('#<%= this.CalculatedActualCosts.ClientID %>Field').val();
        $('#<%= this.TotalActualCosts.ClientID %>Field').val(parseFloat(entered) + parseFloat(calculated));
    }
</script>