using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeGenerator.CodeModel
{
    /// <summary>
    ///     Defines the scenarios in which a project type will be generated and written to the disk
    /// </summary>
    public enum ProjectGeneration
    {
        /// <summary>
        ///     The project type is always generated and its content is written to the disk, overwriting any existing file.
        /// </summary>
        Always = 0,

        /// <summary>
        ///     The project type is generated only if the target file does not already exist.  Any existing file is left untouched.
        /// </summary>
        Missing = 1
    }
}
