using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Consensus.Security
{
    [AttributeUsage(AttributeTargets.Class)]
    public class LicenseModuleRestrictionAttribute : Attribute
    {
        #region fields

        /// <summary>
        ///     The collection of modules to which the current class is restricted.
        /// </summary>
        private LicenseModules[] _modules;

        #endregion

        #region properties

        /// <summary>
        ///    Gets the collection of modules to which the current class is restricted.
        /// </summary>
        public LicenseModules[] Modules
        {
            get { return _modules; }
        }

        #endregion

        #region constructor

        /// <summary>
        ///     Restricts the class so that access is permitted only if one of the specified modules has been licensed.
        /// </summary>
        /// <param name="modules">
        ///     The collection of modules which enable access to this class.
        /// </param>
        public LicenseModuleRestrictionAttribute(params LicenseModules[] modules)
        {
            _modules = modules;
        }

        #endregion
    }
}
