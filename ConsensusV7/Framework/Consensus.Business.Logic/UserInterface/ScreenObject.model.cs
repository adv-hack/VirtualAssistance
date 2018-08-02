using System;
using System.Collections.Generic;
using System.Linq;

namespace Consensus.UserInterface
{
    /// <summary>
    ///     Encapsulates the <see cref="ScreenObjectRecord" /> with standardised business rules.
    /// </summary>
    public partial class LocalScreenObjectModel
    {
        /// <summary>
        ///     Gets or sets the visibility mode of the screen object
        /// </summary>
        public ScreenObjectVisibility Visibility
        {
            get { return this.ModifiedData.Display.ConvertTo<Int32>().ConvertTo<ScreenObjectVisibility>(); }
            set { this.ModifiedData.Display = value.ConvertTo<Int32>().ConvertTo<Byte>(); }
        }

        /// <summary>
        ///     Gets or sets the visibility mode of the screen object
        /// </summary>
        public ScreenObjectRequirement Requirement
        {
            get { return this.ModifiedData.Requirement.ConvertTo<Int32>().ConvertTo<ScreenObjectRequirement>(); }
            set { this.ModifiedData.Requirement = value.ConvertTo<Int32>().ConvertTo<Byte>(); }
        }
    }
}
