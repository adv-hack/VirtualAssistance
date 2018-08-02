using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Consensus.CodeGenerator
{
    public class GeneratorTransfer : Task
    {
        #region fields

        /// <summary>
        ///     Specifies whether the transfer is pre-generation.
        /// </summary>
        private Boolean _preGeneration;

        /// <summary>
        ///     The location of the temporary files.
        /// </summary>
        private String _temporaryLocation;

        #endregion

        #region properties

        /// <summary>
        ///    Gets whether the transfer is pre-generation.
        /// </summary>
        public Boolean PreGeneration
        {
            get { return _preGeneration; }
        }

        /// <summary>
        ///    Gets the location of the temporary files.
        /// </summary>
        public String TemporaryLocation
        {
            get { return _temporaryLocation; }
        }

        /// <summary>
        ///     Gets the name of the transfer task.
        /// </summary>
        public override String Name
        {
            get { return this.PreGeneration ? "Transfer solution files to temporary location" : "Transfering solution files to development directories"; }
        }
        
        #endregion

        #region constructors

        /// <summary>
        ///     Initialises a new <see cref="GeneratorTransfer" /> instance.
        /// </summary>
        public GeneratorTransfer(String temporaryLocation, Boolean preGeneration)
        {
            _temporaryLocation = temporaryLocation;
            _preGeneration = preGeneration;
        }

        #endregion

        #region methods
        
        /// <summary>
        ///     Executes the task
        /// </summary>
        protected override void ExecuteTask()
        {
            if (this.PreGeneration)
                this.TransferFilesToTemp();
            else
                this.TransferFilesFromTemp();
        }

        private void TransferFilesToTemp()
        {
            // Delete the temporary directory, if it already exists
            if (Directory.Exists(this.TemporaryLocation))
                Directory.Delete(this.TemporaryLocation, true);
            
            // Create the temporary location
            Directory.CreateDirectory(this.TemporaryLocation);

            // Locate the root of the solution
            DirectoryInfo rootDirectory = new DirectoryInfo(".");
            while (rootDirectory != null && !rootDirectory.GetFiles().Any(file => String.Equals(file.Extension, ".sln", StringComparison.OrdinalIgnoreCase)))
                rootDirectory = rootDirectory.Parent;
            if (rootDirectory == null)
                throw new FileNotFoundException("Could not locate root of solution!");

            // Copy the framework files to the temporary location
            this.TransferFiles(false, Path.Combine(rootDirectory.FullName, "framework"), this.TemporaryLocation);
        }

        private void TransferFilesFromTemp()
        {
            // Locate the root of the solution
            DirectoryInfo rootDirectory = new DirectoryInfo(".");
            while (rootDirectory != null && !rootDirectory.GetFiles().Any(file => String.Equals(file.Extension, ".sln", StringComparison.OrdinalIgnoreCase)))
                rootDirectory = rootDirectory.Parent;
            if (rootDirectory == null)
                throw new FileNotFoundException("Could not locate root of solution!");

            // Copy the temporary files to the framework
            this.TransferFiles(true, Path.Combine(this.TemporaryLocation, "framework"), rootDirectory.FullName);
        }

        private void TransferFiles(Boolean conditional, String sourceDirectory, String targetDirectory)
        {
            targetDirectory = Path.Combine(targetDirectory, Path.GetFileName(sourceDirectory));
            if (!Directory.Exists(targetDirectory))
                Directory.CreateDirectory(targetDirectory);

            foreach (DirectoryInfo subdirectory in new DirectoryInfo(sourceDirectory).GetDirectories())
                this.TransferFiles(conditional, subdirectory.FullName, targetDirectory);

            foreach (FileInfo file in new DirectoryInfo(sourceDirectory).GetFiles())
            {
                Boolean processFile = false;
                processFile = processFile || String.Equals(file.Extension, ".cs", StringComparison.OrdinalIgnoreCase);
                processFile = processFile || String.Equals(file.Extension, ".csproj", StringComparison.OrdinalIgnoreCase);
                processFile = processFile || String.Equals(file.Extension, ".sql", StringComparison.OrdinalIgnoreCase);
                processFile = processFile || String.Equals(file.Extension, ".sqlproj", StringComparison.OrdinalIgnoreCase);
                if (processFile)
                {
                    if (conditional)
                    {
                        String sourceContent = File.ReadAllText(file.FullName);
                        String targetFilePath = Path.Combine(targetDirectory, file.Name);
                        Boolean overwrite = !File.Exists(targetFilePath);
                        if (!overwrite)
                        {
                            String targetContent = File.ReadAllText(targetFilePath);
                            overwrite = !String.Equals(sourceContent, targetContent);
                        }

                        if (overwrite)
                            File.WriteAllText(targetFilePath, sourceContent);
                    }
                    else
                    {
                        file.CopyTo(Path.Combine(targetDirectory, file.Name));
                    }
                }
            }
        }

        #endregion
    }
}
