using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Consensus.CodeGenerator
{
    public class CSharpProperty : CSharpMember
    {
        #region properties

        /// <summary>
        ///     Gets or sets the abstraction of the property.
        /// </summary>
        public CSharpAbstractions PropertyAbstraction { get; set; }

        /// <summary>
        ///     Gets or sets the data type of the property.
        /// </summary>
        public String PropertyType { get; set; }

        /// <summary>
        ///     Gets or sets the accessor which reads the property value.
        /// </summary>
        public CSharpAccessor PropertyGetter { get; set; }

        /// <summary>
        ///     Gets or sets the accessor which writes the property value.
        /// </summary>
        public CSharpAccessor PropertySetter { get; set; }

        #endregion

        #region constructor

        /// <summary>
        ///     Initialises a new <see cref="CSharpProperty" /> instance
        /// </summary>
        /// <param name="type">
        ///     Sets the generated runtime type, in which this member is defined.
        /// </param>
        public CSharpProperty(GeneratedType type) : base(type)
        {
        }

        #endregion
    }
}
