using Consensus.Finance;
using Consensus.UserInterface;
using Consensus.Web.Controls;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Consensus.Web.BackOffice.finance.controls
{
    public partial class AllocationDetail : BaseControl<PayAllocation, String>
    {
        #region properties

        public string AllocationType
        {
            get
            {
                return this.Request.QueryString["allocationType"];
            }
        }

        public override Func<string, PayAllocation> DataLoader
        {
            get
            {
                return PayAllocation.FetchById;
            }
        }

        public override string DataTypeName
        {
            get
            {
                if (this.DataSource != null && !String.IsNullOrEmpty(this.DataSource.Id))
                    return "Allocation";
                else
                    return "New allocation";
            }
        }

        /// <summary>
        ///     Sets if record can be deleted
        /// </summary>
        public override bool AllowDelete
        {
            get { return false; }
        }

        #endregion

        #region Methods

        protected override void PopulateControl()
        {
            base.PopulateControl();
        }

        protected override void OnPreRender(EventArgs eventArguments)
        {

            base.OnPreRender(eventArguments);
            switch (AllocationType)
            {
                case "invoice":
                    var invId = this.Request.QueryString["invId"];
                    var invoice = Invoice.FetchById(invId);
                    if (invoice != null)
                    {
                        this.InvId.FieldValue = invoice.Id;
                        this.InvId.FieldText = invoice.Reference;
                        this.UnpaidValue.FieldValue = invoice.UnpaidValue.ConvertTo<String>();
                        this.PaymentId.Filters.Add(new PopupFieldFilter { ParameterName = "ARNumber", Type = PopupFieldFilterTypes.Value, Value = invoice.ArNo });
                        this.PaymentId.Filters.Add(new PopupFieldFilter { ParameterName = "Currency", Type = PopupFieldFilterTypes.Value, Value = invoice.Currency });
                        this.InvId.Filters.Add(new PopupFieldFilter { ParameterName = "ARNumber", Type = PopupFieldFilterTypes.Value, Value = invoice.ArNo });
                        this.InvId.Filters.Add(new PopupFieldFilter { ParameterName = "Currency", Type = PopupFieldFilterTypes.Value, Value = invoice.Currency });
                    }
                    break;

                case "payment":
                    var payId = this.Request.QueryString["payId"];
                    var payment = Payment.FetchById(payId);
                    this.PaymentId.FieldValue = payId;
                    this.PaymentId.FieldText = payId;
                    if (payment != null)
                    {
                        this.UnusedValue.FieldValue = payment.UnusedVal.ConvertTo<String>();
                        this.PaymentId.Filters.Add(new PopupFieldFilter { ParameterName = "ARNumber", Type = PopupFieldFilterTypes.Value, Value = payment.CustomerAcc });
                        this.PaymentId.Filters.Add(new PopupFieldFilter { ParameterName = "Currency", Type = PopupFieldFilterTypes.Value, Value = payment.Currency });
                        this.InvId.Filters.Add(new PopupFieldFilter { ParameterName = "ARNumber", Type = PopupFieldFilterTypes.Value, Value = payment.CustomerAcc });
                        this.InvId.Filters.Add(new PopupFieldFilter { ParameterName = "Currency", Type = PopupFieldFilterTypes.Value, Value = payment.Currency });
                    }
                    break;
            }
            this.ReverseButton.FieldValue = "1";
            ReversalCode();

            if (this.DataSource != null && !String.IsNullOrEmpty(this.DataSource.Id))
            {
                LockField(this.InvId);
                LockField(this.PaymentId);
                LockField(this.Value);
            }

        }

        protected override void RegisterJavascript()
        {

            this.PaymentId.ClientOnChange += @"
                if (this.getData() && (this.getValue() || '') != '' && this.getData().PAY_UNUSED_VAL) {
                    $('#" + this.UnusedValue.ClientID + @"Field').val(this.getData().PAY_UNUSED_VAL);                      
                }
                else{
                    $('#" + this.UnusedValue.ClientID + @"Field').val('0');
                }
                var unusedValue = $('#" + this.UnusedValue.ClientID + @"Field').val();
                var unpaidValue = $('#" + this.UnpaidValue.ClientID + @"Field').val();
                if(unusedValue && unpaidValue){
                    if(parseFloat(unusedValue) > parseFloat(unpaidValue)){
                        $('#" + this.Value.ClientID + @"Field').val(unpaidValue);
                    }
                    else{
                        $('#" + this.Value.ClientID + @"Field').val(unusedValue);
                    }                    
                }
                else{
                    $('#" + this.Value.ClientID + @"Field').val('0');
                }                
            ";

            this.InvId.ClientOnChange += @"
                if (this.getData() && (this.getValue() || '') != '' && this.getData().INV_UNPAID_VAL) {
                    $('#" + this.UnpaidValue.ClientID + @"Field').val(this.getData().INV_UNPAID_VAL);                      
                }
                else{
                    $('#" + this.UnpaidValue.ClientID + @"Field').val('0');
                }
                var unusedValue = $('#" + this.UnusedValue.ClientID + @"Field').val();
                var unpaidValue = $('#" + this.UnpaidValue.ClientID + @"Field').val();
                if(unusedValue && unpaidValue){
                    if(parseFloat(unusedValue) > parseFloat(unpaidValue)){
                        $('#" + this.Value.ClientID + @"Field').val(unpaidValue);
                    }
                    else{
                        $('#" + this.Value.ClientID + @"Field').val(unusedValue);
                    }                    
                }
                else{
                    $('#" + this.Value.ClientID + @"Field').val('0');
                }                
            ";

        }

        /// <summary>
        /// Reverse functionality
        /// </summary>
        public void ReversalCode()
        {
            if (this.DataSource != null)
            {
                //Sets Type value depending on Payment option whether its Credit note, Invoice or Reversal
                if (String.IsNullOrEmpty(this.DataSource.ReversesPaId))
                {
                    if (String.IsNullOrEmpty(this.DataSource.PayId.TypeCode))
                    {
                        this.Type.FieldValue = "Credit note";
                    }
                    else
                    {
                        //Checks if Refund Id is there
                        if (String.IsNullOrEmpty(this.DataSource.RefundId))
                        {
                            this.Type.FieldValue = this.DataSource.PayId.TypeCode;
                        }
                        else
                        {
                            this.Type.FieldValue = Payment.FetchById(this.DataSource.RefundId).TypeCode;
                        }
                    }
                }
                else
                {
                    this.Type.FieldValue = "Reversal";
                }

                //Sets the visibility of reverse button
                var reverse = PayAllocation.FetchAll();
                var reversecheck = reverse.Where(i => i.ReversesPaId == this.DataSource.Id).ToList();
                if (reversecheck.Count > 0)
                {                    
                    this.ReverseButton.FieldValue = "0";
                }
                var rev = PayAllocation.FetchById(this.DataSource.Id);
                if (rev.ReversesPaId != null)
                {
                    this.ReverseButton.FieldValue = "0";
                }
                if (rev.RefundId != null)
                {
                    this.ReverseButton.FieldValue = "0";
                }

                if (this.AllocationType != "payment")
                {
                    this.ReverseButton.FieldValue = "0";
                }

                this.Page.ClientScript.RegisterStartupScript(this.GetType(), this.UniqueID, @"
                function reverseallocation()
                {
                    window.top.swal.call(window.top,{title:'Are you sure',text:'Are you sure you want to reverse the payment?',type:'warning',showCancelButton:true,confirmButtonText:'Yes',cancelButtonText:'No',confirmButtonClass:'btn btn-danger',cancelButtonClass:'btn btn-default',buttonStyling:false}).then(function(){
                    
                    var state=consensus.data.getState();
                    if(!state){
                        window.closePopup();
                    }
                    else{
                         state.object = jQuery.extend(true, {Reverse: 1}, state.object);
                         state.object.uri='finance/payallocation';
                         var data=state.createObject();
                         data.Reverse=1;
                         data.PAID=$('#" + this.AllocationID.ClientID + @"Field').val();
                       
                        consensus.network.send({
                            method:'post',
                            url:state.object.uri,
                            data:data,
                            success:function(result){
                            window.closePopup();
                            parent.location.reload();
                        }
                    
                    });
                    }
                    });
                    };", true);
            }
            else
            {
                this.ReverseButton.FieldValue = "0";
            }
        }

        private void LockField(BaseInputControl control)
        {
            control.IsReadOnly = ConfigurableBoolean.TrueEnforced;
        }

        #endregion
    }
}