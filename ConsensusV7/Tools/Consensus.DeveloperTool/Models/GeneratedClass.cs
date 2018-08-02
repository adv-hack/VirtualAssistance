using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Consensus.CodeGenerator
{
    public abstract class GeneratedClass : GeneratedStruct
    {
        #region properties

        /// <summary>
        ///     Gets the declaration type of the generated runtime type.
        /// </summary>
        public override CSharpTypes DeclarationType
        {
            get { return CSharpTypes.Class; }
        }

        /// <summary>
        ///     Gets the base class of the generated runtime type.
        /// </summary>
        public virtual String TypeBase
        {
            get { return null; }
        }

        /// <summary>
        ///     Gets the abstraction of the generated runtime type.
        /// </summary>
        public virtual CSharpAbstractions TypeAbstraction
        {
            get { return CSharpAbstractions.None; }
        }

        #endregion

        #region constructors

        /// <summary>
        ///     Initialises a new <see cref="GeneratedClass" /> instance.
        /// </summary>
        /// <param name="taskList">
        ///     Sets the project, in which this runtime type is included.
        /// </param>
        public GeneratedClass(GeneratedProject project) : base(project)
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
            List<String> inheritanceChain = new List<String>();
            if (!String.IsNullOrEmpty(this.TypeBase))
                inheritanceChain.Add(this.TypeBase);
            if (this.TypeInterfaces != null)
                inheritanceChain.AddRange(this.TypeInterfaces);
            
            writer.Write("    ");
            writer.Write(this.TypeModifier.ToString().ToLower().Replace("_", " ") + " ");
            writer.Write(this.TypeAbstraction == CSharpAbstractions.None ? "" : this.TypeAbstraction.ConvertTo<String>().ToLower() + " ");
            writer.Write(this.TypeIsPartial ? "partial " : "");
            writer.Write(this.DeclarationType.ToString().ToLower() + " ");
            writer.Write(this.DeclarationName);
            writer.Write(inheritanceChain.Any() ? " : " + String.Join(", ", inheritanceChain) : "");
            writer.Write(this.TypeGenerics == null || !this.TypeGenerics.Any() ? "" : String.Join("", this.TypeGenerics.Select(generic => generic.GenericConstraints == null || !generic.GenericConstraints.Any() ? "" : " where " + generic.GenericName + " : " + String.Join(", ", generic.GenericConstraints))));
        }

        #endregion
    }
}
