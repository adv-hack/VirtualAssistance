using System;
using System.Collections.Generic;
using System.Linq;

namespace Consensus.Activities
{
    /// <summary>
    ///     Encapsulates the <see cref="ActivityXrefRecord" /> with standardised business rules.
    /// </summary>
    public partial class LocalActivityXrefModel
    {
        public ActivityReferenceTypes ActivityReferenceType
        {
            get { return this.Type.ConvertTo<ActivityReferenceTypes>(ActivityReferenceTypes.Other); }
            set { this.Type = value.ConvertTo<Int32>().ConvertTo<Byte>(0); }

        }
    }
}
