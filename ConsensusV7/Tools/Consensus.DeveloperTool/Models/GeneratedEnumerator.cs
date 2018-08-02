using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Consensus.CodeGenerator
{
    /// <summary>
    ///     Represents a generated enumerator.
    /// </summary>
    public abstract class GeneratedEnumerator : GeneratedType
    {
        #region properties

        /// <summary>
        ///     Gets the declaration type of the generated runtime type.
        /// </summary>
        public override CSharpTypes DeclarationType
        {
            get { return CSharpTypes.Enum; }
        }

        /// <summary>
        ///     Gets the enumerations that are defined within the enumerator.
        /// </summary>
        public abstract IEnumerable<CSharpEnumeration> TypeMembers
        {
            get;
        }

        /// <summary>
        ///     Gets whether the enumerator supports bitwise combinations.
        /// </summary>
        public virtual Boolean TypeIsFlagged
        {
            get { return false; }
        }

        #endregion

        #region constructors

        /// <summary>
        ///     Initialises a new <see cref="GeneratedEnumerator" /> instance.
        /// </summary>
        /// <param name="taskList">
        ///     Sets the project, in which this runtime type is included.
        /// </param>
        public GeneratedEnumerator(GeneratedProject project) : base(project)
        {
        }

        #endregion

        #region methods

        /// <summary>
        ///     Generates the type declaration signature.
        /// </summary>
        /// <param name="writer">
        ///     The text writer that outputs the content into the file.
        /// </param>
        protected override void GenerateDeclaration(StreamWriter writer)
        {
            // Output the flags attribute
            if (this.TypeIsFlagged)
            {
                writer.WriteLine("[Flags]");
                writer.Write("    ");
            }

            // Output the standard declaration
            base.GenerateDeclaration(writer);
        }

        /// <summary>
        ///     Generates the members within the runtime type.
        /// </summary>
        /// <param name="writer">
        ///     The text writer that outputs the content into the file.
        /// </param>
        protected override void GenerateMembers(StreamWriter writer)
        {
            // Validate that the members have been defined
            if (this.TypeMembers == null)
                return;

            // Iterate through each enumeration
            CSharpEnumeration[] enumerations = this.TypeMembers.ToArray();
            for (Int32 index = 0; index < enumerations.Length; index++)
            {
                // Output the enumeration xml documentation
                this.GenerateDocumentation(writer, true, "summary", enumerations[index].XmlSummary);
                this.GenerateDocumentation(writer, true, "remarks", enumerations[index].XmlRemarks);

                // Output the enumeration
                writer.Write("        ");
                writer.Write(enumerations[index].Name);
                writer.Write(this.TypeIsFlagged && index > 0 ? " = 1 << " + (index - 1).ToString() : " = " + (index).ToString());
                writer.Write(index < enumerations.Length - 1 ? "," : "");
                writer.Write(index < enumerations.Length - 1 ? Environment.NewLine : "");
                writer.WriteLine();
            }
        }

        #endregion
    }
}
