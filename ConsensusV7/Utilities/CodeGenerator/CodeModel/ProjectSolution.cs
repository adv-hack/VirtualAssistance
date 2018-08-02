using CodeGenerator.DataModel;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeGenerator.CodeModel
{
    /// <summary>
    ///     Represents a Microsoft Visual Studio solution.
    /// </summary>
    [Serializable]
    public class ProjectSolution
    {
        #region fields

        /// <summary>
        ///     The projects defined within the solution.
        /// </summary>
        private List<Project> _projects;

        #endregion

        #region properties

        /// <summary>
        ///     The prefix used for persisted application settings.
        /// </summary>
        private String Prefix { get; set; }

        /// <summary>
        ///     Gets or sets the database that the solution is generated for.
        /// </summary>
        public Database Database { get; set; }

        /// <summary>
        ///     Gets or sets the name of the solution.
        /// </summary>
        public String SolutionName { get; set; }

        /// <summary>
        ///     Gets or sets the root directory for the solution.
        /// </summary>
        public String SolutionPath { get; set; }

        /// <summary>
        ///     Gets or sets the release version for the solution
        /// </summary>
        public Version SolutionVersion { get; set; }

        /// <summary>
        ///     Gets the Microsoft.NET framework version to be targeted
        /// </summary>
        public String SolutionFramework { get; set; }

        /// <summary>
        ///     Gets the projects defined within the solution.
        /// </summary>
        public List<Project> Projects
        {
            get
            {
                if (_projects == null)
                    _projects = new List<Project>();

                return _projects;
            }
        }

        #endregion

        #region constructor

        public ProjectSolution(String prefix)
        {
            this.Prefix = prefix;
            this.SolutionName = this.GetApplicationSetting("SolutionName", "Consensus");
            this.SolutionPath = this.GetApplicationSetting("SolutionPath", "C:\\Development\\Consensus " + this.Prefix);
            this.SolutionVersion = this.GetApplicationVersion("SolutionVersion", "7.0.0");            
        }

        #endregion

        #region methods

        public void Save()
        {
            this.SetApplicationSetting("SolutionName", this.SolutionName);
            this.SetApplicationSetting("SolutionPath", this.SolutionPath);
            this.SetApplicationSetting("SolutionVersion", this.SolutionVersion.ToString());
        }

        private Version GetApplicationVersion(String name, String defaultValue)
        {
            Version configurationVersion;
            String configurationValue = this.GetApplicationSetting(name, defaultValue);
            if (!Version.TryParse(configurationValue, out configurationVersion))
                configurationVersion = new Version(1, 0);

            return configurationVersion;
        }

        private String GetApplicationSetting(String name, String defaultValue)
        {
            Configuration configuration = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
            String configurationValue = configuration.AppSettings.Settings.AllKeys.Contains(this.Prefix + ":" + name) ? configuration.AppSettings.Settings[this.Prefix + ":" + name].Value : null;

            if (String.IsNullOrEmpty(configurationValue))
                configurationValue = defaultValue;

            return configurationValue;
        }

        private void SetApplicationSetting(String name, String value)
        {
            Configuration configuration = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
            if (!configuration.AppSettings.Settings.AllKeys.Contains(this.Prefix + ":" + name))
                configuration.AppSettings.Settings.Add(this.Prefix + ":" + name, "");
            
            configuration.AppSettings.Settings[this.Prefix + ":" + name].Value = value;
            configuration.Save(ConfigurationSaveMode.Modified);
        }

        #endregion
    }
}
