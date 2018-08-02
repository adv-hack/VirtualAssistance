using Microsoft.Build.Execution;
using Microsoft.Build.Framework;
using Microsoft.Build.Logging;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Consensus.CodeGenerator
{
    public class GeneratedBuildTask : Task
    {
        #region fields

        /// <summary>
        ///     The path of the visual studio project to be built.
        /// </summary>
        private String _projectFile;

        /// <summary>
        ///     The path of the compiled library.
        /// </summary>
        private String _projectOutput;

        /// <summary>
        ///     The types compiled within the library.
        /// </summary>
        private Type[] _projectTypes;

        #endregion

        #region properties

        /// <summary>
        ///     Gets the path of the visual studio project to be built. 
        /// </summary>
        public String ProjectFile
        {
            get { return _projectFile; }
        }

        /// <summary>
        ///     Gets the path of the compiled library.
        /// </summary>
        public String ProjectOutput
        {
            get { return _projectOutput; }
            private set { _projectOutput = value; }
        }

        /// <summary>
        ///     Gets the types compiled within the library.
        /// </summary>
        public Type[] ProjectTypes
        {
            get { return _projectTypes; }
            private set { _projectTypes = value; }
        }

        /// <summary>
        ///     Gets the name of the task
        /// </summary>
        public override String Name
        {
            get { return "Compiling " + this.ProjectFile; }
        }

        #endregion

        #region constructor

        /// <summary>
        ///     Creates a new build task to compile a visual studio project.
        /// </summary>
        public GeneratedBuildTask(String projectFile)
        {
            _projectFile = projectFile;
        }
        
        #endregion

        #region methods

        protected override void ExecuteTask()
        {
            // Create the build logger
            List<ConsoleLogger> loggers = new List<ConsoleLogger>();
            loggers.Add(new ConsoleLogger(LoggerVerbosity.Normal, new WriteHandler(this.Message), null, null));

            // Define the build properties
            Dictionary<String, String> properties = new Dictionary<String, String>();
            properties["Configuration"] = "Release";
            //properties["WarningLevel"] = "0"; // This would suppress all warnings - not necessary..
            properties["NoWarn"] = "1572;1573;1574;1734;1735;1591"; // Lose common XML comment related warnings.

            // Define the build parameters
            BuildParameters parameters = new BuildParameters();
            //parameters.DetailedSummary = true;
            parameters.OnlyLogCriticalEvents = false;
            parameters.DetailedSummary = false;
            parameters.Loggers = loggers;

            // Execute the build
            BuildRequestData request = new BuildRequestData(this.ProjectFile, properties, null, new String[] { "Rebuild" }, null);
            TargetResult result = BuildManager.DefaultBuildManager.Build(parameters, request).ResultsByTarget["Rebuild"];
            if (result.ResultCode == TargetResultCode.Failure)
                throw new Exception("Build Failure");

            // Load the resulting assembly from the build
            this.ProjectOutput = result.Items[0].ItemSpec;
            AppDomain.CurrentDomain.AssemblyResolve += this.CurrentDomain_AssemblyResolve;
            Assembly assembly = Assembly.LoadFile(this.ProjectOutput);
            this.ProjectTypes = assembly.GetTypes();
        }

        private Assembly CurrentDomain_AssemblyResolve(Object sender, ResolveEventArgs args)
        {
            Assembly assembly = AppDomain.CurrentDomain.GetAssemblies().FirstOrDefault(ass => AssemblyName.ReferenceMatchesDefinition(ass.GetName(), new AssemblyName(args.Name)));
            if (assembly == null)
            {
                String assemblyPath = Path.GetDirectoryName(this.ProjectOutput);
                String assemblyFile = Directory.GetFiles(assemblyPath, "*.dll").FirstOrDefault(file => AssemblyName.ReferenceMatchesDefinition(AssemblyName.GetAssemblyName(file), new AssemblyName(args.Name)));
                if (!String.IsNullOrEmpty(assemblyFile) && File.Exists(assemblyFile))
                    assembly = AppDomain.CurrentDomain.Load(File.ReadAllBytes(assemblyFile));
            }
            return assembly;
        }

        #endregion
    }
}
