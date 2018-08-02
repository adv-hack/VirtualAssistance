using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Consensus.CodeGenerator
{
    public abstract class CSharpMember
    {
        #region fields

        /// <summary>
        ///     The generated runtime type, in which this member is defined.
        /// </summary>
        private GeneratedType _type;

        #endregion

        #region properties

        /// <summary>
        ///     Gets the generated runtime type, in which this member is defined.
        /// </summary>
        public GeneratedType Type
        {
            get { return _type; }
        }

        /// <summary>
        ///     Gets the name of the member.
        /// </summary>
        public String Name { get; set; }

        /// <summary>
        ///     Gets the xml documentation summary for the member.
        /// </summary>
        public String XmlSummary { get; set; }

        /// <summary>
        ///     Gets the xml documentation remarks for the member.
        /// </summary>
        public String XmlRemarks { get; set; }

        /// <summary>
        ///     Gets or sets the attributes that are rendered for the member
        /// </summary>
        public String[] Attributes { get; set; }

        #endregion

        #region constructor

        /// <summary>
        ///     Initialises a new <see cref="CSharpMember" /> instance
        /// </summary>
        /// <param name="type">
        ///     Sets the generated runtime type, in which this member is defined.
        /// </param>
        public CSharpMember(GeneratedType type)
        {
            _type = type;
        }

        #endregion
    }
}
