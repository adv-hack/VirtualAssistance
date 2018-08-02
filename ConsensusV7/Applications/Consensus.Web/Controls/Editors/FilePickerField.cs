using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;
using System.Web.Script.Serialization;
using System.IO;

namespace Consensus.Web.Controls
{
    /// <summary>
    ///     Renders a free-text input control.
    /// </summary>    
    public class FilePickerField : HiddenField, ICanBeMandatory, ICanBeHidden, ICanBeReadOnly, IHaveCustomTitle, ICanBeValidated
    {
        private string _title = "Add files..";
        private bool _singleFile = false;
        private Dictionary<string, string> _params;

        public string Title
        {
            get { return _title; }
            set { _title = value; }
        }   
        
        public string URL { get; set; }
        public bool AutoUpload { get; set; }
        public bool SingleFile
        {
            get { return _singleFile; }
            set
            {
                _singleFile = value;
                if (_title == "Add files..." && value)
                    _title = "Select file...";
                else if (_title == "Select file..." && !value)
                    _title = "Add files...";
            }
        }
        public Dictionary<string, string> Parameters
        {
            get
            {
                if (_params == null)
                    _params = new Dictionary<string, string>();
                return _params;
            }
        } 

        protected override void InitialiseControlTree()
        {
            base.InitialiseControlTree();
        }

        protected override void InitialiseControlState()
        { 
            base.InitialiseControlState();

            this.Label.Visible = this.Visible;
            this.Error.Visible = this.Visible;
            this.GroupClass = "input-group";

            JavaScriptSerializer serializer = new JavaScriptSerializer();

            if (this.Visible)
            {
                // Construct the configuration for the popup
                StringBuilder javascript = new StringBuilder();
                javascript.AppendFormat("var {0} = new consensus.web.filePickerField('{0}', {{" + Environment.NewLine, this.ClientID);
                javascript.AppendLine(" autoUpload: " + AutoUpload.ToString().ToLower() + ",");
                javascript.AppendLine(" singleFile: " + SingleFile.ToString().ToLower() + ",");
                javascript.AppendLine(" title: " + HttpUtility.JavaScriptStringEncode(Title, true) + ",");
                javascript.AppendLine(" url: " + HttpUtility.JavaScriptStringEncode(URL, true) + ",");
                javascript.AppendLine(" params: " + serializer.Serialize(this.Parameters) + ",");
                javascript.AppendFormat("}});");

                // Register the javascript
                this.Page.ClientScript.RegisterStartupScript(this.GetType(), this.UniqueID, javascript.ToString(), true);

                if (!this.Page.ClientScript.IsClientScriptBlockRegistered("_filePickerTemplate"))
                {
                    string template = ReadFilePickerTemplate();
                    this.Page.ClientScript.RegisterClientScriptBlock(this.GetType(), "_filePickerTemplate", template, false);
                }
            }
        }
        protected override void Render(HtmlTextWriter writer)
        {
            base.Render(writer);
        }

        private string ReadFilePickerTemplate()
        {
            return File.ReadAllText(this.Page.Server.MapPath("~/assets/htmltemplates/FilePickerFieldTemplate.html"));
        }
    }
}
