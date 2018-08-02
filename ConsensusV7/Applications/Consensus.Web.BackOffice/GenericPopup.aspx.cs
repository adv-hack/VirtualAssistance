using Consensus.Web.Controls;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Text;

namespace Consensus.Web.BackOffice
{
    public partial class GenericPopup : BasePopupPage, IIsEditable
    {
        #region enum

        /// <summary>
        ///     Enumerates the buttons that should be displayed.
        /// </summary>
        [Flags]
        public enum ButtonStyle
        {
            /// <summary>
            ///     No buttons should be displayed.
            /// </summary>
            None = 0,

            /// <summary>
            ///     The buttons should be relabelled to OK/Cancel
            /// </summary>
            Stateful = 1,

            /// <summary>
            ///     The undo button should be displayed
            /// </summary>
            Undo = 2,

            /// <summary>
            ///     The save button should be displayed.
            /// </summary>
            Save = 4,

            /// <summary>
            ///     The delete button should be displayed.
            /// </summary>
            Delete = 8,

            /// <summary>
            ///     The send pack button should be displayed.
            /// </summary>
            SendPack = 16
        }

        #endregion

        #region fields

        /// <summary>
        ///     The buttons that are renderd in the footer of the popup.
        /// </summary>
        private ButtonStyle? _buttons;

        /// <summary>
        ///     The control to screenObjectDisplay within the popup page.
        /// </summary>
        private UserControl _control;


        #endregion

        #region properties

        /// <summary>
        ///     Gets the namespace for the control to screenObjectDisplay within the popup page.
        /// </summary>
        public String ControlContext
        {
            get { return this.Request.QueryString["context"]; }
        }

        /// <summary>
        ///     Gets the name for the control to screenObjectDisplay within the popup page.
        /// </summary>
        public String ControlName
        {
            get { return this.Request.QueryString["control"]; }
        }

        /// <summary>
        ///     Gets the virtual path for the control to screenObjectDisplay within the popup page. 
        /// </summary>
        private String ControlPath
        {
            get { return String.Format("~/{0}/controls/{1}.ascx", this.ControlContext, this.ControlName); }
        }

        /// <summary>
        ///    Gets the control to screenObjectDisplay within the popup page.
        /// </summary>
        public UserControl Control
        {
            get
            {
                if (_control == null)
                    _control = this.LoadControl(this.ControlPath) as UserControl;

                return _control;
            }
        }

        /// <summary>
        ///     Gets whether the page is initially rendered in editing mode.
        /// </summary>
        public Boolean IsEditable
        {
            get { return true; }
        }

        /// <summary>
        ///     Gets whether the page is record can be deleted
        /// </summary>
        public Boolean CanDelete
        {
            get
            {
                if (String.IsNullOrEmpty(this.Request.QueryString["id"]))
                    return false;
                else
                    return this.Control is BaseControl ? (this.Control as BaseControl).AllowDelete : true;
            }
        }

        /// <summary>
        ///     Suppresses the reloading of the parent page on save.
        /// </summary>
        public bool NoReload
        {
            get { return this.Request.QueryString["noreload"] == "1"; }
        }

        /// <summary>
        ///    Gets the buttons that are renderd in the footer of the popup.
        /// </summary>
        public ButtonStyle Buttons
        {
            get
            {
                if (_buttons == null)
                {
                    _buttons = ButtonStyle.Save | ButtonStyle.Undo | ButtonStyle.Delete;
                    if (String.Equals(this.Request.QueryString["persistence"], "stateful", StringComparison.OrdinalIgnoreCase))
                        _buttons |= ButtonStyle.Stateful;
                    if (!CanDelete)
                        _buttons -= ButtonStyle.Delete;
                    if (!String.IsNullOrEmpty(this.Request.QueryString["buttons"]))
                        _buttons = this.Request.QueryString["buttons"].ConvertTo(_buttons.Value);


                }

                return _buttons.Value;
            }
        }

        /// <summary>
        ///     Gets the dialog title for the popup page.
        /// </summary>
        public override String DialogTitle
        {
            get
            {
                if (!String.IsNullOrEmpty(this.Request.QueryString["title"]))
                    return this.Request.QueryString["title"];
                else
                    return this.Control is BaseControl ? (this.Control as BaseControl).DataTypeName : "";
            }
        }

        /// <summary>
        ///     Gets the dialog width for the popup page.
        /// </summary>
        public override UInt32 DialogWidth
        {
            get { return this.Request.QueryString["width"].ConvertTo<UInt32>(base.DialogWidth); }
        }

        public void SetInsertMode()
        {
            this.DeleteButton.Visible = false;
            this.SendPackButton.Visible = false;
        }

        #endregion

        #region page cycle

        /// <summary>
        ///     Initialise the control on the page
        /// </summary>
        protected override void OnInit(EventArgs e)
        {
            base.OnInit(e);
            this.Form.Attributes["data-mode"] += (this.IsEditable ? "edit" : "read");
            this.ControlContainer.Controls.Add(this.Control);

            this.SaveButton.Visible = ((this.Buttons & ButtonStyle.Save) == ButtonStyle.Save);
            this.SaveButton.Attributes["class"] += ((this.Buttons & ButtonStyle.Stateful) == ButtonStyle.Stateful) ? " btn-primary" : " btn-success";
            this.SaveButtonText.InnerText = ((this.Buttons & ButtonStyle.Stateful) == ButtonStyle.Stateful) ? "OK" : "Save";

            this.UndoButton.Visible = ((this.Buttons & ButtonStyle.Undo) == ButtonStyle.Undo);
            //this.UndoButton.Attributes["class"] += ((this.Buttons & ButtonStyle.Stateful) == ButtonStyle.Stateful) ? " btn-default" : " btn-warning";
            //this.UndoButtonText.InnerText = ((this.Buttons & ButtonStyle.Stateful) == ButtonStyle.Stateful) ? "Cancel" : "Undo";

            this.DeleteButton.Visible = ((this.Buttons & ButtonStyle.Delete) == ButtonStyle.Delete);
            this.SendPackButton.Visible = ((this.Buttons & ButtonStyle.SendPack) == ButtonStyle.SendPack);
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);

            if (this.Control is BaseControl)
            {
                object data;
                if (GetControlValue(this.Control, "DataSource", out data))
                {
                    object Id;
                    if (GetControlValue(data, "Id", out Id))
                        PopulateCustomFields(Id.ToString());
                }
            }
        }

        protected override void OnPreRender(EventArgs e)
        {
            base.OnPreRender(e);

            if (this.Buttons.HasFlag(ButtonStyle.Save))
            {
                StringBuilder sScript = new StringBuilder();

                sScript.Append(@"
                    function save() {
                        var openFrames = parent.frames.length;
                        var state = consensus.data.getState();                        
                        if (!state) {");
                if (!this.NoReload)
                {
                    sScript.Append(@"
                                if (openFrames <= 1) {                                    
                                    parent.location.reload(true); 
                                } ");
                }
                sScript.Append(@"
                            window.closePopup();                         
                        } else {
                            var validation = consensus.data.validation.check();
                            if (validation.formErrors == 0 && validation.pageErrors == 0) {
                                state.toggleSave('Saving...');
                                beforeSave(state, function() {
                                    state.updateObject();
                                    if (openFrames <= 1) {
                                        var dataMode = $('#DetailPageContent', parent.document).attr('data-mode')");
                if (!this.NoReload)
                {
                    sScript.Append(@"
                                        if(dataMode && dataMode == 'edit'){                                                                             
                                        }                                        
                                        else{
                                            parent.location.reload(true); 
                                        }");
                }
                sScript.Append(@"
                                    }
                                    if (location.href.toLocaleLowerCase().indexOf('producttemplatedetails') > -1) {
                                          saveProduct();
                                        }
                                    else{
                                    window.closePopup(state.createObject());
                                        if(location.href.toLocaleLowerCase().indexOf('opportunitypersondetail') > -1)
                                            parent.location.reload(true);
                                        
                                    }
                                });
                            }
                        }
                    };

                    if (!$.isFunction(beforeSave))
                    {
                        var beforeSave = function (state, callback) {
                            callback();
                        }
                    }

                    function getDeleteMessage() {
                        return 'Are you sure you want to delete this record?';
                    }

                    function deleteme() {
	                    window.top.swal.call(window.top, { title: 'Are you sure?', text: getDeleteMessage(), type: 'warning', showCancelButton: true, confirmButtonText: 'Yes', cancelButtonText: 'No', confirmButtonClass: 'btn btn-danger', cancelButtonClass: 'btn btn-default', buttonsStyling: false }).then(function () {

		                var openFrames = parent.frames.length;
                        var state = consensus.data.getState();
		                    if (!state) {");
                if (!this.NoReload)
                {
                    sScript.Append(@"
                                if (openFrames <= 1) {
                                    parent.location.reload(true); 
                                }");
                }
                sScript.Append(@"
			                    window.closePopup();
		                    } else {
                                    state.object.DeleteMe = 1;
				                    state.updateObject();
                                    if (openFrames <= 1) {
                                        var dataMode = $('#DetailPageContent', parent.document).attr('data-mode')");
                if (!this.NoReload)
                {
                    sScript.Append(@"
                                        if(dataMode && dataMode == 'edit'){                                                                             
                                        }
                                        else{
                                            parent.location.reload(true); 
                                        }  ");
                }
                sScript.Append(@"                                         
                                    }
                                    if (location.href.toLocaleLowerCase().indexOf('producttemplatedetails') > -1) {
                                          deleteProduct();
                                        }else{
				                    window.closePopup(state.object);                                
                                    }
			                    }
		                    });
	                }; ");
                this.Page.ClientScript.RegisterStartupScript(this.GetType(), this.UniqueID, sScript.ToString(), true);
            }

        }

        #endregion
    }
}