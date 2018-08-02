using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Consensus
{
    [AttributeUsage(AttributeTargets.Field)]
    public class EnumerationGuid : Attribute
    {
        #region fields

        /// <summary>
        ///     The unique identifier assigned to the enumeration.
        /// </summary>
        private Guid _guid;

        #endregion

        #region properties

        /// <summary>
        ///    Gets the unique identifier assigned to the enumeration.
        /// </summary>
        public Guid Guid
        {
            get { return _guid; }
        }

        #endregion

        #region constructors

        /// <summary>
        ///     Initialises a new <see cref="EnumerationGuid"/> instance with the specified <paramref name="guid" />.
        /// </summary>
        /// <param name="guid">
        ///     Assigns the specified guid to the enumeration.
        /// </param>
        public EnumerationGuid(String guid) : this(Guid.Parse(guid))
        {
        }

        /// <summary>
        ///     Initialises a new <see cref="EnumerationGuid"/> instance with the specified <paramref name="guid" />.
        /// </summary>
        /// <param name="guid">
        ///     Assigns the specified guid to the enumeration.
        /// </param>
        public EnumerationGuid(Guid guid)
        {
            _guid = guid;
        }

        #endregion
    }
}
