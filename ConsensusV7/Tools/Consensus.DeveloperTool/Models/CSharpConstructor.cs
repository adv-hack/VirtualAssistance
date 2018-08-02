using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Consensus.CodeGenerator
{
    public class CSharpConstructor : CSharpMember
    {
        #region properties

        /// <summary>
        ///     Gets or sets the access modifier of the method.
        /// </summary>
        public CSharpModifiers ConstructorModifier { get; set; }

        /// <summary>
        ///     Gets or sets the parameters for the method.
        /// </summary>
        public CSharpParameter[] ConstructorParameters { get; set; }

        /// <summary>
        ///     Gets or sets the code for the method.
        /// </summary>
        public String[] ConstructorCode { get; set; }

        /// <summary>
        ///     Gets or sets the parameters to be passed to the base constructor.
        /// </summary>
        public String[] ConstructorBase { get; set; }

        #endregion

        #region constructor

        /// <summary>
        ///     Initialises a new <see cref="CSharpConstructor" /> instance
        /// </summary>
        /// <param name="type">
        ///     Sets the generated runtime type, in which this member is defined.
        /// </param>
        public CSharpConstructor(GeneratedType type) : base(type)
        {
        }

        #endregion
    }
}
