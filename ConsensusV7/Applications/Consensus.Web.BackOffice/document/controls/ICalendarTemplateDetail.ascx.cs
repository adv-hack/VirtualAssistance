using Consensus.Document;
using Consensus.Searches;
using Consensus.UserInterface;
using Consensus.Web.Controls;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Consensus.Web.BackOffice.document.controls
{
    public partial class ICalendarTemplateDetail : BaseControl<ICalMessage, String>
    {
        #region properties

        public override string DataTypeName
        {
            get { return "iCalendar template"; }
        }

        #endregion

        #region Methods  

        private void LockField(BaseInputControl control)
        {
            control.IsReadOnly = ConfigurableBoolean.TrueEnforced;
        }

        protected override void OnPreRender(EventArgs eventArguments)
        {
            base.OnPreRender(eventArguments);
            this.Type.DataSource = ICalMessageType.FetchAll();
            this.Appointments.DataSource = this.PopulateAppointmentList();
            this.SellingCompany.DataSource = Common.SellingCompany.FetchAll();
            var mergeFields = new List<KeyValuePair<string, string>>();

            //Query to get Merge Fields from View 
            var mergeFieldListFromView = Query.Create()
                   .Select("COLUMN_NAME")
                   .Select("ICMT_ID")
                   .From(QuerySources.MergeFields);          

            if (this.DataSource != null && this.DataSource.Id > 0)
            {
                this.LockField(this.Type);

                //Gets Merged fields based on selected type
                var selectedTypeMergeFieldsFromView = mergeFieldListFromView.Where("ICMT_ID", QueryConditionTypes.Equal, this.DataSource.ICalMessageTypeId.ToString()).Run();
                var mergedFieldsForEdit = new List<string>();
                foreach (var field in selectedTypeMergeFieldsFromView)
                {
                    mergedFieldsForEdit.Add(field.Values.First().ToString());
                }                
                this.SubjectMerge.DataSource = mergedFieldsForEdit;
                this.LocationMerge.DataSource = mergedFieldsForEdit;
                this.BodyMerge.DataSource = mergedFieldsForEdit;
            }
            else
            {
                this.SellingCompany.FieldValue = this.CurrentSession.User.SellingCompanyId;
                this.Appointments.FieldValue = "1";

                //Fetch all merge fields
                var allMergeFieldFromView = mergeFieldListFromView.Run();

                foreach (var field in allMergeFieldFromView)
                {
                    mergeFields.Add(new KeyValuePair<string, string>(field.Values.First().ToString(), field.Values.Last().ToString()));
                }

                this.AllMergeFields.DataSource = mergeFields;
            }
        }

        /// <summary>
        /// Populates Priority List
        /// </summary>
        /// <returns></returns>
        private object PopulateAppointmentList()
        {
            List<KeyValuePair<String, String>> appointmentList = new List<KeyValuePair<String, String>>();
            appointmentList.Add(new KeyValuePair<string, string>("All Sessions", "1"));
            appointmentList.Add(new KeyValuePair<string, string>("Main Session Only", "0"));
            appointmentList.Add(new KeyValuePair<string, string>("Published Calendar", "2"));
            return appointmentList;
        }


        #endregion
    }
}