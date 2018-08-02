using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Consensus.Contact;
using Consensus.Common;
using Consensus.Activities;
using Consensus.Sales;

namespace Consensus.Web.BackOffice.crm.controls
{
    public partial class ActivityDetailBasic : BaseControl<Activity, string>
    {
        public override String DataTypeName
        {
            get { return "Activity"; }
        }

        /// <summary>
        ///     Gets the delegated method for loading the API object that is presented within the page.
        /// </summary>
        public override Func<string, Activity> DataLoader
        {
            get { return Activity.FetchById; }
        }
                
        protected override void PopulateControl()
        {
            base.PopulateControl();

            if (this.DataSource != null)
            {
                this.SellingCompanyName.DataSource = Common.SellingCompany.FetchAll();
                this.SellingCompanyName.FieldValue = this.DataSource.SellingCompanyId;
            }
        }

        protected override void OnInit(EventArgs e)
        {
            base.OnInit(e);

            String refId = this.Request.QueryString["refid"];
            String refMode = this.Request.QueryString["refmode"];
            //if (!String.IsNullOrEmpty(refMode))
            //{
                // ActivityList.ActivityListMode mode = refMode.ConvertTo<ActivityList.ActivityListMode>();
                // switch (mode)
                // {
                //     case ActivityList.ActivityListMode.PN_ID:
                //         if (this.DataSource != null && String.Equals(this.DataSource.EndUser.PersonRoleId, this.Request.QueryString["refid"])
                // 
                // }
            //}
            conAttachments.DataTable.CanCreateInEditMode = true;
            conAttachments.DataTable.CanModifyInEditMode = true;
            conAttachments.DataTable.OnChange = "return refreshAttachmentsGrid()";

            if (string.IsNullOrEmpty(this.DataId))
            {
                this.tabAttachments.Visible = false;
            }
        }

        protected override void OnPreRender(EventArgs e)
        {
            base.OnPreRender(e);

            this.SellingCompanyName.DataSource = Common.SellingCompany.FetchAll();
            if (this.DataSource == null)
            {
              this.SellingCompanyName.FieldValue = CurrentSession.User.SellingCompanyId;
                
            }

            string pRefid = this.Request.QueryString["refid"];
            string pRefmode = this.Request.QueryString["refmode"];

            if (!string.IsNullOrEmpty(pRefmode))
            {
                ActivityList.ActivityListMode eRefMode = (ActivityList.ActivityListMode)Enum.Parse(typeof(ActivityList.ActivityListMode), pRefmode);

                if ((int)eRefMode < 0)
                {
                    Controls.PopupField pField = EndUser;
                    string personFirstName = "";
                    string personSurname = "";
                    string orgName = "";

                    // If opening for Role, set EndUser or SalesPerson to that role on insert, depending on if this is our user
                    if (eRefMode == ActivityList.ActivityListMode.PROLE_ID)
                    {
                        if (this.DataSource == null)
                        {
                            Role pRole = Role.FetchById(pRefid);

                            if (this.DataSource != null && this.DataSource.EndUser.PersonRoleId != pRefid && this.DataSource.SalesPerson.PersonRoleId == pRefid)
                            {
                                pField = SalesPerson;
                            }

                            personFirstName = pRole.Person.FirstName;
                            personSurname = pRole.Person.Surname;
                            orgName = pRole.Organisation.Name;

                            if (pRole.Person.OurPerson.HasValue && pRole.Person.OurPerson.Value == 1)
                            {
                                SalesPerson.FieldValue = pRefid;
                                SalesPerson.FieldText = pRole.PersonName;
                            }
                            else
                            {
                                EndUser.FieldValue = pRefid;
                                EndUser.FieldText = pRole.PersonName;
                            }
                        }
                    }
                    // Else if opening for Person, limit the picklist to Roles for that person only. 
                    // Limit the sales person picklist rather than the end user if they are the match to the passed person on update.
                    else if (eRefMode == ActivityList.ActivityListMode.PN_ID)
                    {
                        Person pPerson = Person.FetchById(pRefid);

                        if (this.DataSource != null && this.DataSource.EndUser.PersonId != pRefid && this.DataSource.SalesPerson.PersonId == pRefid)
                        {
                            pField = SalesPerson;
                        }

                        personFirstName = pPerson.FirstName;
                        personSurname = pPerson.Surname;

                        // .. and (if inserting) set the end user or sales person to the principal role for the person.
                        if (this.DataSource == null)
                        {
                            if (pPerson.OurPerson.HasValue && pPerson.OurPerson.Value == 1)
                            {
                                SalesPerson.FieldValue = pPerson.PrincipalRole.Id;
                                SalesPerson.FieldText = pPerson.PrincipalRole.PersonName;
                            }
                            else
                            {
                                EndUser.FieldValue = pPerson.PrincipalRole.Id;
                                EndUser.FieldText = pPerson.PrincipalRole.PersonName;
                                EndUser_PersonID.FieldValue = pPerson.Id;
                                EndUser_PnName.FieldValue = pPerson.FullName;
                            }
                        }
                    }
                    // Else if opening for Organisation, show Roles for that organisaction only
                    else if (eRefMode == ActivityList.ActivityListMode.ORG_ID)
                    {
                        Organisation pOrg = Organisation.FetchById(pRefid);

                        if (this.DataSource != null && this.DataSource.EndUser.OrganisationId != pRefid && this.DataSource.SalesPerson.OrganisationId == pRefid)
                        {
                            pField = SalesPerson;
                        }

                        orgName = pOrg.Name;
                    }
                    // Else if opening for Opportunity, assume the end user has a role in the client organisation.
                    else if (eRefMode == ActivityList.ActivityListMode.OPP_ID)
                    {

                        Opportunity pOpp = Opportunity.FetchById(pRefid);

                        orgName = pOpp.ClientOppXref.Organisation.Name;
                        //if(this.DataSource !=null && this.DataSource.EndUser)
                    }

                    if (!string.IsNullOrEmpty(personFirstName))
                    {
                        pField.Filters.Add(new Web.Controls.PopupFieldFilter()
                        {
                            Type = Web.Controls.PopupFieldFilterTypes.Value,
                            ParameterName = "personFirstName",
                            Value = personFirstName
                        });
                    }
                    if (!string.IsNullOrEmpty(personSurname))
                    {
                        pField.Filters.Add(new Web.Controls.PopupFieldFilter()
                        {
                            Type = Web.Controls.PopupFieldFilterTypes.Value,
                            ParameterName = "personSurname",
                            Value = personSurname
                        });
                    }
                    if (!string.IsNullOrEmpty(orgName))
                    {
                        pField.Filters.Add(new Web.Controls.PopupFieldFilter()
                        {
                            Type = Web.Controls.PopupFieldFilterTypes.Value,
                            ParameterName = "orgText",
                            Value = orgName
                        });
                    }
                }
            }
            


            string pType = this.Request.QueryString["reftype"];
            if (pType == "Letter")
            {
                Type.DataSource = Code.FetchAllByType("ACT").Where(c => c.Value1 == "Letter" || c.Value1 == "Email" ||c.Value1== "Phone");
            }
            else if (pType == "D-")
            {
                Type.DataSource = Code.FetchAllByType("ACT").Where(c => c.Value1.StartsWith("D-"));
            }

            if (this.SalesPerson.FieldValue.Length == 0)
            {
              this.SalesPerson.FieldValue = CurrentSession.User.Person.PrincipalRole.Id;
              this.SalesPerson.FieldText = CurrentSession.User.Person.PrincipalRole.PersonName;
            }
            
            if (this.StartDate.FieldValue.ToString() == "")
            {
              this.StartDate.FieldValue = DateTime.Now.Date;
              this.StartTime.FieldValue = DateTime.Now;
            }

        }

        protected override void RegisterJavascript()
        {
            this.EndUser.ClientOnChange = @"
                var data = this.getData();
                 if (data && (data || '') != '') {     
                   " + this.EndUser_PersonID.ClientID + @"Field.value = data.pnId;
                " + this.EndUser_PnName.ClientID + @"Field.value = this.getText();}";
        }
    }
}