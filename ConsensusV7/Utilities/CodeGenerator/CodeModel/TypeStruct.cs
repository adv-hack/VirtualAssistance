using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeGenerator.CodeModel
{
    /// <summary>
    ///     Represents a struct runtime type 
    /// </summary>
    public abstract class TypeStruct : TypeInterface
    {
        #region properties

        /// <summary>
        ///     Gets the type of code object being declared (class, struct, interface, etc).
        /// </summary>
        public override String DeclarationType
        {
            get { return "struct"; }
        }

        #endregion

        #region methods

        /// <summary>
        ///     Generates the body of the runtime type
        /// </summary>
        /// <param name="output">
        ///     The string builder instance to which all generated code is appended.
        /// </param>
        protected override void GenerateContent(StringBuilder output)
        {
            StringBuilder regionBuilder = new StringBuilder();
            this.GenerateRegion<MemberField>(regionBuilder, "fields");
            this.GenerateRegion<MemberProperty>(regionBuilder, "properties");
            this.GenerateRegion<MemberConstructor>(regionBuilder, "constructors");
            this.GenerateRegion<MemberMethod>(regionBuilder, "methods");
            this.GenerateRegion<MemberImplementor>(regionBuilder, "implementation");
            output.Append(regionBuilder.ToString());
        }

        #endregion
    }
}
