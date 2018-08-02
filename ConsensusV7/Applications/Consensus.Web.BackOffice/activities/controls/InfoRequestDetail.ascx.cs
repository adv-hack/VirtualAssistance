using Consensus.Activities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Consensus.Web.BackOffice.activities.controls
{
    public partial class InfoRequestDetail : BaseControl<Helpdesk, String>
    {

        #region properties

        public override string DataTypeName
        {
            get { return "Information Request"; }
        }

        #endregion

        #region Methods        

        protected override void OnPreRender(EventArgs eventArguments)
        {
            base.OnPreRender(eventArguments);
            this.Type.FieldValue = "2";
            this.SellingCompany.DataSource = Common.SellingCompany.FetchAll();
            this.Priority.DataSource = this.PopulatePriorityList();

            //Defaults for new Information Request
            if (this.DataSource == null || this.DataSource.Id == null)
            {
                this.SellingCompany.FieldValue = this.CurrentSession.User.SellingCompanyId;
                this.AssignedToId.FieldValue = this.CurrentSession.User.Person.PrincipalRole.Id;
                this.AssignedToId.FieldText = this.CurrentSession.User.Person.FullName;
            }
            else
            {
                this.SellingCompany.FieldValue = this.DataSource.SelcoSpIdId;
            }
        }

        protected override void RegisterJavascript()
        {
            this.PersonRole.ClientOnChange += @"
                if (this.getData() && (this.getValue() || '') != '') {
                    if (this.getData().organisation.id && this.getData().organisation.id.length != 0) {
                        " + this.Organisation.ClientID + @".setValue(this.getData().organisation.id, this.getData().organisation.name);
                    } else {
                        " + this.Organisation.ClientID + @".setValue('');
                    }                   
                }
            ";
        }

        /// <summary>
        /// Populates Priority List
        /// </summary>
        /// <returns></returns>
        private object PopulatePriorityList()
        {
            List<KeyValuePair<String, String>> priorityList = new List<KeyValuePair<String, String>>();
            priorityList.Add(new KeyValuePair<string, string>("1", "1"));
            priorityList.Add(new KeyValuePair<string, string>("2", "2"));
            priorityList.Add(new KeyValuePair<string, string>("3", "3"));
            priorityList.Add(new KeyValuePair<string, string>("4", "4"));
            priorityList.Add(new KeyValuePair<string, string>("5", "5"));
            return priorityList;
        }

        #endregion
    }
}