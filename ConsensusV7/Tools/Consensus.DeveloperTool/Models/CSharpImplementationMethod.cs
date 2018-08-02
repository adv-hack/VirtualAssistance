using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Consensus.CodeGenerator
{
    public class CSharpImplementationMethod : CSharpImplementation
    {
        #region properties

        /// <summary>
        ///     Gets or sets the returns section of the xml documentation.
        /// </summary>
        public String XmlReturns { get; set; }

        /// <summary>
        ///     Gets or sets the interface that the method is defined on.
        /// </summary>
        public String MethodInterface { get; set; }

        /// <summary>
        ///     Gets or sets the data type that is returned by the method
        /// </summary>
        public String MethodType { get; set; }

        /// <summary>
        ///     Gets or sets the parameters for the method.
        /// </summary>
        public CSharpParameter[] MethodParameters { get; set; }

        /// <summary>
        ///     Gets or sets the generic parameters for the method.
        /// </summary>
        public CSharpGeneric[] MethodGenerics { get; set; }

        /// <summary>
        ///     Gets or sets the code for the method.
        /// </summary>
        public String[] MethodCode
        {
            get
            {
                String methodCode = "";
                if (this.MethodType != null && !String.Equals(this.MethodType, "Void", StringComparison.OrdinalIgnoreCase))
                    methodCode += "return ";
                methodCode += "this." + this.Name;
                if (this.MethodGenerics.Length != 0)
                    methodCode += "<" + String.Join(", ", this.MethodGenerics.Select(gen => gen.GenericName)) + ">";
                methodCode += "(";
                if (this.MethodParameters.Length != 0)
                    methodCode += String.Join(", ", this.MethodParameters.Select(param => param.ParameterName));
                methodCode += ");";

                return new String[] { methodCode };
            }
        }

        #endregion

        #region constructor

        /// <summary>
        ///     Initialises a new <see cref="CSharpImplementationMethod" /> instance
        /// </summary>
        /// <param name="type">
        ///     Sets the generated runtime type, in which this member is defined.
        /// </param>
        public CSharpImplementationMethod(GeneratedType type) : base(type)
        {
        }

        #endregion
    }
}
