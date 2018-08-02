using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Consensus.CodeGenerator
{
    public class CSharpMethod : CSharpMember
    {
        #region properties

        /// <summary>
        ///     Gets or sets the returns section of the xml documentation.
        /// </summary>
        public String XmlReturns { get; set; }

        /// <summary>
        ///     Gets or sets the access modifier of the method.
        /// </summary>
        public CSharpModifiers MethodModifier { get; set; }

        /// <summary>
        ///     Gets or sets the abstraction of the method.
        /// </summary>
        public CSharpAbstractions MethodAbstraction { get; set; }

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
        public String[] MethodCode { get; set; }

        #endregion

        #region constructor

        /// <summary>
        ///     Initialises a new <see cref="CSharpMethod" /> instance
        /// </summary>
        /// <param name="type">
        ///     Sets the generated runtime type, in which this member is defined.
        /// </param>
        public CSharpMethod(GeneratedType type) : base(type)
        {
        }

        #endregion
    }
}
