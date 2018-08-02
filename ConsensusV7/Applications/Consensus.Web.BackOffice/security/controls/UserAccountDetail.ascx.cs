using Consensus.Security;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Consensus.Web.BackOffice.security.controls
{
    public partial class UserAccountDetail : BaseControl<UserAccount, Int32>
    {
        /// <summary>
        ///     Gets the name of the data type being modified
        /// </summary>
        public override String DataTypeName
        {
            get { return "User Account"; }
        }

        /// <summary>
        ///     Initialises the control
        /// </summary>
        protected override void PopulateControl()
        {
            base.PopulateControl();

            //Checks whether user is admin or accesses his own user account
            if (this.DataSource.Person.ActiveUserAccount.Id == CurrentSession.User.Id || CurrentSession.User.SysAdmin == 1)
            {
                this.SellingCompany.DataSource = Common.SellingCompany.FetchAll();
                this.Password.FieldValue = "********";
                this.LastLogin.FieldValue = this.DataSource.LastLogin.ToString();
                this.LicenceType.DataSource = this.PopulateLicenseList();

                if (this.DataSource != null)
                {
                    this.Person.IsReadOnly = UserInterface.ConfigurableBoolean.True;
                    if (this.DataSource.Id == 0)
                    {
                        var personId = this.Request.QueryString["personId"];
                        var personObject = Contact.Person.FetchById(personId);
                        if (personObject != null)
                        {
                            this.Person.FieldValue = personObject.Id;
                            this.Person.FieldText = personObject.FullName;
                            this.Organisation.FieldValue = personObject.PrincipalRole.OrganisationId;
                            this.Organisation.FieldText = personObject.PrincipalRole.Organisation.Name;
                            this.Address.FieldValue = personObject.PrincipalRole.Address.MailString;
                            this.Phone.FieldValue = personObject.PrincipalRole.Telephone;
                            this.Email.FieldValue = personObject.PrincipalRole.Email;
                        }
                        this.UserBarred.FieldValue = true;
                        this.LicenceType.FieldValue = LicenseLimitTypes.PoolA.ConvertTo<Int32>().ToString();
                    }
                    else
                    {
                        //Sets checkbox value depending on Status
                        if (this.DataSource.Status == 1)
                        {
                            this.UserBarred.FieldValue = true;
                        }
                        else
                        {
                            this.UserBarred.FieldValue = false;
                        }
                    }
                }
            }
            else
            {
                HttpContext.Current.Response.Clear();
                HttpContext.Current.Response.StatusCode = 403;
                HttpContext.Current.Response.End();
            }
        }

        protected override void OnInit(EventArgs e)
        {
            base.OnInit(e);

            if (CurrentSession.User.SysAdmin != 1)
            {
                this.SysAdmin.IsReadOnly = UserInterface.ConfigurableBoolean.True;
            }
        }

        /// <summary>
        /// Populates License List
        /// </summary>
        /// <returns></returns>
        private object PopulateLicenseList()
        {
            List<KeyValuePair<String, String>> licenseList = new List<KeyValuePair<String, String>>();
            licenseList.Add(new KeyValuePair<string, string>("0", "Pool A"));
            licenseList.Add(new KeyValuePair<string, string>("1", "Pool B"));
            return licenseList;
        }
    }
}