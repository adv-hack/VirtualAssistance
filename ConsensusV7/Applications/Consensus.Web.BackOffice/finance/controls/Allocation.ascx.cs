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
    public partial class Allocation : BaseControl<PayAllocation, String>
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
                if (this.AllocationType.Equals("credit"))
                    return "Credit Note Allocation";
                else if (this.AllocationType.Equals("invoice"))
                    return "Invoice Allocation";
                else
                    return "Payment Allocation";
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

        protected override void PopulateControl()
        {
            base.PopulateControl();
        }
        private void LockField(BaseInputControl control)
        {
            control.IsReadOnly = ConfigurableBoolean.TrueEnforced;
        }

        protected override void OnPreRender(EventArgs e)
        {
            base.OnPreRender(e);
            this.LockField(this.AllocationID);
            this.LockField(this.PaymentID);
            this.LockField(this.InvRef);
            this.LockField(this.CurrType);
            this.LockField(this.CreditNoteRef);
            this.LockField(this.Value);
            this.LockField(this.Type);
            this.LockField(this.Date);

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
                this.Reverse.Visible = false;
            }
            var rev = PayAllocation.FetchById(this.DataSource.Id);
            if (rev.ReversesPaId != null)
            {
                this.Reverse.Visible = false;
            }
            if (rev.RefundId != null)
            {
                this.Reverse.Visible = false;
            }

            if (this.AllocationType != "payment")
            {
                this.Reverse.Visible = false;
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
    }
}