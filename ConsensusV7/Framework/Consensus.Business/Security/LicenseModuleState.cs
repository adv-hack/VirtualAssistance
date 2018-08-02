using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Consensus.Security
{
    public class LicenseModuleState
    {
        public LicenseModules Module
        {
            get;
            set;
        }

        public String ModuleDescription
        {
            get { return this.Module.ConvertTo<String>(); }
        }

        public Boolean Enabled
        {
            get;
            set;
        }
    }
}
