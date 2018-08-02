using System;
using Consensus.Contact;
using System.Collections.Generic;
using System.Linq;
using Consensus.Searches;

namespace Consensus.Web.BackOffice.crm.controls
{
    public partial class TimeLogDetail : BaseControl<TimeSpent, String>
    {
        public override String DataTypeName
        {
            get { return "Time Log"; }
        }
        protected override void PopulateControl()
        {
            base.PopulateControl();

        }

        /// <summary>
        /// THe time log is for Trainer or Volunteer
        /// </summary>
        private string _timelogFor;

        /// <summary>
        /// THe time log is for Trainer or Volunteer
        /// </summary>
        public string TimeLogFor
        {
            get { return _timelogFor; }
            set { _timelogFor = value; }

        }

        /// <summary>
        ///     Gets the delegated method for loading the API object that is presented within the page.
        /// </summary>
        public override Func<string, TimeSpent> DataLoader
        {
            get { return TimeSpent.FetchById; }
        }

        protected override void OnInit(EventArgs e)
        {
            string RoleId = this.Request.QueryString["RoleId"];
            this.TimeLogFor = this.Request.QueryString["TimeLogFor"];
            this.TIM_TRAIN_SY_TYPE.FieldValue = this.TimeLogFor == "Associate" ? Convert.ToInt32(TrainerSyType.Associate).ToString() : Convert.ToInt32(TrainerSyType.Volunteer).ToString();
            if (this.DataSource == null)
            {
                this.Date.FieldValue = DateTime.Now.Date;
                if (!string.IsNullOrEmpty(RoleId))
                {
                    this.Person.FieldValue = RoleId;
                    this.Person.FieldText = Role.FetchById(RoleId).PersonName;
                }

            }
            base.OnInit(e);
        }

        protected override void OnPreRender(EventArgs e)
        {
            base.OnPreRender(e);

            Controls.PopupField pField = Person;

            pField.Filters.Add(new Web.Controls.PopupFieldFilter()
            {
                Type = Web.Controls.PopupFieldFilterTypes.Value,
                ParameterName = "personType",
                Value = TimeLogFor == "Associate" ? "Associate" : "Volunteer"
            });

            if (this.DataSource != null)
            {
                if (!string.IsNullOrEmpty(this.DataSource.ActId) && this.DataSource.Type == "Activity")
                {
                    this.Activity.FieldValue = this.DataSource.ActId;
                    Activities.Activity activity = Activities.Activity.FetchById(this.DataSource.ActId);
                    if (activity != null)
                        this.Activity.FieldText = Activities.Activity.FetchById(this.DataSource.ActId).Name;
                }
                else if (!string.IsNullOrEmpty(this.DataSource.ActId) && this.DataSource.Type == "Session")
                {
                    var sessionObject = Learning.SessionXref.FetchAllBySessionId(this.DataSource.ActId);
                    if (sessionObject.Any())
                    {
                        var eventId = sessionObject.First().EventId;
                        Learning.Event eventobj = Learning.Event.FetchById(eventId);
                        if (eventobj != null)
                        {
                            this.Event.FieldText = eventobj.Product.Name;
                            this.Event.FieldValue = eventId;
                            this.EventId.FieldValue = this.DataSource.ActId;
                        }
                    }

                }

            }
            var sessionFields = new List<KeyValuePair<string, string>>();

            //Query to get all the sessions in the DB
            var sessionsList = Query.Create()
                    .Select("ACT_ID")
                    .Select("ACT_SESSION_NAME")
                    .Select("ACT_ACTION_DATE")
                    .Select("ACT_START_TIME")
                    .Select("SXREF_COURSE_ID")
                    .From(QuerySources.Sessions);

            //Fetch all sessions
            var allSessionsFromView = sessionsList.Run();

            foreach (var field in allSessionsFromView)
            {
                string startTime = string.IsNullOrEmpty(field.Values.ToList()[3].ToString()) ? "00:00" : field.Values.ToList()[3].ToString();
                string courseId = string.IsNullOrEmpty(field.Values.ToList()[4].ToString()) ? "" : "=" + field.Values.ToList()[4].ToString();
                string DisplayValue = string.Format(field.Values.ToList()[1] + " (" + field.Values.ToList()[2].ConvertTo<DateTime>().Date.ToString("dd/MMM/yyyy") + " - " + startTime + ")" + courseId);
                sessionFields.Add(new KeyValuePair<string, string>(field.Values.First().ToString(), DisplayValue));
            }

            this.ServerSessionList.DataSource = sessionFields;



        }
    }
}