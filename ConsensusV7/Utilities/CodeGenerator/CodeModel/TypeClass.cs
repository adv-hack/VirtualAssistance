using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeGenerator.CodeModel
{
    /// <summary>
    ///     Represents a class runtime type 
    /// </summary>
    public abstract class TypeClass : TypeStruct
    {
        #region properties

        /// <summary>
        ///     Gets the type of code object being declared (class, struct, interface, etc).
        /// </summary>
        public override String DeclarationType
        {
            get { return "class"; }
        }

        /// <summary>
        ///     Gets the abstraction of the class.
        /// </summary>
        public virtual CSharpAbstraction TypeAbstraction
        {
            get { return CSharpAbstraction.None; }
        }

        /// <summary>
        ///     Gets the name of the base-type from which, this type is derived.
        /// </summary>
        public virtual String TypeInheritence
        {
            get { return null; }
        }

        /// <summary>
        ///     Gets the inheritence chain defined within the type declaration
        /// </summary>
        public sealed override String DeclarationInheritence
        {
            get { return this.TypeInheritence + (String.IsNullOrEmpty(this.TypeInheritence) || String.IsNullOrEmpty(base.DeclarationInheritence) ? "" : ", ") + base.DeclarationInheritence; }
        }

        #endregion

        #region methods

        /// <summary>
        ///     Generates the runtime type declaration
        /// </summary>
        /// <param name="output">
        ///     The string builder instance to which all generated code is appended.
        /// </param>
        protected override void GenerateDeclaration(StringBuilder output)
        {
            output.Append("    ");
            output.Append(this.TypeModifier.ToString().ToLower() + " ");
            if (this.TypePartial) { output.Append("partial "); }
            output.Append(this.TypeAbstraction == CSharpAbstraction.None ? "" : this.TypeAbstraction.ToString().ToLower() + " ");
            output.Append(this.DeclarationType.ToLower() + " ");
            output.Append(this.DeclarationName);
            output.Append(String.IsNullOrEmpty(this.DeclarationInheritence) ? "" : " : " + this.DeclarationInheritence);
            output.Append(this.DeclarationConstraint);
            output.AppendLine();
        }

        #endregion
    }
}
