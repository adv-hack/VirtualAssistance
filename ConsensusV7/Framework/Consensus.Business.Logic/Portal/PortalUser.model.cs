using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using Consensus.Portal;

namespace Consensus.Portal
{
    /// <summary>
    ///     Encapsulates the <see cref="PortalUserRecord" /> with standardised business rules.
    /// </summary>
    public partial class LocalPortalUserModel
    {

        #region fields

        /// <summary>
        ///     The new password entered from reset password screen.
        /// </summary>
        private String _newPassword;


        #endregion

        #region properties

        /// <summary>
        ///     Gets or sets the new password entered from reset password screen.
        /// </summary>
        public String NewPassword
        {
            get
            {
                return _newPassword;
            }
            set
            {
                _newPassword = value;
            }
        }

        /// <summary>
        ///     sets the password
        /// </summary>
        public String Password
        {
            set { this.ModifiedData.Password = value.ConvertTo<String>(); }
        }

        public override Boolean IsModified
        {
            get { return base.IsModified || this.NewPassword != null; }
        }

        #endregion

        #region methods

        /// <summary>
        ///     Provides denormalisation of the activity data, prior to persistence.
        /// </summary>
        protected internal override void Denormalise()
        {
            base.Denormalise();
            if (this.NewPassword != null)
            {
                this.Password = LTM.Encryption.PC1.Encrypt(this.NewPassword);
            }
        }

        public void UpdateUserRoles(ArrayList portaluserRoles)
        {
            
            foreach (Dictionary<String, Object> portaluserRole in portaluserRoles)
            {   
                //If Role is selected
                if (portaluserRole["SELECTED"].ConvertTo<bool>())                
                {
                    if  (String.IsNullOrEmpty(portaluserRole["PUR_ID"].ConvertTo<String>()))
                    {
                        LocalPortalUserRoleModel model = new LocalPortalUserRoleModel(this.Provider) { PortalUserId = this.Id, PortalRoleId = portaluserRole["PR_ID"].ConvertTo<Int32>()};
                            model.Save();                   
                    }

                }
                //If Role is unselected
                if (!portaluserRole["SELECTED"].ConvertTo<bool>())
                {
                    LocalPortalUserRoleModel UserRole = this.PortalUserRoles.FirstOrDefault(ps => ps.Id == portaluserRole["PUR_ID"].ConvertTo<Int32>());
                    //If Role exists delete it
                    if (UserRole != null)
                    {
                        UserRole.Delete();
                    }

                }
            }
        }

        public void UpdateUserPortals(ArrayList portaluserPortals)
        {

            foreach (Dictionary<String, Object> portaluserPortal in portaluserPortals)
            {
                //If Portal is selected
                if (portaluserPortal["SELECTED"].ConvertTo<bool>())
                {
                    if (String.IsNullOrEmpty(portaluserPortal["PUSTE_ID"].ConvertTo<String>()))
                    {
                        LocalPortalUserSiteModel model = new LocalPortalUserSiteModel(this.Provider) { PortalUserId = this.Id, PortalSetupId = portaluserPortal["PS_ID"].ConvertTo<Int32>() };
                        model.Save();
                    }

                }
                //If Portal is unselected
                if (!portaluserPortal["SELECTED"].ConvertTo<bool>())
                {
                    LocalPortalUserSiteModel UserSite = this.PortalUserSites.FirstOrDefault(ps => ps.Id == portaluserPortal["PUSTE_ID"].ConvertTo<Int32>());
                    //If Portal exists delete it
                    if (UserSite != null)
                    {
                        UserSite.Delete();
                    }

                }
            }
        }


        #endregion
    }
}
