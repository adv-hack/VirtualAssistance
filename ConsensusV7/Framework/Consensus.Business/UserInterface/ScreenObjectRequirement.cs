using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Consensus.UserInterface
{
    public enum ScreenObjectRequirement
    {
        Optional,

        OptionalEnforced,

        Recommended,

        RecommendedEnforced,

        Mandatory,

        MandatoryEnforced
    }
}
