using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Consensus.CodeGenerator
{
    public class CSharpImplementationProperty : CSharpImplementation
    {
        #region properties

        /// <summary>
        ///     Gets or sets the interface that the method is defined on.
        /// </summary>
        public String PropertyInterface { get; set; }

        /// <summary>
        ///     Gets or sets the data type of the property.
        /// </summary>
        public String PropertyType { get; set; }

        /// <summary>
        ///     Gets or sets the unmapped type of the property.
        /// </summary>
        public String OriginalType { get; set; }

        /// <summary>
        ///     Gets or sets whether the get accessor is generated.
        /// </summary>
        public Boolean PropertyGetter { get; set; }

        /// <summary>
        ///     Gets or sets whether the set accessor is generated.
        /// </summary>
        public Boolean PropertySetter { get; set; }

        #endregion

        #region constructor

        /// <summary>
        ///     Initialises a new <see cref="CSharpImplementationProperty" /> instance
        /// </summary>
        /// <param name="type">
        ///     Sets the generated runtime type, in which this member is defined.
        /// </param>
        public CSharpImplementationProperty(GeneratedType type) : base(type)
        {
        }

        #endregion
    }
}
