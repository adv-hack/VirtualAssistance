using Consensus.Web.BackOffice.assets.templates;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.RegularExpressions;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Reflection;

namespace Consensus.Web.BackOffice.common.controls
{
    public partial class CustomisationDetail : BaseControl
    {
        /// <summary>
        ///     The cached collection of supported icons.
        /// </summary>
        private static String[] _icons;

        /// <summary>
        ///    Gets the cached collection of supported icons.
        /// </summary>
        public static String[] Icons
        {
            get
            {
                if (_icons == null)
                {
                    Regex pattern = new Regex("\\.icons8-([\\w-_]+)", RegexOptions.IgnoreCase);
                    String fileName = HttpContext.Current.Server.MapPath("~/assets/plugins/icons8/icons8.css");
                    String fileText = File.ReadAllText(fileName);
                    _icons = pattern.Matches(fileText).OfType<Match>().Select(match => match.Captures[0].Value.Substring(8)).ToArray();
                }
                return _icons;
            }
        }

        public override String DataTypeName
        {
            get { return "Customisation"; }
        }

        protected override void OnInit(EventArgs e)
        {
            base.OnInit(e);
            // This is far too slow to render. Need to pick a new icon in a different way...
            //foreach (String icon in CustomisationDetail.Icons)
            //    this.Icon.Items.Add(new ListItem(icon.ToPascal(" ").Trim(), icon));
            CustomFieldType.DataSource = UserInterface.ScreenCustomFieldType.FetchAll();

            // Find all web controls derived from class BasePopupSearchPage in the BackOffice site
            // This is inherently difficalt to do, given that what we actually want is the location of
            // the .ascx file in the filesystem, not the namespace and class.
            // This works OK, but note that the class name must match the file name (ignoring .aspx extension) and must be unique within the assembly, not just the namespace
            // It is assumed that the class name will end with "Search", though this is for the display name only.
            string rootPath = HttpContext.Current.Server.MapPath("~/");
            List<string> ascxFiles = new List<string>();
            getFilesOfExtension(ascxFiles, rootPath, "aspx");
            Assembly backOffice = Assembly.GetExecutingAssembly();
            var searchClasses = backOffice.GetTypes().Where(ctype => ctype.Namespace != null && ctype.Namespace.StartsWith("Consensus") && ctype.IsSubclassOf(typeof(BasePopupSearchPage))).ToList();

            List<ListItem> popupUrls = new List<ListItem>();
            foreach (Type searchClass in searchClasses)
            {
                string fileName = ascxFiles.Find(c => c.EndsWith(searchClass.Name + ".aspx", StringComparison.InvariantCultureIgnoreCase));
                if (!string.IsNullOrEmpty(fileName))
                {
                    popupUrls.Add(new ListItem(searchClass.Name.Replace("Search", ""), "~/" + fileName.Replace(rootPath, "").Replace("\\", "/")));
                }
            }
            popupUrls.Sort((a, b) => string.Compare(a.Text, b.Text));
            CustomPopupUrl.DataSource = popupUrls;

            TabUserFieldListTable.Data = "customField.CustomFieldListItems";

            DeleteMessage = "Delete this custom field? Note that all data previously saved for this custom field will be removed.";

            TabUserFieldListTableButtons.CssClass = "consensus-visible-edit";
            TabUserFieldListTableButtons.Buttons.Add(new Web.Controls.DataTableButtonColumnItem() { Icon = "delete", Tooltip = "Delete", OnClick = "deleteRow(this)" });
        }

        private void getFilesOfExtension(List<string> files, string path, string extension)
        {
            foreach (string dirPath in System.IO.Directory.GetDirectories(path))
            {
                getFilesOfExtension(files, dirPath, extension);
            }
            files.AddRange(System.IO.Directory.GetFiles(path, "*." + extension));
        }

        protected override void OnPreRender(EventArgs e)
        {
            base.OnPreRender(e);
            (this.Page.Master as Popup).CustomiseButton.Visible = false;
        }

        public string getSecurityJSON()
        {
            CustomisationSecurity[] customisationSecurities = Security.UserGroup.FetchAll().Select(group => new CustomisationSecurity(group.Principal)).ToArray();
            return RestHandler.Serializer.Serialize(customisationSecurities);
        }
    }
}