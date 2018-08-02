using System;
using System.Collections.Generic;
using System.Linq;

namespace Consensus.UserInterface
{
    /// <summary>
    ///     Encapsulates the <see cref="ScreenObjectDisplayRecord" /> with standardised business rules.
    /// </summary>
    public partial class LocalScreenObjectDisplayModel
    {
        /// <summary>
        ///     Gets or sets the visibility mode of the screen object
        /// </summary>
        public ScreenObjectVisibility Visibility
        {
            get { return this.ModifiedData.Display.ConvertTo<Int32>().ConvertTo<ScreenObjectVisibility>(); }
            set { this.ModifiedData.Display = value.ConvertTo<Int32>().ConvertTo<Byte>(); }
        }
    }
}
