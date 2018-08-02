using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Consensus.Contact;
using Consensus.Common;
using Consensus.UserInterface;

namespace Consensus.Web.BackOffice.crm.controls
{
    public partial class CommunicationDetail : BaseControl<Communications_Xref, Int64>
    {
        public override String DataTypeName
        {
            get { return "Communication method"; }
        }

        /// <summary>
        ///     Gets the delegated method for loading the API object that is presented within the page.
        /// </summary>
        public override Func<Int64, Communications_Xref> DataLoader
        {
            get { return Communications_Xref.FetchById; }
        }

        protected override void OnInit(EventArgs e)
        {

            base.OnInit(e);
            if (this.DataSource == null)
            {
              this.ValidFrom.FieldValue = DateTime.Now.Date;
            }
        }
        protected override void PopulateControl()
        {
            //this.CommunicationType.FieldValue = this.DataSource.Communication.DeviceCodeCode;

            base.PopulateControl();

            switch (this.DataSource.Communication.DeviceCode.Value2)
            {
                case "Email":
                    this.DeviceValue.LabelText = "Email";
                    HideShowPhoneFields(false);
                    break;                               
                case "Web":
                    this.DeviceValue.LabelText = "Web";
                    HideShowPhoneFields(false);
                    break;
                default:
                    this.DeviceValue.LabelText = "Phone";
                    HideShowPhoneFields(true);
                    break;
            }
         
        }

        private void HideShowPhoneFields(Boolean visible)
        {
            this.DiallingCode.IsHidden = visible ? ConfigurableBoolean.FalseEnforced : ConfigurableBoolean.TrueEnforced;
            this.StdCode.IsHidden = visible ? ConfigurableBoolean.FalseEnforced : ConfigurableBoolean.TrueEnforced;
            this.Extension.IsHidden = visible ? ConfigurableBoolean.FalseEnforced : ConfigurableBoolean.TrueEnforced;
            this.ExDirectory.IsHidden = visible ? ConfigurableBoolean.FalseEnforced : ConfigurableBoolean.TrueEnforced;

        }

        
    }
}