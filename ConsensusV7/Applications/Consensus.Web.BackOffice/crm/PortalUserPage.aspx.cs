using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Consensus.Portal;
using Consensus.Contact;

namespace Consensus.Web.BackOffice.crm
{
    public partial class PortalUserPage : BaseStandardPage<PortalUser, Int32>
    {
        #region properties

        /// <summary>
        ///     Gets the text displayed within the header of the page.
        /// </summary>
        public override String DefaultTitle
        {
            get { return "Portal User - " + this.Data.LoginId; }
        }

        /// <summary>
        ///     Gets the icon displayed within the header of the page.
        /// </summary>
        public override String DefaultIcon
        {
            get { return "user"; }
        }

        /// <summary>
        ///     Gets the delegated method for loading the API object that is presented within the page.
        /// </summary>
        public override Func<Int32, PortalUser> DataLoader
        {
            get { return PortalUser.FetchById; }
        }

        /// <summary>
        ///     Gets the delegated method for creating the API object that is presented within the page.
        /// </summary>
        public override Func<PortalUser> DataCreator
        {
            get { return PortalUser.Create; }
        }
        #endregion

        #region methods

        protected override void PopulateControls()
        {
            this.PortalUserDetail.DataSource = this.Data;
            this.PortalUserPortalsList.PortalUser = this.Data.Id.ToString();
            this.PortalUserRolesList.PortalUser = this.Data.Id.ToString();
           

            if (this.Data != null && String.IsNullOrEmpty(this.Data.AuthProvider))
            {
                if (this.Data.Id > 0)
                {
                    this.PopulateSideBar("javascript:resetPassword('" + this.Data.Id + "');", "Reset Password");
                }
                this.ClientScript.RegisterStartupScript(this.GetType(), this.UniqueID, @"
                function resetPassword(userId) {
                    consensus.web.popupFrame({
                        url: consensus.resolveUrl('~/GenericPopup.aspx?context=crm&control=resetPassword&userId=' + userId),
                        open: function () {
                            var button = $(this.window.document.body).find('#Content_PopupFooter_SaveButton');
                            var state = new consensus.data.state(button, { uri: 'portal/portaluser/' + userId }, this.window);
                            consensus.data.setState(state);
                        },
                        result: function (data) {
                          consensus.network.send({
                            method: 'put',
                            url: data.uri,
                            data: data,
                            success: function (result) {
                              window.location.href = consensus.resolveUrl('~/crm/portaluser?id=' + result.Id);
                            }
                          });
                        }
                    });
                }
                consensus.data.onsave = function(state, result, callback) {
                   savePortalUserPortals(state, result, callback);
                }
                consensus.data.onundo = function () {
                    location.reload();
                }

            ", true);
            }
            this.ClientScript.RegisterStartupScript(this.GetType(), this.UniqueID, @"
                consensus.data.onsave = function(state, result, callback) {
                  savePortalUserPortals(state, result, callback);
                }
                consensus.data.onundo = function () {
                    location.reload();
                }
            ", true);
        }

        protected override void PopulateLinks()
        {
            this.PopulateLink(this.BottomTabControl);
        }

        #endregion
    }
}