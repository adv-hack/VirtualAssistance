using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Consensus.CodeGenerator
{
    public class CSharpField : CSharpMember
    {
        #region properties

        /// <summary>
        ///     Gets or sets the instantiation flags for the field.
        /// </summary>
        public CSharpFieldFlags FieldFlags { get; set; }

        /// <summary>
        ///     Gets or sets the access modifier for the field.
        /// </summary>
        public CSharpModifiers FieldModifier { get; set; }

        /// <summary>
        ///     Gets or sets the data type of the field.
        /// </summary>
        public String FieldType { get; set; }

        /// <summary>
        ///     Gets or sets the initial value for the field.
        /// </summary>
        public String FieldValue { get; set; }

        #endregion

        #region constructor

        /// <summary>
        ///     Initialises a new <see cref="CSharpField" /> instance
        /// </summary>
        /// <param name="type">
        ///     Sets the generated runtime type, in which this member is defined.
        /// </param>
        public CSharpField(GeneratedType type) : base(type)
        {
        }

        #endregion
    }
}
