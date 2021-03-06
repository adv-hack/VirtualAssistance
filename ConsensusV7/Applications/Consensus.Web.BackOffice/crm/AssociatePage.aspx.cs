﻿using Consensus.Contact;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Consensus.Web.BackOffice.crm
{
    public partial class AssociatePage : BaseStandardPage<Trainer, String>
    {
        #region Properties

        /// <summary>
        /// Gets the text displayed within the header of the page
        /// </summary>
        public override string DefaultTitle
        {
            get
            {
                return "Associate - " + this.Data.Role.PersonName;
            }
        }

        /// <summary>
        /// Gets the delegated method for loading the API object that is presented within the page
        /// </summary>
        public override Func<string, Trainer> DataLoader
        {
            get
            {
                return Trainer.FetchById;
            }
        }

        /// <summary>
        /// Gets the delegated method for creating the API object that is presented within the page
        /// </summary>
        public override Func<Trainer> DataCreator
        {
            get
            {
                return Trainer.Create;
            }
        }

        /// <summary>
        /// Gets the icon displayed within the header of the page.
        /// </summary>
        public override string DefaultIcon
        {
            get
            {
                return "training";
            }
        }

        #endregion

        #region Methods

        protected override void PopulateControls()
        {
            base.PopulateControls();
            this.TrainerDetail.DataSource = this.Data;
            this.AssociateCourseList.ParentId = this.Data.Id;
            this.TrainerNotesDetail.DataSource = this.Data;            
			this.TimeLogList.AssociateRoleId = this.Data.RoleId;
            this.TimeLogList.AssociateId1 = this.Data.Id;
            this.TimeLogList.TimeLogFor = "Associate";
			this.ProfileList.ProfileParentId = this.Data.Id;
            this.ProfileList.ProfileMode = ProfileList.ProfileListMode.PROF_TRAIN_ID;
        }

        protected override void PopulateLinks()
        {
            this.PopulateLink(this.BottomTabControl);
        }
        #endregion


    }
}