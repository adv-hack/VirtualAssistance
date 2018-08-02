<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="DirectDebitDetails.ascx.cs" Inherits="Consensus.Web.BackOffice.finance.controls.DirectDebitDetails" %>
<div class="row">
    <div class="col-md-6">
        <con:GroupBox runat="server" Title="Direct Debit details">
            <div class="row">
                <div class="col-md-6"><con:ListField runat="server" ID="Status" DataBoundValue="Status" LabelText="Status" ValueMember="Value" DisplayMember="Key" Requirement="MandatoryEnforced"/></div>
                <div class="col-md-6"><con:DateField runat="server" ID="EffectiveDate" DataBoundValue="EffectiveDate" LabelText="Effective date" IsReadOnly="True"/></div>
            </div>

            <div class="row">
                <div class="col-md-6"><con:DateField runat="server" ID="RecDate" DataBoundValue="RecDate" LabelText="Date received" /></div>
                <div class="col-md-6">
                    <con:ListField runat="server" ID="RecMethod" DataBoundValue="RecMethod" LabelText="Method received">
                        <Items>
                            <asp:ListItem Text="" Value="" />
                            <asp:ListItem Text="Paper form" Value="0" />
                            <asp:ListItem Text="Web instruction" Value="1" />
                            <asp:ListItem Text="Verbal" Value="Verbal" />
                        </Items>
                    </con:ListField>
                </div>
            </div>

            <div class="row">
                <div class="col-md-6"><con:TextField runat="server" ID="BalanceOutstanding" LabelText="Outstanding balance" TextMode="Number" IsReadOnly="True" /></div>
                <div class="col-md-6"><con:TextField runat="server" ID="ServiceUserNumber" DataBoundValue="ServiceUserNumber" LabelText="Service user number" /></div>
            </div>
        </con:GroupBox>

    
        <con:GroupBox runat="server" Title="Collection information">
            <div class="row">
                <div class="col-md-6">
                    <con:ListField runat="server" ID="Frequency" LabelText="Collection frequency" DataBoundValue="Frequency" ClientOnChange="directdebit.functions.updateIntervals();">
                        <Items>
                            <asp:ListItem Text="" Value="" />
                            <asp:ListItem Text="Variable" Value="0" />
                            <asp:ListItem Text="Weekly" Value="1" />
                            <asp:ListItem Text="Monthly" Value="2" />
                            <asp:ListItem Text="Quarterly" Value="3" />
                            <asp:ListItem Text="Annually" Value="4" />
                        </Items>
                    </con:ListField>
               </div>
               <div class="col-md-6">
                    <con:ListField runat="server" ID="CollectionType" LabelText="Collection type" DataBoundValue="Variable">
                        <Items>
                            <asp:ListItem Text="Fixed value" Value="0" />
                            <asp:ListItem Text="Variable value" Value="1" />
                        </Items>
                    </con:ListField>
                </div>
            </div>
            
            <div class="row">
                <div class="col-md-6"><con:TextField runat="server" ID="Installments" LabelText="Installments" DataBoundValue="NoOfInstallments" TextMode="Number" Requirement="MandatoryEnforced" ClientOnChange="directdebit.functions.recalculateRepayments();" /></div>
                <div class="col-md-6"><con:ListField runat="server" ID="DayOfMonth" DataBoundValue="DayOfMonth" LabelText="Collection day of month" ValueMember="Value" DisplayMember="Key" ClientOnChange="directdebit.functions.dayOfMonthChange();"/></div>
            </div>           

            <div class="row">
                <div class="col-md-6"><con:TextField runat="server" ID="MaximumValue" LabelText="Maximum value" DataBoundValue="MaxValue" TextMode="Number" /></div>
                <div class="col-md-6"><con:TextField runat="server" ID="TotalVal" LabelText="Total value" DataBoundValue="Total" TextMode="Number" IsReadOnly="True" /></div>
            </div>
            <div class="row">
                
            </div>
        </con:GroupBox>
    </div>
    <div class="col-md-6">
        <con:GroupBox runat="server" Title="Account information">
            <div class="row">
                <div class="col-md-12"><con:TextField runat="server" ID="AccountName" LabelText="Account name" DataBoundValue="BankAccName" Requirement="MandatoryEnforced" /></div>
            </div>
            <div class="row">
                <div class="col-md-6">
                    <con:TextField runat="server" ID="SortCode" LabelText="Sort code" DataBoundValue="SortCode" Requirement="MandatoryEnforced">
                        <Validators>
                            <con:Validator runat="server" Critical="true" ErrorMessage="This is a required field" />
                        </Validators>
                    </con:TextField>
                </div>
                <div class="col-md-6">
                    <con:TextField runat="server" ID="AccountNumber" LabelText="Account number" DataBoundValue="BankAccCode" Requirement="MandatoryEnforced" >
                        <Validators>
                            <con:Validator runat="server" Critical="true" ErrorMessage="This is a required field" />
                        </Validators>
                    </con:TextField>
                </div>   
            </div>

            <div class="row">
                <div class="col-md-12"><con:TextField runat="server" ID="BankName" LabelText="Bank name" DataBoundValue="BankName" /></div>
            </div>


            <div class="row">
                <div class="col-md-12"><con:TextField runat="server" ID="Address1" LabelText="Address 1" DataBoundValue="BankAdd1" /></div>
            </div>
            <div class="row">
                <div class="col-md-12"><con:TextField runat="server" ID="Address2" LabelText="Address 2" DataBoundValue="BankAdd2" /></div>
            </div>
            <div class="row">
                <div class="col-md-12"><con:TextField runat="server" ID="Address3" LabelText="Town" DataBoundValue="BankAdd3" /></div>
            </div>
            <div class="row">
                <div class="col-md-6"><con:TextField runat="server" ID="Address4" LabelText="County" DataBoundValue="BankAdd4" /></div>
                <div class="col-md-6"><con:TextField runat="server" ID="Postcode" LabelText="Postcode" DataBoundValue="BankPostcode" /></div>
            </div>
        </con:GroupBox>
    </div>
</div>
<con:HiddenField runat="server" ID="Id" DataBoundValue="Id" />
<con:HiddenField runat="server" ID="MemberPeriodId" DataBoundValue="MemberPeriodId" />
<con:HiddenField runat="server" ID="TableNum" DataBoundValue="TableNum" />
<con:HiddenField runat="server" ID="Type" DataBoundValue="Type" />
<con:HiddenField runat="server" ID="DueDate" DataBoundValue="DueDate" />
<con:HiddenField runat="server" ID="MepEndDate" DataBoundValue="MemberPeriod.End" />
<con:HiddenField runat="server" ID="MepStartDate" DataBoundValue="MemberPeriod.Start" />
<con:HiddenField runat="server" ID="EndDate" DataBoundValue="EndDate" />
<con:HiddenField runat="server" ID="DDExist" />

<script>

        $(document).ready(function () {
            $('#<%= this.AccountNumber.ClientID %>Group').append('<span class="input-group-addon" onclick="ValidateBankDetails()"><i class="icons8-search"></i></span>');
        });

        function ValidateBankDetails() {
            if ($('#<%= this.SortCode.ClientID %>Field').val() && $('#<%= this.AccountNumber.ClientID %>Field').val()) {
                consensus.network.send({
                    async: false,
                    method: 'post',
                    url: 'finance/DirectDebit/AfdBankFinderAccountNumberValidation?accountNumber=' + $('#<%= this.AccountNumber.ClientID %>Field').val() + '&sortCode=' + $('#<%= this.SortCode.ClientID %>Field').val(),
                    success: function (response) {
                        if (response) {
                            if (response.Result > 0) {

                            }
                            else {
                                $('#<%= this.AccountNumber.ClientID %>Error').find(":last-child").attr("style", "display: inline;");
                                $('#<%= this.AccountNumber.ClientID %>').addClass("has-error");
                            }
                        }
                        else {
                            
                        }
                    },
                    error: function (request) {
                    }
                });
            }
            else {
                if (!$('#<%= this.SortCode.ClientID %>Field').val()) {
                    $('#<%= this.SortCode.ClientID %>Error').find(":last-child").attr("style", "display: inline;");
                    $('#<%= this.SortCode.ClientID %>').addClass("has-error");
                }
                if (!$('#<%= this.AccountNumber.ClientID %>Field').val()) {
                    $('#<%= this.AccountNumber.ClientID %>Error').find(":last-child").attr("style", "display: inline;");
                    $('#<%= this.AccountNumber.ClientID %>').addClass("has-error");
                }
            }
        }


        var directdebit = {
            controls: {
                amount: $('#<%= this.TotalVal.ClientID %>Field'),
                balance: $('#<%= this.BalanceOutstanding.ClientID %>Field'),
                dateDue: $('#<%= this.DueDate.ClientID %>Field'),
                mepStartDate: $('#<%= this.MepStartDate.ClientID %>Field'),
                dateEnd: $('#<%= this.EndDate.ClientID %>Field'),
                frequency: $('#<%= this.Frequency.ClientID %>Field'),
                installments: $('#<%= this.Installments.ClientID %>Field'),
                accountName: $('#<%= this.AccountName.ClientID %>Field'),
                maxValue: $("#<%= this.MaximumValue.ClientID %>Field"),
                dayOfMonth: $("#<%= this.DayOfMonth.ClientID %>Field")
            },
            functions: {
            recalculateRepayments: function () {
                var numInstallments = directdebit.controls.installments.val(),
                    balanceOS =  directdebit.controls.balance.val();

                if (numInstallments > 0)
                    directdebit.controls.maxValue.val(balanceOS / numInstallments);


            },
            updateIntervals: function (){
                var startDate = new Date(directdebit.controls.dateDue.val());   
                var endDate = new Date(directdebit.controls.dateEnd.val());    

                if (!endDate.getDate())
                {
                    endDate = new Date($("#<%= MepEndDate.ClientID %>Field").val());  
                }
        
                var intType = directdebit.controls.frequency.val();
                var numInstallments = 0;

                var d1Y = startDate.getFullYear();
                var d2Y = endDate.getFullYear();
                var d1M = startDate.getMonth();
                var d2M = endDate.getMonth();

                if (intType == 1)
                    numInstallments = Math.floor((endDate - startDate) / (3600000 * 24 * 7)) + 1;
                if (intType == 2)
                {
                    numInstallments = ((d2M + 12 * d2Y) - (d1M + 12 * d1Y)) + 1;
                }
                if (intType == 3)
                    numInstallments = Math.floor(((d2M + 12 * d2Y) - (d1M + 12 * d1Y)) / 3) + 1;

                if (numInstallments <= 0)
                    numInstallments = 1;

                directdebit.controls.installments.val(numInstallments);
                directdebit.functions.recalculateRepayments();
            },
            calculateDueDate(memDate) {
                //For new payments determine first day can collect based on day of month and days have to wait.
                // Copied from v6.5
                var effectiveDate = new Date();
                effectiveDate.setDate(effectiveDate.getDate() + 14);
                var dayOfMonth = directdebit.controls.dayOfMonth.val();
                var actualStartDate = new Date(), addMonth = 0;
                var membershipStartDate = new Date(memDate);

                if (!membershipStartDate){
                    membershipStartDate = new Date();
                    membershipStartDate.setDate(membershipStartDate.getDate() + 14);
                }

                if (dayOfMonth == 0)
                    dayOfMonth = 1;

                if (membershipStartDate.getDate() > dayOfMonth)
                    addMonth = 1;
            
                actualStartDate = new Date(membershipStartDate.getFullYear(), membershipStartDate.getMonth() + addMonth, dayOfMonth);

                if (effectiveDate <= actualStartDate)
                    return actualStartDate.toDateString();
                else {
                //Keep adding months until after received date i.e. in the future
                        
                    while (actualStartDate < effectiveDate)
                    {
                        actualStartDate.setMonth(actualStartDate.getMonth() + 1);
                    }

                }
                return actualStartDate.toDateString();
            },
            setEndDate: function() {
  
                var datDueDate = new Date(directdebit.controls.dateDue.val());  
                var intInstallments = directdebit.controls.installments.val();
                
                if (directdebit.controls.frequency.length >0 && !isNaN(intInstallments) && intInstallments > 0 && datDueDate.getDate()) {	
			
                // Set to latest of MEP_END and due date plus remaining installments
                    var datEndDate = new Date(datDueDate);
                    var datMepEndDate= new Date($("#<%= MepEndDate.ClientID %>Field").val());    
			
                    switch (directdebit.controls.frequency.val()) {
                        case '1': //weekly
                            datEndDate.setDate(datDueDate.getDate() + (intInstallments-1)*7);
                            break;                    
                        case '2': //monthly
                            datEndDate.setMonth(datDueDate.getMonth() + (intInstallments-1));
                            break;                    
                        case '3': //Quarterly
                            datEndDate.setMonth(datDueDate.getMonth() + (intInstallments-1)*3);
                            break;                   
                        case '4': //Annually
                            datEndDate.setFullYear(datDueDate.getFullYear() + (intInstallments-1));
                            break;
                  }

                    if(datMepEndDate.getDate() && datEndDate < datMepEndDate)
                        datEndDate=datMepEndDate

                    directdebit.controls.dateEnd.val(datEndDate.toDateString());
			   }
            },
            setDueDate: function(){
                // Just change DOM on current due date, unless this will be before effective date, in which case add 1 month
                var intDayOfMonth = directdebit.controls.dayOfMonth.val();
                var datDueDate = new Date($("#<%= this.DueDate.ClientID %>Field").val());
                var datEffectiveDate = new Date($("#<%= this.EffectiveDate.ClientID %>Field").val());
		
                if (!datDueDate.getDate()) 			
                    datDueDate=datEffectiveDate;
		
                if (intDayOfMonth>0) {
                    datDueDate.setDate(intDayOfMonth);
                    if (datDueDate.getDate() > datEffectiveDate.getDate())
                        datDueDate.setMonth(datDueDate.getMonth() + 1);

			        }
                directdebit.controls.dateDue.val(datDueDate.toDateString());

            },
            dayOfMonthChange: function () {
                directdebit.functions.setDueDate();
                directdebit.functions.setEndDate();
            },
            populateDirectDebitDefaults: function (prodId) {
                consensus.network.send({
                    url: '/learning/productmembership/' + prodId + '?ListsAtDepth=None&GoToDepth=Root',
                    method: 'get',
                    success: function (data) {
                        if (data.DdFrequency)
                            directdebit.controls.frequency.val(data.DdFrequency);
                        else
                            directdebit.controls.frequency.val(0);

                        if (data.DdNoOfInstallments)
                            directdebit.controls.installments.val(data.DdNoOfInstallments);
                        else
                            directdebit.controls.installments.val(1);                                   
                    },
                    error: function () {
                        directdebit.controls.frequency.val(0);
                        directdebit.controls.installments.val(1);
                    }

                });
            }
        }
        };

   


    consensus.data.onsave = function (state, result, callback) {
       if ($("#<%= DDExist.ClientID %>Field").val() > 0) {
            var mepId = $("#<%= MemberPeriodId.ClientID %>Field").val();
            var ddId = result.Id;
            swal({ title: 'Cancel existing Direct Debits?', text: 'An existing Direct Debit Instruction exists for the current Member period, would you like to cancel it?', type: 'warning', showCancelButton: true, confirmButtonText: 'Yes', cancelButtonText: 'No', confirmButtonClass: 'btn btn-danger', cancelButtonClass: 'btn btn-default', buttonsStyling: false }).then(function (confirm) {
                if (confirm) {
                    consensus.network.send({
                        async: false,
                        method: 'post',
                        url: 'membership/memberperiod/cancelExistingDirectDebits?memberPeriodId=' + mepId + '&directDebitId=' + ddId,
                        success: function () {
                            callback.call(this, state, result);
                        },
                        error: function () {
                            callback.call(this, state, result);
                        }
                    });
                }
            }, function (dismiss) {
                callback.call(this, state, result);
            });
           
        }
        else {
           callback.call(this, state, result);
        }
    }


</script>