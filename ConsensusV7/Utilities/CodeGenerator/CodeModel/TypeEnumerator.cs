using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeGenerator.CodeModel
{
    /// <summary>
    ///     Represents an enumerator runtime type 
    /// </summary>
    public abstract class TypeEnumerator : Type
    {
        #region properties

        /// <summary>
        ///     Gets the enumerations defined within this type.
        /// </summary>
        public abstract IEnumerable<MemberEnumeration> MemberEnumerations
        { 
            get;
        }

        /// <summary>
        ///     Gets the members included within this type.
        /// </summary>
        public sealed override IEnumerable<Member> Members
        {
            get { return this.MemberEnumerations; }
        }

        /// <summary>
        ///     Gets the type of code object being declared (class, struct, interface, etc).
        /// </summary>
        public sealed override String DeclarationType
        {
            get { return "enum"; }
        }

        /// <summary>
        ///     Gets the declared name of the type.
        /// </summary>
        public sealed override String DeclarationName
        {
            get { return this.TypeName; }
        }

        /// <summary>
        ///     Gets or sets if the enumerator is flagged
        /// </summary>
        public Boolean IsFlagged { get; set; }

        #endregion

        #region methods

        /// <summary>
        ///     Generates the body of the runtime type
        /// </summary>
        /// <param name="output">
        ///     The string builder instance to which all generated code is appended.
        /// </param>
        protected sealed override void GenerateContent(StringBuilder output)
        {
            MemberEnumeration[] members = this.MemberEnumerations.ToArray();

            for (Int32 index = 0; index < members.Length; index++)
            {
                // Output the enumeration
                members[index].Generate(output);

                // Output the enumeration initialiser
                output.Append(" = ");
                output.Append(this.IsFlagged ? "1 << " : "");
                output.Append(index);
                output.Append(index == members.Length - 1 ? "" : ",");
                output.AppendLine();

                // Output an additional line between each enumeration
                if (index != members.Length - 1)
                    output.AppendLine();
            }
        }

        #endregion
    }
}
